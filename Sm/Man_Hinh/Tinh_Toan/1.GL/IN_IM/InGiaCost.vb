Public Class InGiaCost

    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable

    Private Sub InGiaCost_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        Chk1.Checked = True
        Chk2.Checked = False
        Chk3.Checked = True

        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        '-- ma Vt
        AddHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_vt
        AddHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_vt

        '-- ma kho
        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Ma_KHo
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_Ma_KHo
        '-- Tk_VT
        AddHandler TxtTk_Vt.CyberValiting, AddressOf V_Tk_Vt
        AddHandler TxtTk_Vt.CyberLeave, AddressOf L_Tk_Vt
        '--VT1
        RemoveHandler TxtNh_Vt1.CyberValiting, AddressOf V_NH_VT1
        RemoveHandler TxtNh_Vt1.CyberLeave, AddressOf L_NH_VT1
        AddHandler TxtNh_Vt1.CyberValiting, AddressOf V_NH_VT1
        AddHandler TxtNh_Vt1.CyberLeave, AddressOf L_NH_VT1
        '--VT2
        RemoveHandler TxtNh_Vt2.CyberValiting, AddressOf V_NH_VT2
        RemoveHandler TxtNh_Vt2.CyberLeave, AddressOf L_NH_VT2
        AddHandler TxtNh_Vt2.CyberValiting, AddressOf V_NH_VT2
        AddHandler TxtNh_Vt2.CyberLeave, AddressOf L_NH_VT2
        '--VT3
        RemoveHandler TxtNh_Vt3.CyberValiting, AddressOf V_NH_VT3
        RemoveHandler TxtNh_Vt3.CyberLeave, AddressOf L_NH_VT3
        AddHandler TxtNh_Vt3.CyberValiting, AddressOf V_NH_VT3
        AddHandler TxtNh_Vt3.CyberLeave, AddressOf L_NH_VT3

        '--VT4
        RemoveHandler TxtNh_VT4.CyberValiting, AddressOf V_NH_VT4
        RemoveHandler TxtNh_VT4.CyberLeave, AddressOf L_NH_VT4
        AddHandler TxtNh_VT4.CyberValiting, AddressOf V_NH_VT4
        AddHandler TxtNh_VT4.CyberLeave, AddressOf L_NH_VT4
        '--VT5
        RemoveHandler TxtNh_VT5.CyberValiting, AddressOf V_NH_VT5
        RemoveHandler TxtNh_VT5.CyberLeave, AddressOf L_NH_VT5
        AddHandler TxtNh_VT5.CyberValiting, AddressOf V_NH_VT5
        AddHandler TxtNh_VT5.CyberLeave, AddressOf L_NH_VT5

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

        TxtMa_kho.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_kho)
        TxtMa_vt.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_vt)

        TxtTen_kho.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_kho.Text.Trim + "')", CyberSmlib)
        Txtten_VT.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Vt", "DmVt", "(Ma_Vt= N'" + TxtMa_vt.Text.Trim + "')", CyberSmlib)

        TxtNh_Vt1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Vt1.Text.Trim + "')", CyberSmlib)
        TxtNh_Vt2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Vt2.Text.Trim + "')", CyberSmlib)
        TxtNh_Vt3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Nh", "DmNhVt", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Vt3.Text.Trim + "')", CyberSmlib)

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
#Region "Valid --- Ma_vt"
    Private Sub V_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt.Text = DrReturn.Item("Ma_vt")
            Txtten_VT.Text = DrReturn.Item("Ten_vt")
        Else
            TxtMa_vt.Text = ""
            Txtten_VT.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- TK_Vt"
    Private Sub V_Tk_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_Vt.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Tk0", "Dmtk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk_Vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Vt.Text = DrReturn.Item("Tk0")
            TxtTen_Tk_Vt.Text = DrReturn.Item("Ten_Tk0")
        Else
            TxtTk_Vt.Text = ""
            TxtTen_Tk_Vt.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_KHo"
    Private Sub V_Ma_KHo(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_kho.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_KHo", "DmKHo", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KHo(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_kho.Text = DrReturn.Item("Ten_Kho")
        Else
            TxtMa_kho.Text = ""
            TxtTen_kho.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT1"
    Private Sub V_NH_VT1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt1.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_VT1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vt1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT2"
    Private Sub V_NH_VT2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt2.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_VT2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vt2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT3"
    Private Sub V_NH_VT3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_Vt3.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_VT3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_Vt3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Vt3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Vt3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT4"
    Private Sub V_NH_VT4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_VT4.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Appconn, DsLookUp, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_VT4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_VT4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VT4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VT4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VT4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_VT5"
    Private Sub V_NH_VT5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_VT5.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Appconn, DsLookUp, "Ma_NH", "DmNhVT", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_VT5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtNh_VT5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_VT5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_VT5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_VT5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = If(Chk1.Checked, "1", "0") & "#" & If(Chk2.Checked, "1", "0") & "#" & If(Chk3.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & CbbM_Thang1.SelectedValue.ToString.Trim & "#" & CbbM_Thang2.SelectedValue.ToString.Trim & "#" & CbbM_Nam.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_kho.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTk_Vt.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_VT1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_VT2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_VT3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt4.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_Vt5.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
End Class
