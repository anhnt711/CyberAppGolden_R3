<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMTHEVIP
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New Cyber.SmLists.TxtLookup()
        Me.TxtNgay_HL1 = New ClsTextBox.txtDate()
        Me.LabNgay_Ku = New System.Windows.Forms.Label()
        Me.LabLs_TH = New System.Windows.Forms.Label()
        Me.TxtPT_GG = New ClsTextBox.txtTien_NT()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtGia_Tri1 = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtGia_Tri2 = New ClsTextBox.txtTien_NT()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtNgay_HL2 = New ClsTextBox.txtDate()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMa_The = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_Xe.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(629, 171)
        Me.ButtExit.TabIndex = 8
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(527, 171)
        Me.ButtOK.TabIndex = 7
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(421, 177)
        Me.TxtMa_Dvcs.TabIndex = 22
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 181)
        Me.ChkActi.TabIndex = 21
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 161)
        Me.GroupBoxLine.Size = New System.Drawing.Size(727, 9)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "License plate"
        Me.Label1.Text = "Biển số xe"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe._ActilookupPopup = False
        Me.TxtMa_Xe.CyberActilookupPopup = True
        Me.TxtMa_Xe.Dv_ListDetail = Nothing
        Me.TxtMa_Xe.Dv_Master = Nothing
        Me.TxtMa_Xe.FilterClient = ""
        Me.TxtMa_Xe.FilterSQL = ""
        Me.TxtMa_Xe.Location = New System.Drawing.Point(110, 60)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Xe.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Xe.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_Xe.TabIndex = 3
        Me.TxtMa_Xe.Table_Name = ""
        '
        'TxtNgay_HL1
        '
        Me.TxtNgay_HL1.Flags = 65536
        Me.TxtNgay_HL1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_HL1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL1.isEmpty = True
        Me.TxtNgay_HL1.Location = New System.Drawing.Point(110, 34)
        Me.TxtNgay_HL1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL1.MaxLength = 10
        Me.TxtNgay_HL1.Name = "TxtNgay_HL1"
        Me.TxtNgay_HL1.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL1.ShowDayBeforeMonth = False
        Me.TxtNgay_HL1.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_HL1.TabIndex = 1
        Me.TxtNgay_HL1.Text = "26/07/2011"
        Me.TxtNgay_HL1.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'LabNgay_Ku
        '
        Me.LabNgay_Ku.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabNgay_Ku.Location = New System.Drawing.Point(5, 35)
        Me.LabNgay_Ku.Name = "LabNgay_Ku"
        Me.LabNgay_Ku.Size = New System.Drawing.Size(99, 21)
        Me.LabNgay_Ku.TabIndex = 358
        Me.LabNgay_Ku.Tag = "Date from"
        Me.LabNgay_Ku.Text = "Hiệu lực từ"
        Me.LabNgay_Ku.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabLs_TH
        '
        Me.LabLs_TH.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabLs_TH.ForeColor = System.Drawing.Color.Navy
        Me.LabLs_TH.Location = New System.Drawing.Point(5, 134)
        Me.LabLs_TH.Name = "LabLs_TH"
        Me.LabLs_TH.Size = New System.Drawing.Size(94, 18)
        Me.LabLs_TH.TabIndex = 376
        Me.LabLs_TH.Tag = "% Discount"
        Me.LabLs_TH.Text = "% Giảm giá"
        '
        'TxtPT_GG
        '
        Me.TxtPT_GG.AllowNegative = True
        Me.TxtPT_GG.Flags = 7680
        Me.TxtPT_GG.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtPT_GG.ForeColor = System.Drawing.Color.Navy
        Me.TxtPT_GG.InputMask = "###"
        Me.TxtPT_GG.Location = New System.Drawing.Point(110, 131)
        Me.TxtPT_GG.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtPT_GG.MaxWholeDigits = 2
        Me.TxtPT_GG.Name = "TxtPT_GG"
        Me.TxtPT_GG.RangeMax = 1.7976931348623157E+308R
        Me.TxtPT_GG.RangeMin = -1.7976931348623157E+308R
        Me.TxtPT_GG.Size = New System.Drawing.Size(76, 21)
        Me.TxtPT_GG.TabIndex = 6
        Me.TxtPT_GG.Text = "0"
        Me.TxtPT_GG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(195, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 15)
        Me.Label8.TabIndex = 378
        Me.Label8.Tag = "VND"
        Me.Label8.Text = "%"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 380
        Me.Label2.Tag = "Code"
        Me.Label2.Text = "Mã thẻ VIP"
        '
        'TxtGia_Tri1
        '
        Me.TxtGia_Tri1.AllowNegative = True
        Me.TxtGia_Tri1.Flags = 7680
        Me.TxtGia_Tri1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_Tri1.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_Tri1.InputMask = "### ### ### ### ### ###"
        Me.TxtGia_Tri1.Location = New System.Drawing.Point(110, 83)
        Me.TxtGia_Tri1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtGia_Tri1.MaxWholeDigits = 17
        Me.TxtGia_Tri1.Name = "TxtGia_Tri1"
        Me.TxtGia_Tri1.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_Tri1.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_Tri1.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia_Tri1.TabIndex = 4
        Me.TxtGia_Tri1.Text = "0"
        Me.TxtGia_Tri1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(5, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 382
        Me.Label3.Tag = "Value"
        Me.Label3.Text = "Giá trị "
        '
        'TxtGia_Tri2
        '
        Me.TxtGia_Tri2.AllowNegative = True
        Me.TxtGia_Tri2.Flags = 7680
        Me.TxtGia_Tri2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGia_Tri2.ForeColor = System.Drawing.Color.Navy
        Me.TxtGia_Tri2.InputMask = "### ### ### ### ### ###"
        Me.TxtGia_Tri2.Location = New System.Drawing.Point(110, 106)
        Me.TxtGia_Tri2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtGia_Tri2.MaxWholeDigits = 17
        Me.TxtGia_Tri2.Name = "TxtGia_Tri2"
        Me.TxtGia_Tri2.RangeMax = 1.7976931348623157E+308R
        Me.TxtGia_Tri2.RangeMin = -1.7976931348623157E+308R
        Me.TxtGia_Tri2.Size = New System.Drawing.Size(149, 21)
        Me.TxtGia_Tri2.TabIndex = 5
        Me.TxtGia_Tri2.Text = "0"
        Me.TxtGia_Tri2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(5, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 18)
        Me.Label4.TabIndex = 384
        Me.Label4.Tag = "Value 2"
        Me.Label4.Text = "Giá trị 2"
        '
        'TxtNgay_HL2
        '
        Me.TxtNgay_HL2.Flags = 65536
        Me.TxtNgay_HL2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_HL2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL2.isEmpty = True
        Me.TxtNgay_HL2.Location = New System.Drawing.Point(327, 32)
        Me.TxtNgay_HL2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL2.MaxLength = 10
        Me.TxtNgay_HL2.Name = "TxtNgay_HL2"
        Me.TxtNgay_HL2.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL2.ShowDayBeforeMonth = False
        Me.TxtNgay_HL2.Size = New System.Drawing.Size(149, 21)
        Me.TxtNgay_HL2.TabIndex = 2
        Me.TxtNgay_HL2.Text = "26/07/2011"
        Me.TxtNgay_HL2.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label5.Location = New System.Drawing.Point(265, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 18)
        Me.Label5.TabIndex = 386
        Me.Label5.Tag = "To"
        Me.Label5.Text = "Đến"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtMa_The
        '
        Me.TxtMa_The.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_The.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_The.Location = New System.Drawing.Point(110, 9)
        Me.TxtMa_The.Name = "TxtMa_The"
        Me.TxtMa_The.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_The.TabIndex = 0
        '
        'DMTHEVIP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(731, 204)
        Me.Controls.Add(Me.TxtMa_The)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNgay_HL2)
        Me.Controls.Add(Me.TxtGia_Tri2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtGia_Tri1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtPT_GG)
        Me.Controls.Add(Me.LabLs_TH)
        Me.Controls.Add(Me.TxtNgay_HL1)
        Me.Controls.Add(Me.LabNgay_Ku)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMTHEVIP"
        Me.Text = "Danh mục khế ước"
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ku, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL1, 0)
        Me.Controls.SetChildIndex(Me.LabLs_TH, 0)
        Me.Controls.SetChildIndex(Me.TxtPT_GG, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_Tri1, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtGia_Tri2, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL2, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_The, 0)
        CType(Me.TxtMa_Xe.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtNgay_HL1 As ClsTextBox.txtDate
    Friend WithEvents LabNgay_Ku As System.Windows.Forms.Label
    Friend WithEvents LabLs_TH As System.Windows.Forms.Label
    Friend WithEvents TxtPT_GG As ClsTextBox.txtTien_NT
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtGia_Tri1 As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtGia_Tri2 As ClsTextBox.txtTien_NT
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_HL2 As ClsTextBox.txtDate
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_The As Windows.Forms.TextBox
End Class
