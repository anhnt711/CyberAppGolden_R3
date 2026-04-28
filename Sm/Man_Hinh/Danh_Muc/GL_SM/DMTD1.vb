Public Class DMTD1
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMTD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_TD1, TxtNh_TD1, TxtNh_TD2, TxtNh_TD3, TxtNh_TD4, TxtNh_TD5)
        TxtMa_TD1.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        
        If TxtNh_TD1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTD1", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_TD1.Text.Trim + "')", CyberSmlib)
        If TxtNh_TD2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTD1", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_TD2.Text.Trim + "')", CyberSmlib)
        If TxtNh_TD3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTD1", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_TD3.Text.Trim + "')", CyberSmlib)
        If TxtNh_TD4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTD1", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_TD4.Text.Trim + "')", CyberSmlib)
        If TxtNh_TD5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTD1", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_TD5.Text.Trim + "')", CyberSmlib)


        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--TD21
        RemoveHandler TxtNh_TD1.CyberValiting, AddressOf V_Nh_TD1
        RemoveHandler TxtNh_TD1.CyberLeave, AddressOf L_Nh_TD1
        AddHandler TxtNh_TD1.CyberValiting, AddressOf V_Nh_TD1
        AddHandler TxtNh_TD1.CyberLeave, AddressOf L_Nh_TD1
        '--TD22
        RemoveHandler TxtNh_TD2.CyberValiting, AddressOf V_Nh_TD2
        RemoveHandler TxtNh_TD2.CyberLeave, AddressOf L_Nh_TD2
        AddHandler TxtNh_TD2.CyberValiting, AddressOf V_Nh_TD2
        AddHandler TxtNh_TD2.CyberLeave, AddressOf L_Nh_TD2
        '--TD23
        RemoveHandler TxtNh_TD3.CyberValiting, AddressOf V_Nh_TD3
        RemoveHandler TxtNh_TD3.CyberLeave, AddressOf L_Nh_TD3
        AddHandler TxtNh_TD3.CyberValiting, AddressOf V_Nh_TD3
        AddHandler TxtNh_TD3.CyberLeave, AddressOf L_Nh_TD3
        '--TD24
        RemoveHandler TxtNh_TD4.CyberValiting, AddressOf V_Nh_TD4
        RemoveHandler TxtNh_TD4.CyberLeave, AddressOf L_Nh_TD4
        AddHandler TxtNh_TD4.CyberValiting, AddressOf V_Nh_TD4
        AddHandler TxtNh_TD4.CyberLeave, AddressOf L_Nh_TD4
        '--TD25
        RemoveHandler TxtNh_TD5.CyberValiting, AddressOf V_Nh_TD5
        RemoveHandler TxtNh_TD5.CyberLeave, AddressOf L_Nh_TD5
        AddHandler TxtNh_TD5.CyberValiting, AddressOf V_Nh_TD5
        AddHandler TxtNh_TD5.CyberLeave, AddressOf L_Nh_TD5
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_TD1"
    Private Sub V_Nh_TD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TD1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTD1", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_TD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_TD1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TD1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TD1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD2"
    Private Sub V_Nh_TD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TD2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTD1", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_TD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_TD2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TD2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TD2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD3"
    Private Sub V_Nh_TD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TD3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTD1", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_TD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_TD3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TD3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TD3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD4"
    Private Sub V_Nh_TD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TD4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTD1", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_TD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_TD4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TD4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TD4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD5"
    Private Sub V_Nh_TD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TD5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTD1", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_TD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_TD5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TD5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TD5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_TD1.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
