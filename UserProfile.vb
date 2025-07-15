Imports System.Data.OleDb
Imports System.IO
Public Class UserProfile
    Private pfpImagePath As String = "" ' Class-level variable


    Private Sub btnEbook_Click(sender As Object, e As EventArgs)
        Me.Hide()
        EbookMarketplace.Show()
    End Sub

    Private Sub btnMarket_Click(sender As Object, e As EventArgs)
        Me.Hide()
        MarketPlace.Show()
    End Sub



    Private Sub LinkProfile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkProfile.LinkClicked
        Using ofd As New OpenFileDialog
            ofd.Filter = "Images|*.jpg;*.png;*.bmp"
            ofd.Title = "Select Profile Picture"

            If ofd.ShowDialog() = DialogResult.OK Then
                ' [1] Display in PictureBox
                picProfile.SizeMode = PictureBoxSizeMode.Zoom
                picProfile.Image = Image.FromFile(ofd.FileName)

                ' [2] Save to application folder
                Dim appPath = Application.StartupPath
                Dim pfpDir = Path.Combine(appPath, "ProfilePictures")
                Directory.CreateDirectory(pfpDir)

                Dim newFileName = $"pfp_{CurrentUserID}_{Guid.NewGuid()}{Path.GetExtension(ofd.FileName)}"
                pfpImagePath = Path.Combine(pfpDir, newFileName)
                File.Copy(ofd.FileName, pfpImagePath, True)
            End If
        End Using
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles picProfile.Click

    End Sub
End Class