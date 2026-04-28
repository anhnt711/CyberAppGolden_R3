Imports System.Windows.Forms

Public Class DMDMS
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim EditMa_Vt, EditMa_CV, EditMa_NVKD, EditTen_Vt, EditTen_Vt3, EditDVt, EditMa_kho_i, EditTon13, EditTen_kho_i, EditMa_TT,
          EditMa_Vv_i, EditMa_Hd_i, EditMa_phi_I, EditMa_Sp_i, EditMa_ku_I, EditMa_TTLN_I, EditMa_TTCP_I, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I As New Cyber.Fill.CyberColumnGridView
    Dim EditSo_Luong, EditTien2, EditGia2 As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_TD1_i, EditMa_TD2_i, EditMa_TD3_i, EditMa_TD4_i, EditMa_TD5_i As New Cyber.Fill.CyberColumnGridView

    Dim DT_DetailTmp, Dt_HeadVT As DataTable
    Dim Dv_DetailTmp, Dv_HeadVT As DataView
    Dim M_Ma_CT As String = "HDK"
    Dim M_Ma_TT As String = "C"
    Dim Lan As String = "V"
    Dim Ma_DMSOld, Ma_DvcsOld As String
    Private Sub DMSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        V_GetColumn()

        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

        V_MainSystem()
        V_AddHandler_Detail()
        V_AddHandMaster()
        UpdateList()
        If Mode = "M" Then
            Ma_DMSOld = ""
            Ma_DvcsOld = ""
        Else
            Ma_DMSOld = TxtMa_DMS.Text.Trim
            Ma_DvcsOld = TxtMa_Dvcs.Text.Trim
        End If

    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_KX.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kx", "DmKx", "( Ma_kx = N'" + TxtMa_KX.Text.Trim + "')", CyberSmlib)
        TxtTen_mau.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Mau", "DmMauXe", "( Ma_Mau = N'" + TxtMa_mau.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_FilterCtDMS", TxtMa_DMS.Text.Trim + "#" + Me.Mode.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        DT_DetailTmp = DsTmp.Tables(0).Copy
        Dt_HeadVT = DsTmp.Tables(1).Copy

        Dv_DetailTmp = New DataView(DT_DetailTmp)
        Dv_HeadVT = New DataView(Dt_HeadVT)

        '========= FillData to Gridview
        Detail.DataSource = Dv_DetailTmp
        Me.DetailGRV.GridControl = Me.Detail
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, Dv_HeadVT, Dv_DetailTmp, Nothing)

    End Sub
    Private Sub V_MainSystem()
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsManl As New Windows.Forms.ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem, Keys.F8)

        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRV.GridControl.ContextMenu = mnItemsMail
        Me.ContextMenu = mnItemsManl
    End Sub
    'Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
    '    Dim rowHandle As Integer = e.HitInfo.RowHandle
    '    If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
    '        PopupMenuMasterGrid.ItemLinks.Clear()
    '        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem, Nothing, True, False))
    '        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem, Nothing, True, False))
    '        PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    '    End If
    'End Sub

    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

    End Sub
    Private Sub V_GetColumn()
        EditMa_Vt.GetColumn(Me.DetailGRV, "Ma_Vt")
        EditTen_Vt.GetColumn(Me.DetailGRV, "Ten_Vt")
        EditDVt.GetColumn(Me.DetailGRV, "DVT")
        EditTon13.GetColumn(Me.DetailGRV, "Ton13")
        EditMa_kho_i.GetColumn(Me.DetailGRV, "Ma_kho_I")
        EditTen_kho_i.GetColumn(Me.DetailGRV, "Ten_kho_I")

        EditSo_Luong.GetColumn(Me.DetailGRV, "So_luong")
        EditGia2.GetColumn(Me.DetailGRV, "Gia2")
        EditTien2.GetColumn(Me.DetailGRV, "Tien2")
    End Sub
    Private Sub V_AddHandMaster()
        'AddHandler DetailGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler DetailGRV.KeyDown, AddressOf MasterGRV_KeyDown
        '--Ma_kx
        AddHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_kx
        '--Ma_mau
        AddHandler TxtMa_mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_mau.CyberLeave, AddressOf L_Ma_Mau

    End Sub
    Private Sub V_AddHandler_Detail()
        EditTen_Vt.ColumnReadOnly = True
        EditDVt.ColumnReadOnly = True

        EditMa_Vt.V_ActiLookUpColumn(AddressOf V_Ma_Vt, AddressOf L_Ma_Vt)
        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditGia2.Column Is Nothing Then AddHandler EditGia2.EditColumn.Leave, AddressOf V_Tinh_ToanPT
        If Not EditTien2.Column Is Nothing Then AddHandler EditTien2.EditColumn.Leave, AddressOf V_Tinh_ToanPT
    End Sub
#End Region
#Region "Valid"
#Region "Ma_Vt"
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Vt", "DmVt", "1=1", "1=1", Me.Mode, M_Ma_CT, M_LAN, M_Para, oSysvar, Appconn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Me.Mode = "S") Then Exit Sub
        DrReturn = Nothing

        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow)("Ma_vt") = ""
            Dv_DetailTmp.Item(iRow).Item("Ten_VT") = ""
            Dv_DetailTmp.Item(iRow).Item("Dvt") = ""
            Dv_DetailTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_VT As String = "", _DVT As String = "", _Ten_VT As String = ""
        Dim _Gia2 As Decimal = 0

        _Ma_VT = DrReturn("Ma_vt").ToString.Trim
        _Ten_VT = DrReturn("Ten_VT").ToString.Trim
        _DVT = DrReturn("DVT").ToString.Trim

        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_Vt") = _Ma_VT
        Dv_DetailTmp.Item(iRow).Item("Ten_vt") = _Ten_VT
        Dv_DetailTmp.Item(iRow).Item("DVT") = _DVT
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-----------------------------------------------------------------------------------------------------------
        Tinh_Gia2(iRow)
        Tinh_TienPT(iRow)
        UpdateList()
        '-----------------------------------------------------------------------------------------------------------
        DetailGRV.UpdateCurrentRow()
    End Sub
    Private Sub Tinh_Gia2(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub

        Dim _Gia2 As Decimal = Dv_DetailTmp.Item(iRow).Item("Gia2")
        Dim _Ma_vt As String = Dv_DetailTmp.Item(iRow).Item("Ma_Vt")
        Dim _Ma_Kho As String = ""
        Dim _Ngay_Ct As Date = Now.Date
        '-----------------------------------------------------------------------------------------------------------
        Dim dsGia2 As New DataSet
        dsGia2 = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetHDKGia2", _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_CT.Trim & "#" & "" & "#" & Me.Mode & "#" &
                                                    "S" & "#" & "2" & "#" & _Ma_vt.Trim & "#" & _Ma_Kho.Trim + "#" & M_Ma_TT & "#" &
                                                    _Gia2.ToString.Trim.Replace(" ", "").Replace(",", ".") & "#" & TxtMa_Dvcs.Text.Trim + "#" + M_User_Name.Trim)
        _Gia2 = dsGia2.Tables(0).Rows(0).Item("Gia2")
        dsGia2.Dispose()
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Gia2") = _Gia2
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-----------------------------------------------------------------------------------------------------------
    End Sub
#End Region
#Region "Vali --- Ma_kx"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KX.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kx", "Dmkx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_KX.Text = "" Then
            TxtTen_KX.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_KX.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KX.Text = DrReturn.Item("Ma_kx")
            TxtTen_KX.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_KX.Text = ""
            TxtTen_KX.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_mau"
    Private Sub V_Ma_mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_mau.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_mau", "Dmmauxe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_mau.Text = "" Then
            TxtTen_mau.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_mau.Text = DrReturn.Item("Ma_mau")
            TxtTen_mau.Text = DrReturn.Item("Ten_mau")
        Else
            TxtMa_mau.Text = ""
            TxtTen_mau.Text = ""
        End If
    End Sub
#End Region
#Region "F4/F8-Vat tu"
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        vTbAdd = Dv_DetailTmp
        '===================================
        If iRow >= 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing

        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), Dv_HeadVT)
        CarrOn(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRV, iRow, 0)
        UpdateList()
    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTmp, Appconn) Then Exit Sub
        Dv_DetailTmp.Delete(iRow)
        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub MasterGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItem(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
#End Region
    Private Sub Tinh_TienPT(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub
        Dim nTy_Gia As Decimal = 1
        nTy_Gia = 1
        'Thanh Tien---------------------------------------------------------------------------------------
        Dv_DetailTmp.Item(iRow).BeginEdit()
        If Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia2") <> 0 Then
            Dv_DetailTmp.Item(iRow).Item("Tien2") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_luong") * Dv_DetailTmp.Item(iRow).Item("Gia2"), 0)
        End If
        Dv_DetailTmp.Item(iRow).EndEdit()
        '-------------------------------------------------------------------------------------------------
        UpdateList()
    End Sub
    Private Sub V_Tinh_ToanPT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DT_DetailTmp.AcceptChanges()
        Tinh_TienPT(iRow)
    End Sub
    Private Sub UpdateList()
        Dim nT_So_Luong As Decimal = 0
        Dim nT_Tien2 As Decimal = 0
        For i As Integer = 0 To DT_DetailTmp.Rows.Count - 1
            nT_So_Luong = nT_So_Luong + DT_DetailTmp.Rows(i).Item("So_Luong")
            nT_Tien2 = nT_Tien2 + DT_DetailTmp.Rows(i).Item("Tien2")
        Next
        TxtT_So_Luong.Double = nT_So_Luong
        TxtT_Tien2.Double = nT_Tien2
    End Sub
#End Region
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_DMS.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        'If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        Dim nCount As Integer = 0

        nCount = DT_DetailTmp.Rows.Count - 1
        For i = nCount To 0 Step -1
            If DT_DetailTmp.Rows(i).Item("Ma_VT").ToString.Trim = "" Then
                DT_DetailTmp.Rows(i).Delete()
                DT_DetailTmp.AcceptChanges()
            End If
        Next
        '=====================================
        For i = 0 To DT_DetailTmp.Rows.Count - 1
            DT_DetailTmp.Rows(i).BeginEdit()
            DT_DetailTmp.Rows(i).Item("Ma_DMS") = TxtMa_DMS.Text.Trim
            DT_DetailTmp.Rows(i).Item("Ma_KX") = TxtMa_KX.Text.Trim
            DT_DetailTmp.Rows(i).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(i + 1)
            DT_DetailTmp.Rows(i).EndEdit()
        Next
        '=====================================
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub

        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, DT_DetailTmp, "CTDMS", Mode, "Ma_DMS =N'" + Ma_DMSOld.Trim + "'")

        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class

