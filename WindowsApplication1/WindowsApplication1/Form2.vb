Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Public Class history_form
    Private strFileName As String
    Public folderName As String
    Public conboboxItems() As String
    Private Sub history_file_tb_Click(sender As Object, e As EventArgs) Handles browse_btn.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            history_file_tb.Text = strFileName
            Dim quoteArray As String() = File.ReadAllLines(strFileName)
            history_chart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
            history_chart.Series(0).XValueType = ChartValueType.Int32
            history_chart.ChartAreas(0).AxisX.ScaleView.Zoomable = True
            history_chart.ChartAreas(0).AxisX.ScaleView.SizeType = DateTimeIntervalType.Number
            history_chart.ChartAreas(0).AxisX.ScaleView.SmallScrollSize = 100
            Dim i As Integer = 0
            For Each value As String In quoteArray
                Dim temp() As String = value.Split(",")
                history_chart.Series(0).Points.AddXY(i, temp(1))
                history_chart.ChartAreas(0).AxisX.CustomLabels.Add(i - 1, i + 1, temp(0))
                i = i + 1
            Next
        End If
    End Sub

    Private Sub model_cbb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles model_cbb.SelectedIndexChanged
        history_chart.Series(0).Points.Clear()
        Dim quoteArray As String() = File.ReadAllLines(model_cbb.Text)
        history_chart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
        history_chart.Series(0).XValueType = ChartValueType.Int32
        history_chart.ChartAreas(0).AxisX.ScaleView.Zoomable = True
        history_chart.ChartAreas(0).AxisX.ScaleView.SizeType = DateTimeIntervalType.Number
        history_chart.ChartAreas(0).AxisX.ScaleView.SmallScrollSize = 100
        Dim i As Integer = 0
        For Each value As String In quoteArray
            Dim temp() As String = value.Split(",")
            history_chart.Series(0).Points.AddXY(i, temp(1))
            history_chart.ChartAreas(0).AxisX.CustomLabels.Add(i - 1, i + 1, temp(0))
            i = i + 1
        Next
    End Sub

    Private Sub history_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        model_cbb.Items.AddRange(main_form.fileList)
    End Sub
End Class