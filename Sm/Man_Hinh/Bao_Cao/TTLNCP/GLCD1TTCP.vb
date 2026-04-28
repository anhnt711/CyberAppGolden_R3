Public Class GLCD1TTCP
    Dim DtBac_Tk As DataTable
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub GLCD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberSmLib.AddStatusVoucher(Me, Me.User_Name.Trim & "(" & Me.Comment.Trim & ")", Me.sysvar("M_Cyber_Ver"), Me.Ma_Dvcs)
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '-----
        DtBac_Tk = GetBac_TK()
        CyberFill.V_FillComBoxValue(Me.CbbM_Bac_TK, DtBac_Tk, "Bac_Tk", IIf(Me.LAN = "V", "Ten_Bac", "Ten_Bac2"), "0")
        CbbM_Bac_TK.SelectedValue = "0"
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        '----
        TxtM_Ma_TTCP.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_Ma_TTCP)
        TxtM_Ma_TTLN.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_Ma_TTLN)

        If TxtM_Ma_TTCP.Text.Trim = "" Then TxtTen_TTCP.Text = "" Else TxtTen_TTCP.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTCP", "DmTTCP", "Ma_TTCP = N'" + TxtM_Ma_TTCP.Text.Trim + "'", CyberSmLib)
        If TxtM_Ma_TTLN.Text.Trim = "" Then TxtTen_TTLN.Text = "" Else TxtTen_TTLN.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTLN", "DmTTLN", "Ma_TTLN = N'" + TxtM_Ma_TTLN.Text.Trim + "'", CyberSmLib)

        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Function GetBac_TK() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Bac_Tk")
        _Return.Columns.Add("Ten_Bac")
        _Return.Columns.Add("Ten_Bac2")
        _Return.Rows.Add("0", "Tất cả các bậc tài khoản", "All")
        _Return.Rows.Add("1", "Tài khoản bậc 1", "Account type 1")
        _Return.Rows.Add("2", "Tài khoản bậc 2", "Account type 2")
        _Return.Rows.Add("3", "Tài khoản bậc 3", "Account type 3")
        _Return.Rows.Add("4", "Tài khoản bậc 4", "Account type 4")
        _Return.Rows.Add("5", "Tài khoản bậc 5", "Account type 5")
        _Return.Rows.Add("6", "Tài khoản bậc 6", "Account type 6")
        _Return.Rows.Add("7", "Tài khoản bậc 7", "Account type 7")
        _Return.Rows.Add("8", "Tài khoản bậc 8", "Account type 8")
        _Return.Rows.Add("9", "Tài khoản bậc 9", "Account type 9")
        _Return.Rows.Add("10", "Tài khoản bậc 10", "Account type 10")

        GetBac_TK = _Return
    End Function
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--TTCP
        AddHandler TxtM_Ma_TTCP.CyberValiting, AddressOf V_TTCP
        AddHandler TxtM_Ma_TTCP.CyberLeave, AddressOf L_TTCP
        '--TTLN
        AddHandler TxtM_Ma_TTLN.CyberValiting, AddressOf V_TTLN
        AddHandler TxtM_Ma_TTLN.CyberLeave, AddressOf L_TTLN

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
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        CyberMe.M_Loai_DK_Loc = "1"
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_Bac_Tk As String = Me.CbbM_Bac_TK.SelectedValue.ToString.Trim
        Dim M_LK As String = "0"
        If ChkM_LK.Checked Then M_LK = "1" Else M_LK = "0"

        Dim M_strParameterStore As String = TxtM_Ma_TTLN.Text.Trim()
        M_strParameterStore = M_strParameterStore & "#" & TxtM_Ma_TTCP.Text.Trim()
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Bac_Tk
        M_strParameterStore = M_strParameterStore & "#" & M_LK
        M_strParameterStore = M_strParameterStore & "#" & ""
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
