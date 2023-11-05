<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuser))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.InitialiserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.EquipeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MesLivrablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PointageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PointageDeGroupeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.imprimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripSeparator4, Me.InitialiserToolStripMenuItem, Me.MesLivrablesToolStripMenuItem, Me.PointageToolStripMenuItem, Me.imprimer})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(658, 25)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(58, 23)
        Me.ToolStripMenuItem1.Text = "Accueil"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 23)
        '
        'InitialiserToolStripMenuItem
        '
        Me.InitialiserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServiceToolStripMenuItem, Me.ToolStripSeparator2, Me.EquipeToolStripMenuItem})
        Me.InitialiserToolStripMenuItem.Name = "InitialiserToolStripMenuItem"
        Me.InitialiserToolStripMenuItem.Size = New System.Drawing.Size(50, 23)
        Me.InitialiserToolStripMenuItem.Text = "Projet"
        '
        'ServiceToolStripMenuItem
        '
        Me.ServiceToolStripMenuItem.Name = "ServiceToolStripMenuItem"
        Me.ServiceToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ServiceToolStripMenuItem.Text = "Mes projets"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(135, 6)
        '
        'EquipeToolStripMenuItem
        '
        Me.EquipeToolStripMenuItem.Name = "EquipeToolStripMenuItem"
        Me.EquipeToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.EquipeToolStripMenuItem.Text = "Mon equipe"
        '
        'MesLivrablesToolStripMenuItem
        '
        Me.MesLivrablesToolStripMenuItem.Name = "MesLivrablesToolStripMenuItem"
        Me.MesLivrablesToolStripMenuItem.Size = New System.Drawing.Size(87, 23)
        Me.MesLivrablesToolStripMenuItem.Text = "Mes livrables"
        '
        'PointageToolStripMenuItem
        '
        Me.PointageToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PointageDeGroupeToolStripMenuItem, Me.ToolStripSeparator1})
        Me.PointageToolStripMenuItem.Name = "PointageToolStripMenuItem"
        Me.PointageToolStripMenuItem.Size = New System.Drawing.Size(44, 23)
        Me.PointageToolStripMenuItem.Text = "Suivi"
        '
        'PointageDeGroupeToolStripMenuItem
        '
        Me.PointageDeGroupeToolStripMenuItem.Name = "PointageDeGroupeToolStripMenuItem"
        Me.PointageDeGroupeToolStripMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.PointageDeGroupeToolStripMenuItem.Text = "Tache"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(101, 6)
        '
        'imprimer
        '
        Me.imprimer.Name = "imprimer"
        Me.imprimer.Size = New System.Drawing.Size(68, 23)
        Me.imprimer.Text = "Imprimer"
        Me.imprimer.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(245, 151)
        Me.DataGridView1.TabIndex = 3
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 27)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(245, 151)
        Me.DataGridView2.TabIndex = 4
        '
        'PrintDocument1
        '
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
        'menuser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 344)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "menuser"
        Me.Text = "menuser"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InitialiserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ServiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EquipeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PointageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PointageDeGroupeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents imprimer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents MesLivrablesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
