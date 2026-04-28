Imports System.Windows.Forms

Public Class Dmxe_hddh
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim EditMa_Vitri, EditMa_xe, EditMa_Vt, EditMa_CV, EditMa_NVKD, EditTen_Vt, EditTen_Vt3, EditDVt, EditMa_kho_i, EditTon13, EditTen_kho_i, EditMa_TT, _
          EditMa_Vv_i, EditMa_Hd_i, EditMa_phi_I, EditMa_Sp_i, EditMa_ku_I, EditMa_TTLN_I, EditMa_TTCP_I, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I As New Cyber.Fill.CyberColumnGridView
    Dim EditSo_Luong, EditTien2, EditGia2 As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_TD1_i, EditMa_TD2_i, EditMa_TD3_i, EditMa_TD4_i, EditMa_TD5_i As New Cyber.Fill.CyberColumnGridView

    Dim DT_DetailTmp, Dt_Head, Dt_DmCt As DataTable
    Dim Dv_DetailTmp, Dv_Head, Dv_DmCt As DataView
    Dim M_Ma_CT As String = "HDK"
    Dim M_Ma_TT As String = "C"
    Dim Lan As String = "V"
    Dim Ma_hd_dhOld, Ma_khOld, Ma_kh_dvcqOld, Ma_hsOld As String
    Dim Ngay_hl1Old, Ngay_hl2Old As Date
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
        If Me.Mode = "M" Then
            Ma_hd_dhOld = ""
            Ma_khOld = ""
            Ma_kh_dvcqOld = ""
            Ma_hsOld = ""
            Ngay_hl1Old = Now.Date
            Ngay_hl2Old = Now.Date
        Else
            Ma_hd_dhOld = TxtSo_HD.Text.Trim
            Ma_khOld = TxtMa_kh.Text.Trim
            Ma_hsOld = Txtma_hs.Text.Trim
            Ngay_hl1Old = Now.Date
            Ngay_hl2Old = Now.Date
        End If

    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_hl1.Value = Now.Date
            TxtNgay_hl2.Value = Now.Date
        End If


        TxtTen_kh.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kh", "Dmkh", "( Ma_kh = N'" + TxtMa_kh.Text.Trim + "')", CyberSmlib)
        TxtTen_hs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_hs", "Dmhs", "( Ma_hs = N'" + Txtma_hs.Text.Trim + "')", CyberSmlib)

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_FilterCtHDDH", TxtMa_kh.Text.Trim + "#" + Me.Mode.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        DT_DetailTmp = DsTmp.Tables(0).Copy
        Dt_Head = DsTmp.Tables(1).Copy
        Dt_DmCt = DsTmp.Tables(2).Copy

        Dv_DetailTmp = New DataView(DT_DetailTmp)

        Dv_Head = New DataView(Dt_Head)
        Dv_DmCt = New DataView(Dt_DmCt)

        '========= FillData to Gridview
        Detail.DataSource = DT_DetailTmp
        Me.DetailGRV.GridControl = Me.Detail
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, Dv_Head, Dv_DetailTmp, Dt_DmCt.Rows(0))

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

    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem, Nothing, True, False))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub

    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
    End Sub
    Private Sub V_GetColumn()
        '---------------------------------------------------------------------------------
        ' Cong Viec
        EditMa_xe.GetColumn(Me.DetailGRV, "Ma_xe")
    End Sub
    Private Sub V_AddHandMaster()
        AddHandler DetailGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler DetailGRV.KeyDown, AddressOf MasterGRV_KeyDown

        AddHandler TxtMa_kh.CyberValiting, AddressOf V_Ma_kh
        AddHandler TxtMa_kh.CyberLeave, AddressOf L_Ma_kh
        '
        AddHandler Txtma_hs.CyberValiting, AddressOf V_Ma_hs
        AddHandler Txtma_hs.CyberLeave, AddressOf L_Ma_hs
    End Sub
    Private Sub V_AddHandler_Detail()
        EditMa_xe.V_ActiLookUpColumn(AddressOf V_Ma_xe, AddressOf L_Ma_xe)
    End Sub
    Private Sub UpdateList()
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
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), Dv_Head)
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
#Region "---Ma_xe"
    Private Sub V_Ma_xe(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_xe", "Dmxe", "1=1", "1=1", Me.Mode, M_Ma_CT, M_LAN, M_Para, oSysvar, Appconn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow)("Ma_xe") = ""
            If DT_DetailTmp.Columns.Contains("ten_LX") Then Dv_DetailTmp.Item(iRow).Item("ten_LX") = ""
            If DT_DetailTmp.Columns.Contains("Dt_Lx") Then Dv_DetailTmp.Item(iRow).Item("Dt_Lx") = ""
            If DT_DetailTmp.Columns.Contains("Dia_chi") Then Dv_DetailTmp.Item(iRow).Item("Dia_chi") = ""
            If DT_DetailTmp.Columns.Contains("Ma_kx") Then Dv_DetailTmp.Item(iRow).Item("Ma_kx") = ""
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_xe") = DrReturn("Ma_xe").ToString.Trim
        If DT_DetailTmp.Columns.Contains("ten_LX") Then Dv_DetailTmp.Item(iRow).Item("ten_LX") = DrReturn("ten_LX").ToString.Trim
        If DT_DetailTmp.Columns.Contains("Dt_Lx") Then Dv_DetailTmp.Item(iRow).Item("Dt_Lx") = DrReturn("Dt_Lx").ToString.Trim
        If DT_DetailTmp.Columns.Contains("Dia_chi") Then Dv_DetailTmp.Item(iRow).Item("Dia_chi") = DrReturn("Dia_chi").ToString.Trim
        If DT_DetailTmp.Columns.Contains("Ma_kx") Then Dv_DetailTmp.Item(iRow).Item("Ma_kx") = DrReturn("Ma_kx").ToString.Trim
        Dv_DetailTmp.Item(iRow).EndEdit()
        DetailGRV.UpdateCurrentRow()
    End Sub
#End Region

    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#Region "Valid"

    Private Sub V_Ma_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kh", "Dmkh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kh.Text = DrReturn.Item("Ma_kh")
            TxtTen_kh.Text = DrReturn.Item("Ten_kh")
        Else
            TxtMa_kh.Text = ""
            TxtTen_kh.Text = ""
        End If
    End Sub
    Private Sub V_Ma_hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_hs", "dmhs", " Acti = '1' AND Nh_Hs2 = N'61.01'", "1=1")
    End Sub
    Private Sub L_Ma_hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_hs.Text = DrReturn.Item("Ma_hs")
            TxtTen_hs.Text = DrReturn.Item("Ten_hs")
        Else
            Txtma_hs.Text = ""
            TxtTen_hs.Text = ""
        End If
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)

        If Not _Value.Trim = "" Then Txtghi_chu.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        Dim nCount As Integer = 0
        nCount = DT_DetailTmp.Rows.Count - 1
        For i = nCount To 0 Step -1
            If DT_DetailTmp.Rows(i).Item("Ma_xe").ToString.Trim = "" Then
                DT_DetailTmp.Rows(i).Delete()
                DT_DetailTmp.AcceptChanges()
            End If
        Next
        nCount = DT_DetailTmp.Rows.Count - 1
        If DT_DetailTmp.Rows.Count = 0 Then
            MsgBox("Bạn chưa nhập liệu chi tiết", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Exit Sub
        End If
        '=====================================
        Dim dt1 As Date = TxtNgay_hl1.Value
        Dim dt2 As Date = TxtNgay_hl2.Value
        For i = 0 To DT_DetailTmp.Rows.Count - 1
            DT_DetailTmp.Rows(i).BeginEdit()
            If DT_DetailTmp.Columns.Contains("ma_Dvcs") Then DT_DetailTmp.Rows(i).Item("ma_Dvcs") = TxtMa_Dvcs.Text.Trim
            If DT_DetailTmp.Columns.Contains("ma_kh") Then DT_DetailTmp.Rows(i).Item("ma_kh") = TxtMa_kh.Text.Trim
            If DT_DetailTmp.Columns.Contains("ma_hs") Then DT_DetailTmp.Rows(i).Item("ma_hs") = Txtma_hs.Text.Trim
            If DT_DetailTmp.Columns.Contains("So_HD") Then DT_DetailTmp.Rows(i).Item("So_HD") = TxtSo_HD.Text.Trim
            If DT_DetailTmp.Columns.Contains("ngay_hl1") Then DT_DetailTmp.Rows(i).Item("ngay_hl1") = dt1
            If DT_DetailTmp.Columns.Contains("ngay_hl2") Then DT_DetailTmp.Rows(i).Item("ngay_hl2") = dt2
            If DT_DetailTmp.Columns.Contains("Acti") Then DT_DetailTmp.Rows(i).Item("Acti") = If(ChkActi.Checked, "1", "0")
            If DT_DetailTmp.Columns.Contains("Stt_Rec0") Then DT_DetailTmp.Rows(i).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(i + 1)
            DT_DetailTmp.Rows(i).EndEdit()
        Next

        '=====================================
        'If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, DT_DetailTmp, "Dmxe_Cthddh", Mode, "Ma_kh = N'" + Ma_khOld.Trim + "'")
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
   

End Class

