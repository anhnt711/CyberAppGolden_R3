<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ro_Up_Hang_Loc
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_Mau = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtten_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbbMa_Loai = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSo_thang = New ClsTextBox.txtTien_NT()
        Me.TxtNgay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtNgay_ct2 = New ClsTextBox.txtDate1()
        Me.CmbMa_kx = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtSo_ngay = New ClsTextBox.txtTien_NT()
        Me.LblNgay = New System.Windows.Forms.Label()
        Me.TxtSo_RO = New System.Windows.Forms.TextBox()
        Me.LabSo_Ct1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbbMa_post2 = New System.Windows.Forms.ComboBox()
        Me.CbbMa_Post1 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.ChkIs_Loai = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 122)
        Me.GroupBoxLine.Size = New System.Drawing.Size(676, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(476, 132)
        Me.ButtOK.TabIndex = 8
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(578, 132)
        Me.ButtExit.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 15)
        Me.Label3.TabIndex = 519
        Me.Label3.Tag = "FA ID"
        Me.Label3.Text = "Màu xe"
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.BackColor = System.Drawing.Color.White
        Me.TxtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Mau.Enabled = False
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Mau.Location = New System.Drawing.Point(206, 275)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(364, 13)
        Me.TxtTen_Mau.TabIndex = 518
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
        Me.TxtMa_Mau.Location = New System.Drawing.Point(92, 268)
        Me.TxtMa_Mau.Name = "TxtMa_Mau"
        Me.TxtMa_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Mau.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Mau.TabIndex = 6
        Me.TxtMa_Mau.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 517
        Me.Label4.Tag = "FA ID"
        Me.Label4.Text = "Kiểu xe"
        '
        'Txtten_Kx
        '
        Me.Txtten_Kx.BackColor = System.Drawing.Color.White
        Me.Txtten_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Kx.Enabled = False
        Me.Txtten_Kx.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Kx.Location = New System.Drawing.Point(206, 250)
        Me.Txtten_Kx.Name = "Txtten_Kx"
        Me.Txtten_Kx.ReadOnly = True
        Me.Txtten_Kx.Size = New System.Drawing.Size(364, 13)
        Me.Txtten_Kx.TabIndex = 516
        Me.Txtten_Kx.TabStop = False
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(92, 245)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Kx.TabIndex = 5
        Me.TxtMa_Kx.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(239, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 523
        Me.Label2.Tag = "Date to"
        Me.Label2.Text = "Đến ngày"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 522
        Me.Label1.Tag = "Date from"
        Me.Label1.Text = "Từ ngày"
        '
        'CbbMa_Loai
        '
        Me.CbbMa_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Loai.Enabled = False
        Me.CbbMa_Loai.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Loai.FormattingEnabled = True
        Me.CbbMa_Loai.Location = New System.Drawing.Point(305, 253)
        Me.CbbMa_Loai.Name = "CbbMa_Loai"
        Me.CbbMa_Loai.Size = New System.Drawing.Size(267, 21)
        Me.CbbMa_Loai.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(227, 259)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 525
        Me.Label5.Tag = "To from"
        Me.Label5.Text = "Loại đánh giá"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.Location = New System.Drawing.Point(95, 49)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(128, 20)
        Me.TxtMa_Xe.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(25, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 1847
        Me.Label7.Tag = "Plates"
        Me.Label7.Text = "Biển số"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(25, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 1850
        Me.Label6.Tag = "Advisor"
        Me.Label6.Text = "CVDV"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(229, 74)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(364, 13)
        Me.TxtTen_Hs.TabIndex = 1849
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
        Me.TxtMa_Hs.Location = New System.Drawing.Point(95, 71)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(128, 20)
        Me.TxtMa_Hs.TabIndex = 4
        Me.TxtMa_Hs.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(227, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 1852
        Me.Label8.Text = "Số tháng lọc"
        '
        'TxtSo_thang
        '
        Me.TxtSo_thang.AllowNegative = True
        Me.TxtSo_thang.Flags = 7680
        Me.TxtSo_thang.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_thang.InputMask = "### ### ### ### ###"
        Me.TxtSo_thang.Location = New System.Drawing.Point(305, 277)
        Me.TxtSo_thang.MaxWholeDigits = 14
        Me.TxtSo_thang.Name = "TxtSo_thang"
        Me.TxtSo_thang.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_thang.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_thang.Size = New System.Drawing.Size(99, 20)
        Me.TxtSo_thang.TabIndex = 7
        Me.TxtSo_thang.Text = "6"
        Me.TxtSo_thang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.Flags = 0
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct1.IsAllowResize = False
        Me.TxtNgay_Ct1.isEmpty = True
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(95, 4)
        Me.TxtNgay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(128, 20)
        Me.TxtNgay_Ct1.TabIndex = 0
        Me.TxtNgay_Ct1.Text = "__/__/____"
        Me.TxtNgay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtNgay_ct2
        '
        Me.TxtNgay_ct2.Flags = 0
        Me.TxtNgay_ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_ct2.IsAllowResize = False
        Me.TxtNgay_ct2.isEmpty = True
        Me.TxtNgay_ct2.Location = New System.Drawing.Point(310, 7)
        Me.TxtNgay_ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_ct2.MaxLength = 10
        Me.TxtNgay_ct2.Name = "TxtNgay_ct2"
        Me.TxtNgay_ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_ct2.Size = New System.Drawing.Size(128, 20)
        Me.TxtNgay_ct2.TabIndex = 1
        Me.TxtNgay_ct2.Text = "__/__/____"
        Me.TxtNgay_ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'CmbMa_kx
        '
        Me.CmbMa_kx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_kx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbMa_kx.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_kx.FormattingEnabled = True
        Me.CmbMa_kx.Location = New System.Drawing.Point(92, 292)
        Me.CmbMa_kx.Name = "CmbMa_kx"
        Me.CmbMa_kx.Size = New System.Drawing.Size(212, 23)
        Me.CmbMa_kx.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(4, 295)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 15)
        Me.Label11.TabIndex = 1949
        Me.Label11.Tag = "FA ID"
        Me.Label11.Text = "Loại xe"
        '
        'TxtSo_ngay
        '
        Me.TxtSo_ngay.AllowNegative = True
        Me.TxtSo_ngay.Flags = 7680
        Me.TxtSo_ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_ngay.InputMask = "### ### ### ### ###"
        Me.TxtSo_ngay.Location = New System.Drawing.Point(481, 277)
        Me.TxtSo_ngay.MaxWholeDigits = 14
        Me.TxtSo_ngay.Name = "TxtSo_ngay"
        Me.TxtSo_ngay.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_ngay.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_ngay.Size = New System.Drawing.Size(91, 20)
        Me.TxtSo_ngay.TabIndex = 8
        Me.TxtSo_ngay.Text = "3"
        Me.TxtSo_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtSo_ngay.Visible = False
        '
        'LblNgay
        '
        Me.LblNgay.AutoSize = True
        Me.LblNgay.ForeColor = System.Drawing.Color.Navy
        Me.LblNgay.Location = New System.Drawing.Point(410, 280)
        Me.LblNgay.Name = "LblNgay"
        Me.LblNgay.Size = New System.Drawing.Size(65, 13)
        Me.LblNgay.TabIndex = 1950
        Me.LblNgay.Text = "Ngày Follow"
        Me.LblNgay.Visible = False
        '
        'TxtSo_RO
        '
        Me.TxtSo_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_RO.Location = New System.Drawing.Point(95, 28)
        Me.TxtSo_RO.Name = "TxtSo_RO"
        Me.TxtSo_RO.Size = New System.Drawing.Size(128, 20)
        Me.TxtSo_RO.TabIndex = 2
        '
        'LabSo_Ct1
        '
        Me.LabSo_Ct1.Location = New System.Drawing.Point(25, 30)
        Me.LabSo_Ct1.Name = "LabSo_Ct1"
        Me.LabSo_Ct1.Size = New System.Drawing.Size(51, 15)
        Me.LabSo_Ct1.TabIndex = 1952
        Me.LabSo_Ct1.Tag = "R/O"
        Me.LabSo_Ct1.Text = "Số lệnh"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(350, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 1956
        Me.Label9.Tag = "Level to"
        Me.Label9.Text = "Đến mức xử lý"
        '
        'CbbMa_post2
        '
        Me.CbbMa_post2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_post2.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_post2.FormattingEnabled = True
        Me.CbbMa_post2.Location = New System.Drawing.Point(443, 97)
        Me.CbbMa_post2.Name = "CbbMa_post2"
        Me.CbbMa_post2.Size = New System.Drawing.Size(213, 21)
        Me.CbbMa_post2.TabIndex = 7
        '
        'CbbMa_Post1
        '
        Me.CbbMa_Post1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post1.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post1.FormattingEnabled = True
        Me.CbbMa_Post1.Location = New System.Drawing.Point(95, 97)
        Me.CbbMa_Post1.Name = "CbbMa_Post1"
        Me.CbbMa_Post1.Size = New System.Drawing.Size(213, 21)
        Me.CbbMa_Post1.TabIndex = 6
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(23, 99)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(75, 17)
        Me.Label17.TabIndex = 1955
        Me.Label17.Tag = "Level from"
        Me.Label17.Text = "Từ mức xử lý"
        '
        'ChkIs_Loai
        '
        Me.ChkIs_Loai.AutoSize = True
        Me.ChkIs_Loai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIs_Loai.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkIs_Loai.Location = New System.Drawing.Point(443, 5)
        Me.ChkIs_Loai.Name = "ChkIs_Loai"
        Me.ChkIs_Loai.Size = New System.Drawing.Size(211, 19)
        Me.ChkIs_Loai.TabIndex = 2024
        Me.ChkIs_Loai.TabStop = False
        Me.ChkIs_Loai.Tag = "Warranty"
        Me.ChkIs_Loai.Text = "Lọc lệnh chưa cập nhật lệnh hãng"
        Me.ChkIs_Loai.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkIs_Loai.UseVisualStyleBackColor = True
        '
        'ROLOADTMSS_HDK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(680, 186)
        Me.Controls.Add(Me.ChkIs_Loai)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CbbMa_post2)
        Me.Controls.Add(Me.CbbMa_Post1)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtSo_RO)
        Me.Controls.Add(Me.LabSo_Ct1)
        Me.Controls.Add(Me.TxtSo_ngay)
        Me.Controls.Add(Me.LblNgay)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CmbMa_kx)
        Me.Controls.Add(Me.TxtNgay_ct2)
        Me.Controls.Add(Me.TxtNgay_Ct1)
        Me.Controls.Add(Me.TxtSo_thang)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.CbbMa_Loai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.TxtMa_Mau)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtten_Kx)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Name = "ROLOADTMSS_HDK"
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Loai, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_thang, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_ct2, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_kx, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.LblNgay, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_ngay, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabSo_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_RO, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_post2, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Loai, 0)
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Mau As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtten_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_Loai As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_thang As ClsTextBox.txtTien_NT
    Friend WithEvents TxtNgay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtNgay_ct2 As ClsTextBox.txtDate1
    Friend WithEvents CmbMa_kx As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_ngay As ClsTextBox.txtTien_NT
    Friend WithEvents LblNgay As System.Windows.Forms.Label
    Friend WithEvents TxtSo_RO As System.Windows.Forms.TextBox
    Friend WithEvents LabSo_Ct1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_post2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_Post1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents ChkIs_Loai As System.Windows.Forms.CheckBox

End Class
