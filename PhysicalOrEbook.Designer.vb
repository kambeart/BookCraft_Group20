<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PhysicalOrEbook
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PhysicalOrEbook))
        Me.btnPhysical = New System.Windows.Forms.Button()
        Me.btnEbook = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBackToMarketPlace = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPhysical
        '
        Me.btnPhysical.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnPhysical.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPhysical.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPhysical.Location = New System.Drawing.Point(93, 259)
        Me.btnPhysical.Name = "btnPhysical"
        Me.btnPhysical.Size = New System.Drawing.Size(171, 69)
        Me.btnPhysical.TabIndex = 0
        Me.btnPhysical.Text = "Physical Book"
        Me.btnPhysical.UseVisualStyleBackColor = False
        '
        'btnEbook
        '
        Me.btnEbook.BackColor = System.Drawing.Color.LavenderBlush
        Me.btnEbook.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEbook.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEbook.Location = New System.Drawing.Point(382, 259)
        Me.btnEbook.Name = "btnEbook"
        Me.btnEbook.Size = New System.Drawing.Size(171, 69)
        Me.btnEbook.TabIndex = 1
        Me.btnEbook.Text = "Ebook"
        Me.btnEbook.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(349, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(239, 236)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(61, 16)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(239, 236)
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Bisque
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnEbook)
        Me.Panel1.Controls.Add(Me.btnPhysical)
        Me.Panel1.Location = New System.Drawing.Point(71, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(653, 336)
        Me.Panel1.TabIndex = 6
        '
        'btnBackToMarketPlace
        '
        Me.btnBackToMarketPlace.BackgroundImage = CType(resources.GetObject("btnBackToMarketPlace.BackgroundImage"), System.Drawing.Image)
        Me.btnBackToMarketPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBackToMarketPlace.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackToMarketPlace.ForeColor = System.Drawing.Color.Transparent
        Me.btnBackToMarketPlace.Location = New System.Drawing.Point(12, 12)
        Me.btnBackToMarketPlace.Name = "btnBackToMarketPlace"
        Me.btnBackToMarketPlace.Size = New System.Drawing.Size(74, 57)
        Me.btnBackToMarketPlace.TabIndex = 35
        Me.btnBackToMarketPlace.UseVisualStyleBackColor = True
        '
        'PhysicalOrEbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(252, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(182, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBackToMarketPlace)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "PhysicalOrEbook"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PhysicalOrEbook"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnPhysical As Button
    Friend WithEvents btnEbook As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBackToMarketPlace As Button
End Class
