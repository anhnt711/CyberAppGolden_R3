Public Class PH89CVDV_Right
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa As DataTable
    Private _Load_TP As Boolean = False
    Private Sub FDMKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load_TP = False
        V_GetChkErro()

        V_Load()

        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        Txtcomment.Text = CyberSmodb.SQLGetvalue(Appconn, "comment", "Userinfo", "user_name = N'" + Txtuser_name.Text + "'", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        ''--to
        RemoveHandler Txtuser_name.CyberValiting, AddressOf V_User_name
        RemoveHandler Txtuser_name.CyberLeave, AddressOf L_User_name
        AddHandler Txtuser_name.CyberValiting, AddressOf V_User_name
        AddHandler Txtuser_name.CyberLeave, AddressOf L_User_name
       
    End Sub
#End Region
#Region "Vali --- Userinfo"
    Private Sub V_User_name(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtuser_name.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "user_name", "Userinfo", "1=1", "1=1")
    End Sub
    Private Sub L_User_name(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Txtuser_name.Text = "" Then
            Txtcomment.Text = ""
            Exit Sub
        End If
        DrReturn = Txtuser_name.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtuser_name.Text = DrReturn.Item("user_name")
            Txtcomment.Text = DrReturn.Item("comment")
        Else
            Txtuser_name.Text = ""
            Txtcomment.Text = ""

        End If
    End Sub
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then Txtuser_name.Text = _Value
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
