<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTopic = New System.Windows.Forms.Label()
        Me.btnShow = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnPop = New System.Windows.Forms.Button()
        Me.btnText = New System.Windows.Forms.Button()
        Me.txtShow = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTopic
        '
        Me.lblTopic.AutoSize = True
        Me.lblTopic.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblTopic.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblTopic.Location = New System.Drawing.Point(253, 60)
        Me.lblTopic.Name = "lblTopic"
        Me.lblTopic.Size = New System.Drawing.Size(270, 20)
        Me.lblTopic.TabIndex = 0
        Me.lblTopic.Text = "Welcome to My First Form in VB "
        '
        'btnShow
        '
        Me.btnShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnShow.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShow.Location = New System.Drawing.Point(294, 100)
        Me.btnShow.Name = "btnShow"
        Me.btnShow.Size = New System.Drawing.Size(182, 49)
        Me.btnShow.TabIndex = 1
        Me.btnShow.Text = "SHOW POP UP"
        Me.btnShow.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblName.Location = New System.Drawing.Point(105, 187)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(154, 20)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "ENTER YOUR NAME:"
        '
        'btnPop
        '
        Me.btnPop.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnPop.Location = New System.Drawing.Point(275, 240)
        Me.btnPop.Name = "btnPop"
        Me.btnPop.Size = New System.Drawing.Size(75, 31)
        Me.btnPop.TabIndex = 3
        Me.btnPop.Text = "POP UP"
        Me.btnPop.UseVisualStyleBackColor = True
        '
        'btnText
        '
        Me.btnText.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnText.Location = New System.Drawing.Point(401, 240)
        Me.btnText.Name = "btnText"
        Me.btnText.Size = New System.Drawing.Size(91, 31)
        Me.btnText.TabIndex = 4
        Me.btnText.Text = "TEXTBOX"
        Me.btnText.UseVisualStyleBackColor = True
        '
        'txtShow
        '
        Me.txtShow.Location = New System.Drawing.Point(265, 299)
        Me.txtShow.Name = "txtShow"
        Me.txtShow.Size = New System.Drawing.Size(241, 23)
        Me.txtShow.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(265, 188)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(241, 23)
        Me.txtName.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.HotPink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtShow)
        Me.Controls.Add(Me.btnText)
        Me.Controls.Add(Me.btnPop)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnShow)
        Me.Controls.Add(Me.lblTopic)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTopic As Label
    Friend WithEvents btnShow As Button
    Friend WithEvents lblName As Label
    Friend WithEvents btnPop As Button
    Friend WithEvents btnText As Button
    Friend WithEvents txtShow As TextBox
    Friend WithEvents txtName As TextBox
End Class
