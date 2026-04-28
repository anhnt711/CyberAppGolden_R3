<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class INSD1
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
        Me.TxtM_Ngay_Ct2 = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Cc = New System.Windows.Forms.Label()
        Me.TxtTen_Vt = New System.Windows.Forms.TextBox()
        Me.TxtMa_Vt = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(656, 179)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 8
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 128)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(653, 25)
        Me.CBBMa_Dvcs.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 132)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(517, 179)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 7
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 103)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 99)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 4
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(280, 99)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 5
        '
        'TxtM_Ngay_Ct2
        '
        Me.TxtM_Ngay_Ct2.Flags = 0
        Me.TxtM_Ngay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct2.IsAllowResize = False
        Me.TxtM_Ngay_Ct2.isEmpty = True
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(127, 65)
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
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(13, 69)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 157)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(785, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(13, 10)
        Me.LabMa_kho.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(109, 17)
        Me.LabMa_kho.TabIndex = 194
        Me.LabMa_kho.Tag = "Warehouse"
        Me.LabMa_kho.Text = "Mã kho"
        '
        'TxtTen_kho
        '
        Me.TxtTen_kho.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kho.Enabled = False
        Me.TxtTen_kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kho.Location = New System.Drawing.Point(288, 10)
        Me.TxtTen_kho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(493, 17)
        Me.TxtTen_kho.TabIndex = 193
        Me.TxtTen_kho.TabStop = False
        '
        'TxtMa_kho
        '
        Me.TxtMa_kho._ActilookupPopup = False
        Me.TxtMa_kho.CyberActilookupPopup = True
        Me.TxtMa_kho.Dv_ListDetail = Nothing
        Me.TxtMa_kho.Dv_Master = Nothing
        Me.TxtMa_kho.FilterClient = ""
        Me.TxtMa_kho.FilterSQL = ""
        Me.TxtMa_kho.Location = New System.Drawing.Point(127, 7)
        Me.TxtMa_kho.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_kho.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_kho.TabIndex = 0
        Me.TxtMa_kho.Table_Name = ""
        '
        'LabMa_Cc
        '
        Me.LabMa_Cc.Location = New System.Drawing.Point(13, 43)
        Me.LabMa_Cc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Cc.Name = "LabMa_Cc"
        Me.LabMa_Cc.Size = New System.Drawing.Size(109, 17)
        Me.LabMa_Cc.TabIndex = 197
        Me.LabMa_Cc.Tag = "Supplies"
        Me.LabMa_Cc.Text = "Mã vật tư"
        '
        'TxtTen_Vt
        '
        Me.TxtTen_Vt.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Vt.Enabled = False
        Me.TxtTen_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Vt.Location = New System.Drawing.Point(288, 39)
        Me.TxtTen_Vt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Vt.Name = "TxtTen_Vt"
        Me.TxtTen_Vt.ReadOnly = True
        Me.TxtTen_Vt.Size = New System.Drawing.Size(493, 17)
        Me.TxtTen_Vt.TabIndex = 196
        Me.TxtTen_Vt.TabStop = False
        '
        'TxtMa_Vt
        '
        Me.TxtMa_Vt._ActilookupPopup = False
        Me.TxtMa_Vt.CyberActilookupPopup = True
        Me.TxtMa_Vt.Dv_ListDetail = Nothing
        Me.TxtMa_Vt.Dv_Master = Nothing
        Me.TxtMa_Vt.FilterClient = ""
        Me.TxtMa_Vt.FilterSQL = ""
        Me.TxtMa_Vt.Location = New System.Drawing.Point(127, 35)
        Me.TxtMa_Vt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Vt.Name = "TxtMa_Vt"
        Me.TxtMa_Vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vt.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Vt.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vt.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_Vt.TabIndex = 1
        Me.TxtMa_Vt.Table_Name = ""
        '
        'INSD1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(795, 248)
        Me.Controls.Add(Me.LabMa_Cc)
        Me.Controls.Add(Me.TxtTen_Vt)
        Me.Controls.Add(Me.TxtMa_Vt)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "INSD1"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vt, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Cc, 0)
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Cc As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Vt As Cyber.SmLists.TxtLookup

End Class
