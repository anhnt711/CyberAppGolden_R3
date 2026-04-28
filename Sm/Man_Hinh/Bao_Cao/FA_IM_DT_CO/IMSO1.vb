Public Class IMSO1
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub IMSO1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        TxtMa_kho.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_kho)
        TxtMa_Cc.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Cc)

        If TxtMa_kho.Text.Trim = "" Then TxtTen_kho.Text = "" Else TxtTen_kho.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_kho.Text.Trim + "')", CyberSmLib)
        If TxtMa_Cc.Text.Trim = "" Then TxtTen_Cc.Text = "" Else TxtTen_Cc.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Cc", "DmCc", "(Ma_Cc= N'" + TxtMa_Cc.Text.Trim + "')", CyberSmLib)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--ma_kho
        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Ma_KHo
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_Ma_KHo
        '--Ma_Cc
        AddHandler TxtMa_Cc.CyberValiting, AddressOf V_Ma_Cc
        AddHandler TxtMa_Cc.CyberLeave, AddressOf L_Ma_CC

    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_KHo"
    Private Sub V_Ma_KHo(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_kho.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KHo", "DmKHo", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KHo(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_kho.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_kho.Text = ""
            TxtTen_kho.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Cc"
    Private Sub V_Ma_Cc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Cc.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Cc", "DmCc", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Cc.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Cc.Text = DrReturn.Item("Ma_Cc")
            TxtTen_Cc.Text = DrReturn.Item("Ten_Cc")
        Else
            TxtMa_Cc.Text = ""
            TxtTen_Cc.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        If TxtMa_kho.Text.Trim = "" Then
            TxtMa_kho.Focus()
            Exit Sub
        End If
        If TxtMa_Cc.Text.Trim = "" Then
            TxtMa_Cc.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Me.Para(Me.VT_PARA + 2).Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_kho.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Cc.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
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
