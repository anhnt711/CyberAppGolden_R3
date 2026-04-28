Public Class DMDoXe
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMKHO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DsLookup = New DataSet
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_do, TxtNh_do1, TxtNh_do2, TxtNh_do3, TxtNh_do4, TxtNh_do5)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhdoxe", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_do1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhdoxe", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_do2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhdoxe", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_do3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhdoxe", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_do4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhdoxe", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_do5.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        RemoveHandler TxtMa_do.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_do.KeyPress, AddressOf TxtCodeError_KeyPress
        '--KHO1
        RemoveHandler TxtNh_do1.CyberValiting, AddressOf V_NH_Kho1
        RemoveHandler TxtNh_do1.CyberLeave, AddressOf L_NH_Kho1
        AddHandler TxtNh_do1.CyberValiting, AddressOf V_NH_Kho1
        AddHandler TxtNh_do1.CyberLeave, AddressOf L_NH_Kho1
        '--KHO2
        RemoveHandler TxtNh_do2.CyberValiting, AddressOf V_NH_Kho2
        RemoveHandler TxtNh_do2.CyberLeave, AddressOf L_NH_Kho2
        AddHandler TxtNh_do2.CyberValiting, AddressOf V_NH_Kho2
        AddHandler TxtNh_do2.CyberLeave, AddressOf L_NH_Kho2
        '--KHO3
        RemoveHandler TxtNh_do3.CyberValiting, AddressOf V_NH_Kho3
        RemoveHandler TxtNh_do3.CyberLeave, AddressOf L_NH_Kho3
        AddHandler TxtNh_do3.CyberValiting, AddressOf V_NH_Kho3
        AddHandler TxtNh_do3.CyberLeave, AddressOf L_NH_Kho3
        '--KHO4
        RemoveHandler TxtNh_do4.CyberValiting, AddressOf V_NH_Kho4
        RemoveHandler TxtNh_do4.CyberLeave, AddressOf L_NH_Kho4
        AddHandler TxtNh_do4.CyberValiting, AddressOf V_NH_Kho4
        AddHandler TxtNh_do4.CyberLeave, AddressOf L_NH_Kho4
        '--KHO5
        RemoveHandler TxtNh_do5.CyberValiting, AddressOf V_NH_Kho5
        RemoveHandler TxtNh_do5.CyberLeave, AddressOf L_NH_Kho5
        AddHandler TxtNh_do5.CyberValiting, AddressOf V_NH_Kho5
        AddHandler TxtNh_do5.CyberLeave, AddressOf L_NH_Kho5



    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_Kho1"
    Private Sub V_NH_Kho1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_do1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhdoxe", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_Kho1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_do1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_do1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_do1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Kho2"
    Private Sub V_NH_Kho2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_do2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhdoxe", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_Kho2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_do2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_do2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_do2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Kho3"
    Private Sub V_NH_Kho3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_do3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhdoxe", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_Kho3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_do3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_do3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_do3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Kho4"
    Private Sub V_NH_Kho4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_do4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhdoxe", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_Kho4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_do4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_do4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_do4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Kho5"
    Private Sub V_NH_Kho5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_do5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhdoxe", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_Kho5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_do5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_do5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_do5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region

#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_do.Text = _Value
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