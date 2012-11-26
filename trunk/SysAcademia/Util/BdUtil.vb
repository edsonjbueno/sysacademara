Public Class BdUtil

    Public Shared Function GetNull(ByVal Obj As Object) As Object
        If Obj Is Nothing Then
            Return DBNull.Value
        End If
        Return Obj
    End Function

    Public Shared Function SetNull(ByVal Obj As Object) As Object

        Try
            Dim ObjDBNull As DBNull = Obj
            Return Nothing
        Catch ex As Exception
            Return Obj
        End Try

    End Function


End Class
