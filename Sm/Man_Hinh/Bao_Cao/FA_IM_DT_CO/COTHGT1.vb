Public Class COTHGT1
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable
    Private Sub COTHGT1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)

        '----Set

        DtThang1 = CreateTableMonth()
        DtThang2 = DtThang1.Copy
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang1, DtThang1, "Thang", IIf(Me.LAN = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Thang2, DtThang2, "Thang", IIf(Me.LAN = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.LAN = "V", "Ten_Nam", "Ten_nam2"), "Default")

        '
        TxtTK.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtTK)
        TxtMa_vt.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_vt)
        TxtMa_Cd.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Cd)
        


        TxtTen_TK.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_tk0", "Dmtk0", "(tk0= N'" + TxtTK.Text.Trim + "')", CyberSmLib)
        If TxtMa_vt.Text.Trim = "" Then TxtTen_vt.Text = "" Else TxtTen_vt.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Vt", "DmVt", "(Ma_Vt= N'" + TxtMa_vt.Text.Trim + "')", CyberSmLib)
        If TxtMa_Cd.Text.Trim = "" Then TxtTen_Cd.Text = "" Else TxtTen_Cd.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_CD", "DmCD", "(Ma_CD= N'" + TxtMa_Cd.Text.Trim + "')", CyberSmLib)

        CyberSmodb.GetValueToControler(Me)
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
            _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit



        '-------------------------------------------------------------------
        '--Tk
        RemoveHandler TxtTK.CyberValiting, AddressOf V_TK
        RemoveHandler TxtTK.CyberLeave, AddressOf L_TK
        AddHandler TxtTK.CyberValiting, AddressOf V_TK
        AddHandler TxtTK.CyberLeave, AddressOf L_TK
        '--Vt
        RemoveHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_vt
        RemoveHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_vt
        AddHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_vt
        AddHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_vt
        '--CD
        RemoveHandler TxtMa_Cd.CyberValiting, AddressOf V_Ma_CD
        RemoveHandler TxtMa_Cd.CyberLeave, AddressOf L_Ma_CD
        AddHandler TxtMa_Cd.CyberValiting, AddressOf V_Ma_CD
        AddHandler TxtMa_Cd.CyberLeave, AddressOf L_Ma_CD


    End Sub
#End Region
#Region "Valid"




#Region "Vali --- TK"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTK.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "TK0", "Dmtk0", "1=1", "1=1")
    End Sub
    Private Sub L_tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtTK.Text = "" Then
            TxtTen_TK.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTK.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtTK.Text = DrReturn.Item("tk0")
            TxtTen_TK.Text = DrReturn.Item("Ten_tk0")
        Else
            TxtTK.Text = ""
            TxtTen_TK.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_vt"
    Private Sub V_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_vt.Text = "" Then
            TxtTen_vt.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_vt.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_vt.Text = DrReturn.Item("Ma_vt")
            TxtTen_vt.Text = DrReturn.Item("Ten_vt")
        Else
            TxtMa_vt.Text = ""
            TxtTen_vt.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_CD"
    Private Sub V_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Cd.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_CD", "DmCD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Cd.Text = "" Then
            TxtTen_Cd.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Cd.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Cd.Text = DrReturn.Item("Ma_CD")
            TxtTen_Cd.Text = DrReturn.Item("Ten_CD")
        Else
            TxtMa_Cd.Text = ""
            TxtTen_Cd.Text = ""
        End If
    End Sub
#End Region


#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = CbbM_Thang1.SelectedValue.ToString.Trim & "#" & CbbM_Thang2.SelectedValue.ToString.Trim & "#" & CbbM_Nam.SelectedValue.ToString.Trim

       

        M_strParameterStore = M_strParameterStore & "#" & TxtTK.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Cd.Text.Trim

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
