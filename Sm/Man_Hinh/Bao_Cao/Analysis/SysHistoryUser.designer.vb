<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysHistoryUser
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
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTitle1 = New System.Windows.Forms.TextBox()
        Me.TxtMa_DM = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtHostname = New System.Windows.Forms.TextBox()
        Me.ChkDetail_OK = New System.Windows.Forms.CheckBox()
        Me.CbbGroupByCT = New System.Windows.Forms.ComboBox()
        Me.CbbGroupByTH = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtComment = New System.Windows.Forms.TextBox()
        Me.TxtUser_name_Find = New Cyber.SmLists.TxtLookup()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTen_Ct = New System.Windows.Forms.TextBox()
        Me.TxtMa_Ct = New Cyber.SmLists.TxtLookup()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbbMa_Loai = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbbMa_Status = New System.Windows.Forms.ComboBox()
        Me.CbbMa_post2 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CbbMa_post1 = New System.Windows.Forms.ComboBox()
        Me.LabLoai_phieu = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_CT1 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtM_Ngay_ct2 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        CType(Me.TxtMa_DM.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtUser_name_Find.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Ct.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(719, 409)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 20
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(131, 361)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(721, 25)
        Me.CBBMa_Dvcs.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 356)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.TabIndex = 15
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 409)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 19
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 336)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLoai_NT.TabIndex = 12
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(131, 332)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 13
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(255, 332)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 14
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 387)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(848, 12)
        Me.GroupBoxLine.TabIndex = 18
        Me.GroupBoxLine.TabStop = False
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(544, 119)
        Me.LabM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(68, 17)
        Me.LabM_Ngay_Ct2.TabIndex = 201
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(13, 119)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(60, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 200
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(13, 245)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 261
        Me.Label5.Tag = "List"
        Me.Label5.Text = "Danh mục"
        '
        'txtTitle1
        '
        Me.txtTitle1.BackColor = System.Drawing.SystemColors.Control
        Me.txtTitle1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitle1.Enabled = False
        Me.txtTitle1.ForeColor = System.Drawing.Color.Navy
        Me.txtTitle1.Location = New System.Drawing.Point(341, 243)
        Me.txtTitle1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTitle1.Name = "txtTitle1"
        Me.txtTitle1.ReadOnly = True
        Me.txtTitle1.Size = New System.Drawing.Size(493, 17)
        Me.txtTitle1.TabIndex = 260
        Me.txtTitle1.TabStop = False
        '
        'TxtMa_DM
        '
        Me.TxtMa_DM._ActilookupPopup = False
        Me.TxtMa_DM.CyberActilookupPopup = True
        Me.TxtMa_DM.Dv_ListDetail = Nothing
        Me.TxtMa_DM.Dv_Master = Nothing
        Me.TxtMa_DM.FilterClient = ""
        Me.TxtMa_DM.FilterSQL = ""
        Me.TxtMa_DM.Location = New System.Drawing.Point(129, 239)
        Me.TxtMa_DM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_DM.Name = "TxtMa_DM"
        Me.TxtMa_DM.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_DM.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_DM.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_DM.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_DM.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_DM.Size = New System.Drawing.Size(204, 22)
        Me.TxtMa_DM.TabIndex = 8
        Me.TxtMa_DM.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 183)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 17)
        Me.Label2.TabIndex = 271
        Me.Label2.Tag = "Computer name"
        Me.Label2.Text = "Máy tính"
        '
        'TxtHostname
        '
        Me.TxtHostname.Location = New System.Drawing.Point(129, 178)
        Me.TxtHostname.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtHostname.Name = "TxtHostname"
        Me.TxtHostname.Size = New System.Drawing.Size(203, 24)
        Me.TxtHostname.TabIndex = 6
        '
        'ChkDetail_OK
        '
        Me.ChkDetail_OK.AutoSize = True
        Me.ChkDetail_OK.Location = New System.Drawing.Point(129, 81)
        Me.ChkDetail_OK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkDetail_OK.Name = "ChkDetail_OK"
        Me.ChkDetail_OK.Size = New System.Drawing.Size(104, 21)
        Me.ChkDetail_OK.TabIndex = 429
        Me.ChkDetail_OK.Tag = "Detail"
        Me.ChkDetail_OK.Text = "Chi tiết theo"
        Me.ChkDetail_OK.UseVisualStyleBackColor = True
        '
        'CbbGroupByCT
        '
        Me.CbbGroupByCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGroupByCT.ForeColor = System.Drawing.Color.Navy
        Me.CbbGroupByCT.FormattingEnabled = True
        Me.CbbGroupByCT.Location = New System.Drawing.Point(271, 78)
        Me.CbbGroupByCT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbGroupByCT.Name = "CbbGroupByCT"
        Me.CbbGroupByCT.Size = New System.Drawing.Size(583, 25)
        Me.CbbGroupByCT.TabIndex = 2
        '
        'CbbGroupByTH
        '
        Me.CbbGroupByTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGroupByTH.ForeColor = System.Drawing.Color.Navy
        Me.CbbGroupByTH.FormattingEnabled = True
        Me.CbbGroupByTH.Location = New System.Drawing.Point(129, 47)
        Me.CbbGroupByTH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbGroupByTH.Name = "CbbGroupByTH"
        Me.CbbGroupByTH.Size = New System.Drawing.Size(724, 25)
        Me.CbbGroupByTH.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 52)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 430
        Me.Label4.Tag = "Group by"
        Me.Label4.Text = "Tổng hợp theo"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(13, 152)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 17)
        Me.Label3.TabIndex = 433
        Me.Label3.Tag = "User name"
        Me.Label3.Text = "Tên đăng nhập"
        '
        'TxtComment
        '
        Me.TxtComment.BackColor = System.Drawing.SystemColors.Control
        Me.TxtComment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtComment.Enabled = False
        Me.TxtComment.ForeColor = System.Drawing.Color.Navy
        Me.TxtComment.Location = New System.Drawing.Point(341, 150)
        Me.TxtComment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtComment.Name = "TxtComment"
        Me.TxtComment.ReadOnly = True
        Me.TxtComment.Size = New System.Drawing.Size(493, 17)
        Me.TxtComment.TabIndex = 432
        Me.TxtComment.TabStop = False
        '
        'TxtUser_name_Find
        '
        Me.TxtUser_name_Find._ActilookupPopup = False
        Me.TxtUser_name_Find.CyberActilookupPopup = True
        Me.TxtUser_name_Find.Dv_ListDetail = Nothing
        Me.TxtUser_name_Find.Dv_Master = Nothing
        Me.TxtUser_name_Find.FilterClient = ""
        Me.TxtUser_name_Find.FilterSQL = ""
        Me.TxtUser_name_Find.Location = New System.Drawing.Point(129, 146)
        Me.TxtUser_name_Find.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtUser_name_Find.Name = "TxtUser_name_Find"
        Me.TxtUser_name_Find.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtUser_name_Find.Properties.Appearance.Options.UseForeColor = True
        Me.TxtUser_name_Find.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtUser_name_Find.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtUser_name_Find.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtUser_name_Find.Size = New System.Drawing.Size(204, 22)
        Me.TxtUser_name_Find.TabIndex = 5
        Me.TxtUser_name_Find.Table_Name = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(13, 214)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 17)
        Me.Label9.TabIndex = 436
        Me.Label9.Tag = "Voucher"
        Me.Label9.Text = "Chứng từ"
        '
        'TxtTen_Ct
        '
        Me.TxtTen_Ct.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Ct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Ct.Enabled = False
        Me.TxtTen_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Ct.Location = New System.Drawing.Point(341, 213)
        Me.TxtTen_Ct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Ct.Name = "TxtTen_Ct"
        Me.TxtTen_Ct.ReadOnly = True
        Me.TxtTen_Ct.Size = New System.Drawing.Size(493, 17)
        Me.TxtTen_Ct.TabIndex = 435
        Me.TxtTen_Ct.TabStop = False
        '
        'TxtMa_Ct
        '
        Me.TxtMa_Ct._ActilookupPopup = False
        Me.TxtMa_Ct.CyberActilookupPopup = True
        Me.TxtMa_Ct.Dv_ListDetail = Nothing
        Me.TxtMa_Ct.Dv_Master = Nothing
        Me.TxtMa_Ct.FilterClient = ""
        Me.TxtMa_Ct.FilterSQL = ""
        Me.TxtMa_Ct.Location = New System.Drawing.Point(129, 209)
        Me.TxtMa_Ct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Ct.Name = "TxtMa_Ct"
        Me.TxtMa_Ct.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Ct.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Ct.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Ct.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Ct.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Ct.Size = New System.Drawing.Size(204, 22)
        Me.TxtMa_Ct.TabIndex = 7
        Me.TxtMa_Ct.Table_Name = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 17)
        Me.Label6.TabIndex = 456
        Me.Label6.Tag = "form"
        Me.Label6.Text = "Hình thức"
        '
        'CbbMa_Loai
        '
        Me.CbbMa_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Loai.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Loai.FormattingEnabled = True
        Me.CbbMa_Loai.Location = New System.Drawing.Point(129, 17)
        Me.CbbMa_Loai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_Loai.Name = "CbbMa_Loai"
        Me.CbbMa_Loai.Size = New System.Drawing.Size(723, 25)
        Me.CbbMa_Loai.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 275)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 17)
        Me.Label10.TabIndex = 458
        Me.Label10.Tag = "Interactive"
        Me.Label10.Text = "Thao tác"
        '
        'CbbMa_Status
        '
        Me.CbbMa_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Status.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Status.FormattingEnabled = True
        Me.CbbMa_Status.Location = New System.Drawing.Point(129, 269)
        Me.CbbMa_Status.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_Status.Name = "CbbMa_Status"
        Me.CbbMa_Status.Size = New System.Drawing.Size(203, 25)
        Me.CbbMa_Status.TabIndex = 9
        '
        'CbbMa_post2
        '
        Me.CbbMa_post2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_post2.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_post2.FormattingEnabled = True
        Me.CbbMa_post2.Location = New System.Drawing.Point(651, 299)
        Me.CbbMa_post2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_post2.Name = "CbbMa_post2"
        Me.CbbMa_post2.Size = New System.Drawing.Size(203, 25)
        Me.CbbMa_post2.TabIndex = 11
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(544, 305)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 17)
        Me.Label11.TabIndex = 462
        Me.Label11.Tag = "Type post to"
        Me.Label11.Text = "Đến mức xử lý"
        '
        'CbbMa_post1
        '
        Me.CbbMa_post1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_post1.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_post1.FormattingEnabled = True
        Me.CbbMa_post1.Location = New System.Drawing.Point(129, 299)
        Me.CbbMa_post1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_post1.Name = "CbbMa_post1"
        Me.CbbMa_post1.Size = New System.Drawing.Size(203, 25)
        Me.CbbMa_post1.TabIndex = 10
        '
        'LabLoai_phieu
        '
        Me.LabLoai_phieu.AutoSize = True
        Me.LabLoai_phieu.Location = New System.Drawing.Point(13, 305)
        Me.LabLoai_phieu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLoai_phieu.Name = "LabLoai_phieu"
        Me.LabLoai_phieu.Size = New System.Drawing.Size(92, 17)
        Me.LabLoai_phieu.TabIndex = 461
        Me.LabLoai_phieu.Tag = "Type post from"
        Me.LabLoai_phieu.Text = "Từ mức xử lý"
        '
        'TxtM_Ngay_CT1
        '
        Me.TxtM_Ngay_CT1.Flags = 0
        Me.TxtM_Ngay_CT1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtM_Ngay_CT1.IsAllowResize = False
        Me.TxtM_Ngay_CT1.Location = New System.Drawing.Point(129, 112)
        Me.TxtM_Ngay_CT1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_CT1.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtM_Ngay_CT1.MaxLength = 10
        Me.TxtM_Ngay_CT1.Name = "TxtM_Ngay_CT1"
        Me.TxtM_Ngay_CT1.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtM_Ngay_CT1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtM_Ngay_CT1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_CT1.Size = New System.Drawing.Size(203, 26)
        Me.TxtM_Ngay_CT1.TabIndex = 3
        Me.TxtM_Ngay_CT1.Value = "30/07/2019 15:56"
        '
        'TxtM_Ngay_ct2
        '
        Me.TxtM_Ngay_ct2.Flags = 0
        Me.TxtM_Ngay_ct2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtM_Ngay_ct2.IsAllowResize = False
        Me.TxtM_Ngay_ct2.Location = New System.Drawing.Point(651, 112)
        Me.TxtM_Ngay_ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_ct2.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtM_Ngay_ct2.MaxLength = 10
        Me.TxtM_Ngay_ct2.Name = "TxtM_Ngay_ct2"
        Me.TxtM_Ngay_ct2.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtM_Ngay_ct2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtM_Ngay_ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_ct2.Size = New System.Drawing.Size(203, 26)
        Me.TxtM_Ngay_ct2.TabIndex = 4
        Me.TxtM_Ngay_ct2.Value = "30/07/2019 15:56"
        '
        'SysHistoryUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(857, 479)
        Me.Controls.Add(Me.TxtM_Ngay_ct2)
        Me.Controls.Add(Me.TxtM_Ngay_CT1)
        Me.Controls.Add(Me.CbbMa_post2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CbbMa_post1)
        Me.Controls.Add(Me.LabLoai_phieu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbbMa_Status)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CbbMa_Loai)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTen_Ct)
        Me.Controls.Add(Me.TxtMa_Ct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtComment)
        Me.Controls.Add(Me.TxtUser_name_Find)
        Me.Controls.Add(Me.ChkDetail_OK)
        Me.Controls.Add(Me.CbbGroupByCT)
        Me.Controls.Add(Me.CbbGroupByTH)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtHostname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTitle1)
        Me.Controls.Add(Me.TxtMa_DM)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "SysHistoryUser"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_DM, 0)
        Me.Controls.SetChildIndex(Me.txtTitle1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtHostname, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.CbbGroupByTH, 0)
        Me.Controls.SetChildIndex(Me.CbbGroupByCT, 0)
        Me.Controls.SetChildIndex(Me.ChkDetail_OK, 0)
        Me.Controls.SetChildIndex(Me.TxtUser_name_Find, 0)
        Me.Controls.SetChildIndex(Me.TxtComment, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Ct, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Loai, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Status, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_phieu, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_post1, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_post2, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_CT1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_ct2, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        CType(Me.TxtMa_DM.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtUser_name_Find.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Ct.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTitle1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_DM As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtHostname As System.Windows.Forms.TextBox
    Friend WithEvents ChkDetail_OK As System.Windows.Forms.CheckBox
    Friend WithEvents CbbGroupByCT As System.Windows.Forms.ComboBox
    Friend WithEvents CbbGroupByTH As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtComment As System.Windows.Forms.TextBox
    Friend WithEvents TxtUser_name_Find As Cyber.SmLists.TxtLookup
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Ct As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Ct As Cyber.SmLists.TxtLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_Loai As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_Status As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_post2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_post1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabLoai_phieu As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_CT1 As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtM_Ngay_ct2 As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH

End Class
