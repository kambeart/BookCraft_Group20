Imports System.Data.OleDb
Imports System.IO

Public Class UploadEbook
    Private chapterFilePath As String = ""
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picCover.Click

    End Sub

    Private Sub UploadEbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize controls
        txtChapter.Enabled = False
        cboEbook.Visible = False
        picCover.SizeMode = PictureBoxSizeMode.Zoom ' For better image display

        ' Load seller's existing ebooks
        LoadSellerEbooks()
    End Sub

    Private Sub LoadSellerEbooks()
        Dim query = "SELECT ProductID, Title FROM ProductInfo WHERE SellerID = @SellerID AND IsEbook = True"
        Dim params As New List(Of OleDbParameter) From {
            New OleDbParameter("@SellerID", 1) ' Replace with actual seller ID
        }

        Dim dt = DatabaseHelper.ExecuteQuery(query, params)
        cboEbook.DataSource = dt
        cboEbook.DisplayMember = "Title"
        cboEbook.ValueMember = "ProductID"
    End Sub

    Private Sub rbNewEbook_CheckedChanged(sender As Object, e As EventArgs) Handles rbNewEbook.CheckedChanged
        txtChapter.Enabled = False
        cboEbook.Visible = False
        linkUploadCover.Visible = True
    End Sub

    Private Sub rbNewChap_CheckedChanged(sender As Object, e As EventArgs) Handles rbNewChap.CheckedChanged
        txtChapter.Enabled = True
        cboEbook.Visible = True
        linkUploadCover.Visible = False

        ' Auto-load cover of selected ebook
        If cboEbook.SelectedValue IsNot Nothing Then
            LoadEbookCover(CInt(cboEbook.SelectedValue))
        End If
    End Sub

    Private Sub LoadEbookCover(ebookID As Integer)
        Dim query = "SELECT CoverImagePath FROM ProductInfo WHERE ProductID = @EbookID"
        Dim params As New List(Of OleDbParameter) From {
            New OleDbParameter("@EbookID", ebookID)
        }

        Dim dt = DatabaseHelper.ExecuteQuery(query, params)
        If dt.Rows.Count > 0 AndAlso Not IsDBNull(dt.Rows(0)("CoverImagePath")) Then
            picCover.Image = Image.FromFile(dt.Rows(0)("CoverImagePath").ToString())
        End If
    End Sub

    Private Sub linkUploadCover_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkUploadCover.LinkClicked
        Using ofd As New OpenFileDialog
            ofd.Filter = "Image Files|*.jpg;*.png;*.bmp"
            If ofd.ShowDialog() = DialogResult.OK Then
                picCover.Image = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    Private Sub btnUploadChap_Click(sender As Object, e As EventArgs) Handles btnUploadChap.Click
        Using ofd As New OpenFileDialog
            ofd.Filter = "Document Files|*.pdf;*.docx"
            If ofd.ShowDialog() = DialogResult.OK Then
                ' Store the file path temporarily
                ' We'll process it during publish
                chapterFilePath = ofd.FileName
                MessageBox.Show("Chapter file selected!")
            End If
        End Using
    End Sub

    Private Sub btnPublish_Click(sender As Object, e As EventArgs) Handles btnPublish.Click
        If rbNewEbook.Checked Then
            If String.IsNullOrEmpty(txtTitle.Text) OrElse picCover.Image Is Nothing Then
                MsgBox("Please fill all required fields.", MsgBoxStyle.Exclamation, "Incomplete Input")
                Return
            End If
            UploadNewEbook()
        Else
            If cboEbook.SelectedIndex = -1 OrElse String.IsNullOrEmpty(txtChapter.Text) OrElse String.IsNullOrEmpty(chapterFilePath) Then
                MsgBox("Please select an ebook, enter chapter number, and upload file!", MsgBoxStyle.Exclamation, "Incomplete Input")
                Return
            End If
            UploadNewChapter()
        End If
    End Sub

    Private Sub UploadNewEbook()
        ' Validate cover image
        If picCover.Image Is Nothing Then
            MessageBox.Show("Please select a cover image!")
            Return
        End If

        Try
            ' 1. Save cover image
            Dim coverPath = SaveFileToFolder(picCover.Image, "Covers", $"{Guid.NewGuid()}.jpg") ' Using GUID for unique filenames

            ' 2. Insert into ProductInfo
            Dim query = "INSERT INTO ProductInfo (Title, Description, SellerID, IsEbook, CoverImagePath) 
                    VALUES (@Title, @Desc, @SellerID, True, @CoverPath)"

            Dim params As New List(Of OleDbParameter) From {
            New OleDbParameter("@Title", txtTitle.Text),
            New OleDbParameter("@Desc", txtDesc.Text),
            New OleDbParameter("@SellerID", 1), ' Actual seller ID
            New OleDbParameter("@CoverPath", coverPath)
        }

            DatabaseHelper.ExecuteNonQuery(query, params)
            MessageBox.Show("New ebook published!")

        Catch ex As Exception
            MessageBox.Show($"Error saving ebook: {ex.Message}")
        End Try
    End Sub

    Private Sub UploadNewChapter()
        ' 1. Save chapter file
        Dim chapterPath = SaveFileToFolder(chapterFilePath, "Chapters", $"{cboEbook.SelectedValue}_{txtChapter.Text}.pdf")

        ' 2. Insert into EbookChapters
        Dim query = "INSERT INTO EbookChapters (EbookID, ChapterNumber, ChapterTitle, ContentPath, Description)
                VALUES (@EbookID, @ChapNum, @Title, @Path, @Desc)"

        Dim params As New List(Of OleDbParameter) From {
            New OleDbParameter("@EbookID", cboEbook.SelectedValue),
            New OleDbParameter("@ChapNum", CInt(txtChapter.Text)),
            New OleDbParameter("@Title", txtTitle.Text),
            New OleDbParameter("@Path", chapterPath),
            New OleDbParameter("@Desc", txtDesc.Text)
        }

        DatabaseHelper.ExecuteNonQuery(query, params)
        MessageBox.Show("New chapter added!")
    End Sub

    Private Function SaveFileToFolder(fileObject As Object, subFolder As String, fileName As String) As String
        Try
            Dim appPath = Application.StartupPath
            Dim fullPath = Path.Combine(appPath, subFolder)

            ' Create folder if doesn't exist
            If Not Directory.Exists(fullPath) Then
                Directory.CreateDirectory(fullPath)
            End If

            Dim destPath = Path.Combine(fullPath, fileName)

            ' Handle both images and files
            If TypeOf fileObject Is Image Then
                DirectCast(fileObject, Image).Save(destPath, Imaging.ImageFormat.Jpeg)
            ElseIf TypeOf fileObject Is String Then
                File.Copy(fileObject.ToString(), destPath, True)
            Else
                Throw New ArgumentException("Unsupported file type")
            End If

            Return destPath
        Catch ex As Exception
            MessageBox.Show($"Error saving file: {ex.Message}")
            Return ""
        End Try
    End Function

    Private Sub txtDesc_TextChanged(sender As Object, e As EventArgs) Handles txtDesc.TextChanged

    End Sub
End Class