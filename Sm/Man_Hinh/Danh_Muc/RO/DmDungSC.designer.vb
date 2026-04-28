<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DmDungSC
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DmDungSC))
        Me.TxtPost_UP = New System.Windows.Forms.TextBox()
        Me.Labten_mau2 = New System.Windows.Forms.Label()
        Me.TxtTen_dung = New System.Windows.Forms.TextBox()
        Me.LabMa_mau = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtMa_dung = New System.Windows.Forms.TextBox()
        Me.ChkIsKhoang = New System.Windows.Forms.CheckBox()
        Me.ChkisEndAll_KTV = New System.Windows.Forms.CheckBox()
        Me.ChkDefault = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ButtClear = New System.Windows.Forms.Button()
        Me.ButtColor = New System.Windows.Forms.Button()
        Me.TxtBackcolor_Test = New System.Windows.Forms.TextBox()
        Me.TxtBackcolor = New System.Windows.Forms.TextBox()
        Me.LabBackcolor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(494, 141)
        Me.ButtExit.TabIndex = 14
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(392, 141)
        Me.ButtOK.TabIndex = 13
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(286, 147)
        Me.TxtMa_Dvcs.TabIndex = 12
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(107, 151)
        Me.ChkActi.TabIndex = 11
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 126)
        Me.GroupBoxLine.Size = New System.Drawing.Size(592, 9)
        Me.GroupBoxLine.TabIndex = 10
        '
        'TxtPost_UP
        '
        Me.TxtPost_UP.ForeColor = System.Drawing.Color.Navy
        Me.TxtPost_UP.Location = New System.Drawing.Point(107, 79)
        Me.TxtPost_UP.Name = "TxtPost_UP"
        Me.TxtPost_UP.Size = New System.Drawing.Size(149, 21)
        Me.TxtPost_UP.TabIndex = 6
        '
        'Labten_mau2
        '
        Me.Labten_mau2.Location = New System.Drawing.Point(10, 83)
        Me.Labten_mau2.Name = "Labten_mau2"
        Me.Labten_mau2.Size = New System.Drawing.Size(89, 16)
        Me.Labten_mau2.TabIndex = 8
        Me.Labten_mau2.Tag = "Update Post HDK"
        Me.Labten_mau2.Text = "Update Post HDK"
        Me.ToolTip1.SetToolTip(Me.Labten_mau2, "Update trạng thái lệnh" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Khai báo trạng thái lệnh tức mã Post HDK. Sau khi kết th" & _
                "úc " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "trạng thái tiến độ tự động Update lại trạng thái lệnh" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Update ma post HDK)" & _
                "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'TxtTen_dung
        '
        Me.TxtTen_dung.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_dung.Location = New System.Drawing.Point(107, 32)
        Me.TxtTen_dung.Name = "TxtTen_dung"
        Me.TxtTen_dung.Size = New System.Drawing.Size(482, 21)
        Me.TxtTen_dung.TabIndex = 1
        '
        'LabMa_mau
        '
        Me.LabMa_mau.Location = New System.Drawing.Point(10, 13)
        Me.LabMa_mau.Name = "LabMa_mau"
        Me.LabMa_mau.Size = New System.Drawing.Size(77, 16)
        Me.LabMa_mau.TabIndex = 19
        Me.LabMa_mau.Tag = "Stop code"
        Me.LabMa_mau.Text = "Mã dừng"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 20
        Me.Label1.Tag = "Name"
        Me.Label1.Text = "Tên dừng"
        '
        'txtMa_dung
        '
        Me.txtMa_dung.ForeColor = System.Drawing.Color.Navy
        Me.txtMa_dung.Location = New System.Drawing.Point(107, 9)
        Me.txtMa_dung.Name = "txtMa_dung"
        Me.txtMa_dung.Size = New System.Drawing.Size(149, 21)
        Me.txtMa_dung.TabIndex = 0
        '
        'ChkIsKhoang
        '
        Me.ChkIsKhoang.AutoSize = True
        Me.ChkIsKhoang.Location = New System.Drawing.Point(107, 106)
        Me.ChkIsKhoang.Name = "ChkIsKhoang"
        Me.ChkIsKhoang.Size = New System.Drawing.Size(107, 17)
        Me.ChkIsKhoang.TabIndex = 7
        Me.ChkIsKhoang.Text = "Located in cavity"
        Me.ToolTip1.SetToolTip(Me.ChkIsKhoang, resources.GetString("ChkIsKhoang.ToolTip"))
        Me.ChkIsKhoang.UseVisualStyleBackColor = True
        '
        'ChkisEndAll_KTV
        '
        Me.ChkisEndAll_KTV.AutoSize = True
        Me.ChkisEndAll_KTV.Location = New System.Drawing.Point(267, 106)
        Me.ChkisEndAll_KTV.Name = "ChkisEndAll_KTV"
        Me.ChkisEndAll_KTV.Size = New System.Drawing.Size(118, 17)
        Me.ChkisEndAll_KTV.TabIndex = 8
        Me.ChkisEndAll_KTV.Tag = "Finish"
        Me.ChkisEndAll_KTV.Text = "Kết thúc tất cả KTV"
        Me.ToolTip1.SetToolTip(Me.ChkisEndAll_KTV, resources.GetString("ChkisEndAll_KTV.ToolTip"))
        Me.ChkisEndAll_KTV.UseVisualStyleBackColor = True
        '
        'ChkDefault
        '
        Me.ChkDefault.AutoSize = True
        Me.ChkDefault.Location = New System.Drawing.Point(474, 106)
        Me.ChkDefault.Name = "ChkDefault"
        Me.ChkDefault.Size = New System.Drawing.Size(68, 17)
        Me.ChkDefault.TabIndex = 9
        Me.ChkDefault.Tag = "Default"
        Me.ChkDefault.Text = "Mặc định"
        Me.ToolTip1.SetToolTip(Me.ChkDefault, "Mặc định:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " - Mức trạng thái được chọn đầu tiên")
        Me.ChkDefault.UseVisualStyleBackColor = True
        '
        'ButtClear
        '
        Me.ButtClear.Location = New System.Drawing.Point(536, 55)
        Me.ButtClear.Name = "ButtClear"
        Me.ButtClear.Size = New System.Drawing.Size(54, 23)
        Me.ButtClear.TabIndex = 5
        Me.ButtClear.TabStop = False
        Me.ButtClear.Tag = "Clear"
        Me.ButtClear.Text = "Clear"
        Me.ButtClear.UseVisualStyleBackColor = True
        '
        'ButtColor
        '
        Me.ButtColor.Location = New System.Drawing.Point(474, 55)
        Me.ButtColor.Name = "ButtColor"
        Me.ButtColor.Size = New System.Drawing.Size(54, 23)
        Me.ButtColor.TabIndex = 4
        Me.ButtColor.TabStop = False
        Me.ButtColor.Tag = "Color"
        Me.ButtColor.Text = "Color"
        Me.ButtColor.UseVisualStyleBackColor = True
        '
        'TxtBackcolor_Test
        '
        Me.TxtBackcolor_Test.ForeColor = System.Drawing.Color.Navy
        Me.TxtBackcolor_Test.Location = New System.Drawing.Point(263, 56)
        Me.TxtBackcolor_Test.Name = "TxtBackcolor_Test"
        Me.TxtBackcolor_Test.Size = New System.Drawing.Size(197, 21)
        Me.TxtBackcolor_Test.TabIndex = 3
        Me.TxtBackcolor_Test.TabStop = False
        '
        'TxtBackcolor
        '
        Me.TxtBackcolor.ForeColor = System.Drawing.Color.Navy
        Me.TxtBackcolor.Location = New System.Drawing.Point(107, 56)
        Me.TxtBackcolor.Name = "TxtBackcolor"
        Me.TxtBackcolor.Size = New System.Drawing.Size(149, 21)
        Me.TxtBackcolor.TabIndex = 2
        Me.TxtBackcolor.TabStop = False
        '
        'LabBackcolor
        '
        Me.LabBackcolor.Location = New System.Drawing.Point(10, 60)
        Me.LabBackcolor.Name = "LabBackcolor"
        Me.LabBackcolor.Size = New System.Drawing.Size(96, 16)
        Me.LabBackcolor.TabIndex = 196
        Me.LabBackcolor.Tag = "Backcolor"
        Me.LabBackcolor.Text = "Backcolor"
        '
        'DmDungSC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 174)
        Me.Controls.Add(Me.ButtClear)
        Me.Controls.Add(Me.ButtColor)
        Me.Controls.Add(Me.TxtBackcolor_Test)
        Me.Controls.Add(Me.TxtBackcolor)
        Me.Controls.Add(Me.LabBackcolor)
        Me.Controls.Add(Me.ChkDefault)
        Me.Controls.Add(Me.ChkisEndAll_KTV)
        Me.Controls.Add(Me.ChkIsKhoang)
        Me.Controls.Add(Me.txtMa_dung)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtPost_UP)
        Me.Controls.Add(Me.Labten_mau2)
        Me.Controls.Add(Me.TxtTen_dung)
        Me.Controls.Add(Me.LabMa_mau)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DmDungSC"
        Me.Text = "Danh mục Quận/Huyện"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_dung, 0)
        Me.Controls.SetChildIndex(Me.Labten_mau2, 0)
        Me.Controls.SetChildIndex(Me.TxtPost_UP, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtMa_dung, 0)
        Me.Controls.SetChildIndex(Me.ChkIsKhoang, 0)
        Me.Controls.SetChildIndex(Me.ChkisEndAll_KTV, 0)
        Me.Controls.SetChildIndex(Me.ChkDefault, 0)
        Me.Controls.SetChildIndex(Me.LabBackcolor, 0)
        Me.Controls.SetChildIndex(Me.TxtBackcolor, 0)
        Me.Controls.SetChildIndex(Me.TxtBackcolor_Test, 0)
        Me.Controls.SetChildIndex(Me.ButtColor, 0)
        Me.Controls.SetChildIndex(Me.ButtClear, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtPost_UP As System.Windows.Forms.TextBox
    Friend WithEvents Labten_mau2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_dung As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_mau As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMa_dung As System.Windows.Forms.TextBox
    Friend WithEvents ChkIsKhoang As System.Windows.Forms.CheckBox
    Friend WithEvents ChkisEndAll_KTV As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDefault As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ButtClear As System.Windows.Forms.Button
    Friend WithEvents ButtColor As System.Windows.Forms.Button
    Friend WithEvents TxtBackcolor_Test As System.Windows.Forms.TextBox
    Friend WithEvents TxtBackcolor As System.Windows.Forms.TextBox
    Friend WithEvents LabBackcolor As System.Windows.Forms.Label

End Class
