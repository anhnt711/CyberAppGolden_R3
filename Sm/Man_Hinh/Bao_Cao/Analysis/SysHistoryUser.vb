Public Class SysHistoryUser
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtGroupBy As DataTable
    Dim _GroupByTH, _GroupByCT, _Dt_GD, _Dt_post1, _Dt_post2 As DataTable
    Dim _Ma_Loai As String
    Private Sub SysHistoryUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ChkDetail_OK.Checked = False
        TxtM_Ngay_CT1.Value = Now
        TxtM_Ngay_ct2.Value = Now
        _DtGroupBy = GetGroupBy()
        V_AddMenuShorcut()
        V_Load()
        V_Ma_Loai()
        V_VisibleCT()
        V_Addhander()

        TxtUser_name_Find.Text = Me.User_Name
        TxtComment.Text = Me.Comment

        TxtUser_name_Find.Enabled = Me.is_Admin
        TxtComment.Enabled = Me.is_Admin

    End Sub
#Region "Chi tiet theo"
    Private Sub V_VisibleCT()
        If ChkDetail_OK.Checked = True Then CbbGroupByCT.Visible = True Else CbbGroupByCT.Visible = False
    End Sub
    Private Sub V_Detail_OK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_VisibleCT()
    End Sub
#End Region
#Region "Load"
    Private Function GetGroupBy() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Tinh_dc")
        _Return.Columns.Add("Ten_DC")
        _Return.Columns.Add("Ten_Dc2")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("1", "Tính phát sinh điều chuyển", "Tính phát sinh điều chuyển", "1")
        _Return.Rows.Add("0", "Không tính phát sinh điều chuyển", "Không tính phát sinh điều chuyển", "0")
        GetGroupBy = _Return
    End Function

    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '-----------
        Dim DtMa_Loai As New DataTable
        DtMa_Loai.Columns.Add("Ma")
        DtMa_Loai.Columns.Add("Ten")
        DtMa_Loai.Columns.Add("Default")

        DtMa_Loai.Rows.Add("0", "Tất cả", "1")
        DtMa_Loai.Rows.Add("1", "Đăng nhập hệ thống", "0")
        DtMa_Loai.Rows.Add("2", "Chứng từ (Tạo mới/sửa/xóa/Duyệt chứng từ)", "0")
        DtMa_Loai.Rows.Add("3", "Danh mục (Tạo mới/sửa/xóa)", "0")

        CyberFill.V_FillComBoxDefaul(Me.CbbMa_Loai, DtMa_Loai, "Ma", "Ten", "Default")
        '----------



        TxtHostname.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtHostname)

        TxtMa_DM.Text = CyberSmodb.SQLGetvalue(AppConn, "Name", "Syslist", "(Name = N'" + TxtMa_DM.Text.Trim + "')", CyberSmLib)
        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '-------------
        RemoveHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK
        AddHandler ChkDetail_OK.CheckedChanged, AddressOf V_Detail_OK
        '-----------
        '--Vt1
        RemoveHandler TxtMa_DM.CyberValiting, AddressOf V_Name
        RemoveHandler TxtMa_DM.CyberLeave, AddressOf L_Name
        AddHandler TxtMa_DM.CyberValiting, AddressOf V_Name
        AddHandler TxtMa_DM.CyberLeave, AddressOf L_Name

        '----------
        AddHandler TxtMa_Ct.CyberValiting, AddressOf V_Ma_Ct
        AddHandler TxtMa_Ct.CyberLeave, AddressOf L_Ma_Ct
        '----
        AddHandler TxtUser_name_Find.CyberValiting, AddressOf V_User_name
        AddHandler TxtUser_name_Find.CyberLeave, AddressOf L_User_name

        AddHandler CbbMa_Loai.SelectedIndexChanged, AddressOf V_Ma_Loai
    End Sub


#End Region
    Private Sub V_Ma_Loai()
        _Ma_Loai = CbbMa_Loai.SelectedValue.ToString.Trim
        Dim _DsGroup As New DataSet
        _DsGroup = Nothing
        _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysHistoryUserSupport", _Ma_Loai + "#" + "" + "#" + "" + "#" + "" + "#" + Me.Ma_Dvcs + "#" + Me.User_Name)
        _GroupByTH = _DsGroup.Tables(0).Copy
        _GroupByCT = _DsGroup.Tables(1).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByTH, _GroupByTH, "Ma", "Ten")
        CyberFill.V_FillComBoxDefaul(Me.CbbGroupByCT, _GroupByCT, "Ma", "Ten")

        '-----------
        Dim DtMa_Status As New DataTable
        DtMa_Status.Columns.Add("Ma")
        DtMa_Status.Columns.Add("Ten")
        DtMa_Status.Columns.Add("Default")

        DtMa_Status.Rows.Add("", "Tất cả", "1")
        DtMa_Status.Rows.Add("M", "Tạo mới", "0")
        DtMa_Status.Rows.Add("S", "Sửa", "0")
        DtMa_Status.Rows.Add("D", "Xóa", "0")
        DtMa_Status.Rows.Add("A", "Duyệt", "0")

        If _Ma_Loai = "3" Then
            DtMa_Status.Rows.RemoveAt(4)
        End If
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_Status, DtMa_Status, "Ma", "Ten", "Default")

        If _Ma_Loai = "0" Then
            TxtMa_Ct.Enabled = True
            TxtMa_DM.Enabled = True
            CbbMa_Status.Enabled = True
            CbbMa_post1.Enabled = True
            CbbMa_post2.Enabled = True
        ElseIf _Ma_Loai = "1" Then
            TxtMa_Ct.Text = ""
            TxtTen_Ct.Text = ""
            TxtMa_DM.Text = ""
            txtTitle1.Text = ""
            CbbMa_Status.SelectedValue = ""
            CbbMa_post1.SelectedValue = ""
            CbbMa_post2.SelectedValue = ""
            TxtMa_Ct.Enabled = False
            TxtMa_DM.Enabled = False
            CbbMa_Status.Enabled = False
            CbbMa_post1.Enabled = False
            CbbMa_post2.Enabled = False
        ElseIf _Ma_Loai = "2" Then
            TxtMa_DM.Text = ""
            txtTitle1.Text = ""
            TxtMa_Ct.Enabled = True
            TxtMa_DM.Enabled = False
            CbbMa_Status.Enabled = True
            CbbMa_post1.Enabled = True
            CbbMa_post2.Enabled = True
        ElseIf _Ma_Loai = "3" Then
            TxtMa_Ct.Text = ""
            TxtTen_Ct.Text = ""
            TxtMa_Ct.Enabled = False
            TxtMa_DM.Enabled = True
            CbbMa_Status.Enabled = True
            CbbMa_post1.Enabled = False
            CbbMa_post2.Enabled = False

        End If



    End Sub
#Region "Valid"

#Region "Valid ---MA_Ct"
    Private Sub V_Ma_Ct(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Ct.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_CT", "DMCT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Ct(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Ct.Text = DrReturn.Item("Ma_Ct")
            TxtTen_Ct.Text = DrReturn.Item("Ten_Ct")
        Else
            TxtMa_Ct.Text = ""
            TxtTen_Ct.Text = ""
            Exit Sub
        End If
        Dim _MA_CT As String = ""
        _MA_CT = TxtMa_Ct.Text

        Dim _DsPost As New DataSet
        _DsPost = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", _MA_CT & "##")
        _Dt_post1 = _DsPost.Tables(0).Copy
        _Dt_post2 = _DsPost.Tables(1).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_post1, _Dt_post1, "ma_post", "Ten_post")
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_post2, _Dt_post2, "ma_post", "Ten_post")
    End Sub
#End Region
#Region "Valid ---User_name"
    Private Sub V_User_name(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtUser_name_Find.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "User_name", "Userinfo", "1=1", "1=1")
    End Sub
    Private Sub L_User_name(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtUser_name_Find.Text = DrReturn.Item("User_name")
            TxtComment.Text = DrReturn.Item("Comment")
        Else
            TxtUser_name_Find.Text = ""
            TxtComment.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- Name"
    Private Sub V_Name(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Name", "Syslist", "1=1", "1=1")
    End Sub
    Private Sub L_Name(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_DM.Text = "" Then
            txtTitle1.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_DM.Text = DrReturn.Item("Name")
            txtTitle1.Text = DrReturn.Item("Title1")
        Else
            TxtMa_DM.Text = ""
            txtTitle1.Text = ""
        End If
    End Sub
#End Region


#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        If CyberMe.V_GetValueCombox(CbbGroupByTH).ToString.Trim = "" Then
            MsgBox("Chưa chọn tổng hợp theo tiêu thức nào", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            CbbGroupByTH.Focus()
            Exit Sub
        End If
        If ChkDetail_OK.Checked And CyberMe.V_GetValueCombox(CbbGroupByCT).ToString.Trim = "" Then
            MsgBox("Chưa chọn tiêu thức chi tiết", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            CbbGroupByCT.Focus()
            Exit Sub
        End If
        If ChkDetail_OK.Checked And CyberMe.V_GetValueCombox(CbbGroupByCT).ToString.Trim.ToUpper = CyberMe.V_GetValueCombox(CbbGroupByTH).ToString.Trim.ToUpper Then
            MsgBox("Hai tiêu thức tổng hợp và chi tiết không thể giống nhau", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            CbbGroupByTH.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------
        Dim _Ngay_CT1 As Date = TxtM_Ngay_CT1.Value
        Dim _Ngay_CT2 As Date = TxtM_Ngay_ct2.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = CbbGroupByTH.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & If(ChkDetail_OK.Checked, CbbGroupByCT.SelectedValue.ToString.Trim, "")
        M_strParameterStore = M_strParameterStore & "#" & _Ngay_CT1.ToString("yyyyMMdd HH:mm") & "#" & _Ngay_CT2.ToString("yyyyMMdd HH:mm").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtUser_name_Find.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtHostname.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Ct.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_DM.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbMa_Loai.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbMa_Status.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.V_GetValueCombox(CbbMa_post1)
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.V_GetValueCombox(CbbMa_post2)
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & Me.User_Name.Trim
        '-----------------------------------------------------------------------------
        Me.is_continue = True
        Dim M_strFieldValue As String = ""
        Dim M_strFieldName As String = ""
        CyberSmodb.GetValueControler(Me, M_strFieldName, M_strFieldValue, "")
        Me.Tag_Field = M_strFieldName
        Me.Tag_Value = M_strFieldValue
        CyberSmLib.SaveRegistry(Me, Me.sysvar)
        Me.Tag = M_strParameterStore
        Me.Close()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_AddMenuShorcut()
        Dim mnItems = New ContextMenu
        Dim mnItemsNhan As New MenuItem(IIf(Me.LAN = "V", "Chấp nhận", "OK"), AddressOf V_Nhan, Keys.Control + Keys.Enter)
        Dim mnItemsExit As New MenuItem(IIf(Me.LAN = "V", "Quay ra", "Exit"), AddressOf V_Exit, Keys.Escape)
        mnItems.MenuItems.Add(mnItemsNhan)
        mnItems.MenuItems.Add(mnItemsExit)
        Me.ContextMenu = mnItems
    End Sub
#End Region
End Class
