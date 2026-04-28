<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAttachFile
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
        Me.CmdSelectFile = New System.Windows.Forms.Button()
        Me.TxtFile_Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 98)
        Me.GroupBoxLine.Size = New System.Drawing.Size(564, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(364, 108)
        Me.ButtOK.TabIndex = 1
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(466, 108)
        Me.ButtExit.TabIndex = 2
        '
        'CmdSelectFile
        '
        Me.CmdSelectFile.Location = New System.Drawing.Point(51, 9)
        Me.CmdSelectFile.Name = "CmdSelectFile"
        Me.CmdSelectFile.Size = New System.Drawing.Size(100, 30)
        Me.CmdSelectFile.TabIndex = 45
        Me.CmdSelectFile.Text = "Chọn File"
        Me.CmdSelectFile.UseVisualStyleBackColor = True
        '
        'TxtFile_Name
        '
        Me.TxtFile_Name.BackColor = System.Drawing.Color.White
        Me.TxtFile_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtFile_Name.ForeColor = System.Drawing.Color.Navy
        Me.TxtFile_Name.Location = New System.Drawing.Point(51, 45)
        Me.TxtFile_Name.Name = "TxtFile_Name"
        Me.TxtFile_Name.Size = New System.Drawing.Size(505, 20)
        Me.TxtFile_Name.TabIndex = 2174
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 2175
        Me.Label2.Tag = "Subject"
        Me.Label2.Text = "File"
        '
        'FrmAttachFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(568, 162)
        Me.Controls.Add(Me.TxtFile_Name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmdSelectFile)
        Me.Name = "FrmAttachFile"
        Me.Text = "Đính kèm File"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CmdSelectFile, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtFile_Name, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdSelectFile As System.Windows.Forms.Button
    Friend WithEvents TxtFile_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
