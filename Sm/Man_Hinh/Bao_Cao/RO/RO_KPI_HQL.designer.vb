<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RO_KPI_HQL
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
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtSo_RO = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.LabSo_Ct1 = New System.Windows.Forms.Label()
        Me.LabMa_Hs = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_kh = New System.Windows.Forms.TextBox()
        Me.Txtma_kh = New Cyber.SmLists.TxtLookup()
        Me.LabMa_TTPhi = New System.Windows.Forms.Label()
        Me.TxtTen_TTCP = New System.Windows.Forms.TextBox()
        Me.TxtMa_TTCP = New Cyber.SmLists.TxtLookup()
        Me.LabMa_TTLN = New System.Windows.Forms.Label()
        Me.TxtTen_TTLN = New System.Windows.Forms.TextBox()
        Me.TxtMa_TTLN = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh5 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH5 = New Cyber.SmLists.TxtLookup()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh4 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH4 = New Cyber.SmLists.TxtLookup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH3 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH2 = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH1 = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ChkSCC = New System.Windows.Forms.CheckBox()
        Me.ChkSBD = New System.Windows.Forms.CheckBox()
        Me.ChkSDS = New System.Windows.Forms.CheckBox()
        Me.LabMa_Post_HDS2 = New System.Windows.Forms.Label()
        Me.CbbMa_Post_HDS2 = New System.Windows.Forms.ComboBox()
        Me.CbbMa_Post_HDS1 = New System.Windows.Forms.ComboBox()
        Me.LabMa_Post_HDS1 = New System.Windows.Forms.Label()
        Me.LabMa_Post_HDK2 = New System.Windows.Forms.Label()
        Me.CbbMa_Post_HDK2 = New System.Windows.Forms.ComboBox()
        Me.CbbMa_Post_HDK1 = New System.Windows.Forms.ComboBox()
        Me.LabMa_Post_HDK1 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbbMuc_SBD = New System.Windows.Forms.ComboBox()
        Me.CbbMuc_SDS = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ChkHen = New System.Windows.Forms.CheckBox()
        Me.Chkfirst_visit = New System.Windows.Forms.CheckBox()
        Me.ChkEM60 = New System.Windows.Forms.CheckBox()
        Me.ChkPM90 = New System.Windows.Forms.CheckBox()
        Me.ChkTheo_HDS = New System.Windows.Forms.CheckBox()
        Me.ChkTheo_HDK = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_TTCP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_TTLN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1068, 520)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 25
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 469)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(1065, 25)
        Me.CBBMa_Dvcs.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 473)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(929, 520)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 24
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 445)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 441)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 21
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(280, 441)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 22
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(125, 73)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(153, 24)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(7, 77)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(60, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "From Date "
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 498)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1197, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 109)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Tag = "Date to"
        Me.Label2.Text = "Đến ngày"
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(125, 105)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(153, 24)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtSo_RO
        '
        Me.TxtSo_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_RO.Location = New System.Drawing.Point(371, 73)
        Me.TxtSo_RO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSo_RO.Name = "TxtSo_RO"
        Me.TxtSo_RO.Size = New System.Drawing.Size(153, 24)
        Me.TxtSo_RO.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(555, 82)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 528
        Me.Label5.Tag = "Type"
        Me.Label5.Text = "Loại lệnh"
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(669, 77)
        Me.CbbMa_GD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(215, 25)
        Me.CbbMa_GD.TabIndex = 4
        '
        'LabSo_Ct1
        '
        Me.LabSo_Ct1.Location = New System.Drawing.Point(287, 77)
        Me.LabSo_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabSo_Ct1.Name = "LabSo_Ct1"
        Me.LabSo_Ct1.Size = New System.Drawing.Size(83, 20)
        Me.LabSo_Ct1.TabIndex = 527
        Me.LabSo_Ct1.Tag = "No RO"
        Me.LabSo_Ct1.Text = "Số lệnh"
        '
        'LabMa_Hs
        '
        Me.LabMa_Hs.AutoSize = True
        Me.LabMa_Hs.Location = New System.Drawing.Point(7, 139)
        Me.LabMa_Hs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Hs.Name = "LabMa_Hs"
        Me.LabMa_Hs.Size = New System.Drawing.Size(101, 17)
        Me.LabMa_Hs.TabIndex = 533
        Me.LabMa_Hs.Tag = "Staff"
        Me.LabMa_Hs.Text = "Cố vấn dịch vụ"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(297, 139)
        Me.TxtTen_Hs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Hs.TabIndex = 532
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
        Me.TxtMa_Hs.Location = New System.Drawing.Point(125, 135)
        Me.TxtMa_Hs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_Hs.TabIndex = 8
        Me.TxtMa_Hs.Table_Name = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 167)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 17)
        Me.Label6.TabIndex = 536
        Me.Label6.Tag = "Customer"
        Me.Label6.Text = "Mã khách hàng"
        '
        'TxtTen_kh
        '
        Me.TxtTen_kh.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kh.Enabled = False
        Me.TxtTen_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh.Location = New System.Drawing.Point(297, 167)
        Me.TxtTen_kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_kh.Name = "TxtTen_kh"
        Me.TxtTen_kh.ReadOnly = True
        Me.TxtTen_kh.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_kh.TabIndex = 535
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
        Me.Txtma_kh.Location = New System.Drawing.Point(125, 163)
        Me.Txtma_kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtma_kh.Name = "Txtma_kh"
        Me.Txtma_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_kh.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_kh.Size = New System.Drawing.Size(155, 22)
        Me.Txtma_kh.TabIndex = 9
        Me.Txtma_kh.Table_Name = ""
        '
        'LabMa_TTPhi
        '
        Me.LabMa_TTPhi.Location = New System.Drawing.Point(5, 369)
        Me.LabMa_TTPhi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_TTPhi.Name = "LabMa_TTPhi"
        Me.LabMa_TTPhi.Size = New System.Drawing.Size(109, 17)
        Me.LabMa_TTPhi.TabIndex = 542
        Me.LabMa_TTPhi.Tag = "Cost center"
        Me.LabMa_TTPhi.Text = "TT chi phí"
        '
        'TxtTen_TTCP
        '
        Me.TxtTen_TTCP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TTCP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TTCP.Enabled = False
        Me.TxtTen_TTCP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TTCP.Location = New System.Drawing.Point(297, 375)
        Me.TxtTen_TTCP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TTCP.Name = "TxtTen_TTCP"
        Me.TxtTen_TTCP.ReadOnly = True
        Me.TxtTen_TTCP.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_TTCP.TabIndex = 541
        Me.TxtTen_TTCP.TabStop = False
        '
        'TxtMa_TTCP
        '
        Me.TxtMa_TTCP._ActilookupPopup = False
        Me.TxtMa_TTCP.CyberActilookupPopup = True
        Me.TxtMa_TTCP.Dv_ListDetail = Nothing
        Me.TxtMa_TTCP.Dv_Master = Nothing
        Me.TxtMa_TTCP.FilterClient = ""
        Me.TxtMa_TTCP.FilterSQL = ""
        Me.TxtMa_TTCP.Location = New System.Drawing.Point(125, 365)
        Me.TxtMa_TTCP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_TTCP.Name = "TxtMa_TTCP"
        Me.TxtMa_TTCP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TTCP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TTCP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TTCP.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_TTCP.TabIndex = 16
        Me.TxtMa_TTCP.Table_Name = ""
        '
        'LabMa_TTLN
        '
        Me.LabMa_TTLN.Location = New System.Drawing.Point(5, 341)
        Me.LabMa_TTLN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_TTLN.Name = "LabMa_TTLN"
        Me.LabMa_TTLN.Size = New System.Drawing.Size(109, 17)
        Me.LabMa_TTLN.TabIndex = 540
        Me.LabMa_TTLN.Tag = "Profit Centers"
        Me.LabMa_TTLN.Text = "TT lợi nhuận"
        '
        'TxtTen_TTLN
        '
        Me.TxtTen_TTLN.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TTLN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TTLN.Enabled = False
        Me.TxtTen_TTLN.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TTLN.Location = New System.Drawing.Point(297, 345)
        Me.TxtTen_TTLN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TTLN.Name = "TxtTen_TTLN"
        Me.TxtTen_TTLN.ReadOnly = True
        Me.TxtTen_TTLN.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_TTLN.TabIndex = 539
        Me.TxtTen_TTLN.TabStop = False
        '
        'TxtMa_TTLN
        '
        Me.TxtMa_TTLN._ActilookupPopup = False
        Me.TxtMa_TTLN.CyberActilookupPopup = True
        Me.TxtMa_TTLN.Dv_ListDetail = Nothing
        Me.TxtMa_TTLN.Dv_Master = Nothing
        Me.TxtMa_TTLN.FilterClient = ""
        Me.TxtMa_TTLN.FilterSQL = ""
        Me.TxtMa_TTLN.Location = New System.Drawing.Point(125, 337)
        Me.TxtMa_TTLN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_TTLN.Name = "TxtMa_TTLN"
        Me.TxtMa_TTLN.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TTLN.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TTLN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TTLN.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_TTLN.TabIndex = 15
        Me.TxtMa_TTLN.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(7, 314)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 24)
        Me.Label8.TabIndex = 556
        Me.Label8.Tag = "Group 5"
        Me.Label8.Text = "Nhóm 5"
        '
        'TxtTen_Nh5
        '
        Me.TxtTen_Nh5.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh5.Enabled = False
        Me.TxtTen_Nh5.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh5.Location = New System.Drawing.Point(297, 315)
        Me.TxtTen_Nh5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh5.Name = "TxtTen_Nh5"
        Me.TxtTen_Nh5.ReadOnly = True
        Me.TxtTen_Nh5.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Nh5.TabIndex = 555
        Me.TxtTen_Nh5.TabStop = False
        '
        'TxtNh_KH5
        '
        Me.TxtNh_KH5._ActilookupPopup = False
        Me.TxtNh_KH5.CyberActilookupPopup = True
        Me.TxtNh_KH5.Dv_ListDetail = Nothing
        Me.TxtNh_KH5.Dv_Master = Nothing
        Me.TxtNh_KH5.FilterClient = ""
        Me.TxtNh_KH5.FilterSQL = ""
        Me.TxtNh_KH5.Location = New System.Drawing.Point(125, 307)
        Me.TxtNh_KH5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH5.Name = "TxtNh_KH5"
        Me.TxtNh_KH5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH5.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH5.Size = New System.Drawing.Size(155, 22)
        Me.TxtNh_KH5.TabIndex = 14
        Me.TxtNh_KH5.Table_Name = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(7, 285)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 22)
        Me.Label9.TabIndex = 554
        Me.Label9.Tag = "Group 4"
        Me.Label9.Text = "Nhóm 4"
        '
        'TxtTen_Nh4
        '
        Me.TxtTen_Nh4.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh4.Enabled = False
        Me.TxtTen_Nh4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh4.Location = New System.Drawing.Point(297, 286)
        Me.TxtTen_Nh4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh4.Name = "TxtTen_Nh4"
        Me.TxtTen_Nh4.ReadOnly = True
        Me.TxtTen_Nh4.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Nh4.TabIndex = 553
        Me.TxtTen_Nh4.TabStop = False
        '
        'TxtNh_KH4
        '
        Me.TxtNh_KH4._ActilookupPopup = False
        Me.TxtNh_KH4.CyberActilookupPopup = True
        Me.TxtNh_KH4.Dv_ListDetail = Nothing
        Me.TxtNh_KH4.Dv_Master = Nothing
        Me.TxtNh_KH4.FilterClient = ""
        Me.TxtNh_KH4.FilterSQL = ""
        Me.TxtNh_KH4.Location = New System.Drawing.Point(125, 279)
        Me.TxtNh_KH4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH4.Name = "TxtNh_KH4"
        Me.TxtNh_KH4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH4.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH4.Size = New System.Drawing.Size(155, 22)
        Me.TxtNh_KH4.TabIndex = 13
        Me.TxtNh_KH4.Table_Name = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(7, 255)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(105, 22)
        Me.Label10.TabIndex = 552
        Me.Label10.Tag = "Group 3"
        Me.Label10.Text = "Nhóm 3"
        '
        'TxtTen_Nh3
        '
        Me.TxtTen_Nh3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh3.Enabled = False
        Me.TxtTen_Nh3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh3.Location = New System.Drawing.Point(297, 258)
        Me.TxtTen_Nh3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh3.Name = "TxtTen_Nh3"
        Me.TxtTen_Nh3.ReadOnly = True
        Me.TxtTen_Nh3.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Nh3.TabIndex = 551
        Me.TxtTen_Nh3.TabStop = False
        '
        'TxtNh_KH3
        '
        Me.TxtNh_KH3._ActilookupPopup = False
        Me.TxtNh_KH3.CyberActilookupPopup = True
        Me.TxtNh_KH3.Dv_ListDetail = Nothing
        Me.TxtNh_KH3.Dv_Master = Nothing
        Me.TxtNh_KH3.FilterClient = ""
        Me.TxtNh_KH3.FilterSQL = ""
        Me.TxtNh_KH3.Location = New System.Drawing.Point(125, 250)
        Me.TxtNh_KH3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH3.Name = "TxtNh_KH3"
        Me.TxtNh_KH3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH3.Size = New System.Drawing.Size(155, 22)
        Me.TxtNh_KH3.TabIndex = 12
        Me.TxtNh_KH3.Table_Name = ""
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh2.Enabled = False
        Me.TxtTen_Nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(297, 229)
        Me.TxtTen_Nh2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.ReadOnly = True
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Nh2.TabIndex = 550
        Me.TxtTen_Nh2.TabStop = False
        '
        'TxtNh_KH2
        '
        Me.TxtNh_KH2._ActilookupPopup = False
        Me.TxtNh_KH2.CyberActilookupPopup = True
        Me.TxtNh_KH2.Dv_ListDetail = Nothing
        Me.TxtNh_KH2.Dv_Master = Nothing
        Me.TxtNh_KH2.FilterClient = ""
        Me.TxtNh_KH2.FilterSQL = ""
        Me.TxtNh_KH2.Location = New System.Drawing.Point(125, 221)
        Me.TxtNh_KH2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH2.Name = "TxtNh_KH2"
        Me.TxtNh_KH2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH2.Size = New System.Drawing.Size(155, 22)
        Me.TxtNh_KH2.TabIndex = 11
        Me.TxtNh_KH2.Table_Name = ""
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(7, 196)
        Me.LabMa_Nh1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(105, 22)
        Me.LabMa_Nh1.TabIndex = 549
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Nhóm 1"
        '
        'TxtTen_Nh1
        '
        Me.TxtTen_Nh1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh1.Enabled = False
        Me.TxtTen_Nh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh1.Location = New System.Drawing.Point(297, 200)
        Me.TxtTen_Nh1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh1.Name = "TxtTen_Nh1"
        Me.TxtTen_Nh1.ReadOnly = True
        Me.TxtTen_Nh1.Size = New System.Drawing.Size(576, 17)
        Me.TxtTen_Nh1.TabIndex = 548
        Me.TxtTen_Nh1.TabStop = False
        '
        'TxtNh_KH1
        '
        Me.TxtNh_KH1._ActilookupPopup = False
        Me.TxtNh_KH1.CyberActilookupPopup = True
        Me.TxtNh_KH1.Dv_ListDetail = Nothing
        Me.TxtNh_KH1.Dv_Master = Nothing
        Me.TxtNh_KH1.FilterClient = ""
        Me.TxtNh_KH1.FilterSQL = ""
        Me.TxtNh_KH1.Location = New System.Drawing.Point(125, 192)
        Me.TxtNh_KH1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH1.Name = "TxtNh_KH1"
        Me.TxtNh_KH1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH1.Size = New System.Drawing.Size(155, 22)
        Me.TxtNh_KH1.TabIndex = 10
        Me.TxtNh_KH1.Table_Name = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(7, 225)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(105, 22)
        Me.Label11.TabIndex = 557
        Me.Label11.Tag = "Group 2"
        Me.Label11.Text = "Nhóm 2"
        '
        'ChkSCC
        '
        Me.ChkSCC.AutoSize = True
        Me.ChkSCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkSCC.Location = New System.Drawing.Point(669, 143)
        Me.ChkSCC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkSCC.Name = "ChkSCC"
        Me.ChkSCC.Size = New System.Drawing.Size(164, 21)
        Me.ChkSCC.TabIndex = 27
        Me.ChkSCC.Tag = "General Repair"
        Me.ChkSCC.Text = "Lệnh sửa chữa chung"
        Me.ChkSCC.UseVisualStyleBackColor = True
        '
        'ChkSBD
        '
        Me.ChkSBD.AutoSize = True
        Me.ChkSBD.ForeColor = System.Drawing.Color.Blue
        Me.ChkSBD.Location = New System.Drawing.Point(873, 143)
        Me.ChkSBD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkSBD.Name = "ChkSBD"
        Me.ChkSBD.Size = New System.Drawing.Size(132, 21)
        Me.ChkSBD.TabIndex = 28
        Me.ChkSBD.Tag = "Maintenance"
        Me.ChkSBD.Text = "Lệnh bảo dưỡng"
        Me.ChkSBD.UseVisualStyleBackColor = True
        '
        'ChkSDS
        '
        Me.ChkSDS.AutoSize = True
        Me.ChkSDS.ForeColor = System.Drawing.Color.Blue
        Me.ChkSDS.Location = New System.Drawing.Point(1047, 143)
        Me.ChkSDS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkSDS.Name = "ChkSDS"
        Me.ChkSDS.Size = New System.Drawing.Size(148, 21)
        Me.ChkSDS.TabIndex = 29
        Me.ChkSDS.Tag = "Paint"
        Me.ChkSDS.Text = "Lệnh sửa đồng sơn"
        Me.ChkSDS.UseVisualStyleBackColor = True
        '
        'LabMa_Post_HDS2
        '
        Me.LabMa_Post_HDS2.AutoSize = True
        Me.LabMa_Post_HDS2.Location = New System.Drawing.Point(497, 401)
        Me.LabMa_Post_HDS2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Post_HDS2.Name = "LabMa_Post_HDS2"
        Me.LabMa_Post_HDS2.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_Post_HDS2.TabIndex = 615
        Me.LabMa_Post_HDS2.Tag = "Type post to"
        Me.LabMa_Post_HDS2.Text = "Đến mức xử lý"
        '
        'CbbMa_Post_HDS2
        '
        Me.CbbMa_Post_HDS2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post_HDS2.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post_HDS2.FormattingEnabled = True
        Me.CbbMa_Post_HDS2.Location = New System.Drawing.Point(609, 396)
        Me.CbbMa_Post_HDS2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_Post_HDS2.Name = "CbbMa_Post_HDS2"
        Me.CbbMa_Post_HDS2.Size = New System.Drawing.Size(248, 25)
        Me.CbbMa_Post_HDS2.TabIndex = 18
        '
        'CbbMa_Post_HDS1
        '
        Me.CbbMa_Post_HDS1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post_HDS1.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post_HDS1.FormattingEnabled = True
        Me.CbbMa_Post_HDS1.Location = New System.Drawing.Point(125, 396)
        Me.CbbMa_Post_HDS1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_Post_HDS1.Name = "CbbMa_Post_HDS1"
        Me.CbbMa_Post_HDS1.Size = New System.Drawing.Size(248, 25)
        Me.CbbMa_Post_HDS1.TabIndex = 17
        '
        'LabMa_Post_HDS1
        '
        Me.LabMa_Post_HDS1.Location = New System.Drawing.Point(5, 396)
        Me.LabMa_Post_HDS1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Post_HDS1.Name = "LabMa_Post_HDS1"
        Me.LabMa_Post_HDS1.Size = New System.Drawing.Size(112, 22)
        Me.LabMa_Post_HDS1.TabIndex = 614
        Me.LabMa_Post_HDS1.Tag = "Type post from"
        Me.LabMa_Post_HDS1.Text = "Mức xử lý (H/Đ)"
        '
        'LabMa_Post_HDK2
        '
        Me.LabMa_Post_HDK2.AutoSize = True
        Me.LabMa_Post_HDK2.Location = New System.Drawing.Point(495, 401)
        Me.LabMa_Post_HDK2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Post_HDK2.Name = "LabMa_Post_HDK2"
        Me.LabMa_Post_HDK2.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_Post_HDK2.TabIndex = 611
        Me.LabMa_Post_HDK2.Tag = "Loại giao dịch"
        Me.LabMa_Post_HDK2.Text = "Đến mức xử lý"
        '
        'CbbMa_Post_HDK2
        '
        Me.CbbMa_Post_HDK2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post_HDK2.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post_HDK2.FormattingEnabled = True
        Me.CbbMa_Post_HDK2.Location = New System.Drawing.Point(609, 396)
        Me.CbbMa_Post_HDK2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_Post_HDK2.Name = "CbbMa_Post_HDK2"
        Me.CbbMa_Post_HDK2.Size = New System.Drawing.Size(248, 25)
        Me.CbbMa_Post_HDK2.TabIndex = 20
        '
        'CbbMa_Post_HDK1
        '
        Me.CbbMa_Post_HDK1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post_HDK1.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post_HDK1.FormattingEnabled = True
        Me.CbbMa_Post_HDK1.Location = New System.Drawing.Point(125, 396)
        Me.CbbMa_Post_HDK1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_Post_HDK1.Name = "CbbMa_Post_HDK1"
        Me.CbbMa_Post_HDK1.Size = New System.Drawing.Size(248, 25)
        Me.CbbMa_Post_HDK1.TabIndex = 19
        '
        'LabMa_Post_HDK1
        '
        Me.LabMa_Post_HDK1.Location = New System.Drawing.Point(5, 396)
        Me.LabMa_Post_HDK1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Post_HDK1.Name = "LabMa_Post_HDK1"
        Me.LabMa_Post_HDK1.Size = New System.Drawing.Size(112, 22)
        Me.LabMa_Post_HDK1.TabIndex = 610
        Me.LabMa_Post_HDK1.Tag = "Type"
        Me.LabMa_Post_HDK1.Text = "Mức xử lý (R/O)"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(371, 102)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(153, 24)
        Me.TxtMa_Xe.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(287, 106)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 20)
        Me.Label12.TabIndex = 617
        Me.Label12.Tag = "License Plate"
        Me.Label12.Text = "Biển số"
        '
        'CbbMuc_SBD
        '
        Me.CbbMuc_SBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMuc_SBD.Enabled = False
        Me.CbbMuc_SBD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMuc_SBD.ForeColor = System.Drawing.Color.Blue
        Me.CbbMuc_SBD.FormattingEnabled = True
        Me.CbbMuc_SBD.Location = New System.Drawing.Point(1060, 173)
        Me.CbbMuc_SBD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMuc_SBD.Name = "CbbMuc_SBD"
        Me.CbbMuc_SBD.Size = New System.Drawing.Size(141, 26)
        Me.CbbMuc_SBD.TabIndex = 2080
        '
        'CbbMuc_SDS
        '
        Me.CbbMuc_SDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMuc_SDS.Enabled = False
        Me.CbbMuc_SDS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMuc_SDS.ForeColor = System.Drawing.Color.Blue
        Me.CbbMuc_SDS.FormattingEnabled = True
        Me.CbbMuc_SDS.Location = New System.Drawing.Point(1060, 205)
        Me.CbbMuc_SDS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMuc_SDS.Name = "CbbMuc_SDS"
        Me.CbbMuc_SDS.Size = New System.Drawing.Size(141, 26)
        Me.CbbMuc_SDS.TabIndex = 2079
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(944, 178)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 17)
        Me.Label13.TabIndex = 2081
        Me.Label13.Tag = "Maintenance level"
        Me.Label13.Text = "Mức bảo dưỡng"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(951, 209)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 17)
        Me.Label14.TabIndex = 2082
        Me.Label14.Tag = "Paint level"
        Me.Label14.Text = "Mức SĐS"
        '
        'ChkHen
        '
        Me.ChkHen.AutoSize = True
        Me.ChkHen.ForeColor = System.Drawing.Color.Blue
        Me.ChkHen.Location = New System.Drawing.Point(1143, 252)
        Me.ChkHen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkHen.Name = "ChkHen"
        Me.ChkHen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkHen.Size = New System.Drawing.Size(54, 21)
        Me.ChkHen.TabIndex = 2083
        Me.ChkHen.Tag = "Appointment"
        Me.ChkHen.Text = "Hẹn"
        Me.ChkHen.UseVisualStyleBackColor = True
        '
        'Chkfirst_visit
        '
        Me.Chkfirst_visit.AutoSize = True
        Me.Chkfirst_visit.ForeColor = System.Drawing.Color.Blue
        Me.Chkfirst_visit.Location = New System.Drawing.Point(1111, 282)
        Me.Chkfirst_visit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Chkfirst_visit.Name = "Chkfirst_visit"
        Me.Chkfirst_visit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Chkfirst_visit.Size = New System.Drawing.Size(82, 21)
        Me.Chkfirst_visit.TabIndex = 2084
        Me.Chkfirst_visit.Tag = "First visit"
        Me.Chkfirst_visit.Text = "First visit"
        Me.Chkfirst_visit.UseVisualStyleBackColor = True
        '
        'ChkEM60
        '
        Me.ChkEM60.AutoSize = True
        Me.ChkEM60.ForeColor = System.Drawing.Color.Blue
        Me.ChkEM60.Location = New System.Drawing.Point(1133, 310)
        Me.ChkEM60.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkEM60.Name = "ChkEM60"
        Me.ChkEM60.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkEM60.Size = New System.Drawing.Size(64, 21)
        Me.ChkEM60.TabIndex = 2085
        Me.ChkEM60.Tag = "EM60"
        Me.ChkEM60.Text = "EM60"
        Me.ChkEM60.UseVisualStyleBackColor = True
        '
        'ChkPM90
        '
        Me.ChkPM90.AutoSize = True
        Me.ChkPM90.ForeColor = System.Drawing.Color.Blue
        Me.ChkPM90.Location = New System.Drawing.Point(1133, 344)
        Me.ChkPM90.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkPM90.Name = "ChkPM90"
        Me.ChkPM90.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkPM90.Size = New System.Drawing.Size(64, 21)
        Me.ChkPM90.TabIndex = 2086
        Me.ChkPM90.Tag = "PM90"
        Me.ChkPM90.Text = "PM90"
        Me.ChkPM90.UseVisualStyleBackColor = True
        '
        'ChkTheo_HDS
        '
        Me.ChkTheo_HDS.AutoSize = True
        Me.ChkTheo_HDS.ForeColor = System.Drawing.Color.Blue
        Me.ChkTheo_HDS.Location = New System.Drawing.Point(125, 10)
        Me.ChkTheo_HDS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkTheo_HDS.Name = "ChkTheo_HDS"
        Me.ChkTheo_HDS.Size = New System.Drawing.Size(313, 21)
        Me.ChkTheo_HDS.TabIndex = 2087
        Me.ChkTheo_HDS.Tag = "Results by Date Accounting"
        Me.ChkTheo_HDS.Text = "Hiệu quả lệnh theo ngày hạch toán doanh thu"
        Me.ChkTheo_HDS.UseVisualStyleBackColor = True
        '
        'ChkTheo_HDK
        '
        Me.ChkTheo_HDK.AutoSize = True
        Me.ChkTheo_HDK.ForeColor = System.Drawing.Color.Blue
        Me.ChkTheo_HDK.Location = New System.Drawing.Point(125, 42)
        Me.ChkTheo_HDK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkTheo_HDK.Name = "ChkTheo_HDK"
        Me.ChkTheo_HDK.Size = New System.Drawing.Size(229, 21)
        Me.ChkTheo_HDK.TabIndex = 2088
        Me.ChkTheo_HDK.Tag = "Result by Create date"
        Me.ChkTheo_HDK.Text = "Hiệu quả lệnh theo ngày lập lệnh"
        Me.ChkTheo_HDK.UseVisualStyleBackColor = True
        '
        'RO_KPI_HQL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(1207, 590)
        Me.Controls.Add(Me.ChkTheo_HDK)
        Me.Controls.Add(Me.ChkTheo_HDS)
        Me.Controls.Add(Me.ChkPM90)
        Me.Controls.Add(Me.ChkEM60)
        Me.Controls.Add(Me.Chkfirst_visit)
        Me.Controls.Add(Me.ChkHen)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.CbbMuc_SBD)
        Me.Controls.Add(Me.CbbMuc_SDS)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.LabMa_Post_HDS2)
        Me.Controls.Add(Me.CbbMa_Post_HDS2)
        Me.Controls.Add(Me.CbbMa_Post_HDS1)
        Me.Controls.Add(Me.LabMa_Post_HDS1)
        Me.Controls.Add(Me.LabMa_Post_HDK2)
        Me.Controls.Add(Me.CbbMa_Post_HDK2)
        Me.Controls.Add(Me.CbbMa_Post_HDK1)
        Me.Controls.Add(Me.LabMa_Post_HDK1)
        Me.Controls.Add(Me.ChkSDS)
        Me.Controls.Add(Me.ChkSBD)
        Me.Controls.Add(Me.ChkSCC)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTen_Nh5)
        Me.Controls.Add(Me.TxtNh_KH5)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTen_Nh4)
        Me.Controls.Add(Me.TxtNh_KH4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTen_Nh3)
        Me.Controls.Add(Me.TxtNh_KH3)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.TxtNh_KH2)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_Nh1)
        Me.Controls.Add(Me.TxtNh_KH1)
        Me.Controls.Add(Me.LabMa_TTPhi)
        Me.Controls.Add(Me.TxtTen_TTCP)
        Me.Controls.Add(Me.TxtMa_TTCP)
        Me.Controls.Add(Me.LabMa_TTLN)
        Me.Controls.Add(Me.TxtTen_TTLN)
        Me.Controls.Add(Me.TxtMa_TTLN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.Txtma_kh)
        Me.Controls.Add(Me.LabMa_Hs)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.TxtSo_RO)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.LabSo_Ct1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "RO_KPI_HQL"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.LabSo_Ct1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.Txtma_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TTLN, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TTLN, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTLN, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TTCP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TTCP, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTPhi, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh1, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh3, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh4, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh5, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.ChkSCC, 0)
        Me.Controls.SetChildIndex(Me.ChkSBD, 0)
        Me.Controls.SetChildIndex(Me.ChkSDS, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Post_HDK1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post_HDK1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post_HDK2, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Post_HDK2, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Post_HDS1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post_HDS1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post_HDS2, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Post_HDS2, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.CbbMuc_SDS, 0)
        Me.Controls.SetChildIndex(Me.CbbMuc_SBD, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.ChkHen, 0)
        Me.Controls.SetChildIndex(Me.Chkfirst_visit, 0)
        Me.Controls.SetChildIndex(Me.ChkEM60, 0)
        Me.Controls.SetChildIndex(Me.ChkPM90, 0)
        Me.Controls.SetChildIndex(Me.ChkTheo_HDS, 0)
        Me.Controls.SetChildIndex(Me.ChkTheo_HDK, 0)
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_TTCP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_TTLN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtSo_RO As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents LabSo_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabMa_Hs As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kh As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_TTPhi As System.Windows.Forms.Label
    Friend WithEvents TxtTen_TTCP As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_TTCP As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_TTLN As System.Windows.Forms.Label
    Friend WithEvents TxtTen_TTLN As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_TTLN As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH5 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH4 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH2 As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH1 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ChkSCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSBD As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSDS As System.Windows.Forms.CheckBox
    Friend WithEvents LabMa_Post_HDS2 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_Post_HDS2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_Post_HDS1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_Post_HDS1 As System.Windows.Forms.Label
    Friend WithEvents LabMa_Post_HDK2 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_Post_HDK2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_Post_HDK1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_Post_HDK1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CbbMuc_SBD As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMuc_SDS As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ChkHen As System.Windows.Forms.CheckBox
    Friend WithEvents Chkfirst_visit As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEM60 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPM90 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTheo_HDS As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTheo_HDK As System.Windows.Forms.CheckBox

End Class
