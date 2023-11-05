Imports System.Data.OleDb
Public Class commentaire

    Private Sub commentaire_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Gestion des Commentaire"
        Me.BackColor = Color.FromArgb(240, 240, 240)
        Me.Width = 1200
        Me.Height = 600
        Me.CenterToScreen()

        DataGridView1.Width = Me.Width - 40
        DataGridView1.Height = Me.Height - 220
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.DefaultCellStyle.Font = New Font("Segoe UI", 10)
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(49, 139, 122)
        DataGridView1.EnableHeadersVisualStyles = False
        DataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        DataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(49, 139, 122)
        DataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None

        afficher_commentaire()
    End Sub
    Public Sub afficher_commentaire()
        connexion()
        requete = "SELECT Commentaire.id_commentaire, texte_commentaire, date_commentaire ,Tache.id_tache, nom_Tache, Membre.id_membre, nom_membre, prenom_membre " & _
                  "FROM Commentaire, Tache, Membre " & _
                  "where Commentaire.id_tache = Tache.id_tache " & _
                  "and Commentaire.id_membre = Membre.id_membre " & _
                  "ORDER BY Commentaire.id_commentaire ASC;"

        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)

        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
        DataGridView1.Columns(0).Width = 100

        con.Close()

        Dim nombre As Integer = DataGridView1.Rows.Count
        cpt.Text = "Nombre des Commentaires : " + nombre.ToString

        If (membre_form.type_operation.Text = "Ajouter") Then
            DataGridView1.FirstDisplayedScrollingRowIndex = DataGridView1.Rows.Count - 1
            DataGridView1.Rows(DataGridView1.Rows.Count - 1).Selected = True
        End If
        If (tache_form.type_operation.Text = "Modifier") Then
            DataGridView1.Rows(Val(tache_form.ligne_modifie.Text)).Selected = True
        End If
    End Sub

    Private Sub Ajouter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ajouter.Click
        commentaire_form.type_operation.Text = "Ajouter"
        commentaire_form.idc.Text = Nothing
        commentaire_form.texte.Text = Nothing
        commentaire_form.datec.Text = Nothing
        commentaire_form.ShowDialog()
    End Sub
    Private Sub DataGridView1_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim i As Integer
        i = DataGridView1.CurrentCell.RowIndex
        commentaire_form.idc.Text = DataGridView1.Rows(i).Cells(0).Value.ToString
        commentaire_form.ancien_idc.Text = DataGridView1.Rows(i).Cells(0).Value
        commentaire_form.texte.Text = DataGridView1.Rows(i).Cells(1).Value.ToString
        commentaire_form.Datec.Text = DataGridView1.Rows(i).Cells(2).Value.ToString
        commentaire_form.tache.Text = DataGridView1.Rows(i).Cells(3).Value.ToString
        commentaire_form.membre.Text = DataGridView1.Rows(i).Cells(5).Value.ToString
        commentaire_form.ligne_modifie.Text = i
        commentaire_form.type_operation.Text = "Modifier"
        commentaire_form.ShowDialog()
    End Sub

    Private Sub Supprimer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Supprimer.Click
        commentaire_form.type_operation.Text = "Ajouter"
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("Aucun projet...", vbExclamation, "Message")
        Else
            Dim i As Integer = DataGridView1.CurrentCell.RowIndex
            Dim id As String = DataGridView1.Rows(i).Cells(0).Value.ToString()
            Dim rep As MsgBoxResult

            rep = MsgBox("Êtes-vous sûr de supprimer ce commentaire : " + id + "?", vbYesNo + vbQuestion, "Confirmation")
            If rep = vbYes Then
                connexion()
                ' Supprimer la tâche dans la table " commentaire
                requete = "DELETE FROM Commentaire WHERE id_commentaire = " + id
                cmdsql()
                cmd.ExecuteNonQuery()
                con.Close()
                requete = "SELECT * FROM Commentaire ORDER BY id_commentaire"
                afficher_commentaire()
            End If
        End If
    End Sub

    Private Sub Actualiser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Actualiser.Click
        afficher_commentaire()
    End Sub

    Private Sub Rechercher_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rechercher.Click
        Dim nom_a_chercher As String
        nom_a_chercher = InputBox("Entrez le nom de tache ou de membre ou la date de commentaire : ", "Recherche", "")
        connexion()
        requete = "SELECT Commentaire.id_commentaire, texte_commentaire, date_commentaire ,Tache.id_tache, nom_Tache, Membre.id_membre, nom_membre, prenom_membre " & _
                  "FROM Commentaire, Tache, Membre " & _
                  "where Commentaire.id_tache = Tache.id_tache " & _
                  "and Commentaire.id_membre = Membre.id_membre " & _
                  "AND (UCASE(Tache.nom_tache) LIKE '%" & nom_a_chercher.ToUpper().Replace("'", "''") & "%' " & _
                  "OR UCASE(Membre.nom_membre) LIKE '%" & nom_a_chercher.ToUpper().Replace("'", "''") & "%' " & _
                  "OR UCASE(Membre.prenom_membre) LIKE '%" & nom_a_chercher.ToUpper().Replace("'", "''") & "%' " & _
                  "OR UCASE(Commentaire.date_commentaire) LIKE '%" & nom_a_chercher.ToUpper().Replace("'", "''") & "%')"

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
End Class