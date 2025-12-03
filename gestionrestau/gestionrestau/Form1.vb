Public Class Form1
    Dim prix As Integer = 0
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboisson.SelectedIndexChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstboisson.Items.Add("café")
        lstboisson.Items.Add("jus d orange")
        lstboisson.Items.Add("eau minerale")
        lstboisson.Items.Add("citronade")
    End Sub

    Private Sub btnannuler_Click(sender As Object, e As EventArgs) Handles btnannuler.Click


    End Sub

    Private Sub btncommander_Click(sender As Object, e As EventArgs) Handles btncommander.Click
        Dim commande As String
        If Rdpizza.Checked Then
            commande = "pizza"
            prix = 10
        ElseIf rdburger.Checked Then
            commande = "burger"
            prix = 8
        Else
            commande = "pate"
            prix = 15
        End If
        For Each ctrl In Grpsupplements.Controls
            If ctrl.checked Then
                commande = commande + " " + ctrl.text
                If ctrl.text = "frommage" Then
                    prix = prix + 2
                ElseIf ctrl.text = "frittes" Then
                    prix = prix + 2
                ElseIf ctrl.text = "dessert" Then
                    prix = prix + 4
                End If
            End If
        Next
        If lstboisson.SelectedIndex = 0 Then
            commande = commande & " " & lstboisson.SelectedItem.text
        End If
        Labelaficher.Text = commande & "total:" & prix
    End Sub
End Class
