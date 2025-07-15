<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OnlineBankingPayment
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(221, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(524, 53)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Payment via Online Banking"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(311, 218)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 28)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Username"
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(447, 214)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(204, 32)
        Me.txtUsername.TabIndex = 6
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(447, 258)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(204, 32)
        Me.txtPassword.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(311, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 28)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(417, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 28)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Bank Name"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDone
        '
        Me.btnDone.BackColor = System.Drawing.Color.Sienna
        Me.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDone.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDone.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDone.Location = New System.Drawing.Point(343, 316)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(104, 36)
        Me.btnDone.TabIndex = 11
        Me.btnDone.Text = "Confirm"
        Me.btnDone.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Sienna
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(505, 316)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 36)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'OnlineBankingPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.BackgroundImage = Global.BookCraft_Group20.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(984, 532)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "OnlineBankingPayment"
        Me.Text = "OnlineBankingPayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnDone As Button
    Friend WithEvents btnCancel As Button
End Class
