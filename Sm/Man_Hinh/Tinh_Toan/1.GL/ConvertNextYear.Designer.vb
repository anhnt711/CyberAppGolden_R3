<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvertNextYear
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
        Me.CbbYear = New System.Windows.Forms.ComboBox()
        Me.LabNam = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 56)
        Me.GroupBoxLine.Size = New System.Drawing.Size(590, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(390, 66)
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 66)
        '
        'CbbYear
        '
        Me.CbbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbYear.ForeColor = System.Drawing.Color.Navy
        Me.CbbYear.FormattingEnabled = True
        Me.CbbYear.Location = New System.Drawing.Point(183, 16)
        Me.CbbYear.Name = "CbbYear"
        Me.CbbYear.Size = New System.Drawing.Size(179, 23)
        Me.CbbYear.TabIndex = 45
        '
        'LabNam
        '
        Me.LabNam.BackColor = System.Drawing.Color.Transparent
        Me.LabNam.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabNam.ForeColor = System.Drawing.Color.Navy
        Me.LabNam.Location = New System.Drawing.Point(9, 19)
        Me.LabNam.Margin = New System.Windows.Forms.Padding(0)
        Me.LabNam.Name = "LabNam"
        Me.LabNam.Size = New System.Drawing.Size(171, 15)
        Me.LabNam.TabIndex = 139
        Me.LabNam.Tag = "To year convert"
        Me.LabNam.Text = "Chuyển số dư sang đầu năm"
        '
        'ConvertNextYear
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(594, 120)
        Me.Controls.Add(Me.LabNam)
        Me.Controls.Add(Me.CbbYear)
        Me.Name = "ConvertNextYear"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbYear, 0)
        Me.Controls.SetChildIndex(Me.LabNam, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbYear As System.Windows.Forms.ComboBox
    Friend WithEvents LabNam As System.Windows.Forms.Label

End Class
