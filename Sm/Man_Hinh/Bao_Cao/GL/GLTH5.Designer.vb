<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLTH5
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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabM_Tk = New System.Windows.Forms.Label()
        Me.TxtM_Tk = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Tk = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nhom1 = New System.Windows.Forms.TextBox()
        Me.TxtNhom1 = New Cyber.SmLists.TxtLookup()
        Me.LabNhom1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Nhom2 = New System.Windows.Forms.TextBox()
        Me.TxtNhom2 = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Nhom3 = New System.Windows.Forms.TextBox()
        Me.TxtNhom3 = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Nhom4 = New System.Windows.Forms.TextBox()
        Me.TxtNhom4 = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_Nhom5 = New System.Windows.Forms.TextBox()
        Me.TxtNhom5 = New Cyber.SmLists.TxtLookup()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbbPhat_Sinh = New System.Windows.Forms.ComboBox()
        CType(Me.TxtM_Tk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNhom1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNhom2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNhom3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNhom4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNhom5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(656, 358)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 13
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 307)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(653, 25)
        Me.CBBMa_Dvcs.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 311)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(517, 358)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 12
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 279)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 279)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 9
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(281, 280)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 10
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(127, 7)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(127, 39)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(13, 10)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(60, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(13, 43)
        Me.LabM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(68, 17)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 336)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(785, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabM_Tk
        '
        Me.LabM_Tk.AutoSize = True
        Me.LabM_Tk.Location = New System.Drawing.Point(13, 76)
        Me.LabM_Tk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(67, 17)
        Me.LabM_Tk.TabIndex = 17
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "Tài khoản"
        '
        'TxtM_Tk
        '
        Me.TxtM_Tk._ActilookupPopup = False
        Me.TxtM_Tk.CyberActilookupPopup = True
        Me.TxtM_Tk.Dv_ListDetail = Nothing
        Me.TxtM_Tk.Dv_Master = Nothing
        Me.TxtM_Tk.FilterClient = ""
        Me.TxtM_Tk.FilterSQL = ""
        Me.TxtM_Tk.Location = New System.Drawing.Point(127, 72)
        Me.TxtM_Tk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_Tk.Name = "TxtM_Tk"
        Me.TxtM_Tk.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Tk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Tk.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Tk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Tk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Tk.Size = New System.Drawing.Size(152, 24)
        Me.TxtM_Tk.TabIndex = 2
        Me.TxtM_Tk.Table_Name = ""
        '
        'Txtten_Tk
        '
        Me.Txtten_Tk.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Tk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Tk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Tk.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk.Location = New System.Drawing.Point(287, 77)
        Me.Txtten_Tk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_Tk.Name = "Txtten_Tk"
        Me.Txtten_Tk.ReadOnly = True
        Me.Txtten_Tk.Size = New System.Drawing.Size(501, 16)
        Me.Txtten_Tk.TabIndex = 144
        Me.Txtten_Tk.TabStop = False
        '
        'TxtTen_Nhom1
        '
        Me.TxtTen_Nhom1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nhom1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nhom1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nhom1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nhom1.Location = New System.Drawing.Point(287, 140)
        Me.TxtTen_Nhom1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nhom1.Name = "TxtTen_Nhom1"
        Me.TxtTen_Nhom1.ReadOnly = True
        Me.TxtTen_Nhom1.Size = New System.Drawing.Size(501, 16)
        Me.TxtTen_Nhom1.TabIndex = 163
        Me.TxtTen_Nhom1.TabStop = False
        '
        'TxtNhom1
        '
        Me.TxtNhom1._ActilookupPopup = False
        Me.TxtNhom1.CyberActilookupPopup = True
        Me.TxtNhom1.Dv_ListDetail = Nothing
        Me.TxtNhom1.Dv_Master = Nothing
        Me.TxtNhom1.FilterClient = ""
        Me.TxtNhom1.FilterSQL = ""
        Me.TxtNhom1.Location = New System.Drawing.Point(127, 135)
        Me.TxtNhom1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNhom1.Name = "TxtNhom1"
        Me.TxtNhom1.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNhom1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNhom1.Properties.Appearance.Options.UseFont = True
        Me.TxtNhom1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNhom1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNhom1.Size = New System.Drawing.Size(152, 24)
        Me.TxtNhom1.TabIndex = 4
        Me.TxtNhom1.Table_Name = ""
        '
        'LabNhom1
        '
        Me.LabNhom1.AutoSize = True
        Me.LabNhom1.Location = New System.Drawing.Point(13, 144)
        Me.LabNhom1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNhom1.Name = "LabNhom1"
        Me.LabNhom1.Size = New System.Drawing.Size(57, 17)
        Me.LabNhom1.TabIndex = 164
        Me.LabNhom1.Tag = "Group 1"
        Me.LabNhom1.Text = "Nhóm 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 171)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 167
        Me.Label2.Tag = "Group 2"
        Me.Label2.Text = "Nhóm 2"
        '
        'TxtTen_Nhom2
        '
        Me.TxtTen_Nhom2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nhom2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nhom2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nhom2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nhom2.Location = New System.Drawing.Point(287, 167)
        Me.TxtTen_Nhom2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nhom2.Name = "TxtTen_Nhom2"
        Me.TxtTen_Nhom2.ReadOnly = True
        Me.TxtTen_Nhom2.Size = New System.Drawing.Size(501, 16)
        Me.TxtTen_Nhom2.TabIndex = 166
        Me.TxtTen_Nhom2.TabStop = False
        '
        'TxtNhom2
        '
        Me.TxtNhom2._ActilookupPopup = False
        Me.TxtNhom2.CyberActilookupPopup = True
        Me.TxtNhom2.Dv_ListDetail = Nothing
        Me.TxtNhom2.Dv_Master = Nothing
        Me.TxtNhom2.FilterClient = ""
        Me.TxtNhom2.FilterSQL = ""
        Me.TxtNhom2.Location = New System.Drawing.Point(127, 162)
        Me.TxtNhom2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNhom2.Name = "TxtNhom2"
        Me.TxtNhom2.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNhom2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNhom2.Properties.Appearance.Options.UseFont = True
        Me.TxtNhom2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNhom2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNhom2.Size = New System.Drawing.Size(152, 24)
        Me.TxtNhom2.TabIndex = 5
        Me.TxtNhom2.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 199)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 170
        Me.Label3.Tag = "Group 3"
        Me.Label3.Text = "Nhóm 3"
        '
        'TxtTen_Nhom3
        '
        Me.TxtTen_Nhom3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nhom3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nhom3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nhom3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nhom3.Location = New System.Drawing.Point(287, 195)
        Me.TxtTen_Nhom3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nhom3.Name = "TxtTen_Nhom3"
        Me.TxtTen_Nhom3.ReadOnly = True
        Me.TxtTen_Nhom3.Size = New System.Drawing.Size(501, 16)
        Me.TxtTen_Nhom3.TabIndex = 169
        Me.TxtTen_Nhom3.TabStop = False
        '
        'TxtNhom3
        '
        Me.TxtNhom3._ActilookupPopup = False
        Me.TxtNhom3.CyberActilookupPopup = True
        Me.TxtNhom3.Dv_ListDetail = Nothing
        Me.TxtNhom3.Dv_Master = Nothing
        Me.TxtNhom3.FilterClient = ""
        Me.TxtNhom3.FilterSQL = ""
        Me.TxtNhom3.Location = New System.Drawing.Point(127, 190)
        Me.TxtNhom3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNhom3.Name = "TxtNhom3"
        Me.TxtNhom3.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNhom3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNhom3.Properties.Appearance.Options.UseFont = True
        Me.TxtNhom3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNhom3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNhom3.Size = New System.Drawing.Size(152, 24)
        Me.TxtNhom3.TabIndex = 6
        Me.TxtNhom3.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 226)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 173
        Me.Label4.Tag = "Group 4"
        Me.Label4.Text = "Nhóm 4"
        '
        'TxtTen_Nhom4
        '
        Me.TxtTen_Nhom4.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nhom4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nhom4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nhom4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nhom4.Location = New System.Drawing.Point(287, 222)
        Me.TxtTen_Nhom4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nhom4.Name = "TxtTen_Nhom4"
        Me.TxtTen_Nhom4.ReadOnly = True
        Me.TxtTen_Nhom4.Size = New System.Drawing.Size(501, 16)
        Me.TxtTen_Nhom4.TabIndex = 172
        Me.TxtTen_Nhom4.TabStop = False
        '
        'TxtNhom4
        '
        Me.TxtNhom4._ActilookupPopup = False
        Me.TxtNhom4.CyberActilookupPopup = True
        Me.TxtNhom4.Dv_ListDetail = Nothing
        Me.TxtNhom4.Dv_Master = Nothing
        Me.TxtNhom4.FilterClient = ""
        Me.TxtNhom4.FilterSQL = ""
        Me.TxtNhom4.Location = New System.Drawing.Point(127, 217)
        Me.TxtNhom4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNhom4.Name = "TxtNhom4"
        Me.TxtNhom4.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNhom4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNhom4.Properties.Appearance.Options.UseFont = True
        Me.TxtNhom4.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNhom4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNhom4.Size = New System.Drawing.Size(152, 24)
        Me.TxtNhom4.TabIndex = 7
        Me.TxtNhom4.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 255)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 17)
        Me.Label5.TabIndex = 176
        Me.Label5.Tag = "Group 5"
        Me.Label5.Text = "Nhóm 5"
        '
        'TxtTen_Nhom5
        '
        Me.TxtTen_Nhom5.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nhom5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nhom5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Nhom5.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nhom5.Location = New System.Drawing.Point(287, 251)
        Me.TxtTen_Nhom5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nhom5.Name = "TxtTen_Nhom5"
        Me.TxtTen_Nhom5.ReadOnly = True
        Me.TxtTen_Nhom5.Size = New System.Drawing.Size(501, 16)
        Me.TxtTen_Nhom5.TabIndex = 175
        Me.TxtTen_Nhom5.TabStop = False
        '
        'TxtNhom5
        '
        Me.TxtNhom5._ActilookupPopup = False
        Me.TxtNhom5.CyberActilookupPopup = True
        Me.TxtNhom5.Dv_ListDetail = Nothing
        Me.TxtNhom5.Dv_Master = Nothing
        Me.TxtNhom5.FilterClient = ""
        Me.TxtNhom5.FilterSQL = ""
        Me.TxtNhom5.Location = New System.Drawing.Point(127, 246)
        Me.TxtNhom5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNhom5.Name = "TxtNhom5"
        Me.TxtNhom5.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtNhom5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNhom5.Properties.Appearance.Options.UseFont = True
        Me.TxtNhom5.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNhom5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNhom5.Size = New System.Drawing.Size(152, 24)
        Me.TxtNhom5.TabIndex = 8
        Me.TxtNhom5.Table_Name = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 109)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 226
        Me.Label7.Tag = "Debit/Credit"
        Me.Label7.Text = "Phát sinh"
        '
        'CbbPhat_Sinh
        '
        Me.CbbPhat_Sinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbPhat_Sinh.ForeColor = System.Drawing.Color.Navy
        Me.CbbPhat_Sinh.FormattingEnabled = True
        Me.CbbPhat_Sinh.Location = New System.Drawing.Point(127, 103)
        Me.CbbPhat_Sinh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbPhat_Sinh.Name = "CbbPhat_Sinh"
        Me.CbbPhat_Sinh.Size = New System.Drawing.Size(151, 25)
        Me.CbbPhat_Sinh.TabIndex = 3
        '
        'GLTH5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(795, 428)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CbbPhat_Sinh)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_Nhom5)
        Me.Controls.Add(Me.TxtNhom5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Nhom4)
        Me.Controls.Add(Me.TxtNhom4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Nhom3)
        Me.Controls.Add(Me.TxtNhom3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Nhom2)
        Me.Controls.Add(Me.TxtNhom2)
        Me.Controls.Add(Me.LabNhom1)
        Me.Controls.Add(Me.TxtTen_Nhom1)
        Me.Controls.Add(Me.TxtNhom1)
        Me.Controls.Add(Me.TxtM_Tk)
        Me.Controls.Add(Me.Txtten_Tk)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "GLTH5"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtNhom1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nhom1, 0)
        Me.Controls.SetChildIndex(Me.LabNhom1, 0)
        Me.Controls.SetChildIndex(Me.TxtNhom2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nhom2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNhom3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nhom3, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtNhom4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nhom4, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtNhom5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nhom5, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.CbbPhat_Sinh, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        CType(Me.TxtM_Tk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNhom1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNhom2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNhom3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNhom4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNhom5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtM_Tk As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Nhom1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNhom1 As Cyber.SmLists.TxtLookup
    Friend WithEvents LabNhom1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nhom2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNhom2 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nhom3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNhom3 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nhom4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNhom4 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nhom5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNhom5 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CbbPhat_Sinh As System.Windows.Forms.ComboBox

End Class
