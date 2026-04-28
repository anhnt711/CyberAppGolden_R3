Imports System.Drawing
Imports System.Windows.Forms

Public Class FrmTien_Do_TimKhoang
#Region "AddProperty"
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
    Dim M_Stt_Rec As String = ""
    Public Property Stt_Rec() As String
        Get
            Stt_Rec = M_Stt_Rec
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec = Value
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
    Dim M_So_Ro As String = ""
    Public Property So_Ro() As String
        Get
            So_Ro = M_So_Ro
        End Get
        Set(ByVal Value As String)
            M_So_Ro = Value
        End Set
    End Property
    Dim M_Ma_Ct As String = ""
    Public Property Ma_Ct() As String
        Get
            Ma_Ct = M_Ma_Ct
        End Get
        Set(ByVal Value As String)
            M_Ma_Ct = Value
        End Set
    End Property
    Dim M_So_Phut As Decimal = 0
    Public Property So_Phut() As Decimal
        Get
            So_Phut = M_So_Phut
        End Get
        Set(ByVal Value As Decimal)
            M_So_Phut = Value
        End Set
    End Property
    Dim M_Ngay_BD0 As Date = Now.Date
    Public Property Ngay_BD0() As Date
        Get
            Ngay_BD0 = M_Ngay_BD0
        End Get
        Set(ByVal Value As Date)
            M_Ngay_BD0 = Value
        End Set
    End Property
    Dim M_Ngay_KT0 As Date = Now.Date
    Public Property Ngay_KT0() As Date
        Get
            Ngay_KT0 = M_Ngay_KT0
        End Get
        Set(ByVal Value As Date)
            M_Ngay_KT0 = Value
        End Set
    End Property
    Dim M_Ds_Return As DataSet
    Public Property Ds_Return() As DataSet
        Get
            Ds_Return = M_Ds_Return
        End Get
        Set(ByVal Value As DataSet)
            M_Ds_Return = Value
        End Set
    End Property
#End Region
#Region "Khai báo biến"
    Dim CyberColor As New Cyber.Color.Sys
    Dim CyberWork As New Cyber.Workprogress.Sys
    Dim EditkhoangTAG, EditKhoangXem_Hen As New Cyber.Fill.CyberColumnGridView
    Dim Dt_khoang, Dt_khoangH, Dt_DmMucSBD, Dt_DmMucSDS As DataTable
    Dim Dv_khoang, Dv_khoangH As DataView
    
#End Region
    Private Sub FrmTien_Do_TimKhoang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Ds_Return = Nothing
        Me.Save_OK = False
        If M_So_Phut < 0 Then M_So_Phut = 0
        If M_Ngay_BD0 < Now.Date Then M_Ngay_BD0 = Now.Date

        TxtSo_Ro0.Text = M_So_Ro
        TxtMa_Xe0.Text = M_Ma_Xe
        TxtTG_SC0.Double = M_So_Phut
        TxtNgay_BD0.Value = M_Ngay_BD0
        '------------------------------------------------------------
        V_CreateFillMucSDS()
        '------------------------------------------------------------
        V_Load()
        '------------------------------------------------------------
        V_Addhander()
        '------------------------------------------------------------
        If Loai_SC.Trim = "2" Then
            ChkSDS.Checked = True
            ChkSCC.Checked = False
        Else
            ChkSDS.Checked = False
            ChkSCC.Checked = True
        End If
        Me.Text = IIf(M_LAN = "V", "Năng lực xưởng", "Workshop capacity")
        V_VisibleMuc_SDS_SCC()
        '------------------------------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '------------------------------------------------------------------------------------------------------------------

    End Sub
    Private Sub V_Tim_khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Ds_Return = Nothing
        Dim _Is_One_khoang As String = IIf(ChkIs_One_khoang.Checked, "1", "0")
        Dim _Ma_Xe As String = TxtMa_Xe0.Text
        Dim _So_Ro As String = TxtSo_Ro0.Text
        Dim _So_Phut As String = TxtTG_SC0.Double.ToString.Trim.Replace(" ", "").Replace(",", ".")
        Dim _Ngay_BD As Date = TxtNgay_BD0.Value
        Dim _Loai_Sc As String = IIf(ChkSCC.Checked, "1", "2")
        Dim _SCC As String = IIf(ChkSCC.Checked, "1", "0")
        Dim _SBD As String = IIf(ChkSBD.Checked, "1", "0")
        Dim _SDS As String = IIf(ChkSDS.Checked, "1", "0")
        Dim _Muc_SBD As String = CbbMuc_SBD.SelectedValue.ToString.Trim
        Dim _Muc_SDS As String = CbbMuc_SDS.SelectedValue.ToString.Trim

        Dim _Strkhoang As String = ""

        For i As Integer = 0 To Dt_khoang.Rows.Count - 1
            If Dt_khoang.Rows(i).Item("tag").ToString = "1" Then
                _Strkhoang = _Strkhoang + ";INSERT Dmkhoang SELECT N'" + Dt_khoang.Rows(i).Item("ma_khoang").ToString + "'"
            End If
        Next
        If _Strkhoang = "" Then
            MsgBox("Bạn chưa chọn khoang để thực hiện", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Return
        End If
        Dim Dstmp As DataSet = CyberWork.V_Goi_Y_khoang(_Strkhoang, M_Ma_Ct, M_Stt_Rec, _Is_One_khoang, _Ma_Xe, _So_Ro, _So_Phut, _Ngay_BD, _
                                                                         _Loai_Sc, _SCC, _SBD, _SDS, _Muc_SBD, _Muc_SDS, _
                                                                          AppConn, Sysvar, M_LAN, Para, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        If Dstmp Is Nothing Then Return

        If DsTmp.Tables.Count <= 1 Then
            DsTmp.Dispose()
            Me.Ds_Return = Nothing
            Exit Sub
        End If

        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next
        Dim nCount As Integer = DsTmp.Tables.Count - 1

        If DsTmp.Tables(nCount).Columns.Contains("Tg_SC") Then TxtTG_SC.Double = DsTmp.Tables(nCount).Rows(0).Item("Tg_SC")
        If DsTmp.Tables(nCount).Columns.Contains("Ngay_BD") Then TxtNgay_BD.Value = DsTmp.Tables(nCount).Rows(0).Item("Ngay_BD")
        If DsTmp.Tables(nCount).Columns.Contains("Ngay_KT") Then TxtNgay_KT.Value = DsTmp.Tables(nCount).Rows(0).Item("Ngay_KT")
        If DsTmp.Tables(nCount).Columns.Contains("Dien_Giai") Then TxtDien_Giai.Text = DsTmp.Tables(nCount).Rows(0).Item("Dien_Giai")


        If Not CyberSupport.V_MsgChk(DsTmp.Tables(nCount), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Me.Ds_Return = Nothing
            Exit Sub
        End If
        For i As Integer = 0 To Dt_khoang.Rows.Count - 1
            Dt_khoang.Rows(i).BeginEdit()
            If Dt_khoang.Columns.Contains("Chon") Then Dt_khoang.Rows(i).Item("Chon") = "0"
            If Dt_khoang.Columns.Contains("BackColor") Then Dt_khoang.Rows(i).Item("BackColor") = ""
            If Dt_khoang.Columns.Contains("BackColor2") Then Dt_khoang.Rows(i).Item("BackColor2") = ""
            If Dt_khoang.Columns.Contains("Bold") Then Dt_khoang.Rows(i).Item("Bold") = "0"
            If Dt_khoang.Columns.Contains("Forecolor") Then Dt_khoang.Rows(i).Item("Forecolor") = ""
            If Dt_khoang.Columns.Contains("Dien_Giai") Then Dt_khoang.Rows(i).Item("Dien_Giai") = ""

            If Dt_khoang.Columns.Contains("Ngay1") Then Dt_khoang.Rows(i).Item("Ngay1") = New Date(1900, 1, 1, 0, 0, 0, 0)
            If Dt_khoang.Columns.Contains("Ngay2") Then Dt_khoang.Rows(i).Item("Ngay2") = New Date(1900, 1, 1, 0, 0, 0, 0)

            Dt_khoang.Rows(i).EndEdit()
        Next
        Dt_khoang.AcceptChanges()

        If DsTmp.Tables(0).Columns.Contains("ma_khoang") And Dt_khoang.Columns.Contains("ma_khoang") Then
            For i As Integer = 0 To DsTmp.Tables(0).Rows.Count - 1
                For iRow As Integer = 0 To Dt_khoang.Rows.Count - 1
                    If Dt_khoang.Rows(iRow).Item("Ma_khoang") = DsTmp.Tables(0).Rows(i).Item("ma_khoang") Then
                        CyberSmodb.V_UpdateRowtoRow(DsTmp.Tables(0).Rows(i), Dt_khoang, iRow)
                        Exit For
                    End If
                Next
            Next
        End If
        Dt_khoang.AcceptChanges()
        Me.Ds_Return = DsTmp.Copy
        DsTmp.Dispose()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim DstmpKhoang As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_TinhThoigianRong_DsKhoang", "1#0#" & M_Loai_SC & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dt_khoang = DstmpKhoang.Tables(0).Copy
        Dt_khoangH = DstmpKhoang.Tables(1).Copy
        Dv_khoang = New DataView(Dt_khoang)
        Dv_khoangH = New DataView(Dt_khoangH)
        masterKhoang.DataSource = Dv_khoang
        CyberFill.V_FillReports(masterKhoangGRV, M_LAN, Dv_khoangH, Dv_khoang)
        DstmpKhoang.Dispose()

    End Sub
    Private Sub V_Addhander()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmdTim_khoang.Click, AddressOf V_Tim_khoang
        AddHandler TxtNgay_BD0.Leave, AddressOf V_Ngay_BD0
        AddHandler TxtTG_SC0.Leave, AddressOf V_TG_SC0

        AddHandler ChkSCC.CheckedChanged, AddressOf V_Chk_SSC
        AddHandler ChkSBD.CheckedChanged, AddressOf V_Chk_SBD
        AddHandler ChkSDS.CheckedChanged, AddressOf V_Chk_SDS
        AddHandler masterKhoangGRV.RowCellStyle, AddressOf MasterkhoangGRV_RowCellStyle

        EditkhoangTAG.GetColumn(masterKhoangGRV, "TAG")
        EditKhoangXem_Hen.GetColumn(masterKhoangGRV, "Xem_Hen")

        If Not EditkhoangTAG.Column Is Nothing Then AddHandler EditkhoangTAG.EditColumn.Click, AddressOf V_CLICK_KHoang_tag
        If Not EditKhoangXem_Hen.Column Is Nothing Then AddHandler EditKhoangXem_Hen.EditColumn.Click, AddressOf V_Xem_Hen_Khoang
    End Sub
    Private Sub V_Ngay_BD0(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtNgay_BD0.Value < Now.Date Then TxtNgay_BD0.Value = Now.Date
    End Sub
    Private Sub V_TG_SC0(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtTG_SC0.Double < 0 Then TxtTG_SC0.Double = 0
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#Region "Khoang"
    Private Sub masterKhoangGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn tất", "Select All"), AddressOf V_SelectkhoangAll, Shortcut.CtrlA, Nothing, True, True)).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gỡ chọn", "Remove All"), AddressOf V_RemovekhoangAll, Shortcut.CtrlU, Nothing, True, True)).BeginGroup = False
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
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
    Private Sub V_CLICK_KHoang_tag(ByVal sender As System.Object, ByVal e As System.EventArgs)
        masterKhoangGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_Xem_Hen_Khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim IROW As Integer = masterKhoangGRV.GetFocusedDataSourceRowIndex
        Dim _Stt_Rec As String = ""
        Dim _Ma_Xe As String = ""
        Dim _Ma_Khoang As String = ""
        If IROW >= 0 Then If Dt_khoang.Columns.Contains("Ma_KHoang") Then _Ma_Khoang = Dv_khoang.Item(IROW).Item("Ma_Khoang")
        Dim _Ngay_Ct1 As Date = TxtNgay_BD.Value
        Dim _Ngay_Ct2 As Date = TxtNgay_KT.Value
        Dim _Return As String = ""
        Dim _StrSQL As String = "1#1#1#1#" + _Stt_Rec + "#" + _Ma_Xe + "#" + _Ma_Khoang + "#" + _Ngay_Ct1.ToString("yyyyMMdd") + "#" + _Ngay_Ct2.ToString("yyyyMMdd") + "#" + _Return + "#" + M_Ma_Dvcs + "#" + M_User_Name
        '   CyberWork.V_Xem("CP_RO_CVDV_Hen", _StrSQL, "DANH SÁCH LỊCH HẸN", AppConn, Sysvar, Para, Lan, True, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberVoucher, CyberLoading, False)
    End Sub
    Private Sub MasterkhoangGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, masterKhoangGRV, Dt_khoang, Me.Font)
    End Sub

#End Region
#Region "sửa chữa đồng sơn/Mức bảo dưỡng/SCC"
    Private Sub V_Chk_SSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkSCC.Checked Then ChkSDS.Checked = True
        If Not ChkSCC.Checked Then ChkSBD.Checked = False
        ChkSDS.Checked = Not ChkSCC.Checked
        V_VisibleMuc_SDS_SCC()
    End Sub
    Private Sub V_Chk_SBD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkSCC.Checked Then ChkSBD.Checked = False
        V_VisibleMuc_SDS_SCC()
    End Sub
    Private Sub V_Chk_SDS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ChkSCC.Checked = Not ChkSDS.Checked
        V_VisibleMuc_SDS_SCC()
    End Sub
    Private Sub V_CreateFillMucSDS()

        Dim Str1 As String = "SELECT Muc_SBD,ten_SBD,ten_SBD as ten_SBD2,[Default] as Ngam_Dinh	FROM dbo.DmMucSBD WITH (NOLOCK) ORDER BY Muc_SBD"
        Dim Dstmp1 As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", Str1 + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dt_DmMucSBD = Dstmp1.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(CbbMuc_SBD, Dt_DmMucSBD, "Muc_SBD", If(M_LAN = "V", "Ten_SBD", "Ten_SBD2"), "Ngam_Dinh")

        Dim Str2 As String = "SELECT Muc_SDS,ten_SDS,ten_SDS as ten_SDS2,[Default] as Ngam_Dinh	FROM dbo.DmMucSDS WITH (NOLOCK) ORDER BY Muc_SDS"
        Dim Dstmp2 As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", Str2 + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dt_DmMucSDS = Dstmp2.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(CbbMuc_SDS, Dt_DmMucSDS, "Muc_SDS", If(M_LAN = "V", "Ten_SDS", "Ten_SDS2"), "Ngam_Dinh")
    End Sub
    Private Sub V_VisibleMuc_SDS_SCC()
        CbbMuc_SDS.Visible = ChkSDS.Checked
        CbbMuc_SBD.Visible = ChkSBD.Checked And ChkSCC.Checked
    End Sub
#End Region
End Class

