<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysPrintBBDCCN
    Inherits DevExpress.XtraEditors.XtraForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SysPrintBBDCCN))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Rad12 = New System.Windows.Forms.RadioButton()
        Me.Rad11 = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Rad22 = New System.Windows.Forms.RadioButton()
        Me.Rad21 = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Rad32 = New System.Windows.Forms.RadioButton()
        Me.Rad31 = New System.Windows.Forms.RadioButton()
        Me.ButtCancel = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtOK = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtDai_Dien1 = New System.Windows.Forms.TextBox()
        Me.TxtChuc_Vu1 = New System.Windows.Forms.TextBox()
        Me.Labma_kh = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtChuc_Vu2 = New System.Windows.Forms.TextBox()
        Me.TxtDai_Dien2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtChuc_Vu4 = New System.Windows.Forms.TextBox()
        Me.TxtDai_Dien4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtChuc_Vu3 = New System.Windows.Forms.TextBox()
        Me.TxtDai_Dien3 = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.TxtHom_Nay = New ClsTextBox.txtDate1()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTai = New System.Windows.Forms.TextBox()
        Me.CmdEditReport = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Rad12)
        Me.GroupBox1.Controls.Add(Me.Rad11)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(218, 88)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Tag = "Print options"
        Me.GroupBox1.Text = "Kiểu in"
        '
        'Rad12
        '
        Me.Rad12.AutoSize = True
        Me.Rad12.Location = New System.Drawing.Point(44, 53)
        Me.Rad12.Name = "Rad12"
        Me.Rad12.Size = New System.Drawing.Size(71, 17)
        Me.Rad12.TabIndex = 20
        Me.Rad12.TabStop = True
        Me.Rad12.Tag = "Preview"
        Me.Rad12.Text = "&Xem và in"
        Me.Rad12.UseVisualStyleBackColor = True
        '
        'Rad11
        '
        Me.Rad11.AutoSize = True
        Me.Rad11.Location = New System.Drawing.Point(44, 26)
        Me.Rad11.Name = "Rad11"
        Me.Rad11.Size = New System.Drawing.Size(58, 17)
        Me.Rad11.TabIndex = 19
        Me.Rad11.TabStop = True
        Me.Rad11.Tag = "Print"
        Me.Rad11.Text = "&Máy In"
        Me.Rad11.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Rad22)
        Me.GroupBox2.Controls.Add(Me.Rad21)
        Me.GroupBox2.Location = New System.Drawing.Point(229, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(218, 88)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = "Currency"
        Me.GroupBox2.Text = "Loại tiền"
        '
        'Rad22
        '
        Me.Rad22.AutoSize = True
        Me.Rad22.Location = New System.Drawing.Point(103, 53)
        Me.Rad22.Name = "Rad22"
        Me.Rad22.Size = New System.Drawing.Size(65, 17)
        Me.Rad22.TabIndex = 20
        Me.Rad22.TabStop = True
        Me.Rad22.Tag = "&Currency"
        Me.Rad22.Text = "&Ngoại tệ"
        Me.Rad22.UseVisualStyleBackColor = True
        '
        'Rad21
        '
        Me.Rad21.AutoSize = True
        Me.Rad21.Location = New System.Drawing.Point(103, 26)
        Me.Rad21.Name = "Rad21"
        Me.Rad21.Size = New System.Drawing.Size(46, 17)
        Me.Rad21.TabIndex = 19
        Me.Rad21.TabStop = True
        Me.Rad21.Tag = "&VND"
        Me.Rad21.Text = "&VNĐ"
        Me.Rad21.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Rad32)
        Me.GroupBox3.Controls.Add(Me.Rad31)
        Me.GroupBox3.Location = New System.Drawing.Point(454, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(218, 88)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Tag = "Language"
        Me.GroupBox3.Text = "Ngôn ngữ"
        '
        'Rad32
        '
        Me.Rad32.AutoSize = True
        Me.Rad32.Location = New System.Drawing.Point(64, 53)
        Me.Rad32.Name = "Rad32"
        Me.Rad32.Size = New System.Drawing.Size(73, 17)
        Me.Rad32.TabIndex = 20
        Me.Rad32.TabStop = True
        Me.Rad32.Tag = "&English"
        Me.Rad32.Text = "Tiếng &Anh"
        Me.Rad32.UseVisualStyleBackColor = True
        '
        'Rad31
        '
        Me.Rad31.AutoSize = True
        Me.Rad31.Location = New System.Drawing.Point(64, 26)
        Me.Rad31.Name = "Rad31"
        Me.Rad31.Size = New System.Drawing.Size(72, 17)
        Me.Rad31.TabIndex = 19
        Me.Rad31.TabStop = True
        Me.Rad31.Tag = "Vietnamese"
        Me.Rad31.Text = "&Tiếng Việt"
        Me.Rad31.UseVisualStyleBackColor = True
        '
        'ButtCancel
        '
        Me.ButtCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtCancel.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtCancel.Appearance.Options.UseForeColor = True
        Me.ButtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtCancel.Image = CType(resources.GetObject("ButtCancel.Image"), System.Drawing.Image)
        Me.ButtCancel.Location = New System.Drawing.Point(580, 340)
        Me.ButtCancel.Name = "ButtCancel"
        Me.ButtCancel.Size = New System.Drawing.Size(100, 30)
        Me.ButtCancel.TabIndex = 14
        Me.ButtCancel.Tag = "&Exit"
        Me.ButtCancel.Text = "&Quay ra"
        '
        'ButtOK
        '
        Me.ButtOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Image = CType(resources.GetObject("ButtOK.Image"), System.Drawing.Image)
        Me.ButtOK.Location = New System.Drawing.Point(478, 340)
        Me.ButtOK.Name = "ButtOK"
        Me.ButtOK.Size = New System.Drawing.Size(100, 30)
        Me.ButtOK.TabIndex = 13
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'TxtDai_Dien1
        '
        Me.TxtDai_Dien1.Location = New System.Drawing.Point(84, 178)
        Me.TxtDai_Dien1.Name = "TxtDai_Dien1"
        Me.TxtDai_Dien1.Size = New System.Drawing.Size(249, 21)
        Me.TxtDai_Dien1.TabIndex = 5
        '
        'TxtChuc_Vu1
        '
        Me.TxtChuc_Vu1.Location = New System.Drawing.Point(423, 178)
        Me.TxtChuc_Vu1.Name = "TxtChuc_Vu1"
        Me.TxtChuc_Vu1.Size = New System.Drawing.Size(249, 21)
        Me.TxtChuc_Vu1.TabIndex = 7
        '
        'Labma_kh
        '
        Me.Labma_kh.Location = New System.Drawing.Point(12, 181)
        Me.Labma_kh.Name = "Labma_kh"
        Me.Labma_kh.Size = New System.Drawing.Size(66, 13)
        Me.Labma_kh.TabIndex = 207
        Me.Labma_kh.Tag = "Replay 1"
        Me.Labma_kh.Text = "Đại diện 1"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(339, 181)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 208
        Me.Label1.Tag = "Job"
        Me.Label1.Text = "Chức vụ"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(339, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 212
        Me.Label2.Tag = "Job"
        Me.Label2.Text = "Chức vụ"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(12, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 211
        Me.Label3.Tag = "Replay 2"
        Me.Label3.Text = "Đại diện 2"
        '
        'TxtChuc_Vu2
        '
        Me.TxtChuc_Vu2.Location = New System.Drawing.Point(423, 203)
        Me.TxtChuc_Vu2.Name = "TxtChuc_Vu2"
        Me.TxtChuc_Vu2.Size = New System.Drawing.Size(249, 21)
        Me.TxtChuc_Vu2.TabIndex = 8
        '
        'TxtDai_Dien2
        '
        Me.TxtDai_Dien2.Location = New System.Drawing.Point(84, 203)
        Me.TxtDai_Dien2.Name = "TxtDai_Dien2"
        Me.TxtDai_Dien2.Size = New System.Drawing.Size(249, 21)
        Me.TxtDai_Dien2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(339, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 220
        Me.Label4.Tag = "Job"
        Me.Label4.Text = "Chức vụ"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 299)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 219
        Me.Label5.Tag = "Replay 1"
        Me.Label5.Text = "Đại diện 2"
        '
        'TxtChuc_Vu4
        '
        Me.TxtChuc_Vu4.Location = New System.Drawing.Point(423, 296)
        Me.TxtChuc_Vu4.Name = "TxtChuc_Vu4"
        Me.TxtChuc_Vu4.Size = New System.Drawing.Size(249, 21)
        Me.TxtChuc_Vu4.TabIndex = 12
        '
        'TxtDai_Dien4
        '
        Me.TxtDai_Dien4.Location = New System.Drawing.Point(84, 296)
        Me.TxtDai_Dien4.Name = "TxtDai_Dien4"
        Me.TxtDai_Dien4.Size = New System.Drawing.Size(249, 21)
        Me.TxtDai_Dien4.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(339, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 216
        Me.Label6.Tag = "Job"
        Me.Label6.Text = "Chức vụ"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(12, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 215
        Me.Label7.Tag = "Replay 1"
        Me.Label7.Text = "Đại diện 1"
        '
        'TxtChuc_Vu3
        '
        Me.TxtChuc_Vu3.Location = New System.Drawing.Point(423, 271)
        Me.TxtChuc_Vu3.Name = "TxtChuc_Vu3"
        Me.TxtChuc_Vu3.Size = New System.Drawing.Size(249, 21)
        Me.TxtChuc_Vu3.TabIndex = 10
        '
        'TxtDai_Dien3
        '
        Me.TxtDai_Dien3.Location = New System.Drawing.Point(84, 271)
        Me.TxtDai_Dien3.Name = "TxtDai_Dien3"
        Me.TxtDai_Dien3.Size = New System.Drawing.Size(249, 21)
        Me.TxtDai_Dien3.TabIndex = 9
        '
        'GroupBox4
        '
        Me.GroupBox4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox4.Location = New System.Drawing.Point(6, 248)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(673, 76)
        Me.GroupBox4.TabIndex = 221
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "II. BÊN B"
        '
        'GroupBox5
        '
        Me.GroupBox5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox5.Location = New System.Drawing.Point(6, 155)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(673, 76)
        Me.GroupBox5.TabIndex = 222
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "I. BÊN A"
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(12, 120)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(76, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 224
        Me.LabM_Ngay_Ct1.Tag = "Date from"
        Me.LabM_Ngay_Ct1.Text = "Hôm nay ngày"
        '
        'TxtHom_Nay
        '
        Me.TxtHom_Nay.Flags = 0
        Me.TxtHom_Nay.ForeColor = System.Drawing.Color.Navy
        Me.TxtHom_Nay.IsAllowResize = False
        Me.TxtHom_Nay.Location = New System.Drawing.Point(88, 117)
        Me.TxtHom_Nay.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtHom_Nay.MaskDate = "dd/MM/yyyy"
        Me.TxtHom_Nay.MaxLength = 10
        Me.TxtHom_Nay.Name = "TxtHom_Nay"
        Me.TxtHom_Nay.RangeMax = New Date(CType(0, Long))
        Me.TxtHom_Nay.RangeMin = New Date(CType(0, Long))
        Me.TxtHom_Nay.ShowDayBeforeMonth = False
        Me.TxtHom_Nay.Size = New System.Drawing.Size(110, 21)
        Me.TxtHom_Nay.TabIndex = 3
        Me.TxtHom_Nay.Text = "01/01/1900"
        Me.TxtHom_Nay.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(201, 120)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(21, 13)
        Me.Label8.TabIndex = 225
        Me.Label8.Tag = "Date from"
        Me.Label8.Text = "Tại"
        '
        'TxtTai
        '
        Me.TxtTai.Location = New System.Drawing.Point(229, 117)
        Me.TxtTai.Name = "TxtTai"
        Me.TxtTai.Size = New System.Drawing.Size(443, 21)
        Me.TxtTai.TabIndex = 4
        '
        'CmdEditReport
        '
        Me.CmdEditReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdEditReport.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdEditReport.Appearance.Options.UseForeColor = True
        Me.CmdEditReport.Image = CType(resources.GetObject("CmdEditReport.Image"), System.Drawing.Image)
        Me.CmdEditReport.Location = New System.Drawing.Point(6, 340)
        Me.CmdEditReport.Name = "CmdEditReport"
        Me.CmdEditReport.Size = New System.Drawing.Size(100, 30)
        Me.CmdEditReport.TabIndex = 226
        Me.CmdEditReport.Tag = "&Edit"
        Me.CmdEditReport.Text = "&Sữa mẫu"
        '
        'SysPrintBBDCCN
        '
        Me.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtCancel
        Me.ClientSize = New System.Drawing.Size(684, 372)
        Me.Controls.Add(Me.CmdEditReport)
        Me.Controls.Add(Me.TxtTai)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtHom_Nay)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtChuc_Vu4)
        Me.Controls.Add(Me.TxtDai_Dien4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtChuc_Vu3)
        Me.Controls.Add(Me.TxtDai_Dien3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtChuc_Vu2)
        Me.Controls.Add(Me.TxtDai_Dien2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Labma_kh)
        Me.Controls.Add(Me.TxtChuc_Vu1)
        Me.Controls.Add(Me.TxtDai_Dien1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ButtCancel)
        Me.Controls.Add(Me.ButtOK)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SysPrintBBDCCN"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Print options"
        Me.Text = "Lựa chọn in"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ButtCancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtOK As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Rad12 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad11 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Rad22 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad21 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Rad32 As System.Windows.Forms.RadioButton
    Friend WithEvents Rad31 As System.Windows.Forms.RadioButton
    Friend WithEvents TxtDai_Dien1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtChuc_Vu1 As System.Windows.Forms.TextBox
    Friend WithEvents Labma_kh As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtChuc_Vu2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDai_Dien2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtChuc_Vu4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDai_Dien4 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtChuc_Vu3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtDai_Dien3 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents TxtHom_Nay As ClsTextBox.txtDate1
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTai As System.Windows.Forms.TextBox
    Friend WithEvents CmdEditReport As DevExpress.XtraEditors.SimpleButton
End Class
