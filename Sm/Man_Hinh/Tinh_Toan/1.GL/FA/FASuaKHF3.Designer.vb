<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FASUAKHF3
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ChkSua_Kh = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtGt_kh = New ClsTextBox.txtTien_NT()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGt_CL = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtGt_Da_KH = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNguyen_Gia = New ClsTextBox.txtTien_NT()
        Me.TxtNuoc_Sx = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTen_loai = New System.Windows.Forms.TextBox()
        Me.TxtMa_Loai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSo_hieu_ts = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNam_Sx = New System.Windows.Forms.TextBox()
        Me.txtSo_luong = New System.Windows.Forms.TextBox()
        Me.txtTen_Tk_Ts = New System.Windows.Forms.TextBox()
        Me.txtTk_Ts = New System.Windows.Forms.TextBox()
        Me.lbma_BPkd = New System.Windows.Forms.Label()
        Me.txtDVT = New System.Windows.Forms.TextBox()
        Me.lbMa_kh = New System.Windows.Forms.Label()
        Me.TxtTen_ts = New System.Windows.Forms.TextBox()
        Me.Txtma_Ts = New System.Windows.Forms.TextBox()
        Me.lbTen_Nh = New System.Windows.Forms.Label()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.TxtTen_ts2 = New System.Windows.Forms.TextBox()
        Me.lbTen_phi2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 331)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1037, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(771, 343)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(907, 343)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(432, 122)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 25)
        Me.Label9.TabIndex = 361
        Me.Label9.Tag = "Quantity"
        Me.Label9.Text = "Số lượng"
        '
        'ChkSua_Kh
        '
        Me.ChkSua_Kh.AutoSize = True
        Me.ChkSua_Kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ChkSua_Kh.Location = New System.Drawing.Point(239, 182)
        Me.ChkSua_Kh.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkSua_Kh.Name = "ChkSua_Kh"
        Me.ChkSua_Kh.Size = New System.Drawing.Size(160, 22)
        Me.ChkSua_Kh.TabIndex = 341
        Me.ChkSua_Kh.Tag = "Adjust the depreciation value"
        Me.ChkSua_Kh.Text = "Sửa giá trị khấu hao"
        Me.ChkSua_Kh.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(16, 298)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 25)
        Me.Label6.TabIndex = 360
        Me.Label6.Tag = "Adjusted depreciation value"
        Me.Label6.Text = "GT khấu hao điều chỉnh"
        '
        'TxtGt_kh
        '
        Me.TxtGt_kh.AllowNegative = True
        Me.TxtGt_kh.BackColor = System.Drawing.Color.White
        Me.TxtGt_kh.Flags = 7680
        Me.TxtGt_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtGt_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtGt_kh.InputMask = "## ### ### ### ###.#0"
        Me.TxtGt_kh.Location = New System.Drawing.Point(239, 298)
        Me.TxtGt_kh.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGt_kh.MaxWholeDigits = 16
        Me.TxtGt_kh.Name = "TxtGt_kh"
        Me.TxtGt_kh.RangeMax = 1.7976931348623157E+308R
        Me.TxtGt_kh.RangeMin = -1.7976931348623157E+308R
        Me.TxtGt_kh.Size = New System.Drawing.Size(212, 24)
        Me.TxtGt_kh.TabIndex = 345
        Me.TxtGt_kh.Text = "1.00"
        Me.TxtGt_kh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(16, 270)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 25)
        Me.Label4.TabIndex = 359
        Me.Label4.Tag = "Residual value first month "
        Me.Label4.Text = "Gt còn lại đầu ngày"
        '
        'TxtGt_CL
        '
        Me.TxtGt_CL.AllowNegative = True
        Me.TxtGt_CL.BackColor = System.Drawing.SystemColors.Control
        Me.TxtGt_CL.Enabled = False
        Me.TxtGt_CL.Flags = 7680
        Me.TxtGt_CL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtGt_CL.ForeColor = System.Drawing.Color.Navy
        Me.TxtGt_CL.InputMask = "## ### ### ### ###.#0"
        Me.TxtGt_CL.Location = New System.Drawing.Point(239, 270)
        Me.TxtGt_CL.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGt_CL.MaxWholeDigits = 16
        Me.TxtGt_CL.Name = "TxtGt_CL"
        Me.TxtGt_CL.RangeMax = 1.7976931348623157E+308R
        Me.TxtGt_CL.RangeMin = -1.7976931348623157E+308R
        Me.TxtGt_CL.ReadOnly = True
        Me.TxtGt_CL.Size = New System.Drawing.Size(212, 24)
        Me.TxtGt_CL.TabIndex = 344
        Me.TxtGt_CL.Text = "1.00"
        Me.TxtGt_CL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(16, 241)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 25)
        Me.Label3.TabIndex = 358
        Me.Label3.Tag = "Depreciation in the first month"
        Me.Label3.Text = "Gt KH đến đầu ngày"
        '
        'TxtGt_Da_KH
        '
        Me.TxtGt_Da_KH.AllowNegative = True
        Me.TxtGt_Da_KH.BackColor = System.Drawing.SystemColors.Control
        Me.TxtGt_Da_KH.Enabled = False
        Me.TxtGt_Da_KH.Flags = 7680
        Me.TxtGt_Da_KH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtGt_Da_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtGt_Da_KH.InputMask = "## ### ### ### ###.#0"
        Me.TxtGt_Da_KH.Location = New System.Drawing.Point(239, 241)
        Me.TxtGt_Da_KH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGt_Da_KH.MaxWholeDigits = 16
        Me.TxtGt_Da_KH.Name = "TxtGt_Da_KH"
        Me.TxtGt_Da_KH.RangeMax = 1.7976931348623157E+308R
        Me.TxtGt_Da_KH.RangeMin = -1.7976931348623157E+308R
        Me.TxtGt_Da_KH.ReadOnly = True
        Me.TxtGt_Da_KH.Size = New System.Drawing.Size(212, 24)
        Me.TxtGt_Da_KH.TabIndex = 343
        Me.TxtGt_Da_KH.Text = "1.00"
        Me.TxtGt_Da_KH.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 213)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 25)
        Me.Label2.TabIndex = 357
        Me.Label2.Tag = "Original price"
        Me.Label2.Text = "Nguyên giá"
        '
        'TxtNguyen_Gia
        '
        Me.TxtNguyen_Gia.AllowNegative = True
        Me.TxtNguyen_Gia.BackColor = System.Drawing.SystemColors.Control
        Me.TxtNguyen_Gia.Enabled = False
        Me.TxtNguyen_Gia.Flags = 7680
        Me.TxtNguyen_Gia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtNguyen_Gia.ForeColor = System.Drawing.Color.Navy
        Me.TxtNguyen_Gia.InputMask = "## ### ### ### ###.#0"
        Me.TxtNguyen_Gia.Location = New System.Drawing.Point(239, 213)
        Me.TxtNguyen_Gia.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNguyen_Gia.MaxWholeDigits = 16
        Me.TxtNguyen_Gia.Name = "TxtNguyen_Gia"
        Me.TxtNguyen_Gia.RangeMax = 1.7976931348623157E+308R
        Me.TxtNguyen_Gia.RangeMin = -1.7976931348623157E+308R
        Me.TxtNguyen_Gia.ReadOnly = True
        Me.TxtNguyen_Gia.Size = New System.Drawing.Size(212, 24)
        Me.TxtNguyen_Gia.TabIndex = 342
        Me.TxtNguyen_Gia.Text = "1.00"
        Me.TxtNguyen_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNuoc_Sx
        '
        Me.TxtNuoc_Sx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtNuoc_Sx.ForeColor = System.Drawing.Color.Navy
        Me.TxtNuoc_Sx.Location = New System.Drawing.Point(893, 150)
        Me.TxtNuoc_Sx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNuoc_Sx.Name = "TxtNuoc_Sx"
        Me.TxtNuoc_Sx.ReadOnly = True
        Me.TxtNuoc_Sx.Size = New System.Drawing.Size(136, 24)
        Me.TxtNuoc_Sx.TabIndex = 340
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(747, 150)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(143, 25)
        Me.Label8.TabIndex = 356
        Me.Label8.Tag = "Production nation"
        Me.Label8.Text = "Nước sản xuất"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(747, 122)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 25)
        Me.Label7.TabIndex = 355
        Me.Label7.Tag = "Production year"
        Me.Label7.Text = "Năm sản xuất"
        '
        'TxtTen_loai
        '
        Me.TxtTen_loai.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_loai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_loai.Enabled = False
        Me.TxtTen_loai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTen_loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_loai.Location = New System.Drawing.Point(420, 12)
        Me.TxtTen_loai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_loai.Name = "TxtTen_loai"
        Me.TxtTen_loai.ReadOnly = True
        Me.TxtTen_loai.Size = New System.Drawing.Size(608, 17)
        Me.TxtTen_loai.TabIndex = 347
        Me.TxtTen_loai.TabStop = False
        '
        'TxtMa_Loai
        '
        Me.TxtMa_Loai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Loai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtMa_Loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Loai.Location = New System.Drawing.Point(239, 9)
        Me.TxtMa_Loai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Loai.Name = "TxtMa_Loai"
        Me.TxtMa_Loai.ReadOnly = True
        Me.TxtMa_Loai.Size = New System.Drawing.Size(172, 24)
        Me.TxtMa_Loai.TabIndex = 331
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(16, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 30)
        Me.Label5.TabIndex = 354
        Me.Label5.Tag = "Type Asset"
        Me.Label5.Text = "Loại tài sản"
        '
        'TxtSo_hieu_ts
        '
        Me.TxtSo_hieu_ts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_hieu_ts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtSo_hieu_ts.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_hieu_ts.Location = New System.Drawing.Point(776, 37)
        Me.TxtSo_hieu_ts.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSo_hieu_ts.Name = "TxtSo_hieu_ts"
        Me.TxtSo_hieu_ts.ReadOnly = True
        Me.TxtSo_hieu_ts.Size = New System.Drawing.Size(253, 24)
        Me.TxtSo_hieu_ts.TabIndex = 333
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(627, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 353
        Me.Label1.Tag = "Serial"
        Me.Label1.Text = "Số hiệu tài sản"
        '
        'TxtNam_Sx
        '
        Me.TxtNam_Sx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtNam_Sx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtNam_Sx.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam_Sx.Location = New System.Drawing.Point(893, 122)
        Me.TxtNam_Sx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtNam_Sx.Name = "TxtNam_Sx"
        Me.TxtNam_Sx.ReadOnly = True
        Me.TxtNam_Sx.Size = New System.Drawing.Size(136, 24)
        Me.TxtNam_Sx.TabIndex = 338
        Me.TxtNam_Sx.Text = "0"
        Me.TxtNam_Sx.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSo_luong
        '
        Me.txtSo_luong.BackColor = System.Drawing.SystemColors.Control
        Me.txtSo_luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtSo_luong.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_luong.Location = New System.Drawing.Point(593, 122)
        Me.txtSo_luong.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSo_luong.Name = "txtSo_luong"
        Me.txtSo_luong.ReadOnly = True
        Me.txtSo_luong.Size = New System.Drawing.Size(145, 24)
        Me.txtSo_luong.TabIndex = 337
        Me.txtSo_luong.Text = "0"
        Me.txtSo_luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTen_Tk_Ts
        '
        Me.txtTen_Tk_Ts.BackColor = System.Drawing.SystemColors.Control
        Me.txtTen_Tk_Ts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_Tk_Ts.Enabled = False
        Me.txtTen_Tk_Ts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtTen_Tk_Ts.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Tk_Ts.Location = New System.Drawing.Point(420, 154)
        Me.txtTen_Tk_Ts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTen_Tk_Ts.Name = "txtTen_Tk_Ts"
        Me.txtTen_Tk_Ts.ReadOnly = True
        Me.txtTen_Tk_Ts.Size = New System.Drawing.Size(608, 17)
        Me.txtTen_Tk_Ts.TabIndex = 346
        Me.txtTen_Tk_Ts.TabStop = False
        '
        'txtTk_Ts
        '
        Me.txtTk_Ts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtTk_Ts.ForeColor = System.Drawing.Color.Navy
        Me.txtTk_Ts.Location = New System.Drawing.Point(239, 150)
        Me.txtTk_Ts.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTk_Ts.Name = "txtTk_Ts"
        Me.txtTk_Ts.ReadOnly = True
        Me.txtTk_Ts.Size = New System.Drawing.Size(172, 24)
        Me.txtTk_Ts.TabIndex = 339
        '
        'lbma_BPkd
        '
        Me.lbma_BPkd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbma_BPkd.Location = New System.Drawing.Point(16, 150)
        Me.lbma_BPkd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbma_BPkd.Name = "lbma_BPkd"
        Me.lbma_BPkd.Size = New System.Drawing.Size(195, 25)
        Me.lbma_BPkd.TabIndex = 352
        Me.lbma_BPkd.Tag = "Account"
        Me.lbma_BPkd.Text = "Tài khoản tài sản"
        '
        'txtDVT
        '
        Me.txtDVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtDVT.ForeColor = System.Drawing.Color.Navy
        Me.txtDVT.Location = New System.Drawing.Point(239, 122)
        Me.txtDVT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDVT.Name = "txtDVT"
        Me.txtDVT.ReadOnly = True
        Me.txtDVT.Size = New System.Drawing.Size(172, 24)
        Me.txtDVT.TabIndex = 336
        '
        'lbMa_kh
        '
        Me.lbMa_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbMa_kh.Location = New System.Drawing.Point(16, 122)
        Me.lbMa_kh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMa_kh.Name = "lbMa_kh"
        Me.lbMa_kh.Size = New System.Drawing.Size(176, 25)
        Me.lbMa_kh.TabIndex = 351
        Me.lbMa_kh.Tag = "Unit"
        Me.lbMa_kh.Text = "Đơn vị tính"
        '
        'TxtTen_ts
        '
        Me.TxtTen_ts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTen_ts.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ts.Location = New System.Drawing.Point(239, 65)
        Me.TxtTen_ts.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_ts.Name = "TxtTen_ts"
        Me.TxtTen_ts.ReadOnly = True
        Me.TxtTen_ts.Size = New System.Drawing.Size(791, 24)
        Me.TxtTen_ts.TabIndex = 334
        '
        'Txtma_Ts
        '
        Me.Txtma_Ts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtma_Ts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Txtma_Ts.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_Ts.Location = New System.Drawing.Point(239, 37)
        Me.Txtma_Ts.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtma_Ts.Name = "Txtma_Ts"
        Me.Txtma_Ts.ReadOnly = True
        Me.Txtma_Ts.Size = New System.Drawing.Size(172, 24)
        Me.Txtma_Ts.TabIndex = 332
        '
        'lbTen_Nh
        '
        Me.lbTen_Nh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbTen_Nh.Location = New System.Drawing.Point(16, 65)
        Me.lbTen_Nh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTen_Nh.Name = "lbTen_Nh"
        Me.lbTen_Nh.Size = New System.Drawing.Size(217, 25)
        Me.lbTen_Nh.TabIndex = 350
        Me.lbTen_Nh.Tag = "Name "
        Me.lbTen_Nh.Text = "Tên tài sản"
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbMa_Phi.Location = New System.Drawing.Point(16, 37)
        Me.lbMa_Phi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(217, 25)
        Me.lbMa_Phi.TabIndex = 349
        Me.lbMa_Phi.Tag = "Asset"
        Me.lbMa_Phi.Text = "Tài sản"
        '
        'TxtTen_ts2
        '
        Me.TxtTen_ts2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTen_ts2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ts2.Location = New System.Drawing.Point(239, 94)
        Me.TxtTen_ts2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_ts2.Name = "TxtTen_ts2"
        Me.TxtTen_ts2.ReadOnly = True
        Me.TxtTen_ts2.Size = New System.Drawing.Size(791, 24)
        Me.TxtTen_ts2.TabIndex = 335
        '
        'lbTen_phi2
        '
        Me.lbTen_phi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbTen_phi2.Location = New System.Drawing.Point(16, 94)
        Me.lbTen_phi2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTen_phi2.Name = "lbTen_phi2"
        Me.lbTen_phi2.Size = New System.Drawing.Size(217, 25)
        Me.lbTen_phi2.TabIndex = 348
        Me.lbTen_phi2.Tag = "English Name"
        Me.lbTen_phi2.Text = "Tên tiếng anh"
        '
        'FASUAKHF3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1043, 410)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ChkSua_Kh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtGt_kh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtGt_CL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtGt_Da_KH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNguyen_Gia)
        Me.Controls.Add(Me.TxtNuoc_Sx)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTen_loai)
        Me.Controls.Add(Me.TxtMa_Loai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSo_hieu_ts)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNam_Sx)
        Me.Controls.Add(Me.txtSo_luong)
        Me.Controls.Add(Me.txtTen_Tk_Ts)
        Me.Controls.Add(Me.txtTk_Ts)
        Me.Controls.Add(Me.lbma_BPkd)
        Me.Controls.Add(Me.txtDVT)
        Me.Controls.Add(Me.lbMa_kh)
        Me.Controls.Add(Me.TxtTen_ts)
        Me.Controls.Add(Me.Txtma_Ts)
        Me.Controls.Add(Me.lbTen_Nh)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.Controls.Add(Me.TxtTen_ts2)
        Me.Controls.Add(Me.lbTen_phi2)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FASUAKHF3"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.lbTen_phi2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ts2, 0)
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.lbTen_Nh, 0)
        Me.Controls.SetChildIndex(Me.Txtma_Ts, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ts, 0)
        Me.Controls.SetChildIndex(Me.lbMa_kh, 0)
        Me.Controls.SetChildIndex(Me.txtDVT, 0)
        Me.Controls.SetChildIndex(Me.lbma_BPkd, 0)
        Me.Controls.SetChildIndex(Me.txtTk_Ts, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Tk_Ts, 0)
        Me.Controls.SetChildIndex(Me.txtSo_luong, 0)
        Me.Controls.SetChildIndex(Me.TxtNam_Sx, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_hieu_ts, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Loai, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_loai, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtNuoc_Sx, 0)
        Me.Controls.SetChildIndex(Me.TxtNguyen_Gia, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtGt_Da_KH, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtGt_CL, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtGt_kh, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.ChkSua_Kh, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ChkSua_Kh As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtGt_kh As ClsTextBox.txtTien_NT
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtGt_CL As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtGt_Da_KH As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtNguyen_Gia As ClsTextBox.txtTien_NT
    Friend WithEvents TxtNuoc_Sx As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_loai As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Loai As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_hieu_ts As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNam_Sx As System.Windows.Forms.TextBox
    Friend WithEvents txtSo_luong As System.Windows.Forms.TextBox
    Friend WithEvents txtTen_Tk_Ts As System.Windows.Forms.TextBox
    Friend WithEvents txtTk_Ts As System.Windows.Forms.TextBox
    Friend WithEvents lbma_BPkd As System.Windows.Forms.Label
    Friend WithEvents txtDVT As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_kh As System.Windows.Forms.Label
    Friend WithEvents TxtTen_ts As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_Ts As System.Windows.Forms.TextBox
    Friend WithEvents lbTen_Nh As System.Windows.Forms.Label
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents TxtTen_ts2 As System.Windows.Forms.TextBox
    Friend WithEvents lbTen_phi2 As System.Windows.Forms.Label

End Class
