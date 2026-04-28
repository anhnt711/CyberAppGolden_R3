Public Class IMSuaPBLoc
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang, DtNam As DataTable
    Private Sub IMSuaPBLoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()

        AddHandler ButtOK.Click, AddressOf V_Nhan

        AddHandler TxtMa_Cc.CyberValiting, AddressOf V_Ma_Cc
        AddHandler TxtMa_Cc.CyberLeave, AddressOf L_Ma_Cc

        '--TS1
        RemoveHandler TxtNh_Cc1.CyberValiting, AddressOf V_NH_Cc1
        RemoveHandler TxtNh_Cc1.CyberLeave, AddressOf L_NH_Cc1
        AddHandler TxtNh_Cc1.CyberValiting, AddressOf V_NH_Cc1
        AddHandler TxtNh_Cc1.CyberLeave, AddressOf L_NH_Cc1
        '--ts2
        RemoveHandler TxtNh_Cc2.CyberValiting, AddressOf V_NH_Cc2
        RemoveHandler TxtNh_Cc2.CyberLeave, AddressOf L_NH_Cc2
        AddHandler TxtNh_Cc2.CyberValiting, AddressOf V_NH_Cc2
        AddHandler TxtNh_Cc2.CyberLeave, AddressOf L_NH_Cc2
        '--ts3
        RemoveHandler TxtNh_Cc3.CyberValiting, AddressOf V_NH_Cc3
        RemoveHandler TxtNh_Cc3.CyberLeave, AddressOf L_NH_Cc3
        AddHandler TxtNh_Cc3.CyberValiting, AddressOf V_NH_Cc3
        AddHandler TxtNh_Cc3.CyberLeave, AddressOf L_NH_Cc3
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        DtThang = CreateTableMonth()

        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang1, DtThang, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")
        TxtMa_Cc.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_Cc)
        Txtten_Cc.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Cc", "DmCc", "(Ma_Cc= N'" + TxtMa_Cc.Text.Trim + "')", CyberSmlib)

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

            If Now.Date.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
#Region "Valid"
#Region "Valid --- Ma_Cc"
    Private Sub V_Ma_Cc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Cc.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Cc", "DmCc", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Cc.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Cc.Text = DrReturn.Item("Ma_Cc")
            Txtten_Cc.Text = DrReturn.Item("Ten_Cc")
        Else
            TxtMa_Cc.Text = ""
            Txtten_Cc.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- NH_Cc1"
    Private Sub V_NH_Cc1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Cc1.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhts", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_Cc1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Cc1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Cc1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Cc1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Cc1.Text = ""
            TxtTen_Nh_Cc1.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- NH_Cc2"
    Private Sub V_NH_Cc2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Cc2.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhts", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_Cc2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Cc2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Cc2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Cc2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Cc2.Text = ""
            TxtTen_Nh_Cc2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Cc3"
    Private Sub V_NH_Cc3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Cc3.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhts", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_Cc3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Cc3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Cc3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Cc3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Cc3.Text = ""
            TxtTen_Nh_Cc3.Text = ""
        End If
    End Sub
#End Region
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = "1#" & CbbM_Thang1.SelectedValue.ToString.Trim & "#" & CbbM_Nam.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#19000101"
        M_strParameterStore = M_strParameterStore & "#"
        M_strParameterStore = M_strParameterStore & "#"
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Cc.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Cc1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Cc2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Cc3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
End Class
