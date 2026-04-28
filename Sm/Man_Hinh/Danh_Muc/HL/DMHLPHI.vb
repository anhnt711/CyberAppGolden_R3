Public Class DMHLPHI
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMHLPHI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        txtNgay_HL.Value = Now.Date()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_PHI.Focus()
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
        RemoveHandler TxtMa_PHI.CyberValiting, AddressOf V_Ma_PHI
        RemoveHandler TxtMa_PHI.CyberLeave, AddressOf L_Ma_PHI
        AddHandler TxtMa_PHI.CyberValiting, AddressOf V_Ma_PHI
        AddHandler TxtMa_PHI.CyberLeave, AddressOf L_Ma_PHI
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#Region "Valid"
#Region "Vali --- Ma_Kho"
    Private Sub V_Ma_PHI(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_PHI.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_PHI", "DmPHI", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_PHI(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_PHI.Text = "" Then
            TxtTen_PHI.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_PHI.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_PHI.Text = DrReturn.Item("Ma_PHI")
            TxtTen_PHI.Text = DrReturn.Item("Ten_PHI")
        Else
            TxtMa_PHI.Text = ""
            TxtTen_PHI.Text = ""
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
