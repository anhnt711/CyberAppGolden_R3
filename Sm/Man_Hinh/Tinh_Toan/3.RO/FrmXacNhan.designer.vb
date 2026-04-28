<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmXacNhan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmXacNhan))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdSearch = New DevExpress.XtraEditors.SimpleButton()
        Me.btnXac_nhan = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtTen = New System.Windows.Forms.Label()
        Me.TxtMa = New Cyber.SmLists.TxtLookup()
        Me.lblMa = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSo_Ro = New System.Windows.Forms.TextBox()
        Me.TxtTien = New ClsTextBox.txtTien_NT()
        Me.LabGt_XN = New System.Windows.Forms.Label()
        Me.TxtNgay_ct1 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.txtGhi_chu = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ChkQC1 = New System.Windows.Forms.CheckBox()
        Me.ChkQC2 = New System.Windows.Forms.CheckBox()
        Me.ChkQC3 = New System.Windows.Forms.CheckBox()
        Me.lblQC = New System.Windows.Forms.Label()
        Me.txtCoupon = New System.Windows.Forms.TextBox()
        Me.lblCoupon = New System.Windows.Forms.Label()
        Me.TxtNgay_ct2 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.lblTrang_Thai = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtMa_xe = New System.Windows.Forms.TextBox()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TxtT_TT = New ClsTextBox.txtTien_NT()
        Me.LabGT_Lenh = New System.Windows.Forms.Label()
        Me.btnChi_tiet = New DevExpress.XtraEditors.SimpleButton()
        Me.txtStt_rec = New Cyber.SmLists.TxtLookup()
        Me.lblLoai_ct = New System.Windows.Forms.Label()
        Me.CbBMa_TT = New System.Windows.Forms.ComboBox()
        Me.TxtTen_kh = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.txtTen_BP = New System.Windows.Forms.TextBox()
        Me.TxtMa_Bp = New Cyber.SmLists.TxtLookup()
        Me.LabKH = New System.Windows.Forms.Label()
        Me.TxtT_C = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSo_Ro_Loc = New System.Windows.Forms.TextBox()
        Me.LabeMa_Bp = New System.Windows.Forms.Label()
        CType(Me.TxtMa.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtStt_rec.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Bp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 583)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1018, 8)
        Me.GroupBoxLine.Visible = False
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(698, 580)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtOK.TabIndex = 13
        Me.ButtOK.TabStop = False
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ButtExit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseFont = True
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(869, 4)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtExit.Size = New System.Drawing.Size(119, 33)
        Me.ButtExit.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(6, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 400
        Me.Label2.Tag = "Date from"
        Me.Label2.Text = "Từ ngày"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(248, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 401
        Me.Label1.Tag = "Date to"
        Me.Label1.Text = "Đến ngày"
        '
        'CmdSearch
        '
        Me.CmdSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.CmdSearch.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSearch.Appearance.Options.UseFont = True
        Me.CmdSearch.Appearance.Options.UseForeColor = True
        Me.CmdSearch.Image = CType(resources.GetObject("CmdSearch.Image"), System.Drawing.Image)
        Me.CmdSearch.Location = New System.Drawing.Point(869, 149)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(119, 32)
        Me.CmdSearch.TabIndex = 12
        Me.CmdSearch.Tag = "&Search"
        Me.CmdSearch.Text = "&Tìm kiếm"
        '
        'btnXac_nhan
        '
        Me.btnXac_nhan.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnXac_nhan.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.btnXac_nhan.Appearance.Options.UseFont = True
        Me.btnXac_nhan.Appearance.Options.UseForeColor = True
        Me.btnXac_nhan.Image = CType(resources.GetObject("btnXac_nhan.Image"), System.Drawing.Image)
        Me.btnXac_nhan.Location = New System.Drawing.Point(745, 4)
        Me.btnXac_nhan.Name = "btnXac_nhan"
        Me.btnXac_nhan.Size = New System.Drawing.Size(119, 33)
        Me.btnXac_nhan.TabIndex = 6
        Me.btnXac_nhan.Tag = "&Confirm"
        Me.btnXac_nhan.Text = "&Xác nhận"
        '
        'TxtTen
        '
        Me.TxtTen.BackColor = System.Drawing.Color.White
        Me.TxtTen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen.Location = New System.Drawing.Point(465, 7)
        Me.TxtTen.Name = "TxtTen"
        Me.TxtTen.Size = New System.Drawing.Size(271, 14)
        Me.TxtTen.TabIndex = 549
        Me.TxtTen.Tag = "Group 4"
        '
        'TxtMa
        '
        Me.TxtMa._ActilookupPopup = False
        Me.TxtMa.CyberActilookupPopup = True
        Me.TxtMa.Dv_ListDetail = Nothing
        Me.TxtMa.Dv_Master = Nothing
        Me.TxtMa.FilterClient = Nothing
        Me.TxtMa.FilterSQL = Nothing
        Me.TxtMa.Location = New System.Drawing.Point(322, 4)
        Me.TxtMa.Name = "TxtMa"
        Me.TxtMa.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa.Size = New System.Drawing.Size(107, 20)
        Me.TxtMa.TabIndex = 3
        Me.TxtMa.Table_Name = Nothing
        '
        'lblMa
        '
        Me.lblMa.AutoSize = True
        Me.lblMa.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblMa.Location = New System.Drawing.Point(242, 8)
        Me.lblMa.Name = "lblMa"
        Me.lblMa.Size = New System.Drawing.Size(37, 13)
        Me.lblMa.TabIndex = 548
        Me.lblMa.Tag = "Date from"
        Me.lblMa.Text = "Mã KH"
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(4, 140)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(983, 8)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(6, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 556
        Me.Label10.Tag = "R/O"
        Me.Label10.Text = "Số R/O"
        '
        'txtSo_Ro
        '
        Me.txtSo_Ro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_Ro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtSo_Ro.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_Ro.Location = New System.Drawing.Point(90, 4)
        Me.txtSo_Ro.Name = "txtSo_Ro"
        Me.txtSo_Ro.Size = New System.Drawing.Size(147, 21)
        Me.txtSo_Ro.TabIndex = 0
        '
        'TxtTien
        '
        Me.TxtTien.AllowNegative = True
        Me.TxtTien.BackColor = System.Drawing.Color.White
        Me.TxtTien.Flags = 7680
        Me.TxtTien.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTien.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien.InputMask = "### ### ### ### ###"
        Me.TxtTien.Location = New System.Drawing.Point(90, 52)
        Me.TxtTien.MaxWholeDigits = 14
        Me.TxtTien.Name = "TxtTien"
        Me.TxtTien.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien.Size = New System.Drawing.Size(147, 21)
        Me.TxtTien.TabIndex = 4
        Me.TxtTien.Text = "0"
        Me.TxtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGt_XN
        '
        Me.LabGt_XN.AutoSize = True
        Me.LabGt_XN.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabGt_XN.ForeColor = System.Drawing.Color.Navy
        Me.LabGt_XN.Location = New System.Drawing.Point(6, 56)
        Me.LabGt_XN.Name = "LabGt_XN"
        Me.LabGt_XN.Size = New System.Drawing.Size(82, 13)
        Me.LabGt_XN.TabIndex = 558
        Me.LabGt_XN.Tag = "Validated value"
        Me.LabGt_XN.Text = "Giá trị xác nhận"
        '
        'TxtNgay_ct1
        '
        Me.TxtNgay_ct1.Flags = 0
        Me.TxtNgay_ct1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_ct1.IsAllowResize = False
        Me.TxtNgay_ct1.Location = New System.Drawing.Point(90, 155)
        Me.TxtNgay_ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_ct1.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_ct1.MaxLength = 10
        Me.TxtNgay_ct1.Name = "TxtNgay_ct1"
        Me.TxtNgay_ct1.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_ct1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_ct1.Size = New System.Drawing.Size(147, 21)
        Me.TxtNgay_ct1.TabIndex = 8
        Me.TxtNgay_ct1.Text = "__/__/____ __:__"
        Me.TxtNgay_ct1.Value = CType(resources.GetObject("TxtNgay_ct1.Value"), Object)
        '
        'txtGhi_chu
        '
        Me.txtGhi_chu.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtGhi_chu.ForeColor = System.Drawing.Color.Navy
        Me.txtGhi_chu.Location = New System.Drawing.Point(90, 100)
        Me.txtGhi_chu.Multiline = True
        Me.txtGhi_chu.Name = "txtGhi_chu"
        Me.txtGhi_chu.Size = New System.Drawing.Size(339, 39)
        Me.txtGhi_chu.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(6, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 558
        Me.Label4.Tag = "Note"
        Me.Label4.Text = "Ghi chú"
        '
        'ChkQC1
        '
        Me.ChkQC1.AutoSize = True
        Me.ChkQC1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ChkQC1.Location = New System.Drawing.Point(322, 30)
        Me.ChkQC1.Name = "ChkQC1"
        Me.ChkQC1.Size = New System.Drawing.Size(32, 17)
        Me.ChkQC1.TabIndex = 4
        Me.ChkQC1.Text = "1"
        Me.ChkQC1.UseVisualStyleBackColor = True
        '
        'ChkQC2
        '
        Me.ChkQC2.AutoSize = True
        Me.ChkQC2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ChkQC2.Location = New System.Drawing.Point(378, 30)
        Me.ChkQC2.Name = "ChkQC2"
        Me.ChkQC2.Size = New System.Drawing.Size(32, 17)
        Me.ChkQC2.TabIndex = 3
        Me.ChkQC2.Text = "2"
        Me.ChkQC2.UseVisualStyleBackColor = True
        '
        'ChkQC3
        '
        Me.ChkQC3.AutoSize = True
        Me.ChkQC3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ChkQC3.Location = New System.Drawing.Point(434, 30)
        Me.ChkQC3.Name = "ChkQC3"
        Me.ChkQC3.Size = New System.Drawing.Size(32, 17)
        Me.ChkQC3.TabIndex = 6
        Me.ChkQC3.Text = "3"
        Me.ChkQC3.UseVisualStyleBackColor = True
        '
        'lblQC
        '
        Me.lblQC.AutoSize = True
        Me.lblQC.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblQC.Location = New System.Drawing.Point(242, 32)
        Me.lblQC.Name = "lblQC"
        Me.lblQC.Size = New System.Drawing.Size(22, 13)
        Me.lblQC.TabIndex = 548
        Me.lblQC.Tag = "Date from"
        Me.lblQC.Text = "QC"
        '
        'txtCoupon
        '
        Me.txtCoupon.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCoupon.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtCoupon.ForeColor = System.Drawing.Color.Navy
        Me.txtCoupon.Location = New System.Drawing.Point(322, 52)
        Me.txtCoupon.Name = "txtCoupon"
        Me.txtCoupon.Size = New System.Drawing.Size(107, 21)
        Me.txtCoupon.TabIndex = 5
        '
        'lblCoupon
        '
        Me.lblCoupon.AutoSize = True
        Me.lblCoupon.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblCoupon.ForeColor = System.Drawing.Color.Navy
        Me.lblCoupon.Location = New System.Drawing.Point(242, 56)
        Me.lblCoupon.Name = "lblCoupon"
        Me.lblCoupon.Size = New System.Drawing.Size(44, 13)
        Me.lblCoupon.TabIndex = 6
        Me.lblCoupon.Tag = "Coupon"
        Me.lblCoupon.Text = "Coupon"
        '
        'TxtNgay_ct2
        '
        Me.TxtNgay_ct2.Flags = 0
        Me.TxtNgay_ct2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_ct2.IsAllowResize = False
        Me.TxtNgay_ct2.Location = New System.Drawing.Point(322, 155)
        Me.TxtNgay_ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_ct2.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_ct2.MaxLength = 10
        Me.TxtNgay_ct2.Name = "TxtNgay_ct2"
        Me.TxtNgay_ct2.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_ct2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_ct2.Size = New System.Drawing.Size(138, 21)
        Me.TxtNgay_ct2.TabIndex = 9
        Me.TxtNgay_ct2.Text = "__/__/____ __:__"
        Me.TxtNgay_ct2.Value = CType(resources.GetObject("TxtNgay_ct2.Value"), Object)
        '
        'lblTrang_Thai
        '
        Me.lblTrang_Thai.Font = New System.Drawing.Font("Tahoma", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTrang_Thai.ForeColor = System.Drawing.Color.Red
        Me.lblTrang_Thai.Location = New System.Drawing.Point(435, 55)
        Me.lblTrang_Thai.Name = "lblTrang_Thai"
        Me.lblTrang_Thai.Size = New System.Drawing.Size(341, 26)
        Me.lblTrang_Thai.TabIndex = 558
        Me.lblTrang_Thai.Tag = "Group by"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(6, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 560
        Me.Label7.Tag = "Plates"
        Me.Label7.Text = "Biển số"
        '
        'txtMa_xe
        '
        Me.txtMa_xe.BackColor = System.Drawing.SystemColors.Info
        Me.txtMa_xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMa_xe.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtMa_xe.ForeColor = System.Drawing.Color.Blue
        Me.txtMa_xe.Location = New System.Drawing.Point(90, 28)
        Me.txtMa_xe.Name = "txtMa_xe"
        Me.txtMa_xe.Size = New System.Drawing.Size(147, 21)
        Me.txtMa_xe.TabIndex = 2
        Me.txtMa_xe.TabStop = False
        '
        'Master
        '
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(2, 186)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master.Size = New System.Drawing.Size(987, 361)
        Me.Master.TabIndex = 563
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
        Me.MasterGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV.OptionsView.ShowGroupPanel = False
        Me.MasterGRV.RowHeight = 21
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'TxtT_TT
        '
        Me.TxtT_TT.AllowNegative = True
        Me.TxtT_TT.BackColor = System.Drawing.SystemColors.Info
        Me.TxtT_TT.Flags = 7680
        Me.TxtT_TT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtT_TT.ForeColor = System.Drawing.Color.Blue
        Me.TxtT_TT.InputMask = "### ### ### ### ###"
        Me.TxtT_TT.Location = New System.Drawing.Point(322, 76)
        Me.TxtT_TT.MaxWholeDigits = 14
        Me.TxtT_TT.Name = "TxtT_TT"
        Me.TxtT_TT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_TT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_TT.ReadOnly = True
        Me.TxtT_TT.Size = New System.Drawing.Size(107, 21)
        Me.TxtT_TT.TabIndex = 564
        Me.TxtT_TT.Text = "0"
        Me.TxtT_TT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGT_Lenh
        '
        Me.LabGT_Lenh.AutoSize = True
        Me.LabGT_Lenh.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabGT_Lenh.ForeColor = System.Drawing.Color.Blue
        Me.LabGT_Lenh.Location = New System.Drawing.Point(243, 79)
        Me.LabGT_Lenh.Name = "LabGT_Lenh"
        Me.LabGT_Lenh.Size = New System.Drawing.Size(54, 13)
        Me.LabGT_Lenh.TabIndex = 565
        Me.LabGT_Lenh.Tag = "Total command"
        Me.LabGT_Lenh.Text = "Tổng lệnh"
        '
        'btnChi_tiet
        '
        Me.btnChi_tiet.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.btnChi_tiet.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.btnChi_tiet.Appearance.Options.UseFont = True
        Me.btnChi_tiet.Appearance.Options.UseForeColor = True
        Me.btnChi_tiet.Image = CType(resources.GetObject("btnChi_tiet.Image"), System.Drawing.Image)
        Me.btnChi_tiet.Location = New System.Drawing.Point(869, 106)
        Me.btnChi_tiet.Name = "btnChi_tiet"
        Me.btnChi_tiet.Size = New System.Drawing.Size(119, 33)
        Me.btnChi_tiet.TabIndex = 566
        Me.btnChi_tiet.Tag = "&Detail"
        Me.btnChi_tiet.Text = "&Chi tiết lệnh"
        '
        'txtStt_rec
        '
        Me.txtStt_rec._ActilookupPopup = False
        Me.txtStt_rec.CyberActilookupPopup = True
        Me.txtStt_rec.Dv_ListDetail = Nothing
        Me.txtStt_rec.Dv_Master = Nothing
        Me.txtStt_rec.FilterClient = Nothing
        Me.txtStt_rec.FilterSQL = Nothing
        Me.txtStt_rec.Location = New System.Drawing.Point(745, 152)
        Me.txtStt_rec.Name = "txtStt_rec"
        Me.txtStt_rec.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtStt_rec.Properties.Appearance.Options.UseForeColor = True
        Me.txtStt_rec.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtStt_rec.Size = New System.Drawing.Size(62, 20)
        Me.txtStt_rec.TabIndex = 567
        Me.txtStt_rec.Table_Name = Nothing
        Me.txtStt_rec.Visible = False
        '
        'lblLoai_ct
        '
        Me.lblLoai_ct.AutoSize = True
        Me.lblLoai_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoai_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblLoai_ct.Location = New System.Drawing.Point(524, 115)
        Me.lblLoai_ct.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLoai_ct.Name = "lblLoai_ct"
        Me.lblLoai_ct.Size = New System.Drawing.Size(121, 15)
        Me.lblLoai_ct.TabIndex = 569
        Me.lblLoai_ct.Tag = "Object payment"
        Me.lblLoai_ct.Text = "Đối tượng TT coupon"
        '
        'CbBMa_TT
        '
        Me.CbBMa_TT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbBMa_TT.ForeColor = System.Drawing.Color.Navy
        Me.CbBMa_TT.FormattingEnabled = True
        Me.CbBMa_TT.Location = New System.Drawing.Point(648, 113)
        Me.CbBMa_TT.Name = "CbBMa_TT"
        Me.CbBMa_TT.Size = New System.Drawing.Size(180, 21)
        Me.CbBMa_TT.TabIndex = 7
        '
        'TxtTen_kh
        '
        Me.TxtTen_kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh.Location = New System.Drawing.Point(434, 5)
        Me.TxtTen_kh.Name = "TxtTen_kh"
        Me.TxtTen_kh.ReadOnly = True
        Me.TxtTen_kh.Size = New System.Drawing.Size(305, 20)
        Me.TxtTen_kh.TabIndex = 1851
        Me.TxtTen_kh.TabStop = False
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(322, 5)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(107, 22)
        Me.TxtMa_Kh.TabIndex = 1
        Me.TxtMa_Kh.Table_Name = ""
        '
        'txtTen_BP
        '
        Me.txtTen_BP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTen_BP.BackColor = System.Drawing.Color.White
        Me.txtTen_BP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTen_BP.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_BP.Location = New System.Drawing.Point(456, 277)
        Me.txtTen_BP.Name = "txtTen_BP"
        Me.txtTen_BP.ReadOnly = True
        Me.txtTen_BP.Size = New System.Drawing.Size(303, 20)
        Me.txtTen_BP.TabIndex = 1856
        Me.txtTen_BP.TabStop = False
        '
        'TxtMa_Bp
        '
        Me.TxtMa_Bp._ActilookupPopup = False
        Me.TxtMa_Bp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Bp.CyberActilookupPopup = True
        Me.TxtMa_Bp.Dv_ListDetail = Nothing
        Me.TxtMa_Bp.Dv_Master = Nothing
        Me.TxtMa_Bp.FilterClient = ""
        Me.TxtMa_Bp.FilterSQL = ""
        Me.TxtMa_Bp.Location = New System.Drawing.Point(343, 277)
        Me.TxtMa_Bp.Name = "TxtMa_Bp"
        Me.TxtMa_Bp.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Bp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Bp.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Bp.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Bp.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Bp.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Bp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Bp.Size = New System.Drawing.Size(107, 20)
        Me.TxtMa_Bp.TabIndex = 3
        Me.TxtMa_Bp.Table_Name = ""
        '
        'LabKH
        '
        Me.LabKH.AutoSize = True
        Me.LabKH.ForeColor = System.Drawing.Color.Navy
        Me.LabKH.Location = New System.Drawing.Point(6, 79)
        Me.LabKH.Name = "LabKH"
        Me.LabKH.Size = New System.Drawing.Size(56, 13)
        Me.LabKH.TabIndex = 1989
        Me.LabKH.Tag = "Cus payment"
        Me.LabKH.Text = "KH T.toán"
        '
        'TxtT_C
        '
        Me.TxtT_C.AllowNegative = True
        Me.TxtT_C.BackColor = System.Drawing.Color.Lavender
        Me.TxtT_C.Flags = 7680
        Me.TxtT_C.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_C.InputMask = "### ### ### ### ###"
        Me.TxtT_C.Location = New System.Drawing.Point(90, 75)
        Me.TxtT_C.MaxWholeDigits = 14
        Me.TxtT_C.Name = "TxtT_C"
        Me.TxtT_C.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_C.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_C.ReadOnly = True
        Me.TxtT_C.Size = New System.Drawing.Size(147, 20)
        Me.TxtT_C.TabIndex = 1985
        Me.TxtT_C.TabStop = False
        Me.TxtT_C.Text = "0"
        Me.TxtT_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(507, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 1991
        Me.Label3.Tag = "R/O"
        Me.Label3.Text = "Số R/O Lọc"
        '
        'TxtSo_Ro_Loc
        '
        Me.TxtSo_Ro_Loc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro_Loc.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtSo_Ro_Loc.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ro_Loc.Location = New System.Drawing.Point(591, 155)
        Me.TxtSo_Ro_Loc.Name = "TxtSo_Ro_Loc"
        Me.TxtSo_Ro_Loc.Size = New System.Drawing.Size(147, 21)
        Me.TxtSo_Ro_Loc.TabIndex = 10
        '
        'LabeMa_Bp
        '
        Me.LabeMa_Bp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabeMa_Bp.BackColor = System.Drawing.Color.Transparent
        Me.LabeMa_Bp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabeMa_Bp.ForeColor = System.Drawing.Color.Navy
        Me.LabeMa_Bp.Location = New System.Drawing.Point(263, 280)
        Me.LabeMa_Bp.Margin = New System.Windows.Forms.Padding(0)
        Me.LabeMa_Bp.Name = "LabeMa_Bp"
        Me.LabeMa_Bp.Size = New System.Drawing.Size(63, 14)
        Me.LabeMa_Bp.TabIndex = 1855
        Me.LabeMa_Bp.Tag = "Department"
        Me.LabeMa_Bp.Text = "Bộ phận"
        '
        'FrmXacNhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(992, 573)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSo_Ro_Loc)
        Me.Controls.Add(Me.LabKH)
        Me.Controls.Add(Me.TxtT_C)
        Me.Controls.Add(Me.txtTen_BP)
        Me.Controls.Add(Me.TxtMa_Bp)
        Me.Controls.Add(Me.LabeMa_Bp)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.CbBMa_TT)
        Me.Controls.Add(Me.lblLoai_ct)
        Me.Controls.Add(Me.txtStt_rec)
        Me.Controls.Add(Me.btnChi_tiet)
        Me.Controls.Add(Me.TxtT_TT)
        Me.Controls.Add(Me.LabGT_Lenh)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMa_xe)
        Me.Controls.Add(Me.lblCoupon)
        Me.Controls.Add(Me.txtCoupon)
        Me.Controls.Add(Me.ChkQC3)
        Me.Controls.Add(Me.ChkQC2)
        Me.Controls.Add(Me.ChkQC1)
        Me.Controls.Add(Me.txtGhi_chu)
        Me.Controls.Add(Me.TxtNgay_ct2)
        Me.Controls.Add(Me.TxtNgay_ct1)
        Me.Controls.Add(Me.TxtTien)
        Me.Controls.Add(Me.lblTrang_Thai)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabGt_XN)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSo_Ro)
        Me.Controls.Add(Me.TxtTen)
        Me.Controls.Add(Me.lblQC)
        Me.Controls.Add(Me.lblMa)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.btnXac_nhan)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMa)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmXacNhan"
        Me.Text = "Xác nhận"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnXac_nhan, 0)
        Me.Controls.SetChildIndex(Me.CmdSearch, 0)
        Me.Controls.SetChildIndex(Me.lblMa, 0)
        Me.Controls.SetChildIndex(Me.lblQC, 0)
        Me.Controls.SetChildIndex(Me.TxtTen, 0)
        Me.Controls.SetChildIndex(Me.txtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.LabGt_XN, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.lblTrang_Thai, 0)
        Me.Controls.SetChildIndex(Me.TxtTien, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_ct2, 0)
        Me.Controls.SetChildIndex(Me.txtGhi_chu, 0)
        Me.Controls.SetChildIndex(Me.ChkQC1, 0)
        Me.Controls.SetChildIndex(Me.ChkQC2, 0)
        Me.Controls.SetChildIndex(Me.ChkQC3, 0)
        Me.Controls.SetChildIndex(Me.txtCoupon, 0)
        Me.Controls.SetChildIndex(Me.lblCoupon, 0)
        Me.Controls.SetChildIndex(Me.txtMa_xe, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.LabGT_Lenh, 0)
        Me.Controls.SetChildIndex(Me.TxtT_TT, 0)
        Me.Controls.SetChildIndex(Me.btnChi_tiet, 0)
        Me.Controls.SetChildIndex(Me.txtStt_rec, 0)
        Me.Controls.SetChildIndex(Me.lblLoai_ct, 0)
        Me.Controls.SetChildIndex(Me.CbBMa_TT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh, 0)
        Me.Controls.SetChildIndex(Me.LabeMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.txtTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtT_C, 0)
        Me.Controls.SetChildIndex(Me.LabKH, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro_Loc, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        CType(Me.TxtMa.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtStt_rec.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Bp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdSearch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnXac_nhan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtTen As System.Windows.Forms.Label
    Friend WithEvents TxtMa As Cyber.SmLists.TxtLookup
    Friend WithEvents lblMa As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSo_Ro As System.Windows.Forms.TextBox
    Friend WithEvents TxtTien As ClsTextBox.txtTien_NT
    Friend WithEvents LabGt_XN As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_ct1 As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents txtGhi_chu As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ChkQC1 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkQC2 As System.Windows.Forms.CheckBox
    Friend WithEvents ChkQC3 As System.Windows.Forms.CheckBox
    Friend WithEvents lblQC As System.Windows.Forms.Label
    Friend WithEvents txtCoupon As System.Windows.Forms.TextBox
    Friend WithEvents lblCoupon As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_ct2 As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents lblTrang_Thai As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMa_xe As System.Windows.Forms.TextBox
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TxtT_TT As ClsTextBox.txtTien_NT
    Friend WithEvents LabGT_Lenh As System.Windows.Forms.Label
    Friend WithEvents btnChi_tiet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtStt_rec As Cyber.SmLists.TxtLookup
    Friend WithEvents lblLoai_ct As System.Windows.Forms.Label
    Friend WithEvents CbBMa_TT As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTen_kh As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents txtTen_BP As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Bp As Cyber.SmLists.TxtLookup
    Friend WithEvents LabKH As System.Windows.Forms.Label
    Friend WithEvents TxtT_C As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ro_Loc As System.Windows.Forms.TextBox
    Friend WithEvents LabeMa_Bp As System.Windows.Forms.Label

End Class
