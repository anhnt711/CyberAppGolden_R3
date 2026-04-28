<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMDMS
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_DMS = New System.Windows.Forms.TextBox()
        Me.TxtMa_DMS = New System.Windows.Forms.TextBox()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.TabVt = New System.Windows.Forms.TabPage()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabHDK = New System.Windows.Forms.TabControl()
        Me.txtSo_luong = New ClsTextBox.txtTien_NT()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtT_So_Luong = New ClsTextBox.txtTien_NT()
        Me.TxtTen_mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_mau = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_KX = New System.Windows.Forms.TextBox()
        Me.TxtMa_KX = New Cyber.SmLists.TxtLookup()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.LabMa_vt = New System.Windows.Forms.Label()
        Me.TxtTen_DMS2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtT_Tien2 = New ClsTextBox.txtTien_NT()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabVt.SuspendLayout()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabHDK.SuspendLayout()
        CType(Me.TxtMa_mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(780, 422)
        Me.ButtExit.TabIndex = 9
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(674, 422)
        Me.ButtOK.TabIndex = 8
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(-196, 429)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(70, 21)
        Me.TxtMa_Dvcs.TabIndex = 6
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(116, 425)
        Me.ChkActi.TabIndex = 7
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(-6, 409)
        Me.GroupBoxLine.Size = New System.Drawing.Size(886, 4)
        Me.GroupBoxLine.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 14)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Code"
        Me.Label1.Text = "Mã định mức "
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Tag = "Name"
        Me.Label2.Text = "Tên định mức "
        '
        'TxtTen_DMS
        '
        Me.TxtTen_DMS.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_DMS.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_DMS.Location = New System.Drawing.Point(111, 73)
        Me.TxtTen_DMS.Name = "TxtTen_DMS"
        Me.TxtTen_DMS.Size = New System.Drawing.Size(766, 21)
        Me.TxtTen_DMS.TabIndex = 3
        '
        'TxtMa_DMS
        '
        Me.TxtMa_DMS.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_DMS.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_DMS.Location = New System.Drawing.Point(111, 49)
        Me.TxtMa_DMS.Name = "TxtMa_DMS"
        Me.TxtMa_DMS.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_DMS.TabIndex = 2
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
        Me.barDockControlTop.Size = New System.Drawing.Size(890, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 468)
        Me.barDockControlBottom.Size = New System.Drawing.Size(890, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 468)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(890, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 468)
        '
        'TabVt
        '
        Me.TabVt.Controls.Add(Me.Detail)
        Me.TabVt.Location = New System.Drawing.Point(4, 22)
        Me.TabVt.Name = "TabVt"
        Me.TabVt.Padding = New System.Windows.Forms.Padding(3)
        Me.TabVt.Size = New System.Drawing.Size(874, 239)
        Me.TabVt.TabIndex = 0
        Me.TabVt.Tag = "Item"
        Me.TabVt.Text = "Vật tư sơn"
        Me.TabVt.UseVisualStyleBackColor = True
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
        Me.Detail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Detail.Size = New System.Drawing.Size(868, 233)
        Me.Detail.TabIndex = 8
        Me.Detail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV, Me.GridView1})
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
        'GridView1
        '
        Me.GridView1.GridControl = Me.Detail
        Me.GridView1.Name = "GridView1"
        '
        'TabHDK
        '
        Me.TabHDK.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabHDK.Controls.Add(Me.TabVt)
        Me.TabHDK.Location = New System.Drawing.Point(2, 142)
        Me.TabHDK.Name = "TabHDK"
        Me.TabHDK.SelectedIndex = 0
        Me.TabHDK.Size = New System.Drawing.Size(882, 265)
        Me.TabHDK.TabIndex = 6
        '
        'txtSo_luong
        '
        Me.txtSo_luong.AllowNegative = True
        Me.txtSo_luong.Flags = 7680
        Me.txtSo_luong.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtSo_luong.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_luong.InputMask = "### ### ### ### ###.##"
        Me.txtSo_luong.Location = New System.Drawing.Point(111, 120)
        Me.txtSo_luong.MaxWholeDigits = 17
        Me.txtSo_luong.Name = "txtSo_luong"
        Me.txtSo_luong.RangeMax = 1.7976931348623157E+308R
        Me.txtSo_luong.RangeMin = -1.7976931348623157E+308R
        Me.txtSo_luong.Size = New System.Drawing.Size(149, 21)
        Me.txtSo_luong.TabIndex = 5
        Me.txtSo_luong.Tag = "### ### ### ### ###.##"
        Me.txtSo_luong.Text = "0.00"
        Me.txtSo_luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 21)
        Me.Label5.TabIndex = 1938
        Me.Label5.Tag = "Quantity norms"
        Me.Label5.Text = "Số lượng định mức"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(294, 425)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 1946
        Me.Label6.Tag = "total quantity"
        Me.Label6.Text = "Tổng số lượng"
        '
        'TxtT_So_Luong
        '
        Me.TxtT_So_Luong.AllowNegative = True
        Me.TxtT_So_Luong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtT_So_Luong.BackColor = System.Drawing.Color.White
        Me.TxtT_So_Luong.Flags = 7680
        Me.TxtT_So_Luong.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtT_So_Luong.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_So_Luong.InputMask = "### ### ### ###.##"
        Me.TxtT_So_Luong.Location = New System.Drawing.Point(369, 422)
        Me.TxtT_So_Luong.MaxWholeDigits = 14
        Me.TxtT_So_Luong.Name = "TxtT_So_Luong"
        Me.TxtT_So_Luong.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_So_Luong.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_So_Luong.ReadOnly = True
        Me.TxtT_So_Luong.Size = New System.Drawing.Size(110, 21)
        Me.TxtT_So_Luong.TabIndex = 1945
        Me.TxtT_So_Luong.TabStop = False
        Me.TxtT_So_Luong.Text = "0.00"
        Me.TxtT_So_Luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTen_mau
        '
        Me.TxtTen_mau.BackColor = System.Drawing.Color.White
        Me.TxtTen_mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_mau.Enabled = False
        Me.TxtTen_mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_mau.Location = New System.Drawing.Point(266, 29)
        Me.TxtTen_mau.Name = "TxtTen_mau"
        Me.TxtTen_mau.ReadOnly = True
        Me.TxtTen_mau.Size = New System.Drawing.Size(611, 14)
        Me.TxtTen_mau.TabIndex = 1956
        Me.TxtTen_mau.TabStop = False
        '
        'TxtMa_mau
        '
        Me.TxtMa_mau._ActilookupPopup = False
        Me.TxtMa_mau.CyberActilookupPopup = True
        Me.TxtMa_mau.Dv_ListDetail = Nothing
        Me.TxtMa_mau.Dv_Master = Nothing
        Me.TxtMa_mau.FilterClient = ""
        Me.TxtMa_mau.FilterSQL = ""
        Me.TxtMa_mau.Location = New System.Drawing.Point(111, 26)
        Me.TxtMa_mau.Name = "TxtMa_mau"
        Me.TxtMa_mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_mau.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_mau.TabIndex = 1
        Me.TxtMa_mau.Table_Name = ""
        '
        'TxtTen_KX
        '
        Me.TxtTen_KX.BackColor = System.Drawing.Color.White
        Me.TxtTen_KX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KX.Enabled = False
        Me.TxtTen_KX.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KX.Location = New System.Drawing.Point(266, 6)
        Me.TxtTen_KX.Name = "TxtTen_KX"
        Me.TxtTen_KX.ReadOnly = True
        Me.TxtTen_KX.Size = New System.Drawing.Size(611, 14)
        Me.TxtTen_KX.TabIndex = 1955
        Me.TxtTen_KX.TabStop = False
        '
        'TxtMa_KX
        '
        Me.TxtMa_KX._ActilookupPopup = False
        Me.TxtMa_KX.CyberActilookupPopup = True
        Me.TxtMa_KX.Dv_ListDetail = Nothing
        Me.TxtMa_KX.Dv_Master = Nothing
        Me.TxtMa_KX.FilterClient = ""
        Me.TxtMa_KX.FilterSQL = ""
        Me.TxtMa_KX.Location = New System.Drawing.Point(111, 3)
        Me.TxtMa_KX.Name = "TxtMa_KX"
        Me.TxtMa_KX.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KX.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KX.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_KX.TabIndex = 0
        Me.TxtMa_KX.Table_Name = ""
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(6, 30)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(92, 13)
        Me.LabMa_kho.TabIndex = 1954
        Me.LabMa_kho.Tag = "Color code"
        Me.LabMa_kho.Text = "Mã màu"
        '
        'LabMa_vt
        '
        Me.LabMa_vt.Location = New System.Drawing.Point(6, 7)
        Me.LabMa_vt.Name = "LabMa_vt"
        Me.LabMa_vt.Size = New System.Drawing.Size(96, 13)
        Me.LabMa_vt.TabIndex = 1953
        Me.LabMa_vt.Tag = "Type car"
        Me.LabMa_vt.Text = "Mã kiểu xe"
        '
        'TxtTen_DMS2
        '
        Me.TxtTen_DMS2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_DMS2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_DMS2.Location = New System.Drawing.Point(111, 97)
        Me.TxtTen_DMS2.Name = "TxtTen_DMS2"
        Me.TxtTen_DMS2.Size = New System.Drawing.Size(766, 21)
        Me.TxtTen_DMS2.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 20)
        Me.Label4.TabIndex = 1962
        Me.Label4.Tag = "Name 2"
        Me.Label4.Text = "Tên định mức 2"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(483, 425)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 1968
        Me.Label7.Tag = "total amount"
        Me.Label7.Text = "Tổng tiền"
        '
        'TxtT_Tien2
        '
        Me.TxtT_Tien2.AllowNegative = True
        Me.TxtT_Tien2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien2.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien2.Flags = 7680
        Me.TxtT_Tien2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtT_Tien2.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien2.InputMask = "### ### ### ###"
        Me.TxtT_Tien2.Location = New System.Drawing.Point(542, 422)
        Me.TxtT_Tien2.MaxWholeDigits = 11
        Me.TxtT_Tien2.Name = "TxtT_Tien2"
        Me.TxtT_Tien2.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien2.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien2.ReadOnly = True
        Me.TxtT_Tien2.Size = New System.Drawing.Size(110, 21)
        Me.TxtT_Tien2.TabIndex = 1967
        Me.TxtT_Tien2.TabStop = False
        Me.TxtT_Tien2.Text = "0"
        Me.TxtT_Tien2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DMDMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(890, 468)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtT_Tien2)
        Me.Controls.Add(Me.TxtTen_DMS2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_mau)
        Me.Controls.Add(Me.TxtMa_mau)
        Me.Controls.Add(Me.TxtTen_KX)
        Me.Controls.Add(Me.TxtMa_KX)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.LabMa_vt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtT_So_Luong)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSo_luong)
        Me.Controls.Add(Me.TabHDK)
        Me.Controls.Add(Me.TxtTen_DMS)
        Me.Controls.Add(Me.TxtMa_DMS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMDMS"
        Me.Text = "Danh mục định mức sơn"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_DMS, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_DMS, 0)
        Me.Controls.SetChildIndex(Me.TabHDK, 0)
        Me.Controls.SetChildIndex(Me.txtSo_luong, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtT_So_Luong, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.LabMa_vt, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KX, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KX, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_mau, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_DMS2, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien2, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabVt.ResumeLayout(False)
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabHDK.ResumeLayout(False)
        CType(Me.TxtMa_mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_DMS As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_DMS As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents TabHDK As System.Windows.Forms.TabControl
    Friend WithEvents TabVt As System.Windows.Forms.TabPage
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSo_luong As ClsTextBox.txtTien_NT
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtT_So_Luong As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTen_mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_mau As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_KX As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KX As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents LabMa_vt As System.Windows.Forms.Label
    Friend WithEvents TxtTen_DMS2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents TxtT_Tien2 As ClsTextBox.txtTien_NT
End Class
