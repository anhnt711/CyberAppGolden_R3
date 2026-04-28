Imports System.Drawing
Imports System.Windows.Forms
Public Class LOA_Xem
#Region "AddProperty"
    Dim M_strLoc As String
    Public Property strLoc() As String
        Get
            strLoc = M_strLoc
        End Get
        Set(ByVal Value As String)
            M_strLoc = Value
        End Set
    End Property
    Dim M_Ma_CT As String
    Public Property Ma_CT() As String
        Get
            Ma_CT = M_Ma_CT
        End Get
        Set(ByVal Value As String)
            M_Ma_CT = Value
        End Set
    End Property
    Dim M_Ma_GD As String
    Public Property Ma_GD() As String
        Get
            Ma_GD = M_Ma_GD
        End Get
        Set(ByVal Value As String)
            M_Ma_GD = Value
        End Set
    End Property
#End Region
#Region "Declare "
    Dim CyberCalculatorCustom As New Cyber.CalculatorCustom.Sys
    Dim EditSo_CT As New Cyber.Fill.CyberColumnGridView
    Dim M_Tab_Boolean As Boolean = False
    Dim M_title As String = ""
#End Region
    Private Sub LOA_Xem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        Me.Tag = ""
        '------------------------------------------------------------------------------------------------------------------
        V_Loaddata("1", "")
        '------------------------------------------------------------------------------------------------------------------
        V_GetColumn()
        '------------------------------------------------------------------------------------------------------------------
        V_AddHandler()
        '------------------------------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        Me.Text = M_Bar
        If Not Dt_ColFrozen Is Nothing Then If Dt_ColFrozen.Rows.Count > 0 And Dt_ColFrozen.Columns.Contains("Title") And Dt_ColFrozen.Columns.Contains("Title2") Then M_title = If(M_LAN = "V", Dt_ColFrozen.Rows(0).Item("Title"), Dt_ColFrozen.Rows(0).Item("Title2"))
        If M_title.Trim = "" Then M_title = If(M_LAN = "V", M_Bar, M_Bar2)
        If M_title.Trim = "" Then M_title = M_Bar
        Me.Text = M_title
        If Not Dt_ColFrozen Is Nothing Then If Dt_ColFrozen.Rows.Count > 0 And Dt_ColFrozen.Columns.Contains("Is_Max") Then If Dt_ColFrozen.Rows(0).Item("Is_Max").ToString.Trim = "1" Then Me.WindowState = FormWindowState.Maximized
    End Sub
#Region "Load database"
    Dim Dt_Master, Dt_ColFrozen, Dt_Head, Dt_Filter0, Dt_Filter1 As DataTable
    Dim Dv_Master, Dv_head, Dv_Filter0, Dv_Filter1 As DataView
    Private Sub V_Loaddata(ByVal Status As String, ByVal _Stt_rec As String)
        Dim Dstmp As DataSet = V_Loaddatavase(Status, _Stt_rec) '--- CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CRMQLLLLoad", Status + "#" + _Ma_Get + "#" + strLoc)
        If Status.ToString.Trim = "1" Then
            Dt_Master = New DataTable
            Dt_Head = New DataTable

            Dt_Master = Dstmp.Tables(0).Copy
            Dt_ColFrozen = Dstmp.Tables(1).Copy
            Dt_Head = Dstmp.Tables(2).Copy
            Dv_Master = New DataView(Dt_Master)
            Dv_head = New DataView(Dt_Head)

            CyberSupport.V_SetSortView(Dv_Master, Dt_ColFrozen)
            CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_head, Dv_Master)

            Master.DataSource = Dv_Master
            Me.MasterGRV.GridControl = Me.Master
            MasterGRV.OptionsView.ShowViewCaption = False
            MasterGRV.OptionsSelection.MultiSelect = False
            Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen

            Dim FixCol As Integer = -1
            If Dt_ColFrozen.Columns.Contains("ColFrozen") And Dt_ColFrozen.Rows.Count > 0 Then FixCol = Dt_ColFrozen.Rows(0).Item("ColFrozen")
            If FixCol < MasterGRV.Columns.Count And FixCol > 0 Then
                For iCol = 0 To FixCol
                    MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                Next
            End If

            If Dt_Master.Columns.Contains("Tag") And Dt_Head.Select("Field_Name = 'Tag'").Length > 0 Then M_Tab_Boolean = True
            LoadFilter()

        Else
            If _Stt_rec.ToString = "" Then
                Dt_Master.Clear()
                Dt_Master.Load(Dstmp.Tables(0).CreateDataReader)
            Else
                Dim nCount As Integer = Dt_Master.Rows.Count - 1

                For i As Integer = nCount To 0 Step -1
                    If Dt_Master.Rows(i).Item("Stt_rec") = _Stt_rec Then
                        Dt_Master.Rows(i).Delete()
                        Dt_Master.AcceptChanges()
                        Exit For
                    End If
                Next
                Dt_Master.Load(Dstmp.Tables(0).CreateDataReader)
            End If
        End If
        Dstmp.Dispose()
    End Sub
    Private Function V_Loaddatavase(ByVal Status As String, ByVal _Stt_rec As String) As DataSet
        Return CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LOAApproval", Status + "#" + _Stt_rec + "#" + strLoc)
    End Function
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Loaddata("0", "")
    End Sub
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

        For i As Integer = 1 To Dt_Head.Rows.Count - 1
            _Field_Name = Dt_Head.Rows(i).Item("Field_Name").ToString
            _Field_Head = Dt_Head.Rows(i).Item("Field_Head1").ToString
            _Field_Type = Dt_Head.Rows(i).Item("Field_Type").ToString.ToUpper.Trim

            If _Field_Type = "N" Or _Field_Type = "D" Or _Field_Type = "B" Then Continue For
            If Not CyberSmodb.isExistField(Dt_Master, _Field_Name) Then Continue For
            If _Field_Name.ToString.Trim.ToUpper = "TAG" Then Continue For
            Dt_Filter0.Rows.Add(_Field_Name, _Field_Head, "0")
            Dt_Filter1.Rows.Add(_Field_Name, _Field_Type)
        Next
        CyberFill.V_FillComBoxValue(ComFilter, Dt_Filter0, "Ma", "Ten", "")
        Dv_Filter0 = New DataView(Dt_Filter0)
        Dv_Filter1 = New DataView(Dt_Filter1)
        CyberFill.V_FillComBoxValue(ComFilter, Dt_Filter0, "Ma", "Ten", "")
    End Sub
    Private Sub V_AddHandler()
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle

        AddHandler CmbRefresh.Click, AddressOf V_Refresh
        AddHandler CmbbXuatExcel.Click, AddressOf V_XuatExcel
        AddHandler CmbbXuatExcelx.Click, AddressOf V_XuatExcelx

        AddHandler CmbbSelectAll.Click, AddressOf V_SelectAll
        AddHandler CmbbUnSelectAll.Click, AddressOf V_RemoveAll

        AddHandler TxtSearch.TextChanged, AddressOf V_Search

        RemoveHandler EditSo_CT.EditColumn.Click, AddressOf V_F3
        AddHandler EditSo_CT.EditColumn.Click, AddressOf V_F3
    End Sub
    Private Sub V_GetColumn()
        EditSo_CT.GetColumn(MasterGRV, "So_CT")
    End Sub
#End Region
    Private Sub V_F3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_rec As String = ""
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow >= 0 And Dt_Master.Columns.Contains("Stt_rec") Then _Stt_rec = Dv_Master.Item(iRow).Item("Stt_rec").ToString.Trim
        If _Stt_rec.Trim = "" Then Return

        Dim Ds_Load As DataSet = V_Loaddatavase("2", _Stt_rec)
        If Ds_Load.Tables.Count = 0 Then Return

        Dim _Dt_Load As DataTable
        Dim _Dv_Load As DataView
        Dim _Drv As DataRowView
        _Dt_Load = Ds_Load.Tables(0).Copy
        If _Dt_Load.Rows.Count = 0 Then Return

        _Dv_Load = New DataView(_Dt_Load)
        _Drv = _Dv_Load.Item(0)

        Ds_Load.Dispose()
        '---------------------------------------------
        Dim FrmF3_Calculator As LOA_F3
        ''Dim FrmF3_Calculator As Cyber.CalculatorCustom.CRM_F3
        ''FrmF3_Calculator = CyberCalculatorCustom.GetFormCRM_F3(M_Loai, M_Ma_Loai, M_Ma_Ngay)
        Dim Dt_Return As DataTable
        '---------------------------------------------       
        If Not FrmF3_Calculator Is Nothing Then
            FrmF3_Calculator.Ma_CT = Ma_CT
            FrmF3_Calculator.Ma_GD = Ma_GD
            FrmF3_Calculator.Stt_rec = _Stt_rec
            FrmF3_Calculator.Drv_Load = _Drv
            '---------------------------------------------
            FrmF3_Calculator.Lan = Me.Lan
            FrmF3_Calculator.Para = Me.Para
            FrmF3_Calculator.Sysvar = Me.Sysvar
            FrmF3_Calculator.AppConn = Me.AppConn
            FrmF3_Calculator.CyberSmlib = Me.CyberSmlib
            FrmF3_Calculator.CyberSupport = Me.CyberSupport
            FrmF3_Calculator.CyberFill = Me.CyberFill
            FrmF3_Calculator.CyberSmlistSys = Me.CyberSmlistSys
            FrmF3_Calculator.CyberSmodb = Me.CyberSmodb
            FrmF3_Calculator.CyberExport = Me.CyberExport
            FrmF3_Calculator.CyberVoucher = Me.CyberVoucher
            FrmF3_Calculator.CyberLoading = Me.CyberLoading

            FrmF3_Calculator.ShowInTaskbar = False
            FrmF3_Calculator.ShowDialog()
            If Not FrmF3_Calculator.Save_OK Then Exit Sub
            Dt_Return = FrmF3_Calculator.M_Dt_Return
        Else
            Dim FrmF3 As New LOA_F3
            FrmF3.Ma_CT = Ma_CT
            FrmF3.Ma_GD = Ma_GD
            FrmF3.Stt_rec = _Stt_rec
            FrmF3.Drv_Load = _Drv
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

            FrmF3.ShowInTaskbar = False
            FrmF3.ShowDialog()
            If Not FrmF3.Save_OK Then Exit Sub
            Dt_Return = FrmF3.M_Dt_Return
        End If

        V_LoadDatabasesALL(Dt_Return)
    End Sub
    Private Sub V_LoadDatabasesALL(ByVal _Dt As DataTable)
        If _Dt Is Nothing Then Return
        If _Dt.Rows.Count = 0 Then Return
        If Not _Dt.Columns.Contains("Stt_rec") Then Return
        Dim _Stt_rec As String = ""
        For i As Integer = 0 To _Dt.Rows.Count - 1
            _Stt_rec = _Dt.Rows(i).Item("Stt_rec").ToString.Trim
            V_Loaddata("0", _Stt_rec)
        Next
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", M_Bar, M_Bar2), AddressOf V_F3, Shortcut.F3, My.Resources.edit_16x16, True, False)).BeginGroup = True

        If M_Tab_Boolean Then
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn tất", "Select All"), AddressOf V_SelectAll, Shortcut.CtrlA, Nothing, True, True)).BeginGroup = False
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gỡ chọn", "Remove All"), AddressOf V_RemoveAll, Shortcut.CtrlU, Nothing, True, True)).BeginGroup = True
        End If
      
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xuất Excel", "Export to Excel"), AddressOf V_XuatExcelx, Shortcut.F11, My.Resources.exporttoxls_16x16, True, True), False).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), False).BeginGroup = False

        '--- End Tuy chọn
        'Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, Nothing, My.Resources.cancel_16x16, True, True), False).BeginGroup = True

        'PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)

        'End If
    End Sub
    Private Sub V_XuatExcelx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        Dim _Tu_Ngay As String = "TỪ NGÀY " & Me.Key_Sub3.ToString & " ĐẾN NGÀY" & Me.Key_Sub4.ToString.Trim
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.MasterGRV, _Dv_Title, Dv_Master, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub V_XuatExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        Dim _Tu_Ngay As String = "TỪ NGÀY " & Me.Key_Sub3.ToString & " ĐẾN NGÀY" & Me.Key_Sub4.ToString.Trim
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXls(AppConn, Me.MasterGRV, _Dv_Title, Dv_Master, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
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
        If Not M_Tab_Boolean Then Exit Sub
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
        If Not M_Tab_Boolean Then Exit Sub
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True

        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            If _Type Then Dv_Master.Item(i).Item("Tag") = False Else Dv_Master.Item(i).Item("Tag") = "0"
            Dv_Master.Item(i).EndEdit()
            MasterGRV.UpdateCurrentRow()
        Next
    End Sub
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        ''CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterGRV, Dt_Master, Me.Font, "Bold", "BackColor", "Backcolor2", "Forecolor", "Underline", "Italic", CyberColor)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterGRV, Dt_Master, Me.Font)
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Dim ProccessList As New Collection
    Private Sub KillProce()
        Try
            Dim op As Process
            For i As Integer = ProccessList.Count To 1 Step -1
                op = ProccessList(i)
                If Not op Is Nothing Then
                    If Not op.HasExited() Then
                        op.Kill()
                        ProccessList.Remove(i)
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub
    Private Sub FrmRepports_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        KillProce()
    End Sub

    '#End Region
End Class
