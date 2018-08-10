Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'GradiDataSet1.INVENTARIO' table. You can move, or remove it, as needed.
        Me.INVENTARIOTableAdapter.Fill(Me.GradiDataSet1.INVENTARIO)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Validate()
        Me.INVENTARIOBindingSource.EndEdit()
        Me.INVENTARIOTableAdapter.Update(Me.GradiDataSet1)
    End Sub
End Class
