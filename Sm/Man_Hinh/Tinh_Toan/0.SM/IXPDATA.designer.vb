<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IXPDATA
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
        Me.Tab_RaVaoSolieu = New System.Windows.Forms.TabControl()
        Me.TabEx = New System.Windows.Forms.TabPage()
        Me.ChkEBak = New System.Windows.Forms.CheckBox()
        Me.CmdEXL_ma_Dvsc = New System.Windows.Forms.Button()
        Me.TxtL_ma_DVCS = New System.Windows.Forms.TextBox()
        Me.CmdEXFile_Copy = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CmdEXFile_Export = New System.Windows.Forms.Button()
        Me.CmdEXHistory_Export = New System.Windows.Forms.Button()
        Me.TxtFile_Export = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtxDTo = New ClsTextBox.txtDate1()
        Me.TxtxDFrom = New ClsTextBox.txtDate1()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TabIm = New System.Windows.Forms.TabPage()
        Me.ChkIBak = New System.Windows.Forms.CheckBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.TxtIL_Ma_DVCS = New System.Windows.Forms.TextBox()
        Me.TxtIDTo = New ClsTextBox.txtDate1()
        Me.TxtIDFrom = New ClsTextBox.txtDate1()
        Me.CmdIHistory_Import = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CmdIFile_Import = New System.Windows.Forms.Button()
        Me.TxtFile_Import = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblHistory = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialogInput = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialogOuput = New System.Windows.Forms.OpenFileDialog()
        Me.Tab_RaVaoSolieu.SuspendLayout()
        Me.TabEx.SuspendLayout()
        Me.TabIm.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(3, 208)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBoxLine.Size = New System.Drawing.Size(745, 10)
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(479, 220)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtOK.TabIndex = 1
        Me.ButtOK.Tag = "&Ok"
        Me.ButtOK.Text = "&Chấp nhận"
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(615, 220)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtExit.TabIndex = 2
        '
        'Tab_RaVaoSolieu
        '
        Me.Tab_RaVaoSolieu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_RaVaoSolieu.Controls.Add(Me.TabEx)
        Me.Tab_RaVaoSolieu.Controls.Add(Me.TabIm)
        Me.Tab_RaVaoSolieu.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Tab_RaVaoSolieu.Location = New System.Drawing.Point(4, 6)
        Me.Tab_RaVaoSolieu.Margin = New System.Windows.Forms.Padding(4)
        Me.Tab_RaVaoSolieu.Name = "Tab_RaVaoSolieu"
        Me.Tab_RaVaoSolieu.SelectedIndex = 0
        Me.Tab_RaVaoSolieu.Size = New System.Drawing.Size(741, 212)
        Me.Tab_RaVaoSolieu.TabIndex = 0
        '
        'TabEx
        '
        Me.TabEx.BackColor = System.Drawing.Color.Transparent
        Me.TabEx.Controls.Add(Me.ChkEBak)
        Me.TabEx.Controls.Add(Me.CmdEXL_ma_Dvsc)
        Me.TabEx.Controls.Add(Me.TxtL_ma_DVCS)
        Me.TabEx.Controls.Add(Me.CmdEXFile_Copy)
        Me.TabEx.Controls.Add(Me.Label12)
        Me.TabEx.Controls.Add(Me.CmdEXFile_Export)
        Me.TabEx.Controls.Add(Me.CmdEXHistory_Export)
        Me.TabEx.Controls.Add(Me.TxtFile_Export)
        Me.TabEx.Controls.Add(Me.Label15)
        Me.TabEx.Controls.Add(Me.TxtxDTo)
        Me.TabEx.Controls.Add(Me.TxtxDFrom)
        Me.TabEx.Controls.Add(Me.Label13)
        Me.TabEx.Controls.Add(Me.Label11)
        Me.TabEx.Controls.Add(Me.Label14)
        Me.TabEx.Controls.Add(Me.Label16)
        Me.TabEx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabEx.ForeColor = System.Drawing.Color.Navy
        Me.TabEx.Location = New System.Drawing.Point(4, 25)
        Me.TabEx.Margin = New System.Windows.Forms.Padding(4)
        Me.TabEx.Name = "TabEx"
        Me.TabEx.Padding = New System.Windows.Forms.Padding(4)
        Me.TabEx.Size = New System.Drawing.Size(733, 183)
        Me.TabEx.TabIndex = 0
        Me.TabEx.Tag = "Export data"
        Me.TabEx.Text = "Truyền dữ liệu"
        Me.TabEx.UseVisualStyleBackColor = True
        '
        'ChkEBak
        '
        Me.ChkEBak.AutoSize = True
        Me.ChkEBak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkEBak.Location = New System.Drawing.Point(140, 91)
        Me.ChkEBak.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkEBak.Name = "ChkEBak"
        Me.ChkEBak.Size = New System.Drawing.Size(268, 21)
        Me.ChkEBak.TabIndex = 8
        Me.ChkEBak.Tag = "Backup database"
        Me.ChkEBak.Text = "Lưu trữ dữ liệu trước lúc truyền số liệu"
        Me.ChkEBak.UseVisualStyleBackColor = True
        '
        'CmdEXL_ma_Dvsc
        '
        Me.CmdEXL_ma_Dvsc.Location = New System.Drawing.Point(676, 37)
        Me.CmdEXL_ma_Dvsc.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdEXL_ma_Dvsc.Name = "CmdEXL_ma_Dvsc"
        Me.CmdEXL_ma_Dvsc.Size = New System.Drawing.Size(40, 25)
        Me.CmdEXL_ma_Dvsc.TabIndex = 5
        Me.CmdEXL_ma_Dvsc.Text = "..."
        Me.CmdEXL_ma_Dvsc.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEXL_ma_Dvsc.UseVisualStyleBackColor = True
        '
        'TxtL_ma_DVCS
        '
        Me.TxtL_ma_DVCS.BackColor = System.Drawing.Color.White
        Me.TxtL_ma_DVCS.ForeColor = System.Drawing.Color.Navy
        Me.TxtL_ma_DVCS.Location = New System.Drawing.Point(140, 37)
        Me.TxtL_ma_DVCS.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtL_ma_DVCS.Name = "TxtL_ma_DVCS"
        Me.TxtL_ma_DVCS.ReadOnly = True
        Me.TxtL_ma_DVCS.Size = New System.Drawing.Size(524, 23)
        Me.TxtL_ma_DVCS.TabIndex = 4
        '
        'CmdEXFile_Copy
        '
        Me.CmdEXFile_Copy.Location = New System.Drawing.Point(676, 7)
        Me.CmdEXFile_Copy.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdEXFile_Copy.Name = "CmdEXFile_Copy"
        Me.CmdEXFile_Copy.Size = New System.Drawing.Size(40, 25)
        Me.CmdEXFile_Copy.TabIndex = 3
        Me.CmdEXFile_Copy.Text = "..."
        Me.CmdEXFile_Copy.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEXFile_Copy.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(544, 11)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(118, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Tag = "Files copy"
        Me.Label12.Text = "Các tệp sao chép"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CmdEXFile_Export
        '
        Me.CmdEXFile_Export.Location = New System.Drawing.Point(676, 63)
        Me.CmdEXFile_Export.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdEXFile_Export.Name = "CmdEXFile_Export"
        Me.CmdEXFile_Export.Size = New System.Drawing.Size(40, 25)
        Me.CmdEXFile_Export.TabIndex = 7
        Me.CmdEXFile_Export.Text = "..."
        Me.CmdEXFile_Export.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEXFile_Export.UseVisualStyleBackColor = True
        '
        'CmdEXHistory_Export
        '
        Me.CmdEXHistory_Export.Location = New System.Drawing.Point(140, 112)
        Me.CmdEXHistory_Export.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdEXHistory_Export.Name = "CmdEXHistory_Export"
        Me.CmdEXHistory_Export.Size = New System.Drawing.Size(40, 30)
        Me.CmdEXHistory_Export.TabIndex = 9
        Me.CmdEXHistory_Export.Text = "..."
        Me.CmdEXHistory_Export.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CmdEXHistory_Export.UseVisualStyleBackColor = True
        '
        'TxtFile_Export
        '
        Me.TxtFile_Export.BackColor = System.Drawing.Color.White
        Me.TxtFile_Export.ForeColor = System.Drawing.Color.Navy
        Me.TxtFile_Export.Location = New System.Drawing.Point(140, 63)
        Me.TxtFile_Export.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFile_Export.Name = "TxtFile_Export"
        Me.TxtFile_Export.ReadOnly = True
        Me.TxtFile_Export.Size = New System.Drawing.Size(524, 23)
        Me.TxtFile_Export.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(288, 12)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(69, 17)
        Me.Label15.TabIndex = 231
        Me.Label15.Tag = "Date to "
        Me.Label15.Text = "Đến ngày"
        '
        'TxtxDTo
        '
        Me.TxtxDTo.Flags = 65536
        Me.TxtxDTo.ForeColor = System.Drawing.Color.Navy
        Me.TxtxDTo.IsAllowResize = False
        Me.TxtxDTo.isEmpty = True
        Me.TxtxDTo.Location = New System.Drawing.Point(387, 7)
        Me.TxtxDTo.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtxDTo.MaskDate = "dd/MM/yyyy"
        Me.TxtxDTo.MaxLength = 10
        Me.TxtxDTo.Name = "TxtxDTo"
        Me.TxtxDTo.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtxDTo.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtxDTo.ShowDayBeforeMonth = False
        Me.TxtxDTo.Size = New System.Drawing.Size(141, 23)
        Me.TxtxDTo.TabIndex = 1
        Me.TxtxDTo.Text = "07/09/2011"
        Me.TxtxDTo.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtxDFrom
        '
        Me.TxtxDFrom.Flags = 65536
        Me.TxtxDFrom.ForeColor = System.Drawing.Color.Navy
        Me.TxtxDFrom.IsAllowResize = False
        Me.TxtxDFrom.isEmpty = True
        Me.TxtxDFrom.Location = New System.Drawing.Point(140, 7)
        Me.TxtxDFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtxDFrom.MaskDate = "dd/MM/yyyy"
        Me.TxtxDFrom.MaxLength = 10
        Me.TxtxDFrom.Name = "TxtxDFrom"
        Me.TxtxDFrom.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtxDFrom.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtxDFrom.ShowDayBeforeMonth = False
        Me.TxtxDFrom.Size = New System.Drawing.Size(141, 23)
        Me.TxtxDFrom.TabIndex = 0
        Me.TxtxDFrom.Text = "07/09/2011"
        Me.TxtxDFrom.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'Label13
        '
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(9, 118)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 16)
        Me.Label13.TabIndex = 234
        Me.Label13.Tag = "History (Exports)"
        Me.Label13.Text = "Lịch sử copy ra"
        '
        'Label11
        '
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(9, 42)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(123, 16)
        Me.Label11.TabIndex = 239
        Me.Label11.Tag = "Units"
        Me.Label11.Text = "Đơn vị hạch toán"
        '
        'Label14
        '
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(9, 68)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 16)
        Me.Label14.TabIndex = 232
        Me.Label14.Tag = "File Name (Export)"
        Me.Label14.Text = "Tệp lưu trữ"
        '
        'Label16
        '
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(9, 11)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(128, 21)
        Me.Label16.TabIndex = 230
        Me.Label16.Tag = "Date from"
        Me.Label16.Text = "Từ ngày"
        '
        'TabIm
        '
        Me.TabIm.BackColor = System.Drawing.Color.Transparent
        Me.TabIm.Controls.Add(Me.ChkIBak)
        Me.TabIm.Controls.Add(Me.ProgressBar1)
        Me.TabIm.Controls.Add(Me.TxtIL_Ma_DVCS)
        Me.TabIm.Controls.Add(Me.TxtIDTo)
        Me.TabIm.Controls.Add(Me.TxtIDFrom)
        Me.TabIm.Controls.Add(Me.CmdIHistory_Import)
        Me.TabIm.Controls.Add(Me.Label7)
        Me.TabIm.Controls.Add(Me.CmdIFile_Import)
        Me.TabIm.Controls.Add(Me.TxtFile_Import)
        Me.TabIm.Controls.Add(Me.Label2)
        Me.TabIm.Controls.Add(Me.LblHistory)
        Me.TabIm.Controls.Add(Me.Label6)
        Me.TabIm.Controls.Add(Me.Label5)
        Me.TabIm.Location = New System.Drawing.Point(4, 25)
        Me.TabIm.Margin = New System.Windows.Forms.Padding(4)
        Me.TabIm.Name = "TabIm"
        Me.TabIm.Padding = New System.Windows.Forms.Padding(4)
        Me.TabIm.Size = New System.Drawing.Size(733, 183)
        Me.TabIm.TabIndex = 1
        Me.TabIm.Tag = "Import Data"
        Me.TabIm.Text = "Nhận dữ liệu"
        Me.TabIm.UseVisualStyleBackColor = True
        '
        'ChkIBak
        '
        Me.ChkIBak.AutoSize = True
        Me.ChkIBak.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.ChkIBak.Location = New System.Drawing.Point(136, 101)
        Me.ChkIBak.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkIBak.Name = "ChkIBak"
        Me.ChkIBak.Size = New System.Drawing.Size(260, 21)
        Me.ChkIBak.TabIndex = 4
        Me.ChkIBak.Tag = "Backup database"
        Me.ChkIBak.Text = "Lưu trữ dữ liệu trước lúc nhận số liệu"
        Me.ChkIBak.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(185, 127)
        Me.ProgressBar1.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(528, 28)
        Me.ProgressBar1.TabIndex = 246
        Me.ProgressBar1.Visible = False
        '
        'TxtIL_Ma_DVCS
        '
        Me.TxtIL_Ma_DVCS.BackColor = System.Drawing.Color.White
        Me.TxtIL_Ma_DVCS.ForeColor = System.Drawing.Color.Navy
        Me.TxtIL_Ma_DVCS.Location = New System.Drawing.Point(136, 38)
        Me.TxtIL_Ma_DVCS.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtIL_Ma_DVCS.Name = "TxtIL_Ma_DVCS"
        Me.TxtIL_Ma_DVCS.ReadOnly = True
        Me.TxtIL_Ma_DVCS.Size = New System.Drawing.Size(524, 22)
        Me.TxtIL_Ma_DVCS.TabIndex = 1
        '
        'TxtIDTo
        '
        Me.TxtIDTo.Enabled = False
        Me.TxtIDTo.Flags = 65536
        Me.TxtIDTo.ForeColor = System.Drawing.Color.Navy
        Me.TxtIDTo.IsAllowResize = False
        Me.TxtIDTo.isEmpty = True
        Me.TxtIDTo.Location = New System.Drawing.Point(381, 69)
        Me.TxtIDTo.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtIDTo.MaskDate = "dd/MM/yyyy"
        Me.TxtIDTo.MaxLength = 10
        Me.TxtIDTo.Name = "TxtIDTo"
        Me.TxtIDTo.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtIDTo.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtIDTo.ReadOnly = True
        Me.TxtIDTo.ShowDayBeforeMonth = False
        Me.TxtIDTo.Size = New System.Drawing.Size(141, 22)
        Me.TxtIDTo.TabIndex = 3
        Me.TxtIDTo.Text = "07/09/2011"
        Me.TxtIDTo.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'TxtIDFrom
        '
        Me.TxtIDFrom.Enabled = False
        Me.TxtIDFrom.Flags = 65536
        Me.TxtIDFrom.ForeColor = System.Drawing.Color.Navy
        Me.TxtIDFrom.IsAllowResize = False
        Me.TxtIDFrom.isEmpty = True
        Me.TxtIDFrom.Location = New System.Drawing.Point(136, 69)
        Me.TxtIDFrom.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtIDFrom.MaskDate = "dd/MM/yyyy"
        Me.TxtIDFrom.MaxLength = 10
        Me.TxtIDFrom.Name = "TxtIDFrom"
        Me.TxtIDFrom.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtIDFrom.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtIDFrom.ReadOnly = True
        Me.TxtIDFrom.ShowDayBeforeMonth = False
        Me.TxtIDFrom.Size = New System.Drawing.Size(141, 22)
        Me.TxtIDFrom.TabIndex = 2
        Me.TxtIDFrom.Text = "07/09/2011"
        Me.TxtIDFrom.Value = New Date(2011, 9, 7, 0, 0, 0, 0)
        '
        'CmdIHistory_Import
        '
        Me.CmdIHistory_Import.Location = New System.Drawing.Point(136, 128)
        Me.CmdIHistory_Import.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdIHistory_Import.Name = "CmdIHistory_Import"
        Me.CmdIHistory_Import.Size = New System.Drawing.Size(41, 25)
        Me.CmdIHistory_Import.TabIndex = 5
        Me.CmdIHistory_Import.Text = "..."
        Me.CmdIHistory_Import.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(297, 74)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 4
        Me.Label7.Tag = "Date to"
        Me.Label7.Text = "Đến ngày"
        '
        'CmdIFile_Import
        '
        Me.CmdIFile_Import.Location = New System.Drawing.Point(669, 10)
        Me.CmdIFile_Import.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdIFile_Import.Name = "CmdIFile_Import"
        Me.CmdIFile_Import.Size = New System.Drawing.Size(41, 25)
        Me.CmdIFile_Import.TabIndex = 2
        Me.CmdIFile_Import.Text = "..."
        Me.CmdIFile_Import.UseVisualStyleBackColor = True
        '
        'TxtFile_Import
        '
        Me.TxtFile_Import.BackColor = System.Drawing.Color.White
        Me.TxtFile_Import.Location = New System.Drawing.Point(136, 10)
        Me.TxtFile_Import.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtFile_Import.Name = "TxtFile_Import"
        Me.TxtFile_Import.ReadOnly = True
        Me.TxtFile_Import.Size = New System.Drawing.Size(524, 22)
        Me.TxtFile_Import.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(3, 38)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(261, 16)
        Me.Label2.TabIndex = 244
        Me.Label2.Tag = "Units"
        Me.Label2.Text = "Đơn vị hạch toán"
        '
        'LblHistory
        '
        Me.LblHistory.Location = New System.Drawing.Point(3, 128)
        Me.LblHistory.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblHistory.Name = "LblHistory"
        Me.LblHistory.Size = New System.Drawing.Size(220, 25)
        Me.LblHistory.TabIndex = 8
        Me.LblHistory.Tag = "History (Imports)"
        Me.LblHistory.Text = "Lịch sử copy vào"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(3, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(129, 22)
        Me.Label6.TabIndex = 3
        Me.Label6.Tag = "Date from"
        Me.Label6.Text = "Từ ngày"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(3, 14)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(261, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Tag = "File Name (Import)"
        Me.Label5.Text = "Tên tệp lưu trữ"
        '
        'IXPDATA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(751, 287)
        Me.Controls.Add(Me.Tab_RaVaoSolieu)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "IXPDATA"
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.Tab_RaVaoSolieu, 0)
        Me.Tab_RaVaoSolieu.ResumeLayout(False)
        Me.TabEx.ResumeLayout(False)
        Me.TabEx.PerformLayout()
        Me.TabIm.ResumeLayout(False)
        Me.TabIm.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Tab_RaVaoSolieu As System.Windows.Forms.TabControl
    Friend WithEvents TabEx As System.Windows.Forms.TabPage
    Friend WithEvents ChkEBak As System.Windows.Forms.CheckBox
    Friend WithEvents CmdEXL_ma_Dvsc As System.Windows.Forms.Button
    Friend WithEvents TxtL_ma_DVCS As System.Windows.Forms.TextBox
    Friend WithEvents CmdEXFile_Copy As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CmdEXFile_Export As System.Windows.Forms.Button
    Friend WithEvents CmdEXHistory_Export As System.Windows.Forms.Button
    Friend WithEvents TxtFile_Export As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TxtxDTo As ClsTextBox.txtDate1
    Friend WithEvents TxtxDFrom As ClsTextBox.txtDate1
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TabIm As System.Windows.Forms.TabPage
    Friend WithEvents ChkIBak As System.Windows.Forms.CheckBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents TxtIL_Ma_DVCS As System.Windows.Forms.TextBox
    Friend WithEvents TxtIDTo As ClsTextBox.txtDate1
    Friend WithEvents TxtIDFrom As ClsTextBox.txtDate1
    Friend WithEvents CmdIHistory_Import As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmdIFile_Import As System.Windows.Forms.Button
    Friend WithEvents TxtFile_Import As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblHistory As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialogInput As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialogOuput As System.Windows.Forms.OpenFileDialog

End Class
