<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCapStt
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
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.PopupMenu = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.Bar1 = New DevExpress.XtraBars.Bar()
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.CbbMa_Quay = New System.Windows.Forms.ComboBox()
        Me.TxtMa_Quay = New System.Windows.Forms.TextBox()
        Me.Master_Ds = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV_Ds = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.CmdGoi = New DevExpress.XtraEditors.SimpleButton()
        Me.Timer_LoadDb = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_ScrollGrid = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_ScrollLable = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master_Ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV_Ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 471)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1172, 8)
        Me.GroupBoxLine.Visible = False
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Image = Global.Cyber.Workprogress.My.Resources.Resources.saveall_32x32
        Me.ButtOK.Location = New System.Drawing.Point(972, 480)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1074, 480)
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(3, -3)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.Size = New System.Drawing.Size(1171, 483)
        Me.Master.TabIndex = 277
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
        Me.MasterGRV.OptionsBehavior.Editable = False
        Me.MasterGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV.OptionsView.ShowGroupPanel = False
        Me.MasterGRV.RowHeight = 21
        '
        'PopupMenu
        '
        Me.PopupMenu.Manager = Me.BarManager1
        Me.PopupMenu.Name = "PopupMenu"
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
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Size = New System.Drawing.Size(1176, 29)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 534)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1176, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 29)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 505)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1176, 29)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 505)
        '
        'CbbMa_Quay
        '
        Me.CbbMa_Quay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_Quay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Quay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbbMa_Quay.ForeColor = System.Drawing.Color.Blue
        Me.CbbMa_Quay.FormattingEnabled = True
        Me.CbbMa_Quay.Location = New System.Drawing.Point(2, 482)
        Me.CbbMa_Quay.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_Quay.Name = "CbbMa_Quay"
        Me.CbbMa_Quay.Size = New System.Drawing.Size(192, 28)
        Me.CbbMa_Quay.TabIndex = 7317
        '
        'TxtMa_Quay
        '
        Me.TxtMa_Quay.BackColor = System.Drawing.Color.White
        Me.TxtMa_Quay.Enabled = False
        Me.TxtMa_Quay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Quay.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Quay.Location = New System.Drawing.Point(201, 484)
        Me.TxtMa_Quay.Name = "TxtMa_Quay"
        Me.TxtMa_Quay.ReadOnly = True
        Me.TxtMa_Quay.Size = New System.Drawing.Size(62, 26)
        Me.TxtMa_Quay.TabIndex = 7322
        Me.TxtMa_Quay.Tag = ""
        Me.TxtMa_Quay.Visible = False
        '
        'Master_Ds
        '
        Me.Master_Ds.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Master_Ds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master_Ds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master_Ds.Location = New System.Drawing.Point(0, -3)
        Me.Master_Ds.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master_Ds.MainView = Me.MasterGRV_Ds
        Me.Master_Ds.Name = "Master_Ds"
        Me.Master_Ds.Size = New System.Drawing.Size(10, 483)
        Me.Master_Ds.TabIndex = 7327
        Me.Master_Ds.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterGRV_Ds})
        Me.Master_Ds.Visible = False
        '
        'MasterGRV_Ds
        '
        Me.MasterGRV_Ds.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MasterGRV_Ds.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterGRV_Ds.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterGRV_Ds.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterGRV_Ds.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterGRV_Ds.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MasterGRV_Ds.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MasterGRV_Ds.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterGRV_Ds.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterGRV_Ds.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterGRV_Ds.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterGRV_Ds.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterGRV_Ds.GridControl = Me.Master_Ds
        Me.MasterGRV_Ds.GroupRowHeight = 30
        Me.MasterGRV_Ds.Name = "MasterGRV_Ds"
        Me.MasterGRV_Ds.OptionsBehavior.Editable = False
        Me.MasterGRV_Ds.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV_Ds.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV_Ds.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV_Ds.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterGRV_Ds.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV_Ds.OptionsView.ShowGroupPanel = False
        Me.MasterGRV_Ds.RowHeight = 21
        '
        'CmdGoi
        '
        Me.CmdGoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdGoi.Image = Global.Cyber.Workprogress.My.Resources.Resources.next_16x16
        Me.CmdGoi.Location = New System.Drawing.Point(201, 482)
        Me.CmdGoi.Name = "CmdGoi"
        Me.CmdGoi.Size = New System.Drawing.Size(146, 28)
        Me.CmdGoi.TabIndex = 7332
        Me.CmdGoi.Text = "Gọi khách hàng"
        '
        'FrmCapStt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1176, 534)
        Me.Controls.Add(Me.CmdGoi)
        Me.Controls.Add(Me.Master_Ds)
        Me.Controls.Add(Me.TxtMa_Quay)
        Me.Controls.Add(Me.CbbMa_Quay)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "FrmCapStt"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Quay, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Quay, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Master_Ds, 0)
        Me.Controls.SetChildIndex(Me.CmdGoi, 0)
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master_Ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV_Ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PopupMenu As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents Bar1 As DevExpress.XtraBars.Bar
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents CbbMa_Quay As System.Windows.Forms.ComboBox
    Friend WithEvents TxtMa_Quay As System.Windows.Forms.TextBox
    Friend WithEvents Master_Ds As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV_Ds As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents CmdGoi As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Timer_LoadDb As System.Windows.Forms.Timer
    Friend WithEvents Timer_ScrollGrid As System.Windows.Forms.Timer
    Friend WithEvents Timer_ScrollLable As System.Windows.Forms.Timer

End Class
