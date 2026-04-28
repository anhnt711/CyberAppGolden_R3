<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOA_Loc
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtTen_Hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        Me.CmbMa_GD = New System.Windows.Forms.ComboBox()
        Me.LabTT_CS = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_BP = New System.Windows.Forms.TextBox()
        Me.TxtMa_BP = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 84)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(570, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(370, 94)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 7
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(472, 94)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 1850
        Me.Label6.Tag = "Staff"
        Me.Label6.Text = "Nhân viên"
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Hs.Enabled = False
        Me.TxtTen_Hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Hs.Location = New System.Drawing.Point(206, 52)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.ReadOnly = True
        Me.TxtTen_Hs.Size = New System.Drawing.Size(364, 13)
        Me.TxtTen_Hs.TabIndex = 1849
        Me.TxtTen_Hs.TabStop = False
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs._ActilookupPopup = False
        Me.TxtMa_Hs.CyberActilookupPopup = True
        Me.TxtMa_Hs.Dv_ListDetail = Nothing
        Me.TxtMa_Hs.Dv_Master = Nothing
        Me.TxtMa_Hs.FilterClient = ""
        Me.TxtMa_Hs.FilterSQL = ""
        Me.TxtMa_Hs.Location = New System.Drawing.Point(92, 48)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_Hs.TabIndex = 2
        Me.TxtMa_Hs.Table_Name = ""
        '
        'CmbMa_GD
        '
        Me.CmbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_GD.FormattingEnabled = True
        Me.CmbMa_GD.Location = New System.Drawing.Point(92, 3)
        Me.CmbMa_GD.Name = "CmbMa_GD"
        Me.CmbMa_GD.Size = New System.Drawing.Size(322, 21)
        Me.CmbMa_GD.TabIndex = 0
        '
        'LabTT_CS
        '
        Me.LabTT_CS.AutoSize = True
        Me.LabTT_CS.Location = New System.Drawing.Point(5, 6)
        Me.LabTT_CS.Name = "LabTT_CS"
        Me.LabTT_CS.Size = New System.Drawing.Size(66, 13)
        Me.LabTT_CS.TabIndex = 1854
        Me.LabTT_CS.Tag = "Type"
        Me.LabTT_CS.Text = "Loại đề xuất"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1857
        Me.Label1.Tag = "Staff"
        Me.Label1.Text = "Phòng ban"
        '
        'TxtTen_BP
        '
        Me.TxtTen_BP.BackColor = System.Drawing.Color.White
        Me.TxtTen_BP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_BP.Enabled = False
        Me.TxtTen_BP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_BP.Location = New System.Drawing.Point(206, 30)
        Me.TxtTen_BP.Name = "TxtTen_BP"
        Me.TxtTen_BP.ReadOnly = True
        Me.TxtTen_BP.Size = New System.Drawing.Size(364, 13)
        Me.TxtTen_BP.TabIndex = 1856
        Me.TxtTen_BP.TabStop = False
        '
        'TxtMa_BP
        '
        Me.TxtMa_BP._ActilookupPopup = False
        Me.TxtMa_BP.CyberActilookupPopup = True
        Me.TxtMa_BP.Dv_ListDetail = Nothing
        Me.TxtMa_BP.Dv_Master = Nothing
        Me.TxtMa_BP.FilterClient = ""
        Me.TxtMa_BP.FilterSQL = ""
        Me.TxtMa_BP.Location = New System.Drawing.Point(92, 26)
        Me.TxtMa_BP.Name = "TxtMa_BP"
        Me.TxtMa_BP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_BP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_BP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_BP.Size = New System.Drawing.Size(110, 20)
        Me.TxtMa_BP.TabIndex = 1
        Me.TxtMa_BP.Table_Name = ""
        '
        'LOA_Loc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(574, 148)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_BP)
        Me.Controls.Add(Me.TxtMa_BP)
        Me.Controls.Add(Me.CmbMa_GD)
        Me.Controls.Add(Me.LabTT_CS)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LOA_Loc"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.LabTT_CS, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_BP, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_BP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup
    Friend WithEvents CmbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents LabTT_CS As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_BP As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_BP As Cyber.SmLists.TxtLookup

End Class
