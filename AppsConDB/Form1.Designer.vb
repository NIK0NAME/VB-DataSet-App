<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pnLogin = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.listaCuentas = New System.Windows.Forms.ListView()
        Me.ncuenta = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.saldo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnLogin.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnLogin
        '
        Me.pnLogin.BackColor = System.Drawing.Color.Transparent
        Me.pnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.pnLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnLogin.Controls.Add(Me.Label4)
        Me.pnLogin.Controls.Add(Me.btnLogin)
        Me.pnLogin.Controls.Add(Me.txtPass)
        Me.pnLogin.Controls.Add(Me.txtUsername)
        Me.pnLogin.Controls.Add(Me.Label3)
        Me.pnLogin.Controls.Add(Me.Label2)
        Me.pnLogin.Controls.Add(Me.Label1)
        Me.pnLogin.Location = New System.Drawing.Point(13, 13)
        Me.pnLogin.Name = "pnLogin"
        Me.pnLogin.Size = New System.Drawing.Size(397, 224)
        Me.pnLogin.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(161, 170)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Continuar"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(132, 128)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(136, 20)
        Me.txtPass.TabIndex = 4
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(132, 80)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(136, 20)
        Me.txtUsername.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(129, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(129, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INICIAR SESION"
        '
        'listaCuentas
        '
        Me.listaCuentas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ncuenta, Me.tipo, Me.saldo})
        Me.listaCuentas.HideSelection = False
        Me.listaCuentas.Location = New System.Drawing.Point(13, 281)
        Me.listaCuentas.MultiSelect = False
        Me.listaCuentas.Name = "listaCuentas"
        Me.listaCuentas.Size = New System.Drawing.Size(397, 275)
        Me.listaCuentas.TabIndex = 2
        Me.listaCuentas.UseCompatibleStateImageBehavior = False
        Me.listaCuentas.View = System.Windows.Forms.View.Details
        '
        'ncuenta
        '
        Me.ncuenta.Text = "Numero Cuenta"
        Me.ncuenta.Width = 116
        '
        'tipo
        '
        Me.tipo.Text = "Tipo"
        Me.tipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tipo.Width = 76
        '
        'saldo
        '
        Me.saldo.Text = "Saldo"
        Me.saldo.Width = 135
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(150, 255)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "CUENTAS ASOCIADAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Nirmala UI", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(209, 12)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Introducir datos para continuar si ya tiene un cuenta."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(422, 568)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.listaCuentas)
        Me.Controls.Add(Me.pnLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(100, 150)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Banco"
        Me.pnLogin.ResumeLayout(False)
        Me.pnLogin.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnLogin As Panel
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents listaCuentas As ListView
    Friend WithEvents ncuenta As ColumnHeader
    Friend WithEvents tipo As ColumnHeader
    Friend WithEvents saldo As ColumnHeader
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
End Class
