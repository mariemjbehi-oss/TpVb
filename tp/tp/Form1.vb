Public Class Form1
    Private Sub btnajouter_click(sender As Object, e As EventArgs) Handles btnajouter.Click
        Dim nom As String
        Dim note As Double
        nom = txtNom.text
        note = CDbl(textNote)
        If nom = "" Then
            MessageBox.Show("veuillez indiquer le nom")
            Return
        End If
        If Not (0 <= note <= 20) Then
            MessageBox.Show("veuillez introduire une notre entre 0 et 20")
            Return
        End If
        Etudiant.nom = nom
        Etudiant.note = note
        ajouter(Etudiant)
    End Sub
End Class
