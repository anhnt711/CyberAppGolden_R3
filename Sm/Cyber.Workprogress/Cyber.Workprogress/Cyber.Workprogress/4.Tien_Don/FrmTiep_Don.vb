Imports DevExpress.XtraScheduler
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Windows.Forms
Public Class FrmTiep_Don
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
        Me.Text = "PHÂN VIỆC"
        TxtM_Ngay_Ct.Value = Now.Date
        '------------------------------------------------------------------------------------------------------
        Tao_Ngam_Dinh()
        '------------------------------------------------------------------------------------------------------
        CyberSupport.V_SetTree(ResourcesTree)
        '------------------------------------------------------------------------------------------------------
        CyberSupport.V_LoadTimeLine(SchedulerControl)
        '------------------------------------------------------------------------------------------------------
        V_Ngay_Ct_Tien_Do()
        '------------------------------------------------------------------------------------------------------
        V_CyberSetTime_Tien_Do()
        '------------------------------------------------------------------------------------------------------
        V_LoadData_Tien_Do("1", "")
        V_LoadData_Tien_Do_Xe("1", "")
        '------------------------------------------------------------------------------------------------------
        V_SetSchedulerControl()
        '------------------------------------------------------------------------------------------------------
        V_Auto_Data_Tien_Do(New System.Object, New System.EventArgs)
        '------------------------------------------------------------------------------------------------------
        V_AddHander_Tien_Do()
        '------------------------------------------------------------------------------------------------------
        V_Tinh_So_XE()
        '------------------------------------------------------------------------------------------------------
        V_Do_Rong(New System.Object, New System.EventArgs) 'Độ rộng của cột
        '--------------------------------------------------------------------------------------------
        V_SetRowHeight() ' RowPage trong bảng tiến độ
        '--------------------------------------------------------------------------------------------
        V_SetAppointmentHeight() ' Độ cao của chíp
        '------------------------------------------------------------------------------------------------------
        If Dt_Data.Columns.Contains("PercentComplete") And Dt_Ngay_Tien_Do.Columns.Contains("Tg_PercentComplete") Then
            Timer_PercentComplete.Interval = Dt_Ngay_Tien_Do.Rows(0).Item("Tg_PercentComplete")
            Timer_PercentComplete.Enabled = True
            V_PercentComplete("")
        End If
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
        SchedulerControl.BeginUpdate()
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
        V_PercentComplete(_Stt_Rec)

        SchedulerControl.EndUpdate()
        SchedulerControl.Storage.RefreshData()

        SchedulerStorage.Appointments.AutoReload = True

        V_Tinh_So_XE()

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
    Private Sub V_RefreshData(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_Tien_Do("0", "")
    End Sub
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

        SchedulerControl.LimitInterval.Start = M_Ngay_LimitInterval_Min
        SchedulerControl.LimitInterval.End = M_Ngay_LimitInterval_Max
        SchedulerControl.Start = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Ct")
        TxtM_Ngay_Ct.Value = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Ct")
    End Sub
    Private Sub V_Ngay_Ct_Tien_Do(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ngay_Ct_Tien_Do()
        V_LoadData_Tien_Do("0", "")
        V_LoadData_Tien_Do_Xe("0", "")
        'V_Tinh_So_XE()
    End Sub

    Private Sub FCVDV_Xem_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_SetRowHeight()
    End Sub
#End Region

#Region "Scheduler"
    Private Sub V_CyberSetTime_Tien_Do()
        CyberSupport.V_CyberSetTime_Tien_Do(SchedulerControl, CyberWork.V_GetvalueCombox(CbbMa_BN), M_StartHour, M_StartMINUTE, M_FinishHour, M_FinishMINUTE, M_Ngay_LimitInterval_Min, M_Ngay_LimitInterval_Max, M_Thu_Bay, M_Chu_Nhat)
    End Sub
    Private Sub V_SetSchedulerControl()
        SchedulerControl.DateNavigationBar.Visible = False
        '------------------------------------------------------------------------
        SchedulerControl.ActiveViewType = SchedulerViewType.Gantt
        SchedulerControl.Views.GanttView.Scales(6).Width = Dt_Ngay_Tien_Do.Rows(0).Item("HourWidth")
        SchedulerControl.Views.GanttView.ResourcesPerPage = Dt_Ngay_Tien_Do.Rows(0).Item("RowPage")
        '------------------------------------------------------------------------
        SchedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
        '------------------------------------------------------------------------
        V_SetSchedulerSetValue()
        '------------------------------------------------------------------------
        V_SetColorAppointments()
        '------------------------------------------------------------------------
        If Dt_Data.Columns.Contains("Color") Then SchedulerStorage.Resources.Mappings.Color = Dt_Data.Columns("Color").ColumnName.ToString.Trim
        If Dt_Data.Columns.Contains("Image") Then SchedulerStorage.Resources.Mappings.Image = Dt_Data.Columns("Image").ColumnName.ToString.Trim
        '------------------------------------------------------------------------
        Me.SchedulerStorage.Appointments.DataSource = Dv_Data
        Me.SchedulerStorage.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerStorage.Appointments.Mappings.AppointmentId = Dt_Data.Columns("Stt_Rec").ColumnName


        If Dt_Data.Columns.Contains("Dien_Giai") Then Me.SchedulerStorage.Appointments.Mappings.Description = Dt_Data.Columns("Dien_Giai").ColumnName
        Me.SchedulerStorage.Appointments.Mappings.Start = Dt_Data.Columns("Ngay_BD").ColumnName
        Me.SchedulerStorage.Appointments.Mappings.End = Dt_Data.Columns("Ngay_KT").ColumnName

        Me.SchedulerControl.Views.GanttView.AppointmentDisplayOptions.AutoAdjustForeColor = False

        If Dt_Data.Columns.Contains("Size_Border") Then Me.SchedulerStorage.Appointments.Mappings.Status = Dt_Data.Columns("Size_Border").ColumnName
        If Dt_Data.Columns.Contains("PercentComplete") Then Me.SchedulerStorage.Appointments.Mappings.PercentComplete = Dt_Data.Columns("PercentComplete").ColumnName Else SchedulerControl.Views.GanttView.AppointmentDisplayOptions.PercentCompleteDisplayType = PercentCompleteDisplayType.None
        If Dt_Data.Columns.Contains("Type") Then Me.SchedulerStorage.Appointments.Mappings.Type = Dt_Data.Columns("Type").ColumnName

        '------------------------------------------------------------------------
        SchedulerControl.OptionsView.ToolTipVisibility = ToolTipVisibility.Always
        SchedulerControl.GanttView.Appearance.Appointment.ForeColor = System.Drawing.Color.White
        SchedulerControl.GanttView.Appearance.Appointment.Font = New Font(SchedulerControl.DayView.Appearance.Appointment.Font.FontFamily, 10)
        '------------------------------------------------------------------------
        SchedulerControl.Views.GanttView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Never
        SchedulerControl.Views.GanttView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Never
        SchedulerControl.Views.GanttView.AppointmentDisplayOptions.SnapToCellsMode = AppointmentSnapToCellsMode.Disabled
        '------------------------------------------------------------------------
    End Sub
    Private Sub V_SetSchedulerSetValue()
        CyberSupport.V_SetScheduler(Dv_Data, Dv_Data_Parent, Dv_DmCVDV, "Ma_Cvdv", "Ten_CVDV", "Ma_Xe", 120, SchedulerControl, ResourcesTree, Nothing)
        If ResourcesTree.Visible Then SplitContainer_Tien_Do.SplitterDistance = 200 Else SplitContainer_Tien_Do.SplitterDistance = 0
    End Sub
    Private Sub V_SetColorAppointments()
        For i = 0 To Dt_ConFigColor.Rows.Count - 1
            V_SetColorlabel(i, Dt_ConFigColor.Rows(i))
        Next
    End Sub
    Private Sub V_SetColorlabel(ByVal _i As Integer, ByVal _Dr As DataRow)

    End Sub
#End Region
#Region "----------Sự kiện - SchedulerControl"
    Private Sub V_CustomDrawTimeCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs)
        CyberSupport.V_CustomDrawTimeCell(sender, e, SchedulerControl, M_FinishHour, CyberColor)
    End Sub
    Private Sub scheduler_CustomDrawResourceHeader(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs)
        CyberSupport.Scheduler_CustomDrawResourceHeader(sender, e, CyberColor, My.Resources.flag1, My.Resources.flag2, My.Resources.flag3, My.Resources.flag4, My.Resources.flag5, My.Resources.flag6)
    End Sub

    Private Sub SchedulerControl_InitAppointmentImages(ByVal sender As Object, ByVal e As AppointmentImagesEventArgs)
        CyberSupport.SchedulerControl_InitAppointmentImages(sender, e, CyberColor, My.Resources.flag1, My.Resources.flag2, My.Resources.flag3, My.Resources.flag4, My.Resources.flag5, My.Resources.flag6)
    End Sub

    Private Sub SchedulerControl_CustomDrawAppointmentBackground(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs)
        CyberSupport.SchedulerControl_CustomDrawAppointmentBackground(sender, e, CyberColor)
    End Sub

    Private Sub V_AppointmentViewInfoCustomizing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentViewInfoCustomizingEventArgs)
        CyberSupport.V_AppointmentViewInfoCustomizing(sender, e, Me.Font, CyberColor)
    End Sub

#End Region

#Region "Hander"
    Private Sub V_AddHander_Tien_Do()
        '------------------------------------------------------------------------------------------------------------------------------------------------------------
        AddHandler SchedulerControl.CustomDrawTimeIndicator, AddressOf CyberSupport.SchedulerControl_CustomDrawTimeIndicator '--Đường thời gian chạy (Màu đỏ)
        AddHandler SchedulerControl.CustomDrawTimeCell, AddressOf V_CustomDrawTimeCell ' --Đường xanh khoảng giữa các giờ chặn + màu của dòng trên bảng tiến độ
        AddHandler SchedulerControl.CustomDrawDayHeader, AddressOf CyberSupport.schedulerControl_CustomDrawDayHeader ' --Bôi màu Head ngày trên cùng: VD 16-03
        AddHandler SchedulerControl.CustomDrawResourceHeader, AddressOf scheduler_CustomDrawResourceHeader ' --Set Màu, cờ, Chữ (Bold,Italic,Underline) của Head dòng : VD Tên Khoang)
        AddHandler SchedulerControl.InitAppointmentImages, AddressOf SchedulerControl_InitAppointmentImages 'Cờ trên chíp
        AddHandler SchedulerControl.CustomDrawAppointmentBackground, AddressOf SchedulerControl_CustomDrawAppointmentBackground '---Border chíp
        AddHandler SchedulerControl.AppointmentViewInfoCustomizing, AddressOf V_AppointmentViewInfoCustomizing '---backColor/ForeColor tren chíp

        '-------------keo tha - chuyen khoang
        AddHandler SchedulerControl.AppointmentDrop, AddressOf V_SchedulerControl_AppointmentDrop
        AddHandler SchedulerControl.AppointmentResized, AddressOf V_SchedulerControl_AppointmentResized
        '------------------------------------------------------------------------------------------------------------------------------------------------------------

        AddHandler SchedulerControl.PopupMenuShowing, AddressOf V_PopupMenu
        AddHandler SchedulerControl.EditAppointmentFormShowing, AddressOf CyberWork.V_Lap_F3F4
        AddHandler SchedulerControl.DoubleClick, AddressOf V_Sua_Dat_Cho

        AddHandler CbbCVDV.SelectedIndexChanged, AddressOf V_Filter
        AddHandler TxtMa_Xe_KH_SCC.TextChanged, AddressOf V_Filter
        AddHandler TxtM_Ngay_Ct.TextChanged, AddressOf V_Ngay_Ct_Tien_Do
        AddHandler ChkAuto_Data.CheckedChanged, AddressOf V_Auto_Data_Tien_Do
        AddHandler CbbTime_Data.SelectedValueChanged, AddressOf V_Auto_Data_Tien_Do
        AddHandler CbbMa_BN.SelectedValueChanged, AddressOf V_Buoc_Nhay
        AddHandler CbbDo_Rong.SelectedValueChanged, AddressOf V_Do_Rong

        AddHandler Timer_Data.Tick, AddressOf V_Timer_Data
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

        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Giải phóng", "Release"), AddressOf V_Giai_phong, Nothing, Nothing, True, True)).BeginGroup = True
        '-----------------------------------------------
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo đặt chỗ", "Make a reservation"), AddressOf V_Dat_Cho, Nothing, My.Resources.apply_16x16, True, True)).BeginGroup = True
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Sửa kế hoạch", "Modify the plan"), AddressOf V_Sua_Dat_Cho, Nothing, My.Resources.edit_16x16, True, True)).BeginGroup = False
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa đặt chỗ", "Delete appointment"), AddressOf V_Xoa_Dat_Cho, Nothing, My.Resources.deletelist_16x16, True, True)).BeginGroup = False
        '-----------------------------------------------
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_RefreshData, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        ''-----------------------------------------------
        'PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem danh sách xe sữa chữa", "Preview"), AddressOf V_GanttGiaoXE, Nothing, My.Resources.Preview_16_IN, True, True), True).BeginGroup = True

        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), True).BeginGroup = True
        If Not e Is Nothing Then PopupMenuSchedulerControl.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_Buoc_Nhay(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_CyberSetTime_Tien_Do()
        V_Do_Rong(sender, e)
    End Sub
    Private Sub V_Do_Rong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i = 0 To 6
            If SchedulerControl.GanttView.Scales(i).Visible Then SchedulerControl.Views.GanttView.Scales(i).Width = CbbDo_Rong.SelectedValue()
        Next
        If SchedulerControl.ActiveViewType = SchedulerViewType.Day Then SchedulerControl.DayView.RowHeight = CyberWork.V_GetvalueCombox(CbbDo_Rong)
    End Sub
    Private Sub V_SetAppointmentHeight()
        Dim _AppointmentHeight As Integer = 20
        CyberSupport.V_SetAppointmentHeight(SchedulerControl, _AppointmentHeight, Sysvar)
    End Sub
    Private Sub V_SetRowHeight()
        Dim _RowHeight As Decimal = 0
        Dim _RowPage As Decimal = 0
        If Dt_Ngay_Tien_Do Is Nothing Then Return
        If Dt_Ngay_Tien_Do.Rows.Count = 0 Then Return
        If Dt_Ngay_Tien_Do.Columns.Contains("RowHeight") Then _RowHeight = Dt_Ngay_Tien_Do.Rows(0).Item("RowHeight")
        If Dt_Ngay_Tien_Do.Columns.Contains("RowPage") Then _RowPage = Dt_Ngay_Tien_Do.Rows(0).Item("RowPage")
        If _RowHeight = 0 Or _RowPage = 0 Then Return
        CyberSupport.V_SetRowHeight(SchedulerControl, _RowHeight, _RowPage, Sysvar)
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

#Region "Đặt chỗ"
    Private Sub V_Giai_phong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        '------------------------------------------------------------------------
        If _Stt_Rec.Trim = "" Then Exit Sub
        If Not CyberWork.V_Msgbox_Delete(Me.Sysvar, "Bạn có giải phóng khỏi bảng này không ?") Then Exit Sub
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_DELETE", "1#" + _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        DsTmp.Dispose()
        V_LoadData_Tien_Do("0", _Stt_Rec)
    End Sub
    Dim M_Ma_Ct_PDC As String = "DTD"
    Private Sub V_Dat_Cho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        Dim _Ma_CVDV As String = SchedulerControl.SelectedResource.Id.ToString.Trim
        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End
        V_Tao_Moi_Sua_Dat_Cho("M", M_Ma_Ct_PDC, _Stt_Rec, _Ngay_Bd, _Ngay_Kt, _Ma_CVDV)
    End Sub
    Private Sub V_Sua_Dat_Cho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Mode As String = "S"
        Dim _Save As String = "0"
        Dim _Stt_Rec As String = ""

        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Exit Sub

        Dim _Ma_CVDV As String = SchedulerControl.SelectedResource.Id.ToString.Trim
        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End
        V_Tao_Moi_Sua_Dat_Cho(_Mode, M_Ma_Ct_PDC, _Stt_Rec, _Ngay_Bd, _Ngay_Kt, _Ma_CVDV)

    End Sub
    Private Sub V_Tao_Moi_Sua_Dat_Cho(ByVal _Mode As String, ByVal _Ma_CT As String, ByVal _Stt_Rec As String, ByVal _Ngay_Bd As Date, ByVal _Ngay_KT As Date, ByVal _Ma_CVDV As String)
        Dim _Dr_Return As DataRow = Nothing
        _Stt_Rec = _Stt_Rec.Trim
        If _Mode = "M" Then _Stt_Rec = ""
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_Dat_Cho", _Mode & "#" & _Ma_CT & "#" & _Stt_Rec + "#" & _Ngay_Bd.ToString("yyyyMMdd HH:mm") + "#" & _Ngay_KT.ToString("yyyyMMdd HH:mm") & "#" & _Ma_CVDV & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsTmp.Tables.Count > 0 Then
            If DsTmp.Tables(0).Rows.Count > 0 Then _Dr_Return = DsTmp.Tables(0).Rows(0)
        End If
        DsTmp.Dispose()
        If _Dr_Return Is Nothing Then Exit Sub
        '---------------------------------------------------------------------------------
        _Stt_Rec = _Dr_Return.Item("Stt_Rec")
        Dim Frm As New FrmTiep_Don_Dat_Cho
        Frm.M_DmUT = M_DmUT
        Frm.M_DmCvdv = Dt_DmCVDV
        Frm.M_Ma_CT = _Ma_CT
        Frm.TxtStt_Rec.Text = _Stt_Rec
        Frm.Dr_Return = _Dr_Return
        Frm.M_Mode = _Mode
        '------------------------------------------------------
        Frm.Para = Me.Para
        Frm.Sysvar = Me.Sysvar
        Frm.AppConn = Me.AppConn
        Frm.CyberSmlib = Me.CyberSmlib
        Frm.CyberSupport = Me.CyberSupport
        Frm.CyberFill = Me.CyberFill
        Frm.CyberSmlistSys = Me.CyberSmlistSys
        Frm.CyberSmodb = Me.CyberSmodb
        Frm.CyberExport = Me.CyberExport
        Frm.CyberVoucher = Me.CyberVoucher
        Frm.CyberLoading = Me.CyberLoading
        Frm.Key_Sub2 = Me.Key_Sub2
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        If Not Frm.Save_OK Then Exit Sub
        V_LoadData_Tien_Do("0", _Stt_Rec)
        V_LoadData_Tien_Do_Xe("0", _Stt_Rec)

    End Sub
    Private Sub V_Xoa_Dat_Cho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        '------------------------------------------------------------------------
        If _Stt_Rec.Trim = "" Then Exit Sub
        If Not CyberWork.V_Msgbox_Delete(Me.Sysvar, "Bạn có muốn xóa không") Then Exit Sub
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_DELETE", "2#" + _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        V_LoadData_Tien_Do("0", _Stt_Rec)
        V_LoadData_Tien_Do_Xe("0", _Stt_Rec)
    End Sub
#End Region
#Region "Timer"
    Private Sub V_Timer_Data_Change(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _TimeData As Decimal = CbbTime_Data.SelectedValue
        If _TimeData <= 0 Then _TimeData = 3000
        Timer_Data.Interval = _TimeData
    End Sub
    Private Sub V_Auto_Data_Tien_Do(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer_Data.Enabled = ChkAuto_Data.Checked
        CbbTime_Data.Enabled = ChkAuto_Data.Checked
        Dim _TimeData As Decimal = CbbTime_Data.SelectedValue
        If _TimeData <= 0 Then _TimeData = 3000
        Timer_Data.Interval = _TimeData
    End Sub
    Private Sub V_Timer_Data(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Timer_Data.Enabled Then Exit Sub
        V_LoadData_Tien_Do("0", "")
        V_LoadData_Tien_Do_Xe("0", "")
    End Sub
    Private Sub V_Timer_PercentComplete(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Timer_PercentComplete.Enabled Then Exit Sub
        V_PercentComplete("")
    End Sub
    Private Sub V_PercentComplete(Optional ByVal _Stt_rec As String = "")
        If Not Dt_Timer_Data.Columns.Contains("PercentComplete") Then Exit Sub
        If Not Dt_Data.Columns.Contains("Ngay_BD") Then Exit Sub
        If Not Dt_Timer_Data.Columns.Contains("Ngay_KT") Then Exit Sub

        _Stt_rec = _Stt_rec.Trim.ToUpper
        Dim _ChkRec As Boolean = True

        Dim PercentComplete As Decimal = 0
        If _Stt_rec = "" Then _ChkRec = False

        If Not Dt_Data.Columns.Contains("Stt_Rec") Then _ChkRec = False
        Dim _Ngay_HT As DateTime = Now
        SchedulerStorage.Appointments.AutoReload = False
        For i = 0 To Dt_Data.Rows.Count - 1
            If _ChkRec Then
                If Dt_Data.Rows(i).Item("Stt_Rec").ToString.Trim.ToUpper = _Stt_rec Then
                    Dt_Data.Rows(i).BeginEdit()
                    Dt_Data.Rows(i).Item("PercentComplete") = CyberWork.V_PercentComplete(Dt_Data.Rows(i).Item("Ngay_BD"), Dt_Data.Rows(i).Item("Ngay_KT"), _Ngay_HT, CyberSupport)
                    Dt_Data.Rows(i).EndEdit()
                End If
            End If
        Next

        SchedulerControl.Storage.RefreshData()
        SchedulerStorage.Appointments.AutoReload = True
    End Sub
#End Region
    '#End Region
#Region "Tạo mới - Sửa - xóa: kế hoạch"
    Private Sub V_Tao_KH(ByVal _Ma_CVDV As String, ByVal _Dr As DataRow, ByVal _Ngay1 As Date, ByVal _Ngay2 As Date)
        If _Dr Is Nothing Then Exit Sub
        Dim _Mode As String = "M"
        Dim _Save As String = "1"

        Dim _Ngay_Bd As Date = New Date(1900, 1, 1)
        Dim _Ngay_KT As Date = New Date(1900, 1, 1)
        'Dim _Stt_rec As String = CyberProgress.V_GetStt_RecSCC(M_Ma_Ct_PKH, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)

        Dim _Stt_Rec As String = _Dr.Item("Stt_Rec").ToString.Trim
        Dim _Ma_Ct As String = _Dr.Item("Ma_Ct").ToString.Trim
        Dim _Ma_Xe As String = _Dr.Item("Ma_Xe").ToString.Trim
        V_Lap_KH(_Mode, _Save, _Ma_Ct, _Stt_Rec, _Ma_Xe, _Ma_CVDV, _Ngay1, _Ngay2)
    End Sub
    Private Sub V_Tao_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DGV_CHOGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Cho.Item(iRow)
        If _Drv Is Nothing Then Exit Sub
        Dim _Mode As String = "M"
        Dim _Save As String = "0"

        Dim _Stt_Rec As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Ma_CVDV As String = ""
        Dim _Ma_Xe As String = ""

        If Dt_Cho.Columns.Contains("Stt_Rec") Then _Stt_Rec = _Drv.Item("Stt_Rec")
        If Dt_Cho.Columns.Contains("Ma_Ct") Then _Ma_Ct = _Drv.Item("Ma_Ct")
        If Dt_Cho.Columns.Contains("Ma_Xe") Then _Ma_Xe = _Drv.Item("Ma_Xe")
        If Dt_Cho.Columns.Contains("Ma_CVDV") Then _Ma_CVDV = _Drv.Item("Ma_Cvdv")

        If _Stt_Rec.Trim = "" Then Exit Sub
        If _Ma_Xe.Trim = "" Then Exit Sub
        If _Ma_Ct.Trim = "" Then Exit Sub

        Dim _Ngay_Bd As Date = New Date(1900, 1, 1)
        Dim _Ngay_KT As Date = New Date(1900, 1, 1)
        V_Lap_KH(_Mode, _Save, _Ma_Ct, _Stt_Rec, _Ma_Xe, _Ma_CVDV, _Ngay_Bd, _Ngay_KT)
    End Sub
    Private Sub V_Lap_KH(ByVal _Mode As String, ByVal _Save As String, ByVal _ma_Ct As String, ByVal _Stt_Rec As String, ByVal _Ma_Xe As String, ByVal _Ma_CVDV As String, ByVal _Ngay_Bd As Date, ByVal _Ngay_KT As Date)
        '_Save: '1'	---0: Lap KH, --1: Keo tu Xe cho KH sang (Luu Luon), 2--- Copy Ke Hoach
        Dim _Ngay_CT As Date = TxtM_Ngay_Ct.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_Load_KH", _Save & "#" & _Mode & "#" & _ma_Ct & "#" & _Stt_Rec & "#" & _Ma_Xe & "#" & _Ma_CVDV & "#" & _Ngay_Bd.ToString("yyyyMMdd HH:mm") & "#" & _Ngay_KT.ToString("yyyyMMdd HH:mm") & "#" & _Ngay_CT.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsTmp.Tables.Count <= 1 Then
            DsTmp.Dispose()
            Exit Sub
        End If

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        If DsTmp.Tables(1).Rows.Count = 0 Then
            DsTmp.Dispose()
            Exit Sub
        End If

        Dim _Dr_Return As DataRow = DsTmp.Tables(1).Copy.Rows(0)

        If _Save.ToString = "1" Then
            V_LoadData_Tien_Do("0", _Stt_Rec)
            V_LoadData_Tien_Do_Xe("0", _Stt_Rec)
            Return
        End If

        Dim Frm As New FrmTiep_Don_Dat_Cho
        Frm.M_DmUT = M_DmUT
        Frm.M_DmCvdv = Dt_DmCVDV
        Frm.M_Ma_CT = _ma_Ct
        Frm.TxtStt_Rec.Text = _Stt_Rec
        Frm.Dr_Return = _Dr_Return
        Frm.M_Mode = _Mode
        '------------------------------------------------------
        Frm.Para = Me.Para
        Frm.Sysvar = Me.Sysvar
        Frm.AppConn = Me.AppConn
        Frm.CyberSmlib = Me.CyberSmlib
        Frm.CyberSupport = Me.CyberSupport
        Frm.CyberFill = Me.CyberFill
        Frm.CyberSmlistSys = Me.CyberSmlistSys
        Frm.CyberSmodb = Me.CyberSmodb
        Frm.CyberExport = Me.CyberExport
        Frm.CyberVoucher = Me.CyberVoucher
        Frm.CyberLoading = Me.CyberLoading
        Frm.Key_Sub2 = Me.Key_Sub2
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        If Not Frm.Save_OK Then Exit Sub
        _Dr_Return = Frm.Dr_Return
        ''---------------------------------------------------------------------------------
        V_LoadData_Tien_Do("0", _Stt_Rec)
        V_LoadData_Tien_Do_Xe("0", _Stt_Rec)
    End Sub
    Private Sub V_Tinh_So_XE()
        Dim _So_Xe_Dat As Decimal = 0
        Dim _So_Xe_Cho As Decimal = 0
        Dim _Ma_Ct As String = ""

        For i As Integer = 0 To Dv_Data.Count - 1
            _Ma_Ct = Dv_Data.Item(i).Item("Ma_Ct").ToString.Trim.ToUpper
            Select Case _Ma_Ct
                Case M_Ma_Ct_PDC.ToUpper.Trim
                    _So_Xe_Dat = _So_Xe_Dat + 1

                Case Else
                    _So_Xe_Cho = _So_Xe_Cho + 1

            End Select
        Next
        LabSo_Xe_Cho.Text = _So_Xe_Cho
        LabSo_Xe_Dat.Text = _So_Xe_Dat
    End Sub
#End Region
#Region "Event Chờ sửa chữa -  Tien do"
    Dim _keotha2Grid As New GridviewDragDrop
    Private Sub V_DragDropGridview()
        _keotha2Grid = New GridviewDragDrop(DGV_CHO, SchedulerControl)
        AddHandler SchedulerControl.DragDrop, AddressOf Master1_DragDrop
    End Sub
    Private Sub Master1_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
        Dim _SchedulerControl As New SchedulerControl
        _SchedulerControl = sender
        'Dim _Dr_CHO As DataRow = TryCast(e.Data.GetData(GetType(DataRow)), DataRow)
        Dim _Dr_CHO As DataRow = TryCast(e.Data.GetData(GetType(DataRow)), DataRow)
        If _Dr_CHO Is Nothing Then Exit Sub
        Dim pt As Point = _SchedulerControl.PointToClient(New Point(e.X, e.Y))
        Dim hitInfo As DevExpress.XtraScheduler.Drawing.SchedulerHitInfo = SchedulerControl.ActiveView.ViewInfo.CalcHitInfo(pt, True)
        If hitInfo.HitTest = DevExpress.XtraScheduler.Drawing.SchedulerHitTest.Cell Then
            Dim cell As DevExpress.XtraScheduler.Drawing.SelectableIntervalViewInfo = hitInfo.ViewInfo
            Dim apt As Appointment = SchedulerStorage.CreateAppointment(AppointmentType.Normal, cell.Interval.Start, TimeSpan.FromHours(4))
            Dim _Ma_CVDV As String = cell.Resource.Id

            Dim _Ngay1 As Date = SchedulerControl.SelectedInterval.Start
            Dim _Ngay2 As Date = SchedulerControl.SelectedInterval.End
            V_Tao_KH(_Ma_CVDV, _Dr_CHO, _Ngay1, _Ngay2)
        End If
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub DGV_CHOGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DGV_CHOGRV, Dt_Cho, Me.Font)
    End Sub

    Private Sub DGV_CHOGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuChoGRV.ItemLinks.Clear()
        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, "Tạo kế hoạch", AddressOf V_Tao_KH, Nothing, My.Resources.apply_16x16, True, True)).BeginGroup = False
        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, "Giải phóng xe", AddressOf V_Giai_Phong_Xe, Nothing, My.Resources.deletelist_16x16, True, True)).BeginGroup = False
        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, "Cập nhật thông tin xe vào cổng", AddressOf V_Update_Xe_RVR, Nothing, My.Resources.edit_16x16, True, True)).BeginGroup = False

        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, 0, "Làm tươi dữ liệu", AddressOf V_Refresh_CHO, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        Dim MenuExits As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenuChoGRV.ItemLinks.Add(MenuExits, True)
        PopupMenuChoGRV.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuChoGRV.ShowPopup(Control.MousePosition)
        'End If
    End Sub
    Private Sub V_Giai_Phong_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DGV_CHOGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Cho.Item(iRow)
        If _Drv Is Nothing Then Exit Sub

        Dim _Stt_Rec As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Ma_Xe As String = ""

        If Dt_Cho.Columns.Contains("Stt_Rec") Then _Stt_Rec = _Drv.Item("Stt_Rec")
        If Dt_Cho.Columns.Contains("Ma_Ct") Then _Ma_Ct = _Drv.Item("Ma_Ct")
        If Dt_Cho.Columns.Contains("Ma_Xe") Then _Ma_Xe = _Drv.Item("Ma_Xe")

        If _Stt_Rec.Trim = "" Then Exit Sub
        If _Ma_Xe.Trim = "" Then Exit Sub
        If _Ma_Ct.Trim = "" Then Exit Sub

        If MsgBox("Bạn có chắc chắn giải phóng xe này không?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Sysvar("M_CYBER_VER")) = MsgBoxResult.Cancel Then Return
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_GiaiPhong_Xe", _Ma_Ct.Trim & "#" & _Stt_Rec.Trim & "#" & _Ma_Xe.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Return
        End If

        DsTmp.Dispose()
        V_LoadData_Tien_Do("", _Stt_Rec)
        V_LoadData_Tien_Do_Xe("0", _Stt_Rec)
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
        If _Return Then V_LoadData_Tien_Do_Xe("0", _Stt_Rec)
    End Sub
#End Region

#Region "Keo tha - thay doi thoi gian va chuyen khoang"
    Private Function V_Update_Keo_Tha(ByVal _Appointment As Appointment) As Boolean
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then
            Try
                _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
            Catch ex As Exception
            End Try
        End If

        If _Stt_Rec.ToString.Trim = "" Then Return False

        Dim _Ma_CVDV As String = _Appointment.ResourceId.ToString
        Dim _Ma_Khoang1 As String = SchedulerControl.SelectedResource.Id.ToString.Trim
        Dim _Ngay_Bd As Date = _Appointment.Start ' SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = _Appointment.End '  SchedulerControl.SelectedInterval.End
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_Save", _Stt_Rec + "#" + _Ma_CVDV + "#" + _Ngay_Bd.ToString("yyyyMMdd HH:mm") + "#" + _Ngay_Kt.ToString("yyyyMMdd HH:mm") + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN)
        DsTmp.Dispose()
        If _Return Then V_PercentComplete(_Stt_Rec)
        Return _Return
    End Function
    Private Sub V_SchedulerControl_AppointmentDrop(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentDragEventArgs)
        Dim _Appointment As Appointment
        _Appointment = e.EditedAppointment
        Dim _Return As Boolean = V_Update_Keo_Tha(_Appointment)
        e.Allow = _Return
    End Sub
    Private Sub V_SchedulerControl_AppointmentResized(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentResizeEventArgs)
        Dim _Appointment As Appointment
        _Appointment = e.EditedAppointment
        Dim _Return As Boolean = V_Update_Keo_Tha(_Appointment)
        e.Allow = _Return
        e.Handled = Not _Return
    End Sub
#End Region
End Class
