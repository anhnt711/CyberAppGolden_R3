Public Class DMNOT
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
        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhNot", "(Ma_Nh = '1' AND Ma_Nh = N'" + TxtNh_not1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhNot", "(Ma_Nh = '2' AND Ma_Nh = N'" + TxtNh_not2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhNot", "(Ma_Nh = '3' AND Ma_Nh = N'" + TxtNh_not3.Text.Trim + "')", CyberSmlib)
        TxtTen_tuyen.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_tuyen", "DmTuyen", "(Ma_tuyen=   N'" + TxtMa_tuyen.Text.Trim + "')", CyberSmlib)
        '    'TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_ve2.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        AddHandler TxtNh_not1.CyberValiting, AddressOf V_Nh_not1
        AddHandler TxtNh_not1.CyberLeave, AddressOf L_Nh_not1

        AddHandler TxtNh_not2.CyberValiting, AddressOf V_Nh_not2
        AddHandler TxtNh_not2.CyberLeave, AddressOf L_Nh_not2

        AddHandler TxtNh_not3.CyberValiting, AddressOf V_Nh_not3
        AddHandler TxtNh_not3.CyberLeave, AddressOf L_Nh_not3

        AddHandler TxtMa_tuyen.CyberValiting, AddressOf V_Ma_tuyen
        AddHandler TxtMa_tuyen.CyberLeave, AddressOf L_Ma_tuyen


    End Sub
#End Region


#Region "Valid"

    Private Sub V_Nh_not1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhNot", "1=1", "Ma_Nh = '1'")
    End Sub
    Private Sub L_Nh_not1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_not1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_not1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub

#End Region
#Region "Valid"

    Private Sub V_Nh_not2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhNot", "1=1", "Ma_Nh = '2'")
    End Sub
    Private Sub L_Nh_not2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_not2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_not2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub

#End Region
#Region "Valid"

    Private Sub V_Nh_not3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhNot", "1=1", "Ma_Nh = '3'")
    End Sub
    Private Sub L_Nh_not3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_not3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_not3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub

#End Region
#Region "Valid"

    Private Sub V_Ma_tuyen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_tuyen", "DmTuyen", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_tuyen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_tuyen.Text = DrReturn.Item("Ma_tuyen")
            TxtTen_tuyen.Text = DrReturn.Item("Ten_tuyen")
        Else
            TxtMa_tuyen.Text = ""
            TxtTen_tuyen.Text = ""
        End If
    End Sub

#End Region


#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_not.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
