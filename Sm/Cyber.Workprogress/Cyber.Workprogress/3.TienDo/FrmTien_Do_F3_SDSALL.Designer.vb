<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTien_Do_F3_SDSALL
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TxtNgay_henKT_RO = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtDT_LX = New System.Windows.Forms.TextBox()
        Me.ChkSDS = New System.Windows.Forms.CheckBox()
        Me.CbbMuc_SBD = New System.Windows.Forms.ComboBox()
        Me.CbbMuc_SDS = New System.Windows.Forms.ComboBox()
        Me.ChkSBD = New System.Windows.Forms.CheckBox()
        Me.ChkSCC = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Lx = New System.Windows.Forms.TextBox()
        Me.TxtDien_Giai_RO = New System.Windows.Forms.TextBox()
        Me.txtTen_KH = New System.Windows.Forms.TextBox()
        Me.TxtNgay_KT_RO = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_BD_RO = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.txtten_Kx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_HS_H = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNgay_Ct = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtT_TT = New ClsTextBox.txtTien_NT()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTG_SC_RO = New ClsTextBox.txtTien_NT()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec_RO = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChkKhong_doi = New System.Windows.Forms.CheckBox()
        Me.ChkIs_Doi = New System.Windows.Forms.CheckBox()
        Me.ChkIs_None = New System.Windows.Forms.CheckBox()
        Me.ChkUT = New System.Windows.Forms.CheckBox()
        Me.ChkHen = New System.Windows.Forms.CheckBox()
        Me.ChkPM90 = New System.Windows.Forms.CheckBox()
        Me.ChkIs_3D = New System.Windows.Forms.CheckBox()
        Me.ChkEM60 = New System.Windows.Forms.CheckBox()
        Me.Chkfirst_visit = New System.Windows.Forms.CheckBox()
        Me.ChkIs_NonFir = New System.Windows.Forms.CheckBox()
        Me.ChkSCL = New System.Windows.Forms.CheckBox()
        Me.ChkIs_PT = New System.Windows.Forms.CheckBox()
        Me.ChkIs_Rua = New System.Windows.Forms.CheckBox()
        Me.ChkIs_W = New System.Windows.Forms.CheckBox()
        Me.CmdXem_Giao_Xe = New System.Windows.Forms.Button()
        Me.ÇmdNang_Luc_Xuong = New System.Windows.Forms.Button()
        Me.ÇmdXem_LSSC = New System.Windows.Forms.Button()
        Me.ÇmdXem_LS_Hen = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtThem_Gio = New ClsTextBox.txtTien_NT()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 407)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1250, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(1050, 417)
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1152, 417)
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GridLevelNode1.RelationName = "Level1"
        GridLevelNode2.RelationName = "Level2"
        Me.Master.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1, GridLevelNode2})
        Me.Master.Location = New System.Drawing.Point(9, 133)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Margin = New System.Windows.Forms.Padding(0)
        Me.Master.Name = "Master"
        Me.Master.Size = New System.Drawing.Size(1241, 271)
        Me.Master.TabIndex = 45
        Me.Master.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterGRV})
        '
        'MasterGRV
        '
        Me.MasterGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MasterGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterGRV.GridControl = Me.Master
        Me.MasterGRV.GroupRowHeight = 30
        Me.MasterGRV.Name = "MasterGRV"
        Me.MasterGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsCustomization.AllowSort = False
        Me.MasterGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.MasterGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.MasterGRV.OptionsView.ShowGroupPanel = False
        Me.MasterGRV.OptionsView.ShowIndicator = False
        Me.MasterGRV.RowHeight = 22
        '
        'TxtNgay_henKT_RO
        '
        Me.TxtNgay_henKT_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_henKT_RO.Enabled = False
        Me.TxtNgay_henKT_RO.Flags = 0
        Me.TxtNgay_henKT_RO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_henKT_RO.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_henKT_RO.IsAllowResize = False
        Me.TxtNgay_henKT_RO.Location = New System.Drawing.Point(295, 75)
        Me.TxtNgay_henKT_RO.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_henKT_RO.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_henKT_RO.MaxLength = 10
        Me.TxtNgay_henKT_RO.Name = "TxtNgay_henKT_RO"
        Me.TxtNgay_henKT_RO.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_henKT_RO.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_henKT_RO.ReadOnly = True
        Me.TxtNgay_henKT_RO.ShowDayBeforeMonth = False
        Me.TxtNgay_henKT_RO.Size = New System.Drawing.Size(155, 21)
        Me.TxtNgay_henKT_RO.TabIndex = 7169
        Me.TxtNgay_henKT_RO.Value = "14/10/2019 14:31"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DarkRed
        Me.Label10.Location = New System.Drawing.Point(235, 78)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 15)
        Me.Label10.TabIndex = 7168
        Me.Label10.Tag = "Delivery"
        Me.Label10.Text = "Giao xe"
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(939, 9)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 15)
        Me.Label9.TabIndex = 7167
        Me.Label9.Tag = "Tel"
        Me.Label9.Text = "Tel"
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DarkRed
        Me.Label8.Location = New System.Drawing.Point(718, 52)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 15)
        Me.Label8.TabIndex = 7166
        Me.Label8.Tag = "Note"
        Me.Label8.Text = "Y/C SC"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(718, 29)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 15)
        Me.Label6.TabIndex = 7165
        Me.Label6.Tag = "Customer"
        Me.Label6.Text = "Khách hàng"
        '
        'TxtDT_LX
        '
        Me.TxtDT_LX.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDT_LX.Enabled = False
        Me.TxtDT_LX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDT_LX.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtDT_LX.Location = New System.Drawing.Point(970, 6)
        Me.TxtDT_LX.Name = "TxtDT_LX"
        Me.TxtDT_LX.ReadOnly = True
        Me.TxtDT_LX.Size = New System.Drawing.Size(157, 21)
        Me.TxtDT_LX.TabIndex = 7161
        Me.TxtDT_LX.TabStop = False
        Me.TxtDT_LX.Tag = ""
        '
        'ChkSDS
        '
        Me.ChkSDS.AutoSize = True
        Me.ChkSDS.Enabled = False
        Me.ChkSDS.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkSDS.Location = New System.Drawing.Point(618, 28)
        Me.ChkSDS.Name = "ChkSDS"
        Me.ChkSDS.Size = New System.Drawing.Size(72, 17)
        Me.ChkSDS.TabIndex = 7160
        Me.ChkSDS.TabStop = False
        Me.ChkSDS.Tag = "BP"
        Me.ChkSDS.Text = "Đồng sơn"
        Me.ChkSDS.UseVisualStyleBackColor = True
        '
        'CbbMuc_SBD
        '
        Me.CbbMuc_SBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMuc_SBD.Enabled = False
        Me.CbbMuc_SBD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMuc_SBD.ForeColor = System.Drawing.Color.DarkRed
        Me.CbbMuc_SBD.FormattingEnabled = True
        Me.CbbMuc_SBD.Location = New System.Drawing.Point(516, 48)
        Me.CbbMuc_SBD.Name = "CbbMuc_SBD"
        Me.CbbMuc_SBD.Size = New System.Drawing.Size(94, 22)
        Me.CbbMuc_SBD.TabIndex = 7159
        '
        'CbbMuc_SDS
        '
        Me.CbbMuc_SDS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMuc_SDS.Enabled = False
        Me.CbbMuc_SDS.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMuc_SDS.ForeColor = System.Drawing.Color.DarkRed
        Me.CbbMuc_SDS.FormattingEnabled = True
        Me.CbbMuc_SDS.Location = New System.Drawing.Point(618, 47)
        Me.CbbMuc_SDS.Name = "CbbMuc_SDS"
        Me.CbbMuc_SDS.Size = New System.Drawing.Size(94, 22)
        Me.CbbMuc_SDS.TabIndex = 7158
        '
        'ChkSBD
        '
        Me.ChkSBD.AutoSize = True
        Me.ChkSBD.Enabled = False
        Me.ChkSBD.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkSBD.Location = New System.Drawing.Point(516, 28)
        Me.ChkSBD.Name = "ChkSBD"
        Me.ChkSBD.Size = New System.Drawing.Size(78, 17)
        Me.ChkSBD.TabIndex = 7157
        Me.ChkSBD.TabStop = False
        Me.ChkSBD.Tag = "EM"
        Me.ChkSBD.Text = "Bảo dưỡng"
        Me.ChkSBD.UseVisualStyleBackColor = True
        '
        'ChkSCC
        '
        Me.ChkSCC.AutoSize = True
        Me.ChkSCC.Enabled = False
        Me.ChkSCC.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkSCC.Location = New System.Drawing.Point(455, 28)
        Me.ChkSCC.Name = "ChkSCC"
        Me.ChkSCC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkSCC.Size = New System.Drawing.Size(47, 17)
        Me.ChkSCC.TabIndex = 7153
        Me.ChkSCC.TabStop = False
        Me.ChkSCC.Tag = "GJ"
        Me.ChkSCC.Text = "SCC"
        Me.ChkSCC.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(718, 6)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 15)
        Me.Label2.TabIndex = 7152
        Me.Label2.Tag = "Driver"
        Me.Label2.Text = "Lái xe"
        '
        'TxtTen_Lx
        '
        Me.TxtTen_Lx.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTen_Lx.Enabled = False
        Me.TxtTen_Lx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_Lx.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtTen_Lx.Location = New System.Drawing.Point(770, 6)
        Me.TxtTen_Lx.Name = "TxtTen_Lx"
        Me.TxtTen_Lx.ReadOnly = True
        Me.TxtTen_Lx.Size = New System.Drawing.Size(146, 21)
        Me.TxtTen_Lx.TabIndex = 7151
        Me.TxtTen_Lx.TabStop = False
        Me.TxtTen_Lx.Tag = ""
        '
        'TxtDien_Giai_RO
        '
        Me.TxtDien_Giai_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDien_Giai_RO.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDien_Giai_RO.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtDien_Giai_RO.Location = New System.Drawing.Point(770, 51)
        Me.TxtDien_Giai_RO.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDien_Giai_RO.Multiline = True
        Me.TxtDien_Giai_RO.Name = "TxtDien_Giai_RO"
        Me.TxtDien_Giai_RO.ReadOnly = True
        Me.TxtDien_Giai_RO.Size = New System.Drawing.Size(357, 21)
        Me.TxtDien_Giai_RO.TabIndex = 7150
        Me.TxtDien_Giai_RO.TabStop = False
        Me.TxtDien_Giai_RO.Tag = ""
        '
        'txtTen_KH
        '
        Me.txtTen_KH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTen_KH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen_KH.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTen_KH.Location = New System.Drawing.Point(770, 28)
        Me.txtTen_KH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTen_KH.Multiline = True
        Me.txtTen_KH.Name = "txtTen_KH"
        Me.txtTen_KH.ReadOnly = True
        Me.txtTen_KH.Size = New System.Drawing.Size(357, 21)
        Me.txtTen_KH.TabIndex = 7149
        Me.txtTen_KH.TabStop = False
        Me.txtTen_KH.Tag = ""
        '
        'TxtNgay_KT_RO
        '
        Me.TxtNgay_KT_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_KT_RO.Enabled = False
        Me.TxtNgay_KT_RO.Flags = 0
        Me.TxtNgay_KT_RO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT_RO.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_KT_RO.IsAllowResize = False
        Me.TxtNgay_KT_RO.Location = New System.Drawing.Point(295, 52)
        Me.TxtNgay_KT_RO.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT_RO.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT_RO.MaxLength = 10
        Me.TxtNgay_KT_RO.Name = "TxtNgay_KT_RO"
        Me.TxtNgay_KT_RO.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT_RO.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT_RO.ReadOnly = True
        Me.TxtNgay_KT_RO.ShowDayBeforeMonth = False
        Me.TxtNgay_KT_RO.Size = New System.Drawing.Size(155, 21)
        Me.TxtNgay_KT_RO.TabIndex = 7148
        Me.TxtNgay_KT_RO.Value = "14/10/2019 14:31"
        '
        'TxtNgay_BD_RO
        '
        Me.TxtNgay_BD_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_BD_RO.Enabled = False
        Me.TxtNgay_BD_RO.Flags = 0
        Me.TxtNgay_BD_RO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD_RO.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_BD_RO.IsAllowResize = False
        Me.TxtNgay_BD_RO.Location = New System.Drawing.Point(65, 52)
        Me.TxtNgay_BD_RO.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD_RO.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD_RO.MaxLength = 10
        Me.TxtNgay_BD_RO.Name = "TxtNgay_BD_RO"
        Me.TxtNgay_BD_RO.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD_RO.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD_RO.ReadOnly = True
        Me.TxtNgay_BD_RO.ShowDayBeforeMonth = False
        Me.TxtNgay_BD_RO.Size = New System.Drawing.Size(155, 21)
        Me.TxtNgay_BD_RO.TabIndex = 7147
        Me.TxtNgay_BD_RO.Value = "14/10/2019 14:31"
        '
        'txtten_Kx
        '
        Me.txtten_Kx.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtten_Kx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtten_Kx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtten_Kx.ForeColor = System.Drawing.Color.DarkRed
        Me.txtten_Kx.Location = New System.Drawing.Point(295, 28)
        Me.txtten_Kx.Margin = New System.Windows.Forms.Padding(4)
        Me.txtten_Kx.Name = "txtten_Kx"
        Me.txtten_Kx.ReadOnly = True
        Me.txtten_Kx.Size = New System.Drawing.Size(155, 21)
        Me.txtten_Kx.TabIndex = 7146
        Me.txtten_Kx.TabStop = False
        Me.txtten_Kx.Tag = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(455, 6)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 15)
        Me.Label3.TabIndex = 7145
        Me.Label3.Tag = "Advisor"
        Me.Label3.Text = "CVDV"
        '
        'TxtTen_HS_H
        '
        Me.TxtTen_HS_H.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTen_HS_H.Enabled = False
        Me.TxtTen_HS_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_HS_H.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtTen_HS_H.Location = New System.Drawing.Point(516, 4)
        Me.TxtTen_HS_H.Name = "TxtTen_HS_H"
        Me.TxtTen_HS_H.ReadOnly = True
        Me.TxtTen_HS_H.Size = New System.Drawing.Size(196, 21)
        Me.TxtTen_HS_H.TabIndex = 7144
        Me.TxtTen_HS_H.TabStop = False
        Me.TxtTen_HS_H.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(235, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 7143
        Me.Label1.Tag = "End"
        Me.Label1.Text = "Sửa xong"
        '
        'LblNgay_Ct
        '
        Me.LblNgay_Ct.AutoSize = True
        Me.LblNgay_Ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNgay_Ct.ForeColor = System.Drawing.Color.DarkRed
        Me.LblNgay_Ct.Location = New System.Drawing.Point(6, 55)
        Me.LblNgay_Ct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNgay_Ct.Name = "LblNgay_Ct"
        Me.LblNgay_Ct.Size = New System.Drawing.Size(49, 15)
        Me.LblNgay_Ct.TabIndex = 7142
        Me.LblNgay_Ct.Tag = "Begin"
        Me.LblNgay_Ct.Text = "Bắt đầu"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.DarkRed
        Me.Label29.Location = New System.Drawing.Point(6, 32)
        Me.Label29.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(58, 15)
        Me.Label29.TabIndex = 7141
        Me.Label29.Tag = "Costs total"
        Me.Label29.Text = "Tổng tiền"
        '
        'TxtT_TT
        '
        Me.TxtT_TT.AllowNegative = True
        Me.TxtT_TT.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtT_TT.Flags = 7680
        Me.TxtT_TT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_TT.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtT_TT.InputMask = "### ### ### ### ### ###"
        Me.TxtT_TT.Location = New System.Drawing.Point(65, 28)
        Me.TxtT_TT.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtT_TT.MaxWholeDigits = 17
        Me.TxtT_TT.Name = "TxtT_TT"
        Me.TxtT_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_TT.ReadOnly = True
        Me.TxtT_TT.Size = New System.Drawing.Size(155, 21)
        Me.TxtT_TT.TabIndex = 7140
        Me.TxtT_TT.TabStop = False
        Me.TxtT_TT.Text = "0"
        Me.TxtT_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkRed
        Me.Label21.Location = New System.Drawing.Point(235, 28)
        Me.Label21.Margin = New System.Windows.Forms.Padding(0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(57, 15)
        Me.Label21.TabIndex = 7139
        Me.Label21.Tag = "Model"
        Me.Label21.Text = "Kiểu xe"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(6, 6)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 7138
        Me.Label5.Tag = "R/O"
        Me.Label5.Text = "Số lệnh"
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.BackColor = System.Drawing.Color.Lavender
        Me.TxtSo_Ro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_Ro.Location = New System.Drawing.Point(65, 4)
        Me.TxtSo_Ro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(155, 21)
        Me.TxtSo_Ro.TabIndex = 7136
        Me.TxtSo_Ro.TabStop = False
        Me.TxtSo_Ro.Tag = ""
        Me.TxtSo_Ro.Text = "01.S15000001"
        Me.TxtSo_Ro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtMa_Xe.Location = New System.Drawing.Point(295, 4)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.ReadOnly = True
        Me.TxtMa_Xe.Size = New System.Drawing.Size(155, 21)
        Me.TxtMa_Xe.TabIndex = 7135
        Me.TxtMa_Xe.TabStop = False
        Me.TxtMa_Xe.Tag = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(235, 6)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 7137
        Me.Label4.Tag = "Plate"
        Me.Label4.Text = "Biển số"
        '
        'TxtTG_SC_RO
        '
        Me.TxtTG_SC_RO.AllowNegative = True
        Me.TxtTG_SC_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTG_SC_RO.Flags = 7680
        Me.TxtTG_SC_RO.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtTG_SC_RO.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtTG_SC_RO.InputMask = "### ### ### ### ### ###"
        Me.TxtTG_SC_RO.Location = New System.Drawing.Point(65, 77)
        Me.TxtTG_SC_RO.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTG_SC_RO.MaxWholeDigits = 17
        Me.TxtTG_SC_RO.Name = "TxtTG_SC_RO"
        Me.TxtTG_SC_RO.RangeMax = 1.7976931348623157E+308R
        Me.TxtTG_SC_RO.RangeMin = -1.7976931348623157E+308R
        Me.TxtTG_SC_RO.ReadOnly = True
        Me.TxtTG_SC_RO.Size = New System.Drawing.Size(155, 22)
        Me.TxtTG_SC_RO.TabIndex = 7192
        Me.TxtTG_SC_RO.Text = "0"
        Me.TxtTG_SC_RO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtStt_Rec.Location = New System.Drawing.Point(761, 417)
        Me.TxtStt_Rec.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.ReadOnly = True
        Me.TxtStt_Rec.Size = New System.Drawing.Size(48, 21)
        Me.TxtStt_Rec.TabIndex = 7193
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Tag = ""
        Me.TxtStt_Rec.Visible = False
        '
        'TxtStt_Rec_RO
        '
        Me.TxtStt_Rec_RO.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtStt_Rec_RO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec_RO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec_RO.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtStt_Rec_RO.Location = New System.Drawing.Point(827, 417)
        Me.TxtStt_Rec_RO.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec_RO.Name = "TxtStt_Rec_RO"
        Me.TxtStt_Rec_RO.ReadOnly = True
        Me.TxtStt_Rec_RO.Size = New System.Drawing.Size(48, 21)
        Me.TxtStt_Rec_RO.TabIndex = 7194
        Me.TxtStt_Rec_RO.TabStop = False
        Me.TxtStt_Rec_RO.Tag = ""
        Me.TxtStt_Rec_RO.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(6, 81)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 15)
        Me.Label7.TabIndex = 7195
        Me.Label7.Tag = "Time"
        Me.Label7.Text = "T/G SC"
        '
        'ChkKhong_doi
        '
        Me.ChkKhong_doi.AutoSize = True
        Me.ChkKhong_doi.Enabled = False
        Me.ChkKhong_doi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkKhong_doi.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkKhong_doi.Location = New System.Drawing.Point(1152, 113)
        Me.ChkKhong_doi.Name = "ChkKhong_doi"
        Me.ChkKhong_doi.Size = New System.Drawing.Size(94, 17)
        Me.ChkKhong_doi.TabIndex = 7255
        Me.ChkKhong_doi.TabStop = False
        Me.ChkKhong_doi.Tag = "No Wait"
        Me.ChkKhong_doi.Text = "KH Không Đợi"
        Me.ChkKhong_doi.UseVisualStyleBackColor = True
        '
        'ChkIs_Doi
        '
        Me.ChkIs_Doi.AutoSize = True
        Me.ChkIs_Doi.Enabled = False
        Me.ChkIs_Doi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIs_Doi.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkIs_Doi.Location = New System.Drawing.Point(1152, 91)
        Me.ChkIs_Doi.Name = "ChkIs_Doi"
        Me.ChkIs_Doi.Size = New System.Drawing.Size(60, 17)
        Me.ChkIs_Doi.TabIndex = 7254
        Me.ChkIs_Doi.TabStop = False
        Me.ChkIs_Doi.Tag = "Waiting"
        Me.ChkIs_Doi.Text = "KH Đợi"
        Me.ChkIs_Doi.UseVisualStyleBackColor = True
        '
        'ChkIs_None
        '
        Me.ChkIs_None.AutoSize = True
        Me.ChkIs_None.Enabled = False
        Me.ChkIs_None.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIs_None.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkIs_None.Location = New System.Drawing.Point(955, 103)
        Me.ChkIs_None.Name = "ChkIs_None"
        Me.ChkIs_None.Size = New System.Drawing.Size(68, 17)
        Me.ChkIs_None.TabIndex = 7252
        Me.ChkIs_None.TabStop = False
        Me.ChkIs_None.Tag = "Non origin"
        Me.ChkIs_None.Text = "Xe ngoài"
        Me.ChkIs_None.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkIs_None.UseVisualStyleBackColor = True
        '
        'ChkUT
        '
        Me.ChkUT.AutoSize = True
        Me.ChkUT.Enabled = False
        Me.ChkUT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkUT.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkUT.Location = New System.Drawing.Point(955, 82)
        Me.ChkUT.Name = "ChkUT"
        Me.ChkUT.Size = New System.Drawing.Size(74, 17)
        Me.ChkUT.TabIndex = 7253
        Me.ChkUT.TabStop = False
        Me.ChkUT.Tag = "Priority"
        Me.ChkUT.Text = "Xe ưu tiên"
        Me.ChkUT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkUT.UseVisualStyleBackColor = True
        '
        'ChkHen
        '
        Me.ChkHen.AutoSize = True
        Me.ChkHen.Enabled = False
        Me.ChkHen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkHen.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkHen.Location = New System.Drawing.Point(770, 82)
        Me.ChkHen.Name = "ChkHen"
        Me.ChkHen.Size = New System.Drawing.Size(46, 17)
        Me.ChkHen.TabIndex = 7251
        Me.ChkHen.TabStop = False
        Me.ChkHen.Tag = "Appointment"
        Me.ChkHen.Text = "Hẹn"
        Me.ChkHen.UseVisualStyleBackColor = True
        '
        'ChkPM90
        '
        Me.ChkPM90.AutoSize = True
        Me.ChkPM90.Enabled = False
        Me.ChkPM90.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkPM90.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkPM90.Location = New System.Drawing.Point(870, 103)
        Me.ChkPM90.Name = "ChkPM90"
        Me.ChkPM90.Size = New System.Drawing.Size(57, 17)
        Me.ChkPM90.TabIndex = 7250
        Me.ChkPM90.TabStop = False
        Me.ChkPM90.Tag = "PM90"
        Me.ChkPM90.Text = "PM 90"
        Me.ChkPM90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkPM90.UseVisualStyleBackColor = True
        '
        'ChkIs_3D
        '
        Me.ChkIs_3D.AutoSize = True
        Me.ChkIs_3D.Enabled = False
        Me.ChkIs_3D.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIs_3D.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkIs_3D.Location = New System.Drawing.Point(1035, 82)
        Me.ChkIs_3D.Name = "ChkIs_3D"
        Me.ChkIs_3D.Size = New System.Drawing.Size(58, 17)
        Me.ChkIs_3D.TabIndex = 7249
        Me.ChkIs_3D.TabStop = False
        Me.ChkIs_3D.Tag = "3 day"
        Me.ChkIs_3D.Text = "3 ngày"
        Me.ChkIs_3D.UseVisualStyleBackColor = True
        '
        'ChkEM60
        '
        Me.ChkEM60.AutoSize = True
        Me.ChkEM60.Enabled = False
        Me.ChkEM60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkEM60.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkEM60.Location = New System.Drawing.Point(870, 82)
        Me.ChkEM60.Name = "ChkEM60"
        Me.ChkEM60.Size = New System.Drawing.Size(57, 17)
        Me.ChkEM60.TabIndex = 7248
        Me.ChkEM60.TabStop = False
        Me.ChkEM60.Tag = "EM60"
        Me.ChkEM60.Text = "EM 60"
        Me.ChkEM60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkEM60.UseVisualStyleBackColor = True
        '
        'Chkfirst_visit
        '
        Me.Chkfirst_visit.AutoSize = True
        Me.Chkfirst_visit.Enabled = False
        Me.Chkfirst_visit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkfirst_visit.ForeColor = System.Drawing.Color.DarkRed
        Me.Chkfirst_visit.Location = New System.Drawing.Point(1152, 72)
        Me.Chkfirst_visit.Name = "Chkfirst_visit"
        Me.Chkfirst_visit.Size = New System.Drawing.Size(66, 17)
        Me.Chkfirst_visit.TabIndex = 7247
        Me.Chkfirst_visit.TabStop = False
        Me.Chkfirst_visit.Tag = "First visit"
        Me.Chkfirst_visit.Text = "First visit"
        Me.Chkfirst_visit.UseVisualStyleBackColor = True
        '
        'ChkIs_NonFir
        '
        Me.ChkIs_NonFir.AutoSize = True
        Me.ChkIs_NonFir.Enabled = False
        Me.ChkIs_NonFir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIs_NonFir.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkIs_NonFir.Location = New System.Drawing.Point(1152, 50)
        Me.ChkIs_NonFir.Name = "ChkIs_NonFir"
        Me.ChkIs_NonFir.Size = New System.Drawing.Size(66, 17)
        Me.ChkIs_NonFir.TabIndex = 7246
        Me.ChkIs_NonFir.TabStop = False
        Me.ChkIs_NonFir.Tag = "Non FIR"
        Me.ChkIs_NonFir.Text = "Non FIR"
        Me.ChkIs_NonFir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkIs_NonFir.UseVisualStyleBackColor = True
        '
        'ChkSCL
        '
        Me.ChkSCL.AutoSize = True
        Me.ChkSCL.Enabled = False
        Me.ChkSCL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkSCL.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkSCL.Location = New System.Drawing.Point(1152, 9)
        Me.ChkSCL.Name = "ChkSCL"
        Me.ChkSCL.Size = New System.Drawing.Size(85, 17)
        Me.ChkSCL.TabIndex = 7245
        Me.ChkSCL.TabStop = False
        Me.ChkSCL.Tag = "Re-Fix"
        Me.ChkSCL.Text = "Sửa chữa lại"
        Me.ChkSCL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ChkSCL.UseVisualStyleBackColor = True
        '
        'ChkIs_PT
        '
        Me.ChkIs_PT.AutoSize = True
        Me.ChkIs_PT.Enabled = False
        Me.ChkIs_PT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIs_PT.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkIs_PT.Location = New System.Drawing.Point(770, 103)
        Me.ChkIs_PT.Name = "ChkIs_PT"
        Me.ChkIs_PT.Size = New System.Drawing.Size(60, 17)
        Me.ChkIs_PT.TabIndex = 7244
        Me.ChkIs_PT.TabStop = False
        Me.ChkIs_PT.Tag = "Keep spare"
        Me.ChkIs_PT.Text = "Lấy PT"
        Me.ChkIs_PT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkIs_PT.UseVisualStyleBackColor = True
        '
        'ChkIs_Rua
        '
        Me.ChkIs_Rua.AutoSize = True
        Me.ChkIs_Rua.Enabled = False
        Me.ChkIs_Rua.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIs_Rua.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkIs_Rua.Location = New System.Drawing.Point(1152, 30)
        Me.ChkIs_Rua.Name = "ChkIs_Rua"
        Me.ChkIs_Rua.Size = New System.Drawing.Size(60, 17)
        Me.ChkIs_Rua.TabIndex = 7243
        Me.ChkIs_Rua.TabStop = False
        Me.ChkIs_Rua.Tag = "Washing"
        Me.ChkIs_Rua.Text = "Rửa xe"
        Me.ChkIs_Rua.UseVisualStyleBackColor = True
        '
        'ChkIs_W
        '
        Me.ChkIs_W.AutoSize = True
        Me.ChkIs_W.Enabled = False
        Me.ChkIs_W.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkIs_W.ForeColor = System.Drawing.Color.DarkRed
        Me.ChkIs_W.Location = New System.Drawing.Point(1035, 103)
        Me.ChkIs_W.Name = "ChkIs_W"
        Me.ChkIs_W.Size = New System.Drawing.Size(72, 17)
        Me.ChkIs_W.TabIndex = 7242
        Me.ChkIs_W.TabStop = False
        Me.ChkIs_W.Tag = "Warranty"
        Me.ChkIs_W.Text = "Bảo hành"
        Me.ChkIs_W.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkIs_W.UseVisualStyleBackColor = True
        '
        'CmdXem_Giao_Xe
        '
        Me.CmdXem_Giao_Xe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdXem_Giao_Xe.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmdXem_Giao_Xe.Location = New System.Drawing.Point(659, 417)
        Me.CmdXem_Giao_Xe.Name = "CmdXem_Giao_Xe"
        Me.CmdXem_Giao_Xe.Size = New System.Drawing.Size(97, 30)
        Me.CmdXem_Giao_Xe.TabIndex = 7259
        Me.CmdXem_Giao_Xe.Tag = "Delivery"
        Me.CmdXem_Giao_Xe.Text = "Giao xe"
        Me.CmdXem_Giao_Xe.UseVisualStyleBackColor = True
        '
        'ÇmdNang_Luc_Xuong
        '
        Me.ÇmdNang_Luc_Xuong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ÇmdNang_Luc_Xuong.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ÇmdNang_Luc_Xuong.Location = New System.Drawing.Point(955, 417)
        Me.ÇmdNang_Luc_Xuong.Name = "ÇmdNang_Luc_Xuong"
        Me.ÇmdNang_Luc_Xuong.Size = New System.Drawing.Size(97, 30)
        Me.ÇmdNang_Luc_Xuong.TabIndex = 7258
        Me.ÇmdNang_Luc_Xuong.Tag = "Capacity"
        Me.ÇmdNang_Luc_Xuong.Text = "Năng lực xưởng"
        Me.ÇmdNang_Luc_Xuong.UseVisualStyleBackColor = True
        '
        'ÇmdXem_LSSC
        '
        Me.ÇmdXem_LSSC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ÇmdXem_LSSC.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ÇmdXem_LSSC.Location = New System.Drawing.Point(758, 417)
        Me.ÇmdXem_LSSC.Name = "ÇmdXem_LSSC"
        Me.ÇmdXem_LSSC.Size = New System.Drawing.Size(97, 30)
        Me.ÇmdXem_LSSC.TabIndex = 7256
        Me.ÇmdXem_LSSC.Tag = "Repair history"
        Me.ÇmdXem_LSSC.Text = "Lịch sử sửa chữa"
        Me.ÇmdXem_LSSC.UseVisualStyleBackColor = True
        '
        'ÇmdXem_LS_Hen
        '
        Me.ÇmdXem_LS_Hen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ÇmdXem_LS_Hen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ÇmdXem_LS_Hen.Location = New System.Drawing.Point(857, 417)
        Me.ÇmdXem_LS_Hen.Name = "ÇmdXem_LS_Hen"
        Me.ÇmdXem_LS_Hen.Size = New System.Drawing.Size(97, 30)
        Me.ÇmdXem_LS_Hen.TabIndex = 7257
        Me.ÇmdXem_LS_Hen.Tag = "Appointment History"
        Me.ÇmdXem_LS_Hen.Text = "Lịch sử hẹn"
        Me.ÇmdXem_LS_Hen.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(6, 103)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(59, 15)
        Me.Label11.TabIndex = 7260
        Me.Label11.Tag = "Time"
        Me.Label11.Text = "Thêm giờ"
        '
        'TxtThem_Gio
        '
        Me.TxtThem_Gio.AllowNegative = True
        Me.TxtThem_Gio.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtThem_Gio.Flags = 7680
        Me.TxtThem_Gio.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtThem_Gio.ForeColor = System.Drawing.Color.Red
        Me.TxtThem_Gio.InputMask = "### ### ### ### ### ###"
        Me.TxtThem_Gio.Location = New System.Drawing.Point(65, 100)
        Me.TxtThem_Gio.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtThem_Gio.MaxWholeDigits = 17
        Me.TxtThem_Gio.Name = "TxtThem_Gio"
        Me.TxtThem_Gio.RangeMax = 1.7976931348623157E+308R
        Me.TxtThem_Gio.RangeMin = -1.7976931348623157E+308R
        Me.TxtThem_Gio.Size = New System.Drawing.Size(155, 22)
        Me.TxtThem_Gio.TabIndex = 7261
        Me.TxtThem_Gio.Text = "0"
        Me.TxtThem_Gio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(228, 103)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 15)
        Me.Label12.TabIndex = 7262
        Me.Label12.Tag = "Delivery"
        Me.Label12.Text = "(phút)"
        '
        'FrmCVDV_KH_SDSALL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1254, 471)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtThem_Gio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CmdXem_Giao_Xe)
        Me.Controls.Add(Me.ÇmdNang_Luc_Xuong)
        Me.Controls.Add(Me.ÇmdXem_LSSC)
        Me.Controls.Add(Me.ÇmdXem_LS_Hen)
        Me.Controls.Add(Me.ChkKhong_doi)
        Me.Controls.Add(Me.ChkIs_Doi)
        Me.Controls.Add(Me.ChkIs_None)
        Me.Controls.Add(Me.ChkUT)
        Me.Controls.Add(Me.ChkHen)
        Me.Controls.Add(Me.ChkPM90)
        Me.Controls.Add(Me.ChkIs_3D)
        Me.Controls.Add(Me.ChkEM60)
        Me.Controls.Add(Me.Chkfirst_visit)
        Me.Controls.Add(Me.ChkIs_NonFir)
        Me.Controls.Add(Me.ChkSCL)
        Me.Controls.Add(Me.ChkIs_PT)
        Me.Controls.Add(Me.ChkIs_Rua)
        Me.Controls.Add(Me.ChkIs_W)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtStt_Rec_RO)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtTG_SC_RO)
        Me.Controls.Add(Me.TxtNgay_henKT_RO)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtDT_LX)
        Me.Controls.Add(Me.ChkSDS)
        Me.Controls.Add(Me.CbbMuc_SBD)
        Me.Controls.Add(Me.CbbMuc_SDS)
        Me.Controls.Add(Me.ChkSBD)
        Me.Controls.Add(Me.ChkSCC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Lx)
        Me.Controls.Add(Me.TxtDien_Giai_RO)
        Me.Controls.Add(Me.txtTen_KH)
        Me.Controls.Add(Me.TxtNgay_KT_RO)
        Me.Controls.Add(Me.TxtNgay_BD_RO)
        Me.Controls.Add(Me.txtten_Kx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_HS_H)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblNgay_Ct)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.TxtT_TT)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSo_Ro)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Master)
        Me.Name = "FrmCVDV_KH_SDSALL"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label21, 0)
        Me.Controls.SetChildIndex(Me.TxtT_TT, 0)
        Me.Controls.SetChildIndex(Me.Label29, 0)
        Me.Controls.SetChildIndex(Me.LblNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS_H, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtten_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT_RO, 0)
        Me.Controls.SetChildIndex(Me.txtTen_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Lx, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.ChkSCC, 0)
        Me.Controls.SetChildIndex(Me.ChkSBD, 0)
        Me.Controls.SetChildIndex(Me.CbbMuc_SDS, 0)
        Me.Controls.SetChildIndex(Me.CbbMuc_SBD, 0)
        Me.Controls.SetChildIndex(Me.ChkSDS, 0)
        Me.Controls.SetChildIndex(Me.TxtDT_LX, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_henKT_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtTG_SC_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec_RO, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_W, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Rua, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_PT, 0)
        Me.Controls.SetChildIndex(Me.ChkSCL, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_NonFir, 0)
        Me.Controls.SetChildIndex(Me.Chkfirst_visit, 0)
        Me.Controls.SetChildIndex(Me.ChkEM60, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_3D, 0)
        Me.Controls.SetChildIndex(Me.ChkPM90, 0)
        Me.Controls.SetChildIndex(Me.ChkHen, 0)
        Me.Controls.SetChildIndex(Me.ChkUT, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_None, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Doi, 0)
        Me.Controls.SetChildIndex(Me.ChkKhong_doi, 0)
        Me.Controls.SetChildIndex(Me.ÇmdXem_LS_Hen, 0)
        Me.Controls.SetChildIndex(Me.ÇmdXem_LSSC, 0)
        Me.Controls.SetChildIndex(Me.ÇmdNang_Luc_Xuong, 0)
        Me.Controls.SetChildIndex(Me.CmdXem_Giao_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtThem_Gio, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TxtNgay_henKT_RO As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtDT_LX As System.Windows.Forms.TextBox
    Friend WithEvents ChkSDS As System.Windows.Forms.CheckBox
    Friend WithEvents CbbMuc_SBD As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMuc_SDS As System.Windows.Forms.ComboBox
    Friend WithEvents ChkSBD As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSCC As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Lx As System.Windows.Forms.TextBox
    Friend WithEvents TxtDien_Giai_RO As System.Windows.Forms.TextBox
    Friend WithEvents txtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents TxtNgay_KT_RO As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_BD_RO As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents txtten_Kx As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_HS_H As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents TxtT_TT As ClsTextBox.txtTien_NT
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ro As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTG_SC_RO As ClsTextBox.txtTien_NT
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec_RO As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ChkKhong_doi As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_Doi As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_None As System.Windows.Forms.CheckBox
    Friend WithEvents ChkUT As System.Windows.Forms.CheckBox
    Friend WithEvents ChkHen As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPM90 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_3D As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEM60 As System.Windows.Forms.CheckBox
    Friend WithEvents Chkfirst_visit As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_NonFir As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSCL As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_PT As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_Rua As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_W As System.Windows.Forms.CheckBox
    Friend WithEvents CmdXem_Giao_Xe As System.Windows.Forms.Button
    Friend WithEvents ÇmdNang_Luc_Xuong As System.Windows.Forms.Button
    Friend WithEvents ÇmdXem_LSSC As System.Windows.Forms.Button
    Friend WithEvents ÇmdXem_LS_Hen As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtThem_Gio As ClsTextBox.txtTien_NT
    Friend WithEvents Label12 As System.Windows.Forms.Label

End Class
