Public Class Partido
    Private _fecha As Date
    Private _golesLocal As UShort
    Private _golesVisitante As UShort
    Private _minutosGolesLocales As List(Of UShort)
    Private _minutosGolesVisitante As List(Of UShort)
    Private _finalizado As Boolean
    Sub New()
        _fecha = Nothing
        _golesLocal = 0
        _golesVisitante = 0
        _minutosGolesLocales = New List(Of UShort)
        _minutosGolesVisitante = New List(Of UShort)
        _finalizado = False
    End Sub
    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            If Not _finalizado Then
                _fecha = value
            End If
        End Set
    End Property
    Public ReadOnly Property GolesLocal As UShort
        Get
            Return _golesLocal
        End Get
    End Property
    Public ReadOnly Property GolesVisitante As UShort
        Get
            Return _golesVisitante
        End Get
    End Property
    Public ReadOnly Property MinutosGolesLocales As List(Of UShort)
        Get
            Return _minutosGolesLocales
        End Get
    End Property
    Public ReadOnly Property MinutosGolesVisitantes As List(Of UShort)
        Get
            Return _minutosGolesVisitante
        End Get
    End Property
    Public Sub nuevoGolLocal(Minutos As UShort)
        If Not _finalizado Then
            MinutosGolesLocales.Add(Minutos)
            _golesLocal += 1
        End If
    End Sub
    Public Sub nuevoGolVisitante(Minutos As UShort)
        If Not _finalizado Then
            MinutosGolesVisitantes.Add(Minutos)
            _golesVisitante += 1
        End If
    End Sub
    Public Sub Finalizado()
        _finalizado = True
    End Sub

End Class
