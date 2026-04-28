Imports System.Windows.Forms
Imports System.Data.SqlClient
Public Class CTDmHDXM
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    'Dim M_AppConn As SqlConnection

    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Public Dt_head, Dt_Master As DataTable
    Public Dv_head, Dv_Master As DataView

    Dim DrDmct As DataRow
    Dim EditSo_Khung, EditSo_May, EditMa_Mau, EditMa_Kx, EditSo_luong, EditGia_ban, EditThanh_tien As New Cyber.Fill.CyberColumnGridView
    Private Sub CTDMHD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        Master.DataSource = Dv_Master
        CyberFill.V_FillVoucher(MasterGRV, Me.Lan, Dv_head, Dv_Master, DrDmct)
        V_GetColumn()
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
        V_AddHandler()
        V_AddhandlerDetail()
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
    End Sub
#Region "Loading ..."
    Private Sub V_GetColumn()
        EditSo_Khung.GetColumn(MasterGRV, "So_Khung")
        EditSo_May.GetColumn(MasterGRV, "So_May")
        EditMa_Mau.GetColumn(MasterGRV, "Ma_Mau")
        EditMa_Kx.GetColumn(MasterGRV, "Ma_kx")
        EditSo_luong.GetColumn(MasterGRV, "So_luong")
        EditGia_ban.GetColumn(MasterGRV, "Gia_ban")
        EditThanh_tien.GetColumn(MasterGRV, "Thanh_tien")
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_AddHandler()
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler MasterGRV.KeyDown, AddressOf MasterGRV_KeyDown
        AddHandler ButtOK.Click, AddressOf V_Ok
        AddHandler CmdImport.Click, AddressOf V_SelectFile

        MasterGRV.ViewCaption = ""
        MasterGRV.OptionsView.ShowViewCaption = False
    End Sub
    Private Sub V_AddhandlerDetail()
        EditMa_Kx.V_ActiLookUpColumn(AddressOf V_Ma_Kx_i, AddressOf L_Ma_Kx_i)
        EditMa_Mau.V_ActiLookUpColumn(AddressOf V_Ma_Mau, AddressOf L_Ma_Mau)

        If Not EditSo_luong.Column Is Nothing Then AddHandler EditSo_luong.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia_ban.Column Is Nothing Then AddHandler EditGia_ban.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditThanh_tien.Column Is Nothing Then AddHandler EditThanh_tien.EditColumn.Leave, AddressOf L_Tinh_Toan

        EditSo_Khung.V_ActiLookUpColumn(AddressOf V_SoKhung, AddressOf L_SoKhung)
    End Sub
#End Region
#Region "Valid - Detail"
    Private Sub V_Ma_Kx_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_kx", "DmKx", "Is_KD ='1'", "1=1", "M", "", M_LAN, Para, Sysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kx_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        MasterGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = MasterGRV.GetFocusedRow
        Dim drRertrun As DataRow = CyberSupport.L_Lookup("M", "", sender, True)
        If Not drRertrun Is Nothing Then
            drvCurren.Item("ma_kx") = drRertrun("ma_kx")
            drvCurren.Item("ten_kx") = drRertrun("ten_kx")
        Else
            drvCurren.Item("ma_kx") = ""
            drvCurren.Item("ten_kx") = ""
        End If
    End Sub
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Mau", "DmMauXe", "1=1", "1=1", "M", "", M_LAN, Para, Sysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        MasterGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = MasterGRV.GetFocusedRow
        Dim drRertrun As DataRow = CyberSupport.L_Lookup("M", "", sender, True)
        If Not drRertrun Is Nothing Then
            drvCurren.Item("Ma_Mau") = drRertrun("Ma_Mau")
            drvCurren.Item("Ten_Mau") = drRertrun("Ten_Mau")
        Else
            drvCurren.Item("Ma_Mau") = ""
            drvCurren.Item("Ten_Mau") = ""
        End If
    End Sub
    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex()
        If iRow < 0 Then Exit Sub
        MasterGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = MasterGRV.GetFocusedRow
        CyberSupport.V_UpdateGRV(MasterGRV)
        V_Tinh_Toan(iRow)
    End Sub
    Private Sub V_Tinh_Toan(ByVal irow As Integer)
        If irow < 0 Then Exit Sub
        'Thanh Tien---------------------------------------------------------------------------------------
        Dv_Master.Item(irow).BeginEdit()
        If Dv_Master.Item(irow).Item("So_luong") * Dv_Master.Item(irow).Item("Gia_Ban") <> 0 Then
            Dv_Master.Item(irow).Item("Thanh_tien") = CyberSupport.V_Round(Dv_Master.Item(irow).Item("So_luong") * Dv_Master.Item(irow).Item("Gia_Ban"), 0)
        End If
        Dv_Master.Item(irow).EndEdit()
        '-------------------------------------------------------------------------------------------------
    End Sub
    Private Sub L_So_May(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex()
        If iRow < 0 Then Exit Sub
        GetDetail_So_May(iRow, "2")
    End Sub
    Private Sub L_So_Khung(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex()
        If iRow < 0 Then Exit Sub
        GetDetail_So_May(iRow, "1")
    End Sub
    Private Sub GetDetail_So_May(ByVal iRow As Integer, ByVal _Loai As String)
        If iRow < 0 Then Exit Sub
        Dim _Ma_HD As String = ""
        Dim _Ma_kx As String = Dv_Master.Item(iRow).Item("Ma_kx").ToString.Trim
        Dim _Ma_Mau As String = Dv_Master.Item(iRow).Item("Ma_Mau").ToString.Trim
        Dim _So_Khung As String = Dv_Master.Item(iRow).Item("So_Khung").ToString.Trim
        Dim _So_May As String = Dv_Master.Item(iRow).Item("So_May").ToString.Trim
        Dim _Gia_NT2 As Decimal = 0 'Dv_Master.Item(iRow).Item("Gia_Ban")
        Dim _Tien_Nt2 As Decimal = 0 'Dv_Master.Item(iRow).Item("Thanh_tien")

        Dim DsgetPrice As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetDetailSo_May", _Loai + "#" + _Ma_HD + "#" + _Ma_kx.Trim + "#" + _Ma_Mau.Trim + "#" + _
         _So_Khung + "#" + _So_May + "#" + _Gia_NT2.ToString.Trim.Replace(",", ".") + "#" + _Tien_Nt2.ToString.Trim.Replace(",", ".") + "##" + M_User_Name.Trim)
        If DsgetPrice.Tables.Count <= 0 Then
            DsgetPrice.Dispose()
            Exit Sub
        End If

        If DsgetPrice.Tables(0).Rows.Count <= 0 Then
            DsgetPrice.Dispose()
            Exit Sub
        End If

        Dim _DtGia As DataTable = DsgetPrice.Tables(0)
        Dv_Master.Item(iRow).BeginEdit()
        If _DtGia.Columns.Contains("So_Luong") Then Dv_Master.Item(iRow).Item("So_Luong") = _DtGia.Rows(0).Item("So_Luong")
        If _DtGia.Columns.Contains("Ma_Kx") Then Dv_Master.Item(iRow).Item("Ma_Kx") = _DtGia.Rows(0).Item("Ma_Kx")
        If _DtGia.Columns.Contains("Ten_Kx") Then Dv_Master.Item(iRow).Item("Ten_Kx") = _DtGia.Rows(0).Item("Ten_Kx")
        If _DtGia.Columns.Contains("Ma_Mau") Then Dv_Master.Item(iRow).Item("Ma_Mau") = _DtGia.Rows(0).Item("Ma_Mau")
        If _DtGia.Columns.Contains("Ten_Mau") Then Dv_Master.Item(iRow).Item("Ten_Mau") = _DtGia.Rows(0).Item("Ten_Mau")
        If _DtGia.Columns.Contains("So_Khung") Then Dv_Master.Item(iRow).Item("So_Khung") = _DtGia.Rows(0).Item("So_Khung")
        If _DtGia.Columns.Contains("So_May") Then Dv_Master.Item(iRow).Item("So_May") = _DtGia.Rows(0).Item("So_May")
        If _DtGia.Columns.Contains("Gia_Ban") Then Dv_Master.Item(iRow).Item("Gia_Ban") = _DtGia.Rows(0).Item("Gia_NT2")
        If _DtGia.Columns.Contains("Tien_Ban") Then Dv_Master.Item(iRow).Item("Tien_Ban") = _DtGia.Rows(0).Item("Tien_Nt2")
        If _DtGia.Columns.Contains("Gia_VAT") Then Dv_Master.Item(iRow).Item("Gia_VAT") = _DtGia.Rows(0).Item("Gia_VAT")
        Dv_Master.Item(iRow).EndEdit()
        Dv_Master.Table.AcceptChanges()
        DsgetPrice.Dispose()
        V_Tinh_Toan(iRow)
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
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo mới mới", "Create"), AddressOf V_ShortAddItem, Shortcut.F4, Nothing, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa ", "Delete"), AddressOf V_ShortDeleteItem, Shortcut.F8, Nothing, True, False))
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
#Region "LookUp from StoreProcedure"
    Private Sub V_SoKhung(ByVal sender As Object, ByVal e As EventArgs)
        If DsLookup.Tables.Contains("DMSOKHUNG") = False Then
            Dim DsDmLookup As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetDataDmSoKhung", M_Ma_Dvcs & "#" & M_User_Name)
            Dim TbDmLookUp As DataTable = DsDmLookup.Tables(0).Copy
            TbDmLookUp.TableName = "DMSOKHUNG"
            DsLookup.Tables.Add(TbDmLookUp)
        End If
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "So_Khung", "DMSOKHUNG", "1=1", "1=1")
    End Sub
    Private Sub L_SoKhung(ByVal sender As Object, ByVal e As EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup("S", "DMHD", sender, True)
        If DrReturn Is Nothing Then
            Dv_Master.Item(iRow).BeginEdit()
            Dv_Master.Item(iRow).Item("So_Khung") = ""
            Dv_Master.Item(iRow).EndEdit()
            Exit Sub
        Else
            Dv_Master.Item(iRow).BeginEdit()
            Dv_Master.Item(iRow).Item("So_Khung") = DrReturn("So_Khung").ToString.Trim
            Dv_Master.Item(iRow).EndEdit()
        End If
        Dv_Master.Table.AcceptChanges()
        V_GetTTSoKhung(iRow)
        MasterGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_GetTTSoKhung(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub
        MasterGRV.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = MasterGRV.GetFocusedRow

        Dim _So_May As String
        Dim _So_Khung As String
        _So_May = Dv_Master.Item(iRow).Item("So_May")
        _So_Khung = Dv_Master.Item(iRow).Item("So_Khung")

        Dim DsGetSoMay As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_HPY_GetTTXe", "1#" + _So_May.Trim + "#" & _So_Khung.Trim + "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsGetSoMay.Tables(0), Me.Sysvar, M_LAN) Then
            DsGetSoMay.Dispose()
            Exit Sub
        End If

        Dim DtTTXe As DataTable = DsGetSoMay.Tables(1)
        Dv_Master.Item(iRow).BeginEdit()
        Dv_Master.Item(iRow).Item("So_Khung") = DtTTXe.Rows(0).Item("So_Khung")
        Dv_Master.Item(iRow).Item("So_May") = DtTTXe.Rows(0).Item("So_May")
        Dv_Master.Item(iRow).Item("Ma_Kx") = DtTTXe.Rows(0).Item("Ma_Kx")
        Dv_Master.Item(iRow).Item("Ten_Kx") = DtTTXe.Rows(0).Item("Ten_Kx")
        Dv_Master.Item(iRow).Item("Ma_Mau") = DtTTXe.Rows(0).Item("Ma_Mau")
        Dv_Master.Item(iRow).Item("Ten_Mau") = DtTTXe.Rows(0).Item("Ten_Mau")
        Dv_Master.Item(iRow).Item("So_luong") = DtTTXe.Rows(0).Item("So_luong")
        Dv_Master.Item(iRow).EndEdit()
        DsGetSoMay.Dispose()
    End Sub
#End Region
    Private Sub V_Ok(ByVal sender As Object, ByVal e As EventArgs)
        Me.Save_OK = True
        Me.Close()
    End Sub
#Region "Sms - Import"
    Private Sub V_SelectFile(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TbImport As New DataTable
        CyberExport = New Cyber.Export.Sys
        TbImport = CyberExport.V_ImportDataToGridview(AppConn, Sysvar, Para, MasterGRV, Dt_Master, M_LAN)
        If TbImport Is Nothing Then Exit Sub

        Dt_Master.Clear()
        Dt_Master.AcceptChanges()

        'Xóa dòng sai định dạng
        Dim iRow, nCount As Integer
        nCount = TbImport.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If TbImport.Rows(iRow).Item("So_Khung").ToString.Trim = "So_Khung" Or TbImport.Rows(iRow).Item("So_Khung").ToString.Trim = "" Then
                TbImport.Rows(iRow).Delete()
                TbImport.AcceptChanges()
            End If
        Next

        For i = 0 To TbImport.Rows.Count - 1
            Dt_Master.ImportRow(TbImport.Rows(i))
            V_GetTTSoKhung(i)
        Next

        Dt_Master.AcceptChanges()
    End Sub
#End Region
End Class