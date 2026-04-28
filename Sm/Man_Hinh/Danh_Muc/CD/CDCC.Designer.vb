<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDCC
    Inherits Cyber.From.FrmList

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
        Me.TxtDu_NT00 = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabMa_CD = New System.Windows.Forms.Label()
        Me.TxtDu00 = New ClsTextBox.txtTien_NT()
        Me.TxtTon00 = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMa_cc = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_cc = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtMa_Vitri = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_vitri = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_cc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Vitri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(829, 239)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(693, 239)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 13
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(751, 231)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(179, 24)
        Me.TxtMa_Dvcs.TabIndex = 0
        Me.TxtMa_Dvcs.TabStop = False
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(147, 252)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 12
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(1, 226)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(960, 12)
        Me.GroupBoxLine.TabIndex = 11
        '
        'TxtDu_NT00
        '
        Me.TxtDu_NT00.AllowNegative = True
        Me.TxtDu_NT00.Flags = 7680
        Me.TxtDu_NT00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_NT00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_NT00.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_NT00.Location = New System.Drawing.Point(195, 199)
        Me.TxtDu_NT00.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDu_NT00.MaxWholeDigits = 17
        Me.TxtDu_NT00.Name = "TxtDu_NT00"
        Me.TxtDu_NT00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_NT00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_NT00.Size = New System.Drawing.Size(179, 24)
        Me.TxtDu_NT00.TabIndex = 7
        Me.TxtDu_NT00.Tag = "### ### ### ### ###.##"
        Me.TxtDu_NT00.Text = "0.00"
        Me.TxtDu_NT00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(19, 199)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 22)
        Me.Label3.TabIndex = 263
        Me.Label3.Tag = "Opening balance"
        Me.Label3.Text = "Dư đầu kỳ (Giá trị)"
        '
        'TxtTen_kho
        '
        Me.TxtTen_kho.BackColor = System.Drawing.Color.White
        Me.TxtTen_kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kho.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kho.Location = New System.Drawing.Point(388, 115)
        Me.TxtTen_kho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(569, 17)
        Me.TxtTen_kho.TabIndex = 260
        Me.TxtTen_kho.TabStop = False
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbMa_Phi.ForeColor = System.Drawing.Color.Navy
        Me.lbMa_Phi.Location = New System.Drawing.Point(19, 114)
        Me.lbMa_Phi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(133, 22)
        Me.lbMa_Phi.TabIndex = 262
        Me.lbMa_Phi.Tag = "Account"
        Me.lbMa_Phi.Text = "Kho"
        '
        'TxtMa_kho
        '
        Me.TxtMa_kho._ActilookupPopup = False
        Me.TxtMa_kho.CyberActilookupPopup = True
        Me.TxtMa_kho.Dv_ListDetail = Nothing
        Me.TxtMa_kho.Dv_Master = Nothing
        Me.TxtMa_kho.FilterClient = ""
        Me.TxtMa_kho.FilterSQL = ""
        Me.TxtMa_kho.Location = New System.Drawing.Point(195, 111)
        Me.TxtMa_kho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_kho.TabIndex = 3
        Me.TxtMa_kho.Table_Name = ""
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(7, 246)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(625, 29)
        Me.Label12.TabIndex = 12
        Me.Label12.Tag = "Note: Year starts balance inserts into balance sheet"
        Me.Label12.Text = "Ghi chú: Số dư đầu năm để lên bảng cân đối kế toán"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(19, 143)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(159, 22)
        Me.Label8.TabIndex = 277
        Me.Label8.Tag = "Currency"
        Me.Label8.Text = "Vị trí"
        '
        'LabMa_CD
        '
        Me.LabMa_CD.Location = New System.Drawing.Point(19, 58)
        Me.LabMa_CD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_CD.Name = "LabMa_CD"
        Me.LabMa_CD.Size = New System.Drawing.Size(133, 18)
        Me.LabMa_CD.TabIndex = 281
        Me.LabMa_CD.Tag = "Producing process"
        Me.LabMa_CD.Text = "Đơn vị hạch toán"
        '
        'TxtDu00
        '
        Me.TxtDu00.AllowNegative = True
        Me.TxtDu00.Flags = 7680
        Me.TxtDu00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu00.InputMask = "### ### ### ### ###.##"
        Me.TxtDu00.Location = New System.Drawing.Point(587, 199)
        Me.TxtDu00.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDu00.MaxWholeDigits = 17
        Me.TxtDu00.Name = "TxtDu00"
        Me.TxtDu00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu00.Size = New System.Drawing.Size(179, 24)
        Me.TxtDu00.TabIndex = 6
        Me.TxtDu00.Tag = "### ### ### ### ###.##"
        Me.TxtDu00.Text = "0.00"
        Me.TxtDu00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDu00.Visible = False
        '
        'TxtTon00
        '
        Me.TxtTon00.AllowNegative = True
        Me.TxtTon00.Flags = 7680
        Me.TxtTon00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTon00.ForeColor = System.Drawing.Color.Navy
        Me.TxtTon00.InputMask = "### ### ### ### ###.##"
        Me.TxtTon00.Location = New System.Drawing.Point(195, 169)
        Me.TxtTon00.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTon00.MaxWholeDigits = 17
        Me.TxtTon00.Name = "TxtTon00"
        Me.TxtTon00.RangeMax = 1.7976931348623157E+308R
        Me.TxtTon00.RangeMin = -1.7976931348623157E+308R
        Me.TxtTon00.Size = New System.Drawing.Size(179, 24)
        Me.TxtTon00.TabIndex = 5
        Me.TxtTon00.Tag = "### ### ### ### ###.##"
        Me.TxtTon00.Text = "0.00"
        Me.TxtTon00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(411, 199)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 22)
        Me.Label2.TabIndex = 287
        Me.Label2.Tag = "Opening balance (VND)"
        Me.Label2.Text = "Dư đầu kỳ VND (giá trị)"
        Me.Label2.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(19, 171)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 22)
        Me.Label6.TabIndex = 286
        Me.Label6.Tag = "Opening stock"
        Me.Label6.Text = "Tồn đầu kỳ (số lượng)"
        '
        'TxtMa_cc
        '
        Me.TxtMa_cc._ActilookupPopup = False
        Me.TxtMa_cc.CyberActilookupPopup = True
        Me.TxtMa_cc.Dv_ListDetail = Nothing
        Me.TxtMa_cc.Dv_Master = Nothing
        Me.TxtMa_cc.FilterClient = ""
        Me.TxtMa_cc.FilterSQL = ""
        Me.TxtMa_cc.Location = New System.Drawing.Point(195, 82)
        Me.TxtMa_cc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_cc.Name = "TxtMa_cc"
        Me.TxtMa_cc.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_cc.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_cc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_cc.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_cc.TabIndex = 2
        Me.TxtMa_cc.Table_Name = ""
        '
        'TxtTen_cc
        '
        Me.TxtTen_cc.BackColor = System.Drawing.Color.White
        Me.TxtTen_cc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_cc.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_cc.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_cc.Location = New System.Drawing.Point(388, 86)
        Me.TxtTen_cc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_cc.Name = "TxtTen_cc"
        Me.TxtTen_cc.ReadOnly = True
        Me.TxtTen_cc.Size = New System.Drawing.Size(569, 17)
        Me.TxtTen_cc.TabIndex = 294
        Me.TxtTen_cc.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(19, 85)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 22)
        Me.Label11.TabIndex = 295
        Me.Label11.Tag = "Account"
        Me.Label11.Text = "Công cụ"
        '
        'TxtMa_Vitri
        '
        Me.TxtMa_Vitri._ActilookupPopup = False
        Me.TxtMa_Vitri.CyberActilookupPopup = True
        Me.TxtMa_Vitri.Dv_ListDetail = Nothing
        Me.TxtMa_Vitri.Dv_Master = Nothing
        Me.TxtMa_Vitri.FilterClient = ""
        Me.TxtMa_Vitri.FilterSQL = ""
        Me.TxtMa_Vitri.Location = New System.Drawing.Point(195, 140)
        Me.TxtMa_Vitri.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Vitri.Name = "TxtMa_Vitri"
        Me.TxtMa_Vitri.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vitri.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vitri.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vitri.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_Vitri.TabIndex = 4
        Me.TxtMa_Vitri.Table_Name = ""
        '
        'TxtTen_vitri
        '
        Me.TxtTen_vitri.BackColor = System.Drawing.Color.White
        Me.TxtTen_vitri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_vitri.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_vitri.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_vitri.Location = New System.Drawing.Point(388, 144)
        Me.TxtTen_vitri.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_vitri.Name = "TxtTen_vitri"
        Me.TxtTen_vitri.ReadOnly = True
        Me.TxtTen_vitri.Size = New System.Drawing.Size(569, 17)
        Me.TxtTen_vitri.TabIndex = 297
        Me.TxtTen_vitri.TabStop = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(19, 25)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 22)
        Me.Label10.TabIndex = 299
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Năm"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDien_Giai.Enabled = False
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(195, 52)
        Me.TxtDien_Giai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(179, 24)
        Me.TxtDien_Giai.TabIndex = 1
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(195, 22)
        Me.TxtNam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(179, 24)
        Me.TxtNam.TabIndex = 0
        Me.TxtNam.TabStop = False
        '
        'CDCC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(965, 282)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtMa_Vitri)
        Me.Controls.Add(Me.TxtTen_vitri)
        Me.Controls.Add(Me.TxtMa_cc)
        Me.Controls.Add(Me.TxtTen_cc)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtDu00)
        Me.Controls.Add(Me.TxtTon00)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabMa_CD)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.TxtDu_NT00)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "CDCC"
        Me.Tb_Name = "Open"
        Me.Text = "Số dư đầu kỳ tài khoản"
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_NT00, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.LabMa_CD, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTon00, 0)
        Me.Controls.SetChildIndex(Me.TxtDu00, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_cc, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_cc, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vitri, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vitri, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_cc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Vitri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDu_NT00 As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents LabMa_CD As System.Windows.Forms.Label
    Friend WithEvents TxtDu00 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTon00 As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_cc As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_cc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Vitri As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_vitri As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Giai As System.Windows.Forms.TextBox
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox

End Class
