Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Drawing

Public Class FrmTien_Do_F3_SDSALL
#Region "AddProperty"
    Dim CyberWork As New Sys
    Dim CyberColor As New Cyber.Color.Sys
    Dim M_So_Ro As String = "1"
    Dim M_Ma_TTCP As String = ""
    Public Property Ma_TTCP() As String
        Get
            Ma_TTCP = M_Ma_TTCP
        End Get
        Set(ByVal Value As String)
            M_Ma_TTCP = Value
        End Set
    End Property
    Public Property So_Ro() As String
        Get
            So_Ro = M_So_Ro
        End Get
        Set(ByVal Value As String)
            M_So_Ro = Value
        End Set
    End Property
    Dim M_Stt_Rec_Ro As String = ""
    Public Property Stt_Rec_Ro() As String
        Get
            Stt_Rec_Ro = M_Stt_Rec_Ro
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec_Ro = Value
        End Set
    End Property
    Dim M_Kieu_Xem As String = "KH"
    Public Property Kieu_Xem() As String
        Get
            Kieu_Xem = M_Kieu_Xem
        End Get
        Set(ByVal Value As String)
            M_Kieu_Xem = Value
        End Set
    End Property
    Dim M_Loai_SC As String = "1"
    Public Property Loai_SC() As String
        Get
            Loai_SC = M_Loai_SC
        End Get
        Set(ByVal Value As String)
            M_Loai_SC = Value
        End Set
    End Property

    Dim M_Mode As String = "M"
    Public Property Mode() As String
        Get
            Mode = M_Mode
        End Get
        Set(ByVal Value As String)
            M_Mode = Value
        End Set
    End Property
    Dim M_Ma_Ct As String = "PKH"
    Public Property Ma_Ct() As String
        Get
            Ma_Ct = M_Ma_Ct
        End Get
        Set(ByVal Value As String)
            M_Ma_Ct = Value
        End Set
    End Property

    Dim M_Ngay_BD As Date
    Public Property Ngay_BD() As Date
        Get
            Ngay_BD = M_Ngay_BD
        End Get
        Set(ByVal Value As Date)
            M_Ngay_BD = Value
        End Set
    End Property
    Dim M_Ngay_KT As Date
    Public Property Ngay_KT() As Date
        Get
            Ngay_KT = M_Ngay_KT
        End Get
        Set(ByVal Value As Date)
            M_Ngay_KT = Value
        End Set
    End Property
    Dim M_Ma_CVDV As String = ""
    Public Property Ma_CVDV() As String
        Get
            Ma_CVDV = M_Ma_CVDV
        End Get
        Set(ByVal Value As String)
            M_Ma_CVDV = Value
        End Set
    End Property
    Dim M_Ma_khoang As String = ""
    Public Property Ma_Khoang() As String
        Get
            Ma_Khoang = M_Ma_khoang
        End Get
        Set(ByVal Value As String)
            M_Ma_khoang = Value
        End Set
    End Property
    Dim M_Ma_To As String = ""
    Public Property Ma_To() As String
        Get
            Ma_To = M_Ma_To
        End Get
        Set(ByVal Value As String)
            M_Ma_To = Value
        End Set
    End Property
    Dim M_Ma_Xe As String = ""
    Public Property Ma_Xe() As String
        Get
            Ma_Xe = M_Ma_Xe
        End Get
        Set(ByVal Value As String)
            M_Ma_Xe = Value
        End Set
    End Property
    Dim M_Ma_CD As String = ""
    Public Property Ma_CD() As String
        Get
            Ma_CD = M_Ma_CD
        End Get
        Set(ByVal Value As String)
            M_Ma_CD = Value
        End Set
    End Property
    Dim M_Ma_KTV As String = ""
    Public Property Ma_KTV() As String
        Get
            Ma_KTV = M_Ma_KTV
        End Get
        Set(ByVal Value As String)
            M_Ma_KTV = Value
        End Set
    End Property

#End Region
#Region "Columns Edit"
    Dim EditTg_SC, EditTg_TC, EditSo_Nguoi, EditNgay_BD, EditNgay_KT, EditMa_To, EditTen_To, EditMa_Khoang, EditTen_Khoang As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Ktv_S, EditTen_KTV_S As New Cyber.Fill.CyberColumnGridView
    Dim Edittag As New Cyber.Fill.CyberColumnGridView
#End Region
#Region "Add Cac Table"

    'Dim Dt_khoang, Dt_To, Dt_KTV, Dt_CD As DataTable
    'Dim Dt_khoangH, Dt_ToH, Dt_KTVH, Dt_CD_H As DataTable

    'Dim Dv_khoang, Dv_To, Dv_KTV, Dv_CD As DataView
    'Dim Dv_khoangH, Dv_ToH, Dv_KTVH, Dv_CD_H As DataView
    Dim Dt_DmMucSDS, Dt_DmMucSBD As DataTable

    Dim Dt_PH89CVDV, Dt_Master, Dt_Head As DataTable
    Dim Dv_PH89CVDV, Dv_Master, Dv_Head As DataView

    Public M_Dt_Return As DataTable = Nothing

    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DsLoad As DataSet
    Dim DsTmp As DataSet
    Dim M_Stt_Rec As String = ""

#End Region
    
    Private Sub FrmCVDV_KH_SDSALL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        '----------------------------
        TxtSo_Ro.Text = M_So_Ro
        TxtStt_Rec_RO.Text = M_Stt_Rec_Ro
        '----------------------------
        V_Load("1")
        '----------------------------
        V_GetColumn()
        '----------------------------
        V_AddHandler()
        '----------------------------
        '------------------------------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        Me.Text = "Tạo nhanh kế hoạch sửa chữa đồng sơn"
        '------------------------------------------------------------------------------------------------------------------
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load(ByVal _Load As String)
        Dim _Str As String = ""
        Dim _Ngay_Bd As Date = M_Ngay_BD
        Dim _Ngay_KT As Date = M_Ngay_KT


        _Str = _Load & "#" & M_Kieu_Xem & "#" & M_Loai_SC.Trim & "#" & "PKH" & "#" & "M" & "#" & TxtStt_Rec_RO.Text & "#" & TxtSo_Ro.Text & "#" & M_Ma_khoang + "#" + _
                                                                          M_Ma_CVDV & "#" & M_Ma_To & "#" & M_Ma_Xe & "#" & M_Ma_CD & "#" & M_Ma_KTV & "#" & _
                                                                          _Ngay_Bd.ToString("yyyyMMdd HH:mm") & "#" & _Ngay_KT.ToString("yyyyMMdd HH:mm") & "#" & M_Ma_Dvcs & "#" + M_User_Name

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkPKH_SDS_Load_ALLS", _Str)
        Dim iTb As Integer = 0

        If _Load = "1" Then
            iTb = 0
            Dt_PH89CVDV = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dv_PH89CVDV = New DataView(Dt_PH89CVDV)
            '------------------------
            Dt_Master = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dv_Master = New DataView(Dt_Master)
            '------------------------
            Dt_Head = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dv_Head = New DataView(Dt_Head)

            Master.DataSource = Dv_Master
            CyberFill.V_FillReports(MasterGRV, M_LAN, Dv_Head, Dv_Master)
            '-----------------------------------------------------
            Dt_DmMucSBD = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            CyberFill.V_FillComBoxDefaul(CbbMuc_SBD, Dt_DmMucSBD, "Muc_SBD", "ten_SBD", "Ngam_Dinh")
            '-----------------------------------------------------
            Dt_DmMucSDS = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            CyberFill.V_FillComBoxDefaul(CbbMuc_SDS, Dt_DmMucSDS, "Muc_SDS", "ten_SDS", "Ngam_Dinh")
            '-----------------------------------------------------


        Else
            iTb = 0
            Dt_PH89CVDV.Clear()
            Dt_PH89CVDV.Load(Dstmp.Tables(iTb).CreateDataReader)
            iTb = iTb + 1

            Dt_Master.Clear()
            Dt_Master.Load(Dstmp.Tables(iTb).CreateDataReader)
            iTb = iTb + 1
        End If
        CyberSmodb.SetValueTObj(Me, Dt_PH89CVDV.Rows(0))

        If Dt_PH89CVDV.Columns.Contains("Stt_Rec") Then M_Stt_Rec = Dt_PH89CVDV.Rows(0).Item("Stt_Rec")
        If Dt_PH89CVDV.Columns.Contains("Stt_Rec_Ro") Then M_Stt_Rec_RO = Dt_PH89CVDV.Rows(0).Item("Stt_Rec_Ro")
        If Dt_PH89CVDV.Columns.Contains("So_RO") Then M_So_RO = Dt_PH89CVDV.Rows(0).Item("So_RO")

        'M_Stt_Rec_Ro = Dt_PH89CVDV.Rows(0).Item("Stt_Rec_Ro")
        'M_So_Ro = Dt_PH89CVDV.Rows(0).Item("Stt_Rec_Ro")
        'Me.Stt_Rec = M_Stt_Rec
        'Me.Stt_Rec_Ro = M_Stt_Rec_Ro
        'Me.So_Ro = M_So_Ro
    End Sub
    Private Sub V_GetColumn()
        EditTg_TC.GetColumn(MasterGRV, "Tg_TC")
        EditSo_Nguoi.GetColumn(MasterGRV, "So_Nguoi")
        EditTg_SC.GetColumn(MasterGRV, "Tg_SC")

        EditNgay_BD.GetColumn(MasterGRV, "Ngay_BD")
        EditNgay_KT.GetColumn(MasterGRV, "Ngay_KT")

        EditMa_To.GetColumn(MasterGRV, "Ma_TO")
        EditTen_To.GetColumn(MasterGRV, "Ten_TO")

        EditMa_Khoang.GetColumn(MasterGRV, "Ma_Khoang")
        EditTen_Khoang.GetColumn(MasterGRV, "Ten_Khoang")

        EditMa_Ktv_S.GetColumn(MasterGRV, "Ma_KTV_S")
        EditTen_KTV_S.GetColumn(MasterGRV, "Ten_KTV_S")
        ''Edittag.GetColumn(MasterKTVGRV, "Ftag")
    End Sub
    Private Sub V_AddHandler()

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtSo_Ro.Leave, AddressOf L_So_Ro

        '----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        AddHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler MasterGRV.FocusedRowChanged, AddressOf MasterGRV_FocusedRowChanged

        If Not EditTg_TC.Column Is Nothing Then AddHandler EditTg_TC.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditSo_Nguoi.Column Is Nothing Then AddHandler EditSo_Nguoi.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditTg_SC.Column Is Nothing Then AddHandler EditTg_SC.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditNgay_BD.Column Is Nothing Then AddHandler EditNgay_BD.EditColumn.Leave, AddressOf V_Tinh_Toan
        If Not EditNgay_KT.Column Is Nothing Then AddHandler EditNgay_KT.EditColumn.Leave, AddressOf V_Tinh_Toan

        EditMa_To.V_ActiLookUpColumn(AddressOf V_Master_Ma_To, AddressOf L_Master_Ma_TO)
        EditTen_To.V_ActiLookUpColumn(AddressOf V_Master_Ma_To, AddressOf L_Master_Ma_TO)
        EditMa_Khoang.V_ActiLookUpColumn(AddressOf V_Master_Ma_KHoang, AddressOf L_Master_Ma_khoang)
        ''EditTen_Khoang.V_ActiLookUpColumn(AddressOf V_Master_Ma_KHoang, AddressOf L_Master_Ma_khoang)
        AddHandler EditTen_Khoang.EditColumn.Click, AddressOf V_Chon_khoang

        'AddHandler EditMa_Ktv_S.EditColumn.Click, AddressOf V_Ma_KTV_S
        AddHandler EditTen_KTV_S.EditColumn.Click, AddressOf V_Ten_KTV_S
        ''----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'AddHandler CbbMa_To.SelectedIndexChanged, AddressOf V_Ma_TO
        'AddHandler CbbMa_Khoang.SelectedIndexChanged, AddressOf V_Ma_khoang

        'AddHandler TxtTG_TC.Leave, AddressOf V_TG_TC
        'AddHandler TxtSo_Nguoi.Leave, AddressOf V_TG_TC
        'AddHandler TxtTG_SC.Leave, AddressOf V_TG_SC

        'AddHandler TxtNgay_BD.Leave, AddressOf V_Ngay_BD
        'AddHandler TxtNgay_KT.Leave, AddressOf V_Ngay_KT
        ''----------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        'AddHandler MasterKTVGRV.FocusedRowChanged, AddressOf MasterKTVGRV_FocusedRowChanged
        'AddHandler MasterKTVGRV.RowCellClick, AddressOf V_RowCellClick
        'AddHandler Edittag.EditColumn.EditValueChanged, AddressOf V_Tag

        '---------------------------------------------------------
        AddHandler ÇmdNang_Luc_Xuong.Click, AddressOf V_Nang_Luc_Xuong
        AddHandler ÇmdXem_LSSC.Click, AddressOf V_Lich_Su_SC
        AddHandler ÇmdXem_LS_Hen.Click, AddressOf V_Lich_Su_Hen
        AddHandler CmdXem_Giao_Xe.Click, AddressOf V_Xem_Giao_Xe
        '---------------------------------------------------------

    End Sub
    Private Sub L_So_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt As Date = TxtNgay_BD_RO.Value
        Dim _date = M_Ngay_BD

        TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Me.Sysvar, "HDK", "S", M_Mode, _date, TxtSo_Ro.Text, M_Ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        TxtStt_Rec_RO.Text = ""
        TxtStt_Rec.Text = ""

        V_Load("0")
    End Sub
#Region "/Giaoo/XeNăng lực xưởng"
    Private Sub V_Xem_Giao_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _StrLoc As String = TxtStt_Rec_RO.Text + "#" + TxtSo_Ro.Text + "#" + "HDK" + "#" + M_Ma_Dvcs + "#" + M_User_Name
        CyberSupport.V_WorkView("CP_ROHDKXemGX", _StrLoc, "XEM QÚA TRÌNH ĐIỀU CHỈNH THỜI GIAN GIAO XE", False, M_Ma_Dvcs, M_User_Name, AppConn, Me.Sysvar, M_LAN, Me.Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_Nang_Luc_Xuong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Tg_SC As Decimal = TxtTG_SC_RO.Double
        Dim _Ngay_BD As Date = TxtNgay_BD_RO.Value
        Dim _Ngay_KT As Date = TxtNgay_KT_RO.Value
        Dim _Loai_SC As String = "2"
        If ChkSCC.Checked Or ChkSBD.Checked Then _Loai_SC = "1"
        Dim _DsTmpNLX As DataSet = CyberWork.V_Tinh_Khoang(M_Kieu_Xem, M_Loai_SC, TxtStt_Rec.Text, M_Ma_Ct, TxtMa_Xe.Text, TxtSo_Ro.Text, _Tg_SC, _Ngay_BD, _Ngay_KT, AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_Lich_Su_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = TxtMa_Xe.Text
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, "HDK", "", AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
    Private Sub V_Lich_Su_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = TxtMa_Xe.Text
        If _Ma_Xe.Trim = "" Then Return
        Dim _StrLoc As String = M_Kieu_Xem + "#" + M_Loai_SC + "#" + "" + "#" + _Ma_Xe + "#" + "" + "#" + "19000101" + "#" + "20500101" + "#" + "" + "#" + M_Ma_Dvcs + "#" + M_User_Name
        CyberSupport.V_WorkView("CP_WorkDLH", _StrLoc, "DANH SÁCH LỊCH HẸN SỬA CHỮA", False, M_Ma_Dvcs, M_User_Name, AppConn, Me.Sysvar, M_LAN, Me.Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
#End Region
#Region "Event"
    Private Sub V_Master_Ma_To(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_To", "DmToSC", "is_SDS = N'1'", "1=1", M_Mode, M_Ma_Ct, M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Master_Ma_TO(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_Ct, sender, True)
        MasterGRV.PostEditor()
        If DrReturn Is Nothing Then
            Dv_Master.Item(iRow)("Ma_To") = ""
            If Dv_Master.Table.Columns.Contains("Ten_To") Then Dv_Master.Item(iRow).Item("Ten_To") = ""
            Exit Sub
        End If

        Dv_Master.Item(iRow).BeginEdit()
        Dv_Master.Item(iRow).Item("Ma_To") = DrReturn("Ma_To").ToString.Trim
        If Dv_Master.Table.Columns.Contains("Ten_To") And DrReturn.Table.Columns.Contains("Ten_To") Then Dv_Master.Item(iRow).Item("Ten_To") = DrReturn("Ten_To").ToString.Trim
        Dv_Master.Item(iRow).EndEdit()
        MasterGRV.UpdateCurrentRow()
        ''V_UpdateFrom(iRow)
    End Sub
    Private Sub V_Master_Ma_KHoang(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_KHoang", "DmKHoang", "is_SDS = N'1'", "1=1", M_Mode, M_Ma_Ct, M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Master_Ma_khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        MasterGRV.PostEditor()
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_Ct, sender, True)
        If DrReturn Is Nothing Then
            Dv_Master.Item(iRow)("Ma_KHoang") = ""
            If Dv_Master.Table.Columns.Contains("Ten_KHoang") Then Dv_Master.Item(iRow).Item("Ten_KHoang") = ""
            Exit Sub
        End If
        Dv_Master.Item(iRow).BeginEdit()
        Dv_Master.Item(iRow).Item("Ma_KHoang") = DrReturn("Ma_KHoang").ToString.Trim
        If Dv_Master.Table.Columns.Contains("Ten_KHoang") Then Dv_Master.Item(iRow).Item("Ten_KHoang") = DrReturn("Ten_KHoang").ToString.Trim
        Dv_Master.Item(iRow).EndEdit()
        MasterGRV.UpdateCurrentRow()
        'V_UpdateFrom(iRow)
    End Sub
    Private Sub V_Chon_khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'If Not Dt_Master.Columns.Contains("Ma_Khoang") Then Exit Sub
        'If Not Dt_Master.Columns.Contains("Ten_Khoang") Then Exit Sub

        'M_Mode = M_Mode.Trim

        'Dim _iRow As Integer = -1
        '_iRow = MasterGRV.GetFocusedDataSourceRowIndex
        'If _iRow < 0 Then Exit Sub
        'Dim _Ten_Khoang As String = ""
        'Dim _Ma_Khoang As String = Dv_Master.Item(_iRow).Item("Ma_Khoang")
        'If Dv_Master.Table.Columns.Contains("Ten_Khoang") Then _Ten_Khoang = Dv_Master.Item(_iRow).Item("Ten_Khoang")
        'V_Ma_KHoang(_Ma_Khoang, _Ten_Khoang, _iRow)
    End Sub
    Private Sub V_Ma_KHoang(ByVal _Ma_Khoang As String, ByVal _Ten_Khoang As String, ByVal _IRow As Integer)
        Dim str As String
        Dim strTen As String = ""

        str = GetKTV(_Ma_Khoang, strTen)
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            If str Is Nothing Then Exit Sub
            Exit Sub
        End If
        If str Is Nothing Then Exit Sub
        If str Is Nothing Then str = ""
        If strTen Is Nothing Then strTen = ""
        Dv_Master.Item(_IRow).BeginEdit()
        Dv_Master.Item(_IRow).Item("Ma_khoang") = str
        If Dv_Master.Table.Columns.Contains("ten_Khoang") Then Dv_Master.Item(_IRow).Item("ten_Khoang") = strTen
        Dv_Master.Item(_IRow).EndEdit()
        MasterGRV.UpdateCurrentRow()
    End Sub
    Private Function GetKhoang(ByVal _Ma_Khoang As String, ByRef _Ten_Khoang As String) As String
        GetKhoang = CyberSupport.V_GetStrSelectList(AppConn, Sysvar, Para, "CP_GetListSelect", "DMKhoang#" & _Ma_Khoang & "#" & M_Ma_Ct & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN, _Ten_Khoang)
    End Function
    Private Sub V_Ten_KTV_S(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        'If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not Dt_Master.Columns.Contains("Ten_KTV_S") Then Exit Sub
        If Not Dt_Master.Columns.Contains("Ma_KTV_S") Then Exit Sub

        Dim _iRow As Integer = -1
        _iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If _iRow < 0 Then Exit Sub
        Dim _Ten_Ktv_s As String = ""
        Dim _ma_Ktv_s As String = Dv_Master.Item(_iRow).Item("Ma_KTV_S")
        If Dv_Master.Table.Columns.Contains("Ten_KTV_S") Then _Ten_Ktv_s = Dv_Master.Item(_iRow).Item("ten_KTV_S")

        V_Ma_KTV_S(_ma_Ktv_s, _Ten_Ktv_s, _iRow)

    End Sub
    Private Sub V_Ma_KTV_S(ByVal _Ma_KTV_S As String, ByVal _Ten_KTV_S As String, ByVal _IRow As Integer)
        Dim str As String
        Dim strTen As String = ""

        str = GetKTV(_Ma_KTV_S, strTen)
        If Not (M_Mode = "M" Or M_Mode = "S") Then
            If str Is Nothing Then Exit Sub
            Exit Sub
        End If
        If str Is Nothing Then Exit Sub
        If str Is Nothing Then str = ""
        If strTen Is Nothing Then strTen = ""
        Dv_Master.Item(_IRow).BeginEdit()
        Dv_Master.Item(_IRow).Item("Ma_KTV_S") = str
        If Dv_Master.Table.Columns.Contains("ten_KTV_S") Then Dv_Master.Item(_IRow).Item("ten_KTV_S") = strTen
        Dv_Master.Item(_IRow).EndEdit()

        MasterGRV.UpdateCurrentRow()
    End Sub
    Private Function GetKTV(ByVal _Ma_KTV As String, ByRef _Ten_KTV As String) As String
        GetKTV = CyberSupport.V_GetStrSelectList(AppConn, Sysvar, Para, "CP_GetListSelect", "DMKTVDS#" & _Ma_KTV & "#" & M_Ma_Ct & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN, _Ten_KTV)
    End Function
#End Region
#Region "Thoi gian"
    Private Sub V_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        MasterGRV.PostEditor()
        V_Tinh_Toan(iRow)
    End Sub
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)
        If Dv_Master.Table.Columns.Contains("So_nguoi") Then
            If Dv_Master.Item(iRow).Item("So_Nguoi") < 0 Then
                Dv_Master.Item(iRow).BeginEdit()
                Dv_Master.Item(iRow).Item("So_Nguoi") = 0
                Dv_Master.Item(iRow).EndEdit()
                MasterGRV.UpdateCurrentRow()
            End If
        End If

        If Dv_Master.Table.Columns.Contains("Tg_TC") Then
            If Dv_Master.Item(iRow).Item("Tg_TC") < 0 Then
                Dv_Master.Item(iRow).BeginEdit()
                Dv_Master.Item(iRow).Item("Tg_TC") = 0
                Dv_Master.Item(iRow).EndEdit()
                MasterGRV.UpdateCurrentRow()
            End If
        End If
        If Dt_Master.Columns.Contains("So_Nguoi") And Dt_Master.Columns.Contains("Tg_TC") And Dt_Master.Columns.Contains("Tg_SC") Then
            Dim _So_Nguoi As Decimal = Dv_Master.Item(iRow).Item("So_Nguoi")
            Dv_Master.Item(iRow).BeginEdit()
            If _So_Nguoi <> 0 Then Dv_Master.Item(iRow).Item("Tg_SC") = CyberSupport.V_Round(Dv_Master.Item(iRow).Item("Tg_TC") / _So_Nguoi, 0)
            Dv_Master.Item(iRow).EndEdit()
            MasterGRV.UpdateCurrentRow()
        End If
        '-------------------------------------------------------------------------------
        V_Xu_ly_Cong_Doan_Sau(iRow)
        'V_UpdateFrom(iRow)
    End Sub
    Private Sub V_Xu_ly_Cong_Doan_Sau(ByVal _IRow As Integer)

        If _IRow <= -1 Then Exit Sub
        Dim nCount As Decimal = Dv_Master.Count - 1
        If _IRow > nCount Then Exit Sub

        Dim _Tg_Sc As Decimal = Dv_Master.Item(_IRow).Item("Tg_Sc")
        Dim _Ngay_BD As Date = Dv_Master.Item(_IRow).Item("Ngay_Bd")
        Dim _Ngay_KT As Date = Dv_Master.Item(_IRow).Item("Ngay_KT")
        If _Ngay_KT < _Ngay_BD Then _Ngay_KT = _Ngay_BD

        _Ngay_KT = CyberWork.V_AddTime(_Ngay_BD, _Tg_Sc, AppConn, CyberSmlib, M_Ma_Dvcs)

        Dv_Master.Item(_IRow).BeginEdit()
        Dv_Master.Item(_IRow).Item("Tg_Sc") = _Tg_Sc
        Dv_Master.Item(_IRow).Item("Ngay_Bd") = _Ngay_BD
        Dv_Master.Item(_IRow).Item("Ngay_KT") = _Ngay_KT
        Dv_Master.Item(_IRow).EndEdit()
        MasterGRV.UpdateCurrentRow()
        '-------------------------------------------------
        If _IRow + 1 > nCount Then Return
        '-------------------------------------------------

        Dim _Tg_Sc1 As Decimal = Dv_Master.Item(_IRow + 1).Item("Tg_Sc")
        Dim _Ngay_BD1 As Date = Dv_Master.Item(_IRow + 1).Item("Ngay_Bd")
        Dim _Ngay_KT1 As Date = Dv_Master.Item(_IRow + 1).Item("Ngay_KT")

        If _Ngay_BD1 < _Ngay_KT Then
            _Ngay_BD1 = _Ngay_KT

            _Ngay_KT1 = CyberWork.V_AddTime(_Ngay_BD1, _Tg_Sc1, AppConn, CyberSmlib, M_Ma_Dvcs)

            Dv_Master.Item(_IRow + 1).BeginEdit()
            Dv_Master.Item(_IRow + 1).Item("Tg_Sc") = _Tg_Sc1
            Dv_Master.Item(_IRow + 1).Item("Ngay_Bd") = _Ngay_BD1
            Dv_Master.Item(_IRow + 1).Item("Ngay_KT") = _Ngay_KT1
            Dv_Master.Item(_IRow + 1).EndEdit()
            MasterGRV.UpdateCurrentRow()
        End If
        _IRow = _IRow + 1
        If _IRow < nCount Then
            V_Xu_ly_Cong_Doan_Sau(_IRow)
        End If
    End Sub

#End Region
#Region "Master Style"
    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterGRV, Dt_Master, Me.Font)
    End Sub
    Private Sub MasterGRV_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        'V_UpdateFrom(iRow)
    End Sub
#End Region
#Region "Save"
    Private Function V_Vsave() As Boolean
        M_Stt_Rec = TxtStt_Rec.Text
        M_Stt_Rec_RO = TxtStt_Rec_RO.Text
        M_So_RO = TxtSo_Ro.Text

        If Dt_PH89CVDV.Columns.Contains("Stt_Rec_Ro") Then M_Stt_Rec_RO = Dt_PH89CVDV.Rows(0).Item("Stt_Rec_Ro")
        If Dt_PH89CVDV.Columns.Contains("So_RO") Then M_So_RO = Dt_PH89CVDV.Rows(0).Item("So_RO")

        If TxtSo_Ro.Text = "" Then
            MsgBox("Bạn chưa nhập R/O", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Return False
        End If
        If TxtStt_Rec_RO.Text = "" Then
            MsgBox("Bạn chưa nhập R/O", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Return False
        End If
        If TxtMa_Xe.Text = "" Then
            MsgBox("Bạn chưa nhập biển số xe", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Return False
        End If

        'If txtTen_KH.Text = "" Then
        '    MsgBox("Bạn chưa nhập tên khách hàng", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
        '    Return False
        'End If

        'If Not ChkSDS.Checked And Not ChkSBD.Checked And Not ChkSCC.Checked Then
        '    MsgBox("Bạn chưa chọn loại hình sửa chữa", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, Sysvar("M_CYBER_VER"))
        '    Return False
        'End If

        'If ChkSDS.Checked Then TxtLoai_SC.Text = "2"
        'If (ChkSCC.Checked Or ChkSBD.Checked) And (Not ChkSDS.Checked) Then TxtLoai_SC.Text = "1"
        'If (ChkSCC.Checked Or ChkSBD.Checked) And (ChkSDS.Checked) Then TxtLoai_SC.Text = "3"

        'If TxtTen_kh.Text = "" Then
        '    MsgBox("Bạn chưa nhập tên khách hàng", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
        '    Return False
        'End If
        Return True
    End Function
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_So_Ro = TxtSo_Ro.Text
        M_Stt_Rec_Ro = TxtStt_Rec_RO.Text
        M_Stt_Rec = ""

        If Not V_Vsave() Then Return
        '-----------------------------------------------------------------------------------------------------------------
        Dim Dt_Save As DataTable = Dt_Master.Copy
        '-----------------------------------------------------------------------------------------------------------------
        Dim _Dt_Ph As DataTable
        Dim DsTmpstru As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo.PH89CVDV_SCC WITH (NOLOCK) WHERE 1=0#" & M_Ma_Dvcs & "#" & M_User_Name)
        _Dt_Ph = DsTmpstru.Tables(0).Copy
        DsTmpstru.Dispose()
        '-----------------------------------------------------------------------------------------------------------------

        Dim _DrH As DataRow = _Dt_Ph.NewRow
        _DrH.BeginEdit()
        CyberSmodb.SetValueBlankRow(_DrH)
        CyberSmodb.AddValueToRow(_DrH, Me)
        If _Dt_Ph.Columns.Contains("Stt_Rec_RO") Then _DrH.Item("Stt_Rec_RO") = TxtStt_Rec_RO.Text
        If _Dt_Ph.Columns.Contains("Stt_Rec") Then _DrH.Item("Stt_Rec") = TxtStt_Rec.Text
        If _Dt_Ph.Columns.Contains("Ma_Ct") Then _DrH.Item("Ma_Ct") = M_Ma_Ct
        If _Dt_Ph.Columns.Contains("Ma_Dvcs") Then _DrH.Item("Ma_Dvcs") = M_Ma_Dvcs
        _DrH.EndEdit()
        _Dt_Ph.Rows.Add(_DrH)
        _Dt_Ph.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------------------
        Dim strXML As String = CyberSmodb.V_ConvertDataToXML({"PH89CVDV_SCC", "DMCD"}, {_Dt_Ph, Dt_Save})
        M_Mode = "M"
        '--------------------------------------------------------------------------------------------
        Dim M_strParameterStore As String = M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Mode.Trim + "#" + M_Stt_Rec + "#" + M_Stt_Rec_RO + "#" + M_So_RO + "#" + strXML + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkPKH_Save_SDS_ALL", M_strParameterStore)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Me.Save_OK = False
            Me.M_Dt_Return = Nothing
            Exit Sub
        End If
        M_Stt_Rec_RO = DsTmp.Tables(1).Rows(0).Item("Stt_Rec_Ro")
        Me.Tag = M_Stt_Rec_Ro
        Me.M_Dt_Return = DsTmp.Tables(1).Copy
        Me.Save_OK = True
        DsTmp.Dispose()
        Me.Close()

    End Sub
#End Region

End Class
