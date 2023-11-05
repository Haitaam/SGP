Public Class equipe_membre_form

    Private Sub equipe_membre_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Formulaire equipe d'un projet "
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.CenterToScreen()
        connexion()
        requete = "select * from projet"
        cmdsql()
        Dim data As IDataReader
        data = cmd.ExecuteReader()
        Dim ids, noms As String
        id_projet.Items.Clear()
        While data.Read()
            ids = data(0).ToString
            noms = data(1)
            id_projet.Items.Add(ids + " | " + noms)
        End While
        con.Close()
        connexion()
        requete = "select * from Membre "
        cmdsql()
        Dim datae As IDataReader
        datae = cmd.ExecuteReader()
        Dim ide, nome, prenome As String
        id_membre.Items.Clear()
        While datae.Read()
            ide = datae(0).ToString
            nome = datae(1)
            prenome = datae(2)
            id_membre.Items.Add(ide + " | " + nome + " " + prenome)
        End While
        con.Close()
        id_projet.Text = Nothing
        id_membre.Text = Nothing
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Dim p As Integer
            Dim idp As String = ""
            Dim idm As String = ""
            If (id_projet.SelectedIndex <> -1) Then
                p = InStr(id_projet.Text, "|")
                idp = Mid(id_projet.Text, 1, p - 1)
            End If
            If (id_membre.SelectedIndex <> -1) Then
                p = InStr(id_membre.Text, "|")
                idm = Mid(id_membre.Text, 1, p - 1)
            End If

            If (type_operation.Text = "Ajouter") Then
                requete = "INSERT INTO Equipe_projet (id_projet, id_membre, role) VALUES (" & idp & ", " & idm & ", '" & role.Text & "')"
            End If
            If (type_operation.Text = "Modifier") Then
                requete = "UPDATE Equipe_projet SET id_projet =" & idp & _
                          ", id_membre = " & idm & _
                          ", role = '" & role.Text & "'" & _
                          " WHERE Equipe_projet.id_projet = " & ancien_id.Text & _
                          " AND Equipe_projet.id_membre = " & ancien_idm.Text
            End If
            connexion()
            cmdsql()
            cmd.ExecuteNonQuery()
            con.Close()
            equipe_membre.afficher_equipe_membre()
            Me.Close()
        Catch ex As Exception
            MsgBox("L'équipe a déjà été ajoutée...", vbExclamation, "Message")
        End Try
        equipe_membre.afficher_equipe_membre()

    End Sub

    Private Sub id_projet_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles id_projet.SelectedIndexChanged

    End Sub
End Class