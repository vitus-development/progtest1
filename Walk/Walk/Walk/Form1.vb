Imports System.Data.SqlClient


Public Class IntastningAfWalkData 'step 1 sql connection definering
    Dim connection As New SqlConnection("server= VBJXPS2017\VITUS; Initial catalog= Walk; Integrated security = True")
    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click
        Dim insertQuery As String = "Insert INTO WalkData(ID,Dato,Fornavn,Efternavn,Skridt,Km,Minutter,Kalorier)VALUES(" & IdVærdi.Text() & "," & DatoVærdi.Text & ",'" & FornavnTekst.Text & "','" & EfternavnTekst.Text & "'," & AntalSkridtVærdi.Text & "," & AntalKmVærdi.Text & "," & AntalMinutterVærdi.Text & "," & AntalKalorierVærdi.Text & ")"
        ExecuteQuery(insertQuery)

    End Sub

    Public Sub ExecuteQuery(Query As String) 'step 2 Her laves åbne og Lukke forbindelse i forbindelse indlæsning af 
        'den enkelte række på databasen. Programmet kan ikke indlæse flere rækker af gangen 
        Dim command As New SqlCommand(Query, connection)
        connection.Open()

        command.ExecuteNonQuery()

        connection.Close()

    End Sub


    End Sub
End Class