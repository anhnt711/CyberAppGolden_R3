<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMMauNtKx
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
        Me.TxtMa_Mau_Nt = New Cyber.SmLists.TxtLookup()
        Me.ChkNgam_Dinh = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Mau_Nt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(541, 111)
        Me.ButtExit.TabIndex = 4
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(439, 111)
        Me.ButtOK.TabIndex = 3
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(333, 117)
        Me.TxtMa_Dvcs.TabIndex = 14
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(108, 111)
        Me.ChkActi.TabIndex = 13
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 90)
        Me.GroupBoxLine.Size = New System.Drawing.Size(639, 9)
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(3, 16)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(100, 16)
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
        Me.TxtTen_kx.Location = New System.Drawing.Point(263, 12)
        Me.TxtTen_kx.Name = "TxtTen_kx"
        Me.TxtTen_kx.ReadOnly = True
        Me.TxtTen_kx.Size = New System.Drawing.Size(280, 14)
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
        Me.TxtMa_kx.Location = New System.Drawing.Point(108, 12)
        Me.TxtMa_kx.Name = "TxtMa_kx"
        Me.TxtMa_kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kx.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_kx.TabIndex = 0
        Me.TxtMa_kx.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(3, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
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
        Me.TxtTen_Mau.Location = New System.Drawing.Point(263, 36)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.ReadOnly = True
        Me.TxtTen_Mau.Size = New System.Drawing.Size(280, 14)
        Me.TxtTen_Mau.TabIndex = 26
        Me.TxtTen_Mau.TabStop = False
        '
        'TxtMa_Mau_Nt
        '
        Me.TxtMa_Mau_Nt._ActilookupPopup = False
        Me.TxtMa_Mau_Nt.CyberActilookupPopup = True
        Me.TxtMa_Mau_Nt.Dv_ListDetail = Nothing
        Me.TxtMa_Mau_Nt.Dv_Master = Nothing
        Me.TxtMa_Mau_Nt.FilterClient = ""
        Me.TxtMa_Mau_Nt.FilterSQL = ""
        Me.TxtMa_Mau_Nt.Location = New System.Drawing.Point(108, 37)
        Me.TxtMa_Mau_Nt.Name = "TxtMa_Mau_Nt"
        Me.TxtMa_Mau_Nt.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Mau_Nt.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Mau_Nt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Mau_Nt.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_Mau_Nt.TabIndex = 1
        Me.TxtMa_Mau_Nt.Table_Name = ""
        '
        'ChkNgam_Dinh
        '
        Me.ChkNgam_Dinh.AutoSize = True
        Me.ChkNgam_Dinh.Location = New System.Drawing.Point(108, 63)
        Me.ChkNgam_Dinh.Name = "ChkNgam_Dinh"
        Me.ChkNgam_Dinh.Size = New System.Drawing.Size(76, 17)
        Me.ChkNgam_Dinh.TabIndex = 2
        Me.ChkNgam_Dinh.Tag = "Default"
        Me.ChkNgam_Dinh.Text = "Ngầm định"
        Me.ChkNgam_Dinh.UseVisualStyleBackColor = True
        '
        'DMMauNtKx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(643, 144)
        Me.Controls.Add(Me.ChkNgam_Dinh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.TxtMa_Mau_Nt)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_kx)
        Me.Controls.Add(Me.TxtMa_kx)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "DMMauNtKx"
        Me.Text = "Danh mục  vị trí trung tâm lợi nhuận"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kx, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Mau_Nt, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ChkNgam_Dinh, 0)
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Mau_Nt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kx As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Mau_Nt As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkNgam_Dinh As System.Windows.Forms.CheckBox

End Class
