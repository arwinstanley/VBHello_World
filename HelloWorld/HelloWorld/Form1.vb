' NAME: Alex Winstanley
' DATE: 2/6/15
' PURPOSE: my first visual basic program



Public Class frmHelloWorld
    'Set initial values
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblHelloWorld.Text = "Hello World :)"
        tbxHelloWorld.Text = "Hello World :)"
    End Sub


    'show the textbox

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        tbxHelloWorld.Show()
    End Sub

    'change the text
    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        tbxHelloWorld.Text = "My program"
    End Sub

    'restore original text

    Private Sub btnRestore_Click(sender As Object, e As EventArgs) Handles btnRestore.Click
        tbxHelloWorld.Text = "Hello World :)"
    End Sub
    'hide the text box


    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        tbxHelloWorld.Hide()
    End Sub

    'exit the program

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
