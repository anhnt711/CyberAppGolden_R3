<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ph89CVDV_Clock_CVDVKhoangToKTV
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
        Me.CmbLoai = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txtten = New System.Windows.Forms.TextBox()
        Me.Txtma = New Cyber.SmLists.TxtLookup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.TxtTu_ngay = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Txtden_ngay = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        CType(Me.Txtma.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(518, 153)
        Me.ButtExit.TabIndex = 9
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(416, 153)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(310, 159)
        Me.TxtMa_Dvcs.TabIndex = 5
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 163)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 143)
        Me.GroupBoxLine.Size = New System.Drawing.Size(616, 9)
        Me.GroupBoxLine.TabIndex = 3
        '
        'CmbLoai
        '
        Me.CmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLoai.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbLoai.ForeColor = System.Drawing.Color.Navy
        Me.CmbLoai.FormattingEnabled = True
        Me.CmbLoai.Location = New System.Drawing.Point(110, 12)
        Me.CmbLoai.Name = "CmbLoai"
        Me.CmbLoai.Size = New System.Drawing.Size(508, 21)
        Me.CmbLoai.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(5, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 472
        Me.Label3.Tag = "Backcolor"
        Me.Label3.Text = "Loại"
        '
        'Txtten
        '
        Me.Txtten.BackColor = System.Drawing.Color.White
        Me.Txtten.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten.Enabled = False
        Me.Txtten.ForeColor = System.Drawing.Color.Navy
        Me.Txtten.Location = New System.Drawing.Point(288, 42)
        Me.Txtten.Name = "Txtten"
        Me.Txtten.ReadOnly = True
        Me.Txtten.Size = New System.Drawing.Size(330, 14)
        Me.Txtten.TabIndex = 2079
        Me.Txtten.TabStop = False
        '
        'Txtma
        '
        Me.Txtma._ActilookupPopup = False
        Me.Txtma.CyberActilookupPopup = True
        Me.Txtma.Dv_ListDetail = Nothing
        Me.Txtma.Dv_Master = Nothing
        Me.Txtma.FilterClient = ""
        Me.Txtma.FilterSQL = ""
        Me.Txtma.Location = New System.Drawing.Point(110, 39)
        Me.Txtma.Name = "Txtma"
        Me.Txtma.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma.Size = New System.Drawing.Size(172, 20)
        Me.Txtma.TabIndex = 1
        Me.Txtma.Table_Name = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(5, 42)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 2078
        Me.Label10.Tag = "Code"
        Me.Label10.Text = "Mã"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 14)
        Me.Label1.TabIndex = 2083
        Me.Label1.Tag = "Date to"
        Me.Label1.Text = "Đến ngày"
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.Location = New System.Drawing.Point(5, 73)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(79, 14)
        Me.LabNgay_ban.TabIndex = 2082
        Me.LabNgay_ban.Tag = "Date from"
        Me.LabNgay_ban.Text = "Từ ngày"
        '
        'TxtTu_ngay
        '
        Me.TxtTu_ngay.Flags = 0
        Me.TxtTu_ngay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TxtTu_ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtTu_ngay.IsAllowResize = False
        Me.TxtTu_ngay.Location = New System.Drawing.Point(110, 64)
        Me.TxtTu_ngay.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtTu_ngay.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtTu_ngay.MaxLength = 10
        Me.TxtTu_ngay.Name = "TxtTu_ngay"
        Me.TxtTu_ngay.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtTu_ngay.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtTu_ngay.ShowDayBeforeMonth = False
        Me.TxtTu_ngay.Size = New System.Drawing.Size(172, 23)
        Me.TxtTu_ngay.TabIndex = 2
        Me.TxtTu_ngay.Value = "15/05/2019 21:50"
        '
        'Txtden_ngay
        '
        Me.Txtden_ngay.Flags = 0
        Me.Txtden_ngay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Txtden_ngay.ForeColor = System.Drawing.Color.Navy
        Me.Txtden_ngay.IsAllowResize = False
        Me.Txtden_ngay.Location = New System.Drawing.Point(110, 94)
        Me.Txtden_ngay.Margin = New System.Windows.Forms.Padding(0)
        Me.Txtden_ngay.MaskDate = "dd/MM/yyyy HH:mm"
        Me.Txtden_ngay.MaxLength = 10
        Me.Txtden_ngay.Name = "Txtden_ngay"
        Me.Txtden_ngay.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.Txtden_ngay.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Txtden_ngay.ShowDayBeforeMonth = False
        Me.Txtden_ngay.Size = New System.Drawing.Size(172, 23)
        Me.Txtden_ngay.TabIndex = 3
        Me.Txtden_ngay.Value = "15/05/2019 21:50"
        '
        'Ph89CVDV_Clock_CVDVKhoangToKTV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(620, 186)
        Me.Controls.Add(Me.Txtden_ngay)
        Me.Controls.Add(Me.TxtTu_ngay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.Controls.Add(Me.Txtten)
        Me.Controls.Add(Me.Txtma)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbLoai)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(490, 100)
        Me.Name = "Ph89CVDV_Clock_CVDVKhoangToKTV"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.CmbLoai, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Txtma, 0)
        Me.Controls.SetChildIndex(Me.Txtten, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtTu_ngay, 0)
        Me.Controls.SetChildIndex(Me.Txtden_ngay, 0)
        CType(Me.Txtma.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbLoai As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Txtten As System.Windows.Forms.TextBox
    Friend WithEvents Txtma As Cyber.SmLists.TxtLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents TxtTu_ngay As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Txtden_ngay As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH

End Class
