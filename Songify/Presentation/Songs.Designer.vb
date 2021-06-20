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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Songs))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.songNametxt = New System.Windows.Forms.Label()
        Me.AlbumSongtxt = New System.Windows.Forms.Label()
        Me.SongLengthtxt = New System.Windows.Forms.Label()
        Me.lbl_profile = New System.Windows.Forms.Label()
        Me.EmailLog = New System.Windows.Forms.Label()
        Me.Songtxt = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnHistory = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.songlengthtxtbox = New System.Windows.Forms.TextBox()
        Me.songalbumtxtbox = New System.Windows.Forms.TextBox()
        Me.songnametxtbox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Michi = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Play = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GoBackBtn = New System.Windows.Forms.Button()
        Me.CleanBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(35, 167)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(174, 407)
        Me.ListBox1.TabIndex = 0
        '
        'songNametxt
        '
        Me.songNametxt.AutoSize = True
        Me.songNametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.songNametxt.ForeColor = System.Drawing.Color.White
        Me.songNametxt.Location = New System.Drawing.Point(33, 588)
        Me.songNametxt.Name = "songNametxt"
        Me.songNametxt.Size = New System.Drawing.Size(77, 26)
        Me.songNametxt.TabIndex = 1
        Me.songNametxt.Text = "Label1"
        '
        'AlbumSongtxt
        '
        Me.AlbumSongtxt.AutoSize = True
        Me.AlbumSongtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.AlbumSongtxt.ForeColor = System.Drawing.Color.White
        Me.AlbumSongtxt.Location = New System.Drawing.Point(33, 640)
        Me.AlbumSongtxt.Name = "AlbumSongtxt"
        Me.AlbumSongtxt.Size = New System.Drawing.Size(77, 26)
        Me.AlbumSongtxt.TabIndex = 2
        Me.AlbumSongtxt.Text = "Label2"
        '
        'SongLengthtxt
        '
        Me.SongLengthtxt.AutoSize = True
        Me.SongLengthtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.SongLengthtxt.ForeColor = System.Drawing.Color.White
        Me.SongLengthtxt.Location = New System.Drawing.Point(33, 701)
        Me.SongLengthtxt.Name = "SongLengthtxt"
        Me.SongLengthtxt.Size = New System.Drawing.Size(77, 26)
        Me.SongLengthtxt.TabIndex = 3
        Me.SongLengthtxt.Text = "Label3"
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
        Me.EmailLog.Location = New System.Drawing.Point(144, 18)
        Me.EmailLog.Name = "EmailLog"
        Me.EmailLog.Size = New System.Drawing.Size(61, 23)
        Me.EmailLog.TabIndex = 14
        Me.EmailLog.Text = "rfjpe"
        '
        'Songtxt
        '
        Me.Songtxt.AutoSize = True
        Me.Songtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Songtxt.ForeColor = System.Drawing.Color.White
        Me.Songtxt.Location = New System.Drawing.Point(645, 462)
        Me.Songtxt.Name = "Songtxt"
        Me.Songtxt.Size = New System.Drawing.Size(66, 24)
        Me.Songtxt.TabIndex = 16
        Me.Songtxt.Text = "Label1"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(545, 517)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(265, 23)
        Me.ProgressBar1.TabIndex = 17
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(255, 167)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(174, 407)
        Me.ListBox2.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(33, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Songs"
        '
        'btnHistory
        '
        Me.btnHistory.AutoSize = True
        Me.btnHistory.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.ForeColor = System.Drawing.Color.White
        Me.btnHistory.Location = New System.Drawing.Point(250, 111)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(97, 25)
        Me.btnHistory.TabIndex = 27
        Me.btnHistory.Text = "History"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(930, 391)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(231, 23)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Song length (in sec)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(930, 306)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 23)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Song album"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(930, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 23)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Song name"
        '
        'songlengthtxtbox
        '
        Me.songlengthtxtbox.Location = New System.Drawing.Point(934, 417)
        Me.songlengthtxtbox.Name = "songlengthtxtbox"
        Me.songlengthtxtbox.Size = New System.Drawing.Size(283, 20)
        Me.songlengthtxtbox.TabIndex = 30
        '
        'songalbumtxtbox
        '
        Me.songalbumtxtbox.Location = New System.Drawing.Point(934, 332)
        Me.songalbumtxtbox.Name = "songalbumtxtbox"
        Me.songalbumtxtbox.Size = New System.Drawing.Size(283, 20)
        Me.songalbumtxtbox.TabIndex = 29
        '
        'songnametxtbox
        '
        Me.songnametxtbox.Location = New System.Drawing.Point(934, 255)
        Me.songnametxtbox.Name = "songnametxtbox"
        Me.songnametxtbox.Size = New System.Drawing.Size(283, 20)
        Me.songnametxtbox.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(930, 141)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(156, 32)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Add song"
        '
        'Michi
        '
        Me.Michi.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Michi.ForeColor = System.Drawing.Color.White
        Me.Michi.Image = Global.Songify.My.Resources.Resources._4aedd44ab39a02514290e2b05871555f
        Me.Michi.Location = New System.Drawing.Point(521, 454)
        Me.Michi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Michi.Name = "Michi"
        Me.Michi.Size = New System.Drawing.Size(311, 397)
        Me.Michi.TabIndex = 35
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.Songify.My.Resources.Resources.eliminar
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(1136, 529)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(81, 57)
        Me.btn_delete.TabIndex = 24
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.ForeColor = System.Drawing.Color.Black
        Me.btn_update.Image = Global.Songify.My.Resources.Resources.actualizar
        Me.btn_update.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_update.Location = New System.Drawing.Point(1037, 529)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(81, 57)
        Me.btn_update.TabIndex = 23
        Me.btn_update.Text = "Update"
        Me.btn_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insert.ForeColor = System.Drawing.Color.Black
        Me.btn_insert.Image = CType(resources.GetObject("btn_insert.Image"), System.Drawing.Image)
        Me.btn_insert.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insert.Location = New System.Drawing.Point(934, 529)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(81, 57)
        Me.btn_insert.TabIndex = 22
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'Play
        '
        Me.Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Play.Image = Global.Songify.My.Resources.Resources.jugar1
        Me.Play.Location = New System.Drawing.Point(641, 551)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(70, 49)
        Me.Play.TabIndex = 18
        Me.Play.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Songify.My.Resources.Resources.Sin_título_1
        Me.PictureBox1.Location = New System.Drawing.Point(527, 121)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(309, 316)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'GoBackBtn
        '
        Me.GoBackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GoBackBtn.ForeColor = System.Drawing.Color.Black
        Me.GoBackBtn.Image = Global.Songify.My.Resources.Resources.WhatsApp_Image_2021_04_06_at_12_40_53
        Me.GoBackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GoBackBtn.Location = New System.Drawing.Point(35, 742)
        Me.GoBackBtn.Name = "GoBackBtn"
        Me.GoBackBtn.Size = New System.Drawing.Size(92, 42)
        Me.GoBackBtn.TabIndex = 12
        Me.GoBackBtn.Text = "Back"
        Me.GoBackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GoBackBtn.UseVisualStyleBackColor = True
        '
        'CleanBtn
        '
        Me.CleanBtn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CleanBtn.ForeColor = System.Drawing.Color.Black
        Me.CleanBtn.Image = CType(resources.GetObject("CleanBtn.Image"), System.Drawing.Image)
        Me.CleanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CleanBtn.Location = New System.Drawing.Point(1136, 457)
        Me.CleanBtn.Name = "CleanBtn"
        Me.CleanBtn.Size = New System.Drawing.Size(81, 57)
        Me.CleanBtn.TabIndex = 36
        Me.CleanBtn.Text = "Clean"
        Me.CleanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CleanBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(250, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(134, 25)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "User/Date"
        '
        'Songs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(1328, 796)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CleanBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.songlengthtxtbox)
        Me.Controls.Add(Me.songalbumtxtbox)
        Me.Controls.Add(Me.songnametxtbox)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.Play)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Songtxt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.EmailLog)
        Me.Controls.Add(Me.lbl_profile)
        Me.Controls.Add(Me.GoBackBtn)
        Me.Controls.Add(Me.SongLengthtxt)
        Me.Controls.Add(Me.AlbumSongtxt)
        Me.Controls.Add(Me.songNametxt)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Michi)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "Songs"
        Me.Text = "Songs"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents songNametxt As Label
    Friend WithEvents AlbumSongtxt As Label
    Friend WithEvents SongLengthtxt As Label
    Friend WithEvents GoBackBtn As Button
    Friend WithEvents lbl_profile As Label
    Friend WithEvents EmailLog As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Songtxt As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Play As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnHistory As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents songlengthtxtbox As TextBox
    Friend WithEvents songalbumtxtbox As TextBox
    Friend WithEvents songnametxtbox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Michi As Label
    Friend WithEvents CleanBtn As Button
    Friend WithEvents Label7 As Label
End Class
