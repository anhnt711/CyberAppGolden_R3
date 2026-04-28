<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMMauKx
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
        Me.TxtTen_kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_kx = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.TxtMa_MAU = New Cyber.SmLists.TxtLookup()
        Me.ChkNgam_Dinh = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_MAU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(721, 145)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 4
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(585, 145)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 3
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(444, 153)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.TabIndex = 14
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(144, 145)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkActi.TabIndex = 13
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 118)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(852, 12)
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(4, 21)
        Me.LabMa_Nh1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(133, 21)
        Me.LabMa_Nh1.TabIndex = 24
        Me.LabMa_Nh1.Tag = "Models code"
        Me.LabMa_Nh1.Text = "Mã kiểu xe"
        '
        'TxtTen_kx
        '
        Me.TxtTen_kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_kx.Enabled = False
        Me.TxtTen_kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kx.Location = New System.Drawing.Point(351, 16)
        Me.TxtTen_kx.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_kx.Name = "TxtTen_kx"
        Me.TxtTen_kx.ReadOnly = True
        Me.TxtTen_kx.Size = New System.Drawing.Size(373, 17)
        Me.TxtTen_kx.TabIndex = 23
        Me.TxtTen_kx.TabStop = False
        '
        'TxtMa_kx
        '
        Me.TxtMa_kx._ActilookupPopup = False
        Me.TxtMa_kx.CyberActilookupPopup = True
        Me.TxtMa_kx.Dv_ListDetail = Nothing
        Me.TxtMa_kx.Dv_Master = Nothing
        Me.TxtMa_kx.FilterClient = ""
        Me.TxtMa_kx.FilterSQL = ""
        Me.TxtMa_kx.Location = New System.Drawing.Point(144, 16)
        Me.TxtMa_kx.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_kx.Name = "TxtMa_kx"
        Me.TxtMa_kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kx.Size = New System.Drawing.Size(199, 22)
        Me.TxtMa_kx.TabIndex = 0
        Me.TxtMa_kx.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 21)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Colour"
        Me.Label1.Text = "Mã màu xe"
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.BackColor = System.Drawing.Color.White
        Me.TxtTen_Mau.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Mau.Enabled = False
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Mau.Location = New System.Drawing.Point(351, 47)
        Me.TxtTen_Mau.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(373, 17)
        Me.TxtTen_Mau.TabIndex = 26
        Me.TxtTen_Mau.TabStop = False
        '
        'TxtMa_MAU
        '
        Me.TxtMa_MAU._ActilookupPopup = False
        Me.TxtMa_MAU.CyberActilookupPopup = True
        Me.TxtMa_MAU.Dv_ListDetail = Nothing
        Me.TxtMa_MAU.Dv_Master = Nothing
        Me.TxtMa_MAU.FilterClient = ""
        Me.TxtMa_MAU.FilterSQL = ""
        Me.TxtMa_MAU.Location = New System.Drawing.Point(144, 48)
        Me.TxtMa_MAU.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_MAU.Name = "TxtMa_MAU"
        Me.TxtMa_MAU.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_MAU.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_MAU.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_MAU.Size = New System.Drawing.Size(199, 22)
        Me.TxtMa_MAU.TabIndex = 1
        Me.TxtMa_MAU.Table_Name = ""
        '
        'ChkNgam_Dinh
        '
        Me.ChkNgam_Dinh.AutoSize = True
        Me.ChkNgam_Dinh.Location = New System.Drawing.Point(144, 82)
        Me.ChkNgam_Dinh.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkNgam_Dinh.Name = "ChkNgam_Dinh"
        Me.ChkNgam_Dinh.Size = New System.Drawing.Size(96, 21)
        Me.ChkNgam_Dinh.TabIndex = 2
        Me.ChkNgam_Dinh.Tag = "Default"
        Me.ChkNgam_Dinh.Text = "Ngầm định"
        Me.ChkNgam_Dinh.UseVisualStyleBackColor = True
        '
        'DMMauKx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(857, 188)
        Me.Controls.Add(Me.ChkNgam_Dinh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.TxtMa_MAU)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_kx)
        Me.Controls.Add(Me.TxtMa_kx)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "DMMauKx"
        Me.Text = "Danh mục  vị trí trung tâm lợi nhuận"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kx, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_MAU, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ChkNgam_Dinh, 0)
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_MAU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kx As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_MAU As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkNgam_Dinh As System.Windows.Forms.CheckBox

End Class
