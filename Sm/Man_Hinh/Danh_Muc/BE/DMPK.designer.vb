<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMPK
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
        Me.LabMa_PK = New System.Windows.Forms.Label()
        Me.TxtMa_PK = New System.Windows.Forms.TextBox()
        Me.TxtTen_PK = New System.Windows.Forms.TextBox()
        Me.LabTen_kho = New System.Windows.Forms.Label()
        Me.TxtTen_PK2 = New System.Windows.Forms.TextBox()
        Me.Labten_Kho2 = New System.Windows.Forms.Label()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_PK1 = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_PK2 = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_PK3 = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh4 = New System.Windows.Forms.TextBox()
        Me.TxtNh_PK4 = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh5 = New System.Windows.Forms.TextBox()
        Me.TxtNh_PK5 = New Cyber.SmLists.TxtLookup()
        Me.LblTk_DL = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_kx = New Cyber.SmLists.TxtLookup()
        Me.TxtDVT = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtGia = New ClsTextBox.txtTy_Gia()
        Me.TxtGia_nt = New ClsTextBox.txtTy_Gia()
        Me.LabGia_nt = New System.Windows.Forms.Label()
        CType(Me.TxtNh_PK1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_PK2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_PK3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_PK4.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_PK5.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 237)
        Me.ButtExit.TabIndex = 12
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 237)
        Me.ButtOK.TabIndex = 11
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 243)
        Me.TxtMa_Dvcs.TabIndex = 11
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 247)
        Me.ChkActi.TabIndex = 10
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 227)
        '
        'LabMa_PK
        '
        Me.LabMa_PK.Location = New System.Drawing.Point(5, 115)
        Me.LabMa_PK.Name = "LabMa_PK"
        Me.LabMa_PK.Size = New System.Drawing.Size(100, 18)
        Me.LabMa_PK.TabIndex = 10
        Me.LabMa_PK.Tag = "Code"
        Me.LabMa_PK.Text = "Mã phụ kiện"
        '
        'TxtMa_PK
        '
        Me.TxtMa_PK.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_PK.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_PK.Location = New System.Drawing.Point(110, 114)
        Me.TxtMa_PK.Name = "TxtMa_PK"
        Me.TxtMa_PK.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_PK.TabIndex = 5
        '
        'TxtTen_PK
        '
        Me.TxtTen_PK.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_PK.Location = New System.Drawing.Point(110, 137)
        Me.TxtTen_PK.Name = "TxtTen_PK"
        Me.TxtTen_PK.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_PK.TabIndex = 6
        '
        'LabTen_kho
        '
        Me.LabTen_kho.Location = New System.Drawing.Point(5, 139)
        Me.LabTen_kho.Name = "LabTen_kho"
        Me.LabTen_kho.Size = New System.Drawing.Size(100, 16)
        Me.LabTen_kho.TabIndex = 12
        Me.LabTen_kho.Tag = "Name"
        Me.LabTen_kho.Text = "Tên phụ kiện"
        '
        'TxtTen_PK2
        '
        Me.TxtTen_PK2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_PK2.Location = New System.Drawing.Point(110, 160)
        Me.TxtTen_PK2.Name = "TxtTen_PK2"
        Me.TxtTen_PK2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_PK2.TabIndex = 7
        '
        'Labten_Kho2
        '
        Me.Labten_Kho2.Location = New System.Drawing.Point(5, 161)
        Me.Labten_Kho2.Name = "Labten_Kho2"
        Me.Labten_Kho2.Size = New System.Drawing.Size(100, 17)
        Me.Labten_Kho2.TabIndex = 14
        Me.Labten_Kho2.Tag = "English name"
        Me.Labten_Kho2.Text = "Tên tiếng anh"
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(5, 4)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_Nh1.TabIndex = 24
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Nhóm 1"
        '
        'TxtTen_Nh1
        '
        Me.TxtTen_Nh1.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh1.Enabled = False
        Me.TxtTen_Nh1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh1.Location = New System.Drawing.Point(263, 10)
        Me.TxtTen_Nh1.Name = "TxtTen_Nh1"
        Me.TxtTen_Nh1.ReadOnly = True
        Me.TxtTen_Nh1.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Nh1.TabIndex = 23
        Me.TxtTen_Nh1.TabStop = False
        '
        'TxtNh_PK1
        '
        Me.TxtNh_PK1._ActilookupPopup = False
        Me.TxtNh_PK1.CyberActilookupPopup = True
        Me.TxtNh_PK1.Dv_ListDetail = Nothing
        Me.TxtNh_PK1.Dv_Master = Nothing
        Me.TxtNh_PK1.FilterClient = ""
        Me.TxtNh_PK1.FilterSQL = ""
        Me.TxtNh_PK1.Location = New System.Drawing.Point(110, 4)
        Me.TxtNh_PK1.Name = "TxtNh_PK1"
        Me.TxtNh_PK1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_PK1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_PK1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_PK1.Size = New System.Drawing.Size(149, 20)
        Me.TxtNh_PK1.TabIndex = 0
        Me.TxtNh_PK1.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "Nhóm 2"
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh2.Enabled = False
        Me.TxtTen_Nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(263, 32)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.ReadOnly = True
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Nh2.TabIndex = 26
        Me.TxtTen_Nh2.TabStop = False
        '
        'TxtNh_PK2
        '
        Me.TxtNh_PK2._ActilookupPopup = False
        Me.TxtNh_PK2.CyberActilookupPopup = True
        Me.TxtNh_PK2.Dv_ListDetail = Nothing
        Me.TxtNh_PK2.Dv_Master = Nothing
        Me.TxtNh_PK2.FilterClient = ""
        Me.TxtNh_PK2.FilterSQL = ""
        Me.TxtNh_PK2.Location = New System.Drawing.Point(110, 26)
        Me.TxtNh_PK2.Name = "TxtNh_PK2"
        Me.TxtNh_PK2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_PK2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_PK2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_PK2.Size = New System.Drawing.Size(149, 20)
        Me.TxtNh_PK2.TabIndex = 1
        Me.TxtNh_PK2.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 17)
        Me.Label2.TabIndex = 30
        Me.Label2.Tag = "Group 3"
        Me.Label2.Text = "Nhóm 3"
        '
        'TxtTen_Nh3
        '
        Me.TxtTen_Nh3.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh3.Enabled = False
        Me.TxtTen_Nh3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh3.Location = New System.Drawing.Point(263, 54)
        Me.TxtTen_Nh3.Name = "TxtTen_Nh3"
        Me.TxtTen_Nh3.ReadOnly = True
        Me.TxtTen_Nh3.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Nh3.TabIndex = 29
        Me.TxtTen_Nh3.TabStop = False
        '
        'TxtNh_PK3
        '
        Me.TxtNh_PK3._ActilookupPopup = False
        Me.TxtNh_PK3.CyberActilookupPopup = True
        Me.TxtNh_PK3.Dv_ListDetail = Nothing
        Me.TxtNh_PK3.Dv_Master = Nothing
        Me.TxtNh_PK3.FilterClient = ""
        Me.TxtNh_PK3.FilterSQL = ""
        Me.TxtNh_PK3.Location = New System.Drawing.Point(110, 48)
        Me.TxtNh_PK3.Name = "TxtNh_PK3"
        Me.TxtNh_PK3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_PK3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_PK3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_PK3.Size = New System.Drawing.Size(149, 20)
        Me.TxtNh_PK3.TabIndex = 2
        Me.TxtNh_PK3.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Tag = "Group 4"
        Me.Label3.Text = "Nhóm 4"
        '
        'TxtTen_Nh4
        '
        Me.TxtTen_Nh4.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh4.Enabled = False
        Me.TxtTen_Nh4.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh4.Location = New System.Drawing.Point(263, 76)
        Me.TxtTen_Nh4.Name = "TxtTen_Nh4"
        Me.TxtTen_Nh4.ReadOnly = True
        Me.TxtTen_Nh4.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Nh4.TabIndex = 32
        Me.TxtTen_Nh4.TabStop = False
        '
        'TxtNh_PK4
        '
        Me.TxtNh_PK4._ActilookupPopup = False
        Me.TxtNh_PK4.CyberActilookupPopup = True
        Me.TxtNh_PK4.Dv_ListDetail = Nothing
        Me.TxtNh_PK4.Dv_Master = Nothing
        Me.TxtNh_PK4.FilterClient = ""
        Me.TxtNh_PK4.FilterSQL = ""
        Me.TxtNh_PK4.Location = New System.Drawing.Point(110, 70)
        Me.TxtNh_PK4.Name = "TxtNh_PK4"
        Me.TxtNh_PK4.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_PK4.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_PK4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_PK4.Size = New System.Drawing.Size(149, 20)
        Me.TxtNh_PK4.TabIndex = 3
        Me.TxtNh_PK4.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(5, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Tag = "Group 5"
        Me.Label4.Text = "Nhóm 5"
        '
        'TxtTen_Nh5
        '
        Me.TxtTen_Nh5.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Nh5.Enabled = False
        Me.TxtTen_Nh5.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nh5.Location = New System.Drawing.Point(263, 98)
        Me.TxtTen_Nh5.Name = "TxtTen_Nh5"
        Me.TxtTen_Nh5.ReadOnly = True
        Me.TxtTen_Nh5.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Nh5.TabIndex = 35
        Me.TxtTen_Nh5.TabStop = False
        '
        'TxtNh_PK5
        '
        Me.TxtNh_PK5._ActilookupPopup = False
        Me.TxtNh_PK5.CyberActilookupPopup = True
        Me.TxtNh_PK5.Dv_ListDetail = Nothing
        Me.TxtNh_PK5.Dv_Master = Nothing
        Me.TxtNh_PK5.FilterClient = ""
        Me.TxtNh_PK5.FilterSQL = ""
        Me.TxtNh_PK5.Location = New System.Drawing.Point(110, 92)
        Me.TxtNh_PK5.Name = "TxtNh_PK5"
        Me.TxtNh_PK5.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_PK5.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_PK5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_PK5.Size = New System.Drawing.Size(149, 20)
        Me.TxtNh_PK5.TabIndex = 4
        Me.TxtNh_PK5.Table_Name = ""
        '
        'LblTk_DL
        '
        Me.LblTk_DL.Location = New System.Drawing.Point(5, 210)
        Me.LblTk_DL.Name = "LblTk_DL"
        Me.LblTk_DL.Size = New System.Drawing.Size(100, 15)
        Me.LblTk_DL.TabIndex = 39
        Me.LblTk_DL.Tag = "Model car"
        Me.LblTk_DL.Text = "Mã kiểu xe"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(265, 211)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Kx.TabIndex = 38
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_kx
        '
        Me.TxtMa_kx._ActilookupPopup = False
        Me.TxtMa_kx.CyberActilookupPopup = True
        Me.TxtMa_kx.Dv_ListDetail = Nothing
        Me.TxtMa_kx.Dv_Master = Nothing
        Me.TxtMa_kx.FilterClient = ""
        Me.TxtMa_kx.FilterSQL = ""
        Me.TxtMa_kx.Location = New System.Drawing.Point(110, 208)
        Me.TxtMa_kx.Name = "TxtMa_kx"
        Me.TxtMa_kx.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtMa_kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kx.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kx.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_kx.TabIndex = 10
        Me.TxtMa_kx.Table_Name = ""
        '
        'TxtDVT
        '
        Me.TxtDVT.ForeColor = System.Drawing.Color.Navy
        Me.TxtDVT.Location = New System.Drawing.Point(110, 184)
        Me.TxtDVT.Name = "TxtDVT"
        Me.TxtDVT.Size = New System.Drawing.Size(149, 21)
        Me.TxtDVT.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(5, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 15)
        Me.Label5.TabIndex = 449
        Me.Label5.Tag = "Unit"
        Me.Label5.Text = "Đơn vị tính"
        '
        'TxtGia
        '
        Me.TxtGia.AllowNegative = True
        Me.TxtGia.Flags = 7680
        Me.TxtGia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia.InputMask = "### ### ### ### ###"
        Me.TxtGia.Location = New System.Drawing.Point(319, 243)
        Me.TxtGia.MaxWholeDigits = 14
        Me.TxtGia.Name = "TxtGia"
        Me.TxtGia.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia.TabIndex = 451
        Me.TxtGia.Text = "1"
        Me.TxtGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtGia.Visible = False
        '
        'TxtGia_nt
        '
        Me.TxtGia_nt.AllowNegative = True
        Me.TxtGia_nt.Flags = 7680
        Me.TxtGia_nt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_nt.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_nt.InputMask = "### ### ### ### ###"
        Me.TxtGia_nt.Location = New System.Drawing.Point(390, 184)
        Me.TxtGia_nt.MaxWholeDigits = 14
        Me.TxtGia_nt.Name = "TxtGia_nt"
        Me.TxtGia_nt.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_nt.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_nt.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia_nt.TabIndex = 9
        Me.TxtGia_nt.Text = "1"
        Me.TxtGia_nt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabGia_nt
        '
        Me.LabGia_nt.Location = New System.Drawing.Point(309, 185)
        Me.LabGia_nt.Name = "LabGia_nt"
        Me.LabGia_nt.Size = New System.Drawing.Size(80, 18)
        Me.LabGia_nt.TabIndex = 452
        Me.LabGia_nt.Tag = "Price "
        Me.LabGia_nt.Text = "Đơn giá"
        '
        'DMPK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 270)
        Me.Controls.Add(Me.TxtGia)
        Me.Controls.Add(Me.TxtGia_nt)
        Me.Controls.Add(Me.LabGia_nt)
        Me.Controls.Add(Me.TxtDVT)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblTk_DL)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtMa_kx)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Nh5)
        Me.Controls.Add(Me.TxtNh_PK5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_Nh4)
        Me.Controls.Add(Me.TxtNh_PK4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_Nh3)
        Me.Controls.Add(Me.TxtNh_PK3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.TxtNh_PK2)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_Nh1)
        Me.Controls.Add(Me.TxtNh_PK1)
        Me.Controls.Add(Me.TxtTen_PK2)
        Me.Controls.Add(Me.Labten_Kho2)
        Me.Controls.Add(Me.TxtTen_PK)
        Me.Controls.Add(Me.LabTen_kho)
        Me.Controls.Add(Me.TxtMa_PK)
        Me.Controls.Add(Me.LabMa_PK)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMPK"
        Me.Text = "Danh mục phụ kiện"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_PK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_PK, 0)
        Me.Controls.SetChildIndex(Me.LabTen_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_PK, 0)
        Me.Controls.SetChildIndex(Me.Labten_Kho2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_PK2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_PK1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh1, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_PK2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_PK3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_PK4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh4, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_PK5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh5, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.LblTk_DL, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtDVT, 0)
        Me.Controls.SetChildIndex(Me.LabGia_nt, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_nt, 0)
        Me.Controls.SetChildIndex(Me.TxtGia, 0)
        CType(Me.TxtNh_PK1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_PK2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_PK3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_PK4.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_PK5.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_PK As System.Windows.Forms.Label
    Friend WithEvents TxtMa_PK As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_PK As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_PK2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_Kho2 As System.Windows.Forms.Label
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_PK1 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_PK2 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_PK3 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_PK4 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh5 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_PK5 As Cyber.SmLists.TxtLookup
    Friend WithEvents LblTk_DL As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kx As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtDVT As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtGia As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtGia_nt As ClsTextBox.txtTy_Gia
    Friend WithEvents LabGia_nt As System.Windows.Forms.Label

End Class
