Public Class Form1

    'Llamar al servicio web'
    Dim servicio As New ServiceReference2.CalculadoraSoapClient

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        'Sumar los numeros utilizando el servicio web'
        Dim Nro1, Nro2 As Double
        Nro1 = txtNro1.Text  'Esta es una forma de llamar al cuadro de texto'
        Nro2 = Double.Parse(txtNro2.Text)  'Esto es una segunda forma de llamar al cuadro de texto'
        'Es libre de escoger cualquiera de los dos metodos'
        Dim Suma As Double = servicio.Suma(Nro1, Nro2)
        txtResultado.Text = Suma.ToString  'Este metodo para convertir a el numero en un texto pero esto no es necesario en el Visual Basic'

    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim Nro1, Nro2 As Double
        Nro1 = txtNro1.Text
        Nro2 = Double.Parse(txtNro2.Text)

        Dim Resta As Double = servicio.Resta(Nro1, Nro2)
        txtResultado.Text = Resta.ToString

    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Dim Nro1, Nro2 As Double
        Nro1 = txtNro1.Text
        Nro2 = txtNro2.Text

        Dim Multiplicacion As Double = servicio.Multiplicacion(Nro1, Nro2)
        txtResultado.Text = Multiplicacion.ToString
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        Dim Nro1, Nro2 As Double
        Nro1 = txtNro1.Text
        Nro2 = txtNro2.Text

        If (Nro1 = 0) Then
            txtResultado.Text = "Error!!"
        Else
            Dim Division As Double = servicio.Division(Nro1, Nro2)
            txtResultado.Text = Division.ToString
        End If

    End Sub

    Private Sub btnPotencia_Click(sender As Object, e As EventArgs) Handles btnPotencia.Click
        Dim Nro1, Nro2 As Double
        Nro1 = txtNro1.Text
        Nro2 = txtNro2.Text

        Dim Potencia As Double = servicio.Potencia(Nro1, Nro2)
        txtResultado.Text = Potencia.ToString
    End Sub

    Private Sub btnSen_Click(sender As Object, e As EventArgs) Handles btnSen.Click
        Dim Nro1 As Double
        Nro1 = txtNro1.Text

        Dim Seno As Double = servicio.Seno(Nro1)
        txtResultado.Text = Seno.ToString
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        Dim Nro1 As Double
        Nro1 = txtNro1.Text

        Dim Coseno As Double = servicio.Coseno(Nro1)
        txtResultado.Text = Coseno.ToString
    End Sub

    Private Sub btnTan_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        Dim Nro1 As Double
        Nro1 = txtNro1.Text

        Dim Tangente As Double = servicio.Tangente(Nro1)
        txtResultado.Text = Tangente.ToString
    End Sub

    Private Sub btnfac_Click(sender As Object, e As EventArgs) Handles btnfac.Click
        Dim Nro1 As Double
        Nro1 = txtNro1.Text

        Dim Factorial As Double = servicio.Factorial(Nro1)
        txtResultado.Text = Factorial.ToString
    End Sub

    Private Sub btnInversa_Click(sender As Object, e As EventArgs) Handles btnInversa.Click
        Dim Nro1 As Double
        Nro1 = txtNro1.Text

        Dim Inverso As Double = servicio.Inverso(Nro1)
        txtResultado.Text = Inverso.ToString
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim Nro1 As Double
        Nro1 = txtNro1.Text

        Dim Logaritmo As Double = servicio.Logaritmo(Nro1)
        txtResultado.Text = Logaritmo.ToString
    End Sub

    Private Sub btnPorcentaje_Click(sender As Object, e As EventArgs) Handles btnPorcentaje.Click
        Dim Nro1, Nro2 As Double
        Nro1 = txtNro1.Text
        Nro2 = txtNro1.Text

        Dim Porcentaje As Double = servicio.Porcentaje(Nro1, Nro2)
        txtResultado.Text = Porcentaje.ToString
    End Sub
End Class
