Imports DevExpress.XtraScheduler
Imports System.Drawing
Imports DevExpress.Utils
Imports System.Windows.Forms

Public Class FrmXac_Nhan
#Region "AddProperty"
#End Region
#Region "Biến"
    Dim CyberWork As New Sys
    Dim CyberColor As New Cyber.Color.Sys
    Dim M_Loai_SC As String = "1" '-------1 : Xác nhận theo RO/ 2 - Xác nhận RO chi tiết theo từng KTV
    Dim Dt_Data, Dt_Head As DataTable
    Dim Dv_Data, Dv_Head As DataView
    Dim M_Kieu_XN As String = "1" ' 1: Xác nhận theo R/O; 2: Xác nhận theo R/O chi tiết theo KTV
    Dim M_Is_Max As String = "0"
    Dim EditTag, EditSo_Ro, EditNgay_BD_TH, EditNgay_KT_TH As New Cyber.Fill.CyberColumnGridView
    Dim M_Is_tag As Boolean = False
    Dim M_Ma_TTCP As String = ""
#End Region
    Private Sub FrmXac_Nhan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Loai_SC = Me.Para(M_VT_PARA + 2)
        TxtBarCode.Text = ""
        Dim _Barcode As String = TxtBarCode.Text
        '---------------------------------------------------------------------------------------------------------------------------------------
        M_Ma_TTCP = CyberSupport.V_GetDefault_TTCP("PKH", M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        '---------------------------------------------------------------------------------------------------------------------------------------
        V_LoadDatabases("1", _Barcode, "", "", "", "", "", "", "", "")
        '---------------------------------------------------------------------------------------------------------------------------------------
        V_AddHander()
        '---------------------------------------------------------------------------------------------------------------------------------------
        If M_Is_Max = "1" Then Me.WindowState = FormWindowState.Maximized
        '---------------------------------------------------------------------------------------------------------------------------------------
        Me.Save_OK = False
        TxtBarCode.SelectAll()
        TxtBarCode.Focus()
    End Sub
    Private Sub V_LoadDatabases(ByVal status As String, ByVal _Barcode As String, ByVal _Ma_Get As String, ByVal _So_Ro As String, ByVal _Stt_rec_Ro As String, ByVal _Stt_rec As String, ByVal _Ma_KTV As String, ByVal _Ma_Cv As String, ByVal _Ma_CD As String, ByVal _Stt_Rec0_Ro As String)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_XN_Get", status + "#" + M_Loai_SC + "#" + _Barcode + "#" + _Ma_Get + "#" + _
                                                                   _So_Ro + "#" + _Stt_rec_Ro + "#" + _Stt_rec + "#" + _Ma_KTV + "#" + _Ma_Cv + "#" + _Ma_CD + "#" + _Stt_Rec0_Ro + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If status = "1" Then
            LabBarcode.Text = Dstmp.Tables(0).Rows(0).Item("LabBarcode").ToString.Trim
            M_Kieu_XN = Dstmp.Tables(0).Rows(0).Item("Kieu_XN").ToString.Trim
            M_Is_Max = Dstmp.Tables(0).Rows(0).Item("Is_Max").ToString.Trim

            Dt_Data = Dstmp.Tables(1).Copy
            Dt_Head = Dstmp.Tables(2).Copy
            Dv_Data = New DataView(Dt_Data)
            Dv_Head = New DataView(Dt_Head)
            CyberSupport.V_SetSortView(Dv_Data, Dstmp.Tables(0))

            Master.DataSource = Dv_Data
            Me.MasterGRV.GridControl = Me.Master
            CyberFill.V_FillReports(MasterGRV, M_LAN, Dv_Head, Dv_Data)
            MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
            MasterGRV.OptionsSelection.MultiSelect = True
            If Dt_Data.Columns.Contains("Tag") And Dt_Head.Select("Field_Name = 'Tag'").Length > 0 Then M_Is_tag = True

            Dim _ColFrozen As Integer = -1
            If Dstmp.Tables(0).Columns.Contains("ColFrozen") Then _ColFrozen = Dstmp.Tables(0).Rows(0).Item("ColFrozen")

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

        Else
            If _Ma_Get.Trim = "" Then
                TxtBarcodeName.Text = Dstmp.Tables(0).Rows(0).Item("BarcodeName").ToString.Trim
                TxtBarCode.Text = Dstmp.Tables(0).Rows(0).Item("Barcode").ToString.Trim
                Dt_Data.Clear()
            Else
                Dim nCount As Integer = Dt_Data.Rows.Count - 1
                For i As Integer = nCount To 0 Step -1
                    If Dt_Data.Rows(i).Item("Ma_Get").ToString.Trim = _Ma_Get Then
                        Dt_Data.Rows(i).Delete()
                        Exit For
                    End If
                Next
            End If
            Dt_Data.AcceptChanges()
            Dt_Data.Load(Dstmp.Tables(1).CreateDataReader)
        End If
        Dstmp.Dispose()
    End Sub
    Private Sub V_BarCode(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Barcode As String = TxtBarCode.Text.ToString.Trim
        If _Barcode.Trim = "" Then
            TxtBarcodeName.Text = ""
            Dt_Data.Clear()
            Dt_Data.AcceptChanges()
            TxtBarCode.SelectAll()
            Return
        End If
        If M_Kieu_XN.Trim = "1" Then
            Dim _Dt As DateTime = Now.Date
            TxtBarCode.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Me.Sysvar, "HDK", "S", "M", _Dt, TxtBarCode.Text, M_Ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        End If
        _Barcode = TxtBarCode.Text.ToString.Trim
        V_LoadDatabases("0", _Barcode, "", "", "", "", "", "", "", "")
        TxtBarCode.SelectAll()
    End Sub
    Private Sub V_Tao_Moi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtBarCode.Text = ""
        V_BarCode(New System.Object, New System.EventArgs)
        TxtBarCode.SelectAll()
        TxtBarCode.Focus()
    End Sub
    Private Sub V_Sua_Thoi_Gian(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Barcode As String = TxtBarCode.Text.ToString.Trim
        If _Barcode.Trim = "" Then Return

        Dim _Xml As String = V_GetValue(iRow)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_XN_F3_Load", M_Kieu_XN + "#" + M_Loai_SC + "#" + _Barcode + "#" + _Xml + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        If Dstmp.Tables.Count = 0 Then Return
        If Dstmp.Tables(0).Rows.Count = 0 Then Return
        Dim _Dr As DataRow = Dstmp.Tables(0).Copy.Rows(0)
        Dim Frm As New FrmXac_Nhan_F3
        Frm.M_Dr = _Dr
        'Frm.Dr = _Dr
        Frm.Lan = M_LAN
        Frm.Para = Me.Para
        Frm.Sysvar = Me.Sysvar
        Frm.AppConn = AppConn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = Nothing
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()
        If Not Frm.Save_OK Then Return

        Dim _StrNgay_BD_TH As String = Frm.Key_Sub1.ToString.Trim
        Dim _StrNgay_KT_TH As String = Frm.Key_Sub2.ToString.Trim

        Dim DstmpSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_XN_F3_Save", _StrNgay_BD_TH + "#" + _StrNgay_KT_TH + "#" + M_Kieu_XN + "#" + M_Loai_SC + "#" + _Barcode + "#" + _Xml + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DstmpSave.Tables(0), Sysvar, M_LAN) Then Return
        V_LoadDatabases("0", _Barcode, "", "", "", "", "", "", "", "")

    End Sub
    Private Function V_Thuc_Hien(ByVal _Xml As String) As Boolean
        Dim _Barcode As String = TxtBarCode.Text.ToString.Trim
        If _Barcode.Trim = "" Then
            Dt_Data.Clear()
            Dt_Data.AcceptChanges()
            Return False
        End If
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_XN_Thuc_Hien", M_Kieu_XN + "#" + M_Loai_SC + "#" + _Barcode + "#" + _Xml + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim _Return As Boolean = CyberSupport.V_MsgChk(Dstmp.Tables(0), Sysvar, M_LAN)

        If _Return Then
            Dim _Ma_Get As String = ""
            Dim _So_Ro As String = ""
            Dim _Stt_Rec_Ro As String = ""
            Dim _Stt_Rec As String = ""
            Dim _Ma_KTV As String = ""
            Dim _Ma_CV As String = ""
            Dim _Ma_CD As String = ""
            Dim _Stt_Rec0_Ro As String = ""
            Dim _Dt As DataTable = Dstmp.Tables(1).Copy
            For iRow As Integer = 0 To _Dt.Rows.Count - 1

                If _Dt.Columns.Contains("Ma_Get") Then _Ma_Get = _Dt.Rows(iRow).Item("Ma_Get").ToString.Trim
                If _Dt.Columns.Contains("So_Ro") Then _So_Ro = _Dt.Rows(iRow).Item("So_Ro").ToString.Trim
                If _Dt.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = _Dt.Rows(iRow).Item("Stt_Rec_Ro").ToString.Trim
                If _Dt.Columns.Contains("Stt_Rec") Then _Stt_Rec = _Dt.Rows(iRow).Item("Stt_Rec").ToString.Trim
                If _Dt.Columns.Contains("Ma_KTV") Then _Ma_KTV = _Dt.Rows(iRow).Item("Ma_KTV").ToString.Trim
                If _Dt.Columns.Contains("Ma_CV") Then _Ma_CV = _Dt.Rows(iRow).Item("Ma_CV").ToString.Trim
                If _Dt.Columns.Contains("Ma_CD") Then _Ma_CD = _Dt.Rows(iRow).Item("Ma_CD").ToString.Trim
                If _Dt.Columns.Contains("Stt_Rec0_Ro") Then _Stt_Rec0_Ro = _Dt.Rows(iRow).Item("Stt_Rec0_Ro").ToString.Trim

                V_LoadDatabases("0", _Barcode, _Ma_Get, _So_Ro, _Stt_Rec_Ro, _Stt_Rec, _Ma_KTV, _Ma_CV, _Ma_CD, _Stt_Rec0_Ro)
            Next
        End If
        Return _Return
    End Function
    Private Sub V_Thuc_Hien(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Xml As String = V_GetValue(iRow)
        V_Thuc_Hien(_Xml)
    End Sub

    Private Sub V_Thuc_Hien_All(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not M_Is_tag Then Return
        If Dt_Data.Select("Tag = '1'").Length = 0 Then
            MsgBox("Bạn chưa chọn chíp thực hiện bắt đầu hoặc kết thúc", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            TxtBarCode.SelectAll()
            TxtBarCode.Focus()
            Return
        End If

        Dim _XML As String = ""
        For iRow As Integer = 0 To Dv_Data.Count - 1
            If Not Dv_Data.Item(iRow).Item("tag").ToString.Trim = "1" Then Continue For
            If Not _XML.Trim = "" Then _XML = _XML + ";"
            _XML = _XML + V_GetValue(iRow)
        Next

        If V_Thuc_Hien(_XML) Then V_RemoveAll(New System.Object, New System.EventArgs)
        TxtBarCode.SelectAll()
        TxtBarCode.Focus()
    End Sub
    Private Function V_GetValue(ByVal iRow As Integer) As String
        Dim _Return As String = ""
        Dim _Ma_Get As String = ""
        Dim _So_Ro As String = ""
        Dim _Stt_Rec_Ro As String = ""
        Dim _Stt_Rec As String = ""
        Dim _Ma_KTV As String = ""
        Dim _Ma_CV As String = ""
        Dim _Ma_CD As String = ""
        Dim _Stt_Rec0_Ro As String = ""
        If Dt_Data.Columns.Contains("Ma_Get") Then _Ma_Get = Dv_Data.Item(iRow).Item("Ma_Get").ToString.Trim
        If Dt_Data.Columns.Contains("So_Ro") Then _So_Ro = Dv_Data.Item(iRow).Item("So_Ro").ToString.Trim
        If Dt_Data.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Data.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim
        If Dt_Data.Columns.Contains("Stt_Rec") Then _Stt_Rec = Dv_Data.Item(iRow).Item("Stt_Rec").ToString.Trim
        If Dt_Data.Columns.Contains("Ma_KTV") Then _Ma_KTV = Dv_Data.Item(iRow).Item("Ma_KTV").ToString.Trim
        If Dt_Data.Columns.Contains("Ma_CV") Then _Ma_CV = Dv_Data.Item(iRow).Item("Ma_CV").ToString.Trim
        If Dt_Data.Columns.Contains("Ma_CD") Then _Ma_CD = Dv_Data.Item(iRow).Item("Ma_CD").ToString.Trim
        If Dt_Data.Columns.Contains("Stt_Rec0_Ro") Then _Stt_Rec0_Ro = Dv_Data.Item(iRow).Item("Stt_Rec0_Ro").ToString.Trim

        _Return = "INSERT THUCHIEN SELECT N'" + _Ma_Get + "',N'" + _So_Ro + "',N'" + _Stt_Rec_Ro + "',N'" + _Stt_Rec + "',N'" + _Ma_KTV + "',N'" + _Ma_CV + "',N'" + _Ma_CD + "',N'" + _Stt_Rec0_Ro + "'"

        Return _Return
    End Function
    Private Sub V_CLICK_Tag(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MasterGRV.PostEditor()
        MasterGRV.UpdateCurrentRow()
        Dim iRow As Integer = MasterGRV.GetFocusedDataSourceRowIndex
        Dt_Data.AcceptChanges()
    End Sub
#Region "System"
    Private Sub V_AddHander()

        EditTag.GetColumn(MasterGRV, "TAG")
        EditSo_Ro.GetColumn(MasterGRV, "So_Ro")
        EditNgay_BD_TH.GetColumn(MasterGRV, "Ngay_BD_TH")
        EditNgay_KT_TH.GetColumn(MasterGRV, "Ngay_KT_TH")

        AddHandler CmdXac_Nhan.Click, AddressOf V_Thuc_Hien_All
        AddHandler CmdTao_Moi.Click, AddressOf V_Tao_Moi
        AddHandler CmdQuay_ra.Click, AddressOf V_Quay_Ra
        'AddHandler CmdRO_CVDV_XN.Click, AddressOf V_RO_CVDV_XN
        'AddHandler CmdViewGannt.Click, AddressOf V_View_Gantt

        AddHandler TxtBarCode.Leave, AddressOf V_BarCode
        AddHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing

        'If Not EditTag.Column Is Nothing Then AddHandler EditTag.EditColumn.Click, AddressOf V_CLICK_Tag
        'If Not EditTag.Column Is Nothing Then AddHandler EditTag.EditColumn.Leave, AddressOf V_CLICK_Tag
        If Not EditTag.Column Is Nothing Then AddHandler EditTag.EditColumn.EditValueChanged, AddressOf V_CLICK_Tag

        If Not EditSo_Ro.Column Is Nothing Then AddHandler EditSo_Ro.EditColumn.Click, AddressOf V_Thuc_Hien
        If Not EditNgay_BD_TH.Column Is Nothing Then AddHandler EditNgay_BD_TH.EditColumn.Click, AddressOf V_Thuc_Hien
        If Not EditNgay_KT_TH.Column Is Nothing Then AddHandler EditNgay_KT_TH.EditColumn.Click, AddressOf V_Thuc_Hien
    End Sub
    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterGRV, Dt_Data, Me.Font, "Tag", "backColor", "backColor2", "ForeColor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuMasterGRV.ItemLinks.Clear()

        If M_Is_tag Then PopupMenuMasterGRV.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, "Thực hiện (BĐ/KT) theo chọn", AddressOf V_Thuc_Hien_All, Nothing, My.Resources.apply_16x16, True, True)).BeginGroup = False

        PopupMenuMasterGRV.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, "Điểu chỉnh thời gian", AddressOf V_Sua_Thoi_Gian, Nothing, My.Resources.edit_16x16, True, True)).BeginGroup = False

        PopupMenuMasterGRV.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn tất", "Select All"), AddressOf V_SelectAll, Shortcut.CtrlA, Nothing, True, True)).BeginGroup = True
        PopupMenuMasterGRV.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gỡ chọn", "Remove All"), AddressOf V_RemoveAll, Shortcut.CtrlU, Nothing, True, True)).BeginGroup = False
        Dim MenuExits As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)

        PopupMenuMasterGRV.ItemLinks.Add(MenuExits, True)
        PopupMenuMasterGRV.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGRV.ShowPopup(Control.MousePosition)
        'End If
    End Sub
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dv_Data.Count - 1
            If Dt_Data.Columns.Contains("Tag") Then
                Dv_Data.Item(i).BeginEdit()
                Dv_Data.Item(i).Item("Tag") = "1"
                Dv_Data.Item(i).EndEdit()
                MasterGRV.UpdateCurrentRow()
            End If
        Next
        Dt_Data.AcceptChanges()
        MasterGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i As Integer = 0 To Dv_Data.Count - 1
            If Dt_Data.Columns.Contains("Tag") Then
                Dv_Data.Item(i).BeginEdit()
                Dv_Data.Item(i).Item("Tag") = "0"
                Dv_Data.Item(i).EndEdit()
                MasterGRV.UpdateCurrentRow()
            End If
        Next
        Dt_Data.AcceptChanges()
        MasterGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Me.Close()
    End Sub
    Private Sub V_Quay_Ra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Me.Close()
    End Sub
#End Region
End Class
