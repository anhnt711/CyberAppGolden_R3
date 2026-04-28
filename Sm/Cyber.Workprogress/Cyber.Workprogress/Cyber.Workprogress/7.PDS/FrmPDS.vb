Imports System.Drawing
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.XtraScheduler
Imports DevExpress.Utils
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class FrmPDS
#Region "Khai báo biến"
    Dim CyberWork As New Cyber.Workprogress.Sys
    Dim CyberColor As New Cyber.Color.Sys

    Dim Dt_Time, Dt_ConFigColor, Dt_Ngay_Tien_Do, Dt_Buoc_Nhay, Dt_SchedulerViewType, Dt_Do_Rong, Dt_Loai_Xem As DataTable
    Dim Dm_khoang, Dm_Hs, Dm_Hs_Filter, Dm_Bp, Dm_Bp_Filter, Dm_Ma3, Dm_Ma4 As DataTable
    Dim Dv_Khoang, Dv_Hs, Dv_BP As DataView

    Dim Dt_Data_Sort, Dt_Data, Dt_Data_Parent, Dt_Data_left, Dt_Data_Right As DataTable
    Dim Dv_Data_Sort, Dv_Data, Dv_Data_Parent, Dv_Data_left, Dv_Data_Right As DataView

    Dim Dt_left_H, Dt_Right_H As DataTable
    Dim Dv_left_H, Dv_Right_H As DataView

    Dim Head_khoang_Tree, Head_SK_Tree, Head_HS_Tree, Head_Bp_Tree As DataTable
    Dim Dv_Head_khoang, Dv_Head_SK, Dv_Head_Hs, Dv_Head_BP As DataView

    Dim M_StartHour, M_FinishHour As Decimal
    Dim M_StartMINUTE, M_FinishMINUTE As Decimal
    Dim M_TimeScales_Phut As Decimal
    Dim M_TimeScales_Gio As Decimal
    Dim M_TimeScales_Ngay As Decimal
    Dim M_TimeScales_Tuan As Decimal
    Dim M_TimeScales_Thang As Decimal
    Dim M_TimeScales_Quy As Decimal
    Dim M_TimeScales_Nam As Decimal

    Dim M_Ngay_LimitInterval_Min As Date
    Dim M_Ngay_LimitInterval_Max As Date
    Dim M_Thu_Bay As String = "0"
    Dim M_Chu_Nhat As String = "1"
#End Region
    Private Sub FrmPDS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "QUẢN LÝ TIẾN ĐỘ PDS"
        TxtM_Ngay_Ct.Value = Now.Date
        Timer_Data.Enabled = False
        ChkAuto_Data.Checked = False
        '--------------------------------------------------------------------------------------------
        Tao_Ngam_Dinh()
        '--------------------------------------------------------------------------------------------
        CyberSupport.V_SetTree(ResourcesTree)
        '--------------------------------------------------------------------------------------------
        CyberSupport.V_LoadTimeLine(SchedulerControl)
        '--------------------------------------------------------------------------------------------
        V_Ngay_Ct_Tien_Do()
        '--------------------------------------------------------------------------------------------
        V_CyberSetTime_Tien_Do()
        '--------------------------------------------------------------------------------------------
        V_LoadData_Tien_Do("1", "")
        '--------------------------------------------------------------------------------------------
        V_SetSchedulerControl()
        '--------------------------------------------------------------------------------------------
        V_Auto_Data_Tien_Do(New System.Object, New System.EventArgs)
        '--------------------------------------------------------------------------------------------
        V_AddHander_Tien_Do()
        '--------------------------------------------------------------------------------------------
        V_Do_Rong(New System.Object, New System.EventArgs) 'Độ rộng của cột
        '--------------------------------------------------------------------------------------------
        V_SetRowHeight() ' RowPage trong bảng tiến độ
        '--------------------------------------------------------------------------------------------
        V_SetAppointmentHeight() ' Độ cao của chíp
        
    End Sub
#Region "Databases And System"
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub Tao_Ngam_Dinh()
        Dim _Ngay_Ct As Date = TxtM_Ngay_Ct.Value
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_PDS_Config", _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim iTb As Integer = 0
        '---------------------------------------------------------------------
        If Dstmp.Tables.Count > iTb Then Dt_Time = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1

        '----ConFig
        If Dstmp.Tables.Count > iTb Then Dt_ConFigColor = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1
        '----
        If Dstmp.Tables.Count > iTb Then Dt_Buoc_Nhay = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1

        '----
        If Dstmp.Tables.Count > iTb Then Dt_SchedulerViewType = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1
        '----
        If Dstmp.Tables.Count > iTb Then Dt_Do_Rong = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1
        '----
        If Dstmp.Tables.Count > iTb Then Dt_Loai_Xem = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1
        '---------------------------------------------------------------------
        If Dstmp.Tables.Count > iTb Then Dm_khoang = Dstmp.Tables(iTb).Copy
        If Not Dm_khoang Is Nothing Then Dv_Khoang = New DataView(Dm_khoang)
        iTb = iTb + 1
        '----
        If Dstmp.Tables.Count > iTb Then Dm_Hs = Dstmp.Tables(iTb).Copy
        If Not Dm_Hs Is Nothing Then Dv_Hs = New DataView(Dm_Hs)
        If Not Dm_Hs Is Nothing Then Dm_Hs_Filter = Dm_Hs.Copy
        If Not Dm_Hs Is Nothing Then V_DeleteRowEmpty(Dm_Hs, "Ma_Hs")
        iTb = iTb + 1
        '-------------------------
        If Dstmp.Tables.Count > iTb Then Dm_Bp = Dstmp.Tables(iTb).Copy
        If Not Dm_Bp Is Nothing Then Dv_BP = New DataView(Dm_Bp)
        If Not Dm_Bp Is Nothing Then Dm_Bp_Filter = Dm_Bp.Copy
        If Not Dm_Bp Is Nothing Then V_DeleteRowEmpty(Dm_Bp, "Ma_Bp")

        iTb = iTb + 1
        '-------------------------
        If Dstmp.Tables.Count > iTb Then Head_khoang_Tree = Dstmp.Tables(iTb).Copy
        If Dstmp.Tables.Count > iTb Then Dv_Head_khoang = New DataView(Head_khoang_Tree)
        iTb = iTb + 1
        '-------------------------
        If Dstmp.Tables.Count > iTb Then Head_SK_Tree = Dstmp.Tables(iTb).Copy
        If Dstmp.Tables.Count > iTb Then Dv_Head_SK = New DataView(Head_SK_Tree)
        iTb = iTb + 1
        '-------------------------
        If Dstmp.Tables.Count > iTb Then Head_HS_Tree = Dstmp.Tables(iTb).Copy
        If Dstmp.Tables.Count > iTb Then Dv_Head_Hs = New DataView(Head_HS_Tree)
        iTb = iTb + 1
        '-------------------------
        If Dstmp.Tables.Count > iTb Then Head_Bp_Tree = Dstmp.Tables(iTb).Copy
        If Dstmp.Tables.Count > iTb Then Dv_Head_BP = New DataView(Head_Bp_Tree)
        iTb = iTb + 1
        '-------------------------
        If Dstmp.Tables.Count > iTb Then Dm_Ma3 = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1
        '-------------------------
        If Dstmp.Tables.Count > iTb Then Dm_Ma4 = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1

        '---------------------------------------------------------------------
        CbbTime_Data.Visible = Not Dt_Time Is Nothing
        CyberFill.V_FillComBoxDefaul(CbbTime_Data, Dt_Time, "TG", "Ten_TG" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")

        CbbMa_BN.Visible = Not Dt_Buoc_Nhay Is Nothing
        CyberFill.V_FillComBoxDefaul(CbbMa_BN, Dt_Buoc_Nhay, "Ma_BN", "Ten_BN" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")

        CbbSchedulerViewType.Visible = Not Dt_SchedulerViewType Is Nothing
        CyberFill.V_FillComBoxDefaul(CbbSchedulerViewType, Dt_SchedulerViewType, "SchedulerViewType", "Name" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")

        CbbDo_Rong.Visible = Not Dt_Do_Rong Is Nothing
        CyberFill.V_FillComBoxDefaul(CbbDo_Rong, Dt_Do_Rong, "Ma_Width", "Ten_Width" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")

        CbbLoai_Xem.Visible = Not Dt_Loai_Xem Is Nothing
        CyberFill.V_FillComBoxDefaul(CbbLoai_Xem, Dt_Loai_Xem, "Loai", "Ten_Loai" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")

        CbbMa_Hs.Visible = Not Dm_Hs_Filter Is Nothing
        CyberFill.V_FillComBoxDefaul(CbbMa_Hs, Dm_Hs_Filter, "Ma_Hs", "Ten_Hs", "Ngam_Dinh")

        CbbMa_BP.Visible = Not Dm_Bp_Filter Is Nothing
        CyberFill.V_FillComBoxDefaul(CbbMa_BP, Dm_Bp_Filter, "Ma_BP", "Ten_BP", "Ngam_Dinh")

        CbbMa3.Visible = Not Dm_Ma3 Is Nothing
        CyberFill.V_FillComBoxDefaul(CbbMa3, Dm_Ma3, "Ma", "Ten", "Ngam_Dinh")

        CbbMa4.Visible = Not Dm_Ma4 Is Nothing
        CyberFill.V_FillComBoxDefaul(CbbMa4, Dm_Ma4, "Ma", "Ten", "Ngam_Dinh")

    End Sub
    Private Sub V_LoadData_Tien_Do(ByVal status As String, ByVal _Stt_Rec As String)
        SchedulerStorage.Appointments.AutoReload = False
        SchedulerStorage.BeginUpdate()
        Dim _Dt As Date = TxtM_Ngay_Ct.Value
        Dim _Loai_BN As String = V_GetLoaiBN()

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_PDS_Data", status & "#" & _Stt_Rec & "#" & _Loai_BN & "#" & _Dt.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If status = "1" Then
            Dt_Data_Sort = Nothing
            Dt_Data = Nothing
            Dt_Data_left = Nothing
            Dt_Data_Right = Nothing

            Dim iTb As Integer = 0
            '------------------------------------------------------------------------------------------------------------------------------
            If DsTmp.Tables.Count > iTb Then Dt_Data_Sort = DsTmp.Tables(iTb).Copy
            iTb = iTb + 1

            If DsTmp.Tables.Count > iTb Then Dt_Data = DsTmp.Tables(iTb).Copy
            If Not Dt_Data Is Nothing Then Dv_Data = New DataView(Dt_Data)
            iTb = iTb + 1
            '-------
            If DsTmp.Tables.Count > iTb Then Dt_Data_left = DsTmp.Tables(iTb).Copy
            If Not Dt_Data_left Is Nothing Then Dv_Data_left = New DataView(Dt_Data_left)
            iTb = iTb + 1
            '-------
            If DsTmp.Tables.Count > iTb Then Dt_Data_Right = DsTmp.Tables(iTb).Copy
            If Not Dt_Data_Right Is Nothing Then Dv_Data_Right = New DataView(Dt_Data_Right)
            iTb = iTb + 1
            '----------------------------------------------------------------------------------Head Left/Right
            If DsTmp.Tables.Count > iTb Then Dt_left_H = DsTmp.Tables(iTb).Copy
            If Not Dt_left_H Is Nothing Then Dv_left_H = New DataView(Dt_left_H)
            iTb = iTb + 1
            '-------
            If DsTmp.Tables.Count > iTb Then Dt_Right_H = DsTmp.Tables(iTb).Copy
            If Not Dt_Right_H Is Nothing Then Dv_Right_H = New DataView(Dt_Right_H)
            iTb = iTb + 1
            '----------------------------------------------------------------------------------
            If Not Dt_Data Is Nothing And Not Dt_Data_Sort Is Nothing Then
                Dim _Drs As DataRow() = Dt_Data_Sort.Select("Loai = 'DATA_KH'")
                If _Drs.Length > 0 Then CyberSupport.V_SetSortView(Dv_Data, _Drs(0))
            End If

            If Not Dt_Data_left Is Nothing And Not Dt_Data_Sort Is Nothing Then
                Dim _Drs As DataRow() = Dt_Data_Sort.Select("Loai = 'DATA_LEFT'")
                If _Drs.Length > 0 Then CyberSupport.V_SetSortView(Dv_Data_left, _Drs(0))
            End If

            If Not Dt_Data_Right Is Nothing And Not Dt_Data_Sort Is Nothing Then
                Dim _Drs As DataRow() = Dt_Data_Sort.Select("Loai = 'DATA_RIGHT'")
                If _Drs.Length > 0 Then CyberSupport.V_SetSortView(Dv_Data_Right, _Drs(0))
            End If

            '------------------------------------------------------------------------------------------------------------------------------

            If Not Dv_Data_left Is Nothing And Not Dv_left_H Is Nothing Then
                CyberFill.V_FillReports(MasterLeftGRV, M_LAN, Dv_left_H, Dv_Data_left)
                MasterLeft.DataSource = Dv_Data_left
                Me.MasterLeftGRV.GridControl = Me.MasterLeft
                MasterLeftGRV.OptionsView.ShowViewCaption = False
                MasterLeftGRV.OptionsSelection.MultiSelect = False
                Me.MasterLeftGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
            End If
            If Not Dv_Data_Right Is Nothing And Not Dv_Right_H Is Nothing Then
                CyberFill.V_FillReports(MasterRightGRV, M_LAN, Dv_Right_H, Dv_Data_Right)
                MasterRight.DataSource = Dv_Data_Right
                Me.MasterRightGRV.GridControl = Me.MasterRight
                MasterRightGRV.OptionsView.ShowViewCaption = False
                MasterRightGRV.OptionsSelection.MultiSelect = False
                Me.MasterRightGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
            End If
            '------------------------------------------------------------------------------------------------------------------------------
        Else
            If _Stt_Rec.Trim = "" Then
                Dim iTb As Integer = 0
                If DsTmp.Tables.Count > iTb And Not Dt_Data Is Nothing Then
                    Dt_Data.Clear()
                    Dt_Data.Load(DsTmp.Tables(iTb).CreateDataReader)
                End If
                iTb = iTb + 1
                If DsTmp.Tables.Count > iTb And Not Dt_Data_left Is Nothing Then
                    Dt_Data_left.Clear()
                    Dt_Data_left.Load(DsTmp.Tables(iTb).CreateDataReader)
                End If
                iTb = iTb + 1
                If DsTmp.Tables.Count > iTb And Not Dt_Data_Right Is Nothing Then
                    Dt_Data_Right.Clear()
                    Dt_Data_Right.Load(DsTmp.Tables(iTb).CreateDataReader)
                End If
                iTb = iTb + 1
            Else
                '----------------------------------------------
                Dim iTb As Integer = 0
                If Not Dt_Data Is Nothing Then
                    V_Delete_KH_Rx(Dt_Data, _Stt_Rec)
                    If DsTmp.Tables.Count > iTb Then Dt_Data.Load(DsTmp.Tables(iTb).CreateDataReader)
                End If
                iTb = iTb + 1
                '----------------------------------------------
                If Not Dt_Data_left Is Nothing Then
                    V_Delete_KH_Rx(Dt_Data_left, _Stt_Rec)
                    If DsTmp.Tables.Count > iTb Then Dt_Data_left.Load(DsTmp.Tables(iTb).CreateDataReader)
                End If
                iTb = iTb + 1

                '----------------------------------------------
                If Not Dt_Data_Right Is Nothing Then
                    V_Delete_KH_Rx(Dt_Data_Right, _Stt_Rec)
                    If DsTmp.Tables.Count > iTb Then Dt_Data_Right.Load(DsTmp.Tables(iTb).CreateDataReader)
                End If
                iTb = iTb + 1

            End If
        End If

        DsTmp.Dispose()
        SchedulerStorage.EndUpdate()
        SchedulerControl.Storage.RefreshData()
        SchedulerStorage.Appointments.AutoReload = True

        V_Filter(New System.Object, New System.EventArgs)

    End Sub
    Private Sub V_DeleteRowEmpty(ByVal _Dt As DataTable, ByVal _Fieldname As String)
        If _Dt Is Nothing Then Return
        _Fieldname = _Fieldname.Trim
        If Not _Dt.Columns.Contains(_Fieldname) Then Return
        _Fieldname = _Dt.Columns(_Fieldname).ColumnName
        Dim nCount As Integer = _Dt.Rows.Count - 1
        For i As Integer = nCount To 0 Step -1
            If _Dt.Rows(i).Item(_Fieldname).ToString.Trim = "" Then _Dt.Rows(i).Delete()
        Next
        _Dt.AcceptChanges()
    End Sub
    Private Sub V_RefreshData(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_Tien_Do("0", "")
    End Sub
    Private Sub V_Delete_KH_Rx(ByVal _Dt As DataTable, ByVal _Stt_Rec As String)
        If _Dt Is Nothing Then Return
        Dim nCount As Integer = _Dt.Rows.Count - 1
        If _Stt_Rec.Trim = "" Then
            _Dt.Clear()
            _Dt.AcceptChanges()
            Return
        End If
        If Not _Dt.Columns.Contains("Stt_Rec") Then Return

        nCount = _Dt.Rows.Count - 1

        For i As Integer = nCount To 0 Step -1
            '-------------------

            If _Dt.Rows(i).Item("Stt_Rec").ToString.Trim = _Stt_Rec.Trim Then
                ''_Dt.Rows.RemoveAt(i)
                _Dt.Rows(i).Delete()
            End If
        Next
        _Dt.AcceptChanges()

    End Sub
    Private Sub FrmPDS_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_SetRowHeight()
    End Sub
    Private Sub V_Quay_Ra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_Filter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '----------------------------------------------------------------------------------------
        Dim _StrFilter_Data As String = V_GetFilter(Dt_Data)
        Try
            If Not Dv_Data Is Nothing Then Dv_Data.RowFilter = _StrFilter_Data
        Catch ex As Exception
        End Try
        '----------------------------------------------------------------------------------------
        Dim _StrFilter_Data_Left As String = V_GetFilter(Dt_Data_left)
        Try
            If Not Dt_Data_left Is Nothing Then Dv_Data_left.RowFilter = _StrFilter_Data_Left
        Catch ex As Exception
        End Try
        '----------------------------------------------------------------------------------------
        Dim _StrFilter_Data_Right As String = V_GetFilter(Dt_Data_Right)
        Try
            If Not Dt_Data_Right Is Nothing Then Dv_Data_Right.RowFilter = _StrFilter_Data_Right
        Catch ex As Exception
        End Try
        '----------------------------------------------------------------------------------------
        Dim _StrFilter_HS As String = V_GetFilter(Dm_Hs)
        Try
            If Not Dm_Hs Is Nothing Then Dv_Hs.RowFilter = _StrFilter_HS
        Catch ex As Exception
        End Try
        '----------------------------------------------------------------------------------------
        Dim _StrFilter_Bp As String = V_GetFilter(Dm_Bp)
        Try
            If Not Dm_Bp Is Nothing Then Dv_BP.RowFilter = _StrFilter_Bp
        Catch ex As Exception
        End Try

    End Sub
    Private Function V_GetFilter(ByVal _DT_Filter As DataTable) As String
        If _DT_Filter Is Nothing Then Return "1=1"
        Dim _StrFilter As String = "1=1"
        If _DT_Filter Is Nothing Then Return _StrFilter
        Dim _Ma_HS As String = CyberWork.V_GetvalueCombox(CbbMa_Hs)
        If _DT_Filter.Columns.Contains("Ma_HS") And _Ma_HS <> "" Then _StrFilter = _StrFilter + " AND Ma_HS = '" + _Ma_HS.Trim + "'"

        Dim _Ma_Bp As String = CyberWork.V_GetvalueCombox(CbbMa_BP)
        If _DT_Filter.Columns.Contains("Ma_Bp") And _Ma_Bp <> "" Then _StrFilter = _StrFilter + " AND Ma_Bp = '" + _Ma_Bp.Trim + "'"

        Dim _Ma3 As String = CyberWork.V_GetvalueCombox(CbbMa3)
        If _DT_Filter.Columns.Contains("Ma3") And _Ma3 <> "" Then _StrFilter = _StrFilter + " AND Ma3 = '" + _Ma3.Trim + "'"

        Dim _Ma4 As String = CyberWork.V_GetvalueCombox(CbbMa4)
        If _DT_Filter.Columns.Contains("Ma4") And _Ma4 <> "" Then _StrFilter = _StrFilter + " AND Ma4 = '" + _Ma4.Trim + "'"
        '------------------------------------------------------------------------------------------------        
        V_GetFilter = _StrFilter

    End Function
#End Region
#Region "AddHander"
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

        AddHandler ResourcesTree.CustomDrawNodeCell, AddressOf ResourcesTree_CustomDrawNodeCell
        AddHandler ToolTipController1.BeforeShow, AddressOf ToolTipController_BeforeShow

        '------------------------------------------------------------------------------------------------------------------------------------------------------------
        If CbbMa_Hs.Visible Then AddHandler CbbMa_Hs.SelectedValueChanged, AddressOf V_Filter
        If CbbMa_BP.Visible Then AddHandler CbbMa_BP.SelectedValueChanged, AddressOf V_Filter
        If CbbMa3.Visible Then AddHandler CbbMa3.SelectedValueChanged, AddressOf V_Filter
        If CbbMa4.Visible Then AddHandler CbbMa4.SelectedValueChanged, AddressOf V_Filter


        AddHandler TxtM_Ngay_Ct.TextChanged, AddressOf V_Ngay_Ct
        AddHandler CbbLoai_Xem.SelectedIndexChanged, AddressOf V_Loai_Xem
        AddHandler CbbMa_BN.SelectedValueChanged, AddressOf V_Buoc_Nhay

        AddHandler CbbSchedulerViewType.SelectedValueChanged, AddressOf V_SchedulerViewType
        AddHandler CbbDo_Rong.SelectedValueChanged, AddressOf V_Do_Rong

        '------------------------GRV------------------------------------------------------------------------------------------------
        AddHandler MasterLeftGRV.RowCellStyle, AddressOf MasterLeftGRV_RowCellStyle
        AddHandler MasterRightGRV.RowCellStyle, AddressOf MasterRightGRV_RowCellStyle
        AddHandler MasterRightGRV.PopupMenuShowing, AddressOf Master_Sua_Xong_KHGRVPopupMenuShowing
        '------------------------GRV------------------------------------------------------------------------------------------------
        AddHandler SchedulerControl.PopupMenuShowing, AddressOf V_PopupMenu
        AddHandler SchedulerControl.EditAppointmentFormShowing, AddressOf CyberWork.V_Lap_F3F4
        ''---------------------------------------------------------------------------------------------------------------------
        ''-------------Timer
        AddHandler ChkAuto_Data.CheckedChanged, AddressOf V_Auto_Data_Tien_Do
        AddHandler CbbTime_Data.SelectedValueChanged, AddressOf V_Auto_Data_Tien_Do

        AddHandler Timer_Data.Tick, AddressOf V_Timer_Data
        AddHandler Timer_PercentComplete.Tick, AddressOf V_Timer_PercentComplete

        ''---------------------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub V_PopupMenu(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs)

        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        Dim _Stt_Rec As String = ""
        If scheduler.SelectedAppointments.Count > 0 Then
            Try
                _Stt_Rec = scheduler.SelectedAppointments(0).Id.ToString
            Catch ex As Exception
            End Try
        End If
        e.Menu.Items.Clear()
        Dim rowHandle As Integer = 0
        PopupMenuSchedulerControl.ItemLinks.Clear()
        '-----------------
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Bắt đầu/Kết thúc", "Begin/Finish"), AddressOf V_BD_KT, Shortcut.F10, My.Resources.time_16x16, True, True), True).BeginGroup = True
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Tạo KH", "New"), AddressOf V_Tao_KH_Scheduler, Shortcut.F4, My.Resources.apply_16x16, True, True), True).BeginGroup = True
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Sửa KH", "Edit"), AddressOf V_Sua_KH_Scheduler, Shortcut.F3, My.Resources.edit_16x16, True, True), True).BeginGroup = False
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xóa KH", "Delete"), AddressOf V_Xoa_KH_Scheduler, Shortcut.F8, My.Resources.deletelist_16x16, True, True), True).BeginGroup = False
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_RefreshData, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        '-----------------
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), True).BeginGroup = True
        If Not e Is Nothing Then PopupMenuSchedulerControl.ShowPopup(Control.MousePosition)
    End Sub
#End Region

#Region "----------Sự kiện - Footer:1. Ngày,Giờ xem, Loại xem, Bước ngày, độ rộng, Độ cao của chíp, Độ rộng của Head"
    Private Sub V_Ngay_Ct_Tien_Do()
        Dim _Ngay_Ct As Date = TxtM_Ngay_Ct.Value
        Dim _Loai_BN As String = V_GetLoaiBN()
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_PDS_Ngay_Ngam_Dinh", _Loai_BN & "#" & _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs + "#" & M_User_Name)
        If Not Dt_Ngay_Tien_Do Is Nothing Then
            Dt_Ngay_Tien_Do.Clear()
            Dt_Ngay_Tien_Do.ImportRow(DsTmp.Tables(0).Rows(0))
        Else
            Dt_Ngay_Tien_Do = DsTmp.Tables(0).Copy
        End If
        '------------------------------------------------------------------------------------------------------------------
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

        If Dt_Ngay_Tien_Do.Columns.Contains("LabLeft") Then C.Text = Dt_Ngay_Tien_Do.Rows(0).Item("LabLeft").ToString.Trim.ToUpper
        If Dt_Ngay_Tien_Do.Columns.Contains("LabHead") Then LabHead.Text = Dt_Ngay_Tien_Do.Rows(0).Item("LabHead").ToString.Trim.ToUpper
        If Dt_Ngay_Tien_Do.Columns.Contains("LabRight") Then LabRight.Text = Dt_Ngay_Tien_Do.Rows(0).Item("LabRight").ToString.Trim.ToUpper

        If Dt_Ngay_Tien_Do.Columns.Contains("LabLeft2") And M_LAN <> "V" Then C.Text = Dt_Ngay_Tien_Do.Rows(0).Item("LabLeft2").ToString.Trim.ToUpper
        If Dt_Ngay_Tien_Do.Columns.Contains("LabHead2") And M_LAN <> "V" Then LabHead.Text = Dt_Ngay_Tien_Do.Rows(0).Item("LabHead2").ToString.Trim.ToUpper
        If Dt_Ngay_Tien_Do.Columns.Contains("LabRight2") And M_LAN <> "V" Then LabRight.Text = Dt_Ngay_Tien_Do.Rows(0).Item("LabRight2").ToString.Trim.ToUpper

        If Dt_Ngay_Tien_Do.Columns.Contains("Is_LabLeft") Then C.Visible = Dt_Ngay_Tien_Do.Rows(0).Item("Is_LabLeft").ToString.Trim.ToUpper = "1"
        If Dt_Ngay_Tien_Do.Columns.Contains("Is_LabHead") Then LabHead.Visible = Dt_Ngay_Tien_Do.Rows(0).Item("Is_LabHead").ToString.Trim.ToUpper = "1"
        If Dt_Ngay_Tien_Do.Columns.Contains("Is_LabRight") Then LabRight.Visible = Dt_Ngay_Tien_Do.Rows(0).Item("Is_LabRight").ToString.Trim.ToUpper = "1"

    End Sub
    Private Sub V_Ngay_Ct(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '------------------------------------------------------------------------------------------------------------------
        V_Ngay_Ct_Tien_Do()
        '------------------------------------------------------------------------------------------------------------------
        V_LoadData_Tien_Do("0", "")
        '------------------------------------------------------------------------------------------------------------------
        ''   V_SetSchedulerSetValue()
        '------------------------------------------------------------------------------------------------------------------
        ''  V_SetSchedulerControl()
    End Sub
    Private Sub V_Loai_Xem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Timer As Boolean = V_GetEnableTimer()
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm("Đang thực hiện", "Waiting", M_LAN)
        V_SetSchedulerSetValue()
        '---------------------------------------------------
        V_SetAppointmentHeight()
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        If _Timer Then V_SetEnableTimer()
        V_SetAppointmentHeight()
    End Sub
    Private Function V_GetThoiGianBN(ByVal _Ma_BN As String)
        Dim _Dr As DataRow() = Dt_Buoc_Nhay.Select("Ma_BN = '" + _Ma_BN + "'")
        V_GetThoiGianBN = _Dr(0).Item("TG")
    End Function
    Private Function V_GetLoaiBN() As String
        Dim _Loai_BN As String = "01"
        Try
            Dim _Ma_BN As String = CyberWork.V_GetvalueCombox(CbbMa_BN)
            Dim _Dr As DataRow() = Dt_Buoc_Nhay.Select("Ma_BN ='" & _Ma_BN & "'")
            _Loai_BN = _Dr(0).Item("Loai_BN").ToString.Trim
        Catch ex As Exception
        End Try
        V_GetLoaiBN = _Loai_BN
    End Function
    Private Sub V_Buoc_Nhay(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_CyberSetTime_Tien_Do()
        V_Do_Rong(sender, e)
    End Sub
    Private Sub V_Do_Rong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SchedulerControl.ActiveViewType = SchedulerViewType.Gantt Then
            For i = 0 To SchedulerControl.Views.GanttView.Scales.Count - 1
                If SchedulerControl.GanttView.Scales(i).Visible Then
                    SchedulerControl.Views.GanttView.Scales(i).Width = CyberWork.V_GetvalueCombox(CbbDo_Rong)
                End If
            Next
        End If
        If SchedulerControl.ActiveViewType = SchedulerViewType.Day Then
            SchedulerControl.DayView.RowHeight = CyberWork.V_GetvalueCombox(CbbDo_Rong)
        End If
        If SchedulerControl.ActiveViewType = SchedulerViewType.Timeline Then
            For i = 0 To SchedulerControl.Views.TimelineView.Scales.Count - 1
                If SchedulerControl.TimelineView.Scales(i).Visible Then
                    SchedulerControl.Views.TimelineView.Scales(i).Width = CyberWork.V_GetvalueCombox(CbbDo_Rong)
                End If
            Next

            For i = 0 To SchedulerControl.Views.GanttView.Scales.Count - 1
                ' If SchedulerControl.GanttView.Scales(i).Visible Then
                SchedulerControl.Views.GanttView.Scales(i).Width = CyberWork.V_GetvalueCombox(CbbDo_Rong)
                ' End If
            Next
            SchedulerControl.DayView.RowHeight = CyberWork.V_GetvalueCombox(CbbDo_Rong)
        End If
        If SchedulerControl.ActiveViewType = SchedulerViewType.FullWeek Then
            For i = 0 To SchedulerControl.Views.TimelineView.Scales.Count - 1
                If SchedulerControl.TimelineView.Scales(i).Visible Then
                    SchedulerControl.Views.TimelineView.Scales(i).Width = CyberWork.V_GetvalueCombox(CbbDo_Rong)
                End If
            Next

            For i = 0 To SchedulerControl.Views.GanttView.Scales.Count - 1
                ' If SchedulerControl.GanttView.Scales(i).Visible Then
                SchedulerControl.Views.GanttView.Scales(i).Width = CyberWork.V_GetvalueCombox(CbbDo_Rong)
                ' End If
            Next

            SchedulerControl.Views.FullWeekView.RowHeight = CyberWork.V_GetvalueCombox(CbbDo_Rong)


        End If
    End Sub
    Private Sub V_PercentComplete(Optional ByVal _Stt_rec As String = "", Optional ByVal _So_Ro As String = "")
    End Sub
    Private Sub V_SchedulerViewType(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _SchedulerViewType As String = CyberWork.V_GetvalueCombox(CbbSchedulerViewType)
        If _SchedulerViewType.Trim = "" Then _SchedulerViewType = "Gantt"
        _SchedulerViewType = _SchedulerViewType.Trim.ToUpper
        Select Case _SchedulerViewType
            Case "GANTT".ToUpper
                SchedulerControl.ActiveViewType = SchedulerViewType.Gantt
                SchedulerControl.Views.GanttView.ResourcesPerPage = 12
            Case "DAY".ToUpper
                SchedulerControl.ActiveViewType = SchedulerViewType.Day
                SchedulerControl.Views.GanttView.ResourcesPerPage = 6
            Case "AGENDA".ToUpper
                SchedulerControl.ActiveViewType = SchedulerViewType.Agenda
            Case "WEEK".ToUpper
                SchedulerControl.ActiveViewType = SchedulerViewType.Week
                SchedulerControl.Views.WeekView.ResourcesPerPage = 2
            Case "FULLWEEK".ToUpper
                SchedulerControl.ActiveViewType = SchedulerViewType.FullWeek
                SchedulerControl.Views.FullWeekView.ResourcesPerPage = 2
            Case "WorkWeek".ToUpper
                SchedulerControl.ActiveViewType = SchedulerViewType.WorkWeek
                SchedulerControl.Views.GanttView.ResourcesPerPage = 2
            Case "TimeLine".ToUpper
                SchedulerControl.ActiveViewType = SchedulerViewType.Timeline
                SchedulerControl.Views.TimelineView.ResourcesPerPage = 4
            Case "month".ToUpper
                SchedulerControl.ActiveViewType = SchedulerViewType.Month
                SchedulerControl.Views.MonthView.ResourcesPerPage = 4
            Case Else
                SchedulerControl.ActiveViewType = SchedulerViewType.Gantt
        End Select
    End Sub
    Private Sub V_SetAppointmentHeight()

        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem)
        If Dt_Loai_Xem Is Nothing Then Return
        If Not Dt_Loai_Xem.Columns.Contains("Is_AppointmentHeight") Then Return
        If Not Dt_Loai_Xem.Columns.Contains("AppointmentHeight") Then Return
        If Not Dt_Loai_Xem.Columns.Contains("Loai") Then Return
        Dim _Dr As DataRow()
        _Dr = Dt_Loai_Xem.Select("Loai = '" & _Loai_Xem & "'")
        If _Dr.Length = 0 Then Return

        Dim _Is_AppointmentHeight As String = _Dr(0).Item("Is_AppointmentHeight")
        Dim _AppointmentHeight As Decimal = _Dr(0).Item("AppointmentHeight")

        If _Is_AppointmentHeight = 0 Then Return
        If _AppointmentHeight = 0 Then Return

        '--------------------------------
        CyberSupport.V_SetAppointmentHeight(SchedulerControl, _AppointmentHeight, Sysvar)

    End Sub
    Private Sub V_SetRowHeight()

        Dim _RowHeight As Decimal = 0
        Dim _RowPage As Decimal = 0
        If Dt_Ngay_Tien_Do Is Nothing Then Return
        If Dt_Ngay_Tien_Do.Rows.Count = 0 Then Return
        If Dt_Ngay_Tien_Do.Columns.Contains("RowHeight") Then _RowHeight = Dt_Ngay_Tien_Do.Rows(0).Item("RowHeight")
        If Dt_Ngay_Tien_Do.Columns.Contains("RowPage") Then _RowPage = Dt_Ngay_Tien_Do.Rows(0).Item("RowPage")
        CyberSupport.V_SetRowHeight(SchedulerControl, _RowHeight, _RowPage, Sysvar)

    End Sub
    Private Sub V_GetFromSetScheduler(ByRef _Ma_khoang As String, ByRef _Ngay_BD As Date, ByRef _Ngay_KT As Date, Optional ByVal _Appointment As Appointment = Nothing)
        _Ngay_BD = Now.Date
        _Ngay_KT = Now.Date
        If _Appointment Is Nothing Then
            _Ngay_BD = SchedulerControl.SelectedInterval.Start
            _Ngay_KT = SchedulerControl.SelectedInterval.End
        Else
            _Ngay_BD = _Appointment.Start
            _Ngay_KT = _Appointment.End
        End If


        Dim _Value As String = GetvalueSelectedResource(_Appointment)
        If _Value.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Value = ""
        _Ma_khoang = _Value
    End Sub
    Private Function GetvalueSelectedResource(Optional ByVal _Appointment As Appointment = Nothing) As String
        Dim _Value As String = ""
        Try
            If _Appointment Is Nothing Then
                _Value = SchedulerControl.SelectedResource.Id.ToString.Trim().ToUpper.Trim
            Else
                _Value = _Appointment.ResourceId.ToString()
            End If
        Catch ex As Exception
        End Try
        If _Value.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Value = ""
        If _Value.ToUpper.Trim Like "*DevExpress.XtraScheduler*".ToUpper.Trim Then _Value = ""
        Return _Value
    End Function
    Private Sub V_GetFromSetScheduler_Old(ByRef _ma_khoangOld As String, Optional ByVal _Appointment As Appointment = Nothing)
        Dim apt As Appointment = SchedulerControl.SelectedAppointments(0)
        Dim _drv As DataRowView
        Try
            If apt.Type = AppointmentType.Normal Or apt.Type = AppointmentType.Pattern Then
                _drv = SchedulerControl.SelectedAppointments(0).GetSourceObject(SchedulerControl.Storage)
            Else
                _drv = SchedulerControl.SelectedAppointments(0).RecurrencePattern.GetSourceObject(SchedulerControl.Storage)
            End If
        Catch ex As Exception

        End Try
        If _drv Is Nothing Then Return
        If Dt_Data.Columns.Contains("ma_khoang") Then _ma_khoangOld = _drv.Item("Ma_khoang").ToString.Trim
    End Sub
#End Region
#Region "Scheduler"
    Private Sub V_CyberSetTime_Tien_Do()
        V_Set_Ngay_Ct_Tien_Do()
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
    End Sub
    Private Sub V_SetSchedulerSetValue()
        Dim _Loai_Xem As String = CbbLoai_Xem.SelectedValue.ToString
        Dim _ShowLeft As Boolean = True
        Dim _ShowTree As Boolean = True
        Dim _ShowHead As Boolean = True
        Dim _ShowRight As Boolean = True
        Dim _SplitterDistance_Left As Integer = 200
        Dim _SplitterDistance_Right As Integer = 200
        Dim _SplitterDistance_Tree As Integer = 200
        Dim _AppointmentHeight As Integer = 30
        Dim _Is_AppointmentHeight As Boolean = False

        Dim _Do_Rong_Head As Integer = 100
        Dim _Do_Rong As Integer = 100

        Dim _Dr As DataRow()
        If Not Dt_Loai_Xem Is Nothing Then _Dr = Dt_Loai_Xem.Select("Loai = '" & _Loai_Xem & "'")
        If Not _Dr Is Nothing Then
            If _Dr.Length > 0 Then
                If Dt_Loai_Xem.Columns.Contains("ShowLeft") Then _ShowLeft = (_Dr(0).Item("ShowLeft").ToString.Trim = "1")
                If Dt_Loai_Xem.Columns.Contains("ShowTree") Then _ShowTree = (_Dr(0).Item("ShowTree").ToString.Trim = "1")
                If Dt_Loai_Xem.Columns.Contains("ShowHead") Then _ShowHead = (_Dr(0).Item("ShowHead").ToString.Trim = "1")
                If Dt_Loai_Xem.Columns.Contains("ShowRight") Then _ShowRight = (_Dr(0).Item("ShowRight").ToString.Trim = "1")

                If Dt_Loai_Xem.Columns.Contains("SplitterDistance_Left") Then _SplitterDistance_Left = (_Dr(0).Item("SplitterDistance_Left"))
                If Dt_Loai_Xem.Columns.Contains("SplitterDistance_Right") Then _SplitterDistance_Right = (_Dr(0).Item("SplitterDistance_Right"))
                If Dt_Loai_Xem.Columns.Contains("Width_Head") Then _Do_Rong_Head = _Dr(0).Item("Width_Head")

                If Dt_Loai_Xem.Columns.Contains("ShowLeft") Then _ShowLeft = _Dr(0).Item("ShowLeft").ToString.Trim = "1"
                If Dt_Loai_Xem.Columns.Contains("ShowTree") Then _ShowTree = _Dr(0).Item("ShowTree").ToString.Trim = "1"
                If Dt_Loai_Xem.Columns.Contains("ShowHead") Then _ShowHead = _Dr(0).Item("ShowHead").ToString.Trim = "1"
                If Dt_Loai_Xem.Columns.Contains("ShowRight") Then _ShowRight = _Dr(0).Item("ShowRight").ToString.Trim = "1"

                If Dt_Loai_Xem.Columns.Contains("SplitterDistance_Left") Then _SplitterDistance_Left = _Dr(0).Item("SplitterDistance_Left")
                If Dt_Loai_Xem.Columns.Contains("SplitterDistance_Right") Then _SplitterDistance_Right = _Dr(0).Item("SplitterDistance_Right")
                If Dt_Loai_Xem.Columns.Contains("SplitterDistance_Tree") Then _SplitterDistance_Tree = _Dr(0).Item("SplitterDistance_Tree")

                If Dt_Loai_Xem.Columns.Contains("Do_Rong") Then _Do_Rong = _Dr(0).Item("Do_Rong")

                If Dt_Loai_Xem.Columns.Contains("Is_AppointmentHeight") Then If _Dr(0).Item("Is_AppointmentHeight").ToString.Trim = "1" Then _Is_AppointmentHeight = True
                If Dt_Loai_Xem.Columns.Contains("AppointmentHeight") Then _AppointmentHeight = _Dr(0).Item("AppointmentHeight")


            End If
        End If
        If _SplitterDistance_Left < 0 Then _SplitterDistance_Left = 0
        If _SplitterDistance_Right < 0 Then _SplitterDistance_Right = 0
        MasterLeft.Visible = _ShowLeft
        MasterRight.Visible = _ShowRight


        If Not _ShowLeft Then SplitContainer_Left.SplitterDistance = 0 Else SplitContainer_Left.SplitterDistance = _SplitterDistance_Left
        If Not _ShowRight Then SplitContainer_Right.SplitterDistance = 0 Else SplitContainer_Right.SplitterDistance = _SplitterDistance_Right

        If _Loai_Xem = "02" And Dv_Data Is Nothing Then _Loai_Xem = "01"
        If _Loai_Xem = "03" And Dv_Hs Is Nothing Then _Loai_Xem = "01"
        If _Loai_Xem = "04" And Dv_BP Is Nothing Then _Loai_Xem = "01"


        Dim _Ma As String = ""
        Dim _Ten As String = ""
        Select Case _Loai_Xem
            Case "02"
                If Head_SK_Tree Is Nothing Then _ShowTree = False Else If Head_SK_Tree.Rows.Count = 0 Then _ShowTree = False
                _Ma = "Ma_Xe"
                _Ten = "Ma_Xe"
                CyberSupport.V_SetScheduler(Dv_Data, Dv_Data_Parent, Nothing, _Ma, _Ten, "Ma_Xe", _Do_Rong, SchedulerControl, ResourcesTree, IIf(_ShowTree, Head_SK_Tree, Nothing))

            Case "03"
                If Head_HS_Tree Is Nothing Then _ShowTree = False Else If Head_HS_Tree.Rows.Count = 0 Then _ShowTree = False
                _Ma = "Ma_Hs"
                _Ten = "Ma_Hs"
                CyberSupport.V_SetScheduler(Dv_Hs, Dv_Data_Parent, Nothing, _Ma, _Ten, "Ma_Xe", _Do_Rong, SchedulerControl, ResourcesTree, IIf(_ShowTree, Head_HS_Tree, Nothing))

            Case "04"
                If Head_Bp_Tree Is Nothing Then _ShowTree = False Else If Head_Bp_Tree.Rows.Count = 0 Then _ShowTree = False
                _Ma = "Ma_Bp"
                _Ten = "Ma_Bp"
                CyberSupport.V_SetScheduler(Dv_BP, Dv_Data_Parent, Nothing, _Ma, _Ten, "Ma_Xe", _Do_Rong, SchedulerControl, ResourcesTree, IIf(_ShowTree, Head_Bp_Tree, Nothing))

            Case Else
                If Head_khoang_Tree Is Nothing Then _ShowTree = False Else If Head_khoang_Tree.Rows.Count = 0 Then _ShowTree = False
                If Dm_khoang.Columns.Contains("Ma_Khoang_Tmp") Then _Ma = "Ma_Khoang_Tmp" Else _Ma = "Ma_Khoang"
                If Dm_khoang.Columns.Contains("Ten_Khoang_Tmp") Then _Ten = "Ten_Khoang_Tmp" Else _Ten = If(Dm_khoang.Columns.Contains("Ten3"), "Ten3", "Ten_Khoang")
                CyberSupport.V_SetScheduler(Dv_Data, Dv_Data_Parent, Dv_Khoang, _Ma, _Ten, "Ma_Xe", _Do_Rong, SchedulerControl, ResourcesTree, IIf(_ShowTree, Head_khoang_Tree, Nothing))

        End Select
        '-------------------------------------------------------------------------------------
        If Not _ShowTree Then _ShowHead = True
        SchedulerControl.Views.GanttView.ShowResourceHeaders = _ShowHead

        If Not _ShowLeft Then _SplitterDistance_Left = 0
        If Not _ShowRight Then _SplitterDistance_Right = 0
        If Not _ShowTree Then _SplitterDistance_Tree = 0

        '-------------------------------------------------------------------------------------
        SplitContainer_Left.Panel1Collapsed = Not _ShowLeft
        SplitContainer_Right.Panel2Collapsed = Not _ShowRight
        SplitContainer_Tree.Panel1Collapsed = Not _ShowTree
        '-------------------------------------------------------------------------------------
        If _ShowLeft Then
            If _SplitterDistance_Left <= 10 Then _SplitterDistance_Left = 10
            SplitContainer_Left.SplitterDistance = _SplitterDistance_Left
        End If

        If _ShowRight Then
            Dim _With_Right As Decimal = SplitContainer_Right.Width
            _SplitterDistance_Right = _With_Right - _SplitterDistance_Right
            If _SplitterDistance_Right <= 10 Then _SplitterDistance_Right = 10
            SplitContainer_Right.SplitterDistance = _SplitterDistance_Right
        End If

        If _ShowTree Then
            If _SplitterDistance_Tree <= 10 Then _SplitterDistance_Tree = 10
            SplitContainer_Tree.SplitterDistance = _SplitterDistance_Tree
        End If
        '-------------------------------------------------------------------------------------

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

#Region "Scheduler: Drop/Drop/Resize: keo tha"
    Private Function V_Update_Keo_Tha(ByVal _Appointment As Appointment) As Boolean
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then
            Try
                _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
            Catch ex As Exception
            End Try
        End If
        If _Stt_Rec.ToString.Trim = "" Then Return False
        '----------------------------KHong thay doi duoc ngay o doan nay
        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End
        '----------------------------
        Dim _ma_khoang As String = ""
        Dim _ma_khoangOld As String = ""

        V_GetFromSetScheduler(_ma_khoang, _Ngay_Bd, _Ngay_Kt, _Appointment)
        V_GetFromSetScheduler_Old(_ma_khoangOld, _Appointment)
        Dim _Tg_SC As Integer = CbbMa_BN.SelectedValue

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_PDS_Keo_Tha", _Tg_SC.ToString.Trim.Replace(",", ".") & "#" & _Stt_Rec & "#" & _ma_khoang & "#" & _ma_khoangOld & "#" & _Ngay_Bd.ToString("yyyyMMdd HH:mm") & "#" & _Ngay_Kt.ToString("yyyyMMdd HH:mm") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN)
        DsTmp.Dispose()
        If _Return Then V_LoadData_Tien_Do("0", _Stt_Rec)
        Return _Return
    End Function
    Private Sub V_SchedulerControl_AppointmentDrop(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentDragEventArgs) '----Handles SchedulerControl_KH_SCC.AppointmentDrop
        Dim _Appointment As Appointment
        _Appointment = e.EditedAppointment
        Dim _Return As Boolean = V_Update_Keo_Tha(_Appointment)
        e.Allow = _Return
    End Sub
    Private Sub V_SchedulerControl_AppointmentResized(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentResizeEventArgs) '----Handles SchedulerControl_KH_SCC.AppointmentResized
        Dim _Appointment As Appointment
        _Appointment = e.EditedAppointment
        Dim _Return As Boolean = V_Update_Keo_Tha(_Appointment)
        e.Allow = _Return
        e.Handled = Not _Return
    End Sub
#End Region
#Region "Tao moi/Sua/ xoa/bat dau - Ket thuc"
    Private Sub V_Tao_KH_Scheduler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Mode As String = "M"
        Dim _Stt_rec As String = ""
        Dim _Ma_khoang As String = ""
        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End
        _Ma_khoang = SchedulerControl.SelectedResource.Id.ToString.Trim()
        Dim _Tg_SC As Integer = V_GetThoiGianBN(CbbMa_BN.SelectedValue)
        Dim _Dt_Return As DataTable = CyberWork.V_KH_PDS(_Mode, _Stt_rec, _Ma_khoang, _Ngay_Bd, _Ngay_Kt, _Tg_SC, Dm_khoang, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        If _Dt_Return Is Nothing Then Return
        If _Dt_Return.Rows.Count = 0 Then Return
        If Not _Dt_Return.Columns.Contains("Stt_Rec") Then Return
        If _Dt_Return.Rows(0).Item("Stt_Rec").ToString.Trim = "" Then Return
        V_LoadData_Tien_Do("0", _Dt_Return.Rows(0).Item("Stt_Rec").ToString.Trim)

    End Sub
    Private Sub V_Sua_KH_Scheduler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Mode As String = "S"
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then
            Try
                _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
            Catch ex As Exception
            End Try
        End If
        If _Stt_Rec.ToString.Trim = "" Then Return
        Dim _Ma_khoang As String = ""
        Dim _Ngay_Bd As Date = Now
        Dim _Ngay_Kt As Date = Now

        Dim _Drs As DataRow() = Dt_Data.Select("Stt_Rec = '" + _Stt_Rec + "'")
        If _Drs.Length > 0 Then
            _Ma_khoang = _Drs(0).Item("Ma_khoang").ToString.Trim
            _Ngay_Bd = _Drs(0).Item("Ngay_Bd")
            _Ngay_Kt = _Drs(0).Item("Ngay_KT")
        End If

        Dim _Tg_SC As Integer = V_GetThoiGianBN(CbbMa_BN.SelectedValue)
        Dim _Dt_Return As DataTable = CyberWork.V_KH_PDS(_Mode, _Stt_Rec, _Ma_khoang, _Ngay_Bd, _Ngay_Kt, _Tg_SC, Dm_khoang, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, _
                                     CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        If _Dt_Return Is Nothing Then Return
        If _Dt_Return.Rows.Count = 0 Then Return
        If Not _Dt_Return.Columns.Contains("Stt_Rec") Then Return
        If _Dt_Return.Rows(0).Item("Stt_Rec").ToString.Trim = "" Then Return
        V_LoadData_Tien_Do("0", _Dt_Return.Rows(0).Item("Stt_Rec").ToString.Trim)
    End Sub
    Private Sub V_Xoa_KH_Scheduler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then
            Try
                _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
            Catch ex As Exception
            End Try
        End If
        If _Stt_Rec.ToString.Trim = "" Then Return
        If Not CyberWork.V_Msgbox_Delete(Me.Sysvar, "Bạn có chắc chắn xóa không?") Then Return
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_PDS_DELETE", _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), Sysvar, M_LAN) Then
            Dstmp.Dispose()
            Return
        End If
        V_LoadData_Tien_Do("0", _Stt_Rec)

    End Sub

    Private Sub V_BD_KT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then
            Try
                _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
            Catch ex As Exception
            End Try
        End If
        If _Stt_Rec.ToString.Trim = "" Then Return
        V_Thuc_Hien(_Stt_Rec)
    End Sub
    Private Function V_Thuc_Hien(ByVal _Stt_Rec As String) As Boolean
        If _Stt_Rec.Trim = "" Then Return False
        Dim _Tg_SC As Integer = CbbMa_BN.SelectedValue
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_PDS_ThucHien", _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim _Return As Boolean = CyberSupport.V_MsgChk(Dstmp.Tables(0), Sysvar, M_LAN)
        If _Return Then V_LoadData_Tien_Do("0", _Stt_Rec)
        Return _Return
    End Function
#End Region
#Region "GRV"
    Private Sub MasterLeftGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterLeftGRV, Dt_Data_left, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub MasterRightGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterRightGRV, Dt_Data_Right, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub Master_Sua_Xong_KHGRVPopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuRight.ItemLinks.Clear()
        PopupMenuRight.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Đặt vị trí xe", "Location"), AddressOf V_Vi_Tri_Xe, System.Windows.Forms.Shortcut.F4, My.Resources.apply_16x16, True, True), True).BeginGroup = True
        PopupMenuRight.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem vị trí xe", "Set Location"), AddressOf V_Vi_Tri_Xe_Load, System.Windows.Forms.Shortcut.F10, Nothing, True, True), True).BeginGroup = False
        PopupMenuRight.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_RefreshData, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        Dim MenuExits As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenuRight.ItemLinks.Add(MenuExits, True)
        PopupMenuRight.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuRight.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_Vi_Tri_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Data_Right.Columns.Contains("Ma_Xe") Then Return
        iRow = MasterRightGRV.GetFocusedDataSourceRowIndex
        Dim _Ma_Xe As String = ""
        If iRow >= 0 Then _Ma_Xe = Dv_Data_Right.Item(iRow).Item("Ma_Xe")
        Dim Dt_Vitri As DataTable = CyberWork.V_Do_Xe(_Ma_Xe, "P", "3", "", AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

        If Dt_Vitri Is Nothing Then Return
        If Dt_Vitri.Rows.Count = 0 Then Return


        Dim _Ma_Xe_Up As String = ""
        Dim _Ma_Do_Up As String = ""
        Dim _Ten_Do_Up As String = ""

        If Dt_Vitri.Columns.Contains("Ma_Xe") Then _Ma_Xe_Up = Dt_Vitri.Rows(0).Item("Ma_Xe").ToString.Trim()
        If Dt_Vitri.Columns.Contains("Ma_Do") Then _Ma_Do_Up = Dt_Vitri.Rows(0).Item("Ma_Do").ToString.Trim()
        If Dt_Vitri.Columns.Contains("Ten_Do") Then _Ten_Do_Up = Dt_Vitri.Rows(0).Item("Ten_Do").ToString.Trim()
        If _Ma_Xe_Up = "" Or _Ma_Do_Up.Trim = "" Then Return

        Dim _Xe As Boolean = Dt_Data_Right.Columns.Contains("Ma_Xe")
        Dim _Do As Boolean = Dt_Data_Right.Columns.Contains("Ma_Do")
        Dim _Ten As Boolean = Dt_Data_Right.Columns.Contains("Ten_Do")

        If Not _Xe Then Return
        If Not _Do Then Return

        For i As Integer = 0 To Dt_Data_Right.Rows.Count - 1
            If Not Dt_Data_Right.Rows(i).Item("Ma_Xe").ToString.Trim.ToUpper = _Ma_Xe_Up.Trim.ToUpper.Trim Then Continue For
            Dt_Data_Right.Rows(i).BeginEdit()
            If _Do Then Dt_Data_Right.Rows(i).Item("Ma_Do") = _Ma_Do_Up
            If _Ten Then Dt_Data_Right.Rows(i).Item("Ten_Do") = _Ten_Do_Up
            Dt_Data_Right.Rows(i).EndEdit()
        Next
        Dt_Data_Right.AcceptChanges()

    End Sub
    Private Sub V_Vi_Tri_Xe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Data_Right.Columns.Contains("Ma_Xe") Then Return
        iRow = MasterRightGRV.GetFocusedDataSourceRowIndex
        Dim _Ma_Xe As String = ""
        If iRow >= 0 Then _Ma_Xe = Dv_Data_Right.Item(iRow).Item("Ma_Xe")
        V_Vi_Tri_Xe(_Ma_Xe)
    End Sub
    Dim ProccessList As New Collection
    Private Sub V_Vi_Tri_Xe(ByVal _Ma_Xe As String)
        CyberWork.V_Do_Xe_Load(_Ma_Xe, "P", "3", "", AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        'Dim CyberReport As New Cyber.Reports.Sys
        'Dim strAddParar As String = "CP_RO_Do_Xe_Load#" + _Ma_Xe + "##" + M_Ma_Dvcs + "#" + M_User_Name
        'Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Reports.dll", Me.Para, strAddParar)
        'If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
#End Region
#Region "Timer............."
    Private Function V_GetEnableTimer() As Boolean
        Dim _Return As Boolean = False
        If Timer_Data.Enabled Then _Return = True
        If _Return Then Timer_Data.Enabled = False
        Return _Return
    End Function
    Private Sub V_SetEnableTimer()
        Timer_Data.Enabled = True
    End Sub
    Private Sub V_Timer_Data_Change_RX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _TimeData As Decimal = CyberWork.V_GetvalueCombox(CbbTime_Data)
        If _TimeData <= 0 Then _TimeData = 3000
        Timer_Data.Interval = _TimeData
    End Sub
    Private Sub V_Auto_Data_Tien_Do(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer_Data.Enabled = ChkAuto_Data.Checked
        CbbTime_Data.Enabled = ChkAuto_Data.Checked
        Dim _TimeData As Decimal = CyberWork.V_StringToNumeric(CbbTime_Data)
        If _TimeData <= 0 Then _TimeData = 3000
        Timer_Data.Interval = _TimeData
    End Sub
    Private Sub V_Timer_Data(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Timer_Data.Enabled Then Exit Sub
        V_LoadData_Tien_Do("0", "")
    End Sub
    Private Sub V_Timer_PercentComplete(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Timer_PercentComplete.Enabled Then Exit Sub
        V_PercentComplete("", "")
        'abc
    End Sub
    Private Sub V_SetTimer()
        Dim _E As Boolean = False
        CbbTime_Data.Enabled = _E
    End Sub
    Private Sub V_EnabledTime(ByVal Chk As CheckBox, ByVal _Cbb As System.Windows.Forms.ComboBox, ByVal _Timer As Timer, ByVal _Value As Decimal)
        Dim _Chk As Boolean = Chk.Checked
        If _Value <= 0 Then _Chk = False
        _Cbb.Enabled = _Chk
        _Timer.Enabled = _Chk
        If Not _Chk Then Return
        If _Value <= 0 Then _Value = 3000
        _Timer.Interval = _Value
    End Sub
#End Region
#Region "----------Sự kiện - Tree; Tootltip"
    Private Sub ResourcesTree_CustomDrawNodeCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs)
        CyberSupport.ResourcesTree_CustomDrawNodeCell(sender, e, CyberColor)
    End Sub
    Private Sub ToolTipController_BeforeShow(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerShowEventArgs)
        'Handles ToolTipController1.BeforeShow
        Dim controller As DevExpress.Utils.ToolTipController = TryCast(sender, DevExpress.Utils.ToolTipController)
        Dim aptViewInfo As DevExpress.XtraScheduler.Drawing.AppointmentViewInfo = TryCast(controller.ActiveObject, DevExpress.XtraScheduler.Drawing.AppointmentViewInfo)
        If aptViewInfo Is Nothing Then
            Return
        End If
        Dim _Stt_Rec = aptViewInfo.Appointment.Id
        Dim dr() As DataRow = Dt_Data.Select("Stt_Rec = '" & _Stt_Rec & "'")
        If dr.Length < 1 Then
            Exit Sub
        End If
        Dim drDt As DataRow = dr(0)
        If ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip Then
            Dim SuperTip As New DevExpress.Utils.SuperToolTip()
            Dim args As New DevExpress.Utils.SuperToolTipSetupArgs()
            args.Title.Text = drDt("Ma_Xe").ToString
            args.Title.Font = New Font(Me.Font.FontFamily, 11, FontStyle.Bold)
            args.Title.Image = My.Resources.refresh2_16x16
            If drDt.Table.Columns.Contains("Dien_Giai") Then args.Contents.Text = drDt("Dien_Giai").ToString
            args.ShowFooterSeparator = True
            args.Footer.Font = New Font(Me.Font.FontFamily, 10)
            args.Footer.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True
            If drDt.Table.Columns.Contains("Tootip") Then args.Footer.Text = drDt("Tootip").ToString
            SuperTip.Setup(args)
            e.SuperTip = SuperTip
        End If
    End Sub
#End Region
End Class