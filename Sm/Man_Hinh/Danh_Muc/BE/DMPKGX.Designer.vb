<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMPKGX
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
        Me.TxtDien_giai = New System.Windows.Forms.TextBox()
        Me.Labten_TD12 = New System.Windows.Forms.Label()
        Me.TxtTen_Kx = New System.Windows.Forms.TextBox()
        Me.TxtMa_kx = New Cyber.SmLists.TxtLookup()
        Me.LblTk_DL = New System.Windows.Forms.Label()
        Me.TxtSo_luong = New ClsTextBox.txtSo_luong()
        Me.labSl_min = New System.Windows.Forms.Label()
        Me.Txtdvt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtMa_pk = New Cyber.SmLists.TxtLookup()
        Me.Txtten_pk = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_pk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(517, 136)
        Me.ButtExit.TabIndex = 6
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(415, 136)
        Me.ButtOK.TabIndex = 5
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(309, 142)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 146)
        Me.ChkActi.TabIndex = 9
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 126)
        Me.GroupBoxLine.Size = New System.Drawing.Size(615, 9)
        Me.GroupBoxLine.TabIndex = 7
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.Location = New System.Drawing.Point(7, 10)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(94, 14)
        Me.LabMa_TD1.TabIndex = 9
        Me.LabMa_TD1.Tag = "Code"
        Me.LabMa_TD1.Text = "Mã phụ kiện"
        '
        'TxtDien_giai
        '
        Me.TxtDien_giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_giai.Location = New System.Drawing.Point(110, 29)
        Me.TxtDien_giai.Name = "TxtDien_giai"
        Me.TxtDien_giai.Size = New System.Drawing.Size(505, 21)
        Me.TxtDien_giai.TabIndex = 1
        '
        'Labten_TD12
        '
        Me.Labten_TD12.Location = New System.Drawing.Point(7, 32)
        Me.Labten_TD12.Name = "Labten_TD12"
        Me.Labten_TD12.Size = New System.Drawing.Size(94, 15)
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
        Me.TxtTen_Kx.Location = New System.Drawing.Point(265, 56)
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
        Me.TxtMa_kx.Location = New System.Drawing.Point(110, 51)
        Me.TxtMa_kx.Name = "TxtMa_kx"
        Me.TxtMa_kx.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtMa_kx.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_kx.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_kx.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_kx.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_kx.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_kx.TabIndex = 2
        Me.TxtMa_kx.Table_Name = ""
        '
        'LblTk_DL
        '
        Me.LblTk_DL.Location = New System.Drawing.Point(7, 54)
        Me.LblTk_DL.Name = "LblTk_DL"
        Me.LblTk_DL.Size = New System.Drawing.Size(94, 15)
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
        Me.TxtSo_luong.Location = New System.Drawing.Point(110, 96)
        Me.TxtSo_luong.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TxtSo_luong.MaxWholeDigits = 14
        Me.TxtSo_luong.Name = "TxtSo_luong"
        Me.TxtSo_luong.RangeMax = 1.7976931348623157E+308R
        Me.TxtSo_luong.RangeMin = -1.7976931348623157E+308R
        Me.TxtSo_luong.Size = New System.Drawing.Size(149, 21)
        Me.TxtSo_luong.TabIndex = 4
        Me.TxtSo_luong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'labSl_min
        '
        Me.labSl_min.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.labSl_min.ForeColor = System.Drawing.Color.Navy
        Me.labSl_min.Location = New System.Drawing.Point(7, 99)
        Me.labSl_min.Name = "labSl_min"
        Me.labSl_min.Size = New System.Drawing.Size(94, 16)
        Me.labSl_min.TabIndex = 445
        Me.labSl_min.Tag = "Quantity"
        Me.labSl_min.Text = "Số lượng"
        '
        'Txtdvt
        '
        Me.Txtdvt.ForeColor = System.Drawing.Color.Navy
        Me.Txtdvt.Location = New System.Drawing.Point(110, 73)
        Me.Txtdvt.Name = "Txtdvt"
        Me.Txtdvt.Size = New System.Drawing.Size(149, 21)
        Me.Txtdvt.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(7, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 14)
        Me.Label1.TabIndex = 447
        Me.Label1.Tag = "Unit"
        Me.Label1.Text = "Đơn vị tính"
        '
        'TxtMa_pk
        '
        Me.TxtMa_pk._ActilookupPopup = False
        Me.TxtMa_pk.CyberActilookupPopup = True
        Me.TxtMa_pk.Dv_ListDetail = Nothing
        Me.TxtMa_pk.Dv_Master = Nothing
        Me.TxtMa_pk.FilterClient = ""
        Me.TxtMa_pk.FilterSQL = ""
        Me.TxtMa_pk.Location = New System.Drawing.Point(110, 7)
        Me.TxtMa_pk.Name = "TxtMa_pk"
        Me.TxtMa_pk.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.TxtMa_pk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_pk.Properties.Appearance.Options.UseBackColor = True
        Me.TxtMa_pk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_pk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_pk.Size = New System.Drawing.Size(149, 20)
        Me.TxtMa_pk.TabIndex = 0
        Me.TxtMa_pk.Table_Name = ""
        '
        'Txtten_pk
        '
        Me.Txtten_pk.BackColor = System.Drawing.Color.White
        Me.Txtten_pk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_pk.Enabled = False
        Me.Txtten_pk.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_pk.Location = New System.Drawing.Point(265, 9)
        Me.Txtten_pk.Name = "Txtten_pk"
        Me.Txtten_pk.ReadOnly = True
        Me.Txtten_pk.Size = New System.Drawing.Size(350, 14)
        Me.Txtten_pk.TabIndex = 449
        Me.Txtten_pk.TabStop = False
        '
        'DMPKGX
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(619, 169)
        Me.Controls.Add(Me.Txtten_pk)
        Me.Controls.Add(Me.TxtMa_pk)
        Me.Controls.Add(Me.Txtdvt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSo_luong)
        Me.Controls.Add(Me.labSl_min)
        Me.Controls.Add(Me.LblTk_DL)
        Me.Controls.Add(Me.TxtMa_kx)
        Me.Controls.Add(Me.TxtTen_Kx)
        Me.Controls.Add(Me.TxtDien_giai)
        Me.Controls.Add(Me.Labten_TD12)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMPKGX"
        Me.Text = "Danh mục phụ kiện giao xe"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.Labten_TD12, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_giai, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Kx, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_kx, 0)
        Me.Controls.SetChildIndex(Me.LblTk_DL, 0)
        Me.Controls.SetChildIndex(Me.labSl_min, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_luong, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Txtdvt, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_pk, 0)
        Me.Controls.SetChildIndex(Me.Txtten_pk, 0)
        CType(Me.TxtMa_kx.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_pk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_giai As System.Windows.Forms.TextBox
    Friend WithEvents Labten_TD12 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Kx As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_kx As Cyber.SmLists.TxtLookup
    Friend WithEvents LblTk_DL As System.Windows.Forms.Label
    Friend WithEvents TxtSo_luong As ClsTextBox.txtSo_luong
    Friend WithEvents labSl_min As System.Windows.Forms.Label
    Friend WithEvents Txtdvt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_pk As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_pk As System.Windows.Forms.TextBox

End Class
