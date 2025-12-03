Module patients
    Public Structure patient
        Dim code As Integer
        Dim nom As String
        Dim prenom As String
        Dim age As Integer
    End Structure
    Public listepatients As List(Of patient)
    Public Sub ajouterpatients(p As patient)
        If listepatients Is Nothing Then
            listepatients = New List(Of patient)
        End If
        p.code = listepatients.Count
        listepatients.Add(p)
    End Sub



End Module
