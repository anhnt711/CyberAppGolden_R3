Public Class DMHLKU
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMHLKU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        txtNgay_HL.Value = Now.Date()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_KU.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()


        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub

#End Region
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--Ma_KHO
        RemoveHandler TxtMa_KU.CyberValiting, AddressOf V_Ma_KU
        RemoveHandler TxtMa_KU.CyberLeave, AddressOf L_Ma_KU
        AddHandler TxtMa_KU.CyberValiting, AddressOf V_Ma_KU
        AddHandler TxtMa_KU.CyberLeave, AddressOf L_Ma_KU
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#Region "Valid"
#Region "Vali --- Ma_Kho"
    Private Sub V_Ma_KU(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KU.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_KU", "DmKU", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KU(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_KU.Text = "" Then
            TxtTen_KU.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_KU.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KU.Text = DrReturn.Item("Ma_KU")
            TxtTen_KU.Text = DrReturn.Item("Ten_KU")
        Else
            TxtMa_KU.Text = ""
            TxtTen_KU.Text = ""
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
