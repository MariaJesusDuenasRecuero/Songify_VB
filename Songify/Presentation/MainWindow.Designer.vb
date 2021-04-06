<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.btn_Album = New System.Windows.Forms.Button()
        Me.btn_songs = New System.Windows.Forms.Button()
        Me.btn_play = New System.Windows.Forms.Button()
        Me.btn_signOut = New System.Windows.Forms.Button()
        Me.btn_artists = New System.Windows.Forms.Button()
        Me.lbl_background = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btn_Album
        '
        Me.btn_Album.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Album.Image = Global.Songify.My.Resources.Resources.album_de_musica
        Me.btn_Album.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_Album.Location = New System.Drawing.Point(101, 222)
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
        Me.btn_songs.Location = New System.Drawing.Point(101, 321)
        Me.btn_songs.Name = "btn_songs"
        Me.btn_songs.Size = New System.Drawing.Size(217, 64)
        Me.btn_songs.TabIndex = 5
        Me.btn_songs.Text = "Songs"
        Me.btn_songs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_songs.UseVisualStyleBackColor = True
        '
        'btn_play
        '
        Me.btn_play.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_play.Image = Global.Songify.My.Resources.Resources.jugar
        Me.btn_play.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_play.Location = New System.Drawing.Point(101, 420)
        Me.btn_play.Name = "btn_play"
        Me.btn_play.Size = New System.Drawing.Size(217, 64)
        Me.btn_play.TabIndex = 6
        Me.btn_play.Text = "Play"
        Me.btn_play.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_play.UseVisualStyleBackColor = True
        '
        'btn_signOut
        '
        Me.btn_signOut.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signOut.Image = Global.Songify.My.Resources.Resources.power_off
        Me.btn_signOut.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_signOut.Location = New System.Drawing.Point(101, 540)
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
        Me.btn_artists.Location = New System.Drawing.Point(101, 122)
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
        Me.lbl_background.Location = New System.Drawing.Point(23, 67)
        Me.lbl_background.Name = "lbl_background"
        Me.lbl_background.Size = New System.Drawing.Size(392, 579)
        Me.lbl_background.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(421, 84)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(489, 550)
        Me.ListBox1.TabIndex = 8
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(951, 714)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btn_signOut)
        Me.Controls.Add(Me.btn_play)
        Me.Controls.Add(Me.btn_songs)
        Me.Controls.Add(Me.btn_Album)
        Me.Controls.Add(Me.btn_artists)
        Me.Controls.Add(Me.lbl_background)
        Me.Name = "MainWindow"
        Me.Text = "MainWindow"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_background As Label
    Friend WithEvents btn_artists As Button
    Friend WithEvents btn_Album As Button
    Friend WithEvents btn_songs As Button
    Friend WithEvents btn_play As Button
    Friend WithEvents btn_signOut As Button
    Friend WithEvents ListBox1 As ListBox


End Class
