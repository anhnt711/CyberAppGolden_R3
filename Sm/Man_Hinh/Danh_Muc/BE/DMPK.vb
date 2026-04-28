Public Class DMPK
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMPK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DsLookup = New DataSet
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_PK, TxtNh_PK1, TxtNh_PK2, TxtNh_PK3, TxtNh_PK4, TxtNh_PK5)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhPK", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_PK1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhPK", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_PK2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhPK", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_PK3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhPK", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_PK4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhPK", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_PK5.Text.Trim + "')", CyberSmlib)
        TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kx", "DMkx", "(Ma_kx =  N'" + TxtMa_kx.Text.Trim + "')", CyberSmlib)
        ' If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        RemoveHandler TxtMa_PK.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_PK.KeyPress, AddressOf TxtCodeError_KeyPress
        '--pk1
        RemoveHandler TxtNh_PK1.CyberValiting, AddressOf V_NH_pk1
        RemoveHandler TxtNh_PK1.CyberLeave, AddressOf L_NH_pk1
        AddHandler TxtNh_PK1.CyberValiting, AddressOf V_NH_pk1
        AddHandler TxtNh_PK1.CyberLeave, AddressOf L_NH_pk1
        '--pk2
        RemoveHandler TxtNh_PK2.CyberValiting, AddressOf V_NH_pk2
        RemoveHandler TxtNh_PK2.CyberLeave, AddressOf L_NH_pk2
        AddHandler TxtNh_PK2.CyberValiting, AddressOf V_NH_pk2
        AddHandler TxtNh_PK2.CyberLeave, AddressOf L_NH_pk2
        '--pk3
        RemoveHandler TxtNh_PK3.CyberValiting, AddressOf V_NH_pk3
        RemoveHandler TxtNh_PK3.CyberLeave, AddressOf L_NH_pk3
        AddHandler TxtNh_PK3.CyberValiting, AddressOf V_NH_pk3
        AddHandler TxtNh_PK3.CyberLeave, AddressOf L_NH_pk3
        '--pk4
        RemoveHandler TxtNh_PK4.CyberValiting, AddressOf V_NH_pk4
        RemoveHandler TxtNh_PK4.CyberLeave, AddressOf L_NH_pk4
        AddHandler TxtNh_PK4.CyberValiting, AddressOf V_NH_pk4
        AddHandler TxtNh_PK4.CyberLeave, AddressOf L_NH_pk4
        '--pk5
        RemoveHandler TxtNh_PK5.CyberValiting, AddressOf V_NH_pk5
        RemoveHandler TxtNh_PK5.CyberLeave, AddressOf L_NH_pk5
        AddHandler TxtNh_PK5.CyberValiting, AddressOf V_NH_pk5
        AddHandler TxtNh_PK5.CyberLeave, AddressOf L_NH_pk5

        '--TK_DL
        RemoveHandler TxtMa_kx.CyberValiting, AddressOf V_Ma_kx
        RemoveHandler TxtMa_kx.CyberLeave, AddressOf L_Ma_kx

        AddHandler TxtMa_kx.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_kx.CyberLeave, AddressOf L_Ma_kx

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_pk1"
    Private Sub V_NH_pk1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_PK1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhpk", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_pk1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_PK1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_PK1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_PK1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_pk2"
    Private Sub V_NH_pk2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_PK2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhpk", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_pk2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_PK2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_PK2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_PK2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_pk3"
    Private Sub V_NH_pk3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_PK3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhpk", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_pk3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_PK3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_PK3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_PK3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_pk4"
    Private Sub V_NH_pk4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_PK4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhpk", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_pk4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_PK4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_PK4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_PK4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_pk5"
    Private Sub V_NH_pk5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_PK5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhpk", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_pk5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_PK5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_PK5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_PK5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_kx"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_kx.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "ma_kx", "Dmkx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kx.Text = DrReturn.Item("ma_kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_PK.Text = _Value
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