<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMXA
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
        Me.TxtTen_xa2 = New System.Windows.Forms.TextBox()
        Me.Labten_mau2 = New System.Windows.Forms.Label()
        Me.TxtTen_xa = New System.Windows.Forms.TextBox()
        Me.LabTen_mau = New System.Windows.Forms.Label()
        Me.LabMa_mau = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_xa = New System.Windows.Forms.TextBox()
        Me.TxtTen_TP = New System.Windows.Forms.TextBox()
        Me.TxtMa_TP = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_quan = New System.Windows.Forms.TextBox()
        Me.TxtMa_quan = New Cyber.SmLists.TxtLookup()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_TP.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_quan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(907, 169)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 9
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(771, 169)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 8
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(629, 177)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(140, 182)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 6
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 153)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1037, 12)
        Me.GroupBoxLine.TabIndex = 5
        '
        'TxtTen_xa2
        '
        Me.TxtTen_xa2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_xa2.Location = New System.Drawing.Point(140, 127)
        Me.TxtTen_xa2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_xa2.Name = "TxtTen_xa2"
        Me.TxtTen_xa2.Size = New System.Drawing.Size(893, 24)
        Me.TxtTen_xa2.TabIndex = 4
        '
        'Labten_mau2
        '
        Me.Labten_mau2.Location = New System.Drawing.Point(11, 132)
        Me.Labten_mau2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labten_mau2.Name = "Labten_mau2"
        Me.Labten_mau2.Size = New System.Drawing.Size(107, 20)
        Me.Labten_mau2.TabIndex = 17
        Me.Labten_mau2.Tag = "English name"
        Me.Labten_mau2.Text = "Tên tiếng anh"
        '
        'TxtTen_xa
        '
        Me.TxtTen_xa.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_xa.Location = New System.Drawing.Point(140, 97)
        Me.TxtTen_xa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_xa.Name = "TxtTen_xa"
        Me.TxtTen_xa.Size = New System.Drawing.Size(893, 24)
        Me.TxtTen_xa.TabIndex = 3
        '
        'LabTen_mau
        '
        Me.LabTen_mau.Location = New System.Drawing.Point(11, 43)
        Me.LabTen_mau.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTen_mau.Name = "LabTen_mau"
        Me.LabTen_mau.Size = New System.Drawing.Size(120, 20)
        Me.LabTen_mau.TabIndex = 18
        Me.LabTen_mau.Tag = "District code"
        Me.LabTen_mau.Text = "Mã Quận/Huyện"
        '
        'LabMa_mau
        '
        Me.LabMa_mau.Location = New System.Drawing.Point(11, 14)
        Me.LabMa_mau.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_mau.Name = "LabMa_mau"
        Me.LabMa_mau.Size = New System.Drawing.Size(120, 20)
        Me.LabMa_mau.TabIndex = 19
        Me.LabMa_mau.Tag = "Province code"
        Me.LabMa_mau.Text = "Mã Tỉnh/TP"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 102)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Tag = "Ward Name"
        Me.Label1.Text = "Tên Phường/xã"
        '
        'TxtMa_xa
        '
        Me.TxtMa_xa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_xa.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_xa.Location = New System.Drawing.Point(140, 67)
        Me.TxtMa_xa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_xa.Name = "TxtMa_xa"
        Me.TxtMa_xa.Size = New System.Drawing.Size(196, 24)
        Me.TxtMa_xa.TabIndex = 2
        '
        'TxtTen_TP
        '
        Me.TxtTen_TP.BackColor = System.Drawing.Color.White
        Me.TxtTen_TP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_TP.Enabled = False
        Me.TxtTen_TP.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TP.Location = New System.Drawing.Point(343, 13)
        Me.TxtTen_TP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TP.Name = "TxtTen_TP"
        Me.TxtTen_TP.ReadOnly = True
        Me.TxtTen_TP.Size = New System.Drawing.Size(692, 17)
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
        Me.TxtMa_TP.Location = New System.Drawing.Point(140, 9)
        Me.TxtMa_TP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_TP.Name = "TxtMa_TP"
        Me.TxtMa_TP.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_TP.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_TP.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_TP.Size = New System.Drawing.Size(197, 22)
        Me.TxtMa_TP.TabIndex = 0
        Me.TxtMa_TP.Table_Name = ""
        '
        'TxtTen_quan
        '
        Me.TxtTen_quan.BackColor = System.Drawing.Color.White
        Me.TxtTen_quan.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_quan.Enabled = False
        Me.TxtTen_quan.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_quan.Location = New System.Drawing.Point(343, 42)
        Me.TxtTen_quan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_quan.Name = "TxtTen_quan"
        Me.TxtTen_quan.ReadOnly = True
        Me.TxtTen_quan.Size = New System.Drawing.Size(692, 17)
        Me.TxtTen_quan.TabIndex = 39
        Me.TxtTen_quan.TabStop = False
        '
        'TxtMa_quan
        '
        Me.TxtMa_quan._ActilookupPopup = False
        Me.TxtMa_quan.CyberActilookupPopup = True
        Me.TxtMa_quan.Dv_ListDetail = Nothing
        Me.TxtMa_quan.Dv_Master = Nothing
        Me.TxtMa_quan.FilterClient = ""
        Me.TxtMa_quan.FilterSQL = ""
        Me.TxtMa_quan.Location = New System.Drawing.Point(140, 38)
        Me.TxtMa_quan.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_quan.Name = "TxtMa_quan"
        Me.TxtMa_quan.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_quan.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_quan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_quan.Size = New System.Drawing.Size(197, 22)
        Me.TxtMa_quan.TabIndex = 1
        Me.TxtMa_quan.Table_Name = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(11, 72)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 40
        Me.Label2.Tag = "Ward code"
        Me.Label2.Text = "Mã Phường/xã"
        '
        'DMXA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(1043, 212)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtTen_quan)
        Me.Controls.Add(Me.TxtMa_quan)
        Me.Controls.Add(Me.TxtTen_TP)
        Me.Controls.Add(Me.TxtMa_TP)
        Me.Controls.Add(Me.TxtMa_xa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_xa2)
        Me.Controls.Add(Me.Labten_mau2)
        Me.Controls.Add(Me.TxtTen_xa)
        Me.Controls.Add(Me.LabTen_mau)
        Me.Controls.Add(Me.LabMa_mau)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMXA"
        Me.Text = "Danh mục Phường/Xã"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_mau, 0)
        Me.Controls.SetChildIndex(Me.LabTen_mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_xa, 0)
        Me.Controls.SetChildIndex(Me.Labten_mau2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_xa2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_xa, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_TP, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TP, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_quan, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_quan, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.TxtMa_TP.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_quan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTen_xa2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_mau2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_xa As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_mau As System.Windows.Forms.Label
    Friend WithEvents LabMa_mau As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_xa As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_TP As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_TP As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_quan As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_quan As Cyber.SmLists.TxtLookup
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
