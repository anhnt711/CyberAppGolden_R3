<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LOA_Approve
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
        Me.ChkAgree = New System.Windows.Forms.CheckBox()
        Me.ChkAgreeCondition = New System.Windows.Forms.CheckBox()
        Me.ChkDisAgree = New System.Windows.Forms.CheckBox()
        Me.ChkReject = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtNote = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(2, 263)
        Me.GroupBoxLine.Size = New System.Drawing.Size(588, 8)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 273)
        Me.ButtOK.TabIndex = 5
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(490, 273)
        Me.ButtExit.TabIndex = 6
        '
        'ChkAgree
        '
        Me.ChkAgree.AutoSize = True
        Me.ChkAgree.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAgree.Location = New System.Drawing.Point(75, 24)
        Me.ChkAgree.Name = "ChkAgree"
        Me.ChkAgree.Size = New System.Drawing.Size(122, 21)
        Me.ChkAgree.TabIndex = 0
        Me.ChkAgree.Text = "Đồng ý / Agree"
        Me.ChkAgree.UseVisualStyleBackColor = True
        '
        'ChkAgreeCondition
        '
        Me.ChkAgreeCondition.AutoSize = True
        Me.ChkAgreeCondition.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkAgreeCondition.Location = New System.Drawing.Point(75, 48)
        Me.ChkAgreeCondition.Name = "ChkAgreeCondition"
        Me.ChkAgreeCondition.Size = New System.Drawing.Size(223, 21)
        Me.ChkAgreeCondition.TabIndex = 1
        Me.ChkAgreeCondition.Text = "Đồng ý có ĐK / AgreeCondition"
        Me.ChkAgreeCondition.UseVisualStyleBackColor = True
        '
        'ChkDisAgree
        '
        Me.ChkDisAgree.AutoSize = True
        Me.ChkDisAgree.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkDisAgree.Location = New System.Drawing.Point(75, 73)
        Me.ChkDisAgree.Name = "ChkDisAgree"
        Me.ChkDisAgree.Size = New System.Drawing.Size(185, 21)
        Me.ChkDisAgree.TabIndex = 2
        Me.ChkDisAgree.Text = "Không đồng ý / DisAgree"
        Me.ChkDisAgree.UseVisualStyleBackColor = True
        '
        'ChkReject
        '
        Me.ChkReject.AutoSize = True
        Me.ChkReject.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkReject.ForeColor = System.Drawing.Color.Red
        Me.ChkReject.Location = New System.Drawing.Point(75, 123)
        Me.ChkReject.Name = "ChkReject"
        Me.ChkReject.Size = New System.Drawing.Size(120, 21)
        Me.ChkReject.TabIndex = 3
        Me.ChkReject.Text = "Trả về / Reject"
        Me.ChkReject.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(2, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(582, 156)
        Me.GroupBox1.TabIndex = 7342
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Phê duyệt"
        '
        'TxtNote
        '
        Me.TxtNote.BackColor = System.Drawing.Color.White
        Me.TxtNote.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNote.ForeColor = System.Drawing.Color.Navy
        Me.TxtNote.Location = New System.Drawing.Point(75, 180)
        Me.TxtNote.Multiline = True
        Me.TxtNote.Name = "TxtNote"
        Me.TxtNote.Size = New System.Drawing.Size(503, 75)
        Me.TxtNote.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(2, 166)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(582, 97)
        Me.GroupBox2.TabIndex = 7344
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ghi chú"
        '
        'LOA_Approve
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(592, 327)
        Me.Controls.Add(Me.TxtNote)
        Me.Controls.Add(Me.ChkReject)
        Me.Controls.Add(Me.ChkDisAgree)
        Me.Controls.Add(Me.ChkAgreeCondition)
        Me.Controls.Add(Me.ChkAgree)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LOA_Approve"
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.ChkAgree, 0)
        Me.Controls.SetChildIndex(Me.ChkAgreeCondition, 0)
        Me.Controls.SetChildIndex(Me.ChkDisAgree, 0)
        Me.Controls.SetChildIndex(Me.ChkReject, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtNote, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ChkAgree As System.Windows.Forms.CheckBox
    Friend WithEvents ChkAgreeCondition As System.Windows.Forms.CheckBox
    Friend WithEvents ChkDisAgree As System.Windows.Forms.CheckBox
    Friend WithEvents ChkReject As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNote As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox

End Class
