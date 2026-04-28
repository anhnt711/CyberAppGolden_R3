<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BeGiaCost
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
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.CbbM_Thang2 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_KX = New System.Windows.Forms.TextBox()
        Me.TxtMa_KX = New Cyber.SmLists.TxtLookup()
        Me.LabMa_vt = New System.Windows.Forms.Label()
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 132)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(760, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(493, 144)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtOK.TabIndex = 4
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(629, 144)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtExit.TabIndex = 5
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(112, 73)
        Me.CbbM_Nam.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Nam.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 76)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 505
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(112, 9)
        Me.CbbM_Thang1.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Thang1.TabIndex = 0
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(0, 12)
        Me.LabM_month1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(65, 17)
        Me.LabM_month1.TabIndex = 503
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Từ tháng"
        '
        'CbbM_Thang2
        '
        Me.CbbM_Thang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang2.FormattingEnabled = True
        Me.CbbM_Thang2.Location = New System.Drawing.Point(112, 39)
        Me.CbbM_Thang2.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbM_Thang2.Name = "CbbM_Thang2"
        Me.CbbM_Thang2.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Thang2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 43)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 17)
        Me.Label1.TabIndex = 507
        Me.Label1.Tag = "Month to"
        Me.Label1.Text = "Đến tháng"
        '
        'TxtTen_KX
        '
        Me.TxtTen_KX.BackColor = System.Drawing.Color.White
        Me.TxtTen_KX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KX.Enabled = False
        Me.TxtTen_KX.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KX.Location = New System.Drawing.Point(265, 110)
        Me.TxtTen_KX.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_KX.Name = "TxtTen_KX"
        Me.TxtTen_KX.ReadOnly = True
        Me.TxtTen_KX.Size = New System.Drawing.Size(489, 15)
        Me.TxtTen_KX.TabIndex = 510
        Me.TxtTen_KX.TabStop = False
        '
        'TxtMa_KX
        '
        Me.TxtMa_KX._ActilookupPopup = False
        Me.TxtMa_KX.CyberActilookupPopup = True
        Me.TxtMa_KX.Dv_ListDetail = Nothing
        Me.TxtMa_KX.Dv_Master = Nothing
        Me.TxtMa_KX.FilterClient = ""
        Me.TxtMa_KX.FilterSQL = ""
        Me.TxtMa_KX.Location = New System.Drawing.Point(112, 106)
        Me.TxtMa_KX.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_KX.Name = "TxtMa_KX"
        Me.TxtMa_KX.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KX.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KX.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KX.Size = New System.Drawing.Size(147, 22)
        Me.TxtMa_KX.TabIndex = 3
        Me.TxtMa_KX.Table_Name = ""
        '
        'LabMa_vt
        '
        Me.LabMa_vt.Location = New System.Drawing.Point(1, 110)
        Me.LabMa_vt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_vt.Name = "LabMa_vt"
        Me.LabMa_vt.Size = New System.Drawing.Size(103, 21)
        Me.LabMa_vt.TabIndex = 509
        Me.LabMa_vt.Tag = "Type car"
        Me.LabMa_vt.Text = "Mã kiểu xe"
        '
        'BeGiaCost
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(765, 210)
        Me.Controls.Add(Me.TxtTen_KX)
        Me.Controls.Add(Me.TxtMa_KX)
        Me.Controls.Add(Me.LabMa_vt)
        Me.Controls.Add(Me.CbbM_Thang2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.LabM_month1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "BeGiaCost"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang2, 0)
        Me.Controls.SetChildIndex(Me.LabMa_vt, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KX, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KX, 0)
        CType(Me.TxtMa_KX.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_KX As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KX As Cyber.SmLists.TxtLookup
    Friend WithEvents LabMa_vt As System.Windows.Forms.Label

End Class
