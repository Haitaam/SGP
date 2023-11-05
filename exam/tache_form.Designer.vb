<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tache_form
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
        Me.Dated = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.description = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.datef = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.id_projet = New System.Windows.Forms.ComboBox()
        Me.statut = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.ancien_idtache = New System.Windows.Forms.TextBox()
        Me.nomt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Dated
        '
        Me.Dated.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dated.Location = New System.Drawing.Point(163, 128)
        Me.Dated.Name = "Dated"
        Me.Dated.Size = New System.Drawing.Size(95, 20)
        Me.Dated.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(163, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Date debut"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Id projet"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(62, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 29)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "nom tache"
        '
        'idt
        '
        Me.idt.Location = New System.Drawing.Point(27, 26)
        Me.idt.Margin = New System.Windows.Forms.Padding(2)
        Me.idt.Name = "idt"
        Me.idt.Size = New System.Drawing.Size(64, 20)
        Me.idt.TabIndex = 53
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "Id tache"
        '
        'description
        '
        Me.description.Location = New System.Drawing.Point(26, 127)
        Me.description.Margin = New System.Windows.Forms.Padding(2)
        Me.description.Multiline = True
        Me.description.Name = "description"
        Me.description.Size = New System.Drawing.Size(130, 78)
        Me.description.TabIndex = 64
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 112)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Description"
        '
        'datef
        '
        Me.datef.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.datef.Location = New System.Drawing.Point(163, 181)
        Me.datef.Name = "datef"
        Me.datef.Size = New System.Drawing.Size(95, 20)
        Me.datef.TabIndex = 66
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(163, 165)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Date fin"
        '
        'id_projet
        '
        Me.id_projet.FormattingEnabled = True
        Me.id_projet.Location = New System.Drawing.Point(28, 74)
        Me.id_projet.Name = "id_projet"
        Me.id_projet.Size = New System.Drawing.Size(230, 21)
        Me.id_projet.TabIndex = 67
        '
        'statut
        '
        Me.statut.FormattingEnabled = True
        Me.statut.Items.AddRange(New Object() {"En cours", "En attente", "Terminé"})
        Me.statut.Location = New System.Drawing.Point(32, 234)
        Me.statut.Name = "statut"
        Me.statut.Size = New System.Drawing.Size(226, 21)
        Me.statut.TabIndex = 69
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(28, 218)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "Nom tache"
        '
        'ligne_modifie
        '
        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(401, 165)
        Me.ligne_modifie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(68, 13)
        Me.ligne_modifie.TabIndex = 72
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(401, 112)
        Me.type_operation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(77, 13)
        Me.type_operation.TabIndex = 71
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False
        '
        'ancien_idtache
        '
        Me.ancien_idtache.Location = New System.Drawing.Point(403, 137)
        Me.ancien_idtache.Margin = New System.Windows.Forms.Padding(2)
        Me.ancien_idtache.Name = "ancien_idtache"
        Me.ancien_idtache.Size = New System.Drawing.Size(146, 20)
        Me.ancien_idtache.TabIndex = 70
        Me.ancien_idtache.Visible = False
        '
        'nomt
        '
        Me.nomt.Location = New System.Drawing.Point(102, 26)
        Me.nomt.Margin = New System.Windows.Forms.Padding(2)
        Me.nomt.Name = "nomt"
        Me.nomt.Size = New System.Drawing.Size(156, 20)
        Me.nomt.TabIndex = 73
        '
        'tache_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 338)
        Me.Controls.Add(Me.nomt)
        Me.Controls.Add(Me.ligne_modifie)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.ancien_idtache)
        Me.Controls.Add(Me.statut)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.id_projet)
        Me.Controls.Add(Me.datef)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.description)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Dated)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idt)
        Me.Controls.Add(Me.Label1)
        Me.Name = "tache_form"
        Me.Text = "tache_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dated As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents description As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents datef As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents id_projet As System.Windows.Forms.ComboBox
    Friend WithEvents statut As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents ancien_idtache As System.Windows.Forms.TextBox
    Friend WithEvents nomt As System.Windows.Forms.TextBox
End Class
