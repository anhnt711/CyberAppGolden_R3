Imports System.Windows.Forms
Imports System.Drawing

Public Class ROXPT
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim FileName As String
    Dim DsData As New DataSet
    Dim tbMaster, tbHeader, tbHeader_DaXuat As New DataTable
    Dim DvMaster, DvHeader, DvHeader_DaXuat As New DataView
    Dim DsTmpDetal As New DataSet

    Dim Dt_Ro, Dt_Ro_H As DataTable
    Dim Dv_Ro, Dv_Ro_H As DataView


    Dim Dt_Ro1, Dt_Ro_H1 As DataTable
    Dim Dv_Ro1, Dv_Ro_H1 As DataView

    Dim _SL_Xuat_Pick, _SL_Xuat As Double
    Dim M_Stt_Rec, M_Stt_Rec0 As String
    Dim _StrSave As String = ""
    Dim Dt_Timer_Data As DataTable
    '--------
    Dim M_Chk_Defa As String = ""
    Dim M_Ma_TTCP As String = ""

#Region "Columns Edit"
    Dim EditMa_VT, EditMa_Kho_I, EditMa_Vv_I, EditMa_phi_i, EditMa_HD_I, EditMa_Sp_I, EditMa_ku_I, EditMa_TTLN_i, EditMa_TTCP_i, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I, EditMa_TD1_I, EditMa_TD2_I, EditMa_TD3_I, EditMa_TD4_I, EditMa_TD5_I As New Cyber.Fill.CyberColumnGridView
    Dim EditTen_Vt, EditDvt, EditSL_Ton, EditSL_RO, EditSL_Xuat, EditSL_Da_Xuat, EditSL_Xuat_Pick, EditSL_Da_Xuat_Pick, EditSL_CL, EditGia2, EditThue, EditTien2, EditSo_RO As New Cyber.Fill.CyberColumnGridView
#End Region
    Private Sub ROXPT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        '---------------------------------------------------------------------------------------------
        V_Load()
        '---------------------------------------------------------------------------------------------
        V_GetColumn()
        '---------------------------------------------------------------------------------------------
        V_LoadDatases_Ngam_Dinh()
        '---------------------------------------------------------------------------------------------
        V_AddHandler()
        '---------------------------------------------------------------------------------------------
        V_Fill_Data()
        '---------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '---------------------------------------------------------------------------------------------
        M_Ma_TTCP = CyberSupport.V_GetDefault_TTCP("PKH", M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)

    End Sub
    Private Sub V_Fill_Data()
        CyberFill.V_FillComBoxDefaul(CbbTime_Data, Dt_Timer_Data, "Tg", "Ten_TG", "Ngam_Dinh")
    End Sub
    Private Sub V_LoadDatases_Ngam_Dinh()
        'Dim _Dt As Date = TxtM_Ngay_Ct.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RO_XPT_Load_Ngam_Dinh", M_Ma_Dvcs & "#" & M_User_Name)
        Dt_Timer_Data = DsTmp.Tables(0).Copy
        '-----------------
        DsTmp.Dispose()
        '----------------------
        Dim M_Chk_Defa As String = Me.Para(M_VT_PARA + 2).Trim
        If M_Chk_Defa = "1" Then ChkPick.Checked = True
    End Sub
#Region "Load and System...."
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_AddHandler()
        V_AddHandler_System()
        V_AddHandler_Master()
        V_AddHandler_Detail()
    End Sub
    Private Sub V_AddHandler_System()

    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler TxtSo_Ro.Leave, AddressOf L_So_RO
        AddHandler CmDanh_Sach.Click, AddressOf V_Sanh_Sach
        AddHandler CmdXemPhieuXuat.Click, AddressOf V_XemPhieuXuat
        AddHandler DetailGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle

        AddHandler ChkAuto_Data.CheckedChanged, AddressOf V_Auto_Data
        AddHandler Timer_Data.Tick, AddressOf V_Timer_Data

        AddHandler ChkPick.CheckedChanged, AddressOf V_ChkPick
        AddHandler TxtSo_Ro.KeyDown, AddressOf EnterasTab

        AddHandler Chk_S.CheckedChanged, AddressOf V_Timer_Data
        AddHandler Chk_P.CheckedChanged, AddressOf V_Timer_Data
        AddHandler Chk_B.CheckedChanged, AddressOf V_Timer_Data

        AddHandler ChkHen_SCC.CheckedChanged, AddressOf V_Timer_Data
        AddHandler ChkHen_SBD.CheckedChanged, AddressOf V_Timer_Data
        AddHandler ChkHen_SDS.CheckedChanged, AddressOf V_Timer_Data

        AddHandler TxtMa_HS_H.CyberValiting, AddressOf V_Ma_Hs_H
        AddHandler TxtMa_HS_H.CyberLeave, AddressOf L_Ma_Hs_H
    End Sub
    Private Sub V_AddHandler_Detail()
        AddHandler DetailGRV.PopupMenuShowing, AddressOf DetailGRV_PopupMenuShowing
        AddHandler DetailGRV1.PopupMenuShowing, AddressOf DetailGRV1_PopupMenuShowing
        '--------------------------

        '--------------------------
        AddHandler DetailGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler DetailGRV1.RowCellStyle, AddressOf MasterGRV_RowCellStyle

        AddHandler DetailGRV1.FocusedRowChanged, AddressOf V_DetailGRV1_FocusedRowChanged
        '--------------------------
    End Sub
#End Region
    Private Sub V_DetailGRV1_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        If DetailGRV1.RowCount = 0 Then Exit Sub
        Dim selectedRow As DataRowView = Nothing
        selectedRow = DetailGRV1.GetFocusedRow
        TxtSo_Ro.Text = selectedRow("So_Ro").ToString()
        Dim _Dt As Date = Now.Date
        TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, "HDK", "S", "M", _Dt, TxtSo_Ro.Text, M_Ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        V_Loaddatatabse("0", TxtSo_Ro.Text)
        UpdateList()

    End Sub
    Private Sub V_DetailGRV1_FocusedRowChanged(ByVal DetailGRV1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Dv_Master As DataView, ByVal Dv_DetailTmp As DataView)
        Dim selectedRow As DataRowView = Nothing
        selectedRow = DetailGRV1.GetFocusedRow
        TxtSo_Ro.Text = selectedRow("So_Ro").ToString()
    End Sub
    Private Sub V_Auto_Data(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer_Data.Enabled = ChkAuto_Data.Checked
        CbbTime_Data.Enabled = ChkAuto_Data.Checked
        Dim _TimeData As Decimal = CbbTime_Data.SelectedValue
        If _TimeData <= 0 Then _TimeData = 3000
        Timer_Data.Interval = _TimeData
        If ChkAuto_Data.Checked = True Then
            Timer_Data.Start()
        Else
            Timer_Data.Stop()
        End If
    End Sub
    Private Sub V_Timer_Data(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _load As String = "3"
        Dim _load1 As String = "4"

        If ChkHen_SBD.Checked = True And ChkHen_SCC.Checked = False And ChkHen_SDS.Checked = False Then _load = "0"
        If ChkHen_SCC.Checked = True And ChkHen_SBD.Checked = False And ChkHen_SDS.Checked = False Then _load = "1"
        If ChkHen_SDS.Checked = True And ChkHen_SBD.Checked = False And ChkHen_SCC.Checked = False Then _load = "2"

        If Chk_S.Checked = True And Chk_P.Checked = False And Chk_B.Checked = False Then _load1 = "5"
        If Chk_P.Checked = True And Chk_S.Checked = False And Chk_B.Checked = False Then _load1 = "6"
        If Chk_B.Checked = True And Chk_S.Checked = False And Chk_P.Checked = False Then _load1 = "7"

        V_LoadRo(_load, _load1)
        CyberFill.V_FillVoucher(DetailGRV1, M_LAN, Dv_Ro_H1, Dv_Ro1)
        DetailGRV1.GridControl.DataSource = Dv_Ro1
    End Sub
    Private Sub V_Load()
        V_Loaddatatabse("1", "")
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, Dv_Ro_H, Dv_Ro)
        DetailGRV.GridControl.DataSource = Dv_Ro

        ''--- Load luoi RO
        V_LoadRo("3", "4")
        CyberFill.V_FillVoucher(DetailGRV1, M_LAN, Dv_Ro_H1, Dv_Ro1)
        DetailGRV1.GridControl.DataSource = Dv_Ro1
        '-----------------------------------------------------
        If DetailGRV1.RowCount = 0 Then Exit Sub

        Dim selectedRow As DataRowView = Nothing
        selectedRow = DetailGRV1.GetFocusedRow
        TxtSo_Ro.Text = selectedRow("So_Ro").ToString()
        Dim _Dt As Date = Now.Date

        TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, "HDK", "S", "M", _Dt, TxtSo_Ro.Text, M_Ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)

        V_Loaddatatabse("0", TxtSo_Ro.Text)
        UpdateList()
    End Sub
    Private Sub V_LoadRo(ByVal _Load As String, ByVal _Load1 As String)
        _Load = "3"
        _Load1 = "4"

        If ChkHen_SBD.Checked = True And ChkHen_SCC.Checked = False And ChkHen_SDS.Checked = False Then _Load = "0"
        If ChkHen_SCC.Checked = True And ChkHen_SBD.Checked = False And ChkHen_SDS.Checked = False Then _Load = "1"
        If ChkHen_SDS.Checked = True And ChkHen_SBD.Checked = False And ChkHen_SCC.Checked = False Then _Load = "2"

        If Chk_S.Checked = True And Chk_P.Checked = False And Chk_B.Checked = False Then _Load1 = "5"
        If Chk_P.Checked = True And Chk_S.Checked = False And Chk_B.Checked = False Then _Load1 = "6"
        If Chk_B.Checked = True And Chk_S.Checked = False And Chk_P.Checked = False Then _Load1 = "7"

        Dim DsTmpRO As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetROXPTDetail1", _Load + "#" + _Load1 + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name)

        For i As Integer = 0 To DsTmpRO.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmpRO.Tables(i))
        Next
        Dt_Ro1 = DsTmpRO.Tables(0).Copy
        Dt_Ro_H1 = DsTmpRO.Tables(1).Copy
        Dv_Ro1 = New DataView(Dt_Ro1)
        Dv_Ro_H1 = New DataView(Dt_Ro_H1)
        DsTmpRO.Dispose()
        Dt_Ro1.Clear()
        CyberSmodb.SQLTbToTb(DsTmpRO.Tables(0), Dt_Ro1)
    End Sub
    Private Sub V_Loaddatatabse(ByVal _Status As String, ByVal _So_Ro As String)
        Dim _Pick As String = ""
        If ChkPick.Checked = True Then _Pick = "1"
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetROXPTDetail", _Status + "#" + _So_Ro + "#" + _Pick + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name)

        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next
        If _Status = "1" Then
            Dt_Ro = DsTmp.Tables(1).Copy
            Dt_Ro_H = DsTmp.Tables(2).Copy
            Dv_Ro = New DataView(Dt_Ro)
            Dv_Ro_H = New DataView(Dt_Ro_H)
            DsTmp.Dispose()
            Exit Sub
        End If

        Dt_Ro.Clear()

        CyberSmodb.SQLTbToTb(DsTmp.Tables(1), Dt_Ro)

        If DsTmp.Tables(0).Columns.Contains("Ma_Xe") Then TxtMa_Xe.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Xe")
        If DsTmp.Tables(0).Columns.Contains("Ma_KX") Then TxtMa_kx.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Kx")
        If DsTmp.Tables(0).Columns.Contains("Ten_KH") Then TxtTen_KH.Text = DsTmp.Tables(0).Rows(0).Item("Ten_KH")
        If DsTmp.Tables(0).Columns.Contains("Ten_HS") Then TxtTen_HS.Text = DsTmp.Tables(0).Rows(0).Item("Ten_HS")
        If DsTmp.Tables(0).Columns.Contains("Ten_mau") Then TxtTen_Mau.Text = DsTmp.Tables(0).Rows(0).Item("Ten_mau")
        If DsTmp.Tables(0).Columns.Contains("Dia_Chi") Then TxtDia_Chi.Text = DsTmp.Tables(0).Rows(0).Item("Dia_Chi")
        If DsTmp.Tables(0).Columns.Contains("Ong_ba") Then TxtOng_ba.Text = DsTmp.Tables(0).Rows(0).Item("Ong_ba")
        If DsTmp.Tables(0).Columns.Contains("Dien_giai") Then TxtDien_giai.Text = DsTmp.Tables(0).Rows(0).Item("Dien_giai")

        CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN)
        DsTmp.Dispose()

    End Sub
    Private Sub L_So_RO(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt As Date = Now.Date
        TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, "HDK", "S", "M", _Dt, TxtSo_Ro.Text, M_Ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)

        V_Loaddatatabse("0", TxtSo_Ro.Text)
        UpdateList()
    End Sub
    Private Sub V_ReFresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _So_Ro As String = TxtSo_Ro.Text.Trim
        If _So_Ro = "" Then Exit Sub
        V_Loaddatatabse("0", TxtSo_Ro.Text)
        UpdateList()
    End Sub
    Private Sub V_ReFresh1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadRo("3", "4")
        CyberFill.V_FillVoucher(DetailGRV1, M_LAN, Dv_Ro_H1, Dv_Ro1)
        DetailGRV1.GridControl.DataSource = Dv_Ro1
        UpdateList()
    End Sub
    Private Sub V_GetColumn()
        EditMa_VT.GetColumn(DetailGRV, "Ma_VT")
        EditTen_Vt.GetColumn(DetailGRV, "Ten_VT")
        EditDvt.GetColumn(DetailGRV, "Dvt")
        EditSL_RO.GetColumn(DetailGRV, "SL_RO")
        EditSL_Xuat.GetColumn(DetailGRV, "SL_Xuat")
        EditSL_Da_Xuat.GetColumn(DetailGRV, "SL_Da_Xuat")
        EditSL_Xuat_Pick.GetColumn(DetailGRV, "SL_Xuat_Pick")
        EditSL_Da_Xuat_Pick.GetColumn(DetailGRV, "SL_Da_Xuat_Pick")
        EditGia2.GetColumn(DetailGRV, "Gia2")
        EditThue.GetColumn(DetailGRV, "Thue")
        EditSo_RO.GetColumn(DetailGRV, "SO_RO")
    End Sub
    Private Sub DetailGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenuChoGRV.ItemLinks.Clear()
        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, "Xuất vật tư (Xuất một vật tư) ", AddressOf V_Phieu_Xuat_One, Nothing, Nothing, True, True)).BeginGroup = False
        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, 0, "Xuất vật tư  (Tất cả)", AddressOf V_Phieu_Xuat_All, Nothing, Nothing, True, True), True).BeginGroup = False
        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, "Xuất Pick vật tư (Xuất một vật tư) ", AddressOf V_Pick_One, Nothing, Nothing, True, True)).BeginGroup = True
        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, 0, "Xuất Pick vật tư  (Tất cả)", AddressOf V_Pick_All, Nothing, Nothing, True, True), True).BeginGroup = False
        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, 0, "Lịch sửa xuất kho của VTPT", AddressOf V_History_Xuat1, Nothing, Nothing, True, True), True).BeginGroup = True
        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, 0, "Lịch sửa xuất kho của lệnh", AddressOf V_History_Xuat2, Nothing, Nothing, True, True), True).BeginGroup = False

        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, 0, "Lịch sửa xuất Pick của VTPT", AddressOf V_History_Xuat3, Nothing, Nothing, True, True), True).BeginGroup = True

        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, 0, "Làm tươi dữ liệu", AddressOf V_ReFresh, Nothing, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True

        PopupMenuChoGRV.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuChoGRV.ShowPopup(Control.MousePosition)
    End Sub

    Private Sub DetailGRV1_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenuChoGRV.ItemLinks.Clear()

        PopupMenuChoGRV.ItemLinks.Add(New CyberMenuPopup(sender, 0, "Làm tươi dữ liệu", AddressOf V_ReFresh1, Nothing, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        PopupMenuChoGRV.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuChoGRV.ShowPopup(Control.MousePosition)
    End Sub

    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        Dim Dt_Master As New DataTable
        Dim vDt_Master As New DataView
        Dim Grid As New DevExpress.XtraGrid.Views.Grid.GridView
        Dim CyberColor As New Cyber.Color.Sys
        Grid = sender

        If Grid.DataSource.GetType.Name.Trim.ToUpper = "DATAVIEW" Then
            vDt_Master = Grid.DataSource
            Dt_Master = vDt_Master.Table
        Else
            Dt_Master = Grid.DataSource
        End If

        If Dt_Master.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dt_Master.Columns("Bold").ColumnName
            Dim _categoryBold As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        End If

        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dt_Master.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dt_Master.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If Dt_Master.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = Dt_Master.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = Grid.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
    Private Sub V_History_Xuat1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_History_Xuat("1")
    End Sub
    Private Sub V_History_Xuat2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_History_Xuat("2")
    End Sub
    Private Sub V_History_Xuat3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_History_Xuat("3")
    End Sub
    Private Sub V_History_Xuat(ByVal _Loai As String)
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        Dim _ma_VT As String = ""
        Dim _So_RO As String = TxtSo_Ro.Text.Trim
        Dim _Stt_Rec As String = ""
        If iRow >= 0 Then _ma_VT = Dv_Ro.Item(iRow).Item("Ma_Vt")

        Dim _Title As String = "LỊCH SỬ XUẤT KHO"
        Dim _Cp_name As String
        Dim _StrFilter As String = ""
        Dim M_Ma_CT As String = "PXK"

        _StrFilter = _Loai & "#" & _So_RO.Trim & "#" & _ma_VT.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim
        _Cp_name = "CP_RoXemLichsuPX"
        _Title = "LỊCH SỬ XUẤT KHO"

        If _Loai = "3" Then
            M_Ma_CT = "PIC"
            _Cp_name = "CP_RoXemLichsuPIC"
        End If
        '--------------------------------------------------------------------------------------------------------------------------
        CyberSupport.V_WorkView(_Cp_name, _StrFilter, _Title, False, M_Ma_Dvcs, M_User_Name, AppConn, Me.Sysvar, M_LAN, Me.Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
    Private Sub V_XemPhieuXuat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _So_Ro As String = TxtSo_Ro.Text.Trim
        Dim _Stt_Rec As String = ""

        If _So_Ro = "" Then Exit Sub
        Dim _Title As String = "DANH SÁCH XE SỬA CHỮA XONG"
        Dim _Cp_name As String
        Dim _StrFilter As String = ""
        Dim M_Ma_CT As String = "HDK"

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 1 Stt_Rec FROM dbo.Ph89 WITH (NOLOCK) WHERE So_Ro  = '" + _So_Ro + "'")
        If Dstmp.Tables(0).Rows.Count > 0 Then _Stt_Rec = Dstmp.Tables(0).Rows(0).Item("Stt_Rec").ToString.Trim
        Dstmp.Dispose()

        _StrFilter = _Stt_Rec.Trim + "#" + _So_Ro.Trim + "#" + M_Ma_CT.Trim + "#" + M_Ma_Dvcs.Trim + "#" + M_User_Name.Trim
        _Cp_name = "CP_RoXemPX"
        _Title = "TÌNH HÌNH XUẤT KHO"
        '--------------------------------------------------------------------------------------------------------------------------
        CyberSupport.V_WorkView(_Cp_name, _StrFilter, _Title, False, M_Ma_Dvcs, M_User_Name, AppConn, Me.Sysvar, M_LAN, Me.Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_Sanh_Sach(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Frm As New ROXPTFilter
        Frm.Lan = M_LAN
        Frm.Para = Me.Para
        Frm.Sysvar = Me.Sysvar
        Frm.AppConn = AppConn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = CyberVoucher
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        If Not Frm.Save_OK Then Exit Sub
        Dim _strParameterStore As String = Frm.Tag.ToString.Trim
        Dim _Stt_rec As String = ""

        Dim _Cp_name As String = "CP_ROXPTFilter"
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, _Cp_name, "1#" + _strParameterStore)

        Dim _Dt_master As DataTable = DsTmp.Tables(0).Copy
        Dim _Dt_Detail As DataTable = DsTmp.Tables(1).Copy
        Dim _Dt_masterH As DataTable = DsTmp.Tables(2).Copy
        Dim _Dt_DetailH As DataTable = DsTmp.Tables(3).Copy

        Dim _Dv_master As DataView = New DataView(_Dt_master)
        Dim _Dv_Detail As DataView = New DataView(_Dt_Detail)
        Dim _Dv_masterH As DataView = New DataView(_Dt_masterH)
        Dim _Dv_DetailH As DataView = New DataView(_Dt_DetailH)

        If _Dt_master.Rows.Count <= 0 Then
            DsTmp.Dispose()
            Exit Sub
        End If

        _Stt_rec = _Dv_master.Item(0).Item("Stt_Rec").ToString.Trim

        Dim FrmX As New ROXPTView
        '------------------------------------------------
        FrmX.strLoc = "0#" + _strParameterStore
        FrmX.Cp_Loc = _Cp_name
        FrmX.Dt_Master = _Dt_master
        FrmX.Dt_Detail = _Dt_Detail
        FrmX.Dt_MasterH = _Dt_masterH
        FrmX.Dt_DetailH = _Dt_DetailH
        FrmX.Title = "Xem lệnh chưa xuất kho"
        FrmX.Stt_Rec = _Stt_rec
        '-------------------------------------------------
        FrmX.Lan = M_LAN
        FrmX.Para = Me.Para
        FrmX.Sysvar = Me.Sysvar
        FrmX.AppConn = AppConn
        FrmX.CyberSmlib = CyberSmlib
        FrmX.CyberSupport = CyberSupport
        FrmX.CyberFill = CyberFill
        FrmX.CyberSmlistSys = CyberSmlistSys
        FrmX.CyberSmodb = CyberSmodb
        FrmX.CyberExport = Nothing
        FrmX.CyberVoucher = CyberVoucher
        FrmX.CyberLoading = CyberLoading
        'FrmX.ShowInTaskbar = False
        FrmX.ShowDialog()

        If Not Frm.Save_OK Then
            DsTmp.Dispose()
            Exit Sub
        End If

        Dim _Dr_View_Return As DataRowView = FrmX.Dr_View_Return
        If _Dr_View_Return Is Nothing Then
            DsTmp.Dispose()
            Exit Sub
        End If
        If _Dr_View_Return.DataView.Table.Columns.Contains("So_Ro") Then
            TxtSo_Ro.Text = _Dr_View_Return.Item("So_Ro").ToString.Trim
            L_So_RO(sender, e)
        End If

        DsTmp.Dispose()

    End Sub
#Region "Valid - Detail - Core"
    Private Sub UpdateList()
        Dim nT_Tien2 As Decimal = 0
        Dim nT_Thue As Decimal = 0
        Dim nT_TT As Decimal = 0
        For iRow As Integer = 0 To Dv_Ro.Count() - 1
            nT_Tien2 = nT_Tien2 + Dv_Ro.Item(iRow).Item("Tien2")
            nT_Thue = nT_Thue + Dv_Ro.Item(iRow).Item("Thue")
        Next

        nT_TT = nT_Tien2 + nT_Thue
        TxtT_Tien2.Double = nT_Tien2
        TxtT_thue.Double = nT_Thue
        TxtT_TT.Double = nT_TT
    End Sub
#End Region
#Region "Tạo phiếu xuất"
    Private Sub V_Phieu_Xuat_One(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Tao_Px("1", iRow)
        If _Stt_Rec.Trim = "" Then Exit Sub
        V_ReFresh(New System.Object, New System.EventArgs)
        V_Print(_Stt_Rec)
    End Sub
    Private Sub V_Phieu_Xuat_All(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = Tao_Px("1", -1)
        If _Stt_Rec.Trim = "" Then Exit Sub
        V_ReFresh(New System.Object, New System.EventArgs)
        V_Print(_Stt_Rec)
    End Sub
    Private Function Tao_Px(ByVal _Loai As String, ByVal iRow As Integer) As String
        _StrSave = ""
        Dim j As Integer = 0

        Dim nCount As Integer = 0
        If iRow = -1 Then
            j = 0
            nCount = Dv_Ro.Count - 1
        Else
            j = iRow
            nCount = iRow
        End If

        For i = j To nCount
            If _Loai = "1" And Dv_Ro.Item(i).Item("Sl_Xuat") = 0 Then Continue For
            If _Loai = "2" And Dv_Ro.Item(i).Item("Sl_Xuat_PICK") = 0 Then Continue For

            '_StrSave = _StrSave + ";INSERT KTVKTVKTV SELECT '" & Dv_Ro.Item(i).Item("So_RO").ToString.Trim & "','" & Dv_Ro.Item(i).Item("Ma_VT").ToString.Trim & "'," & Dv_Ro.Item(i).Item("Sl_Xuat").ToString.Trim.Replace(" ", "").Replace(",", ".") & "," & Dv_Ro.Item(i).Item("Sl_Xuat_PICK").ToString.Trim.Replace(" ", "").Replace(",", ".")

            _StrSave = _StrSave + ";INSERT KTVKTVKTV SELECT '" & Dv_Ro.Item(i).Item("So_RO").ToString.Trim & "','" & Dv_Ro.Item(i).Item("Ma_VT").ToString.Trim & "','" & Dv_Ro.Item(i).Item("Ma_Kho").ToString.Trim & "','" & Dv_Ro.Item(i).Item("Ma_Vitri").ToString.Trim & "'," & Dv_Ro.Item(i).Item("Sl_Xuat").ToString.Trim.Replace(" ", "").Replace(",", ".") & "," & Dv_Ro.Item(i).Item("Sl_Xuat_PICK").ToString.Trim.Replace(" ", "").Replace(",", ".")
        Next

        If _StrSave = "" Then Return ""

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CreatePXKFromXPT", _Loai + "#" + _StrSave & "#" & TxtOng_ba.Text & "#" & TxtMa_HS_H.Text & "#" & TxtDien_giai.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _Stt_Rec As String = ""

        If CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) = True Then
            _Stt_Rec = DsTmp.Tables(0).Rows(0).Item("Stt_Rec")
            DsTmp.Dispose()
        End If
        Return _Stt_Rec
    End Function
    Private Sub V_Print(ByVal _Stt_Rec)
        If _Stt_Rec.Trim = "" Then Exit Sub
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGettable", "Dmct#Ma_CT='PXK'#Ma_Ct")
        Dim Dt_Dmct As DataTable = Dstmp.Tables(0).Copy
        Dstmp.Dispose()

        Dim DrDmct As DataRow = Dt_Dmct.Rows(0)

        Dim _Dt As Date = Now.Date
        Dim _Ma_Post As String = "3"

        CyberVoucher.V_PrintVocuher(AppConn, Sysvar, Nothing, _Stt_Rec, _Dt, _Ma_Post, M_LAN, Para, DrDmct, "PXK", M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)
    End Sub
    'ABC
    Private Sub V_Print_pick(ByVal _Stt_Rec)
        'hieulv 24-08-2021
        Exit Sub

        If _Stt_Rec.Trim = "" Then Exit Sub
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGettable", "Dmct#Ma_CT='PXK'#Ma_Ct")
        Dim Dt_Dmct As DataTable = Dstmp.Tables(0).Copy
        Dstmp.Dispose()

        Dim DrDmct As DataRow = Dt_Dmct.Rows(0)

        Dim _Dt As Date = Now.Date
        Dim _Ma_Post As String = "9"

        CyberVoucher.V_PrintVocuher(AppConn, Sysvar, Nothing, _Stt_Rec, _Dt, _Ma_Post, M_LAN, Para, DrDmct, "PIC", M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)
    End Sub

#End Region
#Region "Xuất pick"
    Private Sub V_Pick_One(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Tao_Px("2", iRow)
        If _Stt_Rec.Trim = "" Then Exit Sub
        V_ReFresh(New System.Object, New System.EventArgs)
        V_Print_pick(_Stt_Rec)

    End Sub
    Private Sub V_Pick_All(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = Tao_Px("2", -1)
        If _Stt_Rec.Trim = "" Then Exit Sub
        V_ReFresh(New System.Object, New System.EventArgs)
        V_Print_pick(_Stt_Rec)
    End Sub
    Private Sub V_ChkPick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtSo_Ro.Text = "" Then Exit Sub
        V_Loaddatatabse("0", TxtSo_Ro.Text)
    End Sub

    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not ChkRightsVoucher("P") Then Exit Sub
        'If M_Stt_Rec.Trim = "" Then Exit Sub
        'Dim _Dt As Date = TxtNgay_Ct.Value
        'Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        'CyberVoucher.V_PrintVocuher(AppConn, osysvar, Nothing, M_Stt_Rec, _Dt, _Ma_Post, M_LAN, M_Para, DrDmct, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)

        'CyberVoucher.V_PrintVocuher(AppConn, Sysvar, Nothing, _Stt_Rec, _Dt, _Ma_Post, M_LAN, Para, DrDmct, "PXK", M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)

    End Sub
#End Region
#Region "Vali --- Ma_Hs_H"
    Private Sub V_Ma_Hs_H(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_HS_H.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs_H(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_HS_H.Text = "" Then
            TxtTen_HS_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HS_H.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS_H.Text = DrReturn.Item("Ma_Hs")
            TxtTen_HS_H.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_HS_H.Text = ""
            TxtTen_HS_H.Text = ""
        End If
    End Sub
#End Region
#Region "Support"
    Private Sub EnterasTab(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub V_Chks(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtSo_Ro.Text = "" Then Exit Sub
        ''abc
        V_LoadRo("3", "4")

    End Sub

#End Region

End Class
Public Class CyberMenuPopup
    Inherits DevExpress.XtraBars.BarButtonItem
    Dim V_kh As System.EventHandler
    Public Sub New(ByVal view As Object, ByVal rowHandle As Integer, ByVal Title As String, ByVal handel As EventHandler, Optional ByVal img As Image = Nothing, Optional ByVal _Enabled As Boolean = True, Optional ByVal _Group As Boolean = False)
        Me.Caption = Title
        Me.Glyph = img
        Me.Enabled = _Enabled
        V_kh = handel
        AddHandler Me.ItemClick, AddressOf CyberLeave
        Me.Name = Name
    End Sub
    Public Sub New(ByVal view As Object, ByVal rowHandle As Integer, ByVal Title As String, ByVal handel As EventHandler, ByVal _ShortCut As System.Windows.Forms.Shortcut, Optional ByVal img As Image = Nothing, Optional ByVal _Enabled As Boolean = True, Optional ByVal _ShowShortCut As DevExpress.Utils.DefaultBoolean = DevExpress.Utils.DefaultBoolean.False)
        Me.Caption = Title
        Me.Glyph = img
        Me.Enabled = _Enabled
        Me.ShortCut = _ShortCut
        'Me.ShowItemShortcut = _ShowShortCut
        V_kh = handel
        AddHandler Me.ItemClick, AddressOf CyberLeave
        Me.Name = Name
    End Sub
    Private Sub CyberLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not V_kh Is Nothing Then V_kh(sender, e)
    End Sub
End Class
Public Class CyberBarSubMenuPopup
    Inherits DevExpress.XtraBars.BarSubItem
    Public Sub New(ByVal view As Object, ByVal rowHandle As Integer, ByVal Title As String, ByVal handel As EventHandler, Optional ByVal img As Image = Nothing, Optional ByVal _Enabled As Boolean = True, Optional ByVal _Group As Boolean = False)
        Me.Caption = Title
        Me.Glyph = img
        Me.Enabled = _Enabled
        Me.Name = Name
    End Sub
End Class
