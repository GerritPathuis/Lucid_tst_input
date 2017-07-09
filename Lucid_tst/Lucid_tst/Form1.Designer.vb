<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TextBox39 = New System.Windows.Forms.TextBox()
        Me.GroupBox14 = New System.Windows.Forms.GroupBox()
        Me.Label131 = New System.Windows.Forms.Label()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.Label107 = New System.Windows.Forms.Label()
        Me.TextBox38 = New System.Windows.Forms.TextBox()
        Me.Label105 = New System.Windows.Forms.Label()
        Me.TextBox37 = New System.Windows.Forms.TextBox()
        Me.Label102 = New System.Windows.Forms.Label()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label94 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label106 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.btnDisconnect = New System.Windows.Forms.Button()
        Me.combo_Baud = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.combo_Port1 = New System.Windows.Forms.ComboBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox14.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox39
        '
        Me.TextBox39.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox39.Location = New System.Drawing.Point(19, 298)
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.Size = New System.Drawing.Size(149, 24)
        Me.TextBox39.TabIndex = 79
        Me.TextBox39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox14
        '
        Me.GroupBox14.Controls.Add(Me.Label131)
        Me.GroupBox14.Controls.Add(Me.Label130)
        Me.GroupBox14.Controls.Add(Me.Label107)
        Me.GroupBox14.Controls.Add(Me.TextBox38)
        Me.GroupBox14.Controls.Add(Me.Label105)
        Me.GroupBox14.Controls.Add(Me.TextBox37)
        Me.GroupBox14.Controls.Add(Me.Label102)
        Me.GroupBox14.Location = New System.Drawing.Point(19, 149)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(403, 123)
        Me.GroupBox14.TabIndex = 78
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "Feed back from ASC unit (AI4)"
        '
        'Label131
        '
        Me.Label131.AutoSize = True
        Me.Label131.Location = New System.Drawing.Point(356, 12)
        Me.Label131.Name = "Label131"
        Me.Label131.Size = New System.Drawing.Size(27, 13)
        Me.Label131.TabIndex = 75
        Me.Label131.Text = "LSB"
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Location = New System.Drawing.Point(231, 12)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(30, 13)
        Me.Label130.TabIndex = 74
        Me.Label130.Text = "MSB"
        '
        'Label107
        '
        Me.Label107.AutoSize = True
        Me.Label107.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label107.Location = New System.Drawing.Point(15, 30)
        Me.Label107.Name = "Label107"
        Me.Label107.Size = New System.Drawing.Size(125, 18)
        Me.Label107.TabIndex = 73
        Me.Label107.Text = "Input hex, decimal"
        '
        'TextBox38
        '
        Me.TextBox38.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox38.Location = New System.Drawing.Point(234, 27)
        Me.TextBox38.Name = "TextBox38"
        Me.TextBox38.Size = New System.Drawing.Size(149, 24)
        Me.TextBox38.TabIndex = 72
        Me.TextBox38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label105
        '
        Me.Label105.AutoSize = True
        Me.Label105.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label105.Location = New System.Drawing.Point(15, 60)
        Me.Label105.Name = "Label105"
        Me.Label105.Size = New System.Drawing.Size(160, 18)
        Me.Label105.TabIndex = 70
        Me.Label105.Text = "Input Lucid-Control AI4 "
        '
        'TextBox37
        '
        Me.TextBox37.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox37.Location = New System.Drawing.Point(292, 57)
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Size = New System.Drawing.Size(91, 24)
        Me.TextBox37.TabIndex = 67
        Me.TextBox37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label102
        '
        Me.Label102.AutoSize = True
        Me.Label102.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label102.Location = New System.Drawing.Point(231, 60)
        Me.Label102.Name = "Label102"
        Me.Label102.Size = New System.Drawing.Size(25, 18)
        Me.Label102.TabIndex = 66
        Me.Label102.Text = "[V]"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label94)
        Me.GroupBox9.Controls.Add(Me.Button9)
        Me.GroupBox9.Controls.Add(Me.Label106)
        Me.GroupBox9.Controls.Add(Me.Button12)
        Me.GroupBox9.Controls.Add(Me.btnDisconnect)
        Me.GroupBox9.Controls.Add(Me.combo_Baud)
        Me.GroupBox9.Controls.Add(Me.Label25)
        Me.GroupBox9.Controls.Add(Me.combo_Port1)
        Me.GroupBox9.Location = New System.Drawing.Point(19, 12)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(459, 115)
        Me.GroupBox9.TabIndex = 80
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "USB port info"
        '
        'Label94
        '
        Me.Label94.AutoSize = True
        Me.Label94.BackColor = System.Drawing.Color.Red
        Me.Label94.Location = New System.Drawing.Point(214, 55)
        Me.Label94.Name = "Label94"
        Me.Label94.Size = New System.Drawing.Size(18, 13)
        Me.Label94.TabIndex = 9
        Me.Label94.Text = "IN"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.Transparent
        Me.Button9.Location = New System.Drawing.Point(123, 19)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(71, 77)
        Me.Button9.TabIndex = 8
        Me.Button9.Text = "Find ports"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label106
        '
        Me.Label106.AutoSize = True
        Me.Label106.Location = New System.Drawing.Point(15, 51)
        Me.Label106.Name = "Label106"
        Me.Label106.Size = New System.Drawing.Size(80, 13)
        Me.Label106.TabIndex = 7
        Me.Label106.Text = "Receive port_1"
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.Red
        Me.Button12.Location = New System.Drawing.Point(359, 19)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(75, 44)
        Me.Button12.TabIndex = 0
        Me.Button12.Text = "Connect"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(359, 72)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(75, 32)
        Me.btnDisconnect.TabIndex = 1
        Me.btnDisconnect.Text = "Disconnect"
        Me.btnDisconnect.UseVisualStyleBackColor = True
        '
        'combo_Baud
        '
        Me.combo_Baud.FormattingEnabled = True
        Me.combo_Baud.Location = New System.Drawing.Point(220, 21)
        Me.combo_Baud.Name = "combo_Baud"
        Me.combo_Baud.Size = New System.Drawing.Size(94, 21)
        Me.combo_Baud.TabIndex = 3
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(17, 22)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 13)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "Baud rate"
        '
        'combo_Port1
        '
        Me.combo_Port1.BackColor = System.Drawing.SystemColors.Window
        Me.combo_Port1.FormattingEnabled = True
        Me.combo_Port1.Location = New System.Drawing.Point(257, 52)
        Me.combo_Port1.Name = "combo_Port1"
        Me.combo_Port1.Size = New System.Drawing.Size(57, 21)
        Me.combo_Port1.TabIndex = 2
        '
        'SerialPort1
        '
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(378, 298)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 37)
        Me.Button1.TabIndex = 81
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(233, 306)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 18)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Status"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(428, 179)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(50, 37)
        Me.Button2.TabIndex = 82
        Me.Button2.Text = "Go"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(276, 340)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 37)
        Me.Button3.TabIndex = 83
        Me.Button3.Text = "test"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 380)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.TextBox39)
        Me.Controls.Add(Me.GroupBox14)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox14.ResumeLayout(False)
        Me.GroupBox14.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox39 As TextBox
    Friend WithEvents GroupBox14 As GroupBox
    Friend WithEvents Label131 As Label
    Friend WithEvents Label130 As Label
    Friend WithEvents Label107 As Label
    Friend WithEvents TextBox38 As TextBox
    Friend WithEvents Label105 As Label
    Friend WithEvents TextBox37 As TextBox
    Friend WithEvents Label102 As Label
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label94 As Label
    Friend WithEvents Button9 As Button
    Friend WithEvents Label106 As Label
    Friend WithEvents Button12 As Button
    Friend WithEvents btnDisconnect As Button
    Friend WithEvents combo_Baud As ComboBox
    Friend WithEvents Label25 As Label
    Friend WithEvents combo_Port1 As ComboBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
