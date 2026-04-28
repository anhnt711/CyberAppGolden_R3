Public Class GLAnalysisKQKD
    Dim CyberMe As New Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam, _DtMa_Ky As DataTable
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Dim M_So_ky As String = "3"
    Private Sub GLAnalysisKQKD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim M_VT_PARA As Integer = CType(Me.Para(0).Trim, Integer)
        Try
            M_So_ky = Me.Para(M_VT_PARA + 2)
        Catch ex As Exception
        End Try

        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
        V_VisibleDate()
    End Sub
#Region "Load"
    Private Sub V_VisibleDate()
        If CbbMa_Ky.SelectedValue < "03" Then
            LabThang.Visible = False
            CbbM_Thang1.Visible = False
            LabNam.Visible = False
            CbbM_Nam.Visible = False
            LabNgay.Visible = True
            TxtM_Ngay_Ct1.Visible = True
        Else
            LabThang.Visible = True
            CbbM_Thang1.Visible = True
            LabNam.Visible = True
            CbbM_Nam.Visible = True
            LabNgay.Visible = False
            TxtM_Ngay_Ct1.Visible = False
        End If
    End Sub
    Private Sub V_Load()
        TxtM_Ngay_Ct1.Value = Now.Date()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)

        Dim _DsMaKy As DataSet
        _DsMaKy = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "DmkyBC#Acti = N'1'#ID")
        _DtMa_Ky = _DsMaKy.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_Ky, _DtMa_Ky, "ID", If(Me.LAN = "V", "Title", "Title2"), "Default")
        '---------------------------
        '--------------------------------------------------------------------------------------------------------------------------------------
        DtThang1 = CreateTableMonth()
        DtThang2 = CreateTableMonth()
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang1, DtThang1, "Thang", IIf(Me.LAN = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.LAN = "V", "Ten_Nam", "Ten_nam2"), "Default")
        Me.CyberSmodb.GetValueToControler(Me)

        TxtSo_Ky.Double = M_So_ky
    End Sub
    Private Function CreateTableMonth() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Thang")
        _Return.Columns.Add("Ten_Thang")
        _Return.Columns.Add("Ten_Thang2")
        _Return.Columns.Add("Default")
        Dim _Thang As String = ""
        Dim _Default As String = "0"

        For i As Integer = 1 To 12
            _Thang = Strings.Right("00" + i.ToString.Trim, 2).Trim
            If Now.Date.Month = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Thang.ToString, "Tháng " + _Thang, "Month " + _Thang, _Default)
        Next
        CreateTableMonth = _Return
    End Function
    Private Function CreateTableYear() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Nam")
        _Return.Columns.Add("Ten_Nam")
        _Return.Columns.Add("Ten_Nam2")
        _Return.Columns.Add("Default")

        Dim _CurYear As Integer = Now.Year

        Dim _Nam As String = ""
        Dim _Default As String = "0"

        For i As Integer = _CurYear - 10 To _CurYear + 10
            _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim

            If Now.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, " " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit

        RemoveHandler CbbMa_Ky.SelectedIndexChanged, AddressOf V_CbbMa_Ky
        AddHandler CbbMa_Ky.SelectedIndexChanged, AddressOf V_CbbMa_Ky

    End Sub
#End Region
#Region "Valid"
    Private Sub V_CbbMa_Ky(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_VisibleDate()
    End Sub
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim _Ma_Ky As String = Me.CbbMa_Ky.SelectedValue.ToString.Trim
        Dim _Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = _Ma_Ky
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_Ky.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & Me.CbbM_Thang1.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & Me.CbbM_Nam.SelectedValue.ToString.Trim

        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Dvcs_Filter
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
