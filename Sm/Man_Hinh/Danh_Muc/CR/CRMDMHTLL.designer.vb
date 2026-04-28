<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRMDMHTLL
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtMa_HTLL = New System.Windows.Forms.TextBox()
        Me.TxtTen_HTLL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ChkNgam_Dinh = New System.Windows.Forms.CheckBox()
        Me.TxtTen_Loai = New System.Windows.Forms.TextBox()
        Me.Txtma_Loai = New Cyber.SmLists.TxtLookup()
        CType(Me.Txtma_Loai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(696, 152)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 5
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(555, 152)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 4
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(20, 158)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(153, 169)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 5
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(1, 139)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(840, 4)
        Me.GroupBoxLine.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 22)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Code"
        Me.Label1.Text = "Mã hình thức"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 22)
        Me.Label2.TabIndex = 30
        Me.Label2.Tag = "Name"
        Me.Label2.Text = "Tên hình thức"
        '
        'TxtMa_HTLL
        '
        Me.TxtMa_HTLL.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_HTLL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_HTLL.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HTLL.Location = New System.Drawing.Point(153, 46)
        Me.TxtMa_HTLL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_HTLL.Name = "TxtMa_HTLL"
        Me.TxtMa_HTLL.Size = New System.Drawing.Size(149, 24)
        Me.TxtMa_HTLL.TabIndex = 1
        '
        'TxtTen_HTLL
        '
        Me.TxtTen_HTLL.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_HTLL.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HTLL.Location = New System.Drawing.Point(153, 75)
        Me.TxtTen_HTLL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_HTLL.Name = "TxtTen_HTLL"
        Me.TxtTen_HTLL.Size = New System.Drawing.Size(683, 24)
        Me.TxtTen_HTLL.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(133, 22)
        Me.Label3.TabIndex = 32
        Me.Label3.Tag = "Type"
        Me.Label3.Text = "Phân loại"
        '
        'ChkNgam_Dinh
        '
        Me.ChkNgam_Dinh.AutoSize = True
        Me.ChkNgam_Dinh.Location = New System.Drawing.Point(153, 111)
        Me.ChkNgam_Dinh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNgam_Dinh.Name = "ChkNgam_Dinh"
        Me.ChkNgam_Dinh.Size = New System.Drawing.Size(96, 21)
        Me.ChkNgam_Dinh.TabIndex = 3
        Me.ChkNgam_Dinh.Tag = "Default"
        Me.ChkNgam_Dinh.Text = "Ngầm định"
        Me.ChkNgam_Dinh.UseVisualStyleBackColor = True
        '
        'TxtTen_Loai
        '
        Me.TxtTen_Loai.BackColor = System.Drawing.Color.White
        Me.TxtTen_Loai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Loai.Enabled = False
        Me.TxtTen_Loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Loai.Location = New System.Drawing.Point(312, 21)
        Me.TxtTen_Loai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Loai.Name = "TxtTen_Loai"
        Me.TxtTen_Loai.ReadOnly = True
        Me.TxtTen_Loai.Size = New System.Drawing.Size(491, 17)
        Me.TxtTen_Loai.TabIndex = 34
        Me.TxtTen_Loai.TabStop = False
        '
        'Txtma_Loai
        '
        Me.Txtma_Loai._ActilookupPopup = False
        Me.Txtma_Loai.CyberActilookupPopup = True
        Me.Txtma_Loai.Dv_ListDetail = Nothing
        Me.Txtma_Loai.Dv_Master = Nothing
        Me.Txtma_Loai.FilterClient = ""
        Me.Txtma_Loai.FilterSQL = ""
        Me.Txtma_Loai.Location = New System.Drawing.Point(153, 17)
        Me.Txtma_Loai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtma_Loai.Name = "Txtma_Loai"
        Me.Txtma_Loai.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.Txtma_Loai.Properties.Appearance.Options.UseForeColor = True
        Me.Txtma_Loai.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.Txtma_Loai.Size = New System.Drawing.Size(151, 22)
        Me.Txtma_Loai.TabIndex = 0
        Me.Txtma_Loai.Table_Name = ""
        '
        'CRMDMHTLL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(845, 207)
        Me.Controls.Add(Me.TxtTen_Loai)
        Me.Controls.Add(Me.Txtma_Loai)
        Me.Controls.Add(Me.ChkNgam_Dinh)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtTen_HTLL)
        Me.Controls.Add(Me.TxtMa_HTLL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "CRMDMHTLL"
        Me.Text = "Danh mục hình thức liên lạc"
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HTLL, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HTLL, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkNgam_Dinh, 0)
        Me.Controls.SetChildIndex(Me.Txtma_Loai, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Loai, 0)
        CType(Me.Txtma_Loai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_HTLL As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_HTLL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ChkNgam_Dinh As System.Windows.Forms.CheckBox
    Friend WithEvents TxtTen_Loai As System.Windows.Forms.TextBox
    Friend WithEvents Txtma_Loai As Cyber.SmLists.TxtLookup

End Class
