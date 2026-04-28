Public Class CDCTCC
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub CDHS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'V_FillCombox()
        
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_Cc.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtNgay_Ct.Value = Now.Date
        txtNgay_Pb.Value = Now.Date
        'If TxtMa_Dvcs.Text.Trim = "" Then TxtTen_Dvcs.Text = "" Else TxtTen_Dvcs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Dvcs", "DmDvcs", "(Ma_Dvcs = N'" + TxtMa_Dvcs.Text.Trim + "')", CyberSmlib)
        TxtTen_Tk_CP.Text = CyberSmodb.SQLGetvalue(Appconn, "TEN_TK", "DMTK", "(Tk = N'" + TxtTK_CP.Text.Trim + "')", CyberSmlib)
        TxtTen_NX.Text = CyberSmodb.SQLGetvalue(Appconn, "TEN_TK", "DMTK", "(Tk = N'" + TxtMa_Nx.Text.Trim + "')", CyberSmlib)

        TxtTen_CC.Text = CyberSmodb.SQLGetvalue(Appconn, "TEN_CC", "DMCC", "(MA_CC = N'" + TxtMa_Cc.Text.Trim + "')", CyberSmlib)
        'If TxtMa_kho.Text.Trim = "" Then TxtTen_kho.Text = "" Else TxtTen_kho.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_kho.Text.Trim + "')", CyberSmLib)
        If TxtMa_Vv.Text.Trim = "" Then TxtTen_vv.Text = "" Else TxtTen_vv.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Vv", "DmVv", "(Ma_Vv = N'" + TxtMa_Vv.Text.Trim + "')", CyberSmlib)
        TxtTen_phi.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_phi", "DmPHI", "(Ma_phi = N'" + TxtMa_phi.Text.Trim + "')", CyberSmlib)
        TxtTen_HD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_HD", "DmHD", "(Ma_HD = N'" + TxtMa_hd.Text.Trim + "')", CyberSmlib)
        TxtTen_Sp.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Sp", "DmSP", "(Ma_sp = N'" + TxtMa_sp.Text.Trim + "')", CyberSmlib)

        If TxtMa_TTLN.Text.Trim = "" Then TxtTen_TTLN.Text = "" Else TxtTen_TTLN.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TTLN", "DmTTLN", "(Ma_TTLN = N'" + TxtMa_TTLN.Text.Trim + "')", CyberSmlib)
        If TxtMa_TTCP.Text.Trim = "" Then TxtTen_TTCP.Text = "" Else TxtTen_TTCP.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TTCP", "DmTTCP", "(Ma_TTCP = N'" + TxtMa_TTCP.Text.Trim + "')", CyberSmlib)
        TxtTen_CD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_CD", "DmCD", "(Ma_CD = N'" + TxtMa_CD.Text.Trim + "')", CyberSmlib)
        TxtTen_Ku.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Ku", "Dmku", "(Ma_Ku = N'" + TxtMa_Ku.Text.Trim + "')", CyberSmlib)
        TxtTen_Bp.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Bp", "DmBp", "(Ma_Bp = N'" + TxtMa_bp.Text.Trim + "')", CyberSmlib)
        TxtTen_HS.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_HS", "DmHs", "(Ma_HS = N'" + TxtMa_HS.Text.Trim + "')", CyberSmlib)

        If TxtMa_TD1.Text.Trim = "" Then TxtTen_TD1.Text = "" Else TxtTen_TD1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TD1", "DmTD1", "(Ma_TD1 = N'" + TxtMa_TD1.Text.Trim + "')", CyberSmlib)
        If TxtMa_TD2.Text.Trim = "" Then TxtTen_TD2.Text = "" Else TxtTen_TD2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TD2", "DmTD2", "(Ma_TD2 = N'" + TxtMa_TD2.Text.Trim + "')", CyberSmlib)
        If TxtMa_TD3.Text.Trim = "" Then TxtTen_TD3.Text = "" Else TxtTen_TD3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TD3", "DmTD3", "(Ma_TD3 = N'" + TxtMa_TD3.Text.Trim + "')", CyberSmlib)
        If TxtMa_TD4.Text.Trim = "" Then TxtTen_TD4.Text = "" Else TxtTen_TD4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TD4", "DmTD4", "(Ma_TD4 = N'" + TxtMa_TD4.Text.Trim + "')", CyberSmlib)
        If TxtMa_TD5.Text.Trim = "" Then TxtTen_TD5.Text = "" Else TxtTen_TD5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TD5", "DmTD5", "(Ma_TD5 = N'" + TxtMa_TD5.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Private Sub V_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTien.Double = TxtTien_NT.Double
        If TxtSo_Ky_Pb.Double <> 0 Then
            TxtGt_Pb_Ky.Double = CyberSupport.V_Round(TxtTien_NT.Double / TxtSo_Ky_Pb.Double, 0)
        End If
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '---Tien_NT
        AddHandler TxtTien.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtTien_NT.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtSo_Ky_Pb.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtGt_Pb_Ky.Leave, AddressOf V_Tinh_Toan
        '--Ma_Nx
        AddHandler TxtMa_Nx.CyberValiting, AddressOf V_MA_NX
        AddHandler TxtMa_Nx.CyberLeave, AddressOf L_MA_NX

        '--Tk_CP
        AddHandler TxtTK_CP.CyberValiting, AddressOf V_Tk_CP
        AddHandler TxtTK_CP.CyberLeave, AddressOf L_Tk_CP

        '--Ma_CC
        AddHandler TxtMa_Cc.CyberValiting, AddressOf V_MA_CC
        AddHandler TxtMa_Cc.CyberLeave, AddressOf L_MA_CC
        '--Ma_kho

        '--Ma_Vv
        AddHandler TxtMa_Vv.CyberValiting, AddressOf V_MA_VV
        AddHandler TxtMa_Vv.CyberLeave, AddressOf L_MA_VV
        '--Ma_Phi
        AddHandler TxtMa_phi.CyberValiting, AddressOf V_MA_Phi
        AddHandler TxtMa_phi.CyberLeave, AddressOf L_MA_Phi
        '--Ma_HD
        AddHandler TxtMa_hd.CyberValiting, AddressOf V_MA_HD
        AddHandler TxtMa_hd.CyberLeave, AddressOf L_MA_HD
        '--Ma_SP
        AddHandler TxtMa_sp.CyberValiting, AddressOf V_MA_SP
        AddHandler TxtMa_sp.CyberLeave, AddressOf L_MA_SP
        '--Ma_TTLN
        AddHandler TxtMa_TTLN.CyberValiting, AddressOf V_MA_TTLN
        AddHandler TxtMa_TTLN.CyberLeave, AddressOf L_MA_TTLN
        '--Ma_TTCP
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_MA_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_MA_TTCP
        '--Ma_CD
        AddHandler TxtMa_CD.CyberValiting, AddressOf V_MA_CD
        AddHandler TxtMa_CD.CyberLeave, AddressOf L_MA_CD
        '--Ma_KU
        AddHandler TxtMa_Ku.CyberValiting, AddressOf V_MA_KU
        AddHandler TxtMa_Ku.CyberLeave, AddressOf L_MA_KU
        '--Ma_BP
        AddHandler TxtMa_bp.CyberValiting, AddressOf V_MA_Bp
        AddHandler TxtMa_bp.CyberLeave, AddressOf L_MA_Bp
        '--Ma_HS
        AddHandler TxtMa_HS.CyberValiting, AddressOf V_MA_Hs
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_MA_Hs

        '--Ma_TD1
        AddHandler TxtMa_TD1.CyberValiting, AddressOf V_MA_TD1
        AddHandler TxtMa_TD1.CyberLeave, AddressOf L_MA_TD1

        '--Ma_TD2
        AddHandler TxtMa_TD2.CyberValiting, AddressOf V_MA_TD2
        AddHandler TxtMa_TD2.CyberLeave, AddressOf L_MA_TD2

        '--Ma_TD3
        AddHandler TxtMa_TD3.CyberValiting, AddressOf V_MA_TD3
        AddHandler TxtMa_TD3.CyberLeave, AddressOf L_MA_TD3

        '--Ma_TD4
        AddHandler TxtMa_TD4.CyberValiting, AddressOf V_MA_TD4
        AddHandler TxtMa_TD4.CyberLeave, AddressOf L_MA_TD4
        '--Ma_TD5
        AddHandler TxtMa_TD5.CyberValiting, AddressOf V_MA_TD5
        AddHandler TxtMa_TD5.CyberLeave, AddressOf L_MA_TD5
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- MA_NX"
    Private Sub V_Ma_Nx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Nx.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DmTK", "1=1", "1=1")
    End Sub
    Private Sub L_MA_NX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Nx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Nx.Text = DrReturn.Item("Tk")
            TxtTen_NX.Text = DrReturn.Item("Ten_TK")
        Else
            TxtMa_Nx.Text = ""
            TxtTen_NX.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_CP"
    Private Sub V_Tk_CP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTK_CP.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DmTK", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_CP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTK_CP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK_CP.Text = DrReturn.Item("Tk")
            TxtTen_Tk_CP.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTK_CP.Text = ""
            TxtTen_Tk_CP.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- CC"
    Private Sub V_MA_CC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Cc", "DmCc", "1=1", "1=1")
    End Sub
    Private Sub L_MA_CC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If TxtMa_Cc.Text = "" Then
            TxtTen_CC.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtMa_Cc.Text = DrReturn.Item("MA_CC")
            TxtTen_CC.Text = DrReturn.Item("Ten_CC")

        Else
            TxtMa_Cc.Text = ""
            TxtTen_CC.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- VV"
    Private Sub V_MA_VV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Vv.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_VV", "DmVV", "1=1", "1=1")
    End Sub
    Private Sub L_MA_VV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Vv.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vv.Text = DrReturn.Item("Ma_Vv")
            TxtTen_vv.Text = DrReturn.Item("Ten_Vv")
        Else
            TxtMa_Vv.Text = ""
            TxtTen_vv.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Phi"
    Private Sub V_MA_Phi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_Phi", "Dmphi", "1=1", "1=1")
    End Sub
    Private Sub L_MA_Phi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If TxtMa_phi.Text = "" Then
            TxtTen_phi.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtMa_phi.Text = DrReturn.Item("Ma_Phi")
            TxtTen_phi.Text = DrReturn.Item("Ten_Phi")
        Else
            TxtMa_phi.Text = ""
            TxtTen_phi.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- HD"
    Private Sub V_MA_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_HD", "Dmhd", "1=1", "1=1")
    End Sub
    Private Sub L_MA_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_hd.Text = DrReturn.Item("Ma_Hd")
            TxtTen_HD.Text = DrReturn.Item("Ten_Hd")
        Else
            TxtMa_hd.Text = ""
            TxtTen_HD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- SP"
    Private Sub V_MA_SP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_SP", "Dmsp", "1=1", "1=1")
    End Sub
    Private Sub L_MA_SP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_sp.Text = DrReturn.Item("Ma_SP")
            TxtTen_Sp.Text = DrReturn.Item("Ten_SP")
        Else
            TxtMa_sp.Text = ""
            TxtTen_Sp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali ---KU"
    Private Sub V_MA_KU(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_Ku", "DmKu", "1=1", "1=1")
    End Sub
    Private Sub L_MA_KU(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Ku.Text = DrReturn.Item("Ma_KU")
            TxtTen_Ku.Text = DrReturn.Item("Ten_Ku")
        Else
            TxtMa_Ku.Text = ""
            TxtTen_Ku.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TTLN"
    Private Sub V_MA_TTLN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_TTLN", "DmTTLN", "1=1", "1=1")
    End Sub
    Private Sub L_MA_TTLN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TTLN.Text = DrReturn.Item("Ma_TTLN")
            TxtTen_TTLN.Text = DrReturn.Item("Ten_TTLN")
        Else
            TxtMa_TTLN.Text = ""
            TxtTen_TTLN.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TTCP"
    Private Sub V_MA_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_MA_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP.Text = ""
            TxtTen_TTCP.Text = ""
        End If
    End Sub
#End Region
#Region "Vali ---Bp"
    Private Sub V_MA_Bp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_Bp", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_MA_Bp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_bp.Text = DrReturn.Item("MA_Bp")
            TxtTen_Bp.Text = DrReturn.Item("TEN_Bp")
        Else
            TxtMa_bp.Text = ""
            TxtTen_Bp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Hs"
    Private Sub V_MA_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_HS.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_MA_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_HS.GetRowsSelectData(True)
        If TxtMa_HS.Text = "" Then
            TxtTen_HS.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtMa_HS.Text = DrReturn.Item("Ma_Hs")
            TxtTen_HS.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_HS.Text = ""
            TxtTen_HS.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- CD"
    Private Sub V_MA_CD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_CD", "DmCD", "1=1", "1=1")
    End Sub
    Private Sub L_MA_CD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CD.Text = DrReturn.Item("Ma_CD")
            TxtTen_CD.Text = DrReturn.Item("Ten_CD")
        Else
            TxtMa_CD.Text = ""
            TxtTen_CD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TD1"
    Private Sub V_MA_TD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_TD1", "DmTd1", "1=1", "1=1")
    End Sub
    Private Sub L_MA_TD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TD1.Text = DrReturn.Item("Ma_td1")
            TxtTen_TD1.Text = DrReturn.Item("Ten_td1")
        Else
            TxtMa_TD1.Text = ""
            TxtTen_TD1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TD2"
    Private Sub V_MA_TD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_TD2", "Dmtd2", "1=1", "1=1")
    End Sub
    Private Sub L_MA_TD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TD2.Text = DrReturn.Item("Ma_td2")
            TxtTen_TD2.Text = DrReturn.Item("Ten_Td2")
        Else
            TxtMa_TD2.Text = ""
            TxtTen_TD2.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- TD3"
    Private Sub V_MA_TD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_TD3", "Dmtd3", "1=1", "1=1")
    End Sub
    Private Sub L_MA_TD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TD3.Text = DrReturn.Item("Ma_TD3")
            TxtTen_TD3.Text = DrReturn.Item("Ten_TD3")
        Else
            TxtMa_TD3.Text = ""
            TxtTen_TD3.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- TD4"
    Private Sub V_MA_TD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_TD4", "Dmtd4", "1=1", "1=1")
    End Sub
    Private Sub L_MA_TD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TD4.Text = DrReturn.Item("Ma_TD4")
            TxtTen_TD4.Text = DrReturn.Item("Ten_TD4")
        Else
            TxtMa_TD4.Text = ""
            TxtTen_TD4.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- TD5"
    Private Sub V_MA_TD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_TD5", "Dmtd5", "1=1", "1=1")
    End Sub
    Private Sub L_MA_TD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TD5.Text = DrReturn.Item("Ma_TD5")
            TxtTen_TD5.Text = DrReturn.Item("Ten_TD5")
        Else
            TxtMa_TD5.Text = ""
            TxtTen_TD5.Text = ""
        End If
    End Sub

#End Region
#End Region
#Region "Buuton"
    Private Sub GetRec()
        If Me.Mode = "S" And TxtStt_Rec.Text.Trim <> "" And TxtStt_Rec0.Text.Trim <> "" Then Exit Sub
        Dim strSQL = "SELECT MAX(Stt_Rec) as Stt_Rec,MAX(Stt_Rec0) as Stt_Rec0 FROM dbo.cdctcc WHERE Ma_Dvcs = N'" + M_Ma_Dvcs.Trim + "'"
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysExecute", strSQL & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec0 As String = ""
        CyberSmodb.SetNotNullTable(DsTmp.Tables(0))
        If DsTmp.Tables(0).Rows.Count > 0 Then
            _Stt_Rec = DsTmp.Tables(0).Rows(0).Item("Stt_Rec").ToString.Trim
            _Stt_Rec0 = DsTmp.Tables(0).Rows(0).Item("Stt_Rec0").ToString.Trim
        End If
        If _Stt_Rec0.Trim = "" Then _Stt_Rec0 = "0000"
        If Len(_Stt_Rec0.Trim) <> 4 Then _Stt_Rec0 = Strings.Right("0000" + _Stt_Rec0.Trim, 4)
        If _Stt_Rec.Trim = "" Then _Stt_Rec = "A" + Strings.Left(M_Ma_Dvcs.Trim + "_000000000000000000", 12)
        TxtStt_Rec.Text = _Stt_Rec
        Dim Stt As Decimal = CType(_Stt_Rec0, Decimal) + 1
        TxtStt_Rec0.Text = Strings.Right("0000" + Stt.ToString.Trim, 4)
    End Sub
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        GetRec()
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