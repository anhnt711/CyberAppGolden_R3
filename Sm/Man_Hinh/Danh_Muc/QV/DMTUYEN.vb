Public Class DMTUYEN
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMTD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_Tuyen, TxtNh_Tuyen1, TxtNh_Tuyen2, TxtNh_Tuyen3, TxtNh_Tuyen4, TxtNh_Tuyen5)
        TxtMa_Tuyen.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTUYEN", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Tuyen1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTUYEN", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Tuyen2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTUYEN", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Tuyen3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTUYEN", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Tuyen4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTUYEN", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Tuyen5.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--TD11
        RemoveHandler TxtNh_Tuyen1.CyberValiting, AddressOf V_Nh_TD1
        RemoveHandler TxtNh_Tuyen1.CyberLeave, AddressOf L_Nh_TD1
        AddHandler TxtNh_Tuyen1.CyberValiting, AddressOf V_Nh_TD1
        AddHandler TxtNh_Tuyen1.CyberLeave, AddressOf L_Nh_TD1
        '--TD12
        RemoveHandler TxtNh_Tuyen2.CyberValiting, AddressOf V_Nh_TD2
        RemoveHandler TxtNh_Tuyen2.CyberLeave, AddressOf L_Nh_TD2
        AddHandler TxtNh_Tuyen2.CyberValiting, AddressOf V_Nh_TD2
        AddHandler TxtNh_Tuyen2.CyberLeave, AddressOf L_Nh_TD2
        '--TD13
        RemoveHandler TxtNh_Tuyen3.CyberValiting, AddressOf V_Nh_TD3
        RemoveHandler TxtNh_Tuyen3.CyberLeave, AddressOf L_Nh_TD3
        AddHandler TxtNh_Tuyen3.CyberValiting, AddressOf V_Nh_TD3
        AddHandler TxtNh_Tuyen3.CyberLeave, AddressOf L_Nh_TD3
        '--TD14
        RemoveHandler TxtNh_Tuyen4.CyberValiting, AddressOf V_Nh_TD4
        RemoveHandler TxtNh_Tuyen4.CyberLeave, AddressOf L_Nh_TD4
        AddHandler TxtNh_Tuyen4.CyberValiting, AddressOf V_Nh_TD4
        AddHandler TxtNh_Tuyen4.CyberLeave, AddressOf L_Nh_TD4
        '--TD15
        RemoveHandler TxtNh_Tuyen5.CyberValiting, AddressOf V_Nh_TD5
        RemoveHandler TxtNh_Tuyen5.CyberLeave, AddressOf L_Nh_TD5
        AddHandler TxtNh_Tuyen5.CyberValiting, AddressOf V_Nh_TD5
        AddHandler TxtNh_Tuyen5.CyberLeave, AddressOf L_Nh_TD5

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_TD1"
    Private Sub V_Nh_TD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Tuyen1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTUYEN", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_TD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Tuyen1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Tuyen1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Tuyen1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD2"
    Private Sub V_Nh_TD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Tuyen2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTUYEN", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_TD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Tuyen2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Tuyen2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Tuyen2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD3"
    Private Sub V_Nh_TD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Tuyen3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTUYEN", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_TD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Tuyen3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Tuyen3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Tuyen3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD4"
    Private Sub V_Nh_TD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Tuyen4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTUYEN", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_TD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Tuyen4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Tuyen4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Tuyen4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD5"
    Private Sub V_Nh_TD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Tuyen5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTUYEN", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_TD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Tuyen5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Tuyen5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Tuyen5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
       Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Tuyen.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
