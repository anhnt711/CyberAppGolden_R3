Public Class DMTTCP
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMTTCP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_TTCP, TxtNh_TTCP1, TxtNh_TTCP2, TxtNh_TTCP3, TxtNh_TTCP4, TxtNh_TTCP5)
        TxtMa_TTCP.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtNh_TTCP1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTCP", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_TTCP1.Text.Trim + "')", CyberSmlib)
        If TxtNh_TTCP2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTCP", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_TTCP2.Text.Trim + "')", CyberSmlib)
        If TxtNh_TTCP3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTCP", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_TTCP3.Text.Trim + "')", CyberSmlib)
        If TxtNh_TTCP4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTCP", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_TTCP4.Text.Trim + "')", CyberSmlib)
        If TxtNh_TTCP5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTCP", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_TTCP5.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_TTCP.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_TTCP.KeyPress, AddressOf TxtCodeError_KeyPress

        '--TTCP1
        RemoveHandler TxtNh_TTCP1.CyberValiting, AddressOf V_NH_TTCP1
        RemoveHandler TxtNh_TTCP1.CyberLeave, AddressOf L_NH_TTCP1

        AddHandler TxtNh_TTCP1.CyberValiting, AddressOf V_NH_TTCP1
        AddHandler TxtNh_TTCP1.CyberLeave, AddressOf L_NH_TTCP1

        '--TTCP2
        RemoveHandler TxtNh_TTCP2.CyberValiting, AddressOf V_NH_TTCP2
        RemoveHandler TxtNh_TTCP2.CyberLeave, AddressOf L_NH_TTCP2
        AddHandler TxtNh_TTCP2.CyberValiting, AddressOf V_NH_TTCP2
        AddHandler TxtNh_TTCP2.CyberLeave, AddressOf L_NH_TTCP2

        '--TTCP3
        RemoveHandler TxtNh_TTCP3.CyberValiting, AddressOf V_NH_TTCP3
        RemoveHandler TxtNh_TTCP3.CyberLeave, AddressOf L_NH_TTCP3
        AddHandler TxtNh_TTCP3.CyberValiting, AddressOf V_NH_TTCP3
        AddHandler TxtNh_TTCP3.CyberLeave, AddressOf L_NH_TTCP3
        '--TTCP4
        RemoveHandler TxtNh_TTCP4.CyberValiting, AddressOf V_NH_TTCP4
        RemoveHandler TxtNh_TTCP4.CyberLeave, AddressOf L_NH_TTCP4
        AddHandler TxtNh_TTCP4.CyberValiting, AddressOf V_NH_TTCP4
        AddHandler TxtNh_TTCP4.CyberLeave, AddressOf L_NH_TTCP4
        '--TTCP5
        RemoveHandler TxtNh_TTCP5.CyberValiting, AddressOf V_NH_TTCP5
        RemoveHandler TxtNh_TTCP5.CyberLeave, AddressOf L_NH_TTCP5
        AddHandler TxtNh_TTCP5.CyberValiting, AddressOf V_NH_TTCP5
        AddHandler TxtNh_TTCP5.CyberLeave, AddressOf L_NH_TTCP5

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_TTCP1"
    Private Sub V_NH_TTCP1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TTCP1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTTCP", "1=1", "Loai_Nh='1'")
    End Sub

    Private Sub L_NH_TTCP1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_TTCP1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TTCP1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TTCP1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_TTCP2"
    Private Sub V_NH_TTCP2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TTCP2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTTCP", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_TTCP2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_TTCP2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TTCP2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TTCP2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_TTCP3"
    Private Sub V_NH_TTCP3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TTCP3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTTCP", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_TTCP3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_TTCP3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TTCP3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TTCP3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_TTCP4"
    Private Sub V_NH_TTCP4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TTCP4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTTCP", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_TTCP4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_TTCP4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TTCP4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TTCP4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_TTCP5"
    Private Sub V_NH_TTCP5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TTCP5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTTCP", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_TTCP5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_TTCP5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TTCP5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TTCP5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_TTCP.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
