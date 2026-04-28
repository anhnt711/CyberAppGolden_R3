<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLSO1TTCP
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
        Me.LabM_Tk = New System.Windows.Forms.Label()
        Me.TxtM_Tk = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Tk = New System.Windows.Forms.TextBox()
        Me.ChkM_GROUP_TK = New System.Windows.Forms.CheckBox()
        Me.TxtM_Ma_TTLN = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_TTLN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtM_Ma_TTCP = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_TTCP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkM_Group_TTCP = New System.Windows.Forms.CheckBox()
        Me.ChkM_Group_TTLN = New System.Windows.Forms.CheckBox()
        CType(Me.TxtM_Tk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtM_Ma_TTLN.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtM_Ma_TTCP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(656, 299)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 12
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 248)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(653, 25)
        Me.CBBMa_Dvcs.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 252)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(517, 299)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 11
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 220)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 220)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 8
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(281, 221)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 9
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(127, 7)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(429, 7)
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
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(13, 10)
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
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(316, 10)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 277)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(785, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabM_Tk
        '
        Me.LabM_Tk.AutoSize = True
        Me.LabM_Tk.Location = New System.Drawing.Point(13, 102)
        Me.LabM_Tk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(67, 17)
        Me.LabM_Tk.TabIndex = 17
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "Tài khoản"
        '
        'TxtM_Tk
        '
        Me.TxtM_Tk._ActilookupPopup = False
        Me.TxtM_Tk.CyberActilookupPopup = True
        Me.TxtM_Tk.Dv_ListDetail = Nothing
        Me.TxtM_Tk.Dv_Master = Nothing
        Me.TxtM_Tk.FilterClient = ""
        Me.TxtM_Tk.FilterSQL = ""
        Me.TxtM_Tk.Location = New System.Drawing.Point(127, 98)
        Me.TxtM_Tk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_Tk.Name = "TxtM_Tk"
        Me.TxtM_Tk.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Tk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Tk.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Tk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Tk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Tk.Size = New System.Drawing.Size(152, 24)
        Me.TxtM_Tk.TabIndex = 4
        Me.TxtM_Tk.Table_Name = ""
        '
        'Txtten_Tk
        '
        Me.Txtten_Tk.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Tk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Tk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Tk.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk.Location = New System.Drawing.Point(281, 107)
        Me.Txtten_Tk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_Tk.Name = "Txtten_Tk"
        Me.Txtten_Tk.ReadOnly = True
        Me.Txtten_Tk.Size = New System.Drawing.Size(509, 16)
        Me.Txtten_Tk.TabIndex = 144
        Me.Txtten_Tk.TabStop = False
        '
        'ChkM_GROUP_TK
        '
        Me.ChkM_GROUP_TK.AutoSize = True
        Me.ChkM_GROUP_TK.Location = New System.Drawing.Point(127, 133)
        Me.ChkM_GROUP_TK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkM_GROUP_TK.Name = "ChkM_GROUP_TK"
        Me.ChkM_GROUP_TK.Size = New System.Drawing.Size(332, 21)
        Me.ChkM_GROUP_TK.TabIndex = 5
        Me.ChkM_GROUP_TK.Tag = "Group by Corresponding acc"
        Me.ChkM_GROUP_TK.Text = "Nhóm theo tài khoản đối ứng của từng chứng từ"
        Me.ChkM_GROUP_TK.UseVisualStyleBackColor = True
        '
        'TxtM_Ma_TTLN
        '
        Me.TxtM_Ma_TTLN._ActilookupPopup = False
        Me.TxtM_Ma_TTLN.CyberActilookupPopup = True
        Me.TxtM_Ma_TTLN.Dv_ListDetail = Nothing
        Me.TxtM_Ma_TTLN.Dv_Master = Nothing
        Me.TxtM_Ma_TTLN.FilterClient = ""
        Me.TxtM_Ma_TTLN.FilterSQL = ""
        Me.TxtM_Ma_TTLN.Location = New System.Drawing.Point(127, 41)
        Me.TxtM_Ma_TTLN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_Ma_TTLN.Name = "TxtM_Ma_TTLN"
        Me.TxtM_Ma_TTLN.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Ma_TTLN.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ma_TTLN.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Ma_TTLN.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Ma_TTLN.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Ma_TTLN.Size = New System.Drawing.Size(152, 24)
        Me.TxtM_Ma_TTLN.TabIndex = 2
        Me.TxtM_Ma_TTLN.Table_Name = ""
        '
        'TxtTen_TTLN
        '
        Me.TxtTen_TTLN.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TTLN.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TTLN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_TTLN.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TTLN.Location = New System.Drawing.Point(281, 50)
        Me.TxtTen_TTLN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TTLN.Name = "TxtTen_TTLN"
        Me.TxtTen_TTLN.ReadOnly = True
        Me.TxtTen_TTLN.Size = New System.Drawing.Size(509, 16)
        Me.TxtTen_TTLN.TabIndex = 147
        Me.TxtTen_TTLN.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 146
        Me.Label2.Tag = "Profit Centers"
        Me.Label2.Text = "Mã TTLN"
        '
        'TxtM_Ma_TTCP
        '
        Me.TxtM_Ma_TTCP._ActilookupPopup = False
        Me.TxtM_Ma_TTCP.CyberActilookupPopup = True
        Me.TxtM_Ma_TTCP.Dv_ListDetail = Nothing
        Me.TxtM_Ma_TTCP.Dv_Master = Nothing
        Me.TxtM_Ma_TTCP.FilterClient = ""
        Me.TxtM_Ma_TTCP.FilterSQL = ""
        Me.TxtM_Ma_TTCP.Location = New System.Drawing.Point(127, 69)
        Me.TxtM_Ma_TTCP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_Ma_TTCP.Name = "TxtM_Ma_TTCP"
        Me.TxtM_Ma_TTCP.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Ma_TTCP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ma_TTCP.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Ma_TTCP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Ma_TTCP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Ma_TTCP.Size = New System.Drawing.Size(152, 24)
        Me.TxtM_Ma_TTCP.TabIndex = 3
        Me.TxtM_Ma_TTCP.Table_Name = ""
        '
        'TxtTen_TTCP
        '
        Me.TxtTen_TTCP.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TTCP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TTCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_TTCP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TTCP.Location = New System.Drawing.Point(281, 78)
        Me.TxtTen_TTCP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TTCP.Name = "TxtTen_TTCP"
        Me.TxtTen_TTCP.ReadOnly = True
        Me.TxtTen_TTCP.Size = New System.Drawing.Size(509, 16)
        Me.TxtTen_TTCP.TabIndex = 150
        Me.TxtTen_TTCP.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 73)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 149
        Me.Label3.Tag = "Cost center"
        Me.Label3.Text = "Mã TTCP"
        '
        'ChkM_Group_TTCP
        '
        Me.ChkM_Group_TTCP.AutoSize = True
        Me.ChkM_Group_TTCP.Location = New System.Drawing.Point(127, 192)
        Me.ChkM_Group_TTCP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkM_Group_TTCP.Name = "ChkM_Group_TTCP"
        Me.ChkM_Group_TTCP.Size = New System.Drawing.Size(208, 21)
        Me.ChkM_Group_TTCP.TabIndex = 7
        Me.ChkM_Group_TTCP.Tag = "Group by Cost center"
        Me.ChkM_Group_TTCP.Text = "Nhóm theo trung tâm chi phí"
        Me.ChkM_Group_TTCP.UseVisualStyleBackColor = True
        '
        'ChkM_Group_TTLN
        '
        Me.ChkM_Group_TTLN.AutoSize = True
        Me.ChkM_Group_TTLN.Location = New System.Drawing.Point(127, 163)
        Me.ChkM_Group_TTLN.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkM_Group_TTLN.Name = "ChkM_Group_TTLN"
        Me.ChkM_Group_TTLN.Size = New System.Drawing.Size(224, 21)
        Me.ChkM_Group_TTLN.TabIndex = 6
        Me.ChkM_Group_TTLN.Tag = "Group by Profit Centers"
        Me.ChkM_Group_TTLN.Text = "Nhóm theo trung tâm lợi nhuận"
        Me.ChkM_Group_TTLN.UseVisualStyleBackColor = True
        '
        'GLSO1TTCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(795, 369)
        Me.Controls.Add(Me.ChkM_Group_TTLN)
        Me.Controls.Add(Me.ChkM_Group_TTCP)
        Me.Controls.Add(Me.TxtM_Ma_TTCP)
        Me.Controls.Add(Me.TxtTen_TTCP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtM_Ma_TTLN)
        Me.Controls.Add(Me.TxtTen_TTLN)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ChkM_GROUP_TK)
        Me.Controls.Add(Me.TxtM_Tk)
        Me.Controls.Add(Me.Txtten_Tk)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "GLSO1TTCP"
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
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Tk, 0)
        Me.Controls.SetChildIndex(Me.ChkM_GROUP_TK, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TTLN, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ma_TTLN, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TTCP, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ma_TTCP, 0)
        Me.Controls.SetChildIndex(Me.ChkM_Group_TTCP, 0)
        Me.Controls.SetChildIndex(Me.ChkM_Group_TTLN, 0)
        CType(Me.TxtM_Tk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtM_Ma_TTLN.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtM_Ma_TTCP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtM_Tk As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk As System.Windows.Forms.TextBox
    Friend WithEvents ChkM_GROUP_TK As System.Windows.Forms.CheckBox
    Friend WithEvents TxtM_Ma_TTLN As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_TTLN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Ma_TTCP As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_TTCP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkM_Group_TTCP As System.Windows.Forms.CheckBox
    Friend WithEvents ChkM_Group_TTLN As System.Windows.Forms.CheckBox

End Class
