<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ROPT5BK1
    Inherits Cyber.From.FilterReport

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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbbMa_post2 = New System.Windows.Forms.ComboBox()
        Me.CbbMa_Post1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LabSo_Ct1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_kh = New System.Windows.Forms.TextBox()
        Me.Txtma_kh = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txtten_xe = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.TxtTen_HD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbbMa_TT = New System.Windows.Forms.ComboBox()
        Me.TxtSo_RO = New System.Windows.Forms.TextBox()
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(761, 282)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 11
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(143, 237)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(745, 25)
        Me.CBBMa_Dvcs.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 241)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(623, 282)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 10
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(20, 205)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLoai_NT.Size = New System.Drawing.Size(83, 17)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(143, 205)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 8
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(295, 205)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 15
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(143, 4)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(427, 4)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(20, 8)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(60, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(333, 9)
        Me.LabM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(68, 17)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 260)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(891, 12)
        Me.GroupBoxLine.TabIndex = 14
        Me.GroupBoxLine.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(483, 165)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 439
        Me.Label4.Tag = "Type post to"
        Me.Label4.Text = "Đến mức xử lý"
        '
        'CbbMa_post2
        '
        Me.CbbMa_post2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_post2.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_post2.FormattingEnabled = True
        Me.CbbMa_post2.Location = New System.Drawing.Point(607, 158)
        Me.CbbMa_post2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_post2.Name = "CbbMa_post2"
        Me.CbbMa_post2.Size = New System.Drawing.Size(283, 25)
        Me.CbbMa_post2.TabIndex = 7
        '
        'CbbMa_Post1
        '
        Me.CbbMa_Post1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post1.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post1.FormattingEnabled = True
        Me.CbbMa_Post1.Location = New System.Drawing.Point(143, 158)
        Me.CbbMa_Post1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_Post1.Name = "CbbMa_Post1"
        Me.CbbMa_Post1.Size = New System.Drawing.Size(283, 25)
        Me.CbbMa_Post1.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(20, 161)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 22)
        Me.Label7.TabIndex = 438
        Me.Label7.Tag = "Type post from"
        Me.Label7.Text = "Từ mức xử lý"
        '
        'LabSo_Ct1
        '
        Me.LabSo_Ct1.Location = New System.Drawing.Point(20, 39)
        Me.LabSo_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabSo_Ct1.Name = "LabSo_Ct1"
        Me.LabSo_Ct1.Size = New System.Drawing.Size(83, 20)
        Me.LabSo_Ct1.TabIndex = 493
        Me.LabSo_Ct1.Tag = "No RO"
        Me.LabSo_Ct1.Text = "Số lệnh"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 497
        Me.Label2.Tag = "Customer"
        Me.Label2.Text = "Mã khách hàng"
        '
        'TxtTen_kh
        '
        Me.TxtTen_kh.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kh.Enabled = False
        Me.TxtTen_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh.Location = New System.Drawing.Point(313, 101)
        Me.TxtTen_kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_kh.Name = "TxtTen_kh"
        Me.TxtTen_kh.ReadOnly = True
        Me.TxtTen_kh.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_kh.TabIndex = 495
        Me.TxtTen_kh.TabStop = False
        '
        'Txtma_kh
        '
        Me.Txtma_kh._ActilookupPopup = False
        Me.Txtma_kh.CyberActilookupPopup = True
        Me.Txtma_kh.Dv_ListDetail = Nothing
        Me.Txtma_kh.Dv_Master = Nothing
        Me.Txtma_kh.FilterClient = ""
        Me.Txtma_kh.FilterSQL = ""
        Me.Txtma_kh.Location = New System.Drawing.Point(143, 97)
        Me.Txtma_kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtma_kh.Name = "Txtma_kh"
        Me.Txtma_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_kh.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_kh.Size = New System.Drawing.Size(152, 22)
        Me.Txtma_kh.TabIndex = 4
        Me.Txtma_kh.Table_Name = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 69)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 17)
        Me.Label11.TabIndex = 500
        Me.Label11.Tag = "License Plate"
        Me.Label11.Text = "Biển số"
        '
        'Txtten_xe
        '
        Me.Txtten_xe.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_xe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_xe.Enabled = False
        Me.Txtten_xe.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_xe.Location = New System.Drawing.Point(313, 69)
        Me.Txtten_xe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_xe.Name = "Txtten_xe"
        Me.Txtten_xe.ReadOnly = True
        Me.Txtten_xe.Size = New System.Drawing.Size(576, 17)
        Me.Txtten_xe.TabIndex = 507
        Me.Txtten_xe.TabStop = False
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(143, 65)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(151, 24)
        Me.TxtMa_Xe.TabIndex = 3
        '
        'TxtTen_HD
        '
        Me.TxtTen_HD.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_HD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HD.Enabled = False
        Me.TxtTen_HD.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HD.Location = New System.Drawing.Point(316, 186)
        Me.TxtTen_HD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_HD.Name = "TxtTen_HD"
        Me.TxtTen_HD.ReadOnly = True
        Me.TxtTen_HD.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_HD.TabIndex = 517
        Me.TxtTen_HD.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 131)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 520
        Me.Label5.Tag = "Payments"
        Me.Label5.Text = "Thanh toán"
        '
        'CbbMa_TT
        '
        Me.CbbMa_TT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TT.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TT.FormattingEnabled = True
        Me.CbbMa_TT.Location = New System.Drawing.Point(143, 126)
        Me.CbbMa_TT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_TT.Name = "CbbMa_TT"
        Me.CbbMa_TT.Size = New System.Drawing.Size(283, 25)
        Me.CbbMa_TT.TabIndex = 5
        '
        'TxtSo_RO
        '
        Me.TxtSo_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_RO.Location = New System.Drawing.Point(143, 35)
        Me.TxtSo_RO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSo_RO.Name = "TxtSo_RO"
        Me.TxtSo_RO.Size = New System.Drawing.Size(151, 24)
        Me.TxtSo_RO.TabIndex = 2
        '
        'ROPT5BK1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(900, 352)
        Me.Controls.Add(Me.TxtSo_RO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CbbMa_TT)
        Me.Controls.Add(Me.TxtTen_HD)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Txtten_xe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.Txtma_kh)
        Me.Controls.Add(Me.LabSo_Ct1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbMa_post2)
        Me.Controls.Add(Me.CbbMa_Post1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "ROPT5BK1"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_post2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.LabSo_Ct1, 0)
        Me.Controls.SetChildIndex(Me.Txtma_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.Txtten_xe, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HD, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TT, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_RO, 0)
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_post2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_Post1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LabSo_Ct1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kh As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txtten_xe As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_HD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_TT As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSo_RO As System.Windows.Forms.TextBox

End Class
