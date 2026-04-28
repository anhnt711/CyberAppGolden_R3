<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTien_Do_Mau_KX
    Inherits Cyber.From.FrmCalculator

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTien_Do_Mau_KX))
        Me.LabMa_Xe = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kx = New Cyber.SmLists.TxtLookup()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_Mau = New Cyber.SmLists.TxtLookup()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTen_Mau = New System.Windows.Forms.TextBox()
        Me.txtGhi_Chu = New System.Windows.Forms.TextBox()
        Me.buttRemove_backcolor = New DevExpress.XtraEditors.SimpleButton()
        Me.buttRemove_Forecolor = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtBackColor_Ghichu = New System.Windows.Forms.TextBox()
        Me.ButtBackColor_Choose = New DevExpress.XtraEditors.SimpleButton()
        Me.ButtForeColor_Choose = New DevExpress.XtraEditors.SimpleButton()
        Me.TxtForeColor_Ghichu = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CldChon_ForeColor = New System.Windows.Forms.ColorDialog()
        Me.CldChon_Backcolor = New System.Windows.Forms.ColorDialog()
        Me.ChkMau_kho = New System.Windows.Forms.CheckBox()
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 192)
        Me.GroupBoxLine.Size = New System.Drawing.Size(551, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(351, 202)
        Me.ButtOK.TabIndex = 3
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(453, 202)
        Me.ButtExit.TabIndex = 4
        '
        'LabMa_Xe
        '
        Me.LabMa_Xe.AutoSize = True
        Me.LabMa_Xe.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_Xe.ForeColor = System.Drawing.Color.Blue
        Me.LabMa_Xe.Location = New System.Drawing.Point(18, 15)
        Me.LabMa_Xe.Name = "LabMa_Xe"
        Me.LabMa_Xe.Size = New System.Drawing.Size(55, 17)
        Me.LabMa_Xe.TabIndex = 7157
        Me.LabMa_Xe.Tag = "Plate"
        Me.LabMa_Xe.Text = "Biển số"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Blue
        Me.TxtMa_Xe.Location = New System.Drawing.Point(102, 13)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(155, 23)
        Me.TxtMa_Xe.TabIndex = 0
        Me.TxtMa_Xe.Tag = ""
        '
        'TxtMa_Kx
        '
        Me.TxtMa_Kx._ActilookupPopup = False
        Me.TxtMa_Kx.CyberActilookupPopup = True
        Me.TxtMa_Kx.Dv_ListDetail = Nothing
        Me.TxtMa_Kx.Dv_Master = Nothing
        Me.TxtMa_Kx.FilterClient = ""
        Me.TxtMa_Kx.FilterSQL = ""
        Me.TxtMa_Kx.Location = New System.Drawing.Point(102, 39)
        Me.TxtMa_Kx.Name = "TxtMa_Kx"
        Me.TxtMa_Kx.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kx.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kx.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_Kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kx.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_Kx.TabIndex = 1
        Me.TxtMa_Kx.Table_Name = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(18, 42)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 7160
        Me.Label5.Tag = "Model"
        Me.Label5.Text = "Kiểu xe"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(266, 41)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.Size = New System.Drawing.Size(284, 20)
        Me.TxtTen_Kx.TabIndex = 7159
        Me.TxtTen_Kx.Tag = ""
        '
        'TxtMa_Mau
        '
        Me.TxtMa_Mau._ActilookupPopup = False
        Me.TxtMa_Mau.CyberActilookupPopup = True
        Me.TxtMa_Mau.Dv_ListDetail = Nothing
        Me.TxtMa_Mau.Dv_Master = Nothing
        Me.TxtMa_Mau.FilterClient = ""
        Me.TxtMa_Mau.FilterSQL = ""
        Me.TxtMa_Mau.Location = New System.Drawing.Point(102, 65)
        Me.TxtMa_Mau.Name = "TxtMa_Mau"
        Me.TxtMa_Mau.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Mau.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Mau.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Mau.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Mau.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.TxtMa_Mau.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Mau.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_Mau.TabIndex = 2
        Me.TxtMa_Mau.Table_Name = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(18, 66)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 7163
        Me.Label1.Tag = "Color"
        Me.Label1.Text = "Màu xe"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TxtTen_Mau
        '
        Me.TxtTen_Mau.BackColor = System.Drawing.Color.White
        Me.TxtTen_Mau.Enabled = False
        Me.TxtTen_Mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Mau.Location = New System.Drawing.Point(266, 65)
        Me.TxtTen_Mau.Name = "TxtTen_Mau"
        Me.TxtTen_Mau.Size = New System.Drawing.Size(284, 20)
        Me.TxtTen_Mau.TabIndex = 7162
        Me.TxtTen_Mau.Tag = ""
        '
        'txtGhi_Chu
        '
        Me.txtGhi_Chu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGhi_Chu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhi_Chu.ForeColor = System.Drawing.Color.Navy
        Me.txtGhi_Chu.Location = New System.Drawing.Point(102, 113)
        Me.txtGhi_Chu.MaxLength = 200
        Me.txtGhi_Chu.Multiline = True
        Me.txtGhi_Chu.Name = "txtGhi_Chu"
        Me.txtGhi_Chu.Size = New System.Drawing.Size(445, 82)
        Me.txtGhi_Chu.TabIndex = 7164
        '
        'buttRemove_backcolor
        '
        Me.buttRemove_backcolor.Image = CType(resources.GetObject("buttRemove_backcolor.Image"), System.Drawing.Image)
        Me.buttRemove_backcolor.Location = New System.Drawing.Point(49, 168)
        Me.buttRemove_backcolor.Name = "buttRemove_backcolor"
        Me.buttRemove_backcolor.Size = New System.Drawing.Size(26, 23)
        Me.buttRemove_backcolor.TabIndex = 7297
        Me.buttRemove_backcolor.ToolTip = "Màu chữ"
        '
        'buttRemove_Forecolor
        '
        Me.buttRemove_Forecolor.Image = CType(resources.GetObject("buttRemove_Forecolor.Image"), System.Drawing.Image)
        Me.buttRemove_Forecolor.Location = New System.Drawing.Point(49, 139)
        Me.buttRemove_Forecolor.Name = "buttRemove_Forecolor"
        Me.buttRemove_Forecolor.Size = New System.Drawing.Size(26, 23)
        Me.buttRemove_Forecolor.TabIndex = 7296
        Me.buttRemove_Forecolor.ToolTip = "Màu chữ"
        '
        'TxtBackColor_Ghichu
        '
        Me.TxtBackColor_Ghichu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtBackColor_Ghichu.BackColor = System.Drawing.Color.White
        Me.TxtBackColor_Ghichu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtBackColor_Ghichu.ForeColor = System.Drawing.Color.Blue
        Me.TxtBackColor_Ghichu.Location = New System.Drawing.Point(54, 170)
        Me.TxtBackColor_Ghichu.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtBackColor_Ghichu.Name = "TxtBackColor_Ghichu"
        Me.TxtBackColor_Ghichu.Size = New System.Drawing.Size(35, 21)
        Me.TxtBackColor_Ghichu.TabIndex = 7295
        Me.TxtBackColor_Ghichu.TabStop = False
        Me.TxtBackColor_Ghichu.Tag = ""
        Me.TxtBackColor_Ghichu.Visible = False
        '
        'ButtBackColor_Choose
        '
        Me.ButtBackColor_Choose.Image = CType(resources.GetObject("ButtBackColor_Choose.Image"), System.Drawing.Image)
        Me.ButtBackColor_Choose.Location = New System.Drawing.Point(21, 168)
        Me.ButtBackColor_Choose.Name = "ButtBackColor_Choose"
        Me.ButtBackColor_Choose.Size = New System.Drawing.Size(26, 23)
        Me.ButtBackColor_Choose.TabIndex = 7294
        Me.ButtBackColor_Choose.ToolTip = "Màu nền"
        '
        'ButtForeColor_Choose
        '
        Me.ButtForeColor_Choose.Image = CType(resources.GetObject("ButtForeColor_Choose.Image"), System.Drawing.Image)
        Me.ButtForeColor_Choose.Location = New System.Drawing.Point(21, 139)
        Me.ButtForeColor_Choose.Name = "ButtForeColor_Choose"
        Me.ButtForeColor_Choose.Size = New System.Drawing.Size(26, 23)
        Me.ButtForeColor_Choose.TabIndex = 7293
        Me.ButtForeColor_Choose.ToolTip = "Màu chữ"
        '
        'TxtForeColor_Ghichu
        '
        Me.TxtForeColor_Ghichu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtForeColor_Ghichu.BackColor = System.Drawing.Color.White
        Me.TxtForeColor_Ghichu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtForeColor_Ghichu.ForeColor = System.Drawing.Color.Blue
        Me.TxtForeColor_Ghichu.Location = New System.Drawing.Point(52, 139)
        Me.TxtForeColor_Ghichu.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtForeColor_Ghichu.Name = "TxtForeColor_Ghichu"
        Me.TxtForeColor_Ghichu.Size = New System.Drawing.Size(37, 21)
        Me.TxtForeColor_Ghichu.TabIndex = 7292
        Me.TxtForeColor_Ghichu.TabStop = False
        Me.TxtForeColor_Ghichu.Tag = ""
        Me.TxtForeColor_Ghichu.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(18, 116)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 7291
        Me.Label2.Tag = "Type car"
        Me.Label2.Text = "Ghi chú"
        '
        'ChkMau_kho
        '
        Me.ChkMau_kho.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkMau_kho.AutoSize = True
        Me.ChkMau_kho.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkMau_kho.ForeColor = System.Drawing.Color.Red
        Me.ChkMau_kho.Location = New System.Drawing.Point(102, 93)
        Me.ChkMau_kho.Name = "ChkMau_kho"
        Me.ChkMau_kho.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ChkMau_kho.Size = New System.Drawing.Size(75, 17)
        Me.ChkMau_kho.TabIndex = 7298
        Me.ChkMau_kho.Text = "Màu khó"
        Me.ChkMau_kho.UseVisualStyleBackColor = True
        '
        'Frm_Mau_KX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(555, 256)
        Me.Controls.Add(Me.ChkMau_kho)
        Me.Controls.Add(Me.buttRemove_backcolor)
        Me.Controls.Add(Me.buttRemove_Forecolor)
        Me.Controls.Add(Me.TxtBackColor_Ghichu)
        Me.Controls.Add(Me.ButtBackColor_Choose)
        Me.Controls.Add(Me.ButtForeColor_Choose)
        Me.Controls.Add(Me.TxtForeColor_Ghichu)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtGhi_Chu)
        Me.Controls.Add(Me.TxtMa_Mau)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTen_Mau)
        Me.Controls.Add(Me.TxtMa_Kx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.LabMa_Xe)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Name = "Frm_Mau_KX"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Mau, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Mau, 0)
        Me.Controls.SetChildIndex(Me.txtGhi_Chu, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtForeColor_Ghichu, 0)
        Me.Controls.SetChildIndex(Me.ButtForeColor_Choose, 0)
        Me.Controls.SetChildIndex(Me.ButtBackColor_Choose, 0)
        Me.Controls.SetChildIndex(Me.TxtBackColor_Ghichu, 0)
        Me.Controls.SetChildIndex(Me.buttRemove_Forecolor, 0)
        Me.Controls.SetChildIndex(Me.buttRemove_backcolor, 0)
        Me.Controls.SetChildIndex(Me.ChkMau_kho, 0)
        CType(Me.TxtMa_Kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Mau.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Xe As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Kx As Cyber.SmLists.TxtLookup
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Mau As Cyber.SmLists.TxtLookup
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Mau As System.Windows.Forms.TextBox
    Friend WithEvents txtGhi_Chu As System.Windows.Forms.TextBox
    Friend WithEvents buttRemove_backcolor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents buttRemove_Forecolor As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtBackColor_Ghichu As System.Windows.Forms.TextBox
    Friend WithEvents ButtBackColor_Choose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ButtForeColor_Choose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents TxtForeColor_Ghichu As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CldChon_ForeColor As System.Windows.Forms.ColorDialog
    Friend WithEvents CldChon_Backcolor As System.Windows.Forms.ColorDialog
    Friend WithEvents ChkMau_kho As System.Windows.Forms.CheckBox

End Class
