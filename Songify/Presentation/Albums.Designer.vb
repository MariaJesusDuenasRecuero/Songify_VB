﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Albums
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Albums))
        Me.GoBackBtn = New System.Windows.Forms.Button()
        Me.releaseDate = New System.Windows.Forms.Label()
        Me.aName = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Length = New System.Windows.Forms.Label()
        Me.lbl_albums = New System.Windows.Forms.Label()
        Me.lbl_songs = New System.Windows.Forms.Label()
        Me.lbl_artistName = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_length = New System.Windows.Forms.Label()
        Me.lbl_profile = New System.Windows.Forms.Label()
        Me.EmailLog = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.albumartisttxt = New System.Windows.Forms.TextBox()
        Me.albumreleaseDatetxt = New System.Windows.Forms.TextBox()
        Me.albumnametxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.img_album = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        Me.CleanBtn = New System.Windows.Forms.Button()
        CType(Me.img_album, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GoBackBtn
        '
        Me.GoBackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GoBackBtn.Image = Global.Songify.My.Resources.Resources.WhatsApp_Image_2021_04_06_at_12_40_53
        Me.GoBackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GoBackBtn.Location = New System.Drawing.Point(33, 711)
        Me.GoBackBtn.Name = "GoBackBtn"
        Me.GoBackBtn.Size = New System.Drawing.Size(96, 42)
        Me.GoBackBtn.TabIndex = 11
        Me.GoBackBtn.Text = "Back"
        Me.GoBackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GoBackBtn.UseVisualStyleBackColor = True
        '
        'releaseDate
        '
        Me.releaseDate.AutoSize = True
        Me.releaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.releaseDate.ForeColor = System.Drawing.Color.White
        Me.releaseDate.Location = New System.Drawing.Point(698, 667)
        Me.releaseDate.Name = "releaseDate"
        Me.releaseDate.Size = New System.Drawing.Size(57, 20)
        Me.releaseDate.TabIndex = 8
        Me.releaseDate.Text = "Label2"
        '
        'aName
        '
        Me.aName.AutoSize = True
        Me.aName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.aName.ForeColor = System.Drawing.Color.White
        Me.aName.Location = New System.Drawing.Point(698, 615)
        Me.aName.Name = "aName"
        Me.aName.Size = New System.Drawing.Size(57, 20)
        Me.aName.TabIndex = 7
        Me.aName.Text = "Label1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(33, 124)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(310, 212)
        Me.ListBox1.TabIndex = 6
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(33, 388)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(310, 199)
        Me.ListBox2.TabIndex = 12
        '
        'Length
        '
        Me.Length.AutoSize = True
        Me.Length.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Length.ForeColor = System.Drawing.Color.White
        Me.Length.Location = New System.Drawing.Point(698, 723)
        Me.Length.Name = "Length"
        Me.Length.Size = New System.Drawing.Size(57, 20)
        Me.Length.TabIndex = 13
        Me.Length.Text = "Label2"
        '
        'lbl_albums
        '
        Me.lbl_albums.AutoSize = True
        Me.lbl_albums.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_albums.ForeColor = System.Drawing.Color.White
        Me.lbl_albums.Location = New System.Drawing.Point(29, 98)
        Me.lbl_albums.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_albums.Name = "lbl_albums"
        Me.lbl_albums.Size = New System.Drawing.Size(90, 23)
        Me.lbl_albums.TabIndex = 14
        Me.lbl_albums.Text = "Albums"
        '
        'lbl_songs
        '
        Me.lbl_songs.AutoSize = True
        Me.lbl_songs.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_songs.ForeColor = System.Drawing.Color.White
        Me.lbl_songs.Location = New System.Drawing.Point(29, 362)
        Me.lbl_songs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_songs.Name = "lbl_songs"
        Me.lbl_songs.Size = New System.Drawing.Size(75, 23)
        Me.lbl_songs.TabIndex = 15
        Me.lbl_songs.Text = "Songs"
        '
        'lbl_artistName
        '
        Me.lbl_artistName.AutoSize = True
        Me.lbl_artistName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_artistName.ForeColor = System.Drawing.Color.White
        Me.lbl_artistName.Location = New System.Drawing.Point(526, 615)
        Me.lbl_artistName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_artistName.Name = "lbl_artistName"
        Me.lbl_artistName.Size = New System.Drawing.Size(78, 23)
        Me.lbl_artistName.TabIndex = 16
        Me.lbl_artistName.Text = "Artist:"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.ForeColor = System.Drawing.Color.White
        Me.lbl_date.Location = New System.Drawing.Point(526, 667)
        Me.lbl_date.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(69, 23)
        Me.lbl_date.TabIndex = 17
        Me.lbl_date.Text = "Date:"
        '
        'lbl_length
        '
        Me.lbl_length.AutoSize = True
        Me.lbl_length.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_length.ForeColor = System.Drawing.Color.White
        Me.lbl_length.Location = New System.Drawing.Point(511, 720)
        Me.lbl_length.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_length.Name = "lbl_length"
        Me.lbl_length.Size = New System.Drawing.Size(93, 23)
        Me.lbl_length.TabIndex = 18
        Me.lbl_length.Text = "Length:"
        '
        'lbl_profile
        '
        Me.lbl_profile.AutoSize = True
        Me.lbl_profile.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profile.ForeColor = System.Drawing.Color.White
        Me.lbl_profile.Location = New System.Drawing.Point(29, 9)
        Me.lbl_profile.Name = "lbl_profile"
        Me.lbl_profile.Size = New System.Drawing.Size(126, 23)
        Me.lbl_profile.TabIndex = 20
        Me.lbl_profile.Text = "Logged as:"
        '
        'EmailLog
        '
        Me.EmailLog.AutoSize = True
        Me.EmailLog.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLog.ForeColor = System.Drawing.Color.White
        Me.EmailLog.Location = New System.Drawing.Point(205, 9)
        Me.EmailLog.Name = "EmailLog"
        Me.EmailLog.Size = New System.Drawing.Size(61, 23)
        Me.EmailLog.TabIndex = 19
        Me.EmailLog.Text = "rfjpe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(949, 348)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(144, 23)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Album artist"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(949, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(220, 23)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Album release date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(949, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Album name"
        '
        'albumartisttxt
        '
        Me.albumartisttxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.albumartisttxt.Location = New System.Drawing.Point(953, 374)
        Me.albumartisttxt.Name = "albumartisttxt"
        Me.albumartisttxt.Size = New System.Drawing.Size(285, 26)
        Me.albumartisttxt.TabIndex = 26
        '
        'albumreleaseDatetxt
        '
        Me.albumreleaseDatetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.albumreleaseDatetxt.Location = New System.Drawing.Point(953, 282)
        Me.albumreleaseDatetxt.Name = "albumreleaseDatetxt"
        Me.albumreleaseDatetxt.Size = New System.Drawing.Size(285, 26)
        Me.albumreleaseDatetxt.TabIndex = 25
        '
        'albumnametxt
        '
        Me.albumnametxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.albumnametxt.Location = New System.Drawing.Point(953, 197)
        Me.albumnametxt.Name = "albumnametxt"
        Me.albumnametxt.Size = New System.Drawing.Size(285, 26)
        Me.albumnametxt.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(949, 418)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 23)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Album cover"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(949, 98)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 32)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Add album"
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.Songify.My.Resources.Resources.eliminar
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(1157, 530)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(81, 57)
        Me.btn_delete.TabIndex = 23
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
        Me.btn_update.Location = New System.Drawing.Point(1056, 530)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(81, 57)
        Me.btn_update.TabIndex = 22
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
        Me.btn_insert.Location = New System.Drawing.Point(953, 530)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(81, 57)
        Me.btn_insert.TabIndex = 21
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'img_album
        '
        Me.img_album.Image = Global.Songify.My.Resources.Resources.imagenDefault
        Me.img_album.Location = New System.Drawing.Point(386, 79)
        Me.img_album.Name = "img_album"
        Me.img_album.Size = New System.Drawing.Size(522, 508)
        Me.img_album.TabIndex = 9
        Me.img_album.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(953, 453)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 57)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Cover"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ofdPath
        '
        Me.ofdPath.FileName = "OpenFileDialog1"
        '
        'CleanBtn
        '
        Me.CleanBtn.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CleanBtn.ForeColor = System.Drawing.Color.Black
        Me.CleanBtn.Image = CType(resources.GetObject("CleanBtn.Image"), System.Drawing.Image)
        Me.CleanBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CleanBtn.Location = New System.Drawing.Point(1157, 453)
        Me.CleanBtn.Name = "CleanBtn"
        Me.CleanBtn.Size = New System.Drawing.Size(81, 57)
        Me.CleanBtn.TabIndex = 34
        Me.CleanBtn.Text = "Clean"
        Me.CleanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CleanBtn.UseVisualStyleBackColor = True
        '
        'Albums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(1328, 796)
        Me.Controls.Add(Me.CleanBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.albumartisttxt)
        Me.Controls.Add(Me.albumreleaseDatetxt)
        Me.Controls.Add(Me.albumnametxt)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_profile)
        Me.Controls.Add(Me.EmailLog)
        Me.Controls.Add(Me.lbl_length)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_artistName)
        Me.Controls.Add(Me.lbl_songs)
        Me.Controls.Add(Me.lbl_albums)
        Me.Controls.Add(Me.Length)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.GoBackBtn)
        Me.Controls.Add(Me.img_album)
        Me.Controls.Add(Me.releaseDate)
        Me.Controls.Add(Me.aName)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Albums"
        Me.Text = "Albums"
        CType(Me.img_album, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GoBackBtn As Button
    Friend WithEvents img_album As PictureBox
    Friend WithEvents releaseDate As Label
    Friend WithEvents aName As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Length As Label
    Friend WithEvents lbl_albums As Label
    Friend WithEvents lbl_songs As Label
    Friend WithEvents lbl_artistName As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents lbl_length As Label
    Friend WithEvents lbl_profile As Label
    Friend WithEvents EmailLog As Label
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents albumartisttxt As TextBox
    Friend WithEvents albumreleaseDatetxt As TextBox
    Friend WithEvents albumnametxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents CleanBtn As Button
End Class
