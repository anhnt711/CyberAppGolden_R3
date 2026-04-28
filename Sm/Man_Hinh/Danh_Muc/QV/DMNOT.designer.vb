<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DMNOT
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
        Me.LabMa_KH = New System.Windows.Forms.Label()
        Me.LabMa_Nh1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LabTen_KHVAT = New System.Windows.Forms.Label()
        Me.TxtNh_not1 = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_Nh1 = New System.Windows.Forms.Label()
        Me.TxtMa_tuyen = New Cyber.SmLists.TxtLookup()
        Me.TxtTen_tuyen = New System.Windows.Forms.Label()
        Me.TxtTen_not = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtMa_not = New System.Windows.Forms.TextBox()
        Me.TxtLoai_Not = New System.Windows.Forms.TextBox()
        Me.TxtGio_di = New System.Windows.Forms.TextBox()
        Me.TxtTen_Nh2 = New System.Windows.Forms.Label()
        Me.TxtNh_not2 = New Cyber.SmLists.TxtLookup()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTen_Nh3 = New System.Windows.Forms.Label()
        Me.TxtNh_not3 = New Cyber.SmLists.TxtLookup()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.TxtNh_not1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtMa_tuyen.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_not2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TxtNh_not3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtExit
        '
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(827, 292)
        Me.ButtExit.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtExit.TabIndex = 12
        '
        'ButtOK
        '
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(685, 292)
        Me.ButtOK.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtOK.TabIndex = 11
        '
        'TxtMa_Dvcs
        '
        Me.TxtMa_Dvcs.Location = New System.Drawing.Point(516, 301)
        Me.TxtMa_Dvcs.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_Dvcs.TabIndex = 10
        '
        'ChkActi
        '
        Me.ChkActi.Location = New System.Drawing.Point(99, 309)
        Me.ChkActi.Margin = New System.Windows.Forms.Padding(4)
        Me.ChkActi.TabIndex = 9
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Location = New System.Drawing.Point(12, 273)
        Me.GroupBoxLine.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBoxLine.Size = New System.Drawing.Size(971, 3)
        Me.GroupBoxLine.TabIndex = 8
        '
        'LabMa_KH
        '
        Me.LabMa_KH.Location = New System.Drawing.Point(8, 18)
        Me.LabMa_KH.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_KH.Name = "LabMa_KH"
        Me.LabMa_KH.Size = New System.Drawing.Size(133, 23)
        Me.LabMa_KH.TabIndex = 10
        Me.LabMa_KH.Tag = "Group 1"
        Me.LabMa_KH.Text = "Nhóm nốt 1"
        '
        'LabMa_Nh1
        '
        Me.LabMa_Nh1.Location = New System.Drawing.Point(8, 109)
        Me.LabMa_Nh1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabMa_Nh1.Name = "LabMa_Nh1"
        Me.LabMa_Nh1.Size = New System.Drawing.Size(133, 23)
        Me.LabMa_Nh1.TabIndex = 24
        Me.LabMa_Nh1.Tag = "Type"
        Me.LabMa_Nh1.Text = "Loại nốt"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 140)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 23)
        Me.Label1.TabIndex = 27
        Me.Label1.Tag = "Code"
        Me.Label1.Text = "Mã nốt"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 201)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 23)
        Me.Label2.TabIndex = 30
        Me.Label2.Tag = "Time"
        Me.Label2.Text = "Giờ đi"
        '
        'LabTen_KHVAT
        '
        Me.LabTen_KHVAT.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.LabTen_KHVAT.Location = New System.Drawing.Point(8, 234)
        Me.LabTen_KHVAT.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabTen_KHVAT.Name = "LabTen_KHVAT"
        Me.LabTen_KHVAT.Size = New System.Drawing.Size(133, 23)
        Me.LabTen_KHVAT.TabIndex = 355
        Me.LabTen_KHVAT.Tag = "Route code"
        Me.LabTen_KHVAT.Text = "Mã tuyến"
        '
        'TxtNh_not1
        '
        Me.TxtNh_not1._ActilookupPopup = False
        Me.TxtNh_not1.CyberActilookupPopup = True
        Me.TxtNh_not1.Dv_ListDetail = Nothing
        Me.TxtNh_not1.Dv_Master = Nothing
        Me.TxtNh_not1.FilterClient = ""
        Me.TxtNh_not1.FilterSQL = ""
        Me.TxtNh_not1.Location = New System.Drawing.Point(99, 14)
        Me.TxtNh_not1.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_not1.Name = "TxtNh_not1"
        Me.TxtNh_not1.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_not1.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_not1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_not1.Size = New System.Drawing.Size(199, 22)
        Me.TxtNh_not1.TabIndex = 0
        Me.TxtNh_not1.Table_Name = ""
        '
        'TxtTen_Nh1
        '
        Me.TxtTen_Nh1.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh1.Location = New System.Drawing.Point(308, 18)
        Me.TxtTen_Nh1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_Nh1.Name = "TxtTen_Nh1"
        Me.TxtTen_Nh1.Size = New System.Drawing.Size(652, 18)
        Me.TxtTen_Nh1.TabIndex = 362
        Me.TxtTen_Nh1.Tag = ""
        '
        'TxtMa_tuyen
        '
        Me.TxtMa_tuyen._ActilookupPopup = False
        Me.TxtMa_tuyen.CyberActilookupPopup = True
        Me.TxtMa_tuyen.Dv_ListDetail = Nothing
        Me.TxtMa_tuyen.Dv_Master = Nothing
        Me.TxtMa_tuyen.FilterClient = ""
        Me.TxtMa_tuyen.FilterSQL = ""
        Me.TxtMa_tuyen.Location = New System.Drawing.Point(99, 230)
        Me.TxtMa_tuyen.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_tuyen.Name = "TxtMa_tuyen"
        Me.TxtMa_tuyen.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_tuyen.Properties.Appearance.Options.UseForeColor = True
        Me.TxtMa_tuyen.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtMa_tuyen.Size = New System.Drawing.Size(199, 22)
        Me.TxtMa_tuyen.TabIndex = 7
        Me.TxtMa_tuyen.Table_Name = ""
        '
        'TxtTen_tuyen
        '
        Me.TxtTen_tuyen.BackColor = System.Drawing.Color.White
        Me.TxtTen_tuyen.Location = New System.Drawing.Point(307, 234)
        Me.TxtTen_tuyen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_tuyen.Name = "TxtTen_tuyen"
        Me.TxtTen_tuyen.Size = New System.Drawing.Size(653, 18)
        Me.TxtTen_tuyen.TabIndex = 365
        Me.TxtTen_tuyen.Tag = ""
        '
        'TxtTen_not
        '
        Me.TxtTen_not.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtTen_not.ForeColor = System.Drawing.Color.Navy
        Me.TxtTen_not.Location = New System.Drawing.Point(99, 166)
        Me.TxtTen_not.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtTen_not.Name = "TxtTen_not"
        Me.TxtTen_not.Size = New System.Drawing.Size(197, 24)
        Me.TxtTen_not.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 170)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 23)
        Me.Label5.TabIndex = 369
        Me.Label5.Tag = "Name"
        Me.Label5.Text = "Tên nốt"
        '
        'TxtMa_not
        '
        Me.TxtMa_not.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtMa_not.ForeColor = System.Drawing.Color.Navy
        Me.TxtMa_not.Location = New System.Drawing.Point(99, 136)
        Me.TxtMa_not.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtMa_not.Name = "TxtMa_not"
        Me.TxtMa_not.Size = New System.Drawing.Size(197, 24)
        Me.TxtMa_not.TabIndex = 4
        '
        'TxtLoai_Not
        '
        Me.TxtLoai_Not.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtLoai_Not.ForeColor = System.Drawing.Color.Navy
        Me.TxtLoai_Not.Location = New System.Drawing.Point(99, 105)
        Me.TxtLoai_Not.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtLoai_Not.Name = "TxtLoai_Not"
        Me.TxtLoai_Not.Size = New System.Drawing.Size(197, 24)
        Me.TxtLoai_Not.TabIndex = 3
        '
        'TxtGio_di
        '
        Me.TxtGio_di.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.TxtGio_di.ForeColor = System.Drawing.Color.Navy
        Me.TxtGio_di.Location = New System.Drawing.Point(99, 197)
        Me.TxtGio_di.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtGio_di.Name = "TxtGio_di"
        Me.TxtGio_di.Size = New System.Drawing.Size(197, 24)
        Me.TxtGio_di.TabIndex = 6
        '
        'TxtTen_Nh2
        '
        Me.TxtTen_Nh2.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh2.Location = New System.Drawing.Point(308, 48)
        Me.TxtTen_Nh2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_Nh2.Name = "TxtTen_Nh2"
        Me.TxtTen_Nh2.Size = New System.Drawing.Size(652, 18)
        Me.TxtTen_Nh2.TabIndex = 372
        Me.TxtTen_Nh2.Tag = ""
        '
        'TxtNh_not2
        '
        Me.TxtNh_not2._ActilookupPopup = False
        Me.TxtNh_not2.CyberActilookupPopup = True
        Me.TxtNh_not2.Dv_ListDetail = Nothing
        Me.TxtNh_not2.Dv_Master = Nothing
        Me.TxtNh_not2.FilterClient = ""
        Me.TxtNh_not2.FilterSQL = ""
        Me.TxtNh_not2.Location = New System.Drawing.Point(99, 44)
        Me.TxtNh_not2.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_not2.Name = "TxtNh_not2"
        Me.TxtNh_not2.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_not2.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_not2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_not2.Size = New System.Drawing.Size(199, 22)
        Me.TxtNh_not2.TabIndex = 1
        Me.TxtNh_not2.Table_Name = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 48)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 23)
        Me.Label4.TabIndex = 371
        Me.Label4.Tag = "Group 2"
        Me.Label4.Text = "Nhóm nốt 2"
        '
        'TxtTen_Nh3
        '
        Me.TxtTen_Nh3.BackColor = System.Drawing.Color.White
        Me.TxtTen_Nh3.Location = New System.Drawing.Point(307, 78)
        Me.TxtTen_Nh3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TxtTen_Nh3.Name = "TxtTen_Nh3"
        Me.TxtTen_Nh3.Size = New System.Drawing.Size(653, 18)
        Me.TxtTen_Nh3.TabIndex = 375
        Me.TxtTen_Nh3.Tag = ""
        '
        'TxtNh_not3
        '
        Me.TxtNh_not3._ActilookupPopup = False
        Me.TxtNh_not3.CyberActilookupPopup = True
        Me.TxtNh_not3.Dv_ListDetail = Nothing
        Me.TxtNh_not3.Dv_Master = Nothing
        Me.TxtNh_not3.FilterClient = ""
        Me.TxtNh_not3.FilterSQL = ""
        Me.TxtNh_not3.Location = New System.Drawing.Point(99, 75)
        Me.TxtNh_not3.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtNh_not3.Name = "TxtNh_not3"
        Me.TxtNh_not3.Properties.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.TxtNh_not3.Properties.Appearance.Options.UseForeColor = True
        Me.TxtNh_not3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.TxtNh_not3.Size = New System.Drawing.Size(199, 22)
        Me.TxtNh_not3.TabIndex = 2
        Me.TxtNh_not3.Table_Name = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 78)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(133, 23)
        Me.Label7.TabIndex = 374
        Me.Label7.Tag = "Group 3"
        Me.Label7.Text = "Nhóm nốt 3"
        '
        'DMNOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(976, 339)
        Me.Controls.Add(Me.TxtTen_Nh3)
        Me.Controls.Add(Me.TxtNh_not3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTen_Nh2)
        Me.Controls.Add(Me.TxtNh_not2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtGio_di)
        Me.Controls.Add(Me.TxtLoai_Not)
        Me.Controls.Add(Me.TxtMa_not)
        Me.Controls.Add(Me.TxtTen_not)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtTen_tuyen)
        Me.Controls.Add(Me.TxtMa_tuyen)
        Me.Controls.Add(Me.TxtTen_Nh1)
        Me.Controls.Add(Me.TxtNh_not1)
        Me.Controls.Add(Me.LabTen_KHVAT)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabMa_Nh1)
        Me.Controls.Add(Me.LabMa_KH)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "DMNOT"
        Me.Text = "Danh mục nốt vận tải"
        Me.Controls.SetChildIndex(Me.LabMa_KH, 0)
        Me.Controls.SetChildIndex(Me.LabMa_Nh1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.LabTen_KHVAT, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_Dvcs, 0)
        Me.Controls.SetChildIndex(Me.ChkActi, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_not1, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh1, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_tuyen, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_tuyen, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_not, 0)
        Me.Controls.SetChildIndex(Me.TxtMa_not, 0)
        Me.Controls.SetChildIndex(Me.TxtLoai_Not, 0)
        Me.Controls.SetChildIndex(Me.TxtGio_di, 0)
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_not2, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh2, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.TxtNh_not3, 0)
        Me.Controls.SetChildIndex(Me.TxtTen_Nh3, 0)
        CType(Me.TxtNh_not1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtMa_tuyen.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_not2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TxtNh_not3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMa_KH As System.Windows.Forms.Label
    Friend WithEvents LabMa_Nh1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LabTen_KHVAT As System.Windows.Forms.Label
    Friend WithEvents TxtNh_not1 As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_Nh1 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_tuyen As Cyber.SmLists.TxtLookup
    Friend WithEvents TxtTen_tuyen As System.Windows.Forms.Label
    Friend WithEvents TxtTen_not As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtMa_not As System.Windows.Forms.TextBox
    Friend WithEvents TxtLoai_Not As System.Windows.Forms.TextBox
    Friend WithEvents TxtGio_di As System.Windows.Forms.TextBox
    Friend WithEvents TxtTen_Nh2 As System.Windows.Forms.Label
    Friend WithEvents TxtNh_not2 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtTen_Nh3 As System.Windows.Forms.Label
    Friend WithEvents TxtNh_not3 As Cyber.SmLists.TxtLookup
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
