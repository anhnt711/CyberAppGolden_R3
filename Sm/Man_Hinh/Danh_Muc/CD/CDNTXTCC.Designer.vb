<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDNTXTCC
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
        Me.TxtTien_NT = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabMa_CD = New System.Windows.Forms.Label()
        Me.TxtTien = New ClsTextBox.txtTien_NT()
        Me.TxtSo_Luong = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMa_cc = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_cc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtMa_Vitri = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_vitri = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtNgay_ct = New ClsTextBox.txtDate()
        Me.TxtSo_ct = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtTen_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec0 = New System.Windows.Forms.TextBox()
        Me.TxtMa_Ct = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_cc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Vitri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(829, 263)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(693, 263)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 13
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(187, 14)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(179, 24)
        Me.TxtMa_Dvcs.TabIndex = 0
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = True
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(187, 263)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 12
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(1, 250)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(960, 12)
        Me.GroupBoxLine.TabIndex = 11
        '
        'TxtTien_NT
        '
        Me.TxtTien_NT.AllowNegative = True
        Me.TxtTien_NT.Flags = 7680
        Me.TxtTien_NT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_NT.InputMask = "### ### ### ### ###"
        Me.TxtTien_NT.Location = New System.Drawing.Point(187, 222)
        Me.TxtTien_NT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTien_NT.MaxWholeDigits = 14
        Me.TxtTien_NT.Name = "TxtTien_NT"
        Me.TxtTien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_NT.Size = New System.Drawing.Size(179, 24)
        Me.TxtTien_NT.TabIndex = 8
        Me.TxtTien_NT.Tag = "### ### ### ### ###.##"
        Me.TxtTien_NT.Text = "0"
        Me.TxtTien_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(19, 225)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 24)
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
        Me.TxtTen_kho.Location = New System.Drawing.Point(380, 136)
        Me.TxtTen_kho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(569, 17)
        Me.TxtTen_kho.TabIndex = 260
        Me.TxtTen_kho.TabStop = False
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbMa_Phi.ForeColor = System.Drawing.Color.Navy
        Me.lbMa_Phi.Location = New System.Drawing.Point(19, 135)
        Me.lbMa_Phi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(133, 24)
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
        Me.TxtMa_kho.Location = New System.Drawing.Point(187, 132)
        Me.TxtMa_kho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_kho.TabIndex = 4
        Me.TxtMa_kho.Table_Name = ""
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(7, 269)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(625, 29)
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
        Me.Label8.Location = New System.Drawing.Point(19, 163)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 24)
        Me.Label8.TabIndex = 277
        Me.Label8.Tag = "Location"
        Me.Label8.Text = "Vị trí"
        '
        'LabMa_CD
        '
        Me.LabMa_CD.Location = New System.Drawing.Point(19, 50)
        Me.LabMa_CD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_CD.Name = "LabMa_CD"
        Me.LabMa_CD.Size = New System.Drawing.Size(133, 19)
        Me.LabMa_CD.TabIndex = 281
        Me.LabMa_CD.Tag = "Date voucher"
        Me.LabMa_CD.Text = "Ngày chứng từ"
        '
        'TxtTien
        '
        Me.TxtTien.AllowNegative = True
        Me.TxtTien.Flags = 7680
        Me.TxtTien.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTien.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien.InputMask = "### ### ### ### ###"
        Me.TxtTien.Location = New System.Drawing.Point(693, 222)
        Me.TxtTien.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTien.MaxWholeDigits = 14
        Me.TxtTien.Name = "TxtTien"
        Me.TxtTien.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien.Size = New System.Drawing.Size(179, 24)
        Me.TxtTien.TabIndex = 7
        Me.TxtTien.Tag = "### ### ### ### ###.##"
        Me.TxtTien.Text = "0"
        Me.TxtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTien.Visible = False
        '
        'TxtSo_Luong
        '
        Me.TxtSo_Luong.AllowNegative = True
        Me.TxtSo_Luong.Flags = 7680
        Me.TxtSo_Luong.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtSo_Luong.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Luong.InputMask = "### ### ### ### ###"
        Me.TxtSo_Luong.Location = New System.Drawing.Point(187, 190)
        Me.TxtSo_Luong.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSo_Luong.MaxWholeDigits = 14
        Me.TxtSo_Luong.Name = "TxtSo_Luong"
        Me.TxtSo_Luong.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Luong.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Luong.Size = New System.Drawing.Size(179, 24)
        Me.TxtSo_Luong.TabIndex = 6
        Me.TxtSo_Luong.Tag = "### ### ### ### ###.##"
        Me.TxtSo_Luong.Text = "0"
        Me.TxtSo_Luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(525, 220)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 27)
        Me.Label2.TabIndex = 287
        Me.Label2.Tag = "Opening balance(VND)"
        Me.Label2.Text = "Dư đầu kỳ (giá trị)"
        Me.Label2.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(19, 192)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 24)
        Me.Label6.TabIndex = 286
        Me.Label6.Tag = "Opening Stock"
        Me.Label6.Text = "Tồn đầu kỳ (số lượng)"
        '
        'TxtMa_cc
        '
        Me.TxtMa_cc._ActilookupPopup = False
        Me.TxtMa_cc.CyberActilookupPopup = True
        Me.TxtMa_cc.Dv_ListDetail = Nothing
        Me.TxtMa_cc.Dv_Master = Nothing
        Me.TxtMa_cc.FilterClient = ""
        Me.TxtMa_cc.FilterSQL = ""
        Me.TxtMa_cc.Location = New System.Drawing.Point(187, 103)
        Me.TxtMa_cc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_cc.Name = "TxtMa_cc"
        Me.TxtMa_cc.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_cc.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_cc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_cc.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_cc.TabIndex = 3
        Me.TxtMa_cc.Table_Name = ""
        '
        'TxtTen_cc
        '
        Me.TxtTen_cc.BackColor = System.Drawing.Color.White
        Me.TxtTen_cc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_cc.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_cc.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_cc.Location = New System.Drawing.Point(380, 107)
        Me.TxtTen_cc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_cc.Name = "TxtTen_cc"
        Me.TxtTen_cc.ReadOnly = True
        Me.TxtTen_cc.Size = New System.Drawing.Size(569, 17)
        Me.TxtTen_cc.TabIndex = 294
        Me.TxtTen_cc.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(19, 106)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 24)
        Me.Label11.TabIndex = 295
        Me.Label11.Tag = "Tools ID"
        Me.Label11.Text = "Công cụ"
        '
        'TxtMa_Vitri
        '
        Me.TxtMa_Vitri._ActilookupPopup = False
        Me.TxtMa_Vitri.CyberActilookupPopup = True
        Me.TxtMa_Vitri.Dv_ListDetail = Nothing
        Me.TxtMa_Vitri.Dv_Master = Nothing
        Me.TxtMa_Vitri.FilterClient = ""
        Me.TxtMa_Vitri.FilterSQL = ""
        Me.TxtMa_Vitri.Location = New System.Drawing.Point(187, 161)
        Me.TxtMa_Vitri.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Vitri.Name = "TxtMa_Vitri"
        Me.TxtMa_Vitri.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vitri.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vitri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vitri.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_Vitri.TabIndex = 5
        Me.TxtMa_Vitri.Table_Name = ""
        '
        'TxtTen_vitri
        '
        Me.TxtTen_vitri.BackColor = System.Drawing.Color.White
        Me.TxtTen_vitri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_vitri.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_vitri.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_vitri.Location = New System.Drawing.Point(380, 165)
        Me.TxtTen_vitri.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_vitri.Name = "TxtTen_vitri"
        Me.TxtTen_vitri.ReadOnly = True
        Me.TxtTen_vitri.Size = New System.Drawing.Size(569, 17)
        Me.TxtTen_vitri.TabIndex = 297
        Me.TxtTen_vitri.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(19, 17)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 24)
        Me.Label10.TabIndex = 299
        Me.Label10.Tag = "Code"
        Me.Label10.Text = "Mã hạch toán"
        '
        'txtNgay_ct
        '
        Me.txtNgay_ct.Flags = 65536
        Me.txtNgay_ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtNgay_ct.ForeColor = System.Drawing.Color.Navy
        Me.txtNgay_ct.isEmpty = True
        Me.txtNgay_ct.Location = New System.Drawing.Point(187, 44)
        Me.txtNgay_ct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNgay_ct.MaskDate = "dd/MM/yyyy"
        Me.txtNgay_ct.MaxLength = 10
        Me.txtNgay_ct.Name = "txtNgay_ct"
        Me.txtNgay_ct.RangeMax = New Date(9999, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_ct.ShowDayBeforeMonth = False
        Me.txtNgay_ct.Size = New System.Drawing.Size(179, 24)
        Me.txtNgay_ct.TabIndex = 1
        Me.txtNgay_ct.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtSo_ct
        '
        Me.TxtSo_ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_ct.Location = New System.Drawing.Point(187, 75)
        Me.TxtSo_ct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSo_ct.Name = "TxtSo_ct"
        Me.TxtSo_ct.Size = New System.Drawing.Size(179, 24)
        Me.TxtSo_ct.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(19, 77)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 24)
        Me.Label1.TabIndex = 303
        Me.Label1.Tag = "Voucher No."
        Me.Label1.Text = "Số chứng từ"
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(667, 77)
        Me.TxtNam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(179, 24)
        Me.TxtNam.TabIndex = 305
        Me.TxtNam.TabStop = False
        Me.TxtNam.Visible = False
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(524, 80)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 22)
        Me.Label14.TabIndex = 304
        Me.Label14.Tag = "Year"
        Me.Label14.Text = "Năm"
        Me.Label14.Visible = False
        '
        'TxtTen_Dvcs
        '
        Me.TxtTen_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Dvcs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Dvcs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Dvcs.Location = New System.Drawing.Point(380, 16)
        Me.TxtTen_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Dvcs.Name = "TxtTen_Dvcs"
        Me.TxtTen_Dvcs.ReadOnly = True
        Me.TxtTen_Dvcs.Size = New System.Drawing.Size(569, 17)
        Me.TxtTen_Dvcs.TabIndex = 306
        Me.TxtTen_Dvcs.TabStop = False
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(583, 307)
        Me.TxtStt_Rec.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.ReadOnly = True
        Me.TxtStt_Rec.Size = New System.Drawing.Size(101, 24)
        Me.TxtStt_Rec.TabIndex = 307
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Visible = False
        '
        'TxtStt_Rec0
        '
        Me.TxtStt_Rec0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec0.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec0.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtStt_Rec0.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec0.Location = New System.Drawing.Point(467, 269)
        Me.TxtStt_Rec0.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtStt_Rec0.Name = "TxtStt_Rec0"
        Me.TxtStt_Rec0.ReadOnly = True
        Me.TxtStt_Rec0.Size = New System.Drawing.Size(93, 24)
        Me.TxtStt_Rec0.TabIndex = 310
        Me.TxtStt_Rec0.TabStop = False
        Me.TxtStt_Rec0.Visible = False
        '
        'TxtMa_Ct
        '
        Me.TxtMa_Ct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Ct.Location = New System.Drawing.Point(412, 269)
        Me.TxtMa_Ct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Ct.Name = "TxtMa_Ct"
        Me.TxtMa_Ct.ReadOnly = True
        Me.TxtMa_Ct.Size = New System.Drawing.Size(116, 24)
        Me.TxtMa_Ct.TabIndex = 311
        Me.TxtMa_Ct.TabStop = False
        Me.TxtMa_Ct.Visible = False
        '
        'CDNTXTCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(965, 306)
        Me.Controls.Add(Me.TxtMa_Ct)
        Me.Controls.Add(Me.TxtStt_Rec0)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtTen_Dvcs)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtSo_ct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNgay_ct)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtMa_Vitri)
        Me.Controls.Add(Me.TxtTen_vitri)
        Me.Controls.Add(Me.TxtMa_cc)
        Me.Controls.Add(Me.TxtTen_cc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtTien)
        Me.Controls.Add(Me.TxtSo_Luong)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabMa_CD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.TxtTien_NT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "CDNTXTCC"
        Me.Tb_Name = "Open"
        Me.Text = "Số dư đầu kỳ tài khoản"
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.LabMa_CD, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Luong, 0)
        Me.Controls.SetChildIndex(Me.TxtTien, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_cc, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_cc, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vitri, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vitri, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txtNgay_ct, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_ct, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec0, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Ct, 0)
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_cc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Vitri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabMa_CD As System.Windows.Forms.Label
    Friend WithEvents TxtTien As ClsTextBox.txtTien_NT
    Friend WithEvents TxtSo_Luong As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_cc As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_cc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Vitri As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_vitri As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNgay_ct As ClsTextBox.txtDate
    Friend WithEvents TxtSo_ct As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec0 As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Ct As System.Windows.Forms.TextBox

End Class
