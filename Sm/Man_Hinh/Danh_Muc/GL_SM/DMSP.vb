Public Class DMSP
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMSP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_SP, TxtNh_SP1, TxtNh_SP2, TxtNh_SP3, TxtNh_SP4, TxtNh_SP5)
        TxtMa_SP.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtNh_SP1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhSP", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_SP1.Text.Trim + "')", CyberSmlib)
        If TxtNh_SP2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhSP", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_SP2.Text.Trim + "')", CyberSmlib)
        If TxtNh_SP3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhSP", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_SP3.Text.Trim + "')", CyberSmlib)
        If TxtNh_SP4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhSP", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_SP4.Text.Trim + "')", CyberSmlib)
        If TxtNh_SP5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhSP", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_SP5.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_SP.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_SP.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Sp1
        RemoveHandler TxtNh_SP1.CyberValiting, AddressOf V_NH_SP1
        RemoveHandler TxtNh_SP1.CyberLeave, AddressOf L_NH_SP1
        AddHandler TxtNh_SP1.CyberValiting, AddressOf V_NH_SP1
        AddHandler TxtNh_SP1.CyberLeave, AddressOf L_NH_SP1
        '--Sp2
        RemoveHandler TxtNh_SP2.CyberValiting, AddressOf V_NH_SP2
        RemoveHandler TxtNh_SP2.CyberLeave, AddressOf L_NH_SP2
        AddHandler TxtNh_SP2.CyberValiting, AddressOf V_NH_SP2
        AddHandler TxtNh_SP2.CyberLeave, AddressOf L_NH_SP2
        '--Sp3
        RemoveHandler TxtNh_SP3.CyberValiting, AddressOf V_NH_SP3
        RemoveHandler TxtNh_SP3.CyberLeave, AddressOf L_NH_SP3
        AddHandler TxtNh_SP3.CyberValiting, AddressOf V_NH_SP3
        AddHandler TxtNh_SP3.CyberLeave, AddressOf L_NH_SP3
        '--Sp4
        RemoveHandler TxtNh_SP4.CyberValiting, AddressOf V_NH_SP4
        RemoveHandler TxtNh_SP4.CyberLeave, AddressOf L_NH_SP4
        AddHandler TxtNh_SP4.CyberValiting, AddressOf V_NH_SP4
        AddHandler TxtNh_SP4.CyberLeave, AddressOf L_NH_SP4
        '--Sp5
        RemoveHandler TxtNh_SP5.CyberValiting, AddressOf V_NH_SP5
        RemoveHandler TxtNh_SP5.CyberLeave, AddressOf L_NH_SP5
        AddHandler TxtNh_SP5.CyberValiting, AddressOf V_NH_SP5
        AddHandler TxtNh_SP5.CyberLeave, AddressOf L_NH_SP5

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_SP1"
    Private Sub V_NH_SP1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_SP1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhSP", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_SP1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_SP1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_SP1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_SP1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_SP2"
    Private Sub V_NH_SP2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_SP2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhSP", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_SP2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_SP2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_SP2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_SP2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_SP3"
    Private Sub V_NH_SP3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_SP3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhSP", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_SP3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_SP3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_SP3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_SP3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_SP4"
    Private Sub V_NH_SP4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_SP4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhSP", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_SP4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_SP4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_SP4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_SP4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_SP5"
    Private Sub V_NH_SP5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_SP5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhSP", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_SP5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_SP5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_SP5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_SP5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_SP.Text = _Value
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
