Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class FrmVOD_XLTM
    Dim M_Ds_Fill As DataSet
    Dim DrReturn As DataRow
    Public Property Ds_Fill() As DataSet
        Get
            Ds_Fill = M_Ds_Fill
        End Get
        Set(ByVal Value As DataSet)
            M_Ds_Fill = Value
        End Set
    End Property
    Dim M_DsLookup As DataSet
    Public Property DsLookup() As DataSet
        Get
            DsLookup = M_DsLookup
        End Get
        Set(ByVal Value As DataSet)
            M_DsLookup = DsLookup
        End Set
    End Property
    Dim dtMaster, dtMasterHeader As New DataTable
    Dim vdtMaster, vdtMasterHeader As New DataView

    Dim dtDetail, dtDetailHeader As New DataTable
    Dim vdtDetail, vdtDetailHeader As New DataView

    Dim mRec_Detail As String = "", mRec0_Detail As String = ""
    Private Sub FrmVOD_XLKN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_AddHanderl()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date
        TxtNgay_Ct1.Focus()
        V_LoadDatabase("1")
        V_FillDataToGridview(DetailGRV_Master, M_LAN, vdtMasterHeader, vdtMaster)
        V_FillDataToGridview(DetailGRV_Detail, M_LAN, vdtDetailHeader, vdtDetail)

        V_MenuMaster(DetailGRV_Master, AddressOf V_EditMaster)
        V_MenuDetail(DetailGRV_Detail, AddressOf V_EditDetail)

        V_SetGridview()
        V_BilldtingRo(DetailGRV_Master, vdtMaster, vdtDetail)
    End Sub
    Private Sub V_AddHanderl()
        AddHandler DetailGRV_Master.FocusedRowChanged, AddressOf DetailGRVRo_Master_FocusedRowChanged

        AddHandler TxtNgay_Ct1.KeyDown, AddressOf EnterasTab
        AddHandler TxtNgay_Ct2.KeyDown, AddressOf EnterasTab
        '-----------------------------------
        AddHandler btnLoc.Click, AddressOf btnLoc_Click
    End Sub
    Private Sub V_MenuMaster(ByVal DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Events As EventHandler)
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF5 As New MenuItem("Xem chi tiết", AddressOf V_Viewvoucher, Keys.F5)
        Dim mnItemsF7 As New MenuItem("Chuyển người phụ trách", AddressOf V_ChangeUser, Keys.F7)
        mnItemsMail.MenuItems.Add(mnItemsF7)
        mnItemsMail.MenuItems.Add(mnItemsF5)
        DetailGRV.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub V_MenuDetail(ByVal DetailGRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Events As EventHandler)
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF3 As New MenuItem("Sửa chi tiết", AddressOf V_EditItem, Keys.F3)
        Dim mnItemsF4 As New MenuItem("Thêm mới chi tiết", AddressOf V_AddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa chi tiết", AddressOf V_Delete, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF3)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRV.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub V_SetGridview()
        CyberFill.V_GridviewRowCellStyle(DetailGRV_Master) ' dt thuoc tinh Bold cho gridview
        CyberFill.V_GridviewRowCellStyle(DetailGRV_Detail)
    End Sub
    Private Sub DetailGRVRo_Master_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs)
        V_BilldtingRo(sender, vdtMaster, vdtDetail)
    End Sub
#Region "Edit voucher"
    Private Sub V_EditMaster(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberFill.V_EditVoucher(M_LAN, Me.Para, Me.Sysvar, AppConn, DetailGRV_Master)
    End Sub
    Private Sub V_EditDetail(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberFill.V_EditVoucher(M_LAN, Me.Para, Me.Sysvar, AppConn, DetailGRV_Detail)
    End Sub
#End Region
#Region "Data"
    Private Sub V_LoadDatabase(ByVal Status As String)
        Dim Dt1 As Date, Dt2 As Date
        Dt1 = TxtNgay_Ct1.Value
        Dt2 = TxtNgay_Ct2.Value

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_VOD_XLKN_Load", Status & "#" & Dt1.ToString("yyyyMMdd HH:mm").Trim & "#" & Dt2.ToString("yyyyMMdd HH:mm").Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name.Trim)

        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next

        If Status = "1" Then
            dtMaster = DsTmp.Tables(0).Clone
            dtDetail = DsTmp.Tables(1).Clone

            vdtMaster = New DataView(dtMaster)
            vdtDetail = New DataView(dtDetail)

            dtMasterHeader = DsTmp.Tables(2).Copy
            dtDetailHeader = DsTmp.Tables(3).Copy

            vdtMasterHeader = New DataView(dtMasterHeader)
            vdtDetailHeader = New DataView(dtDetailHeader)
        End If

        '-------------------------------------------------------------------------
        dtMaster.Clear()
        If DsTmp.Tables(0).Rows.Count > 0 Then
            For i As Integer = 0 To DsTmp.Tables(0).Rows.Count - 1
                dtMaster.ImportRow(DsTmp.Tables(0).Rows(i))
            Next
        End If

        dtDetail.Clear()
        If DsTmp.Tables(1).Rows.Count > 0 Then
            For i As Integer = 0 To DsTmp.Tables(1).Rows.Count - 1
                dtDetail.ImportRow(DsTmp.Tables(1).Rows(i))
            Next
        End If
        DsTmp.Dispose()
    End Sub
    Private Sub V_BilldtingRo(ByVal MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Dv_Master As DataView, ByVal Dv_DetailTmp As DataView)
        If MasterGRV.GetFocusedRow Is Nothing Then Exit Sub
        If Not Dv_DetailTmp.Table.Columns.Contains("Stt_Rec") Then Exit Sub
        If Not Dv_DetailTmp.Table.Columns.Contains("Stt_Rec0VOD") Then Exit Sub
        If Not Dv_Master.Table.Columns.Contains("Stt_Rec") Then Exit Sub
        If Not Dv_Master.Table.Columns.Contains("Stt_Rec0") Then Exit Sub
        If Dv_Master.Table.Rows.Count < 1 Then Exit Sub
        If Dv_Master.Table.Columns.Count < 1 Then Exit Sub
        Dim filter As String = "1=1"
        Dim selectedRow As DataRowView = Nothing
        Try
            selectedRow = MasterGRV.GetFocusedRow
            If (Not String.IsNullOrEmpty(selectedRow("Stt_Rec").ToString)) Then
                filter = "Stt_Rec='" + selectedRow("Stt_Rec").ToString() + "' and Stt_Rec0VOD = '" + selectedRow("Stt_Rec0").ToString() + "'"
                mRec_Detail = selectedRow("Stt_Rec").ToString()
                mRec0_Detail = selectedRow("Stt_Rec0").ToString()
                Dv_DetailTmp.RowFilter = filter
            End If
        Catch ex As Exception
            Dv_DetailTmp.RowFilter = "1=0"
        End Try
    End Sub
    Private Sub V_AddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xStt_Rec As String = "", xStt_Rec0 As String = "", xStt_Rec0VOD As String = ""
        Dim iRow As Integer = DetailGRV_Detail.FocusedRowHandle
        If iRow < 0 Then
            xStt_Rec = mRec_Detail
            xStt_Rec0VOD = mRec0_Detail
        Else
            Dim selectedRow As DataRowView = Nothing
            Try
                selectedRow = DetailGRV_Detail.GetFocusedRow
                If (Not String.IsNullOrEmpty(selectedRow("Stt_Rec").ToString)) Then
                    xStt_Rec = selectedRow("Stt_Rec").ToString()
                    xStt_Rec0 = selectedRow("Stt_Rec0").ToString()
                    xStt_Rec0VOD = selectedRow("Stt_Rec0VOD").ToString()
                End If
            Catch ex As Exception
            End Try
        End If

        If xStt_Rec = "" Or xStt_Rec0VOD = "" Then Exit Sub

        Dim Form As New FrmVOD_XLTM_F4
        Form.Mode = "M"
        Form.Para = Me.Para
        Form.Sysvar = Me.Sysvar
        Form.M_LAN = Me.M_LAN
        Form.M_User_Name = M_User_Name
        Form.M_Ma_Dvcs = M_Ma_Dvcs
        Form.Para = Me.Para
        Form.AppConn = AppConn
        Form.Sysvar = Me.Sysvar
        Form.Stt_rec = xStt_Rec
        Form.Stt_Rec0VOD = xStt_Rec0VOD
        Form.Stt_rec0 = xStt_Rec0
        Form.ShowDialog()
        If Form.Save_OK = True Then
            dtDetail.ImportRow(Form.Row)
            vdtDetail.RowFilter = " Stt_Rec ='" & Form.Stt_Rec & "' AND Stt_Rec0VOD ='" & Form.Stt_Rec0VOD & "'"
        End If
    End Sub
    Private Sub V_EditItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xStt_Rec As String = "", xStt_Rec0VOD As String = "", xStt_Rec0 As String = ""
        Dim iRow As Integer = DetailGRV_Detail.FocusedRowHandle
        If iRow < 0 Then Exit Sub

        Dim drRowEdit As DataRow = Nothing
        Dim selectedRow As DataRowView = Nothing
        Try
            selectedRow = DetailGRV_Detail.GetFocusedRow
            drRowEdit = DetailGRV_Detail.GetFocusedDataRow
            If (Not String.IsNullOrEmpty(selectedRow("Stt_Rec").ToString)) Then
                xStt_Rec = selectedRow("Stt_Rec").ToString()
                xStt_Rec0 = selectedRow("Stt_Rec0").ToString()
                xStt_Rec0VOD = selectedRow("Stt_Rec0VOD").ToString()
            End If
        Catch ex As Exception
        End Try
        If xStt_Rec = "" Or xStt_Rec0VOD = "" Then Exit Sub

        Dim Form As New FrmVOD_XLTM_F4
        Form.Mode = "S"
        Form.Para = Me.Para
        Form.Sysvar = Me.Sysvar
        Form.M_LAN = Me.M_LAN
        Form.M_User_Name = M_User_Name
        Form.M_Ma_Dvcs = M_Ma_Dvcs
        Form.Para = Me.Para
        Form.AppConn = AppConn
        Form.Sysvar = Me.Sysvar
        Form.Stt_rec = xStt_Rec
        Form.Stt_Rec0VOD = xStt_Rec0VOD
        Form.Stt_rec0 = xStt_Rec0
        Form.Row = drRowEdit
        Form.ShowDialog()
        If Form.Save_OK = True Then
            For i As Integer = 0 To dtDetail.Rows.Count - 1
                If dtDetail.Rows(i).Item("Stt_Rec") = Form.Stt_Rec And dtDetail.Rows(i).Item("Stt_Rec0") = Form.Stt_Rec0 And dtDetail.Rows(i).Item("Stt_Rec0VOD") = Form.Stt_Rec0VOD Then
                    dtDetail.Rows(i).Delete()
                    Exit For
                End If
            Next
            dtDetail.AcceptChanges()
            dtDetail.ImportRow(Form.Row)
            dtDetail.AcceptChanges()
            vdtDetail.RowFilter = " Stt_Rec ='" & Form.Stt_Rec & "' AND Stt_Rec0VOD ='" & Form.Stt_Rec0VOD & "'"
            vdtDetail.Sort = "Stt_Rec0 ASC"
        End If
    End Sub
    Private Sub V_Delete(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dtDetail.Rows.Count = 0 Then Exit Sub
        Dim iRow As Integer = DetailGRV_Detail.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        Dim xStt_Rec As String = "", xStt_Rec0VOD As String = "", xStt_Rec0 As String = ""
        Dim selectedRow As DataRowView = Nothing
        Try
            selectedRow = DetailGRV_Detail.GetFocusedRow
            If (Not String.IsNullOrEmpty(selectedRow("Stt_Rec").ToString)) Then
                xStt_Rec = selectedRow("Stt_Rec").ToString()
                xStt_Rec0 = selectedRow("Stt_Rec0").ToString()
                xStt_Rec0VOD = selectedRow("Stt_Rec0VOD").ToString()
            End If
        Catch ex As Exception
        End Try
        If xStt_Rec = "" Or xStt_Rec0 = "" Then Exit Sub
        Dim nCount As Integer = 0
        Dim DsApproval As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_VOD_XLKN_Del", xStt_Rec & "#" & xStt_Rec0.Trim & "#" & xStt_Rec0VOD.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name)
        nCount = DsApproval.Tables.Count
        If nCount < 1 Then
            DsApproval.Dispose()
            Return
        End If

        If Not CyberSupport.V_MsgChk(DsApproval.Tables(0), Sysvar, M_LAN) Then
            DsApproval.Dispose()
            Return
        End If
        If MsgBox("Bạn có muốn xóa dữ liệu này không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, Me.Sysvar("M_CYBER_VER")) = MsgBoxResult.No Then Exit Sub
        For i As Integer = 0 To dtDetail.Rows.Count - 1
            If dtDetail.Rows(i).Item("Stt_Rec") = xStt_Rec And dtDetail.Rows(i).Item("Stt_Rec0VOD") = xStt_Rec0VOD And dtDetail.Rows(i).Item("Stt_Rec0") = xStt_Rec0 Then
                dtDetail.Rows(i).Delete()
                dtDetail.AcceptChanges()
                vdtDetail.RowFilter = " Stt_Rec ='" & xStt_Rec & "' And Stt_Rec0VOD ='" & xStt_Rec0VOD & "'"
                Exit For
            End If
        Next
    End Sub
    Dim ProccessList As New Collection
    Private Sub V_Viewvoucher(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xStt_Rec As String = "", xStt_Rec0 As String = ""
        Dim iRow As Integer = DetailGRV_Master.FocusedRowHandle
        If iRow < 0 Then Exit Sub

        Dim drRowEdit As DataRow = Nothing
        Dim selectedRow As DataRowView = Nothing
        Try
            selectedRow = DetailGRV_Master.GetFocusedRow
            drRowEdit = DetailGRV_Master.GetFocusedDataRow
            If (Not String.IsNullOrEmpty(selectedRow("Stt_Rec").ToString)) Then
                xStt_Rec = selectedRow("Stt_Rec").ToString()
                xStt_Rec0 = selectedRow("Stt_Rec0").ToString()
            End If
        Catch ex As Exception
        End Try

        Dim strAddParar As String

        strAddParar = "1#VOD#10###" & xStt_Rec

        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
    Private Sub V_ChangeUser(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim xStt_Rec As String = "", xStt_Rec0 As String = "", Ma_Hs_PT As String = "", Ten_Hs_PT As String = ""
        Dim iRow As Integer = DetailGRV_Master.FocusedRowHandle
        If iRow < 0 Then Exit Sub

        Dim drRowEdit As DataRow = Nothing
        Dim selectedRow As DataRowView = Nothing
        Try
            selectedRow = DetailGRV_Master.GetFocusedRow
            drRowEdit = DetailGRV_Master.GetFocusedDataRow
            If (Not String.IsNullOrEmpty(selectedRow("Stt_Rec").ToString)) Then
                xStt_Rec = selectedRow("Stt_Rec").ToString()
                xStt_Rec0 = selectedRow("Stt_Rec0").ToString()
                Ma_Hs_PT = selectedRow("Ma_Hs_PT").ToString()
                Ten_Hs_PT = selectedRow("Ten_Hs_PT").ToString()
            End If
        Catch ex As Exception
        End Try
        If xStt_Rec = "" Or xStt_Rec0 = "" Then Exit Sub

        Dim Form As New FrmVOD_XLKN_User
        Form.Mode = ""
        Form.Para = Me.Para
        Form.Sysvar = Me.Sysvar
        Form.M_LAN = Me.M_LAN
        Form.M_User_Name = M_User_Name
        Form.M_Ma_Dvcs = M_Ma_Dvcs
        Form.Para = Me.Para
        Form.AppConn = AppConn
        Form.Sysvar = Me.Sysvar
        Form.Stt_rec = xStt_Rec
        Form.Stt_rec0 = xStt_Rec0
        Form.Ma_Hs_PT = Ma_Hs_PT
        Form.Ten_Hs_PT = Ten_Hs_PT
        Form.Row = drRowEdit
        Form.ShowDialog()
        For i As Integer = 0 To dtMaster.Rows.Count - 1
            If dtMaster.Rows(i).Item("Stt_Rec").ToString = xStt_Rec And dtMaster.Rows(i).Item("Stt_Rec0").ToString = xStt_Rec0 Then
                dtMaster.Rows(i).BeginEdit()
                dtMaster.Rows(i).Item("Ma_Hs_PT") = Form.Ma_Hs_PT
                dtMaster.Rows(i).Item("Ten_Hs_PT") = Form.Ten_Hs_PT
                dtMaster.Rows(i).EndEdit()
                dtMaster.AcceptChanges()
                Exit For
            End If
        Next
    End Sub
#End Region
    Private Sub V_FillDataToGridview(ByVal GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal DvHeader As DataView, ByVal DvData As DataView)
        GRV.OptionsBehavior.Editable = True
        CyberFill.V_FillReports(GRV, _M_lan, DvHeader, DvData)
        GRV.GridControl.DataSource = DvData
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#Region "Leave"

    Private Sub btnLoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabase("0")
    End Sub
    Dim CyberColor As New Cyber.Color.Sys
#End Region
#Region "Support"
    Private Sub EnterasTab(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
#End Region
End Class
