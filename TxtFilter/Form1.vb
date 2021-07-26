Public Class frmFilter
    Dim txtMain() As String = IO.File.ReadAllLines("main.txt")
    Dim txtFilter() As String = IO.File.ReadAllLines("filter.txt")
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

    End Sub

    Private Sub frmFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstMain.DataSource = txtMain
        lstFilter.DataSource = txtFilter
        Dim Count As Integer = lstMain.Items.Count

        For i = 0 To Count - 1
            lstFilter.SetSelected(Count, True)
            Dim query As String = lstFilter.SelectedItem.ToString
            Dim contains As String = lstMain.Items.Contains(query)
            If Not contains = -1 Then
                lstMain.Items.Remove(query)
            End If
        Next
    End Sub
End Class
