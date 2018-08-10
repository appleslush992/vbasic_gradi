Imports System.Data.OleDb
Imports System.Data


Public Class Form4
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox2.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MsgBox("plz fill the info")
        Else
            Try
                Dim conn As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\usuarios.mdb")
                Dim insert As String = "Insert into Table1 values('" & TextBox1.Text & "','" & TextBox2.Text & "');"
                Dim cmd As New OleDbCommand(insert, conn)
                conn.Open()
                cmd.ExecuteNonQuery()
                MsgBox("create success")
                Me.Close()
            Catch ex As Exception
                MsgBox("error")
            End Try
        End If
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub Form4_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Form3.Show()
    End Sub
End Class