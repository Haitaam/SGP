Public Class Menus
    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.White
        Me.Width = 1200
        Me.Height = 600
        Me.CenterToScreen()
        MenuStrip1.BackColor = Color.White
    End Sub

    Private Sub ServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServiceToolStripMenuItem.Click
        Form1.ShowDialog()
    End Sub

    Private Sub EmployéToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployéToolStripMenuItem.Click
        facture.ShowDialog()
    End Sub

    Private Sub AffecterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AffecterToolStripMenuItem.Click
        membre.ShowDialog()
    End Sub

    Private Sub EquipeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EquipeToolStripMenuItem.Click
        equipe_membre.ShowDialog()
    End Sub

    Private Sub PointageIndividuelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointageIndividuelToolStripMenuItem.Click
        ressource.ShowDialog()
    End Sub

    Private Sub PointageDeGroupeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PointageDeGroupeToolStripMenuItem.Click
        tache.ShowDialog()
    End Sub
    Private Sub LivrableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LivrableToolStripMenuItem.Click
        livrable.ShowDialog()
    End Sub

    Private Sub AffecterUnMembreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AffecterUnMembreToolStripMenuItem.Click
        travaille_sur.ShowDialog()
    End Sub

    Private Sub AffecterUneRessourceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AffecterUneRessourceToolStripMenuItem.Click
        affectation.ShowDialog()
    End Sub

    Private Sub CommentaireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CommentaireToolStripMenuItem.Click
        commentaire.ShowDialog()
    End Sub

    Private Sub GsectionDesComptesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GsectionDesComptesToolStripMenuItem.Click
        compte.ShowDialog()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class

