Imports System.Windows.Forms

Public Class FrmDLHen_F3
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
    Dim M_Kieu_Xem As String = "HEN"
    Dim M_Loai_SC As String = "1"
    Public Property Kieu_Xem As String
        Get
            Kieu_Xem = M_Kieu_Xem
        End Get
        Set(ByVal Value As String)
            M_Kieu_Xem = Value
        End Set
    End Property
    Public Property Loai_SC() As String
        Get
            Loai_SC = M_Loai_SC
        End Get
        Set(ByVal Value As String)
            M_Loai_SC = Value
        End Set
    End Property
    Dim M_Stt_Rec As String = "M"
    Public Property Stt_Rec() As String
        Get
            Stt_Rec = M_Stt_Rec
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec = Value
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
#Region "Bien"
    Dim CyberWork As New Sys
    Public M_Dt_Return As DataTable = Nothing

    Dim Dt_DmDlhen As DataTable

    Dim Dt_CVDV, Dt_khoang, Dt_To, Dt_KTV, Dt_KTV_Chon As DataTable
    Dim Dt_CVDVH, Dt_khoangH, Dt_ToH, Dt_KTVH As DataTable

    Dim Dv_CVDV, Dv_khoang, Dv_To, Dv_KTV, Dv_KTV_Chon As DataView
    Dim Dv_CVDVH, Dv_khoangH, Dv_ToH, Dv_KTVH As DataView

    Dim DmPost As New DataTable
    Dim Dt_DmMucSDS, Dt_DmMucSBD, Dt_DMTTCP, Dt_DMTTCP_Nhan As DataTable
    Dim Dt_HTLL As DataTable
    Dim Dt_Loai_Nhan As DataTable

    Dim EditCVDVTAG, EditCVDVXem_Hen As New Cyber.Fill.CyberColumnGridView
    Dim EditkhoangTAG, EditKhoangXem_Hen As New Cyber.Fill.CyberColumnGridView
    Dim EditKTVTag, EditKTVXem_Hen As New Cyber.Fill.CyberColumnGridView

#End Region
    Private Sub DmDLHen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load("1")
        V_AddHander()

        TxtSo_Ro.Enabled = False
        If M_Mode.Trim = "S" Then TxtMa_Xe.Enabled = False
        'If M_Loai_SC.Trim = "1" Then
        '    ChkSDS.Enabled = False

        '    ChkSCC.Enabled = True
        '    ChkSBD.Enabled = True
        '    If M_Mode = "M" Then ChkSCC.Checked = True
        '    ChkSDS.Checked = False
        'Else

        '    ChkSDS.Enabled = False
        '    ChkSCC.Enabled = False
        '    ChkSBD.Enabled = False
        '    If M_Mode = "M" Then ChkSDS.Checked = True

        '    ChkSCC.Checked = False
        '    ChkSBD.Checked = False

        'End If
        If M_Mode = "M" Then
            TxtMa_Xe.Focus()
            'TxtMa_Kx.Text = ""
            'TxtE_Mail.Text = ""
            'TxtTen_Lx.Text = ""
            'TXTDT_LX.Text = ""
            'TxtTen_kh.Text = ""
            'TxtDia_Chi.Text = ""
            'ChkSCC.Checked = 1
        End If

        CbbMa_TTCP.SelectedValue = Ma_TTCP

        V_VisbleMuc_SBD()
        V_VisbleMuc_SDS()
    End Sub
#Region "Load..."
    Private Sub V_Load(ByVal _Load As String)
        If M_Loai_SC.Trim = "" Then M_Loai_SC = "1"
        Dim _Str As String = _Load + "#" + M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Mode + "#" + M_Stt_Rec + "#" + M_Ngay_BD.ToString("yyyyMMdd HH:mm") + "#" + M_Ngay_KT.ToString("yyyyMMdd HH:mm")
        _Str = _Str + "#" + M_Ma_Xe + "#" + M_Ma_CVDV + "#" + M_Ma_khoang
        _Str = _Str + "#" + M_Ma_To + "#" + M_Ma_CD + "#" + M_Ma_KTV + "#" + M_Ma_TTCP + "#" + M_Ma_Dvcs + "#" + M_User_Name

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkDLH_Load", _Str)

        Dim iTb As Integer = 0
        Dt_DmDlhen = CyberWork.V_Gettable(iTb, Dstmp)
        '-----------------------------------------------------
        iTb = iTb + 1
        Dt_CVDV = CyberWork.V_Gettable(iTb, Dstmp)
        iTb = iTb + 1
        Dt_CVDVH = CyberWork.V_Gettable(iTb, Dstmp)
        Dv_CVDV = New DataView(Dt_CVDV)
        Dv_CVDVH = New DataView(Dt_CVDVH)
        '-----------------------------------------------------
        iTb = iTb + 1
        Dt_khoang = CyberWork.V_Gettable(iTb, Dstmp)
        iTb = iTb + 1
        Dt_khoangH = CyberWork.V_Gettable(iTb, Dstmp)
        Dv_khoang = New DataView(Dt_khoang)
        Dv_khoangH = New DataView(Dt_khoangH)
        '-----------------------------------------------------
        iTb = iTb + 1
        Dt_To = CyberWork.V_Gettable(iTb, Dstmp)
        iTb = iTb + 1
        Dt_ToH = CyberWork.V_Gettable(iTb, Dstmp)
        Dv_To = New DataView(Dt_To)
        Dv_ToH = New DataView(Dt_ToH)
        '-----------------------------------------------------
        iTb = iTb + 1
        Dt_KTV = CyberWork.V_Gettable(iTb, Dstmp)
        iTb = iTb + 1
        Dt_KTVH = CyberWork.V_Gettable(iTb, Dstmp)
        Dv_KTV = New DataView(Dt_KTV)
        Dv_KTVH = New DataView(Dt_KTVH)
        '-----------------------------------------------------
        Dt_KTV_Chon = Dt_KTV.Clone
        Dv_KTV_Chon = New DataView(Dt_KTV_Chon)

        ChkKTV_Chon.DataSource = Dv_KTV_Chon
        ChkKTV_Chon.DisplayMember = Dt_KTV_Chon.Columns("Ten_Hs").ColumnName
        ChkKTV_Chon.ValueMember = Dt_KTV_Chon.Columns("Ma_Hs").ColumnName

        '-----------------------------------------------------
        iTb = iTb + 1
        Dt_DmMucSBD = CyberWork.V_Gettable(iTb, Dstmp)

        '-----------------------------------------------------
        iTb = iTb + 1
        Dt_DmMucSDS = CyberWork.V_Gettable(iTb, Dstmp)

        '-----------------------------------------------------
        iTb = iTb + 1
        Dt_Loai_Nhan = CyberWork.V_Gettable(iTb, Dstmp)

        '-----------------------------------------------------
        iTb = iTb + 1
        Dt_HTLL = CyberWork.V_Gettable(iTb, Dstmp)
        '-----------------------------------------------------

        iTb = iTb + 1
        DmPost = CyberWork.V_Gettable(iTb, Dstmp)

        iTb = iTb + 1
        Dt_DMTTCP = CyberWork.V_Gettable(iTb, Dstmp)
        Dt_DMTTCP_Nhan = CyberWork.V_Gettable(iTb, Dstmp)


        '---------------------------------------------------------------------------------------------------------------------------------------------------------------
        masterCVDV.DataSource = Dv_CVDV
        CyberFill.V_FillReports(MasterCVDVGRV, M_LAN, Dv_CVDVH, Dv_CVDV)

        masterKhoang.DataSource = Dv_khoang
        CyberFill.V_FillReports(masterKhoangGRV, M_LAN, Dv_khoangH, Dv_khoang)

        masterKTV.DataSource = Dv_KTV
        CyberFill.V_FillReports(masterKTVGRV, M_LAN, Dv_KTVH, Dv_KTV)

        CyberFill.V_FillComBoxDefaul(CbbMa_To, Dt_To, "ma_To", "Ten_To", "Ngam_Dinh")


        CyberFill.V_FillComBoxDefaul(CbbMuc_SBD, Dt_DmMucSBD, "Muc_SBD", "ten_SBD", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMuc_SDS, Dt_DmMucSDS, "Muc_SDS", "ten_SDS", "Ngam_Dinh")

        CyberFill.V_FillComBoxDefaul(CbbLoai_Nhan, Dt_Loai_Nhan, "Loai_Nhan", "Ten", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_HTLL, Dt_HTLL, "MA_HTLL", "Ten_HTLL", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CBBma_post, DmPost, "Ma_Post", If(M_LAN = "V", "Ten_Post", "Ten_Post2"), "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_TTCP, Dt_DMTTCP, "Ma_TTCP", "Ten_TTCP", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_TTCP_Nhan, Dt_DMTTCP_Nhan, "Ma_TTCP", "Ten_TTCP", "Ngam_Dinh")

        CyberSmodb.SetValueTObj(Me, Dt_DmDlhen.Rows(0))
        M_Stt_Rec = Dt_DmDlhen.Rows(0).Item("Stt_Rec")


        V_GetKTV_Chon()

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
        EditCVDVTAG.GetColumn(MasterCVDVGRV, "TAG")
        EditkhoangTAG.GetColumn(masterKhoangGRV, "TAG")
        EditKTVTag.GetColumn(masterKTVGRV, "TAG")

        EditCVDVXem_Hen.GetColumn(MasterCVDVGRV, "Xem_Hen")
        EditKhoangXem_Hen.GetColumn(masterKhoangGRV, "Xem_Hen")
        EditKTVXem_Hen.GetColumn(masterKTVGRV, "Xem_Hen")

        '-------------------------------------------------------------------------------------------------------
        If Not EditCVDVTAG.Column Is Nothing Then AddHandler EditCVDVTAG.EditColumn.EditValueChanged, AddressOf V_CLICK_CVDV
        If Not EditkhoangTAG.Column Is Nothing Then AddHandler EditkhoangTAG.EditColumn.EditValueChanged, AddressOf V_CLICK_KHoang_tag
        If Not EditKTVTag.Column Is Nothing Then AddHandler EditKTVTag.EditColumn.EditValueChanged, AddressOf V_CLICK_KTV_tag


        'If Not EditCVDVXem_Hen.Column Is Nothing Then AddHandler EditCVDVXem_Hen.EditColumn.Click, AddressOf V_Xem_Hen_CVDV
        'If Not EditKhoangXem_Hen.Column Is Nothing Then AddHandler EditKhoangXem_Hen.EditColumn.Click, AddressOf V_Xem_Hen_Khoang
        'If Not EditKTVXem_Hen.Column Is Nothing Then AddHandler EditKTVXem_Hen.EditColumn.Click, AddressOf V_Xem_Hen_KTV
        '-------------------------------------------------------------------------------------------------------

        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
        AddHandler LabMa_Xe.Click, AddressOf V_Ma_Xe_Click
        AddHandler CbbMa_To.SelectedIndexChanged, AddressOf V_Ma_TO

        AddHandler ButtCall.Click, AddressOf V_Call

        AddHandler ChkSCC.CheckedChanged, AddressOf V_Chk_SSC
        AddHandler ChkSBD.CheckedChanged, AddressOf V_Chk_SBD
        AddHandler CbbMuc_SBD.SelectedIndexChanged, AddressOf V_Muc_SBD

        AddHandler ChkSDS.CheckedChanged, AddressOf V_Chk_SDS
        AddHandler CbbMuc_SDS.SelectedIndexChanged, AddressOf V_Muc_SDS
        '-------------------------------------------------------------------------------------------------------
        AddHandler TxtTG_SC.Leave, AddressOf V_TG_SC
        AddHandler TxtNgay_Den.Leave, AddressOf V_Ngay_Den
        AddHandler TxtNgay_BD.Leave, AddressOf V_Ngay_BD
        AddHandler TxtNgay_KT.Leave, AddressOf V_Ngay_KT
        AddHandler TxtNgay_HenKT.Leave, AddressOf V_Ngay_Gx
        '---------------------------------------------------------
        AddHandler TxtMa_SC.CyberValiting, AddressOf V_Ma_sc
        AddHandler TxtMa_SC.CyberLeave, AddressOf L_Ma_sc

        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_KX
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_KX

        '-------------------------------------------------------------------------------------------------------
        AddHandler ButtOK.Click, AddressOf V_Nhan
        '-------------------------------------------------------------------------------------------------------
        AddHandler CmdGoi_Y_CVDV.Click, AddressOf V_Goi_Y_CVDV
        AddHandler CmdGoi_Y_Khoang.Click, AddressOf V_Goi_Y_Khoang

        AddHandler ÇmdXem_LSSC.Click, AddressOf V_Lich_Su_SC
        AddHandler ÇmdXem_LS_Hen.Click, AddressOf V_Lich_Su_Hen
        AddHandler ÇmdNang_Luc_Xuong.Click, AddressOf V_Nang_Luc_Xuong
        AddHandler CmdTraCuu.Click, AddressOf V_TraCuu_LH


        '-------------------------------------------------------------------------------------------------------
        AddHandler masterKTVGRV.PopupMenuShowing, AddressOf masterKTVGRV_PopupMenuShowing
        AddHandler masterKhoangGRV.PopupMenuShowing, AddressOf masterKhoangGRV_PopupMenuShowing

        '-------------------------------------------------------------------------------------------------------
        AddHandler MasterCVDVGRV.RowCellStyle, AddressOf Master_CVDVGRV_RowCellStyle
        AddHandler masterKhoangGRV.RowCellStyle, AddressOf Master_khoangGRV_RowCellStyle
        AddHandler masterKTVGRV.RowCellStyle, AddressOf Master_KTVGRV_RowCellStyle

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_SetDefault()
        MasterCVDVGRV.ColumnPanelRowHeight = 30
        masterKhoangGRV.ColumnPanelRowHeight = 30
        masterKTVGRV.ColumnPanelRowHeight = 30
    End Sub

#End Region
#Region "Xe/To"
    Private Sub V_Ma_Xe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim Dr = CyberSmlistSys.V_CheckAndAddRowList(M_LAN, Me.Para, Me.Sysvar, AppConn, "DMXE", "Ma_Xe= N'" & TxtMa_Xe.Text.Trim.Replace("'", "").Replace("#", "") & "'", "MA_XE#", TxtMa_Xe.Text.Trim, True)
        If Dr Is Nothing Then Exit Sub
        V_LoadMa_Xe(TxtMa_Xe.Text.Trim)
        V_Tinh_Tien_TG()

    End Sub
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        V_LoadMa_Xe(TxtMa_Xe.Text.Trim)

    End Sub
    Private Sub V_LoadMa_Xe(ByVal _Ma_Xe As String)
        Dim drMaster As DataRow
        Dim CrrRow As Integer = 0
        drMaster = Dt_DmDlhen.Rows(CrrRow)
        CyberSmodb.AddValueToRow(drMaster, Me)
        Dim strXML As String = CyberSmodb.V_ConvertDataToXML({"DmDlHen_CVDV"}, {CyberSmodb.V_ConvertDrToTb(drMaster)})
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkDLH_Ma_Xe", M_Mode + "#" + M_Stt_Rec + "#" + TxtMa_Xe.Text.Trim + "#" + strXML + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Exit Sub
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Exit Sub
        End If
        CyberSmodb.SetValueTObj_1(Me, Dstmp.Tables(0)(0))
        Dstmp.Dispose()
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
#Region "K/xGoi sua chua"
    Dim DsLookup As DataSet
    Private Sub V_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_KX", "DmKX", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("ma_KX")
            TXTTEN_KX.Text = DrReturn.Item("ten_KX")
            V_Tinh_Tien_TG()
        Else
            TxtMa_Kx.Text = ""
            TXTTEN_KX.Text = ""
        End If
    End Sub
    Private Sub V_Ma_sc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DsLookup = Nothing
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_sc", "Dmsc", "Ma_kx = N'" + TxtMa_Kx.Text.Trim + "'", "1=1")
    End Sub
    Private Sub L_Ma_sc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_SC.Text = DrReturn.Item("ma_sc")
            TxtTen_SC.Text = DrReturn.Item("ten_sc")
            V_Tinh_Tien_TG()
        Else
            TxtMa_SC.Text = ""
            TxtTen_SC.Text = ""
        End If
    End Sub
    Private Sub V_Tinh_Tien_TG()
        Dim _Ma_Xe As String = TxtMa_Xe.Text
        Dim _Ma_Sc As String = TxtMa_SC.Text
        Dim _SCC As String = If(ChkSCC.Checked, "1", "0")
        Dim _SBD As String = If(ChkSBD.Checked, "1", "0")
        Dim _SDS As String = If(ChkSDS.Checked, "1", "0")

        Dim _Muc_SBD As String = CyberWork.V_GetvalueCombox(CbbMuc_SBD)
        If _Muc_SBD = "" Then _Muc_SBD = "1"
        Dim _Muc_SDS As String = CyberWork.V_GetvalueCombox(CbbMuc_SDS)
        If _Muc_SDS = "" Then _Muc_SDS = "1"

        Dim _So_Phut As Decimal = TxtTG_SC.Double
        If _So_Phut < 0 Then
            _So_Phut = 0
            TxtTG_SC.Double = 0
        End If

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkDLH_CPSC", _So_Phut.ToString.Trim.Replace(" ", "").Replace(",", ".") & "#" & M_Loai_SC & "#" & _
                                                                  M_Mode & "#" & M_Stt_Rec & "#" & _
                                                                  _Ma_Xe & "#" & _Ma_Sc & "#" & _
                                                                  _SCC & "#" & _SBD & "#" & _SDS & "#" & _Muc_SBD & "#" & _Muc_SDS & "#" & _
                                                                  M_Ma_Dvcs & "#" + M_User_Name)
        If DsTmp.Tables.Count = 0 Then
            DsTmp.Dispose()
            Return
        End If
        CyberSmodb.SetNotNullTable(DsTmp.Tables(0))

        If DsTmp.Tables(0).Columns.Contains("Tong_tien") Then TxtGia_tri.Double = DsTmp.Tables(0).Rows(0).Item("Tong_tien")
        If DsTmp.Tables(0).Columns.Contains("So_phut") Then If DsTmp.Tables(0).Rows(0).Item("So_phut") > 0 Then TxtTG_SC.Double = DsTmp.Tables(0).Rows(0).Item("So_phut")
        If DsTmp.Tables(0).Columns.Contains("Muc_SBD") Then If DsTmp.Tables(0).Rows(0).Item("Muc_SBD") <> "" Then CbbMuc_SBD.SelectedValue = DsTmp.Tables(0).Rows(0).Item("Muc_SBD")

        If DsTmp.Tables(0).Columns.Contains("Ma_SC") Then TxtMa_SC.Text = DsTmp.Tables(0).Rows(0).Item("Ma_SC")
        If DsTmp.Tables(0).Columns.Contains("Ten_SC") Then TxtTen_SC.Text = DsTmp.Tables(0).Rows(0).Item("Ten_SC")

        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        TxtNgay_KT.Value = _Ngay_BD.AddMinutes(TxtTG_SC.Double)

        DsTmp.Dispose()
    End Sub
#End Region
#Region "Chk Loai SC"
    Private Sub V_Chk_SSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSCC.Checked And Not ChkSBD.Checked And (Not ChkSDS.Checked Or Not ChkSDS.Enabled) Then
            If ChkSBD.Enabled Then ChkSBD.Checked = True
        End If
        V_Tinh_Tien_TG()
    End Sub
    Private Sub V_Chk_SBD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSCC.Checked And Not ChkSBD.Checked And Not ChkSDS.Checked Then
            If ChkSDS.Enabled Then ChkSDS.Checked = True Else ChkSCC.Checked = True
        End If
        V_Tinh_Tien_TG()
    End Sub
    Private Sub V_Chk_SDS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not ChkSCC.Checked And Not ChkSBD.Checked And Not ChkSDS.Checked Then
            If ChkSCC.Enabled Then ChkSCC.Checked = True
        End If
        V_Tinh_Tien_TG()
    End Sub
    Private Sub V_VisbleMuc_SDS()
        CbbMuc_SDS.Visible = ChkSDS.Checked
    End Sub
    Private Sub V_VisbleMuc_SBD()
        CbbMuc_SBD.Visible = ChkSBD.Checked
    End Sub
    Private Sub V_SDS(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSDS.CheckedChanged
        V_VisbleMuc_SDS()
        V_Tinh_Tien_TG()
    End Sub
    Private Sub V_SBD(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSBD.CheckedChanged
        V_VisbleMuc_SBD()
        V_Tinh_Tien_TG()
    End Sub
    Private Sub V_Muc_SBD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Tinh_Tien_TG()
    End Sub
    Private Sub V_Muc_SDS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Tinh_Tien_TG()
    End Sub
#End Region
#Region "Thoi gian/Ngay"
    Private Sub V_Ngay_Den(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_Den As Date = TxtNgay_Den.Value
        'If M_Mode = "S" And _Ngay_Den.Date <> Date.Now().Date Then
        '    MsgBox("Không được thay đổi ngày hẹn!")
        '    TxtNgay_Den.Value = Now()
        '    Return
        'End If
        TxtNgay_BD.Value = CyberWork.V_AddTime(_Ngay_Den, 15, AppConn, CyberSmlib, M_Ma_Dvcs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        If TxtTG_SC.Double > 0 Then
            TxtNgay_KT.Value = CyberWork.V_AddTime(_Ngay_BD, TxtTG_SC.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        End If
        V_Ngay_Gx(sender, e)
    End Sub
    Private Sub V_TG_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        If TxtTG_SC.Double <= 0 Then TxtTG_SC.Double = 0
        TxtNgay_KT.Value = CyberWork.V_AddTime(_Ngay_BD, TxtTG_SC.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        V_Ngay_Gx(sender, e)
    End Sub
    Private Sub V_Ngay_BD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        If TxtTG_SC.Double > 0 Then
            TxtNgay_KT.Value = CyberWork.V_AddTime(_Ngay_BD, TxtTG_SC.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        End If
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        TxtTG_SC.Double = CyberWork.V_GetTimeM(_Ngay_BD, _Ngay_KT, AppConn, CyberSmlib, M_Ma_Dvcs)
        V_Ngay_Gx(sender, e)
    End Sub
    Private Sub V_Ngay_KT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        TxtTG_SC.Double = CyberWork.V_GetTimeM(_Ngay_BD, _Ngay_KT, AppConn, CyberSmlib, M_Ma_Dvcs)
        V_Ngay_Gx(sender, e)
    End Sub
    Private Sub V_Ngay_Gx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNgay_HenKT.Value = DateAdd(DateInterval.Minute, 15, TxtNgay_KT.Value)
    End Sub
#End Region
#Region "Click.."
    Private Sub V_CLICK_CVDV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MasterCVDVGRV.PostEditor()
        MasterCVDVGRV.UpdateCurrentRow()

        Dim iRow As Integer = MasterCVDVGRV.GetFocusedDataSourceRowIndex
        For i = 0 To Dv_CVDV.Count - 1
            Dv_CVDV.Item(i).BeginEdit()
            If i <> iRow Then
                Dv_CVDV.Item(i).Item("TAG") = "0"
            End If
            Dv_CVDV.Item(i).EndEdit()
        Next
        Dt_CVDV.AcceptChanges()
        MasterCVDVGRV.UpdateCurrentRow()
    End Sub
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
                ''If Dt_khoang.Columns.Contains("ForeColor") Then Dv_khoang.Item(i).Item("ForeColor") = ""
            End If
            Dv_khoang.Item(i).EndEdit()
        Next
        Dt_khoang.AcceptChanges()
        masterKhoangGRV.UpdateCurrentRow()
        'If Not _Strkhoang.Trim = "" And _iRow_Update >= 0 Then
        '    Dim _Dr_Khoang As DataRow = V_Goi_Y_Khoang(_Strkhoang)
        '    If _Dr_Khoang Is Nothing Then Return

        '    If Not _Dr_Khoang.Table.Columns.Contains("Ma_khoang") Then Return
        '    Dim _Ma_khoang As String = _Dr_Khoang.Item("Ma_khoang").ToString.Trim
        '    If _Ma_khoang.Trim = "" Then Return
        '    CyberSmodb.V_UpdateRowtoRow(_Dr_Khoang, Dt_khoang, _iRow_Update)
        '    masterKhoangGRV.UpdateCurrentRow()
        'End If
    End Sub
    Private Sub V_CLICK_KTV_tag(ByVal sender As System.Object, ByVal e As System.EventArgs)
        masterKTVGRV.PostEditor()
        masterKTVGRV.UpdateCurrentRow()
        Dim iRow As Integer = masterKTVGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_GetKTV_Chon()
    End Sub
    Private Sub V_UpdateKTV_XN(ByVal _Stt_Rec As String, ByVal _Ma_Hs As String)
        'V_RemoveKTVAll(New System.Object, New System.EventArgs)
        'V_Thuc_Hien_XN(_Stt_Rec, _Ma_Hs)
    End Sub

    Private Sub V_Thuc_Hien_XN(ByVal _Stt_Rec As String, ByVal _Ma_Hs As String)
        Dim DstmpKTV_UP As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_XN_Load", _Stt_Rec & "#" & _Ma_Hs & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        For i As Integer = 0 To DstmpKTV_UP.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DstmpKTV_UP.Tables(i))
        Next
        If DstmpKTV_UP.Tables.Count = 0 Then Return

        For i As Integer = 0 To DstmpKTV_UP.Tables(0).Rows.Count - 1
            For IRow As Integer = 0 To Dv_KTV.Count - 1
                If DstmpKTV_UP.Tables(0).Rows(i).Item("Ma_Hs").ToString.Trim = Dv_KTV.Item(IRow).Item("Ma_Hs").ToString.Trim Then
                    CyberSmodb.V_UpdateRowtoRow(DstmpKTV_UP.Tables(0).Rows(i), Dv_KTV, IRow)
                    Exit For
                End If
            Next
        Next
        masterKTVGRV.UpdateCurrentRow()
    End Sub
#End Region
#Region "Chon/Remove"
    Private Sub masterKTVGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()


        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn tất", "Select All"), AddressOf V_SelectKTVAll, Shortcut.CtrlA, Nothing, True, True)).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gỡ chọn", "Remove All"), AddressOf V_RemoveKTVAll, Shortcut.CtrlU, Nothing, True, True)).BeginGroup = False
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)

        'End If
    End Sub
    Private Sub masterKhoangGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn EM", "Select EM"), AddressOf V_SelectkhoangAll_EM, Shortcut.CtrlE, Nothing, True, True)).BeginGroup = False
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn GJ", "Select GJ"), AddressOf V_SelectkhoangAll_GJ, Shortcut.CtrlG, Nothing, True, True)).BeginGroup = False

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn tất", "Select All"), AddressOf V_SelectkhoangAll, Shortcut.CtrlA, Nothing, True, True)).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gỡ chọn", "Remove All"), AddressOf V_RemovekhoangAll, Shortcut.CtrlU, Nothing, True, True)).BeginGroup = False
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)

        'End If
    End Sub
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
    End Sub
#End Region
#Region "RowCellStyle"
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub Master_CVDVGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        'CyberSupport.DetailGRV_RowCellStyle2(sender, e, masterKhoangGRV, Dt_khoang, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterCVDVGRV, Dt_CVDV, Me.Font, "Tag", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub Master_khoangGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        'CyberSupport.DetailGRV_RowCellStyle2(sender, e, masterKhoangGRV, Dt_khoang, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, masterKhoangGRV, Dt_khoang, Me.Font, "Tag", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub Master_KTVGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        'CyberSupport.DetailGRV_RowCellStyle2(sender, e, masterKTVGRV, Dt_KTV, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, masterKTVGRV, Dt_KTV, Me.Font, "Tag", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
#End Region
#Region "Save/Quit..."
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strXML As String = ""
        '--------------------------------------------------------------------------------------------
        Dim drMaster As DataRow
        Dim CrrRow As Integer = 0
        drMaster = Dt_DmDlhen.Rows(CrrRow)
        CyberSmodb.AddValueToRow(drMaster, Me)
        '--------------------------------------------------------------------------------------------
        Dim Dt_CVDVTmp As DataTable = Dt_CVDV.Clone
        Dim Dt_KhoangTmp As DataTable = Dt_khoang.Clone
        Dim Dt_KTVTmp As DataTable = Dt_KTV.Clone

        Dim Dr_CVDv As DataRow() = Dt_CVDV.Select("Tag = '1'")
        Dim Dr_Khoang As DataRow() = Dt_khoang.Select("Tag = '1'")
        Dim Dr_KTV As DataRow() = Dt_KTV.Select("Tag = '1'")
        '------------------------------
        For i As Integer = 0 To Dr_CVDv.Length - 1
            Dt_CVDVTmp.ImportRow(Dr_CVDv(i))
        Next
        Dt_CVDVTmp.AcceptChanges()
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
        strXML = CyberSmodb.V_ConvertDataToXML({"DmDlHen_CVDV", "DmCVDV", "DmKHoang", "DMKTVSC"}, {CyberSmodb.V_ConvertDrToTb(drMaster), Dt_CVDVTmp, Dt_KhoangTmp, Dt_KTVTmp})
        '--------------------------------------------------------------------------------------------
        Dim M_strParameterStore As String = M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Mode.Trim + "#" + M_Stt_Rec + "#" + strXML + "#" + M_Ma_TTCP + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkDLH_Save", M_strParameterStore)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Me.Save_OK = False
            Me.M_Dt_Return = Nothing
            Exit Sub
        Else
            M_Stt_Rec = DsTmp.Tables(1).Rows(0).Item("Stt_rec")
            Me.Tag = M_Stt_Rec
            Me.M_Dt_Return = DsTmp.Tables(1).Copy
            Me.Save_OK = True
            DsTmp.Dispose()
            Me.Close()
        End If

    End Sub
#End Region
#Region "Hỗ trợ: Gợi ý CVDV/Khoang: Lịch sử sửa chữa, Lịch sử hẹn, Năng lực xưởng "
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
    Private Sub V_Goi_Y_CVDV(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim _ma_Xe As String = TxtMa_Xe.Text
        Dim _Loai_Sc As String = M_Loai_SC.Trim
        If _Loai_Sc.Trim = "" Then _Loai_Sc = "1"
        _Loai_Sc = Strings.Left(_Loai_Sc.Trim, 1)
        Dim _SCC As String = If(ChkSCC.Checked, "1", "0")
        Dim _SBD As String = If(ChkSBD.Checked, "1", "0")
        Dim _SDS As String = If(ChkSDS.Checked, "1", "0")

        Dim _Muc_SBD As String = CyberWork.V_GetvalueCombox(CbbMuc_SBD)
        Dim _Muc_SDS As String = CyberWork.V_GetvalueCombox(CbbMuc_SDS)
        Dim _Tg_Sc As String = TxtTG_SC.Double.ToString.Trim.Replace(" ", "").Replace(",", ".")
        Dim _Ngay_Den As Date = TxtNgay_Den.Value
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value

        Dim _ma_khoang As String = ""
        For i As Integer = 0 To Dt_khoang.Rows.Count - 1
            If Dt_khoang.Rows(i).Item("Tag").ToString.Trim = "1" Then
                _ma_khoang = Dt_khoang.Rows(i).Item("ma_khoang").ToString.Trim
            End If
        Next

        Dim _ma_Hs As String = ""
        For i As Integer = 0 To Dt_CVDV.Rows.Count - 1
            If Dt_CVDV.Rows(i).Item("Tag").ToString.Trim = "1" Then
                _ma_Hs = Dt_CVDV.Rows(i).Item("ma_Hs").ToString.Trim
            End If
        Next
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Hen_OptimalSelection", _ma_Xe & "#" & _Loai_Sc & "#" & _SCC & "#" & _SDS & "#" & _SBD & "#" & _Muc_SBD & "#" & _Muc_SDS & "#" & _Tg_Sc & "#" & _Ngay_Den.ToString("yyyyMMdd HH:mm") & "#" & _Ngay_BD.ToString("yyyyMMdd HH:mm") & "#" & _Ngay_KT.ToString("yyyyMMdd HH:mm") & "#" & _ma_khoang & "#" & _ma_Hs & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If DsTmp.Tables.Count = 0 Then
            DsTmp.Dispose()
            Return
        End If
        If DsTmp.Tables(0).Rows.Count = 0 Then
            DsTmp.Dispose()
            Return
        End If
        Dim _ma_Hs_Up As String = ""
        Dim _ma_khoang_Up As String = ""
        If DsTmp.Tables(0).Columns.Contains("Ma_Hs") Then _ma_Hs_Up = DsTmp.Tables(0).Rows(0).Item("ma_hs").ToString.Trim()
        If DsTmp.Tables(0).Columns.Contains("Ma_khoang") Then _ma_khoang_Up = DsTmp.Tables(0).Rows(0).Item("Ma_khoang").ToString.Trim()
        V_Update_CVDV_Khoang(Dt_CVDV, _ma_Hs_Up, "Ma_Hs")
        V_Update_CVDV_Khoang(Dt_khoang, _ma_khoang_Up, "Ma_khoang")

    End Sub
    Private Sub V_Update_CVDV_Khoang(ByVal _Dt As DataTable, ByVal _value As String, ByVal _Fieldname As String)
        _value = _value.Trim
        _Fieldname = _Fieldname.Trim

        If _value.Trim = "" Then Return
        If _Dt Is Nothing Then Return
        If Not _Dt.Columns.Contains("tag") Then Return
        If Not _Dt.Columns.Contains(_Fieldname) Then Return

        For i As Integer = 0 To _Dt.Rows.Count - 1
            _Dt.Rows(i).BeginEdit()
            If _Dt.Rows(i).Item(_Fieldname).ToString.Trim.ToUpper = _value.Trim.ToUpper Then
                _Dt.Rows(i).Item("Tag") = "1"
            Else
                _Dt.Rows(i).Item("Tag") = "0"
            End If
            _Dt.Rows(i).EndEdit()
        Next
        _Dt.AcceptChanges()
    End Sub
    Private Sub V_TraCuu_LH(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Frm As New CRMTraCuuLHen

        Frm.Lan = M_LAN
        Frm.Para = Me.Para
        Frm.Sysvar = Sysvar
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
    Private Sub V_Nang_Luc_Xuong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Tg_SC As Decimal = TxtTG_SC.Double
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        Dim _DsTmpNLX As DataSet = CyberWork.V_Tinh_Khoang(M_Kieu_Xem, M_Loai_SC, M_Stt_Rec, "DLH", TxtMa_Xe.Text, TxtSo_Ro.Text, _Tg_SC, _Ngay_BD, _Ngay_KT, AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
#End Region
    Private Sub V_Call(ByVal sender As Object, ByVal e As EventArgs)
        ' Xác định Tổng đài của cộc gọi
        Dim _NhKx As String = CyberSmodb.SQLGetvalue(AppConn, "Nh_Kx2", "DmKx", "Ma_Kx = N'" + TxtMa_Kx.Text.Trim + "'", CyberSmlib)
        Dim _TongDai As String = ""
        If _NhKx.Trim = "18" Then ' Xe MG
            _TongDai = "02"
        Else
            _TongDai = "01"
        End If
        Dim sys As New CyberGoiDien.LibGoiDien
        Dim ds As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Call_GetUser", _TongDai + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        'Dim stt_rec As String = Guid.NewGuid.ToString.Substring(0, 6) + "HDS"
        Dim sdt As String = TXTDT_LX.Text
        If sys.V_Call(ds.Tables(0).Rows(0).Item("ID_ConfigCall").ToString, sdt, ds.Tables(0).Rows(0).Item("Server").ToString,
                   ds.Tables(0).Rows(0).Item("Proxy").ToString, ds.Tables(0).Rows(0).Item("CallExt").ToString,
                   ds.Tables(0).Rows(0).Item("Pass").ToString, ds.Tables(0).Rows(0).Item("LinkSIP").ToString) Then
            CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Call_SaveData", "WF#" + Stt_Rec + "#" + ds.Tables(0).Rows(0).Item("CallExt") + "#" + sdt + "##" + M_Ma_Dvcs + "#" + M_User_Name)
        End If
    End Sub
End Class
