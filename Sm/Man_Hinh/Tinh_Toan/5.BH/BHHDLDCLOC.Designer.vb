<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BHHDLDCLOC
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtten_KH = New System.Windows.Forms.TextBox()
        Me.TxtMa_KH = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_NhKH1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH1 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NhKH3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH3 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NhKH2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_KH2 = New Cyber.SmLists.TxtLookup()
        Me.LabLenh_SO = New System.Windows.Forms.Label()
        Me.TxtLenh_SO = New System.Windows.Forms.TextBox()
        Me.TxtNgay_CT2 = New ClsTextBox.txtDate()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNgay_CT1 = New ClsTextBox.txtDate()
        Me.LabNgay_LCt = New System.Windows.Forms.Label()
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_KH2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 170)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(760, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(493, 182)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtOK.TabIndex = 7
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(629, 182)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtExit.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 65)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 502
        Me.Label4.Tag = "Customer"
        Me.Label4.Text = "Mã đối tượng"
        '
        'Txtten_KH
        '
        Me.Txtten_KH.BackColor = System.Drawing.Color.White
        Me.Txtten_KH.Enabled = False
        Me.Txtten_KH.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_KH.Location = New System.Drawing.Point(264, 59)
        Me.Txtten_KH.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtten_KH.Name = "Txtten_KH"
        Me.Txtten_KH.ReadOnly = True
        Me.Txtten_KH.Size = New System.Drawing.Size(495, 22)
        Me.Txtten_KH.TabIndex = 501
        Me.Txtten_KH.TabStop = False
        '
        'TxtMa_KH
        '
        Me.TxtMa_KH._ActilookupPopup = False
        Me.TxtMa_KH.CyberActilookupPopup = True
        Me.TxtMa_KH.Dv_ListDetail = Nothing
        Me.TxtMa_KH.Dv_Master = Nothing
        Me.TxtMa_KH.FilterClient = ""
        Me.TxtMa_KH.FilterSQL = ""
        Me.TxtMa_KH.Location = New System.Drawing.Point(112, 60)
        Me.TxtMa_KH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_KH.Name = "TxtMa_KH"
        Me.TxtMa_KH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KH.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_KH.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_KH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KH.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_KH.TabIndex = 3
        Me.TxtMa_KH.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(1, 144)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 18)
        Me.Label8.TabIndex = 523
        Me.Label8.Tag = "Group 3"
        Me.Label8.Text = "Nhóm 3"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(1, 92)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 18)
        Me.Label6.TabIndex = 522
        Me.Label6.Tag = "Group 1"
        Me.Label6.Text = "Nhóm 1"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(1, 118)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 521
        Me.Label5.Tag = "Group 2"
        Me.Label5.Text = "Nhóm 2"
        '
        'TxtTen_NhKH1
        '
        Me.TxtTen_NhKH1.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhKH1.Enabled = False
        Me.TxtTen_NhKH1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhKH1.Location = New System.Drawing.Point(264, 85)
        Me.TxtTen_NhKH1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_NhKH1.Name = "TxtTen_NhKH1"
        Me.TxtTen_NhKH1.ReadOnly = True
        Me.TxtTen_NhKH1.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_NhKH1.TabIndex = 520
        Me.TxtTen_NhKH1.TabStop = False
        '
        'TxtNh_KH1
        '
        Me.TxtNh_KH1._ActilookupPopup = False
        Me.TxtNh_KH1.CyberActilookupPopup = True
        Me.TxtNh_KH1.Dv_ListDetail = Nothing
        Me.TxtNh_KH1.Dv_Master = Nothing
        Me.TxtNh_KH1.FilterClient = ""
        Me.TxtNh_KH1.FilterSQL = ""
        Me.TxtNh_KH1.Location = New System.Drawing.Point(112, 86)
        Me.TxtNh_KH1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_KH1.Name = "TxtNh_KH1"
        Me.TxtNh_KH1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_KH1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_KH1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH1.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_KH1.TabIndex = 4
        Me.TxtNh_KH1.Table_Name = ""
        '
        'TxtTen_NhKH3
        '
        Me.TxtTen_NhKH3.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhKH3.Enabled = False
        Me.TxtTen_NhKH3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhKH3.Location = New System.Drawing.Point(264, 137)
        Me.TxtTen_NhKH3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_NhKH3.Name = "TxtTen_NhKH3"
        Me.TxtTen_NhKH3.ReadOnly = True
        Me.TxtTen_NhKH3.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_NhKH3.TabIndex = 519
        Me.TxtTen_NhKH3.TabStop = False
        '
        'TxtNh_KH3
        '
        Me.TxtNh_KH3._ActilookupPopup = False
        Me.TxtNh_KH3.CyberActilookupPopup = True
        Me.TxtNh_KH3.Dv_ListDetail = Nothing
        Me.TxtNh_KH3.Dv_Master = Nothing
        Me.TxtNh_KH3.FilterClient = ""
        Me.TxtNh_KH3.FilterSQL = ""
        Me.TxtNh_KH3.Location = New System.Drawing.Point(112, 138)
        Me.TxtNh_KH3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_KH3.Name = "TxtNh_KH3"
        Me.TxtNh_KH3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH3.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_KH3.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_KH3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH3.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_KH3.TabIndex = 6
        Me.TxtNh_KH3.Table_Name = ""
        '
        'TxtTen_NhKH2
        '
        Me.TxtTen_NhKH2.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhKH2.Enabled = False
        Me.TxtTen_NhKH2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhKH2.Location = New System.Drawing.Point(264, 111)
        Me.TxtTen_NhKH2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_NhKH2.Name = "TxtTen_NhKH2"
        Me.TxtTen_NhKH2.ReadOnly = True
        Me.TxtTen_NhKH2.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_NhKH2.TabIndex = 518
        Me.TxtTen_NhKH2.TabStop = False
        '
        'TxtNh_KH2
        '
        Me.TxtNh_KH2._ActilookupPopup = False
        Me.TxtNh_KH2.CyberActilookupPopup = True
        Me.TxtNh_KH2.Dv_ListDetail = Nothing
        Me.TxtNh_KH2.Dv_Master = Nothing
        Me.TxtNh_KH2.FilterClient = ""
        Me.TxtNh_KH2.FilterSQL = ""
        Me.TxtNh_KH2.Location = New System.Drawing.Point(112, 112)
        Me.TxtNh_KH2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_KH2.Name = "TxtNh_KH2"
        Me.TxtNh_KH2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_KH2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_KH2.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtNh_KH2.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtNh_KH2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_KH2.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_KH2.TabIndex = 5
        Me.TxtNh_KH2.Table_Name = ""
        '
        'LabLenh_SO
        '
        Me.LabLenh_SO.BackColor = System.Drawing.Color.Transparent
        Me.LabLenh_SO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabLenh_SO.ForeColor = System.Drawing.Color.Navy
        Me.LabLenh_SO.Location = New System.Drawing.Point(1, 36)
        Me.LabLenh_SO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLenh_SO.Name = "LabLenh_SO"
        Me.LabLenh_SO.Size = New System.Drawing.Size(60, 16)
        Me.LabLenh_SO.TabIndex = 529
        Me.LabLenh_SO.Tag = "R/O"
        Me.LabLenh_SO.Text = "Số lệnh"
        '
        'TxtLenh_SO
        '
        Me.TxtLenh_SO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_SO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_SO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_SO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_SO.Location = New System.Drawing.Point(112, 31)
        Me.TxtLenh_SO.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLenh_SO.Name = "TxtLenh_SO"
        Me.TxtLenh_SO.Size = New System.Drawing.Size(145, 24)
        Me.TxtLenh_SO.TabIndex = 2
        Me.TxtLenh_SO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNgay_CT2
        '
        Me.TxtNgay_CT2.BackColor = System.Drawing.Color.White
        Me.TxtNgay_CT2.Flags = 65536
        Me.TxtNgay_CT2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_CT2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_CT2.isEmpty = True
        Me.TxtNgay_CT2.Location = New System.Drawing.Point(411, 2)
        Me.TxtNgay_CT2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNgay_CT2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_CT2.MaxLength = 10
        Me.TxtNgay_CT2.Name = "TxtNgay_CT2"
        Me.TxtNgay_CT2.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_CT2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CT2.ShowDayBeforeMonth = False
        Me.TxtNgay_CT2.Size = New System.Drawing.Size(145, 24)
        Me.TxtNgay_CT2.TabIndex = 1
        Me.TxtNgay_CT2.Text = "18/09/2011"
        Me.TxtNgay_CT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_CT2.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(300, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 16)
        Me.Label1.TabIndex = 527
        Me.Label1.Tag = "Date to"
        Me.Label1.Text = "Đến ngày"
        '
        'TxtNgay_CT1
        '
        Me.TxtNgay_CT1.BackColor = System.Drawing.Color.White
        Me.TxtNgay_CT1.Flags = 65536
        Me.TxtNgay_CT1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_CT1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_CT1.isEmpty = True
        Me.TxtNgay_CT1.Location = New System.Drawing.Point(112, 2)
        Me.TxtNgay_CT1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNgay_CT1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_CT1.MaxLength = 10
        Me.TxtNgay_CT1.Name = "TxtNgay_CT1"
        Me.TxtNgay_CT1.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_CT1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_CT1.ShowDayBeforeMonth = False
        Me.TxtNgay_CT1.Size = New System.Drawing.Size(145, 24)
        Me.TxtNgay_CT1.TabIndex = 0
        Me.TxtNgay_CT1.Text = "18/09/2011"
        Me.TxtNgay_CT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_CT1.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'LabNgay_LCt
        '
        Me.LabNgay_LCt.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_LCt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_LCt.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_LCt.Location = New System.Drawing.Point(1, 7)
        Me.LabNgay_LCt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNgay_LCt.Name = "LabNgay_LCt"
        Me.LabNgay_LCt.Size = New System.Drawing.Size(104, 16)
        Me.LabNgay_LCt.TabIndex = 525
        Me.LabNgay_LCt.Tag = "Date from"
        Me.LabNgay_LCt.Text = "Từ ngày"
        '
        'BHHDLDCLOC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(765, 249)
        Me.Controls.Add(Me.LabLenh_SO)
        Me.Controls.Add(Me.TxtLenh_SO)
        Me.Controls.Add(Me.TxtNgay_CT2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNgay_CT1)
        Me.Controls.Add(Me.LabNgay_LCt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_NhKH1)
        Me.Controls.Add(Me.TxtNh_KH1)
        Me.Controls.Add(Me.TxtTen_NhKH3)
        Me.Controls.Add(Me.TxtNh_KH3)
        Me.Controls.Add(Me.TxtTen_NhKH2)
        Me.Controls.Add(Me.TxtNh_KH2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtten_KH)
        Me.Controls.Add(Me.TxtMa_KH)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "BHHDLDCLOC"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KH, 0)
        Me.Controls.SetChildIndex(Me.Txtten_KH, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhKH2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhKH3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_KH1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhKH1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CT1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_CT2, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_SO, 0)
        Me.Controls.SetChildIndex(Me.LabLenh_SO, 0)
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_KH2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtten_KH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KH As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_NhKH1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NhKH3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NhKH2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_KH2 As Cyber.SmLists.TxtLookup
    Friend WithEvents LabLenh_SO As System.Windows.Forms.Label
    Friend WithEvents TxtLenh_SO As System.Windows.Forms.TextBox
    Friend WithEvents TxtNgay_CT2 As ClsTextBox.txtDate
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_CT1 As ClsTextBox.txtDate
    Friend WithEvents LabNgay_LCt As System.Windows.Forms.Label

End Class
