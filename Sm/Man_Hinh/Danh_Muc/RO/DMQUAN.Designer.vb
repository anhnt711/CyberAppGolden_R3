<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMQUAN
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
        Me.TxtTen_quan2 = New System.Windows.Forms.TextBox()
        Me.Labten_mau2 = New System.Windows.Forms.Label()
        Me.TxtTen_quan = New System.Windows.Forms.TextBox()
        Me.LabTen_mau = New System.Windows.Forms.Label()
        Me.LabMa_mau = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_quan = New System.Windows.Forms.TextBox()
        Me.TxtTen_TP = New System.Windows.Forms.TextBox()
        Me.TxtMa_TP = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_TP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(680, 110)
        Me.ButtExit.TabIndex = 6
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(578, 110)
        Me.ButtOK.TabIndex = 5
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(472, 116)
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(105, 120)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 98)
        Me.GroupBoxLine.Size = New System.Drawing.Size(778, 9)
        Me.GroupBoxLine.TabIndex = 8
        '
        'TxtTen_quan2
        '
        Me.TxtTen_quan2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_quan2.Location = New System.Drawing.Point(105, 75)
        Me.TxtTen_quan2.Name = "TxtTen_quan2"
        Me.TxtTen_quan2.Size = New System.Drawing.Size(671, 21)
        Me.TxtTen_quan2.TabIndex = 3
        '
        'Labten_mau2
        '
        Me.Labten_mau2.Location = New System.Drawing.Point(8, 79)
        Me.Labten_mau2.Name = "Labten_mau2"
        Me.Labten_mau2.Size = New System.Drawing.Size(80, 13)
        Me.Labten_mau2.TabIndex = 17
        Me.Labten_mau2.Tag = "English name"
        Me.Labten_mau2.Text = "Tên tiếng anh"
        '
        'TxtTen_quan
        '
        Me.TxtTen_quan.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_quan.Location = New System.Drawing.Point(105, 52)
        Me.TxtTen_quan.Name = "TxtTen_quan"
        Me.TxtTen_quan.Size = New System.Drawing.Size(671, 21)
        Me.TxtTen_quan.TabIndex = 2
        '
        'LabTen_mau
        '
        Me.LabTen_mau.Location = New System.Drawing.Point(8, 33)
        Me.LabTen_mau.Name = "LabTen_mau"
        Me.LabTen_mau.Size = New System.Drawing.Size(90, 13)
        Me.LabTen_mau.TabIndex = 18
        Me.LabTen_mau.Tag = "Distict Code"
        Me.LabTen_mau.Text = "Mã Quận/Huyện"
        '
        'LabMa_mau
        '
        Me.LabMa_mau.Location = New System.Drawing.Point(8, 11)
        Me.LabMa_mau.Name = "LabMa_mau"
        Me.LabMa_mau.Size = New System.Drawing.Size(90, 13)
        Me.LabMa_mau.TabIndex = 19
        Me.LabMa_mau.Tag = "Province code"
        Me.LabMa_mau.Text = "Mã Tỉnh/TP"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Tag = "Distict Name"
        Me.Label1.Text = "Tên Quận/Huyện"
        '
        'TxtMa_quan
        '
        Me.TxtMa_quan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_quan.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_quan.Location = New System.Drawing.Point(105, 29)
        Me.TxtMa_quan.Name = "TxtMa_quan"
        Me.TxtMa_quan.Size = New System.Drawing.Size(148, 21)
        Me.TxtMa_quan.TabIndex = 1
        '
        'TxtTen_TP
        '
        Me.TxtTen_TP.BackColor = System.Drawing.Color.White
        Me.TxtTen_TP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TP.Enabled = False
        Me.TxtTen_TP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TP.Location = New System.Drawing.Point(257, 10)
        Me.TxtTen_TP.Name = "TxtTen_TP"
        Me.TxtTen_TP.ReadOnly = True
        Me.TxtTen_TP.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_TP.TabIndex = 37
        Me.TxtTen_TP.TabStop = False
        '
        'TxtMa_TP
        '
        Me.TxtMa_TP._ActilookupPopup = False
        Me.TxtMa_TP.CyberActilookupPopup = True
        Me.TxtMa_TP.Dv_ListDetail = Nothing
        Me.TxtMa_TP.Dv_Master = Nothing
        Me.TxtMa_TP.FilterClient = ""
        Me.TxtMa_TP.FilterSQL = ""
        Me.TxtMa_TP.Location = New System.Drawing.Point(105, 7)
        Me.TxtMa_TP.Name = "TxtMa_TP"
        Me.TxtMa_TP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TP.Size = New System.Drawing.Size(148, 20)
        Me.TxtMa_TP.TabIndex = 0
        Me.TxtMa_TP.Table_Name = ""
        '
        'DMQUAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(782, 143)
        Me.Controls.Add(Me.TxtTen_TP)
        Me.Controls.Add(Me.TxtMa_TP)
        Me.Controls.Add(Me.TxtMa_quan)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_quan2)
        Me.Controls.Add(Me.Labten_mau2)
        Me.Controls.Add(Me.TxtTen_quan)
        Me.Controls.Add(Me.LabTen_mau)
        Me.Controls.Add(Me.LabMa_mau)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMQUAN"
        Me.Text = "Danh mục Quận/Huyện"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_mau, 0)
        Me.Controls.SetChildIndex(Me.LabTen_mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_quan, 0)
        Me.Controls.SetChildIndex(Me.Labten_mau2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_quan2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_quan, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TP, 0)
        CType(Me.TxtMa_TP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTen_quan2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_mau2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_quan As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_mau As System.Windows.Forms.Label
    Friend WithEvents LabMa_mau As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_quan As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_TP As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_TP As Cyber.SmLists.TxtLookup

End Class
