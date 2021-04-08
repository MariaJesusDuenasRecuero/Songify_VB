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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.releaseDate = New System.Windows.Forms.Label()
        Me.aName = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GoBackBtn
        '
        Me.GoBackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GoBackBtn.Location = New System.Drawing.Point(223, 315)
        Me.GoBackBtn.Name = "GoBackBtn"
        Me.GoBackBtn.Size = New System.Drawing.Size(103, 42)
        Me.GoBackBtn.TabIndex = 11
        Me.GoBackBtn.Text = "Back"
        Me.GoBackBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(13, 269)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 103)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'releaseDate
        '
        Me.releaseDate.AutoSize = True
        Me.releaseDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.releaseDate.Location = New System.Drawing.Point(179, 184)
        Me.releaseDate.Name = "releaseDate"
        Me.releaseDate.Size = New System.Drawing.Size(57, 20)
        Me.releaseDate.TabIndex = 8
        Me.releaseDate.Text = "Label2"
        '
        'aName
        '
        Me.aName.AutoSize = True
        Me.aName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.aName.Location = New System.Drawing.Point(179, 52)
        Me.aName.Name = "aName"
        Me.aName.Size = New System.Drawing.Size(57, 20)
        Me.aName.TabIndex = 7
        Me.aName.Text = "Label1"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(151, 238)
        Me.ListBox1.TabIndex = 6
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(416, 12)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(127, 238)
        Me.ListBox2.TabIndex = 12
        '
        'Albums
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(555, 408)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.GoBackBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.releaseDate)
        Me.Controls.Add(Me.aName)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Albums"
        Me.Text = "Albums"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GoBackBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents releaseDate As Label
    Friend WithEvents aName As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
End Class
