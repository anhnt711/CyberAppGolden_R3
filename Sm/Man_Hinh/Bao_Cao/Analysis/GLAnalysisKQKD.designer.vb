<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLAnalysisKQKD
    Inherits Cyber.From.FilterReport

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
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabSo_Ct1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbbMa_Ky = New System.Windows.Forms.ComboBox()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.LabNam = New System.Windows.Forms.Label()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.LabThang = New System.Windows.Forms.Label()
        Me.LabNgay = New System.Windows.Forms.Label()
        Me.TxtSo_Ky = New ClsTextBox.txtTien_NT()
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(632, 182)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 32
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(121, 128)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(636, 25)
        Me.CBBMa_Dvcs.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Size = New System.Drawing.Size(59, 17)
        Me.Label1.TabIndex = 33
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(493, 182)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 31
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(11, 105)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLoai_NT.Size = New System.Drawing.Size(59, 17)
        Me.LabLoai_NT.TabIndex = 34
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(121, 105)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 4
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(273, 105)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 5
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 166)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(761, 12)
        Me.GroupBoxLine.TabIndex = 30
        Me.GroupBoxLine.TabStop = False
        '
        'LabSo_Ct1
        '
        Me.LabSo_Ct1.Location = New System.Drawing.Point(11, 46)
        Me.LabSo_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabSo_Ct1.Name = "LabSo_Ct1"
        Me.LabSo_Ct1.Size = New System.Drawing.Size(59, 20)
        Me.LabSo_Ct1.TabIndex = 493
        Me.LabSo_Ct1.Tag = "Periods"
        Me.LabSo_Ct1.Text = "Số kỳ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 17)
        Me.Label5.TabIndex = 520
        Me.Label5.Tag = "Period type"
        Me.Label5.Text = "Loại kỳ "
        '
        'CbbMa_Ky
        '
        Me.CbbMa_Ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Ky.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Ky.FormattingEnabled = True
        Me.CbbMa_Ky.Location = New System.Drawing.Point(121, 9)
        Me.CbbMa_Ky.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbMa_Ky.Name = "CbbMa_Ky"
        Me.CbbMa_Ky.Size = New System.Drawing.Size(636, 25)
        Me.CbbMa_Ky.TabIndex = 0
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(411, 73)
        Me.CbbM_Nam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(109, 25)
        Me.CbbM_Nam.TabIndex = 3
        '
        'LabNam
        '
        Me.LabNam.AutoSize = True
        Me.LabNam.Location = New System.Drawing.Point(356, 78)
        Me.LabNam.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNam.Name = "LabNam"
        Me.LabNam.Size = New System.Drawing.Size(36, 17)
        Me.LabNam.TabIndex = 621
        Me.LabNam.Tag = "Year"
        Me.LabNam.Text = "Năm"
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(121, 73)
        Me.CbbM_Thang1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(132, 25)
        Me.CbbM_Thang1.TabIndex = 5
        '
        'LabThang
        '
        Me.LabThang.AutoSize = True
        Me.LabThang.Location = New System.Drawing.Point(11, 78)
        Me.LabThang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabThang.Name = "LabThang"
        Me.LabThang.Size = New System.Drawing.Size(98, 17)
        Me.LabThang.TabIndex = 620
        Me.LabThang.Tag = "Month from"
        Me.LabThang.Text = "Tháng bắt đầu"
        '
        'LabNgay
        '
        Me.LabNgay.Location = New System.Drawing.Point(11, 77)
        Me.LabNgay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNgay.Name = "LabNgay"
        Me.LabNgay.Size = New System.Drawing.Size(107, 20)
        Me.LabNgay.TabIndex = 623
        Me.LabNgay.Tag = "Start date"
        Me.LabNgay.Text = "Ngày bắt đầu"
        '
        'TxtSo_Ky
        '
        Me.TxtSo_Ky.AllowNegative = True
        Me.TxtSo_Ky.Flags = 7680
        Me.TxtSo_Ky.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtSo_Ky.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_Ky.InputMask = "### ### ### ### ###"
        Me.TxtSo_Ky.Location = New System.Drawing.Point(121, 42)
        Me.TxtSo_Ky.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSo_Ky.MaxWholeDigits = 14
        Me.TxtSo_Ky.Name = "TxtSo_Ky"
        Me.TxtSo_Ky.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_Ky.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_Ky.Size = New System.Drawing.Size(132, 24)
        Me.TxtSo_Ky.TabIndex = 1
        Me.TxtSo_Ky.Text = "3"
        Me.TxtSo_Ky.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(121, 73)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(132, 24)
        Me.TxtM_Ngay_Ct1.TabIndex = 2
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'GLAnalysisKQKD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(771, 255)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtSo_Ky)
        Me.Controls.Add(Me.LabNgay)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.LabNam)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.LabThang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CbbMa_Ky)
        Me.Controls.Add(Me.LabSo_Ct1)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "GLAnalysisKQKD"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabSo_Ct1, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Ky, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.LabThang, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.LabNam, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.LabNgay, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ky, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabSo_Ct1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CbbMa_Ky As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents LabNam As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabThang As System.Windows.Forms.Label
    Friend WithEvents LabNgay As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ky As ClsTextBox.txtTien_NT
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1

End Class
