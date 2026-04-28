<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRMDMTL
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
        Me.LabMa_LHTT = New System.Windows.Forms.Label()
        Me.TxtMa_Tl = New System.Windows.Forms.TextBox()
        Me.TxtTen_TL = New System.Windows.Forms.TextBox()
        Me.LabTen_LHTT = New System.Windows.Forms.Label()
        Me.TxtTen_Tl2 = New System.Windows.Forms.TextBox()
        Me.LabTen_LHTT2 = New System.Windows.Forms.Label()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.TxtTen_Ch = New System.Windows.Forms.TextBox()
        Me.TxtMa_Ch = New Cyber.SmLists.TxtLookup()
        Me.ChkNgam_Dinh = New System.Windows.Forms.CheckBox()
        Me.TxtDiem = New ClsTextBox.txtTien_NT()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.TxtMa_Ch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(899, 199)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 10
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(763, 199)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 9
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(621, 207)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Dvcs.TabIndex = 8
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(135, 212)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 7
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 186)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1029, 12)
        Me.GroupBoxLine.TabIndex = 6
        '
        'LabMa_LHTT
        '
        Me.LabMa_LHTT.Location = New System.Drawing.Point(12, 38)
        Me.LabMa_LHTT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_LHTT.Name = "LabMa_LHTT"
        Me.LabMa_LHTT.Size = New System.Drawing.Size(123, 21)
        Me.LabMa_LHTT.TabIndex = 10
        Me.LabMa_LHTT.Tag = "Answer code"
        Me.LabMa_LHTT.Text = "Mã trả lời"
        '
        'TxtMa_Tl
        '
        Me.TxtMa_Tl.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Tl.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Tl.Location = New System.Drawing.Point(136, 33)
        Me.TxtMa_Tl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Tl.Name = "TxtMa_Tl"
        Me.TxtMa_Tl.Size = New System.Drawing.Size(197, 24)
        Me.TxtMa_Tl.TabIndex = 1
        '
        'TxtTen_TL
        '
        Me.TxtTen_TL.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_TL.Location = New System.Drawing.Point(136, 61)
        Me.TxtTen_TL.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_TL.Name = "TxtTen_TL"
        Me.TxtTen_TL.Size = New System.Drawing.Size(895, 24)
        Me.TxtTen_TL.TabIndex = 2
        '
        'LabTen_LHTT
        '
        Me.LabTen_LHTT.Location = New System.Drawing.Point(12, 67)
        Me.LabTen_LHTT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTen_LHTT.Name = "LabTen_LHTT"
        Me.LabTen_LHTT.Size = New System.Drawing.Size(123, 21)
        Me.LabTen_LHTT.TabIndex = 12
        Me.LabTen_LHTT.Tag = "Answer name"
        Me.LabTen_LHTT.Text = "Tên trả lời"
        '
        'TxtTen_Tl2
        '
        Me.TxtTen_Tl2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Tl2.Location = New System.Drawing.Point(136, 90)
        Me.TxtTen_Tl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Tl2.Name = "TxtTen_Tl2"
        Me.TxtTen_Tl2.Size = New System.Drawing.Size(895, 24)
        Me.TxtTen_Tl2.TabIndex = 3
        '
        'LabTen_LHTT2
        '
        Me.LabTen_LHTT2.Location = New System.Drawing.Point(12, 95)
        Me.LabTen_LHTT2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTen_LHTT2.Name = "LabTen_LHTT2"
        Me.LabTen_LHTT2.Size = New System.Drawing.Size(123, 21)
        Me.LabTen_LHTT2.TabIndex = 14
        Me.LabTen_LHTT2.Tag = "English name"
        Me.LabTen_LHTT2.Text = "Tên tiếng anh"
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(12, 10)
        Me.LabMa_Nh1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(123, 21)
        Me.LabMa_Nh1.TabIndex = 24
        Me.LabMa_Nh1.Tag = "Question code"
        Me.LabMa_Nh1.Text = "Mã câu hỏi"
        '
        'TxtTen_Ch
        '
        Me.TxtTen_Ch.BackColor = System.Drawing.Color.White
        Me.TxtTen_Ch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtTen_Ch.Enabled = False
        Me.TxtTen_Ch.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Ch.Location = New System.Drawing.Point(337, 9)
        Me.TxtTen_Ch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Ch.Name = "TxtTen_Ch"
        Me.TxtTen_Ch.ReadOnly = True
        Me.TxtTen_Ch.Size = New System.Drawing.Size(692, 17)
        Me.TxtTen_Ch.TabIndex = 23
        Me.TxtTen_Ch.TabStop = False
        '
        'TxtMa_Ch
        '
        Me.TxtMa_Ch._ActilookupPopup = False
        Me.TxtMa_Ch.CyberActilookupPopup = True
        Me.TxtMa_Ch.Dv_ListDetail = Nothing
        Me.TxtMa_Ch.Dv_Master = Nothing
        Me.TxtMa_Ch.FilterClient = ""
        Me.TxtMa_Ch.FilterSQL = ""
        Me.TxtMa_Ch.Location = New System.Drawing.Point(136, 5)
        Me.TxtMa_Ch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Ch.Name = "TxtMa_Ch"
        Me.TxtMa_Ch.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Ch.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Ch.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Ch.Size = New System.Drawing.Size(199, 22)
        Me.TxtMa_Ch.TabIndex = 0
        Me.TxtMa_Ch.Table_Name = ""
        '
        'ChkNgam_Dinh
        '
        Me.ChkNgam_Dinh.AutoSize = True
        Me.ChkNgam_Dinh.Location = New System.Drawing.Point(136, 156)
        Me.ChkNgam_Dinh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNgam_Dinh.Name = "ChkNgam_Dinh"
        Me.ChkNgam_Dinh.Size = New System.Drawing.Size(96, 21)
        Me.ChkNgam_Dinh.TabIndex = 5
        Me.ChkNgam_Dinh.Tag = "Default"
        Me.ChkNgam_Dinh.Text = "Ngầm định"
        Me.ChkNgam_Dinh.UseVisualStyleBackColor = True
        '
        'TxtDiem
        '
        Me.TxtDiem.AllowNegative = True
        Me.TxtDiem.BackColor = System.Drawing.Color.White
        Me.TxtDiem.Enabled = False
        Me.TxtDiem.Flags = 7680
        Me.TxtDiem.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtDiem.ForeColor = System.Drawing.Color.Navy
        Me.TxtDiem.InputMask = " ###"
        Me.TxtDiem.Location = New System.Drawing.Point(136, 120)
        Me.TxtDiem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDiem.MaxWholeDigits = 2
        Me.TxtDiem.Name = "TxtDiem"
        Me.TxtDiem.RangeMax = 1.7976931348623157E+308R
        Me.TxtDiem.RangeMin = -1.7976931348623157E+308R
        Me.TxtDiem.Size = New System.Drawing.Size(196, 24)
        Me.TxtDiem.TabIndex = 4
        Me.TxtDiem.Text = "0"
        Me.TxtDiem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(12, 124)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 21)
        Me.Label1.TabIndex = 440
        Me.Label1.Tag = "Scores"
        Me.Label1.Text = "Điểm"
        '
        'CRMDMTL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(1035, 242)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDiem)
        Me.Controls.Add(Me.ChkNgam_Dinh)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.TxtTen_Ch)
        Me.Controls.Add(Me.TxtMa_Ch)
        Me.Controls.Add(Me.TxtTen_Tl2)
        Me.Controls.Add(Me.LabTen_LHTT2)
        Me.Controls.Add(Me.TxtTen_TL)
        Me.Controls.Add(Me.LabTen_LHTT)
        Me.Controls.Add(Me.TxtMa_Tl)
        Me.Controls.Add(Me.LabMa_LHTT)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "CRMDMTL"
        Me.Text = "Danh mục loại hình thanh toán"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_LHTT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Tl, 0)
        Me.Controls.SetChildIndex(Me.LabTen_LHTT, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_TL, 0)
        Me.Controls.SetChildIndex(Me.LabTen_LHTT2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Tl2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Ch, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Ch, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.ChkNgam_Dinh, 0)
        Me.Controls.SetChildIndex(Me.TxtDiem, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.TxtMa_Ch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_LHTT As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Tl As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_TL As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_LHTT As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Tl2 As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_LHTT2 As System.Windows.Forms.Label
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Ch As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Ch As Cyber.SmLists.TxtLookup
    Friend WithEvents ChkNgam_Dinh As System.Windows.Forms.CheckBox
    Friend WithEvents TxtDiem As ClsTextBox.txtTien_NT
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
