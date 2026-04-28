<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RO_X03
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
        Me.TxtMa_To = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_To = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabMa_KTV = New System.Windows.Forms.Label()
        Me.TxtTen_KTV = New System.Windows.Forms.TextBox()
        Me.TxtMa_KTV = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Khoang = New System.Windows.Forms.Label()
        Me.TxtTen_khoang = New System.Windows.Forms.TextBox()
        Me.TxtMa_Khoang = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBBLoai_SC = New System.Windows.Forms.ComboBox()
        Me.TxtSo_RO = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Txtten_xe = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabSo_Ct1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbbMa_post2 = New System.Windows.Forms.ComboBox()
        Me.CbbMa_Post1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChkLoc1 = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_To.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KTV.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Khoang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 277)
        Me.ButtExit.TabIndex = 21
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 238)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 241)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 277)
        Me.ButtOK.TabIndex = 20
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(9, 216)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 216)
        Me.ChkVND.TabIndex = 17
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(211, 217)
        Me.ChkNT.TabIndex = 18
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = False
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 26)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 2
        Me.TxtM_Ngay_Ct1.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = False
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 48)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 3
        Me.TxtM_Ngay_Ct2.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(9, 29)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(9, 51)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 260)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'TxtMa_To
        '
        Me.TxtMa_To._ActilookupPopup = False
        Me.TxtMa_To.CyberActilookupPopup = True
        Me.TxtMa_To.Dv_ListDetail = Nothing
        Me.TxtMa_To.Dv_Master = Nothing
        Me.TxtMa_To.FilterClient = ""
        Me.TxtMa_To.FilterSQL = ""
        Me.TxtMa_To.Location = New System.Drawing.Point(95, 71)
        Me.TxtMa_To.Name = "TxtMa_To"
        Me.TxtMa_To.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_To.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_To.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_To.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_To.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_To.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_To.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_To.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_To.Size = New System.Drawing.Size(114, 22)
        Me.TxtMa_To.TabIndex = 3
        Me.TxtMa_To.Table_Name = ""
        '
        'TxtTen_To
        '
        Me.TxtTen_To.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_To.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_To.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_To.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_To.Location = New System.Drawing.Point(215, 74)
        Me.TxtTen_To.Name = "TxtTen_To"
        Me.TxtTen_To.ReadOnly = True
        Me.TxtTen_To.Size = New System.Drawing.Size(371, 13)
        Me.TxtTen_To.TabIndex = 148
        Me.TxtTen_To.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(19, 13)
        Me.Label2.TabIndex = 147
        Me.Label2.Tag = "Customer"
        Me.Label2.Text = "Tổ"
        '
        'LabMa_KTV
        '
        Me.LabMa_KTV.Location = New System.Drawing.Point(12, 120)
        Me.LabMa_KTV.Name = "LabMa_KTV"
        Me.LabMa_KTV.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_KTV.TabIndex = 609
        Me.LabMa_KTV.Tag = "Cost center"
        Me.LabMa_KTV.Text = "KTV"
        '
        'TxtTen_KTV
        '
        Me.TxtTen_KTV.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_KTV.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KTV.Enabled = False
        Me.TxtTen_KTV.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KTV.Location = New System.Drawing.Point(218, 119)
        Me.TxtTen_KTV.Name = "TxtTen_KTV"
        Me.TxtTen_KTV.ReadOnly = True
        Me.TxtTen_KTV.Size = New System.Drawing.Size(369, 14)
        Me.TxtTen_KTV.TabIndex = 608
        Me.TxtTen_KTV.TabStop = False
        '
        'TxtMa_KTV
        '
        Me.TxtMa_KTV._ActilookupPopup = False
        Me.TxtMa_KTV.CyberActilookupPopup = True
        Me.TxtMa_KTV.Dv_ListDetail = Nothing
        Me.TxtMa_KTV.Dv_Master = Nothing
        Me.TxtMa_KTV.FilterClient = ""
        Me.TxtMa_KTV.FilterSQL = ""
        Me.TxtMa_KTV.Location = New System.Drawing.Point(95, 117)
        Me.TxtMa_KTV.Name = "TxtMa_KTV"
        Me.TxtMa_KTV.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KTV.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KTV.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KTV.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_KTV.TabIndex = 9
        Me.TxtMa_KTV.Table_Name = ""
        '
        'LabMa_Khoang
        '
        Me.LabMa_Khoang.Location = New System.Drawing.Point(11, 98)
        Me.LabMa_Khoang.Name = "LabMa_Khoang"
        Me.LabMa_Khoang.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_Khoang.TabIndex = 607
        Me.LabMa_Khoang.Tag = "Profit Centers"
        Me.LabMa_Khoang.Text = "Khoang "
        '
        'TxtTen_khoang
        '
        Me.TxtTen_khoang.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_khoang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_khoang.Enabled = False
        Me.TxtTen_khoang.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_khoang.Location = New System.Drawing.Point(217, 98)
        Me.TxtTen_khoang.Name = "TxtTen_khoang"
        Me.TxtTen_khoang.ReadOnly = True
        Me.TxtTen_khoang.Size = New System.Drawing.Size(369, 14)
        Me.TxtTen_khoang.TabIndex = 606
        Me.TxtTen_khoang.TabStop = False
        '
        'TxtMa_Khoang
        '
        Me.TxtMa_Khoang._ActilookupPopup = False
        Me.TxtMa_Khoang.CyberActilookupPopup = True
        Me.TxtMa_Khoang.Dv_ListDetail = Nothing
        Me.TxtMa_Khoang.Dv_Master = Nothing
        Me.TxtMa_Khoang.FilterClient = ""
        Me.TxtMa_Khoang.FilterSQL = ""
        Me.TxtMa_Khoang.Location = New System.Drawing.Point(95, 95)
        Me.TxtMa_Khoang.Name = "TxtMa_Khoang"
        Me.TxtMa_Khoang.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Khoang.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Khoang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Khoang.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Khoang.TabIndex = 7
        Me.TxtMa_Khoang.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 613
        Me.Label3.Tag = "Account Level"
        Me.Label3.Text = "Loại sữa chữa"
        '
        'CBBLoai_SC
        '
        Me.CBBLoai_SC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBLoai_SC.ForeColor = System.Drawing.Color.Navy
        Me.CBBLoai_SC.FormattingEnabled = True
        Me.CBBLoai_SC.Location = New System.Drawing.Point(96, 4)
        Me.CBBLoai_SC.Name = "CBBLoai_SC"
        Me.CBBLoai_SC.Size = New System.Drawing.Size(113, 21)
        Me.CBBLoai_SC.TabIndex = 0
        '
        'TxtSo_RO
        '
        Me.TxtSo_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_RO.Location = New System.Drawing.Point(95, 139)
        Me.TxtSo_RO.Name = "TxtSo_RO"
        Me.TxtSo_RO.Size = New System.Drawing.Size(114, 21)
        Me.TxtSo_RO.TabIndex = 10
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(95, 161)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(114, 21)
        Me.TxtMa_Xe.TabIndex = 11
        '
        'Txtten_xe
        '
        Me.Txtten_xe.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_xe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_xe.Enabled = False
        Me.Txtten_xe.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_xe.Location = New System.Drawing.Point(224, 164)
        Me.Txtten_xe.Name = "Txtten_xe"
        Me.Txtten_xe.ReadOnly = True
        Me.Txtten_xe.Size = New System.Drawing.Size(220, 14)
        Me.Txtten_xe.TabIndex = 622
        Me.Txtten_xe.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 164)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 621
        Me.Label11.Tag = "Staff"
        Me.Label11.Text = "Biển số"
        '
        'LabSo_Ct1
        '
        Me.LabSo_Ct1.Location = New System.Drawing.Point(11, 142)
        Me.LabSo_Ct1.Name = "LabSo_Ct1"
        Me.LabSo_Ct1.Size = New System.Drawing.Size(82, 15)
        Me.LabSo_Ct1.TabIndex = 620
        Me.LabSo_Ct1.Tag = "Voucher from"
        Me.LabSo_Ct1.Text = "Số lệnh"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(308, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Tag = "Loại giao dịch"
        Me.Label5.Text = "Đến mức xử lý"
        '
        'CbbMa_post2
        '
        Me.CbbMa_post2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_post2.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_post2.FormattingEnabled = True
        Me.CbbMa_post2.Location = New System.Drawing.Point(395, 185)
        Me.CbbMa_post2.Name = "CbbMa_post2"
        Me.CbbMa_post2.Size = New System.Drawing.Size(191, 21)
        Me.CbbMa_post2.TabIndex = 16
        '
        'CbbMa_Post1
        '
        Me.CbbMa_Post1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post1.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post1.FormattingEnabled = True
        Me.CbbMa_Post1.Location = New System.Drawing.Point(95, 185)
        Me.CbbMa_Post1.Name = "CbbMa_Post1"
        Me.CbbMa_Post1.Size = New System.Drawing.Size(182, 21)
        Me.CbbMa_Post1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 187)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 17)
        Me.Label7.TabIndex = 627
        Me.Label7.Tag = "Type"
        Me.Label7.Text = "Từ mức xử lý"
        '
        'ChkLoc1
        '
        Me.ChkLoc1.AutoSize = True
        Me.ChkLoc1.Checked = True
        Me.ChkLoc1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkLoc1.Location = New System.Drawing.Point(223, 7)
        Me.ChkLoc1.Name = "ChkLoc1"
        Me.ChkLoc1.Size = New System.Drawing.Size(121, 17)
        Me.ChkLoc1.TabIndex = 22
        Me.ChkLoc1.Text = "Lọc xe chậm tiến độ"
        Me.ChkLoc1.UseVisualStyleBackColor = True
        '
        'RO_X03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 330)
        Me.Controls.Add(Me.ChkLoc1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CbbMa_post2)
        Me.Controls.Add(Me.CbbMa_Post1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtSo_RO)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Txtten_xe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LabSo_Ct1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBBLoai_SC)
        Me.Controls.Add(Me.LabMa_KTV)
        Me.Controls.Add(Me.TxtTen_KTV)
        Me.Controls.Add(Me.TxtMa_KTV)
        Me.Controls.Add(Me.LabMa_Khoang)
        Me.Controls.Add(Me.TxtTen_khoang)
        Me.Controls.Add(Me.TxtMa_Khoang)
        Me.Controls.Add(Me.TxtMa_To)
        Me.Controls.Add(Me.TxtTen_To)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "RO_X03"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_To, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_To, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Khoang, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_khoang, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Khoang, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KTV, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KTV, 0)
        Me.Controls.SetChildIndex(Me.LabMa_KTV, 0)
        Me.Controls.SetChildIndex(Me.CBBLoai_SC, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.LabSo_Ct1, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Txtten_xe, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_RO, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_post2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.ChkLoc1, 0)
        CType(Me.TxtMa_To.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KTV.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Khoang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMa_To As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_To As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabMa_KTV As System.Windows.Forms.Label
    Friend WithEvents TxtTen_KTV As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KTV As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Khoang As System.Windows.Forms.Label
    Friend WithEvents TxtTen_khoang As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Khoang As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBBLoai_SC As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSo_RO As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Txtten_xe As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabSo_Ct1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_post2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_Post1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ChkLoc1 As System.Windows.Forms.CheckBox

End Class
