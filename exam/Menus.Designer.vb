<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menus
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InitialiserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.AffecterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PointageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PointageDeGroupeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PointageIndividuelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AffecterToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AffecterUneRessourceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AffecterUnMembreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CommentaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.LivrableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GsectionDesComptesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InitialiserToolStripMenuItem, Me.PointageToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(949, 29)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InitialiserToolStripMenuItem
        '
        Me.InitialiserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiceToolStripMenuItem, Me.EmployéToolStripMenuItem, Me.ToolStripSeparator2, Me.AffecterToolStripMenuItem, Me.EquipeToolStripMenuItem, Me.ToolStripSeparator3, Me.QuitterToolStripMenuItem})
        Me.InitialiserToolStripMenuItem.Name = "InitialiserToolStripMenuItem"
        Me.InitialiserToolStripMenuItem.Size = New System.Drawing.Size(70, 27)
        Me.InitialiserToolStripMenuItem.Text = "Projet"
        '
        'ServiceToolStripMenuItem
        '
        Me.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem"
        Me.ServiceToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.ServiceToolStripMenuItem.Text = "Projet"
        '
        'EmployéToolStripMenuItem
        '
        Me.EmployéToolStripMenuItem.Name = "EmployéToolStripMenuItem"
        Me.EmployéToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.EmployéToolStripMenuItem.Text = "Facture"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(198, 6)
        '
        'AffecterToolStripMenuItem
        '
        Me.AffecterToolStripMenuItem.Name = "AffecterToolStripMenuItem"
        Me.AffecterToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.AffecterToolStripMenuItem.Text = "Membre"
        '
        'EquipeToolStripMenuItem
        '
        Me.EquipeToolStripMenuItem.Name = "EquipeToolStripMenuItem"
        Me.EquipeToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.EquipeToolStripMenuItem.Text = "Equipe"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(198, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(201, 28)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'PointageToolStripMenuItem
        '
        Me.PointageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PointageDeGroupeToolStripMenuItem, Me.ToolStripSeparator1, Me.PointageIndividuelToolStripMenuItem, Me.AffecterToolStripMenuItem1, Me.LivrableToolStripMenuItem})
        Me.PointageToolStripMenuItem.Name = "PointageToolStripMenuItem"
        Me.PointageToolStripMenuItem.Size = New System.Drawing.Size(61, 27)
        Me.PointageToolStripMenuItem.Text = "Suivi"
        '
        'PointageDeGroupeToolStripMenuItem
        '
        Me.PointageDeGroupeToolStripMenuItem.Name = "PointageDeGroupeToolStripMenuItem"
        Me.PointageDeGroupeToolStripMenuItem.Size = New System.Drawing.Size(158, 28)
        Me.PointageDeGroupeToolStripMenuItem.Text = "Tache"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        'PointageIndividuelToolStripMenuItem
        '
        Me.PointageIndividuelToolStripMenuItem.Name = "PointageIndividuelToolStripMenuItem"
        Me.PointageIndividuelToolStripMenuItem.Size = New System.Drawing.Size(158, 28)
        Me.PointageIndividuelToolStripMenuItem.Text = "Ressource"
        '
        'AffecterToolStripMenuItem1
        '
        Me.AffecterToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AffecterUneRessourceToolStripMenuItem, Me.ToolStripSeparator4, Me.AffecterUnMembreToolStripMenuItem, Me.CommentaireToolStripMenuItem, Me.ToolStripSeparator5})
        Me.AffecterToolStripMenuItem1.Name = "AffecterToolStripMenuItem1"
        Me.AffecterToolStripMenuItem1.Size = New System.Drawing.Size(158, 28)
        Me.AffecterToolStripMenuItem1.Text = "Affecter"
        '
        'AffecterUneRessourceToolStripMenuItem
        '
        Me.AffecterUneRessourceToolStripMenuItem.Name = "AffecterUneRessourceToolStripMenuItem"
        Me.AffecterUneRessourceToolStripMenuItem.Size = New System.Drawing.Size(259, 28)
        Me.AffecterUneRessourceToolStripMenuItem.Text = "Affecter une ressource"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(256, 6)
        '
        'AffecterUnMembreToolStripMenuItem
        '
        Me.AffecterUnMembreToolStripMenuItem.Name = "AffecterUnMembreToolStripMenuItem"
        Me.AffecterUnMembreToolStripMenuItem.Size = New System.Drawing.Size(259, 28)
        Me.AffecterUnMembreToolStripMenuItem.Text = "Affecter un membre"
        '
        'CommentaireToolStripMenuItem
        '
        Me.CommentaireToolStripMenuItem.Name = "CommentaireToolStripMenuItem"
        Me.CommentaireToolStripMenuItem.Size = New System.Drawing.Size(259, 28)
        Me.CommentaireToolStripMenuItem.Text = "Commentaire"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(256, 6)
        '
        'LivrableToolStripMenuItem
        '
        Me.LivrableToolStripMenuItem.Name = "LivrableToolStripMenuItem"
        Me.LivrableToolStripMenuItem.Size = New System.Drawing.Size(158, 28)
        Me.LivrableToolStripMenuItem.Text = "Livrable"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GsectionDesComptesToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(123, 27)
        Me.ToolStripMenuItem1.Text = "Les Comptes"
        '
        'GsectionDesComptesToolStripMenuItem
        '
        Me.GsectionDesComptesToolStripMenuItem.Name = "GsectionDesComptesToolStripMenuItem"
        Me.GsectionDesComptesToolStripMenuItem.Size = New System.Drawing.Size(151, 28)
        Me.GsectionDesComptesToolStripMenuItem.Text = "Comptes"
        '
        'Menus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.My.Resources.Resources.Projet_informatique_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(949, 501)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Menus"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InitialiserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployéToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AffecterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PointageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PointageIndividuelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PointageDeGroupeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquipeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AffecterToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LivrableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AffecterUneRessourceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AffecterUnMembreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CommentaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GsectionDesComptesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
