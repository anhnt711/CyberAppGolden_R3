<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSua_Bien_So
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTiep_Don))
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.SchedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.CbbTime_Data = New System.Windows.Forms.ComboBox()
        Me.ChkAuto_Data = New System.Windows.Forms.CheckBox()
        Me.CbbCVDV = New System.Windows.Forms.ComboBox()
        Me.CbbDo_Rong = New System.Windows.Forms.ComboBox()
        Me.CbbMa_BN = New System.Windows.Forms.ComboBox()
        Me.TxtM_Ngay_Ct = New ClsTextBox.txtDate1()
        Me.Timer_Data = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_PercentComplete = New System.Windows.Forms.Timer(Me.components)
        Me.PopupMenuChoGRV = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.PopupMenuSchedulerControl = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.Pan_Dat = New System.Windows.Forms.Panel()
        Me.LabSo_Xe_Dat = New System.Windows.Forms.Label()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Lab_Dat = New System.Windows.Forms.Label()
        Me.Pan_Cho = New System.Windows.Forms.Panel()
        Me.LabSo_Xe_Cho = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Lab_Cho = New System.Windows.Forms.Label()
        Me.TxtMa_Xe_KH_SCC = New System.Windows.Forms.TextBox()
        Me.DGV_CHO = New DevExpress.XtraGrid.GridControl()
        Me.DGV_CHOGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuChoGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuSchedulerControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan_Dat.SuspendLayout()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Pan_Cho.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_CHO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_CHOGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 498)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1247, 8)
        Me.GroupBoxLine.Visible = False
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(1047, 475)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1149, 475)
        Me.ButtExit.Visible = False
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1251, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 494)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1251, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 494)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1251, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 494)
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
        'CbbTime_Data
        '
        Me.CbbTime_Data.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbTime_Data.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbTime_Data.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbTime_Data.ForeColor = System.Drawing.Color.Navy
        Me.CbbTime_Data.FormattingEnabled = True
        Me.CbbTime_Data.Location = New System.Drawing.Point(62, 448)
        Me.CbbTime_Data.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbTime_Data.Name = "CbbTime_Data"
        Me.CbbTime_Data.Size = New System.Drawing.Size(52, 21)
        Me.CbbTime_Data.TabIndex = 1925
        '
        'ChkAuto_Data
        '
        Me.ChkAuto_Data.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ChkAuto_Data.AutoSize = True
        Me.ChkAuto_Data.Location = New System.Drawing.Point(12, 453)
        Me.ChkAuto_Data.Name = "ChkAuto_Data"
        Me.ChkAuto_Data.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkAuto_Data.Size = New System.Drawing.Size(48, 17)
        Me.ChkAuto_Data.TabIndex = 1924
        Me.ChkAuto_Data.Text = "Auto"
        Me.ChkAuto_Data.UseVisualStyleBackColor = True
        '
        'CbbCVDV
        '
        Me.CbbCVDV.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbCVDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbCVDV.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbCVDV.ForeColor = System.Drawing.Color.Navy
        Me.CbbCVDV.FormattingEnabled = True
        Me.CbbCVDV.Location = New System.Drawing.Point(983, 447)
        Me.CbbCVDV.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbCVDV.Name = "CbbCVDV"
        Me.CbbCVDV.Size = New System.Drawing.Size(162, 21)
        Me.CbbCVDV.TabIndex = 1927
        '
        'CbbDo_Rong
        '
        Me.CbbDo_Rong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbDo_Rong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbDo_Rong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbDo_Rong.ForeColor = System.Drawing.Color.Navy
        Me.CbbDo_Rong.FormattingEnabled = True
        Me.CbbDo_Rong.Location = New System.Drawing.Point(177, 448)
        Me.CbbDo_Rong.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbDo_Rong.Name = "CbbDo_Rong"
        Me.CbbDo_Rong.Size = New System.Drawing.Size(52, 21)
        Me.CbbDo_Rong.TabIndex = 1929
        '
        'CbbMa_BN
        '
        Me.CbbMa_BN.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_BN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_BN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_BN.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_BN.FormattingEnabled = True
        Me.CbbMa_BN.Location = New System.Drawing.Point(118, 448)
        Me.CbbMa_BN.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_BN.Name = "CbbMa_BN"
        Me.CbbMa_BN.Size = New System.Drawing.Size(52, 21)
        Me.CbbMa_BN.TabIndex = 1928
        '
        'TxtM_Ngay_Ct
        '
        Me.TxtM_Ngay_Ct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtM_Ngay_Ct.Flags = 0
        Me.TxtM_Ngay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct.IsAllowResize = False
        Me.TxtM_Ngay_Ct.isEmpty = True
        Me.TxtM_Ngay_Ct.Location = New System.Drawing.Point(1149, 447)
        Me.TxtM_Ngay_Ct.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct.MaxLength = 10
        Me.TxtM_Ngay_Ct.Name = "TxtM_Ngay_Ct"
        Me.TxtM_Ngay_Ct.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct.Size = New System.Drawing.Size(102, 20)
        Me.TxtM_Ngay_Ct.TabIndex = 1930
        Me.TxtM_Ngay_Ct.Text = "__/__/____"
        Me.TxtM_Ngay_Ct.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Timer_PercentComplete
        '
        Me.Timer_PercentComplete.Interval = 1000
        '
        'PopupMenuChoGRV
        '
        Me.PopupMenuChoGRV.Manager = Me.BarManager1
        Me.PopupMenuChoGRV.Name = "PopupMenuChoGRV"
        '
        'PopupMenuSchedulerControl
        '
        Me.PopupMenuSchedulerControl.Manager = Me.BarManager1
        Me.PopupMenuSchedulerControl.Name = "PopupMenuSchedulerControl"
        '
        'Pan_Dat
        '
        Me.Pan_Dat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Pan_Dat.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Pan_Dat.Controls.Add(Me.LabSo_Xe_Dat)
        Me.Pan_Dat.Controls.Add(Me.PictureBox7)
        Me.Pan_Dat.Controls.Add(Me.Panel4)
        Me.Pan_Dat.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Pan_Dat.Location = New System.Drawing.Point(448, 448)
        Me.Pan_Dat.Name = "Pan_Dat"
        Me.Pan_Dat.Size = New System.Drawing.Size(45, 15)
        Me.Pan_Dat.TabIndex = 1944
        '
        'LabSo_Xe_Dat
        '
        Me.LabSo_Xe_Dat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabSo_Xe_Dat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabSo_Xe_Dat.ForeColor = System.Drawing.Color.Lavender
        Me.LabSo_Xe_Dat.Location = New System.Drawing.Point(11, 0)
        Me.LabSo_Xe_Dat.Name = "LabSo_Xe_Dat"
        Me.LabSo_Xe_Dat.Size = New System.Drawing.Size(32, 15)
        Me.LabSo_Xe_Dat.TabIndex = 27
        Me.LabSo_Xe_Dat.Text = "10"
        Me.LabSo_Xe_Dat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox7
        '
        Me.PictureBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(17, 15)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 13
        Me.PictureBox7.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Panel4.Controls.Add(Me.PictureBox8)
        Me.Panel4.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Panel4.Location = New System.Drawing.Point(-44, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(45, 15)
        Me.Panel4.TabIndex = 12
        '
        'PictureBox8
        '
        Me.PictureBox8.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), System.Drawing.Image)
        Me.PictureBox8.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(17, 15)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox8.TabIndex = 9
        Me.PictureBox8.TabStop = False
        '
        'Lab_Dat
        '
        Me.Lab_Dat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lab_Dat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Dat.ForeColor = System.Drawing.Color.Blue
        Me.Lab_Dat.Location = New System.Drawing.Point(492, 448)
        Me.Lab_Dat.Name = "Lab_Dat"
        Me.Lab_Dat.Size = New System.Drawing.Size(56, 15)
        Me.Lab_Dat.TabIndex = 1943
        Me.Lab_Dat.Text = "Đặt chỗ"
        Me.Lab_Dat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Pan_Cho
        '
        Me.Pan_Cho.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Pan_Cho.BackColor = System.Drawing.Color.Gray
        Me.Pan_Cho.Controls.Add(Me.LabSo_Xe_Cho)
        Me.Pan_Cho.Controls.Add(Me.PictureBox2)
        Me.Pan_Cho.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Pan_Cho.Location = New System.Drawing.Point(284, 449)
        Me.Pan_Cho.Name = "Pan_Cho"
        Me.Pan_Cho.Size = New System.Drawing.Size(43, 15)
        Me.Pan_Cho.TabIndex = 1938
        '
        'LabSo_Xe_Cho
        '
        Me.LabSo_Xe_Cho.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabSo_Xe_Cho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabSo_Xe_Cho.ForeColor = System.Drawing.Color.Lavender
        Me.LabSo_Xe_Cho.Location = New System.Drawing.Point(13, 0)
        Me.LabSo_Xe_Cho.Name = "LabSo_Xe_Cho"
        Me.LabSo_Xe_Cho.Size = New System.Drawing.Size(28, 15)
        Me.LabSo_Xe_Cho.TabIndex = 24
        Me.LabSo_Xe_Cho.Text = "10"
        Me.LabSo_Xe_Cho.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(17, 15)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'Lab_Cho
        '
        Me.Lab_Cho.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lab_Cho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Cho.ForeColor = System.Drawing.Color.Blue
        Me.Lab_Cho.Location = New System.Drawing.Point(329, 449)
        Me.Lab_Cho.Name = "Lab_Cho"
        Me.Lab_Cho.Size = New System.Drawing.Size(89, 15)
        Me.Lab_Cho.TabIndex = 1935
        Me.Lab_Cho.Text = "Chờ sửa chữa"
        Me.Lab_Cho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtMa_Xe_KH_SCC
        '
        Me.TxtMa_Xe_KH_SCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Xe_KH_SCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMa_Xe_KH_SCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMa_Xe_KH_SCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe_KH_SCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe_KH_SCC.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe_KH_SCC.Location = New System.Drawing.Point(822, 447)
        Me.TxtMa_Xe_KH_SCC.Name = "TxtMa_Xe_KH_SCC"
        Me.TxtMa_Xe_KH_SCC.Size = New System.Drawing.Size(159, 23)
        Me.TxtMa_Xe_KH_SCC.TabIndex = 1949
        Me.TxtMa_Xe_KH_SCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DGV_CHO
        '
        Me.DGV_CHO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DGV_CHO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGV_CHO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_CHO.Location = New System.Drawing.Point(0, 0)
        Me.DGV_CHO.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.DGV_CHO.MainView = Me.DGV_CHOGRV
        Me.DGV_CHO.Margin = New System.Windows.Forms.Padding(0)
        Me.DGV_CHO.Name = "DGV_CHO"
        Me.DGV_CHO.Size = New System.Drawing.Size(1251, 472)
        Me.DGV_CHO.TabIndex = 1954
        Me.DGV_CHO.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DGV_CHOGRV})
        '
        'DGV_CHOGRV
        '
        Me.DGV_CHOGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DGV_CHOGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DGV_CHOGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DGV_CHOGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DGV_CHOGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DGV_CHOGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DGV_CHOGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DGV_CHOGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DGV_CHOGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGV_CHOGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DGV_CHOGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DGV_CHOGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DGV_CHOGRV.GridControl = Me.DGV_CHO
        Me.DGV_CHOGRV.GroupRowHeight = 30
        Me.DGV_CHOGRV.Name = "DGV_CHOGRV"
        Me.DGV_CHOGRV.OptionsBehavior.Editable = False
        Me.DGV_CHOGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DGV_CHOGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.DGV_CHOGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DGV_CHOGRV.OptionsView.ColumnAutoWidth = False
        Me.DGV_CHOGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
        Me.DGV_CHOGRV.OptionsView.ShowGroupPanel = False
        Me.DGV_CHOGRV.RowHeight = 22
        '
        'FrmTiep_Don
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1251, 494)
        Me.Controls.Add(Me.DGV_CHO)
        Me.Controls.Add(Me.TxtMa_Xe_KH_SCC)
        Me.Controls.Add(Me.Pan_Dat)
        Me.Controls.Add(Me.Lab_Dat)
        Me.Controls.Add(Me.Pan_Cho)
        Me.Controls.Add(Me.Lab_Cho)
        Me.Controls.Add(Me.TxtM_Ngay_Ct)
        Me.Controls.Add(Me.CbbDo_Rong)
        Me.Controls.Add(Me.CbbMa_BN)
        Me.Controls.Add(Me.CbbCVDV)
        Me.Controls.Add(Me.CbbTime_Data)
        Me.Controls.Add(Me.ChkAuto_Data)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmTiep_Don"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.ChkAuto_Data, 0)
        Me.Controls.SetChildIndex(Me.CbbTime_Data, 0)
        Me.Controls.SetChildIndex(Me.CbbCVDV, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_BN, 0)
        Me.Controls.SetChildIndex(Me.CbbDo_Rong, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct, 0)
        Me.Controls.SetChildIndex(Me.Lab_Cho, 0)
        Me.Controls.SetChildIndex(Me.Pan_Cho, 0)
        Me.Controls.SetChildIndex(Me.Lab_Dat, 0)
        Me.Controls.SetChildIndex(Me.Pan_Dat, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe_KH_SCC, 0)
        Me.Controls.SetChildIndex(Me.DGV_CHO, 0)
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuChoGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuSchedulerControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan_Dat.ResumeLayout(False)
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Pan_Cho.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_CHO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_CHOGRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbTime_Data As System.Windows.Forms.ComboBox
    Friend WithEvents ChkAuto_Data As System.Windows.Forms.CheckBox
    Friend WithEvents CbbCVDV As System.Windows.Forms.ComboBox
    Friend WithEvents CbbDo_Rong As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_BN As System.Windows.Forms.ComboBox
    Friend WithEvents TxtM_Ngay_Ct As ClsTextBox.txtDate1
    Friend WithEvents Timer_Data As System.Windows.Forms.Timer
    Friend WithEvents Timer_PercentComplete As System.Windows.Forms.Timer
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents PopupMenuChoGRV As DevExpress.XtraBars.PopupMenu
    Friend WithEvents PopupMenuSchedulerControl As DevExpress.XtraBars.PopupMenu
    Friend WithEvents Pan_Dat As System.Windows.Forms.Panel
    Friend WithEvents LabSo_Xe_Dat As System.Windows.Forms.Label
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox8 As System.Windows.Forms.PictureBox
    Friend WithEvents Lab_Dat As System.Windows.Forms.Label
    Friend WithEvents Pan_Cho As System.Windows.Forms.Panel
    Friend WithEvents LabSo_Xe_Cho As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Lab_Cho As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe_KH_SCC As System.Windows.Forms.TextBox
    Friend WithEvents SchedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents DGV_CHO As DevExpress.XtraGrid.GridControl
    Friend WithEvents DGV_CHOGRV As DevExpress.XtraGrid.Views.Grid.GridView

End Class
