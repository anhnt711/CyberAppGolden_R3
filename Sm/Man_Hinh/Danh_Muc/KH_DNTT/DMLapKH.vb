Public Class DMLapKH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMLapKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_LapKH.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_LapKH, TxtNh_LapKH1, TxtNh_LapKH2, TxtNh_LapKH3, TxtNh_LapKH4, TxtNh_LapKH5)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtNh_LapKH1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLapKH", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_LapKH1.Text.Trim + "')", CyberSmlib)
        If TxtNh_LapKH2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLapKH", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_LapKH2.Text.Trim + "')", CyberSmlib)
        If TxtNh_LapKH3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLapKH", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_LapKH3.Text.Trim + "')", CyberSmlib)
        If TxtNh_LapKH4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLapKH", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_LapKH4.Text.Trim + "')", CyberSmlib)
        If TxtNh_LapKH5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLapKH", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_LapKH5.Text.Trim + "')", CyberSmlib)
        If TxtTen_CT.Text.Trim = "" Then TxtTen_CT.Text = "" Else TxtTen_CT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_LapKH", "DmLapKH", "(Ma_LapKH = N'" + TxtMa_CT.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_LapKH.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_LapKH.KeyPress, AddressOf TxtCodeError_KeyPress
        '--LapKH1
        RemoveHandler TxtNh_LapKH1.CyberValiting, AddressOf V_NH_LapKH1
        RemoveHandler TxtNh_LapKH1.CyberLeave, AddressOf L_NH_LapKH1
        AddHandler TxtNh_LapKH1.CyberValiting, AddressOf V_NH_LapKH1
        AddHandler TxtNh_LapKH1.CyberLeave, AddressOf L_NH_LapKH1
        '--LapKH2
        RemoveHandler TxtNh_LapKH2.CyberValiting, AddressOf V_NH_LapKH2
        RemoveHandler TxtNh_LapKH2.CyberLeave, AddressOf L_NH_LapKH2
        AddHandler TxtNh_LapKH2.CyberValiting, AddressOf V_NH_LapKH2
        AddHandler TxtNh_LapKH2.CyberLeave, AddressOf L_NH_LapKH2
        '--LapKH3
        RemoveHandler TxtNh_LapKH3.CyberValiting, AddressOf V_NH_LapKH3
        RemoveHandler TxtNh_LapKH3.CyberLeave, AddressOf L_NH_LapKH3
        AddHandler TxtNh_LapKH3.CyberValiting, AddressOf V_NH_LapKH3
        AddHandler TxtNh_LapKH3.CyberLeave, AddressOf L_NH_LapKH3
        '--LapKH4
        RemoveHandler TxtNh_LapKH4.CyberValiting, AddressOf V_NH_LapKH4
        RemoveHandler TxtNh_LapKH4.CyberLeave, AddressOf L_NH_LapKH4
        AddHandler TxtNh_LapKH4.CyberValiting, AddressOf V_NH_LapKH4
        AddHandler TxtNh_LapKH4.CyberLeave, AddressOf L_NH_LapKH4
        '--LapKH5
        RemoveHandler TxtNh_LapKH5.CyberValiting, AddressOf V_NH_LapKH5
        RemoveHandler TxtNh_LapKH5.CyberLeave, AddressOf L_NH_LapKH5
        AddHandler TxtNh_LapKH5.CyberValiting, AddressOf V_NH_LapKH5
        AddHandler TxtNh_LapKH5.CyberLeave, AddressOf L_NH_LapKH5

        '--TK
        RemoveHandler TxtMa_CT.CyberValiting, AddressOf V_Ma_LapKH
        RemoveHandler TxtMa_CT.CyberLeave, AddressOf L_Ma_LapKH
        AddHandler TxtMa_CT.CyberValiting, AddressOf V_Ma_LapKH
        AddHandler TxtMa_CT.CyberLeave, AddressOf L_Ma_LapKH
        '--Tk_NO
        RemoveHandler TxtTk_NO.CyberValiting, AddressOf V_TK_NO
        RemoveHandler TxtTk_NO.CyberLeave, AddressOf L_TK_NO
        AddHandler TxtTk_NO.CyberValiting, AddressOf V_TK_NO
        AddHandler TxtTk_NO.CyberLeave, AddressOf L_TK_NO
        '--Tk_Co
        RemoveHandler TxtTk_Co.CyberValiting, AddressOf V_TK_Co
        RemoveHandler TxtTk_Co.CyberLeave, AddressOf L_TK_Co
        AddHandler TxtTk_Co.CyberValiting, AddressOf V_TK_Co
        AddHandler TxtTk_Co.CyberLeave, AddressOf L_TK_Co
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
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_LapKH1"
    Private Sub V_NH_LapKH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LapKH1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLapKH", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_LapKH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LapKH1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LapKH1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LapKH1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LapKH1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_LapKH2"
    Private Sub V_NH_LapKH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LapKH2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLapKH", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_LapKH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LapKH2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LapKH2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LapKH2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LapKH2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_LapKH3"
    Private Sub V_NH_LapKH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LapKH3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLapKH", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_LapKH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LapKH3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LapKH3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LapKH3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LapKH3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_LapKH4"
    Private Sub V_NH_LapKH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LapKH4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLapKH", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_LapKH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LapKH4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LapKH4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LapKH4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LapKH4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_LapKH5"
    Private Sub V_NH_LapKH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LapKH5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLapKH", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_LapKH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LapKH5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LapKH5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LapKH5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LapKH5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_CT"
    Private Sub V_Ma_LapKH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_CT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_CT", "Dmct", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_LapKH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_CT.Text = "" Then
            TxtTen_CT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CT.Text = DrReturn.Item("Ma_CT")
            TxtTen_CT.Text = DrReturn.Item("Ten_CT")
        Else
            TxtMa_CT.Text = ""
            TxtTen_CT.Text = ""
        End If
    End Sub
#End Region
    Dim M_DsLookup As DataSet
#Region "Vali --- TK_NO"
    Private Sub V_TK_NO(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_NO.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "TK0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_TK_NO(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtTk_NO.Text = "" Then
            Txtten_Tk_NO.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_NO.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_NO.Text = DrReturn.Item("TK0")
            Txtten_Tk_NO.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTk_NO.Text = ""
            Txtten_Tk_NO.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TK_Co"
    Private Sub V_TK_Co(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_Co.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "TK0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_TK_Co(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtTk_Co.Text = "" Then
            TxtTen_Tk_Co.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Co.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Co.Text = DrReturn.Item("TK0")
            TxtTen_Tk_Co.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTk_Co.Text = ""
            TxtTen_Tk_Co.Text = ""
        End If
    End Sub
#End Region

#Region "Vali --- Ma_Vv"
    Private Sub V_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vv.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_Vv", "DmVv", "1=1", "1=1")
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
        TxtMa_HD.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
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
        TxtMa_phi.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
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
        TxtMa_Sp.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_Sp", "DmSp", "1=1", "1=1")
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
        TxtMa_TTLN.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
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
        TxtMa_TTCP.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
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
        Txtma_Ku.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_Ku", "DmKu", "1=1", "1=1")
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
#Region "Vali --- Ma_Bp"
    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bp.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
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
        TxtMa_Hs.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
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
        TxtMa_Td1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_TD1", "DmTD1", "1=1", "1=1")
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
        TxtMa_Td2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
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
        TxtMa_Td3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
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
        TxtMa_Td4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
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
        TxtMa_Td5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, M_DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
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
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_LapKH.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
