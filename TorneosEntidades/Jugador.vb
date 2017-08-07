Public Class Jugador
    Private _numero As UShort
    Sub New()
        _numero = 0
    End Sub
    Public Property Numero As UShort
        Get
            Return _numero
        End Get
        Set(value As UShort)
            If value > 0 And value < 100 Then
                _numero = value
            End If
        End Set
    End Property
End Class
