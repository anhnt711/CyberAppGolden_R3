Public Class GLCTPK4_F31
    Public Property Drv() As DataRowView
        Get
            Drv = M_Drv
        End Get
        Set(ByVal Value As DataRowView)
            M_Drv = Value
        End Set
    End Property
    Dim M_Drv As DataRowView
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable
    Private Sub GLCTPK4_F31_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_Addhander()

        Me.Text = If(Me.Lan = "V", "Điều chỉnh hệ số phân bổ", "Adjust attribution factor")
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        CyberSmodb.SetValueTObj(Me, Drv)
        txtten_kh.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kh", "DmKh", "(Ma_Kh= N'" + Txtma_kh.Text.Trim + "')", CyberSmlib)
        TxtTen_Vv.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_VV", "DmVV", "(Ma_VV= N'" + TxtMa_Vv.Text.Trim + "')", CyberSmlib)
        TxtTen_HD.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HD", "DmHD", "(Ma_HD= N'" + TxtMa_HD.Text.Trim + "')", CyberSmlib)
        TxtTen_Phi.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Phi", "DmPhi", "(Ma_Phi= N'" + TxtMa_phi.Text.Trim + "')", CyberSmlib)
        TxtTen_Sp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Sp", "DmSp", "(Ma_Sp= N'" + TxtMa_Sp.Text.Trim + "')", CyberSmlib)
        TxtTen_ku.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Ku", "DmKu", "(Ma_Ku= N'" + Txtma_Ku.Text.Trim + "')", CyberSmlib)

        TxtTen_TTLN.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTLN", "DmTTLN", "(Ma_TTLN= N'" + TxtMa_TTLN.Text.Trim + "')", CyberSmlib)
        TxtTen_TTCP.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTCP", "DmTTCP", "(Ma_TTCP= N'" + TxtMa_TTCP.Text.Trim + "')", CyberSmlib)
        TxtTen_Bp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_BP", "DmBP", "(Ma_BP= N'" + TxtMa_Bp.Text.Trim + "')", CyberSmlib)
        TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "DmHS", "(Ma_HS= N'" + TxtMa_Hs.Text.Trim + "')", CyberSmlib)
        TxtTen_CD.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_CD", "DmCD", "(Ma_CD= N'" + TxtMa_CD.Text.Trim + "')", CyberSmlib)

        TxtTen_Td1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD1", "DmTD1", "(Ma_TD1= N'" + TxtMa_Td1.Text.Trim + "')", CyberSmlib)
        TxtTen_Td2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD2", "DmTD2", "(Ma_TD2= N'" + TxtMa_Td2.Text.Trim + "')", CyberSmlib)
        TxtTen_Td3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD3", "DmTD3", "(Ma_TD3= N'" + TxtMa_Td3.Text.Trim + "')", CyberSmlib)
        TxtTen_Td4.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD4", "DmTD4", "(Ma_TD4= N'" + TxtMa_Td4.Text.Trim + "')", CyberSmlib)
        TxtTen_Td5.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD5", "DmTD5", "(Ma_TD5= N'" + TxtMa_Td5.Text.Trim + "')", CyberSmlib)

    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim strUpdate As String = TxtHeso01.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & TxtHeso02.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & TxtHeso03.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & TxtHeso04.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & TxtHeso05.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & TxtHeso06.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & TxtHeso07.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & TxtHeso08.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & TxtHeso09.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & TxtHeso10.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & TxtHeso11.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & TxtHeso12.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & Txtma_kh.Text.Trim
        strUpdate = strUpdate & "#" & TxtMa_Vv.Text.Trim & "#" & TxtMa_HD.Text.Trim & "#" & TxtMa_phi.Text.Trim & "#" & TxtMa_Sp.Text.Trim & "#" & Txtma_Ku.Text.Trim
        strUpdate = strUpdate & "#" & TxtMa_TTLN.Text.Trim & "#" & TxtMa_TTCP.Text.Trim & "#" & TxtMa_Bp.Text.Trim & "#" & TxtMa_Hs.Text.Trim & "#" & TxtMa_CD.Text.Trim
        strUpdate = strUpdate & "#" & TxtMa_Td1.Text.Trim & "#" & TxtMa_Td2.Text.Trim & "#" & TxtMa_Td3.Text.Trim & "#" & TxtMa_Td4.Text.Trim & "#" & TxtMa_Td5.Text.Trim
        strUpdate = strUpdate & "#" & Drv.Item("Stt_Rec").ToString.Trim & "#" & Drv.Item("Stt_Rec0").ToString.Trim & "#" & Me.Nam.ToString.Trim
        strUpdate = strUpdate & "#" & M_Ma_Dvcs & "#" & M_User_Name
        Dim DsUpdate As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GLCTPK4UpdateDmpb1", strUpdate)

        Dim _DvReturn As DataView
        _DvReturn = New DataView(DsUpdate.Tables(1).Copy)
        Drv = _DvReturn.Item(0)
        Me.Tag = ""
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtOK.Click, AddressOf V_Nhan
        '--ma khach hang
        AddHandler Txtma_kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler Txtma_kh.CyberLeave, AddressOf L_Ma_KH

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
#Region "Valid"

#Region "Valid --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_kh.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = Txtma_kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_kh.Text = DrReturn.Item("Ma_kh")
            txtten_kh.Text = DrReturn.Item("Ten_Kh")
        Else
            Txtma_kh.Text = ""
            txtten_kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Vv"
    Private Sub V_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vv.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Vv", "DmVv", "1=1", "1=1")
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
        TxtMa_HD.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
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
#Region "Vali --- Ma_CD"
    Private Sub V_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CD.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_CD", "DmCD", "1=1", "1=1")
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
        TxtMa_Td1.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.AppConn, DsLookup, "Ma_TD1", "DmTD1", "1=1", "1=1")
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
        TxtMa_Td2.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.AppConn, DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
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
        TxtMa_Td3.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.AppConn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
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
        TxtMa_Td4.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.AppConn, DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
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
        TxtMa_Td5.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.AppConn, DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
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
End Class
