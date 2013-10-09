Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click


        Dim CurYear As Integer
        Dim CurPop As Double

        CurYear = 2012
        CurPop = 7000

        Do While (CurPop > 6)
            CurYear = CurYear - 50
            CurPop = CurPop / 2
        Loop

        MessageBox.Show("The year is " & CurYear, "Error")

    End Sub
End Class


