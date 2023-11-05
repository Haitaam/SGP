<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.ancien_idprojet = New System.Windows.Forms.TextBox()
        Me.nom_projet = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.id_projet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.description_projet = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.date_debut = New System.Windows.Forms.DateTimePicker()
        Me.date_fin = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ligne_modifie
        '
        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(254, 52)
        Me.ligne_modifie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(68, 13)
        Me.ligne_modifie.TabIndex = 15
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(254, -1)
        Me.type_operation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(77, 13)
        Me.type_operation.TabIndex = 14
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False
        '
        'ancien_idprojet
        '
        Me.ancien_idprojet.Location = New System.Drawing.Point(256, 24)
        Me.ancien_idprojet.Margin = New System.Windows.Forms.Padding(2)
        Me.ancien_idprojet.Name = "ancien_idprojet"
        Me.ancien_idprojet.Size = New System.Drawing.Size(146, 20)
        Me.ancien_idprojet.TabIndex = 13
        Me.ancien_idprojet.Visible = False
        '
        'nom_projet
        '
        Me.nom_projet.Location = New System.Drawing.Point(14, 73)
        Me.nom_projet.Margin = New System.Windows.Forms.Padding(2)
        Me.nom_projet.Multiline = True
        Me.nom_projet.Name = "nom_projet"
        Me.nom_projet.Size = New System.Drawing.Size(233, 73)
        Me.nom_projet.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Nom"
        '
        'id_projet
        '
        Me.id_projet.Location = New System.Drawing.Point(14, 24)
        Me.id_projet.Margin = New System.Windows.Forms.Padding(2)
        Me.id_projet.Name = "id_projet"
        Me.id_projet.Size = New System.Drawing.Size(233, 20)
        Me.id_projet.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "id_projet"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(54, 377)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 29)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'description_projet
        '
        Me.description_projet.Location = New System.Drawing.Point(12, 182)
        Me.description_projet.Margin = New System.Windows.Forms.Padding(2)
        Me.description_projet.Multiline = True
        Me.description_projet.Name = "description_projet"
        Me.description_projet.Size = New System.Drawing.Size(233, 131)
        Me.description_projet.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "description"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 324)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "date de debut"
        '
        'date_debut
        '
        Me.date_debut.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_debut.Location = New System.Drawing.Point(14, 340)
        Me.date_debut.Name = "date_debut"
        Me.date_debut.Size = New System.Drawing.Size(103, 20)
        Me.date_debut.TabIndex = 22
        '
        'date_fin
        '
        Me.date_fin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.date_fin.Location = New System.Drawing.Point(142, 340)
        Me.date_fin.Name = "date_fin"
        Me.date_fin.Size = New System.Drawing.Size(103, 20)
        Me.date_fin.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 324)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "date de fin"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 428)
        Me.Controls.Add(Me.date_fin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.date_debut)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.description_projet)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ligne_modifie)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.ancien_idprojet)
        Me.Controls.Add(Me.nom_projet)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_projet)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents ancien_idprojet As System.Windows.Forms.TextBox
    Friend WithEvents nom_projet As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id_projet As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents description_projet As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents date_debut As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_fin As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
