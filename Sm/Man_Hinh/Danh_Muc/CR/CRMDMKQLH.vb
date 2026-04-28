Public Class CRMDMKQLH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMTD2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        ' Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_KQ)
        ' TxtMa_KQ.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtMa_Loai.Text.Trim = "" Then TxtTen_Loai.Text = "" Else TxtTen_Loai.Text = CyberSmodb.SQLGetvalue(Appconn, "CrmTen_Loai", "CRMDMLoai", "(CrmMa_Loai = N'" + TxtMa_Loai.Text.Trim + "')", CyberSmlib)
        ' If TxtMa_KQ.Text.Trim = "" Then TxtTen_KQ.Text = "" Else TxtTen_KQ.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_KQ", "CRMDMKQ", "(Ma_KQ = N'" + TxtMa_KQ.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--MaLoai
        RemoveHandler TxtMa_Loai.CyberValiting, AddressOf V_Ma_Loai
        RemoveHandler TxtMa_Loai.CyberLeave, AddressOf L_Ma_Loai
        AddHandler TxtMa_Loai.CyberValiting, AddressOf V_Ma_Loai
        AddHandler TxtMa_Loai.CyberLeave, AddressOf L_Ma_Loai
        '--MaKQ


    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Loai"
    Private Sub V_Ma_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Loai.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "CrmMa_Loai", "CRMDMLoai", "1=1")
    End Sub
    Private Sub L_Ma_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Loai.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Loai.Text = DrReturn.Item("CrmMa_Loai")
            TxtTen_Loai.Text = DrReturn.Item("CrmTen_Loai")
        Else
            TxtMa_Loai.Text = ""
            TxtTen_Loai.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_KQ.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
