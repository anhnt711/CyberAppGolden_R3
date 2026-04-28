Imports System.Windows.Forms
Imports System.Drawing

Public Class ARAPTTPB
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
    Dim Edit2GRVTT, Edit2GRVTT_NT As New Cyber.Fill.CyberColumnGridView
    Private Sub ARAPTTPB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_LoadData(DsDataLoc)
        V_GetColumn()
        V_Addhandler()
        V_AddhandlerDetail()
        Master1GRV_RowClick(Nothing, Nothing)
        Dim DropDragGridview As New DropDragGridview(Master1GRV, True, Master2GRV, False)
        AddHandler DropDragGridview.CyberSetVauleDraGrop, AddressOf V_SetValue
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load And Database Fill.."
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_LoadData(ByVal _DsLoc As DataSet)
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
        CyberFill.V_FillReports(Master1GRV, M_LAN, DvH1, Dv1)
        CyberFill.V_FillReports(Master2GRV, M_LAN, DvH2, Dv2)
    End Sub
    Private Sub V_Databing(ByVal _DsLoc As DataSet)
        Dt1.Clear()
        For Each dr As DataRow In _DsLoc.Tables(0).Rows
            Dt1.ImportRow(dr)
        Next
        Dt1.AcceptChanges()
        Dt2.Clear()
        For Each dr As DataRow In _DsLoc.Tables(1).Rows
            Dt2.ImportRow(dr)
        Next
        Dt2.AcceptChanges()
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

        Dt2.Clear()
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
    Private Sub V_Addhandler()
        'AddHandler Master1GRV.RowClick, AddressOf Master1GRV_RowClick
        AddHandler Master1GRV.FocusedRowChanged, AddressOf Master1GRV_FocusedRowChanged
        AddHandler CmdRefresh.Click, AddressOf V_Refresh
        AddHandler CmdAuto_Tien.Click, AddressOf V_Auto_Pb_Tien
        AddHandler CmdAuto_SL.Click, AddressOf V_Auto_PB_SL
        AddHandler CmdTao_PB.Click, AddressOf V_Tao_Pb
        AddHandler CmdXoa_PB.Click, AddressOf V_Xoa_Pb
        AddHandler Master1GRV.PopupMenuShowing, AddressOf Master1GRV_PopupMenuShowing
        AddHandler Master2GRV.PopupMenuShowing, AddressOf Master2GRV_PopupMenuShowing
    End Sub
    Private Sub V_AddhandlerDetail()
        If Not Edit2GRVTT.Column Is Nothing Then AddHandler Edit2GRVTT.EditColumn.Leave, AddressOf L_Tinh_Toan2GRV
        If Not Edit2GRVTT_NT.Column Is Nothing Then AddHandler Edit2GRVTT_NT.EditColumn.Leave, AddressOf L_Tinh_Toan2GRV
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARAPTTPB", Me.strLoc.ToString.Trim)
        V_Databing(_DsTmp)
        Master1GRV_FocusedRowChanged(sender, Nothing)

    End Sub
    Private Sub V_GetColumn()
        Edit2GRVTT.GetColumn(Master2GRV, "TT")
        Edit2GRVTT_NT.GetColumn(Master2GRV, "TT_NT")
    End Sub
#End Region
#Region "Tao Phan Bo"
    Private Sub V_Tao_Pb_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Master2GRV.PostEditor()
        Dim iRow1 As Integer = Master1GRV.GetFocusedDataSourceRowIndex
        Dim _Drv1 As DataRowView = Dv1.Item(iRow1)
        Dim iRow2 As Integer = Master2GRV.GetFocusedDataSourceRowIndex
        Dim _Drv2 As DataRowView = Dv2.Item(iRow2)

        If _Drv1 Is Nothing Then Exit Sub
        If _Drv2 Is Nothing Then Exit Sub
        Dim strField, strValue As String
        Dim strField_PB, strValue_PB As String

        CyberSmodb.GetValueData(_Drv1, strField, strValue)
        CyberSmodb.GetValueData(_Drv2, strField_PB, strValue_PB)

        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARAPTTPBChkTao", "1#" & strField & "#" & strValue & "#" & strField_PB & "#" & strValue_PB & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(_DsTmp.Tables(0), Me.Sysvar) Then Exit Sub

        CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARAPTTPBTao", "1#" & strField & "#" & strValue & "#" & strField_PB & "#" & strValue_PB & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        V_Loaddatatabse("2", _Drv1, iRow1)
    End Sub
    Private Sub V_Tao_Pb(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Master2GRV.PostEditor()
        Dim iRow1 As Integer = Master1GRV.GetFocusedDataSourceRowIndex
        Dim _Drv1 As DataRowView = Dv1.Item(iRow1)
        If _Drv1 Is Nothing Then Exit Sub

        Dim strField, strValue As String
        Dim strField_PB, strValue_PB As String

        CyberSmodb.GetValueData(_Drv1, strField, strValue)
        Dim iLan_Pb As Integer = 0
        For Each dr As DataRow In Dt2.Rows
            CyberSmodb.GetValueData(dr, strField_PB, strValue_PB)
            Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARAPTTPBChkTao", iLan_Pb.ToString & "#" & strField & "#" & strValue & "#" & strField_PB & "#" & strValue_PB & "#" & M_Ma_Dvcs & "#" & M_User_Name)
            iLan_Pb = iLan_Pb + 1
            If Not CyberSupport.V_MsgChk(_DsTmp.Tables(0), Me.Sysvar) Then Exit Sub
        Next
        For Each dr As DataRow In Dt2.Rows
            CyberSmodb.GetValueData(dr, strField_PB, strValue_PB)
            Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARAPTTPBTao", iLan_Pb.ToString & "#" & strField & "#" & strValue & "#" & strField_PB & "#" & strValue_PB & "#" & M_Ma_Dvcs & "#" & M_User_Name)
            iLan_Pb = iLan_Pb + 1
        Next
        V_Loaddatatabse("2", _Drv1, iRow1)
    End Sub
#End Region
#Region "Tinh phan bo"
    Private Sub L_Tinh_Toan2GRV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Master2GRV.PostEditor()
        Dim dr As DataRow
        Dim T_Tien_Bp As Double = 0
        dr = Master1GRV.GetFocusedDataRow()
        If dr Is Nothing Then Exit Sub

        For i As Integer = 0 To Dt2.Rows.Count - 1
            T_Tien_Bp += Dt2.Rows(i)("TT_NT")
            Dt2.Rows(i)("Cl_NT") = Dt2.Rows(i)("Tien_NT") - Dt2.Rows(i)("Da_Pb_NT") - Dt2.Rows(i)("TT_NT")
        Next

        dr("TT_NT") = T_Tien_Bp
        dr("Cl_NT") = dr("Tien_NT") - dr("Da_Pb_NT") - dr("TT_NT")

        dr.Table.AcceptChanges()
    End Sub
    Private Sub V_Auto_Pb_Tien(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_TinhPhanBo(1)
    End Sub
    Private Sub V_Auto_PB_SL(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_TinhPhanBo(2)
    End Sub
    Private Sub V_TinhPhanBo(ByVal M_LoaiPb As String)
        Dim _Drv As DataRow = Master1GRV.GetFocusedDataRow
        If _Drv Is Nothing Then Exit Sub
        Dim _Tk As String = If(Not _Drv Is Nothing, _Drv("Tk").ToString.Trim, "")
        Dim _ma_kh As String = If(Not _Drv Is Nothing, _Drv("Ma_kh").ToString.Trim, "")
        Dim _Stt_Rec As String = If(Not _Drv Is Nothing, _Drv("Stt_Rec").ToString.Trim, "")
        Dim _Ngay1 As Date = If(Not _Drv Is Nothing, _Drv("Ngay_Ct"), New Date(1900, 1, 1))
        Dim _Ngay2 As Date = If(Not _Drv Is Nothing, _Drv("Ngay_Ct"), New Date(1900, 1, 1))

        Dim DsTmp As New DataSet
        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARAPTTPB1", M_LoaiPb & "#" & _Stt_Rec & "#" & _Tk & "#" & _ma_kh & "#" & _Ngay1.ToString("yyyyMMdd") & "#" & _Ngay2.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_Ma_Dvcs)
        For i = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next

        Dt2.Clear()
        For i As Integer = 0 To DsTmp.Tables(1).Rows.Count - 1
            Dt2.ImportRow(DsTmp.Tables(1).Rows(i))
        Next
        Dt2.AcceptChanges()

        If DsTmp.Tables(0).Rows.Count > 1 Then Exit Sub
        '----------------------
        Dim _Dv As DataView = New DataView(DsTmp.Tables(0).Copy)
        Dim _Drvs As DataRowView = _Dv.Item(0)

        Dim rowView As DataRowView
        Dim iCol As Integer = -1
        rowView = V_UpdateItem(Dv1, Master1GRV.GetFocusedDataSourceRowIndex, _Drvs)
        'Master1GRV.FocusedRowHandle = 0
        'iCol = FindRowHandleByRowObject(Master1GRV, rowView)
        'Master1GRV.FocusedRowHandle = iCol
        'Master1GRV.ClearSelection()
        'Master1GRV.SelectRow(Master1GRV.FocusedRowHandle)
    End Sub
#End Region
#Region "Xoa Phan Bo"
    Private Sub V_Xoa_Pb(ByVal sender As System.Object, ByVal e As System.EventArgs)
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

        For i As Integer = 0 To Dt2.Rows.Count - 1
            Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARAPTTPB_Xoa", _Stt_Rec1 & "#" & Dt2.Rows(i)("Stt_Rec").ToString.Trim & "#" & _TK & "#" & _Ma_Kh & "#" & _Ma_NT & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Next
        'If Not CyberSupport.V_MsgChk(_DsTmp.Tables(0), Me.Sysvar) Then Exit Sub
        V_Loaddatatabse("2", _Drv1, iRow1)
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
    Private Sub Master1GRV_RowClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowClickEventArgs)
        Dim iRow As Integer = -1
        iRow = Master1GRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv1.Item(iRow)
        V_Loaddatatabse("2", _Drv)
    End Sub
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
#End Region
    Public Sub V_SetValue(ByVal sender1 As System.Object, ByVal sender2 As System.Object)
        Dim dr1, dr2 As DataRow
        dr1 = sender1
        dr2 = sender2

        If dr1.Table Is dr2.Table Then Exit Sub
        Dim Datanguon As DataRow
        Dim DataDich As DataRow
        Datanguon = sender1
        DataDich = sender2
        If Datanguon.Table Is DataDich.Table Then Exit Sub
        If DataDich("Cl_NT") = 0 Then Exit Sub
        If Datanguon("Cl_NT") = 0 Then Exit Sub

        Dim Cl_Pb1 As Decimal = Datanguon("Tien_NT") - Datanguon("Da_Pb_NT") - Datanguon("TT_NT")
        Dim Cl_Pb2 As Decimal = DataDich("Tien_NT") - DataDich("Da_Pb_NT") - DataDich("TT_NT")
        If Cl_Pb1 - Cl_Pb2 > 0 Then
            DataDich("TT_NT") = Cl_Pb2
            Datanguon("TT_NT") = Datanguon("TT_NT") + Cl_Pb2
        Else
            DataDich("TT_NT") = Cl_Pb1
            Datanguon("TT_NT") = Datanguon("TT_NT") + Cl_Pb1
        End If

        DataDich("Cl_NT") = DataDich("Tien_NT") - DataDich("Da_Pb_NT") - DataDich("TT_NT")
        Datanguon("Cl_NT") = Datanguon("Tien_NT") - Datanguon("Da_Pb_NT") - Datanguon("TT_NT")
    End Sub
    Private Sub Master1GRV_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) 'Handles Master1GRV.FocusedRowChanged
        Dim iRow As Integer = -1
        iRow = Master1GRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv1.Item(iRow)
        V_Loaddatatabse("2", _Drv)
    End Sub
End Class
Public Class DropDragGridview
    Dim GridviewDrag As New DevExpress.XtraGrid.Views.Grid.GridView
    Dim GridviewDrop As New DevExpress.XtraGrid.Views.Grid.GridView

    Dim GridDrag As New DevExpress.XtraGrid.GridControl
    Dim GridDrop As New DevExpress.XtraGrid.GridControl

    Dim isDragDrop1 As Boolean
    Dim isDragDrop2 As Boolean

    Dim downHitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = Nothing
    Public Event CyberSetVauleDraGrop(ByVal Datanguon As System.Object, ByVal DataDich As System.Object)

    Public Sub New(ByVal Gridview_1 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal isDragDrop_1 As Boolean, ByVal Gridview_2 As DevExpress.XtraGrid.Views.Grid.GridView, ByVal isDragDrop_2 As Boolean)
        If Gridview_1 Is Nothing Then Exit Sub

        GridviewDrag = Gridview_1
        If Not Gridview_2 Is Nothing Then GridviewDrop = Gridview_2 Else GridviewDrop = Gridview_1

        GridDrag = GridviewDrag.GridControl
        GridDrop = GridviewDrop.GridControl

        GridDrag.AllowDrop = True
        GridDrop.AllowDrop = True

        isDragDrop1 = isDragDrop_1
        isDragDrop2 = isDragDrop_2

        V_Addhandler()
    End Sub
    Private Sub V_Addhandler()

        If isDragDrop1 Then AddHandler GridviewDrag.MouseDown, AddressOf V_GridviewDrag_MouseDown
        If isDragDrop1 Then AddHandler GridviewDrag.MouseMove, AddressOf V_GridviewDrag_MouseMove
        AddHandler GridDrag.DragOver, AddressOf GridDrag_DragOver
        AddHandler GridDrag.DragDrop, AddressOf GridDrag_DragDrop

        If GridviewDrop Is GridviewDrag Then Exit Sub

        If isDragDrop2 Then AddHandler GridviewDrop.MouseDown, AddressOf V_GridviewDrag_MouseDown
        If isDragDrop2 Then AddHandler GridviewDrop.MouseMove, AddressOf V_GridviewDrag_MouseMove
        AddHandler GridDrop.DragOver, AddressOf GridDrag_DragOver
        AddHandler GridDrop.DragDrop, AddressOf GridDrag_DragDrop
    End Sub
    Private Sub V_GridviewDrag_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        downHitInfo = Nothing
        Dim hitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = view.CalcHitInfo(New Point(e.X, e.Y))
        If Not Control.ModifierKeys = Keys.None Then Exit Sub
        If e.Button = MouseButtons.Left And hitInfo.RowHandle >= 0 Then
            downHitInfo = hitInfo
        End If
    End Sub
    Private Sub V_GridviewDrag_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        If e.Button = MouseButtons.Left And Not downHitInfo Is Nothing Then
            Dim dragSize As Drawing.Size = SystemInformation.DragSize
            Dim DragRect As Rectangle = New Rectangle(New Point(downHitInfo.HitPoint.X - dragSize.Width / 2, downHitInfo.HitPoint.Y - dragSize.Height / 2), dragSize)
            If Not DragRect.Contains(New Point(e.X, e.Y)) Then
                Dim row As DataRow = view.GetDataRow(downHitInfo.RowHandle)
                view.GridControl.DoDragDrop(row, DragDropEffects.Move)
                downHitInfo = Nothing
                DevExpress.Utils.DXMouseEventArgs.GetMouseArgs(e).Handled = True
            End If
        End If
    End Sub
    Private Sub GridDrag_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim grid As DevExpress.XtraGrid.GridControl = CType(sender, DevExpress.XtraGrid.GridControl)
        Dim row As DataRow = CType(e.Data.GetData(GetType(DataRow)), DataRow)
        If Not row Is Nothing Then
            Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(grid.MainView, DevExpress.XtraGrid.Views.Grid.GridView)
            Dim hitInfo As DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo = view.CalcHitInfo(grid.PointToClient(New Point(e.X, e.Y)))
            Dim rowDich As DataRow = view.GetDataRow(hitInfo.RowHandle)
            'rowDich("Ma_Ct") = row("ma_Ct")
            RaiseEvent CyberSetVauleDraGrop(row, rowDich)
        End If
    End Sub
    Private Sub GridDrag_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If e.Data.GetDataPresent(GetType(DataRow)) Then
            e.Effect = DragDropEffects.Move
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub
End Class