Public Class RO_KPI_BC41
    Dim CyberMe As New Cyber.Reports.Sys
    Dim _Dt_DmLoaiLenh As DataTable

    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub RO_HDS_KPI_TH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        _Dt_DmLoaiLenh = CyberMe.V_CreateLoaiLenh()



        CyberFill.V_FillComBoxDefaul(CbbMa_GD, _Dt_DmLoaiLenh, "Ma_GD", "ten_GD", "Ngam_Dinh")
        V_Load()
        V_Addhander()
        
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
        Dim M_VT_PARA As Integer = 14
        Try
            M_VT_PARA = CType(Me.Para(0).Trim, Integer)
            TxtTk.Text = Me.Para(M_VT_PARA + 2).Trim
        Catch ex As Exception
        End Try
        If TxtTk.Text.Trim = "" Then TxtTk.Text = "1312"
        TxtTen_TK.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtTk.Text.Trim + "'", CyberSmLib)


        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        ''---------------------------------------------------------------------------------------------------------------
        RemoveHandler TxtTk.CyberValiting, AddressOf V_Tk
        RemoveHandler TxtTk.CyberLeave, AddressOf L_Tk
        AddHandler TxtTk.CyberValiting, AddressOf V_Tk
        AddHandler TxtTk.CyberLeave, AddressOf L_Tk

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

        ''---------------------------------------------------------------------------------------------------------------
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
    End Sub
#End Region
#Region "Valid --- Tk"
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk", "DmTKCN", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("Tk")
            TxtTen_TK.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk.Text = ""
            TxtTen_TK.Text = ""
            Exit Sub
        End If
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
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim _Ngay_Ct1 As Date = TxtM_Ngay_Ct1.Value
        Dim _Ngay_Ct2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim _StrF As String = ""
        Dim _StrV As String = ""

        CyberSmodb.GetValueControler(Me, _StrF, _StrV, "TEN_KH,TEN_HS,TEN_VT,TEN_NH1,TEN_NH2,TEN_NH3,TEN_NH4,TEN_NH5")

        Dim M_strParameterStore As String = _Ngay_Ct1.ToString("yyyyMMdd") & "#" & _Ngay_Ct2.ToString("yyyyMMdd")
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
