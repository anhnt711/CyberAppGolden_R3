Public Class DMCD
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMCD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_CD, TxtNh_CD1, TxtNh_CD2, TxtNh_CD3, TxtNh_CD4, TxtNh_CD5)
        TxtMa_CD.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtNh_CD1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCD", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_CD1.Text.Trim + "')", CyberSmlib)
        If TxtNh_CD2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCD", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_CD2.Text.Trim + "')", CyberSmlib)
        If TxtNh_CD3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCD", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_CD3.Text.Trim + "')", CyberSmlib)
        If TxtNh_CD4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCD", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_CD4.Text.Trim + "')", CyberSmlib)
        If TxtNh_CD5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCD", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_CD5.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_CD.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_CD.KeyPress, AddressOf TxtCodeError_KeyPress

        '--CD1
        RemoveHandler TxtNh_CD1.CyberValiting, AddressOf V_NH_CD1
        RemoveHandler TxtNh_CD1.CyberLeave, AddressOf L_NH_CD1
        AddHandler TxtNh_CD1.CyberValiting, AddressOf V_NH_CD1
        AddHandler TxtNh_CD1.CyberLeave, AddressOf L_NH_CD1
        '--CD2
        RemoveHandler TxtNh_CD2.CyberValiting, AddressOf V_NH_CD2
        RemoveHandler TxtNh_CD2.CyberLeave, AddressOf L_NH_CD2
        AddHandler TxtNh_CD2.CyberValiting, AddressOf V_NH_CD2
        AddHandler TxtNh_CD2.CyberLeave, AddressOf L_NH_CD2
        '--CD3
        RemoveHandler TxtNh_CD3.CyberValiting, AddressOf V_NH_CD3
        RemoveHandler TxtNh_CD3.CyberLeave, AddressOf L_NH_CD3
        AddHandler TxtNh_CD3.CyberValiting, AddressOf V_NH_CD3
        AddHandler TxtNh_CD3.CyberLeave, AddressOf L_NH_CD3
        '--CD4
        RemoveHandler TxtNh_CD4.CyberValiting, AddressOf V_NH_CD4
        RemoveHandler TxtNh_CD4.CyberLeave, AddressOf L_NH_CD4
        AddHandler TxtNh_CD4.CyberValiting, AddressOf V_NH_CD4
        AddHandler TxtNh_CD4.CyberLeave, AddressOf L_NH_CD4
        '--CD5
        RemoveHandler TxtNh_CD5.CyberValiting, AddressOf V_NH_CD5
        RemoveHandler TxtNh_CD5.CyberLeave, AddressOf L_NH_CD5
        AddHandler TxtNh_CD5.CyberValiting, AddressOf V_NH_CD5
        AddHandler TxtNh_CD5.CyberLeave, AddressOf L_NH_CD5

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_CD1"
    Private Sub V_NH_CD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CD1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCD", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_CD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_CD1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CD1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CD1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CD1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_CD2"
    Private Sub V_NH_CD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CD2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCD", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_CD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_CD2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CD2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CD2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CD2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_CD3"
    Private Sub V_NH_CD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CD3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCD", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_CD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_CD3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CD2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CD3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CD3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_CD4"
    Private Sub V_NH_CD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CD4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCD", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_CD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_CD4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CD4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CD4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CD4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_CD5"
    Private Sub V_NH_CD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CD5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCD", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_CD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_CD5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_CD5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CD5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CD5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_CD.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
