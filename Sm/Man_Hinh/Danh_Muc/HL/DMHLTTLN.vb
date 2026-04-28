Public Class DMHLTTLN
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMHLTTLN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        txtNgay_HL.Value = Now.Date()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_TTLN.Focus()
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
        RemoveHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        RemoveHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#Region "Valid"
#Region "Vali --- Ma_Kho"
    Private Sub V_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TTLN.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TTLN.Text = "" Then
            TxtTen_TTLN.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTLN.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TTLN.Text = DrReturn.Item("Ma_TTLN")
            TxtTen_TTLN.Text = DrReturn.Item("Ten_TTLN")
        Else
            TxtMa_TTLN.Text = ""
            TxtTen_TTLN.Text = ""
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
