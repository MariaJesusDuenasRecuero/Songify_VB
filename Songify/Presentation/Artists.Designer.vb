<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Artists
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
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.im_artists = New System.Windows.Forms.PictureBox()
        Me.btnFav = New System.Windows.Forms.Button()
        CType(Me.im_artists, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lsb_artist
        '
        Me.lsb_artist.FormattingEnabled = True
        Me.lsb_artist.Location = New System.Drawing.Point(17, 81)
        Me.lsb_artist.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lsb_artist.Name = "lsb_artist"
        Me.lsb_artist.Size = New System.Drawing.Size(383, 212)
        Me.lsb_artist.TabIndex = 0
        '
        'aName
        '
        Me.aName.AutoSize = True
        Me.aName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.aName.ForeColor = System.Drawing.Color.White
        Me.aName.Location = New System.Drawing.Point(717, 564)
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
        Me.country.Location = New System.Drawing.Point(717, 650)
        Me.country.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.country.Name = "country"
        Me.country.Size = New System.Drawing.Size(77, 26)
        Me.country.TabIndex = 2
        Me.country.Text = "Label2"
        '
        'lst_album
        '
        Me.lst_album.FormattingEnabled = True
        Me.lst_album.Location = New System.Drawing.Point(17, 337)
        Me.lst_album.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.lst_album.Name = "lst_album"
        Me.lst_album.Size = New System.Drawing.Size(383, 199)
        Me.lst_album.TabIndex = 4
        '
        'GoBackBtn
        '
        Me.GoBackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GoBackBtn.ForeColor = System.Drawing.Color.Black
        Me.GoBackBtn.Location = New System.Drawing.Point(21, 653)
        Me.GoBackBtn.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.GoBackBtn.Name = "GoBackBtn"
        Me.GoBackBtn.Size = New System.Drawing.Size(88, 42)
        Me.GoBackBtn.TabIndex = 5
        Me.GoBackBtn.Text = "Back"
        Me.GoBackBtn.UseVisualStyleBackColor = True
        '
        'lbl_artists
        '
        Me.lbl_artists.AutoSize = True
        Me.lbl_artists.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_artists.ForeColor = System.Drawing.Color.White
        Me.lbl_artists.Location = New System.Drawing.Point(17, 51)
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
        Me.lbl_albums.Location = New System.Drawing.Point(17, 311)
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
        Me.lbl_name.Location = New System.Drawing.Point(576, 564)
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
        Me.lbl_nationality.Location = New System.Drawing.Point(518, 653)
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
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.Songify.My.Resources.Resources.eliminar
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(319, 555)
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
        Me.btn_update.Location = New System.Drawing.Point(116, 555)
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
        Me.btn_insert.Location = New System.Drawing.Point(17, 555)
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
        Me.im_artists.Location = New System.Drawing.Point(429, 34)
        Me.im_artists.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.im_artists.Name = "im_artists"
        Me.im_artists.Size = New System.Drawing.Size(509, 507)
        Me.im_artists.TabIndex = 3
        Me.im_artists.TabStop = False
        '
        'btnFav
        '
        Me.btnFav.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFav.ForeColor = System.Drawing.Color.Black
        Me.btnFav.Image = Global.Songify.My.Resources.Resources.estrella
        Me.btnFav.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnFav.Location = New System.Drawing.Point(223, 555)
        Me.btnFav.Name = "btnFav"
        Me.btnFav.Size = New System.Drawing.Size(81, 57)
        Me.btnFav.TabIndex = 15
        Me.btnFav.Text = "Favorite"
        Me.btnFav.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFav.UseVisualStyleBackColor = True
        '
        'Artists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(951, 714)
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
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
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
End Class
