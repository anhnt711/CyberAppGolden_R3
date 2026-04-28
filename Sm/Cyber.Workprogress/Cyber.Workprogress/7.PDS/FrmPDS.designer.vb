<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPDS
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CbbSchedulerViewType = New System.Windows.Forms.ComboBox()
        Me.CbbLoai_Xem = New System.Windows.Forms.ComboBox()
        Me.CbbMa4 = New System.Windows.Forms.ComboBox()
        Me.CbbMa3 = New System.Windows.Forms.ComboBox()
        Me.CbbMa_BP = New System.Windows.Forms.ComboBox()
        Me.CbbDo_Rong = New System.Windows.Forms.ComboBox()
        Me.CbbMa_BN = New System.Windows.Forms.ComboBox()
        Me.TxtM_Ngay_Ct = New ClsTextBox.txtDate1()
        Me.ChkAuto_Data = New System.Windows.Forms.CheckBox()
        Me.CbbTime_Data = New System.Windows.Forms.ComboBox()
        Me.CbbMa_Hs = New System.Windows.Forms.ComboBox()
        Me.SchedulerControl = New DevExpress.XtraScheduler.SchedulerControl()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SchedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.ToolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
        Me.Timer_Data = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainer_Left = New System.Windows.Forms.SplitContainer()
        Me.MasterLeft = New DevExpress.XtraGrid.GridControl()
        Me.MasterLeftGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.C = New System.Windows.Forms.Label()
        Me.SplitContainer_Right = New System.Windows.Forms.SplitContainer()
        Me.MasterRight = New DevExpress.XtraGrid.GridControl()
        Me.MasterRightGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LabRight = New System.Windows.Forms.Label()
        Me.SplitContainer_Tree = New System.Windows.Forms.SplitContainer()
        Me.ResourcesTree = New DevExpress.XtraScheduler.UI.ResourcesTree()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.LabHead = New System.Windows.Forms.Label()
        Me.PopupMenuSchedulerControl = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.PopupMenuLeft = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.PopupMenuRight = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.Timer_PercentComplete = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2.SuspendLayout()
        CType(Me.SchedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer_Left, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Left.Panel1.SuspendLayout()
        Me.SplitContainer_Left.Panel2.SuspendLayout()
        Me.SplitContainer_Left.SuspendLayout()
        CType(Me.MasterLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterLeftGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer_Right, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Right.Panel1.SuspendLayout()
        Me.SplitContainer_Right.Panel2.SuspendLayout()
        Me.SplitContainer_Right.SuspendLayout()
        CType(Me.MasterRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterRightGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer_Tree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer_Tree.Panel1.SuspendLayout()
        Me.SplitContainer_Tree.Panel2.SuspendLayout()
        Me.SplitContainer_Tree.SuspendLayout()
        CType(Me.ResourcesTree, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuSchedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 468)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1023, 8)
        Me.GroupBoxLine.Visible = False
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(823, 478)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(925, 478)
        Me.ButtExit.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CbbSchedulerViewType)
        Me.GroupBox2.Controls.Add(Me.CbbLoai_Xem)
        Me.GroupBox2.Controls.Add(Me.CbbMa4)
        Me.GroupBox2.Controls.Add(Me.CbbMa3)
        Me.GroupBox2.Controls.Add(Me.CbbMa_BP)
        Me.GroupBox2.Controls.Add(Me.CbbDo_Rong)
        Me.GroupBox2.Controls.Add(Me.CbbMa_BN)
        Me.GroupBox2.Controls.Add(Me.TxtM_Ngay_Ct)
        Me.GroupBox2.Controls.Add(Me.ChkAuto_Data)
        Me.GroupBox2.Controls.Add(Me.CbbTime_Data)
        Me.GroupBox2.Controls.Add(Me.CbbMa_Hs)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox2.Location = New System.Drawing.Point(0, 404)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1027, 38)
        Me.GroupBox2.TabIndex = 448
        Me.GroupBox2.TabStop = False
        '
        'CbbSchedulerViewType
        '
        Me.CbbSchedulerViewType.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbSchedulerViewType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbSchedulerViewType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbSchedulerViewType.ForeColor = System.Drawing.Color.Navy
        Me.CbbSchedulerViewType.FormattingEnabled = True
        Me.CbbSchedulerViewType.Location = New System.Drawing.Point(159, 10)
        Me.CbbSchedulerViewType.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbSchedulerViewType.Name = "CbbSchedulerViewType"
        Me.CbbSchedulerViewType.Size = New System.Drawing.Size(89, 21)
        Me.CbbSchedulerViewType.TabIndex = 7128
        Me.CbbSchedulerViewType.Visible = False
        '
        'CbbLoai_Xem
        '
        Me.CbbLoai_Xem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbLoai_Xem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbLoai_Xem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbLoai_Xem.ForeColor = System.Drawing.Color.Navy
        Me.CbbLoai_Xem.FormattingEnabled = True
        Me.CbbLoai_Xem.Location = New System.Drawing.Point(291, 10)
        Me.CbbLoai_Xem.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbLoai_Xem.Name = "CbbLoai_Xem"
        Me.CbbLoai_Xem.Size = New System.Drawing.Size(69, 21)
        Me.CbbLoai_Xem.TabIndex = 1957
        '
        'CbbMa4
        '
        Me.CbbMa4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMa4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa4.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa4.FormattingEnabled = True
        Me.CbbMa4.Location = New System.Drawing.Point(741, 10)
        Me.CbbMa4.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa4.Name = "CbbMa4"
        Me.CbbMa4.Size = New System.Drawing.Size(152, 21)
        Me.CbbMa4.TabIndex = 7123
        Me.CbbMa4.Visible = False
        '
        'CbbMa3
        '
        Me.CbbMa3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMa3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa3.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa3.FormattingEnabled = True
        Me.CbbMa3.Location = New System.Drawing.Point(672, 10)
        Me.CbbMa3.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa3.Name = "CbbMa3"
        Me.CbbMa3.Size = New System.Drawing.Size(152, 21)
        Me.CbbMa3.TabIndex = 7122
        Me.CbbMa3.Visible = False
        '
        'CbbMa_BP
        '
        Me.CbbMa_BP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_BP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_BP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_BP.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_BP.FormattingEnabled = True
        Me.CbbMa_BP.Location = New System.Drawing.Point(517, 10)
        Me.CbbMa_BP.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_BP.Name = "CbbMa_BP"
        Me.CbbMa_BP.Size = New System.Drawing.Size(152, 21)
        Me.CbbMa_BP.TabIndex = 7121
        Me.CbbMa_BP.Visible = False
        '
        'CbbDo_Rong
        '
        Me.CbbDo_Rong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbDo_Rong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbDo_Rong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbDo_Rong.ForeColor = System.Drawing.Color.Navy
        Me.CbbDo_Rong.FormattingEnabled = True
        Me.CbbDo_Rong.Location = New System.Drawing.Point(246, 10)
        Me.CbbDo_Rong.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbDo_Rong.Name = "CbbDo_Rong"
        Me.CbbDo_Rong.Size = New System.Drawing.Size(44, 21)
        Me.CbbDo_Rong.TabIndex = 1936
        Me.CbbDo_Rong.Visible = False
        '
        'CbbMa_BN
        '
        Me.CbbMa_BN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_BN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_BN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_BN.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_BN.FormattingEnabled = True
        Me.CbbMa_BN.Location = New System.Drawing.Point(59, 10)
        Me.CbbMa_BN.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_BN.Name = "CbbMa_BN"
        Me.CbbMa_BN.Size = New System.Drawing.Size(100, 21)
        Me.CbbMa_BN.TabIndex = 1935
        Me.CbbMa_BN.Visible = False
        '
        'TxtM_Ngay_Ct
        '
        Me.TxtM_Ngay_Ct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtM_Ngay_Ct.Flags = 0
        Me.TxtM_Ngay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct.IsAllowResize = False
        Me.TxtM_Ngay_Ct.isEmpty = True
        Me.TxtM_Ngay_Ct.Location = New System.Drawing.Point(938, 11)
        Me.TxtM_Ngay_Ct.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct.MaxLength = 10
        Me.TxtM_Ngay_Ct.Name = "TxtM_Ngay_Ct"
        Me.TxtM_Ngay_Ct.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct.ReadOnly = True
        Me.TxtM_Ngay_Ct.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct.Size = New System.Drawing.Size(86, 20)
        Me.TxtM_Ngay_Ct.TabIndex = 1932
        Me.TxtM_Ngay_Ct.Text = "__/__/____"
        Me.TxtM_Ngay_Ct.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'ChkAuto_Data
        '
        Me.ChkAuto_Data.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkAuto_Data.AutoSize = True
        Me.ChkAuto_Data.Location = New System.Drawing.Point(9, 12)
        Me.ChkAuto_Data.Name = "ChkAuto_Data"
        Me.ChkAuto_Data.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkAuto_Data.Size = New System.Drawing.Size(48, 17)
        Me.ChkAuto_Data.TabIndex = 7118
        Me.ChkAuto_Data.Text = "Auto"
        Me.ChkAuto_Data.UseVisualStyleBackColor = True
        '
        'CbbTime_Data
        '
        Me.CbbTime_Data.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbTime_Data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbTime_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbTime_Data.ForeColor = System.Drawing.Color.Navy
        Me.CbbTime_Data.FormattingEnabled = True
        Me.CbbTime_Data.Location = New System.Drawing.Point(59, 10)
        Me.CbbTime_Data.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbTime_Data.Name = "CbbTime_Data"
        Me.CbbTime_Data.Size = New System.Drawing.Size(52, 21)
        Me.CbbTime_Data.TabIndex = 7119
        '
        'CbbMa_Hs
        '
        Me.CbbMa_Hs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_Hs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Hs.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_Hs.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Hs.FormattingEnabled = True
        Me.CbbMa_Hs.Location = New System.Drawing.Point(362, 10)
        Me.CbbMa_Hs.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_Hs.Name = "CbbMa_Hs"
        Me.CbbMa_Hs.Size = New System.Drawing.Size(152, 21)
        Me.CbbMa_Hs.TabIndex = 7120
        Me.CbbMa_Hs.Visible = False
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
        Me.SchedulerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
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
        Me.SchedulerControl.Size = New System.Drawing.Size(293, 345)
        Me.SchedulerControl.Start = New Date(2017, 8, 16, 0, 0, 0, 0)
        Me.SchedulerControl.Storage = Me.SchedulerStorage
        Me.SchedulerControl.TabIndex = 449
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
        'BarManager1
        '
        Me.BarManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() {Me.Bar1})
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
        Me.Bar1.Visible = False
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1027, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 464)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1027, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 435)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1027, 29)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 435)
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
        'SplitContainer_Left
        '
        Me.SplitContainer_Left.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Left.Location = New System.Drawing.Point(0, 29)
        Me.SplitContainer_Left.Name = "SplitContainer_Left"
        '
        'SplitContainer_Left.Panel1
        '
        Me.SplitContainer_Left.Panel1.Controls.Add(Me.MasterLeft)
        Me.SplitContainer_Left.Panel1.Controls.Add(Me.C)
        Me.SplitContainer_Left.Panel1MinSize = 0
        '
        'SplitContainer_Left.Panel2
        '
        Me.SplitContainer_Left.Panel2.Controls.Add(Me.SplitContainer_Right)
        Me.SplitContainer_Left.Panel2MinSize = 0
        Me.SplitContainer_Left.Size = New System.Drawing.Size(1027, 375)
        Me.SplitContainer_Left.SplitterDistance = 289
        Me.SplitContainer_Left.TabIndex = 450
        '
        'MasterLeft
        '
        Me.MasterLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MasterLeft.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterLeft.Location = New System.Drawing.Point(0, 30)
        Me.MasterLeft.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.MasterLeft.MainView = Me.MasterLeftGRV
        Me.MasterLeft.Name = "MasterLeft"
        Me.MasterLeft.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.MasterLeft.Size = New System.Drawing.Size(289, 345)
        Me.MasterLeft.TabIndex = 1792
        Me.MasterLeft.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterLeftGRV})
        '
        'MasterLeftGRV
        '
        Me.MasterLeftGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MasterLeftGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterLeftGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterLeftGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterLeftGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterLeftGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MasterLeftGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MasterLeftGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterLeftGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterLeftGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterLeftGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterLeftGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterLeftGRV.GridControl = Me.MasterLeft
        Me.MasterLeftGRV.GroupRowHeight = 30
        Me.MasterLeftGRV.Name = "MasterLeftGRV"
        Me.MasterLeftGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterLeftGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterLeftGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterLeftGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterLeftGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterLeftGRV.OptionsView.ShowGroupPanel = False
        Me.MasterLeftGRV.RowHeight = 21
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
        'C
        '
        Me.C.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.C.Dock = System.Windows.Forms.DockStyle.Top
        Me.C.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C.ForeColor = System.Drawing.Color.White
        Me.C.Location = New System.Drawing.Point(0, 0)
        Me.C.Name = "C"
        Me.C.Size = New System.Drawing.Size(289, 30)
        Me.C.TabIndex = 1793
        Me.C.Tag = "WAITING"
        Me.C.Text = "CHỜ KẾ HOẠCH"
        Me.C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer_Right
        '
        Me.SplitContainer_Right.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Right.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer_Right.Name = "SplitContainer_Right"
        '
        'SplitContainer_Right.Panel1
        '
        Me.SplitContainer_Right.Panel1.Controls.Add(Me.MasterRight)
        Me.SplitContainer_Right.Panel1.Controls.Add(Me.LabRight)
        Me.SplitContainer_Right.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer_Right.Panel1MinSize = 0
        '
        'SplitContainer_Right.Panel2
        '
        Me.SplitContainer_Right.Panel2.Controls.Add(Me.SplitContainer_Tree)
        Me.SplitContainer_Right.Panel2.Controls.Add(Me.LabHead)
        Me.SplitContainer_Right.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer_Right.Panel2MinSize = 0
        Me.SplitContainer_Right.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SplitContainer_Right.Size = New System.Drawing.Size(734, 375)
        Me.SplitContainer_Right.SplitterDistance = 233
        Me.SplitContainer_Right.TabIndex = 0
        '
        'MasterRight
        '
        Me.MasterRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.MasterRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MasterRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterRight.Location = New System.Drawing.Point(0, 30)
        Me.MasterRight.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.MasterRight.MainView = Me.MasterRightGRV
        Me.MasterRight.Name = "MasterRight"
        Me.MasterRight.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4})
        Me.MasterRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.MasterRight.Size = New System.Drawing.Size(233, 345)
        Me.MasterRight.TabIndex = 1792
        Me.MasterRight.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterRightGRV})
        '
        'MasterRightGRV
        '
        Me.MasterRightGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MasterRightGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterRightGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterRightGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterRightGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterRightGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MasterRightGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MasterRightGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterRightGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterRightGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterRightGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterRightGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterRightGRV.GridControl = Me.MasterRight
        Me.MasterRightGRV.GroupRowHeight = 30
        Me.MasterRightGRV.Name = "MasterRightGRV"
        Me.MasterRightGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterRightGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterRightGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterRightGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterRightGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterRightGRV.OptionsView.ShowGroupPanel = False
        Me.MasterRightGRV.RowHeight = 21
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
        'LabRight
        '
        Me.LabRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabRight.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabRight.ForeColor = System.Drawing.Color.White
        Me.LabRight.Location = New System.Drawing.Point(0, 0)
        Me.LabRight.Name = "LabRight"
        Me.LabRight.Size = New System.Drawing.Size(233, 30)
        Me.LabRight.TabIndex = 1795
        Me.LabRight.Tag = "FINISH"
        Me.LabRight.Text = "HOÀN THÀNH"
        Me.LabRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer_Tree
        '
        Me.SplitContainer_Tree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer_Tree.Location = New System.Drawing.Point(0, 30)
        Me.SplitContainer_Tree.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer_Tree.Name = "SplitContainer_Tree"
        '
        'SplitContainer_Tree.Panel1
        '
        Me.SplitContainer_Tree.Panel1.Controls.Add(Me.ResourcesTree)
        Me.SplitContainer_Tree.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer_Tree.Panel1MinSize = 0
        '
        'SplitContainer_Tree.Panel2
        '
        Me.SplitContainer_Tree.Panel2.Controls.Add(Me.SchedulerControl)
        Me.SplitContainer_Tree.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer_Tree.Panel2MinSize = 0
        Me.SplitContainer_Tree.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.SplitContainer_Tree.Size = New System.Drawing.Size(497, 345)
        Me.SplitContainer_Tree.SplitterDistance = 200
        Me.SplitContainer_Tree.TabIndex = 450
        '
        'ResourcesTree
        '
        Me.ResourcesTree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ResourcesTree.FixedLineWidth = 1
        Me.ResourcesTree.HorzScrollStep = 1
        Me.ResourcesTree.Location = New System.Drawing.Point(0, 0)
        Me.ResourcesTree.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.ResourcesTree.MenuManager = Me.BarManager1
        Me.ResourcesTree.Name = "ResourcesTree"
        Me.ResourcesTree.OptionsBehavior.Editable = False
        Me.ResourcesTree.OptionsView.FocusRectStyle = DevExpress.XtraTreeList.DrawFocusRectStyle.RowFullFocus
        Me.ResourcesTree.OptionsView.ShowButtons = False
        Me.ResourcesTree.OptionsView.ShowRoot = False
        Me.ResourcesTree.OptionsView.ShowVertLines = True
        Me.ResourcesTree.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.ResourcesTree.SchedulerControl = Me.SchedulerControl
        Me.ResourcesTree.ShowButtonMode = DevExpress.XtraTreeList.ShowButtonModeEnum.ShowForFocusedRow
        Me.ResourcesTree.Size = New System.Drawing.Size(200, 345)
        Me.ResourcesTree.TabIndex = 5
        Me.ResourcesTree.TreeLineStyle = DevExpress.XtraTreeList.LineStyle.None
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'LabHead
        '
        Me.LabHead.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabHead.ForeColor = System.Drawing.Color.White
        Me.LabHead.Location = New System.Drawing.Point(0, 0)
        Me.LabHead.Name = "LabHead"
        Me.LabHead.Size = New System.Drawing.Size(497, 30)
        Me.LabHead.TabIndex = 1794
        Me.LabHead.Tag = "PLANNING"
        Me.LabHead.Text = "KẾ HOẠCH"
        Me.LabHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PopupMenuSchedulerControl
        '
        Me.PopupMenuSchedulerControl.Manager = Me.BarManager1
        Me.PopupMenuSchedulerControl.Name = "PopupMenuSchedulerControl"
        '
        'PopupMenuLeft
        '
        Me.PopupMenuLeft.Manager = Me.BarManager1
        Me.PopupMenuLeft.Name = "PopupMenuLeft"
        '
        'PopupMenuRight
        '
        Me.PopupMenuRight.Manager = Me.BarManager1
        Me.PopupMenuRight.Name = "PopupMenuRight"
        '
        'Timer_PercentComplete
        '
        Me.Timer_PercentComplete.Interval = 1000
        '
        'FrmPDS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1027, 464)
        Me.Controls.Add(Me.SplitContainer_Left)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmPDS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer_Left, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SchedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Left.Panel1.ResumeLayout(False)
        Me.SplitContainer_Left.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Left, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Left.ResumeLayout(False)
        CType(Me.MasterLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterLeftGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Right.Panel1.ResumeLayout(False)
        Me.SplitContainer_Right.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Right, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Right.ResumeLayout(False)
        CType(Me.MasterRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterRightGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Tree.Panel1.ResumeLayout(False)
        Me.SplitContainer_Tree.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer_Tree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer_Tree.ResumeLayout(False)
        CType(Me.ResourcesTree, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuSchedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkAuto_Data As System.Windows.Forms.CheckBox
    Friend WithEvents CbbTime_Data As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_Hs As System.Windows.Forms.ComboBox
    Friend WithEvents TxtM_Ngay_Ct As ClsTextBox.txtDate1
    Friend WithEvents SchedulerControl As DevExpress.XtraScheduler.SchedulerControl
    Friend WithEvents SchedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents Timer_Data As System.Windows.Forms.Timer
    Friend WithEvents CbbDo_Rong As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_BN As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa4 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa3 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_BP As System.Windows.Forms.ComboBox
    Friend WithEvents CbbLoai_Xem As System.Windows.Forms.ComboBox
    Friend WithEvents SplitContainer_Left As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer_Right As System.Windows.Forms.SplitContainer
    Friend WithEvents MasterLeft As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterLeftGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PopupMenuSchedulerControl As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Private WithEvents PopupMenuLeft As DevExpress.XtraBars.PopupMenu
    Private WithEvents PopupMenuRight As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Timer_PercentComplete As System.Windows.Forms.Timer
    Friend WithEvents SplitContainer_Tree As System.Windows.Forms.SplitContainer
    Friend WithEvents ResourcesTree As DevExpress.XtraScheduler.UI.ResourcesTree
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents C As System.Windows.Forms.Label
    Friend WithEvents LabRight As System.Windows.Forms.Label
    Friend WithEvents LabHead As System.Windows.Forms.Label
    Friend WithEvents CbbSchedulerViewType As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTipController1 As DevExpress.Utils.ToolTipController
    Friend WithEvents MasterRight As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterRightGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit

End Class
