Public Class DTB04
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtGroupBy As DataTable

    Private Sub DTB04_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


        TxtMa_Vv.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Vv)

        If TxtMa_Vv.Text.Trim = "" Then TxtTen_Vv.Text = "" Else TxtTen_Vv.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_VV", "DmVV", "(Ma_VV= N'" + TxtMa_Vv.Text.Trim + "')", CyberSmLib)

        '----
        If TxtTk.Text.Trim = "" Then TxtTk.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtTk)
        If TxtTk.Text.Trim = "" Then Txtten_Tk.Text = "" Else Txtten_Tk.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtTk.Text.Trim + "'", CyberSmLib)
        '----
        If TxtTK02.Text.Trim = "" Then TxtTK02.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtTK02)
        If TxtTK02.Text.Trim = "" Then TxtTen_TK02.Text = "" Else TxtTen_TK02.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtTK02.Text.Trim + "'", CyberSmLib)
        If TxtTK03.Text.Trim = "" Then TxtTK03.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtTK03)
        If TxtTK03.Text.Trim = "" Then TxtTen_TK03.Text = "" Else TxtTen_TK03.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtTK03.Text.Trim + "'", CyberSmLib)
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--vv
        RemoveHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        RemoveHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        AddHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        AddHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        '--TK
        AddHandler TxtTk.CyberValiting, AddressOf V_Tk
        AddHandler TxtTk.CyberLeave, AddressOf L_Tk

        RemoveHandler TxtTK02.CyberValiting, AddressOf V_Tk02
        RemoveHandler TxtTK02.CyberLeave, AddressOf L_Tk02
        AddHandler TxtTK02.CyberValiting, AddressOf V_Tk02
        AddHandler TxtTK02.CyberLeave, AddressOf L_Tk02

        RemoveHandler TxtTK03.CyberValiting, AddressOf V_Tk03
        RemoveHandler TxtTK03.CyberLeave, AddressOf L_Tk03
        AddHandler TxtTK03.CyberValiting, AddressOf V_Tk03
        AddHandler TxtTK03.CyberLeave, AddressOf L_Tk03

    End Sub
#End Region
#Region "Valid"

#Region "Vali --- Ma_Vv"
    Private Sub V_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vv.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Vv", "DmVv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Vv.Text = "" Then
            TxtTen_Vv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Vv.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Vv.Text = DrReturn.Item("Ma_Vv")
            TxtTen_Vv.Text = DrReturn.Item("Ten_Vv")
        Else
            TxtMa_Vv.Text = ""
            TxtTen_Vv.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Tk"
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("Tk0")
            Txtten_Tk.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTk.Text = ""
            Txtten_Tk.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Tk02"
    Private Sub V_Tk02(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTK02.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk02(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTK02.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK02.Text = DrReturn.Item("Tk0")
            TxtTen_TK02.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTK02.Text = ""
            TxtTen_TK02.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Tk03"
    Private Sub V_Tk03(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTK03.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk03(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTK03.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK03.Text = DrReturn.Item("Tk0")
            TxtTen_TK03.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTK03.Text = ""
            TxtTen_TK03.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Vv.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTk.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTK02.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTK03.Text.Trim
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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub
End Class
