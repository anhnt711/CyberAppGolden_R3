<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ARTTBK1
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
        Me.TxtM_Ngay_Ct = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabM_Tk = New System.Windows.Forms.Label()
        Me.TxtM_Tk_CN = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Tk_CN = New System.Windows.Forms.TextBox()
        Me.TxtM_Ma_kh = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TxtTen_Nh1 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH2 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_KH1 = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNh_KH3 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh3 = New System.Windows.Forms.TextBox()
        Me.ChkIn_TT = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkAuTo_PB = New System.Windows.Forms.CheckBox()
        CType(Me.TxtM_Tk_CN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtM_Ma_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(656, 303)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 12
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 252)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(653, 25)
        Me.CBBMa_Dvcs.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 256)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(517, 303)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 11
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(12, 224)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 224)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 8
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(281, 225)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 9
        '
        'TxtM_Ngay_Ct
        '
        Me.TxtM_Ngay_Ct.Flags = 0
        Me.TxtM_Ngay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct.IsAllowResize = False
        Me.TxtM_Ngay_Ct.isEmpty = True
        Me.TxtM_Ngay_Ct.Location = New System.Drawing.Point(127, 5)
        Me.TxtM_Ngay_Ct.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct.MaxLength = 10
        Me.TxtM_Ngay_Ct.Name = "TxtM_Ngay_Ct"
        Me.TxtM_Ngay_Ct.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct.TabIndex = 0
        Me.TxtM_Ngay_Ct.Text = "__/__/____"
        Me.TxtM_Ngay_Ct.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(12, 9)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(68, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "To date "
        Me.LabM_Ngay_Ct1.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 281)
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
        Me.LabM_Tk.Location = New System.Drawing.Point(12, 41)
        Me.LabM_Tk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(67, 17)
        Me.LabM_Tk.TabIndex = 17
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "Tài khoản"
        '
        'TxtM_Tk_CN
        '
        Me.TxtM_Tk_CN._ActilookupPopup = False
        Me.TxtM_Tk_CN.CyberActilookupPopup = True
        Me.TxtM_Tk_CN.Dv_ListDetail = Nothing
        Me.TxtM_Tk_CN.Dv_Master = Nothing
        Me.TxtM_Tk_CN.FilterClient = ""
        Me.TxtM_Tk_CN.FilterSQL = ""
        Me.TxtM_Tk_CN.Location = New System.Drawing.Point(127, 37)
        Me.TxtM_Tk_CN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_Tk_CN.Name = "TxtM_Tk_CN"
        Me.TxtM_Tk_CN.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Tk_CN.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Tk_CN.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Tk_CN.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Tk_CN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Tk_CN.Size = New System.Drawing.Size(152, 24)
        Me.TxtM_Tk_CN.TabIndex = 1
        Me.TxtM_Tk_CN.Table_Name = ""
        '
        'Txtten_Tk_CN
        '
        Me.Txtten_Tk_CN.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Tk_CN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Tk_CN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Tk_CN.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk_CN.Location = New System.Drawing.Point(280, 46)
        Me.Txtten_Tk_CN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_Tk_CN.Name = "Txtten_Tk_CN"
        Me.Txtten_Tk_CN.ReadOnly = True
        Me.Txtten_Tk_CN.Size = New System.Drawing.Size(509, 16)
        Me.Txtten_Tk_CN.TabIndex = 144
        Me.Txtten_Tk_CN.TabStop = False
        '
        'TxtM_Ma_kh
        '
        Me.TxtM_Ma_kh._ActilookupPopup = False
        Me.TxtM_Ma_kh.CyberActilookupPopup = True
        Me.TxtM_Ma_kh.Dv_ListDetail = Nothing
        Me.TxtM_Ma_kh.Dv_Master = Nothing
        Me.TxtM_Ma_kh.FilterClient = ""
        Me.TxtM_Ma_kh.FilterSQL = ""
        Me.TxtM_Ma_kh.Location = New System.Drawing.Point(127, 67)
        Me.TxtM_Ma_kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_Ma_kh.Name = "TxtM_Ma_kh"
        Me.TxtM_Ma_kh.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Ma_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ma_kh.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Ma_kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Ma_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Ma_kh.Size = New System.Drawing.Size(152, 24)
        Me.TxtM_Ma_kh.TabIndex = 2
        Me.TxtM_Ma_kh.Table_Name = ""
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_KH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KH.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH.Location = New System.Drawing.Point(280, 76)
        Me.TxtTen_KH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(509, 16)
        Me.TxtTen_KH.TabIndex = 148
        Me.TxtTen_KH.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 147
        Me.Label2.Tag = "Customer"
        Me.Label2.Text = "Mã đối tượng"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(251, 401)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(100, 21)
        Me.CheckBox1.TabIndex = 158
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TxtTen_Nh1
        '
        Me.TxtTen_Nh1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh1.Enabled = False
        Me.TxtTen_Nh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh1.Location = New System.Drawing.Point(280, 106)
        Me.TxtTen_Nh1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh1.Name = "TxtTen_Nh1"
        Me.TxtTen_Nh1.ReadOnly = True
        Me.TxtTen_Nh1.Size = New System.Drawing.Size(509, 17)
        Me.TxtTen_Nh1.TabIndex = 152
        Me.TxtTen_Nh1.TabStop = False
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh2.Enabled = False
        Me.TxtTen_Nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(280, 135)
        Me.TxtTen_Nh2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.ReadOnly = True
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(509, 17)
        Me.TxtTen_Nh2.TabIndex = 154
        Me.TxtTen_Nh2.TabStop = False
        '
        'TxtNh_KH2
        '
        Me.TxtNh_KH2._ActilookupPopup = False
        Me.TxtNh_KH2.CyberActilookupPopup = True
        Me.TxtNh_KH2.Dv_ListDetail = Nothing
        Me.TxtNh_KH2.Dv_Master = Nothing
        Me.TxtNh_KH2.FilterClient = ""
        Me.TxtNh_KH2.FilterSQL = ""
        Me.TxtNh_KH2.Location = New System.Drawing.Point(127, 127)
        Me.TxtNh_KH2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH2.Name = "TxtNh_KH2"
        Me.TxtNh_KH2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH2.Size = New System.Drawing.Size(152, 22)
        Me.TxtNh_KH2.TabIndex = 4
        Me.TxtNh_KH2.Table_Name = ""
        '
        'TxtNh_KH1
        '
        Me.TxtNh_KH1._ActilookupPopup = False
        Me.TxtNh_KH1.CyberActilookupPopup = True
        Me.TxtNh_KH1.Dv_ListDetail = Nothing
        Me.TxtNh_KH1.Dv_Master = Nothing
        Me.TxtNh_KH1.FilterClient = ""
        Me.TxtNh_KH1.FilterSQL = ""
        Me.TxtNh_KH1.Location = New System.Drawing.Point(127, 98)
        Me.TxtNh_KH1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH1.Name = "TxtNh_KH1"
        Me.TxtNh_KH1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH1.Size = New System.Drawing.Size(152, 22)
        Me.TxtNh_KH1.TabIndex = 3
        Me.TxtNh_KH1.Table_Name = ""
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(12, 102)
        Me.LabMa_Nh1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(72, 18)
        Me.LabMa_Nh1.TabIndex = 153
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Nhóm 1"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(12, 131)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 18)
        Me.Label4.TabIndex = 155
        Me.Label4.Tag = "Group 2"
        Me.Label4.Text = "Nhóm 2"
        '
        'TxtNh_KH3
        '
        Me.TxtNh_KH3._ActilookupPopup = False
        Me.TxtNh_KH3.CyberActilookupPopup = True
        Me.TxtNh_KH3.Dv_ListDetail = Nothing
        Me.TxtNh_KH3.Dv_Master = Nothing
        Me.TxtNh_KH3.FilterClient = ""
        Me.TxtNh_KH3.FilterSQL = ""
        Me.TxtNh_KH3.Location = New System.Drawing.Point(127, 156)
        Me.TxtNh_KH3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_KH3.Name = "TxtNh_KH3"
        Me.TxtNh_KH3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH3.Size = New System.Drawing.Size(152, 22)
        Me.TxtNh_KH3.TabIndex = 5
        Me.TxtNh_KH3.Table_Name = ""
        '
        'TxtTen_Nh3
        '
        Me.TxtTen_Nh3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh3.Enabled = False
        Me.TxtTen_Nh3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh3.Location = New System.Drawing.Point(280, 163)
        Me.TxtTen_Nh3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Nh3.Name = "TxtTen_Nh3"
        Me.TxtTen_Nh3.ReadOnly = True
        Me.TxtTen_Nh3.Size = New System.Drawing.Size(509, 17)
        Me.TxtTen_Nh3.TabIndex = 156
        Me.TxtTen_Nh3.TabStop = False
        '
        'ChkIn_TT
        '
        Me.ChkIn_TT.AutoSize = True
        Me.ChkIn_TT.ForeColor = System.Drawing.Color.Navy
        Me.ChkIn_TT.Location = New System.Drawing.Point(127, 190)
        Me.ChkIn_TT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkIn_TT.Name = "ChkIn_TT"
        Me.ChkIn_TT.Size = New System.Drawing.Size(249, 21)
        Me.ChkIn_TT.TabIndex = 6
        Me.ChkIn_TT.Tag = "Including bill has been finally settled"
        Me.ChkIn_TT.Text = "Lên cho cả các hóa đơn đã tất toán"
        Me.ChkIn_TT.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 157
        Me.Label3.Tag = "Group 3"
        Me.Label3.Text = "Nhóm 3"
        '
        'ChkAuTo_PB
        '
        Me.ChkAuTo_PB.AutoSize = True
        Me.ChkAuTo_PB.ForeColor = System.Drawing.Color.Navy
        Me.ChkAuTo_PB.Location = New System.Drawing.Point(521, 190)
        Me.ChkAuTo_PB.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkAuTo_PB.Name = "ChkAuTo_PB"
        Me.ChkAuTo_PB.Size = New System.Drawing.Size(138, 21)
        Me.ChkAuTo_PB.TabIndex = 7
        Me.ChkAuTo_PB.Tag = "Auto allocation"
        Me.ChkAuTo_PB.Text = "Tự động phân bổ"
        Me.ChkAuTo_PB.UseVisualStyleBackColor = True
        '
        'ARTTBK1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(795, 373)
        Me.Controls.Add(Me.ChkAuTo_PB)
        Me.Controls.Add(Me.ChkIn_TT)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Nh3)
        Me.Controls.Add(Me.TxtNh_KH3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.TxtNh_KH2)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_Nh1)
        Me.Controls.Add(Me.TxtNh_KH1)
        Me.Controls.Add(Me.TxtM_Ma_kh)
        Me.Controls.Add(Me.TxtTen_KH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtM_Tk_CN)
        Me.Controls.Add(Me.Txtten_Tk_CN)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "ARTTBK1"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Tk_CN, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Tk_CN, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ma_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh1, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh3, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.CheckBox1, 0)
        Me.Controls.SetChildIndex(Me.ChkIn_TT, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.ChkAuTo_PB, 0)
        CType(Me.TxtM_Tk_CN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtM_Ma_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtM_Tk_CN As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk_CN As System.Windows.Forms.TextBox
    Friend WithEvents TxtM_Ma_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTen_Nh1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Nh2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH2 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNh_KH1 As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNh_KH3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh3 As System.Windows.Forms.TextBox
    Friend WithEvents ChkIn_TT As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkAuTo_PB As System.Windows.Forms.CheckBox

End Class
