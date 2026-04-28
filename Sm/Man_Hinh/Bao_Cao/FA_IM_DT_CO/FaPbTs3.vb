Public Class FaPbTs3
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _GroupByTH, _GroupByCT As DataTable
    Private Sub FaPbTs3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChkDetail_OK.Checked = False
        V_AddMenuShorcut()
        V_Load()
        V_VisibleCT()
        V_Addhander()

    End Sub
#Region "Chi tiet theo"
    Private Sub V_VisibleCT()
        If ChkDetail_OK.Checked Then CbbGroupByCT.Visible = True Else CbbGroupByCT.Visible = False
    End Sub
    Private Sub V_Detail_OK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_VisibleCT()
    End Sub
#End Region
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        Dim _DsGroup As New DataSet
        _DsGroup = Nothing
        _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_FaSysGetTH", "" + "#" + "" + "#" + "" + "#" + "" + "#" + Me.Ma_Dvcs + "#" + Me.User_Name)
        _GroupByTH = _DsGroup.Tables(0).Copy
        _GroupByCT = _DsGroup.Tables(1).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByTH, _GroupByTH, "Ma", "Ten")
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByCT, _GroupByCT, "Ma", "Ten")


        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        '----
        TxtMa_ts.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_ts)
        TxtNh_ts1.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtNh_ts1)
        TxtNh_ts2.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtNh_ts2)
        TxtNh_ts3.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtNh_ts3)


        Txtten_ts.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Ts", "DmTs", "(Ma_Ts= N'" + TxtMa_ts.Text.Trim + "')", CyberSmLib)
        TxtTen_Nhts1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhts", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_ts1.Text.Trim + "')", CyberSmLib)
        TxtTen_Nhts2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhts", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_ts2.Text.Trim + "')", CyberSmLib)
        TxtTen_Nhts3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhts", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_ts3.Text.Trim + "')", CyberSmLib)

        '
        TxtMa_Vv.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Vv)
        TxtMa_HD.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_HD)
        TxtMa_phi.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_phi)
        TxtMa_Sp.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Sp)
        Txtma_Ku.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, Txtma_Ku)

        TxtMa_TTLN.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_TTLN)
        TxtMa_TTCP.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_TTCP)
        TxtMa_Bp.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Bp)
        TxtMa_Hs.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Hs)
        TxtMa_CD.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_CD)

        TxtMa_Td1.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Td1)
        TxtMa_Td2.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Td2)
        TxtMa_Td3.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Td3)
        TxtMa_Td4.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Td4)
        TxtMa_Td5.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Td5)


        If TxtMa_Vv.Text.Trim = "" Then TxtTen_Vv.Text = "" Else TxtTen_Vv.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_VV", "DmVV", "(Ma_VV= N'" + TxtMa_Vv.Text.Trim + "')", CyberSmLib)
        If TxtMa_HD.Text.Trim = "" Then TxtTen_HD.Text = "" Else TxtTen_HD.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HD", "DmHD", "(Ma_HD= N'" + TxtMa_HD.Text.Trim + "')", CyberSmLib)
        If TxtMa_phi.Text.Trim = "" Then TxtTen_Phi.Text = "" Else TxtTen_Phi.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Phi", "DmPhi", "(Ma_Phi= N'" + TxtMa_phi.Text.Trim + "')", CyberSmLib)
        If TxtMa_Sp.Text.Trim = "" Then TxtTen_Sp.Text = "" Else TxtTen_Sp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Sp", "DmSp", "(Ma_Sp= N'" + TxtMa_Sp.Text.Trim + "')", CyberSmLib)
        If Txtma_Ku.Text.Trim = "" Then TxtTen_ku.Text = "" Else TxtTen_ku.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Ku", "DmKu", "(Ma_Ku= N'" + Txtma_Ku.Text.Trim + "')", CyberSmLib)

        If TxtMa_TTLN.Text.Trim = "" Then TxtTen_TTLN.Text = "" Else TxtTen_TTLN.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTLN", "DmTTLN", "(Ma_TTLN= N'" + TxtMa_TTLN.Text.Trim + "')", CyberSmLib)
        If TxtMa_TTCP.Text.Trim = "" Then TxtTen_TTCP.Text = "" Else TxtTen_TTCP.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTCP", "DmTTCP", "(Ma_TTCP= N'" + TxtMa_TTCP.Text.Trim + "')", CyberSmLib)
        If TxtMa_Bp.Text.Trim = "" Then TxtTen_Bp.Text = "" Else TxtTen_Bp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Bp", "DmBp", "(Ma_Bp= N'" + TxtMa_Bp.Text.Trim + "')", CyberSmLib)
        If TxtMa_Hs.Text.Trim = "" Then TxtTen_Hs.Text = "" Else TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Hs", "DmHs", "(Ma_Hs= N'" + TxtMa_Hs.Text.Trim + "')", CyberSmLib)
        If TxtMa_CD.Text.Trim = "" Then TxtTen_CD.Text = "" Else TxtTen_CD.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_CD", "DmCD", "(Ma_CD= N'" + TxtMa_CD.Text.Trim + "')", CyberSmLib)

        If TxtMa_Td1.Text.Trim = "" Then TxtTen_Td1.Text = "" Else TxtTen_Td1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD1", "DmTD1", "(Ma_TD1= N'" + TxtMa_Td1.Text.Trim + "')", CyberSmLib)
        If TxtMa_Td2.Text.Trim = "" Then TxtTen_Td2.Text = "" Else TxtTen_Td2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD2", "DmTD2", "(Ma_TD2= N'" + TxtMa_Td2.Text.Trim + "')", CyberSmLib)
        If TxtMa_Td3.Text.Trim = "" Then TxtTen_Td3.Text = "" Else TxtTen_Td3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD3", "DmTD3", "(Ma_TD3= N'" + TxtMa_Td3.Text.Trim + "')", CyberSmLib)
        If TxtMa_Td4.Text.Trim = "" Then TxtTen_Td4.Text = "" Else TxtTen_Td4.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD4", "DmTD4", "(Ma_TD4= N'" + TxtMa_Td4.Text.Trim + "')", CyberSmLib)
        If TxtMa_Td5.Text.Trim = "" Then TxtTen_Td5.Text = "" Else TxtTen_Td5.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD5", "DmTD5", "(Ma_TD5= N'" + TxtMa_Td5.Text.Trim + "')", CyberSmLib)

        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        RemoveHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK
        AddHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK

        '-- ma cong cu
        AddHandler TxtMa_ts.CyberValiting, AddressOf V_Ma_ts
        AddHandler TxtMa_ts.CyberLeave, AddressOf L_Ma_ts
        '--TS1
        RemoveHandler TxtNh_ts1.CyberValiting, AddressOf V_NH_ts1
        RemoveHandler TxtNh_ts1.CyberLeave, AddressOf L_NH_ts1
        AddHandler TxtNh_ts1.CyberValiting, AddressOf V_NH_ts1
        AddHandler TxtNh_ts1.CyberLeave, AddressOf L_NH_ts1
        '--ts2
        RemoveHandler TxtNh_ts2.CyberValiting, AddressOf V_NH_ts2
        RemoveHandler TxtNh_ts2.CyberLeave, AddressOf L_NH_ts2
        AddHandler TxtNh_ts2.CyberValiting, AddressOf V_NH_ts2
        AddHandler TxtNh_ts2.CyberLeave, AddressOf L_NH_ts2
        '--ts3
        RemoveHandler TxtNh_ts3.CyberValiting, AddressOf V_NH_ts3
        RemoveHandler TxtNh_ts3.CyberLeave, AddressOf L_NH_ts3
        AddHandler TxtNh_ts3.CyberValiting, AddressOf V_NH_ts3
        AddHandler TxtNh_ts3.CyberLeave, AddressOf L_NH_ts3

        '-------------------------------------------------------------------
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
        '--Ku
        RemoveHandler Txtma_Ku.CyberValiting, AddressOf V_Ma_Ku
        RemoveHandler Txtma_Ku.CyberLeave, AddressOf L_Ma_Ku
        AddHandler Txtma_Ku.CyberValiting, AddressOf V_Ma_Ku
        AddHandler Txtma_Ku.CyberLeave, AddressOf L_Ma_Ku

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

        '--CD
        RemoveHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        RemoveHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD
        AddHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        AddHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD

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
#Region "Valid"
#Region "Valid --- Ma_ts"
    Private Sub V_Ma_ts(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_ts.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_ts", "Dmts", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_ts(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_ts.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_ts.Text = DrReturn.Item("Ma_ts")
            Txtten_ts.Text = DrReturn.Item("Ten_ts")
        Else
            TxtMa_ts.Text = ""
            Txtten_ts.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- NH_ts1"
    Private Sub V_NH_ts1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_ts1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhts", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_ts1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_ts1.Text = "" Then
            TxtTen_Nhts1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_ts1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ts1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nhts1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ts1.Text = ""
            TxtTen_Nhts1.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- NH_TS2"
    Private Sub V_NH_ts2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_ts2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhts", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_ts2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_ts2.Text = "" Then
            TxtTen_Nhts2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_ts2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ts2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nhts2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ts2.Text = ""
            TxtTen_Nhts2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_ts3"
    Private Sub V_NH_ts3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_ts3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhts", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_ts3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_ts3.Text = "" Then
            TxtTen_Nhts3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_ts3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ts3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nhts3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ts3.Text = ""
            TxtTen_Nhts3.Text = ""
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
        TxtMa_phi.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
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
        TxtMa_Sp.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Sp", "DmSp", "1=1", "1=1")
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
#Region "Vali --- Ma_Ku"
    Private Sub V_Ma_Ku(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_Ku.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Ku", "DmKu", "1=1", "1=1")
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
#Region "Vali --- Ma_TTLN"
    Private Sub V_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTLN.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
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
        TxtMa_TTCP.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
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
#Region "Vali --- Ma_Bp"
    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bp.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
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
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
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
#Region "Vali --- Ma_CD"
    Private Sub V_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CD.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_CD", "DmCD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_CD.Text = "" Then
            TxtTen_CD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CD.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_CD.Text = DrReturn.Item("Ma_CD")
            TxtTen_CD.Text = DrReturn.Item("Ten_CD")
        Else
            TxtMa_CD.Text = ""
            TxtTen_CD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD1"
    Private Sub V_Ma_TD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Td1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD1", "DmTD1", "1=1", "1=1")
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
        TxtMa_Td2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
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
        TxtMa_Td3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
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
        TxtMa_Td4.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
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
        TxtMa_Td5.V_LookUp(Me.LAN, Me.Para, Me.sysvar, Me.AppConn, DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
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

#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_strParameterStore As String = CbbGroupByTH.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & If(ChkDetail_OK.Checked, CbbGroupByCT.SelectedValue.ToString.Trim, "")
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_ts.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_ts1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_ts2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_ts3.Text.Trim

        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Vv.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_HD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_phi.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Sp.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Txtma_Ku.Text.Trim

        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TTLN.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_TTCP.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Bp.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CD.Text.Trim

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
End Class
