<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class commentaire_form
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
        Me.texte = New System.Windows.Forms.TextBox()
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.ancien_idc = New System.Windows.Forms.TextBox()
        Me.tache = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.membre = New System.Windows.Forms.ComboBox()
        Me.Datec = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idc = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'texte
        '
        Me.texte.Location = New System.Drawing.Point(22, 74)
        Me.texte.Margin = New System.Windows.Forms.Padding(2)
        Me.texte.Multiline = True
        Me.texte.Name = "texte"
        Me.texte.Size = New System.Drawing.Size(231, 61)
        Me.texte.TabIndex = 91
        '
        'ligne_modifie
        '
        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(396, 174)
        Me.ligne_modifie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(68, 13)
        Me.ligne_modifie.TabIndex = 90
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(396, 121)
        Me.type_operation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(77, 13)
        Me.type_operation.TabIndex = 89
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False
        '
        'ancien_idc
        '
        Me.ancien_idc.Location = New System.Drawing.Point(398, 146)
        Me.ancien_idc.Margin = New System.Windows.Forms.Padding(2)
        Me.ancien_idc.Name = "ancien_idc"
        Me.ancien_idc.Size = New System.Drawing.Size(146, 20)
        Me.ancien_idc.TabIndex = 88
        Me.ancien_idc.Visible = False
        '
        'tache
        '
        Me.tache.FormattingEnabled = True
        Me.tache.Items.AddRange(New Object() {"En cours", "En attente", "Terminé"})
        Me.tache.Location = New System.Drawing.Point(24, 153)
        Me.tache.Name = "tache"
        Me.tache.Size = New System.Drawing.Size(229, 21)
        Me.tache.TabIndex = 87
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 137)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 86
        Me.Label7.Text = "Tache"
        '
        'membre
        '
        Me.membre.FormattingEnabled = True
        Me.membre.Location = New System.Drawing.Point(24, 193)
        Me.membre.Name = "membre"
        Me.membre.Size = New System.Drawing.Size(229, 21)
        Me.membre.TabIndex = 85
        '
        'Datec
        '
        Me.Datec.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datec.Location = New System.Drawing.Point(150, 35)
        Me.Datec.Name = "Datec"
        Me.Datec.Size = New System.Drawing.Size(103, 20)
        Me.Datec.TabIndex = 80
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(147, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 79
        Me.Label4.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "Membre"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(68, 233)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 29)
        Me.Button1.TabIndex = 77
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 57)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Texte de commentaire"
        '
        'idc
        '
        Me.idc.Location = New System.Drawing.Point(22, 35)
        Me.idc.Margin = New System.Windows.Forms.Padding(2)
        Me.idc.Name = "idc"
        Me.idc.Size = New System.Drawing.Size(103, 20)
        Me.idc.TabIndex = 75
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "Id commentaire"
        '
        'commentaire_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 293)
        Me.Controls.Add(Me.texte)
        Me.Controls.Add(Me.ligne_modifie)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.ancien_idc)
        Me.Controls.Add(Me.tache)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.membre)
        Me.Controls.Add(Me.Datec)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "commentaire_form"
        Me.Text = "commentaire_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents texte As System.Windows.Forms.TextBox
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents ancien_idc As System.Windows.Forms.TextBox
    Friend WithEvents tache As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents membre As System.Windows.Forms.ComboBox
    Friend WithEvents Datec As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idc As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
