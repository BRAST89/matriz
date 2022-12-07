Public Class Ejercicio_21
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fila, columna As Byte
        Dim i As Byte
        fila = Val(TextBox1.Text)
        columna = Val(TextBox2.Text)
        matriza.RowCount = fila
        matriza.ColumnCount = columna
        For i = 0 To columna - 1
            matriza.Columns(i).HeaderText = i + 1
            matriza.Columns(i).Width = 50

        Next
        matrizb.RowCount = fila
        matrizb.ColumnCount = columna
        For i = 0 To columna - 1
            matrizb.Columns(i).HeaderText = i + 1
            matrizb.Columns(i).Width = 50

        Next
        matrizc.RowCount = fila
        matrizc.ColumnCount = columna
        For i = 0 To columna - 1
            matrizc.Columns(i).HeaderText = i + 1
            matrizc.Columns(i).Width = 50

        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim i, j, k As Byte
        Dim valor As Integer
        Dim fila, columna As Byte
        fila = Val(TextBox1.Text)
        columna = Val(TextBox2.Text)
        If fila = columna Then
            For k = 0 To fila - 1
                For i = 0 To columna - 1
                    valor = 0
                    For j = 0 To columna - 1
                        valor = valor + Val(matriza.Rows(k).Cells(j).Value) * Val(matrizb.Rows(j).Cells(i).Value)
                        matrizc.Rows(k).Cells(i).Value = valor
                    Next
                Next
            Next
        Else
            MsgBox("la matrz no es cuadrada")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
    End Sub
End Class