<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLGSSO4Detail
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
        Me.TxtRec_gs = New Cyber.SmLists.TxtLookup()
        Me.TxtM_Tk = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Tk = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txttk_du = New Cyber.SmLists.TxtLookup()
        Me.Txtten_tk_du = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.TxtRec_gs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtM_Tk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txttk_du.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(656, 234)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 9
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 183)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(653, 25)
        Me.CBBMa_Dvcs.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 187)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(517, 234)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 8
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(12, 154)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 154)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 5
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(281, 156)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 6
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(127, 95)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct1.TabIndex = 2
        Me.TxtM_Ngay_Ct1.Text = "__/__/____"
        Me.TxtM_Ngay_Ct1.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(127, 128)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(151, 24)
        Me.TxtM_Ngay_Ct2.TabIndex = 3
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(12, 99)
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
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(12, 132)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 212)
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
        Me.LabM_Tk.Location = New System.Drawing.Point(12, 10)
        Me.LabM_Tk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(47, 17)
        Me.LabM_Tk.TabIndex = 17
        Me.LabM_Tk.Tag = "No"
        Me.LabM_Tk.Text = "Số rec"
        '
        'TxtRec_gs
        '
        Me.TxtRec_gs._ActilookupPopup = False
        Me.TxtRec_gs.CyberActilookupPopup = True
        Me.TxtRec_gs.Dv_ListDetail = Nothing
        Me.TxtRec_gs.Dv_Master = Nothing
        Me.TxtRec_gs.FilterClient = ""
        Me.TxtRec_gs.FilterSQL = ""
        Me.TxtRec_gs.Location = New System.Drawing.Point(127, 7)
        Me.TxtRec_gs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtRec_gs.Name = "TxtRec_gs"
        Me.TxtRec_gs.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtRec_gs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtRec_gs.Properties.Appearance.Options.UseFont = True
        Me.TxtRec_gs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtRec_gs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtRec_gs.Size = New System.Drawing.Size(152, 24)
        Me.TxtRec_gs.TabIndex = 0
        Me.TxtRec_gs.Table_Name = ""
        '
        'TxtM_Tk
        '
        Me.TxtM_Tk._ActilookupPopup = False
        Me.TxtM_Tk.CyberActilookupPopup = True
        Me.TxtM_Tk.Dv_ListDetail = Nothing
        Me.TxtM_Tk.Dv_Master = Nothing
        Me.TxtM_Tk.FilterClient = ""
        Me.TxtM_Tk.FilterSQL = ""
        Me.TxtM_Tk.Location = New System.Drawing.Point(127, 37)
        Me.TxtM_Tk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_Tk.Name = "TxtM_Tk"
        Me.TxtM_Tk.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Tk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Tk.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Tk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Tk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Tk.Size = New System.Drawing.Size(152, 24)
        Me.TxtM_Tk.TabIndex = 145
        Me.TxtM_Tk.Table_Name = ""
        '
        'Txtten_Tk
        '
        Me.Txtten_Tk.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Tk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Tk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Tk.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk.Location = New System.Drawing.Point(280, 46)
        Me.Txtten_Tk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_Tk.Name = "Txtten_Tk"
        Me.Txtten_Tk.ReadOnly = True
        Me.Txtten_Tk.Size = New System.Drawing.Size(509, 16)
        Me.Txtten_Tk.TabIndex = 147
        Me.Txtten_Tk.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 17)
        Me.Label2.TabIndex = 146
        Me.Label2.Tag = "Account"
        Me.Label2.Text = "Tài khoản"
        '
        'Txttk_du
        '
        Me.Txttk_du._ActilookupPopup = False
        Me.Txttk_du.CyberActilookupPopup = True
        Me.Txttk_du.Dv_ListDetail = Nothing
        Me.Txttk_du.Dv_Master = Nothing
        Me.Txttk_du.FilterClient = ""
        Me.Txttk_du.FilterSQL = ""
        Me.Txttk_du.Location = New System.Drawing.Point(127, 67)
        Me.Txttk_du.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txttk_du.Name = "Txttk_du"
        Me.Txttk_du.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txttk_du.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txttk_du.Properties.Appearance.Options.UseFont = True
        Me.Txttk_du.Properties.Appearance.Options.UseForeColor = True
        Me.Txttk_du.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txttk_du.Size = New System.Drawing.Size(152, 24)
        Me.Txttk_du.TabIndex = 148
        Me.Txttk_du.Table_Name = ""
        '
        'Txtten_tk_du
        '
        Me.Txtten_tk_du.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_tk_du.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_tk_du.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_tk_du.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_tk_du.Location = New System.Drawing.Point(280, 76)
        Me.Txtten_tk_du.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_tk_du.Name = "Txtten_tk_du"
        Me.Txtten_tk_du.ReadOnly = True
        Me.Txtten_tk_du.Size = New System.Drawing.Size(509, 16)
        Me.Txtten_tk_du.TabIndex = 150
        Me.Txtten_tk_du.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 17)
        Me.Label3.TabIndex = 149
        Me.Label3.Tag = "Corresponding acc"
        Me.Label3.Text = "Tài khoản đ/ư"
        '
        'GLGSSO4Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(795, 303)
        Me.Controls.Add(Me.Txttk_du)
        Me.Controls.Add(Me.Txtten_tk_du)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtM_Tk)
        Me.Controls.Add(Me.Txtten_Tk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtRec_gs)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "GLGSSO4Detail"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtRec_gs, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Tk, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Txtten_tk_du, 0)
        Me.Controls.SetChildIndex(Me.Txttk_du, 0)
        CType(Me.TxtRec_gs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtM_Tk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txttk_du.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtRec_gs As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtM_Tk As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txttk_du As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_tk_du As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
