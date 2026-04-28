Public Class DTB03
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim _DtGroupBy As DataTable
    Dim __DtGroupBy As DataTable
    Private Sub DTB03_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        __DtGroupBy = GetGroupBy()
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Function GetGroupBy() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("LoaiBC")
        _Return.Columns.Add("Ten_BC")
        _Return.Columns.Add("Ten_BC2")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("1", "Chi tiết", "Chi tiết", "1")
        _Return.Rows.Add("0", "Không chi tiết", "Không chi tiết", "0")
        GetGroupBy = _Return
    End Function
    Private Sub V_Load()
        CyberFill.V_FillComBoxDefaul(Me.CbbLoaiBC, __DtGroupBy, "LoaiBC", "Ten_BC", "Ngam_Dinh")
        Dim _DsGroup As New DataSet
        _DsGroup = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "DMMauBC#Ma_MauBC= N'DTB03'#Ma_MauBC")
        _DtGroupBy = _DsGroup.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbDmMauBc, _DtGroupBy, "FILE_MAUBC", "TEN_MAUBC", "Ngam_Dinh")
        V_AddMenuShorcut()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)




        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

    End Sub
#End Region
#Region "Valid"


#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbDmMauBc.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & CbbLoaiBC.SelectedValue.ToString.Trim
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
