<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COTinhApGia
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
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbM_Thang2 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.LabM_month2 = New System.Windows.Forms.Label()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtten_VT = New System.Windows.Forms.TextBox()
        Me.TxtMa_VT = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_NhVT1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_VT1 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NhVT3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_VT3 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NhVT2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_VT2 = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_TK = New System.Windows.Forms.TextBox()
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_CD = New System.Windows.Forms.TextBox()
        Me.TxtMa_CD = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_VT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_VT1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_VT3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_VT2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_CD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 193)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(760, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(493, 206)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtOK.TabIndex = 10
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(629, 206)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtExit.TabIndex = 11
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(613, 9)
        Me.CbbM_Nam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Nam.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(571, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 505
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'CbbM_Thang2
        '
        Me.CbbM_Thang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang2.FormattingEnabled = True
        Me.CbbM_Thang2.Location = New System.Drawing.Point(361, 9)
        Me.CbbM_Thang2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang2.Name = "CbbM_Thang2"
        Me.CbbM_Thang2.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Thang2.TabIndex = 1
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(112, 9)
        Me.CbbM_Thang1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Thang1.TabIndex = 0
        '
        'LabM_month2
        '
        Me.LabM_month2.AutoSize = True
        Me.LabM_month2.Location = New System.Drawing.Point(279, 12)
        Me.LabM_month2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month2.Name = "LabM_month2"
        Me.LabM_month2.Size = New System.Drawing.Size(74, 17)
        Me.LabM_month2.TabIndex = 504
        Me.LabM_month2.Tag = "Month to"
        Me.LabM_month2.Text = "Đến tháng"
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(0, 12)
        Me.LabM_month1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(65, 17)
        Me.LabM_month1.TabIndex = 503
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Từ tháng"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 44)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 502
        Me.Label4.Tag = "Product"
        Me.Label4.Text = "Mã sản phẩm"
        '
        'Txtten_VT
        '
        Me.Txtten_VT.BackColor = System.Drawing.Color.White
        Me.Txtten_VT.Enabled = False
        Me.Txtten_VT.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_VT.Location = New System.Drawing.Point(264, 38)
        Me.Txtten_VT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_VT.Name = "Txtten_VT"
        Me.Txtten_VT.ReadOnly = True
        Me.Txtten_VT.Size = New System.Drawing.Size(495, 22)
        Me.Txtten_VT.TabIndex = 501
        Me.Txtten_VT.TabStop = False
        '
        'TxtMa_VT
        '
        Me.TxtMa_VT._ActilookupPopup = False
        Me.TxtMa_VT.CyberActilookupPopup = True
        Me.TxtMa_VT.Dv_ListDetail = Nothing
        Me.TxtMa_VT.Dv_Master = Nothing
        Me.TxtMa_VT.FilterClient = ""
        Me.TxtMa_VT.FilterSQL = ""
        Me.TxtMa_VT.Location = New System.Drawing.Point(112, 39)
        Me.TxtMa_VT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_VT.Name = "TxtMa_VT"
        Me.TxtMa_VT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_VT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_VT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_VT.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_VT.TabIndex = 3
        Me.TxtMa_VT.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(1, 123)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 18)
        Me.Label8.TabIndex = 514
        Me.Label8.Tag = "Group 3"
        Me.Label8.Text = "Nhóm 3"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(1, 71)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 18)
        Me.Label6.TabIndex = 513
        Me.Label6.Tag = "Group 1"
        Me.Label6.Text = "Nhóm 1"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(1, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 512
        Me.Label5.Tag = "Group 2"
        Me.Label5.Text = "Nhóm 2"
        '
        'TxtTen_NhVT1
        '
        Me.TxtTen_NhVT1.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhVT1.Enabled = False
        Me.TxtTen_NhVT1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhVT1.Location = New System.Drawing.Point(264, 64)
        Me.TxtTen_NhVT1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_NhVT1.Name = "TxtTen_NhVT1"
        Me.TxtTen_NhVT1.ReadOnly = True
        Me.TxtTen_NhVT1.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_NhVT1.TabIndex = 511
        Me.TxtTen_NhVT1.TabStop = False
        '
        'TxtNh_VT1
        '
        Me.TxtNh_VT1._ActilookupPopup = False
        Me.TxtNh_VT1.CyberActilookupPopup = True
        Me.TxtNh_VT1.Dv_ListDetail = Nothing
        Me.TxtNh_VT1.Dv_Master = Nothing
        Me.TxtNh_VT1.FilterClient = ""
        Me.TxtNh_VT1.FilterSQL = ""
        Me.TxtNh_VT1.Location = New System.Drawing.Point(112, 65)
        Me.TxtNh_VT1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_VT1.Name = "TxtNh_VT1"
        Me.TxtNh_VT1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_VT1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_VT1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_VT1.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_VT1.TabIndex = 4
        Me.TxtNh_VT1.Table_Name = ""
        '
        'TxtTen_NhVT3
        '
        Me.TxtTen_NhVT3.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhVT3.Enabled = False
        Me.TxtTen_NhVT3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhVT3.Location = New System.Drawing.Point(264, 116)
        Me.TxtTen_NhVT3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_NhVT3.Name = "TxtTen_NhVT3"
        Me.TxtTen_NhVT3.ReadOnly = True
        Me.TxtTen_NhVT3.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_NhVT3.TabIndex = 510
        Me.TxtTen_NhVT3.TabStop = False
        '
        'TxtNh_VT3
        '
        Me.TxtNh_VT3._ActilookupPopup = False
        Me.TxtNh_VT3.CyberActilookupPopup = True
        Me.TxtNh_VT3.Dv_ListDetail = Nothing
        Me.TxtNh_VT3.Dv_Master = Nothing
        Me.TxtNh_VT3.FilterClient = ""
        Me.TxtNh_VT3.FilterSQL = ""
        Me.TxtNh_VT3.Location = New System.Drawing.Point(112, 117)
        Me.TxtNh_VT3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_VT3.Name = "TxtNh_VT3"
        Me.TxtNh_VT3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_VT3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_VT3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_VT3.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_VT3.TabIndex = 6
        Me.TxtNh_VT3.Table_Name = ""
        '
        'TxtTen_NhVT2
        '
        Me.TxtTen_NhVT2.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhVT2.Enabled = False
        Me.TxtTen_NhVT2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhVT2.Location = New System.Drawing.Point(264, 90)
        Me.TxtTen_NhVT2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_NhVT2.Name = "TxtTen_NhVT2"
        Me.TxtTen_NhVT2.ReadOnly = True
        Me.TxtTen_NhVT2.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_NhVT2.TabIndex = 509
        Me.TxtTen_NhVT2.TabStop = False
        '
        'TxtNh_VT2
        '
        Me.TxtNh_VT2._ActilookupPopup = False
        Me.TxtNh_VT2.CyberActilookupPopup = True
        Me.TxtNh_VT2.Dv_ListDetail = Nothing
        Me.TxtNh_VT2.Dv_Master = Nothing
        Me.TxtNh_VT2.FilterClient = ""
        Me.TxtNh_VT2.FilterSQL = ""
        Me.TxtNh_VT2.Location = New System.Drawing.Point(112, 91)
        Me.TxtNh_VT2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNh_VT2.Name = "TxtNh_VT2"
        Me.TxtNh_VT2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_VT2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_VT2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_VT2.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_VT2.TabIndex = 5
        Me.TxtNh_VT2.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 150)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 517
        Me.Label1.Tag = "Account"
        Me.Label1.Text = "TK dở dang"
        '
        'TxtTen_TK
        '
        Me.TxtTen_TK.BackColor = System.Drawing.Color.White
        Me.TxtTen_TK.Enabled = False
        Me.TxtTen_TK.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK.Location = New System.Drawing.Point(264, 144)
        Me.TxtTen_TK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TK.Name = "TxtTen_TK"
        Me.TxtTen_TK.ReadOnly = True
        Me.TxtTen_TK.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_TK.TabIndex = 516
        Me.TxtTen_TK.TabStop = False
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(112, 145)
        Me.TxtTk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(147, 22)
        Me.TxtTk.TabIndex = 7
        Me.TxtTk.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 177)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 38)
        Me.Label3.TabIndex = 520
        Me.Label3.Tag = "Stages"
        Me.Label3.Text = "Công đoạn"
        '
        'TxtTen_CD
        '
        Me.TxtTen_CD.BackColor = System.Drawing.Color.White
        Me.TxtTen_CD.Enabled = False
        Me.TxtTen_CD.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_CD.Location = New System.Drawing.Point(264, 171)
        Me.TxtTen_CD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_CD.Name = "TxtTen_CD"
        Me.TxtTen_CD.ReadOnly = True
        Me.TxtTen_CD.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_CD.TabIndex = 519
        Me.TxtTen_CD.TabStop = False
        '
        'TxtMa_CD
        '
        Me.TxtMa_CD._ActilookupPopup = False
        Me.TxtMa_CD.CyberActilookupPopup = True
        Me.TxtMa_CD.Dv_ListDetail = Nothing
        Me.TxtMa_CD.Dv_Master = Nothing
        Me.TxtMa_CD.FilterClient = ""
        Me.TxtMa_CD.FilterSQL = ""
        Me.TxtMa_CD.Location = New System.Drawing.Point(112, 172)
        Me.TxtMa_CD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_CD.Name = "TxtMa_CD"
        Me.TxtMa_CD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_CD.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_CD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_CD.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_CD.TabIndex = 8
        Me.TxtMa_CD.Table_Name = ""
        '
        'COTinhApGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(765, 272)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_CD)
        Me.Controls.Add(Me.TxtMa_CD)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_TK)
        Me.Controls.Add(Me.TxtTk)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_NhVT1)
        Me.Controls.Add(Me.TxtNh_VT1)
        Me.Controls.Add(Me.TxtTen_NhVT3)
        Me.Controls.Add(Me.TxtNh_VT3)
        Me.Controls.Add(Me.TxtTen_NhVT2)
        Me.Controls.Add(Me.TxtNh_VT2)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.LabM_month2)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtten_VT)
        Me.Controls.Add(Me.TxtMa_VT)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "COTinhApGia"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_VT, 0)
        Me.Controls.SetChildIndex(Me.Txtten_VT, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.LabM_month2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_VT2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhVT2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_VT3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhVT3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_VT1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhVT1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_CD, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_CD, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.TxtMa_VT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_VT1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_VT3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_VT2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_CD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month2 As System.Windows.Forms.Label
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtten_VT As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_VT As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_NhVT1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_VT1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NhVT3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_VT3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NhVT2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_VT2 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_TK As System.Windows.Forms.TextBox
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_CD As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_CD As Cyber.SmLists.TxtLookup

End Class
