<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmXNTiep_Don
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
        Me.ChkGiai_Phong = New System.Windows.Forms.CheckBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 101)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(772, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(505, 113)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtOK.TabIndex = 16
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(641, 113)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtExit.TabIndex = 17
        '
        'ChkGiai_Phong
        '
        Me.ChkGiai_Phong.AutoSize = True
        Me.ChkGiai_Phong.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkGiai_Phong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkGiai_Phong.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ChkGiai_Phong.Location = New System.Drawing.Point(251, 52)
        Me.ChkGiai_Phong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkGiai_Phong.Name = "ChkGiai_Phong"
        Me.ChkGiai_Phong.Size = New System.Drawing.Size(173, 21)
        Me.ChkGiai_Phong.TabIndex = 13
        Me.ChkGiai_Phong.Tag = "Free"
        Me.ChkGiai_Phong.Text = "Giải phóng tiếp đón"
        Me.ChkGiai_Phong.UseVisualStyleBackColor = True
        Me.ChkGiai_Phong.Visible = False
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Xe.Location = New System.Drawing.Point(251, 12)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(241, 30)
        Me.TxtMa_Xe.TabIndex = 6
        Me.TxtMa_Xe.Tag = ""
        Me.TxtMa_Xe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.ForeColor = System.Drawing.Color.Blue
        Me.Label35.Location = New System.Drawing.Point(127, 14)
        Me.Label35.Margin = New System.Windows.Forms.Padding(0)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(55, 17)
        Me.Label35.TabIndex = 2036
        Me.Label35.Tag = "License plate"
        Me.Label35.Text = "Biển số"
        '
        'FrmXNTiep_Don
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(777, 180)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.ChkGiai_Phong)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MinimizeBox = False
        Me.Name = "FrmXNTiep_Don"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.ChkGiai_Phong, 0)
        Me.Controls.SetChildIndex(Me.Label35, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChkGiai_Phong As System.Windows.Forms.CheckBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label

End Class
