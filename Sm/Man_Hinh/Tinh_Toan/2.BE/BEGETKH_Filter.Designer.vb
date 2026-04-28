<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BEGETKH_Filter
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
        Me.chkBB = New System.Windows.Forms.CheckBox()
        Me.ChkNV = New System.Windows.Forms.CheckBox()
        Me.ChkTH = New System.Windows.Forms.CheckBox()
        Me.ChkCT = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Txtten_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 144)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(887, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(620, 156)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtOK.TabIndex = 8
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(756, 156)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtExit.TabIndex = 9
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(112, 70)
        Me.CbbM_Nam.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(176, 24)
        Me.CbbM_Nam.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 75)
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
        Me.CbbM_Thang1.Location = New System.Drawing.Point(112, 7)
        Me.CbbM_Thang1.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(176, 24)
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
        Me.CbbM_Thang2.Location = New System.Drawing.Point(112, 38)
        Me.CbbM_Thang2.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbM_Thang2.Name = "CbbM_Thang2"
        Me.CbbM_Thang2.Size = New System.Drawing.Size(176, 24)
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
        'chkBB
        '
        Me.chkBB.AutoSize = True
        Me.chkBB.Location = New System.Drawing.Point(381, 81)
        Me.chkBB.Margin = New System.Windows.Forms.Padding(4)
        Me.chkBB.Name = "chkBB"
        Me.chkBB.Size = New System.Drawing.Size(245, 21)
        Me.chkBB.TabIndex = 7
        Me.chkBB.Tag = "Sale planning for company"
        Me.chkBB.Text = "Nhập kế hoạch báo bán cho hãng"
        Me.chkBB.UseVisualStyleBackColor = True
        Me.chkBB.Visible = False
        '
        'ChkNV
        '
        Me.ChkNV.AutoSize = True
        Me.ChkNV.Location = New System.Drawing.Point(381, 58)
        Me.ChkNV.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkNV.Name = "ChkNV"
        Me.ChkNV.Size = New System.Drawing.Size(239, 21)
        Me.ChkNV.TabIndex = 6
        Me.ChkNV.Tag = "Detail by staff"
        Me.ChkNV.Text = "Lập KH bán hàng theo nhân viên"
        Me.ChkNV.UseVisualStyleBackColor = True
        Me.ChkNV.Visible = False
        '
        'ChkTH
        '
        Me.ChkTH.AutoSize = True
        Me.ChkTH.Location = New System.Drawing.Point(381, 32)
        Me.ChkTH.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkTH.Name = "ChkTH"
        Me.ChkTH.Size = New System.Drawing.Size(213, 21)
        Me.ChkTH.TabIndex = 5
        Me.ChkTH.Tag = "Detail by month"
        Me.ChkTH.Text = "Lập KH bán hàng theo tháng"
        Me.ChkTH.UseVisualStyleBackColor = True
        Me.ChkTH.Visible = False
        '
        'ChkCT
        '
        Me.ChkCT.AutoSize = True
        Me.ChkCT.Location = New System.Drawing.Point(381, 7)
        Me.ChkCT.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkCT.Name = "ChkCT"
        Me.ChkCT.Size = New System.Drawing.Size(202, 21)
        Me.ChkCT.TabIndex = 4
        Me.ChkCT.Tag = "Detail by type car"
        Me.ChkCT.Text = "Lập KH chi tiết theo kiểu xe"
        Me.ChkCT.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 107)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 514
        Me.Label4.Tag = "Type car"
        Me.Label4.Text = "Kiểu xe"
        '
        'Txtten_Kx
        '
        Me.Txtten_Kx.BackColor = System.Drawing.Color.White
        Me.Txtten_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Kx.Enabled = False
        Me.Txtten_Kx.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Kx.Location = New System.Drawing.Point(381, 106)
        Me.Txtten_Kx.Margin = New System.Windows.Forms.Padding(4)
        Me.Txtten_Kx.Name = "Txtten_Kx"
        Me.Txtten_Kx.ReadOnly = True
        Me.Txtten_Kx.Size = New System.Drawing.Size(493, 15)
        Me.Txtten_Kx.TabIndex = 513
        Me.Txtten_Kx.TabStop = False
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(112, 102)
        Me.TxtMa_Kx.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(177, 22)
        Me.TxtMa_Kx.TabIndex = 3
        Me.TxtMa_Kx.Table_Name = ""
        '
        'BEGETKH_Filter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(892, 223)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txtten_Kx)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.chkBB)
        Me.Controls.Add(Me.ChkNV)
        Me.Controls.Add(Me.ChkTH)
        Me.Controls.Add(Me.ChkCT)
        Me.Controls.Add(Me.CbbM_Thang2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.LabM_month1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "BEGETKH_Filter"
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang2, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.ChkCT, 0)
        Me.Controls.SetChildIndex(Me.ChkTH, 0)
        Me.Controls.SetChildIndex(Me.ChkNV, 0)
        Me.Controls.SetChildIndex(Me.chkBB, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkBB As System.Windows.Forms.CheckBox
    Friend WithEvents ChkNV As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTH As System.Windows.Forms.CheckBox
    Friend WithEvents ChkCT As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Txtten_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup

End Class
