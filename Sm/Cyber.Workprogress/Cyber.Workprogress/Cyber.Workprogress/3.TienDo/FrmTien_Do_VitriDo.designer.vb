<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTien_Do_VitriDo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTien_Do_VitriDo))
        Me.LabMa_Xe = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CmdFind_Vitri = New DevExpress.XtraEditors.SimpleButton()
        Me.CbbMa_Do = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 92)
        Me.GroupBoxLine.Size = New System.Drawing.Size(556, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Image = CType(resources.GetObject("ButtOK.Image"), System.Drawing.Image)
        Me.ButtOK.Location = New System.Drawing.Point(356, 102)
        Me.ButtOK.TabIndex = 2
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(458, 102)
        Me.ButtExit.TabIndex = 3
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
        Me.TxtMa_Xe.Location = New System.Drawing.Point(102, 9)
        Me.TxtMa_Xe.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(445, 23)
        Me.TxtMa_Xe.TabIndex = 0
        Me.TxtMa_Xe.Tag = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(18, 38)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 7160
        Me.Label5.Tag = "Location"
        Me.Label5.Text = "Vị trí đỗ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CmdFind_Vitri
        '
        Me.CmdFind_Vitri.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdFind_Vitri.Image = CType(resources.GetObject("CmdFind_Vitri.Image"), System.Drawing.Image)
        Me.CmdFind_Vitri.Location = New System.Drawing.Point(102, 63)
        Me.CmdFind_Vitri.Name = "CmdFind_Vitri"
        Me.CmdFind_Vitri.Size = New System.Drawing.Size(155, 23)
        Me.CmdFind_Vitri.TabIndex = 7163
        Me.CmdFind_Vitri.Text = "Tìm vị trí đỗ xe phù hợp"
        '
        'CbbMa_Do
        '
        Me.CbbMa_Do.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_Do.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_Do.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_Do.FormattingEnabled = True
        Me.CbbMa_Do.Location = New System.Drawing.Point(102, 35)
        Me.CbbMa_Do.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_Do.Name = "CbbMa_Do"
        Me.CbbMa_Do.Size = New System.Drawing.Size(445, 22)
        Me.CbbMa_Do.TabIndex = 7164
        '
        'FrmVitriDo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(560, 156)
        Me.Controls.Add(Me.CbbMa_Do)
        Me.Controls.Add(Me.CmdFind_Vitri)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LabMa_Xe)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Name = "FrmVitriDo"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.CmdFind_Vitri, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Do, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_Xe As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CmdFind_Vitri As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents CbbMa_Do As System.Windows.Forms.ComboBox

End Class
