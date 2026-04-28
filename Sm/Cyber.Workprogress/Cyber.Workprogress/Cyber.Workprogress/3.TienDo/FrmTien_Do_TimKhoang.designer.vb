<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTien_Do_TimKhoang
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
        Me.components = New System.ComponentModel.Container()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.TxtMa_Xe0 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtSo_Ro0 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CbbMuc_SDS = New System.Windows.Forms.ComboBox()
        Me.CbbMuc_SBD = New System.Windows.Forms.ComboBox()
        Me.ChkSCC = New System.Windows.Forms.CheckBox()
        Me.ChkSBD = New System.Windows.Forms.CheckBox()
        Me.ChkSDS = New System.Windows.Forms.CheckBox()
        Me.Labkhoang = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.CmdTim_khoang = New DevExpress.XtraEditors.SimpleButton()
        Me.ChkIs_One_khoang = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtTG_SC0 = New ClsTextBox.txtTien_NT()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtNgay_BD0 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNgay_KT = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTG_SC = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNgay_BD = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.masterKhoang = New DevExpress.XtraGrid.GridControl()
        Me.masterKhoangGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.masterKhoang, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.masterKhoangGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 488)
        Me.GroupBoxLine.Size = New System.Drawing.Size(879, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(679, 498)
        Me.ButtOK.Text = "&Chuyển KH"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(781, 498)
        '
        'TxtMa_Xe0
        '
        Me.TxtMa_Xe0.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe0.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe0.Location = New System.Drawing.Point(143, 19)
        Me.TxtMa_Xe0.Name = "TxtMa_Xe0"
        Me.TxtMa_Xe0.Size = New System.Drawing.Size(150, 20)
        Me.TxtMa_Xe0.TabIndex = 310
        Me.TxtMa_Xe0.Tag = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(70, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 324
        Me.Label4.Tag = "Car"
        Me.Label4.Text = "Biển số"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtSo_Ro0)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TxtMa_Xe0)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(5, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 77)
        Me.GroupBox1.TabIndex = 325
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Loại trừ kế hoặc"
        '
        'TxtSo_Ro0
        '
        Me.TxtSo_Ro0.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ro0.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro0.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_Ro0.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ro0.Location = New System.Drawing.Point(143, 45)
        Me.TxtSo_Ro0.Name = "TxtSo_Ro0"
        Me.TxtSo_Ro0.Size = New System.Drawing.Size(150, 20)
        Me.TxtSo_Ro0.TabIndex = 325
        Me.TxtSo_Ro0.Tag = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(70, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 326
        Me.Label1.Tag = "R/O"
        Me.Label1.Text = "Số lệnh"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CbbMuc_SDS)
        Me.GroupBox2.Controls.Add(Me.CbbMuc_SBD)
        Me.GroupBox2.Controls.Add(Me.ChkSCC)
        Me.GroupBox2.Controls.Add(Me.ChkSBD)
        Me.GroupBox2.Controls.Add(Me.ChkSDS)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(5, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(299, 77)
        Me.GroupBox2.TabIndex = 326
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Loại sửa chữa"
        '
        'CbbMuc_SDS
        '
        Me.CbbMuc_SDS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMuc_SDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMuc_SDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMuc_SDS.ForeColor = System.Drawing.Color.Navy
        Me.CbbMuc_SDS.FormattingEnabled = True
        Me.CbbMuc_SDS.Location = New System.Drawing.Point(204, 49)
        Me.CbbMuc_SDS.Name = "CbbMuc_SDS"
        Me.CbbMuc_SDS.Size = New System.Drawing.Size(89, 21)
        Me.CbbMuc_SDS.TabIndex = 2074
        '
        'CbbMuc_SBD
        '
        Me.CbbMuc_SBD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMuc_SBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMuc_SBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMuc_SBD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMuc_SBD.FormattingEnabled = True
        Me.CbbMuc_SBD.Location = New System.Drawing.Point(83, 49)
        Me.CbbMuc_SBD.Name = "CbbMuc_SBD"
        Me.CbbMuc_SBD.Size = New System.Drawing.Size(89, 21)
        Me.CbbMuc_SBD.TabIndex = 2075
        '
        'ChkSCC
        '
        Me.ChkSCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkSCC.AutoSize = True
        Me.ChkSCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSCC.ForeColor = System.Drawing.Color.Red
        Me.ChkSCC.Location = New System.Drawing.Point(16, 24)
        Me.ChkSCC.Name = "ChkSCC"
        Me.ChkSCC.Size = New System.Drawing.Size(47, 17)
        Me.ChkSCC.TabIndex = 2072
        Me.ChkSCC.TabStop = False
        Me.ChkSCC.Tag = "Tel, time"
        Me.ChkSCC.Text = "SCC"
        Me.ChkSCC.UseVisualStyleBackColor = True
        '
        'ChkSBD
        '
        Me.ChkSBD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkSBD.AutoSize = True
        Me.ChkSBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSBD.ForeColor = System.Drawing.Color.Red
        Me.ChkSBD.Location = New System.Drawing.Point(83, 24)
        Me.ChkSBD.Name = "ChkSBD"
        Me.ChkSBD.Size = New System.Drawing.Size(78, 17)
        Me.ChkSBD.TabIndex = 2073
        Me.ChkSBD.TabStop = False
        Me.ChkSBD.Tag = "Tel, time"
        Me.ChkSBD.Text = "Bảo dưỡng"
        Me.ChkSBD.UseVisualStyleBackColor = True
        '
        'ChkSDS
        '
        Me.ChkSDS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkSDS.AutoSize = True
        Me.ChkSDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSDS.ForeColor = System.Drawing.Color.Red
        Me.ChkSDS.Location = New System.Drawing.Point(204, 24)
        Me.ChkSDS.Name = "ChkSDS"
        Me.ChkSDS.Size = New System.Drawing.Size(72, 17)
        Me.ChkSDS.TabIndex = 2071
        Me.ChkSDS.TabStop = False
        Me.ChkSDS.Tag = "Tel, time"
        Me.ChkSDS.Text = "Đồng sơn"
        Me.ChkSDS.UseVisualStyleBackColor = True
        '
        'Labkhoang
        '
        Me.Labkhoang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Labkhoang.BackColor = System.Drawing.Color.Black
        Me.Labkhoang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labkhoang.ForeColor = System.Drawing.Color.White
        Me.Labkhoang.Location = New System.Drawing.Point(310, 9)
        Me.Labkhoang.Margin = New System.Windows.Forms.Padding(0)
        Me.Labkhoang.Name = "Labkhoang"
        Me.Labkhoang.Size = New System.Drawing.Size(572, 23)
        Me.Labkhoang.TabIndex = 7129
        Me.Labkhoang.Tag = ""
        Me.Labkhoang.Text = "CHỌN KHOANG TẠO KẾ HOẠCH"
        Me.Labkhoang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CmdTim_khoang)
        Me.GroupBox4.Controls.Add(Me.ChkIs_One_khoang)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.TxtTG_SC0)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.TxtNgay_BD0)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(5, 173)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(299, 127)
        Me.GroupBox4.TabIndex = 2077
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Thời gian sửa chữa"
        '
        'CmdTim_khoang
        '
        Me.CmdTim_khoang.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdTim_khoang.Appearance.ForeColor = System.Drawing.Color.Blue
        Me.CmdTim_khoang.Appearance.Options.UseForeColor = True
        Me.CmdTim_khoang.Location = New System.Drawing.Point(151, 93)
        Me.CmdTim_khoang.Name = "CmdTim_khoang"
        Me.CmdTim_khoang.Size = New System.Drawing.Size(141, 29)
        Me.CmdTim_khoang.TabIndex = 7135
        Me.CmdTim_khoang.Text = "Tìm khoang"
        '
        'ChkIs_One_khoang
        '
        Me.ChkIs_One_khoang.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkIs_One_khoang.AutoSize = True
        Me.ChkIs_One_khoang.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIs_One_khoang.ForeColor = System.Drawing.Color.Red
        Me.ChkIs_One_khoang.Location = New System.Drawing.Point(20, 74)
        Me.ChkIs_One_khoang.Name = "ChkIs_One_khoang"
        Me.ChkIs_One_khoang.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkIs_One_khoang.Size = New System.Drawing.Size(273, 17)
        Me.ChkIs_One_khoang.TabIndex = 7134
        Me.ChkIs_One_khoang.TabStop = False
        Me.ChkIs_One_khoang.Tag = "Is One "
        Me.ChkIs_One_khoang.Text = "KH lập trên 1 khoang trong danh sách khoang chọn"
        Me.ChkIs_One_khoang.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(13, 47)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 18)
        Me.Label15.TabIndex = 7133
        Me.Label15.Tag = "Begin"
        Me.Label15.Text = "Dự kiến bắt đầu từ"
        '
        'TxtTG_SC0
        '
        Me.TxtTG_SC0.AllowNegative = True
        Me.TxtTG_SC0.BackColor = System.Drawing.Color.White
        Me.TxtTG_SC0.Flags = 7680
        Me.TxtTG_SC0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTG_SC0.ForeColor = System.Drawing.Color.Blue
        Me.TxtTG_SC0.InputMask = "### ###  ###"
        Me.TxtTG_SC0.Location = New System.Drawing.Point(151, 20)
        Me.TxtTG_SC0.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTG_SC0.MaxWholeDigits = 8
        Me.TxtTG_SC0.Name = "TxtTG_SC0"
        Me.TxtTG_SC0.RangeMax = 1.7976931348623157E+308R
        Me.TxtTG_SC0.RangeMin = -1.7976931348623157E+308R
        Me.TxtTG_SC0.Size = New System.Drawing.Size(142, 21)
        Me.TxtTG_SC0.TabIndex = 7130
        Me.TxtTG_SC0.Text = "0"
        Me.TxtTG_SC0.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(13, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 18)
        Me.Label8.TabIndex = 7132
        Me.Label8.Tag = "Time"
        Me.Label8.Text = "TG sửa chữa"
        '
        'TxtNgay_BD0
        '
        Me.TxtNgay_BD0.BackColor = System.Drawing.Color.White
        Me.TxtNgay_BD0.Flags = 0
        Me.TxtNgay_BD0.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD0.ForeColor = System.Drawing.Color.Blue
        Me.TxtNgay_BD0.IsAllowResize = False
        Me.TxtNgay_BD0.Location = New System.Drawing.Point(151, 44)
        Me.TxtNgay_BD0.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD0.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD0.MaxLength = 10
        Me.TxtNgay_BD0.Name = "TxtNgay_BD0"
        Me.TxtNgay_BD0.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD0.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD0.ShowDayBeforeMonth = False
        Me.TxtNgay_BD0.Size = New System.Drawing.Size(142, 21)
        Me.TxtNgay_BD0.TabIndex = 7131
        Me.TxtNgay_BD0.Value = "04/05/2019 21:52"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtDien_Giai)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.TxtNgay_KT)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.TxtTG_SC)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TxtNgay_BD)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(5, 311)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(299, 173)
        Me.GroupBox3.TabIndex = 7134
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Kết quả tim kiếm khoang tối ưu"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(6, 96)
        Me.TxtDien_Giai.Multiline = True
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.ReadOnly = True
        Me.TxtDien_Giai.Size = New System.Drawing.Size(286, 70)
        Me.TxtDien_Giai.TabIndex = 7136
        Me.TxtDien_Giai.Tag = ""
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(13, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 18)
        Me.Label5.TabIndex = 7135
        Me.Label5.Tag = "Begin"
        Me.Label5.Text = "Dự kiến kết thúc"
        '
        'TxtNgay_KT
        '
        Me.TxtNgay_KT.BackColor = System.Drawing.Color.White
        Me.TxtNgay_KT.Enabled = False
        Me.TxtNgay_KT.Flags = 0
        Me.TxtNgay_KT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_KT.IsAllowResize = False
        Me.TxtNgay_KT.Location = New System.Drawing.Point(151, 72)
        Me.TxtNgay_KT.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT.MaxLength = 10
        Me.TxtNgay_KT.Name = "TxtNgay_KT"
        Me.TxtNgay_KT.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT.ReadOnly = True
        Me.TxtNgay_KT.ShowDayBeforeMonth = False
        Me.TxtNgay_KT.Size = New System.Drawing.Size(142, 21)
        Me.TxtNgay_KT.TabIndex = 7134
        Me.TxtNgay_KT.Value = "04/05/2019 21:52"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(13, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 18)
        Me.Label2.TabIndex = 7133
        Me.Label2.Tag = "Begin"
        Me.Label2.Text = "Dự kiến bắt đầu từ"
        '
        'TxtTG_SC
        '
        Me.TxtTG_SC.AllowNegative = True
        Me.TxtTG_SC.BackColor = System.Drawing.Color.White
        Me.TxtTG_SC.Flags = 7680
        Me.TxtTG_SC.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTG_SC.ForeColor = System.Drawing.Color.Navy
        Me.TxtTG_SC.InputMask = "### ###  ###"
        Me.TxtTG_SC.Location = New System.Drawing.Point(151, 20)
        Me.TxtTG_SC.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTG_SC.MaxWholeDigits = 8
        Me.TxtTG_SC.Name = "TxtTG_SC"
        Me.TxtTG_SC.RangeMax = 1.7976931348623157E+308R
        Me.TxtTG_SC.RangeMin = -1.7976931348623157E+308R
        Me.TxtTG_SC.ReadOnly = True
        Me.TxtTG_SC.Size = New System.Drawing.Size(142, 21)
        Me.TxtTG_SC.TabIndex = 7130
        Me.TxtTG_SC.Text = "0"
        Me.TxtTG_SC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(13, 22)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 18)
        Me.Label3.TabIndex = 7132
        Me.Label3.Tag = "Time"
        Me.Label3.Text = "TG sửa chữa"
        '
        'TxtNgay_BD
        '
        Me.TxtNgay_BD.BackColor = System.Drawing.Color.White
        Me.TxtNgay_BD.Enabled = False
        Me.TxtNgay_BD.Flags = 0
        Me.TxtNgay_BD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_BD.IsAllowResize = False
        Me.TxtNgay_BD.Location = New System.Drawing.Point(151, 44)
        Me.TxtNgay_BD.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD.MaxLength = 10
        Me.TxtNgay_BD.Name = "TxtNgay_BD"
        Me.TxtNgay_BD.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD.ReadOnly = True
        Me.TxtNgay_BD.ShowDayBeforeMonth = False
        Me.TxtNgay_BD.Size = New System.Drawing.Size(142, 21)
        Me.TxtNgay_BD.TabIndex = 7131
        Me.TxtNgay_BD.Value = "04/05/2019 21:52"
        '
        'masterKhoang
        '
        Me.masterKhoang.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.masterKhoang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.masterKhoang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GridLevelNode2.RelationName = "Level1"
        Me.masterKhoang.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.masterKhoang.Location = New System.Drawing.Point(310, 35)
        Me.masterKhoang.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.masterKhoang.MainView = Me.masterKhoangGRV
        Me.masterKhoang.Name = "masterKhoang"
        Me.masterKhoang.Size = New System.Drawing.Size(572, 449)
        Me.masterKhoang.TabIndex = 7135
        Me.masterKhoang.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.masterKhoangGRV})
        '
        'masterKhoangGRV
        '
        Me.masterKhoangGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.masterKhoangGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.masterKhoangGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.masterKhoangGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.masterKhoangGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.masterKhoangGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.masterKhoangGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.masterKhoangGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.masterKhoangGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.masterKhoangGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.masterKhoangGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.masterKhoangGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.masterKhoangGRV.GridControl = Me.masterKhoang
        Me.masterKhoangGRV.GroupRowHeight = 30
        Me.masterKhoangGRV.Name = "masterKhoangGRV"
        Me.masterKhoangGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.masterKhoangGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.masterKhoangGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.masterKhoangGRV.OptionsView.ColumnAutoWidth = False
        Me.masterKhoangGRV.OptionsView.ShowGroupPanel = False
        Me.masterKhoangGRV.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.masterKhoangGRV.RowHeight = 21
        '
        'PopupMenuMasterGrid
        '
        Me.PopupMenuMasterGrid.Manager = Me.BarManager1
        Me.PopupMenuMasterGrid.Name = "PopupMenuMasterGrid"
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 1"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Custom 1"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(883, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 552)
        Me.barDockControlBottom.Size = New System.Drawing.Size(883, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 523)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(883, 29)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 523)
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(9, 504)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(612, 19)
        Me.Label14.TabIndex = 7168
        Me.Label14.Tag = ""
        Me.Label14.Text = "Ghi chú: Khi bạn nhiều khoang hệ thống sẽ tự động tạo nhiều kế hoạch và lựa chọn " & _
            "theo p/p tính khoang rỗng"
        '
        'FrmCVDV_TimKhoang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(883, 552)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.masterKhoang)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Labkhoang)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmCVDV_TimKhoang"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.Labkhoang, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.masterKhoang, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.masterKhoang, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.masterKhoangGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtMa_Xe0 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSo_Ro0 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CbbMuc_SDS As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMuc_SBD As System.Windows.Forms.ComboBox
    Friend WithEvents ChkSCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSBD As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSDS As System.Windows.Forms.CheckBox
    Friend WithEvents Labkhoang As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtTG_SC0 As ClsTextBox.txtTien_NT
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_BD0 As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTG_SC As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_BD As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents CmdTim_khoang As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_KT As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents ChkIs_One_khoang As System.Windows.Forms.CheckBox
    Friend WithEvents TxtDien_Giai As System.Windows.Forms.TextBox
    Friend WithEvents masterKhoang As DevExpress.XtraGrid.GridControl
    Friend WithEvents masterKhoangGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Label14 As System.Windows.Forms.Label

End Class
