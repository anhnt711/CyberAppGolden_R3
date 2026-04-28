<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InGiaCost
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
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbM_Thang2 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.LabM_month2 = New System.Windows.Forms.Label()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.Chk3 = New System.Windows.Forms.CheckBox()
        Me.Chk2 = New System.Windows.Forms.CheckBox()
        Me.Chk1 = New System.Windows.Forms.CheckBox()
        Me.TxtTen_Nh1 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh3 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh2 = New System.Windows.Forms.TextBox()
        Me.Txtten_VT = New System.Windows.Forms.TextBox()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.TxtTk_Vt = New Cyber.SmLists.TxtLookup()
        Me.TxtMa_vt = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Tk_Vt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNh_VT3 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_VT2 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_VT1 = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh5 = New System.Windows.Forms.TextBox()
        Me.TxtNh_VT5 = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh4 = New System.Windows.Forms.TextBox()
        Me.TxtNh_VT4 = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk_Vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_VT3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_VT2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_VT1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_VT5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_VT4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 364)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(761, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(495, 377)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtOK.TabIndex = 14
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(631, 377)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtExit.TabIndex = 15
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(613, 9)
        Me.CbbM_Nam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Nam.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(571, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 505
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'CbbM_Thang2
        '
        Me.CbbM_Thang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang2.FormattingEnabled = True
        Me.CbbM_Thang2.Location = New System.Drawing.Point(361, 9)
        Me.CbbM_Thang2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang2.Name = "CbbM_Thang2"
        Me.CbbM_Thang2.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Thang2.TabIndex = 1
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(112, 9)
        Me.CbbM_Thang1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Thang1.TabIndex = 0
        '
        'LabM_month2
        '
        Me.LabM_month2.AutoSize = True
        Me.LabM_month2.Location = New System.Drawing.Point(279, 12)
        Me.LabM_month2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month2.Name = "LabM_month2"
        Me.LabM_month2.Size = New System.Drawing.Size(74, 17)
        Me.LabM_month2.TabIndex = 504
        Me.LabM_month2.Tag = "Month to"
        Me.LabM_month2.Text = "Đến tháng"
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(0, 12)
        Me.LabM_month1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(65, 17)
        Me.LabM_month1.TabIndex = 503
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Từ tháng"
        '
        'Chk3
        '
        Me.Chk3.AutoSize = True
        Me.Chk3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Chk3.Location = New System.Drawing.Point(112, 338)
        Me.Chk3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Chk3.Name = "Chk3"
        Me.Chk3.Size = New System.Drawing.Size(308, 22)
        Me.Chk3.TabIndex = 13
        Me.Chk3.Tag = "Calculate cost price by FIFO method"
        Me.Chk3.Text = "Tính giá vốn theo giá nhập trước xuất trước"
        Me.Chk3.UseVisualStyleBackColor = True
        '
        'Chk2
        '
        Me.Chk2.AutoSize = True
        Me.Chk2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Chk2.Location = New System.Drawing.Point(112, 308)
        Me.Chk2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Chk2.Name = "Chk2"
        Me.Chk2.Size = New System.Drawing.Size(244, 22)
        Me.Chk2.TabIndex = 12
        Me.Chk2.Tag = "Daily calculate cost price"
        Me.Chk2.Text = "Tính giá vốn bình quân theo ngày"
        Me.Chk2.UseVisualStyleBackColor = True
        '
        'Chk1
        '
        Me.Chk1.AutoSize = True
        Me.Chk1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Chk1.Location = New System.Drawing.Point(112, 277)
        Me.Chk1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Chk1.Name = "Chk1"
        Me.Chk1.Size = New System.Drawing.Size(176, 22)
        Me.Chk1.TabIndex = 11
        Me.Chk1.Tag = "Calculate cost price"
        Me.Chk1.Text = "Tính giá vốn bình quân"
        Me.Chk1.UseVisualStyleBackColor = True
        '
        'TxtTen_Nh1
        '
        Me.TxtTen_Nh1.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh1.Enabled = False
        Me.TxtTen_Nh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh1.Location = New System.Drawing.Point(264, 129)
        Me.TxtTen_Nh1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh1.Name = "TxtTen_Nh1"
        Me.TxtTen_Nh1.ReadOnly = True
        Me.TxtTen_Nh1.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_Nh1.TabIndex = 523
        Me.TxtTen_Nh1.TabStop = False
        '
        'TxtTen_Nh3
        '
        Me.TxtTen_Nh3.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh3.Enabled = False
        Me.TxtTen_Nh3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh3.Location = New System.Drawing.Point(264, 183)
        Me.TxtTen_Nh3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh3.Name = "TxtTen_Nh3"
        Me.TxtTen_Nh3.ReadOnly = True
        Me.TxtTen_Nh3.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_Nh3.TabIndex = 522
        Me.TxtTen_Nh3.TabStop = False
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh2.Enabled = False
        Me.TxtTen_Nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(264, 156)
        Me.TxtTen_Nh2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.ReadOnly = True
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_Nh2.TabIndex = 521
        Me.TxtTen_Nh2.TabStop = False
        '
        'Txtten_VT
        '
        Me.Txtten_VT.BackColor = System.Drawing.Color.White
        Me.Txtten_VT.Enabled = False
        Me.Txtten_VT.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_VT.Location = New System.Drawing.Point(264, 69)
        Me.Txtten_VT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_VT.Name = "Txtten_VT"
        Me.Txtten_VT.ReadOnly = True
        Me.Txtten_VT.Size = New System.Drawing.Size(495, 22)
        Me.Txtten_VT.TabIndex = 516
        Me.Txtten_VT.TabStop = False
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(0, 43)
        Me.LabMa_kho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(105, 16)
        Me.LabMa_kho.TabIndex = 529
        Me.LabMa_kho.Tag = "Warehouse"
        Me.LabMa_kho.Text = "Mã kho"
        '
        'TxtMa_kho
        '
        Me.TxtMa_kho._ActilookupPopup = False
        Me.TxtMa_kho.CyberActilookupPopup = True
        Me.TxtMa_kho.Dv_ListDetail = Nothing
        Me.TxtMa_kho.Dv_Master = Nothing
        Me.TxtMa_kho.FilterClient = ""
        Me.TxtMa_kho.FilterSQL = ""
        Me.TxtMa_kho.Location = New System.Drawing.Point(112, 41)
        Me.TxtMa_kho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_kho.TabIndex = 3
        Me.TxtMa_kho.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(0, 191)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 528
        Me.Label8.Tag = "Group 3"
        Me.Label8.Text = "Nhóm 3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(0, 162)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 527
        Me.Label13.Tag = "Group 2"
        Me.Label13.Text = "Nhóm 2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(0, 138)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 17)
        Me.Label14.TabIndex = 526
        Me.Label14.Tag = "Group 1"
        Me.Label14.Text = "Nhóm 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(0, 78)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 525
        Me.Label6.Tag = "Suplies"
        Me.Label6.Text = "Mã vật tư"
        '
        'TxtTen_kho
        '
        Me.TxtTen_kho.BackColor = System.Drawing.Color.White
        Me.TxtTen_kho.Enabled = False
        Me.TxtTen_kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kho.Location = New System.Drawing.Point(264, 41)
        Me.TxtTen_kho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_kho.TabIndex = 530
        Me.TxtTen_kho.TabStop = False
        '
        'TxtTk_Vt
        '
        Me.TxtTk_Vt._ActilookupPopup = False
        Me.TxtTk_Vt.CyberActilookupPopup = True
        Me.TxtTk_Vt.Dv_ListDetail = Nothing
        Me.TxtTk_Vt.Dv_Master = Nothing
        Me.TxtTk_Vt.EditValue = ""
        Me.TxtTk_Vt.FilterClient = ""
        Me.TxtTk_Vt.FilterSQL = ""
        Me.TxtTk_Vt.Location = New System.Drawing.Point(112, 98)
        Me.TxtTk_Vt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTk_Vt.Name = "TxtTk_Vt"
        Me.TxtTk_Vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_Vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk_Vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk_Vt.Size = New System.Drawing.Size(147, 22)
        Me.TxtTk_Vt.TabIndex = 5
        Me.TxtTk_Vt.Table_Name = ""
        '
        'TxtMa_vt
        '
        Me.TxtMa_vt._ActilookupPopup = False
        Me.TxtMa_vt.CyberActilookupPopup = True
        Me.TxtMa_vt.Dv_ListDetail = Nothing
        Me.TxtMa_vt.Dv_Master = Nothing
        Me.TxtMa_vt.EditValue = ""
        Me.TxtMa_vt.FilterClient = ""
        Me.TxtMa_vt.FilterSQL = ""
        Me.TxtMa_vt.Location = New System.Drawing.Point(112, 69)
        Me.TxtMa_vt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_vt.Name = "TxtMa_vt"
        Me.TxtMa_vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_vt.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_vt.TabIndex = 4
        Me.TxtMa_vt.Table_Name = ""
        '
        'TxtTen_Tk_Vt
        '
        Me.TxtTen_Tk_Vt.BackColor = System.Drawing.Color.White
        Me.TxtTen_Tk_Vt.Enabled = False
        Me.TxtTen_Tk_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk_Vt.Location = New System.Drawing.Point(264, 98)
        Me.TxtTen_Tk_Vt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Tk_Vt.Name = "TxtTen_Tk_Vt"
        Me.TxtTen_Tk_Vt.ReadOnly = True
        Me.TxtTen_Tk_Vt.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_Tk_Vt.TabIndex = 537
        Me.TxtTen_Tk_Vt.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(-1, 110)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 17)
        Me.Label3.TabIndex = 536
        Me.Label3.Tag = "Account"
        Me.Label3.Text = "Tk vật tư"
        '
        'TxtNh_VT3
        '
        Me.TxtNh_VT3._ActilookupPopup = False
        Me.TxtNh_VT3.CyberActilookupPopup = True
        Me.TxtNh_VT3.Dv_ListDetail = Nothing
        Me.TxtNh_VT3.Dv_Master = Nothing
        Me.TxtNh_VT3.FilterClient = ""
        Me.TxtNh_VT3.FilterSQL = ""
        Me.TxtNh_VT3.Location = New System.Drawing.Point(112, 183)
        Me.TxtNh_VT3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_VT3.Name = "TxtNh_VT3"
        Me.TxtNh_VT3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_VT3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_VT3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_VT3.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_VT3.TabIndex = 8
        Me.TxtNh_VT3.Table_Name = ""
        '
        'TxtNh_VT2
        '
        Me.TxtNh_VT2._ActilookupPopup = False
        Me.TxtNh_VT2.CyberActilookupPopup = True
        Me.TxtNh_VT2.Dv_ListDetail = Nothing
        Me.TxtNh_VT2.Dv_Master = Nothing
        Me.TxtNh_VT2.FilterClient = ""
        Me.TxtNh_VT2.FilterSQL = ""
        Me.TxtNh_VT2.Location = New System.Drawing.Point(112, 156)
        Me.TxtNh_VT2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_VT2.Name = "TxtNh_VT2"
        Me.TxtNh_VT2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_VT2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_VT2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_VT2.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_VT2.TabIndex = 7
        Me.TxtNh_VT2.Table_Name = ""
        '
        'TxtNh_VT1
        '
        Me.TxtNh_VT1._ActilookupPopup = False
        Me.TxtNh_VT1.CyberActilookupPopup = True
        Me.TxtNh_VT1.Dv_ListDetail = Nothing
        Me.TxtNh_VT1.Dv_Master = Nothing
        Me.TxtNh_VT1.FilterClient = ""
        Me.TxtNh_VT1.FilterSQL = ""
        Me.TxtNh_VT1.Location = New System.Drawing.Point(112, 129)
        Me.TxtNh_VT1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_VT1.Name = "TxtNh_VT1"
        Me.TxtNh_VT1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_VT1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_VT1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_VT1.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_VT1.TabIndex = 6
        Me.TxtNh_VT1.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 246)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 16)
        Me.Label4.TabIndex = 543
        Me.Label4.Tag = "Group 5"
        Me.Label4.Text = "Nhóm 5"
        '
        'TxtTen_Nh5
        '
        Me.TxtTen_Nh5.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh5.Enabled = False
        Me.TxtTen_Nh5.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh5.Location = New System.Drawing.Point(264, 241)
        Me.TxtTen_Nh5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh5.Name = "TxtTen_Nh5"
        Me.TxtTen_Nh5.ReadOnly = True
        Me.TxtTen_Nh5.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_Nh5.TabIndex = 542
        Me.TxtTen_Nh5.TabStop = False
        '
        'TxtNh_VT5
        '
        Me.TxtNh_VT5._ActilookupPopup = False
        Me.TxtNh_VT5.CyberActilookupPopup = True
        Me.TxtNh_VT5.Dv_ListDetail = Nothing
        Me.TxtNh_VT5.Dv_Master = Nothing
        Me.TxtNh_VT5.FilterClient = ""
        Me.TxtNh_VT5.FilterSQL = ""
        Me.TxtNh_VT5.Location = New System.Drawing.Point(112, 242)
        Me.TxtNh_VT5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_VT5.Name = "TxtNh_VT5"
        Me.TxtNh_VT5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_VT5.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_VT5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_VT5.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_VT5.TabIndex = 10
        Me.TxtNh_VT5.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 219)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 541
        Me.Label1.Tag = "Group 4"
        Me.Label1.Text = "Nhóm 4"
        '
        'TxtTen_Nh4
        '
        Me.TxtTen_Nh4.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh4.Enabled = False
        Me.TxtTen_Nh4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh4.Location = New System.Drawing.Point(264, 212)
        Me.TxtTen_Nh4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh4.Name = "TxtTen_Nh4"
        Me.TxtTen_Nh4.ReadOnly = True
        Me.TxtTen_Nh4.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_Nh4.TabIndex = 540
        Me.TxtTen_Nh4.TabStop = False
        '
        'TxtNh_VT4
        '
        Me.TxtNh_VT4._ActilookupPopup = False
        Me.TxtNh_VT4.CyberActilookupPopup = True
        Me.TxtNh_VT4.Dv_ListDetail = Nothing
        Me.TxtNh_VT4.Dv_Master = Nothing
        Me.TxtNh_VT4.FilterClient = ""
        Me.TxtNh_VT4.FilterSQL = ""
        Me.TxtNh_VT4.Location = New System.Drawing.Point(112, 212)
        Me.TxtNh_VT4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_VT4.Name = "TxtNh_VT4"
        Me.TxtNh_VT4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_VT4.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_VT4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_VT4.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_VT4.TabIndex = 9
        Me.TxtNh_VT4.Table_Name = ""
        '
        'InGiaCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(767, 443)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Nh5)
        Me.Controls.Add(Me.TxtNh_VT5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Nh4)
        Me.Controls.Add(Me.TxtNh_VT4)
        Me.Controls.Add(Me.TxtNh_VT3)
        Me.Controls.Add(Me.TxtNh_VT2)
        Me.Controls.Add(Me.TxtNh_VT1)
        Me.Controls.Add(Me.Chk3)
        Me.Controls.Add(Me.Chk2)
        Me.Controls.Add(Me.TxtTen_Tk_Vt)
        Me.Controls.Add(Me.Chk1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTk_Vt)
        Me.Controls.Add(Me.TxtMa_vt)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_Nh1)
        Me.Controls.Add(Me.TxtTen_Nh3)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.Txtten_VT)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.LabM_month2)
        Me.Controls.Add(Me.LabM_month1)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "InGiaCost"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.LabM_month2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.Txtten_VT, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh1, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_Vt, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Chk1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk_Vt, 0)
        Me.Controls.SetChildIndex(Me.Chk2, 0)
        Me.Controls.SetChildIndex(Me.Chk3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_VT1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_VT2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_VT3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_VT4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh4, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_VT5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh5, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk_Vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_VT3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_VT2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_VT1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_VT5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_VT4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month2 As System.Windows.Forms.Label
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents Chk3 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk2 As System.Windows.Forms.CheckBox
    Friend WithEvents Chk1 As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTen_Nh1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Nh3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Nh2 As System.Windows.Forms.TextBox
    Friend WithEvents Txtten_VT As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents TxtTk_Vt As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtMa_vt As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Tk_Vt As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNh_VT3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNh_VT2 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNh_VT1 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_VT5 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_VT4 As Cyber.SmLists.TxtLookup

End Class
