Public Class Calculator
    Dim a, b, r, c As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Plus.Click
        a = Val(Number2.Text)
        c = 1
        Number1.Text = Number1.Text + "+"

        Number2.Clear()

        Minus.Enabled = False
        Devision.Enabled = False
        Multipication.Enabled = False





    End Sub

    Private Sub Number1_TextChanged(sender As Object, e As EventArgs) Handles Number1.TextChanged

    End Sub

    Private Sub Devision_Click(sender As Object, e As EventArgs) Handles Devision.Click
        a = Val(Number2.Text)
        c = 2
        Number1.Text = Number1.Text + "/"

        Number2.Clear()

        Minus.Enabled = False
        Plus.Enabled = False
        Multipication.Enabled = False

    End Sub

    Private Sub Multipication_Click(sender As Object, e As EventArgs) Handles Multipication.Click
        a = Val(Number2.Text)
        c = 3
        Number1.Text = Number1.Text + "*"

        Number2.Clear()
        Minus.Enabled = False
        Devision.Enabled = False
        Plus.Enabled = False

    End Sub

    Private Sub Minus_Click(sender As Object, e As EventArgs) Handles Minus.Click
        a = Val(Number2.Text)
        c = 4
        Number1.Text = Number1.Text + "-"

        Number2.Clear()

        Plus.Enabled = False
        Devision.Enabled = False
        Multipication.Enabled = False

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Number1.Clear()
        Number2.Clear()
        a = 0
        b = 0
        r = 0

        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True
        Button9.Enabled = True
        Plus.Enabled = True
        Devision.Enabled = True
        Multipication.Enabled = True
        Button12.Enabled = True
        Button10.Enabled = True


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Number1.Text = Number1.Text + "1"
        Number2.Text = Number2.Text + "1"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Number1.Text = Number1.Text + "2"
        Number2.Text = Number2.Text + "2"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Number1.Text = Number1.Text + "3"
        Number2.Text = Number2.Text + "3"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Number1.Text = Number1.Text + "4"
        Number2.Text = Number2.Text + "4"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Number1.Text = Number1.Text + "5"
        Number2.Text = Number2.Text + "5"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Number1.Text = Number1.Text + "6"
        Number2.Text = Number2.Text + "6"
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Number1.Text = Number1.Text + "7"
        Number2.Text = Number2.Text + "7"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Number1.Text = Number1.Text + "8"
        Number2.Text = Number2.Text + "8"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Number1.Text = Number1.Text + "9"
        Number2.Text = Number2.Text + "9"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Number1.Text = Number1.Text + "0"
        Number2.Text = Number2.Text + "0"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Number2.TextChanged

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        b = Val(Number2.Text)
        Select Case c
            Case "1"
                r = a + b
            Case "2"
                r = a / b
            Case "3"
                r = a * b
            Case "4"
                r = a - b

        End Select

        Number1.Text = Number1.Text + " = " + CStr(r)
        Button1.Enabled = False
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Button6.Enabled = False
        Button7.Enabled = False
        Button8.Enabled = False
        Button9.Enabled = False
        Plus.Enabled = False
        Devision.Enabled = False
        Multipication.Enabled = False
        Button12.Enabled = False
        Button10.Enabled = False




    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Number1.Text = Number1.Text + ","
        Number2.Text = Number2.Text + "."
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Kids.Show()

    End Sub
End Class
