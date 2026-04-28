<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLTC5Detail
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
        Me.TxtTk_No = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Tk_No = New System.Windows.Forms.TextBox()
        Me.TxtTk_Co = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Tk_Co = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkM_GROUP = New System.Windows.Forms.CheckBox()
        Me.ChkM_goup1 = New System.Windows.Forms.CheckBox()
        CType(Me.TxtTk_No.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk_Co.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(656, 267)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 9
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 216)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(653, 25)
        Me.CBBMa_Dvcs.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 220)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(517, 267)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 8
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(12, 187)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 187)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 5
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(281, 188)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 6
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(127, 65)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(127, 98)
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
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(12, 69)
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
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(12, 102)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 245)
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
        Me.LabM_Tk.Size = New System.Drawing.Size(87, 17)
        Me.LabM_Tk.TabIndex = 17
        Me.LabM_Tk.Tag = "Acc debit"
        Me.LabM_Tk.Text = "Tài khoản nợ"
        '
        'TxtTk_No
        '
        Me.TxtTk_No._ActilookupPopup = False
        Me.TxtTk_No.CyberActilookupPopup = True
        Me.TxtTk_No.Dv_ListDetail = Nothing
        Me.TxtTk_No.Dv_Master = Nothing
        Me.TxtTk_No.FilterClient = ""
        Me.TxtTk_No.FilterSQL = ""
        Me.TxtTk_No.Location = New System.Drawing.Point(127, 7)
        Me.TxtTk_No.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTk_No.Name = "TxtTk_No"
        Me.TxtTk_No.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTk_No.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_No.Properties.Appearance.Options.UseFont = True
        Me.TxtTk_No.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk_No.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk_No.Size = New System.Drawing.Size(152, 24)
        Me.TxtTk_No.TabIndex = 0
        Me.TxtTk_No.Table_Name = ""
        '
        'Txtten_Tk_No
        '
        Me.Txtten_Tk_No.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Tk_No.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Tk_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Tk_No.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk_No.Location = New System.Drawing.Point(280, 16)
        Me.Txtten_Tk_No.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_Tk_No.Name = "Txtten_Tk_No"
        Me.Txtten_Tk_No.ReadOnly = True
        Me.Txtten_Tk_No.Size = New System.Drawing.Size(509, 16)
        Me.Txtten_Tk_No.TabIndex = 144
        Me.Txtten_Tk_No.TabStop = False
        '
        'TxtTk_Co
        '
        Me.TxtTk_Co._ActilookupPopup = False
        Me.TxtTk_Co.CyberActilookupPopup = True
        Me.TxtTk_Co.Dv_ListDetail = Nothing
        Me.TxtTk_Co.Dv_Master = Nothing
        Me.TxtTk_Co.FilterClient = ""
        Me.TxtTk_Co.FilterSQL = ""
        Me.TxtTk_Co.Location = New System.Drawing.Point(127, 37)
        Me.TxtTk_Co.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTk_Co.Name = "TxtTk_Co"
        Me.TxtTk_Co.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTk_Co.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_Co.Properties.Appearance.Options.UseFont = True
        Me.TxtTk_Co.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk_Co.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk_Co.Size = New System.Drawing.Size(152, 24)
        Me.TxtTk_Co.TabIndex = 1
        Me.TxtTk_Co.Table_Name = ""
        '
        'TxtTen_Tk_Co
        '
        Me.TxtTen_Tk_Co.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Tk_Co.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Tk_Co.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_Tk_Co.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk_Co.Location = New System.Drawing.Point(280, 46)
        Me.TxtTen_Tk_Co.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Tk_Co.Name = "TxtTen_Tk_Co"
        Me.TxtTen_Tk_Co.ReadOnly = True
        Me.TxtTen_Tk_Co.Size = New System.Drawing.Size(509, 16)
        Me.TxtTen_Tk_Co.TabIndex = 148
        Me.TxtTen_Tk_Co.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 147
        Me.Label2.Tag = "Acc credit"
        Me.Label2.Text = "Tài khoản có"
        '
        'ChkM_GROUP
        '
        Me.ChkM_GROUP.AutoSize = True
        Me.ChkM_GROUP.Location = New System.Drawing.Point(127, 129)
        Me.ChkM_GROUP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkM_GROUP.Name = "ChkM_GROUP"
        Me.ChkM_GROUP.Size = New System.Drawing.Size(144, 21)
        Me.ChkM_GROUP.TabIndex = 149
        Me.ChkM_GROUP.Tag = "Debt account value"
        Me.ChkM_GROUP.Text = "Giá trị tài khoản nợ"
        Me.ChkM_GROUP.UseVisualStyleBackColor = True
        '
        'ChkM_goup1
        '
        Me.ChkM_goup1.AutoSize = True
        Me.ChkM_goup1.Location = New System.Drawing.Point(127, 160)
        Me.ChkM_goup1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkM_goup1.Name = "ChkM_goup1"
        Me.ChkM_goup1.Size = New System.Drawing.Size(143, 21)
        Me.ChkM_goup1.TabIndex = 150
        Me.ChkM_goup1.Tag = "Credit account value"
        Me.ChkM_goup1.Text = "Giá trị tài khoản có"
        Me.ChkM_goup1.UseVisualStyleBackColor = True
        '
        'GLTC5Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(795, 336)
        Me.Controls.Add(Me.ChkM_goup1)
        Me.Controls.Add(Me.ChkM_GROUP)
        Me.Controls.Add(Me.TxtTk_Co)
        Me.Controls.Add(Me.TxtTen_Tk_Co)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTk_No)
        Me.Controls.Add(Me.Txtten_Tk_No)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "GLTC5Detail"
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
        Me.Controls.SetChildIndex(Me.Txtten_Tk_No, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_No, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk_Co, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_Co, 0)
        Me.Controls.SetChildIndex(Me.ChkM_GROUP, 0)
        Me.Controls.SetChildIndex(Me.ChkM_goup1, 0)
        CType(Me.TxtTk_No.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk_Co.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtTk_No As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk_No As System.Windows.Forms.TextBox
    Friend WithEvents TxtTk_Co As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Tk_Co As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChkM_GROUP As System.Windows.Forms.CheckBox
    Friend WithEvents ChkM_goup1 As System.Windows.Forms.CheckBox

End Class
