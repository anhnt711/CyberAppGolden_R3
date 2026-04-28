Public Class RO_HD03
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DsLookup As DataSet
    Dim DrReturn As DataRow
    Private Sub RO_HD03Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        ChkIs_All.Checked = True
        ChkIs_C.Checked = False
        ChkIs_I.Checked = False
        ChkIs_W.Checked = False
        ChkIs_N.Checked = False
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        'Try
        '    TxtTK.Text = Me.Para(Me.VT_PARA + 2).ToString.Trim
        'Catch ex As Exception

        'End Try
        If TxtTK.Text.Trim = "" Then TxtTK.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtTK)
        If TxtTK.Text.Trim = "" Then TxtTK.Text = "131"
        If TxtTK.Text.Trim = "" Then TxtTen_TK.Text = "" Else TxtTen_TK.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtTK.Text.Trim + "'", CyberSmLib)
        '
        If TxtMa_Kh.Text.Trim = "" Then TxtMa_Kh.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_Kh)
        If TxtMa_Kh.Text.Trim = "" Then TxtTen_Kh.Text = "" Else TxtTen_Kh.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kh", "Dmkh", "Ma_Kh = N'" + TxtMa_Kh.Text.Trim + "'", CyberSmLib)
        '----
        CyberSmodb.GetValueToControler(Me)

    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--TK
        AddHandler TxtTK.CyberValiting, AddressOf V_TK
        AddHandler TxtTK.CyberLeave, AddressOf L_TK

        '--Ma_Kh
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_Kh
        AddHandler TxtSo_RO.Leave, AddressOf L_So_RO

        AddHandler ChkIs_All.Click, AddressOf V_Is_All
        AddHandler ChkIs_C.Click, AddressOf V_Ma_TT
        AddHandler ChkIs_I.Click, AddressOf V_Ma_TT
        AddHandler ChkIs_N.Click, AddressOf V_Ma_TT
        AddHandler ChkIs_W.Click, AddressOf V_Ma_TT

    End Sub
    Private Sub V_Is_All(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkIs_All.Checked Then
            ChkIs_C.Checked = False
            ChkIs_I.Checked = False
            ChkIs_N.Checked = False
            ChkIs_W.Checked = False
        Else
            If Not ChkIs_C.Checked And Not ChkIs_I.Checked And Not ChkIs_N.Checked And Not ChkIs_W.Checked Then
                ChkIs_C.Checked = True
            End If
        End If
    End Sub
    Private Sub V_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkIs_C.Checked And Not ChkIs_I.Checked And Not ChkIs_N.Checked And Not ChkIs_W.Checked Then
            ChkIs_C.Checked = True
        End If
        ChkIs_All.Checked = False
        'If ChkIs_C.Checked And ChkIs_I.Checked And ChkIs_N.Checked And ChkIs_W.Checked Then
        '    ChkIs_All.Checked = False
        'End I
    End Sub
#End Region
#Region "Valid --- Tk"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTK.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk", "DmTKCN", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTK.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK.Text = DrReturn.Item("Tk")
            TxtTen_TK.Text = DrReturn.Item("Ten_TK")
        Else
            TxtTK.Text = ""
            TxtTen_TK.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- /RO/Ma_Kh"
    Dim CyberVoucher As New Cyber.Voucher.Sys
    Private Sub L_So_RO(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not TxtSo_RO.Text.Trim = "" Then
            Dim _Dt As Date = Now.Date
            TxtSo_RO.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Me.sysvar, "HDK", "S", "M", _Dt, TxtSo_RO.Text, "", Me.Ma_Dvcs, Me.User_Name, CyberSmLib)
        End If
    End Sub

    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
            TxtTen_Kh.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_All.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_C.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_I.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_N.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & IIf(ChkIs_W.Checked, "1", "0")
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_RO.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTK.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kh.Text.Trim
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
