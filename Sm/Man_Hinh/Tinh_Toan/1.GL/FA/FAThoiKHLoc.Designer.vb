<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAThoiKHLoc
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
        Me.Txtten_ts = New System.Windows.Forms.TextBox()
        Me.TxtMa_ts = New Cyber.SmLists.TxtLookup()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_Nhts1 = New System.Windows.Forms.TextBox()
        Me.TxtNh_ts1 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nhts3 = New System.Windows.Forms.TextBox()
        Me.TxtNh_ts3 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nhts2 = New System.Windows.Forms.TextBox()
        Me.TxtNh_ts2 = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_ts.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_ts1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_ts3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_ts2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label4.Tag = "Asset"
        Me.Label4.Text = "Mã TSCĐ"
        '
        'Txtten_ts
        '
        Me.Txtten_ts.BackColor = System.Drawing.Color.White
        Me.Txtten_ts.Enabled = False
        Me.Txtten_ts.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_ts.Location = New System.Drawing.Point(264, 4)
        Me.Txtten_ts.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtten_ts.Name = "Txtten_ts"
        Me.Txtten_ts.ReadOnly = True
        Me.Txtten_ts.Size = New System.Drawing.Size(495, 22)
        Me.Txtten_ts.TabIndex = 501
        Me.Txtten_ts.TabStop = False
        '
        'TxtMa_ts
        '
        Me.TxtMa_ts._ActilookupPopup = False
        Me.TxtMa_ts.CyberActilookupPopup = True
        Me.TxtMa_ts.Dv_ListDetail = Nothing
        Me.TxtMa_ts.Dv_Master = Nothing
        Me.TxtMa_ts.FilterClient = ""
        Me.TxtMa_ts.FilterSQL = ""
        Me.TxtMa_ts.Location = New System.Drawing.Point(112, 5)
        Me.TxtMa_ts.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_ts.Name = "TxtMa_ts"
        Me.TxtMa_ts.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_ts.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_ts.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_ts.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_ts.TabIndex = 2
        Me.TxtMa_ts.Table_Name = ""
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
        'TxtTen_Nhts1
        '
        Me.TxtTen_Nhts1.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nhts1.Enabled = False
        Me.TxtTen_Nhts1.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nhts1.Location = New System.Drawing.Point(264, 30)
        Me.TxtTen_Nhts1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Nhts1.Name = "TxtTen_Nhts1"
        Me.TxtTen_Nhts1.ReadOnly = True
        Me.TxtTen_Nhts1.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_Nhts1.TabIndex = 520
        Me.TxtTen_Nhts1.TabStop = False
        '
        'TxtNh_ts1
        '
        Me.TxtNh_ts1._ActilookupPopup = False
        Me.TxtNh_ts1.CyberActilookupPopup = True
        Me.TxtNh_ts1.Dv_ListDetail = Nothing
        Me.TxtNh_ts1.Dv_Master = Nothing
        Me.TxtNh_ts1.FilterClient = ""
        Me.TxtNh_ts1.FilterSQL = ""
        Me.TxtNh_ts1.Location = New System.Drawing.Point(112, 31)
        Me.TxtNh_ts1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_ts1.Name = "TxtNh_ts1"
        Me.TxtNh_ts1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_ts1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_ts1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_ts1.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_ts1.TabIndex = 3
        Me.TxtNh_ts1.Table_Name = ""
        '
        'TxtTen_Nhts3
        '
        Me.TxtTen_Nhts3.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nhts3.Enabled = False
        Me.TxtTen_Nhts3.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nhts3.Location = New System.Drawing.Point(264, 81)
        Me.TxtTen_Nhts3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Nhts3.Name = "TxtTen_Nhts3"
        Me.TxtTen_Nhts3.ReadOnly = True
        Me.TxtTen_Nhts3.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_Nhts3.TabIndex = 519
        Me.TxtTen_Nhts3.TabStop = False
        '
        'TxtNh_ts3
        '
        Me.TxtNh_ts3._ActilookupPopup = False
        Me.TxtNh_ts3.CyberActilookupPopup = True
        Me.TxtNh_ts3.Dv_ListDetail = Nothing
        Me.TxtNh_ts3.Dv_Master = Nothing
        Me.TxtNh_ts3.FilterClient = ""
        Me.TxtNh_ts3.FilterSQL = ""
        Me.TxtNh_ts3.Location = New System.Drawing.Point(112, 82)
        Me.TxtNh_ts3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_ts3.Name = "TxtNh_ts3"
        Me.TxtNh_ts3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_ts3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_ts3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_ts3.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_ts3.TabIndex = 5
        Me.TxtNh_ts3.Table_Name = ""
        '
        'TxtTen_Nhts2
        '
        Me.TxtTen_Nhts2.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nhts2.Enabled = False
        Me.TxtTen_Nhts2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Nhts2.Location = New System.Drawing.Point(264, 55)
        Me.TxtTen_Nhts2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Nhts2.Name = "TxtTen_Nhts2"
        Me.TxtTen_Nhts2.ReadOnly = True
        Me.TxtTen_Nhts2.Size = New System.Drawing.Size(495, 22)
        Me.TxtTen_Nhts2.TabIndex = 518
        Me.TxtTen_Nhts2.TabStop = False
        '
        'TxtNh_ts2
        '
        Me.TxtNh_ts2._ActilookupPopup = False
        Me.TxtNh_ts2.CyberActilookupPopup = True
        Me.TxtNh_ts2.Dv_ListDetail = Nothing
        Me.TxtNh_ts2.Dv_Master = Nothing
        Me.TxtNh_ts2.FilterClient = ""
        Me.TxtNh_ts2.FilterSQL = ""
        Me.TxtNh_ts2.Location = New System.Drawing.Point(112, 57)
        Me.TxtNh_ts2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_ts2.Name = "TxtNh_ts2"
        Me.TxtNh_ts2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_ts2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_ts2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_ts2.Size = New System.Drawing.Size(147, 22)
        Me.TxtNh_ts2.TabIndex = 4
        Me.TxtNh_ts2.Table_Name = ""
        '
        'FAThoiKHLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(765, 186)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_Nhts1)
        Me.Controls.Add(Me.TxtNh_ts1)
        Me.Controls.Add(Me.TxtTen_Nhts3)
        Me.Controls.Add(Me.TxtNh_ts3)
        Me.Controls.Add(Me.TxtTen_Nhts2)
        Me.Controls.Add(Me.TxtNh_ts2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtten_ts)
        Me.Controls.Add(Me.TxtMa_ts)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "FAThoiKHLoc"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_ts, 0)
        Me.Controls.SetChildIndex(Me.Txtten_ts, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_ts2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nhts2, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_ts3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nhts3, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_ts1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nhts1, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        CType(Me.TxtMa_ts.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_ts1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_ts3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_ts2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtten_ts As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_ts As Cyber.SmLists.TxtLookup
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nhts1 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_ts1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nhts3 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_ts3 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nhts2 As System.Windows.Forms.TextBox
    Friend WithEvents TxtNh_ts2 As Cyber.SmLists.TxtLookup

End Class
