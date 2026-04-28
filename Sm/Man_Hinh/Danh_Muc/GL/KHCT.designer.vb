<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class KHCT
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
        Me.LabTen_KH = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtTen_Vv = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMa_Vv = New Cyber.SmLists.TxtLookup()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTen_tk = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTk = New Cyber.SmLists.TxtLookup()
        Me.TxtTien = New ClsTextBox.txtTien_NT()
        Me.TxtTien_NT = New ClsTextBox.txtTien_NT()
        Me.TxtNam = New System.Windows.Forms.TextBox()
        CType(Me.TxtMa_Vv.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(820, 183)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtExit.TabIndex = 9
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(679, 183)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtOK.TabIndex = 8
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(512, 195)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(132, 197)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChkActi.TabIndex = 6
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(1, 171)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(979, 3)
        Me.GroupBoxLine.TabIndex = 5
        '
        'LabTen_KH
        '
        Me.LabTen_KH.Location = New System.Drawing.Point(35, 129)
        Me.LabTen_KH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTen_KH.Name = "LabTen_KH"
        Me.LabTen_KH.Size = New System.Drawing.Size(91, 21)
        Me.LabTen_KH.TabIndex = 12
        Me.LabTen_KH.Tag = "Amount NT"
        Me.LabTen_KH.Text = "Tiền NT"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(35, 101)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 21)
        Me.Label2.TabIndex = 30
        Me.Label2.Tag = "Amount"
        Me.Label2.Text = "Tiền"
        '
        'TxtTen_Vv
        '
        Me.TxtTen_Vv.BackColor = System.Drawing.Color.White
        Me.TxtTen_Vv.Location = New System.Drawing.Point(333, 76)
        Me.TxtTen_Vv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_Vv.Name = "TxtTen_Vv"
        Me.TxtTen_Vv.Size = New System.Drawing.Size(595, 17)
        Me.TxtTen_Vv.TabIndex = 368
        Me.TxtTen_Vv.Tag = "Group 4"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(35, 73)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 21)
        Me.Label5.TabIndex = 367
        Me.Label5.Tag = "Case"
        Me.Label5.Text = "Vụ việc"
        '
        'TxtMa_Vv
        '
        Me.TxtMa_Vv._ActilookupPopup = False
        Me.TxtMa_Vv.CyberActilookupPopup = True
        Me.TxtMa_Vv.Dv_ListDetail = Nothing
        Me.TxtMa_Vv.Dv_Master = Nothing
        Me.TxtMa_Vv.FilterClient = ""
        Me.TxtMa_Vv.FilterSQL = ""
        Me.TxtMa_Vv.Location = New System.Drawing.Point(127, 69)
        Me.TxtMa_Vv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtMa_Vv.Name = "TxtMa_Vv"
        Me.TxtMa_Vv.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Vv.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Vv.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Vv.Size = New System.Drawing.Size(180, 22)
        Me.TxtMa_Vv.TabIndex = 1
        Me.TxtMa_Vv.Table_Name = ""
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(35, 16)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 25)
        Me.Label10.TabIndex = 381
        Me.Label10.Tag = "Year"
        Me.Label10.Text = "Năm"
        '
        'TxtTen_tk
        '
        Me.TxtTen_tk.BackColor = System.Drawing.Color.White
        Me.TxtTen_tk.Location = New System.Drawing.Point(333, 47)
        Me.TxtTen_tk.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_tk.Name = "TxtTen_tk"
        Me.TxtTen_tk.Size = New System.Drawing.Size(595, 17)
        Me.TxtTen_tk.TabIndex = 384
        Me.TxtTen_tk.Tag = "Group 4"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(35, 46)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 21)
        Me.Label4.TabIndex = 383
        Me.Label4.Tag = "Account"
        Me.Label4.Text = "Tài khoản"
        '
        'TxtTk
        '
        Me.TxtTk._ActilookupPopup = False
        Me.TxtTk.CyberActilookupPopup = True
        Me.TxtTk.Dv_ListDetail = Nothing
        Me.TxtTk.Dv_Master = Nothing
        Me.TxtTk.FilterClient = ""
        Me.TxtTk.FilterSQL = ""
        Me.TxtTk.Location = New System.Drawing.Point(127, 42)
        Me.TxtTk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTk.Name = "TxtTk"
        Me.TxtTk.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtTk.Properties.Appearance.Options.UseForeColor = True
        Me.TxtTk.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtTk.Size = New System.Drawing.Size(180, 22)
        Me.TxtTk.TabIndex = 0
        Me.TxtTk.Table_Name = ""
        '
        'TxtTien
        '
        Me.TxtTien.AllowNegative = True
        Me.TxtTien.Flags = 7680
        Me.TxtTien.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTien.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien.InputMask = "### ### ### ### ###.##"
        Me.TxtTien.Location = New System.Drawing.Point(127, 97)
        Me.TxtTien.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTien.MaxWholeDigits = 17
        Me.TxtTien.Name = "TxtTien"
        Me.TxtTien.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien.Size = New System.Drawing.Size(179, 24)
        Me.TxtTien.TabIndex = 2
        Me.TxtTien.Tag = "### ### ### ### ###.##"
        Me.TxtTien.Text = "0.00"
        Me.TxtTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtTien_NT
        '
        Me.TxtTien_NT.AllowNegative = True
        Me.TxtTien_NT.Flags = 7680
        Me.TxtTien_NT.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TxtTien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTien_NT.InputMask = "### ### ### ### ###.##"
        Me.TxtTien_NT.Location = New System.Drawing.Point(127, 126)
        Me.TxtTien_NT.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtTien_NT.MaxWholeDigits = 17
        Me.TxtTien_NT.Name = "TxtTien_NT"
        Me.TxtTien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtTien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtTien_NT.Size = New System.Drawing.Size(179, 24)
        Me.TxtTien_NT.TabIndex = 3
        Me.TxtTien_NT.Tag = "### ### ### ### ###.##"
        Me.TxtTien_NT.Text = "0.00"
        Me.TxtTien_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TxtNam
        '
        Me.TxtNam.BackColor = System.Drawing.Color.White
        Me.TxtNam.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNam.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtNam.ForeColor = System.Drawing.Color.Navy
        Me.TxtNam.Location = New System.Drawing.Point(127, 10)
        Me.TxtNam.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TxtNam.Name = "TxtNam"
        Me.TxtNam.ReadOnly = True
        Me.TxtNam.Size = New System.Drawing.Size(179, 24)
        Me.TxtNam.TabIndex = 385
        Me.TxtNam.TabStop = False
        '
        'KHCT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(969, 238)
        Me.Controls.Add(Me.TxtNam)
        Me.Controls.Add(Me.TxtTien_NT)
        Me.Controls.Add(Me.TxtTien)
        Me.Controls.Add(Me.TxtTen_tk)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtTk)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTen_Vv)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtMa_Vv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabTen_KH)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "KHCT"
        Me.Text = "Cập nhật dự toán công trình"
        Me.Controls.SetChildIndex(Me.LabTen_KH, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Vv, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Vv, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtTk, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_tk, 0)
        Me.Controls.SetChildIndex(Me.TxtTien, 0)
        Me.Controls.SetChildIndex(Me.TxtTien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtNam, 0)
        CType(Me.TxtMa_Vv.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtTk.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabTen_KH As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Vv As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Vv As Cyber.SmLists.TxtLookup
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_tk As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTk As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTien As ClsTextBox.txtTien_NT
    Friend WithEvents TxtTien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtNam As System.Windows.Forms.TextBox

End Class
