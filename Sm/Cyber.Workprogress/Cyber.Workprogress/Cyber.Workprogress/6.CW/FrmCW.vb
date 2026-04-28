Imports DevExpress.XtraScheduler
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraScheduler.Drawing
Imports DevExpress.Utils
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraEditors
Public Class FrmCW
#Region "--------Bien"
    Dim Dt_ConFigColor, Dt_Timer_Data, Dt_Ngay_Tien_Do, Dt_Buoc_Nhay, Dt_Do_Rong, Dt_Kieu_Xem As DataTable
    Dim DmCVDV_Loc_KH_SCC, DmKhoang_Loc_KH_SCC As DataTable

    Dim DmCVDV_KH_SCC, Dm_Khoang As DataTable
    Dim Dv_DmCVDV_KH_SCC, Dv_Dm_Khoang As DataView
    Dim M_StartHour, M_FinishHour As Integer
    Dim M_StartMINUTE, M_FinishMINUTE As Integer
    Dim M_Ngay_LimitInterval_Min As Date
    Dim M_Ngay_LimitInterval_Max As Date
    Dim M_Thu_Bay As String = "0"
    Dim M_Chu_Nhat As String = "1"
    Dim M_Loai_KH As String = "3"
    Dim Dt_Time As DataTable
    Dim Dt_Ca_Ngay As DataTable
    Dim Dt_Gio_Xem As DataTable

    Public M_Loai_SC As String = "1"
    Public M_Tang As String = "1"
    Dim M_Ma_TTCP As String = ""

    '-----------------------------------------------------------------------------
    Dim EditMa_Xe_Cho, EditMa_Xe_Dang_Rua, EditMa_Xe_Rua_Xong As New Cyber.Fill.CyberColumnGridView
    '-----------------------------------------------------------------------------
#End Region
    Private Sub FrmCW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtM_Ngay_Ct.Value = Now.Date
        Timer_Data.Enabled = False
        ChkAuto_Data.Checked = False

        Dim M_VT_PARA As Integer = CType(Para(0).Trim, Integer)
        Try
            M_Loai_SC = Para(M_VT_PARA + 2).Trim
        Catch ex As Exception
        End Try
        Try
            M_Loai_KH = Para(M_VT_PARA + 3).Trim
        Catch ex As Exception
        End Try
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
        V_LoadDatabases("1", "")
        ''--------------------------------------------------------------------------------------------
        V_AddHander_Tien_Do()
        '--------------------------------------------------------------------------------------------
        V_Auto_Data_Tien_Do(New System.Object, New System.EventArgs)
        '--------------------------------------------------------------------------------------------
        V_GetColumn()
        '--------------------------------------------------------------------------------------------
        V_SetSchedulerControl()
        '--------------------------------------------------------------------------------------------
        V_Do_Rong(New System.Object, New System.EventArgs) 'Độ rộng của cột
        '--------------------------------------------------------------------------------------------
        V_SetRowHeight() ' RowPage trong bảng tiến độ
        '--------------------------------------------------------------------------------------------
        V_SetAppointmentHeight() ' Độ cao của chíp
        ''--------------------------------------------------------------------------------------------
        If M_LAN = "V" Then Me.Text = "BẢNG KẾ HOẠCH RỬA XE " Else Me.Text = " WASHING TABLE"
        '--------------------------------------------------------------------------------------------
        If Not M_LAN = "V" Then
            LabWait.Text = LabWait.Tag.ToString.Trim
            LabPlan.Text = LabPlan.Tag.ToString.Trim
            LabWash.Text = LabWash.Tag.ToString.Trim
            LabFinish.Text = LabFinish.Tag.ToString.Trim
        End If
    End Sub
#Region "Databases And System"
    Dim Dt_Cho_Rua, Dt_Dang_Rua, Dt_Rua_Xong, Dt_Data_Xe, Dt_Cho_Rua_H, Dt_Dang_Rua_H, Dt_Rua_Xong_H, Dt_Xe_H As DataTable
    Dim Dt_Data As DataTable, Dt_Data_Parent As DataTable

    Dim Dv_Cho_Rua, Dv_Dang_Rua, Dv_Rua_Xong, Dv_Data_Xe, Dv_Cho_Rua_H, Dv_Dang_Rua_H, Dv_Rua_Xong_H, Dv_Xe_H As DataView
    Dim Dv_Data, Dv_Data_Parent As DataView

    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub Tao_Ngam_Dinh()
        Dim _Dt_Ngay_Ct As Date = TxtM_Ngay_Ct.Value
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_ConFig", M_Loai_SC & "#" & M_Tang & "#" & _Dt_Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim iTb As Integer = 0
        '----ConFig
        Dt_ConFigColor = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1

        Dt_Timer_Data = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1

        Dt_Buoc_Nhay = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1

        Dt_Do_Rong = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1
        '---Danh muc        
        '-------------------------Khoang
        DmKhoang_Loc_KH_SCC = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1
        Dm_Khoang = DmKhoang_Loc_KH_SCC.Copy
        V_DeleteRowEmpty(Dm_Khoang, "Ma_Khoang")
        Dv_Dm_Khoang = New DataView(Dm_Khoang)
        '-------------------------Cố vấn dịch vụ
        DmCVDV_Loc_KH_SCC = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1

        DmCVDV_KH_SCC = DmCVDV_Loc_KH_SCC.Copy
        V_DeleteRowEmpty(DmCVDV_KH_SCC, "Ma_HS")
        Dv_DmCVDV_KH_SCC = New DataView(DmCVDV_KH_SCC)
        '----------------------------Kieu xem

        Dt_Kieu_Xem = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1
        '----------------------------
        Dt_Ca_Ngay = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1
        '----------------------------
        Dt_Gio_Xem = Dstmp.Tables(iTb).Copy
        iTb = iTb + 1




        '-----------------------------------------------------------------------------------------------------------------------------
        CyberFill.V_FillComBoxDefaul(CbbTime_Data, Dt_Timer_Data, "Tg", "Ten_TG", "Ngam_Dinh")

        CyberFill.V_FillComBoxDefaul(CbbMa_HS, DmCVDV_Loc_KH_SCC, "Ma_Hs", "Ten_Hs", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_BN, Dt_Buoc_Nhay, "Ma_BN", "Ten_BN", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbDo_Rong, Dt_Do_Rong, "Ma_Width", "Ten_Width", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbKieu_Xem, Dt_Kieu_Xem, "Kieu_Xem", "Ten_Kieu", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbCa_Ngay, Dt_Ca_Ngay, "Ca_Ngay", "Ten", "Default")
        CyberFill.V_FillComBoxDefaul(CbbGio_Xem, Dt_Gio_Xem, "Gio_Xem", "Ten", "Default")


        Dim _kieu_Xem As String = CyberWork.V_GetvalueCombox(CbbKieu_Xem)
        V_Kieu_Xem(_kieu_Xem)
        M_Ma_TTCP = CyberSupport.V_GetDefault_TTCP("PKH", M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        '-----------------------------------------------------------------------------------------------------------------------------
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
    Private Sub V_GetColumn()
        EditMa_Xe_Cho.GetColumn(MasterCho_RuaGRV, "Ma_XE")
        EditMa_Xe_Dang_Rua.GetColumn(MasterDang_RuaGRV, "Ma_XE")
        EditMa_Xe_Rua_Xong.GetColumn(MasterRua_XongGRV, "Ma_XE")
    End Sub
    Private Sub FCVDV_Xem_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_SetRowHeight()
    End Sub
    Private Sub V_LoadDatabases(ByVal status As String, ByVal _Stt_Rec As String)
        SchedulerStorage.Appointments.AutoReload = False
        SchedulerStorage.BeginUpdate()
        Dim _Dt As Date = TxtM_Ngay_Ct.Value
        Dim _Ca_Ngay As String = CbbCa_Ngay.SelectedValue.ToString

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_Data", status & "#" & _Ca_Ngay & "#" & M_Loai_KH & "#" & _Stt_Rec & "#" & _Dt.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If status = "1" Then
            Dim _Dt_Sort As DataTable
            Dim _Dr_Sort As DataRow()
            Dt_Cho_Rua = Nothing
            Dt_Data = Nothing
            Dt_Dang_Rua = Nothing
            Dt_Rua_Xong = Nothing

            Dt_Cho_Rua_H = Nothing
            Dt_Dang_Rua_H = Nothing
            Dt_Rua_Xong_H = Nothing
            '------------------------------------------------------------------------------------------------------------------------------
            _Dt_Sort = DsTmp.Tables(0).Copy
            '------------------------------------------
            Dt_Cho_Rua = DsTmp.Tables(1).Copy
            Dv_Cho_Rua = New DataView(Dt_Cho_Rua)

            _Dr_Sort = Nothing
            _Dr_Sort = _Dt_Sort.Select("Loai = '01'")
            If _Dr_Sort.Length > 0 Then CyberSupport.V_SetSortView(Dv_Cho_Rua, _Dr_Sort(0))

            '------------------------------------------
            Dt_Data = DsTmp.Tables(2).Copy
            Dv_Data = New DataView(Dt_Data)

            _Dr_Sort = Nothing
            _Dr_Sort = _Dt_Sort.Select("Loai = '02'")
            If _Dr_Sort.Length > 0 Then CyberSupport.V_SetSortView(Dv_Data, _Dr_Sort(0))

            '------------------------------------------
            Dt_Dang_Rua = DsTmp.Tables(3).Copy
            Dv_Dang_Rua = New DataView(Dt_Dang_Rua)

            _Dr_Sort = Nothing
            _Dr_Sort = _Dt_Sort.Select("Loai = '03'")
            If _Dr_Sort.Length > 0 Then CyberSupport.V_SetSortView(Dv_Dang_Rua, _Dr_Sort(0))

            '------------------------------------------
            Dt_Rua_Xong = DsTmp.Tables(4).Copy
            Dv_Rua_Xong = New DataView(Dt_Rua_Xong)

            _Dr_Sort = Nothing
            _Dr_Sort = _Dt_Sort.Select("Loai = '04'")
            If _Dr_Sort.Length > 0 Then CyberSupport.V_SetSortView(Dv_Rua_Xong, _Dr_Sort(0))

            '------------------------------------------
            Dt_Data_Xe = DsTmp.Tables(5).Copy
            Dv_Data_Xe = New DataView(Dt_Data_Xe)

            _Dr_Sort = Nothing
            _Dr_Sort = _Dt_Sort.Select("Loai = '05'")
            If _Dr_Sort.Length > 0 Then CyberSupport.V_SetSortView(Dv_Data_Xe, _Dr_Sort(0))

            '------------------------------------------------------------------------------------------------------------------------------
            Dt_Cho_Rua_H = DsTmp.Tables(6).Copy
            Dv_Cho_Rua_H = New DataView(Dt_Cho_Rua_H)

            Dt_Dang_Rua_H = DsTmp.Tables(7).Copy
            Dv_Dang_Rua_H = New DataView(Dt_Dang_Rua_H)

            Dt_Rua_Xong_H = DsTmp.Tables(8).Copy
            Dv_Rua_Xong_H = New DataView(Dt_Rua_Xong_H)
            '------------------------------------------------------------------------------------------------------------------------------

            If DsTmp.Tables.Count > 9 Then
                Dt_Xe_H = DsTmp.Tables(9).Copy
                Dv_Xe_H = New DataView(Dt_Xe_H)
            End If

            '------------------------------------------------------------------------------------------------------------------------------
            CyberFill.V_FillReports(MasterCho_RuaGRV, M_LAN, Dv_Cho_Rua_H, Dv_Cho_Rua)
            MasterCho_Rua.DataSource = Dv_Cho_Rua
            Me.MasterCho_RuaGRV.GridControl = Me.MasterCho_Rua

            MasterCho_RuaGRV.OptionsView.ShowViewCaption = False
            MasterCho_RuaGRV.OptionsSelection.MultiSelect = False
            Me.MasterCho_RuaGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen

            '------------------------------------------------------------------------------------------------------------------------------
            MasterDang_Rua.DataSource = Dv_Dang_Rua
            Me.MasterDang_RuaGRV.GridControl = Me.MasterDang_Rua
            CyberFill.V_FillReports(MasterDang_RuaGRV, M_LAN, Dv_Dang_Rua_H, Dv_Dang_Rua)
            MasterDang_RuaGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
            MasterDang_RuaGRV.OptionsSelection.MultiSelect = False

            '-------------------------------------------'-------------------------------------------
            MasterRua_Xong.DataSource = Dv_Rua_Xong
            Me.MasterRua_XongGRV.GridControl = Me.MasterRua_Xong
            CyberFill.V_FillReports(MasterRua_XongGRV, M_LAN, Dv_Rua_Xong_H, Dv_Rua_Xong)
            MasterRua_XongGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
            MasterRua_XongGRV.OptionsSelection.MultiSelect = False
            '-------------------------------------------'-------------------------------------------
        Else

            If _Stt_Rec.Trim = "" Then
                '----------------------------------------------
                Dt_Cho_Rua.Clear()
                Dt_Cho_Rua.Load(DsTmp.Tables(0).CreateDataReader)
                '----------------------------------------------
                Dt_Data.Clear()
                Dt_Data.Load(DsTmp.Tables(1).CreateDataReader)
                '----------------------------------------------
                Dt_Dang_Rua.Clear()
                Dt_Dang_Rua.Load(DsTmp.Tables(2).CreateDataReader)
                '----------------------------------------------
                Dt_Rua_Xong.Clear()
                Dt_Rua_Xong.Load(DsTmp.Tables(3).CreateDataReader)
                '----------------------------------------------                
                Dt_Data_Xe.Clear()
                Dt_Data_Xe.Load(DsTmp.Tables(4).CreateDataReader)
                '----------------------------------------------    
            Else
                '----------------------------------------------
                If Not Dt_Cho_Rua Is Nothing Then
                    V_Delete_Data(Dt_Cho_Rua, _Stt_Rec)
                    If DsTmp.Tables.Count > 0 Then Dt_Cho_Rua.Load(DsTmp.Tables(0).CreateDataReader)
                End If
                '----------------------------------------------
                If Not Dt_Data Is Nothing Then
                    V_Delete_Data(Dt_Data, _Stt_Rec)
                    If DsTmp.Tables.Count > 1 Then Dt_Data.Load(DsTmp.Tables(1).CreateDataReader)
                End If
                '----------------------------------------------
                If Not Dt_Dang_Rua Is Nothing Then
                    V_Delete_Data(Dt_Dang_Rua, _Stt_Rec)
                    If DsTmp.Tables.Count > 2 Then Dt_Dang_Rua.Load(DsTmp.Tables(2).CreateDataReader)
                End If
                '----------------------------------------------
                If Not Dt_Rua_Xong Is Nothing Then
                    V_Delete_Data(Dt_Rua_Xong, _Stt_Rec)
                    If DsTmp.Tables.Count > 3 Then Dt_Rua_Xong.Load(DsTmp.Tables(3).CreateDataReader)
                End If
                '----------------------------------------------
                If Not Dt_Data_Xe Is Nothing Then
                    V_Delete_Data(Dt_Data_Xe, _Stt_Rec)
                    If DsTmp.Tables.Count > 4 Then Dt_Data_Xe.Load(DsTmp.Tables(4).CreateDataReader)
                End If

            End If
        End If

        DsTmp.Dispose()
        SchedulerStorage.EndUpdate()
        V_Filter(New System.Object, New System.EventArgs)

        'V_PercentComplete(_Stt_Rec, _So_Ro)
        SchedulerControl.Storage.RefreshData()
        SchedulerStorage.Appointments.AutoReload = True
        V_Hieu_suat()
    End Sub
    Private Sub V_Hieu_suat()
        LabTy_Hieusuat.Text = ""
        Dim _Ngay_Ct As Date = TxtM_Ngay_Ct.Value
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_Tinh_Hieu_suat", M_Loai_SC + "#" + _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Columns.Contains("VISIBLE") Then LabTy_Hieusuat.Visible = IIf(Dstmp.Tables(0).Rows(0).Item("VISIBLE") = 1, True, False)
        If Dstmp.Tables(0).Columns.Contains("Hieusuat") Then LabTy_Hieusuat.Text = Dstmp.Tables(0).Rows(0).Item("Hieusuat")
        If Dstmp.Tables(0).Columns.Contains("BackColor") Then LabTy_Hieusuat.BackColor = CyberColor.GetBackColor(Dstmp.Tables(0).Rows(0).Item("BackColor"))
        If Dstmp.Tables(0).Columns.Contains("ForeColor") Then LabTy_Hieusuat.ForeColor = CyberColor.GetBackColor(Dstmp.Tables(0).Rows(0).Item("ForeColor"))
        Dstmp.Dispose()
    End Sub
    Private Sub V_Delete_Data(ByVal _Dt As DataTable, ByVal _Stt_Rec As String)
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
    Private Sub V_RefreshData(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabases("0", "")
    End Sub
    Private Sub V_Ngay_Ct_Tien_Do(ByVal sender As System.Object, ByVal e As System.EventArgs)

        V_Ngay_Ct_Tien_Do()
        '------------------------------------------------------------------------------------------------------------------
        V_LoadDatabases("0", "")
        '------------------------------------------------------------------------------------------------------------------
        V_SetSchedulerSetValue()
        '------------------------------------------------------------------------------------------------------------------
        V_SetSchedulerControl()
    End Sub
    Private Sub V_Ngay_Ct_Tien_Do()
        Dim _Ngay_Ct As Date = TxtM_Ngay_Ct.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_Ngay_Ngam_Dinh", M_Loai_SC + "#" + _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs + "#" & M_User_Name)

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
        Dim _Ca_Ngay As String = "01"
        _Ca_Ngay = CyberWork.V_GetvalueCombox(CbbCa_Ngay) '---  _Loai = "01" Cả ngày/_Loai = "02" Sáng/_Loai = "03" Chiều

        M_Thu_Bay = Dt_Ngay_Tien_Do.Rows(0).Item("Thu_Bay").ToString.Trim
        M_Chu_Nhat = Dt_Ngay_Tien_Do.Rows(0).Item("Chu_Nhat").ToString.Trim

        Select Case _Ca_Ngay
            Case "02" '---Sang
                M_StartHour = Dt_Ngay_Tien_Do.Rows(0).Item("H_Sang1")
                M_StartMINUTE = Dt_Ngay_Tien_Do.Rows(0).Item("M_Sang1")
                M_FinishHour = Dt_Ngay_Tien_Do.Rows(0).Item("H_Sang2")
                M_FinishMINUTE = Dt_Ngay_Tien_Do.Rows(0).Item("M_Sang2")
                M_Ngay_LimitInterval_Min = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Sang1")
                M_Ngay_LimitInterval_Max = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Sang2")
            Case "03" '---Chieu
                M_StartHour = Dt_Ngay_Tien_Do.Rows(0).Item("H_Chieu1")
                M_StartMINUTE = Dt_Ngay_Tien_Do.Rows(0).Item("M_Chieu1")

                M_FinishHour = Dt_Ngay_Tien_Do.Rows(0).Item("H_Chieu2")
                M_FinishMINUTE = Dt_Ngay_Tien_Do.Rows(0).Item("M_Chieu2")
                M_Ngay_LimitInterval_Max = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Chieu2")
            Case Else
                M_StartHour = Dt_Ngay_Tien_Do.Rows(0).Item("StartHour")
                M_FinishHour = Dt_Ngay_Tien_Do.Rows(0).Item("FinishHour")
                M_StartMINUTE = Dt_Ngay_Tien_Do.Rows(0).Item("StartMINUTE")
                M_FinishMINUTE = Dt_Ngay_Tien_Do.Rows(0).Item("FinishMINUTE")
                M_Ngay_LimitInterval_Min = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_LimitInterval_Min")
                M_Ngay_LimitInterval_Max = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_LimitInterval_Max")
        End Select

        SchedulerControl.LimitInterval.Start = M_Ngay_LimitInterval_Min
        SchedulerControl.LimitInterval.End = M_Ngay_LimitInterval_Max
        SchedulerControl.Start = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Ct")
        TxtM_Ngay_Ct.Value = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Ct")
    End Sub
    Private Sub V_Filter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '----------------------------------------------------------------------------------------
        Dim _StrFilter_Cho_KH As String = V_GetFilter_KH_SCC(Dt_Cho_Rua)
        Dim _StrFilter_Data_KH As String = V_GetFilter_KH_SCC(Dt_Data)
        Dim _StrFilter_Rua_Xong As String = V_GetFilter_KH_SCC(Dt_Rua_Xong)
        Dim _StrFilter_Xe As String = V_GetFilter_KH_SCC(Dt_Data_Xe)
        Dim _StrFilter_Dang_Rua As String = V_GetFilter_KH_SCC(Dt_Dang_Rua)
        '----------------------------------------------------------------------------------------
        Try
            Dv_Cho_Rua.RowFilter = _StrFilter_Cho_KH
        Catch ex As Exception
        End Try
        '----------------------------------------------------------------------------------------
        Try
            Dv_Data.RowFilter = _StrFilter_Data_KH
        Catch ex As Exception
        End Try
        '----------------------------------------------------------------------------------------
        Try
            Dv_Rua_Xong.RowFilter = _StrFilter_Rua_Xong
        Catch ex As Exception
        End Try
        '----------------------------------------------------------------------------------------
        Try
            Dv_Data_Xe.RowFilter = _StrFilter_Xe
        Catch ex As Exception
        End Try

        '----------------------------------------------------------------------------------------
        Try
            Dv_Dang_Rua.RowFilter = _StrFilter_Dang_Rua
        Catch ex As Exception
        End Try


        '----------------------------------------------------------------------------------------
        T_tinh_So_Xe_RX()
        '----------------------------------------------------------------------------------------
    End Sub
    Private Function V_GetFilter_KH_SCC(ByVal _DT_Filter As DataTable) As String
        Dim _StrFilter As String = "1=1"
        If _DT_Filter Is Nothing Then Return _StrFilter

        Dim _Ma_Hs As String = CyberWork.V_GetvalueCombox(CbbMa_HS)
        If _DT_Filter.Columns.Contains("Ma_Hs") And _Ma_Hs <> "" Then _StrFilter = _StrFilter + " AND Ma_Hs = '" + _Ma_Hs.Trim + "'"
        Dim _Ma_Xe As String = TxtMa_Xe.Text
        If _DT_Filter.Columns.Contains("Ma_Xe") And _Ma_Xe <> "" Then _StrFilter = _StrFilter + " AND Ma_Xe LIKE '*" + _Ma_Xe.Trim + "*'"
        Dim _So_RO As String = TxtSo_RO.Text
        If _DT_Filter.Columns.Contains("So_RO") And _So_RO <> "" Then _StrFilter = _StrFilter + " AND So_RO LIKE '*" + _So_RO.Trim + "*'"
        '------------------------------------------------        
        V_GetFilter_KH_SCC = _StrFilter


    End Function
    Private Sub T_tinh_So_Xe_RX()
        LabKQ_CR.Text = 0
        LabKQ_DR.Text = 0
        LabKQ_RX.Text = 0
        Dim _CR As Integer = 0
        Dim _DR As Integer = 0
        Dim _RX As Integer = 0
        Dim _TL As String = 0
        Dim _Tong_Xe As Integer = 0
        Dim _StrRX As String = ""
        '-------------------------------------------------------------------------------------
        _CR = Dv_Cho_Rua.Count
        _DR = Dv_Dang_Rua.Count
        _RX = Dv_Rua_Xong.Count
        _Tong_Xe = _CR + _DR + _RX
        '-------------------------------------------------------------------------------------

        LabKQ_CR.Text = _CR
        LabKQ_DR.Text = _DR
        If _Tong_Xe <> 0 Then _TL = CyberSupport.V_Round(_RX * 100 / _Tong_Xe, 0).ToString.Trim & "%" Else _TL = "0%"
        _StrRX = _RX.ToString.Trim & "/" + _Tong_Xe.ToString.Trim & " - " & _TL.Trim
        LabKQ_RX.Text = _StrRX
        '-------------------------------------------------------------------------------------
    End Sub
#End Region
#Region "AddHander"
    Private Sub V_AddHander_Tien_Do()
        V_AddHander_MasterCho_Rua()
        V_AddHander_MasterDang_Rua()
        V_AddHander_MasterRua_Xong()
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
        AddHandler SchedulerControl.DoubleClick, AddressOf V_BD_KT
        AddHandler SchedulerControl.PopupMenuShowing, AddressOf V_PopupMenu
        AddHandler SchedulerControl.EditAppointmentFormShowing, AddressOf CyberWork.V_Lap_F3F4

        ''---------------------------------------------------------------------------------------------------------------------
        ''-------------Timer
        AddHandler ChkAuto_Data.CheckedChanged, AddressOf V_Auto_Data_Tien_Do
        AddHandler CbbTime_Data.SelectedValueChanged, AddressOf V_Auto_Data_Tien_Do
        AddHandler Timer_Data.Tick, AddressOf V_Timer_Data
        AddHandler Timer_PercentComplete.Tick, AddressOf V_Timer_PercentComplete
        '---------------------------------------------------------------------------------------------------------------------
        AddHandler CbbMa_BN.SelectedValueChanged, AddressOf V_Buoc_Nhay
        AddHandler CbbDo_Rong.SelectedValueChanged, AddressOf V_Do_Rong
        AddHandler CbbCa_Ngay.SelectedIndexChanged, AddressOf V_Ca_Ngay
        AddHandler CbbKieu_Xem.SelectedIndexChanged, AddressOf V_Kieu_Xem
        AddHandler CbbGio_Xem.SelectedIndexChanged, AddressOf V_Gio_Xem
        AddHandler CmdRefresh.Click, AddressOf V_RefreshData
        AddHandler TxtM_Ngay_Ct.TextChanged, AddressOf V_Ngay_Ct_Tien_Do
        'Filter---------------------------------------------------------------------------------------------------------------------
        AddHandler CbbMa_HS.SelectedValueChanged, AddressOf V_Filter
        AddHandler TxtMa_Xe.TextChanged, AddressOf V_Filter
        AddHandler TxtSo_RO.TextChanged, AddressOf V_Filter
        '---------------------------------------------------------------------------------------------------------------------
        AddHandler ResourcesTree.CustomDrawNodeCell, AddressOf ResourcesTree_CustomDrawNodeCell
        AddHandler ResourcesTree.DoubleClick, AddressOf ResourcesTree_DoubleClick
        AddHandler ResourcesTree.PopupMenuShowing, AddressOf ResourcesTree_PopupMenuShowing
    End Sub
    Private Sub V_AddHander_MasterCho_Rua()

        AddHandler EditMa_Xe_Cho.EditColumn.Click, AddressOf V_Ma_Xe_Cho
        AddHandler MasterCho_RuaGRV.PopupMenuShowing, AddressOf MasterCho_RuaGRV_PopupMenuShowing
        AddHandler MasterCho_RuaGRV.RowCellStyle, AddressOf MasterCho_RuaGRV_RowCellStyle
    End Sub
    Private Sub V_AddHander_MasterDang_Rua()
        AddHandler EditMa_Xe_Dang_Rua.EditColumn.Click, AddressOf V_Ma_Xe_Dang_Rua
        AddHandler MasterDang_RuaGRV.PopupMenuShowing, AddressOf MasterDang_RuaGRV_PopupMenuShowing
        AddHandler MasterDang_RuaGRV.RowCellStyle, AddressOf MasterDang_RuaGRV_RowCellStyle
    End Sub
    Private Sub V_AddHander_MasterRua_Xong()
        AddHandler EditMa_Xe_Rua_Xong.EditColumn.Click, AddressOf V_Ma_Xe_Rua_Xong
        AddHandler MasterRua_XongGRV.PopupMenuShowing, AddressOf MasterRua_XongGRV_PopupMenuShowing
        AddHandler MasterRua_XongGRV.RowCellStyle, AddressOf MasterRua_XongGRV_RowCellStyle
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
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Bắt đầu/Kết thúc rửa xe", "Begin/End"), AddressOf V_BD_KT, Shortcut.F10, My.Resources.time_16x16, True, True), True).BeginGroup = False

        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Tạo KH rửa", "New"), AddressOf V_Tao_KH_Scheduler, Shortcut.F4, My.Resources.apply_16x16, True, True), True).BeginGroup = True
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Sửa KH rửa", "Edit"), AddressOf V_Sua_KH_Scheduler, Shortcut.F3, My.Resources.edit_16x16, True, True), True).BeginGroup = False
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xóa KH", "Delete"), AddressOf V_Xoa_KH_Scheduler, Shortcut.F8, My.Resources.deletelist_16x16, True, True), True).BeginGroup = False

        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem lệnh", "Preview"), AddressOf V_Preview_RX, Shortcut.F7, My.Resources.preview_16x16, True, True), True).BeginGroup = True
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_RefreshData, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        '-----------------
        Dim MenuOption As New CyberBarSubMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tùy chọn", "Option"), Nothing, My.Resources.managedatasource_16x16, True)
        PopupMenuSchedulerControl.ItemLinks.Add(MenuOption, True)
        Dim MenuOptionDay As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Theo cầu", "Day"), AddressOf V_ActiView_Day_RX, Nothing, True, False)
        Dim MenuOptionGantt As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thời gian", "Chart"), AddressOf V_ActiView_Gantt_RX, Nothing, True, False)

        MenuOption.AddItem(MenuOptionDay).BeginGroup = False
        MenuOption.AddItem(MenuOptionGantt).BeginGroup = False
        '-----------------
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), True).BeginGroup = True
        If Not e Is Nothing Then PopupMenuSchedulerControl.ShowPopup(Control.MousePosition)
    End Sub
#End Region

#Region "Scheduler"
    Dim CyberColor As New Cyber.Color.Sys
    Dim CyberWork As New Cyber.Workprogress.Sys

    Private Sub V_CyberSetTime_Tien_Do()
        V_Set_Ngay_Ct_Tien_Do()
        CyberSupport.V_CyberSetTime_Tien_Do(SchedulerControl, CyberWork.V_GetvalueCombox(CbbMa_BN), M_StartHour, M_StartMINUTE, M_FinishHour, M_FinishMINUTE, M_Ngay_LimitInterval_Min, M_Ngay_LimitInterval_Max, M_Thu_Bay, M_Chu_Nhat)
    End Sub
    Private Sub V_SetSchedulerControl()
        SchedulerControl.DateNavigationBar.Visible = False
        '------------------------------------------------------------------------
        Dim _Gio_Xem As String = CyberWork.V_GetvalueCombox(CbbGio_Xem)
        If _Gio_Xem = "01" Then
            SchedulerControl.ActiveViewType = SchedulerViewType.Gantt
            SchedulerControl.OptionsView.ResourceHeaders.Height = 80
        Else
            SchedulerControl.ActiveViewType = SchedulerViewType.Day
            SchedulerControl.OptionsView.ResourceHeaders.Height = 30
        End If

        SchedulerControl.Views.GanttView.Scales(6).Width = Dt_Ngay_Tien_Do.Rows(0).Item("HourWidth")
        SchedulerControl.Views.GanttView.ResourcesPerPage = Dt_Ngay_Tien_Do.Rows(0).Item("RowPage")
        '------------------------------------------------------------------------
        SchedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
        '------------------------------------------------------------------------
        V_SetSchedulerSetValue()
        '------------------------------------------------------------------------
        V_SetColorAppointments()
        '------------------------------------------------------------------------
        If Dm_Khoang.Columns.Contains("Color") Then SchedulerStorage.Resources.Mappings.Color = Dm_Khoang.Columns("Color").ColumnName.ToString.Trim
        If Dm_Khoang.Columns.Contains("Image") Then SchedulerStorage.Resources.Mappings.Image = Dm_Khoang.Columns("Image").ColumnName.ToString.Trim
        '------------------------------------------------------------------------
        Me.SchedulerStorage.Appointments.DataSource = Dv_Data
        Me.SchedulerStorage.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerStorage.Appointments.Mappings.AppointmentId = Dt_Data.Columns("Stt_Rec").ColumnName


        If Dt_Data.Columns.Contains("Dien_Giai") Then Me.SchedulerStorage.Appointments.Mappings.Description = Dt_Data.Columns("Dien_Giai").ColumnName
        Me.SchedulerStorage.Appointments.Mappings.Start = Dt_Data.Columns("Ngay_BD").ColumnName
        Me.SchedulerStorage.Appointments.Mappings.End = Dt_Data.Columns("Ngay_KT").ColumnName
        ''Me.SchedulerStorage_KH_RX.Appointments.Mappings.Label = Dt_Data.Columns("Id_backColor").ColumnName
        Me.SchedulerControl.Views.GanttView.AppointmentDisplayOptions.AutoAdjustForeColor = False



        If Dt_Data.Columns.Contains("Size_Border") Then Me.SchedulerStorage.Appointments.Mappings.Status = Dt_Data.Columns("Size_Border").ColumnName
        If Dt_Data.Columns.Contains("PercentComplete") Then Me.SchedulerStorage.Appointments.Mappings.PercentComplete = Dt_Data.Columns("PercentComplete").ColumnName Else SchedulerControl.Views.GanttView.AppointmentDisplayOptions.PercentCompleteDisplayType = PercentCompleteDisplayType.None
        If Dt_Data.Columns.Contains("Type") Then Me.SchedulerStorage.Appointments.Mappings.Type = Dt_Data.Columns("Type").ColumnName
        If Dt_Data.Columns.Contains("Tootip") Then Me.SchedulerStorage.Appointments.Mappings.Location = Dt_Data.Columns("Tootip").ColumnName Else If Dt_Data.Columns.Contains("Dien_Giai") Then Me.SchedulerStorage.Appointments.Mappings.Location = Dt_Data.Columns("Dien_Giai").ColumnName


        '------------------------------------------------------------------------

        SchedulerControl.GanttView.Appearance.Appointment.ForeColor = System.Drawing.Color.White
        'SchedulerControl_KH_SCC.GanttView.Appearance.Appointment.ForeColor = System.Drawing.Color.Red
        SchedulerControl.GanttView.Appearance.Appointment.Font = New System.Drawing.Font(SchedulerControl.DayView.Appearance.Appointment.Font.FontFamily, 8)

        SchedulerControl.DayView.Appearance.Appointment.ForeColor = System.Drawing.Color.White
        'SchedulerControl_KH_SCC.DayView.Appearance.Appointment.ForeColor = System.Drawing.Color.Red
        SchedulerControl.DayView.Appearance.Appointment.Font = New System.Drawing.Font(SchedulerControl.DayView.Appearance.Appointment.Font.FontFamily, 8)

        ''CustomDrawAppointment

        '------------------------------------------------------------------------
        SchedulerControl.Views.GanttView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Never
        SchedulerControl.Views.GanttView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Never
        SchedulerControl.Views.GanttView.AppointmentDisplayOptions.SnapToCellsMode = AppointmentSnapToCellsMode.Disabled

        SchedulerControl.Views.DayView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Never
        SchedulerControl.Views.DayView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Never
        SchedulerControl.Views.DayView.AppointmentDisplayOptions.SnapToCellsMode = AppointmentSnapToCellsMode.Disabled



    End Sub
    Private Sub V_SetSchedulerSetValue()
        Dim _Kieu_Xem As String = CyberWork.V_GetvalueCombox(CbbKieu_Xem)
        Dim _Ca_Ngay As String = CyberWork.V_GetvalueCombox(CbbCa_Ngay)
        Dim _Gio_Xem As String = CyberWork.V_GetvalueCombox(CbbGio_Xem)

        Dim _Do_Rong As Decimal = 50
        If _Ca_Ngay = "02" Then _Do_Rong = 120
        If _Kieu_Xem = "02" Then _Do_Rong = 120
        If _Gio_Xem = "01" Then _Do_Rong = 120

        '---2019.09.20
        Dim _ShowHead As Boolean = True
        If Not Dt_Kieu_Xem Is Nothing Then
            If Dt_Kieu_Xem.Columns.Contains("ShowHead") Then
                Dim _Dr() As DataRow = Dt_Kieu_Xem.Select("Kieu_Xem ='" + _Kieu_Xem + "'")
                If _Dr.Length > 0 Then If _Dr(0).Item("ShowHead") = 0 Then _ShowHead = False
            End If
        End If
        SchedulerControl.Views.GanttView.ShowResourceHeaders = _ShowHead
        '------Theo Khoang
        If _Kieu_Xem = "01" Then CyberSupport.V_SetScheduler(Dv_Data, Dv_Data_Parent, Dv_Dm_Khoang, "Ma_khoang", If(Dm_Khoang.Columns.Contains("Ten3"), "Ten3", "Ten_khoang"), "Ma_Xe", _Do_Rong, SchedulerControl, ResourcesTree, Nothing)
        '------Theo Xe
        If _Kieu_Xem = "02" Then CyberSupport.V_SetScheduler(Dv_Data, Dv_Data_Parent, Dv_Data_Xe, "Stt_Rec", "Ma_Xe", "Ma_Xe", _Do_Rong, SchedulerControl, ResourcesTree, Dt_Xe_H)

        If ResourcesTree.Visible Then
            SplitContainer5.SplitterDistance = 200
        Else
            SplitContainer5.SplitterDistance = 0
        End If
    End Sub
    Private Sub V_SetColorAppointments()
        For i = 0 To Dt_ConFigColor.Rows.Count - 1
            'SchedulerStorage.Appointments.Labels(i).Color = CyberColor.GetBackColor(Dt_ConFigColor.Rows(i).Item("BackColor"))
            'SchedulerStorage.Appointments.Labels(i).DisplayName = Dt_ConFigColor.Rows(i).Item("Ten_Color")
            'SchedulerStorage.Appointments.Labels(i).MenuCaption = Dt_ConFigColor.Rows(i).Item("Ten_Color")
            V_SetColorlabel(i, Dt_ConFigColor.Rows(i))
        Next
    End Sub
    Private Sub V_SetColorlabel(ByVal _i As Integer, ByVal _Dr As DataRow)

    End Sub
    Private Sub V_GetFromSetScheduler(ByRef _Ngay_BD As Date, ByRef _Ngay_KT As Date, ByRef _Ma_khoang As String, Optional ByVal _Appointment As Appointment = Nothing)
        Dim _Kieu_Xem As String = CyberWork.V_GetvalueCombox(CbbKieu_Xem)
        _Ngay_BD = Now.Date
        _Ngay_KT = Now.Date
        _Ma_khoang = ""
        If _Appointment Is Nothing Then
            _Ngay_BD = SchedulerControl.SelectedInterval.Start
            _Ngay_KT = SchedulerControl.SelectedInterval.End
        Else
            _Ngay_BD = _Appointment.Start
            _Ngay_KT = _Appointment.End
        End If
        Dim _Value As String = CyberSupport.GetvalueSelectedResource(_Appointment, SchedulerControl)
        If _Value.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Value = ""
        _Value = _Value.Replace("_THUCHIEN", "")

        Select Case _Kieu_Xem
            Case "01"
                _Ma_khoang = _Value
            Case Else
                _Ma_khoang = ""
        End Select
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

#Region "Scheduler: Drop/Drop/Resize"
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
        Dim _Value As String = CyberSupport.GetvalueSelectedResource(_Appointment, SchedulerControl)
        If _Value.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Value = ""
        _Ma_khoang = _Value
    End Sub

    Private Sub V_GetFromSetSchedulerOld(ByRef _ma_khoangOld As String, Optional ByVal _Appointment As Appointment = Nothing)
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
    Private Function V_Update_Keo_Tha_KH_RX(ByVal _Appointment As Appointment) As Boolean

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
        V_GetFromSetSchedulerOld(_ma_khoangOld, _Appointment)
        Dim _Tg_SC As Integer = CbbMa_BN.SelectedValue

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_Save_Keo_Tha", _Tg_SC.ToString.Trim.Replace(",", ".") & "#" & M_Loai_KH & "#" & _Stt_Rec & "#" & _ma_khoang & "#" & _ma_khoangOld & "#" & _
                                                                  _Ngay_Bd.ToString("yyyyMMdd HH:mm") & "#" & _Ngay_Kt.ToString("yyyyMMdd HH:mm") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN)
        DsTmp.Dispose()


        If _Return Then V_LoadDatabases("0", _Stt_Rec)

        Return _Return
    End Function
    Private Sub V_SchedulerControl_AppointmentDrop(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentDragEventArgs) '----Handles SchedulerControl_KH_SCC.AppointmentDrop
        Dim _Appointment As Appointment
        _Appointment = e.EditedAppointment
        Dim _Return As Boolean = V_Update_Keo_Tha_KH_RX(_Appointment)
        e.Allow = _Return
    End Sub
    Private Sub V_SchedulerControl_AppointmentResized(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentResizeEventArgs) '----Handles SchedulerControl_KH_SCC.AppointmentResized
        Dim _Appointment As Appointment
        _Appointment = e.EditedAppointment
        Dim _Return As Boolean = V_Update_Keo_Tha_KH_RX(_Appointment)
        e.Allow = _Return
        e.Handled = Not _Return
    End Sub
#End Region

#Region "Scheduler: View"
    Private Sub V_ActiView_Day_RX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.Day
        SchedulerControl.DayView.ShowDayHeaders = False
        V_CyberSetTime_Tien_Do()
        SchedulerControl.OptionsView.ResourceHeaders.Height = 30
    End Sub
    Private Sub V_ActiView_Gantt_RX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.Gantt
        V_CyberSetTime_Tien_Do()
        SchedulerControl.OptionsView.ResourceHeaders.Height = 80
    End Sub
    Private Sub V_ActiView_FullWeek_RX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.FullWeek
    End Sub
    Private Sub V_ActiView_Month_RX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.Month
    End Sub
    Private Sub V_ActiView_Agenda_RX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.Agenda
    End Sub
    Private Sub V_ActiView_Timeline_RX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.Timeline
    End Sub
    Private Sub V_ActiView_Week_RX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.Week
    End Sub
    Private Sub V_ActiView_WorkWeek_RX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.WorkWeek
    End Sub
#End Region

#Region "Tree"
    Private Sub ResourcesTree_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.PopupMenuShowingEventArgs) Handles ResourcesTree.PopupMenuShowing
        Dim rowHandle As Integer
        'If e Is Nothing Then
        '    rowHandle = -1
        'Else
        '    rowHandle = e.HitInfo.RowHandle
        'End If
        PopupMenuCho_Rua.ItemLinks.Clear()
        PopupMenuCho_Rua.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Cập nhập màu xe/Kiểu xe", "Location"), AddressOf V_Nhap_Mau_Xe_Tree, Shortcut.F4, My.Resources.apply_16x16, True, True), True).BeginGroup = False
        PopupMenuCho_Rua.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_RefreshData, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False

        Dim MenuExits As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenuCho_Rua.ItemLinks.Add(MenuExits, True)
        PopupMenuCho_Rua.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuCho_Rua.ShowPopup(Control.MousePosition)

    End Sub
    Private Sub V_Nhap_Mau_Xe_Tree(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dv As DataView = SchedulerStorage.Resources.DataSource
        If _Dv Is Nothing Then Return
        If Not _Dv.Table.Columns.Contains("Stt_Rec") Then Return
        Dim Notes As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim iRow As Integer = -1
        Try
            Notes = ResourcesTree.FocusedNode
            iRow = Notes.Id
        Catch ex As Exception

        End Try

        Dim _Stt_rec As String = ""
        Dim _Ma_Xe As String = ""
        If iRow >= 0 Then _Stt_rec = _Dv.Item(iRow).Item("Stt_Rec").ToString.Trim()
        If iRow >= 0 Then _Ma_Xe = _Dv.Item(iRow).Item("Ma_Xe").ToString.Trim()

        If _Stt_rec.Trim = "" Then Return

    End Sub
    Private Sub ResourcesTree_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ResourcesTree.Visible Then Return
        Dim _Dv As DataView = SchedulerStorage.Resources.DataSource
        If _Dv Is Nothing Then Return
        If Not _Dv.Table.Columns.Contains("Stt_Rec") Then Return
        Dim Notes As DevExpress.XtraTreeList.Nodes.TreeListNode
        Dim iRow As Integer = -1
        Try
            Notes = ResourcesTree.FocusedNode
            iRow = Notes.Id
        Catch ex As Exception

        End Try

        Dim _Stt_rec As String = ""
        If iRow >= 0 Then _Stt_rec = _Dv.Item(iRow).Item("Stt_Rec").ToString.Trim()
        If _Stt_rec.Trim = "" Then Return

        V_Thuc_Hien(_Stt_rec)
    End Sub
    Private Sub ResourcesTree_CustomDrawNodeCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs)
        CyberSupport.ResourcesTree_CustomDrawNodeCell(sender, e, CyberColor)
    End Sub
#End Region
#Region "Tao Moi/Sua/Xoa KH/Bat Dau/ket thuc rua xe"
#Region "Tạo mới"
    Private Sub V_Tao_KH_Scheduler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Mode As String = "M"
        Dim _Stt_rec As String = ""
        Dim _Ma_khoang As String = ""
        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End
        _Ma_khoang = SchedulerControl.SelectedResource.Id.ToString.Trim()
        V_GetFromSetScheduler(_Ngay_Bd, _Ngay_Kt, _Ma_khoang)
        Dim _Tg_SC As Integer = CbbMa_BN.SelectedValue
        Dim _Dt_Return As DataTable = CyberWork.V_KH_CW(M_Ma_TTCP, M_Loai_KH, _Mode, _Stt_rec, _Ma_khoang, _Ngay_Bd, _Ngay_Kt, _Tg_SC, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

        If _Dt_Return Is Nothing Then Return
        If _Dt_Return.Rows.Count = 0 Then Return
        If Not _Dt_Return.Columns.Contains("Stt_Rec") Then Return
        If _Dt_Return.Rows(0).Item("Stt_Rec").ToString.Trim = "" Then Return
        V_LoadDatabases("0", _Dt_Return.Rows(0).Item("Stt_Rec").ToString.Trim)

    End Sub
    Private Sub V_Tao_Cho_Rua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Mode As String = "M"
        Dim _Stt_rec As String = ""
        Dim _Ma_khoang As String = ""
        Dim _Ngay_Bd As Date
        Dim _Ngay_Kt As Date

        V_GetFromSetScheduler(_Ngay_Bd, _Ngay_Kt, _Ma_khoang)
        _Ngay_Bd = Now
        _Ngay_Kt = _Ngay_Bd.AddMinutes(10)
        Dim _Tg_SC As Integer = CbbMa_BN.SelectedValue

        Dim _Dt_Return As DataTable = CyberWork.V_KH_CW(M_Ma_TTCP, M_Loai_KH, _Mode, _Stt_rec, _Ma_khoang, _Ngay_Bd, _Ngay_Kt, _Tg_SC, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        If _Dt_Return Is Nothing Then Return
        If _Dt_Return.Rows.Count = 0 Then Return
        If Not _Dt_Return.Columns.Contains("Stt_Rec") Then Return

        If _Dt_Return.Rows(0).Item("Stt_Rec").ToString.Trim = "" Then Return
        V_LoadDatabases("0", _Dt_Return.Rows(0).Item("Stt_Rec").ToString.Trim)

    End Sub
#End Region
#Region "Sửa kế hoạch"
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

        Dim _Tg_SC As Integer = CbbMa_BN.SelectedValue
        Dim _Dt_Return As DataTable = CyberWork.V_KH_CW(M_Ma_TTCP, M_Loai_KH, _Mode, _Stt_Rec, _Ma_khoang, _Ngay_Bd, _Ngay_Kt, _Tg_SC, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        If _Dt_Return Is Nothing Then Return
        If _Dt_Return.Rows.Count = 0 Then Return
        If Not _Dt_Return.Columns.Contains("Stt_Rec") Then Return
        If _Dt_Return.Rows(0).Item("Stt_Rec").ToString.Trim = "" Then Return
        V_LoadDatabases("0", _Dt_Return.Rows(0).Item("Stt_Rec").ToString.Trim)


    End Sub
    Private Sub V_Sua_Cho_Rua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Cho_Rua.Columns.Contains("Stt_Rec") Then Return
        iRow = MasterCho_RuaGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Mode As String = "S"
        Dim _Stt_Rec As String = Dv_Cho_Rua.Item(iRow).Item("Stt_Rec")
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


        Dim _Tg_SC As Integer = CbbMa_BN.SelectedValue

        Dim _Dt_Return As DataTable = CyberWork.V_KH_CW(M_Ma_TTCP, M_Loai_KH, _Mode, _Stt_Rec, _Ma_khoang, _Ngay_Bd, _Ngay_Kt, _Tg_SC, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        If _Dt_Return Is Nothing Then Return
        If _Dt_Return.Rows.Count = 0 Then Return
        If Not _Dt_Return.Columns.Contains("Stt_Rec") Then Return
        If _Dt_Return.Rows(0).Item("Stt_Rec").ToString.Trim = "" Then Return
        V_LoadDatabases("0", _Dt_Return.Rows(0).Item("Stt_Rec").ToString.Trim)

    End Sub
#End Region
#Region "Xóa kế hoạch"
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
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_Delete", _Stt_Rec + "#" + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), Sysvar, M_LAN) Then
            Dstmp.Dispose()
            Return
        End If
        V_LoadDatabases("0", _Stt_Rec)

    End Sub
    Private Sub V_Xoa_Cho_Rua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Cho_Rua.Columns.Contains("Stt_Rec") Then Return
        iRow = MasterCho_RuaGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Mode As String = "S"
        Dim _Stt_Rec As String = Dv_Cho_Rua.Item(iRow).Item("Stt_Rec")
        If _Stt_Rec.ToString.Trim = "" Then Return
        If Not CyberWork.V_Msgbox_Delete(Me.Sysvar, "Bạn có chắc chắn xóa không?") Then Return
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_Delete", _Stt_Rec + "#" + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), Sysvar, M_LAN) Then
            Dstmp.Dispose()
            Return
        End If
        V_LoadDatabases("0", _Stt_Rec)

    End Sub
#End Region
#Region "Bắt đầu/Kết thúc"
    Private Function V_Thuc_Hien(ByVal _Stt_Rec As String) As Boolean
        If _Stt_Rec.Trim = "" Then Return False
        Dim _Tg_SC As Integer = CbbMa_BN.SelectedValue

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_BD_KT", _Tg_SC.ToString.Trim.Replace(",", ".").Replace(" ", "") & "#" & _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim _Return As Boolean = CyberSupport.V_MsgChk(Dstmp.Tables(0), Sysvar, M_LAN)
        If _Return Then V_LoadDatabases("0", _Stt_Rec)
        Return _Return
    End Function
    Private Sub V_BD_KT_Cho_Rua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Cho_Rua.Columns.Contains("Stt_Rec") Then Return
        iRow = MasterCho_RuaGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Cho_Rua.Item(iRow).Item("Stt_Rec")
        If _Stt_Rec.ToString.Trim = "" Then Return
        V_Thuc_Hien(_Stt_Rec)
    End Sub
    Private Sub V_Ma_Xe_Cho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterCho_RuaGRV.GetFocusedDataSourceRowIndex

        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = ""
        _Stt_Rec = Dv_Cho_Rua.Item(iRow).Item("Stt_Rec").ToString.Trim

        If _Stt_Rec.Trim = "" Then Return
        V_Thuc_Hien(_Stt_Rec)
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
    Private Sub V_BD_KT_Dang_Rua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Dang_Rua.Columns.Contains("Stt_Rec") Then Return
        iRow = MasterDang_RuaGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Dang_Rua.Item(iRow).Item("Stt_Rec")
        If _Stt_Rec.ToString.Trim = "" Then Return

        V_Thuc_Hien(_Stt_Rec)
    End Sub
    Private Sub V_Ma_Xe_Dang_Rua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterDang_RuaGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = ""
        _Stt_Rec = Dv_Dang_Rua.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec.Trim = "" Then Return
        V_Thuc_Hien(_Stt_Rec)
    End Sub
#End Region
    Private Sub V_Quay_Ra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_Preview_RX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Return
        If _Stt_Rec.ToString.Trim = "" Then Return
        Dim _Ma_Ct As String = ""
        Dim _Drs As DataRow() = Dt_Data.Select("Stt_Rec = '" + _Stt_Rec + "'")
        If _Drs.Length <= 0 Then Return
        _Ma_Ct = _Drs(0).Item("Ma_Ct").ToString.Trim
        If Not (_Ma_Ct = "HDK" Or _Ma_Ct = "HDP" Or _Ma_Ct = "HDM") Then Return

        CyberWork.V_PreviewLenh("CW", M_Loai_SC, _Stt_Rec, _Stt_Rec, M_Ma_Dvcs, M_User_Name, Me.Para, AppConn, Me.Sysvar, M_LAN, CyberSmlib, CyberVoucher, CyberSupport)

    End Sub
    Private Sub V_Preview_Cho_Rua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Cho_Rua.Columns.Contains("Stt_Rec") Then Return
        iRow = MasterCho_RuaGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Mode As String = "S"
        Dim _Stt_Rec As String = Dv_Cho_Rua.Item(iRow).Item("Stt_Rec")
        If _Stt_Rec.ToString.Trim = "" Then Return
        Dim _Ma_Ct As String = ""
        _Ma_Ct = Dv_Cho_Rua.Item(iRow).Item("Ma_Ct")
        If Not (_Ma_Ct = "HDK" Or _Ma_Ct = "HDP" Or _Ma_Ct = "HDM") Then Return
        CyberWork.V_PreviewLenh("CW", M_Loai_SC, _Stt_Rec, _Stt_Rec, M_Ma_Dvcs, M_User_Name, Me.Para, AppConn, Me.Sysvar, M_LAN, CyberSmlib, CyberVoucher, CyberSupport)

    End Sub
    Private Sub V_Preview_Dang_Rua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Dang_Rua.Columns.Contains("Stt_Rec") Then Return
        iRow = MasterDang_RuaGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Mode As String = "S"
        Dim _Stt_Rec As String = Dv_Dang_Rua.Item(iRow).Item("Stt_Rec")
        If _Stt_Rec.ToString.Trim = "" Then Return
        Dim _Ma_Ct As String = ""
        _Ma_Ct = Dv_Dang_Rua.Item(iRow).Item("Ma_Ct")
        If Not (_Ma_Ct = "HDK" Or _Ma_Ct = "HDP" Or _Ma_Ct = "HDM") Then Return
        CyberWork.V_PreviewLenh("CW", M_Loai_SC, _Stt_Rec, _Stt_Rec, M_Ma_Dvcs, M_User_Name, Me.Para, AppConn, Me.Sysvar, M_LAN, CyberSmlib, CyberVoucher, CyberSupport)

    End Sub
#End Region
#Region "GRV - Cho Rua Xe"
    Private Sub MasterCho_RuaGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuCho_Rua.ItemLinks.Clear()
        PopupMenuCho_Rua.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Bắt đầu/Kết thúc rửa xe", "Begin/End"), AddressOf V_BD_KT_Cho_Rua, Shortcut.F10, My.Resources.time_16x16, True, True), True).BeginGroup = False
        PopupMenuCho_Rua.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Tạo KH rửa", "New"), AddressOf V_Tao_Cho_Rua, Shortcut.F4, My.Resources.apply_16x16, True, True), True).BeginGroup = True
        PopupMenuCho_Rua.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Sửa KH rửa", "Edit"), AddressOf V_Sua_Cho_Rua, Shortcut.F3, My.Resources.edit_16x16, True, True), True).BeginGroup = False
        PopupMenuCho_Rua.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xóa KH", "Delete"), AddressOf V_Xoa_Cho_Rua, Shortcut.F8, My.Resources.deletelist_16x16, True, True), True).BeginGroup = False
        PopupMenuCho_Rua.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem lệnh", "Preview"), AddressOf V_Preview_Cho_Rua, Shortcut.F7, My.Resources.preview_16x16, True, True), True).BeginGroup = True
        PopupMenuCho_Rua.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_RefreshData, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenuCho_Rua.ItemLinks.Add(MenuExits, True)
        PopupMenuCho_Rua.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuCho_Rua.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub MasterCho_RuaGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterCho_RuaGRV, Dt_Cho_Rua, Me.Font)
    End Sub
#End Region
#Region "Dang rua"
    Private Sub MasterDang_RuaGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuDang_Rua.ItemLinks.Clear()
        PopupMenuDang_Rua.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Bắt đầu/Kết thúc rửa xe", "Begin/End"), AddressOf V_BD_KT_Dang_Rua, Shortcut.F10, My.Resources.time_16x16, True, True), True).BeginGroup = True
        PopupMenuDang_Rua.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem lệnh", "Preview"), AddressOf V_Preview_Dang_Rua, Shortcut.F7, My.Resources.preview_16x16, True, True), True).BeginGroup = True
        PopupMenuDang_Rua.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_RefreshData, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenuDang_Rua.ItemLinks.Add(MenuExits, True)
        PopupMenuDang_Rua.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuDang_Rua.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub MasterDang_RuaGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterDang_RuaGRV, Dt_Dang_Rua, Me.Font)
    End Sub
#End Region
#Region "GRV - Rua xong"
    Private Sub MasterRua_XongGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenuRua_Xong.ItemLinks.Clear()


        PopupMenuRua_Xong.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Đặt vị trí xe", "Location"), AddressOf V_Vi_Tri_Xe, Shortcut.F4, My.Resources.apply_16x16, True, True), True).BeginGroup = False
        PopupMenuRua_Xong.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem vị trí xe", "Set Location"), AddressOf V_Vi_Tri_Xe_Load, Shortcut.F10, My.Resources.preview_16x16, True, True), True).BeginGroup = False

        PopupMenuRua_Xong.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Giao xe", "Delivered"), AddressOf V_Giao_Xe, Shortcut.F3, My.Resources.edit_16x16, True, True), True).BeginGroup = False

        PopupMenuRua_Xong.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem lệnh", "Preview"), AddressOf V_Preview_Rua_Xong, Shortcut.F7, My.Resources.preview_16x16, True, True), True).BeginGroup = True
        PopupMenuRua_Xong.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_RefreshData, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False

        Dim MenuExits As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenuRua_Xong.ItemLinks.Add(MenuExits, True)
        PopupMenuRua_Xong.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuRua_Xong.ShowPopup(Control.MousePosition)

    End Sub
    Private Sub MasterRua_XongGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterRua_XongGRV, Dt_Rua_Xong, Me.Font)
    End Sub
    Private Sub V_Vi_Tri_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Rua_Xong.Columns.Contains("Ma_Xe") Then Return
        iRow = MasterRua_XongGRV.GetFocusedDataSourceRowIndex
        Dim _Ma_Xe As String = ""
        If iRow >= 0 Then _Ma_Xe = Dv_Rua_Xong.Item(iRow).Item("Ma_Xe")

        Dim Dt_Vitri As DataTable = CyberWork.V_Do_Xe(_Ma_Xe, M_Loai_KH, M_Loai_SC, "", AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, _
                                     CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

        If Dt_Vitri Is Nothing Then Return
        If Dt_Vitri.Rows.Count = 0 Then Return
        If Not Dt_Vitri.Columns.Contains("Ma_Xe") Or Not Dt_Vitri.Columns.Contains("Ma_Do") Then Return

        Dim _Ma_Xe_Up As String = Dt_Vitri.Rows(0).Item("Ma_Xe").ToString.Trim
        Dim _Ma_Do_Up As String = Dt_Vitri.Rows(0).Item("Ma_Do").ToString.Trim
        Dim _Ten_Do_Up As String = ""
        If Dt_Vitri.Columns.Contains("Ten_Do") Then _Ten_Do_Up = Dt_Vitri.Rows(0).Item("Ten_Do").ToString.Trim()
        For i As Integer = 0 To Dt_Rua_Xong.Rows.Count - 1
            If Dt_Rua_Xong.Rows(i).Item("ma_Xe").ToUpper.Trim = _Ma_Xe_Up.ToUpper.Trim Then
                Dt_Rua_Xong.Rows(i).BeginEdit()
                If Dt_Rua_Xong.Columns.Contains("Ma_Do") Then Dt_Rua_Xong.Rows(i).Item("Ma_Do") = _Ma_Do_Up
                If Dt_Rua_Xong.Columns.Contains("Ten_Do") Then Dt_Rua_Xong.Rows(i).Item("Ten_Do") = _Ten_Do_Up
                Dt_Rua_Xong.Rows(i).EndEdit()
            End If
        Next
        Dt_Rua_Xong.AcceptChanges()
    End Sub
    Dim ProccessList As New Collection
    Private Sub V_Vi_Tri_Xe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Rua_Xong.Columns.Contains("Ma_Xe") Then Return
        iRow = MasterRua_XongGRV.GetFocusedDataSourceRowIndex
        Dim _Ma_Xe As String = ""
        If iRow >= 0 Then _Ma_Xe = Dv_Rua_Xong.Item(iRow).Item("Ma_Xe")
        V_Vi_Tri_Xe(_Ma_Xe)
    End Sub
    Private Sub V_Vi_Tri_Xe(ByVal _Ma_Xe As String)
        CyberWork.V_Do_Xe_Load(_Ma_Xe, "P", "3", "", AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

        'Dim CyberReport As New Cyber.Reports.Sys
        'Dim strAddParar As String = "CP_Work_Do_Xe_Load#" + _Ma_Xe + "##" + M_Ma_Dvcs + "#" + M_User_Name
        'Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Reports.dll", Me.Para, strAddParar)
        'If Not _Process Is Nothing Then ProccessList.Add(_Process)

    End Sub
    Private Sub V_Ma_Xe_Rua_Xong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterRua_XongGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Ma_Xe As String = ""
        _Ma_Xe = Dv_Rua_Xong.Item(iRow).Item("Ma_Xe").ToString.Trim
        V_Vi_Tri_Xe(_Ma_Xe)
    End Sub
    Private Sub V_Giao_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Rua_Xong.Columns.Contains("Stt_Rec") Then Return
        iRow = MasterRua_XongGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Rua_Xong.Item(iRow).Item("Stt_Rec")
        If _Stt_Rec.ToString.Trim = "" Then Return
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_Giai_phong", _Stt_Rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), Me.Sysvar, M_LAN) Then
            Dstmp.Dispose()
            Return
        End If
        Dstmp.Dispose()
        V_LoadDatabases("0", _Stt_Rec)

    End Sub
    Private Sub V_Preview_Rua_Xong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Rua_Xong.Columns.Contains("Stt_Rec") Then Return
        iRow = MasterRua_XongGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Rua_Xong.Item(iRow).Item("Stt_Rec")
        If _Stt_Rec.ToString.Trim = "" Then Return

        Dim _Ma_Ct As String = ""
        _Ma_Ct = Dv_Rua_Xong.Item(iRow).Item("Ma_Ct")
        If Not (_Ma_Ct = "HDK" Or _Ma_Ct = "HDP" Or _Ma_Ct = "HDM") Then Return
        CyberWork.V_PreviewLenh("CW", M_Loai_SC, _Stt_Rec, _Stt_Rec, M_Ma_Dvcs, M_User_Name, Me.Para, AppConn, Me.Sysvar, M_LAN, CyberSmlib, CyberVoucher, CyberSupport)
    End Sub
#End Region
#Region "Bước nhảy, độ rộng, phần trăm"
    Private Sub V_Buoc_Nhay(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_CyberSetTime_Tien_Do()
        V_Do_Rong(sender, e)
    End Sub
    Private Sub V_Do_Rong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SchedulerControl.ActiveViewType = SchedulerViewType.Gantt Then
            For i = 0 To 6
                If SchedulerControl.GanttView.Scales(i).Visible Then SchedulerControl.Views.GanttView.Scales(i).Width = CyberWork.V_GetvalueCombox(CbbDo_Rong)
            Next
        End If
        If SchedulerControl.ActiveViewType = SchedulerViewType.Day Then SchedulerControl.DayView.RowHeight = CyberWork.V_GetvalueCombox(CbbDo_Rong)
    End Sub
    Private Sub V_PercentComplete(Optional ByVal _Stt_rec As String = "", Optional ByVal _So_Ro As String = "")
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
        CyberSupport.V_SetRowHeight(SchedulerControl, _RowHeight, _RowPage, Sysvar)
    End Sub
#End Region

#Region "Kiểu xem (Khoang/Xe); (Sáng/chiều/Cả ngày); Theo giờ/theo khoang"
    Private Sub V_Kieu_Xem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Kieu_xem As String = CbbKieu_Xem.SelectedValue.ToString
        V_Kieu_Xem(_Kieu_xem)
        V_SetSchedulerSetValue()
    End Sub
    Private Sub V_Kieu_Xem(ByVal _Kieu_Xem As String)
        If _Kieu_Xem = "02" Then CbbGio_Xem.SelectedValue = "01"
        CbbGio_Xem.Enabled = _Kieu_Xem = "01"
    End Sub
    Private Sub V_Ca_Ngay(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_CyberSetTime_Tien_Do()
        V_Do_Rong(sender, e)
        V_LoadDatabases("0", "")
    End Sub
    Private Sub V_Gio_Xem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Gio_Xem As String = CyberWork.V_GetvalueCombox(CbbGio_Xem)
        If _Gio_Xem = "01" Then V_ActiView_Gantt_RX(sender, e)
        If _Gio_Xem = "02" Then V_ActiView_Day_RX(sender, e)
    End Sub
#End Region
#Region "Timer............."
    Private Function V_GetEnableTimer_KH_RX() As Boolean
        Dim _Return As Boolean = False
        If Timer_Data.Enabled Then _Return = True
        If _Return Then Timer_Data.Enabled = False
        Return _Return
    End Function
    Private Sub V_SetEnableTimer_KH_RX()
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
        V_LoadDatabases("0", "")
    End Sub

    Private Sub V_Timer_PercentComplete(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Timer_PercentComplete.Enabled Then Exit Sub
        V_PercentComplete("", "")
        'abc
    End Sub

    Private Sub V_SetTimer_RX()
        Dim _E As Boolean = False
        CbbTime_Data.Enabled = _E
    End Sub
    Private Sub V_EnabledTime_RX(ByVal Chk As CheckBox, ByVal _Cbb As System.Windows.Forms.ComboBox, ByVal _Timer As Timer, ByVal _Value As Decimal)
        Dim _Chk As Boolean = Chk.Checked
        If _Value <= 0 Then _Chk = False
        _Cbb.Enabled = _Chk
        _Timer.Enabled = _Chk
        If Not _Chk Then Return
        If _Value <= 0 Then _Value = 3000
        _Timer.Interval = _Value
    End Sub
#End Region
End Class
