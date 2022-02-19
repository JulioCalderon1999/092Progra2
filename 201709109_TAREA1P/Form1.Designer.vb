<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form1
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
        Me.rbL = New System.Windows.Forms.RadioButton()
        Me.rbM = New System.Windows.Forms.RadioButton()
        Me.rbS = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rblona = New System.Windows.Forms.RadioButton()
        Me.rbseda = New System.Windows.Forms.RadioButton()
        Me.rbalgodon = New System.Windows.Forms.RadioButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Resultados = New System.Windows.Forms.GroupBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Resultados.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbL)
        Me.GroupBox1.Controls.Add(Me.rbM)
        Me.GroupBox1.Controls.Add(Me.rbS)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(53, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 201)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tallas"
        '
        'rbL
        '
        Me.rbL.AutoSize = True
        Me.rbL.Location = New System.Drawing.Point(11, 158)
        Me.rbL.Name = "rbL"
        Me.rbL.Size = New System.Drawing.Size(67, 24)
        Me.rbL.TabIndex = 2
        Me.rbL.TabStop = True
        Me.rbL.Text = "Large"
        Me.rbL.UseVisualStyleBackColor = True
        '
        'rbM
        '
        Me.rbM.AutoSize = True
        Me.rbM.Location = New System.Drawing.Point(11, 99)
        Me.rbM.Name = "rbM"
        Me.rbM.Size = New System.Drawing.Size(85, 24)
        Me.rbM.TabIndex = 1
        Me.rbM.TabStop = True
        Me.rbM.Text = "Medium"
        Me.rbM.UseVisualStyleBackColor = True
        '
        'rbS
        '
        Me.rbS.AutoSize = True
        Me.rbS.Location = New System.Drawing.Point(11, 40)
        Me.rbS.Name = "rbS"
        Me.rbS.Size = New System.Drawing.Size(67, 24)
        Me.rbS.TabIndex = 0
        Me.rbS.TabStop = True
        Me.rbS.Text = "Small"
        Me.rbS.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rblona)
        Me.GroupBox2.Controls.Add(Me.rbseda)
        Me.GroupBox2.Controls.Add(Me.rbalgodon)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(291, 41)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(202, 201)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo de material"
        '
        'rblona
        '
        Me.rblona.AutoSize = True
        Me.rblona.Location = New System.Drawing.Point(18, 141)
        Me.rblona.Name = "rblona"
        Me.rblona.Size = New System.Drawing.Size(62, 24)
        Me.rblona.TabIndex = 2
        Me.rblona.TabStop = True
        Me.rblona.Text = "Lona"
        Me.rblona.UseVisualStyleBackColor = True
        '
        'rbseda
        '
        Me.rbseda.AutoSize = True
        Me.rbseda.Location = New System.Drawing.Point(18, 99)
        Me.rbseda.Name = "rbseda"
        Me.rbseda.Size = New System.Drawing.Size(63, 24)
        Me.rbseda.TabIndex = 1
        Me.rbseda.TabStop = True
        Me.rbseda.Text = "Seda"
        Me.rbseda.UseVisualStyleBackColor = True
        '
        'rbalgodon
        '
        Me.rbalgodon.AutoSize = True
        Me.rbalgodon.Location = New System.Drawing.Point(18, 59)
        Me.rbalgodon.Name = "rbalgodon"
        Me.rbalgodon.Size = New System.Drawing.Size(88, 24)
        Me.rbalgodon.TabIndex = 0
        Me.rbalgodon.TabStop = True
        Me.rbalgodon.Text = "Algodon"
        Me.rbalgodon.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(208, 100)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(125, 27)
        Me.TextBox1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Precio Costo "
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(544, 100)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(125, 27)
        Me.txtcantidad.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(544, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cantidad de chumpas a elaborar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 58)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(30, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Limpiar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(30, 159)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Salir "
        Me.Button3.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox3.Location = New System.Drawing.Point(564, 246)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(161, 204)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones"
        '
        'Resultados
        '
        Me.Resultados.Controls.Add(Me.TextBox4)
        Me.Resultados.Controls.Add(Me.Label4)
        Me.Resultados.Controls.Add(Me.Label3)
        Me.Resultados.Controls.Add(Me.TextBox2)
        Me.Resultados.Controls.Add(Me.Label1)
        Me.Resultados.Controls.Add(Me.TextBox1)
        Me.Resultados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Resultados.Location = New System.Drawing.Point(64, 276)
        Me.Resultados.Name = "Resultados"
        Me.Resultados.Size = New System.Drawing.Size(398, 223)
        Me.Resultados.TabIndex = 12
        Me.Resultados.TabStop = False
        Me.Resultados.Text = "Resultados"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(208, 151)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(125, 27)
        Me.TextBox4.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Precio Venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Precio costo por unidad"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(208, 51)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(125, 27)
        Me.TextBox2.TabIndex = 6
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Maroon
        Me.ClientSize = New System.Drawing.Size(826, 542)
        Me.Controls.Add(Me.Resultados)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.Resultados.ResumeLayout(False)
        Me.Resultados.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbL As RadioButton
    Friend WithEvents rbM As RadioButton
    Friend WithEvents rbS As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rblona As RadioButton
    Friend WithEvents rbseda As RadioButton
    Friend WithEvents rbalgodon As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Resultados As GroupBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
End Class
