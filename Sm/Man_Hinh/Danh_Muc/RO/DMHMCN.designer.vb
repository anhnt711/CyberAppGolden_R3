<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMHMCN
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
        Me.LabMa_vt = New System.Windows.Forms.Label()
        Me.TxtTen_Kh = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.TxtNgay_CT1 = New ClsTextBox.txtDate1()
        Me.TxtHan_Muc = New ClsTextBox.txtTy_Gia()
        Me.TxtSo_ngay = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt2 = New System.Windows.Forms.Label()
        Me.LabGia_nt3 = New System.Windows.Forms.Label()
        Me.TxtNgay_CT2 = New ClsTextBox.txtDate1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGhi_Chu = New System.Windows.Forms.RichTextBox()
        Me.TxtSo_CV = New System.Windows.Forms.TextBox()
        Me.txtLai_Suat = New ClsTextBox.txtTien_NT()
        Me.ChkIs_End = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtten_DVCS = New System.Windows.Forms.TextBox()
        Me.LabNgay_Ct2 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(597, 261)
        Me.ButtExit.TabIndex = 13
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(495, 261)
        Me.ButtOK.TabIndex = 12
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(121, 11)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_Dvcs.TabIndex = 0
        Me.TxtMa_Dvcs.Visible = True
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(119, 270)
        Me.ChkActi.TabIndex = 11
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 251)
        Me.GroupBoxLine.Size = New System.Drawing.Size(695, 9)
        Me.GroupBoxLine.TabIndex = 10
        '
        'LabMa_vt
        '
        Me.LabMa_vt.Location = New System.Drawing.Point(16, 38)
        Me.LabMa_vt.Name = "LabMa_vt"
        Me.LabMa_vt.Size = New System.Drawing.Size(89, 13)
        Me.LabMa_vt.TabIndex = 20
        Me.LabMa_vt.Tag = "Item code"
        Me.LabMa_vt.Text = "Mã khách hàng"
        '
        'TxtTen_Kh
        '
        Me.TxtTen_Kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kh.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kh.Enabled = False
        Me.TxtTen_Kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kh.Location = New System.Drawing.Point(274, 37)
        Me.TxtTen_Kh.Name = "TxtTen_Kh"
        Me.TxtTen_Kh.ReadOnly = True
        Me.TxtTen_Kh.Size = New System.Drawing.Size(406, 14)
        Me.TxtTen_Kh.TabIndex = 382
        Me.TxtTen_Kh.TabStop = False
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(121, 34)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_Kh.TabIndex = 1
        Me.TxtMa_Kh.Table_Name = ""
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.Location = New System.Drawing.Point(16, 60)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(89, 14)
        Me.LabNgay_ban.TabIndex = 29
        Me.LabNgay_ban.Tag = "Date"
        Me.LabNgay_ban.Text = "Từ ngày"
        '
        'TxtNgay_CT1
        '
        Me.TxtNgay_CT1.Flags = 65536
        Me.TxtNgay_CT1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_CT1.IsAllowResize = False
        Me.TxtNgay_CT1.isEmpty = True
        Me.TxtNgay_CT1.Location = New System.Drawing.Point(121, 57)
        Me.TxtNgay_CT1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_CT1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_CT1.MaxLength = 10
        Me.TxtNgay_CT1.Name = "TxtNgay_CT1"
        Me.TxtNgay_CT1.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_CT1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CT1.ShowDayBeforeMonth = False
        Me.TxtNgay_CT1.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_CT1.TabIndex = 2
        Me.TxtNgay_CT1.Text = "07/09/2011"
        Me.TxtNgay_CT1.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtHan_Muc
        '
        Me.TxtHan_Muc.AllowNegative = True
        Me.TxtHan_Muc.Flags = 7680
        Me.TxtHan_Muc.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtHan_Muc.ForeColor = System.Drawing.Color.Navy
        Me.TxtHan_Muc.InputMask = "### ### ### ### ###"
        Me.TxtHan_Muc.Location = New System.Drawing.Point(121, 105)
        Me.TxtHan_Muc.MaxWholeDigits = 14
        Me.TxtHan_Muc.Name = "TxtHan_Muc"
        Me.TxtHan_Muc.RangeMax = 1.7976931348623157E+308R
        Me.TxtHan_Muc.RangeMin = -1.7976931348623157E+308R
        Me.TxtHan_Muc.Size = New System.Drawing.Size(149, 21)
        Me.TxtHan_Muc.TabIndex = 5
        Me.TxtHan_Muc.Text = "1"
        Me.TxtHan_Muc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtSo_ngay
        '
        Me.TxtSo_ngay.AllowNegative = True
        Me.TxtSo_ngay.Flags = 7680
        Me.TxtSo_ngay.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_ngay.InputMask = "### ### ### ### ###"
        Me.TxtSo_ngay.Location = New System.Drawing.Point(121, 128)
        Me.TxtSo_ngay.MaxWholeDigits = 14
        Me.TxtSo_ngay.Name = "TxtSo_ngay"
        Me.TxtSo_ngay.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_ngay.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_ngay.Size = New System.Drawing.Size(149, 21)
        Me.TxtSo_ngay.TabIndex = 6
        Me.TxtSo_ngay.Text = "1"
        Me.TxtSo_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt2
        '
        Me.LabGia_nt2.Location = New System.Drawing.Point(16, 108)
        Me.LabGia_nt2.Name = "LabGia_nt2"
        Me.LabGia_nt2.Size = New System.Drawing.Size(96, 14)
        Me.LabGia_nt2.TabIndex = 30
        Me.LabGia_nt2.Tag = "Date"
        Me.LabGia_nt2.Text = "Hạn mức"
        '
        'LabGia_nt3
        '
        Me.LabGia_nt3.Location = New System.Drawing.Point(16, 131)
        Me.LabGia_nt3.Name = "LabGia_nt3"
        Me.LabGia_nt3.Size = New System.Drawing.Size(89, 14)
        Me.LabGia_nt3.TabIndex = 6
        Me.LabGia_nt3.Tag = "Date"
        Me.LabGia_nt3.Text = "Số ngày quá hạn"
        '
        'TxtNgay_CT2
        '
        Me.TxtNgay_CT2.Flags = 65536
        Me.TxtNgay_CT2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_CT2.IsAllowResize = False
        Me.TxtNgay_CT2.isEmpty = True
        Me.TxtNgay_CT2.Location = New System.Drawing.Point(121, 81)
        Me.TxtNgay_CT2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_CT2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_CT2.MaxLength = 10
        Me.TxtNgay_CT2.Name = "TxtNgay_CT2"
        Me.TxtNgay_CT2.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_CT2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CT2.ShowDayBeforeMonth = False
        Me.TxtNgay_CT2.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_CT2.TabIndex = 4
        Me.TxtNgay_CT2.Text = "07/09/2011"
        Me.TxtNgay_CT2.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 14)
        Me.Label1.TabIndex = 431
        Me.Label1.Tag = "Date"
        Me.Label1.Text = "Lãi suất trả chậm"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 14)
        Me.Label3.TabIndex = 433
        Me.Label3.Tag = "Date"
        Me.Label3.Text = "Số công văn"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 214)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 14)
        Me.Label4.TabIndex = 434
        Me.Label4.Tag = "Date"
        Me.Label4.Text = "Ghi chú"
        '
        'TxtGhi_Chu
        '
        Me.TxtGhi_Chu.Location = New System.Drawing.Point(121, 197)
        Me.TxtGhi_Chu.Name = "TxtGhi_Chu"
        Me.TxtGhi_Chu.Size = New System.Drawing.Size(564, 48)
        Me.TxtGhi_Chu.TabIndex = 9
        Me.TxtGhi_Chu.Text = ""
        '
        'TxtSo_CV
        '
        Me.TxtSo_CV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_CV.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_CV.Location = New System.Drawing.Point(121, 174)
        Me.TxtSo_CV.Name = "TxtSo_CV"
        Me.TxtSo_CV.Size = New System.Drawing.Size(149, 21)
        Me.TxtSo_CV.TabIndex = 8
        '
        'txtLai_Suat
        '
        Me.txtLai_Suat.AllowNegative = True
        Me.txtLai_Suat.Flags = 7680
        Me.txtLai_Suat.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtLai_Suat.ForeColor = System.Drawing.Color.Navy
        Me.txtLai_Suat.InputMask = "### ### ### ### ###.##"
        Me.txtLai_Suat.Location = New System.Drawing.Point(121, 151)
        Me.txtLai_Suat.MaxWholeDigits = 17
        Me.txtLai_Suat.Name = "txtLai_Suat"
        Me.txtLai_Suat.RangeMax = 1.7976931348623157E+308R
        Me.txtLai_Suat.RangeMin = -1.7976931348623157E+308R
        Me.txtLai_Suat.Size = New System.Drawing.Size(76, 21)
        Me.txtLai_Suat.TabIndex = 7
        Me.txtLai_Suat.Tag = "### ### ### ### ###.##"
        Me.txtLai_Suat.Text = "0.00"
        Me.txtLai_Suat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChkIs_End
        '
        Me.ChkIs_End.AutoSize = True
        Me.ChkIs_End.ForeColor = System.Drawing.Color.Navy
        Me.ChkIs_End.Location = New System.Drawing.Point(274, 83)
        Me.ChkIs_End.Name = "ChkIs_End"
        Me.ChkIs_End.Size = New System.Drawing.Size(93, 17)
        Me.ChkIs_End.TabIndex = 3
        Me.ChkIs_End.TabStop = False
        Me.ChkIs_End.Tag = "Tel, time"
        Me.ChkIs_End.Text = "Ngày đến hạn"
        Me.ChkIs_End.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 13)
        Me.Label5.TabIndex = 439
        Me.Label5.Tag = "Item code"
        Me.Label5.Text = "Đơn vị"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(203, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 14)
        Me.Label2.TabIndex = 440
        Me.Label2.Tag = "Date"
        Me.Label2.Text = "%"
        '
        'Txtten_DVCS
        '
        Me.Txtten_DVCS.BackColor = System.Drawing.Color.White
        Me.Txtten_DVCS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_DVCS.Enabled = False
        Me.Txtten_DVCS.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_DVCS.Location = New System.Drawing.Point(274, 14)
        Me.Txtten_DVCS.Name = "Txtten_DVCS"
        Me.Txtten_DVCS.ReadOnly = True
        Me.Txtten_DVCS.Size = New System.Drawing.Size(406, 14)
        Me.Txtten_DVCS.TabIndex = 441
        Me.Txtten_DVCS.TabStop = False
        '
        'LabNgay_Ct2
        '
        Me.LabNgay_Ct2.Location = New System.Drawing.Point(16, 84)
        Me.LabNgay_Ct2.Name = "LabNgay_Ct2"
        Me.LabNgay_Ct2.Size = New System.Drawing.Size(89, 14)
        Me.LabNgay_Ct2.TabIndex = 442
        Me.LabNgay_Ct2.Tag = "Date"
        Me.LabNgay_Ct2.Text = "Đến ngày"
        '
        'DMHMCN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(699, 294)
        Me.Controls.Add(Me.LabNgay_Ct2)
        Me.Controls.Add(Me.Txtten_DVCS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ChkIs_End)
        Me.Controls.Add(Me.txtLai_Suat)
        Me.Controls.Add(Me.TxtSo_CV)
        Me.Controls.Add(Me.TxtGhi_Chu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNgay_CT2)
        Me.Controls.Add(Me.LabGia_nt3)
        Me.Controls.Add(Me.TxtSo_ngay)
        Me.Controls.Add(Me.TxtHan_Muc)
        Me.Controls.Add(Me.LabGia_nt2)
        Me.Controls.Add(Me.TxtNgay_CT1)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.TxtTen_Kh)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.LabMa_vt)
        Me.KeyPreview = True
        Me.Name = "DMHMCN"
        Me.Controls.SetChildIndex(Me.LabMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kh, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CT1, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt2, 0)
        Me.Controls.SetChildIndex(Me.TxtHan_Muc, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_ngay, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt3, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CT2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtGhi_Chu, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_CV, 0)
        Me.Controls.SetChildIndex(Me.txtLai_Suat, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_End, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Txtten_DVCS, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ct2, 0)
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_vt As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kh As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_CT1 As ClsTextBox.txtDate1
    Friend WithEvents TxtHan_Muc As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtSo_ngay As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt2 As System.Windows.Forms.Label
    Friend WithEvents LabGia_nt3 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_CT2 As ClsTextBox.txtDate1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtGhi_Chu As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtSo_CV As System.Windows.Forms.TextBox
    Friend WithEvents txtLai_Suat As ClsTextBox.txtTien_NT
    Friend WithEvents ChkIs_End As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtten_DVCS As System.Windows.Forms.TextBox
    Friend WithEvents LabNgay_Ct2 As System.Windows.Forms.Label

End Class
