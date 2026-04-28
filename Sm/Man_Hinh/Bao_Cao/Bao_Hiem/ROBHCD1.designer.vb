<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ROBHCD1
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
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.cbbTinh_dc = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtMa_BH = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_BH = New System.Windows.Forms.TextBox()
        Me.LabMa_Cc = New System.Windows.Forms.Label()
        Me.TxtMa_vitri = New Cyber.SmLists.TxtLookup()
        Me.txtTen_Vitri = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_vitri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(719, 282)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 14
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(160, 230)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(693, 25)
        Me.CBBMa_Dvcs.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 234)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.TabIndex = 10
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 282)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 13
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(11, 205)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLoai_NT.TabIndex = 7
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(160, 201)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkVND.TabIndex = 8
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(303, 201)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkNT.TabIndex = 9
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 260)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(848, 12)
        Me.GroupBoxLine.TabIndex = 12
        Me.GroupBoxLine.TabStop = False
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(11, 48)
        Me.LabM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(68, 17)
        Me.LabM_Ngay_Ct2.TabIndex = 201
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(11, 17)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(60, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 200
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(160, 43)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(153, 24)
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
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(160, 12)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(153, 24)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'cbbTinh_dc
        '
        Me.cbbTinh_dc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbbTinh_dc.ForeColor = System.Drawing.Color.Navy
        Me.cbbTinh_dc.FormattingEnabled = True
        Me.cbbTinh_dc.Location = New System.Drawing.Point(160, 166)
        Me.cbbTinh_dc.Margin = New System.Windows.Forms.Padding(4)
        Me.cbbTinh_dc.Name = "cbbTinh_dc"
        Me.cbbTinh_dc.Size = New System.Drawing.Size(292, 25)
        Me.cbbTinh_dc.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(11, 171)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 17)
        Me.Label12.TabIndex = 270
        Me.Label12.Tag = "Transfer arising stock"
        Me.Label12.Text = "Tính điều chuyển kho"
        '
        'TxtMa_kho
        '
        Me.TxtMa_kho._ActilookupPopup = False
        Me.TxtMa_kho.CyberActilookupPopup = True
        Me.TxtMa_kho.Dv_ListDetail = Nothing
        Me.TxtMa_kho.Dv_Master = Nothing
        Me.TxtMa_kho.FilterClient = ""
        Me.TxtMa_kho.FilterSQL = ""
        Me.TxtMa_kho.Location = New System.Drawing.Point(160, 105)
        Me.TxtMa_kho.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_kho.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_kho.TabIndex = 3
        Me.TxtMa_kho.Table_Name = ""
        '
        'TxtTen_kho
        '
        Me.TxtTen_kho.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kho.Enabled = False
        Me.TxtTen_kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kho.Location = New System.Drawing.Point(321, 109)
        Me.TxtTen_kho.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(493, 17)
        Me.TxtTen_kho.TabIndex = 193
        Me.TxtTen_kho.TabStop = False
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(11, 110)
        Me.LabMa_kho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(109, 17)
        Me.LabMa_kho.TabIndex = 194
        Me.LabMa_kho.Tag = "Warehouse"
        Me.LabMa_kho.Text = "Mã kho"
        '
        'TxtMa_BH
        '
        Me.TxtMa_BH._ActilookupPopup = False
        Me.TxtMa_BH.CyberActilookupPopup = True
        Me.TxtMa_BH.Dv_ListDetail = Nothing
        Me.TxtMa_BH.Dv_Master = Nothing
        Me.TxtMa_BH.FilterClient = ""
        Me.TxtMa_BH.FilterSQL = ""
        Me.TxtMa_BH.Location = New System.Drawing.Point(160, 75)
        Me.TxtMa_BH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_BH.Name = "TxtMa_BH"
        Me.TxtMa_BH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BH.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_BH.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_BH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BH.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_BH.TabIndex = 2
        Me.TxtMa_BH.Table_Name = ""
        '
        'TxtTen_BH
        '
        Me.TxtTen_BH.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_BH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BH.Enabled = False
        Me.TxtTen_BH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BH.Location = New System.Drawing.Point(321, 78)
        Me.TxtTen_BH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_BH.Name = "TxtTen_BH"
        Me.TxtTen_BH.ReadOnly = True
        Me.TxtTen_BH.Size = New System.Drawing.Size(493, 17)
        Me.TxtTen_BH.TabIndex = 196
        Me.TxtTen_BH.TabStop = False
        '
        'LabMa_Cc
        '
        Me.LabMa_Cc.Location = New System.Drawing.Point(11, 80)
        Me.LabMa_Cc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Cc.Name = "LabMa_Cc"
        Me.LabMa_Cc.Size = New System.Drawing.Size(109, 17)
        Me.LabMa_Cc.TabIndex = 197
        Me.LabMa_Cc.Tag = "Insurer"
        Me.LabMa_Cc.Text = "Đơn vị BH"
        '
        'TxtMa_vitri
        '
        Me.TxtMa_vitri._ActilookupPopup = False
        Me.TxtMa_vitri.CyberActilookupPopup = True
        Me.TxtMa_vitri.Dv_ListDetail = Nothing
        Me.TxtMa_vitri.Dv_Master = Nothing
        Me.TxtMa_vitri.FilterClient = ""
        Me.TxtMa_vitri.FilterSQL = ""
        Me.TxtMa_vitri.Location = New System.Drawing.Point(160, 135)
        Me.TxtMa_vitri.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_vitri.Name = "TxtMa_vitri"
        Me.TxtMa_vitri.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_vitri.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_vitri.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_vitri.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_vitri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_vitri.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_vitri.TabIndex = 4
        Me.TxtMa_vitri.Table_Name = ""
        '
        'txtTen_Vitri
        '
        Me.txtTen_Vitri.BackColor = System.Drawing.SystemColors.Control
        Me.txtTen_Vitri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_Vitri.Enabled = False
        Me.txtTen_Vitri.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Vitri.Location = New System.Drawing.Point(321, 139)
        Me.txtTen_Vitri.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTen_Vitri.Name = "txtTen_Vitri"
        Me.txtTen_Vitri.ReadOnly = True
        Me.txtTen_Vitri.Size = New System.Drawing.Size(493, 17)
        Me.txtTen_Vitri.TabIndex = 255
        Me.txtTen_Vitri.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 140)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 17)
        Me.Label6.TabIndex = 256
        Me.Label6.Tag = "Location"
        Me.Label6.Text = "Vị trí"
        '
        'ROBHCD1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(857, 352)
        Me.Controls.Add(Me.cbbTinh_dc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTen_Vitri)
        Me.Controls.Add(Me.TxtMa_vitri)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Controls.Add(Me.LabMa_Cc)
        Me.Controls.Add(Me.TxtTen_BH)
        Me.Controls.Add(Me.TxtMa_BH)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "ROBHCD1"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BH, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_vitri, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Vitri, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.cbbTinh_dc, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_vitri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents cbbTinh_dc As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtMa_BH As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_BH As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_Cc As System.Windows.Forms.Label
    Friend WithEvents TxtMa_vitri As Cyber.SmLists.TxtLookup
    Friend WithEvents txtTen_Vitri As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
