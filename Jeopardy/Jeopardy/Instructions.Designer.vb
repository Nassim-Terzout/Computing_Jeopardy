<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Instructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Instructions))
        Me.Instructionstext = New System.Windows.Forms.Label()
        Me.Startinstructions = New System.Windows.Forms.Button()
        Me.Returnmain = New System.Windows.Forms.Button()
        Me.Exitinstructions = New System.Windows.Forms.Button()
        Me.Borderinstructions = New System.Windows.Forms.PictureBox()
        Me.Backgroundinstructions = New System.Windows.Forms.PictureBox()
        CType(Me.Borderinstructions, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Backgroundinstructions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Instructionstext
        '
        Me.Instructionstext.BackColor = System.Drawing.Color.Black
        Me.Instructionstext.Font = New System.Drawing.Font("Cooper Black", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Instructionstext.ForeColor = System.Drawing.Color.Red
        Me.Instructionstext.Location = New System.Drawing.Point(131, 234)
        Me.Instructionstext.Name = "Instructionstext"
        Me.Instructionstext.Size = New System.Drawing.Size(646, 182)
        Me.Instructionstext.TabIndex = 1
        Me.Instructionstext.Text = resources.GetString("Instructionstext.Text")
        '
        'Startinstructions
        '
        Me.Startinstructions.BackgroundImage = CType(resources.GetObject("Startinstructions.BackgroundImage"), System.Drawing.Image)
        Me.Startinstructions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Startinstructions.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Startinstructions.ForeColor = System.Drawing.Color.Black
        Me.Startinstructions.Location = New System.Drawing.Point(597, 479)
        Me.Startinstructions.Name = "Startinstructions"
        Me.Startinstructions.Size = New System.Drawing.Size(207, 78)
        Me.Startinstructions.TabIndex = 6
        Me.Startinstructions.Text = "Start"
        Me.Startinstructions.UseVisualStyleBackColor = True
        '
        'Returnmain
        '
        Me.Returnmain.BackgroundImage = CType(resources.GetObject("Returnmain.BackgroundImage"), System.Drawing.Image)
        Me.Returnmain.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Returnmain.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Returnmain.ForeColor = System.Drawing.Color.Black
        Me.Returnmain.Location = New System.Drawing.Point(353, 479)
        Me.Returnmain.Name = "Returnmain"
        Me.Returnmain.Size = New System.Drawing.Size(207, 78)
        Me.Returnmain.TabIndex = 5
        Me.Returnmain.Text = "Return"
        Me.Returnmain.UseVisualStyleBackColor = True
        '
        'Exitinstructions
        '
        Me.Exitinstructions.BackgroundImage = CType(resources.GetObject("Exitinstructions.BackgroundImage"), System.Drawing.Image)
        Me.Exitinstructions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Exitinstructions.Font = New System.Drawing.Font("Cooper Black", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitinstructions.ForeColor = System.Drawing.Color.Black
        Me.Exitinstructions.Location = New System.Drawing.Point(106, 479)
        Me.Exitinstructions.Name = "Exitinstructions"
        Me.Exitinstructions.Size = New System.Drawing.Size(207, 78)
        Me.Exitinstructions.TabIndex = 4
        Me.Exitinstructions.Text = "Exit"
        Me.Exitinstructions.UseVisualStyleBackColor = True
        '
        'Borderinstructions
        '
        Me.Borderinstructions.Image = Global.Jeopardy.My.Resources.Resources.chalkboard
        Me.Borderinstructions.Location = New System.Drawing.Point(106, 222)
        Me.Borderinstructions.Name = "Borderinstructions"
        Me.Borderinstructions.Size = New System.Drawing.Size(698, 204)
        Me.Borderinstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Borderinstructions.TabIndex = 2
        Me.Borderinstructions.TabStop = False
        '
        'Backgroundinstructions
        '
        Me.Backgroundinstructions.Image = Global.Jeopardy.My.Resources.Resources.Instrcutionsbackgood_copy
        Me.Backgroundinstructions.Location = New System.Drawing.Point(0, -1)
        Me.Backgroundinstructions.Name = "Backgroundinstructions"
        Me.Backgroundinstructions.Size = New System.Drawing.Size(913, 575)
        Me.Backgroundinstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Backgroundinstructions.TabIndex = 0
        Me.Backgroundinstructions.TabStop = False
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 569)
        Me.Controls.Add(Me.Startinstructions)
        Me.Controls.Add(Me.Returnmain)
        Me.Controls.Add(Me.Exitinstructions)
        Me.Controls.Add(Me.Instructionstext)
        Me.Controls.Add(Me.Borderinstructions)
        Me.Controls.Add(Me.Backgroundinstructions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Instructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructions"
        CType(Me.Borderinstructions, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Backgroundinstructions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Backgroundinstructions As PictureBox
    Friend WithEvents Instructionstext As Label
    Friend WithEvents Borderinstructions As PictureBox
    Friend WithEvents Exitinstructions As Button
    Friend WithEvents Returnmain As Button
    Friend WithEvents Startinstructions As Button
End Class
