Public Class GLTH5T
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim Tb_name As String = "DMNhVV"
    Private Sub GLTH5T_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        GetTb_name()
        V_Addhander()
    End Sub
    Private Sub GetTb_name()
        Dim Ma_Code As String = Me.Para(Me.VT_PARA + 3).ToString.Trim.ToUpper

        If Ma_Code.Trim.Length > 2 Then Tb_name = "DmNh" + Strings.Right(Ma_Code.Trim, 2)

        If Ma_Code = "MA_VV" Then Tb_name = "DmNhVv"
        If Ma_Code = "MA_HD" Then Tb_name = "DmNhHD"
        If Ma_Code = "MA_PHI" Then Tb_name = "DmNhPhi"
        If Ma_Code = "MA_SP" Then Tb_name = "DmNhSP"
        If Ma_Code = "MA_KU" Then Tb_name = "DmNhKu"

        If Ma_Code = "MA_TTLN" Then Tb_name = "DmNhTTLN"
        If Ma_Code = "MA_TTCP" Then Tb_name = "DmNhTTCP"
        If Ma_Code = "MA_BP" Then Tb_name = "DmNhBp"
        If Ma_Code = "MA_HS" Then Tb_name = "DmNhHS"
        If Ma_Code = "MA_CD" Then Tb_name = "DmNhCD"

        If Ma_Code = "MA_TD1" Then Tb_name = "DmNhTD1"
        If Ma_Code = "MA_TD2" Then Tb_name = "DmNhTD2"
        If Ma_Code = "MA_TD3" Then Tb_name = "DmNhTD3"
        If Ma_Code = "MA_TD4" Then Tb_name = "DmNhTD4"
        If Ma_Code = "MA_TD5" Then Tb_name = "DmNhTD5"

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
        Try
            TxtM_Tk.Text = Me.Para(Me.VT_PARA + 2).ToString.Trim
        Catch ex As Exception

        End Try
        If TxtM_Tk.Text.Trim = "" Then TxtM_Tk.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtM_Tk)
        If TxtM_Tk.Text.Trim = "" Then Txtten_Tk.Text = "" Else Txtten_Tk.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtM_Tk.Text.Trim + "'", CyberSmLib)
        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--TK
        AddHandler TxtM_Tk.CyberValiting, AddressOf V_Tk
        AddHandler TxtM_Tk.CyberLeave, AddressOf L_Tk
        '---Nhom1
        AddHandler TxtNhom1.CyberValiting, AddressOf V_NHom1
        AddHandler TxtNhom1.CyberLeave, AddressOf L_Nhom1
        '---Nhom2
        AddHandler TxtNhom2.CyberValiting, AddressOf V_Nhom2
        AddHandler TxtNhom2.CyberLeave, AddressOf L_Nhom2
        '---Nhom3
        AddHandler TxtNhom3.CyberValiting, AddressOf V_Nhom3
        AddHandler TxtNhom3.CyberLeave, AddressOf L_Nhom3
        '---Nhom4
        AddHandler TxtNhom4.CyberValiting, AddressOf V_Nhom4
        AddHandler TxtNhom4.CyberLeave, AddressOf L_Nhom4
        '---Nhom5
        AddHandler TxtNhom5.CyberValiting, AddressOf V_Nhom5
        AddHandler TxtNhom5.CyberLeave, AddressOf L_Nhom5

    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Nhom1"
    Private Sub V_Nhom1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNhom1.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", Tb_name, "1=1", "loai_nh='1'")
    End Sub
    Private Sub L_Nhom1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNhom1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNhom1.Text = DrReturn.Item("ma_nh")
            TxtTen_Nhom1.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNhom1.Text = ""
            TxtTen_Nhom1.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nhom2"
    Private Sub V_Nhom2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNhom2.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", Tb_name, "1=1", "loai_nh='2'")
    End Sub
    Private Sub L_Nhom2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNhom2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNhom2.Text = DrReturn.Item("ma_nh")
            TxtTen_Nhom2.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNhom2.Text = ""
            TxtTen_Nhom2.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nhom3"
    Private Sub V_Nhom3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNhom3.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", Tb_name, "1=1", "loai_nh='3'")
    End Sub
    Private Sub L_Nhom3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNhom3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNhom3.Text = DrReturn.Item("ma_nh")
            TxtTen_Nhom3.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNhom3.Text = ""
            TxtTen_Nhom3.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nhom4"
    Private Sub V_Nhom4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNhom4.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", Tb_name, "1=1", "loai_nh='4'")
    End Sub
    Private Sub L_Nhom4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNhom4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNhom4.Text = DrReturn.Item("ma_nh")
            TxtTen_Nhom4.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNhom4.Text = ""
            TxtTen_Nhom4.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Nhom5"
    Private Sub V_Nhom5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNhom5.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "ma_nh", Tb_name, "1=1", "loai_nh='5'")
    End Sub
    Private Sub L_Nhom5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNhom5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNhom5.Text = DrReturn.Item("ma_nh")
            TxtTen_Nhom5.Text = DrReturn.Item("Ten_nh")
        Else
            TxtNhom5.Text = ""
            TxtTen_Nhom5.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Tk"
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtM_Tk.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtM_Tk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtM_Tk.Text = DrReturn.Item("Tk0")
            Txtten_Tk.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtM_Tk.Text = ""
            Txtten_Tk.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtM_Tk.Text.Trim = "" Then
            TxtM_Tk.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = Me.Para(Me.VT_PARA + 3).ToString.Trim.ToUpper
        M_strParameterStore = M_strParameterStore & "#" & TxtM_Tk.Text.Trim.Replace("#", "")
        M_strParameterStore = M_strParameterStore & "#" & TxtNhom1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNhom2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNhom3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNhom4.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNhom5.Text.Trim
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
