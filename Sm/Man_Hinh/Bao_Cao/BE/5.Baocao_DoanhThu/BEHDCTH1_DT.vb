Public Class BEHDCTH1_DT
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _GroupByTH, _GroupByCT As DataTable
    Private Sub BEHDCTH1_DT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChkDetail_OK.Checked = False
        V_AddMenuShorcut()
        V_LoadDate()
        V_Load()
        V_VisibleCT()
        V_Addhander()
    End Sub
#Region "Chi tiet theo"
    Private Sub V_VisibleCT()
        If ChkDetail_OK.Checked = True Then CbbGroupByCT.Visible = True Else CbbGroupByCT.Visible = False
    End Sub
    Private Sub V_Detail_OK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_VisibleCT()
    End Sub
#End Region
#Region "Load"
   
    Private Sub V_LoadDate()

        Dim _Thang1 As Integer = Now.Month
        Dim _Nam1 As Integer = Now.Year

        Dim _Date1 As Date = Now
        _Date1 = _Date1.AddMonths(-1)

        Dim _Thang3 As Integer = _Date1.Month
        Dim _Nam3 As Integer = _Date1.Year

        TxtM_Ngay_Ct1.Value = New Date(_Nam1, _Thang1, 1)
        Dim _Ngay_Ct1 As Date = TxtM_Ngay_Ct1.Value
        TxtM_Ngay_Ct2.Value = _Ngay_Ct1.AddMonths(1).AddDays(-1)


        TxtM_Ngay_Ct3.Value = New Date(_Nam3, _Thang3, 1)
        Dim _Ngay_Ct3 As Date = TxtM_Ngay_Ct3.Value
        TxtM_Ngay_Ct4.Value = _Ngay_Ct3.AddMonths(1).AddDays(-1)

        'TxtM_Ngay_Ct1.Value = Now.Date
        'TxtM_Ngay_Ct2.Value = Now.Date
        'TxtM_Ngay_Ct3.Value = Now.Date
        'TxtM_Ngay_Ct4.Value = Now.Date
        'TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        'TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        'TxtM_Ngay_Ct3.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct3)
        'TxtM_Ngay_Ct4.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct4)

    End Sub
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----------
        Dim _DsGroup As New DataSet
        ' _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'MUA_BAN2' AND Acti = N'1'#ID")
        _DsGroup = Nothing
        _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTH_KD", "" + "#" + "" + "#" + "" + "#" + "" + "#" + Me.Ma_Dvcs + "#" + Me.User_Name)
        _GroupByTH = _DsGroup.Tables(0).Copy
        _GroupByCT = _DsGroup.Tables(1).Copy

        V_Delete(_GroupByTH, "NGAY_CT")
        V_Delete(_GroupByCT, "NGAY_CT")
        V_Delete(_GroupByTH, "So_KHUNG")
        V_Delete(_GroupByCT, "So_KHUNG")
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByTH, _GroupByTH, "Ma", "Ten")
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByCT, _GroupByCT, "Ma", "Ten")


        '-----------



        TxtMa_KX.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_KX)
        TxtMa_mau.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_mau)
        TxtSo_khung.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtSo_khung)

        TxtTen_kx.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_KX", "Dmkx", "(Ma_KX= N'" + TxtMa_KX.Text.Trim + "')", CyberSmLib)
        txtTen_Mau.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_mau", "DmMauxe", "(Ma_mau= N'" + TxtMa_mau.Text.Trim + "')", CyberSmLib)

        TxtNh_Kx1.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Nh", "DmNhKx", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Kx1.Text.Trim + "')", CyberSmLib)
        TxtNh_Kx2.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Nh", "DmNhKx", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Kx2.Text.Trim + "')", CyberSmLib)
        TxtNh_Kx3.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Nh", "DmNhKx", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Kx3.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Delete(ByRef _Dt As DataTable, ByVal _Ma As String)
        If _Dt Is Nothing Or _Ma.Trim = "" Then Return
        Dim nCount As Integer = _Dt.Rows.Count - 1
        For i As Integer = nCount To 0 Step -1
            If _Dt.Rows(i).Item("Ma").ToString.Trim.ToUpper = _Ma.ToUpper.Trim Then _Dt.Rows(i).Delete()
        Next
        _Dt.AcceptChanges()
    End Sub

    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '-------------
        RemoveHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK
        AddHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK
        '-----------

        '--Ma_VT
        AddHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_Kx
        '-- Tk vt
        AddHandler TxtMa_mau.CyberValiting, AddressOf V_Ma_mau
        AddHandler TxtMa_mau.CyberLeave, AddressOf L_Ma_mau
        '--Vt1
        RemoveHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_kx1
        RemoveHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_kx1
        AddHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_kx1
        AddHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_kx1
        '--VT2
        RemoveHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_kx2
        RemoveHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_kx2
        AddHandler TxtNh_Kx2.CyberValiting, AddressOf V_Nh_kx2
        AddHandler TxtNh_Kx2.CyberLeave, AddressOf L_Nh_kx2
        '--VT3
        RemoveHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_kx3
        RemoveHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_kx3
        AddHandler TxtNh_Kx3.CyberValiting, AddressOf V_Nh_kx3
        AddHandler TxtNh_Kx3.CyberLeave, AddressOf L_Nh_kx3
        '----------
        AddHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_Bp
        AddHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_Bp
        '----
        AddHandler TxtMa_HS.CyberValiting, AddressOf V_Ma_HS
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_Ma_HS
    End Sub


#End Region
#Region "Valid"

#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_KX.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_KX.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KX.Text = DrReturn.Item("Ma_Kx")
            TxtTen_kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_KX.Text = ""
            TxtTen_kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid ---MA_MAU"
    Private Sub V_Ma_mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_mau.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_mau", "DmMauxe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_mau.Text = DrReturn.Item("Ma_mau")
            txtTen_Mau.Text = DrReturn.Item("Ten_mau")
        Else
            TxtMa_mau.Text = ""
            txtTen_Mau.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid ---MA_HS"
    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HS.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "dmhs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_HS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS.Text = DrReturn.Item("Ma_HS")
            TxtTen_HS.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_HS.Text = ""
            TxtTen_HS.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid ---MA_BP"
    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bp.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Bp", "dmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Bp.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp.Text = DrReturn.Item("Ma_Bp")
            TxtTen_bP.Text = DrReturn.Item("Ten_bp")
        Else
            TxtMa_Bp.Text = ""
            TxtTen_bP.Text = ""
            Exit Sub
        End If
    End Sub
#End Region

#Region "Vali --- Nh_kx1"
    Private Sub V_Nh_kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhKx", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_kx1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx1.Text = "" Then
            txtten_nhKX1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx1.Text = DrReturn.Item("Ma_Nh")
            txtten_nhKX1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx1.Text = ""
            txtten_nhKX1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_kx2"
    Private Sub V_Nh_kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhKx", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_kx2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx2.Text = "" Then
            txtten_nhkx2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx2.Text = DrReturn.Item("Ma_Nh")
            txtten_nhkx2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx2.Text = ""
            txtten_nhkx2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_kx3"
    Private Sub V_Nh_kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Kx3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_kx3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_Kx3.Text = "" Then
            txtten_nhKX3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Kx3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kx3.Text = DrReturn.Item("Ma_Nh")
            txtten_nhKX3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx3.Text = ""
            txtten_nhKX3.Text = ""
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
        Dim _Ngay_CT1 As Date = TxtM_Ngay_Ct1.Value
        Dim _Ngay_CT2 As Date = TxtM_Ngay_Ct2.Value
        Dim _Ngay_CT3 As Date = TxtM_Ngay_Ct3.Value
        Dim _Ngay_CT4 As Date = TxtM_Ngay_Ct4.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = CbbGroupByTH.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & If(ChkDetail_OK.Checked, CbbGroupByCT.SelectedValue.ToString.Trim, "")
        M_strParameterStore = M_strParameterStore & "#" & _Ngay_CT1.ToString("yyyyMMdd") & "#" & _Ngay_CT2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & _Ngay_CT3.ToString("yyyyMMdd") & "#" & _Ngay_CT4.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_KX.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_mau.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_khung.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HS.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Bp.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx1.Text.Trim()
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Kx3.Text.Trim
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
