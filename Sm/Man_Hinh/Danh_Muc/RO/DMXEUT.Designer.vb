<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMXEUT
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
        Me.TxtGhi_chu = New System.Windows.Forms.TextBox()
        Me.LabGhi_chu = New System.Windows.Forms.Label()
        Me.LabMa_UT = New System.Windows.Forms.Label()
        Me.TxtTen_UT = New System.Windows.Forms.TextBox()
        Me.TxtMa_UT = New Cyber.SmLists.TxtLookup()
        Me.LabMa_xe = New System.Windows.Forms.Label()
        Me.TxtMa_xe = New System.Windows.Forms.TextBox()
        Me.TxtNgay_HL = New ClsTextBox.txtDate1()
        Me.LabNgay_hl = New System.Windows.Forms.Label()
        CType(Me.TxtMa_UT.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(893, 207)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(740, 207)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(581, 217)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMa_Dvcs.TabIndex = 5
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(165, 224)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 191)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1006, 9)
        Me.GroupBoxLine.TabIndex = 7
        '
        'TxtGhi_chu
        '
        Me.TxtGhi_chu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGhi_chu.ForeColor = System.Drawing.Color.Navy
        Me.TxtGhi_chu.Location = New System.Drawing.Point(165, 120)
        Me.TxtGhi_chu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtGhi_chu.Name = "TxtGhi_chu"
        Me.TxtGhi_chu.Size = New System.Drawing.Size(844, 27)
        Me.TxtGhi_chu.TabIndex = 3
        '
        'LabGhi_chu
        '
        Me.LabGhi_chu.AutoSize = True
        Me.LabGhi_chu.Location = New System.Drawing.Point(8, 126)
        Me.LabGhi_chu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabGhi_chu.Name = "LabGhi_chu"
        Me.LabGhi_chu.Size = New System.Drawing.Size(65, 21)
        Me.LabGhi_chu.TabIndex = 14
        Me.LabGhi_chu.Tag = "English name"
        Me.LabGhi_chu.Text = "Ghi chú"
        '
        'LabMa_UT
        '
        Me.LabMa_UT.AutoSize = True
        Me.LabMa_UT.Location = New System.Drawing.Point(8, 89)
        Me.LabMa_UT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_UT.Name = "LabMa_UT"
        Me.LabMa_UT.Size = New System.Drawing.Size(97, 21)
        Me.LabMa_UT.TabIndex = 24
        Me.LabMa_UT.Tag = "Voucher"
        Me.LabMa_UT.Text = "Loại ưu tiên"
        '
        'TxtTen_UT
        '
        Me.TxtTen_UT.BackColor = System.Drawing.Color.White
        Me.TxtTen_UT.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_UT.Enabled = False
        Me.TxtTen_UT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_UT.Location = New System.Drawing.Point(394, 89)
        Me.TxtTen_UT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtTen_UT.Name = "TxtTen_UT"
        Me.TxtTen_UT.ReadOnly = True
        Me.TxtTen_UT.Size = New System.Drawing.Size(778, 20)
        Me.TxtTen_UT.TabIndex = 16
        Me.TxtTen_UT.TabStop = False
        '
        'TxtMa_UT
        '
        Me.TxtMa_UT._ActilookupPopup = False
        Me.TxtMa_UT.CyberActilookupPopup = True
        Me.TxtMa_UT.Dv_ListDetail = Nothing
        Me.TxtMa_UT.Dv_Master = Nothing
        Me.TxtMa_UT.FilterClient = ""
        Me.TxtMa_UT.FilterSQL = ""
        Me.TxtMa_UT.Location = New System.Drawing.Point(165, 82)
        Me.TxtMa_UT.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMa_UT.Name = "TxtMa_UT"
        Me.TxtMa_UT.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_UT.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_UT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_UT.Size = New System.Drawing.Size(224, 26)
        Me.TxtMa_UT.TabIndex = 2
        Me.TxtMa_UT.Table_Name = ""
        '
        'LabMa_xe
        '
        Me.LabMa_xe.AutoSize = True
        Me.LabMa_xe.Location = New System.Drawing.Point(8, 52)
        Me.LabMa_xe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_xe.Name = "LabMa_xe"
        Me.LabMa_xe.Size = New System.Drawing.Size(64, 21)
        Me.LabMa_xe.TabIndex = 29
        Me.LabMa_xe.Tag = "Voucher"
        Me.LabMa_xe.Text = "Biển số"
        '
        'TxtMa_xe
        '
        Me.TxtMa_xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_xe.Location = New System.Drawing.Point(165, 45)
        Me.TxtMa_xe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMa_xe.Name = "TxtMa_xe"
        Me.TxtMa_xe.Size = New System.Drawing.Size(222, 27)
        Me.TxtMa_xe.TabIndex = 1
        '
        'TxtNgay_HL
        '
        Me.TxtNgay_HL.Flags = 65536
        Me.TxtNgay_HL.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_HL.IsAllowResize = False
        Me.TxtNgay_HL.isEmpty = True
        Me.TxtNgay_HL.Location = New System.Drawing.Point(165, 8)
        Me.TxtNgay_HL.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_HL.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_HL.MaxLength = 10
        Me.TxtNgay_HL.Name = "TxtNgay_HL"
        Me.TxtNgay_HL.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_HL.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_HL.ShowDayBeforeMonth = False
        Me.TxtNgay_HL.Size = New System.Drawing.Size(222, 27)
        Me.TxtNgay_HL.TabIndex = 0
        Me.TxtNgay_HL.Text = "07/09/2011"
        Me.TxtNgay_HL.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'LabNgay_hl
        '
        Me.LabNgay_hl.AutoSize = True
        Me.LabNgay_hl.Location = New System.Drawing.Point(9, 15)
        Me.LabNgay_hl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNgay_hl.Name = "LabNgay_hl"
        Me.LabNgay_hl.Size = New System.Drawing.Size(110, 21)
        Me.LabNgay_hl.TabIndex = 32
        Me.LabNgay_hl.Tag = "Date"
        Me.LabNgay_hl.Text = "Ngày hiệu lực"
        '
        'DMXEUT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.ClientSize = New System.Drawing.Size(1046, 261)
        Me.Controls.Add(Me.TxtNgay_HL)
        Me.Controls.Add(Me.LabNgay_hl)
        Me.Controls.Add(Me.TxtMa_xe)
        Me.Controls.Add(Me.LabMa_xe)
        Me.Controls.Add(Me.LabMa_UT)
        Me.Controls.Add(Me.TxtTen_UT)
        Me.Controls.Add(Me.TxtMa_UT)
        Me.Controls.Add(Me.TxtGhi_chu)
        Me.Controls.Add(Me.LabGhi_chu)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(724, 127)
        Me.Name = "DMXEUT"
        Me.Controls.SetChildIndex(Me.LabGhi_chu, 0)
        Me.Controls.SetChildIndex(Me.TxtGhi_chu, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_UT, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_UT, 0)
        Me.Controls.SetChildIndex(Me.LabMa_UT, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_xe, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_xe, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_hl, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_HL, 0)
        CType(Me.TxtMa_UT.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtGhi_chu As System.Windows.Forms.TextBox
    Friend WithEvents LabGhi_chu As System.Windows.Forms.Label
    Friend WithEvents LabMa_UT As System.Windows.Forms.Label
    Friend WithEvents TxtTen_UT As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_UT As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_xe As System.Windows.Forms.Label
    Friend WithEvents TxtMa_xe As System.Windows.Forms.TextBox
    Friend WithEvents TxtNgay_HL As ClsTextBox.txtDate1
    Friend WithEvents LabNgay_hl As System.Windows.Forms.Label

End Class
