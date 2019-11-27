<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuenta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cuenta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtN_cuenta = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblSaldo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.calendarHasta = New System.Windows.Forms.MonthCalendar()
        Me.calendarDesde = New System.Windows.Forms.MonthCalendar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.listaMovimientos = New System.Windows.Forms.ListView()
        Me.nmovimiento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.importe = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.concepto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblFechas = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReintegro = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº Cuenta"
        '
        'txtN_cuenta
        '
        Me.txtN_cuenta.AutoSize = True
        Me.txtN_cuenta.Location = New System.Drawing.Point(109, 30)
        Me.txtN_cuenta.Name = "txtN_cuenta"
        Me.txtN_cuenta.Size = New System.Drawing.Size(39, 13)
        Me.txtN_cuenta.TabIndex = 1
        Me.txtN_cuenta.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label2.Location = New System.Drawing.Point(234, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Saldo"
        '
        'lblSaldo
        '
        Me.lblSaldo.AutoSize = True
        Me.lblSaldo.Location = New System.Drawing.Point(292, 30)
        Me.lblSaldo.Name = "lblSaldo"
        Me.lblSaldo.Size = New System.Drawing.Size(39, 13)
        Me.lblSaldo.TabIndex = 3
        Me.lblSaldo.Text = "Label3"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Desde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(234, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Hasta"
        '
        'calendarHasta
        '
        Me.calendarHasta.Location = New System.Drawing.Point(237, 134)
        Me.calendarHasta.MaxSelectionCount = 1
        Me.calendarHasta.Name = "calendarHasta"
        Me.calendarHasta.TabIndex = 7
        '
        'calendarDesde
        '
        Me.calendarDesde.Location = New System.Drawing.Point(36, 134)
        Me.calendarDesde.MaxSelectionCount = 1
        Me.calendarDesde.Name = "calendarDesde"
        Me.calendarDesde.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Consultar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(354, 320)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Borrar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'listaMovimientos
        '
        Me.listaMovimientos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nmovimiento, Me.importe, Me.concepto, Me.fecha})
        Me.listaMovimientos.HideSelection = False
        Me.listaMovimientos.Location = New System.Drawing.Point(36, 385)
        Me.listaMovimientos.Name = "listaMovimientos"
        Me.listaMovimientos.Size = New System.Drawing.Size(393, 184)
        Me.listaMovimientos.TabIndex = 11
        Me.listaMovimientos.UseCompatibleStateImageBehavior = False
        Me.listaMovimientos.View = System.Windows.Forms.View.Details
        '
        'nmovimiento
        '
        Me.nmovimiento.Text = "Movimiento"
        Me.nmovimiento.Width = 69
        '
        'importe
        '
        Me.importe.Text = "Importe"
        Me.importe.Width = 106
        '
        'concepto
        '
        Me.concepto.Text = "Concepto"
        Me.concepto.Width = 71
        '
        'fecha
        '
        Me.fecha.Text = "Fecha"
        Me.fecha.Width = 135
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 366)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Movimientos"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Location = New System.Drawing.Point(36, 54)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 2)
        Me.Panel1.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel2.Location = New System.Drawing.Point(36, 349)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(393, 2)
        Me.Panel2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(36, 576)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Rango Fechas"
        '
        'lblFechas
        '
        Me.lblFechas.AutoSize = True
        Me.lblFechas.Location = New System.Drawing.Point(119, 576)
        Me.lblFechas.Name = "lblFechas"
        Me.lblFechas.Size = New System.Drawing.Size(39, 13)
        Me.lblFechas.TabIndex = 16
        Me.lblFechas.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(137, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Cantidad"
        '
        'txtReintegro
        '
        Me.txtReintegro.Location = New System.Drawing.Point(194, 64)
        Me.txtReintegro.Name = "txtReintegro"
        Me.txtReintegro.Size = New System.Drawing.Size(154, 20)
        Me.txtReintegro.TabIndex = 18
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(354, 62)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Reintegro"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Location = New System.Drawing.Point(36, 91)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(393, 2)
        Me.Panel3.TabIndex = 14
        '
        'Cuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(464, 604)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtReintegro)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblFechas)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.listaMovimientos)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.calendarDesde)
        Me.Controls.Add(Me.calendarHasta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblSaldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtN_cuenta)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Cuenta"
        Me.Text = "Cuenta"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtN_cuenta As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblSaldo As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents calendarHasta As MonthCalendar
    Friend WithEvents calendarDesde As MonthCalendar
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents listaMovimientos As ListView
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents lblFechas As Label
    Friend WithEvents nmovimiento As ColumnHeader
    Friend WithEvents importe As ColumnHeader
    Friend WithEvents concepto As ColumnHeader
    Friend WithEvents fecha As ColumnHeader
    Friend WithEvents Label7 As Label
    Friend WithEvents txtReintegro As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel3 As Panel
End Class
