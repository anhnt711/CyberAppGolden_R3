Public Class DMBP
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMBP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_BP, TxtNh_BP1, TxtNh_BP2, TxtNh_BP3, TxtNh_BP4, TxtNh_BP5)
        TxtMa_BP.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtNh_BP1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhBP", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_BP1.Text.Trim + "')", CyberSmlib)
        If TxtNh_BP2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhBP", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_BP2.Text.Trim + "')", CyberSmlib)
        If TxtNh_BP3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhBP", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_BP3.Text.Trim + "')", CyberSmlib)
        If TxtNh_BP4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhBP", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_BP4.Text.Trim + "')", CyberSmlib)
        If TxtNh_BP5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhBP", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_BP5.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_BP.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_BP.KeyPress, AddressOf TxtCodeError_KeyPress

        '--BP1
        RemoveHandler TxtNh_BP1.CyberValiting, AddressOf V_NH_BP1
        RemoveHandler TxtNh_BP1.CyberLeave, AddressOf L_NH_BP1
        AddHandler TxtNh_BP1.CyberValiting, AddressOf V_NH_BP1
        AddHandler TxtNh_BP1.CyberLeave, AddressOf L_NH_BP1
        '--BP2
        RemoveHandler TxtNh_BP2.CyberValiting, AddressOf V_NH_BP2
        RemoveHandler TxtNh_BP2.CyberLeave, AddressOf L_NH_BP2
        AddHandler TxtNh_BP2.CyberValiting, AddressOf V_NH_BP2
        AddHandler TxtNh_BP2.CyberLeave, AddressOf L_NH_BP2
        '--BP3
        RemoveHandler TxtNh_BP3.CyberValiting, AddressOf V_NH_BP3
        RemoveHandler TxtNh_BP3.CyberLeave, AddressOf L_NH_BP3
        AddHandler TxtNh_BP3.CyberValiting, AddressOf V_NH_BP3
        AddHandler TxtNh_BP3.CyberLeave, AddressOf L_NH_BP3
        '--BP4
        RemoveHandler TxtNh_BP4.CyberValiting, AddressOf V_NH_BP4
        RemoveHandler TxtNh_BP4.CyberLeave, AddressOf L_NH_BP4
        AddHandler TxtNh_BP4.CyberValiting, AddressOf V_NH_BP4
        AddHandler TxtNh_BP4.CyberLeave, AddressOf L_NH_BP4
        '--BP5
        RemoveHandler TxtNh_BP5.CyberValiting, AddressOf V_NH_BP5
        RemoveHandler TxtNh_BP5.CyberLeave, AddressOf L_NH_BP5
        AddHandler TxtNh_BP5.CyberValiting, AddressOf V_NH_BP5
        AddHandler TxtNh_BP5.CyberLeave, AddressOf L_NH_BP5

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_BP1"
    Private Sub V_NH_BP1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_BP1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhBP", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_BP1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_BP1.GetRowsSelectData(True)
        If TxtNh_BP1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_BP1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_BP1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_BP2"
    Private Sub V_NH_BP2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_BP2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhBP", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_BP2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_BP2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_BP2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_BP2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_BP2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_BP3"
    Private Sub V_NH_BP3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_BP3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhBP", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_BP3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not DrReturn Is Nothing Then TxtNh_BP3.Text = DrReturn.Item("Ma_Nh")
        If TxtNh_BP3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_BP3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_BP3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_BP3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_BP4"
    Private Sub V_NH_BP4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_BP4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhBP", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_BP4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_BP4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_BP4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_BP4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_BP4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_BP5"
    Private Sub V_NH_BP5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_BP5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhBP", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_BP5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_BP5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_BP5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_BP5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_BP5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_BP.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
