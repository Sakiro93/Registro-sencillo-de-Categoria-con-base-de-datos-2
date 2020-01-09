Public Class EntCategoria
    Private CatCodigo As Integer
    Private CatDescripcion As String
    Public Property Codigo() As Integer
        Get
            Return CatCodigo
        End Get
        Set(ByVal value As Integer)
            CatCodigo = value
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return CatDescripcion
        End Get
        Set(ByVal value As String)
            CatDescripcion = value
        End Set
    End Property
    Sub New()
        Me.CatCodigo = 0
        Me.CatDescripcion = ""
    End Sub
    Sub New(ByVal CatCodigo As Integer, ByVal CatDescripcion As String)
        Me.CatCodigo = CatCodigo
        Me.CatDescripcion = CatDescripcion
    End Sub
End Class
