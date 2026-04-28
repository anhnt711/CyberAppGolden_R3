Public Class DmGiaPW1
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DmGiaPW1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        txtNgay_HL.Value = Now.Date()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Dim DT As Date = txtNgay_HL.Value
        If DT.ToString("yyyyMMdd") = "19000101" Then txtNgay_HL.Value = Now.Date
        TxtMa_VT.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub

#End Region
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--Ma_KH
        RemoveHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_KH
        RemoveHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_KH

        '--Ma_VT
        RemoveHandler TxtMa_VT.CyberValiting, AddressOf V_Ma_Vt
        RemoveHandler TxtMa_VT.CyberLeave, AddressOf L_Ma_Vt
        AddHandler TxtMa_VT.CyberValiting, AddressOf V_Ma_Vt
        AddHandler TxtMa_VT.CyberLeave, AddressOf L_Ma_Vt
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#Region "Valid"
#Region "Vali --- Ma_VT"
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_VT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Vt", "DmVt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_VT.Text = "" Then
            TxtTen_VT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_VT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_VT.Text = DrReturn.Item("Ma_Vt")
            TxtTen_VT.Text = DrReturn.Item("Ten_Vt")
        Else
            TxtMa_VT.Text = ""
            TxtTen_VT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Kh"
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kh.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kh.Text = "" Then
            TxtTen_Kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
            TxtTen_Kh.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
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
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
