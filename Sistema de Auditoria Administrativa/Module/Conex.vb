Imports System.IO
Imports System.Net
Imports MySql.Data.MySqlClient

Module Conex
    Private WithEvents transfer As DownloadFilesSftp

#Region "SFTP"

    Public Sub Descarga_Archivos(ByVal servidor As String, ByVal puerto As String, ByVal usuario As String, ByVal contraseña As String, ByVal ruta_ori As String, ByVal ruta_des As String)
        transfer = New DownloadFilesSftp(servidor, Integer.Parse(puerto), usuario, contraseña)
        transfer.Descarga_Archivos(ruta_ori, ruta_des)
    End Sub

    Public Function Verifica_Conex(ByVal servidor As String, ByVal puerto As String, ByVal usuario As String, ByVal contraseña As String, ByVal ruta_ori As String, ByVal ruta_des As String) As String
        transfer = New DownloadFilesSftp(servidor, Integer.Parse(puerto), usuario, contraseña)
        transfer.Verifica_Conex(ruta_ori, ruta_des)
        Return transfer.Verifica_Conex(ruta_ori, ruta_des).ToString()
    End Function

#End Region

#Region "MySQL"

    Public Function Conex_MySQL(ByVal cServidor As String, ByVal cUsu As String, ByVal cClave As String, ByVal cPort As String, ByVal cBD As String) As Boolean

        Try
            Dim connStr As String = "Database=" & cBD & ";" & _
                    "Data Source=" & cServidor & "; Port=" & cPort & ";" & _
                    "User Id=" & cUsu & ";Password=" & cClave
            Dim connection As New MySqlConnection(connStr)
            connection.Open()
            connection.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

#End Region

#Region "SQL SERVER"

    Public Function Conex_SQLServer(ByVal cServidor As String, ByVal cUsu As String, ByVal cClave As String, ByVal cBD As String) As Boolean
        Try
            Dim ConexBD As New ADODB.Connection
            ConexBD = New ADODB.Connection
            ConexBD.ConnectionString = "driver={SQL Server Native Client 11.0};server=" & cServidor & ";uid=" & cUsu & ";pwd=" & cClave & ";database=" & cBD
            ConexBD.ConnectionTimeout = 8
            ConexBD.CommandTimeout = 0
            ConexBD.Open()

            Return True
        Catch ex As Exception

            Return False
        End Try

    End Function

#End Region

    Public Sub ftp(ByVal servidor As String, ByVal usuario As String, ByVal contraseña As String, ByVal ruta_ori As String, ByVal ruta_des As String)

        Try
            Dim request As System.Net.FtpWebRequest = DirectCast(System.Net.WebRequest.Create("ftp://" + servidor + ruta_ori), System.Net.FtpWebRequest)
            MessageBox.Show("ftp://" + servidor + ruta_ori)
            Dim response As FtpWebResponse = request.GetResponse()
            Dim responseStream As Stream = response.GetResponseStream()
            Dim files() As String
            Dim reader As StreamReader = New StreamReader(responseStream)
            Dim N As Integer = 0

            request.Credentials = New System.Net.NetworkCredential(usuario, contraseña)
            request.Method = System.Net.WebRequestMethods.Ftp.ListDirectoryDetails
            request.UsePassive = True
            request.UseBinary = True
            request.KeepAlive = True

            Do While reader.Peek() >= 0
                ReDim files(N)
                files.SetValue(reader.ReadLine(), N)
                N = N + 1
                MessageBox.Show(reader.ReadLine())
            Loop

            reader.Close()
            response.Close()
            responseStream.Close()

        Catch ex As Exception
            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "Error a Conectar Servidor FTP", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Module
