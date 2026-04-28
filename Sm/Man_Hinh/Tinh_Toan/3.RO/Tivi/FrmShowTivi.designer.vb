<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShowTivi
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
        Me.components = New System.ComponentModel.Container()
        Me.LabMaster = New System.Windows.Forms.Label()
        Me.Timer_LoadDb = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_ScrollGrid = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_ScrollLable = New System.Windows.Forms.Timer(Me.components)
        Me.Master = New DevExpress.XtraGrid.GridControl()
        Me.MasterGRV = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabFooter = New System.Windows.Forms.Label()
        Me.LabTime_Clock = New System.Windows.Forms.Label()
        Me.Timer_clock = New System.Windows.Forms.Timer(Me.components)
        CType(Me.Master, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBoxLine
        '
        Me.GroupBoxLine.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBoxLine.Location = New System.Drawing.Point(215, 527)
        Me.GroupBoxLine.Size = New System.Drawing.Size(570, 8)
        Me.GroupBoxLine.Visible = False
        '
        'ButtOK
        '
        Me.ButtOK.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtOK.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtOK.Appearance.Options.UseForeColor = True
        Me.ButtOK.Location = New System.Drawing.Point(583, 537)
        Me.ButtOK.Visible = False
        '
        'ButtExit
        '
        Me.ButtExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtExit.Appearance.ForeColor = System.Drawing.Color.Navy
        Me.ButtExit.Appearance.Options.UseForeColor = True
        Me.ButtExit.Location = New System.Drawing.Point(685, 537)
        Me.ButtExit.Visible = False
        '
        'LabMaster
        '
        Me.LabMaster.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabMaster.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabMaster.ForeColor = System.Drawing.Color.White
        Me.LabMaster.Location = New System.Drawing.Point(79, 5)
        Me.LabMaster.Name = "LabMaster"
        Me.LabMaster.Size = New System.Drawing.Size(821, 53)
        Me.LabMaster.TabIndex = 46
        Me.LabMaster.Text = "CẢM ƠN QUÝ KHÁCH ĐÃ SỬ DỤNG DỊCH VỤ"
        Me.LabMaster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Master
        '
        Me.Master.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Master.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Master.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Master.Location = New System.Drawing.Point(-1, 61)
        Me.Master.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.Master.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.Master.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Master.MainView = Me.MasterGRV
        Me.Master.Name = "Master"
        Me.Master.Size = New System.Drawing.Size(1002, 441)
        Me.Master.TabIndex = 572
        Me.Master.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.MasterGRV})
        '
        'MasterGRV
        '
        Me.MasterGRV.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MasterGRV.Appearance.FocusedRow.Options.UseBackColor = True
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Red
        Me.MasterGRV.Appearance.SelectedRow.Options.UseBackColor = True
        Me.MasterGRV.Appearance.ViewCaption.Options.UseTextOptions = True
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.MasterGRV.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.MasterGRV.AppearancePrint.EvenRow.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterGRV.AppearancePrint.EvenRow.Options.UseFont = True
        Me.MasterGRV.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.MasterGRV.CustomizationFormBounds = New System.Drawing.Rectangle(907, 465, 210, 172)
        Me.MasterGRV.GridControl = Me.Master
        Me.MasterGRV.GroupRowHeight = 30
        Me.MasterGRV.Name = "MasterGRV"
        Me.MasterGRV.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.MasterGRV.OptionsLayout.Columns.AddNewColumns = False
        Me.MasterGRV.OptionsSelection.CheckBoxSelectorColumnWidth = 20
        Me.MasterGRV.OptionsView.ColumnAutoWidth = False
        Me.MasterGRV.OptionsView.ShowGroupPanel = False
        Me.MasterGRV.RowHeight = 21
        '
        'LabFooter
        '
        Me.LabFooter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LabFooter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabFooter.ForeColor = System.Drawing.Color.White
        Me.LabFooter.Location = New System.Drawing.Point(0, 503)
        Me.LabFooter.Name = "LabFooter"
        Me.LabFooter.Size = New System.Drawing.Size(1001, 44)
        Me.LabFooter.TabIndex = 573
        Me.LabFooter.Text = "CẢM ƠN QUÝ KHÁCH ĐÃ SỬ DỤNG DỊCH VỤ"
        Me.LabFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabTime_Clock
        '
        Me.LabTime_Clock.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabTime_Clock.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabTime_Clock.ForeColor = System.Drawing.Color.White
        Me.LabTime_Clock.Location = New System.Drawing.Point(895, 5)
        Me.LabTime_Clock.Name = "LabTime_Clock"
        Me.LabTime_Clock.Size = New System.Drawing.Size(101, 53)
        Me.LabTime_Clock.TabIndex = 574
        Me.LabTime_Clock.Text = "10:20"
        Me.LabTime_Clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer_clock
        '
        Me.Timer_clock.Enabled = True
        Me.Timer_clock.Interval = 1000
        '
        'FrmShowTivi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1001, 546)
        Me.Controls.Add(Me.LabFooter)
        Me.Controls.Add(Me.LabTime_Clock)
        Me.Controls.Add(Me.Master)
        Me.Controls.Add(Me.LabMaster)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "FrmShowTivi"
        Me.Text = "Màn hình tiếp đón dịch vụ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.LabMaster, 0)
        Me.Controls.SetChildIndex(Me.Master, 0)
        Me.Controls.SetChildIndex(Me.LabTime_Clock, 0)
        Me.Controls.SetChildIndex(Me.ButtExit, 0)
        Me.Controls.SetChildIndex(Me.ButtOK, 0)
        Me.Controls.SetChildIndex(Me.GroupBoxLine, 0)
        Me.Controls.SetChildIndex(Me.LabFooter, 0)
        CType(Me.Master, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MasterGRV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabMaster As System.Windows.Forms.Label
    Friend WithEvents Timer_LoadDb As System.Windows.Forms.Timer
    Friend WithEvents Timer_ScrollGrid As System.Windows.Forms.Timer
    Friend WithEvents Timer_ScrollLable As System.Windows.Forms.Timer
    Friend WithEvents Master As DevExpress.XtraGrid.GridControl
    Friend WithEvents MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabFooter As System.Windows.Forms.Label
    Friend WithEvents LabTime_Clock As System.Windows.Forms.Label
    Friend WithEvents Timer_clock As System.Windows.Forms.Timer

End Class
