<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLCTTK
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
        Me.LabM_month1 = New System.Windows.Forms.Label()
        Me.LabM_month2 = New System.Windows.Forms.Label()
        Me.GroupBoxLine = New System.Windows.Forms.GroupBox()
        Me.CbbM_Thang1 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Thang2 = New System.Windows.Forms.ComboBox()
        Me.CbbM_Nam = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtM_Tk = New Cyber.SmLists.TxtLookup()
        Me.Txtten_Tk = New System.Windows.Forms.TextBox()
        Me.LabM_Tk = New System.Windows.Forms.Label()
        CType(Me.TxtM_Tk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(492, 119)
        Me.ButtExit.TabIndex = 8
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 80)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 6
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
        Me.ButtOK.TabIndex = 7
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 61)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 58)
        Me.ChkVND.TabIndex = 4
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(219, 58)
        Me.ChkNT.TabIndex = 5
        '
        'LabM_month1
        '
        Me.LabM_month1.AutoSize = True
        Me.LabM_month1.Location = New System.Drawing.Point(10, 33)
        Me.LabM_month1.Name = "LabM_month1"
        Me.LabM_month1.Size = New System.Drawing.Size(51, 13)
        Me.LabM_month1.TabIndex = 13
        Me.LabM_month1.Tag = "Month from"
        Me.LabM_month1.Text = "Từ tháng"
        '
        'LabM_month2
        '
        Me.LabM_month2.AutoSize = True
        Me.LabM_month2.Location = New System.Drawing.Point(219, 33)
        Me.LabM_month2.Name = "LabM_month2"
        Me.LabM_month2.Size = New System.Drawing.Size(58, 13)
        Me.LabM_month2.TabIndex = 14
        Me.LabM_month2.Tag = "Month to"
        Me.LabM_month2.Text = "Đến tháng"
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
        'CbbM_Thang1
        '
        Me.CbbM_Thang1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang1.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang1.FormattingEnabled = True
        Me.CbbM_Thang1.Location = New System.Drawing.Point(95, 30)
        Me.CbbM_Thang1.Name = "CbbM_Thang1"
        Me.CbbM_Thang1.Size = New System.Drawing.Size(114, 21)
        Me.CbbM_Thang1.TabIndex = 1
        '
        'CbbM_Thang2
        '
        Me.CbbM_Thang2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Thang2.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Thang2.FormattingEnabled = True
        Me.CbbM_Thang2.Location = New System.Drawing.Point(296, 30)
        Me.CbbM_Thang2.Name = "CbbM_Thang2"
        Me.CbbM_Thang2.Size = New System.Drawing.Size(114, 21)
        Me.CbbM_Thang2.TabIndex = 2
        '
        'CbbM_Nam
        '
        Me.CbbM_Nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbM_Nam.ForeColor = System.Drawing.Color.Navy
        Me.CbbM_Nam.FormattingEnabled = True
        Me.CbbM_Nam.Location = New System.Drawing.Point(478, 30)
        Me.CbbM_Nam.Name = "CbbM_Nam"
        Me.CbbM_Nam.Size = New System.Drawing.Size(114, 21)
        Me.CbbM_Nam.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(431, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Tag = "Year"
        Me.Label2.Text = "Năm"
        '
        'TxtM_Tk
        '
        Me.TxtM_Tk._ActilookupPopup = False
        Me.TxtM_Tk.CyberActilookupPopup = True
        Me.TxtM_Tk.Dv_ListDetail = Nothing
        Me.TxtM_Tk.Dv_Master = Nothing
        Me.TxtM_Tk.FilterClient = ""
        Me.TxtM_Tk.FilterSQL = ""
        Me.TxtM_Tk.Location = New System.Drawing.Point(94, 5)
        Me.TxtM_Tk.Name = "TxtM_Tk"
        Me.TxtM_Tk.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Tk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Tk.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Tk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Tk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Tk.Size = New System.Drawing.Size(114, 20)
        Me.TxtM_Tk.TabIndex = 0
        Me.TxtM_Tk.Table_Name = ""
        '
        'Txtten_Tk
        '
        Me.Txtten_Tk.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Tk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Tk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Tk.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk.Location = New System.Drawing.Point(210, 12)
        Me.Txtten_Tk.Name = "Txtten_Tk"
        Me.Txtten_Tk.ReadOnly = True
        Me.Txtten_Tk.Size = New System.Drawing.Size(382, 13)
        Me.Txtten_Tk.TabIndex = 147
        Me.Txtten_Tk.TabStop = False
        '
        'LabM_Tk
        '
        Me.LabM_Tk.AutoSize = True
        Me.LabM_Tk.Location = New System.Drawing.Point(10, 8)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(53, 13)
        Me.LabM_Tk.TabIndex = 146
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "Tài khoản"
        '
        'GLCTTK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 172)
        Me.Controls.Add(Me.TxtM_Tk)
        Me.Controls.Add(Me.Txtten_Tk)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.CbbM_Nam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CbbM_Thang2)
        Me.Controls.Add(Me.CbbM_Thang1)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_month2)
        Me.Controls.Add(Me.LabM_month1)
        Me.Name = "GLCTTK"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.CBBMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.ChkVND, 0)
        Me.Controls.SetChildIndex(Me.ChkNT, 0)
        Me.Controls.SetChildIndex(Me.LabLoai_NT, 0)
        Me.Controls.SetChildIndex(Me.LabM_month1, 0)
        Me.Controls.SetChildIndex(Me.LabM_month2, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang1, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Thang2, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.CbbM_Nam, 0)
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Tk, 0)
        CType(Me.TxtM_Tk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabM_month1 As System.Windows.Forms.Label
    Friend WithEvents LabM_month2 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents CbbM_Thang1 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Thang2 As System.Windows.Forms.ComboBox
    Friend WithEvents CbbM_Nam As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtM_Tk As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk As System.Windows.Forms.TextBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label

End Class
