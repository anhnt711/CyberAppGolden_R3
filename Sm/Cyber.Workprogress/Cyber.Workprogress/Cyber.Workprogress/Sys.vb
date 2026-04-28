Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing
Imports DevExpress.XtraScheduler

Public Class Sys
#Region "Load..."
    Public Sub Initvao(ByVal M_Para As String())
        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
        Dim M_CP_Name As String = M_Para(M_VT_PARA + 1).Trim
        Dim M_User_Name As String = M_Para(6).Trim
        Dim M_Lan As String = M_Para(13).Trim
        Dim M_Ma_Dvcs As String = M_Para(14).Trim
        Dim M_Bar As String = M_Para(11).Trim
        Dim M_Bar2 As String = M_Para(12).Trim
        Dim _Title As String = "Đang thực hiện: " + M_Bar
        Dim _Title2 As String = "Processing: " + M_Bar2
        Dim CyberSmlib As New Cyber.SmLib.Sys

        Dim CyberSupport As New Cyber.Support.Sys
        Dim CyberFill As New Cyber.Fill.Sys
        Dim CyberSmlistSys As New Cyber.SmLists.Sys
        Dim CyberSmodb As New Cyber.Smodb.Sys
        Dim CyberEport As New Cyber.Export.Sys
        Dim CyberVoucher As New Cyber.Voucher.Sys
        Dim CyberLoading As New Cyber.Loading.Loading
        Dim Appconn As SqlConnection = CyberSmlib.GetConn()
        Dim oSysvar As Collection = CyberSmlib.IniSysVar(Appconn, M_Ma_Dvcs, M_User_Name)
        M_CP_Name = M_CP_Name.Trim.ToUpper

        Dim Frm As Cyber.From.FrmCalculator

        '-------------------------------------------------------------------------------------------------------------------------------------
        Select Case M_CP_Name.ToUpper.Trim
            Case "CP_Workprogress".ToUpper.Trim
                Frm = New FrmTien_Do
            Case "CP_Work_TIEP_DON".ToUpper.Trim
                Frm = New FrmTiep_Don
            Case "CP_Work_Sua_Bien".ToUpper.Trim
                Frm = New FrmSua_Bien
            Case "CP_Work_XN".ToUpper.Trim
                Frm = New FrmXac_Nhan
            Case "CP_Work_CW".ToUpper.Trim
                Frm = New FrmCW
            Case "CP_Work_PDS".ToUpper.Trim
                Frm = New FrmPDS
            Case "CP_WorkCapStt".ToUpper.Trim
                Frm = New FrmCapStt
            Case "CP_Work_TEST".ToUpper.Trim
                Frm = New FFF
            Case Else
                Exit Sub
        End Select
        If Frm Is Nothing Then Return
        Frm.Lan = M_Lan
        Frm.Para = M_Para
        Frm.Sysvar = oSysvar
        Frm.AppConn = Appconn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberVoucher = CyberVoucher
        Frm.CyberLoading = CyberLoading
        Frm.ShowDialog()
        ' ''--------------
    End Sub
#End Region
#Region "Đón tiếp"""
    Public Function V_Tiep_Don_Update_Xe_RVR(ByVal _Stt_rec As String, ByVal _Ma_Xe As String, _
                      ByVal _App As SqlConnection, ByVal osysvar As Collection,
                      ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                      Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                              Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                              Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                              Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                              Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                              Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                              Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As Boolean

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Dstmp As DataSet = Nothing
        Dim Frm As New FrmTiep_Don_Update_RVR
        '-----------------------------------------------------------
        Frm.Stt_rec = _Stt_rec
        Frm.Ma_Xe = _Ma_Xe
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Dim _Return As Boolean = Frm.Save_OK
        Return _Return
        CyberSmlib.FlushMemorySave()
    End Function
#End Region
#Region "Lich_Hen"
    Public Function V_Lich_Hen(ByVal _Ma_TTCP As String, ByVal _Ma_Ct As String, ByVal _Mode As String, ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, _
                            ByVal _Stt_rec As String, ByVal _Ma_Khoang As String, _
                            ByVal _Ma_CVDV As String, ByVal _Ma_To As String, ByVal _Ma_Xe As String, ByVal _Ma_CD As String, ByVal _Ma_KTV As String, _
                            ByVal _Ngay_Bd As Date, ByVal _Ngay_Kt As Date, _
                            ByVal _App As SqlConnection, ByVal osysvar As Collection,
                            ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                                Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                                Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                                Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                                Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                                Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                                Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmDLHen_F3
        '-----------------------------------------------------------
        Frm.Ma_TTCP = _Ma_TTCP
        Frm.Kieu_Xem = _Kieu_Xem
        Frm.Loai_SC = _Loai_SC
        Frm.Mode = _Mode
        Frm.Stt_Rec = _Stt_rec
        Frm.Ngay_BD = _Ngay_Bd
        Frm.Ngay_KT = _Ngay_Kt
        Frm.Ma_CVDV = _Ma_CVDV
        Frm.Ma_Khoang = _Ma_Khoang
        Frm.Ma_To = _Ma_To
        Frm.Ma_CD = _Ma_CD
        Frm.Ma_Xe = _Ma_Xe
        Frm.Ma_KTV = _Ma_KTV
        '------------------------
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()

        Dim _Return As DataTable
        If Frm.Save_OK Then _Return = Frm.M_Dt_Return.Copy Else _Return = Nothing
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
    Public Function V_Hen_Thay_Doi_Post(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_Rec As String, ByVal _Ma_post As String, ByVal _App As SqlConnection, ByVal osysvar As Collection, ByVal _Lan As String, _
                                  ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                                 Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                                 Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                                 Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                                 Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                                 Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                                 Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As Boolean

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_WorkDLH_ChangePost", _Kieu_Xem + "#" + _Loai_SC + "#" + _Stt_Rec + "#" + _Ma_post + "#" + _Ma_Dvcs + "#" + _User_name)
        If DsTmp.Tables.Count <= 0 Then
            DsTmp.Dispose()
            Return False
        End If


        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), osysvar, _Lan) Then Return False
        DsTmp.Dispose()
        Return True
    End Function
    Public Function V_Hen_Call(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_rec As String, ByVal _Stt_rec_RO As String, _
                     ByVal _App As SqlConnection, ByVal osysvar As Collection,
                     ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                      Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                             Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                             Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                             Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                             Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                             Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                             Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As Boolean

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmDLHen_Call
        '-----------------------------------------------------------
        Frm.Kieu_Xem = _Kieu_Xem
        Frm.Loai_SC = _Loai_SC

        Frm.Stt_rec = _Stt_rec
        Frm.Stt_rec_Ro = _Stt_rec_RO
        '-----------------------------------------------------------
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        CyberSmlib.FlushMemorySave()
        Return Frm.Save_OK
    End Function
    Public Function V_Hen_Print(ByVal _Stt_rec_Hen As String, _
                   ByVal _App As SqlConnection, ByVal osysvar As Collection,
                   ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                    Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                           Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                           Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                           Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                           Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                           Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                           Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As Boolean

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim DsPrint As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_WorkDLH_Print", _Stt_rec_Hen & "#" & _Ma_Dvcs & "#" & _User_name)
        If Not CyberSupport.V_MsgChk(DsPrint.Tables(0), osysvar, _Lan) Then
            DsPrint.Dispose()
            Return False
        End If

        Dim _ReportName As String = ""
        Dim _Title1 As String = "PHIẾU ĐẶT LỊCH HẸN"
        Dim _Title2 As String = "PHIẾU ĐẶT LỊCH HẸN"
        If DsPrint.Tables(0).Columns.Contains("Repo_Name") Then _ReportName = DsPrint.Tables(0).Rows(0).Item("Repo_Name").ToString.Trim()
        If DsPrint.Tables(0).Columns.Contains("M_Title") Then _Title1 = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        If DsPrint.Tables(0).Columns.Contains("M_Title") Then _Title2 = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        DsPrint.Tables.Remove(DsPrint.Tables(0))
        V_Print(_App, _Ma_Dvcs, _Lan, "1", True, True, _ReportName, DsPrint, _Title1, _Title2, osysvar, _Para)

        Return True
    End Function
    Public Sub V_Xem_Ds_Hen(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_rec As String, ByVal _Ma_Xe As String, ByVal _Ma_Hs As String, ByVal _Ngay_Ct1 As Date, ByVal _Ngay_Ct2 As Date, ByVal _ShowFilter As Boolean, _
                  ByVal _App As SqlConnection, ByVal osysvar As Collection,
                  ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                   Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                          Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                          Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                          Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                          Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                          Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                          Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing)

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim _strFilter As String = ""
        If _ShowFilter = True Then
            Dim Frm As New FrmDLHenFilter
            '-----------------------------------------------------------
            Frm.Kieu_Xem = _Kieu_Xem
            Frm.Loai_SC = _Loai_SC

            Frm.Ma_Xe = _Ma_Xe
            Frm.Ma_Hs = _Ma_Hs
            Frm.Ngay_CT1 = _Ngay_Ct1
            Frm.Ngay_CT2 = _Ngay_Ct2
            '-----------------------------------------------------------
            Frm.Lan = _Lan
            Frm.Para = _Para
            Frm.Sysvar = osysvar
            Frm.AppConn = _App
            Frm.CyberSmlib = CyberSmlib
            Frm.CyberSupport = CyberSupport
            Frm.CyberFill = CyberFill
            Frm.CyberSmlistSys = CyberSmlistSys
            Frm.CyberSmodb = CyberSmodb
            Frm.CyberExport = CyberEport
            Frm.CyberLoading = CyberLoading

            Frm.ShowInTaskbar = False
            Frm.ShowDialog()
            If Not Frm.Save_OK Then Return
            _strFilter = Frm.Tag.ToString.Trim
        Else
            _strFilter = _Kieu_Xem & "#" & _Loai_SC '--Kieu_Xem + Loai_SC
            _strFilter = _strFilter & "#" & "" 'Stt_Rec
            _strFilter = _strFilter & "#" & _Ma_Xe
            _strFilter = _strFilter & "#" & _Ma_Hs
            _strFilter = _strFilter & "#" & _Ngay_Ct1.ToString("yyyyMMdd") & "#" & _Ngay_Ct2.ToString("yyyyMMdd") & "#" & "" & "#" & _Ma_Dvcs + "#" + _User_name

        End If

        Dim _Title As String = "DANH SÁCH LỊCH HẸN SỬA CHỮA"
        CyberSupport.V_WorkView("CP_WorkDLH", _strFilter, _Title, False, _Ma_Dvcs, _User_name, _App, osysvar, _Lan, _Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, Nothing, CyberLoading)
        'CyberSupport.V_WorkView("CP_WorkDLH", _strFilter, _Title, True, _Ma_Dvcs, _User_name, _App, osysvar, _Lan, _Para, FrmDLHenFilter, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, Nothing, CyberLoading)
        CyberSmlib.FlushMemorySave()
    End Sub
#End Region
#Region "Dat cho"
    Public Function V_Dat_Cho(ByVal _Ma_TTCP As String, ByVal _Ma_Ct As String, ByVal _Mode As String, ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, _
                            ByVal _Stt_rec As String, ByVal _Ma_Khoang As String, _
                            ByVal _Ma_CVDV As String, ByVal _Ma_To As String, ByVal _Ma_Xe As String, ByVal _Ma_CD As String, ByVal _Ma_KTV As String, _
                            ByVal _Ngay_Bd As Date, ByVal _Ngay_Kt As Date, _
                            ByVal _App As SqlConnection, ByVal osysvar As Collection,
                            ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                              Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                              Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                              Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                              Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                              Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                              Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                              Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable




        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmDat_Cho_F3
        '-----------------------------------------------------------
        Frm.Ma_TTCP = _Ma_TTCP
        Frm.Kieu_Xem = _Kieu_Xem
        Frm.Loai_SC = _Loai_SC
        Frm.Mode = _Mode
        Frm.Stt_Rec = _Stt_rec
        Frm.Ngay_BD = _Ngay_Bd
        Frm.Ngay_KT = _Ngay_Kt
        Frm.Ma_CVDV = _Ma_CVDV
        Frm.Ma_Khoang = _Ma_Khoang
        Frm.Ma_To = _Ma_To
        Frm.Ma_CD = _Ma_CD
        Frm.Ma_Xe = _Ma_Xe
        Frm.Ma_KTV = _Ma_KTV
        '------------------------
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()

        Dim _Return As DataTable
        If Frm.Save_OK Then _Return = Frm.M_Dt_Return.Copy Else _Return = Nothing
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
#End Region
#Region "Tien do"
    Public Function V_Lock_Tien_Do(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, _
                        ByVal _App As SqlConnection, ByVal osysvar As Collection,
                        ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                       Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                             Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                             Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                             Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                             Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                             Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                             Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As Boolean

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_Work_Lock_UnLock", _Kieu_Xem & "#" & _Loai_SC & "#" & _Ma_Dvcs & "#" & _User_name)
        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmp.Tables(0), osysvar, _Lan)
        DsTmp.Dispose()
        Return _Return
    End Function
    Public Function V_Up_TG_GX(ByVal _Ma_TTCP As String, ByVal _Loai_SC As String, ByVal _Stt_rec_Ro As String, ByVal _So_Ro As String, _
                  ByVal _App As SqlConnection, ByVal osysvar As Collection,
                     ByVal _Para As String(), ByVal _Lan As String, ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                      Optional ByVal _ShowInTaskbar As Boolean = True, _
                  Optional ByVal Cybersmlib As Cyber.SmLib.Sys = Nothing, _
                  Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                  Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                    Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                    Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                    Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                    Optional ByVal CyberVoucher As Cyber.Voucher.Sys = Nothing, _
                    Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataRow

        '--------------------------------------------------------------------------------------------------------------------------
        If Cybersmlib Is Nothing Then Cybersmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberVoucher Is Nothing Then CyberVoucher = New Cyber.Voucher.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading
        '--------------------------------------------------------------------------------------------------------------------------
        Dim Frm As New FrmTien_Do_Update_TG_GX
        Frm.Ma_TTCP = _Ma_TTCP
        Frm.Loai_SC = _Loai_SC
        Frm.Stt_rec_Ro = _Stt_rec_Ro
        Frm.So_RO = _So_Ro
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = Cybersmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = CyberVoucher
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Dim _Return_DR As DataRow
        If Frm.Save_OK Then _Return_DR = Frm.M_Dr_Return
        V_Up_TG_GX = _Return_DR
    End Function
    Public Function V_KH_SCC(ByVal _Ma_TTCP As String, ByVal _Ma_Ct As String, ByVal _Mode As String, ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, _
                            ByVal _Stt_rec As String, ByVal _Stt_rec_RO As String, ByVal _So_Ro As String, ByVal _Ma_Khoang As String, _
                            ByVal _Ma_CVDV As String, ByVal _Ma_To As String, ByVal _Ma_Xe As String, ByVal _Ma_CD As String, ByVal _Ma_KTV As String, _
                            ByVal _Ngay_Bd As Date, ByVal _Ngay_Kt As Date, _
                            ByVal _App As SqlConnection, ByVal osysvar As Collection,
                            ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                                Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                                Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                                Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                                Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                                Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                                Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmTien_Do_F3
        '-----------------------------------------------------------
        Frm.Ma_TTCP = _Ma_TTCP
        Frm.Kieu_Xem = _Kieu_Xem
        Frm.Loai_SC = _Loai_SC
        Frm.Mode = _Mode
        Frm.Stt_Rec = _Stt_rec
        Frm.Stt_Rec_Ro = _Stt_rec_RO
        Frm.So_Ro = _So_Ro
        Frm.Ngay_BD = _Ngay_Bd
        Frm.Ngay_KT = _Ngay_Kt
        Frm.Ma_CVDV = _Ma_CVDV
        Frm.Ma_Khoang = _Ma_Khoang
        Frm.Ma_To = _Ma_To
        Frm.Ma_CD = _Ma_CD
        Frm.Ma_Xe = _Ma_Xe
        Frm.Ma_KTV = _Ma_KTV

        '------------------------
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        '-----------------------------------------------------------
        Dim _Return As DataTable
        If Frm.Save_OK Then _Return = Frm.M_Dt_Return.Copy Else _Return = Nothing
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
    Public Function V_KH_SDSALL(ByVal _Ma_TTCP As String, ByVal _Ma_Ct As String, ByVal _Mode As String, ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, _
                              ByVal _Stt_rec As String, ByVal _Stt_rec_RO As String, ByVal _So_Ro As String, ByVal _Ma_Khoang As String, _
                              ByVal _Ma_CVDV As String, ByVal _Ma_To As String, ByVal _Ma_Xe As String, ByVal _Ma_CD As String, ByVal _Ma_KTV As String, _
                           ByVal _Ngay_Bd As Date, ByVal _Ngay_Kt As Date, _
                          ByVal _App As SqlConnection, ByVal osysvar As Collection,
                          ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                 Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                                  Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                                  Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                                  Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                                  Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                                  Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                                  Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading


        Dim Frm As New FrmTien_Do_F3_SDSALL
        ''-----------------------------------------------------------
        Frm.Ma_TTCP = _Ma_TTCP
        Frm.So_Ro = _So_Ro
        Frm.Stt_Rec_Ro = _Stt_rec_RO
        Frm.Mode = _Mode
        Frm.Ma_Ct = _Ma_Ct
        Frm.Kieu_Xem = _Kieu_Xem
        Frm.Loai_SC = _Loai_SC
        Frm.Ngay_BD = _Ngay_Bd
        Frm.Ngay_KT = _Ngay_Kt
        Frm.Ma_CVDV = _Ma_CVDV
        Frm.Ma_Khoang = _Ma_Khoang
        Frm.Ma_To = _Ma_To
        Frm.Ma_CD = _Ma_CD
        Frm.Ma_Xe = _Ma_Xe
        Frm.Ma_KTV = _Ma_KTV
        '------------------------
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Dim _Return As DataTable
        If Frm.Save_OK Then _Return = Frm.M_Dt_Return.Copy Else _Return = Nothing
        CyberSmlib.FlushMemorySave()
        Return _Return

    End Function
    Public Function V_Giao_Xe(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_Rec_Ro As String, ByVal _Stt_Rec As String, _
                       ByVal _App As SqlConnection, ByVal osysvar As Collection,
                       ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                      Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                            Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                            Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                            Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                            Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                            Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                            Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_Work_Chuyen_GX", _Kieu_Xem & "#" & _Loai_SC & "#" & _Stt_Rec_Ro & "#" & _Stt_Rec & "#" & _Ma_Dvcs & "#" & _User_name)

        Dim _Return As DataTable = Nothing
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), osysvar, _Lan) Then _Return = Nothing Else _Return = DsTmp.Tables(0).Copy
        DsTmp.Dispose()
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
#End Region
#Region "PDS"
    Public Function V_KH_PDS(ByVal _Mode As String, ByVal _Stt_Rec As String, ByVal _Ma_Khoang As String, ByVal _Ngay_BD As Date, ByVal _Ngay_KT As Date, ByVal _Tg_Sc As Integer, _
                   ByVal Dmkhoang As DataTable, _
             ByVal _App As SqlConnection, ByVal osysvar As Collection,
             ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                     Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                     Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                     Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                     Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                     Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                     Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                     Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmPDS_F3

        Frm.DmKhoang = Dmkhoang
        Frm.Stt_rec = _Stt_Rec
        Frm.Mode = _Mode
        Frm.Ma_khoang = _Ma_Khoang
        Frm.Ngay_BD = _Ngay_BD
        Frm.Ngay_KT = _Ngay_KT
        Frm.Tg_SC = _Tg_Sc

        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = Nothing
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Return Frm.Dt_Return
    End Function
#End Region
#Region "Chạy thử, Dừng, Q-Get,KSC, Dừng sửa chữa"
    Public Function V_Chay_Thu(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_rec As String, ByVal _Stt_rec_Ro As String, _
                       ByVal _App As SqlConnection, ByVal osysvar As Collection,
                       ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                               Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                               Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                               Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                               Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                               Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                               Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmTien_Do_ChayThu
        '-----------------------------------------------------------
        Frm.Stt_rec = _Stt_rec
        Frm.Stt_rec_RO = _Stt_rec_Ro
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Dim _Return As DataTable
        If Frm.Save_OK Then _Return = Frm.Dt_Return.Copy Else _Return = Nothing
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
    Public Function V_Chay_Thu_Stop(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_rec As String, ByVal _Stt_rec_Ro As String, _
                       ByVal _App As SqlConnection, ByVal osysvar As Collection,
                       ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                       Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                      Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                      Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                      Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                      Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                      Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                      Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing
                      ) As DataTable
        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_Work_CHAYTHU_STOP", _Kieu_Xem + "#" + _Loai_SC + "#" + _Stt_rec & "#" & _Stt_rec_Ro & "#" & _Ma_Dvcs & "#" & _User_name)
        Dim _Return As DataTable = Nothing
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), osysvar, _Lan) Then _Return = Nothing Else _Return = Dstmp.Tables(0).Copy
        Dstmp.Dispose()
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
    Public Function V_BD_Dung_SC(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_rec As String, _
                           ByVal _App As SqlConnection, ByVal osysvar As Collection,
                           ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                    Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                                   Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                                   Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                                   Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                                   Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                                   Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                                   Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Dstmp As DataSet = Nothing
        Dim Frm As New FrmTien_Do_Dung_SC
        '-----------------------------------------------------------
        Frm.Kieu_Xem = _Kieu_Xem
        Frm.Loai_SC = _Loai_SC
        Frm.Stt_rec = _Stt_rec

        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Dim _Return As DataTable
        If Frm.Save_OK Then _Return = Frm.Dt_Return.Copy Else _Return = Nothing
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
    Public Function V_KT_Dung_SC(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_Rec_RO As String, ByVal _Stt_Rec As String, ByVal _So_Ro As String, ByVal _Ma_Xe As String, _
                           ByVal _App As SqlConnection, ByVal osysvar As Collection,
                         ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                 Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                                 Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                                 Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                                 Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                                 Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                                 Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                                 Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_Work_DungSC_Save_KT", _Kieu_Xem & "#" & _Loai_SC & "#" & _Stt_Rec_RO & "#" & _Stt_Rec & "#" & _So_Ro & "#" & _Ma_Xe & "#" & _Ma_Dvcs & "#" & _User_name)
        Dim _Return As DataTable = Nothing
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), osysvar, _Lan) Then _Return = Nothing Else _Return = DsTmp.Tables(0).Copy
        DsTmp.Dispose()
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
    Public Function V_QGate(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_rec As String, _
                              ByVal _App As SqlConnection, ByVal osysvar As Collection,
                              ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                        Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                                      Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                                      Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                                      Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                                      Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                                      Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                                      Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading


        Dim Frm As New FrmTien_Do_QGate
        '-----------------------------------------------------------
        Frm.Stt_rec = _Stt_rec
        Frm.Loai_SC = _Loai_SC
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Dim _Return As DataTable
        If Frm.Save_OK Then _Return = Frm.Dt_Return.Copy Else _Return = Nothing
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
    Public Function V_KCS_CD(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_rec As String, _
                          ByVal _App As SqlConnection, ByVal osysvar As Collection,
                          ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                                  Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                                  Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                                  Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                                  Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                                  Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                                  Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmTien_Do_KCS_CD
        '-----------------------------------------------------------
        Frm.Kieu_Xem = _Kieu_Xem
        Frm.Loai_SC = _Loai_SC
        Frm.Stt_rec = _Stt_rec
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Dim _Return As DataTable
        If Frm.Save_OK Then _Return = Frm.Dt_Return.Copy Else _Return = Nothing
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
    Public Function V_Chuyen_Tang(ByVal _Status As String, ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_rec_KH As String, ByVal _Stt_rec_Ro As String, _
                         ByVal _App As SqlConnection, ByVal osysvar As Collection,
                         ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                                 Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                                 Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                                 Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                                 Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                                 Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                                 Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim _Return As DataTable = Nothing
        Select Case _Status
            Case 0
                Dim Frm As New FrmTien_Do_ChuyenTang
                '-----------------------------------------------------------
                Frm.Kieu_Xem = _Kieu_Xem
                Frm.Loai_SC = _Loai_SC
                Frm.Stt_rec_KH = _Stt_rec_KH
                Frm.Stt_rec_Ro = _Stt_rec_Ro

                Frm.Lan = _Lan
                Frm.Para = _Para
                Frm.Sysvar = osysvar
                Frm.AppConn = _App
                Frm.CyberSmlib = CyberSmlib
                Frm.CyberSupport = CyberSupport
                Frm.CyberFill = CyberFill
                Frm.CyberSmlistSys = CyberSmlistSys
                Frm.CyberSmodb = CyberSmodb
                Frm.CyberExport = Nothing
                Frm.CyberVoucher = Nothing
                Frm.CyberLoading = CyberLoading
                Frm.ShowInTaskbar = False
                Frm.ShowDialog()
                If Frm.Save_OK Then _Return = Frm.Dt_Return.Copy Else _Return = Nothing
            Case 1
                Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_Work_Chuyentang_NhanThongDiep", "0#" + _Kieu_Xem + "#" + _Loai_SC + "#" + _Stt_rec_KH + "#" + _Stt_rec_Ro & "#" & _Ma_Dvcs & "#" & _User_name)
                If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), osysvar, _Lan) Then _Return = Nothing Else _Return = Dstmp.Tables(0).Copy
                Dstmp.Dispose()
            Case 2
                Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_Work_Chuyentang_NhanThongDiep", "1#" + _Kieu_Xem + "#" + _Loai_SC + "#" + _Stt_rec_KH + "#" + _Stt_rec_Ro & "#" & _Ma_Dvcs & "#" & _User_name)
                If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), osysvar, _Lan) Then _Return = Nothing Else _Return = Dstmp.Tables(0).Copy
                Dstmp.Dispose()
        End Select
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
#End Region
#Region "Hẹn To KH/Cap nhap KX/mau"
    Public Function V_Hen_To_Kh(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_rec_Hen As String, ByVal _Stt_rec_Ro As String, _
                      ByVal _App As SqlConnection, ByVal osysvar As Collection,
                      ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                       Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                              Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                              Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                              Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                              Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                              Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                              Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As String

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim _So_Ro As String = ""
        Dim _Returnvalue As String = ""
        _So_Ro = CyberSmodb.SQLGetvalue(_App, "So_Ro", "Ph89", "Ma_Dvcs = N'" + _Ma_Dvcs.Trim + "' AND Stt_rec =N'" + _Stt_rec_Ro + "'", CyberSmlib)

        _Returnvalue = _So_Ro
        If _So_Ro.Trim = "" Then
            Dim Frm As New FrmTien_Do_Hen_To_KH
            '-----------------------------------------------------------
            Frm.Kieu_Xem = _Kieu_Xem
            Frm.Loai_SC = _Loai_SC
            Frm.Stt_Rec_hen = _Stt_rec_Hen
            Frm.So_Ro = _So_Ro
            '-----------------------------------------------------------
            Frm.Lan = _Lan
            Frm.Para = _Para
            Frm.Sysvar = osysvar
            Frm.AppConn = _App
            Frm.CyberSmlib = CyberSmlib
            Frm.CyberSupport = CyberSupport
            Frm.CyberFill = CyberFill
            Frm.CyberSmlistSys = CyberSmlistSys
            Frm.CyberSmodb = CyberSmodb
            Frm.CyberExport = CyberEport
            Frm.CyberLoading = CyberLoading

            Frm.ShowInTaskbar = False
            Frm.ShowDialog()
            Dim _Return As Boolean = Frm.Save_OK

            If Not _Return Then
                _Returnvalue = ""
            Else
                _Returnvalue = Frm.M_So_Ro_Return.Trim.ToUpper
            End If
        End If
        Return _Returnvalue
    End Function
    Public Sub V_Cap_Nhap_Mau_Kx(ByVal _Dt_Nguon As DataTable, ByVal _Dt_Dich As DataTable, _
                               Optional ByVal _FieldXe_Nguon As String = "MA_XE", Optional ByVal _FieldXe_Dich As String = "MA_XE", _
                               Optional ByVal _FieldKx_Nguon As String = "MA_KX", Optional ByVal _FieldKx_Dich As String = "MA_KX", _
                               Optional ByVal _FieldMau_Nguon As String = "MA_Mau", Optional ByVal _FieldMau_Dich As String = "MA_Mau")
        If _Dt_Nguon Is Nothing Then Return
        If _Dt_Dich Is Nothing Then Return
        If _Dt_Nguon.Rows.Count = 0 Then Return
        If Not _Dt_Nguon.Columns.Contains(_FieldXe_Nguon) Then Return
        If Not _Dt_Dich.Columns.Contains(_FieldXe_Dich) Then Return

        Dim _Ma_Xe As String = _Dt_Nguon.Rows(0).Item(_FieldXe_Nguon).ToString.Trim.ToUpper
        If _Ma_Xe.Trim = "" Then Return

        Dim _Ma_Kx As String = ""
        Dim _Ma_Mau As String = ""
        If _Dt_Nguon.Columns.Contains(_FieldKx_Nguon) Then _Ma_Kx = _Dt_Nguon.Rows(0).Item(_FieldKx_Nguon).ToString.Trim
        If _Dt_Nguon.Columns.Contains(_FieldMau_Nguon) Then _Ma_Mau = _Dt_Nguon.Rows(0).Item(_FieldMau_Nguon).ToString.Trim

        For i As Integer = 0 To _Dt_Dich.Rows.Count - 1
            If Not _Dt_Dich.Rows(i).Item(_FieldXe_Dich).ToString.Trim.ToUpper = _Ma_Xe Then Continue For
            _Dt_Dich.Rows(i).BeginEdit()
            If _Dt_Dich.Columns.Contains(_FieldKx_Dich) And _Ma_Kx.Trim <> "" Then _Dt_Dich.Rows(i).Item(_FieldKx_Dich) = _Ma_Kx
            If _Dt_Dich.Columns.Contains(_FieldMau_Dich) And _Ma_Mau.Trim <> "" Then _Dt_Dich.Rows(i).Item(_FieldMau_Dich) = _Ma_Mau
            _Dt_Dich.Rows(i).EndEdit()
        Next
        _Dt_Dich.AcceptChanges()

    End Sub
    Public Function V_Update_Mau_KX(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Ma_Xe As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_RO As String, _
            ByVal _App As SqlConnection, ByVal osysvar As Collection,
            ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                    Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                    Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                    Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                    Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                    Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                    Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                    Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmTien_Do_Mau_KX

        Frm.Kieu_Xem = _Kieu_Xem
        Frm.Loai_SC = _Loai_SC
        Frm.Ma_Xe = _Ma_Xe
        Frm.Stt_Rec = _Stt_Rec
        Frm.Stt_Rec_Ro = _Stt_Rec_RO

        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = Nothing
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Dim _Return As DataTable
        If Frm.Save_OK Then _Return = Frm.Dt_Return.Copy Else _Return = Nothing
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
    Public Function V_Update_Ghi_Chu(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_RO As String, _
            ByVal _App As SqlConnection, ByVal osysvar As Collection,
            ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                    Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                    Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                    Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                    Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                    Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                    Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                    Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmTien_Do_Note

        Frm.Kieu_Xem = _Kieu_Xem
        Frm.Loai_SC = _Loai_SC
        Frm.Stt_Rec = _Stt_Rec
        Frm.Stt_rec_Ro = _Stt_Rec_RO

        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = Nothing
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()

        Dim _Return As DataTable
        If Frm.Save_OK Then _Return = Frm.Dt_Return.Copy Else _Return = Nothing
        CyberSmlib.FlushMemorySave()
        Return _Return

    End Function

#End Region
#Region "Xác nhận bắt đầu/Kết thúc sửa chữa SC"
    Public Function V_Xac_Nhan(ByVal _Phuong_Thuc As String, ByVal _StrKTV As String, ByVal _Ghi_Chu As String, ByVal _Loai_XN As String, ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_Rec As String, _
                                ByVal _App As SqlConnection, ByVal osysvar As Collection, ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                                 Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                                 Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                                 Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                                 Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                                 Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                                 Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable
        '---_Kieu_Xem = HEN/KH/XN
        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_Work_XN_BD_KT", _Kieu_Xem & "#" & _Loai_SC & "#" & _Phuong_Thuc & "#" & _StrKTV & "#" & _Stt_Rec & "#" & _Loai_XN & "#" & _Ghi_Chu & "#" & _Ma_Dvcs & "#" & _User_name)
        Dim _Dt_Return As DataTable
        If CyberSupport.V_MsgChk(DsTmp.Tables(0), osysvar, _Lan) Then _Dt_Return = DsTmp.Tables(0).Copy Else _Dt_Return = Nothing
        Return _Dt_Return
    End Function
#End Region
#Region "gợi ý CVDV, Gợi ý khoang,Năng lực xưởng"
    Public Function V_Goi_Y_khoang(ByVal _Strkhoang As String, ByVal M_Ma_Ct As String, ByVal M_Stt_Rec As String, ByVal _Is_One_khoang As String, ByVal _Ma_Xe As String, ByVal _So_Ro As String, ByVal _So_Phut As String, ByVal _Ngay_BD As Date, _
                                                                       ByVal _Loai_Sc As String, ByVal _SCC As String, ByVal _SBD As String, ByVal _SDS As String, ByVal _Muc_SBD As String, ByVal _Muc_SDS As String, _
                                                                        ByVal _App As SqlConnection, ByVal osysvar As Collection,
                               ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                 Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                            Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                        Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                        Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                        Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                        Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                        Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataSet


        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_Work_TinhThoigianRong", _Strkhoang & "#" & M_Ma_Ct & "#" & M_Stt_Rec & "#" & _Is_One_khoang & "#" & _Ma_Xe & "#" & _So_Ro & "#" & _So_Phut & "#" & _Ngay_BD.ToString("yyyyMMdd HH:mm") & "#" & _
                                                                        _Loai_Sc & "#" & _SCC & "#" & _SBD & "#" & _SDS & "#" & _Muc_SBD & "#" & _Muc_SDS & "#" & _
                                                                         "" & "#" & _Ma_Dvcs & "#" & _User_name)
        Dim _Return As DataSet = DsTmp.Copy
        DsTmp.Dispose()
        Return _Return
    End Function
    Public Function V_Goi_Y_khoangDatHen(ByVal _Strkhoang As String, ByVal M_Ma_Ct As String, ByVal M_Stt_Rec As String, ByVal _Is_One_khoang As String, ByVal _Ma_Xe As String, ByVal _So_Ro As String, ByVal _So_Phut As String, ByVal _Ngay_BD As Date, _
                                                                       ByVal _Loai_Sc As String, ByVal _SCC As String, ByVal _SBD As String, ByVal _SDS As String, ByVal _Muc_SBD As String, ByVal _Muc_SDS As String, _
                                                                        ByVal _App As SqlConnection, ByVal osysvar As Collection,
                               ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                 Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                            Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                        Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                        Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                        Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                        Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                        Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataSet


        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_Work_TinhThoigianRongDatHen", _Strkhoang & "#" & M_Ma_Ct & "#" & M_Stt_Rec & "#" & _Is_One_khoang & "#" & _Ma_Xe & "#" & _So_Ro & "#" & _So_Phut & "#" & _Ngay_BD.ToString("yyyyMMdd HH:mm") & "#" & _
                                                                        _Loai_Sc & "#" & _SCC & "#" & _SBD & "#" & _SDS & "#" & _Muc_SBD & "#" & _Muc_SDS & "#" & _
                                                                         "" & "#" & _Ma_Dvcs & "#" & _User_name)
        Dim _Return As DataSet = DsTmp.Copy
        DsTmp.Dispose()
        Return _Return
    End Function
    Public Function V_Tinh_Khoang(ByVal _Kieu_Xem As String, ByVal _Loai_SC As String, ByVal _Stt_rec As String, ByVal _Ma_Ct As String, ByVal _Ma_Xe As String, ByVal _So_Ro As String, _
                 ByVal _So_phut As Decimal, ByVal _Ngay_Bd As Date, ByVal _Ngay_Kt As Date, _
                 ByVal _App As SqlConnection, ByVal osysvar As Collection,
                 ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                         Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                         Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                         Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                         Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                         Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                         Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                         Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataSet

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmTien_Do_TimKhoang

        Frm.Kieu_Xem = _Kieu_Xem
        Frm.Loai_SC = _Loai_SC
        Frm.So_Phut = _So_phut
        Frm.Ngay_BD0 = _Ngay_Bd
        Frm.Ngay_KT0 = _Ngay_Kt
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        If Not Frm.Save_OK Then Return Nothing

        Return Frm.Ds_Return

        CyberSmlib.FlushMemorySave()
    End Function
#End Region
#Region "Support"
    Public Function V_GetvalueCombox(ByVal _Cbb As ComboBox) As String
        Dim _Return As String = ""
        Try
            _Return = _Cbb.SelectedValue.ToString.Trim
        Catch ex As Exception

        End Try
        V_GetvalueCombox = _Return
    End Function
    Public Function V_StringToNumeric(ByVal _Cbb As ComboBox) As Decimal
        Dim _Return As Decimal = 0
        Dim _Value As String = V_GetvalueCombox(_Cbb)
        If _Value.Trim = "" Then _Value = "0"
        Try
            _Return = CType(_Value, Decimal)
        Catch ex As Exception
        End Try
        V_StringToNumeric = _Return
    End Function
    Public Sub V_GetDataview(ByRef _Dt As DataTable, ByRef _Dv As DataView)
        If _Dt Is Nothing Then Return
        _Dv = New DataView(_Dt)
    End Sub
    Public Function V_GetTbRowEmpty(ByVal _Dt As DataTable, ByVal _Fieldname As String) As DataTable
        If _Dt Is Nothing Then Return Nothing
        Dim _Return As DataTable = _Dt.Copy
        _Fieldname = _Fieldname.Trim
        If Not _Return.Columns.Contains(_Fieldname) Then Return Nothing

        _Fieldname = _Return.Columns(_Fieldname).ColumnName
        Dim nCount As Integer = _Return.Rows.Count - 1
        For i As Integer = nCount To 0 Step -1
            If _Return.Rows(i).Item(_Fieldname).ToString.Trim = "" Then _Return.Rows(i).Delete()
        Next
        _Return.AcceptChanges()
        Return _Return
    End Function
    Public Sub V_GetColorBold(ByVal _Dt As DataTable, ByRef _Bold As Boolean, ByRef _BackColor As Boolean, ByRef _BackColor2 As Boolean, ByRef _ForeColor As Boolean, ByRef _FieldBold As String, ByRef _FieldBackColor As String, ByRef _FieldBackColor2 As String, ByRef _FieldForeColor As String)
        If _Dt Is Nothing Then Return
        If _Dt.Columns.Contains("Bold") Then
            _Bold = True
            _FieldBold = _Dt.Columns("Bold").ColumnName
        End If
        If _Dt.Columns.Contains("Backcolor") Then
            _BackColor = True
            _FieldBackColor = _Dt.Columns("Backcolor").ColumnName
        End If
        If _Dt.Columns.Contains("Backcolor2") Then
            _BackColor2 = True
            _FieldBackColor2 = _Dt.Columns("Backcolor2").ColumnName
        End If
        If _Dt.Columns.Contains("Forecolor") Then
            _ForeColor = True
            _FieldForeColor = _Dt.Columns("Forecolor").ColumnName
        End If
    End Sub
    Public Sub V_GetColorBold2(ByVal _Dt As DataTable, ByRef _Bold As Boolean, ByRef _BackColor As Boolean, ByRef _BackColor2 As Boolean, ByRef _ForeColor As Boolean, ByRef _Underline As Boolean, _
                               ByRef _FieldBold As String, ByRef _FieldBackColor As String, ByRef _FieldBackColor2 As String, ByRef _FieldForeColor As String, ByRef _FieldUnderLine As String)
        If _Dt Is Nothing Then Return
        If _Dt.Columns.Contains("Bold") Then
            _Bold = True
            _FieldBold = _Dt.Columns("Bold").ColumnName
        End If
        If _Dt.Columns.Contains("Backcolor") Then
            _BackColor = True
            _FieldBackColor = _Dt.Columns("Backcolor").ColumnName
        End If
        If _Dt.Columns.Contains("Backcolor2") Then
            _BackColor2 = True
            _FieldBackColor2 = _Dt.Columns("Backcolor2").ColumnName
        End If
        If _Dt.Columns.Contains("Forecolor") Then
            _ForeColor = True
            _FieldForeColor = _Dt.Columns("Forecolor").ColumnName
        End If
        If _Dt.Columns.Contains("UnderLine") Then
            _Underline = True
            _FieldUnderLine = _Dt.Columns("UnderLine").ColumnName
        End If
    End Sub
    Public Function FindItemInArr(ByVal _value As String, ByVal arr_txt As String, ByVal strSplit As String)
        If _value = "" Or arr_txt = "" Then Return -1
        Dim arr() As String = arr_txt.Split(strSplit)
        For i = 0 To arr.Length - 1
            If arr(i).ToString.ToUpper() = _value.ToUpper() Or "COL_" + arr(i).ToString.ToUpper() = _value.ToUpper() Then
                Return i
            End If
        Next
        Return -1
    End Function
    Public Function V_Gettable(ByVal _iTb As Integer, ByVal _Ds As DataSet) As DataTable
        Dim _Return As DataTable = Nothing
        _Return = _Ds.Tables(_iTb).Copy
        Return _Return
    End Function
    Public Sub V_Print(ByVal _App As SqlConnection, ByVal _ma_Dvcs As String, ByVal _Lan As String, ByVal Loai_IN As String, ByVal Loai_Tien As Boolean, ByVal Ngon_ngu As Boolean, ByVal M_Reports As String, ByVal DsDataReport As DataSet, ByVal M_Title1 As String, ByVal M_Title2 As String, ByVal oSysVar As Collection, ByVal M_PARA As String())
        Dim ClssPrint As New Cyber.Print.Sys
        ClssPrint.CyberPrintReport(_App, Loai_IN, M_Reports, DsDataReport, M_Title1, M_Title2, oSysVar, M_PARA, _ma_Dvcs, False, "", _Lan, Loai_Tien, Ngon_ngu)
        GC.Collect()
    End Sub
    Public Sub V_PreviewLenh(ByVal M_Kieu_Xem As String, ByVal M_Loai_SC As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String, ByVal _ma_Dvcs As String, ByVal _User_Name As String, ByVal _Para As String(), ByVal AppConn As SqlConnection, ByVal osysvar As Collection, ByVal M_Lan As String, _
                      Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                      Optional ByVal CyberVoucher As Cyber.Voucher.Sys = Nothing, _
                      Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                      Optional ByVal CyberPrint As Cyber.Print.Sys = Nothing)

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberVoucher Is Nothing Then CyberVoucher = New Cyber.Voucher.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberPrint Is Nothing Then CyberPrint = New Cyber.Print.Sys

        Dim DsDataReport As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Preview", M_Kieu_Xem & "#" & M_Loai_SC & "#" & _Stt_Rec & "#" & _Stt_Rec_Ro & "#" & _ma_Dvcs + "#" & _User_Name)

        If Not CyberSupport.V_MsgChk(DsDataReport.Tables(0), osysvar, M_Lan) Then
            DsDataReport.Dispose()
            Exit Sub
        End If

        Dim Loai_IN As String = "1"
        Dim M_Reports As String = DsDataReport.Tables(0).Rows(0).Item("Repo_Name").ToString.Trim
        Dim M_Title1 As String = DsDataReport.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        Dim M_Title2 As String = DsDataReport.Tables(0).Rows(0).Item("M_Title").ToString.Trim

        DsDataReport.Tables.Remove(DsDataReport.Tables(0))

        Dim Loai_Tien As Boolean = True
        Dim Ngon_ngu As Boolean = True

        CyberPrint.CyberPrintReport(AppConn, Loai_IN, M_Reports, DsDataReport, M_Title1, M_Title2, osysvar, _Para, _ma_Dvcs, False, "", M_Lan, Loai_Tien, Ngon_ngu)

        DsDataReport.Dispose()
    End Sub
    Public Function V_Msgbox_Delete(ByVal osysvar As Collection, ByVal _Title As String) As Boolean
        Dim _Return As Boolean = False
        If MsgBox(_Title, MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, osysvar("M_CYBER_VER")) = MsgBoxResult.Ok Then _Return = True
        V_Msgbox_Delete = _Return
    End Function
    Public Sub V_DeleteTable(ByVal _Dt As DataTable, ByVal _Value As String, ByVal _FieldName As String)
        If _Dt Is Nothing Then Return
        _FieldName = _FieldName.Trim
        If Not _Dt.Columns.Contains(_FieldName) Then Exit Sub
        _FieldName = _Dt.Columns(_FieldName).ColumnName
        Dim nCount As Integer = _Dt.Rows.Count - 1
        For i = nCount To 0 Step -1
            If _Dt.Rows(i).Item(_FieldName).ToString.Trim.ToUpper = _Value.Trim.ToUpper Then _Dt.Rows.RemoveAt(i) '_Dt.Rows(i).Delete()
        Next
        '    _Dt.AcceptChanges()
    End Sub
    Public Function V_PercentComplete(ByVal _Ngay_Bd As DateTime, ByVal _Ngay_Kt As DateTime, ByVal _Ngay_HT As DateTime, Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing) As Decimal
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        Dim _Return As Decimal = 0

        Dim Tong As Decimal = V_GetTimeM_Tinh_TG_THUC(_Ngay_Bd, _Ngay_Kt)
        Dim Thuc_Hien As Decimal = V_GetTimeM_Tinh_TG_THUC(_Ngay_Bd, _Ngay_HT)

        If Tong <> 0 Then _Return = CyberSupport.V_Round(100 * Thuc_Hien / Tong, 0)

        If _Ngay_HT >= _Ngay_Kt Then _Return = 100
        If _Ngay_HT <= _Ngay_Bd Then _Return = 0

        If _Return > 100 Then _Return = 0
        If _Return < 0 Then _Return = 0
        V_PercentComplete = _Return
    End Function
#End Region
#Region "Cong phut"
    Public Function V_AddTime(ByVal _Ngay_BD As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH, ByVal _Tg As ClsTextBox.txtTien_NT, ByVal Appconn As SqlConnection, ByVal Cybersmlib As Cyber.SmLib.Sys, ByVal _ma_Dvcs As String) As Date
        Dim Ngay_BD As Date = _Ngay_BD.Value
        Dim Tg As Decimal = _Tg.Double
        V_AddTime = V_AddTime(Ngay_BD, Tg, Appconn, Cybersmlib, _ma_Dvcs)
    End Function
    Public Function V_AddTime(ByVal DFrom As Date, ByVal TG As Decimal, ByVal Appconn As SqlConnection, ByVal Cybersmlib As Cyber.SmLib.Sys, ByVal _ma_Dvcs As String) As Date
        If Cybersmlib Is Nothing Then Cybersmlib = New Cyber.SmLib.Sys
        Dim DsTmp As DataSet = Cybersmlib.SQLExcuteStoreProcedure(Appconn, "CP_AddMinute", DFrom.ToString("yyyyMMdd HH:mm") + "#" + TG.ToString.Trim.Replace(" ", "").Replace(",", ".") + "#" + _ma_Dvcs)
        Dim _Return As Date = DsTmp.Tables(0).Rows(0).Item("Value")
        DsTmp.Dispose()
        V_AddTime = _Return
    End Function
#End Region
#Region "Lay so phut"
    Public Function V_GetTimeM_LUU(ByRef Ngay_BD As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH, ByRef Ngay_KT As Cyber.ClsTxtDateTime.ClsTxtDateTime.txtHDateH) As Decimal
        'Dim _Ngay_BD As Date = Ngay_BD.Value
        'Dim _Ngay_KT As Date = Ngay_KT.Value
        'V_GetTimeM = V_GetTimeM(_Ngay_BD, _Ngay_KT)
        Return 0
    End Function
    Public Function V_GetTimeM_Tinh_TG_THUC(ByVal _Ngay_BD As Date, ByVal _Ngay_KT As Date) As Decimal
        Dim _Ngay_TG As Date
        Dim _Hour8h, _Hour12h, _Hour13h, _Hour17h As Integer
        Dim _Minute8h, _Minute12h, _Minute13h, _Minute17h As Integer
        Dim _So_phut_BD, _So_phut_KT, _So_Ngay, _So_Ngay_CN As Integer
        Dim _Return As Integer = 0
        Dim _cn As String
        'Lấy ngày chuẩn 00:00 
        Dim _Ngay0_BD, _Ngay0_KT, _Ngay08h_BD, _Ngay012h_BD, _Ngay013h_BD, _Ngay017h_BD, _Ngay08h_KT, _Ngay012h_KT, _Ngay013h_KT, _Ngay017h_KT As Date

        _Ngay0_BD = _Ngay_BD.Date
        _Ngay0_KT = _Ngay_KT.Date

        _So_Ngay = 0
        _So_Ngay_CN = 0

        _Hour8h = 8
        _Hour12h = 12
        _Hour13h = 13
        _Hour17h = 17

        _Minute8h = 0
        _Minute12h = 0
        _Minute13h = 0
        _Minute17h = 0

        _Ngay08h_BD = _Ngay0_BD.AddHours(_Hour8h).AddMinutes(_Minute8h)
        _Ngay012h_BD = _Ngay0_BD.AddHours(_Hour12h).AddMinutes(_Minute12h)
        _Ngay013h_BD = _Ngay0_BD.AddHours(_Hour13h).AddMinutes(_Minute13h)
        _Ngay017h_BD = _Ngay0_BD.AddHours(_Hour17h).AddMinutes(_Minute17h)

        _Ngay08h_KT = _Ngay0_KT.AddHours(_Hour8h).AddMinutes(_Minute8h)
        _Ngay012h_KT = _Ngay0_KT.AddHours(_Hour12h).AddMinutes(_Minute12h)
        _Ngay013h_KT = _Ngay0_KT.AddHours(_Hour13h).AddMinutes(_Minute13h)
        _Ngay017h_KT = _Ngay0_KT.AddHours(_Hour17h).AddMinutes(_Minute17h)

        If _Ngay_BD < _Ngay08h_BD Then _Ngay_BD = _Ngay08h_BD
        If _Ngay_BD < _Ngay013h_BD And _Ngay_BD > _Ngay012h_BD Then _Ngay_BD = _Ngay013h_BD
        If _Ngay_BD > _Ngay017h_BD Then _Ngay_BD = _Ngay017h_BD

        If _Ngay_KT < _Ngay08h_KT Then _Ngay_KT = _Ngay08h_KT
        If _Ngay_KT < _Ngay013h_KT And _Ngay_KT > _Ngay012h_KT Then _Ngay_KT = _Ngay013h_KT
        If _Ngay_KT > _Ngay017h_KT Then _Ngay_KT = _Ngay017h_KT

        If _Ngay_BD.DayOfWeek = 0 Then
            _Ngay08h_BD = _Ngay08h_BD.AddDays(1)
            _Ngay_BD = _Ngay08h_BD
        End If

        If _Ngay_KT.DayOfWeek = 0 Then
            _Ngay017h_KT = _Ngay017h_KT.AddDays(-1)
            _Ngay_KT = _Ngay017h_KT
        End If

        _So_phut_BD = DateDiff(DateInterval.Minute, _Ngay08h_BD, _Ngay_BD)
        _So_phut_KT = DateDiff(DateInterval.Minute, _Ngay_KT, _Ngay017h_KT)
        _So_Ngay = DateDiff(DateInterval.Day, _Ngay_BD.Date, _Ngay_KT.Date)

        If _So_phut_BD > 240 Then _So_phut_BD = _So_phut_BD - 60
        If _So_phut_KT > 240 Then _So_phut_KT = _So_phut_KT - 60


        '-----Tính toán 
        '---Ngày BD > Ngày KT 
        If _So_Ngay < 0 Then _Return = 0

        '--Cùng ngày 
        If _So_Ngay = 0 Then
            _Return = _Return + 480 - _So_phut_BD - _So_phut_KT
        End If

        '--khác ngày 
        If _So_Ngay > 0 Then
            _Return = _Return + _So_Ngay * 480 + 480 - _So_phut_BD - _So_phut_KT
            '-----Tính số ngày cn 
            _Ngay_TG = _Ngay_BD.Date

            While _Ngay_TG < _Ngay_KT
                _cn = _Ngay_TG.DayOfWeek
                If _cn = 0 Then _So_Ngay_CN = _So_Ngay_CN + 1
                _Ngay_TG = _Ngay_TG.Date.AddDays(1)
            End While
            _Return = _Return - _So_Ngay_CN * 480
        End If
        If _Return < 0 Then _Return = 0
        Return _Return
    End Function
    Public Function V_GetTimeM(ByVal DFrom As Date, ByVal Dto As Date, ByVal Appconn As SqlConnection, ByVal Cybersmlib As Cyber.SmLib.Sys, ByVal _ma_Dvcs As String) As Decimal
        If Cybersmlib Is Nothing Then Cybersmlib = New Cyber.SmLib.Sys
        Dim DsTmp As DataSet = Cybersmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetMinuteDateToDate", DFrom.ToString("yyyyMMdd HH:mm") + "#" + Dto.ToString("yyyyMMdd HH:mm") + "#" + _ma_Dvcs)
        Dim _Return As Decimal = DsTmp.Tables(0).Rows(0).Item("Value")
        DsTmp.Dispose()
        V_GetTimeM = _Return
    End Function
#End Region
#Region "Do xe"
    Public Function V_Do_Xe(ByVal _Ma_Xe As String, ByVal _Kieu_xem As String, ByVal _ma_loai As String, ByVal _Ma_Tang As String, ByVal _App As SqlConnection, ByVal osysvar As Collection,
            ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                    Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                    Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                    Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                    Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                    Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                    Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                    Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmTien_Do_VitriDo
        Frm.Ma_Xe = _Ma_Xe
        Frm.M_Ma_Tang = _Ma_Tang
        Frm.M_Loai = _ma_loai
        Frm.M_kieu_Xem = _Kieu_xem
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = Nothing
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Dim Dt_Vitri As DataTable
        If Frm.Save_OK Then Dt_Vitri = Frm.Dt_Return
        Return Dt_Vitri
    End Function
    Public Sub V_Do_Xe_Load(ByVal _Ma_Xe As String, ByVal _Kieu_xem As String, ByVal _ma_loai As String, ByVal _Ma_Tang As String, ByVal _App As SqlConnection, ByVal osysvar As Collection,
           ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                   Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                   Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                   Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                   Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                   Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                   Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                   Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing)

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmTien_Do_VitriDo_Vitri
        Frm.M_Ma_Xe = _Ma_Xe
        Frm.M_Ma_Tang = _Ma_Tang
        Frm.M_Loai = _ma_loai
        Frm.M_kieu_Xem = _Kieu_xem
        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = Nothing
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        'Dim Dt_Vitri As DataTable
        'If Frm.Save_OK Then Dt_Vitri = Frm.Dt_Return
        'Return Dt_Vitri
    End Sub

#End Region
#Region "Rua xe"
    Public Function V_KH_CW(ByVal _Ma_TTCP As String, ByVal _Loai_SC As String, ByVal _Mode As String, ByVal _Stt_Rec As String, ByVal _Ma_Khoang As String, ByVal _Ngay_BD As Date, ByVal _Ngay_KT As Date, ByVal _Tg_Sc As Integer, _
            ByVal _App As SqlConnection, ByVal osysvar As Collection,
            ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                    Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                    Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                    Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                    Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                    Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                    Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                    Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmCW_F34

        Frm.Ma_TTCP = _Ma_TTCP
        Frm.Loai_SC = _Loai_SC
        Frm.Stt_rec = _Stt_Rec
        Frm.Mode = _Mode
        Frm.Ma_khoang = _Ma_Khoang
        Frm.Ngay_BD = _Ngay_BD
        Frm.Ngay_KT = _Ngay_KT
        Frm.Tg_SC = _Tg_Sc

        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = Nothing
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Return Frm.Dt_Return
    End Function
#End Region

#Region "Scheduler"
    Public Sub V_Lap_F3F4(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentFormEventArgs)
        e.Handled = True
    End Sub
#End Region

#Region "Cấp Stt"
    Public Function V_Cap_Stt(ByVal _Stt_Rec As String, ByVal _Mode As String, _
                       ByVal _App As SqlConnection, ByVal osysvar As Collection,
                       ByVal _Lan As String, ByVal _Para As String(), ByVal _Ma_Dvcs As String, ByVal _User_name As String, _
                                Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, _
                               Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                               Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
                               Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
                               Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
                               Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
                               Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing) As DataTable

        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmCapStt_F3
        '-------------------------------------------------------------------------------------------------------------------
        Frm.Stt_Rec = _Stt_Rec
        Frm.Mode = _Mode

        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberLoading = CyberLoading

        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        Dim _Return As DataTable
        If Frm.Save_OK Then _Return = Frm.M_Dt_Return.Copy Else _Return = Nothing
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
#End Region
End Class
Public Class GridviewDragDrop
    Dim downHitInfo As GridHitInfo = Nothing
    Dim _GridDrag As New DevExpress.XtraGrid.GridControl
    Dim _CtrDrop As New Control
    Dim _GrvDrag As New GridView
    Public _ActiDraDrop As Boolean = False
    Public Sub New()
    End Sub
    Public Sub New(ByVal Grid_keo As DevExpress.XtraGrid.GridControl, ByVal Cotrol_Tha As Control)
        _GridDrag = Grid_keo
        _CtrDrop = Cotrol_Tha
        _CtrDrop = IIf(Cotrol_Tha Is Nothing, Grid_keo, Cotrol_Tha)
        '_CtrDrop.AllowDrop = True
        _GridDrag.AllowDrop = True
        _GrvDrag = TryCast(_GridDrag.MainView, GridView)
        V_Addhandler()
    End Sub
    Private Sub V_Addhandler()
        AddHandler _GrvDrag.MouseMove, AddressOf view_MouseMove
        AddHandler _GrvDrag.MouseDown, AddressOf view_MouseDown
        AddHandler _CtrDrop.DragOver, AddressOf grid_DragOver
    End Sub
    Private Sub view_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)
        _ActiDraDrop = False
        Dim view As GridView = TryCast(sender, GridView)
        downHitInfo = Nothing
        Dim hitInfo As GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
        If Control.ModifierKeys <> Keys.None Then
            Return
        End If
        If e.Button = MouseButtons.Left AndAlso hitInfo.RowHandle >= 0 Then
            downHitInfo = hitInfo
            _ActiDraDrop = True
        End If
    End Sub
    Private Sub view_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)
        Dim view As GridView = TryCast(sender, GridView)
        If e.Button = MouseButtons.Left AndAlso downHitInfo IsNot Nothing Then
            Dim dragSize As Size = SystemInformation.DragSize
            Dim dragRect As New Rectangle(New Point(downHitInfo.HitPoint.X - dragSize.Width / 2, downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize)
            If (Not dragRect.Contains(New Point(e.X, e.Y))) Then
                Dim row As DataRow = view.GetDataRow(downHitInfo.RowHandle)
                view.GridControl.DoDragDrop(row, DragDropEffects.Move)
                downHitInfo = Nothing
                DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = True
            End If
        End If
    End Sub
    Private Sub grid_DragOver(ByVal sender As Object, ByVal e As DragEventArgs)
        e.Effect = DragDropEffects.Move
    End Sub
End Class
Public Class CyberMenuPopup
    Inherits DevExpress.XtraBars.BarButtonItem
    Dim V_kh As System.EventHandler
    Public Sub New(ByVal view As Object, ByVal rowHandle As Integer, ByVal Title As String, ByVal handel As EventHandler, Optional ByVal img As Image = Nothing, Optional ByVal _Enabled As Boolean = True, Optional ByVal _Group As Boolean = False)
        Me.Caption = Title
        Me.Glyph = img
        Me.Enabled = _Enabled
        V_kh = handel
        AddHandler Me.ItemClick, AddressOf CyberLeave
        Me.Name = Name
    End Sub
    Public Sub New(ByVal view As Object, ByVal rowHandle As Integer, ByVal Title As String, ByVal handel As EventHandler, ByVal _ShortCut As System.Windows.Forms.Shortcut, Optional ByVal img As Image = Nothing, Optional ByVal _Enabled As Boolean = True, Optional ByVal _ShowShortCut As DevExpress.Utils.DefaultBoolean = DevExpress.Utils.DefaultBoolean.False)
        Me.Caption = Title
        Me.Glyph = img
        Me.Enabled = _Enabled
        Me.ShortCut = _ShortCut
        'Me.ShowItemShortcut = _ShowShortCut
        V_kh = handel
        AddHandler Me.ItemClick, AddressOf CyberLeave
        Me.Name = Name
    End Sub
    Private Sub CyberLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not V_kh Is Nothing Then V_kh(sender, e)
    End Sub
End Class
Public Class CyberBarSubMenuPopup
    Inherits DevExpress.XtraBars.BarSubItem
    Public Sub New(ByVal view As Object, ByVal rowHandle As Integer, ByVal Title As String, ByVal handel As EventHandler, Optional ByVal img As Image = Nothing, Optional ByVal _Enabled As Boolean = True, Optional ByVal _Group As Boolean = False)
        Me.Caption = Title
        Me.Glyph = img
        Me.Enabled = _Enabled
        Me.Name = Name
    End Sub
    Public Class CustomMouseHandlerService
        Inherits DevExpress.Services.MouseHandlerServiceWrapper
        Private provider As IServiceProvider
        Public Sub New(ByVal provider As IServiceProvider, ByVal service As DevExpress.Services.IMouseHandlerService)
            MyBase.New(service)
            Me.provider = provider
        End Sub
        Public Overrides Sub OnMouseWheel(ByVal e As System.Windows.Forms.MouseEventArgs)
            Dim scheduler As SchedulerControl = TryCast(provider, SchedulerControl)

            If scheduler IsNot Nothing AndAlso scheduler.ActiveViewType = SchedulerViewType.Gantt Then
                Return
            End If

            MyBase.OnMouseWheel(e)
        End Sub
    End Class
End Class