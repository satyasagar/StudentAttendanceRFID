Public Class Library

    Private Sub Library_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub Library_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.5
    End Sub

    Private Sub Library_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tb1.Text = Form.un.Text
    End Sub

    Private Sub Signout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Signout.Click
        Me.Close()
        Form.Show()
    End Sub

    Private Sub Signout_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Signout.GotFocus
        Signout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Signout_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Signout.LostFocus
        Signout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Issuance.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        searchlib.Show()
    End Sub

    Private Sub Button1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.GotFocus
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Button1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.LostFocus
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Button2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.GotFocus
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Button2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.LostFocus
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub
End Class