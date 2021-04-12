<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SongPlayback
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.email = New System.Windows.Forms.Label()
        Me.Play = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(73, 316)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(265, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.email.ForeColor = System.Drawing.Color.White
        Me.email.Location = New System.Drawing.Point(161, 276)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(66, 24)
        Me.email.TabIndex = 3
        Me.email.Text = "Label1"
        '
        'Play
        '
        Me.Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.Play.Image = Global.Songify.My.Resources.Resources.jugar1
        Me.Play.Location = New System.Drawing.Point(165, 371)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(70, 49)
        Me.Play.TabIndex = 0
        Me.Play.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(73, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(265, 250)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'SongPlayback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(399, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.email)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Play)
        Me.Name = "SongPlayback"
        Me.Text = "Playback"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Play As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents email As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
