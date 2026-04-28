Imports System.Windows.Forms

Public Class FrmCapStt
    Dim Dt_Master, Dt_ColFrozen, Dt_Header, Dt_Master_Hen, Dt_Header_Hen As New DataTable
    Dim Dv_Master, Dv_Header, Dv_Master_Hen, Dv_Header_Hen As New DataView
    Dim CyberColor As New Cyber.Color.Sys
    Dim Dt_DmQuay As DataTable
    Dim M_Ma_Quay As String = ""
    Dim EditTen_post As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Xe As New Cyber.Fill.CyberColumnGridView
    Dim EditLan_Goi As New Cyber.Fill.CyberColumnGridView
    Dim TimerLoad As Integer = 40000, TimerScroll As Integer = 10000, RowStep As Integer = 7, FontSizeHead As Integer = 26, FontSizeRow As Integer = 26, FontName As String = "Microsoft Sans Serif"

    Private Sub FrmCapStt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load_Quay()
        V_Load()
        EditTen_post.GetColumn(MasterGRV, "Ten_Post")
        EditMa_Xe.GetColumn(MasterGRV, "Ten_Post")
        EditLan_Goi.GetColumn(MasterGRV, "Ten_Post")

        Timer_LoadDb.Interval = TimerLoad
        Timer_ScrollGrid.Interval = TimerScroll

        Timer_LoadDb.Start()
        Timer_ScrollGrid.Start()
        Timer_ScrollLable.Start()

        V_SetDeffault()
        V_AddHander()
    End Sub

    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        V_LoadDatabases("1", "")
        CyberFill.V_FillReports(MasterGRV, M_LAN, Dv_Header, Dv_Master)
        Master.DataSource = Dv_Master
        CyberFill.V_FillReports(MasterGRV_Ds, M_LAN, Dv_Header_Hen, Dv_Master_Hen)
        Master_Ds.DataSource = Dv_Master_Hen
    End Sub
    Private Sub V_Load_Quay()
        Dim dsQuay As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkCapStt_DmQuay", M_Ma_Dvcs + "#" + M_User_Name)
        Dt_DmQuay = dsQuay.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(CbbMa_Quay, Dt_DmQuay, "Ma_Quay", "ten_Quay", "Ngam_Dinh")
        M_Ma_Quay = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_Quay)
        Try
            Dim _Ma_Quay As String = CbbMa_Quay.SelectedValue.ToString.Trim
            If _Ma_Quay = "" And Not M_Ma_Quay.Trim = "" Then CbbMa_Quay.SelectedValue = M_Ma_Quay
        Catch ex As Exception
        End Try
    End Sub
    Private Sub V_LoadDatabases(ByVal status As String, ByVal _Stt_rec As String)
        Dim _Dt As Date = New Date(1900, 1, 1)

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkCapStt_Load", status + "#" + _Stt_rec + "#" + _Dt.ToString("yyyyMMdd") + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If status.ToString.Trim = "1" Then
            Dt_Master = New DataTable
            Dt_Header = New DataTable

            Dt_Master = Dstmp.Tables(0).Copy
            Dt_ColFrozen = Dstmp.Tables(1).Copy
            Dt_Header = Dstmp.Tables(2).Copy

            Dv_Master = New DataView(Dt_Master)
            Dv_Header = New DataView(Dt_Header)

            Dt_Master_Hen = New DataTable
            Dt_Header_Hen = New DataTable

            Dt_Master_Hen = Dstmp.Tables(3).Copy
            Dt_Header_Hen = Dstmp.Tables(4).Copy

            Dv_Master_Hen = New DataView(Dt_Master_Hen)
            Dv_Header_Hen = New DataView(Dt_Header_Hen)
        Else
            Timer_ScrollGrid.Stop()
            Timer_ScrollLable.Stop()
            If _Stt_rec = "" Then
                Dt_Master.Clear()
                Dt_Master_Hen.Clear()
            Else
                Dim nCount As Integer = Dt_Master.Rows.Count - 1
                For i As Integer = nCount To 0 Step -1
                    If Dt_Master.Rows(i).Item("Stt_rec").ToString.Trim.ToUpper = _Stt_rec.ToUpper.Trim Then
                        Dt_Master.Rows(i).Delete()
                    End If
                Next
                Dt_Master.AcceptChanges()
                Dt_Master_Hen.AcceptChanges()
            End If
            Dt_Master.Load(Dstmp.Tables(0).CreateDataReader)
            Dt_Master_Hen.Load(Dstmp.Tables(3).CreateDataReader)

            Timer_ScrollGrid.Interval = TimerScroll
            Timer_ScrollGrid.Start()
            Timer_ScrollLable.Start()
        End If
        Dstmp.Dispose()
    End Sub
    Private Sub V_SetDeffault()
        If Dt_ColFrozen Is Nothing Then Return
        If Dt_ColFrozen.Rows.Count = 0 Then Return
        Dim _Title As String = "DANH SÁCH XE CẤP STT"
        Dim _Sort As String = ""

        If Dt_ColFrozen.Columns.Contains("Title") Then _Title = Dt_ColFrozen.Rows(0).Item("Title").ToString.Trim
        Dim _ColFrozen As Integer = -1
        If Dt_ColFrozen.Columns.Contains("ColFrozen") Then _ColFrozen = Dt_ColFrozen.Rows(0).Item("ColFrozen")
        If Dt_ColFrozen.Columns.Contains("FieldSort") Then _Sort = Dt_ColFrozen.Rows(0).Item("FieldSort").ToString.Trim.Replace(" ", "").Replace(",,", ",")
        CyberSupport.V_SetSortView(Dv_Master, _Sort)

        Me.Text = _Title

        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < MasterGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If


    End Sub
    Private Sub V_AddHander()
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle

        AddHandler MasterGRV_Ds.PopupMenuShowing, AddressOf MasterGRV_Hen_PopupMenuShowing
        AddHandler MasterGRV_Ds.RowCellStyle, AddressOf MasterGRV_Hen_RowCellStyle

        AddHandler EditTen_post.EditColumn.Click, AddressOf V_Goi
        AddHandler EditMa_Xe.EditColumn.Click, AddressOf V_Goi
        AddHandler EditLan_Goi.EditColumn.Click, AddressOf V_Goi

        AddHandler Timer_LoadDb.Tick, AddressOf Timer_LoadDb_Tick
        AddHandler Timer_ScrollGrid.Tick, AddressOf Timer_ScrollGrid_Tick

        AddHandler CmdGoi.Click, AddressOf V_Goi_Lan_Luot
    End Sub
#Region "Timer"
    Private Sub Timer_LoadDb_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabases("0", "")
    End Sub
    Private Sub Timer_ScrollGrid_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ScrollGrid(MasterGRV)
    End Sub
    Sub ScrollGrid(ByVal _Dgr As DevExpress.XtraGrid.Views.Grid.GridView)
        Dim selRow As DataRow = Nothing
        Dim vStt As Integer = 0, nCount As Integer = _Dgr.RowCount
        If nCount <= 0 Then Exit Sub
        If _Dgr.RowCount <= 0 Then Exit Sub
        selRow = _Dgr.GetFocusedDataRow
        vStt = selRow.Item("Stt1")
        vStt = vStt + RowStep
        If vStt > nCount - 1 Then vStt = nCount - 1
        _Dgr.ClearSelection()
        _Dgr.SelectRow(vStt)
        _Dgr.FocusedRowHandle = vStt
        _Dgr.MakeRowVisible(vStt)
    End Sub
#End Region
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Gọi lại", "Call"), AddressOf V_Goi, System.Windows.Forms.Shortcut.F6, Nothing, True, True), True).BeginGroup = True

        'PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Tạo phiếu", "Create"), AddressOf V_Tao_moi, System.Windows.Forms.Shortcut.F4, My.Resources.apply_16x16, True, True), True).BeginGroup = True
        'PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Sửa phiếu", "Edit"), AddressOf V_Sua, System.Windows.Forms.Shortcut.F3, My.Resources.edit_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Hủy phiếu", "Cancel"), AddressOf V_Huy, System.Windows.Forms.Shortcut.F9, My.Resources.cancel_16x16, True, True), True).BeginGroup = False
        'PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xóa phiếu", "Delete"), AddressOf V_Xoa, System.Windows.Forms.Shortcut.F8, My.Resources.deletelist_16x16, True, True), True).BeginGroup = False

        'PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "In phiếu", "Delete"), AddressOf V_Print, System.Windows.Forms.Shortcut.F7, My.Resources.printer_16x16, True, True), True).BeginGroup = True


        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Export Excel", AddressOf V_ExportExcel, System.Windows.Forms.Shortcut.F12, My.Resources.exporttoxls_16x16, True, True), True).BeginGroup = True
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)

    End Sub
    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterGRV, Dt_Master, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub MasterGRV_Hen_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False

        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)

    End Sub
    Private Sub MasterGRV_Hen_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterGRV_Ds, Dt_Master_Hen, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub V_ExportExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberExport As New Cyber.Export.Sys
        Dim FileName As String = ""
        Dim Dt_Title As New DataTable
        Dt_Title.Columns.Add("Title1")
        Dt_Title.Columns.Add("Title2")
        Dt_Title.Rows.Add("Danh sách xe cấp số thứ tự", "Danh sách xe cấp số thứ tự")
        Dim Dt_TitleDetail As New DataTable
        Dt_TitleDetail.Columns.Add("Tu_Ngay")
        FileName = CyberExport.V_ExportToXlsx(AppConn, MasterGRV, New DataView(Dt_Title), New DataView(Dt_TitleDetail), Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabases("0", "")
    End Sub
    Private Sub V_Quay_Ra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        V_SaveQuay()
        Me.Close()
    End Sub
    Private Sub FrmCapStt_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        V_SaveQuay()
    End Sub
    Private Sub V_SaveQuay()
        Try
            TxtMa_Quay.Text = CbbMa_Quay.SelectedValue.ToString
        Catch ex As Exception

        End Try
        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
    End Sub
#Region "Tạo mới/Sửa/xóa/Gọi/Hủy"
    Dim CyberWork As New Cyber.Workprogress.Sys
    Private Sub V_Tao_moi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        Dim Dt_Return As DataTable = CyberWork.V_Cap_Stt(_Stt_Rec, "M", AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        Dim _Stt_Rec_Return As String = ""
        If Not Dt_Return Is Nothing Then If Dt_Return.Rows.Count > 0 And Dt_Return.Columns.Contains("Stt_Rec") Then _Stt_Rec_Return = Dt_Return.Rows(0).Item("Stt_Rec")
        If _Stt_Rec_Return.Trim = "" Then Return
        'V_LoadDatabases("0", _Stt_Rec_Return)
        V_LoadDatabases("0", "")
    End Sub
    Private Sub V_Sua(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return
        Dim Dt_Return As DataTable = CyberWork.V_Cap_Stt(_Stt_Rec, "S", AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        Dim _Stt_Rec_Return As String = ""
        If Not Dt_Return Is Nothing Then If Dt_Return.Rows.Count > 0 And Dt_Return.Columns.Contains("Stt_Rec") Then _Stt_Rec_Return = Dt_Return.Rows(0).Item("Stt_Rec")
        If _Stt_Rec_Return.Trim = "" Then Return
        'V_LoadDatabases("0", _Stt_Rec_Return)
        V_LoadDatabases("0", "")
    End Sub
    Private Sub V_Huy(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkCapStt_Huy", _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), Me.Sysvar, M_LAN) Then
            Dstmp.Dispose()
            Return
        End If
        'V_LoadDatabases("0", _Stt_Rec)
        V_LoadDatabases("0", "")
        Dstmp.Dispose()
    End Sub
    Private Sub V_Xoa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkCapStt_Xoa", _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), Me.Sysvar, M_LAN) Then
            Dstmp.Dispose()
            Return
        End If
        'V_LoadDatabases("0", _Stt_Rec)
        Dstmp.Dispose()
    End Sub
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        Dim _Stt_Rec = ""
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        _Stt_Rec = Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return

        Dim DsPrint As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkCapStt_Print", _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsPrint.Tables(0), Me.Sysvar, M_LAN) Then
            DsPrint.Dispose()
            Return
        End If

        Dim _ReportName As String = ""
        Dim _Title1 As String = "PHIẾU ĐẶT LỊCH"
        Dim _Title2 As String = "PHIẾU ĐẶT LỊCH"
        If DsPrint.Tables(0).Columns.Contains("Repo_Name") Then _ReportName = DsPrint.Tables(0).Rows(0).Item("Repo_Name").ToString.Trim()
        If DsPrint.Tables(0).Columns.Contains("M_Title") Then _Title1 = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        If DsPrint.Tables(0).Columns.Contains("M_Title") Then _Title2 = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        DsPrint.Tables.Remove(DsPrint.Tables(0))
        Dim CyberWork As New Cyber.Workprogress.Sys
        CyberWork.V_Print(AppConn, M_Ma_Dvcs, M_LAN, "1", True, True, _ReportName, DsPrint, _Title1, _Title2, Me.Sysvar, Me.Para)
        DsPrint.Dispose()

    End Sub
    Private Sub V_Goi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        Dim _Stt_Rec = ""

        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        _Stt_Rec = Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return
        If Dv_Master.Item(iRow).Item("Lan_Goi").ToString.Trim = 0 Then Return
        Dim _Ma_Quay As String = ""
        Try
            _Ma_Quay = CbbMa_Quay.SelectedValue.ToString
        Catch ex As Exception
        End Try

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkCapStt_DocChu", _Ma_Quay + "#" + _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Dstmp.Tables.Count = 0 Then Return
        If Dstmp.Tables(0).Rows.Count = 0 Then Return
        If Dstmp.Tables(0).Columns.Contains("Doc_Chu").ToString.Trim = "" Then Return
        Dim _Doc_Chu As String = Dstmp.Tables(0).Copy.Rows(0).Item("Doc_Chu")
        If _Doc_Chu.Trim = "" Then Return

        Dim speech As New Cyber.FptAI.sys
        speech.V_SpeechLocation(_Doc_Chu)
        'Dim speech As New Cyber.FptAI.sys
        'speech.V_Speech("http://fptai.cybersoft.com.vn/api/fptai", _Doc_Chu)
        'V_LoadDatabases("0", _Stt_Rec)
        V_LoadDatabases("0", "")
    End Sub
    Dim _row As Integer = 0

    Private Sub V_Goi_Lan_Luot(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim nCount_Master As Integer = Dt_Master.Rows.Count
        For iRow As Integer = 0 To nCount_Master - 1 Step 1
            If Dt_Master.Rows(iRow).Item("Lan_Goi").ToString.Trim = 0 Then
                V_Goi_Lan_Luot(iRow)
                Exit Sub
            End If
        Next
        If _row > nCount_Master - 1 Then _row = 0
        V_Goi_Lan_Luot(_row)
        _row = _row + 1
    End Sub
    Private Sub V_Goi_Lan_Luot(ByVal _row As Integer)
        Dim _Stt_Rec = ""
        _Stt_Rec = Dv_Master.Item(_row).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return
        If Dv_Master.Item(_row).Item("Lan_Goi").ToString.Trim <> 0 Then Return

        Dim _Ma_Quay As String = ""
        Try
            _Ma_Quay = CbbMa_Quay.SelectedValue.ToString
        Catch ex As Exception
        End Try

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkCapStt_DocChu", _Ma_Quay + "#" + _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Dstmp.Tables.Count = 0 Then Return
        If Dstmp.Tables(0).Rows.Count = 0 Then Return
        If Dstmp.Tables(0).Columns.Contains("Doc_Chu").ToString.Trim = "" Then Return
        Dim _Doc_Chu As String = Dstmp.Tables(0).Copy.Rows(0).Item("Doc_Chu")
        If _Doc_Chu.Trim = "" Then Return

        Dim speech As New Cyber.FptAI.sys
        speech.V_SpeechLocation(_Doc_Chu)
        'V_LoadDatabases("0", _Stt_Rec)
        V_LoadDatabases("0", "")
    End Sub

#End Region
End Class
