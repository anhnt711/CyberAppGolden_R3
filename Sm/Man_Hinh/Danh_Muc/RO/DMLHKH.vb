Public Class DMLHKH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa As DataTable
    Private _Load_TP As Boolean = False
    Private Sub FDMKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load_TP = False
        V_GetChkErro()

        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If TxtNh_LHKH1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLHKH", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_LHKH1.Text.Trim + "')", CyberSmlib)
        If TxtNh_LHKH2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLHKH", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_LHKH2.Text.Trim + "')", CyberSmlib)
        If TxtNh_LHKH3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLHKH", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_LHKH3.Text.Trim + "')", CyberSmlib)
        If TxtNh_LHKH4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLHKH", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_LHKH4.Text.Trim + "')", CyberSmlib)
        If TxtNh_LHKH5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhLHKH", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_LHKH5.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_LHKH.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_LHKH.KeyPress, AddressOf TxtCodeError_KeyPress

        '--BP1
        RemoveHandler TxtNh_LHKH1.CyberValiting, AddressOf V_Nh_kh1
        RemoveHandler TxtNh_LHKH1.CyberLeave, AddressOf L_Nh_kh1
        AddHandler TxtNh_LHKH1.CyberValiting, AddressOf V_Nh_kh1
        AddHandler TxtNh_LHKH1.CyberLeave, AddressOf L_Nh_kh1
        '--BP2
        RemoveHandler TxtNh_LHKH2.CyberValiting, AddressOf V_Nh_kh2
        RemoveHandler TxtNh_LHKH2.CyberLeave, AddressOf L_Nh_kh2
        AddHandler TxtNh_LHKH2.CyberValiting, AddressOf V_Nh_kh2
        AddHandler TxtNh_LHKH2.CyberLeave, AddressOf L_Nh_kh2
        '--BP3
        RemoveHandler TxtNh_LHKH3.CyberValiting, AddressOf V_Nh_kh3
        RemoveHandler TxtNh_LHKH3.CyberLeave, AddressOf L_Nh_kh3
        AddHandler TxtNh_LHKH3.CyberValiting, AddressOf V_Nh_kh3
        AddHandler TxtNh_LHKH3.CyberLeave, AddressOf L_Nh_kh3
        '--BP4
        RemoveHandler TxtNh_LHKH4.CyberValiting, AddressOf V_Nh_kh4
        RemoveHandler TxtNh_LHKH4.CyberLeave, AddressOf L_Nh_kh4
        AddHandler TxtNh_LHKH4.CyberValiting, AddressOf V_Nh_kh4
        AddHandler TxtNh_LHKH4.CyberLeave, AddressOf L_Nh_kh4
        '--BP5
        RemoveHandler TxtNh_LHKH5.CyberValiting, AddressOf V_Nh_kh5
        RemoveHandler TxtNh_LHKH5.CyberLeave, AddressOf L_Nh_kh5
        AddHandler TxtNh_LHKH5.CyberValiting, AddressOf V_Nh_kh5
        AddHandler TxtNh_LHKH5.CyberLeave, AddressOf L_Nh_kh5

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Nh_kh1"
    Private Sub V_Nh_kh1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LHKH1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "dmnhlhkh", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_kh1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_LHKH1.GetRowsSelectData(True)
        If TxtNh_LHKH1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_LHKH1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LHKH1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_kh2"
    Private Sub V_Nh_kh2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LHKH2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "dmnhlhkh", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_kh2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LHKH2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LHKH2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LHKH2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LHKH2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_kh3"
    Private Sub V_Nh_kh3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LHKH3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "dmnhlhkh", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_kh3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not DrReturn Is Nothing Then TxtNh_LHKH3.Text = DrReturn.Item("Ma_Nh")
        If TxtNh_LHKH3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LHKH3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LHKH3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LHKH3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_kh4"
    Private Sub V_Nh_kh4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LHKH4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "dmnhlhkh", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_kh4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LHKH4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LHKH4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LHKH4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LHKH4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_kh5"
    Private Sub V_Nh_kh5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_LHKH5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "dmnhlhkh", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_kh5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_LHKH5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_LHKH5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_LHKH5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_LHKH5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub



#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_LHKH.Text = _Value
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
