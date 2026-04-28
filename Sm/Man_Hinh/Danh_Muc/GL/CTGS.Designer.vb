<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTGS
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
        Me.LblTk = New System.Windows.Forms.Label()
        Me.TxtTen_TK = New System.Windows.Forms.TextBox()
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        Me.Txtten_DVCS = New System.Windows.Forms.TextBox()
        Me.CbbKieu = New System.Windows.Forms.ComboBox()
        Me.CbbNo_Co = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDien_giai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSo_Lo = New System.Windows.Forms.TextBox()
        Me.Lbghi_chu = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNgay_LO = New ClsTextBox.txtDate()
        Me.lbNgay_vv2 = New System.Windows.Forms.Label()
        Me.lbNgay_vv1 = New System.Windows.Forms.Label()
        Me.TxtNgay_CT1 = New ClsTextBox.txtDate()
        Me.TxtNgay_CT2 = New ClsTextBox.txtDate()
        Me.LabMa_Dvcs = New System.Windows.Forms.Label()
        Me.TxtRec_Gs = New System.Windows.Forms.TextBox()
        Me.TxtT_Tien_nt = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien = New ClsTextBox.txtTien_NT()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(909, 339)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(773, 339)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 13
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(147, 38)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(197, 24)
        Me.TxtMa_Dvcs.TabIndex = 0
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = True
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(147, 352)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 12
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 326)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1039, 9)
        '
        'LblTk
        '
        Me.LblTk.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LblTk.Location = New System.Drawing.Point(12, 133)
        Me.LblTk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTk.Name = "LblTk"
        Me.LblTk.Size = New System.Drawing.Size(127, 25)
        Me.LblTk.TabIndex = 42
        Me.LblTk.Tag = "Account"
        Me.LblTk.Text = "Tài khoản"
        '
        'TxtTen_TK
        '
        Me.TxtTen_TK.BackColor = System.Drawing.Color.White
        Me.TxtTen_TK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TK.Enabled = False
        Me.TxtTen_TK.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_TK.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK.Location = New System.Drawing.Point(351, 141)
        Me.TxtTen_TK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TK.Name = "TxtTen_TK"
        Me.TxtTen_TK.ReadOnly = True
        Me.TxtTen_TK.Size = New System.Drawing.Size(692, 17)
        Me.TxtTen_TK.TabIndex = 41
        Me.TxtTen_TK.TabStop = False
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(147, 133)
        Me.TxtTk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(199, 22)
        Me.TxtTk.TabIndex = 3
        Me.TxtTk.Table_Name = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(12, 12)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 25)
        Me.Label10.TabIndex = 272
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Năm"
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(147, 7)
        Me.TxtNam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(197, 24)
        Me.TxtNam.TabIndex = 271
        Me.TxtNam.TabStop = False
        '
        'Txtten_DVCS
        '
        Me.Txtten_DVCS.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_DVCS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_DVCS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtten_DVCS.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_DVCS.Location = New System.Drawing.Point(351, 42)
        Me.Txtten_DVCS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_DVCS.Name = "Txtten_DVCS"
        Me.Txtten_DVCS.ReadOnly = True
        Me.Txtten_DVCS.Size = New System.Drawing.Size(692, 17)
        Me.Txtten_DVCS.TabIndex = 273
        Me.Txtten_DVCS.TabStop = False
        '
        'CbbKieu
        '
        Me.CbbKieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbKieu.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CbbKieu.ForeColor = System.Drawing.Color.Navy
        Me.CbbKieu.FormattingEnabled = True
        Me.CbbKieu.Location = New System.Drawing.Point(147, 292)
        Me.CbbKieu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbKieu.Name = "CbbKieu"
        Me.CbbKieu.Size = New System.Drawing.Size(197, 25)
        Me.CbbKieu.TabIndex = 8
        '
        'CbbNo_Co
        '
        Me.CbbNo_Co.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbNo_Co.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CbbNo_Co.ForeColor = System.Drawing.Color.Navy
        Me.CbbNo_Co.FormattingEnabled = True
        Me.CbbNo_Co.Location = New System.Drawing.Point(147, 163)
        Me.CbbNo_Co.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbNo_Co.Name = "CbbNo_Co"
        Me.CbbNo_Co.Size = New System.Drawing.Size(197, 25)
        Me.CbbNo_Co.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(12, 296)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 25)
        Me.Label4.TabIndex = 320
        Me.Label4.Tag = "Filter "
        Me.Label4.Text = "Kiểu lọc"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(12, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(127, 25)
        Me.Label3.TabIndex = 319
        Me.Label3.Tag = "Debt/Credit"
        Me.Label3.Text = "Ghi Nợ/Có"
        '
        'TxtDien_giai
        '
        Me.TxtDien_giai.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtDien_giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_giai.Location = New System.Drawing.Point(147, 260)
        Me.TxtDien_giai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDien_giai.Name = "TxtDien_giai"
        Me.TxtDien_giai.Size = New System.Drawing.Size(895, 24)
        Me.TxtDien_giai.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(12, 264)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 25)
        Me.Label2.TabIndex = 318
        Me.Label2.Tag = "Note"
        Me.Label2.Text = "Diễn giải"
        '
        'TxtSo_Lo
        '
        Me.TxtSo_Lo.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_Lo.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Lo.Location = New System.Drawing.Point(147, 69)
        Me.TxtSo_Lo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSo_Lo.Name = "TxtSo_Lo"
        Me.TxtSo_Lo.Size = New System.Drawing.Size(197, 24)
        Me.TxtSo_Lo.TabIndex = 1
        '
        'Lbghi_chu
        '
        Me.Lbghi_chu.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Lbghi_chu.Location = New System.Drawing.Point(12, 73)
        Me.Lbghi_chu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbghi_chu.Name = "Lbghi_chu"
        Me.Lbghi_chu.Size = New System.Drawing.Size(127, 25)
        Me.Lbghi_chu.TabIndex = 317
        Me.Lbghi_chu.Tag = "Voucher No."
        Me.Lbghi_chu.Text = "Số CTGS"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 25)
        Me.Label1.TabIndex = 323
        Me.Label1.Tag = "Finish date"
        Me.Label1.Text = "Ngày CTGS"
        '
        'TxtNgay_LO
        '
        Me.TxtNgay_LO.Flags = 65536
        Me.TxtNgay_LO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_LO.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_LO.isEmpty = True
        Me.TxtNgay_LO.Location = New System.Drawing.Point(147, 101)
        Me.TxtNgay_LO.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNgay_LO.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_LO.MaxLength = 10
        Me.TxtNgay_LO.Name = "TxtNgay_LO"
        Me.TxtNgay_LO.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_LO.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_LO.ShowDayBeforeMonth = False
        Me.TxtNgay_LO.Size = New System.Drawing.Size(197, 24)
        Me.TxtNgay_LO.TabIndex = 2
        Me.TxtNgay_LO.Text = "26/07/2011"
        Me.TxtNgay_LO.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'lbNgay_vv2
        '
        Me.lbNgay_vv2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbNgay_vv2.ForeColor = System.Drawing.Color.Navy
        Me.lbNgay_vv2.Location = New System.Drawing.Point(12, 231)
        Me.lbNgay_vv2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgay_vv2.Name = "lbNgay_vv2"
        Me.lbNgay_vv2.Size = New System.Drawing.Size(127, 25)
        Me.lbNgay_vv2.TabIndex = 326
        Me.lbNgay_vv2.Tag = "Finish date"
        Me.lbNgay_vv2.Text = "Đến ngày"
        '
        'lbNgay_vv1
        '
        Me.lbNgay_vv1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbNgay_vv1.ForeColor = System.Drawing.Color.Navy
        Me.lbNgay_vv1.Location = New System.Drawing.Point(12, 203)
        Me.lbNgay_vv1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbNgay_vv1.Name = "lbNgay_vv1"
        Me.lbNgay_vv1.Size = New System.Drawing.Size(127, 25)
        Me.lbNgay_vv1.TabIndex = 325
        Me.lbNgay_vv1.Tag = "Start date"
        Me.lbNgay_vv1.Text = "Từ ngày"
        '
        'TxtNgay_CT1
        '
        Me.TxtNgay_CT1.Flags = 65536
        Me.TxtNgay_CT1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_CT1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_CT1.isEmpty = True
        Me.TxtNgay_CT1.Location = New System.Drawing.Point(147, 196)
        Me.TxtNgay_CT1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNgay_CT1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_CT1.MaxLength = 10
        Me.TxtNgay_CT1.Name = "TxtNgay_CT1"
        Me.TxtNgay_CT1.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_CT1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CT1.ShowDayBeforeMonth = False
        Me.TxtNgay_CT1.Size = New System.Drawing.Size(197, 24)
        Me.TxtNgay_CT1.TabIndex = 5
        Me.TxtNgay_CT1.Text = "26/07/2011"
        Me.TxtNgay_CT1.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'TxtNgay_CT2
        '
        Me.TxtNgay_CT2.Flags = 65536
        Me.TxtNgay_CT2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_CT2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_CT2.isEmpty = True
        Me.TxtNgay_CT2.Location = New System.Drawing.Point(147, 228)
        Me.TxtNgay_CT2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNgay_CT2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_CT2.MaxLength = 10
        Me.TxtNgay_CT2.Name = "TxtNgay_CT2"
        Me.TxtNgay_CT2.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_CT2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CT2.ShowDayBeforeMonth = False
        Me.TxtNgay_CT2.Size = New System.Drawing.Size(197, 24)
        Me.TxtNgay_CT2.TabIndex = 6
        Me.TxtNgay_CT2.Text = "26/07/2011"
        Me.TxtNgay_CT2.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'LabMa_Dvcs
        '
        Me.LabMa_Dvcs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_Dvcs.Location = New System.Drawing.Point(12, 43)
        Me.LabMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Dvcs.Name = "LabMa_Dvcs"
        Me.LabMa_Dvcs.Size = New System.Drawing.Size(127, 25)
        Me.LabMa_Dvcs.TabIndex = 329
        Me.LabMa_Dvcs.Tag = "Unit"
        Me.LabMa_Dvcs.Text = "Đơn vị"
        '
        'TxtRec_Gs
        '
        Me.TxtRec_Gs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtRec_Gs.ForeColor = System.Drawing.Color.Navy
        Me.TxtRec_Gs.Location = New System.Drawing.Point(728, 38)
        Me.TxtRec_Gs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtRec_Gs.Name = "TxtRec_Gs"
        Me.TxtRec_Gs.Size = New System.Drawing.Size(173, 24)
        Me.TxtRec_Gs.TabIndex = 9
        Me.TxtRec_Gs.WordWrap = False
        '
        'TxtT_Tien_nt
        '
        Me.TxtT_Tien_nt.AllowNegative = True
        Me.TxtT_Tien_nt.Flags = 7680
        Me.TxtT_Tien_nt.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_nt.InputMask = "### ### ###.###"
        Me.TxtT_Tien_nt.Location = New System.Drawing.Point(728, 103)
        Me.TxtT_Tien_nt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtT_Tien_nt.MaxWholeDigits = 12
        Me.TxtT_Tien_nt.Name = "TxtT_Tien_nt"
        Me.TxtT_Tien_nt.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_nt.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_nt.Size = New System.Drawing.Size(179, 24)
        Me.TxtT_Tien_nt.TabIndex = 11
        Me.TxtT_Tien_nt.Text = "1.000"
        Me.TxtT_Tien_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien_nt.Visible = False
        '
        'TxtT_Tien
        '
        Me.TxtT_Tien.AllowNegative = True
        Me.TxtT_Tien.Flags = 7680
        Me.TxtT_Tien.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien.InputMask = "### ### ###.###"
        Me.TxtT_Tien.Location = New System.Drawing.Point(728, 68)
        Me.TxtT_Tien.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtT_Tien.MaxWholeDigits = 12
        Me.TxtT_Tien.Name = "TxtT_Tien"
        Me.TxtT_Tien.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien.Size = New System.Drawing.Size(179, 24)
        Me.TxtT_Tien.TabIndex = 10
        Me.TxtT_Tien.Text = "1.000"
        Me.TxtT_Tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien.Visible = False
        '
        'CTGS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1045, 382)
        Me.Controls.Add(Me.TxtT_Tien_nt)
        Me.Controls.Add(Me.TxtT_Tien)
        Me.Controls.Add(Me.TxtRec_Gs)
        Me.Controls.Add(Me.LabMa_Dvcs)
        Me.Controls.Add(Me.TxtNgay_CT2)
        Me.Controls.Add(Me.TxtNgay_CT1)
        Me.Controls.Add(Me.lbNgay_vv2)
        Me.Controls.Add(Me.lbNgay_vv1)
        Me.Controls.Add(Me.TxtNgay_LO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbbKieu)
        Me.Controls.Add(Me.CbbNo_Co)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDien_giai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSo_Lo)
        Me.Controls.Add(Me.Lbghi_chu)
        Me.Controls.Add(Me.Txtten_DVCS)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.LblTk)
        Me.Controls.Add(Me.TxtTen_TK)
        Me.Controls.Add(Me.TxtTk)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "CTGS"
        Me.Text = "Danh mục khoản phí"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK, 0)
        Me.Controls.SetChildIndex(Me.LblTk, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Txtten_DVCS, 0)
        Me.Controls.SetChildIndex(Me.Lbghi_chu, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Lo, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_giai, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.CbbNo_Co, 0)
        Me.Controls.SetChildIndex(Me.CbbKieu, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_LO, 0)
        Me.Controls.SetChildIndex(Me.lbNgay_vv1, 0)
        Me.Controls.SetChildIndex(Me.lbNgay_vv2, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CT1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CT2, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtRec_Gs, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_nt, 0)
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblTk As System.Windows.Forms.Label
    Friend WithEvents TxtTen_TK As System.Windows.Forms.TextBox
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents Txtten_DVCS As System.Windows.Forms.TextBox
    Friend WithEvents CbbKieu As System.Windows.Forms.ComboBox
    Friend WithEvents CbbNo_Co As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_giai As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Lo As System.Windows.Forms.TextBox
    Friend WithEvents Lbghi_chu As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_LO As ClsTextBox.txtDate
    Friend WithEvents lbNgay_vv2 As System.Windows.Forms.Label
    Friend WithEvents lbNgay_vv1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_CT1 As ClsTextBox.txtDate
    Friend WithEvents TxtNgay_CT2 As ClsTextBox.txtDate
    Friend WithEvents LabMa_Dvcs As System.Windows.Forms.Label
    Friend WithEvents TxtRec_Gs As System.Windows.Forms.TextBox
    Friend WithEvents TxtT_Tien_nt As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien As ClsTextBox.txtTien_NT

End Class
