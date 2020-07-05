<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class q4002form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q4002form))
        Me.q4002back = New System.Windows.Forms.PictureBox()
        Me.q4002border = New System.Windows.Forms.PictureBox()
        Me.q4002text = New System.Windows.Forms.Label()
        Me.Nextq4002 = New System.Windows.Forms.Button()
        Me.q4002panel = New System.Windows.Forms.Panel()
        Me.q4002ans4 = New System.Windows.Forms.RadioButton()
        Me.q4002ans3 = New System.Windows.Forms.RadioButton()
        Me.q4002ans2 = New System.Windows.Forms.RadioButton()
        Me.q4002ans1 = New System.Windows.Forms.RadioButton()
        Me.q4002ansback = New System.Windows.Forms.Label()
        Me.borderq4002ans = New System.Windows.Forms.PictureBox()
        CType(Me.q4002back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q4002border, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.q4002panel.SuspendLayout()
        CType(Me.borderq4002ans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'q4002back
        '
        Me.q4002back.Image = Global.Jeopardy.My.Resources.Resources.Stage_curtains
        Me.q4002back.Location = New System.Drawing.Point(0, -2)
        Me.q4002back.Name = "q4002back"
        Me.q4002back.Size = New System.Drawing.Size(913, 575)
        Me.q4002back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q4002back.TabIndex = 3
        Me.q4002back.TabStop = False
        '
        'q4002border
        '
        Me.q4002border.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.q4002border.Location = New System.Drawing.Point(52, 26)
        Me.q4002border.Name = "q4002border"
        Me.q4002border.Size = New System.Drawing.Size(787, 303)
        Me.q4002border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q4002border.TabIndex = 10
        Me.q4002border.TabStop = False
        '
        'q4002text
        '
        Me.q4002text.BackColor = System.Drawing.Color.Black
        Me.q4002text.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q4002text.ForeColor = System.Drawing.Color.Red
        Me.q4002text.Location = New System.Drawing.Point(78, 38)
        Me.q4002text.Name = "q4002text"
        Me.q4002text.Size = New System.Drawing.Size(734, 278)
        Me.q4002text.TabIndex = 13
        Me.q4002text.Text = "What is a whistle blower?"
        Me.q4002text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Nextq4002
        '
        Me.Nextq4002.BackgroundImage = CType(resources.GetObject("Nextq4002.BackgroundImage"), System.Drawing.Image)
        Me.Nextq4002.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Nextq4002.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nextq4002.ForeColor = System.Drawing.Color.Black
        Me.Nextq4002.Location = New System.Drawing.Point(694, 479)
        Me.Nextq4002.Name = "Nextq4002"
        Me.Nextq4002.Size = New System.Drawing.Size(207, 78)
        Me.Nextq4002.TabIndex = 22
        Me.Nextq4002.Text = "Next"
        Me.Nextq4002.UseVisualStyleBackColor = True
        '
        'q4002panel
        '
        Me.q4002panel.Controls.Add(Me.q4002ans4)
        Me.q4002panel.Controls.Add(Me.q4002ans3)
        Me.q4002panel.Controls.Add(Me.q4002ans2)
        Me.q4002panel.Controls.Add(Me.q4002ans1)
        Me.q4002panel.Controls.Add(Me.q4002ansback)
        Me.q4002panel.Controls.Add(Me.borderq4002ans)
        Me.q4002panel.Location = New System.Drawing.Point(52, 335)
        Me.q4002panel.Name = "q4002panel"
        Me.q4002panel.Size = New System.Drawing.Size(622, 170)
        Me.q4002panel.TabIndex = 29
        '
        'q4002ans4
        '
        Me.q4002ans4.AutoSize = True
        Me.q4002ans4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.q4002ans4.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q4002ans4.ForeColor = System.Drawing.Color.Red
        Me.q4002ans4.Location = New System.Drawing.Point(37, 114)
        Me.q4002ans4.Name = "q4002ans4"
        Me.q4002ans4.Size = New System.Drawing.Size(361, 25)
        Me.q4002ans4.TabIndex = 24
        Me.q4002ans4.TabStop = True
        Me.q4002ans4.Text = "Someone who blows whistles for fun"
        Me.q4002ans4.UseVisualStyleBackColor = False
        '
        'q4002ans3
        '
        Me.q4002ans3.AutoSize = True
        Me.q4002ans3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.q4002ans3.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q4002ans3.ForeColor = System.Drawing.Color.Red
        Me.q4002ans3.Location = New System.Drawing.Point(37, 83)
        Me.q4002ans3.Name = "q4002ans3"
        Me.q4002ans3.Size = New System.Drawing.Size(526, 25)
        Me.q4002ans3.TabIndex = 23
        Me.q4002ans3.TabStop = True
        Me.q4002ans3.Text = "Someone who blows whistles based on moral dilemma"
        Me.q4002ans3.UseVisualStyleBackColor = False
        '
        'q4002ans2
        '
        Me.q4002ans2.AutoSize = True
        Me.q4002ans2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.q4002ans2.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q4002ans2.ForeColor = System.Drawing.Color.Red
        Me.q4002ans2.Location = New System.Drawing.Point(37, 52)
        Me.q4002ans2.Name = "q4002ans2"
        Me.q4002ans2.Size = New System.Drawing.Size(547, 25)
        Me.q4002ans2.TabIndex = 22
        Me.q4002ans2.TabStop = True
        Me.q4002ans2.Text = "Someone who hides information based on moral dilemma"
        Me.q4002ans2.UseVisualStyleBackColor = False
        '
        'q4002ans1
        '
        Me.q4002ans1.AutoSize = True
        Me.q4002ans1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.q4002ans1.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q4002ans1.ForeColor = System.Drawing.Color.Red
        Me.q4002ans1.Location = New System.Drawing.Point(37, 21)
        Me.q4002ans1.Name = "q4002ans1"
        Me.q4002ans1.Size = New System.Drawing.Size(550, 25)
        Me.q4002ans1.TabIndex = 21
        Me.q4002ans1.TabStop = True
        Me.q4002ans1.Text = "Someone who leaks information based on moral dilemma"
        Me.q4002ans1.UseVisualStyleBackColor = False
        '
        'q4002ansback
        '
        Me.q4002ansback.BackColor = System.Drawing.Color.Black
        Me.q4002ansback.Location = New System.Drawing.Point(21, 10)
        Me.q4002ansback.Name = "q4002ansback"
        Me.q4002ansback.Size = New System.Drawing.Size(581, 152)
        Me.q4002ansback.TabIndex = 19
        '
        'borderq4002ans
        '
        Me.borderq4002ans.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.borderq4002ans.Location = New System.Drawing.Point(0, 0)
        Me.borderq4002ans.Name = "borderq4002ans"
        Me.borderq4002ans.Size = New System.Drawing.Size(623, 170)
        Me.borderq4002ans.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.borderq4002ans.TabIndex = 20
        Me.borderq4002ans.TabStop = False
        '
        'q4002form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.q4002panel)
        Me.Controls.Add(Me.Nextq4002)
        Me.Controls.Add(Me.q4002text)
        Me.Controls.Add(Me.q4002border)
        Me.Controls.Add(Me.q4002back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "q4002form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "q4002form"
        CType(Me.q4002back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q4002border, System.ComponentModel.ISupportInitialize).EndInit()
        Me.q4002panel.ResumeLayout(False)
        Me.q4002panel.PerformLayout()
        CType(Me.borderq4002ans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents q4002back As PictureBox
    Friend WithEvents q4002border As PictureBox
    Friend WithEvents q4002text As Label
    Friend WithEvents Nextq4002 As Button
    Friend WithEvents q4002panel As Panel
    Friend WithEvents q4002ans4 As RadioButton
    Friend WithEvents q4002ans3 As RadioButton
    Friend WithEvents q4002ans2 As RadioButton
    Friend WithEvents q4002ans1 As RadioButton
    Friend WithEvents q4002ansback As Label
    Friend WithEvents borderq4002ans As PictureBox
End Class
