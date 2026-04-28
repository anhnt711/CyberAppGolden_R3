Imports System.Data.SqlClient
Public Class DMTP
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMBP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_TP.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If TxtNh_TP1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTP", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_TP1.Text.Trim + "')", CyberSmlib)
        If TxtNh_TP2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTP", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_TP2.Text.Trim + "')", CyberSmlib)
        If TxtNh_TP3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTP", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_TP3.Text.Trim + "')", CyberSmlib)
        If TxtNh_TP4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTP", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_TP4.Text.Trim + "')", CyberSmlib)
        If TxtNh_TP5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTP", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_TP5.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_TP.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_TP.KeyPress, AddressOf TxtCodeError_KeyPress

        '--BP1
        RemoveHandler TxtNh_TP1.CyberValiting, AddressOf V_Nh_TP1
        RemoveHandler TxtNh_TP1.CyberLeave, AddressOf L_Nh_TP1
        AddHandler TxtNh_TP1.CyberValiting, AddressOf V_Nh_TP1
        AddHandler TxtNh_TP1.CyberLeave, AddressOf L_Nh_TP1
        '--BP2
        RemoveHandler TxtNh_TP2.CyberValiting, AddressOf V_Nh_TP2
        RemoveHandler TxtNh_TP2.CyberLeave, AddressOf L_Nh_TP2
        AddHandler TxtNh_TP2.CyberValiting, AddressOf V_Nh_TP2
        AddHandler TxtNh_TP2.CyberLeave, AddressOf L_Nh_TP2
        '--BP3
        RemoveHandler TxtNh_TP3.CyberValiting, AddressOf V_Nh_TP3
        RemoveHandler TxtNh_TP3.CyberLeave, AddressOf L_Nh_TP3
        AddHandler TxtNh_TP3.CyberValiting, AddressOf V_Nh_TP3
        AddHandler TxtNh_TP3.CyberLeave, AddressOf L_Nh_TP3
        '--BP4
        RemoveHandler TxtNh_TP4.CyberValiting, AddressOf V_Nh_TP4
        RemoveHandler TxtNh_TP4.CyberLeave, AddressOf L_Nh_TP4
        AddHandler TxtNh_TP4.CyberValiting, AddressOf V_Nh_TP4
        AddHandler TxtNh_TP4.CyberLeave, AddressOf L_Nh_TP4
        '--BP5
        RemoveHandler TxtNh_TP5.CyberValiting, AddressOf V_Nh_TP5
        RemoveHandler TxtNh_TP5.CyberLeave, AddressOf L_Nh_TP5
        AddHandler TxtNh_TP5.CyberValiting, AddressOf V_Nh_TP5
        AddHandler TxtNh_TP5.CyberLeave, AddressOf L_Nh_TP5

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Nh_TP1"
    Private Sub V_Nh_TP1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TP1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTp", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_TP1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_TP1.GetRowsSelectData(True)
        If TxtNh_TP1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_TP1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TP1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_TP2"
    Private Sub V_Nh_TP2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TP2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTp", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_TP2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TP2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TP2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TP2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TP2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_TP3"
    Private Sub V_Nh_TP3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TP3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTp", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_TP3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not DrReturn Is Nothing Then TxtNh_TP3.Text = DrReturn.Item("Ma_Nh")
        If TxtNh_TP3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TP3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TP3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TP3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_TP4"
    Private Sub V_Nh_TP4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TP4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTp", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_TP4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TP4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TP4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TP4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TP4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_TP5"
    Private Sub V_Nh_TP5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_TP5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTp", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_TP5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_TP5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_TP5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_TP5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_TP5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
