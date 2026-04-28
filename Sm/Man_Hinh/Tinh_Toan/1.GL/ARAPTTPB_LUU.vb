Imports System.Windows.Forms
Public Class ARAPTTPB_LUU
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
    Dim M_strLoc, M_Cp_Update, M_Cp_Loc As String
    Dim M_DsDataLoc As DataSet
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim Dt1, Dt2, DtH1, DtH2 As DataTable
    Dim Dv1, Dv2, DvH1, DvH2 As DataView
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub ARAPTTPB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load(sender, e)
        V_Addhandler()

        Master1GRV_SelectionChanged(New System.Object, New DevExpress.Data.SelectionChangedEventArgs)
        Me.KeyPreview = True
        Master1GRV_PopupMenuShowing(Master1GRV, Nothing)
        Master2GRV_PopupMenuShowing(Master2GRV, Nothing)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load And Database Fill.."
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load(ByVal sender As Object, ByVal e As EventArgs)
        Load(DsDataLoc)

        Binding_PositionChanged(sender, e)
        Dim currency As CurrencyManager
        currency = Me.BindingContext(Me.Master1GRV.DataSource)
        AddHandler currency.PositionChanged, AddressOf Binding_PositionChanged
    End Sub
    Private Sub Load(ByVal _DsLoc As DataSet)
        Dt1 = _DsLoc.Tables(0).Copy
        Dt2 = _DsLoc.Tables(1).Copy
        DtH1 = _DsLoc.Tables(2).Copy
        DtH2 = _DsLoc.Tables(3).Copy
        CyberSmodb.SetNotNullTable(Dt1)
        CyberSmodb.SetNotNullTable(Dt2)

        CyberSmodb.SetNotNullTable(DtH1)
        CyberSmodb.SetNotNullTable(DtH2)
        Dv1 = New DataView(Dt1)
        Dv2 = New DataView(Dt2)
        DvH1 = New DataView(DtH1)
        DvH2 = New DataView(DtH2)

        Master1.DataSource = Dv1
        Master2.DataSource = Dv2

        Me.Master1GRV.GridControl = Me.Master1
        Me.Master2GRV.GridControl = Me.Master2

        CyberFill.V_FillReports(Master1GRV, M_LAN, DvH1, Dv1)
        CyberFill.V_FillReports(Master2GRV, M_LAN, DvH2, Dv2)

    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARAPTTPB", Me.strLoc.ToString.Trim)
        Load(_DsTmp)
        Binding_PositionChanged(sender, e)
        Dim currency As CurrencyManager
        currency = Me.BindingContext(Me.Master1GRV.DataSource)
        AddHandler currency.PositionChanged, AddressOf Binding_PositionChanged
    End Sub
    Private Sub V_Loaddatatabse(ByVal Status As String, ByVal _Drv As DataRowView, Optional ByVal iRow As Integer = -1)
        Dim _Tk As String = If(Not _Drv Is Nothing, _Drv("Tk").ToString.Trim, "")
        Dim _ma_kh As String = If(Not _Drv Is Nothing, _Drv("Ma_kh").ToString.Trim, "")
        Dim _Stt_Rec As String = If(Not _Drv Is Nothing, _Drv("Stt_Rec").ToString.Trim, "")
        Dim _Ngay1 As Date = If(Not _Drv Is Nothing, _Drv("Ngay_Ct"), New Date(1900, 1, 1))
        Dim _Ngay2 As Date = If(Not _Drv Is Nothing, _Drv("Ngay_Ct"), New Date(1900, 1, 1))
        V_Loaddatatabse(Status, _Stt_Rec, _Tk, _ma_kh, _Ngay1, _Ngay2, iRow)
    End Sub
    Private Sub V_Loaddatatabse(ByVal _Load As String, ByVal _Stt_Rec As String, ByVal _Tk As String, ByVal _Ma_kh As String, ByVal _Ngay1 As Date, ByVal _Ngay2 As Date, Optional ByVal iRow As Integer = -1)
        Dim M_strParameterStore As String = _Load.Trim & "#" & _Stt_Rec & "#" & _Tk & "#" & _Ma_kh & "#" & _Ngay1.ToString("yyyyMMdd") & "#" & _Ngay2.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARAPTTPB", M_strParameterStore)
        For i = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next
        Dim nCount As Integer = Dt2.Rows.Count - 1
        For i As Integer = nCount To 0 Step -1
            Dt2.Rows(i).Delete()
        Next
        Dt2.AcceptChanges()
        For i As Integer = 0 To DsTmp.Tables(1).Rows.Count - 1
            Dt2.ImportRow(DsTmp.Tables(1).Rows(i))
        Next
        Dt2.AcceptChanges()
        '----------------------
        If iRow < 0 Then Exit Sub
        If DsTmp.Tables(0).Rows.Count > 1 Then Exit Sub
        '----------------------
        Dim _Dv As DataView = New DataView(DsTmp.Tables(0).Copy)
        Dim _Drv As DataRowView = _Dv.Item(0)

        Dim rowView As DataRowView
        Dim iCol As Integer = -1
        rowView = V_UpdateItem(Dv1, iRow, _Drv)
        Master1GRV.FocusedRowHandle = 0
        iCol = FindRowHandleByRowObject(Master1GRV, rowView)
        Master1GRV.FocusedRowHandle = iCol
        Master1GRV.ClearSelection()
        Master1GRV.SelectRow(Master1GRV.FocusedRowHandle)

    End Sub
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
    Private Sub V_Addhandler()
        RemoveHandler CmdRefresh.Click, AddressOf V_Refresh
        RemoveHandler CmdAuto_Tien.Click, AddressOf V_Auto_Pb_Tien
        RemoveHandler CmdAuto_SL.Click, AddressOf V_Auto_PB_SL
        RemoveHandler CmdTao_PB.Click, AddressOf V_Tao_Pb
        RemoveHandler CmdXoa_PB.Click, AddressOf V_Xoa_Pb

        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exits

        RemoveHandler Master1GRV.RowCellStyle, AddressOf Master1GRV_RowCellStyle
        RemoveHandler Master2GRV.RowCellStyle, AddressOf Master2GRV_RowCellStyle
        RemoveHandler Master1GRV.CustomColumnSort, AddressOf Master1GRV_CustomColumnSort
        RemoveHandler Master1GRV.SelectionChanged, AddressOf Master1GRV_SelectionChanged

        RemoveHandler Master1GRV.PopupMenuShowing, AddressOf Master1GRV_PopupMenuShowing
        RemoveHandler Master2GRV.PopupMenuShowing, AddressOf Master2GRV_PopupMenuShowing
        '--------------------------------------------------------------------------------------------
        AddHandler CmdRefresh.Click, AddressOf V_Refresh
        AddHandler CmdAuto_Tien.Click, AddressOf V_Auto_Pb_Tien
        AddHandler CmdAuto_SL.Click, AddressOf V_Auto_PB_SL
        AddHandler CmdTao_PB.Click, AddressOf V_Tao_Pb
        AddHandler CmdXoa_PB.Click, AddressOf V_Xoa_Pb

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exits

        AddHandler Master1GRV.RowCellStyle, AddressOf Master1GRV_RowCellStyle
        AddHandler Master2GRV.RowCellStyle, AddressOf Master2GRV_RowCellStyle
        AddHandler Master1GRV.CustomColumnSort, AddressOf Master1GRV_CustomColumnSort
        AddHandler Master1GRV.SelectionChanged, AddressOf Master1GRV_SelectionChanged

        AddHandler Master1GRV.PopupMenuShowing, AddressOf Master1GRV_PopupMenuShowing
        AddHandler Master2GRV.PopupMenuShowing, AddressOf Master2GRV_PopupMenuShowing
    End Sub
#End Region
#Region "Tao Phan Bo"
    Private Sub V_Auto_Pb_Tien(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub V_Auto_PB_SL(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub V_Tao_Pb(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = Master2GRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
    End Sub
    Private Sub V_Tao_Pb_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow1 As Integer = Master1GRV.GetFocusedDataSourceRowIndex
        If iRow1 < 0 Then Exit Sub
        Dim iRow2 As Integer = Master2GRV.GetFocusedDataSourceRowIndex
        If iRow2 < 0 Then Exit Sub
    End Sub
#End Region
#Region "Xoa Phan Bo"
    Private Sub V_Xoa_Pb(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = Master2GRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
    End Sub
    Private Sub V_Xoa_Pb_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow1 As Integer = Master1GRV.GetFocusedDataSourceRowIndex
        If iRow1 < 0 Then Exit Sub
        Dim iRow2 As Integer = Master2GRV.GetFocusedDataSourceRowIndex
        If iRow2 < 0 Then Exit Sub
        Dim _Drv1 As DataRowView = Dv1.Item(iRow1)
        Dim _Drv2 As DataRowView = Dv2.Item(iRow2)

        Dim _Stt_Rec2 As String = _Drv2.Item("Stt_Rec").ToString.Trim
        Dim _Stt_Rec1 As String = _Drv1.Item("Stt_Rec").ToString.Trim
        Dim _Ma_Kh As String = _Drv1.Item("Ma_kh").ToString.Trim
        Dim _TK As String = _Drv1.Item("TK").ToString.Trim
        Dim _Ma_NT As String = _Drv1.Item("Ma_NT").ToString.Trim
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARAPTTPB_Xoa", _Stt_Rec1 & "#" & _Stt_Rec2 & "#" & _TK & "#" & _Ma_Kh & "#" & _Ma_NT & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(_DsTmp.Tables(0), Me.Sysvar) Then Exit Sub
        V_Loaddatatabse("2", _Drv1, iRow1)
    End Sub
#End Region
#Region "Exit"
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#End Region
#Region "GridView"
    Private Sub Master1GRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuMasterGrid.ItemLinks.Clear()
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Xem chứng từ", AddressOf V_F3_1, Shortcut.F3, My.Resources.edit_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Làm tươi dữ liệu", AddressOf V_Refresh, Shortcut.F5, My.Resources.refresh2_16x16, True, False), True)
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Gán phân bổ theo giá trị hóa đơn", AddressOf V_Auto_Pb_Tien, Shortcut.F3, My.Resources.edit_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Gán phân bổ theo số lượng hóa đơn", AddressOf V_Auto_PB_SL, Shortcut.F4, My.Resources.edit_16x16, True, False), True)

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Tạo phân bổ", AddressOf V_Tao_Pb, Shortcut.F6, My.Resources.apply_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Xóa phân bổ", AddressOf V_Xoa_Pb, Shortcut.F8, My.Resources.Xoa_BT_16x16, True, False), True)
        '--- End Tuy chọn
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub Master2GRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuMasterGrid.ItemLinks.Clear()

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Làm tươi dữ liệu", AddressOf V_Refresh, Shortcut.F5, My.Resources.refresh2_16x16, True, False), True)
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Gán phân bổ theo giá trị hóa đơn", AddressOf V_Auto_Pb_Tien, Shortcut.F3, My.Resources.edit_16x16, True, False))
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Gán phân bổ theo số lượng hóa đơn", AddressOf V_Auto_PB_SL, Shortcut.F4, My.Resources.edit_16x16, True, False), True)

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Tạo phân bổ (Cho chứng từ hiện tại)", AddressOf V_Tao_Pb_Nhan, Shortcut.F6, My.Resources.apply_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Xóa phân bổ (Cho chứng từ hiện tại)", AddressOf V_Xoa_Pb_Nhan, Shortcut.F8, My.Resources.Xoa_BT_16x16, True, False), True)
        '--- End Tuy chọn
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)

        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub Binding_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim filter As String = Nothing
        Dim selectedRow As DataRowView = Nothing

        Try
            If (Dv1.Table.Rows.Count() <> Nothing And Dv1.Table.Columns.Count > 0) Then
                selectedRow = CType(Me.BindingContext(Master1GRV.DataSource).Current, DataRowView)
            End If
            If (Not String.IsNullOrEmpty(selectedRow("stt_rec").ToString)) Then
                V_Loaddatatabse("2", selectedRow)
            End If
        Catch ex As Exception
            V_Loaddatatabse("2", Nothing)
        End Try

    End Sub
    Private Sub Master1GRV_CustomColumnSort(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnSortEventArgs)
        Dim iRow As Integer = -1
        iRow = Master1GRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv1.Item(iRow)
        V_Loaddatatabse("2", _Drv)
    End Sub
    Private Sub Master1GRV_SelectionChanged(ByVal sender As System.Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs)
        Dim iRow As Integer = -1
        iRow = Master1GRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv1.Item(iRow)
        V_Loaddatatabse("2", _Drv)
    End Sub
    Private Sub Master1GRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        If Dv1.Table.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dv1.Table.Columns("Bold").ColumnName
            Dim _categoryBold As String = Master1GRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New System.Drawing.Font(Me.Font.FontFamily, Me.Font.Size, System.Drawing.FontStyle.Bold)
        End If
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dv1.Table.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dv1.Table.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = Master1GRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If Dv1.Table.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = Dv1.Table.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = Master1GRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                If _categoryBackColor2.Trim <> "" Then
                    e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
                End If
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
    Private Sub Master2GRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        If Dv2.Table.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dv2.Table.Columns("Bold").ColumnName
            Dim _categoryBold As String = Master2GRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New System.Drawing.Font(Me.Font.FontFamily, Me.Font.Size, System.Drawing.FontStyle.Bold)
        End If
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dv2.Table.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dv2.Table.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = Master2GRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If Dv2.Table.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = Dv2.Table.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = Master2GRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                If _categoryBackColor2.Trim <> "" Then
                    e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
                End If
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
#End Region
End Class
