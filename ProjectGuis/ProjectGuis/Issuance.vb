Imports System.IO
Imports System
Imports System.data
Imports System.Data.SqlClient
Public Class Issuance

    Dim day As Double = 14
    Dim d As Date

    Private Sub Issuance_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Me.Opacity = 1
    End Sub

    Private Sub Issuance_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Deactivate
        Me.Opacity = 0.5
    End Sub
    Private Sub Issuance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dd.Enabled = False
        d = d1.Value.AddDays(day)
        Dim date1 As String = d.Day.ToString()
        Dim mon As String = d.Month.ToString()
        Dim yea As String = d.Year.ToString()
        If Convert.ToInt32(mon) < 10 Then
            mon = String.Concat(0, mon)
        End If
        If Convert.ToInt32(date1) < 10 Then
            date1 = String.Concat(0, date1)
        End If
        dd.Text = "" & date1 & "/" & mon & "/" & yea & ""
    End Sub

    Private Sub dd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dd.TextChanged

    End Sub

    Private Sub assign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles assign.Click
        Dim str2 As String = "data source=.;user id= sa;pwd=alaska;initial catalog=RFID"
        Dim con1 As New SqlConnection(str2)
        Dim con2 As New SqlConnection(str2)
        Dim con3 As New SqlConnection(str2)
        con1.Open()
        Try
            Dim qry As String = "select * from student where transid='" & Tag.Text & "'"
            Dim cmsel As New SqlCommand(qry, con1)
            Dim dr1 As SqlDataReader = cmsel.ExecuteReader()
            If dr1.HasRows Then
                dr1.Read()
                Dim qry1 As String = "select * from Login where designation='" & dr1(0).ToString & "'"
                Dim cmsel1 As New SqlCommand(qry1, con2)
                con2.Open()
                Dim dr2 As SqlDataReader = cmsel1.ExecuteReader()
                If dr2.HasRows And bid.Text <> "" Then
                    Dim qry2 As String = "Insert into Issuance (stagid,bkid,Dateissue,DueDate) Values('" & dr1(0).ToString & "','" & bid.Text & "', '" & d1.Value & "', '" & dd.Text & "')"
                    Dim cmsel2 As New SqlCommand(qry2, con3)
                    con3.Open()
                    Try
                        cmsel2.ExecuteReader()
                    Catch ex As Exception
                        MsgBox(ex.Message, MsgBoxStyle.Information)
                    End Try
                    MsgBox("Data Inserted Due Date: '" & dd.Text & "'", MsgBoxStyle.Information)
                Else
                    If bid.Text <> "" Then
                        MsgBox("Student's Login Information is missing", MsgBoxStyle.Information)
                    Else
                        MsgBox("Field Book Id cannot be Empty", MsgBoxStyle.Information)
                    End If
                End If
            Else
        MsgBox("No Such Student Exists in the Student Table", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
        con3.Close()
        con2.Close()
        con1.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        Library.Show()
    End Sub

    Private Sub d1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d1.ValueChanged
        d = d1.Value.AddDays(day)
        Dim date1 As String = d.Day.ToString()
        Dim mon As String = d.Month.ToString()
        Dim yea As String = d.Year.ToString()
        If Convert.ToInt32(mon) < 10 Then
            mon = String.Concat(0, mon)
        End If
        If Convert.ToInt32(date1) < 10 Then
            date1 = String.Concat(0, date1)
        End If
        dd.Text = "" & date1 & "/" & mon & "/" & yea & ""
    End Sub

    Private Sub assign_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles assign.GotFocus
        assign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub assign_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles assign.LostFocus
        assign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Regular)
    End Sub

    Private Sub Button2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.GotFocus
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub

    Private Sub Button2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.LostFocus
        Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8, FontStyle.Bold)
    End Sub
End Class