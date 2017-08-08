﻿Public Class Equipo
    Private _nombre As String
    Sub New()
        _nombre = ""
    End Sub
    Sub New(nombre As String)
        Me.New()
        Me.Nombre = nombre
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

End Class
