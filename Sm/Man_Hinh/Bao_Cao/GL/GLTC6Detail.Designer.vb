<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLTC6Detail
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
        Me.TxtMa_so = New Cyber.SmLists.TxtLookup()
        Me.TxtFile_MaubC = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Txtchi_tieu = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_so.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtFile_MaubC.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(656, 220)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 9
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 169)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(653, 25)
        Me.CBBMa_Dvcs.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 173)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(517, 220)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 8
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(12, 140)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 140)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 5
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(281, 141)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 197)
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
        Me.LabM_Tk.Size = New System.Drawing.Size(43, 17)
        Me.LabM_Tk.TabIndex = 17
        Me.LabM_Tk.Tag = "Code"
        Me.LabM_Tk.Text = "Mã số"
        '
        'TxtMa_so
        '
        Me.TxtMa_so._ActilookupPopup = False
        Me.TxtMa_so.CyberActilookupPopup = True
        Me.TxtMa_so.Dv_ListDetail = Nothing
        Me.TxtMa_so.Dv_Master = Nothing
        Me.TxtMa_so.FilterClient = ""
        Me.TxtMa_so.FilterSQL = ""
        Me.TxtMa_so.Location = New System.Drawing.Point(127, 7)
        Me.TxtMa_so.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_so.Name = "TxtMa_so"
        Me.TxtMa_so.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtMa_so.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_so.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_so.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_so.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_so.Size = New System.Drawing.Size(152, 24)
        Me.TxtMa_so.TabIndex = 0
        Me.TxtMa_so.Table_Name = ""
        '
        'TxtFile_MaubC
        '
        Me.TxtFile_MaubC._ActilookupPopup = False
        Me.TxtFile_MaubC.CyberActilookupPopup = True
        Me.TxtFile_MaubC.Dv_ListDetail = Nothing
        Me.TxtFile_MaubC.Dv_Master = Nothing
        Me.TxtFile_MaubC.FilterClient = ""
        Me.TxtFile_MaubC.FilterSQL = ""
        Me.TxtFile_MaubC.Location = New System.Drawing.Point(127, 37)
        Me.TxtFile_MaubC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtFile_MaubC.Name = "TxtFile_MaubC"
        Me.TxtFile_MaubC.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtFile_MaubC.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtFile_MaubC.Properties.Appearance.Options.UseFont = True
        Me.TxtFile_MaubC.Properties.Appearance.Options.UseForeColor = True
        Me.TxtFile_MaubC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtFile_MaubC.Size = New System.Drawing.Size(152, 24)
        Me.TxtFile_MaubC.TabIndex = 1
        Me.TxtFile_MaubC.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 17)
        Me.Label2.TabIndex = 147
        Me.Label2.Tag = "Report form"
        Me.Label2.Text = "Mẫu báo cáo"
        '
        'Txtchi_tieu
        '
        Me.Txtchi_tieu.BackColor = System.Drawing.SystemColors.Control
        Me.Txtchi_tieu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtchi_tieu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtchi_tieu.ForeColor = System.Drawing.Color.Navy
        Me.Txtchi_tieu.Location = New System.Drawing.Point(287, 16)
        Me.Txtchi_tieu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtchi_tieu.Name = "Txtchi_tieu"
        Me.Txtchi_tieu.ReadOnly = True
        Me.Txtchi_tieu.Size = New System.Drawing.Size(509, 16)
        Me.Txtchi_tieu.TabIndex = 148
        Me.Txtchi_tieu.TabStop = False
        '
        'GLTC6Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(795, 289)
        Me.Controls.Add(Me.Txtchi_tieu)
        Me.Controls.Add(Me.TxtFile_MaubC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMa_so)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "GLTC6Detail"
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
        Me.Controls.SetChildIndex(Me.TxtMa_so, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtFile_MaubC, 0)
        Me.Controls.SetChildIndex(Me.Txtchi_tieu, 0)
        CType(Me.TxtMa_so.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtFile_MaubC.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label
    Friend WithEvents TxtMa_so As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtFile_MaubC As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Txtchi_tieu As System.Windows.Forms.TextBox

End Class
