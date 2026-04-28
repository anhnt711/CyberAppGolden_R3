Public Class GLTH1TTCP
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub GLTH1TTCP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        V_AddMenuShorcut()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        TxtM_Tk.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_Tk)
        TxtM_Ma_TTCP.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_Ma_TTCP)
        TxtM_Ma_TTLN.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_Ma_TTLN)
        If TxtM_Tk.Text.Trim = "" Then TxtM_Tk.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, "TXTM_TK011")
        If TxtM_Tk.Text.Trim = "" Then Txtten_Tk.Text = "" Else Txtten_Tk.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtM_Tk.Text.Trim + "'", CyberSmLib)
        If TxtM_Ma_TTCP.Text.Trim = "" Then TxtTen_TTCP.Text = "" Else TxtTen_TTCP.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTCP", "DmTTCP", "Ma_TTCP = N'" + TxtM_Ma_TTCP.Text.Trim + "'", CyberSmLib)
        If TxtM_Ma_TTLN.Text.Trim = "" Then TxtTen_TTLN.Text = "" Else TxtTen_TTLN.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTLN", "DmTTLN", "Ma_TTLN = N'" + TxtM_Ma_TTLN.Text.Trim + "'", CyberSmLib)
        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--TK
        AddHandler TxtM_Tk.CyberValiting, AddressOf V_Tk
        AddHandler TxtM_Tk.CyberLeave, AddressOf L_Tk
        '--TTCP
        AddHandler TxtM_Ma_TTCP.CyberValiting, AddressOf V_TTCP
        AddHandler TxtM_Ma_TTCP.CyberLeave, AddressOf L_TTCP
        '--TTLN
        AddHandler TxtM_Ma_TTLN.CyberValiting, AddressOf V_TTLN
        AddHandler TxtM_Ma_TTLN.CyberLeave, AddressOf L_TTLN
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Tk"
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtM_Tk.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtM_Tk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtM_Tk.Text = DrReturn.Item("Tk0")
            Txtten_Tk.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtM_Tk.Text = ""
            Txtten_Tk.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- TTLN"
    Private Sub V_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtM_Ma_TTLN.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
    End Sub
    Private Sub L_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtM_Ma_TTLN.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtM_Ma_TTLN.Text = DrReturn.Item("Ma_TTLN")
            TxtTen_TTLN.Text = DrReturn.Item("Ten_TTLN")
        Else
            TxtM_Ma_TTLN.Text = ""
            TxtTen_TTLN.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- TTCP"
    Private Sub V_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtM_Ma_TTCP.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtM_Ma_TTCP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtM_Ma_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtM_Ma_TTCP.Text = ""
            TxtTen_TTCP.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtM_Tk.Text.Trim = "" Then
            TxtM_Tk.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = TxtM_Tk.Text.Trim.Replace("#", "")
        M_strParameterStore = M_strParameterStore & "#" & TxtM_Ma_TTLN.Text.Trim()
        M_strParameterStore = M_strParameterStore & "#" & TxtM_Ma_TTCP.Text.Trim()
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
