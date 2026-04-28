<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARAPTTPB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ARAPTTPB))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Master1 = New DevExpress.XtraGrid.GridControl()
        Me.Master1GRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Master2 = New DevExpress.XtraGrid.GridControl()
        Me.Master2GRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit3 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit4 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.CmdRefresh = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdAuto_Tien = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdAuto_SL = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdTao_PB = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdXoa_PB = New DevExpress.XtraEditors.SimpleButton()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.Master1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master1GRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master2GRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 453)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1665, 5)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(1399, 481)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1535, 481)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 1)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Master1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Master2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1668, 447)
        Me.SplitContainer1.SplitterDistance = 872
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 45
        '
        'Master1
        '
        Me.Master1.AllowDrop = True
        Me.Master1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Master1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master1.Location = New System.Drawing.Point(0, 0)
        Me.Master1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master1.MainView = Me.Master1GRV
        Me.Master1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Master1.Name = "Master1"
        Me.Master1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master1.Size = New System.Drawing.Size(872, 447)
        Me.Master1.TabIndex = 51
        Me.Master1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master1GRV})
        '
        'Master1GRV
        '
        Me.Master1GRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master1GRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master1GRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master1GRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master1GRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master1GRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master1GRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master1GRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master1GRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master1GRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master1GRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master1GRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master1GRV.GridControl = Me.Master1
        Me.Master1GRV.GroupRowHeight = 30
        Me.Master1GRV.Name = "Master1GRV"
        Me.Master1GRV.OptionsBehavior.Editable = False
        Me.Master1GRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master1GRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master1GRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master1GRV.OptionsView.ColumnAutoWidth = False
        Me.Master1GRV.OptionsView.ShowGroupPanel = False
        Me.Master1GRV.RowHeight = 21
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
        'Master2
        '
        Me.Master2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Master2.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Master2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master2.Location = New System.Drawing.Point(0, 0)
        Me.Master2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master2.MainView = Me.Master2GRV
        Me.Master2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Master2.Name = "Master2"
        Me.Master2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit3, Me.RepositoryItemTextEdit4})
        Me.Master2.Size = New System.Drawing.Size(791, 447)
        Me.Master2.TabIndex = 52
        Me.Master2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.Master2GRV})
        '
        'Master2GRV
        '
        Me.Master2GRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Master2GRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.Master2GRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.Master2GRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.Master2GRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.Master2GRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.Master2GRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.Master2GRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.Master2GRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master2GRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.Master2GRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.Master2GRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.Master2GRV.GridControl = Me.Master2
        Me.Master2GRV.GroupRowHeight = 30
        Me.Master2GRV.Name = "Master2GRV"
        Me.Master2GRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.Master2GRV.OptionsLayout.Columns.AddNewColumns = False
        Me.Master2GRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.Master2GRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.Master2GRV.OptionsView.ColumnAutoWidth = False
        Me.Master2GRV.OptionsView.ShowGroupPanel = False
        Me.Master2GRV.RowHeight = 21
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
        'CmdRefresh
        '
        Me.CmdRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdRefresh.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdRefresh.Appearance.Options.UseForeColor = True
        Me.CmdRefresh.Image = CType(resources.GetObject("CmdRefresh.Image"), System.Drawing.Image)
        Me.CmdRefresh.Location = New System.Drawing.Point(725, 481)
        Me.CmdRefresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdRefresh.Name = "CmdRefresh"
        Me.CmdRefresh.Size = New System.Drawing.Size(133, 37)
        Me.CmdRefresh.TabIndex = 46
        Me.CmdRefresh.Tag = "&Refesh"
        Me.CmdRefresh.Text = "Làm mới"
        '
        'CmdAuto_Tien
        '
        Me.CmdAuto_Tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdAuto_Tien.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdAuto_Tien.Appearance.Options.UseForeColor = True
        Me.CmdAuto_Tien.Image = CType(resources.GetObject("CmdAuto_Tien.Image"), System.Drawing.Image)
        Me.CmdAuto_Tien.Location = New System.Drawing.Point(861, 481)
        Me.CmdAuto_Tien.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdAuto_Tien.Name = "CmdAuto_Tien"
        Me.CmdAuto_Tien.Size = New System.Drawing.Size(133, 37)
        Me.CmdAuto_Tien.TabIndex = 47
        Me.CmdAuto_Tien.Tag = "Allocated by value"
        Me.CmdAuto_Tien.Text = "PB theo GT HĐ"
        '
        'CmdAuto_SL
        '
        Me.CmdAuto_SL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdAuto_SL.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdAuto_SL.Appearance.Options.UseForeColor = True
        Me.CmdAuto_SL.Image = CType(resources.GetObject("CmdAuto_SL.Image"), System.Drawing.Image)
        Me.CmdAuto_SL.Location = New System.Drawing.Point(995, 481)
        Me.CmdAuto_SL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdAuto_SL.Name = "CmdAuto_SL"
        Me.CmdAuto_SL.Size = New System.Drawing.Size(133, 37)
        Me.CmdAuto_SL.TabIndex = 48
        Me.CmdAuto_SL.Tag = "Allocated by quantity"
        Me.CmdAuto_SL.Text = "PB theo SL HĐ"
        '
        'CmdTao_PB
        '
        Me.CmdTao_PB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdTao_PB.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdTao_PB.Appearance.Options.UseForeColor = True
        Me.CmdTao_PB.Image = CType(resources.GetObject("CmdTao_PB.Image"), System.Drawing.Image)
        Me.CmdTao_PB.Location = New System.Drawing.Point(1131, 481)
        Me.CmdTao_PB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdTao_PB.Name = "CmdTao_PB"
        Me.CmdTao_PB.Size = New System.Drawing.Size(133, 37)
        Me.CmdTao_PB.TabIndex = 49
        Me.CmdTao_PB.Tag = "Create"
        Me.CmdTao_PB.Text = "Tạo phân bổ"
        '
        'CmdXoa_PB
        '
        Me.CmdXoa_PB.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdXoa_PB.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdXoa_PB.Appearance.Options.UseForeColor = True
        Me.CmdXoa_PB.Image = CType(resources.GetObject("CmdXoa_PB.Image"), System.Drawing.Image)
        Me.CmdXoa_PB.Location = New System.Drawing.Point(1265, 481)
        Me.CmdXoa_PB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdXoa_PB.Name = "CmdXoa_PB"
        Me.CmdXoa_PB.Size = New System.Drawing.Size(133, 37)
        Me.CmdXoa_PB.TabIndex = 50
        Me.CmdXoa_PB.Tag = "Delete"
        Me.CmdXoa_PB.Text = "Xóa phân bổ"
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1671, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 548)
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1671, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 548)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1671, 0)
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 548)
        '
        'ARAPTTPB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1671, 548)
        Me.Controls.Add(Me.CmdXoa_PB)
        Me.Controls.Add(Me.CmdTao_PB)
        Me.Controls.Add(Me.CmdAuto_SL)
        Me.Controls.Add(Me.CmdAuto_Tien)
        Me.Controls.Add(Me.CmdRefresh)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "ARAPTTPB"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.CmdRefresh, 0)
        Me.Controls.SetChildIndex(Me.CmdAuto_Tien, 0)
        Me.Controls.SetChildIndex(Me.CmdAuto_SL, 0)
        Me.Controls.SetChildIndex(Me.CmdTao_PB, 0)
        Me.Controls.SetChildIndex(Me.CmdXoa_PB, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.Master1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master1GRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master2GRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents Master1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master1GRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Master2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master2GRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit3 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit4 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents CmdRefresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdAuto_Tien As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdAuto_SL As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdTao_PB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdXoa_PB As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl

End Class
