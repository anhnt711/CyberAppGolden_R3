Public Class DMCLV
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMCLV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DsLookup = New DataSet
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_C, TxtNh_C1, TxtNh_C2, TxtNh_C3, TxtNh_C4, TxtNh_C5)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "dmnhCLV", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_C1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "dmnhCLV", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_C2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "dmnhCLV", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_C3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "dmnhCLV", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_C4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "dmnhCLV", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_C5.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        RemoveHandler TxtMa_C.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_C.KeyPress, AddressOf TxtCodeError_KeyPress
        '--CLV1
        RemoveHandler TxtNh_C1.CyberValiting, AddressOf V_NH_C1
        RemoveHandler TxtNh_C1.CyberLeave, AddressOf L_NH_C1
        AddHandler TxtNh_C1.CyberValiting, AddressOf V_NH_C1
        AddHandler TxtNh_C1.CyberLeave, AddressOf L_NH_C1
        '--C2
        RemoveHandler TxtNh_C2.CyberValiting, AddressOf V_NH_C2
        RemoveHandler TxtNh_C2.CyberLeave, AddressOf L_NH_C2
        AddHandler TxtNh_C2.CyberValiting, AddressOf V_NH_C2
        AddHandler TxtNh_C2.CyberLeave, AddressOf L_NH_C2
        '--C3
        RemoveHandler TxtNh_C3.CyberValiting, AddressOf V_NH_C3
        RemoveHandler TxtNh_C3.CyberLeave, AddressOf L_NH_C3
        AddHandler TxtNh_C3.CyberValiting, AddressOf V_NH_C3
        AddHandler TxtNh_C3.CyberLeave, AddressOf L_NH_C3
        '--C4
        RemoveHandler TxtNh_C4.CyberValiting, AddressOf V_NH_C4
        RemoveHandler TxtNh_C4.CyberLeave, AddressOf L_NH_C4
        AddHandler TxtNh_C4.CyberValiting, AddressOf V_NH_C4
        AddHandler TxtNh_C4.CyberLeave, AddressOf L_NH_C4
        '--C5
        RemoveHandler TxtNh_C5.CyberValiting, AddressOf V_NH_C5
        RemoveHandler TxtNh_C5.CyberLeave, AddressOf L_NH_C5
        AddHandler TxtNh_C5.CyberValiting, AddressOf V_NH_C5
        AddHandler TxtNh_C5.CyberLeave, AddressOf L_NH_C5
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_C1"
    Private Sub V_NH_C1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_C1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "dmnhCLV", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_C1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_C1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_C1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_C1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_C2"
    Private Sub V_NH_C2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_C2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "dmnhCLV", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_C2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_C2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_C2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_C2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_C3"
    Private Sub V_NH_C3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_C3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "dmnhCLV", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_C3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_C3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_C3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_C3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_C4"
    Private Sub V_NH_C4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_C4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "dmnhCLV", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_C4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_C4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_C4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_C4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_C5"
    Private Sub V_NH_C5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_C5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "dmnhCLV", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_C5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_C5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_C5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_C5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_C.Text = _Value
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