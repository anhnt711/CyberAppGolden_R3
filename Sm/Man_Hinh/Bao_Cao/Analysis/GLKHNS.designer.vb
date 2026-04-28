<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLKHNS
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
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.CbbM_Thang2 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.CbbFile_MauBC = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 181)
        Me.ButtExit.TabIndex = 8
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 142)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(14, 145)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 181)
        Me.ButtOK.TabIndex = 7
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(14, 120)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 120)
        Me.ChkVND.TabIndex = 4
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(211, 121)
        Me.ChkNT.TabIndex = 5
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 164)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'CbbM_Thang2
        '
        Me.CbbM_Thang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang2.FormattingEnabled = True
        Me.CbbM_Thang2.Location = New System.Drawing.Point(96, 35)
        Me.CbbM_Thang2.Name = "CbbM_Thang2"
        Me.CbbM_Thang2.Size = New System.Drawing.Size(110, 21)
        Me.CbbM_Thang2.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 513
        Me.Label2.Tag = "To from"
        Me.Label2.Text = "Đến tháng"
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(96, 61)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(110, 21)
        Me.CbbM_Nam.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 13)
        Me.Label3.TabIndex = 512
        Me.Label3.Tag = "Year"
        Me.Label3.Text = "Năm"
        '
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(96, 8)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(110, 21)
        Me.CbbM_Thang1.TabIndex = 0
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(14, 12)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(51, 13)
        Me.LabM_month1.TabIndex = 511
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Từ tháng"
        '
        'CbbFile_MauBC
        '
        Me.CbbFile_MauBC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbFile_MauBC.ForeColor = System.Drawing.Color.Navy
        Me.CbbFile_MauBC.FormattingEnabled = True
        Me.CbbFile_MauBC.Location = New System.Drawing.Point(96, 88)
        Me.CbbFile_MauBC.Name = "CbbFile_MauBC"
        Me.CbbFile_MauBC.Size = New System.Drawing.Size(486, 21)
        Me.CbbFile_MauBC.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 515
        Me.Label4.Tag = "Form"
        Me.Label4.Text = "Báo cáo"
        '
        'GLKHNS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 234)
        Me.Controls.Add(Me.CbbFile_MauBC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CbbM_Thang2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.LabM_month1)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Name = "GLKHNS"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang2, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.CbbFile_MauBC, 0)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents CbbM_Thang2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents CbbFile_MauBC As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label

End Class
