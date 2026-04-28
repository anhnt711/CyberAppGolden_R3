Public Class GLBK5
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub GLBK5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Try
            TxtM_Tk.Text = Me.Para(Me.VT_PARA + 2).ToString.Trim
        Catch ex As Exception

        End Try
        If TxtM_Tk.Text.Trim = "" Then TxtM_Tk.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_Tk)
        If TxtM_Tk.Text.Trim = "" Then Txtten_Tk.Text = "" Else Txtten_Tk.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtM_Tk.Text.Trim + "'", CyberSmLib)

        If TxtM_TK_Du.Text.Trim = "" Then TxtM_TK_Du.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_TK_Du)
        If TxtM_TK_Du.Text.Trim = "" Then Txtten_Tk_Du.Text = "" Else Txtten_Tk_Du.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtM_TK_Du.Text.Trim + "'", CyberSmLib)


        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '-------------------------------------------------------------------------------------------------------------------
        '--Tk
        RemoveHandler TxtM_Tk.CyberValiting, AddressOf V_TK
        RemoveHandler TxtM_Tk.CyberLeave, AddressOf L_TK
        AddHandler TxtM_Tk.CyberValiting, AddressOf V_TK
        AddHandler TxtM_Tk.CyberLeave, AddressOf L_Tk
        '--Tk_DU
        RemoveHandler TxtM_TK_Du.CyberValiting, AddressOf V_Tk_DU
        RemoveHandler TxtM_TK_Du.CyberLeave, AddressOf L_Tk_DU
        AddHandler TxtM_TK_Du.CyberValiting, AddressOf V_Tk_DU
        AddHandler TxtM_TK_Du.CyberLeave, AddressOf L_Tk_DU
        '--Ma_kh
        RemoveHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        RemoveHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        '-------------------------------------------------------------------------------------------------------------------
        '--Vv
        RemoveHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        RemoveHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        AddHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        AddHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        '--HD
        RemoveHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        RemoveHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        '--Phi
        RemoveHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_Phi
        RemoveHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_Phi
        AddHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_Phi
        AddHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_Phi
        '--Sp
        RemoveHandler TxtMa_Sp.CyberValiting, AddressOf V_Ma_Sp
        RemoveHandler TxtMa_Sp.CyberLeave, AddressOf L_Ma_Sp
        AddHandler TxtMa_Sp.CyberValiting, AddressOf V_Ma_Sp
        AddHandler TxtMa_Sp.CyberLeave, AddressOf L_Ma_Sp
        '--TTLN
        RemoveHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        RemoveHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN

        '--TTCP
        RemoveHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        RemoveHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        '--Ku
        RemoveHandler Txtma_Ku.CyberValiting, AddressOf V_Ma_Ku
        RemoveHandler Txtma_Ku.CyberLeave, AddressOf L_Ma_Ku
        AddHandler Txtma_Ku.CyberValiting, AddressOf V_Ma_Ku
        AddHandler Txtma_Ku.CyberLeave, AddressOf L_Ma_Ku
        '--CD
        RemoveHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        RemoveHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD
        AddHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        AddHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD

        '--Bp
        RemoveHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_Bp
        RemoveHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_Bp
        AddHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_Bp
        AddHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_Bp

        '--Hs
        RemoveHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        RemoveHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs

        '--TD1
        RemoveHandler TxtMa_Td1.CyberValiting, AddressOf V_Ma_TD1
        RemoveHandler TxtMa_Td1.CyberLeave, AddressOf L_Ma_TD1
        AddHandler TxtMa_Td1.CyberValiting, AddressOf V_Ma_TD1
        AddHandler TxtMa_Td1.CyberLeave, AddressOf L_Ma_TD1
        '--TD2
        RemoveHandler TxtMa_Td2.CyberValiting, AddressOf V_Ma_TD2
        RemoveHandler TxtMa_Td2.CyberLeave, AddressOf L_Ma_TD2
        AddHandler TxtMa_Td2.CyberValiting, AddressOf V_Ma_TD2
        AddHandler TxtMa_Td2.CyberLeave, AddressOf L_Ma_TD2
        '--TD3
        RemoveHandler TxtMa_Td3.CyberValiting, AddressOf V_Ma_TD3
        RemoveHandler TxtMa_Td3.CyberLeave, AddressOf L_Ma_TD3
        AddHandler TxtMa_Td3.CyberValiting, AddressOf V_Ma_TD3
        AddHandler TxtMa_Td3.CyberLeave, AddressOf L_Ma_TD3
        '--TD4
        RemoveHandler TxtMa_Td4.CyberValiting, AddressOf V_Ma_TD4
        RemoveHandler TxtMa_Td4.CyberLeave, AddressOf L_Ma_TD4
        AddHandler TxtMa_Td4.CyberValiting, AddressOf V_Ma_TD4
        AddHandler TxtMa_Td4.CyberLeave, AddressOf L_Ma_TD4
        '--TD5
        RemoveHandler TxtMa_Td5.CyberValiting, AddressOf V_Ma_TD5
        RemoveHandler TxtMa_Td5.CyberLeave, AddressOf L_Ma_TD5
        AddHandler TxtMa_Td5.CyberValiting, AddressOf V_Ma_TD5
        AddHandler TxtMa_Td5.CyberLeave, AddressOf L_Ma_TD5

    End Sub
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        
        Dim M_strParameterStore As String = Me.Para(Me.VT_PARA + 3)
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtM_Tk.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & "0"
        M_strParameterStore = M_strParameterStore & "#" & TxtM_TK_Du.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kh.Text.Trim

        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Vv.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_phi.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Sp.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Txtma_Ku.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TTLN.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TTCP.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Bp.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CD.TExt.trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Td1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Td2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Td3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Td4.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Td5.Text.Trim
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
#Region "Valid --- Tk_Du"
    Private Sub V_Tk_Du(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtM_TK_Du.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Du(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtM_TK_Du.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtM_TK_Du.Text = DrReturn.Item("Tk0")
            Txtten_Tk_Du.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtM_TK_Du.Text = ""
            Txtten_Tk_Du.Text = ""
            Exit Sub
        End If
    End Sub
#End Region

#Region "Vali --- Ma_Kh"
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KH", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Kh.Text = "" Then
            TxtTen_kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_KH")
            TxtTen_kh.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_kh.Text = ""
        End If
    End Sub
#End Region
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
#Region "Vali --- Ma_HD"
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HD.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_HD.Text = "" Then
            TxtTen_HD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HD.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn.Item("Ma_HD")
            TxtTen_HD.Text = DrReturn.Item("Ten_HD")
        Else
            TxtMa_HD.Text = ""
            TxtTen_HD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Phi"
    Private Sub V_Ma_Phi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_phi.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Phi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_phi.Text = "" Then
            TxtTen_Phi.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_phi.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_phi.Text = DrReturn.Item("Ma_Phi")
            TxtTen_Phi.Text = DrReturn.Item("Ten_Phi")
        Else
            TxtMa_phi.Text = ""
            TxtTen_Phi.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Sp"
    Private Sub V_Ma_Sp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Sp.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Sp", "DmSp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Sp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Sp.Text = "" Then
            TxtTen_Sp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Sp.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Sp.Text = DrReturn.Item("Ma_Sp")
            TxtTen_Sp.Text = DrReturn.Item("Ten_Sp")
        Else
            TxtMa_Sp.Text = ""
            TxtTen_Sp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTLN"
    Private Sub V_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTLN.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TTLN.Text = "" Then
            TxtTen_TTLN.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTLN.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TTLN.Text = DrReturn.Item("Ma_TTLN")
            TxtTen_TTLN.Text = DrReturn.Item("Ten_TTLN")
        Else
            TxtMa_TTLN.Text = ""
            TxtTen_TTLN.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTCP"
    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTCP.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TTCP.Text = "" Then
            TxtTen_TTCP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTCP.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP.Text = ""
            TxtTen_TTCP.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Ku"
    Private Sub V_Ma_Ku(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_Ku.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Ku", "DmKu", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Ku(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Txtma_Ku.Text = "" Then
            TxtTen_ku.Text = ""
            Exit Sub
        End If
        DrReturn = Txtma_Ku.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            Txtma_Ku.Text = DrReturn.Item("Ma_Ku")
            TxtTen_ku.Text = DrReturn.Item("Ten_Ku")
        Else
            Txtma_Ku.Text = ""
            TxtTen_ku.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_CD"
    Private Sub V_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CD.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_CD", "DmCD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Txtma_CD.Text = "" Then
            TxtTen_CD.Text = ""
            Exit Sub
        End If
        DrReturn = Txtma_CD.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            Txtma_CD.Text = DrReturn.Item("Ma_CD")
            TxtTen_CD.Text = DrReturn.Item("Ten_CD")
        Else
            Txtma_CD.Text = ""
            TxtTen_CD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Bp"
    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bp.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Bp.Text = "" Then
            TxtTen_Bp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Bp.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp.Text = DrReturn.Item("Ma_Bp")
            TxtTen_Bp.Text = DrReturn.Item("Ten_Bp")
        Else
            TxtMa_Bp.Text = ""
            TxtTen_Bp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD1"
    Private Sub V_Ma_TD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD1.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.Appconn, DsLookup, "Ma_TD1", "DmTD1", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td1.Text = "" Then
            TxtTen_Td1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td1.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td1.Text = DrReturn.Item("Ma_TD1")
            TxtTen_Td1.Text = DrReturn.Item("Ten_TD1")
        Else
            TxtMa_Td1.Text = ""
            TxtTen_Td1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD2"
    Private Sub V_Ma_TD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD2.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.Appconn, DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td2.Text = "" Then
            TxtTen_Td2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td2.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td2.Text = DrReturn.Item("Ma_TD2")
            TxtTen_Td2.Text = DrReturn.Item("Ten_TD2")
        Else
            TxtMa_Td2.Text = ""
            TxtTen_Td2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD3"
    Private Sub V_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TD3.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.Appconn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td3.Text = "" Then
            TxtTen_Td3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td3.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td3.Text = DrReturn.Item("Ma_TD3")
            TxtTen_Td3.Text = DrReturn.Item("Ten_TD3")
        Else
            TxtMa_Td3.Text = ""
            TxtTen_Td3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD4"
    Private Sub V_Ma_TD4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Td4.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.Appconn, DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td4.Text = "" Then
            TxtTen_Td4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td4.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td4.Text = DrReturn.Item("Ma_TD4")
            TxtTen_Td4.Text = DrReturn.Item("Ten_TD4")
        Else
            TxtMa_Td4.Text = ""
            TxtTen_Td4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD5"
    Private Sub V_Ma_TD5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Td5.V_LookUp(Me.LAN, Me.Para, Me.Sysvar, Me.AppConn, DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td5.Text = "" Then
            TxtTen_Td5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td5.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td5.Text = DrReturn.Item("Ma_TD5")
            TxtTen_Td5.Text = DrReturn.Item("Ten_TD5")
        Else
            TxtMa_Td5.Text = ""
            TxtTen_Td5.Text = ""
        End If
    End Sub
#End Region

End Class
