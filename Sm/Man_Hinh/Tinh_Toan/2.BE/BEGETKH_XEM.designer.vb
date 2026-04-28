<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BEGETKH_XEM
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
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.ComFilter = New System.Windows.Forms.ComboBox()
        Me.CmbbSms = New System.Windows.Forms.Button()
        Me.CmbbSelectAll = New System.Windows.Forms.Button()
        Me.CmbbUnSelectAll = New System.Windows.Forms.Button()
        Me.CmbbXuatExcel = New System.Windows.Forms.Button()
        Me.CmbbRefresh = New System.Windows.Forms.Button()
        Me.TxtM_thang1 = New System.Windows.Forms.TextBox()
        Me.TxtM_thang2 = New System.Windows.Forms.TextBox()
        Me.TxtM_Nam = New System.Windows.Forms.TextBox()
        Me.CmbbPrint = New System.Windows.Forms.Button()
        Me.CmbbInBien_Ban = New System.Windows.Forms.Button()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 390)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1356, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(1089, 433)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtOK.TabIndex = 6
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1225, 432)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtExit.TabIndex = 7
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
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1361, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 498)
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1361, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 498)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1361, 0)
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 498)
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(1, 1)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Master.Name = "Master"
        Me.Master.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master.Size = New System.Drawing.Size(1357, 428)
        Me.Master.TabIndex = 50
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
        'TxtSearch
        '
        Me.TxtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtSearch.Location = New System.Drawing.Point(243, 441)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(597, 22)
        Me.TxtSearch.TabIndex = 1785
        '
        'ComFilter
        '
        Me.ComFilter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComFilter.ForeColor = System.Drawing.Color.Navy
        Me.ComFilter.FormattingEnabled = True
        Me.ComFilter.Location = New System.Drawing.Point(0, 439)
        Me.ComFilter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComFilter.Name = "ComFilter"
        Me.ComFilter.Size = New System.Drawing.Size(237, 24)
        Me.ComFilter.TabIndex = 1784
        '
        'CmbbSms
        '
        Me.CmbbSms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbbSms.Location = New System.Drawing.Point(120, 432)
        Me.CmbbSms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbbSms.Name = "CmbbSms"
        Me.CmbbSms.Size = New System.Drawing.Size(119, 36)
        Me.CmbbSms.TabIndex = 1783
        Me.CmbbSms.TabStop = False
        Me.CmbbSms.Tag = "SMS"
        Me.CmbbSms.Text = "SMS"
        Me.CmbbSms.UseVisualStyleBackColor = True
        Me.CmbbSms.Visible = False
        '
        'CmbbSelectAll
        '
        Me.CmbbSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbSelectAll.Location = New System.Drawing.Point(239, 434)
        Me.CmbbSelectAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbbSelectAll.Name = "CmbbSelectAll"
        Me.CmbbSelectAll.Size = New System.Drawing.Size(119, 36)
        Me.CmbbSelectAll.TabIndex = 1779
        Me.CmbbSelectAll.Tag = "&XepXe"
        Me.CmbbSelectAll.Text = "&Chọn toàn bộ"
        Me.CmbbSelectAll.Visible = False
        '
        'CmbbUnSelectAll
        '
        Me.CmbbUnSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbUnSelectAll.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbUnSelectAll.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbUnSelectAll.Location = New System.Drawing.Point(359, 434)
        Me.CmbbUnSelectAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbbUnSelectAll.Name = "CmbbUnSelectAll"
        Me.CmbbUnSelectAll.Size = New System.Drawing.Size(119, 36)
        Me.CmbbUnSelectAll.TabIndex = 1778
        Me.CmbbUnSelectAll.Tag = "&XepXe"
        Me.CmbbUnSelectAll.Text = "&Gỡ chọn"
        Me.CmbbUnSelectAll.Visible = False
        '
        'CmbbXuatExcel
        '
        Me.CmbbXuatExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbbXuatExcel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbXuatExcel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbXuatExcel.Location = New System.Drawing.Point(843, 436)
        Me.CmbbXuatExcel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbbXuatExcel.Name = "CmbbXuatExcel"
        Me.CmbbXuatExcel.Size = New System.Drawing.Size(119, 36)
        Me.CmbbXuatExcel.TabIndex = 1777
        Me.CmbbXuatExcel.Tag = "&ExportExcel"
        Me.CmbbXuatExcel.Text = "Xuất &Excel"
        '
        'CmbbRefresh
        '
        Me.CmbbRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbbRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbRefresh.Location = New System.Drawing.Point(963, 434)
        Me.CmbbRefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbbRefresh.Name = "CmbbRefresh"
        Me.CmbbRefresh.Size = New System.Drawing.Size(119, 36)
        Me.CmbbRefresh.TabIndex = 1776
        Me.CmbbRefresh.Tag = "&Refresh"
        Me.CmbbRefresh.Text = "&Làm tươi"
        '
        'TxtM_thang1
        '
        Me.TxtM_thang1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtM_thang1.BackColor = System.Drawing.Color.White
        Me.TxtM_thang1.ForeColor = System.Drawing.Color.Blue
        Me.TxtM_thang1.Location = New System.Drawing.Point(964, 404)
        Me.TxtM_thang1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_thang1.Name = "TxtM_thang1"
        Me.TxtM_thang1.ReadOnly = True
        Me.TxtM_thang1.Size = New System.Drawing.Size(96, 22)
        Me.TxtM_thang1.TabIndex = 1790
        Me.TxtM_thang1.Visible = False
        '
        'TxtM_thang2
        '
        Me.TxtM_thang2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtM_thang2.BackColor = System.Drawing.Color.White
        Me.TxtM_thang2.ForeColor = System.Drawing.Color.Blue
        Me.TxtM_thang2.Location = New System.Drawing.Point(1069, 404)
        Me.TxtM_thang2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_thang2.Name = "TxtM_thang2"
        Me.TxtM_thang2.ReadOnly = True
        Me.TxtM_thang2.Size = New System.Drawing.Size(96, 22)
        Me.TxtM_thang2.TabIndex = 1791
        Me.TxtM_thang2.Visible = False
        '
        'TxtM_Nam
        '
        Me.TxtM_Nam.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtM_Nam.BackColor = System.Drawing.Color.White
        Me.TxtM_Nam.ForeColor = System.Drawing.Color.Blue
        Me.TxtM_Nam.Location = New System.Drawing.Point(1175, 405)
        Me.TxtM_Nam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_Nam.Name = "TxtM_Nam"
        Me.TxtM_Nam.ReadOnly = True
        Me.TxtM_Nam.Size = New System.Drawing.Size(96, 22)
        Me.TxtM_Nam.TabIndex = 1792
        Me.TxtM_Nam.Visible = False
        '
        'CmbbPrint
        '
        Me.CmbbPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbPrint.Location = New System.Drawing.Point(479, 434)
        Me.CmbbPrint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbbPrint.Name = "CmbbPrint"
        Me.CmbbPrint.Size = New System.Drawing.Size(119, 36)
        Me.CmbbPrint.TabIndex = 1781
        Me.CmbbPrint.Tag = "&XepXe"
        Me.CmbbPrint.Text = "&In ĐKHĐ"
        Me.CmbbPrint.Visible = False
        '
        'CmbbInBien_Ban
        '
        Me.CmbbInBien_Ban.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmbbInBien_Ban.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.CmbbInBien_Ban.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbInBien_Ban.Location = New System.Drawing.Point(600, 434)
        Me.CmbbInBien_Ban.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbbInBien_Ban.Name = "CmbbInBien_Ban"
        Me.CmbbInBien_Ban.Size = New System.Drawing.Size(119, 36)
        Me.CmbbInBien_Ban.TabIndex = 1782
        Me.CmbbInBien_Ban.Tag = "&Create contract"
        Me.CmbbInBien_Ban.Text = "In &Biên bản"
        Me.CmbbInBien_Ban.Visible = False
        '
        'BEGETKH_XEM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1361, 498)
        Me.Controls.Add(Me.TxtM_Nam)
        Me.Controls.Add(Me.TxtM_thang2)
        Me.Controls.Add(Me.TxtM_thang1)
        Me.Controls.Add(Me.TxtSearch)
        Me.Controls.Add(Me.ComFilter)
        Me.Controls.Add(Me.CmbbSms)
        Me.Controls.Add(Me.CmbbInBien_Ban)
        Me.Controls.Add(Me.CmbbPrint)
        Me.Controls.Add(Me.CmbbSelectAll)
        Me.Controls.Add(Me.CmbbUnSelectAll)
        Me.Controls.Add(Me.CmbbXuatExcel)
        Me.Controls.Add(Me.CmbbRefresh)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "BEGETKH_XEM"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.CmbbRefresh, 0)
        Me.Controls.SetChildIndex(Me.CmbbXuatExcel, 0)
        Me.Controls.SetChildIndex(Me.CmbbUnSelectAll, 0)
        Me.Controls.SetChildIndex(Me.CmbbSelectAll, 0)
        Me.Controls.SetChildIndex(Me.CmbbPrint, 0)
        Me.Controls.SetChildIndex(Me.CmbbInBien_Ban, 0)
        Me.Controls.SetChildIndex(Me.CmbbSms, 0)
        Me.Controls.SetChildIndex(Me.ComFilter, 0)
        Me.Controls.SetChildIndex(Me.TxtSearch, 0)
        Me.Controls.SetChildIndex(Me.TxtM_thang1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_thang2, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Nam, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TxtSearch As System.Windows.Forms.TextBox
    Friend WithEvents ComFilter As System.Windows.Forms.ComboBox
    Friend WithEvents CmbbSms As System.Windows.Forms.Button
    Friend WithEvents CmbbSelectAll As System.Windows.Forms.Button
    Friend WithEvents CmbbUnSelectAll As System.Windows.Forms.Button
    Friend WithEvents CmbbXuatExcel As System.Windows.Forms.Button
    Friend WithEvents CmbbRefresh As System.Windows.Forms.Button
    Friend WithEvents TxtM_Nam As System.Windows.Forms.TextBox
    Friend WithEvents TxtM_thang2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtM_thang1 As System.Windows.Forms.TextBox
    Friend WithEvents CmbbInBien_Ban As System.Windows.Forms.Button
    Friend WithEvents CmbbPrint As System.Windows.Forms.Button

End Class
