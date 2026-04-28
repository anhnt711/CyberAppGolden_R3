<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RO_07
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbbLoai_Phieu = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Txtten_xe = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_KX = New Cyber.SmLists.TxtLookup()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTen_Mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_mau = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbbMa_post2 = New System.Windows.Forms.ComboBox()
        Me.CbbMa_Post1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(571, 203)
        Me.ButtExit.TabIndex = 12
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(107, 168)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(560, 21)
        Me.CBBMa_Dvcs.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(15, 171)
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(467, 203)
        Me.ButtOK.TabIndex = 11
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(15, 144)
        Me.LabLoai_NT.Size = New System.Drawing.Size(62, 13)
        Me.LabLoai_NT.TabIndex = 13
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(107, 144)
        Me.ChkVND.TabIndex = 8
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(221, 144)
        Me.ChkNT.TabIndex = 9
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(107, 28)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 1
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(325, 28)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 2
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(15, 31)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(224, 31)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 186)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(668, 9)
        Me.GroupBoxLine.TabIndex = 14
        Me.GroupBoxLine.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 443
        Me.Label6.Tag = "Type"
        Me.Label6.Text = "Loại lệnh"
        '
        'CbbLoai_Phieu
        '
        Me.CbbLoai_Phieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbLoai_Phieu.ForeColor = System.Drawing.Color.Navy
        Me.CbbLoai_Phieu.FormattingEnabled = True
        Me.CbbLoai_Phieu.Location = New System.Drawing.Point(107, 5)
        Me.CbbLoai_Phieu.Name = "CbbLoai_Phieu"
        Me.CbbLoai_Phieu.Size = New System.Drawing.Size(213, 21)
        Me.CbbLoai_Phieu.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(15, 55)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 500
        Me.Label11.Tag = "License Plate"
        Me.Label11.Text = "Biển số"
        '
        'Txtten_xe
        '
        Me.Txtten_xe.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_xe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_xe.Enabled = False
        Me.Txtten_xe.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_xe.Location = New System.Drawing.Point(235, 55)
        Me.Txtten_xe.Name = "Txtten_xe"
        Me.Txtten_xe.ReadOnly = True
        Me.Txtten_xe.Size = New System.Drawing.Size(432, 14)
        Me.Txtten_xe.TabIndex = 507
        Me.Txtten_xe.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(15, 77)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 13)
        Me.Label10.TabIndex = 515
        Me.Label10.Tag = "Type car"
        Me.Label10.Text = "Kiểu xe"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(235, 77)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(432, 14)
        Me.TxtTen_Kx.TabIndex = 514
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_KX
        '
        Me.TxtMa_KX._ActilookupPopup = False
        Me.TxtMa_KX.CyberActilookupPopup = True
        Me.TxtMa_KX.Dv_ListDetail = Nothing
        Me.TxtMa_KX.Dv_Master = Nothing
        Me.TxtMa_KX.FilterClient = ""
        Me.TxtMa_KX.FilterSQL = ""
        Me.TxtMa_KX.Location = New System.Drawing.Point(107, 74)
        Me.TxtMa_KX.Name = "TxtMa_KX"
        Me.TxtMa_KX.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KX.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KX.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_KX.TabIndex = 4
        Me.TxtMa_KX.Table_Name = ""
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(107, 52)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(114, 21)
        Me.TxtMa_Xe.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 518
        Me.Label7.Tag = "Color"
        Me.Label7.Text = "Mã màu "
        '
        'txtTen_Mau
        '
        Me.txtTen_Mau.BackColor = System.Drawing.SystemColors.Control
        Me.txtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_Mau.Enabled = False
        Me.txtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Mau.Location = New System.Drawing.Point(232, 100)
        Me.txtTen_Mau.Name = "txtTen_Mau"
        Me.txtTen_Mau.ReadOnly = True
        Me.txtTen_Mau.Size = New System.Drawing.Size(447, 14)
        Me.txtTen_Mau.TabIndex = 517
        Me.txtTen_Mau.TabStop = False
        '
        'TxtMa_mau
        '
        Me.TxtMa_mau._ActilookupPopup = False
        Me.TxtMa_mau.CyberActilookupPopup = True
        Me.TxtMa_mau.Dv_ListDetail = Nothing
        Me.TxtMa_mau.Dv_Master = Nothing
        Me.TxtMa_mau.FilterClient = ""
        Me.TxtMa_mau.FilterSQL = ""
        Me.TxtMa_mau.Location = New System.Drawing.Point(107, 97)
        Me.TxtMa_mau.Name = "TxtMa_mau"
        Me.TxtMa_mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_mau.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_mau.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_mau.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_mau.TabIndex = 5
        Me.TxtMa_mau.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(362, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 522
        Me.Label4.Tag = "Type post to"
        Me.Label4.Text = "Đến mức xử lý"
        '
        'CbbMa_post2
        '
        Me.CbbMa_post2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_post2.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_post2.FormattingEnabled = True
        Me.CbbMa_post2.Location = New System.Drawing.Point(455, 120)
        Me.CbbMa_post2.Name = "CbbMa_post2"
        Me.CbbMa_post2.Size = New System.Drawing.Size(213, 21)
        Me.CbbMa_post2.TabIndex = 7
        '
        'CbbMa_Post1
        '
        Me.CbbMa_Post1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post1.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post1.FormattingEnabled = True
        Me.CbbMa_Post1.Location = New System.Drawing.Point(107, 120)
        Me.CbbMa_Post1.Name = "CbbMa_Post1"
        Me.CbbMa_Post1.Size = New System.Drawing.Size(213, 21)
        Me.CbbMa_Post1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 521
        Me.Label2.Tag = "Type post from"
        Me.Label2.Text = "Từ mức xử lý"
        '
        'RO_07
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(675, 256)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbMa_post2)
        Me.Controls.Add(Me.CbbMa_Post1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtTen_Mau)
        Me.Controls.Add(Me.TxtMa_mau)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtMa_KX)
        Me.Controls.Add(Me.Txtten_xe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CbbLoai_Phieu)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "RO_07"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbLoai_Phieu, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.Txtten_xe, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KX, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_mau, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_post2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CbbLoai_Phieu As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Txtten_xe As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KX As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_mau As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_post2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_Post1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
