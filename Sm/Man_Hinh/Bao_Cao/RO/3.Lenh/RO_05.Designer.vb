<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RO_05
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
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.LabMa_mau = New System.Windows.Forms.Label()
        Me.TxtTen_kx = New System.Windows.Forms.TextBox()
        Me.LabMa_kx = New System.Windows.Forms.Label()
        Me.TxtTen_kh = New System.Windows.Forms.TextBox()
        Me.LabMa_xe = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New Cyber.SmLists.TxtLookup()
        Me.TxtMa_Mau = New Cyber.SmLists.TxtLookup()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CbbMa_post2 = New System.Windows.Forms.ComboBox()
        Me.CbbMa_Post1 = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CbbLoai_Phieu = New System.Windows.Forms.ComboBox()
        CType(Me.TxtMa_Xe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(563, 246)
        Me.ButtExit.TabIndex = 9
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 207)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(562, 21)
        Me.CBBMa_Dvcs.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 210)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(459, 246)
        Me.ButtOK.TabIndex = 8
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 188)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 185)
        Me.ChkVND.TabIndex = 5
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 185)
        Me.ChkNT.TabIndex = 6
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 4)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 30)
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
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(9, 9)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(9, 33)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 229)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(660, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Mau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Mau.Location = New System.Drawing.Point(215, 81)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(388, 13)
        Me.TxtTen_Mau.TabIndex = 154
        Me.TxtTen_Mau.TabStop = False
        '
        'LabMa_mau
        '
        Me.LabMa_mau.AutoSize = True
        Me.LabMa_mau.Location = New System.Drawing.Point(9, 81)
        Me.LabMa_mau.Name = "LabMa_mau"
        Me.LabMa_mau.Size = New System.Drawing.Size(42, 13)
        Me.LabMa_mau.TabIndex = 153
        Me.LabMa_mau.Tag = "Car Color"
        Me.LabMa_mau.Text = "Màu xe"
        '
        'TxtTen_kx
        '
        Me.TxtTen_kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kx.Location = New System.Drawing.Point(215, 57)
        Me.TxtTen_kx.Name = "TxtTen_kx"
        Me.TxtTen_kx.ReadOnly = True
        Me.TxtTen_kx.Size = New System.Drawing.Size(388, 13)
        Me.TxtTen_kx.TabIndex = 152
        Me.TxtTen_kx.TabStop = False
        '
        'LabMa_kx
        '
        Me.LabMa_kx.AutoSize = True
        Me.LabMa_kx.Location = New System.Drawing.Point(9, 57)
        Me.LabMa_kx.Name = "LabMa_kx"
        Me.LabMa_kx.Size = New System.Drawing.Size(42, 13)
        Me.LabMa_kx.TabIndex = 151
        Me.LabMa_kx.Tag = "Car Model"
        Me.LabMa_kx.Text = "Kiểu xe"
        '
        'TxtTen_kh
        '
        Me.TxtTen_kh.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh.Location = New System.Drawing.Point(215, 104)
        Me.TxtTen_kh.Name = "TxtTen_kh"
        Me.TxtTen_kh.ReadOnly = True
        Me.TxtTen_kh.Size = New System.Drawing.Size(388, 13)
        Me.TxtTen_kh.TabIndex = 157
        Me.TxtTen_kh.TabStop = False
        '
        'LabMa_xe
        '
        Me.LabMa_xe.AutoSize = True
        Me.LabMa_xe.Location = New System.Drawing.Point(9, 103)
        Me.LabMa_xe.Name = "LabMa_xe"
        Me.LabMa_xe.Size = New System.Drawing.Size(41, 13)
        Me.LabMa_xe.TabIndex = 156
        Me.LabMa_xe.Tag = "License Plate"
        Me.LabMa_xe.Text = "Biển số"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe._ActilookupPopup = False
        Me.TxtMa_Xe.CyberActilookupPopup = True
        Me.TxtMa_Xe.Dv_ListDetail = Nothing
        Me.TxtMa_Xe.Dv_Master = Nothing
        Me.TxtMa_Xe.FilterClient = ""
        Me.TxtMa_Xe.FilterSQL = ""
        Me.TxtMa_Xe.Location = New System.Drawing.Point(95, 100)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Xe.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Xe.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Xe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Xe.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Xe.TabIndex = 4
        Me.TxtMa_Xe.Table_Name = ""
        '
        'TxtMa_Mau
        '
        Me.TxtMa_Mau._ActilookupPopup = False
        Me.TxtMa_Mau.CyberActilookupPopup = True
        Me.TxtMa_Mau.Dv_ListDetail = Nothing
        Me.TxtMa_Mau.Dv_Master = Nothing
        Me.TxtMa_Mau.FilterClient = ""
        Me.TxtMa_Mau.FilterSQL = ""
        Me.TxtMa_Mau.Location = New System.Drawing.Point(95, 77)
        Me.TxtMa_Mau.Name = "TxtMa_Mau"
        Me.TxtMa_Mau.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Mau.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Mau.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Mau.TabIndex = 3
        Me.TxtMa_Mau.Table_Name = ""
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(95, 54)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtMa_Kx.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Kx.TabIndex = 2
        Me.TxtMa_Kx.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(351, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 443
        Me.Label4.Tag = "Type post to"
        Me.Label4.Text = "Đến mức xử lý"
        '
        'CbbMa_post2
        '
        Me.CbbMa_post2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_post2.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_post2.FormattingEnabled = True
        Me.CbbMa_post2.Location = New System.Drawing.Point(444, 147)
        Me.CbbMa_post2.Name = "CbbMa_post2"
        Me.CbbMa_post2.Size = New System.Drawing.Size(213, 21)
        Me.CbbMa_post2.TabIndex = 441
        '
        'CbbMa_Post1
        '
        Me.CbbMa_Post1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post1.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Post1.FormattingEnabled = True
        Me.CbbMa_Post1.Location = New System.Drawing.Point(95, 147)
        Me.CbbMa_Post1.Name = "CbbMa_Post1"
        Me.CbbMa_Post1.Size = New System.Drawing.Size(213, 21)
        Me.CbbMa_Post1.TabIndex = 440
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(9, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 17)
        Me.Label7.TabIndex = 442
        Me.Label7.Tag = "Type post from "
        Me.Label7.Text = "Từ mức xử lý"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 445
        Me.Label6.Tag = "Command"
        Me.Label6.Text = "Lệnh"
        '
        'CbbLoai_Phieu
        '
        Me.CbbLoai_Phieu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbLoai_Phieu.ForeColor = System.Drawing.Color.Navy
        Me.CbbLoai_Phieu.FormattingEnabled = True
        Me.CbbLoai_Phieu.Location = New System.Drawing.Point(95, 123)
        Me.CbbLoai_Phieu.Name = "CbbLoai_Phieu"
        Me.CbbLoai_Phieu.Size = New System.Drawing.Size(213, 21)
        Me.CbbLoai_Phieu.TabIndex = 444
        '
        'RO_05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(667, 299)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CbbLoai_Phieu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbMa_post2)
        Me.Controls.Add(Me.CbbMa_Post1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.LabMa_xe)
        Me.Controls.Add(Me.TxtMa_Mau)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.LabMa_mau)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.TxtTen_kx)
        Me.Controls.Add(Me.LabMa_kx)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "RO_05"
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
        Me.Controls.SetChildIndex(Me.LabMa_kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kx, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.LabMa_mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.LabMa_xe, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_post2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.CbbLoai_Phieu, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        CType(Me.TxtMa_Xe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents TxtMa_Mau As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_mau As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_kx As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_kx As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_kh As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_xe As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_post2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_Post1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CbbLoai_Phieu As System.Windows.Forms.ComboBox

End Class
