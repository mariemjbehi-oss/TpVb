Imports System.Net.Security

Module Reservations
    Dim nbpalcesdisponible As Integer = 50
    Public Structure Reservation
        Dim ligne As String
        Dim villedepart As String
        Dim villearrive As String
        Dim h_debut As String
        Dim h_fin As String
        Dim places As Integer
        Dim options As List(Of String)
        Dim type As String
        Public Sub initReservation()
            options = New List(Of String)
        End Sub
    End Structure
    Public listeReservation As New List(Of Reservation)
    Public Function ajouterReservation(r As Reservation)
        If r.places <= nbpalcesdisponible Then
            listeReservation.Add(r)
            nbpalcesdisponible = nbpalcesdisponible - r.places


        End If
    End Function

End Module
