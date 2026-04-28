Imports System.Data.SqlClient
Public Class DMTT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMTT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_TT.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If TxtNh_Tt1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTT", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Tt1.Text.Trim + "')", CyberSmlib)
        If TxtNh_Tt2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTT", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Tt2.Text.Trim + "')", CyberSmlib)
        If TxtNh_Tt3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTT", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Tt3.Text.Trim + "')", CyberSmlib)
        If TxtNh_Tt4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTT", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Tt4.Text.Trim + "')", CyberSmlib)
        If TxtNh_Tt5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhTT", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Tt5.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_TT.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_TT.KeyPress, AddressOf TxtCodeError_KeyPress

        '--BP1
        RemoveHandler TxtNh_Tt1.CyberValiting, AddressOf V_Nh_Tt1
        RemoveHandler TxtNh_Tt1.CyberLeave, AddressOf L_Nh_Tt1
        AddHandler TxtNh_Tt1.CyberValiting, AddressOf V_Nh_Tt1
        AddHandler TxtNh_Tt1.CyberLeave, AddressOf L_Nh_Tt1
        '--BP2
        RemoveHandler TxtNh_Tt2.CyberValiting, AddressOf V_Nh_Tt2
        RemoveHandler TxtNh_Tt2.CyberLeave, AddressOf L_Nh_Tt2
        AddHandler TxtNh_Tt2.CyberValiting, AddressOf V_Nh_Tt2
        AddHandler TxtNh_Tt2.CyberLeave, AddressOf L_Nh_Tt2
        '--BP3
        RemoveHandler TxtNh_Tt3.CyberValiting, AddressOf V_Nh_Tt3
        RemoveHandler TxtNh_Tt3.CyberLeave, AddressOf L_Nh_Tt3
        AddHandler TxtNh_Tt3.CyberValiting, AddressOf V_Nh_Tt3
        AddHandler TxtNh_Tt3.CyberLeave, AddressOf L_Nh_Tt3
        '--BP4
        RemoveHandler TxtNh_Tt4.CyberValiting, AddressOf V_Nh_Tt4
        RemoveHandler TxtNh_Tt4.CyberLeave, AddressOf L_Nh_Tt4
        AddHandler TxtNh_Tt4.CyberValiting, AddressOf V_Nh_Tt4
        AddHandler TxtNh_Tt4.CyberLeave, AddressOf L_Nh_Tt4
        '--BP5
        RemoveHandler TxtNh_Tt5.CyberValiting, AddressOf V_Nh_Tt5
        RemoveHandler TxtNh_Tt5.CyberLeave, AddressOf L_Nh_Tt5
        AddHandler TxtNh_Tt5.CyberValiting, AddressOf V_Nh_Tt5
        AddHandler TxtNh_Tt5.CyberLeave, AddressOf L_Nh_Tt5



    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Nh_Tt1"
    Private Sub V_Nh_Tt1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Tt1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTt", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Tt1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Tt1.GetRowsSelectData(True)
        If TxtNh_Tt1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_Tt1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Tt1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Tt2"
    Private Sub V_Nh_Tt2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Tt2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTt", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Tt2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Tt2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Tt2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Tt2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Tt2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Tt3"
    Private Sub V_Nh_Tt3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Tt3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTt", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Tt3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not DrReturn Is Nothing Then TxtNh_Tt3.Text = DrReturn.Item("Ma_Nh")
        If TxtNh_Tt3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Tt3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Tt3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Tt3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Tt4"
    Private Sub V_Nh_Tt4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Tt4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTt", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_Tt4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Tt4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Tt4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Tt4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Tt4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Tt5"
    Private Sub V_Nh_Tt5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Tt5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhTt", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_Tt5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Tt5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Tt5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Tt5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Tt5.Text = ""
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
