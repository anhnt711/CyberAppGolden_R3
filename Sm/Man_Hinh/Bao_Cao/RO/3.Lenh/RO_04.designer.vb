<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RO_04
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbGroupByTH = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbbMa_post2 = New System.Windows.Forms.ComboBox()
        Me.CbbMa_Post1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbbGroupByCT = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbbLoai_Phieu = New System.Windows.Forms.ComboBox()
        Me.LabMa_Hs = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.LabSo_Ct1 = New System.Windows.Forms.Label()
        Me.TxtSo_ro = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_kh = New System.Windows.Forms.TextBox()
        Me.Txtma_kh = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txtten_xe = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTen_BP = New System.Windows.Forms.TextBox()
        Me.TxtMa_BP = New Cyber.SmLists.TxtLookup()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_KX = New Cyber.SmLists.TxtLookup()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.ChkDetail_OK = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSo_ro.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(761, 408)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 17
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(143, 362)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(745, 25)
        Me.CBBMa_Dvcs.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 366)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Size = New System.Drawing.Size(61, 17)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(623, 408)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 16
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(20, 344)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLoai_NT.Size = New System.Drawing.Size(61, 17)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(143, 340)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 14
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(295, 340)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 13
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(143, 61)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct1.TabIndex = 2
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(427, 61)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct2.TabIndex = 3
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(20, 67)
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
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(333, 67)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 386)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(891, 12)
        Me.GroupBoxLine.TabIndex = 14
        Me.GroupBoxLine.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 5)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 386
        Me.Label3.Tag = "Group by"
        Me.Label3.Text = "Tổng hợp theo"
        '
        'CbbGroupByTH
        '
        Me.CbbGroupByTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGroupByTH.ForeColor = System.Drawing.Color.Navy
        Me.CbbGroupByTH.FormattingEnabled = True
        Me.CbbGroupByTH.Location = New System.Drawing.Point(143, 0)
        Me.CbbGroupByTH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbGroupByTH.Name = "CbbGroupByTH"
        Me.CbbGroupByTH.Size = New System.Drawing.Size(745, 25)
        Me.CbbGroupByTH.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(483, 310)
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
        Me.CbbMa_post2.Location = New System.Drawing.Point(607, 303)
        Me.CbbMa_post2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_post2.Name = "CbbMa_post2"
        Me.CbbMa_post2.Size = New System.Drawing.Size(283, 25)
        Me.CbbMa_post2.TabIndex = 13
        '
        'CbbMa_Post1
        '
        Me.CbbMa_Post1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post1.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post1.FormattingEnabled = True
        Me.CbbMa_Post1.Location = New System.Drawing.Point(143, 303)
        Me.CbbMa_Post1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_Post1.Name = "CbbMa_Post1"
        Me.CbbMa_Post1.Size = New System.Drawing.Size(283, 25)
        Me.CbbMa_Post1.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(20, 306)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 22)
        Me.Label7.TabIndex = 438
        Me.Label7.Tag = "Type post from "
        Me.Label7.Text = "Từ mức xử lý"
        '
        'CbbGroupByCT
        '
        Me.CbbGroupByCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGroupByCT.ForeColor = System.Drawing.Color.Navy
        Me.CbbGroupByCT.FormattingEnabled = True
        Me.CbbGroupByCT.Location = New System.Drawing.Point(295, 30)
        Me.CbbGroupByCT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbGroupByCT.Name = "CbbGroupByCT"
        Me.CbbGroupByCT.Size = New System.Drawing.Size(593, 25)
        Me.CbbGroupByCT.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 277)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 443
        Me.Label6.Tag = "Command"
        Me.Label6.Text = "Lệnh"
        '
        'CbbLoai_Phieu
        '
        Me.CbbLoai_Phieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbLoai_Phieu.ForeColor = System.Drawing.Color.Navy
        Me.CbbLoai_Phieu.FormattingEnabled = True
        Me.CbbLoai_Phieu.Location = New System.Drawing.Point(143, 272)
        Me.CbbLoai_Phieu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbLoai_Phieu.Name = "CbbLoai_Phieu"
        Me.CbbLoai_Phieu.Size = New System.Drawing.Size(283, 25)
        Me.CbbLoai_Phieu.TabIndex = 10
        '
        'LabMa_Hs
        '
        Me.LabMa_Hs.AutoSize = True
        Me.LabMa_Hs.Location = New System.Drawing.Point(20, 186)
        Me.LabMa_Hs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Hs.Name = "LabMa_Hs"
        Me.LabMa_Hs.Size = New System.Drawing.Size(101, 17)
        Me.LabMa_Hs.TabIndex = 475
        Me.LabMa_Hs.Tag = "Staff"
        Me.LabMa_Hs.Text = "Cố vấn dịch vụ"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(313, 186)
        Me.TxtTen_Hs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Hs.TabIndex = 453
        Me.TxtTen_Hs.TabStop = False
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs._ActilookupPopup = False
        Me.TxtMa_Hs.CyberActilookupPopup = True
        Me.TxtMa_Hs.Dv_ListDetail = Nothing
        Me.TxtMa_Hs.Dv_Master = Nothing
        Me.TxtMa_Hs.FilterClient = ""
        Me.TxtMa_Hs.FilterSQL = ""
        Me.TxtMa_Hs.Location = New System.Drawing.Point(143, 182)
        Me.TxtMa_Hs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(152, 22)
        Me.TxtMa_Hs.TabIndex = 7
        Me.TxtMa_Hs.Table_Name = ""
        '
        'LabSo_Ct1
        '
        Me.LabSo_Ct1.Location = New System.Drawing.Point(20, 97)
        Me.LabSo_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabSo_Ct1.Name = "LabSo_Ct1"
        Me.LabSo_Ct1.Size = New System.Drawing.Size(61, 20)
        Me.LabSo_Ct1.TabIndex = 493
        Me.LabSo_Ct1.Tag = "No RO"
        Me.LabSo_Ct1.Text = "Số lệnh"
        '
        'TxtSo_ro
        '
        Me.TxtSo_ro._ActilookupPopup = False
        Me.TxtSo_ro.CyberActilookupPopup = True
        Me.TxtSo_ro.Dv_ListDetail = Nothing
        Me.TxtSo_ro.Dv_Master = Nothing
        Me.TxtSo_ro.FilterClient = ""
        Me.TxtSo_ro.FilterSQL = ""
        Me.TxtSo_ro.Location = New System.Drawing.Point(143, 93)
        Me.TxtSo_ro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSo_ro.Name = "TxtSo_ro"
        Me.TxtSo_ro.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_ro.Properties.Appearance.Options.UseForeColor = True
        Me.TxtSo_ro.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtSo_ro.Size = New System.Drawing.Size(152, 22)
        Me.TxtSo_ro.TabIndex = 4
        Me.TxtSo_ro.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 246)
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
        Me.TxtTen_kh.Location = New System.Drawing.Point(313, 246)
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
        Me.Txtma_kh.Location = New System.Drawing.Point(143, 242)
        Me.Txtma_kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtma_kh.Name = "Txtma_kh"
        Me.Txtma_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_kh.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_kh.Size = New System.Drawing.Size(152, 22)
        Me.Txtma_kh.TabIndex = 9
        Me.Txtma_kh.Table_Name = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(20, 127)
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
        Me.Txtten_xe.Location = New System.Drawing.Point(313, 127)
        Me.Txtten_xe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_xe.Name = "Txtten_xe"
        Me.Txtten_xe.ReadOnly = True
        Me.Txtten_xe.Size = New System.Drawing.Size(576, 17)
        Me.Txtten_xe.TabIndex = 507
        Me.Txtten_xe.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 216)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 17)
        Me.Label8.TabIndex = 510
        Me.Label8.Tag = "Department"
        Me.Label8.Text = "Bộ phận"
        '
        'TxtTen_BP
        '
        Me.TxtTen_BP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_BP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BP.Enabled = False
        Me.TxtTen_BP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BP.Location = New System.Drawing.Point(315, 216)
        Me.TxtTen_BP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_BP.Name = "TxtTen_BP"
        Me.TxtTen_BP.ReadOnly = True
        Me.TxtTen_BP.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_BP.TabIndex = 509
        Me.TxtTen_BP.TabStop = False
        '
        'TxtMa_BP
        '
        Me.TxtMa_BP._ActilookupPopup = False
        Me.TxtMa_BP.CyberActilookupPopup = True
        Me.TxtMa_BP.Dv_ListDetail = Nothing
        Me.TxtMa_BP.Dv_Master = Nothing
        Me.TxtMa_BP.FilterClient = ""
        Me.TxtMa_BP.FilterSQL = ""
        Me.TxtMa_BP.Location = New System.Drawing.Point(143, 212)
        Me.TxtMa_BP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_BP.Name = "TxtMa_BP"
        Me.TxtMa_BP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP.Size = New System.Drawing.Size(152, 22)
        Me.TxtMa_BP.TabIndex = 8
        Me.TxtMa_BP.Table_Name = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(483, 272)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 17)
        Me.Label9.TabIndex = 512
        Me.Label9.Tag = "Type"
        Me.Label9.Text = "Loại lệnh"
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(607, 272)
        Me.CbbMa_GD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(283, 25)
        Me.CbbMa_GD.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(20, 156)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 17)
        Me.Label10.TabIndex = 515
        Me.Label10.Tag = "Type car"
        Me.Label10.Text = "Kiểu xe"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(313, 156)
        Me.TxtTen_Kx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Kx.TabIndex = 514
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_KX
        '
        Me.TxtMa_KX._ActilookupPopup = False
        Me.TxtMa_KX.CyberActilookupPopup = True
        Me.TxtMa_KX.Dv_ListDetail = Nothing
        Me.TxtMa_KX.Dv_Master = Nothing
        Me.TxtMa_KX.FilterClient = ""
        Me.TxtMa_KX.FilterSQL = ""
        Me.TxtMa_KX.Location = New System.Drawing.Point(143, 152)
        Me.TxtMa_KX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_KX.Name = "TxtMa_KX"
        Me.TxtMa_KX.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KX.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KX.Size = New System.Drawing.Size(152, 22)
        Me.TxtMa_KX.TabIndex = 6
        Me.TxtMa_KX.Table_Name = ""
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.Location = New System.Drawing.Point(143, 123)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(151, 24)
        Me.TxtMa_Xe.TabIndex = 5
        '
        'ChkDetail_OK
        '
        Me.ChkDetail_OK.AutoSize = True
        Me.ChkDetail_OK.Location = New System.Drawing.Point(143, 34)
        Me.ChkDetail_OK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkDetail_OK.Name = "ChkDetail_OK"
        Me.ChkDetail_OK.Size = New System.Drawing.Size(104, 21)
        Me.ChkDetail_OK.TabIndex = 516
        Me.ChkDetail_OK.Tag = "Detail"
        Me.ChkDetail_OK.Text = "Chi tiết theo"
        Me.ChkDetail_OK.UseVisualStyleBackColor = True
        '
        'ROBCTHHDK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(900, 477)
        Me.Controls.Add(Me.ChkDetail_OK)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtMa_KX)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTen_BP)
        Me.Controls.Add(Me.TxtMa_BP)
        Me.Controls.Add(Me.Txtten_xe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.Txtma_kh)
        Me.Controls.Add(Me.LabSo_Ct1)
        Me.Controls.Add(Me.TxtSo_ro)
        Me.Controls.Add(Me.LabMa_Hs)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CbbLoai_Phieu)
        Me.Controls.Add(Me.CbbGroupByCT)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbMa_post2)
        Me.Controls.Add(Me.CbbMa_Post1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbbGroupByTH)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "ROBCTHHDK"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbGroupByTH, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_post2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.CbbGroupByCT, 0)
        Me.Controls.SetChildIndex(Me.CbbLoai_Phieu, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_ro, 0)
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
        Me.Controls.SetChildIndex(Me.TxtMa_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BP, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KX, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.ChkDetail_OK, 0)
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSo_ro.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbbGroupByTH As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_post2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_Post1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CbbGroupByCT As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CbbLoai_Phieu As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_Hs As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents LabSo_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_ro As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kh As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txtten_xe As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_BP As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BP As Cyber.SmLists.TxtLookup
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KX As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents ChkDetail_OK As System.Windows.Forms.CheckBox

End Class
