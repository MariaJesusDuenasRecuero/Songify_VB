<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btn_login = New System.Windows.Forms.Button()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.ofdPath = New System.Windows.Forms.OpenFileDialog()
        Me.btn_connect = New System.Windows.Forms.Button()
        Me.btn_selectDB = New System.Windows.Forms.Button()
        Me.lbl_iconEmail = New System.Windows.Forms.Label()
        Me.btn_signUp = New System.Windows.Forms.Button()
        Me.lbl_songify = New System.Windows.Forms.Label()
        Me.lbl_background = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_login.BackColor = System.Drawing.Color.White
        Me.btn_login.Enabled = False
        Me.btn_login.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.Location = New System.Drawing.Point(315, 398)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(279, 42)
        Me.btn_login.TabIndex = 2
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'txt_email
        '
        Me.txt_email.Enabled = False
        Me.txt_email.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_email.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.txt_email.Location = New System.Drawing.Point(355, 321)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(239, 31)
        Me.txt_email.TabIndex = 4
        Me.txt_email.Text = "Email"
        '
        'ofdPath
        '
        Me.ofdPath.FileName = "OpenFileDialog1"
        '
        'btn_connect
        '
        Me.btn_connect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_connect.BackColor = System.Drawing.Color.White
        Me.btn_connect.Enabled = False
        Me.btn_connect.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_connect.Image = Global.Songify.My.Resources.Resources.bases_de_datos_conectadas
        Me.btn_connect.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_connect.Location = New System.Drawing.Point(476, 533)
        Me.btn_connect.Name = "btn_connect"
        Me.btn_connect.Size = New System.Drawing.Size(118, 58)
        Me.btn_connect.TabIndex = 8
        Me.btn_connect.Text = "Connect"
        Me.btn_connect.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_connect.UseVisualStyleBackColor = False
        '
        'btn_selectDB
        '
        Me.btn_selectDB.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_selectDB.BackColor = System.Drawing.Color.White
        Me.btn_selectDB.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_selectDB.Image = Global.Songify.My.Resources.Resources.busqueda_de_datos__1_
        Me.btn_selectDB.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btn_selectDB.Location = New System.Drawing.Point(315, 533)
        Me.btn_selectDB.Name = "btn_selectDB"
        Me.btn_selectDB.Size = New System.Drawing.Size(118, 58)
        Me.btn_selectDB.TabIndex = 7
        Me.btn_selectDB.Text = "Select"
        Me.btn_selectDB.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_selectDB.UseVisualStyleBackColor = False
        '
        'lbl_iconEmail
        '
        Me.lbl_iconEmail.BackColor = System.Drawing.Color.White
        Me.lbl_iconEmail.Image = Global.Songify.My.Resources.Resources.email
        Me.lbl_iconEmail.Location = New System.Drawing.Point(312, 321)
        Me.lbl_iconEmail.Name = "lbl_iconEmail"
        Me.lbl_iconEmail.Size = New System.Drawing.Size(37, 31)
        Me.lbl_iconEmail.TabIndex = 6
        '
        'btn_signUp
        '
        Me.btn_signUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btn_signUp.BackColor = System.Drawing.Color.White
        Me.btn_signUp.Enabled = False
        Me.btn_signUp.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_signUp.Location = New System.Drawing.Point(315, 456)
        Me.btn_signUp.Name = "btn_signUp"
        Me.btn_signUp.Size = New System.Drawing.Size(279, 42)
        Me.btn_signUp.TabIndex = 3
        Me.btn_signUp.Text = "Sign up"
        Me.btn_signUp.UseVisualStyleBackColor = False
        '
        'lbl_songify
        '
        Me.lbl_songify.BackColor = System.Drawing.Color.White
        Me.lbl_songify.Image = Global.Songify.My.Resources.Resources.logo
        Me.lbl_songify.Location = New System.Drawing.Point(275, 92)
        Me.lbl_songify.Name = "lbl_songify"
        Me.lbl_songify.Size = New System.Drawing.Size(358, 180)
        Me.lbl_songify.TabIndex = 1
        '
        'lbl_background
        '
        Me.lbl_background.Image = Global.Songify.My.Resources.Resources.fonditomj
        Me.lbl_background.Location = New System.Drawing.Point(186, 22)
        Me.lbl_background.Name = "lbl_background"
        Me.lbl_background.Size = New System.Drawing.Size(543, 633)
        Me.lbl_background.TabIndex = 0
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(951, 714)
        Me.Controls.Add(Me.btn_connect)
        Me.Controls.Add(Me.btn_selectDB)
        Me.Controls.Add(Me.lbl_iconEmail)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.btn_signUp)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.lbl_songify)
        Me.Controls.Add(Me.lbl_background)
        Me.Name = "Login"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_background As Label
    Friend WithEvents lbl_songify As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_signUp As Button
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_iconEmail As Label
    Friend WithEvents btn_selectDB As Button
    Friend WithEvents ofdPath As OpenFileDialog
    Friend WithEvents btn_connect As Button
End Class
