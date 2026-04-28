<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMKCSCD
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
        Me.LabMa_TP = New System.Windows.Forms.Label()
        Me.TxtMa_KCS = New System.Windows.Forms.TextBox()
        Me.TxtTen_KCS = New System.Windows.Forms.TextBox()
        Me.LabTen_tp = New System.Windows.Forms.Label()
        Me.TxtTen_KCS2 = New System.Windows.Forms.TextBox()
        Me.LabTen_tp2 = New System.Windows.Forms.Label()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_CD = New System.Windows.Forms.TextBox()
        Me.TxtMa_CD = New Cyber.SmLists.TxtLookup()
        Me.ChkDefault = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_CD.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 137)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 137)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 143)
        Me.TxtMa_Dvcs.TabIndex = 11
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 147)
        Me.ChkActi.TabIndex = 5
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 127)
        Me.GroupBoxLine.TabIndex = 12
        '
        'LabMa_TP
        '
        Me.LabMa_TP.Location = New System.Drawing.Point(5, 29)
        Me.LabMa_TP.Name = "LabMa_TP"
        Me.LabMa_TP.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_TP.TabIndex = 10
        Me.LabMa_TP.Tag = "Province code"
        Me.LabMa_TP.Text = "Mã KCS"
        '
        'TxtMa_KCS
        '
        Me.TxtMa_KCS.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_KCS.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_KCS.Location = New System.Drawing.Point(110, 27)
        Me.TxtMa_KCS.Name = "TxtMa_KCS"
        Me.TxtMa_KCS.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_KCS.TabIndex = 1
        '
        'TxtTen_KCS
        '
        Me.TxtTen_KCS.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KCS.Location = New System.Drawing.Point(110, 50)
        Me.TxtTen_KCS.Name = "TxtTen_KCS"
        Me.TxtTen_KCS.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_KCS.TabIndex = 2
        '
        'LabTen_tp
        '
        Me.LabTen_tp.Location = New System.Drawing.Point(5, 52)
        Me.LabTen_tp.Name = "LabTen_tp"
        Me.LabTen_tp.Size = New System.Drawing.Size(100, 17)
        Me.LabTen_tp.TabIndex = 12
        Me.LabTen_tp.Tag = "Province name"
        Me.LabTen_tp.Text = "Tên KCS"
        '
        'TxtTen_KCS2
        '
        Me.TxtTen_KCS2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_KCS2.Location = New System.Drawing.Point(110, 73)
        Me.TxtTen_KCS2.Name = "TxtTen_KCS2"
        Me.TxtTen_KCS2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_KCS2.TabIndex = 3
        '
        'LabTen_tp2
        '
        Me.LabTen_tp2.Location = New System.Drawing.Point(5, 75)
        Me.LabTen_tp2.Name = "LabTen_tp2"
        Me.LabTen_tp2.Size = New System.Drawing.Size(100, 17)
        Me.LabTen_tp2.TabIndex = 14
        Me.LabTen_tp2.Tag = "English name"
        Me.LabTen_tp2.Text = "Tên tiếng anh"
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(5, 6)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(100, 17)
        Me.LabMa_Nh1.TabIndex = 24
        Me.LabMa_Nh1.Tag = "Group 1"
        Me.LabMa_Nh1.Text = "Mã công đoạn"
        '
        'TxtTen_CD
        '
        Me.TxtTen_CD.BackColor = System.Drawing.Color.White
        Me.TxtTen_CD.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_CD.Enabled = False
        Me.TxtTen_CD.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_CD.Location = New System.Drawing.Point(263, 7)
        Me.TxtTen_CD.Name = "TxtTen_CD"
        Me.TxtTen_CD.ReadOnly = True
        Me.TxtTen_CD.Size = New System.Drawing.Size(519, 14)
        Me.TxtTen_CD.TabIndex = 23
        Me.TxtTen_CD.TabStop = False
        '
        'TxtMa_CD
        '
        Me.TxtMa_CD._ActilookupPopup = False
        Me.TxtMa_CD.CyberActilookupPopup = True
        Me.TxtMa_CD.Dv_ListDetail = Nothing
        Me.TxtMa_CD.Dv_Master = Nothing
        Me.TxtMa_CD.FilterClient = ""
        Me.TxtMa_CD.FilterSQL = ""
        Me.TxtMa_CD.Location = New System.Drawing.Point(110, 4)
        Me.TxtMa_CD.Name = "TxtMa_CD"
        Me.TxtMa_CD.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_CD.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_CD.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_CD.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_CD.TabIndex = 0
        Me.TxtMa_CD.Table_Name = ""
        '
        'ChkDefault
        '
        Me.ChkDefault.AutoSize = True
        Me.ChkDefault.Location = New System.Drawing.Point(110, 98)
        Me.ChkDefault.Name = "ChkDefault"
        Me.ChkDefault.Size = New System.Drawing.Size(76, 17)
        Me.ChkDefault.TabIndex = 4
        Me.ChkDefault.Tag = "Default"
        Me.ChkDefault.Text = "Ngầm định"
        Me.ChkDefault.UseVisualStyleBackColor = True
        '
        'DMKCSCD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(784, 170)
        Me.Controls.Add(Me.ChkDefault)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_CD)
        Me.Controls.Add(Me.TxtMa_CD)
        Me.Controls.Add(Me.TxtTen_KCS2)
        Me.Controls.Add(Me.LabTen_tp2)
        Me.Controls.Add(Me.TxtTen_KCS)
        Me.Controls.Add(Me.LabTen_tp)
        Me.Controls.Add(Me.TxtMa_KCS)
        Me.Controls.Add(Me.LabMa_TP)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMKCSCD"
        Me.Text = "Danh mục Tỉnh/TP"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TP, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_KCS, 0)
        Me.Controls.SetChildIndex(Me.LabTen_tp, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KCS, 0)
        Me.Controls.SetChildIndex(Me.LabTen_tp2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_KCS2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_CD, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_CD, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.ChkDefault, 0)
        CType(Me.TxtMa_CD.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TP As System.Windows.Forms.Label
    Friend WithEvents TxtMa_KCS As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_KCS As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_tp As System.Windows.Forms.Label
    Friend WithEvents TxtTen_KCS2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_tp2 As System.Windows.Forms.Label
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_CD As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_CD As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkDefault As System.Windows.Forms.CheckBox

End Class
