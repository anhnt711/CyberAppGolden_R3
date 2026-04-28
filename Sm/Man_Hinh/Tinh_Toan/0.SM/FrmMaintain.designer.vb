<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaintain
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
        Me.TabKq = New DevExpress.XtraTab.XtraTabControl()
        Me.TabKq1 = New DevExpress.XtraTab.XtraTabPage()
        Me.Detail1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabKq2 = New DevExpress.XtraTab.XtraTabPage()
        Me.Detail2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabKq3 = New DevExpress.XtraTab.XtraTabPage()
        Me.Detail3 = New DevExpress.XtraGrid.GridControl()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabKq4 = New DevExpress.XtraTab.XtraTabPage()
        Me.Detail4 = New DevExpress.XtraGrid.GridControl()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.lblNam = New System.Windows.Forms.Label()
        Me.Chk04 = New System.Windows.Forms.CheckBox()
        Me.Chk03 = New System.Windows.Forms.CheckBox()
        Me.Chk02 = New System.Windows.Forms.CheckBox()
        Me.Chk01 = New System.Windows.Forms.CheckBox()
        Me.Chk00 = New System.Windows.Forms.CheckBox()
        Me.CmbNam = New System.Windows.Forms.ComboBox()
        Me.Lbprocess = New System.Windows.Forms.Label()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.CmdDang_Ky_Dll = New System.Windows.Forms.Button()
        CType(Me.TabKq, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabKq.SuspendLayout()
        Me.TabKq1.SuspendLayout()
        CType(Me.Detail1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabKq2.SuspendLayout()
        CType(Me.Detail2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabKq3.SuspendLayout()
        CType(Me.Detail3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabKq4.SuspendLayout()
        CType(Me.Detail4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 565)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1441, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(1175, 577)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1311, 577)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        '
        'TabKq
        '
        Me.TabKq.Location = New System.Drawing.Point(10, 90)
        Me.TabKq.Margin = New System.Windows.Forms.Padding(4)
        Me.TabKq.Name = "TabKq"
        Me.TabKq.SelectedTabPage = Me.TabKq1
        Me.TabKq.Size = New System.Drawing.Size(1601, 480)
        Me.TabKq.TabIndex = 123
        Me.TabKq.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.TabKq1, Me.TabKq2, Me.TabKq3, Me.TabKq4})
        '
        'TabKq1
        '
        Me.TabKq1.Controls.Add(Me.Detail1)
        Me.TabKq1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabKq1.Name = "TabKq1"
        Me.TabKq1.Size = New System.Drawing.Size(1594, 445)
        Me.TabKq1.Tag = "Accounting consolidated accounts"
        Me.TabKq1.Text = "Hạch toán tài khoản tổng hơp"
        '
        'Detail1
        '
        Me.Detail1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.Detail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail1.Location = New System.Drawing.Point(0, 0)
        Me.Detail1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail1.MainView = Me.GridView1
        Me.Detail1.Margin = New System.Windows.Forms.Padding(4)
        Me.Detail1.Name = "Detail1"
        Me.Detail1.Size = New System.Drawing.Size(1593, 446)
        Me.Detail1.TabIndex = 12
        Me.Detail1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView1.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView1.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.GridView1.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.AppearancePrint.EvenRow.Options.UseFont = True
        Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GridView1.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.GridView1.GridControl = Me.Detail1
        Me.GridView1.GroupRowHeight = 30
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView1.OptionsLayout.Columns.AddNewColumns = False
        Me.GridView1.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.GridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.RowHeight = 21
        '
        'TabKq2
        '
        Me.TabKq2.Controls.Add(Me.Detail2)
        Me.TabKq2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabKq2.Name = "TabKq2"
        Me.TabKq2.Size = New System.Drawing.Size(1594, 445)
        Me.TabKq2.Tag = "Accounting for liabilities accounts"
        Me.TabKq2.Text = "Hạch toán tài khoản công nợ"
        '
        'Detail2
        '
        Me.Detail2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.Detail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail2.Location = New System.Drawing.Point(0, 0)
        Me.Detail2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail2.MainView = Me.GridView2
        Me.Detail2.Margin = New System.Windows.Forms.Padding(4)
        Me.Detail2.Name = "Detail2"
        Me.Detail2.Size = New System.Drawing.Size(1593, 414)
        Me.Detail2.TabIndex = 12
        Me.Detail2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView2.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.GridView2.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView2.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView2.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView2.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView2.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.GridView2.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView2.AppearancePrint.EvenRow.Options.UseFont = True
        Me.GridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GridView2.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.GridView2.GridControl = Me.Detail2
        Me.GridView2.GroupRowHeight = 30
        Me.GridView2.Name = "GridView2"
        Me.GridView2.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView2.OptionsLayout.Columns.AddNewColumns = False
        Me.GridView2.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.GridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView2.OptionsView.ColumnAutoWidth = False
        Me.GridView2.OptionsView.ShowGroupPanel = False
        Me.GridView2.RowHeight = 21
        '
        'TabKq3
        '
        Me.TabKq3.Controls.Add(Me.Detail3)
        Me.TabKq3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabKq3.Name = "TabKq3"
        Me.TabKq3.Size = New System.Drawing.Size(1594, 445)
        Me.TabKq3.Tag = "Difference between ledger and warehouse book"
        Me.TabKq3.Text = "Lệch số cái và sổ kho"
        '
        'Detail3
        '
        Me.Detail3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail3.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.Detail3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail3.Location = New System.Drawing.Point(0, 0)
        Me.Detail3.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail3.MainView = Me.GridView3
        Me.Detail3.Margin = New System.Windows.Forms.Padding(4)
        Me.Detail3.Name = "Detail3"
        Me.Detail3.Size = New System.Drawing.Size(1593, 414)
        Me.Detail3.TabIndex = 12
        Me.Detail3.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView3})
        '
        'GridView3
        '
        Me.GridView3.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView3.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.GridView3.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView3.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView3.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView3.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView3.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.GridView3.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView3.AppearancePrint.EvenRow.Options.UseFont = True
        Me.GridView3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GridView3.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.GridView3.GridControl = Me.Detail3
        Me.GridView3.GroupRowHeight = 30
        Me.GridView3.Name = "GridView3"
        Me.GridView3.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView3.OptionsLayout.Columns.AddNewColumns = False
        Me.GridView3.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.GridView3.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView3.OptionsView.ColumnAutoWidth = False
        Me.GridView3.OptionsView.ShowGroupPanel = False
        Me.GridView3.RowHeight = 21
        '
        'TabKq4
        '
        Me.TabKq4.Controls.Add(Me.Detail4)
        Me.TabKq4.Margin = New System.Windows.Forms.Padding(4)
        Me.TabKq4.Name = "TabKq4"
        Me.TabKq4.Size = New System.Drawing.Size(1594, 445)
        Me.TabKq4.Tag = "Accouting accout without supplies account"
        Me.TabKq4.Text = "Tài khoản hạch toán khác tài khoản vật tư"
        '
        'Detail4
        '
        Me.Detail4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail4.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.Detail4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail4.Location = New System.Drawing.Point(0, 0)
        Me.Detail4.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail4.MainView = Me.GridView4
        Me.Detail4.Margin = New System.Windows.Forms.Padding(4)
        Me.Detail4.Name = "Detail4"
        Me.Detail4.Size = New System.Drawing.Size(1593, 414)
        Me.Detail4.TabIndex = 12
        Me.Detail4.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView4})
        '
        'GridView4
        '
        Me.GridView4.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GridView4.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView4.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.GridView4.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView4.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.GridView4.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView4.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView4.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.GridView4.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView4.AppearancePrint.EvenRow.Options.UseFont = True
        Me.GridView4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.GridView4.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.GridView4.GridControl = Me.Detail4
        Me.GridView4.GroupRowHeight = 30
        Me.GridView4.Name = "GridView4"
        Me.GridView4.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.GridView4.OptionsLayout.Columns.AddNewColumns = False
        Me.GridView4.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.GridView4.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.GridView4.OptionsView.ColumnAutoWidth = False
        Me.GridView4.OptionsView.ShowGroupPanel = False
        Me.GridView4.RowHeight = 21
        '
        'lblNam
        '
        Me.lblNam.BackColor = System.Drawing.Color.Transparent
        Me.lblNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNam.ForeColor = System.Drawing.Color.Navy
        Me.lblNam.Location = New System.Drawing.Point(8, 9)
        Me.lblNam.Margin = New System.Windows.Forms.Padding(0)
        Me.lblNam.Name = "lblNam"
        Me.lblNam.Size = New System.Drawing.Size(95, 18)
        Me.lblNam.TabIndex = 140
        Me.lblNam.Tag = "Year"
        Me.lblNam.Text = "Năm"
        '
        'Chk04
        '
        Me.Chk04.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk04.AutoSize = True
        Me.Chk04.Location = New System.Drawing.Point(974, 34)
        Me.Chk04.Margin = New System.Windows.Forms.Padding(4)
        Me.Chk04.Name = "Chk04"
        Me.Chk04.Size = New System.Drawing.Size(463, 21)
        Me.Chk04.TabIndex = 238
        Me.Chk04.Tag = "Check accounting acount without supplies account"
        Me.Chk04.Text = "Kiểm tra tài khoản hạch toán khác với tài khoản vật tư trong khai báo"
        Me.Chk04.UseVisualStyleBackColor = True
        '
        'Chk03
        '
        Me.Chk03.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Chk03.AutoSize = True
        Me.Chk03.Location = New System.Drawing.Point(976, 9)
        Me.Chk03.Margin = New System.Windows.Forms.Padding(4)
        Me.Chk03.Name = "Chk03"
        Me.Chk03.Size = New System.Drawing.Size(218, 21)
        Me.Chk03.TabIndex = 237
        Me.Chk03.Tag = "Check the difference between ledger and warehouse-book"
        Me.Chk03.Text = "Kiểm tra lệch sổ cái và sổ kho"
        Me.Chk03.UseVisualStyleBackColor = True
        '
        'Chk02
        '
        Me.Chk02.AutoSize = True
        Me.Chk02.Location = New System.Drawing.Point(459, 34)
        Me.Chk02.Margin = New System.Windows.Forms.Padding(4)
        Me.Chk02.Name = "Chk02"
        Me.Chk02.Size = New System.Drawing.Size(523, 21)
        Me.Chk02.TabIndex = 235
        Me.Chk02.Tag = "Check liabilities account but no customer"
        Me.Chk02.Text = "Kiểm tra hạch toán tài khoản công nợ nhưng không có đối tượng (khách hàng)"
        Me.Chk02.UseVisualStyleBackColor = True
        '
        'Chk01
        '
        Me.Chk01.AutoSize = True
        Me.Chk01.Location = New System.Drawing.Point(459, 6)
        Me.Chk01.Margin = New System.Windows.Forms.Padding(4)
        Me.Chk01.Name = "Chk01"
        Me.Chk01.Size = New System.Drawing.Size(298, 21)
        Me.Chk01.TabIndex = 234
        Me.Chk01.Tag = "Check accounting into general accounts"
        Me.Chk01.Text = "Kiểm tra hạch toán vào tài khoản tổng hợp"
        Me.Chk01.UseVisualStyleBackColor = True
        '
        'Chk00
        '
        Me.Chk00.AutoSize = True
        Me.Chk00.Location = New System.Drawing.Point(187, 6)
        Me.Chk00.Margin = New System.Windows.Forms.Padding(4)
        Me.Chk00.Name = "Chk00"
        Me.Chk00.Size = New System.Drawing.Size(273, 21)
        Me.Chk00.TabIndex = 233
        Me.Chk00.Tag = "Clear data (Speed up the program)"
        Me.Chk00.Text = "Dọn số liệu  (tăng tốc độ chương trình)"
        Me.Chk00.UseVisualStyleBackColor = True
        '
        'CmbNam
        '
        Me.CmbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbNam.FormattingEnabled = True
        Me.CmbNam.Location = New System.Drawing.Point(63, 9)
        Me.CmbNam.Margin = New System.Windows.Forms.Padding(4)
        Me.CmbNam.Name = "CmbNam"
        Me.CmbNam.Size = New System.Drawing.Size(107, 24)
        Me.CmbNam.TabIndex = 239
        '
        'Lbprocess
        '
        Me.Lbprocess.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbprocess.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbprocess.ForeColor = System.Drawing.Color.Blue
        Me.Lbprocess.Location = New System.Drawing.Point(7, 578)
        Me.Lbprocess.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbprocess.Name = "Lbprocess"
        Me.Lbprocess.Size = New System.Drawing.Size(531, 30)
        Me.Lbprocess.TabIndex = 227
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
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1447, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 644)
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1447, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 644)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1447, 0)
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 644)
        '
        'CmdDang_Ky_Dll
        '
        Me.CmdDang_Ky_Dll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdDang_Ky_Dll.Location = New System.Drawing.Point(1159, 54)
        Me.CmdDang_Ky_Dll.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdDang_Ky_Dll.Name = "CmdDang_Ky_Dll"
        Me.CmdDang_Ky_Dll.Size = New System.Drawing.Size(280, 28)
        Me.CmdDang_Ky_Dll.TabIndex = 244
        Me.CmdDang_Ky_Dll.Tag = "Sign in - Speed up"
        Me.CmdDang_Ky_Dll.Text = "Đăng ký chương trình - tăng tốc động "
        Me.CmdDang_Ky_Dll.UseVisualStyleBackColor = True
        '
        'FrmMaintain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1447, 644)
        Me.Controls.Add(Me.CmdDang_Ky_Dll)
        Me.Controls.Add(Me.Lbprocess)
        Me.Controls.Add(Me.CmbNam)
        Me.Controls.Add(Me.Chk04)
        Me.Controls.Add(Me.Chk03)
        Me.Controls.Add(Me.Chk02)
        Me.Controls.Add(Me.Chk01)
        Me.Controls.Add(Me.Chk00)
        Me.Controls.Add(Me.lblNam)
        Me.Controls.Add(Me.TabKq)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FrmMaintain"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.TabKq, 0)
        Me.Controls.SetChildIndex(Me.lblNam, 0)
        Me.Controls.SetChildIndex(Me.Chk00, 0)
        Me.Controls.SetChildIndex(Me.Chk01, 0)
        Me.Controls.SetChildIndex(Me.Chk02, 0)
        Me.Controls.SetChildIndex(Me.Chk03, 0)
        Me.Controls.SetChildIndex(Me.Chk04, 0)
        Me.Controls.SetChildIndex(Me.CmbNam, 0)
        Me.Controls.SetChildIndex(Me.Lbprocess, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CmdDang_Ky_Dll, 0)
        CType(Me.TabKq, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabKq.ResumeLayout(False)
        Me.TabKq1.ResumeLayout(False)
        CType(Me.Detail1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabKq2.ResumeLayout(False)
        CType(Me.Detail2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabKq3.ResumeLayout(False)
        CType(Me.Detail3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabKq4.ResumeLayout(False)
        CType(Me.Detail4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabKq As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents TabKq2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabKq1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents lblNam As System.Windows.Forms.Label
    Friend WithEvents Chk04 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk03 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk02 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk01 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk00 As System.Windows.Forms.CheckBox
    Friend WithEvents TabKq3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents TabKq4 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents CmbNam As System.Windows.Forms.ComboBox
    Friend WithEvents Lbprocess As System.Windows.Forms.Label
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Detail3 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Detail4 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Detail1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Detail2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents CmdDang_Ky_Dll As System.Windows.Forms.Button

End Class
