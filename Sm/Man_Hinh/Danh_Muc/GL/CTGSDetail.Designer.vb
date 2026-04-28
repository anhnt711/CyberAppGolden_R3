<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTGSDetail
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CTGSDetail))
        Me.CmdOk = New System.Windows.Forms.Button()
        Me.CmdRemoveAll = New System.Windows.Forms.Button()
        Me.CmdExit = New System.Windows.Forms.Button()
        Me.CmdSelectAll = New System.Windows.Forms.Button()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdOk
        '
        Me.CmdOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdOk.Location = New System.Drawing.Point(1085, 522)
        Me.CmdOk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdOk.Name = "CmdOk"
        Me.CmdOk.Size = New System.Drawing.Size(153, 38)
        Me.CmdOk.TabIndex = 40
        Me.CmdOk.Tag = "&Sign in"
        Me.CmdOk.Text = "&Đăng ký CTGS"
        Me.CmdOk.UseVisualStyleBackColor = True
        '
        'CmdRemoveAll
        '
        Me.CmdRemoveAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdRemoveAll.Location = New System.Drawing.Point(153, 522)
        Me.CmdRemoveAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdRemoveAll.Name = "CmdRemoveAll"
        Me.CmdRemoveAll.Size = New System.Drawing.Size(153, 38)
        Me.CmdRemoveAll.TabIndex = 39
        Me.CmdRemoveAll.Tag = "&Remove All"
        Me.CmdRemoveAll.Text = "&Không chọn"
        Me.CmdRemoveAll.UseVisualStyleBackColor = True
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CmdExit.Location = New System.Drawing.Point(1244, 522)
        Me.CmdExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(153, 38)
        Me.CmdExit.TabIndex = 37
        Me.CmdExit.TabStop = False
        Me.CmdExit.Tag = "&Exit"
        Me.CmdExit.Text = "&Quay ra"
        Me.CmdExit.UseVisualStyleBackColor = True
        '
        'CmdSelectAll
        '
        Me.CmdSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdSelectAll.Location = New System.Drawing.Point(-1, 522)
        Me.CmdSelectAll.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdSelectAll.Name = "CmdSelectAll"
        Me.CmdSelectAll.Size = New System.Drawing.Size(153, 38)
        Me.CmdSelectAll.TabIndex = 38
        Me.CmdSelectAll.Tag = "&SELECT ALL"
        Me.CmdSelectAll.Text = "&Chọn"
        Me.CmdSelectAll.UseVisualStyleBackColor = True
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(0, 0)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Master.Name = "Master"
        Me.Master.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master.Size = New System.Drawing.Size(1399, 519)
        Me.Master.TabIndex = 41
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
        Me.PopupMenuMasterGrid.Name = "PopupMenuMasterGrid"
        '
        'CTGSDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 561)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.CmdOk)
        Me.Controls.Add(Me.CmdRemoveAll)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdSelectAll)
        Me.ForeColor = System.Drawing.Color.Navy
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimizeBox = False
        Me.Name = "CTGSDetail"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "List registration documents recording vouchers"
        Me.Text = "Danh sách chứng từ đăng ký chứng từ ghi sổ"
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CmdOk As System.Windows.Forms.Button
    Friend WithEvents CmdRemoveAll As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents CmdSelectAll As System.Windows.Forms.Button
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
End Class
