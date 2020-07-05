<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dailydoubleq
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dailydoubleq))
        Me.dailydoubleqback = New System.Windows.Forms.PictureBox()
        Me.dailydoubleqborder = New System.Windows.Forms.PictureBox()
        Me.dailydoubleqtext = New System.Windows.Forms.Label()
        Me.ddansborder = New System.Windows.Forms.PictureBox()
        Me.ddanslabel = New System.Windows.Forms.Label()
        Me.ddans = New System.Windows.Forms.TextBox()
        Me.Nextdd = New System.Windows.Forms.Button()
        CType(Me.dailydoubleqback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dailydoubleqborder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ddansborder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dailydoubleqback
        '
        Me.dailydoubleqback.Image = Global.Jeopardy.My.Resources.Resources.Stage_curtains
        Me.dailydoubleqback.Location = New System.Drawing.Point(0, -2)
        Me.dailydoubleqback.Name = "dailydoubleqback"
        Me.dailydoubleqback.Size = New System.Drawing.Size(913, 573)
        Me.dailydoubleqback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dailydoubleqback.TabIndex = 4
        Me.dailydoubleqback.TabStop = False
        '
        'dailydoubleqborder
        '
        Me.dailydoubleqborder.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.dailydoubleqborder.Location = New System.Drawing.Point(58, 64)
        Me.dailydoubleqborder.Name = "dailydoubleqborder"
        Me.dailydoubleqborder.Size = New System.Drawing.Size(787, 303)
        Me.dailydoubleqborder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dailydoubleqborder.TabIndex = 12
        Me.dailydoubleqborder.TabStop = False
        '
        'dailydoubleqtext
        '
        Me.dailydoubleqtext.BackColor = System.Drawing.Color.Black
        Me.dailydoubleqtext.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dailydoubleqtext.ForeColor = System.Drawing.Color.Red
        Me.dailydoubleqtext.Location = New System.Drawing.Point(85, 75)
        Me.dailydoubleqtext.Name = "dailydoubleqtext"
        Me.dailydoubleqtext.Size = New System.Drawing.Size(734, 278)
        Me.dailydoubleqtext.TabIndex = 13
        Me.dailydoubleqtext.Text = "What language is this program written in?"
        Me.dailydoubleqtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ddansborder
        '
        Me.ddansborder.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.ddansborder.Location = New System.Drawing.Point(175, 373)
        Me.ddansborder.Name = "ddansborder"
        Me.ddansborder.Size = New System.Drawing.Size(556, 62)
        Me.ddansborder.TabIndex = 15
        Me.ddansborder.TabStop = False
        '
        'ddanslabel
        '
        Me.ddanslabel.BackColor = System.Drawing.Color.Black
        Me.ddanslabel.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddanslabel.ForeColor = System.Drawing.Color.Red
        Me.ddanslabel.Location = New System.Drawing.Point(204, 383)
        Me.ddanslabel.Name = "ddanslabel"
        Me.ddanslabel.Size = New System.Drawing.Size(139, 39)
        Me.ddanslabel.TabIndex = 16
        Me.ddanslabel.Text = "Answer:"
        '
        'ddans
        '
        Me.ddans.BackColor = System.Drawing.Color.Black
        Me.ddans.Font = New System.Drawing.Font("Modern No. 20", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddans.ForeColor = System.Drawing.Color.Red
        Me.ddans.Location = New System.Drawing.Point(349, 382)
        Me.ddans.Name = "ddans"
        Me.ddans.Size = New System.Drawing.Size(346, 42)
        Me.ddans.TabIndex = 17
        '
        'Nextdd
        '
        Me.Nextdd.BackgroundImage = CType(resources.GetObject("Nextdd.BackgroundImage"), System.Drawing.Image)
        Me.Nextdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Nextdd.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nextdd.ForeColor = System.Drawing.Color.Black
        Me.Nextdd.Location = New System.Drawing.Point(694, 479)
        Me.Nextdd.Name = "Nextdd"
        Me.Nextdd.Size = New System.Drawing.Size(207, 78)
        Me.Nextdd.TabIndex = 18
        Me.Nextdd.Text = "Next"
        Me.Nextdd.UseVisualStyleBackColor = True
        '
        'Dailydoubleq
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.Nextdd)
        Me.Controls.Add(Me.ddans)
        Me.Controls.Add(Me.ddanslabel)
        Me.Controls.Add(Me.ddansborder)
        Me.Controls.Add(Me.dailydoubleqtext)
        Me.Controls.Add(Me.dailydoubleqborder)
        Me.Controls.Add(Me.dailydoubleqback)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Dailydoubleq"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dailydoubleq"
        CType(Me.dailydoubleqback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dailydoubleqborder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ddansborder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dailydoubleqback As PictureBox
    Friend WithEvents dailydoubleqborder As PictureBox
    Friend WithEvents dailydoubleqtext As Label
    Friend WithEvents ddansborder As PictureBox
    Friend WithEvents ddanslabel As Label
    Friend WithEvents ddans As TextBox
    Friend WithEvents Nextdd As Button
End Class
