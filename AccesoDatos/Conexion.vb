Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Configuration
Public Class Conexion
    Private StrConn As String
    Private Servidor As String
    Private Base As String
    Private Usuario As String
    Private Password As String
    Private Cnn As SqlConnection

    Public Property Prop_Conexion() As SqlConnection
        Get
            Return Cnn
        End Get
        Set(ByVal value As SqlConnection)

            Cnn = value
        End Set
    End Property

    Public Sub New()
        Try
            Leer_AppConfig()
            StrConn = "SERVER ='" & Servidor & "'; DATABASE='" & Base & "'; INTEGRATED SECURITY = SSPI; CONNECT TIMEOUT=5 "

        Catch Errors As Exception
            MessageBox.Show("Error al leer el archivo de configuración para conectar con la base de datos. " & Errors.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '-----Establece la conexion con SQLSERVER
    Public Sub Conectar()
        '-----Construyendo una nueva conexion a SQLSERVER
        Cnn = New SqlConnection(StrConn)
        Cnn.Open()

    End Sub

    Public Sub Desconectar()
        Try
            If Cnn IsNot Nothing Or Cnn.State <> ConnectionState.Closed Then
                Cnn.Close()
            End If
        Catch Problema As Exception
            MessageBox.Show("No se pudo desconectar de la base de datos del sistema. " & Problema.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Leer_AppConfig()
        Servidor = ConfigurationManager.AppSettings("Server")
        Base = ConfigurationManager.AppSettings("DataBase")
        Usuario = ConfigurationManager.AppSettings("User")
        Password = ConfigurationManager.AppSettings("Password")

    End Sub

End Class
