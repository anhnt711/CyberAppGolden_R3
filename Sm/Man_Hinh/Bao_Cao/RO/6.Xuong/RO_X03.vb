Public Class RO_X03
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtLoai_SC, _Dt_post1, _Dt_post2 As DataTable
    Dim M_Ma_CT As String = "HDK"
    Dim M_Ma_Post1 As String = ""
    Dim M_Ma_Post2 As String = ""
    Private Sub RO_X03_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Ma_CT = Me.Para(Me.VT_PARA + 2).Trim
        M_Ma_Post1 = Me.Para(Me.VT_PARA + 3).Trim
        M_Ma_Post2 = Me.Para(Me.VT_PARA + 4).Trim
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
        TxtMa_To.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_To)
        TxtMa_Khoang.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Khoang)
        TxtMa_KTV.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_KTV)
        TxtSo_RO.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtSo_RO)
        TxtMa_Xe.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Xe)

        If TxtMa_To.Text.Trim = "" Then TxtTen_To.Text = "" Else TxtTen_To.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_to", "Dmto", "Ma_to = N'" + TxtMa_To.Text.Trim + "'", CyberSmLib)
        If TxtMa_Khoang.Text.Trim = "" Then TxtTen_khoang.Text = "" Else TxtTen_khoang.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_khoang", "DmKhoang", "Ma_khoang = N'" + TxtMa_Khoang.Text.Trim + "'", CyberSmLib)
        If TxtMa_KTV.Text.Trim = "" Then TxtTen_KTV.Text = "" Else TxtTen_KTV.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "DmKTV", "Ma_HS = N'" + TxtMa_KTV.Text.Trim + "'", CyberSmLib)
        '-----Loại SC
        Dim _DsLoai_Sc As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'Loai_SC' AND Acti = N'1'#ID")
        DtLoai_SC = _DsLoai_Sc.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CBBLoai_SC, DtLoai_SC, "Nhom", "Ten_nhom")

        ' Load mã post
        Dim _DsPost As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", M_Ma_CT & "##")
        _Dt_post1 = _DsPost.Tables(0).Copy
        _Dt_post2 = _DsPost.Tables(1).Copy
        _DsPost.Dispose()
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post1, _Dt_post1, "Ma_post", "Ten_post", M_Ma_Post1)
        CyberFill.V_FillComBoxValue(Me.CbbMa_post2, _Dt_post2, "Ma_post", "Ten_post", M_Ma_Post2)
        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--Ma_to
        AddHandler TxtMa_To.CyberValiting, AddressOf V_Ma_TO
        AddHandler TxtMa_To.CyberLeave, AddressOf L_Ma_TO

        '--Ma_khoang
        AddHandler TxtMa_Khoang.CyberValiting, AddressOf V_Ma_Khoang
        AddHandler TxtMa_Khoang.CyberLeave, AddressOf L_Ma_Khoang

        '--Ma_KTV
        AddHandler TxtMa_KTV.CyberValiting, AddressOf V_Ma_KTV
        AddHandler TxtMa_KTV.CyberLeave, AddressOf L_Ma_KTV

        '-- Ma Xe
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe

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
#End Region
#Region "Valid --- Ma_KTV"
    Private Sub V_Ma_KTV(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_KTV.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "DmKTVSC", "1=1", "1=1")
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
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _strField As String = ""
        Dim _strvalue As String = ""

        CyberSmodb.GetValueControler(Me, _strField, _strvalue)

        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim _M_Loai_Sc As String = Me.CBBLoai_SC.SelectedValue.ToString.Trim
        Dim _Ma_Post1 As String = Me.CbbMa_Post1.SelectedValue.ToString.Trim
        Dim _Ma_Post2 As String = Me.CbbMa_post2.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & _strField
        M_strParameterStore = M_strParameterStore & "#" & _strvalue
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
    Private Sub V_AddMenuShorcut()
        Dim mnItems = New ContextMenu
        Dim mnItemsNhan As New MenuItem(IIf(Me.LAN = "V", "Chấp nhận", "OK"), AddressOf V_Nhan, Keys.Control + Keys.Enter)
        Dim mnItemsExit As New MenuItem(IIf(Me.LAN = "V", "Quay ra", "Exit"), AddressOf V_Exit, Keys.Escape)
        mnItems.MenuItems.Add(mnItemsNhan)
        mnItems.MenuItems.Add(mnItemsExit)
        Me.ContextMenu = mnItems
    End Sub
#End Region
End Class
