<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COBKGT1
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
        Me.LabMa_Phi = New System.Windows.Forms.Label()
        Me.TxtTen_Cd = New System.Windows.Forms.TextBox()
        Me.TxtMa_Cd = New Cyber.SmLists.TxtLookup()
        Me.LabMa_HD = New System.Windows.Forms.Label()
        Me.TxtTen_vt = New System.Windows.Forms.TextBox()
        Me.TxtMa_vt = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Vv = New System.Windows.Forms.Label()
        Me.TxtTen_TK = New System.Windows.Forms.TextBox()
        Me.TxtTK = New Cyber.SmLists.TxtLookup()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbM_Thang2 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.LabM_month2 = New System.Windows.Forms.Label()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Cd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTK.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(635, 280)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 29
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 229)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(632, 25)
        Me.CBBMa_Dvcs.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 233)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(496, 280)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 28
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 204)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 200)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 25
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(292, 200)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 26
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 258)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(764, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_Phi
        '
        Me.LabMa_Phi.AutoSize = True
        Me.LabMa_Phi.Location = New System.Drawing.Point(12, 162)
        Me.LabMa_Phi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Phi.Name = "LabMa_Phi"
        Me.LabMa_Phi.Size = New System.Drawing.Size(95, 17)
        Me.LabMa_Phi.TabIndex = 464
        Me.LabMa_Phi.Tag = "Stage"
        Me.LabMa_Phi.Text = "Mã công đoạn"
        '
        'TxtTen_Cd
        '
        Me.TxtTen_Cd.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Cd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Cd.Enabled = False
        Me.TxtTen_Cd.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cd.Location = New System.Drawing.Point(275, 162)
        Me.TxtTen_Cd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Cd.Name = "TxtTen_Cd"
        Me.TxtTen_Cd.ReadOnly = True
        Me.TxtTen_Cd.Size = New System.Drawing.Size(483, 17)
        Me.TxtTen_Cd.TabIndex = 463
        Me.TxtTen_Cd.TabStop = False
        '
        'TxtMa_Cd
        '
        Me.TxtMa_Cd._ActilookupPopup = False
        Me.TxtMa_Cd.CyberActilookupPopup = True
        Me.TxtMa_Cd.Dv_ListDetail = Nothing
        Me.TxtMa_Cd.Dv_Master = Nothing
        Me.TxtMa_Cd.FilterClient = ""
        Me.TxtMa_Cd.FilterSQL = ""
        Me.TxtMa_Cd.Location = New System.Drawing.Point(123, 158)
        Me.TxtMa_Cd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Cd.Name = "TxtMa_Cd"
        Me.TxtMa_Cd.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cd.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cd.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_Cd.TabIndex = 9
        Me.TxtMa_Cd.Table_Name = ""
        '
        'LabMa_HD
        '
        Me.LabMa_HD.AutoSize = True
        Me.LabMa_HD.Location = New System.Drawing.Point(12, 133)
        Me.LabMa_HD.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_HD.Name = "LabMa_HD"
        Me.LabMa_HD.Size = New System.Drawing.Size(70, 17)
        Me.LabMa_HD.TabIndex = 462
        Me.LabMa_HD.Tag = "Product"
        Me.LabMa_HD.Text = "Sản phẩm"
        '
        'TxtTen_vt
        '
        Me.TxtTen_vt.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_vt.Enabled = False
        Me.TxtTen_vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_vt.Location = New System.Drawing.Point(275, 133)
        Me.TxtTen_vt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_vt.Name = "TxtTen_vt"
        Me.TxtTen_vt.ReadOnly = True
        Me.TxtTen_vt.Size = New System.Drawing.Size(483, 17)
        Me.TxtTen_vt.TabIndex = 461
        Me.TxtTen_vt.TabStop = False
        '
        'TxtMa_vt
        '
        Me.TxtMa_vt._ActilookupPopup = False
        Me.TxtMa_vt.CyberActilookupPopup = True
        Me.TxtMa_vt.Dv_ListDetail = Nothing
        Me.TxtMa_vt.Dv_Master = Nothing
        Me.TxtMa_vt.FilterClient = ""
        Me.TxtMa_vt.FilterSQL = ""
        Me.TxtMa_vt.Location = New System.Drawing.Point(123, 129)
        Me.TxtMa_vt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_vt.Name = "TxtMa_vt"
        Me.TxtMa_vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_vt.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_vt.TabIndex = 8
        Me.TxtMa_vt.Table_Name = ""
        '
        'LabMa_Vv
        '
        Me.LabMa_Vv.AutoSize = True
        Me.LabMa_Vv.Location = New System.Drawing.Point(12, 105)
        Me.LabMa_Vv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Vv.Name = "LabMa_Vv"
        Me.LabMa_Vv.Size = New System.Drawing.Size(67, 17)
        Me.LabMa_Vv.TabIndex = 460
        Me.LabMa_Vv.Tag = "Account"
        Me.LabMa_Vv.Text = "Tài khoản"
        '
        'TxtTen_TK
        '
        Me.TxtTen_TK.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TK.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TK.Enabled = False
        Me.TxtTen_TK.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK.Location = New System.Drawing.Point(275, 105)
        Me.TxtTen_TK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TK.Name = "TxtTen_TK"
        Me.TxtTen_TK.ReadOnly = True
        Me.TxtTen_TK.Size = New System.Drawing.Size(483, 17)
        Me.TxtTen_TK.TabIndex = 459
        Me.TxtTen_TK.TabStop = False
        '
        'TxtTK
        '
        Me.TxtTK._ActilookupPopup = False
        Me.TxtTK.CyberActilookupPopup = True
        Me.TxtTK.Dv_ListDetail = Nothing
        Me.TxtTK.Dv_Master = Nothing
        Me.TxtTK.FilterClient = ""
        Me.TxtTK.FilterSQL = ""
        Me.TxtTK.Location = New System.Drawing.Point(123, 101)
        Me.TxtTK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTK.Name = "TxtTK"
        Me.TxtTK.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTK.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTK.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTK.Size = New System.Drawing.Size(147, 22)
        Me.TxtTK.TabIndex = 7
        Me.TxtTK.Table_Name = ""
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(123, 65)
        Me.CbbM_Nam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(145, 25)
        Me.CbbM_Nam.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 496
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'CbbM_Thang2
        '
        Me.CbbM_Thang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang2.FormattingEnabled = True
        Me.CbbM_Thang2.Location = New System.Drawing.Point(123, 37)
        Me.CbbM_Thang2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang2.Name = "CbbM_Thang2"
        Me.CbbM_Thang2.Size = New System.Drawing.Size(145, 25)
        Me.CbbM_Thang2.TabIndex = 1
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(123, 8)
        Me.CbbM_Thang1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(145, 25)
        Me.CbbM_Thang1.TabIndex = 0
        '
        'LabM_month2
        '
        Me.LabM_month2.AutoSize = True
        Me.LabM_month2.Location = New System.Drawing.Point(12, 41)
        Me.LabM_month2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month2.Name = "LabM_month2"
        Me.LabM_month2.Size = New System.Drawing.Size(73, 17)
        Me.LabM_month2.TabIndex = 495
        Me.LabM_month2.Tag = "Month to"
        Me.LabM_month2.Text = "Đến tháng"
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(12, 12)
        Me.LabM_month1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(65, 17)
        Me.LabM_month1.TabIndex = 494
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Từ tháng"
        '
        'COBKGT1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(773, 349)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.LabM_month2)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.LabMa_Phi)
        Me.Controls.Add(Me.TxtTen_Cd)
        Me.Controls.Add(Me.TxtMa_Cd)
        Me.Controls.Add(Me.LabMa_HD)
        Me.Controls.Add(Me.TxtTen_vt)
        Me.Controls.Add(Me.TxtMa_vt)
        Me.Controls.Add(Me.LabMa_Vv)
        Me.Controls.Add(Me.TxtTen_TK)
        Me.Controls.Add(Me.TxtTK)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "COBKGT1"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtTK, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Vv, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vt, 0)
        Me.Controls.SetChildIndex(Me.LabMa_HD, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cd, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cd, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.LabM_month2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        CType(Me.TxtMa_Cd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTK.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_Phi As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Cd As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Cd As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_HD As System.Windows.Forms.Label
    Friend WithEvents TxtTen_vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_vt As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Vv As System.Windows.Forms.Label
    Friend WithEvents TxtTen_TK As System.Windows.Forms.TextBox
    Friend WithEvents TxtTK As Cyber.SmLists.TxtLookup
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month2 As System.Windows.Forms.Label
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label

End Class
