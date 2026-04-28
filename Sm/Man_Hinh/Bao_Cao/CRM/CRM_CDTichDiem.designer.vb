<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRM_CDTichDiem
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTen_Mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_mau = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Cc = New System.Windows.Forms.Label()
        Me.TxtTen_kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_KX = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(537, 179)
        Me.ButtExit.TabIndex = 10
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(107, 144)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(526, 21)
        Me.CBBMa_Dvcs.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(17, 149)
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(434, 179)
        Me.ButtOK.TabIndex = 9
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(17, 126)
        Me.LabLoai_NT.Size = New System.Drawing.Size(62, 13)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(107, 124)
        Me.ChkVND.TabIndex = 6
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(221, 124)
        Me.ChkNT.TabIndex = 7
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(107, 3)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(107, 26)
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
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(17, 7)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(17, 30)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 163)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(634, 9)
        Me.GroupBoxLine.TabIndex = 14
        Me.GroupBoxLine.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(17, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 500
        Me.Label11.Tag = "Staff"
        Me.Label11.Text = "Biển số"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(107, 97)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(114, 21)
        Me.TxtMa_Xe.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(17, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 506
        Me.Label6.Tag = "Color"
        Me.Label6.Text = "Mã màu "
        '
        'txtTen_Mau
        '
        Me.txtTen_Mau.BackColor = System.Drawing.SystemColors.Control
        Me.txtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_Mau.Enabled = False
        Me.txtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Mau.Location = New System.Drawing.Point(228, 75)
        Me.txtTen_Mau.Name = "txtTen_Mau"
        Me.txtTen_Mau.ReadOnly = True
        Me.txtTen_Mau.Size = New System.Drawing.Size(404, 14)
        Me.txtTen_Mau.TabIndex = 505
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
        Me.TxtMa_mau.Location = New System.Drawing.Point(107, 74)
        Me.TxtMa_mau.Name = "TxtMa_mau"
        Me.TxtMa_mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_mau.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_mau.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_mau.Size = New System.Drawing.Size(113, 20)
        Me.TxtMa_mau.TabIndex = 4
        Me.TxtMa_mau.Table_Name = ""
        '
        'LabMa_Cc
        '
        Me.LabMa_Cc.Location = New System.Drawing.Point(17, 54)
        Me.LabMa_Cc.Name = "LabMa_Cc"
        Me.LabMa_Cc.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_Cc.TabIndex = 504
        Me.LabMa_Cc.Tag = "Car type"
        Me.LabMa_Cc.Text = "Mã kiểu xe"
        '
        'TxtTen_kx
        '
        Me.TxtTen_kx.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kx.Enabled = False
        Me.TxtTen_kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kx.Location = New System.Drawing.Point(228, 51)
        Me.TxtTen_kx.Name = "TxtTen_kx"
        Me.TxtTen_kx.ReadOnly = True
        Me.TxtTen_kx.Size = New System.Drawing.Size(404, 14)
        Me.TxtTen_kx.TabIndex = 503
        Me.TxtTen_kx.TabStop = False
        '
        'TxtMa_KX
        '
        Me.TxtMa_KX._ActilookupPopup = False
        Me.TxtMa_KX.CyberActilookupPopup = True
        Me.TxtMa_KX.Dv_ListDetail = Nothing
        Me.TxtMa_KX.Dv_Master = Nothing
        Me.TxtMa_KX.FilterClient = ""
        Me.TxtMa_KX.FilterSQL = ""
        Me.TxtMa_KX.Location = New System.Drawing.Point(107, 50)
        Me.TxtMa_KX.Name = "TxtMa_KX"
        Me.TxtMa_KX.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KX.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KX.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_KX.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_KX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KX.Size = New System.Drawing.Size(113, 20)
        Me.TxtMa_KX.TabIndex = 2
        Me.TxtMa_KX.Table_Name = ""
        '
        'CRM_CDTichDiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(641, 233)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTen_Mau)
        Me.Controls.Add(Me.TxtMa_mau)
        Me.Controls.Add(Me.LabMa_Cc)
        Me.Controls.Add(Me.TxtTen_kx)
        Me.Controls.Add(Me.TxtMa_KX)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "CRM_CDTichDiem"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KX, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kx, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_mau, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        CType(Me.TxtMa_mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_mau As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Cc As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KX As Cyber.SmLists.TxtLookup

End Class
