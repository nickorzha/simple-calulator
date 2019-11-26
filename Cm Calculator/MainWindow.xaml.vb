Imports System.Data

Class MainWindow
    Private Sub Btn_backspace_Click(sender As Object, e As RoutedEventArgs) Handles btn_backspace.Click
        If txt_input.Text < " " Then
            txt_input.Text = Mid(txt_input.Text, 1, Len(txt_input.Text) - 1 + 1)
        Else
            txt_input.Text = Mid(txt_input.Text, 1, Len(txt_input.Text) - 1)
        End If
    End Sub

    Private Sub Btn_clear_Click(sender As Object, e As RoutedEventArgs) Handles btn_clear.Click
        txt_input.Text = " "
    End Sub

    Private Sub Btn_ln_Click(sender As Object, e As RoutedEventArgs) Handles btn_ln.Click
        If (txt_input.Text = vbNullString) Then
            txt_input.Text = txt_input.Text
        Else
            txt_input.Text = Math.Log(txt_input.Text)
        End If
    End Sub

    Private Sub Btn_log_Click(sender As Object, e As RoutedEventArgs) Handles btn_log.Click
        If (txt_input.Text = vbNullString) Then
            txt_input.Text = txt_input.Text
        Else
            txt_input.Text = Math.Log10(txt_input.Text)
        End If
    End Sub

    Private Sub Btn_power_Click(sender As Object, e As RoutedEventArgs) Handles btn_power.Click
        If (txt_input.Text = vbNullString) Then
            txt_input.Text = txt_input.Text
        Else
            txt_input.Text = txt_input.Text & "^"
        End If
    End Sub

    Private Sub Btn_exponent_Click(sender As Object, e As RoutedEventArgs) Handles btn_exponent.Click
        If (txt_input.Text = vbNullString) Then
            txt_input.Text = txt_input.Text
        Else
            txt_input.Text = Math.Exp(txt_input.Text)
        End If
    End Sub

    Private Sub Btn_sqrt_Click(sender As Object, e As RoutedEventArgs) Handles btn_sqrt.Click
        If (txt_input.Text = vbNullString) Then
            txt_input.Text = txt_input.Text
        Else
            txt_input.Text = Math.Sqrt(txt_input.Text)
        End If
    End Sub

    Private Sub Btn_reciprocal_Click(sender As Object, e As RoutedEventArgs) Handles btn_reciprocal.Click
        If (txt_input.Text = vbNullString) Then
            txt_input.Text = txt_input.Text
        Else
            txt_input.Text = 1 / txt_input.Text
        End If
    End Sub

    Private Sub Btn_equalsto_Click(sender As Object, e As RoutedEventArgs) Handles btn_equalsto.Click
        If (txt_input.Text = vbNullString) Then
            txt_input.Text = txt_input.Text
        Else
            txt_input.Text = New DataTable().Compute(txt_input.Text, Nothing)
        End If
    End Sub

    Private Sub Btn_divide_Click(sender As Object, e As RoutedEventArgs) Handles btn_divide.Click
        If (txt_input.Text = vbNullString) Then
            txt_input.Text = txt_input.Text
        Else
            txt_input.Text = txt_input.Text & "/"
        End If
    End Sub

    Private Sub Btn_multiply_Click(sender As Object, e As RoutedEventArgs) Handles btn_multiply.Click
        If (txt_input.Text = vbNullString) Then
            txt_input.Text = txt_input.Text
        Else
            txt_input.Text = txt_input.Text & "*"
        End If
    End Sub

    Private Sub Btn_minus_Click(sender As Object, e As RoutedEventArgs) Handles btn_minus.Click
        If (txt_input.Text = vbNullString) Then
            txt_input.Text = txt_input.Text
        Else
            txt_input.Text = txt_input.Text & "-"
        End If
    End Sub

    Private Sub Btn_plus_Click(sender As Object, e As RoutedEventArgs) Handles btn_plus.Click
        If (txt_input.Text = vbNullString) Then
            txt_input.Text = txt_input.Text
        Else
            txt_input.Text = txt_input.Text & "+"
        End If
    End Sub

    Private Sub Btn_seven_Click(sender As Object, e As RoutedEventArgs) Handles btn_seven.Click
        txt_input.Text = txt_input.Text & "7"
    End Sub

    Private Sub Btn_eight_Click(sender As Object, e As RoutedEventArgs) Handles btn_eight.Click
        txt_input.Text = txt_input.Text & "8"
    End Sub

    Private Sub Btn_nine_Click(sender As Object, e As RoutedEventArgs) Handles btn_nine.Click
        txt_input.Text = txt_input.Text & "9"
    End Sub

    Private Sub Btn_four_Click(sender As Object, e As RoutedEventArgs) Handles btn_four.Click
        txt_input.Text = txt_input.Text & "4"
    End Sub

    Private Sub Btn_five_Click(sender As Object, e As RoutedEventArgs) Handles btn_five.Click
        txt_input.Text = txt_input.Text & "5"
    End Sub

    Private Sub Btn_six_Click(sender As Object, e As RoutedEventArgs) Handles btn_six.Click
        txt_input.Text = txt_input.Text & "6"
    End Sub

    Private Sub Btn_one_Click(sender As Object, e As RoutedEventArgs) Handles btn_one.Click
        txt_input.Text = txt_input.Text & "1"
    End Sub

    Private Sub Btn_two_Click(sender As Object, e As RoutedEventArgs) Handles btn_two.Click
        txt_input.Text = txt_input.Text & "2"
    End Sub

    Private Sub Btn_three_Click(sender As Object, e As RoutedEventArgs) Handles btn_three.Click
        txt_input.Text = txt_input.Text & "3"
    End Sub

    Private Sub Btn_decimal_Click(sender As Object, e As RoutedEventArgs) Handles btn_decimal.Click
        txt_input.Text = txt_input.Text & "."
    End Sub

    Private Sub Btn_zero_Click(sender As Object, e As RoutedEventArgs) Handles btn_zero.Click
        txt_input.Text = txt_input.Text & "0"
    End Sub

    Private Sub Btn_pi_Click(sender As Object, e As RoutedEventArgs) Handles btn_pi.Click
        txt_input.Text = txt_input.Text & "3.14159265"
    End Sub

    Private Sub TextBox_TextChanged(sender As Object, e As TextChangedEventArgs)

    End Sub
End Class