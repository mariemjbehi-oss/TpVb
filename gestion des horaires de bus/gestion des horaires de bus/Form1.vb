Public Class Form1
    Private Sub lstligne_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstligne.SelectedIndexChanged

    End Sub

    Private Sub btnajouter_Click(sender As Object, e As EventArgs) Handles btnajouter.Click
        Dim r As Reservation
        If lstligne.SelectedIndex = -1 Then
            ErrorProvider1.SetError(lstligne, "veuillez selectionner une ligne")
        End If
        r.ligne = lstligne.Text
        If lstdepart.SelectedIndex = -1 Then
            ErrorProvider1.SetError(lstdepart, "veuillez selectionner la ville depart")
        End If
        r.villedepart = lstdepart.Text
        If lstarrivee.SelectedIndex = -1 Then
            ErrorProvider1.SetError(lstarrivee, "veuillez selectionner la ville d arrive")

        End If
        If lstarrivee.Text = lstdepart.Text Then
            ErrorProvider1.SetError(lstarrivee, "veuillez selectionner une ville de depart differente")

        End If
        r.villearrive = lstarrivee.Text
    End Sub
End Class
