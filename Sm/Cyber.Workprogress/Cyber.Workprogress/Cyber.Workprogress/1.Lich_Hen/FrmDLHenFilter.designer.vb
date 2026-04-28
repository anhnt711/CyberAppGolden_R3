<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDLHenFilter
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
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.LbTo = New System.Windows.Forms.Label()
        Me.LbFrom = New System.Windows.Forms.Label()
        Me.TxtNgay_Ct2 = New ClsTextBox.txtDate1()
        Me.TxtNgay_Ct1 = New ClsTextBox.txtDate1()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_HS = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 81)
        Me.GroupBoxLine.Size = New System.Drawing.Size(562, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(362, 91)
        Me.ButtOK.TabIndex = 4
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(464, 91)
        Me.ButtExit.TabIndex = 5
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(104, 36)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(119, 20)
        Me.TxtMa_Xe.TabIndex = 2
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Navy
        Me.Label22.Location = New System.Drawing.Point(19, 39)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(42, 13)
        Me.Label22.TabIndex = 339
        Me.Label22.Tag = "Voucher from"
        Me.Label22.Text = "Biển số"
        '
        'LbTo
        '
        Me.LbTo.AutoSize = True
        Me.LbTo.ForeColor = System.Drawing.Color.Navy
        Me.LbTo.Location = New System.Drawing.Point(231, 12)
        Me.LbTo.Name = "LbTo"
        Me.LbTo.Size = New System.Drawing.Size(53, 13)
        Me.LbTo.TabIndex = 338
        Me.LbTo.Tag = "Date to"
        Me.LbTo.Text = "Đến ngày"
        '
        'LbFrom
        '
        Me.LbFrom.AutoSize = True
        Me.LbFrom.ForeColor = System.Drawing.Color.Navy
        Me.LbFrom.Location = New System.Drawing.Point(19, 12)
        Me.LbFrom.Name = "LbFrom"
        Me.LbFrom.Size = New System.Drawing.Size(46, 13)
        Me.LbFrom.TabIndex = 337
        Me.LbFrom.Tag = "Date from"
        Me.LbFrom.Text = "Từ ngày"
        '
        'TxtNgay_Ct2
        '
        Me.TxtNgay_Ct2.Flags = 65536
        Me.TxtNgay_Ct2.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct2.IsAllowResize = False
        Me.TxtNgay_Ct2.isEmpty = True
        Me.TxtNgay_Ct2.Location = New System.Drawing.Point(316, 9)
        Me.TxtNgay_Ct2.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct2.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct2.MaxLength = 10
        Me.TxtNgay_Ct2.Name = "TxtNgay_Ct2"
        Me.TxtNgay_Ct2.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct2.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct2.Size = New System.Drawing.Size(119, 20)
        Me.TxtNgay_Ct2.TabIndex = 1
        Me.TxtNgay_Ct2.Text = "07/09/2011"
        Me.TxtNgay_Ct2.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtNgay_Ct1
        '
        Me.TxtNgay_Ct1.Flags = 65536
        Me.TxtNgay_Ct1.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct1.IsAllowResize = False
        Me.TxtNgay_Ct1.isEmpty = True
        Me.TxtNgay_Ct1.Location = New System.Drawing.Point(104, 9)
        Me.TxtNgay_Ct1.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Ct1.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct1.MaxLength = 10
        Me.TxtNgay_Ct1.Name = "TxtNgay_Ct1"
        Me.TxtNgay_Ct1.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct1.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct1.Size = New System.Drawing.Size(119, 20)
        Me.TxtNgay_Ct1.TabIndex = 0
        Me.TxtNgay_Ct1.Text = "07/09/2011"
        Me.TxtNgay_Ct1.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs._ActilookupPopup = False
        Me.TxtMa_Hs.CyberActilookupPopup = True
        Me.TxtMa_Hs.Dv_ListDetail = Nothing
        Me.TxtMa_Hs.Dv_Master = Nothing
        Me.TxtMa_Hs.FilterClient = ""
        Me.TxtMa_Hs.FilterSQL = ""
        Me.TxtMa_Hs.Location = New System.Drawing.Point(104, 60)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(119, 22)
        Me.TxtMa_Hs.TabIndex = 3
        Me.TxtMa_Hs.Table_Name = ""
        '
        'TxtTen_HS
        '
        Me.TxtTen_HS.BackColor = System.Drawing.Color.White
        Me.TxtTen_HS.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_HS.Enabled = False
        Me.TxtTen_HS.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HS.Location = New System.Drawing.Point(234, 69)
        Me.TxtTen_HS.Name = "TxtTen_HS"
        Me.TxtTen_HS.Size = New System.Drawing.Size(320, 13)
        Me.TxtTen_HS.TabIndex = 7164
        Me.TxtTen_HS.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(23, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 7165
        Me.Label1.Tag = "Advisor"
        Me.Label1.Text = "CVDV"
        '
        'FrmDLHenFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(566, 145)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Controls.Add(Me.TxtTen_HS)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.LbTo)
        Me.Controls.Add(Me.LbFrom)
        Me.Controls.Add(Me.TxtNgay_Ct2)
        Me.Controls.Add(Me.TxtNgay_Ct1)
        Me.Name = "FrmDLHenFilter"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct2, 0)
        Me.Controls.SetChildIndex(Me.LbFrom, 0)
        Me.Controls.SetChildIndex(Me.LbTo, 0)
        Me.Controls.SetChildIndex(Me.Label22, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents LbTo As System.Windows.Forms.Label
    Friend WithEvents LbFrom As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Ct2 As ClsTextBox.txtDate1
    Friend WithEvents TxtNgay_Ct1 As ClsTextBox.txtDate1
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_HS As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
