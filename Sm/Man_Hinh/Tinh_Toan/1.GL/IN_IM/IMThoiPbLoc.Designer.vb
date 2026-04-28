<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMThoiPbLoc
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtten_Cc = New System.Windows.Forms.TextBox()
        Me.TxtMa_Cc = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_NhCc1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Cc1 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NhCc3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Cc3 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_NhCc2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_Cc2 = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Cc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Cc1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Cc3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_Cc2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 107)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(760, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(493, 119)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtOK.TabIndex = 6
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(629, 119)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtExit.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 502
        Me.Label4.Tag = "Tool"
        Me.Label4.Text = "Mã công cụ"
        '
        'Txtten_Cc
        '
        Me.Txtten_Cc.BackColor = System.Drawing.Color.White
        Me.Txtten_Cc.Enabled = False
        Me.Txtten_Cc.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Cc.Location = New System.Drawing.Point(264, 4)
        Me.Txtten_Cc.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtten_Cc.Name = "Txtten_Cc"
        Me.Txtten_Cc.ReadOnly = True
        Me.Txtten_Cc.Size = New System.Drawing.Size(495, 22)
        Me.Txtten_Cc.TabIndex = 501
        Me.Txtten_Cc.TabStop = False
        '
        'TxtMa_Cc
        '
        Me.TxtMa_Cc._ActilookupPopup = False
        Me.TxtMa_Cc.CyberActilookupPopup = True
        Me.TxtMa_Cc.Dv_ListDetail = Nothing
        Me.TxtMa_Cc.Dv_Master = Nothing
        Me.TxtMa_Cc.FilterClient = ""
        Me.TxtMa_Cc.FilterSQL = ""
        Me.TxtMa_Cc.Location = New System.Drawing.Point(112, 5)
        Me.TxtMa_Cc.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Cc.Name = "TxtMa_Cc"
        Me.TxtMa_Cc.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cc.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cc.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_Cc.TabIndex = 2
        Me.TxtMa_Cc.Table_Name = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(1, 89)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 18)
        Me.Label8.TabIndex = 523
        Me.Label8.Tag = "Group 3"
        Me.Label8.Text = "Nhóm 3"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(1, 37)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 18)
        Me.Label6.TabIndex = 522
        Me.Label6.Tag = "Group 1"
        Me.Label6.Text = "Nhóm 1"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(1, 63)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 18)
        Me.Label5.TabIndex = 521
        Me.Label5.Tag = "Group 2"
        Me.Label5.Text = "Nhóm 2"
        '
        'TxtTen_NhCc1
        '
        Me.TxtTen_NhCc1.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhCc1.Enabled = False
        Me.TxtTen_NhCc1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhCc1.Location = New System.Drawing.Point(264, 30)
        Me.TxtTen_NhCc1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_NhCc1.Name = "TxtTen_NhCc1"
        Me.TxtTen_NhCc1.ReadOnly = True
        Me.TxtTen_NhCc1.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_NhCc1.TabIndex = 520
        Me.TxtTen_NhCc1.TabStop = False
        '
        'TxtNh_Cc1
        '
        Me.TxtNh_Cc1._ActilookupPopup = False
        Me.TxtNh_Cc1.CyberActilookupPopup = True
        Me.TxtNh_Cc1.Dv_ListDetail = Nothing
        Me.TxtNh_Cc1.Dv_Master = Nothing
        Me.TxtNh_Cc1.FilterClient = ""
        Me.TxtNh_Cc1.FilterSQL = ""
        Me.TxtNh_Cc1.Location = New System.Drawing.Point(112, 31)
        Me.TxtNh_Cc1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_Cc1.Name = "TxtNh_Cc1"
        Me.TxtNh_Cc1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Cc1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Cc1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Cc1.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_Cc1.TabIndex = 3
        Me.TxtNh_Cc1.Table_Name = ""
        '
        'TxtTen_NhCc3
        '
        Me.TxtTen_NhCc3.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhCc3.Enabled = False
        Me.TxtTen_NhCc3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhCc3.Location = New System.Drawing.Point(264, 81)
        Me.TxtTen_NhCc3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_NhCc3.Name = "TxtTen_NhCc3"
        Me.TxtTen_NhCc3.ReadOnly = True
        Me.TxtTen_NhCc3.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_NhCc3.TabIndex = 519
        Me.TxtTen_NhCc3.TabStop = False
        '
        'TxtNh_Cc3
        '
        Me.TxtNh_Cc3._ActilookupPopup = False
        Me.TxtNh_Cc3.CyberActilookupPopup = True
        Me.TxtNh_Cc3.Dv_ListDetail = Nothing
        Me.TxtNh_Cc3.Dv_Master = Nothing
        Me.TxtNh_Cc3.FilterClient = ""
        Me.TxtNh_Cc3.FilterSQL = ""
        Me.TxtNh_Cc3.Location = New System.Drawing.Point(112, 82)
        Me.TxtNh_Cc3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_Cc3.Name = "TxtNh_Cc3"
        Me.TxtNh_Cc3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Cc3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Cc3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Cc3.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_Cc3.TabIndex = 5
        Me.TxtNh_Cc3.Table_Name = ""
        '
        'TxtTen_NhCc2
        '
        Me.TxtTen_NhCc2.BackColor = System.Drawing.Color.White
        Me.TxtTen_NhCc2.Enabled = False
        Me.TxtTen_NhCc2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_NhCc2.Location = New System.Drawing.Point(264, 55)
        Me.TxtTen_NhCc2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_NhCc2.Name = "TxtTen_NhCc2"
        Me.TxtTen_NhCc2.ReadOnly = True
        Me.TxtTen_NhCc2.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_NhCc2.TabIndex = 518
        Me.TxtTen_NhCc2.TabStop = False
        '
        'TxtNh_Cc2
        '
        Me.TxtNh_Cc2._ActilookupPopup = False
        Me.TxtNh_Cc2.CyberActilookupPopup = True
        Me.TxtNh_Cc2.Dv_ListDetail = Nothing
        Me.TxtNh_Cc2.Dv_Master = Nothing
        Me.TxtNh_Cc2.FilterClient = ""
        Me.TxtNh_Cc2.FilterSQL = ""
        Me.TxtNh_Cc2.Location = New System.Drawing.Point(112, 57)
        Me.TxtNh_Cc2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_Cc2.Name = "TxtNh_Cc2"
        Me.TxtNh_Cc2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_Cc2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_Cc2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_Cc2.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_Cc2.TabIndex = 4
        Me.TxtNh_Cc2.Table_Name = ""
        '
        'IMThoiPbLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(765, 186)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_NhCc1)
        Me.Controls.Add(Me.TxtNh_Cc1)
        Me.Controls.Add(Me.TxtTen_NhCc3)
        Me.Controls.Add(Me.TxtNh_Cc3)
        Me.Controls.Add(Me.TxtTen_NhCc2)
        Me.Controls.Add(Me.TxtNh_Cc2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtten_Cc)
        Me.Controls.Add(Me.TxtMa_Cc)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "IMThoiPbLoc"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cc, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Cc, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Cc2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhCc2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Cc3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhCc3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_Cc1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_NhCc1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        CType(Me.TxtMa_Cc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Cc1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Cc3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_Cc2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtten_Cc As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Cc As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_NhCc1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Cc1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NhCc3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Cc3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_NhCc2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_Cc2 As Cyber.SmLists.TxtLookup

End Class
