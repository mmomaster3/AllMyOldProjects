Public Class Form1
    Dim a As Double = 0
    Dim b As Double = 0.8
    Dim fa As Double = 0.3333333
    Dim n As Double = 11
    Dim dx As Double = (b - a) / (n - 1)
    Dim result As Double = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For x As Double = a To b Step dx
            result = Math.Tan(x) - (Math.Pow(Math.Tan(x), 3) / 3.0) + (Math.Pow(Math.Tan(x), 5) / 5.0) - (1.0 / 3.0)
            TextBox1.Text += Convert.ToString(Format(result, "0.000000")) + "  x=" + Convert.ToString(x) + Environment.NewLine
        Next

    End Sub
End Class
