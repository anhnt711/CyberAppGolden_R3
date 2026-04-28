Imports System.Windows.Forms
Public Class FrmDmHDXM
#Region "Biến"
    Dim M_Ma_TTCP_H As String = ""
    Dim M_Is_Visible_TTCP As Boolean = False
    Dim DsLookup As DataSet
    Dim Dt_Master, Dt_Sort, Dt_head, Dt_Search, Dt_DmTTCP, Dt_Print As DataTable
    Dim Dv_Master, Dv_head, Dv_Search As DataView
    Dim ProccessList As New Collection
#End Region
    Private Sub FFF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date
        '----------------------------------------------------------------------
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetDefaultVoucher", "BEX".Trim & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())
        If DsTmp.Tables(0).Columns.Contains("Ma_TTCP_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_TTCP_H").ToString.Trim

        If DsTmp.Tables.Count > 1 Then
            Dt_DmTTCP = DsTmp.Tables(1).Copy
        Else
            M_Is_Visible_TTCP = False
        End If

        CyberFill.V_FillComBoxValue(Me.CbbMa_TTCP, Dt_DmTTCP, "Ma_TTCP", If(M_LAN = "V", "Ten_TTCP", "Ten_TTCP2"), M_Ma_TTCP_H)
        '----------------------------------------------------------------------
        V_Loaddatabase("1")
        '----------------------------------------------------------------------
        V_AddHandler()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "System"
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Loaddatabase(_status As String)
        Dim _Dt1 As Date = TxtNgay_Ct1.Value
        Dim _Dt2 As Date = TxtNgay_Ct2.Value
        Dim _ma_TTCP As String = CbbMa_TTCP.SelectedValue

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_XM1DMHDXM_Load", _status & "#" & _Dt1.ToString("yyyyMMdd") & "#" & _Dt2.ToString("yyyyMMdd") & "#" & _ma_TTCP & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If _status = "1" Then

            Dt_Master = DsTmp.Tables(0).Copy
            Dt_Sort = DsTmp.Tables(1).Copy
            Dt_head = DsTmp.Tables(2).Copy
            Dt_Search = DsTmp.Tables(3)

            Dv_Master = New DataView(Dt_Master)
            Dv_head = New DataView(Dt_head)
            Dv_Search = New DataView(Dt_Search)


            CyberSupport.V_SetSortView(Dv_Master, Dt_Sort.Rows(0))

            CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_head, Dv_Master)
            Master.DataSource = Dv_Master
            Me.MasterGRV.GridControl = Me.Master
            MasterGRV.OptionsView.ShowViewCaption = False
            MasterGRV.OptionsSelection.MultiSelect = False
            Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen

            Dim FixCol As Integer = -1
            Try
                FixCol = Dt_Sort.Rows(0).Item("ColFrozen")
            Catch ex As Exception
            End Try

            If FixCol < MasterGRV.Columns.Count And FixCol > 0 Then
                For iCol = 0 To FixCol
                    MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                Next
            End If
            '-----------------------------------------------------------------

            CyberFill.V_FillComBoxValue(CbbSearch, Dt_Search, "Field_Name", "Field_Head1", "")

        Else
            Dt_Master.Clear()
            Dt_Master.Load(DsTmp.Tables(0).CreateDataReader)
            Exit Sub
        End If
    End Sub
    Private Sub V_AddHandler()
        RemoveHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        RemoveHandler CbbMa_TTCP.SelectedValueChanged, AddressOf V_ChangeValue
        'RemoveHandler TxtNgay_Ct1.Validated, AddressOf V_ChangeValue
        'RemoveHandler TxtNgay_Ct2.Validated, AddressOf V_ChangeValue
        RemoveHandler CbbSearch.Click, AddressOf V_ChangeValue

        RemoveHandler CbbSearch.Click, AddressOf V_ChangeValue
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit

        RemoveHandler TxtMa_Kh.Leave, AddressOf V_Filter
        RemoveHandler TxtSCMT.Leave, AddressOf V_Filter
        RemoveHandler TxtSDT.Leave, AddressOf V_Filter

        RemoveHandler TxtSearch.TextChanged, AddressOf V_Filter
        RemoveHandler CbbSearch.TextChanged, AddressOf V_Filter
        RemoveHandler CbbLoc_SL.Click, AddressOf V_Refresh

        '---------------------------------------------------------------------------------------------------
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler CbbMa_TTCP.SelectedValueChanged, AddressOf V_ChangeValue
        'AddHandler TxtNgay_Ct1.Validated, AddressOf V_ChangeValue
        'AddHandler TxtNgay_Ct2.Validated, AddressOf V_ChangeValue

        AddHandler CbbSearch.Click, AddressOf V_ChangeValue
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit


        AddHandler TxtMa_Kh.Leave, AddressOf V_Filter
        AddHandler TxtSCMT.Leave, AddressOf V_Filter
        AddHandler TxtSDT.Leave, AddressOf V_Filter
        AddHandler TxtSearch.TextChanged, AddressOf V_Filter
        AddHandler CbbSearch.TextChanged, AddressOf V_Filter
        AddHandler CbbLoc_SL.Click, AddressOf V_Refresh
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#End Region
#Region "Tạo mới/Sửa/In/xóa/Export Excel/Refresh"
    Private Sub V_F4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_F3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_F7(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_F8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_ExportExcels(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Loaddatabase("0")
        V_Filter(sender, e)
    End Sub
    Private Sub V_ChangeValue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Loaddatabase("0")
        V_Filter(sender, e)
    End Sub
    Private Sub V_Filter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strFilter As String = "1=1"
        If Not TxtMa_Kh.Text.Trim = "" And Dt_Master.Columns.Contains("Ma_KH") Then strFilter = strFilter + " AND Ma_kh = '" + TxtMa_Kh.Text + "'"
        If Not TxtSCMT.Text.Trim = "" And Dt_Master.Columns.Contains("SCMT") Then strFilter = strFilter + " AND SCMT = '" + TxtSCMT.Text + "'"


        If Not TxtSDT.Text.Trim = "" Then
            If Dt_Master.Columns.Contains("DT1") Then
                strFilter = strFilter + " AND (DT1 = '" + TxtSDT.Text + "'"
                If Dt_Master.Columns.Contains("DT2") Then strFilter = strFilter + " OR DT2 = '" + TxtSDT.Text + "'"
                strFilter = strFilter + " )"
            Else
                If Dt_Master.Columns.Contains("DT2") Then strFilter = strFilter + " AND DT2 = '" + TxtSDT.Text + "'"
            End If
        End If
        '-------------------------------------------------------------------------------------
        Dim _FieldName As String = CbbSearch.SelectedValue.ToString.Trim
        Dim _Value As String = TxtSearch.Text.Trim
        Dim _Filter1 As String = CyberSmlistSys.V_FilterDataColumns(Dv_Master, Dv_Search, _FieldName, _Value, "%", "0")
        _Filter1 = _Filter1.Trim
        '-------------------------------------------------------------------------------------
        strFilter = strFilter.Trim

        If Not _Filter1 = "" Then strFilter = strFilter + " AND (" + _Filter1 + ")"
        If strFilter = "1=1" Then strFilter = ""


        MasterGRV.ActiveFilterString = strFilter
        MasterGRV.FocusedRowHandle = 0
        'Try
        '    Dv_Master.RowFilter = strFilter
        'Catch ex As Exception
        'End Try
    End Sub
#End Region
#Region "Grv View"
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer

        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle

        PopupMenuMasterGrid.ItemLinks.Clear()
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex

        'Dim MenuExits As Cyber.SmLib.CyberMenuPopup
        PopupMenuMasterGrid.ItemLinks.Clear()

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo mới hợp đồng", "Create"), AddressOf V_F4, Shortcut.F4, My.Resources.apply_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Sửa hợp đồng", "Edit"), AddressOf V_F3, Shortcut.F3, My.Resources.edit_16x16, True, False), False)
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "In hợp đồng", "Print"), AddressOf V_F7, Shortcut.F7, My.Resources.Preview_16_IN, True, False), True)

        '-------------------------------------------------------------------------------------------------------------------------------------------
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lập lệnh bán phụ kiện", "Lập lệnh bán phụ kiện"), AddressOf V_Tao_PhieuHDM, Nothing, My.Resources.apply_16x16, True, False))
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lập phiếu xuất phụ kiện trả khách", "Lập phiếu xuất phụ kiện trả khách"), AddressOf V_Tao_Phieu_Pk_KhuyenMai, Nothing, My.Resources.apply_16x16, True, False))
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lập phiếu xuất phụ kiện xe mới", "Lập phiếu xuất phụ kiện xe mới"), AddressOf V_Tao_Phieu_Pk_XeMoi, Nothing, My.Resources.apply_16x16, True, False))
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lập lệnh tặng quà", "Lập lệnh tặng quà"), AddressOf V_Tao_PhieuHDQ, Nothing, My.Resources.apply_16x16, True, False))
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lập phiếu tặng Voucher", "Lập phiếu tặng Voucher"), AddressOf V_Tao_PhieuSK6, Nothing, My.Resources.apply_16x16, True, False))

        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo phiếu thu", "Tạo phiếu thu"), AddressOf V_Tao_PT, Shortcut.F9, My.Resources.apply_16x16, True, False), True)
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo phiếu xuất xe", "phiếu xuất xe"), AddressOf V_Tao_HD, Shortcut.F10, My.Resources.apply_16x16, True, False))
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo phiếu nhận chứng từ của khách hàng", "Tạo phiếu nhận chứng từ của khách hàng"), AddressOf V_Tao_Hs1, Nothing, My.Resources.apply_16x16, True, False))
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Đăng ký kỳ thanh toán", "Đăng ký kỳ thanh toán"), AddressOf V_Tao_PhieuKTT, Nothing, My.Resources.apply_16x16, True, False))
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "In hợp đồng", "Refresh"), AddressOf V_Print, Shortcut.F7, My.Resources.printer_16x16, True, False))
        ''PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa hợp đồng", "Delete"), AddressOf V_F8, Shortcut.F8, My.Resources.deletesheetcolumns_16x16, True, False))
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lập hóa đơn bán bảo hiểm, đăng ký, đăng kiểm", "Lập hóa đơn bán bảo hiểm, đăng ký, đăng kiểm"), AddressOf V_Tao_PhieuHDA, Nothing, My.Resources.apply_16x16, True, False))

        '-------------------------------------------------------------------------------------------------------------------------------------------

        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xuất dữ liệu ra Excel", "Export Excel"), AddressOf V_ExportExcels, My.Resources.exporttoxls_16x16, True, True), True)
        'PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, My.Resources.refresh, True, True))

        ' ''--- End Tuy chọn
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exit, My.Resources.cancel_16x16, True, True)
        'MenuExits = New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exit, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)

        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        'End If
    End Sub
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
    End Sub
#End Region

End Class
