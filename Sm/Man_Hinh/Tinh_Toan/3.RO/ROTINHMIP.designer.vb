<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ROTINHMIP
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
        Me.CmbbImportExcel = New System.Windows.Forms.Button()
        Me.Master1 = New DevExpress.XtraGrid.GridControl()
        Me.Master1GRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_vt = New System.Windows.Forms.TextBox()
        Me.TxtMa_vt = New Cyber.SmLists.TxtLookup()
        Me.TxtSo_Ngay_OC = New ClsTextBox.txtTien_NT()
        Me.TxtSo_Ngay_LT = New ClsTextBox.txtTien_NT()
        Me.TxtSo_Ngay_Lam = New ClsTextBox.txtTien_NT()
        Me.CmbbXuatExcel = New System.Windows.Forms.Button()
        Me.CmdLoadData = New System.Windows.Forms.Button()
        Me.CbbM_Thang = New System.Windows.Forms.ComboBox()
        Me.LabM_Thang = New System.Windows.Forms.Label()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSo_Ngay_SL = New ClsTextBox.txtTien_NT()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Master1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Master1GRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 492)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1093, 8)
        Me.GroupBoxLine.TabIndex = 17
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(893, 502)
        Me.ButtOK.TabIndex = 13
        Me.ButtOK.Tag = "&OK"
        Me.ButtOK.Text = "&Lưu dữ liệu"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(995, 502)
        Me.ButtExit.TabIndex = 14
        '
        'CmbbImportExcel
        '
        Me.CmbbImportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbbImportExcel.Location = New System.Drawing.Point(988, 97)
        Me.CmbbImportExcel.Name = "CmbbImportExcel"
        Me.CmbbImportExcel.Size = New System.Drawing.Size(104, 31)
        Me.CmbbImportExcel.TabIndex = 11
        Me.CmbbImportExcel.Tag = "&Import Excel"
        Me.CmbbImportExcel.Text = "&Import Excel"
        Me.CmbbImportExcel.UseVisualStyleBackColor = True
        '
        'Master1
        '
        Me.Master1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master1.Location = New System.Drawing.Point(0, 134)
        Me.Master1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master1.MainView = Me.Master1GRV
        Me.Master1.Name = "Master1"
        Me.Master1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Master1.Size = New System.Drawing.Size(1094, 361)
        Me.Master1.TabIndex = 12
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 514
        Me.Label2.Tag = "Warehouse"
        Me.Label2.Text = "Mã kho"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 515
        Me.Label3.Tag = "Material code"
        Me.Label3.Text = "Mã vật tư"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(177, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 13)
        Me.Label5.TabIndex = 517
        Me.Label5.Tag = "Coefficient O/C"
        Me.Label5.Text = "Chu kỳ đặt hàng O/C"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(377, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 518
        Me.Label6.Tag = "Coefficient L/T"
        Me.Label6.Text = "Thời gian nhận hàng L/T"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 75)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 13)
        Me.Label7.TabIndex = 519
        Me.Label7.Tag = "Number of working days"
        Me.Label7.Text = "Số ngày làm việc"
        '
        'TxtTen_kho
        '
        Me.TxtTen_kho.BackColor = System.Drawing.Color.White
        Me.TxtTen_kho.Enabled = False
        Me.TxtTen_kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kho.Location = New System.Drawing.Point(225, 26)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(591, 20)
        Me.TxtTen_kho.TabIndex = 15
        Me.TxtTen_kho.TabStop = False
        '
        'TxtMa_kho
        '
        Me.TxtMa_kho._ActilookupPopup = False
        Me.TxtMa_kho.CyberActilookupPopup = True
        Me.TxtMa_kho.Dv_ListDetail = Nothing
        Me.TxtMa_kho.Dv_Master = Nothing
        Me.TxtMa_kho.FilterClient = ""
        Me.TxtMa_kho.FilterSQL = ""
        Me.TxtMa_kho.Location = New System.Drawing.Point(96, 26)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(124, 20)
        Me.TxtMa_kho.TabIndex = 1
        Me.TxtMa_kho.Table_Name = ""
        '
        'TxtTen_vt
        '
        Me.TxtTen_vt.BackColor = System.Drawing.Color.White
        Me.TxtTen_vt.Enabled = False
        Me.TxtTen_vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_vt.Location = New System.Drawing.Point(225, 48)
        Me.TxtTen_vt.Name = "TxtTen_vt"
        Me.TxtTen_vt.ReadOnly = True
        Me.TxtTen_vt.Size = New System.Drawing.Size(591, 20)
        Me.TxtTen_vt.TabIndex = 16
        Me.TxtTen_vt.TabStop = False
        '
        'TxtMa_vt
        '
        Me.TxtMa_vt._ActilookupPopup = False
        Me.TxtMa_vt.CyberActilookupPopup = True
        Me.TxtMa_vt.Dv_ListDetail = Nothing
        Me.TxtMa_vt.Dv_Master = Nothing
        Me.TxtMa_vt.FilterClient = ""
        Me.TxtMa_vt.FilterSQL = ""
        Me.TxtMa_vt.Location = New System.Drawing.Point(96, 48)
        Me.TxtMa_vt.Name = "TxtMa_vt"
        Me.TxtMa_vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_vt.Size = New System.Drawing.Size(124, 20)
        Me.TxtMa_vt.TabIndex = 2
        Me.TxtMa_vt.Table_Name = ""
        '
        'TxtSo_Ngay_OC
        '
        Me.TxtSo_Ngay_OC.AllowNegative = True
        Me.TxtSo_Ngay_OC.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ngay_OC.Flags = 7680
        Me.TxtSo_Ngay_OC.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ngay_OC.InputMask = "## ### ### ### ###"
        Me.TxtSo_Ngay_OC.Location = New System.Drawing.Point(292, 71)
        Me.TxtSo_Ngay_OC.MaxWholeDigits = 13
        Me.TxtSo_Ngay_OC.Name = "TxtSo_Ngay_OC"
        Me.TxtSo_Ngay_OC.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Ngay_OC.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Ngay_OC.Size = New System.Drawing.Size(78, 20)
        Me.TxtSo_Ngay_OC.TabIndex = 4
        Me.TxtSo_Ngay_OC.Text = "0"
        Me.TxtSo_Ngay_OC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSo_Ngay_LT
        '
        Me.TxtSo_Ngay_LT.AllowNegative = True
        Me.TxtSo_Ngay_LT.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ngay_LT.Flags = 7680
        Me.TxtSo_Ngay_LT.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ngay_LT.InputMask = "## ### ### ### ###"
        Me.TxtSo_Ngay_LT.Location = New System.Drawing.Point(509, 71)
        Me.TxtSo_Ngay_LT.MaxWholeDigits = 13
        Me.TxtSo_Ngay_LT.Name = "TxtSo_Ngay_LT"
        Me.TxtSo_Ngay_LT.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Ngay_LT.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Ngay_LT.Size = New System.Drawing.Size(78, 20)
        Me.TxtSo_Ngay_LT.TabIndex = 5
        Me.TxtSo_Ngay_LT.Text = "0"
        Me.TxtSo_Ngay_LT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSo_Ngay_Lam
        '
        Me.TxtSo_Ngay_Lam.AllowNegative = True
        Me.TxtSo_Ngay_Lam.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ngay_Lam.Flags = 7680
        Me.TxtSo_Ngay_Lam.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ngay_Lam.InputMask = "## ### ### ### ###"
        Me.TxtSo_Ngay_Lam.Location = New System.Drawing.Point(96, 71)
        Me.TxtSo_Ngay_Lam.MaxWholeDigits = 13
        Me.TxtSo_Ngay_Lam.Name = "TxtSo_Ngay_Lam"
        Me.TxtSo_Ngay_Lam.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Ngay_Lam.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Ngay_Lam.Size = New System.Drawing.Size(78, 20)
        Me.TxtSo_Ngay_Lam.TabIndex = 6
        Me.TxtSo_Ngay_Lam.Text = "0"
        Me.TxtSo_Ngay_Lam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CmbbXuatExcel
        '
        Me.CmbbXuatExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmbbXuatExcel.Location = New System.Drawing.Point(876, 97)
        Me.CmbbXuatExcel.Name = "CmbbXuatExcel"
        Me.CmbbXuatExcel.Size = New System.Drawing.Size(106, 31)
        Me.CmbbXuatExcel.TabIndex = 10
        Me.CmbbXuatExcel.Tag = "&Export Excel"
        Me.CmbbXuatExcel.Text = "&Export Excel"
        Me.CmbbXuatExcel.UseVisualStyleBackColor = True
        '
        'CmdLoadData
        '
        Me.CmdLoadData.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLoadData.Location = New System.Drawing.Point(96, 97)
        Me.CmdLoadData.Name = "CmdLoadData"
        Me.CmdLoadData.Size = New System.Drawing.Size(124, 31)
        Me.CmdLoadData.TabIndex = 7
        Me.CmdLoadData.Tag = "Get data and Count Mip"
        Me.CmdLoadData.Text = "&Tính MIP"
        Me.CmdLoadData.UseVisualStyleBackColor = True
        '
        'CbbM_Thang
        '
        Me.CbbM_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang.FormattingEnabled = True
        Me.CbbM_Thang.Location = New System.Drawing.Point(96, 2)
        Me.CbbM_Thang.Name = "CbbM_Thang"
        Me.CbbM_Thang.Size = New System.Drawing.Size(75, 21)
        Me.CbbM_Thang.TabIndex = 520
        '
        'LabM_Thang
        '
        Me.LabM_Thang.AutoSize = True
        Me.LabM_Thang.Location = New System.Drawing.Point(10, 5)
        Me.LabM_Thang.Name = "LabM_Thang"
        Me.LabM_Thang.Size = New System.Drawing.Size(38, 13)
        Me.LabM_Thang.TabIndex = 521
        Me.LabM_Thang.Tag = "Month"
        Me.LabM_Thang.Text = "Tháng"
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(225, 2)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(95, 21)
        Me.CbbM_Nam.TabIndex = 522
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 13)
        Me.Label1.TabIndex = 523
        Me.Label1.Tag = "Year"
        Me.Label1.Text = "Năm"
        '
        'TxtSo_Ngay_SL
        '
        Me.TxtSo_Ngay_SL.AllowNegative = True
        Me.TxtSo_Ngay_SL.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ngay_SL.Flags = 7680
        Me.TxtSo_Ngay_SL.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ngay_SL.InputMask = "## ### ### ### ###"
        Me.TxtSo_Ngay_SL.Location = New System.Drawing.Point(738, 71)
        Me.TxtSo_Ngay_SL.MaxWholeDigits = 13
        Me.TxtSo_Ngay_SL.Name = "TxtSo_Ngay_SL"
        Me.TxtSo_Ngay_SL.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Ngay_SL.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Ngay_SL.Size = New System.Drawing.Size(78, 20)
        Me.TxtSo_Ngay_SL.TabIndex = 524
        Me.TxtSo_Ngay_SL.Text = "0"
        Me.TxtSo_Ngay_SL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(606, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 525
        Me.Label4.Tag = "Coefficient L/T"
        Me.Label4.Text = "Thời gian dự phòng S/L"
        '
        'ROTINHMIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1097, 556)
        Me.Controls.Add(Me.TxtSo_Ngay_SL)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbbM_Thang)
        Me.Controls.Add(Me.LabM_Thang)
        Me.Controls.Add(Me.CmdLoadData)
        Me.Controls.Add(Me.CmbbXuatExcel)
        Me.Controls.Add(Me.TxtSo_Ngay_Lam)
        Me.Controls.Add(Me.TxtSo_Ngay_LT)
        Me.Controls.Add(Me.TxtSo_Ngay_OC)
        Me.Controls.Add(Me.TxtTen_vt)
        Me.Controls.Add(Me.TxtMa_vt)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Master1)
        Me.Controls.Add(Me.CmbbImportExcel)
        Me.Name = "ROTINHMIP"
        Me.Text = " "
        Me.Controls.SetChildIndex(Me.CmbbImportExcel, 0)
        Me.Controls.SetChildIndex(Me.Master1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ngay_OC, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ngay_LT, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ngay_Lam, 0)
        Me.Controls.SetChildIndex(Me.CmbbXuatExcel, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CmdLoadData, 0)
        Me.Controls.SetChildIndex(Me.LabM_Thang, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ngay_SL, 0)
        CType(Me.Master1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Master1GRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbbImportExcel As System.Windows.Forms.Button
    Friend WithEvents Master1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Master1GRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_vt As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtSo_Ngay_OC As ClsTextBox.txtTien_NT
    Friend WithEvents TxtSo_Ngay_LT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtSo_Ngay_Lam As ClsTextBox.txtTien_NT
    Friend WithEvents CmbbXuatExcel As System.Windows.Forms.Button
    Friend WithEvents CmdLoadData As System.Windows.Forms.Button
    Friend WithEvents CbbM_Thang As Windows.Forms.ComboBox
    Friend WithEvents LabM_Thang As Windows.Forms.Label
    Friend WithEvents CbbM_Nam As Windows.Forms.ComboBox
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtSo_Ngay_SL As ClsTextBox.txtTien_NT
    Friend WithEvents Label4 As Windows.Forms.Label
End Class
