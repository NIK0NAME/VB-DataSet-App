Imports System.Data.SqlClient

Module DBneed
    'El string de conexion
    Dim conn_string As String = "Data Source=SEGUNDO150;Initial Catalog=DAM_nikolayzabaleta_DEV; Integrated Security=True"

    'Conexion con la base de datos
    Public miConexion As SqlConnection

    Public Function abrirConexion() As Boolean
        miConexion = New SqlConnection(conn_string)
        Try
            miConexion.Open()
        Catch ex As Exception
            miConexion = Nothing
            Return False
        End Try

        Return True
    End Function

    Public Function selectFromBD(query As String) As SqlDataReader
        'Creamos el comando sql
        Dim comando As New SqlCommand(query, miConexion)
        comando.CommandType = CommandType.Text

        Try
            Dim reader As SqlDataReader = comando.ExecuteReader()

            Return reader
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
            Return Nothing
        End Try
    End Function
End Module
