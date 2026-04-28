Public Class DMXA
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMTD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_xa.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        TxtTen_TP.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TP", "DmTP", "(Ma_TP = N'" + TxtMa_TP.Text.Trim + "')", CyberSmlib)
        TxtTen_quan.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_quan", "Dmquan", "(Ma_quan = N'" + TxtMa_quan.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_xa.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_xa.KeyPress, AddressOf TxtCodeError_KeyPress

        '--Ma_TP
        RemoveHandler TxtMa_TP.CyberValiting, AddressOf V_Ma_TP
        RemoveHandler TxtMa_TP.CyberLeave, AddressOf L_Ma_TP
        AddHandler TxtMa_TP.CyberValiting, AddressOf V_Ma_TP
        AddHandler TxtMa_TP.CyberLeave, AddressOf L_Ma_TP
        '--Ma_Quan
        RemoveHandler TxtMa_quan.CyberValiting, AddressOf V_Ma_quan
        RemoveHandler TxtMa_quan.CyberLeave, AddressOf L_Ma_quan
        AddHandler TxtMa_quan.CyberValiting, AddressOf V_Ma_quan
        AddHandler TxtMa_quan.CyberLeave, AddressOf L_Ma_quan
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_TP"
    Private Sub V_Ma_TP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TP.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TP", "DMTP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TP.Text = "" Then
            TxtTen_TP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TP.Text = DrReturn.Item("Ma_TP")
            TxtTen_TP.Text = DrReturn.Item("Ten_TP")
        Else
            TxtMa_TP.Text = ""
            TxtTen_TP.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_quan"
    Private Sub V_Ma_quan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_quan.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_quan", "Dmquan", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_quan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_quan.Text = "" Then
            TxtTen_quan.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_quan.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_quan.Text = DrReturn.Item("Ma_quan")
            TxtTen_quan.Text = DrReturn.Item("Ten_quan")
        Else
            TxtMa_quan.Text = ""
            TxtTen_quan.Text = ""
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
