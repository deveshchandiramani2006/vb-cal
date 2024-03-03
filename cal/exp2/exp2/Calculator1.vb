Imports System.Security.Cryptography
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO
Public Class Form1
    Dim num1
    Dim num2
    Dim num = 0
    Dim sw As StreamWriter
    Dim filePath As String = "C:\Users\Admin\source\repos\cal\exp2\exp2\CalculationHistory.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            sw = File.AppendText(filePath)
        Catch ex As IOException
            MessageBox.Show("Error accessing file. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If sw IsNot Nothing Then
            sw.Close()
        End If
    End Sub

    Private Sub saveHistory(operation As String)
        If sw IsNot Nothing Then
            sw.WriteLine(operation)
            sw.Flush() ' Flush the stream to ensure data is written immediately
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MessageBox.Show("Number not entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            TextBox1.Text = Val(TextBox1.Text) + Val(TextBox2.Text)
            TextBox2.Text = TextBox1.Text
            saveHistory($"{TextBox2.Text} + {TextBox1.Text} = {TextBox1.Text}")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MessageBox.Show("Number not entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            TextBox1.Text = Val(TextBox2.Text) - Val(TextBox1.Text)
            TextBox2.Text = TextBox1.Text
            saveHistory($"{TextBox2.Text} - {TextBox1.Text} = {TextBox1.Text}")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MessageBox.Show("Number not entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            TextBox1.Text = Val(TextBox1.Text) * Val(TextBox2.Text)
            TextBox2.Text = TextBox1.Text
            saveHistory($"{TextBox2.Text} * {TextBox1.Text} = {TextBox1.Text}")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If (TextBox1.Text = "" Or TextBox2.Text = "") Then
            MessageBox.Show("Number not entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf Val(TextBox1.Text) = 0 Then
            MessageBox.Show("Cannot divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            TextBox1.Text = Val(TextBox2.Text) / Val(TextBox1.Text)
            TextBox2.Text = TextBox1.Text
            saveHistory($"{TextBox2.Text} / {TextBox1.Text} = {TextBox1.Text}")
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox2.Text = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text &= "3"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text &= "4"

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text &= "5"

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text &= "7"

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click

        TextBox1.Text &= "0"


    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text &= "1"

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text &= "2"

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text &= "6"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text &= "8"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text &= "9"

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text &= "."

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click

        TextBox2.Text = TextBox1.Text
        TextBox1.Text = ""
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Toggle between black and white modes
        If num = 0 Then
            ' Set black mode
            SetBlackMode()
            num = 1
        Else
            ' Set white mode
            SetWhiteMode()
            num = 0
        End If

        ' Toggle the mode flag

    End Sub

    ' Function to set black mode
    Private Sub SetBlackMode()
        Me.BackColor = Color.Black
        Me.ForeColor = Color.Black

    End Sub

    ' Function to set white mode
    Private Sub SetWhiteMode()
        Me.BackColor = Color.White
        Me.ForeColor = Color.Black
    End Sub

    ' Function to set button colorss
End Class
