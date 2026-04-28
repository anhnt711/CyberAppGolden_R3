Public Class DMKHO
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMKHO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DsLookup = New DataSet
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_KHo, TxtNh_Kho1, TxtNh_Kho2, TxtNh_Kho3, TxtNh_Kho4, TxtNh_Kho5)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKHO", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Kho1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKHO", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Kho2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKHO", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Kho3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKHO", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Kho4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKHO", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Kho5.Text.Trim + "')", CyberSmlib)
        TxtTen_TK_DL.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TK", "DMTK", "(Tk =  N'" + TxtTk_DL.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        RemoveHandler TxtMa_KHo.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_KHo.KeyPress, AddressOf TxtCodeError_KeyPress
        '--KHO1
        RemoveHandler TxtNh_Kho1.CyberValiting, AddressOf V_NH_Kho1
        RemoveHandler TxtNh_Kho1.CyberLeave, AddressOf L_NH_Kho1
        AddHandler TxtNh_Kho1.CyberValiting, AddressOf V_NH_Kho1
        AddHandler TxtNh_Kho1.CyberLeave, AddressOf L_NH_Kho1
        '--KHO2
        RemoveHandler TxtNh_Kho2.CyberValiting, AddressOf V_NH_Kho2
        RemoveHandler TxtNh_Kho2.CyberLeave, AddressOf L_NH_Kho2
        AddHandler TxtNh_Kho2.CyberValiting, AddressOf V_NH_Kho2
        AddHandler TxtNh_Kho2.CyberLeave, AddressOf L_NH_Kho2
        '--KHO3
        RemoveHandler TxtNh_Kho3.CyberValiting, AddressOf V_NH_Kho3
        RemoveHandler TxtNh_Kho3.CyberLeave, AddressOf L_NH_Kho3
        AddHandler TxtNh_Kho3.CyberValiting, AddressOf V_NH_Kho3
        AddHandler TxtNh_Kho3.CyberLeave, AddressOf L_NH_Kho3
        '--KHO4
        RemoveHandler TxtNh_Kho4.CyberValiting, AddressOf V_NH_Kho4
        RemoveHandler TxtNh_Kho4.CyberLeave, AddressOf L_NH_Kho4
        AddHandler TxtNh_Kho4.CyberValiting, AddressOf V_NH_Kho4
        AddHandler TxtNh_Kho4.CyberLeave, AddressOf L_NH_Kho4
        '--KHO5
        RemoveHandler TxtNh_Kho5.CyberValiting, AddressOf V_NH_Kho5
        RemoveHandler TxtNh_Kho5.CyberLeave, AddressOf L_NH_Kho5
        AddHandler TxtNh_Kho5.CyberValiting, AddressOf V_NH_Kho5
        AddHandler TxtNh_Kho5.CyberLeave, AddressOf L_NH_Kho5

        '--TK_DL
        RemoveHandler TxtTk_DL.CyberValiting, AddressOf V_TK_DL
        RemoveHandler TxtTk_DL.CyberLeave, AddressOf L_TK_DL

        AddHandler TxtTk_DL.CyberValiting, AddressOf V_TK_DL
        AddHandler TxtTk_DL.CyberLeave, AddressOf L_TK_DL

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_Kho1"
    Private Sub V_NH_Kho1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kho1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKho", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_Kho1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kho1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kho1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kho1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Kho2"
    Private Sub V_NH_Kho2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kho2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKho", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_Kho2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kho2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kho2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kho2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Kho3"
    Private Sub V_NH_Kho3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kho3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKho", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_Kho3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kho3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kho3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kho3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Kho4"
    Private Sub V_NH_Kho4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kho4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKho", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_Kho4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kho4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kho4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kho4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Kho5"
    Private Sub V_NH_Kho5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kho5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKho", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_Kho5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kho5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Kho5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kho5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TK_DL"
    Private Sub V_TK_DL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_DL.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DmTK", "1=1", "1=1")
    End Sub
    Private Sub L_TK_DL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk_DL.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_DL.Text = DrReturn.Item("TK")
            TxtTen_TK_DL.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTk_DL.Text = ""
            TxtTen_TK_DL.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_KHo.Text = _Value
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