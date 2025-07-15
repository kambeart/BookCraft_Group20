<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardPayment
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
        Me.txtCardHolder = New System.Windows.Forms.TextBox()
        Me.RadioButton_Mastercard = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Visa = New System.Windows.Forms.RadioButton()
        Me.txtCVV = New System.Windows.Forms.TextBox()
        Me.dtp_Expiry = New System.Windows.Forms.DateTimePicker()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txt_CardNum = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCardHolder
        '
        Me.txtCardHolder.Location = New System.Drawing.Point(332, 102)
        Me.txtCardHolder.Name = "txtCardHolder"
        Me.txtCardHolder.Size = New System.Drawing.Size(247, 22)
        Me.txtCardHolder.TabIndex = 0
        '
        'RadioButton_Mastercard
        '
        Me.RadioButton_Mastercard.AutoSize = True
        Me.RadioButton_Mastercard.Location = New System.Drawing.Point(285, 185)
        Me.RadioButton_Mastercard.Name = "RadioButton_Mastercard"
        Me.RadioButton_Mastercard.Size = New System.Drawing.Size(96, 20)
        Me.RadioButton_Mastercard.TabIndex = 1
        Me.RadioButton_Mastercard.TabStop = True
        Me.RadioButton_Mastercard.Text = "Mastercard"
        Me.RadioButton_Mastercard.UseVisualStyleBackColor = True
        '
        'RadioButton_Visa
        '
        Me.RadioButton_Visa.AutoSize = True
        Me.RadioButton_Visa.Location = New System.Drawing.Point(482, 185)
        Me.RadioButton_Visa.Name = "RadioButton_Visa"
        Me.RadioButton_Visa.Size = New System.Drawing.Size(55, 20)
        Me.RadioButton_Visa.TabIndex = 2
        Me.RadioButton_Visa.TabStop = True
        Me.RadioButton_Visa.Text = "Visa"
        Me.RadioButton_Visa.UseVisualStyleBackColor = True
        '
        'txtCVV
        '
        Me.txtCVV.Location = New System.Drawing.Point(580, 300)
        Me.txtCVV.Name = "txtCVV"
        Me.txtCVV.Size = New System.Drawing.Size(100, 22)
        Me.txtCVV.TabIndex = 3
        '
        'dtp_Expiry
        '
        Me.dtp_Expiry.Location = New System.Drawing.Point(178, 300)
        Me.dtp_Expiry.Name = "dtp_Expiry"
        Me.dtp_Expiry.Size = New System.Drawing.Size(238, 22)
        Me.dtp_Expiry.TabIndex = 4
        '
        'btnConfirm
        '
        Me.btnConfirm.BackColor = System.Drawing.Color.Sienna
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirm.Location = New System.Drawing.Point(373, 360)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(104, 36)
        Me.btnConfirm.TabIndex = 13
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.Sienna
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCancel.Location = New System.Drawing.Point(516, 360)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(104, 36)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Sienna
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(676, 360)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 36)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txt_CardNum
        '
        Me.txt_CardNum.Location = New System.Drawing.Point(332, 242)
        Me.txt_CardNum.Name = "txt_CardNum"
        Me.txt_CardNum.Size = New System.Drawing.Size(247, 22)
        Me.txt_CardNum.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Sienna
        Me.Label1.Location = New System.Drawing.Point(207, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(568, 53)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Payment via Credit/Debit Card"
        '
        'CardPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(210, Byte), Integer), CType(CType(227, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1013, 494)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_CardNum)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.dtp_Expiry)
        Me.Controls.Add(Me.txtCVV)
        Me.Controls.Add(Me.RadioButton_Visa)
        Me.Controls.Add(Me.RadioButton_Mastercard)
        Me.Controls.Add(Me.txtCardHolder)
        Me.Name = "CardPayment"
        Me.Text = "CardPayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCardHolder As TextBox
    Friend WithEvents RadioButton_Mastercard As RadioButton
    Friend WithEvents RadioButton_Visa As RadioButton
    Friend WithEvents txtCVV As TextBox
    Friend WithEvents dtp_Expiry As DateTimePicker
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents txt_CardNum As TextBox
    Friend WithEvents Label1 As Label
End Class
