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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.aName = New System.Windows.Forms.Label()
        Me.country = New System.Windows.Forms.Label()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.GoBackBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(151, 238)
        Me.ListBox1.TabIndex = 0
        '
        'aName
        '
        Me.aName.AutoSize = True
        Me.aName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.aName.Location = New System.Drawing.Point(217, 62)
        Me.aName.Name = "aName"
        Me.aName.Size = New System.Drawing.Size(77, 26)
        Me.aName.TabIndex = 1
        Me.aName.Text = "Label1"
        '
        'country
        '
        Me.country.AutoSize = True
        Me.country.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.country.Location = New System.Drawing.Point(217, 150)
        Me.country.Name = "country"
        Me.country.Size = New System.Drawing.Size(77, 26)
        Me.country.TabIndex = 2
        Me.country.Text = "Label2"
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(389, 12)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(151, 238)
        Me.ListBox2.TabIndex = 4
        '
        'GoBackBtn
        '
        Me.GoBackBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.GoBackBtn.Location = New System.Drawing.Point(222, 315)
        Me.GoBackBtn.Name = "GoBackBtn"
        Me.GoBackBtn.Size = New System.Drawing.Size(103, 42)
        Me.GoBackBtn.TabIndex = 5
        Me.GoBackBtn.Text = "Back"
        Me.GoBackBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 269)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(151, 103)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Artists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(555, 404)
        Me.Controls.Add(Me.GoBackBtn)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.country)
        Me.Controls.Add(Me.aName)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Artists"
        Me.Text = "Artists"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents aName As Label
    Friend WithEvents country As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents GoBackBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
