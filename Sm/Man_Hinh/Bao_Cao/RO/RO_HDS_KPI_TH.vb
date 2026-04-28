Public Class RO_HDS_KPI_TH
    Dim CyberMe As New Cyber.Reports.Sys
    Dim _Dt_DmLoaiLenh As DataTable
    Dim _Dt_DmLoaiTT As DataTable
    Dim _Dt_DmIS_HD_VAT As DataTable
    Dim _Dt_PostHDK1, _Dt_PostHDK2 As DataTable
    Dim _Dt_PostHDS1, _Dt_PostHDS2 As DataTable
    Dim _Dt_MucSBD, _Dt_MucSDS As DataTable
    Dim _Dt_DmSo_Seri As DataTable

    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub RO_HDS_KPI_TH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        _Dt_DmLoaiLenh = CyberMe.V_CreateLoaiLenh()
        _Dt_DmLoaiTT = CyberMe.V_CreateLoaiTT()
        _Dt_DmIS_HD_VAT = CyberMe.V_CreateIS_HD_VAT()
        _Dt_PostHDK1 = CyberMe.V_CreatemaPost(AppConn, CyberSmLib, "HDK", Ma_Dvcs, User_Name)
        _Dt_PostHDK2 = _Dt_PostHDK1.Copy
        _Dt_DmSo_Seri = CyberMe.V_CreateSoseri(AppConn, CyberSmLib, Ma_Dvcs, User_Name)

        _Dt_PostHDS1 = CyberMe.V_CreatemaPost(AppConn, CyberSmLib, "HDS", Ma_Dvcs, User_Name)
        _Dt_PostHDS2 = _Dt_PostHDS1.Copy
        _DT_MucSBD = CyberMe.V_MucSBD(AppConn, CyberSmLib, Ma_Dvcs, User_Name)
        _Dt_MucSDS = CyberMe.V_MucSDS(AppConn, CyberSmLib, Ma_Dvcs, User_Name)
        CyberFill.V_FillComBoxDefaul(CbbSo_Seri, _Dt_DmSo_Seri, "So_Seri", "ten_Seri", "Ngam_Dinh")

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

        For i As Integer = 0 To _Dt_PostHDS1.Rows.Count - 1
            If _Dt_PostHDS1.Rows(i).Item("Ma_Post").ToString = "3" Then
                _Dt_PostHDS1.Rows(i).BeginEdit()
                _Dt_PostHDS1.Rows(i).Item("Ngam_Dinh") = "1"
                _Dt_PostHDS1.Rows(i).EndEdit()
                Exit For
            End If
        Next
        For i As Integer = 0 To _Dt_PostHDS2.Rows.Count - 1
            If _Dt_PostHDS2.Rows(i).Item("Ma_Post").ToString = "9" Then
                _Dt_PostHDS2.Rows(i).BeginEdit()
                _Dt_PostHDS2.Rows(i).Item("Ngam_Dinh") = "1"
                _Dt_PostHDS2.Rows(i).EndEdit()
                Exit For
            End If
        Next


        CyberFill.V_FillComBoxDefaul(CbbMa_GD, _Dt_DmLoaiLenh, "Ma_GD", "ten_GD", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_TT, _Dt_DmLoaiTT, "Ma_TT", "ten_TT", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbIS_HD_VAT, _Dt_DmIS_HD_VAT, "Ma", "ten", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_Post_HDK1, _Dt_PostHDK1, "Ma_Post", "ten_Post", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_Post_HDK2, _Dt_PostHDK2, "Ma_Post", "ten_Post", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_Post_HDS1, _Dt_PostHDS1, "Ma_Post", "ten_Post", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_Post_HDS2, _Dt_PostHDS2, "Ma_Post", "ten_Post", "Ngam_Dinh")
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


        RemoveHandler TxtMa_Tang.Leave, AddressOf L_Ma_Tang
        AddHandler TxtMa_Tang.Leave, AddressOf L_Ma_Tang
        '--ma khach hang
        RemoveHandler Txtma_kh.CyberValiting, AddressOf V_Ma_KH
        RemoveHandler Txtma_kh.CyberLeave, AddressOf L_Ma_KH
        AddHandler Txtma_kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler Txtma_kh.CyberLeave, AddressOf L_Ma_KH
        '-- ma HS
        RemoveHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        RemoveHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs

        '--KH1
        RemoveHandler TxtNh_KH1.CyberValiting, AddressOf V_NH_KH1
        RemoveHandler TxtNh_KH1.CyberLeave, AddressOf L_NH_KH1
        AddHandler TxtNh_KH1.CyberValiting, AddressOf V_NH_KH1
        AddHandler TxtNh_KH1.CyberLeave, AddressOf L_NH_KH1
        '--KH2
        RemoveHandler TxtNh_KH2.CyberValiting, AddressOf V_NH_KH2
        RemoveHandler TxtNh_KH2.CyberLeave, AddressOf L_NH_KH2
        AddHandler TxtNh_KH2.CyberValiting, AddressOf V_NH_KH2
        AddHandler TxtNh_KH2.CyberLeave, AddressOf L_NH_KH2
        '--KH3
        RemoveHandler TxtNh_KH3.CyberValiting, AddressOf V_NH_KH3
        RemoveHandler TxtNh_KH3.CyberLeave, AddressOf L_NH_KH3
        AddHandler TxtNh_KH3.CyberValiting, AddressOf V_NH_KH3
        AddHandler TxtNh_KH3.CyberLeave, AddressOf L_NH_KH3
        '--KH4
        RemoveHandler TxtNh_KH4.CyberValiting, AddressOf V_NH_KH4
        RemoveHandler TxtNh_KH4.CyberLeave, AddressOf L_NH_KH4
        AddHandler TxtNh_KH4.CyberValiting, AddressOf V_NH_KH4
        AddHandler TxtNh_KH4.CyberLeave, AddressOf L_NH_KH4
        '--KH5
        RemoveHandler TxtNh_KH5.CyberValiting, AddressOf V_NH_KH5
        RemoveHandler TxtNh_KH5.CyberLeave, AddressOf L_NH_KH5
        AddHandler TxtNh_KH5.CyberValiting, AddressOf V_NH_KH5
        AddHandler TxtNh_KH5.CyberLeave, AddressOf L_NH_KH5

        '--TTLN
        RemoveHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        RemoveHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN
        '--TTCP
        RemoveHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        RemoveHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
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
#Region "Valid --- Tầng"
    Private Sub L_Ma_Tang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Tang.Text.Trim = "" Then Return
        TxtMa_Tang.Text = Strings.Right("00" + TxtMa_Tang.Text.Trim, 2)
    End Sub
#End Region
#Region "Valid --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_kh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = Txtma_kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_kh.Text = DrReturn.Item("Ma_kh")
            TxtTen_kh.Text = DrReturn.Item("Ten_Kh")
        Else
            Txtma_kh.Text = ""
            TxtTen_kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH1"
    Private Sub V_NH_KH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH1.V_LookUp(Me.LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_KH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KH1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH2"
    Private Sub V_NH_KH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH2.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_KH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KH2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH3"
    Private Sub V_NH_KH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH3.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_KH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KH3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH4"
    Private Sub V_NH_KH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH4.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_KH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KH4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH5"
    Private Sub V_NH_KH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH5.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_KH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KH5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH5.Text = ""
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
#Region "Vali --- Ma_TTLN"
    Private Sub V_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTLN.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TTLN.Text = "" Then
            TxtTen_TTLN.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTLN.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TTLN.Text = DrReturn.Item("Ma_TTLN")
            TxtTen_TTLN.Text = DrReturn.Item("Ten_TTLN")
        Else
            TxtMa_TTLN.Text = ""
            TxtTen_TTLN.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTCP"
    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTCP.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TTCP.Text = "" Then
            TxtTen_TTCP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTCP.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP.Text = ""
            TxtTen_TTCP.Text = ""
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

        CyberSmodb.GetValueControler(Me, _StrF, _StrV, "TEN_KH,TEN_HS,TEN_VT,TEN_NH1,TEN_NH2,TEN_NH3,TEN_NH4,TEN_NH5")

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
