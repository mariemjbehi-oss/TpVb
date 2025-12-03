Structure Etudiants

    Public Structure Etudiant
        Dim nom As String
        Dim note As Double

    End Structure
    Public listeEtudiants As New List(Of Etudiant)
    Function ajouter(E As Etudiant)
        If Not existe(E.nom) Then
            listeEtudiants.Add(E)
            MessageBox.Show("ajout avec succes" & listeEtudiants.Count())
        Else
            MessageBox.Show("l'Etudiant existe deja! ")
        End If
    End Function
    Function existe()
        Dim test As Boolean = False
        For Each et As etudiants In listeEtudiants
            If et.nom = Char Then
                test = True
            End If
        Next
        Return test
    End Function
    End Module
