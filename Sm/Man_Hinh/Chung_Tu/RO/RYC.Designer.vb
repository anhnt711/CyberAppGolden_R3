<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RYC
    Inherits Cyber.From.Frmvoucher

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
        Me.components = New System.ComponentModel.Container()
        Me.CbbMa_GD = New System.Windows.Forms.ComboBox()
        Me.LabDia_Chi = New System.Windows.Forms.Label()
        Me.TxtDia_Chi = New System.Windows.Forms.TextBox()
        Me.TxtMa_Quyen = New System.Windows.Forms.TextBox()
        Me.LabMa_Quyen = New System.Windows.Forms.Label()
        Me.LabNgay_LCt = New System.Windows.Forms.Label()
        Me.LabNgay_Ct = New System.Windows.Forms.Label()
        Me.txtDien_giai = New System.Windows.Forms.TextBox()
        Me.LabDien_Giai = New System.Windows.Forms.Label()
        Me.lblLoai_ct = New System.Windows.Forms.Label()
        Me.txtOng_ba = New System.Windows.Forms.TextBox()
        Me.LabOng_ba = New System.Windows.Forms.Label()
        Me.lblSo_ct = New System.Windows.Forms.Label()
        Me.txtSo_ct = New System.Windows.Forms.TextBox()
        Me.LabMa_kh = New System.Windows.Forms.Label()
        Me.LabMa_NT = New System.Windows.Forms.Label()
        Me.TxtTy_Gia = New ClsTextBox.txtTy_Gia()
        Me.TxtNgay_LCt = New ClsTextBox.txtDate()
        Me.TxtNgay_Ct = New ClsTextBox.txtDate()
        Me.TxtMa_NT = New System.Windows.Forms.TextBox()
        Me.Detail = New DevExpress.XtraGrid.GridControl()
        Me.DetailGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemTextEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LabTy_gia = New System.Windows.Forms.Label()
        Me.TxtTen_kh = New System.Windows.Forms.TextBox()
        Me.TxtMa_Kh = New Cyber.SmLists.TxtLookup()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.TxtT_Tien_NT = New ClsTextBox.txtTien_NT()
        Me.TxtT_Tien = New ClsTextBox.txtTien_NT()
        Me.LabT_TT_NT = New System.Windows.Forms.Label()
        Me.TxtMa_Dvcs = New System.Windows.Forms.TextBox()
        Me.TxtStt_Rec = New System.Windows.Forms.TextBox()
        Me.PopupMenuMasterGrid = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.ChkPN_Gia_TB = New System.Windows.Forms.CheckBox()
        Me.LabLenh_RO = New System.Windows.Forms.Label()
        Me.TxtLenh_RO = New System.Windows.Forms.TextBox()
        Me.LabLenh_PO = New System.Windows.Forms.Label()
        Me.TxtLenh_PO = New System.Windows.Forms.TextBox()
        Me.LabLenh_SO = New System.Windows.Forms.Label()
        Me.TxtLenh_SO = New System.Windows.Forms.TextBox()
        Me.LabT_So_Luong = New System.Windows.Forms.Label()
        Me.TxtT_SO_LUONG = New ClsTextBox.txtTien_NT()
        Me.TxtLenh_Vt = New System.Windows.Forms.TextBox()
        Me.TxtGio_CT = New System.Windows.Forms.TextBox()
        Me.LabMa_Xe = New System.Windows.Forms.Label()
        Me.CbbMa_KX = New System.Windows.Forms.ComboBox()
        Me.label = New System.Windows.Forms.Label()
        Me.TxtMa_Xe = New System.Windows.Forms.TextBox()
        Me.TxtDia_ChiVAT = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTen_khVAT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtTen_Lx = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtDien_Thoai = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtDt_LX = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChkScc = New System.Windows.Forms.CheckBox()
        Me.ChkTv = New System.Windows.Forms.CheckBox()
        Me.ChkBd = New System.Windows.Forms.CheckBox()
        Me.TxtE_Mail = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtTen_GD = New System.Windows.Forms.TextBox()
        Me.ChkNonVAT = New System.Windows.Forms.CheckBox()
        Me.LabMa_TTCP_H = New System.Windows.Forms.Label()
        Me.CbbMa_TTCP_H = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdEdit
        '
        Me.CmdEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdEdit.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdEdit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdEdit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdEdit.Appearance.Options.UseBackColor = True
        Me.CmdEdit.Appearance.Options.UseFont = True
        Me.CmdEdit.Appearance.Options.UseForeColor = True
        Me.CmdEdit.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdEdit.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdEdit.Location = New System.Drawing.Point(286, 235)
        Me.CmdEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdEdit.Size = New System.Drawing.Size(91, 39)
        '
        'CmdSave
        '
        Me.CmdSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdSave.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSave.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdSave.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSave.Appearance.Options.UseBackColor = True
        Me.CmdSave.Appearance.Options.UseFont = True
        Me.CmdSave.Appearance.Options.UseForeColor = True
        Me.CmdSave.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSave.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdSave.Location = New System.Drawing.Point(6, 235)
        Me.CmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSave.Size = New System.Drawing.Size(91, 39)
        Me.CmdSave.TabIndex = 22
        '
        'CmdView
        '
        Me.CmdView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdView.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdView.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdView.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdView.Appearance.Options.UseBackColor = True
        Me.CmdView.Appearance.Options.UseFont = True
        Me.CmdView.Appearance.Options.UseForeColor = True
        Me.CmdView.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdView.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdView.Location = New System.Drawing.Point(565, 235)
        Me.CmdView.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdView.Size = New System.Drawing.Size(91, 39)
        Me.CmdView.TabIndex = 28
        '
        'LabMa_Post
        '
        Me.LabMa_Post.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabMa_Post.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Post.Location = New System.Drawing.Point(529, 38)
        Me.LabMa_Post.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Post.Size = New System.Drawing.Size(63, 16)
        '
        'CmdSms
        '
        Me.CmdSms.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdSms.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSms.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdSms.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSms.Appearance.Options.UseBackColor = True
        Me.CmdSms.Appearance.Options.UseFont = True
        Me.CmdSms.Appearance.Options.UseForeColor = True
        Me.CmdSms.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSms.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdSms.Location = New System.Drawing.Point(863, 235)
        Me.CmdSms.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSms.Size = New System.Drawing.Size(50, 39)
        Me.CmdSms.TabIndex = 32
        '
        'CmdImport
        '
        Me.CmdImport.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdImport.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdImport.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdImport.Appearance.Options.UseBackColor = True
        Me.CmdImport.Appearance.Options.UseFont = True
        Me.CmdImport.Appearance.Options.UseForeColor = True
        Me.CmdImport.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdImport.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdImport.Location = New System.Drawing.Point(778, 566)
        Me.CmdImport.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdImport.Size = New System.Drawing.Size(50, 39)
        Me.CmdImport.TabIndex = 24
        '
        'CbbMa_Post
        '
        Me.CbbMa_Post.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_Post.Location = New System.Drawing.Point(595, 34)
        Me.CbbMa_Post.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_Post.Size = New System.Drawing.Size(195, 24)
        Me.CbbMa_Post.TabIndex = 17
        '
        'CmdExit
        '
        Me.CmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdExit.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdExit.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdExit.Appearance.Options.UseBackColor = True
        Me.CmdExit.Appearance.Options.UseFont = True
        Me.CmdExit.Appearance.Options.UseForeColor = True
        Me.CmdExit.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdExit.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdExit.Location = New System.Drawing.Point(751, 235)
        Me.CmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdExit.Size = New System.Drawing.Size(91, 39)
        Me.CmdExit.TabIndex = 31
        '
        'CmdSearch
        '
        Me.CmdSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdSearch.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdSearch.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdSearch.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdSearch.Appearance.Options.UseBackColor = True
        Me.CmdSearch.Appearance.Options.UseFont = True
        Me.CmdSearch.Appearance.Options.UseForeColor = True
        Me.CmdSearch.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdSearch.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdSearch.Location = New System.Drawing.Point(659, 235)
        Me.CmdSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdSearch.Size = New System.Drawing.Size(91, 39)
        Me.CmdSearch.TabIndex = 30
        '
        'CmdCopy
        '
        Me.CmdCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdCopy.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCopy.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdCopy.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdCopy.Appearance.Options.UseBackColor = True
        Me.CmdCopy.Appearance.Options.UseFont = True
        Me.CmdCopy.Appearance.Options.UseForeColor = True
        Me.CmdCopy.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdCopy.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdCopy.Location = New System.Drawing.Point(474, 235)
        Me.CmdCopy.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCopy.Size = New System.Drawing.Size(91, 39)
        Me.CmdCopy.TabIndex = 27
        '
        'CmdDelete
        '
        Me.CmdDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdDelete.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdDelete.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdDelete.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdDelete.Appearance.Options.UseBackColor = True
        Me.CmdDelete.Appearance.Options.UseFont = True
        Me.CmdDelete.Appearance.Options.UseForeColor = True
        Me.CmdDelete.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdDelete.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdDelete.Location = New System.Drawing.Point(380, 235)
        Me.CmdDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdDelete.Size = New System.Drawing.Size(91, 39)
        Me.CmdDelete.TabIndex = 26
        '
        'CmdPrint
        '
        Me.CmdPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdPrint.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdPrint.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdPrint.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPrint.Appearance.Options.UseBackColor = True
        Me.CmdPrint.Appearance.Options.UseFont = True
        Me.CmdPrint.Appearance.Options.UseForeColor = True
        Me.CmdPrint.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdPrint.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdPrint.Location = New System.Drawing.Point(194, 235)
        Me.CmdPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdPrint.Size = New System.Drawing.Size(91, 39)
        Me.CmdPrint.TabIndex = 24
        '
        'CmdNew
        '
        Me.CmdNew.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdNew.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdNew.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdNew.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdNew.Appearance.Options.UseBackColor = True
        Me.CmdNew.Appearance.Options.UseFont = True
        Me.CmdNew.Appearance.Options.UseForeColor = True
        Me.CmdNew.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdNew.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdNew.Location = New System.Drawing.Point(100, 235)
        Me.CmdNew.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdNew.Size = New System.Drawing.Size(91, 39)
        Me.CmdNew.TabIndex = 23
        '
        'CmdCancel
        '
        Me.CmdCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdCancel.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdCancel.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdCancel.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdCancel.Appearance.Options.UseBackColor = True
        Me.CmdCancel.Appearance.Options.UseFont = True
        Me.CmdCancel.Appearance.Options.UseForeColor = True
        Me.CmdCancel.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdCancel.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdCancel.Location = New System.Drawing.Point(286, 235)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancel.Size = New System.Drawing.Size(91, 39)
        Me.CmdCancel.TabIndex = 25
        '
        'CmdPhan_Bo
        '
        Me.CmdPhan_Bo.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.CmdPhan_Bo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.CmdPhan_Bo.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.CmdPhan_Bo.Appearance.Options.UseBackColor = True
        Me.CmdPhan_Bo.Appearance.Options.UseFont = True
        Me.CmdPhan_Bo.Appearance.Options.UseForeColor = True
        Me.CmdPhan_Bo.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CmdPhan_Bo.AppearanceDisabled.Options.UseForeColor = True
        Me.CmdPhan_Bo.Location = New System.Drawing.Point(656, 565)
        Me.CmdPhan_Bo.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdPhan_Bo.Size = New System.Drawing.Size(69, 39)
        '
        'TxtUser_id
        '
        Me.TxtUser_id.Location = New System.Drawing.Point(739, 462)
        Me.TxtUser_id.Size = New System.Drawing.Size(100, 23)
        '
        'CbbMa_GD
        '
        Me.CbbMa_GD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_GD.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.CbbMa_GD.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_GD.FormattingEnabled = True
        Me.CbbMa_GD.Location = New System.Drawing.Point(99, 34)
        Me.CbbMa_GD.Margin = New System.Windows.Forms.Padding(4)
        Me.CbbMa_GD.Name = "CbbMa_GD"
        Me.CbbMa_GD.Size = New System.Drawing.Size(296, 24)
        Me.CbbMa_GD.TabIndex = 0
        '
        'LabDia_Chi
        '
        Me.LabDia_Chi.AutoSize = True
        Me.LabDia_Chi.BackColor = System.Drawing.Color.Transparent
        Me.LabDia_Chi.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LabDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.LabDia_Chi.Location = New System.Drawing.Point(16, 112)
        Me.LabDia_Chi.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDia_Chi.Name = "LabDia_Chi"
        Me.LabDia_Chi.Size = New System.Drawing.Size(47, 16)
        Me.LabDia_Chi.TabIndex = 146
        Me.LabDia_Chi.Tag = "Address"
        Me.LabDia_Chi.Text = "Địa chỉ"
        '
        'TxtDia_Chi
        '
        Me.TxtDia_Chi.BackColor = System.Drawing.Color.White
        Me.TxtDia_Chi.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtDia_Chi.ForeColor = System.Drawing.Color.Navy
        Me.TxtDia_Chi.Location = New System.Drawing.Point(99, 109)
        Me.TxtDia_Chi.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtDia_Chi.Name = "TxtDia_Chi"
        Me.TxtDia_Chi.Size = New System.Drawing.Size(691, 23)
        Me.TxtDia_Chi.TabIndex = 6
        '
        'TxtMa_Quyen
        '
        Me.TxtMa_Quyen.BackColor = System.Drawing.Color.White
        Me.TxtMa_Quyen.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Quyen.Location = New System.Drawing.Point(308, 484)
        Me.TxtMa_Quyen.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Quyen.Name = "TxtMa_Quyen"
        Me.TxtMa_Quyen.Size = New System.Drawing.Size(126, 21)
        Me.TxtMa_Quyen.TabIndex = 22
        Me.TxtMa_Quyen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtMa_Quyen.Visible = False
        '
        'LabMa_Quyen
        '
        Me.LabMa_Quyen.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_Quyen.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_Quyen.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_Quyen.Location = New System.Drawing.Point(221, 489)
        Me.LabMa_Quyen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Quyen.Name = "LabMa_Quyen"
        Me.LabMa_Quyen.Size = New System.Drawing.Size(64, 16)
        Me.LabMa_Quyen.TabIndex = 145
        Me.LabMa_Quyen.Tag = "Book no."
        Me.LabMa_Quyen.Text = "Quyển số"
        Me.LabMa_Quyen.Visible = False
        '
        'LabNgay_LCt
        '
        Me.LabNgay_LCt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabNgay_LCt.AutoSize = True
        Me.LabNgay_LCt.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_LCt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LabNgay_LCt.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_LCt.Location = New System.Drawing.Point(811, 39)
        Me.LabNgay_LCt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNgay_LCt.Name = "LabNgay_LCt"
        Me.LabNgay_LCt.Size = New System.Drawing.Size(60, 16)
        Me.LabNgay_LCt.TabIndex = 144
        Me.LabNgay_LCt.Tag = "Create date"
        Me.LabNgay_LCt.Text = "Ngày Lập"
        '
        'LabNgay_Ct
        '
        Me.LabNgay_Ct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabNgay_Ct.AutoSize = True
        Me.LabNgay_Ct.BackColor = System.Drawing.Color.Transparent
        Me.LabNgay_Ct.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LabNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.LabNgay_Ct.Location = New System.Drawing.Point(811, 63)
        Me.LabNgay_Ct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabNgay_Ct.Name = "LabNgay_Ct"
        Me.LabNgay_Ct.Size = New System.Drawing.Size(40, 16)
        Me.LabNgay_Ct.TabIndex = 143
        Me.LabNgay_Ct.Tag = "Voucher date"
        Me.LabNgay_Ct.Text = "Ngày "
        '
        'txtDien_giai
        '
        Me.txtDien_giai.BackColor = System.Drawing.Color.White
        Me.txtDien_giai.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txtDien_giai.ForeColor = System.Drawing.Color.Navy
        Me.txtDien_giai.Location = New System.Drawing.Point(99, 207)
        Me.txtDien_giai.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDien_giai.Name = "txtDien_giai"
        Me.txtDien_giai.Size = New System.Drawing.Size(691, 23)
        Me.txtDien_giai.TabIndex = 16
        '
        'LabDien_Giai
        '
        Me.LabDien_Giai.AutoSize = True
        Me.LabDien_Giai.BackColor = System.Drawing.Color.Transparent
        Me.LabDien_Giai.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LabDien_Giai.ForeColor = System.Drawing.Color.Navy
        Me.LabDien_Giai.Location = New System.Drawing.Point(16, 211)
        Me.LabDien_Giai.Margin = New System.Windows.Forms.Padding(0)
        Me.LabDien_Giai.Name = "LabDien_Giai"
        Me.LabDien_Giai.Size = New System.Drawing.Size(57, 16)
        Me.LabDien_Giai.TabIndex = 139
        Me.LabDien_Giai.Tag = "Reason"
        Me.LabDien_Giai.Text = "Diễn giải"
        '
        'lblLoai_ct
        '
        Me.lblLoai_ct.AutoSize = True
        Me.lblLoai_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblLoai_ct.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lblLoai_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblLoai_ct.Location = New System.Drawing.Point(16, 38)
        Me.lblLoai_ct.Margin = New System.Windows.Forms.Padding(0)
        Me.lblLoai_ct.Name = "lblLoai_ct"
        Me.lblLoai_ct.Size = New System.Drawing.Size(66, 16)
        Me.lblLoai_ct.TabIndex = 138
        Me.lblLoai_ct.Tag = "Vote style"
        Me.lblLoai_ct.Text = "Loại phiếu"
        '
        'txtOng_ba
        '
        Me.txtOng_ba.BackColor = System.Drawing.Color.White
        Me.txtOng_ba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.txtOng_ba.ForeColor = System.Drawing.Color.Navy
        Me.txtOng_ba.Location = New System.Drawing.Point(174, 462)
        Me.txtOng_ba.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOng_ba.Name = "txtOng_ba"
        Me.txtOng_ba.Size = New System.Drawing.Size(509, 20)
        Me.txtOng_ba.TabIndex = 4
        Me.txtOng_ba.Visible = False
        '
        'LabOng_ba
        '
        Me.LabOng_ba.BackColor = System.Drawing.Color.Transparent
        Me.LabOng_ba.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabOng_ba.ForeColor = System.Drawing.Color.Navy
        Me.LabOng_ba.Location = New System.Drawing.Point(81, 465)
        Me.LabOng_ba.Margin = New System.Windows.Forms.Padding(0)
        Me.LabOng_ba.Name = "LabOng_ba"
        Me.LabOng_ba.Size = New System.Drawing.Size(91, 17)
        Me.LabOng_ba.TabIndex = 136
        Me.LabOng_ba.Tag = "Receiver"
        Me.LabOng_ba.Text = "Người nhập"
        Me.LabOng_ba.Visible = False
        '
        'lblSo_ct
        '
        Me.lblSo_ct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_ct.AutoSize = True
        Me.lblSo_ct.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_ct.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.lblSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.lblSo_ct.Location = New System.Drawing.Point(811, 109)
        Me.lblSo_ct.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSo_ct.Name = "lblSo_ct"
        Me.lblSo_ct.Size = New System.Drawing.Size(58, 16)
        Me.lblSo_ct.TabIndex = 135
        Me.lblSo_ct.Tag = "Voucher no."
        Me.lblSo_ct.Text = "Số phiếu"
        '
        'txtSo_ct
        '
        Me.txtSo_ct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_ct.BackColor = System.Drawing.Color.White
        Me.txtSo_ct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSo_ct.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txtSo_ct.ForeColor = System.Drawing.Color.Navy
        Me.txtSo_ct.Location = New System.Drawing.Point(874, 106)
        Me.txtSo_ct.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSo_ct.Name = "txtSo_ct"
        Me.txtSo_ct.Size = New System.Drawing.Size(115, 23)
        Me.txtSo_ct.TabIndex = 43
        Me.txtSo_ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabMa_kh
        '
        Me.LabMa_kh.AutoSize = True
        Me.LabMa_kh.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_kh.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LabMa_kh.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_kh.Location = New System.Drawing.Point(16, 88)
        Me.LabMa_kh.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_kh.Name = "LabMa_kh"
        Me.LabMa_kh.Size = New System.Drawing.Size(64, 16)
        Me.LabMa_kh.TabIndex = 133
        Me.LabMa_kh.Tag = "Cus code"
        Me.LabMa_kh.Text = "Đối tượng"
        '
        'LabMa_NT
        '
        Me.LabMa_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabMa_NT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_NT.Location = New System.Drawing.Point(400, 492)
        Me.LabMa_NT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_NT.Name = "LabMa_NT"
        Me.LabMa_NT.Size = New System.Drawing.Size(64, 21)
        Me.LabMa_NT.TabIndex = 134
        Me.LabMa_NT.Tag = "E.Rate"
        Me.LabMa_NT.Text = "Ngoại tệ"
        Me.LabMa_NT.Visible = False
        '
        'TxtTy_Gia
        '
        Me.TxtTy_Gia.AllowNegative = True
        Me.TxtTy_Gia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTy_Gia.BackColor = System.Drawing.Color.White
        Me.TxtTy_Gia.Flags = 7680
        Me.TxtTy_Gia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTy_Gia.ForeColor = System.Drawing.Color.Navy
        Me.TxtTy_Gia.InputMask = "## ### ###.##"
        Me.TxtTy_Gia.Location = New System.Drawing.Point(471, 513)
        Me.TxtTy_Gia.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTy_Gia.MaxWholeDigits = 10
        Me.TxtTy_Gia.Name = "TxtTy_Gia"
        Me.TxtTy_Gia.RangeMax = 1.7976931348623157E+308R
        Me.TxtTy_Gia.RangeMin = -1.7976931348623157E+308R
        Me.TxtTy_Gia.ReadOnly = True
        Me.TxtTy_Gia.Size = New System.Drawing.Size(102, 21)
        Me.TxtTy_Gia.TabIndex = 20
        Me.TxtTy_Gia.Text = "22 500.01"
        Me.TxtTy_Gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtTy_Gia.Visible = False
        '
        'TxtNgay_LCt
        '
        Me.TxtNgay_LCt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNgay_LCt.BackColor = System.Drawing.Color.White
        Me.TxtNgay_LCt.Flags = 65536
        Me.TxtNgay_LCt.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtNgay_LCt.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_LCt.isEmpty = True
        Me.TxtNgay_LCt.Location = New System.Drawing.Point(874, 36)
        Me.TxtNgay_LCt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNgay_LCt.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_LCt.MaxLength = 10
        Me.TxtNgay_LCt.Name = "TxtNgay_LCt"
        Me.TxtNgay_LCt.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_LCt.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_LCt.ReadOnly = True
        Me.TxtNgay_LCt.ShowDayBeforeMonth = False
        Me.TxtNgay_LCt.Size = New System.Drawing.Size(115, 23)
        Me.TxtNgay_LCt.TabIndex = 40
        Me.TxtNgay_LCt.Text = "18/09/2011"
        Me.TxtNgay_LCt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_LCt.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtNgay_Ct
        '
        Me.TxtNgay_Ct.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtNgay_Ct.BackColor = System.Drawing.Color.White
        Me.TxtNgay_Ct.Flags = 65536
        Me.TxtNgay_Ct.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtNgay_Ct.ForeColor = System.Drawing.Color.Navy
        Me.TxtNgay_Ct.isEmpty = True
        Me.TxtNgay_Ct.Location = New System.Drawing.Point(874, 60)
        Me.TxtNgay_Ct.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNgay_Ct.MaskDate = "dd/MM/yyyy"
        Me.TxtNgay_Ct.MaxLength = 10
        Me.TxtNgay_Ct.Name = "TxtNgay_Ct"
        Me.TxtNgay_Ct.RangeMax = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.TxtNgay_Ct.RangeMin = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.TxtNgay_Ct.ReadOnly = True
        Me.TxtNgay_Ct.ShowDayBeforeMonth = False
        Me.TxtNgay_Ct.Size = New System.Drawing.Size(115, 23)
        Me.TxtNgay_Ct.TabIndex = 41
        Me.TxtNgay_Ct.Text = "18/09/2011"
        Me.TxtNgay_Ct.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtNgay_Ct.Value = New Date(2011, 9, 18, 0, 0, 0, 0)
        '
        'TxtMa_NT
        '
        Me.TxtMa_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_NT.BackColor = System.Drawing.Color.White
        Me.TxtMa_NT.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_NT.Location = New System.Drawing.Point(183, 413)
        Me.TxtMa_NT.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_NT.Name = "TxtMa_NT"
        Me.TxtMa_NT.Size = New System.Drawing.Size(102, 21)
        Me.TxtMa_NT.TabIndex = 19
        Me.TxtMa_NT.TabStop = False
        Me.TxtMa_NT.Visible = False
        '
        'Detail
        '
        Me.Detail.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Detail.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.Detail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Detail.Location = New System.Drawing.Point(5, 277)
        Me.Detail.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Detail.MainView = Me.DetailGRV
        Me.Detail.Margin = New System.Windows.Forms.Padding(4)
        Me.Detail.Name = "Detail"
        Me.Detail.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1, Me.RepositoryItemTextEdit2})
        Me.Detail.Size = New System.Drawing.Size(987, 332)
        Me.Detail.TabIndex = 33
        Me.Detail.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.DetailGRV})
        '
        'DetailGRV
        '
        Me.DetailGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DetailGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.DetailGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.DetailGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.DetailGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.DetailGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.DetailGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetailGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.DetailGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.DetailGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.DetailGRV.GridControl = Me.Detail
        Me.DetailGRV.GroupRowHeight = 30
        Me.DetailGRV.Name = "DetailGRV"
        Me.DetailGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.DetailGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.DetailGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.DetailGRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.DetailGRV.OptionsView.ColumnAutoWidth = False
        Me.DetailGRV.OptionsView.ShowGroupPanel = False
        Me.DetailGRV.RowHeight = 21
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemTextEdit2
        '
        Me.RepositoryItemTextEdit2.AutoHeight = False
        Me.RepositoryItemTextEdit2.Name = "RepositoryItemTextEdit2"
        '
        'LabTy_gia
        '
        Me.LabTy_gia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabTy_gia.BackColor = System.Drawing.Color.Transparent
        Me.LabTy_gia.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabTy_gia.ForeColor = System.Drawing.Color.Navy
        Me.LabTy_gia.Location = New System.Drawing.Point(400, 516)
        Me.LabTy_gia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTy_gia.Name = "LabTy_gia"
        Me.LabTy_gia.Size = New System.Drawing.Size(64, 21)
        Me.LabTy_gia.TabIndex = 153
        Me.LabTy_gia.Tag = "E.Rate"
        Me.LabTy_gia.Text = "Tỷ giá"
        Me.LabTy_gia.Visible = False
        '
        'TxtTen_kh
        '
        Me.TxtTen_kh.BackColor = System.Drawing.Color.White
        Me.TxtTen_kh.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtTen_kh.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_kh.Location = New System.Drawing.Point(99, 85)
        Me.TxtTen_kh.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_kh.Name = "TxtTen_kh"
        Me.TxtTen_kh.Size = New System.Drawing.Size(296, 23)
        Me.TxtTen_kh.TabIndex = 3
        Me.TxtTen_kh.TabStop = False
        '
        'TxtMa_Kh
        '
        Me.TxtMa_Kh._ActilookupPopup = False
        Me.TxtMa_Kh.CyberActilookupPopup = True
        Me.TxtMa_Kh.Dv_ListDetail = Nothing
        Me.TxtMa_Kh.Dv_Master = Nothing
        Me.TxtMa_Kh.FilterClient = ""
        Me.TxtMa_Kh.FilterSQL = ""
        Me.TxtMa_Kh.Location = New System.Drawing.Point(99, 85)
        Me.TxtMa_Kh.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Kh.Name = "TxtMa_Kh"
        Me.TxtMa_Kh.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.TxtMa_Kh.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Kh.Properties.Appearance.Options.UseFont = True
        Me.TxtMa_Kh.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_Kh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_Kh.Size = New System.Drawing.Size(136, 22)
        Me.TxtMa_Kh.TabIndex = 3
        Me.TxtMa_Kh.Table_Name = ""
        Me.TxtMa_Kh.Visible = False
        '
        'TxtT_Tien_NT
        '
        Me.TxtT_Tien_NT.AllowNegative = True
        Me.TxtT_Tien_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien_NT.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien_NT.Flags = 7680
        Me.TxtT_Tien_NT.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien_NT.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien_NT.Location = New System.Drawing.Point(554, 487)
        Me.TxtT_Tien_NT.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtT_Tien_NT.MaxWholeDigits = 16
        Me.TxtT_Tien_NT.Name = "TxtT_Tien_NT"
        Me.TxtT_Tien_NT.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien_NT.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien_NT.ReadOnly = True
        Me.TxtT_Tien_NT.Size = New System.Drawing.Size(138, 23)
        Me.TxtT_Tien_NT.TabIndex = 158
        Me.TxtT_Tien_NT.Text = "1.0"
        Me.TxtT_Tien_NT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien_NT.Visible = False
        '
        'TxtT_Tien
        '
        Me.TxtT_Tien.AllowNegative = True
        Me.TxtT_Tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_Tien.BackColor = System.Drawing.Color.White
        Me.TxtT_Tien.Flags = 7680
        Me.TxtT_Tien.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_Tien.InputMask = "### ### ### ### ###.#"
        Me.TxtT_Tien.Location = New System.Drawing.Point(696, 487)
        Me.TxtT_Tien.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtT_Tien.MaxWholeDigits = 16
        Me.TxtT_Tien.Name = "TxtT_Tien"
        Me.TxtT_Tien.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_Tien.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_Tien.ReadOnly = True
        Me.TxtT_Tien.Size = New System.Drawing.Size(138, 23)
        Me.TxtT_Tien.TabIndex = 159
        Me.TxtT_Tien.Text = "1.0"
        Me.TxtT_Tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_Tien.Visible = False
        '
        'LabT_TT_NT
        '
        Me.LabT_TT_NT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_TT_NT.BackColor = System.Drawing.Color.Transparent
        Me.LabT_TT_NT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_TT_NT.ForeColor = System.Drawing.Color.Navy
        Me.LabT_TT_NT.Location = New System.Drawing.Point(459, 492)
        Me.LabT_TT_NT.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_TT_NT.Name = "LabT_TT_NT"
        Me.LabT_TT_NT.Size = New System.Drawing.Size(91, 17)
        Me.LabT_TT_NT.TabIndex = 160
        Me.LabT_TT_NT.Tag = "Total"
        Me.LabT_TT_NT.Text = "Tổng cộng"
        Me.LabT_TT_NT.Visible = False
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMa_Dvcs.BackColor = System.Drawing.Color.White
        Me.TxtMa_Dvcs.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Dvcs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMa_Dvcs.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(794, 572)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.Name = "TxtMa_Dvcs"
        Me.TxtMa_Dvcs.Size = New System.Drawing.Size(24, 21)
        Me.TxtMa_Dvcs.TabIndex = 161
        Me.TxtMa_Dvcs.TabStop = False
        Me.TxtMa_Dvcs.Visible = False
        '
        'TxtStt_Rec
        '
        Me.TxtStt_Rec.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtStt_Rec.BackColor = System.Drawing.Color.White
        Me.TxtStt_Rec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtStt_Rec.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtStt_Rec.ForeColor = System.Drawing.Color.Navy
        Me.TxtStt_Rec.Location = New System.Drawing.Point(763, 572)
        Me.TxtStt_Rec.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtStt_Rec.Name = "TxtStt_Rec"
        Me.TxtStt_Rec.Size = New System.Drawing.Size(24, 21)
        Me.TxtStt_Rec.TabIndex = 162
        Me.TxtStt_Rec.TabStop = False
        Me.TxtStt_Rec.Visible = False
        '
        'PopupMenuMasterGrid
        '
        Me.PopupMenuMasterGrid.Name = "PopupMenuMasterGrid"
        '
        'ChkPN_Gia_TB
        '
        Me.ChkPN_Gia_TB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkPN_Gia_TB.AutoSize = True
        Me.ChkPN_Gia_TB.Location = New System.Drawing.Point(83, 507)
        Me.ChkPN_Gia_TB.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkPN_Gia_TB.Name = "ChkPN_Gia_TB"
        Me.ChkPN_Gia_TB.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ChkPN_Gia_TB.Size = New System.Drawing.Size(308, 20)
        Me.ChkPN_Gia_TB.TabIndex = 167
        Me.ChkPN_Gia_TB.TabStop = False
        Me.ChkPN_Gia_TB.Tag = "Input avg. cost price for tools and instruments (Avg.)"
        Me.ChkPN_Gia_TB.Text = "Nhập giá trung bình cho vật tư tính giá trung bình"
        Me.ChkPN_Gia_TB.UseVisualStyleBackColor = True
        Me.ChkPN_Gia_TB.Visible = False
        '
        'LabLenh_RO
        '
        Me.LabLenh_RO.BackColor = System.Drawing.Color.Transparent
        Me.LabLenh_RO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabLenh_RO.ForeColor = System.Drawing.Color.Navy
        Me.LabLenh_RO.Location = New System.Drawing.Point(221, 516)
        Me.LabLenh_RO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLenh_RO.Name = "LabLenh_RO"
        Me.LabLenh_RO.Size = New System.Drawing.Size(83, 16)
        Me.LabLenh_RO.TabIndex = 169
        Me.LabLenh_RO.Tag = "R/O"
        Me.LabLenh_RO.Text = "Số R/O"
        Me.LabLenh_RO.Visible = False
        '
        'TxtLenh_RO
        '
        Me.TxtLenh_RO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_RO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_RO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_RO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_RO.Location = New System.Drawing.Point(308, 513)
        Me.TxtLenh_RO.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLenh_RO.Name = "TxtLenh_RO"
        Me.TxtLenh_RO.Size = New System.Drawing.Size(126, 21)
        Me.TxtLenh_RO.TabIndex = 168
        Me.TxtLenh_RO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_RO.Visible = False
        '
        'LabLenh_PO
        '
        Me.LabLenh_PO.BackColor = System.Drawing.Color.Transparent
        Me.LabLenh_PO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabLenh_PO.ForeColor = System.Drawing.Color.Navy
        Me.LabLenh_PO.Location = New System.Drawing.Point(442, 487)
        Me.LabLenh_PO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLenh_PO.Name = "LabLenh_PO"
        Me.LabLenh_PO.Size = New System.Drawing.Size(70, 16)
        Me.LabLenh_PO.TabIndex = 171
        Me.LabLenh_PO.Tag = "P/O"
        Me.LabLenh_PO.Text = "Số P/O"
        Me.LabLenh_PO.Visible = False
        '
        'TxtLenh_PO
        '
        Me.TxtLenh_PO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_PO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_PO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_PO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_PO.Location = New System.Drawing.Point(674, 438)
        Me.TxtLenh_PO.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLenh_PO.Name = "TxtLenh_PO"
        Me.TxtLenh_PO.Size = New System.Drawing.Size(126, 21)
        Me.TxtLenh_PO.TabIndex = 170
        Me.TxtLenh_PO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_PO.Visible = False
        '
        'LabLenh_SO
        '
        Me.LabLenh_SO.BackColor = System.Drawing.Color.Transparent
        Me.LabLenh_SO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabLenh_SO.ForeColor = System.Drawing.Color.Navy
        Me.LabLenh_SO.Location = New System.Drawing.Point(442, 516)
        Me.LabLenh_SO.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabLenh_SO.Name = "LabLenh_SO"
        Me.LabLenh_SO.Size = New System.Drawing.Size(70, 16)
        Me.LabLenh_SO.TabIndex = 173
        Me.LabLenh_SO.Tag = "S/O"
        Me.LabLenh_SO.Text = "Số S/O"
        Me.LabLenh_SO.Visible = False
        '
        'TxtLenh_SO
        '
        Me.TxtLenh_SO.BackColor = System.Drawing.Color.White
        Me.TxtLenh_SO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_SO.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_SO.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_SO.Location = New System.Drawing.Point(664, 518)
        Me.TxtLenh_SO.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLenh_SO.Name = "TxtLenh_SO"
        Me.TxtLenh_SO.Size = New System.Drawing.Size(126, 21)
        Me.TxtLenh_SO.TabIndex = 172
        Me.TxtLenh_SO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_SO.Visible = False
        '
        'LabT_So_Luong
        '
        Me.LabT_So_Luong.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabT_So_Luong.BackColor = System.Drawing.Color.Transparent
        Me.LabT_So_Luong.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.LabT_So_Luong.ForeColor = System.Drawing.Color.Navy
        Me.LabT_So_Luong.Location = New System.Drawing.Point(323, 538)
        Me.LabT_So_Luong.Margin = New System.Windows.Forms.Padding(0)
        Me.LabT_So_Luong.Name = "LabT_So_Luong"
        Me.LabT_So_Luong.Size = New System.Drawing.Size(91, 17)
        Me.LabT_So_Luong.TabIndex = 175
        Me.LabT_So_Luong.Tag = "Total"
        Me.LabT_So_Luong.Text = "Tổng số lượng"
        Me.LabT_So_Luong.Visible = False
        '
        'TxtT_SO_LUONG
        '
        Me.TxtT_SO_LUONG.AllowNegative = True
        Me.TxtT_SO_LUONG.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtT_SO_LUONG.BackColor = System.Drawing.Color.White
        Me.TxtT_SO_LUONG.Flags = 7680
        Me.TxtT_SO_LUONG.ForeColor = System.Drawing.Color.Navy
        Me.TxtT_SO_LUONG.InputMask = "### ### ### ### ###.#"
        Me.TxtT_SO_LUONG.Location = New System.Drawing.Point(372, 559)
        Me.TxtT_SO_LUONG.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtT_SO_LUONG.MaxWholeDigits = 16
        Me.TxtT_SO_LUONG.Name = "TxtT_SO_LUONG"
        Me.TxtT_SO_LUONG.RangeMax = 1.7976931348623157E+308R
        Me.TxtT_SO_LUONG.RangeMin = -1.7976931348623157E+308R
        Me.TxtT_SO_LUONG.ReadOnly = True
        Me.TxtT_SO_LUONG.Size = New System.Drawing.Size(87, 23)
        Me.TxtT_SO_LUONG.TabIndex = 174
        Me.TxtT_SO_LUONG.Text = "0.0"
        Me.TxtT_SO_LUONG.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtT_SO_LUONG.Visible = False
        '
        'TxtLenh_Vt
        '
        Me.TxtLenh_Vt.BackColor = System.Drawing.Color.White
        Me.TxtLenh_Vt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtLenh_Vt.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLenh_Vt.ForeColor = System.Drawing.Color.Navy
        Me.TxtLenh_Vt.Location = New System.Drawing.Point(494, 517)
        Me.TxtLenh_Vt.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLenh_Vt.Name = "TxtLenh_Vt"
        Me.TxtLenh_Vt.Size = New System.Drawing.Size(40, 21)
        Me.TxtLenh_Vt.TabIndex = 250
        Me.TxtLenh_Vt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.TxtLenh_Vt.Visible = False
        '
        'TxtGio_CT
        '
        Me.TxtGio_CT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtGio_CT.BackColor = System.Drawing.Color.White
        Me.TxtGio_CT.Enabled = False
        Me.TxtGio_CT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtGio_CT.ForeColor = System.Drawing.Color.Navy
        Me.TxtGio_CT.Location = New System.Drawing.Point(874, 84)
        Me.TxtGio_CT.Name = "TxtGio_CT"
        Me.TxtGio_CT.ReadOnly = True
        Me.TxtGio_CT.Size = New System.Drawing.Size(115, 21)
        Me.TxtGio_CT.TabIndex = 42
        Me.TxtGio_CT.TabStop = False
        Me.TxtGio_CT.Tag = ""
        Me.TxtGio_CT.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'LabMa_Xe
        '
        Me.LabMa_Xe.AutoSize = True
        Me.LabMa_Xe.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabMa_Xe.ForeColor = System.Drawing.Color.Blue
        Me.LabMa_Xe.Location = New System.Drawing.Point(16, 65)
        Me.LabMa_Xe.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_Xe.Name = "LabMa_Xe"
        Me.LabMa_Xe.Size = New System.Drawing.Size(54, 16)
        Me.LabMa_Xe.TabIndex = 1780
        Me.LabMa_Xe.Tag = "Type (R/O)"
        Me.LabMa_Xe.Text = "Biển số"
        '
        'CbbMa_KX
        '
        Me.CbbMa_KX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_KX.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_KX.FormattingEnabled = True
        Me.CbbMa_KX.Location = New System.Drawing.Point(453, 60)
        Me.CbbMa_KX.Name = "CbbMa_KX"
        Me.CbbMa_KX.Size = New System.Drawing.Size(139, 24)
        Me.CbbMa_KX.TabIndex = 2
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.Navy
        Me.label.Location = New System.Drawing.Point(399, 66)
        Me.label.Margin = New System.Windows.Forms.Padding(0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(48, 15)
        Me.label.TabIndex = 1779
        Me.label.Tag = "Reason"
        Me.label.Text = "Kiểu xe"
        '
        'TxtMa_Xe
        '
        Me.TxtMa_Xe.BackColor = System.Drawing.Color.White
        Me.TxtMa_Xe.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtMa_Xe.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TxtMa_Xe.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_Xe.Location = New System.Drawing.Point(99, 63)
        Me.TxtMa_Xe.Name = "TxtMa_Xe"
        Me.TxtMa_Xe.Size = New System.Drawing.Size(296, 21)
        Me.TxtMa_Xe.TabIndex = 1
        Me.TxtMa_Xe.Tag = ""
        '
        'TxtDia_ChiVAT
        '
        Me.TxtDia_ChiVAT.BackColor = System.Drawing.Color.White
        Me.TxtDia_ChiVAT.ForeColor = System.Drawing.Color.Navy
        Me.TxtDia_ChiVAT.Location = New System.Drawing.Point(99, 157)
        Me.TxtDia_ChiVAT.Name = "TxtDia_ChiVAT"
        Me.TxtDia_ChiVAT.Size = New System.Drawing.Size(691, 23)
        Me.TxtDia_ChiVAT.TabIndex = 8
        Me.TxtDia_ChiVAT.Tag = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Navy
        Me.Label10.Location = New System.Drawing.Point(16, 160)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(75, 16)
        Me.Label10.TabIndex = 1850
        Me.Label10.Tag = "Address "
        Me.Label10.Text = "Địa chỉ VAT"
        '
        'TxtTen_khVAT
        '
        Me.TxtTen_khVAT.BackColor = System.Drawing.Color.White
        Me.TxtTen_khVAT.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_khVAT.Location = New System.Drawing.Point(99, 133)
        Me.TxtTen_khVAT.Name = "TxtTen_khVAT"
        Me.TxtTen_khVAT.Size = New System.Drawing.Size(691, 23)
        Me.TxtTen_khVAT.TabIndex = 7
        Me.TxtTen_khVAT.Tag = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(16, 136)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 16)
        Me.Label8.TabIndex = 1849
        Me.Label8.Tag = "Name"
        Me.Label8.Text = "Tên KH VAT"
        '
        'TxtTen_Lx
        '
        Me.TxtTen_Lx.Location = New System.Drawing.Point(99, 181)
        Me.TxtTen_Lx.Name = "TxtTen_Lx"
        Me.TxtTen_Lx.Size = New System.Drawing.Size(296, 23)
        Me.TxtTen_Lx.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 1846
        Me.Label5.Text = "Tên lái xe"
        '
        'TxtDien_Thoai
        '
        Me.TxtDien_Thoai.Location = New System.Drawing.Point(664, 61)
        Me.TxtDien_Thoai.Name = "TxtDien_Thoai"
        Me.TxtDien_Thoai.Size = New System.Drawing.Size(126, 23)
        Me.TxtDien_Thoai.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(592, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 16)
        Me.Label3.TabIndex = 1847
        Me.Label3.Text = "Điện thoại"
        '
        'TxtDt_LX
        '
        Me.TxtDt_LX.BackColor = System.Drawing.Color.White
        Me.TxtDt_LX.ForeColor = System.Drawing.Color.Navy
        Me.TxtDt_LX.Location = New System.Drawing.Point(471, 181)
        Me.TxtDt_LX.Name = "TxtDt_LX"
        Me.TxtDt_LX.Size = New System.Drawing.Size(319, 23)
        Me.TxtDt_LX.TabIndex = 12
        Me.TxtDt_LX.Tag = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(399, 184)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 16)
        Me.Label1.TabIndex = 1848
        Me.Label1.Tag = "Driver tel"
        Me.Label1.Text = "ĐT Lái xe"
        '
        'ChkScc
        '
        Me.ChkScc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkScc.AutoSize = True
        Me.ChkScc.Location = New System.Drawing.Point(874, 136)
        Me.ChkScc.Name = "ChkScc"
        Me.ChkScc.Size = New System.Drawing.Size(120, 20)
        Me.ChkScc.TabIndex = 13
        Me.ChkScc.Text = "Sửa chữa chung"
        Me.ChkScc.UseVisualStyleBackColor = True
        '
        'ChkTv
        '
        Me.ChkTv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkTv.AutoSize = True
        Me.ChkTv.Location = New System.Drawing.Point(874, 182)
        Me.ChkTv.Name = "ChkTv"
        Me.ChkTv.Size = New System.Drawing.Size(81, 20)
        Me.ChkTv.TabIndex = 15
        Me.ChkTv.Text = "Đồng sơn"
        Me.ChkTv.UseVisualStyleBackColor = True
        '
        'ChkBd
        '
        Me.ChkBd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkBd.AutoSize = True
        Me.ChkBd.Location = New System.Drawing.Point(874, 159)
        Me.ChkBd.Name = "ChkBd"
        Me.ChkBd.Size = New System.Drawing.Size(127, 20)
        Me.ChkBd.TabIndex = 14
        Me.ChkBd.Text = "Bảo dưỡng nhanh"
        Me.ChkBd.UseVisualStyleBackColor = True
        '
        'TxtE_Mail
        '
        Me.TxtE_Mail.BackColor = System.Drawing.Color.White
        Me.TxtE_Mail.ForeColor = System.Drawing.Color.Navy
        Me.TxtE_Mail.Location = New System.Drawing.Point(453, 85)
        Me.TxtE_Mail.Name = "TxtE_Mail"
        Me.TxtE_Mail.Size = New System.Drawing.Size(337, 23)
        Me.TxtE_Mail.TabIndex = 5
        Me.TxtE_Mail.Tag = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(399, 88)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 16)
        Me.Label12.TabIndex = 1856
        Me.Label12.Tag = "E Mail"
        Me.Label12.Text = "E Mail"
        '
        'TxtTen_GD
        '
        Me.TxtTen_GD.BackColor = System.Drawing.Color.White
        Me.TxtTen_GD.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTen_GD.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_GD.Location = New System.Drawing.Point(790, 140)
        Me.TxtTen_GD.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_GD.Name = "TxtTen_GD"
        Me.TxtTen_GD.Size = New System.Drawing.Size(63, 23)
        Me.TxtTen_GD.TabIndex = 1857
        Me.TxtTen_GD.Visible = False
        '
        'ChkNonVAT
        '
        Me.ChkNonVAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ChkNonVAT.AutoSize = True
        Me.ChkNonVAT.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ChkNonVAT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkNonVAT.ForeColor = System.Drawing.Color.Navy
        Me.ChkNonVAT.Location = New System.Drawing.Point(874, 208)
        Me.ChkNonVAT.Name = "ChkNonVAT"
        Me.ChkNonVAT.Size = New System.Drawing.Size(62, 17)
        Me.ChkNonVAT.TabIndex = 2133
        Me.ChkNonVAT.TabStop = False
        Me.ChkNonVAT.Tag = "Non VAT"
        Me.ChkNonVAT.Text = "NonVat"
        Me.ChkNonVAT.UseVisualStyleBackColor = True
        '
        'LabMa_TTCP_H
        '
        Me.LabMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMa_TTCP_H.BackColor = System.Drawing.SystemColors.Control
        Me.LabMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.LabMa_TTCP_H.Location = New System.Drawing.Point(641, 7)
        Me.LabMa_TTCP_H.Margin = New System.Windows.Forms.Padding(0)
        Me.LabMa_TTCP_H.Name = "LabMa_TTCP_H"
        Me.LabMa_TTCP_H.Size = New System.Drawing.Size(144, 17)
        Me.LabMa_TTCP_H.TabIndex = 2165
        Me.LabMa_TTCP_H.Tag = "Cost centrer"
        Me.LabMa_TTCP_H.Text = "TTCP"
        Me.LabMa_TTCP_H.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CbbMa_TTCP_H
        '
        Me.CbbMa_TTCP_H.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CbbMa_TTCP_H.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbbMa_TTCP_H.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbbMa_TTCP_H.ForeColor = System.Drawing.Color.Navy
        Me.CbbMa_TTCP_H.FormattingEnabled = True
        Me.CbbMa_TTCP_H.Location = New System.Drawing.Point(785, 3)
        Me.CbbMa_TTCP_H.Name = "CbbMa_TTCP_H"
        Me.CbbMa_TTCP_H.Size = New System.Drawing.Size(205, 23)
        Me.CbbMa_TTCP_H.TabIndex = 2164
        Me.CbbMa_TTCP_H.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(811, 87)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 16)
        Me.Label2.TabIndex = 2166
        Me.Label2.Tag = "Time"
        Me.Label2.Text = "Thời gian"
        '
        'RYC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(995, 635)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LabMa_TTCP_H)
        Me.Controls.Add(Me.CbbMa_TTCP_H)
        Me.Controls.Add(Me.ChkNonVAT)
        Me.Controls.Add(Me.TxtTen_GD)
        Me.Controls.Add(Me.Detail)
        Me.Controls.Add(Me.TxtE_Mail)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.ChkScc)
        Me.Controls.Add(Me.ChkTv)
        Me.Controls.Add(Me.ChkBd)
        Me.Controls.Add(Me.TxtDia_ChiVAT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTen_khVAT)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtTen_Lx)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtDien_Thoai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDt_LX)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabMa_Xe)
        Me.Controls.Add(Me.CbbMa_KX)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.TxtMa_Xe)
        Me.Controls.Add(Me.TxtGio_CT)
        Me.Controls.Add(Me.TxtLenh_Vt)
        Me.Controls.Add(Me.LabT_So_Luong)
        Me.Controls.Add(Me.TxtT_SO_LUONG)
        Me.Controls.Add(Me.LabLenh_SO)
        Me.Controls.Add(Me.TxtLenh_SO)
        Me.Controls.Add(Me.LabLenh_PO)
        Me.Controls.Add(Me.TxtLenh_PO)
        Me.Controls.Add(Me.LabLenh_RO)
        Me.Controls.Add(Me.TxtLenh_RO)
        Me.Controls.Add(Me.ChkPN_Gia_TB)
        Me.Controls.Add(Me.LabT_TT_NT)
        Me.Controls.Add(Me.TxtT_Tien)
        Me.Controls.Add(Me.TxtT_Tien_NT)
        Me.Controls.Add(Me.TxtTen_kh)
        Me.Controls.Add(Me.TxtMa_Kh)
        Me.Controls.Add(Me.LabTy_gia)
        Me.Controls.Add(Me.TxtMa_NT)
        Me.Controls.Add(Me.TxtTy_Gia)
        Me.Controls.Add(Me.TxtNgay_LCt)
        Me.Controls.Add(Me.TxtNgay_Ct)
        Me.Controls.Add(Me.CbbMa_GD)
        Me.Controls.Add(Me.LabDia_Chi)
        Me.Controls.Add(Me.TxtDia_Chi)
        Me.Controls.Add(Me.TxtMa_Quyen)
        Me.Controls.Add(Me.LabMa_Quyen)
        Me.Controls.Add(Me.LabNgay_LCt)
        Me.Controls.Add(Me.LabNgay_Ct)
        Me.Controls.Add(Me.txtDien_giai)
        Me.Controls.Add(Me.LabDien_Giai)
        Me.Controls.Add(Me.lblLoai_ct)
        Me.Controls.Add(Me.txtOng_ba)
        Me.Controls.Add(Me.LabOng_ba)
        Me.Controls.Add(Me.lblSo_ct)
        Me.Controls.Add(Me.txtSo_ct)
        Me.Controls.Add(Me.LabMa_kh)
        Me.Controls.Add(Me.LabMa_NT)
        Me.Controls.Add(Me.TxtStt_Rec)
        Me.Controls.Add(Me.TxtMa_Dvcs)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(879, 674)
        Me.Name = "RYC"
        Me.Controls.SetChildIndex(Me.TxtUser_id, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.TxtStt_Rec, 0)
        Me.Controls.SetChildIndex(Me.LabMa_NT, 0)
        Me.Controls.SetChildIndex(Me.LabMa_kh, 0)
        Me.Controls.SetChildIndex(Me.txtSo_ct, 0)
        Me.Controls.SetChildIndex(Me.lblSo_ct, 0)
        Me.Controls.SetChildIndex(Me.LabOng_ba, 0)
        Me.Controls.SetChildIndex(Me.txtOng_ba, 0)
        Me.Controls.SetChildIndex(Me.lblLoai_ct, 0)
        Me.Controls.SetChildIndex(Me.LabDien_Giai, 0)
        Me.Controls.SetChildIndex(Me.txtDien_giai, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.LabNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Quyen, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Quyen, 0)
        Me.Controls.SetChildIndex(Me.TxtDia_Chi, 0)
        Me.Controls.SetChildIndex(Me.LabDia_Chi, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_GD, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_Ct, 0)
        Me.Controls.SetChildIndex(Me.TxtNgay_LCt, 0)
        Me.Controls.SetChildIndex(Me.TxtTy_Gia, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_NT, 0)
        Me.Controls.SetChildIndex(Me.LabTy_gia, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Kh, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_kh, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien_NT, 0)
        Me.Controls.SetChildIndex(Me.TxtT_Tien, 0)
        Me.Controls.SetChildIndex(Me.LabT_TT_NT, 0)
        Me.Controls.SetChildIndex(Me.ChkPN_Gia_TB, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_RO, 0)
        Me.Controls.SetChildIndex(Me.LabLenh_RO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_PO, 0)
        Me.Controls.SetChildIndex(Me.LabLenh_PO, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_SO, 0)
        Me.Controls.SetChildIndex(Me.LabLenh_SO, 0)
        Me.Controls.SetChildIndex(Me.TxtT_SO_LUONG, 0)
        Me.Controls.SetChildIndex(Me.LabT_So_Luong, 0)
        Me.Controls.SetChildIndex(Me.TxtLenh_Vt, 0)
        Me.Controls.SetChildIndex(Me.TxtGio_CT, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.label, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_KX, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Xe, 0)
        Me.Controls.SetChildIndex(Me.CmdPhan_Bo, 0)
        Me.Controls.SetChildIndex(Me.CmdNew, 0)
        Me.Controls.SetChildIndex(Me.CmdSave, 0)
        Me.Controls.SetChildIndex(Me.CmdPrint, 0)
        Me.Controls.SetChildIndex(Me.CmdEdit, 0)
        Me.Controls.SetChildIndex(Me.CmdCancel, 0)
        Me.Controls.SetChildIndex(Me.CmdDelete, 0)
        Me.Controls.SetChildIndex(Me.CmdCopy, 0)
        Me.Controls.SetChildIndex(Me.CmdSearch, 0)
        Me.Controls.SetChildIndex(Me.CmdExit, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_Post, 0)
        Me.Controls.SetChildIndex(Me.CmdImport, 0)
        Me.Controls.SetChildIndex(Me.CmdSms, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Post, 0)
        Me.Controls.SetChildIndex(Me.CmdView, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.TxtDt_LX, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.TxtDien_Thoai, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Lx, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_khVAT, 0)
        Me.Controls.SetChildIndex(Me.Label10, 0)
        Me.Controls.SetChildIndex(Me.TxtDia_ChiVAT, 0)
        Me.Controls.SetChildIndex(Me.ChkBd, 0)
        Me.Controls.SetChildIndex(Me.ChkTv, 0)
        Me.Controls.SetChildIndex(Me.ChkScc, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.TxtE_Mail, 0)
        Me.Controls.SetChildIndex(Me.Detail, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_GD, 0)
        Me.Controls.SetChildIndex(Me.ChkNonVAT, 0)
        Me.Controls.SetChildIndex(Me.CbbMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.LabMa_TTCP_H, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        CType(Me.PopupMenuMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailGRV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_Kh.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenuMasterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CbbMa_GD As System.Windows.Forms.ComboBox
    Friend WithEvents LabDia_Chi As System.Windows.Forms.Label
    Friend WithEvents TxtDia_Chi As System.Windows.Forms.TextBox
    Friend WithEvents TxtMa_Quyen As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_Quyen As System.Windows.Forms.Label
    Friend WithEvents LabNgay_LCt As System.Windows.Forms.Label
    Friend WithEvents LabNgay_Ct As System.Windows.Forms.Label
    Friend WithEvents txtDien_giai As System.Windows.Forms.TextBox
    Friend WithEvents LabDien_Giai As System.Windows.Forms.Label
    Friend WithEvents lblLoai_ct As System.Windows.Forms.Label
    Friend WithEvents txtOng_ba As System.Windows.Forms.TextBox
    Friend WithEvents LabOng_ba As System.Windows.Forms.Label
    Friend WithEvents lblSo_ct As System.Windows.Forms.Label
    Friend WithEvents txtSo_ct As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_kh As System.Windows.Forms.Label
    Friend WithEvents LabMa_NT As System.Windows.Forms.Label
    Friend WithEvents TxtTy_Gia As ClsTextBox.txtTy_Gia
    Friend WithEvents TxtNgay_LCt As ClsTextBox.txtDate
    Friend WithEvents TxtNgay_Ct As ClsTextBox.txtDate
    Friend WithEvents TxtMa_NT As System.Windows.Forms.TextBox
    Friend WithEvents Detail As DevExpress.XtraGrid.GridControl
    Friend WithEvents DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabTy_gia As System.Windows.Forms.Label
    Friend WithEvents TxtTen_kh As System.Windows.Forms.TextBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents TxtMa_Kh As Cyber.SmLists.TxtLookup
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemTextEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents TxtT_Tien_NT As ClsTextBox.txtTien_NT
    Friend WithEvents TxtT_Tien As ClsTextBox.txtTien_NT
    Friend WithEvents LabT_TT_NT As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Dvcs As System.Windows.Forms.TextBox
    Friend WithEvents TxtStt_Rec As System.Windows.Forms.TextBox
    Friend WithEvents PopupMenuMasterGrid As DevExpress.XtraBars.PopupMenu
    Friend WithEvents ChkPN_Gia_TB As System.Windows.Forms.CheckBox
    Friend WithEvents LabLenh_RO As System.Windows.Forms.Label
    Friend WithEvents TxtLenh_RO As System.Windows.Forms.TextBox
    Friend WithEvents LabLenh_PO As System.Windows.Forms.Label
    Friend WithEvents TxtLenh_PO As System.Windows.Forms.TextBox
    Friend WithEvents LabLenh_SO As System.Windows.Forms.Label
    Friend WithEvents TxtLenh_SO As System.Windows.Forms.TextBox
    Friend WithEvents LabT_So_Luong As System.Windows.Forms.Label
    Friend WithEvents TxtT_SO_LUONG As ClsTextBox.txtTien_NT
    Friend WithEvents TxtLenh_Vt As System.Windows.Forms.TextBox
    Friend WithEvents TxtGio_CT As System.Windows.Forms.TextBox
    Friend WithEvents LabMa_Xe As System.Windows.Forms.Label
    Friend WithEvents CbbMa_KX As System.Windows.Forms.ComboBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents TxtMa_Xe As System.Windows.Forms.TextBox
    Friend WithEvents TxtDia_ChiVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_khVAT As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Lx As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtDien_Thoai As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtDt_LX As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ChkScc As System.Windows.Forms.CheckBox
    Friend WithEvents ChkTv As System.Windows.Forms.CheckBox
    Friend WithEvents ChkBd As System.Windows.Forms.CheckBox
    Friend WithEvents TxtE_Mail As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_GD As System.Windows.Forms.TextBox
    Friend WithEvents ChkNonVAT As System.Windows.Forms.CheckBox
    Friend WithEvents LabMa_TTCP_H As System.Windows.Forms.Label
    Friend WithEvents CbbMa_TTCP_H As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As Label
End Class
