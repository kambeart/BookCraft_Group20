<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UploadEbook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UploadEbook))
        Me.picCover = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.linkUploadCover = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.txtChapter = New System.Windows.Forms.TextBox()
        Me.cboGenre = New System.Windows.Forms.ComboBox()
        Me.btnPublish = New System.Windows.Forms.Button()
        Me.btnUploadChap = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rbNewEbook = New System.Windows.Forms.RadioButton()
        Me.rbNewChap = New System.Windows.Forms.RadioButton()
        Me.cboEbook = New System.Windows.Forms.ComboBox()
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'picCover
        '
        Me.picCover.Location = New System.Drawing.Point(231, 48)
        Me.picCover.Name = "picCover"
        Me.picCover.Size = New System.Drawing.Size(228, 208)
        Me.picCover.TabIndex = 0
        Me.picCover.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(28, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 72)
        Me.Button2.TabIndex = 23
        Me.Button2.UseVisualStyleBackColor = True
        '
        'linkUploadCover
        '
        Me.linkUploadCover.AutoSize = True
        Me.linkUploadCover.Location = New System.Drawing.Point(299, 259)
        Me.linkUploadCover.Name = "linkUploadCover"
        Me.linkUploadCover.Size = New System.Drawing.Size(91, 16)
        Me.linkUploadCover.TabIndex = 24
        Me.linkUploadCover.TabStop = True
        Me.linkUploadCover.Text = "Upload Cover"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(194, 301)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 383)
        Me.Panel1.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(163, 271)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 40)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Chapter:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(155, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 40)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Genre(s):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 40)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Description:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(212, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Title:"
        '
        'txtTitle
        '
        Me.txtTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTitle.Location = New System.Drawing.Point(512, 313)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(626, 45)
        Me.txtTitle.TabIndex = 26
        '
        'txtDesc
        '
        Me.txtDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDesc.Location = New System.Drawing.Point(512, 364)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(626, 151)
        Me.txtDesc.TabIndex = 27
        '
        'txtChapter
        '
        Me.txtChapter.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChapter.Location = New System.Drawing.Point(512, 572)
        Me.txtChapter.Name = "txtChapter"
        Me.txtChapter.Size = New System.Drawing.Size(163, 45)
        Me.txtChapter.TabIndex = 29
        '
        'cboGenre
        '
        Me.cboGenre.Font = New System.Drawing.Font("Calibri", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGenre.FormattingEnabled = True
        Me.cboGenre.Items.AddRange(New Object() {"Crime", "Detective", "Romance", "Fantasy", "Sci-Fi", "Action", "Adventure", "Mystery", "Horror", "Comedy", "Literary prose", "Poetry", "Drama", "Historical", "Children", "Philosophical/Religious", "Graphic novel", "Textbook", "Report", "Other"})
        Me.cboGenre.Location = New System.Drawing.Point(512, 519)
        Me.cboGenre.Name = "cboGenre"
        Me.cboGenre.Size = New System.Drawing.Size(163, 48)
        Me.cboGenre.TabIndex = 30
        '
        'btnPublish
        '
        Me.btnPublish.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.btnPublish.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPublish.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPublish.Location = New System.Drawing.Point(512, 623)
        Me.btnPublish.Name = "btnPublish"
        Me.btnPublish.Size = New System.Drawing.Size(235, 61)
        Me.btnPublish.TabIndex = 31
        Me.btnPublish.Text = "Publish"
        Me.btnPublish.UseVisualStyleBackColor = False
        '
        'btnUploadChap
        '
        Me.btnUploadChap.BackColor = System.Drawing.Color.Sienna
        Me.btnUploadChap.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUploadChap.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUploadChap.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUploadChap.Location = New System.Drawing.Point(894, 519)
        Me.btnUploadChap.Name = "btnUploadChap"
        Me.btnUploadChap.Size = New System.Drawing.Size(244, 48)
        Me.btnUploadChap.TabIndex = 32
        Me.btnUploadChap.Text = "Upload Chapter"
        Me.btnUploadChap.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(1203, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(143, 125)
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbNewChap)
        Me.Panel2.Controls.Add(Me.rbNewEbook)
        Me.Panel2.Location = New System.Drawing.Point(584, 84)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(382, 100)
        Me.Panel2.TabIndex = 4
        '
        'rbNewEbook
        '
        Me.rbNewEbook.AutoSize = True
        Me.rbNewEbook.Location = New System.Drawing.Point(24, 40)
        Me.rbNewEbook.Name = "rbNewEbook"
        Me.rbNewEbook.Size = New System.Drawing.Size(98, 20)
        Me.rbNewEbook.TabIndex = 0
        Me.rbNewEbook.TabStop = True
        Me.rbNewEbook.Text = "New Ebook"
        Me.rbNewEbook.UseVisualStyleBackColor = True
        '
        'rbNewChap
        '
        Me.rbNewChap.AutoSize = True
        Me.rbNewChap.Location = New System.Drawing.Point(230, 40)
        Me.rbNewChap.Name = "rbNewChap"
        Me.rbNewChap.Size = New System.Drawing.Size(105, 20)
        Me.rbNewChap.TabIndex = 1
        Me.rbNewChap.TabStop = True
        Me.rbNewChap.Text = "New Chapter"
        Me.rbNewChap.UseVisualStyleBackColor = True
        '
        'cboEbook
        '
        Me.cboEbook.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEbook.FormattingEnabled = True
        Me.cboEbook.Location = New System.Drawing.Point(584, 190)
        Me.cboEbook.Name = "cboEbook"
        Me.cboEbook.Size = New System.Drawing.Size(382, 33)
        Me.cboEbook.TabIndex = 34
        '
        'UploadEbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.cboEbook)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.btnUploadChap)
        Me.Controls.Add(Me.btnPublish)
        Me.Controls.Add(Me.cboGenre)
        Me.Controls.Add(Me.txtChapter)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.linkUploadCover)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.picCover)
        Me.Name = "UploadEbook"
        Me.Text = "UploadEbook"
        CType(Me.picCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picCover As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents linkUploadCover As LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents txtDesc As TextBox
    Friend WithEvents txtChapter As TextBox
    Friend WithEvents cboGenre As ComboBox
    Friend WithEvents btnPublish As Button
    Friend WithEvents btnUploadChap As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rbNewChap As RadioButton
    Friend WithEvents rbNewEbook As RadioButton
    Friend WithEvents cboEbook As ComboBox
End Class
