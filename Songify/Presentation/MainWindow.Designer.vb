<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainWindow
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
        Me.btn_Album = New System.Windows.Forms.Button()
        Me.btn_songs = New System.Windows.Forms.Button()
        Me.btn_signOut = New System.Windows.Forms.Button()
        Me.btn_artists = New System.Windows.Forms.Button()
        Me.lbl_background = New System.Windows.Forms.Label()
        Me.lbl_profile = New System.Windows.Forms.Label()
        Me.EmailLog = New System.Windows.Forms.Label()
        Me.songTXT = New System.Windows.Forms.Label()
        Me.songchoosed = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_Album
        '
        Me.btn_Album.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Album.Image = Global.Songify.My.Resources.Resources.album_de_musica
        Me.btn_Album.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Album.Location = New System.Drawing.Point(374, 225)
        Me.btn_Album.Name = "btn_Album"
        Me.btn_Album.Size = New System.Drawing.Size(217, 64)
        Me.btn_Album.TabIndex = 4
        Me.btn_Album.Text = "Album"
        Me.btn_Album.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Album.UseVisualStyleBackColor = True
        '
        'btn_songs
        '
        Me.btn_songs.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_songs.Image = Global.Songify.My.Resources.Resources.grabacion
        Me.btn_songs.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_songs.Location = New System.Drawing.Point(374, 324)
        Me.btn_songs.Name = "btn_songs"
        Me.btn_songs.Size = New System.Drawing.Size(217, 64)
        Me.btn_songs.TabIndex = 5
        Me.btn_songs.Text = "Songs"
        Me.btn_songs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_songs.UseVisualStyleBackColor = True
        '
        'btn_signOut
        '
        Me.btn_signOut.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signOut.Image = Global.Songify.My.Resources.Resources.power_off
        Me.btn_signOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_signOut.Location = New System.Drawing.Point(374, 518)
        Me.btn_signOut.Name = "btn_signOut"
        Me.btn_signOut.Size = New System.Drawing.Size(217, 64)
        Me.btn_signOut.TabIndex = 7
        Me.btn_signOut.Text = "Sign out"
        Me.btn_signOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_signOut.UseVisualStyleBackColor = True
        '
        'btn_artists
        '
        Me.btn_artists.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_artists.Image = Global.Songify.My.Resources.Resources.cantante
        Me.btn_artists.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_artists.Location = New System.Drawing.Point(374, 125)
        Me.btn_artists.Name = "btn_artists"
        Me.btn_artists.Size = New System.Drawing.Size(217, 64)
        Me.btn_artists.TabIndex = 3
        Me.btn_artists.Text = "Artists"
        Me.btn_artists.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_artists.UseVisualStyleBackColor = True
        '
        'lbl_background
        '
        Me.lbl_background.BackColor = System.Drawing.Color.DarkViolet
        Me.lbl_background.Image = Global.Songify.My.Resources.Resources.fonditomj
        Me.lbl_background.Location = New System.Drawing.Point(296, 45)
        Me.lbl_background.Name = "lbl_background"
        Me.lbl_background.Size = New System.Drawing.Size(392, 579)
        Me.lbl_background.TabIndex = 2
        '
        'lbl_profile
        '
        Me.lbl_profile.AutoSize = True
        Me.lbl_profile.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_profile.ForeColor = System.Drawing.Color.White
        Me.lbl_profile.Location = New System.Drawing.Point(29, 23)
        Me.lbl_profile.Name = "lbl_profile"
        Me.lbl_profile.Size = New System.Drawing.Size(126, 23)
        Me.lbl_profile.TabIndex = 13
        Me.lbl_profile.Text = "Logged as:"
        '
        'EmailLog
        '
        Me.EmailLog.AutoSize = True
        Me.EmailLog.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailLog.ForeColor = System.Drawing.Color.White
        Me.EmailLog.Location = New System.Drawing.Point(161, 23)
        Me.EmailLog.Name = "EmailLog"
        Me.EmailLog.Size = New System.Drawing.Size(61, 23)
        Me.EmailLog.TabIndex = 12
        Me.EmailLog.Text = "rfjpe"
        '
        'songTXT
        '
        Me.songTXT.AutoSize = True
        Me.songTXT.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.songTXT.ForeColor = System.Drawing.Color.White
        Me.songTXT.Location = New System.Drawing.Point(29, 77)
        Me.songTXT.Name = "songTXT"
        Me.songTXT.Size = New System.Drawing.Size(72, 23)
        Me.songTXT.TabIndex = 14
        Me.songTXT.Text = "Song:"
        '
        'songchoosed
        '
        Me.songchoosed.AutoSize = True
        Me.songchoosed.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.songchoosed.ForeColor = System.Drawing.Color.White
        Me.songchoosed.Location = New System.Drawing.Point(107, 77)
        Me.songchoosed.Name = "songchoosed"
        Me.songchoosed.Size = New System.Drawing.Size(61, 23)
        Me.songchoosed.TabIndex = 15
        Me.songchoosed.Text = "rfjpe"
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(951, 714)
        Me.Controls.Add(Me.songchoosed)
        Me.Controls.Add(Me.songTXT)
        Me.Controls.Add(Me.lbl_profile)
        Me.Controls.Add(Me.EmailLog)
        Me.Controls.Add(Me.btn_signOut)
        Me.Controls.Add(Me.btn_songs)
        Me.Controls.Add(Me.btn_Album)
        Me.Controls.Add(Me.btn_artists)
        Me.Controls.Add(Me.lbl_background)
        Me.Name = "MainWindow"
        Me.Text = "MainWindow"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_background As Label
    Friend WithEvents btn_artists As Button
    Friend WithEvents btn_Album As Button
    Friend WithEvents btn_songs As Button
    Friend WithEvents btn_signOut As Button

    Public Artists As Collection
    Public Albums As Collection
    Public Songs As Collection
    Public Email As String
    Public Song As Song
    Private Sub MainWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EmailLog.Text = Email
        songTXT.Visible = False
        songchoosed.Visible = False
        If Song IsNot Nothing Then
            songTXT.Visible = True
            songchoosed.Visible = True
            songchoosed.Text = Song.GetName()
        End If
    End Sub

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Public Sub New(ByVal email As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Email = email

    End Sub
    Public Sub New(ByVal email As String, ByVal song As Song)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Me.Email = email
        Me.Song = song
    End Sub

    Private Sub ArtistBtnClick(sender As Object, e As EventArgs) Handles btn_artists.Click
        Dim f2 As New Artists(Email)
        f2.Show()
        Me.Hide()
    End Sub
    Private Sub AlbumBtnClick(sender As Object, e As EventArgs) Handles btn_Album.Click
        Dim f2 As New Albums(Email)
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub SongBtnClick(sender As Object, e As EventArgs) Handles btn_songs.Click
        Dim f2 As New Songs(Email)
        f2.Show()
        Me.Hide()
    End Sub

    Private Sub btn_play_Click(sender As Object, e As EventArgs)
        If Song Is Nothing Then
            MsgBox("Choose a Song to play")
        Else
            Dim f2 As New SongPlayback(Email, Song)
            f2.Show()
            Me.Hide()
        End If

    End Sub

    Friend WithEvents lbl_profile As Label
    Friend WithEvents EmailLog As Label
    Friend WithEvents songTXT As Label
    Friend WithEvents songchoosed As Label
End Class
