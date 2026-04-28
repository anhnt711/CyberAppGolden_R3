Public Class DMLHBH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMBP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_LHBH.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If TxtNh_LHBh1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLHBH", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_LHBh1.Text.Trim + "')", CyberSmlib)
        If TxtNh_LHBh2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLHBH", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_LHBh2.Text.Trim + "')", CyberSmlib)
        If TxtNh_LHBh3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLHBH", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_LHBh3.Text.Trim + "')", CyberSmlib)
        If TxtNh_LHBh4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLHBH", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_LHBh4.Text.Trim + "')", CyberSmlib)
        If TxtNh_LHBh5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLHBH", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_LHBh5.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_LHBH.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_LHBH.KeyPress, AddressOf TxtCodeError_KeyPress

        '--BP1
        RemoveHandler TxtNh_LHBh1.CyberValiting, AddressOf V_Nh_Bh1
        RemoveHandler TxtNh_LHBh1.CyberLeave, AddressOf L_Nh_Bh1
        AddHandler TxtNh_LHBh1.CyberValiting, AddressOf V_Nh_Bh1
        AddHandler TxtNh_LHBh1.CyberLeave, AddressOf L_Nh_Bh1
        '--BP2
        RemoveHandler TxtNh_LHBh2.CyberValiting, AddressOf V_Nh_Bh2
        RemoveHandler TxtNh_LHBh2.CyberLeave, AddressOf L_Nh_Bh2
        AddHandler TxtNh_LHBh2.CyberValiting, AddressOf V_Nh_Bh2
        AddHandler TxtNh_LHBh2.CyberLeave, AddressOf L_Nh_Bh2
        '--BP3
        RemoveHandler TxtNh_LHBh3.CyberValiting, AddressOf V_Nh_Bh3
        RemoveHandler TxtNh_LHBh3.CyberLeave, AddressOf L_Nh_Bh3
        AddHandler TxtNh_LHBh3.CyberValiting, AddressOf V_Nh_Bh3
        AddHandler TxtNh_LHBh3.CyberLeave, AddressOf L_Nh_Bh3
        '--BP4
        RemoveHandler TxtNh_LHBh4.CyberValiting, AddressOf V_Nh_Bh4
        RemoveHandler TxtNh_LHBh4.CyberLeave, AddressOf L_Nh_Bh4
        AddHandler TxtNh_LHBh4.CyberValiting, AddressOf V_Nh_Bh4
        AddHandler TxtNh_LHBh4.CyberLeave, AddressOf L_Nh_Bh4
        '--BP5
        RemoveHandler TxtNh_LHBh5.CyberValiting, AddressOf V_Nh_Bh5
        RemoveHandler TxtNh_LHBh5.CyberLeave, AddressOf L_Nh_Bh5
        AddHandler TxtNh_LHBh5.CyberValiting, AddressOf V_Nh_Bh5
        AddHandler TxtNh_LHBh5.CyberLeave, AddressOf L_Nh_Bh5

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Nh_Bh1"
    Private Sub V_Nh_Bh1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LHBh1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLhBh", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Bh1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_LHBh1.GetRowsSelectData(True)
        If TxtNh_LHBh1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_LHBh1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LHBh1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Bh2"
    Private Sub V_Nh_Bh2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LHBh2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLhBh", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Bh2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LHBh2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LHBh2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LHBh2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LHBh2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Bh3"
    Private Sub V_Nh_Bh3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LHBh3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLhBh", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Bh3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not DrReturn Is Nothing Then TxtNh_LHBh3.Text = DrReturn.Item("Ma_Nh")
        If TxtNh_LHBh3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LHBh3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LHBh3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LHBh3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Bh4"
    Private Sub V_Nh_Bh4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LHBh4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLhBh", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_Bh4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LHBh4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LHBh4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LHBh4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LHBh4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Bh5"
    Private Sub V_Nh_Bh5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LHBh5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhLhBh", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_Bh5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LHBh5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LHBh5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LHBh5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LHBh5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_LHBH.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
