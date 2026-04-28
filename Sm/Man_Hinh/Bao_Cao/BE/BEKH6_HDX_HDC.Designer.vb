<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BEKH6_HDX_HDC
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
        Me.LabMa_GD = New System.Windows.Forms.Label()
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbGroupByTH = New System.Windows.Forms.ComboBox()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_BP = New System.Windows.Forms.TextBox()
        Me.TxtMa_BP = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_HS = New System.Windows.Forms.TextBox()
        Me.TxtMa_HS = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_Mau = New Cyber.SmLists.TxtLookup()
        Me.CbbGroupByCT = New System.Windows.Forms.ComboBox()
        Me.ChkDetail_OK = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(691, 362)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 13
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 311)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(688, 25)
        Me.CBBMa_Dvcs.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 315)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(552, 362)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 12
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(11, 286)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLoai_NT.Size = New System.Drawing.Size(93, 17)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 282)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 10
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(280, 282)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 11
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(127, 103)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct1.TabIndex = 4
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(127, 132)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct2.TabIndex = 5
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(11, 106)
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
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(11, 137)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 340)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(820, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_GD
        '
        Me.LabMa_GD.AutoSize = True
        Me.LabMa_GD.Location = New System.Drawing.Point(11, 76)
        Me.LabMa_GD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_GD.Name = "LabMa_GD"
        Me.LabMa_GD.Size = New System.Drawing.Size(92, 17)
        Me.LabMa_GD.TabIndex = 382
        Me.LabMa_GD.Tag = "Plan type"
        Me.LabMa_GD.Text = "Loại kế hoạch"
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(127, 72)
        Me.CbbMa_GD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(331, 25)
        Me.CbbMa_GD.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 386
        Me.Label3.Tag = "Group by"
        Me.Label3.Text = "Nhóm theo"
        '
        'CbbGroupByTH
        '
        Me.CbbGroupByTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGroupByTH.ForeColor = System.Drawing.Color.Navy
        Me.CbbGroupByTH.FormattingEnabled = True
        Me.CbbGroupByTH.Location = New System.Drawing.Point(125, 3)
        Me.CbbGroupByTH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbGroupByTH.Name = "CbbGroupByTH"
        Me.CbbGroupByTH.Size = New System.Drawing.Size(688, 25)
        Me.CbbGroupByTH.TabIndex = 0
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(11, 170)
        Me.LabMa_kho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(93, 17)
        Me.LabMa_kho.TabIndex = 389
        Me.LabMa_kho.Tag = "Department"
        Me.LabMa_kho.Text = "Bộ phận"
        '
        'TxtTen_BP
        '
        Me.TxtTen_BP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_BP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BP.Enabled = False
        Me.TxtTen_BP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BP.Location = New System.Drawing.Point(289, 167)
        Me.TxtTen_BP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_BP.Name = "TxtTen_BP"
        Me.TxtTen_BP.ReadOnly = True
        Me.TxtTen_BP.Size = New System.Drawing.Size(353, 17)
        Me.TxtTen_BP.TabIndex = 388
        Me.TxtTen_BP.TabStop = False
        '
        'TxtMa_BP
        '
        Me.TxtMa_BP._ActilookupPopup = False
        Me.TxtMa_BP.CyberActilookupPopup = True
        Me.TxtMa_BP.Dv_ListDetail = Nothing
        Me.TxtMa_BP.Dv_Master = Nothing
        Me.TxtMa_BP.FilterClient = ""
        Me.TxtMa_BP.FilterSQL = ""
        Me.TxtMa_BP.Location = New System.Drawing.Point(127, 163)
        Me.TxtMa_BP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_BP.Name = "TxtMa_BP"
        Me.TxtMa_BP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP.Size = New System.Drawing.Size(152, 22)
        Me.TxtMa_BP.TabIndex = 6
        Me.TxtMa_BP.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 197)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 392
        Me.Label2.Tag = "Staff"
        Me.Label2.Text = "Nhân viên"
        '
        'TxtTen_HS
        '
        Me.TxtTen_HS.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_HS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HS.Enabled = False
        Me.TxtTen_HS.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HS.Location = New System.Drawing.Point(289, 195)
        Me.TxtTen_HS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_HS.Name = "TxtTen_HS"
        Me.TxtTen_HS.ReadOnly = True
        Me.TxtTen_HS.Size = New System.Drawing.Size(353, 17)
        Me.TxtTen_HS.TabIndex = 391
        Me.TxtTen_HS.TabStop = False
        '
        'TxtMa_HS
        '
        Me.TxtMa_HS._ActilookupPopup = False
        Me.TxtMa_HS.CyberActilookupPopup = True
        Me.TxtMa_HS.Dv_ListDetail = Nothing
        Me.TxtMa_HS.Dv_Master = Nothing
        Me.TxtMa_HS.FilterClient = ""
        Me.TxtMa_HS.FilterSQL = ""
        Me.TxtMa_HS.Location = New System.Drawing.Point(127, 191)
        Me.TxtMa_HS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_HS.Name = "TxtMa_HS"
        Me.TxtMa_HS.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS.Size = New System.Drawing.Size(152, 22)
        Me.TxtMa_HS.TabIndex = 7
        Me.TxtMa_HS.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 225)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 17)
        Me.Label4.TabIndex = 395
        Me.Label4.Tag = "Car type"
        Me.Label4.Text = "Kiểu xe"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(289, 222)
        Me.TxtTen_Kx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(353, 17)
        Me.TxtTen_Kx.TabIndex = 394
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(127, 218)
        Me.TxtMa_Kx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(152, 22)
        Me.TxtMa_Kx.TabIndex = 8
        Me.TxtMa_Kx.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(11, 252)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 398
        Me.Label5.Tag = "Color"
        Me.Label5.Text = "Màu xe"
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Mau.Enabled = False
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Mau.Location = New System.Drawing.Point(289, 250)
        Me.TxtTen_Mau.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(353, 17)
        Me.TxtTen_Mau.TabIndex = 397
        Me.TxtTen_Mau.TabStop = False
        '
        'TxtMa_Mau
        '
        Me.TxtMa_Mau._ActilookupPopup = False
        Me.TxtMa_Mau.CyberActilookupPopup = True
        Me.TxtMa_Mau.Dv_ListDetail = Nothing
        Me.TxtMa_Mau.Dv_Master = Nothing
        Me.TxtMa_Mau.FilterClient = ""
        Me.TxtMa_Mau.FilterSQL = ""
        Me.TxtMa_Mau.Location = New System.Drawing.Point(127, 246)
        Me.TxtMa_Mau.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Mau.Name = "TxtMa_Mau"
        Me.TxtMa_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Mau.Size = New System.Drawing.Size(152, 22)
        Me.TxtMa_Mau.TabIndex = 9
        Me.TxtMa_Mau.Table_Name = ""
        '
        'CbbGroupByCT
        '
        Me.CbbGroupByCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGroupByCT.ForeColor = System.Drawing.Color.Navy
        Me.CbbGroupByCT.FormattingEnabled = True
        Me.CbbGroupByCT.Location = New System.Drawing.Point(248, 38)
        Me.CbbGroupByCT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbGroupByCT.Name = "CbbGroupByCT"
        Me.CbbGroupByCT.Size = New System.Drawing.Size(565, 25)
        Me.CbbGroupByCT.TabIndex = 2
        '
        'ChkDetail_OK
        '
        Me.ChkDetail_OK.AutoSize = True
        Me.ChkDetail_OK.Location = New System.Drawing.Point(127, 38)
        Me.ChkDetail_OK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkDetail_OK.Name = "ChkDetail_OK"
        Me.ChkDetail_OK.Size = New System.Drawing.Size(104, 21)
        Me.ChkDetail_OK.TabIndex = 1
        Me.ChkDetail_OK.Tag = "Detail"
        Me.ChkDetail_OK.Text = "Chi tiết theo"
        Me.ChkDetail_OK.UseVisualStyleBackColor = True
        '
        'BEKH6_HDX_HDC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(829, 432)
        Me.Controls.Add(Me.ChkDetail_OK)
        Me.Controls.Add(Me.CbbGroupByCT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.TxtMa_Mau)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_HS)
        Me.Controls.Add(Me.TxtMa_HS)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtTen_BP)
        Me.Controls.Add(Me.TxtMa_BP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbbGroupByTH)
        Me.Controls.Add(Me.LabMa_GD)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "BEKH6_HDX_HDC"
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
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.LabMa_GD, 0)
        Me.Controls.SetChildIndex(Me.CbbGroupByTH, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BP, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.CbbGroupByCT, 0)
        Me.Controls.SetChildIndex(Me.ChkDetail_OK, 0)
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_GD As System.Windows.Forms.Label
    Friend WithEvents CbbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbbGroupByTH As System.Windows.Forms.ComboBox
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_BP As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BP As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_HS As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_HS As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Mau As Cyber.SmLists.TxtLookup
    Friend WithEvents CbbGroupByCT As System.Windows.Forms.ComboBox
    Friend WithEvents ChkDetail_OK As System.Windows.Forms.CheckBox

End Class
