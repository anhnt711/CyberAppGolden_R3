Public Class RO_X01
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtTTLN, DtMa_Loai, DtLoai_SC As DataTable
    Dim _ChkBien_so As String = "0"
    Dim M_Para As String()
    Public M_Loai_BC As String = "VND"
    Public oSysVar As New Collection()
    Private Sub RO_X01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_Addhander()
        TxtM_Ngay_Ct1.Select()
    End Sub
#Region "Load"
    Private Sub V_Load()
        V_AddMenuShorcut()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        'TxtMa_To.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_To)
        TxtMa_Khoang.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Khoang)
        TxtMa_KTV.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_KTV)
        TxtMa_Hs.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs)
        TxtSo_RO.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtSo_RO)
        TxtMa_Xe.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Xe)
        TxtMa_Kx.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Kx)

        If TxtMa_To.Text.Trim = "" Then TxtTen_To.Text = "" Else TxtTen_To.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_to", "Dmto", "Ma_to = N'" + TxtMa_To.Text.Trim + "'", CyberSmLib)
        If TxtMa_Khoang.Text.Trim = "" Then TxtTen_khoang.Text = "" Else TxtTen_khoang.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_khoang", "DmKhoang", "Ma_khoang = N'" + TxtMa_Khoang.Text.Trim + "'", CyberSmLib)
        If TxtMa_Hs.Text.Trim = "" Then TxtTen_Hs.Text = "" Else TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "DmHS", "Ma_HS = N'" + TxtMa_Hs.Text.Trim + "'", CyberSmLib)
        If TxtMa_KTV.Text.Trim = "" Then TxtTen_KTV.Text = "" Else TxtTen_KTV.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "DmKTV", "Ma_HS = N'" + TxtMa_KTV.Text.Trim + "'", CyberSmLib)
        If TxtMa_Kx.Text.Trim = "" Then TxtTen_Kx.Text = "" Else TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_KX", "DmKx", "Ma_KX = N'" + TxtMa_Kx.Text.Trim + "'", CyberSmLib)

        '-----Loại BC
        Dim _DsMa_Loai As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'Ma_Loai' AND Acti = N'1'#ID")
        DtMa_Loai = _DsMa_Loai.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_Loai, DtMa_Loai, "Nhom", "Ten_nhom")

        '-----Loại SC
        Dim _DsLoai_Sc As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'Loai_SC' AND Acti = N'1'#ID")
        DtLoai_SC = _DsLoai_Sc.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CBBLoai_SC, DtLoai_SC, "Nhom", "Ten_nhom")

        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        AddHandler CmdList_Ma_kho.Click, AddressOf V_List_Ma_Kho

        '--Ma_to
        AddHandler TxtMa_To.CyberValiting, AddressOf V_Ma_TO
        AddHandler TxtMa_To.CyberLeave, AddressOf L_Ma_TO

        '--Ma_khoang
        AddHandler TxtMa_Khoang.CyberValiting, AddressOf V_Ma_Khoang
        AddHandler TxtMa_Khoang.CyberLeave, AddressOf L_Ma_Khoang

        '-- nh_Khoang1
        AddHandler TxtNh_khoang1.CyberValiting, AddressOf V_Nh_Khoang1
        AddHandler TxtNh_khoang1.CyberLeave, AddressOf L_Nh_Khoang1
        '-- nh_Khoang2
        AddHandler TxtNh_khoang2.CyberValiting, AddressOf V_Nh_Khoang2
        AddHandler TxtNh_khoang2.CyberLeave, AddressOf L_Nh_Khoang2
        '-- nh_Khoang3
        AddHandler TxtNh_khoang3.CyberValiting, AddressOf V_Nh_Khoang3
        AddHandler TxtNh_khoang3.CyberLeave, AddressOf L_Nh_Khoang3

        '--Ma_HS
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_HS
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_HS

        '--Ma_KTV
        AddHandler TxtMa_KTV.CyberValiting, AddressOf V_Ma_KTV
        AddHandler TxtMa_KTV.CyberLeave, AddressOf L_Ma_KTV

        '-- Ma Xe
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe

        '-- Ma Kx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx

    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_TO"
    Private Sub V_Ma_TO(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_To.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_TO", "DmToSC", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TO(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_To.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_To.Text = DrReturn.Item("Ma_to")
            TxtTen_To.Text = DrReturn.Item("Ten_to")
        Else
            TxtMa_To.Text = ""
            TxtTen_To.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Khoang"
    Private Sub V_Ma_Khoang(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Khoang.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Khoang", "DmKhoang", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Khoang(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Khoang.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Khoang.Text = DrReturn.Item("Ma_Khoang")
            TxtTen_khoang.Text = DrReturn.Item("Ten_Khoang")
        Else
            TxtMa_Khoang.Text = ""
            TxtTen_khoang.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub V_Nh_Khoang1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_khoang1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "Dmnhkhoang", "1=1", "loai_nh='1'")
    End Sub
    Private Sub L_Nh_Khoang1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_khoang1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_khoang1.Text = DrReturn.Item("ma_nh")
            TxtTen_nh1.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_khoang1.Text = ""
            TxtTen_nh1.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub V_Nh_Khoang2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_khoang2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "Dmnhkhoang", "1=1", "loai_nh='2'")
    End Sub
    Private Sub L_Nh_Khoang2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_khoang2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_khoang2.Text = DrReturn.Item("ma_nh")
            TxtTen_nh2.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_khoang2.Text = ""
            TxtTen_nh2.Text = ""
            Exit Sub
        End If
    End Sub
    Private Sub V_Nh_Khoang3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_khoang3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Nh", "Dmnhkhoang", "1=1", "loai_nh='3'")
    End Sub
    Private Sub L_Nh_Khoang3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_khoang3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_khoang3.Text = DrReturn.Item("ma_nh")
            TxtTen_nh3.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_khoang3.Text = ""
            TxtTen_nh3.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_HS"
    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_HS")
            TxtTen_Hs.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_KTV"
    Private Sub V_Ma_KTV(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_KTV.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "DmKTV", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KTV(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_KTV.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KTV.Text = DrReturn.Item("Ma_HS")
            TxtTen_KTV.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_KTV.Text = ""
            TxtTen_KTV.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Xe"
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        'TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
    End Sub
#End Region
#Region "Vali --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kx.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DMKX", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Kx.Text = "" Then
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_Ma_Loai As String = Me.CbbMa_Loai.SelectedValue.ToString.Trim
        Dim M_Loai_Sc As String = Me.CBBLoai_SC.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = M_Loai_Sc.Trim & "#" & M_Ma_Loai.Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_To.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Khoang.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_KTV.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_RO.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kx.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_khoang1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_khoang2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_khoang3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & _ChkBien_so.Trim
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & Me.User_Name.Trim
        '-----------------------------------------------------------------------------
        Me.is_continue = True
        Dim M_strFieldValue As String = ""
        Dim M_strFieldName As String = ""
        CyberSmodb.GetValueControler(Me, M_strFieldName, M_strFieldValue, "")
        Me.Tag_Field = M_strFieldName
        Me.Tag_Value = M_strFieldValue
        CyberSmLib.SaveRegistry(Me, Me.sysvar)
        Me.Tag = M_strParameterStore
        Me.Close()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_List_Ma_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim str As String
        Dim _List_Ma_To As String = ""
        Dim strTen As String = ""
        str = GetMaTo(TxtMa_To.Text, strTen)
        TxtMa_To.Text = str
        If str Is Nothing Then Exit Sub
    End Sub
    Private Function GetMaTo(ByVal _List_Ma_To As String, ByRef _Ten_Ma_To As String) As String
        GetMaTo = CyberSupport.V_GetStrSelectList(AppConn, Me.sysvar, Me.Para, "CP_GetListSelect", "DMTOSC#" & _List_Ma_To & "#" & TxtMa_To.Text.Trim & "#" & Me.Ma_Dvcs & "#" & Me.User_Name, Me.LAN, _Ten_Ma_To)
    End Function
    Private Sub V_AddMenuShorcut()
        Dim mnItems = New ContextMenu
        Dim mnItemsNhan As New MenuItem(IIf(Me.LAN = "V", "Chấp nhận", "OK"), AddressOf V_Nhan, Keys.Control + Keys.Enter)
        Dim mnItemsExit As New MenuItem(IIf(Me.LAN = "V", "Quay ra", "Exit"), AddressOf V_Exit, Keys.Escape)
        mnItems.MenuItems.Add(mnItemsNhan)
        mnItems.MenuItems.Add(mnItemsExit)
        Me.ContextMenu = mnItems
    End Sub
#End Region
    Private Sub ChkMa_xe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSo_Ro.CheckedChanged
        If ChkSo_Ro.Checked Then
            _ChkBien_so = "1"
        Else
            _ChkBien_so = "0"
        End If
    End Sub
End Class
