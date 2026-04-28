Public Class CRM_VOD01
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DtMaGD, DtGroup As DataTable
    Dim DvGroup As DataView
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet

    Private Sub CRM_VOD01_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_GetData()

        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        Dim _Str As String = "	SELECT * FROM (SELECT '' as Ma_GD,N'Toàn bộ' as ten_GD,N'Toàn bộ' as ten_GD2,'1' as Ngam_Dinh	UNION ALL(SELECT Ma_GD,Ten_GD,Ten_GD2,'0' as Ngam_Dinh FROM dbo.DmMaGD WHERE ma_ct = 'VOD')) as a ORDER BY a.ma_GD"
        Dim _DsMa_Gd As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", _Str + "#" + Me.Ma_Dvcs & "#" & Me.User_Name)
        DtMaGD = _DsMa_Gd.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_GD, DtMaGD, "ma_GD", "Ten_GD", "Default")
        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_GetData()
        Dim DsTmp As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_CRM_VOC_VOD_Filter", Me.Ma_Dvcs + "#" + Me.User_Name)
        If DsTmp.Tables.Count >= 1 Then DtGroup = DsTmp.Tables(0).Copy
        If Not DtGroup Is Nothing Then DvGroup = New DataView(DtGroup)
        CyberFill.V_FillComBoxDefaul(CbbGroupByTH, DtGroup, "Ma", "Ten", "Default")
        '------------------------------------------------------------------------------------------------------------------------------------------------
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
        Dim _Ngay_Ct1 As Date = TxtM_Ngay_Ct1.Value
        Dim _Ngay_Ct2 As Date = TxtM_Ngay_Ct2.Value
        Dim _Loai As String = ""
        Dim _Ma_Loai As String = ""
        Dim _Ma_Ngay As String = ""

        Dim _Ma_TH As String = CyberSmodb.GetvalueFromCombox(CbbGroupByTH)
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_Ma_GD_Filter As String = Me.CbbMa_GD.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = _Ma_TH & "#" & M_Ma_GD_Filter
        M_strParameterStore = M_strParameterStore & "#" & _Ngay_Ct1.ToString("yyyyMMdd") & "#" & _Ngay_Ct2.ToString("yyyyMMdd")
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
