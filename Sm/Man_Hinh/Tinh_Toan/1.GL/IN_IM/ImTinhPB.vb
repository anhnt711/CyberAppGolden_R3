Public Class ImTinhPB

    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable

    Private Sub ImTinhPB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        '-- ma cong cu
        AddHandler TxtMa_CC.CyberValiting, AddressOf V_Ma_Cc
        AddHandler TxtMa_CC.CyberLeave, AddressOf L_Ma_Cc
        '--CC1
        RemoveHandler TxtNh_CC1.CyberValiting, AddressOf V_NH_Cc1
        RemoveHandler TxtNh_CC1.CyberLeave, AddressOf L_NH_Cc1
        AddHandler TxtNh_CC1.CyberValiting, AddressOf V_NH_Cc1
        AddHandler TxtNh_CC1.CyberLeave, AddressOf L_NH_Cc1
        '--CC2
        RemoveHandler TxtNh_CC2.CyberValiting, AddressOf V_NH_Cc2
        RemoveHandler TxtNh_CC2.CyberLeave, AddressOf L_NH_Cc2
        AddHandler TxtNh_CC2.CyberValiting, AddressOf V_NH_Cc2
        AddHandler TxtNh_CC2.CyberLeave, AddressOf L_NH_Cc2
        '--CC3
        RemoveHandler TxtNh_CC3.CyberValiting, AddressOf V_NH_Cc3
        RemoveHandler TxtNh_CC3.CyberLeave, AddressOf L_NH_Cc3
        AddHandler TxtNh_CC3.CyberValiting, AddressOf V_NH_Cc3
        AddHandler TxtNh_CC3.CyberLeave, AddressOf L_NH_Cc3
        V_SETChkBT()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        DtThang1 = CreateTableMonth()
        DtThang2 = DtThang1.Copy
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang1, DtThang1, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Thang2, DtThang2, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")


        TxtMa_CC.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_CC)
        TxtNh_CC1.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_CC1)
        TxtNh_CC2.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_CC2)
        TxtNh_CC3.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_CC3)

        Txtten_CC.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Cc", "DmCc", "(Ma_Cc= N'" + TxtMa_CC.Text.Trim + "')", CyberSmlib)
        TxtTen_NhCC1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhCc", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_CC1.Text.Trim + "')", CyberSmlib)
        TxtTen_NhCC2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhCc", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_CC2.Text.Trim + "')", CyberSmlib)
        TxtTen_NhCC3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhCc", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_CC3.Text.Trim + "')", CyberSmlib)

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
        TxtMa_CC.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Cc", "DmCc", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_CC.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CC.Text = DrReturn.Item("Ma_Cc")
            Txtten_CC.Text = DrReturn.Item("Ten_Cc")
        Else
            TxtMa_CC.Text = ""
            Txtten_CC.Text = ""
            V_SETChkBT()
            Exit Sub
        End If
        V_SETChkBT()
    End Sub
#End Region
#Region "Vali --- NH_Cc1"
    Private Sub V_NH_Cc1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CC1.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhCc", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_Cc1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_CC1.Text = "" Then
            TxtTen_NhCC1.Text = ""
            V_SETChkBT()
            Exit Sub
        End If
        DrReturn = TxtNh_CC1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CC1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_NhCC1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CC1.Text = ""
            TxtTen_NhCC1.Text = ""
        End If
        V_SETChkBT()
    End Sub
#End Region
#Region "Vali --- NH_Cc2"
    Private Sub V_NH_Cc2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CC2.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhCc", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_Cc2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_CC2.Text = "" Then
            TxtTen_NhCC2.Text = ""
            V_SETChkBT()
            Exit Sub
        End If
        DrReturn = TxtNh_CC2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CC2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_NhCC2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CC2.Text = ""
            TxtTen_NhCC2.Text = ""
        End If
        V_SETChkBT()
    End Sub
#End Region
#Region "Vali --- NH_Cc3"
    Private Sub V_NH_Cc3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_CC3.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhCc", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_Cc3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_CC3.Text = "" Then
            TxtTen_NhCC3.Text = ""
            V_SETChkBT()
            Exit Sub
        End If
        DrReturn = TxtNh_CC3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CC3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_NhCC3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CC3.Text = ""
            TxtTen_NhCC3.Text = ""
        End If
        V_SETChkBT()
    End Sub
#End Region
#End Region
    Private Sub V_SETChkBT()
        If TxtMa_CC.Text.Trim <> "" Then ChkTao_but_Toan.Checked = False
        If TxtNh_CC1.Text.Trim <> "" Then ChkTao_but_Toan.Checked = False
        If TxtNh_CC2.Text.Trim <> "" Then ChkTao_but_Toan.Checked = False
        If TxtNh_CC3.Text.Trim <> "" Then ChkTao_but_Toan.Checked = False
        If TxtMa_CC.Text.Trim = "" And TxtNh_CC1.Text.Trim = "" And TxtNh_CC2.Text.Trim = "" And TxtNh_CC3.Text.Trim = "" Then
            ChkTao_but_Toan.Visible = True
        Else
            ChkTao_but_Toan.Visible = False
        End If
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        V_SETChkBT()
        Dim M_strParameterStore As String = CbbM_Thang1.SelectedValue.ToString.Trim & "#" & CbbM_Thang2.SelectedValue.ToString.Trim & "#" & CbbM_Nam.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & If(ChkTao_but_Toan.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CC.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CC1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CC2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_CC3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
End Class
