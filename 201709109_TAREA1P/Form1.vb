Imports System.Math
Public Class form1
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub

    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If rbS.Checked = False And rbM.Checked = False And rbL.Checked = False Then
            MsgBox("Elegir una talla por favor")

        End If

        If rbalgodon.Checked = False And rbseda.Checked = False And rblona.Checked = False Then
            MsgBox("Elegir el tipo de material por favor")
        End If

        If txtcantidad.Text = "" Then
            txtcantidad.Text = 1

        End If

        Dim CantYardas As Double = 0



        Dim yardas_usar As Double = 0
        yardas_usar = txtcantidad.Text

        Dim CostMO As Double = 0
        CostMO = Val(TextBox1.Text)

        Dim P_cost_U As Double
        P_cost_U = Val(TextBox2.Text)

        Dim P_venta As Double
        P_venta = Val(TextBox4.Text)




        If rbS.Checked = True And rbalgodon.Checked = True Then
            TextBox1.Text = Round(Val((MOS * txtcantidad.Text) + (Palgodon * YardasS * txtcantidad.Text)), 2)
        ElseIf rbS.Checked = True And rbseda.Checked = True Then
            TextBox1.Text = Round(Val((MOS * txtcantidad.Text) + (Pseda * YardasS * txtcantidad.Text)), 2)
        ElseIf rbS.Checked = True And rblona.Checked = True Then
            TextBox1.Text = Round(Val((MOS * txtcantidad.Text) + (Plona * YardasS * txtcantidad.Text)), 2)


        ElseIf rbM.Checked = True And rbalgodon.Checked = True Then
            TextBox1.Text = Round(Val((MOM * txtcantidad.Text) + (Palgodon * YardasM * txtcantidad.Text)), 2)
        ElseIf rbM.Checked = True And rbseda.Checked = True Then
            TextBox1.Text = Round(Val((MOM * txtcantidad.Text) + (Pseda * YardasM * txtcantidad.Text)), 2)
        ElseIf rbM.Checked = True And rblona.Checked = True Then
            TextBox1.Text = Round(Val((MOM * txtcantidad.Text) + (Plona * YardasM * txtcantidad.Text)), 2)


        ElseIf rbL.Checked = True And rbalgodon.Checked = True Then
            TextBox1.Text = Round(Val((MOL * txtcantidad.Text) + (Palgodon * YardasL * txtcantidad.Text)), 2)
        ElseIf rbL.Checked = True And rbseda.Checked = True Then
            TextBox1.Text = Round(Val((MOL * txtcantidad.Text) + (Pseda * YardasL * txtcantidad.Text)), 2)
        ElseIf rblona.Checked = True And rblona.Checked = True Then
            TextBox1.Text = Round(Val((MOL * txtcantidad.Text) + (Plona * YardasL * txtcantidad.Text)), 2)

        End If


        P_cost_U = (TextBox1.Text / txtcantidad.Text)
        TextBox2.Text = Round(Val(P_cost_U), 2)

        P_venta = (TextBox1.Text * 0.65) + TextBox1.Text
        TextBox4.Text = Round(Val(P_venta), 2)














    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If MsgBox(" ¿ Desea salir del programa ? ", vbQuestion + vbYesNo, "salir") = vbYes Then
            End
        End If

    End Sub

    Private Sub txtcantidad_TextChanged(sender As Object, e As EventArgs) Handles txtcantidad.TextChanged

    End Sub

    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        txtcantidad.Clear()
        TextBox2.Clear()

        TextBox4.Clear()
        rbS.Checked = False
        rbM.Checked = False
        rbM.Checked = False
        rbalgodon.Checked = False
        rbseda.Checked = False
        rblona.Checked = False


    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox2_Enter_1(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Resultados_Enter(sender As Object, e As EventArgs) Handles Resultados.Enter

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
