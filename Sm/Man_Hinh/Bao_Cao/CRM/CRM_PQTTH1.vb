Public Class CRM_PQTTH1
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _Dt_GD, _Dt_post1, _Dt_post2 As DataTable
    Private Sub CRM_PQTTH1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        TxtMa_vt.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_vt)
        If TxtMa_vt.Text.Trim = "" Then TxtTen_vt.Text = "" Else TxtTen_vt.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Vt", "DmVt", "(Ma_Vt= N'" + TxtMa_vt.Text.Trim + "')", CyberSmLib)
        If TxtNh_Vt1.Text.Trim = "" Then TxtTen_Nh_Vt1.Text = "" Else TxtTen_Nh_Vt1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Vt1.Text.Trim + "')", CyberSmLib)
        If TxtNh_Vt2.Text.Trim = "" Then TxtTen_Nh_Vt2.Text = "" Else TxtTen_Nh_Vt2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Vt2.Text.Trim + "')", CyberSmLib)
        If TxtNh_Vt3.Text.Trim = "" Then TxtTen_Nh_Vt3.Text = "" Else TxtTen_Nh_Vt3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Vt3.Text.Trim + "')", CyberSmLib)
        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '-- ma Vt
        AddHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_vt
        AddHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_vt
        '-- nh_Vt1
        AddHandler TxtNh_Vt1.CyberValiting, AddressOf V_Nh_Vt1
        AddHandler TxtNh_Vt1.CyberLeave, AddressOf L_Nh_Vt1
        '-- nh_Vt2
        AddHandler TxtNh_Vt2.CyberValiting, AddressOf V_Nh_Vt2
        AddHandler TxtNh_Vt2.CyberLeave, AddressOf L_Nh_Vt2
        '-- nh_Vt3
        AddHandler TxtNh_Vt3.CyberValiting, AddressOf V_Nh_Vt3
        AddHandler TxtNh_Vt3.CyberLeave, AddressOf L_Nh_Vt3
    End Sub
#End Region

#Region "Valid --- Ma_vt"
    Private Sub V_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt.Text = DrReturn.Item("Ma_vt")
            TxtTen_vt.Text = DrReturn.Item("Ten_vt")
        Else
            TxtMa_vt.Text = ""
            TxtTen_vt.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Vt1"
    Private Sub V_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhVt", "1=1", "loai_nh='1'")
    End Sub
    Private Sub L_Nh_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt1.Text = DrReturn.Item("ma_nh")
            TxtTen_Nh_Vt1.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_Vt1.Text = ""
            TxtTen_Nh_Vt1.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Vt2"
    Private Sub V_Nh_Vt2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhVt", "1=1", "loai_nh='2'")
    End Sub
    Private Sub L_Nh_Vt2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt2.Text = DrReturn.Item("ma_nh")
            TxtTen_Nh_Vt2.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_Vt2.Text = ""
            TxtTen_Nh_Vt2.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nh_Vt3"
    Private Sub V_Nh_Vt3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", "DmnhVt", "1=1", "loai_nh='3'")
    End Sub
    Private Sub L_Nh_Vt3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt3.Text = DrReturn.Item("ma_nh")
            TxtTen_Nh_Vt3.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_Vt3.Text = ""
            TxtTen_Nh_Vt3.Text = ""
            Exit Sub
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
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt3.Text.Trim
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
