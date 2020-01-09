Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class SqlEjecucion
    Private OConexion As Conexion

    Sub New()
        OConexion = New Conexion()
    End Sub

    Public Function Consulta(ByVal Cmd As SqlCommand) As DataTable
        Dim Tabla As DataTable = Nothing
        Try
            OConexion.Conectar()
            Cmd.Connection = OConexion.Prop_Conexion
            Cmd.CommandTimeout = 0 'SIN TIEMPO LIMITE DE ESPERA, (LOS ROLES DEMORAN MUCHO)
            Dim oAdap As New SqlDataAdapter(Cmd)
            Tabla = New DataTable()
            oAdap.Fill(Tabla) 'SE RECIBEN LOS DATOS EN UNA TABLA
        Catch Errors As Exception
            MessageBox.Show(Errors.Message)
        End Try
        OConexion.Desconectar()
        Return Tabla
    End Function

    Public Sub Ejecutar(ByVal Cmd As SqlCommand)
        Try
            OConexion.Conectar()
            Cmd.Connection = OConexion.Prop_Conexion
            Cmd.CommandTimeout = 0 'SI TIEMPO LIMITE DE ESPERA, (LOS ROLES DEMORAN MUCHO)
            Cmd.ExecuteNonQuery()
            OConexion.Desconectar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    Public Function MaximoCodigo(ByVal Cmd As SqlCommand) As String
        Dim sec As String
        Try

            OConexion.Conectar()
            Cmd.Connection = OConexion.Prop_Conexion
            Cmd.CommandTimeout = 0
            sec = Cmd.ExecuteScalar()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            sec = "0"
        End Try
        OConexion.Desconectar()
        Return sec
    End Function

End Class
