Public Class GLTC6ND
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DtThang, DtNam As DataTable
    Dim DtDmMauBc As DataTable
    Dim _DsTmp As DataSet
    Private Sub GLTC6ND_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DtThang = CyberSmodb.OpenTableKey(AppConn, _DsTmp, "Dmthang", "Id_Date", "1=1", CyberSmLib)
        DtNam = CreateTableYear()
        DtDmMauBc = CyberSmodb.OpenTableKey(AppConn, _DsTmp, "DmMauBC", "FILE_MauBC", "Acti=N'1' AND Ma_mauBc =N'GLTC6'", CyberSmLib)
        ''---------------------------------------------
        Dim _ThangDefaul As String = Strings.Right("00" & Now.Month.ToString.Trim, 2)
        CyberFill.V_FillComBoxValue(CbbM_Thang, DtThang, "Id_Date", IIf(Me.LAN = "V", "Caption0", "Caption1"), _ThangDefaul)
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.LAN = "V", "Ten_Nam", "Ten_nam2"), "Default")
        CyberFill.V_FillComBoxDefaul(Me.CbbDmMauBc, DtDmMauBc, "File_MauBC", IIf(Me.LAN = "V", "Ten_mauBC", "Ten_MauBc2"), "Ngam_Dinh")

        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
        RBU01.Checked = True
        RBU02.Checked = False
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub

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
        Dim _MauBc As String = ""
        Try
            _MauBc = CbbDmMauBc.SelectedValue.ToString.Trim()
        Catch ex As Exception
        End Try
        If _MauBc.Trim = "" Then
            CbbDmMauBc.Focus()
            Exit Sub
        End If

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = CbbM_Thang.SelectedValue.ToString.Trim & "#" & CbbM_Nam.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & If(RBU01.Checked, "1", "2")
        M_strParameterStore = M_strParameterStore & "#" & _MauBc.Trim
        M_strParameterStore = M_strParameterStore & "#" & ""
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
