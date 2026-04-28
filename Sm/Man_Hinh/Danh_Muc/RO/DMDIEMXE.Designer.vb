<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMDIEMXE
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
        Me.TxtGhi_chu = New System.Windows.Forms.TextBox()
        Me.LabGhi_chu = New System.Windows.Forms.Label()
        Me.LabMa_UT = New System.Windows.Forms.Label()
        Me.LabMa_xe = New System.Windows.Forms.Label()
        Me.TxtMa_xe = New System.Windows.Forms.TextBox()
        Me.TxtDiem_so = New ClsTextBox.txtTien_NT()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(817, 162)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtExit.TabIndex = 6
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(664, 162)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ButtOK.TabIndex = 5
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(505, 171)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMa_Dvcs.TabIndex = 4
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(165, 178)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ChkActi.TabIndex = 3
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 146)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(963, 9)
        Me.GroupBoxLine.TabIndex = 7
        '
        'TxtGhi_chu
        '
        Me.TxtGhi_chu.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGhi_chu.ForeColor = System.Drawing.Color.Navy
        Me.TxtGhi_chu.Location = New System.Drawing.Point(165, 87)
        Me.TxtGhi_chu.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtGhi_chu.Name = "TxtGhi_chu"
        Me.TxtGhi_chu.Size = New System.Drawing.Size(752, 27)
        Me.TxtGhi_chu.TabIndex = 2
        '
        'LabGhi_chu
        '
        Me.LabGhi_chu.Location = New System.Drawing.Point(8, 94)
        Me.LabGhi_chu.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabGhi_chu.Name = "LabGhi_chu"
        Me.LabGhi_chu.Size = New System.Drawing.Size(150, 21)
        Me.LabGhi_chu.TabIndex = 14
        Me.LabGhi_chu.Tag = "English name"
        Me.LabGhi_chu.Text = "Ghi chú"
        '
        'LabMa_UT
        '
        Me.LabMa_UT.Location = New System.Drawing.Point(8, 57)
        Me.LabMa_UT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_UT.Name = "LabMa_UT"
        Me.LabMa_UT.Size = New System.Drawing.Size(150, 21)
        Me.LabMa_UT.TabIndex = 24
        Me.LabMa_UT.Tag = "Voucher"
        Me.LabMa_UT.Text = "Điểm số"
        '
        'LabMa_xe
        '
        Me.LabMa_xe.Location = New System.Drawing.Point(8, 19)
        Me.LabMa_xe.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_xe.Name = "LabMa_xe"
        Me.LabMa_xe.Size = New System.Drawing.Size(150, 21)
        Me.LabMa_xe.TabIndex = 29
        Me.LabMa_xe.Tag = "Voucher"
        Me.LabMa_xe.Text = "Biển số"
        '
        'TxtMa_xe
        '
        Me.TxtMa_xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_xe.Location = New System.Drawing.Point(165, 13)
        Me.TxtMa_xe.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtMa_xe.Name = "TxtMa_xe"
        Me.TxtMa_xe.Size = New System.Drawing.Size(222, 27)
        Me.TxtMa_xe.TabIndex = 0
        '
        'TxtDiem_so
        '
        Me.TxtDiem_so.AllowNegative = True
        Me.TxtDiem_so.BackColor = System.Drawing.Color.White
        Me.TxtDiem_so.Flags = 7680
        Me.TxtDiem_so.ForeColor = System.Drawing.Color.Navy
        Me.TxtDiem_so.InputMask = "### ### ### ###"
        Me.TxtDiem_so.Location = New System.Drawing.Point(165, 50)
        Me.TxtDiem_so.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TxtDiem_so.MaxWholeDigits = 11
        Me.TxtDiem_so.Name = "TxtDiem_so"
        Me.TxtDiem_so.RangeMax = 1.7976931348623157E+308R
        Me.TxtDiem_so.RangeMin = -1.7976931348623157E+308R
        Me.TxtDiem_so.Size = New System.Drawing.Size(222, 27)
        Me.TxtDiem_so.TabIndex = 1
        Me.TxtDiem_so.Text = "0"
        Me.TxtDiem_so.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DMDIEMXE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.ClientSize = New System.Drawing.Size(970, 215)
        Me.Controls.Add(Me.TxtDiem_so)
        Me.Controls.Add(Me.TxtMa_xe)
        Me.Controls.Add(Me.LabMa_xe)
        Me.Controls.Add(Me.LabMa_UT)
        Me.Controls.Add(Me.TxtGhi_chu)
        Me.Controls.Add(Me.LabGhi_chu)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(724, 127)
        Me.Name = "DMDIEMXE"
        Me.Controls.SetChildIndex(Me.LabGhi_chu, 0)
        Me.Controls.SetChildIndex(Me.TxtGhi_chu, 0)
        Me.Controls.SetChildIndex(Me.LabMa_UT, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.LabMa_xe, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_xe, 0)
        Me.Controls.SetChildIndex(Me.TxtDiem_so, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtGhi_chu As System.Windows.Forms.TextBox
    Friend WithEvents LabGhi_chu As System.Windows.Forms.Label
    Friend WithEvents LabMa_UT As System.Windows.Forms.Label
    Friend WithEvents LabMa_xe As System.Windows.Forms.Label
    Friend WithEvents TxtMa_xe As System.Windows.Forms.TextBox
    Friend WithEvents TxtDiem_so As ClsTextBox.txtTien_NT

End Class
