Public Class BbUtil

    Public Shared Function GetNull(ByVal Obj As Object) As Object
        If Obj Is Nothing Then
            Return DBNull.Value
        End If
        Return Obj
    End Function


End Class
