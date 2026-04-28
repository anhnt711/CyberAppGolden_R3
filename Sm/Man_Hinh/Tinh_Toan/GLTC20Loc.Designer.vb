<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLTC20Loc
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
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbM_Thang = New System.Windows.Forms.ComboBox()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.CbbM_DmMauBC = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 103)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(760, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(493, 116)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtOK.TabIndex = 3
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(629, 116)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtExit.TabIndex = 4
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(112, 39)
        Me.CbbM_Nam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Nam.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 43)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 17)
        Me.Label2.TabIndex = 505
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'CbbM_Thang
        '
        Me.CbbM_Thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang.FormattingEnabled = True
        Me.CbbM_Thang.Location = New System.Drawing.Point(112, 9)
        Me.CbbM_Thang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_Thang.Name = "CbbM_Thang"
        Me.CbbM_Thang.Size = New System.Drawing.Size(145, 24)
        Me.CbbM_Thang.TabIndex = 0
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(0, 12)
        Me.LabM_month1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(49, 17)
        Me.LabM_month1.TabIndex = 503
        Me.LabM_month1.Tag = "Month"
        Me.LabM_month1.Text = "Tháng"
        '
        'CbbM_DmMauBC
        '
        Me.CbbM_DmMauBC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_DmMauBC.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_DmMauBC.FormattingEnabled = True
        Me.CbbM_DmMauBC.Location = New System.Drawing.Point(112, 73)
        Me.CbbM_DmMauBC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CbbM_DmMauBC.Name = "CbbM_DmMauBC"
        Me.CbbM_DmMauBC.Size = New System.Drawing.Size(649, 24)
        Me.CbbM_DmMauBC.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 76)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 507
        Me.Label1.Tag = "Circulars"
        Me.Label1.Text = "Thông tư/QĐ"
        '
        'GLTC20Loc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(765, 182)
        Me.Controls.Add(Me.CbbM_DmMauBC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang)
        Me.Controls.Add(Me.LabM_month1)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "GLTC20Loc"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_DmMauBC, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents CbbM_DmMauBC As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
