<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InsUpdDel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InsUpdDel))
        Me.ListBoxArtist = New System.Windows.Forms.ListBox()
        Me.ListBoxAlbum = New System.Windows.Forms.ListBox()
        Me.ListBoxSongs = New System.Windows.Forms.ListBox()
        Me.btn_deleteArtists = New System.Windows.Forms.Button()
        Me.btn_updateArtists = New System.Windows.Forms.Button()
        Me.btn_insertArtists = New System.Windows.Forms.Button()
        Me.btn_deleteAlbum = New System.Windows.Forms.Button()
        Me.btn_updateAlbum = New System.Windows.Forms.Button()
        Me.btn_insertAlbum = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBoxArtist
        '
        Me.ListBoxArtist.FormattingEnabled = True
        Me.ListBoxArtist.Location = New System.Drawing.Point(40, 93)
        Me.ListBoxArtist.Name = "ListBoxArtist"
        Me.ListBoxArtist.Size = New System.Drawing.Size(251, 407)
        Me.ListBoxArtist.TabIndex = 0
        '
        'ListBoxAlbum
        '
        Me.ListBoxAlbum.FormattingEnabled = True
        Me.ListBoxAlbum.Location = New System.Drawing.Point(349, 93)
        Me.ListBoxAlbum.Name = "ListBoxAlbum"
        Me.ListBoxAlbum.Size = New System.Drawing.Size(255, 407)
        Me.ListBoxAlbum.TabIndex = 1
        '
        'ListBoxSongs
        '
        Me.ListBoxSongs.FormattingEnabled = True
        Me.ListBoxSongs.Location = New System.Drawing.Point(665, 93)
        Me.ListBoxSongs.Name = "ListBoxSongs"
        Me.ListBoxSongs.Size = New System.Drawing.Size(255, 407)
        Me.ListBoxSongs.TabIndex = 2
        '
        'btn_deleteArtists
        '
        Me.btn_deleteArtists.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteArtists.ForeColor = System.Drawing.Color.Black
        Me.btn_deleteArtists.Image = Global.Songify.My.Resources.Resources.eliminar
        Me.btn_deleteArtists.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteArtists.Location = New System.Drawing.Point(209, 527)
        Me.btn_deleteArtists.Name = "btn_deleteArtists"
        Me.btn_deleteArtists.Size = New System.Drawing.Size(82, 55)
        Me.btn_deleteArtists.TabIndex = 17
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
        Me.btn_updateArtists.Location = New System.Drawing.Point(124, 527)
        Me.btn_updateArtists.Name = "btn_updateArtists"
        Me.btn_updateArtists.Size = New System.Drawing.Size(82, 55)
        Me.btn_updateArtists.TabIndex = 16
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
        Me.btn_insertArtists.Location = New System.Drawing.Point(40, 527)
        Me.btn_insertArtists.Name = "btn_insertArtists"
        Me.btn_insertArtists.Size = New System.Drawing.Size(79, 55)
        Me.btn_insertArtists.TabIndex = 15
        Me.btn_insertArtists.Text = "Insert"
        Me.btn_insertArtists.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertArtists.UseVisualStyleBackColor = True
        '
        'btn_deleteAlbum
        '
        Me.btn_deleteAlbum.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_deleteAlbum.ForeColor = System.Drawing.Color.Black
        Me.btn_deleteAlbum.Image = Global.Songify.My.Resources.Resources.eliminar
        Me.btn_deleteAlbum.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_deleteAlbum.Location = New System.Drawing.Point(523, 527)
        Me.btn_deleteAlbum.Name = "btn_deleteAlbum"
        Me.btn_deleteAlbum.Size = New System.Drawing.Size(81, 57)
        Me.btn_deleteAlbum.TabIndex = 20
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
        Me.btn_updateAlbum.Location = New System.Drawing.Point(436, 527)
        Me.btn_updateAlbum.Name = "btn_updateAlbum"
        Me.btn_updateAlbum.Size = New System.Drawing.Size(81, 57)
        Me.btn_updateAlbum.TabIndex = 19
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
        Me.btn_insertAlbum.Location = New System.Drawing.Point(349, 527)
        Me.btn_insertAlbum.Name = "btn_insertAlbum"
        Me.btn_insertAlbum.Size = New System.Drawing.Size(81, 57)
        Me.btn_insertAlbum.TabIndex = 18
        Me.btn_insertAlbum.Text = "Insert"
        Me.btn_insertAlbum.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insertAlbum.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.ForeColor = System.Drawing.Color.Black
        Me.btn_delete.Image = Global.Songify.My.Resources.Resources.eliminar
        Me.btn_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(839, 525)
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
        Me.btn_update.Location = New System.Drawing.Point(752, 525)
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
        Me.btn_insert.Location = New System.Drawing.Point(665, 525)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(81, 57)
        Me.btn_insert.TabIndex = 21
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.ForeColor = System.Drawing.Color.Black
        Me.btn_back.Image = Global.Songify.My.Resources.Resources.WhatsApp_Image_2021_04_06_at_12_40_53
        Me.btn_back.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_back.Location = New System.Drawing.Point(40, 636)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(79, 55)
        Me.btn_back.TabIndex = 24
        Me.btn_back.Text = "Back"
        Me.btn_back.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'InsUpdDel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(951, 714)
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
        Me.Controls.Add(Me.ListBoxSongs)
        Me.Controls.Add(Me.ListBoxAlbum)
        Me.Controls.Add(Me.ListBoxArtist)
        Me.Name = "InsUpdDel"
        Me.Text = "InsUpdDel"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListBoxArtist As ListBox
    Friend WithEvents ListBoxAlbum As ListBox
    Friend WithEvents ListBoxSongs As ListBox
    Friend WithEvents btn_deleteArtists As Button
    Friend WithEvents btn_updateArtists As Button
    Friend WithEvents btn_insertArtists As Button
    Friend WithEvents btn_deleteAlbum As Button
    Friend WithEvents btn_updateAlbum As Button
    Friend WithEvents btn_insertAlbum As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_insert As Button
    Friend WithEvents btn_back As Button
End Class
