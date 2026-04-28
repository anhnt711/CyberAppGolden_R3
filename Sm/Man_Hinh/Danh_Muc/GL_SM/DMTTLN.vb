Public Class DMTTLN
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMTTLN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_TTLN.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_TTLN, TxtNh_TTLN1, TxtNh_TTLN2, TxtNh_TTLN3, TxtNh_TTLN4, TxtNh_TTLN5)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTLN", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_TTLN1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTLN", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_TTLN2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTLN", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_TTLN3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTLN", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_TTLN4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTLN", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_TTLN5.Text.Trim + "')", CyberSmlib)

        If TxtNh_TTLN1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTLN", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_TTLN1.Text.Trim + "')", CyberSmlib)
        If TxtNh_TTLN2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTLN", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_TTLN2.Text.Trim + "')", CyberSmlib)
        If TxtNh_TTLN3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTLN", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_TTLN3.Text.Trim + "')", CyberSmlib)
        If TxtNh_TTLN4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTLN", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_TTLN4.Text.Trim + "')", CyberSmlib)
        If TxtNh_TTLN5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTTLN", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_TTLN5.Text.Trim + "')", CyberSmlib)

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_TTLN.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_TTLN.KeyPress, AddressOf TxtCodeError_KeyPress


        '--TTLN1
        RemoveHandler TxtNh_TTLN1.CyberValiting, AddressOf V_NH_TTLN1
        RemoveHandler TxtNh_TTLN1.CyberLeave, AddressOf L_NH_TTLN1
        AddHandler TxtNh_TTLN1.CyberValiting, AddressOf V_NH_TTLN1
        AddHandler TxtNh_TTLN1.CyberLeave, AddressOf L_NH_TTLN1
        '--TTLN2
        RemoveHandler TxtNh_TTLN2.CyberValiting, AddressOf V_NH_TTLN2
        RemoveHandler TxtNh_TTLN2.CyberLeave, AddressOf L_NH_TTLN2
        AddHandler TxtNh_TTLN2.CyberValiting, AddressOf V_NH_TTLN2
        AddHandler TxtNh_TTLN2.CyberLeave, AddressOf L_NH_TTLN2
        '--TTLN3
        RemoveHandler TxtNh_TTLN3.CyberValiting, AddressOf V_NH_TTLN3
        RemoveHandler TxtNh_TTLN3.CyberLeave, AddressOf L_NH_TTLN3
        AddHandler TxtNh_TTLN3.CyberValiting, AddressOf V_NH_TTLN3
        AddHandler TxtNh_TTLN3.CyberLeave, AddressOf L_NH_TTLN3
        '--TTLN4
        RemoveHandler TxtNh_TTLN4.CyberValiting, AddressOf V_NH_TTLN4
        RemoveHandler TxtNh_TTLN4.CyberLeave, AddressOf L_NH_TTLN4
        AddHandler TxtNh_TTLN4.CyberValiting, AddressOf V_NH_TTLN4
        AddHandler TxtNh_TTLN4.CyberLeave, AddressOf L_NH_TTLN4
        '--TTLN5
        RemoveHandler TxtNh_TTLN5.CyberValiting, AddressOf V_NH_TTLN5
        RemoveHandler TxtNh_TTLN5.CyberLeave, AddressOf L_NH_TTLN5
        AddHandler TxtNh_TTLN5.CyberValiting, AddressOf V_NH_TTLN5
        AddHandler TxtNh_TTLN5.CyberLeave, AddressOf L_NH_TTLN5
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_TTLN1"
    Private Sub V_NH_TTLN1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TTLN1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTTLN", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_TTLN1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TTLN1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TTLN1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TTLN1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TTLN1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_TTLN2"
    Private Sub V_NH_TTLN2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TTLN2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTTLN", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_TTLN2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TTLN2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TTLN2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TTLN2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TTLN2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_TTLN3"
    Private Sub V_NH_TTLN3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TTLN3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTTLN", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_TTLN3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TTLN3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TTLN3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TTLN3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TTLN3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_TTLN4"
    Private Sub V_NH_TTLN4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TTLN4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTTLN", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_TTLN4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TTLN4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TTLN4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TTLN4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TTLN4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_TTLN5"
    Private Sub V_NH_TTLN5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TTLN5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTTLN", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_TTLN5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TTLN5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TTLN5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TTLN5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TTLN5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
      Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_TTLN.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
