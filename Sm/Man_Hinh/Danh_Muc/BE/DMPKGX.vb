Public Class DMPKGX
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMPKGX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_pk.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kx", "DMkx", "(Ma_kx =  N'" + TxtMa_kx.Text.Trim + "')", CyberSmlib)
        Txtten_pk.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_pk", "DMpk", "(Ma_pk =  N'" + TxtMa_pk.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_pk.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_pk.KeyPress, AddressOf TxtCodeError_KeyPress
        '--ma_kx
        RemoveHandler TxtMa_kx.CyberValiting, AddressOf V_Ma_kx
        RemoveHandler txtma_kx.CyberLeave, AddressOf L_Ma_kx

        AddHandler txtma_kx.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_kx.CyberLeave, AddressOf L_Ma_kx
        '--ma_pk
        RemoveHandler TxtMa_pk.CyberValiting, AddressOf V_Ma_pk
        RemoveHandler TxtMa_pk.CyberLeave, AddressOf L_Ma_pk

        AddHandler TxtMa_pk.CyberValiting, AddressOf V_Ma_pk
        AddHandler TxtMa_pk.CyberLeave, AddressOf L_Ma_pk
        MyBase.V_Addhander()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_kx"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_kx.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "ma_kx", "Dmkx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kx.Text = DrReturn.Item("ma_kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_pk"
    Private Sub V_Ma_pk(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_pk.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "ma_pk", "Dmpk", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_pk(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_pk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_pk.Text = DrReturn.Item("ma_pk")
            Txtten_pk.Text = DrReturn.Item("Ten_pk")
        Else
            TxtMa_pk.Text = ""
            Txtten_pk.Text = ""
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
