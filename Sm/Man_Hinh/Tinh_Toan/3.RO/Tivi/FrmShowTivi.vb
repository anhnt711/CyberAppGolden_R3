Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing
Public Class FrmShowTivi
#Region "Property"
    Dim M_Ma_Loai As String = ""
    Public Property Ma_Loai As String
        Get
            Ma_Loai = M_Ma_Loai
        End Get
        Set(ByVal Value As String)
            M_Ma_Loai = Value
        End Set
    End Property
#End Region
#Region "Biến"
    Dim Dt_Master, dt_Head, dt_Config As New DataTable
    Dim Dv_Master, dv_Head, dv_Config As New DataView

    Dim M_Cp_name As String = "", M_Cp_name_Config As String = ""
    Dim _RunChuChay As New Threading.Thread(AddressOf V_RunChuChay)
    '----
    Dim TimerLoad As Integer = 60000, TimerScroll As Integer = 10000, TimerLabel As Integer = 2000, pageRowCount As Integer = 7, SortField As String = "" _
    , RowFontSize As Integer = 26, RowHeight As Integer = 26, RowBackColor As String = "", RowForeColor As String = "", RowFont As String = "Microsoft Sans Serif" _
    , TitleFontSize As Integer = 26, TitleBackColor As String = "", TitleForeColor As String = "", TitleFont As String = "Microsoft Sans Serif", TitleBold As String = "1" _
    , FooterFontSize As Integer = 0, FooterBackColor As String = "", FooterForeColor As String = "", FooterFont As String = "Microsoft Sans Serif", FooterBold As String = "1" _
    , HeaderFontSize As Integer = 26, HeaderHeight As Integer = 26, HeaderBackColor As String = "", HeaderForeColor As String = "", HeaderFont As String = "Microsoft Sans Serif", HeaderBold As String = "1"
    '----
    Dim s As Integer = 0, t As Integer = 0
    Dim dta As String, dtb As String
    Dim M_Date_Load As Date = New Date(1900, 1, 1)
    Dim Is_FullScreen As Boolean = False
    Dim Is_Chay_Chu_Header As Boolean = False
    Dim Is_Chay_Chu_Footer As Boolean = False

#End Region
#Region "System"
    Private Sub FrmShowTivi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        '------------------------------------------------------------------------------
        Control.CheckForIllegalCrossThreadCalls = False
        '------------------------------------------------------------------------------
        M_Cp_name = ""
        M_Cp_name = Me.Para(M_VT_PARA + 1).ToString().Trim
        M_Cp_name_Config = M_Cp_name.Trim & "Config"
        If M_Cp_name.Trim = "" Or M_Cp_name_Config.Trim = "" Then Me.Close()
        '------------------------------------------------------------------------------
        If Not V_LoadConFig() Then Me.Close()
        '------------------------------------------------------------------------------
        V_LoadDatabase("1")
        '------------------------------------------------------------------------------
        V_FillDataToGridview(MasterGRV, M_LAN, dv_Head, Dv_Master)
        '------------------------------------------------------------------------------
        V_DesignMaster()
        '------------------------------------------------------------------------------
        V_SetGridview(MasterGRV)
        '------------------------------------------------------------------------------
        MasterGRV.OptionsBehavior.Editable = False
        '------------------------------------------------------------------------------
        dta = LabMaster.Text
        dtb = LabFooter.Text
        '------------------------------------------------------------------------------
        Timer_LoadDb.Interval = TimerLoad
        Timer_ScrollGrid.Interval = TimerScroll
        Timer_ScrollLable.Interval = TimerLabel
        Timer_LoadDb.Start()
        Timer_ScrollGrid.Start()
        _RunChuChay.Start()
        '------------------------------------------------------------------------------
        AddHandle()
        '------------------------------------------------------------------------------
        V_FullScreen()
        '------------------------------------------------------------------------------
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub AddHandle()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler LabMaster.Click, AddressOf LblMaster_Click
        AddHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle

        AddHandler Timer_LoadDb.Tick, AddressOf Timer_LoadDb_Tick
        AddHandler Timer_ScrollGrid.Tick, AddressOf Timer_ScrollGrid_Tick
        AddHandler Timer_clock.Tick, AddressOf V_Timer_clock


    End Sub
    Private Sub V_FullScreen()
        If Not Is_FullScreen Then Return
        Me.WindowState = FormWindowState.Maximized
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End If
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Me.Close()
    End Sub
    Private Sub LblMaster_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub FrmShowTivi_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        CyberSmlib.FlushMemory()
        System.Diagnostics.Process.GetCurrentProcess().Kill()
        Application.Exit()
    End Sub
#End Region
#Region "Load databases"
    Private Function V_LoadConFig() As Boolean
        '----- 2.Using config to design
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, M_Cp_name_Config, M_Ma_Loai & "#" & M_Ma_Dvcs & "#" & M_User_Name.Trim)
        Dim nCount As Integer = 0
        nCount = DsTmp.Tables.Count()
        If nCount < 1 Then Return False

        dt_Config = DsTmp.Tables(0).Copy
        dv_Config = New DataView(dt_Config)

        If dt_Config.Columns.Contains("Title_Page") Then Me.Text = dt_Config.Rows(0).Item("Title_Page").ToString.Trim
        If dt_Config.Columns.Contains("PageBackColor") Then Me.BackColor = Drawing.Color.FromName(dt_Config.Rows(0).Item("PageBackColor"))

        If dt_Config.Columns.Contains("Title") Then LabMaster.Text = dt_Config.Rows(0).Item("Title").ToString.Trim
        If dt_Config.Columns.Contains("TitleFont") Then TitleFont = dt_Config.Rows(0).Item("TitleFont").ToString.Trim
        If dt_Config.Columns.Contains("TitleFontSize") Then TitleFontSize = dt_Config.Rows(0).Item("TitleFontSize")
        If dt_Config.Columns.Contains("TitleBackColor") Then TitleBackColor = dt_Config.Rows(0).Item("TitleBackColor")
        If dt_Config.Columns.Contains("TitleForeColor") Then TitleForeColor = dt_Config.Rows(0).Item("TitleForeColor")
        If dt_Config.Columns.Contains("TitleBold") Then TitleBold = dt_Config.Rows(0).Item("TitleBold")

        If dt_Config.Columns.Contains("TimerLoad") Then TimerLoad = dt_Config.Rows(0).Item("TimerLoad")
        If dt_Config.Columns.Contains("TimerScroll") Then TimerScroll = dt_Config.Rows(0).Item("TimerScroll")
        If dt_Config.Columns.Contains("TimerLabel") Then TimerLabel = dt_Config.Rows(0).Item("TimerLabel")
        If dt_Config.Columns.Contains("pageRowCount") Then pageRowCount = dt_Config.Rows(0).Item("pageRowCount")

        If dt_Config.Columns.Contains("HeaderFontSize") Then HeaderFontSize = dt_Config.Rows(0).Item("HeaderFontSize")
        If dt_Config.Columns.Contains("HeaderFont") Then HeaderFont = dt_Config.Rows(0).Item("HeaderFont")
        If dt_Config.Columns.Contains("HeaderBackColor") Then HeaderBackColor = dt_Config.Rows(0).Item("HeaderBackColor")
        If dt_Config.Columns.Contains("HeaderForeColor") Then HeaderForeColor = dt_Config.Rows(0).Item("HeaderForeColor")
        If dt_Config.Columns.Contains("HeaderBold") Then HeaderBold = dt_Config.Rows(0).Item("HeaderBold")
        If dt_Config.Columns.Contains("HeaderHeight") Then HeaderHeight = dt_Config.Rows(0).Item("HeaderHeight")

        If dt_Config.Columns.Contains("RowFontSize") Then RowFontSize = dt_Config.Rows(0).Item("RowFontSize")
        If dt_Config.Columns.Contains("RowFont") Then RowFont = dt_Config.Rows(0).Item("RowFont")
        If dt_Config.Columns.Contains("RowBackColor") Then RowBackColor = dt_Config.Rows(0).Item("RowBackColor")
        If dt_Config.Columns.Contains("RowForeColor") Then RowForeColor = dt_Config.Rows(0).Item("RowForeColor")
        If dt_Config.Columns.Contains("RowHeight") Then RowHeight = dt_Config.Rows(0).Item("RowHeight")

        If dt_Config.Columns.Contains("FooterFooter") Then LabFooter.Text = dt_Config.Rows(0).Item("FooterFooter").ToString.Trim
        If dt_Config.Columns.Contains("FooterFont") Then FooterFont = dt_Config.Rows(0).Item("FooterFont").ToString.Trim

        If dt_Config.Columns.Contains("FooterFontSize") Then FooterFontSize = dt_Config.Rows(0).Item("FooterFontSize")

        If dt_Config.Columns.Contains("FooterBackColor") Then FooterBackColor = dt_Config.Rows(0).Item("FooterBackColor")
        If dt_Config.Columns.Contains("FooterForeColor") Then FooterForeColor = dt_Config.Rows(0).Item("FooterForeColor")
        If dt_Config.Columns.Contains("FooterBold") Then FooterBold = dt_Config.Rows(0).Item("FooterBold")


        '--------------
        If dt_Config.Columns.Contains("Is_FullScreen") Then Is_FullScreen = (dt_Config.Rows(0).Item("Is_FullScreen").ToString = "1")

        If dt_Config.Columns.Contains("Is_Chay_Chu_Header") Then Is_Chay_Chu_Header = (dt_Config.Rows(0).Item("Is_Chay_Chu_Header").ToString = "1")
        If dt_Config.Columns.Contains("Is_Chay_Chu_Footer") Then Is_Chay_Chu_Footer = (dt_Config.Rows(0).Item("Is_Chay_Chu_Footer").ToString = "1")


        DsTmp.Dispose()
        Return True
    End Function
    Private Sub V_LoadDatabase(ByVal Status As String)
        '----- 1.Loading data
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, M_Cp_name, Status & "#" & M_Ma_Loai & "#" & M_Date_Load.ToString("yyyyMMdd HH:mm:ss") & "#" & M_Ma_Dvcs & "#" & M_User_Name.Trim)
        '-------------------------------------------------------------------------
        M_Date_Load = DsTmp.Tables(0).Rows(0).Item("Date_Load")
        If DsTmp.Tables.Count = 1 And Status = "0" Then Return

        Timer_ScrollGrid.Stop()
        Timer_ScrollLable.Stop()
        If Status = "1" Then
            Dt_Master = DsTmp.Tables(1).Copy
            dt_Head = DsTmp.Tables(3).Copy

            Dv_Master = New DataView(Dt_Master)
            dv_Head = New DataView(dt_Head)
            CyberSupport.V_SetSortView(Dv_Master, DsTmp.Tables(2))
            DsTmp.Dispose()
            Exit Sub
        End If
        '------------------------------------------------------------------------- 
        Dt_Master.Clear()
        Dt_Master.Load(DsTmp.Tables(1).CreateDataReader)
        Dt_Master.AcceptChanges()
        Timer_ScrollGrid.Interval = TimerScroll
        Timer_ScrollGrid.Start()
        DsTmp.Dispose()
        GC.Collect(1, GCCollectionMode.Forced)
    End Sub
#End Region
#Region "Timer"
    Private Sub V_Timer_clock(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LabTime_Clock.Text = Strings.Right("00" & Now.Hour.ToString.Trim, 2) & ":" & Strings.Right("00" & Now.Minute.ToString.Trim, 2)
    End Sub

    Private Sub Timer_LoadDb_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabase("0")
    End Sub
    Private Sub Timer_ScrollGrid_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ScrollGrid(MasterGRV)
    End Sub
    Private Sub Timer_ScrollLabel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        s = s + 1
        LabMaster.Text = Mid(dta, 1, s)
        If Len(LabMaster.Text) >= 78 Then LabMaster.Text = Strings.Right(LabMaster.Text, 77)
        If s = Len(dta) Then
            LabMaster.Text = ""
            s = 0
        End If
        t = t + 1
        LabFooter.Text = Mid(dtb, 1, t)
        If Len(LabFooter.Text) >= 90 Then LabFooter.Text = Strings.Right(LabFooter.Text, 89)
        If t = Len(dtb) Then
            LabFooter.Text = ""
            t = 0
        End If
    End Sub
    Sub V_RunChuChay()
        While True
            Try
                If Is_Chay_Chu_Header Then
                    s = s + 1
                    LabMaster.Text = Mid(dta, 1, s)
                    If Len(LabMaster.Text) >= 78 Then LabMaster.Text = Strings.Right(LabMaster.Text, 77)
                    If s = Len(dta) Then
                        LabMaster.Text = ""
                        s = 0
                    End If
                End If
                
                If Is_Chay_Chu_Footer Then
                    t = t + 1
                    LabFooter.Text = Mid(dtb, 1, t)
                    If Len(LabFooter.Text) >= 90 Then LabFooter.Text = Strings.Right(LabFooter.Text, 89)
                    If t = Len(dtb) Then
                        LabFooter.Text = ""
                        t = 0
                    End If
                End If
            Catch ex As Exception
            End Try
            Threading.Thread.Sleep(TimerLabel)
        End While
    End Sub
#End Region
#Region "Grid"
    Private Sub V_DesignMaster()
        Dim fTitleBold As New Font(TitleFont, TitleFontSize, FontStyle.Bold)
        Dim fTitleRegular As New Font(TitleFont, TitleFontSize, FontStyle.Regular)
        LabMaster.Font = IIf(TitleBold.Trim = "1", fTitleBold, fTitleRegular)

        LabMaster.BackColor = Drawing.Color.FromName(TitleBackColor)
        LabMaster.ForeColor = Drawing.Color.FromName(TitleForeColor)

        LabTime_Clock.BackColor = Drawing.Color.FromName(TitleBackColor)
        LabTime_Clock.ForeColor = Drawing.Color.FromName(TitleForeColor)

        '------------------
        If FooterFontSize <= 0 Then FooterFontSize = 22
        Dim fFooterBold As New Font(FooterFont, FooterFontSize, FontStyle.Bold)
        Dim fFooterRegular As New Font(FooterFont, FooterFontSize, FontStyle.Regular)
        '------------------

        LabFooter.Font = IIf(FooterBold.Trim = "1", fFooterBold, fFooterRegular)
        LabFooter.BackColor = Drawing.Color.FromName(FooterBackColor)
        LabFooter.ForeColor = Drawing.Color.FromName(FooterForeColor)
        '------------------

    End Sub
    Private Sub V_FillDataToGridview(ByVal GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal dv_Head As DataView, ByVal DvData As DataView)
        GRV.OptionsBehavior.Editable = True
        CyberFill.V_FillReports(GRV, _M_lan, dv_Head, DvData)
        GRV.GridControl.DataSource = DvData
    End Sub
    Private Sub V_SetGridview(ByVal GRV As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim fBoldHeader As New Font(TitleFont, HeaderFontSize, FontStyle.Bold)
        Dim fRegHeader As New Font(TitleFont, HeaderFontSize, FontStyle.Regular)
        Dim fReg As New Font(RowFont, RowFontSize, FontStyle.Regular)

        GRV.Appearance.Row.Font = fReg
        GRV.RowHeight = RowHeight
        GRV.ColumnPanelRowHeight = HeaderHeight
        GRV.HorzScrollVisibility = False
        GRV.VertScrollVisibility = False

        CyberFill.V_GridviewRowCellStyle(GRV)
        GRV.OptionsView.ShowIndicator = False

        For Each Col As DevExpress.XtraGrid.Columns.GridColumn In GRV.Columns
            Col.AppearanceHeader.BackColor = Drawing.Color.FromName(HeaderBackColor)
            Col.AppearanceHeader.Font = IIf(HeaderBold.Trim = "1", fBoldHeader, fRegHeader)
            Col.AppearanceHeader.ForeColor = Drawing.Color.FromName(HeaderForeColor)
            Col.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Next
        GRV.OptionsView.RowAutoHeight = True
    End Sub
    Sub ScrollGrid(ByVal _Dgr As DevExpress.XtraGrid.Views.Grid.GridView)
        If Not Dt_Master.Columns.Contains("Stt") Then Return
        Dim selRow As DataRow = Nothing
        Dim vStt As Integer = 0, nCount As Integer = _Dgr.RowCount
        If nCount <= 0 Then Exit Sub
        If _Dgr.RowCount <= 0 Then Exit Sub
        selRow = _Dgr.GetFocusedDataRow
        vStt = selRow.Item("Stt")
        vStt = vStt + pageRowCount
        If vStt >= 1 Then vStt = vStt - 1
        If vStt > nCount - 1 Then vStt = nCount - 1
        _Dgr.ClearSelection()
        _Dgr.SelectRow(vStt)
        _Dgr.FocusedRowHandle = vStt
        _Dgr.MakeRowVisible(vStt)
    End Sub
    Private Sub DetailGRV_RowCellStyle(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterGRV, Dt_Master, MasterGRV.Appearance.Row.Font)

        'CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterGRV, Dt_Master, Me.Font)

        'Dim currentView As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        'If currentView.GetDataRow(e.RowHandle) IsNot Nothing Then
        '    Dim drIsValid As DataRow = currentView.GetDataRow(e.RowHandle)
        '    e.Appearance.BackColor = Drawing.Color.FromName(drIsValid.Item("BackColor").ToString)
        '    e.Appearance.ForeColor = Drawing.Color.FromName(drIsValid.Item("ForeColor").ToString)
        '    If currentView.IsRowSelected(e.RowHandle) OrElse currentView.FocusedRowHandle = e.RowHandle Then
        '        e.Appearance.BackColor = Drawing.Color.FromName(drIsValid.Item("BackColor").ToString)
        '        e.Appearance.ForeColor = Drawing.Color.FromName(drIsValid.Item("ForeColor").ToString)
        '    End If
        'End If
    End Sub
#End Region
End Class
