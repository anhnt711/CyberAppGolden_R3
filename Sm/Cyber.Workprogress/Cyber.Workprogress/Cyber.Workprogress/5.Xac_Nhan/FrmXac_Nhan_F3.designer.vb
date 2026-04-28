<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmXac_Nhan_F3
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
        Me.components = New System.ComponentModel.Container()
        Me.SchedulerStorage = New DevExpress.XtraScheduler.SchedulerStorage(Me.components)
        Me.TxtTen_HS_H = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNgay_BD_TH = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.TxtNgay_KT_TH = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.ChkNgayKT = New System.Windows.Forms.CheckBox()
        Me.ChkNgayBD = New System.Windows.Forms.CheckBox()
        CType(Me.SchedulerStorage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 146)
        Me.GroupBoxLine.Size = New System.Drawing.Size(489, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(289, 156)
        Me.ButtOK.TabIndex = 2
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(391, 156)
        Me.ButtExit.TabIndex = 3
        '
        'TxtTen_HS_H
        '
        Me.TxtTen_HS_H.BackColor = System.Drawing.Color.Lavender
        Me.TxtTen_HS_H.Enabled = False
        Me.TxtTen_HS_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_HS_H.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtTen_HS_H.Location = New System.Drawing.Point(303, 10)
        Me.TxtTen_HS_H.Name = "TxtTen_HS_H"
        Me.TxtTen_HS_H.ReadOnly = True
        Me.TxtTen_HS_H.Size = New System.Drawing.Size(179, 21)
        Me.TxtTen_HS_H.TabIndex = 1966
        Me.TxtTen_HS_H.TabStop = False
        Me.TxtTen_HS_H.Tag = ""
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(234, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 15)
        Me.Label3.TabIndex = 1967
        Me.Label3.Tag = "Advisor"
        Me.Label3.Text = "CVDV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(11, 12)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 1965
        Me.Label5.Tag = "R/O"
        Me.Label5.Text = "Số lệnh"
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.BackColor = System.Drawing.Color.Lavender
        Me.TxtSo_Ro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtSo_Ro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Blue
        Me.TxtSo_Ro.Location = New System.Drawing.Point(70, 10)
        Me.TxtSo_Ro.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.ReadOnly = True
        Me.TxtSo_Ro.Size = New System.Drawing.Size(155, 21)
        Me.TxtSo_Ro.TabIndex = 1963
        Me.TxtSo_Ro.TabStop = False
        Me.TxtSo_Ro.Tag = ""
        Me.TxtSo_Ro.Text = "01.S15000001"
        Me.TxtSo_Ro.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.Lavender
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.DarkRed
        Me.TxtMa_Xe.Location = New System.Drawing.Point(70, 37)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.ReadOnly = True
        Me.TxtMa_Xe.Size = New System.Drawing.Size(155, 21)
        Me.TxtMa_Xe.TabIndex = 1962
        Me.TxtMa_Xe.TabStop = False
        Me.TxtMa_Xe.Tag = ""
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(11, 36)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 1964
        Me.Label4.Tag = "Plate"
        Me.Label4.Text = "Biển số"
        '
        'TxtNgay_BD_TH
        '
        Me.TxtNgay_BD_TH.BackColor = System.Drawing.Color.White
        Me.TxtNgay_BD_TH.Flags = 0
        Me.TxtNgay_BD_TH.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_BD_TH.ForeColor = System.Drawing.Color.Red
        Me.TxtNgay_BD_TH.IsAllowResize = False
        Me.TxtNgay_BD_TH.Location = New System.Drawing.Point(70, 79)
        Me.TxtNgay_BD_TH.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_BD_TH.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_BD_TH.MaxLength = 10
        Me.TxtNgay_BD_TH.Name = "TxtNgay_BD_TH"
        Me.TxtNgay_BD_TH.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_BD_TH.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_BD_TH.ShowDayBeforeMonth = False
        Me.TxtNgay_BD_TH.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_BD_TH.TabIndex = 0
        Me.TxtNgay_BD_TH.Value = "27/06/2020 08:21"
        '
        'TxtNgay_KT_TH
        '
        Me.TxtNgay_KT_TH.BackColor = System.Drawing.Color.White
        Me.TxtNgay_KT_TH.Flags = 0
        Me.TxtNgay_KT_TH.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNgay_KT_TH.ForeColor = System.Drawing.Color.Red
        Me.TxtNgay_KT_TH.IsAllowResize = False
        Me.TxtNgay_KT_TH.Location = New System.Drawing.Point(70, 112)
        Me.TxtNgay_KT_TH.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_KT_TH.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_KT_TH.MaxLength = 10
        Me.TxtNgay_KT_TH.Name = "TxtNgay_KT_TH"
        Me.TxtNgay_KT_TH.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_KT_TH.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_KT_TH.ShowDayBeforeMonth = False
        Me.TxtNgay_KT_TH.Size = New System.Drawing.Size(155, 22)
        Me.TxtNgay_KT_TH.TabIndex = 1
        Me.TxtNgay_KT_TH.Value = "27/06/2020 08:21"
        '
        'Label15
        '
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(11, 82)
        Me.Label15.Margin = New System.Windows.Forms.Padding(0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 15)
        Me.Label15.TabIndex = 7141
        Me.Label15.Tag = "Begin"
        Me.Label15.Text = "Bắt đầu"
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(11, 113)
        Me.Label16.Margin = New System.Windows.Forms.Padding(0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 15)
        Me.Label16.TabIndex = 7142
        Me.Label16.Tag = "End"
        Me.Label16.Text = "Kết thúc"
        Me.Label16.Visible = False
        '
        'ChkNgayKT
        '
        Me.ChkNgayKT.AutoSize = True
        Me.ChkNgayKT.Location = New System.Drawing.Point(237, 116)
        Me.ChkNgayKT.Name = "ChkNgayKT"
        Me.ChkNgayKT.Size = New System.Drawing.Size(66, 17)
        Me.ChkNgayKT.TabIndex = 7143
        Me.ChkNgayKT.Text = "Kết thúc"
        Me.ChkNgayKT.UseVisualStyleBackColor = True
        '
        'ChkNgayBD
        '
        Me.ChkNgayBD.AutoSize = True
        Me.ChkNgayBD.Location = New System.Drawing.Point(237, 84)
        Me.ChkNgayBD.Name = "ChkNgayBD"
        Me.ChkNgayBD.Size = New System.Drawing.Size(64, 17)
        Me.ChkNgayBD.TabIndex = 7144
        Me.ChkNgayBD.Text = "Bắt đầu"
        Me.ChkNgayBD.UseVisualStyleBackColor = True
        '
        'FrmXac_Nhan_F3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(493, 210)
        Me.Controls.Add(Me.ChkNgayBD)
        Me.Controls.Add(Me.ChkNgayKT)
        Me.Controls.Add(Me.TxtNgay_BD_TH)
        Me.Controls.Add(Me.TxtNgay_KT_TH)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtTen_HS_H)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtSo_Ro)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmXac_Nhan_F3"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS_H, 0)
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_KT_TH, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_BD_TH, 0)
        Me.Controls.SetChildIndex(Me.ChkNgayKT, 0)
        Me.Controls.SetChildIndex(Me.ChkNgayBD, 0)
        CType(Me.SchedulerStorage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SchedulerStorage As DevExpress.XtraScheduler.SchedulerStorage
    Friend WithEvents TxtTen_HS_H As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ro As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_BD_TH As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents TxtNgay_KT_TH As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents ChkNgayKT As System.Windows.Forms.CheckBox
    Friend WithEvents ChkNgayBD As System.Windows.Forms.CheckBox

End Class
