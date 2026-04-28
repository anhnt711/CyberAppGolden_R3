<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmKTVSC
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
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.ChkIs_TienDo = New System.Windows.Forms.CheckBox()
        Me.Chkis_SCC = New System.Windows.Forms.CheckBox()
        Me.Chkis_SDS = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_hs = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_to = New System.Windows.Forms.TextBox()
        Me.TxtMa_to = New Cyber.SmLists.TxtLookup()
        Me.ChkIs_ConFlict = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTime_ConFlict = New ClsTextBox.txtTy_Gia()
        Me.ChkIs_GJ = New System.Windows.Forms.CheckBox()
        Me.ChkIs_EM = New System.Windows.Forms.CheckBox()
        Me.TxtTen_khoang = New System.Windows.Forms.TextBox()
        Me.Txtma_khoang = New Cyber.SmLists.TxtLookup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ChkChinh_phu = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_to.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtma_khoang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(547, 230)
        Me.ButtExit.TabIndex = 13
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(441, 230)
        Me.ButtOK.TabIndex = 12
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(292, 239)
        Me.TxtMa_Dvcs.TabIndex = 6
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(108, 243)
        Me.ChkActi.TabIndex = 11
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 225)
        Me.GroupBoxLine.Size = New System.Drawing.Size(648, 2)
        Me.GroupBoxLine.TabIndex = 4
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(2, 38)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(100, 16)
        Me.LabMa_Nh1.TabIndex = 24
        Me.LabMa_Nh1.Tag = "Code"
        Me.LabMa_Nh1.Text = "Mã Tổ"
        '
        'ChkIs_TienDo
        '
        Me.ChkIs_TienDo.AutoSize = True
        Me.ChkIs_TienDo.Location = New System.Drawing.Point(108, 133)
        Me.ChkIs_TienDo.Name = "ChkIs_TienDo"
        Me.ChkIs_TienDo.Size = New System.Drawing.Size(121, 17)
        Me.ChkIs_TienDo.TabIndex = 5
        Me.ChkIs_TienDo.Tag = "Is Visible"
        Me.ChkIs_TienDo.Text = "Hiện thị trên tiến độ"
        Me.ChkIs_TienDo.UseVisualStyleBackColor = True
        '
        'Chkis_SCC
        '
        Me.Chkis_SCC.AutoSize = True
        Me.Chkis_SCC.ForeColor = System.Drawing.Color.Blue
        Me.Chkis_SCC.Location = New System.Drawing.Point(108, 156)
        Me.Chkis_SCC.Name = "Chkis_SCC"
        Me.Chkis_SCC.Size = New System.Drawing.Size(201, 17)
        Me.Chkis_SCC.TabIndex = 6
        Me.Chkis_SCC.Tag = "Is Visible"
        Me.Chkis_SCC.Text = "Hiện thị trên tiến độ sửa chữa chung"
        Me.Chkis_SCC.UseVisualStyleBackColor = True
        '
        'Chkis_SDS
        '
        Me.Chkis_SDS.AutoSize = True
        Me.Chkis_SDS.ForeColor = System.Drawing.Color.Blue
        Me.Chkis_SDS.Location = New System.Drawing.Point(108, 179)
        Me.Chkis_SDS.Name = "Chkis_SDS"
        Me.Chkis_SDS.Size = New System.Drawing.Size(168, 17)
        Me.Chkis_SDS.TabIndex = 7
        Me.Chkis_SDS.Tag = "Is Visible"
        Me.Chkis_SDS.Text = "Hiện thị trên tiến độ đồng sơn"
        Me.Chkis_SDS.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 480
        Me.Label3.Tag = "Code"
        Me.Label3.Text = "Mã kỹ thuật viên"
        '
        'TxtTen_hs
        '
        Me.TxtTen_hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_hs.Enabled = False
        Me.TxtTen_hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_hs.Location = New System.Drawing.Point(266, 18)
        Me.TxtTen_hs.Name = "TxtTen_hs"
        Me.TxtTen_hs.ReadOnly = True
        Me.TxtTen_hs.Size = New System.Drawing.Size(359, 14)
        Me.TxtTen_hs.TabIndex = 482
        Me.TxtTen_hs.TabStop = False
        '
        'TxtMa_hs
        '
        Me.TxtMa_hs._ActilookupPopup = False
        Me.TxtMa_hs.CyberActilookupPopup = True
        Me.TxtMa_hs.Dv_ListDetail = Nothing
        Me.TxtMa_hs.Dv_Master = Nothing
        Me.TxtMa_hs.FilterClient = ""
        Me.TxtMa_hs.FilterSQL = ""
        Me.TxtMa_hs.Location = New System.Drawing.Point(108, 12)
        Me.TxtMa_hs.Name = "TxtMa_hs"
        Me.TxtMa_hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_hs.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_hs.TabIndex = 0
        Me.TxtMa_hs.Table_Name = ""
        '
        'TxtTen_to
        '
        Me.TxtTen_to.BackColor = System.Drawing.Color.White
        Me.TxtTen_to.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_to.Enabled = False
        Me.TxtTen_to.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_to.Location = New System.Drawing.Point(266, 41)
        Me.TxtTen_to.Name = "TxtTen_to"
        Me.TxtTen_to.ReadOnly = True
        Me.TxtTen_to.Size = New System.Drawing.Size(359, 14)
        Me.TxtTen_to.TabIndex = 488
        Me.TxtTen_to.TabStop = False
        '
        'TxtMa_to
        '
        Me.TxtMa_to._ActilookupPopup = False
        Me.TxtMa_to.CyberActilookupPopup = True
        Me.TxtMa_to.Dv_ListDetail = Nothing
        Me.TxtMa_to.Dv_Master = Nothing
        Me.TxtMa_to.FilterClient = ""
        Me.TxtMa_to.FilterSQL = ""
        Me.TxtMa_to.Location = New System.Drawing.Point(108, 35)
        Me.TxtMa_to.Name = "TxtMa_to"
        Me.TxtMa_to.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_to.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_to.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_to.Size = New System.Drawing.Size(148, 20)
        Me.TxtMa_to.TabIndex = 1
        Me.TxtMa_to.Table_Name = ""
        '
        'ChkIs_ConFlict
        '
        Me.ChkIs_ConFlict.AutoSize = True
        Me.ChkIs_ConFlict.ForeColor = System.Drawing.Color.Red
        Me.ChkIs_ConFlict.Location = New System.Drawing.Point(108, 110)
        Me.ChkIs_ConFlict.Name = "ChkIs_ConFlict"
        Me.ChkIs_ConFlict.Size = New System.Drawing.Size(176, 17)
        Me.ChkIs_ConFlict.TabIndex = 4
        Me.ChkIs_ConFlict.Tag = "Is ConFlict"
        Me.ChkIs_ConFlict.Text = "Không cho phép trùng thời gian"
        Me.ChkIs_ConFlict.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(382, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 16)
        Me.Label9.TabIndex = 490
        Me.Label9.Tag = "Time ConFlict"
        Me.Label9.Text = "Thời gian cho phép trùng "
        '
        'TxtTime_ConFlict
        '
        Me.TxtTime_ConFlict.AllowNegative = True
        Me.TxtTime_ConFlict.Flags = 7680
        Me.TxtTime_ConFlict.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTime_ConFlict.ForeColor = System.Drawing.Color.Red
        Me.TxtTime_ConFlict.InputMask = "### ###"
        Me.TxtTime_ConFlict.Location = New System.Drawing.Point(521, 106)
        Me.TxtTime_ConFlict.MaxWholeDigits = 5
        Me.TxtTime_ConFlict.Name = "TxtTime_ConFlict"
        Me.TxtTime_ConFlict.RangeMax = 1.7976931348623157E+308R
        Me.TxtTime_ConFlict.RangeMin = -1.7976931348623157E+308R
        Me.TxtTime_ConFlict.Size = New System.Drawing.Size(105, 21)
        Me.TxtTime_ConFlict.TabIndex = 8
        Me.TxtTime_ConFlict.Text = "1"
        Me.TxtTime_ConFlict.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChkIs_GJ
        '
        Me.ChkIs_GJ.AutoSize = True
        Me.ChkIs_GJ.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_GJ.Location = New System.Drawing.Point(382, 179)
        Me.ChkIs_GJ.Name = "ChkIs_GJ"
        Me.ChkIs_GJ.Size = New System.Drawing.Size(97, 17)
        Me.ChkIs_GJ.TabIndex = 10
        Me.ChkIs_GJ.Tag = "Is Visible"
        Me.ChkIs_GJ.Text = "KTV khoang GJ"
        Me.ChkIs_GJ.UseVisualStyleBackColor = True
        '
        'ChkIs_EM
        '
        Me.ChkIs_EM.AutoSize = True
        Me.ChkIs_EM.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_EM.Location = New System.Drawing.Point(382, 156)
        Me.ChkIs_EM.Name = "ChkIs_EM"
        Me.ChkIs_EM.Size = New System.Drawing.Size(99, 17)
        Me.ChkIs_EM.TabIndex = 9
        Me.ChkIs_EM.Tag = "Is Visible"
        Me.ChkIs_EM.Text = "KTV khoang EM"
        Me.ChkIs_EM.UseVisualStyleBackColor = True
        '
        'TxtTen_khoang
        '
        Me.TxtTen_khoang.BackColor = System.Drawing.Color.White
        Me.TxtTen_khoang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_khoang.Enabled = False
        Me.TxtTen_khoang.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_khoang.Location = New System.Drawing.Point(266, 67)
        Me.TxtTen_khoang.Name = "TxtTen_khoang"
        Me.TxtTen_khoang.ReadOnly = True
        Me.TxtTen_khoang.Size = New System.Drawing.Size(359, 14)
        Me.TxtTen_khoang.TabIndex = 497
        Me.TxtTen_khoang.TabStop = False
        '
        'Txtma_khoang
        '
        Me.Txtma_khoang._ActilookupPopup = False
        Me.Txtma_khoang.CyberActilookupPopup = True
        Me.Txtma_khoang.Dv_ListDetail = Nothing
        Me.Txtma_khoang.Dv_Master = Nothing
        Me.Txtma_khoang.FilterClient = ""
        Me.Txtma_khoang.FilterSQL = ""
        Me.Txtma_khoang.Location = New System.Drawing.Point(108, 61)
        Me.Txtma_khoang.Name = "Txtma_khoang"
        Me.Txtma_khoang.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_khoang.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_khoang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_khoang.Size = New System.Drawing.Size(148, 20)
        Me.Txtma_khoang.TabIndex = 2
        Me.Txtma_khoang.Table_Name = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(2, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 496
        Me.Label10.Tag = "Code"
        Me.Label10.Text = "Khoang ngầm định"
        '
        'ChkChinh_phu
        '
        Me.ChkChinh_phu.AutoSize = True
        Me.ChkChinh_phu.ForeColor = System.Drawing.Color.Blue
        Me.ChkChinh_phu.Location = New System.Drawing.Point(108, 87)
        Me.ChkChinh_phu.Name = "ChkChinh_phu"
        Me.ChkChinh_phu.Size = New System.Drawing.Size(74, 17)
        Me.ChkChinh_phu.TabIndex = 3
        Me.ChkChinh_phu.Tag = "KTV Chính"
        Me.ChkChinh_phu.Text = "KTV Chính"
        Me.ChkChinh_phu.UseVisualStyleBackColor = True
        '
        'DmKTVSC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(659, 272)
        Me.Controls.Add(Me.ChkChinh_phu)
        Me.Controls.Add(Me.TxtTen_khoang)
        Me.Controls.Add(Me.Txtma_khoang)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ChkIs_GJ)
        Me.Controls.Add(Me.ChkIs_EM)
        Me.Controls.Add(Me.ChkIs_ConFlict)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTime_ConFlict)
        Me.Controls.Add(Me.TxtTen_to)
        Me.Controls.Add(Me.TxtMa_to)
        Me.Controls.Add(Me.TxtTen_hs)
        Me.Controls.Add(Me.TxtMa_hs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Chkis_SDS)
        Me.Controls.Add(Me.Chkis_SCC)
        Me.Controls.Add(Me.ChkIs_TienDo)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DmKTVSC"
        Me.Text = "Danh mục tổ SC"
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_TienDo, 0)
        Me.Controls.SetChildIndex(Me.Chkis_SCC, 0)
        Me.Controls.SetChildIndex(Me.Chkis_SDS, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_hs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_to, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_to, 0)
        Me.Controls.SetChildIndex(Me.TxtTime_ConFlict, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_ConFlict, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_EM, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_GJ, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Txtma_khoang, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_khoang, 0)
        Me.Controls.SetChildIndex(Me.ChkChinh_phu, 0)
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_to.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtma_khoang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents ChkIs_TienDo As System.Windows.Forms.CheckBox
    Friend WithEvents Chkis_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents Chkis_SDS As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_hs As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_to As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_to As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkIs_ConFlict As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTime_ConFlict As ClsTextBox.txtTy_Gia
    Friend WithEvents ChkIs_GJ As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_EM As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTen_khoang As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_khoang As Cyber.SmLists.TxtLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ChkChinh_phu As System.Windows.Forms.CheckBox

End Class
