<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Albums
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
        Me.GoBackBtn = New System.Windows.Forms.Button()
        Me.releaseDate = New System.Windows.Forms.Label()
        Me.aName = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Length = New System.Windows.Forms.Label()
        Me.img_album = New System.Windows.Forms.PictureBox()
        Me.lbl_albums = New System.Windows.Forms.Label()
        Me.lbl_songs = New System.Windows.Forms.Label()
        Me.lbl_artistName = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_length = New System.Windows.Forms.Label()
        Me.lbl_profile = New System.Windows.Forms.Label()
        Me.EmailLog = New System.Windows.Forms.Label()
        CType(Me.img_album, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GoBackBtn
        '
        Me.GoBackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GoBackBtn.Location = New System.Drawing.Point(51, 631)
        Me.GoBackBtn.Name = "GoBackBtn"
        Me.GoBackBtn.Size = New System.Drawing.Size(103, 42)
        Me.GoBackBtn.TabIndex = 11
        Me.GoBackBtn.Text = "Back"
        Me.GoBackBtn.UseVisualStyleBackColor = True
        '
        'releaseDate
        '
        Me.releaseDate.AutoSize = True
        Me.releaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.releaseDate.ForeColor = System.Drawing.Color.White
        Me.releaseDate.Location = New System.Drawing.Point(605, 604)
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
        Me.aName.Location = New System.Drawing.Point(605, 563)
        Me.aName.Name = "aName"
        Me.aName.Size = New System.Drawing.Size(57, 20)
        Me.aName.TabIndex = 7
        Me.aName.Text = "Label1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(33, 79)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(310, 212)
        Me.ListBox1.TabIndex = 6
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(33, 362)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(310, 199)
        Me.ListBox2.TabIndex = 12
        '
        'Length
        '
        Me.Length.AutoSize = True
        Me.Length.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Length.ForeColor = System.Drawing.Color.White
        Me.Length.Location = New System.Drawing.Point(605, 643)
        Me.Length.Name = "Length"
        Me.Length.Size = New System.Drawing.Size(57, 20)
        Me.Length.TabIndex = 13
        Me.Length.Text = "Label2"
        '
        'img_album
        '
        Me.img_album.Image = Global.Songify.My.Resources.Resources.imagenDefault
        Me.img_album.Location = New System.Drawing.Point(395, 32)
        Me.img_album.Name = "img_album"
        Me.img_album.Size = New System.Drawing.Size(522, 508)
        Me.img_album.TabIndex = 9
        Me.img_album.TabStop = False
        '
        'lbl_albums
        '
        Me.lbl_albums.AutoSize = True
        Me.lbl_albums.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_albums.ForeColor = System.Drawing.Color.White
        Me.lbl_albums.Location = New System.Drawing.Point(29, 53)
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
        Me.lbl_songs.Location = New System.Drawing.Point(29, 336)
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
        Me.lbl_artistName.Location = New System.Drawing.Point(467, 560)
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
        Me.lbl_date.Location = New System.Drawing.Point(476, 601)
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
        Me.lbl_length.Location = New System.Drawing.Point(452, 643)
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
        'Albums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(951, 714)
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
End Class
