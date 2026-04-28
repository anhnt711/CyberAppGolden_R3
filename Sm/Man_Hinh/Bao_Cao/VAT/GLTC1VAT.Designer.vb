<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLTC1VAT
    Inherits Cyber.From.FilterReport

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
        Me.TxtM_Ngay_Ct = New ClsTextBox.txtDate1()
        Me.LabM_Ngay_Ct1 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbDmMauBc = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 119)
        Me.ButtExit.TabIndex = 5
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 80)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 83)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 119)
        Me.ButtOK.TabIndex = 4
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 61)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 58)
        Me.ChkVND.TabIndex = 2
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 58)
        Me.ChkNT.TabIndex = 3
        '
        'TxtM_Ngay_Ct
        '
        Me.TxtM_Ngay_Ct.Flags = 0
        Me.TxtM_Ngay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct.IsAllowResize = False
        Me.TxtM_Ngay_Ct.Location = New System.Drawing.Point(95, 5)
        Me.TxtM_Ngay_Ct.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtM_Ngay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtM_Ngay_Ct.MaxLength = 10
        Me.TxtM_Ngay_Ct.Name = "TxtM_Ngay_Ct"
        Me.TxtM_Ngay_Ct.RangeMax = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct.RangeMin = New Date(CType(0, Long))
        Me.TxtM_Ngay_Ct.ShowDayBeforeMonth = False
        Me.TxtM_Ngay_Ct.Size = New System.Drawing.Size(114, 21)
        Me.TxtM_Ngay_Ct.TabIndex = 0
        Me.TxtM_Ngay_Ct.Text = "01/01/1900"
        Me.TxtM_Ngay_Ct.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'LabM_Ngay_Ct1
        '
        Me.LabM_Ngay_Ct1.AutoSize = True
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(10, 8)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(54, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date to"
        Me.LabM_Ngay_Ct1.Text = "Đến ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 102)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Tag = "Form"
        Me.Label3.Text = "Mẫu theo"
        '
        'CbbDmMauBc
        '
        Me.CbbDmMauBc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbDmMauBc.ForeColor = System.Drawing.Color.Navy
        Me.CbbDmMauBc.FormattingEnabled = True
        Me.CbbDmMauBc.Location = New System.Drawing.Point(95, 32)
        Me.CbbDmMauBc.Name = "CbbDmMauBc"
        Me.CbbDmMauBc.Size = New System.Drawing.Size(491, 21)
        Me.CbbDmMauBc.TabIndex = 1
        '
        'GLTC1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 172)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbbDmMauBc)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct)
        Me.Name = "GLTC1"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Ngay_Ct, 0)
        Me.Controls.SetChildIndex(Me.LabM_Ngay_Ct1, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbDmMauBc, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbbDmMauBc As System.Windows.Forms.ComboBox

End Class
