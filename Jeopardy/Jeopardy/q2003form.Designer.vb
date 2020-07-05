<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class q2003form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q2003form))
        Me.q2003back = New System.Windows.Forms.PictureBox()
        Me.q2003border = New System.Windows.Forms.PictureBox()
        Me.q2003text = New System.Windows.Forms.Label()
        Me.q2003borderans = New System.Windows.Forms.PictureBox()
        Me.q2003labelans = New System.Windows.Forms.Label()
        Me.q2003ans = New System.Windows.Forms.TextBox()
        Me.Nextq2003 = New System.Windows.Forms.Button()
        CType(Me.q2003back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q2003border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q2003borderans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'q2003back
        '
        Me.q2003back.Image = Global.Jeopardy.My.Resources.Resources.Stage_curtains
        Me.q2003back.Location = New System.Drawing.Point(0, -2)
        Me.q2003back.Name = "q2003back"
        Me.q2003back.Size = New System.Drawing.Size(913, 573)
        Me.q2003back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q2003back.TabIndex = 3
        Me.q2003back.TabStop = False
        '
        'q2003border
        '
        Me.q2003border.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.q2003border.Location = New System.Drawing.Point(52, 26)
        Me.q2003border.Name = "q2003border"
        Me.q2003border.Size = New System.Drawing.Size(787, 303)
        Me.q2003border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q2003border.TabIndex = 10
        Me.q2003border.TabStop = False
        '
        'q2003text
        '
        Me.q2003text.BackColor = System.Drawing.Color.Black
        Me.q2003text.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q2003text.ForeColor = System.Drawing.Color.Red
        Me.q2003text.Location = New System.Drawing.Point(78, 38)
        Me.q2003text.Name = "q2003text"
        Me.q2003text.Size = New System.Drawing.Size(734, 278)
        Me.q2003text.TabIndex = 12
        Me.q2003text.Text = "Which piece of hardware is designed to process graphics?"
        Me.q2003text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'q2003borderans
        '
        Me.q2003borderans.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.q2003borderans.Location = New System.Drawing.Point(192, 411)
        Me.q2003borderans.Name = "q2003borderans"
        Me.q2003borderans.Size = New System.Drawing.Size(556, 62)
        Me.q2003borderans.TabIndex = 16
        Me.q2003borderans.TabStop = False
        '
        'q2003labelans
        '
        Me.q2003labelans.BackColor = System.Drawing.Color.Black
        Me.q2003labelans.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q2003labelans.ForeColor = System.Drawing.Color.Red
        Me.q2003labelans.Location = New System.Drawing.Point(213, 424)
        Me.q2003labelans.Name = "q2003labelans"
        Me.q2003labelans.Size = New System.Drawing.Size(139, 39)
        Me.q2003labelans.TabIndex = 17
        Me.q2003labelans.Text = "Answer:"
        '
        'q2003ans
        '
        Me.q2003ans.BackColor = System.Drawing.Color.Black
        Me.q2003ans.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q2003ans.ForeColor = System.Drawing.Color.Red
        Me.q2003ans.Location = New System.Drawing.Point(380, 421)
        Me.q2003ans.Name = "q2003ans"
        Me.q2003ans.Size = New System.Drawing.Size(346, 42)
        Me.q2003ans.TabIndex = 18
        '
        'Nextq2003
        '
        Me.Nextq2003.BackgroundImage = CType(resources.GetObject("Nextq2003.BackgroundImage"), System.Drawing.Image)
        Me.Nextq2003.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Nextq2003.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nextq2003.ForeColor = System.Drawing.Color.Black
        Me.Nextq2003.Location = New System.Drawing.Point(694, 479)
        Me.Nextq2003.Name = "Nextq2003"
        Me.Nextq2003.Size = New System.Drawing.Size(207, 78)
        Me.Nextq2003.TabIndex = 19
        Me.Nextq2003.Text = "Next"
        Me.Nextq2003.UseVisualStyleBackColor = True
        '
        'q2003form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.Nextq2003)
        Me.Controls.Add(Me.q2003ans)
        Me.Controls.Add(Me.q2003labelans)
        Me.Controls.Add(Me.q2003borderans)
        Me.Controls.Add(Me.q2003text)
        Me.Controls.Add(Me.q2003border)
        Me.Controls.Add(Me.q2003back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "q2003form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "q2003form"
        CType(Me.q2003back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q2003border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q2003borderans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents q2003back As PictureBox
    Friend WithEvents q2003border As PictureBox
    Friend WithEvents q2003text As Label
    Friend WithEvents q2003borderans As PictureBox
    Friend WithEvents q2003labelans As Label
    Friend WithEvents q2003ans As TextBox
    Friend WithEvents Nextq2003 As Button
End Class
