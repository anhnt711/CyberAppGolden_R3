Imports System.Windows.Forms
Imports System.Drawing
Public Class FrmDat_Cho_F3
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

#Region "Bien"
    Dim CyberWork As New Sys
    Public M_Dt_Return As DataTable = Nothing

    Dim Dt_DmPDC As DataTable

    Dim Dt_CVDV, Dt_khoang, Dt_To, Dt_KTV, Dt_KTV_Chon As DataTable
    Dim Dt_CVDVH, Dt_khoangH, Dt_ToH, Dt_KTVH As DataTable

    Dim Dv_CVDV, Dv_khoang, Dv_To, Dv_KTV, Dv_KTV_Chon As DataView
    Dim Dv_CVDVH, Dv_khoangH, Dv_ToH, Dv_KTVH As DataView


    Dim EditCVDVTAG, EditCVDVXem_Hen As New Cyber.Fill.CyberColumnGridView
    Dim EditkhoangTAG, EditKhoangXem_Hen As New Cyber.Fill.CyberColumnGridView
    Dim EditKTVTag, EditKTVXem_Hen As New Cyber.Fill.CyberColumnGridView

#End Region
    Private Sub FrmPDC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        '------------------------------------------------------------------------------------------------------------------
        V_Load("1")
        '------------------------------------------------------------------------------------------------------------------
        V_AddHander()
        '------------------------------------------------------------------------------------------------------------------
        If M_Mode = "M" Then Me.Text = "Tạo mới đặt chỗ" Else Me.Text = "Sửu đặt chỗ"
        '------------------------------------------------------------------------------------------------------------------
        MasterCVDVGRV.ColumnPanelRowHeight = 30
        masterKhoangGRV.ColumnPanelRowHeight = 30
        masterKTVGRV.ColumnPanelRowHeight = 30
        '------------------------------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '------------------------------------------------------------------------------------------------------------------
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub V_Load(ByVal _Load As String)
        If M_Loai_SC.Trim = "" Then M_Loai_SC = "1"
        Dim _Str As String = _Load + "#" + M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Mode + "#" + M_Stt_Rec + "#" + M_Ngay_BD.ToString("yyyyMMdd HH:mm") + "#" + M_Ngay_KT.ToString("yyyyMMdd HH:mm")
        _Str = _Str + "#" + M_Ma_Xe + "#" + M_Ma_CVDV + "#" + M_Ma_khoang
        _Str = _Str + "#" + M_Ma_To + "#" + M_Ma_CD + "#" + M_Ma_KTV + "#" + M_Ma_Dvcs + "#" + M_User_Name

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkPDC_Load", _Str)

        Dim iTb As Integer = 0
        Dt_DmPDC = CyberWork.V_Gettable(iTb, Dstmp)
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

        '---------------------------------------------------------------------------------------------------------------------------------------------------------------
        masterCVDV.DataSource = Dv_CVDV
        CyberFill.V_FillReports(MasterCVDVGRV, M_LAN, Dv_CVDVH, Dv_CVDV)

        masterKhoang.DataSource = Dv_khoang
        CyberFill.V_FillReports(masterKhoangGRV, M_LAN, Dv_khoangH, Dv_khoang)

        masterKTV.DataSource = Dv_KTV
        CyberFill.V_FillReports(masterKTVGRV, M_LAN, Dv_KTVH, Dv_KTV)
        CyberFill.V_FillComBoxDefaul(CbbMa_To, Dt_To, "ma_To", "Ten_To", "Ngam_Dinh")

        CyberFill.V_FillComBoxDefaul(CbbMa_To, Dt_To, "ma_To", "Ten_To", "Ngam_Dinh")


        CyberSmodb.SetValueTObj(Me, Dt_DmPDC.Rows(0))
        M_Stt_Rec = Dt_DmPDC.Rows(0).Item("Stt_Rec")

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
        '-------------------------------------------------------------------------------------------------------
        AddHandler TxtTG_SC.Leave, AddressOf V_TG_SC
        AddHandler TxtNgay_BD.Leave, AddressOf V_Ngay_BD
        AddHandler TxtNgay_KT.Leave, AddressOf V_Ngay_KT
        '-------------------------------------------------------------------------------------------------------
        AddHandler ButtOK.Click, AddressOf V_Nhan

        AddHandler MasterCVDVGRV.RowCellStyle, AddressOf Master_CVDVGRV_RowCellStyle
        AddHandler masterKhoangGRV.RowCellStyle, AddressOf Master_khoangGRV_RowCellStyle
        AddHandler masterKTVGRV.RowCellStyle, AddressOf Master_KTVGRV_RowCellStyle

    End Sub
#Region "Xe/To"
    Private Sub V_Ma_Xe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim Dr = CyberSmlistSys.V_CheckAndAddRowList(M_LAN, Me.Para, Me.Sysvar, AppConn, "DMXE", "Ma_Xe= N'" & TxtMa_Xe.Text.Trim.Replace("'", "").Replace("#", "") & "'", "MA_XE#", TxtMa_Xe.Text.Trim, True)
        'Dim Dr As DataRow = CyberSmodb.SQLGetRow(AppConn,"Dmxe","Ma_Xe = N'" + TxtMa_Xe.Text + "'",CyberSmlib)
        If Dr Is Nothing Then Exit Sub
        TxtMa_Xe.Text = Dr.Item("Ma_Xe")
        If Dr.Table.Columns.Contains("Ten_LX") Then TxtTen_Lx.Text = Dr.Item("Ten_Lx")
        If Dr.Table.Columns.Contains("Dt_Lx") Then TXTDT_LX.Text = Dr.Item("Dt_Lx")

    End Sub
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim Dr As DataRow = CyberSmodb.SQLGetRow(AppConn, "Dmxe", "Ma_Xe = N'" + TxtMa_Xe.Text + "'", CyberSmlib)
        If Dr Is Nothing Then Exit Sub
        If Dr.Table.Columns.Contains("Ten_LX") Then TxtTen_Lx.Text = Dr.Item("Ten_Lx")
        If Dr.Table.Columns.Contains("Dt_Lx") Then TXTDT_LX.Text = Dr.Item("Dt_Lx")

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
#Region "Thoi gian/Ngay"
    Private Sub V_TG_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        If TxtTG_SC.Double <= 0 Then TxtTG_SC.Double = 0
        TxtNgay_KT.Value = CyberWork.V_AddTime(_Ngay_BD, TxtTG_SC.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_Ngay_BD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        If TxtTG_SC.Double > 0 Then
            TxtNgay_KT.Value = CyberWork.V_AddTime(_Ngay_BD, TxtTG_SC.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        End If
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        TxtTG_SC.Double = CyberWork.V_GetTimeM(_Ngay_BD, _Ngay_KT, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_Ngay_KT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        TxtTG_SC.Double = CyberWork.V_GetTimeM(_Ngay_BD, _Ngay_KT, AppConn, CyberSmlib, M_Ma_Dvcs)
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
        Dim DstmpKTV_UP As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RO_CVDV_KH_SCC_Load_XN", _Stt_Rec & "#" & _Ma_Hs & "#" & M_Ma_Dvcs & "#" & M_User_Name)
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
    Dim CyberColor As New Cyber.Color.Sys
#Region "RowCellStyle"
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
        drMaster = Dt_DmPDC.Rows(CrrRow)
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
        strXML = CyberSmodb.V_ConvertDataToXML({"PH89CVDV_SCC", "DmCVDV", "DmKHoang", "DMKTVSC"}, {CyberSmodb.V_ConvertDrToTb(drMaster), Dt_CVDVTmp, Dt_KhoangTmp, Dt_KTVTmp})
        '--------------------------------------------------------------------------------------------
        Dim M_strParameterStore As String = M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Mode.Trim + "#" + M_Stt_Rec + "#" + strXML + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkPDC_Save", M_strParameterStore)
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
    
End Class
