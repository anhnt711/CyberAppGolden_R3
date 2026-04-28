Public Class FaBCTGTH1VAT

    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet

    Dim DtThang1, DtThang2, DtNam As DataTable
    Private Sub FaBCTGTH1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_Addhander()
        Me.Text = Me.Text + " - Finance"
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

        '----
        TxtMa_ts.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_ts)
        TxtNh_ts1.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtNh_ts1)
        TxtNh_ts2.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtNh_ts2)
        TxtNh_ts3.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtNh_ts3)


        Txtten_ts.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Ts", "DmTSVAT", "(Ma_Ts= N'" + TxtMa_ts.Text.Trim + "')", CyberSmLib)
        TxtTen_Nhts1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhts", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_ts1.Text.Trim + "')", CyberSmLib)
        TxtTen_Nhts2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhts", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_ts2.Text.Trim + "')", CyberSmLib)
        TxtTen_Nhts3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhts", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_ts3.Text.Trim + "')", CyberSmLib)



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

        '-- ma cong cu
        AddHandler TxtMa_ts.CyberValiting, AddressOf V_Ma_ts
        AddHandler TxtMa_ts.CyberLeave, AddressOf L_Ma_ts
        '--TS1
        RemoveHandler TxtNh_ts1.CyberValiting, AddressOf V_NH_ts1
        RemoveHandler TxtNh_ts1.CyberLeave, AddressOf L_NH_ts1
        AddHandler TxtNh_ts1.CyberValiting, AddressOf V_NH_ts1
        AddHandler TxtNh_ts1.CyberLeave, AddressOf L_NH_ts1
        '--ts2
        RemoveHandler TxtNh_ts2.CyberValiting, AddressOf V_NH_ts2
        RemoveHandler TxtNh_ts2.CyberLeave, AddressOf L_NH_ts2
        AddHandler TxtNh_ts2.CyberValiting, AddressOf V_NH_ts2
        AddHandler TxtNh_ts2.CyberLeave, AddressOf L_NH_ts2
        '--ts3
        RemoveHandler TxtNh_ts3.CyberValiting, AddressOf V_NH_ts3
        RemoveHandler TxtNh_ts3.CyberLeave, AddressOf L_NH_ts3
        AddHandler TxtNh_ts3.CyberValiting, AddressOf V_NH_ts3
        AddHandler TxtNh_ts3.CyberLeave, AddressOf L_NH_ts3


    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_ts"
    Private Sub V_Ma_ts(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_ts.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_ts", "DmTSVAT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_ts(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_ts.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_ts.Text = DrReturn.Item("Ma_ts")
            Txtten_ts.Text = DrReturn.Item("Ten_ts")
        Else
            TxtMa_ts.Text = ""
            Txtten_ts.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- NH_ts1"
    Private Sub V_NH_ts1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_ts1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhts", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_ts1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_ts1.Text = "" Then
            TxtTen_Nhts1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_ts1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ts1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nhts1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ts1.Text = ""
            TxtTen_Nhts1.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- NH_TS2"
    Private Sub V_NH_ts2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_ts2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_nh", "DmNhts", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_ts2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_ts2.Text = "" Then
            TxtTen_Nhts2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_ts2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ts2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nhts2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ts2.Text = ""
            TxtTen_Nhts2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_ts3"
    Private Sub V_NH_ts3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_ts3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_NH", "DmNhts", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_ts3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_ts3.Text = "" Then
            TxtTen_Nhts3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_ts3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ts3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nhts3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ts3.Text = ""
            TxtTen_Nhts3.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = CbbM_Thang1.SelectedValue.ToString.Trim & "#" & CbbM_Thang2.SelectedValue.ToString.Trim & "#" & CbbM_Nam.SelectedValue.ToString.Trim

        M_strParameterStore = M_strParameterStore & "#" & TxtMa_ts.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_ts1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_ts2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_ts3.Text.Trim

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
