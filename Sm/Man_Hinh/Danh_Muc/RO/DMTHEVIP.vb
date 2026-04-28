Public Class DMTHEVIP
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMTHEVIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        'Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_KU, TxtNh_KU1, TxtNh_KU2, TxtNh_KU3, TxtNh_KU4, TxtNh_KU5)
        TxtNgay_HL1.Focus()
        RemoveHandler TxtMa_Xe.CyberValiting, AddressOf V_Ma_Xe
        RemoveHandler TxtMa_Xe.CyberLeave, AddressOf L_MA_XE
        AddHandler TxtMa_Xe.CyberValiting, AddressOf V_Ma_Xe
        AddHandler TxtMa_Xe.CyberLeave, AddressOf L_MA_XE
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtNgay_HL1.Value = Now.Date
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub

#End Region
#Region "Valid"
#Region "Vali --- ma_Xe"
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Xe.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Xe", "DmXe", "1=1", "1=1")
    End Sub
    Private Sub L_MA_XE(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Xe.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Xe.Text = DrReturn.Item("Ma_Xe")
        Else
            TxtMa_Xe.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        'If Not _Value.Trim = "" Then TxtMa_KU.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

End Class
