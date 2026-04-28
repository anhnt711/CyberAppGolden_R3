Imports Cyber.Smreports
Imports System.Data.SqlClient
Public Class Sys
    Public oReportFormLib As Cyber.Smreports.FrmRepports_Banded
    Dim M_Para As String()
    Public M_Loai_BC As String = "VND"
    Public oSysVar As New Collection()
    Public M_strParameterStore As String = ""
    Public M_strFieldValue As String = ""
    Public M_strFieldName As String = ""
    Public M_Loai_DK_Loc As String = "0"
    Public Sub main()
        'Dim M_Para As String()
        'Dim abc As String
        'abc = "14#C:\#E:\Project\Cyber_TMV\System\#E:\Project\Cyber_TMV\Repo\#E:\Project\Cyber_TMV\Repo-nt\#Cyber Enterprice#ABC#Admin#True#1#02.05.00#Phiếu thu tiền mặt#Cash on hand receipt#V#02#CP_GLSO1"
        ''abc = "14#C:\#E:\Project\Cyber_TMV\System\#E:\Project\Cyber_TMV\Repo\#E:\Project\Cyber_TMV\Repo-nt\#Cyber Enterprice#ABC#Admin#True#1#02.05.00#Phiếu thu tiền mặt#Cash on hand receipt#V#02#CP_GLCD1"
        'M_Para = abc.Trim.Split("#")
        'Initvao1(M_Para)
    End Sub
    Public Function V_GetFrmFilter(ByVal Cp_Name As String, ByVal status As String) As Cyber.From.FilterReport
        Dim _Return As Cyber.From.FilterReport = Nothing

        Select Case Cp_Name.ToString.Trim.ToUpper
            Case "CP_SYSTH1_BAN_LOC_TEN_THU_TUC_O_DAY".Trim.ToUpper
                '--CYBERSOFT Cho Phép bạn Hiệu chỉnh ở phần này
                _Return = New SysTH1
            Case "CP_POTH29".Trim.ToUpper
                _Return = New GLTC27
                '    _Return = New BESO1
                '    'BE ------------------------------------------------------------------------------------------------------------------------------
                'Case "CP_BESO1".Trim.ToUpper, "CP_BEXSO1".Trim.ToUpper
                '    _Return = New BESO1
                'Case "CP_BETH1".Trim.ToUpper, "CP_BEBK11".Trim.ToUpper
                '    _Return = New BETH1
                'Case "CP_BECD1".Trim.ToUpper, "CP_BEXCD1".Trim.ToUpper
                '    _Return = New BECD1
                'Case "CP_BEBK1"
                '    _Return = New BETH1
                'Case "CP_BEBK1".Trim.ToUpper
                '    _Return = New BETH1
                'Case "CP_BEXTH1".Trim.ToUpper, "CP_BEXBK1".Trim.ToUpper, "CP_BEXBK11".Trim.ToUpper, "CP_BEXBK12".Trim.ToUpper, "CP_BEBK12".Trim.ToUpper
                '    _Return = New BEXTH1
                'Case "CP_BECD2".Trim.ToUpper, "CP_BEXCD2".Trim.ToUpper
                '    _Return = New BECD2
                'Case "CP_BEKQKD_HDC".Trim.ToUpper, "CP_BEKQKD_HDC_DETAIL"
                '    _Return = New BEKQKD_HDC
                'Case "CP_BEKQKD_HDX".Trim.ToUpper, "CP_BEKQKD_HDX_DETAIL"
                '    _Return = New BEKQKD_HDX
                'Case "CP_BEKH6_HDX_HDC".Trim.ToUpper, "CP_BEKH6_HDX_HDC_DETAIL"
                '    _Return = New BEKH6_HDX_HDC

                '    'RO ------------------------------------------------------------------------------------------------------------------------------
                '    'RO RVR (Xe vao ra) 
                'Case "CP_RORVRBK1", "CP_RORVRTH1"
                '    _Return = New RORVRBK1
                'Case "CP_RORVRXeTon".ToUpper.Trim
                '    _Return = New RORVRXeTon
                '    'RO -HDK-HDP-HDM (Bao cao theo lenh sua chua)
                'Case "CP_ROHDKBK1"
                '    _Return = New ROHDKBK1
                'Case "CP_ROHDKTH1"
                '    _Return = New ROHDKTH1
                'Case "CP_ROBCTH_HDK", "CP_ROBCTH_HDK_DETAIL"
                '    _Return = New ROBCTHHDK
                '    'RO HDS ------------------------------------------------------------------------------------------------------------------------------
                'Case "CP_ROBCTH_HDS", "CP_ROBCTH_HDS_DETAIL"
                '    _Return = New ROBCTHHDS
                '    'RO PT5------------------------------------------------------------------------------------------------------------------------------
                'Case "CP_ROPT5BK1", "CP_ROPT5TH1"
                '    _Return = New ROPT5BK1
            Case Else
                _Return = Nothing
        End Select


        V_GetFrmFilter = _Return
    End Function
    'Public Function Initvao(ByVal _Para As String()) As Boolean
    '    M_Para = _Para
    '    '--------------------------------------------------------------------------------------------------------------------
    '    Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
    '    Dim K_Tmp As String = M_Para(1).Trim
    '    Dim K_System As String = M_Para(2).Trim
    '    Dim K_Repo As String = M_Para(3).Trim
    '    Dim K_Repo_Nt As String = M_Para(4).Trim
    '    Dim M_CYBER_VER As String = M_Para(5).Trim
    '    Dim M_User_Name As String = M_Para(6).Trim
    '    Dim M_Comment As String = M_Para(7).Trim
    '    Dim M_is_Admin As Boolean = CType(M_Para(8), Boolean)
    '    Dim M_User_ID As String = M_Para(9).Trim
    '    Dim M_Menu_ID0 As String = M_Para(10).Trim
    '    Dim M_Bar As String = M_Para(11).Trim
    '    Dim M_Bar2 As String = M_Para(12).Trim
    '    Dim M_LAN As String = M_Para(13).Trim
    '    Dim M_Ma_Dvcs As String = M_Para(14).Trim
    '    Dim M_Cp_Name As String = M_Para(M_VT_PARA + 1).Trim
    '    '--------------------------------------------------------------------------------------------------------------------
    '    Dim FrmFilter As Cyber.From.FilterReport
    '    FrmFilter = V_GetFrmFilter(M_Cp_Name, "1")

    '    Dim CyberSmLib As New Cyber.SmLib.Sys
    '    Dim Appconn As SqlConnection = CyberSmLib.GetConn()
    '    oSysVar = CyberSmLib.IniSysVar(Appconn, M_Ma_Dvcs, M_User_Name)
    '    '--------------------------------------------------------------------------------------------------------------------
    '    FrmFilter.Para = M_Para
    '    FrmFilter.sysvar = oSysVar
    '    FrmFilter.AppConn = Appconn
    '    FrmFilter.DtUnists = V_GetUnists(Appconn, M_Ma_Dvcs, M_User_Name, CyberSmLib)
    '    '--------------------------------------------------------------------------------------------------------------------
    '    M_Loai_BC = IIf(M_LAN = "V", "VND", "NT")
    '    '--------------------------------------------------------------------------------------------------------------------
    '    FrmFilter.ShowDialog()
    '    If Not FrmFilter.is_continue Then Return False
    '    M_Loai_DK_Loc = "0"
    '    M_strParameterStore = FrmFilter.Tag.ToString
    '    V_Loaddata(M_Cp_Name, M_strParameterStore, oReportFormLib, "1", M_Loai_DK_Loc, FrmFilter)
    '    Return True
    'End Function
    'Private Sub V_Loaddata(ByVal sCp_name As String, ByVal strParastore As String, ByVal oReportFormLib As Cyber.Smreports.FrmRepports_Banded, ByVal loadtype As String, ByVal Loai_DK_Loc As String, Optional ByVal FrmFilter As Form = Nothing)
    '    oReportFormLib = New Cyber.Smreports.FrmRepports_Banded
    '    If FrmFilter Is Nothing Then oReportFormLib.FrmFilter = Nothing Else oReportFormLib.FrmFilter = FrmFilter
    '    oReportFormLib.SysVar = oSysVar
    '    oReportFormLib.Para = M_Para
    '    oReportFormLib.Loai_BC = M_Loai_BC
    '    oReportFormLib.Cp_name = sCp_name
    '    oReportFormLib.strParastore = strParastore
    '    oReportFormLib.strFieldValue = M_strFieldValue
    '    oReportFormLib.strFieldName = M_strFieldName
    '    oReportFormLib.Ma_Dvcs = M_Para(14).Trim ' M_Ma_Dvcs
    '    oReportFormLib.User_name = M_Para(6).Trim ' M_User_Name
    '    oReportFormLib.Loai_DK_Loc = Loai_DK_Loc
    '    oReportFormLib.Lan = M_Para(13).Trim ' M_LAN
    '    AddHandler oReportFormLib.DetailReport, AddressOf V_Detail
    '    AddHandler oReportFormLib.QuickDetailReport, AddressOf V_QuickDetail
    '    oReportFormLib.ShowDialog()
    'End Sub
    '#Region "Detail Reports"
    '    Sub V_Detail(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal cpnameDetail As String, ByVal strParasource As String, ByVal strParasourceDetail As String, ByVal DrvDetail As DataRowView, ByVal Loai_DK_Loc As String)
    '        If DrvDetail Is Nothing Then Exit Sub
    '        If cpname.Trim = "" Or cpnameDetail.Trim = "" Then Exit Sub
    '        Dim oReportFrm As New Cyber.Smreports.FrmRepports_Banded
    '        Dim frm As Cyber.From.FilterReport
    '        frm = V_GetFrmFilter(cpnameDetail, "0")
    '        Dim _ParaNew As String() = V_GetPara(cpnameDetail, M_Para, strParasource)
    '        Dim _ParaOld As String() = M_Para
    '        M_Para = _ParaNew
    '        '--------------------------------------------------------------------------------------------------------------------
    '        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
    '        Dim K_Tmp As String = M_Para(1).Trim
    '        Dim K_System As String = M_Para(2).Trim
    '        Dim K_Repo As String = M_Para(3).Trim
    '        Dim K_Repo_Nt As String = M_Para(4).Trim
    '        Dim M_CYBER_VER As String = M_Para(5).Trim
    '        Dim M_User_Name As String = M_Para(6).Trim
    '        Dim M_Comment As String = M_Para(7).Trim
    '        Dim M_is_Admin As Boolean = CType(M_Para(8), Boolean)
    '        Dim M_User_ID As String = M_Para(9).Trim
    '        Dim M_Menu_ID0 As String = M_Para(10).Trim
    '        Dim M_Bar As String = M_Para(11).Trim
    '        Dim M_Bar2 As String = M_Para(12).Trim
    '        Dim M_LAN As String = M_Para(13).Trim
    '        Dim M_Ma_Dvcs As String = M_Para(14).Trim
    '        Dim M_Cp_Name As String = M_Para(M_VT_PARA + 1).Trim
    '        '--------------------------------------------------------------------------------------------------------------------

    '        If Not frm Is Nothing Then
    '            frm.Tag = strParasourceDetail
    '            frm.Para = M_Para
    '            frm.sysvar = oSysVar
    '            Dim CyberSmLib As New Cyber.SmLib.Sys
    '            Dim Appconn As SqlConnection = CyberSmLib.GetConn()
    '            'Dim oSysVar As New Collection()
    '            oSysVar = CyberSmLib.IniSysVar(Appconn, M_Ma_Dvcs, M_User_Name)
    '            frm.AppConn = Appconn
    '            frm.DtUnists = V_GetUnists(Appconn, M_Ma_Dvcs, M_User_Name, CyberSmLib)
    '        End If
    '        V_Loaddata(cpnameDetail, strParasourceDetail, oReportFrm, "1", Loai_DK_Loc, frm)
    '        M_Para = _ParaOld
    '    End Sub
    '    Sub V_QuickDetail(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal cpnameQDetail As String, ByVal strParasource As String, ByVal strParasourceQDetail As String, ByVal DrvQDetail As DataRowView, ByVal Loai_DK_Loc As String)
    '        V_Detail(sender, e, cpname, cpnameQDetail, strParasource, strParasourceQDetail, DrvQDetail, Loai_DK_Loc)
    '    End Sub
    '#End Region
#Region "Add On F8/F9/F10/F11/F12"
    Public Function V_F8(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String) As Boolean
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
    Public Function V_F9(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String)
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
    Public Function V_F10(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String)
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
    Public Function V_F11(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String)
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
    Public Function V_F12(ByVal sender As Object, ByVal e As System.EventArgs, ByVal cpname As String, ByVal _Para As String(), ByVal _DsDL As DataSet, ByVal iRow As Integer, ByVal _Drv As DataRowView, ByVal _strParastore As String, ByVal _strFieldValue As String, ByVal _strFieldName As String)
        Return False
        'Return True ' Thuc thi tai Customer
    End Function
#End Region
#Region "Support"
    Public Sub V_LoadLoai_BC(ByVal chkVND As CheckBox, ByVal chkNT As CheckBox, Optional ByVal _LAN As String = "V")
        If _LAN.Trim = "V" Then
            chkVND.Checked = True
            chkNT.Checked = False
        Else
            chkVND.Checked = False
            chkNT.Checked = True
        End If
    End Sub
    Public Function GetLoai_BC(ByVal chkVND As CheckBox) As String
        If chkVND.Checked Then Return "VND" Else Return "NT"
    End Function
    Public Function GetLoai_BC(ByVal chkVND As CheckBox, ByVal chk2 As CheckBox) As String
        If chkVND.Checked And chk2.Checked Then Return ""
        If chkVND.Checked Then Return "VND" Else Return "NT"
    End Function
    Public Function V_GetMaGD(ByVal _App As SqlConnection, ByVal _Ma_Ct As String, Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing) As DataTable
        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        Dim _Ds As DataSet = CyberSmlib.SQLExcuteStoreProcedure(_App, "CP_SysGetGD", _Ma_Ct)
        V_GetMaGD = _Ds.Tables(0).Copy
        _Ds.Dispose()
    End Function
    Public Function V_GetMaGD(ByVal _App As SqlConnection, ByVal _Ma_Ct As String, ByVal _Cbb As ComboBox, Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing, Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing) As DataTable
        Dim _Dt As DataTable = V_GetMaGD(_App, _Ma_Ct, CyberSmlib)
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        CyberFill.V_FillComBoxDefaul(_Cbb, _Dt, "Ma_GD", "ten_GD")
    End Function
    Public Function V_GetValueCombox(ByVal _Cbb As ComboBox) As String
        Dim _Return As String = ""
        Try
            _Return = _Cbb.SelectedValue.ToString.Trim
        Catch ex As Exception
            _Return = ""
        End Try
        V_GetValueCombox = _Return
    End Function
#End Region
End Class

