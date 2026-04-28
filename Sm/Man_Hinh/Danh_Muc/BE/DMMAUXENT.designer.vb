<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMMAUXENT
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
        Me.TxtTen_mau2 = New System.Windows.Forms.TextBox()
        Me.Labten_mau2 = New System.Windows.Forms.Label()
        Me.TxtTen_mau = New System.Windows.Forms.TextBox()
        Me.LabTen_mau = New System.Windows.Forms.Label()
        Me.TxtMa_mau_Nt = New System.Windows.Forms.TextBox()
        Me.LabMa_mau = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(671, 86)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(569, 86)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(463, 92)
        Me.TxtMa_Dvcs.TabIndex = 5
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(105, 96)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 74)
        Me.GroupBoxLine.Size = New System.Drawing.Size(769, 9)
        Me.GroupBoxLine.TabIndex = 3
        '
        'TxtTen_mau2
        '
        Me.TxtTen_mau2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_mau2.Location = New System.Drawing.Point(105, 51)
        Me.TxtTen_mau2.Name = "TxtTen_mau2"
        Me.TxtTen_mau2.Size = New System.Drawing.Size(664, 21)
        Me.TxtTen_mau2.TabIndex = 2
        '
        'Labten_mau2
        '
        Me.Labten_mau2.Location = New System.Drawing.Point(8, 55)
        Me.Labten_mau2.Name = "Labten_mau2"
        Me.Labten_mau2.Size = New System.Drawing.Size(80, 13)
        Me.Labten_mau2.TabIndex = 17
        Me.Labten_mau2.Tag = "English name"
        Me.Labten_mau2.Text = "Tên tiếng anh"
        '
        'TxtTen_mau
        '
        Me.TxtTen_mau.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_mau.Location = New System.Drawing.Point(105, 28)
        Me.TxtTen_mau.Name = "TxtTen_mau"
        Me.TxtTen_mau.Size = New System.Drawing.Size(664, 21)
        Me.TxtTen_mau.TabIndex = 1
        '
        'LabTen_mau
        '
        Me.LabTen_mau.Location = New System.Drawing.Point(8, 32)
        Me.LabTen_mau.Name = "LabTen_mau"
        Me.LabTen_mau.Size = New System.Drawing.Size(90, 13)
        Me.LabTen_mau.TabIndex = 18
        Me.LabTen_mau.Tag = "Color Name"
        Me.LabTen_mau.Text = "Tên màu xe"
        '
        'TxtMa_mau_Nt
        '
        Me.TxtMa_mau_Nt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_mau_Nt.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_mau_Nt.Location = New System.Drawing.Point(105, 5)
        Me.TxtMa_mau_Nt.Name = "TxtMa_mau_Nt"
        Me.TxtMa_mau_Nt.Size = New System.Drawing.Size(148, 21)
        Me.TxtMa_mau_Nt.TabIndex = 0
        '
        'LabMa_mau
        '
        Me.LabMa_mau.Location = New System.Drawing.Point(8, 9)
        Me.LabMa_mau.Name = "LabMa_mau"
        Me.LabMa_mau.Size = New System.Drawing.Size(90, 13)
        Me.LabMa_mau.TabIndex = 19
        Me.LabMa_mau.Tag = "Color code"
        Me.LabMa_mau.Text = "Mã màu"
        '
        'DMMAUXENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(773, 119)
        Me.Controls.Add(Me.TxtTen_mau2)
        Me.Controls.Add(Me.Labten_mau2)
        Me.Controls.Add(Me.TxtTen_mau)
        Me.Controls.Add(Me.LabTen_mau)
        Me.Controls.Add(Me.TxtMa_mau_Nt)
        Me.Controls.Add(Me.LabMa_mau)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMMAUXENT"
        Me.Text = "Danh mục màu xe"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_mau, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_mau_Nt, 0)
        Me.Controls.SetChildIndex(Me.LabTen_mau, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_mau, 0)
        Me.Controls.SetChildIndex(Me.Labten_mau2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_mau2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTen_mau2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_mau2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_mau As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_mau As System.Windows.Forms.Label
    Friend WithEvents TxtMa_mau_Nt As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_mau As System.Windows.Forms.Label

End Class
