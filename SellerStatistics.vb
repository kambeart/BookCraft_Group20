Imports System.Data.OleDb
Imports System.Globalization
Imports System.Windows.Forms.DataVisualization.Charting

Public Class SellerStatistics

    Private currentSellerID As Integer = 1 ' Initialize with default seller ID or get from session
    Private Const ConnectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yiwen\source\repos\BookCraft_Group20\bin\Debug\BookCraft_Group20_Database.accdb"

    Private Sub SellerStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupChart()
        LoadSalesData()
    End Sub

    Public Function GetMonthlySales(sellerID As Integer) As DataTable
        Dim query = "SELECT SaleMonth, TotalSales FROM qryMonthlySales WHERE SellerID = ?"

        Using conn As New OleDbConnection(ConnectionString),
              cmd As New OleDbCommand(query, conn)

            cmd.Parameters.AddWithValue("?", sellerID)
            conn.Open()

            Dim dt As New DataTable
            dt.Load(cmd.ExecuteReader())
            Return dt
        End Using
    End Function

    Private Sub SetupChart()
        With chartSales
            .Series.Clear()
            Dim series1 As New Series("Sales")
            series1.ChartType = SeriesChartType.Column
            series1.Color = Color.FromArgb(78, 121, 167) ' Professional blue
            series1.IsValueShownAsLabel = True
            series1.LabelFormat = "RM #,##0"
            .Series.Add(series1)

            ' Format axes
            .ChartAreas(0).AxisX.Title = "Month"
            .ChartAreas(0).AxisY.Title = "Sales (RM)"
            .ChartAreas(0).AxisY.LabelStyle.Format = "RM #,##0"
            .ChartAreas(0).AxisX.Interval = 1
        End With
    End Sub

    Private Sub LoadSalesData()
        Dim dt = GetMonthlySales(currentSellerID)
        chartSales.Series(0).Points.Clear()

        For Each row As DataRow In dt.Rows
            Dim monthNumber = CInt(row("SaleMonth"))
            Dim monthName As String = DateTimeFormatInfo.CurrentInfo.GetMonthName(monthNumber)
            Dim sales = CDec(row("TotalSales"))

            Dim point = chartSales.Series(0).Points.Add(sales)
            point.AxisLabel = monthName
            point.Label = sales.ToString("RM #,##0")
            point.Color = If(sales > 0, Color.SteelBlue, Color.LightGray)
        Next

        If dt.Rows.Count = 0 Then
            chartSales.Titles.Add("No sales data available")
            chartSales.Titles(0).Font = New Font("Arial", 12, FontStyle.Italic)
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        LoadSalesData()
    End Sub

End Class