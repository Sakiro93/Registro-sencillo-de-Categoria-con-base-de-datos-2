Imports Entidad
Imports AccesoDatos
Imports Interfaz
Public Class LogCategoria
    Implements IntCategoria
    Dim LogAccCategoria As New AccCategoria()
    Public Function buscar(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntCategoria) Implements Interfaz.IntCategoria.buscar
        Return LogAccCategoria.buscar(filtro)
    End Function

    Public Function buscarCodigo(ByVal cod As Integer) As Entidad.EntCategoria Implements Interfaz.IntCategoria.buscarCodigo
        Return LogAccCategoria.buscarCodigo(cod)
    End Function

    Public Sub eliminar(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntCategoria.eliminar
        LogAccCategoria.eliminar(Categoria)
    End Sub

    Public Sub ingresar(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntCategoria.ingresar
        LogAccCategoria.ingresar(Categoria)
    End Sub

    Public Function MaxCodigo() As String Implements Interfaz.IntCategoria.MaxCodigo
        Return Val(LogAccCategoria.MaxCodigo())
    End Function

    Public Sub modificar(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntCategoria.modificar
        LogAccCategoria.modificar(Categoria)
    End Sub
End Class
