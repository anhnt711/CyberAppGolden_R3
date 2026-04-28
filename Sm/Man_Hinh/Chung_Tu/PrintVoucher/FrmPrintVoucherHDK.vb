Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class FrmPrintVoucherHDK
    Dim CyberSmlib As New Cyber.SmLib.Sys
    Dim CyberSmodb As New Cyber.Smodb.Sys
    Dim CyberSupport As New Cyber.Support.Sys
    Dim CyberFill As New Cyber.Fill.Sys
    Dim CyberLists As New Cyber.SmLists.Sys
    Dim DrReturn As DataRow
    Dim M_Lan As String
    Dim M_Para As String()
    Dim osysvar As Collection
    Dim M_Appconn As SqlConnection
    Dim M_DrDmCt As DataRow
    Dim M_Ma_Dvcs As String = ""
    Dim M_User_name As String = ""
    Dim TbPrintTT, DtLoai_IN As DataTable
    Dim CyberLoading As New Cyber.Loading.Loading

    Private Sub FrmPrintVoucherHDK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        RemoveHandler CmdPrint.Click, AddressOf V_Print
        RemoveHandler CmdPriview.Click, AddressOf V_Preview
        RemoveHandler CmdModify.Click, AddressOf V_Modify

        AddHandler CmdPrint.Click, AddressOf V_Print
        AddHandler CmdPriview.Click, AddressOf V_Preview
        AddHandler CmdModify.Click, AddressOf V_Modify
        AddHandler CbbMa_In.SelectedValueChanged, AddressOf V_Ma_In
        AddHandler CmdExportWord.Click, AddressOf V_XuatWord   'V_ExportWord
        AddHandler CmdExportExcel.Click, AddressOf V_XuatExcel   'V_ExportExcel
        V_Ma_In(Nothing, Nothing)
        GetTable()
    End Sub
    Private Sub V_Load()
        M_Lan = Me.Lan
        M_Para = Me.Para
        osysvar = Me.Sysvar
        M_Appconn = Me.AppConn
        M_DrDmCt = Me.DrDmct
        M_User_name = M_Para(6).Trim
        M_Ma_Dvcs = M_Para(14).Trim
        '---------------Lay ngam dinh ma in--TVT-------------------------
        Dim DsMaIn As DataSet
        DsMaIn = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetDFMaInHDK", Me.Stt_Rec & "#" & Me.Ma_CT & "#" & M_Ma_Dvcs & "#" & M_User_name)
        DtMaIn.Clear()
        DtMaIn = DsMaIn.Tables(0)
        '------------------------------------------------------------
        '--Dt conFig
        If DsMaIn.Tables.Count > 1 Then
            If DsMaIn.Tables(1).Columns.Contains("SHOWEXPORTWORD") Then
                CmdExportWord.Visible = IIf(DsMaIn.Tables(1).Rows(0).Item("SHOWEXPORTWORD") = "1", True, False)
            End If
            If DsMaIn.Tables(1).Columns.Contains("SHOWEXPORTEXCEL") Then
                CmdExportExcel.Visible = IIf(DsMaIn.Tables(1).Rows(0).Item("SHOWEXPORTEXCEL") = "1", True, False)
            End If
        End If
        '------------------------------------------------------------
        txtTitle1.Text = M_DrDmCt.Item("Tieu_De_Ct").ToString.ToUpper
        txtTitle2.Text = M_DrDmCt.Item("Tieu_De2").ToString.ToUpper
        CyberFill.V_FillComBoxDefaul(CbbMa_In, DtMaIn, "Ma_In", IIf(Me.Lan = "V", "ten_IN", "ten_IN2"), "Ngam_Dinh")
        CyberSmodb.GetValueToControler(Me)
        '---
        CyberSupport.Translaste(Me, Me.Lan, True)
        Me.Loai_In = "Preview"
        Me.ReturnOk = False
        Me.Tag_Field = ""
        Me.Tag_Value = ""
        Me.Key_Sub1 = ""
        Me.Key_Sub2 = ""
        Me.Key_Sub3 = ""
        Me.Key_Sub4 = ""
        Me.Key_Sub5 = ""
        ChkLanBS.Checked = True
    End Sub
    Private Sub GetTable()
        Dim DsPrintMa_TT As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetCombox", "DMTT" + "#" + "1=1" + "#" + "Ma_TT" + "#" + M_User_name.Trim)
        TbPrintTT = DsPrintMa_TT.Tables(0).Copy
        DtLoai_IN = New DataTable
        DtLoai_IN.Columns.Add("Ma")
        DtLoai_IN.Columns.Add("Ten")
        DtLoai_IN.Rows.Add("0", "In có giá trị")
        DtLoai_IN.Rows.Add("1", "In không có giá trị")
        CyberFill.V_FillComBoxValue(CbbMa_TT, TbPrintTT, "Ma_TT", "Ten_TT", "")
        CyberFill.V_FillComBoxValue(CbbLoai_IN, DtLoai_IN, "Ma", "Ten", "0")

    End Sub
    Private Sub V_AddMenuShorcut()
        Dim mnItems = New ContextMenu
        Dim mnItemsNhan As New MenuItem(IIf(Me.Lan = "V", "Xem & In", "Priview"), AddressOf V_Preview, Keys.Control + Keys.Enter)
        Dim mnItemsExit As New MenuItem(IIf(Me.Lan = "V", "Quay ra", "Exit"), AddressOf V_Exit, Keys.Escape)
        mnItems.MenuItems.Add(mnItemsNhan)
        mnItems.MenuItems.Add(mnItemsExit)
        Me.ContextMenu = mnItems
    End Sub
    Private Sub V_Print(ByVal _Status)
        Dim M_strFieldValue As String = ""
        Dim M_strFieldName As String = ""

        CyberSmodb.GetValueControler(Me, M_strFieldName, M_strFieldValue, "")
        Me.Tag_Field = M_strFieldName
        Me.Tag_Value = M_strFieldValue
        Me.Title1 = txtTitle1.Text
        Me.Title2 = txtTitle2.Text
        Me.Ma_In = CbbMa_In.SelectedValue
        Me.Loai_In = _Status
        Me.So_Ct = TxtSo_Ct_Goc.Text
        Me.So_Lien = TxtSo_lien.Double
        Me.Key_Sub1 = CbbLoai_IN.SelectedValue.ToString
        Me.Key_Sub2 = CbbMa_TT.SelectedValue.ToString
        Me.Key_Sub3 = IIf(ChkLanBS.Checked, "0", TxtLanBS.Text.ToString.Trim)

        Me.ReturnOk = True
        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
    End Sub
    Private Sub V_Preview(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Print("PREVIEW")
        Me.Close()
    End Sub
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Print("PRINT")
        Me.Close()
    End Sub
    Private Sub V_Modify(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Print("MODI")
        Me.Close()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.ReturnOk = False
        Me.Close()
    End Sub
    Private Sub V_Ma_In(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim So_lien As Integer = 1
        Dim So_Ct_goc As String = ""
        For Each dr As DataRow In DtMaIn.Rows
            If dr("Ma_In") = CbbMa_In.SelectedValue Then
                If DtMaIn.Columns.Contains("So_Lien") Then So_lien = dr("So_Lien")
                If DtMaIn.Columns.Contains("So_Ct_goc") Then So_Ct_goc = dr("So_Ct_goc")
                Exit For
            End If
        Next
        TxtSo_lien.Text = So_lien
        TxtSo_Ct_Goc.Text = So_Ct_goc
    End Sub
    Private Sub V_ExportWord(ByVal sender As Object, ByVal e As EventArgs)
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(M_Lan)
        V_Print_Cus("EXPORTWORD", "CP_PrintHDK", 1)
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        Me.Close()
    End Sub
    Private Sub V_ExportExcel(ByVal sender As Object, ByVal e As EventArgs)
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(M_Lan)
        V_Print_Cus("CREATEEXCEL", "CP_PrintHDK", 2)
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        Me.Close()
    End Sub
    Private Sub V_Print_Cus(ByVal _Loai As String, ByVal Cp_name As String, ByVal Is_PrintCus As Integer)
        'Dim DsPrint_ok As DataSet = New DataSet()
        'Dim DsPrint As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, Cp_name, Me.Stt_Rec + "#" + CbbMa_In.SelectedValue + "#" + CbbLoai_IN.SelectedValue + "#" + CbbMa_TT.SelectedValue + "#" + TxtLanBS.Text + "#" + M_User_name)
        'If Not CyberSupport.V_MsgChk(DsPrint.Tables(0), Sysvar, M_Lan) Then
        '    DsPrint.Dispose()
        '    Exit Sub
        'End If
        'For i As Integer = 0 To DsPrint.Tables.Count - 1
        '    CyberSmodb.SetNotNullTable(DsPrint.Tables(i))
        '    If i > 0 Then
        '        DsPrint_ok.Tables.Add(DsPrint.Tables(i).Copy)
        '    End If
        'Next
        'Dim CyberPrint As New Cyber.PrintCustom.Sys
        'Dim _Report_Name As String = DsPrint.Tables(0).Rows(0).Item("Repo_Name").ToString.Trim
        'Dim _Title As String = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        'Dim _IsWaterMark As Boolean = False
        'Dim AddParaCustom As New List(Of Cyber.PrintCustom.CyberPrintParameter)
        'AddParaCustom.Add(New Cyber.PrintCustom.CyberPrintParameter("Stt_rec", Me.Stt_Rec))
        'Dim printsetting As New Windows.Forms.PrintDialog
        'If _Loai = "PRINT" Then
        '    Dim result As Windows.Forms.DialogResult = printsetting.ShowDialog()
        '    If Not result.ToString.ToUpper.Trim = "OK".ToUpper.Trim Then
        '        Exit Sub
        '    End If
        'End If
        'Dim _WaterMark As String = ""
        'DsPrint.Tables(0).Clear()
        'DsPrint.Tables(0).Clear()
        'If Is_PrintCus = 1 Then
        '    CyberPrint.CyberPrintReportcustomer(AddParaCustom, printsetting, AppConn, _Loai, _Report_Name, DsPrint_ok, _Title, _Title, Me.Sysvar, Me.Para, M_Ma_Dvcs, _IsWaterMark, _WaterMark, Me.Lan, True, True)
        'ElseIf Is_PrintCus = 2 Then
        '    CyberPrint.CyberCreateReportcustomer(AddParaCustom, AppConn, _Loai, CbbMa_In.SelectedValue, _Report_Name, DsPrint_ok, _Title, _Title, Sysvar, Me.Para, M_Ma_Dvcs, _IsWaterMark, _WaterMark, Me.Lan, True, True)
        'Else
        '    CyberPrint.CyberPrintReport(AppConn, _Loai, _Report_Name, DsPrint_ok, _Title, _Title, Me.Sysvar, Me.Para, M_Ma_Dvcs, _IsWaterMark, _WaterMark, Me.Lan, True, True)
        'End If
    End Sub
    Private Sub V_XuatWord(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New FrmXuatWord_DV
        'frm.AppConn = AppConn
        'frm.Sysvar = osysvar
        'frm.Lan = M_LAN
        'frm.Para = M_Para
        ''frm.Mode = M_Mode
        'frm.Stt_Rec = Me.Stt_Rec
        ''frm.Ma_CT = M_Ma_CT
        'frm.DrDmct = DrDmct
        'frm.Ma_Dvcs = M_Ma_Dvcs
        'frm.User_name = M_User_Name
        'frm.ShowDialog()
        'If Not frm.ReturnOk Then Exit Sub
    End Sub
    Private Sub V_XuatExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim frm As New FrmXuatExcel_DV
        'frm.AppConn = AppConn
        'frm.Sysvar = osysvar
        'frm.Lan = M_Lan
        'frm.Para = M_Para
        ''frm.Mode = M_Mode
        'frm.Stt_Rec = Me.Stt_Rec
        ''frm.Ma_CT = M_Ma_CT
        'frm.DrDmct = DrDmct
        'frm.Ma_Dvcs = M_Ma_Dvcs
        'frm.User_name = M_User_name
        'frm.ShowDialog()
        'If Not frm.ReturnOk Then Exit Sub
    End Sub
End Class
