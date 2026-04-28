<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVOD_XLKN_User
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
        Me.TxtTen_Hs = New System.Windows.Forms.Label()
        Me.lblMa = New System.Windows.Forms.Label()
        Me.TxtMa_Hs = New Cyber.SmLists.TxtLookup()
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 47)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(760, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(493, 59)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtOK.TabIndex = 1
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(629, 59)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.ButtExit.TabIndex = 2
        '
        'TxtTen_Hs
        '
        Me.TxtTen_Hs.BackColor = System.Drawing.Color.White
        Me.TxtTen_Hs.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_Hs.Location = New System.Drawing.Point(285, 18)
        Me.TxtTen_Hs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_Hs.Name = "TxtTen_Hs"
        Me.TxtTen_Hs.Size = New System.Drawing.Size(464, 17)
        Me.TxtTen_Hs.TabIndex = 552
        Me.TxtTen_Hs.Tag = "Group 4"
        '
        'lblMa
        '
        Me.lblMa.AutoSize = True
        Me.lblMa.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.lblMa.Location = New System.Drawing.Point(4, 20)
        Me.lblMa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMa.Name = "lblMa"
        Me.lblMa.Size = New System.Drawing.Size(105, 17)
        Me.lblMa.TabIndex = 551
        Me.lblMa.Tag = "New processor"
        Me.lblMa.Text = "Người xử lý mới"
        '
        'TxtMa_Hs
        '
        Me.TxtMa_Hs._ActilookupPopup = False
        Me.TxtMa_Hs.CyberActilookupPopup = True
        Me.TxtMa_Hs.Dv_ListDetail = Nothing
        Me.TxtMa_Hs.Dv_Master = Nothing
        Me.TxtMa_Hs.FilterClient = Nothing
        Me.TxtMa_Hs.FilterSQL = Nothing
        Me.TxtMa_Hs.Location = New System.Drawing.Point(124, 15)
        Me.TxtMa_Hs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Hs.Name = "TxtMa_Hs"
        Me.TxtMa_Hs.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Hs.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Hs.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Hs.Size = New System.Drawing.Size(155, 22)
        Me.TxtMa_Hs.TabIndex = 0
        Me.TxtMa_Hs.Table_Name = Nothing
        '
        'FrmVOC_XLKN_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(765, 126)
        Me.Controls.Add(Me.TxtTen_Hs)
        Me.Controls.Add(Me.lblMa)
        Me.Controls.Add(Me.TxtMa_Hs)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "FrmVOC_XLKN_User"
        Me.Text = "Đổi người xử lý khiếu nại"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Hs, 0)
        Me.Controls.SetChildIndex(Me.lblMa, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Hs, 0)
        CType(Me.TxtMa_Hs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTen_Hs As System.Windows.Forms.Label
    Friend WithEvents lblMa As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Hs As Cyber.SmLists.TxtLookup

End Class
