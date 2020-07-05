<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dailydouble
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dailydouble))
        Me.dailydoubletext = New System.Windows.Forms.Label()
        Me.dailydouble1next = New System.Windows.Forms.Button()
        Me.dailydoubleborder = New System.Windows.Forms.PictureBox()
        Me.dailydoubleback = New System.Windows.Forms.PictureBox()
        CType(Me.dailydoubleborder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dailydoubleback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dailydoubletext
        '
        Me.dailydoubletext.BackColor = System.Drawing.Color.Black
        Me.dailydoubletext.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dailydoubletext.ForeColor = System.Drawing.Color.Red
        Me.dailydoubletext.Location = New System.Drawing.Point(89, 145)
        Me.dailydoubletext.Name = "dailydoubletext"
        Me.dailydoubletext.Size = New System.Drawing.Size(734, 278)
        Me.dailydoubletext.TabIndex = 12
        Me.dailydoubletext.Text = "Well done! You have completed all the questions and ended with a positive score! " &
    "The next question will give you the opportunity to double your points!"
        Me.dailydoubletext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dailydouble1next
        '
        Me.dailydouble1next.BackgroundImage = CType(resources.GetObject("dailydouble1next.BackgroundImage"), System.Drawing.Image)
        Me.dailydouble1next.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.dailydouble1next.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dailydouble1next.ForeColor = System.Drawing.Color.Black
        Me.dailydouble1next.Location = New System.Drawing.Point(694, 479)
        Me.dailydouble1next.Name = "dailydouble1next"
        Me.dailydouble1next.Size = New System.Drawing.Size(207, 78)
        Me.dailydouble1next.TabIndex = 16
        Me.dailydouble1next.Text = "Next"
        Me.dailydouble1next.UseVisualStyleBackColor = True
        '
        'dailydoubleborder
        '
        Me.dailydoubleborder.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.dailydoubleborder.Location = New System.Drawing.Point(63, 133)
        Me.dailydoubleborder.Name = "dailydoubleborder"
        Me.dailydoubleborder.Size = New System.Drawing.Size(787, 303)
        Me.dailydoubleborder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dailydoubleborder.TabIndex = 11
        Me.dailydoubleborder.TabStop = False
        '
        'dailydoubleback
        '
        Me.dailydoubleback.Image = Global.Jeopardy.My.Resources.Resources.Stage_curtains
        Me.dailydoubleback.Location = New System.Drawing.Point(-1, -2)
        Me.dailydoubleback.Name = "dailydoubleback"
        Me.dailydoubleback.Size = New System.Drawing.Size(914, 573)
        Me.dailydoubleback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dailydoubleback.TabIndex = 2
        Me.dailydoubleback.TabStop = False
        '
        'Dailydouble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.dailydouble1next)
        Me.Controls.Add(Me.dailydoubletext)
        Me.Controls.Add(Me.dailydoubleborder)
        Me.Controls.Add(Me.dailydoubleback)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dailydouble"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dailydouble"
        CType(Me.dailydoubleborder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dailydoubleback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dailydoubleback As PictureBox
    Friend WithEvents dailydoubleborder As PictureBox
    Friend WithEvents dailydoubletext As Label
    Friend WithEvents dailydouble1next As Button
End Class
