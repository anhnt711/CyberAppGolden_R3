<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ROXPT
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
        Me.LabLenh_RO = New System.Windows.Forms.Label()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMa_HS_H = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_HS_H = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTen_HS = New System.Windows.Forms.TextBox()
        Me.TxtDia_Chi = New System.Windows.Forms.TextBox()
        Me.TxtMa_kx = New System.Windows.Forms.TextBox()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.LabT_Thue_NT = New System.Windows.Forms.Label()
        Me.TxtT_thue = New ClsTextBox.txtTien_NT()
        Me.LabT_Tien_NT = New System.Windows.Forms.Label()
        Me.TxtT_Tien2 = New ClsTextBox.txtTien_NT()
        Me.LabT_TT_NT = New System.Windows.Forms.Label()
        Me.TxtT_TT = New ClsTextBox.txtTien_NT()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.PopupMenuChoGRV = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.CmDanh_Sach = New System.Windows.Forms.Button()
        Me.CmdXemPhieuXuat = New System.Windows.Forms.Button()
        Me.ChkHen_SBD = New System.Windows.Forms.CheckBox()
        Me.ChkHen_SDS = New System.Windows.Forms.CheckBox()
        Me.ChkHen_SCC = New System.Windows.Forms.CheckBox()
        Me.CbbTime_Data = New System.Windows.Forms.ComboBox()
        Me.ChkAuto_Data = New System.Windows.Forms.CheckBox()
        Me.Detail1 = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDien_giai = New System.Windows.Forms.TextBox()
        Me.TxtOng_ba = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer_Data = New System.Windows.Forms.Timer(Me.components)
        Me.ChkPick = New System.Windows.Forms.CheckBox()
        Me.CbbLan_In = New System.Windows.Forms.ComboBox()
        Me.Chk_S = New System.Windows.Forms.CheckBox()
        Me.Chk_P = New System.Windows.Forms.CheckBox()
        Me.Chk_B = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TxtMa_HS_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuChoGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 498)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1483, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(1283, 502)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 10
        Me.ButtOK.Tag = "&OK"
        Me.ButtOK.Text = "&Chấp nhận"
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1385, 502)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 11
        Me.ButtExit.Visible = False
        '
        'LabLenh_RO
        '
        Me.LabLenh_RO.AutoSize = True
        Me.LabLenh_RO.BackColor = System.Drawing.Color.Transparent
        Me.LabLenh_RO.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabLenh_RO.ForeColor = System.Drawing.Color.Navy
        Me.LabLenh_RO.Location = New System.Drawing.Point(6, 19)
        Me.LabLenh_RO.Name = "LabLenh_RO"
        Me.LabLenh_RO.Size = New System.Drawing.Size(63, 18)
        Me.LabLenh_RO.TabIndex = 1804
        Me.LabLenh_RO.Tag = "R/O"
        Me.LabLenh_RO.Text = "Số R/O"
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ro.Location = New System.Drawing.Point(75, 12)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(216, 30)
        Me.TxtSo_Ro.TabIndex = 2
        Me.TxtSo_Ro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TxtMa_HS_H)
        Me.GroupBox1.Controls.Add(Me.TxtTen_HS_H)
        Me.GroupBox1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox1.Location = New System.Drawing.Point(297, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(644, 150)
        Me.GroupBox1.TabIndex = 1807
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "RO info"
        Me.GroupBox1.Text = "Thông tin RO"
        '
        'Label4
        '
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(9, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 15)
        Me.Label4.TabIndex = 1831
        Me.Label4.Tag = "Color"
        Me.Label4.Text = "KTV"
        '
        'TxtMa_HS_H
        '
        Me.TxtMa_HS_H._ActilookupPopup = False
        Me.TxtMa_HS_H.CyberActilookupPopup = True
        Me.TxtMa_HS_H.Dv_ListDetail = Nothing
        Me.TxtMa_HS_H.Dv_Master = Nothing
        Me.TxtMa_HS_H.FilterClient = ""
        Me.TxtMa_HS_H.FilterSQL = ""
        Me.TxtMa_HS_H.Location = New System.Drawing.Point(74, 119)
        Me.TxtMa_HS_H.Name = "TxtMa_HS_H"
        Me.TxtMa_HS_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS_H.Size = New System.Drawing.Size(128, 20)
        Me.TxtMa_HS_H.TabIndex = 1829
        Me.TxtMa_HS_H.Table_Name = ""
        '
        'TxtTen_HS_H
        '
        Me.TxtTen_HS_H.BackColor = System.Drawing.Color.White
        Me.TxtTen_HS_H.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HS_H.Enabled = False
        Me.TxtTen_HS_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HS_H.Location = New System.Drawing.Point(208, 123)
        Me.TxtTen_HS_H.Name = "TxtTen_HS_H"
        Me.TxtTen_HS_H.ReadOnly = True
        Me.TxtTen_HS_H.Size = New System.Drawing.Size(420, 13)
        Me.TxtTen_HS_H.TabIndex = 1830
        Me.TxtTen_HS_H.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(692, 25)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1787
        Me.Label1.Tag = "Colour"
        Me.Label1.Text = "Màu xe"
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_Mau.BackColor = System.Drawing.Color.White
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Blue
        Me.TxtTen_Mau.Location = New System.Drawing.Point(754, 21)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(171, 20)
        Me.TxtTen_Mau.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(692, 51)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 1780
        Me.Label11.Tag = "A advisor"
        Me.Label11.Text = "CVDV"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(306, 77)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 1779
        Me.Label10.Tag = "Address"
        Me.Label10.Text = "Địa chỉ"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(505, 25)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 13)
        Me.Label9.TabIndex = 1778
        Me.Label9.Tag = "Model"
        Me.Label9.Text = "Kiểu xe"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(306, 51)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 1776
        Me.Label7.Tag = "Customer"
        Me.Label7.Text = "Khách hàng"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(306, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 1777
        Me.Label8.Tag = "Plates"
        Me.Label8.Text = "Biển số xe"
        '
        'TxtTen_HS
        '
        Me.TxtTen_HS.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_HS.BackColor = System.Drawing.Color.White
        Me.TxtTen_HS.ForeColor = System.Drawing.Color.Blue
        Me.TxtTen_HS.Location = New System.Drawing.Point(754, 47)
        Me.TxtTen_HS.Name = "TxtTen_HS"
        Me.TxtTen_HS.ReadOnly = True
        Me.TxtTen_HS.Size = New System.Drawing.Size(171, 20)
        Me.TxtTen_HS.TabIndex = 4
        '
        'TxtDia_Chi
        '
        Me.TxtDia_Chi.BackColor = System.Drawing.Color.White
        Me.TxtDia_Chi.ForeColor = System.Drawing.Color.Blue
        Me.TxtDia_Chi.Location = New System.Drawing.Point(371, 73)
        Me.TxtDia_Chi.Name = "TxtDia_Chi"
        Me.TxtDia_Chi.ReadOnly = True
        Me.TxtDia_Chi.Size = New System.Drawing.Size(317, 20)
        Me.TxtDia_Chi.TabIndex = 5
        '
        'TxtMa_kx
        '
        Me.TxtMa_kx.BackColor = System.Drawing.Color.White
        Me.TxtMa_kx.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_kx.Location = New System.Drawing.Point(557, 21)
        Me.TxtMa_kx.Name = "TxtMa_kx"
        Me.TxtMa_kx.ReadOnly = True
        Me.TxtMa_kx.Size = New System.Drawing.Size(131, 20)
        Me.TxtMa_kx.TabIndex = 1
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.Color.White
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.Blue
        Me.TxtTen_KH.Location = New System.Drawing.Point(371, 47)
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(317, 20)
        Me.TxtTen_KH.TabIndex = 3
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Xe.Location = New System.Drawing.Point(371, 21)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.ReadOnly = True
        Me.TxtMa_Xe.Size = New System.Drawing.Size(128, 20)
        Me.TxtMa_Xe.TabIndex = 0
        '
        'LabT_Thue_NT
        '
        Me.LabT_Thue_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabT_Thue_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_Thue_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabT_Thue_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_Thue_NT.Location = New System.Drawing.Point(755, 509)
        Me.LabT_Thue_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_Thue_NT.Name = "LabT_Thue_NT"
        Me.LabT_Thue_NT.Size = New System.Drawing.Size(63, 17)
        Me.LabT_Thue_NT.TabIndex = 1814
        Me.LabT_Thue_NT.Tag = "Total tax"
        Me.LabT_Thue_NT.Text = "Thuế VAT"
        '
        'TxtT_thue
        '
        Me.TxtT_thue.AllowNegative = True
        Me.TxtT_thue.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtT_thue.BackColor = System.Drawing.Color.White
        Me.TxtT_thue.Flags = 7680
        Me.TxtT_thue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_thue.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_thue.InputMask = "### ### ### ### ###.#"
        Me.TxtT_thue.Location = New System.Drawing.Point(825, 507)
        Me.TxtT_thue.MaxWholeDigits = 16
        Me.TxtT_thue.Name = "TxtT_thue"
        Me.TxtT_thue.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_thue.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_thue.ReadOnly = True
        Me.TxtT_thue.Size = New System.Drawing.Size(112, 20)
        Me.TxtT_thue.TabIndex = 1813
        Me.TxtT_thue.TabStop = False
        Me.TxtT_thue.Text = "1.0"
        Me.TxtT_thue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabT_Tien_NT
        '
        Me.LabT_Tien_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabT_Tien_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_Tien_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabT_Tien_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_Tien_NT.Location = New System.Drawing.Point(573, 509)
        Me.LabT_Tien_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_Tien_NT.Name = "LabT_Tien_NT"
        Me.LabT_Tien_NT.Size = New System.Drawing.Size(63, 17)
        Me.LabT_Tien_NT.TabIndex = 1815
        Me.LabT_Tien_NT.Tag = "Total"
        Me.LabT_Tien_NT.Text = "Tiền hàng"
        '
        'TxtT_Tien2
        '
        Me.TxtT_Tien2.AllowNegative = True
        Me.TxtT_Tien2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien2.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien2.Flags = 7680
        Me.TxtT_Tien2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_Tien2.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien2.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien2.Location = New System.Drawing.Point(640, 507)
        Me.TxtT_Tien2.MaxWholeDigits = 16
        Me.TxtT_Tien2.Name = "TxtT_Tien2"
        Me.TxtT_Tien2.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien2.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien2.ReadOnly = True
        Me.TxtT_Tien2.Size = New System.Drawing.Size(112, 20)
        Me.TxtT_Tien2.TabIndex = 1812
        Me.TxtT_Tien2.TabStop = False
        Me.TxtT_Tien2.Text = "1.0"
        Me.TxtT_Tien2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabT_TT_NT
        '
        Me.LabT_TT_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabT_TT_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_TT_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabT_TT_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_TT_NT.Location = New System.Drawing.Point(1290, 508)
        Me.LabT_TT_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_TT_NT.Name = "LabT_TT_NT"
        Me.LabT_TT_NT.Size = New System.Drawing.Size(68, 17)
        Me.LabT_TT_NT.TabIndex = 1811
        Me.LabT_TT_NT.Tag = "Total All"
        Me.LabT_TT_NT.Text = "Tổng cộng"
        '
        'TxtT_TT
        '
        Me.TxtT_TT.AllowNegative = True
        Me.TxtT_TT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtT_TT.BackColor = System.Drawing.Color.White
        Me.TxtT_TT.Flags = 7680
        Me.TxtT_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_TT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_TT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_TT.Location = New System.Drawing.Point(1363, 506)
        Me.TxtT_TT.MaxWholeDigits = 16
        Me.TxtT_TT.Name = "TxtT_TT"
        Me.TxtT_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_TT.ReadOnly = True
        Me.TxtT_TT.Size = New System.Drawing.Size(119, 20)
        Me.TxtT_TT.TabIndex = 1810
        Me.TxtT_TT.TabStop = False
        Me.TxtT_TT.Text = "1.0"
        Me.TxtT_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PopupMenuMasterGrid
        '
        Me.PopupMenuMasterGrid.Manager = Me.BarManager1
        Me.PopupMenuMasterGrid.Name = "PopupMenuMasterGrid"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1252, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 556)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1252, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 556)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1252, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 556)
        '
        'PopupMenuChoGRV
        '
        Me.PopupMenuChoGRV.Manager = Me.BarManager1
        Me.PopupMenuChoGRV.Name = "PopupMenuChoGRV"
        '
        'CmDanh_Sach
        '
        Me.CmDanh_Sach.Location = New System.Drawing.Point(74, 49)
        Me.CmDanh_Sach.Name = "CmDanh_Sach"
        Me.CmDanh_Sach.Size = New System.Drawing.Size(216, 47)
        Me.CmDanh_Sach.TabIndex = 3
        Me.CmDanh_Sach.Tag = "List RO has not exported out of stock"
        Me.CmDanh_Sach.Text = "Danh sách lệnh chưa xuất hết"
        Me.CmDanh_Sach.UseVisualStyleBackColor = True
        '
        'CmdXemPhieuXuat
        '
        Me.CmdXemPhieuXuat.Location = New System.Drawing.Point(74, 103)
        Me.CmdXemPhieuXuat.Name = "CmdXemPhieuXuat"
        Me.CmdXemPhieuXuat.Size = New System.Drawing.Size(216, 47)
        Me.CmdXemPhieuXuat.TabIndex = 4
        Me.CmdXemPhieuXuat.Tag = "View Voucher exported by RO"
        Me.CmdXemPhieuXuat.Text = "Xem xuất kho theo lệnh"
        Me.CmdXemPhieuXuat.UseVisualStyleBackColor = True
        '
        'ChkHen_SBD
        '
        Me.ChkHen_SBD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkHen_SBD.AutoSize = True
        Me.ChkHen_SBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkHen_SBD.ForeColor = System.Drawing.Color.Navy
        Me.ChkHen_SBD.Location = New System.Drawing.Point(331, 509)
        Me.ChkHen_SBD.Name = "ChkHen_SBD"
        Me.ChkHen_SBD.Size = New System.Drawing.Size(78, 17)
        Me.ChkHen_SBD.TabIndex = 7120
        Me.ChkHen_SBD.TabStop = False
        Me.ChkHen_SBD.Tag = "Maintenance"
        Me.ChkHen_SBD.Text = "Bảo dưỡng"
        Me.ChkHen_SBD.UseVisualStyleBackColor = True
        '
        'ChkHen_SDS
        '
        Me.ChkHen_SDS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkHen_SDS.AutoSize = True
        Me.ChkHen_SDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkHen_SDS.ForeColor = System.Drawing.Color.Navy
        Me.ChkHen_SDS.Location = New System.Drawing.Point(437, 509)
        Me.ChkHen_SDS.Name = "ChkHen_SDS"
        Me.ChkHen_SDS.Size = New System.Drawing.Size(72, 17)
        Me.ChkHen_SDS.TabIndex = 7118
        Me.ChkHen_SDS.TabStop = False
        Me.ChkHen_SDS.Tag = "BP"
        Me.ChkHen_SDS.Text = "Đồng sơn"
        Me.ChkHen_SDS.UseVisualStyleBackColor = True
        '
        'ChkHen_SCC
        '
        Me.ChkHen_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkHen_SCC.AutoSize = True
        Me.ChkHen_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkHen_SCC.ForeColor = System.Drawing.Color.Navy
        Me.ChkHen_SCC.Location = New System.Drawing.Point(251, 509)
        Me.ChkHen_SCC.Name = "ChkHen_SCC"
        Me.ChkHen_SCC.Size = New System.Drawing.Size(47, 17)
        Me.ChkHen_SCC.TabIndex = 7119
        Me.ChkHen_SCC.TabStop = False
        Me.ChkHen_SCC.Tag = "GJ"
        Me.ChkHen_SCC.Text = "SCC"
        Me.ChkHen_SCC.UseVisualStyleBackColor = True
        '
        'CbbTime_Data
        '
        Me.CbbTime_Data.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbTime_Data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbTime_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbTime_Data.ForeColor = System.Drawing.Color.Navy
        Me.CbbTime_Data.FormattingEnabled = True
        Me.CbbTime_Data.Location = New System.Drawing.Point(77, 507)
        Me.CbbTime_Data.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbTime_Data.Name = "CbbTime_Data"
        Me.CbbTime_Data.Size = New System.Drawing.Size(52, 21)
        Me.CbbTime_Data.TabIndex = 7116
        '
        'ChkAuto_Data
        '
        Me.ChkAuto_Data.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkAuto_Data.AutoSize = True
        Me.ChkAuto_Data.Location = New System.Drawing.Point(27, 509)
        Me.ChkAuto_Data.Name = "ChkAuto_Data"
        Me.ChkAuto_Data.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkAuto_Data.Size = New System.Drawing.Size(48, 17)
        Me.ChkAuto_Data.TabIndex = 7115
        Me.ChkAuto_Data.Tag = "Auto"
        Me.ChkAuto_Data.Text = "Auto"
        Me.ChkAuto_Data.UseVisualStyleBackColor = True
        '
        'Detail1
        '
        Me.Detail1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail1.Location = New System.Drawing.Point(3, 1)
        Me.Detail1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail1.MainView = Me.DetailGRV1
        Me.Detail1.Name = "Detail1"
        Me.Detail1.Size = New System.Drawing.Size(289, 474)
        Me.Detail1.TabIndex = 7125
        Me.Detail1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV1})
        '
        'DetailGRV1
        '
        Me.DetailGRV1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailGRV1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DetailGRV1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DetailGRV1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV1.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV1.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV1.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV1.GridControl = Me.Detail1
        Me.DetailGRV1.GroupRowHeight = 30
        Me.DetailGRV1.Name = "DetailGRV1"
        Me.DetailGRV1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV1.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV1.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV1.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV1.OptionsView.ShowGroupPanel = False
        Me.DetailGRV1.RowHeight = 21
        '
        'DetailGRV
        '
        Me.DetailGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV.GridControl = Me.Detail
        Me.DetailGRV.GroupRowHeight = 30
        Me.DetailGRV.Name = "DetailGRV"
        Me.DetailGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV.OptionsView.ShowGroupPanel = False
        Me.DetailGRV.RowHeight = 21
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(3, 159)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.Size = New System.Drawing.Size(938, 316)
        Me.Detail.TabIndex = 1817
        Me.Detail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV})
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(9, 9)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtDien_giai)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtOng_ba)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Detail)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtTen_Mau)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtSo_Ro)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label11)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CmDanh_Sach)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CmdXemPhieuXuat)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabLenh_RO)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtTen_HS)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtMa_Xe)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtDia_Chi)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtTen_KH)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtMa_kx)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Detail1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1243, 497)
        Me.SplitContainer1.SplitterDistance = 944
        Me.SplitContainer1.TabIndex = 7130
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(306, 103)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 1828
        Me.Label3.Tag = "Reason"
        Me.Label3.Text = "Lý do"
        '
        'TxtDien_giai
        '
        Me.TxtDien_giai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDien_giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_giai.ForeColor = System.Drawing.Color.Blue
        Me.TxtDien_giai.Location = New System.Drawing.Point(371, 96)
        Me.TxtDien_giai.Name = "TxtDien_giai"
        Me.TxtDien_giai.Size = New System.Drawing.Size(554, 20)
        Me.TxtDien_giai.TabIndex = 7
        '
        'TxtOng_ba
        '
        Me.TxtOng_ba.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtOng_ba.BackColor = System.Drawing.Color.White
        Me.TxtOng_ba.ForeColor = System.Drawing.Color.Blue
        Me.TxtOng_ba.Location = New System.Drawing.Point(754, 73)
        Me.TxtOng_ba.Name = "TxtOng_ba"
        Me.TxtOng_ba.Size = New System.Drawing.Size(171, 20)
        Me.TxtOng_ba.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(692, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 1826
        Me.Label2.Tag = "Receiver"
        Me.Label2.Text = "Người nhân "
        '
        'ChkPick
        '
        Me.ChkPick.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkPick.AutoSize = True
        Me.ChkPick.ForeColor = System.Drawing.Color.Blue
        Me.ChkPick.Location = New System.Drawing.Point(136, 509)
        Me.ChkPick.Name = "ChkPick"
        Me.ChkPick.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkPick.Size = New System.Drawing.Size(86, 17)
        Me.ChkPick.TabIndex = 7135
        Me.ChkPick.Tag = "Export prepick"
        Me.ChkPick.Text = "Xuất prepick"
        Me.ChkPick.UseVisualStyleBackColor = True
        '
        'CbbLan_In
        '
        Me.CbbLan_In.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbLan_In.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbLan_In.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbLan_In.ForeColor = System.Drawing.Color.Navy
        Me.CbbLan_In.FormattingEnabled = True
        Me.CbbLan_In.Location = New System.Drawing.Point(517, 507)
        Me.CbbLan_In.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbLan_In.Name = "CbbLan_In"
        Me.CbbLan_In.Size = New System.Drawing.Size(52, 21)
        Me.CbbLan_In.TabIndex = 7140
        '
        'Chk_S
        '
        Me.Chk_S.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk_S.AutoSize = True
        Me.Chk_S.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Chk_S.ForeColor = System.Drawing.Color.Navy
        Me.Chk_S.Location = New System.Drawing.Point(986, 509)
        Me.Chk_S.Name = "Chk_S"
        Me.Chk_S.Size = New System.Drawing.Size(33, 17)
        Me.Chk_S.TabIndex = 7145
        Me.Chk_S.TabStop = False
        Me.Chk_S.Tag = "S"
        Me.Chk_S.Text = "S"
        Me.Chk_S.UseVisualStyleBackColor = True
        '
        'Chk_P
        '
        Me.Chk_P.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk_P.AutoSize = True
        Me.Chk_P.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Chk_P.ForeColor = System.Drawing.Color.Navy
        Me.Chk_P.Location = New System.Drawing.Point(1100, 509)
        Me.Chk_P.Name = "Chk_P"
        Me.Chk_P.Size = New System.Drawing.Size(33, 17)
        Me.Chk_P.TabIndex = 7146
        Me.Chk_P.TabStop = False
        Me.Chk_P.Tag = "P"
        Me.Chk_P.Text = "P"
        Me.Chk_P.UseVisualStyleBackColor = True
        '
        'Chk_B
        '
        Me.Chk_B.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk_B.AutoSize = True
        Me.Chk_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Chk_B.ForeColor = System.Drawing.Color.Navy
        Me.Chk_B.Location = New System.Drawing.Point(1207, 509)
        Me.Chk_B.Name = "Chk_B"
        Me.Chk_B.Size = New System.Drawing.Size(33, 17)
        Me.Chk_B.TabIndex = 7147
        Me.Chk_B.TabStop = False
        Me.Chk_B.Tag = "B"
        Me.Chk_B.Text = "B"
        Me.Chk_B.UseVisualStyleBackColor = True
        '
        'ROXPT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1252, 556)
        Me.Controls.Add(Me.Chk_B)
        Me.Controls.Add(Me.Chk_P)
        Me.Controls.Add(Me.Chk_S)
        Me.Controls.Add(Me.CbbLan_In)
        Me.Controls.Add(Me.ChkPick)
        Me.Controls.Add(Me.ChkHen_SBD)
        Me.Controls.Add(Me.ChkHen_SDS)
        Me.Controls.Add(Me.ChkHen_SCC)
        Me.Controls.Add(Me.CbbTime_Data)
        Me.Controls.Add(Me.ChkAuto_Data)
        Me.Controls.Add(Me.LabT_Thue_NT)
        Me.Controls.Add(Me.TxtT_thue)
        Me.Controls.Add(Me.LabT_Tien_NT)
        Me.Controls.Add(Me.TxtT_Tien2)
        Me.Controls.Add(Me.LabT_TT_NT)
        Me.Controls.Add(Me.TxtT_TT)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ROXPT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.TxtT_TT, 0)
        Me.Controls.SetChildIndex(Me.LabT_TT_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien2, 0)
        Me.Controls.SetChildIndex(Me.LabT_Tien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_thue, 0)
        Me.Controls.SetChildIndex(Me.LabT_Thue_NT, 0)
        Me.Controls.SetChildIndex(Me.ChkAuto_Data, 0)
        Me.Controls.SetChildIndex(Me.CbbTime_Data, 0)
        Me.Controls.SetChildIndex(Me.ChkHen_SCC, 0)
        Me.Controls.SetChildIndex(Me.ChkHen_SDS, 0)
        Me.Controls.SetChildIndex(Me.ChkHen_SBD, 0)
        Me.Controls.SetChildIndex(Me.ChkPick, 0)
        Me.Controls.SetChildIndex(Me.CbbLan_In, 0)
        Me.Controls.SetChildIndex(Me.Chk_S, 0)
        Me.Controls.SetChildIndex(Me.Chk_P, 0)
        Me.Controls.SetChildIndex(Me.Chk_B, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TxtMa_HS_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuChoGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabLenh_RO As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ro As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_HS As System.Windows.Forms.TextBox
    Friend WithEvents TxtDia_Chi As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents LabT_Thue_NT As System.Windows.Forms.Label
    Friend WithEvents TxtT_thue As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_Tien_NT As System.Windows.Forms.Label
    Friend WithEvents TxtT_Tien2 As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_TT_NT As System.Windows.Forms.Label
    Friend WithEvents TxtT_TT As ClsTextBox.txtTien_NT
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenuChoGRV As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents CmDanh_Sach As System.Windows.Forms.Button
    Friend WithEvents CmdXemPhieuXuat As System.Windows.Forms.Button
    Friend WithEvents ChkHen_SBD As System.Windows.Forms.CheckBox
    Friend WithEvents ChkHen_SDS As System.Windows.Forms.CheckBox
    Friend WithEvents ChkHen_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents CbbTime_Data As System.Windows.Forms.ComboBox
    Friend WithEvents ChkAuto_Data As System.Windows.Forms.CheckBox
    Friend WithEvents Detail1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Timer_Data As System.Windows.Forms.Timer
    Friend WithEvents ChkPick As System.Windows.Forms.CheckBox
    Friend WithEvents CbbLan_In As System.Windows.Forms.ComboBox
    Friend WithEvents TxtOng_ba As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Chk_B As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_P As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_S As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_giai As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_HS_H As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_HS_H As System.Windows.Forms.TextBox

End Class
