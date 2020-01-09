Imports Entidad
Public Interface IntCategoria
    Sub ingresar(ByVal Categoria As EntCategoria)
    Sub modificar(ByVal Categoria As EntCategoria)
    Sub eliminar(ByVal Categoria As EntCategoria)
    Function buscar(ByVal filtro As String) As List(Of EntCategoria)
    Function buscarCodigo(ByVal cod As Integer) As EntCategoria
    Function MaxCodigo() As String
End Interface
