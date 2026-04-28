<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmGiaPW1
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
        Me.LabMa_TD1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_VT = New Cyber.SmLists.TxtLookup()
        Me.txtNgay_HL = New ClsTextBox.txtDate()
        Me.TxtTen_VT = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtM_DG = New ClsTextBox.txtTien_NT()
        Me.TxtM_HS_QD = New ClsTextBox.txtTien_NT()
        Me.TxtM_DG_DV = New ClsTextBox.txtTien_NT()
        Me.TxtTen_KH = New System.Windows.Forms.TextBox()
        Me.TxtMa_KH = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_VT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(637, 201)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(501, 201)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(360, 209)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(147, 214)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 188)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(768, 12)
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.Location = New System.Drawing.Point(3, 12)
        Me.LabMa_TD1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(135, 20)
        Me.LabMa_TD1.TabIndex = 10
        Me.LabMa_TD1.Tag = "Product"
        Me.LabMa_TD1.Text = "Hàng hóa"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 72)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Tag = "Effective date"
        Me.Label1.Text = "Ngày hiệu lực"
        '
        'TxtMa_VT
        '
        Me.TxtMa_VT._ActilookupPopup = False
        Me.TxtMa_VT.CyberActilookupPopup = True
        Me.TxtMa_VT.Dv_ListDetail = Nothing
        Me.TxtMa_VT.Dv_Master = Nothing
        Me.TxtMa_VT.FilterClient = ""
        Me.TxtMa_VT.FilterSQL = ""
        Me.TxtMa_VT.Location = New System.Drawing.Point(140, 7)
        Me.TxtMa_VT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_VT.Name = "TxtMa_VT"
        Me.TxtMa_VT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_VT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_VT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_VT.Size = New System.Drawing.Size(199, 22)
        Me.TxtMa_VT.TabIndex = 0
        Me.TxtMa_VT.Table_Name = ""
        '
        'txtNgay_HL
        '
        Me.txtNgay_HL.Flags = 65536
        Me.txtNgay_HL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.txtNgay_HL.isEmpty = True
        Me.txtNgay_HL.Location = New System.Drawing.Point(140, 67)
        Me.txtNgay_HL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.txtNgay_HL.MaxLength = 10
        Me.txtNgay_HL.Name = "txtNgay_HL"
        Me.txtNgay_HL.RangeMax = New Date(9999, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_HL.ShowDayBeforeMonth = False
        Me.txtNgay_HL.Size = New System.Drawing.Size(197, 24)
        Me.txtNgay_HL.TabIndex = 2
        Me.txtNgay_HL.Text = "18/09/2011"
        Me.txtNgay_HL.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtTen_VT
        '
        Me.TxtTen_VT.BackColor = System.Drawing.Color.White
        Me.TxtTen_VT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_VT.Enabled = False
        Me.TxtTen_VT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_VT.Location = New System.Drawing.Point(353, 8)
        Me.TxtTen_VT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_VT.Name = "TxtTen_VT"
        Me.TxtTen_VT.ReadOnly = True
        Me.TxtTen_VT.Size = New System.Drawing.Size(405, 17)
        Me.TxtTen_VT.TabIndex = 24
        Me.TxtTen_VT.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(3, 102)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Tag = "Price"
        Me.Label2.Text = "Đơn giá bán"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(3, 133)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 20)
        Me.Label3.TabIndex = 31
        Me.Label3.Tag = "Unit price of service"
        Me.Label3.Text = "Đơn giá cân dịch vụ"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(3, 165)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(135, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Tag = "Conversion factor"
        Me.Label4.Text = "Hệ số quy đổi"
        '
        'TxtM_DG
        '
        Me.TxtM_DG.AllowNegative = True
        Me.TxtM_DG.Flags = 7680
        Me.TxtM_DG.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtM_DG.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_DG.InputMask = "### ### ### ### ###"
        Me.TxtM_DG.Location = New System.Drawing.Point(140, 98)
        Me.TxtM_DG.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_DG.MaxWholeDigits = 14
        Me.TxtM_DG.Name = "TxtM_DG"
        Me.TxtM_DG.RangeMax = 1.7976931348623157E+308R
        Me.TxtM_DG.RangeMin = -1.7976931348623157E+308R
        Me.TxtM_DG.Size = New System.Drawing.Size(197, 24)
        Me.TxtM_DG.TabIndex = 3
        Me.TxtM_DG.Text = "0"
        Me.TxtM_DG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtM_HS_QD
        '
        Me.TxtM_HS_QD.AllowNegative = True
        Me.TxtM_HS_QD.Flags = 7680
        Me.TxtM_HS_QD.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtM_HS_QD.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_HS_QD.InputMask = "### ### ### ### ###.####"
        Me.TxtM_HS_QD.Location = New System.Drawing.Point(140, 160)
        Me.TxtM_HS_QD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_HS_QD.MaxWholeDigits = 19
        Me.TxtM_HS_QD.Name = "TxtM_HS_QD"
        Me.TxtM_HS_QD.RangeMax = 1.7976931348623157E+308R
        Me.TxtM_HS_QD.RangeMin = -1.7976931348623157E+308R
        Me.TxtM_HS_QD.Size = New System.Drawing.Size(197, 24)
        Me.TxtM_HS_QD.TabIndex = 5
        Me.TxtM_HS_QD.Text = "0.0000"
        Me.TxtM_HS_QD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtM_DG_DV
        '
        Me.TxtM_DG_DV.AllowNegative = True
        Me.TxtM_DG_DV.Flags = 7680
        Me.TxtM_DG_DV.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtM_DG_DV.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_DG_DV.InputMask = "### ### ### ### ###"
        Me.TxtM_DG_DV.Location = New System.Drawing.Point(140, 128)
        Me.TxtM_DG_DV.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_DG_DV.MaxWholeDigits = 14
        Me.TxtM_DG_DV.Name = "TxtM_DG_DV"
        Me.TxtM_DG_DV.RangeMax = 1.7976931348623157E+308R
        Me.TxtM_DG_DV.RangeMin = -1.7976931348623157E+308R
        Me.TxtM_DG_DV.Size = New System.Drawing.Size(197, 24)
        Me.TxtM_DG_DV.TabIndex = 4
        Me.TxtM_DG_DV.Text = "0"
        Me.TxtM_DG_DV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTen_KH
        '
        Me.TxtTen_KH.BackColor = System.Drawing.Color.White
        Me.TxtTen_KH.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KH.Enabled = False
        Me.TxtTen_KH.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KH.Location = New System.Drawing.Point(353, 38)
        Me.TxtTen_KH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_KH.Name = "TxtTen_KH"
        Me.TxtTen_KH.ReadOnly = True
        Me.TxtTen_KH.Size = New System.Drawing.Size(405, 17)
        Me.TxtTen_KH.TabIndex = 35
        Me.TxtTen_KH.TabStop = False
        '
        'TxtMa_KH
        '
        Me.TxtMa_KH._ActilookupPopup = False
        Me.TxtMa_KH.CyberActilookupPopup = True
        Me.TxtMa_KH.Dv_ListDetail = Nothing
        Me.TxtMa_KH.Dv_Master = Nothing
        Me.TxtMa_KH.FilterClient = ""
        Me.TxtMa_KH.FilterSQL = ""
        Me.TxtMa_KH.Location = New System.Drawing.Point(140, 37)
        Me.TxtMa_KH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_KH.Name = "TxtMa_KH"
        Me.TxtMa_KH.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KH.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KH.Size = New System.Drawing.Size(199, 22)
        Me.TxtMa_KH.TabIndex = 1
        Me.TxtMa_KH.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 42)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 20)
        Me.Label5.TabIndex = 34
        Me.Label5.Tag = "Customer"
        Me.Label5.Text = "Khách hàng"
        '
        'DmGiaPW1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(773, 245)
        Me.Controls.Add(Me.TxtTen_KH)
        Me.Controls.Add(Me.TxtMa_KH)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtM_DG_DV)
        Me.Controls.Add(Me.TxtM_HS_QD)
        Me.Controls.Add(Me.TxtM_DG)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_VT)
        Me.Controls.Add(Me.txtNgay_HL)
        Me.Controls.Add(Me.TxtMa_VT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "DmGiaPW1"
        Me.Text = "Danh mục hiệu lực bộ phận"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_VT, 0)
        Me.Controls.SetChildIndex(Me.txtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_VT, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtM_DG, 0)
        Me.Controls.SetChildIndex(Me.TxtM_HS_QD, 0)
        Me.Controls.SetChildIndex(Me.TxtM_DG_DV, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KH, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KH, 0)
        CType(Me.TxtMa_VT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KH.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_VT As Cyber.SmLists.TxtLookup
    Friend WithEvents txtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents TxtTen_VT As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtM_DG As ClsTextBox.txtTien_NT
    Friend WithEvents TxtM_HS_QD As ClsTextBox.txtTien_NT
    Friend WithEvents TxtM_DG_DV As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTen_KH As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KH As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
