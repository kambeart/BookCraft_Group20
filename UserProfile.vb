Imports System.Data.OleDb
Imports System.IO
Public Class UserProfile
    'Private pfpImagePath As String = "" ' Class-level variable




    'Private Sub LinkProfile_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
    '    Using ofd As New OpenFileDialog
    '        ofd.Filter = "Images|*.jpg;*.png;*.bmp"
    '        ofd.Title = "Select Profile Picture"

    '        If ofd.ShowDialog() = DialogResult.OK Then
    '            ' [1] Display in PictureBox
    '            picProfile.SizeMode = PictureBoxSizeMode.Zoom
    '            picProfile.Image = Image.FromFile(ofd.FileName)

    '            ' [2] Save to application folder
    '            Dim appPath = Application.StartupPath
    '            Dim pfpDir = Path.Combine(appPath, "ProfilePictures")
    '            Directory.CreateDirectory(pfpDir)

    '            Dim newFileName = $"pfp_{CurrentUserID}_{Guid.NewGuid()}{Path.GetExtension(ofd.FileName)}"
    '            pfpImagePath = Path.Combine(pfpDir, newFileName)
    '            File.Copy(ofd.FileName, pfpImagePath, True)
    '        End If
    '    End Using
    'End Sub

    Private Sub btnMarket_Click_1(sender As Object, e As EventArgs) Handles btnMarket.Click
        Me.Hide()
        MarketPlace.Show()
    End Sub

    Private Sub btnEbook_Click_1(sender As Object, e As EventArgs) Handles btnEbook.Click
        Me.Hide()
        EbookMarketplace.Show()
    End Sub


    Sub switchpanel(ByVal panel As Form)
        MainPanel.Controls.Clear()
        panel.TopLevel = False
        panel.FormBorderStyle = FormBorderStyle.None
        panel.Dock = DockStyle.Fill
        MainPanel.Controls.Add(panel)
        panel.Show()
    End Sub


    Private Sub btnProfile2_Click(sender As Object, e As EventArgs) Handles btnProfile2.Click
        switchpanel(Form2)
    End Sub

    Private Sub btnLibrary_Click(sender As Object, e As EventArgs) Handles btnLibrary.Click
        switchpanel(UserLibrary)
    End Sub

    Private Sub btnCatelogue_Click(sender As Object, e As EventArgs) Handles btnCatelogue.Click
        switchpanel(Sales_Catalogue)
    End Sub

    Private Sub btnStatistic_Click(sender As Object, e As EventArgs) Handles btnStatistic.Click

    End Sub

    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchpanel(Form2)
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class