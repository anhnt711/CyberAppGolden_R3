<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTiep_Don_Dat_Cho
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
        Me.TxtLocation = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTG_SC = New ClsTextBox.txtTien_NT()
        Me.TxtNgay_KT = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_BD = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.lblStartTime = New DevExpress.XtraEditors.LabelControl()
        Me.lblEndTime = New DevExpress.XtraEditors.LabelControl()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtLoai_SC_Luu = New System.Windows.Forms.TextBox()
        Me.TxtTinh_Trang = New System.Windows.Forms.TextBox()
        Me.TxtMa_Ct = New System.Windows.Forms.TextBox()
        Me.TxtMa_Bp = New System.Windows.Forms.TextBox()
        Me.TxtLoai = New System.Windows.Forms.TextBox()
        Me.TxtResourceID = New System.Windows.Forms.TextBox()
        Me.TxtStatus = New System.Windows.Forms.TextBox()
        Me.txtRecurrenceInfo = New System.Windows.Forms.TextBox()
        Me.TxtType = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.CbbXe_UT = New System.Windows.Forms.ComboBox()
        Me.TxtTen_Lx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDt_Lx = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbMa_Cvdv = New System.Windows.Forms.ComboBox()
        Me.ChkSCC = New System.Windows.Forms.CheckBox()
        Me.ChkSBD = New System.Windows.Forms.CheckBox()
        Me.ChkSDS = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 258)
        Me.GroupBoxLine.Size = New System.Drawing.Size(760, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(560, 268)
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(662, 268)
        Me.ButtExit.TabIndex = 8
        '
        'TxtLocation
        '
        Me.TxtLocation.BackColor = System.Drawing.Color.White
        Me.TxtLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLocation.ForeColor = System.Drawing.Color.Navy
        Me.TxtLocation.Location = New System.Drawing.Point(19, 160)
        Me.TxtLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLocation.Multiline = True
        Me.TxtLocation.Name = "TxtLocation"
        Me.TxtLocation.Size = New System.Drawing.Size(730, 98)
        Me.TxtLocation.TabIndex = 6
        Me.TxtLocation.TabStop = False
        Me.TxtLocation.Tag = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(15, 136)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 20)
        Me.Label9.TabIndex = 2045
        Me.Label9.Tag = ""
        Me.Label9.Text = "Diễn giải"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(15, 103)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 20)
        Me.Label8.TabIndex = 2044
        Me.Label8.Tag = ""
        Me.Label8.Text = "Thời gian"
        '
        'TxtTG_SC
        '
        Me.TxtTG_SC.AllowNegative = True
        Me.TxtTG_SC.BackColor = System.Drawing.Color.White
        Me.TxtTG_SC.Flags = 7680
        Me.TxtTG_SC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTG_SC.ForeColor = System.Drawing.Color.Navy
        Me.TxtTG_SC.InputMask = "### ### ### ### ### ###"
        Me.TxtTG_SC.Location = New System.Drawing.Point(101, 100)
        Me.TxtTG_SC.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTG_SC.MaxWholeDigits = 17
        Me.TxtTG_SC.Name = "TxtTG_SC"
        Me.TxtTG_SC.RangeMax = 1.7976931348623157E+308R
        Me.TxtTG_SC.RangeMin = -1.7976931348623157E+308R
        Me.TxtTG_SC.Size = New System.Drawing.Size(137, 26)
        Me.TxtTG_SC.TabIndex = 3
        Me.TxtTG_SC.Text = "0"
        Me.TxtTG_SC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNgay_KT
        '
        Me.TxtNgay_KT.Flags = 0
        Me.TxtNgay_KT.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtNgay_KT.IsAllowResize = False
        Me.TxtNgay_KT.Location = New System.Drawing.Point(317, 127)
        Me.TxtNgay_KT.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT.MaxLength = 10
        Me.TxtNgay_KT.Name = "TxtNgay_KT"
        Me.TxtNgay_KT.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT.ShowDayBeforeMonth = False
        Me.TxtNgay_KT.Size = New System.Drawing.Size(188, 26)
        Me.TxtNgay_KT.TabIndex = 5
        Me.TxtNgay_KT.Value = "05/04/2019 15:06"
        '
        'TxtNgay_BD
        '
        Me.TxtNgay_BD.Flags = 0
        Me.TxtNgay_BD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TxtNgay_BD.IsAllowResize = False
        Me.TxtNgay_BD.Location = New System.Drawing.Point(317, 100)
        Me.TxtNgay_BD.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD.MaxLength = 10
        Me.TxtNgay_BD.Name = "TxtNgay_BD"
        Me.TxtNgay_BD.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD.ShowDayBeforeMonth = False
        Me.TxtNgay_BD.Size = New System.Drawing.Size(188, 26)
        Me.TxtNgay_BD.TabIndex = 4
        Me.TxtNgay_BD.Value = "05/04/2019 15:06"
        '
        'lblStartTime
        '
        Me.lblStartTime.AccessibleName = "Start time"
        Me.lblStartTime.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartTime.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lblStartTime.Appearance.Options.UseFont = True
        Me.lblStartTime.Appearance.Options.UseForeColor = True
        Me.lblStartTime.Location = New System.Drawing.Point(242, 102)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(56, 20)
        Me.lblStartTime.TabIndex = 2042
        Me.lblStartTime.Text = "Bắt đầu"
        '
        'lblEndTime
        '
        Me.lblEndTime.AccessibleName = "End time"
        Me.lblEndTime.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndTime.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.lblEndTime.Appearance.Options.UseFont = True
        Me.lblEndTime.Appearance.Options.UseForeColor = True
        Me.lblEndTime.Location = New System.Drawing.Point(242, 131)
        Me.lblEndTime.Name = "lblEndTime"
        Me.lblEndTime.Size = New System.Drawing.Size(59, 20)
        Me.lblEndTime.TabIndex = 2043
        Me.lblEndTime.Text = "&Kết thúc"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(242, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 2041
        Me.Label3.Tag = "Advisor"
        Me.Label3.Text = "CVDV"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(101, 4)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(137, 26)
        Me.TxtMa_Xe.TabIndex = 0
        Me.TxtMa_Xe.TabStop = False
        Me.TxtMa_Xe.Tag = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(15, 8)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 18)
        Me.Label4.TabIndex = 2039
        Me.Label4.Tag = "Type (R/O)"
        Me.Label4.Text = "Biển số"
        '
        'TxtLoai_SC_Luu
        '
        Me.TxtLoai_SC_Luu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtLoai_SC_Luu.BackColor = System.Drawing.Color.Lavender
        Me.TxtLoai_SC_Luu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLoai_SC_Luu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLoai_SC_Luu.ForeColor = System.Drawing.Color.Blue
        Me.TxtLoai_SC_Luu.Location = New System.Drawing.Point(558, 265)
        Me.TxtLoai_SC_Luu.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLoai_SC_Luu.Name = "TxtLoai_SC_Luu"
        Me.TxtLoai_SC_Luu.ReadOnly = True
        Me.TxtLoai_SC_Luu.Size = New System.Drawing.Size(39, 26)
        Me.TxtLoai_SC_Luu.TabIndex = 7
        Me.TxtLoai_SC_Luu.TabStop = False
        Me.TxtLoai_SC_Luu.Tag = ""
        Me.TxtLoai_SC_Luu.Visible = False
        '
        'TxtTinh_Trang
        '
        Me.TxtTinh_Trang.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTinh_Trang.BackColor = System.Drawing.Color.Lavender
        Me.TxtTinh_Trang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTinh_Trang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTinh_Trang.ForeColor = System.Drawing.Color.Blue
        Me.TxtTinh_Trang.Location = New System.Drawing.Point(509, 267)
        Me.TxtTinh_Trang.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTinh_Trang.Name = "TxtTinh_Trang"
        Me.TxtTinh_Trang.ReadOnly = True
        Me.TxtTinh_Trang.Size = New System.Drawing.Size(41, 26)
        Me.TxtTinh_Trang.TabIndex = 2057
        Me.TxtTinh_Trang.TabStop = False
        Me.TxtTinh_Trang.Tag = ""
        Me.TxtTinh_Trang.Visible = False
        '
        'TxtMa_Ct
        '
        Me.TxtMa_Ct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Ct.BackColor = System.Drawing.Color.Lavender
        Me.TxtMa_Ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Ct.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Ct.Location = New System.Drawing.Point(92, 269)
        Me.TxtMa_Ct.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Ct.Name = "TxtMa_Ct"
        Me.TxtMa_Ct.ReadOnly = True
        Me.TxtMa_Ct.Size = New System.Drawing.Size(37, 26)
        Me.TxtMa_Ct.TabIndex = 2056
        Me.TxtMa_Ct.TabStop = False
        Me.TxtMa_Ct.Tag = ""
        Me.TxtMa_Ct.Visible = False
        '
        'TxtMa_Bp
        '
        Me.TxtMa_Bp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Bp.BackColor = System.Drawing.Color.Lavender
        Me.TxtMa_Bp.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Bp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Bp.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Bp.Location = New System.Drawing.Point(362, 270)
        Me.TxtMa_Bp.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Bp.Name = "TxtMa_Bp"
        Me.TxtMa_Bp.ReadOnly = True
        Me.TxtMa_Bp.Size = New System.Drawing.Size(40, 26)
        Me.TxtMa_Bp.TabIndex = 2053
        Me.TxtMa_Bp.TabStop = False
        Me.TxtMa_Bp.Tag = ""
        Me.TxtMa_Bp.Visible = False
        '
        'TxtLoai
        '
        Me.TxtLoai.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtLoai.BackColor = System.Drawing.Color.Lavender
        Me.TxtLoai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLoai.ForeColor = System.Drawing.Color.Blue
        Me.TxtLoai.Location = New System.Drawing.Point(317, 270)
        Me.TxtLoai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLoai.Name = "TxtLoai"
        Me.TxtLoai.ReadOnly = True
        Me.TxtLoai.Size = New System.Drawing.Size(37, 26)
        Me.TxtLoai.TabIndex = 2052
        Me.TxtLoai.TabStop = False
        Me.TxtLoai.Tag = ""
        Me.TxtLoai.Visible = False
        '
        'TxtResourceID
        '
        Me.TxtResourceID.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtResourceID.BackColor = System.Drawing.Color.Lavender
        Me.TxtResourceID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtResourceID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtResourceID.ForeColor = System.Drawing.Color.Blue
        Me.TxtResourceID.Location = New System.Drawing.Point(272, 269)
        Me.TxtResourceID.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtResourceID.Name = "TxtResourceID"
        Me.TxtResourceID.ReadOnly = True
        Me.TxtResourceID.Size = New System.Drawing.Size(37, 26)
        Me.TxtResourceID.TabIndex = 2051
        Me.TxtResourceID.TabStop = False
        Me.TxtResourceID.Tag = ""
        Me.TxtResourceID.Visible = False
        '
        'TxtStatus
        '
        Me.TxtStatus.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtStatus.BackColor = System.Drawing.Color.Lavender
        Me.TxtStatus.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStatus.ForeColor = System.Drawing.Color.Blue
        Me.TxtStatus.Location = New System.Drawing.Point(227, 270)
        Me.TxtStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStatus.Name = "TxtStatus"
        Me.TxtStatus.ReadOnly = True
        Me.TxtStatus.Size = New System.Drawing.Size(37, 26)
        Me.TxtStatus.TabIndex = 2050
        Me.TxtStatus.TabStop = False
        Me.TxtStatus.Tag = ""
        Me.TxtStatus.Visible = False
        '
        'txtRecurrenceInfo
        '
        Me.txtRecurrenceInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtRecurrenceInfo.BackColor = System.Drawing.Color.Lavender
        Me.txtRecurrenceInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRecurrenceInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecurrenceInfo.ForeColor = System.Drawing.Color.Blue
        Me.txtRecurrenceInfo.Location = New System.Drawing.Point(182, 270)
        Me.txtRecurrenceInfo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRecurrenceInfo.Name = "txtRecurrenceInfo"
        Me.txtRecurrenceInfo.ReadOnly = True
        Me.txtRecurrenceInfo.Size = New System.Drawing.Size(37, 26)
        Me.txtRecurrenceInfo.TabIndex = 2049
        Me.txtRecurrenceInfo.TabStop = False
        Me.txtRecurrenceInfo.Tag = ""
        Me.txtRecurrenceInfo.Visible = False
        '
        'TxtType
        '
        Me.TxtType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtType.BackColor = System.Drawing.Color.Lavender
        Me.TxtType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtType.ForeColor = System.Drawing.Color.Blue
        Me.TxtType.Location = New System.Drawing.Point(137, 269)
        Me.TxtType.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtType.Name = "TxtType"
        Me.TxtType.ReadOnly = True
        Me.TxtType.Size = New System.Drawing.Size(37, 26)
        Me.TxtType.TabIndex = 2048
        Me.TxtType.TabStop = False
        Me.TxtType.Tag = ""
        Me.TxtType.Visible = False
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.Lavender
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Blue
        Me.TxtStt_Rec.Location = New System.Drawing.Point(57, 264)
        Me.TxtStt_Rec.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.ReadOnly = True
        Me.TxtStt_Rec.Size = New System.Drawing.Size(27, 26)
        Me.TxtStt_Rec.TabIndex = 2047
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Tag = ""
        Me.TxtStt_Rec.Visible = False
        '
        'CbbXe_UT
        '
        Me.CbbXe_UT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbXe_UT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbXe_UT.ForeColor = System.Drawing.Color.Navy
        Me.CbbXe_UT.FormattingEnabled = True
        Me.CbbXe_UT.Location = New System.Drawing.Point(525, 4)
        Me.CbbXe_UT.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbXe_UT.Name = "CbbXe_UT"
        Me.CbbXe_UT.Size = New System.Drawing.Size(222, 24)
        Me.CbbXe_UT.TabIndex = 9
        '
        'TxtTen_Lx
        '
        Me.TxtTen_Lx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Lx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTen_Lx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_Lx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Lx.Location = New System.Drawing.Point(101, 34)
        Me.TxtTen_Lx.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Lx.Name = "TxtTen_Lx"
        Me.TxtTen_Lx.Size = New System.Drawing.Size(404, 26)
        Me.TxtTen_Lx.TabIndex = 1
        Me.TxtTen_Lx.TabStop = False
        Me.TxtTen_Lx.Tag = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(15, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 18)
        Me.Label1.TabIndex = 2061
        Me.Label1.Tag = "Type (R/O)"
        Me.Label1.Text = "Lái xe"
        '
        'TxtDt_Lx
        '
        Me.TxtDt_Lx.BackColor = System.Drawing.Color.White
        Me.TxtDt_Lx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDt_Lx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDt_Lx.ForeColor = System.Drawing.Color.Navy
        Me.TxtDt_Lx.Location = New System.Drawing.Point(101, 65)
        Me.TxtDt_Lx.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDt_Lx.Name = "TxtDt_Lx"
        Me.TxtDt_Lx.Size = New System.Drawing.Size(404, 26)
        Me.TxtDt_Lx.TabIndex = 2
        Me.TxtDt_Lx.TabStop = False
        Me.TxtDt_Lx.Tag = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(15, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 18)
        Me.Label2.TabIndex = 2063
        Me.Label2.Tag = "Type (R/O)"
        Me.Label2.Text = "Điện thoại"
        '
        'CbbMa_Cvdv
        '
        Me.CbbMa_Cvdv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Cvdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_Cvdv.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Cvdv.FormattingEnabled = True
        Me.CbbMa_Cvdv.Location = New System.Drawing.Point(302, 4)
        Me.CbbMa_Cvdv.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_Cvdv.Name = "CbbMa_Cvdv"
        Me.CbbMa_Cvdv.Size = New System.Drawing.Size(203, 24)
        Me.CbbMa_Cvdv.TabIndex = 2064
        '
        'ChkSCC
        '
        Me.ChkSCC.AutoSize = True
        Me.ChkSCC.Location = New System.Drawing.Point(525, 41)
        Me.ChkSCC.Name = "ChkSCC"
        Me.ChkSCC.Size = New System.Drawing.Size(105, 17)
        Me.ChkSCC.TabIndex = 2065
        Me.ChkSCC.Text = "Sửa chữa chung"
        Me.ChkSCC.UseVisualStyleBackColor = True
        '
        'ChkSBD
        '
        Me.ChkSBD.AutoSize = True
        Me.ChkSBD.Location = New System.Drawing.Point(525, 71)
        Me.ChkSBD.Name = "ChkSBD"
        Me.ChkSBD.Size = New System.Drawing.Size(111, 17)
        Me.ChkSBD.TabIndex = 2066
        Me.ChkSBD.Text = "Bảo dưỡng nhanh"
        Me.ChkSBD.UseVisualStyleBackColor = True
        '
        'ChkSDS
        '
        Me.ChkSDS.AutoSize = True
        Me.ChkSDS.Location = New System.Drawing.Point(525, 100)
        Me.ChkSDS.Name = "ChkSDS"
        Me.ChkSDS.Size = New System.Drawing.Size(120, 17)
        Me.ChkSDS.TabIndex = 2067
        Me.ChkSDS.Text = "Sửa chữa đồng sơn"
        Me.ChkSDS.UseVisualStyleBackColor = True
        '
        'FTiep_Don_Dat_Cho
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(764, 322)
        Me.Controls.Add(Me.ChkSDS)
        Me.Controls.Add(Me.ChkSBD)
        Me.Controls.Add(Me.ChkSCC)
        Me.Controls.Add(Me.CbbMa_Cvdv)
        Me.Controls.Add(Me.TxtDt_Lx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Lx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbbXe_UT)
        Me.Controls.Add(Me.TxtLoai_SC_Luu)
        Me.Controls.Add(Me.TxtTinh_Trang)
        Me.Controls.Add(Me.TxtMa_Ct)
        Me.Controls.Add(Me.TxtMa_Bp)
        Me.Controls.Add(Me.TxtLoai)
        Me.Controls.Add(Me.TxtResourceID)
        Me.Controls.Add(Me.TxtStatus)
        Me.Controls.Add(Me.txtRecurrenceInfo)
        Me.Controls.Add(Me.TxtType)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtLocation)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTG_SC)
        Me.Controls.Add(Me.TxtNgay_KT)
        Me.Controls.Add(Me.TxtNgay_BD)
        Me.Controls.Add(Me.lblStartTime)
        Me.Controls.Add(Me.lblEndTime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FTiep_Don_Dat_Cho"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.lblEndTime, 0)
        Me.Controls.SetChildIndex(Me.lblStartTime, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT, 0)
        Me.Controls.SetChildIndex(Me.TxtTG_SC, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtLocation, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtType, 0)
        Me.Controls.SetChildIndex(Me.txtRecurrenceInfo, 0)
        Me.Controls.SetChildIndex(Me.TxtStatus, 0)
        Me.Controls.SetChildIndex(Me.TxtResourceID, 0)
        Me.Controls.SetChildIndex(Me.TxtLoai, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtTinh_Trang, 0)
        Me.Controls.SetChildIndex(Me.TxtLoai_SC_Luu, 0)
        Me.Controls.SetChildIndex(Me.CbbXe_UT, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Lx, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtDt_Lx, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Cvdv, 0)
        Me.Controls.SetChildIndex(Me.ChkSCC, 0)
        Me.Controls.SetChildIndex(Me.ChkSBD, 0)
        Me.Controls.SetChildIndex(Me.ChkSDS, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTG_SC As ClsTextBox.txtTien_NT
    Friend WithEvents TxtNgay_KT As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_BD As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents lblStartTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblEndTime As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtLoai_SC_Luu As System.Windows.Forms.TextBox
    Friend WithEvents TxtTinh_Trang As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Ct As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Bp As System.Windows.Forms.TextBox
    Friend WithEvents TxtLoai As System.Windows.Forms.TextBox
    Friend WithEvents TxtResourceID As System.Windows.Forms.TextBox
    Friend WithEvents TxtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtRecurrenceInfo As System.Windows.Forms.TextBox
    Friend WithEvents TxtType As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents CbbXe_UT As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTen_Lx As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDt_Lx As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_Cvdv As System.Windows.Forms.ComboBox
    Friend WithEvents ChkSCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSBD As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSDS As System.Windows.Forms.CheckBox

End Class
