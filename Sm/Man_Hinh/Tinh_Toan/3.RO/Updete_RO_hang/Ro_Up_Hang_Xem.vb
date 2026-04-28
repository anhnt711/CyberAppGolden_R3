Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors

Public Class Ro_Up_Hang_Xem
#Region "AddProperty"
    Public Property strLoc() As String
        Get
            strLoc = M_strLoc
        End Get
        Set(ByVal Value As String)
            M_strLoc = Value
        End Set
    End Property
    Public Property Cp_Loc() As String
        Get
            Cp_Loc = M_Cp_Loc
        End Get
        Set(ByVal Value As String)
            M_Cp_Loc = Value
        End Set
    End Property
    Public Property Cp_Update() As String
        Get
            Cp_Update = M_Cp_Update
        End Get
        Set(ByVal Value As String)
            M_Cp_Update = Value
        End Set
    End Property
    Public Property DsDataLoc() As DataSet
        Get
            DsDataLoc = M_DsDataLoc
        End Get
        Set(ByVal Value As DataSet)
            M_DsDataLoc = Value
        End Set
    End Property
#End Region
#Region "Declare "
    Dim M_strLoc, M_Cp_Update, M_Cp_Loc As String
    Dim M_DsDataLoc As DataSet
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim Dt_head, Dt_Master, Dt_Dmct, Dt_Filter1, Dt_Filter0 As DataTable
    Dim Dv_head, Dv_Master, Dv_Dmct, DV_Filter1, DV_Filter0 As DataView

    Dim DrDmct As DataRow
    Dim CyberColor As New Cyber.Color.Sys
    Dim EditMa_Xe, EditSo_Ro As New Cyber.Fill.CyberColumnGridView

    Dim M_Loai As String = ""
    Dim M_Ma_Loai As String = ""
    Dim _Tab_Boolean As Boolean = False
    Dim ProccessList As New Collection
#End Region
    Private Sub Ro_Up_Hang_Xem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim M_VT_PARA As Integer = CType(Me.Para(0).Trim, Integer)
        M_Loai = Me.Para(M_VT_PARA + 2).ToString.Trim.ToUpper
        M_Ma_Loai = Me.Para(M_VT_PARA + 3).ToString.Trim.ToUpper
        M_Bar = Me.Para(11).Trim
        M_Bar2 = Me.Para(12).Trim
        Me.Save_OK = False
        Me.Tag = ""
        V_Load()
        V_FilldatatoGridview()

        V_GetColumn()

        V_AddHandler_Master()
        V_AddHandler_Detail()
        MasterGRV.OptionsBehavior.Editable = False
        LoadFilter()
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
        'Me.Text = Me.Key_Sub2.ToString.Trim
        Me.Text = Me.M_Bar
        'Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load data"
    Private Sub LoadFilter()
        Dt_Filter0 = New DataTable
        Dt_Filter1 = New DataTable

        Dt_Filter1.Columns.Add("Field_Name")
        Dt_Filter1.Columns.Add("Field_Type")

        Dt_Filter0.Columns.Add("Ma")
        Dt_Filter0.Columns.Add("Ten")
        Dt_Filter0.Columns.Add("Default")


        Dim _Field_Name As String = ""
        Dim _Field_Head As String = ""
        Dim _Field_Type As String = ""
        Dt_Filter0.Rows.Add("", "Tất cả", "0")

        For i As Integer = 1 To Dt_head.Rows.Count - 1
            _Field_Name = Dt_head.Rows(i).Item("Field_Name").ToString
            _Field_Head = Dt_head.Rows(i).Item("Field_Head1").ToString
            _Field_Type = Dt_head.Rows(i).Item("Field_Type").ToString.ToUpper.Trim

            If _Field_Type = "N" Or _Field_Type = "D" Or _Field_Type = "B" Then Continue For
            If Not CyberSmodb.isExistField(Dt_Master, _Field_Name) Then Continue For
            If _Field_Name.ToString.Trim.ToUpper = "TAG" Then Continue For
            Dt_Filter0.Rows.Add(_Field_Name, _Field_Head, "0")
            Dt_Filter1.Rows.Add(_Field_Name, _Field_Type)
        Next
        CyberFill.V_FillComBoxValue(ComFilter, Dt_Filter0, "Ma", "Ten", "")
        DV_Filter0 = New DataView(Dt_Filter0)
        DV_Filter1 = New DataView(Dt_Filter1)
        CyberFill.V_FillComBoxValue(ComFilter, Dt_Filter0, "Ma", "Ten", "")
    End Sub
    Private Sub V_Load()
        Dt_Master = DsDataLoc.Tables(0).Copy
        Dt_Dmct = DsDataLoc.Tables(1).Copy
        Dt_head = DsDataLoc.Tables(2).Copy

        Dv_Master = New DataView(Dt_Master)
        Dv_Dmct = New DataView(Dt_Dmct)
        Dv_head = New DataView(Dt_head)
        DrDmct = Dt_Dmct.Rows(0)
        If Dv_Master.Table.Columns.Contains("Tag") Then _Tab_Boolean = True
        '---------Load Databases
    End Sub
    Private Sub V_GetColumn()
        EditSo_Ro.GetColumn(MasterGRV, "So_RO")
        EditMa_Xe.GetColumn(MasterGRV, "ma_Xe")
    End Sub
    Private Sub V_FilldatatoGridview()
        CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_head, Dv_Master)
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
        Dim FixCol As Integer = -1
        Try
            FixCol = Dt_Dmct.Rows(0).Item("ColFrozen_Master")
        Catch ex As Exception
        End Try

        If FixCol < MasterGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If

    End Sub
#End Region
#Region "V_AddHandler"
    Private Sub V_AddHandler_Master()
        RemoveHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing


        AddHandler CmbbSms.Click, AddressOf V_SMS
        AddHandler CmbbRefresh.Click, AddressOf V_Refresh
        AddHandler CmbbXuatExcel.Click, AddressOf V_XuatExcel
        AddHandler CmbbXuatExcelx.Click, AddressOf V_XuatExcelx
        AddHandler CmbbSelectAll.Click, AddressOf V_SelectAll
        AddHandler CmbbUnSelectAll.Click, AddressOf V_RemoveAll
        AddHandler TxtSearch.TextChanged, AddressOf V_Search
    End Sub
    Private Sub V_AddHandler_Detail()

        RemoveHandler EditSo_Ro.EditColumn.Click, AddressOf V_F3
        RemoveHandler Editma_Xe.EditColumn.Click, AddressOf V_Xem_Lenh
        RemoveHandler MasterGRV.DoubleClick, AddressOf V_Xem_Lenh

        AddHandler EditSo_Ro.EditColumn.Click, AddressOf V_F3
        AddHandler Editma_Xe.EditColumn.Click, AddressOf V_Xem_Lenh
        AddHandler MasterGRV.DoubleClick, AddressOf V_Xem_Lenh
    End Sub
#End Region
#Region "F3////----------------------------------------------"
    Private Sub V_F3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)

        
        Dim FrmF3 As New Ro_Up_Hang_F3
        '---------------------------------------------
        FrmF3.Lan = Me.Lan
        FrmF3.Para = Me.Para
        FrmF3.Sysvar = Me.Sysvar
        FrmF3.AppConn = Me.AppConn
        FrmF3.CyberSmlib = Me.CyberSmlib
        FrmF3.CyberSupport = Me.CyberSupport
        FrmF3.CyberFill = Me.CyberFill
        FrmF3.CyberSmlistSys = Me.CyberSmlistSys
        FrmF3.CyberSmodb = Me.CyberSmodb
        FrmF3.CyberExport = Me.CyberExport
        FrmF3.CyberVoucher = Me.CyberVoucher
        FrmF3.CyberLoading = Me.CyberLoading
        FrmF3.Drv = _Drv
        FrmF3.Key_Sub2 = Me.Key_Sub2
        FrmF3.ShowInTaskbar = False
        FrmF3.ShowDialog()
        If Not FrmF3.Save_OK Then Exit Sub

        Dim M_strParameterStore As String = "0" & "#" & "19000101" & "#" & "19000101"
        M_strParameterStore = M_strParameterStore & "#" & ""
        M_strParameterStore = M_strParameterStore & "#" & _Drv.Item("Stt_rec").ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & ""
        M_strParameterStore = M_strParameterStore & "#" & ""
        M_strParameterStore = M_strParameterStore & "#" & "2"
        M_strParameterStore = M_strParameterStore & "#" & "9"
        M_strParameterStore = M_strParameterStore & "#" & "0"
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Ro_Up_Hang", M_strParameterStore)
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        Dim _DrU_Up As DataRow = Dstmp.Tables(0).Rows(0)
        CyberSmodb.V_UpdateRowtoRow(_DrU_Up, Dv_Master, iRow)

        MasterGRV.UpdateCurrentRow()
        Dstmp.Dispose()
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, Cp_Loc, strLoc)
        CyberSmodb.SetNotNullTable(Dstmp.Tables(0))
        Dim nCount As Integer = Dt_Master.Rows.Count - 1
        For i = nCount To 0 Step -1
            Dt_Master.Rows(i).Delete()
        Next
        Dt_Master.AcceptChanges()
        For i = 0 To Dstmp.Tables(0).Rows.Count - 1
            Dt_Master.ImportRow(Dstmp.Tables(0).Rows(i))
        Next
        Dt_Master.AcceptChanges()
        Dstmp.Dispose()

    End Sub
#End Region
#Region "Excel/Sms/Select ..."

    Private Sub V_Attach(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        Dim _ma_Get1 As String = ""
        If _Drv.DataView.Table.Columns.Contains("Ma_Get1") Then _ma_Get1 = _Drv("Ma_Get1").ToString.Trim

        If _ma_Get1.Trim <> "" Then CyberSupport.V_AttachFile(AppConn, Me.Para, Me.Sysvar, M_LAN, M_Ma_Dvcs, M_User_Name, _ma_Get1.Trim, "")
    End Sub
    Private Sub V_Is_Sms(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub V_Is_mail(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub V_XuatExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        ' Dim _Tu_Ngay As String = "TỪ THÁNG " & Strings.Right("00" & Me.Thang1.ToString.Trim, 2) & " ĐẾN THÁNG " & Strings.Right("00" & Me.Thang2.ToString.Trim, 2) & " năm " & Me.Nam.ToString.Trim
        Dim _Tu_Ngay As String = "TỪ NGÀY " & Me.Key_Sub3.ToString & " ĐẾN NGÀY" & Me.Key_Sub4.ToString.Trim
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXls(AppConn, Me.MasterGRV, _Dv_Title, Dv_Master, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name, "C:\CYBER_DsXE.xls")
    End Sub
    Private Sub V_XuatExcelx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        ' Dim _Tu_Ngay As String = "TỪ THÁNG " & Strings.Right("00" & Me.Thang1.ToString.Trim, 2) & " ĐẾN THÁNG " & Strings.Right("00" & Me.Thang2.ToString.Trim, 2) & " năm " & Me.Nam.ToString.Trim
        Dim _Tu_Ngay As String = "TỪ NGÀY " & Me.Key_Sub3.ToString & " ĐẾN NGÀY" & Me.Key_Sub4.ToString.Trim
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.MasterGRV, _Dv_Title, Dv_Master, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name, "C:\CYBER_DsXE.xlsx")
    End Sub
    Private Sub V_SMS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Ma_Get")
        Dim _Ma_CT As String = ""
        Dim _Dien_Thoai As String = ""
        If Dv_Master.Table.Columns.Contains("Dien_Thoai") Then _Dien_Thoai = _Drv.Item("Dien_Thoai").ToString.Trim
        If _Stt_Rec.Trim <> "" Then CyberSupport.V_Sms(AppConn, Me.Para, Me.Sysvar, M_LAN, _Stt_Rec, _Ma_CT, M_Ma_Dvcs, M_User_Name, _Dien_Thoai, "", CyberSmlib, CyberSmodb)
    End Sub
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _FieldName, _Value, _Filter, _Filter1 As String
        Dim _Count = 0, _Index As Decimal = 0
        _FieldName = ComFilter.SelectedValue.ToString.Trim

        _Value = TxtSearch.Text.Trim
        _Value = CyberSmlistSys.V_FormatKeyFilter(_Value)
        _Filter = CyberSmlistSys.V_FilterDataColumns(Dv_Master, DV_Filter1, _FieldName, _Value, "%")

        _Filter1 = "1=1"
        If _Filter.Trim = "" Then _Filter = "1=1"
        If _Filter1.Trim = "" Then _Filter1 = "1=1"
        MasterGRV.ActiveFilterString = _Filter
        MasterGRV.FocusedRowHandle = 0
    End Sub
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not _Tab_Boolean Then Exit Sub
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True
        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            If _Type Then Dv_Master.Item(i).Item("Tag") = True Else Dv_Master.Item(i).Item("Tag") = "1"
            Dv_Master.Item(i).EndEdit()
            MasterGRV.UpdateCurrentRow()
        Next
    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not _Tab_Boolean Then Exit Sub
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True

        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            If _Type Then Dv_Master.Item(i).Item("Tag") = False Else Dv_Master.Item(i).Item("Tag") = "0"
            Dv_Master.Item(i).EndEdit()
            MasterGRV.UpdateCurrentRow()
        Next
    End Sub
#End Region
#Region "Event"
    Private Function FindRowHandleByRowObject(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal row As Object) As Integer
        Dim I As Integer
        If Not row Is Nothing Then
            For I = 0 To view.DataRowCount - 1
                If row.Equals(view.GetRow(I)) Then
                    Return I
                End If
            Next
        End If
        Return DevExpress.XtraGrid.GridControl.InvalidRowHandle
    End Function
    Private Function V_UpdateItem(ByVal Dv As DataView, ByVal iRow As Decimal, ByVal DrvUp As DataRowView) As DataRowView
        If iRow < 0 Then Return Nothing
        Dim iCol As Integer
        Dim _Fieldname As String
        Dim Drv As DataRowView
        Drv = Dv.Item(iRow)
        Drv.BeginEdit()
        For iCol = 0 To Dv.Table.Columns.Count - 1
            _Fieldname = Dv.Table.Columns(iCol).ColumnName
            If DrvUp.DataView.Table.Columns.Contains(_Fieldname) Then
                Drv.Item(_Fieldname) = DrvUp.Item(_Fieldname)
            End If
        Next
        Drv.EndEdit()
        Dv.Table.AcceptChanges()
        Return Drv
    End Function
#Region "Valid --- Xem lenh "
    Private Sub V_Xem_Lenh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        If _Stt_Rec.Trim = "" Then Return

        Dim _Ma_Ct As String = _Drv.Item("Ma_Ct")
        Dim _Process As Process = CyberSmlib.V_EditVoucher(_Stt_Rec, _Ma_Ct, Me.Para, AppConn, Me.Sysvar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)

    End Sub

#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Me.Tag = ""
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        If Dt_Master.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dt_Master.Columns("Bold").ColumnName
            Dim _categoryBold As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        End If
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dt_Master.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dt_Master.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If Dt_Master.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = Dt_Master.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                If Not _categoryBackColor2.Trim = "" Then e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If
            If Dt_Master.Columns.Contains("ForeColor") Then
                Dim _FieldForeColor As String = ""
                _FieldForeColor = Dt_Master.Columns("ForeColor").ColumnName
                Dim _categoryForeColor As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldForeColor).ToString.Trim
                If Not _categoryForeColor.Trim = "" Then e.Appearance.ForeColor = CyberColor.GetForeColor(_categoryForeColor)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", M_Bar, M_Bar2), AddressOf V_F3, Shortcut.F3, Nothing, True, True), False)

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xem lệnh", "Xem lệnh"), AddressOf V_Xem_Lenh, Shortcut.F2, My.Resources.edit_16x16, True, False))

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel .xls", "Export to Excel"), AddressOf V_XuatExcel, Nothing, Nothing, True, True), True)
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel .xlsx", "Export to Excel"), AddressOf V_XuatExcelx, Nothing, Nothing, True, True), False)

        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Đánh đấu đã gửi Sms", "Export to Excel"), AddressOf V_Is_Sms, Shortcut.CtrlS, Nothing, True, True), True)
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Đánh đấu đã gửi E-Mail", "Export to Excel"), AddressOf V_Is_mail, Shortcut.CtrlE, Nothing, True, True), False)

        If _Tab_Boolean Then
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn tất", "Select All"), AddressOf V_SelectAll, Shortcut.CtrlA, Nothing, True, True)).BeginGroup = True
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gỡ chọn", "Remove All"), AddressOf V_RemoveAll, Shortcut.CtrlU, Nothing, True, True)).BeginGroup = False
        End If

        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Đính kèm", "Attach File"), AddressOf V_Attach, Nothing, My.Resources.attachment_16x16, True, True)).BeginGroup = True

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True)
        '--- End Tuy chọn
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)

        'End If
    End Sub

#End Region
End Class
