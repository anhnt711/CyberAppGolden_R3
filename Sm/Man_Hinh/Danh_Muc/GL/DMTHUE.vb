Public Class DMTHUE
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMTKNH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtTk_thue_co.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_Tk_thue_co.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk", "DmTk", "(Tk = N'" + TxtTk_thue_co.Text.Trim + "')", CyberSmlib)
        TxtTen_tk_thue_no.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk", "DmTk", "(Tk = N'" + TxtTk_thue_no.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--TK
        RemoveHandler TxtTk_thue_co.CyberValiting, AddressOf V_tK_thue_co
        RemoveHandler TxtTk_thue_co.CyberLeave, AddressOf L_tK_thue_co
        RemoveHandler TxtTk_thue_no.CyberValiting, AddressOf V_tK_thue_no
        RemoveHandler TxtTk_thue_no.CyberLeave, AddressOf L_tK_thue_no

        AddHandler TxtTk_thue_co.CyberValiting, AddressOf V_tK_thue_co
        AddHandler TxtTk_thue_co.CyberLeave, AddressOf L_tK_thue_co
        AddHandler TxtTk_thue_no.CyberValiting, AddressOf V_tK_thue_no
        AddHandler TxtTk_thue_no.CyberLeave, AddressOf L_tK_thue_no

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- tK_thue_co"
    Private Sub V_tK_thue_co(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_thue_co.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk", "Dmtk", "1=1", "1=1")
    End Sub
    Private Sub L_tK_thue_co(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk_thue_co.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_thue_co.Text = DrReturn.Item("Tk")
            TxtTen_Tk_thue_co.Text = DrReturn.Item("Ten_Tk")
        Else
            TxtTk_thue_co.Text = ""
            TxtTen_Tk_thue_co.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- tK_thue_no"
    Private Sub V_tK_thue_no(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_thue_no.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk", "Dmtk", "1=1", "1=1")
    End Sub
    Private Sub L_tK_thue_no(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk_thue_no.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_thue_no.Text = DrReturn.Item("Tk")
            TxtTen_tk_thue_no.Text = DrReturn.Item("Ten_Tk")
        Else
            TxtTk_thue_no.Text = ""
            TxtTen_tk_thue_no.Text = ""
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
