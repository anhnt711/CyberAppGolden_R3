Public Class ROBCTHHDS
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim _Dt_GD, _Dt_post1, _Dt_post2, _DtGroup, _DtGroupct, _DtMa_TT As DataTable
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet

    Dim M_Ma_CT As String = ""
    Dim M_Ma_GD As String = ""
    Dim M_Loai_TH As String = "0"
    Dim M_Ma_Post1 As String = ""
    Dim M_Ma_Post2 As String = ""
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Private Sub SysDateToDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Ma_CT = Me.Para(Me.VT_PARA + 2).Trim
        M_Ma_GD = Me.Para(Me.VT_PARA + 3).Trim
        M_Ma_Post1 = Me.Para(Me.VT_PARA + 4).Trim
        M_Ma_Post2 = Me.Para(Me.VT_PARA + 5).Trim

        If Not (M_Ma_CT = "HDS") Then M_Ma_CT = "HDS"
        If Cp_Name.ToUpper.Trim = "CP_ROBCTH_HDS_DETAIL".ToUpper.Trim Then
            ChkDetail_OK.Visible = False
            ChkDetail_OK.Checked = False
        End If
        V_AddMenuShorcut()
        V_Load()
        V_VisibleCT()
        V_Addhander()
    End Sub
#Region "Load"
#Region "Chi tiet theo"
    Private Sub V_VisibleCT()
        If ChkDetail_OK.Checked = True Then CbbGroupByCT.Visible = True Else CbbGroupByCT.Visible = False
    End Sub
    Private Sub V_Detail_OK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_VisibleCT()
    End Sub
#End Region
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '--------------------------------------------------------------------

        Dim _DsMa_TT As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'LOAI_TT' AND Acti = N'1'#ID")
        _DtMa_TT = _DsMa_TT.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.Ma_TT, _DtMa_TT, "Nhom", "Ten_nhom")

        Dim _DsGroup As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTHRO", M_Ma_CT + "#" + "" + "#" + "" + "#" + Me.Ma_Dvcs + "#" + Me.User_Name)
        _DtGroup = _DsGroup.Tables(0).Copy
        _DtGroupct = _DsGroup.Tables(1).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByTH, _DtGroup, "Ma", "Ten")
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByCT, _DtGroupct, "Ma", "Ten")
        _DsGroup.Dispose()

        Dim _DsMa_GD As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetGD", M_Ma_CT)
        _Dt_GD = _DsMa_GD.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CbbMa_GD, _Dt_GD, "ma_gd", "Ten_gd", M_Ma_GD)
        _DsMa_GD.Dispose()

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
        '--------------------------------------------------------------------
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        Txtma_kh.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, Txtma_kh)
        TxtMa_Hs.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs)

        If Txtma_kh.Text.Trim = "" Then TxtTen_kh.Text = "" Else TxtTen_kh.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kh", "DmKh", "(Ma_kh = N'" + Txtma_kh.Text.Trim + "')", CyberSmLib)
        If TxtMa_Hs.Text.Trim = "" Then TxtTen_Hs.Text = "" Else TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_HS", "DmHS", "(Ma_HS= N'" + TxtMa_Hs.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--ma khach hang
        AddHandler Txtma_kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler Txtma_kh.CyberLeave, AddressOf L_Ma_KH
        '-- ma HS
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        '-- ma xe
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
        'AddHandler TxtMa_xe.CyberValiting, AddressOf V_Ma_xe
        'AddHandler TxtMa_xe.CyberLeave, AddressOf L_Ma_xe

        AddHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_Kx

        RemoveHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK
        AddHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK


    End Sub
#End Region
#Region "Valid"
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
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_KX.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_KX.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KX.Text = DrReturn.Item("Ma_Kx")
        Else
            TxtMa_KX.Text = ""
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub

        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
    End Sub
    '#Region "Valid --- Ma_xe"
    '    Private Sub V_Ma_xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '        TxtMa_xe.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_xe", "Dmxe", "1=1", "1=1")
    '    End Sub
    '    Private Sub L_Ma_xe(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
    '        DrReturn = TxtMa_xe.GetRowsSelectData(True)
    '        If Not DrReturn Is Nothing Then
    '            TxtMa_xe.Text = DrReturn.Item("Ma_xe")
    '        Else
    '            TxtMa_xe.Text = ""
    '            Txtten_xe.Text = ""
    '            Exit Sub
    '        End If
    '    End Sub
    '#End Region
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
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        If CyberMe.V_GetValueCombox(CbbGroupByTH).ToString.Trim = "" Then
            MsgBox("Chưa chọn tổng hợp theo tiêu thức nào", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            CbbGroupByTH.Focus()
            Exit Sub
        End If
        If ChkDetail_OK.Checked And CyberMe.V_GetValueCombox(CbbGroupByCT).ToString.Trim = "" Then
            MsgBox("Chưa chọn tiêu thức chi tiết", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            CbbGroupByCT.Focus()
            Exit Sub
        End If
        If ChkDetail_OK.Checked And CyberMe.V_GetValueCombox(CbbGroupByCT).ToString.Trim.ToUpper = CyberMe.V_GetValueCombox(CbbGroupByTH).ToString.Trim.ToUpper Then
            MsgBox("Hai tiêu thức tổng hợp và chi tiết không thể giống nhau", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            CbbGroupByTH.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_TH_Filter As String = Me.CbbGroupByTH.SelectedValue.ToString.Trim
        Dim M_Ma_CT_Filter As String = Me.Ma_TT.SelectedValue.ToString.Trim
        Dim M_Ma_GD_Filter As String = Me.CbbMa_GD.SelectedValue.ToString.Trim
        Dim M_Ma_Post1_Filter As String = Me.CbbMa_Post1.SelectedValue.ToString.Trim
        Dim M_Ma_Post2_Filter As String = Me.CbbMa_post2.SelectedValue.ToString.Trim
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = M_TH_Filter
        M_strParameterStore = M_strParameterStore & "#" & If(ChkDetail_OK.Checked, CbbGroupByCT.SelectedValue.ToString.Trim, "")
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_CT_Filter
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_GD_Filter
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_ro.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_KX.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Txtma_kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Post1_Filter
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Post2_Filter
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
