Public Class DmToSC
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa As DataTable
    Private _Load_TP As Boolean = False
    Dim dt_Loai_To As DataTable
    Private Sub FDMKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load_TP = False
        V_GetChkErro()
        '-------------------------------------------------
        V_FillLoai_To()
        '-------------------------------------------------
        V_Load()
        If Mode.Trim = "M" Then ChkIs_TienDo.Checked = True
        If Mode.Trim = "M" Then ChkIs_ConFlict.Checked = False
        TxtMa_To.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
    End Sub
#Region "Load"
    Private Sub V_FillLoai_To()
        dt_Loai_To = New DataTable
        dt_Loai_To.Columns.Add("Loai_To")
        dt_Loai_To.Columns.Add("Ten")
        dt_Loai_To.Columns.Add("Ten2")
        dt_Loai_To.Columns.Add("Ngam_Dinh")

        dt_Loai_To.Rows.Add("0", "Chưa xác định", "Non", "1")
        dt_Loai_To.Rows.Add("1", "Tổ sơn", "Depar Paint", "0")
        dt_Loai_To.Rows.Add("2", "Tổ đồng", "Depar background", "0")
        dt_Loai_To.Rows.Add("3", "Khác", "Other", "0")
        CyberFill.V_FillComBoxDefaul(Me.CmbLoai_To, dt_Loai_To, "Loai_To", "Ten", "Ngam_Dinh")
    End Sub
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        TxtTen_khoang.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_khoang", "Dmkhoang", "ma_khoang = N'" + Txtma_khoang.Text + "'", CyberSmlib)
        TxtTen_cd.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_cd", "Dmcdsc", "ma_cd = N'" + Txtma_cd.Text + "'", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        ''--to
        RemoveHandler TxtMa_To.CyberValiting, AddressOf V_Ma_to
        RemoveHandler TxtMa_To.CyberLeave, AddressOf L_Ma_to
        AddHandler TxtMa_To.CyberValiting, AddressOf V_Ma_to
        AddHandler TxtMa_To.CyberLeave, AddressOf L_Ma_to
        ''--khoang
        RemoveHandler Txtma_khoang.CyberValiting, AddressOf V_Ma_khoang
        RemoveHandler Txtma_khoang.CyberLeave, AddressOf L_Ma_khoang
        AddHandler Txtma_khoang.CyberValiting, AddressOf V_Ma_khoang
        AddHandler Txtma_khoang.CyberLeave, AddressOf L_Ma_khoang
        ''--cong doan
        RemoveHandler Txtma_cd.CyberValiting, AddressOf V_Ma_cd
        RemoveHandler Txtma_cd.CyberLeave, AddressOf L_Ma_cd
        AddHandler Txtma_cd.CyberValiting, AddressOf V_Ma_cd
        AddHandler Txtma_cd.CyberLeave, AddressOf L_Ma_cd
    End Sub
#End Region
#Region "Vali --- Ma_to"
    Private Sub V_Ma_to(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_to.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_to(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_to.Text = "" Then
            TxtTen_to.Text = ""
            TxtTen_To2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_to.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_to.Text = DrReturn.Item("Ma_BP")
            TxtTen_to.Text = DrReturn.Item("Ten_BP")
            TxtTen_To2.Text = DrReturn.Item("Ten_BP2")
        Else
            TxtMa_to.Text = ""
            TxtTen_to.Text = ""
            TxtTen_To2.Text = ""
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
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_to.Text = _Value
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
