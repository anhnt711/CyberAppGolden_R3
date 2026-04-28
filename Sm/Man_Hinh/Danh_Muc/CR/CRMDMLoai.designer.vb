<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRMDMLoai
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
        Me.LabMa_LHTT = New System.Windows.Forms.Label()
        Me.TxtCrmMa_Loai = New System.Windows.Forms.TextBox()
        Me.TxtCrmTen_Loai = New System.Windows.Forms.TextBox()
        Me.LabTen_LHTT = New System.Windows.Forms.Label()
        Me.TxtCrmTen_Loai2 = New System.Windows.Forms.TextBox()
        Me.LabTen_LHTT2 = New System.Windows.Forms.Label()
        Me.CmbMa_Phan_He = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbCrmLoai = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(525, 134)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(423, 134)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(317, 140)
        Me.TxtMa_Dvcs.TabIndex = 8
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(101, 144)
        Me.ChkActi.TabIndex = 7
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 124)
        Me.GroupBoxLine.Size = New System.Drawing.Size(623, 9)
        Me.GroupBoxLine.TabIndex = 6
        '
        'LabMa_LHTT
        '
        Me.LabMa_LHTT.Location = New System.Drawing.Point(11, 53)
        Me.LabMa_LHTT.Name = "LabMa_LHTT"
        Me.LabMa_LHTT.Size = New System.Drawing.Size(77, 16)
        Me.LabMa_LHTT.TabIndex = 10
        Me.LabMa_LHTT.Tag = "Code"
        Me.LabMa_LHTT.Text = "Mã loại"
        '
        'TxtCrmMa_Loai
        '
        Me.TxtCrmMa_Loai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCrmMa_Loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtCrmMa_Loai.Location = New System.Drawing.Point(102, 49)
        Me.TxtCrmMa_Loai.Name = "TxtCrmMa_Loai"
        Me.TxtCrmMa_Loai.Size = New System.Drawing.Size(149, 21)
        Me.TxtCrmMa_Loai.TabIndex = 1
        '
        'TxtCrmTen_Loai
        '
        Me.TxtCrmTen_Loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtCrmTen_Loai.Location = New System.Drawing.Point(102, 71)
        Me.TxtCrmTen_Loai.Name = "TxtCrmTen_Loai"
        Me.TxtCrmTen_Loai.Size = New System.Drawing.Size(506, 21)
        Me.TxtCrmTen_Loai.TabIndex = 2
        '
        'LabTen_LHTT
        '
        Me.LabTen_LHTT.Location = New System.Drawing.Point(11, 75)
        Me.LabTen_LHTT.Name = "LabTen_LHTT"
        Me.LabTen_LHTT.Size = New System.Drawing.Size(77, 16)
        Me.LabTen_LHTT.TabIndex = 12
        Me.LabTen_LHTT.Tag = "Name"
        Me.LabTen_LHTT.Text = "Tên loại"
        '
        'TxtCrmTen_Loai2
        '
        Me.TxtCrmTen_Loai2.ForeColor = System.Drawing.Color.Navy
        Me.TxtCrmTen_Loai2.Location = New System.Drawing.Point(102, 93)
        Me.TxtCrmTen_Loai2.Name = "TxtCrmTen_Loai2"
        Me.TxtCrmTen_Loai2.Size = New System.Drawing.Size(506, 21)
        Me.TxtCrmTen_Loai2.TabIndex = 3
        '
        'LabTen_LHTT2
        '
        Me.LabTen_LHTT2.Location = New System.Drawing.Point(11, 97)
        Me.LabTen_LHTT2.Name = "LabTen_LHTT2"
        Me.LabTen_LHTT2.Size = New System.Drawing.Size(77, 16)
        Me.LabTen_LHTT2.TabIndex = 14
        Me.LabTen_LHTT2.Tag = "English name"
        Me.LabTen_LHTT2.Text = "Tên tiếng anh"
        '
        'CmbMa_Phan_He
        '
        Me.CmbMa_Phan_He.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMa_Phan_He.ForeColor = System.Drawing.Color.Navy
        Me.CmbMa_Phan_He.FormattingEnabled = True
        Me.CmbMa_Phan_He.Location = New System.Drawing.Point(102, 2)
        Me.CmbMa_Phan_He.Name = "CmbMa_Phan_He"
        Me.CmbMa_Phan_He.Size = New System.Drawing.Size(352, 21)
        Me.CmbMa_Phan_He.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 1971
        Me.Label1.Tag = "Type"
        Me.Label1.Text = "Phân hệ"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 16)
        Me.Label2.TabIndex = 1973
        Me.Label2.Tag = "Type"
        Me.Label2.Text = "Loại chăm sóc"
        '
        'CmbCrmLoai
        '
        Me.CmbCrmLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbCrmLoai.ForeColor = System.Drawing.Color.Navy
        Me.CmbCrmLoai.FormattingEnabled = True
        Me.CmbCrmLoai.Location = New System.Drawing.Point(102, 25)
        Me.CmbCrmLoai.Name = "CmbCrmLoai"
        Me.CmbCrmLoai.Size = New System.Drawing.Size(149, 21)
        Me.CmbCrmLoai.TabIndex = 1972
        '
        'CRMDMLoai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(627, 167)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbCrmLoai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbMa_Phan_He)
        Me.Controls.Add(Me.TxtCrmTen_Loai2)
        Me.Controls.Add(Me.LabTen_LHTT2)
        Me.Controls.Add(Me.TxtCrmTen_Loai)
        Me.Controls.Add(Me.LabTen_LHTT)
        Me.Controls.Add(Me.TxtCrmMa_Loai)
        Me.Controls.Add(Me.LabMa_LHTT)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "CRMDMLoai"
        Me.Text = "Danh mục loại hình chăm sóc"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_LHTT, 0)
        Me.Controls.SetChildIndex(Me.TxtCrmMa_Loai, 0)
        Me.Controls.SetChildIndex(Me.LabTen_LHTT, 0)
        Me.Controls.SetChildIndex(Me.TxtCrmTen_Loai, 0)
        Me.Controls.SetChildIndex(Me.LabTen_LHTT2, 0)
        Me.Controls.SetChildIndex(Me.TxtCrmTen_Loai2, 0)
        Me.Controls.SetChildIndex(Me.CmbMa_Phan_He, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CmbCrmLoai, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_LHTT As System.Windows.Forms.Label
    Friend WithEvents TxtCrmMa_Loai As System.Windows.Forms.TextBox
    Friend WithEvents TxtCrmTen_Loai As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_LHTT As System.Windows.Forms.Label
    Friend WithEvents TxtCrmTen_Loai2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_LHTT2 As System.Windows.Forms.Label
    Friend WithEvents CmbMa_Phan_He As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbCrmLoai As System.Windows.Forms.ComboBox

End Class
