<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRM_PQTTH1
    Inherits Cyber.From.FilterReport

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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.TxtNh_Vt3 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_Vt2 = New Cyber.SmLists.TxtLookup()
        Me.TxtNh_Vt1 = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtTen_vt = New System.Windows.Forms.TextBox()
        Me.TxtMa_vt = New Cyber.SmLists.TxtLookup()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh_Vt1 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh_Vt3 = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh_Vt2 = New System.Windows.Forms.TextBox()
        CType(Me.TxtNh_Vt3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Vt2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Vt1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 205)
        Me.ButtExit.TabIndex = 14
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 166)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 169)
        Me.Label1.TabIndex = 22
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 205)
        Me.ButtOK.TabIndex = 13
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 147)
        Me.LabLoai_NT.TabIndex = 21
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 144)
        Me.ChkVND.TabIndex = 10
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 144)
        Me.ChkNT.TabIndex = 11
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 9)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 32)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(10, 13)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 15
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(9, 36)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 16
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 188)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 23
        Me.GroupBoxLine.TabStop = False
        '
        'TxtNh_Vt3
        '
        Me.TxtNh_Vt3._ActilookupPopup = False
        Me.TxtNh_Vt3.CyberActilookupPopup = True
        Me.TxtNh_Vt3.Dv_ListDetail = Nothing
        Me.TxtNh_Vt3.Dv_Master = Nothing
        Me.TxtNh_Vt3.FilterClient = ""
        Me.TxtNh_Vt3.FilterSQL = ""
        Me.TxtNh_Vt3.Location = New System.Drawing.Point(95, 122)
        Me.TxtNh_Vt3.Name = "TxtNh_Vt3"
        Me.TxtNh_Vt3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Vt3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Vt3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Vt3.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Vt3.TabIndex = 8
        Me.TxtNh_Vt3.Table_Name = ""
        '
        'TxtNh_Vt2
        '
        Me.TxtNh_Vt2._ActilookupPopup = False
        Me.TxtNh_Vt2.CyberActilookupPopup = True
        Me.TxtNh_Vt2.Dv_ListDetail = Nothing
        Me.TxtNh_Vt2.Dv_Master = Nothing
        Me.TxtNh_Vt2.FilterClient = ""
        Me.TxtNh_Vt2.FilterSQL = ""
        Me.TxtNh_Vt2.Location = New System.Drawing.Point(95, 100)
        Me.TxtNh_Vt2.Name = "TxtNh_Vt2"
        Me.TxtNh_Vt2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Vt2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Vt2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Vt2.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Vt2.TabIndex = 6
        Me.TxtNh_Vt2.Table_Name = ""
        '
        'TxtNh_Vt1
        '
        Me.TxtNh_Vt1._ActilookupPopup = False
        Me.TxtNh_Vt1.CyberActilookupPopup = True
        Me.TxtNh_Vt1.Dv_ListDetail = Nothing
        Me.TxtNh_Vt1.Dv_Master = Nothing
        Me.TxtNh_Vt1.FilterClient = ""
        Me.TxtNh_Vt1.FilterSQL = ""
        Me.TxtNh_Vt1.Location = New System.Drawing.Point(95, 78)
        Me.TxtNh_Vt1.Name = "TxtNh_Vt1"
        Me.TxtNh_Vt1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Vt1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Vt1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Vt1.Size = New System.Drawing.Size(114, 20)
        Me.TxtNh_Vt1.TabIndex = 4
        Me.TxtNh_Vt1.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Tag = "Group supplies 3"
        Me.Label8.Text = "Nhóm vật tư 3"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 105)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 13)
        Me.Label13.TabIndex = 19
        Me.Label13.Tag = "Group supplies 2"
        Me.Label13.Text = "Nhóm vật tư 2"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(11, 82)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 13)
        Me.Label14.TabIndex = 18
        Me.Label14.Tag = "Group supplies 1"
        Me.Label14.Text = "Nhóm vật tư 1"
        '
        'TxtTen_vt
        '
        Me.TxtTen_vt.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_vt.Enabled = False
        Me.TxtTen_vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_vt.Location = New System.Drawing.Point(214, 59)
        Me.TxtTen_vt.Name = "TxtTen_vt"
        Me.TxtTen_vt.ReadOnly = True
        Me.TxtTen_vt.Size = New System.Drawing.Size(365, 14)
        Me.TxtTen_vt.TabIndex = 3
        Me.TxtTen_vt.TabStop = False
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
        Me.TxtMa_vt.Location = New System.Drawing.Point(95, 56)
        Me.TxtMa_vt.Name = "TxtMa_vt"
        Me.TxtMa_vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_vt.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_vt.TabIndex = 2
        Me.TxtMa_vt.Table_Name = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(11, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Tag = "Supplies "
        Me.Label6.Text = "Mã vật tư"
        '
        'TxtTen_Nh_Vt1
        '
        Me.TxtTen_Nh_Vt1.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Vt1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Vt1.Enabled = False
        Me.TxtTen_Nh_Vt1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Vt1.Location = New System.Drawing.Point(214, 81)
        Me.TxtTen_Nh_Vt1.Name = "TxtTen_Nh_Vt1"
        Me.TxtTen_Nh_Vt1.ReadOnly = True
        Me.TxtTen_Nh_Vt1.Size = New System.Drawing.Size(365, 14)
        Me.TxtTen_Nh_Vt1.TabIndex = 5
        Me.TxtTen_Nh_Vt1.TabStop = False
        '
        'TxtTen_Nh_Vt3
        '
        Me.TxtTen_Nh_Vt3.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Vt3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Vt3.Enabled = False
        Me.TxtTen_Nh_Vt3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Vt3.Location = New System.Drawing.Point(214, 125)
        Me.TxtTen_Nh_Vt3.Name = "TxtTen_Nh_Vt3"
        Me.TxtTen_Nh_Vt3.ReadOnly = True
        Me.TxtTen_Nh_Vt3.Size = New System.Drawing.Size(365, 14)
        Me.TxtTen_Nh_Vt3.TabIndex = 9
        Me.TxtTen_Nh_Vt3.TabStop = False
        '
        'TxtTen_Nh_Vt2
        '
        Me.TxtTen_Nh_Vt2.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Nh_Vt2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh_Vt2.Enabled = False
        Me.TxtTen_Nh_Vt2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh_Vt2.Location = New System.Drawing.Point(213, 103)
        Me.TxtTen_Nh_Vt2.Name = "TxtTen_Nh_Vt2"
        Me.TxtTen_Nh_Vt2.ReadOnly = True
        Me.TxtTen_Nh_Vt2.Size = New System.Drawing.Size(365, 14)
        Me.TxtTen_Nh_Vt2.TabIndex = 7
        Me.TxtTen_Nh_Vt2.TabStop = False
        '
        'CP_PQTTH1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 258)
        Me.Controls.Add(Me.TxtTen_Nh_Vt2)
        Me.Controls.Add(Me.TxtTen_Nh_Vt3)
        Me.Controls.Add(Me.TxtTen_Nh_Vt1)
        Me.Controls.Add(Me.TxtNh_Vt3)
        Me.Controls.Add(Me.TxtNh_Vt2)
        Me.Controls.Add(Me.TxtNh_Vt1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtTen_vt)
        Me.Controls.Add(Me.TxtMa_vt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "CP_PQTTH1"
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
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vt, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Vt1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Vt2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Vt3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Vt1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Vt3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh_Vt2, 0)
        CType(Me.TxtNh_Vt3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Vt2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Vt1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNh_Vt3 As SmLists.TxtLookup
    Friend WithEvents TxtNh_Vt2 As SmLists.TxtLookup
    Friend WithEvents TxtNh_Vt1 As SmLists.TxtLookup
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtTen_vt As TextBox
    Friend WithEvents TxtMa_vt As SmLists.TxtLookup
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtTen_Nh_Vt1 As TextBox
    Friend WithEvents TxtTen_Nh_Vt3 As TextBox
    Friend WithEvents TxtTen_Nh_Vt2 As TextBox
End Class
