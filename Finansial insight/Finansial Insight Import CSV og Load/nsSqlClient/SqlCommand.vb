Namespace nsSqlClient
    Friend Class SqlCommand
        Friend CommandText As String
        Private strSQL As String
        Private objConn As SqlConnection

        Public Sub New(strSQL As String, objConn As SqlConnection)
            Me.strSQL = strSQL
            Me.objConn = objConn
        End Sub

        Friend Sub ExecuteNonQuery()
            Throw New NotImplementedException()
        End Sub
    End Class
End Namespace
