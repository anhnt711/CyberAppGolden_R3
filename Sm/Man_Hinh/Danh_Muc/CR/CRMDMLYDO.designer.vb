<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CRMDMLYDO
    Inherits Cyber.From.FrmList

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabLy_do = New System.Windows.Forms.Label()
        Me.TxtLy_do = New System.Windows.Forms.TextBox()
        Me.TxtTen_ly_do = New System.Windows.Forms.TextBox()
        Me.LabTen_ly_do = New System.Windows.Forms.Label()
        Me.TxtTen_ly_do2 = New System.Windows.Forms.TextBox()
        Me.LabTen_ly_do2 = New System.Windows.Forms.Label()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Loai = New System.Windows.Forms.TextBox()
        Me.TxtMa_Loai = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_KQ = New System.Windows.Forms.TextBox()
        Me.TxtMa_KQ = New Cyber.SmLists.TxtLookup()
        Me.TxtLoai = New System.Windows.Forms.TextBox()
        Me.ChkNgam_dinh = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_Loai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_KQ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 188)
        Me.ButtExit.TabIndex = 8
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 188)
        Me.ButtOK.TabIndex = 7
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 194)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 198)
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 178)
        '
        'LabLy_do
        '
        Me.LabLy_do.Location = New System.Drawing.Point(5, 72)
        Me.LabLy_do.Name = "LabLy_do"
        Me.LabLy_do.Size = New System.Drawing.Size(100, 15)
        Me.LabLy_do.TabIndex = 10
        Me.LabLy_do.Tag = "Free 2"
        Me.LabLy_do.Text = "Lý do"
        '
        'TxtLy_do
        '
        Me.TxtLy_do.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLy_do.ForeColor = System.Drawing.Color.Navy
        Me.TxtLy_do.Location = New System.Drawing.Point(111, 71)
        Me.TxtLy_do.Name = "TxtLy_do"
        Me.TxtLy_do.Size = New System.Drawing.Size(149, 21)
        Me.TxtLy_do.TabIndex = 3
        '
        'TxtTen_ly_do
        '
        Me.TxtTen_ly_do.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ly_do.Location = New System.Drawing.Point(111, 95)
        Me.TxtTen_ly_do.Name = "TxtTen_ly_do"
        Me.TxtTen_ly_do.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_ly_do.TabIndex = 4
        '
        'LabTen_ly_do
        '
        Me.LabTen_ly_do.Location = New System.Drawing.Point(5, 96)
        Me.LabTen_ly_do.Name = "LabTen_ly_do"
        Me.LabTen_ly_do.Size = New System.Drawing.Size(100, 15)
        Me.LabTen_ly_do.TabIndex = 12
        Me.LabTen_ly_do.Tag = "Name"
        Me.LabTen_ly_do.Text = "Tên lý do"
        '
        'TxtTen_ly_do2
        '
        Me.TxtTen_ly_do2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_ly_do2.Location = New System.Drawing.Point(111, 119)
        Me.TxtTen_ly_do2.Name = "TxtTen_ly_do2"
        Me.TxtTen_ly_do2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_ly_do2.TabIndex = 5
        '
        'LabTen_ly_do2
        '
        Me.LabTen_ly_do2.Location = New System.Drawing.Point(5, 120)
        Me.LabTen_ly_do2.Name = "LabTen_ly_do2"
        Me.LabTen_ly_do2.Size = New System.Drawing.Size(100, 15)
        Me.LabTen_ly_do2.TabIndex = 14
        Me.LabTen_ly_do2.Tag = "English name"
        Me.LabTen_ly_do2.Text = "Tên lý do 2"
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(5, 27)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(100, 15)
        Me.LabMa_Nh1.TabIndex = 24
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Loại"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 15)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Group 2"
        Me.Label1.Text = "Mã loại"
        '
        'TxtTen_Loai
        '
        Me.TxtTen_Loai.BackColor = System.Drawing.Color.White
        Me.TxtTen_Loai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Loai.Enabled = False
        Me.TxtTen_Loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Loai.Location = New System.Drawing.Point(263, 5)
        Me.TxtTen_Loai.Name = "TxtTen_Loai"
        Me.TxtTen_Loai.ReadOnly = True
        Me.TxtTen_Loai.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_Loai.TabIndex = 26
        Me.TxtTen_Loai.TabStop = False
        '
        'TxtMa_Loai
        '
        Me.TxtMa_Loai._ActilookupPopup = False
        Me.TxtMa_Loai.CyberActilookupPopup = True
        Me.TxtMa_Loai.Dv_ListDetail = Nothing
        Me.TxtMa_Loai.Dv_Master = Nothing
        Me.TxtMa_Loai.FilterClient = ""
        Me.TxtMa_Loai.FilterSQL = ""
        Me.TxtMa_Loai.Location = New System.Drawing.Point(111, 2)
        Me.TxtMa_Loai.Name = "TxtMa_Loai"
        Me.TxtMa_Loai.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Loai.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Loai.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Loai.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_Loai.TabIndex = 0
        Me.TxtMa_Loai.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 15)
        Me.Label2.TabIndex = 30
        Me.Label2.Tag = "Group 3"
        Me.Label2.Text = "Mã kết quả"
        '
        'TxtTen_KQ
        '
        Me.TxtTen_KQ.BackColor = System.Drawing.Color.White
        Me.TxtTen_KQ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_KQ.Enabled = False
        Me.TxtTen_KQ.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KQ.Location = New System.Drawing.Point(263, 51)
        Me.TxtTen_KQ.Name = "TxtTen_KQ"
        Me.TxtTen_KQ.ReadOnly = True
        Me.TxtTen_KQ.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_KQ.TabIndex = 29
        Me.TxtTen_KQ.TabStop = False
        '
        'TxtMa_KQ
        '
        Me.TxtMa_KQ._ActilookupPopup = False
        Me.TxtMa_KQ.CyberActilookupPopup = True
        Me.TxtMa_KQ.Dv_ListDetail = Nothing
        Me.TxtMa_KQ.Dv_Master = Nothing
        Me.TxtMa_KQ.FilterClient = ""
        Me.TxtMa_KQ.FilterSQL = ""
        Me.TxtMa_KQ.Location = New System.Drawing.Point(111, 48)
        Me.TxtMa_KQ.Name = "TxtMa_KQ"
        Me.TxtMa_KQ.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KQ.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_KQ.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_KQ.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_KQ.TabIndex = 2
        Me.TxtMa_KQ.Table_Name = ""
        '
        'TxtLoai
        '
        Me.TxtLoai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLoai.Enabled = False
        Me.TxtLoai.ForeColor = System.Drawing.Color.Navy
        Me.TxtLoai.Location = New System.Drawing.Point(111, 24)
        Me.TxtLoai.Name = "TxtLoai"
        Me.TxtLoai.Size = New System.Drawing.Size(149, 21)
        Me.TxtLoai.TabIndex = 1
        '
        'ChkNgam_dinh
        '
        Me.ChkNgam_dinh.AutoSize = True
        Me.ChkNgam_dinh.Location = New System.Drawing.Point(111, 147)
        Me.ChkNgam_dinh.Name = "ChkNgam_dinh"
        Me.ChkNgam_dinh.Size = New System.Drawing.Size(76, 17)
        Me.ChkNgam_dinh.TabIndex = 6
        Me.ChkNgam_dinh.Text = "Ngầm định"
        Me.ChkNgam_dinh.UseVisualStyleBackColor = True
        '
        'CRMDMLYDOLH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 221)
        Me.Controls.Add(Me.ChkNgam_dinh)
        Me.Controls.Add(Me.TxtLoai)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_KQ)
        Me.Controls.Add(Me.TxtMa_KQ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Loai)
        Me.Controls.Add(Me.TxtMa_Loai)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_ly_do2)
        Me.Controls.Add(Me.LabTen_ly_do2)
        Me.Controls.Add(Me.TxtTen_ly_do)
        Me.Controls.Add(Me.LabTen_ly_do)
        Me.Controls.Add(Me.TxtLy_do)
        Me.Controls.Add(Me.LabLy_do)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "CRMDMLYDOLH"
        Me.Text = "Danh mục lý do kết quả"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabLy_do, 0)
        Me.Controls.SetChildIndex(Me.TxtLy_do, 0)
        Me.Controls.SetChildIndex(Me.LabTen_ly_do, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ly_do, 0)
        Me.Controls.SetChildIndex(Me.LabTen_ly_do2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_ly_do2, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Loai, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Loai, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KQ, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KQ, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtLoai, 0)
        Me.Controls.SetChildIndex(Me.ChkNgam_dinh, 0)
        CType(Me.TxtMa_Loai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_KQ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabLy_do As System.Windows.Forms.Label
    Friend WithEvents TxtLy_do As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_ly_do As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_ly_do As System.Windows.Forms.Label
    Friend WithEvents TxtTen_ly_do2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_ly_do2 As System.Windows.Forms.Label
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Loai As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Loai As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_KQ As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_KQ As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtLoai As System.Windows.Forms.TextBox
    Friend WithEvents ChkNgam_dinh As System.Windows.Forms.CheckBox

End Class
