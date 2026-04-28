<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLThueBk2
    Inherits Cyber.From.FilterReport

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
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.LabM_month2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Thang2 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Labma_kh = New System.Windows.Forms.Label()
        Me.txtten_kh = New System.Windows.Forms.TextBox()
        Me.Txtma_kh = New Cyber.SmLists.TxtLookup()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Cc = New System.Windows.Forms.Label()
        Me.TxtTen_Vv = New System.Windows.Forms.TextBox()
        Me.TxtMa_Vv = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtten_tk_du = New System.Windows.Forms.TextBox()
        Me.ChkHoa_don = New System.Windows.Forms.CheckBox()
        Me.TxtMa_Thue = New Cyber.SmLists.TxtLookup()
        Me.txtTen_Thue = New System.Windows.Forms.TextBox()
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Tk = New System.Windows.Forms.TextBox()
        Me.TxtTk_Du = New Cyber.SmLists.TxtLookup()
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Vv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Thue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk_Du.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(731, 324)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 14
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(129, 269)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(733, 25)
        Me.CBBMa_Dvcs.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(1, 272)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Size = New System.Drawing.Size(120, 26)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(592, 324)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 13
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(1, 245)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLoai_NT.Size = New System.Drawing.Size(120, 22)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(129, 245)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 10
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(289, 245)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 11
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(1, 16)
        Me.LabM_month1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(65, 17)
        Me.LabM_month1.TabIndex = 13
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Từ tháng"
        '
        'LabM_month2
        '
        Me.LabM_month2.AutoSize = True
        Me.LabM_month2.Location = New System.Drawing.Point(348, 16)
        Me.LabM_month2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month2.Name = "LabM_month2"
        Me.LabM_month2.Size = New System.Drawing.Size(73, 17)
        Me.LabM_month2.TabIndex = 14
        Me.LabM_month2.Tag = "Month to"
        Me.LabM_month2.Text = "Đến tháng"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 301)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(860, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(129, 10)
        Me.CbbM_Thang1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(153, 25)
        Me.CbbM_Thang1.TabIndex = 0
        '
        'CbbM_Thang2
        '
        Me.CbbM_Thang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang2.FormattingEnabled = True
        Me.CbbM_Thang2.Location = New System.Drawing.Point(433, 12)
        Me.CbbM_Thang2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang2.Name = "CbbM_Thang2"
        Me.CbbM_Thang2.Size = New System.Drawing.Size(153, 25)
        Me.CbbM_Thang2.TabIndex = 1
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(709, 10)
        Me.CbbM_Nam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(153, 25)
        Me.CbbM_Nam.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(627, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'Labma_kh
        '
        Me.Labma_kh.Location = New System.Drawing.Point(1, 132)
        Me.Labma_kh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labma_kh.Name = "Labma_kh"
        Me.Labma_kh.Size = New System.Drawing.Size(123, 25)
        Me.Labma_kh.TabIndex = 209
        Me.Labma_kh.Tag = "Customer"
        Me.Labma_kh.Text = "Mã  đối tượng"
        '
        'txtten_kh
        '
        Me.txtten_kh.BackColor = System.Drawing.SystemColors.Control
        Me.txtten_kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_kh.Enabled = False
        Me.txtten_kh.ForeColor = System.Drawing.Color.Navy
        Me.txtten_kh.Location = New System.Drawing.Point(287, 139)
        Me.txtten_kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtten_kh.Name = "txtten_kh"
        Me.txtten_kh.ReadOnly = True
        Me.txtten_kh.Size = New System.Drawing.Size(577, 17)
        Me.txtten_kh.TabIndex = 208
        Me.txtten_kh.TabStop = False
        '
        'Txtma_kh
        '
        Me.Txtma_kh._ActilookupPopup = False
        Me.Txtma_kh.CyberActilookupPopup = True
        Me.Txtma_kh.Dv_ListDetail = Nothing
        Me.Txtma_kh.Dv_Master = Nothing
        Me.Txtma_kh.FilterClient = ""
        Me.Txtma_kh.FilterSQL = ""
        Me.Txtma_kh.Location = New System.Drawing.Point(129, 131)
        Me.Txtma_kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtma_kh.Name = "Txtma_kh"
        Me.Txtma_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_kh.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_kh.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.Txtma_kh.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.Txtma_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_kh.Size = New System.Drawing.Size(155, 22)
        Me.Txtma_kh.TabIndex = 6
        Me.Txtma_kh.Table_Name = ""
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(1, 163)
        Me.LabMa_kho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(123, 17)
        Me.LabMa_kho.TabIndex = 212
        Me.LabMa_kho.Tag = "Warehouse"
        Me.LabMa_kho.Text = "Mã kho"
        '
        'TxtTen_kho
        '
        Me.TxtTen_kho.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kho.Enabled = False
        Me.TxtTen_kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kho.Location = New System.Drawing.Point(287, 167)
        Me.TxtTen_kho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(577, 17)
        Me.TxtTen_kho.TabIndex = 211
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
        Me.TxtMa_kho.Location = New System.Drawing.Point(129, 160)
        Me.TxtMa_kho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_kho.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_kho.TabIndex = 7
        Me.TxtMa_kho.Table_Name = ""
        '
        'LabMa_Cc
        '
        Me.LabMa_Cc.Location = New System.Drawing.Point(1, 190)
        Me.LabMa_Cc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Cc.Name = "LabMa_Cc"
        Me.LabMa_Cc.Size = New System.Drawing.Size(123, 17)
        Me.LabMa_Cc.TabIndex = 215
        Me.LabMa_Cc.Tag = "Case"
        Me.LabMa_Cc.Text = "Mã vụ việc"
        '
        'TxtTen_Vv
        '
        Me.TxtTen_Vv.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Vv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Vv.Enabled = False
        Me.TxtTen_Vv.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Vv.Location = New System.Drawing.Point(287, 196)
        Me.TxtTen_Vv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Vv.Name = "TxtTen_Vv"
        Me.TxtTen_Vv.ReadOnly = True
        Me.TxtTen_Vv.Size = New System.Drawing.Size(577, 17)
        Me.TxtTen_Vv.TabIndex = 214
        Me.TxtTen_Vv.TabStop = False
        '
        'TxtMa_Vv
        '
        Me.TxtMa_Vv._ActilookupPopup = False
        Me.TxtMa_Vv.CyberActilookupPopup = True
        Me.TxtMa_Vv.Dv_ListDetail = Nothing
        Me.TxtMa_Vv.Dv_Master = Nothing
        Me.TxtMa_Vv.FilterClient = ""
        Me.TxtMa_Vv.FilterSQL = ""
        Me.TxtMa_Vv.Location = New System.Drawing.Point(129, 188)
        Me.TxtMa_Vv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Vv.Name = "TxtMa_Vv"
        Me.TxtMa_Vv.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vv.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vv.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Vv.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Vv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vv.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_Vv.TabIndex = 8
        Me.TxtMa_Vv.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1, 46)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 17)
        Me.Label3.TabIndex = 216
        Me.Label3.Tag = "Tax rate"
        Me.Label3.Text = "Thuế suất"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(1, 76)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 216
        Me.Label5.Tag = "Tax Account"
        Me.Label5.Text = "Tài khoản thuế"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(1, 105)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 17)
        Me.Label6.TabIndex = 216
        Me.Label6.Tag = "Corresponding acc"
        Me.Label6.Text = "Tài khoản đối ứng"
        '
        'txtten_tk_du
        '
        Me.txtten_tk_du.BackColor = System.Drawing.SystemColors.Control
        Me.txtten_tk_du.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtten_tk_du.Enabled = False
        Me.txtten_tk_du.ForeColor = System.Drawing.Color.Navy
        Me.txtten_tk_du.Location = New System.Drawing.Point(287, 110)
        Me.txtten_tk_du.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtten_tk_du.Name = "txtten_tk_du"
        Me.txtten_tk_du.ReadOnly = True
        Me.txtten_tk_du.Size = New System.Drawing.Size(577, 17)
        Me.txtten_tk_du.TabIndex = 219
        Me.txtten_tk_du.TabStop = False
        '
        'ChkHoa_don
        '
        Me.ChkHoa_don.AutoSize = True
        Me.ChkHoa_don.Location = New System.Drawing.Point(129, 214)
        Me.ChkHoa_don.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkHoa_don.Name = "ChkHoa_don"
        Me.ChkHoa_don.Size = New System.Drawing.Size(499, 21)
        Me.ChkHoa_don.TabIndex = 9
        Me.ChkHoa_don.Tag = "Bill style (In season bill - Remove update VAT tax bill)"
        Me.ChkHoa_don.Text = "Dạng hóa đơn (HĐ trong kỳ - Loại bỏ HĐ điều chỉnh tăng (giảm) thuế GTGT)"
        Me.ChkHoa_don.UseVisualStyleBackColor = True
        '
        'TxtMa_Thue
        '
        Me.TxtMa_Thue._ActilookupPopup = False
        Me.TxtMa_Thue.CyberActilookupPopup = True
        Me.TxtMa_Thue.Dv_ListDetail = Nothing
        Me.TxtMa_Thue.Dv_Master = Nothing
        Me.TxtMa_Thue.FilterClient = ""
        Me.TxtMa_Thue.FilterSQL = ""
        Me.TxtMa_Thue.Location = New System.Drawing.Point(129, 43)
        Me.TxtMa_Thue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Thue.Name = "TxtMa_Thue"
        Me.TxtMa_Thue.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Thue.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Thue.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Thue.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Thue.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Thue.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_Thue.TabIndex = 3
        Me.TxtMa_Thue.Table_Name = ""
        '
        'txtTen_Thue
        '
        Me.txtTen_Thue.BackColor = System.Drawing.SystemColors.Control
        Me.txtTen_Thue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_Thue.Enabled = False
        Me.txtTen_Thue.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Thue.Location = New System.Drawing.Point(287, 44)
        Me.txtTen_Thue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTen_Thue.Name = "txtTen_Thue"
        Me.txtTen_Thue.ReadOnly = True
        Me.txtTen_Thue.Size = New System.Drawing.Size(577, 17)
        Me.txtTen_Thue.TabIndex = 221
        Me.txtTen_Thue.TabStop = False
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(129, 72)
        Me.TxtTk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtTk.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(155, 22)
        Me.TxtTk.TabIndex = 4
        Me.TxtTk.Table_Name = ""
        '
        'TxtTen_Tk
        '
        Me.TxtTen_Tk.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Tk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Tk.Enabled = False
        Me.TxtTen_Tk.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk.Location = New System.Drawing.Point(292, 76)
        Me.TxtTen_Tk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Tk.Name = "TxtTen_Tk"
        Me.TxtTen_Tk.ReadOnly = True
        Me.TxtTen_Tk.Size = New System.Drawing.Size(577, 17)
        Me.TxtTen_Tk.TabIndex = 223
        Me.TxtTen_Tk.TabStop = False
        '
        'TxtTk_Du
        '
        Me.TxtTk_Du._ActilookupPopup = False
        Me.TxtTk_Du.CyberActilookupPopup = True
        Me.TxtTk_Du.Dv_ListDetail = Nothing
        Me.TxtTk_Du.Dv_Master = Nothing
        Me.TxtTk_Du.FilterClient = ""
        Me.TxtTk_Du.FilterSQL = ""
        Me.TxtTk_Du.Location = New System.Drawing.Point(129, 101)
        Me.TxtTk_Du.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTk_Du.Name = "TxtTk_Du"
        Me.TxtTk_Du.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_Du.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk_Du.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtTk_Du.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtTk_Du.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk_Du.Size = New System.Drawing.Size(155, 22)
        Me.TxtTk_Du.TabIndex = 5
        Me.TxtTk_Du.Table_Name = ""
        '
        'GLThueBk2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(869, 394)
        Me.Controls.Add(Me.TxtTk_Du)
        Me.Controls.Add(Me.TxtTen_Tk)
        Me.Controls.Add(Me.TxtTk)
        Me.Controls.Add(Me.txtTen_Thue)
        Me.Controls.Add(Me.TxtMa_Thue)
        Me.Controls.Add(Me.ChkHoa_don)
        Me.Controls.Add(Me.txtten_tk_du)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabMa_Cc)
        Me.Controls.Add(Me.TxtTen_Vv)
        Me.Controls.Add(Me.TxtMa_Vv)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.Labma_kh)
        Me.Controls.Add(Me.txtten_kh)
        Me.Controls.Add(Me.Txtma_kh)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_month2)
        Me.Controls.Add(Me.LabM_month1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "GLThueBk2"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.LabM_month2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.Txtma_kh, 0)
        Me.Controls.SetChildIndex(Me.txtten_kh, 0)
        Me.Controls.SetChildIndex(Me.Labma_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vv, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vv, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.txtten_tk_du, 0)
        Me.Controls.SetChildIndex(Me.ChkHoa_don, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Thue, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Thue, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_Du, 0)
        CType(Me.Txtma_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Vv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Thue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk_Du.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents LabM_month2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Thang2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Labma_kh As System.Windows.Forms.Label
    Friend WithEvents txtten_kh As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Cc As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Vv As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Vv As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtten_tk_du As System.Windows.Forms.TextBox
    Friend WithEvents ChkHoa_don As System.Windows.Forms.CheckBox
    Friend WithEvents TxtMa_Thue As Cyber.SmLists.TxtLookup
    Friend WithEvents txtTen_Thue As System.Windows.Forms.TextBox
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Tk As System.Windows.Forms.TextBox
    Friend WithEvents TxtTk_Du As Cyber.SmLists.TxtLookup

End Class
