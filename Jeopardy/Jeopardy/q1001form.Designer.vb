<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class q1001form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q1001form))
        Me.q1001text = New System.Windows.Forms.Label()
        Me.q1001ans1 = New System.Windows.Forms.RadioButton()
        Me.q1001ans2 = New System.Windows.Forms.RadioButton()
        Me.q1001ans3 = New System.Windows.Forms.RadioButton()
        Me.q1001ans4 = New System.Windows.Forms.RadioButton()
        Me.q1001ansback = New System.Windows.Forms.Label()
        Me.Nextq1001 = New System.Windows.Forms.Button()
        Me.q1001border = New System.Windows.Forms.PictureBox()
        Me.borderq1001ans = New System.Windows.Forms.PictureBox()
        Me.q1001back = New System.Windows.Forms.PictureBox()
        CType(Me.q1001border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.borderq1001ans, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q1001back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'q1001text
        '
        Me.q1001text.BackColor = System.Drawing.Color.Black
        Me.q1001text.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q1001text.ForeColor = System.Drawing.Color.Red
        Me.q1001text.Location = New System.Drawing.Point(78, 38)
        Me.q1001text.Name = "q1001text"
        Me.q1001text.Size = New System.Drawing.Size(734, 278)
        Me.q1001text.TabIndex = 10
        Me.q1001text.Text = "Which of the following is not an Operating System?"
        Me.q1001text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'q1001ans1
        '
        Me.q1001ans1.AutoSize = True
        Me.q1001ans1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.q1001ans1.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q1001ans1.ForeColor = System.Drawing.Color.Red
        Me.q1001ans1.Location = New System.Drawing.Point(104, 356)
        Me.q1001ans1.Name = "q1001ans1"
        Me.q1001ans1.Size = New System.Drawing.Size(219, 26)
        Me.q1001ans1.TabIndex = 11
        Me.q1001ans1.TabStop = True
        Me.q1001ans1.Text = "Microsoft Windows"
        Me.q1001ans1.UseVisualStyleBackColor = False
        '
        'q1001ans2
        '
        Me.q1001ans2.AutoSize = True
        Me.q1001ans2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.q1001ans2.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q1001ans2.ForeColor = System.Drawing.Color.Red
        Me.q1001ans2.Location = New System.Drawing.Point(104, 388)
        Me.q1001ans2.Name = "q1001ans2"
        Me.q1001ans2.Size = New System.Drawing.Size(155, 26)
        Me.q1001ans2.TabIndex = 12
        Me.q1001ans2.TabStop = True
        Me.q1001ans2.Text = "Linux Ubuntu"
        Me.q1001ans2.UseVisualStyleBackColor = False
        '
        'q1001ans3
        '
        Me.q1001ans3.AutoSize = True
        Me.q1001ans3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.q1001ans3.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q1001ans3.ForeColor = System.Drawing.Color.Red
        Me.q1001ans3.Location = New System.Drawing.Point(104, 420)
        Me.q1001ans3.Name = "q1001ans3"
        Me.q1001ans3.Size = New System.Drawing.Size(185, 26)
        Me.q1001ans3.TabIndex = 13
        Me.q1001ans3.TabStop = True
        Me.q1001ans3.Text = "Linux Backtrack"
        Me.q1001ans3.UseVisualStyleBackColor = False
        '
        'q1001ans4
        '
        Me.q1001ans4.AutoSize = True
        Me.q1001ans4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.q1001ans4.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q1001ans4.ForeColor = System.Drawing.Color.Red
        Me.q1001ans4.Location = New System.Drawing.Point(104, 452)
        Me.q1001ans4.Name = "q1001ans4"
        Me.q1001ans4.Size = New System.Drawing.Size(206, 26)
        Me.q1001ans4.TabIndex = 14
        Me.q1001ans4.TabStop = True
        Me.q1001ans4.Text = "League of Pigeons"
        Me.q1001ans4.UseVisualStyleBackColor = False
        '
        'q1001ansback
        '
        Me.q1001ansback.BackColor = System.Drawing.Color.Black
        Me.q1001ansback.Location = New System.Drawing.Point(91, 356)
        Me.q1001ansback.Name = "q1001ansback"
        Me.q1001ansback.Size = New System.Drawing.Size(249, 154)
        Me.q1001ansback.TabIndex = 17
        '
        'Nextq1001
        '
        Me.Nextq1001.BackgroundImage = CType(resources.GetObject("Nextq1001.BackgroundImage"), System.Drawing.Image)
        Me.Nextq1001.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Nextq1001.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nextq1001.ForeColor = System.Drawing.Color.Black
        Me.Nextq1001.Location = New System.Drawing.Point(694, 479)
        Me.Nextq1001.Name = "Nextq1001"
        Me.Nextq1001.Size = New System.Drawing.Size(207, 78)
        Me.Nextq1001.TabIndex = 15
        Me.Nextq1001.Text = "Next"
        Me.Nextq1001.UseVisualStyleBackColor = True
        '
        'q1001border
        '
        Me.q1001border.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.q1001border.Location = New System.Drawing.Point(52, 26)
        Me.q1001border.Name = "q1001border"
        Me.q1001border.Size = New System.Drawing.Size(787, 303)
        Me.q1001border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q1001border.TabIndex = 9
        Me.q1001border.TabStop = False
        '
        'borderq1001ans
        '
        Me.borderq1001ans.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.borderq1001ans.Location = New System.Drawing.Point(81, 347)
        Me.borderq1001ans.Name = "borderq1001ans"
        Me.borderq1001ans.Size = New System.Drawing.Size(268, 171)
        Me.borderq1001ans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.borderq1001ans.TabIndex = 16
        Me.borderq1001ans.TabStop = False
        '
        'q1001back
        '
        Me.q1001back.Image = Global.Jeopardy.My.Resources.Resources.Stage_curtains
        Me.q1001back.Location = New System.Drawing.Point(0, -2)
        Me.q1001back.Name = "q1001back"
        Me.q1001back.Size = New System.Drawing.Size(913, 573)
        Me.q1001back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q1001back.TabIndex = 1
        Me.q1001back.TabStop = False
        '
        'q1001form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.Nextq1001)
        Me.Controls.Add(Me.q1001ans4)
        Me.Controls.Add(Me.q1001ans3)
        Me.Controls.Add(Me.q1001ans2)
        Me.Controls.Add(Me.q1001ans1)
        Me.Controls.Add(Me.q1001text)
        Me.Controls.Add(Me.q1001border)
        Me.Controls.Add(Me.q1001ansback)
        Me.Controls.Add(Me.borderq1001ans)
        Me.Controls.Add(Me.q1001back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "q1001form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.q1001border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.borderq1001ans, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q1001back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents q1001back As PictureBox
    Friend WithEvents q1001border As PictureBox
    Friend WithEvents q1001text As Label
    Friend WithEvents q1001ans1 As RadioButton
    Friend WithEvents q1001ans2 As RadioButton
    Friend WithEvents q1001ans3 As RadioButton
    Friend WithEvents q1001ans4 As RadioButton
    Friend WithEvents Nextq1001 As Button
    Friend WithEvents borderq1001ans As PictureBox
    Friend WithEvents q1001ansback As Label
End Class
