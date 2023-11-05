Public Class tache_form

    Private Sub tache_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "####Tache#### "
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
        id_projet.Text = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p As Integer
        Dim idp As String = ""
        If (id_projet.SelectedIndex <> -1) Then
            p = InStr(id_projet.Text, "|")
            idp = Mid(id_projet.Text, 1, p - 1)
        End If
        If type_operation.Text = "Modifier" Then
            requete = "UPDATE Tache SET id_tache = " & idt.Text & ", " & _
                       "nom_tache = '" & nomt.Text & "', " & _
                       "id_projet = " & idp & ", " & _
                       "description_tache = '" & Replace(description.Text, "'", "''") & "', " & _
                       "date_debut = #" & Dated.Text & "#, " & _
                       "date_fin = #" & datef.Text & "#, " & _
                       "statut = '" & statut.Text & "' " & _
                       "WHERE id_tache = " & ancien_idtache.Text
        End If
        If (type_operation.Text = "Ajouter") Then
            Dim idtValue As String = idt.Text.Replace("'", "''")
            Dim nomtValue As String = nomt.Text.Replace("'", "''")
            Dim descriptionValue As String = description.Text.Replace("'", "''")
            Dim DatedValue As String = Dated.Text.Replace("'", "''")
            Dim datefValue As String = datef.Text.Replace("'", "''")
            Dim statutValue As String = statut.Text.Replace("'", "''")
            requete = "INSERT INTO Tache VALUES ('" + idtValue + "','" + nomtValue + "','" + descriptionValue + "','" + DatedValue + "','" + datefValue + "','" + statutValue + "','" + idp + "')"
        End If

        cmdsql()
        Try
            cmd.CommandText = requete
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            tache.afficher_tache()
            Me.Close()
        Catch ex As Exception
            MsgBox("Le ID tache existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
            con.Close()
        End Try
        tache.afficher_tache()
    End Sub
End Class