Public Class RO_05
    Dim CyberMe As New Cyber.Reports.Sys
    Dim _Dt_post1, _Dt_post2, _DtLoai_Phieu As DataTable
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim M_Ma_CT As String = ""
    Dim M_Ma_Post1 As String = ""
    Dim M_Ma_Post2 As String = ""
    Private Sub SysDateToDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Ma_CT = Me.Para(Me.VT_PARA + 2).Trim
        M_Ma_Post1 = Me.Para(Me.VT_PARA + 4).Trim
        M_Ma_Post2 = Me.Para(Me.VT_PARA + 5).Trim
        If Not (M_Ma_CT = "HDK" Or M_Ma_CT = "HDP" Or M_Ma_CT = "HDM") Then M_Ma_CT = "HDK"
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        Dim _DsLoai_Phieu As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'HDK_HDM_HDP' AND Acti = N'1' AND Ma_ct <> 'HDM'#ID")
        _DtLoai_Phieu = _DsLoai_Phieu.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CbbLoai_Phieu, _DtLoai_Phieu, "Nhom", "Ten_nhom", "HDK")
        Dim _DsPost As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", M_Ma_CT & "##")
        _Dt_post1 = _DsPost.Tables(0).Copy
        _Dt_post2 = _DsPost.Tables(1).Copy

        Dim _Ma_Post_Min As String = _Dt_post1.Rows(0).Item("Ma_Post")
        Dim _Ma_Post_Max As String = _Dt_post2.Rows(_Dt_post2.Rows.Count - 1).Item("Ma_Post")

        If _Dt_post1.Select("Ma_Post = '" + M_Ma_Post1.Trim + "'").Length = 0 Then M_Ma_Post1 = _Ma_Post_Min
        If _Dt_post2.Select("Ma_Post = '" + M_Ma_Post2.Trim + "'").Length = 0 Then M_Ma_Post2 = _Ma_Post_Max

        _DsPost.Dispose()
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post1, _Dt_post1, "ma_post", "Ten_post", M_Ma_Post1)
        CyberFill.V_FillComBoxValue(Me.CbbMa_post2, _Dt_post2, "ma_post", "Ten_post", M_Ma_Post2)
        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '-- Ma_Kx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_KX
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_KX
        '-- Ma_Mau
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        '-- Ma_Xe
        AddHandler TxtMa_Xe.CyberValiting, AddressOf V_Ma_Xe
        AddHandler TxtMa_Xe.CyberLeave, AddressOf L_Ma_Xe
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_KX"
    Private Sub V_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kx.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KX", "DmKX", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_KX")
            TxtTen_kx.Text = DrReturn.Item("Ten_KX")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Mau.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            TxtTen_Mau.Text = DrReturn.Item("Ten_Mau")
        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_xe"
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Xe.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Xe", "DmXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Xe.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Xe.Text = DrReturn.Item("Ma_Xe")
            TxtTen_kh.Text = DrReturn.Item("Ten_kh")
        Else
            TxtMa_Xe.Text = ""
            TxtTen_kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_CT_Filter As String = Me.CbbLoai_Phieu.SelectedValue.ToString.Trim
        Dim M_Ma_Post1_Filter As String = Me.CbbMa_Post1.SelectedValue.ToString.Trim
        Dim M_Ma_Post2_Filter As String = Me.CbbMa_post2.SelectedValue.ToString.Trim

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Post1_Filter
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Post2_Filter
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_CT_Filter
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kx.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Mau.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text.Trim
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
