Public Class DmKTVSC
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa As DataTable
    Private _Load_TP As Boolean = False
    Private Sub FDMKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load_TP = False
        V_GetChkErro()

        V_Load()
        If Mode.Trim = "M" Then ChkIs_TienDo.Checked = True
        If Mode.Trim = "M" Then ChkIs_ConFlict.Checked = False
        TxtMa_To.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        TxtTen_to.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_To", "DmToSC", "ma_To = N'" + TxtMa_to.Text + "'", CyberSmlib)
        TxtTen_khoang.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_Khoang", "DmKhoang", "Ma_Khoang = N'" + Txtma_khoang.Text + "'", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        ''--HS
        RemoveHandler TxtMa_hs.CyberValiting, AddressOf V_Ma_hs
        RemoveHandler TxtMa_hs.CyberLeave, AddressOf L_Ma_hs
        AddHandler TxtMa_hs.CyberValiting, AddressOf V_Ma_hs
        AddHandler TxtMa_hs.CyberLeave, AddressOf L_Ma_hs

        ''--to
        RemoveHandler TxtMa_to.CyberValiting, AddressOf V_Ma_to
        RemoveHandler TxtMa_to.CyberLeave, AddressOf L_Ma_to
        AddHandler TxtMa_to.CyberValiting, AddressOf V_Ma_to
        AddHandler TxtMa_to.CyberLeave, AddressOf L_Ma_to
        ''--khoang
        RemoveHandler Txtma_khoang.CyberValiting, AddressOf V_Ma_khoang
        RemoveHandler Txtma_khoang.CyberLeave, AddressOf L_Ma_khoang
        AddHandler Txtma_khoang.CyberValiting, AddressOf V_Ma_khoang
        AddHandler Txtma_khoang.CyberLeave, AddressOf L_Ma_khoang

    End Sub
#End Region
#Region "Vali --- Ma_hs"
    Private Sub V_Ma_hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_hs.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_hs", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_hs.Text = "" Then
            TxtTen_hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_hs.Text = DrReturn.Item("Ma_hs")
            TxtTen_hs.Text = DrReturn.Item("Ten_hs")
        Else
            TxtMa_hs.Text = ""
            TxtTen_hs.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_to"
    Private Sub V_Ma_to(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_to.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_to", "DmToSC", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_to(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_to.Text = "" Then
            TxtTen_to.Text = ""
            ChkIs_TienDo.Checked = False
            Chkis_SCC.Checked = False
            Chkis_SDS.Checked = False
            Exit Sub
        End If
        DrReturn = TxtMa_to.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_to.Text = DrReturn.Item("Ma_to")
            TxtTen_to.Text = DrReturn.Item("Ten_to")
            ChkIs_TienDo.Checked = DrReturn.Item("Is_TienDo")
            Chkis_SCC.Checked = DrReturn.Item("is_SCC")
            Chkis_SDS.Checked = DrReturn.Item("is_SDS")
        Else
            TxtMa_to.Text = ""
            TxtTen_to.Text = ""
            ChkIs_TienDo.Checked = False
            Chkis_SCC.Checked = False
            Chkis_SDS.Checked = False
        End If
    End Sub
#End Region
#Region "Vali --- Ma_khoang"
    Private Sub V_Ma_khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_khoang.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_khoang", "Dmkhoang", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_khoang.Text = "" Then
            TxtTen_khoang.Text = ""
        End If
        DrReturn = TxtMa_khoang.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_khoang.Text = DrReturn.Item("Ma_khoang")
            TxtTen_khoang.Text = DrReturn.Item("Ten_khoang")
        Else
            TxtMa_khoang.Text = ""
            TxtTen_khoang.Text = ""
        End If
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_to.Text = _Value
        If TxtMa_to.Text = "" Then
            TxtMa_to.Focus()
            Return
        End If
        If TxtMa_hs.Text = "" Then
            TxtMa_hs.Focus()
            Return
        End If
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
