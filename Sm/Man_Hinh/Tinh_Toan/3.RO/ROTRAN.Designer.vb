<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ROTRAN
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
        Me.CmbbMa_CT = New System.Windows.Forms.ComboBox()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.TxtSo_Ro = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDien_Giai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CmbbMa_PostOld = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbbMa_PostNew = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 213)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(760, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(493, 225)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtOK.TabIndex = 5
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(629, 225)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtExit.TabIndex = 6
        '
        'CmbbMa_CT
        '
        Me.CmbbMa_CT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbbMa_CT.ForeColor = System.Drawing.Color.Navy
        Me.CmbbMa_CT.FormattingEnabled = True
        Me.CmbbMa_CT.Location = New System.Drawing.Point(153, 7)
        Me.CmbbMa_CT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbbMa_CT.Name = "CmbbMa_CT"
        Me.CmbbMa_CT.Size = New System.Drawing.Size(371, 24)
        Me.CmbbMa_CT.TabIndex = 0
        '
        'LabM_month1
        '
        Me.LabM_month1.Location = New System.Drawing.Point(4, 7)
        Me.LabM_month1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(129, 22)
        Me.LabM_month1.TabIndex = 504
        Me.LabM_month1.Tag = "Type"
        Me.LabM_month1.Text = "Loại lệnh"
        '
        'TxtSo_Ro
        '
        Me.TxtSo_Ro.BackColor = System.Drawing.Color.White
        Me.TxtSo_Ro.ForeColor = System.Drawing.Color.Navy
        Me.TxtSo_Ro.Location = New System.Drawing.Point(153, 38)
        Me.TxtSo_Ro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtSo_Ro.Name = "TxtSo_Ro"
        Me.TxtSo_Ro.Size = New System.Drawing.Size(371, 22)
        Me.TxtSo_Ro.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 22)
        Me.Label1.TabIndex = 532
        Me.Label1.Tag = "R/O"
        Me.Label1.Text = "Lệnh số"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(4, 73)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 22)
        Me.Label2.TabIndex = 534
        Me.Label2.Tag = "Explain"
        Me.Label2.Text = "Diễn giải"
        '
        'TxtDien_Giai
        '
        Me.TxtDien_Giai.BackColor = System.Drawing.Color.White
        Me.TxtDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.TxtDien_Giai.Location = New System.Drawing.Point(153, 69)
        Me.TxtDien_Giai.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtDien_Giai.Multiline = True
        Me.TxtDien_Giai.Name = "TxtDien_Giai"
        Me.TxtDien_Giai.Size = New System.Drawing.Size(608, 83)
        Me.TxtDien_Giai.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(4, 161)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 22)
        Me.Label3.TabIndex = 536
        Me.Label3.Tag = "Current level"
        Me.Label3.Text = "Mức hiện tại"
        '
        'CmbbMa_PostOld
        '
        Me.CmbbMa_PostOld.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbbMa_PostOld.Enabled = False
        Me.CmbbMa_PostOld.ForeColor = System.Drawing.Color.Navy
        Me.CmbbMa_PostOld.FormattingEnabled = True
        Me.CmbbMa_PostOld.Location = New System.Drawing.Point(153, 158)
        Me.CmbbMa_PostOld.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbbMa_PostOld.Name = "CmbbMa_PostOld"
        Me.CmbbMa_PostOld.Size = New System.Drawing.Size(371, 24)
        Me.CmbbMa_PostOld.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(4, 192)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 22)
        Me.Label4.TabIndex = 538
        Me.Label4.Tag = "Level to"
        Me.Label4.Text = "Loại Chuyển về mức"
        '
        'CmbbMa_PostNew
        '
        Me.CmbbMa_PostNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbbMa_PostNew.ForeColor = System.Drawing.Color.Navy
        Me.CmbbMa_PostNew.FormattingEnabled = True
        Me.CmbbMa_PostNew.Location = New System.Drawing.Point(153, 188)
        Me.CmbbMa_PostNew.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbbMa_PostNew.Name = "CmbbMa_PostNew"
        Me.CmbbMa_PostNew.Size = New System.Drawing.Size(371, 24)
        Me.CmbbMa_PostNew.TabIndex = 4
        '
        'ROTRAN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(765, 292)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CmbbMa_PostNew)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmbbMa_PostOld)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtDien_Giai)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtSo_Ro)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.CmbbMa_CT)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "ROTRAN"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CmbbMa_CT, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.TxtSo_Ro, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CmbbMa_PostOld, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.CmbbMa_PostNew, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbbMa_CT As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents TxtSo_Ro As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Giai As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbbMa_PostOld As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmbbMa_PostNew As System.Windows.Forms.ComboBox

End Class
