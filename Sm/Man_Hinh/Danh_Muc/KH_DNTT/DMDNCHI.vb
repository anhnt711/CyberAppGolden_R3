Public Class DMdnchi
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMdnchi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_dnchi.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_dnchi, TxtNh_dnchi1, TxtNh_dnchi2, TxtNh_dnchi3, TxtNh_dnchi4, TxtNh_dnchi5)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtNh_dnchi1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhdnchi", "(Loai_Nh = N'1' AND Ma_Nh = N'" + TxtNh_dnchi1.Text.Trim + "')", CyberSmlib)
        If TxtNh_dnchi2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhdnchi", "(Loai_Nh = N'2' AND Ma_Nh = N'" + TxtNh_dnchi2.Text.Trim + "')", CyberSmlib)
        If TxtNh_dnchi3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhdnchi", "(Loai_Nh = N'3' AND Ma_Nh = N'" + TxtNh_dnchi3.Text.Trim + "')", CyberSmlib)
        If TxtNh_dnchi4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhdnchi", "(Loai_Nh = N'4' AND Ma_Nh = N'" + TxtNh_dnchi4.Text.Trim + "')", CyberSmlib)
        If TxtNh_dnchi5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhdnchi", "(Loai_Nh = N'5' AND Ma_Nh = N'" + TxtNh_dnchi5.Text.Trim + "')", CyberSmlib)
        If TxtTk_No.Text.Trim = "" Then TxtTen_TK_No.Text = "" Else TxtTen_TK_No.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk", "DmTk", "(TK = N'" + TxtTk_No.Text.Trim + "')", CyberSmlib)
        If TxtTk_No.Text.Trim = "" Then TxtTen_TK_Co.Text = "" Else TxtTen_TK_Co.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk", "DmTk", "(TK = N'" + TxtTk_Co.Text.Trim + "')", CyberSmlib)
        If TxtMa_phi.Text.Trim = "" Then TxtTen_Phi.Text = "" Else TxtTen_Phi.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Phi", "DmPhi", "(Ma_Phi = N'" + TxtMa_phi.Text.Trim + "')", CyberSmlib)
        If TxtMa_TTCP.Text.Trim = "" Then TxtTen_TTCP.Text = "" Else TxtTen_TTCP.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TTCP", "DmTTCP", "(Ma_TTCP = N'" + TxtMa_TTCP.Text.Trim + "')", CyberSmlib)
        If TxtMa_TTLN.Text.Trim = "" Then TxtTen_TTLN.Text = "" Else TxtTen_TTLN.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TTLN", "DmTTLN", "(Ma_TTLN = N'" + TxtMa_TTLN.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_dnchi.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_dnchi.KeyPress, AddressOf TxtCodeError_KeyPress
        '--dnchi1
        RemoveHandler TxtNh_dnchi1.CyberValiting, AddressOf V_NH_dnchi1
        RemoveHandler TxtNh_dnchi1.CyberLeave, AddressOf L_NH_dnchi1
        AddHandler TxtNh_dnchi1.CyberValiting, AddressOf V_NH_dnchi1
        AddHandler TxtNh_dnchi1.CyberLeave, AddressOf L_NH_dnchi1
        '--dnchi2
        RemoveHandler TxtNh_dnchi2.CyberValiting, AddressOf V_NH_dnchi2
        RemoveHandler TxtNh_dnchi2.CyberLeave, AddressOf L_NH_dnchi2
        AddHandler TxtNh_dnchi2.CyberValiting, AddressOf V_NH_dnchi2
        AddHandler TxtNh_dnchi2.CyberLeave, AddressOf L_NH_dnchi2
        '--dnchi3
        RemoveHandler TxtNh_dnchi3.CyberValiting, AddressOf V_NH_dnchi3
        RemoveHandler TxtNh_dnchi3.CyberLeave, AddressOf L_NH_dnchi3
        AddHandler TxtNh_dnchi3.CyberValiting, AddressOf V_NH_dnchi3
        AddHandler TxtNh_dnchi3.CyberLeave, AddressOf L_NH_dnchi3
        '--dnchi4
        RemoveHandler TxtNh_dnchi4.CyberValiting, AddressOf V_NH_dnchi4
        RemoveHandler TxtNh_dnchi4.CyberLeave, AddressOf L_NH_dnchi4
        AddHandler TxtNh_dnchi4.CyberValiting, AddressOf V_NH_dnchi4
        AddHandler TxtNh_dnchi4.CyberLeave, AddressOf L_NH_dnchi4
        '--dnchi5
        RemoveHandler TxtNh_dnchi5.CyberValiting, AddressOf V_NH_dnchi5
        RemoveHandler TxtNh_dnchi5.CyberLeave, AddressOf L_NH_dnchi5
        AddHandler TxtNh_dnchi5.CyberValiting, AddressOf V_NH_dnchi5
        AddHandler TxtNh_dnchi5.CyberLeave, AddressOf L_NH_dnchi5

        '--TK
        RemoveHandler TxtTk_No.CyberValiting, AddressOf V_TK_No
        RemoveHandler TxtTk_No.CyberLeave, AddressOf L_TK_No
        AddHandler TxtTk_No.CyberValiting, AddressOf V_TK_No
        AddHandler TxtTk_No.CyberLeave, AddressOf L_TK_No

        '--TK
        RemoveHandler TxtTk_Co.CyberValiting, AddressOf V_TK_Co
        RemoveHandler TxtTk_Co.CyberLeave, AddressOf L_TK_Co
        AddHandler TxtTk_Co.CyberValiting, AddressOf V_TK_Co
        AddHandler TxtTk_Co.CyberLeave, AddressOf L_TK_Co

        '--Ma_Phi
        RemoveHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_Phi
        RemoveHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_Phi
        AddHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_Phi
        AddHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_Phi

        '--Ma_TTCP
        RemoveHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        RemoveHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP

        '--Ma_TTLN
        RemoveHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        RemoveHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN


    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_dnchi1"
    Private Sub V_NH_dnchi1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_dnchi1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhdnchi", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_dnchi1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_dnchi1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_dnchi1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_dnchi1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_dnchi1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_dnchi2"
    Private Sub V_NH_dnchi2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_dnchi2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhdnchi", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_dnchi2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_dnchi2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_dnchi2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_dnchi2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_dnchi2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_dnchi3"
    Private Sub V_NH_dnchi3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_dnchi3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhdnchi", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_dnchi3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_dnchi3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_dnchi3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_dnchi3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_dnchi3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_dnchi4"
    Private Sub V_NH_dnchi4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_dnchi4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhdnchi", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_dnchi4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_dnchi4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_dnchi4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_dnchi4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_dnchi4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_dnchi5"
    Private Sub V_NH_dnchi5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_dnchi5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhdnchi", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_dnchi5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_dnchi5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_dnchi5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_dnchi5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_dnchi5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TK_No"
    Private Sub V_TK_No(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_No.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DmTK", "1=1", "1=1")
    End Sub
    Private Sub L_TK_No(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_No.Text = "" Then
            TxtTen_TK_No.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_No.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_No.Text = DrReturn.Item("TK")
            TxtTen_TK_No.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_No.Text = ""
            TxtTen_TK_No.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TK_Co"
    Private Sub V_TK_Co(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Co.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DmTK", "1=1", "1=1")
    End Sub
    Private Sub L_TK_Co(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_Co.Text = "" Then
            TxtTen_TK_Co.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Co.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Co.Text = DrReturn.Item("TK")
            TxtTen_TK_Co.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_Co.Text = ""
            TxtTen_TK_Co.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Phi"
    Private Sub V_Ma_Phi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_phi.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Phi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_phi.Text = "" Then
            TxtTen_Phi.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_phi.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_phi.Text = DrReturn.Item("Ma_Phi")
            TxtTen_Phi.Text = DrReturn.Item("Ten_Phi")
        Else
            TxtMa_phi.Text = ""
            TxtTen_Phi.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTCP"
    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TTCP.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TTCP.Text = "" Then
            TxtTen_TTCP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTCP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP.Text = ""
            TxtTen_TTCP.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTLN"
    Private Sub V_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TTLN.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TTLN.Text = "" Then
            TxtTen_TTLN.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTLN.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TTLN.Text = DrReturn.Item("Ma_TTLN")
            TxtTen_TTLN.Text = DrReturn.Item("Ten_TTLN")
        Else
            TxtMa_TTLN.Text = ""
            TxtTen_TTLN.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_dnchi.Text = _Value
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
