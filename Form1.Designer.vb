<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtPlain = New System.Windows.Forms.TextBox()
        Me.txtPlainKey = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.btnPlain = New System.Windows.Forms.Button()
        Me.btnCipher = New System.Windows.Forms.Button()
        Me.lblCipher = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDecrypt = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtPlain
        '
        Me.txtPlain.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPlain.Location = New System.Drawing.Point(216, 37)
        Me.txtPlain.Name = "txtPlain"
        Me.txtPlain.Size = New System.Drawing.Size(228, 33)
        Me.txtPlain.TabIndex = 0
        '
        'txtPlainKey
        '
        Me.txtPlainKey.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtPlainKey.Location = New System.Drawing.Point(216, 87)
        Me.txtPlainKey.Name = "txtPlainKey"
        Me.txtPlainKey.Size = New System.Drawing.Size(228, 33)
        Me.txtPlainKey.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(148, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(51, 24)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Text"
        '
        'lblKey
        '
        Me.lblKey.AutoSize = True
        Me.lblKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblKey.ForeColor = System.Drawing.Color.White
        Me.lblKey.Location = New System.Drawing.Point(154, 91)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(45, 24)
        Me.lblKey.TabIndex = 3
        Me.lblKey.Text = "Key"
        '
        'btnPlain
        '
        Me.btnPlain.BackColor = System.Drawing.Color.Black
        Me.btnPlain.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPlain.ForeColor = System.Drawing.Color.White
        Me.btnPlain.Location = New System.Drawing.Point(119, 275)
        Me.btnPlain.Name = "btnPlain"
        Me.btnPlain.Size = New System.Drawing.Size(87, 46)
        Me.btnPlain.TabIndex = 10
        Me.btnPlain.Text = "Encrypt"
        Me.btnPlain.UseVisualStyleBackColor = False
        '
        'btnCipher
        '
        Me.btnCipher.BackColor = System.Drawing.Color.Black
        Me.btnCipher.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCipher.ForeColor = System.Drawing.Color.White
        Me.btnCipher.Location = New System.Drawing.Point(274, 275)
        Me.btnCipher.Name = "btnCipher"
        Me.btnCipher.Size = New System.Drawing.Size(87, 46)
        Me.btnCipher.TabIndex = 11
        Me.btnCipher.Text = "Decrypt"
        Me.btnCipher.UseVisualStyleBackColor = False
        '
        'lblCipher
        '
        Me.lblCipher.AutoSize = True
        Me.lblCipher.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCipher.ForeColor = System.Drawing.Color.Red
        Me.lblCipher.Location = New System.Drawing.Point(247, 135)
        Me.lblCipher.Name = "lblCipher"
        Me.lblCipher.Size = New System.Drawing.Size(0, 24)
        Me.lblCipher.TabIndex = 12
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(47, 135)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(152, 24)
        Me.Label21.TabIndex = 14
        Me.Label21.Text = "Encrypted Text"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(47, 189)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 24)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Decrypted Text"
        '
        'lblDecrypt
        '
        Me.lblDecrypt.AutoSize = True
        Me.lblDecrypt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDecrypt.ForeColor = System.Drawing.Color.Lime
        Me.lblDecrypt.Location = New System.Drawing.Point(247, 189)
        Me.lblDecrypt.Name = "lblDecrypt"
        Me.lblDecrypt.Size = New System.Drawing.Size(0, 24)
        Me.lblDecrypt.TabIndex = 15
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(421, 275)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 46)
        Me.btnClear.TabIndex = 17
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(612, 343)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblDecrypt)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.lblCipher)
        Me.Controls.Add(Me.btnCipher)
        Me.Controls.Add(Me.btnPlain)
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtPlainKey)
        Me.Controls.Add(Me.txtPlain)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encrypter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPlain As TextBox
    Friend WithEvents txtPlainKey As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents lblKey As Label
    Friend WithEvents btnPlain As Button
    Friend WithEvents btnCipher As Button
    Friend WithEvents lblCipher As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDecrypt As Label
    Friend WithEvents btnClear As Button
End Class
