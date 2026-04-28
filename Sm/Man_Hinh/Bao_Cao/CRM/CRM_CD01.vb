Public Class CRM_CD01
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim Dtloai As New DataTable
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub SysDateToDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        '-----Loại
        If TxtMa_chiendich.Text.Trim = "" Then TxtTen_Chiendich.Text = "" Else TxtTen_Chiendich.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_ChienDich", "DmChienDich", "Ma_chiendich = N'" + TxtMa_chiendich.Text.Trim + "'", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--Ma_kh
        AddHandler TxtMa_chiendich.CyberValiting, AddressOf V_Ma_Chiendich
        AddHandler TxtMa_chiendich.CyberLeave, AddressOf L_Ma_ChienDich
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_KX
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
    End Sub
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_chiendich.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kx.Text.Trim
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
#Region "Valid --- Ma_chiến dịch"
    Private Sub V_Ma_Chiendich(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_chiendich.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_chienDich", "DmChienDich", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_ChienDich(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_chiendich.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_chiendich.Text = DrReturn.Item("Ma_chienDich")
            TxtTen_Chiendich.Text = DrReturn.Item("Ten_ChienDich")
        Else
            TxtMa_chiendich.Text = ""
            TxtTen_Chiendich.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- Ma_KX"
    Private Sub V_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kx.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Kx.Text = "" Then
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region
End Class
