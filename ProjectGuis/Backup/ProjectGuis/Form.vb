Imports System.IO
Imports System
Imports System.data
Imports System.Data.SqlClient
Public Class Form

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub cb1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb1.SelectedIndexChanged

    End Sub

    Private Sub signin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signin.Click
        Dim str2 As String = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID"
        Dim con1 As New SqlConnection(str2)
        con1.Open()
        Try
            Dim qry As String = "select * from Login where loginid='" & un.Text & "'AND pass='" & pass.Text & "'AND rights='" & cb1.Text & "'"
            Dim cmsel As New SqlCommand(qry, con1)
            Dim dr1 As SqlDataReader = cmsel.ExecuteReader()
            If dr1.HasRows Then
                dr1.Read()
                If cb1.Text = "Administrator" Then
                    Me.Hide()
                    admin.Show()
                End If
                If cb1.Text = "Student" Then
                    Me.Hide()
                    student.Show()
                End If
                If cb1.Text = "Faculty" Then
                    Me.Hide()
                    faculty.Show()
                End If
                If dr1(3).ToString = "Librarian" Then
                    Me.Hide()
                    Library.Show()
                End If
            Else
                MsgBox("Login Unsuccessful", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con1.Close()
    End Sub

    Private Sub Form_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
        un.Clear()
        pass.Clear()
        cb1.Text = ""
    End Sub

    Private Sub Form_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.5
    End Sub

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub un_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles un.TextChanged

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub signin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles signin.GotFocus
        signin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub signin_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles signin.LostFocus
        signin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub

    Private Sub Button2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.GotFocus
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Button2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.LostFocus
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub

    Private Sub att_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles att.Click
        Me.Hide()
        Form2.Show()
    End Sub
End Class
