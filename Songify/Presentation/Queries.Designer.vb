<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Queries
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
        Me.firstQuerie = New System.Windows.Forms.Button()
        Me.SecondQuerie = New System.Windows.Forms.Button()
        Me.thirdQuerie = New System.Windows.Forms.Button()
        Me.fourthQuerie = New System.Windows.Forms.Button()
        Me.fifthQuerie = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.playbackTime = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'GoBackBtn
        '
        Me.GoBackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GoBackBtn.Location = New System.Drawing.Point(30, 771)
        Me.GoBackBtn.Name = "GoBackBtn"
        Me.GoBackBtn.Size = New System.Drawing.Size(81, 42)
        Me.GoBackBtn.TabIndex = 12
        Me.GoBackBtn.Text = "Back"
        Me.GoBackBtn.UseVisualStyleBackColor = True
        '
        'firstQuerie
        '
        Me.firstQuerie.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstQuerie.Location = New System.Drawing.Point(30, 177)
        Me.firstQuerie.Name = "firstQuerie"
        Me.firstQuerie.Size = New System.Drawing.Size(191, 68)
        Me.firstQuerie.TabIndex = 13
        Me.firstQuerie.Text = "First querie"
        Me.firstQuerie.UseVisualStyleBackColor = True
        '
        'SecondQuerie
        '
        Me.SecondQuerie.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondQuerie.Location = New System.Drawing.Point(30, 387)
        Me.SecondQuerie.Name = "SecondQuerie"
        Me.SecondQuerie.Size = New System.Drawing.Size(191, 68)
        Me.SecondQuerie.TabIndex = 14
        Me.SecondQuerie.Text = "Second querie"
        Me.SecondQuerie.UseVisualStyleBackColor = True
        '
        'thirdQuerie
        '
        Me.thirdQuerie.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdQuerie.Location = New System.Drawing.Point(30, 619)
        Me.thirdQuerie.Name = "thirdQuerie"
        Me.thirdQuerie.Size = New System.Drawing.Size(191, 68)
        Me.thirdQuerie.TabIndex = 15
        Me.thirdQuerie.Text = "Third querie"
        Me.thirdQuerie.UseVisualStyleBackColor = True
        '
        'fourthQuerie
        '
        Me.fourthQuerie.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourthQuerie.Location = New System.Drawing.Point(1045, 177)
        Me.fourthQuerie.Name = "fourthQuerie"
        Me.fourthQuerie.Size = New System.Drawing.Size(191, 68)
        Me.fourthQuerie.TabIndex = 16
        Me.fourthQuerie.Text = "Fourth querie"
        Me.fourthQuerie.UseVisualStyleBackColor = True
        '
        'fifthQuerie
        '
        Me.fifthQuerie.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fifthQuerie.Location = New System.Drawing.Point(1045, 619)
        Me.fifthQuerie.Name = "fifthQuerie"
        Me.fifthQuerie.Size = New System.Drawing.Size(191, 68)
        Me.fifthQuerie.TabIndex = 17
        Me.fifthQuerie.Text = "Fifth querie"
        Me.fifthQuerie.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "List of artists sorted by number of playbacks "
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(457, 35)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "(in general and allowing filtering by country)."
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(26, 343)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(457, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "List of songs sorted by number of playbacks."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 571)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(403, 23)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "List of artists most listened to by a user (between 2 given dates)."
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(833, 571)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(403, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Playback time of a user's favorite artists."
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(854, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(382, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "List of users sorted by time using the application application"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1102, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 23)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "application"
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(498, 88)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(329, 602)
        Me.ListBox1.TabIndex = 25
        Me.ListBox1.Visible = False
        '
        'playbackTime
        '
        Me.playbackTime.AutoSize = True
        Me.playbackTime.Enabled = False
        Me.playbackTime.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playbackTime.ForeColor = System.Drawing.Color.White
        Me.playbackTime.Location = New System.Drawing.Point(539, 387)
        Me.playbackTime.Name = "playbackTime"
        Me.playbackTime.Size = New System.Drawing.Size(103, 32)
        Me.playbackTime.TabIndex = 26
        Me.playbackTime.Text = "Label8"
        Me.playbackTime.Visible = False
        '
        'lblSeconds
        '
        Me.lblSeconds.AutoSize = True
        Me.lblSeconds.Enabled = False
        Me.lblSeconds.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSeconds.ForeColor = System.Drawing.Color.White
        Me.lblSeconds.Location = New System.Drawing.Point(668, 387)
        Me.lblSeconds.Name = "lblSeconds"
        Me.lblSeconds.Size = New System.Drawing.Size(123, 32)
        Me.lblSeconds.TabIndex = 27
        Me.lblSeconds.Text = "seconds"
        Me.lblSeconds.Visible = False
        '
        'ListBox2
        '
        Me.ListBox2.Enabled = False
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(498, 88)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(329, 602)
        Me.ListBox2.TabIndex = 28
        Me.ListBox2.Visible = False
        '
        'ListBox3
        '
        Me.ListBox3.Enabled = False
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(498, 88)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(329, 602)
        Me.ListBox3.TabIndex = 29
        Me.ListBox3.Visible = False
        '
        'ListBox4
        '
        Me.ListBox4.Enabled = False
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(498, 88)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(329, 602)
        Me.ListBox4.TabIndex = 30
        Me.ListBox4.Visible = False
        '
        'Queries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(1271, 865)
        Me.Controls.Add(Me.playbackTime)
        Me.Controls.Add(Me.lblSeconds)
        Me.Controls.Add(Me.ListBox4)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fifthQuerie)
        Me.Controls.Add(Me.fourthQuerie)
        Me.Controls.Add(Me.thirdQuerie)
        Me.Controls.Add(Me.SecondQuerie)
        Me.Controls.Add(Me.firstQuerie)
        Me.Controls.Add(Me.GoBackBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Queries"
        Me.Text = "Queries"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GoBackBtn As Button
    Friend WithEvents firstQuerie As Button
    Friend WithEvents SecondQuerie As Button
    Friend WithEvents thirdQuerie As Button
    Friend WithEvents fourthQuerie As Button
    Friend WithEvents fifthQuerie As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents playbackTime As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
End Class
