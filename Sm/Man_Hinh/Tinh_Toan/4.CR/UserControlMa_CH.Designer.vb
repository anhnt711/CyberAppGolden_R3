<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserControlMa_CH
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabbTen_CH = New System.Windows.Forms.Label()
        Me.CbbMa_TL = New System.Windows.Forms.ComboBox()
        Me.TxtGhi_Chu = New System.Windows.Forms.TextBox()
        Me.TxtMa_CH = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'LabbTen_CH
        '
        Me.LabbTen_CH.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabbTen_CH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabbTen_CH.ForeColor = System.Drawing.Color.Navy
        Me.LabbTen_CH.Location = New System.Drawing.Point(3, 1)
        Me.LabbTen_CH.Name = "LabbTen_CH"
        Me.LabbTen_CH.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabbTen_CH.Size = New System.Drawing.Size(371, 27)
        Me.LabbTen_CH.TabIndex = 0
        Me.LabbTen_CH.Text = "Label1"
        Me.LabbTen_CH.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CbbMa_TL
        '
        Me.CbbMa_TL.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_TL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TL.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TL.FormattingEnabled = True
        Me.CbbMa_TL.Location = New System.Drawing.Point(377, 4)
        Me.CbbMa_TL.Name = "CbbMa_TL"
        Me.CbbMa_TL.Size = New System.Drawing.Size(132, 21)
        Me.CbbMa_TL.TabIndex = 1
        '
        'TxtGhi_Chu
        '
        Me.TxtGhi_Chu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGhi_Chu.Location = New System.Drawing.Point(513, 4)
        Me.TxtGhi_Chu.Name = "TxtGhi_Chu"
        Me.TxtGhi_Chu.Size = New System.Drawing.Size(341, 20)
        Me.TxtGhi_Chu.TabIndex = 2
        '
        'TxtMa_CH
        '
        Me.TxtMa_CH.Location = New System.Drawing.Point(113, 3)
        Me.TxtMa_CH.Name = "TxtMa_CH"
        Me.TxtMa_CH.Size = New System.Drawing.Size(114, 20)
        Me.TxtMa_CH.TabIndex = 3
        Me.TxtMa_CH.Visible = False
        '
        'UserControlMa_CH
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TxtMa_CH)
        Me.Controls.Add(Me.TxtGhi_Chu)
        Me.Controls.Add(Me.CbbMa_TL)
        Me.Controls.Add(Me.LabbTen_CH)
        Me.Name = "UserControlMa_CH"
        Me.Size = New System.Drawing.Size(857, 34)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabbTen_CH As System.Windows.Forms.Label
    Friend WithEvents CbbMa_TL As System.Windows.Forms.ComboBox
    Friend WithEvents TxtGhi_Chu As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_CH As System.Windows.Forms.TextBox

End Class
