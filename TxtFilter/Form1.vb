Public Class frmFilter
    Dim txtMain() As String = IO.File.ReadAllLines("main.txt")
    Dim txtFilter() As String = IO.File.ReadAllLines("filter.txt")
    Dim Count As Integer

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Calc()
    End Sub

    Public Sub Calc()
        For i = -1 To Count - 1
            lstFilter.SetSelected(i + 1, True)
            Dim query As String = lstFilter.SelectedItem.ToString
            Dim contains As String = lstMain.Items.Contains(query)
            If contains Then
                lstMain.Items.Remove(query)
            End If
        Next
    End Sub

    Private Sub frmFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim filterLength As Integer = txtFilter.Length
        Dim mainLength As Integer = txtMain.Length
        For i = 0 To filterLength - 1
            lstFilter.Items.Add(txtFilter(i))
        Next
        For i = 0 To mainLength - 1
            lstMain.Items.Add(txtMain(i))
        Next
        Count = lstFilter.Items.Count - 1

    End Sub
End Class
