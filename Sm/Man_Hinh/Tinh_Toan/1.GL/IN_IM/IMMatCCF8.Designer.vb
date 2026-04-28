<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMMatCCF8
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
        Me.TxtTen_Cc = New System.Windows.Forms.TextBox()
        Me.Txtma_Cc = New System.Windows.Forms.TextBox()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.ChkThoi_PB = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtNgay_Thoi = New ClsTextBox.txtDate1()
        Me.TxtNgay_CT = New ClsTextBox.txtDate1()
        Me.txtLy_do = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 145)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(674, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(474, 155)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 5
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(576, 155)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 6
        '
        'TxtTen_Cc
        '
        Me.TxtTen_Cc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTen_Cc.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cc.Location = New System.Drawing.Point(217, 8)
        Me.TxtTen_Cc.Name = "TxtTen_Cc"
        Me.TxtTen_Cc.ReadOnly = True
        Me.TxtTen_Cc.Size = New System.Drawing.Size(460, 21)
        Me.TxtTen_Cc.TabIndex = 352
        '
        'Txtma_Cc
        '
        Me.Txtma_Cc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtma_Cc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Txtma_Cc.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_Cc.Location = New System.Drawing.Point(83, 8)
        Me.Txtma_Cc.Name = "Txtma_Cc"
        Me.Txtma_Cc.ReadOnly = True
        Me.Txtma_Cc.Size = New System.Drawing.Size(130, 21)
        Me.Txtma_Cc.TabIndex = 0
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbMa_Phi.Location = New System.Drawing.Point(5, 12)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(74, 20)
        Me.lbMa_Phi.TabIndex = 353
        Me.lbMa_Phi.Tag = "Tool"
        Me.lbMa_Phi.Text = "Mã công cụ"
        '
        'ChkThoi_PB
        '
        Me.ChkThoi_PB.AutoSize = True
        Me.ChkThoi_PB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ChkThoi_PB.Location = New System.Drawing.Point(83, 66)
        Me.ChkThoi_PB.Name = "ChkThoi_PB"
        Me.ChkThoi_PB.Size = New System.Drawing.Size(140, 19)
        Me.ChkThoi_PB.TabIndex = 2
        Me.ChkThoi_PB.Tag = "Stop allocating tooling tools"
        Me.ChkThoi_PB.Text = "Mất công cụ dụng cụ"
        Me.ChkThoi_PB.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(5, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 20)
        Me.Label1.TabIndex = 357
        Me.Label1.Tag = "Date"
        Me.Label1.Text = "Ngày xuất"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(5, 97)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(32, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 361
        Me.LabM_Ngay_Ct1.Tag = "Stop Date "
        Me.LabM_Ngay_Ct1.Text = "Ngày"
        '
        'TxtNgay_Thoi
        '
        Me.TxtNgay_Thoi.Flags = 0
        Me.TxtNgay_Thoi.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Thoi.IsAllowResize = False
        Me.TxtNgay_Thoi.isEmpty = True
        Me.TxtNgay_Thoi.Location = New System.Drawing.Point(83, 94)
        Me.TxtNgay_Thoi.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Thoi.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Thoi.MaxLength = 10
        Me.TxtNgay_Thoi.Name = "TxtNgay_Thoi"
        Me.TxtNgay_Thoi.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Thoi.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Thoi.ShowDayBeforeMonth = False
        Me.TxtNgay_Thoi.Size = New System.Drawing.Size(114, 20)
        Me.TxtNgay_Thoi.TabIndex = 3
        Me.TxtNgay_Thoi.Text = "__/__/____"
        Me.TxtNgay_Thoi.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtNgay_CT
        '
        Me.TxtNgay_CT.Enabled = False
        Me.TxtNgay_CT.Flags = 0
        Me.TxtNgay_CT.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_CT.IsAllowResize = False
        Me.TxtNgay_CT.isEmpty = True
        Me.TxtNgay_CT.Location = New System.Drawing.Point(82, 32)
        Me.TxtNgay_CT.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_CT.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_CT.MaxLength = 10
        Me.TxtNgay_CT.Name = "TxtNgay_CT"
        Me.TxtNgay_CT.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_CT.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_CT.ShowDayBeforeMonth = False
        Me.TxtNgay_CT.Size = New System.Drawing.Size(114, 20)
        Me.TxtNgay_CT.TabIndex = 1
        Me.TxtNgay_CT.Text = "__/__/____"
        Me.TxtNgay_CT.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'txtLy_do
        '
        Me.txtLy_do.BackColor = System.Drawing.Color.White
        Me.txtLy_do.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLy_do.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtLy_do.ForeColor = System.Drawing.Color.Navy
        Me.txtLy_do.Location = New System.Drawing.Point(83, 119)
        Me.txtLy_do.Name = "txtLy_do"
        Me.txtLy_do.Size = New System.Drawing.Size(593, 21)
        Me.txtLy_do.TabIndex = 4
        Me.txtLy_do.Tag = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(5, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 510
        Me.Label2.Tag = "Reason"
        Me.Label2.Text = "Lý do "
        '
        'IMMatCCF8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(678, 209)
        Me.Controls.Add(Me.txtLy_do)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNgay_CT)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtNgay_Thoi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChkThoi_PB)
        Me.Controls.Add(Me.TxtTen_Cc)
        Me.Controls.Add(Me.Txtma_Cc)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "IMMatCCF8"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.Txtma_Cc, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cc, 0)
        Me.Controls.SetChildIndex(Me.ChkThoi_PB, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Thoi, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CT, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtLy_do, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTen_Cc As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_Cc As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents ChkThoi_PB As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Thoi As ClsTextBox.txtDate1
    Friend WithEvents TxtNgay_CT As ClsTextBox.txtDate1
    Friend WithEvents txtLy_do As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
