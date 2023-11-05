<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class equipe_membre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(equipe_membre))
        Me.toolbar = New System.Windows.Forms.ToolStrip()
        Me.Ajouter = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.Supprimer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Rechercher = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.Actualiser = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Imprimer = New System.Windows.Forms.ToolStripDropDownButton()
        Me.ImprimerTousLesServicesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImprimerLaListeDesÉquipesDunMembreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cpt = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.toolbar.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.Color.White
        Me.toolbar.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.toolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Ajouter, Me.ToolStripSeparator1, Me.Supprimer, Me.ToolStripSeparator2, Me.Rechercher, Me.ToolStripSeparator3, Me.Actualiser, Me.ToolStripSeparator4, Me.Imprimer, Me.cpt})
        Me.toolbar.Location = New System.Drawing.Point(0, 0)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(437, 31)
        Me.toolbar.TabIndex = 13
        Me.toolbar.Text = "Rechercher par le nom du service"
        '
        'Ajouter
        '
        Me.Ajouter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Ajouter.Image = CType(resources.GetObject("Ajouter.Image"), System.Drawing.Image)
        Me.Ajouter.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(28, 28)
        Me.Ajouter.Text = "Ajouter"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'Supprimer
        '
        Me.Supprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Supprimer.Image = CType(resources.GetObject("Supprimer.Image"), System.Drawing.Image)
        Me.Supprimer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(28, 28)
        Me.Supprimer.Text = "Supprimer"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'Rechercher
        '
        Me.Rechercher.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Rechercher.Image = CType(resources.GetObject("Rechercher.Image"), System.Drawing.Image)
        Me.Rechercher.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Rechercher.Name = "Rechercher"
        Me.Rechercher.Size = New System.Drawing.Size(28, 28)
        Me.Rechercher.Text = "Rechercher par le nom du service"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'Actualiser
        '
        Me.Actualiser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Actualiser.Image = CType(resources.GetObject("Actualiser.Image"), System.Drawing.Image)
        Me.Actualiser.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Actualiser.Name = "Actualiser"
        Me.Actualiser.Size = New System.Drawing.Size(28, 28)
        Me.Actualiser.Text = "Actualiser"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'Imprimer
        '
        Me.Imprimer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Imprimer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImprimerTousLesServicesToolStripMenuItem, Me.ImprimerToolStripMenuItem, Me.ImprimerLaListeDesÉquipesDunMembreToolStripMenuItem})
        Me.Imprimer.Image = CType(resources.GetObject("Imprimer.Image"), System.Drawing.Image)
        Me.Imprimer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Imprimer.Name = "Imprimer"
        Me.Imprimer.Size = New System.Drawing.Size(37, 28)
        Me.Imprimer.Text = "Imprimer"
        '
        'ImprimerTousLesServicesToolStripMenuItem
        '
        Me.ImprimerTousLesServicesToolStripMenuItem.Name = "ImprimerTousLesServicesToolStripMenuItem"
        Me.ImprimerTousLesServicesToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.ImprimerTousLesServicesToolStripMenuItem.Text = "Imprimer tous les équipes"
        '
        'ImprimerToolStripMenuItem
        '
        Me.ImprimerToolStripMenuItem.Name = "ImprimerToolStripMenuItem"
        Me.ImprimerToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.ImprimerToolStripMenuItem.Text = "Imprimer les membres d'un équipe"
        '
        'ImprimerLaListeDesÉquipesDunMembreToolStripMenuItem
        '
        Me.ImprimerLaListeDesÉquipesDunMembreToolStripMenuItem.Name = "ImprimerLaListeDesÉquipesDunMembreToolStripMenuItem"
        Me.ImprimerLaListeDesÉquipesDunMembreToolStripMenuItem.Size = New System.Drawing.Size(299, 22)
        Me.ImprimerLaListeDesÉquipesDunMembreToolStripMenuItem.Text = "Imprimer la liste des équipes d’un membre"
        '
        'cpt
        '
        Me.cpt.Name = "cpt"
        Me.cpt.Size = New System.Drawing.Size(87, 28)
        Me.cpt.Text = "ToolStripLabel1"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 42)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(160, 97)
        Me.DataGridView1.TabIndex = 12
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'DataGridView2
        '
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AllowUserToResizeColumns = False
        Me.DataGridView2.AllowUserToResizeRows = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(266, 42)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.ReadOnly = True
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(160, 97)
        Me.DataGridView2.TabIndex = 14
        Me.DataGridView2.Visible = False
        '
        'equipe_membre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 261)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.toolbar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "equipe_membre"
        Me.Text = "equipe_membre"
        Me.toolbar.ResumeLayout(False)
        Me.toolbar.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents toolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents Ajouter As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Supprimer As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Rechercher As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Actualiser As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Imprimer As System.Windows.Forms.ToolStripDropDownButton
    Friend WithEvents ImprimerTousLesServicesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cpt As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ImprimerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImprimerLaListeDesÉquipesDunMembreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
End Class
