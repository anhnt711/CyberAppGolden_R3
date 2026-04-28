<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVOD_XLTM_F4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVOD_XLTM_F4))
        Me.TxtNgay_GQ = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtKet_Qua = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNgay_Lap = New Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtUser_Id = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 143)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(601, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(401, 153)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 3
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(503, 153)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 4
        '
        'TxtNgay_GQ
        '
        Me.TxtNgay_GQ.Flags = 0
        Me.TxtNgay_GQ.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_GQ.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_GQ.IsAllowResize = False
        Me.TxtNgay_GQ.Location = New System.Drawing.Point(93, 9)
        Me.TxtNgay_GQ.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_GQ.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_GQ.MaxLength = 10
        Me.TxtNgay_GQ.Name = "TxtNgay_GQ"
        Me.TxtNgay_GQ.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_GQ.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_GQ.ShowDayBeforeMonth = False
        Me.TxtNgay_GQ.Size = New System.Drawing.Size(128, 21)
        Me.TxtNgay_GQ.TabIndex = 0
        Me.TxtNgay_GQ.Text = "__/__/____ __:__"
        Me.TxtNgay_GQ.Value = CType(resources.GetObject("TxtNgay_GQ.Value"), Object)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label2.Location = New System.Drawing.Point(8, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 13)
        Me.Label2.TabIndex = 402
        Me.Label2.Tag = "Moment"
        Me.Label2.Text = "Thời điểm xử lý"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDien_Giai.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(93, 33)
        Me.TxtDien_Giai.Multiline = True
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(510, 49)
        Me.TxtDien_Giai.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(8, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 402
        Me.Label1.Tag = "Content"
        Me.Label1.Text = "Nội dung xử lý"
        '
        'TxtKet_Qua
        '
        Me.TxtKet_Qua.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtKet_Qua.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtKet_Qua.ForeColor = System.Drawing.Color.Navy
        Me.TxtKet_Qua.Location = New System.Drawing.Point(93, 85)
        Me.TxtKet_Qua.Multiline = True
        Me.TxtKet_Qua.Name = "TxtKet_Qua"
        Me.TxtKet_Qua.Size = New System.Drawing.Size(510, 49)
        Me.TxtKet_Qua.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(8, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 404
        Me.Label3.Tag = "Result"
        Me.Label3.Text = "Kết quả"
        '
        'TxtNgay_Lap
        '
        Me.TxtNgay_Lap.Enabled = False
        Me.TxtNgay_Lap.Flags = 0
        Me.TxtNgay_Lap.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNgay_Lap.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Lap.IsAllowResize = False
        Me.TxtNgay_Lap.Location = New System.Drawing.Point(475, 9)
        Me.TxtNgay_Lap.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtNgay_Lap.MaskDate = "dd/MM/yyyy HH:mm"
        Me.TxtNgay_Lap.MaxLength = 10
        Me.TxtNgay_Lap.Name = "TxtNgay_Lap"
        Me.TxtNgay_Lap.RangeMax = New Date(2079, 6, 5, 0, 0, 0, 0)
        Me.TxtNgay_Lap.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Lap.ShowDayBeforeMonth = False
        Me.TxtNgay_Lap.Size = New System.Drawing.Size(128, 21)
        Me.TxtNgay_Lap.TabIndex = 405
        Me.TxtNgay_Lap.Text = "__/__/____ __:__"
        Me.TxtNgay_Lap.Value = CType(resources.GetObject("TxtNgay_Lap.Value"), Object)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(390, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 406
        Me.Label4.Tag = "Create date"
        Me.Label4.Text = "Ngày tạo"
        '
        'TxtUser_Id
        '
        Me.TxtUser_Id.Location = New System.Drawing.Point(93, 158)
        Me.TxtUser_Id.Name = "TxtUser_Id"
        Me.TxtUser_Id.Size = New System.Drawing.Size(54, 20)
        Me.TxtUser_Id.TabIndex = 407
        Me.TxtUser_Id.Visible = False
        '
        'FrmVOD_XLKN_F4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(605, 207)
        Me.Controls.Add(Me.TxtUser_Id)
        Me.Controls.Add(Me.TxtNgay_Lap)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtKet_Qua)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.TxtNgay_GQ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmVOD_XLKN_F4"
        Me.Text = "Sửa/Tạo mới chi tiết"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_GQ, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtKet_Qua, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Lap, 0)
        Me.Controls.SetChildIndex(Me.TxtUser_Id, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtNgay_GQ As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Giai As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtKet_Qua As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNgay_Lap As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtUser_Id As System.Windows.Forms.TextBox

End Class
