<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmXac_Nhan
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
        Me.SchedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.LabBarcode = New System.Windows.Forms.Label()
        Me.TxtBarCode = New System.Windows.Forms.TextBox()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CmdQuay_ra = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdTao_Moi = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdXac_Nhan = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtBarcodeName = New System.Windows.Forms.TextBox()
        Me.PopupMenuMasterGRV = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.SchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 497)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1131, 8)
        Me.GroupBoxLine.Visible = False
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(931, 507)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1033, 507)
        Me.ButtExit.Visible = False
        '
        'LabBarcode
        '
        Me.LabBarcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabBarcode.ForeColor = System.Drawing.Color.Navy
        Me.LabBarcode.Location = New System.Drawing.Point(6, 21)
        Me.LabBarcode.Name = "LabBarcode"
        Me.LabBarcode.Size = New System.Drawing.Size(79, 24)
        Me.LabBarcode.TabIndex = 2194
        Me.LabBarcode.Text = "KTV"
        Me.LabBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TxtBarCode
        '
        Me.TxtBarCode.BackColor = System.Drawing.Color.PowderBlue
        Me.TxtBarCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBarCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarCode.ForeColor = System.Drawing.Color.Navy
        Me.TxtBarCode.Location = New System.Drawing.Point(89, 9)
        Me.TxtBarCode.Name = "TxtBarCode"
        Me.TxtBarCode.Size = New System.Drawing.Size(409, 53)
        Me.TxtBarCode.TabIndex = 0
        Me.TxtBarCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(3, 69)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.Size = New System.Drawing.Size(1131, 468)
        Me.Master.TabIndex = 2195
        Me.Master.TabStop = False
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
        Me.MasterGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV.OptionsView.ShowGroupPanel = False
        Me.MasterGRV.RowHeight = 21
        '
        'CmdQuay_ra
        '
        Me.CmdQuay_ra.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdQuay_ra.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CmdQuay_ra.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdQuay_ra.Appearance.Options.UseFont = True
        Me.CmdQuay_ra.Appearance.Options.UseForeColor = True
        Me.CmdQuay_ra.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdQuay_ra.AppearanceHovered.Options.UseBackColor = True
        Me.CmdQuay_ra.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CmdQuay_ra.Image = Global.Cyber.Workprogress.My.Resources.Resources.close_32x32
        Me.CmdQuay_ra.Location = New System.Drawing.Point(1028, 11)
        Me.CmdQuay_ra.Name = "CmdQuay_ra"
        Me.CmdQuay_ra.Size = New System.Drawing.Size(106, 51)
        Me.CmdQuay_ra.TabIndex = 2196
        Me.CmdQuay_ra.TabStop = False
        Me.CmdQuay_ra.Text = "&Quay ra"
        '
        'CmdTao_Moi
        '
        Me.CmdTao_Moi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdTao_Moi.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CmdTao_Moi.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdTao_Moi.Appearance.Options.UseFont = True
        Me.CmdTao_Moi.Appearance.Options.UseForeColor = True
        Me.CmdTao_Moi.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdTao_Moi.AppearanceHovered.Options.UseBackColor = True
        Me.CmdTao_Moi.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CmdTao_Moi.Image = Global.Cyber.Workprogress.My.Resources.Resources.news_32x32
        Me.CmdTao_Moi.Location = New System.Drawing.Point(921, 11)
        Me.CmdTao_Moi.Name = "CmdTao_Moi"
        Me.CmdTao_Moi.Size = New System.Drawing.Size(106, 51)
        Me.CmdTao_Moi.TabIndex = 2197
        Me.CmdTao_Moi.TabStop = False
        Me.CmdTao_Moi.Text = "&Tạo mới"
        '
        'CmdXac_Nhan
        '
        Me.CmdXac_Nhan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdXac_Nhan.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.CmdXac_Nhan.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdXac_Nhan.Appearance.Options.UseFont = True
        Me.CmdXac_Nhan.Appearance.Options.UseForeColor = True
        Me.CmdXac_Nhan.AppearanceHovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdXac_Nhan.AppearanceHovered.Options.UseBackColor = True
        Me.CmdXac_Nhan.AppearancePressed.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdXac_Nhan.AppearancePressed.Options.UseBackColor = True
        Me.CmdXac_Nhan.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.CmdXac_Nhan.Image = Global.Cyber.Workprogress.My.Resources.Resources.apply_32x32
        Me.CmdXac_Nhan.Location = New System.Drawing.Point(812, 11)
        Me.CmdXac_Nhan.Name = "CmdXac_Nhan"
        Me.CmdXac_Nhan.Size = New System.Drawing.Size(106, 51)
        Me.CmdXac_Nhan.TabIndex = 1
        Me.CmdXac_Nhan.Text = "&Xác nhận"
        '
        'TxtBarcodeName
        '
        Me.TxtBarcodeName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtBarcodeName.BackColor = System.Drawing.Color.PowderBlue
        Me.TxtBarcodeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtBarcodeName.Enabled = False
        Me.TxtBarcodeName.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBarcodeName.ForeColor = System.Drawing.Color.Navy
        Me.TxtBarcodeName.Location = New System.Drawing.Point(501, 8)
        Me.TxtBarcodeName.Multiline = True
        Me.TxtBarcodeName.Name = "TxtBarcodeName"
        Me.TxtBarcodeName.Size = New System.Drawing.Size(309, 54)
        Me.TxtBarcodeName.TabIndex = 2199
        Me.TxtBarcodeName.TabStop = False
        Me.TxtBarcodeName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PopupMenuMasterGRV
        '
        Me.PopupMenuMasterGRV.Manager = Me.BarManager1
        Me.PopupMenuMasterGRV.Name = "PopupMenuMasterGRV"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1135, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 561)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1135, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 561)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1135, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 561)
        '
        'FrmXac_Nhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1135, 561)
        Me.Controls.Add(Me.TxtBarcodeName)
        Me.Controls.Add(Me.CmdXac_Nhan)
        Me.Controls.Add(Me.CmdTao_Moi)
        Me.Controls.Add(Me.CmdQuay_ra)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.LabBarcode)
        Me.Controls.Add(Me.TxtBarCode)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmXac_Nhan"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtBarCode, 0)
        Me.Controls.SetChildIndex(Me.LabBarcode, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.CmdQuay_ra, 0)
        Me.Controls.SetChildIndex(Me.CmdTao_Moi, 0)
        Me.Controls.SetChildIndex(Me.CmdXac_Nhan, 0)
        Me.Controls.SetChildIndex(Me.TxtBarcodeName, 0)
        CType(Me.SchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SchedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents LabBarcode As System.Windows.Forms.Label
    Friend WithEvents TxtBarCode As System.Windows.Forms.TextBox
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CmdQuay_ra As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdTao_Moi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdXac_Nhan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtBarcodeName As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenuMasterGRV As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl

End Class
