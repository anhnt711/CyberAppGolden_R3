<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMHLKU
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
        Me.TxtTen_KU = New System.Windows.Forms.TextBox()
        Me.txtNgay_HL = New ClsTextBox.txtDate()
        Me.TxtMa_KU = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabMa_TD1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_KU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(661, 217)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(525, 217)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(384, 225)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(147, 230)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 204)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(792, 12)
        '
        'TxtGt2
        '
        Me.TxtGt2.AllowNegative = True
        Me.TxtGt2.Flags = 7680
        Me.TxtGt2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtGt2.ForeColor = System.Drawing.Color.Navy
        Me.TxtGt2.InputMask = "### ### ### ### ###"
        Me.TxtGt2.Location = New System.Drawing.Point(140, 110)
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
        Me.TxtGt3.Location = New System.Drawing.Point(140, 141)
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
        Me.TxtGt4.Location = New System.Drawing.Point(140, 173)
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
        Me.TxtGt1.Location = New System.Drawing.Point(140, 77)
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
        Me.Label5.Location = New System.Drawing.Point(0, 175)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 21)
        Me.Label5.TabIndex = 48
        Me.Label5.Tag = "Free 1"
        Me.Label5.Text = "Giá trị 4"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 144)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 21)
        Me.Label4.TabIndex = 47
        Me.Label4.Tag = "Free 1"
        Me.Label4.Text = "Giá trị 3"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 21)
        Me.Label3.TabIndex = 46
        Me.Label3.Tag = "Free 1"
        Me.Label3.Text = "Giá trị 2"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 21)
        Me.Label2.TabIndex = 45
        Me.Label2.Tag = "Free 1"
        Me.Label2.Text = "Giá trị 1"
        '
        'TxtTen_KU
        '
        Me.TxtTen_KU.BackColor = System.Drawing.Color.White
        Me.TxtTen_KU.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KU.Enabled = False
        Me.TxtTen_KU.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KU.Location = New System.Drawing.Point(347, 20)
        Me.TxtTen_KU.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_KU.Name = "TxtTen_KU"
        Me.TxtTen_KU.ReadOnly = True
        Me.TxtTen_KU.Size = New System.Drawing.Size(435, 17)
        Me.TxtTen_KU.TabIndex = 43
        Me.TxtTen_KU.TabStop = False
        '
        'txtNgay_HL
        '
        Me.txtNgay_HL.Flags = 65536
        Me.txtNgay_HL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.txtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.txtNgay_HL.isEmpty = True
        Me.txtNgay_HL.Location = New System.Drawing.Point(140, 46)
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
        'TxtMa_KU
        '
        Me.TxtMa_KU._ActilookupPopup = False
        Me.TxtMa_KU.CyberActilookupPopup = True
        Me.TxtMa_KU.Dv_ListDetail = Nothing
        Me.TxtMa_KU.Dv_Master = Nothing
        Me.TxtMa_KU.FilterClient = ""
        Me.TxtMa_KU.FilterSQL = ""
        Me.TxtMa_KU.Location = New System.Drawing.Point(140, 16)
        Me.TxtMa_KU.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_KU.Name = "TxtMa_KU"
        Me.TxtMa_KU.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KU.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KU.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KU.Size = New System.Drawing.Size(199, 22)
        Me.TxtMa_KU.TabIndex = 0
        Me.TxtMa_KU.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 21)
        Me.Label1.TabIndex = 42
        Me.Label1.Tag = "Effective date"
        Me.Label1.Text = "Ngày hiệu lực"
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.Location = New System.Drawing.Point(0, 17)
        Me.LabMa_TD1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(113, 21)
        Me.LabMa_TD1.TabIndex = 40
        Me.LabMa_TD1.Tag = "Indenture"
        Me.LabMa_TD1.Text = "Mã khế ước"
        '
        'DMHLKU
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 260)
        Me.Controls.Add(Me.TxtGt2)
        Me.Controls.Add(Me.TxtGt3)
        Me.Controls.Add(Me.TxtGt4)
        Me.Controls.Add(Me.TxtGt1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_KU)
        Me.Controls.Add(Me.txtNgay_HL)
        Me.Controls.Add(Me.TxtMa_KU)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "DMHLKU"
        Me.Text = "Danh mục hiệu lực khế ước"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KU, 0)
        Me.Controls.SetChildIndex(Me.txtNgay_HL, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KU, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtGt1, 0)
        Me.Controls.SetChildIndex(Me.TxtGt4, 0)
        Me.Controls.SetChildIndex(Me.TxtGt3, 0)
        Me.Controls.SetChildIndex(Me.TxtGt2, 0)
        CType(Me.TxtMa_KU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents TxtTen_KU As System.Windows.Forms.TextBox
    Friend WithEvents txtNgay_HL As ClsTextBox.txtDate
    Friend WithEvents TxtMa_KU As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label

End Class
