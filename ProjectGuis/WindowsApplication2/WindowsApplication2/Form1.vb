Imports System.IO
Imports System
Imports System.data
Imports System.Data.SqlClient
Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str2 As String = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID"
        Dim con1 As New SqlConnection(str2)
        con1.Open()
        Dim qr1 As String = "Insert into Student(transid,sname,Rollno) Values('" & a1.Text & "', '" & a2.Text & "', '" & a3.Text & "' )"
        Dim cmd2 As New SqlCommand(qr1, con1)
        Try
            cmd2.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            GoTo c
        End Try
        MsgBox("Data Inserted", MsgBoxStyle.Information)
c:      con1.Close()
        a1.Clear()
        a2.Clear()
        a3.Clear()
        a1.Enabled = True
        a2.Enabled = True
        a3.Enabled = True
    End Sub

    Private Sub a3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a3.TextChanged

    End Sub

    Private Sub a1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.TextChanged

    End Sub

    Private Sub a2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a2.TextChanged

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim str2 As String = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID"
        Dim con1 As New SqlConnection(str2)
        con1.Open()
        Dim qr1 As String = "Delete from Student where transid='" & a1.Text & "'"
        Dim cmd2 As New SqlCommand(qr1, con1)
        Try
            cmd2.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            GoTo c
        End Try
        MsgBox("Row against " & a1.Text & " Deleted", MsgBoxStyle.Information)
c:      con1.Close()
        a1.Clear()
        a2.Clear()
        a3.Clear()
        a1.Enabled = True
        a2.Enabled = True
        a3.Enabled = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        a1.Enabled = False
        Dim str2 As String = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID"
        Dim con1 As New SqlConnection(str2)
        con1.Open()
        Try
            Dim qry As String = "select * from Student where transid='" & a1.Text & "'"
            Dim cmd2 As New SqlCommand(qry, con1)
            Dim dr1 As SqlDataReader = cmd2.ExecuteReader()
            If dr1.HasRows Then
                While dr1.Read
                    a1.Text = dr1(0).ToString()
                    a2.Text = dr1(1).ToString()
                    a3.Text = dr1(2).ToString()
                End While
            End If

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con1.Close()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        a1.Clear()
        a2.Clear()
        a3.Clear()
        a1.Enabled = True
        a2.Enabled = True
        a3.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim str2 As String = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID"
        Dim con1 As New SqlConnection(str2)
        con1.Open()
        Dim qr1 As String = "Update Student set sname='" & a2.Text & "',Rollno='" & a3.Text & "' where transid='" & a1.Text & "'"
        Dim cmd2 As New SqlCommand(qr1, con1)
        Try
            cmd2.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
            GoTo c
        End Try
        MsgBox("Row against " & a1.Text & " Updated", MsgBoxStyle.Information)
c:      con1.Close()
        a1.Clear()
        a2.Clear()
        a3.Clear()
        a1.Enabled = True
        a2.Enabled = True
        a3.Enabled = True
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

End Class
