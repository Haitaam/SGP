Imports System.Data.OleDb
Public Class facture
    Public etat As Integer
    Private Sub facture_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Gestion des factures "
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

        afficher_facture()
    End Sub
    Public Sub afficher_facture()
        connexion()
        requete = "SELECT facture.id_facture, nom_client, projet.id_projet, nom_projet, description_projet, facture.date_facture, montant_facture " & _
                  "FROM facture, projet " & _
                  "WHERE facture.id_projet = projet.id_projet " & _
                  "ORDER BY facture.id_facture ASC;"

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 100
        con.Close()
        Dim nombre As Integer = DataGridView1.Rows.Count
        cpt.Text = "Nombre des facture : " + nombre.ToString
        If (membre_form.type_operation.Text = "Ajouter") Then
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
        End If
        If (tache_form.type_operation.Text = "Modifier") Then
            DataGridView1.Rows(Val(tache_form.ligne_modifie.Text)).Selected = True
        End If
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        facture_form.type_operation.Text = "Ajouter"
        facture_form.idf.Text = Nothing
        facture_form.nom.Text = Nothing
        facture_form.Datef.Text = Nothing
        facture_form.prix.Text = Nothing
        facture_form.ShowDialog()
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        Dim i As Integer = DataGridView1.CurrentCell.RowIndex
        Dim idf As String = DataGridView1.Rows(i).Cells(0).Value
        Dim idp As String = DataGridView1.Rows(i).Cells(2).Value
        Dim rep As MsgBoxResult
        rep = MsgBox("Etes-vous sûr de supprimer cette facture ? ", vbYesNo + vbQuestion, "Confirmation")
        If (rep = vbYes) Then
            connexion()
            requete = "delete from facture where id_projet = " + idp & _
                      "and id_facture = " + idf
            cmdsql()
            cmd.ExecuteNonQuery()
            con.Close()
            requete = "select * from facture order by id_projet"
            afficher_facture()
        End If
    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le nom de projet ou la date chercher : ", "Recherche", "")
        connexion()
        requete = "SELECT projet.id_projet, nom_projet, description_projet, facture.id_facture, nom_client, date_facture, montant_facture " & _
                  "FROM facture, projet " & _
                  "WHERE facture.id_projet = projet.id_projet " & _
                  "AND (UCASE(nom_projet) LIKE '%" & nom_a_chercher.ToUpper & "%' " & _
                  "OR UCASE(date_facture) LIKE '%" & nom_a_chercher.ToUpper & "%')"

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
            afficher_facture()
        End If
    End Sub

    Private Sub Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiser.Click
        afficher_facture()
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
        e.Graphics.DrawString("Liste des Factures", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 20
        With e.Graphics
            .DrawString("Id Facture", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Id projet", font_tcolonne, Brushes.Black, cl + 100, ln)
            .DrawString("Nom client ", font_tcolonne, Brushes.Black, cl + 200, ln)
            .DrawString("Date ", font_tcolonne, Brushes.Black, cl + 400, ln)
            .DrawString("Prix ", font_tcolonne, Brushes.Black, cl + 640, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c3, c4, c5 As String
        Dim nld As Integer 'nld : nombre_de_ligne_du_datagrid
        If etat = 1 Then nld = DataGridView1.Rows.Count
        If etat = 2 Then nld = DataGridView2.Rows.Count
        If etat = 3 Then nld = DataGridView2.Rows.Count
        For i = 0 To nld - 1
            If etat = 1 Then
                c1 = DataGridView1.Rows(i).Cells(0).Value
                c2 = DataGridView1.Rows(i).Cells(2).Value
                c3 = DataGridView1.Rows(i).Cells(1).Value
                c4 = DataGridView1.Rows(i).Cells(5).Value
                c5 = DataGridView1.Rows(i).Cells(6).Value
            Else
                c1 = DataGridView2.Rows(i).Cells(0).Value
                c2 = DataGridView2.Rows(i).Cells(2).Value
                c3 = DataGridView2.Rows(i).Cells(1).Value
                c4 = DataGridView2.Rows(i).Cells(5).Value
                c5 = DataGridView2.Rows(i).Cells(6).Value
            End If
            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 100, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 200, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 400, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 640, ln)
            End With
            ln = ln + 20
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("Facture", font_titre, Brushes.Black, cl, 1100)
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        facture_form.idf.Text = DataGridView1.Rows(i).Cells(0).Value.ToString
        facture_form.ancien_id.Text = DataGridView1.Rows(i).Cells(0).Value
        facture_form.nom.Text = DataGridView1.Rows(i).Cells(1).Value.ToString
        facture_form.id_projet.Text = DataGridView1.Rows(i).Cells(2).Value.ToString
        facture_form.prix.Text = DataGridView1.Rows(i).Cells(6).Value.ToString
        facture_form.Datef.Text = DataGridView1.Rows(i).Cells(5).Value.ToString
        facture_form.ligne_modifie.Text = i
        facture_form.type_operation.Text = "Modifier"
        facture_form.ShowDialog()
    End Sub

    Private Sub ImprimerUneFactureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerUneFactureToolStripMenuItem.Click
        etat = 2
        Dim nom_client As String
        nom_client = InputBox("Entrez le nom de client à chercher", "Imprimer les membres d’une équipe.", "Projet ")

        'liste des employés d'un service
        connexion()
        requete = "SELECT facture.id_facture, nom_client, projet.id_projet, nom_projet, description_projet, facture.date_facture, montant_facture " & _
                  "FROM facture, projet " & _
                  "WHERE facture.id_projet = projet.id_projet " & _
                  "and facture.nom_client like '" + nom_client + "'"
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

    Private Sub ImprimerLesFacturesDunProjetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerLesFacturesDunProjetToolStripMenuItem.Click
        etat = 2
        Dim nom_client As String
        nom_client = InputBox("Entrez le nom ou l'ID de projet à chercher", "Imprimer les membres d’une équipe.", "Projet ")

        'liste des employés d'un service
        connexion()
        requete = "SELECT facture.id_facture, nom_client, projet.id_projet, nom_projet, description_projet, facture.date_facture, montant_facture " & _
                  "FROM facture, projet " & _
                  "WHERE facture.id_projet = projet.id_projet " & _
                  "and (projet.id_projet like '" + nom_client + "'" & _
                  "or projet.nom_projet like '" + nom_client + "')"
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
End Class