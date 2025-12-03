<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class label9
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Label1 = New Label()
        label6 = New Label()
        label = New Label()
        Label4 = New Label()
        btnajouter = New Button()
        btnannuler = New Button()
        Textnom = New TextBox()
        Textprenom = New TextBox()
        dgvlisteetudiants = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        lbldate = New Label()
        txtage = New NumericUpDown()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvlisteetudiants, ComponentModel.ISupportInitialize).BeginInit()
        CType(txtage, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Simple Outline Pat", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(178))
        Label1.Location = New Point(70, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(308, 33)
        Label1.TabIndex = 0
        Label1.Text = "ajouter un nouveau patient"
        ' 
        ' label6
        ' 
        label6.AutoSize = True
        label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label6.Location = New Point(76, 113)
        label6.Name = "label6"
        label6.Size = New Size(41, 20)
        label6.TabIndex = 1
        label6.Text = "nom"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        label.Location = New Point(80, 167)
        label.Name = "label"
        label.Size = New Size(63, 20)
        label.TabIndex = 2
        label.Text = "prenom"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(80, 225)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 20)
        Label4.TabIndex = 3
        Label4.Text = "age"
        ' 
        ' btnajouter
        ' 
        btnajouter.ForeColor = SystemColors.InfoText
        btnajouter.Location = New Point(70, 297)
        btnajouter.Name = "btnajouter"
        btnajouter.Size = New Size(94, 29)
        btnajouter.TabIndex = 4
        btnajouter.Text = "ajouter"
        btnajouter.UseVisualStyleBackColor = True
        ' 
        ' btnannuler
        ' 
        btnannuler.Location = New Point(205, 297)
        btnannuler.Name = "btnannuler"
        btnannuler.Size = New Size(94, 29)
        btnannuler.TabIndex = 5
        btnannuler.Text = "annuler"
        btnannuler.UseVisualStyleBackColor = True
        ' 
        ' Textnom
        ' 
        Textnom.Location = New Point(189, 113)
        Textnom.Name = "Textnom"
        Textnom.Size = New Size(159, 27)
        Textnom.TabIndex = 6
        ' 
        ' Textprenom
        ' 
        Textprenom.Location = New Point(189, 167)
        Textprenom.Name = "Textprenom"
        Textprenom.Size = New Size(159, 27)
        Textprenom.TabIndex = 7
        ' 
        ' dgvlisteetudiants
        ' 
        dgvlisteetudiants.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvlisteetudiants.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4})
        dgvlisteetudiants.Location = New Point(469, 138)
        dgvlisteetudiants.Name = "dgvlisteetudiants"
        dgvlisteetudiants.RowHeadersWidth = 51
        dgvlisteetudiants.Size = New Size(537, 188)
        dgvlisteetudiants.TabIndex = 9
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "code"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "nom"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "prenom"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "age"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' lbldate
        ' 
        lbldate.AutoSize = True
        lbldate.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lbldate.Location = New Point(564, 51)
        lbldate.Name = "lbldate"
        lbldate.Size = New Size(319, 31)
        lbldate.TabIndex = 10
        lbldate.Text = "date du jour 30 octobre 2025"
        ' 
        ' txtage
        ' 
        txtage.Location = New Point(189, 225)
        txtage.Name = "txtage"
        txtage.Size = New Size(159, 27)
        txtage.TabIndex = 11
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' label9
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Green
        ClientSize = New Size(1064, 450)
        Controls.Add(txtage)
        Controls.Add(lbldate)
        Controls.Add(dgvlisteetudiants)
        Controls.Add(Textprenom)
        Controls.Add(Textnom)
        Controls.Add(btnannuler)
        Controls.Add(btnajouter)
        Controls.Add(Label4)
        Controls.Add(label)
        Controls.Add(label6)
        Controls.Add(Label1)
        Name = "label9"
        Text = "Form1"
        CType(dgvlisteetudiants, ComponentModel.ISupportInitialize).EndInit()
        CType(txtage, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents label6 As Label
    Friend WithEvents label As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnajouter As Button
    Friend WithEvents btnannuler As Button
    Friend WithEvents Textnom As TextBox
    Friend WithEvents Textprenom As TextBox
    Friend WithEvents dgvlisteetudiants As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents lbldate As Label
    Friend WithEvents txtage As NumericUpDown
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
