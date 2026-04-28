Public Class DmCapDuyet
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMLapKHG_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtMa_Bp.Text.Trim = "" Then txtTen_BP.Text = "" Else txtTen_BP.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Bp", "DmBp", "(Ma_BP = N'" + TxtMa_Bp.Text.Trim + "')", CyberSmlib)
        If TxtCap.Text.Trim = "" Then txtTen_Cap.Text = "" Else txtTen_Cap.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Cap", "vCapDuyetDNChi", "(Cap = N'" + TxtCap.Text.Trim + "')", CyberSmlib)
        If TxtUser_Name.Text.Trim = "" Then txtHo_Ten.Text = "" Else txtHo_Ten.Text = CyberSmodb.SQLGetvalue(Appconn, "Comment", "UserInfo", "(User_Name = N'" + TxtUser_Name.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtNgay_HL.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtNgay_HL.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Cap
        RemoveHandler TxtCap.CyberValiting, AddressOf V_Cap
        RemoveHandler TxtCap.CyberLeave, AddressOf L_Cap
        AddHandler TxtCap.CyberValiting, AddressOf V_Cap
        AddHandler TxtCap.CyberLeave, AddressOf L_Cap
        '--Ma_Bp
        RemoveHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_BP
        RemoveHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_BP
        AddHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_BP
        '--User_Name
        RemoveHandler TxtUser_Name.CyberValiting, AddressOf V_User_Name
        RemoveHandler TxtUser_Name.CyberLeave, AddressOf L_User_Name
        AddHandler TxtUser_Name.CyberValiting, AddressOf V_User_Name
        AddHandler TxtUser_Name.CyberLeave, AddressOf L_User_Name
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Cap"
    Private Sub V_Cap(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtCap.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Cap", "vCapDuyetDNChi", "1=1", "1=1")
    End Sub
    Private Sub L_Cap(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtCap.Text = "" Then
            txtTen_Cap.Text = ""
            Exit Sub
        End If
        DrReturn = TxtCap.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtCap.Text = DrReturn.Item("Cap")
            txtTen_Cap.Text = DrReturn.Item("Ten_Cap")
        Else
            TxtCap.Text = ""
            txtTen_Cap.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Bp"
    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Bp.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Bp.Text = "" Then
            txtTen_BP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Bp.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp.Text = DrReturn.Item("Ma_Bp")
            txtTen_BP.Text = DrReturn.Item("Ten_Bp")
        Else
            TxtMa_Bp.Text = ""
            txtTen_BP.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- User_Name"
    Private Sub V_User_Name(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtUser_Name.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "User_Name", "UserInfo", "1=1", "1=1")
    End Sub
    Private Sub L_User_Name(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtUser_Name.Text = "" Then
            txtHo_Ten.Text = ""
            Exit Sub
        End If
        DrReturn = TxtUser_Name.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtUser_Name.Text = DrReturn.Item("User_Name")
            txtHo_Ten.Text = DrReturn.Item("Comment")
        Else
            TxtUser_Name.Text = ""
            txtHo_Ten.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtNgay_HL.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
