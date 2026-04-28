<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMTKNH
    Inherits Cyber.From.FrmList

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
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        Me.TxtE_mail = New System.Windows.Forms.TextBox()
        Me.Labemail = New System.Windows.Forms.Label()
        Me.TxtFax = New System.Windows.Forms.TextBox()
        Me.LabFax = New System.Windows.Forms.Label()
        Me.TxtDien_thoai = New System.Windows.Forms.TextBox()
        Me.LabDien_thoai = New System.Windows.Forms.Label()
        Me.TxtTinh_thanh = New System.Windows.Forms.TextBox()
        Me.Labtinh_thanh = New System.Windows.Forms.Label()
        Me.TxtMa_so_thue = New System.Windows.Forms.TextBox()
        Me.Labma_so_thue = New System.Windows.Forms.Label()
        Me.TxtTen_Tk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabTk0 = New System.Windows.Forms.Label()
        Me.TxtTen_nh2 = New System.Windows.Forms.TextBox()
        Me.Labten_nh2 = New System.Windows.Forms.Label()
        Me.TxtTen_nh = New System.Windows.Forms.TextBox()
        Me.LabTen_nh = New System.Windows.Forms.Label()
        Me.TxtTk_nh = New System.Windows.Forms.TextBox()
        Me.Labtk_nh = New System.Windows.Forms.Label()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(909, 250)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 11
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(773, 250)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 10
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(632, 258)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.TabIndex = 12
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(147, 263)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkActi.TabIndex = 9
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 237)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.TabIndex = 13
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(145, 10)
        Me.TxtTk.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseFont = True
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.AutoHeight = False
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(199, 22)
        Me.TxtTk.TabIndex = 0
        Me.TxtTk.Table_Name = ""
        '
        'TxtE_mail
        '
        Me.TxtE_mail.ForeColor = System.Drawing.Color.Navy
        Me.TxtE_mail.Location = New System.Drawing.Point(145, 211)
        Me.TxtE_mail.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtE_mail.Name = "TxtE_mail"
        Me.TxtE_mail.Size = New System.Drawing.Size(895, 24)
        Me.TxtE_mail.TabIndex = 8
        '
        'Labemail
        '
        Me.Labemail.Location = New System.Drawing.Point(8, 216)
        Me.Labemail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labemail.Name = "Labemail"
        Me.Labemail.Size = New System.Drawing.Size(108, 22)
        Me.Labemail.TabIndex = 94
        Me.Labemail.Tag = "Email"
        Me.Labemail.Text = "Email"
        '
        'TxtFax
        '
        Me.TxtFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtFax.ForeColor = System.Drawing.Color.Navy
        Me.TxtFax.Location = New System.Drawing.Point(641, 180)
        Me.TxtFax.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFax.Name = "TxtFax"
        Me.TxtFax.Size = New System.Drawing.Size(399, 24)
        Me.TxtFax.TabIndex = 7
        '
        'LabFax
        '
        Me.LabFax.Location = New System.Drawing.Point(541, 186)
        Me.LabFax.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabFax.Name = "LabFax"
        Me.LabFax.Size = New System.Drawing.Size(99, 20)
        Me.LabFax.TabIndex = 93
        Me.LabFax.Tag = "Fax"
        Me.LabFax.Text = "Fax"
        '
        'TxtDien_thoai
        '
        Me.TxtDien_thoai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtDien_thoai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_thoai.Location = New System.Drawing.Point(145, 180)
        Me.TxtDien_thoai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDien_thoai.Name = "TxtDien_thoai"
        Me.TxtDien_thoai.Size = New System.Drawing.Size(197, 24)
        Me.TxtDien_thoai.TabIndex = 5
        '
        'LabDien_thoai
        '
        Me.LabDien_thoai.Location = New System.Drawing.Point(8, 186)
        Me.LabDien_thoai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabDien_thoai.Name = "LabDien_thoai"
        Me.LabDien_thoai.Size = New System.Drawing.Size(133, 22)
        Me.LabDien_thoai.TabIndex = 92
        Me.LabDien_thoai.Tag = "Tel"
        Me.LabDien_thoai.Text = "Điện thoại"
        '
        'TxtTinh_thanh
        '
        Me.TxtTinh_thanh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTinh_thanh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTinh_thanh.Location = New System.Drawing.Point(641, 152)
        Me.TxtTinh_thanh.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTinh_thanh.Name = "TxtTinh_thanh"
        Me.TxtTinh_thanh.Size = New System.Drawing.Size(399, 24)
        Me.TxtTinh_thanh.TabIndex = 6
        '
        'Labtinh_thanh
        '
        Me.Labtinh_thanh.Location = New System.Drawing.Point(539, 157)
        Me.Labtinh_thanh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labtinh_thanh.Name = "Labtinh_thanh"
        Me.Labtinh_thanh.Size = New System.Drawing.Size(99, 20)
        Me.Labtinh_thanh.TabIndex = 91
        Me.Labtinh_thanh.Tag = "Address"
        Me.Labtinh_thanh.Text = "Tỉnh thành"
        '
        'TxtMa_so_thue
        '
        Me.TxtMa_so_thue.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_so_thue.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_so_thue.Location = New System.Drawing.Point(145, 152)
        Me.TxtMa_so_thue.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_so_thue.Name = "TxtMa_so_thue"
        Me.TxtMa_so_thue.Size = New System.Drawing.Size(197, 24)
        Me.TxtMa_so_thue.TabIndex = 4
        '
        'Labma_so_thue
        '
        Me.Labma_so_thue.Location = New System.Drawing.Point(8, 157)
        Me.Labma_so_thue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labma_so_thue.Name = "Labma_so_thue"
        Me.Labma_so_thue.Size = New System.Drawing.Size(129, 22)
        Me.Labma_so_thue.TabIndex = 90
        Me.Labma_so_thue.Tag = "Tax code"
        Me.Labma_so_thue.Text = "Mã số thuế"
        '
        'TxtTen_Tk
        '
        Me.TxtTen_Tk.BackColor = System.Drawing.Color.White
        Me.TxtTen_Tk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Tk.Enabled = False
        Me.TxtTen_Tk.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tk.Location = New System.Drawing.Point(345, 16)
        Me.TxtTen_Tk.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Tk.Name = "TxtTen_Tk"
        Me.TxtTen_Tk.ReadOnly = True
        Me.TxtTen_Tk.Size = New System.Drawing.Size(695, 17)
        Me.TxtTen_Tk.TabIndex = 89
        Me.TxtTen_Tk.TabStop = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(8, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 27)
        Me.Label1.TabIndex = 88
        Me.Label1.Tag = "The bank"
        Me.Label1.Text = "Phần ngân hàng"
        '
        'LabTk0
        '
        Me.LabTk0.Location = New System.Drawing.Point(8, 17)
        Me.LabTk0.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTk0.Name = "LabTk0"
        Me.LabTk0.Size = New System.Drawing.Size(135, 22)
        Me.LabTk0.TabIndex = 87
        Me.LabTk0.Tag = "Account"
        Me.LabTk0.Text = "TK kế toán"
        '
        'TxtTen_nh2
        '
        Me.TxtTen_nh2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_nh2.Location = New System.Drawing.Point(145, 122)
        Me.TxtTen_nh2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_nh2.Name = "TxtTen_nh2"
        Me.TxtTen_nh2.Size = New System.Drawing.Size(895, 24)
        Me.TxtTen_nh2.TabIndex = 3
        '
        'Labten_nh2
        '
        Me.Labten_nh2.Location = New System.Drawing.Point(8, 127)
        Me.Labten_nh2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labten_nh2.Name = "Labten_nh2"
        Me.Labten_nh2.Size = New System.Drawing.Size(133, 22)
        Me.Labten_nh2.TabIndex = 86
        Me.Labten_nh2.Tag = "English name"
        Me.Labten_nh2.Text = "Tên tiếng anh"
        '
        'TxtTen_nh
        '
        Me.TxtTen_nh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_nh.Location = New System.Drawing.Point(145, 93)
        Me.TxtTen_nh.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_nh.Name = "TxtTen_nh"
        Me.TxtTen_nh.Size = New System.Drawing.Size(895, 24)
        Me.TxtTen_nh.TabIndex = 2
        '
        'LabTen_nh
        '
        Me.LabTen_nh.Location = New System.Drawing.Point(8, 98)
        Me.LabTen_nh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTen_nh.Name = "LabTen_nh"
        Me.LabTen_nh.Size = New System.Drawing.Size(133, 22)
        Me.LabTen_nh.TabIndex = 85
        Me.LabTen_nh.Tag = "Bank"
        Me.LabTen_nh.Text = "Tên ngân hàng"
        '
        'TxtTk_nh
        '
        Me.TxtTk_nh.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtTk_nh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk_nh.Location = New System.Drawing.Point(145, 64)
        Me.TxtTk_nh.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTk_nh.Name = "TxtTk_nh"
        Me.TxtTk_nh.Size = New System.Drawing.Size(197, 24)
        Me.TxtTk_nh.TabIndex = 1
        '
        'Labtk_nh
        '
        Me.Labtk_nh.Location = New System.Drawing.Point(8, 69)
        Me.Labtk_nh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labtk_nh.Name = "Labtk_nh"
        Me.Labtk_nh.Size = New System.Drawing.Size(133, 22)
        Me.Labtk_nh.TabIndex = 84
        Me.Labtk_nh.Tag = "Bank Acc"
        Me.Labtk_nh.Text = "TK ngân hàng"
        '
        'DMTKNH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1045, 293)
        Me.Controls.Add(Me.TxtTk)
        Me.Controls.Add(Me.TxtE_mail)
        Me.Controls.Add(Me.Labemail)
        Me.Controls.Add(Me.TxtFax)
        Me.Controls.Add(Me.LabFax)
        Me.Controls.Add(Me.TxtDien_thoai)
        Me.Controls.Add(Me.LabDien_thoai)
        Me.Controls.Add(Me.TxtTinh_thanh)
        Me.Controls.Add(Me.Labtinh_thanh)
        Me.Controls.Add(Me.TxtMa_so_thue)
        Me.Controls.Add(Me.Labma_so_thue)
        Me.Controls.Add(Me.TxtTen_Tk)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabTk0)
        Me.Controls.Add(Me.TxtTen_nh2)
        Me.Controls.Add(Me.Labten_nh2)
        Me.Controls.Add(Me.TxtTen_nh)
        Me.Controls.Add(Me.LabTen_nh)
        Me.Controls.Add(Me.TxtTk_nh)
        Me.Controls.Add(Me.Labtk_nh)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "DMTKNH"
        Me.Text = "Danh mục tài khoản ngân hàng"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Labtk_nh, 0)
        Me.Controls.SetChildIndex(Me.TxtTk_nh, 0)
        Me.Controls.SetChildIndex(Me.LabTen_nh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_nh, 0)
        Me.Controls.SetChildIndex(Me.Labten_nh2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_nh2, 0)
        Me.Controls.SetChildIndex(Me.LabTk0, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tk, 0)
        Me.Controls.SetChildIndex(Me.Labma_so_thue, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_so_thue, 0)
        Me.Controls.SetChildIndex(Me.Labtinh_thanh, 0)
        Me.Controls.SetChildIndex(Me.TxtTinh_thanh, 0)
        Me.Controls.SetChildIndex(Me.LabDien_thoai, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_thoai, 0)
        Me.Controls.SetChildIndex(Me.LabFax, 0)
        Me.Controls.SetChildIndex(Me.TxtFax, 0)
        Me.Controls.SetChildIndex(Me.Labemail, 0)
        Me.Controls.SetChildIndex(Me.TxtE_mail, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtE_mail As System.Windows.Forms.TextBox
    Friend WithEvents Labemail As System.Windows.Forms.Label
    Friend WithEvents TxtFax As System.Windows.Forms.TextBox
    Friend WithEvents LabFax As System.Windows.Forms.Label
    Friend WithEvents TxtDien_thoai As System.Windows.Forms.TextBox
    Friend WithEvents LabDien_thoai As System.Windows.Forms.Label
    Friend WithEvents TxtTinh_thanh As System.Windows.Forms.TextBox
    Friend WithEvents Labtinh_thanh As System.Windows.Forms.Label
    Friend WithEvents TxtMa_so_thue As System.Windows.Forms.TextBox
    Friend WithEvents Labma_so_thue As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Tk As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabTk0 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_nh2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_nh2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_nh As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_nh As System.Windows.Forms.Label
    Friend WithEvents TxtTk_nh As System.Windows.Forms.TextBox
    Friend WithEvents Labtk_nh As System.Windows.Forms.Label

End Class
