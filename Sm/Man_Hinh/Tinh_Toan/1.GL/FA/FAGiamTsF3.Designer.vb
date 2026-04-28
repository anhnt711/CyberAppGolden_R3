<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAGiamTsF3
    Inherits Cyber.From.FrmCalculator

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
        Me.TxtTen_ts = New System.Windows.Forms.TextBox()
        Me.Txtma_Ts = New System.Windows.Forms.TextBox()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.ChkGiam_Ts = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_NV = New System.Windows.Forms.TextBox()
        Me.TxtMa_NV = New System.Windows.Forms.TextBox()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtNgay_Giam = New ClsTextBox.txtDate1()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Giam = New System.Windows.Forms.TextBox()
        Me.TxtMa_Giam = New Cyber.SmLists.TxtLookup()
        Me.txtSo_ct = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLy_do = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Giam.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 225)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(899, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(632, 238)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtOK.TabIndex = 5
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(768, 238)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtExit.TabIndex = 6
        '
        'TxtTen_ts
        '
        Me.TxtTen_ts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTen_ts.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ts.Location = New System.Drawing.Point(289, 5)
        Me.TxtTen_ts.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_ts.Name = "TxtTen_ts"
        Me.TxtTen_ts.ReadOnly = True
        Me.TxtTen_ts.Size = New System.Drawing.Size(612, 24)
        Me.TxtTen_ts.TabIndex = 352
        '
        'Txtma_Ts
        '
        Me.Txtma_Ts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Txtma_Ts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Txtma_Ts.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_Ts.Location = New System.Drawing.Point(111, 5)
        Me.Txtma_Ts.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtma_Ts.Name = "Txtma_Ts"
        Me.Txtma_Ts.ReadOnly = True
        Me.Txtma_Ts.Size = New System.Drawing.Size(172, 24)
        Me.Txtma_Ts.TabIndex = 0
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbMa_Phi.Location = New System.Drawing.Point(-1, 10)
        Me.lbMa_Phi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(99, 25)
        Me.lbMa_Phi.TabIndex = 353
        Me.lbMa_Phi.Tag = "Asset"
        Me.lbMa_Phi.Text = "Mã tài sản"
        '
        'ChkGiam_Ts
        '
        Me.ChkGiam_Ts.AutoSize = True
        Me.ChkGiam_Ts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ChkGiam_Ts.Location = New System.Drawing.Point(111, 71)
        Me.ChkGiam_Ts.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkGiam_Ts.Name = "ChkGiam_Ts"
        Me.ChkGiam_Ts.Size = New System.Drawing.Size(171, 22)
        Me.ChkGiam_Ts.TabIndex = 0
        Me.ChkGiam_Ts.Tag = "Asset decrease declaration"
        Me.ChkGiam_Ts.Text = "Khai báo giảm tài sản"
        Me.ChkGiam_Ts.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(-1, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 25)
        Me.Label1.TabIndex = 357
        Me.Label1.Tag = "Capital"
        Me.Label1.Text = "Nguồn vốn"
        '
        'TxtTen_NV
        '
        Me.TxtTen_NV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtTen_NV.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NV.Location = New System.Drawing.Point(289, 36)
        Me.TxtTen_NV.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_NV.Name = "TxtTen_NV"
        Me.TxtTen_NV.ReadOnly = True
        Me.TxtTen_NV.Size = New System.Drawing.Size(612, 24)
        Me.TxtTen_NV.TabIndex = 359
        '
        'TxtMa_NV
        '
        Me.TxtMa_NV.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_NV.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtMa_NV.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NV.Location = New System.Drawing.Point(111, 36)
        Me.TxtMa_NV.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_NV.Name = "TxtMa_NV"
        Me.TxtMa_NV.ReadOnly = True
        Me.TxtMa_NV.Size = New System.Drawing.Size(172, 24)
        Me.TxtMa_NV.TabIndex = 1
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(-1, 110)
        Me.LabM_Ngay_Ct1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(75, 17)
        Me.LabM_Ngay_Ct1.TabIndex = 361
        Me.LabM_Ngay_Ct1.Tag = "Decrease date"
        Me.LabM_Ngay_Ct1.Text = "Ngày giảm"
        '
        'TxtNgay_Giam
        '
        Me.TxtNgay_Giam.Flags = 0
        Me.TxtNgay_Giam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Giam.IsAllowResize = False
        Me.TxtNgay_Giam.isEmpty = True
        Me.TxtNgay_Giam.Location = New System.Drawing.Point(111, 106)
        Me.TxtNgay_Giam.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Giam.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Giam.MaxLength = 10
        Me.TxtNgay_Giam.Name = "TxtNgay_Giam"
        Me.TxtNgay_Giam.RangeMax = New Date(CType(0, Long))
        Me.TxtNgay_Giam.RangeMin = New Date(CType(0, Long))
        Me.TxtNgay_Giam.ShowDayBeforeMonth = False
        Me.TxtNgay_Giam.Size = New System.Drawing.Size(172, 22)
        Me.TxtNgay_Giam.TabIndex = 1
        Me.TxtNgay_Giam.Text = "__/__/____"
        Me.TxtNgay_Giam.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-1, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 505
        Me.Label4.Tag = "Decrease ID"
        Me.Label4.Text = "Mã giảm"
        '
        'TxtTen_Giam
        '
        Me.TxtTen_Giam.BackColor = System.Drawing.SystemColors.Control
        Me.TxtTen_Giam.Enabled = False
        Me.TxtTen_Giam.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Giam.Location = New System.Drawing.Point(289, 133)
        Me.TxtTen_Giam.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Giam.Name = "TxtTen_Giam"
        Me.TxtTen_Giam.ReadOnly = True
        Me.TxtTen_Giam.Size = New System.Drawing.Size(612, 22)
        Me.TxtTen_Giam.TabIndex = 504
        Me.TxtTen_Giam.TabStop = False
        '
        'TxtMa_Giam
        '
        Me.TxtMa_Giam._ActilookupPopup = False
        Me.TxtMa_Giam.CyberActilookupPopup = True
        Me.TxtMa_Giam.Dv_ListDetail = Nothing
        Me.TxtMa_Giam.Dv_Master = Nothing
        Me.TxtMa_Giam.FilterClient = ""
        Me.TxtMa_Giam.FilterSQL = ""
        Me.TxtMa_Giam.Location = New System.Drawing.Point(111, 134)
        Me.TxtMa_Giam.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Giam.Name = "TxtMa_Giam"
        Me.TxtMa_Giam.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Giam.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Giam.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Giam.Size = New System.Drawing.Size(173, 22)
        Me.TxtMa_Giam.TabIndex = 2
        Me.TxtMa_Giam.Table_Name = ""
        '
        'txtSo_ct
        '
        Me.txtSo_ct.BackColor = System.Drawing.Color.White
        Me.txtSo_ct.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_ct.Location = New System.Drawing.Point(111, 160)
        Me.txtSo_ct.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSo_ct.Name = "txtSo_ct"
        Me.txtSo_ct.Size = New System.Drawing.Size(172, 24)
        Me.txtSo_ct.TabIndex = 3
        Me.txtSo_ct.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(-1, 164)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 18)
        Me.Label5.TabIndex = 509
        Me.Label5.Tag = "Voucher"
        Me.Label5.Text = "Chứng từ giảm"
        '
        'txtLy_do
        '
        Me.txtLy_do.BackColor = System.Drawing.Color.White
        Me.txtLy_do.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtLy_do.ForeColor = System.Drawing.Color.Navy
        Me.txtLy_do.Location = New System.Drawing.Point(111, 188)
        Me.txtLy_do.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLy_do.Name = "txtLy_do"
        Me.txtLy_do.Size = New System.Drawing.Size(792, 24)
        Me.txtLy_do.TabIndex = 4
        Me.txtLy_do.Tag = ""
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(-1, 191)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 25)
        Me.Label2.TabIndex = 508
        Me.Label2.Tag = "Reasons "
        Me.Label2.Text = "Lý do giảm"
        '
        'FAGiamTsF3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(904, 304)
        Me.Controls.Add(Me.txtSo_ct)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtLy_do)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTen_Giam)
        Me.Controls.Add(Me.TxtMa_Giam)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtNgay_Giam)
        Me.Controls.Add(Me.TxtTen_NV)
        Me.Controls.Add(Me.TxtMa_NV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ChkGiam_Ts)
        Me.Controls.Add(Me.TxtTen_ts)
        Me.Controls.Add(Me.Txtma_Ts)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FAGiamTsF3"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.Txtma_Ts, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ts, 0)
        Me.Controls.SetChildIndex(Me.ChkGiam_Ts, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NV, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NV, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Giam, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Giam, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Giam, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtLy_do, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtSo_ct, 0)
        CType(Me.TxtMa_Giam.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTen_ts As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_Ts As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents ChkGiam_Ts As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_NV As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_NV As System.Windows.Forms.TextBox
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Giam As ClsTextBox.txtDate1
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Giam As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Giam As Cyber.SmLists.TxtLookup
    Friend WithEvents txtSo_ct As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLy_do As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
