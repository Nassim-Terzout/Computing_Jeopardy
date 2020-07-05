<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class q2002form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q2002form))
        Me.q2002back = New System.Windows.Forms.PictureBox()
        Me.q2002border = New System.Windows.Forms.PictureBox()
        Me.q2002text = New System.Windows.Forms.Label()
        Me.q2002borderans = New System.Windows.Forms.PictureBox()
        Me.q2002labelans = New System.Windows.Forms.Label()
        Me.q2002ans = New System.Windows.Forms.TextBox()
        Me.Nextq2002 = New System.Windows.Forms.Button()
        CType(Me.q2002back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q2002border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q2002borderans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'q2002back
        '
        Me.q2002back.Image = Global.Jeopardy.My.Resources.Resources.Stage_curtains
        Me.q2002back.Location = New System.Drawing.Point(-1, -2)
        Me.q2002back.Name = "q2002back"
        Me.q2002back.Size = New System.Drawing.Size(914, 575)
        Me.q2002back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q2002back.TabIndex = 3
        Me.q2002back.TabStop = False
        '
        'q2002border
        '
        Me.q2002border.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.q2002border.Location = New System.Drawing.Point(52, 26)
        Me.q2002border.Name = "q2002border"
        Me.q2002border.Size = New System.Drawing.Size(787, 303)
        Me.q2002border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q2002border.TabIndex = 10
        Me.q2002border.TabStop = False
        '
        'q2002text
        '
        Me.q2002text.BackColor = System.Drawing.Color.Black
        Me.q2002text.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q2002text.ForeColor = System.Drawing.Color.Red
        Me.q2002text.Location = New System.Drawing.Point(78, 38)
        Me.q2002text.Name = "q2002text"
        Me.q2002text.Size = New System.Drawing.Size(734, 278)
        Me.q2002text.TabIndex = 12
        Me.q2002text.Text = "Which do we call the ""brain"" of the computer?"
        Me.q2002text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'q2002borderans
        '
        Me.q2002borderans.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.q2002borderans.Location = New System.Drawing.Point(192, 411)
        Me.q2002borderans.Name = "q2002borderans"
        Me.q2002borderans.Size = New System.Drawing.Size(556, 62)
        Me.q2002borderans.TabIndex = 15
        Me.q2002borderans.TabStop = False
        '
        'q2002labelans
        '
        Me.q2002labelans.BackColor = System.Drawing.Color.Black
        Me.q2002labelans.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q2002labelans.ForeColor = System.Drawing.Color.Red
        Me.q2002labelans.Location = New System.Drawing.Point(213, 424)
        Me.q2002labelans.Name = "q2002labelans"
        Me.q2002labelans.Size = New System.Drawing.Size(139, 39)
        Me.q2002labelans.TabIndex = 16
        Me.q2002labelans.Text = "Answer:"
        '
        'q2002ans
        '
        Me.q2002ans.BackColor = System.Drawing.Color.Black
        Me.q2002ans.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q2002ans.ForeColor = System.Drawing.Color.Red
        Me.q2002ans.Location = New System.Drawing.Point(380, 421)
        Me.q2002ans.Name = "q2002ans"
        Me.q2002ans.Size = New System.Drawing.Size(346, 42)
        Me.q2002ans.TabIndex = 17
        '
        'Nextq2002
        '
        Me.Nextq2002.BackgroundImage = CType(resources.GetObject("Nextq2002.BackgroundImage"), System.Drawing.Image)
        Me.Nextq2002.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Nextq2002.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nextq2002.ForeColor = System.Drawing.Color.Black
        Me.Nextq2002.Location = New System.Drawing.Point(694, 479)
        Me.Nextq2002.Name = "Nextq2002"
        Me.Nextq2002.Size = New System.Drawing.Size(207, 78)
        Me.Nextq2002.TabIndex = 18
        Me.Nextq2002.Text = "Next"
        Me.Nextq2002.UseVisualStyleBackColor = True
        '
        'q2002form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.Nextq2002)
        Me.Controls.Add(Me.q2002ans)
        Me.Controls.Add(Me.q2002labelans)
        Me.Controls.Add(Me.q2002borderans)
        Me.Controls.Add(Me.q2002text)
        Me.Controls.Add(Me.q2002border)
        Me.Controls.Add(Me.q2002back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "q2002form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "q2002form"
        CType(Me.q2002back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q2002border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q2002borderans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents q2002back As PictureBox
    Friend WithEvents q2002border As PictureBox
    Friend WithEvents q2002text As Label
    Friend WithEvents q2002borderans As PictureBox
    Friend WithEvents q2002labelans As Label
    Friend WithEvents q2002ans As TextBox
    Friend WithEvents Nextq2002 As Button
End Class
