Public Class affectation_form

    Private Sub affectation_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Formulaire d'affectation"
        Me.MinimizeBox = False
        Me.MaximizeBox = False
        Me.CenterToScreen()
        connexion()
        requete = "select * from Tache"
        cmdsql()
        Dim data As IDataReader
        data = cmd.ExecuteReader()
        Dim idt, nomt As String
        id_tache.Items.Clear()
        While data.Read()
            idt = data(0).ToString
            nomt = data(1)
            id_tache.Items.Add(idt + " | " + nomt)
        End While
        con.Close()
        connexion()
        requete = "select * from ressource "
        cmdsql()
        Dim datae As IDataReader
        datae = cmd.ExecuteReader()
        Dim idr, nomr As String
        id_ressource.Items.Clear()
        While datae.Read()
            idr = datae(0).ToString
            nomr = datae(1)
            id_ressource.Items.Add(idr + " | " + nomr)
        End While
        con.Close()
        id_tache.Text = Nothing
        id_ressource.Text = Nothing
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        connexion()
        Dim p As Integer
            Dim idt As String = ""
            Dim idr As String = ""
            If (id_tache.SelectedIndex <> -1) Then
                p = InStr(id_tache.Text, "|")
                idt = Mid(id_tache.Text, 1, p - 1)
            End If
            If (id_ressource.SelectedIndex <> -1) Then
                p = InStr(id_ressource.Text, "|")
                idr = Mid(id_ressource.Text, 1, p - 1)
        End If
        If type_operation.Text = "Ajouter" Then
            requete = "INSERT INTO affectation VALUES (" & idt & ", " & idr & ")"
        End If

        If (type_operation.Text = "Modifier") Then
            requete = "UPDATE affectation SET id_tache =" & idt & _
                      ", id_ressource = " & idr & _
                      " WHERE affectation.id_tache = " & ancien_idt.Text & _
                      " AND affectation.id_ressource = " & ancien_idr.Text
        End If


        cmdsql()
        'Try
        cmd.ExecuteNonQuery() 'On exécute la requête
        con.Close()
        affectation.afficher_affectation()
        Me.Close()
        'Catch ex As Exception
        '  MsgBox("Le ID ressource existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
        con.Close()
        'End Try
    End Sub
End Class