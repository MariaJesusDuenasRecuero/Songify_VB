<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Artists
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Artists))
        Me.lsb_artist = New System.Windows.Forms.ListBox()
        Me.aName = New System.Windows.Forms.Label()
        Me.country = New System.Windows.Forms.Label()
        Me.lst_album = New System.Windows.Forms.ListBox()
        Me.GoBackBtn = New System.Windows.Forms.Button()
        Me.lbl_artists = New System.Windows.Forms.Label()
        Me.lbl_albums = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_nationality = New System.Windows.Forms.Label()
        Me.EmailLog = New System.Windows.Forms.Label()
        Me.lbl_profile = New System.Windows.Forms.Label()
        Me.lsb_favArtist = New System.Windows.Forms.ListBox()
        Me.artistnametxt = New System.Windows.Forms.TextBox()
        Me.artistcountrytxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.unFavButton = New System.Windows.Forms.Button()
        Me.btnFav = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.im_artists = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        Me.CleanBtn = New System.Windows.Forms.Button()
        CType(Me.im_artists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lsb_artist
        '
        Me.lsb_artist.FormattingEnabled = True
        Me.lsb_artist.Location = New System.Drawing.Point(13, 120)
        Me.lsb_artist.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lsb_artist.Name = "lsb_artist"
        Me.lsb_artist.Size = New System.Drawing.Size(154, 225)
        Me.lsb_artist.TabIndex = 0
        '
        'aName
        '
        Me.aName.AutoSize = True
        Me.aName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.aName.ForeColor = System.Drawing.Color.White
        Me.aName.Location = New System.Drawing.Point(733, 627)
        Me.aName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.aName.Name = "aName"
        Me.aName.Size = New System.Drawing.Size(77, 26)
        Me.aName.TabIndex = 1
        Me.aName.Text = "Label1"
        '
        'country
        '
        Me.country.AutoSize = True
        Me.country.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.country.ForeColor = System.Drawing.Color.White
        Me.country.Location = New System.Drawing.Point(733, 670)
        Me.country.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.country.Name = "country"
        Me.country.Size = New System.Drawing.Size(77, 26)
        Me.country.TabIndex = 2
        Me.country.Text = "Label2"
        '
        'lst_album
        '
        Me.lst_album.FormattingEnabled = True
        Me.lst_album.Location = New System.Drawing.Point(21, 402)
        Me.lst_album.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lst_album.Name = "lst_album"
        Me.lst_album.Size = New System.Drawing.Size(383, 199)
        Me.lst_album.TabIndex = 4
        '
        'GoBackBtn
        '
        Me.GoBackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GoBackBtn.ForeColor = System.Drawing.Color.Black
        Me.GoBackBtn.Image = Global.Songify.My.Resources.Resources.WhatsApp_Image_2021_04_06_at_12_40_53
        Me.GoBackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GoBackBtn.Location = New System.Drawing.Point(23, 727)
        Me.GoBackBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GoBackBtn.Name = "GoBackBtn"
        Me.GoBackBtn.Size = New System.Drawing.Size(103, 42)
        Me.GoBackBtn.TabIndex = 5
        Me.GoBackBtn.Text = "Back"
        Me.GoBackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GoBackBtn.UseVisualStyleBackColor = True
        '
        'lbl_artists
        '
        Me.lbl_artists.AutoSize = True
        Me.lbl_artists.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_artists.ForeColor = System.Drawing.Color.White
        Me.lbl_artists.Location = New System.Drawing.Point(13, 94)
        Me.lbl_artists.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_artists.Name = "lbl_artists"
        Me.lbl_artists.Size = New System.Drawing.Size(81, 23)
        Me.lbl_artists.TabIndex = 6
        Me.lbl_artists.Text = "Artists"
        '
        'lbl_albums
        '
        Me.lbl_albums.AutoSize = True
        Me.lbl_albums.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_albums.ForeColor = System.Drawing.Color.White
        Me.lbl_albums.Location = New System.Drawing.Point(19, 372)
        Me.lbl_albums.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_albums.Name = "lbl_albums"
        Me.lbl_albums.Size = New System.Drawing.Size(90, 23)
        Me.lbl_albums.TabIndex = 7
        Me.lbl_albums.Text = "Albums"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.ForeColor = System.Drawing.Color.White
        Me.lbl_name.Location = New System.Drawing.Point(592, 627)
        Me.lbl_name.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(72, 23)
        Me.lbl_name.TabIndex = 8
        Me.lbl_name.Text = "Name"
        '
        'lbl_nationality
        '
        Me.lbl_nationality.AutoSize = True
        Me.lbl_nationality.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nationality.ForeColor = System.Drawing.Color.White
        Me.lbl_nationality.Location = New System.Drawing.Point(534, 673)
        Me.lbl_nationality.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_nationality.Name = "lbl_nationality"
        Me.lbl_nationality.Size = New System.Drawing.Size(130, 23)
        Me.lbl_nationality.TabIndex = 9
        Me.lbl_nationality.Text = "Nationality"
        '
        'EmailLog
        '
        Me.EmailLog.AutoSize = True
        Me.EmailLog.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLog.Location = New System.Drawing.Point(193, 13)
        Me.EmailLog.Name = "EmailLog"
        Me.EmailLog.Size = New System.Drawing.Size(61, 23)
        Me.EmailLog.TabIndex = 10
        Me.EmailLog.Text = "rfjpe"
        '
        'lbl_profile
        '
        Me.lbl_profile.AutoSize = True
        Me.lbl_profile.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profile.Location = New System.Drawing.Point(17, 13)
        Me.lbl_profile.Name = "lbl_profile"
        Me.lbl_profile.Size = New System.Drawing.Size(126, 23)
        Me.lbl_profile.TabIndex = 11
        Me.lbl_profile.Text = "Logged as:"
        '
        'lsb_favArtist
        '
        Me.lsb_favArtist.FormattingEnabled = True
        Me.lsb_favArtist.Location = New System.Drawing.Point(250, 120)
        Me.lsb_favArtist.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lsb_favArtist.Name = "lsb_favArtist"
        Me.lsb_favArtist.Size = New System.Drawing.Size(154, 225)
        Me.lsb_favArtist.TabIndex = 16
        '
        'artistnametxt
        '
        Me.artistnametxt.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.artistnametxt.Location = New System.Drawing.Point(968, 232)
        Me.artistnametxt.Name = "artistnametxt"
        Me.artistnametxt.Size = New System.Drawing.Size(274, 27)
        Me.artistnametxt.TabIndex = 17
        '
        'artistcountrytxt
        '
        Me.artistcountrytxt.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.artistcountrytxt.Location = New System.Drawing.Point(968, 309)
        Me.artistcountrytxt.Name = "artistcountrytxt"
        Me.artistcountrytxt.Size = New System.Drawing.Size(274, 27)
        Me.artistcountrytxt.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(964, 206)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Artist name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(964, 283)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 23)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Artist country"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(964, 356)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(208, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Artist image route"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(246, 94)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 23)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Favorites"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(964, 94)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 32)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Add artist"
        '
        'unFavButton
        '
        Me.unFavButton.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unFavButton.ForeColor = System.Drawing.Color.Black
        Me.unFavButton.Image = Global.Songify.My.Resources.Resources.estrella1
        Me.unFavButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.unFavButton.Location = New System.Drawing.Point(237, 619)
        Me.unFavButton.Name = "unFavButton"
        Me.unFavButton.Size = New System.Drawing.Size(167, 57)
        Me.unFavButton.TabIndex = 34
        Me.unFavButton.Text = "Unfavorite"
        Me.unFavButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.unFavButton.UseVisualStyleBackColor = True
        '
        'btnFav
        '
        Me.btnFav.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFav.ForeColor = System.Drawing.Color.Black
        Me.btnFav.Image = Global.Songify.My.Resources.Resources.estrella
        Me.btnFav.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFav.Location = New System.Drawing.Point(23, 622)
        Me.btnFav.Name = "btnFav"
        Me.btnFav.Size = New System.Drawing.Size(166, 57)
        Me.btnFav.TabIndex = 15
        Me.btnFav.Text = "Favorite"
        Me.btnFav.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFav.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.Songify.My.Resources.Resources.eliminar
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(1161, 474)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(81, 57)
        Me.btn_delete.TabIndex = 14
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
        Me.btn_update.Location = New System.Drawing.Point(1064, 474)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(81, 57)
        Me.btn_update.TabIndex = 13
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
        Me.btn_insert.Location = New System.Drawing.Point(968, 474)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(81, 57)
        Me.btn_insert.TabIndex = 12
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'im_artists
        '
        Me.im_artists.Image = Global.Songify.My.Resources.Resources.imagenDefault
        Me.im_artists.Location = New System.Drawing.Point(429, 94)
        Me.im_artists.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.im_artists.Name = "im_artists"
        Me.im_artists.Size = New System.Drawing.Size(509, 507)
        Me.im_artists.TabIndex = 3
        Me.im_artists.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(968, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 57)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Image"
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
        Me.CleanBtn.Location = New System.Drawing.Point(1161, 392)
        Me.CleanBtn.Name = "CleanBtn"
        Me.CleanBtn.Size = New System.Drawing.Size(81, 57)
        Me.CleanBtn.TabIndex = 36
        Me.CleanBtn.Text = "Clean"
        Me.CleanBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.CleanBtn.UseVisualStyleBackColor = True
        '
        'Artists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(1328, 796)
        Me.Controls.Add(Me.CleanBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.unFavButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.artistcountrytxt)
        Me.Controls.Add(Me.artistnametxt)
        Me.Controls.Add(Me.lsb_favArtist)
        Me.Controls.Add(Me.btnFav)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.lbl_profile)
        Me.Controls.Add(Me.EmailLog)
        Me.Controls.Add(Me.lbl_nationality)
        Me.Controls.Add(Me.lbl_name)
        Me.Controls.Add(Me.lbl_albums)
        Me.Controls.Add(Me.lbl_artists)
        Me.Controls.Add(Me.GoBackBtn)
        Me.Controls.Add(Me.lst_album)
        Me.Controls.Add(Me.country)
        Me.Controls.Add(Me.aName)
        Me.Controls.Add(Me.lsb_artist)
        Me.Controls.Add(Me.im_artists)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.Name = "Artists"
        Me.Text = "Artists"
        CType(Me.im_artists, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lsb_artist As ListBox
    Friend WithEvents aName As Label
    Friend WithEvents country As Label
    Friend WithEvents lst_album As ListBox
    Friend WithEvents GoBackBtn As Button
    Friend WithEvents im_artists As PictureBox
    Friend WithEvents lbl_artists As Label
    Friend WithEvents lbl_albums As Label
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_nationality As Label
    Friend WithEvents EmailLog As Label
    Friend WithEvents lbl_profile As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btnFav As Button
    Friend WithEvents lsb_favArtist As ListBox
    Friend WithEvents artistnametxt As TextBox
    Friend WithEvents artistcountrytxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents unFavButton As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents CleanBtn As Button
End Class
