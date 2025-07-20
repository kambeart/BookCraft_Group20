Public Class ReadEbook
    Private CurrentProductID As Integer = 1 ' Default eBook ID
    Private CurrentPage As Integer = 1
    Private TotalPages As Integer = 0
    Private Const PageLength As Integer = 500 ' Characters per page
    Private ReadOnly ProductID As Integer ' Store the selected book ID

    ' Constructor that accepts ProductID
    Public Sub New(bookID As Integer)
        InitializeComponent()
        ProductID = bookID
        LoadEBook() ' Load the book content
    End Sub

    Private Sub LoadEBook()
        ' Your code to load the eBook based on ProductID
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        UserLibrary.Show()
    End Sub
End Class