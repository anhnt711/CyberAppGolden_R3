Imports System.Data.SqlClient

Public Class FSysKPI
    Dim CyberPrint As New Cyber.Print.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    '----------
    Dim EditLoading As New Cyber.Fill.CyberColumnGridView
    Dim Dt_Master, Dt_head As DataTable
    Dim Dv_Master, Dv_head As DataView
    '----------
    Dim M_Ma_Phan_He As String
    Dim M_VT_PARA As Integer
    '----------
    Dim DsData, DsHeader, DsMaster As New DataSet
    Dim DtUnists As DataTable
    Private Sub FSysKPI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_VT_PARA = CType(Me.Para(0).Trim, Integer)
        Me.Save_OK = False
        TxtM_Ngay_CT1.Value = Now.Date()
        TxtM_Ngay_CT2.Value = Now.Date()

        DtUnists = V_GetUnists(AppConn, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, DtUnists, "Ma_Dvcs", "Ten_Dvcs", M_Ma_Dvcs)
      
        V_Load()
        V_Fill()
        V_AddHandler()
        Me.Text = Me.Text.ToUpper
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Function V_GetUnists(ByVal Appconn As SqlConnection, ByVal _Ma_Dvcs As String, ByVal _User_Name As String, Optional ByVal CyberSmLib As Cyber.SmLib.Sys = Nothing) As DataTable
        Dim DsUnits As New DataSet
        DsUnits = CyberSmLib.SQLExcuteStoreProcedure(Appconn, "CP_SysListUnits", _Ma_Dvcs.Trim + "#" + _User_Name)
        V_GetUnists = DsUnits.Tables(0).Copy
        DsUnits.Dispose()
    End Function
    Private Sub V_AddHandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler MasterGRV.FocusedRowChanged, AddressOf MasterGRV_FocusedRowChanged

        AddHandler CBBMa_Dvcs.SelectedValueChanged, AddressOf V_Loading
        AddHandler EditLoading.EditColumn.Click, AddressOf V_Loading
        AddHandler ChkLabel.CheckedChanged, AddressOf V_ChkLable
        AddHandler ChkSeriesFrom.CheckedChanged, AddressOf V_ChkSeriesFrom
    End Sub
#Region "Loading..."
    Private Sub V_Load()
        '------------------------------------------------------------------------------------------------------------
        M_Ma_Phan_He = ""
        Try
            M_Ma_Phan_He = Me.Para(M_VT_PARA + 2)
        Catch ex As Exception
        End Try
        Dim _Ma_Dvcs As String = ""
        Try
            _Ma_Dvcs = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Catch ex As Exception

        End Try

        Dim _Ngay_Ct1 As Date = TxtM_Ngay_CT1.Value
        Dim _Ngay_Ct2 As Date = TxtM_Ngay_CT2.Value
        Dim _DsKPI As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysKPI_Load", _Ngay_Ct1.ToString("yyyyMMdd") + "#" + _Ngay_Ct2.ToString("yyyyMMdd") + "#" + M_Ma_Phan_He + "#" + _Ma_Dvcs + "#" + M_User_Name)

        Dt_Master = _DsKPI.Tables(0).Copy
        Dt_head = _DsKPI.Tables(1).Copy
        Dv_Master = New DataView(Dt_Master)
        Dv_head = New DataView(Dt_head)
        '---------------------------------------------------------------------------------------

        '---------------------------------------------------------------------------------------
    End Sub
    Private Sub V_Loading(ByVal iRow As Integer, ByVal Load As String)
        '-- iRow: Index cua ban ghi trong data
        '-- Load: co lay lai du lieu hay khong (1: lay lai du lieu: 0: khong lay lai du lieu)

        If iRow < 0 Then Exit Sub
        If Dt_Master.Columns.Contains("Ma_KPI") = False Then Exit Sub

        Dim _Ma_Dvcs As String = ""
        Try
            _Ma_Dvcs = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Catch ex As Exception

        End Try

        Dim _Ma_KPI As String
        Dim _DtData As New DataTable
        Dim _DtHeader As New DataTable
        Dim _DtMaster As New DataTable

        Dim _isData As Boolean = False
        Dim _isHeader As Boolean = False
        Dim _isMaster As Boolean = False

        _Ma_KPI = Dt_Master.Rows(iRow).Item("Ma_KPI").ToString.Trim
        If _Ma_KPI = "" Then Exit Sub

        _isData = DsData.Tables.Contains(_Ma_KPI)
        _isHeader = DsHeader.Tables.Contains(_Ma_KPI)
        _isMaster = DsMaster.Tables.Contains(_Ma_KPI)

        If Not _isData Then Load = "1"
        If Not _isHeader Then Load = "1"
        If Not _isMaster Then Load = "1"

        If Load = "1" Then
            '==== lay lai du lieu vao 3 bang
            Dim _Ngay_Ct1 As Date = TxtM_Ngay_CT1.Value
            Dim _Ngay_Ct2 As Date = TxtM_Ngay_CT2.Value
            Dim Dstmp As New DataSet
            Dstmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysKPI_Loading", _Ngay_Ct1.ToString("yyyyMMdd") + "#" + _Ngay_Ct2.ToString("yyyyMMdd") + "#" + _Ma_KPI + "#" + _Ma_Dvcs + "#" + M_User_Name)
            If Dstmp.Tables.Count < 3 Then Exit Sub

            _DtData = Dstmp.Tables(0).Copy
            _DtData.TableName = _Ma_KPI

            _DtHeader = Dstmp.Tables(1).Copy
            _DtHeader.TableName = _Ma_KPI

            _DtMaster = Dstmp.Tables(2).Copy
            _DtMaster.TableName = _Ma_KPI

            If _isData Then DsData.Tables.Remove(_Ma_KPI)
            If _isHeader Then DsHeader.Tables.Remove(_Ma_KPI)
            If _isMaster Then DsMaster.Tables.Remove(_Ma_KPI)

            DsData.Tables.Add(_DtData)
            DsHeader.Tables.Add(_DtHeader)
            DsMaster.Tables.Add(_DtMaster)
        Else
            _DtData = DsData.Tables(_Ma_KPI)
            _DtHeader = DsHeader.Tables(_Ma_KPI)
            _DtMaster = DsMaster.Tables(_Ma_KPI)
        End If
        V_LoadChart(_DtData, _DtHeader, _DtMaster, iRow)
    End Sub
    Private Sub V_LoadChart(ByVal _Datasoure As DataTable, ByVal _Datahead As DataTable, ByVal _Master As DataTable, ByVal _Index As Integer)
        Dim DtMasterArgumentDataMember As New List(Of Cyber.Print.CyberArgumentDataMember)
        Dim FileNameArgument As String = ""
        Dim _Title1 As String = ""
        Dim _Title2 As String = ""
        If _Master.Rows.Count > 0 And _Master.Columns.Contains("Title1") Then _Title1 = _Master.Rows(0).Item("Title1")
        If _Master.Rows.Count > 0 And _Master.Columns.Contains("Title2") Then _Title2 = _Master.Rows(0).Item("Title2")
        If _Title2 = "" Then _Title2 = _Title1
        For Each dr As DataRow In _Datahead.Rows
            If dr("Field_Type").ToString.ToUpper = "C" And _Datasoure.Columns.Contains(dr("Field_Name")) Then
                FileNameArgument = dr("Field_Name")
                Exit For
            End If
        Next
        If FileNameArgument = "" Then Exit Sub

        For Each dr As DataRow In _Datasoure.Rows
            DtMasterArgumentDataMember.Add(New Cyber.Print.CyberArgumentDataMember("", dr(FileNameArgument)))
        Next
        Chart1.ClearCache()
        Chart1.DataSource = Nothing
        Chart1.Series.Clear()
        CyberPrint.LoadChart(Chart1, Me.AppConn, Me.Sysvar, M_LAN, _Title1, _Title2, "", "", _Datasoure, _Datahead, DtMasterArgumentDataMember)

        V_ChkLable(New System.Object, New System.EventArgs)
        V_ChkSeriesFrom(New System.Object, New System.EventArgs)
    End Sub
#End Region
#Region "Fill Data"
    Private Sub V_Fill()
        CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_head, Dv_Master)
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
        EditLoading.GetColumn(MasterGRV, "Loading")

        If MasterGRV.RowCount < 1 Then Exit Sub

        V_Loading(0, "1")
    End Sub
#End Region
#Region "Event"
    Private Sub V_Loading(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        V_Loading(iRow, "1")
    End Sub
    Private Sub MasterGRV_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        V_Loading(iRow, "0")
    End Sub
    Private Sub V_ChkLable(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Chart1.SeriesTemplate.LabelsVisibility = IIf(ChkLabel.Checked, DevExpress.Utils.DefaultBoolean.True, DevExpress.Utils.DefaultBoolean.False)
    End Sub
    Private Sub V_ChkSeriesFrom(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkSeriesFrom.Checked Then
            Chart1.SeriesDataMember = "ArgumentDataMember"
            Chart1.SeriesTemplate.ArgumentDataMember = "SeriesDataMember"
        Else
            Chart1.SeriesDataMember = "SeriesDataMember"
            Chart1.SeriesTemplate.ArgumentDataMember = "ArgumentDataMember"
        End If
    End Sub

    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#End Region
End Class