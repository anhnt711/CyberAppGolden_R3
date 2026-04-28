<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KPI_THKHNS
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
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.LabM_month2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Thang2 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChkIs_TH = New System.Windows.Forms.CheckBox()
        Me.ChkIs_LK = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(656, 258)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 9
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(127, 207)
        Me.CBBMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(653, 25)
        Me.CBBMa_Dvcs.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(13, 211)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(517, 258)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 8
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(13, 182)
        Me.LabLoai_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(127, 178)
        Me.ChkVND.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkVND.TabIndex = 5
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(292, 178)
        Me.ChkNT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkNT.TabIndex = 6
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(13, 44)
        Me.LabM_month1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(65, 17)
        Me.LabM_month1.TabIndex = 13
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Từ tháng"
        '
        'LabM_month2
        '
        Me.LabM_month2.AutoSize = True
        Me.LabM_month2.Location = New System.Drawing.Point(13, 75)
        Me.LabM_month2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month2.Name = "LabM_month2"
        Me.LabM_month2.Size = New System.Drawing.Size(73, 17)
        Me.LabM_month2.TabIndex = 14
        Me.LabM_month2.Tag = "Month to"
        Me.LabM_month2.Text = "Đến tháng"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(5, 235)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(785, 12)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(127, 41)
        Me.CbbM_Thang1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(125, 25)
        Me.CbbM_Thang1.TabIndex = 1
        '
        'CbbM_Thang2
        '
        Me.CbbM_Thang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang2.FormattingEnabled = True
        Me.CbbM_Thang2.Location = New System.Drawing.Point(127, 71)
        Me.CbbM_Thang2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang2.Name = "CbbM_Thang2"
        Me.CbbM_Thang2.Size = New System.Drawing.Size(125, 25)
        Me.CbbM_Thang2.TabIndex = 2
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(127, 102)
        Me.CbbM_Nam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(125, 25)
        Me.CbbM_Nam.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 106)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'ChkIs_TH
        '
        Me.ChkIs_TH.AutoSize = True
        Me.ChkIs_TH.Location = New System.Drawing.Point(127, 140)
        Me.ChkIs_TH.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkIs_TH.Name = "ChkIs_TH"
        Me.ChkIs_TH.Size = New System.Drawing.Size(166, 21)
        Me.ChkIs_TH.TabIndex = 4
        Me.ChkIs_TH.Tag = "General Report"
        Me.ChkIs_TH.Text = "Lên báo cáo tổng hợp"
        Me.ChkIs_TH.UseVisualStyleBackColor = True
        '
        'ChkIs_LK
        '
        Me.ChkIs_LK.AutoSize = True
        Me.ChkIs_LK.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.ChkIs_LK.ForeColor = System.Drawing.Color.Blue
        Me.ChkIs_LK.Location = New System.Drawing.Point(127, 16)
        Me.ChkIs_LK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkIs_LK.Name = "ChkIs_LK"
        Me.ChkIs_LK.Size = New System.Drawing.Size(129, 21)
        Me.ChkIs_LK.TabIndex = 0
        Me.ChkIs_LK.Tag = "Accumulated report"
        Me.ChkIs_LK.Text = "Báo cáo lũy kế"
        Me.ChkIs_LK.UseVisualStyleBackColor = True
        '
        'KPI_THKHNS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.ClientSize = New System.Drawing.Size(795, 327)
        Me.Controls.Add(Me.ChkIs_LK)
        Me.Controls.Add(Me.ChkIs_TH)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_month2)
        Me.Controls.Add(Me.LabM_month1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(647, 225)
        Me.Name = "KPI_THKHNS"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.LabM_month2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_TH, 0)
        Me.Controls.SetChildIndex(Me.ChkIs_LK, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents LabM_month2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Thang2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ChkIs_TH As System.Windows.Forms.CheckBox
    Friend WithEvents ChkIs_LK As System.Windows.Forms.CheckBox

End Class
