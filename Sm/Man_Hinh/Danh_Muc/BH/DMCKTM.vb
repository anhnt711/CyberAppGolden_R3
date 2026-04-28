
Public Class DMCKTM
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
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_nhCKTM1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DMnhCKTM", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_CKTM1.Text.Trim + "')", CyberSmlib)
        TxtTen_nhCKTM2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DMnhCKTM", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_CKTM2.Text.Trim + "')", CyberSmlib)
        TxtTen_nhCKTM3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DMnhCKTM", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_CKTM3.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub

    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        AddHandler TxtNh_CKTM1.CyberValiting, AddressOf V_Nh_CKTM1
        AddHandler TxtNh_CKTM1.CyberLeave, AddressOf L_Nh_CKTM1

        AddHandler TxtNh_CKTM2.CyberValiting, AddressOf V_Nh_CKTM2
        AddHandler TxtNh_CKTM2.CyberLeave, AddressOf L_Nh_CKTM2

        AddHandler TxtNh_CKTM3.CyberValiting, AddressOf V_Nh_CKTM3
        AddHandler TxtNh_CKTM3.CyberLeave, AddressOf L_Nh_CKTM3
    End Sub
#End Region
#Region "Valid"
#End Region
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#Region "Valid"

    Private Sub V_Nh_CKTM1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_nh", "DMnhCKTM", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_CKTM1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CKTM1.Text = DrReturn.Item("Ma_nh")
            TxtTen_nhCKTM1.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_CKTM1.Text = ""
            TxtTen_nhCKTM1.Text = ""
        End If
    End Sub

#End Region

#Region "Valid"

    Private Sub V_Nh_CKTM2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_nh", "DMnhCKTM", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_CKTM2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CKTM2.Text = DrReturn.Item("Ma_nh")
            TxtTen_nhCKTM2.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_CKTM2.Text = ""
            TxtTen_nhCKTM2.Text = ""
        End If
    End Sub

#End Region
#Region "Valid"

    Private Sub V_Nh_CKTM3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_nh", "DMnhCKTM", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_CKTM3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CKTM3.Text = DrReturn.Item("Ma_nh")
            TxtTen_nhCKTM3.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNh_CKTM3.Text = ""
            TxtTen_nhCKTM3.Text = ""
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

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub TxtMa_Dvcs_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtMa_Dvcs.TextChanged

    End Sub
End Class
