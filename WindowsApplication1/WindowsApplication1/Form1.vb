Imports System.IO
Imports System.Windows.Forms
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Text

Public Class main_form
    Private selectedColumn As Integer
    Dim cpk_data As New List(Of Single)
    Private i As Single
    Private strFileName As String
    Private exportFolder As String
    Private computerName As String
    Public fileList() As String
    Public units() As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine("Form Load Event")
        Dim unitPath As String = "units.txt"
        Dim computerPath As String = "computers.txt"
        ' Read units.
        If File.Exists(unitPath) = True Then
            units = File.ReadAllLines(unitPath)
            Console.WriteLine(units(0))
        End If
        ' Read computers.
        If File.Exists(computerPath) = True Then
            Dim readText() As String = File.ReadAllLines(computerPath)
            computers_cbb.Items.AddRange(readText)
        End If
        
        cpk_chart.Series(0).ChartType = DataVisualization.Charting.SeriesChartType.Line
        cpk_chart.Series(0).XValueType = ChartValueType.Int32
        cpk_chart.ChartAreas(0).AxisX.ScaleView.Zoomable = True
        cpk_chart.ChartAreas(0).AxisX.ScaleView.SizeType = DateTimeIntervalType.Number
        cpk_chart.ChartAreas(0).AxisX.ScaleView.SmallScrollSize = 100
    End Sub
    Private Function isUnit(unit As String)
        Dim ret As Boolean = False
        For Each _unit As String In units
            If unit = _unit Then
                ret = True
                Exit For
            End If
        Next
        Return ret
    End Function
    Private Sub getSteps()
        Dim testFile As System.IO.FileInfo
        testFile = My.Computer.FileSystem.GetFileInfo(strFileName)
        Dim folderPath As String = testFile.DirectoryName
        Dim fileName As String = testFile.Name
        Dim fileNameCopy = folderPath + "\" + fileName.Split(".csv")(0) + "_copy.csv"
        My.Computer.FileSystem.CopyFile(strFileName, fileNameCopy, overwrite:=True)
        Try
            Dim fileContents() As String = File.ReadAllLines(fileNameCopy)
            If fileContents.Length > 8 Then
                Dim steps() As String = fileContents(7).Split(",")
                Dim _step As Integer = 0
                For Each temp As String In steps
                    If isUnit(temp) = True Then
                        step_cbb.Items.Add(_step.ToString())
                    End If
                    _step = _step + 1
                Next
            End If
        Catch e As IOException
            MessageBox.Show("File not found")
        End Try
    End Sub
    Private Sub models_cbb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles models_cbb.SelectedIndexChanged
        step_cbb.Enabled = True
        step_cbb.Items.Clear()
        step_cbb.Text = ""
        strFileName = models_cbb.Text
        getSteps()
        cpk_tm.Stop()
        cpk_chart.Series(0).Points.Clear()
    End Sub
    Private Sub resetValue()
        avg_tb.Text = ""
        min_tb.Text = ""
        max_tb.Text = ""
        upper_tb.Text = ""
        lower_tb.Text = ""
        cpk_tb.Text = ""
        total_tb.Text = ""
        ng_tb.Text = ""
        ok_tb.Text = ""
        refresh_btn.Enabled = False
    End Sub
    Private Sub computers_cbb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles computers_cbb.SelectedIndexChanged
        models_cbb.Enabled = True
        computerName = computers_cbb.Text
        step_cbb.Items.Clear()
        step_cbb.Enabled = False
        step_cbb.Text = ""
        models_cbb.Items.Clear()
        models_cbb.Text = ""
        cpk_tm.Stop()
        cpk_chart.Series(0).Points.Clear()
        Try
            fileList = IO.Directory.GetFiles(computers_cbb.Text, "*.csv")
            exportFolder = computers_cbb.Text
            models_cbb.Items.AddRange(fileList)
        Catch ex As IOException
            MessageBox.Show("file not found")
        End Try
    End Sub
    Private Sub calculate()
        Dim okCount As Integer = 0
        Dim counter As Integer = 0
        Dim min As Single = 999999
        Dim max As Single = -999999
        Dim sum As Single = 0
        Dim squareSum = 0
        Dim avg As Single = 0
        Dim upperLm As Single = 0
        Dim lowerLm As Single = 0
        Dim testFile As System.IO.FileInfo
        testFile = My.Computer.FileSystem.GetFileInfo(strFileName)
        Dim folderPath As String = testFile.DirectoryName
        Dim fileName As String = testFile.Name
        Dim fileNameCopy = folderPath + "\" + fileName.Split(".csv")(0) + "_copy.csv"
        My.Computer.FileSystem.CopyFile(strFileName, fileNameCopy, overwrite:=True)
        Try
            Dim quoteArray As String() = File.ReadAllLines(fileNameCopy)
            For Each line As String In quoteArray
                Dim values() As String = line.Split(",")
                If counter = 0 Then
                    total_tb.Text = values(0)
                    ok_tb.Text = values(1)
                    ng_tb.Text = values(2)
                ElseIf counter = 5 Then
                    upper_tb.Text = values(selectedColumn)
                    upperLm = values(selectedColumn)
                ElseIf counter = 6 Then
                    lower_tb.Text = values(selectedColumn)
                    lowerLm = values(selectedColumn)
                ElseIf counter >= 8 And values.Length >= selectedColumn Then
                    Dim value As Single
                    Dim isNumerical As Boolean = Single.TryParse(values(selectedColumn), value)
                    If isNumerical = True And value <= upperLm And value >= lowerLm Then
                        If value > max Then
                            max = value
                        End If
                        If (value < min) Then
                            min = value
                        End If
                        sum += value
                        squareSum += value ^ 2
                        okCount = okCount + 1
                    End If
                End If
                counter = counter + 1
            Next
            avg = sum / okCount
            avg_tb.Text = avg.ToString()
            min_tb.Text = min.ToString()
            max_tb.Text = max.ToString()
            Dim S, V, Sigma, k, Cpk As Single
            cpk_data.Add(avg)
            S = squareSum - sum ^ 2 / okCount
            V = S / (okCount - 1)
            Sigma = System.Math.Sqrt(V)
            k = System.Math.Abs((upperLm + lowerLm) / 2 - avg) / System.Math.Abs((upperLm - lowerLm) / 2)
            Cpk = ((1 - k) * (upperLm - lowerLm) / (6 * Sigma))
            cpk_tb.Text = Cpk.ToString()
            cpk_chart.Series(0).Points.AddXY(i, Cpk)
            cpk_chart.ChartAreas(0).AxisX.CustomLabels.Add(i - 1, i + 1, Now.ToString("HH:mm:ss"))
            i = i + 1
            Dim csvFilePath As String = exportFolder + "\cpk_" + Date.Now().ToString("dd_MM_yyyy") + "_" + selectedColumn.ToString() + ".csv" 'Path to create or existing file
            Dim allRecord As New List(Of String)
            Try
                Dim str() As String = File.ReadAllLines(csvFilePath)
                allRecord.AddRange(str)
            Catch ex As Exception
                'MessageBox.Show("new file")
            End Try
            allRecord.Add(Now.ToString("HH:mm:ss") + "," + Cpk.ToString())
            System.IO.File.WriteAllLines(csvFilePath, allRecord.ToArray)
        Catch e As IOException
            MessageBox.Show("File is opening, please close file and choose model and step again")
        End Try
    End Sub
    Private Sub step_cbb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles step_cbb.SelectedIndexChanged
        cpk_chart.Series(0).Points.Clear()
        selectedColumn = Integer.Parse(step_cbb.Text)
        calculate()
        cpk_tm.Start()
        refresh_btn.Enabled = True
    End Sub

    Private Sub cpk_tm_Tick(sender As Object, e As EventArgs) Handles cpk_tm.Tick

        Console.WriteLine("hihi")
        calculate()

        'Console.WriteLine(i)
        'For Each j As Single In cpk_data
        '    Console.WriteLine(j)
        'Next

        'cpk_chart.ChartAreas(0).AxisX.CustomLabels.Add(i - 1, i + 1, Now.ToString("HH:mm:ss"))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\"
        fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            fileName_tb.Text = strFileName
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        history_form.folderName = exportFolder
        history_form.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            export_tb.Text = FolderBrowserDialog1.SelectedPath
            exportFolder = FolderBrowserDialog1.SelectedPath
            step_cbb.Enabled = True
        End If
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        calculate()
    End Sub
End Class
