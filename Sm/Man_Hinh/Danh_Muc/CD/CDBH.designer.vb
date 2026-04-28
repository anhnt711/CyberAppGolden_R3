<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDBH
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
        Me.txtTon00 = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMa_Vitri = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_vitri = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        Me.TxtTen_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtMa_BH = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_BH = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Vitri.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(787, 239)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 9
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(651, 239)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 8
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(159, 41)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(179, 24)
        Me.TxtMa_Dvcs.TabIndex = 1
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = True
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 226)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(917, 12)
        Me.GroupBoxLine.TabIndex = 11
        '
        'TxtDu_NT00
        '
        Me.TxtDu_NT00.AllowNegative = True
        Me.TxtDu_NT00.Flags = 7680
        Me.TxtDu_NT00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_NT00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_NT00.InputMask = "### ### ### ### ###"
        Me.TxtDu_NT00.Location = New System.Drawing.Point(159, 194)
        Me.TxtDu_NT00.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDu_NT00.MaxWholeDigits = 14
        Me.TxtDu_NT00.Name = "TxtDu_NT00"
        Me.TxtDu_NT00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_NT00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_NT00.Size = New System.Drawing.Size(179, 24)
        Me.TxtDu_NT00.TabIndex = 6
        Me.TxtDu_NT00.Tag = "### ### ### ### ###.##"
        Me.TxtDu_NT00.Text = "0"
        Me.TxtDu_NT00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(4, 196)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 22)
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
        Me.TxtTen_kho.Location = New System.Drawing.Point(348, 106)
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
        Me.lbMa_Phi.Location = New System.Drawing.Point(5, 105)
        Me.lbMa_Phi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(136, 22)
        Me.lbMa_Phi.TabIndex = 262
        Me.lbMa_Phi.Tag = "Warehouse"
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
        Me.TxtMa_kho.Location = New System.Drawing.Point(159, 102)
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
        Me.Label8.Location = New System.Drawing.Point(5, 135)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(136, 22)
        Me.Label8.TabIndex = 277
        Me.Label8.Tag = "Location"
        Me.Label8.Text = "Vị trí"
        '
        'LabMa_CD
        '
        Me.LabMa_CD.Location = New System.Drawing.Point(5, 46)
        Me.LabMa_CD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_CD.Name = "LabMa_CD"
        Me.LabMa_CD.Size = New System.Drawing.Size(136, 19)
        Me.LabMa_CD.TabIndex = 281
        Me.LabMa_CD.Tag = "Acc unit"
        Me.LabMa_CD.Text = "Đơn vị hạch toán"
        '
        'TxtDu00
        '
        Me.TxtDu00.AllowNegative = True
        Me.TxtDu00.Flags = 7680
        Me.TxtDu00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu00.InputMask = "### ### ### ### ###"
        Me.TxtDu00.Location = New System.Drawing.Point(592, 194)
        Me.TxtDu00.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDu00.MaxWholeDigits = 14
        Me.TxtDu00.Name = "TxtDu00"
        Me.TxtDu00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu00.Size = New System.Drawing.Size(179, 24)
        Me.TxtDu00.TabIndex = 7
        Me.TxtDu00.Tag = "### ### ### ### ###.##"
        Me.TxtDu00.Text = "0"
        Me.TxtDu00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtDu00.Visible = False
        '
        'txtTon00
        '
        Me.txtTon00.AllowNegative = True
        Me.txtTon00.Flags = 7680
        Me.txtTon00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txtTon00.ForeColor = System.Drawing.Color.Navy
        Me.txtTon00.InputMask = "### ### ### ### ###"
        Me.txtTon00.Location = New System.Drawing.Point(159, 162)
        Me.txtTon00.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTon00.MaxWholeDigits = 14
        Me.txtTon00.Name = "txtTon00"
        Me.txtTon00.RangeMax = 1.7976931348623157E+308R
        Me.txtTon00.RangeMin = -1.7976931348623157E+308R
        Me.txtTon00.Size = New System.Drawing.Size(179, 24)
        Me.txtTon00.TabIndex = 5
        Me.txtTon00.Tag = "### ### ### ### ###.##"
        Me.txtTon00.Text = "1"
        Me.txtTon00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(417, 196)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(168, 21)
        Me.Label2.TabIndex = 287
        Me.Label2.Tag = "Opening balance VND"
        Me.Label2.Text = "Dư đầu kỳ VND (giá trị)"
        Me.Label2.Visible = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(5, 165)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 22)
        Me.Label6.TabIndex = 286
        Me.Label6.Tag = "Opening stock"
        Me.Label6.Text = "Tồn đầu kỳ (số lượng)"
        '
        'TxtMa_Vitri
        '
        Me.TxtMa_Vitri._ActilookupPopup = False
        Me.TxtMa_Vitri.CyberActilookupPopup = True
        Me.TxtMa_Vitri.Dv_ListDetail = Nothing
        Me.TxtMa_Vitri.Dv_Master = Nothing
        Me.TxtMa_Vitri.FilterClient = ""
        Me.TxtMa_Vitri.FilterSQL = ""
        Me.TxtMa_Vitri.Location = New System.Drawing.Point(159, 132)
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
        Me.TxtTen_vitri.Location = New System.Drawing.Point(348, 136)
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
        Me.Label10.Location = New System.Drawing.Point(5, 12)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 22)
        Me.Label10.TabIndex = 299
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Năm"
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(159, 9)
        Me.TxtNam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(179, 24)
        Me.TxtNam.TabIndex = 0
        Me.TxtNam.TabStop = False
        '
        'TxtTen_Dvcs
        '
        Me.TxtTen_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Dvcs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Dvcs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Dvcs.Location = New System.Drawing.Point(348, 44)
        Me.TxtTen_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Dvcs.Name = "TxtTen_Dvcs"
        Me.TxtTen_Dvcs.ReadOnly = True
        Me.TxtTen_Dvcs.Size = New System.Drawing.Size(569, 17)
        Me.TxtTen_Dvcs.TabIndex = 301
        Me.TxtTen_Dvcs.TabStop = False
        '
        'TxtMa_BH
        '
        Me.TxtMa_BH._ActilookupPopup = False
        Me.TxtMa_BH.CyberActilookupPopup = True
        Me.TxtMa_BH.Dv_ListDetail = Nothing
        Me.TxtMa_BH.Dv_Master = Nothing
        Me.TxtMa_BH.FilterClient = ""
        Me.TxtMa_BH.FilterSQL = ""
        Me.TxtMa_BH.Location = New System.Drawing.Point(159, 72)
        Me.TxtMa_BH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_BH.Name = "TxtMa_BH"
        Me.TxtMa_BH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BH.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_BH.TabIndex = 2
        Me.TxtMa_BH.Table_Name = ""
        '
        'TxtTen_BH
        '
        Me.TxtTen_BH.BackColor = System.Drawing.Color.White
        Me.TxtTen_BH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BH.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_BH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BH.Location = New System.Drawing.Point(348, 76)
        Me.TxtTen_BH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_BH.Name = "TxtTen_BH"
        Me.TxtTen_BH.ReadOnly = True
        Me.TxtTen_BH.Size = New System.Drawing.Size(569, 17)
        Me.TxtTen_BH.TabIndex = 303
        Me.TxtTen_BH.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(5, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 22)
        Me.Label1.TabIndex = 304
        Me.Label1.Tag = "Insurance unit"
        Me.Label1.Text = "Đơn vị bảo hiểm"
        '
        'CDBH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(923, 282)
        Me.Controls.Add(Me.TxtMa_BH)
        Me.Controls.Add(Me.TxtTen_BH)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Dvcs)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtMa_Vitri)
        Me.Controls.Add(Me.TxtTen_vitri)
        Me.Controls.Add(Me.TxtDu00)
        Me.Controls.Add(Me.txtTon00)
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
        Me.Name = "CDBH"
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
        Me.Controls.SetChildIndex(Me.txtTon00, 0)
        Me.Controls.SetChildIndex(Me.TxtDu00, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vitri, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vitri, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BH, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BH, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Vitri.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtTon00 As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Vitri As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_vitri As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BH As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_BH As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
