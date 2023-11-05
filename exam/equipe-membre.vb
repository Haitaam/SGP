Imports System.Data.OleDb
Public Class equipe_membre
    Public etat As Integer
    Private Sub equipe_membre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Equipe projet "
        Me.BackColor = Color.WhiteSmoke

        Me.Width = 1200
        Me.Height = 600
        Me.CenterToScreen()

        DataGridView1.Width = Me.Width - 40
        DataGridView1.Height = Me.Height - 220
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.DefaultCellStyle.Font = New Font("Arial", 14)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Black

        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.Black

        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None

        DataGridView1.DefaultCellStyle.BackColor = Color.Black
        DataGridView1.DefaultCellStyle.ForeColor = Color.White

        afficher_equipe_membre()
    End Sub

    Public Sub afficher_equipe_membre()
        connexion()
        requete = "select projet.id_projet, nom_projet, description_projet, Membre.id_membre, nom_membre, prenom_membre, Equipe_projet.role " & _
                    "from Membre, projet, Equipe_projet " & _
                    "where Equipe_projet.id_projet = projet.id_projet " & _
                    "and Equipe_projet.id_membre = Membre.id_membre"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 100
        con.Close()
        Dim nombre As Integer = DataGridView1.Rows.Count
        cpt.Text = "Nombre des membre : " + nombre.ToString

        If (membre_form.type_operation.Text = "Ajouter") Then
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
        End If
        If (tache_form.type_operation.Text = "Modifier") Then
            DataGridView1.Rows(Val(tache_form.ligne_modifie.Text)).Selected = True
        End If
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        equipe_membre_form.type_operation.Text = "Ajouter"
        equipe_membre_form.role.Text = Nothing
        equipe_membre_form.ShowDialog()
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        Dim i As Integer = DataGridView1.CurrentCell.RowIndex
        Dim idp As String = DataGridView1.Rows(i).Cells(0).Value
        Dim idm As String = DataGridView1.Rows(i).Cells(3).Value
        Dim rep As MsgBoxResult
        rep = MsgBox("Etes-vous sûr de supprimer ce projet ? ", vbYesNo + vbQuestion, "Confirmation")
        If (rep = vbYes) Then
            connexion()
            requete = "delete from Equipe_projet where id_projet = " + idp & _
                      "and id_membre = " + idm
            cmdsql()
            cmd.ExecuteNonQuery()
            con.Close()
            requete = "select * from Equipe_projet order by id_projet"
            afficher_equipe_membre()
        End If
    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le nom membre chercher : ", "Recherche", "")
        connexion()
        requete = "SELECT projet.id_projet, projet.nom_projet, projet.description_projet, Membre.id_membre, Membre.nom_membre, Membre.prenom_membre, Equipe_projet.role " & _
                  "FROM Membre, projet, Equipe_projet " & _
                  "WHERE Equipe_projet.id_projet = projet.id_projet " & _
                  "AND Equipe_projet.id_membre = Membre.id_membre " & _
                  "AND ucase(Membre.nom_membre) LIKE '%" + nom_a_chercher.ToUpper + "%'"


        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 100
        con.Close()
        If (DataGridView1.Rows.Count = 0) Then MsgBox("Introuvable...", vbExclamation, "Message")

    End Sub

    Private Sub Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiser.Click
        afficher_equipe_membre()
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        etat = 1
        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim font_titre As New Font("Arial", 12, FontStyle.Regular)
        Dim font_tcolonne As New Font("Arial", 10, FontStyle.Bold)
        Dim font_colonne As New Font("Arial", 10, FontStyle.Regular)
        Dim ln As Integer = 50
        Dim cl As Integer = 50
        e.Graphics.DrawString("Gestion des Projets", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 55
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 55
        With e.Graphics
            .DrawString("IdP", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Nom projet", font_tcolonne, Brushes.Black, cl + 30, ln)
            .DrawString("Description", font_tcolonne, Brushes.Black, cl + 270, ln)
            .DrawString("IdM", font_tcolonne, Brushes.Black, cl + 470, ln)
            .DrawString("Nom", font_tcolonne, Brushes.Black, cl + 500, ln)
            .DrawString("et prenom ", font_tcolonne, Brushes.Black, cl + 540, ln)
            .DrawString("Role", font_tcolonne, Brushes.Black, cl + 630, ln)
        End With
        ln = ln + 55
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c3, c4, c5, c6, c7 As String
        Dim nld As Integer 'nld : nombre_de_ligne_du_datagrid
        If etat = 1 Then nld = DataGridView1.Rows.Count
        If etat = 2 Then nld = DataGridView2.Rows.Count
        If etat = 3 Then nld = DataGridView2.Rows.Count
        For i = 0 To nld - 1
            If etat = 1 Then
                c1 = DataGridView1.Rows(i).Cells(0).Value
                c2 = DataGridView1.Rows(i).Cells(1).Value
                c3 = DataGridView1.Rows(i).Cells(2).Value
                c4 = DataGridView1.Rows(i).Cells(3).Value
                c5 = DataGridView1.Rows(i).Cells(4).Value
                c6 = DataGridView1.Rows(i).Cells(5).Value
                c7 = DataGridView1.Rows(i).Cells(6).Value
            Else
                c1 = DataGridView2.Rows(i).Cells(0).Value
                c2 = DataGridView2.Rows(i).Cells(1).Value
                c3 = DataGridView2.Rows(i).Cells(2).Value
                c4 = DataGridView2.Rows(i).Cells(3).Value
                c5 = DataGridView2.Rows(i).Cells(4).Value
                c6 = DataGridView2.Rows(i).Cells(5).Value
                c7 = DataGridView2.Rows(i).Cells(6).Value
            End If
            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 30, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 270, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 470, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 500, ln)
                .DrawString(c6, font_colonne, Brushes.Black, cl + 550, ln)
                .DrawString(c7, font_colonne, Brushes.Black, cl + 620, ln)
            End With
            ln = ln + 45
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("Gestion des Equipes", font_titre, Brushes.Black, cl, 1100)

    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        equipe_membre_form.id_projet.Text = DataGridView1.Rows(i).Cells(0).Value.ToString
        equipe_membre_form.ancien_id.Text = DataGridView1.Rows(i).Cells(0).Value
        equipe_membre_form.id_membre.Text = DataGridView1.Rows(i).Cells(3).Value.ToString
        equipe_membre_form.ancien_idm.Text = DataGridView1.Rows(i).Cells(3).Value
        equipe_membre_form.role.Text = DataGridView1.Rows(i).Cells(6).Value.ToString
        equipe_membre_form.ligne_modifie.Text = i
        equipe_membre_form.type_operation.Text = "Modifier"
        equipe_membre_form.ShowDialog()
    End Sub

    Private Sub ImprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerToolStripMenuItem.Click
        etat = 2
        Dim nom_equipe As String
        nom_equipe = InputBox("Entrez le id ou le nom du projet à chercher", "Imprimer les membres d’une équipe.", "Projet ")

        'liste des employés d'un service
        connexion()
        requete = "select projet.id_projet, nom_projet, description_projet, Membre.id_membre, nom_membre, prenom_membre, Equipe_projet.role " & _
                    "from Membre, projet, Equipe_projet " & _
                    "where (Equipe_projet.id_projet = projet.id_projet " & _
                    "and Equipe_projet.id_membre = Membre.id_membre) " & _
                    "and projet.id_projet like '" + nom_equipe + "'"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView2.DataSource = dt.DefaultView
        DataGridView2.Columns(0).Width = 100
        con.Close()
        Dim cpt As Integer = DataGridView2.Rows.Count()
        If cpt = 0 Then
            MsgBox("ID entré introuvable...", MsgBoxStyle.Information, "Message")
        Else
            'Imprimer
            DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
            PrintDocument1.DefaultPageSettings.Landscape = False
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub ImprimerLaListeDesÉquipesDunMembreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerLaListeDesÉquipesDunMembreToolStripMenuItem.Click
        etat = 3
        Dim nom_equipe As String
        nom_equipe = InputBox("Entrez le prenom ou le nom du membre à chercher", "Imprimer les membres d’une équipe.", "Projet ")

        'liste des employés d'un service
        connexion()
        requete = "select projet.id_projet, nom_projet, description_projet, Membre.id_membre, nom_membre, prenom_membre, Equipe_projet.role " & _
                    "from Membre, projet, Equipe_projet " & _
                    "where (Equipe_projet.id_projet = projet.id_projet " & _
                    "and Equipe_projet.id_membre = Membre.id_membre) " & _
                    "and Membre.nom_membre like '" + nom_equipe + "'"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView2.DataSource = dt.DefaultView
        DataGridView2.Columns(0).Width = 100
        con.Close()
        Dim cpt As Integer = DataGridView2.Rows.Count()
        If cpt = 0 Then
            MsgBox("ID entré introuvable...", MsgBoxStyle.Information, "Message")
        Else
            'Imprimer
            DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
            PrintDocument1.DefaultPageSettings.Landscape = False
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub
End Class