﻿Partial Class GradiDataSet
    Partial Public Class INVENTARIODataTable
        Private Sub INVENTARIODataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.SerieColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class
