<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class compte_form
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
        Me.ancien_idc = New System.Windows.Forms.TextBox()
        Me.membre = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.login = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.type = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ligne_modifie
        '
        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(383, 163)
        Me.ligne_modifie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(68, 13)
        Me.ligne_modifie.TabIndex = 104
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(383, 110)
        Me.type_operation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(77, 13)
        Me.type_operation.TabIndex = 103
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False
        '
        'ancien_idc
        '
        Me.ancien_idc.Location = New System.Drawing.Point(385, 135)
        Me.ancien_idc.Margin = New System.Windows.Forms.Padding(2)
        Me.ancien_idc.Name = "ancien_idc"
        Me.ancien_idc.Size = New System.Drawing.Size(146, 20)
        Me.ancien_idc.TabIndex = 102
        Me.ancien_idc.Visible = False
        '
        'membre
        '
        Me.membre.FormattingEnabled = True
        Me.membre.Location = New System.Drawing.Point(9, 123)
        Me.membre.Name = "membre"
        Me.membre.Size = New System.Drawing.Size(231, 21)
        Me.membre.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 107)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 96
        Me.Label3.Text = "Membre"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(55, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 29)
        Me.Button1.TabIndex = 95
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 60)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 94
        Me.Label2.Text = "Type compte"
        '
        'idc
        '
        Me.idc.Location = New System.Drawing.Point(9, 24)
        Me.idc.Margin = New System.Windows.Forms.Padding(2)
        Me.idc.Name = "idc"
        Me.idc.Size = New System.Drawing.Size(231, 20)
        Me.idc.TabIndex = 93
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 92
        Me.Label1.Text = "ID compte"
        '
        'login
        '
        Me.login.Location = New System.Drawing.Point(9, 171)
        Me.login.Margin = New System.Windows.Forms.Padding(2)
        Me.login.Name = "login"
        Me.login.Size = New System.Drawing.Size(107, 20)
        Me.login.TabIndex = 109
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 156)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Login"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 156)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "Password"
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(133, 171)
        Me.password.Margin = New System.Windows.Forms.Padding(2)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(107, 20)
        Me.password.TabIndex = 112
        '
        'type
        '
        Me.type.FormattingEnabled = True
        Me.type.Items.AddRange(New Object() {"admin", "utilisateur"})
        Me.type.Location = New System.Drawing.Point(9, 76)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(231, 21)
        Me.type.TabIndex = 113
        '
        'compte_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(249, 265)
        Me.Controls.Add(Me.type)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.login)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ligne_modifie)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.ancien_idc)
        Me.Controls.Add(Me.membre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "compte_form"
        Me.Text = "compte_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents ancien_idc As System.Windows.Forms.TextBox
    Friend WithEvents membre As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents login As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents password As System.Windows.Forms.TextBox
    Friend WithEvents type As System.Windows.Forms.ComboBox
End Class
