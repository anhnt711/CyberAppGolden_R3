<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCW_F34
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
        Me.CbbMa_khoang = New System.Windows.Forms.ComboBox()
        Me.ChkDat_them = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabSo_RO = New System.Windows.Forms.Label()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.TxtNgay_henKT_RO = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNgay_KT_RO = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_BD_RO = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNgay_Ct = New System.Windows.Forms.Label()
        Me.TxtNgay_KT = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_BD = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTG_SC = New ClsTextBox.txtTien_NT()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Ct = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.TxtKh_Theo = New System.Windows.Forms.TextBox()
        Me.ChkKet_Thuc = New System.Windows.Forms.CheckBox()
        Me.TxtNgay_KT_TH = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_BD_TH = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.LabMa_Xe = New System.Windows.Forms.Label()
        Me.ChkQua_Ban = New System.Windows.Forms.CheckBox()
        Me.TxtLoai_SC = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 231)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(618, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(419, 241)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 10
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(521, 241)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 11
        '
        'CbbMa_khoang
        '
        Me.CbbMa_khoang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_khoang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_khoang.ForeColor = System.Drawing.Color.Blue
        Me.CbbMa_khoang.FormattingEnabled = True
        Me.CbbMa_khoang.Location = New System.Drawing.Point(93, 128)
        Me.CbbMa_khoang.Name = "CbbMa_khoang"
        Me.CbbMa_khoang.Size = New System.Drawing.Size(155, 24)
        Me.CbbMa_khoang.TabIndex = 6
        '
        'ChkDat_them
        '
        Me.ChkDat_them.AutoSize = True
        Me.ChkDat_them.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDat_them.ForeColor = System.Drawing.Color.Blue
        Me.ChkDat_them.Location = New System.Drawing.Point(93, 5)
        Me.ChkDat_them.Name = "ChkDat_them"
        Me.ChkDat_them.Size = New System.Drawing.Size(144, 20)
        Me.ChkDat_them.TabIndex = 0
        Me.ChkDat_them.TabStop = False
        Me.ChkDat_them.Tag = "Add planning"
        Me.ChkDat_them.Text = "Tạo thêm KH rửa xe"
        Me.ChkDat_them.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(5, 132)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 7063
        Me.Label8.Tag = "Cabin"
        Me.Label8.Text = "Khoang"
        '
        'LabSo_RO
        '
        Me.LabSo_RO.AutoSize = True
        Me.LabSo_RO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabSo_RO.ForeColor = System.Drawing.Color.Blue
        Me.LabSo_RO.Location = New System.Drawing.Point(263, 30)
        Me.LabSo_RO.Margin = New System.Windows.Forms.Padding(0)
        Me.LabSo_RO.Name = "LabSo_RO"
        Me.LabSo_RO.Size = New System.Drawing.Size(56, 17)
        Me.LabSo_RO.TabIndex = 7068
        Me.LabSo_RO.Tag = "R/O"
        Me.LabSo_RO.Text = "Số lệnh"
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_Ro.Location = New System.Drawing.Point(367, 28)
        Me.TxtSo_Ro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(155, 23)
        Me.TxtSo_Ro.TabIndex = 1
        Me.TxtSo_Ro.Tag = ""
        Me.TxtSo_Ro.Text = "01.S15000001"
        Me.TxtSo_Ro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Xe.Location = New System.Drawing.Point(93, 28)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(155, 23)
        Me.TxtMa_Xe.TabIndex = 2
        Me.TxtMa_Xe.Tag = ""
        '
        'TxtNgay_henKT_RO
        '
        Me.TxtNgay_henKT_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_henKT_RO.Enabled = False
        Me.TxtNgay_henKT_RO.Flags = 0
        Me.TxtNgay_henKT_RO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_henKT_RO.ForeColor = System.Drawing.Color.Blue
        Me.TxtNgay_henKT_RO.IsAllowResize = False
        Me.TxtNgay_henKT_RO.Location = New System.Drawing.Point(367, 76)
        Me.TxtNgay_henKT_RO.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_henKT_RO.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_henKT_RO.MaxLength = 10
        Me.TxtNgay_henKT_RO.Name = "TxtNgay_henKT_RO"
        Me.TxtNgay_henKT_RO.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_henKT_RO.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_henKT_RO.ReadOnly = True
        Me.TxtNgay_henKT_RO.ShowDayBeforeMonth = False
        Me.TxtNgay_henKT_RO.Size = New System.Drawing.Size(155, 23)
        Me.TxtNgay_henKT_RO.TabIndex = 5
        Me.TxtNgay_henKT_RO.TabStop = False
        Me.TxtNgay_henKT_RO.Value = "05/05/2020 11:28"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(263, 79)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 7139
        Me.Label10.Tag = "Delivered"
        Me.Label10.Text = "Giao xe"
        '
        'TxtNgay_KT_RO
        '
        Me.TxtNgay_KT_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_KT_RO.Enabled = False
        Me.TxtNgay_KT_RO.Flags = 0
        Me.TxtNgay_KT_RO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT_RO.ForeColor = System.Drawing.Color.Blue
        Me.TxtNgay_KT_RO.IsAllowResize = False
        Me.TxtNgay_KT_RO.Location = New System.Drawing.Point(93, 79)
        Me.TxtNgay_KT_RO.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT_RO.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT_RO.MaxLength = 10
        Me.TxtNgay_KT_RO.Name = "TxtNgay_KT_RO"
        Me.TxtNgay_KT_RO.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT_RO.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT_RO.ReadOnly = True
        Me.TxtNgay_KT_RO.ShowDayBeforeMonth = False
        Me.TxtNgay_KT_RO.Size = New System.Drawing.Size(155, 23)
        Me.TxtNgay_KT_RO.TabIndex = 4
        Me.TxtNgay_KT_RO.TabStop = False
        Me.TxtNgay_KT_RO.Value = "05/05/2020 11:28"
        '
        'TxtNgay_BD_RO
        '
        Me.TxtNgay_BD_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_BD_RO.Enabled = False
        Me.TxtNgay_BD_RO.Flags = 0
        Me.TxtNgay_BD_RO.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD_RO.ForeColor = System.Drawing.Color.Blue
        Me.TxtNgay_BD_RO.IsAllowResize = False
        Me.TxtNgay_BD_RO.Location = New System.Drawing.Point(93, 53)
        Me.TxtNgay_BD_RO.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD_RO.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD_RO.MaxLength = 10
        Me.TxtNgay_BD_RO.Name = "TxtNgay_BD_RO"
        Me.TxtNgay_BD_RO.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD_RO.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD_RO.ReadOnly = True
        Me.TxtNgay_BD_RO.ShowDayBeforeMonth = False
        Me.TxtNgay_BD_RO.Size = New System.Drawing.Size(155, 23)
        Me.TxtNgay_BD_RO.TabIndex = 3
        Me.TxtNgay_BD_RO.TabStop = False
        Me.TxtNgay_BD_RO.Value = "05/05/2020 11:28"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(5, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 7136
        Me.Label1.Tag = "Finish"
        Me.Label1.Text = "Sửa xong"
        '
        'LblNgay_Ct
        '
        Me.LblNgay_Ct.AutoSize = True
        Me.LblNgay_Ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNgay_Ct.ForeColor = System.Drawing.Color.Blue
        Me.LblNgay_Ct.Location = New System.Drawing.Point(5, 56)
        Me.LblNgay_Ct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNgay_Ct.Name = "LblNgay_Ct"
        Me.LblNgay_Ct.Size = New System.Drawing.Size(57, 17)
        Me.LblNgay_Ct.TabIndex = 7135
        Me.LblNgay_Ct.Tag = "Begin"
        Me.LblNgay_Ct.Text = "Bắt đầu"
        '
        'TxtNgay_KT
        '
        Me.TxtNgay_KT.BackColor = System.Drawing.Color.White
        Me.TxtNgay_KT.Flags = 0
        Me.TxtNgay_KT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_KT.IsAllowResize = False
        Me.TxtNgay_KT.Location = New System.Drawing.Point(93, 206)
        Me.TxtNgay_KT.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT.MaxLength = 10
        Me.TxtNgay_KT.Name = "TxtNgay_KT"
        Me.TxtNgay_KT.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT.ShowDayBeforeMonth = False
        Me.TxtNgay_KT.Size = New System.Drawing.Size(155, 23)
        Me.TxtNgay_KT.TabIndex = 9
        Me.TxtNgay_KT.Value = "05/05/2020 11:28"
        '
        'TxtNgay_BD
        '
        Me.TxtNgay_BD.BackColor = System.Drawing.Color.White
        Me.TxtNgay_BD.Flags = 0
        Me.TxtNgay_BD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_BD.IsAllowResize = False
        Me.TxtNgay_BD.Location = New System.Drawing.Point(93, 180)
        Me.TxtNgay_BD.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD.MaxLength = 10
        Me.TxtNgay_BD.Name = "TxtNgay_BD"
        Me.TxtNgay_BD.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD.ShowDayBeforeMonth = False
        Me.TxtNgay_BD.Size = New System.Drawing.Size(155, 23)
        Me.TxtNgay_BD.TabIndex = 8
        Me.TxtNgay_BD.Value = "05/05/2020 11:28"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(5, 185)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 17)
        Me.Label15.TabIndex = 7143
        Me.Label15.Tag = "Begin"
        Me.Label15.Text = "Bắt đầu"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(5, 208)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 17)
        Me.Label16.TabIndex = 7144
        Me.Label16.Tag = "End"
        Me.Label16.Text = "Kết thúc"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(5, 158)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 7147
        Me.Label13.Tag = "Time"
        Me.Label13.Text = "Thời gian"
        '
        'TxtTG_SC
        '
        Me.TxtTG_SC.AllowNegative = True
        Me.TxtTG_SC.BackColor = System.Drawing.Color.White
        Me.TxtTG_SC.Flags = 7680
        Me.TxtTG_SC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTG_SC.ForeColor = System.Drawing.Color.Blue
        Me.TxtTG_SC.InputMask = "### ### ### ### ### ###"
        Me.TxtTG_SC.Location = New System.Drawing.Point(93, 154)
        Me.TxtTG_SC.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTG_SC.MaxWholeDigits = 17
        Me.TxtTG_SC.Name = "TxtTG_SC"
        Me.TxtTG_SC.RangeMax = 1.7976931348623157E+308R
        Me.TxtTG_SC.RangeMin = -1.7976931348623157E+308R
        Me.TxtTG_SC.Size = New System.Drawing.Size(155, 23)
        Me.TxtTG_SC.TabIndex = 7
        Me.TxtTG_SC.Text = "0"
        Me.TxtTG_SC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(44, 244)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(45, 21)
        Me.TxtMa_Dvcs.TabIndex = 7148
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Tag = ""
        Me.TxtMa_Dvcs.Visible = False
        '
        'TxtMa_Ct
        '
        Me.TxtMa_Ct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Ct.BackColor = System.Drawing.Color.White
        Me.TxtMa_Ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtMa_Ct.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Ct.Location = New System.Drawing.Point(97, 244)
        Me.TxtMa_Ct.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Ct.Name = "TxtMa_Ct"
        Me.TxtMa_Ct.Size = New System.Drawing.Size(45, 21)
        Me.TxtMa_Ct.TabIndex = 7149
        Me.TxtMa_Ct.TabStop = False
        Me.TxtMa_Ct.Tag = ""
        Me.TxtMa_Ct.Visible = False
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Blue
        Me.TxtStt_Rec.Location = New System.Drawing.Point(150, 244)
        Me.TxtStt_Rec.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(45, 21)
        Me.TxtStt_Rec.TabIndex = 7150
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Tag = ""
        Me.TxtStt_Rec.Visible = False
        '
        'TxtKh_Theo
        '
        Me.TxtKh_Theo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtKh_Theo.BackColor = System.Drawing.Color.White
        Me.TxtKh_Theo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtKh_Theo.ForeColor = System.Drawing.Color.Blue
        Me.TxtKh_Theo.Location = New System.Drawing.Point(200, 245)
        Me.TxtKh_Theo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtKh_Theo.Name = "TxtKh_Theo"
        Me.TxtKh_Theo.Size = New System.Drawing.Size(45, 21)
        Me.TxtKh_Theo.TabIndex = 7151
        Me.TxtKh_Theo.TabStop = False
        Me.TxtKh_Theo.Tag = ""
        Me.TxtKh_Theo.Visible = False
        '
        'ChkKet_Thuc
        '
        Me.ChkKet_Thuc.AutoSize = True
        Me.ChkKet_Thuc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkKet_Thuc.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkKet_Thuc.Location = New System.Drawing.Point(252, 322)
        Me.ChkKet_Thuc.Name = "ChkKet_Thuc"
        Me.ChkKet_Thuc.Size = New System.Drawing.Size(66, 17)
        Me.ChkKet_Thuc.TabIndex = 7152
        Me.ChkKet_Thuc.TabStop = False
        Me.ChkKet_Thuc.Tag = "Tel, time"
        Me.ChkKet_Thuc.Text = "Kết thúc"
        Me.ChkKet_Thuc.UseVisualStyleBackColor = True
        Me.ChkKet_Thuc.Visible = False
        '
        'TxtNgay_KT_TH
        '
        Me.TxtNgay_KT_TH.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNgay_KT_TH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_KT_TH.Enabled = False
        Me.TxtNgay_KT_TH.Flags = 0
        Me.TxtNgay_KT_TH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT_TH.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_KT_TH.IsAllowResize = False
        Me.TxtNgay_KT_TH.Location = New System.Drawing.Point(318, 241)
        Me.TxtNgay_KT_TH.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT_TH.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT_TH.MaxLength = 10
        Me.TxtNgay_KT_TH.Name = "TxtNgay_KT_TH"
        Me.TxtNgay_KT_TH.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT_TH.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT_TH.ReadOnly = True
        Me.TxtNgay_KT_TH.ShowDayBeforeMonth = False
        Me.TxtNgay_KT_TH.Size = New System.Drawing.Size(82, 21)
        Me.TxtNgay_KT_TH.TabIndex = 7154
        Me.TxtNgay_KT_TH.Value = "05/05/2020 11:28"
        Me.TxtNgay_KT_TH.Visible = False
        '
        'TxtNgay_BD_TH
        '
        Me.TxtNgay_BD_TH.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNgay_BD_TH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_BD_TH.Enabled = False
        Me.TxtNgay_BD_TH.Flags = 0
        Me.TxtNgay_BD_TH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD_TH.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_BD_TH.IsAllowResize = False
        Me.TxtNgay_BD_TH.Location = New System.Drawing.Point(236, 245)
        Me.TxtNgay_BD_TH.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD_TH.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD_TH.MaxLength = 10
        Me.TxtNgay_BD_TH.Name = "TxtNgay_BD_TH"
        Me.TxtNgay_BD_TH.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD_TH.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD_TH.ReadOnly = True
        Me.TxtNgay_BD_TH.ShowDayBeforeMonth = False
        Me.TxtNgay_BD_TH.Size = New System.Drawing.Size(82, 22)
        Me.TxtNgay_BD_TH.TabIndex = 7153
        Me.TxtNgay_BD_TH.Value = "05/05/2020 11:28"
        Me.TxtNgay_BD_TH.Visible = False
        '
        'LabMa_Xe
        '
        Me.LabMa_Xe.AutoSize = True
        Me.LabMa_Xe.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_Xe.ForeColor = System.Drawing.Color.Blue
        Me.LabMa_Xe.Location = New System.Drawing.Point(5, 30)
        Me.LabMa_Xe.Name = "LabMa_Xe"
        Me.LabMa_Xe.Size = New System.Drawing.Size(55, 17)
        Me.LabMa_Xe.TabIndex = 7155
        Me.LabMa_Xe.Tag = "Plate"
        Me.LabMa_Xe.Text = "Biển số"
        '
        'ChkQua_Ban
        '
        Me.ChkQua_Ban.AutoSize = True
        Me.ChkQua_Ban.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkQua_Ban.ForeColor = System.Drawing.Color.Red
        Me.ChkQua_Ban.Location = New System.Drawing.Point(367, 132)
        Me.ChkQua_Ban.Name = "ChkQua_Ban"
        Me.ChkQua_Ban.Size = New System.Drawing.Size(100, 21)
        Me.ChkQua_Ban.TabIndex = 7156
        Me.ChkQua_Ban.TabStop = False
        Me.ChkQua_Ban.Tag = "Tel, time"
        Me.ChkQua_Ban.Text = "Xe quá bẩn"
        Me.ChkQua_Ban.UseVisualStyleBackColor = True
        '
        'TxtLoai_SC
        '
        Me.TxtLoai_SC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtLoai_SC.BackColor = System.Drawing.Color.White
        Me.TxtLoai_SC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtLoai_SC.ForeColor = System.Drawing.Color.Blue
        Me.TxtLoai_SC.Location = New System.Drawing.Point(338, 252)
        Me.TxtLoai_SC.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLoai_SC.Name = "TxtLoai_SC"
        Me.TxtLoai_SC.Size = New System.Drawing.Size(45, 21)
        Me.TxtLoai_SC.TabIndex = 7157
        Me.TxtLoai_SC.TabStop = False
        Me.TxtLoai_SC.Tag = ""
        Me.TxtLoai_SC.Visible = False
        '
        'FrmCW_F34
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(623, 295)
        Me.Controls.Add(Me.TxtLoai_SC)
        Me.Controls.Add(Me.ChkQua_Ban)
        Me.Controls.Add(Me.LabMa_Xe)
        Me.Controls.Add(Me.TxtNgay_KT_TH)
        Me.Controls.Add(Me.TxtNgay_BD_TH)
        Me.Controls.Add(Me.ChkKet_Thuc)
        Me.Controls.Add(Me.TxtKh_Theo)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Ct)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtTG_SC)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtNgay_KT)
        Me.Controls.Add(Me.TxtNgay_BD)
        Me.Controls.Add(Me.TxtNgay_henKT_RO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNgay_KT_RO)
        Me.Controls.Add(Me.TxtNgay_BD_RO)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblNgay_Ct)
        Me.Controls.Add(Me.LabSo_RO)
        Me.Controls.Add(Me.TxtSo_Ro)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.CbbMa_khoang)
        Me.Controls.Add(Me.ChkDat_them)
        Me.Controls.Add(Me.Label8)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmCW_F34"
        Me.Text = "KH Rua xe"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.ChkDat_them, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_khoang, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.LabSo_RO, 0)
        Me.Controls.SetChildIndex(Me.LblNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT_RO, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_henKT_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.TxtTG_SC, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtKh_Theo, 0)
        Me.Controls.SetChildIndex(Me.ChkKet_Thuc, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD_TH, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT_TH, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.ChkQua_Ban, 0)
        Me.Controls.SetChildIndex(Me.TxtLoai_SC, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbMa_khoang As System.Windows.Forms.ComboBox
    Friend WithEvents ChkDat_them As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabSo_RO As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ro As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents TxtNgay_henKT_RO As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_KT_RO As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_BD_RO As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_KT As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_BD As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtTG_SC As ClsTextBox.txtTien_NT
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Ct As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents TxtKh_Theo As System.Windows.Forms.TextBox
    Friend WithEvents ChkKet_Thuc As System.Windows.Forms.CheckBox
    Friend WithEvents TxtNgay_KT_TH As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_BD_TH As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents LabMa_Xe As System.Windows.Forms.Label
    Friend WithEvents ChkQua_Ban As System.Windows.Forms.CheckBox
    Friend WithEvents TxtLoai_SC As System.Windows.Forms.TextBox

End Class
