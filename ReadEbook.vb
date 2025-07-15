Imports System.Data.OleDb

Public Class ReadEbook
    Private currentEbookID As Integer = 1 ' Set this from your library
    Private chapters As DataTable

    Private Sub frmChapterSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load book info and chapters
        LoadBookInfo()
        LoadChapters()
    End Sub

    Private Sub LoadBookInfo()
        Dim query = "SELECT Title, Author FROM ProductInfo WHERE ProductID = @EbookID"
        Dim dt = DatabaseHelper.ExecuteQuery(query, New List(Of OleDbParameter) From {
            New OleDbParameter("@EbookID", currentEbookID)
        })

        If dt.Rows.Count > 0 Then
            lblTitle.Text = dt.Rows(0)("Title").ToString()
            lblAuthor.Text = dt.Rows(0)("Author").ToString()
        End If
    End Sub

    Private Sub LoadChapters()
        Dim query = "SELECT ChapterID, ChapterNumber, ChapterTitle FROM EbookChapters WHERE EbookID = @EbookID ORDER BY ChapterNumber"
        chapters = DatabaseHelper.ExecuteQuery(query, New List(Of OleDbParameter) From {
            New OleDbParameter("@EbookID", currentEbookID)
        })

        lstChapters.DataSource = chapters
        lstChapters.DisplayMember = "ChapterTitle"
        lstChapters.ValueMember = "ChapterID"
    End Sub

    Private Sub btnMyLibrary_Click(sender As Object, e As EventArgs) Handles btnMyLibrary.Click
        Me.Hide()
        frmMyLibrary.Show() ' Your existing library form
    End Sub

    Private Sub btnReadChapter_Click(sender As Object, e As EventArgs) Handles btnReadChapter.Click
        If lstChapters.SelectedValue IsNot Nothing Then
            Dim readerForm As New frmEbookReader()
            readerForm.ChapterID = CInt(lstChapters.SelectedValue)
            readerForm.Show()
            Me.Hide()
        Else
            MessageBox.Show("Please select a chapter")
        End If
    End Sub
    Private Sub ReadEbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class