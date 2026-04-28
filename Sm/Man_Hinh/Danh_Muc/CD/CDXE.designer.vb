<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDXE
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
        Me.TxtDu_NT00 = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabMa_CD = New System.Windows.Forms.Label()
        Me.TxtDu00 = New ClsTextBox.txtTien_NT()
        Me.txtTon00 = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMa_kx = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_kx = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtMa_Vitri = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_vitri = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        Me.TxtTen_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtMa_mau = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_mau = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSo_khung = New System.Windows.Forms.TextBox()
        Me.TxtSo_May = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNam_SX = New ClsTextBox.txtTien_NT()
        Me.TxtSo_hang = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNgay_Nhap = New ClsTextBox.txtDate1()
        Me.Label13 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Vitri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(622, 303)
        Me.ButtExit.TabIndex = 15
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(520, 303)
        Me.ButtOK.TabIndex = 14
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(119, 30)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(135, 21)
        Me.TxtMa_Dvcs.TabIndex = 1
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = True
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 313)
        Me.ChkActi.TabIndex = 12
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 293)
        Me.GroupBoxLine.Size = New System.Drawing.Size(720, 9)
        Me.GroupBoxLine.TabIndex = 11
        '
        'TxtDu_NT00
        '
        Me.TxtDu_NT00.AllowNegative = True
        Me.TxtDu_NT00.Flags = 7680
        Me.TxtDu_NT00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_NT00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_NT00.InputMask = "### ### ### ### ###"
        Me.TxtDu_NT00.Location = New System.Drawing.Point(119, 268)
        Me.TxtDu_NT00.MaxWholeDigits = 14
        Me.TxtDu_NT00.Name = "TxtDu_NT00"
        Me.TxtDu_NT00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_NT00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_NT00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu_NT00.TabIndex = 12
        Me.TxtDu_NT00.Tag = "### ### ### ### ###.##"
        Me.TxtDu_NT00.Text = "0"
        Me.TxtDu_NT00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(3, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 18)
        Me.Label3.TabIndex = 263
        Me.Label3.Tag = "Opening balance"
        Me.Label3.Text = "Dư đầu kỳ (Giá trị)"
        '
        'TxtTen_kho
        '
        Me.TxtTen_kho.BackColor = System.Drawing.Color.White
        Me.TxtTen_kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kho.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kho.Location = New System.Drawing.Point(261, 100)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(427, 14)
        Me.TxtTen_kho.TabIndex = 260
        Me.TxtTen_kho.TabStop = False
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbMa_Phi.ForeColor = System.Drawing.Color.Navy
        Me.lbMa_Phi.Location = New System.Drawing.Point(4, 99)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(102, 18)
        Me.lbMa_Phi.TabIndex = 262
        Me.lbMa_Phi.Tag = "Warehouse"
        Me.lbMa_Phi.Text = "Kho"
        '
        'TxtMa_kho
        '
        Me.TxtMa_kho._ActilookupPopup = False
        Me.TxtMa_kho.CyberActilookupPopup = True
        Me.TxtMa_kho.Dv_ListDetail = Nothing
        Me.TxtMa_kho.Dv_Master = Nothing
        Me.TxtMa_kho.FilterClient = ""
        Me.TxtMa_kho.FilterSQL = ""
        Me.TxtMa_kho.Location = New System.Drawing.Point(119, 97)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_kho.TabIndex = 4
        Me.TxtMa_kho.Table_Name = ""
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(5, 308)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(469, 22)
        Me.Label12.TabIndex = 12
        Me.Label12.Tag = "Note: Year starts balance inserts into balance sheet"
        Me.Label12.Text = "Ghi chú: Số dư đầu năm để lên bảng cân đối kế toán"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(4, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 18)
        Me.Label8.TabIndex = 277
        Me.Label8.Tag = "Location"
        Me.Label8.Text = "Vị trí"
        '
        'LabMa_CD
        '
        Me.LabMa_CD.Location = New System.Drawing.Point(4, 33)
        Me.LabMa_CD.Name = "LabMa_CD"
        Me.LabMa_CD.Size = New System.Drawing.Size(102, 15)
        Me.LabMa_CD.TabIndex = 281
        Me.LabMa_CD.Tag = "Acc unit"
        Me.LabMa_CD.Text = "Đơn vị hạch toán"
        '
        'TxtDu00
        '
        Me.TxtDu00.AllowNegative = True
        Me.TxtDu00.Flags = 7680
        Me.TxtDu00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu00.InputMask = "### ### ### ### ###"
        Me.TxtDu00.Location = New System.Drawing.Point(444, 272)
        Me.TxtDu00.MaxWholeDigits = 14
        Me.TxtDu00.Name = "TxtDu00"
        Me.TxtDu00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu00.Size = New System.Drawing.Size(135, 21)
        Me.TxtDu00.TabIndex = 13
        Me.TxtDu00.Tag = "### ### ### ### ###.##"
        Me.TxtDu00.Text = "0"
        Me.TxtDu00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDu00.Visible = False
        '
        'txtTon00
        '
        Me.txtTon00.AllowNegative = True
        Me.txtTon00.Flags = 7680
        Me.txtTon00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTon00.ForeColor = System.Drawing.Color.Navy
        Me.txtTon00.InputMask = "### ### ### ### ###"
        Me.txtTon00.Location = New System.Drawing.Point(119, 245)
        Me.txtTon00.MaxWholeDigits = 14
        Me.txtTon00.Name = "txtTon00"
        Me.txtTon00.RangeMax = 1.7976931348623157E+308R
        Me.txtTon00.RangeMin = -1.7976931348623157E+308R
        Me.txtTon00.Size = New System.Drawing.Size(135, 21)
        Me.txtTon00.TabIndex = 11
        Me.txtTon00.Tag = "### ### ### ### ###.##"
        Me.txtTon00.Text = "1"
        Me.txtTon00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(313, 271)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 18)
        Me.Label2.TabIndex = 287
        Me.Label2.Tag = "Opening balance (VND)"
        Me.Label2.Text = "Dư đầu kỳ VND (giá trị)"
        Me.Label2.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(4, 246)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 18)
        Me.Label6.TabIndex = 286
        Me.Label6.Tag = "Opening stock"
        Me.Label6.Text = "Tồn đầu kỳ (số lượng)"
        '
        'TxtMa_kx
        '
        Me.TxtMa_kx._ActilookupPopup = False
        Me.TxtMa_kx.CyberActilookupPopup = True
        Me.TxtMa_kx.Dv_ListDetail = Nothing
        Me.TxtMa_kx.Dv_Master = Nothing
        Me.TxtMa_kx.EditValue = ""
        Me.TxtMa_kx.FilterClient = ""
        Me.TxtMa_kx.FilterSQL = ""
        Me.TxtMa_kx.Location = New System.Drawing.Point(119, 53)
        Me.TxtMa_kx.Name = "TxtMa_kx"
        Me.TxtMa_kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kx.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_kx.TabIndex = 2
        Me.TxtMa_kx.Table_Name = ""
        '
        'TxtTen_kx
        '
        Me.TxtTen_kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kx.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kx.Location = New System.Drawing.Point(261, 56)
        Me.TxtTen_kx.Name = "TxtTen_kx"
        Me.TxtTen_kx.ReadOnly = True
        Me.TxtTen_kx.Size = New System.Drawing.Size(427, 14)
        Me.TxtTen_kx.TabIndex = 294
        Me.TxtTen_kx.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(4, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 18)
        Me.Label11.TabIndex = 295
        Me.Label11.Tag = "Model car"
        Me.Label11.Text = "Kiểu xe"
        '
        'TxtMa_Vitri
        '
        Me.TxtMa_Vitri._ActilookupPopup = False
        Me.TxtMa_Vitri.CyberActilookupPopup = True
        Me.TxtMa_Vitri.Dv_ListDetail = Nothing
        Me.TxtMa_Vitri.Dv_Master = Nothing
        Me.TxtMa_Vitri.FilterClient = ""
        Me.TxtMa_Vitri.FilterSQL = ""
        Me.TxtMa_Vitri.Location = New System.Drawing.Point(119, 119)
        Me.TxtMa_Vitri.Name = "TxtMa_Vitri"
        Me.TxtMa_Vitri.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vitri.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vitri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vitri.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_Vitri.TabIndex = 5
        Me.TxtMa_Vitri.Table_Name = ""
        '
        'TxtTen_vitri
        '
        Me.TxtTen_vitri.BackColor = System.Drawing.Color.White
        Me.TxtTen_vitri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_vitri.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_vitri.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_vitri.Location = New System.Drawing.Point(261, 122)
        Me.TxtTen_vitri.Name = "TxtTen_vitri"
        Me.TxtTen_vitri.ReadOnly = True
        Me.TxtTen_vitri.Size = New System.Drawing.Size(427, 14)
        Me.TxtTen_vitri.TabIndex = 297
        Me.TxtTen_vitri.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(4, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 18)
        Me.Label10.TabIndex = 299
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Năm"
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(119, 7)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(135, 21)
        Me.TxtNam.TabIndex = 0
        Me.TxtNam.TabStop = False
        '
        'TxtTen_Dvcs
        '
        Me.TxtTen_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Dvcs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Dvcs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Dvcs.Location = New System.Drawing.Point(261, 35)
        Me.TxtTen_Dvcs.Name = "TxtTen_Dvcs"
        Me.TxtTen_Dvcs.ReadOnly = True
        Me.TxtTen_Dvcs.Size = New System.Drawing.Size(427, 14)
        Me.TxtTen_Dvcs.TabIndex = 301
        Me.TxtTen_Dvcs.TabStop = False
        '
        'TxtMa_mau
        '
        Me.TxtMa_mau._ActilookupPopup = False
        Me.TxtMa_mau.CyberActilookupPopup = True
        Me.TxtMa_mau.Dv_ListDetail = Nothing
        Me.TxtMa_mau.Dv_Master = Nothing
        Me.TxtMa_mau.FilterClient = ""
        Me.TxtMa_mau.FilterSQL = ""
        Me.TxtMa_mau.Location = New System.Drawing.Point(119, 75)
        Me.TxtMa_mau.Name = "TxtMa_mau"
        Me.TxtMa_mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_mau.Size = New System.Drawing.Size(135, 20)
        Me.TxtMa_mau.TabIndex = 3
        Me.TxtMa_mau.Table_Name = ""
        '
        'TxtTen_mau
        '
        Me.TxtTen_mau.BackColor = System.Drawing.Color.White
        Me.TxtTen_mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_mau.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_mau.Location = New System.Drawing.Point(261, 78)
        Me.TxtTen_mau.Name = "TxtTen_mau"
        Me.TxtTen_mau.ReadOnly = True
        Me.TxtTen_mau.Size = New System.Drawing.Size(427, 14)
        Me.TxtTen_mau.TabIndex = 303
        Me.TxtTen_mau.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(4, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 18)
        Me.Label1.TabIndex = 304
        Me.Label1.Tag = "Colour"
        Me.Label1.Text = "Màu xe"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(3, 171)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 18)
        Me.Label4.TabIndex = 306
        Me.Label4.Tag = "Chassis number"
        Me.Label4.Text = "Số khung"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(3, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 18)
        Me.Label5.TabIndex = 308
        Me.Label5.Tag = "Car number"
        Me.Label5.Text = "Số máy"
        '
        'TxtSo_khung
        '
        Me.TxtSo_khung.Location = New System.Drawing.Point(119, 171)
        Me.TxtSo_khung.Name = "TxtSo_khung"
        Me.TxtSo_khung.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_khung.TabIndex = 7
        '
        'TxtSo_May
        '
        Me.TxtSo_May.Location = New System.Drawing.Point(119, 194)
        Me.TxtSo_May.Name = "TxtSo_May"
        Me.TxtSo_May.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_May.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(328, 194)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 18)
        Me.Label7.TabIndex = 310
        Me.Label7.Tag = "Year"
        Me.Label7.Text = "Năm sản xuất"
        '
        'TxtNam_SX
        '
        Me.TxtNam_SX.AllowNegative = True
        Me.TxtNam_SX.Flags = 7680
        Me.TxtNam_SX.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtNam_SX.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam_SX.InputMask = "### ### ### ### ###"
        Me.TxtNam_SX.Location = New System.Drawing.Point(444, 194)
        Me.TxtNam_SX.MaxWholeDigits = 14
        Me.TxtNam_SX.Name = "TxtNam_SX"
        Me.TxtNam_SX.RangeMax = 1.7976931348623157E+308R
        Me.TxtNam_SX.RangeMin = -1.7976931348623157E+308R
        Me.TxtNam_SX.Size = New System.Drawing.Size(135, 21)
        Me.TxtNam_SX.TabIndex = 9
        Me.TxtNam_SX.Tag = "### ### ### ### ###.##"
        Me.TxtNam_SX.Text = "0"
        Me.TxtNam_SX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSo_hang
        '
        Me.TxtSo_hang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_hang.Location = New System.Drawing.Point(119, 144)
        Me.TxtSo_hang.Name = "TxtSo_hang"
        Me.TxtSo_hang.Size = New System.Drawing.Size(135, 21)
        Me.TxtSo_hang.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(3, 144)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 18)
        Me.Label9.TabIndex = 312
        Me.Label9.Tag = "Number"
        Me.Label9.Text = "Số hãng"
        '
        'TxtNgay_Nhap
        '
        Me.TxtNgay_Nhap.Flags = 0
        Me.TxtNgay_Nhap.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Nhap.IsAllowResize = False
        Me.TxtNgay_Nhap.isEmpty = True
        Me.TxtNgay_Nhap.Location = New System.Drawing.Point(119, 218)
        Me.TxtNgay_Nhap.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Nhap.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Nhap.MaxLength = 10
        Me.TxtNgay_Nhap.Name = "TxtNgay_Nhap"
        Me.TxtNgay_Nhap.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Nhap.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Nhap.ShowDayBeforeMonth = False
        Me.TxtNgay_Nhap.Size = New System.Drawing.Size(135, 21)
        Me.TxtNgay_Nhap.TabIndex = 10
        Me.TxtNgay_Nhap.Text = "__/__/____"
        Me.TxtNgay_Nhap.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(3, 221)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 18)
        Me.Label13.TabIndex = 314
        Me.Label13.Tag = "Car number"
        Me.Label13.Text = "Ngày nhập mua"
        '
        'CDXE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(724, 336)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtNgay_Nhap)
        Me.Controls.Add(Me.TxtSo_hang)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtNam_SX)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtSo_May)
        Me.Controls.Add(Me.TxtSo_khung)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtMa_mau)
        Me.Controls.Add(Me.TxtTen_mau)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Dvcs)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtMa_Vitri)
        Me.Controls.Add(Me.TxtTen_vitri)
        Me.Controls.Add(Me.TxtMa_kx)
        Me.Controls.Add(Me.TxtTen_kx)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtDu00)
        Me.Controls.Add(Me.txtTon00)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabMa_CD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.TxtDu_NT00)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "CDXE"
        Me.Tb_Name = "Open"
        Me.Text = "Số dư đầu kỳ tài khoản"
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_NT00, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.LabMa_CD, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtTon00, 0)
        Me.Controls.SetChildIndex(Me.TxtDu00, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kx, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vitri, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vitri, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_mau, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_mau, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_khung, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_May, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtNam_SX, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_hang, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Nhap, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Vitri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDu_NT00 As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabMa_CD As System.Windows.Forms.Label
    Friend WithEvents TxtDu00 As ClsTextBox.txtTien_NT
    Friend WithEvents txtTon00 As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_kx As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_kx As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Vitri As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_vitri As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_mau As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_mau As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_khung As System.Windows.Forms.TextBox
    Friend WithEvents TxtSo_May As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtNam_SX As ClsTextBox.txtTien_NT
    Friend WithEvents TxtSo_hang As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Nhap As ClsTextBox.txtDate1
    Friend WithEvents Label13 As System.Windows.Forms.Label

End Class
