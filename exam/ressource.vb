Imports System.Data.OleDb
Public Class ressource

    Private Sub ressource_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Gestion des ressources"
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

        afficher_ressource()
    End Sub
    Public Sub afficher_ressource()
        connexion()
        requete = "select * from ressource;"
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 100
        con.Close()
        Dim nombre As Integer = DataGridView1.Rows.Count
        cpt.Text = "Nombre des ressources : " + nombre.ToString
        If (membre_form.type_operation.Text = "Ajouter") Then
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
        End If
        If (ressource_form.type_operation.Text = "Modifier") Then
            DataGridView1.Rows(Val(ressource_form.ligne_modifie.Text)).Selected = True
        End If
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        ressource_form.idr.Text = DataGridView1.Rows(i).Cells(0).Value
        ressource_form.ancien_idservice.Text = DataGridView1.Rows(i).Cells(0).Value
        ressource_form.nom.Text = DataGridView1.Rows(i).Cells(1).Value
        ressource_form.description.Text = DataGridView1.Rows(i).Cells(2).Value ' Ajout de la troisième colonne
        ressource_form.ligne_modifie.Text = i
        ressource_form.type_operation.Text = "Modifier"
        ressource_form.ShowDialog()

    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        ressource_form.type_operation.Text = "Ajouter"
        ressource_form.idr.Text = Nothing
        ressource_form.nom.Text = Nothing
        ressource_form.description.Text = Nothing
        ressource_form.ShowDialog()
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        If (DataGridView1.Rows.Count = 0) Then
            MsgBox("Aucun ressource...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value
            Dim rep As MsgBoxResult
            rep = MsgBox("Etes-vous sûr de supprimer cette ressource : " + id + "? ", vbYesNo + vbQuestion, "Confirmation")
            If (rep = vbYes) Then
                connexion()
                requete = "delete from ressource where id_ressource = " + id
                cmdsql()
                cmd.ExecuteNonQuery()
                con.Close()
                requete = "select * from ressource order by id_ressource"
                afficher_ressource()
            End If
        End If
    End Sub

    Private Sub Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiser.Click
        afficher_ressource()
    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le nom à chercher : ", "Recherche", "")
        connexion()
        requete = "select * from ressource where " & _
                  "ucase(nom_ressource) like '%" + nom_a_chercher.ToUpper + "%'"
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

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
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
        e.Graphics.DrawString("Gestion des ressources", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 55
        With e.Graphics
            .DrawString("Id", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Nom ressource", font_tcolonne, Brushes.Black, cl + 30, ln)
            .DrawString("Description", font_tcolonne, Brushes.Black, cl + 220, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c3 As String
        For i = 0 To DataGridView1.Rows.Count - 1
            c1 = DataGridView1.Rows(i).Cells(0).Value
            c2 = DataGridView1.Rows(i).Cells(1).Value
            c3 = DataGridView1.Rows(i).Cells(2).Value
            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 30, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 220, ln)
            End With
            ln = ln + 40
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("Gestion des ressources", font_titre, Brushes.Black, cl, 1100)
    End Sub
End Class