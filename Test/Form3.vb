Imports System.Data.OleDb
Imports System.Data

Public Class Form3
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname As String = ""
        Dim pword As String
        Dim username As String = ""
        Dim pass As String
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Porfavor llenar la informacion")
        Else
            uname = TextBox1.Text
            pword = TextBox2.Text
            Dim querry As String = "Select password From Table1 where name= '" & uname & "';"
            Dim dbsource As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\usuarios.mdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()
            Try
                pass = cmd.ExecuteScalar().ToString
            Catch ex As Exception
                MsgBox("Username does not exit")
            End Try
            If (pword = pass) Then
                MsgBox("Login success")
                Form2.Show()
                If Form2.Visible Then
                    Me.Hide()
                End If

            Else
                MsgBox("login Failed")
                TextBox1.Clear()
                TextBox2.Clear()
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
        If Form4.Visible Then
            Me.Hide()

        End If
    End Sub
End Class