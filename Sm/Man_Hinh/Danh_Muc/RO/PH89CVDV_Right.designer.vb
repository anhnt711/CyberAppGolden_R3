<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PH89CVDV_Right
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
        Me.ChkIs_hen = New System.Windows.Forms.CheckBox()
        Me.Chkis_SCC = New System.Windows.Forms.CheckBox()
        Me.Chkis_SDS = New System.Windows.Forms.CheckBox()
        Me.Txtcomment = New System.Windows.Forms.TextBox()
        Me.Txtuser_name = New Cyber.SmLists.TxtLookup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ChkIs_CVDV = New System.Windows.Forms.CheckBox()
        Me.ChkIs_cs = New System.Windows.Forms.CheckBox()
        Me.ChkIs_admin = New System.Windows.Forms.CheckBox()
        Me.ChkIs_Xn_SCC = New System.Windows.Forms.CheckBox()
        Me.ChkIs_KTV = New System.Windows.Forms.CheckBox()
        Me.ChkIs_Controler = New System.Windows.Forms.CheckBox()
        Me.ChkIs_XN_SDS = New System.Windows.Forms.CheckBox()
        Me.ChkIs_To_truong = New System.Windows.Forms.CheckBox()
        CType(Me.Txtuser_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(547, 208)
        Me.ButtExit.TabIndex = 12
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(441, 208)
        Me.ButtOK.TabIndex = 11
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(292, 217)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(112, 221)
        Me.ChkActi.TabIndex = 11
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 203)
        Me.GroupBoxLine.Size = New System.Drawing.Size(660, 2)
        Me.GroupBoxLine.TabIndex = 12
        '
        'ChkIs_hen
        '
        Me.ChkIs_hen.AutoSize = True
        Me.ChkIs_hen.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_hen.Location = New System.Drawing.Point(405, 58)
        Me.ChkIs_hen.Name = "ChkIs_hen"
        Me.ChkIs_hen.Size = New System.Drawing.Size(45, 17)
        Me.ChkIs_hen.TabIndex = 6
        Me.ChkIs_hen.Tag = "Is Visible"
        Me.ChkIs_hen.Text = "Hẹn"
        Me.ChkIs_hen.UseVisualStyleBackColor = True
        '
        'Chkis_SCC
        '
        Me.Chkis_SCC.AutoSize = True
        Me.Chkis_SCC.ForeColor = System.Drawing.Color.Blue
        Me.Chkis_SCC.Location = New System.Drawing.Point(405, 81)
        Me.Chkis_SCC.Name = "Chkis_SCC"
        Me.Chkis_SCC.Size = New System.Drawing.Size(201, 17)
        Me.Chkis_SCC.TabIndex = 7
        Me.Chkis_SCC.Tag = "Is Visible"
        Me.Chkis_SCC.Text = "Hiện thị trên tiến độ sửa chữa chung"
        Me.Chkis_SCC.UseVisualStyleBackColor = True
        '
        'Chkis_SDS
        '
        Me.Chkis_SDS.AutoSize = True
        Me.Chkis_SDS.ForeColor = System.Drawing.Color.Blue
        Me.Chkis_SDS.Location = New System.Drawing.Point(405, 104)
        Me.Chkis_SDS.Name = "Chkis_SDS"
        Me.Chkis_SDS.Size = New System.Drawing.Size(168, 17)
        Me.Chkis_SDS.TabIndex = 8
        Me.Chkis_SDS.Tag = "Is Visible"
        Me.Chkis_SDS.Text = "Hiện thị trên tiến độ đồng sơn"
        Me.Chkis_SDS.UseVisualStyleBackColor = True
        '
        'Txtcomment
        '
        Me.Txtcomment.BackColor = System.Drawing.Color.White
        Me.Txtcomment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtcomment.Enabled = False
        Me.Txtcomment.ForeColor = System.Drawing.Color.Navy
        Me.Txtcomment.Location = New System.Drawing.Point(292, 23)
        Me.Txtcomment.Name = "Txtcomment"
        Me.Txtcomment.ReadOnly = True
        Me.Txtcomment.Size = New System.Drawing.Size(359, 14)
        Me.Txtcomment.TabIndex = 494
        Me.Txtcomment.TabStop = False
        '
        'Txtuser_name
        '
        Me.Txtuser_name._ActilookupPopup = False
        Me.Txtuser_name.CyberActilookupPopup = True
        Me.Txtuser_name.Dv_ListDetail = Nothing
        Me.Txtuser_name.Dv_Master = Nothing
        Me.Txtuser_name.FilterClient = ""
        Me.Txtuser_name.FilterSQL = ""
        Me.Txtuser_name.Location = New System.Drawing.Point(134, 17)
        Me.Txtuser_name.Name = "Txtuser_name"
        Me.Txtuser_name.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtuser_name.Properties.Appearance.Options.UseForeColor = True
        Me.Txtuser_name.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtuser_name.Size = New System.Drawing.Size(148, 20)
        Me.Txtuser_name.TabIndex = 0
        Me.Txtuser_name.Table_Name = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(14, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 492
        Me.Label10.Tag = "Code"
        Me.Label10.Text = "User name"
        '
        'ChkIs_CVDV
        '
        Me.ChkIs_CVDV.AutoSize = True
        Me.ChkIs_CVDV.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_CVDV.Location = New System.Drawing.Point(134, 94)
        Me.ChkIs_CVDV.Name = "ChkIs_CVDV"
        Me.ChkIs_CVDV.Size = New System.Drawing.Size(97, 17)
        Me.ChkIs_CVDV.TabIndex = 3
        Me.ChkIs_CVDV.Tag = "Is Visible"
        Me.ChkIs_CVDV.Text = "Cố vấn dịch vụ"
        Me.ChkIs_CVDV.UseVisualStyleBackColor = True
        '
        'ChkIs_cs
        '
        Me.ChkIs_cs.AutoSize = True
        Me.ChkIs_cs.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_cs.Location = New System.Drawing.Point(134, 71)
        Me.ChkIs_cs.Name = "ChkIs_cs"
        Me.ChkIs_cs.Size = New System.Drawing.Size(72, 17)
        Me.ChkIs_cs.TabIndex = 2
        Me.ChkIs_cs.Tag = "Is Visible"
        Me.ChkIs_cs.Text = "Chăm sóc"
        Me.ChkIs_cs.UseVisualStyleBackColor = True
        '
        'ChkIs_admin
        '
        Me.ChkIs_admin.AutoSize = True
        Me.ChkIs_admin.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_admin.Location = New System.Drawing.Point(134, 48)
        Me.ChkIs_admin.Name = "ChkIs_admin"
        Me.ChkIs_admin.Size = New System.Drawing.Size(55, 17)
        Me.ChkIs_admin.TabIndex = 1
        Me.ChkIs_admin.Tag = "Is Visible"
        Me.ChkIs_admin.Text = "Admin"
        Me.ChkIs_admin.UseVisualStyleBackColor = True
        '
        'ChkIs_Xn_SCC
        '
        Me.ChkIs_Xn_SCC.AutoSize = True
        Me.ChkIs_Xn_SCC.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_Xn_SCC.Location = New System.Drawing.Point(405, 127)
        Me.ChkIs_Xn_SCC.Name = "ChkIs_Xn_SCC"
        Me.ChkIs_Xn_SCC.Size = New System.Drawing.Size(93, 17)
        Me.ChkIs_Xn_SCC.TabIndex = 9
        Me.ChkIs_Xn_SCC.Tag = "Is Visible"
        Me.ChkIs_Xn_SCC.Text = "Xác nhận SCC"
        Me.ChkIs_Xn_SCC.UseVisualStyleBackColor = True
        '
        'ChkIs_KTV
        '
        Me.ChkIs_KTV.AutoSize = True
        Me.ChkIs_KTV.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_KTV.Location = New System.Drawing.Point(134, 166)
        Me.ChkIs_KTV.Name = "ChkIs_KTV"
        Me.ChkIs_KTV.Size = New System.Drawing.Size(90, 17)
        Me.ChkIs_KTV.TabIndex = 5
        Me.ChkIs_KTV.Tag = "Is Visible"
        Me.ChkIs_KTV.Text = "Kỹ thuật viên"
        Me.ChkIs_KTV.UseVisualStyleBackColor = True
        '
        'ChkIs_Controler
        '
        Me.ChkIs_Controler.AutoSize = True
        Me.ChkIs_Controler.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_Controler.Location = New System.Drawing.Point(134, 117)
        Me.ChkIs_Controler.Name = "ChkIs_Controler"
        Me.ChkIs_Controler.Size = New System.Drawing.Size(71, 17)
        Me.ChkIs_Controler.TabIndex = 4
        Me.ChkIs_Controler.Tag = "Is Visible"
        Me.ChkIs_Controler.Text = "Controler"
        Me.ChkIs_Controler.UseVisualStyleBackColor = True
        '
        'ChkIs_XN_SDS
        '
        Me.ChkIs_XN_SDS.AutoSize = True
        Me.ChkIs_XN_SDS.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_XN_SDS.Location = New System.Drawing.Point(405, 151)
        Me.ChkIs_XN_SDS.Name = "ChkIs_XN_SDS"
        Me.ChkIs_XN_SDS.Size = New System.Drawing.Size(92, 17)
        Me.ChkIs_XN_SDS.TabIndex = 10
        Me.ChkIs_XN_SDS.Tag = "Is Visible"
        Me.ChkIs_XN_SDS.Text = "Xác nhận SDS"
        Me.ChkIs_XN_SDS.UseVisualStyleBackColor = True
        '
        'ChkIs_To_truong
        '
        Me.ChkIs_To_truong.AutoSize = True
        Me.ChkIs_To_truong.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_To_truong.Location = New System.Drawing.Point(134, 141)
        Me.ChkIs_To_truong.Name = "ChkIs_To_truong"
        Me.ChkIs_To_truong.Size = New System.Drawing.Size(74, 17)
        Me.ChkIs_To_truong.TabIndex = 495
        Me.ChkIs_To_truong.Tag = "Is Visible"
        Me.ChkIs_To_truong.Text = "Tổ trưởng"
        Me.ChkIs_To_truong.UseVisualStyleBackColor = True
        '
        'PH89CVDV_Right
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(659, 250)
        Me.Controls.Add(Me.ChkIs_To_truong)
        Me.Controls.Add(Me.ChkIs_XN_SDS)
        Me.Controls.Add(Me.ChkIs_Xn_SCC)
        Me.Controls.Add(Me.ChkIs_KTV)
        Me.Controls.Add(Me.ChkIs_Controler)
        Me.Controls.Add(Me.ChkIs_CVDV)
        Me.Controls.Add(Me.ChkIs_cs)
        Me.Controls.Add(Me.ChkIs_admin)
        Me.Controls.Add(Me.Txtcomment)
        Me.Controls.Add(Me.Txtuser_name)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Chkis_SDS)
        Me.Controls.Add(Me.Chkis_SCC)
        Me.Controls.Add(Me.ChkIs_hen)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "PH89CVDV_Right"
        Me.Text = "Danh mục CVDV"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_hen, 0)
        Me.Controls.SetChildIndex(Me.Chkis_SCC, 0)
        Me.Controls.SetChildIndex(Me.Chkis_SDS, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Txtuser_name, 0)
        Me.Controls.SetChildIndex(Me.Txtcomment, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_admin, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_cs, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_CVDV, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Controler, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_KTV, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_Xn_SCC, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_XN_SDS, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_To_truong, 0)
        CType(Me.Txtuser_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChkIs_hen As System.Windows.Forms.CheckBox
    Friend WithEvents Chkis_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents Chkis_SDS As System.Windows.Forms.CheckBox
    Friend WithEvents Txtcomment As System.Windows.Forms.TextBox
    Friend WithEvents Txtuser_name As Cyber.SmLists.TxtLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ChkIs_CVDV As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_cs As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_admin As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_Xn_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_KTV As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_Controler As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_XN_SDS As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_To_truong As System.Windows.Forms.CheckBox

End Class
