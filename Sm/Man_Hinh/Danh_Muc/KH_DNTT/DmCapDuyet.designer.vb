<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmCapDuyet
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
        Me.txtTen_Cap = New System.Windows.Forms.TextBox()
        Me.TxtEMail = New System.Windows.Forms.TextBox()
        Me.TxtTelePhone = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHo_Ten = New System.Windows.Forms.TextBox()
        Me.TxtUser_Name = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTen_BP = New System.Windows.Forms.TextBox()
        Me.TxtMa_Bp = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtCap = New Cyber.SmLists.TxtLookup()
        Me.LblNgay_Ct = New System.Windows.Forms.Label()
        Me.TxtNgay_HL = New ClsTextBox.txtDate()
        CType(Me.TxtUser_Name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Bp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtCap.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(527, 151)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(425, 151)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(319, 157)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 161)
        Me.ChkActi.TabIndex = 9
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 141)
        Me.GroupBoxLine.Size = New System.Drawing.Size(618, 6)
        '
        'txtTen_Cap
        '
        Me.txtTen_Cap.BackColor = System.Drawing.Color.White
        Me.txtTen_Cap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTen_Cap.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Cap.Location = New System.Drawing.Point(180, 25)
        Me.txtTen_Cap.Name = "txtTen_Cap"
        Me.txtTen_Cap.ReadOnly = True
        Me.txtTen_Cap.Size = New System.Drawing.Size(429, 20)
        Me.txtTen_Cap.TabIndex = 1928
        Me.txtTen_Cap.TabStop = False
        '
        'TxtEMail
        '
        Me.TxtEMail.ForeColor = System.Drawing.Color.Navy
        Me.TxtEMail.Location = New System.Drawing.Point(77, 98)
        Me.TxtEMail.Name = "TxtEMail"
        Me.TxtEMail.Size = New System.Drawing.Size(532, 21)
        Me.TxtEMail.TabIndex = 4
        '
        'TxtTelePhone
        '
        Me.TxtTelePhone.ForeColor = System.Drawing.Color.Navy
        Me.TxtTelePhone.Location = New System.Drawing.Point(77, 119)
        Me.TxtTelePhone.Name = "TxtTelePhone"
        Me.TxtTelePhone.Size = New System.Drawing.Size(532, 21)
        Me.TxtTelePhone.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 1926
        Me.Label5.Tag = "E- Mail"
        Me.Label5.Text = "E- Mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 122)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 1927
        Me.Label3.Tag = "English name"
        Me.Label3.Text = "Điện thoai"
        '
        'txtHo_Ten
        '
        Me.txtHo_Ten.BackColor = System.Drawing.Color.White
        Me.txtHo_Ten.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtHo_Ten.ForeColor = System.Drawing.Color.Navy
        Me.txtHo_Ten.Location = New System.Drawing.Point(180, 73)
        Me.txtHo_Ten.Name = "txtHo_Ten"
        Me.txtHo_Ten.ReadOnly = True
        Me.txtHo_Ten.Size = New System.Drawing.Size(429, 20)
        Me.txtHo_Ten.TabIndex = 1925
        Me.txtHo_Ten.TabStop = False
        '
        'TxtUser_Name
        '
        Me.TxtUser_Name._ActilookupPopup = False
        Me.TxtUser_Name.CyberActilookupPopup = True
        Me.TxtUser_Name.Dv_ListDetail = Nothing
        Me.TxtUser_Name.Dv_Master = Nothing
        Me.TxtUser_Name.FilterClient = ""
        Me.TxtUser_Name.FilterSQL = ""
        Me.TxtUser_Name.Location = New System.Drawing.Point(77, 73)
        Me.TxtUser_Name.Name = "TxtUser_Name"
        Me.TxtUser_Name.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtUser_Name.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtUser_Name.Properties.Appearance.Options.UseFont = True
        Me.TxtUser_Name.Properties.Appearance.Options.UseForeColor = True
        Me.TxtUser_Name.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtUser_Name.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtUser_Name.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtUser_Name.Size = New System.Drawing.Size(97, 20)
        Me.TxtUser_Name.TabIndex = 3
        Me.TxtUser_Name.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(9, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 1924
        Me.Label2.Tag = "Cus code"
        Me.Label2.Text = "User duyệt"
        '
        'txtTen_BP
        '
        Me.txtTen_BP.BackColor = System.Drawing.Color.White
        Me.txtTen_BP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtTen_BP.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_BP.Location = New System.Drawing.Point(180, 47)
        Me.txtTen_BP.Name = "txtTen_BP"
        Me.txtTen_BP.ReadOnly = True
        Me.txtTen_BP.Size = New System.Drawing.Size(429, 20)
        Me.txtTen_BP.TabIndex = 1923
        Me.txtTen_BP.TabStop = False
        '
        'TxtMa_Bp
        '
        Me.TxtMa_Bp._ActilookupPopup = False
        Me.TxtMa_Bp.CyberActilookupPopup = True
        Me.TxtMa_Bp.Dv_ListDetail = Nothing
        Me.TxtMa_Bp.Dv_Master = Nothing
        Me.TxtMa_Bp.FilterClient = ""
        Me.TxtMa_Bp.FilterSQL = ""
        Me.TxtMa_Bp.Location = New System.Drawing.Point(77, 47)
        Me.TxtMa_Bp.Name = "TxtMa_Bp"
        Me.TxtMa_Bp.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_Bp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Bp.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Bp.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Bp.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Bp.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Bp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Bp.Size = New System.Drawing.Size(97, 20)
        Me.TxtMa_Bp.TabIndex = 2
        Me.TxtMa_Bp.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(9, 50)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 1922
        Me.Label4.Tag = "Cus code"
        Me.Label4.Text = "Bộ phận"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1921
        Me.Label1.Tag = "Account"
        Me.Label1.Text = "Cấp duyệt"
        '
        'TxtCap
        '
        Me.TxtCap._ActilookupPopup = False
        Me.TxtCap.CyberActilookupPopup = True
        Me.TxtCap.Dv_ListDetail = Nothing
        Me.TxtCap.Dv_Master = Nothing
        Me.TxtCap.FilterClient = ""
        Me.TxtCap.FilterSQL = ""
        Me.TxtCap.Location = New System.Drawing.Point(77, 26)
        Me.TxtCap.Name = "TxtCap"
        Me.TxtCap.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtCap.Properties.Appearance.Options.UseForeColor = True
        Me.TxtCap.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtCap.Size = New System.Drawing.Size(97, 20)
        Me.TxtCap.TabIndex = 1
        Me.TxtCap.Table_Name = ""
        '
        'LblNgay_Ct
        '
        Me.LblNgay_Ct.AutoSize = True
        Me.LblNgay_Ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.LblNgay_Ct.Location = New System.Drawing.Point(9, 6)
        Me.LblNgay_Ct.Name = "LblNgay_Ct"
        Me.LblNgay_Ct.Size = New System.Drawing.Size(54, 15)
        Me.LblNgay_Ct.TabIndex = 1920
        Me.LblNgay_Ct.Tag = "Voucher date"
        Me.LblNgay_Ct.Text = "Ngày HL"
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.BackColor = System.Drawing.Color.White
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.isEmpty = True
        Me.TxtNgay_HL.Location = New System.Drawing.Point(77, 4)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(97, 21)
        Me.TxtNgay_HL.TabIndex = 0
        Me.TxtNgay_HL.TabStop = False
        Me.TxtNgay_HL.Text = "18/09/2011"
        Me.TxtNgay_HL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_HL.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'DmCapDuyet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(629, 184)
        Me.Controls.Add(Me.txtTen_Cap)
        Me.Controls.Add(Me.TxtEMail)
        Me.Controls.Add(Me.TxtTelePhone)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHo_Ten)
        Me.Controls.Add(Me.TxtUser_Name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTen_BP)
        Me.Controls.Add(Me.TxtMa_Bp)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCap)
        Me.Controls.Add(Me.LblNgay_Ct)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(488, 176)
        Me.Name = "DmCapDuyet"
        Me.Text = "Danh mục lập kế hoạch"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.LblNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtCap, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Bp, 0)
        Me.Controls.SetChildIndex(Me.txtTen_BP, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtUser_Name, 0)
        Me.Controls.SetChildIndex(Me.txtHo_Ten, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTelePhone, 0)
        Me.Controls.SetChildIndex(Me.TxtEMail, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Cap, 0)
        CType(Me.TxtUser_Name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Bp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtCap.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtTen_Cap As System.Windows.Forms.TextBox
    Friend WithEvents TxtEMail As System.Windows.Forms.TextBox
    Friend WithEvents TxtTelePhone As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHo_Ten As System.Windows.Forms.TextBox
    Friend WithEvents TxtUser_Name As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTen_BP As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Bp As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtCap As Cyber.SmLists.TxtLookup
    Friend WithEvents LblNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate

End Class
