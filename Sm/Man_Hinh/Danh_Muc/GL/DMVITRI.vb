Public Class DMVITRI
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMVITRI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_VITRI.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_VITRI, TxtNh_VITRI1, TxtNh_VITRI2, TxtNh_VITRI3, TxtNh_VITRI4, TxtNh_VITRI5)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVitri", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_VITRI1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVitri", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_VITRI2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVitri", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_VITRI3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVitri", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_VITRI4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVitri", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_VITRI5.Text.Trim + "')", CyberSmlib)
        TxtTen_kho.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kho", "Dmkho", String.Format("(Ma_kho = N'{0}')", TxtMa_kho.Text.Trim), CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        RemoveHandler TxtMa_VITRI.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_VITRI.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Vitri1
        RemoveHandler TxtNh_VITRI1.CyberValiting, AddressOf V_NH_Vitri1
        RemoveHandler TxtNh_VITRI1.CyberLeave, AddressOf L_NH_Vitri1
        AddHandler TxtNh_VITRI1.CyberValiting, AddressOf V_NH_Vitri1
        AddHandler TxtNh_VITRI1.CyberLeave, AddressOf L_NH_Vitri1
        '--Vitri2
        RemoveHandler TxtNh_VITRI2.CyberValiting, AddressOf V_NH_Vitri2
        RemoveHandler TxtNh_VITRI2.CyberLeave, AddressOf L_NH_Vitri2
        AddHandler TxtNh_VITRI2.CyberValiting, AddressOf V_NH_Vitri2
        AddHandler TxtNh_VITRI2.CyberLeave, AddressOf L_NH_Vitri2
        '--Vitri3
        RemoveHandler TxtNh_VITRI3.CyberValiting, AddressOf V_NH_Vitri3
        RemoveHandler TxtNh_VITRI3.CyberLeave, AddressOf L_NH_Vitri3
        AddHandler TxtNh_VITRI3.CyberValiting, AddressOf V_NH_Vitri3
        AddHandler TxtNh_VITRI3.CyberLeave, AddressOf L_NH_Vitri3
        '--Vitri4
        RemoveHandler TxtNh_VITRI4.CyberValiting, AddressOf V_NH_Vitri4
        RemoveHandler TxtNh_VITRI4.CyberLeave, AddressOf L_NH_Vitri4
        AddHandler TxtNh_VITRI4.CyberValiting, AddressOf V_NH_Vitri4
        AddHandler TxtNh_VITRI4.CyberLeave, AddressOf L_NH_Vitri4
        '--Vitri5
        RemoveHandler TxtNh_VITRI5.CyberValiting, AddressOf V_NH_Vitri5
        RemoveHandler TxtNh_VITRI5.CyberLeave, AddressOf L_NH_Vitri5
        AddHandler TxtNh_VITRI5.CyberValiting, AddressOf V_NH_Vitri5
        AddHandler TxtNh_VITRI5.CyberLeave, AddressOf L_NH_Vitri5
        '--Kho
        RemoveHandler TxtMa_kho.CyberValiting, AddressOf V_Kho
        RemoveHandler TxtMa_kho.CyberLeave, AddressOf L_Kho
        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Kho
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_Kho

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- NH_Vitri1"
    Private Sub V_NH_Vitri1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_VITRI1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVitri", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_Vitri1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_VITRI1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VITRI1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VITRI1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VITRI1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vitri2"
    Private Sub V_NH_Vitri2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_VITRI2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVitri", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_Vitri2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_VITRI2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VITRI2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VITRI2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VITRI2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vitri3"
    Private Sub V_NH_Vitri3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_VITRI3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVitri", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_Vitri3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_VITRI3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VITRI3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VITRI3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VITRI3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vitri4"
    Private Sub V_NH_Vitri4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_VITRI4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVitri", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_Vitri4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_VITRI4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VITRI4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VITRI4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VITRI4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vitri5"
    Private Sub V_NH_Vitri5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_VITRI5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhVitri", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_Vitri5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_VITRI5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VITRI5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VITRI5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VITRI5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_kho"
    Private Sub V_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_kho.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kho", "Dmkho", "1=1")
    End Sub
    Private Sub L_Kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_kho.Text = "" Then
            TxtTen_kho.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_kho.Text = DrReturn.Item("Ten_kho")
        Else
            TxtMa_kho.Text = ""
            TxtTen_kho.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
       Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_VITRI.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
