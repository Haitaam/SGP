<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class facture_form
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
        Me.prix = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idf = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Datef = New System.Windows.Forms.DateTimePicker()
        Me.ligne_modifie = New System.Windows.Forms.Label()
        Me.type_operation = New System.Windows.Forms.Label()
        Me.ancien_id = New System.Windows.Forms.TextBox()
        Me.id_projet = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'prix
        '
        Me.prix.Location = New System.Drawing.Point(150, 176)
        Me.prix.Margin = New System.Windows.Forms.Padding(2)
        Me.prix.Name = "prix"
        Me.prix.Size = New System.Drawing.Size(106, 20)
        Me.prix.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(149, 161)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Prix"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 161)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Date facture"
        '
        'nom
        '
        Me.nom.Location = New System.Drawing.Point(22, 128)
        Me.nom.Margin = New System.Windows.Forms.Padding(2)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(233, 20)
        Me.nom.TabIndex = 42
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 113)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Nom client"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(64, 224)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 29)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 64)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Id projet"
        '
        'idf
        '
        Me.idf.Location = New System.Drawing.Point(24, 30)
        Me.idf.Margin = New System.Windows.Forms.Padding(2)
        Me.idf.Name = "idf"
        Me.idf.Size = New System.Drawing.Size(233, 20)
        Me.idf.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Id facture"
        '
        'Datef
        '
        Me.Datef.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Datef.Location = New System.Drawing.Point(22, 177)
        Me.Datef.Name = "Datef"
        Me.Datef.Size = New System.Drawing.Size(107, 20)
        Me.Datef.TabIndex = 47
        '
        'ligne_modifie
        '
        Me.ligne_modifie.AutoSize = True
        Me.ligne_modifie.Location = New System.Drawing.Point(372, 117)
        Me.ligne_modifie.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ligne_modifie.Name = "ligne_modifie"
        Me.ligne_modifie.Size = New System.Drawing.Size(68, 13)
        Me.ligne_modifie.TabIndex = 50
        Me.ligne_modifie.Text = "ligne_modifie"
        Me.ligne_modifie.Visible = False
        '
        'type_operation
        '
        Me.type_operation.AutoSize = True
        Me.type_operation.Location = New System.Drawing.Point(372, 64)
        Me.type_operation.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.type_operation.Name = "type_operation"
        Me.type_operation.Size = New System.Drawing.Size(77, 13)
        Me.type_operation.TabIndex = 49
        Me.type_operation.Text = "type_operation"
        Me.type_operation.Visible = False
        '
        'ancien_id
        '
        Me.ancien_id.Location = New System.Drawing.Point(374, 89)
        Me.ancien_id.Margin = New System.Windows.Forms.Padding(2)
        Me.ancien_id.Name = "ancien_id"
        Me.ancien_id.Size = New System.Drawing.Size(146, 20)
        Me.ancien_id.TabIndex = 48
        Me.ancien_id.Visible = False
        '
        'id_projet
        '
        Me.id_projet.FormattingEnabled = True
        Me.id_projet.Location = New System.Drawing.Point(25, 80)
        Me.id_projet.Name = "id_projet"
        Me.id_projet.Size = New System.Drawing.Size(230, 21)
        Me.id_projet.TabIndex = 51
        '
        'facture_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(290, 281)
        Me.Controls.Add(Me.id_projet)
        Me.Controls.Add(Me.ligne_modifie)
        Me.Controls.Add(Me.type_operation)
        Me.Controls.Add(Me.ancien_id)
        Me.Controls.Add(Me.Datef)
        Me.Controls.Add(Me.prix)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.nom)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idf)
        Me.Controls.Add(Me.Label1)
        Me.Name = "facture_form"
        Me.Text = "facture_form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents prix As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents nom As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents idf As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Datef As System.Windows.Forms.DateTimePicker
    Friend WithEvents ligne_modifie As System.Windows.Forms.Label
    Friend WithEvents type_operation As System.Windows.Forms.Label
    Friend WithEvents ancien_id As System.Windows.Forms.TextBox
    Friend WithEvents id_projet As System.Windows.Forms.ComboBox
End Class
