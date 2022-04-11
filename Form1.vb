Public Class Form1

    Dim plain As String
    Dim cipher As String
    Dim key As Int32
    Dim i As Int32
    Dim j As Int32

    Private Sub btnPlain_Click(sender As Object, e As EventArgs) Handles btnPlain.Click

        If (txtPlain.Text.Trim.Length > 0 And txtPlainKey.Text.Trim.Length > 0) Then

            If (Convert.ToInt32(txtPlainKey.Text) > 25) Then
                MessageBox.Show("Please enter a key between 0 to 25")
            Else
                plain = txtPlain.Text
                key = Convert.ToInt32(txtPlainKey.Text)

                For i = 0 To (plain.Length() - 1)
                    If (Char.IsWhiteSpace(plain(i))) Then

                        cipher += Convert.ToChar(32)

                    ElseIf (Char.IsUpper(plain(i))) Then

                        cipher += Convert.ToChar((((Convert.ToInt32(plain(i)) + key) - 65) Mod 26) + 65)

                    Else

                        cipher += Convert.ToChar((((Convert.ToInt32(plain(i)) + key) - 97) Mod 26) + 97)

                    End If
                Next

                lblCipher.Text = cipher
                lblDecrypt.Text = ""

                plain = ""
                cipher = ""
                i = 0
            End If



        Else
            MessageBox.Show("Please Fill the Details")
        End If

    End Sub

    Private Sub btnCipher_Click(sender As Object, e As EventArgs) Handles btnCipher.Click

        If (txtPlain.Text.Trim.Length > 0 And txtPlainKey.Text.Trim.Length > 0) Then

            If (Convert.ToInt32(txtPlainKey.Text) > 25) Then
                MessageBox.Show("Please enter a key between 0 to 25")
            Else
                cipher = txtPlain.Text
                key = Convert.ToInt32(txtPlainKey.Text)

                For j = 0 To (cipher.Length() - 1)
                    If (Char.IsWhiteSpace(cipher(j))) Then

                        plain += Convert.ToChar(32)

                    ElseIf (Char.IsUpper(cipher(j))) Then

                        plain += Convert.ToChar(((((Convert.ToInt32(cipher(j)) - key) - 65) + 26) Mod 26) + 65)

                    Else

                        plain += Convert.ToChar(((((Convert.ToInt32(cipher(j)) - key) - 97) + 26) Mod 26) + 97)

                    End If
                Next

                lblDecrypt.Text = plain
                lblCipher.Text = ""

                plain = ""
                cipher = ""
                j = 0
            End If


        Else
            MessageBox.Show("Warning Please Fill the Details")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPlain.Clear()
        txtPlainKey.Clear()
        lblCipher.Text = ""
        lblDecrypt.Text = ""
        plain = ""
        cipher = ""
        key = 0
        i = 0
        j = 0
    End Sub
End Class
