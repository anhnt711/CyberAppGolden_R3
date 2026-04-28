<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GLSD1
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
        Me.ButtExit.Location = New System.Drawing.Point(492, 121)
        Me.ButtExit.TabIndex = 6
        '
        'CBBMa_Dvcs
        '
        Me.CBBMa_Dvcs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CBBMa_Dvcs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBBMa_Dvcs.Location = New System.Drawing.Point(95, 82)
        Me.CBBMa_Dvcs.Size = New System.Drawing.Size(491, 21)
        Me.CBBMa_Dvcs.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(10, 85)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(388, 121)
        Me.ButtOK.TabIndex = 5
        '
        'LabLoai_NT
        '
        Me.LabLoai_NT.Location = New System.Drawing.Point(10, 63)
        '
        'ChkVND
        '
        Me.ChkVND.Location = New System.Drawing.Point(95, 60)
        Me.ChkVND.TabIndex = 2
        '
        'ChkNT
        '
        Me.ChkNT.Location = New System.Drawing.Point(210, 60)
        Me.ChkNT.TabIndex = 3
        '
        'TxtM_Ngay_Ct
        '
        Me.TxtM_Ngay_Ct.Flags = 0
        Me.TxtM_Ngay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Ngay_Ct.IsAllowResize = False
        Me.TxtM_Ngay_Ct.Location = New System.Drawing.Point(95, 6)
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
        Me.LabM_Ngay_Ct1.Location = New System.Drawing.Point(10, 9)
        Me.LabM_Ngay_Ct1.Name = "LabM_Ngay_Ct1"
        Me.LabM_Ngay_Ct1.Size = New System.Drawing.Size(32, 13)
        Me.LabM_Ngay_Ct1.TabIndex = 13
        Me.LabM_Ngay_Ct1.Tag = "Date "
        Me.LabM_Ngay_Ct1.Text = "Ngày"
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBoxLine.Location = New System.Drawing.Point(4, 104)
        Me.GroupBoxLine.Name = "GroupBoxLine"
        Me.GroupBoxLine.Size = New System.Drawing.Size(589, 9)
        Me.GroupBoxLine.TabIndex = 15
        Me.GroupBoxLine.TabStop = False
        '
        'TxtM_Tk
        '
        Me.TxtM_Tk._ActilookupPopup = False
        Me.TxtM_Tk.CyberActilookupPopup = True
        Me.TxtM_Tk.Dv_ListDetail = Nothing
        Me.TxtM_Tk.Dv_Master = Nothing
        Me.TxtM_Tk.FilterClient = ""
        Me.TxtM_Tk.FilterSQL = ""
        Me.TxtM_Tk.Location = New System.Drawing.Point(95, 32)
        Me.TxtM_Tk.Name = "TxtM_Tk"
        Me.TxtM_Tk.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.TxtM_Tk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtM_Tk.Properties.Appearance.Options.UseFont = True
        Me.TxtM_Tk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtM_Tk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtM_Tk.Size = New System.Drawing.Size(114, 20)
        Me.TxtM_Tk.TabIndex = 1
        Me.TxtM_Tk.Table_Name = ""
        '
        'Txtten_Tk
        '
        Me.Txtten_Tk.BackColor = System.Drawing.SystemColors.Control
        Me.Txtten_Tk.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Txtten_Tk.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Txtten_Tk.ForeColor = System.Drawing.Color.Navy
        Me.Txtten_Tk.Location = New System.Drawing.Point(210, 39)
        Me.Txtten_Tk.Name = "Txtten_Tk"
        Me.Txtten_Tk.ReadOnly = True
        Me.Txtten_Tk.Size = New System.Drawing.Size(382, 13)
        Me.Txtten_Tk.TabIndex = 147
        Me.Txtten_Tk.TabStop = False
        '
        'LabM_Tk
        '
        Me.LabM_Tk.AutoSize = True
        Me.LabM_Tk.Location = New System.Drawing.Point(10, 35)
        Me.LabM_Tk.Name = "LabM_Tk"
        Me.LabM_Tk.Size = New System.Drawing.Size(53, 13)
        Me.LabM_Tk.TabIndex = 146
        Me.LabM_Tk.Tag = "Account"
        Me.LabM_Tk.Text = "Tài khoản"
        '
        'GLSD1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(596, 174)
        Me.Controls.Add(Me.TxtM_Tk)
        Me.Controls.Add(Me.Txtten_Tk)
        Me.Controls.Add(Me.LabM_Tk)
        Me.Controls.Add(Me.GroupBoxLine)
        Me.Controls.Add(Me.LabM_Ngay_Ct1)
        Me.Controls.Add(Me.TxtM_Ngay_Ct)
        Me.Name = "GLSD1"
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
        Me.Controls.SetChildIndex(Me.LabM_Tk, 0)
        Me.Controls.SetChildIndex(Me.Txtten_Tk, 0)
        Me.Controls.SetChildIndex(Me.TxtM_Tk, 0)
        CType(Me.TxtM_Tk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtM_Ngay_Ct As ClsTextBox.txtDate1
    Friend WithEvents LabM_Ngay_Ct1 As System.Windows.Forms.Label
    Friend WithEvents GroupBoxLine As System.Windows.Forms.GroupBox
    Friend WithEvents TxtM_Tk As Cyber.SmLists.TxtLookup
    Friend WithEvents Txtten_Tk As System.Windows.Forms.TextBox
    Friend WithEvents LabM_Tk As System.Windows.Forms.Label

End Class
