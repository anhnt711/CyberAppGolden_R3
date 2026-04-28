Public Class ROBHTHXBH
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _Dt_GD, _Dt_post1, _Dt_post2, _GroupByTH, _GroupByCT As DataTable

    Private Sub ROBHTHXBH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChkDetail_OK.Checked = False
        V_AddMenuShorcut()
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
    Private Sub V_Load()

        '--------------------------------------------------------------------
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----------------------
        Dim _DsGroup As New DataSet
        _DsGroup = Nothing
        _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_ROBHSupportTH_BH", "2" + "#" + "" + "#" + "" + "#" + "" + "#" + "" + "#" + Me.Ma_Dvcs + "#" + Me.User_Name)
        _GroupByTH = _DsGroup.Tables(0).Copy
        _GroupByCT = _DsGroup.Tables(1).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByTH, _GroupByTH, "Ma", "Ten")
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByCT, _GroupByCT, "Ma", "Ten")
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_Hs_h.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs_h)
        If TxtMa_Hs_h.Text.Trim = "" Then TxtTen_Hs_h.Text = "" Else TxtTen_Hs_h.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Hs", "DmHs", "(Ma_Hs= N'" + TxtMa_Hs_h.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        RemoveHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK
        AddHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK
        '-----------
        '--KH
        AddHandler txtMa_kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler txtMa_kh.CyberLeave, AddressOf L_Ma_KH

        '--Hs
        AddHandler TxtMa_Hs_h.CyberValiting, AddressOf V_Ma_Hs_H
        AddHandler TxtMa_Hs_h.CyberLeave, AddressOf L_Ma_Hs_H

        '--bp
        AddHandler TxtMa_BP_H.CyberValiting, AddressOf V_Ma_BP_H
        AddHandler TxtMa_BP_H.CyberLeave, AddressOf L_Ma_BP_H

        'BH
        AddHandler txtMa_BH.CyberValiting, AddressOf V_Ma_BH
        AddHandler txtMa_BH.CyberLeave, AddressOf L_Ma_BH


    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_BH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If txtMa_kh.Text = "" Then
            txtTen_Kh.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            txtMa_kh.Text = DrReturn.Item("Ma_KH")
            txtTen_Kh.Text = DrReturn.Item("Ten_KH")
        Else
            txtMa_kh.Text = ""
            txtTen_Kh.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Hs_h.Text = "" Then
            TxtTen_Hs_h.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs_h.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs_h.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs_h.Text = ""
            TxtTen_Hs_h.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_BP"
    Private Sub V_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_BP_H.Text = "" Then
            TxtTen_BP_H.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_BP_H.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP_H.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BP_H.Text = ""
            TxtTen_BP_H.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_BH"
    Private Sub V_Ma_BH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_BH", "DmBH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If txtMa_BH.Text = "" Then
            txtTen_BH.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            txtMa_BH.Text = DrReturn.Item("Ma_BH")
            txtTen_BH.Text = DrReturn.Item("Ten_BH")
        Else
            txtMa_BH.Text = ""
            txtTen_BH.Text = ""
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
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = CbbGroupByTH.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & If(ChkDetail_OK.Checked, CbbGroupByCT.SelectedValue.ToString.Trim, "")
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & txtMa_kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs_h.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_BP_H.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & txtMa_BH.Text.Trim
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
