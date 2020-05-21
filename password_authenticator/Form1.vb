Public Class Form1

    Function IsValid(ByVal strInput As String) As Boolean
        Dim intCount As Integer
        Dim strCount As Integer
        Dim blnResult As Boolean
        intCount = 0
        strCount = 0
        For i = 0 To strInput.Length - 1
            If Char.IsNumber(strInput.Chars(i)) Then
                intCount += 1
            ElseIf Char.IsLetter(strInput.Chars(i)) Then
                strCount += 1
            End If
        Next
        If intCount >= 1 And strCount >= 1 And strInput.Length >= 6 Then
            blnResult = True
            lblResults.Text = "True"
        Else
            blnResult = False
            lblResults.Text = "Make sure you type at least one digit, and one letter character. Must contain 6 characters in the string."
        End If

        Return blnResult
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim blnResult As Boolean

        blnResult = IsValid(txtInput.Text)
    End Sub
End Class
