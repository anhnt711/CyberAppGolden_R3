<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTien_Do_Update_TG_GX
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
        Me.TxtNgay_BD_RO = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_KT_RO = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Lx = New System.Windows.Forms.TextBox()
        Me.txtDt_lx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtNgay_BD_KH = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_KT_KH = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtNgay_BD_RX = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_KT_RX = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Master_Update = New DevExpress.XtraGrid.GridControl()
        Me.Master_UpdateGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TxtStt_Rec_Ro = New System.Windows.Forms.TextBox()
        Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtNgay_BD_Up = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_KT_Up = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtNgay_HenKT_Up = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CmdUp_TG_GX_KH_SCC = New DevExpress.XtraEditors.SimpleButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtNgay_HenKT_RO = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.ChkIs_Rua = New System.Windows.Forms.CheckBox()
        CType(Me.Master_Update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_UpdateGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 526)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1002, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(802, 536)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(904, 536)
        Me.ButtExit.TabIndex = 5
        '
        'TxtNgay_BD_RO
        '
        Me.TxtNgay_BD_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_BD_RO.Enabled = False
        Me.TxtNgay_BD_RO.Flags = 0
        Me.TxtNgay_BD_RO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD_RO.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_BD_RO.IsAllowResize = False
        Me.TxtNgay_BD_RO.Location = New System.Drawing.Point(88, 42)
        Me.TxtNgay_BD_RO.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD_RO.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD_RO.MaxLength = 10
        Me.TxtNgay_BD_RO.Name = "TxtNgay_BD_RO"
        Me.TxtNgay_BD_RO.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD_RO.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD_RO.ShowDayBeforeMonth = False
        Me.TxtNgay_BD_RO.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_BD_RO.TabIndex = 7144
        Me.TxtNgay_BD_RO.Value = "29/03/2020 01:22"
        '
        'TxtNgay_KT_RO
        '
        Me.TxtNgay_KT_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_KT_RO.Enabled = False
        Me.TxtNgay_KT_RO.Flags = 0
        Me.TxtNgay_KT_RO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT_RO.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_KT_RO.IsAllowResize = False
        Me.TxtNgay_KT_RO.Location = New System.Drawing.Point(88, 70)
        Me.TxtNgay_KT_RO.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT_RO.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT_RO.MaxLength = 10
        Me.TxtNgay_KT_RO.Name = "TxtNgay_KT_RO"
        Me.TxtNgay_KT_RO.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT_RO.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT_RO.ShowDayBeforeMonth = False
        Me.TxtNgay_KT_RO.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_KT_RO.TabIndex = 7145
        Me.TxtNgay_KT_RO.Value = "29/03/2020 01:22"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(458, 14)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 7143
        Me.Label2.Tag = "Advisor"
        Me.Label2.Text = "Lái xe"
        '
        'TxtTen_Lx
        '
        Me.TxtTen_Lx.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTen_Lx.Enabled = False
        Me.TxtTen_Lx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_Lx.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtTen_Lx.Location = New System.Drawing.Point(501, 12)
        Me.TxtTen_Lx.Name = "TxtTen_Lx"
        Me.TxtTen_Lx.ReadOnly = True
        Me.TxtTen_Lx.Size = New System.Drawing.Size(189, 21)
        Me.TxtTen_Lx.TabIndex = 7142
        Me.TxtTen_Lx.TabStop = False
        Me.TxtTen_Lx.Tag = ""
        '
        'txtDt_lx
        '
        Me.txtDt_lx.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDt_lx.Enabled = False
        Me.txtDt_lx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDt_lx.ForeColor = System.Drawing.Color.DarkRed
        Me.txtDt_lx.Location = New System.Drawing.Point(501, 43)
        Me.txtDt_lx.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDt_lx.Multiline = True
        Me.txtDt_lx.Name = "txtDt_lx"
        Me.txtDt_lx.ReadOnly = True
        Me.txtDt_lx.Size = New System.Drawing.Size(189, 21)
        Me.txtDt_lx.TabIndex = 7141
        Me.txtDt_lx.TabStop = False
        Me.txtDt_lx.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(28, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 7140
        Me.Label5.Tag = "Type (R/O)"
        Me.Label5.Text = "Số lệnh"
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.BackColor = System.Drawing.Color.Lavender
        Me.TxtSo_Ro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_Ro.Location = New System.Drawing.Point(88, 12)
        Me.TxtSo_Ro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(155, 21)
        Me.TxtSo_Ro.TabIndex = 0
        Me.TxtSo_Ro.TabStop = False
        Me.TxtSo_Ro.Tag = ""
        Me.TxtSo_Ro.Text = "01.S15000001"
        Me.TxtSo_Ro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Enabled = False
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtMa_Xe.Location = New System.Drawing.Point(314, 12)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.ReadOnly = True
        Me.TxtMa_Xe.Size = New System.Drawing.Size(143, 21)
        Me.TxtMa_Xe.TabIndex = 7137
        Me.TxtMa_Xe.TabStop = False
        Me.TxtMa_Xe.Tag = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(254, 14)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 7139
        Me.Label4.Tag = "Type (R/O)"
        Me.Label4.Text = "Biển số"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(456, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 15)
        Me.Label1.TabIndex = 7146
        Me.Label1.Tag = "Advisor"
        Me.Label1.Text = "ĐT"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(28, 44)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 15)
        Me.Label6.TabIndex = 7148
        Me.Label6.Tag = "Type (R/O)"
        Me.Label6.Text = "Bắt đầu"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(28, 72)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 7149
        Me.Label3.Tag = "Type (R/O)"
        Me.Label3.Text = "Kết thúc"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(727, 14)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 7151
        Me.Label7.Tag = "Advisor"
        Me.Label7.Text = "CVDV"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtTen_Hs.Location = New System.Drawing.Point(795, 12)
        Me.TxtTen_Hs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Hs.Multiline = True
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(155, 21)
        Me.TxtTen_Hs.TabIndex = 7150
        Me.TxtTen_Hs.TabStop = False
        Me.TxtTen_Hs.Tag = ""
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(703, 152)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 7155
        Me.Label8.Tag = "Type (R/O)"
        Me.Label8.Text = "Kết thúc"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(703, 124)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 15)
        Me.Label9.TabIndex = 7154
        Me.Label9.Tag = "Type (R/O)"
        Me.Label9.Text = "Bắt đầu"
        '
        'TxtNgay_BD_KH
        '
        Me.TxtNgay_BD_KH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_BD_KH.Enabled = False
        Me.TxtNgay_BD_KH.Flags = 0
        Me.TxtNgay_BD_KH.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD_KH.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_BD_KH.IsAllowResize = False
        Me.TxtNgay_BD_KH.Location = New System.Drawing.Point(763, 122)
        Me.TxtNgay_BD_KH.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD_KH.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD_KH.MaxLength = 10
        Me.TxtNgay_BD_KH.Name = "TxtNgay_BD_KH"
        Me.TxtNgay_BD_KH.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD_KH.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD_KH.ShowDayBeforeMonth = False
        Me.TxtNgay_BD_KH.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_BD_KH.TabIndex = 7152
        Me.TxtNgay_BD_KH.Value = "29/03/2020 01:22"
        '
        'TxtNgay_KT_KH
        '
        Me.TxtNgay_KT_KH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_KT_KH.Enabled = False
        Me.TxtNgay_KT_KH.Flags = 0
        Me.TxtNgay_KT_KH.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT_KH.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_KT_KH.IsAllowResize = False
        Me.TxtNgay_KT_KH.Location = New System.Drawing.Point(763, 150)
        Me.TxtNgay_KT_KH.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT_KH.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT_KH.MaxLength = 10
        Me.TxtNgay_KT_KH.Name = "TxtNgay_KT_KH"
        Me.TxtNgay_KT_KH.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT_KH.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT_KH.ShowDayBeforeMonth = False
        Me.TxtNgay_KT_KH.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_KT_KH.TabIndex = 7153
        Me.TxtNgay_KT_KH.Value = "29/03/2020 01:22"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(388, 159)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 15)
        Me.Label10.TabIndex = 7159
        Me.Label10.Tag = "Type (R/O)"
        Me.Label10.Text = "Kết thúc"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(388, 131)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 15)
        Me.Label11.TabIndex = 7158
        Me.Label11.Tag = "Type (R/O)"
        Me.Label11.Text = "Bắt đầu"
        '
        'TxtNgay_BD_RX
        '
        Me.TxtNgay_BD_RX.BackColor = System.Drawing.Color.White
        Me.TxtNgay_BD_RX.Flags = 0
        Me.TxtNgay_BD_RX.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD_RX.ForeColor = System.Drawing.Color.Blue
        Me.TxtNgay_BD_RX.IsAllowResize = False
        Me.TxtNgay_BD_RX.Location = New System.Drawing.Point(443, 129)
        Me.TxtNgay_BD_RX.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD_RX.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD_RX.MaxLength = 10
        Me.TxtNgay_BD_RX.Name = "TxtNgay_BD_RX"
        Me.TxtNgay_BD_RX.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD_RX.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD_RX.ShowDayBeforeMonth = False
        Me.TxtNgay_BD_RX.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_BD_RX.TabIndex = 7156
        Me.TxtNgay_BD_RX.Value = "29/03/2020 01:22"
        '
        'TxtNgay_KT_RX
        '
        Me.TxtNgay_KT_RX.BackColor = System.Drawing.Color.White
        Me.TxtNgay_KT_RX.Flags = 0
        Me.TxtNgay_KT_RX.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT_RX.ForeColor = System.Drawing.Color.Blue
        Me.TxtNgay_KT_RX.IsAllowResize = False
        Me.TxtNgay_KT_RX.Location = New System.Drawing.Point(443, 157)
        Me.TxtNgay_KT_RX.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT_RX.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT_RX.MaxLength = 10
        Me.TxtNgay_KT_RX.Name = "TxtNgay_KT_RX"
        Me.TxtNgay_KT_RX.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT_RX.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT_RX.ShowDayBeforeMonth = False
        Me.TxtNgay_KT_RX.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_KT_RX.TabIndex = 7157
        Me.TxtNgay_KT_RX.Value = "29/03/2020 01:22"
        '
        'Master_Update
        '
        Me.Master_Update.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_Update.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_Update.Location = New System.Drawing.Point(4, 215)
        Me.Master_Update.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_Update.MainView = Me.Master_UpdateGRV
        Me.Master_Update.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_Update.Name = "Master_Update"
        Me.Master_Update.Size = New System.Drawing.Size(999, 311)
        Me.Master_Update.TabIndex = 7160
        Me.Master_Update.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_UpdateGRV})
        '
        'Master_UpdateGRV
        '
        Me.Master_UpdateGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_UpdateGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_UpdateGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_UpdateGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_UpdateGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_UpdateGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_UpdateGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_UpdateGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_UpdateGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_UpdateGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_UpdateGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_UpdateGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_UpdateGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.Master_UpdateGRV.GridControl = Me.Master_Update
        Me.Master_UpdateGRV.GroupRowHeight = 30
        Me.Master_UpdateGRV.Name = "Master_UpdateGRV"
        Me.Master_UpdateGRV.OptionsBehavior.Editable = False
        Me.Master_UpdateGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_UpdateGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_UpdateGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_UpdateGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_UpdateGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Master_UpdateGRV.OptionsView.ShowGroupPanel = False
        Me.Master_UpdateGRV.RowHeight = 22
        '
        'TxtStt_Rec_Ro
        '
        Me.TxtStt_Rec_Ro.BackColor = System.Drawing.Color.Lavender
        Me.TxtStt_Rec_Ro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec_Ro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec_Ro.ForeColor = System.Drawing.Color.Blue
        Me.TxtStt_Rec_Ro.Location = New System.Drawing.Point(257, 44)
        Me.TxtStt_Rec_Ro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec_Ro.Name = "TxtStt_Rec_Ro"
        Me.TxtStt_Rec_Ro.Size = New System.Drawing.Size(69, 21)
        Me.TxtStt_Rec_Ro.TabIndex = 7161
        Me.TxtStt_Rec_Ro.TabStop = False
        Me.TxtStt_Rec_Ro.Tag = ""
        Me.TxtStt_Rec_Ro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtStt_Rec_Ro.Visible = False
        '
        'PopupMenu
        '
        Me.PopupMenu.Manager = Me.BarManager1
        Me.PopupMenu.Name = "PopupMenu"
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1006, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 590)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1006, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 590)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1006, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 590)
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(28, 151)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 15)
        Me.Label12.TabIndex = 7169
        Me.Label12.Tag = "Type (R/O)"
        Me.Label12.Text = "Kết thúc"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(28, 123)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 15)
        Me.Label13.TabIndex = 7168
        Me.Label13.Tag = "Type (R/O)"
        Me.Label13.Text = "Bắt đầu"
        '
        'TxtNgay_BD_Up
        '
        Me.TxtNgay_BD_Up.BackColor = System.Drawing.Color.White
        Me.TxtNgay_BD_Up.Flags = 0
        Me.TxtNgay_BD_Up.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD_Up.ForeColor = System.Drawing.Color.Blue
        Me.TxtNgay_BD_Up.IsAllowResize = False
        Me.TxtNgay_BD_Up.Location = New System.Drawing.Point(88, 121)
        Me.TxtNgay_BD_Up.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD_Up.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD_Up.MaxLength = 10
        Me.TxtNgay_BD_Up.Name = "TxtNgay_BD_Up"
        Me.TxtNgay_BD_Up.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD_Up.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD_Up.ShowDayBeforeMonth = False
        Me.TxtNgay_BD_Up.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_BD_Up.TabIndex = 1
        Me.TxtNgay_BD_Up.Value = "29/03/2020 01:22"
        '
        'TxtNgay_KT_Up
        '
        Me.TxtNgay_KT_Up.BackColor = System.Drawing.Color.White
        Me.TxtNgay_KT_Up.Flags = 0
        Me.TxtNgay_KT_Up.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT_Up.ForeColor = System.Drawing.Color.Blue
        Me.TxtNgay_KT_Up.IsAllowResize = False
        Me.TxtNgay_KT_Up.Location = New System.Drawing.Point(88, 149)
        Me.TxtNgay_KT_Up.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT_Up.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT_Up.MaxLength = 10
        Me.TxtNgay_KT_Up.Name = "TxtNgay_KT_Up"
        Me.TxtNgay_KT_Up.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT_Up.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT_Up.ShowDayBeforeMonth = False
        Me.TxtNgay_KT_Up.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_KT_Up.TabIndex = 2
        Me.TxtNgay_KT_Up.Value = "29/03/2020 01:22"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Blue
        Me.Label14.Location = New System.Drawing.Point(28, 181)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 15)
        Me.Label14.TabIndex = 7171
        Me.Label14.Tag = "Type (R/O)"
        Me.Label14.Text = "Hẹn giao xe"
        '
        'TxtNgay_HenKT_Up
        '
        Me.TxtNgay_HenKT_Up.BackColor = System.Drawing.Color.White
        Me.TxtNgay_HenKT_Up.Flags = 0
        Me.TxtNgay_HenKT_Up.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_HenKT_Up.ForeColor = System.Drawing.Color.Blue
        Me.TxtNgay_HenKT_Up.IsAllowResize = False
        Me.TxtNgay_HenKT_Up.Location = New System.Drawing.Point(88, 179)
        Me.TxtNgay_HenKT_Up.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_HenKT_Up.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_HenKT_Up.MaxLength = 10
        Me.TxtNgay_HenKT_Up.Name = "TxtNgay_HenKT_Up"
        Me.TxtNgay_HenKT_Up.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_HenKT_Up.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HenKT_Up.ShowDayBeforeMonth = False
        Me.TxtNgay_HenKT_Up.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_HenKT_Up.TabIndex = 3
        Me.TxtNgay_HenKT_Up.Value = "29/03/2020 01:22"
        '
        'GroupBox1
        '
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(7, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(303, 119)
        Me.GroupBox1.TabIndex = 7172
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cập nhập vào lệnh"
        '
        'GroupBox2
        '
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(690, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(303, 119)
        Me.GroupBox2.TabIndex = 7173
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "KH Sửa chữa"
        '
        'GroupBox3
        '
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(344, 93)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 119)
        Me.GroupBox3.TabIndex = 7174
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "KH rửa xe"
        '
        'CmdUp_TG_GX_KH_SCC
        '
        Me.CmdUp_TG_GX_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdUp_TG_GX_KH_SCC.Image = Global.Cyber.Workprogress.My.Resources.Resources.apply_32x32
        Me.CmdUp_TG_GX_KH_SCC.Location = New System.Drawing.Point(787, 536)
        Me.CmdUp_TG_GX_KH_SCC.Name = "CmdUp_TG_GX_KH_SCC"
        Me.CmdUp_TG_GX_KH_SCC.Size = New System.Drawing.Size(116, 30)
        Me.CmdUp_TG_GX_KH_SCC.TabIndex = 4
        Me.CmdUp_TG_GX_KH_SCC.Text = "Cập nhập KH"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkRed
        Me.Label15.Location = New System.Drawing.Point(254, 72)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 15)
        Me.Label15.TabIndex = 7181
        Me.Label15.Tag = "Type (R/O)"
        Me.Label15.Text = "Hẹn GX"
        '
        'TxtNgay_HenKT_RO
        '
        Me.TxtNgay_HenKT_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_HenKT_RO.Enabled = False
        Me.TxtNgay_HenKT_RO.Flags = 0
        Me.TxtNgay_HenKT_RO.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_HenKT_RO.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_HenKT_RO.IsAllowResize = False
        Me.TxtNgay_HenKT_RO.Location = New System.Drawing.Point(314, 70)
        Me.TxtNgay_HenKT_RO.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_HenKT_RO.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_HenKT_RO.MaxLength = 10
        Me.TxtNgay_HenKT_RO.Name = "TxtNgay_HenKT_RO"
        Me.TxtNgay_HenKT_RO.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_HenKT_RO.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HenKT_RO.ShowDayBeforeMonth = False
        Me.TxtNgay_HenKT_RO.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_HenKT_RO.TabIndex = 7180
        Me.TxtNgay_HenKT_RO.Value = "29/03/2020 01:22"
        '
        'ChkIs_Rua
        '
        Me.ChkIs_Rua.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkIs_Rua.AutoSize = True
        Me.ChkIs_Rua.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_Rua.Location = New System.Drawing.Point(443, 186)
        Me.ChkIs_Rua.Name = "ChkIs_Rua"
        Me.ChkIs_Rua.Size = New System.Drawing.Size(60, 17)
        Me.ChkIs_Rua.TabIndex = 7186
        Me.ChkIs_Rua.TabStop = False
        Me.ChkIs_Rua.Tag = "Tel, time"
        Me.ChkIs_Rua.Text = "Rửa xe"
        Me.ChkIs_Rua.UseVisualStyleBackColor = True
        '
        'FrmTien_Do_Update_TG_GX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1006, 590)
        Me.Controls.Add(Me.ChkIs_Rua)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtNgay_HenKT_RO)
        Me.Controls.Add(Me.CmdUp_TG_GX_KH_SCC)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtNgay_HenKT_Up)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtNgay_BD_Up)
        Me.Controls.Add(Me.TxtNgay_KT_Up)
        Me.Controls.Add(Me.TxtStt_Rec_Ro)
        Me.Controls.Add(Me.Master_Update)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtNgay_BD_RX)
        Me.Controls.Add(Me.TxtNgay_KT_RX)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtNgay_BD_KH)
        Me.Controls.Add(Me.TxtNgay_KT_KH)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNgay_BD_RO)
        Me.Controls.Add(Me.TxtNgay_KT_RO)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Lx)
        Me.Controls.Add(Me.txtDt_lx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSo_Ro)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmTien_Do_Update_TG_GX"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtDt_lx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Lx, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD_RO, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD_KH, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT_RX, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD_RX, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Master_Update, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec_Ro, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT_Up, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD_Up, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HenKT_Up, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.CmdUp_TG_GX_KH_SCC, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HenKT_RO, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Rua, 0)
        CType(Me.Master_Update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_UpdateGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_BD_RO As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_KT_RO As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Lx As System.Windows.Forms.TextBox
    Friend WithEvents txtDt_lx As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ro As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_BD_KH As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_KT_KH As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_BD_RX As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_KT_RX As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Master_Update As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_UpdateGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtStt_Rec_Ro As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_HenKT_Up As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_BD_Up As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_KT_Up As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdUp_TG_GX_KH_SCC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_HenKT_RO As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents ChkIs_Rua As System.Windows.Forms.CheckBox

End Class
