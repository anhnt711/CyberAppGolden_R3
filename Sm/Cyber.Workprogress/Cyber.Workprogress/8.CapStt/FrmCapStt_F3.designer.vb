<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCapStt_F3
    Inherits Cyber.From.FrmCalculator

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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Lx = New System.Windows.Forms.TextBox()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.txtTen_KH = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNgay_Hen = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.LblNgay_Ct = New System.Windows.Forms.Label()
        Me.Chkis_Hen = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDt_LX = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtStt1 = New System.Windows.Forms.TextBox()
        Me.TxtNgay_Ct = New ClsTextBox.txtDate()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.Txtdate = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.CbbMa_Post = New System.Windows.Forms.ComboBox()
        Me.TxtLan_Goi = New System.Windows.Forms.TextBox()
        Me.TxtLan1 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtLan2 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtLan3 = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.CbbMa_Quay = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 211)
        Me.GroupBoxLine.Size = New System.Drawing.Size(717, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Image = Global.Cyber.Workprogress.My.Resources.Resources.saveall_32x32
        Me.ButtOK.Location = New System.Drawing.Point(517, 229)
        Me.ButtOK.TabIndex = 5
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(619, 229)
        Me.ButtExit.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(9, 146)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 15)
        Me.Label8.TabIndex = 2094
        Me.Label8.Tag = "Request"
        Me.Label8.Text = "ND SC"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(9, 80)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 2093
        Me.Label6.Tag = "Customer"
        Me.Label6.Text = "Khách hàng"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(9, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 15)
        Me.Label2.TabIndex = 2092
        Me.Label2.Tag = "Driver"
        Me.Label2.Text = "Lái xe"
        '
        'TxtTen_Lx
        '
        Me.TxtTen_Lx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Lx.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_Lx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Lx.Location = New System.Drawing.Point(89, 50)
        Me.TxtTen_Lx.Name = "TxtTen_Lx"
        Me.TxtTen_Lx.Size = New System.Drawing.Size(345, 26)
        Me.TxtTen_Lx.TabIndex = 1
        Me.TxtTen_Lx.Tag = ""
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(89, 146)
        Me.TxtDien_Giai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDien_Giai.Multiline = True
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(629, 50)
        Me.TxtDien_Giai.TabIndex = 4
        Me.TxtDien_Giai.Tag = ""
        '
        'txtTen_KH
        '
        Me.txtTen_KH.BackColor = System.Drawing.Color.White
        Me.txtTen_KH.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen_KH.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_KH.Location = New System.Drawing.Point(89, 80)
        Me.txtTen_KH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTen_KH.Multiline = True
        Me.txtTen_KH.Name = "txtTen_KH"
        Me.txtTen_KH.Size = New System.Drawing.Size(629, 26)
        Me.txtTen_KH.TabIndex = 3
        Me.txtTen_KH.Tag = ""
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(89, 21)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(145, 26)
        Me.TxtMa_Xe.TabIndex = 0
        Me.TxtMa_Xe.Tag = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(9, 24)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 15)
        Me.Label4.TabIndex = 2088
        Me.Label4.Tag = "Plate"
        Me.Label4.Text = "Biển số"
        '
        'TxtNgay_Hen
        '
        Me.TxtNgay_Hen.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Hen.Enabled = False
        Me.TxtNgay_Hen.Flags = 0
        Me.TxtNgay_Hen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_Hen.ForeColor = System.Drawing.Color.Red
        Me.TxtNgay_Hen.IsAllowResize = False
        Me.TxtNgay_Hen.Location = New System.Drawing.Point(89, 113)
        Me.TxtNgay_Hen.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Hen.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_Hen.MaxLength = 10
        Me.TxtNgay_Hen.Name = "TxtNgay_Hen"
        Me.TxtNgay_Hen.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_Hen.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Hen.ReadOnly = True
        Me.TxtNgay_Hen.ShowDayBeforeMonth = False
        Me.TxtNgay_Hen.Size = New System.Drawing.Size(145, 26)
        Me.TxtNgay_Hen.TabIndex = 2096
        Me.TxtNgay_Hen.TabStop = False
        Me.TxtNgay_Hen.Value = "15/02/2023 13:39"
        '
        'LblNgay_Ct
        '
        Me.LblNgay_Ct.AutoSize = True
        Me.LblNgay_Ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNgay_Ct.ForeColor = System.Drawing.Color.Red
        Me.LblNgay_Ct.Location = New System.Drawing.Point(9, 118)
        Me.LblNgay_Ct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNgay_Ct.Name = "LblNgay_Ct"
        Me.LblNgay_Ct.Size = New System.Drawing.Size(52, 15)
        Me.LblNgay_Ct.TabIndex = 2095
        Me.LblNgay_Ct.Tag = "Date"
        Me.LblNgay_Ct.Text = "T/G Hẹn"
        '
        'Chkis_Hen
        '
        Me.Chkis_Hen.AutoSize = True
        Me.Chkis_Hen.Enabled = False
        Me.Chkis_Hen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Chkis_Hen.ForeColor = System.Drawing.Color.Red
        Me.Chkis_Hen.Location = New System.Drawing.Point(239, 118)
        Me.Chkis_Hen.Name = "Chkis_Hen"
        Me.Chkis_Hen.Size = New System.Drawing.Size(65, 19)
        Me.Chkis_Hen.TabIndex = 7307
        Me.Chkis_Hen.TabStop = False
        Me.Chkis_Hen.Tag = "Sche"
        Me.Chkis_Hen.Text = "Xe hẹn"
        Me.Chkis_Hen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Chkis_Hen.UseVisualStyleBackColor = True
        Me.Chkis_Hen.Visible = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(440, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 15)
        Me.Label1.TabIndex = 7309
        Me.Label1.Tag = "Driver"
        Me.Label1.Text = "Điện thoại"
        '
        'TxtDt_LX
        '
        Me.TxtDt_LX.BackColor = System.Drawing.Color.White
        Me.TxtDt_LX.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDt_LX.ForeColor = System.Drawing.Color.Navy
        Me.TxtDt_LX.Location = New System.Drawing.Point(527, 50)
        Me.TxtDt_LX.Name = "TxtDt_LX"
        Me.TxtDt_LX.Size = New System.Drawing.Size(191, 26)
        Me.TxtDt_LX.TabIndex = 2
        Me.TxtDt_LX.Tag = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(440, 24)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 19)
        Me.Label3.TabIndex = 7311
        Me.Label3.Tag = "Driver"
        Me.Label3.Text = "Thứ tự"
        '
        'TxtStt1
        '
        Me.TxtStt1.BackColor = System.Drawing.Color.White
        Me.TxtStt1.Enabled = False
        Me.TxtStt1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt1.ForeColor = System.Drawing.Color.Blue
        Me.TxtStt1.Location = New System.Drawing.Point(527, 21)
        Me.TxtStt1.Name = "TxtStt1"
        Me.TxtStt1.ReadOnly = True
        Me.TxtStt1.Size = New System.Drawing.Size(191, 26)
        Me.TxtStt1.TabIndex = 7310
        Me.TxtStt1.TabStop = False
        Me.TxtStt1.Tag = ""
        '
        'TxtNgay_Ct
        '
        Me.TxtNgay_Ct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtNgay_Ct.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct.Flags = 65536
        Me.TxtNgay_Ct.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct.isEmpty = True
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(12, 234)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct.ReadOnly = True
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(85, 21)
        Me.TxtNgay_Ct.TabIndex = 7312
        Me.TxtNgay_Ct.Text = "18/09/2011"
        Me.TxtNgay_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        Me.TxtNgay_Ct.Visible = False
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.Enabled = False
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Blue
        Me.TxtStt_Rec.Location = New System.Drawing.Point(103, 229)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.ReadOnly = True
        Me.TxtStt_Rec.Size = New System.Drawing.Size(36, 26)
        Me.TxtStt_Rec.TabIndex = 7313
        Me.TxtStt_Rec.Tag = ""
        Me.TxtStt_Rec.Visible = False
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Enabled = False
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(145, 229)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(35, 26)
        Me.TxtMa_Dvcs.TabIndex = 7314
        Me.TxtMa_Dvcs.Tag = ""
        Me.TxtMa_Dvcs.Visible = False
        '
        'Txtdate
        '
        Me.Txtdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Txtdate.BackColor = System.Drawing.Color.White
        Me.Txtdate.Enabled = False
        Me.Txtdate.Flags = 0
        Me.Txtdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtdate.ForeColor = System.Drawing.Color.Red
        Me.Txtdate.IsAllowResize = False
        Me.Txtdate.Location = New System.Drawing.Point(242, 227)
        Me.Txtdate.Margin = New System.Windows.Forms.Padding(0)
        Me.Txtdate.MaskDate = "dd/MM/yyyy HH:mm"
        Me.Txtdate.MaxLength = 10
        Me.Txtdate.Name = "Txtdate"
        Me.Txtdate.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.Txtdate.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Txtdate.ReadOnly = True
        Me.Txtdate.ShowDayBeforeMonth = False
        Me.Txtdate.Size = New System.Drawing.Size(51, 26)
        Me.Txtdate.TabIndex = 7315
        Me.Txtdate.Value = "15/02/2023 13:38"
        Me.Txtdate.Visible = False
        '
        'CbbMa_Post
        '
        Me.CbbMa_Post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Post.Enabled = False
        Me.CbbMa_Post.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbbMa_Post.ForeColor = System.Drawing.Color.Blue
        Me.CbbMa_Post.FormattingEnabled = True
        Me.CbbMa_Post.Location = New System.Drawing.Point(238, 19)
        Me.CbbMa_Post.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_Post.Name = "CbbMa_Post"
        Me.CbbMa_Post.Size = New System.Drawing.Size(196, 28)
        Me.CbbMa_Post.TabIndex = 7316
        Me.CbbMa_Post.TabStop = False
        '
        'TxtLan_Goi
        '
        Me.TxtLan_Goi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtLan_Goi.BackColor = System.Drawing.Color.White
        Me.TxtLan_Goi.Enabled = False
        Me.TxtLan_Goi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLan_Goi.ForeColor = System.Drawing.Color.Blue
        Me.TxtLan_Goi.Location = New System.Drawing.Point(242, 229)
        Me.TxtLan_Goi.Name = "TxtLan_Goi"
        Me.TxtLan_Goi.ReadOnly = True
        Me.TxtLan_Goi.Size = New System.Drawing.Size(41, 26)
        Me.TxtLan_Goi.TabIndex = 7317
        Me.TxtLan_Goi.Tag = ""
        Me.TxtLan_Goi.Visible = False
        '
        'TxtLan1
        '
        Me.TxtLan1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtLan1.BackColor = System.Drawing.Color.White
        Me.TxtLan1.Enabled = False
        Me.TxtLan1.Flags = 0
        Me.TxtLan1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLan1.ForeColor = System.Drawing.Color.Red
        Me.TxtLan1.IsAllowResize = False
        Me.TxtLan1.Location = New System.Drawing.Point(242, 229)
        Me.TxtLan1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtLan1.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtLan1.MaxLength = 10
        Me.TxtLan1.Name = "TxtLan1"
        Me.TxtLan1.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtLan1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtLan1.ReadOnly = True
        Me.TxtLan1.ShowDayBeforeMonth = False
        Me.TxtLan1.Size = New System.Drawing.Size(51, 26)
        Me.TxtLan1.TabIndex = 7318
        Me.TxtLan1.Value = "15/02/2023 13:38"
        Me.TxtLan1.Visible = False
        '
        'TxtLan2
        '
        Me.TxtLan2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtLan2.BackColor = System.Drawing.Color.White
        Me.TxtLan2.Enabled = False
        Me.TxtLan2.Flags = 0
        Me.TxtLan2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLan2.ForeColor = System.Drawing.Color.Red
        Me.TxtLan2.IsAllowResize = False
        Me.TxtLan2.Location = New System.Drawing.Point(242, 229)
        Me.TxtLan2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtLan2.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtLan2.MaxLength = 10
        Me.TxtLan2.Name = "TxtLan2"
        Me.TxtLan2.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtLan2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtLan2.ReadOnly = True
        Me.TxtLan2.ShowDayBeforeMonth = False
        Me.TxtLan2.Size = New System.Drawing.Size(51, 26)
        Me.TxtLan2.TabIndex = 7319
        Me.TxtLan2.Value = "15/02/2023 13:38"
        Me.TxtLan2.Visible = False
        '
        'TxtLan3
        '
        Me.TxtLan3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtLan3.BackColor = System.Drawing.Color.White
        Me.TxtLan3.Enabled = False
        Me.TxtLan3.Flags = 0
        Me.TxtLan3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLan3.ForeColor = System.Drawing.Color.Red
        Me.TxtLan3.IsAllowResize = False
        Me.TxtLan3.Location = New System.Drawing.Point(242, 227)
        Me.TxtLan3.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtLan3.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtLan3.MaxLength = 10
        Me.TxtLan3.Name = "TxtLan3"
        Me.TxtLan3.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtLan3.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtLan3.ReadOnly = True
        Me.TxtLan3.ShowDayBeforeMonth = False
        Me.TxtLan3.Size = New System.Drawing.Size(51, 26)
        Me.TxtLan3.TabIndex = 7320
        Me.TxtLan3.Value = "15/02/2023 13:38"
        Me.TxtLan3.Visible = False
        '
        'CbbMa_Quay
        '
        Me.CbbMa_Quay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Quay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CbbMa_Quay.ForeColor = System.Drawing.Color.Blue
        Me.CbbMa_Quay.FormattingEnabled = True
        Me.CbbMa_Quay.Location = New System.Drawing.Point(526, 111)
        Me.CbbMa_Quay.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_Quay.Name = "CbbMa_Quay"
        Me.CbbMa_Quay.Size = New System.Drawing.Size(192, 28)
        Me.CbbMa_Quay.TabIndex = 7321
        Me.CbbMa_Quay.TabStop = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(440, 118)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 7322
        Me.Label5.Tag = "Driver"
        Me.Label5.Text = "Quầy số"
        '
        'FrmCapStt_F3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(721, 283)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CbbMa_Quay)
        Me.Controls.Add(Me.TxtLan3)
        Me.Controls.Add(Me.TxtLan2)
        Me.Controls.Add(Me.TxtLan1)
        Me.Controls.Add(Me.TxtLan_Goi)
        Me.Controls.Add(Me.CbbMa_Post)
        Me.Controls.Add(Me.Txtdate)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtStt1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDt_LX)
        Me.Controls.Add(Me.Chkis_Hen)
        Me.Controls.Add(Me.TxtNgay_Hen)
        Me.Controls.Add(Me.LblNgay_Ct)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Lx)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.txtTen_KH)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmCapStt_F3"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.txtTen_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Lx, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.LblNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Hen, 0)
        Me.Controls.SetChildIndex(Me.Chkis_Hen, 0)
        Me.Controls.SetChildIndex(Me.TxtDt_LX, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtStt1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Txtdate, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post, 0)
        Me.Controls.SetChildIndex(Me.TxtLan_Goi, 0)
        Me.Controls.SetChildIndex(Me.TxtLan1, 0)
        Me.Controls.SetChildIndex(Me.TxtLan2, 0)
        Me.Controls.SetChildIndex(Me.TxtLan3, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Quay, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Lx As System.Windows.Forms.TextBox
    Friend WithEvents TxtDien_Giai As System.Windows.Forms.TextBox
    Friend WithEvents txtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Hen As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents LblNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents Chkis_Hen As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDt_LX As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtStt1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNgay_Ct As ClsTextBox.txtDate
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents Txtdate As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents CbbMa_Post As System.Windows.Forms.ComboBox
    Friend WithEvents TxtLan_Goi As System.Windows.Forms.TextBox
    Friend WithEvents TxtLan1 As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtLan2 As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtLan3 As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents CbbMa_Quay As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
