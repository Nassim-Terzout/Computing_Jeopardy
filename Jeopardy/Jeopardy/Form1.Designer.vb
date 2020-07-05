<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Startmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Startmenu))
        Me.pname = New System.Windows.Forms.TextBox()
        Me.Usernameimport = New System.Windows.Forms.Label()
        Me.namewarning = New System.Windows.Forms.Label()
        Me.Exitstart = New System.Windows.Forms.Button()
        Me.Instructionsbutton = New System.Windows.Forms.Button()
        Me.startButton = New System.Windows.Forms.Button()
        Me.pnameborder = New System.Windows.Forms.PictureBox()
        Me.Borderwarning = New System.Windows.Forms.PictureBox()
        Me.startback = New System.Windows.Forms.PictureBox()
        CType(Me.pnameborder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Borderwarning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.startback, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pname
        '
        Me.pname.BackColor = System.Drawing.Color.Black
        Me.pname.Font = New System.Drawing.Font("Palatino Linotype", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pname.ForeColor = System.Drawing.Color.Red
        Me.pname.Location = New System.Drawing.Point(467, 287)
        Me.pname.Name = "pname"
        Me.pname.Size = New System.Drawing.Size(246, 44)
        Me.pname.TabIndex = 6
        '
        'Usernameimport
        '
        Me.Usernameimport.BackColor = System.Drawing.Color.Black
        Me.Usernameimport.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usernameimport.ForeColor = System.Drawing.Color.Red
        Me.Usernameimport.Location = New System.Drawing.Point(63, 287)
        Me.Usernameimport.Name = "Usernameimport"
        Me.Usernameimport.Size = New System.Drawing.Size(353, 39)
        Me.Usernameimport.TabIndex = 5
        Me.Usernameimport.Text = "Please enter a name:"
        '
        'namewarning
        '
        Me.namewarning.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.namewarning.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namewarning.ForeColor = System.Drawing.Color.Red
        Me.namewarning.Location = New System.Drawing.Point(194, 392)
        Me.namewarning.Name = "namewarning"
        Me.namewarning.Size = New System.Drawing.Size(507, 48)
        Me.namewarning.TabIndex = 7
        Me.namewarning.Text = "You need a name to continue!!"
        Me.namewarning.Visible = False
        '
        'Exitstart
        '
        Me.Exitstart.BackgroundImage = CType(resources.GetObject("Exitstart.BackgroundImage"), System.Drawing.Image)
        Me.Exitstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Exitstart.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitstart.ForeColor = System.Drawing.Color.Black
        Me.Exitstart.Location = New System.Drawing.Point(694, 479)
        Me.Exitstart.Name = "Exitstart"
        Me.Exitstart.Size = New System.Drawing.Size(207, 78)
        Me.Exitstart.TabIndex = 3
        Me.Exitstart.Text = "Exit"
        Me.Exitstart.UseVisualStyleBackColor = True
        '
        'Instructionsbutton
        '
        Me.Instructionsbutton.BackgroundImage = CType(resources.GetObject("Instructionsbutton.BackgroundImage"), System.Drawing.Image)
        Me.Instructionsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Instructionsbutton.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instructionsbutton.ForeColor = System.Drawing.Color.Black
        Me.Instructionsbutton.Location = New System.Drawing.Point(346, 479)
        Me.Instructionsbutton.Name = "Instructionsbutton"
        Me.Instructionsbutton.Size = New System.Drawing.Size(207, 78)
        Me.Instructionsbutton.TabIndex = 2
        Me.Instructionsbutton.Text = "Instructions"
        Me.Instructionsbutton.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.BackgroundImage = CType(resources.GetObject("startButton.BackgroundImage"), System.Drawing.Image)
        Me.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.startButton.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButton.ForeColor = System.Drawing.Color.Black
        Me.startButton.Location = New System.Drawing.Point(12, 479)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(207, 78)
        Me.startButton.TabIndex = 1
        Me.startButton.Text = "Start!"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'pnameborder
        '
        Me.pnameborder.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.pnameborder.Location = New System.Drawing.Point(49, 275)
        Me.pnameborder.Name = "pnameborder"
        Me.pnameborder.Size = New System.Drawing.Size(381, 62)
        Me.pnameborder.TabIndex = 8
        Me.pnameborder.TabStop = False
        '
        'Borderwarning
        '
        Me.Borderwarning.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.Borderwarning.Location = New System.Drawing.Point(181, 383)
        Me.Borderwarning.Name = "Borderwarning"
        Me.Borderwarning.Size = New System.Drawing.Size(532, 67)
        Me.Borderwarning.TabIndex = 9
        Me.Borderwarning.TabStop = False
        Me.Borderwarning.Visible = False
        '
        'startback
        '
        Me.startback.BackgroundImage = Global.Jeopardy.My.Resources.Resources.rtytrtrtr_tis_gfrete
        Me.startback.Image = Global.Jeopardy.My.Resources.Resources.rtytrtrtr_tis_gfrete
        Me.startback.Location = New System.Drawing.Point(0, 0)
        Me.startback.Name = "startback"
        Me.startback.Size = New System.Drawing.Size(913, 569)
        Me.startback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.startback.TabIndex = 4
        Me.startback.TabStop = False
        '
        'Startmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.namewarning)
        Me.Controls.Add(Me.pname)
        Me.Controls.Add(Me.Usernameimport)
        Me.Controls.Add(Me.Exitstart)
        Me.Controls.Add(Me.Instructionsbutton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.pnameborder)
        Me.Controls.Add(Me.Borderwarning)
        Me.Controls.Add(Me.startback)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Startmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jeopardy Menu"
        CType(Me.pnameborder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Borderwarning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.startback, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents startButton As Button
    Friend WithEvents Instructionsbutton As Button
    Friend WithEvents Exitstart As Button
    Friend WithEvents startback As PictureBox
    Friend WithEvents Usernameimport As Label
    Friend WithEvents pname As TextBox
    Friend WithEvents pnameborder As PictureBox
    Friend WithEvents Borderwarning As PictureBox
    Friend WithEvents namewarning As Label
End Class
