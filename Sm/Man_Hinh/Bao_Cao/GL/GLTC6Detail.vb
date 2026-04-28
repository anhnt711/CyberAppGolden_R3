Public Class GLTC6Detail
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub GLTC6Detail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        TxtFile_MaubC.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtFile_MaubC)

        Try
            TxtMa_so.Text = Me.Para(Me.VT_PARA + 2).ToString.Trim
        Catch ex As Exception

        End Try
        If TxtMa_so.Text.Trim = "" Then TxtMa_so.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtMa_so)
        If TxtMa_so.Text.Trim = "" Then Txtchi_tieu.Text = "" Else Txtchi_tieu.Text = CyberSmodb.SQLGetvalue(AppConn, "ma_so", "gltc6", "ma_so = N'" + TxtMa_so.Text.Trim + "'", CyberSmLib)
      

        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--TK
        AddHandler TxtMa_so.CyberValiting, AddressOf V_Ma_so
        AddHandler TxtMa_so.CyberLeave, AddressOf L_Ma_so
        '--TK
        AddHandler TxtFile_MaubC.CyberValiting, AddressOf V_Mau_bc
        AddHandler TxtFile_MaubC.CyberLeave, AddressOf L_Mau_bc
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_so"
    Private Sub V_Ma_so(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "MA_SO", "GLTC6", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_so(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_so.Text = DrReturn.Item("ma_so")
            Txtchi_tieu.Text = DrReturn.Item("chi_tieu")
        Else
            TxtMa_so.Text = ""
            Txtchi_tieu.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- mau_bc"
    Private Sub V_Mau_bc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtFile_MaubC.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_so", "gltc6", "1=1", "1=1")
    End Sub
    Private Sub L_Mau_bc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtFile_MaubC.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtFile_MaubC.Text = DrReturn.Item("File_MaubC")

        Else
            TxtFile_MaubC.Text = ""

            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_so.Text.Trim = "" Then
            TxtMa_so.Focus()
            Exit Sub
        End If
        If TxtFile_MaubC.Text.Trim = "" Then
            TxtFile_MaubC.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = TxtMa_so.Text.Trim.Replace("#", "")
        M_strParameterStore = M_strParameterStore & "#" & TxtFile_MaubC.Text.Trim
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
