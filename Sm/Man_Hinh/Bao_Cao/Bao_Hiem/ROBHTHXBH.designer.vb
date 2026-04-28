<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ROBHTHXBH
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
        Me.LabMa_Hs = New System.Windows.Forms.Label()
        Me.TxtTen_Hs_h = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs_h = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTen_Kh = New System.Windows.Forms.TextBox()
        Me.txtMa_kh = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_BP_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_BP_H = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTen_BH = New System.Windows.Forms.TextBox()
        Me.txtMa_BH = New Cyber.SmLists.TxtLookup()
        Me.ChkDetail_OK = New System.Windows.Forms.CheckBox()
        Me.CbbGroupByCT = New System.Windows.Forms.ComboBox()
        Me.CbbGroupByTH = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Hs_h.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa_kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BP_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa_BH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(715, 337)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 14
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(121, 296)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(724, 25)
        Me.CBBMa_Dvcs.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 299)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(576, 337)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 13
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(5, 271)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(123, 268)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 10
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(281, 268)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 11
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(121, 81)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(140, 24)
        Me.TxtM_Ngay_Ct1.TabIndex = 2
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(121, 112)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(140, 24)
        Me.TxtM_Ngay_Ct2.TabIndex = 3
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(5, 86)
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
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(5, 118)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(7, 322)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(844, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_Hs
        '
        Me.LabMa_Hs.AutoSize = True
        Me.LabMa_Hs.Location = New System.Drawing.Point(5, 179)
        Me.LabMa_Hs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Hs.Name = "LabMa_Hs"
        Me.LabMa_Hs.Size = New System.Drawing.Size(73, 17)
        Me.LabMa_Hs.TabIndex = 408
        Me.LabMa_Hs.Tag = "Staff"
        Me.LabMa_Hs.Text = "Nhân viên "
        '
        'TxtTen_Hs_h
        '
        Me.TxtTen_Hs_h.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs_h.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs_h.Enabled = False
        Me.TxtTen_Hs_h.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs_h.Location = New System.Drawing.Point(295, 178)
        Me.TxtTen_Hs_h.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Hs_h.Name = "TxtTen_Hs_h"
        Me.TxtTen_Hs_h.ReadOnly = True
        Me.TxtTen_Hs_h.Size = New System.Drawing.Size(543, 17)
        Me.TxtTen_Hs_h.TabIndex = 407
        Me.TxtTen_Hs_h.TabStop = False
        '
        'TxtMa_Hs_h
        '
        Me.TxtMa_Hs_h._ActilookupPopup = False
        Me.TxtMa_Hs_h.CyberActilookupPopup = True
        Me.TxtMa_Hs_h.Dv_ListDetail = Nothing
        Me.TxtMa_Hs_h.Dv_Master = Nothing
        Me.TxtMa_Hs_h.FilterClient = ""
        Me.TxtMa_Hs_h.FilterSQL = ""
        Me.TxtMa_Hs_h.Location = New System.Drawing.Point(121, 174)
        Me.TxtMa_Hs_h.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Hs_h.Name = "TxtMa_Hs_h"
        Me.TxtMa_Hs_h.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs_h.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs_h.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs_h.Size = New System.Drawing.Size(141, 22)
        Me.TxtMa_Hs_h.TabIndex = 5
        Me.TxtMa_Hs_h.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 149)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 441
        Me.Label3.Tag = "Customer"
        Me.Label3.Text = "Khách hàng"
        '
        'txtTen_Kh
        '
        Me.txtTen_Kh.BackColor = System.Drawing.SystemColors.Control
        Me.txtTen_Kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_Kh.Enabled = False
        Me.txtTen_Kh.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Kh.Location = New System.Drawing.Point(295, 148)
        Me.txtTen_Kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTen_Kh.Name = "txtTen_Kh"
        Me.txtTen_Kh.ReadOnly = True
        Me.txtTen_Kh.Size = New System.Drawing.Size(543, 17)
        Me.txtTen_Kh.TabIndex = 440
        Me.txtTen_Kh.TabStop = False
        '
        'txtMa_kh
        '
        Me.txtMa_kh._ActilookupPopup = False
        Me.txtMa_kh.CyberActilookupPopup = True
        Me.txtMa_kh.Dv_ListDetail = Nothing
        Me.txtMa_kh.Dv_Master = Nothing
        Me.txtMa_kh.FilterClient = ""
        Me.txtMa_kh.FilterSQL = ""
        Me.txtMa_kh.Location = New System.Drawing.Point(121, 144)
        Me.txtMa_kh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMa_kh.Name = "txtMa_kh"
        Me.txtMa_kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtMa_kh.Properties.Appearance.Options.UseForeColor = True
        Me.txtMa_kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtMa_kh.Size = New System.Drawing.Size(141, 22)
        Me.txtMa_kh.TabIndex = 4
        Me.txtMa_kh.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 444
        Me.Label2.Tag = "Department"
        Me.Label2.Text = "Bộ phận"
        '
        'TxtTen_BP_H
        '
        Me.TxtTen_BP_H.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_BP_H.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BP_H.Enabled = False
        Me.TxtTen_BP_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BP_H.Location = New System.Drawing.Point(295, 208)
        Me.TxtTen_BP_H.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_BP_H.Name = "TxtTen_BP_H"
        Me.TxtTen_BP_H.ReadOnly = True
        Me.TxtTen_BP_H.Size = New System.Drawing.Size(543, 17)
        Me.TxtTen_BP_H.TabIndex = 443
        Me.TxtTen_BP_H.TabStop = False
        '
        'TxtMa_BP_H
        '
        Me.TxtMa_BP_H._ActilookupPopup = False
        Me.TxtMa_BP_H.CyberActilookupPopup = True
        Me.TxtMa_BP_H.Dv_ListDetail = Nothing
        Me.TxtMa_BP_H.Dv_Master = Nothing
        Me.TxtMa_BP_H.FilterClient = ""
        Me.TxtMa_BP_H.FilterSQL = ""
        Me.TxtMa_BP_H.Location = New System.Drawing.Point(121, 204)
        Me.TxtMa_BP_H.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_BP_H.Name = "TxtMa_BP_H"
        Me.TxtMa_BP_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP_H.Size = New System.Drawing.Size(141, 22)
        Me.TxtMa_BP_H.TabIndex = 6
        Me.TxtMa_BP_H.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 241)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 17)
        Me.Label4.TabIndex = 447
        Me.Label4.Tag = "Insurer"
        Me.Label4.Text = "Đơn vị bảo hiểm"
        '
        'txtTen_BH
        '
        Me.txtTen_BH.BackColor = System.Drawing.SystemColors.Control
        Me.txtTen_BH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_BH.Enabled = False
        Me.txtTen_BH.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_BH.Location = New System.Drawing.Point(295, 239)
        Me.txtTen_BH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTen_BH.Name = "txtTen_BH"
        Me.txtTen_BH.ReadOnly = True
        Me.txtTen_BH.Size = New System.Drawing.Size(543, 17)
        Me.txtTen_BH.TabIndex = 446
        Me.txtTen_BH.TabStop = False
        '
        'txtMa_BH
        '
        Me.txtMa_BH._ActilookupPopup = False
        Me.txtMa_BH.CyberActilookupPopup = True
        Me.txtMa_BH.Dv_ListDetail = Nothing
        Me.txtMa_BH.Dv_Master = Nothing
        Me.txtMa_BH.FilterClient = ""
        Me.txtMa_BH.FilterSQL = ""
        Me.txtMa_BH.Location = New System.Drawing.Point(121, 235)
        Me.txtMa_BH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMa_BH.Name = "txtMa_BH"
        Me.txtMa_BH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtMa_BH.Properties.Appearance.Options.UseForeColor = True
        Me.txtMa_BH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtMa_BH.Size = New System.Drawing.Size(141, 22)
        Me.txtMa_BH.TabIndex = 7
        Me.txtMa_BH.Table_Name = ""
        '
        'ChkDetail_OK
        '
        Me.ChkDetail_OK.AutoSize = True
        Me.ChkDetail_OK.Location = New System.Drawing.Point(121, 47)
        Me.ChkDetail_OK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkDetail_OK.Name = "ChkDetail_OK"
        Me.ChkDetail_OK.Size = New System.Drawing.Size(104, 21)
        Me.ChkDetail_OK.TabIndex = 450
        Me.ChkDetail_OK.Tag = "Detail"
        Me.ChkDetail_OK.Text = "Chi tiết theo"
        Me.ChkDetail_OK.UseVisualStyleBackColor = True
        '
        'CbbGroupByCT
        '
        Me.CbbGroupByCT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGroupByCT.ForeColor = System.Drawing.Color.Navy
        Me.CbbGroupByCT.FormattingEnabled = True
        Me.CbbGroupByCT.Location = New System.Drawing.Point(263, 44)
        Me.CbbGroupByCT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbGroupByCT.Name = "CbbGroupByCT"
        Me.CbbGroupByCT.Size = New System.Drawing.Size(583, 25)
        Me.CbbGroupByCT.TabIndex = 1
        '
        'CbbGroupByTH
        '
        Me.CbbGroupByTH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbGroupByTH.ForeColor = System.Drawing.Color.Navy
        Me.CbbGroupByTH.FormattingEnabled = True
        Me.CbbGroupByTH.Location = New System.Drawing.Point(121, 13)
        Me.CbbGroupByTH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbGroupByTH.Name = "CbbGroupByTH"
        Me.CbbGroupByTH.Size = New System.Drawing.Size(724, 25)
        Me.CbbGroupByTH.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 17)
        Me.Label5.TabIndex = 451
        Me.Label5.Tag = "Group by"
        Me.Label5.Text = "Tổng hợp theo"
        '
        'ROBHTHXBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(853, 407)
        Me.Controls.Add(Me.ChkDetail_OK)
        Me.Controls.Add(Me.CbbGroupByCT)
        Me.Controls.Add(Me.CbbGroupByTH)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTen_BH)
        Me.Controls.Add(Me.txtMa_BH)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_BP_H)
        Me.Controls.Add(Me.TxtMa_BP_H)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTen_Kh)
        Me.Controls.Add(Me.txtMa_kh)
        Me.Controls.Add(Me.LabMa_Hs)
        Me.Controls.Add(Me.TxtTen_Hs_h)
        Me.Controls.Add(Me.TxtMa_Hs_h)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "ROBHTHXBH"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs_h, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs_h, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.txtMa_kh, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Kh, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BP_H, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtMa_BH, 0)
        Me.Controls.SetChildIndex(Me.txtTen_BH, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.CbbGroupByTH, 0)
        Me.Controls.SetChildIndex(Me.CbbGroupByCT, 0)
        Me.Controls.SetChildIndex(Me.ChkDetail_OK, 0)
        CType(Me.TxtMa_Hs_h.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa_kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BP_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa_BH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_Hs As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs_h As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs_h As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTen_Kh As System.Windows.Forms.TextBox
    Friend WithEvents txtMa_kh As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_BP_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BP_H As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTen_BH As System.Windows.Forms.TextBox
    Friend WithEvents txtMa_BH As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkDetail_OK As System.Windows.Forms.CheckBox
    Friend WithEvents CbbGroupByCT As System.Windows.Forms.ComboBox
    Friend WithEvents CbbGroupByTH As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
