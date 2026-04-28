<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DTB05
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
        Me.LabMa_Vv = New System.Windows.Forms.Label()
        Me.TxtTen_Vv = New System.Windows.Forms.TextBox()
        Me.TxtMa_Vv = New Cyber.SmLists.TxtLookup()
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Tk = New System.Windows.Forms.TextBox()
        Me.LabM_Tk = New System.Windows.Forms.Label()
        Me.TxtTK02 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_TK02 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTK03 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_TK03 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Vv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTK02.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTK03.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(656, 286)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 10
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 235)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(653, 25)
        Me.CBBMa_Dvcs.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 239)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(517, 286)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 9
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(12, 207)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 207)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 6
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(281, 208)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 7
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(145, 12)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(145, 44)
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
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(12, 16)
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
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(12, 48)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 264)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(785, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_Vv
        '
        Me.LabMa_Vv.AutoSize = True
        Me.LabMa_Vv.Location = New System.Drawing.Point(12, 78)
        Me.LabMa_Vv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Vv.Name = "LabMa_Vv"
        Me.LabMa_Vv.Size = New System.Drawing.Size(73, 17)
        Me.LabMa_Vv.TabIndex = 403
        Me.LabMa_Vv.Tag = "Case"
        Me.LabMa_Vv.Text = "Mã vụ việc"
        '
        'TxtTen_Vv
        '
        Me.TxtTen_Vv.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Vv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Vv.Enabled = False
        Me.TxtTen_Vv.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Vv.Location = New System.Drawing.Point(304, 78)
        Me.TxtTen_Vv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Vv.Name = "TxtTen_Vv"
        Me.TxtTen_Vv.ReadOnly = True
        Me.TxtTen_Vv.Size = New System.Drawing.Size(477, 17)
        Me.TxtTen_Vv.TabIndex = 402
        Me.TxtTen_Vv.TabStop = False
        '
        'TxtMa_Vv
        '
        Me.TxtMa_Vv._ActilookupPopup = False
        Me.TxtMa_Vv.CyberActilookupPopup = True
        Me.TxtMa_Vv.Dv_ListDetail = Nothing
        Me.TxtMa_Vv.Dv_Master = Nothing
        Me.TxtMa_Vv.FilterClient = ""
        Me.TxtMa_Vv.FilterSQL = ""
        Me.TxtMa_Vv.Location = New System.Drawing.Point(145, 75)
        Me.TxtMa_Vv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Vv.Name = "TxtMa_Vv"
        Me.TxtMa_Vv.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vv.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vv.Size = New System.Drawing.Size(152, 22)
        Me.TxtMa_Vv.TabIndex = 2
        Me.TxtMa_Vv.Table_Name = ""
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(145, 106)
        Me.TxtTk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseFont = True
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(152, 24)
        Me.TxtTk.TabIndex = 3
        Me.TxtTk.Table_Name = ""
        '
        'Txtten_Tk
        '
        Me.Txtten_Tk.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Tk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Tk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Tk.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk.Location = New System.Drawing.Point(304, 111)
        Me.Txtten_Tk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_Tk.Name = "Txtten_Tk"
        Me.Txtten_Tk.ReadOnly = True
        Me.Txtten_Tk.Size = New System.Drawing.Size(477, 16)
        Me.Txtten_Tk.TabIndex = 406
        Me.Txtten_Tk.TabStop = False
        '
        'LabM_Tk
        '
        Me.LabM_Tk.AutoSize = True
        Me.LabM_Tk.Location = New System.Drawing.Point(12, 110)
        Me.LabM_Tk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(115, 17)
        Me.LabM_Tk.TabIndex = 405
        Me.LabM_Tk.Tag = "Construction acc"
        Me.LabM_Tk.Text = "Tài khoản xây lắp"
        '
        'TxtTK02
        '
        Me.TxtTK02._ActilookupPopup = False
        Me.TxtTK02.CyberActilookupPopup = True
        Me.TxtTK02.Dv_ListDetail = Nothing
        Me.TxtTK02.Dv_Master = Nothing
        Me.TxtTK02.FilterClient = ""
        Me.TxtTK02.FilterSQL = ""
        Me.TxtTK02.Location = New System.Drawing.Point(145, 137)
        Me.TxtTK02.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTK02.Name = "TxtTK02"
        Me.TxtTK02.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTK02.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTK02.Properties.Appearance.Options.UseFont = True
        Me.TxtTK02.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTK02.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTK02.Size = New System.Drawing.Size(152, 24)
        Me.TxtTK02.TabIndex = 4
        Me.TxtTK02.Table_Name = ""
        '
        'TxtTen_TK02
        '
        Me.TxtTen_TK02.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TK02.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TK02.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_TK02.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK02.Location = New System.Drawing.Point(304, 143)
        Me.TxtTen_TK02.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TK02.Name = "TxtTen_TK02"
        Me.TxtTen_TK02.ReadOnly = True
        Me.TxtTen_TK02.Size = New System.Drawing.Size(477, 16)
        Me.TxtTen_TK02.TabIndex = 409
        Me.TxtTen_TK02.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 141)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 17)
        Me.Label2.TabIndex = 408
        Me.Label2.Tag = "Device acc"
        Me.Label2.Text = "Tài khoản thiết bị"
        '
        'TxtTK03
        '
        Me.TxtTK03._ActilookupPopup = False
        Me.TxtTK03.CyberActilookupPopup = True
        Me.TxtTK03.Dv_ListDetail = Nothing
        Me.TxtTK03.Dv_Master = Nothing
        Me.TxtTK03.FilterClient = ""
        Me.TxtTK03.FilterSQL = ""
        Me.TxtTK03.Location = New System.Drawing.Point(145, 169)
        Me.TxtTK03.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTK03.Name = "TxtTK03"
        Me.TxtTK03.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTK03.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTK03.Properties.Appearance.Options.UseFont = True
        Me.TxtTK03.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTK03.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTK03.Size = New System.Drawing.Size(152, 24)
        Me.TxtTK03.TabIndex = 5
        Me.TxtTK03.Table_Name = ""
        '
        'TxtTen_TK03
        '
        Me.TxtTen_TK03.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TK03.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TK03.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_TK03.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK03.Location = New System.Drawing.Point(304, 174)
        Me.TxtTen_TK03.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TK03.Name = "TxtTen_TK03"
        Me.TxtTen_TK03.ReadOnly = True
        Me.TxtTen_TK03.Size = New System.Drawing.Size(477, 16)
        Me.TxtTen_TK03.TabIndex = 412
        Me.TxtTen_TK03.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 173)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 17)
        Me.Label3.TabIndex = 411
        Me.Label3.Tag = "Other acc"
        Me.Label3.Text = "Tài khoản khác"
        '
        'DTB05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(795, 356)
        Me.Controls.Add(Me.TxtTK03)
        Me.Controls.Add(Me.TxtTen_TK03)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTK02)
        Me.Controls.Add(Me.TxtTen_TK02)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTk)
        Me.Controls.Add(Me.Txtten_Tk)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.LabMa_Vv)
        Me.Controls.Add(Me.TxtTen_Vv)
        Me.Controls.Add(Me.TxtMa_Vv)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "DTB05"
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
        Me.Controls.SetChildIndex(Me.TxtMa_Vv, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vv, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Vv, 0)
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK02, 0)
        Me.Controls.SetChildIndex(Me.TxtTK02, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK03, 0)
        Me.Controls.SetChildIndex(Me.TxtTK03, 0)
        CType(Me.TxtMa_Vv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTK02.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTK03.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_Vv As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Vv As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Vv As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk As System.Windows.Forms.TextBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtTK02 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_TK02 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTK03 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_TK03 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
