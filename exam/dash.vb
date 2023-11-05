Imports System.Data.OleDb
Public Class dash
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        requete = "SELECT Membre.nom_membre AS 'Nom', prenom_membre AS 'Prenom', email_membre AS 'Mon email', poste AS 'Mon Poste', " & _
              "compte.login, compte.password, compte.typecompte " & _
              "FROM Membre, compte " & _
              "WHERE compte.id_membre = Membre.id_membre " & _
              "AND compte.login = '" + login.Text + "' " & _
              "AND compte.password = '" + password.Text + "'"

        connexion()
        Dim da As New OleDbDataAdapter
        da = New OleDbDataAdapter(requete, con)
        Dim dt As New DataTable
        Dim ds As New DataSet
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Dim typeCompte As String = dt.Rows(0)("typecompte").ToString()
            con.Close()
            If typeCompte = "admin" Then
                Menus.ShowDialog()
            ElseIf typeCompte = "utilisateur" Then
                menuser.DataGridView1.DataSource = dt.DefaultView
                menuser.DataGridView1.Columns(0).Width = 100
                menuser.ShowDialog()
            End If
            login.Text = ""
            password.Text = ""
        Else
            con.Close()
            MsgBox("Identifiant ou mot de passe incorrect. Veuillez réessayer.", vbExclamation, "Erreur d'authentification")
        End If
    End Sub

    Private Sub dash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class