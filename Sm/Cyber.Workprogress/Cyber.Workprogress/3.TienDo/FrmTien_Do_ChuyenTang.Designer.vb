<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTien_Do_ChuyenTang
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTien_Do_ChuyenTang))
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec_KH = New System.Windows.Forms.TextBox()
        Me.txtGhi_Chu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabMa_Xe = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSo_RO = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtStt_Rec_Ro = New System.Windows.Forms.TextBox()
        Me.CldChon_ForeColor = New System.Windows.Forms.ColorDialog()
        Me.TxtForeColor_Ghichu = New System.Windows.Forms.TextBox()
        Me.ButtForeColor_Choose = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtBackColor_Choose = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtBackColor_Ghichu = New System.Windows.Forms.TextBox()
        Me.CldChon_Backcolor = New System.Windows.Forms.ColorDialog()
        Me.buttRemove_Forecolor = New DevExpress.XtraEditors.SimpleButton()
        Me.buttRemove_backcolor = New DevExpress.XtraEditors.SimpleButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbMa_TangChuyen = New System.Windows.Forms.ComboBox()
        Me.CbbMa_TangNhan = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 154)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(504, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(305, 164)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 12
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(407, 164)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 13
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(44, 167)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(45, 21)
        Me.TxtMa_Dvcs.TabIndex = 8
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Tag = ""
        Me.TxtMa_Dvcs.Visible = False
        '
        'TxtStt_Rec_KH
        '
        Me.TxtStt_Rec_KH.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec_KH.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec_KH.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtStt_Rec_KH.ForeColor = System.Drawing.Color.Blue
        Me.TxtStt_Rec_KH.Location = New System.Drawing.Point(150, 167)
        Me.TxtStt_Rec_KH.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec_KH.Name = "TxtStt_Rec_KH"
        Me.TxtStt_Rec_KH.Size = New System.Drawing.Size(45, 21)
        Me.TxtStt_Rec_KH.TabIndex = 10
        Me.TxtStt_Rec_KH.TabStop = False
        Me.TxtStt_Rec_KH.Tag = ""
        Me.TxtStt_Rec_KH.Visible = False
        '
        'txtGhi_Chu
        '
        Me.txtGhi_Chu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGhi_Chu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhi_Chu.ForeColor = System.Drawing.Color.Navy
        Me.txtGhi_Chu.Location = New System.Drawing.Point(86, 54)
        Me.txtGhi_Chu.MaxLength = 200
        Me.txtGhi_Chu.Multiline = True
        Me.txtGhi_Chu.Name = "txtGhi_Chu"
        Me.txtGhi_Chu.Size = New System.Drawing.Size(413, 96)
        Me.txtGhi_Chu.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(11, 60)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 7264
        Me.Label1.Tag = "Type car"
        Me.Label1.Text = "Ghi chú"
        '
        'LabMa_Xe
        '
        Me.LabMa_Xe.AutoSize = True
        Me.LabMa_Xe.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Xe.Location = New System.Drawing.Point(11, 5)
        Me.LabMa_Xe.Name = "LabMa_Xe"
        Me.LabMa_Xe.Size = New System.Drawing.Size(48, 15)
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
        Me.TxtMa_Xe.Location = New System.Drawing.Point(86, 2)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.ReadOnly = True
        Me.TxtMa_Xe.Size = New System.Drawing.Size(155, 21)
        Me.TxtMa_Xe.TabIndex = 7274
        Me.TxtMa_Xe.TabStop = False
        Me.TxtMa_Xe.Tag = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Navy
        Me.Label7.Location = New System.Drawing.Point(247, 5)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
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
        Me.TxtSo_RO.Location = New System.Drawing.Point(322, 2)
        Me.TxtSo_RO.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSo_RO.Name = "TxtSo_RO"
        Me.TxtSo_RO.ReadOnly = True
        Me.TxtSo_RO.Size = New System.Drawing.Size(177, 21)
        Me.TxtSo_RO.TabIndex = 7276
        Me.TxtSo_RO.TabStop = False
        Me.TxtSo_RO.Tag = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(11, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 7280
        Me.Label2.Tag = "Type car"
        Me.Label2.Text = "Tầng chuyển"
        '
        'TxtStt_Rec_Ro
        '
        Me.TxtStt_Rec_Ro.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec_Ro.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec_Ro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtStt_Rec_Ro.ForeColor = System.Drawing.Color.Blue
        Me.TxtStt_Rec_Ro.Location = New System.Drawing.Point(217, 167)
        Me.TxtStt_Rec_Ro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec_Ro.Name = "TxtStt_Rec_Ro"
        Me.TxtStt_Rec_Ro.Size = New System.Drawing.Size(45, 21)
        Me.TxtStt_Rec_Ro.TabIndex = 7282
        Me.TxtStt_Rec_Ro.TabStop = False
        Me.TxtStt_Rec_Ro.Tag = ""
        Me.TxtStt_Rec_Ro.Visible = False
        '
        'TxtForeColor_Ghichu
        '
        Me.TxtForeColor_Ghichu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtForeColor_Ghichu.BackColor = System.Drawing.Color.White
        Me.TxtForeColor_Ghichu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtForeColor_Ghichu.ForeColor = System.Drawing.Color.Blue
        Me.TxtForeColor_Ghichu.Location = New System.Drawing.Point(42, 83)
        Me.TxtForeColor_Ghichu.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtForeColor_Ghichu.Name = "TxtForeColor_Ghichu"
        Me.TxtForeColor_Ghichu.Size = New System.Drawing.Size(37, 21)
        Me.TxtForeColor_Ghichu.TabIndex = 7284
        Me.TxtForeColor_Ghichu.TabStop = False
        Me.TxtForeColor_Ghichu.Tag = ""
        Me.TxtForeColor_Ghichu.Visible = False
        '
        'ButtForeColor_Choose
        '
        Me.ButtForeColor_Choose.Image = CType(resources.GetObject("ButtForeColor_Choose.Image"), System.Drawing.Image)
        Me.ButtForeColor_Choose.Location = New System.Drawing.Point(14, 83)
        Me.ButtForeColor_Choose.Name = "ButtForeColor_Choose"
        Me.ButtForeColor_Choose.Size = New System.Drawing.Size(26, 23)
        Me.ButtForeColor_Choose.TabIndex = 7286
        Me.ButtForeColor_Choose.ToolTip = "Màu chữ"
        '
        'ButtBackColor_Choose
        '
        Me.ButtBackColor_Choose.Image = CType(resources.GetObject("ButtBackColor_Choose.Image"), System.Drawing.Image)
        Me.ButtBackColor_Choose.Location = New System.Drawing.Point(14, 112)
        Me.ButtBackColor_Choose.Name = "ButtBackColor_Choose"
        Me.ButtBackColor_Choose.Size = New System.Drawing.Size(26, 23)
        Me.ButtBackColor_Choose.TabIndex = 7287
        Me.ButtBackColor_Choose.ToolTip = "Màu nền"
        '
        'TxtBackColor_Ghichu
        '
        Me.TxtBackColor_Ghichu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBackColor_Ghichu.BackColor = System.Drawing.Color.White
        Me.TxtBackColor_Ghichu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtBackColor_Ghichu.ForeColor = System.Drawing.Color.Blue
        Me.TxtBackColor_Ghichu.Location = New System.Drawing.Point(44, 114)
        Me.TxtBackColor_Ghichu.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBackColor_Ghichu.Name = "TxtBackColor_Ghichu"
        Me.TxtBackColor_Ghichu.Size = New System.Drawing.Size(35, 21)
        Me.TxtBackColor_Ghichu.TabIndex = 7288
        Me.TxtBackColor_Ghichu.TabStop = False
        Me.TxtBackColor_Ghichu.Tag = ""
        Me.TxtBackColor_Ghichu.Visible = False
        '
        'buttRemove_Forecolor
        '
        Me.buttRemove_Forecolor.Image = CType(resources.GetObject("buttRemove_Forecolor.Image"), System.Drawing.Image)
        Me.buttRemove_Forecolor.Location = New System.Drawing.Point(42, 83)
        Me.buttRemove_Forecolor.Name = "buttRemove_Forecolor"
        Me.buttRemove_Forecolor.Size = New System.Drawing.Size(26, 23)
        Me.buttRemove_Forecolor.TabIndex = 7289
        Me.buttRemove_Forecolor.ToolTip = "Màu chữ"
        '
        'buttRemove_backcolor
        '
        Me.buttRemove_backcolor.Image = CType(resources.GetObject("buttRemove_backcolor.Image"), System.Drawing.Image)
        Me.buttRemove_backcolor.Location = New System.Drawing.Point(42, 112)
        Me.buttRemove_backcolor.Name = "buttRemove_backcolor"
        Me.buttRemove_backcolor.Size = New System.Drawing.Size(26, 23)
        Me.buttRemove_backcolor.TabIndex = 7290
        Me.buttRemove_backcolor.ToolTip = "Màu chữ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(247, 27)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 15)
        Me.Label3.TabIndex = 7291
        Me.Label3.Tag = "Type car"
        Me.Label3.Text = "Tầng nhận"
        '
        'CbbMa_TangChuyen
        '
        Me.CbbMa_TangChuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TangChuyen.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_TangChuyen.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TangChuyen.FormattingEnabled = True
        Me.CbbMa_TangChuyen.Location = New System.Drawing.Point(86, 25)
        Me.CbbMa_TangChuyen.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_TangChuyen.Name = "CbbMa_TangChuyen"
        Me.CbbMa_TangChuyen.Size = New System.Drawing.Size(157, 22)
        Me.CbbMa_TangChuyen.TabIndex = 7292
        '
        'CbbMa_TangNhan
        '
        Me.CbbMa_TangNhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TangNhan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_TangNhan.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TangNhan.FormattingEnabled = True
        Me.CbbMa_TangNhan.Location = New System.Drawing.Point(322, 25)
        Me.CbbMa_TangNhan.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_TangNhan.Name = "CbbMa_TangNhan"
        Me.CbbMa_TangNhan.Size = New System.Drawing.Size(177, 22)
        Me.CbbMa_TangNhan.TabIndex = 7293
        '
        'FrmChuyentang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(509, 218)
        Me.Controls.Add(Me.CbbMa_TangNhan)
        Me.Controls.Add(Me.CbbMa_TangChuyen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.buttRemove_backcolor)
        Me.Controls.Add(Me.buttRemove_Forecolor)
        Me.Controls.Add(Me.TxtBackColor_Ghichu)
        Me.Controls.Add(Me.ButtBackColor_Choose)
        Me.Controls.Add(Me.ButtForeColor_Choose)
        Me.Controls.Add(Me.TxtForeColor_Ghichu)
        Me.Controls.Add(Me.TxtStt_Rec_Ro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtSo_RO)
        Me.Controls.Add(Me.LabMa_Xe)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtGhi_Chu)
        Me.Controls.Add(Me.TxtStt_Rec_KH)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmChuyentang"
        Me.Text = "Chuyển tầng"
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec_KH, 0)
        Me.Controls.SetChildIndex(Me.txtGhi_Chu, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_RO, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec_Ro, 0)
        Me.Controls.SetChildIndex(Me.TxtForeColor_Ghichu, 0)
        Me.Controls.SetChildIndex(Me.ButtForeColor_Choose, 0)
        Me.Controls.SetChildIndex(Me.ButtBackColor_Choose, 0)
        Me.Controls.SetChildIndex(Me.TxtBackColor_Ghichu, 0)
        Me.Controls.SetChildIndex(Me.buttRemove_Forecolor, 0)
        Me.Controls.SetChildIndex(Me.buttRemove_backcolor, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TangChuyen, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TangNhan, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec_KH As System.Windows.Forms.TextBox
    Friend WithEvents txtGhi_Chu As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabMa_Xe As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_RO As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtStt_Rec_Ro As System.Windows.Forms.TextBox
    Friend WithEvents CldChon_ForeColor As System.Windows.Forms.ColorDialog
    Friend WithEvents TxtForeColor_Ghichu As System.Windows.Forms.TextBox
    Friend WithEvents ButtForeColor_Choose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtBackColor_Choose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtBackColor_Ghichu As System.Windows.Forms.TextBox
    Friend WithEvents CldChon_Backcolor As System.Windows.Forms.ColorDialog
    Friend WithEvents buttRemove_Forecolor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents buttRemove_backcolor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_TangChuyen As System.Windows.Forms.ComboBox
    Friend WithEvents CbbMa_TangNhan As System.Windows.Forms.ComboBox

End Class
