<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTien_Do_Luu
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
        Dim TimeRuler1 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeRuler2 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim TimeScaleYear1 As DevExpress.XtraScheduler.TimeScaleYear = New DevExpress.XtraScheduler.TimeScaleYear()
        Dim TimeScaleQuarter1 As DevExpress.XtraScheduler.TimeScaleQuarter = New DevExpress.XtraScheduler.TimeScaleQuarter()
        Dim TimeScaleMonth1 As DevExpress.XtraScheduler.TimeScaleMonth = New DevExpress.XtraScheduler.TimeScaleMonth()
        Dim TimeScaleWeek1 As DevExpress.XtraScheduler.TimeScaleWeek = New DevExpress.XtraScheduler.TimeScaleWeek()
        Dim TimeScaleDay1 As DevExpress.XtraScheduler.TimeScaleDay = New DevExpress.XtraScheduler.TimeScaleDay()
        Dim TimeScaleHour1 As DevExpress.XtraScheduler.TimeScaleHour = New DevExpress.XtraScheduler.TimeScaleHour()
        Dim TimeScale15Minutes1 As DevExpress.XtraScheduler.TimeScale15Minutes = New DevExpress.XtraScheduler.TimeScale15Minutes()
        Dim TimeRuler3 As DevExpress.XtraScheduler.TimeRuler = New DevExpress.XtraScheduler.TimeRuler()
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTien_Do_Luu))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.Bar2 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.Timer_Data_hen = New System.Windows.Forms.Timer(Me.components)
        Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Tab6 = New System.Windows.Forms.TabPage()
        Me.Master_ChayThu = New DevExpress.XtraGrid.GridControl()
        Me.Master_ChayThuGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView16 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView17 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CbbCVDV_Chaythu = New System.Windows.Forms.ComboBox()
        Me.Tab5 = New System.Windows.Forms.TabPage()
        Me.Master_Dung = New DevExpress.XtraGrid.GridControl()
        Me.Master_DungGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView13 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView14 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CbbCVDV_Dung = New System.Windows.Forms.ComboBox()
        Me.Tab4 = New System.Windows.Forms.TabPage()
        Me.Master_HonHop = New DevExpress.XtraGrid.GridControl()
        Me.Master_HonHopGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView11 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CbbCVDV_HonHop = New System.Windows.Forms.ComboBox()
        Me.Tab3 = New System.Windows.Forms.TabPage()
        Me.SplitContainer_Right = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer_Left = New System.Windows.Forms.SplitContainer()
        Me.Master_Cho_Lap_KH = New DevExpress.XtraGrid.GridControl()
        Me.Master_Cho_Lap_KHGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GBLoc_Xe = New System.Windows.Forms.GroupBox()
        Me.TxtSo_Ro_Cho_Lap_KH = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe_Cho_Lap_KH = New System.Windows.Forms.TextBox()
        Me.SplitContainer_Tree = New System.Windows.Forms.SplitContainer()
        Me.ResourcesTree = New DevExpress.XtraScheduler.UI.ResourcesTree()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.SchedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
        Me.SchedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.LabTotal = New System.Windows.Forms.Label()
        Me.TabSua_Xong_Mau_XE = New System.Windows.Forms.TabControl()
        Me.TabPage_Sua_Xong = New System.Windows.Forms.TabPage()
        Me.Master_Sua_Xong_KH = New DevExpress.XtraGrid.GridControl()
        Me.Master_Sua_Xong_KHGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage_Bang_Mau = New System.Windows.Forms.TabPage()
        Me.ChkUu_Tien = New System.Windows.Forms.CheckBox()
        Me.ChkGiao_Ngay_Kh_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkSCL_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkPM90_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkEM60_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkCho_Giao_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkDang_Rua_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkCho_Rua_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkFV_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkSDS_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkDung_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkIs_EM_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkIs_GJ_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkSBD_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.Lab_SCC1_01 = New System.Windows.Forms.Label()
        Me.Lab_SCC_01 = New System.Windows.Forms.Label()
        Me.Lab_SCC_02 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_02 = New System.Windows.Forms.Label()
        Me.Lab_SCC_03 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_03 = New System.Windows.Forms.Label()
        Me.Lab_SCC_04 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_04 = New System.Windows.Forms.Label()
        Me.Lab_SCC_05 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_05 = New System.Windows.Forms.Label()
        Me.Lab_SCC_06 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_06 = New System.Windows.Forms.Label()
        Me.Lab_SCC_07 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_20 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_07 = New System.Windows.Forms.Label()
        Me.Lab_SCC_20 = New System.Windows.Forms.Label()
        Me.Lab_SCC_08 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_08 = New System.Windows.Forms.Label()
        Me.Lab_SCC_09 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_19 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_09 = New System.Windows.Forms.Label()
        Me.Lab_SCC_19 = New System.Windows.Forms.Label()
        Me.Lab_SCC_10 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_10 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_18 = New System.Windows.Forms.Label()
        Me.Lab_SCC_11 = New System.Windows.Forms.Label()
        Me.Lab_SCC_18 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_11 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_17 = New System.Windows.Forms.Label()
        Me.Lab_SCC_12 = New System.Windows.Forms.Label()
        Me.Lab_SCC_17 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_12 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_16 = New System.Windows.Forms.Label()
        Me.Lab_SCC_13 = New System.Windows.Forms.Label()
        Me.Lab_SCC_16 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_13 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_15 = New System.Windows.Forms.Label()
        Me.Lab_SCC_14 = New System.Windows.Forms.Label()
        Me.Lab_SCC_15 = New System.Windows.Forms.Label()
        Me.Lab_SCC1_14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CmdRefresh_KH_SCC = New DevExpress.XtraEditors.SimpleButton()
        Me.ChkAuto_Data_KH_SCC = New System.Windows.Forms.CheckBox()
        Me.CbbTime_Data_KH_SCC = New System.Windows.Forms.ComboBox()
        Me.CbbMa_BN_KH_SCC = New System.Windows.Forms.ComboBox()
        Me.buttRemove_Filter = New DevExpress.XtraEditors.SimpleButton()
        Me.ChkDu_kien_giaoCVDV = New System.Windows.Forms.CheckBox()
        Me.ChkShow_All_Cd_Xe = New System.Windows.Forms.CheckBox()
        Me.CmdUp_TG_GX_KH_SCC = New DevExpress.XtraEditors.SimpleButton()
        Me.CbbGio_Xem = New System.Windows.Forms.ComboBox()
        Me.LabLock = New System.Windows.Forms.Label()
        Me.CbbMuc_SBD_KH_SCC = New System.Windows.Forms.ComboBox()
        Me.CbbMuc_SDS_KH_SCC = New System.Windows.Forms.ComboBox()
        Me.TxtSo_RO_KH_SCC = New System.Windows.Forms.TextBox()
        Me.CbbLoai_Xem_KH_SCC = New System.Windows.Forms.ComboBox()
        Me.CbbTang_KH_SCC = New System.Windows.Forms.ComboBox()
        Me.CbbTo_KH_SCC = New System.Windows.Forms.ComboBox()
        Me.CbbCD_KH_SCC = New System.Windows.Forms.ComboBox()
        Me.CbbKhoang_KH_SCC = New System.Windows.Forms.ComboBox()
        Me.TxtMa_Xe_KH_SCC = New System.Windows.Forms.TextBox()
        Me.CbbDo_Rong_KH_SCC = New System.Windows.Forms.ComboBox()
        Me.CbbCVDV_KH_SCC = New System.Windows.Forms.ComboBox()
        Me.TxtM_Ngay_Ct_KH_SCC = New ClsTextBox.txtDate1()
        Me.CbbTrang_thai = New System.Windows.Forms.ComboBox()
        Me.Tab2 = New System.Windows.Forms.TabPage()
        Me.Master_TiepDon = New DevExpress.XtraGrid.GridControl()
        Me.Master_TiepDonGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView12 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView15 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.CbbCVDV_TiepDon = New System.Windows.Forms.ComboBox()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Master_Hen = New DevExpress.XtraGrid.GridControl()
        Me.Master_HenGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabCVDV = New System.Windows.Forms.TabControl()
        Me.Tab1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer_Hen = New System.Windows.Forms.SplitContainer()
        Me.ChkHen_SDS = New System.Windows.Forms.CheckBox()
        Me.CbbTo_Hen = New System.Windows.Forms.ComboBox()
        Me.ChkAuto_Data_Hen = New System.Windows.Forms.CheckBox()
        Me.TxtM_Ngay_Ct_hen = New ClsTextBox.txtDate1()
        Me.CbbTime_Data_Hen = New System.Windows.Forms.ComboBox()
        Me.ChkHen_SBD = New System.Windows.Forms.CheckBox()
        Me.CbbCVDV_Hen = New System.Windows.Forms.ComboBox()
        Me.ChkHen_SCC = New System.Windows.Forms.CheckBox()
        Me.Tab7 = New System.Windows.Forms.TabPage()
        Me.Master_ThemGio = New DevExpress.XtraGrid.GridControl()
        Me.Master_ThemGioGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView19 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView20 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.CbbCVDV_ThemGio = New System.Windows.Forms.ComboBox()
        Me.Tab8 = New System.Windows.Forms.TabPage()
        Me.Master_khac = New DevExpress.XtraGrid.GridControl()
        Me.Master_khacGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView18 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView21 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.CbbCVDV_Khac = New System.Windows.Forms.ComboBox()
        Me.Tab9 = New System.Windows.Forms.TabPage()
        Me.Master_HieuSuat = New DevExpress.XtraGrid.GridControl()
        Me.Master_HieuSuatGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView22 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView23 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.CbbLoai_HieuSuat = New System.Windows.Forms.ComboBox()
        Me.CbbCVDV_HieuSuat = New System.Windows.Forms.ComboBox()
        Me.Timer_Data_KH_SC = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_PercentComplete = New System.Windows.Forms.Timer(Me.components)
        Me.PopupMenuSchedulerControl = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.CmbFullScreen = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdThu_Nho = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdDong_Lai = New DevExpress.XtraEditors.SimpleButton()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Tab6.SuspendLayout()
        CType(Me.Master_ChayThu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_ChayThuGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Tab5.SuspendLayout()
        CType(Me.Master_Dung, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_DungGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Tab4.SuspendLayout()
        CType(Me.Master_HonHop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_HonHopGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Tab3.SuspendLayout()
        CType(Me.SplitContainer_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Right.Panel1.SuspendLayout()
        Me.SplitContainer_Right.Panel2.SuspendLayout()
        Me.SplitContainer_Right.SuspendLayout()
        CType(Me.SplitContainer_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Left.Panel1.SuspendLayout()
        Me.SplitContainer_Left.Panel2.SuspendLayout()
        Me.SplitContainer_Left.SuspendLayout()
        CType(Me.Master_Cho_Lap_KH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_Cho_Lap_KHGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBLoc_Xe.SuspendLayout()
        CType(Me.SplitContainer_Tree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Tree.Panel1.SuspendLayout()
        Me.SplitContainer_Tree.Panel2.SuspendLayout()
        Me.SplitContainer_Tree.SuspendLayout()
        CType(Me.ResourcesTree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabSua_Xong_Mau_XE.SuspendLayout()
        Me.TabPage_Sua_Xong.SuspendLayout()
        CType(Me.Master_Sua_Xong_KH, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_Sua_Xong_KHGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_Bang_Mau.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Tab2.SuspendLayout()
        CType(Me.Master_TiepDon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_TiepDonGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_Hen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_HenGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabCVDV.SuspendLayout()
        Me.Tab1.SuspendLayout()
        CType(Me.SplitContainer_Hen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Hen.Panel1.SuspendLayout()
        Me.SplitContainer_Hen.Panel2.SuspendLayout()
        Me.SplitContainer_Hen.SuspendLayout()
        Me.Tab7.SuspendLayout()
        CType(Me.Master_ThemGio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_ThemGioGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.Tab8.SuspendLayout()
        CType(Me.Master_khac, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_khacGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Tab9.SuspendLayout()
        CType(Me.Master_HieuSuat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_HieuSuatGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView23, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        CType(Me.PopupMenuSchedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 518)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1200, 10)
        Me.GroupBoxLine.Visible = False
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(1000, 533)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1102, 533)
        Me.ButtExit.Visible = False
        '
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1, Me.Bar2})
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.MaxItemId = 0
        '
        'Bar1
        '
        Me.Bar1.BarName = "Custom 1"
        Me.Bar1.DockCol = 0
        Me.Bar1.DockRow = 0
        Me.Bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar1.Text = "Custom 1"
        '
        'Bar2
        '
        Me.Bar2.BarName = "Custom 2"
        Me.Bar2.DockCol = 0
        Me.Bar2.DockRow = 1
        Me.Bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
        Me.Bar2.Text = "Custom 2"
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1204, 58)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 545)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1204, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 58)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 487)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1204, 58)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 487)
        '
        'PopupMenu
        '
        Me.PopupMenu.Manager = Me.BarManager1
        Me.PopupMenu.Name = "PopupMenu"
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
        'GridView4
        '
        Me.GridView4.Name = "GridView4"
        '
        'Tab6
        '
        Me.Tab6.Controls.Add(Me.Master_ChayThu)
        Me.Tab6.Controls.Add(Me.Panel4)
        Me.Tab6.Location = New System.Drawing.Point(4, 22)
        Me.Tab6.Name = "Tab6"
        Me.Tab6.Size = New System.Drawing.Size(1195, 497)
        Me.Tab6.TabIndex = 5
        Me.Tab6.Text = "CHẠY THỬ"
        Me.Tab6.UseVisualStyleBackColor = True
        '
        'Master_ChayThu
        '
        Me.Master_ChayThu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_ChayThu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_ChayThu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_ChayThu.Location = New System.Drawing.Point(0, 0)
        Me.Master_ChayThu.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_ChayThu.MainView = Me.Master_ChayThuGRV
        Me.Master_ChayThu.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_ChayThu.Name = "Master_ChayThu"
        Me.Master_ChayThu.Size = New System.Drawing.Size(1195, 461)
        Me.Master_ChayThu.TabIndex = 448
        Me.Master_ChayThu.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_ChayThuGRV, Me.GridView16, Me.GridView17})
        '
        'Master_ChayThuGRV
        '
        Me.Master_ChayThuGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_ChayThuGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_ChayThuGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_ChayThuGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_ChayThuGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_ChayThuGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_ChayThuGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_ChayThuGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_ChayThuGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_ChayThuGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_ChayThuGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_ChayThuGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_ChayThuGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.Master_ChayThuGRV.GridControl = Me.Master_ChayThu
        Me.Master_ChayThuGRV.GroupRowHeight = 30
        Me.Master_ChayThuGRV.Name = "Master_ChayThuGRV"
        Me.Master_ChayThuGRV.OptionsBehavior.Editable = False
        Me.Master_ChayThuGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_ChayThuGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_ChayThuGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_ChayThuGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_ChayThuGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Master_ChayThuGRV.OptionsView.ShowGroupPanel = False
        Me.Master_ChayThuGRV.RowHeight = 22
        '
        'GridView16
        '
        Me.GridView16.GridControl = Me.Master_ChayThu
        Me.GridView16.Name = "GridView16"
        '
        'GridView17
        '
        Me.GridView17.GridControl = Me.Master_ChayThu
        Me.GridView17.Name = "GridView17"
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CbbCVDV_Chaythu)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 461)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1195, 36)
        Me.Panel4.TabIndex = 447
        '
        'CbbCVDV_Chaythu
        '
        Me.CbbCVDV_Chaythu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbCVDV_Chaythu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbCVDV_Chaythu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbCVDV_Chaythu.ForeColor = System.Drawing.Color.Navy
        Me.CbbCVDV_Chaythu.FormattingEnabled = True
        Me.CbbCVDV_Chaythu.Location = New System.Drawing.Point(4, 7)
        Me.CbbCVDV_Chaythu.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbCVDV_Chaythu.Name = "CbbCVDV_Chaythu"
        Me.CbbCVDV_Chaythu.Size = New System.Drawing.Size(152, 21)
        Me.CbbCVDV_Chaythu.TabIndex = 7121
        '
        'Tab5
        '
        Me.Tab5.Controls.Add(Me.Master_Dung)
        Me.Tab5.Controls.Add(Me.Panel3)
        Me.Tab5.Location = New System.Drawing.Point(4, 22)
        Me.Tab5.Name = "Tab5"
        Me.Tab5.Size = New System.Drawing.Size(1195, 497)
        Me.Tab5.TabIndex = 4
        Me.Tab5.Text = "XE DỪNG"
        Me.Tab5.UseVisualStyleBackColor = True
        '
        'Master_Dung
        '
        Me.Master_Dung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_Dung.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_Dung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_Dung.Location = New System.Drawing.Point(0, 0)
        Me.Master_Dung.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_Dung.MainView = Me.Master_DungGRV
        Me.Master_Dung.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_Dung.Name = "Master_Dung"
        Me.Master_Dung.Size = New System.Drawing.Size(1195, 461)
        Me.Master_Dung.TabIndex = 448
        Me.Master_Dung.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_DungGRV, Me.GridView13, Me.GridView14})
        '
        'Master_DungGRV
        '
        Me.Master_DungGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_DungGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_DungGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_DungGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_DungGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_DungGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_DungGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_DungGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_DungGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_DungGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_DungGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_DungGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_DungGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.Master_DungGRV.GridControl = Me.Master_Dung
        Me.Master_DungGRV.GroupRowHeight = 30
        Me.Master_DungGRV.Name = "Master_DungGRV"
        Me.Master_DungGRV.OptionsBehavior.Editable = False
        Me.Master_DungGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_DungGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_DungGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_DungGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_DungGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Master_DungGRV.OptionsView.ShowGroupPanel = False
        Me.Master_DungGRV.RowHeight = 22
        '
        'GridView13
        '
        Me.GridView13.GridControl = Me.Master_Dung
        Me.GridView13.Name = "GridView13"
        '
        'GridView14
        '
        Me.GridView14.GridControl = Me.Master_Dung
        Me.GridView14.Name = "GridView14"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.CbbCVDV_Dung)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 461)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1195, 36)
        Me.Panel3.TabIndex = 447
        '
        'CbbCVDV_Dung
        '
        Me.CbbCVDV_Dung.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbCVDV_Dung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbCVDV_Dung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbCVDV_Dung.ForeColor = System.Drawing.Color.Navy
        Me.CbbCVDV_Dung.FormattingEnabled = True
        Me.CbbCVDV_Dung.Location = New System.Drawing.Point(4, 7)
        Me.CbbCVDV_Dung.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbCVDV_Dung.Name = "CbbCVDV_Dung"
        Me.CbbCVDV_Dung.Size = New System.Drawing.Size(152, 21)
        Me.CbbCVDV_Dung.TabIndex = 7121
        '
        'Tab4
        '
        Me.Tab4.Controls.Add(Me.Master_HonHop)
        Me.Tab4.Controls.Add(Me.Panel2)
        Me.Tab4.Location = New System.Drawing.Point(4, 22)
        Me.Tab4.Name = "Tab4"
        Me.Tab4.Size = New System.Drawing.Size(1195, 497)
        Me.Tab4.TabIndex = 3
        Me.Tab4.Text = "XE HỖN HỢP"
        Me.Tab4.UseVisualStyleBackColor = True
        '
        'Master_HonHop
        '
        Me.Master_HonHop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_HonHop.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_HonHop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_HonHop.Location = New System.Drawing.Point(0, 0)
        Me.Master_HonHop.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_HonHop.MainView = Me.Master_HonHopGRV
        Me.Master_HonHop.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_HonHop.Name = "Master_HonHop"
        Me.Master_HonHop.Size = New System.Drawing.Size(1195, 461)
        Me.Master_HonHop.TabIndex = 446
        Me.Master_HonHop.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_HonHopGRV, Me.GridView10, Me.GridView11})
        '
        'Master_HonHopGRV
        '
        Me.Master_HonHopGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_HonHopGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_HonHopGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_HonHopGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_HonHopGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_HonHopGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_HonHopGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_HonHopGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_HonHopGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_HonHopGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_HonHopGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_HonHopGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_HonHopGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.Master_HonHopGRV.GridControl = Me.Master_HonHop
        Me.Master_HonHopGRV.GroupRowHeight = 30
        Me.Master_HonHopGRV.Name = "Master_HonHopGRV"
        Me.Master_HonHopGRV.OptionsBehavior.Editable = False
        Me.Master_HonHopGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_HonHopGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_HonHopGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_HonHopGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_HonHopGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Master_HonHopGRV.OptionsView.ShowGroupPanel = False
        Me.Master_HonHopGRV.RowHeight = 22
        '
        'GridView10
        '
        Me.GridView10.GridControl = Me.Master_HonHop
        Me.GridView10.Name = "GridView10"
        '
        'GridView11
        '
        Me.GridView11.GridControl = Me.Master_HonHop
        Me.GridView11.Name = "GridView11"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CbbCVDV_HonHop)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 461)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1195, 36)
        Me.Panel2.TabIndex = 0
        '
        'CbbCVDV_HonHop
        '
        Me.CbbCVDV_HonHop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbCVDV_HonHop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbCVDV_HonHop.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbCVDV_HonHop.ForeColor = System.Drawing.Color.Navy
        Me.CbbCVDV_HonHop.FormattingEnabled = True
        Me.CbbCVDV_HonHop.Location = New System.Drawing.Point(4, 7)
        Me.CbbCVDV_HonHop.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbCVDV_HonHop.Name = "CbbCVDV_HonHop"
        Me.CbbCVDV_HonHop.Size = New System.Drawing.Size(152, 21)
        Me.CbbCVDV_HonHop.TabIndex = 7121
        '
        'Tab3
        '
        Me.Tab3.Controls.Add(Me.SplitContainer_Right)
        Me.Tab3.Controls.Add(Me.Panel1)
        Me.Tab3.Location = New System.Drawing.Point(4, 22)
        Me.Tab3.Name = "Tab3"
        Me.Tab3.Size = New System.Drawing.Size(1195, 497)
        Me.Tab3.TabIndex = 2
        Me.Tab3.Text = "KẾ HOẠCH"
        Me.Tab3.UseVisualStyleBackColor = True
        '
        'SplitContainer_Right
        '
        Me.SplitContainer_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer_Right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Right.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Right.Name = "SplitContainer_Right"
        '
        'SplitContainer_Right.Panel1
        '
        Me.SplitContainer_Right.Panel1.BackColor = System.Drawing.Color.White
        Me.SplitContainer_Right.Panel1.Controls.Add(Me.SplitContainer_Left)
        Me.SplitContainer_Right.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer_Right.Panel1MinSize = 0
        '
        'SplitContainer_Right.Panel2
        '
        Me.SplitContainer_Right.Panel2.Controls.Add(Me.TabSua_Xong_Mau_XE)
        Me.SplitContainer_Right.Panel2.Controls.Add(Me.LabTotal)
        Me.SplitContainer_Right.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer_Right.Panel2MinSize = 0
        Me.SplitContainer_Right.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer_Right.Size = New System.Drawing.Size(1195, 462)
        Me.SplitContainer_Right.SplitterDistance = 888
        Me.SplitContainer_Right.TabIndex = 1956
        '
        'SplitContainer_Left
        '
        Me.SplitContainer_Left.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Left.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Left.Margin = New System.Windows.Forms.Padding(1)
        Me.SplitContainer_Left.Name = "SplitContainer_Left"
        '
        'SplitContainer_Left.Panel1
        '
        Me.SplitContainer_Left.Panel1.Controls.Add(Me.Master_Cho_Lap_KH)
        Me.SplitContainer_Left.Panel1.Controls.Add(Me.GBLoc_Xe)
        Me.SplitContainer_Left.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer_Left.Panel1MinSize = 0
        '
        'SplitContainer_Left.Panel2
        '
        Me.SplitContainer_Left.Panel2.Controls.Add(Me.SplitContainer_Tree)
        Me.SplitContainer_Left.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer_Left.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer_Left.Size = New System.Drawing.Size(886, 460)
        Me.SplitContainer_Left.SplitterDistance = 160
        Me.SplitContainer_Left.SplitterWidth = 1
        Me.SplitContainer_Left.TabIndex = 4
        '
        'Master_Cho_Lap_KH
        '
        Me.Master_Cho_Lap_KH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_Cho_Lap_KH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_Cho_Lap_KH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_Cho_Lap_KH.Location = New System.Drawing.Point(0, 0)
        Me.Master_Cho_Lap_KH.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_Cho_Lap_KH.MainView = Me.Master_Cho_Lap_KHGRV
        Me.Master_Cho_Lap_KH.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_Cho_Lap_KH.Name = "Master_Cho_Lap_KH"
        Me.Master_Cho_Lap_KH.Size = New System.Drawing.Size(160, 425)
        Me.Master_Cho_Lap_KH.TabIndex = 449
        Me.Master_Cho_Lap_KH.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_Cho_Lap_KHGRV})
        '
        'Master_Cho_Lap_KHGRV
        '
        Me.Master_Cho_Lap_KHGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_Cho_Lap_KHGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_Cho_Lap_KHGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_Cho_Lap_KHGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_Cho_Lap_KHGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_Cho_Lap_KHGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_Cho_Lap_KHGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_Cho_Lap_KHGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_Cho_Lap_KHGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_Cho_Lap_KHGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_Cho_Lap_KHGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_Cho_Lap_KHGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_Cho_Lap_KHGRV.GridControl = Me.Master_Cho_Lap_KH
        Me.Master_Cho_Lap_KHGRV.GroupRowHeight = 30
        Me.Master_Cho_Lap_KHGRV.Name = "Master_Cho_Lap_KHGRV"
        Me.Master_Cho_Lap_KHGRV.OptionsBehavior.Editable = False
        Me.Master_Cho_Lap_KHGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_Cho_Lap_KHGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_Cho_Lap_KHGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_Cho_Lap_KHGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_Cho_Lap_KHGRV.OptionsView.ShowGroupPanel = False
        Me.Master_Cho_Lap_KHGRV.RowHeight = 22
        '
        'GBLoc_Xe
        '
        Me.GBLoc_Xe.Controls.Add(Me.TxtSo_Ro_Cho_Lap_KH)
        Me.GBLoc_Xe.Controls.Add(Me.TxtMa_Xe_Cho_Lap_KH)
        Me.GBLoc_Xe.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GBLoc_Xe.Location = New System.Drawing.Point(0, 425)
        Me.GBLoc_Xe.Name = "GBLoc_Xe"
        Me.GBLoc_Xe.Size = New System.Drawing.Size(160, 35)
        Me.GBLoc_Xe.TabIndex = 448
        Me.GBLoc_Xe.TabStop = False
        '
        'TxtSo_Ro_Cho_Lap_KH
        '
        Me.TxtSo_Ro_Cho_Lap_KH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSo_Ro_Cho_Lap_KH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSo_Ro_Cho_Lap_KH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro_Cho_Lap_KH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_Ro_Cho_Lap_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ro_Cho_Lap_KH.Location = New System.Drawing.Point(1, 8)
        Me.TxtSo_Ro_Cho_Lap_KH.Name = "TxtSo_Ro_Cho_Lap_KH"
        Me.TxtSo_Ro_Cho_Lap_KH.Size = New System.Drawing.Size(118, 23)
        Me.TxtSo_Ro_Cho_Lap_KH.TabIndex = 1959
        Me.TxtSo_Ro_Cho_Lap_KH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtMa_Xe_Cho_Lap_KH
        '
        Me.TxtMa_Xe_Cho_Lap_KH.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Xe_Cho_Lap_KH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMa_Xe_Cho_Lap_KH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMa_Xe_Cho_Lap_KH.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe_Cho_Lap_KH.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe_Cho_Lap_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe_Cho_Lap_KH.Location = New System.Drawing.Point(121, 8)
        Me.TxtMa_Xe_Cho_Lap_KH.Name = "TxtMa_Xe_Cho_Lap_KH"
        Me.TxtMa_Xe_Cho_Lap_KH.Size = New System.Drawing.Size(124, 23)
        Me.TxtMa_Xe_Cho_Lap_KH.TabIndex = 1958
        Me.TxtMa_Xe_Cho_Lap_KH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'SplitContainer_Tree
        '
        Me.SplitContainer_Tree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Tree.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Tree.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer_Tree.Name = "SplitContainer_Tree"
        '
        'SplitContainer_Tree.Panel1
        '
        Me.SplitContainer_Tree.Panel1.Controls.Add(Me.ResourcesTree)
        Me.SplitContainer_Tree.Panel1MinSize = 0
        '
        'SplitContainer_Tree.Panel2
        '
        Me.SplitContainer_Tree.Panel2.Controls.Add(Me.SchedulerControl)
        Me.SplitContainer_Tree.Panel2MinSize = 0
        Me.SplitContainer_Tree.Size = New System.Drawing.Size(725, 460)
        Me.SplitContainer_Tree.SplitterDistance = 118
        Me.SplitContainer_Tree.SplitterWidth = 1
        Me.SplitContainer_Tree.TabIndex = 6
        '
        'ResourcesTree
        '
        Me.ResourcesTree.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.ResourcesTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResourcesTree.FixedLineWidth = 1
        Me.ResourcesTree.HorzScrollStep = 1
        Me.ResourcesTree.Location = New System.Drawing.Point(0, 0)
        Me.ResourcesTree.Margin = New System.Windows.Forms.Padding(0)
        Me.ResourcesTree.MenuManager = Me.BarManager1
        Me.ResourcesTree.Name = "ResourcesTree"
        Me.ResourcesTree.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFullFocus
        Me.ResourcesTree.OptionsView.ShowButtons = False
        Me.ResourcesTree.OptionsView.ShowRoot = False
        Me.ResourcesTree.OptionsView.ShowVertLines = True
        Me.ResourcesTree.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.ResourcesTree.SchedulerControl = Me.SchedulerControl
        Me.ResourcesTree.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow
        Me.ResourcesTree.Size = New System.Drawing.Size(118, 460)
        Me.ResourcesTree.TabIndex = 6
        Me.ResourcesTree.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None
        Me.ResourcesTree.VertScrollVisibility = DevExpress.XtraTreeList.ScrollVisibility.Always
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'SchedulerControl
        '
        Me.SchedulerControl.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Gantt
        Me.SchedulerControl.Appearance.Appointment.Options.UseTextOptions = True
        Me.SchedulerControl.Appearance.Appointment.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.SchedulerControl.Appearance.Appointment.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.SchedulerControl.Appearance.Appointment.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.SchedulerControl.Appearance.HeaderCaption.Options.UseImage = True
        Me.SchedulerControl.Appearance.ResourceHeaderCaption.ForeColor = System.Drawing.Color.Blue
        Me.SchedulerControl.Appearance.ResourceHeaderCaption.Options.UseBackColor = True
        Me.SchedulerControl.Appearance.ResourceHeaderCaption.Options.UseBorderColor = True
        Me.SchedulerControl.Appearance.ResourceHeaderCaption.Options.UseFont = True
        Me.SchedulerControl.Appearance.ResourceHeaderCaption.Options.UseForeColor = True
        Me.SchedulerControl.Appearance.ResourceHeaderCaption.Options.UseImage = True
        Me.SchedulerControl.Appearance.ResourceHeaderCaption.Options.UseTextOptions = True
        Me.SchedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SchedulerControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SchedulerControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SchedulerControl.Location = New System.Drawing.Point(0, 0)
        Me.SchedulerControl.Margin = New System.Windows.Forms.Padding(0)
        Me.SchedulerControl.MenuManager = Me.BarManager1
        Me.SchedulerControl.Name = "SchedulerControl"
        Me.SchedulerControl.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None
        Me.SchedulerControl.OptionsView.ResourceHeaders.Height = 80
        Me.SchedulerControl.OptionsView.ResourceHeaders.ImageSize = New System.Drawing.Size(10, 10)
        Me.SchedulerControl.OptionsView.ResourceHeaders.RotateCaption = False
        Me.SchedulerControl.OptionsView.ToolTipVisibility = DevExpress.XtraScheduler.ToolTipVisibility.Always
        Me.SchedulerControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SchedulerControl.Size = New System.Drawing.Size(606, 460)
        Me.SchedulerControl.Start = New Date(2017, 8, 16, 0, 0, 0, 0)
        Me.SchedulerControl.Storage = Me.SchedulerStorage
        Me.SchedulerControl.TabIndex = 3
        Me.SchedulerControl.Text = "SchedulerControl1"
        Me.SchedulerControl.ToolTipController = Me.ToolTipController1
        Me.SchedulerControl.Views.DayView.TimeRulers.Add(TimeRuler1)
        Me.SchedulerControl.Views.FullWeekView.Enabled = True
        Me.SchedulerControl.Views.FullWeekView.TimeRulers.Add(TimeRuler2)
        Me.SchedulerControl.Views.GanttView.CellsAutoHeightOptions.Enabled = True
        Me.SchedulerControl.Views.GanttView.CellsAutoHeightOptions.MinHeight = 150
        TimeScaleYear1.Enabled = False
        TimeScaleQuarter1.Enabled = False
        TimeScaleMonth1.Enabled = False
        TimeScaleWeek1.Enabled = False
        Me.SchedulerControl.Views.GanttView.Scales.Add(TimeScaleYear1)
        Me.SchedulerControl.Views.GanttView.Scales.Add(TimeScaleQuarter1)
        Me.SchedulerControl.Views.GanttView.Scales.Add(TimeScaleMonth1)
        Me.SchedulerControl.Views.GanttView.Scales.Add(TimeScaleWeek1)
        Me.SchedulerControl.Views.GanttView.Scales.Add(TimeScaleDay1)
        Me.SchedulerControl.Views.GanttView.Scales.Add(TimeScaleHour1)
        Me.SchedulerControl.Views.GanttView.Scales.Add(TimeScale15Minutes1)
        Me.SchedulerControl.Views.WorkWeekView.TimeRulers.Add(TimeRuler3)
        '
        'SchedulerStorage
        '
        Me.SchedulerStorage.Appointments.Labels.Add(System.Drawing.Color.LightGray, "Chờ sửa chữa", "&Chờ sửa chữa")
        Me.SchedulerStorage.Appointments.Labels.Add(System.Drawing.SystemColors.Highlight, "Đang sửa chữa", "&Đang sửa chữa")
        Me.SchedulerStorage.Appointments.Labels.Add(System.Drawing.Color.Red, "Dừng", "&Dừng")
        Me.SchedulerStorage.Appointments.Labels.Add(System.Drawing.Color.MediumPurple, "Đặt chỗ", "Đặt chỗ")
        Me.SchedulerStorage.Appointments.Labels.Add(System.Drawing.Color.Yellow, "Đặt hẹn", "Đặt hẹn")
        Me.SchedulerStorage.Appointments.Labels.Add(System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(147, Byte), Integer)), "Must Attend", "Must &Attend")
        Me.SchedulerStorage.Appointments.Labels.Add(System.Drawing.Color.FromArgb(CType(CType(199, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(255, Byte), Integer)), "Travel Required", "&Travel Required")
        Me.SchedulerStorage.Appointments.Labels.Add(System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(152, Byte), Integer)), "Needs Preparation", "&Needs Preparation")
        Me.SchedulerStorage.Appointments.Labels.Add(System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(233, Byte), Integer)), "Birthday", "&Birthday")
        Me.SchedulerStorage.Appointments.Labels.Add(System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(233, Byte), Integer), CType(CType(223, Byte), Integer)), "Anniversary", "&Anniversary")
        Me.SchedulerStorage.Appointments.Labels.Add(System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(165, Byte), Integer)), "Phone Call", "Phone &Call")
        '
        'ToolTipController1
        '
        Me.ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip
        '
        'LabTotal
        '
        Me.LabTotal.BackColor = System.Drawing.Color.Green
        Me.LabTotal.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LabTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTotal.ForeColor = System.Drawing.Color.White
        Me.LabTotal.Location = New System.Drawing.Point(0, 421)
        Me.LabTotal.Name = "LabTotal"
        Me.LabTotal.Size = New System.Drawing.Size(301, 39)
        Me.LabTotal.TabIndex = 1978
        Me.LabTotal.Text = "10"
        Me.LabTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TabSua_Xong_Mau_XE
        '
        Me.TabSua_Xong_Mau_XE.Controls.Add(Me.TabPage_Sua_Xong)
        Me.TabSua_Xong_Mau_XE.Controls.Add(Me.TabPage_Bang_Mau)
        Me.TabSua_Xong_Mau_XE.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabSua_Xong_Mau_XE.Location = New System.Drawing.Point(0, 0)
        Me.TabSua_Xong_Mau_XE.Name = "TabSua_Xong_Mau_XE"
        Me.TabSua_Xong_Mau_XE.SelectedIndex = 0
        Me.TabSua_Xong_Mau_XE.Size = New System.Drawing.Size(301, 421)
        Me.TabSua_Xong_Mau_XE.TabIndex = 7139
        '
        'TabPage_Sua_Xong
        '
        Me.TabPage_Sua_Xong.Controls.Add(Me.Master_Sua_Xong_KH)
        Me.TabPage_Sua_Xong.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Sua_Xong.Name = "TabPage_Sua_Xong"
        Me.TabPage_Sua_Xong.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage_Sua_Xong.Size = New System.Drawing.Size(293, 395)
        Me.TabPage_Sua_Xong.TabIndex = 0
        Me.TabPage_Sua_Xong.Text = "Sửa xong"
        Me.TabPage_Sua_Xong.UseVisualStyleBackColor = True
        '
        'Master_Sua_Xong_KH
        '
        Me.Master_Sua_Xong_KH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_Sua_Xong_KH.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_Sua_Xong_KH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GridLevelNode1.RelationName = "Level1"
        Me.Master_Sua_Xong_KH.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me.Master_Sua_Xong_KH.Location = New System.Drawing.Point(3, 3)
        Me.Master_Sua_Xong_KH.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_Sua_Xong_KH.MainView = Me.Master_Sua_Xong_KHGRV
        Me.Master_Sua_Xong_KH.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_Sua_Xong_KH.Name = "Master_Sua_Xong_KH"
        Me.Master_Sua_Xong_KH.Size = New System.Drawing.Size(287, 389)
        Me.Master_Sua_Xong_KH.TabIndex = 447
        Me.Master_Sua_Xong_KH.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_Sua_Xong_KHGRV})
        '
        'Master_Sua_Xong_KHGRV
        '
        Me.Master_Sua_Xong_KHGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_Sua_Xong_KHGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_Sua_Xong_KHGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_Sua_Xong_KHGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_Sua_Xong_KHGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_Sua_Xong_KHGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_Sua_Xong_KHGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_Sua_Xong_KHGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_Sua_Xong_KHGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_Sua_Xong_KHGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_Sua_Xong_KHGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_Sua_Xong_KHGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_Sua_Xong_KHGRV.GridControl = Me.Master_Sua_Xong_KH
        Me.Master_Sua_Xong_KHGRV.GroupRowHeight = 30
        Me.Master_Sua_Xong_KHGRV.Name = "Master_Sua_Xong_KHGRV"
        Me.Master_Sua_Xong_KHGRV.OptionsBehavior.Editable = False
        Me.Master_Sua_Xong_KHGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_Sua_Xong_KHGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_Sua_Xong_KHGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_Sua_Xong_KHGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_Sua_Xong_KHGRV.OptionsView.ShowGroupPanel = False
        Me.Master_Sua_Xong_KHGRV.RowHeight = 22
        '
        'TabPage_Bang_Mau
        '
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkUu_Tien)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkGiao_Ngay_Kh_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkSCL_KH_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkPM90_KH_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkEM60_KH_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkCho_Giao_KH_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkDang_Rua_KH_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkCho_Rua_KH_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkFV_KH_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkSDS_KH_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkDung_KH_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkIs_EM_KH_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkIs_GJ_KH_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.ChkSBD_KH_SCC)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_01)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_01)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_02)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_02)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_03)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_03)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_04)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_04)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_05)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_05)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_06)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_06)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_07)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_20)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_07)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_20)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_08)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_08)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_09)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_19)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_09)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_19)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_10)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_10)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_18)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_11)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_18)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_11)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_17)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_12)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_17)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_12)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_16)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_13)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_16)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_13)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_15)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_14)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC_15)
        Me.TabPage_Bang_Mau.Controls.Add(Me.Lab_SCC1_14)
        Me.TabPage_Bang_Mau.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Bang_Mau.Name = "TabPage_Bang_Mau"
        Me.TabPage_Bang_Mau.Size = New System.Drawing.Size(293, 395)
        Me.TabPage_Bang_Mau.TabIndex = 1
        Me.TabPage_Bang_Mau.Text = "Bảng màu"
        Me.TabPage_Bang_Mau.UseVisualStyleBackColor = True
        '
        'ChkUu_Tien
        '
        Me.ChkUu_Tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkUu_Tien.AutoSize = True
        Me.ChkUu_Tien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkUu_Tien.ForeColor = System.Drawing.Color.Blue
        Me.ChkUu_Tien.Location = New System.Drawing.Point(74, 7634)
        Me.ChkUu_Tien.Name = "ChkUu_Tien"
        Me.ChkUu_Tien.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkUu_Tien.Size = New System.Drawing.Size(60, 17)
        Me.ChkUu_Tien.TabIndex = 7143
        Me.ChkUu_Tien.TabStop = False
        Me.ChkUu_Tien.Tag = "Priority"
        Me.ChkUu_Tien.Text = "Ưu tiên"
        Me.ChkUu_Tien.UseVisualStyleBackColor = True
        '
        'ChkGiao_Ngay_Kh_SCC
        '
        Me.ChkGiao_Ngay_Kh_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkGiao_Ngay_Kh_SCC.AutoSize = True
        Me.ChkGiao_Ngay_Kh_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkGiao_Ngay_Kh_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkGiao_Ngay_Kh_SCC.Location = New System.Drawing.Point(72, 7710)
        Me.ChkGiao_Ngay_Kh_SCC.Name = "ChkGiao_Ngay_Kh_SCC"
        Me.ChkGiao_Ngay_Kh_SCC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkGiao_Ngay_Kh_SCC.Size = New System.Drawing.Size(74, 17)
        Me.ChkGiao_Ngay_Kh_SCC.TabIndex = 7142
        Me.ChkGiao_Ngay_Kh_SCC.TabStop = False
        Me.ChkGiao_Ngay_Kh_SCC.Tag = "Delivery day"
        Me.ChkGiao_Ngay_Kh_SCC.Text = "Giao ngày"
        Me.ChkGiao_Ngay_Kh_SCC.UseVisualStyleBackColor = True
        '
        'ChkSCL_KH_SCC
        '
        Me.ChkSCL_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkSCL_KH_SCC.AutoSize = True
        Me.ChkSCL_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkSCL_KH_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkSCL_KH_SCC.Location = New System.Drawing.Point(72, 7652)
        Me.ChkSCL_KH_SCC.Name = "ChkSCL_KH_SCC"
        Me.ChkSCL_KH_SCC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkSCL_KH_SCC.Size = New System.Drawing.Size(46, 17)
        Me.ChkSCL_KH_SCC.TabIndex = 7141
        Me.ChkSCL_KH_SCC.TabStop = False
        Me.ChkSCL_KH_SCC.Tag = "Re-Fix"
        Me.ChkSCL_KH_SCC.Text = "SCL"
        Me.ChkSCL_KH_SCC.UseVisualStyleBackColor = True
        '
        'ChkPM90_KH_SCC
        '
        Me.ChkPM90_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkPM90_KH_SCC.AutoSize = True
        Me.ChkPM90_KH_SCC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkPM90_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkPM90_KH_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkPM90_KH_SCC.Location = New System.Drawing.Point(13, 7731)
        Me.ChkPM90_KH_SCC.Name = "ChkPM90_KH_SCC"
        Me.ChkPM90_KH_SCC.Size = New System.Drawing.Size(54, 17)
        Me.ChkPM90_KH_SCC.TabIndex = 7140
        Me.ChkPM90_KH_SCC.TabStop = False
        Me.ChkPM90_KH_SCC.Tag = "PM90"
        Me.ChkPM90_KH_SCC.Text = "PM90"
        Me.ChkPM90_KH_SCC.UseVisualStyleBackColor = True
        '
        'ChkEM60_KH_SCC
        '
        Me.ChkEM60_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkEM60_KH_SCC.AutoSize = True
        Me.ChkEM60_KH_SCC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkEM60_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkEM60_KH_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkEM60_KH_SCC.Location = New System.Drawing.Point(13, 7652)
        Me.ChkEM60_KH_SCC.Name = "ChkEM60_KH_SCC"
        Me.ChkEM60_KH_SCC.Size = New System.Drawing.Size(54, 17)
        Me.ChkEM60_KH_SCC.TabIndex = 7139
        Me.ChkEM60_KH_SCC.TabStop = False
        Me.ChkEM60_KH_SCC.Tag = "EM60"
        Me.ChkEM60_KH_SCC.Text = "EM60"
        Me.ChkEM60_KH_SCC.UseVisualStyleBackColor = True
        '
        'ChkCho_Giao_KH_SCC
        '
        Me.ChkCho_Giao_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkCho_Giao_KH_SCC.AutoSize = True
        Me.ChkCho_Giao_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkCho_Giao_KH_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkCho_Giao_KH_SCC.Location = New System.Drawing.Point(72, 7731)
        Me.ChkCho_Giao_KH_SCC.Name = "ChkCho_Giao_KH_SCC"
        Me.ChkCho_Giao_KH_SCC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkCho_Giao_KH_SCC.Size = New System.Drawing.Size(68, 17)
        Me.ChkCho_Giao_KH_SCC.TabIndex = 7138
        Me.ChkCho_Giao_KH_SCC.TabStop = False
        Me.ChkCho_Giao_KH_SCC.Tag = "Wait delivery"
        Me.ChkCho_Giao_KH_SCC.Text = "Chờ giao"
        Me.ChkCho_Giao_KH_SCC.UseVisualStyleBackColor = True
        '
        'ChkDang_Rua_KH_SCC
        '
        Me.ChkDang_Rua_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkDang_Rua_KH_SCC.AutoSize = True
        Me.ChkDang_Rua_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkDang_Rua_KH_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkDang_Rua_KH_SCC.Location = New System.Drawing.Point(134, 7636)
        Me.ChkDang_Rua_KH_SCC.Name = "ChkDang_Rua_KH_SCC"
        Me.ChkDang_Rua_KH_SCC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkDang_Rua_KH_SCC.Size = New System.Drawing.Size(70, 17)
        Me.ChkDang_Rua_KH_SCC.TabIndex = 7137
        Me.ChkDang_Rua_KH_SCC.TabStop = False
        Me.ChkDang_Rua_KH_SCC.Tag = "Washing"
        Me.ChkDang_Rua_KH_SCC.Text = "Đang rửa"
        Me.ChkDang_Rua_KH_SCC.UseVisualStyleBackColor = True
        Me.ChkDang_Rua_KH_SCC.Visible = False
        '
        'ChkCho_Rua_KH_SCC
        '
        Me.ChkCho_Rua_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkCho_Rua_KH_SCC.AutoSize = True
        Me.ChkCho_Rua_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkCho_Rua_KH_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkCho_Rua_KH_SCC.Location = New System.Drawing.Point(72, 7690)
        Me.ChkCho_Rua_KH_SCC.Name = "ChkCho_Rua_KH_SCC"
        Me.ChkCho_Rua_KH_SCC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkCho_Rua_KH_SCC.Size = New System.Drawing.Size(63, 17)
        Me.ChkCho_Rua_KH_SCC.TabIndex = 7136
        Me.ChkCho_Rua_KH_SCC.TabStop = False
        Me.ChkCho_Rua_KH_SCC.Tag = "Wait washing"
        Me.ChkCho_Rua_KH_SCC.Text = "Chờ rửa"
        Me.ChkCho_Rua_KH_SCC.UseVisualStyleBackColor = True
        '
        'ChkFV_KH_SCC
        '
        Me.ChkFV_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkFV_KH_SCC.AutoSize = True
        Me.ChkFV_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkFV_KH_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkFV_KH_SCC.Location = New System.Drawing.Point(134, 7659)
        Me.ChkFV_KH_SCC.Name = "ChkFV_KH_SCC"
        Me.ChkFV_KH_SCC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkFV_KH_SCC.Size = New System.Drawing.Size(39, 17)
        Me.ChkFV_KH_SCC.TabIndex = 7134
        Me.ChkFV_KH_SCC.TabStop = False
        Me.ChkFV_KH_SCC.Tag = "FV"
        Me.ChkFV_KH_SCC.Text = "FV"
        Me.ChkFV_KH_SCC.UseVisualStyleBackColor = True
        '
        'ChkSDS_KH_SCC
        '
        Me.ChkSDS_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkSDS_KH_SCC.AutoSize = True
        Me.ChkSDS_KH_SCC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkSDS_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkSDS_KH_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkSDS_KH_SCC.Location = New System.Drawing.Point(26, 7711)
        Me.ChkSDS_KH_SCC.Name = "ChkSDS_KH_SCC"
        Me.ChkSDS_KH_SCC.Size = New System.Drawing.Size(41, 17)
        Me.ChkSDS_KH_SCC.TabIndex = 7135
        Me.ChkSDS_KH_SCC.TabStop = False
        Me.ChkSDS_KH_SCC.Tag = "BP"
        Me.ChkSDS_KH_SCC.Text = "ĐS"
        Me.ChkSDS_KH_SCC.UseVisualStyleBackColor = True
        '
        'ChkDung_KH_SCC
        '
        Me.ChkDung_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkDung_KH_SCC.AutoSize = True
        Me.ChkDung_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkDung_KH_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkDung_KH_SCC.Location = New System.Drawing.Point(72, 7670)
        Me.ChkDung_KH_SCC.Name = "ChkDung_KH_SCC"
        Me.ChkDung_KH_SCC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkDung_KH_SCC.Size = New System.Drawing.Size(52, 17)
        Me.ChkDung_KH_SCC.TabIndex = 7133
        Me.ChkDung_KH_SCC.TabStop = False
        Me.ChkDung_KH_SCC.Tag = "Stop"
        Me.ChkDung_KH_SCC.Text = "Dừng"
        Me.ChkDung_KH_SCC.UseVisualStyleBackColor = True
        '
        'ChkIs_EM_KH_SCC
        '
        Me.ChkIs_EM_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkIs_EM_KH_SCC.AutoSize = True
        Me.ChkIs_EM_KH_SCC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkIs_EM_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkIs_EM_KH_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_EM_KH_SCC.Location = New System.Drawing.Point(25, 7634)
        Me.ChkIs_EM_KH_SCC.Name = "ChkIs_EM_KH_SCC"
        Me.ChkIs_EM_KH_SCC.Size = New System.Drawing.Size(42, 17)
        Me.ChkIs_EM_KH_SCC.TabIndex = 7131
        Me.ChkIs_EM_KH_SCC.TabStop = False
        Me.ChkIs_EM_KH_SCC.Tag = "Tel, time"
        Me.ChkIs_EM_KH_SCC.Text = "EM"
        Me.ChkIs_EM_KH_SCC.UseVisualStyleBackColor = True
        '
        'ChkIs_GJ_KH_SCC
        '
        Me.ChkIs_GJ_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkIs_GJ_KH_SCC.AutoSize = True
        Me.ChkIs_GJ_KH_SCC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkIs_GJ_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkIs_GJ_KH_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_GJ_KH_SCC.Location = New System.Drawing.Point(28, 7690)
        Me.ChkIs_GJ_KH_SCC.Name = "ChkIs_GJ_KH_SCC"
        Me.ChkIs_GJ_KH_SCC.Size = New System.Drawing.Size(39, 17)
        Me.ChkIs_GJ_KH_SCC.TabIndex = 7132
        Me.ChkIs_GJ_KH_SCC.TabStop = False
        Me.ChkIs_GJ_KH_SCC.Tag = "GJ"
        Me.ChkIs_GJ_KH_SCC.Text = "GJ"
        Me.ChkIs_GJ_KH_SCC.UseVisualStyleBackColor = True
        '
        'ChkSBD_KH_SCC
        '
        Me.ChkSBD_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkSBD_KH_SCC.AutoSize = True
        Me.ChkSBD_KH_SCC.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkSBD_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkSBD_KH_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkSBD_KH_SCC.Location = New System.Drawing.Point(26, 7670)
        Me.ChkSBD_KH_SCC.Name = "ChkSBD_KH_SCC"
        Me.ChkSBD_KH_SCC.Size = New System.Drawing.Size(41, 17)
        Me.ChkSBD_KH_SCC.TabIndex = 7130
        Me.ChkSBD_KH_SCC.TabStop = False
        Me.ChkSBD_KH_SCC.Tag = "Mainten"
        Me.ChkSBD_KH_SCC.Text = "BD"
        Me.ChkSBD_KH_SCC.UseVisualStyleBackColor = True
        '
        'Lab_SCC1_01
        '
        Me.Lab_SCC1_01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_01.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_01.Location = New System.Drawing.Point(15, 7)
        Me.Lab_SCC1_01.Name = "Lab_SCC1_01"
        Me.Lab_SCC1_01.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_01.TabIndex = 2018
        Me.Lab_SCC1_01.Text = "Đang sửa chữa"
        Me.Lab_SCC1_01.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_01.Visible = False
        '
        'Lab_SCC_01
        '
        Me.Lab_SCC_01.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_01.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_01.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_01.Location = New System.Drawing.Point(15, 24)
        Me.Lab_SCC_01.Name = "Lab_SCC_01"
        Me.Lab_SCC_01.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_01.TabIndex = 2017
        Me.Lab_SCC_01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_01.Visible = False
        '
        'Lab_SCC_02
        '
        Me.Lab_SCC_02.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_02.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_02.Location = New System.Drawing.Point(15, 68)
        Me.Lab_SCC_02.Name = "Lab_SCC_02"
        Me.Lab_SCC_02.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_02.TabIndex = 2019
        Me.Lab_SCC_02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_02.Visible = False
        '
        'Lab_SCC1_02
        '
        Me.Lab_SCC1_02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_02.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_02.Location = New System.Drawing.Point(15, 51)
        Me.Lab_SCC1_02.Name = "Lab_SCC1_02"
        Me.Lab_SCC1_02.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_02.TabIndex = 2020
        Me.Lab_SCC1_02.Text = "Đang sửa chữa"
        Me.Lab_SCC1_02.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_02.Visible = False
        '
        'Lab_SCC_03
        '
        Me.Lab_SCC_03.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_03.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_03.Location = New System.Drawing.Point(15, 108)
        Me.Lab_SCC_03.Name = "Lab_SCC_03"
        Me.Lab_SCC_03.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_03.TabIndex = 2021
        Me.Lab_SCC_03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_03.Visible = False
        '
        'Lab_SCC1_03
        '
        Me.Lab_SCC1_03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_03.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_03.Location = New System.Drawing.Point(15, 91)
        Me.Lab_SCC1_03.Name = "Lab_SCC1_03"
        Me.Lab_SCC1_03.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_03.TabIndex = 2022
        Me.Lab_SCC1_03.Text = "Đang sửa chữa"
        Me.Lab_SCC1_03.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_03.Visible = False
        '
        'Lab_SCC_04
        '
        Me.Lab_SCC_04.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_04.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_04.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_04.Location = New System.Drawing.Point(15, 151)
        Me.Lab_SCC_04.Name = "Lab_SCC_04"
        Me.Lab_SCC_04.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_04.TabIndex = 2023
        Me.Lab_SCC_04.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_04.Visible = False
        '
        'Lab_SCC1_04
        '
        Me.Lab_SCC1_04.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_04.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_04.Location = New System.Drawing.Point(15, 134)
        Me.Lab_SCC1_04.Name = "Lab_SCC1_04"
        Me.Lab_SCC1_04.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_04.TabIndex = 2024
        Me.Lab_SCC1_04.Text = "Đang sửa chữa"
        Me.Lab_SCC1_04.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_04.Visible = False
        '
        'Lab_SCC_05
        '
        Me.Lab_SCC_05.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_05.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_05.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_05.Location = New System.Drawing.Point(15, 195)
        Me.Lab_SCC_05.Name = "Lab_SCC_05"
        Me.Lab_SCC_05.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_05.TabIndex = 2025
        Me.Lab_SCC_05.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_05.Visible = False
        '
        'Lab_SCC1_05
        '
        Me.Lab_SCC1_05.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_05.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_05.Location = New System.Drawing.Point(15, 178)
        Me.Lab_SCC1_05.Name = "Lab_SCC1_05"
        Me.Lab_SCC1_05.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_05.TabIndex = 2026
        Me.Lab_SCC1_05.Text = "Đang sửa chữa"
        Me.Lab_SCC1_05.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_05.Visible = False
        '
        'Lab_SCC_06
        '
        Me.Lab_SCC_06.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_06.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_06.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_06.Location = New System.Drawing.Point(15, 238)
        Me.Lab_SCC_06.Name = "Lab_SCC_06"
        Me.Lab_SCC_06.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_06.TabIndex = 2027
        Me.Lab_SCC_06.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_06.Visible = False
        '
        'Lab_SCC1_06
        '
        Me.Lab_SCC1_06.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_06.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_06.Location = New System.Drawing.Point(15, 221)
        Me.Lab_SCC1_06.Name = "Lab_SCC1_06"
        Me.Lab_SCC1_06.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_06.TabIndex = 2028
        Me.Lab_SCC1_06.Text = "Đang sửa chữa"
        Me.Lab_SCC1_06.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_06.Visible = False
        '
        'Lab_SCC_07
        '
        Me.Lab_SCC_07.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_07.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_07.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_07.Location = New System.Drawing.Point(15, 281)
        Me.Lab_SCC_07.Name = "Lab_SCC_07"
        Me.Lab_SCC_07.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_07.TabIndex = 2029
        Me.Lab_SCC_07.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_07.Visible = False
        '
        'Lab_SCC1_20
        '
        Me.Lab_SCC1_20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_20.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_20.Location = New System.Drawing.Point(240, 221)
        Me.Lab_SCC1_20.Name = "Lab_SCC1_20"
        Me.Lab_SCC1_20.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_20.TabIndex = 2056
        Me.Lab_SCC1_20.Text = "Đang sửa chữa"
        Me.Lab_SCC1_20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_20.Visible = False
        '
        'Lab_SCC1_07
        '
        Me.Lab_SCC1_07.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_07.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_07.Location = New System.Drawing.Point(15, 264)
        Me.Lab_SCC1_07.Name = "Lab_SCC1_07"
        Me.Lab_SCC1_07.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_07.TabIndex = 2030
        Me.Lab_SCC1_07.Text = "Đang sửa chữa"
        Me.Lab_SCC1_07.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_07.Visible = False
        '
        'Lab_SCC_20
        '
        Me.Lab_SCC_20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_20.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_20.Location = New System.Drawing.Point(240, 238)
        Me.Lab_SCC_20.Name = "Lab_SCC_20"
        Me.Lab_SCC_20.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_20.TabIndex = 2055
        Me.Lab_SCC_20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_20.Visible = False
        '
        'Lab_SCC_08
        '
        Me.Lab_SCC_08.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_08.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_08.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_08.Location = New System.Drawing.Point(15, 325)
        Me.Lab_SCC_08.Name = "Lab_SCC_08"
        Me.Lab_SCC_08.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Lab_SCC_08.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_08.TabIndex = 2031
        Me.Lab_SCC_08.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_08.Visible = False
        '
        'Lab_SCC1_08
        '
        Me.Lab_SCC1_08.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_08.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_08.Location = New System.Drawing.Point(15, 308)
        Me.Lab_SCC1_08.Name = "Lab_SCC1_08"
        Me.Lab_SCC1_08.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_08.TabIndex = 2032
        Me.Lab_SCC1_08.Text = "Đang sửa chữa"
        Me.Lab_SCC1_08.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_08.Visible = False
        '
        'Lab_SCC_09
        '
        Me.Lab_SCC_09.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_09.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_09.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_09.Location = New System.Drawing.Point(15, 366)
        Me.Lab_SCC_09.Name = "Lab_SCC_09"
        Me.Lab_SCC_09.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_09.TabIndex = 2033
        Me.Lab_SCC_09.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_09.Visible = False
        '
        'Lab_SCC1_19
        '
        Me.Lab_SCC1_19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_19.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_19.Location = New System.Drawing.Point(240, 178)
        Me.Lab_SCC1_19.Name = "Lab_SCC1_19"
        Me.Lab_SCC1_19.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_19.TabIndex = 2054
        Me.Lab_SCC1_19.Text = "Đang sửa chữa"
        Me.Lab_SCC1_19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_19.Visible = False
        '
        'Lab_SCC1_09
        '
        Me.Lab_SCC1_09.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_09.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_09.Location = New System.Drawing.Point(15, 349)
        Me.Lab_SCC1_09.Name = "Lab_SCC1_09"
        Me.Lab_SCC1_09.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_09.TabIndex = 2034
        Me.Lab_SCC1_09.Text = "Đang sửa chữa"
        Me.Lab_SCC1_09.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_09.Visible = False
        '
        'Lab_SCC_19
        '
        Me.Lab_SCC_19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_19.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_19.Location = New System.Drawing.Point(240, 195)
        Me.Lab_SCC_19.Name = "Lab_SCC_19"
        Me.Lab_SCC_19.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_19.TabIndex = 2053
        Me.Lab_SCC_19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_19.Visible = False
        '
        'Lab_SCC_10
        '
        Me.Lab_SCC_10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_10.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_10.Location = New System.Drawing.Point(129, 25)
        Me.Lab_SCC_10.Name = "Lab_SCC_10"
        Me.Lab_SCC_10.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_10.TabIndex = 2035
        Me.Lab_SCC_10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_10.Visible = False
        '
        'Lab_SCC1_10
        '
        Me.Lab_SCC1_10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_10.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_10.Location = New System.Drawing.Point(129, 8)
        Me.Lab_SCC1_10.Name = "Lab_SCC1_10"
        Me.Lab_SCC1_10.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_10.TabIndex = 2036
        Me.Lab_SCC1_10.Text = "Đang sửa chữa"
        Me.Lab_SCC1_10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_10.Visible = False
        '
        'Lab_SCC1_18
        '
        Me.Lab_SCC1_18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_18.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_18.Location = New System.Drawing.Point(240, 137)
        Me.Lab_SCC1_18.Name = "Lab_SCC1_18"
        Me.Lab_SCC1_18.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_18.TabIndex = 2052
        Me.Lab_SCC1_18.Text = "Đang sửa chữa"
        Me.Lab_SCC1_18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_18.Visible = False
        '
        'Lab_SCC_11
        '
        Me.Lab_SCC_11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_11.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_11.Location = New System.Drawing.Point(129, 69)
        Me.Lab_SCC_11.Name = "Lab_SCC_11"
        Me.Lab_SCC_11.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_11.TabIndex = 2037
        Me.Lab_SCC_11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_11.Visible = False
        '
        'Lab_SCC_18
        '
        Me.Lab_SCC_18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_18.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_18.Location = New System.Drawing.Point(240, 154)
        Me.Lab_SCC_18.Name = "Lab_SCC_18"
        Me.Lab_SCC_18.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_18.TabIndex = 2051
        Me.Lab_SCC_18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_18.Visible = False
        '
        'Lab_SCC1_11
        '
        Me.Lab_SCC1_11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_11.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_11.Location = New System.Drawing.Point(129, 52)
        Me.Lab_SCC1_11.Name = "Lab_SCC1_11"
        Me.Lab_SCC1_11.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_11.TabIndex = 2038
        Me.Lab_SCC1_11.Text = "Đang sửa chữa"
        Me.Lab_SCC1_11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_11.Visible = False
        '
        'Lab_SCC1_17
        '
        Me.Lab_SCC1_17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_17.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_17.Location = New System.Drawing.Point(129, 308)
        Me.Lab_SCC1_17.Name = "Lab_SCC1_17"
        Me.Lab_SCC1_17.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_17.TabIndex = 2050
        Me.Lab_SCC1_17.Text = "Đang sửa chữa"
        Me.Lab_SCC1_17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_17.Visible = False
        '
        'Lab_SCC_12
        '
        Me.Lab_SCC_12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_12.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_12.Location = New System.Drawing.Point(129, 113)
        Me.Lab_SCC_12.Name = "Lab_SCC_12"
        Me.Lab_SCC_12.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_12.TabIndex = 2039
        Me.Lab_SCC_12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_12.Visible = False
        '
        'Lab_SCC_17
        '
        Me.Lab_SCC_17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_17.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_17.Location = New System.Drawing.Point(129, 325)
        Me.Lab_SCC_17.Name = "Lab_SCC_17"
        Me.Lab_SCC_17.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_17.TabIndex = 2049
        Me.Lab_SCC_17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_17.Visible = False
        '
        'Lab_SCC1_12
        '
        Me.Lab_SCC1_12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_12.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_12.Location = New System.Drawing.Point(129, 96)
        Me.Lab_SCC1_12.Name = "Lab_SCC1_12"
        Me.Lab_SCC1_12.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_12.TabIndex = 2040
        Me.Lab_SCC1_12.Text = "Đang sửa chữa"
        Me.Lab_SCC1_12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_12.Visible = False
        '
        'Lab_SCC1_16
        '
        Me.Lab_SCC1_16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_16.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_16.Location = New System.Drawing.Point(129, 265)
        Me.Lab_SCC1_16.Name = "Lab_SCC1_16"
        Me.Lab_SCC1_16.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_16.TabIndex = 2048
        Me.Lab_SCC1_16.Text = "Đang sửa chữa"
        Me.Lab_SCC1_16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_16.Visible = False
        '
        'Lab_SCC_13
        '
        Me.Lab_SCC_13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_13.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_13.Location = New System.Drawing.Point(129, 153)
        Me.Lab_SCC_13.Name = "Lab_SCC_13"
        Me.Lab_SCC_13.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_13.TabIndex = 2041
        Me.Lab_SCC_13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_13.Visible = False
        '
        'Lab_SCC_16
        '
        Me.Lab_SCC_16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_16.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_16.Location = New System.Drawing.Point(129, 282)
        Me.Lab_SCC_16.Name = "Lab_SCC_16"
        Me.Lab_SCC_16.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_16.TabIndex = 2047
        Me.Lab_SCC_16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_16.Visible = False
        '
        'Lab_SCC1_13
        '
        Me.Lab_SCC1_13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_13.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_13.Location = New System.Drawing.Point(129, 136)
        Me.Lab_SCC1_13.Name = "Lab_SCC1_13"
        Me.Lab_SCC1_13.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_13.TabIndex = 2042
        Me.Lab_SCC1_13.Text = "Đang sửa chữa"
        Me.Lab_SCC1_13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_13.Visible = False
        '
        'Lab_SCC1_15
        '
        Me.Lab_SCC1_15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_15.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_15.Location = New System.Drawing.Point(129, 222)
        Me.Lab_SCC1_15.Name = "Lab_SCC1_15"
        Me.Lab_SCC1_15.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_15.TabIndex = 2046
        Me.Lab_SCC1_15.Text = "Đang sửa chữa"
        Me.Lab_SCC1_15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_15.Visible = False
        '
        'Lab_SCC_14
        '
        Me.Lab_SCC_14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_14.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_14.Location = New System.Drawing.Point(129, 196)
        Me.Lab_SCC_14.Name = "Lab_SCC_14"
        Me.Lab_SCC_14.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_14.TabIndex = 2043
        Me.Lab_SCC_14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_14.Visible = False
        '
        'Lab_SCC_15
        '
        Me.Lab_SCC_15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Lab_SCC_15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC_15.ForeColor = System.Drawing.Color.Red
        Me.Lab_SCC_15.Location = New System.Drawing.Point(129, 239)
        Me.Lab_SCC_15.Name = "Lab_SCC_15"
        Me.Lab_SCC_15.Size = New System.Drawing.Size(105, 23)
        Me.Lab_SCC_15.TabIndex = 2045
        Me.Lab_SCC_15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Lab_SCC_15.Visible = False
        '
        'Lab_SCC1_14
        '
        Me.Lab_SCC1_14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_SCC1_14.ForeColor = System.Drawing.Color.Blue
        Me.Lab_SCC1_14.Location = New System.Drawing.Point(129, 179)
        Me.Lab_SCC1_14.Name = "Lab_SCC1_14"
        Me.Lab_SCC1_14.Size = New System.Drawing.Size(105, 15)
        Me.Lab_SCC1_14.TabIndex = 2044
        Me.Lab_SCC1_14.Text = "Đang sửa chữa"
        Me.Lab_SCC1_14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Lab_SCC1_14.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.CmdRefresh_KH_SCC)
        Me.Panel1.Controls.Add(Me.ChkAuto_Data_KH_SCC)
        Me.Panel1.Controls.Add(Me.CbbTime_Data_KH_SCC)
        Me.Panel1.Controls.Add(Me.CbbMa_BN_KH_SCC)
        Me.Panel1.Controls.Add(Me.buttRemove_Filter)
        Me.Panel1.Controls.Add(Me.ChkDu_kien_giaoCVDV)
        Me.Panel1.Controls.Add(Me.ChkShow_All_Cd_Xe)
        Me.Panel1.Controls.Add(Me.CmdUp_TG_GX_KH_SCC)
        Me.Panel1.Controls.Add(Me.CbbGio_Xem)
        Me.Panel1.Controls.Add(Me.LabLock)
        Me.Panel1.Controls.Add(Me.CbbMuc_SBD_KH_SCC)
        Me.Panel1.Controls.Add(Me.CbbMuc_SDS_KH_SCC)
        Me.Panel1.Controls.Add(Me.TxtSo_RO_KH_SCC)
        Me.Panel1.Controls.Add(Me.CbbLoai_Xem_KH_SCC)
        Me.Panel1.Controls.Add(Me.CbbTang_KH_SCC)
        Me.Panel1.Controls.Add(Me.CbbTo_KH_SCC)
        Me.Panel1.Controls.Add(Me.CbbCD_KH_SCC)
        Me.Panel1.Controls.Add(Me.CbbKhoang_KH_SCC)
        Me.Panel1.Controls.Add(Me.TxtMa_Xe_KH_SCC)
        Me.Panel1.Controls.Add(Me.CbbDo_Rong_KH_SCC)
        Me.Panel1.Controls.Add(Me.CbbCVDV_KH_SCC)
        Me.Panel1.Controls.Add(Me.TxtM_Ngay_Ct_KH_SCC)
        Me.Panel1.Controls.Add(Me.CbbTrang_thai)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 462)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1195, 35)
        Me.Panel1.TabIndex = 1955
        '
        'CmdRefresh_KH_SCC
        '
        Me.CmdRefresh_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdRefresh_KH_SCC.Image = Global.Cyber.Workprogress.My.Resources.Resources.refresh2_16x16
        Me.CmdRefresh_KH_SCC.Location = New System.Drawing.Point(420, 6)
        Me.CmdRefresh_KH_SCC.Name = "CmdRefresh_KH_SCC"
        Me.CmdRefresh_KH_SCC.Size = New System.Drawing.Size(22, 23)
        Me.CmdRefresh_KH_SCC.TabIndex = 51
        Me.CmdRefresh_KH_SCC.ToolTip = "Làm tươi dữ liệu"
        '
        'ChkAuto_Data_KH_SCC
        '
        Me.ChkAuto_Data_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkAuto_Data_KH_SCC.AutoSize = True
        Me.ChkAuto_Data_KH_SCC.Location = New System.Drawing.Point(6, 14)
        Me.ChkAuto_Data_KH_SCC.Name = "ChkAuto_Data_KH_SCC"
        Me.ChkAuto_Data_KH_SCC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkAuto_Data_KH_SCC.Size = New System.Drawing.Size(15, 14)
        Me.ChkAuto_Data_KH_SCC.TabIndex = 7299
        Me.ChkAuto_Data_KH_SCC.UseVisualStyleBackColor = True
        '
        'CbbTime_Data_KH_SCC
        '
        Me.CbbTime_Data_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbTime_Data_KH_SCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbTime_Data_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbTime_Data_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.CbbTime_Data_KH_SCC.FormattingEnabled = True
        Me.CbbTime_Data_KH_SCC.Location = New System.Drawing.Point(24, 7)
        Me.CbbTime_Data_KH_SCC.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbTime_Data_KH_SCC.Name = "CbbTime_Data_KH_SCC"
        Me.CbbTime_Data_KH_SCC.Size = New System.Drawing.Size(46, 21)
        Me.CbbTime_Data_KH_SCC.TabIndex = 7300
        '
        'CbbMa_BN_KH_SCC
        '
        Me.CbbMa_BN_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_BN_KH_SCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_BN_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_BN_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_BN_KH_SCC.FormattingEnabled = True
        Me.CbbMa_BN_KH_SCC.Location = New System.Drawing.Point(72, 7)
        Me.CbbMa_BN_KH_SCC.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_BN_KH_SCC.Name = "CbbMa_BN_KH_SCC"
        Me.CbbMa_BN_KH_SCC.Size = New System.Drawing.Size(46, 21)
        Me.CbbMa_BN_KH_SCC.TabIndex = 7301
        '
        'buttRemove_Filter
        '
        Me.buttRemove_Filter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.buttRemove_Filter.Image = Global.Cyber.Workprogress.My.Resources.Resources.deletelist_16x16
        Me.buttRemove_Filter.Location = New System.Drawing.Point(469, 6)
        Me.buttRemove_Filter.Name = "buttRemove_Filter"
        Me.buttRemove_Filter.Size = New System.Drawing.Size(22, 23)
        Me.buttRemove_Filter.TabIndex = 7297
        Me.buttRemove_Filter.ToolTip = "Xóa tìm kiếm"
        Me.buttRemove_Filter.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'ChkDu_kien_giaoCVDV
        '
        Me.ChkDu_kien_giaoCVDV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkDu_kien_giaoCVDV.AutoSize = True
        Me.ChkDu_kien_giaoCVDV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDu_kien_giaoCVDV.ForeColor = System.Drawing.Color.Red
        Me.ChkDu_kien_giaoCVDV.Location = New System.Drawing.Point(394, 11)
        Me.ChkDu_kien_giaoCVDV.Name = "ChkDu_kien_giaoCVDV"
        Me.ChkDu_kien_giaoCVDV.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkDu_kien_giaoCVDV.Size = New System.Drawing.Size(15, 14)
        Me.ChkDu_kien_giaoCVDV.TabIndex = 1929
        Me.ChkDu_kien_giaoCVDV.UseVisualStyleBackColor = True
        '
        'ChkShow_All_Cd_Xe
        '
        Me.ChkShow_All_Cd_Xe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkShow_All_Cd_Xe.AutoSize = True
        Me.ChkShow_All_Cd_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkShow_All_Cd_Xe.ForeColor = System.Drawing.Color.DarkOrange
        Me.ChkShow_All_Cd_Xe.Location = New System.Drawing.Point(425, 11)
        Me.ChkShow_All_Cd_Xe.Name = "ChkShow_All_Cd_Xe"
        Me.ChkShow_All_Cd_Xe.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkShow_All_Cd_Xe.Size = New System.Drawing.Size(15, 14)
        Me.ChkShow_All_Cd_Xe.TabIndex = 7128
        Me.ChkShow_All_Cd_Xe.UseVisualStyleBackColor = True
        '
        'CmdUp_TG_GX_KH_SCC
        '
        Me.CmdUp_TG_GX_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdUp_TG_GX_KH_SCC.Image = Global.Cyber.Workprogress.My.Resources.Resources.historyitem_16x16
        Me.CmdUp_TG_GX_KH_SCC.Location = New System.Drawing.Point(445, 6)
        Me.CmdUp_TG_GX_KH_SCC.Name = "CmdUp_TG_GX_KH_SCC"
        Me.CmdUp_TG_GX_KH_SCC.Size = New System.Drawing.Size(22, 23)
        Me.CmdUp_TG_GX_KH_SCC.TabIndex = 7123
        Me.CmdUp_TG_GX_KH_SCC.ToolTip = "Cập nhập thời gian giao xe"
        '
        'CbbGio_Xem
        '
        Me.CbbGio_Xem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbGio_Xem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGio_Xem.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbGio_Xem.ForeColor = System.Drawing.Color.Navy
        Me.CbbGio_Xem.FormattingEnabled = True
        Me.CbbGio_Xem.Location = New System.Drawing.Point(286, 6)
        Me.CbbGio_Xem.Name = "CbbGio_Xem"
        Me.CbbGio_Xem.Size = New System.Drawing.Size(60, 22)
        Me.CbbGio_Xem.TabIndex = 7122
        '
        'LabLock
        '
        Me.LabLock.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabLock.BackColor = System.Drawing.Color.Green
        Me.LabLock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabLock.ForeColor = System.Drawing.Color.White
        Me.LabLock.Location = New System.Drawing.Point(347, 6)
        Me.LabLock.Name = "LabLock"
        Me.LabLock.Size = New System.Drawing.Size(71, 23)
        Me.LabLock.TabIndex = 50
        Me.LabLock.Text = "LOCK"
        Me.LabLock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CbbMuc_SBD_KH_SCC
        '
        Me.CbbMuc_SBD_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMuc_SBD_KH_SCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMuc_SBD_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMuc_SBD_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.CbbMuc_SBD_KH_SCC.FormattingEnabled = True
        Me.CbbMuc_SBD_KH_SCC.Location = New System.Drawing.Point(493, 8)
        Me.CbbMuc_SBD_KH_SCC.Name = "CbbMuc_SBD_KH_SCC"
        Me.CbbMuc_SBD_KH_SCC.Size = New System.Drawing.Size(102, 21)
        Me.CbbMuc_SBD_KH_SCC.TabIndex = 7117
        '
        'CbbMuc_SDS_KH_SCC
        '
        Me.CbbMuc_SDS_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMuc_SDS_KH_SCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMuc_SDS_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMuc_SDS_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.CbbMuc_SDS_KH_SCC.FormattingEnabled = True
        Me.CbbMuc_SDS_KH_SCC.Location = New System.Drawing.Point(493, 8)
        Me.CbbMuc_SDS_KH_SCC.Name = "CbbMuc_SDS_KH_SCC"
        Me.CbbMuc_SDS_KH_SCC.Size = New System.Drawing.Size(102, 21)
        Me.CbbMuc_SDS_KH_SCC.TabIndex = 7116
        '
        'TxtSo_RO_KH_SCC
        '
        Me.TxtSo_RO_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSo_RO_KH_SCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtSo_RO_KH_SCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSo_RO_KH_SCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_RO_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_RO_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_RO_KH_SCC.Location = New System.Drawing.Point(446, 6)
        Me.TxtSo_RO_KH_SCC.Name = "TxtSo_RO_KH_SCC"
        Me.TxtSo_RO_KH_SCC.Size = New System.Drawing.Size(114, 23)
        Me.TxtSo_RO_KH_SCC.TabIndex = 1957
        Me.TxtSo_RO_KH_SCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CbbLoai_Xem_KH_SCC
        '
        Me.CbbLoai_Xem_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbLoai_Xem_KH_SCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbLoai_Xem_KH_SCC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbLoai_Xem_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.CbbLoai_Xem_KH_SCC.FormattingEnabled = True
        Me.CbbLoai_Xem_KH_SCC.Location = New System.Drawing.Point(224, 6)
        Me.CbbLoai_Xem_KH_SCC.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbLoai_Xem_KH_SCC.Name = "CbbLoai_Xem_KH_SCC"
        Me.CbbLoai_Xem_KH_SCC.Size = New System.Drawing.Size(60, 22)
        Me.CbbLoai_Xem_KH_SCC.TabIndex = 1956
        '
        'CbbTang_KH_SCC
        '
        Me.CbbTang_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbTang_KH_SCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbTang_KH_SCC.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbTang_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.CbbTang_KH_SCC.FormattingEnabled = True
        Me.CbbTang_KH_SCC.Location = New System.Drawing.Point(163, 6)
        Me.CbbTang_KH_SCC.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbTang_KH_SCC.Name = "CbbTang_KH_SCC"
        Me.CbbTang_KH_SCC.Size = New System.Drawing.Size(60, 22)
        Me.CbbTang_KH_SCC.TabIndex = 1955
        '
        'CbbTo_KH_SCC
        '
        Me.CbbTo_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbTo_KH_SCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbTo_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbTo_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.CbbTo_KH_SCC.FormattingEnabled = True
        Me.CbbTo_KH_SCC.Location = New System.Drawing.Point(769, 8)
        Me.CbbTo_KH_SCC.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbTo_KH_SCC.Name = "CbbTo_KH_SCC"
        Me.CbbTo_KH_SCC.Size = New System.Drawing.Size(116, 21)
        Me.CbbTo_KH_SCC.TabIndex = 1954
        '
        'CbbCD_KH_SCC
        '
        Me.CbbCD_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbCD_KH_SCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbCD_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbCD_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.CbbCD_KH_SCC.FormattingEnabled = True
        Me.CbbCD_KH_SCC.Location = New System.Drawing.Point(650, 8)
        Me.CbbCD_KH_SCC.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbCD_KH_SCC.Name = "CbbCD_KH_SCC"
        Me.CbbCD_KH_SCC.Size = New System.Drawing.Size(116, 21)
        Me.CbbCD_KH_SCC.TabIndex = 1953
        '
        'CbbKhoang_KH_SCC
        '
        Me.CbbKhoang_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbKhoang_KH_SCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbKhoang_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbKhoang_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.CbbKhoang_KH_SCC.FormattingEnabled = True
        Me.CbbKhoang_KH_SCC.Location = New System.Drawing.Point(886, 8)
        Me.CbbKhoang_KH_SCC.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbKhoang_KH_SCC.Name = "CbbKhoang_KH_SCC"
        Me.CbbKhoang_KH_SCC.Size = New System.Drawing.Size(99, 21)
        Me.CbbKhoang_KH_SCC.TabIndex = 1932
        '
        'TxtMa_Xe_KH_SCC
        '
        Me.TxtMa_Xe_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Xe_KH_SCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMa_Xe_KH_SCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMa_Xe_KH_SCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe_KH_SCC.Location = New System.Drawing.Point(561, 6)
        Me.TxtMa_Xe_KH_SCC.Name = "TxtMa_Xe_KH_SCC"
        Me.TxtMa_Xe_KH_SCC.Size = New System.Drawing.Size(87, 23)
        Me.TxtMa_Xe_KH_SCC.TabIndex = 1935
        Me.TxtMa_Xe_KH_SCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CbbDo_Rong_KH_SCC
        '
        Me.CbbDo_Rong_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbDo_Rong_KH_SCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbDo_Rong_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbDo_Rong_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.CbbDo_Rong_KH_SCC.FormattingEnabled = True
        Me.CbbDo_Rong_KH_SCC.Location = New System.Drawing.Point(119, 7)
        Me.CbbDo_Rong_KH_SCC.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbDo_Rong_KH_SCC.Name = "CbbDo_Rong_KH_SCC"
        Me.CbbDo_Rong_KH_SCC.Size = New System.Drawing.Size(43, 21)
        Me.CbbDo_Rong_KH_SCC.TabIndex = 1934
        '
        'CbbCVDV_KH_SCC
        '
        Me.CbbCVDV_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbCVDV_KH_SCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbCVDV_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbCVDV_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.CbbCVDV_KH_SCC.FormattingEnabled = True
        Me.CbbCVDV_KH_SCC.Location = New System.Drawing.Point(987, 8)
        Me.CbbCVDV_KH_SCC.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbCVDV_KH_SCC.Name = "CbbCVDV_KH_SCC"
        Me.CbbCVDV_KH_SCC.Size = New System.Drawing.Size(107, 21)
        Me.CbbCVDV_KH_SCC.TabIndex = 1930
        '
        'TxtM_Ngay_Ct_KH_SCC
        '
        Me.TxtM_Ngay_Ct_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtM_Ngay_Ct_KH_SCC.Flags = 0
        Me.TxtM_Ngay_Ct_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct_KH_SCC.IsAllowResize = False
        Me.TxtM_Ngay_Ct_KH_SCC.isEmpty = True
        Me.TxtM_Ngay_Ct_KH_SCC.Location = New System.Drawing.Point(1098, 7)
        Me.TxtM_Ngay_Ct_KH_SCC.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct_KH_SCC.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct_KH_SCC.MaxLength = 10
        Me.TxtM_Ngay_Ct_KH_SCC.Name = "TxtM_Ngay_Ct_KH_SCC"
        Me.TxtM_Ngay_Ct_KH_SCC.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct_KH_SCC.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct_KH_SCC.ReadOnly = True
        Me.TxtM_Ngay_Ct_KH_SCC.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct_KH_SCC.Size = New System.Drawing.Size(91, 20)
        Me.TxtM_Ngay_Ct_KH_SCC.TabIndex = 1931
        Me.TxtM_Ngay_Ct_KH_SCC.Text = "__/__/____"
        Me.TxtM_Ngay_Ct_KH_SCC.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'CbbTrang_thai
        '
        Me.CbbTrang_thai.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbTrang_thai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbTrang_thai.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbTrang_thai.ForeColor = System.Drawing.Color.Navy
        Me.CbbTrang_thai.FormattingEnabled = True
        Me.CbbTrang_thai.Location = New System.Drawing.Point(1, 5)
        Me.CbbTrang_thai.Name = "CbbTrang_thai"
        Me.CbbTrang_thai.Size = New System.Drawing.Size(150, 22)
        Me.CbbTrang_thai.TabIndex = 7298
        Me.CbbTrang_thai.Visible = False
        '
        'Tab2
        '
        Me.Tab2.Controls.Add(Me.Master_TiepDon)
        Me.Tab2.Controls.Add(Me.Panel6)
        Me.Tab2.Location = New System.Drawing.Point(4, 22)
        Me.Tab2.Name = "Tab2"
        Me.Tab2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab2.Size = New System.Drawing.Size(1195, 497)
        Me.Tab2.TabIndex = 1
        Me.Tab2.Text = "CHỜ TIẾP ĐÓN"
        Me.Tab2.UseVisualStyleBackColor = True
        '
        'Master_TiepDon
        '
        Me.Master_TiepDon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_TiepDon.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_TiepDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_TiepDon.Location = New System.Drawing.Point(3, 3)
        Me.Master_TiepDon.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_TiepDon.MainView = Me.Master_TiepDonGRV
        Me.Master_TiepDon.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_TiepDon.Name = "Master_TiepDon"
        Me.Master_TiepDon.Size = New System.Drawing.Size(1189, 455)
        Me.Master_TiepDon.TabIndex = 448
        Me.Master_TiepDon.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_TiepDonGRV, Me.GridView12, Me.GridView15})
        '
        'Master_TiepDonGRV
        '
        Me.Master_TiepDonGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_TiepDonGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_TiepDonGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_TiepDonGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_TiepDonGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_TiepDonGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_TiepDonGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_TiepDonGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_TiepDonGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_TiepDonGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_TiepDonGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_TiepDonGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_TiepDonGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.Master_TiepDonGRV.GridControl = Me.Master_TiepDon
        Me.Master_TiepDonGRV.GroupRowHeight = 30
        Me.Master_TiepDonGRV.Name = "Master_TiepDonGRV"
        Me.Master_TiepDonGRV.OptionsBehavior.Editable = False
        Me.Master_TiepDonGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_TiepDonGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_TiepDonGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_TiepDonGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_TiepDonGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Master_TiepDonGRV.OptionsView.ShowGroupPanel = False
        Me.Master_TiepDonGRV.RowHeight = 22
        '
        'GridView12
        '
        Me.GridView12.GridControl = Me.Master_TiepDon
        Me.GridView12.Name = "GridView12"
        '
        'GridView15
        '
        Me.GridView15.GridControl = Me.Master_TiepDon
        Me.GridView15.Name = "GridView15"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.CbbCVDV_TiepDon)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(3, 458)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1189, 36)
        Me.Panel6.TabIndex = 447
        '
        'CbbCVDV_TiepDon
        '
        Me.CbbCVDV_TiepDon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbCVDV_TiepDon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbCVDV_TiepDon.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbCVDV_TiepDon.ForeColor = System.Drawing.Color.Navy
        Me.CbbCVDV_TiepDon.FormattingEnabled = True
        Me.CbbCVDV_TiepDon.Location = New System.Drawing.Point(4, 7)
        Me.CbbCVDV_TiepDon.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbCVDV_TiepDon.Name = "CbbCVDV_TiepDon"
        Me.CbbCVDV_TiepDon.Size = New System.Drawing.Size(152, 21)
        Me.CbbCVDV_TiepDon.TabIndex = 7121
        '
        'GridView5
        '
        Me.GridView5.Name = "GridView5"
        '
        'GridView6
        '
        Me.GridView6.Name = "GridView6"
        '
        'GridView7
        '
        Me.GridView7.GridControl = Me.Master_Hen
        Me.GridView7.Name = "GridView7"
        '
        'Master_Hen
        '
        Me.Master_Hen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_Hen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_Hen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_Hen.Location = New System.Drawing.Point(0, 0)
        Me.Master_Hen.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_Hen.MainView = Me.Master_HenGRV
        Me.Master_Hen.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_Hen.Name = "Master_Hen"
        Me.Master_Hen.Size = New System.Drawing.Size(1185, 430)
        Me.Master_Hen.TabIndex = 445
        Me.Master_Hen.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_HenGRV, Me.GridView8, Me.GridView7})
        '
        'Master_HenGRV
        '
        Me.Master_HenGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_HenGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_HenGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_HenGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_HenGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_HenGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_HenGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_HenGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_HenGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_HenGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_HenGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_HenGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_HenGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.Master_HenGRV.GridControl = Me.Master_Hen
        Me.Master_HenGRV.GroupRowHeight = 30
        Me.Master_HenGRV.Name = "Master_HenGRV"
        Me.Master_HenGRV.OptionsBehavior.Editable = False
        Me.Master_HenGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_HenGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_HenGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_HenGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_HenGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Master_HenGRV.OptionsView.ShowGroupPanel = False
        Me.Master_HenGRV.RowHeight = 22
        '
        'GridView8
        '
        Me.GridView8.GridControl = Me.Master_Hen
        Me.GridView8.Name = "GridView8"
        '
        'TabCVDV
        '
        Me.TabCVDV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabCVDV.Controls.Add(Me.Tab1)
        Me.TabCVDV.Controls.Add(Me.Tab2)
        Me.TabCVDV.Controls.Add(Me.Tab3)
        Me.TabCVDV.Controls.Add(Me.Tab4)
        Me.TabCVDV.Controls.Add(Me.Tab5)
        Me.TabCVDV.Controls.Add(Me.Tab6)
        Me.TabCVDV.Controls.Add(Me.Tab7)
        Me.TabCVDV.Controls.Add(Me.Tab8)
        Me.TabCVDV.Controls.Add(Me.Tab9)
        Me.TabCVDV.Location = New System.Drawing.Point(0, 0)
        Me.TabCVDV.Name = "TabCVDV"
        Me.TabCVDV.SelectedIndex = 0
        Me.TabCVDV.Size = New System.Drawing.Size(1203, 523)
        Me.TabCVDV.TabIndex = 45
        '
        'Tab1
        '
        Me.Tab1.Controls.Add(Me.SplitContainer_Hen)
        Me.Tab1.Location = New System.Drawing.Point(4, 22)
        Me.Tab1.Name = "Tab1"
        Me.Tab1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab1.Size = New System.Drawing.Size(1195, 497)
        Me.Tab1.TabIndex = 0
        Me.Tab1.Text = "XE HẸN"
        Me.Tab1.UseVisualStyleBackColor = True
        '
        'SplitContainer_Hen
        '
        Me.SplitContainer_Hen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SplitContainer_Hen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Hen.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer_Hen.Name = "SplitContainer_Hen"
        Me.SplitContainer_Hen.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer_Hen.Panel1
        '
        Me.SplitContainer_Hen.Panel1.Controls.Add(Me.Master_Hen)
        '
        'SplitContainer_Hen.Panel2
        '
        Me.SplitContainer_Hen.Panel2.Controls.Add(Me.ChkHen_SDS)
        Me.SplitContainer_Hen.Panel2.Controls.Add(Me.CbbTo_Hen)
        Me.SplitContainer_Hen.Panel2.Controls.Add(Me.ChkAuto_Data_Hen)
        Me.SplitContainer_Hen.Panel2.Controls.Add(Me.TxtM_Ngay_Ct_hen)
        Me.SplitContainer_Hen.Panel2.Controls.Add(Me.CbbTime_Data_Hen)
        Me.SplitContainer_Hen.Panel2.Controls.Add(Me.ChkHen_SBD)
        Me.SplitContainer_Hen.Panel2.Controls.Add(Me.CbbCVDV_Hen)
        Me.SplitContainer_Hen.Panel2.Controls.Add(Me.ChkHen_SCC)
        Me.SplitContainer_Hen.Size = New System.Drawing.Size(1189, 491)
        Me.SplitContainer_Hen.SplitterDistance = 434
        Me.SplitContainer_Hen.TabIndex = 7132
        '
        'ChkHen_SDS
        '
        Me.ChkHen_SDS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkHen_SDS.AutoSize = True
        Me.ChkHen_SDS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkHen_SDS.ForeColor = System.Drawing.Color.Navy
        Me.ChkHen_SDS.Location = New System.Drawing.Point(645, 23)
        Me.ChkHen_SDS.Name = "ChkHen_SDS"
        Me.ChkHen_SDS.Size = New System.Drawing.Size(72, 17)
        Me.ChkHen_SDS.TabIndex = 7121
        Me.ChkHen_SDS.TabStop = False
        Me.ChkHen_SDS.Tag = "Tel, time"
        Me.ChkHen_SDS.Text = "Đồng sơn"
        Me.ChkHen_SDS.UseVisualStyleBackColor = True
        '
        'CbbTo_Hen
        '
        Me.CbbTo_Hen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbTo_Hen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbTo_Hen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbTo_Hen.ForeColor = System.Drawing.Color.Navy
        Me.CbbTo_Hen.FormattingEnabled = True
        Me.CbbTo_Hen.Location = New System.Drawing.Point(278, 20)
        Me.CbbTo_Hen.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbTo_Hen.Name = "CbbTo_Hen"
        Me.CbbTo_Hen.Size = New System.Drawing.Size(107, 21)
        Me.CbbTo_Hen.TabIndex = 7125
        '
        'ChkAuto_Data_Hen
        '
        Me.ChkAuto_Data_Hen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkAuto_Data_Hen.AutoSize = True
        Me.ChkAuto_Data_Hen.Location = New System.Drawing.Point(5, 22)
        Me.ChkAuto_Data_Hen.Name = "ChkAuto_Data_Hen"
        Me.ChkAuto_Data_Hen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkAuto_Data_Hen.Size = New System.Drawing.Size(48, 17)
        Me.ChkAuto_Data_Hen.TabIndex = 7118
        Me.ChkAuto_Data_Hen.Text = "Auto"
        Me.ChkAuto_Data_Hen.UseVisualStyleBackColor = True
        '
        'TxtM_Ngay_Ct_hen
        '
        Me.TxtM_Ngay_Ct_hen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtM_Ngay_Ct_hen.Flags = 0
        Me.TxtM_Ngay_Ct_hen.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct_hen.IsAllowResize = False
        Me.TxtM_Ngay_Ct_hen.isEmpty = True
        Me.TxtM_Ngay_Ct_hen.Location = New System.Drawing.Point(393, 20)
        Me.TxtM_Ngay_Ct_hen.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct_hen.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct_hen.MaxLength = 10
        Me.TxtM_Ngay_Ct_hen.Name = "TxtM_Ngay_Ct_hen"
        Me.TxtM_Ngay_Ct_hen.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct_hen.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct_hen.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct_hen.Size = New System.Drawing.Size(86, 20)
        Me.TxtM_Ngay_Ct_hen.TabIndex = 7124
        Me.TxtM_Ngay_Ct_hen.Text = "__/__/____"
        Me.TxtM_Ngay_Ct_hen.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'CbbTime_Data_Hen
        '
        Me.CbbTime_Data_Hen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbTime_Data_Hen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbTime_Data_Hen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbTime_Data_Hen.ForeColor = System.Drawing.Color.Navy
        Me.CbbTime_Data_Hen.FormattingEnabled = True
        Me.CbbTime_Data_Hen.Location = New System.Drawing.Point(55, 20)
        Me.CbbTime_Data_Hen.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbTime_Data_Hen.Name = "CbbTime_Data_Hen"
        Me.CbbTime_Data_Hen.Size = New System.Drawing.Size(52, 21)
        Me.CbbTime_Data_Hen.TabIndex = 7119
        '
        'ChkHen_SBD
        '
        Me.ChkHen_SBD.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkHen_SBD.AutoSize = True
        Me.ChkHen_SBD.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkHen_SBD.ForeColor = System.Drawing.Color.Navy
        Me.ChkHen_SBD.Location = New System.Drawing.Point(546, 23)
        Me.ChkHen_SBD.Name = "ChkHen_SBD"
        Me.ChkHen_SBD.Size = New System.Drawing.Size(78, 17)
        Me.ChkHen_SBD.TabIndex = 7123
        Me.ChkHen_SBD.TabStop = False
        Me.ChkHen_SBD.Tag = "Tel, time"
        Me.ChkHen_SBD.Text = "Bảo dưỡng"
        Me.ChkHen_SBD.UseVisualStyleBackColor = True
        '
        'CbbCVDV_Hen
        '
        Me.CbbCVDV_Hen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbCVDV_Hen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbCVDV_Hen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbCVDV_Hen.ForeColor = System.Drawing.Color.Navy
        Me.CbbCVDV_Hen.FormattingEnabled = True
        Me.CbbCVDV_Hen.Location = New System.Drawing.Point(115, 20)
        Me.CbbCVDV_Hen.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbCVDV_Hen.Name = "CbbCVDV_Hen"
        Me.CbbCVDV_Hen.Size = New System.Drawing.Size(152, 21)
        Me.CbbCVDV_Hen.TabIndex = 7120
        '
        'ChkHen_SCC
        '
        Me.ChkHen_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkHen_SCC.AutoSize = True
        Me.ChkHen_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkHen_SCC.ForeColor = System.Drawing.Color.Navy
        Me.ChkHen_SCC.Location = New System.Drawing.Point(482, 23)
        Me.ChkHen_SCC.Name = "ChkHen_SCC"
        Me.ChkHen_SCC.Size = New System.Drawing.Size(47, 17)
        Me.ChkHen_SCC.TabIndex = 7122
        Me.ChkHen_SCC.TabStop = False
        Me.ChkHen_SCC.Tag = "Tel, time"
        Me.ChkHen_SCC.Text = "SCC"
        Me.ChkHen_SCC.UseVisualStyleBackColor = True
        '
        'Tab7
        '
        Me.Tab7.Controls.Add(Me.Master_ThemGio)
        Me.Tab7.Controls.Add(Me.Panel5)
        Me.Tab7.Location = New System.Drawing.Point(4, 22)
        Me.Tab7.Name = "Tab7"
        Me.Tab7.Size = New System.Drawing.Size(1195, 497)
        Me.Tab7.TabIndex = 6
        Me.Tab7.Text = "THÊM GIỜ"
        Me.Tab7.UseVisualStyleBackColor = True
        '
        'Master_ThemGio
        '
        Me.Master_ThemGio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_ThemGio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_ThemGio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_ThemGio.Location = New System.Drawing.Point(0, 0)
        Me.Master_ThemGio.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_ThemGio.MainView = Me.Master_ThemGioGRV
        Me.Master_ThemGio.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_ThemGio.Name = "Master_ThemGio"
        Me.Master_ThemGio.Size = New System.Drawing.Size(1195, 461)
        Me.Master_ThemGio.TabIndex = 448
        Me.Master_ThemGio.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_ThemGioGRV, Me.GridView19, Me.GridView20})
        '
        'Master_ThemGioGRV
        '
        Me.Master_ThemGioGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_ThemGioGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_ThemGioGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_ThemGioGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_ThemGioGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_ThemGioGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_ThemGioGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_ThemGioGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_ThemGioGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_ThemGioGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_ThemGioGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_ThemGioGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_ThemGioGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.Master_ThemGioGRV.GridControl = Me.Master_ThemGio
        Me.Master_ThemGioGRV.GroupRowHeight = 30
        Me.Master_ThemGioGRV.Name = "Master_ThemGioGRV"
        Me.Master_ThemGioGRV.OptionsBehavior.Editable = False
        Me.Master_ThemGioGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_ThemGioGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_ThemGioGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_ThemGioGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_ThemGioGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Master_ThemGioGRV.OptionsView.ShowGroupPanel = False
        Me.Master_ThemGioGRV.RowHeight = 22
        '
        'GridView19
        '
        Me.GridView19.GridControl = Me.Master_ThemGio
        Me.GridView19.Name = "GridView19"
        '
        'GridView20
        '
        Me.GridView20.GridControl = Me.Master_ThemGio
        Me.GridView20.Name = "GridView20"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.CbbCVDV_ThemGio)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 461)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1195, 36)
        Me.Panel5.TabIndex = 447
        '
        'CbbCVDV_ThemGio
        '
        Me.CbbCVDV_ThemGio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbCVDV_ThemGio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbCVDV_ThemGio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbCVDV_ThemGio.ForeColor = System.Drawing.Color.Navy
        Me.CbbCVDV_ThemGio.FormattingEnabled = True
        Me.CbbCVDV_ThemGio.Location = New System.Drawing.Point(4, 7)
        Me.CbbCVDV_ThemGio.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbCVDV_ThemGio.Name = "CbbCVDV_ThemGio"
        Me.CbbCVDV_ThemGio.Size = New System.Drawing.Size(152, 21)
        Me.CbbCVDV_ThemGio.TabIndex = 7121
        '
        'Tab8
        '
        Me.Tab8.Controls.Add(Me.Master_khac)
        Me.Tab8.Controls.Add(Me.Panel7)
        Me.Tab8.Location = New System.Drawing.Point(4, 22)
        Me.Tab8.Name = "Tab8"
        Me.Tab8.Size = New System.Drawing.Size(1195, 497)
        Me.Tab8.TabIndex = 7
        Me.Tab8.Text = "KHÁC"
        Me.Tab8.UseVisualStyleBackColor = True
        '
        'Master_khac
        '
        Me.Master_khac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_khac.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_khac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_khac.Location = New System.Drawing.Point(0, 0)
        Me.Master_khac.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_khac.MainView = Me.Master_khacGRV
        Me.Master_khac.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_khac.Name = "Master_khac"
        Me.Master_khac.Size = New System.Drawing.Size(1195, 461)
        Me.Master_khac.TabIndex = 450
        Me.Master_khac.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_khacGRV, Me.GridView18, Me.GridView21})
        '
        'Master_khacGRV
        '
        Me.Master_khacGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_khacGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_khacGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_khacGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_khacGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_khacGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_khacGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_khacGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_khacGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_khacGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_khacGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_khacGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_khacGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.Master_khacGRV.GridControl = Me.Master_khac
        Me.Master_khacGRV.GroupRowHeight = 30
        Me.Master_khacGRV.Name = "Master_khacGRV"
        Me.Master_khacGRV.OptionsBehavior.Editable = False
        Me.Master_khacGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_khacGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_khacGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_khacGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_khacGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Master_khacGRV.OptionsView.ShowGroupPanel = False
        Me.Master_khacGRV.RowHeight = 22
        '
        'GridView18
        '
        Me.GridView18.GridControl = Me.Master_khac
        Me.GridView18.Name = "GridView18"
        '
        'GridView21
        '
        Me.GridView21.GridControl = Me.Master_khac
        Me.GridView21.Name = "GridView21"
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.CbbCVDV_Khac)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 461)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1195, 36)
        Me.Panel7.TabIndex = 449
        '
        'CbbCVDV_Khac
        '
        Me.CbbCVDV_Khac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbCVDV_Khac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbCVDV_Khac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbCVDV_Khac.ForeColor = System.Drawing.Color.Navy
        Me.CbbCVDV_Khac.FormattingEnabled = True
        Me.CbbCVDV_Khac.Location = New System.Drawing.Point(4, 7)
        Me.CbbCVDV_Khac.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbCVDV_Khac.Name = "CbbCVDV_Khac"
        Me.CbbCVDV_Khac.Size = New System.Drawing.Size(152, 21)
        Me.CbbCVDV_Khac.TabIndex = 7121
        Me.CbbCVDV_Khac.Visible = False
        '
        'Tab9
        '
        Me.Tab9.Controls.Add(Me.Master_HieuSuat)
        Me.Tab9.Controls.Add(Me.Panel8)
        Me.Tab9.Location = New System.Drawing.Point(4, 22)
        Me.Tab9.Name = "Tab9"
        Me.Tab9.Size = New System.Drawing.Size(1195, 497)
        Me.Tab9.TabIndex = 8
        Me.Tab9.Text = "HIỆU SUẤT"
        Me.Tab9.UseVisualStyleBackColor = True
        '
        'Master_HieuSuat
        '
        Me.Master_HieuSuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_HieuSuat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master_HieuSuat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_HieuSuat.Location = New System.Drawing.Point(0, 0)
        Me.Master_HieuSuat.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_HieuSuat.MainView = Me.Master_HieuSuatGRV
        Me.Master_HieuSuat.Margin = New System.Windows.Forms.Padding(0)
        Me.Master_HieuSuat.Name = "Master_HieuSuat"
        Me.Master_HieuSuat.Size = New System.Drawing.Size(1195, 461)
        Me.Master_HieuSuat.TabIndex = 452
        Me.Master_HieuSuat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master_HieuSuatGRV, Me.GridView22, Me.GridView23})
        '
        'Master_HieuSuatGRV
        '
        Me.Master_HieuSuatGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master_HieuSuatGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master_HieuSuatGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master_HieuSuatGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master_HieuSuatGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master_HieuSuatGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master_HieuSuatGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master_HieuSuatGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master_HieuSuatGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_HieuSuatGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master_HieuSuatGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master_HieuSuatGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master_HieuSuatGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.Master_HieuSuatGRV.GridControl = Me.Master_HieuSuat
        Me.Master_HieuSuatGRV.GroupRowHeight = 30
        Me.Master_HieuSuatGRV.Name = "Master_HieuSuatGRV"
        Me.Master_HieuSuatGRV.OptionsBehavior.Editable = False
        Me.Master_HieuSuatGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master_HieuSuatGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master_HieuSuatGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master_HieuSuatGRV.OptionsView.ColumnAutoWidth = False
        Me.Master_HieuSuatGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.Master_HieuSuatGRV.OptionsView.ShowGroupPanel = False
        Me.Master_HieuSuatGRV.RowHeight = 22
        '
        'GridView22
        '
        Me.GridView22.GridControl = Me.Master_HieuSuat
        Me.GridView22.Name = "GridView22"
        '
        'GridView23
        '
        Me.GridView23.GridControl = Me.Master_HieuSuat
        Me.GridView23.Name = "GridView23"
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.CbbLoai_HieuSuat)
        Me.Panel8.Controls.Add(Me.CbbCVDV_HieuSuat)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel8.Location = New System.Drawing.Point(0, 461)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1195, 36)
        Me.Panel8.TabIndex = 451
        '
        'CbbLoai_HieuSuat
        '
        Me.CbbLoai_HieuSuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbLoai_HieuSuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbLoai_HieuSuat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbLoai_HieuSuat.ForeColor = System.Drawing.Color.Navy
        Me.CbbLoai_HieuSuat.FormattingEnabled = True
        Me.CbbLoai_HieuSuat.Location = New System.Drawing.Point(10, 7)
        Me.CbbLoai_HieuSuat.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbLoai_HieuSuat.Name = "CbbLoai_HieuSuat"
        Me.CbbLoai_HieuSuat.Size = New System.Drawing.Size(152, 21)
        Me.CbbLoai_HieuSuat.TabIndex = 7122
        '
        'CbbCVDV_HieuSuat
        '
        Me.CbbCVDV_HieuSuat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbCVDV_HieuSuat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbCVDV_HieuSuat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbCVDV_HieuSuat.ForeColor = System.Drawing.Color.Navy
        Me.CbbCVDV_HieuSuat.FormattingEnabled = True
        Me.CbbCVDV_HieuSuat.Location = New System.Drawing.Point(170, 7)
        Me.CbbCVDV_HieuSuat.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbCVDV_HieuSuat.Name = "CbbCVDV_HieuSuat"
        Me.CbbCVDV_HieuSuat.Size = New System.Drawing.Size(152, 21)
        Me.CbbCVDV_HieuSuat.TabIndex = 7121
        Me.CbbCVDV_HieuSuat.Visible = False
        '
        'Timer_PercentComplete
        '
        Me.Timer_PercentComplete.Interval = 1000
        '
        'PopupMenuSchedulerControl
        '
        Me.PopupMenuSchedulerControl.Manager = Me.BarManager1
        Me.PopupMenuSchedulerControl.Name = "PopupMenuSchedulerControl"
        '
        'CmbFullScreen
        '
        Me.CmbFullScreen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbFullScreen.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.CmbFullScreen.Image = Global.Cyber.Workprogress.My.Resources.Resources.fullextent_16x16
        Me.CmbFullScreen.Location = New System.Drawing.Point(1139, 0)
        Me.CmbFullScreen.Name = "CmbFullScreen"
        Me.CmbFullScreen.Size = New System.Drawing.Size(20, 19)
        Me.CmbFullScreen.TabIndex = 1957
        '
        'CmdThu_Nho
        '
        Me.CmdThu_Nho.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdThu_Nho.Image = CType(resources.GetObject("CmdThu_Nho.Image"), System.Drawing.Image)
        Me.CmdThu_Nho.Location = New System.Drawing.Point(1156, 0)
        Me.CmdThu_Nho.Name = "CmdThu_Nho"
        Me.CmdThu_Nho.Size = New System.Drawing.Size(20, 19)
        Me.CmdThu_Nho.TabIndex = 7309
        Me.CmdThu_Nho.ToolTip = "Min /Thu nhỏ màn hình"
        Me.CmdThu_Nho.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'CmdDong_Lai
        '
        Me.CmdDong_Lai.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdDong_Lai.Image = Global.Cyber.Workprogress.My.Resources.Resources.close_16x16
        Me.CmdDong_Lai.Location = New System.Drawing.Point(1179, 0)
        Me.CmdDong_Lai.Name = "CmdDong_Lai"
        Me.CmdDong_Lai.Size = New System.Drawing.Size(20, 19)
        Me.CmdDong_Lai.TabIndex = 7308
        Me.CmdDong_Lai.ToolTip = "Exit /Thoát chương trình"
        Me.CmdDong_Lai.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
        '
        'FrmTien_Do
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1204, 545)
        Me.Controls.Add(Me.CmdThu_Nho)
        Me.Controls.Add(Me.CmdDong_Lai)
        Me.Controls.Add(Me.CmbFullScreen)
        Me.Controls.Add(Me.TabCVDV)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmTien_Do"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TabCVDV, 0)
        Me.Controls.SetChildIndex(Me.CmbFullScreen, 0)
        Me.Controls.SetChildIndex(Me.CmdDong_Lai, 0)
        Me.Controls.SetChildIndex(Me.CmdThu_Nho, 0)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Tab6.ResumeLayout(False)
        CType(Me.Master_ChayThu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_ChayThuGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Tab5.ResumeLayout(False)
        CType(Me.Master_Dung, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_DungGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView14, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Tab4.ResumeLayout(False)
        CType(Me.Master_HonHop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_HonHopGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Tab3.ResumeLayout(False)
        Me.SplitContainer_Right.Panel1.ResumeLayout(False)
        Me.SplitContainer_Right.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Right, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Right.ResumeLayout(False)
        Me.SplitContainer_Left.Panel1.ResumeLayout(False)
        Me.SplitContainer_Left.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Left, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Left.ResumeLayout(False)
        CType(Me.Master_Cho_Lap_KH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_Cho_Lap_KHGRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBLoc_Xe.ResumeLayout(False)
        Me.GBLoc_Xe.PerformLayout()
        Me.SplitContainer_Tree.Panel1.ResumeLayout(False)
        Me.SplitContainer_Tree.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Tree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Tree.ResumeLayout(False)
        CType(Me.ResourcesTree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabSua_Xong_Mau_XE.ResumeLayout(False)
        Me.TabPage_Sua_Xong.ResumeLayout(False)
        CType(Me.Master_Sua_Xong_KH, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_Sua_Xong_KHGRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_Bang_Mau.ResumeLayout(False)
        Me.TabPage_Bang_Mau.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Tab2.ResumeLayout(False)
        CType(Me.Master_TiepDon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_TiepDonGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView15, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_Hen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_HenGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabCVDV.ResumeLayout(False)
        Me.Tab1.ResumeLayout(False)
        Me.SplitContainer_Hen.Panel1.ResumeLayout(False)
        Me.SplitContainer_Hen.Panel2.ResumeLayout(False)
        Me.SplitContainer_Hen.Panel2.PerformLayout()
        CType(Me.SplitContainer_Hen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Hen.ResumeLayout(False)
        Me.Tab7.ResumeLayout(False)
        CType(Me.Master_ThemGio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_ThemGioGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView20, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Tab8.ResumeLayout(False)
        CType(Me.Master_khac, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_khacGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Tab9.ResumeLayout(False)
        CType(Me.Master_HieuSuat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_HieuSuatGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView23, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        CType(Me.PopupMenuSchedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer_Data_hen As System.Windows.Forms.Timer
    Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabCVDV As System.Windows.Forms.TabControl
    Friend WithEvents Tab1 As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer_Hen As System.Windows.Forms.SplitContainer
    Friend WithEvents Master_Hen As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_HenGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents ChkHen_SDS As System.Windows.Forms.CheckBox
    Friend WithEvents CbbTo_Hen As System.Windows.Forms.ComboBox
    Friend WithEvents ChkAuto_Data_Hen As System.Windows.Forms.CheckBox
    Friend WithEvents TxtM_Ngay_Ct_hen As ClsTextBox.txtDate1
    Friend WithEvents CbbTime_Data_Hen As System.Windows.Forms.ComboBox
    Friend WithEvents ChkHen_SBD As System.Windows.Forms.CheckBox
    Friend WithEvents CbbCVDV_Hen As System.Windows.Forms.ComboBox
    Friend WithEvents ChkHen_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents Tab2 As System.Windows.Forms.TabPage
    Friend WithEvents Tab3 As System.Windows.Forms.TabPage
    Friend WithEvents Tab4 As System.Windows.Forms.TabPage
    Friend WithEvents Tab5 As System.Windows.Forms.TabPage
    Friend WithEvents Tab6 As System.Windows.Forms.TabPage
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents CmdRefresh_KH_SCC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkAuto_Data_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents CbbTime_Data_KH_SCC As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_BN_KH_SCC As System.Windows.Forms.ComboBox
    Friend WithEvents buttRemove_Filter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ChkDu_kien_giaoCVDV As System.Windows.Forms.CheckBox
    Friend WithEvents ChkShow_All_Cd_Xe As System.Windows.Forms.CheckBox
    Friend WithEvents CmdUp_TG_GX_KH_SCC As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CbbGio_Xem As System.Windows.Forms.ComboBox
    Friend WithEvents LabLock As System.Windows.Forms.Label
    Friend WithEvents CbbMuc_SBD_KH_SCC As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMuc_SDS_KH_SCC As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSo_RO_KH_SCC As System.Windows.Forms.TextBox
    Friend WithEvents CbbLoai_Xem_KH_SCC As System.Windows.Forms.ComboBox
    Friend WithEvents CbbTang_KH_SCC As System.Windows.Forms.ComboBox
    Friend WithEvents CbbTo_KH_SCC As System.Windows.Forms.ComboBox
    Friend WithEvents CbbCD_KH_SCC As System.Windows.Forms.ComboBox
    Friend WithEvents CbbKhoang_KH_SCC As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMa_Xe_KH_SCC As System.Windows.Forms.TextBox
    Friend WithEvents CbbDo_Rong_KH_SCC As System.Windows.Forms.ComboBox
    Friend WithEvents CbbCVDV_KH_SCC As System.Windows.Forms.ComboBox
    Friend WithEvents TxtM_Ngay_Ct_KH_SCC As ClsTextBox.txtDate1
    Friend WithEvents CbbTrang_thai As System.Windows.Forms.ComboBox
    Friend WithEvents Timer_Data_KH_SC As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer_Right As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer_Left As System.Windows.Forms.SplitContainer
    Friend WithEvents Master_Cho_Lap_KH As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_Cho_Lap_KHGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GBLoc_Xe As System.Windows.Forms.GroupBox
    Friend WithEvents TxtSo_Ro_Cho_Lap_KH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe_Cho_Lap_KH As System.Windows.Forms.TextBox
    Friend WithEvents SplitContainer_Tree As System.Windows.Forms.SplitContainer
    Friend WithEvents TabSua_Xong_Mau_XE As System.Windows.Forms.TabControl
    Friend WithEvents TabPage_Sua_Xong As System.Windows.Forms.TabPage
    Friend WithEvents Master_Sua_Xong_KH As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_Sua_Xong_KHGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage_Bang_Mau As System.Windows.Forms.TabPage
    Friend WithEvents ChkUu_Tien As System.Windows.Forms.CheckBox
    Friend WithEvents ChkGiao_Ngay_Kh_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSCL_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPM90_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkEM60_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCho_Giao_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDang_Rua_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCho_Rua_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkFV_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSDS_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDung_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_EM_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_GJ_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSBD_KH_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents Lab_SCC1_01 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_01 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_02 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_02 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_03 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_03 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_04 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_04 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_05 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_05 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_06 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_06 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_07 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_20 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_07 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_20 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_08 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_08 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_09 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_19 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_09 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_19 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_10 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_10 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_18 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_11 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_18 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_11 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_17 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_12 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_17 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_12 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_16 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_13 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_16 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_13 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_15 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_14 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC_15 As System.Windows.Forms.Label
    Friend WithEvents Lab_SCC1_14 As System.Windows.Forms.Label
    Friend WithEvents LabTotal As System.Windows.Forms.Label
    Friend WithEvents SchedulerControl As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents Timer_PercentComplete As System.Windows.Forms.Timer
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents Bar2 As DevExpress.XtraBars.Bar
    Friend WithEvents PopupMenuSchedulerControl As DevExpress.XtraBars.PopupMenu
    Friend WithEvents CmbFullScreen As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Tab7 As System.Windows.Forms.TabPage
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Master_HonHop As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_HonHopGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView11 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CbbCVDV_HonHop As System.Windows.Forms.ComboBox
    Friend WithEvents Master_Dung As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_DungGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView13 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView14 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents CbbCVDV_Dung As System.Windows.Forms.ComboBox
    Friend WithEvents Master_ChayThu As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_ChayThuGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView16 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView17 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents CbbCVDV_Chaythu As System.Windows.Forms.ComboBox
    Friend WithEvents Master_ThemGio As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_ThemGioGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView19 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView20 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents CbbCVDV_ThemGio As System.Windows.Forms.ComboBox
    Friend WithEvents Master_TiepDon As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_TiepDonGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView12 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView15 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents CbbCVDV_TiepDon As System.Windows.Forms.ComboBox
    Friend WithEvents CmdThu_Nho As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdDong_Lai As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ResourcesTree As DevExpress.XtraScheduler.UI.ResourcesTree
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents Tab8 As System.Windows.Forms.TabPage
    Friend WithEvents Master_khac As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_khacGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView18 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView21 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents CbbCVDV_Khac As System.Windows.Forms.ComboBox
    Friend WithEvents Tab9 As System.Windows.Forms.TabPage
    Friend WithEvents Master_HieuSuat As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master_HieuSuatGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView22 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView23 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Panel8 As System.Windows.Forms.Panel
    Friend WithEvents CbbLoai_HieuSuat As System.Windows.Forms.ComboBox
    Friend WithEvents CbbCVDV_HieuSuat As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip

End Class
