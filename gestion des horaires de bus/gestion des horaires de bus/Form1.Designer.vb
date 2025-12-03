<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        GroupBox1 = New GroupBox()
        chkwifi = New GroupBox()
        GroupBox3 = New GroupBox()
        btnajouter = New Button()
        btnmodifier = New Button()
        btnsupprimer = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        timedepart = New DateTimePicker()
        lstligne = New ComboBox()
        lstdepart = New ComboBox()
        lstarrivee = New ComboBox()
        DataGridView1 = New DataGridView()
        timearrivee = New DateTimePicker()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Column7 = New DataGridViewTextBoxColumn()
        chkclimatisation = New CheckBox()
        CheckBox2 = New CheckBox()
        chkbus = New CheckBox()
        rdregulier = New RadioButton()
        rdexpress = New RadioButton()
        rdnocturne = New RadioButton()
        NumericUpDown1 = New NumericUpDown()
        ErrorProvider1 = New ErrorProvider(components)
        GroupBox1.SuspendLayout()
        chkwifi.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Controls.Add(timearrivee)
        GroupBox1.Controls.Add(lstarrivee)
        GroupBox1.Controls.Add(lstdepart)
        GroupBox1.Controls.Add(lstligne)
        GroupBox1.Controls.Add(timedepart)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(btnsupprimer)
        GroupBox1.Controls.Add(btnmodifier)
        GroupBox1.Controls.Add(btnajouter)
        GroupBox1.Location = New Point(12, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(695, 331)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "informations du trajet"
        ' 
        ' chkwifi
        ' 
        chkwifi.Controls.Add(chkbus)
        chkwifi.Controls.Add(CheckBox2)
        chkwifi.Controls.Add(chkclimatisation)
        chkwifi.Location = New Point(731, 24)
        chkwifi.Name = "chkwifi"
        chkwifi.Size = New Size(214, 142)
        chkwifi.TabIndex = 1
        chkwifi.TabStop = False
        chkwifi.Text = "option"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(rdnocturne)
        GroupBox3.Controls.Add(rdexpress)
        GroupBox3.Controls.Add(rdregulier)
        GroupBox3.Location = New Point(731, 172)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(219, 164)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "type de trajet"
        ' 
        ' btnajouter
        ' 
        btnajouter.Location = New Point(115, 291)
        btnajouter.Name = "btnajouter"
        btnajouter.Size = New Size(94, 29)
        btnajouter.TabIndex = 0
        btnajouter.Text = "ajouter"
        btnajouter.UseVisualStyleBackColor = True
        ' 
        ' btnmodifier
        ' 
        btnmodifier.Location = New Point(233, 291)
        btnmodifier.Name = "btnmodifier"
        btnmodifier.Size = New Size(94, 29)
        btnmodifier.TabIndex = 1
        btnmodifier.Text = "modifier"
        btnmodifier.UseVisualStyleBackColor = True
        ' 
        ' btnsupprimer
        ' 
        btnsupprimer.Location = New Point(346, 291)
        btnsupprimer.Name = "btnsupprimer"
        btnsupprimer.Size = New Size(94, 29)
        btnsupprimer.TabIndex = 2
        btnsupprimer.Text = "supprimer"
        btnsupprimer.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 20)
        Label1.TabIndex = 3
        Label1.Text = "ligne:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 102)
        Label2.Name = "Label2"
        Label2.Size = New Size(87, 20)
        Label2.TabIndex = 4
        Label2.Text = "ville depart:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(80, 20)
        Label3.TabIndex = 5
        Label3.Text = "ville arrive:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 177)
        Label4.Name = "Label4"
        Label4.Size = New Size(97, 20)
        Label4.TabIndex = 6
        Label4.Text = "heure depart:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(25, 247)
        Label5.Name = "Label5"
        Label5.Size = New Size(90, 20)
        Label5.TabIndex = 7
        Label5.Text = "heure arrive:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(22, 295)
        Label6.Name = "Label6"
        Label6.Size = New Size(48, 20)
        Label6.TabIndex = 8
        Label6.Text = "place:"
        ' 
        ' timedepart
        ' 
        timedepart.Format = DateTimePickerFormat.Time
        timedepart.Location = New Point(151, 172)
        timedepart.Name = "timedepart"
        timedepart.Size = New Size(250, 27)
        timedepart.TabIndex = 9
        ' 
        ' lstligne
        ' 
        lstligne.FormattingEnabled = True
        lstligne.Items.AddRange(New Object() {"ligne1", "ligne2", "ligne3"})
        lstligne.Location = New Point(151, 64)
        lstligne.Name = "lstligne"
        lstligne.Size = New Size(151, 28)
        lstligne.TabIndex = 10
        ' 
        ' lstdepart
        ' 
        lstdepart.FormattingEnabled = True
        lstdepart.Items.AddRange(New Object() {"bizerte", "manzel jemil", "manzel abd errahmen"})
        lstdepart.Location = New Point(151, 98)
        lstdepart.Name = "lstdepart"
        lstdepart.Size = New Size(151, 28)
        lstdepart.TabIndex = 11
        ' 
        ' lstarrivee
        ' 
        lstarrivee.FormattingEnabled = True
        lstarrivee.Items.AddRange(New Object() {"bizerte", "manzel jemil", "manzel abd errahmen"})
        lstarrivee.Location = New Point(149, 132)
        lstarrivee.Name = "lstarrivee"
        lstarrivee.Size = New Size(151, 28)
        lstarrivee.TabIndex = 12
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5, Column6, Column7})
        DataGridView1.Location = New Point(12, 358)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(933, 188)
        DataGridView1.TabIndex = 13
        ' 
        ' timearrivee
        ' 
        timearrivee.Format = DateTimePickerFormat.Time
        timearrivee.Location = New Point(154, 209)
        timearrivee.Name = "timearrivee"
        timearrivee.Size = New Size(250, 27)
        timearrivee.TabIndex = 14
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ligne"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.Width = 125
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "depart"
        Column2.MinimumWidth = 6
        Column2.Name = "Column2"
        Column2.Width = 125
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "arrivee"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.Width = 125
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "heure depart"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.Width = 125
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "heure arrivee"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.Width = 125
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "places"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.Width = 125
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "options"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.Width = 125
        ' 
        ' chkclimatisation
        ' 
        chkclimatisation.AutoSize = True
        chkclimatisation.Location = New Point(13, 32)
        chkclimatisation.Name = "chkclimatisation"
        chkclimatisation.Size = New Size(125, 24)
        chkclimatisation.TabIndex = 0
        chkclimatisation.Text = "climatiosation"
        chkclimatisation.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(13, 66)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(55, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "wifi"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' chkbus
        ' 
        chkbus.AutoSize = True
        chkbus.Location = New Point(13, 96)
        chkbus.Name = "chkbus"
        chkbus.Size = New Size(108, 24)
        chkbus.TabIndex = 2
        chkbus.Text = "bus a etage"
        chkbus.UseVisualStyleBackColor = True
        ' 
        ' rdregulier
        ' 
        rdregulier.AutoSize = True
        rdregulier.Location = New Point(12, 35)
        rdregulier.Name = "rdregulier"
        rdregulier.Size = New Size(81, 24)
        rdregulier.TabIndex = 0
        rdregulier.TabStop = True
        rdregulier.Text = "regulier"
        rdregulier.UseVisualStyleBackColor = True
        ' 
        ' rdexpress
        ' 
        rdexpress.AutoSize = True
        rdexpress.Location = New Point(12, 70)
        rdexpress.Name = "rdexpress"
        rdexpress.Size = New Size(79, 24)
        rdexpress.TabIndex = 1
        rdexpress.TabStop = True
        rdexpress.Text = "express"
        rdexpress.UseVisualStyleBackColor = True
        ' 
        ' rdnocturne
        ' 
        rdnocturne.AutoSize = True
        rdnocturne.Location = New Point(13, 109)
        rdnocturne.Name = "rdnocturne"
        rdnocturne.Size = New Size(88, 24)
        rdnocturne.TabIndex = 2
        rdnocturne.TabStop = True
        rdnocturne.Text = "nocturne"
        rdnocturne.UseVisualStyleBackColor = True
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(157, 245)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(150, 27)
        NumericUpDown1.TabIndex = 15
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1084, 472)
        Controls.Add(GroupBox3)
        Controls.Add(DataGridView1)
        Controls.Add(chkwifi)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        chkwifi.ResumeLayout(False)
        chkwifi.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnsupprimer As Button
    Friend WithEvents btnmodifier As Button
    Friend WithEvents btnajouter As Button
    Friend WithEvents chkwifi As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents lstarrivee As ComboBox
    Friend WithEvents lstdepart As ComboBox
    Friend WithEvents lstligne As ComboBox
    Friend WithEvents timedepart As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents timearrivee As DateTimePicker
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents chkbus As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents chkclimatisation As CheckBox
    Friend WithEvents rdnocturne As RadioButton
    Friend WithEvents rdexpress As RadioButton
    Friend WithEvents rdregulier As RadioButton
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
