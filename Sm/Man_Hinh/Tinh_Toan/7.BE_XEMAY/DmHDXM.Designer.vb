<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDmHDXM
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
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.CbbLoc_SL = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSCMT = New Cyber.SmLists.TxtLookup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CbbMa_TTCP = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CbbSearch = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtSDT = New Cyber.SmLists.TxtLookup()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct1 = New ClsTextBox.txtDate1()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.TxtSCMT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtSDT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 454)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1052, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(852, 464)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(954, 464)
        Me.ButtExit.TabStop = False
        '
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(200, 466)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(372, 20)
        Me.TxtSearch.TabIndex = 599
        '
        'CbbLoc_SL
        '
        Me.CbbLoc_SL.Location = New System.Drawing.Point(408, 27)
        Me.CbbLoc_SL.Name = "CbbLoc_SL"
        Me.CbbLoc_SL.Size = New System.Drawing.Size(120, 23)
        Me.CbbLoc_SL.TabIndex = 589
        Me.CbbLoc_SL.Text = "Lọc số liệu"
        Me.CbbLoc_SL.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(203, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 598
        Me.Label2.Tag = "Group 1"
        Me.Label2.Text = "Số chứng minh"
        '
        'TxtSCMT
        '
        Me.TxtSCMT._ActilookupPopup = False
        Me.TxtSCMT.CyberActilookupPopup = True
        Me.TxtSCMT.Dv_ListDetail = Nothing
        Me.TxtSCMT.Dv_Master = Nothing
        Me.TxtSCMT.FilterClient = ""
        Me.TxtSCMT.FilterSQL = ""
        Me.TxtSCMT.Location = New System.Drawing.Point(295, 27)
        Me.TxtSCMT.Name = "TxtSCMT"
        Me.TxtSCMT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtSCMT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtSCMT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtSCMT.Size = New System.Drawing.Size(110, 20)
        Me.TxtSCMT.TabIndex = 585
        Me.TxtSCMT.Table_Name = ""
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Location = New System.Drawing.Point(638, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 597
        Me.Label10.Tag = "Group 2"
        Me.Label10.Text = "Cửa hàng"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbbMa_TTCP
        '
        Me.CbbMa_TTCP.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_TTCP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TTCP.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TTCP.FormattingEnabled = True
        Me.CbbMa_TTCP.Location = New System.Drawing.Point(716, 4)
        Me.CbbMa_TTCP.Name = "CbbMa_TTCP"
        Me.CbbMa_TTCP.Size = New System.Drawing.Size(337, 21)
        Me.CbbMa_TTCP.TabIndex = 586
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 469)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 596
        Me.Label9.Tag = "Loại giao dịch"
        Me.Label9.Text = "Tìm kiếm"
        '
        'CbbSearch
        '
        Me.CbbSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbSearch.ForeColor = System.Drawing.Color.Navy
        Me.CbbSearch.FormattingEnabled = True
        Me.CbbSearch.Location = New System.Drawing.Point(64, 465)
        Me.CbbSearch.Name = "CbbSearch"
        Me.CbbSearch.Size = New System.Drawing.Size(130, 21)
        Me.CbbSearch.TabIndex = 590
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 13)
        Me.Label8.TabIndex = 595
        Me.Label8.Tag = "Group 1"
        Me.Label8.Text = "Điện thoại"
        '
        'TxtSDT
        '
        Me.TxtSDT._ActilookupPopup = False
        Me.TxtSDT.CyberActilookupPopup = True
        Me.TxtSDT.Dv_ListDetail = Nothing
        Me.TxtSDT.Dv_Master = Nothing
        Me.TxtSDT.FilterClient = ""
        Me.TxtSDT.FilterSQL = ""
        Me.TxtSDT.Location = New System.Drawing.Point(82, 28)
        Me.TxtSDT.Name = "TxtSDT"
        Me.TxtSDT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtSDT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtSDT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtSDT.Size = New System.Drawing.Size(110, 20)
        Me.TxtSDT.TabIndex = 584
        Me.TxtSDT.Table_Name = ""
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.Location = New System.Drawing.Point(638, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 594
        Me.Label7.Tag = "Group 1"
        Me.Label7.Text = "Khách hàng"
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(716, 28)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Kh.TabIndex = 587
        Me.TxtMa_Kh.Table_Name = ""
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(719, 27)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(330, 13)
        Me.TxtTen_Kx.TabIndex = 588
        Me.TxtTen_Kx.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 593
        Me.Label1.Tag = "Date from"
        Me.Label1.Text = "Đến ngày"
        '
        'TxtNgay_Ct2
        '
        Me.TxtNgay_Ct2.Flags = 0
        Me.TxtNgay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct2.IsAllowResize = False
        Me.TxtNgay_Ct2.isEmpty = True
        Me.TxtNgay_Ct2.Location = New System.Drawing.Point(295, 5)
        Me.TxtNgay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct2.MaxLength = 10
        Me.TxtNgay_Ct2.Name = "TxtNgay_Ct2"
        Me.TxtNgay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct2.Size = New System.Drawing.Size(110, 20)
        Me.TxtNgay_Ct2.TabIndex = 583
        Me.TxtNgay_Ct2.Text = "__/__/____"
        Me.TxtNgay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(8, 8)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(46, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 592
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.Flags = 0
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct1.IsAllowResize = False
        Me.TxtNgay_Ct1.isEmpty = True
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(82, 5)
        Me.TxtNgay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(110, 20)
        Me.TxtNgay_Ct1.TabIndex = 582
        Me.TxtNgay_Ct1.Text = "__/__/____"
        Me.TxtNgay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(1, 53)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master.Size = New System.Drawing.Size(1054, 408)
        Me.Master.TabIndex = 591
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
        Me.MasterGRV.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
        Me.MasterGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1056, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 518)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1056, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 518)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1056, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 518)
        '
        'FrmDmHDXM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1056, 518)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.CbbLoc_SL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSCMT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CbbMa_TTCP)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CbbSearch)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtSDT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNgay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtNgay_Ct1)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmDmHDXM"
        Me.Text = "Quản lý bán xe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtSDT, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.CbbSearch, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TTCP, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtSCMT, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbLoc_SL, 0)
        Me.Controls.SetChildIndex(Me.TxtSearch, 0)
        CType(Me.TxtSCMT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtSDT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents CbbLoc_SL As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSCMT As Cyber.SmLists.TxtLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_TTCP As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CbbSearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtSDT As Cyber.SmLists.TxtLookup
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl

End Class
