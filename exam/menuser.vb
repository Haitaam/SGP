Imports System.Data.OleDb
Public Class menuser
    Private Sub menuser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Mon espace "
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

        '-------------------------------------------------------------------------------
        DataGridView2.Visible = False
        DataGridView2.Width = Me.Width - 40
        DataGridView2.Height = Me.Height - 100
        DataGridView2.BorderStyle = BorderStyle.None
        DataGridView2.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        DataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(49, 139, 122)
        DataGridView2.EnableHeadersVisualStyles = False
        DataGridView2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(49, 139, 122)
        DataGridView2.CellBorderStyle = DataGridViewCellBorderStyle.None
    End Sub

    Private Sub ServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceToolStripMenuItem.Click
        DataGridView2.Visible = True
        imprimer.Visible = False
        Dim i As Integer
        Dim id As String
        i = DataGridView1.CurrentCell.RowIndex
        id = DataGridView1.Rows(i).Cells(0).Value.ToString()
        connexion()
        'requete = "SELECT projet.id_projet, projet.nom_projet, description_projet, date_debut, date_fin, " & _
        '          "Membre.id_membre, " & _
        '          "compte.typecompte, " & _
        '          "Equipe_projet.role " & _
        '          "FROM projet, Equipe_projet , Membre, compte " & _
        '          "WHERE Equipe_projet.id_projet = projet.id_projet " & _
        '          "AND Equipe_projet.id_membre = Membre.id_membre " & _
        '          "AND compte.id_membre = Membre.id_membre " & _
        '          "AND Membre.nom_membre = '" & id & "'"
        requete = "select Travaille_sur.id_membre, Membre.nom_membre, " & _
                  "projet.nom_projet, description_projet, projet.date_debut, projet.date_fin, " & _
                  "Tache.statut from projet, Tache, Travaille_sur, Membre " & _
                  "where Tache.id_projet = projet.id_projet " & _
                  "and Travaille_sur.id_tache = Tache.id_tache " & _
                  "and Travaille_sur.id_membre = Membre.id_membre " & _
                  "and Membre.nom_membre = '" & id & "'"

        Dim da As New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView2.DataSource = dt
        DataGridView2.Columns(0).Width = 100
        con.Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If (DataGridView2.Visible = True) Then
            DataGridView2.Visible = False
            imprimer.Visible = False
        End If
    End Sub

    Private Sub EquipeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipeToolStripMenuItem.Click
        DataGridView2.Visible = True
        imprimer.Visible = False

        Dim i As Integer
        Dim id As String
        i = DataGridView1.CurrentCell.RowIndex
        id = DataGridView1.Rows(i).Cells(0).Value.ToString()
        connexion()
        requete = "SELECT projet.id_projet, projet.nom_projet, " & _
                  "Membre.id_membre, nom_membre, prenom_membre, " & _
                  "Equipe_projet.role " & _
                  "FROM projet, Equipe_projet, Membre " & _
                  "WHERE Equipe_projet.id_projet = projet.id_projet " & _
                  "AND Equipe_projet.id_membre = Membre.id_membre " & _
                  "AND Membre.nom_membre = '" & id & "'"

        Dim da As New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView2.DataSource = dt
        DataGridView2.Columns(0).Width = 100
        con.Close()
    End Sub

    Private Sub PointageDeGroupeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointageDeGroupeToolStripMenuItem.Click
        DataGridView2.Visible = True
        imprimer.Visible = True
        Dim i As Integer
        Dim id As String
        i = DataGridView1.CurrentCell.RowIndex
        id = DataGridView1.Rows(i).Cells(0).Value.ToString()
        connexion()
        requete = "SELECT projet.id_projet,nom_projet, Travaille_sur.id_tache," & _
                  "Tache.nom_tache,description_tache,Tache.date_debut,Tache.date_fin,statut, " & _
                  "Membre.nom_membre " & _
                  "FROM projet, Travaille_sur, Membre, Tache " & _
                  "WHERE Tache.id_projet = projet.id_projet " & _
                  "AND Travaille_sur.id_membre = Membre.id_membre " & _
                  "AND Travaille_sur.id_tache = Tache.id_tache " & _
                  "AND Membre.nom_membre = '" & id & "'"
        Dim da As New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        da.Fill(dt)
        DataGridView2.DataSource = dt
        DataGridView2.Columns(0).Width = 100
        con.Close()
    End Sub

    Private Sub Imprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles imprimer.Click
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
        e.Graphics.DrawString("Mes taches", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 55
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 55
        With e.Graphics
            .DrawString("Id", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Nom projet", font_tcolonne, Brushes.Black, cl + 30, ln)
            .DrawString("Id", font_tcolonne, Brushes.Black, cl + 170, ln)
            .DrawString("Nom tache", font_tcolonne, Brushes.Black, cl + 190, ln)
            .DrawString("Description", font_tcolonne, Brushes.Black, cl + 330, ln)
            .DrawString("Date debut", font_tcolonne, Brushes.Black, cl + 490, ln)
            .DrawString("Date fin", font_tcolonne, Brushes.Black, cl + 570, ln)
            .DrawString("Nom", font_tcolonne, Brushes.Black, cl + 650, ln)
        End With
        ln = ln + 55
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c3, c4, c5, c6, c7, c8 As String
        For i = 0 To DataGridView1.Rows.Count - 1
            c1 = DataGridView2.Rows(i).Cells(0).Value
            c2 = DataGridView2.Rows(i).Cells(1).Value
            c3 = DataGridView2.Rows(i).Cells(2).Value
            c4 = DataGridView2.Rows(i).Cells(3).Value
            c5 = DataGridView2.Rows(i).Cells(4).Value
            c6 = DataGridView2.Rows(i).Cells(5).Value
            c7 = DataGridView2.Rows(i).Cells(6).Value
            c8 = DataGridView2.Rows(i).Cells(7).Value
            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 30, ln)
                .DrawString(c3, font_colonne, Brushes.Black, cl + 170, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 190, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 330, ln)
                .DrawString(c6, font_colonne, Brushes.Black, cl + 490, ln)
                .DrawString(c7, font_colonne, Brushes.Black, cl + 570, ln)
                .DrawString(c8, font_colonne, Brushes.Black, cl + 650, ln)
            End With
            ln = ln + 55
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("Mes taches", font_titre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub MesLivrablesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MesLivrablesToolStripMenuItem.Click
        If DataGridView2.Rows.Count = 0 Then
            MsgBox("Aucune Tache ...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView2.CurrentCell.RowIndex
            Dim id As String = DataGridView2.Rows(i).Cells(2).Value.ToString()
            Dim idp As String = DataGridView2.Rows(i).Cells(0).Value.ToString()
            Dim rep As MsgBoxResult
            rep = MsgBox("Est-ce que vous allez effectuer cette Tache : " + id + "?", vbYesNo + vbQuestion, "Confirmation")
            If rep = vbYes Then
                connexion()
                requete = "update Tache set statut = 'Termine' " &
                          "where id_tache = " + id + " and id_projet = " + idp
                cmdsql()
                cmd.ExecuteNonQuery()
                con.Close()

            End If
        End If
    End Sub

    Private Sub DataGridView2_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class