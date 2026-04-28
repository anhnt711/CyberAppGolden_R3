<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTiendo_Xem_KH
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
        Me.GridView6 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView5 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView3 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView7 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridView8 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbbMa_Loai = New System.Windows.Forms.ComboBox()
        Me.CmbbXuatExcelx = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbMa_Loai_SC = New System.Windows.Forms.ComboBox()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 414)
        Me.GroupBoxLine.Size = New System.Drawing.Size(839, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(636, 4)
        Me.ButtOK.Size = New System.Drawing.Size(102, 29)
        Me.ButtOK.TabIndex = 3
        Me.ButtOK.Text = "&Tìm kiếm"
        '
        'ButtExit
        '
        Me.ButtExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(740, 4)
        Me.ButtExit.Size = New System.Drawing.Size(100, 29)
        Me.ButtExit.TabIndex = 4
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
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(1, 76)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.Size = New System.Drawing.Size(840, 381)
        Me.Master.TabIndex = 403
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
        Me.MasterGRV.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus
        Me.MasterGRV.GridControl = Me.Master
        Me.MasterGRV.GroupRowHeight = 30
        Me.MasterGRV.Name = "MasterGRV"
        Me.MasterGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.MasterGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV.OptionsView.ShowAutoFilterRow = True
        Me.MasterGRV.OptionsView.ShowGroupPanel = False
        Me.MasterGRV.RowHeight = 21
        '
        'Label33
        '
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Navy
        Me.Label33.Location = New System.Drawing.Point(4, 6)
        Me.Label33.Margin = New System.Windows.Forms.Padding(0)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(67, 18)
        Me.Label33.TabIndex = 405
        Me.Label33.Tag = "Acce date"
        Me.Label33.Text = "Từ ngày"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 18)
        Me.Label1.TabIndex = 407
        Me.Label1.Tag = "Acce date"
        Me.Label1.Text = "Đến ngày"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMa_Xe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(71, 49)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(105, 23)
        Me.TxtMa_Xe.TabIndex = 2
        Me.TxtMa_Xe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 18)
        Me.Label2.TabIndex = 1960
        Me.Label2.Tag = "Acce date"
        Me.Label2.Text = "Biển số"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(184, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 1962
        Me.Label7.Tag = "Account Level"
        Me.Label7.Text = "Loại báo cáo"
        '
        'CbbMa_Loai
        '
        Me.CbbMa_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Loai.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Loai.FormattingEnabled = True
        Me.CbbMa_Loai.Location = New System.Drawing.Point(261, 27)
        Me.CbbMa_Loai.Name = "CbbMa_Loai"
        Me.CbbMa_Loai.Size = New System.Drawing.Size(168, 21)
        Me.CbbMa_Loai.TabIndex = 4
        '
        'CmbbXuatExcelx
        '
        Me.CmbbXuatExcelx.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbbXuatExcelx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.CmbbXuatExcelx.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.CmbbXuatExcelx.Location = New System.Drawing.Point(745, 459)
        Me.CmbbXuatExcelx.Name = "CmbbXuatExcelx"
        Me.CmbbXuatExcelx.Size = New System.Drawing.Size(96, 22)
        Me.CmbbXuatExcelx.TabIndex = 1964
        Me.CmbbXuatExcelx.Tag = "&ExportExcel"
        Me.CmbbXuatExcelx.Text = "To Excel (xlsx)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 1966
        Me.Label3.Tag = "Account Level"
        Me.Label3.Text = "Loại sửa chữa"
        '
        'CbbMa_Loai_SC
        '
        Me.CbbMa_Loai_SC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Loai_SC.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Loai_SC.FormattingEnabled = True
        Me.CbbMa_Loai_SC.Location = New System.Drawing.Point(261, 5)
        Me.CbbMa_Loai_SC.Name = "CbbMa_Loai_SC"
        Me.CbbMa_Loai_SC.Size = New System.Drawing.Size(168, 21)
        Me.CbbMa_Loai_SC.TabIndex = 3
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(71, 27)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(105, 20)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(71, 5)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(105, 20)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'FrmCVDV_Xem_KH_SCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(843, 482)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbbMa_Loai_SC)
        Me.Controls.Add(Me.CmbbXuatExcelx)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CbbMa_Loai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Master)
        Me.Name = "FrmCVDV_Xem_KH_SCC"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.Label33, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Loai, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.CmbbXuatExcelx, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Loai_SC, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        CType(Me.GridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_Loai As System.Windows.Forms.ComboBox
    Friend WithEvents CmbbXuatExcelx As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_Loai_SC As System.Windows.Forms.ComboBox
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1

End Class
