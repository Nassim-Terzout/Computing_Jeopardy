<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class q1002form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q1002form))
        Me.q1002text = New System.Windows.Forms.Label()
        Me.q1002ans = New System.Windows.Forms.TextBox()
        Me.labelansq1002 = New System.Windows.Forms.Label()
        Me.Nextq1002 = New System.Windows.Forms.Button()
        Me.q1002border = New System.Windows.Forms.PictureBox()
        Me.borderanslabelq1002 = New System.Windows.Forms.PictureBox()
        Me.q1002back = New System.Windows.Forms.PictureBox()
        CType(Me.q1002border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.borderanslabelq1002, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q1002back, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'q1002text
        '
        Me.q1002text.BackColor = System.Drawing.Color.Black
        Me.q1002text.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q1002text.ForeColor = System.Drawing.Color.Red
        Me.q1002text.Location = New System.Drawing.Point(78, 38)
        Me.q1002text.Name = "q1002text"
        Me.q1002text.Size = New System.Drawing.Size(734, 278)
        Me.q1002text.TabIndex = 11
        Me.q1002text.Text = "What do we call harmful software?"
        Me.q1002text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'q1002ans
        '
        Me.q1002ans.BackColor = System.Drawing.Color.Black
        Me.q1002ans.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q1002ans.ForeColor = System.Drawing.Color.Red
        Me.q1002ans.Location = New System.Drawing.Point(380, 421)
        Me.q1002ans.Name = "q1002ans"
        Me.q1002ans.Size = New System.Drawing.Size(346, 42)
        Me.q1002ans.TabIndex = 12
        '
        'labelansq1002
        '
        Me.labelansq1002.BackColor = System.Drawing.Color.Black
        Me.labelansq1002.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelansq1002.ForeColor = System.Drawing.Color.Red
        Me.labelansq1002.Location = New System.Drawing.Point(213, 424)
        Me.labelansq1002.Name = "labelansq1002"
        Me.labelansq1002.Size = New System.Drawing.Size(139, 39)
        Me.labelansq1002.TabIndex = 13
        Me.labelansq1002.Text = "Answer:"
        '
        'Nextq1002
        '
        Me.Nextq1002.BackgroundImage = CType(resources.GetObject("Nextq1002.BackgroundImage"), System.Drawing.Image)
        Me.Nextq1002.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Nextq1002.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nextq1002.ForeColor = System.Drawing.Color.Black
        Me.Nextq1002.Location = New System.Drawing.Point(694, 479)
        Me.Nextq1002.Name = "Nextq1002"
        Me.Nextq1002.Size = New System.Drawing.Size(207, 78)
        Me.Nextq1002.TabIndex = 16
        Me.Nextq1002.Text = "Next"
        Me.Nextq1002.UseVisualStyleBackColor = True
        '
        'q1002border
        '
        Me.q1002border.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.q1002border.Location = New System.Drawing.Point(52, 26)
        Me.q1002border.Name = "q1002border"
        Me.q1002border.Size = New System.Drawing.Size(787, 303)
        Me.q1002border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q1002border.TabIndex = 10
        Me.q1002border.TabStop = False
        '
        'borderanslabelq1002
        '
        Me.borderanslabelq1002.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.borderanslabelq1002.Location = New System.Drawing.Point(192, 411)
        Me.borderanslabelq1002.Name = "borderanslabelq1002"
        Me.borderanslabelq1002.Size = New System.Drawing.Size(556, 62)
        Me.borderanslabelq1002.TabIndex = 14
        Me.borderanslabelq1002.TabStop = False
        '
        'q1002back
        '
        Me.q1002back.Image = Global.Jeopardy.My.Resources.Resources.Stage_curtains
        Me.q1002back.Location = New System.Drawing.Point(-1, -2)
        Me.q1002back.Name = "q1002back"
        Me.q1002back.Size = New System.Drawing.Size(913, 573)
        Me.q1002back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q1002back.TabIndex = 2
        Me.q1002back.TabStop = False
        '
        'q1002form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.Nextq1002)
        Me.Controls.Add(Me.labelansq1002)
        Me.Controls.Add(Me.q1002ans)
        Me.Controls.Add(Me.q1002text)
        Me.Controls.Add(Me.q1002border)
        Me.Controls.Add(Me.borderanslabelq1002)
        Me.Controls.Add(Me.q1002back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "q1002form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "q2001form"
        CType(Me.q1002border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.borderanslabelq1002, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q1002back, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents q1002back As PictureBox
    Friend WithEvents q1002border As PictureBox
    Friend WithEvents q1002text As Label
    Friend WithEvents q1002ans As TextBox
    Friend WithEvents labelansq1002 As Label
    Friend WithEvents borderanslabelq1002 As PictureBox
    Friend WithEvents Nextq1002 As Button
End Class
