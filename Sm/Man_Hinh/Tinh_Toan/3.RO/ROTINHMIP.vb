Imports System.Windows.Forms
Public Class ROTINHMIP
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DsData As New DataSet
    Dim tbMaster, tbHeader, tbThamSo As New DataTable
    Dim DtThang, DtNam As DataTable
    Dim DvMaster, DvHeader As New DataView
    Private Sub ROTINHMIP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_AddHandler()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem, Keys.F8)
        'mnItemsMail.MenuItems.Add(mnItemsF4)
        'mnItemsMail.MenuItems.Add(mnItemsF8)
        'Me.ContextMenu = mnItemsMail
        DsData = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "Cp_LoadHeaderMip", M_Ma_Dvcs & "#" & M_User_Name)
        tbHeader = DsData.Tables(0)
        tbMaster = DsData.Tables(1)
        tbThamSo = DsData.Tables(2)
        DvHeader = New DataView(tbHeader)
        DvMaster = New DataView(tbMaster)
        CyberFill.V_FillReports(Master1GRV, M_LAN, DvHeader, DvMaster)
        Master1GRV.GridControl.DataSource = DvMaster
        ' 
        If tbThamSo IsNot Nothing And tbThamSo.Rows.Count > 0 Then
            TxtSo_Ngay_Lam.Double = tbThamSo.Rows(0).Item("So_Ngay_Lam")
            TxtSo_Ngay_OC.Double = tbThamSo.Rows(0).Item("So_ngay_OC")
            TxtSo_Ngay_LT.Double = tbThamSo.Rows(0).Item("So_ngay_LT")
            TxtSo_Ngay_SL.Double = tbThamSo.Rows(0).Item("So_ngay_SL")
        End If
        If Not TxtMa_kho.Text = "" Then TxtTen_kho.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_kho", "Dmkho", "(Ma_kho= N'" + TxtMa_kho.Text.Trim + "')", CyberSmlib)
        If Not TxtMa_vt.Text = "" Then TxtTen_vt.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_vt", "Dmvt", "(Ma_vt= N'" + TxtMa_vt.Text.Trim + "')", CyberSmlib)
        '-----------------------------------------------------------------------
        DtThang = CreateTableMonth()
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang, DtThang, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")
        '----
    End Sub
#Region "Load Nam - Thang"
    Private Function CreateTableMonth() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Thang")
        _Return.Columns.Add("Ten_Thang")
        _Return.Columns.Add("Ten_Thang2")
        _Return.Columns.Add("Default")
        Dim _Thang As String
        Dim _Default As String
        For i As Integer = 1 To 12
            _Thang = Strings.Right("00" + i.ToString.Trim, 2).Trim
            If Now.Date.Month = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Thang.ToString, _Thang, _Thang, _Default)
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
        Dim _Nam As String
        Dim _Default As String
        For i As Integer = _CurYear - 5 To _CurYear + 5
            _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim
            If Now.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, _Nam, _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
#End Region
    Private Sub V_AddHandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmbbImportExcel.Click, AddressOf V_ImportExcel
        AddHandler CmdLoadData.Click, AddressOf V_LoadData
        AddHandler CmbbXuatExcel.Click, AddressOf V_XuatExcel

        '--Ma_kho
        
        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Ma_kho
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_Ma_kho

        '--Ma_vt        
        AddHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_vt
        AddHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_vt
    End Sub
#Region "Cmd..."
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        'Xóa dữ liệu
        Dim _strField As String = "", _strValue As String = ""
        CyberSmodb.GetValueControler(Me, _strField, _strValue)
        CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_INDeleteMIP", CbbM_Nam.SelectedValue.ToString.Trim & "#" & CbbM_Thang.SelectedValue.ToString.Trim & "#" & _strField.Trim & "#" & _strValue.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        'cap nhat thong tin
        For i = 0 To tbMaster.Rows.Count - 1
            tbMaster.Rows(i).Item("Ma_Dvcs") = M_Ma_Dvcs
            tbMaster.Rows(i).Item("Ngay_Tinh") = Date.Now
            tbMaster.Rows(i).Item("User_Id") = M_User_ID
        Next
        tbMaster.AcceptChanges()
        'hieulv đổ cả table lên để save
        CyberSmodb.V_CyberBulkSaveToSQL(AppConn, Sysvar, M_User_Name, tbMaster, "CTMIP", "S", "1 = 1", False)
        MsgBox("Đã lưu dữ liệu", MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))

        Me.Close()
    End Sub
    Private Sub V_ImportExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim tbImport As DataTable
        tbImport = CyberExport.V_ImportDataToGridview(AppConn, Sysvar, Para, Master1GRV, tbMaster, M_LAN)
        If tbImport Is Nothing Then Exit Sub
        For Each dr As DataRow In tbImport.Select("Ma_vt<>''")
            tbMaster.ImportRow(dr)
        Next
        tbMaster.AcceptChanges()
    End Sub
    Private Sub V_XuatExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        Dim _Tu_Ngay As String = "NGÀY " & Date.Now.ToShortDateString
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXls(AppConn, Master1GRV, _Dv_Title, DvMaster, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name, "C:\CYBER_DsXE.xls")
    End Sub
    Private Sub V_LoadData(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Tinh_Toan("0")
    End Sub
    Private Sub Tinh_Toan(ByVal M_Loai As String)
        Dim _strField As String = "", _strValue As String = ""
        CyberSmodb.GetValueControler(Me, _strField, _strValue)
        Dim _dsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_INTINHMIP", M_Loai & "#" & CbbM_Nam.SelectedValue.ToString.Trim & "#" & CbbM_Thang.SelectedValue.ToString.Trim & "#" & _strField.Trim & "#" & _strValue.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)
        CyberSmodb.SetNotNullTable(_dsTmp.Tables(0))
        tbMaster.Clear()
        For i As Integer = 0 To _dsTmp.Tables(0).Rows.Count - 1
            tbMaster.ImportRow(_dsTmp.Tables(0).Rows(i))
        Next
    End Sub
#End Region
#Region "Valid Master"
#Region "Vali --- Ma_kho"
    Private Sub V_Ma_kho(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_kho.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_kho", "Dmkho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kho(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_kho.Text = "" Then
            TxtTen_kho.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_kho.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_kho.Text = DrReturn.Item("ma_kho")
            TxtTen_kho.Text = DrReturn.Item("Ten_kho")
        Else
            TxtMa_kho.Text = ""
            TxtTen_kho.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_vt"
    Private Sub V_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_vt.Text = "" Then
            TxtTen_vt.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_vt.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_vt.Text = DrReturn.Item("ma_vt")
            TxtTen_vt.Text = DrReturn.Item("Ten_vt")
        Else
            TxtMa_vt.Text = ""
            TxtTen_vt.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Them, Xoa ...."
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = Master1GRV.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = Master1GRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(Sysvar, M_LAN, "", iRow, DvMaster, AppConn) Then Exit Sub
        DvMaster.Delete(iRow)
        DvMaster.Table.AcceptChanges()
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = DvMaster.Item(iRow) Else DrvOld = Nothing
        DvMaster.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(DvMaster.Table.Rows(DvMaster.Table.Rows.Count - 1))
        'CyberSupport.SetCarryOn(DrvOld, DvMaster.Table.Rows(DvMaster.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(1)))
        iRow = DvMaster.Count - 1
        CyberFill.V_ForcusCell(Master1GRV, iRow, 0)

    End Sub
#End Region

End Class
