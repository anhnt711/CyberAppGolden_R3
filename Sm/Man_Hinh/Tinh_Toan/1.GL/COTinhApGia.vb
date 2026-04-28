Public Class COTinhApGia

    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable
    Private Sub COTinhApGia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        '-- ma cong cu
        AddHandler TxtMa_VT.CyberValiting, AddressOf V_Ma_Vt
        AddHandler TxtMa_VT.CyberLeave, AddressOf L_Ma_Vt
        '--CC1
        'RemoveHandler TxtNh_VT1.CyberValiting, AddressOf V_NH_Vt1
        'RemoveHandler TxtNh_VT1.CyberLeave, AddressOf L_NH_Vt1
        AddHandler TxtNh_VT1.CyberValiting, AddressOf V_NH_Vt1
        AddHandler TxtNh_VT1.CyberLeave, AddressOf L_NH_Vt1
        '--CC2
        'RemoveHandler TxtNh_VT2.CyberValiting, AddressOf V_NH_Vt2
        'RemoveHandler TxtNh_VT2.CyberLeave, AddressOf L_NH_Vt2
        AddHandler TxtNh_VT2.CyberValiting, AddressOf V_NH_Vt2
        AddHandler TxtNh_VT2.CyberLeave, AddressOf L_NH_Vt2
        '--CC3
        'RemoveHandler TxtNh_VT3.CyberValiting, AddressOf V_NH_Vt3
        'RemoveHandler TxtNh_VT3.CyberLeave, AddressOf L_NH_Vt3
        AddHandler TxtNh_VT3.CyberValiting, AddressOf V_NH_Vt3
        AddHandler TxtNh_VT3.CyberLeave, AddressOf L_NH_Vt3

        '-- TK
        AddHandler TxtTk.CyberValiting, AddressOf V_TK
        AddHandler TxtTk.CyberLeave, AddressOf L_TK

        '-- CD
        AddHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        AddHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD
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


        TxtMa_VT.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_VT)
        TxtNh_VT1.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_VT1)
        TxtNh_VT2.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_VT2)
        TxtNh_VT3.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtNh_VT3)

        Txtten_VT.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Vt", "DmVt", "(Ma_Vt= N'" + TxtMa_VT.Text.Trim + "')", CyberSmlib)
        TxtTen_NhVT1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_VT1.Text.Trim + "')", CyberSmlib)
        TxtTen_NhVT2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_VT2.Text.Trim + "')", CyberSmlib)
        TxtTen_NhVT3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_VT3.Text.Trim + "')", CyberSmlib)

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
#Region "Valid --- Ma_Vt"
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_VT.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Vt", "DmVt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_VT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_VT.Text = DrReturn.Item("Ma_Vt")
            Txtten_VT.Text = DrReturn.Item("Ten_Vt")
        Else
            TxtMa_VT.Text = ""
            Txtten_VT.Text = ""

            Exit Sub
        End If

    End Sub
#End Region
#Region "Vali --- NH_Vt1"
    Private Sub V_NH_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_VT1.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhVt", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_Vt1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_VT1.Text = "" Then
            TxtTen_NhVT1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VT1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VT1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_NhVT1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VT1.Text = ""
            TxtTen_NhVT1.Text = ""
        End If

    End Sub
#End Region
#Region "Vali --- NH_Vt2"
    Private Sub V_NH_Vt2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_VT2.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Nh", "DmNhVt", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_Vt2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_VT2.Text = "" Then
            TxtTen_NhVT2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VT2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VT2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_NhVT2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VT2.Text = ""
            TxtTen_NhVT2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_Vt3"
    Private Sub V_NH_Vt3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_VT3.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhVt", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_Vt3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_VT3.Text = "" Then
            TxtTen_NhVT3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VT3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VT3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_NhVT3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VT3.Text = ""
            TxtTen_NhVT3.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_CD"
    Private Sub V_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CD.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_CD", "DmCD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_CD.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_CD.Text = DrReturn.Item("Ma_CD")
            TxtTen_CD.Text = DrReturn.Item("Ten_CD")
        Else
            TxtMa_CD.Text = ""
            TxtTen_CD.Text = ""
            Exit Sub
        End If

    End Sub
#Region "Valid --- Ma_CD"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "TK0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("TK0")
            TxtTen_TK.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTk.Text = ""
            TxtTen_TK.Text = ""
            Exit Sub
        End If

    End Sub
#End Region
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = "1#" & CbbM_Thang1.SelectedValue.ToString.Trim & "#" & CbbM_Thang2.SelectedValue.ToString.Trim & "#" & CbbM_Nam.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_VT.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_VT1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_VT2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_VT3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTk.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_CD.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
End Class
