<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMCHANG
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
        Me.TxtMa_Chang = New System.Windows.Forms.TextBox()
        Me.TxtTen_Chang = New System.Windows.Forms.TextBox()
        Me.LabTen_TD1 = New System.Windows.Forms.Label()
        Me.TxtTen_Chang2 = New System.Windows.Forms.TextBox()
        Me.Labten_TD12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(624, 127)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 7
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(488, 127)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(347, 135)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Dvcs.TabIndex = 5
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(147, 140)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 114)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(755, 12)
        Me.GroupBoxLine.TabIndex = 3
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.Location = New System.Drawing.Point(9, 10)
        Me.LabMa_TD1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(125, 19)
        Me.LabMa_TD1.TabIndex = 9
        Me.LabMa_TD1.Tag = "code"
        Me.LabMa_TD1.Text = "Mã Chặng"
        '
        'TxtMa_Chang
        '
        Me.TxtMa_Chang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Chang.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Chang.Location = New System.Drawing.Point(147, 9)
        Me.TxtMa_Chang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Chang.Name = "TxtMa_Chang"
        Me.TxtMa_Chang.Size = New System.Drawing.Size(197, 24)
        Me.TxtMa_Chang.TabIndex = 0
        '
        'TxtTen_Chang
        '
        Me.TxtTen_Chang.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Chang.Location = New System.Drawing.Point(147, 39)
        Me.TxtTen_Chang.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Chang.Name = "TxtTen_Chang"
        Me.TxtTen_Chang.Size = New System.Drawing.Size(596, 24)
        Me.TxtTen_Chang.TabIndex = 1
        '
        'LabTen_TD1
        '
        Me.LabTen_TD1.Location = New System.Drawing.Point(9, 42)
        Me.LabTen_TD1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTen_TD1.Name = "LabTen_TD1"
        Me.LabTen_TD1.Size = New System.Drawing.Size(125, 19)
        Me.LabTen_TD1.TabIndex = 8
        Me.LabTen_TD1.Tag = "Name"
        Me.LabTen_TD1.Text = "Tên chặng"
        '
        'TxtTen_Chang2
        '
        Me.TxtTen_Chang2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_Chang2.Location = New System.Drawing.Point(147, 69)
        Me.TxtTen_Chang2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTen_Chang2.Name = "TxtTen_Chang2"
        Me.TxtTen_Chang2.Size = New System.Drawing.Size(596, 24)
        Me.TxtTen_Chang2.TabIndex = 2
        '
        'Labten_TD12
        '
        Me.Labten_TD12.Location = New System.Drawing.Point(9, 71)
        Me.Labten_TD12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labten_TD12.Name = "Labten_TD12"
        Me.Labten_TD12.Size = New System.Drawing.Size(125, 19)
        Me.Labten_TD12.TabIndex = 10
        Me.Labten_TD12.Tag = "English name"
        Me.Labten_TD12.Text = "Tên tiếng anh"
        '
        'DMCHANG
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(760, 178)
        Me.Controls.Add(Me.TxtTen_Chang2)
        Me.Controls.Add(Me.Labten_TD12)
        Me.Controls.Add(Me.TxtTen_Chang)
        Me.Controls.Add(Me.LabTen_TD1)
        Me.Controls.Add(Me.TxtMa_Chang)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMCHANG"
        Me.Text = "Danh mục nguồn vốn"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Chang, 0)
        Me.Controls.SetChildIndex(Me.LabTen_TD1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Chang, 0)
        Me.Controls.SetChildIndex(Me.Labten_TD12, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Chang2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Chang As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Chang As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Chang2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_TD12 As System.Windows.Forms.Label

End Class
