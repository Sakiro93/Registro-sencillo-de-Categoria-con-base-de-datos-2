Imports System.Data.SqlClient
Imports Interfaz
Imports Entidad
Public Class AccCategoria
    Implements IntCategoria
   
    Public Function buscar(ByVal filtro As String) As System.Collections.Generic.List(Of Entidad.EntCategoria) Implements Interfaz.IntCategoria.buscar    
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure 'Llama a un procedimiento almacenado
        cmd.CommandText = "Ca_Categorias" 'Ingresa el nombre de la Tabla
        With cmd.Parameters 'Añade Parametros
            .Add("@Opcion", SqlDbType.VarChar).Value = "DES"
            .Add("@CatCodigo", SqlDbType.TinyInt).Value = 0
            .Add("@CatDescripcion", SqlDbType.VarChar).Value = filtro
        End With
        Dim LstCategoria As New List(Of EntCategoria)
        Dim Categoria As EntCategoria
        Dim Tabla As DataTable
        Tabla = sql.Consulta(cmd)
        For fila = 0 To Tabla.Rows.Count - 1
            Categoria = New EntCategoria(Tabla.Rows(fila).Item(0), Tabla.Rows(fila).Item(1)) 'Item Columna, Item(0)=Codigo, Item(1)=Descripcion
            LstCategoria.Add(Categoria)
        Next
        Return LstCategoria
    End Function

    Public Function buscarCodigo(ByVal cod As Integer) As Entidad.EntCategoria Implements Interfaz.IntCategoria.buscarCodigo
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure 'Llama a un procedimiento almacenado
        cmd.CommandText = "Ca_Categorias" 'Ingresa el nombre de la Tabla
        With cmd.Parameters 'Añade Parametros
            .Add("@Opcion", SqlDbType.VarChar).Value = "COD"
            .Add("@CatCodigo", SqlDbType.TinyInt).Value = cod
            .Add("@CatDescripcion", SqlDbType.VarChar).Value = ""
        End With
        Dim Tabla As DataTable
        Dim Categoria As EntCategoria
        Tabla = sql.Consulta(cmd)
        Categoria = New EntCategoria(Tabla.Rows(0).Item(0), Tabla.Rows(0).Item(1))
        Return Categoria
    End Function

    Public Sub eliminar(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntCategoria.eliminar
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure 'Llama a un procedimiento almacenado
        cmd.CommandText = "Ca_Categorias" 'Ingresa el nombre de la Tabla
        With cmd.Parameters 'Añade Parametros
            .Add("@Opcion", SqlDbType.VarChar).Value = "ELI"
            .Add("@CatCodigo", SqlDbType.TinyInt).Value = Categoria.Codigo
            .Add("@CatDescripcion", SqlDbType.VarChar).Value = ""

        End With
        sql.Ejecutar(cmd)
    End Sub

    Public Sub ingresar(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntCategoria.ingresar
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure 'Llama a un procedimiento almacenado
        cmd.CommandText = "Ca_Categorias" 'Ingresa el nombre de la Tabla
        With cmd.Parameters 'Añade Parametros
            .Add("@Opcion", SqlDbType.VarChar).Value = "INS"
            .Add("@CatCodigo", SqlDbType.TinyInt).Value = Categoria.Codigo
            .Add("@CatDescripcion", SqlDbType.VarChar).Value = Categoria.Descripcion

        End With
        sql.Ejecutar(cmd)
    End Sub

    Public Function MaxCodigo() As String Implements Interfaz.IntCategoria.MaxCodigo
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure 'Llama a un procedimiento almacenado
        cmd.CommandText = "Ca_Categorias" 'Ingresa el nombre de la Tabla
        With cmd.Parameters 'Añade Parametros
            .Add("@Opcion", SqlDbType.VarChar).Value = "SIG"
            .Add("@CatCodigo", SqlDbType.TinyInt).Value = 0
            .Add("@CatDescripcion", SqlDbType.VarChar).Value = ""
        End With
        Dim codigo As String = sql.MaximoCodigo(cmd)
        Return codigo
    End Function

    Public Sub modificar(ByVal Categoria As Entidad.EntCategoria) Implements Interfaz.IntCategoria.modificar
        Dim sql As New SqlEjecucion()
        Dim cmd As New SqlCommand()
        cmd.CommandType = CommandType.StoredProcedure 'Llama a un procedimiento almacenado
        cmd.CommandText = "Ca_Categorias" 'Ingresa el nombre de la Tabla
        With cmd.Parameters 'Añade Parametros
            .Add("@Opcion", SqlDbType.VarChar).Value = "MOD"
            .Add("@CatCodigo", SqlDbType.TinyInt).Value = Categoria.Codigo
            .Add("@CatDescripcion", SqlDbType.VarChar).Value = Categoria.Descripcion
        End With
        sql.Ejecutar(cmd)
    End Sub
End Class
