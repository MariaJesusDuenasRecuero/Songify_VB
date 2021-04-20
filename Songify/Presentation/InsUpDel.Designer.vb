<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsUpDel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsUpDel))
        Me.albmcoverlbl = New System.Windows.Forms.Label()
        Me.albmcovertxt = New System.Windows.Forms.TextBox()
        Me.SongTitle = New System.Windows.Forms.Label()
        Me.AlbumTitle = New System.Windows.Forms.Label()
        Me.ArtistTitle = New System.Windows.Forms.Label()
        Me.songlengthlbl = New System.Windows.Forms.Label()
        Me.songalbumlbl = New System.Windows.Forms.Label()
        Me.songnamelbl = New System.Windows.Forms.Label()
        Me.songlengthtxt = New System.Windows.Forms.TextBox()
        Me.songalbmtxt = New System.Windows.Forms.TextBox()
        Me.songnametxt = New System.Windows.Forms.TextBox()
        Me.albartistlbl = New System.Windows.Forms.Label()
        Me.albmdatelbl = New System.Windows.Forms.Label()
        Me.albmnamelbl = New System.Windows.Forms.Label()
        Me.coverbtn = New System.Windows.Forms.Button()
        Me.albmartisttxt = New System.Windows.Forms.TextBox()
        Me.albmdatetxt = New System.Windows.Forms.TextBox()
        Me.albmnametxt = New System.Windows.Forms.TextBox()
        Me.artimglbl = New System.Windows.Forms.Label()
        Me.artcountrylbl = New System.Windows.Forms.Label()
        Me.artNamelbl = New System.Windows.Forms.Label()
        Me.imagebtn = New System.Windows.Forms.Button()
        Me.artimagetxt = New System.Windows.Forms.TextBox()
        Me.artcountrytxt = New System.Windows.Forms.TextBox()
        Me.artnametxt = New System.Windows.Forms.TextBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_deleteAlbum = New System.Windows.Forms.Button()
        Me.btn_updateAlbum = New System.Windows.Forms.Button()
        Me.btn_insertAlbum = New System.Windows.Forms.Button()
        Me.btn_deleteArtists = New System.Windows.Forms.Button()
        Me.btn_updateArtists = New System.Windows.Forms.Button()
        Me.btn_insertArtists = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'albmcoverlbl
        '
        Me.albmcoverlbl.AutoSize = True
        Me.albmcoverlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.albmcoverlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.albmcoverlbl.Location = New System.Drawing.Point(358, 325)
        Me.albmcoverlbl.Name = "albmcoverlbl"
        Me.albmcoverlbl.Size = New System.Drawing.Size(120, 24)
        Me.albmcoverlbl.TabIndex = 85
        Me.albmcoverlbl.Text = "Album Cover"
        '
        'albmcovertxt
        '
        Me.albmcovertxt.Location = New System.Drawing.Point(357, 361)
        Me.albmcovertxt.Name = "albmcovertxt"
        Me.albmcovertxt.Size = New System.Drawing.Size(251, 20)
        Me.albmcovertxt.TabIndex = 84
        '
        'SongTitle
        '
        Me.SongTitle.AutoSize = True
        Me.SongTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.SongTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SongTitle.Location = New System.Drawing.Point(755, 19)
        Me.SongTitle.Name = "SongTitle"
        Me.SongTitle.Size = New System.Drawing.Size(64, 24)
        Me.SongTitle.TabIndex = 83
        Me.SongTitle.Text = "Songs"
        '
        'AlbumTitle
        '
        Me.AlbumTitle.AutoSize = True
        Me.AlbumTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.AlbumTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AlbumTitle.Location = New System.Drawing.Point(439, 19)
        Me.AlbumTitle.Name = "AlbumTitle"
        Me.AlbumTitle.Size = New System.Drawing.Size(74, 24)
        Me.AlbumTitle.TabIndex = 82
        Me.AlbumTitle.Text = "Albums"
        '
        'ArtistTitle
        '
        Me.ArtistTitle.AutoSize = True
        Me.ArtistTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.ArtistTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ArtistTitle.Location = New System.Drawing.Point(127, 19)
        Me.ArtistTitle.Name = "ArtistTitle"
        Me.ArtistTitle.Size = New System.Drawing.Size(59, 24)
        Me.ArtistTitle.TabIndex = 81
        Me.ArtistTitle.Text = "Artists"
        '
        'songlengthlbl
        '
        Me.songlengthlbl.AutoSize = True
        Me.songlengthlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.songlengthlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.songlengthlbl.Location = New System.Drawing.Point(673, 255)
        Me.songlengthlbl.Name = "songlengthlbl"
        Me.songlengthlbl.Size = New System.Drawing.Size(118, 24)
        Me.songlengthlbl.TabIndex = 80
        Me.songlengthlbl.Text = "Song Length"
        '
        'songalbumlbl
        '
        Me.songalbumlbl.AutoSize = True
        Me.songalbumlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.songalbumlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.songalbumlbl.Location = New System.Drawing.Point(672, 186)
        Me.songalbumlbl.Name = "songalbumlbl"
        Me.songalbumlbl.Size = New System.Drawing.Size(135, 24)
        Me.songalbumlbl.TabIndex = 79
        Me.songalbumlbl.Text = "Song Id Album"
        '
        'songnamelbl
        '
        Me.songnamelbl.AutoSize = True
        Me.songnamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.songnamelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.songnamelbl.Location = New System.Drawing.Point(673, 110)
        Me.songnamelbl.Name = "songnamelbl"
        Me.songnamelbl.Size = New System.Drawing.Size(111, 24)
        Me.songnamelbl.TabIndex = 78
        Me.songnamelbl.Text = "Song Name"
        '
        'songlengthtxt
        '
        Me.songlengthtxt.Location = New System.Drawing.Point(676, 291)
        Me.songlengthtxt.Name = "songlengthtxt"
        Me.songlengthtxt.Size = New System.Drawing.Size(251, 20)
        Me.songlengthtxt.TabIndex = 77
        '
        'songalbmtxt
        '
        Me.songalbmtxt.Location = New System.Drawing.Point(676, 226)
        Me.songalbmtxt.Name = "songalbmtxt"
        Me.songalbmtxt.Size = New System.Drawing.Size(251, 20)
        Me.songalbmtxt.TabIndex = 76
        '
        'songnametxt
        '
        Me.songnametxt.Location = New System.Drawing.Point(676, 153)
        Me.songnametxt.Name = "songnametxt"
        Me.songnametxt.Size = New System.Drawing.Size(251, 20)
        Me.songnametxt.TabIndex = 75
        '
        'albartistlbl
        '
        Me.albartistlbl.AutoSize = True
        Me.albartistlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.albartistlbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.albartistlbl.Location = New System.Drawing.Point(357, 255)
        Me.albartistlbl.Name = "albartistlbl"
        Me.albartistlbl.Size = New System.Drawing.Size(130, 24)
        Me.albartistlbl.TabIndex = 74
        Me.albartistlbl.Text = "Album Id Artist"
        '
        'albmdatelbl
        '
        Me.albmdatelbl.AutoSize = True
        Me.albmdatelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.albmdatelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.albmdatelbl.Location = New System.Drawing.Point(356, 186)
        Me.albmdatelbl.Name = "albmdatelbl"
        Me.albmdatelbl.Size = New System.Drawing.Size(108, 24)
        Me.albmdatelbl.TabIndex = 73
        Me.albmdatelbl.Text = "Album Date"
        '
        'albmnamelbl
        '
        Me.albmnamelbl.AutoSize = True
        Me.albmnamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.albmnamelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.albmnamelbl.Location = New System.Drawing.Point(357, 110)
        Me.albmnamelbl.Name = "albmnamelbl"
        Me.albmnamelbl.Size = New System.Drawing.Size(121, 24)
        Me.albmnamelbl.TabIndex = 72
        Me.albmnamelbl.Text = "Album Name"
        '
        'coverbtn
        '
        Me.coverbtn.Location = New System.Drawing.Point(530, 411)
        Me.coverbtn.Name = "coverbtn"
        Me.coverbtn.Size = New System.Drawing.Size(82, 42)
        Me.coverbtn.TabIndex = 71
        Me.coverbtn.Text = "Search Cover"
        Me.coverbtn.UseVisualStyleBackColor = True
        '
        'albmartisttxt
        '
        Me.albmartisttxt.Location = New System.Drawing.Point(356, 291)
        Me.albmartisttxt.Name = "albmartisttxt"
        Me.albmartisttxt.Size = New System.Drawing.Size(251, 20)
        Me.albmartisttxt.TabIndex = 70
        '
        'albmdatetxt
        '
        Me.albmdatetxt.Location = New System.Drawing.Point(360, 226)
        Me.albmdatetxt.Name = "albmdatetxt"
        Me.albmdatetxt.Size = New System.Drawing.Size(251, 20)
        Me.albmdatetxt.TabIndex = 69
        '
        'albmnametxt
        '
        Me.albmnametxt.Location = New System.Drawing.Point(360, 153)
        Me.albmnametxt.Name = "albmnametxt"
        Me.albmnametxt.Size = New System.Drawing.Size(251, 20)
        Me.albmnametxt.TabIndex = 68
        '
        'artimglbl
        '
        Me.artimglbl.AutoSize = True
        Me.artimglbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.artimglbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.artimglbl.Location = New System.Drawing.Point(43, 255)
        Me.artimglbl.Name = "artimglbl"
        Me.artimglbl.Size = New System.Drawing.Size(107, 24)
        Me.artimglbl.TabIndex = 67
        Me.artimglbl.Text = "Artist Image"
        '
        'artcountrylbl
        '
        Me.artcountrylbl.AutoSize = True
        Me.artcountrylbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.artcountrylbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.artcountrylbl.Location = New System.Drawing.Point(43, 186)
        Me.artcountrylbl.Name = "artcountrylbl"
        Me.artcountrylbl.Size = New System.Drawing.Size(120, 24)
        Me.artcountrylbl.TabIndex = 66
        Me.artcountrylbl.Text = "Artist Country"
        '
        'artNamelbl
        '
        Me.artNamelbl.AutoSize = True
        Me.artNamelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.artNamelbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.artNamelbl.Location = New System.Drawing.Point(44, 110)
        Me.artNamelbl.Name = "artNamelbl"
        Me.artNamelbl.Size = New System.Drawing.Size(106, 24)
        Me.artNamelbl.TabIndex = 65
        Me.artNamelbl.Text = "Artist Name"
        '
        'imagebtn
        '
        Me.imagebtn.Location = New System.Drawing.Point(216, 411)
        Me.imagebtn.Name = "imagebtn"
        Me.imagebtn.Size = New System.Drawing.Size(82, 42)
        Me.imagebtn.TabIndex = 64
        Me.imagebtn.Text = "Search Image"
        Me.imagebtn.UseVisualStyleBackColor = True
        '
        'artimagetxt
        '
        Me.artimagetxt.Location = New System.Drawing.Point(47, 291)
        Me.artimagetxt.Name = "artimagetxt"
        Me.artimagetxt.Size = New System.Drawing.Size(251, 20)
        Me.artimagetxt.TabIndex = 63
        '
        'artcountrytxt
        '
        Me.artcountrytxt.Location = New System.Drawing.Point(48, 226)
        Me.artcountrytxt.Name = "artcountrytxt"
        Me.artcountrytxt.Size = New System.Drawing.Size(251, 20)
        Me.artcountrytxt.TabIndex = 62
        '
        'artnametxt
        '
        Me.artnametxt.Location = New System.Drawing.Point(47, 153)
        Me.artnametxt.Name = "artnametxt"
        Me.artnametxt.Size = New System.Drawing.Size(251, 20)
        Me.artnametxt.TabIndex = 61
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.Black
        Me.btn_back.Image = Global.Songify.My.Resources.Resources.WhatsApp_Image_2021_04_06_at_12_40_53
        Me.btn_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_back.Location = New System.Drawing.Point(47, 632)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(79, 55)
        Me.btn_back.TabIndex = 60
        Me.btn_back.Text = "Back"
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.Songify.My.Resources.Resources.eliminar
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(846, 521)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(81, 57)
        Me.btn_delete.TabIndex = 59
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
        Me.btn_update.Location = New System.Drawing.Point(759, 521)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(81, 57)
        Me.btn_update.TabIndex = 58
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
        Me.btn_insert.Location = New System.Drawing.Point(672, 521)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(81, 57)
        Me.btn_insert.TabIndex = 57
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_deleteAlbum
        '
        Me.btn_deleteAlbum.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteAlbum.ForeColor = System.Drawing.Color.Black
        Me.btn_deleteAlbum.Image = Global.Songify.My.Resources.Resources.eliminar
        Me.btn_deleteAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteAlbum.Location = New System.Drawing.Point(530, 523)
        Me.btn_deleteAlbum.Name = "btn_deleteAlbum"
        Me.btn_deleteAlbum.Size = New System.Drawing.Size(81, 57)
        Me.btn_deleteAlbum.TabIndex = 56
        Me.btn_deleteAlbum.Text = "Delete"
        Me.btn_deleteAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteAlbum.UseVisualStyleBackColor = True
        '
        'btn_updateAlbum
        '
        Me.btn_updateAlbum.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateAlbum.ForeColor = System.Drawing.Color.Black
        Me.btn_updateAlbum.Image = Global.Songify.My.Resources.Resources.actualizar
        Me.btn_updateAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateAlbum.Location = New System.Drawing.Point(443, 523)
        Me.btn_updateAlbum.Name = "btn_updateAlbum"
        Me.btn_updateAlbum.Size = New System.Drawing.Size(81, 57)
        Me.btn_updateAlbum.TabIndex = 55
        Me.btn_updateAlbum.Text = "Update"
        Me.btn_updateAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateAlbum.UseVisualStyleBackColor = True
        '
        'btn_insertAlbum
        '
        Me.btn_insertAlbum.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertAlbum.ForeColor = System.Drawing.Color.Black
        Me.btn_insertAlbum.Image = CType(resources.GetObject("btn_insertAlbum.Image"), System.Drawing.Image)
        Me.btn_insertAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertAlbum.Location = New System.Drawing.Point(356, 523)
        Me.btn_insertAlbum.Name = "btn_insertAlbum"
        Me.btn_insertAlbum.Size = New System.Drawing.Size(81, 57)
        Me.btn_insertAlbum.TabIndex = 54
        Me.btn_insertAlbum.Text = "Insert"
        Me.btn_insertAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertAlbum.UseVisualStyleBackColor = True
        '
        'btn_deleteArtists
        '
        Me.btn_deleteArtists.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteArtists.ForeColor = System.Drawing.Color.Black
        Me.btn_deleteArtists.Image = Global.Songify.My.Resources.Resources.eliminar
        Me.btn_deleteArtists.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteArtists.Location = New System.Drawing.Point(216, 523)
        Me.btn_deleteArtists.Name = "btn_deleteArtists"
        Me.btn_deleteArtists.Size = New System.Drawing.Size(82, 55)
        Me.btn_deleteArtists.TabIndex = 53
        Me.btn_deleteArtists.Text = "Delete"
        Me.btn_deleteArtists.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_deleteArtists.UseVisualStyleBackColor = True
        '
        'btn_updateArtists
        '
        Me.btn_updateArtists.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateArtists.ForeColor = System.Drawing.Color.Black
        Me.btn_updateArtists.Image = Global.Songify.My.Resources.Resources.actualizar
        Me.btn_updateArtists.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_updateArtists.Location = New System.Drawing.Point(131, 523)
        Me.btn_updateArtists.Name = "btn_updateArtists"
        Me.btn_updateArtists.Size = New System.Drawing.Size(82, 55)
        Me.btn_updateArtists.TabIndex = 52
        Me.btn_updateArtists.Text = "Update"
        Me.btn_updateArtists.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_updateArtists.UseVisualStyleBackColor = True
        '
        'btn_insertArtists
        '
        Me.btn_insertArtists.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_insertArtists.ForeColor = System.Drawing.Color.Black
        Me.btn_insertArtists.Image = CType(resources.GetObject("btn_insertArtists.Image"), System.Drawing.Image)
        Me.btn_insertArtists.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_insertArtists.Location = New System.Drawing.Point(47, 523)
        Me.btn_insertArtists.Name = "btn_insertArtists"
        Me.btn_insertArtists.Size = New System.Drawing.Size(79, 55)
        Me.btn_insertArtists.TabIndex = 51
        Me.btn_insertArtists.Text = "Insert"
        Me.btn_insertArtists.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertArtists.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(48, 87)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(251, 20)
        Me.TextBox1.TabIndex = 86
        '
        'InsUpDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(1007, 683)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.albmcoverlbl)
        Me.Controls.Add(Me.albmcovertxt)
        Me.Controls.Add(Me.SongTitle)
        Me.Controls.Add(Me.AlbumTitle)
        Me.Controls.Add(Me.ArtistTitle)
        Me.Controls.Add(Me.songlengthlbl)
        Me.Controls.Add(Me.songalbumlbl)
        Me.Controls.Add(Me.songnamelbl)
        Me.Controls.Add(Me.songlengthtxt)
        Me.Controls.Add(Me.songalbmtxt)
        Me.Controls.Add(Me.songnametxt)
        Me.Controls.Add(Me.albartistlbl)
        Me.Controls.Add(Me.albmdatelbl)
        Me.Controls.Add(Me.albmnamelbl)
        Me.Controls.Add(Me.coverbtn)
        Me.Controls.Add(Me.albmartisttxt)
        Me.Controls.Add(Me.albmdatetxt)
        Me.Controls.Add(Me.albmnametxt)
        Me.Controls.Add(Me.artimglbl)
        Me.Controls.Add(Me.artcountrylbl)
        Me.Controls.Add(Me.artNamelbl)
        Me.Controls.Add(Me.imagebtn)
        Me.Controls.Add(Me.artimagetxt)
        Me.Controls.Add(Me.artcountrytxt)
        Me.Controls.Add(Me.artnametxt)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_insert)
        Me.Controls.Add(Me.btn_deleteAlbum)
        Me.Controls.Add(Me.btn_updateAlbum)
        Me.Controls.Add(Me.btn_insertAlbum)
        Me.Controls.Add(Me.btn_deleteArtists)
        Me.Controls.Add(Me.btn_updateArtists)
        Me.Controls.Add(Me.btn_insertArtists)
        Me.Name = "InsUpDel"
        Me.Text = "InsUpDel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents albmcoverlbl As Label
    Friend WithEvents albmcovertxt As TextBox
    Friend WithEvents SongTitle As Label
    Friend WithEvents AlbumTitle As Label
    Friend WithEvents ArtistTitle As Label
    Friend WithEvents songlengthlbl As Label
    Friend WithEvents songalbumlbl As Label
    Friend WithEvents songnamelbl As Label
    Friend WithEvents songlengthtxt As TextBox
    Friend WithEvents songalbmtxt As TextBox
    Friend WithEvents songnametxt As TextBox
    Friend WithEvents albartistlbl As Label
    Friend WithEvents albmdatelbl As Label
    Friend WithEvents albmnamelbl As Label
    Friend WithEvents coverbtn As Button
    Friend WithEvents albmartisttxt As TextBox
    Friend WithEvents albmdatetxt As TextBox
    Friend WithEvents albmnametxt As TextBox
    Friend WithEvents artimglbl As Label
    Friend WithEvents artcountrylbl As Label
    Friend WithEvents artNamelbl As Label
    Friend WithEvents imagebtn As Button
    Friend WithEvents artimagetxt As TextBox
    Friend WithEvents artcountrytxt As TextBox
    Friend WithEvents artnametxt As TextBox
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_deleteAlbum As Button
    Friend WithEvents btn_updateAlbum As Button
    Friend WithEvents btn_insertAlbum As Button
    Friend WithEvents btn_deleteArtists As Button
    Friend WithEvents btn_updateArtists As Button
    Friend WithEvents btn_insertArtists As Button
    Friend WithEvents TextBox1 As TextBox
End Class
