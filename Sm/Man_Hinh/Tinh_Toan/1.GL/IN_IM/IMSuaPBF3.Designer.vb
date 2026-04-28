<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSuaPBF3
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
        Me.ChkSua_PB = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtGt_PB = New ClsTextBox.txtTien_NT()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGt_CL = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtGt_Da_PB = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTien_NT = New ClsTextBox.txtTien_NT()
        Me.TxtSo_Ct_X = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTen_loai = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.txtSL_Xuat = New System.Windows.Forms.TextBox()
        Me.txtTen_Nx = New System.Windows.Forms.TextBox()
        Me.txtMa_Nx = New System.Windows.Forms.TextBox()
        Me.lbma_BPkd = New System.Windows.Forms.Label()
        Me.txtDVT = New System.Windows.Forms.TextBox()
        Me.lbMa_kh = New System.Windows.Forms.Label()
        Me.TxtTen_Cc = New System.Windows.Forms.TextBox()
        Me.TxtMa_Cc = New System.Windows.Forms.TextBox()
        Me.lbTen_CC = New System.Windows.Forms.Label()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.TxtTen_Cc2 = New System.Windows.Forms.TextBox()
        Me.lbTen_phi2 = New System.Windows.Forms.Label()
        Me.Stt_Rec0 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Tk_CP = New System.Windows.Forms.TextBox()
        Me.TxtTk_CP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDien_Giai_X = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNgay_Ct_X = New ClsTextBox.txtDate()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 352)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1113, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(847, 364)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(983, 364)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label9.Location = New System.Drawing.Point(416, 91)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(128, 20)
        Me.Label9.TabIndex = 361
        Me.Label9.Tag = "Quantity"
        Me.Label9.Text = "SL xuất sử dụng"
        '
        'ChkSua_PB
        '
        Me.ChkSua_PB.AutoSize = True
        Me.ChkSua_PB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ChkSua_PB.Location = New System.Drawing.Point(239, 212)
        Me.ChkSua_PB.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkSua_PB.Name = "ChkSua_PB"
        Me.ChkSua_PB.Size = New System.Drawing.Size(152, 22)
        Me.ChkSua_PB.TabIndex = 341
        Me.ChkSua_PB.Tag = "Edit attribution"
        Me.ChkSua_PB.Text = "Sửa giá trị phân bổ"
        Me.ChkSua_PB.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(16, 321)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(195, 20)
        Me.Label6.TabIndex = 360
        Me.Label6.Tag = "Distribution value this period"
        Me.Label6.Text = "Giá trị phân bổ kỳ này"
        '
        'TxtGt_PB
        '
        Me.TxtGt_PB.AllowNegative = True
        Me.TxtGt_PB.BackColor = System.Drawing.Color.White
        Me.TxtGt_PB.Flags = 7680
        Me.TxtGt_PB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtGt_PB.ForeColor = System.Drawing.Color.Navy
        Me.TxtGt_PB.InputMask = "## ### ### ### ###.#0"
        Me.TxtGt_PB.Location = New System.Drawing.Point(239, 321)
        Me.TxtGt_PB.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGt_PB.MaxWholeDigits = 16
        Me.TxtGt_PB.Name = "TxtGt_PB"
        Me.TxtGt_PB.RangeMax = 1.7976931348623157E+308R
        Me.TxtGt_PB.RangeMin = -1.7976931348623157E+308R
        Me.TxtGt_PB.Size = New System.Drawing.Size(172, 24)
        Me.TxtGt_PB.TabIndex = 345
        Me.TxtGt_PB.Text = "1.00"
        Me.TxtGt_PB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(16, 293)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 20)
        Me.Label4.TabIndex = 359
        Me.Label4.Tag = "Residual value"
        Me.Label4.Text = "Giá trị còn lại"
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
        Me.TxtGt_CL.Location = New System.Drawing.Point(239, 293)
        Me.TxtGt_CL.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGt_CL.MaxWholeDigits = 16
        Me.TxtGt_CL.Name = "TxtGt_CL"
        Me.TxtGt_CL.RangeMax = 1.7976931348623157E+308R
        Me.TxtGt_CL.RangeMin = -1.7976931348623157E+308R
        Me.TxtGt_CL.ReadOnly = True
        Me.TxtGt_CL.Size = New System.Drawing.Size(172, 24)
        Me.TxtGt_CL.TabIndex = 344
        Me.TxtGt_CL.Text = "1.00"
        Me.TxtGt_CL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(16, 265)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(195, 20)
        Me.Label3.TabIndex = 358
        Me.Label3.Tag = "Allocated value"
        Me.Label3.Text = "Giá trị đã phân bổ"
        '
        'TxtGt_Da_PB
        '
        Me.TxtGt_Da_PB.AllowNegative = True
        Me.TxtGt_Da_PB.BackColor = System.Drawing.SystemColors.Control
        Me.TxtGt_Da_PB.Enabled = False
        Me.TxtGt_Da_PB.Flags = 7680
        Me.TxtGt_Da_PB.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtGt_Da_PB.ForeColor = System.Drawing.Color.Navy
        Me.TxtGt_Da_PB.InputMask = "## ### ### ### ###.#0"
        Me.TxtGt_Da_PB.Location = New System.Drawing.Point(239, 265)
        Me.TxtGt_Da_PB.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGt_Da_PB.MaxWholeDigits = 16
        Me.TxtGt_Da_PB.Name = "TxtGt_Da_PB"
        Me.TxtGt_Da_PB.RangeMax = 1.7976931348623157E+308R
        Me.TxtGt_Da_PB.RangeMin = -1.7976931348623157E+308R
        Me.TxtGt_Da_PB.ReadOnly = True
        Me.TxtGt_Da_PB.Size = New System.Drawing.Size(172, 24)
        Me.TxtGt_Da_PB.TabIndex = 343
        Me.TxtGt_Da_PB.Text = "1.00"
        Me.TxtGt_Da_PB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 236)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 20)
        Me.Label2.TabIndex = 357
        Me.Label2.Tag = "Tool value"
        Me.Label2.Text = "Giá trị công cụ"
        '
        'TxtTien_NT
        '
        Me.TxtTien_NT.AllowNegative = True
        Me.TxtTien_NT.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTien_NT.Enabled = False
        Me.TxtTien_NT.Flags = 7680
        Me.TxtTien_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_NT.InputMask = "## ### ### ### ###.#0"
        Me.TxtTien_NT.Location = New System.Drawing.Point(239, 236)
        Me.TxtTien_NT.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTien_NT.MaxWholeDigits = 16
        Me.TxtTien_NT.Name = "TxtTien_NT"
        Me.TxtTien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_NT.ReadOnly = True
        Me.TxtTien_NT.Size = New System.Drawing.Size(172, 24)
        Me.TxtTien_NT.TabIndex = 342
        Me.TxtTien_NT.Text = "1.00"
        Me.TxtTien_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSo_Ct_X
        '
        Me.TxtSo_Ct_X.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtSo_Ct_X.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ct_X.Location = New System.Drawing.Point(976, 90)
        Me.TxtSo_Ct_X.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtSo_Ct_X.Name = "TxtSo_Ct_X"
        Me.TxtSo_Ct_X.ReadOnly = True
        Me.TxtSo_Ct_X.Size = New System.Drawing.Size(136, 24)
        Me.TxtSo_Ct_X.TabIndex = 340
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label8.Location = New System.Drawing.Point(869, 91)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 20)
        Me.Label8.TabIndex = 356
        Me.Label8.Tag = "Voucher No."
        Me.Label8.Text = "Số C.Từ xuất"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label7.Location = New System.Drawing.Point(652, 91)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 20)
        Me.Label7.TabIndex = 355
        Me.Label7.Tag = "Date"
        Me.Label7.Text = "Ngày xuất"
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
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(33, 433)
        Me.TxtStt_Rec.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.ReadOnly = True
        Me.TxtStt_Rec.Size = New System.Drawing.Size(117, 24)
        Me.TxtStt_Rec.TabIndex = 333
        Me.TxtStt_Rec.Visible = False
        '
        'txtSL_Xuat
        '
        Me.txtSL_Xuat.BackColor = System.Drawing.SystemColors.Control
        Me.txtSL_Xuat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtSL_Xuat.ForeColor = System.Drawing.Color.Navy
        Me.txtSL_Xuat.Location = New System.Drawing.Point(551, 90)
        Me.txtSL_Xuat.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSL_Xuat.Name = "txtSL_Xuat"
        Me.txtSL_Xuat.ReadOnly = True
        Me.txtSL_Xuat.Size = New System.Drawing.Size(93, 24)
        Me.txtSL_Xuat.TabIndex = 337
        Me.txtSL_Xuat.Text = "0"
        Me.txtSL_Xuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTen_Nx
        '
        Me.txtTen_Nx.BackColor = System.Drawing.SystemColors.Control
        Me.txtTen_Nx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_Nx.Enabled = False
        Me.txtTen_Nx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtTen_Nx.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Nx.Location = New System.Drawing.Point(420, 151)
        Me.txtTen_Nx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTen_Nx.Name = "txtTen_Nx"
        Me.txtTen_Nx.ReadOnly = True
        Me.txtTen_Nx.Size = New System.Drawing.Size(693, 17)
        Me.txtTen_Nx.TabIndex = 346
        Me.txtTen_Nx.TabStop = False
        '
        'txtMa_Nx
        '
        Me.txtMa_Nx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtMa_Nx.ForeColor = System.Drawing.Color.Navy
        Me.txtMa_Nx.Location = New System.Drawing.Point(239, 148)
        Me.txtMa_Nx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtMa_Nx.Name = "txtMa_Nx"
        Me.txtMa_Nx.ReadOnly = True
        Me.txtMa_Nx.Size = New System.Drawing.Size(172, 24)
        Me.txtMa_Nx.TabIndex = 339
        '
        'lbma_BPkd
        '
        Me.lbma_BPkd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbma_BPkd.Location = New System.Drawing.Point(16, 148)
        Me.lbma_BPkd.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbma_BPkd.Name = "lbma_BPkd"
        Me.lbma_BPkd.Size = New System.Drawing.Size(195, 20)
        Me.lbma_BPkd.TabIndex = 352
        Me.lbma_BPkd.Tag = "Acc allocation"
        Me.lbma_BPkd.Text = "Tài khoản phân bổ"
        '
        'txtDVT
        '
        Me.txtDVT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtDVT.ForeColor = System.Drawing.Color.Navy
        Me.txtDVT.Location = New System.Drawing.Point(239, 90)
        Me.txtDVT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDVT.Name = "txtDVT"
        Me.txtDVT.ReadOnly = True
        Me.txtDVT.Size = New System.Drawing.Size(172, 24)
        Me.txtDVT.TabIndex = 336
        '
        'lbMa_kh
        '
        Me.lbMa_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbMa_kh.Location = New System.Drawing.Point(16, 91)
        Me.lbMa_kh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMa_kh.Name = "lbMa_kh"
        Me.lbMa_kh.Size = New System.Drawing.Size(176, 20)
        Me.lbMa_kh.TabIndex = 351
        Me.lbMa_kh.Tag = "Unit"
        Me.lbMa_kh.Text = "Đơn vị tính"
        '
        'TxtTen_Cc
        '
        Me.TxtTen_Cc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTen_Cc.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cc.Location = New System.Drawing.Point(239, 32)
        Me.TxtTen_Cc.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Cc.Name = "TxtTen_Cc"
        Me.TxtTen_Cc.ReadOnly = True
        Me.TxtTen_Cc.Size = New System.Drawing.Size(873, 24)
        Me.TxtTen_Cc.TabIndex = 334
        '
        'TxtMa_Cc
        '
        Me.TxtMa_Cc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Cc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtMa_Cc.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cc.Location = New System.Drawing.Point(239, 4)
        Me.TxtMa_Cc.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Cc.Name = "TxtMa_Cc"
        Me.TxtMa_Cc.ReadOnly = True
        Me.TxtMa_Cc.Size = New System.Drawing.Size(172, 24)
        Me.TxtMa_Cc.TabIndex = 332
        '
        'lbTen_CC
        '
        Me.lbTen_CC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbTen_CC.Location = New System.Drawing.Point(13, 32)
        Me.lbTen_CC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTen_CC.Name = "lbTen_CC"
        Me.lbTen_CC.Size = New System.Drawing.Size(217, 20)
        Me.lbTen_CC.TabIndex = 350
        Me.lbTen_CC.Tag = "Name"
        Me.lbTen_CC.Text = "Tên công cụ"
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbMa_Phi.Location = New System.Drawing.Point(16, 7)
        Me.lbMa_Phi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(217, 20)
        Me.lbMa_Phi.TabIndex = 349
        Me.lbMa_Phi.Tag = "Tool"
        Me.lbMa_Phi.Text = "Mã công cụ"
        '
        'TxtTen_Cc2
        '
        Me.TxtTen_Cc2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTen_Cc2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cc2.Location = New System.Drawing.Point(239, 60)
        Me.TxtTen_Cc2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Cc2.Name = "TxtTen_Cc2"
        Me.TxtTen_Cc2.ReadOnly = True
        Me.TxtTen_Cc2.Size = New System.Drawing.Size(873, 24)
        Me.TxtTen_Cc2.TabIndex = 335
        '
        'lbTen_phi2
        '
        Me.lbTen_phi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbTen_phi2.Location = New System.Drawing.Point(16, 60)
        Me.lbTen_phi2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbTen_phi2.Name = "lbTen_phi2"
        Me.lbTen_phi2.Size = New System.Drawing.Size(217, 20)
        Me.lbTen_phi2.TabIndex = 348
        Me.lbTen_phi2.Tag = "English Name"
        Me.lbTen_phi2.Text = "Tên tiếng anh"
        '
        'Stt_Rec0
        '
        Me.Stt_Rec0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Stt_Rec0.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Stt_Rec0.ForeColor = System.Drawing.Color.Navy
        Me.Stt_Rec0.Location = New System.Drawing.Point(160, 433)
        Me.Stt_Rec0.Margin = New System.Windows.Forms.Padding(4)
        Me.Stt_Rec0.Name = "Stt_Rec0"
        Me.Stt_Rec0.ReadOnly = True
        Me.Stt_Rec0.Size = New System.Drawing.Size(117, 24)
        Me.Stt_Rec0.TabIndex = 362
        Me.Stt_Rec0.Visible = False
        '
        'TxtTen_Tk_CP
        '
        Me.TxtTen_Tk_CP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Tk_CP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Tk_CP.Enabled = False
        Me.TxtTen_Tk_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTen_Tk_CP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk_CP.Location = New System.Drawing.Point(420, 180)
        Me.TxtTen_Tk_CP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTen_Tk_CP.Name = "TxtTen_Tk_CP"
        Me.TxtTen_Tk_CP.ReadOnly = True
        Me.TxtTen_Tk_CP.Size = New System.Drawing.Size(693, 17)
        Me.TxtTen_Tk_CP.TabIndex = 364
        Me.TxtTen_Tk_CP.TabStop = False
        '
        'TxtTk_CP
        '
        Me.TxtTk_CP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTk_CP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_CP.Location = New System.Drawing.Point(239, 176)
        Me.TxtTk_CP.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTk_CP.Name = "TxtTk_CP"
        Me.TxtTk_CP.ReadOnly = True
        Me.TxtTk_CP.Size = New System.Drawing.Size(172, 24)
        Me.TxtTk_CP.TabIndex = 363
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 176)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 20)
        Me.Label1.TabIndex = 365
        Me.Label1.Tag = "Acc costs"
        Me.Label1.Text = "Tài khoản chi phí"
        '
        'TxtDien_Giai_X
        '
        Me.TxtDien_Giai_X.BackColor = System.Drawing.SystemColors.Control
        Me.TxtDien_Giai_X.Enabled = False
        Me.TxtDien_Giai_X.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai_X.Location = New System.Drawing.Point(239, 119)
        Me.TxtDien_Giai_X.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDien_Giai_X.Name = "TxtDien_Giai_X"
        Me.TxtDien_Giai_X.Size = New System.Drawing.Size(876, 22)
        Me.TxtDien_Giai_X.TabIndex = 366
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(16, 119)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(176, 20)
        Me.Label5.TabIndex = 367
        Me.Label5.Tag = "Explain"
        Me.Label5.Text = "Diễn giải"
        '
        'txtNgay_Ct_X
        '
        Me.txtNgay_Ct_X.BackColor = System.Drawing.SystemColors.Control
        Me.txtNgay_Ct_X.Enabled = False
        Me.txtNgay_Ct_X.Flags = 65536
        Me.txtNgay_Ct_X.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtNgay_Ct_X.ForeColor = System.Drawing.Color.Navy
        Me.txtNgay_Ct_X.isEmpty = True
        Me.txtNgay_Ct_X.Location = New System.Drawing.Point(741, 90)
        Me.txtNgay_Ct_X.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNgay_Ct_X.MaskDate = "dd/MM/yyyy"
        Me.txtNgay_Ct_X.MaxLength = 10
        Me.txtNgay_Ct_X.Name = "txtNgay_Ct_X"
        Me.txtNgay_Ct_X.RangeMax = New Date(9999, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_Ct_X.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_Ct_X.ShowDayBeforeMonth = False
        Me.txtNgay_Ct_X.Size = New System.Drawing.Size(125, 24)
        Me.txtNgay_Ct_X.TabIndex = 368
        Me.txtNgay_Ct_X.Text = "__/__/____"
        Me.txtNgay_Ct_X.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'IMSuaPBF3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1119, 431)
        Me.Controls.Add(Me.txtNgay_Ct_X)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDien_Giai_X)
        Me.Controls.Add(Me.TxtTen_Tk_CP)
        Me.Controls.Add(Me.TxtTk_CP)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Stt_Rec0)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ChkSua_PB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtGt_PB)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtGt_CL)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtGt_Da_PB)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTien_NT)
        Me.Controls.Add(Me.TxtSo_Ct_X)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTen_loai)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.txtSL_Xuat)
        Me.Controls.Add(Me.txtTen_Nx)
        Me.Controls.Add(Me.txtMa_Nx)
        Me.Controls.Add(Me.lbma_BPkd)
        Me.Controls.Add(Me.txtDVT)
        Me.Controls.Add(Me.lbMa_kh)
        Me.Controls.Add(Me.TxtTen_Cc)
        Me.Controls.Add(Me.TxtMa_Cc)
        Me.Controls.Add(Me.lbTen_CC)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.Controls.Add(Me.TxtTen_Cc2)
        Me.Controls.Add(Me.lbTen_phi2)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "IMSuaPBF3"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.lbTen_phi2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cc2, 0)
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.lbTen_CC, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cc, 0)
        Me.Controls.SetChildIndex(Me.lbMa_kh, 0)
        Me.Controls.SetChildIndex(Me.txtDVT, 0)
        Me.Controls.SetChildIndex(Me.lbma_BPkd, 0)
        Me.Controls.SetChildIndex(Me.txtMa_Nx, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Nx, 0)
        Me.Controls.SetChildIndex(Me.txtSL_Xuat, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_loai, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ct_X, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_NT, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtGt_Da_PB, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtGt_CL, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtGt_PB, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.ChkSua_PB, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Stt_Rec0, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_CP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk_CP, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai_X, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtNgay_Ct_X, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ChkSua_PB As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtGt_PB As ClsTextBox.txtTien_NT
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtGt_CL As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtGt_Da_PB As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtSo_Ct_X As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_loai As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents txtSL_Xuat As System.Windows.Forms.TextBox
    Friend WithEvents txtTen_Nx As System.Windows.Forms.TextBox
    Friend WithEvents txtMa_Nx As System.Windows.Forms.TextBox
    Friend WithEvents lbma_BPkd As System.Windows.Forms.Label
    Friend WithEvents txtDVT As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_kh As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Cc As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Cc As System.Windows.Forms.TextBox
    Friend WithEvents lbTen_CC As System.Windows.Forms.Label
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Cc2 As System.Windows.Forms.TextBox
    Friend WithEvents lbTen_phi2 As System.Windows.Forms.Label
    Friend WithEvents Stt_Rec0 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Tk_CP As System.Windows.Forms.TextBox
    Friend WithEvents TxtTk_CP As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Giai_X As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNgay_Ct_X As ClsTextBox.txtDate

End Class
