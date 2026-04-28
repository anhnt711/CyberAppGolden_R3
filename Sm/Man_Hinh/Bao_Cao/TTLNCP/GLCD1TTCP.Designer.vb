<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLCD1TTCP
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
        Me.TxtM_Ngay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.ChkM_LK = New System.Windows.Forms.CheckBox()
        Me.CbbM_Bac_TK = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtM_Ma_TTCP = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_TTCP = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtM_Ma_TTLN = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_TTLN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.TxtM_Ma_TTCP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtM_Ma_TTLN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(656, 228)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 9
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 177)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(653, 25)
        Me.CBBMa_Dvcs.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 180)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(517, 228)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 8
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 149)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 148)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 5
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(279, 149)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 6
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(127, 9)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct1.TabIndex = 0
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(127, 39)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(13, 16)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(60, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(13, 50)
        Me.LabM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(68, 17)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 205)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(785, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'ChkM_LK
        '
        Me.ChkM_LK.Location = New System.Drawing.Point(443, 47)
        Me.ChkM_LK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkM_LK.Name = "ChkM_LK"
        Me.ChkM_LK.Size = New System.Drawing.Size(347, 24)
        Me.ChkM_LK.TabIndex = 3
        Me.ChkM_LK.Tag = "Accumulated charge incurred"
        Me.ChkM_LK.Text = "Tính phát sinh lũy kế"
        Me.ChkM_LK.UseVisualStyleBackColor = True
        '
        'CbbM_Bac_TK
        '
        Me.CbbM_Bac_TK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Bac_TK.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Bac_TK.FormattingEnabled = True
        Me.CbbM_Bac_TK.Location = New System.Drawing.Point(443, 12)
        Me.CbbM_Bac_TK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Bac_TK.Name = "CbbM_Bac_TK"
        Me.CbbM_Bac_TK.Size = New System.Drawing.Size(335, 25)
        Me.CbbM_Bac_TK.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(328, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Tag = "calculate"
        Me.Label2.Text = "Tính"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(328, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Tag = "Account Level"
        Me.Label3.Text = "Bậc tài khoản"
        '
        'TxtM_Ma_TTCP
        '
        Me.TxtM_Ma_TTCP._ActilookupPopup = False
        Me.TxtM_Ma_TTCP.CyberActilookupPopup = True
        Me.TxtM_Ma_TTCP.Dv_ListDetail = Nothing
        Me.TxtM_Ma_TTCP.Dv_Master = Nothing
        Me.TxtM_Ma_TTCP.FilterClient = ""
        Me.TxtM_Ma_TTCP.FilterSQL = ""
        Me.TxtM_Ma_TTCP.Location = New System.Drawing.Point(127, 99)
        Me.TxtM_Ma_TTCP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_Ma_TTCP.Name = "TxtM_Ma_TTCP"
        Me.TxtM_Ma_TTCP.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Ma_TTCP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ma_TTCP.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Ma_TTCP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Ma_TTCP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Ma_TTCP.Size = New System.Drawing.Size(152, 24)
        Me.TxtM_Ma_TTCP.TabIndex = 4
        Me.TxtM_Ma_TTCP.Table_Name = ""
        '
        'TxtTen_TTCP
        '
        Me.TxtTen_TTCP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TTCP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TTCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_TTCP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TTCP.Location = New System.Drawing.Point(281, 109)
        Me.TxtTen_TTCP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TTCP.Name = "TxtTen_TTCP"
        Me.TxtTen_TTCP.ReadOnly = True
        Me.TxtTen_TTCP.Size = New System.Drawing.Size(509, 16)
        Me.TxtTen_TTCP.TabIndex = 156
        Me.TxtTen_TTCP.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 103)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 155
        Me.Label4.Tag = "Cost center"
        Me.Label4.Text = "Mã TTCP"
        '
        'TxtM_Ma_TTLN
        '
        Me.TxtM_Ma_TTLN._ActilookupPopup = False
        Me.TxtM_Ma_TTLN.CyberActilookupPopup = True
        Me.TxtM_Ma_TTLN.Dv_ListDetail = Nothing
        Me.TxtM_Ma_TTLN.Dv_Master = Nothing
        Me.TxtM_Ma_TTLN.FilterClient = ""
        Me.TxtM_Ma_TTLN.FilterSQL = ""
        Me.TxtM_Ma_TTLN.Location = New System.Drawing.Point(127, 71)
        Me.TxtM_Ma_TTLN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_Ma_TTLN.Name = "TxtM_Ma_TTLN"
        Me.TxtM_Ma_TTLN.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Ma_TTLN.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ma_TTLN.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Ma_TTLN.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Ma_TTLN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Ma_TTLN.Size = New System.Drawing.Size(152, 24)
        Me.TxtM_Ma_TTLN.TabIndex = 3
        Me.TxtM_Ma_TTLN.Table_Name = ""
        '
        'TxtTen_TTLN
        '
        Me.TxtTen_TTLN.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TTLN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TTLN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_TTLN.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TTLN.Location = New System.Drawing.Point(281, 80)
        Me.TxtTen_TTLN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TTLN.Name = "TxtTen_TTLN"
        Me.TxtTen_TTLN.ReadOnly = True
        Me.TxtTen_TTLN.Size = New System.Drawing.Size(509, 16)
        Me.TxtTen_TTLN.TabIndex = 154
        Me.TxtTen_TTLN.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 75)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 17)
        Me.Label5.TabIndex = 153
        Me.Label5.Tag = "Profit Centers"
        Me.Label5.Text = "Mã TTLN"
        '
        'GLCD1TTCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(795, 297)
        Me.Controls.Add(Me.TxtM_Ma_TTCP)
        Me.Controls.Add(Me.TxtTen_TTCP)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtM_Ma_TTLN)
        Me.Controls.Add(Me.TxtTen_TTLN)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbbM_Bac_TK)
        Me.Controls.Add(Me.ChkM_LK)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "GLCD1TTCP"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.ChkM_LK, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Bac_TK, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TTLN, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ma_TTLN, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TTCP, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ma_TTCP, 0)
        CType(Me.TxtM_Ma_TTCP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtM_Ma_TTLN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents ChkM_LK As System.Windows.Forms.CheckBox
    Friend WithEvents CbbM_Bac_TK As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ma_TTCP As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_TTCP As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ma_TTLN As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_TTLN As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
