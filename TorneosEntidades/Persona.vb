Public Class Persona
    Private _fechaNacimiento As Date
    Private _nombre As String
    Sub New()
        _nombre = ""
        _fechaNacimiento = Nothing
    End Sub
    Sub New(nombre As String, fechaNacimiento As Date)
        Me._fechaNacimiento = fechaNacimiento
        Me._nombre = nombre
    End Sub
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If Len(value) <= 30 And value <> "" Then
                _nombre = value
            End If
        End Set
    End Property
    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            If DateDiff(DateInterval.Year, value, Date.Today) >= 16 Then
                _fechaNacimiento = value
            End If
        End Set
    End Property
    Public Function Edad() As UShort
        Return CalcularEdad()
    End Function
    Private Function CalcularEdad() As UShort
        Return DateDiff(DateInterval.Year, FechaNacimiento, Date.Today)
    End Function
End Class
