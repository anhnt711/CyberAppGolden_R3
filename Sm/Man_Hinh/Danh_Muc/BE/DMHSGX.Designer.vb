<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMHSGX
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
        Me.LabMa_TD1 = New System.Windows.Forms.Label()
        Me.TxtMa_HSGX = New System.Windows.Forms.TextBox()
        Me.TxtTen_HSGX = New System.Windows.Forms.TextBox()
        Me.LabTen_TD1 = New System.Windows.Forms.Label()
        Me.TxtDien_giai = New System.Windows.Forms.TextBox()
        Me.Labten_TD12 = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_kx = New Cyber.SmLists.TxtLookup()
        Me.LblTk_DL = New System.Windows.Forms.Label()
        Me.TxtSo_luong = New ClsTextBox.txtSo_luong()
        Me.labSl_min = New System.Windows.Forms.Label()
        Me.TxtDvt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(517, 149)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(415, 149)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(309, 155)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 159)
        Me.ChkActi.TabIndex = 9
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 139)
        Me.GroupBoxLine.Size = New System.Drawing.Size(615, 9)
        Me.GroupBoxLine.TabIndex = 7
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.Location = New System.Drawing.Point(7, 10)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(94, 15)
        Me.LabMa_TD1.TabIndex = 9
        Me.LabMa_TD1.Tag = "Code"
        Me.LabMa_TD1.Text = "Mã hồ sơ giao xe"
        '
        'TxtMa_HSGX
        '
        Me.TxtMa_HSGX.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_HSGX.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_HSGX.Location = New System.Drawing.Point(110, 7)
        Me.TxtMa_HSGX.Name = "TxtMa_HSGX"
        Me.TxtMa_HSGX.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_HSGX.TabIndex = 0
        '
        'TxtTen_HSGX
        '
        Me.TxtTen_HSGX.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_HSGX.Location = New System.Drawing.Point(110, 30)
        Me.TxtTen_HSGX.Name = "TxtTen_HSGX"
        Me.TxtTen_HSGX.Size = New System.Drawing.Size(505, 21)
        Me.TxtTen_HSGX.TabIndex = 1
        '
        'LabTen_TD1
        '
        Me.LabTen_TD1.Location = New System.Drawing.Point(7, 33)
        Me.LabTen_TD1.Name = "LabTen_TD1"
        Me.LabTen_TD1.Size = New System.Drawing.Size(94, 15)
        Me.LabTen_TD1.TabIndex = 8
        Me.LabTen_TD1.Tag = "Name"
        Me.LabTen_TD1.Text = "Tên hồ sơ giao xe"
        '
        'TxtDien_giai
        '
        Me.TxtDien_giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_giai.Location = New System.Drawing.Point(110, 53)
        Me.TxtDien_giai.Name = "TxtDien_giai"
        Me.TxtDien_giai.Size = New System.Drawing.Size(505, 21)
        Me.TxtDien_giai.TabIndex = 2
        '
        'Labten_TD12
        '
        Me.Labten_TD12.Location = New System.Drawing.Point(7, 53)
        Me.Labten_TD12.Name = "Labten_TD12"
        Me.Labten_TD12.Size = New System.Drawing.Size(94, 18)
        Me.Labten_TD12.TabIndex = 10
        Me.Labten_TD12.Tag = "Explain"
        Me.Labten_TD12.Text = "Diễn giải"
        '
        'TxtTen_Kx
        '
        Me.TxtTen_Kx.BackColor = System.Drawing.Color.White
        Me.TxtTen_Kx.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Kx.Enabled = False
        Me.TxtTen_Kx.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Kx.Location = New System.Drawing.Point(265, 80)
        Me.TxtTen_Kx.Name = "TxtTen_Kx"
        Me.TxtTen_Kx.ReadOnly = True
        Me.TxtTen_Kx.Size = New System.Drawing.Size(350, 14)
        Me.TxtTen_Kx.TabIndex = 39
        Me.TxtTen_Kx.TabStop = False
        '
        'TxtMa_kx
        '
        Me.TxtMa_kx._ActilookupPopup = False
        Me.TxtMa_kx.CyberActilookupPopup = True
        Me.TxtMa_kx.Dv_ListDetail = Nothing
        Me.TxtMa_kx.Dv_Master = Nothing
        Me.TxtMa_kx.FilterClient = ""
        Me.TxtMa_kx.FilterSQL = ""
        Me.TxtMa_kx.Location = New System.Drawing.Point(110, 75)
        Me.TxtMa_kx.Name = "TxtMa_kx"
        Me.TxtMa_kx.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtMa_kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kx.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kx.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_kx.TabIndex = 3
        Me.TxtMa_kx.Table_Name = ""
        '
        'LblTk_DL
        '
        Me.LblTk_DL.Location = New System.Drawing.Point(7, 78)
        Me.LblTk_DL.Name = "LblTk_DL"
        Me.LblTk_DL.Size = New System.Drawing.Size(100, 15)
        Me.LblTk_DL.TabIndex = 41
        Me.LblTk_DL.Tag = "Model car"
        Me.LblTk_DL.Text = "Mã kiểu xe"
        '
        'TxtSo_luong
        '
        Me.TxtSo_luong.AllowNegative = True
        Me.TxtSo_luong.Flags = 7680
        Me.TxtSo_luong.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtSo_luong.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_luong.InputMask = "### ### ### ###.#0"
        Me.TxtSo_luong.Location = New System.Drawing.Point(110, 120)
        Me.TxtSo_luong.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSo_luong.MaxWholeDigits = 14
        Me.TxtSo_luong.Name = "TxtSo_luong"
        Me.TxtSo_luong.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_luong.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_luong.Size = New System.Drawing.Size(149, 21)
        Me.TxtSo_luong.TabIndex = 5
        Me.TxtSo_luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labSl_min
        '
        Me.labSl_min.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.labSl_min.ForeColor = System.Drawing.Color.Navy
        Me.labSl_min.Location = New System.Drawing.Point(7, 120)
        Me.labSl_min.Name = "labSl_min"
        Me.labSl_min.Size = New System.Drawing.Size(81, 18)
        Me.labSl_min.TabIndex = 445
        Me.labSl_min.Tag = "Quantity"
        Me.labSl_min.Text = "Số lượng"
        '
        'TxtDvt
        '
        Me.TxtDvt.ForeColor = System.Drawing.Color.Navy
        Me.TxtDvt.Location = New System.Drawing.Point(110, 97)
        Me.TxtDvt.Name = "TxtDvt"
        Me.TxtDvt.Size = New System.Drawing.Size(149, 21)
        Me.TxtDvt.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 22)
        Me.Label1.TabIndex = 447
        Me.Label1.Tag = "Unit"
        Me.Label1.Text = "Đơn vị tính"
        '
        'DMHSGX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(619, 182)
        Me.Controls.Add(Me.TxtDvt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSo_luong)
        Me.Controls.Add(Me.labSl_min)
        Me.Controls.Add(Me.LblTk_DL)
        Me.Controls.Add(Me.TxtMa_kx)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtDien_giai)
        Me.Controls.Add(Me.Labten_TD12)
        Me.Controls.Add(Me.TxtTen_HSGX)
        Me.Controls.Add(Me.LabTen_TD1)
        Me.Controls.Add(Me.TxtMa_HSGX)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMHSGX"
        Me.Text = "Danh mục hồ sơ giao xe"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_HSGX, 0)
        Me.Controls.SetChildIndex(Me.LabTen_TD1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_HSGX, 0)
        Me.Controls.SetChildIndex(Me.Labten_TD12, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_giai, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kx, 0)
        Me.Controls.SetChildIndex(Me.LblTk_DL, 0)
        Me.Controls.SetChildIndex(Me.labSl_min, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_luong, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtDvt, 0)
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_HSGX As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_HSGX As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_giai As System.Windows.Forms.TextBox
    Friend WithEvents Labten_TD12 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kx As Cyber.SmLists.TxtLookup
    Friend WithEvents LblTk_DL As System.Windows.Forms.Label
    Friend WithEvents TxtSo_luong As ClsTextBox.txtSo_luong
    Friend WithEvents labSl_min As System.Windows.Forms.Label
    Friend WithEvents TxtDvt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
