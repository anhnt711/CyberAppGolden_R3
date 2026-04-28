<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRMQLLLBK1
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_Mau = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.LabMa_TH = New System.Windows.Forms.Label()
        Me.CmbMa_TH = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Cs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Cs = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_Loai = New System.Windows.Forms.TextBox()
        Me.TxtMa_Loai = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTen_Ngay = New System.Windows.Forms.TextBox()
        Me.TxtMa_Ngay = New Cyber.SmLists.TxtLookup()
        Me.LabMa_TTCS = New System.Windows.Forms.Label()
        Me.CmbMa_TTCS = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTen_ChienDich = New System.Windows.Forms.TextBox()
        Me.TxtMa_ChienDich = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Cs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Loai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Ngay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_ChienDich.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 311)
        Me.ButtExit.TabIndex = 16
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 272)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 275)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 311)
        Me.ButtOK.TabIndex = 15
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 253)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 250)
        Me.ChkVND.TabIndex = 12
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(241, 250)
        Me.ChkNT.TabIndex = 13
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 30)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 1
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 53)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 2
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(8, 34)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(8, 57)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 294)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 15)
        Me.Label6.TabIndex = 1867
        Me.Label6.Tag = "Staff"
        Me.Label6.Text = "CVDV (TVBH)"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(213, 120)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(373, 14)
        Me.TxtTen_Hs.TabIndex = 1866
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
        Me.TxtMa_Hs.Location = New System.Drawing.Point(95, 118)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Hs.TabIndex = 6
        Me.TxtMa_Hs.Table_Name = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(8, 205)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 1865
        Me.Label7.Tag = "License plate"
        Me.Label7.Text = "Biển số"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.Location = New System.Drawing.Point(95, 202)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(114, 21)
        Me.TxtMa_Xe.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 1864
        Me.Label3.Tag = "Color"
        Me.Label3.Text = "Màu xe"
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Mau.Enabled = False
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Mau.Location = New System.Drawing.Point(213, 185)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(373, 14)
        Me.TxtTen_Mau.TabIndex = 1863
        Me.TxtTen_Mau.TabStop = False
        '
        'TxtMa_Mau
        '
        Me.TxtMa_Mau._ActilookupPopup = False
        Me.TxtMa_Mau.CyberActilookupPopup = True
        Me.TxtMa_Mau.Dv_ListDetail = Nothing
        Me.TxtMa_Mau.Dv_Master = Nothing
        Me.TxtMa_Mau.FilterClient = ""
        Me.TxtMa_Mau.FilterSQL = ""
        Me.TxtMa_Mau.Location = New System.Drawing.Point(95, 181)
        Me.TxtMa_Mau.Name = "TxtMa_Mau"
        Me.TxtMa_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Mau.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Mau.TabIndex = 9
        Me.TxtMa_Mau.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 1862
        Me.Label4.Tag = "type car"
        Me.Label4.Text = "Kiểu xe"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(213, 162)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(373, 14)
        Me.TxtTen_Kx.TabIndex = 1861
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(95, 160)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Kx.TabIndex = 8
        Me.TxtMa_Kx.Table_Name = ""
        '
        'LabMa_TH
        '
        Me.LabMa_TH.AutoSize = True
        Me.LabMa_TH.Location = New System.Drawing.Point(8, 10)
        Me.LabMa_TH.Name = "LabMa_TH"
        Me.LabMa_TH.Size = New System.Drawing.Size(77, 13)
        Me.LabMa_TH.TabIndex = 1869
        Me.LabMa_TH.Tag = "Group by"
        Me.LabMa_TH.Text = "Tổng hợp theo"
        '
        'CmbMa_TH
        '
        Me.CmbMa_TH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_TH.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_TH.FormattingEnabled = True
        Me.CmbMa_TH.Location = New System.Drawing.Point(95, 6)
        Me.CmbMa_TH.Name = "CmbMa_TH"
        Me.CmbMa_TH.Size = New System.Drawing.Size(491, 21)
        Me.CmbMa_TH.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 1872
        Me.Label2.Tag = "Staff"
        Me.Label2.Text = "NV CS/CR"
        '
        'TxtTen_Cs
        '
        Me.TxtTen_Cs.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Cs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Cs.Enabled = False
        Me.TxtTen_Cs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cs.Location = New System.Drawing.Point(213, 141)
        Me.TxtTen_Cs.Name = "TxtTen_Cs"
        Me.TxtTen_Cs.ReadOnly = True
        Me.TxtTen_Cs.Size = New System.Drawing.Size(373, 14)
        Me.TxtTen_Cs.TabIndex = 1871
        Me.TxtTen_Cs.TabStop = False
        '
        'TxtMa_Cs
        '
        Me.TxtMa_Cs._ActilookupPopup = False
        Me.TxtMa_Cs.CyberActilookupPopup = True
        Me.TxtMa_Cs.Dv_ListDetail = Nothing
        Me.TxtMa_Cs.Dv_Master = Nothing
        Me.TxtMa_Cs.FilterClient = ""
        Me.TxtMa_Cs.FilterSQL = ""
        Me.TxtMa_Cs.Location = New System.Drawing.Point(95, 139)
        Me.TxtMa_Cs.Name = "TxtMa_Cs"
        Me.TxtMa_Cs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cs.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Cs.TabIndex = 7
        Me.TxtMa_Cs.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 15)
        Me.Label5.TabIndex = 1875
        Me.Label5.Tag = "Staff"
        Me.Label5.Text = "Hình thức C/S"
        '
        'TxtTen_Loai
        '
        Me.TxtTen_Loai.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Loai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Loai.Enabled = False
        Me.TxtTen_Loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Loai.Location = New System.Drawing.Point(213, 79)
        Me.TxtTen_Loai.Name = "TxtTen_Loai"
        Me.TxtTen_Loai.ReadOnly = True
        Me.TxtTen_Loai.Size = New System.Drawing.Size(373, 14)
        Me.TxtTen_Loai.TabIndex = 1874
        Me.TxtTen_Loai.TabStop = False
        '
        'TxtMa_Loai
        '
        Me.TxtMa_Loai._ActilookupPopup = False
        Me.TxtMa_Loai.CyberActilookupPopup = True
        Me.TxtMa_Loai.Dv_ListDetail = Nothing
        Me.TxtMa_Loai.Dv_Master = Nothing
        Me.TxtMa_Loai.FilterClient = ""
        Me.TxtMa_Loai.FilterSQL = ""
        Me.TxtMa_Loai.Location = New System.Drawing.Point(95, 76)
        Me.TxtMa_Loai.Name = "TxtMa_Loai"
        Me.TxtMa_Loai.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Loai.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Loai.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Loai.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Loai.TabIndex = 4
        Me.TxtMa_Loai.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 15)
        Me.Label8.TabIndex = 1878
        Me.Label8.Tag = "Staff"
        Me.Label8.Text = "Loại ngày"
        '
        'TxtTen_Ngay
        '
        Me.TxtTen_Ngay.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Ngay.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Ngay.Enabled = False
        Me.TxtTen_Ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Ngay.Location = New System.Drawing.Point(213, 100)
        Me.TxtTen_Ngay.Name = "TxtTen_Ngay"
        Me.TxtTen_Ngay.ReadOnly = True
        Me.TxtTen_Ngay.Size = New System.Drawing.Size(373, 14)
        Me.TxtTen_Ngay.TabIndex = 1877
        Me.TxtTen_Ngay.TabStop = False
        '
        'TxtMa_Ngay
        '
        Me.TxtMa_Ngay._ActilookupPopup = False
        Me.TxtMa_Ngay.CyberActilookupPopup = True
        Me.TxtMa_Ngay.Dv_ListDetail = Nothing
        Me.TxtMa_Ngay.Dv_Master = Nothing
        Me.TxtMa_Ngay.FilterClient = ""
        Me.TxtMa_Ngay.FilterSQL = ""
        Me.TxtMa_Ngay.Location = New System.Drawing.Point(95, 97)
        Me.TxtMa_Ngay.Name = "TxtMa_Ngay"
        Me.TxtMa_Ngay.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Ngay.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Ngay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Ngay.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Ngay.TabIndex = 5
        Me.TxtMa_Ngay.Table_Name = ""
        '
        'LabMa_TTCS
        '
        Me.LabMa_TTCS.AutoSize = True
        Me.LabMa_TTCS.Location = New System.Drawing.Point(226, 34)
        Me.LabMa_TTCS.Name = "LabMa_TTCS"
        Me.LabMa_TTCS.Size = New System.Drawing.Size(76, 13)
        Me.LabMa_TTCS.TabIndex = 1880
        Me.LabMa_TTCS.Tag = "Group by"
        Me.LabMa_TTCS.Text = "Tình trạng C/S"
        '
        'CmbMa_TTCS
        '
        Me.CmbMa_TTCS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_TTCS.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_TTCS.FormattingEnabled = True
        Me.CmbMa_TTCS.Location = New System.Drawing.Point(313, 30)
        Me.CmbMa_TTCS.Name = "CmbMa_TTCS"
        Me.CmbMa_TTCS.Size = New System.Drawing.Size(273, 21)
        Me.CmbMa_TTCS.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 15)
        Me.Label9.TabIndex = 1883
        Me.Label9.Tag = "Color"
        Me.Label9.Text = "Chiến dịch"
        '
        'TxtTen_ChienDich
        '
        Me.TxtTen_ChienDich.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_ChienDich.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_ChienDich.Enabled = False
        Me.TxtTen_ChienDich.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ChienDich.Location = New System.Drawing.Point(213, 228)
        Me.TxtTen_ChienDich.Name = "TxtTen_ChienDich"
        Me.TxtTen_ChienDich.ReadOnly = True
        Me.TxtTen_ChienDich.Size = New System.Drawing.Size(373, 14)
        Me.TxtTen_ChienDich.TabIndex = 1882
        Me.TxtTen_ChienDich.TabStop = False
        '
        'TxtMa_ChienDich
        '
        Me.TxtMa_ChienDich._ActilookupPopup = False
        Me.TxtMa_ChienDich.CyberActilookupPopup = True
        Me.TxtMa_ChienDich.Dv_ListDetail = Nothing
        Me.TxtMa_ChienDich.Dv_Master = Nothing
        Me.TxtMa_ChienDich.FilterClient = ""
        Me.TxtMa_ChienDich.FilterSQL = ""
        Me.TxtMa_ChienDich.Location = New System.Drawing.Point(95, 224)
        Me.TxtMa_ChienDich.Name = "TxtMa_ChienDich"
        Me.TxtMa_ChienDich.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_ChienDich.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_ChienDich.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_ChienDich.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_ChienDich.TabIndex = 11
        Me.TxtMa_ChienDich.Table_Name = ""
        '
        'CRMQLLLBK1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 364)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTen_ChienDich)
        Me.Controls.Add(Me.TxtMa_ChienDich)
        Me.Controls.Add(Me.LabMa_TTCS)
        Me.Controls.Add(Me.CmbMa_TTCS)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTen_Ngay)
        Me.Controls.Add(Me.TxtMa_Ngay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_Loai)
        Me.Controls.Add(Me.TxtMa_Loai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Cs)
        Me.Controls.Add(Me.TxtMa_Cs)
        Me.Controls.Add(Me.LabMa_TH)
        Me.Controls.Add(Me.CmbMa_TH)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.TxtMa_Mau)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "CRMQLLLBK1"
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
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_TH, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cs, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Loai, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Loai, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Ngay, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Ngay, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_TTCS, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTCS, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_ChienDich, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ChienDich, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Cs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Loai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Ngay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_ChienDich.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Mau As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_TH As System.Windows.Forms.Label
    Friend WithEvents CmbMa_TH As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Cs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Cs As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Loai As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Loai As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Ngay As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Ngay As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_TTCS As System.Windows.Forms.Label
    Friend WithEvents CmbMa_TTCS As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_ChienDich As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_ChienDich As Cyber.SmLists.TxtLookup

End Class
