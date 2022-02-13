<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ckcompra = New System.Windows.Forms.CheckBox()
        Me.ckventa = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbeuro = New System.Windows.Forms.RadioButton()
        Me.rbcolon = New System.Windows.Forms.RadioButton()
        Me.rbpeso = New System.Windows.Forms.RadioButton()
        Me.rbdolar = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ckcompra)
        Me.GroupBox1.Controls.Add(Me.ckventa)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(177, 206)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compra o Venta"
        '
        'ckcompra
        '
        Me.ckcompra.AutoSize = True
        Me.ckcompra.Location = New System.Drawing.Point(18, 59)
        Me.ckcompra.Name = "ckcompra"
        Me.ckcompra.Size = New System.Drawing.Size(84, 24)
        Me.ckcompra.TabIndex = 6
        Me.ckcompra.Text = "Compra"
        Me.ckcompra.UseVisualStyleBackColor = True
        '
        'ckventa
        '
        Me.ckventa.AutoSize = True
        Me.ckventa.Location = New System.Drawing.Point(18, 107)
        Me.ckventa.Name = "ckventa"
        Me.ckventa.Size = New System.Drawing.Size(68, 24)
        Me.ckventa.TabIndex = 7
        Me.ckventa.Text = "Venta"
        Me.ckventa.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(394, 59)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(380, 180)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(217, 120)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(167, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Resultado con comision"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Cantidad de cambio"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(217, 30)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(125, 27)
        Me.TextBox4.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Resultado sin comision"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 20)
        Me.Label1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(217, 74)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 27)
        Me.TextBox2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbeuro)
        Me.GroupBox3.Controls.Add(Me.rbcolon)
        Me.GroupBox3.Controls.Add(Me.rbpeso)
        Me.GroupBox3.Controls.Add(Me.rbdolar)
        Me.GroupBox3.Location = New System.Drawing.Point(58, 269)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(250, 220)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tipo de divisas"
        Me.GroupBox3.Visible = False
        '
        'rbeuro
        '
        Me.rbeuro.AutoSize = True
        Me.rbeuro.Location = New System.Drawing.Point(19, 179)
        Me.rbeuro.Name = "rbeuro"
        Me.rbeuro.Size = New System.Drawing.Size(60, 24)
        Me.rbeuro.TabIndex = 3
        Me.rbeuro.Text = "Euro"
        Me.rbeuro.UseVisualStyleBackColor = True
        '
        'rbcolon
        '
        Me.rbcolon.AutoSize = True
        Me.rbcolon.Location = New System.Drawing.Point(19, 135)
        Me.rbcolon.Name = "rbcolon"
        Me.rbcolon.Size = New System.Drawing.Size(69, 24)
        Me.rbcolon.TabIndex = 2
        Me.rbcolon.Text = "Colon"
        Me.rbcolon.UseVisualStyleBackColor = True
        '
        'rbpeso
        '
        Me.rbpeso.AutoSize = True
        Me.rbpeso.Location = New System.Drawing.Point(19, 94)
        Me.rbpeso.Name = "rbpeso"
        Me.rbpeso.Size = New System.Drawing.Size(128, 24)
        Me.rbpeso.TabIndex = 1
        Me.rbpeso.Text = "Peso mexicano"
        Me.rbpeso.UseVisualStyleBackColor = True
        '
        'rbdolar
        '
        Me.rbdolar.AutoSize = True
        Me.rbdolar.Location = New System.Drawing.Point(19, 51)
        Me.rbdolar.Name = "rbdolar"
        Me.rbdolar.Size = New System.Drawing.Size(67, 24)
        Me.rbdolar.TabIndex = 0
        Me.rbdolar.Text = "Dolar"
        Me.rbdolar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(895, 106)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(895, 170)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(895, 231)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 564)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents rbeuro As RadioButton
    Friend WithEvents rbcolon As RadioButton
    Friend WithEvents rbpeso As RadioButton
    Friend WithEvents rbdolar As RadioButton
    Friend WithEvents ckcompra As CheckBox
    Friend WithEvents ckventa As CheckBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
End Class
