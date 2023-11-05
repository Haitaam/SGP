<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class affectation_form
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
        Me.id_tache = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_ressource = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.ancien_idt = New System.Windows.Forms.TextBox()
        Me.ancien_idr = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'id_tache
        '
        Me.id_tache.FormattingEnabled = True
        Me.id_tache.Location = New System.Drawing.Point(15, 34)
        Me.id_tache.Name = "id_tache"
        Me.id_tache.Size = New System.Drawing.Size(230, 21)
        Me.id_tache.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "ID TACHE"
        '
        'id_ressource
        '
        Me.id_ressource.FormattingEnabled = True
        Me.id_ressource.Location = New System.Drawing.Point(15, 80)
        Me.id_ressource.Name = "id_ressource"
        Me.id_ressource.Size = New System.Drawing.Size(230, 21)
        Me.id_ressource.TabIndex = 57
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "ID RESSOURCE"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 34)
        Me.Button1.TabIndex = 58
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ligne_modifie
        '
        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(308, 87)
        Me.ligne_modifie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(68, 13)
        Me.ligne_modifie.TabIndex = 61
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(308, 34)
        Me.type_operation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(77, 13)
        Me.type_operation.TabIndex = 60
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False
        '
        'ancien_idt
        '
        Me.ancien_idt.Location = New System.Drawing.Point(310, 59)
        Me.ancien_idt.Margin = New System.Windows.Forms.Padding(2)
        Me.ancien_idt.Name = "ancien_idt"
        Me.ancien_idt.Size = New System.Drawing.Size(146, 20)
        Me.ancien_idt.TabIndex = 59
        Me.ancien_idt.Visible = False
        '
        'ancien_idr
        '
        Me.ancien_idr.Location = New System.Drawing.Point(310, 102)
        Me.ancien_idr.Margin = New System.Windows.Forms.Padding(2)
        Me.ancien_idr.Name = "ancien_idr"
        Me.ancien_idr.Size = New System.Drawing.Size(146, 20)
        Me.ancien_idr.TabIndex = 62
        Me.ancien_idr.Visible = False
        '
        'affectation_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 189)
        Me.Controls.Add(Me.ancien_idr)
        Me.Controls.Add(Me.ligne_modifie)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.ancien_idt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.id_ressource)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.id_tache)
        Me.Controls.Add(Me.Label1)
        Me.Name = "affectation_form"
        Me.Text = "affectation_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents id_tache As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id_ressource As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents ancien_idt As System.Windows.Forms.TextBox
    Friend WithEvents ancien_idr As System.Windows.Forms.TextBox
End Class
