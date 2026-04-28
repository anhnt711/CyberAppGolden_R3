<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMHSQuyDoiDiem
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
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtGia_Tri_C = New ClsTextBox.txtSo_luong()
        Me.labSl_min = New System.Windows.Forms.Label()
        Me.TxtTen_ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_ID2 = New System.Windows.Forms.TextBox()
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
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(773, 328)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtExit.TabIndex = 15
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(620, 328)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtOK.TabIndex = 14
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(461, 338)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMa_Dvcs.TabIndex = 13
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(165, 345)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkActi.TabIndex = 12
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 312)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(920, 15)
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
        'TxtID
        '
        Me.TxtID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtID.ForeColor = System.Drawing.Color.Navy
        Me.TxtID.Location = New System.Drawing.Point(144, 48)
        Me.TxtID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(146, 27)
        Me.TxtID.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 53)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 21)
        Me.Label4.TabIndex = 440
        Me.Label4.Tag = "Car number"
        Me.Label4.Text = "ID"
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
        'TxtTen_ID
        '
        Me.TxtTen_ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTen_ID.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ID.Location = New System.Drawing.Point(144, 89)
        Me.TxtTen_ID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtTen_ID.Name = "TxtTen_ID"
        Me.TxtTen_ID.Size = New System.Drawing.Size(754, 27)
        Me.TxtTen_ID.TabIndex = 2
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
        'TxtTen_ID2
        '
        Me.TxtTen_ID2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTen_ID2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ID2.Location = New System.Drawing.Point(144, 129)
        Me.TxtTen_ID2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtTen_ID2.Name = "TxtTen_ID2"
        Me.TxtTen_ID2.Size = New System.Drawing.Size(754, 27)
        Me.TxtTen_ID2.TabIndex = 3
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
        Me.Label3.Location = New System.Drawing.Point(18, 176)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(399, 21)
        Me.Label3.TabIndex = 4
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
        'DMHSQuyDoiDiem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(926, 382)
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
        Me.Controls.Add(Me.TxtTen_ID2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_ID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtGia_Tri_C)
        Me.Controls.Add(Me.labSl_min)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_Ku)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(724, 261)
        Me.Name = "DMHSQuyDoiDiem"
        Me.Text = "Danh mục hiệu lực vật tư tối ưu"
        Me.Controls.SetChildIndex(Me.LabNgay_Ku, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtID, 0)
        Me.Controls.SetChildIndex(Me.labSl_min, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_Tri_C, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ID, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ID2, 0)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents LabNgay_Ku As System.Windows.Forms.Label
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtGia_Tri_C As ClsTextBox.txtSo_luong
    Friend WithEvents labSl_min As System.Windows.Forms.Label
    Friend WithEvents TxtTen_ID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_ID2 As System.Windows.Forms.TextBox
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

End Class
