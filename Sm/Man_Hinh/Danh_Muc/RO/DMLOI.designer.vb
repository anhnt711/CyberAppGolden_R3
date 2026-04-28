<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMLOI
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
        Me.LabMa_Post = New System.Windows.Forms.Label()
        Me.TxtMa_Loi = New System.Windows.Forms.TextBox()
        Me.TxtTen_Loi = New System.Windows.Forms.TextBox()
        Me.LabTen_BP = New System.Windows.Forms.Label()
        Me.TxtTen_Loi2 = New System.Windows.Forms.TextBox()
        Me.LabTen_BP2 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTen_Cd = New System.Windows.Forms.TextBox()
        Me.TxtMa_Cd = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Cd.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 111)
        Me.ButtExit.TabIndex = 6
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 111)
        Me.ButtOK.TabIndex = 5
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 117)
        Me.TxtMa_Dvcs.TabIndex = 5
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 121)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 101)
        Me.GroupBoxLine.TabIndex = 3
        '
        'LabMa_Post
        '
        Me.LabMa_Post.Location = New System.Drawing.Point(5, 8)
        Me.LabMa_Post.Name = "LabMa_Post"
        Me.LabMa_Post.Size = New System.Drawing.Size(100, 13)
        Me.LabMa_Post.TabIndex = 10
        Me.LabMa_Post.Tag = "Currency"
        Me.LabMa_Post.Text = "Mã lỗi"
        '
        'TxtMa_Loi
        '
        Me.TxtMa_Loi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Loi.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Loi.Location = New System.Drawing.Point(110, 4)
        Me.TxtMa_Loi.Name = "TxtMa_Loi"
        Me.TxtMa_Loi.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_Loi.TabIndex = 0
        '
        'TxtTen_Loi
        '
        Me.TxtTen_Loi.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Loi.Location = New System.Drawing.Point(110, 27)
        Me.TxtTen_Loi.Name = "TxtTen_Loi"
        Me.TxtTen_Loi.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_Loi.TabIndex = 1
        '
        'LabTen_BP
        '
        Me.LabTen_BP.Location = New System.Drawing.Point(5, 31)
        Me.LabTen_BP.Name = "LabTen_BP"
        Me.LabTen_BP.Size = New System.Drawing.Size(100, 13)
        Me.LabTen_BP.TabIndex = 12
        Me.LabTen_BP.Tag = "Name"
        Me.LabTen_BP.Text = "Tên lỗi"
        '
        'TxtTen_Loi2
        '
        Me.TxtTen_Loi2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Loi2.Location = New System.Drawing.Point(110, 50)
        Me.TxtTen_Loi2.Name = "TxtTen_Loi2"
        Me.TxtTen_Loi2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_Loi2.TabIndex = 2
        '
        'LabTen_BP2
        '
        Me.LabTen_BP2.Location = New System.Drawing.Point(5, 54)
        Me.LabTen_BP2.Name = "LabTen_BP2"
        Me.LabTen_BP2.Size = New System.Drawing.Size(100, 13)
        Me.LabTen_BP2.TabIndex = 14
        Me.LabTen_BP2.Tag = "English name"
        Me.LabTen_BP2.Text = "Tên tiếng anh"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(5, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 32
        Me.Label2.Tag = "Group 1"
        Me.Label2.Text = "Công đoạn"
        '
        'txtTen_Cd
        '
        Me.txtTen_Cd.BackColor = System.Drawing.Color.White
        Me.txtTen_Cd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTen_Cd.Enabled = False
        Me.txtTen_Cd.ForeColor = System.Drawing.Color.Navy
        Me.txtTen_Cd.Location = New System.Drawing.Point(263, 77)
        Me.txtTen_Cd.Name = "txtTen_Cd"
        Me.txtTen_Cd.ReadOnly = True
        Me.txtTen_Cd.Size = New System.Drawing.Size(519, 14)
        Me.txtTen_Cd.TabIndex = 31
        Me.txtTen_Cd.TabStop = False
        '
        'TxtMa_Cd
        '
        Me.TxtMa_Cd._ActilookupPopup = False
        Me.TxtMa_Cd.CyberActilookupPopup = True
        Me.TxtMa_Cd.Dv_ListDetail = Nothing
        Me.TxtMa_Cd.Dv_Master = Nothing
        Me.TxtMa_Cd.FilterClient = ""
        Me.TxtMa_Cd.FilterSQL = ""
        Me.TxtMa_Cd.Location = New System.Drawing.Point(110, 74)
        Me.TxtMa_Cd.Name = "TxtMa_Cd"
        Me.TxtMa_Cd.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Cd.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Cd.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Cd.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_Cd.TabIndex = 3
        Me.TxtMa_Cd.Table_Name = ""
        '
        'DMLOI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 144)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTen_Cd)
        Me.Controls.Add(Me.TxtMa_Cd)
        Me.Controls.Add(Me.TxtTen_Loi2)
        Me.Controls.Add(Me.LabTen_BP2)
        Me.Controls.Add(Me.TxtTen_Loi)
        Me.Controls.Add(Me.LabTen_BP)
        Me.Controls.Add(Me.TxtMa_Loi)
        Me.Controls.Add(Me.LabMa_Post)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(490, 100)
        Me.Name = "DMLOI"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Post, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Loi, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Loi, 0)
        Me.Controls.SetChildIndex(Me.LabTen_BP2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Loi2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Cd, 0)
        Me.Controls.SetChildIndex(Me.txtTen_Cd, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.TxtMa_Cd.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Post As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Loi As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Loi As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Loi2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_BP2 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTen_Cd As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Cd As Cyber.SmLists.TxtLookup

End Class
