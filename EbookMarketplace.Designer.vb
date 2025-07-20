<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EbookMarketplace
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EbookMarketplace))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnEbook = New System.Windows.Forms.Button()
        Me.btnMarket = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.flpBooks = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 124)
        Me.Panel1.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(238, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(822, 60)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnProfile.BackgroundImage = Global.BookCraft_Group20.My.Resources.Resources.usericon
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
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1150, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(116, 92)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(143, 125)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'flpBooks
        '
        Me.flpBooks.AutoScroll = True
        Me.flpBooks.AutoScrollMargin = New System.Drawing.Size(2, 2)
        Me.flpBooks.Location = New System.Drawing.Point(95, 133)
        Me.flpBooks.Name = "flpBooks"
        Me.flpBooks.Size = New System.Drawing.Size(1159, 455)
        Me.flpBooks.TabIndex = 41
        '
        'EbookMarketplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.flpBooks)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EbookMarketplace"
        Me.Text = "EbookMarketplace"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnMarket As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents btnEbook As Button
    Friend WithEvents flpBooks As FlowLayoutPanel
End Class
