<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class q3001form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q3001form))
        Me.q3001back = New System.Windows.Forms.PictureBox()
        Me.q3001border = New System.Windows.Forms.PictureBox()
        Me.q3001text = New System.Windows.Forms.Label()
        Me.Nextq3001 = New System.Windows.Forms.Button()
        Me.borderanslabelq3001 = New System.Windows.Forms.PictureBox()
        Me.q3001ans = New System.Windows.Forms.TextBox()
        Me.labelansq3001 = New System.Windows.Forms.Label()
        Me.Panelq3001 = New System.Windows.Forms.Panel()
        CType(Me.q3001back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q3001border, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.borderanslabelq3001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelq3001.SuspendLayout()
        Me.SuspendLayout()
        '
        'q3001back
        '
        Me.q3001back.Image = Global.Jeopardy.My.Resources.Resources.Stage_curtains
        Me.q3001back.Location = New System.Drawing.Point(0, -2)
        Me.q3001back.Name = "q3001back"
        Me.q3001back.Size = New System.Drawing.Size(913, 575)
        Me.q3001back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q3001back.TabIndex = 3
        Me.q3001back.TabStop = False
        '
        'q3001border
        '
        Me.q3001border.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.q3001border.Location = New System.Drawing.Point(52, 26)
        Me.q3001border.Name = "q3001border"
        Me.q3001border.Size = New System.Drawing.Size(787, 303)
        Me.q3001border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q3001border.TabIndex = 10
        Me.q3001border.TabStop = False
        '
        'q3001text
        '
        Me.q3001text.BackColor = System.Drawing.Color.Black
        Me.q3001text.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q3001text.ForeColor = System.Drawing.Color.Red
        Me.q3001text.Location = New System.Drawing.Point(78, 38)
        Me.q3001text.Name = "q3001text"
        Me.q3001text.Size = New System.Drawing.Size(734, 278)
        Me.q3001text.TabIndex = 12
        Me.q3001text.Text = "What control do you use in order to create a multiple choice question?"
        Me.q3001text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Nextq3001
        '
        Me.Nextq3001.BackgroundImage = CType(resources.GetObject("Nextq3001.BackgroundImage"), System.Drawing.Image)
        Me.Nextq3001.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Nextq3001.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nextq3001.ForeColor = System.Drawing.Color.Black
        Me.Nextq3001.Location = New System.Drawing.Point(694, 479)
        Me.Nextq3001.Name = "Nextq3001"
        Me.Nextq3001.Size = New System.Drawing.Size(207, 78)
        Me.Nextq3001.TabIndex = 20
        Me.Nextq3001.Text = "Next"
        Me.Nextq3001.UseVisualStyleBackColor = True
        '
        'borderanslabelq3001
        '
        Me.borderanslabelq3001.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.borderanslabelq3001.Location = New System.Drawing.Point(0, 0)
        Me.borderanslabelq3001.Name = "borderanslabelq3001"
        Me.borderanslabelq3001.Size = New System.Drawing.Size(555, 62)
        Me.borderanslabelq3001.TabIndex = 21
        Me.borderanslabelq3001.TabStop = False
        '
        'q3001ans
        '
        Me.q3001ans.BackColor = System.Drawing.Color.Black
        Me.q3001ans.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q3001ans.ForeColor = System.Drawing.Color.Red
        Me.q3001ans.Location = New System.Drawing.Point(188, 9)
        Me.q3001ans.Name = "q3001ans"
        Me.q3001ans.Size = New System.Drawing.Size(346, 42)
        Me.q3001ans.TabIndex = 22
        '
        'labelansq3001
        '
        Me.labelansq3001.BackColor = System.Drawing.Color.Black
        Me.labelansq3001.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelansq3001.ForeColor = System.Drawing.Color.Red
        Me.labelansq3001.Location = New System.Drawing.Point(21, 12)
        Me.labelansq3001.Name = "labelansq3001"
        Me.labelansq3001.Size = New System.Drawing.Size(139, 39)
        Me.labelansq3001.TabIndex = 23
        Me.labelansq3001.Text = "Answer:"
        '
        'Panelq3001
        '
        Me.Panelq3001.Controls.Add(Me.q3001ans)
        Me.Panelq3001.Controls.Add(Me.labelansq3001)
        Me.Panelq3001.Controls.Add(Me.borderanslabelq3001)
        Me.Panelq3001.Location = New System.Drawing.Point(192, 411)
        Me.Panelq3001.Name = "Panelq3001"
        Me.Panelq3001.Size = New System.Drawing.Size(555, 61)
        Me.Panelq3001.TabIndex = 24
        '
        'q3001form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.Nextq3001)
        Me.Controls.Add(Me.q3001text)
        Me.Controls.Add(Me.q3001border)
        Me.Controls.Add(Me.Panelq3001)
        Me.Controls.Add(Me.q3001back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "q3001form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "q3001form"
        CType(Me.q3001back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q3001border, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.borderanslabelq3001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelq3001.ResumeLayout(False)
        Me.Panelq3001.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents q3001back As PictureBox
    Friend WithEvents q3001border As PictureBox
    Friend WithEvents q3001text As Label
    Friend WithEvents Nextq3001 As Button
    Friend WithEvents borderanslabelq3001 As PictureBox
    Friend WithEvents q3001ans As TextBox
    Friend WithEvents labelansq3001 As Label
    Friend WithEvents Panelq3001 As Panel
End Class
