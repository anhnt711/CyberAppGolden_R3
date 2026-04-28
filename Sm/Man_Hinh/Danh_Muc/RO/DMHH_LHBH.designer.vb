<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMHH_LHBH
    Inherits Cyber.From.FrmList

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
        Me.LabMa_vt = New System.Windows.Forms.Label()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_BH = New System.Windows.Forms.TextBox()
        Me.TxtMa_BH = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_LHBH = New System.Windows.Forms.TextBox()
        Me.TxtMa_LHBH = New Cyber.SmLists.TxtLookup()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.TxtNgay_hl = New ClsTextBox.txtDate1()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPT_HH_Phucloi = New ClsTextBox.txtTy_Gia()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPT_HH_GDKD = New ClsTextBox.txtTy_Gia()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPt_hh_tp = New ClsTextBox.txtTy_Gia()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtPT_HH_HT = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt3 = New System.Windows.Forms.Label()
        Me.Txtpt_hh_tv = New ClsTextBox.txtTy_Gia()
        Me.TxtPT_HH_CTY = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPT_HH_Phucloi5 = New ClsTextBox.txtTy_Gia()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtPt_hh_tp5 = New ClsTextBox.txtTy_Gia()
        Me.TxtPT_HH_GDKD5 = New ClsTextBox.txtTy_Gia()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPT_HH_HT5 = New ClsTextBox.txtTy_Gia()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtpt_hh_tv5 = New ClsTextBox.txtTy_Gia()
        Me.TxtPT_HH_CTY5 = New ClsTextBox.txtTy_Gia()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNh_kx = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtTen_nh = New System.Windows.Forms.TextBox()
        Me.ChkXe_moi = New System.Windows.Forms.CheckBox()
        Me.ChkXe_taitung = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_LHBH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(618, 320)
        Me.ButtExit.TabIndex = 19
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(516, 320)
        Me.ButtOK.TabIndex = 18
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(366, 330)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(108, 21)
        Me.TxtMa_Dvcs.TabIndex = 21
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(119, 329)
        Me.ChkActi.TabIndex = 20
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 310)
        Me.GroupBoxLine.Size = New System.Drawing.Size(716, 9)
        Me.GroupBoxLine.TabIndex = 14
        '
        'LabMa_vt
        '
        Me.LabMa_vt.Location = New System.Drawing.Point(3, 7)
        Me.LabMa_vt.Name = "LabMa_vt"
        Me.LabMa_vt.Size = New System.Drawing.Size(104, 13)
        Me.LabMa_vt.TabIndex = 20
        Me.LabMa_vt.Tag = "Item code"
        Me.LabMa_vt.Text = "Đơn vị BH"
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(3, 29)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(100, 13)
        Me.LabMa_kho.TabIndex = 21
        Me.LabMa_kho.Tag = "Stock code"
        Me.LabMa_kho.Text = "Loại hình BH"
        '
        'TxtTen_BH
        '
        Me.TxtTen_BH.BackColor = System.Drawing.Color.White
        Me.TxtTen_BH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BH.Enabled = False
        Me.TxtTen_BH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BH.Location = New System.Drawing.Point(278, 7)
        Me.TxtTen_BH.Name = "TxtTen_BH"
        Me.TxtTen_BH.ReadOnly = True
        Me.TxtTen_BH.Size = New System.Drawing.Size(382, 14)
        Me.TxtTen_BH.TabIndex = 382
        Me.TxtTen_BH.TabStop = False
        '
        'TxtMa_BH
        '
        Me.TxtMa_BH._ActilookupPopup = False
        Me.TxtMa_BH.CyberActilookupPopup = True
        Me.TxtMa_BH.Dv_ListDetail = Nothing
        Me.TxtMa_BH.Dv_Master = Nothing
        Me.TxtMa_BH.FilterClient = ""
        Me.TxtMa_BH.FilterSQL = ""
        Me.TxtMa_BH.Location = New System.Drawing.Point(125, 4)
        Me.TxtMa_BH.Name = "TxtMa_BH"
        Me.TxtMa_BH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BH.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_BH.TabIndex = 0
        Me.TxtMa_BH.Table_Name = ""
        '
        'TxtTen_LHBH
        '
        Me.TxtTen_LHBH.BackColor = System.Drawing.Color.White
        Me.TxtTen_LHBH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_LHBH.Enabled = False
        Me.TxtTen_LHBH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_LHBH.Location = New System.Drawing.Point(278, 29)
        Me.TxtTen_LHBH.Name = "TxtTen_LHBH"
        Me.TxtTen_LHBH.ReadOnly = True
        Me.TxtTen_LHBH.Size = New System.Drawing.Size(382, 14)
        Me.TxtTen_LHBH.TabIndex = 384
        Me.TxtTen_LHBH.TabStop = False
        '
        'TxtMa_LHBH
        '
        Me.TxtMa_LHBH._ActilookupPopup = False
        Me.TxtMa_LHBH.CyberActilookupPopup = True
        Me.TxtMa_LHBH.Dv_ListDetail = Nothing
        Me.TxtMa_LHBH.Dv_Master = Nothing
        Me.TxtMa_LHBH.FilterClient = ""
        Me.TxtMa_LHBH.FilterSQL = ""
        Me.TxtMa_LHBH.Location = New System.Drawing.Point(125, 26)
        Me.TxtMa_LHBH.Name = "TxtMa_LHBH"
        Me.TxtMa_LHBH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_LHBH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_LHBH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_LHBH.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_LHBH.TabIndex = 1
        Me.TxtMa_LHBH.Table_Name = ""
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.Location = New System.Drawing.Point(4, 76)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(100, 14)
        Me.LabNgay_ban.TabIndex = 29
        Me.LabNgay_ban.Tag = "Date"
        Me.LabNgay_ban.Text = "Ngày hiệu lực"
        '
        'TxtNgay_hl
        '
        Me.TxtNgay_hl.Flags = 65536
        Me.TxtNgay_hl.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_hl.IsAllowResize = False
        Me.TxtNgay_hl.isEmpty = True
        Me.TxtNgay_hl.Location = New System.Drawing.Point(125, 72)
        Me.TxtNgay_hl.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_hl.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_hl.MaxLength = 10
        Me.TxtNgay_hl.Name = "TxtNgay_hl"
        Me.TxtNgay_hl.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_hl.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_hl.ShowDayBeforeMonth = False
        Me.TxtNgay_hl.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_hl.TabIndex = 3
        Me.TxtNgay_hl.Text = "07/09/2011"
        Me.TxtNgay_hl.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(2, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 193)
        Me.GroupBox1.TabIndex = 389
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Xe dưới 500.000.000VNĐ"
        '
        'GroupBox2
        '
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(351, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 193)
        Me.GroupBox2.TabIndex = 397
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Xe trên 500.000.000VNĐ"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(33, 244)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 14)
        Me.Label8.TabIndex = 412
        Me.Label8.Tag = "Date"
        Me.Label8.Text = "% HH Phúc lợi"
        '
        'TxtPT_HH_Phucloi
        '
        Me.TxtPT_HH_Phucloi.AllowNegative = True
        Me.TxtPT_HH_Phucloi.Flags = 7680
        Me.TxtPT_HH_Phucloi.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_Phucloi.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_Phucloi.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_Phucloi.Location = New System.Drawing.Point(154, 242)
        Me.TxtPT_HH_Phucloi.MaxWholeDigits = 19
        Me.TxtPT_HH_Phucloi.Name = "TxtPT_HH_Phucloi"
        Me.TxtPT_HH_Phucloi.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_Phucloi.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_Phucloi.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_Phucloi.TabIndex = 11
        Me.TxtPT_HH_Phucloi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(33, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 14)
        Me.Label7.TabIndex = 410
        Me.Label7.Tag = "Date"
        Me.Label7.Text = "% HH GDKD"
        '
        'TxtPT_HH_GDKD
        '
        Me.TxtPT_HH_GDKD.AllowNegative = True
        Me.TxtPT_HH_GDKD.Flags = 7680
        Me.TxtPT_HH_GDKD.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_GDKD.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_GDKD.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_GDKD.Location = New System.Drawing.Point(154, 220)
        Me.TxtPT_HH_GDKD.MaxWholeDigits = 19
        Me.TxtPT_HH_GDKD.Name = "TxtPT_HH_GDKD"
        Me.TxtPT_HH_GDKD.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_GDKD.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_GDKD.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_GDKD.TabIndex = 10
        Me.TxtPT_HH_GDKD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(33, 199)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 14)
        Me.Label2.TabIndex = 408
        Me.Label2.Tag = "Date"
        Me.Label2.Text = "% HH TP"
        '
        'TxtPt_hh_tp
        '
        Me.TxtPt_hh_tp.AllowNegative = True
        Me.TxtPt_hh_tp.Flags = 7680
        Me.TxtPt_hh_tp.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPt_hh_tp.ForeColor = System.Drawing.Color.Navy
        Me.TxtPt_hh_tp.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPt_hh_tp.Location = New System.Drawing.Point(154, 197)
        Me.TxtPt_hh_tp.MaxWholeDigits = 19
        Me.TxtPt_hh_tp.Name = "TxtPt_hh_tp"
        Me.TxtPt_hh_tp.RangeMax = 1.7976931348623157E+308R
        Me.TxtPt_hh_tp.RangeMin = -1.7976931348623157E+308R
        Me.TxtPt_hh_tp.Size = New System.Drawing.Size(149, 21)
        Me.TxtPt_hh_tp.TabIndex = 9
        Me.TxtPt_hh_tp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(33, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 14)
        Me.Label1.TabIndex = 406
        Me.Label1.Tag = "Date"
        Me.Label1.Text = "% HH hỗ trợ"
        '
        'TxtPT_HH_HT
        '
        Me.TxtPT_HH_HT.AllowNegative = True
        Me.TxtPT_HH_HT.Flags = 7680
        Me.TxtPT_HH_HT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_HT.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_HT.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_HT.Location = New System.Drawing.Point(154, 175)
        Me.TxtPT_HH_HT.MaxWholeDigits = 19
        Me.TxtPT_HH_HT.Name = "TxtPT_HH_HT"
        Me.TxtPT_HH_HT.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_HT.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_HT.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_HT.TabIndex = 8
        Me.TxtPT_HH_HT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt3
        '
        Me.LabGia_nt3.Location = New System.Drawing.Point(33, 154)
        Me.LabGia_nt3.Name = "LabGia_nt3"
        Me.LabGia_nt3.Size = New System.Drawing.Size(121, 14)
        Me.LabGia_nt3.TabIndex = 405
        Me.LabGia_nt3.Tag = "Date"
        Me.LabGia_nt3.Text = "% HH Tư vấn"
        '
        'Txtpt_hh_tv
        '
        Me.Txtpt_hh_tv.AllowNegative = True
        Me.Txtpt_hh_tv.Flags = 7680
        Me.Txtpt_hh_tv.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Txtpt_hh_tv.ForeColor = System.Drawing.Color.Navy
        Me.Txtpt_hh_tv.InputMask = "### ### ### ### ##0.###0"
        Me.Txtpt_hh_tv.Location = New System.Drawing.Point(154, 152)
        Me.Txtpt_hh_tv.MaxWholeDigits = 19
        Me.Txtpt_hh_tv.Name = "Txtpt_hh_tv"
        Me.Txtpt_hh_tv.RangeMax = 1.7976931348623157E+308R
        Me.Txtpt_hh_tv.RangeMin = -1.7976931348623157E+308R
        Me.Txtpt_hh_tv.Size = New System.Drawing.Size(149, 21)
        Me.Txtpt_hh_tv.TabIndex = 7
        Me.Txtpt_hh_tv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPT_HH_CTY
        '
        Me.TxtPT_HH_CTY.AllowNegative = True
        Me.TxtPT_HH_CTY.Flags = 7680
        Me.TxtPT_HH_CTY.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_CTY.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_CTY.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_CTY.Location = New System.Drawing.Point(154, 129)
        Me.TxtPT_HH_CTY.MaxWholeDigits = 19
        Me.TxtPT_HH_CTY.Name = "TxtPT_HH_CTY"
        Me.TxtPT_HH_CTY.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_CTY.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_CTY.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_CTY.TabIndex = 6
        Me.TxtPT_HH_CTY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt2
        '
        Me.LabGia_nt2.Location = New System.Drawing.Point(32, 132)
        Me.LabGia_nt2.Name = "LabGia_nt2"
        Me.LabGia_nt2.Size = New System.Drawing.Size(121, 14)
        Me.LabGia_nt2.TabIndex = 404
        Me.LabGia_nt2.Tag = "Date"
        Me.LabGia_nt2.Text = "% HH công ty"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(364, 248)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(121, 14)
        Me.Label9.TabIndex = 424
        Me.Label9.Tag = "Date"
        Me.Label9.Text = "% HH Phúc lợi"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(364, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 14)
        Me.Label3.TabIndex = 420
        Me.Label3.Tag = "Date"
        Me.Label3.Text = "% HH TP"
        '
        'TxtPT_HH_Phucloi5
        '
        Me.TxtPT_HH_Phucloi5.AllowNegative = True
        Me.TxtPT_HH_Phucloi5.Flags = 7680
        Me.TxtPT_HH_Phucloi5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_Phucloi5.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_Phucloi5.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_Phucloi5.Location = New System.Drawing.Point(485, 246)
        Me.TxtPT_HH_Phucloi5.MaxWholeDigits = 19
        Me.TxtPT_HH_Phucloi5.Name = "TxtPT_HH_Phucloi5"
        Me.TxtPT_HH_Phucloi5.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_Phucloi5.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_Phucloi5.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_Phucloi5.TabIndex = 17
        Me.TxtPT_HH_Phucloi5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(364, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 14)
        Me.Label10.TabIndex = 422
        Me.Label10.Tag = "Date"
        Me.Label10.Text = "% HH GDKD"
        '
        'TxtPt_hh_tp5
        '
        Me.TxtPt_hh_tp5.AllowNegative = True
        Me.TxtPt_hh_tp5.Flags = 7680
        Me.TxtPt_hh_tp5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPt_hh_tp5.ForeColor = System.Drawing.Color.Navy
        Me.TxtPt_hh_tp5.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPt_hh_tp5.Location = New System.Drawing.Point(485, 199)
        Me.TxtPt_hh_tp5.MaxWholeDigits = 19
        Me.TxtPt_hh_tp5.Name = "TxtPt_hh_tp5"
        Me.TxtPt_hh_tp5.RangeMax = 1.7976931348623157E+308R
        Me.TxtPt_hh_tp5.RangeMin = -1.7976931348623157E+308R
        Me.TxtPt_hh_tp5.Size = New System.Drawing.Size(149, 21)
        Me.TxtPt_hh_tp5.TabIndex = 15
        Me.TxtPt_hh_tp5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPT_HH_GDKD5
        '
        Me.TxtPT_HH_GDKD5.AllowNegative = True
        Me.TxtPT_HH_GDKD5.Flags = 7680
        Me.TxtPT_HH_GDKD5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_GDKD5.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_GDKD5.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_GDKD5.Location = New System.Drawing.Point(485, 224)
        Me.TxtPT_HH_GDKD5.MaxWholeDigits = 19
        Me.TxtPT_HH_GDKD5.Name = "TxtPT_HH_GDKD5"
        Me.TxtPT_HH_GDKD5.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_GDKD5.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_GDKD5.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_GDKD5.TabIndex = 16
        Me.TxtPT_HH_GDKD5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(364, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 14)
        Me.Label4.TabIndex = 418
        Me.Label4.Tag = "Date"
        Me.Label4.Text = "% HH hỗ trợ"
        '
        'TxtPT_HH_HT5
        '
        Me.TxtPT_HH_HT5.AllowNegative = True
        Me.TxtPT_HH_HT5.Flags = 7680
        Me.TxtPT_HH_HT5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_HT5.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_HT5.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_HT5.Location = New System.Drawing.Point(485, 177)
        Me.TxtPT_HH_HT5.MaxWholeDigits = 19
        Me.TxtPT_HH_HT5.Name = "TxtPT_HH_HT5"
        Me.TxtPT_HH_HT5.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_HT5.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_HT5.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_HT5.TabIndex = 14
        Me.TxtPT_HH_HT5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(364, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 14)
        Me.Label5.TabIndex = 417
        Me.Label5.Tag = "Date"
        Me.Label5.Text = "% HH Tư vấn"
        '
        'Txtpt_hh_tv5
        '
        Me.Txtpt_hh_tv5.AllowNegative = True
        Me.Txtpt_hh_tv5.Flags = 7680
        Me.Txtpt_hh_tv5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Txtpt_hh_tv5.ForeColor = System.Drawing.Color.Navy
        Me.Txtpt_hh_tv5.InputMask = "### ### ### ### ##0.###0"
        Me.Txtpt_hh_tv5.Location = New System.Drawing.Point(485, 154)
        Me.Txtpt_hh_tv5.MaxWholeDigits = 19
        Me.Txtpt_hh_tv5.Name = "Txtpt_hh_tv5"
        Me.Txtpt_hh_tv5.RangeMax = 1.7976931348623157E+308R
        Me.Txtpt_hh_tv5.RangeMin = -1.7976931348623157E+308R
        Me.Txtpt_hh_tv5.Size = New System.Drawing.Size(149, 21)
        Me.Txtpt_hh_tv5.TabIndex = 13
        Me.Txtpt_hh_tv5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtPT_HH_CTY5
        '
        Me.TxtPT_HH_CTY5.AllowNegative = True
        Me.TxtPT_HH_CTY5.Flags = 7680
        Me.TxtPT_HH_CTY5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_HH_CTY5.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_HH_CTY5.InputMask = "### ### ### ### ##0.###0"
        Me.TxtPT_HH_CTY5.Location = New System.Drawing.Point(485, 131)
        Me.TxtPT_HH_CTY5.MaxWholeDigits = 19
        Me.TxtPT_HH_CTY5.Name = "TxtPT_HH_CTY5"
        Me.TxtPT_HH_CTY5.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_HH_CTY5.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_HH_CTY5.Size = New System.Drawing.Size(149, 21)
        Me.TxtPT_HH_CTY5.TabIndex = 12
        Me.TxtPT_HH_CTY5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(363, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 14)
        Me.Label6.TabIndex = 416
        Me.Label6.Tag = "Date"
        Me.Label6.Text = "% HH công ty"
        '
        'TxtNh_kx
        '
        Me.TxtNh_kx._ActilookupPopup = False
        Me.TxtNh_kx.CyberActilookupPopup = True
        Me.TxtNh_kx.Dv_ListDetail = Nothing
        Me.TxtNh_kx.Dv_Master = Nothing
        Me.TxtNh_kx.FilterClient = ""
        Me.TxtNh_kx.FilterSQL = ""
        Me.TxtNh_kx.Location = New System.Drawing.Point(125, 49)
        Me.TxtNh_kx.Name = "TxtNh_kx"
        Me.TxtNh_kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_kx.Size = New System.Drawing.Size(149, 20)
        Me.TxtNh_kx.TabIndex = 2
        Me.TxtNh_kx.Table_Name = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(3, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 15)
        Me.Label11.TabIndex = 426
        Me.Label11.Tag = "Item code"
        Me.Label11.Text = "Bảo hiểm liên kết hãng"
        '
        'TxtTen_nh
        '
        Me.TxtTen_nh.BackColor = System.Drawing.Color.White
        Me.TxtTen_nh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_nh.Enabled = False
        Me.TxtTen_nh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_nh.Location = New System.Drawing.Point(278, 53)
        Me.TxtTen_nh.Name = "TxtTen_nh"
        Me.TxtTen_nh.ReadOnly = True
        Me.TxtTen_nh.Size = New System.Drawing.Size(382, 14)
        Me.TxtTen_nh.TabIndex = 427
        Me.TxtTen_nh.TabStop = False
        '
        'ChkXe_moi
        '
        Me.ChkXe_moi.AutoSize = True
        Me.ChkXe_moi.Location = New System.Drawing.Point(354, 73)
        Me.ChkXe_moi.Name = "ChkXe_moi"
        Me.ChkXe_moi.Size = New System.Drawing.Size(57, 17)
        Me.ChkXe_moi.TabIndex = 4
        Me.ChkXe_moi.Text = "Xe mới"
        Me.ChkXe_moi.UseVisualStyleBackColor = True
        '
        'ChkXe_taitung
        '
        Me.ChkXe_taitung.AutoSize = True
        Me.ChkXe_taitung.Location = New System.Drawing.Point(481, 72)
        Me.ChkXe_taitung.Name = "ChkXe_taitung"
        Me.ChkXe_taitung.Size = New System.Drawing.Size(78, 17)
        Me.ChkXe_taitung.TabIndex = 5
        Me.ChkXe_taitung.Text = "Xe tái tụng"
        Me.ChkXe_taitung.UseVisualStyleBackColor = True
        '
        'DMHH_LHBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(720, 353)
        Me.Controls.Add(Me.ChkXe_taitung)
        Me.Controls.Add(Me.ChkXe_moi)
        Me.Controls.Add(Me.TxtTen_nh)
        Me.Controls.Add(Me.TxtNh_kx)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtPT_HH_Phucloi5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtPt_hh_tp5)
        Me.Controls.Add(Me.TxtPT_HH_GDKD5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtPT_HH_HT5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Txtpt_hh_tv5)
        Me.Controls.Add(Me.TxtPT_HH_CTY5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtPT_HH_Phucloi)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtPT_HH_GDKD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPt_hh_tp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPT_HH_HT)
        Me.Controls.Add(Me.LabGia_nt3)
        Me.Controls.Add(Me.Txtpt_hh_tv)
        Me.Controls.Add(Me.TxtPT_HH_CTY)
        Me.Controls.Add(Me.LabGia_nt2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtNgay_hl)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.TxtTen_LHBH)
        Me.Controls.Add(Me.TxtMa_LHBH)
        Me.Controls.Add(Me.TxtTen_BH)
        Me.Controls.Add(Me.TxtMa_BH)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.LabMa_vt)
        Me.KeyPreview = True
        Me.Name = "DMHH_LHBH"
        Me.Controls.SetChildIndex(Me.LabMa_vt, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_LHBH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_LHBH, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_hl, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_CTY, 0)
        Me.Controls.SetChildIndex(Me.Txtpt_hh_tv, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt3, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_HT, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtPt_hh_tp, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_GDKD, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_Phucloi, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_CTY5, 0)
        Me.Controls.SetChildIndex(Me.Txtpt_hh_tv5, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_HT5, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_GDKD5, 0)
        Me.Controls.SetChildIndex(Me.TxtPt_hh_tp5, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_HH_Phucloi5, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_nh, 0)
        Me.Controls.SetChildIndex(Me.ChkXe_moi, 0)
        Me.Controls.SetChildIndex(Me.ChkXe_taitung, 0)
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_LHBH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_vt As System.Windows.Forms.Label
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_BH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BH As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_LHBH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_LHBH As Cyber.SmLists.TxtLookup
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_hl As ClsTextBox.txtDate1
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_HH_Phucloi As ClsTextBox.txtTy_Gia
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_HH_GDKD As ClsTextBox.txtTy_Gia
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPt_hh_tp As ClsTextBox.txtTy_Gia
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_HH_HT As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt3 As System.Windows.Forms.Label
    Friend WithEvents Txtpt_hh_tv As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtPT_HH_CTY As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_HH_Phucloi5 As ClsTextBox.txtTy_Gia
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtPt_hh_tp5 As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtPT_HH_GDKD5 As ClsTextBox.txtTy_Gia
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtPT_HH_HT5 As ClsTextBox.txtTy_Gia
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Txtpt_hh_tv5 As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtPT_HH_CTY5 As ClsTextBox.txtTy_Gia
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNh_kx As Cyber.SmLists.TxtLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_nh As System.Windows.Forms.TextBox
    Friend WithEvents ChkXe_moi As System.Windows.Forms.CheckBox
    Friend WithEvents ChkXe_taitung As System.Windows.Forms.CheckBox

End Class
