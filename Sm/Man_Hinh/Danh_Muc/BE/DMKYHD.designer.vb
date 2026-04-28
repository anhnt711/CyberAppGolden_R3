<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMKYHD
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
        Me.LabMa_NV = New System.Windows.Forms.Label()
        Me.LabTen_TD1 = New System.Windows.Forms.Label()
        Me.TxtChuc_Vu = New System.Windows.Forms.TextBox()
        Me.Labten_TD12 = New System.Windows.Forms.Label()
        Me.ChkNgam_dinh = New System.Windows.Forms.CheckBox()
        Me.TxtMa_hs = New Cyber.SmLists.TxtLookup()
        Me.TxtMa_bp = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_hs = New System.Windows.Forms.TextBox()
        Me.TxtTen_bp = New System.Windows.Forms.TextBox()
        Me.TxtUyQuyen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_bp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(591, 196)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 8
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(436, 196)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 7
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(328, 194)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Dvcs.TabIndex = 6
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(147, 196)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 5
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 177)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(749, 12)
        Me.GroupBoxLine.TabIndex = 7
        '
        'LabMa_NV
        '
        Me.LabMa_NV.Location = New System.Drawing.Point(9, 10)
        Me.LabMa_NV.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_NV.Name = "LabMa_NV"
        Me.LabMa_NV.Size = New System.Drawing.Size(125, 21)
        Me.LabMa_NV.TabIndex = 9
        Me.LabMa_NV.Tag = "Code"
        Me.LabMa_NV.Text = "Mã nhân viên"
        '
        'LabTen_TD1
        '
        Me.LabTen_TD1.Location = New System.Drawing.Point(9, 39)
        Me.LabTen_TD1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTen_TD1.Name = "LabTen_TD1"
        Me.LabTen_TD1.Size = New System.Drawing.Size(125, 21)
        Me.LabTen_TD1.TabIndex = 8
        Me.LabTen_TD1.Tag = "Name"
        Me.LabTen_TD1.Text = "Phòng ban"
        '
        'TxtChuc_Vu
        '
        Me.TxtChuc_Vu.ForeColor = System.Drawing.Color.Navy
        Me.TxtChuc_Vu.Location = New System.Drawing.Point(147, 69)
        Me.TxtChuc_Vu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtChuc_Vu.Name = "TxtChuc_Vu"
        Me.TxtChuc_Vu.Size = New System.Drawing.Size(197, 24)
        Me.TxtChuc_Vu.TabIndex = 2
        '
        'Labten_TD12
        '
        Me.Labten_TD12.Location = New System.Drawing.Point(9, 71)
        Me.Labten_TD12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labten_TD12.Name = "Labten_TD12"
        Me.Labten_TD12.Size = New System.Drawing.Size(125, 21)
        Me.Labten_TD12.TabIndex = 10
        Me.Labten_TD12.Tag = "English name"
        Me.Labten_TD12.Text = "Chức vụ"
        '
        'ChkNgam_dinh
        '
        Me.ChkNgam_dinh.AutoSize = True
        Me.ChkNgam_dinh.Location = New System.Drawing.Point(147, 145)
        Me.ChkNgam_dinh.Name = "ChkNgam_dinh"
        Me.ChkNgam_dinh.Size = New System.Drawing.Size(96, 21)
        Me.ChkNgam_dinh.TabIndex = 4
        Me.ChkNgam_dinh.Text = "Ngầm định"
        Me.ChkNgam_dinh.UseVisualStyleBackColor = True
        '
        'TxtMa_hs
        '
        Me.TxtMa_hs._ActilookupPopup = False
        Me.TxtMa_hs.CyberActilookupPopup = True
        Me.TxtMa_hs.Dv_ListDetail = Nothing
        Me.TxtMa_hs.Dv_Master = Nothing
        Me.TxtMa_hs.FilterClient = ""
        Me.TxtMa_hs.FilterSQL = ""
        Me.TxtMa_hs.Location = New System.Drawing.Point(147, 7)
        Me.TxtMa_hs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_hs.Name = "TxtMa_hs"
        Me.TxtMa_hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_hs.Size = New System.Drawing.Size(199, 22)
        Me.TxtMa_hs.TabIndex = 0
        Me.TxtMa_hs.Table_Name = ""
        '
        'TxtMa_bp
        '
        Me.TxtMa_bp._ActilookupPopup = False
        Me.TxtMa_bp.CyberActilookupPopup = True
        Me.TxtMa_bp.Dv_ListDetail = Nothing
        Me.TxtMa_bp.Dv_Master = Nothing
        Me.TxtMa_bp.FilterClient = ""
        Me.TxtMa_bp.FilterSQL = ""
        Me.TxtMa_bp.Location = New System.Drawing.Point(147, 37)
        Me.TxtMa_bp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_bp.Name = "TxtMa_bp"
        Me.TxtMa_bp.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_bp.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_bp.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_bp.Size = New System.Drawing.Size(199, 22)
        Me.TxtMa_bp.TabIndex = 1
        Me.TxtMa_bp.Table_Name = ""
        '
        'TxtTen_hs
        '
        Me.TxtTen_hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_hs.Enabled = False
        Me.TxtTen_hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_hs.Location = New System.Drawing.Point(355, 9)
        Me.TxtTen_hs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_hs.Name = "TxtTen_hs"
        Me.TxtTen_hs.ReadOnly = True
        Me.TxtTen_hs.Size = New System.Drawing.Size(397, 17)
        Me.TxtTen_hs.TabIndex = 33
        Me.TxtTen_hs.TabStop = False
        '
        'TxtTen_bp
        '
        Me.TxtTen_bp.BackColor = System.Drawing.Color.White
        Me.TxtTen_bp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_bp.Enabled = False
        Me.TxtTen_bp.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_bp.Location = New System.Drawing.Point(355, 37)
        Me.TxtTen_bp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_bp.Name = "TxtTen_bp"
        Me.TxtTen_bp.ReadOnly = True
        Me.TxtTen_bp.Size = New System.Drawing.Size(397, 17)
        Me.TxtTen_bp.TabIndex = 34
        Me.TxtTen_bp.TabStop = False
        '
        'TxtUyQuyen
        '
        Me.TxtUyQuyen.ForeColor = System.Drawing.Color.Navy
        Me.TxtUyQuyen.Location = New System.Drawing.Point(147, 105)
        Me.TxtUyQuyen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtUyQuyen.Name = "TxtUyQuyen"
        Me.TxtUyQuyen.Size = New System.Drawing.Size(604, 24)
        Me.TxtUyQuyen.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(9, 107)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 21)
        Me.Label1.TabIndex = 36
        Me.Label1.Tag = "English name"
        Me.Label1.Text = "Giấy ủy quyền"
        '
        'DMKYHD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(755, 241)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtUyQuyen)
        Me.Controls.Add(Me.TxtTen_bp)
        Me.Controls.Add(Me.TxtTen_hs)
        Me.Controls.Add(Me.TxtMa_bp)
        Me.Controls.Add(Me.TxtMa_hs)
        Me.Controls.Add(Me.ChkNgam_dinh)
        Me.Controls.Add(Me.TxtChuc_Vu)
        Me.Controls.Add(Me.Labten_TD12)
        Me.Controls.Add(Me.LabTen_TD1)
        Me.Controls.Add(Me.LabMa_NV)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMKYHD"
        Me.Text = "Danh mục nguồn vốn"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_NV, 0)
        Me.Controls.SetChildIndex(Me.LabTen_TD1, 0)
        Me.Controls.SetChildIndex(Me.Labten_TD12, 0)
        Me.Controls.SetChildIndex(Me.TxtChuc_Vu, 0)
        Me.Controls.SetChildIndex(Me.ChkNgam_dinh, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_hs, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_bp, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_bp, 0)
        Me.Controls.SetChildIndex(Me.TxtUyQuyen, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_bp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_NV As System.Windows.Forms.Label
    Friend WithEvents LabTen_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtChuc_Vu As System.Windows.Forms.TextBox
    Friend WithEvents Labten_TD12 As System.Windows.Forms.Label
    Friend WithEvents ChkNgam_dinh As System.Windows.Forms.CheckBox
    Friend WithEvents TxtMa_hs As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtMa_bp As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_bp As System.Windows.Forms.TextBox
    Friend WithEvents TxtUyQuyen As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
