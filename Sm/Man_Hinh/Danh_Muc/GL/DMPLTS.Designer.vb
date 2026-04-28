<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMPLTS
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
        Me.LabMa_loai = New System.Windows.Forms.Label()
        Me.TxtMa_loai = New System.Windows.Forms.TextBox()
        Me.TxtTen_loai = New System.Windows.Forms.TextBox()
        Me.LabTen_loai = New System.Windows.Forms.Label()
        Me.TxtTen_loai2 = New System.Windows.Forms.TextBox()
        Me.Labten_TD12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(909, 106)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 6
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(773, 106)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 5
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(632, 114)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.TabIndex = 4
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(147, 119)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkActi.TabIndex = 3
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 93)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.TabIndex = 7
        '
        'LabMa_loai
        '
        Me.LabMa_loai.Location = New System.Drawing.Point(7, 10)
        Me.LabMa_loai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_loai.Name = "LabMa_loai"
        Me.LabMa_loai.Size = New System.Drawing.Size(133, 21)
        Me.LabMa_loai.TabIndex = 9
        Me.LabMa_loai.Tag = "Code"
        Me.LabMa_loai.Text = "Mã loại TS"
        '
        'TxtMa_loai
        '
        Me.TxtMa_loai.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_loai.Location = New System.Drawing.Point(147, 9)
        Me.TxtMa_loai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_loai.Name = "TxtMa_loai"
        Me.TxtMa_loai.Size = New System.Drawing.Size(197, 24)
        Me.TxtMa_loai.TabIndex = 0
        '
        'TxtTen_loai
        '
        Me.TxtTen_loai.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_loai.Location = New System.Drawing.Point(147, 39)
        Me.TxtTen_loai.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_loai.Name = "TxtTen_loai"
        Me.TxtTen_loai.Size = New System.Drawing.Size(895, 24)
        Me.TxtTen_loai.TabIndex = 1
        '
        'LabTen_loai
        '
        Me.LabTen_loai.Location = New System.Drawing.Point(7, 42)
        Me.LabTen_loai.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTen_loai.Name = "LabTen_loai"
        Me.LabTen_loai.Size = New System.Drawing.Size(133, 21)
        Me.LabTen_loai.TabIndex = 8
        Me.LabTen_loai.Tag = "Name"
        Me.LabTen_loai.Text = "Tên loại TS"
        '
        'TxtTen_loai2
        '
        Me.TxtTen_loai2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_loai2.Location = New System.Drawing.Point(147, 69)
        Me.TxtTen_loai2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_loai2.Name = "TxtTen_loai2"
        Me.TxtTen_loai2.Size = New System.Drawing.Size(895, 24)
        Me.TxtTen_loai2.TabIndex = 2
        '
        'Labten_TD12
        '
        Me.Labten_TD12.Location = New System.Drawing.Point(7, 71)
        Me.Labten_TD12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labten_TD12.Name = "Labten_TD12"
        Me.Labten_TD12.Size = New System.Drawing.Size(133, 21)
        Me.Labten_TD12.TabIndex = 10
        Me.Labten_TD12.Tag = "English name"
        Me.Labten_TD12.Text = "Tên tiếng anh"
        '
        'DMPLTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1045, 178)
        Me.Controls.Add(Me.TxtTen_loai2)
        Me.Controls.Add(Me.Labten_TD12)
        Me.Controls.Add(Me.TxtTen_loai)
        Me.Controls.Add(Me.LabTen_loai)
        Me.Controls.Add(Me.TxtMa_loai)
        Me.Controls.Add(Me.LabMa_loai)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMPLTS"
        Me.Text = "Danh mục loại tài sản"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_loai, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_loai, 0)
        Me.Controls.SetChildIndex(Me.LabTen_loai, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_loai, 0)
        Me.Controls.SetChildIndex(Me.Labten_TD12, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_loai2, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_loai As System.Windows.Forms.Label
    Friend WithEvents TxtMa_loai As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_loai As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_loai As System.Windows.Forms.Label
    Friend WithEvents TxtTen_loai2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_TD12 As System.Windows.Forms.Label

End Class
