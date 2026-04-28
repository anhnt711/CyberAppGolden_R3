Public Class RO_VR01
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim _Dt_GD, _Dt_post1, _Dt_post2, _DtGroup As DataTable
    Dim M_Ma_CT As String = ""
    Dim M_Ma_GD As String = ""
    Dim M_Loai_TH As String = "0"
    Dim M_Ma_Post1 As String = ""
    Dim M_Ma_Post2 As String = ""
    Private Sub SysDateToDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        M_Ma_CT = Me.Para(Me.VT_PARA + 2).Trim
        M_Loai_TH = Me.Para(Me.VT_PARA + 3).Trim
        M_Ma_GD = Me.Para(Me.VT_PARA + 4).Trim
        M_Ma_Post1 = Me.Para(Me.VT_PARA + 5).Trim
        M_Ma_Post2 = Me.Para(Me.VT_PARA + 6).Trim
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '--------------------------------------------------------------------
        Dim _DsMa_GD As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetGD", M_Ma_CT)
        _Dt_GD = _DsMa_GD.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CbbMa_GD, _Dt_GD, "ma_gd", "Ten_gd", M_Ma_GD)
        _DsMa_GD.Dispose()
        Dim _DsPost As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", M_Ma_CT & "##")
        _Dt_post1 = _DsPost.Tables(0).Copy
        _Dt_post2 = _DsPost.Tables(1).Copy
        _DsPost.Dispose()
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post1, _Dt_post1, "ma_post", "Ten_post", M_Ma_Post1)
        CyberFill.V_FillComBoxValue(Me.CbbMa_post2, _Dt_post2, "ma_post", "Ten_post", M_Ma_Post2)

        Dim _DsGroup As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTHRO", M_Ma_CT + "#" + M_Loai_TH + "#" + Me.Ma_Dvcs + "#" + Me.User_Name)
        _DtGroup = _DsGroup.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByTH, _DtGroup, "Ma", "Ten")
        '--------------------------------------------------------------------

        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
    End Sub
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = CbbGroupByTH.SelectedValue.ToString.Trim

        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbMa_GD.SelectedValue.ToString
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.text
        M_strParameterStore = M_strParameterStore & "#" & CbbMa_Post1.SelectedValue.ToString
        M_strParameterStore = M_strParameterStore & "#" & CbbMa_post2.SelectedValue.ToString
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
