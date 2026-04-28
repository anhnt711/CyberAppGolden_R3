Public Class RO_HDK_KPI_TH
    Dim CyberMe As New Cyber.Reports.Sys
    Dim _Dt_DmLoaiLenh As DataTable
    Dim _Dt_DmLoaiTT As DataTable
    Dim _Dt_PostHDK1, _Dt_PostHDK2 As DataTable
    Dim _Dt_MucSBD, _Dt_MucSDS As DataTable

    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub RO_HDK_KPI_TH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        _Dt_DmLoaiLenh = CyberMe.V_CreateLoaiLenh()
        _Dt_DmLoaiTT = CyberMe.V_CreateLoaiTT()
        _Dt_PostHDK1 = CyberMe.V_CreatemaPost(AppConn, CyberSmLib, "HDK", Ma_Dvcs, User_Name)
        _Dt_PostHDK2 = _Dt_PostHDK1.Copy

        _Dt_MucSBD = CyberMe.V_MucSBD(AppConn, CyberSmLib, Ma_Dvcs, User_Name)
        _Dt_MucSDS = CyberMe.V_MucSDS(AppConn, CyberSmLib, Ma_Dvcs, User_Name)

        For i As Integer = 0 To _Dt_PostHDK1.Rows.Count - 1
            If _Dt_PostHDK1.Rows(i).Item("Ma_Post").ToString = "2" Then
                _Dt_PostHDK1.Rows(i).BeginEdit()
                _Dt_PostHDK1.Rows(i).Item("Ngam_Dinh") = "1"
                _Dt_PostHDK1.Rows(i).EndEdit()
                Exit For
            End If
        Next
        For i As Integer = 0 To _Dt_PostHDK2.Rows.Count - 1
            If _Dt_PostHDK2.Rows(i).Item("Ma_Post").ToString = "9" Then
                _Dt_PostHDK2.Rows(i).BeginEdit()
                _Dt_PostHDK2.Rows(i).Item("Ngam_Dinh") = "1"
                _Dt_PostHDK2.Rows(i).EndEdit()
                Exit For
            End If
        Next

        CyberFill.V_FillComBoxDefaul(CbbMa_GD, _Dt_DmLoaiLenh, "Ma_GD", "ten_GD", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_TT, _Dt_DmLoaiTT, "Ma_TT", "ten_TT", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_Post_HDK1, _Dt_PostHDK1, "Ma_Post", "ten_Post", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_Post_HDK2, _Dt_PostHDK2, "Ma_Post", "ten_Post", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMuc_SBD, _Dt_MucSBD, "Muc_SBD", "ten_SBD", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMuc_SDS, _Dt_MucSDS, "Muc_SDS", "ten_SDS", "Ngam_Dinh")

        V_Load()
        V_Addhander()
        V_SBD(New System.Object, New System.EventArgs)
        V_SDS(New System.Object, New System.EventArgs)
    End Sub

#Region "Load"
    Private Sub V_Load()

        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        ''---------------------------------------------------------------------------------------------------------------
        RemoveHandler ChkSBD.CheckedChanged, AddressOf V_SBD
        AddHandler ChkSBD.CheckedChanged, AddressOf V_SBD

        RemoveHandler ChkSDS.CheckedChanged, AddressOf V_SDS
        AddHandler ChkSDS.CheckedChanged, AddressOf V_SDS
        '--ma khach hang
        RemoveHandler Txtma_kx.CyberValiting, AddressOf V_Ma_KX
        RemoveHandler Txtma_kx.CyberLeave, AddressOf L_Ma_KX
        AddHandler Txtma_kx.CyberValiting, AddressOf V_Ma_KX
        AddHandler Txtma_kx.CyberLeave, AddressOf L_Ma_KX
        '-- ma HS
        RemoveHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        RemoveHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs

        '--KH1
        RemoveHandler TxtNh_KX1.CyberValiting, AddressOf V_NH_KX1
        RemoveHandler TxtNh_KX1.CyberLeave, AddressOf L_NH_KX1
        AddHandler TxtNh_KX1.CyberValiting, AddressOf V_NH_KX1
        AddHandler TxtNh_KX1.CyberLeave, AddressOf L_NH_KX1
        '--KH2
        RemoveHandler TxtNh_KX2.CyberValiting, AddressOf V_NH_KX2
        RemoveHandler TxtNh_KX2.CyberLeave, AddressOf L_NH_KX2
        AddHandler TxtNh_KX2.CyberValiting, AddressOf V_NH_KX2
        AddHandler TxtNh_KX2.CyberLeave, AddressOf L_NH_KX2
        '--KH3
        RemoveHandler TxtNh_KX3.CyberValiting, AddressOf V_NH_KX3
        RemoveHandler TxtNh_KX3.CyberLeave, AddressOf L_NH_KX3
        AddHandler TxtNh_KX3.CyberValiting, AddressOf V_NH_KX3
        AddHandler TxtNh_KX3.CyberLeave, AddressOf L_NH_KX3
        '--KH4
        RemoveHandler TxtNh_KX4.CyberValiting, AddressOf V_NH_KX4
        RemoveHandler TxtNh_KX4.CyberLeave, AddressOf L_NH_KX4
        AddHandler TxtNh_KX4.CyberValiting, AddressOf V_NH_KX4
        AddHandler TxtNh_KX4.CyberLeave, AddressOf L_NH_KX4
        '--KH5
        RemoveHandler TxtNh_KX5.CyberValiting, AddressOf V_NH_KX5
        RemoveHandler TxtNh_KX5.CyberLeave, AddressOf L_NH_KX5
        AddHandler TxtNh_KX5.CyberValiting, AddressOf V_NH_KX5
        AddHandler TxtNh_KX5.CyberLeave, AddressOf L_NH_KX5

        ''---------------------------------------------------------------------------------------------------------------
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
    End Sub
#End Region
#Region "Muc sua chua"
    Private Sub V_SBD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CbbMuc_SBD.Enabled = ChkSBD.Checked
    End Sub

    Private Sub V_SDS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CbbMuc_SDS.Enabled = ChkSDS.Checked
    End Sub
#End Region
#Region "Valid --- Ma_KX"
    Private Sub V_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_kx.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KX", "DmKX", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = Txtma_kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_kx.Text = DrReturn.Item("Ma_KX")
            TxtTen_kx.Text = DrReturn.Item("Ten_KX")
        Else
            Txtma_kx.Text = ""
            TxtTen_kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- NH_KX1"
    Private Sub V_NH_KX1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KX1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKX", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_KX1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KX1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KX1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KX1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KX2"
    Private Sub V_NH_KX2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KX2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKX", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_KX2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KX2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KX2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KX2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KX3"
    Private Sub V_NH_KX3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KX3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKX", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_KX3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KX3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KX3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KX3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KX4"
    Private Sub V_NH_KX4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KX4.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKX", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_KX4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KX4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KX4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KX4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KX5"
    Private Sub V_NH_KX5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KX5.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKX", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_KX5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KX5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KX5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KX5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim _Ngay_Ct1 As Date = TxtM_Ngay_Ct1.Value
        Dim _Ngay_Ct2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim _StrF As String = ""
        Dim _StrV As String = ""
        Dim M_VT_PARA As Integer = CType(Me.Para(0).Trim, Integer)
        Dim _Loai As String = ""
        Try
            _Loai = Me.Para(M_VT_PARA + 2).Trim()
        Catch ex As Exception

        End Try

        CyberSmodb.GetValueControler(Me, _StrF, _StrV, "TEN_KX,TEN_HS,TEN_VT,TEN_NH1,TEN_NH2,TEN_NH3,TEN_NH4,TEN_NH5")

        Dim M_strParameterStore As String = _Loai & "#" & _Ngay_Ct1.ToString("yyyyMMdd") & "#" & _Ngay_Ct2.ToString("yyyyMMdd")
        M_strParameterStore = M_strParameterStore & "#" & _StrF & "#" & _StrV
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & Me.User_Name.Trim
        '-----------------------------------------------------------------------------
        Me.is_continue = True
        Me.Tag_Field = _StrF
        Me.Tag_Value = _StrV
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
