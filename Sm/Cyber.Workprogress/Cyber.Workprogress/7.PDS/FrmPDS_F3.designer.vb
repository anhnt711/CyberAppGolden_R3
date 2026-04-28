<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPDS_F3
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
        Me.LabMa_Xe = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.TxtTen_HS = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDien_Thoai = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.txtten_Kx = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTen_Mau = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOng_Ba = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct = New ClsTextBox.txtDate1()
        Me.TxtNgay_Gx = New ClsTextBox.txtDate1()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMa_HD = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTG_SC = New ClsTextBox.txtTien_NT()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtNgay_KT = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_BD = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.CbbMa_khoang = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.TxtMa_Ct = New System.Windows.Forms.TextBox()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.TxtStt_RecHDX = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec0HDX = New System.Windows.Forms.TextBox()
        Me.TxtLoai_kh = New ClsTextBox.txtTien_NT()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 157)
        Me.GroupBoxLine.Size = New System.Drawing.Size(863, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(663, 167)
        Me.ButtOK.TabIndex = 6
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(765, 167)
        Me.ButtExit.TabIndex = 7
        '
        'LabMa_Xe
        '
        Me.LabMa_Xe.AutoSize = True
        Me.LabMa_Xe.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_Xe.ForeColor = System.Drawing.Color.Blue
        Me.LabMa_Xe.Location = New System.Drawing.Point(11, 6)
        Me.LabMa_Xe.Name = "LabMa_Xe"
        Me.LabMa_Xe.Size = New System.Drawing.Size(68, 17)
        Me.LabMa_Xe.TabIndex = 7157
        Me.LabMa_Xe.Tag = "Vin"
        Me.LabMa_Xe.Text = "Số khung"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Xe.Location = New System.Drawing.Point(99, 4)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(155, 23)
        Me.TxtMa_Xe.TabIndex = 0
        Me.TxtMa_Xe.Tag = ""
        '
        'TxtTen_HS
        '
        Me.TxtTen_HS.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTen_HS.Enabled = False
        Me.TxtTen_HS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_HS.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtTen_HS.Location = New System.Drawing.Point(347, 6)
        Me.TxtTen_HS.Name = "TxtTen_HS"
        Me.TxtTen_HS.ReadOnly = True
        Me.TxtTen_HS.Size = New System.Drawing.Size(156, 21)
        Me.TxtTen_HS.TabIndex = 7159
        Me.TxtTen_HS.TabStop = False
        Me.TxtTen_HS.Tag = ""
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DarkRed
        Me.Label9.Location = New System.Drawing.Point(518, 101)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 7165
        Me.Label9.Tag = "Tel"
        Me.Label9.Text = "Tel"
        '
        'TxtDien_Thoai
        '
        Me.TxtDien_Thoai.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtDien_Thoai.Enabled = False
        Me.TxtDien_Thoai.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDien_Thoai.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtDien_Thoai.Location = New System.Drawing.Point(600, 94)
        Me.TxtDien_Thoai.Name = "TxtDien_Thoai"
        Me.TxtDien_Thoai.ReadOnly = True
        Me.TxtDien_Thoai.Size = New System.Drawing.Size(261, 21)
        Me.TxtDien_Thoai.TabIndex = 7164
        Me.TxtDien_Thoai.TabStop = False
        Me.TxtDien_Thoai.Tag = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkRed
        Me.Label2.Location = New System.Drawing.Point(518, 7)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 15)
        Me.Label2.TabIndex = 7163
        Me.Label2.Tag = "Customer"
        Me.Label2.Text = "Khách hàng"
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtTen_KH.Enabled = False
        Me.TxtTen_KH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtTen_KH.Location = New System.Drawing.Point(600, 3)
        Me.TxtTen_KH.Multiline = True
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(261, 63)
        Me.TxtTen_KH.TabIndex = 7162
        Me.TxtTen_KH.TabStop = False
        Me.TxtTen_KH.Tag = ""
        '
        'txtten_Kx
        '
        Me.txtten_Kx.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtten_Kx.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtten_Kx.Enabled = False
        Me.txtten_Kx.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtten_Kx.ForeColor = System.Drawing.Color.DarkRed
        Me.txtten_Kx.Location = New System.Drawing.Point(347, 29)
        Me.txtten_Kx.Margin = New System.Windows.Forms.Padding(4)
        Me.txtten_Kx.Name = "txtten_Kx"
        Me.txtten_Kx.ReadOnly = True
        Me.txtten_Kx.Size = New System.Drawing.Size(156, 21)
        Me.txtten_Kx.TabIndex = 7161
        Me.txtten_Kx.TabStop = False
        Me.txtten_Kx.Tag = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkRed
        Me.Label3.Location = New System.Drawing.Point(274, 7)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 15)
        Me.Label3.TabIndex = 7160
        Me.Label3.Tag = "Consutant"
        Me.Label3.Text = "TVBH"
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.DarkRed
        Me.Label21.Location = New System.Drawing.Point(274, 33)
        Me.Label21.Margin = New System.Windows.Forms.Padding(0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(69, 15)
        Me.Label21.TabIndex = 7158
        Me.Label21.Tag = "Model"
        Me.Label21.Text = "Kiểu xe"
        '
        'txtTen_Mau
        '
        Me.txtTen_Mau.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTen_Mau.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTen_Mau.Enabled = False
        Me.txtTen_Mau.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTen_Mau.ForeColor = System.Drawing.Color.DarkRed
        Me.txtTen_Mau.Location = New System.Drawing.Point(347, 51)
        Me.txtTen_Mau.Margin = New System.Windows.Forms.Padding(4)
        Me.txtTen_Mau.Name = "txtTen_Mau"
        Me.txtTen_Mau.ReadOnly = True
        Me.txtTen_Mau.Size = New System.Drawing.Size(156, 21)
        Me.txtTen_Mau.TabIndex = 7167
        Me.txtTen_Mau.TabStop = False
        Me.txtTen_Mau.Tag = ""
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(274, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 15)
        Me.Label1.TabIndex = 7166
        Me.Label1.Tag = "Color"
        Me.Label1.Text = "Màu xe"
        '
        'txtOng_Ba
        '
        Me.txtOng_Ba.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOng_Ba.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOng_Ba.Enabled = False
        Me.txtOng_Ba.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOng_Ba.ForeColor = System.Drawing.Color.DarkRed
        Me.txtOng_Ba.Location = New System.Drawing.Point(600, 69)
        Me.txtOng_Ba.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOng_Ba.Name = "txtOng_Ba"
        Me.txtOng_Ba.ReadOnly = True
        Me.txtOng_Ba.Size = New System.Drawing.Size(261, 21)
        Me.txtOng_Ba.TabIndex = 7169
        Me.txtOng_Ba.TabStop = False
        Me.txtOng_Ba.Tag = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkRed
        Me.Label4.Location = New System.Drawing.Point(518, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 7168
        Me.Label4.Tag = "Caller"
        Me.Label4.Text = "Liên hệ"
        '
        'TxtNgay_Ct
        '
        Me.TxtNgay_Ct.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_Ct.Enabled = False
        Me.TxtNgay_Ct.Flags = 0
        Me.TxtNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct.IsAllowResize = False
        Me.TxtNgay_Ct.isEmpty = True
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(347, 74)
        Me.TxtNgay_Ct.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Ct.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Ct.ReadOnly = True
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(156, 20)
        Me.TxtNgay_Ct.TabIndex = 7170
        Me.TxtNgay_Ct.Text = "__/__/____"
        Me.TxtNgay_Ct.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtNgay_Gx
        '
        Me.TxtNgay_Gx.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtNgay_Gx.Enabled = False
        Me.TxtNgay_Gx.Flags = 0
        Me.TxtNgay_Gx.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Gx.IsAllowResize = False
        Me.TxtNgay_Gx.isEmpty = True
        Me.TxtNgay_Gx.Location = New System.Drawing.Point(347, 95)
        Me.TxtNgay_Gx.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Gx.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Gx.MaxLength = 10
        Me.TxtNgay_Gx.Name = "TxtNgay_Gx"
        Me.TxtNgay_Gx.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Gx.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Gx.ReadOnly = True
        Me.TxtNgay_Gx.ShowDayBeforeMonth = False
        Me.TxtNgay_Gx.Size = New System.Drawing.Size(156, 20)
        Me.TxtNgay_Gx.TabIndex = 7171
        Me.TxtNgay_Gx.Text = "__/__/____"
        Me.TxtNgay_Gx.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkRed
        Me.Label5.Location = New System.Drawing.Point(274, 101)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 7172
        Me.Label5.Tag = "Delivery date"
        Me.Label5.Text = "Giao xe"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DarkRed
        Me.Label6.Location = New System.Drawing.Point(274, 80)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 15)
        Me.Label6.TabIndex = 7173
        Me.Label6.Tag = "Date Contract"
        Me.Label6.Text = "Hợp đồng"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(11, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 7175
        Me.Label7.Tag = "Contact"
        Me.Label7.Text = "Số HĐ"
        '
        'TxtMa_HD
        '
        Me.TxtMa_HD.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMa_HD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_HD.Enabled = False
        Me.TxtMa_HD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_HD.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_HD.Location = New System.Drawing.Point(99, 31)
        Me.TxtMa_HD.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_HD.Name = "TxtMa_HD"
        Me.TxtMa_HD.ReadOnly = True
        Me.TxtMa_HD.Size = New System.Drawing.Size(155, 23)
        Me.TxtMa_HD.TabIndex = 7174
        Me.TxtMa_HD.Tag = ""
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Blue
        Me.Label13.Location = New System.Drawing.Point(11, 86)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 7183
        Me.Label13.Tag = "Time"
        Me.Label13.Text = "Thời gian"
        '
        'TxtTG_SC
        '
        Me.TxtTG_SC.AllowNegative = True
        Me.TxtTG_SC.BackColor = System.Drawing.Color.White
        Me.TxtTG_SC.Flags = 7680
        Me.TxtTG_SC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTG_SC.ForeColor = System.Drawing.Color.Blue
        Me.TxtTG_SC.InputMask = "### ### ### ### ### ###"
        Me.TxtTG_SC.Location = New System.Drawing.Point(99, 82)
        Me.TxtTG_SC.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTG_SC.MaxWholeDigits = 17
        Me.TxtTG_SC.Name = "TxtTG_SC"
        Me.TxtTG_SC.RangeMax = 1.7976931348623157E+308R
        Me.TxtTG_SC.RangeMin = -1.7976931348623157E+308R
        Me.TxtTG_SC.Size = New System.Drawing.Size(155, 23)
        Me.TxtTG_SC.TabIndex = 2
        Me.TxtTG_SC.Text = "0"
        Me.TxtTG_SC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Blue
        Me.Label15.Location = New System.Drawing.Point(11, 113)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 17)
        Me.Label15.TabIndex = 7181
        Me.Label15.Tag = "Begin"
        Me.Label15.Text = "Bắt đầu"
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(11, 136)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 17)
        Me.Label16.TabIndex = 7182
        Me.Label16.Tag = "End"
        Me.Label16.Text = "Kết thúc"
        '
        'TxtNgay_KT
        '
        Me.TxtNgay_KT.BackColor = System.Drawing.Color.White
        Me.TxtNgay_KT.Flags = 0
        Me.TxtNgay_KT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_KT.IsAllowResize = False
        Me.TxtNgay_KT.Location = New System.Drawing.Point(99, 134)
        Me.TxtNgay_KT.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT.MaxLength = 10
        Me.TxtNgay_KT.Name = "TxtNgay_KT"
        Me.TxtNgay_KT.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT.ShowDayBeforeMonth = False
        Me.TxtNgay_KT.Size = New System.Drawing.Size(155, 23)
        Me.TxtNgay_KT.TabIndex = 4
        Me.TxtNgay_KT.Value = "16/10/2019 17:46"
        '
        'TxtNgay_BD
        '
        Me.TxtNgay_BD.BackColor = System.Drawing.Color.White
        Me.TxtNgay_BD.Flags = 0
        Me.TxtNgay_BD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtNgay_BD.IsAllowResize = False
        Me.TxtNgay_BD.Location = New System.Drawing.Point(99, 107)
        Me.TxtNgay_BD.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD.MaxLength = 10
        Me.TxtNgay_BD.Name = "TxtNgay_BD"
        Me.TxtNgay_BD.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD.ShowDayBeforeMonth = False
        Me.TxtNgay_BD.Size = New System.Drawing.Size(155, 23)
        Me.TxtNgay_BD.TabIndex = 3
        Me.TxtNgay_BD.Value = "16/10/2019 17:46"
        '
        'CbbMa_khoang
        '
        Me.CbbMa_khoang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_khoang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_khoang.ForeColor = System.Drawing.Color.Blue
        Me.CbbMa_khoang.FormattingEnabled = True
        Me.CbbMa_khoang.Location = New System.Drawing.Point(99, 56)
        Me.CbbMa_khoang.Name = "CbbMa_khoang"
        Me.CbbMa_khoang.Size = New System.Drawing.Size(155, 24)
        Me.CbbMa_khoang.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(11, 60)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 17)
        Me.Label8.TabIndex = 7180
        Me.Label8.Tag = "Cabin"
        Me.Label8.Text = "Khoang"
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Enabled = False
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtStt_Rec.Location = New System.Drawing.Point(98, 172)
        Me.TxtStt_Rec.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.ReadOnly = True
        Me.TxtStt_Rec.Size = New System.Drawing.Size(75, 21)
        Me.TxtStt_Rec.TabIndex = 7184
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Tag = ""
        Me.TxtStt_Rec.Visible = False
        '
        'TxtMa_Ct
        '
        Me.TxtMa_Ct.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMa_Ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Ct.Enabled = False
        Me.TxtMa_Ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Ct.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtMa_Ct.Location = New System.Drawing.Point(204, 170)
        Me.TxtMa_Ct.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Ct.Name = "TxtMa_Ct"
        Me.TxtMa_Ct.ReadOnly = True
        Me.TxtMa_Ct.Size = New System.Drawing.Size(75, 21)
        Me.TxtMa_Ct.TabIndex = 7185
        Me.TxtMa_Ct.TabStop = False
        Me.TxtMa_Ct.Tag = ""
        Me.TxtMa_Ct.Visible = False
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtMa_Dvcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Dvcs.Enabled = False
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(303, 167)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(75, 21)
        Me.TxtMa_Dvcs.TabIndex = 7186
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Tag = ""
        Me.TxtMa_Dvcs.Visible = False
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(274, 122)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 15)
        Me.Label10.TabIndex = 7188
        Me.Label10.Tag = "Request"
        Me.Label10.Text = "Ghi chú"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Giai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(347, 122)
        Me.TxtDien_Giai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDien_Giai.Multiline = True
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(514, 21)
        Me.TxtDien_Giai.TabIndex = 5
        Me.TxtDien_Giai.TabStop = False
        Me.TxtDien_Giai.Tag = ""
        '
        'TxtStt_RecHDX
        '
        Me.TxtStt_RecHDX.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtStt_RecHDX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_RecHDX.Enabled = False
        Me.TxtStt_RecHDX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_RecHDX.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtStt_RecHDX.Location = New System.Drawing.Point(386, 170)
        Me.TxtStt_RecHDX.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_RecHDX.Name = "TxtStt_RecHDX"
        Me.TxtStt_RecHDX.ReadOnly = True
        Me.TxtStt_RecHDX.Size = New System.Drawing.Size(75, 21)
        Me.TxtStt_RecHDX.TabIndex = 7189
        Me.TxtStt_RecHDX.TabStop = False
        Me.TxtStt_RecHDX.Tag = ""
        Me.TxtStt_RecHDX.Visible = False
        '
        'TxtStt_Rec0HDX
        '
        Me.TxtStt_Rec0HDX.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtStt_Rec0HDX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec0HDX.Enabled = False
        Me.TxtStt_Rec0HDX.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec0HDX.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtStt_Rec0HDX.Location = New System.Drawing.Point(469, 170)
        Me.TxtStt_Rec0HDX.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec0HDX.Name = "TxtStt_Rec0HDX"
        Me.TxtStt_Rec0HDX.ReadOnly = True
        Me.TxtStt_Rec0HDX.Size = New System.Drawing.Size(75, 21)
        Me.TxtStt_Rec0HDX.TabIndex = 7190
        Me.TxtStt_Rec0HDX.TabStop = False
        Me.TxtStt_Rec0HDX.Tag = ""
        Me.TxtStt_Rec0HDX.Visible = False
        '
        'TxtLoai_kh
        '
        Me.TxtLoai_kh.AllowNegative = True
        Me.TxtLoai_kh.BackColor = System.Drawing.Color.White
        Me.TxtLoai_kh.Flags = 7680
        Me.TxtLoai_kh.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLoai_kh.ForeColor = System.Drawing.Color.Blue
        Me.TxtLoai_kh.InputMask = "### ### ### ### ### ###"
        Me.TxtLoai_kh.Location = New System.Drawing.Point(564, 172)
        Me.TxtLoai_kh.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLoai_kh.MaxWholeDigits = 17
        Me.TxtLoai_kh.Name = "TxtLoai_kh"
        Me.TxtLoai_kh.RangeMax = 1.7976931348623157E+308R
        Me.TxtLoai_kh.RangeMin = -1.7976931348623157E+308R
        Me.TxtLoai_kh.Size = New System.Drawing.Size(69, 23)
        Me.TxtLoai_kh.TabIndex = 7191
        Me.TxtLoai_kh.Text = "0"
        Me.TxtLoai_kh.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLoai_kh.Visible = False
        '
        'FrmPDS_F3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(867, 221)
        Me.Controls.Add(Me.TxtLoai_kh)
        Me.Controls.Add(Me.TxtStt_Rec0HDX)
        Me.Controls.Add(Me.TxtStt_RecHDX)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.TxtMa_Ct)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtTG_SC)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtNgay_KT)
        Me.Controls.Add(Me.TxtNgay_BD)
        Me.Controls.Add(Me.CbbMa_khoang)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMa_HD)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNgay_Gx)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.txtOng_Ba)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTen_Mau)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_HS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtDien_Thoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_KH)
        Me.Controls.Add(Me.txtten_Kx)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.LabMa_Xe)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Name = "FrmPDS_F3"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label21, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.txtten_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KH, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Thoai, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtOng_Ba, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Gx, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HD, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_khoang, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.TxtTG_SC, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_RecHDX, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec0HDX, 0)
        Me.Controls.SetChildIndex(Me.TxtLoai_kh, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Xe As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_HS As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Thoai As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents txtten_Kx As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtOng_Ba As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct As ClsTextBox.txtDate1
    Friend WithEvents TxtNgay_Gx As ClsTextBox.txtDate1
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_HD As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtTG_SC As ClsTextBox.txtTien_NT
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_KT As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_BD As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents CbbMa_khoang As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Ct As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Giai As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_RecHDX As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec0HDX As System.Windows.Forms.TextBox
    Friend WithEvents TxtLoai_kh As ClsTextBox.txtTien_NT

End Class
