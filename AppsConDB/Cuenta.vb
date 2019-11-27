Imports System.Data.SqlClient

Public Class Cuenta
    Public numer_cuenta As String
    Public Sub load_data(num_cuenta As String)
        txtN_cuenta.Text = num_cuenta
        numer_cuenta = num_cuenta
        Me.Text = "Cuenta - " + num_cuenta
        Dim query_cuenta As String = "SELECT * FROM [vb_banco].[Cuentas] WHERE ncuenta = '" + num_cuenta + "'"

        Dim reader As SqlDataReader = selectFromBD(query_cuenta)
        reader.Read()
        lblSaldo.Text = reader.GetValue(4).ToString() + " $"

        reader.Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inicio As String = calendarDesde.SelectionRange.Start.ToShortDateString()
        Dim fin As String = calendarHasta.SelectionRange.Start.ToShortDateString()
        lblFechas.Text = inicio + " - " + fin
        Dim n_cuenta As String = txtN_cuenta.Text.ToString()
        Dim query As String = "SELECT * FROM [vb_banco].[Movimientos] WHERE ncuenta = '" + n_cuenta + "' and fecha between '" + inicio + "' and '" + fin + "' ORDER BY fecha"

        Dim reader As SqlDataReader = selectFromBD(query)
        listaMovimientos.Items.Clear()
        While reader.Read
            Dim item As ListViewItem = New ListViewItem(reader.GetValue(0).ToString())
            item.SubItems.Add(reader.GetValue(1).ToString())
            item.SubItems.Add(reader.GetValue(2).ToString())
            item.SubItems.Add(reader.GetValue(3).ToString())
            listaMovimientos.Items.Add(item)
        End While
        reader.Close()

    End Sub

    Private Sub Cuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFechas.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'Sacamos la cantidad
        Dim reintegro As Double = CDbl(txtReintegro.Text.ToString())
        txtReintegro.Clear()
        'Obtenemos el id para el movimiento
        Dim query_for_id As String = "SELECT MAX(Nmovimiento) FROM [vb_banco].[Movimientos]"
        'Insertamos el movimiento
        Dim query_reintegro As String = "INSERT INTO [vb_banco].[Movimientos] VALUES(@id, @importe, @concepto, @fecha, @ncuenta)"
        'Actualizamos el daldo
        Dim query_update_saldo As String = "UPDATE [vb_banco].[Cuentas] SET saldo = saldo + @saldo WHERE Ncuenta = @num_cuenta"

        Dim cmd As SqlCommand = New SqlCommand(query_for_id, DBneed.miConexion)

        Try
            Dim id_mov As Integer = CInt(cmd.ExecuteScalar()) + 1

            'Asignamos los parametros para la insert
            Dim inserto As New SqlCommand(query_reintegro, DBneed.miConexion)
            inserto.Parameters.AddWithValue("@id", id_mov)
            inserto.Parameters.AddWithValue("@importe", reintegro)
            inserto.Parameters.AddWithValue("@concepto", "Reintegro Cajero")
            inserto.Parameters.AddWithValue("@fecha", Date.Today())
            inserto.Parameters.AddWithValue("@ncuenta", numer_cuenta)

            inserto.ExecuteNonQuery()

            Dim updateo As New SqlCommand(query_update_saldo, DBneed.miConexion)
            updateo.Parameters.AddWithValue("@saldo", reintegro)
            updateo.Parameters.AddWithValue("@num_cuenta", numer_cuenta)

            updateo.ExecuteNonQuery()

            load_data(numer_cuenta)
        Catch ex As Exception
            MessageBox.Show(ex.ToString(), "Algo ha ido mal")
        End Try

    End Sub
End Class