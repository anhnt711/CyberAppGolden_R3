<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLPB6BK1
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
        Me.TxtTK_No_H = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_TK_No_H = New System.Windows.Forms.TextBox()
        Me.TxtTK_Co_H = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_TK_Co_H = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TxtTK_No_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTK_Co_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(656, 218)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 14
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(123, 169)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(665, 25)
        Me.CBBMa_Dvcs.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 174)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Size = New System.Drawing.Size(95, 17)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(517, 218)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 13
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(24, 144)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLoai_NT.Size = New System.Drawing.Size(95, 17)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(124, 141)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 10
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(279, 141)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 11
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(124, 10)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(124, 43)
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
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(24, 16)
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
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(24, 48)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 199)
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
        Me.LabM_Tk.Location = New System.Drawing.Point(24, 81)
        Me.LabM_Tk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(45, 17)
        Me.LabM_Tk.TabIndex = 17
        Me.LabM_Tk.Tag = "Acc debit"
        Me.LabM_Tk.Text = "TK Nợ"
        '
        'TxtTK_No_H
        '
        Me.TxtTK_No_H._ActilookupPopup = False
        Me.TxtTK_No_H.CyberActilookupPopup = True
        Me.TxtTK_No_H.Dv_ListDetail = Nothing
        Me.TxtTK_No_H.Dv_Master = Nothing
        Me.TxtTK_No_H.FilterClient = ""
        Me.TxtTK_No_H.FilterSQL = ""
        Me.TxtTK_No_H.Location = New System.Drawing.Point(124, 76)
        Me.TxtTK_No_H.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTK_No_H.Name = "TxtTK_No_H"
        Me.TxtTK_No_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTK_No_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTK_No_H.Properties.Appearance.Options.UseFont = True
        Me.TxtTK_No_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTK_No_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTK_No_H.Size = New System.Drawing.Size(152, 24)
        Me.TxtTK_No_H.TabIndex = 2
        Me.TxtTK_No_H.Table_Name = ""
        '
        'TxtTen_TK_No_H
        '
        Me.TxtTen_TK_No_H.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TK_No_H.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TK_No_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_TK_No_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK_No_H.Location = New System.Drawing.Point(292, 81)
        Me.TxtTen_TK_No_H.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TK_No_H.Name = "TxtTen_TK_No_H"
        Me.TxtTen_TK_No_H.ReadOnly = True
        Me.TxtTen_TK_No_H.Size = New System.Drawing.Size(487, 16)
        Me.TxtTen_TK_No_H.TabIndex = 144
        Me.TxtTen_TK_No_H.TabStop = False
        '
        'TxtTK_Co_H
        '
        Me.TxtTK_Co_H._ActilookupPopup = False
        Me.TxtTK_Co_H.CyberActilookupPopup = True
        Me.TxtTK_Co_H.Dv_ListDetail = Nothing
        Me.TxtTK_Co_H.Dv_Master = Nothing
        Me.TxtTK_Co_H.FilterClient = ""
        Me.TxtTK_Co_H.FilterSQL = ""
        Me.TxtTK_Co_H.Location = New System.Drawing.Point(124, 107)
        Me.TxtTK_Co_H.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTK_Co_H.Name = "TxtTK_Co_H"
        Me.TxtTK_Co_H.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTK_Co_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTK_Co_H.Properties.Appearance.Options.UseFont = True
        Me.TxtTK_Co_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTK_Co_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTK_Co_H.Size = New System.Drawing.Size(152, 24)
        Me.TxtTK_Co_H.TabIndex = 3
        Me.TxtTK_Co_H.Table_Name = ""
        '
        'TxtTen_TK_Co_H
        '
        Me.TxtTen_TK_Co_H.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_TK_Co_H.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TK_Co_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtTen_TK_Co_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TK_Co_H.Location = New System.Drawing.Point(292, 112)
        Me.TxtTen_TK_Co_H.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TK_Co_H.Name = "TxtTen_TK_Co_H"
        Me.TxtTen_TK_Co_H.ReadOnly = True
        Me.TxtTen_TK_Co_H.Size = New System.Drawing.Size(487, 16)
        Me.TxtTen_TK_Co_H.TabIndex = 148
        Me.TxtTen_TK_Co_H.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 147
        Me.Label2.Tag = "Acc credit"
        Me.Label2.Text = "TK Có"
        '
        'GLPB6BK1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(795, 296)
        Me.Controls.Add(Me.TxtTK_Co_H)
        Me.Controls.Add(Me.TxtTen_TK_Co_H)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTK_No_H)
        Me.Controls.Add(Me.TxtTen_TK_No_H)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "GLPB6BK1"
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
        Me.Controls.SetChildIndex(Me.TxtTen_TK_No_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTK_No_H, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TK_Co_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTK_Co_H, 0)
        CType(Me.TxtTK_No_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTK_Co_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtTK_No_H As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_TK_No_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtTK_Co_H As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_TK_Co_H As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
