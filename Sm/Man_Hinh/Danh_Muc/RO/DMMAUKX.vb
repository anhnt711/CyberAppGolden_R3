Public Class DMMauKx
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMMauKx_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_kx.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        'Cyber.ListGroupCustom.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_TTLN, TxtNh_TTLN1, TxtNh_TTLN2, TxtNh_TTLN3, TxtNh_TTLN4, TxtNh_TTLN5)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()

        MyBase.V_Load()

        TxtTen_kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_KX", "Dmkx", "( Ma_KX = N'" + TxtMa_kx.Text.Trim + "')", CyberSmlib)
        TxtTen_Mau.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_mau", "Dmmauxe", "(Ma_mau = N'" + TxtMa_MAU.Text.Trim + "')", CyberSmlib)

        If TxtMa_kx.Text.Trim = "" Then TxtTen_kx.Text = "" Else TxtTen_kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_KX", "Dmkx", "(Ma_KX = N'" + TxtMa_kx.Text.Trim + "')", CyberSmlib)
        If TxtMa_MAU.Text.Trim = "" Then TxtTen_Mau.Text = "" Else TxtTen_Mau.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_mau", "Dmmauxe", "(Ma_MAU = N'" + TxtMa_MAU.Text.Trim + "')", CyberSmlib)
      
    End Sub
    Protected Overrides Sub V_Addhander()

        MyBase.V_Addhander()
        RemoveHandler TxtMa_kx.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_kx.KeyPress, AddressOf TxtCodeError_KeyPress

        '--Ma_KX
        RemoveHandler TxtMa_kx.CyberValiting, AddressOf V_MA_kx
        RemoveHandler TxtMa_kx.CyberLeave, AddressOf L_MA_kx
        AddHandler TxtMa_kx.CyberValiting, AddressOf V_MA_kx
        AddHandler TxtMa_kx.CyberLeave, AddressOf L_MA_kx
        '--Ma_Mau
        RemoveHandler TxtMa_MAU.CyberValiting, AddressOf V_Ma_MAU
        RemoveHandler TxtMa_MAU.CyberLeave, AddressOf L_Ma_MAU
        AddHandler TxtMa_MAU.CyberValiting, AddressOf V_Ma_MAU
        AddHandler TxtMa_MAU.CyberLeave, AddressOf L_Ma_MAU
      
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- MA_Kx"
    Private Sub V_MA_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_kx.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_KX", "DmKX", "1=1", "1=1")
    End Sub
    Private Sub L_MA_KX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_kx.Text = "" Then
            TxtTen_kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kx.Text = DrReturn.Item("Ma_kX")
            TxtTen_kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_kx.Text = ""
            TxtTen_kx.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Mau"
    Private Sub V_Ma_MAU(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_MAU.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Mau", "DmMauxe", "1=1", "1=1")
    End Sub
    Private Sub L_MA_MAU(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_MAU.Text = "" Then
            TxtTen_Mau.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_MAU.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_MAU.Text = DrReturn.Item("Ma_Mau")
            TxtTen_Mau.Text = DrReturn.Item("Ten_MAU")
        Else
            TxtMa_MAU.Text = ""
            TxtTen_Mau.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_kx.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
