<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMSO1
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
        Me.LabMa_kho = New System.Windows.Forms.Label()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.LabMa_Cc = New System.Windows.Forms.Label()
        Me.TxtTen_Cc = New System.Windows.Forms.TextBox()
        Me.TxtMa_Cc = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Cc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 168)
        Me.ButtExit.TabIndex = 8
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 129)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 132)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 168)
        Me.ButtOK.TabIndex = 7
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 110)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 107)
        Me.ChkVND.TabIndex = 4
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 107)
        Me.ChkNT.TabIndex = 5
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(95, 50)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(116, 21)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(95, 73)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(116, 21)
        Me.TxtM_Ngay_Ct2.TabIndex = 3
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(10, 53)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(47, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Từ ngày"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(10, 76)
        Me.LabM_Ngay_Ct2.Name = "LabM_Ngay_Ct2"
        Me.LabM_Ngay_Ct2.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct2.TabIndex = 14
        Me.LabM_Ngay_Ct2.Tag = "Date to"
        Me.LabM_Ngay_Ct2.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 151)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_kho
        '
        Me.LabMa_kho.Location = New System.Drawing.Point(10, 8)
        Me.LabMa_kho.Name = "LabMa_kho"
        Me.LabMa_kho.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_kho.TabIndex = 194
        Me.LabMa_kho.Tag = "Ware house"
        Me.LabMa_kho.Text = "Mã kho"
        '
        'TxtTen_kho
        '
        Me.TxtTen_kho.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kho.Enabled = False
        Me.TxtTen_kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kho.Location = New System.Drawing.Point(216, 8)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(370, 14)
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
        Me.TxtMa_kho.Location = New System.Drawing.Point(95, 5)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_kho.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_kho.TabIndex = 0
        Me.TxtMa_kho.Table_Name = ""
        '
        'LabMa_Cc
        '
        Me.LabMa_Cc.Location = New System.Drawing.Point(10, 33)
        Me.LabMa_Cc.Name = "LabMa_Cc"
        Me.LabMa_Cc.Size = New System.Drawing.Size(82, 13)
        Me.LabMa_Cc.TabIndex = 197
        Me.LabMa_Cc.Tag = "Tool"
        Me.LabMa_Cc.Text = "Mã công cụ"
        '
        'TxtTen_Cc
        '
        Me.TxtTen_Cc.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Cc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Cc.Enabled = False
        Me.TxtTen_Cc.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Cc.Location = New System.Drawing.Point(216, 30)
        Me.TxtTen_Cc.Name = "TxtTen_Cc"
        Me.TxtTen_Cc.ReadOnly = True
        Me.TxtTen_Cc.Size = New System.Drawing.Size(370, 14)
        Me.TxtTen_Cc.TabIndex = 196
        Me.TxtTen_Cc.TabStop = False
        '
        'TxtMa_Cc
        '
        Me.TxtMa_Cc._ActilookupPopup = False
        Me.TxtMa_Cc.CyberActilookupPopup = True
        Me.TxtMa_Cc.Dv_ListDetail = Nothing
        Me.TxtMa_Cc.Dv_Master = Nothing
        Me.TxtMa_Cc.FilterClient = ""
        Me.TxtMa_Cc.FilterSQL = ""
        Me.TxtMa_Cc.Location = New System.Drawing.Point(95, 27)
        Me.TxtMa_Cc.Name = "TxtMa_Cc"
        Me.TxtMa_Cc.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cc.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cc.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.TxtMa_Cc.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.TxtMa_Cc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cc.Size = New System.Drawing.Size(116, 20)
        Me.TxtMa_Cc.TabIndex = 1
        Me.TxtMa_Cc.Table_Name = ""
        '
        'IMSO1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 221)
        Me.Controls.Add(Me.LabMa_Cc)
        Me.Controls.Add(Me.TxtTen_Cc)
        Me.Controls.Add(Me.TxtMa_Cc)
        Me.Controls.Add(Me.LabMa_kho)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "IMSO1"
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
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Cc, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Cc, 0)
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Cc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_kho As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_Cc As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Cc As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Cc As Cyber.SmLists.TxtLookup

End Class
