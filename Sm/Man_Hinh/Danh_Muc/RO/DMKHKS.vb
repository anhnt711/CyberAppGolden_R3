Imports System.Windows.Forms
Public Class DMKHKS
    '==============================================
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim tbCtdmkhks, tbCtPtts As New DataTable
    Dim DvCtDmKHKS, DvCtPtts As New DataView
    Dim DvNvH, DvHTH, DvCtDmKHKS_H, DvPTH As New DataView
    '==============================================
    Dim Ma_KHOld, Ma_DvcsOld As String
    Dim T_Nguyen_Gia, T_Gt_Da_Kh, T_GT_CL, T_Gt_kh_Ky As Decimal
    '===============================================
    Dim EditNVMa_NV, EditNVMa_Tang, EditNVGt_da_kh, EditNVGt_kh_ky, EditNVNguyen_gia, EditNVGt_Cl, EditNVThang_Kh, EditNVNgay_Tang, EditNVNgay_kh, EditMa_giam, EditStt_Rec0, EditNVTk_co, EditNVTk_no As New Cyber.Fill.CyberColumnGridView

    Dim EditNVMa_phi, EditNVMa_vv, EditNVMa_hd, EditNVMa_sp, EditNVMa_KU, _
        EditNVMa_TTLN, EditNVMa_TTCP, EditNVMa_Bp, EditNVMa_HS, EditNVMa_Cd, EditNVMa_Db, EditNVMa_Xe, EditNVMa_Kx, EditNVMa_Tuyen, _
        EditNVMa_TD1, EditNVMa_TD2, EditNVMa_TD3, EditNVMa_TD4, EditNVMa_TD5 As New Cyber.Fill.CyberColumnGridView


    Dim EditHTMa_NV, EditHTMa_Tang, EditHTMa_bpts, EditHTGt_da_kh, EditHTGt_kh_ky, EditHTNguyen_gia, EditHTTk_co, EditHTTk_no, _
        EditHTMa_phi, EditHTMa_vv, EditHTMa_hd, EditHTMa_sp, EditHTMa_KU, _
        EditHTMa_TTLN, EditHTMa_TTCP, EditHTMa_Bp, EditHTMa_HS, EditHTMa_Cd, EditHTMa_Db, EditHTMa_Xe, EditHTMa_Kx, EditHTMa_Tuyen, _
        EditHTMa_TD1, EditHTMa_TD2, EditHTMa_TD3, EditHTMa_TD4, EditHTMa_TD5 As New Cyber.Fill.CyberColumnGridView

    Dim EditTTMa_NV, EditTTMa_bpts, EditTTGt_Cl, EditTTNgay_Tang, EditTTNgay_kh, EditTTNguyen_gia As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_xe As New Cyber.Fill.CyberColumnGridView

    Private Sub DMKHKS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'V_GetChkErro()
        V_Load()
        V_Load_Ctdmkhks(Mode, Txtma_kh.Text.Trim, TxtMa_Dvcs.Text.Trim)
        V_GetColumns()

        V_AddHandlerDetail()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtGhi_chu.Focus()

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        'CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        If Mode = "M" Then
            Ma_KHOld = ""
            Ma_DvcsOld = ""
        Else
            Ma_KHOld = Txtma_kh.Text.Trim
            Ma_DvcsOld = TxtMa_Dvcs.Text.Trim
        End If
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtGhi_chu)
        V_MenuPhu_Tung()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        Txtten_kh.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kh", "Dmkh", "(Ma_kh = N'" + Txtma_kh.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        RemoveHandler Txtma_kh.CyberValiting, AddressOf V_Ma_kh
        RemoveHandler Txtma_kh.CyberLeave, AddressOf L_Ma_kh
        AddHandler Txtma_kh.CyberValiting, AddressOf V_Ma_kh
        AddHandler Txtma_kh.CyberLeave, AddressOf L_Ma_kh
        ' Enter dòng cuối
        AddHandler DetailGRVXe.KeyDown, AddressOf DetailGRVPhu_tung_Ts_KeyDown
    End Sub
    Private Sub V_AddHandlerDetail()
        'EditHTTk_no.V_ActiLookUpColumn(AddressOf V_HTTk_no, AddressOf L_HTTk_no)


        EditMa_xe.V_ActiLookUpColumn(AddressOf V_Ma_Xe, AddressOf L_Ma_Xe)


        EditHTMa_NV.ColumnReadOnly = True
        EditHTMa_Tang.ColumnReadOnly = True
        EditHTMa_bpts.ColumnReadOnly = True
        EditHTGt_da_kh.ColumnReadOnly = True
        EditHTGt_kh_ky.ColumnReadOnly = True
        EditHTNguyen_gia.ColumnReadOnly = True

        ' Trang thai
        EditTTMa_NV.ColumnReadOnly = True
        EditTTMa_bpts.ColumnReadOnly = True
        EditTTGt_Cl.ColumnReadOnly = True
        EditTTNgay_kh.ColumnReadOnly = True
        EditTTNgay_Tang.ColumnReadOnly = True
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Sub V_Load_Ctdmkhks(ByVal M_Mode As String, ByVal sMa_kh As String, ByVal sMa_Dvcs As String)
        Dim DsFilterTsCd As New DataSet
        sMa_kh = sMa_kh.Trim
        sMa_Dvcs = sMa_Dvcs.Trim
        M_Mode = M_Mode.Trim
        DsFilterTsCd = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_FilterCtdmkhks", sMa_kh & "#" & sMa_Dvcs & "#" & M_Mode)
        tbCtdmkhks = DsFilterTsCd.Tables(0)
        DvCtDmKHKS = New DataView(tbCtdmkhks)
        DvCtDmKHKS_H = New DataView(DsFilterTsCd.Tables(1))
        DetailXe.DataSource = DvCtDmKHKS
        Me.DetailGRVXe.GridControl = Me.DetailXe

        CyberFill.V_FillVoucher(DetailGRVXe, M_LAN, DvCtDmKHKS_H, DvCtDmKHKS, Nothing)

    End Sub
    Sub V_GetColumns()
        EditMa_xe.GetColumn(DetailGRVXe, "Ma_xe")


    End Sub
#Region "Menu Gridview"
    Private Sub V_MenuPhu_Tung()
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItemPhu_tung_Ts, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItemPhu_tung_Ts, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVXe.GridControl.ContextMenu = mnItemsMail
    End Sub
#End Region
#End Region



#Region "Vali --- Ma_kh"
    Private Sub V_Ma_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtma_kh.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kh", "Dmkh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Txtma_kh.Text = "" Then
            Txtten_kh.Text = ""
            Exit Sub
        End If
        DrReturn = Txtma_kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_kh.Text = DrReturn.Item("Ma_kh")
            Txtten_kh.Text = DrReturn.Item("Ten_kh")
        Else
            Txtma_kh.Text = ""
            Txtten_kh.Text = ""
        End If
    End Sub
#End Region
#Region "Ma_xe"
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Xe", "DmXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        DrReturn = Nothing
        Dim iRow As Integer = -1
        iRow = DetailGRVXe.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            DvCtDmKHKS.Item(iRow).BeginEdit()
            DvCtDmKHKS.Item(iRow)("Ma_xe") = ""
            DvCtDmKHKS.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_xe As String = ""
        _Ma_xe = DrReturn("Ma_xe").ToString.Trim
        '-----------------------------------------------------------------------------------------------------------
        DvCtDmKHKS.Item(iRow).BeginEdit()
        DvCtDmKHKS.Item(iRow).Item("Ma_xe") = _Ma_xe
        DvCtDmKHKS.Item(iRow).EndEdit()
        DetailGRVXe.UpdateCurrentRow()
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtGhi_chu.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        '=======================================
        'If Not ChkEmpty(TxtGhi_chu) Then Exit Sub
        Dim nCount, i As Integer
        nCount = tbCtdmkhks.Rows.Count - 1
        ' CTDMTS
        For i = nCount To 0 Step -1
            If tbCtdmkhks.Rows(i).Item("Ma_xe").ToString.Trim = "" Then
                tbCtdmkhks.Rows(i).Delete()
                tbCtdmkhks.AcceptChanges()
            End If
        Next

        '--- Check nhap chi tiet
        nCount = tbCtdmkhks.Rows.Count
        If nCount = 0 Then
            MsgBox(IIf(M_LAN = "V", "Chưa vào chi tiết. Không lưu được!", "No details. Do not save it!"), 64, M_CYBER_VER)
            Exit Sub
        End If
        For i = 0 To tbCtdmkhks.Rows.Count - 1
            tbCtdmkhks.Rows(i).BeginEdit()
            'tbCtdmkhks.Rows(i).Item("Stt_Rec0") = Strings.Right("0000" + (i + 1).ToString.Trim, 4)
            tbCtdmkhks.Rows(i).Item("Stt0") = Strings.Right("0000" + (i + 1).ToString.Trim, 4)
            tbCtdmkhks.Rows(i).Item("Ma_KH") = Txtma_kh.Text.Trim
            tbCtdmkhks.Rows(i).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim
            tbCtdmkhks.Rows(i).Item("Acti") = "1"
            tbCtdmkhks.Rows(i).EndEdit()
            tbCtdmkhks.AcceptChanges()
        Next

        '=====================================
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, tbCtdmkhks, "CTDMKHKS", Mode, " Ma_KH  =N'" + Ma_KHOld.Trim + "'")
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
#Region "Add/Delete"
    Sub V_ShortAddItemPhu_tung_Ts(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVXe.FocusedRowHandle
        V_AddItemPhu_tung_Ts(iRow)
    End Sub
    Private Sub V_AddItemPhu_tung_Ts(Optional ByVal iRow As Integer = -1)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow > 0 Then DrvOld = DvCtDmKHKS.Item(iRow) Else DrvOld = Nothing
        DvCtDmKHKS.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(DvCtDmKHKS.Table.Rows(DvCtDmKHKS.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, DvCtDmKHKS.Table.Rows(DvCtDmKHKS.Table.Rows.Count - 1), DvCtDmKHKS_H)
        CarrOnPhu_tung_Ts(DvCtDmKHKS.Table.Rows(DvCtDmKHKS.Table.Rows.Count - 1))
        iRow = DvCtPtts.Count - 1
        If iRow > 0 Then CyberFill.V_ForcusCell(DetailGRVXe, iRow, 0)
    End Sub
    Private Sub CarrOnPhu_tung_Ts(ByVal DvNew As DataRow)
        'DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        'DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        'DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
    Private Sub V_ShortDeleteItemPhu_tung_Ts(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVXe.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, "", iRow, DvCtDmKHKS, Appconn) Then Exit Sub
        DvCtDmKHKS.Delete(iRow)
        DvCtDmKHKS.Table.AcceptChanges()
    End Sub
#End Region
#Region "Enter Dong cuoi"
    Private Sub DetailGRVPhu_tung_Ts_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim Grid As New DevExpress.XtraGrid.Views.Grid.GridView
        Grid = sender
        Dim iCoumnVisible As Integer = Grid.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = Grid.RowCount - 1
        Dim iRowRowFocus As Integer = Grid.FocusedRowHandle
        Dim iColumnRowFocus As Integer = Grid.VisibleColumns.IndexOf(Grid.FocusedColumn)
        Dim iRowOld As Integer = Grid.GetFocusedDataSourceRowIndex

        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItemPhu_tung_Ts(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
#End Region

   
End Class
