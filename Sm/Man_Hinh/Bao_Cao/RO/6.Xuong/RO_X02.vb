Public Class RO_X02
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtLoai_SC As DataTable
    Private Sub RO_X02_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_Addhander()
        TxtM_Ngay_Ct1.Select()
    End Sub
#Region "Load"
    Private Sub V_Load()
        V_AddMenuShorcut()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        TxtMa_Khoang.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Khoang)
        TxtSo_RO.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtSo_RO)
        TxtMa_Xe.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Xe)


        If TxtMa_Khoang.Text.Trim = "" Then TxtTen_khoang.Text = "" Else TxtTen_khoang.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_khoang", "DmKhoang", "Ma_khoang = N'" + TxtMa_Khoang.Text.Trim + "'", CyberSmLib)
        '-----Loại SC
        Dim _DsLoai_Sc As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'Loai_SC' AND Acti = N'1'#ID")
        DtLoai_SC = _DsLoai_Sc.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CBBLoai_SC, DtLoai_SC, "Nhom", "Ten_nhom")

        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        '--Ma_khoang
        AddHandler TxtMa_Khoang.CyberValiting, AddressOf V_Ma_Khoang
        AddHandler TxtMa_Khoang.CyberLeave, AddressOf L_Ma_Khoang

        '-- Ma Xe
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe

    End Sub
#End Region
#Region "Valid"

#Region "Valid --- Ma_Khoang"
    Private Sub V_Ma_Khoang(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Khoang.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Khoang", "DmKhoang", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Khoang(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Khoang.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Khoang.Text = DrReturn.Item("Ma_Khoang")
            TxtTen_khoang.Text = DrReturn.Item("Ten_Khoang")
        Else
            TxtMa_Khoang.Text = ""
            TxtTen_khoang.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Xe"
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        'TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _strField As String = ""
        Dim _strvalue As String = ""

        CyberSmodb.GetValueControler(Me, _strField, _strvalue)

        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim _M_Loai_Sc As String = Me.CBBLoai_SC.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & _strField
        M_strParameterStore = M_strParameterStore & "#" & _strvalue
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
