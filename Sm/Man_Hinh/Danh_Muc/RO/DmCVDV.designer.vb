<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DmCVDV
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
        Me.Chkis_SCC = New System.Windows.Forms.CheckBox()
        Me.Chkis_SDS = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtTen_hs = New System.Windows.Forms.TextBox()
        Me.TxtMa_hs = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_hs2 = New System.Windows.Forms.TextBox()
        Me.LabTen_TD2 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(547, 130)
        Me.ButtExit.TabIndex = 13
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(441, 130)
        Me.ButtOK.TabIndex = 12
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(292, 139)
        Me.TxtMa_Dvcs.TabIndex = 6
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(108, 143)
        Me.ChkActi.TabIndex = 11
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 125)
        Me.GroupBoxLine.Size = New System.Drawing.Size(648, 2)
        Me.GroupBoxLine.TabIndex = 4
        '
        'Chkis_SCC
        '
        Me.Chkis_SCC.AutoSize = True
        Me.Chkis_SCC.ForeColor = System.Drawing.Color.Blue
        Me.Chkis_SCC.Location = New System.Drawing.Point(108, 63)
        Me.Chkis_SCC.Name = "Chkis_SCC"
        Me.Chkis_SCC.Size = New System.Drawing.Size(201, 17)
        Me.Chkis_SCC.TabIndex = 2
        Me.Chkis_SCC.Tag = "Is Visible"
        Me.Chkis_SCC.Text = "Hiện thị trên tiến độ sửa chữa chung"
        Me.Chkis_SCC.UseVisualStyleBackColor = True
        '
        'Chkis_SDS
        '
        Me.Chkis_SDS.AutoSize = True
        Me.Chkis_SDS.ForeColor = System.Drawing.Color.Blue
        Me.Chkis_SDS.Location = New System.Drawing.Point(108, 86)
        Me.Chkis_SDS.Name = "Chkis_SDS"
        Me.Chkis_SDS.Size = New System.Drawing.Size(168, 17)
        Me.Chkis_SDS.TabIndex = 3
        Me.Chkis_SDS.Tag = "Is Visible"
        Me.Chkis_SDS.Text = "Hiện thị trên tiến độ đồng sơn"
        Me.Chkis_SDS.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(2, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 16)
        Me.Label3.TabIndex = 480
        Me.Label3.Tag = "Code"
        Me.Label3.Text = "Mã CVDV"
        '
        'TxtTen_hs
        '
        Me.TxtTen_hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_hs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_hs.Enabled = False
        Me.TxtTen_hs.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_hs.Location = New System.Drawing.Point(266, 16)
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
        'TxtTen_hs2
        '
        Me.TxtTen_hs2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_hs2.Location = New System.Drawing.Point(108, 36)
        Me.TxtTen_hs2.Name = "TxtTen_hs2"
        Me.TxtTen_hs2.Size = New System.Drawing.Size(539, 21)
        Me.TxtTen_hs2.TabIndex = 1
        '
        'LabTen_TD2
        '
        Me.LabTen_TD2.Location = New System.Drawing.Point(2, 39)
        Me.LabTen_TD2.Name = "LabTen_TD2"
        Me.LabTen_TD2.Size = New System.Drawing.Size(100, 16)
        Me.LabTen_TD2.TabIndex = 484
        Me.LabTen_TD2.Tag = "Name"
        Me.LabTen_TD2.Text = "Tên ngắn"
        '
        'DmCVDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(659, 172)
        Me.Controls.Add(Me.TxtTen_hs2)
        Me.Controls.Add(Me.LabTen_TD2)
        Me.Controls.Add(Me.TxtTen_hs)
        Me.Controls.Add(Me.TxtMa_hs)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Chkis_SDS)
        Me.Controls.Add(Me.Chkis_SCC)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DmCVDV"
        Me.Text = "Danh mục CVDV"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Chkis_SCC, 0)
        Me.Controls.SetChildIndex(Me.Chkis_SDS, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_hs, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_hs, 0)
        Me.Controls.SetChildIndex(Me.LabTen_TD2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_hs2, 0)
        CType(Me.TxtMa_hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Chkis_SCC As System.Windows.Forms.CheckBox
    Friend WithEvents Chkis_SDS As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_hs As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_hs As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_hs2 As Windows.Forms.TextBox
    Friend WithEvents LabTen_TD2 As Windows.Forms.Label
End Class
