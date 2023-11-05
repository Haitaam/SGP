Public Class Form2
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Projet "
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.CenterToScreen()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connexion()
        If (type_operation.Text = "Ajouter") Then
            requete = "insert into projet values (" + id_projet.Text + ",'" + nom_projet.Text + "','" + description_projet.Text + "','" + date_debut.Text + "','" + date_fin.Text + "')"
        End If
        If type_operation.Text = "Modifier" Then
            requete = "update projet set id_projet = " & id_projet.Text & ", " & _
                       "nom_projet = '" + nom_projet.Text + "', " & _
                       "description_projet = '" + Replace(description_projet.Text, "'", "''") + "', " & _
                       "date_debut = '" + date_debut.Text + "', " & _
                       "date_fin = #" + date_fin.Text + "# " & _
                       "where id_projet = " + ancien_idprojet.Text
        End If

        cmdsql()
        Try
            cmd.ExecuteNonQuery() 'On exécute la requête
            con.Close()
            Form1.afficher_service()
            Me.Close()
        Catch ex As Exception
            MsgBox("Le ID projet existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
            con.Close()
        End Try
    End Sub

    Private Sub id_projet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_projet.TextChanged

    End Sub
End Class

