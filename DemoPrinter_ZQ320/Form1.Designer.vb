<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class Form1
    Inherits System.Windows.Forms.Form

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer
    private mainMenu1 As System.Windows.Forms.MainMenu

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar con el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.mainMenu1 = New System.Windows.Forms.MainMenu
        Me.Test = New System.Windows.Forms.Button
        Me.Btn_Conectar = New System.Windows.Forms.Button
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.COM5 = New System.IO.Ports.SerialPort(Me.components)
        Me.SuspendLayout()
        '
        'Test
        '
        Me.Test.Location = New System.Drawing.Point(88, 69)
        Me.Test.Name = "Test"
        Me.Test.Size = New System.Drawing.Size(72, 20)
        Me.Test.TabIndex = 0
        Me.Test.Text = "Test"
        '
        'Btn_Conectar
        '
        Me.Btn_Conectar.Location = New System.Drawing.Point(3, 15)
        Me.Btn_Conectar.Name = "Btn_Conectar"
        Me.Btn_Conectar.Size = New System.Drawing.Size(72, 20)
        Me.Btn_Conectar.TabIndex = 1
        Me.Btn_Conectar.Text = "Conectar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(129, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 21)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "HOLA"
        '
        'COM5
        '
        Me.COM5.PortName = "COM5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(240, 268)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Btn_Conectar)
        Me.Controls.Add(Me.Test)
        Me.Menu = Me.mainMenu1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Test As System.Windows.Forms.Button
    Friend WithEvents Btn_Conectar As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents COM5 As System.IO.Ports.SerialPort

End Class
