<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class q3004form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q3004form))
        Me.q3004back = New System.Windows.Forms.PictureBox()
        Me.q3004border = New System.Windows.Forms.PictureBox()
        Me.q3004text = New System.Windows.Forms.Label()
        Me.Nextq3004 = New System.Windows.Forms.Button()
        Me.q3004panel = New System.Windows.Forms.Panel()
        Me.q3004ans4 = New System.Windows.Forms.RadioButton()
        Me.q3004ans3 = New System.Windows.Forms.RadioButton()
        Me.q3004ans2 = New System.Windows.Forms.RadioButton()
        Me.q3004ans1 = New System.Windows.Forms.RadioButton()
        Me.q3004ansback = New System.Windows.Forms.Label()
        Me.borderq3004ans = New System.Windows.Forms.PictureBox()
        CType(Me.q3004back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q3004border, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.q3004panel.SuspendLayout()
        CType(Me.borderq3004ans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'q3004back
        '
        Me.q3004back.Image = Global.Jeopardy.My.Resources.Resources.Stage_curtains
        Me.q3004back.Location = New System.Drawing.Point(-1, -2)
        Me.q3004back.Name = "q3004back"
        Me.q3004back.Size = New System.Drawing.Size(914, 575)
        Me.q3004back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q3004back.TabIndex = 3
        Me.q3004back.TabStop = False
        '
        'q3004border
        '
        Me.q3004border.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.q3004border.Location = New System.Drawing.Point(52, 26)
        Me.q3004border.Name = "q3004border"
        Me.q3004border.Size = New System.Drawing.Size(787, 303)
        Me.q3004border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q3004border.TabIndex = 10
        Me.q3004border.TabStop = False
        '
        'q3004text
        '
        Me.q3004text.BackColor = System.Drawing.Color.Black
        Me.q3004text.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q3004text.ForeColor = System.Drawing.Color.Red
        Me.q3004text.Location = New System.Drawing.Point(78, 38)
        Me.q3004text.Name = "q3004text"
        Me.q3004text.Size = New System.Drawing.Size(734, 278)
        Me.q3004text.TabIndex = 12
        Me.q3004text.Text = "A statement giving the computer two options based on the given."
        Me.q3004text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Nextq3004
        '
        Me.Nextq3004.BackgroundImage = CType(resources.GetObject("Nextq3004.BackgroundImage"), System.Drawing.Image)
        Me.Nextq3004.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Nextq3004.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nextq3004.ForeColor = System.Drawing.Color.Black
        Me.Nextq3004.Location = New System.Drawing.Point(694, 479)
        Me.Nextq3004.Name = "Nextq3004"
        Me.Nextq3004.Size = New System.Drawing.Size(207, 78)
        Me.Nextq3004.TabIndex = 21
        Me.Nextq3004.Text = "Next"
        Me.Nextq3004.UseVisualStyleBackColor = True
        '
        'q3004panel
        '
        Me.q3004panel.Controls.Add(Me.q3004ans4)
        Me.q3004panel.Controls.Add(Me.q3004ans3)
        Me.q3004panel.Controls.Add(Me.q3004ans2)
        Me.q3004panel.Controls.Add(Me.q3004ans1)
        Me.q3004panel.Controls.Add(Me.q3004ansback)
        Me.q3004panel.Controls.Add(Me.borderq3004ans)
        Me.q3004panel.Location = New System.Drawing.Point(52, 350)
        Me.q3004panel.Name = "q3004panel"
        Me.q3004panel.Size = New System.Drawing.Size(622, 170)
        Me.q3004panel.TabIndex = 28
        '
        'q3004ans4
        '
        Me.q3004ans4.AutoSize = True
        Me.q3004ans4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.q3004ans4.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q3004ans4.ForeColor = System.Drawing.Color.Red
        Me.q3004ans4.Location = New System.Drawing.Point(37, 114)
        Me.q3004ans4.Name = "q3004ans4"
        Me.q3004ans4.Size = New System.Drawing.Size(205, 25)
        Me.q3004ans4.TabIndex = 24
        Me.q3004ans4.TabStop = True
        Me.q3004ans4.Text = "If/Then statements"
        Me.q3004ans4.UseVisualStyleBackColor = False
        '
        'q3004ans3
        '
        Me.q3004ans3.AutoSize = True
        Me.q3004ans3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.q3004ans3.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q3004ans3.ForeColor = System.Drawing.Color.Red
        Me.q3004ans3.Location = New System.Drawing.Point(37, 83)
        Me.q3004ans3.Name = "q3004ans3"
        Me.q3004ans3.Size = New System.Drawing.Size(206, 25)
        Me.q3004ans3.TabIndex = 23
        Me.q3004ans3.TabStop = True
        Me.q3004ans3.Text = "Or/Else statements"
        Me.q3004ans3.UseVisualStyleBackColor = False
        '
        'q3004ans2
        '
        Me.q3004ans2.AutoSize = True
        Me.q3004ans2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.q3004ans2.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q3004ans2.ForeColor = System.Drawing.Color.Red
        Me.q3004ans2.Location = New System.Drawing.Point(37, 52)
        Me.q3004ans2.Name = "q3004ans2"
        Me.q3004ans2.Size = New System.Drawing.Size(185, 25)
        Me.q3004ans2.TabIndex = 22
        Me.q3004ans2.TabStop = True
        Me.q3004ans2.Text = "If/Or Statements"
        Me.q3004ans2.UseVisualStyleBackColor = False
        '
        'q3004ans1
        '
        Me.q3004ans1.AutoSize = True
        Me.q3004ans1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.q3004ans1.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q3004ans1.ForeColor = System.Drawing.Color.Red
        Me.q3004ans1.Location = New System.Drawing.Point(37, 21)
        Me.q3004ans1.Name = "q3004ans1"
        Me.q3004ans1.Size = New System.Drawing.Size(202, 25)
        Me.q3004ans1.TabIndex = 21
        Me.q3004ans1.TabStop = True
        Me.q3004ans1.Text = "If/And statements"
        Me.q3004ans1.UseVisualStyleBackColor = False
        '
        'q3004ansback
        '
        Me.q3004ansback.BackColor = System.Drawing.Color.Black
        Me.q3004ansback.Location = New System.Drawing.Point(21, 9)
        Me.q3004ansback.Name = "q3004ansback"
        Me.q3004ansback.Size = New System.Drawing.Size(581, 152)
        Me.q3004ansback.TabIndex = 19
        '
        'borderq3004ans
        '
        Me.borderq3004ans.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.borderq3004ans.Location = New System.Drawing.Point(0, 0)
        Me.borderq3004ans.Name = "borderq3004ans"
        Me.borderq3004ans.Size = New System.Drawing.Size(623, 170)
        Me.borderq3004ans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.borderq3004ans.TabIndex = 20
        Me.borderq3004ans.TabStop = False
        '
        'q3004form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.q3004panel)
        Me.Controls.Add(Me.Nextq3004)
        Me.Controls.Add(Me.q3004text)
        Me.Controls.Add(Me.q3004border)
        Me.Controls.Add(Me.q3004back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "q3004form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "q3004form"
        CType(Me.q3004back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q3004border, System.ComponentModel.ISupportInitialize).EndInit()
        Me.q3004panel.ResumeLayout(False)
        Me.q3004panel.PerformLayout()
        CType(Me.borderq3004ans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents q3004back As PictureBox
    Friend WithEvents q3004border As PictureBox
    Friend WithEvents q3004text As Label
    Friend WithEvents Nextq3004 As Button
    Friend WithEvents q3004panel As Panel
    Friend WithEvents q3004ans4 As RadioButton
    Friend WithEvents q3004ans3 As RadioButton
    Friend WithEvents q3004ans2 As RadioButton
    Friend WithEvents q3004ans1 As RadioButton
    Friend WithEvents q3004ansback As Label
    Friend WithEvents borderq3004ans As PictureBox
End Class
