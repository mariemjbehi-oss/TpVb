Public Class Form1
    Dim a As Integer
    Dim b As Integer
    Dim s As Integer
    Dim ch As String
    Dim test As Boolean = False
    Private Sub btnplus_Click(sender As Object, e As EventArgs) Handles btnplus.Click
        a = Val(txta.Text)
        b = Val(txtb.Text)
        s = a + b
        ch = txta.Text & "+" & txtb.Text & "=" & s
        test = True
    End Sub

    Private Sub btnmoins_Click(sender As Object, e As EventArgs) Handles btnmoins.Click
        a = Val(txta.Text)
        b = Val(txtb.Text)
        s = a - b
        ch = txta.Text & "-" & txtb.Text & "=" & s
        test = True

    End Sub

    Private Sub btnres_Click(sender As Object, e As EventArgs) Handles btnres.Click
        If txta.Text = "" Or txtb.Text = "" Then
            MessageBox.Show("introduire la valeur")
            Text = False
        End If
        If test = True Then
            txtres.Text = ch
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txta.Text = ""
        txtb.Text = ""
        txtres.Text = ""
        test = False
    End Sub
End Class
