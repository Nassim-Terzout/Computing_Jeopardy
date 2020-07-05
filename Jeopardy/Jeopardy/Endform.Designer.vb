<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Endform
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Endform))
        Me.Endingtext = New System.Windows.Forms.Label()
        Me.endgood = New System.Windows.Forms.PictureBox()
        Me.endbad = New System.Windows.Forms.PictureBox()
        Me.Exitend = New System.Windows.Forms.Button()
        Me.Endingborder = New System.Windows.Forms.PictureBox()
        Me.dailydoubleback = New System.Windows.Forms.PictureBox()
        CType(Me.endgood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.endbad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Endingborder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dailydoubleback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Endingtext
        '
        Me.Endingtext.BackColor = System.Drawing.Color.Black
        Me.Endingtext.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Endingtext.ForeColor = System.Drawing.Color.Red
        Me.Endingtext.Location = New System.Drawing.Point(91, 49)
        Me.Endingtext.Name = "Endingtext"
        Me.Endingtext.Size = New System.Drawing.Size(734, 278)
        Me.Endingtext.TabIndex = 11
        Me.Endingtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'endgood
        '
        Me.endgood.ErrorImage = Nothing
        Me.endgood.Image = Global.Jeopardy.My.Resources.Resources.finalgood1
        Me.endgood.Location = New System.Drawing.Point(99, 344)
        Me.endgood.Name = "endgood"
        Me.endgood.Size = New System.Drawing.Size(299, 213)
        Me.endgood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.endgood.TabIndex = 18
        Me.endgood.TabStop = False
        Me.endgood.Visible = False
        '
        'endbad
        '
        Me.endbad.Image = Global.Jeopardy.My.Resources.Resources.bad2
        Me.endbad.Location = New System.Drawing.Point(99, 344)
        Me.endbad.Name = "endbad"
        Me.endbad.Size = New System.Drawing.Size(299, 213)
        Me.endbad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.endbad.TabIndex = 17
        Me.endbad.TabStop = False
        Me.endbad.Visible = False
        '
        'Exitend
        '
        Me.Exitend.BackgroundImage = CType(resources.GetObject("Exitend.BackgroundImage"), System.Drawing.Image)
        Me.Exitend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Exitend.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitend.ForeColor = System.Drawing.Color.Black
        Me.Exitend.Location = New System.Drawing.Point(694, 479)
        Me.Exitend.Name = "Exitend"
        Me.Exitend.Size = New System.Drawing.Size(207, 78)
        Me.Exitend.TabIndex = 16
        Me.Exitend.Text = "Exit"
        Me.Exitend.UseVisualStyleBackColor = True
        '
        'Endingborder
        '
        Me.Endingborder.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.Endingborder.Location = New System.Drawing.Point(64, 35)
        Me.Endingborder.Name = "Endingborder"
        Me.Endingborder.Size = New System.Drawing.Size(787, 303)
        Me.Endingborder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Endingborder.TabIndex = 10
        Me.Endingborder.TabStop = False
        '
        'dailydoubleback
        '
        Me.dailydoubleback.Image = Global.Jeopardy.My.Resources.Resources.Stage_curtains
        Me.dailydoubleback.Location = New System.Drawing.Point(0, 0)
        Me.dailydoubleback.Name = "dailydoubleback"
        Me.dailydoubleback.Size = New System.Drawing.Size(913, 571)
        Me.dailydoubleback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dailydoubleback.TabIndex = 3
        Me.dailydoubleback.TabStop = False
        '
        'Endform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.endgood)
        Me.Controls.Add(Me.endbad)
        Me.Controls.Add(Me.Exitend)
        Me.Controls.Add(Me.Endingtext)
        Me.Controls.Add(Me.Endingborder)
        Me.Controls.Add(Me.dailydoubleback)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Endform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Endform"
        CType(Me.endgood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.endbad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Endingborder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dailydoubleback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dailydoubleback As PictureBox
    Friend WithEvents Endingborder As PictureBox
    Friend WithEvents Endingtext As Label
    Friend WithEvents Exitend As Button
    Friend WithEvents endbad As PictureBox
    Friend WithEvents endgood As PictureBox
End Class
