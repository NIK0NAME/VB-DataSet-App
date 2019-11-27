Imports System.Data.SqlClient

Public Class Form1

    Dim view_cuenta As Cuenta
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtUsername.Text.ToString()
        Dim pass As String = txtPass.Text.ToString()

        Dim query As String = "SELECT * FROM [vb_banco].[Usuarios] WHERE username = '" + user + "' and pass = '" + pass + "'"
        Dim query_cuentas = "SELECT ncuenta, titular, saldo FROM [vb_banco].[Cuentas] WHERE titular = '" + user + "'"
        Dim reader As SqlDataReader = selectFromBD(query)
        listaCuentas.Items.Clear()
        If IsNothing(reader) <> True Then
            If reader.HasRows Then
                MessageBox.Show("Usiario si ke etaaa")
                reader.Close()
                Dim reader_cuentas As SqlDataReader = selectFromBD(query_cuentas)
                While reader_cuentas.Read()
                    Dim it As New ListViewItem(reader_cuentas(0).ToString())
                    it.SubItems.Add(reader_cuentas(1).ToString())
                    it.SubItems.Add(reader_cuentas(2).ToString())
                    listaCuentas.Items.Add(it)
                End While
                reader_cuentas.Close()
            Else
                MessageBox.Show("El jusuario no esta")
                reader.Close()
            End If
            txtUsername.Clear()
            txtPass.Clear()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If abrirConexion() Then
            MessageBox.Show("Conexion establecida")
        Else
            MessageBox.Show("No se puede establecer conexion")
        End If
    End Sub

    Private Sub ListaCuentas_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles listaCuentas.MouseDoubleClick
        Dim item As ListViewItem = listaCuentas.Items.Item(listaCuentas.SelectedIndices.Item(0))
        Dim num_cuenta As String = item.Text.ToString()
        If view_cuenta Is Nothing Then
        Else
            view_cuenta.Close()
            view_cuenta = Nothing
        End If
        view_cuenta = New Cuenta()
        view_cuenta.StartPosition = FormStartPosition.Manual
        view_cuenta.FormBorderStyle = FormBorderStyle.FixedSingle
        view_cuenta.Location = New Point(600, 150)
        view_cuenta.load_data(num_cuenta)
        view_cuenta.Show()
    End Sub
End Class
