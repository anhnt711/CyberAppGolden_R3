<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Funny
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
        Me.Txtnoi_Dung = New System.Windows.Forms.RichTextBox()
        Me.Txtten_Truyen = New System.Windows.Forms.TextBox()
        Me.CmdPrev = New System.Windows.Forms.Button()
        Me.CmdNext = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 469)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(1173, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(907, 481)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(1043, 481)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'Txtnoi_Dung
        '
        Me.Txtnoi_Dung.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtnoi_Dung.BackColor = System.Drawing.SystemColors.Info
        Me.Txtnoi_Dung.Location = New System.Drawing.Point(0, 42)
        Me.Txtnoi_Dung.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtnoi_Dung.Name = "Txtnoi_Dung"
        Me.Txtnoi_Dung.ReadOnly = True
        Me.Txtnoi_Dung.Size = New System.Drawing.Size(1175, 431)
        Me.Txtnoi_Dung.TabIndex = 45
        Me.Txtnoi_Dung.Text = ""
        '
        'Txtten_Truyen
        '
        Me.Txtten_Truyen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Txtten_Truyen.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Txtten_Truyen.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Truyen.Enabled = False
        Me.Txtten_Truyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtten_Truyen.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Truyen.Location = New System.Drawing.Point(0, 0)
        Me.Txtten_Truyen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Txtten_Truyen.Name = "Txtten_Truyen"
        Me.Txtten_Truyen.ReadOnly = True
        Me.Txtten_Truyen.Size = New System.Drawing.Size(1176, 34)
        Me.Txtten_Truyen.TabIndex = 234
        Me.Txtten_Truyen.Tag = ""
        Me.Txtten_Truyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CmdPrev
        '
        Me.CmdPrev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdPrev.Location = New System.Drawing.Point(763, 481)
        Me.CmdPrev.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdPrev.Name = "CmdPrev"
        Me.CmdPrev.Size = New System.Drawing.Size(133, 37)
        Me.CmdPrev.TabIndex = 235
        Me.CmdPrev.Tag = "<<"
        Me.CmdPrev.Text = "<<"
        Me.CmdPrev.UseVisualStyleBackColor = True
        '
        'CmdNext
        '
        Me.CmdNext.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdNext.Location = New System.Drawing.Point(904, 481)
        Me.CmdNext.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmdNext.Name = "CmdNext"
        Me.CmdNext.Size = New System.Drawing.Size(133, 37)
        Me.CmdNext.TabIndex = 236
        Me.CmdNext.Tag = ">"
        Me.CmdNext.Text = ">"
        Me.CmdNext.UseVisualStyleBackColor = True
        '
        'Funny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1179, 548)
        Me.Controls.Add(Me.CmdPrev)
        Me.Controls.Add(Me.CmdNext)
        Me.Controls.Add(Me.Txtten_Truyen)
        Me.Controls.Add(Me.Txtnoi_Dung)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Funny"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Txtnoi_Dung, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Truyen, 0)
        Me.Controls.SetChildIndex(Me.CmdNext, 0)
        Me.Controls.SetChildIndex(Me.CmdPrev, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txtnoi_Dung As System.Windows.Forms.RichTextBox
    Friend WithEvents Txtten_Truyen As System.Windows.Forms.TextBox
    Friend WithEvents CmdPrev As System.Windows.Forms.Button
    Friend WithEvents CmdNext As System.Windows.Forms.Button

End Class
