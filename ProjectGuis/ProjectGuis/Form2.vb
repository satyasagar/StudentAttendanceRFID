Imports System.IO
Imports System
Imports System.data
Imports System.Data.SqlClient
Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim temp As String
        Dim temp1 As String
        Dim str2 As String = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID"
        Dim con1 As New SqlConnection(str2)
        con1.Open()
        Try
            Dim qry As String = "select * from Student where transid='" & a1.Text & "'"
            Dim cmd2 As New SqlCommand(qry, con1)
            Dim dr1 As SqlDataReader = cmd2.ExecuteReader()
            If dr1.HasRows Then
                While dr1.Read
                    temp = dr1(0).ToString()
                    temp1 = dr1(2).ToString()
                End While
            Else
                GoTo x
            End If
            con1.Close()
            Dim query2 As String = "Insert into Attendance(tagid,DateTime1,Rollno) Values('" & temp & "', '" & DateAndTime.Now.ToString() & "', '" & temp1 & "' )"
            con1.Open()
            Dim command As New SqlCommand(query2, con1)
            command.ExecuteReader()
            MsgBox("Attendance Marked", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
x:      con1.Close()
    End Sub

    Private Sub Form2_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub Form2_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.5
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Form.Show()
    End Sub
End Class