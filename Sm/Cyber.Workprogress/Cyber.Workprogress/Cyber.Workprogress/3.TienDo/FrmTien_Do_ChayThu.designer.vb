<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTien_Do_ChayThu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTien_Do_ChayThu))
        Me.TxtNgay_BD = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Ct = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.ChkKet_Thuc = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNgay_KT = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtTG_SC = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmdPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.CmdSave = New DevExpress.XtraEditors.SimpleButton()
        Me.LabTinh_Trang = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(1, 159)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(636, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Image = CType(resources.GetObject("ButtOK.Image"), System.Drawing.Image)
        Me.ButtOK.Location = New System.Drawing.Point(451, 176)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.Size = New System.Drawing.Size(95, 30)
        Me.ButtOK.TabIndex = 10
        Me.ButtOK.Text = "&Lưu - In phiếu"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Image = CType(resources.GetObject("ButtExit.Image"), System.Drawing.Image)
        Me.ButtExit.Location = New System.Drawing.Point(549, 176)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.Size = New System.Drawing.Size(95, 30)
        Me.ButtExit.TabIndex = 11
        '
        'TxtNgay_BD
        '
        Me.TxtNgay_BD.BackColor = System.Drawing.Color.White
        Me.TxtNgay_BD.Flags = 0
        Me.TxtNgay_BD.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_BD.IsAllowResize = False
        Me.TxtNgay_BD.Location = New System.Drawing.Point(91, 49)
        Me.TxtNgay_BD.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD.MaxLength = 10
        Me.TxtNgay_BD.Name = "TxtNgay_BD"
        Me.TxtNgay_BD.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD.ShowDayBeforeMonth = False
        Me.TxtNgay_BD.Size = New System.Drawing.Size(162, 23)
        Me.TxtNgay_BD.TabIndex = 8
        Me.TxtNgay_BD.Value = "10/04/2020 22:44"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(18, 53)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 15)
        Me.Label15.TabIndex = 7143
        Me.Label15.Tag = ""
        Me.Label15.Text = "Bắt đầu"
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(44, 245)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(45, 21)
        Me.TxtMa_Dvcs.TabIndex = 7148
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
        Me.TxtMa_Ct.Location = New System.Drawing.Point(97, 245)
        Me.TxtMa_Ct.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Ct.Name = "TxtMa_Ct"
        Me.TxtMa_Ct.Size = New System.Drawing.Size(45, 21)
        Me.TxtMa_Ct.TabIndex = 7149
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
        Me.TxtStt_Rec.Location = New System.Drawing.Point(150, 245)
        Me.TxtStt_Rec.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(45, 21)
        Me.TxtStt_Rec.TabIndex = 7150
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Tag = ""
        Me.TxtStt_Rec.Visible = False
        '
        'ChkKet_Thuc
        '
        Me.ChkKet_Thuc.AutoSize = True
        Me.ChkKet_Thuc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkKet_Thuc.ForeColor = System.Drawing.Color.Blue
        Me.ChkKet_Thuc.Location = New System.Drawing.Point(91, 137)
        Me.ChkKet_Thuc.Name = "ChkKet_Thuc"
        Me.ChkKet_Thuc.Size = New System.Drawing.Size(74, 17)
        Me.ChkKet_Thuc.TabIndex = 7152
        Me.ChkKet_Thuc.TabStop = False
        Me.ChkKet_Thuc.Tag = "Finish"
        Me.ChkKet_Thuc.Text = "Kết thúc"
        Me.ChkKet_Thuc.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(18, 109)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 7154
        Me.Label1.Tag = ""
        Me.Label1.Text = "Kết thúc"
        '
        'TxtNgay_KT
        '
        Me.TxtNgay_KT.BackColor = System.Drawing.Color.White
        Me.TxtNgay_KT.Flags = 0
        Me.TxtNgay_KT.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_KT.IsAllowResize = False
        Me.TxtNgay_KT.Location = New System.Drawing.Point(91, 105)
        Me.TxtNgay_KT.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT.MaxLength = 10
        Me.TxtNgay_KT.Name = "TxtNgay_KT"
        Me.TxtNgay_KT.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT.ShowDayBeforeMonth = False
        Me.TxtNgay_KT.Size = New System.Drawing.Size(162, 23)
        Me.TxtNgay_KT.TabIndex = 7153
        Me.TxtNgay_KT.Value = "10/04/2020 22:44"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(15, 78)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 19)
        Me.Label13.TabIndex = 7156
        Me.Label13.Tag = ""
        Me.Label13.Text = "Thời gian"
        '
        'TxtTG_SC
        '
        Me.TxtTG_SC.AllowNegative = True
        Me.TxtTG_SC.BackColor = System.Drawing.Color.White
        Me.TxtTG_SC.Flags = 7680
        Me.TxtTG_SC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTG_SC.ForeColor = System.Drawing.Color.Navy
        Me.TxtTG_SC.InputMask = "### ### ### ### ### ###"
        Me.TxtTG_SC.Location = New System.Drawing.Point(91, 78)
        Me.TxtTG_SC.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTG_SC.MaxWholeDigits = 17
        Me.TxtTG_SC.Name = "TxtTG_SC"
        Me.TxtTG_SC.RangeMax = 1.7976931348623157E+308R
        Me.TxtTG_SC.RangeMin = -1.7976931348623157E+308R
        Me.TxtTG_SC.Size = New System.Drawing.Size(162, 23)
        Me.TxtTG_SC.TabIndex = 7155
        Me.TxtTG_SC.Text = "0"
        Me.TxtTG_SC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(257, 138)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 19)
        Me.Label2.TabIndex = 7157
        Me.Label2.Tag = ""
        Me.Label2.Text = "Phiếu chạy thử tự cấp phiếu phiếu xe ra cổng"
        '
        'CmdPrint
        '
        Me.CmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdPrint.Image = Global.Cyber.Workprogress.My.Resources.Resources.printer_16x16
        Me.CmdPrint.Location = New System.Drawing.Point(254, 175)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(95, 30)
        Me.CmdPrint.TabIndex = 7158
        Me.CmdPrint.Text = "In phiếu"
        '
        'CmdSave
        '
        Me.CmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdSave.Image = CType(resources.GetObject("CmdSave.Image"), System.Drawing.Image)
        Me.CmdSave.Location = New System.Drawing.Point(353, 175)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(95, 30)
        Me.CmdSave.TabIndex = 7159
        Me.CmdSave.Tag = "Save"
        Me.CmdSave.Text = "Lưu"
        '
        'LabTinh_Trang
        '
        Me.LabTinh_Trang.BackColor = System.Drawing.Color.Gray
        Me.LabTinh_Trang.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTinh_Trang.ForeColor = System.Drawing.Color.White
        Me.LabTinh_Trang.Location = New System.Drawing.Point(-1, 0)
        Me.LabTinh_Trang.Margin = New System.Windows.Forms.Padding(0)
        Me.LabTinh_Trang.Name = "LabTinh_Trang"
        Me.LabTinh_Trang.Size = New System.Drawing.Size(646, 44)
        Me.LabTinh_Trang.TabIndex = 7160
        Me.LabTinh_Trang.Tag = ""
        Me.LabTinh_Trang.Text = "ĐÃ HOÀN THÀNH CHẠY THỬ, BẠN CÓ CẤP CHẠY THỬ MỚI KHÔNG ?"
        Me.LabTinh_Trang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmTien_Do_ChayThu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(645, 230)
        Me.Controls.Add(Me.LabTinh_Trang)
        Me.Controls.Add(Me.CmdSave)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtTG_SC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtNgay_KT)
        Me.Controls.Add(Me.ChkKet_Thuc)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Ct)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.TxtNgay_BD)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmTien_Do_ChayThu"
        Me.Text = "XÁC NHẬN CHẠY THỬ"
        Me.Controls.SetChildIndex(Me.TxtNgay_BD, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.ChkKet_Thuc, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTG_SC, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CmdPrint, 0)
        Me.Controls.SetChildIndex(Me.CmdSave, 0)
        Me.Controls.SetChildIndex(Me.LabTinh_Trang, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_BD As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Ct As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents ChkKet_Thuc As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_KT As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtTG_SC As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmdPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CmdSave As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabTinh_Trang As System.Windows.Forms.Label

End Class
