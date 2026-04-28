<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMHLHS
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
        Me.TxtGt2 = New ClsTextBox.txtTien_NT()
        Me.TxtGt3 = New ClsTextBox.txtTien_NT()
        Me.TxtGt4 = New ClsTextBox.txtTien_NT()
        Me.TxtGt1 = New ClsTextBox.txtTien_NT()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_HS = New System.Windows.Forms.TextBox()
        Me.txtNgay_HL = New ClsTextBox.txtDate()
        Me.TxtMa_HS = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabMa_TD1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(669, 201)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(533, 201)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(392, 209)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(147, 214)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 188)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(800, 12)
        '
        'TxtGt2
        '
        Me.TxtGt2.AllowNegative = True
        Me.TxtGt2.Flags = 7680
        Me.TxtGt2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtGt2.ForeColor = System.Drawing.Color.Navy
        Me.TxtGt2.InputMask = "### ### ### ### ###"
        Me.TxtGt2.Location = New System.Drawing.Point(147, 92)
        Me.TxtGt2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGt2.MaxWholeDigits = 14
        Me.TxtGt2.Name = "TxtGt2"
        Me.TxtGt2.RangeMax = 1.7976931348623157E+308R
        Me.TxtGt2.RangeMin = -1.7976931348623157E+308R
        Me.TxtGt2.Size = New System.Drawing.Size(197, 24)
        Me.TxtGt2.TabIndex = 3
        Me.TxtGt2.Text = "0"
        Me.TxtGt2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtGt3
        '
        Me.TxtGt3.AllowNegative = True
        Me.TxtGt3.Flags = 7680
        Me.TxtGt3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtGt3.ForeColor = System.Drawing.Color.Navy
        Me.TxtGt3.InputMask = "### ### ### ### ###"
        Me.TxtGt3.Location = New System.Drawing.Point(147, 122)
        Me.TxtGt3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGt3.MaxWholeDigits = 14
        Me.TxtGt3.Name = "TxtGt3"
        Me.TxtGt3.RangeMax = 1.7976931348623157E+308R
        Me.TxtGt3.RangeMin = -1.7976931348623157E+308R
        Me.TxtGt3.Size = New System.Drawing.Size(197, 24)
        Me.TxtGt3.TabIndex = 4
        Me.TxtGt3.Text = "0"
        Me.TxtGt3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtGt4
        '
        Me.TxtGt4.AllowNegative = True
        Me.TxtGt4.Flags = 7680
        Me.TxtGt4.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtGt4.ForeColor = System.Drawing.Color.Navy
        Me.TxtGt4.InputMask = "### ### ### ### ###"
        Me.TxtGt4.Location = New System.Drawing.Point(147, 152)
        Me.TxtGt4.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGt4.MaxWholeDigits = 14
        Me.TxtGt4.Name = "TxtGt4"
        Me.TxtGt4.RangeMax = 1.7976931348623157E+308R
        Me.TxtGt4.RangeMin = -1.7976931348623157E+308R
        Me.TxtGt4.Size = New System.Drawing.Size(197, 24)
        Me.TxtGt4.TabIndex = 5
        Me.TxtGt4.Text = "0"
        Me.TxtGt4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtGt1
        '
        Me.TxtGt1.AllowNegative = True
        Me.TxtGt1.Flags = 7680
        Me.TxtGt1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtGt1.ForeColor = System.Drawing.Color.Navy
        Me.TxtGt1.InputMask = "### ### ### ### ###"
        Me.TxtGt1.Location = New System.Drawing.Point(147, 61)
        Me.TxtGt1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGt1.MaxWholeDigits = 14
        Me.TxtGt1.Name = "TxtGt1"
        Me.TxtGt1.RangeMax = 1.7976931348623157E+308R
        Me.TxtGt1.RangeMin = -1.7976931348623157E+308R
        Me.TxtGt1.Size = New System.Drawing.Size(197, 24)
        Me.TxtGt1.TabIndex = 2
        Me.TxtGt1.Text = "0"
        Me.TxtGt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(7, 157)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 21)
        Me.Label5.TabIndex = 48
        Me.Label5.Tag = "Value 4"
        Me.Label5.Text = "Giá trị 4"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(7, 127)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 21)
        Me.Label4.TabIndex = 47
        Me.Label4.Tag = "Value 3"
        Me.Label4.Text = "Giá trị 3"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(7, 97)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 21)
        Me.Label3.TabIndex = 46
        Me.Label3.Tag = "Value 2"
        Me.Label3.Text = "Giá trị 2"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(7, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 21)
        Me.Label2.TabIndex = 45
        Me.Label2.Tag = "Value 1"
        Me.Label2.Text = "Giá trị 1"
        '
        'TxtTen_HS
        '
        Me.TxtTen_HS.BackColor = System.Drawing.Color.White
        Me.TxtTen_HS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HS.Enabled = False
        Me.TxtTen_HS.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HS.Location = New System.Drawing.Point(353, 7)
        Me.TxtTen_HS.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_HS.Name = "TxtTen_HS"
        Me.TxtTen_HS.ReadOnly = True
        Me.TxtTen_HS.Size = New System.Drawing.Size(440, 17)
        Me.TxtTen_HS.TabIndex = 43
        Me.TxtTen_HS.TabStop = False
        '
        'txtNgay_HL
        '
        Me.txtNgay_HL.Flags = 65536
        Me.txtNgay_HL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.txtNgay_HL.isEmpty = True
        Me.txtNgay_HL.Location = New System.Drawing.Point(147, 31)
        Me.txtNgay_HL.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.txtNgay_HL.MaxLength = 10
        Me.txtNgay_HL.Name = "txtNgay_HL"
        Me.txtNgay_HL.RangeMax = New Date(9999, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.txtNgay_HL.ShowDayBeforeMonth = False
        Me.txtNgay_HL.Size = New System.Drawing.Size(197, 24)
        Me.txtNgay_HL.TabIndex = 1
        Me.txtNgay_HL.Text = "__/__/____"
        Me.txtNgay_HL.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'TxtMa_HS
        '
        Me.TxtMa_HS._ActilookupPopup = False
        Me.TxtMa_HS.CyberActilookupPopup = True
        Me.TxtMa_HS.Dv_ListDetail = Nothing
        Me.TxtMa_HS.Dv_Master = Nothing
        Me.TxtMa_HS.FilterClient = ""
        Me.TxtMa_HS.FilterSQL = ""
        Me.TxtMa_HS.Location = New System.Drawing.Point(147, 3)
        Me.TxtMa_HS.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_HS.Name = "TxtMa_HS"
        Me.TxtMa_HS.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS.Size = New System.Drawing.Size(199, 22)
        Me.TxtMa_HS.TabIndex = 0
        Me.TxtMa_HS.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 21)
        Me.Label1.TabIndex = 42
        Me.Label1.Tag = "Effective date"
        Me.Label1.Text = "Ngày hiệu lực"
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.Location = New System.Drawing.Point(7, 8)
        Me.LabMa_TD1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(133, 21)
        Me.LabMa_TD1.TabIndex = 40
        Me.LabMa_TD1.Tag = "Code"
        Me.LabMa_TD1.Text = "Mã hồ sơ"
        '
        'DMHLHS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(805, 245)
        Me.Controls.Add(Me.TxtGt2)
        Me.Controls.Add(Me.TxtGt3)
        Me.Controls.Add(Me.TxtGt4)
        Me.Controls.Add(Me.TxtGt1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_HS)
        Me.Controls.Add(Me.txtNgay_HL)
        Me.Controls.Add(Me.TxtMa_HS)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "DMHLHS"
        Me.Text = "Danh mục hiệu lực hồ sơ"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS, 0)
        Me.Controls.SetChildIndex(Me.txtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtGt1, 0)
        Me.Controls.SetChildIndex(Me.TxtGt4, 0)
        Me.Controls.SetChildIndex(Me.TxtGt3, 0)
        Me.Controls.SetChildIndex(Me.TxtGt2, 0)
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtGt2 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtGt3 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtGt4 As ClsTextBox.txtTien_NT
    Friend WithEvents TxtGt1 As ClsTextBox.txtTien_NT
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_HS As System.Windows.Forms.TextBox
    Friend WithEvents txtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents TxtMa_HS As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label

End Class
