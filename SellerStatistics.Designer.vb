<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SellerStatistics
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.chartSales = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chartSales
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartSales.ChartAreas.Add(ChartArea1)
        Me.chartSales.Dock = System.Windows.Forms.DockStyle.Right
        Legend1.Name = "Legend1"
        Me.chartSales.Legends.Add(Legend1)
        Me.chartSales.Location = New System.Drawing.Point(687, 0)
        Me.chartSales.Name = "chartSales"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chartSales.Series.Add(Series1)
        Me.chartSales.Size = New System.Drawing.Size(661, 721)
        Me.chartSales.TabIndex = 0
        Me.chartSales.Text = "Chart1"
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.Sienna
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRefresh.Location = New System.Drawing.Point(569, 12)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(112, 47)
        Me.btnRefresh.TabIndex = 1
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'SellerStatistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.chartSales)
        Me.Name = "SellerStatistics"
        Me.Text = "SellerStatistics"
        CType(Me.chartSales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents chartSales As DataVisualization.Charting.Chart
    Friend WithEvents btnRefresh As Button
End Class
