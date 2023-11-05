<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class equipe_membre_form
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_projet = New System.Windows.Forms.ComboBox()
        Me.id_membre = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.role = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.ancien_id = New System.Windows.Forms.TextBox()
        Me.ancien_idm = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id projet"
        '
        'id_projet
        '
        Me.id_projet.FormattingEnabled = True
        Me.id_projet.Location = New System.Drawing.Point(15, 37)
        Me.id_projet.Name = "id_projet"
        Me.id_projet.Size = New System.Drawing.Size(218, 21)
        Me.id_projet.TabIndex = 1
        '
        'id_membre
        '
        Me.id_membre.FormattingEnabled = True
        Me.id_membre.Location = New System.Drawing.Point(15, 95)
        Me.id_membre.Name = "id_membre"
        Me.id_membre.Size = New System.Drawing.Size(218, 21)
        Me.id_membre.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id membre"
        '
        'role
        '
        Me.role.Location = New System.Drawing.Point(15, 155)
        Me.role.Name = "role"
        Me.role.Size = New System.Drawing.Size(218, 20)
        Me.role.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Role"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(55, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 30)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Ajouter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ligne_modifie
        '
        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(255, 74)
        Me.ligne_modifie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(68, 13)
        Me.ligne_modifie.TabIndex = 18
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(255, 21)
        Me.type_operation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(77, 13)
        Me.type_operation.TabIndex = 17
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False
        '
        'ancien_id
        '
        Me.ancien_id.Location = New System.Drawing.Point(257, 46)
        Me.ancien_id.Margin = New System.Windows.Forms.Padding(2)
        Me.ancien_id.Name = "ancien_id"
        Me.ancien_id.Size = New System.Drawing.Size(146, 20)
        Me.ancien_id.TabIndex = 16
        Me.ancien_id.Visible = False
        '
        'ancien_idm
        '
        Me.ancien_idm.Location = New System.Drawing.Point(257, 96)
        Me.ancien_idm.Margin = New System.Windows.Forms.Padding(2)
        Me.ancien_idm.Name = "ancien_idm"
        Me.ancien_idm.Size = New System.Drawing.Size(146, 20)
        Me.ancien_idm.TabIndex = 19
        Me.ancien_idm.Visible = False
        '
        'equipe_membre_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(250, 242)
        Me.Controls.Add(Me.ancien_idm)
        Me.Controls.Add(Me.ligne_modifie)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.ancien_id)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.role)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.id_membre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_projet)
        Me.Controls.Add(Me.Label1)
        Me.Name = "equipe_membre_form"
        Me.Text = "equipe_membre_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id_projet As System.Windows.Forms.ComboBox
    Friend WithEvents id_membre As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents role As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents ancien_id As System.Windows.Forms.TextBox
    Friend WithEvents ancien_idm As System.Windows.Forms.TextBox
End Class
