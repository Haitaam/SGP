Public Class travaille_sur_form


    Private Sub travaille_sur_form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        requete = "select * from Membre "
        cmdsql()
        Dim datae As IDataReader
        datae = cmd.ExecuteReader()
        Dim idr, nom, prenom As String
        id_membre.Items.Clear()
        While datae.Read()
            idr = datae(0).ToString
            nom = datae(1)
            prenom = datae(1)
            id_membre.Items.Add(idr + " | " + nom + " " + prenom)
        End While
        con.Close()
        id_tache.Text = Nothing
        id_membre.Text = Nothing
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
        If (id_membre.SelectedIndex <> -1) Then
            p = InStr(id_membre.Text, "|")
            idr = Mid(id_membre.Text, 1, p - 1)
        End If
        requete = "INSERT INTO travaille_sur VALUES (" & idt & ", " & idr & ")"
        cmdsql()
        Try
            cmd.ExecuteNonQuery() 'On exécute la requête
            con.Close()
            travaille_sur.afficher_travail()
            Me.Close()
        Catch ex As Exception
            MsgBox("Le ID ressource existe déjà, Veuillez le remplacer par un autre", vbExclamation, "Message")
            con.Close()
        End Try
    End Sub
End Class