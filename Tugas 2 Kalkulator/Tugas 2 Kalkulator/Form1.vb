Public Class Form1

    Dim x As Integer
    Dim cek As Byte
    Dim cekOnce As Boolean = False

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If (cekIsi()) Then
            layarKalkulator.Text = "0"
        Else
            layarKalkulator.Text &= "0"
        End If
        Me.cekOnce = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (cekIsi()) Then
            layarKalkulator.Text = "1"
        Else
            layarKalkulator.Text &= "1"
        End If
        Me.cekOnce = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (cekIsi()) Then
            layarKalkulator.Text = "2"
        Else
            layarKalkulator.Text &= "2"
        End If
        Me.cekOnce = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (cekIsi()) Then
            layarKalkulator.Text = "3"
        Else
            layarKalkulator.Text &= "3"
        End If
        Me.cekOnce = True
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (cekIsi()) Then
            layarKalkulator.Text = "4"
        Else
            layarKalkulator.Text &= "4"
        End If
        Me.cekOnce = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (cekIsi()) Then
            layarKalkulator.Text = "5"
        Else
            layarKalkulator.Text &= "5"
        End If
        Me.cekOnce = True
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If (cekIsi()) Then
            layarKalkulator.Text = "6"
        Else
            layarKalkulator.Text &= "6"
        End If
        Me.cekOnce = True
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If (cekIsi()) Then
            layarKalkulator.Text = "7"
        Else
            layarKalkulator.Text &= "7"
        End If
        Me.cekOnce = True
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If (cekIsi()) Then
            layarKalkulator.Text = "8"
        Else
            layarKalkulator.Text &= "8"
        End If
        Me.cekOnce = True
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If (cekIsi()) Then
            layarKalkulator.Text = "9"
        Else
            layarKalkulator.Text &= "9"
        End If
        Me.cekOnce = True
    End Sub

    Private Function cekIsi()
        If (layarKalkulator.Text.Equals("0") Or Me.cek > 0) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        layarKalkulator.Text = "0"
        Me.x = 0
        Me.cek = 0
    End Sub

    Private Sub kurangButton_Click(sender As Object, e As EventArgs) Handles kurangButton.Click
        If (Me.cekOnce = True) Then
            If (Me.x = 0 Or Me.cek = 2) Then
                Me.x += Convert.ToInt32(layarKalkulator.Text)
            Else
                Me.x -= Convert.ToInt32(layarKalkulator.Text)
            End If
            layarKalkulator.Text = Me.x.ToString
            Me.cek = 1
            Me.cekOnce = False
        End If
    End Sub

    Private Sub tambahButton_Click(sender As Object, e As EventArgs) Handles tambahButton.Click
        If (Me.cekOnce = True) Then
            If (Me.cek = 1) Then
                Me.x -= Convert.ToInt32(layarKalkulator.Text)
            Else
                Me.x += Convert.ToInt32(layarKalkulator.Text)
            End If
            layarKalkulator.Text = Me.x.ToString
            Me.cek = 2
            Me.cekOnce = False
        End If
    End Sub

    Private Sub samadenganButton_Click(sender As Object, e As EventArgs) Handles samadenganButton.Click
        Select Me.cek
            Case 1
                layarKalkulator.Text = Convert.ToString(Me.x - Convert.ToInt32(layarKalkulator.Text))
            Case 2
                layarKalkulator.Text = Convert.ToString(Me.x + Convert.ToInt32(layarKalkulator.Text))
        End Select
        Me.x = 0
        Me.cekOnce = True
    End Sub
End Class
