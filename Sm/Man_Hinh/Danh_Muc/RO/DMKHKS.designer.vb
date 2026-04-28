<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMKHKS
    Inherits Cyber.From.FrmList

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
        Me.LabMa_Ts = New System.Windows.Forms.Label()
        Me.TxtGhi_chu = New System.Windows.Forms.TextBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.DetailXe = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRVXe = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Labso_luong = New System.Windows.Forms.Label()
        Me.TxtTL_MG = New ClsTextBox.txtSo_luong()
        Me.Txtten_kh = New System.Windows.Forms.TextBox()
        Me.Labma_loai = New System.Windows.Forms.Label()
        Me.Txtma_kh = New Cyber.SmLists.TxtLookup()
        Me.TxtPT_CK = New ClsTextBox.txtSo_luong()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNgay_HL1 = New ClsTextBox.txtDate1()
        Me.LabNgay_hl = New System.Windows.Forms.Label()
        Me.TxtNgay_HL2 = New ClsTextBox.txtDate1()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TabPage4.SuspendLayout()
        CType(Me.DetailXe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRVXe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1065, 612)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtExit.TabIndex = 9
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(913, 612)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtOK.TabIndex = 8
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(753, 676)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMa_Dvcs.TabIndex = 21
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(394, 623)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkActi.TabIndex = 7
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 591)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1213, 15)
        Me.GroupBoxLine.TabIndex = 22
        '
        'LabMa_Ts
        '
        Me.LabMa_Ts.AutoSize = True
        Me.LabMa_Ts.Location = New System.Drawing.Point(16, 110)
        Me.LabMa_Ts.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Ts.Name = "LabMa_Ts"
        Me.LabMa_Ts.Size = New System.Drawing.Size(65, 21)
        Me.LabMa_Ts.TabIndex = 10
        Me.LabMa_Ts.Tag = "code"
        Me.LabMa_Ts.Text = "Ghi chú"
        '
        'TxtGhi_chu
        '
        Me.TxtGhi_chu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGhi_chu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGhi_chu.ForeColor = System.Drawing.Color.Navy
        Me.TxtGhi_chu.Location = New System.Drawing.Point(165, 107)
        Me.TxtGhi_chu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtGhi_chu.Name = "TxtGhi_chu"
        Me.TxtGhi_chu.Size = New System.Drawing.Size(1029, 27)
        Me.TxtGhi_chu.TabIndex = 5
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.DetailXe)
        Me.TabPage4.Location = New System.Drawing.Point(4, 30)
        Me.TabPage4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(1176, 390)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Tag = "Accessories attached"
        Me.TabPage4.Text = "Chi tiết xe"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'DetailXe
        '
        Me.DetailXe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.DetailXe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DetailXe.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DetailXe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailXe.Location = New System.Drawing.Point(0, 0)
        Me.DetailXe.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.DetailXe.MainView = Me.DetailGRVXe
        Me.DetailXe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DetailXe.Name = "DetailXe"
        Me.DetailXe.Size = New System.Drawing.Size(1176, 390)
        Me.DetailXe.TabIndex = 0
        Me.DetailXe.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRVXe, Me.GridView1})
        '
        'DetailGRVXe
        '
        Me.DetailGRVXe.Appearance.FocusedCell.BorderColor = System.Drawing.Color.Black
        Me.DetailGRVXe.Appearance.FocusedCell.Options.UseBorderColor = True
        Me.DetailGRVXe.Appearance.FocusedRow.BackColor = System.Drawing.SystemColors.ControlLight
        Me.DetailGRVXe.Appearance.FocusedRow.BorderColor = System.Drawing.Color.Black
        Me.DetailGRVXe.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRVXe.Appearance.FocusedRow.Options.UseBorderColor = True
        Me.DetailGRVXe.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRVXe.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRVXe.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRVXe.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.DetailGRVXe.Appearance.ViewCaption.TextOptions.HotkeyPrefix = DevExpress.Utils.HKeyPrefix.Hide
        Me.DetailGRVXe.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRVXe.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRVXe.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRVXe.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRVXe.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRVXe.GridControl = Me.DetailXe
        Me.DetailGRVXe.GroupRowHeight = 30
        Me.DetailGRVXe.Name = "DetailGRVXe"
        Me.DetailGRVXe.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRVXe.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRVXe.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRVXe.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRVXe.OptionsView.ColumnAutoWidth = False
        Me.DetailGRVXe.OptionsView.ShowGroupPanel = False
        Me.DetailGRVXe.OptionsView.ShowViewCaption = True
        Me.DetailGRVXe.RowHeight = 21
        Me.DetailGRVXe.ViewCaption = "F4: Thêm dòng - F8: Xóa dòng - Ctr + Tab: Rời nhập chi tiết"
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.DetailXe
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
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Location = New System.Drawing.Point(16, 162)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1184, 424)
        Me.TabControl1.TabIndex = 6
        '
        'Labso_luong
        '
        Me.Labso_luong.AutoSize = True
        Me.Labso_luong.Location = New System.Drawing.Point(14, 75)
        Me.Labso_luong.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labso_luong.Name = "Labso_luong"
        Me.Labso_luong.Size = New System.Drawing.Size(75, 21)
        Me.Labso_luong.TabIndex = 50
        Me.Labso_luong.Tag = "Quantity"
        Me.Labso_luong.Text = "Tỷ lệ MG"
        '
        'TxtTL_MG
        '
        Me.TxtTL_MG.AllowNegative = True
        Me.TxtTL_MG.Flags = 7680
        Me.TxtTL_MG.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTL_MG.ForeColor = System.Drawing.Color.Navy
        Me.TxtTL_MG.InputMask = "### ### ### ###"
        Me.TxtTL_MG.Location = New System.Drawing.Point(165, 72)
        Me.TxtTL_MG.MaxWholeDigits = 11
        Me.TxtTL_MG.Name = "TxtTL_MG"
        Me.TxtTL_MG.RangeMax = 1.7976931348623157E+308R
        Me.TxtTL_MG.RangeMin = -1.7976931348623157E+308R
        Me.TxtTL_MG.Size = New System.Drawing.Size(222, 27)
        Me.TxtTL_MG.TabIndex = 3
        Me.TxtTL_MG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Txtten_kh
        '
        Me.Txtten_kh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtten_kh.BackColor = System.Drawing.Color.White
        Me.Txtten_kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_kh.Enabled = False
        Me.Txtten_kh.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_kh.Location = New System.Drawing.Point(392, 41)
        Me.Txtten_kh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtten_kh.Name = "Txtten_kh"
        Me.Txtten_kh.ReadOnly = True
        Me.Txtten_kh.Size = New System.Drawing.Size(800, 20)
        Me.Txtten_kh.TabIndex = 38
        Me.Txtten_kh.TabStop = False
        '
        'Labma_loai
        '
        Me.Labma_loai.AutoSize = True
        Me.Labma_loai.Location = New System.Drawing.Point(14, 41)
        Me.Labma_loai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labma_loai.Name = "Labma_loai"
        Me.Labma_loai.Size = New System.Drawing.Size(96, 21)
        Me.Labma_loai.TabIndex = 39
        Me.Labma_loai.Tag = "Asset Type"
        Me.Labma_loai.Text = "Khách hàng"
        '
        'Txtma_kh
        '
        Me.Txtma_kh._ActilookupPopup = False
        Me.Txtma_kh.CyberActilookupPopup = True
        Me.Txtma_kh.Dv_ListDetail = Nothing
        Me.Txtma_kh.Dv_Master = Nothing
        Me.Txtma_kh.FilterClient = ""
        Me.Txtma_kh.FilterSQL = ""
        Me.Txtma_kh.Location = New System.Drawing.Point(165, 38)
        Me.Txtma_kh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Txtma_kh.Name = "Txtma_kh"
        Me.Txtma_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_kh.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_kh.Size = New System.Drawing.Size(224, 26)
        Me.Txtma_kh.TabIndex = 2
        Me.Txtma_kh.Table_Name = ""
        '
        'TxtPT_CK
        '
        Me.TxtPT_CK.AllowNegative = True
        Me.TxtPT_CK.Flags = 7680
        Me.TxtPT_CK.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_CK.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_CK.InputMask = "### ### ### ###"
        Me.TxtPT_CK.Location = New System.Drawing.Point(504, 72)
        Me.TxtPT_CK.MaxWholeDigits = 11
        Me.TxtPT_CK.Name = "TxtPT_CK"
        Me.TxtPT_CK.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_CK.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_CK.Size = New System.Drawing.Size(222, 27)
        Me.TxtPT_CK.TabIndex = 4
        Me.TxtPT_CK.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(405, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 21)
        Me.Label1.TabIndex = 52
        Me.Label1.Tag = "Quantity"
        Me.Label1.Text = "Tỷ lệ GG"
        '
        'TxtNgay_HL1
        '
        Me.TxtNgay_HL1.Flags = 65536
        Me.TxtNgay_HL1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL1.IsAllowResize = False
        Me.TxtNgay_HL1.isEmpty = True
        Me.TxtNgay_HL1.Location = New System.Drawing.Point(165, 6)
        Me.TxtNgay_HL1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_HL1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL1.MaxLength = 10
        Me.TxtNgay_HL1.Name = "TxtNgay_HL1"
        Me.TxtNgay_HL1.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL1.ShowDayBeforeMonth = False
        Me.TxtNgay_HL1.Size = New System.Drawing.Size(222, 27)
        Me.TxtNgay_HL1.TabIndex = 0
        Me.TxtNgay_HL1.Text = "07/09/2011"
        Me.TxtNgay_HL1.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'LabNgay_hl
        '
        Me.LabNgay_hl.AutoSize = True
        Me.LabNgay_hl.Location = New System.Drawing.Point(16, 9)
        Me.LabNgay_hl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNgay_hl.Name = "LabNgay_hl"
        Me.LabNgay_hl.Size = New System.Drawing.Size(131, 21)
        Me.LabNgay_hl.TabIndex = 54
        Me.LabNgay_hl.Tag = "Date"
        Me.LabNgay_hl.Text = "Hiệu lực từ ngày"
        '
        'TxtNgay_HL2
        '
        Me.TxtNgay_HL2.Flags = 65536
        Me.TxtNgay_HL2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL2.IsAllowResize = False
        Me.TxtNgay_HL2.isEmpty = True
        Me.TxtNgay_HL2.Location = New System.Drawing.Point(504, 6)
        Me.TxtNgay_HL2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_HL2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL2.MaxLength = 10
        Me.TxtNgay_HL2.Name = "TxtNgay_HL2"
        Me.TxtNgay_HL2.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL2.ShowDayBeforeMonth = False
        Me.TxtNgay_HL2.Size = New System.Drawing.Size(222, 27)
        Me.TxtNgay_HL2.TabIndex = 1
        Me.TxtNgay_HL2.Text = "07/09/2011"
        Me.TxtNgay_HL2.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(405, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 56
        Me.Label2.Tag = "Date"
        Me.Label2.Text = "Đến ngày"
        '
        'DMKHKS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1219, 665)
        Me.Controls.Add(Me.TxtNgay_HL2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNgay_HL1)
        Me.Controls.Add(Me.LabNgay_hl)
        Me.Controls.Add(Me.TxtPT_CK)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.TxtTL_MG)
        Me.Controls.Add(Me.Labso_luong)
        Me.Controls.Add(Me.Labma_loai)
        Me.Controls.Add(Me.Txtten_kh)
        Me.Controls.Add(Me.Txtma_kh)
        Me.Controls.Add(Me.TxtGhi_chu)
        Me.Controls.Add(Me.LabMa_Ts)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(722, 258)
        Me.Name = "DMKHKS"
        Me.Text = "Danh mục tài sản"
        Me.Controls.SetChildIndex(Me.LabMa_Ts, 0)
        Me.Controls.SetChildIndex(Me.TxtGhi_chu, 0)
        Me.Controls.SetChildIndex(Me.Txtma_kh, 0)
        Me.Controls.SetChildIndex(Me.Txtten_kh, 0)
        Me.Controls.SetChildIndex(Me.Labma_loai, 0)
        Me.Controls.SetChildIndex(Me.Labso_luong, 0)
        Me.Controls.SetChildIndex(Me.TxtTL_MG, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_CK, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_hl, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL2, 0)
        Me.TabPage4.ResumeLayout(False)
        CType(Me.DetailXe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRVXe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Ts As System.Windows.Forms.Label
    Friend WithEvents TxtGhi_chu As System.Windows.Forms.TextBox
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents DetailXe As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRVXe As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView3 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridView4 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Labso_luong As System.Windows.Forms.Label
    Friend WithEvents TxtTL_MG As ClsTextBox.txtSo_luong
    Friend WithEvents Txtten_kh As System.Windows.Forms.TextBox
    Friend WithEvents Labma_loai As System.Windows.Forms.Label
    Friend WithEvents Txtma_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtPT_CK As ClsTextBox.txtSo_luong
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_HL1 As ClsTextBox.txtDate1
    Friend WithEvents LabNgay_hl As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_HL2 As ClsTextBox.txtDate1
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
