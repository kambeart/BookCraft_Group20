﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Transaction_Place
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction_Place))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.RadioButton_Ewallet = New System.Windows.Forms.RadioButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.RadioButton_OnlineBank = New System.Windows.Forms.RadioButton()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.RadioButton_Card = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBackToShoppingCart = New System.Windows.Forms.Button()
        Me.btnConfirmPayment = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(1035, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(129, 126)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Location = New System.Drawing.Point(878, 116)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(151, 142)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'RadioButton_Ewallet
        '
        Me.RadioButton_Ewallet.AutoSize = True
        Me.RadioButton_Ewallet.BackColor = System.Drawing.Color.White
        Me.RadioButton_Ewallet.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Ewallet.Location = New System.Drawing.Point(185, 162)
        Me.RadioButton_Ewallet.Name = "RadioButton_Ewallet"
        Me.RadioButton_Ewallet.Size = New System.Drawing.Size(184, 39)
        Me.RadioButton_Ewallet.TabIndex = 2
        Me.RadioButton_Ewallet.TabStop = True
        Me.RadioButton_Ewallet.Text = "E-wallet / QR"
        Me.RadioButton_Ewallet.UseVisualStyleBackColor = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox3.Location = New System.Drawing.Point(1026, 264)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(129, 126)
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox4.Location = New System.Drawing.Point(891, 264)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(129, 126)
        Me.PictureBox4.TabIndex = 29
        Me.PictureBox4.TabStop = False
        '
        'RadioButton_OnlineBank
        '
        Me.RadioButton_OnlineBank.AutoSize = True
        Me.RadioButton_OnlineBank.BackColor = System.Drawing.Color.White
        Me.RadioButton_OnlineBank.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_OnlineBank.Location = New System.Drawing.Point(185, 316)
        Me.RadioButton_OnlineBank.Name = "RadioButton_OnlineBank"
        Me.RadioButton_OnlineBank.Size = New System.Drawing.Size(207, 39)
        Me.RadioButton_OnlineBank.TabIndex = 3
        Me.RadioButton_OnlineBank.Text = "Online Banking"
        Me.RadioButton_OnlineBank.UseVisualStyleBackColor = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackgroundImage = CType(resources.GetObject("PictureBox5.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox5.Location = New System.Drawing.Point(906, 396)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(232, 162)
        Me.PictureBox5.TabIndex = 31
        Me.PictureBox5.TabStop = False
        '
        'RadioButton_Card
        '
        Me.RadioButton_Card.AutoSize = True
        Me.RadioButton_Card.BackColor = System.Drawing.Color.White
        Me.RadioButton_Card.Font = New System.Drawing.Font("Calibri", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Card.Location = New System.Drawing.Point(185, 468)
        Me.RadioButton_Card.Name = "RadioButton_Card"
        Me.RadioButton_Card.Size = New System.Drawing.Size(248, 39)
        Me.RadioButton_Card.TabIndex = 4
        Me.RadioButton_Card.TabStop = True
        Me.RadioButton_Card.Text = "Credit / Debit Card"
        Me.RadioButton_Card.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(431, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(466, 53)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Choose Payment Method"
        '
        'btnBackToShoppingCart
        '
        Me.btnBackToShoppingCart.BackgroundImage = CType(resources.GetObject("btnBackToShoppingCart.BackgroundImage"), System.Drawing.Image)
        Me.btnBackToShoppingCart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBackToShoppingCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackToShoppingCart.ForeColor = System.Drawing.Color.Transparent
        Me.btnBackToShoppingCart.Location = New System.Drawing.Point(27, 43)
        Me.btnBackToShoppingCart.Name = "btnBackToShoppingCart"
        Me.btnBackToShoppingCart.Size = New System.Drawing.Size(86, 78)
        Me.btnBackToShoppingCart.TabIndex = 25
        Me.btnBackToShoppingCart.UseVisualStyleBackColor = True
        '
        'btnConfirmPayment
        '
        Me.btnConfirmPayment.BackColor = System.Drawing.Color.Sienna
        Me.btnConfirmPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmPayment.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.btnConfirmPayment.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmPayment.Location = New System.Drawing.Point(600, 620)
        Me.btnConfirmPayment.Name = "btnConfirmPayment"
        Me.btnConfirmPayment.Size = New System.Drawing.Size(145, 46)
        Me.btnConfirmPayment.TabIndex = 32
        Me.btnConfirmPayment.Text = "Confirm"
        Me.btnConfirmPayment.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(136, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1107, 490)
        Me.Panel1.TabIndex = 33
        '
        'Transaction_Place
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1348, 721)
        Me.Controls.Add(Me.btnConfirmPayment)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.RadioButton_Card)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.btnBackToShoppingCart)
        Me.Controls.Add(Me.RadioButton_OnlineBank)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RadioButton_Ewallet)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Transaction_Place"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction_Place"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton_Ewallet As RadioButton
    Friend WithEvents RadioButton_OnlineBank As RadioButton
    Friend WithEvents RadioButton_Card As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBackToShoppingCart As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents btnConfirmPayment As Button
    Friend WithEvents Panel1 As Panel
End Class
