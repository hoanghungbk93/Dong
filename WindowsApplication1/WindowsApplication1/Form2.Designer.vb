<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class history_form
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
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.history_chart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.history_file_tb = New System.Windows.Forms.TextBox()
        Me.browse_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.model_cbb = New System.Windows.Forms.ComboBox()
        CType(Me.history_chart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'history_chart
        '
        ChartArea4.CursorX.IsUserEnabled = True
        ChartArea4.CursorX.IsUserSelectionEnabled = True
        ChartArea4.Name = "ChartArea1"
        Me.history_chart.ChartAreas.Add(ChartArea4)
        Legend4.Name = "Legend1"
        Me.history_chart.Legends.Add(Legend4)
        Me.history_chart.Location = New System.Drawing.Point(35, 102)
        Me.history_chart.Name = "history_chart"
        Series4.ChartArea = "ChartArea1"
        Series4.Legend = "Legend1"
        Series4.Name = "Series1"
        Me.history_chart.Series.Add(Series4)
        Me.history_chart.Size = New System.Drawing.Size(860, 378)
        Me.history_chart.TabIndex = 0
        Me.history_chart.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Choose history file"
        Me.Label1.Visible = False
        '
        'history_file_tb
        '
        Me.history_file_tb.Location = New System.Drawing.Point(167, 48)
        Me.history_file_tb.Name = "history_file_tb"
        Me.history_file_tb.Size = New System.Drawing.Size(414, 20)
        Me.history_file_tb.TabIndex = 2
        Me.history_file_tb.Visible = False
        '
        'browse_btn
        '
        Me.browse_btn.Location = New System.Drawing.Point(613, 45)
        Me.browse_btn.Name = "browse_btn"
        Me.browse_btn.Size = New System.Drawing.Size(75, 23)
        Me.browse_btn.TabIndex = 3
        Me.browse_btn.Text = "Browse"
        Me.browse_btn.UseVisualStyleBackColor = True
        Me.browse_btn.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Choose history file"
        '
        'model_cbb
        '
        Me.model_cbb.FormattingEnabled = True
        Me.model_cbb.Location = New System.Drawing.Point(167, 12)
        Me.model_cbb.Name = "model_cbb"
        Me.model_cbb.Size = New System.Drawing.Size(414, 21)
        Me.model_cbb.TabIndex = 5
        '
        'history_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 573)
        Me.Controls.Add(Me.model_cbb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.browse_btn)
        Me.Controls.Add(Me.history_file_tb)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.history_chart)
        Me.Name = "history_form"
        Me.Text = "History"
        CType(Me.history_chart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents history_chart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents history_file_tb As System.Windows.Forms.TextBox
    Friend WithEvents browse_btn As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents model_cbb As System.Windows.Forms.ComboBox
End Class
