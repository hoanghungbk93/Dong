<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.min_tb = New System.Windows.Forms.TextBox()
        Me.models_cbb = New System.Windows.Forms.ComboBox()
        Me.computers_cbb = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.max_tb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.avg_tb = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.upper_tb = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lower_tb = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cpk_tb = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.step_cbb = New System.Windows.Forms.ComboBox()
        Me.ng_lb = New System.Windows.Forms.Label()
        Me.ng_tb = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ok_tb = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.total_tb = New System.Windows.Forms.TextBox()
        Me.cpk_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cpk_tm = New System.Windows.Forms.Timer(Me.components)
        Me.Label10 = New System.Windows.Forms.Label()
        Me.fileName_tb = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.export_tb = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        CType(Me.cpk_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select Computer"
        '
        'min_tb
        '
        Me.min_tb.Location = New System.Drawing.Point(160, 10)
        Me.min_tb.Name = "min_tb"
        Me.min_tb.Size = New System.Drawing.Size(165, 20)
        Me.min_tb.TabIndex = 1
        '
        'models_cbb
        '
        Me.models_cbb.Enabled = False
        Me.models_cbb.FormattingEnabled = True
        Me.models_cbb.Location = New System.Drawing.Point(161, 125)
        Me.models_cbb.Name = "models_cbb"
        Me.models_cbb.Size = New System.Drawing.Size(491, 21)
        Me.models_cbb.TabIndex = 2
        '
        'computers_cbb
        '
        Me.computers_cbb.FormattingEnabled = True
        Me.computers_cbb.Location = New System.Drawing.Point(160, 96)
        Me.computers_cbb.Name = "computers_cbb"
        Me.computers_cbb.Size = New System.Drawing.Size(165, 21)
        Me.computers_cbb.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 127)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Select Model"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Min"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Max"
        '
        'max_tb
        '
        Me.max_tb.Location = New System.Drawing.Point(160, 36)
        Me.max_tb.Name = "max_tb"
        Me.max_tb.Size = New System.Drawing.Size(165, 20)
        Me.max_tb.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Avg"
        '
        'avg_tb
        '
        Me.avg_tb.Location = New System.Drawing.Point(160, 62)
        Me.avg_tb.Name = "avg_tb"
        Me.avg_tb.Size = New System.Drawing.Size(165, 20)
        Me.avg_tb.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(384, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Upper"
        '
        'upper_tb
        '
        Me.upper_tb.Location = New System.Drawing.Point(487, 13)
        Me.upper_tb.Name = "upper_tb"
        Me.upper_tb.Size = New System.Drawing.Size(165, 20)
        Me.upper_tb.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(384, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Lower"
        '
        'lower_tb
        '
        Me.lower_tb.Location = New System.Drawing.Point(487, 39)
        Me.lower_tb.Name = "lower_tb"
        Me.lower_tb.Size = New System.Drawing.Size(165, 20)
        Me.lower_tb.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(384, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Cpk"
        '
        'cpk_tb
        '
        Me.cpk_tb.Location = New System.Drawing.Point(487, 65)
        Me.cpk_tb.Name = "cpk_tb"
        Me.cpk_tb.Size = New System.Drawing.Size(165, 20)
        Me.cpk_tb.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(683, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Step"
        '
        'step_cbb
        '
        Me.step_cbb.Enabled = False
        Me.step_cbb.FormattingEnabled = True
        Me.step_cbb.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.step_cbb.Location = New System.Drawing.Point(735, 33)
        Me.step_cbb.Name = "step_cbb"
        Me.step_cbb.Size = New System.Drawing.Size(100, 21)
        Me.step_cbb.TabIndex = 16
        '
        'ng_lb
        '
        Me.ng_lb.AutoSize = True
        Me.ng_lb.Location = New System.Drawing.Point(683, 127)
        Me.ng_lb.Name = "ng_lb"
        Me.ng_lb.Size = New System.Drawing.Size(23, 13)
        Me.ng_lb.TabIndex = 23
        Me.ng_lb.Text = "NG"
        '
        'ng_tb
        '
        Me.ng_tb.Location = New System.Drawing.Point(735, 121)
        Me.ng_tb.Name = "ng_tb"
        Me.ng_tb.Size = New System.Drawing.Size(100, 20)
        Me.ng_tb.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(683, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(22, 13)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "OK"
        '
        'ok_tb
        '
        Me.ok_tb.Location = New System.Drawing.Point(735, 95)
        Me.ok_tb.Name = "ok_tb"
        Me.ok_tb.Size = New System.Drawing.Size(100, 20)
        Me.ok_tb.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(683, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Total"
        '
        'total_tb
        '
        Me.total_tb.Location = New System.Drawing.Point(735, 69)
        Me.total_tb.Name = "total_tb"
        Me.total_tb.Size = New System.Drawing.Size(100, 20)
        Me.total_tb.TabIndex = 18
        '
        'cpk_chart
        '
        Me.cpk_chart.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea3.CursorX.IsUserEnabled = True
        ChartArea3.CursorX.IsUserSelectionEnabled = True
        ChartArea3.Name = "ChartArea1"
        Me.cpk_chart.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.cpk_chart.Legends.Add(Legend3)
        Me.cpk_chart.Location = New System.Drawing.Point(21, 204)
        Me.cpk_chart.Name = "cpk_chart"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Me.cpk_chart.Series.Add(Series3)
        Me.cpk_chart.Size = New System.Drawing.Size(912, 326)
        Me.cpk_chart.TabIndex = 24
        Me.cpk_chart.Text = "Chart1"
        '
        'cpk_tm
        '
        Me.cpk_tm.Interval = 60000
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(33, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Select File"
        Me.Label10.Visible = False
        '
        'fileName_tb
        '
        Me.fileName_tb.Location = New System.Drawing.Point(160, 152)
        Me.fileName_tb.Name = "fileName_tb"
        Me.fileName_tb.Size = New System.Drawing.Size(398, 20)
        Me.fileName_tb.TabIndex = 26
        Me.fileName_tb.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(577, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(735, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 23)
        Me.Button2.TabIndex = 28
        Me.Button2.Text = "History"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(577, 175)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'export_tb
        '
        Me.export_tb.Location = New System.Drawing.Point(160, 177)
        Me.export_tb.Name = "export_tb"
        Me.export_tb.Size = New System.Drawing.Size(398, 20)
        Me.export_tb.TabIndex = 30
        Me.export_tb.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(33, 184)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 29
        Me.Label13.Text = "Export To"
        Me.Label13.Visible = False
        '
        'main_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 551)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.export_tb)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fileName_tb)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cpk_chart)
        Me.Controls.Add(Me.ng_lb)
        Me.Controls.Add(Me.ng_tb)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ok_tb)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.total_tb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.step_cbb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cpk_tb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lower_tb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.upper_tb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.avg_tb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.max_tb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.computers_cbb)
        Me.Controls.Add(Me.models_cbb)
        Me.Controls.Add(Me.min_tb)
        Me.Controls.Add(Me.Label1)
        Me.Name = "main_form"
        Me.Text = "Cpk View"
        CType(Me.cpk_chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents min_tb As System.Windows.Forms.TextBox
    Friend WithEvents models_cbb As System.Windows.Forms.ComboBox
    Friend WithEvents computers_cbb As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents max_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents avg_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents upper_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lower_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cpk_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents step_cbb As System.Windows.Forms.ComboBox
    Friend WithEvents ng_lb As System.Windows.Forms.Label
    Friend WithEvents ng_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ok_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents total_tb As System.Windows.Forms.TextBox
    Friend WithEvents cpk_chart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cpk_tm As System.Windows.Forms.Timer
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents fileName_tb As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents export_tb As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog

End Class
