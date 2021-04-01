<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SignUp
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
        Me.lbl_background = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_loginSignUp = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_background
        '
        Me.lbl_background.Image = Global.Songify.My.Resources.Resources.fonditomj
        Me.lbl_background.Location = New System.Drawing.Point(204, 41)
        Me.lbl_background.Name = "lbl_background"
        Me.lbl_background.Size = New System.Drawing.Size(543, 633)
        Me.lbl_background.TabIndex = 1
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
        Me.btn_loginSignUp.Text = "Login"
        Me.btn_loginSignUp.UseVisualStyleBackColor = False
        '
        'SignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkViolet
        Me.ClientSize = New System.Drawing.Size(951, 714)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_loginSignUp)
        Me.Controls.Add(Me.lbl_background)
        Me.Name = "SignUp"
        Me.Text = "SignUp"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_background As Label
    Friend WithEvents btn_back As Button
    Friend WithEvents btn_loginSignUp As Button
End Class
