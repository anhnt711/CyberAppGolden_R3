Imports DevExpress.XtraScheduler
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Windows.Forms
Public Class FrmSua_Bien_So
    Dim CyberWork As New Sys
    Dim CyberColor As New Cyber.Color.Sys

    Dim Dt_Ngay_Tien_Do, Dt_Timer_Data, Dt_Buoc_Nhay, Dt_Do_Rong, DmCVDV_Loc, Dt_ConFigColor As DataTable

    Dim Dt_DmCVDV, Dt_Data, Dt_Data_Sort, Dt_Data_Parent, Dt_Cho, Dt_Cho_H, M_DmUT As DataTable
    Dim Dv_DmCVDV, Dv_Data, Dv_Data_Sort, Dv_Data_Parent, Dv_Cho, Dv_Cho_H As DataView

    Dim M_StartHour, M_FinishHour As Integer
    Dim M_StartMINUTE, M_FinishMINUTE As Integer
    Dim M_Ngay_LimitInterval_Min As Date
    Dim M_Ngay_LimitInterval_Max As Date
    Dim M_Thu_Bay As String = "0"
    Dim M_Chu_Nhat As String = "1"
    Private Sub FTiep_Don_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Timer_PercentComplete.Enabled = False
        Me.Save_OK = False
        Me.Text = "DANH SÁCH XE VÀO CỔNG"
        TxtM_Ngay_Ct.Value = Now.Date
        '------------------------------------------------------------------------------------------------------
        Tao_Ngam_Dinh()
        '------------------------------------------------------------------------------------------------------
        V_Ngay_Ct_Tien_Do()
        '------------------------------------------------------------------------------------------------------
        V_CyberSetTime_Tien_Do()
        '------------------------------------------------------------------------------------------------------
        'V_LoadData_Tien_Do("1", "")
        V_LoadData_Tien_Do_Xe("1", "")
        '------------------------------------------------------------------------------------------------------
        V_SetSchedulerControl()
        '------------------------------------------------------------------------------------------------------
        '------------------------------------------------------------------------------------------------------
        V_AddHander_Tien_Do()
        '------------------------------------------------------------------------------------------------------
        '------------------------------------------------------------------------------------------------------
        'V_LoadData_Tien_Do_Xe("0", "")
        '------------------------------------------------------------------------------------------------------
        ' V_DragDropGridview()
        '------------------------------------------------------------------------------------------------------
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()

    End Sub
#Region "Databases And System"
    Private Sub Tao_Ngam_Dinh()
        Dim _Dt As Date = TxtM_Ngay_Ct.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_Ngam_Dinh", _Dt.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        DmCVDV_Loc = DsTmp.Tables(0).Copy
        Dt_DmCVDV = DsTmp.Tables(1).Copy
        Dt_ConFigColor = DsTmp.Tables(2).Copy
        Dt_Timer_Data = DsTmp.Tables(3).Copy

        Dt_Buoc_Nhay = DsTmp.Tables(4).Copy
        Dt_Do_Rong = DsTmp.Tables(5).Copy
        M_DmUT = DsTmp.Tables(6).Copy
        Dv_DmCVDV = New DataView(Dt_DmCVDV)

        CyberSupport.V_SetSortView(Dv_DmCVDV, "Ma_CVDV")

        DsTmp.Dispose()
        '--------------------------------------------------------------------------------------------------------------
        CyberFill.V_FillComBoxDefaul(CbbTime_Data, Dt_Timer_Data, "Tg", "Ten_TG", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_BN, Dt_Buoc_Nhay, "Ma_BN", "Ten_BN", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbDo_Rong, Dt_Do_Rong, "Ma_Width", "Ten_Width", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbCVDV, DmCVDV_Loc, "Ma_HS", "Ten_Hs", "Ngam_Dinh")
    End Sub
    Private Sub V_LoadData_Tien_Do(ByVal status As String, ByVal _Stt_Rec As String)
        SchedulerStorage.Appointments.AutoReload = False
        Dim _Dt As Date = TxtM_Ngay_Ct.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_DATA", status + "#" + _Stt_Rec & "#" & _Dt.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If status = "1" Then
            Dt_Data_Sort = DsTmp.Tables(0).Copy
            Dt_Data = DsTmp.Tables(1).Copy
            Dv_Data = New DataView(Dt_Data)
            CyberSupport.V_SetSortView(Dv_Data, Dt_Data_Sort)
        Else
            If _Stt_Rec.Trim = "" Then
                Dt_Data.Clear()
                Dt_Data.Load(DsTmp.Tables(0).CreateDataReader)
            Else
                Dim nCount As Decimal = Dt_Data.Rows.Count - 1
                If Not _Stt_Rec.Trim = "" Then
                    For i = nCount To 0 Step -1
                        If Dt_Data.Rows(i).Item("Stt_Rec").ToString.Trim.ToUpper = _Stt_Rec.Trim.ToUpper Then Dt_Data.Rows(i).Delete()
                    Next
                End If
                Dt_Data.Load(DsTmp.Tables(0).CreateDataReader)
                Dt_Data.AcceptChanges()
            End If
        End If
        DsTmp.Dispose()
        SchedulerStorage.Appointments.AutoReload = True

    End Sub
    Private Sub V_LoadData_Tien_Do_Xe(ByVal Status As String, ByVal _Stt_Rec As String)
        Dim _Dt As Date = TxtM_Ngay_Ct.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_Data_DSXE", Status + "#" + "1" + "#" + _Stt_Rec + "#" + _Dt.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If Status.ToUpper.Trim = "1" Then

            Dt_Cho = DsTmp.Tables(1).Copy
            Dv_Cho = New DataView(Dt_Cho)
            CyberSupport.V_SetSortView(Dv_Cho, DsTmp.Tables(0).Rows(0))

            Dt_Cho_H = DsTmp.Tables(2).Copy
            Dv_Cho_H = New DataView(Dt_Cho_H)

            DGV_CHO.DataSource = Dv_Cho
            Me.DGV_CHOGRV.GridControl = Me.DGV_CHO
            CyberFill.V_FillReports(DGV_CHOGRV, M_LAN, Dv_Cho_H, Dv_Cho)
            DGV_CHOGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
            DGV_CHOGRV.OptionsSelection.MultiSelect = False
        Else
            If _Stt_Rec.Trim = "" Then
                Dt_Cho.Clear()
                Dt_Cho.Load(DsTmp.Tables(0).CreateDataReader)
            Else
                Dim nCount As Decimal = Dt_Cho.Rows.Count - 1
                If Not _Stt_Rec.Trim = "" Then
                    For i = nCount To 0 Step -1
                        If Dt_Cho.Rows(i).Item("Stt_Rec").ToString.Trim.ToUpper = _Stt_Rec.Trim.ToUpper Then Dt_Cho.Rows(i).Delete()
                    Next
                End If
                Dt_Cho.AcceptChanges()
                Dt_Data.Load(DsTmp.Tables(0).CreateDataReader)
            End If
        End If
        DsTmp.Dispose()
    End Sub
    'Private Sub V_RefreshData(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    V_LoadData_Tien_Do("0", "")
    'End Sub
    Private Sub V_Refresh_CHO(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_Tien_Do_Xe("0", "")
    End Sub
    Private Sub V_Quay_Ra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_Ngay_Ct_Tien_Do()
        Dim _Ngay_Ct As Date = TxtM_Ngay_Ct.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_Ngay_Ngam_Dinh", _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs + "#" & M_User_Name)

        If Dt_Ngay_Tien_Do Is Nothing Then
            Dt_Ngay_Tien_Do = DsTmp.Tables(0).Copy
        Else
            Dt_Ngay_Tien_Do.Clear()
            Dt_Ngay_Tien_Do.ImportRow(DsTmp.Tables(0).Rows(0))
        End If
        DsTmp.Dispose()
        V_Set_Ngay_Ct_Tien_Do()

    End Sub
    Private Sub V_Set_Ngay_Ct_Tien_Do()
        M_Thu_Bay = Dt_Ngay_Tien_Do.Rows(0).Item("Thu_Bay").ToString.Trim
        M_Chu_Nhat = Dt_Ngay_Tien_Do.Rows(0).Item("Chu_Nhat").ToString.Trim

        M_StartHour = Dt_Ngay_Tien_Do.Rows(0).Item("StartHour")
        M_FinishHour = Dt_Ngay_Tien_Do.Rows(0).Item("FinishHour")
        M_StartMINUTE = Dt_Ngay_Tien_Do.Rows(0).Item("StartMINUTE")
        M_FinishMINUTE = Dt_Ngay_Tien_Do.Rows(0).Item("FinishMINUTE")
        M_Ngay_LimitInterval_Min = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_LimitInterval_Min")
        M_Ngay_LimitInterval_Max = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_LimitInterval_Max")

        TxtM_Ngay_Ct.Value = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Ct")
    End Sub
    Private Sub V_Ngay_Ct_Tien_Do(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ngay_Ct_Tien_Do()
        'V_LoadData_Tien_Do("0", "")
        'V_LoadData_Tien_Do_Xe("0", "")
        'V_Tinh_So_XE()
    End Sub

    Private Sub FCVDV_Xem_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub
#End Region
#Region "Scheduler"
    Private Sub V_CyberSetTime_Tien_Do()
    End Sub
    Private Sub V_SetSchedulerControl()
        '------------------------------------------------------------------------
    End Sub
    Private Sub V_SetSchedulerSetValue()
    End Sub
    Private Sub V_SetColorAppointments()
        For i = 0 To Dt_ConFigColor.Rows.Count - 1
            V_SetColorlabel(i, Dt_ConFigColor.Rows(i))
        Next
    End Sub
    Private Sub V_SetColorlabel(ByVal _i As Integer, ByVal _Dr As DataRow)

    End Sub
#End Region
#Region "Hander"
    Private Sub V_AddHander_Tien_Do()
        '---------------------------------------------------------------------------------------------------------------------------------------------------------

        AddHandler CbbCVDV.SelectedIndexChanged, AddressOf V_Filter
        AddHandler TxtMa_Xe_KH_SCC.TextChanged, AddressOf V_Filter
        AddHandler TxtM_Ngay_Ct.TextChanged, AddressOf V_Ngay_Ct_Tien_Do
        '  AddHandler Timer_PercentComplete.Tick, AddressOf V_Timer_PercentComplete
        ''-------Cho KH
        AddHandler DGV_CHOGRV.RowCellStyle, AddressOf DGV_CHOGRV_RowCellStyle
        AddHandler DGV_CHOGRV.PopupMenuShowing, AddressOf DGV_CHOGRV_PopupMenuShowing
    End Sub
    Private Sub V_PopupMenu(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs)
        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        e.Menu.Items.Clear()
        Dim rowHandle As Integer = 0
        PopupMenuSchedulerControl.ItemLinks.Clear()
        '-----------------------------------------------
        'PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_RefreshData, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        ''-----------------------------------------------
        'PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem danh sách xe sữa chữa", "Preview"), AddressOf V_GanttGiaoXE, Nothing, My.Resources.Preview_16_IN, True, True), True).BeginGroup = True

        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), True).BeginGroup = True
        If Not e Is Nothing Then PopupMenuSchedulerControl.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_Filter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Filter()
    End Sub
    Private Sub V_Filter()
        '----------------------------------------------------------------------------------------
        Dim _Filter As String = ""
        _Filter = V_GetFilter_KHSC(Dt_DmCVDV)
        Set_Filter(Dv_DmCVDV, _Filter)
        _Filter = ""

        _Filter = V_GetFilter_KHSC(Dt_Data)
        Set_Filter(Dv_Data, _Filter)
        '----------------------------------------------------------------------------------------
        'V_Tinh_So_XE()
    End Sub
    Private Sub Set_Filter(ByVal _dv As DataView, ByVal _StrFilter As String)
        If Not _dv Is Nothing Then
            Try
                _dv.RowFilter = _StrFilter
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Function V_GetFilter_KHSC(ByVal _DT_Filter As DataTable) As String
        If _DT_Filter Is Nothing Then Return ""
        Dim _StrFilter As String = "1=1"
        Dim _Ma_Hs As String = CyberWork.V_GetvalueCombox(CbbCVDV)
        Dim _Ma_Xe As String = TxtMa_Xe_KH_SCC.Text.Trim
        If _Ma_Hs.Trim <> "" And _DT_Filter.Columns.Contains("Ma_HS") Then _StrFilter = _StrFilter + " AND Ma_Hs = '" + _Ma_Hs + "'"
        If _Ma_Hs.Trim <> "" And _DT_Filter.Columns.Contains("Ma_CVDV") Then _StrFilter = _StrFilter + " AND Ma_CVDV = '" + _Ma_Hs + "'"
        If _Ma_Xe.Trim <> "" And _DT_Filter.Columns.Contains("Ma_Ma_Xe") Then _StrFilter = _StrFilter + " AND Ma_Xe LIKE '%" + _Ma_Xe.Trim + "%'"
        Return _StrFilter
    End Function
#End Region
    '#End Region
#Region "Event Chờ sửa chữa -  Tien do"
    Dim _keotha2Grid As New GridviewDragDrop
    Private Sub DGV_CHOGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DGV_CHOGRV, Dt_Cho, Me.Font)
    End Sub

    Private Sub DGV_CHOGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuChoGRV.ItemLinks.Clear()
        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, "Cập nhật thông tin xe vào cổng", AddressOf V_Update_Xe_RVR, Nothing, My.Resources.edit_16x16, True, True)).BeginGroup = False

        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, 0, "Làm tươi dữ liệu", AddressOf V_Refresh_CHO, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        Dim MenuExits As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenuChoGRV.ItemLinks.Add(MenuExits, True)
        PopupMenuChoGRV.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuChoGRV.ShowPopup(Control.MousePosition)
        'End If
    End Sub
    Private Sub V_Update_Xe_RVR(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DGV_CHOGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Cho.Item(iRow)
        If _Drv Is Nothing Then Exit Sub
        Dim _Stt_Rec As String = ""
        Dim _Ma_Xe As String = ""
        If Dt_Cho.Columns.Contains("Stt_Rec") Then _Stt_Rec = _Drv.Item("Stt_Rec")
        If Dt_Cho.Columns.Contains("Ma_Xe") Then _Ma_Xe = _Drv.Item("Ma_Xe")

        If _Stt_Rec.Trim = "" Then Exit Sub
        If _Ma_Xe.Trim = "" Then Exit Sub
        Dim _Return As Boolean = CyberWork.V_Tiep_Don_Update_Xe_RVR(_Stt_Rec, _Ma_Xe, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        If _Return Then V_LoadData_Tien_Do_Xe("0", "")
    End Sub
#End Region
End Class
