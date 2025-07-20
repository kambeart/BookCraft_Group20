<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserProfile
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnStatistic = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnCatelogue = New System.Windows.Forms.Button()
        Me.btnLibrary = New System.Windows.Forms.Button()
        Me.btnProfile2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnEbook = New System.Windows.Forms.Button()
        Me.btnMarket = New System.Windows.Forms.Button()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.btnStatistic)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btnCatelogue)
        Me.Panel1.Controls.Add(Me.btnLibrary)
        Me.Panel1.Controls.Add(Me.btnProfile2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(0, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 720)
        Me.Panel1.TabIndex = 0
        '
        'btnStatistic
        '
        Me.btnStatistic.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnStatistic.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnStatistic.FlatAppearance.BorderSize = 0
        Me.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStatistic.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistic.ForeColor = System.Drawing.Color.White
        Me.btnStatistic.Location = New System.Drawing.Point(0, 346)
        Me.btnStatistic.Name = "btnStatistic"
        Me.btnStatistic.Size = New System.Drawing.Size(239, 65)
        Me.btnStatistic.TabIndex = 17
        Me.btnStatistic.Text = "My Statistic"
        Me.btnStatistic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStatistic.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 54)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Profile"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 21)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 54)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "User "
        '
        'btnCatelogue
        '
        Me.btnCatelogue.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnCatelogue.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCatelogue.FlatAppearance.BorderSize = 0
        Me.btnCatelogue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCatelogue.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCatelogue.ForeColor = System.Drawing.Color.White
        Me.btnCatelogue.Location = New System.Drawing.Point(0, 281)
        Me.btnCatelogue.Name = "btnCatelogue"
        Me.btnCatelogue.Size = New System.Drawing.Size(239, 65)
        Me.btnCatelogue.TabIndex = 14
        Me.btnCatelogue.Text = "My Catalogue"
        Me.btnCatelogue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCatelogue.UseVisualStyleBackColor = False
        '
        'btnLibrary
        '
        Me.btnLibrary.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnLibrary.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnLibrary.FlatAppearance.BorderSize = 0
        Me.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLibrary.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLibrary.ForeColor = System.Drawing.Color.White
        Me.btnLibrary.Location = New System.Drawing.Point(0, 216)
        Me.btnLibrary.Name = "btnLibrary"
        Me.btnLibrary.Size = New System.Drawing.Size(239, 65)
        Me.btnLibrary.TabIndex = 13
        Me.btnLibrary.Text = "My Library"
        Me.btnLibrary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLibrary.UseVisualStyleBackColor = False
        '
        'btnProfile2
        '
        Me.btnProfile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(132, Byte), Integer), CType(CType(103, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.btnProfile2.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnProfile2.FlatAppearance.BorderSize = 0
        Me.btnProfile2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile2.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProfile2.ForeColor = System.Drawing.Color.White
        Me.btnProfile2.Location = New System.Drawing.Point(0, 151)
        Me.btnProfile2.Name = "btnProfile2"
        Me.btnProfile2.Size = New System.Drawing.Size(239, 65)
        Me.btnProfile2.TabIndex = 12
        Me.btnProfile2.Text = "Profile"
        Me.btnProfile2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProfile2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(239, 151)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Sienna
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnProfile, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnEbook, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnMarket, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 612)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 106.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1348, 109)
        Me.TableLayoutPanel1.TabIndex = 40
        '
        'btnProfile
        '
        Me.btnProfile.BackgroundImage = Global.BookCraft_Group20.My.Resources.Resources.usericon1
        Me.btnProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnProfile.FlatAppearance.BorderSize = 0
        Me.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProfile.Location = New System.Drawing.Point(902, 6)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(439, 97)
        Me.btnProfile.TabIndex = 42
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnEbook
        '
        Me.btnEbook.BackgroundImage = Global.BookCraft_Group20.My.Resources.Resources.ebookicon1
        Me.btnEbook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnEbook.FlatAppearance.BorderSize = 0
        Me.btnEbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEbook.Location = New System.Drawing.Point(454, 6)
        Me.btnEbook.Name = "btnEbook"
        Me.btnEbook.Size = New System.Drawing.Size(439, 97)
        Me.btnEbook.TabIndex = 41
        Me.btnEbook.UseVisualStyleBackColor = True
        '
        'btnMarket
        '
        Me.btnMarket.BackgroundImage = Global.BookCraft_Group20.My.Resources.Resources.bookicon
        Me.btnMarket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnMarket.FlatAppearance.BorderSize = 0
        Me.btnMarket.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMarket.Location = New System.Drawing.Point(6, 6)
        Me.btnMarket.Name = "btnMarket"
        Me.btnMarket.Size = New System.Drawing.Size(439, 97)
        Me.btnMarket.TabIndex = 40
        Me.btnMarket.UseVisualStyleBackColor = True
        '
        'MainPanel
        '
        Me.MainPanel.Location = New System.Drawing.Point(245, 1)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1094, 611)
        Me.MainPanel.TabIndex = 18
        '
        'UserProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MainPanel)
        Me.Name = "UserProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserProfile"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCatelogue As Button
    Friend WithEvents btnLibrary As Button
    Friend WithEvents btnProfile2 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnMarket As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnEbook As Button
    Friend WithEvents btnStatistic As Button
    Friend WithEvents MainPanel As Panel
End Class
