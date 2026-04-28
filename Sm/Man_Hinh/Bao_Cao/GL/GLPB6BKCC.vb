Public Class GLPB6BKCC
    Dim CyberMe As New Cyber.ReportsCustom.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub BKPB6_CC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        TxtTK_Co_H.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtTK_Co_H)

        Try
            TxtTK_No_H.Text = Me.Para(Me.VT_PARA + 2).ToString.Trim
        Catch ex As Exception

        End Try
        Try
            TxtTK_Co_H.Text = Me.Para(Me.VT_PARA + 3).ToString.Trim
        Catch ex As Exception

        End Try
        If TxtTK_No_H.Text.Trim = "" Then TxtTK_No_H.Text = CyberSmLib.GetKeyValueRegistry(Me.sysvar, TxtTK_No_H)
        If TxtTK_No_H.Text.Trim = "" Then TxtTen_TK_No_H.Text = "" Else TxtTen_TK_No_H.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TK0", "DmTK0", "TK0 = N'" + TxtTK_No_H.Text.Trim + "'", CyberSmLib)
        If TxtTK_Co_H.Text.Trim = "" Then TxtTen_TK_Co_H.Text = "" Else TxtTen_TK_Co_H.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TK0", "DmTK0", "TK0 = N'" + TxtTK_Co_H.Text.Trim + "'", CyberSmLib)
        '----
        CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        '--kx
        AddHandler TxtTK_No_H.CyberValiting, AddressOf V_TK_No_H
        AddHandler TxtTK_No_H.CyberLeave, AddressOf L_TK_No_H
        '--Mau
        AddHandler TxtTK_Co_H.CyberValiting, AddressOf V_TK_Co_H
        AddHandler TxtTK_Co_H.CyberLeave, AddressOf L_TK_Co_H

    End Sub
#End Region
#Region "Valid"
#Region "Valid --- TK_No_H"
    Private Sub V_TK_No_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "TK0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_TK_No_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK_No_H.Text = DrReturn.Item("TK0")
            TxtTen_TK_No_H.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTK_No_H.Text = ""
            TxtTen_TK_No_H.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- TK_Co_H"
    Private Sub V_TK_Co_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        sender.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "TK0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_TK_Co_H(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK_Co_H.Text = DrReturn.Item("TK0")
            TxtTen_TK_Co_H.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTK_Co_H.Text = ""
            TxtTen_TK_Co_H.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTK_No_H.Text.ToString.Trim = TxtTK_Co_H.Text.ToString.Trim And (TxtTK_No_H.Text.ToString.Trim <> "" Or TxtTK_Co_H.Text.ToString.Trim <> "") Then
            MsgBox("Tài khoản nợ và tài khoản có không thể giống nhau", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.sysvar("M_CYBER_VER"))
            TxtTK_No_H.Focus()
            Exit Sub
        End If
        '-----------------------------------------------------------------------------
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTK_No_H.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtTK_Co_H.Text.Trim
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
