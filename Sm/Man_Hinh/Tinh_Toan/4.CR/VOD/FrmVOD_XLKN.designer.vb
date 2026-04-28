<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVOD_XLTM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVOD_XLTM))
        Me.btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Detail_Detail = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV_Detail = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Detail_Master = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV_Master = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnLoc = New DevExpress.XtraEditors.SimpleButton()
        Me.lblMaster = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct1 = New ClsTextBox.txtDate1()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.lblDetail = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSo_Ro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMa_xe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTen_Kh = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTen_Lx = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDien_thoai = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Kx = New System.Windows.Forms.Label()
        Me.lblMa = New System.Windows.Forms.Label()
        Me.TxtMa_kx = New Cyber.SmLists.TxtLookup()
        Me.txtTen_hd = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMa_hd = New Cyber.SmLists.TxtLookup()
        Me.txtTen_Hs = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtMa_hs = New Cyber.SmLists.TxtLookup()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV_Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail_Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV_Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_hd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 415)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1184, 10)
        Me.GroupBoxLine.Visible = False
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Enabled = False
        Me.ButtOK.Location = New System.Drawing.Point(986, 468)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtOK.Size = New System.Drawing.Size(177, 48)
        Me.ButtOK.TabIndex = 10
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Enabled = False
        Me.ButtExit.Location = New System.Drawing.Point(1088, 468)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtExit.Size = New System.Drawing.Size(177, 48)
        Me.ButtExit.TabIndex = 11
        Me.ButtExit.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.btnPrint.Appearance.Options.UseForeColor = True
        Me.btnPrint.Enabled = False
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Image)
        Me.btnPrint.Location = New System.Drawing.Point(986, 468)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(100, 30)
        Me.btnPrint.TabIndex = 0
        Me.btnPrint.TabStop = False
        Me.btnPrint.Text = "&In"
        Me.btnPrint.Visible = False
        '
        'GridView1
        '
        Me.GridView1.Name = "GridView1"
        '
        'GridView2
        '
        Me.GridView2.Name = "GridView2"
        '
        'GridView3
        '
        Me.GridView3.Name = "GridView3"
        '
        'Detail_Detail
        '
        Me.Detail_Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail_Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail_Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail_Detail.Location = New System.Drawing.Point(3, 38)
        Me.Detail_Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail_Detail.MainView = Me.DetailGRV_Detail
        Me.Detail_Detail.Name = "Detail_Detail"
        Me.Detail_Detail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4})
        Me.Detail_Detail.Size = New System.Drawing.Size(791, 422)
        Me.Detail_Detail.TabIndex = 0
        Me.Detail_Detail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV_Detail, Me.GridView6})
        '
        'DetailGRV_Detail
        '
        Me.DetailGRV_Detail.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailGRV_Detail.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV_Detail.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV_Detail.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV_Detail.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV_Detail.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DetailGRV_Detail.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DetailGRV_Detail.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV_Detail.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV_Detail.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV_Detail.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV_Detail.GridControl = Me.Detail_Detail
        Me.DetailGRV_Detail.GroupRowHeight = 30
        Me.DetailGRV_Detail.Name = "DetailGRV_Detail"
        Me.DetailGRV_Detail.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV_Detail.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV_Detail.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV_Detail.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV_Detail.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV_Detail.OptionsView.ShowGroupPanel = False
        Me.DetailGRV_Detail.RowHeight = 21
        '
        'RepositoryItemTextEdit3
        '
        Me.RepositoryItemTextEdit3.AutoHeight = False
        Me.RepositoryItemTextEdit3.Name = "RepositoryItemTextEdit3"
        '
        'RepositoryItemTextEdit4
        '
        Me.RepositoryItemTextEdit4.AutoHeight = False
        Me.RepositoryItemTextEdit4.Name = "RepositoryItemTextEdit4"
        '
        'GridView6
        '
        Me.GridView6.GridControl = Me.Detail_Detail
        Me.GridView6.Name = "GridView6"
        '
        'Detail_Master
        '
        Me.Detail_Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail_Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail_Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail_Master.Location = New System.Drawing.Point(3, 38)
        Me.Detail_Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail_Master.MainView = Me.DetailGRV_Master
        Me.Detail_Master.Name = "Detail_Master"
        Me.Detail_Master.Size = New System.Drawing.Size(378, 422)
        Me.Detail_Master.TabIndex = 0
        Me.Detail_Master.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV_Master, Me.GridView4})
        '
        'DetailGRV_Master
        '
        Me.DetailGRV_Master.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailGRV_Master.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV_Master.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV_Master.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV_Master.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV_Master.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DetailGRV_Master.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DetailGRV_Master.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV_Master.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV_Master.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV_Master.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV_Master.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV_Master.GridControl = Me.Detail_Master
        Me.DetailGRV_Master.GroupRowHeight = 30
        Me.DetailGRV_Master.Name = "DetailGRV_Master"
        Me.DetailGRV_Master.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV_Master.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV_Master.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV_Master.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV_Master.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV_Master.OptionsView.ShowGroupPanel = False
        Me.DetailGRV_Master.RowHeight = 21
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.Detail_Master
        Me.GridView4.Name = "GridView4"
        '
        'GridView5
        '
        Me.GridView5.Name = "GridView5"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnLoc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblMaster)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Detail_Master)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtNgay_Ct1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TxtNgay_Ct2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabM_Ngay_Ct1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.lblDetail)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Detail_Detail)
        Me.SplitContainer1.Size = New System.Drawing.Size(1186, 490)
        Me.SplitContainer1.SplitterDistance = 384
        Me.SplitContainer1.TabIndex = 397
        '
        'btnLoc
        '
        Me.btnLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLoc.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.btnLoc.Appearance.Options.UseForeColor = True
        Me.btnLoc.Location = New System.Drawing.Point(267, 462)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(72, 23)
        Me.btnLoc.TabIndex = 2
        Me.btnLoc.Tag = "Fillter"
        Me.btnLoc.Text = "&Lọc "
        '
        'lblMaster
        '
        Me.lblMaster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblMaster.BackColor = System.Drawing.Color.Black
        Me.lblMaster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblMaster.ForeColor = System.Drawing.Color.White
        Me.lblMaster.Location = New System.Drawing.Point(3, 4)
        Me.lblMaster.Name = "lblMaster"
        Me.lblMaster.Size = New System.Drawing.Size(378, 31)
        Me.lblMaster.TabIndex = 0
        Me.lblMaster.Text = "THẮC MẮC"
        Me.lblMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNgay_Ct1.Flags = 0
        Me.TxtNgay_Ct1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct1.IsAllowResize = False
        Me.TxtNgay_Ct1.isEmpty = True
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(39, 464)
        Me.TxtNgay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(94, 21)
        Me.TxtNgay_Ct1.TabIndex = 0
        Me.TxtNgay_Ct1.Text = "__/__/____"
        Me.TxtNgay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.Location = New System.Drawing.Point(137, 468)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 1958
        Me.Label6.Tag = "Date from"
        Me.Label6.Text = "Đến"
        '
        'TxtNgay_Ct2
        '
        Me.TxtNgay_Ct2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNgay_Ct2.Flags = 0
        Me.TxtNgay_Ct2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct2.IsAllowResize = False
        Me.TxtNgay_Ct2.isEmpty = True
        Me.TxtNgay_Ct2.Location = New System.Drawing.Point(170, 464)
        Me.TxtNgay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct2.MaxLength = 10
        Me.TxtNgay_Ct2.Name = "TxtNgay_Ct2"
        Me.TxtNgay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct2.Size = New System.Drawing.Size(94, 21)
        Me.TxtNgay_Ct2.TabIndex = 1
        Me.TxtNgay_Ct2.Text = "__/__/____"
        Me.TxtNgay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(5, 468)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(20, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 1957
        Me.LabM_Ngay_Ct1.Tag = "from"
        Me.LabM_Ngay_Ct1.Text = "Từ"
        '
        'lblDetail
        '
        Me.lblDetail.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDetail.BackColor = System.Drawing.Color.Black
        Me.lblDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lblDetail.ForeColor = System.Drawing.Color.White
        Me.lblDetail.Location = New System.Drawing.Point(3, 4)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(791, 31)
        Me.lblDetail.TabIndex = 399
        Me.lblDetail.Text = "GIẢI QUYẾT"
        Me.lblDetail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(795, 485)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 558
        Me.Label10.Text = "Số R/O"
        Me.Label10.Visible = False
        '
        'txtSo_Ro
        '
        Me.txtSo_Ro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSo_Ro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_Ro.Enabled = False
        Me.txtSo_Ro.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtSo_Ro.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_Ro.Location = New System.Drawing.Point(755, 481)
        Me.txtSo_Ro.Name = "txtSo_Ro"
        Me.txtSo_Ro.Size = New System.Drawing.Size(127, 21)
        Me.txtSo_Ro.TabIndex = 2
        Me.txtSo_Ro.Visible = False
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(795, 485)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 560
        Me.Label1.Text = "Biển số"
        Me.Label1.Visible = False
        '
        'txtMa_xe
        '
        Me.txtMa_xe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtMa_xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMa_xe.Enabled = False
        Me.txtMa_xe.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtMa_xe.ForeColor = System.Drawing.Color.Navy
        Me.txtMa_xe.Location = New System.Drawing.Point(742, 481)
        Me.txtMa_xe.Name = "txtMa_xe"
        Me.txtMa_xe.Size = New System.Drawing.Size(152, 21)
        Me.txtMa_xe.TabIndex = 3
        Me.txtMa_xe.Visible = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(761, 498)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 562
        Me.Label2.Text = "Tên khách hàng"
        Me.Label2.Visible = False
        '
        'txtTen_Kh
        '
        Me.txtTen_Kh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTen_Kh.Enabled = False
        Me.txtTen_Kh.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTen_Kh.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Kh.Location = New System.Drawing.Point(607, 494)
        Me.txtTen_Kh.Name = "txtTen_Kh"
        Me.txtTen_Kh.Size = New System.Drawing.Size(404, 21)
        Me.txtTen_Kh.TabIndex = 4
        Me.txtTen_Kh.TabStop = False
        Me.txtTen_Kh.Visible = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(779, 498)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 564
        Me.Label3.Text = "Tên lái xe"
        Me.Label3.Visible = False
        '
        'txtTen_Lx
        '
        Me.txtTen_Lx.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTen_Lx.Enabled = False
        Me.txtTen_Lx.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTen_Lx.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Lx.Location = New System.Drawing.Point(733, 494)
        Me.txtTen_Lx.Name = "txtTen_Lx"
        Me.txtTen_Lx.Size = New System.Drawing.Size(152, 21)
        Me.txtTen_Lx.TabIndex = 3
        Me.txtTen_Lx.TabStop = False
        Me.txtTen_Lx.Visible = False
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(777, 498)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 568
        Me.Label4.Text = "Điện thoại"
        Me.Label4.Visible = False
        '
        'txtDien_thoai
        '
        Me.txtDien_thoai.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtDien_thoai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDien_thoai.Enabled = False
        Me.txtDien_thoai.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtDien_thoai.ForeColor = System.Drawing.Color.Navy
        Me.txtDien_thoai.Location = New System.Drawing.Point(746, 494)
        Me.txtDien_thoai.Name = "txtDien_thoai"
        Me.txtDien_thoai.Size = New System.Drawing.Size(127, 21)
        Me.txtDien_thoai.TabIndex = 2
        Me.txtDien_thoai.TabStop = False
        Me.txtDien_thoai.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(1250, 443)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 13)
        Me.Label5.TabIndex = 566
        Me.Label5.Text = "Số R/O"
        Me.Label5.Visible = False
        '
        'TextBox3
        '
        Me.TextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TextBox3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TextBox3.ForeColor = System.Drawing.Color.Navy
        Me.TextBox3.Location = New System.Drawing.Point(1308, 439)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(127, 21)
        Me.TextBox3.TabIndex = 565
        Me.TextBox3.Visible = False
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_Kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTen_Kx.Location = New System.Drawing.Point(674, 494)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.Size = New System.Drawing.Size(271, 20)
        Me.TxtTen_Kx.TabIndex = 571
        Me.TxtTen_Kx.Tag = "Group 4"
        Me.TxtTen_Kx.Visible = False
        '
        'lblMa
        '
        Me.lblMa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblMa.AutoSize = True
        Me.lblMa.Enabled = False
        Me.lblMa.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.lblMa.Location = New System.Drawing.Point(785, 498)
        Me.lblMa.Name = "lblMa"
        Me.lblMa.Size = New System.Drawing.Size(48, 13)
        Me.lblMa.TabIndex = 570
        Me.lblMa.Tag = "Date from"
        Me.lblMa.Text = "Kiểu xe"
        Me.lblMa.Visible = False
        '
        'TxtMa_kx
        '
        Me.TxtMa_kx._ActilookupPopup = False
        Me.TxtMa_kx.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_kx.CyberActilookupPopup = True
        Me.TxtMa_kx.Dv_ListDetail = Nothing
        Me.TxtMa_kx.Dv_Master = Nothing
        Me.TxtMa_kx.Enabled = False
        Me.TxtMa_kx.FilterClient = Nothing
        Me.TxtMa_kx.FilterSQL = Nothing
        Me.TxtMa_kx.Location = New System.Drawing.Point(746, 494)
        Me.TxtMa_kx.Name = "TxtMa_kx"
        Me.TxtMa_kx.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtMa_kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kx.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kx.Size = New System.Drawing.Size(127, 20)
        Me.TxtMa_kx.TabIndex = 5
        Me.TxtMa_kx.Table_Name = Nothing
        Me.TxtMa_kx.TabStop = False
        Me.TxtMa_kx.Visible = False
        '
        'txtTen_hd
        '
        Me.txtTen_hd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTen_hd.BackColor = System.Drawing.Color.White
        Me.txtTen_hd.Enabled = False
        Me.txtTen_hd.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTen_hd.Location = New System.Drawing.Point(566, 481)
        Me.txtTen_hd.Name = "txtTen_hd"
        Me.txtTen_hd.Size = New System.Drawing.Size(504, 20)
        Me.txtTen_hd.TabIndex = 574
        Me.txtTen_hd.Tag = "Group 4"
        Me.txtTen_hd.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(788, 485)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 13)
        Me.Label7.TabIndex = 573
        Me.Label7.Tag = "Date from"
        Me.Label7.Text = "Hợp đồng"
        Me.Label7.Visible = False
        '
        'TxtMa_hd
        '
        Me.TxtMa_hd._ActilookupPopup = False
        Me.TxtMa_hd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_hd.CyberActilookupPopup = True
        Me.TxtMa_hd.Dv_ListDetail = Nothing
        Me.TxtMa_hd.Dv_Master = Nothing
        Me.TxtMa_hd.Enabled = False
        Me.TxtMa_hd.FilterClient = Nothing
        Me.TxtMa_hd.FilterSQL = Nothing
        Me.TxtMa_hd.Location = New System.Drawing.Point(755, 481)
        Me.TxtMa_hd.Name = "TxtMa_hd"
        Me.TxtMa_hd.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtMa_hd.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_hd.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_hd.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_hd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_hd.Size = New System.Drawing.Size(127, 20)
        Me.TxtMa_hd.TabIndex = 4
        Me.TxtMa_hd.Table_Name = Nothing
        Me.TxtMa_hd.Visible = False
        '
        'txtTen_Hs
        '
        Me.txtTen_Hs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTen_Hs.BackColor = System.Drawing.Color.White
        Me.txtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txtTen_Hs.Enabled = False
        Me.txtTen_Hs.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTen_Hs.Location = New System.Drawing.Point(722, 494)
        Me.txtTen_Hs.Name = "txtTen_Hs"
        Me.txtTen_Hs.Size = New System.Drawing.Size(310, 20)
        Me.txtTen_Hs.TabIndex = 1961
        Me.txtTen_Hs.Tag = "Group 4"
        Me.txtTen_Hs.Visible = False
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(842, 498)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 13)
        Me.Label9.TabIndex = 1960
        Me.Label9.Tag = "Date from"
        Me.Label9.Text = "TVBH/CVDV"
        Me.Label9.Visible = False
        '
        'TxtMa_hs
        '
        Me.TxtMa_hs._ActilookupPopup = False
        Me.TxtMa_hs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_hs.CyberActilookupPopup = True
        Me.TxtMa_hs.Dv_ListDetail = Nothing
        Me.TxtMa_hs.Dv_Master = Nothing
        Me.TxtMa_hs.Enabled = False
        Me.TxtMa_hs.FilterClient = Nothing
        Me.TxtMa_hs.FilterSQL = Nothing
        Me.TxtMa_hs.Location = New System.Drawing.Point(814, 494)
        Me.TxtMa_hs.Name = "TxtMa_hs"
        Me.TxtMa_hs.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtMa_hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_hs.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_hs.Size = New System.Drawing.Size(127, 20)
        Me.TxtMa_hs.TabIndex = 9
        Me.TxtMa_hs.Table_Name = Nothing
        Me.TxtMa_hs.TabStop = False
        Me.TxtMa_hs.Visible = False
        '
        'FrmVOD_XLKN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1188, 523)
        Me.Controls.Add(Me.txtTen_Hs)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtMa_hs)
        Me.Controls.Add(Me.txtTen_hd)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMa_hd)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.lblMa)
        Me.Controls.Add(Me.TxtMa_kx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDien_thoai)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTen_Lx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTen_Kh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMa_xe)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtSo_Ro)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.btnPrint)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "FrmVOD_XLKN"
        Me.Text = "Xử lý khiếu nại"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.btnPrint, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.txtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.txtMa_xe, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Kh, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Lx, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TextBox3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtDien_thoai, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kx, 0)
        Me.Controls.SetChildIndex(Me.lblMa, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_hd, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtTen_hd, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_hs, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Hs, 0)
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV_Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail_Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV_Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_hd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Detail_Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV_Detail As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Detail_Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV_Master As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lblMaster As System.Windows.Forms.Label
    Friend WithEvents lblDetail As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSo_Ro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMa_xe As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTen_Kh As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTen_Lx As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDien_thoai As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.Label
    Friend WithEvents lblMa As System.Windows.Forms.Label
    Friend WithEvents TxtMa_kx As Cyber.SmLists.TxtLookup
    Friend WithEvents txtTen_hd As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_hd As Cyber.SmLists.TxtLookup
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents txtTen_Hs As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_hs As Cyber.SmLists.TxtLookup
    Friend WithEvents btnLoc As DevExpress.XtraEditors.SimpleButton

End Class
