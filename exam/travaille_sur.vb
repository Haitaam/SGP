Imports System.Data.OleDb
Public Class travaille_sur
    Public etat As Integer

    Private Sub travaille_sur_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Gestion des Travaux"
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

        afficher_travail()
    End Sub
    Public Sub afficher_travail()
        connexion()
        requete = "select Tache.id_tache, nom_tache, Membre.id_membre, nom_membre, prenom_membre " & _
                  "from Tache, Membre,Travaille_sur " & _
                  "where Travaille_sur.id_tache = Tache.id_tache " & _
                  "and Travaille_sur.id_membre = Membre.id_membre;"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 100
        con.Close()
        Dim nombre As Integer = DataGridView1.Rows.Count
        cpt.Text = "Nombre des Travaux : " + nombre.ToString
        If (membre_form.type_operation.Text = "Ajouter") Then
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
        End If
        If (ressource_form.type_operation.Text = "Modifier") Then
            DataGridView1.Rows(Val(ressource_form.ligne_modifie.Text)).Selected = True
        End If
    End Sub
    Private Sub all_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Text = "Gestion des Travaux"
        Me.BackColor = Color.FromArgb(240, 240, 240)
        Me.Width = 1200
        Me.Height = 600
        Me.CenterToScreen()
        DataGridView1.Visible = False
        DataGridView2.Visible = True
        DataGridView2.Width = Me.Width - 40
        DataGridView2.Height = Me.Height - 120
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView2.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(49, 139, 122)
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(49, 139, 122)
        DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None
        DataGridView1.Visible = False
        afficher_travail_all()
    End Sub
    Public Sub afficher_travail_all()
        connexion()
        requete = "SELECT projet.id_projet, nom_projet, " & _
                  "facture.nom_client, date_facture, montant_facture, " & _
                  "Membre.id_membre, nom_membre, prenom_membre, " & _
                  "Tache.id_tache, nom_tache, " & _
                  "ressource.id_ressource, nom_ressource " & _
                  "FROM projet, facture, Membre, Tache, ressource, travaille_sur, Affectation " & _
                  "WHERE Affectation.id_tache = Tache.id_tache " & _
                  "AND Affectation.id_ressource = ressource.id_ressource " & _
                  "AND travaille_sur.id_tache = Tache.id_tache " & _
                  "AND travaille_sur.id_membre = Membre.id_membre " & _
                  "AND Tache.id_projet = projet.id_projet  " & _
                  "AND facture.id_projet = projet.id_projet  ;"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView2.DataSource = dt.DefaultView
        DataGridView2.Columns(0).Width = 100
        con.Close()
        Dim nombre As Integer = DataGridView2.Rows.Count
        cpt.Text = "Nombre des Travaux : " + nombre.ToString
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        travaille_sur_form.type_operation.Text = "Ajouter"
        travaille_sur_form.ShowDialog()
    End Sub

    Private Sub Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiser.Click
        afficher_travail()
        DataGridView2.Visible = False
        DataGridView1.Visible = True
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        Dim i As Integer = DataGridView1.CurrentCell.RowIndex
        Dim idt As String = DataGridView1.Rows(i).Cells(0).Value
        Dim idm As String = DataGridView1.Rows(i).Cells(2).Value
        Dim rep As MsgBoxResult
        rep = MsgBox("Etes-vous sûr de supprimer ce travail ? ", vbYesNo + vbQuestion, "Confirmation")
        If (rep = vbYes) Then
            connexion()
            requete = "delete from travaille_sur where id_tache = " + idt & _
                      "and id_membre = " + idm
            cmdsql()
            cmd.ExecuteNonQuery()
            con.Close()
            requete = "select * from travaille_sur order by id_tache"
            afficher_travail()
        End If
    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le nom chercher : ", "Recherche", "")
        connexion()
        requete = "SELECT Tache.id_tache, nom_tache, Membre.id_membre, nom_membre, prenom_membre " & _
                  "FROM Tache, Membre, travaille_sur " & _
                  "WHERE travaille_sur.id_tache = Tache.id_tache " & _
                  "AND travaille_sur.id_membre = Membre.id_membre " & _
                  "AND (ucase(Tache.nom_tache) LIKE '%" + nom_a_chercher.ToUpper + "%'" & _
                  "or ucase(Membre.prenom_membre) LIKE '%" + nom_a_chercher.ToUpper + "%'" & _
                  "or ucase(Membre.nom_membre) LIKE '%" + nom_a_chercher.ToUpper + "%')"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 100
        con.Close()
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Introuvable...", vbExclamation, "Message")
            afficher_travail()
        End If
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
        e.Graphics.DrawString("Gestion des traveaux", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 18
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 30
        If etat = 4 Then
            With e.Graphics
                '.DrawString("Id.P", font_tcolonne, Brushes.Black, cl, ln)
                .DrawString("Nom.P", font_tcolonne, Brushes.Black, cl, ln)
                .DrawString("Nom.c", font_tcolonne, Brushes.Black, cl + 150, ln)
                .DrawString("Date.F", font_tcolonne, Brushes.Black, cl + 220, ln)
                .DrawString("Montant", font_tcolonne, Brushes.Black, cl + 290, ln)
                .DrawString("Id.M", font_tcolonne, Brushes.Black, cl + 350, ln)
                .DrawString("Nom et", font_tcolonne, Brushes.Black, cl + 380, ln)
                .DrawString(" Prenom", font_tcolonne, Brushes.Black, cl + 430, ln)
                .DrawString("Id.T", font_tcolonne, Brushes.Black, cl + 480, ln)
                .DrawString("Nom.T", font_tcolonne, Brushes.Black, cl + 510, ln)
                .DrawString("Id.R", font_tcolonne, Brushes.Black, cl + 560, ln)
                .DrawString("Nom.R", font_tcolonne, Brushes.Black, cl + 620, ln)
            End With
        Else
            With e.Graphics
                .DrawString("Id tache", font_tcolonne, Brushes.Black, cl, ln)
                .DrawString("Nom tache", font_tcolonne, Brushes.Black, cl + 80, ln)
                .DrawString("Id membre", font_tcolonne, Brushes.Black, cl + 350, ln)
                .DrawString("Nom membre", font_tcolonne, Brushes.Black, cl + 430, ln)
                .DrawString("Prenom membre", font_tcolonne, Brushes.Black, cl + 550, ln)
            End With
        End If
        ln = ln + 50
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c3, c4, c5 As String
        Dim nld As Integer 'nld : nombre_de_ligne_du_datagrid
        If etat = 1 Then nld = DataGridView1.Rows.Count
        If etat = 2 Then nld = DataGridView2.Rows.Count
        If etat = 3 Then nld = DataGridView2.Rows.Count
        If etat = 4 Then nld = DataGridView2.Rows.Count
        For i = 0 To nld - 1
            If etat = 1 Then
                c1 = DataGridView1.Rows(i).Cells(0).Value
                c2 = DataGridView1.Rows(i).Cells(1).Value
                c3 = DataGridView1.Rows(i).Cells(2).Value
                c4 = DataGridView1.Rows(i).Cells(3).Value
                c5 = DataGridView1.Rows(i).Cells(4).Value
            Else
                c1 = DataGridView2.Rows(i).Cells(0).Value
                c2 = DataGridView2.Rows(i).Cells(1).Value
                c3 = DataGridView2.Rows(i).Cells(2).Value
                c4 = DataGridView2.Rows(i).Cells(3).Value
                c5 = DataGridView2.Rows(i).Cells(4).Value
            End If
            Dim c6 As String = ""
            Dim c7 As String = ""
            Dim c8 As String = ""
            Dim c9 As String = ""
            Dim c10 As String = ""
            Dim c11 As String = ""
            Dim c12 As String = ""
            If etat = 4 Then
                ' c1 = DataGridView2.Rows(i).Cells(0).Value
                c2 = DataGridView2.Rows(i).Cells(1).Value
                c3 = DataGridView2.Rows(i).Cells(2).Value
                c4 = DataGridView2.Rows(i).Cells(3).Value
                c5 = DataGridView2.Rows(i).Cells(4).Value
                c6 = DataGridView2.Rows(i).Cells(5).Value
                c7 = DataGridView2.Rows(i).Cells(6).Value
                c8 = DataGridView2.Rows(i).Cells(7).Value
                c9 = DataGridView2.Rows(i).Cells(8).Value
                c10 = DataGridView2.Rows(i).Cells(9).Value
                c11 = DataGridView2.Rows(i).Cells(10).Value
                c12 = DataGridView2.Rows(i).Cells(11).Value
            End If
            With e.Graphics
                ' .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 150, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 220, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 300, ln)
                If etat = 4 Then
                    .DrawString(c6, font_colonne, Brushes.Black, cl + 360, ln)
                    .DrawString(c7, font_colonne, Brushes.Black, cl + 390, ln)
                    .DrawString(c8, font_colonne, Brushes.Black, cl + 460, ln)
                    .DrawString(c9, font_colonne, Brushes.Black, cl + 490, ln)
                    .DrawString(c10, font_colonne, Brushes.Black, cl + 520, ln)
                    .DrawString(c11, font_colonne, Brushes.Black, cl + 560, ln)
                    .DrawString(c12, font_colonne, Brushes.Black, cl + 595, ln)
                End If
            End With
            ln = ln + 50
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("Gestion des traveaux", font_titre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ImprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerToolStripMenuItem.Click
        etat = 2
        Dim nom_tache As String
        nom_tache = InputBox("Entrez le nom du tache à chercher", "Imprimer liste des traveaux d'une tache", "Projet ")

        'liste des employés d'un service
        connexion()
        requete = "select Tache.id_tache, nom_tache, Membre.id_membre, nom_membre, prenom_membre " & _
                  "from Membre, Tache, travaille_sur " & _
                  "where travaille_sur.id_tache = Tache.id_tache " & _
                  "and travaille_sur.id_membre = Membre.id_membre " & _
                  "and Tache.nom_tache like '" + nom_tache + "'"
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

    Private Sub ImprimerLesAffectationsDuneRessourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerLesAffectationsDuneRessourceToolStripMenuItem.Click
        etat = 3
        Dim nom_tache As String
        nom_tache = InputBox("Entrez le nom du membre à chercher", "Imprimer liste des traveaux d'un Membre", "Projet ")

        connexion()
        requete = "select Tache.id_tache, nom_tache, Membre.id_membre, nom_membre " & _
                  "from travaille_sur, Tache, Membre " & _
                  "where travaille_sur.id_tache = Tache.id_tache " & _
                  "and travaille_sur.id_membre = Membre.id_membre " & _
                  "and Membre.nom_membre like '%" + nom_tache + "%'"

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
            MsgBox("Nom entré introuvable...", MsgBoxStyle.Information, "Message")
        Else
            'Imprimer
            DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
            PrintDocument1.DefaultPageSettings.Landscape = False
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub

    Private Sub ImprimerLesTraveausDetailléToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerLesTraveausDetailléToolStripMenuItem.Click
        etat = 4
        connexion()
        requete = "SELECT projet.id_projet, nom_projet, " & _
                  "facture.nom_client, date_facture, montant_facture, " & _
                  "Membre.id_membre, nom_membre, prenom_membre, " & _
                  "Tache.id_tache, nom_tache, " & _
                  "ressource.id_ressource, nom_ressource " & _
                  "FROM projet, facture, Membre, Tache, ressource, travaille_sur, Affectation " & _
                  "WHERE Affectation.id_tache = Tache.id_tache " & _
                  "AND Affectation.id_ressource = ressource.id_ressource " & _
                  "AND travaille_sur.id_tache = Tache.id_tache " & _
                  "AND travaille_sur.id_membre = Membre.id_membre " & _
                  "AND Tache.id_projet = projet.id_projet  " & _
                  "AND facture.id_projet = projet.id_projet  ;"

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
            MsgBox("Nom entré introuvable...", MsgBoxStyle.Information, "Message")
        Else
            'Imprimer
            DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
            PrintDocument1.DefaultPageSettings.Landscape = False
            PrintPreviewDialog1.ShowDialog()
        End If
    End Sub
    Private Sub DataGridView2_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick

    End Sub
End Class
