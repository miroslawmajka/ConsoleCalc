Public Class Calculator

    Public Function Add(ByVal elements As List(Of Integer)) As Integer
        Return elements.Sum()
    End Function

    Public Function Subtract(ByVal el1 As Integer, ByVal el2 As Integer) As Integer
        Return el1 - el2
    End Function

End Class