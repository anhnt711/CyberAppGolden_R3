<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLTC1ND
    Inherits Cyber.From.FilterReport

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
        Me.LabM_Thang = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.CbbM_Thang = New System.Windows.Forms.ComboBox()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RBU02 = New System.Windows.Forms.RadioButton()
        Me.RBU01 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbDmMauBc = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(656, 199)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 9
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 148)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(653, 25)
        Me.CBBMa_Dvcs.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 152)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(517, 199)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 8
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 123)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 119)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 5
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(292, 119)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 6
        '
        'LabM_Thang
        '
        Me.LabM_Thang.AutoSize = True
        Me.LabM_Thang.Location = New System.Drawing.Point(13, 16)
        Me.LabM_Thang.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_Thang.Name = "LabM_Thang"
        Me.LabM_Thang.Size = New System.Drawing.Size(47, 17)
        Me.LabM_Thang.TabIndex = 13
        Me.LabM_Thang.Tag = "Month"
        Me.LabM_Thang.Text = "Tháng"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 177)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(785, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'CbbM_Thang
        '
        Me.CbbM_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang.FormattingEnabled = True
        Me.CbbM_Thang.Location = New System.Drawing.Point(127, 12)
        Me.CbbM_Thang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang.Name = "CbbM_Thang"
        Me.CbbM_Thang.Size = New System.Drawing.Size(231, 25)
        Me.CbbM_Thang.TabIndex = 0
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(127, 44)
        Me.CbbM_Nam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(231, 25)
        Me.CbbM_Nam.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'RBU02
        '
        Me.RBU02.AutoSize = True
        Me.RBU02.Location = New System.Drawing.Point(391, 44)
        Me.RBU02.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBU02.Name = "RBU02"
        Me.RBU02.Size = New System.Drawing.Size(112, 21)
        Me.RBU02.TabIndex = 4
        Me.RBU02.TabStop = True
        Me.RBU02.Tag = "Shorten form"
        Me.RBU02.Text = "Dạng rút gọn"
        Me.RBU02.UseVisualStyleBackColor = True
        '
        'RBU01
        '
        Me.RBU01.AutoSize = True
        Me.RBU01.Location = New System.Drawing.Point(391, 12)
        Me.RBU01.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RBU01.Name = "RBU01"
        Me.RBU01.Size = New System.Drawing.Size(109, 21)
        Me.RBU01.TabIndex = 3
        Me.RBU01.TabStop = True
        Me.RBU01.Tag = "Full Form"
        Me.RBU01.Text = "Dạng đầy đủ"
        Me.RBU01.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 358
        Me.Label3.Tag = "Form"
        Me.Label3.Text = "Mẫu theo"
        '
        'CbbDmMauBc
        '
        Me.CbbDmMauBc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbDmMauBc.ForeColor = System.Drawing.Color.Navy
        Me.CbbDmMauBc.FormattingEnabled = True
        Me.CbbDmMauBc.Location = New System.Drawing.Point(127, 77)
        Me.CbbDmMauBc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbDmMauBc.Name = "CbbDmMauBc"
        Me.CbbDmMauBc.Size = New System.Drawing.Size(653, 25)
        Me.CbbDmMauBc.TabIndex = 2
        '
        'GLTC1ND
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(795, 268)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbbDmMauBc)
        Me.Controls.Add(Me.RBU02)
        Me.Controls.Add(Me.RBU01)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Thang)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "GLTC1ND"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.LabM_Thang, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.RBU01, 0)
        Me.Controls.SetChildIndex(Me.RBU02, 0)
        Me.Controls.SetChildIndex(Me.CbbDmMauBc, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabM_Thang As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents CbbM_Thang As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents RBU02 As System.Windows.Forms.RadioButton
    Friend WithEvents RBU01 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbbDmMauBc As System.Windows.Forms.ComboBox

End Class
