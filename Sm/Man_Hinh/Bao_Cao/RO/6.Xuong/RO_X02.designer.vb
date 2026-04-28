<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RO_X02
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
        Me.LabMa_Khoang = New System.Windows.Forms.Label()
        Me.TxtTen_khoang = New System.Windows.Forms.TextBox()
        Me.TxtMa_Khoang = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBBLoai_SC = New System.Windows.Forms.ComboBox()
        Me.TxtSo_RO = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Txtten_xe = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LabSo_Ct1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Khoang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 206)
        Me.ButtExit.TabIndex = 21
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 167)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 170)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 206)
        Me.ButtOK.TabIndex = 20
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(9, 145)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 145)
        Me.ChkVND.TabIndex = 17
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(211, 146)
        Me.ChkNT.TabIndex = 18
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = False
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 26)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct1.TabIndex = 2
        Me.TxtM_Ngay_Ct1.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = False
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 48)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 3
        Me.TxtM_Ngay_Ct2.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(9, 29)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(9, 51)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 189)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_Khoang
        '
        Me.LabMa_Khoang.Location = New System.Drawing.Point(10, 73)
        Me.LabMa_Khoang.Name = "LabMa_Khoang"
        Me.LabMa_Khoang.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_Khoang.TabIndex = 607
        Me.LabMa_Khoang.Tag = "Profit Centers"
        Me.LabMa_Khoang.Text = "Khoang "
        '
        'TxtTen_khoang
        '
        Me.TxtTen_khoang.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_khoang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_khoang.Enabled = False
        Me.TxtTen_khoang.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_khoang.Location = New System.Drawing.Point(216, 73)
        Me.TxtTen_khoang.Name = "TxtTen_khoang"
        Me.TxtTen_khoang.ReadOnly = True
        Me.TxtTen_khoang.Size = New System.Drawing.Size(369, 14)
        Me.TxtTen_khoang.TabIndex = 606
        Me.TxtTen_khoang.TabStop = False
        '
        'TxtMa_Khoang
        '
        Me.TxtMa_Khoang._ActilookupPopup = False
        Me.TxtMa_Khoang.CyberActilookupPopup = True
        Me.TxtMa_Khoang.Dv_ListDetail = Nothing
        Me.TxtMa_Khoang.Dv_Master = Nothing
        Me.TxtMa_Khoang.FilterClient = ""
        Me.TxtMa_Khoang.FilterSQL = ""
        Me.TxtMa_Khoang.Location = New System.Drawing.Point(95, 70)
        Me.TxtMa_Khoang.Name = "TxtMa_Khoang"
        Me.TxtMa_Khoang.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Khoang.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Khoang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Khoang.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_Khoang.TabIndex = 7
        Me.TxtMa_Khoang.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 613
        Me.Label3.Tag = "Account Level"
        Me.Label3.Text = "Loại sữa chữa"
        '
        'CBBLoai_SC
        '
        Me.CBBLoai_SC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBLoai_SC.ForeColor = System.Drawing.Color.Navy
        Me.CBBLoai_SC.FormattingEnabled = True
        Me.CBBLoai_SC.Location = New System.Drawing.Point(96, 4)
        Me.CBBLoai_SC.Name = "CBBLoai_SC"
        Me.CBBLoai_SC.Size = New System.Drawing.Size(113, 21)
        Me.CBBLoai_SC.TabIndex = 0
        '
        'TxtSo_RO
        '
        Me.TxtSo_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_RO.Location = New System.Drawing.Point(95, 92)
        Me.TxtSo_RO.Name = "TxtSo_RO"
        Me.TxtSo_RO.Size = New System.Drawing.Size(114, 21)
        Me.TxtSo_RO.TabIndex = 10
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(95, 114)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(114, 21)
        Me.TxtMa_Xe.TabIndex = 11
        '
        'Txtten_xe
        '
        Me.Txtten_xe.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_xe.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_xe.Enabled = False
        Me.Txtten_xe.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_xe.Location = New System.Drawing.Point(223, 117)
        Me.Txtten_xe.Name = "Txtten_xe"
        Me.Txtten_xe.ReadOnly = True
        Me.Txtten_xe.Size = New System.Drawing.Size(220, 14)
        Me.Txtten_xe.TabIndex = 622
        Me.Txtten_xe.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 621
        Me.Label11.Tag = "Staff"
        Me.Label11.Text = "Biển số"
        '
        'LabSo_Ct1
        '
        Me.LabSo_Ct1.Location = New System.Drawing.Point(10, 95)
        Me.LabSo_Ct1.Name = "LabSo_Ct1"
        Me.LabSo_Ct1.Size = New System.Drawing.Size(82, 15)
        Me.LabSo_Ct1.TabIndex = 620
        Me.LabSo_Ct1.Tag = "Voucher from"
        Me.LabSo_Ct1.Text = "Số lệnh"
        '
        'RO_X02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 259)
        Me.Controls.Add(Me.TxtSo_RO)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Txtten_xe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LabSo_Ct1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBBLoai_SC)
        Me.Controls.Add(Me.LabMa_Khoang)
        Me.Controls.Add(Me.TxtTen_khoang)
        Me.Controls.Add(Me.TxtMa_Khoang)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Name = "RO_X02"
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
        Me.Controls.SetChildIndex(Me.TxtMa_Khoang, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_khoang, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Khoang, 0)
        Me.Controls.SetChildIndex(Me.CBBLoai_SC, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.LabSo_Ct1, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Txtten_xe, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_RO, 0)
        CType(Me.TxtMa_Khoang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_Khoang As System.Windows.Forms.Label
    Friend WithEvents TxtTen_khoang As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Khoang As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CBBLoai_SC As System.Windows.Forms.ComboBox
    Friend WithEvents TxtSo_RO As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Txtten_xe As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents LabSo_Ct1 As System.Windows.Forms.Label

End Class
