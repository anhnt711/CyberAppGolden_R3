Public Class GLGSSO4Detail
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub GLGSSO4Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


        Try
            TxtRec_gs.Text = Me.Para(Me.VT_PARA + 2).ToString.Trim
        Catch ex As Exception

        End Try
        If TxtRec_gs.Text.Trim = "" Then TxtRec_gs.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtRec_gs)
        If TxtM_Tk.Text.Trim = "" Then TxtM_Tk.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_Tk)
        If TxtM_Tk.Text.Trim = "" Then Txtten_Tk.Text = "" Else Txtten_Tk.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtM_Tk.Text.Trim + "'", CyberSmLib)
        If Txttk_du.Text.Trim = "" Then Txtten_tk_du.Text = "" Else Txtten_tk_du.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + Txttk_du.Text.Trim + "'", CyberSmLib)


        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--TK
        AddHandler TxtRec_gs.CyberValiting, AddressOf V_So_rec
        AddHandler TxtRec_gs.CyberLeave, AddressOf L_So_rec

        '--TK
        AddHandler TxtM_Tk.CyberValiting, AddressOf V_Tk
        AddHandler TxtM_Tk.CyberLeave, AddressOf L_Tk
        '--TK
        AddHandler Txttk_du.CyberValiting, AddressOf V_Tk_du
        AddHandler Txttk_du.CyberLeave, AddressOf L_Tk_du
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- so_rec"
    Private Sub V_So_rec(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtRec_gs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "rec_gs", "ctgs", "1=1", "1=1")
    End Sub
    Private Sub L_So_rec(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtRec_gs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtRec_gs.Text = DrReturn.Item("rec_gs")

        Else
            TxtRec_gs.Text = ""

            Exit Sub
        End If
    End Sub
#End Region
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
#Region "Valid --- Tk_du"
    Private Sub V_Tk_du(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txttk_du.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_du(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = Txttk_du.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txttk_du.Text = DrReturn.Item("Tk0")
            Txtten_tk_du.Text = DrReturn.Item("Ten_TK0")
        Else
            Txttk_du.Text = ""
            Txtten_tk_du.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtRec_gs.Text.Trim = "" Then
            TxtRec_gs.Focus()
            Exit Sub
        End If

        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = TxtRec_gs.Text.Trim.Replace("#", "")
        M_strParameterStore = M_strParameterStore & "#" & TxtM_Tk.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Txttk_du.Text.Trim
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
