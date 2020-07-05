<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class q4001form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(q4001form))
        Me.q4001back = New System.Windows.Forms.PictureBox()
        Me.q4001border = New System.Windows.Forms.PictureBox()
        Me.q4001text = New System.Windows.Forms.Label()
        Me.Nextq4001 = New System.Windows.Forms.Button()
        Me.Panelq4001 = New System.Windows.Forms.Panel()
        Me.q4001ans = New System.Windows.Forms.TextBox()
        Me.labelansq4001 = New System.Windows.Forms.Label()
        Me.borderanslabelq4001 = New System.Windows.Forms.PictureBox()
        CType(Me.q4001back, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.q4001border, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panelq4001.SuspendLayout()
        CType(Me.borderanslabelq4001, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'q4001back
        '
        Me.q4001back.Image = Global.Jeopardy.My.Resources.Resources.Stage_curtains
        Me.q4001back.Location = New System.Drawing.Point(0, -2)
        Me.q4001back.Name = "q4001back"
        Me.q4001back.Size = New System.Drawing.Size(913, 575)
        Me.q4001back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q4001back.TabIndex = 3
        Me.q4001back.TabStop = False
        '
        'q4001border
        '
        Me.q4001border.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.q4001border.Location = New System.Drawing.Point(52, 26)
        Me.q4001border.Name = "q4001border"
        Me.q4001border.Size = New System.Drawing.Size(787, 303)
        Me.q4001border.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.q4001border.TabIndex = 10
        Me.q4001border.TabStop = False
        '
        'q4001text
        '
        Me.q4001text.BackColor = System.Drawing.Color.Black
        Me.q4001text.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q4001text.ForeColor = System.Drawing.Color.Red
        Me.q4001text.Location = New System.Drawing.Point(78, 38)
        Me.q4001text.Name = "q4001text"
        Me.q4001text.Size = New System.Drawing.Size(734, 278)
        Me.q4001text.TabIndex = 12
        Me.q4001text.Text = "What is considered to be the first commercial video game?"
        Me.q4001text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Nextq4001
        '
        Me.Nextq4001.BackgroundImage = CType(resources.GetObject("Nextq4001.BackgroundImage"), System.Drawing.Image)
        Me.Nextq4001.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Nextq4001.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nextq4001.ForeColor = System.Drawing.Color.Black
        Me.Nextq4001.Location = New System.Drawing.Point(694, 479)
        Me.Nextq4001.Name = "Nextq4001"
        Me.Nextq4001.Size = New System.Drawing.Size(207, 78)
        Me.Nextq4001.TabIndex = 21
        Me.Nextq4001.Text = "Next"
        Me.Nextq4001.UseVisualStyleBackColor = True
        '
        'Panelq4001
        '
        Me.Panelq4001.Controls.Add(Me.q4001ans)
        Me.Panelq4001.Controls.Add(Me.labelansq4001)
        Me.Panelq4001.Controls.Add(Me.borderanslabelq4001)
        Me.Panelq4001.Location = New System.Drawing.Point(192, 411)
        Me.Panelq4001.Name = "Panelq4001"
        Me.Panelq4001.Size = New System.Drawing.Size(555, 61)
        Me.Panelq4001.TabIndex = 25
        '
        'q4001ans
        '
        Me.q4001ans.BackColor = System.Drawing.Color.Black
        Me.q4001ans.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.q4001ans.ForeColor = System.Drawing.Color.Red
        Me.q4001ans.Location = New System.Drawing.Point(188, 9)
        Me.q4001ans.Name = "q4001ans"
        Me.q4001ans.Size = New System.Drawing.Size(346, 42)
        Me.q4001ans.TabIndex = 22
        '
        'labelansq4001
        '
        Me.labelansq4001.BackColor = System.Drawing.Color.Black
        Me.labelansq4001.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelansq4001.ForeColor = System.Drawing.Color.Red
        Me.labelansq4001.Location = New System.Drawing.Point(21, 12)
        Me.labelansq4001.Name = "labelansq4001"
        Me.labelansq4001.Size = New System.Drawing.Size(139, 39)
        Me.labelansq4001.TabIndex = 23
        Me.labelansq4001.Text = "Answer:"
        '
        'borderanslabelq4001
        '
        Me.borderanslabelq4001.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.borderanslabelq4001.Location = New System.Drawing.Point(0, 0)
        Me.borderanslabelq4001.Name = "borderanslabelq4001"
        Me.borderanslabelq4001.Size = New System.Drawing.Size(555, 62)
        Me.borderanslabelq4001.TabIndex = 21
        Me.borderanslabelq4001.TabStop = False
        '
        'q4001form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.Panelq4001)
        Me.Controls.Add(Me.Nextq4001)
        Me.Controls.Add(Me.q4001text)
        Me.Controls.Add(Me.q4001border)
        Me.Controls.Add(Me.q4001back)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "q4001form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "q4001form"
        CType(Me.q4001back, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.q4001border, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panelq4001.ResumeLayout(False)
        Me.Panelq4001.PerformLayout()
        CType(Me.borderanslabelq4001, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents q4001back As PictureBox
    Friend WithEvents q4001border As PictureBox
    Friend WithEvents q4001text As Label
    Friend WithEvents Nextq4001 As Button
    Friend WithEvents Panelq4001 As Panel
    Friend WithEvents q4001ans As TextBox
    Friend WithEvents labelansq4001 As Label
    Friend WithEvents borderanslabelq4001 As PictureBox
End Class
