Public Class DMLOI
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMLOI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_Loi.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If TxtMa_Cd.Text.Trim = "" Then txtTen_Cd.Text = "" Else txtTen_Cd.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Cd", "Dmcd", "Ma_Cd = N'" + TxtMa_Cd.Text.Trim + "'", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_Loi.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Loi.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Map01
        RemoveHandler TxtMa_Cd.CyberValiting, AddressOf V_Ma_Cd
        RemoveHandler TxtMa_Cd.CyberLeave, AddressOf L_Ma_Cd
        AddHandler TxtMa_Cd.CyberValiting, AddressOf V_Ma_Cd
        AddHandler TxtMa_Cd.CyberLeave, AddressOf L_Ma_Cd
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
    Private Sub V_Ma_Cd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Cd.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_cd", "Dmcd", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Cd.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Cd.Text = DrReturn.Item("Ma_cd")
            txtTen_Cd.Text = DrReturn.Item("Ten_cd")
        Else
            TxtMa_Cd.Text = ""
            txtTen_Cd.Text = ""
        End If
    End Sub
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
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
