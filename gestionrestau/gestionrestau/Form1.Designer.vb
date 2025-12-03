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
        GroupBox1 = New GroupBox()
        Rdpates = New RadioButton()
        rdburger = New RadioButton()
        Rdpizza = New RadioButton()
        Grpsupplements = New GroupBox()
        Chkdessert = New CheckBox()
        Chkfrittes = New CheckBox()
        Chkfromage = New CheckBox()
        lstboisson = New ListBox()
        Label1 = New Label()
        Label2 = New Label()
        btncommander = New Button()
        btnannuler = New Button()
        lblafficher = New Label()
        Labelaficher = New Label()
        GroupBox1.SuspendLayout()
        Grpsupplements.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Rdpates)
        GroupBox1.Controls.Add(rdburger)
        GroupBox1.Controls.Add(Rdpizza)
        GroupBox1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.ForeColor = SystemColors.ActiveCaptionText
        GroupBox1.Location = New Point(12, 24)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(162, 182)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "choix du plat"
        ' 
        ' Rdpates
        ' 
        Rdpates.AutoSize = True
        Rdpates.Location = New Point(27, 125)
        Rdpates.Name = "Rdpates"
        Rdpates.Size = New Size(68, 24)
        Rdpates.TabIndex = 2
        Rdpates.TabStop = True
        Rdpates.Text = "pates"
        Rdpates.UseVisualStyleBackColor = True
        ' 
        ' rdburger
        ' 
        rdburger.AutoSize = True
        rdburger.Location = New Point(23, 78)
        rdburger.Name = "rdburger"
        rdburger.Size = New Size(77, 24)
        rdburger.TabIndex = 1
        rdburger.TabStop = True
        rdburger.Text = "burger"
        rdburger.UseVisualStyleBackColor = True
        ' 
        ' Rdpizza
        ' 
        Rdpizza.AutoSize = True
        Rdpizza.Location = New Point(20, 36)
        Rdpizza.Name = "Rdpizza"
        Rdpizza.Size = New Size(65, 24)
        Rdpizza.TabIndex = 0
        Rdpizza.TabStop = True
        Rdpizza.Text = "pizza"
        Rdpizza.UseVisualStyleBackColor = True
        ' 
        ' Grpsupplements
        ' 
        Grpsupplements.Controls.Add(Chkdessert)
        Grpsupplements.Controls.Add(Chkfrittes)
        Grpsupplements.Controls.Add(Chkfromage)
        Grpsupplements.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Grpsupplements.Location = New Point(12, 232)
        Grpsupplements.Name = "Grpsupplements"
        Grpsupplements.Size = New Size(250, 125)
        Grpsupplements.TabIndex = 1
        Grpsupplements.TabStop = False
        Grpsupplements.Text = "supplement"
        ' 
        ' Chkdessert
        ' 
        Chkdessert.AutoSize = True
        Chkdessert.Location = New Point(14, 95)
        Chkdessert.Name = "Chkdessert"
        Chkdessert.Size = New Size(82, 24)
        Chkdessert.TabIndex = 2
        Chkdessert.Text = "dessert"
        Chkdessert.UseVisualStyleBackColor = True
        ' 
        ' Chkfrittes
        ' 
        Chkfrittes.AutoSize = True
        Chkfrittes.Location = New Point(14, 53)
        Chkfrittes.Name = "Chkfrittes"
        Chkfrittes.Size = New Size(74, 24)
        Chkfrittes.TabIndex = 1
        Chkfrittes.Text = "frittes"
        Chkfrittes.UseVisualStyleBackColor = True
        ' 
        ' Chkfromage
        ' 
        Chkfromage.AutoSize = True
        Chkfromage.Location = New Point(14, 23)
        Chkfromage.Name = "Chkfromage"
        Chkfromage.Size = New Size(91, 24)
        Chkfromage.TabIndex = 0
        Chkfromage.Text = "fromage"
        Chkfromage.UseVisualStyleBackColor = True
        ' 
        ' lstboisson
        ' 
        lstboisson.FormattingEnabled = True
        lstboisson.Location = New Point(501, 80)
        lstboisson.Name = "lstboisson"
        lstboisson.Size = New Size(196, 84)
        lstboisson.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(353, 84)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 20)
        Label1.TabIndex = 3
        Label1.Text = "boisson"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(357, 144)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 20)
        Label2.TabIndex = 4
        Label2.Text = "facture"
        ' 
        ' btncommander
        ' 
        btncommander.Location = New Point(294, 314)
        btncommander.Name = "btncommander"
        btncommander.Size = New Size(122, 29)
        btncommander.TabIndex = 5
        btncommander.Text = "commander"
        btncommander.UseVisualStyleBackColor = True
        ' 
        ' btnannuler
        ' 
        btnannuler.Location = New Point(444, 314)
        btnannuler.Name = "btnannuler"
        btnannuler.Size = New Size(94, 29)
        btnannuler.TabIndex = 6
        btnannuler.Text = "annuler"
        btnannuler.UseVisualStyleBackColor = True
        ' 
        ' lblafficher
        ' 
        lblafficher.AutoSize = True
        lblafficher.Location = New Point(357, 211)
        lblafficher.Name = "lblafficher"
        lblafficher.Size = New Size(0, 20)
        lblafficher.TabIndex = 7
        ' 
        ' Labelaficher
        ' 
        Labelaficher.AutoSize = True
        Labelaficher.Location = New Point(380, 209)
        Labelaficher.Name = "Labelaficher"
        Labelaficher.Size = New Size(53, 20)
        Labelaficher.TabIndex = 8
        Labelaficher.Text = "Label3"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(886, 460)
        Controls.Add(Labelaficher)
        Controls.Add(lblafficher)
        Controls.Add(btnannuler)
        Controls.Add(btncommander)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(lstboisson)
        Controls.Add(Grpsupplements)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Grpsupplements.ResumeLayout(False)
        Grpsupplements.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Rdpates As RadioButton
    Friend WithEvents rdburger As RadioButton
    Friend WithEvents Rdpizza As RadioButton
    Friend WithEvents Grpsupplements As GroupBox
    Friend WithEvents Chkdessert As CheckBox
    Friend WithEvents Chkfrittes As CheckBox
    Friend WithEvents Chkfromage As CheckBox
    Friend WithEvents lstboisson As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btncommander As Button
    Friend WithEvents btnannuler As Button
    Friend WithEvents lblafficher As Label
    Friend WithEvents Labelaficher As Label

End Class
