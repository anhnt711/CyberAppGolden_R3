Public Class RO_KPI_Moc_TG
    Dim _DtLoai_SC, _DtLoai_BC2 As DataTable
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Private Sub ROBCCSDLDV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '--
        Dim _DsLoai_SC As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'Loai_SC' AND Acti = N'1'#ID")
        _DtLoai_SC = _DsLoai_SC.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbLoai_SC, _DtLoai_SC, "Nhom", "Ten_nhom")

        'Dim _DsLoai_BC2 As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'Loai_BC' AND Acti = N'1'#ID")
        '_DtLoai_BC2 = _DsLoai_BC2.Tables(0).Copy
        'CyberFill.V_FillComBoxDefaul(Me.CbbLoai_BC2, _DtLoai_BC2, "Nhom", "Ten_nhom")
        Dim _Return As New DataTable
        _Return.Columns.Add("ID")
        _Return.Columns.Add("Nhom")
        _Return.Columns.Add("Ten_Nhom")
        _Return.Columns.Add("Default")
        _Return.Rows.Add("0", "0", "Tất cả", "1")
        _Return.Rows.Add("1", "1", "Lệnh đã quyết toán", "0")
        _Return.Rows.Add("2", "2", "Lệnh chưa quyết toán", "0")

        CyberFill.V_FillComBoxDefaul(Me.CbbLoai_BC2, _Return, "Nhom", "Ten_nhom", "Default")
        '----Set
        Dim _Return2 As New DataTable
        _Return2.Columns.Add("ID")
        _Return2.Columns.Add("Ten")
        _Return2.Columns.Add("Default")

        _Return2.Rows.Add("1", "Ngày tạo lệnh", "1")
        _Return2.Rows.Add("2", "Ngày sửa chữa", "0")
        _Return2.Rows.Add("3", "Ngày nghiệm thu", "0")
        _Return2.Rows.Add("4", "Ngày xe vào", "0")
        _Return2.Rows.Add("5", "Ngày xe ra", "0")

        
        CyberFill.V_FillComBoxDefaul(Me.CbbNgay_Theo, _Return2, "ID", "Ten", "Default")

        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
    End Sub
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim _Loai_Theo As String = Me.CbbNgay_Theo.SelectedValue.ToString.Trim
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim Loai_SC_Filter As String = Me.CbbLoai_SC.SelectedValue.ToString.Trim
        Dim Loai_BC2_Filter As String = Me.CbbLoai_BC2.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & _Loai_Theo.Trim
        M_strParameterStore = M_strParameterStore & "#" & Loai_SC_Filter
        M_strParameterStore = M_strParameterStore & "#" & Loai_BC2_Filter
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
