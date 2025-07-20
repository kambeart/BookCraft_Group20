Imports System.IO

Public Class Form2

    Private pfpImagePath As String = "" ' Class-level variable
    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint



    End Sub

    Private Sub LinkProfile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
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

End Class