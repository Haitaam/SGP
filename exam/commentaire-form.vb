Public Class commentaire_form

    Private Sub commentaire_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Commentaire"
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.CenterToScreen()
        connexion()
        requete = "select * from Tache"
        cmdsql()
        Dim data As IDataReader
        data = cmd.ExecuteReader()
        Dim idt, nomt As String
        tache.Items.Clear()
        While data.Read()
            idt = data(0).ToString
            nomt = data(1)
            tache.Items.Add(idt + " | " + nomt)
        End While
        con.Close()
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
        tache.Text = Nothing
        membre.Text = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim p As Integer
        Dim idt As String = ""
        Dim m As Integer
        Dim idm As String = ""
        If (tache.SelectedIndex <> -1) Then
            p = InStr(tache.Text, "|")
            idt = Mid(tache.Text, 1, p - 1)
        End If
        If (membre.SelectedIndex <> -1) Then
            m = InStr(membre.Text, "|")
            idm = Mid(membre.Text, 1, p - 1)
        End If
        If type_operation.Text = "Modifier" Then
            requete = "UPDATE Commentaire SET id_commentaire = " & idc.Text & ", " & _
                      "texte_commentaire = '" & texte.Text & "', " & _
                      "date_commentaire = #" & Datec.Text & "#, " & _
                      "id_tache = " & idt & ", " & _
                      "id_membre = " & idm & " " & _
                      "WHERE id_commentaire = " & ancien_idc.Text

        End If
        If (type_operation.Text = "Ajouter") Then
            requete = "INSERT INTO Commentaire VALUES ('" + idc.Text + "','" + texte.Text + "','" + Datec.Text + "','" + idt + "','" + idm + "')"
        End If
        cmdsql()
        Try
            cmd.CommandText = requete
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            commentaire.afficher_commentaire()
            Me.Close()
        Catch ex As Exception
            MsgBox("Le ID commentaire existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
            con.Close()
        End Try
        commentaire.afficher_commentaire()
    End Sub
End Class