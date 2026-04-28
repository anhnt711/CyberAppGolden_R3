<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmXeTichdiem
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
        Me.TxtNgay_HL = New ClsTextBox.txtDate()
        Me.LabNgay_Ku = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGia_Tri_C = New ClsTextBox.txtSo_luong()
        Me.labSl_min = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtName2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtGia_Tri_I = New ClsTextBox.txtSo_luong()
        Me.TxtGia_Tri_N = New ClsTextBox.txtSo_luong()
        Me.TxtGia_Tri_W = New ClsTextBox.txtSo_luong()
        Me.ChkActi_C = New System.Windows.Forms.CheckBox()
        Me.ChkActi_I = New System.Windows.Forms.CheckBox()
        Me.ChkActi_N = New System.Windows.Forms.CheckBox()
        Me.ChkActi_W = New System.Windows.Forms.CheckBox()
        Me.TxtTen_Vitri = New System.Windows.Forms.TextBox()
        Me.TxtMa_xe = New Cyber.SmLists.TxtLookup()
        Me.TxtGhi_chu = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_xe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(765, 357)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtExit.TabIndex = 16
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(612, 357)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtOK.TabIndex = 15
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(453, 367)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMa_Dvcs.TabIndex = 14
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(165, 373)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkActi.TabIndex = 13
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 341)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(912, 15)
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.isEmpty = False
        Me.TxtNgay_HL.Location = New System.Drawing.Point(144, 8)
        Me.TxtNgay_HL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(146, 27)
        Me.TxtNgay_HL.TabIndex = 0
        Me.TxtNgay_HL.Text = "26/07/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'LabNgay_Ku
        '
        Me.LabNgay_Ku.AutoSize = True
        Me.LabNgay_Ku.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_Ku.Location = New System.Drawing.Point(18, 10)
        Me.LabNgay_Ku.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNgay_Ku.Name = "LabNgay_Ku"
        Me.LabNgay_Ku.Size = New System.Drawing.Size(110, 21)
        Me.LabNgay_Ku.TabIndex = 3
        Me.LabNgay_Ku.Tag = "Date from"
        Me.LabNgay_Ku.Text = "Ngày hiệu lực"
        Me.LabNgay_Ku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 53)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 21)
        Me.Label4.TabIndex = 440
        Me.Label4.Tag = "Car number"
        Me.Label4.Text = "Mã xe"
        '
        'TxtGia_Tri_C
        '
        Me.TxtGia_Tri_C.AllowNegative = True
        Me.TxtGia_Tri_C.Flags = 7680
        Me.TxtGia_Tri_C.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_Tri_C.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_Tri_C.InputMask = "### ### ### ###"
        Me.TxtGia_Tri_C.Location = New System.Drawing.Point(144, 210)
        Me.TxtGia_Tri_C.MaxWholeDigits = 11
        Me.TxtGia_Tri_C.Name = "TxtGia_Tri_C"
        Me.TxtGia_Tri_C.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_Tri_C.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_Tri_C.Size = New System.Drawing.Size(146, 27)
        Me.TxtGia_Tri_C.TabIndex = 4
        Me.TxtGia_Tri_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labSl_min
        '
        Me.labSl_min.AutoSize = True
        Me.labSl_min.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.labSl_min.ForeColor = System.Drawing.Color.Navy
        Me.labSl_min.Location = New System.Drawing.Point(18, 216)
        Me.labSl_min.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labSl_min.Name = "labSl_min"
        Me.labSl_min.Size = New System.Drawing.Size(96, 21)
        Me.labSl_min.TabIndex = 458
        Me.labSl_min.Tag = "Weight"
        Me.labSl_min.Text = "Khách hàng"
        '
        'TxtName
        '
        Me.TxtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtName.ForeColor = System.Drawing.Color.Navy
        Me.TxtName.Location = New System.Drawing.Point(144, 89)
        Me.TxtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(754, 27)
        Me.TxtName.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 21)
        Me.Label1.TabIndex = 460
        Me.Label1.Tag = "Car number"
        Me.Label1.Text = "Tên"
        '
        'TxtName2
        '
        Me.TxtName2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtName2.ForeColor = System.Drawing.Color.Navy
        Me.TxtName2.Location = New System.Drawing.Point(144, 129)
        Me.TxtName2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtName2.Name = "TxtName2"
        Me.TxtName2.Size = New System.Drawing.Size(754, 27)
        Me.TxtName2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 134)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 21)
        Me.Label2.TabIndex = 462
        Me.Label2.Tag = "Car number"
        Me.Label2.Text = "Tên 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 168)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(399, 21)
        Me.Label3.TabIndex = 463
        Me.Label3.Tag = "Car number"
        Me.Label3.Text = "Giá trị quy đổi 1 điểm theo từng loại hình thanh toán"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(18, 257)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 21)
        Me.Label5.TabIndex = 464
        Me.Label5.Tag = "Weight"
        Me.Label5.Text = "Bảo hiểm"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(477, 216)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 21)
        Me.Label6.TabIndex = 465
        Me.Label6.Tag = "Weight"
        Me.Label6.Text = "Nội bộ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(477, 257)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 21)
        Me.Label7.TabIndex = 466
        Me.Label7.Tag = "Weight"
        Me.Label7.Text = "Bảo hành"
        '
        'TxtGia_Tri_I
        '
        Me.TxtGia_Tri_I.AllowNegative = True
        Me.TxtGia_Tri_I.Flags = 7680
        Me.TxtGia_Tri_I.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_Tri_I.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_Tri_I.InputMask = "### ### ### ###"
        Me.TxtGia_Tri_I.Location = New System.Drawing.Point(144, 250)
        Me.TxtGia_Tri_I.MaxWholeDigits = 11
        Me.TxtGia_Tri_I.Name = "TxtGia_Tri_I"
        Me.TxtGia_Tri_I.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_Tri_I.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_Tri_I.Size = New System.Drawing.Size(146, 27)
        Me.TxtGia_Tri_I.TabIndex = 8
        Me.TxtGia_Tri_I.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtGia_Tri_N
        '
        Me.TxtGia_Tri_N.AllowNegative = True
        Me.TxtGia_Tri_N.Flags = 7680
        Me.TxtGia_Tri_N.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_Tri_N.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_Tri_N.InputMask = "### ### ### ###"
        Me.TxtGia_Tri_N.Location = New System.Drawing.Point(586, 210)
        Me.TxtGia_Tri_N.MaxWholeDigits = 11
        Me.TxtGia_Tri_N.Name = "TxtGia_Tri_N"
        Me.TxtGia_Tri_N.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_Tri_N.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_Tri_N.Size = New System.Drawing.Size(146, 27)
        Me.TxtGia_Tri_N.TabIndex = 6
        Me.TxtGia_Tri_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtGia_Tri_W
        '
        Me.TxtGia_Tri_W.AllowNegative = True
        Me.TxtGia_Tri_W.Flags = 7680
        Me.TxtGia_Tri_W.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_Tri_W.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_Tri_W.InputMask = "### ### ### ###"
        Me.TxtGia_Tri_W.Location = New System.Drawing.Point(586, 250)
        Me.TxtGia_Tri_W.MaxWholeDigits = 11
        Me.TxtGia_Tri_W.Name = "TxtGia_Tri_W"
        Me.TxtGia_Tri_W.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_Tri_W.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_Tri_W.Size = New System.Drawing.Size(146, 27)
        Me.TxtGia_Tri_W.TabIndex = 10
        Me.TxtGia_Tri_W.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChkActi_C
        '
        Me.ChkActi_C.AutoSize = True
        Me.ChkActi_C.Location = New System.Drawing.Point(316, 215)
        Me.ChkActi_C.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkActi_C.Name = "ChkActi_C"
        Me.ChkActi_C.Size = New System.Drawing.Size(22, 21)
        Me.ChkActi_C.TabIndex = 5
        Me.ChkActi_C.UseVisualStyleBackColor = True
        '
        'ChkActi_I
        '
        Me.ChkActi_I.AutoSize = True
        Me.ChkActi_I.Location = New System.Drawing.Point(316, 255)
        Me.ChkActi_I.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkActi_I.Name = "ChkActi_I"
        Me.ChkActi_I.Size = New System.Drawing.Size(22, 21)
        Me.ChkActi_I.TabIndex = 9
        Me.ChkActi_I.UseVisualStyleBackColor = True
        '
        'ChkActi_N
        '
        Me.ChkActi_N.AutoSize = True
        Me.ChkActi_N.Location = New System.Drawing.Point(760, 215)
        Me.ChkActi_N.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkActi_N.Name = "ChkActi_N"
        Me.ChkActi_N.Size = New System.Drawing.Size(22, 21)
        Me.ChkActi_N.TabIndex = 7
        Me.ChkActi_N.UseVisualStyleBackColor = True
        '
        'ChkActi_W
        '
        Me.ChkActi_W.AutoSize = True
        Me.ChkActi_W.Location = New System.Drawing.Point(760, 255)
        Me.ChkActi_W.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkActi_W.Name = "ChkActi_W"
        Me.ChkActi_W.Size = New System.Drawing.Size(22, 21)
        Me.ChkActi_W.TabIndex = 11
        Me.ChkActi_W.UseVisualStyleBackColor = True
        '
        'TxtTen_Vitri
        '
        Me.TxtTen_Vitri.BackColor = System.Drawing.Color.White
        Me.TxtTen_Vitri.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Vitri.Enabled = False
        Me.TxtTen_Vitri.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Vitri.Location = New System.Drawing.Point(308, 52)
        Me.TxtTen_Vitri.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtTen_Vitri.Name = "TxtTen_Vitri"
        Me.TxtTen_Vitri.ReadOnly = True
        Me.TxtTen_Vitri.Size = New System.Drawing.Size(591, 20)
        Me.TxtTen_Vitri.TabIndex = 468
        Me.TxtTen_Vitri.TabStop = False
        '
        'TxtMa_xe
        '
        Me.TxtMa_xe._ActilookupPopup = False
        Me.TxtMa_xe.CyberActilookupPopup = True
        Me.TxtMa_xe.Dv_ListDetail = Nothing
        Me.TxtMa_xe.Dv_Master = Nothing
        Me.TxtMa_xe.FilterClient = ""
        Me.TxtMa_xe.FilterSQL = ""
        Me.TxtMa_xe.Location = New System.Drawing.Point(144, 48)
        Me.TxtMa_xe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMa_xe.Name = "TxtMa_xe"
        Me.TxtMa_xe.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_xe.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_xe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_xe.Size = New System.Drawing.Size(147, 26)
        Me.TxtMa_xe.TabIndex = 1
        Me.TxtMa_xe.Table_Name = ""
        '
        'TxtGhi_chu
        '
        Me.TxtGhi_chu.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtGhi_chu.ForeColor = System.Drawing.Color.Navy
        Me.TxtGhi_chu.Location = New System.Drawing.Point(144, 302)
        Me.TxtGhi_chu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtGhi_chu.Name = "TxtGhi_chu"
        Me.TxtGhi_chu.Size = New System.Drawing.Size(754, 27)
        Me.TxtGhi_chu.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(18, 305)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 21)
        Me.Label8.TabIndex = 470
        Me.Label8.Tag = "Weight"
        Me.Label8.Text = "Ghi chú"
        '
        'DmXeTichdiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(918, 410)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtGhi_chu)
        Me.Controls.Add(Me.TxtTen_Vitri)
        Me.Controls.Add(Me.TxtMa_xe)
        Me.Controls.Add(Me.ChkActi_W)
        Me.Controls.Add(Me.ChkActi_N)
        Me.Controls.Add(Me.ChkActi_I)
        Me.Controls.Add(Me.ChkActi_C)
        Me.Controls.Add(Me.TxtGia_Tri_W)
        Me.Controls.Add(Me.TxtGia_Tri_N)
        Me.Controls.Add(Me.TxtGia_Tri_I)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtName2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtGia_Tri_C)
        Me.Controls.Add(Me.labSl_min)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_Ku)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(722, 258)
        Me.Name = "DmXeTichdiem"
        Me.Text = "Danh mục hiệu lực vật tư tối ưu"
        Me.Controls.SetChildIndex(Me.LabNgay_Ku, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.labSl_min, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_Tri_C, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtName, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtName2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_Tri_I, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_Tri_N, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_Tri_W, 0)
        Me.Controls.SetChildIndex(Me.ChkActi_C, 0)
        Me.Controls.SetChildIndex(Me.ChkActi_I, 0)
        Me.Controls.SetChildIndex(Me.ChkActi_N, 0)
        Me.Controls.SetChildIndex(Me.ChkActi_W, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_xe, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vitri, 0)
        Me.Controls.SetChildIndex(Me.TxtGhi_chu, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        CType(Me.TxtMa_xe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents LabNgay_Ku As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtGia_Tri_C As ClsTextBox.txtSo_luong
    Friend WithEvents labSl_min As System.Windows.Forms.Label
    Friend WithEvents TxtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtName2 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtGia_Tri_I As ClsTextBox.txtSo_luong
    Friend WithEvents TxtGia_Tri_N As ClsTextBox.txtSo_luong
    Friend WithEvents TxtGia_Tri_W As ClsTextBox.txtSo_luong
    Friend WithEvents ChkActi_C As System.Windows.Forms.CheckBox
    Friend WithEvents ChkActi_I As System.Windows.Forms.CheckBox
    Friend WithEvents ChkActi_N As System.Windows.Forms.CheckBox
    Friend WithEvents ChkActi_W As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTen_Vitri As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_xe As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtGhi_chu As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
