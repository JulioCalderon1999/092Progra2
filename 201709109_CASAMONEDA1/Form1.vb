Imports System.Math
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox4.Clear()
        rbdolar.Checked = False
        rbpeso.Checked = False
        rbcolon.Checked = False
        rbeuro.Checked = False
        ckcompra.Checked = False
        ckventa.Checked = False


        TextBox4.Focus()


    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox1_EnabledChanged(sender As Object, e As EventArgs) Handles GroupBox1.EnabledChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If (IsNumeric(TextBox4.Text) And Val(TextBox4.Text)) < 0 Then
            MsgBox("Debe de ingresar un valor numerico positivo", , "Error")

        End If

    End Sub

    Private Sub GroupBox3_EnabledChanged(sender As Object, e As EventArgs) Handles GroupBox3.EnabledChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tipo_de_cambio As Double
        tipo_de_cambio = Val(TextBox4.Text)
        Dim resultado As Double
        resultado = Val(TextBox2.Text)
        Dim resultadoconcomision As String
        resultadoconcomision = TextBox1.Text





        If ckcompra.Checked = True Then
            If rbdolar.Checked = True Then
                TextBox2.Text = Round(Val(TextBox4.Text) * dolar, 2)
            End If
            If rbpeso.Checked = True Then
                TextBox2.Text = Round(Val(TextBox4.Text) * peso, 2)
            End If
            If rbcolon.Checked = True Then
                TextBox2.Text = Round(Val(TextBox4.Text) * colon, 2)
            End If
            If rbeuro.Checked = True Then
                TextBox2.Text = Round(Val(TextBox4.Text) * euro, 2)
            End If
            If (TextBox4.Text = "") Or (Not IsNumeric(TextBox4.Text)) Then
                MsgBox("Debe de ingresar un valor numerico")
            End If
        End If

        If ckcompra.Checked = True Then
            TextBox1.Text = Round(Val(TextBox2.Text * comisioncompra) + (TextBox2.Text), 2)

        End If



        If ckventa.Checked = True Then
            If rbdolar.Checked = True Then
                TextBox2.Text = Round(Val(TextBox4.Text) * dolar, 2)
            End If
            If rbpeso.Checked = True Then
                TextBox2.Text = Round(tipo_de_cambio * peso, 2)
            End If
            If rbcolon.Checked = True Then
                TextBox2.Text = Round(tipo_de_cambio * colon, 2)
            End If
            If rbeuro.Checked = True Then
                TextBox2.Text = Round(tipo_de_cambio * euro, 2)
            End If

        End If

        If ckventa.Checked = True Then
            TextBox1.Text = Round(Val(TextBox2.Text * comisionventa) + (TextBox2.Text), 2)

        End If




    End Sub




    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles ckcompra.CheckedChanged
        If ckcompra.Checked = True Then
            GroupBox3.Visible = True
        Else
            GroupBox3.Visible = False
        End If



        If ckcompra.Checked = True And ckventa.Checked = True Then
            GroupBox2.Visible = False
        Else
            GroupBox2.Visible = True
        End If




    End Sub

    Private Sub ckventa_CheckedChanged(sender As Object, e As EventArgs) Handles ckventa.CheckedChanged
        If ckventa.Checked = True Then
            GroupBox3.Visible = True
        Else
            GroupBox3.Visible = False

        End If


        If ckcompra.Checked = True And ckventa.Checked = True Then
            GroupBox2.Enabled = False
        Else
            GroupBox2.Enabled = True
        End If









    End Sub

    Private Sub rbdolar_CheckedChanged(sender As Object, e As EventArgs) Handles rbdolar.CheckedChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox(" ¿ Desea salir del programa ? ", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox3_TextChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class
