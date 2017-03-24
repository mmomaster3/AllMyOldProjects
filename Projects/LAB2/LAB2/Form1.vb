Public Class Form1
    Dim a() As Integer
    Dim r As New Random
    Dim sum As Integer
    Dim Avr As Double
    Dim counter As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ReDim a(Convert.ToInt32(NumericUpDown2.Value - 1))
        TextBox1.Text = ""
        For index = 0 To a.Length - 1
            a(index) = r.Next(10)
            TextBox1.Text += Convert.ToString(a(index)) + " "
            If a(index) < a(0) Or a(index) = a(0) Then
                sum += a(index)
                counter = counter + 1
            End If
        Next
        Avr = sum / counter
        TextBox1.Text += Environment.NewLine + "Среднее арифм. по условию " + Format(Avr, "##.####")
        TextBox1.Text += Environment.NewLine + "Среднее арифм. " + Format(a.Average(), "##.####")

    End Sub
End Class
