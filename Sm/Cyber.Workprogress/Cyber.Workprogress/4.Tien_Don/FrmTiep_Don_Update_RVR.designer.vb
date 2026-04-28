<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTiep_Don_Update_RVR
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
        Me.ChkSBD = New System.Windows.Forms.CheckBox()
        Me.ChkSDS = New System.Windows.Forms.CheckBox()
        Me.ChkSCC = New System.Windows.Forms.CheckBox()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 142)
        Me.GroupBoxLine.Size = New System.Drawing.Size(605, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(405, 152)
        Me.ButtOK.TabIndex = 4
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(507, 152)
        Me.ButtExit.TabIndex = 5
        '
        'ChkSBD
        '
        Me.ChkSBD.AutoSize = True
        Me.ChkSBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSBD.ForeColor = System.Drawing.Color.Red
        Me.ChkSBD.Location = New System.Drawing.Point(268, 108)
        Me.ChkSBD.Name = "ChkSBD"
        Me.ChkSBD.Size = New System.Drawing.Size(144, 17)
        Me.ChkSBD.TabIndex = 2
        Me.ChkSBD.Text = "Sửa chữa bảo dưỡng"
        Me.ChkSBD.UseVisualStyleBackColor = True
        '
        'ChkSDS
        '
        Me.ChkSDS.AutoSize = True
        Me.ChkSDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSDS.ForeColor = System.Drawing.Color.Red
        Me.ChkSDS.Location = New System.Drawing.Point(470, 108)
        Me.ChkSDS.Name = "ChkSDS"
        Me.ChkSDS.Size = New System.Drawing.Size(137, 17)
        Me.ChkSDS.TabIndex = 3
        Me.ChkSDS.Text = "Sửa chữa đồng sơn"
        Me.ChkSDS.UseVisualStyleBackColor = True
        '
        'ChkSCC
        '
        Me.ChkSCC.AutoSize = True
        Me.ChkSCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSCC.ForeColor = System.Drawing.Color.Red
        Me.ChkSCC.Location = New System.Drawing.Point(91, 108)
        Me.ChkSCC.Name = "ChkSCC"
        Me.ChkSCC.Size = New System.Drawing.Size(119, 17)
        Me.ChkSCC.TabIndex = 1
        Me.ChkSCC.Text = "Sửa chữa chung"
        Me.ChkSCC.UseVisualStyleBackColor = True
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(43, 155)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(45, 21)
        Me.TxtMa_Dvcs.TabIndex = 7211
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Tag = ""
        Me.TxtMa_Dvcs.Visible = False
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(90, 17)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(517, 80)
        Me.TxtMa_Xe.TabIndex = 0
        Me.TxtMa_Xe.Tag = ""
        Me.TxtMa_Xe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(10, 40)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 32)
        Me.Label4.TabIndex = 7214
        Me.Label4.Tag = "Type (R/O)"
        Me.Label4.Text = "Biển số"
        '
        'FrmTiep_Don_Update_RVR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(609, 206)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.ChkSDS)
        Me.Controls.Add(Me.ChkSBD)
        Me.Controls.Add(Me.ChkSCC)
        Me.Name = "FrmTiep_Don_Update_RVR"
        Me.Text = "Cập nhật thông tin xe vào"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ChkSCC, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkSBD, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.ChkSDS, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChkSBD As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSDS As System.Windows.Forms.CheckBox
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
