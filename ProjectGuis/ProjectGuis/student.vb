Public Class student

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub student_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub student_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.5
    End Sub

    Private Sub student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tx.Enabled = False
        tx.Text = Form.un.Text
        tx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9, FontStyle.Bold)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
        Form.Show()
    End Sub

    Private Sub tx_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tx.TextChanged

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.GotFocus
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Button2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.LostFocus
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button3_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.GotFocus
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Button3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.LostFocus
        Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.GotFocus
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button4_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.GotFocus
        Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Button5_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.GotFocus
        Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Button1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.LostFocus
        Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub

    Private Sub Button4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.LostFocus
        Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub

    Private Sub Button5_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.LostFocus
        Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub
End Class