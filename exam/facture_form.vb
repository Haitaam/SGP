Public Class facture_form

    Private Sub facture_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Gestion de facture "
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
        If (type_operation.Text = "Ajouter") Then
            requete = "INSERT INTO facture VALUES ('" + idf.Text + "','" + idp + "','" + nom.Text + "','" + Datef.Text + "','" + prix.Text + "DH')"
        End If
        If (type_operation.Text = "Modifier") Then
            requete = "UPDATE facture SET id_facture =" & idf.Text & _
                      ", id_projet = " & idp & _
                      ", nom_client = '" & nom.Text & "'" & _
                      ", date_facture = " & Datef.Text & _
                      ", montant_facture = '" & prix.Text & "'" & _
                      " WHERE facture.id_facture = " & ancien_id.Text
        End If
        cmdsql()
        Try
            cmd.CommandText = requete
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            facture.afficher_facture()
            Me.Close()
        Catch ex As Exception
            MsgBox("La facture existe déjà, Veuillez le remplacer par une autre", vbExclamation, "Message")
            con.Close()
        End Try
    End Sub
End Class