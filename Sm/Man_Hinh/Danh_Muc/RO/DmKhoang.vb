Public Class DmKhoang
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa As DataTable
    Private _Load_TP As Boolean = False
    Dim DmTang As New DataTable
    Private Sub FDMKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load_TP = False
        V_GetChkErro()
        DmTang.Columns.Add("Tang")
        DmTang.Columns.Add("Ten_Tang")
        DmTang.Columns.Add("Ten_Tang2")
        DmTang.Columns.Add("Ngam_Dinh")
        DmTang.Rows.Add("1", "Tầng 1", "Floor 1", "1")
        DmTang.Rows.Add("2", "Tầng 2", "Floor 2", "0")
        DmTang.Rows.Add("3", "Tầng 3", "Floor 3", "0")
        DmTang.Rows.Add("4", "Tầng 4", "Floor 4", "0")
        DmTang.Rows.Add("5", "Tầng 5", "Floor 5", "0")
        DmTang.Rows.Add("6", "Tầng 6", "Floor 6", "0")
        DmTang.Rows.Add("7", "Tầng 7", "Floor 7", "0")
        DmTang.Rows.Add("8", "Tầng 8", "Floor 8", "0")

        CyberFill.V_FillComBoxValue(CBBTang, DmTang, "Tang", If(M_LAN = "V", "Ten_Tang", "Ten_Tang2"), "1")

        V_Load()
        If Mode.Trim = "M" Then ChkIs_TienDo.Checked = True
        If Mode.Trim = "M" Then ChkIs_ConFlict.Checked = False

        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_khoang, TxtNh_khoang1, TxtNh_khoang2, TxtNh_khoang3, TxtNh_khoang4, TxtNh_khoang5)
        _Load_TP = True
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)

        If TxtNh_khoang1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKhoang", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_khoang1.Text.Trim + "')", CyberSmlib)
        If TxtNh_khoang2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKhoang", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_khoang2.Text.Trim + "')", CyberSmlib)
        If TxtNh_khoang3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKhoang", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_khoang3.Text.Trim + "')", CyberSmlib)
        If TxtNh_khoang4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKhoang", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_khoang4.Text.Trim + "')", CyberSmlib)
        If TxtNh_khoang5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKhoang", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_khoang5.Text.Trim + "')", CyberSmlib)
        TxtTen_to.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_To", "DmToSC", "ma_To = N'" + TxtMa_to.Text + "'", CyberSmlib)
        TxtTen_cd.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_cd", "Dmcdsc", "ma_cd = N'" + Txtma_cd.Text + "'", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--Ma Khoang
        RemoveHandler TxtMa_khoang.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_khoang.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Khoang1
        RemoveHandler TxtNh_khoang1.CyberValiting, AddressOf V_Nh_Khoang1
        RemoveHandler TxtNh_khoang1.CyberLeave, AddressOf L_Nh_Khoang1
        AddHandler TxtNh_khoang1.CyberValiting, AddressOf V_Nh_Khoang1
        AddHandler TxtNh_khoang1.CyberLeave, AddressOf L_Nh_Khoang1
        '--BP2
        RemoveHandler TxtNh_khoang2.CyberValiting, AddressOf V_Nh_Khoang2
        RemoveHandler TxtNh_khoang2.CyberLeave, AddressOf L_Nh_Khoang2
        AddHandler TxtNh_khoang2.CyberValiting, AddressOf V_Nh_Khoang2
        AddHandler TxtNh_khoang2.CyberLeave, AddressOf L_Nh_Khoang2
        '--BP3
        RemoveHandler TxtNh_khoang3.CyberValiting, AddressOf V_Nh_Khoang3
        RemoveHandler TxtNh_khoang3.CyberLeave, AddressOf L_Nh_Khoang3
        AddHandler TxtNh_khoang3.CyberValiting, AddressOf V_Nh_Khoang3
        AddHandler TxtNh_khoang3.CyberLeave, AddressOf L_Nh_Khoang3
        '--BP4
        RemoveHandler TxtNh_khoang4.CyberValiting, AddressOf V_Nh_Khoang4
        RemoveHandler TxtNh_khoang4.CyberLeave, AddressOf L_Nh_Khoang4
        AddHandler TxtNh_khoang4.CyberValiting, AddressOf V_Nh_Khoang4
        AddHandler TxtNh_khoang4.CyberLeave, AddressOf L_Nh_Khoang4
        '--BP5
        RemoveHandler TxtNh_khoang5.CyberValiting, AddressOf V_Nh_Khoang5
        RemoveHandler TxtNh_khoang5.CyberLeave, AddressOf L_Nh_Khoang5
        AddHandler TxtNh_khoang5.CyberValiting, AddressOf V_Nh_Khoang5
        AddHandler TxtNh_khoang5.CyberLeave, AddressOf L_Nh_Khoang5

        ''--to
        RemoveHandler TxtMa_to.CyberValiting, AddressOf V_Ma_to
        RemoveHandler TxtMa_to.CyberLeave, AddressOf L_Ma_to
        AddHandler TxtMa_to.CyberValiting, AddressOf V_Ma_to
        AddHandler TxtMa_to.CyberLeave, AddressOf L_Ma_to
        ''--cong doan
        RemoveHandler Txtma_cd.CyberValiting, AddressOf V_Ma_cd
        RemoveHandler Txtma_cd.CyberLeave, AddressOf L_Ma_cd
        AddHandler Txtma_cd.CyberValiting, AddressOf V_Ma_cd
        AddHandler Txtma_cd.CyberLeave, AddressOf L_Ma_cd

        ''--to
        RemoveHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        RemoveHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
    End Sub
#End Region
#Region "Vali --- Nh_Khoang1"
    Private Sub V_Nh_Khoang1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_khoang1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKhoang", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Khoang1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_khoang1.GetRowsSelectData(True)
        If TxtNh_khoang1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_khoang1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_khoang1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Khoang2"
    Private Sub V_Nh_Khoang2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Khoang2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKhoang", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Khoang2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Khoang2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Khoang2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Khoang2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Khoang2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Khoang3"
    Private Sub V_Nh_Khoang3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Khoang3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKhoang", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Khoang3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Khoang3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Khoang3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Khoang3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Khoang3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Khoang4"
    Private Sub V_Nh_Khoang4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Khoang4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKhoang", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_Khoang4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Khoang4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Khoang4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Khoang4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Khoang4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Khoang5"
    Private Sub V_Nh_Khoang5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Khoang5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKhoang", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_Khoang5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Khoang5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Khoang5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Khoang5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Khoang5.Text = ""
            TxtTen_Nh5.Text = ""
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
            Exit Sub
        End If
        DrReturn = TxtMa_to.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_to.Text = DrReturn.Item("Ma_to")
            TxtTen_to.Text = DrReturn.Item("Ten_to")
        Else
            TxtMa_to.Text = ""
            TxtTen_to.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_cd"
    Private Sub V_Ma_cd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtma_cd.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_cd", "DmCDSC", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_cd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Txtma_cd.Text = "" Then
            TxtTen_cd.Text = ""
        End If
        DrReturn = Txtma_cd.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_cd.Text = DrReturn.Item("Ma_cd")
            TxtTen_cd.Text = DrReturn.Item("Ten_cd")
        Else
            Txtma_cd.Text = ""
            TxtTen_cd.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Hs.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Hs", "DmKTVSC", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Txtma_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
        End If
        DrReturn = Txtma_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            Txtma_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_khoang.Text = _Value
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
