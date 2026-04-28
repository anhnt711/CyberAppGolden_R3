<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmNgayNghi
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
        Me.LabNgay_ban = New System.Windows.Forms.Label()
        Me.TxtTu_Ngay = New ClsTextBox.txtDate1()
        Me.TxtDen_Ngay = New ClsTextBox.txtDate1()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmbLoai = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSTT = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtSTT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(585, 149)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 15
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(449, 149)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 14
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(365, 263)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(143, 24)
        Me.TxtMa_Dvcs.TabIndex = 16
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(123, 161)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 13
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 136)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(716, 12)
        Me.GroupBoxLine.TabIndex = 14
        '
        'LabNgay_ban
        '
        Me.LabNgay_ban.Location = New System.Drawing.Point(16, 24)
        Me.LabNgay_ban.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNgay_ban.Name = "LabNgay_ban"
        Me.LabNgay_ban.Size = New System.Drawing.Size(105, 18)
        Me.LabNgay_ban.TabIndex = 29
        Me.LabNgay_ban.Tag = "Date from"
        Me.LabNgay_ban.Text = "Từ ngày"
        '
        'TxtTu_Ngay
        '
        Me.TxtTu_Ngay.Flags = 65536
        Me.TxtTu_Ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtTu_Ngay.IsAllowResize = False
        Me.TxtTu_Ngay.isEmpty = True
        Me.TxtTu_Ngay.Location = New System.Drawing.Point(123, 20)
        Me.TxtTu_Ngay.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtTu_Ngay.MaskDate = "dd/MM/yyyy"
        Me.TxtTu_Ngay.MaxLength = 10
        Me.TxtTu_Ngay.Name = "TxtTu_Ngay"
        Me.TxtTu_Ngay.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtTu_Ngay.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtTu_Ngay.ShowDayBeforeMonth = False
        Me.TxtTu_Ngay.Size = New System.Drawing.Size(197, 24)
        Me.TxtTu_Ngay.TabIndex = 0
        Me.TxtTu_Ngay.Text = "07/09/2011"
        Me.TxtTu_Ngay.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtDen_Ngay
        '
        Me.TxtDen_Ngay.Flags = 65536
        Me.TxtDen_Ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtDen_Ngay.IsAllowResize = False
        Me.TxtDen_Ngay.isEmpty = True
        Me.TxtDen_Ngay.Location = New System.Drawing.Point(123, 52)
        Me.TxtDen_Ngay.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtDen_Ngay.MaskDate = "dd/MM/yyyy"
        Me.TxtDen_Ngay.MaxLength = 10
        Me.TxtDen_Ngay.Name = "TxtDen_Ngay"
        Me.TxtDen_Ngay.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtDen_Ngay.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtDen_Ngay.ShowDayBeforeMonth = False
        Me.TxtDen_Ngay.Size = New System.Drawing.Size(197, 24)
        Me.TxtDen_Ngay.TabIndex = 1
        Me.TxtDen_Ngay.Text = "07/09/2011"
        Me.TxtDen_Ngay.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 56)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 18)
        Me.Label1.TabIndex = 31
        Me.Label1.Tag = "Date to"
        Me.Label1.Text = "Đến ngày"
        '
        'CmbLoai
        '
        Me.CmbLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLoai.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbLoai.ForeColor = System.Drawing.Color.Navy
        Me.CmbLoai.FormattingEnabled = True
        Me.CmbLoai.Location = New System.Drawing.Point(123, 84)
        Me.CmbLoai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbLoai.Name = "CmbLoai"
        Me.CmbLoai.Size = New System.Drawing.Size(197, 25)
        Me.CmbLoai.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 88)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 18)
        Me.Label2.TabIndex = 33
        Me.Label2.Tag = "Type"
        Me.Label2.Text = "Hình thức"
        '
        'TxtSTT
        '
        Me.TxtSTT._ActilookupPopup = False
        Me.TxtSTT.CyberActilookupPopup = True
        Me.TxtSTT.Dv_ListDetail = Nothing
        Me.TxtSTT.Dv_Master = Nothing
        Me.TxtSTT.FilterClient = ""
        Me.TxtSTT.FilterSQL = ""
        Me.TxtSTT.Location = New System.Drawing.Point(409, 21)
        Me.TxtSTT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSTT.Name = "TxtSTT"
        Me.TxtSTT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtSTT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtSTT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtSTT.Size = New System.Drawing.Size(199, 22)
        Me.TxtSTT.TabIndex = 34
        Me.TxtSTT.Table_Name = ""
        Me.TxtSTT.Visible = False
        '
        'DmNgayNghi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(721, 192)
        Me.Controls.Add(Me.TxtSTT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbLoai)
        Me.Controls.Add(Me.TxtDen_Ngay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTu_Ngay)
        Me.Controls.Add(Me.LabNgay_ban)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "DmNgayNghi"
        Me.Controls.SetChildIndex(Me.LabNgay_ban, 0)
        Me.Controls.SetChildIndex(Me.TxtTu_Ngay, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtDen_Ngay, 0)
        Me.Controls.SetChildIndex(Me.CmbLoai, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtSTT, 0)
        CType(Me.TxtSTT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabNgay_ban As System.Windows.Forms.Label
    Friend WithEvents TxtTu_Ngay As ClsTextBox.txtDate1
    Friend WithEvents TxtDen_Ngay As ClsTextBox.txtDate1
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbLoai As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtSTT As Cyber.SmLists.TxtLookup

End Class
