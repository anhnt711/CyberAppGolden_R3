Public Class GLKHNS
    Dim CyberMe As New Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam, DtFile_MauBC As DataTable
    Dim _Ma_MauBC As String = ""
    Private Sub QLKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim M_VT_PARA As Integer = CType(Me.Para(0).Trim, Integer)


        _Ma_MauBC = Me.Para(M_VT_PARA + 2)
        'Dim dstmp As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SYSEXECUTE", "SELECT File_mauBC,ten_MauBC,ten_MauBC2,Ngam_Dinh FROM dbo.DmMauBC WHERE Ma_MauBC = '" + _Ma_MauBC.Trim + "' ORDER BY File_MauBC#" + Ma_Dvcs + "#" + User_Name)
        Dim dstmp As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_SYSEXECUTE", "SELECT File_mauBC,ten_MauBC,ten_MauBC2,Ngam_Dinh FROM dbo.DmMauBC WHERE " + _Ma_MauBC + " ORDER BY File_MauBC#" + Ma_Dvcs + "#" + User_Name)
        DtFile_MauBC = dstmp.Tables(0).Copy
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        V_AddMenuShorcut()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        DtUnists = CyberMe.V_GetUnists(AppConn, Ma_Dvcs, User_Name, CyberSmLib)
        DtThang1 = CreateTableMonth()
        DtThang2 = CreateTableMonth()
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang1, DtThang1, "Thang", IIf(Me.LAN = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Thang2, DtThang2, "Thang", IIf(Me.LAN = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.LAN = "V", "Ten_Nam", "Ten_nam2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbFile_MauBC, DtFile_MauBC, "File_MauBC", "Ten_mauBC", "Ngam_Dinh")
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
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

#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim TH1 As String = CbbM_Thang1.SelectedValue.ToString.Trim
        Dim TH2 As String = CbbM_Thang2.SelectedValue.ToString.Trim
        Dim NAM As String = CbbM_Nam.SelectedValue.ToString.Trim
        Dim MAU_BC As String = ""
        Try
            MAU_BC = CbbFile_MauBC.SelectedValue.ToString.Trim()
        Catch ex As Exception

        End Try
        If MAU_BC.Trim = "" Then
            MsgBox("Bạn chưa chọn mẫu báo cáo", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, sysvar("M_CYBER_VER"))
            Exit Sub
        End If

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = MAU_BC
        
        M_strParameterStore = M_strParameterStore & "#" & TH1 & "#" & TH2 & "#" & NAM
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
#Region "MONTH_YEAR"
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
            _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
#End Region
End Class
