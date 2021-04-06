<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignUp
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
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_loginSignUp = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_surname = New System.Windows.Forms.TextBox()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.txt_birthdate = New System.Windows.Forms.TextBox()
        Me.lbl_introduceCredentials = New System.Windows.Forms.Label()
        Me.lbl_background = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_back.BackColor = System.Drawing.Color.White
        Me.btn_back.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(338, 552)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(264, 42)
        Me.btn_back.TabIndex = 5
        Me.btn_back.Text = "Back"
        Me.btn_back.UseVisualStyleBackColor = False
        '
        'btn_loginSignUp
        '
        Me.btn_loginSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_loginSignUp.BackColor = System.Drawing.Color.White
        Me.btn_loginSignUp.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_loginSignUp.Location = New System.Drawing.Point(338, 494)
        Me.btn_loginSignUp.Name = "btn_loginSignUp"
        Me.btn_loginSignUp.Size = New System.Drawing.Size(264, 42)
        Me.btn_loginSignUp.TabIndex = 4
        Me.btn_loginSignUp.Text = "Sign up"
        Me.btn_loginSignUp.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_name.Location = New System.Drawing.Point(389, 195)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(213, 31)
        Me.txt_name.TabIndex = 6
        Me.txt_name.Text = "Name"
        '
        'txt_surname
        '
        Me.txt_surname.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_surname.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_surname.Location = New System.Drawing.Point(389, 270)
        Me.txt_surname.Name = "txt_surname"
        Me.txt_surname.Size = New System.Drawing.Size(213, 31)
        Me.txt_surname.TabIndex = 7
        Me.txt_surname.Text = "Surname"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_email.Location = New System.Drawing.Point(389, 348)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(213, 31)
        Me.txt_email.TabIndex = 8
        Me.txt_email.Text = "Email"
        '
        'txt_birthdate
        '
        Me.txt_birthdate.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_birthdate.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_birthdate.Location = New System.Drawing.Point(389, 421)
        Me.txt_birthdate.Name = "txt_birthdate"
        Me.txt_birthdate.Size = New System.Drawing.Size(213, 31)
        Me.txt_birthdate.TabIndex = 9
        Me.txt_birthdate.Text = "Birthdate"
        '
        'lbl_introduceCredentials
        '
        Me.lbl_introduceCredentials.AutoSize = True
        Me.lbl_introduceCredentials.BackColor = System.Drawing.Color.White
        Me.lbl_introduceCredentials.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_introduceCredentials.ForeColor = System.Drawing.Color.DarkViolet
        Me.lbl_introduceCredentials.Location = New System.Drawing.Point(317, 118)
        Me.lbl_introduceCredentials.Name = "lbl_introduceCredentials"
        Me.lbl_introduceCredentials.Size = New System.Drawing.Size(303, 29)
        Me.lbl_introduceCredentials.TabIndex = 10
        Me.lbl_introduceCredentials.Text = "Introduce credentials"
        '
        'lbl_background
        '
        Me.lbl_background.Image = Global.Songify.My.Resources.Resources.fonditomj
        Me.lbl_background.Location = New System.Drawing.Point(204, 41)
        Me.lbl_background.Name = "lbl_background"
        Me.lbl_background.Size = New System.Drawing.Size(543, 633)
        Me.lbl_background.TabIndex = 1
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(951, 714)
        Me.Controls.Add(Me.lbl_introduceCredentials)
        Me.Controls.Add(Me.txt_birthdate)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.txt_surname)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_loginSignUp)
        Me.Controls.Add(Me.lbl_background)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_background As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_loginSignUp As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents txt_surname As TextBox
    Friend WithEvents txt_email As TextBox
    Friend WithEvents txt_birthdate As TextBox
    Friend WithEvents lbl_introduceCredentials As Label
End Class
