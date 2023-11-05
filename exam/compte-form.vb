Public Class compte_form
    Private Sub compte_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Compte"
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.CenterToScreen()
        connexion()
        requete = "select * from Membre"
        cmdsql()
        Dim datae As IDataReader
        datae = cmd.ExecuteReader()
        Dim idm, nomm, prenomm As String
        membre.Items.Clear()
        While datae.Read()
            idm = datae(0).ToString
            nomm = datae(1)
            prenomm = datae(2)
            membre.Items.Add(idm + " | " + nomm + " " + prenomm)
        End While
        con.Close()
        membre.Text = Nothing

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p As Integer
        Dim idp As String = ""
        If (membre.SelectedIndex <> -1) Then
            p = InStr(membre.Text, "|")
            idp = Mid(membre.Text, 1, p - 1)
        End If
        If (type_operation.Text = "Ajouter") Then
            requete = "INSERT INTO compte VALUES (" + idc.Text + ",'" + type.Text + "'," + idp + ",'" + login.Text + "','" + password.Text + "')"
        End If
        If (type_operation.Text = "Modifier") Then
            requete = "UPDATE compte SET id_compte = " & idc.Text & _
                      ", typecompte = '" & type.Text & _
                      "', id_membre = " & idp & _
                      ", login = '" & login.Text & _
                      "', [password] = '" & password.Text & _
                      "' WHERE compte.id_compte = " & ancien_idc.Text

        End If
        cmdsql()
        Try
            cmd.CommandText = requete
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            compte.afficher_compte()
            Me.Close()
        Catch ex As Exception
            MsgBox("La facture existe déjà, Veuillez le remplacer par une autre", vbExclamation, "Message")
            con.Close()
        End Try
    End Sub
End Class