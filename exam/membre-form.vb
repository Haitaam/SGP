Public Class membre_form
    Private Sub membre_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Membre"
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.CenterToScreen()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connexion()
        If (type_operation.Text = "Ajouter") Then
            requete = "insert into Membre values ('" + id.Text + "','" + nom.Text + "','" + prenom.Text + "','" + email.Text + "','" + poste.Text + "')"
        End If
        If (type_operation.Text = "Modifier") Then
            requete = "update Membre set id_membre = " + id.Text + ", " & _
                       "nom_membre = '" + nom.Text + "', " & _
                       "prenom_membre = '" + prenom.Text + "', " & _
                       "email_membre = '" + email.Text + "', " & _
                       "poste  ='" + poste.Text + "'" & _
                       "where id_membre = " + ancien_membre.Text
        End If
        cmdsql()
        Try
            cmd.ExecuteNonQuery() 'On exécute la requête
            con.Close()
            membre.afficher_membre()
            Me.Close()
        Catch ex As Exception
            MsgBox("Le ID membre existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
            con.Close()
        End Try
    End Sub
End Class