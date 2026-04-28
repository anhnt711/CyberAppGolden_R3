<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COGTSPDD
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
        Me.LabTen_KH = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMa_vt = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Vt = New System.Windows.Forms.Label()
        Me.TxtTen_Vv = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMa_Vv = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_HD = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtMa_HD = New Cyber.SmLists.TxtLookup()
        Me.TxtSL_DD = New ClsTextBox.txtTien_NT()
        Me.TxtGT_DD = New ClsTextBox.txtTien_NT()
        Me.TxtTen_TK0 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTK_CP = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_tk = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbThang = New System.Windows.Forms.ComboBox()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Vv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTK_CP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(820, 313)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 12
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(679, 313)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 11
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(512, 324)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(132, 327)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 9
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(1, 301)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(979, 3)
        Me.GroupBoxLine.TabIndex = 8
        '
        'LabTen_KH
        '
        Me.LabTen_KH.Location = New System.Drawing.Point(15, 252)
        Me.LabTen_KH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTen_KH.Name = "LabTen_KH"
        Me.LabTen_KH.Size = New System.Drawing.Size(134, 22)
        Me.LabTen_KH.TabIndex = 12
        Me.LabTen_KH.Tag = "Value"
        Me.LabTen_KH.Text = "Gía trị dở dang"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 222)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 22)
        Me.Label2.TabIndex = 30
        Me.Label2.Tag = "Quantity"
        Me.Label2.Text = "Số lượng dở dang"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 22)
        Me.Label3.TabIndex = 362
        Me.Label3.Tag = "Supplies"
        Me.Label3.Text = "Vật tư"
        '
        'TxtMa_vt
        '
        Me.TxtMa_vt._ActilookupPopup = False
        Me.TxtMa_vt.CyberActilookupPopup = True
        Me.TxtMa_vt.Dv_ListDetail = Nothing
        Me.TxtMa_vt.Dv_Master = Nothing
        Me.TxtMa_vt.FilterClient = ""
        Me.TxtMa_vt.FilterSQL = ""
        Me.TxtMa_vt.Location = New System.Drawing.Point(152, 69)
        Me.TxtMa_vt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_vt.Name = "TxtMa_vt"
        Me.TxtMa_vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_vt.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_vt.TabIndex = 1
        Me.TxtMa_vt.Table_Name = ""
        '
        'TxtTen_Vt
        '
        Me.TxtTen_Vt.BackColor = System.Drawing.Color.White
        Me.TxtTen_Vt.Location = New System.Drawing.Point(359, 75)
        Me.TxtTen_Vt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_Vt.Name = "TxtTen_Vt"
        Me.TxtTen_Vt.Size = New System.Drawing.Size(595, 17)
        Me.TxtTen_Vt.TabIndex = 365
        Me.TxtTen_Vt.Tag = "Group 4"
        '
        'TxtTen_Vv
        '
        Me.TxtTen_Vv.BackColor = System.Drawing.Color.White
        Me.TxtTen_Vv.Location = New System.Drawing.Point(359, 103)
        Me.TxtTen_Vv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_Vv.Name = "TxtTen_Vv"
        Me.TxtTen_Vv.Size = New System.Drawing.Size(595, 17)
        Me.TxtTen_Vv.TabIndex = 368
        Me.TxtTen_Vv.Tag = "Group 4"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(15, 102)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 22)
        Me.Label5.TabIndex = 367
        Me.Label5.Tag = "Case"
        Me.Label5.Text = "Vụ việc"
        '
        'TxtMa_Vv
        '
        Me.TxtMa_Vv._ActilookupPopup = False
        Me.TxtMa_Vv.CyberActilookupPopup = True
        Me.TxtMa_Vv.Dv_ListDetail = Nothing
        Me.TxtMa_Vv.Dv_Master = Nothing
        Me.TxtMa_Vv.FilterClient = ""
        Me.TxtMa_Vv.FilterSQL = ""
        Me.TxtMa_Vv.Location = New System.Drawing.Point(152, 98)
        Me.TxtMa_Vv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Vv.Name = "TxtMa_Vv"
        Me.TxtMa_Vv.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vv.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vv.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_Vv.TabIndex = 2
        Me.TxtMa_Vv.Table_Name = ""
        '
        'TxtTen_HD
        '
        Me.TxtTen_HD.BackColor = System.Drawing.Color.White
        Me.TxtTen_HD.Location = New System.Drawing.Point(359, 133)
        Me.TxtTen_HD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_HD.Name = "TxtTen_HD"
        Me.TxtTen_HD.Size = New System.Drawing.Size(595, 17)
        Me.TxtTen_HD.TabIndex = 371
        Me.TxtTen_HD.Tag = "Group 4"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(15, 132)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(110, 22)
        Me.Label7.TabIndex = 370
        Me.Label7.Tag = "Contract"
        Me.Label7.Text = "Hợp đồng"
        '
        'TxtMa_HD
        '
        Me.TxtMa_HD._ActilookupPopup = False
        Me.TxtMa_HD.CyberActilookupPopup = True
        Me.TxtMa_HD.Dv_ListDetail = Nothing
        Me.TxtMa_HD.Dv_Master = Nothing
        Me.TxtMa_HD.FilterClient = ""
        Me.TxtMa_HD.FilterSQL = ""
        Me.TxtMa_HD.Location = New System.Drawing.Point(152, 128)
        Me.TxtMa_HD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_HD.Name = "TxtMa_HD"
        Me.TxtMa_HD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HD.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HD.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_HD.TabIndex = 3
        Me.TxtMa_HD.Table_Name = ""
        '
        'TxtSL_DD
        '
        Me.TxtSL_DD.AllowNegative = True
        Me.TxtSL_DD.Flags = 7680
        Me.TxtSL_DD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtSL_DD.ForeColor = System.Drawing.Color.Navy
        Me.TxtSL_DD.InputMask = "### ### ### ### ###"
        Me.TxtSL_DD.Location = New System.Drawing.Point(152, 218)
        Me.TxtSL_DD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSL_DD.MaxWholeDigits = 14
        Me.TxtSL_DD.Name = "TxtSL_DD"
        Me.TxtSL_DD.RangeMax = 1.7976931348623157E+308R
        Me.TxtSL_DD.RangeMin = -1.7976931348623157E+308R
        Me.TxtSL_DD.Size = New System.Drawing.Size(179, 24)
        Me.TxtSL_DD.TabIndex = 6
        Me.TxtSL_DD.Text = "0"
        Me.TxtSL_DD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtGT_DD
        '
        Me.TxtGT_DD.AllowNegative = True
        Me.TxtGT_DD.Flags = 7680
        Me.TxtGT_DD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtGT_DD.ForeColor = System.Drawing.Color.Navy
        Me.TxtGT_DD.InputMask = "### ### ### ### ###"
        Me.TxtGT_DD.Location = New System.Drawing.Point(152, 248)
        Me.TxtGT_DD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtGT_DD.MaxWholeDigits = 14
        Me.TxtGT_DD.Name = "TxtGT_DD"
        Me.TxtGT_DD.RangeMax = 1.7976931348623157E+308R
        Me.TxtGT_DD.RangeMin = -1.7976931348623157E+308R
        Me.TxtGT_DD.Size = New System.Drawing.Size(179, 24)
        Me.TxtGT_DD.TabIndex = 7
        Me.TxtGT_DD.Text = "0"
        Me.TxtGT_DD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTen_TK0
        '
        Me.TxtTen_TK0.BackColor = System.Drawing.Color.White
        Me.TxtTen_TK0.Location = New System.Drawing.Point(359, 194)
        Me.TxtTen_TK0.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_TK0.Name = "TxtTen_TK0"
        Me.TxtTen_TK0.Size = New System.Drawing.Size(595, 17)
        Me.TxtTen_TK0.TabIndex = 376
        Me.TxtTen_TK0.Tag = "Group 4"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(15, 192)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(134, 22)
        Me.Label6.TabIndex = 375
        Me.Label6.Tag = " Acc expense"
        Me.Label6.Text = "Tài khoản chi phí"
        '
        'TxtTK_CP
        '
        Me.TxtTK_CP._ActilookupPopup = False
        Me.TxtTK_CP.CyberActilookupPopup = True
        Me.TxtTK_CP.Dv_ListDetail = Nothing
        Me.TxtTK_CP.Dv_Master = Nothing
        Me.TxtTK_CP.FilterClient = ""
        Me.TxtTK_CP.FilterSQL = ""
        Me.TxtTK_CP.Location = New System.Drawing.Point(152, 188)
        Me.TxtTK_CP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTK_CP.Name = "TxtTK_CP"
        Me.TxtTK_CP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTK_CP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTK_CP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTK_CP.Size = New System.Drawing.Size(180, 22)
        Me.TxtTK_CP.TabIndex = 5
        Me.TxtTK_CP.Table_Name = ""
        '
        'TxtTen_tk
        '
        Me.TxtTen_tk.BackColor = System.Drawing.Color.White
        Me.TxtTen_tk.Location = New System.Drawing.Point(359, 163)
        Me.TxtTen_tk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_tk.Name = "TxtTen_tk"
        Me.TxtTen_tk.Size = New System.Drawing.Size(595, 17)
        Me.TxtTen_tk.TabIndex = 379
        Me.TxtTen_tk.Tag = "Group 4"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(15, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 22)
        Me.Label4.TabIndex = 378
        Me.Label4.Tag = "Acc process"
        Me.Label4.Text = "Tài khoản dở dang"
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(152, 158)
        Me.TxtTk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(180, 22)
        Me.TxtTk.TabIndex = 4
        Me.TxtTk.Table_Name = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(15, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 26)
        Me.Label10.TabIndex = 381
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Năm"
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(152, 12)
        Me.TxtNam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(179, 24)
        Me.TxtNam.TabIndex = 0
        Me.TxtNam.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(15, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 26)
        Me.Label1.TabIndex = 383
        Me.Label1.Tag = "Month"
        Me.Label1.Text = "Tháng"
        '
        'CmbThang
        '
        Me.CmbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbThang.Enabled = False
        Me.CmbThang.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbThang.ForeColor = System.Drawing.Color.Navy
        Me.CmbThang.FormattingEnabled = True
        Me.CmbThang.Location = New System.Drawing.Point(152, 41)
        Me.CmbThang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbThang.Name = "CmbThang"
        Me.CmbThang.Size = New System.Drawing.Size(179, 25)
        Me.CmbThang.TabIndex = 384
        '
        'COGTSPDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 367)
        Me.Controls.Add(Me.CmbThang)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.TxtTen_tk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTk)
        Me.Controls.Add(Me.TxtTen_TK0)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTK_CP)
        Me.Controls.Add(Me.TxtGT_DD)
        Me.Controls.Add(Me.TxtSL_DD)
        Me.Controls.Add(Me.TxtTen_HD)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMa_HD)
        Me.Controls.Add(Me.TxtTen_Vv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtMa_Vv)
        Me.Controls.Add(Me.TxtTen_Vt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtMa_vt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabTen_KH)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "COGTSPDD"
        Me.Text = "Danh mục gói sửa chữa"
        Me.Controls.SetChildIndex(Me.LabTen_KH, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_vt, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vt, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vv, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vv, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HD, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HD, 0)
        Me.Controls.SetChildIndex(Me.TxtSL_DD, 0)
        Me.Controls.SetChildIndex(Me.TxtGT_DD, 0)
        Me.Controls.SetChildIndex(Me.TxtTK_CP, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK0, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_tk, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CmbThang, 0)
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Vv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_HD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTK_CP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabTen_KH As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_vt As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Vt As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Vv As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Vv As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_HD As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_HD As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtSL_DD As ClsTextBox.txtTien_NT
    Friend WithEvents TxtGT_DD As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTen_TK0 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTK_CP As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_tk As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbThang As System.Windows.Forms.ComboBox

End Class
