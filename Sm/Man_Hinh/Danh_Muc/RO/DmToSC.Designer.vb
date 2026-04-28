<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmToSC
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_to = New System.Windows.Forms.TextBox()
        Me.TxtTen_To2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ChkIs_TienDo = New System.Windows.Forms.CheckBox()
        Me.Chkis_SCC = New System.Windows.Forms.CheckBox()
        Me.Chkis_SDS = New System.Windows.Forms.CheckBox()
        Me.TxtMa_To = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_khoang = New System.Windows.Forms.TextBox()
        Me.Txtma_khoang = New Cyber.SmLists.TxtLookup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTen_cd = New System.Windows.Forms.TextBox()
        Me.Txtma_cd = New Cyber.SmLists.TxtLookup()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.ChkIs_ConFlict = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtTime_ConFlict = New ClsTextBox.txtTy_Gia()
        Me.ChkIs_khoang = New System.Windows.Forms.CheckBox()
        Me.Chkis_CD = New System.Windows.Forms.CheckBox()
        Me.CmbLoai_To = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_To.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtma_khoang.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Txtma_cd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(547, 315)
        Me.ButtExit.TabIndex = 13
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(441, 315)
        Me.ButtOK.TabIndex = 12
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(292, 324)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(112, 328)
        Me.ChkActi.TabIndex = 11
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 310)
        Me.GroupBoxLine.Size = New System.Drawing.Size(660, 2)
        Me.GroupBoxLine.TabIndex = 12
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(2, 15)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(100, 16)
        Me.LabMa_Nh1.TabIndex = 24
        Me.LabMa_Nh1.Tag = "Code"
        Me.LabMa_Nh1.Text = "Mã Tổ"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Name"
        Me.Label1.Text = "Tên tổ"
        '
        'TxtTen_to
        '
        Me.TxtTen_to.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_to.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_to.Location = New System.Drawing.Point(138, 38)
        Me.TxtTen_to.Name = "TxtTen_to"
        Me.TxtTen_to.Size = New System.Drawing.Size(518, 21)
        Me.TxtTen_to.TabIndex = 1
        '
        'TxtTen_To2
        '
        Me.TxtTen_To2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_To2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_To2.Location = New System.Drawing.Point(138, 61)
        Me.TxtTen_To2.Name = "TxtTen_To2"
        Me.TxtTen_To2.Size = New System.Drawing.Size(518, 21)
        Me.TxtTen_To2.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(2, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 16)
        Me.Label5.TabIndex = 369
        Me.Label5.Tag = "English name"
        Me.Label5.Text = "Tên tiếng anh"
        '
        'ChkIs_TienDo
        '
        Me.ChkIs_TienDo.AutoSize = True
        Me.ChkIs_TienDo.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_TienDo.Location = New System.Drawing.Point(138, 229)
        Me.ChkIs_TienDo.Name = "ChkIs_TienDo"
        Me.ChkIs_TienDo.Size = New System.Drawing.Size(121, 17)
        Me.ChkIs_TienDo.TabIndex = 9
        Me.ChkIs_TienDo.Tag = "Is Visible"
        Me.ChkIs_TienDo.Text = "Hiện thị trên tiến độ"
        Me.ChkIs_TienDo.UseVisualStyleBackColor = True
        '
        'Chkis_SCC
        '
        Me.Chkis_SCC.AutoSize = True
        Me.Chkis_SCC.ForeColor = System.Drawing.Color.Blue
        Me.Chkis_SCC.Location = New System.Drawing.Point(138, 252)
        Me.Chkis_SCC.Name = "Chkis_SCC"
        Me.Chkis_SCC.Size = New System.Drawing.Size(201, 17)
        Me.Chkis_SCC.TabIndex = 10
        Me.Chkis_SCC.Tag = "Is Visible"
        Me.Chkis_SCC.Text = "Hiện thị trên tiến độ sửa chữa chung"
        Me.Chkis_SCC.UseVisualStyleBackColor = True
        '
        'Chkis_SDS
        '
        Me.Chkis_SDS.AutoSize = True
        Me.Chkis_SDS.ForeColor = System.Drawing.Color.Blue
        Me.Chkis_SDS.Location = New System.Drawing.Point(138, 275)
        Me.Chkis_SDS.Name = "Chkis_SDS"
        Me.Chkis_SDS.Size = New System.Drawing.Size(168, 17)
        Me.Chkis_SDS.TabIndex = 11
        Me.Chkis_SDS.Tag = "Is Visible"
        Me.Chkis_SDS.Text = "Hiện thị trên tiến độ đồng sơn"
        Me.Chkis_SDS.UseVisualStyleBackColor = True
        '
        'TxtMa_To
        '
        Me.TxtMa_To._ActilookupPopup = False
        Me.TxtMa_To.CyberActilookupPopup = True
        Me.TxtMa_To.Dv_ListDetail = Nothing
        Me.TxtMa_To.Dv_Master = Nothing
        Me.TxtMa_To.FilterClient = ""
        Me.TxtMa_To.FilterSQL = ""
        Me.TxtMa_To.Location = New System.Drawing.Point(138, 12)
        Me.TxtMa_To.Name = "TxtMa_To"
        Me.TxtMa_To.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_To.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_To.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_To.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_To.TabIndex = 0
        Me.TxtMa_To.Table_Name = ""
        '
        'TxtTen_khoang
        '
        Me.TxtTen_khoang.BackColor = System.Drawing.Color.White
        Me.TxtTen_khoang.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_khoang.Enabled = False
        Me.TxtTen_khoang.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_khoang.Location = New System.Drawing.Point(296, 92)
        Me.TxtTen_khoang.Name = "TxtTen_khoang"
        Me.TxtTen_khoang.ReadOnly = True
        Me.TxtTen_khoang.Size = New System.Drawing.Size(359, 14)
        Me.TxtTen_khoang.TabIndex = 494
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
        Me.Txtma_khoang.Location = New System.Drawing.Point(138, 86)
        Me.Txtma_khoang.Name = "Txtma_khoang"
        Me.Txtma_khoang.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_khoang.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_khoang.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_khoang.Size = New System.Drawing.Size(148, 20)
        Me.Txtma_khoang.TabIndex = 3
        Me.Txtma_khoang.Table_Name = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(2, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 16)
        Me.Label10.TabIndex = 492
        Me.Label10.Tag = "Code"
        Me.Label10.Text = "Khoang ngầm định"
        '
        'TxtTen_cd
        '
        Me.TxtTen_cd.BackColor = System.Drawing.Color.White
        Me.TxtTen_cd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_cd.Enabled = False
        Me.TxtTen_cd.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_cd.Location = New System.Drawing.Point(296, 138)
        Me.TxtTen_cd.Name = "TxtTen_cd"
        Me.TxtTen_cd.ReadOnly = True
        Me.TxtTen_cd.Size = New System.Drawing.Size(359, 14)
        Me.TxtTen_cd.TabIndex = 497
        Me.TxtTen_cd.TabStop = False
        '
        'Txtma_cd
        '
        Me.Txtma_cd._ActilookupPopup = False
        Me.Txtma_cd.CyberActilookupPopup = True
        Me.Txtma_cd.Dv_ListDetail = Nothing
        Me.Txtma_cd.Dv_Master = Nothing
        Me.Txtma_cd.FilterClient = ""
        Me.Txtma_cd.FilterSQL = ""
        Me.Txtma_cd.Location = New System.Drawing.Point(138, 132)
        Me.Txtma_cd.Name = "Txtma_cd"
        Me.Txtma_cd.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_cd.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_cd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_cd.Size = New System.Drawing.Size(148, 20)
        Me.Txtma_cd.TabIndex = 5
        Me.Txtma_cd.Table_Name = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(0, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(132, 16)
        Me.Label11.TabIndex = 495
        Me.Label11.Tag = "Code"
        Me.Label11.Text = "Công đoạn ngầm định"
        '
        'ChkIs_ConFlict
        '
        Me.ChkIs_ConFlict.AutoSize = True
        Me.ChkIs_ConFlict.ForeColor = System.Drawing.Color.Red
        Me.ChkIs_ConFlict.Location = New System.Drawing.Point(138, 206)
        Me.ChkIs_ConFlict.Name = "ChkIs_ConFlict"
        Me.ChkIs_ConFlict.Size = New System.Drawing.Size(176, 17)
        Me.ChkIs_ConFlict.TabIndex = 7
        Me.ChkIs_ConFlict.Tag = "Is ConFlict"
        Me.ChkIs_ConFlict.Text = "Không cho phép trùng thời gian"
        Me.ChkIs_ConFlict.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(400, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 16)
        Me.Label9.TabIndex = 505
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
        Me.TxtTime_ConFlict.Location = New System.Drawing.Point(539, 201)
        Me.TxtTime_ConFlict.MaxWholeDigits = 5
        Me.TxtTime_ConFlict.Name = "TxtTime_ConFlict"
        Me.TxtTime_ConFlict.RangeMax = 1.7976931348623157E+308R
        Me.TxtTime_ConFlict.RangeMin = -1.7976931348623157E+308R
        Me.TxtTime_ConFlict.Size = New System.Drawing.Size(105, 21)
        Me.TxtTime_ConFlict.TabIndex = 8
        Me.TxtTime_ConFlict.Text = "1"
        Me.TxtTime_ConFlict.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ChkIs_khoang
        '
        Me.ChkIs_khoang.AutoSize = True
        Me.ChkIs_khoang.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_khoang.Location = New System.Drawing.Point(138, 112)
        Me.ChkIs_khoang.Name = "ChkIs_khoang"
        Me.ChkIs_khoang.Size = New System.Drawing.Size(125, 17)
        Me.ChkIs_khoang.TabIndex = 4
        Me.ChkIs_khoang.Tag = "Is Visible"
        Me.ChkIs_khoang.Text = "Luôn gắn với khoang"
        Me.ChkIs_khoang.UseVisualStyleBackColor = True
        '
        'Chkis_CD
        '
        Me.Chkis_CD.AutoSize = True
        Me.Chkis_CD.ForeColor = System.Drawing.Color.Blue
        Me.Chkis_CD.Location = New System.Drawing.Point(138, 158)
        Me.Chkis_CD.Name = "Chkis_CD"
        Me.Chkis_CD.Size = New System.Drawing.Size(140, 17)
        Me.Chkis_CD.TabIndex = 6
        Me.Chkis_CD.Tag = "Is Visible"
        Me.Chkis_CD.Text = "Luôn gắn với công đoạn"
        Me.Chkis_CD.UseVisualStyleBackColor = True
        '
        'CmbLoai_To
        '
        Me.CmbLoai_To.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbLoai_To.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbLoai_To.ForeColor = System.Drawing.Color.Navy
        Me.CmbLoai_To.FormattingEnabled = True
        Me.CmbLoai_To.Location = New System.Drawing.Point(138, 178)
        Me.CmbLoai_To.Name = "CmbLoai_To"
        Me.CmbLoai_To.Size = New System.Drawing.Size(263, 21)
        Me.CmbLoai_To.TabIndex = 506
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 16)
        Me.Label2.TabIndex = 507
        Me.Label2.Tag = "Type"
        Me.Label2.Text = "Loại tổ"
        '
        'DmToSC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(659, 357)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbLoai_To)
        Me.Controls.Add(Me.Chkis_CD)
        Me.Controls.Add(Me.ChkIs_khoang)
        Me.Controls.Add(Me.ChkIs_ConFlict)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtTime_ConFlict)
        Me.Controls.Add(Me.TxtTen_cd)
        Me.Controls.Add(Me.Txtma_cd)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtTen_khoang)
        Me.Controls.Add(Me.Txtma_khoang)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtMa_To)
        Me.Controls.Add(Me.Chkis_SDS)
        Me.Controls.Add(Me.Chkis_SCC)
        Me.Controls.Add(Me.ChkIs_TienDo)
        Me.Controls.Add(Me.TxtTen_To2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_to)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DmToSC"
        Me.Text = "Danh mục tổ SC"
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_to, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_To2, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_TienDo, 0)
        Me.Controls.SetChildIndex(Me.Chkis_SCC, 0)
        Me.Controls.SetChildIndex(Me.Chkis_SDS, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_To, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.Txtma_khoang, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_khoang, 0)
        Me.Controls.SetChildIndex(Me.Label11, 0)
        Me.Controls.SetChildIndex(Me.Txtma_cd, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_cd, 0)
        Me.Controls.SetChildIndex(Me.TxtTime_ConFlict, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_ConFlict, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_khoang, 0)
        Me.Controls.SetChildIndex(Me.Chkis_CD, 0)
        Me.Controls.SetChildIndex(Me.CmbLoai_To, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.TxtMa_To.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtma_khoang.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Txtma_cd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_to As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_To2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ChkIs_TienDo As System.Windows.Forms.CheckBox
    Friend WithEvents Chkis_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents Chkis_SDS As System.Windows.Forms.CheckBox
    Friend WithEvents TxtMa_To As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_khoang As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_khoang As Cyber.SmLists.TxtLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_cd As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_cd As Cyber.SmLists.TxtLookup
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ChkIs_ConFlict As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtTime_ConFlict As ClsTextBox.txtTy_Gia
    Friend WithEvents ChkIs_khoang As System.Windows.Forms.CheckBox
    Friend WithEvents Chkis_CD As System.Windows.Forms.CheckBox
    Friend WithEvents CmbLoai_To As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
