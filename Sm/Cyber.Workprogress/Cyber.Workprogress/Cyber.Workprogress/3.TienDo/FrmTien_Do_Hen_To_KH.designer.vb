<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTien_Do_Hen_To_KH
    Inherits Cyber.From.FrmCalculator

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 73)
        Me.GroupBoxLine.Size = New System.Drawing.Size(549, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(349, 83)
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(451, 83)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(30, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 7144
        Me.Label5.Tag = "Type (R/O)"
        Me.Label5.Text = "Số lệnh"
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.BackColor = System.Drawing.Color.Lavender
        Me.TxtSo_Ro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_Ro.Location = New System.Drawing.Point(90, 26)
        Me.TxtSo_Ro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(155, 21)
        Me.TxtSo_Ro.TabIndex = 7141
        Me.TxtSo_Ro.TabStop = False
        Me.TxtSo_Ro.Tag = ""
        Me.TxtSo_Ro.Text = "01.S15000001"
        Me.TxtSo_Ro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Enabled = False
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtMa_Xe.Location = New System.Drawing.Point(316, 26)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.ReadOnly = True
        Me.TxtMa_Xe.Size = New System.Drawing.Size(143, 21)
        Me.TxtMa_Xe.TabIndex = 7142
        Me.TxtMa_Xe.TabStop = False
        Me.TxtMa_Xe.Tag = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(256, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 7143
        Me.Label4.Tag = "Type (R/O)"
        Me.Label4.Text = "Biển số"
        '
        'FrmCVDV_Hen_To_KH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(553, 137)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSo_Ro)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmCVDV_Hen_To_KH"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ro As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
