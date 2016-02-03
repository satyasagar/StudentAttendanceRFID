Imports System.IO
Imports System
Imports System.data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Public Class searchlib

    Private Sub t1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles t1.TextChanged
        If t1.Text <> "" Then
            Due.Enabled = True
            All.Enabled = True
        Else
            Due.Enabled = False
            All.Enabled = False
        End If
    End Sub

    Private Sub searchlib_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub searchlib_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.5
    End Sub

    Private Sub searchlib_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Due.Enabled = False
        All.Enabled = False
    End Sub

    Private Sub Signout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Signout.Click
        Me.Close()
        Library.Show()
    End Sub

    Private Sub Due_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Due.Click
        Dim str2 As String = "Provider=SQLOLEDB;data source=.;user id= sa;pwd=alaska;initial catalog=RFID"
        Dim con1 As New OleDbConnection(str2)
        con1.Open()
        Try
            Dim qry As String = "select * from Issuance where stagid='" & t1.Text & "' AND returned='0'"
            Dim cmd As New OleDbCommand(qry, con1)
            Dim dt As DataTable
            dt = New DataTable()
            Dim da As New OleDbDataAdapter(qry, con1)
            da.Fill(dt)
            dg.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con1.Close()
    End Sub

    Private Sub All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles All.Click
        Dim str2 As String = "Provider=SQLOLEDB;data source=.;user id= sa;pwd=alaska;initial catalog=RFID"
        Dim con1 As New OleDbConnection(str2)
        con1.Open()
        Try
            Dim qry As String = "select * from Issuance where stagid='" & t1.Text & "'"
            Dim cmd As New OleDbCommand(qry, con1)
            Dim dt As DataTable
            dt = New DataTable()
            Dim da As New OleDbDataAdapter(qry, con1)
            da.Fill(dt)
            dg.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con1.Close()
    End Sub

    Private Sub Signout_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Signout.GotFocus
        Signout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Signout_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Signout.LostFocus
        Signout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub

    Private Sub Due_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Due.GotFocus
        Due.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Due_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Due.LostFocus
        Due.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub

    Private Sub All_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles All.GotFocus
        All.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub All_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles All.LostFocus
        All.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub
End Class