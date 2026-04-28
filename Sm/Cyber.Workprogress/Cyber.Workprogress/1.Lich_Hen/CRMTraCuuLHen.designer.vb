<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRMTraCuuLHen
    Inherits Cyber.From.FrmCalculator

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView9 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.GridView10 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.CbbLoc = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNgay_CT1 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CbbMa_TTCP_Nhan = New System.Windows.Forms.ComboBox()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 350)
        Me.GroupBoxLine.Size = New System.Drawing.Size(888, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(684, 364)
        Me.ButtOK.Text = "&Chấp nhận"
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(790, 364)
        '
        'GridView6
        '
        Me.GridView6.Name = "GridView6"
        '
        'GridView5
        '
        Me.GridView5.Name = "GridView5"
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
        'GridView7
        '
        Me.GridView7.Name = "GridView7"
        '
        'GridView8
        '
        Me.GridView8.Name = "GridView8"
        '
        'GridView9
        '
        Me.GridView9.Name = "GridView9"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Master)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(880, 277)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Thống kê lịch hẹn"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(6, 6)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master.Size = New System.Drawing.Size(868, 311)
        Me.Master.TabIndex = 404
        Me.Master.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterGRV, Me.GridView10})
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
        Me.MasterGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
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
        'GridView10
        '
        Me.GridView10.GridControl = Me.Master
        Me.GridView10.Name = "GridView10"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(2, 41)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(888, 303)
        Me.TabControl1.TabIndex = 404
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(12, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 1849
        Me.Label7.Tag = "License plate"
        Me.Label7.Text = "Biển số"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.Location = New System.Drawing.Point(75, 11)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Xe.TabIndex = 1848
        '
        'CbbLoc
        '
        Me.CbbLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbLoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbLoc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CbbLoc.Location = New System.Drawing.Point(797, 10)
        Me.CbbLoc.Name = "CbbLoc"
        Me.CbbLoc.Size = New System.Drawing.Size(89, 29)
        Me.CbbLoc.TabIndex = 2215
        Me.CbbLoc.TabStop = False
        Me.CbbLoc.Tag = "&Complain"
        Me.CbbLoc.Text = "&Lọc"
        Me.CbbLoc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(202, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 20)
        Me.Label1.TabIndex = 7362
        Me.Label1.Tag = "Create date"
        Me.Label1.Text = "Ngày"
        '
        'TxtNgay_CT1
        '
        Me.TxtNgay_CT1.BackColor = System.Drawing.SystemColors.Info
        Me.TxtNgay_CT1.Flags = 0
        Me.TxtNgay_CT1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_CT1.ForeColor = System.Drawing.Color.Blue
        Me.TxtNgay_CT1.IsAllowResize = False
        Me.TxtNgay_CT1.Location = New System.Drawing.Point(246, 10)
        Me.TxtNgay_CT1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_CT1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_CT1.MaxLength = 10
        Me.TxtNgay_CT1.Name = "TxtNgay_CT1"
        Me.TxtNgay_CT1.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_CT1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CT1.ReadOnly = True
        Me.TxtNgay_CT1.ShowDayBeforeMonth = False
        Me.TxtNgay_CT1.Size = New System.Drawing.Size(118, 21)
        Me.TxtNgay_CT1.TabIndex = 7361
        Me.TxtNgay_CT1.Value = "06/08/2025"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(379, 16)
        Me.Label21.Margin = New System.Windows.Forms.Padding(0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(67, 15)
        Me.Label21.TabIndex = 7390
        Me.Label21.Tag = "Team"
        Me.Label21.Text = "TTCP SX"
        '
        'CbbMa_TTCP_Nhan
        '
        Me.CbbMa_TTCP_Nhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TTCP_Nhan.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_TTCP_Nhan.ForeColor = System.Drawing.Color.Blue
        Me.CbbMa_TTCP_Nhan.FormattingEnabled = True
        Me.CbbMa_TTCP_Nhan.Location = New System.Drawing.Point(450, 11)
        Me.CbbMa_TTCP_Nhan.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_TTCP_Nhan.Name = "CbbMa_TTCP_Nhan"
        Me.CbbMa_TTCP_Nhan.Size = New System.Drawing.Size(193, 21)
        Me.CbbMa_TTCP_Nhan.TabIndex = 7389
        '
        'CRMTraCuuLHen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(892, 418)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.CbbMa_TTCP_Nhan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNgay_CT1)
        Me.Controls.Add(Me.CbbLoc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "CRMTraCuuLHen"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.CbbLoc, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CT1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TTCP_Nhan, 0)
        Me.Controls.SetChildIndex(Me.Label21, 0)
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridView6 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView5 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView7 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView8 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView9 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents GridView10 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents Label7 As Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As Windows.Forms.TextBox
    Friend WithEvents CbbLoc As Windows.Forms.Button
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtNgay_CT1 As ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label21 As Windows.Forms.Label
    Friend WithEvents CbbMa_TTCP_Nhan As Windows.Forms.ComboBox
End Class
