Imports System.Data.SqlClient
Public Class DMMAUXE
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMTD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_mau.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs

        If TxtNh_Mauxe1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhMauxe", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Mauxe1.Text.Trim + "')", CyberSmlib)
        If TxtNh_Mauxe2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhMauxe", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Mauxe2.Text.Trim + "')", CyberSmlib)
        If TxtNh_Mauxe3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhMauxe", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Mauxe3.Text.Trim + "')", CyberSmlib)
        If TxtNh_Mauxe4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhMauxe", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Mauxe4.Text.Trim + "')", CyberSmlib)
        If TxtNh_Mauxe5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhMauxe", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Mauxe5.Text.Trim + "')", CyberSmlib)

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_mau.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_mau.KeyPress, AddressOf TxtCodeError_KeyPress

        '--Mauxe1
        RemoveHandler TxtNh_Mauxe1.CyberValiting, AddressOf V_Nh_Mauxe1
        RemoveHandler TxtNh_Mauxe1.CyberLeave, AddressOf L_Nh_Mauxe1
        AddHandler TxtNh_Mauxe1.CyberValiting, AddressOf V_Nh_Mauxe1
        AddHandler TxtNh_Mauxe1.CyberLeave, AddressOf L_Nh_Mauxe1
        '--Mauxe2
        RemoveHandler TxtNh_Mauxe2.CyberValiting, AddressOf V_Nh_Mauxe2
        RemoveHandler TxtNh_Mauxe2.CyberLeave, AddressOf L_Nh_Mauxe2
        AddHandler TxtNh_Mauxe2.CyberValiting, AddressOf V_Nh_Mauxe2
        AddHandler TxtNh_Mauxe2.CyberLeave, AddressOf L_Nh_Mauxe2
        '--Mauxe3
        RemoveHandler TxtNh_Mauxe3.CyberValiting, AddressOf V_Nh_Mauxe3
        RemoveHandler TxtNh_Mauxe3.CyberLeave, AddressOf L_Nh_Mauxe3
        AddHandler TxtNh_Mauxe3.CyberValiting, AddressOf V_Nh_Mauxe3
        AddHandler TxtNh_Mauxe3.CyberLeave, AddressOf L_Nh_Mauxe3
        '--Mauxe4
        RemoveHandler TxtNh_Mauxe4.CyberValiting, AddressOf V_Nh_Mauxe4
        RemoveHandler TxtNh_Mauxe4.CyberLeave, AddressOf L_Nh_Mauxe4
        AddHandler TxtNh_Mauxe4.CyberValiting, AddressOf V_Nh_Mauxe4
        AddHandler TxtNh_Mauxe4.CyberLeave, AddressOf L_Nh_Mauxe4
        '--Mauxe5
        RemoveHandler TxtNh_Mauxe5.CyberValiting, AddressOf V_Nh_Mauxe5
        RemoveHandler TxtNh_Mauxe5.CyberLeave, AddressOf L_Nh_Mauxe5
        AddHandler TxtNh_Mauxe5.CyberValiting, AddressOf V_Nh_Mauxe5
        AddHandler TxtNh_Mauxe5.CyberLeave, AddressOf L_Nh_Mauxe5


    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub

#End Region
#Region "Valid"
#Region "Vali --- Nh_Mauxe1"
    Private Sub V_Nh_Mauxe1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Mauxe1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhMauxe", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Mauxe1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Mauxe1.GetRowsSelectData(True)
        If TxtNh_Mauxe1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_Mauxe1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Mauxe1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Mauxe2"
    Private Sub V_Nh_Mauxe2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Mauxe2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhMauxe", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Mauxe2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Mauxe2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Mauxe2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Mauxe2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Mauxe2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Mauxe3"
    Private Sub V_Nh_Mauxe3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Mauxe3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhMauxe", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Mauxe3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Mauxe3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Mauxe3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Mauxe3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Mauxe3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Mauxe4"
    Private Sub V_Nh_Mauxe4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Mauxe4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhMauxe", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_Mauxe4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Mauxe4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Mauxe4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Mauxe4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Mauxe4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Mauxe5"
    Private Sub V_Nh_Mauxe5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Mauxe5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhMauxe", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_Mauxe5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Mauxe5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Mauxe5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Mauxe5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Mauxe5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_mau.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
