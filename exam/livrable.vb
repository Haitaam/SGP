Imports System.Data.OleDb
Public Class livrable
    Public etat As Integer

    Private Sub livrable_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Gestion des livrables"
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

        afficher_livrable()
    End Sub
    Public Sub afficher_livrable()
        connexion()
        requete = "select Livrable.id_livrable, nom_livrable,description_livrable,date_livrable, Tache.id_tache,nom_tache, date_debut, date_fin " & _
                  "from Livrable, Tache " & _
                  "where Livrable.id_tache = Tache.id_tache order by id_livrable"

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
            DataGridView1.Rows(Val(livrable_form.ligne_modifie.Text)).Selected = True
        End If
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        livrable_form.type_operation.Text = "Ajouter"
        livrable_form.idl.Text = Nothing
        livrable_form.noml.Text = Nothing
        livrable_form.descriptionl.Text = Nothing
        livrable_form.Datel.Text = Nothing
        livrable_form.ShowDialog()
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        Dim i As Integer = DataGridView1.CurrentCell.RowIndex
        Dim idl As String = DataGridView1.Rows(i).Cells(0).Value
        Dim idt As String = DataGridView1.Rows(i).Cells(4).Value
        Dim rep As MsgBoxResult
        rep = MsgBox("Etes-vous sûr de supprimer cette Livrable ? ", vbYesNo + vbQuestion, "Confirmation")
        If (rep = vbYes) Then
            connexion()
            requete = "delete from Livrable where id_livrable = " + idl & _
                      "and id_tache = " + idt
            cmdsql()
            cmd.ExecuteNonQuery()
            con.Close()
            requete = "select * from Livrable order by id_livrable"
            afficher_livrable()
        End If
    End Sub

    Private Sub Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiser.Click
        afficher_livrable()
    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le nom chercher : ", "Recherche", "")
        connexion()
        requete = "select Livrable.id_livrable, nom_livrable,description_livrable,date_livrable, Tache.id_tache, date_debut, date_fin " & _
                  "from Livrable, Tache " & _
                  "where Livrable.id_tache = Tache.id_tache " & _
                  "and ucase(Livrable.nom_livrable) LIKE '%" + nom_a_chercher.ToUpper + "%'"
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
            afficher_livrable()
        End If
    End Sub

    Private Sub ImprimerTousLesServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerTousLesServicesToolStripMenuItem.Click
        etat = 1
        Dim datee, dateee As String
        datee = DateTime.ParseExact(InputBox("Entrez la première date à chercher dans ce format : DD/MM/YYYY", "Imprimer liste des livrables entre deux dates"), "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo).ToString("yyyy-MM-dd")
        dateee = DateTime.ParseExact(InputBox("Entrez la deuxième date à chercher dans ce format : DD/MM/YYYY", "Imprimer liste des livrables entre deux dates"), "dd/MM/yyyy", System.Globalization.DateTimeFormatInfo.InvariantInfo).ToString("yyyy-MM-dd")

        connexion()

        requete = "SELECT Livrable.id_livrable, nom_livrable, description_livrable, Format(date_livrable, 'dd/MM/yyyy') AS date_livrable, Tache.id_tache, date_debut, date_fin " & _
                  "FROM Livrable INNER JOIN Tache ON Livrable.id_tache = Tache.id_tache " & _
                  "WHERE date_livrable BETWEEN #" & datee & "# AND #" & dateee & "# " & _
                  "ORDER BY id_livrable;"

        Dim da As New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 100
        con.Close()

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
        e.Graphics.DrawString("Gestion des Livrables", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 18
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 18
        With e.Graphics
            .DrawString("Id", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Nom Livrable", font_tcolonne, Brushes.Black, cl + 30, ln)
            .DrawString("Description", font_tcolonne, Brushes.Black, cl + 150, ln)
            .DrawString("Date", font_tcolonne, Brushes.Black, cl + 340, ln)
            .DrawString("Id Tache", font_tcolonne, Brushes.Black, cl + 450, ln)
            .DrawString("Date debut", font_tcolonne, Brushes.Black, cl + 520, ln)
            .DrawString("Date fin", font_tcolonne, Brushes.Black, cl + 620, ln)
        End With
        ln = ln + 18
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c3, c4, c5, c6, c7 As String
        Dim nld As Integer 'nld : nombre_de_ligne_du_datagrid
        If etat = 1 Then nld = DataGridView1.Rows.Count
        If etat = 2 Then nld = DataGridView2.Rows.Count
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
                c1 = DataGridView1.Rows(i).Cells(0).Value
                c2 = DataGridView1.Rows(i).Cells(1).Value
                c3 = DataGridView1.Rows(i).Cells(2).Value
                c4 = DataGridView1.Rows(i).Cells(3).Value
                c5 = DataGridView1.Rows(i).Cells(4).Value
                c6 = DataGridView1.Rows(i).Cells(5).Value
                c7 = DataGridView1.Rows(i).Cells(6).Value
            End If
            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 30, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 150, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 340, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 450, ln)
                .DrawString(c6, font_colonne, Brushes.Black, cl + 520, ln)
                .DrawString(c7, font_colonne, Brushes.Black, cl + 620, ln)
            End With
            ln = ln + 18
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("Gestion des Livrables", font_titre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ImprimerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerToolStripMenuItem.Click
        etat = 2
        Dim nom_tache As String
        nom_tache = InputBox("Entrez le nom du tache à chercher", "Imprimer liste des affectation d'une tache", "Projet ")

        'liste des employés d'un service
        connexion()
        requete = "SELECT Livrable.id_livrable, nom_livrable, description_livrable, Format(date_livrable, 'dd/MM/yyyy') AS date_livrable, Tache.id_tache, date_debut, date_fin " & _
                  "FROM Livrable INNER JOIN Tache ON Livrable.id_tache = Tache.id_tache " & _
                  "where Tache.nom_tache like '" + nom_tache + "'"

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
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        livrable_form.idl.Text = DataGridView1.Rows(i).Cells(0).Value.ToString
        livrable_form.ancien_id.Text = DataGridView1.Rows(i).Cells(0).Value
        livrable_form.noml.Text = DataGridView1.Rows(i).Cells(1).Value.ToString
        livrable_form.descriptionl.Text = DataGridView1.Rows(i).Cells(2).Value.ToString
        livrable_form.Datel.Text = DataGridView1.Rows(i).Cells(3).Value.ToString
        livrable_form.id_tache.Text = DataGridView1.Rows(i).Cells(4).Value.ToString
        livrable_form.ligne_modifie.Text = i
        livrable_form.type_operation.Text = "Modifier"
        livrable_form.ShowDialog()
    End Sub
End Class