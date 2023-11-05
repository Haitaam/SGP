Public Class livrable_form
    Private Sub livrable_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Formulaire Livrable"
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.CenterToScreen()
        connexion()
        requete = "select * from Tache"
        cmdsql()
        Dim data As IDataReader
        data = cmd.ExecuteReader()
        Dim idt, nomt, dated, datef As String
        id_tache.Items.Clear()
        While data.Read()
            idt = data(0).ToString
            nomt = data(1)
            dated = data(3)
            datef = data(4)
            id_tache.Items.Add(idt + " | " + nomt + " | " + dated + "  à  " + datef)
        End While
        con.Close()
        id_tache.Text = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connexion()
        Dim p As Integer
        Dim idt As String = " "
        If (id_tache.SelectedIndex <> -1) Then
            p = InStr(id_tache.Text, "|")
            idt = Mid(id_tache.Text, 1, p - 1)
        End If

        If type_operation.Text = "Ajouter" Then
            requete = "INSERT INTO Livrable (id_livrable, nom_livrable, description_livrable, date_livrable, id_tache) VALUES " & _
                      "(" & idl.Text & ", '" & noml.Text & "' , '" & descriptionl.Text & "' , '" & Datel.Text & "', " & idt & ")"
        End If

        If type_operation.Text = "Modifier" Then
            requete = "UPDATE Livrable SET id_livrable = " & idl.Text & ", " & _
                      "nom_livrable = '" & noml.Text & "', " & _
                      "description_livrable = '" & Replace(descriptionl.Text, "'", "''") & "', " & _
                      "date_livrable = '" & Datel.Text & "', " & _
                      "id_tache = " & idt & " " & _
                      "WHERE id_livrable = " & ancien_id.Text
        End If






        cmdsql()
        'Try
        cmd.ExecuteNonQuery() 'On exécute la requête
        con.Close()
        livrable.afficher_livrable()
        Me.Close()
        'Catch ex As Exception
        'MsgBox("Le ID ressource existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
        con.Close()
        'End Try
    End Sub
End Class