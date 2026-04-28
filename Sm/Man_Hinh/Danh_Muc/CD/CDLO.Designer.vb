<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CDLO
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
        Me.TxtDu_No_NT00 = New ClsTextBox.txtTien_NT()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_vt = New System.Windows.Forms.TextBox()
        Me.lbMa_Phi = New System.Windows.Forms.Label()
        Me.TxtMa_vt = New Cyber.SmLists.TxtLookup()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTien_NT1 = New ClsTextBox.txtTien_NT()
        Me.TxtTien_NT2 = New ClsTextBox.txtTien_NT()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtMa_kho = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_kho = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtMa_Lo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(829, 238)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(693, 238)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 13
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(739, 255)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.ReadOnly = True
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(179, 24)
        Me.TxtMa_Dvcs.TabIndex = 0
        Me.TxtMa_Dvcs.TabStop = False
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(147, 251)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkActi.TabIndex = 12
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 225)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(960, 12)
        Me.GroupBoxLine.TabIndex = 11
        '
        'TxtDu_No_NT00
        '
        Me.TxtDu_No_NT00.AllowNegative = True
        Me.TxtDu_No_NT00.Flags = 7680
        Me.TxtDu_No_NT00.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtDu_No_NT00.ForeColor = System.Drawing.Color.Navy
        Me.TxtDu_No_NT00.InputMask = "### ### ### ### ###.##"
        Me.TxtDu_No_NT00.Location = New System.Drawing.Point(181, 157)
        Me.TxtDu_No_NT00.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDu_No_NT00.MaxWholeDigits = 17
        Me.TxtDu_No_NT00.Name = "TxtDu_No_NT00"
        Me.TxtDu_No_NT00.RangeMax = 1.7976931348623157E+308R
        Me.TxtDu_No_NT00.RangeMin = -1.7976931348623157E+308R
        Me.TxtDu_No_NT00.Size = New System.Drawing.Size(179, 24)
        Me.TxtDu_No_NT00.TabIndex = 5
        Me.TxtDu_No_NT00.Tag = "### ### ### ### ###.##"
        Me.TxtDu_No_NT00.Text = "0.00"
        Me.TxtDu_No_NT00.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(13, 160)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 22)
        Me.Label3.TabIndex = 263
        Me.Label3.Tag = "Opening balance (FC)"
        Me.Label3.Text = "Dư đầu kỳ (NT)"
        '
        'TxtTen_vt
        '
        Me.TxtTen_vt.BackColor = System.Drawing.Color.White
        Me.TxtTen_vt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_vt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_vt.Location = New System.Drawing.Point(375, 43)
        Me.TxtTen_vt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_vt.Name = "TxtTen_vt"
        Me.TxtTen_vt.ReadOnly = True
        Me.TxtTen_vt.Size = New System.Drawing.Size(569, 17)
        Me.TxtTen_vt.TabIndex = 260
        Me.TxtTen_vt.TabStop = False
        '
        'lbMa_Phi
        '
        Me.lbMa_Phi.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lbMa_Phi.ForeColor = System.Drawing.Color.Navy
        Me.lbMa_Phi.Location = New System.Drawing.Point(13, 42)
        Me.lbMa_Phi.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbMa_Phi.Name = "lbMa_Phi"
        Me.lbMa_Phi.Size = New System.Drawing.Size(133, 22)
        Me.lbMa_Phi.TabIndex = 262
        Me.lbMa_Phi.Tag = "Supplies"
        Me.lbMa_Phi.Text = "Mã Vật tư"
        '
        'TxtMa_vt
        '
        Me.TxtMa_vt._ActilookupPopup = False
        Me.TxtMa_vt.CyberActilookupPopup = True
        Me.TxtMa_vt.Dv_ListDetail = Nothing
        Me.TxtMa_vt.Dv_Master = Nothing
        Me.TxtMa_vt.FilterClient = ""
        Me.TxtMa_vt.FilterSQL = ""
        Me.TxtMa_vt.Location = New System.Drawing.Point(181, 39)
        Me.TxtMa_vt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_vt.Name = "TxtMa_vt"
        Me.TxtMa_vt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_vt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_vt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_vt.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_vt.TabIndex = 1
        Me.TxtMa_vt.Table_Name = ""
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(7, 245)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(625, 29)
        Me.Label12.TabIndex = 12
        Me.Label12.Tag = "Note: Year starts balance inserts into balance sheet"
        Me.Label12.Text = "Ghi chú: Số dư đầu năm để lên bảng cân đối kế toán"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'TxtTien_NT1
        '
        Me.TxtTien_NT1.AllowNegative = True
        Me.TxtTien_NT1.Flags = 7680
        Me.TxtTien_NT1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTien_NT1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_NT1.InputMask = "### ### ### ### ###.##"
        Me.TxtTien_NT1.Location = New System.Drawing.Point(181, 127)
        Me.TxtTien_NT1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTien_NT1.MaxWholeDigits = 17
        Me.TxtTien_NT1.Name = "TxtTien_NT1"
        Me.TxtTien_NT1.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_NT1.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_NT1.Size = New System.Drawing.Size(179, 24)
        Me.TxtTien_NT1.TabIndex = 4
        Me.TxtTien_NT1.Tag = "### ### ### ### ###.##"
        Me.TxtTien_NT1.Text = "0.00"
        Me.TxtTien_NT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTien_NT2
        '
        Me.TxtTien_NT2.AllowNegative = True
        Me.TxtTien_NT2.Flags = 7680
        Me.TxtTien_NT2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTien_NT2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_NT2.InputMask = "### ### ### ### ###.##"
        Me.TxtTien_NT2.Location = New System.Drawing.Point(181, 97)
        Me.TxtTien_NT2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTien_NT2.MaxWholeDigits = 17
        Me.TxtTien_NT2.Name = "TxtTien_NT2"
        Me.TxtTien_NT2.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_NT2.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_NT2.Size = New System.Drawing.Size(179, 24)
        Me.TxtTien_NT2.TabIndex = 3
        Me.TxtTien_NT2.Tag = "### ### ### ### ###.##"
        Me.TxtTien_NT2.Text = "0.00"
        Me.TxtTien_NT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(13, 127)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 27)
        Me.Label2.TabIndex = 287
        Me.Label2.Tag = "Opening balance VND"
        Me.Label2.Text = "Dư đầu kỳ VND (giá trị)"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(13, 99)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 22)
        Me.Label6.TabIndex = 286
        Me.Label6.Tag = "Opening stock"
        Me.Label6.Text = "Tồn đầu kỳ (số lượng)"
        '
        'TxtMa_kho
        '
        Me.TxtMa_kho._ActilookupPopup = False
        Me.TxtMa_kho.CyberActilookupPopup = True
        Me.TxtMa_kho.Dv_ListDetail = Nothing
        Me.TxtMa_kho.Dv_Master = Nothing
        Me.TxtMa_kho.FilterClient = ""
        Me.TxtMa_kho.FilterSQL = ""
        Me.TxtMa_kho.Location = New System.Drawing.Point(181, 10)
        Me.TxtMa_kho.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_kho.Name = "TxtMa_kho"
        Me.TxtMa_kho.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kho.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kho.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kho.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_kho.TabIndex = 0
        Me.TxtMa_kho.Table_Name = ""
        '
        'TxtTen_kho
        '
        Me.TxtTen_kho.BackColor = System.Drawing.Color.White
        Me.TxtTen_kho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kho.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_kho.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kho.Location = New System.Drawing.Point(375, 14)
        Me.TxtTen_kho.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_kho.Name = "TxtTen_kho"
        Me.TxtTen_kho.ReadOnly = True
        Me.TxtTen_kho.Size = New System.Drawing.Size(569, 17)
        Me.TxtTen_kho.TabIndex = 294
        Me.TxtTen_kho.TabStop = False
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(13, 13)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 22)
        Me.Label11.TabIndex = 295
        Me.Label11.Tag = "Warehouse"
        Me.Label11.Text = "Mã kho"
        '
        'TxtMa_Lo
        '
        Me.TxtMa_Lo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Lo.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Lo.Location = New System.Drawing.Point(181, 68)
        Me.TxtMa_Lo.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Lo.Name = "TxtMa_Lo"
        Me.TxtMa_Lo.Size = New System.Drawing.Size(179, 24)
        Me.TxtMa_Lo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(13, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 22)
        Me.Label1.TabIndex = 305
        Me.Label1.Tag = "Batch code"
        Me.Label1.Text = "Mã lô"
        '
        'CDLO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(965, 281)
        Me.Controls.Add(Me.TxtMa_Lo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMa_kho)
        Me.Controls.Add(Me.TxtTen_kho)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtTien_NT1)
        Me.Controls.Add(Me.TxtTien_NT2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TxtMa_vt)
        Me.Controls.Add(Me.TxtDu_No_NT00)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_vt)
        Me.Controls.Add(Me.lbMa_Phi)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "CDLO"
        Me.Tb_Name = "Open"
        Me.Text = "Số dư đầu kỳ tài khoản"
        Me.Controls.SetChildIndex(Me.lbMa_Phi, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_vt, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtDu_No_NT00, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_vt, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_NT2, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_NT1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kho, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kho, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Lo, 0)
        CType(Me.TxtMa_vt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_kho.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtDu_No_NT00 As ClsTextBox.txtTien_NT
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_vt As System.Windows.Forms.TextBox
    Friend WithEvents lbMa_Phi As System.Windows.Forms.Label
    Friend WithEvents TxtMa_vt As Cyber.SmLists.TxtLookup
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtTien_NT1 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTien_NT2 As ClsTextBox.txtTien_NT
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_kho As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_kho As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Lo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
