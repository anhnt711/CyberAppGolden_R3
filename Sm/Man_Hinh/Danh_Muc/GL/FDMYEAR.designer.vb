<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FDMYEAR
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
        Me.Labyear = New System.Windows.Forms.Label()
        Me.CmbMonth = New System.Windows.Forms.ComboBox()
        Me.TxtM_Nam = New ClsTextBox.txtTien_NT()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(397, 111)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 2
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(261, 111)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 1
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(120, 119)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(87, 24)
        Me.TxtMa_Dvcs.TabIndex = 6
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(16, 125)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.Size = New System.Drawing.Size(18, 17)
        Me.ChkActi.TabIndex = 3
        Me.ChkActi.Text = ""
        Me.ChkActi.Visible = False
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 98)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(528, 12)
        Me.GroupBoxLine.TabIndex = 7
        '
        'Labyear
        '
        Me.Labyear.Location = New System.Drawing.Point(20, 21)
        Me.Labyear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Labyear.Name = "Labyear"
        Me.Labyear.Size = New System.Drawing.Size(95, 22)
        Me.Labyear.TabIndex = 9
        Me.Labyear.Tag = "Select year"
        Me.Labyear.Text = "Chọn năm"
        '
        'CmbMonth
        '
        Me.CmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMonth.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.CmbMonth.ForeColor = System.Drawing.Color.Navy
        Me.CmbMonth.FormattingEnabled = True
        Me.CmbMonth.Location = New System.Drawing.Point(120, 43)
        Me.CmbMonth.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CmbMonth.Name = "CmbMonth"
        Me.CmbMonth.Size = New System.Drawing.Size(237, 25)
        Me.CmbMonth.TabIndex = 13
        '
        'TxtM_Nam
        '
        Me.TxtM_Nam.AllowNegative = True
        Me.TxtM_Nam.BackColor = System.Drawing.Color.White
        Me.TxtM_Nam.Flags = 7680
        Me.TxtM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Nam.InputMask = "####"
        Me.TxtM_Nam.Location = New System.Drawing.Point(120, 14)
        Me.TxtM_Nam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtM_Nam.MaxWholeDigits = 4
        Me.TxtM_Nam.Name = "TxtM_Nam"
        Me.TxtM_Nam.RangeMax = 1.7976931348623157E+308R
        Me.TxtM_Nam.RangeMin = -1.7976931348623157E+308R
        Me.TxtM_Nam.Size = New System.Drawing.Size(157, 24)
        Me.TxtM_Nam.TabIndex = 0
        Me.TxtM_Nam.Text = "2 016"
        Me.TxtM_Nam.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 22)
        Me.Label1.TabIndex = 14
        Me.Label1.Tag = "Select month"
        Me.Label1.Text = "Chọn tháng"
        '
        'FDMYEAR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(629, 178)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtM_Nam)
        Me.Controls.Add(Me.CmbMonth)
        Me.Controls.Add(Me.Labyear)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "FDMYEAR"
        Me.Text = "Chọn năm"
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Labyear, 0)
        Me.Controls.SetChildIndex(Me.CmbMonth, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Nam, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Labyear As System.Windows.Forms.Label
    Friend WithEvents CmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents TxtM_Nam As ClsTextBox.txtTien_NT
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
