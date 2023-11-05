Public Class ressource_form

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connexion()
        If (type_operation.Text = "Ajouter") Then
            requete = "insert into ressource values (" + idr.Text + ",'" + nom.Text + "','" + description.Text + "')"
        Else
            requete = "update ressource set id_ressource=" + idr.Text + ", " & _
                "nom_ressource = '" + nom.Text + "'" & _
                "where id_ressource = " + ancien_idservice.Text
        End If


        cmdsql()
        Try
            cmd.ExecuteNonQuery() 'On exécute la requête
            con.Close()
            ressource.afficher_ressource()
            Me.Close()
        Catch ex As Exception
            MsgBox("Le ID ressource existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
            con.Close()
        End Try
    End Sub
End Class