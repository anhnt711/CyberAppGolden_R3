<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MobiDmhang
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
        Me.TxtMa_hang = New System.Windows.Forms.TextBox()
        Me.TxtTen_hang = New System.Windows.Forms.TextBox()
        Me.LabTen_TD2 = New System.Windows.Forms.Label()
        Me.TxtTen_hang2 = New System.Windows.Forms.TextBox()
        Me.Labten_TD22 = New System.Windows.Forms.Label()
        Me.ChkNgam_Dinh = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(682, 113)
        Me.ButtExit.TabIndex = 6
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(580, 113)
        Me.ButtOK.TabIndex = 5
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(474, 119)
        Me.TxtMa_Dvcs.TabIndex = 9
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(110, 123)
        Me.ChkActi.TabIndex = 4
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 103)
        Me.GroupBoxLine.TabIndex = 7
        '
        'LabMa_TD1
        '
        Me.LabMa_TD1.Location = New System.Drawing.Point(5, 13)
        Me.LabMa_TD1.Name = "LabMa_TD1"
        Me.LabMa_TD1.Size = New System.Drawing.Size(100, 16)
        Me.LabMa_TD1.TabIndex = 10
        Me.LabMa_TD1.Tag = "Code"
        Me.LabMa_TD1.Text = "Mã hãng"
        '
        'TxtMa_hang
        '
        Me.TxtMa_hang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_hang.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_hang.Location = New System.Drawing.Point(110, 12)
        Me.TxtMa_hang.Name = "TxtMa_hang"
        Me.TxtMa_hang.Size = New System.Drawing.Size(149, 21)
        Me.TxtMa_hang.TabIndex = 0
        '
        'TxtTen_hang
        '
        Me.TxtTen_hang.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_hang.Location = New System.Drawing.Point(110, 35)
        Me.TxtTen_hang.Name = "TxtTen_hang"
        Me.TxtTen_hang.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_hang.TabIndex = 1
        '
        'LabTen_TD2
        '
        Me.LabTen_TD2.Location = New System.Drawing.Point(5, 37)
        Me.LabTen_TD2.Name = "LabTen_TD2"
        Me.LabTen_TD2.Size = New System.Drawing.Size(100, 16)
        Me.LabTen_TD2.TabIndex = 12
        Me.LabTen_TD2.Tag = "Name"
        Me.LabTen_TD2.Text = "Tên hãng"
        '
        'TxtTen_hang2
        '
        Me.TxtTen_hang2.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_hang2.Location = New System.Drawing.Point(110, 58)
        Me.TxtTen_hang2.Name = "TxtTen_hang2"
        Me.TxtTen_hang2.Size = New System.Drawing.Size(672, 21)
        Me.TxtTen_hang2.TabIndex = 2
        '
        'Labten_TD22
        '
        Me.Labten_TD22.Location = New System.Drawing.Point(5, 59)
        Me.Labten_TD22.Name = "Labten_TD22"
        Me.Labten_TD22.Size = New System.Drawing.Size(100, 16)
        Me.Labten_TD22.TabIndex = 14
        Me.Labten_TD22.Tag = "English name"
        Me.Labten_TD22.Text = "Tên tiếng anh"
        '
        'ChkNgam_Dinh
        '
        Me.ChkNgam_Dinh.AutoSize = True
        Me.ChkNgam_Dinh.Location = New System.Drawing.Point(110, 85)
        Me.ChkNgam_Dinh.Name = "ChkNgam_Dinh"
        Me.ChkNgam_Dinh.Size = New System.Drawing.Size(76, 17)
        Me.ChkNgam_Dinh.TabIndex = 3
        Me.ChkNgam_Dinh.Tag = "Default"
        Me.ChkNgam_Dinh.Text = "Ngầm định"
        Me.ChkNgam_Dinh.UseVisualStyleBackColor = True
        '
        'MobiDmhang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 146)
        Me.Controls.Add(Me.ChkNgam_Dinh)
        Me.Controls.Add(Me.TxtTen_hang2)
        Me.Controls.Add(Me.Labten_TD22)
        Me.Controls.Add(Me.TxtTen_hang)
        Me.Controls.Add(Me.LabTen_TD2)
        Me.Controls.Add(Me.TxtMa_hang)
        Me.Controls.Add(Me.LabMa_TD1)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(489, 181)
        Me.Name = "MobiDmhang"
        Me.Text = "Danh mục hãng"
        Me.Controls.SetChildIndex(Me.LabMa_TD1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_hang, 0)
        Me.Controls.SetChildIndex(Me.LabTen_TD2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_hang, 0)
        Me.Controls.SetChildIndex(Me.Labten_TD22, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_hang2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkNgam_Dinh, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_TD1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_hang As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_hang As System.Windows.Forms.TextBox
    Friend WithEvents LabTen_TD2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_hang2 As System.Windows.Forms.TextBox
    Friend WithEvents Labten_TD22 As System.Windows.Forms.Label
    Friend WithEvents ChkNgam_Dinh As System.Windows.Forms.CheckBox

End Class
