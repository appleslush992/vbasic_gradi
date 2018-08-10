Public Class Form2
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form1.INVENTARIOTableAdapter.Insert(Me.TextBox1.Text, Me.TextBox2.Text, Me.TextBox3.Text, Me.TextBox4.Text, Me.TextBox5.Text, Me.TextBox6.Text,
                                            Me.TextBox7.Text.ToString)
        Form1.INVENTARIOTableAdapter.Fill(Form1.GradiDataSet1.INVENTARIO)
        MsgBox("Registro Guardado")
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub
End Class