Public Class GLTC2Detail
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub GLTC2Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        V_AddMenuShorcut()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)
        TxtTk_Co.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtTk_Co)

        Try
            TxtTk_No.Text = Me.Para(Me.VT_PARA + 2).ToString.Trim
        Catch ex As Exception

        End Try
        If TxtTk_No.Text.Trim = "" Then TxtTk_No.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtTk_No)
        If TxtTk_No.Text.Trim = "" Then Txtten_Tk_No.Text = "" Else Txtten_Tk_No.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtTk_No.Text.Trim + "'", CyberSmLib)
        If TxtTk_Co.Text.Trim = "" Then TxtTen_Tk_Co.Text = "" Else TxtTen_Tk_Co.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtTk_Co.Text.Trim + "'", CyberSmLib)

        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--TK
        AddHandler TxtTk_No.CyberValiting, AddressOf V_Tk_no
        AddHandler TxtTk_No.CyberLeave, AddressOf L_Tk_no
        '--TK
        AddHandler TxtTk_Co.CyberValiting, AddressOf V_Tk_co
        AddHandler TxtTk_Co.CyberLeave, AddressOf L_Tk_co
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Tk_no"
    Private Sub V_Tk_no(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_No.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_no(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk_No.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_No.Text = DrReturn.Item("Tk0")
            Txtten_Tk_No.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTk_No.Text = ""
            Txtten_Tk_No.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- tk_co"
    Private Sub V_Tk_co(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_Co.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "tk0", "Dmtk0", "1=1", "1=1")
    End Sub
    Private Sub L_tk_co(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtTk_Co.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Co.Text = DrReturn.Item("tk0")
            TxtTen_Tk_Co.Text = DrReturn.Item("Ten_tk0")
        Else
            TxtTk_Co.Text = ""
            TxtTen_Tk_Co.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_No.Text.Trim = "" Then
            TxtTk_No.Focus()
            Exit Sub
        End If
        If TxtTk_Co.Text.Trim = "" Then
            TxtTk_Co.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = TxtTk_No.Text.Trim.Replace("#", "")
        M_strParameterStore = M_strParameterStore & "#" & TxtTk_Co.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
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
