Imports System.Data.OleDb
Public Class tache
    Public etat As Integer

    Private Sub tache_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Gestion des Tâches"
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


        afficher_tache()
    End Sub

    Public Sub afficher_tache()
        connexion()

        requete = "SELECT Tache.id_tache, nom_Tache, projet.id_projet, nom_projet, Tache.description_tache, Tache.date_debut, Tache.date_fin, Tache.statut " & _
                  "FROM Tache INNER JOIN projet ON Tache.id_projet = projet.id_projet " & _
                  "ORDER BY Tache.id_tache ASC;"

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)

        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 100

        con.Close()

        Dim nombre As Integer = DataGridView1.Rows.Count
        cpt.Text = "Nombre des taches : " + nombre.ToString

        If (membre_form.type_operation.Text = "Ajouter") Then
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
        End If
        If (tache_form.type_operation.Text = "Modifier") Then
            DataGridView1.Rows(Val(tache_form.ligne_modifie.Text)).Selected = True
        End If
    End Sub
    Private Sub DataGridView1_CellDoubleClick1(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        tache_form.idt.Text = DataGridView1.Rows(i).Cells(0).Value.ToString
        tache_form.ancien_idtache.Text = DataGridView1.Rows(i).Cells(0).Value
        tache_form.nomt.Text = DataGridView1.Rows(i).Cells(1).Value.ToString
        tache_form.id_projet.Text = DataGridView1.Rows(i).Cells(2).Value.ToString
        tache_form.description.Text = DataGridView1.Rows(i).Cells(4).Value.ToString
        tache_form.Dated.Text = DataGridView1.Rows(i).Cells(5).Value.ToString
        tache_form.datef.Text = DataGridView1.Rows(i).Cells(6).Value.ToString
        tache_form.statut.Text = DataGridView1.Rows(i).Cells(7).Value.ToString
        tache_form.ligne_modifie.Text = i
        tache_form.type_operation.Text = "Modifier"
        tache_form.ShowDialog()
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        tache_form.type_operation.Text = "Ajouter"

        If DataGridView1.Rows.Count = 0 Then
            MsgBox("Aucun projet...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value.ToString()
            Dim rep As MsgBoxResult

            rep = MsgBox("Êtes-vous sûr de supprimer cette tâche : " + id + "?", vbYesNo + vbQuestion, "Confirmation")
            If rep = vbYes Then
                connexion()
                ' Supprimer les enregistrements liés dans la table "Affectation"
                requete = "DELETE FROM Affectation WHERE id_tache = " + id
                cmdsql()
                cmd.ExecuteNonQuery()

                ' Supprimer les enregistrements liés dans la table "Travaille_sur"
                requete = "DELETE FROM Travaille_sur WHERE id_tache = " + id
                cmdsql()
                cmd.ExecuteNonQuery()


                ' Supprimer la tâche dans la table "Livrable"
                requete = "DELETE FROM Livrable WHERE id_tache = " + id
                cmdsql()
                cmd.ExecuteNonQuery()

                ' Supprimer la tâche dans la table "Tache"
                requete = "DELETE FROM Tache WHERE id_tache = " + id
                cmdsql()
                cmd.ExecuteNonQuery()

                con.Close()

                requete = "SELECT * FROM Tache ORDER BY id_tache"
                afficher_tache()
            End If
        End If


    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le nom de tache ou du projet ou la date chercher : ", "Recherche", "")
        connexion()
        requete = "SELECT Tache.id_tache, nom_tache, projet.id_projet, nom_projet, Tache.description_tache, Tache.date_debut, Tache.date_fin, Tache.statut " & _
                  "FROM Tache, projet " & _
                  "WHERE Tache.id_projet = projet.id_projet " & _
                  "AND (UCASE(nom_tache) LIKE '%" & nom_a_chercher.ToUpper().Replace("'", "''") & "%' " & _
                  "OR UCASE(Tache.date_debut) LIKE '%" & nom_a_chercher.ToUpper().Replace("'", "''") & "%' " & _
                  "OR UCASE(projet.nom_projet) LIKE '%" & nom_a_chercher.ToUpper().Replace("'", "''") & "%')"

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
        afficher_tache()
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
        e.Graphics.DrawString("Liste des Tache", font_titre, Brushes.Black, cl, ln)
        Dim ligne As New Pen(Color.Black)
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        ln = ln + 20
        With e.Graphics
            .DrawString("Id", font_tcolonne, Brushes.Black, cl, ln)
            .DrawString("Nom Tache", font_tcolonne, Brushes.Black, cl + 20, ln)
            .DrawString("Nom projet", font_tcolonne, Brushes.Black, cl + 130, ln)
            .DrawString("Description ", font_tcolonne, Brushes.Black, cl + 300, ln)
            .DrawString("Date debut ", font_tcolonne, Brushes.Black, cl + 470, ln)
            .DrawString("Date fin ", font_tcolonne, Brushes.Black, cl + 550, ln)
            .DrawString("Statut ", font_tcolonne, Brushes.Black, cl + 640, ln)
        End With
        ln = ln + 20
        e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Dim c1, c2, c4, c5, c6, c7, c8 As String
        Dim nld As Integer 'nld : nombre_de_ligne_du_datagrid
        If etat = 1 Then nld = DataGridView1.Rows.Count
        If etat = 2 Then nld = DataGridView2.Rows.Count
        For i = 0 To nld - 1
            If etat = 1 Then
                c1 = DataGridView1.Rows(i).Cells(0).Value
                c2 = DataGridView1.Rows(i).Cells(1).Value
                c4 = DataGridView1.Rows(i).Cells(3).Value
                c5 = DataGridView1.Rows(i).Cells(4).Value
                c6 = DataGridView1.Rows(i).Cells(5).Value
                c7 = DataGridView1.Rows(i).Cells(6).Value
                c8 = DataGridView1.Rows(i).Cells(7).Value
            Else
                c1 = DataGridView2.Rows(i).Cells(0).Value
                c2 = DataGridView2.Rows(i).Cells(1).Value
                c4 = DataGridView2.Rows(i).Cells(3).Value
                c5 = DataGridView2.Rows(i).Cells(4).Value
                c6 = DataGridView2.Rows(i).Cells(5).Value
                c7 = DataGridView2.Rows(i).Cells(6).Value
                c8 = DataGridView2.Rows(i).Cells(7).Value
            End If
            With e.Graphics
                .DrawString(c1, font_colonne, Brushes.Black, cl, ln)
                .DrawString(c2, font_colonne, Brushes.Black, cl + 20, ln)
                .DrawString(c4, font_colonne, Brushes.Black, cl + 130, ln)
                .DrawString(c5, font_colonne, Brushes.Black, cl + 300, ln)
                .DrawString(c6, font_colonne, Brushes.Black, cl + 470, ln)
                .DrawString(c7, font_colonne, Brushes.Black, cl + 550, ln)
                .DrawString(c8, font_colonne, Brushes.Black, cl + 640, ln)
            End With
            ln = ln + 60
            e.Graphics.DrawLine(ligne, cl, ln, 750, ln)
        Next
        e.Graphics.DrawLine(ligne, cl, 1100, 750, 1100)
        e.Graphics.DrawString("Entreprise : Liste des taches d'un projet ", font_titre, Brushes.Black, cl, 1100)
    End Sub

    Private Sub ImprimerLesTachesDuProjetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImprimerLesTachesDuProjetToolStripMenuItem.Click
        etat = 2
        Dim id_projet As String
        id_projet = InputBox("Entrez l'ID du projet à chercher", "Imprimer liste des employés d'un projet", "Projet ")

        'liste des employés d'un service
        connexion()
        requete = "SELECT Tache.id_tache, nom_tache, projet.id_projet, nom_projet, Tache.description_tache, Tache.date_debut, Tache.date_fin, Tache.statut " & _
                  "FROM Tache, projet " & _
                  "WHERE Tache.id_projet = projet.id_projet " & _
                  "and Tache.id_projet like '" + id_projet + "'"

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
    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        tache_form.type_operation.Text = "Ajouter"
        tache_form.idt.Text = Nothing
        tache_form.nomt.Text = Nothing
        tache_form.description.Text = Nothing
        tache_form.Dated.Text = Nothing
        tache_form.datef.Text = Nothing
        tache_form.ShowDialog()
    End Sub
End Class