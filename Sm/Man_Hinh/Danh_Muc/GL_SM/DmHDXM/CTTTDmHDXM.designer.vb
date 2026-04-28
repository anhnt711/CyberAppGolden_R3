<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTTTDmHDXM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTTTDmHDXM))
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.LabTong_Cong = New System.Windows.Forms.Label()
        Me.TxtT_Tien_Nt = New ClsTextBox.txtTy_Gia()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtT_So_Luong = New ClsTextBox.txtTy_Gia()
        Me.TxtT_Tien_No = New ClsTextBox.txtTy_Gia()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 390)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1004, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Image = CType(resources.GetObject("ButtOK.Image"), System.Drawing.Image)
        Me.ButtOK.Location = New System.Drawing.Point(785, 400)
        Me.ButtOK.Size = New System.Drawing.Size(115, 30)
        Me.ButtOK.TabIndex = 10
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(906, 400)
        Me.ButtExit.TabIndex = 11
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(2, 12)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master.Size = New System.Drawing.Size(1006, 382)
        Me.Master.TabIndex = 506
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
        Me.MasterGRV.CustomizationFormBounds = New System.Drawing.Rectangle(814, 465, 210, 172)
        Me.MasterGRV.GridControl = Me.Master
        Me.MasterGRV.GroupRowHeight = 30
        Me.MasterGRV.Name = "MasterGRV"
        Me.MasterGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = False
        Me.MasterGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never
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
        Me.barDockControlTop.Size = New System.Drawing.Size(1008, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 454)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1008, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 454)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1008, 0)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 454)
        '
        'LabTong_Cong
        '
        Me.LabTong_Cong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabTong_Cong.BackColor = System.Drawing.Color.White
        Me.LabTong_Cong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTong_Cong.ForeColor = System.Drawing.Color.Navy
        Me.LabTong_Cong.Location = New System.Drawing.Point(7, 409)
        Me.LabTong_Cong.Name = "LabTong_Cong"
        Me.LabTong_Cong.Size = New System.Drawing.Size(82, 14)
        Me.LabTong_Cong.TabIndex = 517
        Me.LabTong_Cong.Tag = "Date"
        Me.LabTong_Cong.Text = "Tổng tiền nợ"
        '
        'TxtT_Tien_Nt
        '
        Me.TxtT_Tien_Nt.AllowNegative = True
        Me.TxtT_Tien_Nt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_Nt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtT_Tien_Nt.Flags = 7680
        Me.TxtT_Tien_Nt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_Tien_Nt.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_Nt.InputMask = "### ### ### ### ###"
        Me.TxtT_Tien_Nt.Location = New System.Drawing.Point(359, 406)
        Me.TxtT_Tien_Nt.MaxWholeDigits = 14
        Me.TxtT_Tien_Nt.Name = "TxtT_Tien_Nt"
        Me.TxtT_Tien_Nt.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_Nt.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_Nt.ReadOnly = True
        Me.TxtT_Tien_Nt.Size = New System.Drawing.Size(111, 20)
        Me.TxtT_Tien_Nt.TabIndex = 516
        Me.TxtT_Tien_Nt.TabStop = False
        Me.TxtT_Tien_Nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(476, 409)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 14)
        Me.Label1.TabIndex = 519
        Me.Label1.Tag = "Date"
        Me.Label1.Text = "Tổng số lượng chứng từ"
        '
        'TxtT_So_Luong
        '
        Me.TxtT_So_Luong.AllowNegative = True
        Me.TxtT_So_Luong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_So_Luong.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtT_So_Luong.Flags = 7680
        Me.TxtT_So_Luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_So_Luong.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_So_Luong.InputMask = "### ### ### ### ###"
        Me.TxtT_So_Luong.Location = New System.Drawing.Point(632, 406)
        Me.TxtT_So_Luong.MaxWholeDigits = 14
        Me.TxtT_So_Luong.Name = "TxtT_So_Luong"
        Me.TxtT_So_Luong.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_So_Luong.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_So_Luong.ReadOnly = True
        Me.TxtT_So_Luong.Size = New System.Drawing.Size(111, 20)
        Me.TxtT_So_Luong.TabIndex = 518
        Me.TxtT_So_Luong.TabStop = False
        Me.TxtT_So_Luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtT_Tien_No
        '
        Me.TxtT_Tien_No.AllowNegative = True
        Me.TxtT_Tien_No.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_No.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtT_Tien_No.Flags = 7680
        Me.TxtT_Tien_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtT_Tien_No.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_No.InputMask = "### ### ### ### ###"
        Me.TxtT_Tien_No.Location = New System.Drawing.Point(95, 406)
        Me.TxtT_Tien_No.MaxWholeDigits = 14
        Me.TxtT_Tien_No.Name = "TxtT_Tien_No"
        Me.TxtT_Tien_No.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_No.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_No.ReadOnly = True
        Me.TxtT_Tien_No.Size = New System.Drawing.Size(111, 20)
        Me.TxtT_Tien_No.TabIndex = 524
        Me.TxtT_Tien_No.TabStop = False
        Me.TxtT_Tien_No.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(243, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 14)
        Me.Label2.TabIndex = 529
        Me.Label2.Tag = "Date"
        Me.Label2.Text = "Tổng tiền kê khai"
        '
        'CTTTDMHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1008, 454)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtT_Tien_No)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtT_So_Luong)
        Me.Controls.Add(Me.LabTong_Cong)
        Me.Controls.Add(Me.TxtT_Tien_Nt)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "CTTTDMHD"
        Me.Text = "Cập nhật kỳ thanh toán"
        Me.Controls.SetChildIndex(Me.barDockControlTop, 0)
        Me.Controls.SetChildIndex(Me.barDockControlBottom, 0)
        Me.Controls.SetChildIndex(Me.barDockControlRight, 0)
        Me.Controls.SetChildIndex(Me.barDockControlLeft, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_Nt, 0)
        Me.Controls.SetChildIndex(Me.LabTong_Cong, 0)
        Me.Controls.SetChildIndex(Me.TxtT_So_Luong, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_No, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtT_So_Luong As ClsTextBox.txtTy_Gia
    Friend WithEvents LabTong_Cong As System.Windows.Forms.Label
    Friend WithEvents TxtT_Tien_Nt As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtT_Tien_No As ClsTextBox.txtTy_Gia
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
