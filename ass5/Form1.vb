Imports System.ComponentModel.DataAnnotations

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Regestration Form"
        Label2.Text = "First Name"
        Label3.Text = "Last Name"
        Label4.Text = "Father Name"
        Label5.Text = "Password"
        Label6.Text = "Confirm Password"
        Label7.Text = "Rules for Passwords"
        Label8.Text = "Contains one Capital letter!"
        Label9.Text = "Contains one Small letter!"
        Label10.Text = "Contains one Speacial Character!"
        Label11.Text = "Length shoulbe 8 or Above!"
        Label8.ForeColor = Color.Red
        Label9.ForeColor = Color.Red
        Label10.ForeColor = Color.Red
        Label11.ForeColor = Color.Red
        Label12.Text = "Gender"
        RadioButton1.Text = "Male"
        RadioButton2.Text = "Female"
        Label13.Text = ""
        Label13.ForeColor = Color.Red
        Button1.Text = "Submit"
        Button2.Text = "Reset"
        CheckBox1.Text = "Show"
        CheckBox2.Text = "Show"
        TextBox4.PasswordChar = "*"
        TextBox5.PasswordChar = "*"
        Label14.Text = ""
        Label14.ForeColor = Color.Red
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text.Length < LastChecked Then
            resetFlags()
            For Each ch As Char In TextBox4.Text
                updateFlag(ch)
            Next
        ElseIf TextBox4.Text.Length > LastChecked Then
            For i As Integer = LastChecked To LastChecked
                updateFlag(TextBox4.Text(i))
            Next
        End If
        If Not Length AndAlso TextBox4.Text.Length >= 8 Then
            Length = True
        End If
        LastChecked = TextBox4.Text.Length
        If capital Then
            Label8.ForeColor = Color.Green
        Else
            Label8.ForeColor = Color.Red
        End If
        If lower Then
            Label9.ForeColor = Color.Green
        Else
            Label9.ForeColor = Color.Red
        End If
        If Speacial Then
            Label10.ForeColor = Color.Green
        Else
            Label10.ForeColor = Color.Red
        End If
        If Length Then
            Label11.ForeColor = Color.Green
        Else
            Label11.ForeColor = Color.Red
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        Label13.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            Dim s As String = "Please Fill These Details ->"
            If TextBox1.Text = "" And TextBox2.Text = "" Then
                s = s + " Full_Name"
            ElseIf TextBox1.Text = "" And TextBox2.Text <> "" Then
                s = s + " First_Name"
            ElseIf TextBox1.Text <> "" And TextBox2.Text = "" Then
                s = s + " Last_Name"
            End If
            If TextBox3.Text = "" Then
                s = s + " Father_Name"
            End If
            If TextBox4.Text = "" And TextBox5.Text = "" Then
                s = s + " Both Password"
            ElseIf TextBox4.Text = "" And TextBox5.Text <> "" Then
                s = s + " Password"
            ElseIf TextBox4.Text <> "" And TextBox5.Text = "" Then
                s = s + " Confirm Password"
            End If
            Label13.Text = s
            Return
        End If
        If RadioButton1.Checked = CheckState.Unchecked And RadioButton2.Checked = CheckState.Unchecked Then
            Label13.Text = "Enter your Gender!"
            Return
        End If
        Label13.Text = ""
        If Not AllCondition Then
            Label13.Text = "Can't Submit You Don't Match Password Criteria!"
            Return
        End If
        Dim Name As String = TextBox1.Text & " " & TextBox2.Text
        Dim Fname As String = TextBox3.Text
        Dim password As String = TextBox4.Text
        Dim Form2 As New Form2()
        Form2.SetUserData(Name, Fname, password)
        Form2.Show()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox4.PasswordChar = ""
            CheckBox1.Text = "Hide"
        Else
            TextBox4.PasswordChar = "*"
            CheckBox1.Text = "Show"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            TextBox5.PasswordChar = ""
            CheckBox2.Text = "Hide"
        Else
            TextBox5.PasswordChar = "*"
            CheckBox2.Text = "Show"
        End If
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text.Equals(TextBox4.Text) Then
            Label14.Text = "Password Matched!"
            Label14.ForeColor = Color.Green
        Else
            Label14.Text = "Password Not Matched!"
            Label14.ForeColor = Color.Green
        End If
    End Sub
End Class
