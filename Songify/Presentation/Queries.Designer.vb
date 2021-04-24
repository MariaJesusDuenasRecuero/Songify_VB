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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Queries))
        Me.GoBackBtn = New System.Windows.Forms.Button()
        Me.fourthQuerie = New System.Windows.Forms.Button()
        Me.fifthQuerie = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.playbackTime = New System.Windows.Forms.Label()
        Me.lblSeconds = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.firstquerieCountry = New System.Windows.Forms.Button()
        Me.thirdQuerie = New System.Windows.Forms.Button()
        Me.SecondQuerie = New System.Windows.Forms.Button()
        Me.firstQuerie = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GoBackBtn
        '
        Me.GoBackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GoBackBtn.Image = Global.Songify.My.Resources.Resources.WhatsApp_Image_2021_04_06_at_12_40_53
        Me.GoBackBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GoBackBtn.Location = New System.Drawing.Point(34, 794)
        Me.GoBackBtn.Name = "GoBackBtn"
        Me.GoBackBtn.Size = New System.Drawing.Size(99, 42)
        Me.GoBackBtn.TabIndex = 12
        Me.GoBackBtn.Text = "Back"
        Me.GoBackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.GoBackBtn.UseVisualStyleBackColor = True
        '
        'fourthQuerie
        '
        Me.fourthQuerie.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fourthQuerie.Image = Global.Songify.My.Resources.Resources.lupa
        Me.fourthQuerie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.fourthQuerie.Location = New System.Drawing.Point(454, 542)
        Me.fourthQuerie.Name = "fourthQuerie"
        Me.fourthQuerie.Size = New System.Drawing.Size(87, 42)
        Me.fourthQuerie.TabIndex = 16
        Me.fourthQuerie.Text = "Search"
        Me.fourthQuerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.fourthQuerie.UseVisualStyleBackColor = True
        '
        'fifthQuerie
        '
        Me.fifthQuerie.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fifthQuerie.Image = Global.Songify.My.Resources.Resources.lupa
        Me.fifthQuerie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.fifthQuerie.Location = New System.Drawing.Point(454, 642)
        Me.fifthQuerie.Name = "fifthQuerie"
        Me.fifthQuerie.Size = New System.Drawing.Size(84, 42)
        Me.fifthQuerie.TabIndex = 17
        Me.fifthQuerie.Text = "Search"
        Me.fifthQuerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.fifthQuerie.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(24, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "List of artists sorted by number of playbacks "
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 305)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(403, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "List of songs sorted by number of playbacks."
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(25, 399)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(357, 23)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "List of artists most listened to by a user (between 2 given dates)."
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(29, 661)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(354, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Playback time of a user's favorite artists."
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(29, 554)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(319, 23)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "List of users sorted by time using the application application"
        '
        'ListBox1
        '
        Me.ListBox1.Enabled = False
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(914, 139)
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
        Me.playbackTime.Location = New System.Drawing.Point(1025, 352)
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
        Me.lblSeconds.Location = New System.Drawing.Point(1025, 405)
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
        Me.ListBox2.Location = New System.Drawing.Point(914, 139)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(329, 602)
        Me.ListBox2.TabIndex = 28
        Me.ListBox2.Visible = False
        '
        'ListBox3
        '
        Me.ListBox3.Enabled = False
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(914, 139)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(329, 602)
        Me.ListBox3.TabIndex = 29
        Me.ListBox3.Visible = False
        '
        'ListBox4
        '
        Me.ListBox4.Enabled = False
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(914, 139)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(329, 602)
        Me.ListBox4.TabIndex = 30
        Me.ListBox4.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(621, 204)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(176, 20)
        Me.TextBox1.TabIndex = 31
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(455, 447)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(139, 20)
        Me.TextBox2.TabIndex = 33
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(633, 447)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(139, 20)
        Me.TextBox3.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(598, 437)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 33)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "-"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(451, 390)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(212, 21)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Introduce two dates"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(618, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(212, 21)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Introduce a country"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(326, 554)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 23)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "application"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(12, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Image = Global.Songify.My.Resources.Resources.calendar
        Me.Label11.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Location = New System.Drawing.Point(633, 426)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(139, 18)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Finished date"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Image = Global.Songify.My.Resources.Resources.calendar
        Me.Label10.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Location = New System.Drawing.Point(455, 428)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 18)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Begin date"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'firstquerieCountry
        '
        Me.firstquerieCountry.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstquerieCountry.Image = Global.Songify.My.Resources.Resources.lupa
        Me.firstquerieCountry.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.firstquerieCountry.Location = New System.Drawing.Point(714, 230)
        Me.firstquerieCountry.Name = "firstquerieCountry"
        Me.firstquerieCountry.Size = New System.Drawing.Size(83, 35)
        Me.firstquerieCountry.TabIndex = 32
        Me.firstquerieCountry.Text = "Search"
        Me.firstquerieCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.firstquerieCountry.UseVisualStyleBackColor = True
        '
        'thirdQuerie
        '
        Me.thirdQuerie.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.thirdQuerie.Image = Global.Songify.My.Resources.Resources.lupa
        Me.thirdQuerie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.thirdQuerie.Location = New System.Drawing.Point(689, 473)
        Me.thirdQuerie.Name = "thirdQuerie"
        Me.thirdQuerie.Size = New System.Drawing.Size(83, 32)
        Me.thirdQuerie.TabIndex = 15
        Me.thirdQuerie.Text = "Search"
        Me.thirdQuerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.thirdQuerie.UseVisualStyleBackColor = True
        '
        'SecondQuerie
        '
        Me.SecondQuerie.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondQuerie.Image = Global.Songify.My.Resources.Resources.lupa
        Me.SecondQuerie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SecondQuerie.Location = New System.Drawing.Point(457, 301)
        Me.SecondQuerie.Name = "SecondQuerie"
        Me.SecondQuerie.Size = New System.Drawing.Size(83, 42)
        Me.SecondQuerie.TabIndex = 14
        Me.SecondQuerie.Text = "Search"
        Me.SecondQuerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SecondQuerie.UseVisualStyleBackColor = True
        '
        'firstQuerie
        '
        Me.firstQuerie.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firstQuerie.Image = Global.Songify.My.Resources.Resources.lupa
        Me.firstQuerie.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.firstQuerie.Location = New System.Drawing.Point(454, 171)
        Me.firstQuerie.Name = "firstQuerie"
        Me.firstQuerie.Size = New System.Drawing.Size(116, 53)
        Me.firstQuerie.TabIndex = 13
        Me.firstQuerie.Text = "Search by playbacks"
        Me.firstQuerie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.firstQuerie.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(517, 36)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(232, 59)
        Me.Label13.TabIndex = 41
        Me.Label13.Text = "Queries"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(847, 129)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(23, 612)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "|" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Queries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(1271, 865)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.firstquerieCountry)
        Me.Controls.Add(Me.TextBox1)
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
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.fifthQuerie)
        Me.Controls.Add(Me.fourthQuerie)
        Me.Controls.Add(Me.thirdQuerie)
        Me.Controls.Add(Me.SecondQuerie)
        Me.Controls.Add(Me.firstQuerie)
        Me.Controls.Add(Me.GoBackBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Queries"
        Me.Text = "Statistics"
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
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents playbackTime As Label
    Friend WithEvents lblSeconds As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents firstquerieCountry As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
End Class
