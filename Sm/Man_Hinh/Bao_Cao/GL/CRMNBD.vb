Public Class CRMNBD
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _Dt_GD, _Dt_post1, _Dt_post2, _GroupByTH, _GroupByCT As DataTable
    Private Sub CRMNBD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        'RemoveHandler CbbLoai_Phieu.SelectedIndexChanged, AddressOf CbbLoai_Phieu_SelectedIndexChanged
        'AddHandler CbbLoai_Phieu.SelectedIndexChanged, AddressOf CbbLoai_Phieu_SelectedIndexChanged
        '--------------------------------------------------------------------
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_Hs_H.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs_H)
        If TxtMa_Hs_H.Text.Trim = "" Then TxtTen_Hs_H.Text = "" Else TxtTen_Hs_H.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Hs", "DmHs", "(Ma_Hs= N'" + TxtMa_Hs_H.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--Hs
        AddHandler TxtMa_Hs_H.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs_H.CyberLeave, AddressOf L_Ma_Hs

        '--Hs
        AddHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_KX
        AddHandler txtma_KX.CyberLeave, AddressOf L_Ma_KX


        '--Hs
        AddHandler txtma_mau.CyberValiting, AddressOf V_Ma_KX
        AddHandler txtma_KX.CyberLeave, AddressOf L_Ma_KX
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs_H.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Hs_H.Text = "" Then
            TxtTen_Hs_H.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs_H.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs_H.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs_H.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs_H.Text = ""
            TxtTen_Hs_H.Text = ""
        End If
    End Sub
#End Region
#End Region

#Region "Vali --- Ma_kx"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KX", "DmKX", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If txtma_KX.Text = "" Then
            txtTen_kx.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            txtma_KX.Text = DrReturn.Item("Ma_KX")
            txtTen_kx.Text = DrReturn.Item("Ten_KX")
        Else
            txtma_KX.Text = ""
            txtTen_kx.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Mau", "Dmmauxe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If txtMa_Mau.Text = "" Then
            txtTen_mau.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs_H.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            txtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            txtTen_mau.Text = DrReturn.Item("Ten_Mau")
        Else
            txtMa_Mau.Text = ""
            txtTen_mau.Text = ""
        End If
    End Sub
#End Region

#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_xe.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs_H.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & txtma_KX.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & txtMa_Mau.Text.Trim
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
