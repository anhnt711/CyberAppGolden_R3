<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAThoiKHF3VAT
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
        Me.TxtTen_ts = New System.Windows.Forms.TextBox()
        Me.Txtma_Ts = New System.Windows.Forms.TextBox()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.ChkThoi_Kh = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_NV = New System.Windows.Forms.TextBox()
        Me.TxtMa_NV = New System.Windows.Forms.TextBox()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtNgay_Thoi = New ClsTextBox.txtDate1()
        Me.txtLy_do = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 171)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(899, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(632, 183)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtOK.TabIndex = 5
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(768, 183)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtExit.TabIndex = 6
        '
        'TxtTen_ts
        '
        Me.TxtTen_ts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTen_ts.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ts.Location = New System.Drawing.Point(289, 10)
        Me.TxtTen_ts.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_ts.Name = "TxtTen_ts"
        Me.TxtTen_ts.ReadOnly = True
        Me.TxtTen_ts.Size = New System.Drawing.Size(612, 24)
        Me.TxtTen_ts.TabIndex = 352
        '
        'Txtma_Ts
        '
        Me.Txtma_Ts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtma_Ts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Txtma_Ts.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_Ts.Location = New System.Drawing.Point(111, 10)
        Me.Txtma_Ts.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtma_Ts.Name = "Txtma_Ts"
        Me.Txtma_Ts.ReadOnly = True
        Me.Txtma_Ts.Size = New System.Drawing.Size(172, 24)
        Me.Txtma_Ts.TabIndex = 0
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbMa_Phi.Location = New System.Drawing.Point(7, 15)
        Me.lbMa_Phi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(99, 25)
        Me.lbMa_Phi.TabIndex = 353
        Me.lbMa_Phi.Tag = "Asset"
        Me.lbMa_Phi.Text = "Mã tài sản"
        '
        'ChkThoi_Kh
        '
        Me.ChkThoi_Kh.AutoSize = True
        Me.ChkThoi_Kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ChkThoi_Kh.Location = New System.Drawing.Point(111, 81)
        Me.ChkThoi_Kh.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkThoi_Kh.Name = "ChkThoi_Kh"
        Me.ChkThoi_Kh.Size = New System.Drawing.Size(177, 22)
        Me.ChkThoi_Kh.TabIndex = 2
        Me.ChkThoi_Kh.Tag = "Stop depreciation of assets"
        Me.ChkThoi_Kh.Text = "Dừng khấu hao tài sản"
        Me.ChkThoi_Kh.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(7, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 357
        Me.Label1.Tag = "Capital"
        Me.Label1.Text = "Nguồn vốn"
        '
        'TxtTen_NV
        '
        Me.TxtTen_NV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTen_NV.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NV.Location = New System.Drawing.Point(289, 42)
        Me.TxtTen_NV.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_NV.Name = "TxtTen_NV"
        Me.TxtTen_NV.ReadOnly = True
        Me.TxtTen_NV.Size = New System.Drawing.Size(612, 24)
        Me.TxtTen_NV.TabIndex = 359
        '
        'TxtMa_NV
        '
        Me.TxtMa_NV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_NV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtMa_NV.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NV.Location = New System.Drawing.Point(111, 42)
        Me.TxtMa_NV.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_NV.Name = "TxtMa_NV"
        Me.TxtMa_NV.ReadOnly = True
        Me.TxtMa_NV.Size = New System.Drawing.Size(172, 24)
        Me.TxtMa_NV.TabIndex = 1
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(7, 119)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(41, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 361
        Me.LabM_Ngay_Ct1.Tag = "Date"
        Me.LabM_Ngay_Ct1.Text = "Ngày"
        '
        'TxtNgay_Thoi
        '
        Me.TxtNgay_Thoi.Flags = 0
        Me.TxtNgay_Thoi.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Thoi.IsAllowResize = False
        Me.TxtNgay_Thoi.isEmpty = True
        Me.TxtNgay_Thoi.Location = New System.Drawing.Point(111, 116)
        Me.TxtNgay_Thoi.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Thoi.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Thoi.MaxLength = 10
        Me.TxtNgay_Thoi.Name = "TxtNgay_Thoi"
        Me.TxtNgay_Thoi.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Thoi.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Thoi.ShowDayBeforeMonth = False
        Me.TxtNgay_Thoi.Size = New System.Drawing.Size(151, 22)
        Me.TxtNgay_Thoi.TabIndex = 3
        Me.TxtNgay_Thoi.Text = "__/__/____"
        Me.TxtNgay_Thoi.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'txtLy_do
        '
        Me.txtLy_do.BackColor = System.Drawing.Color.White
        Me.txtLy_do.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtLy_do.ForeColor = System.Drawing.Color.Navy
        Me.txtLy_do.Location = New System.Drawing.Point(111, 144)
        Me.txtLy_do.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLy_do.Name = "txtLy_do"
        Me.txtLy_do.Size = New System.Drawing.Size(789, 24)
        Me.txtLy_do.TabIndex = 4
        Me.txtLy_do.Tag = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(7, 146)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 512
        Me.Label2.Tag = "Reason"
        Me.Label2.Text = "Lý do "
        '
        'FAThoiKHF3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(904, 250)
        Me.Controls.Add(Me.txtLy_do)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtNgay_Thoi)
        Me.Controls.Add(Me.TxtTen_NV)
        Me.Controls.Add(Me.TxtMa_NV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChkThoi_Kh)
        Me.Controls.Add(Me.TxtTen_ts)
        Me.Controls.Add(Me.Txtma_Ts)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FAThoiKHF3"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.Txtma_Ts, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ts, 0)
        Me.Controls.SetChildIndex(Me.ChkThoi_Kh, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NV, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NV, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Thoi, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtLy_do, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTen_ts As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_Ts As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents ChkThoi_Kh As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_NV As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_NV As System.Windows.Forms.TextBox
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Thoi As ClsTextBox.txtDate1
    Friend WithEvents txtLy_do As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
