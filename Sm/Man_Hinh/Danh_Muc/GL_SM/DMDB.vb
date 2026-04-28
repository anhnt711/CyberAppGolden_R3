Public Class DMDB
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMTD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_DB, TxtNh_DB1, TxtNh_DB2, TxtNh_DB3, TxtNh_DB4, TxtNh_DB5)
        TxtMa_DB.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtNh_DB1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhDB", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_DB1.Text.Trim + "')", CyberSmlib)
        If TxtNh_DB2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhDB", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_DB2.Text.Trim + "')", CyberSmlib)
        If TxtNh_DB3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhDB", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_DB3.Text.Trim + "')", CyberSmlib)
        If TxtNh_DB4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhDB", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_DB4.Text.Trim + "')", CyberSmlib)
        If TxtNh_DB5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhDB", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_DB5.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--DB1
        RemoveHandler TxtNh_DB1.CyberValiting, AddressOf V_Nh_Db1
        RemoveHandler TxtNh_DB1.CyberLeave, AddressOf L_Nh_Db1
        AddHandler TxtNh_DB1.CyberValiting, AddressOf V_Nh_Db1
        AddHandler TxtNh_DB1.CyberLeave, AddressOf L_Nh_Db1
        '--Db12
        RemoveHandler TxtNh_DB2.CyberValiting, AddressOf V_Nh_Db2
        RemoveHandler TxtNh_DB2.CyberLeave, AddressOf L_Nh_Db2
        AddHandler TxtNh_DB2.CyberValiting, AddressOf V_Nh_Db2
        AddHandler TxtNh_DB2.CyberLeave, AddressOf L_Nh_Db2
        '--Db13
        RemoveHandler TxtNh_DB3.CyberValiting, AddressOf V_Nh_Db3
        RemoveHandler TxtNh_DB3.CyberLeave, AddressOf L_Nh_Db3
        AddHandler TxtNh_DB3.CyberValiting, AddressOf V_Nh_Db3
        AddHandler TxtNh_DB3.CyberLeave, AddressOf L_Nh_Db3
        '--Db14
        RemoveHandler TxtNh_DB4.CyberValiting, AddressOf V_Nh_Db4
        RemoveHandler TxtNh_DB4.CyberLeave, AddressOf L_Nh_Db4
        AddHandler TxtNh_DB4.CyberValiting, AddressOf V_Nh_Db4
        AddHandler TxtNh_DB4.CyberLeave, AddressOf L_Nh_Db4
        '--Db15
        RemoveHandler TxtNh_DB5.CyberValiting, AddressOf V_Nh_Db5
        RemoveHandler TxtNh_DB5.CyberLeave, AddressOf L_Nh_Db5
        AddHandler TxtNh_DB5.CyberValiting, AddressOf V_Nh_Db5
        AddHandler TxtNh_DB5.CyberLeave, AddressOf L_Nh_Db5
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- nh_Db1"
    Private Sub V_Nh_Db1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_DB1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhDB", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Db1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_DB1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_DB1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_DB1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region

#Region "Vali ---   NH_Db2"
    Private Sub V_Nh_Db2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_DB2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhDB", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Db2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_DB2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_DB2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_DB2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_DB3"
    Private Sub V_Nh_Db3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_DB3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhDB", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Db3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_DB3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_DB3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_DB3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_DB4"
    Private Sub V_Nh_Db4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_DB4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhDB", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_Db4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_DB4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_DB4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_DB4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_DB5"
    Private Sub V_Nh_Db5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_DB5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhDB", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_Db5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_DB5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_DB5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_DB5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_DB.Text = _Value
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