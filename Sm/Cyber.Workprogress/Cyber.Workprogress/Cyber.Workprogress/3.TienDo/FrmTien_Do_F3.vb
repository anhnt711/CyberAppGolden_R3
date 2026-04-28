Imports System.Windows.Forms
Imports System.Data.SqlClient
Imports System.Drawing
Imports DevExpress.XtraScheduler
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid
Public Class FrmTien_Do_F3
#Region "AddProperty"
    Dim M_Ma_TTCP As String = ""
    Public Property Ma_TTCP() As String
        Get
            Ma_TTCP = M_Ma_TTCP
        End Get
        Set(ByVal Value As String)
            M_Ma_TTCP = Value
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
    Dim M_Stt_Rec As String = ""
    Public Property Stt_Rec() As String
        Get
            Stt_Rec = M_Stt_Rec
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec = Value
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
    Dim M_So_Ro As String = ""
    Public Property So_Ro() As String
        Get
            So_Ro = M_So_Ro
        End Get
        Set(ByVal Value As String)
            M_So_Ro = Value
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
    Dim M_Loai_SC As String = "1"
    Public Property Loai_SC() As String
        Get
            Loai_SC = M_Loai_SC
        End Get
        Set(ByVal Value As String)
            M_Loai_SC = Value
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
#Region "Biến"
    Dim CyberWork As New Sys
    Dim CyberColor As New Cyber.Color.Sys

    Dim Dt_PH89CVDV, Dt_CV, Dt_VT, Dt_KTVCV, Dt_CV_H, Dt_VT_H As DataTable
    Dim Dv_PH89CVDV, Dv_CV, Dv_VT, Dv_KTVCV, Dv_CV_H, Dv_VT_H As DataView

    Dim Dt_khoang, Dt_To, Dt_KTV, Dt_KTV_Chon As DataTable
    Dim Dt_khoangH, Dt_ToH, Dt_KTVH As DataTable

    Dim Dv_khoang, Dv_To, Dv_KTV, Dv_KTV_Chon As DataView
    Dim Dv_khoangH, Dv_ToH, Dv_KTVH As DataView
    Dim Dt_CD, Dt_DmMucSDS, Dt_DmMucSBD As DataTable

    Dim M_Ma_Ct As String = "PKH"
    Dim DsLookup As New DataSet
    Dim DrReturn As DataRow

    Public M_Dt_Return As DataTable = Nothing
    Dim EditKTVTime_KTV, EditKTVNgay_BD, EditKTVNgay_KT, EditKTVNgay_BD_TH, EditKTVNgay_KT_TH As New Cyber.Fill.CyberColumnGridView
    Dim EditkhoangTAG, EditKhoangXem_Hen As New Cyber.Fill.CyberColumnGridView
    Dim EditKTVTag, EditKTVChinh_Phu, EditKTVXem_Hen, EditKTVXN_BD, EditKTVXN_KT As New Cyber.Fill.CyberColumnGridView
    Dim EditCVTag, EditVTTag As New Cyber.Fill.CyberColumnGridView
    Dim EditCVIs_GO, EditCVIs_SON, EditMa_KtVt, EditTen_KtVt, EditCVMa_Ktv1, EditCVMa_Ktv2 As New Cyber.Fill.CyberColumnGridView
    Dim EditCVTen_Ktv1, EditCVTen_KTV2 As New Cyber.Fill.CyberColumnGridView
    Dim M_Loai_Giao_Viec As String = "1"
    '-----------------------------------------------------
    ' M_Loai_Giao_Viec = '1' Giao KTV cho CV (Tối đa 2 2 KTV trên 1 công việc: gồm KTV chính  + KTV phụ: Xem được VTPT thay thế): KHOANG + KTV + CV;VT
    ' M_Loai_Giao_Viec = '2' Giao KTV cho CV (Phương pháp giao KTV cho các công việc, được nhiều việc): KHoang + KTV + KTVCV
    ' M_Loai_Giao_Viec = '3' Giao KTV cho CV (Phương pháp giao công việc cho KTV, 1 công việc nhiề KTV): KHoang + CV + KTV
    '-----------------------------------------------------
#End Region
    Private Sub FrmCVDV_KH_SCC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtSo_Ro.Text = M_So_Ro
        '------------------------------------------------------------------------------------
        V_Load("1")
        '------------------------------------------------------------------------------------
        V_SetLoai_Giao_Viec()
        '------------------------------------------------------------------------------------
        Dim _iRow_KTV As Integer = masterKTVGRV.GetFocusedDataSourceRowIndex
        Dim _iRow_CV As Integer = MasterCVGRV.GetFocusedDataSourceRowIndex
        V_SetLoai_KTV_AND_CV(_iRow_KTV, _iRow_CV)
        V_GetKTV_Chon()
        '------------------------------------------------------------------------------------
        V_AddHander()
        '------------------------------------------------------------------------------------
        If M_Loai_SC = "2" Then
            ChkLoc_CV_VSNT.Visible = True
            ChkLoc_CV_GO.Visible = True
            ChkLoc_CV_Son.Visible = True
            CmdUp_TG_GX.Visible = True
        End If
        '------------------------------------------------------------------------------------
        V_Ma_TO(New System.Object, New System.EventArgs)
        '------------------------------------------------------------------------------------
        If M_Loai_Giao_Viec = "1" Then V_DragDropGridview()
        '------------------------------------------------------------------------------------
        V_Sub_SetColorCV()
        '------------------------------------------------------------------------------------
        masterKhoangGRV.ColumnPanelRowHeight = 30
        masterKTVGRV.ColumnPanelRowHeight = 30
        MasterCVGRV.ColumnPanelRowHeight = 30
        MasterVtGRV.ColumnPanelRowHeight = 30
        '------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        If M_Mode.Trim = "S" Then TxtSo_Ro.Enabled = False
        Me.Text = IIf(M_LAN = "V", IIf(Mode = "M", "Tạo mới kế hoạch", "Sửa kế hoạch"), IIf(M_Mode = "M", "Create planing", "Edit planing"))
        '------------------------------------------------------------------------------------
        CbbMa_CD.Enabled = (M_Mode = "M")
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load(ByVal _Load As String)
        Dim _Str As String = _Load + "#" + M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Mode + "#" + M_Stt_Rec + "#" + M_Stt_Rec_Ro + "#" + TxtSo_Ro.Text
        _Str = _Str + "#" + M_Ngay_BD.ToString("yyyyMMdd HH:mm") + "#" + M_Ngay_KT.ToString("yyyyMMdd HH:mm")
        _Str = _Str + "#" + M_Ma_Xe + "#" + M_Ma_CVDV + "#" + M_Ma_khoang
        _Str = _Str + "#" + M_Ma_To + "#" + M_Ma_CD + "#" + M_Ma_KTV + "#" + M_Ma_Dvcs + "#" + M_User_Name

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkPKH_Load", _Str)
        Dim iTb As Integer = 0

        If _Load = "1" Then
            iTb = 0
            Dt_PH89CVDV = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dv_PH89CVDV = New DataView(Dt_PH89CVDV)
            If Dt_PH89CVDV.Columns.Contains("Loai_Giao_Viec") Then M_Loai_Giao_Viec = Dt_PH89CVDV.Rows(0).Item("Loai_Giao_Viec")
            '------------------------
            Dt_CV = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dv_CV = New DataView(Dt_CV)

            '------------------------
            Dt_VT = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dv_VT = New DataView(Dt_VT)

            '------------------------
            Dt_KTVCV = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dv_KTVCV = New DataView(Dt_KTVCV)

          
            '------------------------
            Dt_CV_H = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dv_CV_H = New DataView(Dt_CV_H)

            MasterCV.DataSource = Dv_CV
            CyberFill.V_FillReports(MasterCVGRV, M_LAN, Dv_CV_H, Dv_CV)
            '------------------------
            Dt_VT_H = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dv_VT_H = New DataView(Dt_VT_H)
            MasterVt.DataSource = Dv_VT
            CyberFill.V_FillReports(MasterVtGRV, M_LAN, Dv_VT_H, Dv_VT)


            'Test.DataSource = Dv_KTVCV
            'CyberFill.V_FillReports(TestGRV, M_LAN, New DataView(CyberWork.V_Gettable(iTb, Dstmp)), Dv_KTVCV)
            'iTb = iTb + 1

            '------------------------
            Dt_khoang = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dt_khoangH = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1

            Dv_khoang = New DataView(Dt_khoang)
            Dv_khoangH = New DataView(Dt_khoangH)
            masterKhoang.DataSource = Dv_khoang
            CyberFill.V_FillReports(masterKhoangGRV, M_LAN, Dv_khoangH, Dv_khoang)
            '------------------------
            Dt_To = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dt_ToH = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dv_To = New DataView(Dt_To)
            Dv_ToH = New DataView(Dt_ToH)
            CyberFill.V_FillComBoxDefaul(CbbMa_To, Dt_To, "ma_To", "Ten_To", "Ngam_Dinh")
            '-----------------------------------------------------
            Dt_KTV = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            Dt_KTVH = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1

            Dv_KTV = New DataView(Dt_KTV)
            Dv_KTVH = New DataView(Dt_KTVH)
            masterKTV.DataSource = Dv_KTV
            CyberFill.V_FillReports(masterKTVGRV, M_LAN, Dv_KTVH, Dv_KTV)
            '-----------------------------------------------------
            Dt_KTV_Chon = Dt_KTV.Clone
            Dv_KTV_Chon = New DataView(Dt_KTV_Chon)

            ChkKTV_Chon.DataSource = Dv_KTV_Chon
            ChkKTV_Chon.DisplayMember = Dt_KTV_Chon.Columns("Ten_Hs").ColumnName
            ChkKTV_Chon.ValueMember = Dt_KTV_Chon.Columns("Ma_Hs").ColumnName
            '-----------------------------------------------------
            Dt_CD = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            CyberFill.V_FillComBoxDefaul(CbbMa_CD, Dt_CD, "Ma_CD", "ten_CD", "Ngam_Dinh")

            '-----------------------------------------------------
            Dt_DmMucSBD = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            CyberFill.V_FillComBoxDefaul(CbbMuc_SBD, Dt_DmMucSBD, "Muc_SBD", "ten_SBD", "Ngam_Dinh")
            '-----------------------------------------------------
            Dt_DmMucSDS = CyberWork.V_Gettable(iTb, Dstmp)
            iTb = iTb + 1
            CyberFill.V_FillComBoxDefaul(CbbMuc_SDS, Dt_DmMucSDS, "Muc_SDS", "ten_SDS", "Ngam_Dinh")

        Else
            iTb = 0
            Dt_PH89CVDV.Clear()
            Dt_PH89CVDV.Load(Dstmp.Tables(iTb).CreateDataReader)
            iTb = iTb + 1

            Dt_CV.Clear()
            Dt_CV.Load(Dstmp.Tables(iTb).CreateDataReader)
            iTb = iTb + 1

            Dt_VT.Clear()
            Dt_VT.Load(Dstmp.Tables(iTb).CreateDataReader)
            iTb = iTb + 1

        End If
        '------------------------------------------------------------------------------------------------------------------------------------------------------
        V_GetKTV_Chon()
        CyberSmodb.SetValueTObj(Me, Dt_PH89CVDV.Rows(0))
        '------------------------------------------------------------------------------------------------------------------------------------------------------
        M_Stt_Rec = Dt_PH89CVDV.Rows(0).Item("Stt_Rec")
        M_Stt_Rec_Ro = Dt_PH89CVDV.Rows(0).Item("Stt_Rec_Ro")
        M_So_Ro = Dt_PH89CVDV.Rows(0).Item("Stt_Rec_Ro")

        Me.Stt_Rec = M_Stt_Rec
        Me.Stt_Rec_Ro = M_Stt_Rec_Ro
        Me.So_Ro = M_So_Ro
    End Sub
    Private Sub V_GetKTV_Chon()
        If Dt_KTV Is Nothing Or Dt_KTV_Chon Is Nothing Then Return
        If Not Dt_KTV.Columns.Contains("Tag") Then Return
        Dim _Dr As DataRow() = Dt_KTV.Select("Tag = '1'")
        Dt_KTV_Chon.Clear()
        For i As Integer = 0 To _Dr.Length - 1
            Dt_KTV_Chon.ImportRow(_Dr(i))
        Next
        Dt_KTV_Chon.AcceptChanges()
        For i As Integer = 0 To Dt_KTV_Chon.Rows.Count - 1
            ChkKTV_Chon.SetItemChecked(i, True)
        Next
    End Sub
    Private Sub V_AddHander()

        EditkhoangTAG.GetColumn(masterKhoangGRV, "TAG")
        EditKhoangXem_Hen.GetColumn(masterKhoangGRV, "Xem_Hen")
        '-----
        EditKTVTag.GetColumn(masterKTVGRV, "TAG")
        EditKTVChinh_Phu.GetColumn(masterKTVGRV, "Chinh_Phu")
        EditKTVTime_KTV.GetColumn(masterKTVGRV, "Time_KTV")
        EditKTVXem_Hen.GetColumn(masterKTVGRV, "Xem_Hen")

        EditKTVNgay_BD.GetColumn(masterKTVGRV, "Ngay_DB")
        EditKTVNgay_KT.GetColumn(masterKTVGRV, "Ngay_KT")
        EditKTVNgay_BD_TH.GetColumn(masterKTVGRV, "Ngay_DB_TH")
        EditKTVNgay_KT_TH.GetColumn(masterKTVGRV, "Ngay_KT_TH")
        EditKTVXN_BD.GetColumn(masterKTVGRV, "XN_BD")
        EditKTVXN_KT.GetColumn(masterKTVGRV, "XN_KT")
        '-----
        EditCVTag.GetColumn(MasterCVGRV, "TAG")
        EditCVMa_Ktv1.GetColumn(MasterCVGRV, "Ma_KTV1")
        EditCVMa_Ktv2.GetColumn(MasterCVGRV, "Ma_KTV2")
        EditCVTen_Ktv1.GetColumn(MasterCVGRV, "Ten_KTV1")
        EditCVTen_KTV2.GetColumn(MasterCVGRV, "Ten_KTV2")
        EditCVIs_GO.GetColumn(MasterCVGRV, "IS_GO")
        EditCVIs_SON.GetColumn(MasterCVGRV, "IS_SON")
        '---------------------------------------------------------

        EditVTTag.GetColumn(MasterVtGRV, "TAG")
        EditMa_KtVt.GetColumn(MasterVtGRV, "Ma_KTV")
        EditTen_KtVt.GetColumn(MasterVtGRV, "Ten_KTV")

        '---------------------------------------------------------
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtSo_Ro.Leave, AddressOf L_So_Ro
        AddHandler TxtTG_SC.Leave, AddressOf V_TG_SC
        AddHandler TxtNgay_BD.Leave, AddressOf V_Ngay_BD
        AddHandler TxtNgay_KT.Leave, AddressOf V_Ngay_KT
        AddHandler CbbMa_To.SelectedIndexChanged, AddressOf V_Ma_TO
        '---------------------------------------------------------
        AddHandler masterKhoangGRV.RowCellStyle, AddressOf Master_khoangGRV_RowCellStyle
        AddHandler masterKTVGRV.RowCellStyle, AddressOf Master_KTVGRV_RowCellStyle
        AddHandler MasterCVGRV.RowCellStyle, AddressOf Master_CVGRV_RowCellStyle
        AddHandler MasterVtGRV.RowCellStyle, AddressOf Master_VTGRV_RowCellStyle
        '---------------------------------------------------------
        AddHandler masterKhoangGRV.PopupMenuShowing, AddressOf masterKhoangGRV_PopupMenuShowing
        AddHandler masterKTVGRV.PopupMenuShowing, AddressOf masterKTVGRV_PopupMenuShowing
        AddHandler MasterCVGRV.PopupMenuShowing, AddressOf masterCVGRV_PopupMenuShowing
        '---------------------------------------------------------
        If Not EditkhoangTAG.Column Is Nothing Then AddHandler EditkhoangTAG.EditColumn.EditValueChanged, AddressOf V_CLICK_KHoang_tag
        If Not EditKhoangXem_Hen.Column Is Nothing Then AddHandler EditKhoangXem_Hen.EditColumn.Click, AddressOf V_Xem_Hen_Khoang

        '-----
        If Not EditKTVChinh_Phu.Column Is Nothing Then AddHandler EditKTVChinh_Phu.EditColumn.EditValueChanged, AddressOf V_CLICK_KTVChinh_Phu
        If Not EditKTVTime_KTV.Column Is Nothing Then AddHandler EditKTVTime_KTV.EditColumn.EditValueChanged, AddressOf V_CLICK_Time_KTV

        If Not EditKTVXem_Hen.Column Is Nothing Then AddHandler EditKTVXem_Hen.EditColumn.Click, AddressOf V_Xem_Hen_KTV

        If Not EditKTVNgay_BD.Column Is Nothing Then AddHandler EditKTVNgay_BD.EditColumn.Leave, AddressOf V_CLICK_Ngay_BD
        If Not EditKTVNgay_KT.Column Is Nothing Then AddHandler EditKTVNgay_KT.EditColumn.Leave, AddressOf V_CLICK_Ngay_KT

        'If Not EditKTVXN_BD.Column Is Nothing Then AddHandler EditKTVXN_BD.EditColumn.Click, AddressOf V_Xac_nhan_BD
        'If Not EditKTVXN_KT.Column Is Nothing Then AddHandler EditKTVXN_KT.EditColumn.Click, AddressOf V_Xac_nhan_KT
        '-----
        If Not EditKTVTag.Column Is Nothing Then AddHandler EditKTVTag.EditColumn.EditValueChanged, AddressOf V_CLICK_KTV_tag
        If Not EditCVTag.Column Is Nothing Then AddHandler EditCVTag.EditColumn.EditValueChanged, AddressOf V_CLICK_CV_tag
        If Not EditVTTag.Column Is Nothing Then AddHandler EditVTTag.EditColumn.EditValueChanged, AddressOf V_CLICK_VT_tag
        ''If Not EditCVTag.Column Is Nothing Then AddHandler EditCVTag.EditColumn.Click, AddressOf V_CLICK_CV_tag

        EditCVMa_Ktv1.V_ActiLookUpColumn(AddressOf V_Ma_KTV1, AddressOf L_Ma_KTV1)
        EditCVMa_Ktv2.V_ActiLookUpColumn(AddressOf V_Ma_KTV2, AddressOf L_Ma_KTV2)
        '------------------------------------
        AddHandler CmdGoi_Y_Khoang.Click, AddressOf V_Goi_Y_Khoang
        AddHandler ÇmdNang_Luc_Xuong.Click, AddressOf V_Nang_Luc_Xuong
        AddHandler ÇmdXem_LSSC.Click, AddressOf V_Lich_Su_SC
        AddHandler ÇmdXem_LS_Hen.Click, AddressOf V_Lich_Su_Hen
        AddHandler CmdXem_Giao_Xe.Click, AddressOf V_Xem_Giao_Xe
        '------------------------------------
        AddHandler masterKTVGRV.FocusedRowChanged, AddressOf masterKTVGRV_FocusedRowChanged
        AddHandler MasterCVGRV.FocusedRowChanged, AddressOf masterCVGRV_FocusedRowChanged
    End Sub
#Region "Khac"
    Private Sub L_So_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_BD_RO.Value
        Dim _date = M_Ngay_BD
        TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Me.Sysvar, "HDK", "S", M_Mode, _date, TxtSo_Ro.Text, M_ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        V_Load("0")
    End Sub
    Private Sub V_Ma_TO(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Dt_KTV.Columns.Contains("Ma_To") Then Exit Sub
        Dim _Filter As String = "1=1"
        Dim _Ma_To As String = CyberWork.V_GetvalueCombox(CbbMa_To)
        If Not _Ma_To = "" Then _Filter = "Ma_To = '" + _Ma_To + "'"
        Dv_KTV.RowFilter = _Filter

        'Hadv Filter đồng sơn
        If M_Loai_SC.Trim = "2" Then
            If Dt_khoang.Columns.Contains("Ma_To") Then Dv_khoang.RowFilter = _Filter
        End If

        Dim Dr As DataRow() = CyberSmodb.SQLGetRows(AppConn, "DmtoSC", "Ma_TO = N'" + _Ma_To + "' AND Ma_Dvcs = N'" + M_Ma_Dvcs.Trim + "'", CyberSmlib)
        If Dr Is Nothing Then Return
        If Dr.Length = 0 Then Return

        Dim _Ma_Khoang As String = Dr(0).Item("Ma_khoang").ToString.Trim
        Dim _is_khoang As String = Dr(0).Item("is_khoang").ToString.Trim

        Dim _Ma_CD As String = Dr(0).Item("Ma_CD").ToString.Trim
        Dim _is_CD As String = Dr(0).Item("is_khoang").ToString.Trim

        '---Phàn này làm sau
        'Dim _DaChon As Boolean = False
        'For i As Integer = 0 To Dt_khoang.Rows.Count - 1
        'Next
    End Sub
#End Region
#Region "Thoi gian"
    Private Sub V_TG_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        If TxtTG_SC.Double <= 0 Then TxtTG_SC.Double = 0
        TxtNgay_KT.Value = CyberWork.V_AddTime(_Ngay_BD, TxtTG_SC.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        V_Ngay_Gx(sender, e)
        For iRow As Integer = 0 To Dv_KTV.Count - 1
            V_Update_Ngay_BD_Ngay_KT(iRow)
        Next
    End Sub
    Private Sub V_Ngay_BD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        If TxtTG_SC.Double > 0 Then
            TxtNgay_KT.Value = CyberWork.V_AddTime(_Ngay_BD, TxtTG_SC.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        End If
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        TxtTG_SC.Double = CyberWork.V_GetTimeM(_Ngay_BD, _Ngay_KT, AppConn, CyberSmlib, M_Ma_Dvcs)
        V_Ngay_Gx(sender, e)
        For iRow As Integer = 0 To Dv_KTV.Count - 1
            V_Update_Ngay_BD_Ngay_KT(iRow)
        Next

    End Sub
    Private Sub V_Ngay_KT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        TxtTG_SC.Double = CyberWork.V_GetTimeM(_Ngay_BD, _Ngay_KT, AppConn, CyberSmlib, M_Ma_Dvcs)
        V_Ngay_Gx(sender, e)
        For iRow As Integer = 0 To Dv_KTV.Count - 1
            V_Update_Ngay_BD_Ngay_KT(iRow)
        Next
    End Sub
    Private Sub V_Ngay_Gx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtNgay_HenKT.Value = DateAdd(DateInterval.Minute, 15, TxtNgay_KT.Value)
    End Sub
#End Region
#Region "Click/Xem"
    Private Sub V_CLICK_Ngay_BD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        masterKTVGRV.PostEditor()
        masterKTVGRV.UpdateCurrentRow()

        Dim iRow As Integer = masterKhoangGRV.GetFocusedDataSourceRowIndex
        If iRow >= 0 Then V_Update_Ngay_BD_Ngay_KT(iRow)
        masterKTVGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_CLICK_Ngay_KT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''masterKTVGRV.UpdateCurrentRow()
        masterKTVGRV.PostEditor()
        masterKTVGRV.UpdateCurrentRow()
        Dim iRow As Integer = masterKhoangGRV.GetFocusedDataSourceRowIndex
        If iRow >= 0 Then V_Update_Ngay_BD_Ngay_KT(iRow)
        masterKTVGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_Update_Ngay_BD_Ngay_KT(ByVal iRow As Integer)
        If iRow < 0 Then Return
        If iRow > Dv_KTV.Count - 1 Then Return
        Dim _Ngay_BD = TxtNgay_BD.Value
        Dim _Ngay_KT = TxtNgay_KT.Value
        If Not Dt_KTV.Columns.Contains("Time_KTV") Or Not Dt_KTV.Columns.Contains("Ngay_BD") Or Not Dt_KTV.Columns.Contains("Ngay_KT") Then Return

        Dim _Ngay_BD0 As Date = Dv_KTV.Item(iRow).Item("Ngay_BD")
        Dim _Ngay_KT0 As Date = Dv_KTV.Item(iRow).Item("Ngay_KT")
        If IsDBNull(_Ngay_BD0) Then _Ngay_BD0 = New Date(1900, 1, 1, 0, 0, 0, 0)
        If IsDBNull(_Ngay_KT0) Then _Ngay_KT0 = New Date(1900, 1, 1, 0, 0, 0, 0)

        Dv_KTV.Item(iRow).BeginEdit()
        If Dv_KTV.Item(iRow).Item("Tag").ToString.Trim = "1" Then
            If Not Dv_KTV.Item(iRow).Item("Time_KTV").ToString.Trim = "1" Then
                Dv_KTV.Item(iRow).Item("Ngay_BD") = _Ngay_BD
                Dv_KTV.Item(iRow).Item("Ngay_KT") = _Ngay_KT
            Else
                If _Ngay_BD0 < _Ngay_BD Then Dv_KTV.Item(iRow).Item("Ngay_BD") = _Ngay_BD
                If _Ngay_KT0 > _Ngay_KT Or _Ngay_KT0 = New Date(1900, 1, 1, 0, 0, 0, 0) Then Dv_KTV.Item(iRow).Item("Ngay_KT") = _Ngay_KT
            End If
        Else
            Dv_KTV.Item(iRow).Item("Ngay_BD") = New Date(1900, 1, 1, 0, 0, 0, 0)
            Dv_KTV.Item(iRow).Item("Ngay_KT") = New Date(1900, 1, 1, 0, 0, 0, 0)
        End If
        Dv_KTV.Item(iRow).EndEdit()
        masterKTVGRV.UpdateCurrentRow()
    End Sub
#End Region
#Region "RowCellStyle"
    Private Sub Master_khoangGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        'CyberSupport.DetailGRV_RowCellStyle2(sender, e, masterKhoangGRV, Dt_khoang, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, masterKhoangGRV, Dt_khoang, Me.Font, "Tag", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub Master_KTVGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        'CyberSupport.DetailGRV_RowCellStyle2(sender, e, masterKTVGRV, Dt_KTV, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, masterKTVGRV, Dt_KTV, Me.Font, "Tag", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub Master_CVGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        'CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterCVGRV, Dt_CV, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterCVGRV, Dt_CV, Me.Font, "Tag", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub Master_VTGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        'CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterVtGRV, Dt_VT, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterVtGRV, Dt_VT, Me.Font, "Tag", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
#End Region
#Region "PopupMenuShowing"
    Private Sub masterKhoangGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle

        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn EM", "Select EM"), AddressOf V_SelectkhoangAll_EM, Shortcut.CtrlE, Nothing, True, True)).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn GJ", "Select GJ"), AddressOf V_SelectkhoangAll_GJ, Shortcut.CtrlG, Nothing, True, True)).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn tất", "Select All"), AddressOf V_SelectkhoangAll, Shortcut.CtrlA, Nothing, True, True)).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gỡ chọn", "Remove All"), AddressOf V_RemovekhoangAll, Shortcut.CtrlU, Nothing, True, True)).BeginGroup = False
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)

    End Sub
    Private Sub masterKTVGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn tất", "Select All"), AddressOf V_SelectKTVAll, Shortcut.CtrlA, Nothing, True, True)).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gỡ chọn", "Remove All"), AddressOf V_RemoveKTVAll, Shortcut.CtrlU, Nothing, True, True)).BeginGroup = False
        'If Not EditKTVXN_BD Is Nothing Then PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xác nhận bắt đầu tất cả các KTV", "Approval Bg"), AddressOf V_Xac_nhan_BDAll, Shortcut.CtrlB, Nothing, True, True)).BeginGroup = True
        'If Not EditKTVXN_BD Is Nothing Then PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xác nhận kết thúc tất cả các KTV", "Approval En"), AddressOf V_Xac_nhan_KTAll, Shortcut.CtrlK, Nothing, True, True)).BeginGroup = False
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub masterCVGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn tất", "Select All"), AddressOf V_SelectCVAll, Shortcut.CtrlA, Nothing, True, True)).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gỡ chọn", "Remove All"), AddressOf V_RemoveCVAll, Shortcut.CtrlU, Nothing, True, True)).BeginGroup = False
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
#End Region
#Region "Select And Remove tag"
    Private Sub V_SelectkhoangAll_EM(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Dt_khoang.Columns.Contains("Is_EM") Or Not Dt_khoang.Columns.Contains("Tag") Then Return
        V_RemovekhoangAll(sender, e)
        For i As Integer = 0 To Dv_khoang.Count - 1
            Dv_khoang.Item(i).BeginEdit()
            If Dv_khoang.Item(i).Item("Is_Em").ToString.Trim = "1" Then Dv_khoang.Item(i).Item("Tag") = "1"
            Dv_khoang.Item(i).EndEdit()
            masterKhoangGRV.UpdateCurrentRow()
        Next
        Dt_khoang.AcceptChanges()
        masterKhoangGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_SelectkhoangAll_GJ(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Dt_khoang.Columns.Contains("Is_GJ") Or Not Dt_khoang.Columns.Contains("Tag") Then Return
        V_RemovekhoangAll(sender, e)
        Dt_khoang.AcceptChanges()
        For i As Integer = 0 To Dv_khoang.Count - 1
            Dv_khoang.Item(i).BeginEdit()
            If Dv_khoang.Item(i).Item("Is_GJ").ToString.Trim = "1" Then Dv_khoang.Item(i).Item("Tag") = "1"
            Dv_khoang.Item(i).EndEdit()
            masterKhoangGRV.UpdateCurrentRow()
        Next
        Dt_khoang.AcceptChanges()
        masterKhoangGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_SelectkhoangAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dv_khoang.Count - 1
            If Dt_khoang.Columns.Contains("Tag") Then
                Dv_khoang.Item(i).BeginEdit()
                Dv_khoang.Item(i).Item("Tag") = "1"
                Dv_khoang.Item(i).EndEdit()
                masterKhoangGRV.UpdateCurrentRow()
            End If
        Next
        Dt_khoang.AcceptChanges()
        masterKhoangGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_RemovekhoangAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dv_khoang.Count - 1
            If Dt_khoang.Columns.Contains("Tag") Then
                Dv_khoang.Item(i).BeginEdit()
                Dv_khoang.Item(i).Item("Tag") = "0"
                Dv_khoang.Item(i).EndEdit()
                masterKhoangGRV.UpdateCurrentRow()
            End If
        Next
        Dt_khoang.AcceptChanges()
        masterKhoangGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_SelectKTVAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dv_KTV.Count - 1
            If Dt_KTV.Columns.Contains("Tag") Then
                Dv_KTV.Item(i).BeginEdit()
                Dv_KTV.Item(i).Item("Tag") = "1"
                Dv_KTV.Item(i).EndEdit()
                masterKTVGRV.UpdateCurrentRow()
            End If
        Next
        Dt_KTV.AcceptChanges()
        masterKTVGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_RemoveKTVAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dv_KTV.Count - 1
            If Dt_KTV.Columns.Contains("Tag") Then
                Dv_KTV.Item(i).BeginEdit()
                Dv_KTV.Item(i).Item("Tag") = "0"
                Dv_KTV.Item(i).EndEdit()
                masterKTVGRV.UpdateCurrentRow()
            End If
        Next
        Dt_KTV.AcceptChanges()
        masterKTVGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_SelectCVAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dv_CV.Count - 1
            If Dt_CV.Columns.Contains("Tag") Then
                Dv_CV.Item(i).BeginEdit()
                Dv_CV.Item(i).Item("Tag") = "1"
                Dv_CV.Item(i).EndEdit()
                MasterCVGRV.UpdateCurrentRow()
            End If
        Next
        Dt_CV.AcceptChanges()
        MasterCVGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_RemoveCVAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dv_CV.Count - 1
            If Dt_CV.Columns.Contains("Tag") Then
                Dv_CV.Item(i).BeginEdit()
                Dv_CV.Item(i).Item("Tag") = "0"
                Dv_CV.Item(i).EndEdit()
                MasterCVGRV.UpdateCurrentRow()
            End If
        Next
        Dt_CV.AcceptChanges()
        MasterCVGRV.UpdateCurrentRow()
    End Sub
#End Region
#Region "Click Tag"
    Private Sub V_CLICK_KHoang_tag(ByVal sender As System.Object, ByVal e As System.EventArgs)
        masterKhoangGRV.PostEditor()
        masterKhoangGRV.UpdateCurrentRow()
        Dim iRow As Integer = masterKhoangGRV.GetFocusedDataSourceRowIndex

        Dim _Strkhoang As String = ""
        Dim _iRow_Update As Integer = -1
        For i = 0 To Dv_khoang.Count - 1
            Dv_khoang.Item(i).BeginEdit()
            If i <> iRow Then
                Dv_khoang.Item(i).Item("TAG") = "0"
                If Dt_khoang.Columns.Contains("BackColor") Then Dv_khoang.Item(i).Item("BackColor") = ""
                If Dt_khoang.Columns.Contains("BackColor2") Then Dv_khoang.Item(i).Item("BackColor2") = ""
                If Dt_khoang.Columns.Contains("ForeColor") Then Dv_khoang.Item(i).Item("ForeColor") = ""
            Else
                _iRow_Update = i
                If Dt_khoang.Columns.Contains("BackColor") Then Dv_khoang.Item(i).Item("backColor") = "Pink"
                _Strkhoang = "INSERT Dmkhoang SELECT N'" + Dt_khoang.Rows(i).Item("ma_khoang").ToString + "'"
            End If
            Dv_khoang.Item(i).EndEdit()
        Next
        Dt_khoang.AcceptChanges()
        masterKhoangGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_CLICK_KTV_tag(ByVal sender As System.Object, ByVal e As System.EventArgs)
        masterKTVGRV.PostEditor()
        masterKTVGRV.UpdateCurrentRow()
        Dim _iRow_KTV As Integer = masterKTVGRV.GetFocusedDataSourceRowIndex
        Dim _iRow_CV As Integer = MasterCVGRV.GetFocusedDataSourceRowIndex
        V_GetLoai_KTV_AND_CV(_iRow_KTV, _iRow_CV)
        V_GetKTV_Chon()
    End Sub
    Private Sub V_CLICK_KTVChinh_Phu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        masterKTVGRV.PostEditor()
        masterKTVGRV.UpdateCurrentRow()
        Dim iRow As Integer = masterKTVGRV.GetFocusedDataSourceRowIndex
        masterKTVGRV.UpdateCurrentRow()
        V_UpdateKTV_CV(iRow)
    End Sub
    Private Sub V_CLICK_Time_KTV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        masterKTVGRV.PostEditor()
        masterKTVGRV.UpdateCurrentRow()
        Dim iRow As Integer = masterKhoangGRV.GetFocusedDataSourceRowIndex
        masterKTVGRV.UpdateCurrentRow()
        If iRow >= 0 Then V_Update_Ngay_BD_Ngay_KT(iRow)
        masterKTVGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_CLICK_CV_tag(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MasterCVGRV.PostEditor()
        MasterCVGRV.UpdateCurrentRow()
        Dim _iRow_KTV As Integer = masterKTVGRV.GetFocusedDataSourceRowIndex
        Dim _iRow_CV As Integer = MasterCVGRV.GetFocusedDataSourceRowIndex
        V_GetLoai_KTV_AND_CV(_iRow_KTV, _iRow_CV)
        V_Sub_SetColorCV()
    End Sub
    Private Sub V_CLICK_VT_tag(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MasterVtGRV.PostEditor()
        MasterVtGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_UpdateKTV_CV(ByVal _Irow As Integer)
        For iRow As Integer = 0 To Dv_KTV.Count - 1
            If Dv_KTV.Item(iRow).Item("tag").ToString = "1" And Dv_KTV.Item(iRow).Item("Chinh_Phu").ToString = "1" Then
                For j As Integer = 0 To Dv_CV.Count - 1
                    If Dv_CV.Item(j).Item("Tag").ToString.Trim = "1" And Dv_CV.Item(j).Item("Ma_KTV1").ToString = "" Then
                        Dv_CV.Item(j).BeginEdit()
                        Dv_CV.Item(j).Item("Ma_KTV1") = Dv_KTV.Item(iRow).Item("Ma_Hs").ToString
                        Dv_CV.Item(j).Item("Ten_KTV1") = Dv_KTV.Item(iRow).Item("Ten_HS").ToString
                        Dv_CV.Item(j).EndEdit()
                    End If
                    MasterCVGRV.UpdateCurrentRow()
                Next
                Exit For
            End If
        Next
        Dt_CV.AcceptChanges()
    End Sub
#End Region

#Region "Xem hen"
    Private Sub V_Xem_Hen_Khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
       

        Dim IROW As Integer = masterKhoangGRV.GetFocusedDataSourceRowIndex
        Dim _Ma As String = ""
        If IROW >= 0 Then If Dt_khoang.Columns.Contains("Ma_khoang") Then _Ma = Dv_khoang.Item(IROW).Item("Ma_khoang")

        Dim _Ngay_Ct1 As Date = TxtNgay_BD.Value
        Dim _Ngay_Ct2 As Date = TxtNgay_KT.Value
        Dim _Loai_SC As String = "1"
        Dim _Ma_Koang As String = _Ma
        Dim _Ma_CD As String = ""
        Dim _Ma_to As String = ""
        Dim _Ma_KTV As String = ""
        Dim _Ma_CVDV As String = ""
        Dim _So_Ro As String = ""
        Dim _Ma_Xe As String = ""
        Dim Stt_Rec As String = ""
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        Dim _Title As String = ""
        'CyberWork.V_Xem_Tien_Do_SC(_Loai_SC, _Ma_Koang, _Ma_CD, _Ma_to, _Ma_KTV, _Ma_CVDV, _So_Ro, _Ma_Xe, Stt_Rec, _Ngay_BD, _Ngay_KT, _Title, M_Ma_Dvcs, M_User_Name, AppConn, Sysvar, Para, Lan, True, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberVoucher, CyberLoading, False)

    End Sub
    Private Sub V_Xem_Hen_KTV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim IROW As Integer = masterKTVGRV.GetFocusedDataSourceRowIndex
        Dim _Ma As String = ""
        If IROW >= 0 Then If Dt_KTV.Columns.Contains("Ma_hs") Then _Ma = Dv_KTV.Item(IROW).Item("Ma_hs")

        Dim _Ngay_Ct1 As Date = TxtNgay_BD.Value
        Dim _Ngay_Ct2 As Date = TxtNgay_KT.Value
        Dim _Loai_SC As String = "1"
        Dim _Ma_Koang As String = ""
        Dim _Ma_CD As String = ""
        Dim _Ma_to As String = ""
        Dim _Ma_KTV As String = _Ma
        Dim _Ma_CVDV As String = ""
        Dim _So_Ro As String = ""
        Dim _Ma_Xe As String = ""
        Dim Stt_Rec As String = ""
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        Dim _Title As String = ""
        'CyberWork.V_Xem_Tien_Do_SC(_Loai_SC, _Ma_Koang, _Ma_CD, _Ma_to, _Ma_KTV, _Ma_CVDV, _So_Ro, _Ma_Xe, Stt_Rec, _Ngay_BD, _Ngay_KT, _Title, M_Ma_Dvcs, M_User_Name, AppConn, Sysvar, Para, Lan, True, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberVoucher, CyberLoading, False)
    End Sub
    Private Sub V_Ma_KTV1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim _Keyclient As String = "1=1"
        Dim _KeySQL As String = "1=1"
        Dim _ma_TO As String = ""
        _ma_TO = CyberWork.V_GetvalueCombox(CbbMa_To).ToString.Trim
        _KeySQL = _KeySQL + " AND ma_Dvcs = N'" + M_Ma_Dvcs.Trim + "'"

        If M_Loai_SC.Trim = "1" Then _KeySQL = _KeySQL + " AND Is_SCC = N'1'"
        If M_Loai_SC.Trim = "2" Then _KeySQL = _KeySQL + " AND Is_SDS = N'1'"
        If _ma_TO.Trim <> "" Then _Keyclient = _Keyclient + " AND Ma_To = '" + _ma_TO + "'"

        CyberSupport.V_Lookup("Ma_Hs", "DmKTVSC", _KeySQL, _Keyclient, M_Mode, M_Ma_Ct, M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, sender)

    End Sub
    Private Sub L_Ma_KTV1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterCVGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_Ct, sender, True)
        If DrReturn Is Nothing Then
            Dv_CV.Item(iRow).BeginEdit()
            Dv_CV.Item(iRow).Item("Ma_KTV1") = ""
            If Dv_CV.Table.Columns.Contains("Ten_KTV1") Then Dv_CV.Item(iRow).Item("Ten_KTV1") = ""
            Dv_CV.Item(iRow).EndEdit()
            Exit Sub
        Else
            Dv_CV.Item(iRow).BeginEdit()
            Dv_CV.Item(iRow).Item("Ma_KTV1") = DrReturn("Ma_HS").ToString.Trim
            If Dv_CV.Table.Columns.Contains("Ten_KTV1") And DrReturn.Table.Columns.Contains("Ten_HS") Then Dv_CV.Item(iRow).Item("Ten_KTV1") = DrReturn("Ten_HS").ToString.Trim
            Dv_CV.Item(iRow).EndEdit()
        End If
        Dt_CV.AcceptChanges()
        MasterCVGRV.UpdateCurrentRow()
        V_Sub_SetColorCV()
    End Sub
    Private Sub V_Ma_KTV2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim _Keyclient As String = "1=1"
        Dim _KeySQL As String = "1=1"
        Dim _ma_TO As String = ""
        _ma_TO = CyberWork.V_GetvalueCombox(CbbMa_To).ToString.Trim
        _KeySQL = _KeySQL + " AND ma_Dvcs = N'" + M_Ma_Dvcs.Trim + "'"

        If M_Loai_SC.Trim = "1" Then _KeySQL = _KeySQL + " AND Is_SCC = N'1'"
        If M_Loai_SC.Trim = "2" Then _KeySQL = _KeySQL + " AND Is_SDS = N'1'"
        If _ma_TO.Trim <> "" Then _Keyclient = _Keyclient + " AND Ma_To = '" + _ma_TO + "'"
        CyberSupport.V_Lookup("Ma_Hs", "DmKTVSC", _KeySQL, _Keyclient, M_Mode, M_Ma_Ct, M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_KTV2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterCVGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_Ct, sender, True)
        If DrReturn Is Nothing Then
            Dv_CV.Item(iRow).BeginEdit()
            Dv_CV.Item(iRow).Item("Ma_KTV2") = ""
            If Dv_CV.Table.Columns.Contains("Ten_KTV2") Then Dv_CV.Item(iRow).Item("Ten_KTV2") = ""
            Dv_CV.Item(iRow).EndEdit()
            Exit Sub
        Else
            Dv_CV.Item(iRow).BeginEdit()
            Dv_CV.Item(iRow).Item("Ma_KTV2") = DrReturn("Ma_HS").ToString.Trim
            If Dv_CV.Table.Columns.Contains("Ten_KTV2") And DrReturn.Table.Columns.Contains("Ten_HS") Then Dv_CV.Item(iRow).Item("Ten_KTV2") = DrReturn("Ten_HS").ToString.Trim
            Dv_CV.Item(iRow).EndEdit()
        End If
        Dt_CV.AcceptChanges()
        MasterCVGRV.UpdateCurrentRow()
        V_Sub_SetColorCV()
    End Sub
#End Region
#Region "Xác nhận bắt đầu/Kết thúc"
    'Private Sub V_Xac_nhan_BD(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If M_Mode = "M" Then Return
    '    Dim iRow As Integer = masterKTVGRV.GetFocusedDataSourceRowIndex
    '    If iRow < 0 Then Return
    '    If Dv_KTV.Item(iRow).Item("XN_BD").ToString.Trim <> "" Then
    '        If MsgBox("Bạn có xác nhận bắt đầu không?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Sysvar("M_CYBER_VER")) = MsgBoxResult.Cancel Then Return
    '    End If

    '    If Not Dv_KTV.Item(iRow).Item("Tag").ToString.Trim = "1" Then Return
    '    Dim _Ma_Hs As String = Dv_KTV.Item(iRow).Item("ma_HS").ToString.Trim
    '    If _Ma_Hs.Trim = "" Then Return
    '    Dim _StrKTV As String = "INSERT DMKTVCYBER SELECT N'" + _Ma_Hs + "'"
    '    Dim _Loai_XN As String = "BD"
    '    Dim _Stt_Rec_RO As String = TxtStt_Rec_RO.Text
    '    Dim _Stt_Rec As String = TxtStt_Rec.Text

    '    Dim _Return As Boolean = CyberProgress.V_Xac_Nhan("1", _StrKTV, _Stt_Rec_RO, _Stt_Rec, _Loai_XN, M_Loai_SC, "", _
    '                                                         AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    '    If Not _Return Then Return
    '    V_Thuc_Hien_XN(TxtStt_Rec.Text, _Ma_Hs)
    'End Sub
    'Private Sub V_Xac_nhan_BDAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If M_Mode = "M" Then Return
    '    If MsgBox("Bạn có xác nhận bắt đầu không?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Sysvar("M_CYBER_VER")) = MsgBoxResult.Cancel Then Return

    '    Dim _StrKTV As String = ""
    '    For iRow As Integer = 0 To Dv_KTV.Count - 1
    '        If Dv_KTV.Item(iRow).Item("tag").ToString.Trim = "1" Then
    '            _StrKTV = _StrKTV + ";INSERT DMKTVCYBER SELECT N'" + Dv_KTV.Item(iRow).Item("ma_HS").ToString.Trim + "'"
    '        End If
    '    Next
    '    If _StrKTV.Trim = "" Then Return
    '    Dim _Loai_XN As String = "BD"
    '    Dim _Stt_Rec_RO As String = TxtStt_Rec_RO.Text
    '    Dim _Stt_Rec As String = TxtStt_Rec.Text

    '    Dim _Return As Boolean = CyberProgress.V_Xac_Nhan("1", _StrKTV, _Stt_Rec_RO, _Stt_Rec, _Loai_XN, M_Loai_SC, "", _
    '                                                         AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    '    If Not _Return Then Return
    '    V_Thuc_Hien_XN(TxtStt_Rec.Text, "")

    'End Sub
    'Private Sub V_Xac_nhan_KT(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If M_Mode = "M" Then Return
    '    Dim iRow As Integer = masterKTVGRV.GetFocusedDataSourceRowIndex
    '    If iRow < 0 Then Return
    '    If Dv_KTV.Item(iRow).Item("XN_KT").ToString.Trim <> "" Then
    '        If MsgBox("Bạn có xác nhận kết thúc không?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Sysvar("M_CYBER_VER")) = MsgBoxResult.Cancel Then Return
    '    End If
    '    'If MsgBox("Bạn có xác nhận kết thúc không?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Sysvar("M_CYBER_VER")) = MsgBoxResult.Cancel Then Return
    '    If Not Dv_KTV.Item(iRow).Item("Tag").ToString.Trim = "1" Then Return
    '    Dim _Ma_Hs As String = Dv_KTV.Item(iRow).Item("ma_HS").ToString.Trim
    '    If _Ma_Hs.Trim = "" Then Return
    '    Dim _StrKTV As String = "INSERT DMKTVCYBER SELECT N'" + _Ma_Hs + "'"
    '    Dim _Loai_XN As String = "KT"
    '    Dim _Stt_Rec_RO As String = TxtStt_Rec_RO.Text
    '    Dim _Stt_Rec As String = TxtStt_Rec.Text

    '    Dim _Return As Boolean = CyberProgress.V_Xac_Nhan("1", _StrKTV, _Stt_Rec_RO, _Stt_Rec, _Loai_XN, M_Loai_SC, "", _
    '                                                         AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    '    If Not _Return Then Return
    '    V_Thuc_Hien_XN(TxtStt_Rec.Text, _Ma_Hs)

    'End Sub
    'Private Sub V_Xac_nhan_KTAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If MsgBox("Bạn có xác nhận kết thúc không?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Sysvar("M_CYBER_VER")) = MsgBoxResult.Cancel Then Return

    '    If M_Mode = "M" Then Return

    '    Dim _StrKTV As String = ""
    '    For iRow As Integer = 0 To Dv_KTV.Count - 1
    '        If Dv_KTV.Item(iRow).Item("tag").ToString.Trim = "1" Then
    '            _StrKTV = _StrKTV + ";INSERT DMKTVCYBER SELECT N'" + Dv_KTV.Item(iRow).Item("ma_HS").ToString.Trim + "'"
    '        End If
    '    Next
    '    If _StrKTV.Trim = "" Then Return
    '    Dim _Loai_XN As String = "KT"
    '    Dim _Stt_Rec_RO As String = TxtStt_Rec_RO.Text
    '    Dim _Stt_Rec As String = TxtStt_Rec.Text

    '    Dim _Return As Boolean = CyberProgress.V_Xac_Nhan("1", _StrKTV, _Stt_Rec_RO, _Stt_Rec, _Loai_XN, M_Loai_SC, "", _
    '                                                         AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    '    If Not _Return Then Return
    '    V_Thuc_Hien_XN(TxtStt_Rec.Text, "")
    'End Sub
#End Region
#Region "Event DragDrop"
    Private Sub V_Sub_SetColorCV()
        If M_Loai_Giao_Viec <> "1" Then Return

        For i As Integer = 0 To Dt_CV.Rows.Count - 1
            ''-----------------------------
            Dt_CV.Rows(i).BeginEdit()
            If Dt_CV.Columns.Contains("Tag") And Dt_CV.Columns.Contains("Bold") Then
                If Dt_CV.Rows(i).Item("Tag").ToString.Trim = "1" Then
                    Dt_CV.Rows(i).Item("Bold") = "1"
                    If Dt_CV.Columns.Contains("backColor") Then Dt_CV.Rows(i).Item("backColor") = "Pink"
                Else
                    If Dt_CV.Columns.Contains("backColor") Then Dt_CV.Rows(i).Item("backColor") = ""
                End If
            End If
            Dt_CV.Rows(i).EndEdit()
            ''-----------------------------
            Dt_CV.Rows(i).BeginEdit()
            If Dt_CV.Columns.Contains("BackColor") And (Dt_CV.Columns.Contains("Ma_KTV1")) Then
                If Dt_CV.Rows(i).Item("Ma_KTV1").ToString.Trim <> "" Then
                    If Dt_CV.Rows(i).Item("Tag").ToString.Trim <> "1" Then Dt_CV.Rows(i).Item("BackColor") = "YELLOW"
                Else
                    If Dt_CV.Rows(i).Item("Tag").ToString.Trim <> "1" Then Dt_CV.Rows(i).Item("BackColor") = ""
                End If
            End If
            Dt_CV.Rows(i).EndEdit()
            ''-----------------------------
        Next
        Dt_CV.AcceptChanges()
    End Sub
    Private Sub V_Sub_SetColorVT()
        If M_Loai_Giao_Viec <> "1" Then Return

        For i As Integer = 0 To Dt_VT.Rows.Count - 1
            ''-----------------------------
            Dt_VT.Rows(i).BeginEdit()
            If Dt_VT.Columns.Contains("Tag") And Dt_VT.Columns.Contains("Bold") Then
                If Dt_VT.Rows(i).Item("Tag").ToString.Trim = "1" Then
                    Dt_VT.Rows(i).Item("Bold") = "1"
                    If Dt_VT.Columns.Contains("backColor") Then Dt_VT.Rows(i).Item("backColor") = "Pink"
                Else
                    If Dt_VT.Columns.Contains("backColor") Then Dt_VT.Rows(i).Item("backColor") = ""
                End If
            End If
            Dt_VT.Rows(i).EndEdit()
            ''-----------------------------
        Next
        Dt_VT.AcceptChanges()
    End Sub

    Dim _keothatrongGrid As New ObjectDragDrop
    Dim _keotha2Grid As New ObjectDragDrop
    Dim _keotha2GridVT As New ObjectDragDrop

    Private Sub V_DragDropGridview()
        _keothatrongGrid = New ObjectDragDrop(MasterCV, Nothing)
        _keotha2Grid = New ObjectDragDrop(masterKTV, MasterCV)
        '_keotha2GridVT = New ObjectDragDrop(masterKTV, MasterVt)

        AddHandler MasterCV.DragDrop, AddressOf Master_DragDrop
        'AddHandler MasterVt.DragDrop, AddressOf Master_DragDrop_VT

    End Sub
    Private Sub Master_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim IRow_Master_CV As Integer = -1
        Dim grid As GridControl = TryCast(sender, GridControl)
        Dim gridview As GridView = TryCast(grid.MainView, GridView)
        Dim _Dr_MasterKTV As DataRow = TryCast(e.Data.GetData(GetType(DataRow)), DataRow)
        If _Dr_MasterKTV Is Nothing Then Exit Sub
        Dim hitInfo As GridHitInfo = gridview.CalcHitInfo(grid.PointToClient(New Point(e.X, e.Y)))
        IRow_Master_CV = hitInfo.RowHandle
        If IRow_Master_CV < 0 Then Exit Sub

        Dim _ColName As String = ""
        Try
            _ColName = hitInfo.Column.FieldName.ToUpper.Trim()
        Catch ex As Exception

        End Try
        Dim _KTV1 As Boolean = False
        Dim _KTV2 As Boolean = False
        Dim _Up_KTV12 As Boolean = True

        If Not EditCVMa_Ktv1 Is Nothing Then _KTV1 = True
        If _KTV1 Then If Not EditCVMa_Ktv2 Is Nothing Then _KTV2 = True
        If Not _KTV1 Then Return
        '-------------------------------------------------------------------------------------------
        If (_ColName.Trim.ToUpper = "MA_KTV2" Or _ColName.Trim.ToUpper = "TEN_KTV2") And (_ColName.Trim <> "") Then _Up_KTV12 = False
        If Not _KTV2 Then _Up_KTV12 = True
        '-------------------------------------------------------------------------------------------
        Dim _Stt_rec_RO As String = Dv_CV.Item(IRow_Master_CV).Item("Stt_rec_RO").ToString.Trim
        Dim _Stt_rec0_RO As String = Dv_CV.Item(IRow_Master_CV).Item("Stt_rec0_RO").ToString.Trim
        Dim _Ma_Hs As String = _Dr_MasterKTV.Item("ma_Hs").ToString.Trim
        Dim _Ten_Hs As String = _Dr_MasterKTV.Item("Ten_Hs").ToString.Trim
        Dim _Tag As String = _Dr_MasterKTV.Item("Tag").ToString.Trim
        '-------------------------------------------------------------------------------------------

        If _Tag.Trim.Trim <> "1" Then Return
        Dv_CV.BeginInit()
        If _KTV1 And _KTV2 Then
            If _Up_KTV12 Then
                Dv_CV.Item(IRow_Master_CV).Item("Ma_KTV1") = _Ma_Hs
                Dv_CV.Item(IRow_Master_CV).Item("ten_KTV1") = _Ten_Hs
            Else
                Dv_CV.Item(IRow_Master_CV).Item("Ma_KTV2") = _Ma_Hs
                Dv_CV.Item(IRow_Master_CV).Item("ten_KTV2") = _Ten_Hs
            End If
        Else ''---Chi Moi KTV1
            Dv_CV.Item(IRow_Master_CV).Item("Ma_KTV1") = _Ma_Hs
            Dv_CV.Item(IRow_Master_CV).Item("ten_KTV1") = _Ten_Hs
        End If
        Dv_CV.EndInit()
        Dt_CV.AcceptChanges()
        For i As Integer = 0 To Dt_CV.Rows.Count - 1
            If _Up_KTV12 Then
                If Dt_CV.Rows(i).Item("Ma_KTV1").ToString.Trim = "" Then
                    Dt_CV.Rows(i).Item("Ma_KTV1") = _Ma_Hs
                    Dt_CV.Rows(i).Item("Ten_KTV1") = _Ten_Hs
                End If
            Else
                If Dt_CV.Rows(i).Item("Ma_KTV2").ToString.Trim = "" Then
                    Dt_CV.Rows(i).Item("Ma_KTV2") = _Ma_Hs
                    Dt_CV.Rows(i).Item("Ten_KTV2") = _Ten_Hs
                End If
            End If
        Next
        Dt_CV.AcceptChanges()
        V_Sub_SetColorCV()

        '---------END UPDATE-----------------------------------------------------
        _keothatrongGrid._ActiDraDrop = False
        _keotha2Grid._ActiDraDrop = False
        CyberSmlib.FlushMemorySave()

    End Sub

    Private Sub Master_DragDrop_VT(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim IRow_Master_VT As Integer = -1
        Dim grid As GridControl = TryCast(sender, GridControl)
        Dim gridview As GridView = TryCast(grid.MainView, GridView)
        Dim _Dr_MasterKTV As DataRow = TryCast(e.Data.GetData(GetType(DataRow)), DataRow)
        If _Dr_MasterKTV Is Nothing Then Exit Sub
        Dim hitInfo As GridHitInfo = gridview.CalcHitInfo(grid.PointToClient(New Point(e.X, e.Y)))
        IRow_Master_VT = hitInfo.RowHandle
        If IRow_Master_VT < 0 Then Exit Sub

        Dim _ColName As String = ""
        Try
            _ColName = hitInfo.Column.FieldName.ToUpper.Trim()
        Catch ex As Exception

        End Try

        Dim _KTV As Boolean = False
        
        If Not EditMa_KtVt Is Nothing Then _KTV = True
        If Not _KTV Then Return

        '-------------------------------------------------------------------------------------------
        Dim _Stt_rec_RO As String = Dv_VT.Item(IRow_Master_VT).Item("Stt_rec_RO").ToString.Trim
        Dim _Stt_rec0_RO As String = Dv_VT.Item(IRow_Master_VT).Item("Stt_rec0_RO").ToString.Trim

        Dim _Ma_Hs As String = _Dr_MasterKTV.Item("ma_Hs").ToString.Trim
        Dim _Ten_Hs As String = _Dr_MasterKTV.Item("Ten_Hs").ToString.Trim
        Dim _Tag As String = _Dr_MasterKTV.Item("Tag").ToString.Trim
        '-------------------------------------------------------------------------------------------

        If _Tag.Trim.Trim <> "1" Then Return
        Dv_VT.BeginInit()
        If Dv_VT.Table.Columns.Contains("Ma_KTV") Then Dv_VT.Item(IRow_Master_VT).Item("Ma_KTV") = _Ma_Hs
        If Dv_VT.Table.Columns.Contains("Ten_KTV") Then Dv_VT.Item(IRow_Master_VT).Item("Ten_KTV") = _Ten_Hs

        Dv_VT.EndInit()
        Dt_VT.AcceptChanges()
        V_Sub_SetColorVT()
        '---------END UPDATE-----------------------------------------------------
        _keothatrongGrid._ActiDraDrop = False
        _keotha2GridVT._ActiDraDrop = False
        CyberSmlib.FlushMemorySave()
    End Sub

#End Region
#Region "/Giaoo/XeNăng lực xưởng"
    Private Sub V_Goi_Y_Khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Strkhoang As String = ""
        Dim _Dr As DataRow() = Dt_khoang.Select("tag ='1'")
        Dim _All As Boolean = False
        If _Dr.Length < 1 Then
            _All = True
            For i As Integer = 0 To Dt_khoang.Rows.Count - 1
                Dt_khoang.Rows(i).BeginEdit()
                Dt_khoang.Rows(i).Item("Tag") = "0"
                Dt_khoang.Rows(i).EndEdit()
            Next
        End If
        Dt_khoang.AcceptChanges()
        For i As Integer = 0 To Dt_khoang.Rows.Count - 1
            If Dt_khoang.Rows(i).Item("tag").ToString = "1" Or _All = True Then
                _Strkhoang = _Strkhoang + ";INSERT Dmkhoang SELECT N'" + Dt_khoang.Rows(i).Item("ma_khoang").ToString + "'"
            End If
        Next
        If _Strkhoang = "" Then
            MsgBox("Bạn chưa chọn khoang để thực hiện", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Return
        End If
        '----
        Dim _Dr_Khoang As DataRow = V_Goi_Y_Khoang(_Strkhoang)
        If _Dr_Khoang Is Nothing Then Return

        If Not _Dr_Khoang.Table.Columns.Contains("Ma_khoang") Then Return
        Dim _Ma_khoang As String = _Dr_Khoang.Item("Ma_khoang").ToString.Trim
        If _Ma_khoang.Trim = "" Then Return

        For i As Integer = 0 To Dt_khoang.Rows.Count - 1
            Dt_khoang.Rows(i).BeginEdit()
            If Dt_khoang.Rows(i).Item("Ma_khoang").ToString.Trim <> _Ma_khoang.Trim.ToUpper Then
                Dt_khoang.Rows(i).Item("Tag") = "0"
            Else
                CyberSmodb.V_UpdateRowtoRow(_Dr_Khoang, Dt_khoang, i)
                Dt_khoang.Rows(i).Item("Tag") = "1"
            End If
            Dt_khoang.Rows(i).EndEdit()
        Next
    End Sub
    Private Function V_Goi_Y_khoang(ByVal _Strkhoang As String) As DataRow
        Dim _Is_One_khoang As String = "1"
        Dim _Ma_Xe As String = TxtMa_Xe.Text
        Dim _So_Ro As String = TxtSo_Ro.Text
        Dim _So_Phut As String = TxtTG_SC.Double.ToString.Trim.Replace(" ", "").Replace(",", ".")
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Loai_Sc As String = IIf(ChkSCC.Checked, "1", "2")
        Dim _SCC As String = IIf(ChkSCC.Checked, "1", "0")
        Dim _SBD As String = IIf(ChkSBD.Checked, "1", "0")
        Dim _SDS As String = IIf(ChkSDS.Checked, "1", "0")
        Dim _Muc_SBD As String = CbbMuc_SBD.SelectedValue.ToString.Trim
        Dim _Muc_SDS As String = CbbMuc_SDS.SelectedValue.ToString.Trim

        If _Strkhoang = "" Then
            MsgBox("Bạn chưa chọn khoang để thực hiện", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Return Nothing
        End If
        If _So_Phut < 5 Then Return Nothing
        Dim Dstmp As DataSet = CyberWork.V_Goi_Y_khoangDatHen(_Strkhoang, "DLH", M_Stt_Rec, _Is_One_khoang, _Ma_Xe, _So_Ro, _So_Phut, _Ngay_BD, _
                                                                         _Loai_Sc, _SCC, _SBD, _SDS, _Muc_SBD, _Muc_SDS, _
                                                                          AppConn, Sysvar, M_LAN, Para, M_Ma_Dvcs, M_User_Name, CyberSmlib)

        For i As Integer = 0 To Dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(Dstmp.Tables(i))
        Next
        Dim nCount As Integer = Dstmp.Tables.Count - 1
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(nCount), Sysvar, M_LAN) Then
            Dstmp.Dispose()
            Return Nothing
        End If
        Dim _Return_Ma_Khoang As DataRow
        If nCount < 1 Then
            Dstmp.Dispose()
            Return Nothing
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Return Nothing
        End If
        _Return_Ma_Khoang = Dstmp.Tables(0).Copy.Rows(0)
        Dstmp.Dispose()
        Return _Return_Ma_Khoang
    End Function

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

#Region "Save/Quit..."
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        masterKhoangGRV.PostEditor()
        masterKTVGRV.PostEditor()

        MasterCVGRV.PostEditor()
        MasterVtGRV.PostEditor()

        Dt_khoang.AcceptChanges()
        Dt_KTV.AcceptChanges()
        Dt_CV.AcceptChanges()
        Dt_VT.AcceptChanges()
        Dt_KTVCV.AcceptChanges()

        Dim strXML As String = ""

        M_Stt_Rec = TxtStt_Rec.Text
        M_So_Ro = TxtSo_Ro.Text
        M_Stt_Rec_Ro = TxtStt_Rec_RO.Text
        '--------------------------------------------------------------------------------------------
        Dim drMaster As DataRow
        Dim CrrRow As Integer = 0
        drMaster = Dt_PH89CVDV.Rows(CrrRow)
        CyberSmodb.AddValueToRow(drMaster, Me)
        '--------------------------------------------------------------------------------------------

        Dim Dt_KhoangTmp As DataTable = Dt_khoang.Clone
        Dim Dt_KTVTmp As DataTable = Dt_KTV.Clone
        Dim Dt_CVTmp As DataTable = Dt_CV.Clone
        Dim Dt_VTTmp As DataTable = Dt_VT.Clone

        Dim Dr_Khoang As DataRow() = Dt_khoang.Select("Tag = '1'")
        Dim Dr_KTV As DataRow() = Dt_KTV.Select("Tag = '1'")
        Dim Dr_CV As DataRow() = Dt_CV.Select("Tag = '1'")
        Dim Dr_VT As DataRow() = Dt_VT.Select("Tag = '1'")

        '------------------------------
        For i As Integer = 0 To Dr_Khoang.Length - 1
            Dt_KhoangTmp.ImportRow(Dr_Khoang(i))
        Next
        Dt_KhoangTmp.AcceptChanges()
        '------------------------------
        For i As Integer = 0 To Dr_KTV.Length - 1
            Dt_KTVTmp.ImportRow(Dr_KTV(i))
        Next
        Dt_KTVTmp.AcceptChanges()
        '------------------------------
        For i As Integer = 0 To Dr_CV.Length - 1
            Dt_CVTmp.ImportRow(Dr_CV(i))
        Next
        Dt_CVTmp.AcceptChanges()
        '------------------------------
        For i As Integer = 0 To Dr_VT.Length - 1
            Dt_VTTmp.ImportRow(Dr_VT(i))
        Next
        Dt_VTTmp.AcceptChanges()
        '------------------------------
        If M_Loai_Giao_Viec = "1" Then Dt_KTVCV.Clear()

        ''strXML = CyberSmodb.V_ConvertDataToXML({"PH89CVDV_SCC", "DmKhoang", "PH89CVDV_SCC_KTV", "PH89CVDV_SCC_CV", "PH89CVDV_SCC_VT"}, {CyberSmodb.V_ConvertDrToTb(drMaster), Dt_KhoangTmp, Dt_KTVTmp, Dt_CVTmp, Dt_VTTmp})
        strXML = CyberSmodb.V_ConvertDataToXML({"PH89CVDV_SCC", "Khoang", "KTV", "CV", "VT", "KTVCV"}, {CyberSmodb.V_ConvertDrToTb(drMaster), Dt_KhoangTmp, Dt_KTVTmp, Dt_CVTmp, Dt_VTTmp, Dt_KTVCV})

        '--------------------------------------------------------------------------------------------
        Dim M_strParameterStore As String = M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Loai_Giao_Viec + "#" + M_Mode.Trim + "#" + M_Stt_Rec + "#" + M_Stt_Rec_Ro + "#" + M_So_Ro + "#" + strXML + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkPKH_Save", M_strParameterStore)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Me.Save_OK = False
            Me.M_Dt_Return = Nothing
            Exit Sub
        Else
            Me.Tag = M_Stt_Rec
            Me.M_Dt_Return = DsTmp.Tables(1).Copy
            Me.Save_OK = True
            DsTmp.Dispose()
            Me.Close()
        End If
    End Sub
#End Region

#Region "Loại giao việc"
    Private Sub V_SetLoai_Giao_Viec()
        Select Case M_Loai_Giao_Viec.Trim.ToUpper
            Case "2" '---- KTV ==> CV
                SplitContainer_KTVCV.RightToLeft = Windows.Forms.RightToLeft.No

            Case "3" '---- CV ==> KTV
                SplitContainer_KTVCV.RightToLeft = Windows.Forms.RightToLeft.Yes
            Case Else '---- KTV ==> CV+VT
                SplitContainer_KTVCV.RightToLeft = Windows.Forms.RightToLeft.No
        End Select

        masterKTV.RightToLeft = Windows.Forms.RightToLeft.No
        TabHDK.RightToLeft = Windows.Forms.RightToLeft.No
        MasterCV.RightToLeft = Windows.Forms.RightToLeft.No
        MasterVt.RightToLeft = Windows.Forms.RightToLeft.No
        ChkKTV_Chon.RightToLeft = Windows.Forms.RightToLeft.No
    End Sub

    Private Sub V_SetLoai_KTV_AND_CV(ByVal _iRow_KTV As Integer, ByVal _iRow_CV As Integer)
 

        If M_Loai_Giao_Viec = "1" Then Return
        If M_Loai_Giao_Viec = "2" And _iRow_KTV < 0 Then Return
        If M_Loai_Giao_Viec = "3" And _iRow_CV < 0 Then Return

        Select Case M_Loai_Giao_Viec.ToUpper.Trim
           
            Case "2"

                V_RemoveCVAll(New System.Object, New System.EventArgs)
                Dim _Ma_Hs As String = Dv_KTV.Item(_iRow_KTV).Item("Ma_hs").ToString.Trim
                Dim _Stt_Rec0_Ro As String = ""
                Dim Drs As DataRow() = Dt_KTVCV.Select("ma_Hs = '" + _Ma_Hs + "'")

                For i = 0 To Drs.Length - 1
                    _Stt_Rec0_Ro = Drs(i).Item("Stt_Rec0_Ro").ToString.Trim.ToUpper
                    For j As Integer = 0 To Dt_CV.Rows.Count - 1
                        If Dt_CV.Rows(j).Item("Stt_rec0_Ro").ToString.ToUpper.Trim = _Stt_Rec0_Ro Then
                            Dt_CV.Rows(j).BeginEdit()
                            Dt_CV.Rows(j).Item("tag") = "1"
                            Dt_CV.Rows(j).EndEdit()
                            Exit For
                        End If
                    Next
                Next
                Dt_CV.AcceptChanges()

            Case "3"
                Dim _Chinh_Phu As String = "0"
                Dim _Time_KTV As String = "0"
                V_RemoveKTVAll(New System.Object, New System.EventArgs)
                Dim _Stt_Rec0_Ro As String = Dv_CV.Item(_iRow_CV).Item("Stt_Rec0_Ro").ToString.Trim
                Dim _Ma_Hs As String = ""
                Dim Drs As DataRow() = Dt_KTVCV.Select("Stt_Rec0_Ro = '" + _Stt_Rec0_Ro + "'")

                For i = 0 To Drs.Length - 1
                    _Ma_Hs = Drs(i).Item("Ma_Hs").ToString.Trim.ToUpper
                    _Chinh_Phu = If(Dt_KTVCV.Columns.Contains("Chinh_phu"), Drs(i).Item("Chinh_phu").ToString.Trim.ToUpper, "0")
                    _Time_KTV = If(Dt_KTVCV.Columns.Contains("Time_KTV"), Drs(i).Item("Time_KTV").ToString.Trim.ToUpper, "0")

                    For j As Integer = 0 To Dt_KTV.Rows.Count - 1
                        If Dt_KTV.Rows(j).Item("Ma_Hs").ToString.ToUpper.Trim = _Ma_Hs Then
                            Dt_KTV.Rows(j).BeginEdit()
                            Dt_KTV.Rows(j).Item("tag") = "1"
                            If Dt_KTV.Columns.Contains("Chinh_phu") Then Dt_KTV.Rows(j).Item("Chinh_phu") = _Chinh_Phu
                            If Dt_KTV.Columns.Contains("Time_KTV") Then Dt_KTV.Rows(j).Item("Time_KTV") = _Time_KTV

                            Dt_KTV.Rows(j).EndEdit()
                            Exit For
                        End If
                    Next
                Next
                Dt_KTV.AcceptChanges()
        End Select
    End Sub

    Private Sub V_GetLoai_KTV_AND_CV(ByVal _iRow_KTV As Integer, ByVal _iRow_CV As Integer)

        If M_Loai_Giao_Viec = "1" Then Return
        If M_Loai_Giao_Viec = "2" And _iRow_KTV < 0 Then Return
        If M_Loai_Giao_Viec = "3" And _iRow_CV < 0 Then Return

        


        Select Case M_Loai_Giao_Viec.ToUpper.Trim
            Case "2"
                Dim _Chinh_Phu As String = "0"
                Dim _Time_KTV As String = "0"

                Dim _Ma_Hs As String = Dv_KTV.Item(_iRow_KTV).Item("Ma_hs").ToString.Trim.ToUpper
                Dim _tag As String = Dv_KTV.Item(_iRow_KTV).Item("tag").ToString.Trim

                _Chinh_Phu = If(Dt_KTV.Columns.Contains("Chinh_phu"), Dv_KTV.Item(_iRow_KTV).Item("Chinh_phu").ToString.Trim.ToUpper, "0")
                _Time_KTV = If(Dt_KTV.Columns.Contains("Time_KTV"), Dv_KTV.Item(_iRow_KTV).Item("Time_KTV").ToString.Trim.ToUpper, "0")

                For i As Integer = Dt_KTVCV.Rows.Count - 1 To 0 Step -1
                    If Dt_KTVCV.Rows(i).Item("Ma_Hs").ToString.Trim.ToUpper = _Ma_Hs Then
                        Dt_KTVCV.Rows(i).Delete()
                    End If
                Next
                Dt_KTVCV.AcceptChanges()
                If _tag = "1" Then 'Insert vao'
                    For i As Integer = 0 To Dt_CV.Rows.Count - 1
                        If Dt_CV.Rows(i).Item("Tag").ToString.Trim = "1" Then
                            Dt_KTVCV.Rows.Add(_Ma_Hs, Dt_CV.Rows(i).Item("Stt_Rec0_Ro").ToString.Trim, _Chinh_Phu, _Time_KTV)
                        End If
                    Next
                End If
                Dt_KTVCV.AcceptChanges()
            Case "3"
                Dim _Chinh_Phu As String = "0"
                Dim _Time_KTV As String = "0"

                Dim _Stt_Rec0_Ro As String = Dv_CV.Item(_iRow_CV).Item("Stt_Rec0_Ro").ToString.Trim.ToUpper
                Dim _tag As String = Dv_CV.Item(_iRow_CV).Item("tag").ToString.Trim

                For i As Integer = Dt_KTVCV.Rows.Count - 1 To 0 Step -1
                    If Dt_KTVCV.Rows(i).Item("Stt_Rec0_Ro").ToString.Trim.ToUpper = _Stt_Rec0_Ro Then
                        Dt_KTVCV.Rows(i).Delete()
                    End If
                Next
                Dt_KTVCV.AcceptChanges()
                If _tag = "1" Then 'Insert vao'
                    For i As Integer = 0 To Dt_KTV.Rows.Count - 1
                        If Dt_KTV.Rows(i).Item("Tag").ToString.Trim = "1" Then
                            _Chinh_Phu = If(Dt_KTV.Columns.Contains("Chinh_phu"), Dt_KTV.Rows(i).Item("Chinh_phu").ToString.Trim.ToUpper, "0")
                            _Time_KTV = If(Dt_KTV.Columns.Contains("Time_KTV"), Dt_KTV.Rows(i).Item("Time_KTV").ToString.Trim.ToUpper, "0")

                            Dt_KTVCV.Rows.Add(Dt_KTV.Rows(i).Item("Ma_Hs").ToString.Trim, _Stt_Rec0_Ro, _Chinh_Phu, _Time_KTV)
                        End If
                    Next
                End If
                Dt_KTVCV.AcceptChanges()
        End Select
    End Sub

    Private Sub MasterKTVGRV_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        If M_Loai_Giao_Viec <> "2" Then Return
        Dim _Row_KTV = masterKTVGRV.GetFocusedDataSourceRowIndex()
        Dim _Row_CV = MasterCVGRV.GetFocusedDataSourceRowIndex()
        V_SetLoai_KTV_AND_CV(_Row_KTV, _Row_CV)
        V_GetKTV_Chon()
    End Sub
    Private Sub MasterCVGRV_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)

        If M_Loai_Giao_Viec <> "3" Then Return
        Dim _Row_KTV = masterKTVGRV.GetFocusedDataSourceRowIndex()
        Dim _Row_CV = MasterCVGRV.GetFocusedDataSourceRowIndex()
        V_SetLoai_KTV_AND_CV(_Row_KTV, _Row_CV)
        V_GetKTV_Chon()

    End Sub
    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    'If M_Loai_Giao_Viec = "1" Then
    '    M_Loai_Giao_Viec = "2"
    '    V_SetLoai_Giao_Viec()
    '    Return
    'End If
    'If M_Loai_Giao_Viec = "2" Then
    '    M_Loai_Giao_Viec = "3"
    '    V_SetLoai_Giao_Viec()
    '    Return
    'End If
    'If M_Loai_Giao_Viec = "3" Then
    '    M_Loai_Giao_Viec = "1"
    '    V_SetLoai_Giao_Viec()
    '    Return
    'End If
    'End Sub
#End Region
End Class

Public Class ObjectDragDrop
    Dim downHitInfo As GridHitInfo = Nothing
    Dim _GridDrag As New DevExpress.XtraGrid.GridControl
    Dim _GridDrop As New DevExpress.XtraGrid.GridControl
    Dim _GrvDrag As New GridView
    Dim _GrvDrop As New GridView
    Public _ActiDraDrop As Boolean = False
    Public Sub New()
    End Sub
    Public Sub New(ByVal Grid_keo As DevExpress.XtraGrid.GridControl, ByVal Grid_Tha As DevExpress.XtraGrid.GridControl)
        _GridDrag = Grid_keo
        _GridDrop = IIf(Grid_Tha Is Nothing, Grid_keo, Grid_Tha)
        _GridDrop.AllowDrop = True
        _GridDrag.AllowDrop = True
        _GrvDrag = TryCast(_GridDrag.MainView, GridView)
        _GrvDrop = TryCast(_GridDrop.MainView, GridView)
        V_Addhandler()
    End Sub
    Private Sub V_Addhandler()
        AddHandler _GrvDrag.MouseMove, AddressOf view_MouseMove
        AddHandler _GrvDrag.MouseDown, AddressOf view_MouseDown
        AddHandler _GridDrop.DragOver, AddressOf grid_DragOver
    End Sub
    Private Sub view_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        _ActiDraDrop = False
        Dim view As GridView = TryCast(sender, GridView)
        downHitInfo = Nothing
        Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
        If Control.ModifierKeys <> Keys.None Then
            Return
        End If
        If e.Button = MouseButtons.Left AndAlso hitInfo.RowHandle >= 0 Then
            downHitInfo = hitInfo
            _ActiDraDrop = True
        End If
    End Sub
    Private Sub view_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim view As GridView = TryCast(sender, GridView)
        If e.Button = MouseButtons.Left AndAlso downHitInfo IsNot Nothing Then
            Dim dragSize As Size = SystemInformation.DragSize
            Dim dragRect As New Rectangle(New Point(downHitInfo.HitPoint.X - dragSize.Width / 2, downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize)
            If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
                Dim row As DataRow = view.GetDataRow(downHitInfo.RowHandle)
                view.GridControl.DoDragDrop(row, DragDropEffects.Move)
                downHitInfo = Nothing
                DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = True
            End If
        End If
    End Sub
    Private Sub grid_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If e.Data.GetDataPresent(GetType(DataRow)) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
End Class
