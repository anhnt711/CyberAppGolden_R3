<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dmxe_hddh
    Inherits Cyber.From.FrmList

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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtMa_kh = New Cyber.SmLists.TxtLookup()
        Me.Txtghi_chu = New System.Windows.Forms.TextBox()
        Me.TabHDK = New System.Windows.Forms.TabControl()
        Me.TabCv = New System.Windows.Forms.TabPage()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TxtNgay_LCt = New ClsTextBox.txtDate()
        Me.LabMa_NT = New System.Windows.Forms.Label()
        Me.txtSo_ct = New System.Windows.Forms.TextBox()
        Me.lblSo_ct = New System.Windows.Forms.Label()
        Me.LabNgay_Ct = New System.Windows.Forms.Label()
        Me.TxtMa_Quyen = New System.Windows.Forms.TextBox()
        Me.TxtTy_Gia = New ClsTextBox.txtTy_Gia()
        Me.TxtMa_NT = New System.Windows.Forms.TextBox()
        Me.LabTy_gia = New System.Windows.Forms.Label()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.TxtTen_kh = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Txtma_hs = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_hs = New System.Windows.Forms.TextBox()
        Me.TxtNgay_hl1 = New ClsTextBox.txtDate1()
        Me.TxtNgay_hl2 = New ClsTextBox.txtDate1()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSo_HD = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabHDK.SuspendLayout()
        Me.TabCv.SuspendLayout()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtma_hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(811, 451)
        Me.ButtExit.TabIndex = 10
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(705, 451)
        Me.ButtOK.TabIndex = 9
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(-165, 445)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(70, 21)
        Me.TxtMa_Dvcs.TabIndex = 100
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(113, 457)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(-6, 438)
        Me.GroupBoxLine.Size = New System.Drawing.Size(917, 4)
        Me.GroupBoxLine.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Code"
        Me.Label1.Text = "Ghi chú"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 364
        Me.Label4.Tag = "Models code"
        Me.Label4.Text = "Khách hàng"
        '
        'TxtMa_kh
        '
        Me.TxtMa_kh._ActilookupPopup = False
        Me.TxtMa_kh.CyberActilookupPopup = True
        Me.TxtMa_kh.Dv_ListDetail = Nothing
        Me.TxtMa_kh.Dv_Master = Nothing
        Me.TxtMa_kh.FilterClient = ""
        Me.TxtMa_kh.FilterSQL = ""
        Me.TxtMa_kh.Location = New System.Drawing.Point(108, 6)
        Me.TxtMa_kh.Name = "TxtMa_kh"
        Me.TxtMa_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kh.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_kh.TabIndex = 0
        Me.TxtMa_kh.Table_Name = ""
        '
        'Txtghi_chu
        '
        Me.Txtghi_chu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtghi_chu.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Txtghi_chu.ForeColor = System.Drawing.Color.Navy
        Me.Txtghi_chu.Location = New System.Drawing.Point(108, 124)
        Me.Txtghi_chu.Multiline = True
        Me.Txtghi_chu.Name = "Txtghi_chu"
        Me.Txtghi_chu.Size = New System.Drawing.Size(807, 46)
        Me.Txtghi_chu.TabIndex = 6
        '
        'TabHDK
        '
        Me.TabHDK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabHDK.Controls.Add(Me.TabCv)
        Me.TabHDK.Location = New System.Drawing.Point(1, 173)
        Me.TabHDK.Name = "TabHDK"
        Me.TabHDK.SelectedIndex = 0
        Me.TabHDK.Size = New System.Drawing.Size(918, 268)
        Me.TabHDK.TabIndex = 7
        '
        'TabCv
        '
        Me.TabCv.Controls.Add(Me.Detail)
        Me.TabCv.Controls.Add(Me.TxtNgay_LCt)
        Me.TabCv.Controls.Add(Me.LabMa_NT)
        Me.TabCv.Controls.Add(Me.txtSo_ct)
        Me.TabCv.Controls.Add(Me.lblSo_ct)
        Me.TabCv.Controls.Add(Me.LabNgay_Ct)
        Me.TabCv.Controls.Add(Me.TxtMa_Quyen)
        Me.TabCv.Controls.Add(Me.TxtTy_Gia)
        Me.TabCv.Controls.Add(Me.TxtMa_NT)
        Me.TabCv.Controls.Add(Me.LabTy_gia)
        Me.TabCv.Location = New System.Drawing.Point(4, 22)
        Me.TabCv.Name = "TabCv"
        Me.TabCv.Padding = New System.Windows.Forms.Padding(3)
        Me.TabCv.Size = New System.Drawing.Size(910, 242)
        Me.TabCv.TabIndex = 1
        Me.TabCv.Tag = "Jobs"
        Me.TabCv.Text = "Chi tiết xe"
        Me.TabCv.UseVisualStyleBackColor = True
        '
        'Detail
        '
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(3, 3)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Name = "Detail"
        Me.Detail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4})
        Me.Detail.Size = New System.Drawing.Size(904, 236)
        Me.Detail.TabIndex = 0
        Me.Detail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV})
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
        'TxtNgay_LCt
        '
        Me.TxtNgay_LCt.BackColor = System.Drawing.Color.White
        Me.TxtNgay_LCt.Flags = 65536
        Me.TxtNgay_LCt.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_LCt.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_LCt.isEmpty = True
        Me.TxtNgay_LCt.Location = New System.Drawing.Point(602, 100)
        Me.TxtNgay_LCt.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_LCt.MaxLength = 10
        Me.TxtNgay_LCt.Name = "TxtNgay_LCt"
        Me.TxtNgay_LCt.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_LCt.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_LCt.ReadOnly = True
        Me.TxtNgay_LCt.ShowDayBeforeMonth = False
        Me.TxtNgay_LCt.Size = New System.Drawing.Size(131, 22)
        Me.TxtNgay_LCt.TabIndex = 0
        Me.TxtNgay_LCt.Text = "18/09/2011"
        Me.TxtNgay_LCt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_LCt.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'LabMa_NT
        '
        Me.LabMa_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_NT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_NT.Location = New System.Drawing.Point(235, 41)
        Me.LabMa_NT.Name = "LabMa_NT"
        Me.LabMa_NT.Size = New System.Drawing.Size(64, 18)
        Me.LabMa_NT.TabIndex = 134
        Me.LabMa_NT.Tag = "E.Rate"
        Me.LabMa_NT.Text = "Ngoại tệ"
        '
        'txtSo_ct
        '
        Me.txtSo_ct.BackColor = System.Drawing.Color.White
        Me.txtSo_ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_ct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_ct.Location = New System.Drawing.Point(579, 93)
        Me.txtSo_ct.Name = "txtSo_ct"
        Me.txtSo_ct.Size = New System.Drawing.Size(182, 22)
        Me.txtSo_ct.TabIndex = 2
        Me.txtSo_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSo_ct
        '
        Me.lblSo_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_ct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblSo_ct.Location = New System.Drawing.Point(518, 98)
        Me.lblSo_ct.Name = "lblSo_ct"
        Me.lblSo_ct.Size = New System.Drawing.Size(83, 14)
        Me.lblSo_ct.TabIndex = 135
        Me.lblSo_ct.Tag = "Voucher no."
        Me.lblSo_ct.Text = "Số phiếu"
        '
        'LabNgay_Ct
        '
        Me.LabNgay_Ct.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_Ct.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_Ct.Location = New System.Drawing.Point(524, 107)
        Me.LabNgay_Ct.Name = "LabNgay_Ct"
        Me.LabNgay_Ct.Size = New System.Drawing.Size(91, 14)
        Me.LabNgay_Ct.TabIndex = 143
        Me.LabNgay_Ct.Tag = "Voucher date"
        Me.LabNgay_Ct.Text = "Ngày c.l.từ"
        '
        'TxtMa_Quyen
        '
        Me.TxtMa_Quyen.BackColor = System.Drawing.Color.White
        Me.TxtMa_Quyen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Quyen.Location = New System.Drawing.Point(579, 121)
        Me.TxtMa_Quyen.Name = "TxtMa_Quyen"
        Me.TxtMa_Quyen.Size = New System.Drawing.Size(125, 21)
        Me.TxtMa_Quyen.TabIndex = 22
        Me.TxtMa_Quyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMa_Quyen.Visible = False
        '
        'TxtTy_Gia
        '
        Me.TxtTy_Gia.AllowNegative = True
        Me.TxtTy_Gia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTy_Gia.BackColor = System.Drawing.Color.White
        Me.TxtTy_Gia.Flags = 7680
        Me.TxtTy_Gia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTy_Gia.ForeColor = System.Drawing.Color.Navy
        Me.TxtTy_Gia.InputMask = "## ### ###.##"
        Me.TxtTy_Gia.Location = New System.Drawing.Point(306, 60)
        Me.TxtTy_Gia.MaxWholeDigits = 10
        Me.TxtTy_Gia.Name = "TxtTy_Gia"
        Me.TxtTy_Gia.RangeMax = 1.7976931348623157E+308R
        Me.TxtTy_Gia.RangeMin = -1.7976931348623157E+308R
        Me.TxtTy_Gia.ReadOnly = True
        Me.TxtTy_Gia.Size = New System.Drawing.Size(102, 22)
        Me.TxtTy_Gia.TabIndex = 20
        Me.TxtTy_Gia.Text = "22 500.01"
        Me.TxtTy_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_NT
        '
        Me.TxtMa_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_NT.BackColor = System.Drawing.Color.White
        Me.TxtMa_NT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_NT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NT.Location = New System.Drawing.Point(306, 36)
        Me.TxtMa_NT.Name = "TxtMa_NT"
        Me.TxtMa_NT.Size = New System.Drawing.Size(102, 22)
        Me.TxtMa_NT.TabIndex = 19
        Me.TxtMa_NT.TabStop = False
        '
        'LabTy_gia
        '
        Me.LabTy_gia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabTy_gia.BackColor = System.Drawing.Color.Transparent
        Me.LabTy_gia.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTy_gia.ForeColor = System.Drawing.Color.Navy
        Me.LabTy_gia.Location = New System.Drawing.Point(235, 62)
        Me.LabTy_gia.Name = "LabTy_gia"
        Me.LabTy_gia.Size = New System.Drawing.Size(64, 18)
        Me.LabTy_gia.TabIndex = 153
        Me.LabTy_gia.Tag = "E.Rate"
        Me.LabTy_gia.Text = "Tỷ giá"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(921, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 484)
        Me.barDockControlBottom.Size = New System.Drawing.Size(921, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 484)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(921, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 484)
        '
        'TxtTen_kh
        '
        Me.TxtTen_kh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kh.Enabled = False
        Me.TxtTen_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh.Location = New System.Drawing.Point(263, 9)
        Me.TxtTen_kh.Name = "TxtTen_kh"
        Me.TxtTen_kh.ReadOnly = True
        Me.TxtTen_kh.Size = New System.Drawing.Size(652, 14)
        Me.TxtTen_kh.TabIndex = 1937
        Me.TxtTen_kh.TabStop = False
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 364
        Me.Label5.Tag = "Models code"
        Me.Label5.Text = "Cố vấn dịch vụ"
        '
        'Txtma_hs
        '
        Me.Txtma_hs._ActilookupPopup = False
        Me.Txtma_hs.CyberActilookupPopup = True
        Me.Txtma_hs.Dv_ListDetail = Nothing
        Me.Txtma_hs.Dv_Master = Nothing
        Me.Txtma_hs.FilterClient = ""
        Me.Txtma_hs.FilterSQL = ""
        Me.Txtma_hs.Location = New System.Drawing.Point(108, 29)
        Me.Txtma_hs.Name = "Txtma_hs"
        Me.Txtma_hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_hs.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_hs.Size = New System.Drawing.Size(149, 20)
        Me.Txtma_hs.TabIndex = 2
        Me.Txtma_hs.Table_Name = ""
        '
        'TxtTen_hs
        '
        Me.TxtTen_hs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTen_hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_hs.Enabled = False
        Me.TxtTen_hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_hs.Location = New System.Drawing.Point(263, 32)
        Me.TxtTen_hs.Name = "TxtTen_hs"
        Me.TxtTen_hs.ReadOnly = True
        Me.TxtTen_hs.Size = New System.Drawing.Size(652, 14)
        Me.TxtTen_hs.TabIndex = 1937
        Me.TxtTen_hs.TabStop = False
        '
        'TxtNgay_hl1
        '
        Me.TxtNgay_hl1.Flags = 65536
        Me.TxtNgay_hl1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_hl1.IsAllowResize = False
        Me.TxtNgay_hl1.isEmpty = True
        Me.TxtNgay_hl1.Location = New System.Drawing.Point(108, 53)
        Me.TxtNgay_hl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_hl1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_hl1.MaxLength = 10
        Me.TxtNgay_hl1.Name = "TxtNgay_hl1"
        Me.TxtNgay_hl1.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_hl1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_hl1.ShowDayBeforeMonth = False
        Me.TxtNgay_hl1.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_hl1.TabIndex = 3
        Me.TxtNgay_hl1.Text = "07/09/2011"
        Me.TxtNgay_hl1.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtNgay_hl2
        '
        Me.TxtNgay_hl2.Flags = 65536
        Me.TxtNgay_hl2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_hl2.IsAllowResize = False
        Me.TxtNgay_hl2.isEmpty = True
        Me.TxtNgay_hl2.Location = New System.Drawing.Point(108, 77)
        Me.TxtNgay_hl2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_hl2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_hl2.MaxLength = 10
        Me.TxtNgay_hl2.Name = "TxtNgay_hl2"
        Me.TxtNgay_hl2.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_hl2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_hl2.ShowDayBeforeMonth = False
        Me.TxtNgay_hl2.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_hl2.TabIndex = 4
        Me.TxtNgay_hl2.Text = "07/09/2011"
        Me.TxtNgay_hl2.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(3, 55)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 364
        Me.Label6.Tag = "Models code"
        Me.Label6.Text = "Hiệu lực từ ngày"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(3, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 16)
        Me.Label7.TabIndex = 364
        Me.Label7.Tag = "Models code"
        Me.Label7.Text = "Đến ngày"
        '
        'TxtSo_HD
        '
        Me.TxtSo_HD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSo_HD.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_HD.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_HD.Location = New System.Drawing.Point(108, 100)
        Me.TxtSo_HD.Multiline = True
        Me.TxtSo_HD.Name = "TxtSo_HD"
        Me.TxtSo_HD.Size = New System.Drawing.Size(149, 22)
        Me.TxtSo_HD.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 1943
        Me.Label3.Tag = "Models code"
        Me.Label3.Text = "Số hợp đồng"
        '
        'Dmxe_hddh
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(921, 484)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSo_HD)
        Me.Controls.Add(Me.TxtNgay_hl2)
        Me.Controls.Add(Me.TxtNgay_hl1)
        Me.Controls.Add(Me.TxtTen_hs)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.TabHDK)
        Me.Controls.Add(Me.Txtma_hs)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtMa_kh)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtghi_chu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "Dmxe_hddh"
        Me.Text = "Danh mục gói sửa chữa"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Txtghi_chu, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kh, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Txtma_hs, 0)
        Me.Controls.SetChildIndex(Me.TabHDK, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_hs, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_hl1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_hl2, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_HD, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.TxtMa_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabHDK.ResumeLayout(False)
        Me.TabCv.ResumeLayout(False)
        Me.TabCv.PerformLayout()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtma_hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtghi_chu As System.Windows.Forms.TextBox
    Friend WithEvents TabHDK As System.Windows.Forms.TabControl
    Friend WithEvents TabCv As System.Windows.Forms.TabPage
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TxtNgay_LCt As ClsTextBox.txtDate
    Friend WithEvents LabMa_NT As System.Windows.Forms.Label
    Friend WithEvents txtSo_ct As System.Windows.Forms.TextBox
    Friend WithEvents lblSo_ct As System.Windows.Forms.Label
    Friend WithEvents LabNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Quyen As System.Windows.Forms.TextBox
    Friend WithEvents TxtTy_Gia As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtMa_NT As System.Windows.Forms.TextBox
    Friend WithEvents LabTy_gia As System.Windows.Forms.Label
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents TxtTen_hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_kh As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_hs As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_hl2 As ClsTextBox.txtDate1
    Friend WithEvents TxtNgay_hl1 As ClsTextBox.txtDate1
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_HD As System.Windows.Forms.TextBox

End Class
