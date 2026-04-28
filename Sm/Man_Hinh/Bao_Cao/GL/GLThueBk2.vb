Public Class GLThueBk2
    Dim DtThang1, DtThang2, DtNam As DataTable
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub GLThueBk2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        '----
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
        '--ma Thue
        AddHandler TxtMa_Thue.CyberValiting, AddressOf V_Ma_Thue
        AddHandler TxtMa_Thue.CyberLeave, AddressOf L_Ma_Thue

        '--Tk
        AddHandler TxtTk.CyberValiting, AddressOf V_Tk
        AddHandler TxtTk.CyberLeave, AddressOf L_Tk

        '--Tk_DU
        AddHandler TxtTk_Du.CyberValiting, AddressOf V_Tk_Du
        AddHandler TxtTk_Du.CyberLeave, AddressOf L_Tk_Du

        '--ma khach hang
        AddHandler Txtma_kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler Txtma_kh.CyberLeave, AddressOf L_Ma_KH
        '-- ma kho
        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Ma_KHo
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_Ma_KHo
        '-- ma vu viec
        AddHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_vv
        AddHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_vv
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_Thue"
    Private Sub V_Ma_Thue(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_Thue.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Thue", "DmThue", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Thue(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = Txtma_Thue.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_Thue.Text = DrReturn.Item("Ma_Thue")
            txtten_Thue.Text = DrReturn.Item("Ten_Thue")
        Else
            Txtma_Thue.Text = ""
            txtten_Thue.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Tk"
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("Tk0")
            TxtTen_Tk.Text = DrReturn.Item("Ten_Tk0")
        Else
            TxtTk.Text = ""
            TxtTen_Tk.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Tk_Du"
    Private Sub V_Tk_DU(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_Du.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_DU(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk_Du.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Du.Text = DrReturn.Item("Tk0")
            txtten_tk_du.Text = DrReturn.Item("Ten_Tk0")
        Else
            TxtTk_Du.Text = ""
            txtten_tk_du.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_kh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = Txtma_kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_kh.Text = DrReturn.Item("Ma_kh")
            txtten_kh.Text = DrReturn.Item("Ten_Kh")
        Else
            Txtma_kh.Text = ""
            txtten_kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_KHo"
    Private Sub V_Ma_KHo(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_kho.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KHo", "DmKHo", "1=1", "1=1")
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
#Region "Valid --- Ma_Vv"
    Private Sub V_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vv.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Vv", "Dmvv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Vv.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vv.Text = DrReturn.Item("Ma_Vv")
            TxtTen_Vv.Text = DrReturn.Item("Ten_Vv")
        Else
            TxtMa_Vv.Text = ""
            TxtTen_Vv.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = CbbM_Thang1.SelectedValue.ToString.Trim & "#" & CbbM_Thang2.SelectedValue.ToString.Trim & "#" & CbbM_Nam.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & ""
        M_strParameterStore = M_strParameterStore & "#" & TxtTk.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTk_du.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Txtma_kh.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_kho.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Vv.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkHoa_don.Checked, "0", "1")
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
