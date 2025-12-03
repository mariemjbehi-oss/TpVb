Imports System.DirectoryServices.ActiveDirectory

Public Class label9
    Private Sub btnajouter_Click(sender As Object, e As EventArgs) Handles btnajouter.Click
        Dim A As patient
        Dim nom As String
        Dim prenom As String
        Dim age As Integer
        If String.IsNullOrWhiteSpace(Textnom.Text) Then
            ErrorProvider1.SetError(Textnom, "nom invalide")
            Return
        End If
        If String.IsNullOrWhiteSpace(Textprenom.Text) Then
            ErrorProvider1.SetError(Textprenom, "nom invalide")
            Return
        End If
        age = CInt(txtage.Text)
        A.nom = Textnom.Text
        A.prenom = Textprenom.Text
        A.age = txtage.Text
        ajouterpatients(A)
        init()
        MAJ_DGV()
    End Sub
    Private Sub init()
        txtage.ResetText()
        Textnom.Clear()
        Textprenom.Clear()
    End Sub
    Private Sub MAJ_DGV()
        dgvlisteetudiants.Rows.Clear()
        For Each p As patient In listepatients
            dgvlisteetudiants.Rows.Add(p.code, p.nom, p.prenom, p.age)
        Next
    End Sub
    Private Sub Frmajouterpatient_load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbldate.Text = Date.Today.ToLongDateString()
    End Sub

    Private Sub Textnom_TextChanged(sender As Object, e As EventArgs) Handles Textnom.TextChanged

    End Sub
End Class
