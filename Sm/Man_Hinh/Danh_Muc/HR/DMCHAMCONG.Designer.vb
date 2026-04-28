<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMCHAMCONG
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
        Me.LabTen_KH = New System.Windows.Forms.Label()
        Me.Labten_Kh2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_HS = New System.Windows.Forms.Label()
        Me.TxtMa_HS = New Cyber.SmLists.TxtLookup()
        Me.TxtTu_Ngay = New ClsTextBox.txtDate()
        Me.TxtDen_Ngay = New ClsTextBox.txtDate()
        Me.TxtGhi_Chu = New System.Windows.Forms.TextBox()
        Me.TxtLy_Do = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(704, 170)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 9
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(563, 170)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 8
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(392, 182)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(112, 184)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 6
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 156)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(841, 7)
        Me.GroupBoxLine.TabIndex = 5
        '
        'LabTen_KH
        '
        Me.LabTen_KH.Location = New System.Drawing.Point(20, 97)
        Me.LabTen_KH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTen_KH.Name = "LabTen_KH"
        Me.LabTen_KH.Size = New System.Drawing.Size(133, 20)
        Me.LabTen_KH.TabIndex = 12
        Me.LabTen_KH.Tag = "Reason"
        Me.LabTen_KH.Text = "Lý do"
        '
        'Labten_Kh2
        '
        Me.Labten_Kh2.Location = New System.Drawing.Point(20, 127)
        Me.Labten_Kh2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labten_Kh2.Name = "Labten_Kh2"
        Me.Labten_Kh2.Size = New System.Drawing.Size(133, 20)
        Me.Labten_Kh2.TabIndex = 14
        Me.Labten_Kh2.Tag = "Note"
        Me.Labten_Kh2.Text = "Ghi chú"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Date from"
        Me.Label1.Text = "Từ ngày"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 67)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Tag = "Date to"
        Me.Label2.Text = "Đến ngày"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(20, 12)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 20)
        Me.Label3.TabIndex = 33
        Me.Label3.Tag = "Staff"
        Me.Label3.Text = "Mã HS"
        '
        'TxtTen_HS
        '
        Me.TxtTen_HS.BackColor = System.Drawing.Color.White
        Me.TxtTen_HS.Location = New System.Drawing.Point(316, 12)
        Me.TxtTen_HS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_HS.Name = "TxtTen_HS"
        Me.TxtTen_HS.Size = New System.Drawing.Size(528, 18)
        Me.TxtTen_HS.TabIndex = 362
        Me.TxtTen_HS.Tag = "Group 4"
        '
        'TxtMa_HS
        '
        Me.TxtMa_HS._ActilookupPopup = False
        Me.TxtMa_HS.CyberActilookupPopup = True
        Me.TxtMa_HS.Dv_ListDetail = Nothing
        Me.TxtMa_HS.Dv_Master = Nothing
        Me.TxtMa_HS.FilterClient = ""
        Me.TxtMa_HS.FilterSQL = ""
        Me.TxtMa_HS.Location = New System.Drawing.Point(112, 8)
        Me.TxtMa_HS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_HS.Name = "TxtMa_HS"
        Me.TxtMa_HS.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HS.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_HS.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_HS.Size = New System.Drawing.Size(199, 22)
        Me.TxtMa_HS.TabIndex = 0
        Me.TxtMa_HS.Table_Name = ""
        '
        'TxtTu_Ngay
        '
        Me.TxtTu_Ngay.Flags = 65536
        Me.TxtTu_Ngay.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTu_Ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtTu_Ngay.isEmpty = True
        Me.TxtTu_Ngay.Location = New System.Drawing.Point(112, 33)
        Me.TxtTu_Ngay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTu_Ngay.MaskDate = "dd/MM/yyyy"
        Me.TxtTu_Ngay.MaxLength = 10
        Me.TxtTu_Ngay.Name = "TxtTu_Ngay"
        Me.TxtTu_Ngay.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtTu_Ngay.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtTu_Ngay.ShowDayBeforeMonth = False
        Me.TxtTu_Ngay.Size = New System.Drawing.Size(197, 24)
        Me.TxtTu_Ngay.TabIndex = 1
        Me.TxtTu_Ngay.Text = "26/07/2011"
        Me.TxtTu_Ngay.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'TxtDen_Ngay
        '
        Me.TxtDen_Ngay.Flags = 65536
        Me.TxtDen_Ngay.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtDen_Ngay.ForeColor = System.Drawing.Color.Navy
        Me.TxtDen_Ngay.isEmpty = True
        Me.TxtDen_Ngay.Location = New System.Drawing.Point(112, 63)
        Me.TxtDen_Ngay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDen_Ngay.MaskDate = "dd/MM/yyyy"
        Me.TxtDen_Ngay.MaxLength = 10
        Me.TxtDen_Ngay.Name = "TxtDen_Ngay"
        Me.TxtDen_Ngay.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtDen_Ngay.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtDen_Ngay.ShowDayBeforeMonth = False
        Me.TxtDen_Ngay.Size = New System.Drawing.Size(197, 24)
        Me.TxtDen_Ngay.TabIndex = 2
        Me.TxtDen_Ngay.Text = "26/07/2011"
        Me.TxtDen_Ngay.Value = New Date(2011, 7, 26, 0, 0, 0, 0)
        '
        'TxtGhi_Chu
        '
        Me.TxtGhi_Chu.ForeColor = System.Drawing.Color.Navy
        Me.TxtGhi_Chu.Location = New System.Drawing.Point(112, 123)
        Me.TxtGhi_Chu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtGhi_Chu.Name = "TxtGhi_Chu"
        Me.TxtGhi_Chu.Size = New System.Drawing.Size(724, 24)
        Me.TxtGhi_Chu.TabIndex = 4
        '
        'TxtLy_Do
        '
        Me.TxtLy_Do.ForeColor = System.Drawing.Color.Navy
        Me.TxtLy_Do.Location = New System.Drawing.Point(112, 93)
        Me.TxtLy_Do.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtLy_Do.Name = "TxtLy_Do"
        Me.TxtLy_Do.Size = New System.Drawing.Size(724, 24)
        Me.TxtLy_Do.TabIndex = 3
        '
        'DMCHAMCONG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(847, 225)
        Me.Controls.Add(Me.TxtLy_Do)
        Me.Controls.Add(Me.TxtGhi_Chu)
        Me.Controls.Add(Me.TxtDen_Ngay)
        Me.Controls.Add(Me.TxtTu_Ngay)
        Me.Controls.Add(Me.TxtTen_HS)
        Me.Controls.Add(Me.TxtMa_HS)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Labten_Kh2)
        Me.Controls.Add(Me.LabTen_KH)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMCHAMCONG"
        Me.Text = "Danh mục chấm công"
        Me.Controls.SetChildIndex(Me.LabTen_KH, 0)
        Me.Controls.SetChildIndex(Me.Labten_Kh2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HS, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HS, 0)
        Me.Controls.SetChildIndex(Me.TxtTu_Ngay, 0)
        Me.Controls.SetChildIndex(Me.TxtDen_Ngay, 0)
        Me.Controls.SetChildIndex(Me.TxtGhi_Chu, 0)
        Me.Controls.SetChildIndex(Me.TxtLy_Do, 0)
        CType(Me.TxtMa_HS.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabTen_KH As System.Windows.Forms.Label
    Friend WithEvents Labten_Kh2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_HS As System.Windows.Forms.Label
    Friend WithEvents TxtMa_HS As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTu_Ngay As ClsTextBox.txtDate
    Friend WithEvents TxtDen_Ngay As ClsTextBox.txtDate
    Friend WithEvents TxtGhi_Chu As System.Windows.Forms.TextBox
    Friend WithEvents TxtLy_Do As System.Windows.Forms.TextBox

End Class
