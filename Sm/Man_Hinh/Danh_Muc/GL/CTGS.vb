Imports System.Data.SqlClient
Public Class CTGS

    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DtNo_Co, DtKieu, Dt_Return As DataTable
    Private Sub CTGS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        DtNo_Co = CreateNo_Co()
        DtKieu = CreateKieu_Loc()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtSo_Lo.Focus()

    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        CyberFill.V_FillComBoxDefaul(Me.CbbNo_Co, DtNo_Co, "No_Co", "Ten_NC", "Default")
        CyberFill.V_FillComBoxDefaul(Me.CbbKieu, DtKieu, "Kieu", "Ten_Kieu", "Default")
        TxtNam.Text = Me.Key_Nam.ToString
        'If TxtTen_TK.Text.Trim = "" Then TxtTen_TK.Text = "" Else TxtTen_TK.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk", "DmTk", "(TK = N'" + TxtTk.Text.Trim + "')", CyberSmlib)
        If TxtTen_TK.Text.Trim = "" Then TxtTen_TK.Text = "" Else TxtTen_TK.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(TK0 = N'" + TxtTk.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then
            TxtNgay_LO.Value = Now.Date
            TxtNgay_CT1.Value = Now.Date
            TxtNgay_CT2.Value = Now.Date
            TxtMa_Dvcs.Text = M_Ma_Dvcs
        End If
    End Sub
    Private Function CreateNo_Co() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("No_Co")
        _Return.Columns.Add("Ten_NC")
        _Return.Columns.Add("Ten_NC2")
        _Return.Columns.Add("Default")
        _Return.Rows.Add("1", "Tính theo ghi nợ", "Credit", "1")
        _Return.Rows.Add("2", "Tính theo ghi có", "Credit", "0")
        CreateNo_Co = _Return
    End Function
    Private Function CreateKieu_Loc() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Kieu")
        _Return.Columns.Add("Ten_Kieu")
        _Return.Columns.Add("Ten_Kieu2")
        _Return.Columns.Add("Default")
        _Return.Rows.Add("1", "Tất cả các phát sinh", "All", "1")
        _Return.Rows.Add("2", "Chứng từ chưa đánh số CTGS", "Credit", "0")
        _Return.Rows.Add("3", "Chứng từ đã đánh số CTGS", "0")
        CreateKieu_Loc = _Return
    End Function
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--TK
        RemoveHandler TxtTk.CyberValiting, AddressOf V_TK
        RemoveHandler TxtTk.CyberLeave, AddressOf L_TK
        AddHandler TxtTk.CyberValiting, AddressOf V_TK
        AddHandler TxtTk.CyberLeave, AddressOf L_TK
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- TK"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtTk.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DmTK", "1=1", "1=1")
        TxtTk.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk.GetRowsSelectData(True)
        'If Not DrReturn Is Nothing Then
        '    TxtTk.Text = DrReturn.Item("TK")
        '    TxtTen_TK.Text = DrReturn.Item("Ten_TK")
        'Else
        '    TxtTk.Text = ""
        '    TxtTen_TK.Text = ""
        'End If

        DrReturn = TxtTk.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("TK0")
            TxtTen_TK.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTk.Text = ""
            TxtTen_TK.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        If Not Chksave() Then Exit Sub
        Dt_Return = Nothing
        If Not Get_BKCTGS() Then Exit Sub
        If Me.Mode.Trim = "M" Then TxtRec_Gs.Text = Get_Stt_Rec(Appconn)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)

        Dim _Dt_Lo As Date = TxtNgay_LO.Value
        Dim _Dt1 As Date = TxtNgay_CT1.Value
        Dim _Dt2 As Date = TxtNgay_CT2.Value

        For i = 0 To Dt_Return.Rows.Count - 1
            If Not (Dt_Return.Rows(i).Item("Tag").ToString.Trim.ToUpper = "TRUE" Or Dt_Return.Rows(i).Item("Tag").ToString.Trim.ToUpper = "1") Then Continue For
            CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_CTGS_Save", TxtRec_Gs.Text & "#" & Dt_Return.Rows(i).Item("Stt_Rec") & "#" & _Dt1.ToString("yyyyMMdd") & "#" & _Dt2.ToString("yyyyMMdd") & "#" & _Dt_Lo.ToString("yyyyMMdd") & "#" & TxtSo_Lo.Text & "#" & TxtTk.Text & "#" & CbbNo_Co.SelectedValue & "#" & CbbKieu.SelectedValue & "#" & TxtMa_Dvcs.Text & "#" & M_User_Name)
        Next
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
#Region "Check Save"
    Private Function Chksave() As Boolean
        If TxtTk.Text.Trim = "" Then
            TxtTk.Focus()
            Return False
        End If
        If TxtSo_Lo.Text.Trim = "" Then
            TxtSo_Lo.Focus()
            Return False
        End If
        Dim _Dt As Date = TxtNgay_LO.Value
        If _Dt.ToString("yyyyMMdd") = "19000101" Then
            TxtNgay_LO.Focus()
            Return False
        End If
        Dim _Dt1 As Date = TxtNgay_CT1.Value
        If _Dt1.ToString("yyyyMMdd") = "19000101" Then
            TxtNgay_CT1.Focus()
            Return False
        End If
        Dim _Dt2 As Date = TxtNgay_CT2.Value
        If _Dt2.ToString("yyyyMMdd") = "19000101" Then
            TxtNgay_CT2.Focus()
            Return False
        End If
        Return True
    End Function
    Private Function Get_Stt_Rec(ByVal Appconn As SqlConnection) As String
        Dim _Return As String = ""
        Dim Dstmp As New DataSet
        Dstmp = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetRec_GS", TxtNam.Text.ToString.Trim)
        _Return = Dstmp.Tables(0).Rows(0).Item("Rec_GS").ToString.Trim()
        Get_Stt_Rec = _Return
        Dstmp.Dispose()
    End Function
    Private Function Get_BKCTGS() As Boolean

        Dim dt1 As Date = TxtNgay_CT1.Value
        Dim dt2 As Date = TxtNgay_CT2.Value
        Dim dt3 As Date = TxtNgay_LO.Value
        Dim strKieu As String = CbbKieu.SelectedValue.ToString.Trim

        Dim M_CP_Name As String = "CP_CTGS_Filter"
        Dim strParameterStore As String = TxtNam.Text.Trim
        strParameterStore = strParameterStore & "#" & dt1.ToString("yyyyMMdd")
        strParameterStore = strParameterStore & "#" & dt2.ToString("yyyyMMdd")
        strParameterStore = strParameterStore & "#" & dt3.ToString("yyyyMMdd")
        strParameterStore = strParameterStore & "#" & TxtSo_Lo.Text.Trim
        strParameterStore = strParameterStore & "#" & TxtTk.Text.Trim
        strParameterStore = strParameterStore & "#" & CbbNo_Co.SelectedValue.ToString.Trim
        strParameterStore = strParameterStore & "#" & CbbKieu.SelectedValue.ToString.Trim
        strParameterStore = strParameterStore & "#" & TxtMa_Dvcs.Text.Trim
        strParameterStore = strParameterStore & "#" & M_User_Name.Trim

        Dim Dsdata As DataSet = New DataSet
        Dsdata = CyberSmlib.SQLExcuteStoreProcedure(Appconn, M_CP_Name, strParameterStore)
        Dim tb1 As DataTable = Dsdata.Tables(0)
        Dim tb1H As DataTable = Dsdata.Tables(1)
        Dim _Ok As Boolean = False
        Dim frm As New CTGSDetail
        frm.Lan = M_LAN
        frm.AppConn = Appconn
        frm.SysVar = oSysvar
        frm.Para = M_Para
        frm.Is_Ok = False
        frm.DsData = Dsdata

        frm.ShowDialog()
        Dsdata = Nothing
        If Not frm.Is_Ok Then Return False
        Dt_Return = frm.Dt_Return
        Dim nT_Tien As Decimal = 0
        Dim nT_Tien_NT As Decimal = 0

        For i = 0 To Dt_Return.Rows.Count - 1
            If Not (Dt_Return.Rows(i).Item("Tag").ToString.Trim.ToUpper = "TRUE" Or Dt_Return.Rows(i).Item("Tag").ToString.Trim.ToUpper = "1") Then Continue For
            nT_Tien = nT_Tien + Dt_Return.Rows(i).Item("T_Tien")
            nT_Tien_NT = nT_Tien_NT + Dt_Return.Rows(i).Item("T_Tien_NT")
        Next
        TxtT_Tien.Double = nT_Tien
        TxtT_Tien_nt.Double = nT_Tien_NT
        Get_BKCTGS = True
    End Function
#End Region

End Class

