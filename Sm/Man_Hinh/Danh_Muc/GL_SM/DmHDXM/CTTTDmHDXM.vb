Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class CTTTDmHDXM
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Public Dt_head, Dt_Master As DataTable
    Public Dv_head, Dv_Master As DataView

    Dim DrDmct As DataRow
    Dim EditMa_CD, EditNgay_TT, EditTien_Nt, EditMa_HSGX, EditTen_HSGX, EditSo_Luong As New Cyber.Fill.CyberColumnGridView
    Private Sub CTTTDMHD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        Master.DataSource = Dv_Master
        CyberFill.V_FillVoucher(MasterGRV, Me.Lan, Dv_head, Dv_Master, DrDmct)
        V_GetColumn()
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
        V_AddHandler()
        V_AddhandlerDetail()
        Updatelist()
        V_ReadOnly()
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
    End Sub
#Region "Loading ..."
    Private Sub V_GetColumn()
        EditMa_CD.GetColumn(MasterGRV, "Ma_CD")
        EditNgay_TT.GetColumn(MasterGRV, "Ngay_TT")
        EditTien_Nt.GetColumn(MasterGRV, "Tien_Nt")
        EditMa_HSGX.GetColumn(MasterGRV, "Ma_HSGX")
        EditTen_HSGX.GetColumn(MasterGRV, "Ten_HSGX")
        EditSo_Luong.GetColumn(MasterGRV, "So_Luong")
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub V_AddHandler()
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler MasterGRV.KeyDown, AddressOf MasterGRV_KeyDown
        AddHandler ButtOK.Click, AddressOf V_Ok

        MasterGRV.ViewCaption = ""
        MasterGRV.OptionsView.ShowViewCaption = False
    End Sub
    Private Sub V_AddhandlerDetail()
        EditMa_CD.V_ActiLookUpColumn(AddressOf V_Ma_CD, AddressOf L_Ma_CD)
        EditMa_HSGX.V_ActiLookUpColumn(AddressOf V_Ma_HSGX, AddressOf L_Ma_HSGX)

        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien_Nt.Column Is Nothing Then AddHandler EditTien_Nt.EditColumn.Leave, AddressOf L_Tinh_Toan
    End Sub
#End Region
#Region "Valid - Detail"
#Region "Valid - Ma_CD"
    Private Sub V_Ma_CD(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_CD", "DMCD", "1=1", "1=1", "M", "", M_LAN, Para, Sysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        MasterGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = MasterGRV.GetFocusedRow
        Dim drRertrun As DataRow = CyberSupport.L_Lookup("M", "", sender, True)
        If Not drRertrun Is Nothing Then
            drvCurren.Item("Ma_CD") = drRertrun("Ma_CD")
        Else
            drvCurren.Item("Ma_CD") = ""
        End If
    End Sub
#End Region
#Region "Valid - Ma_HSGX"
    Private Sub V_Ma_HSGX(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_HSGX", "DMHSGX", "1=1", "1=1", "M", "", M_LAN, Para, Sysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HSGX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        MasterGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = MasterGRV.GetFocusedRow
        Dim drRertrun As DataRow = CyberSupport.L_Lookup("M", "", sender, True)
        If Not drRertrun Is Nothing Then
            drvCurren.Item("Ma_HSGX") = drRertrun("Ma_HSGX")
            drvCurren.Item("Ten_HSGX") = drRertrun("Ten_HSGX")
            drvCurren.Item("So_Luong") = 1
        Else
            drvCurren.Item("Ma_HSGX") = ""
            drvCurren.Item("Ten_HSGX") = ""
            drvCurren.Item("So_Luong") = 0
        End If
        Updatelist()
    End Sub
#End Region
    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex()
        If iRow < 0 Then Exit Sub
        MasterGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = MasterGRV.GetFocusedRow
        CyberSupport.V_UpdateGRV(MasterGRV)
        Updatelist()
    End Sub
    Private Sub Updatelist()
        ' -- Tính tiền phụ kiện
        Dim _T_So_Luong As Double = 0
        Dim _T_Tien_Nt As Double = 0

        For iRow As Integer = 0 To Dv_Master.Count - 1
            _T_So_Luong = _T_So_Luong + Dv_Master.Item(iRow).Item("So_Luong")
            _T_Tien_Nt = _T_Tien_Nt + Dv_Master.Item(iRow).Item("Tien_Nt")
        Next
        TxtT_So_Luong.Double = _T_So_Luong
        TxtT_Tien_Nt.Double = _T_Tien_Nt

        TxtT_So_Luong.Refresh()
        TxtT_Tien_Nt.Refresh()
    End Sub
    Private Sub V_ReadOnly()
        TxtT_Tien_No.ReadOnly = True
        TxtT_Tien_Nt.ReadOnly = True
        TxtT_So_Luong.ReadOnly = True
    End Sub
#End Region
#Region "Grv View"
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Create"), AddressOf V_ShortAddItem, Shortcut.F4, Nothing, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete"), AddressOf V_ShortDeleteItem, Shortcut.F8, Nothing, True, False))
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub MasterGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim iCoumnVisible As Integer = MasterGRV.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = MasterGRV.RowCount - 1
        Dim iRowRowFocus As Integer = MasterGRV.FocusedRowHandle
        Dim iColumnRowFocus As Integer = MasterGRV.VisibleColumns.IndexOf(MasterGRV.FocusedColumn)
        Dim iRowOld As Integer = MasterGRV.GetFocusedDataSourceRowIndex
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItem(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = MasterGRV.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = Dv_Master.Item(iRow) Else DrvOld = Nothing
        Dv_Master.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_Master.Table.Rows(Dv_Master.Table.Rows.Count - 1))
        CarrOn(Dv_Master.Table.Rows(Dv_Master.Table.Rows.Count - 1))
        iRow = Dv_Master.Count - 1
        CyberFill.V_ForcusCell(Dv_Master, iRow, 0)
    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = MasterGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        Dv_Master.Delete(iRow)
        Dv_Master.Table.AcceptChanges()
    End Sub
#End Region
    Private Sub V_Ok(ByVal sender As Object, ByVal e As EventArgs)
        If Not ChkVsave() Then Exit Sub
        Me.Save_OK = True
        Me.Close()
    End Sub
    Private Function ChkVsave() As Boolean
        If TxtT_Tien_No.Double <> TxtT_Tien_Nt.Double And Dv_Master.Count > 0 Then
            MsgBox("Tổng số tiền nợ trên hợp đồng và số tiền kê khai theo kỳ không trùng khớp. Xin kiểm tra lại", MsgBoxStyle.Critical, Sysvar.Item("M_CYBER_VER"))
            ChkVsave = False
            Exit Function
        End If
        If TxtT_Tien_Nt.Double = 0 And Dv_Master.Count > 0 Then
            MsgBox("Bạn chưa nhập số tiền cho các kỳ thanh toán", MsgBoxStyle.Critical, Sysvar.Item("M_CYBER_VER"))
            ChkVsave = False
            Exit Function
        End If
        ChkVsave = True
    End Function
End Class