Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Gestion des projets "
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

        afficher_service()

    End Sub

    Public Sub afficher_service()
        connexion()
        requete = "select * from projet"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 100
        con.Close()
        Dim nombre As Integer = DataGridView1.Rows.Count
        cpt.Text = "Nombre des projets : " + nombre.ToString
        If (Form2.type_operation.Text = "Ajouter") Then
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
        End If
        If (Form2.type_operation.Text = "Modifier") Then
            DataGridView1.Rows(Val(Form2.ligne_modifie.Text)).Selected = True
        End If
    End Sub

    Private Sub DataGridView1_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        Form2.id_projet.Text = DataGridView1.Rows(i).Cells(0).Value.ToString
        Form2.ancien_idprojet.Text = DataGridView1.Rows(i).Cells(0).Value
        Form2.nom_projet.Text = DataGridView1.Rows(i).Cells(1).Value.ToString
        Form2.description_projet.Text = DataGridView1.Rows(i).Cells(2).Value.ToString
        Form2.date_debut.Text = DataGridView1.Rows(i).Cells(3).Value.ToString
        Form2.date_fin.Text = DataGridView1.Rows(i).Cells(4).Value.ToString
        Form2.ligne_modifie.Text = i
        Form2.type_operation.Text = "Modifier"
        Form2.ShowDialog()
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
            .DrawString("id projet", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Nom projet", font_tcolonne, Brushes.Black, cl + 100, ln)
            .DrawString("description", font_tcolonne, Brushes.Black, cl + 280, ln)
            .DrawString("date de debut", font_tcolonne, Brushes.Black, cl + 480, ln)
            .DrawString("date fin", font_tcolonne, Brushes.Black, cl + 620, ln)
        End With
        ln = ln + 55
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c3, c4, c5 As String
        For i = 0 To DataGridView1.Rows.Count - 1
            c1 = DataGridView1.Rows(i).Cells(0).Value
            c2 = DataGridView1.Rows(i).Cells(1).Value
            c3 = DataGridView1.Rows(i).Cells(2).Value
            c4 = DataGridView1.Rows(i).Cells(3).Value
            c5 = DataGridView1.Rows(i).Cells(4).Value
            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 100, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 280, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 480, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 620, ln)
            End With
            ln = ln + 55
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("Gestion des Projets", font_titre, Brushes.Black, cl, 1100)
    End Sub
    Private Sub ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        Form2.type_operation.Text = "Ajouter"
        Form2.id_projet.Text = Nothing
        Form2.nom_projet.Text = Nothing
        Form2.description_projet.Text = Nothing
        Form2.date_debut.Text = Nothing
        Form2.date_fin.Text = Nothing
        Form2.ShowDialog()
    End Sub
    Private Sub supprimer_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        Form2.type_operation.Text = "Ajouter"
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucun projet...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer ce produit : " + id + "? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                connexion()
                requete = "delete from projet where id_projet = " + id
                cmdsql()
                cmd.ExecuteNonQuery()
                con.Close()
                requete = "select * from projet order by id_projet"
                afficher_service()
            End If
        End If
    End Sub

    Private Sub rechercher_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le nom ou ID à chercher : ", "Recherche", "")
        connexion()
        requete = "select * from projet where " & _
                  "ucase(nom_projet) like '%" + nom_a_chercher.ToUpper + "%'" & _
                  "or ucase(id_projet) like '%" + nom_a_chercher.ToUpper + "%'"
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

    Private Sub actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiser.Click
        afficher_service()
    End Sub
    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        DirectCast(PrintPreviewDialog1, Form).WindowState = FormWindowState.Maximized
        PrintDocument1.DefaultPageSettings.Landscape = False
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub ChoisirUneCategorieToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le type à chercher : ", "Recherche", "")
        connexion()
        requete = "select * from projet where " & _
            "type like '%" + nom_a_chercher + "%'"
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

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Imprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Imprimer.Click

    End Sub
End Class
