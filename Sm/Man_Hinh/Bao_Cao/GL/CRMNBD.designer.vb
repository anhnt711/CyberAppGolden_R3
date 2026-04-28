<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRMNBD
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
        Me.LabMa_Hs = New System.Windows.Forms.Label()
        Me.TxtTen_Hs_H = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs_H = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMa_xe = New System.Windows.Forms.TextBox()
        Me.txtTen_kx = New System.Windows.Forms.TextBox()
        Me.txtma_KX = New Cyber.SmLists.TxtLookup()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTen_mau = New System.Windows.Forms.TextBox()
        Me.txtMa_Mau = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Hs_H.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtma_KX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(655, 264)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 14
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(133, 222)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(455, 25)
        Me.CBBMa_Dvcs.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 226)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(516, 264)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 13
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(8, 197)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(133, 195)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 10
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(285, 195)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 11
        '
        'TxtM_Ngay_Ct1
        '
        Me.TxtM_Ngay_Ct1.Flags = 0
        Me.TxtM_Ngay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct1.IsAllowResize = False
        Me.TxtM_Ngay_Ct1.isEmpty = True
        Me.TxtM_Ngay_Ct1.Location = New System.Drawing.Point(133, 8)
        Me.TxtM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct1.MaxLength = 10
        Me.TxtM_Ngay_Ct1.Name = "TxtM_Ngay_Ct1"
        Me.TxtM_Ngay_Ct1.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct1.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct1.Size = New System.Drawing.Size(153, 24)
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
        Me.TxtM_Ngay_Ct2.Location = New System.Drawing.Point(133, 39)
        Me.TxtM_Ngay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct2.MaxLength = 10
        Me.TxtM_Ngay_Ct2.Name = "TxtM_Ngay_Ct2"
        Me.TxtM_Ngay_Ct2.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct2.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct2.Size = New System.Drawing.Size(153, 24)
        Me.TxtM_Ngay_Ct2.TabIndex = 1
        Me.TxtM_Ngay_Ct2.Text = "__/__/____"
        Me.TxtM_Ngay_Ct2.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(8, 13)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(114, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Ngày nghiệm thu"
        '
        'LabM_Ngay_Ct2
        '
        Me.LabM_Ngay_Ct2.AutoSize = True
        Me.LabM_Ngay_Ct2.Location = New System.Drawing.Point(8, 44)
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
        Me.GroupBoxLine.Location = New System.Drawing.Point(7, 248)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(784, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'LabMa_Hs
        '
        Me.LabMa_Hs.AutoSize = True
        Me.LabMa_Hs.Location = New System.Drawing.Point(8, 139)
        Me.LabMa_Hs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Hs.Name = "LabMa_Hs"
        Me.LabMa_Hs.Size = New System.Drawing.Size(52, 17)
        Me.LabMa_Hs.TabIndex = 408
        Me.LabMa_Hs.Tag = "Car Type"
        Me.LabMa_Hs.Text = "Kiểu xe"
        '
        'TxtTen_Hs_H
        '
        Me.TxtTen_Hs_H.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Hs_H.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs_H.Enabled = False
        Me.TxtTen_Hs_H.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs_H.Location = New System.Drawing.Point(299, 106)
        Me.TxtTen_Hs_H.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Hs_H.Name = "TxtTen_Hs_H"
        Me.TxtTen_Hs_H.ReadOnly = True
        Me.TxtTen_Hs_H.Size = New System.Drawing.Size(489, 17)
        Me.TxtTen_Hs_H.TabIndex = 407
        Me.TxtTen_Hs_H.TabStop = False
        '
        'TxtMa_Hs_H
        '
        Me.TxtMa_Hs_H._ActilookupPopup = False
        Me.TxtMa_Hs_H.CyberActilookupPopup = True
        Me.TxtMa_Hs_H.Dv_ListDetail = Nothing
        Me.TxtMa_Hs_H.Dv_Master = Nothing
        Me.TxtMa_Hs_H.FilterClient = ""
        Me.TxtMa_Hs_H.FilterSQL = ""
        Me.TxtMa_Hs_H.Location = New System.Drawing.Point(133, 102)
        Me.TxtMa_Hs_H.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Hs_H.Name = "TxtMa_Hs_H"
        Me.TxtMa_Hs_H.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs_H.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs_H.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs_H.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_Hs_H.TabIndex = 4
        Me.TxtMa_Hs_H.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 76)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 17)
        Me.Label4.TabIndex = 436
        Me.Label4.Tag = "License Plates"
        Me.Label4.Text = "Biển số"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 107)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 438
        Me.Label2.Tag = "Staff"
        Me.Label2.Text = "CVDV"
        '
        'TxtMa_xe
        '
        Me.TxtMa_xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_xe.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_xe.Location = New System.Drawing.Point(133, 71)
        Me.TxtMa_xe.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_xe.Name = "TxtMa_xe"
        Me.TxtMa_xe.Size = New System.Drawing.Size(153, 24)
        Me.TxtMa_xe.TabIndex = 2
        Me.TxtMa_xe.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTen_kx
        '
        Me.txtTen_kx.BackColor = System.Drawing.SystemColors.Control
        Me.txtTen_kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_kx.Enabled = False
        Me.txtTen_kx.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_kx.Location = New System.Drawing.Point(299, 137)
        Me.txtTen_kx.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTen_kx.Name = "txtTen_kx"
        Me.txtTen_kx.ReadOnly = True
        Me.txtTen_kx.Size = New System.Drawing.Size(489, 17)
        Me.txtTen_kx.TabIndex = 440
        Me.txtTen_kx.TabStop = False
        '
        'txtma_KX
        '
        Me.txtma_KX._ActilookupPopup = False
        Me.txtma_KX.CyberActilookupPopup = True
        Me.txtma_KX.Dv_ListDetail = Nothing
        Me.txtma_KX.Dv_Master = Nothing
        Me.txtma_KX.FilterClient = ""
        Me.txtma_KX.FilterSQL = ""
        Me.txtma_KX.Location = New System.Drawing.Point(133, 132)
        Me.txtma_KX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtma_KX.Name = "txtma_KX"
        Me.txtma_KX.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtma_KX.Properties.Appearance.Options.UseForeColor = True
        Me.txtma_KX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtma_KX.Size = New System.Drawing.Size(155, 22)
        Me.txtma_KX.TabIndex = 3
        Me.txtma_KX.Table_Name = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 169)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 443
        Me.Label3.Tag = "Color"
        Me.Label3.Text = "Màu xe"
        '
        'txtTen_mau
        '
        Me.txtTen_mau.BackColor = System.Drawing.SystemColors.Control
        Me.txtTen_mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_mau.Enabled = False
        Me.txtTen_mau.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_mau.Location = New System.Drawing.Point(296, 167)
        Me.txtTen_mau.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtTen_mau.Name = "txtTen_mau"
        Me.txtTen_mau.ReadOnly = True
        Me.txtTen_mau.Size = New System.Drawing.Size(489, 17)
        Me.txtTen_mau.TabIndex = 442
        Me.txtTen_mau.TabStop = False
        '
        'txtMa_Mau
        '
        Me.txtMa_Mau._ActilookupPopup = False
        Me.txtMa_Mau.CyberActilookupPopup = True
        Me.txtMa_Mau.Dv_ListDetail = Nothing
        Me.txtMa_Mau.Dv_Master = Nothing
        Me.txtMa_Mau.FilterClient = ""
        Me.txtMa_Mau.FilterSQL = ""
        Me.txtMa_Mau.Location = New System.Drawing.Point(133, 163)
        Me.txtMa_Mau.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMa_Mau.Name = "txtMa_Mau"
        Me.txtMa_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.txtMa_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.txtMa_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.txtMa_Mau.Size = New System.Drawing.Size(155, 22)
        Me.txtMa_Mau.TabIndex = 5
        Me.txtMa_Mau.Table_Name = ""
        '
        'CRMNBD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(793, 333)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTen_mau)
        Me.Controls.Add(Me.txtMa_Mau)
        Me.Controls.Add(Me.txtTen_kx)
        Me.Controls.Add(Me.txtma_KX)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtMa_xe)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LabMa_Hs)
        Me.Controls.Add(Me.TxtTen_Hs_H)
        Me.Controls.Add(Me.TxtMa_Hs_H)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct2)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct2)
        Me.Controls.Add(Me.TxtM_Ngay_Ct1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "CRMNBD"
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs_H, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_xe, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.txtma_KX, 0)
        Me.Controls.SetChildIndex(Me.txtTen_kx, 0)
        Me.Controls.SetChildIndex(Me.txtMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.txtTen_mau, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        CType(Me.TxtMa_Hs_H.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtma_KX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtM_Ngay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents LabM_Ngay_Ct2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents LabMa_Hs As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs_H As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs_H As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_xe As System.Windows.Forms.TextBox
    Friend WithEvents txtTen_kx As System.Windows.Forms.TextBox
    Friend WithEvents txtma_KX As Cyber.SmLists.TxtLookup
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTen_mau As System.Windows.Forms.TextBox
    Friend WithEvents txtMa_Mau As Cyber.SmLists.TxtLookup

End Class
