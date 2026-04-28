Public Class BEKH6_HDX_HDC
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DsLookup As DataSet
    Dim DrReturn As DataRow
    Dim _Dt_GD, _DtGroup, _DtGroupCt As DataTable
    Dim M_Ma_CT As String = ""
    Dim M_Ma_GD As String = ""
    Dim M_Loai_TH As String = "0"
    Dim M_Loai_CT As String = "0"
    Private Sub SysDateToDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Ma_CT = Me.Para(Me.VT_PARA + 2).Trim
        M_Loai_TH = Me.Para(Me.VT_PARA + 3).Trim
        M_Loai_CT = Me.Para(Me.VT_PARA + 4).Trim
        M_Ma_GD = Me.Para(Me.VT_PARA + 5).Trim
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
        V_VisibleCT()
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
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '--------------------------------------------------------------------
        Dim _DsMa_GD As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetGD", M_Ma_CT)
        _Dt_GD = _DsMa_GD.Tables(0).Copy
        CyberFill.V_FillComBoxValue(Me.CbbMa_GD, _Dt_GD, "ma_gd", "Ten_gd", M_Ma_GD)
        _DsMa_GD.Dispose()

        Dim _DsGroup As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTHRO", M_Ma_CT + "#" + "" + "#" + "" + "#" + Me.Ma_Dvcs + "#" + Me.User_Name)
        _DtGroup = _DsGroup.Tables(0).Copy
        _DtGroupct = _DsGroup.Tables(1).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByTH, _DtGroup, "Ma", "Ten")
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByCT, _DtGroupct, "Ma", "Ten")
        _DsGroup.Dispose()
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

        ' Mã bộ phận
        AddHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP
        'Mã nhân viên
        AddHandler TxtMa_HS.CyberValiting, AddressOf V_Ma_HS
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_Ma_HS
        'Mã kiểu xe
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
        'Mã màu xe
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        '--
        RemoveHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK
        AddHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK

    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_BP.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_BP", "DMBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_BP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BP.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BP.Text = ""
            TxtTen_BP.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_HS"
    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HS.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HS", "DMHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_HS.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS.Text = DrReturn.Item("Ma_Hs")
            TxtTen_HS.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_HS.Text = ""
            TxtTen_HS.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kx.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DMKX", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Mau.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Mau", "DMMAUXE", "1=1", "1=1")
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

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = CbbGroupByTH.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & If(ChkDetail_OK.Checked, CbbGroupByCT.SelectedValue.ToString.Trim, "")
        M_strParameterStore = M_strParameterStore & "#" & _Ngay_CT1.ToString("yyyyMMdd") & "#" & _Ngay_CT2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbMa_GD.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_BP.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HS.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kx.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Mau.Text.Trim
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
