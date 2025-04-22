Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "Some Details About You!"
    End Sub
    Public Sub SetUserData(name As String, Fname As String, password As String)
        Label1.Text = "Welcome " & name
        Label3.Text = "Father Name " & Fname
        Label4.Text = "Password: " & password
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label5.Text = DateTime.Now.ToString("hh:mm:ss tt")
    End Sub
End Class