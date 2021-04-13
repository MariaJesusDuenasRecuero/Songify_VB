<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Songs
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.songName = New System.Windows.Forms.Label()
        Me.AlbumSong = New System.Windows.Forms.Label()
        Me.SongLength = New System.Windows.Forms.Label()
        Me.GoBackBtn = New System.Windows.Forms.Button()
        Me.lbl_profile = New System.Windows.Forms.Label()
        Me.EmailLog = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Songtxt = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Play = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(61, 64)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(220, 459)
        Me.ListBox1.TabIndex = 0
        '
        'songName
        '
        Me.songName.AutoSize = True
        Me.songName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.songName.Location = New System.Drawing.Point(326, 104)
        Me.songName.Name = "songName"
        Me.songName.Size = New System.Drawing.Size(77, 26)
        Me.songName.TabIndex = 1
        Me.songName.Text = "Label1"
        '
        'AlbumSong
        '
        Me.AlbumSong.AutoSize = True
        Me.AlbumSong.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.AlbumSong.Location = New System.Drawing.Point(326, 230)
        Me.AlbumSong.Name = "AlbumSong"
        Me.AlbumSong.Size = New System.Drawing.Size(77, 26)
        Me.AlbumSong.TabIndex = 2
        Me.AlbumSong.Text = "Label2"
        '
        'SongLength
        '
        Me.SongLength.AutoSize = True
        Me.SongLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.SongLength.Location = New System.Drawing.Point(326, 356)
        Me.SongLength.Name = "SongLength"
        Me.SongLength.Size = New System.Drawing.Size(77, 26)
        Me.SongLength.TabIndex = 3
        Me.SongLength.Text = "Label3"
        '
        'GoBackBtn
        '
        Me.GoBackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GoBackBtn.Location = New System.Drawing.Point(61, 620)
        Me.GoBackBtn.Name = "GoBackBtn"
        Me.GoBackBtn.Size = New System.Drawing.Size(103, 42)
        Me.GoBackBtn.TabIndex = 12
        Me.GoBackBtn.Text = "Back"
        Me.GoBackBtn.UseVisualStyleBackColor = True
        '
        'lbl_profile
        '
        Me.lbl_profile.AutoSize = True
        Me.lbl_profile.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profile.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_profile.Location = New System.Drawing.Point(12, 18)
        Me.lbl_profile.Name = "lbl_profile"
        Me.lbl_profile.Size = New System.Drawing.Size(126, 23)
        Me.lbl_profile.TabIndex = 13
        Me.lbl_profile.Text = "Logged as:"
        '
        'EmailLog
        '
        Me.EmailLog.AutoSize = True
        Me.EmailLog.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLog.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.EmailLog.Location = New System.Drawing.Point(175, 18)
        Me.EmailLog.Name = "EmailLog"
        Me.EmailLog.Size = New System.Drawing.Size(61, 23)
        Me.EmailLog.TabIndex = 14
        Me.EmailLog.Text = "rfjpe"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(616, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 284)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Songtxt
        '
        Me.Songtxt.AutoSize = True
        Me.Songtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Songtxt.ForeColor = System.Drawing.Color.White
        Me.Songtxt.Location = New System.Drawing.Point(737, 420)
        Me.Songtxt.Name = "Songtxt"
        Me.Songtxt.Size = New System.Drawing.Size(66, 24)
        Me.Songtxt.TabIndex = 16
        Me.Songtxt.Text = "Label1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(633, 500)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(265, 23)
        Me.ProgressBar1.TabIndex = 17
        '
        'Play
        '
        Me.Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Play.Image = Global.Songify.My.Resources.Resources.jugar1
        Me.Play.Location = New System.Drawing.Point(733, 613)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(70, 49)
        Me.Play.TabIndex = 18
        Me.Play.UseVisualStyleBackColor = True
        '
        'Songs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(951, 714)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Songtxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EmailLog)
        Me.Controls.Add(Me.lbl_profile)
        Me.Controls.Add(Me.GoBackBtn)
        Me.Controls.Add(Me.SongLength)
        Me.Controls.Add(Me.AlbumSong)
        Me.Controls.Add(Me.songName)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Songs"
        Me.Text = "Songs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents songName As Label
    Friend WithEvents AlbumSong As Label
    Friend WithEvents SongLength As Label
    Friend WithEvents GoBackBtn As Button
    Friend WithEvents lbl_profile As Label
    Friend WithEvents EmailLog As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Songtxt As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Play As Button
End Class
