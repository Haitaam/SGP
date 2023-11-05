<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class livrable_form
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
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.ancien_id = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.id_tache = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.noml = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Datel = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.descriptionl = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ligne_modifie
        '
        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(305, 82)
        Me.ligne_modifie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(68, 13)
        Me.ligne_modifie.TabIndex = 69
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(305, 29)
        Me.type_operation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(77, 13)
        Me.type_operation.TabIndex = 68
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False
        '
        'ancien_id
        '
        Me.ancien_id.Location = New System.Drawing.Point(307, 54)
        Me.ancien_id.Margin = New System.Windows.Forms.Padding(2)
        Me.ancien_id.Name = "ancien_id"
        Me.ancien_id.Size = New System.Drawing.Size(146, 20)
        Me.ancien_id.TabIndex = 67
        Me.ancien_id.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(66, 279)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 34)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'id_tache
        '
        Me.id_tache.FormattingEnabled = True
        Me.id_tache.Location = New System.Drawing.Point(16, 238)
        Me.id_tache.Name = "id_tache"
        Me.id_tache.Size = New System.Drawing.Size(230, 21)
        Me.id_tache.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 222)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "ID TACHE"
        '
        'idl
        '
        Me.idl.Location = New System.Drawing.Point(15, 34)
        Me.idl.Margin = New System.Windows.Forms.Padding(2)
        Me.idl.Name = "idl"
        Me.idl.Size = New System.Drawing.Size(231, 20)
        Me.idl.TabIndex = 71
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "ID LIVRABLE"
        '
        'noml
        '
        Me.noml.Location = New System.Drawing.Point(15, 89)
        Me.noml.Margin = New System.Windows.Forms.Padding(2)
        Me.noml.Name = "noml"
        Me.noml.Size = New System.Drawing.Size(107, 20)
        Me.noml.TabIndex = 73
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 13)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "NOM LIVRABLE"
        '
        'Datel
        '
        Me.Datel.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datel.Location = New System.Drawing.Point(134, 89)
        Me.Datel.Name = "Datel"
        Me.Datel.Size = New System.Drawing.Size(112, 20)
        Me.Datel.TabIndex = 75
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(131, 74)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "DATE LIVRABLE"
        '
        'descriptionl
        '
        Me.descriptionl.Location = New System.Drawing.Point(15, 142)
        Me.descriptionl.Margin = New System.Windows.Forms.Padding(2)
        Me.descriptionl.Multiline = True
        Me.descriptionl.Name = "descriptionl"
        Me.descriptionl.Size = New System.Drawing.Size(231, 63)
        Me.descriptionl.TabIndex = 77
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 127)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 13)
        Me.Label5.TabIndex = 76
        Me.Label5.Text = "DESCRIPTION"
        '
        'livrable_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(263, 340)
        Me.Controls.Add(Me.descriptionl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Datel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.noml)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.idl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ligne_modifie)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.ancien_id)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.id_tache)
        Me.Controls.Add(Me.Label1)
        Me.Name = "livrable_form"
        Me.Text = "livrable_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents ancien_id As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents id_tache As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idl As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents noml As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Datel As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents descriptionl As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
