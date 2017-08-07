Public Class Torneo
    Private _nombre As String
    Sub New()
        _nombre = ""
    End Sub
    Sub New(nombre As String)
        Me._nombre = nombre
    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If Len(value) <= 50 And value <> "" Then
                _nombre = value
            End If
        End Set
    End Property

End Class
