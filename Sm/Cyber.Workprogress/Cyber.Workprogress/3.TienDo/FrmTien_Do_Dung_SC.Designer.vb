<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTien_Do_Dung_SC
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
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Ct = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.txtGhi_Chu = New System.Windows.Forms.TextBox()
        Me.LabMa_CDSC = New System.Windows.Forms.Label()
        Me.CbbMa_Cd = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabMa_Xe = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSo_RO = New System.Windows.Forms.TextBox()
        Me.ChkTrong_khoang = New System.Windows.Forms.CheckBox()
        Me.CbbMa_Dung = New System.Windows.Forms.ComboBox()
        Me.TxtNgay_BD = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_KT = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 234)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(734, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(535, 244)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 5
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(637, 244)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 6
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(44, 250)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(45, 21)
        Me.TxtMa_Dvcs.TabIndex = 8
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Tag = ""
        Me.TxtMa_Dvcs.Visible = False
        '
        'TxtMa_Ct
        '
        Me.TxtMa_Ct.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Ct.BackColor = System.Drawing.Color.White
        Me.TxtMa_Ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtMa_Ct.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Ct.Location = New System.Drawing.Point(97, 250)
        Me.TxtMa_Ct.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Ct.Name = "TxtMa_Ct"
        Me.TxtMa_Ct.Size = New System.Drawing.Size(45, 21)
        Me.TxtMa_Ct.TabIndex = 9
        Me.TxtMa_Ct.TabStop = False
        Me.TxtMa_Ct.Tag = ""
        Me.TxtMa_Ct.Visible = False
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Blue
        Me.TxtStt_Rec.Location = New System.Drawing.Point(150, 250)
        Me.TxtStt_Rec.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(45, 21)
        Me.TxtStt_Rec.TabIndex = 10
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Tag = ""
        Me.TxtStt_Rec.Visible = False
        '
        'txtGhi_Chu
        '
        Me.txtGhi_Chu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGhi_Chu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhi_Chu.ForeColor = System.Drawing.Color.Navy
        Me.txtGhi_Chu.Location = New System.Drawing.Point(91, 124)
        Me.txtGhi_Chu.Multiline = True
        Me.txtGhi_Chu.Name = "txtGhi_Chu"
        Me.txtGhi_Chu.Size = New System.Drawing.Size(645, 106)
        Me.txtGhi_Chu.TabIndex = 4
        '
        'LabMa_CDSC
        '
        Me.LabMa_CDSC.AutoSize = True
        Me.LabMa_CDSC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_CDSC.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_CDSC.Location = New System.Drawing.Point(12, 6)
        Me.LabMa_CDSC.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_CDSC.Name = "LabMa_CDSC"
        Me.LabMa_CDSC.Size = New System.Drawing.Size(74, 16)
        Me.LabMa_CDSC.TabIndex = 0
        Me.LabMa_CDSC.Tag = "Type car"
        Me.LabMa_CDSC.Text = "Công đoạn"
        '
        'CbbMa_Cd
        '
        Me.CbbMa_Cd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Cd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_Cd.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Cd.FormattingEnabled = True
        Me.CbbMa_Cd.Location = New System.Drawing.Point(91, 4)
        Me.CbbMa_Cd.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_Cd.Name = "CbbMa_Cd"
        Me.CbbMa_Cd.Size = New System.Drawing.Size(245, 23)
        Me.CbbMa_Cd.TabIndex = 10
        Me.CbbMa_Cd.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(12, 29)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 7255
        Me.Label2.Tag = "Type car"
        Me.Label2.Text = "Mã lý do"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(12, 118)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 16)
        Me.Label1.TabIndex = 7264
        Me.Label1.Tag = "Type car"
        Me.Label1.Text = "Ghi chú"
        '
        'LabMa_Xe
        '
        Me.LabMa_Xe.AutoSize = True
        Me.LabMa_Xe.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Xe.Location = New System.Drawing.Point(337, 7)
        Me.LabMa_Xe.Name = "LabMa_Xe"
        Me.LabMa_Xe.Size = New System.Drawing.Size(53, 16)
        Me.LabMa_Xe.TabIndex = 7275
        Me.LabMa_Xe.Tag = "Voucher no."
        Me.LabMa_Xe.Text = "Biển số"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Xe.Location = New System.Drawing.Point(392, 6)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.ReadOnly = True
        Me.TxtMa_Xe.Size = New System.Drawing.Size(139, 21)
        Me.TxtMa_Xe.TabIndex = 7274
        Me.TxtMa_Xe.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(532, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 16)
        Me.Label7.TabIndex = 7277
        Me.Label7.Tag = "Voucher no."
        Me.Label7.Text = "Số R/O"
        '
        'TxtSo_RO
        '
        Me.TxtSo_RO.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.TxtSo_RO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_RO.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_RO.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_RO.Location = New System.Drawing.Point(584, 6)
        Me.TxtSo_RO.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSo_RO.Name = "TxtSo_RO"
        Me.TxtSo_RO.ReadOnly = True
        Me.TxtSo_RO.Size = New System.Drawing.Size(152, 21)
        Me.TxtSo_RO.TabIndex = 7276
        Me.TxtSo_RO.Tag = ""
        '
        'ChkTrong_khoang
        '
        Me.ChkTrong_khoang.AutoSize = True
        Me.ChkTrong_khoang.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkTrong_khoang.ForeColor = System.Drawing.Color.DimGray
        Me.ChkTrong_khoang.Location = New System.Drawing.Point(91, 103)
        Me.ChkTrong_khoang.Name = "ChkTrong_khoang"
        Me.ChkTrong_khoang.Size = New System.Drawing.Size(132, 20)
        Me.ChkTrong_khoang.TabIndex = 3
        Me.ChkTrong_khoang.Text = "Dừng trên khoang"
        Me.ChkTrong_khoang.UseVisualStyleBackColor = True
        '
        'CbbMa_Dung
        '
        Me.CbbMa_Dung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Dung.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_Dung.ForeColor = System.Drawing.Color.Blue
        Me.CbbMa_Dung.FormattingEnabled = True
        Me.CbbMa_Dung.Location = New System.Drawing.Point(91, 30)
        Me.CbbMa_Dung.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_Dung.Name = "CbbMa_Dung"
        Me.CbbMa_Dung.Size = New System.Drawing.Size(245, 21)
        Me.CbbMa_Dung.TabIndex = 0
        '
        'TxtNgay_BD
        '
        Me.TxtNgay_BD.BackColor = System.Drawing.Color.White
        Me.TxtNgay_BD.Flags = 0
        Me.TxtNgay_BD.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_BD.IsAllowResize = False
        Me.TxtNgay_BD.Location = New System.Drawing.Point(91, 54)
        Me.TxtNgay_BD.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD.MaxLength = 10
        Me.TxtNgay_BD.Name = "TxtNgay_BD"
        Me.TxtNgay_BD.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD.ShowDayBeforeMonth = False
        Me.TxtNgay_BD.Size = New System.Drawing.Size(154, 22)
        Me.TxtNgay_BD.TabIndex = 1
        Me.TxtNgay_BD.Value = "22/03/2023 16:24"
        '
        'TxtNgay_KT
        '
        Me.TxtNgay_KT.BackColor = System.Drawing.Color.White
        Me.TxtNgay_KT.Flags = 0
        Me.TxtNgay_KT.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_KT.IsAllowResize = False
        Me.TxtNgay_KT.Location = New System.Drawing.Point(91, 78)
        Me.TxtNgay_KT.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT.MaxLength = 10
        Me.TxtNgay_KT.Name = "TxtNgay_KT"
        Me.TxtNgay_KT.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT.ShowDayBeforeMonth = False
        Me.TxtNgay_KT.Size = New System.Drawing.Size(154, 22)
        Me.TxtNgay_KT.TabIndex = 2
        Me.TxtNgay_KT.Value = "22/03/2023 16:24"
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(12, 54)
        Me.Label14.Margin = New System.Windows.Forms.Padding(0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 15)
        Me.Label14.TabIndex = 7283
        Me.Label14.Tag = ""
        Me.Label14.Text = "Bắt đầu"
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(12, 79)
        Me.Label17.Margin = New System.Windows.Forms.Padding(0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(58, 15)
        Me.Label17.TabIndex = 7284
        Me.Label17.Tag = ""
        Me.Label17.Text = "Kết thúc"
        '
        'FrmTien_Do_Dung_SC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(739, 298)
        Me.Controls.Add(Me.TxtNgay_BD)
        Me.Controls.Add(Me.TxtNgay_KT)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.CbbMa_Dung)
        Me.Controls.Add(Me.ChkTrong_khoang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtSo_RO)
        Me.Controls.Add(Me.LabMa_Xe)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabMa_CDSC)
        Me.Controls.Add(Me.CbbMa_Cd)
        Me.Controls.Add(Me.txtGhi_Chu)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Ct)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmTien_Do_Dung_SC"
        Me.Text = "XÁC NHẬN LÝ DO DỪNG SỬA CHỮA"
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.txtGhi_Chu, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Cd, 0)
        Me.Controls.SetChildIndex(Me.LabMa_CDSC, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_RO, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.ChkTrong_khoang, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Dung, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Ct As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents txtGhi_Chu As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_CDSC As System.Windows.Forms.Label
    Friend WithEvents CbbMa_Cd As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabMa_Xe As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_RO As System.Windows.Forms.TextBox
    Friend WithEvents ChkTrong_khoang As System.Windows.Forms.CheckBox
    Friend WithEvents CbbMa_Dung As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNgay_BD As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_KT As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label

End Class
