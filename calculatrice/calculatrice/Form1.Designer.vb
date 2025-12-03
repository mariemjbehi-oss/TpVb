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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txta = New TextBox()
        txtb = New TextBox()
        txtres = New TextBox()
        btnplus = New Button()
        btnmoins = New Button()
        btnres = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(133, 73)
        Label1.Name = "Label1"
        Label1.Size = New Size(17, 20)
        Label1.TabIndex = 0
        Label1.Text = "a"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(133, 134)
        Label2.Name = "Label2"
        Label2.Size = New Size(18, 20)
        Label2.TabIndex = 1
        Label2.Text = "b"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(133, 191)
        Label3.Name = "Label3"
        Label3.Size = New Size(28, 20)
        Label3.TabIndex = 2
        Label3.Text = "res"
        ' 
        ' txta
        ' 
        txta.Location = New Point(262, 73)
        txta.Name = "txta"
        txta.Size = New Size(125, 27)
        txta.TabIndex = 3
        ' 
        ' txtb
        ' 
        txtb.Location = New Point(262, 131)
        txtb.Name = "txtb"
        txtb.Size = New Size(125, 27)
        txtb.TabIndex = 4
        ' 
        ' txtres
        ' 
        txtres.Location = New Point(262, 188)
        txtres.Name = "txtres"
        txtres.Size = New Size(125, 27)
        txtres.TabIndex = 5
        ' 
        ' btnplus
        ' 
        btnplus.Location = New Point(446, 73)
        btnplus.Name = "btnplus"
        btnplus.Size = New Size(94, 29)
        btnplus.TabIndex = 6
        btnplus.Text = "+"
        btnplus.UseVisualStyleBackColor = True
        ' 
        ' btnmoins
        ' 
        btnmoins.Location = New Point(446, 134)
        btnmoins.Name = "btnmoins"
        btnmoins.Size = New Size(94, 29)
        btnmoins.TabIndex = 7
        btnmoins.Text = "-"
        btnmoins.UseVisualStyleBackColor = True
        ' 
        ' btnres
        ' 
        btnres.Location = New Point(446, 187)
        btnres.Name = "btnres"
        btnres.Size = New Size(94, 29)
        btnres.TabIndex = 8
        btnres.Text = "="
        btnres.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(357, 274)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 9
        Button1.Text = "reset"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(btnres)
        Controls.Add(btnmoins)
        Controls.Add(btnplus)
        Controls.Add(txtres)
        Controls.Add(txtb)
        Controls.Add(txta)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txta As TextBox
    Friend WithEvents txtb As TextBox
    Friend WithEvents txtres As TextBox
    Friend WithEvents btnplus As Button
    Friend WithEvents btnmoins As Button
    Friend WithEvents btnres As Button
    Friend WithEvents Button1 As Button

End Class
