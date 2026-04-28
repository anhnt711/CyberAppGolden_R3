Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing

Public Class FrmXacNhan
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet
    Dim DrReturn As DataRow
    Dim DtPost1, DtPost2, DtDvcs As New DataTable
    Dim DsLookup As DataSet
    '----
    Dim M_Loai_Xn As String = ""
    Dim M_Ma_TT As String = "C"
    Dim M_Ma As String = "", M_Ten As String = "", M_Dmuc As String = "", M_Filt As String = ""
    Dim M_So_ro As String = ""
    '----

    Dim dt_Master, dt_Header, dtTotalBv, dtTotalHeader As New DataTable
    Dim dv_Master, dv_Header, vdtTotalBv, vdtTotalHeader As New DataView
    Dim EditBut_Ctrl, EditBut_HLenh, EditBut_TL As New Cyber.Fill.CyberColumnGridView
    '----
    Dim ProccessList As New Collection
#End Region
    Dim M_ma_TTCP As String = ""
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub FrmXacNhan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        '------------------------------------------------------------------------------------
        V_Load()
        '------------------------------------------------------------------------------------
        M_ma_TTCP = CyberSupport.V_GetDefault_TTCP("HDK", M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        '------------------------------------------------------------------------------------
        V_AddHanderl()
        '------------------------------------------------------------------------------------
        If M_So_ro <> "" Then
            txtSo_Ro.Text = M_So_ro
            L_Lenh_Ro(sender, e)
        End If
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        TxtNgay_ct1.Value = Now.Date
        TxtNgay_ct2.Value = Now.Date.AddHours(23).AddMinutes(59)
        M_Loai_Xn = Me.Para(M_VT_PARA + 2).Trim
        M_So_ro = Me.Para(M_VT_PARA + 3).Trim

        SetVisible()
        V_LoadDatabase("1", "")
        V_FillDataToGridview(MasterGRV, M_LAN, dv_Header, dv_Master)
        V_Menu(MasterGRV, AddressOf V_EditVoucherRo)

        Dim tbDmTT = CyberSmodb.OpenTableKey(AppConn, Nothing, "DMTT", "Ma_TT", "(1=1)", CyberSmlib)
        CyberFill.V_FillComBoxValue(CbBMa_TT, tbDmTT, "Ma_TT", "Ten_TT", M_Ma_TT)
    End Sub
    Sub SetVisible()
        lblQC.Visible = False
        ChkQC1.Enabled = False
        ChkQC1.Visible = False
        ChkQC2.Enabled = False
        ChkQC2.Visible = False
        ChkQC3.Enabled = False
        ChkQC3.Visible = False
        lblCoupon.Visible = False
        txtCoupon.Enabled = False
        txtCoupon.Visible = False

        lblMa.Visible = False
        TxtMa.Visible = False
        TxtTen.Visible = False

        CbBMa_TT.Visible = False
        CbBMa_TT.Enabled = False

        lblLoai_ct.Visible = False
        lblLoai_ct.Enabled = False

        TxtMa_Kh.Visible = False
        TxtTen_kh.Visible = False

        LabeMa_Bp.Visible = False
        TxtMa_Bp.Visible = False
        txtTen_BP.Visible = False
       
        TxtT_C.Enabled = False
       
        Select Case M_Loai_Xn
            Case "QC"

                lblQC.Visible = True
                ChkQC1.Enabled = True
                ChkQC1.Visible = True

                ChkQC2.Enabled = True
                ChkQC2.Visible = True

                ChkQC3.Enabled = True
                ChkQC3.Visible = True

                LabGt_XN.Visible = False
                TxtTien.Visible = False
            Case "COUPON"
                lblCoupon.Visible = True
                txtCoupon.Enabled = True
                txtCoupon.Visible = True
                'CbBMa_TT.Visible = True
                'CbBMa_TT.Enabled = True
                lblMa.Text = "Đối tượng"
                lblMa.Visible = True
                TxtMa_Kh.Visible = True
                TxtTen_kh.Visible = True

                LabeMa_Bp.Visible = True
                TxtMa_Bp.Visible = True
                txtTen_BP.Visible = True

                TxtT_C.Visible = True
                TxtT_C.ReadOnly = True
            Case "I"
                lblMa.Text = "Bảo hiểm"
                lblMa.Visible = True
                TxtMa.Visible = True
                TxtTen.Visible = True
            Case "SCL"
                lblMa.Text = "Mã lỗi"
                lblMa.Visible = True
                TxtMa.Visible = True
                TxtTen.Visible = True
        End Select

    End Sub
    Private Sub V_AddHanderl()
        AddHandler txtSo_Ro.KeyDown, AddressOf EnterasTab
        AddHandler txtGhi_chu.KeyDown, AddressOf EnterasTab
        AddHandler txtCoupon.KeyDown, AddressOf EnterasTab
        AddHandler TxtNgay_ct2.KeyDown, AddressOf EnterasTab
        AddHandler TxtNgay_ct2.KeyDown, AddressOf EnterasTab
        AddHandler TxtTien.KeyDown, AddressOf EnterasTab
        '---------------------------------------------------------------------------------------------
        AddHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler CmdSearch.Click, AddressOf V_Search
        AddHandler btnXac_nhan.Click, AddressOf V_Save
        AddHandler btnChi_tiet.Click, AddressOf V_DetailVoucher
        AddHandler txtSo_Ro.Leave, AddressOf L_Lenh_Ro

        AddHandler TxtMa.CyberValiting, AddressOf V_Ma_Tmp
        AddHandler TxtMa.CyberLeave, AddressOf L_Ma_Tmp
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_BP
    End Sub
    Private Sub V_Menu(ByVal DetailGRVVt As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Events As EventHandler)
        Dim mnItems = New ContextMenu
        Dim mnItemsF8 As New MenuItem("Xóa xác nhận", AddressOf V_Delete, Keys.F8)
        mnItems.MenuItems.Add(mnItemsF8)
        DetailGRVVt.GridControl.ContextMenu = mnItems
    End Sub
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabase("0", TxtSo_Ro_Loc.Text.Trim)
    End Sub
    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterGRV, dt_Master, Me.Font)
    End Sub
#Region "Edit voucher"
    Private Sub V_EditVoucherRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberFill.V_EditVoucher(M_LAN, Me.Para, Me.Sysvar, AppConn, MasterGRV)
    End Sub
#End Region
#Region "Data"
    Private Sub V_LoadDatabase(ByVal Status As String, ByVal _So_Ro As String)
        Dim Dt1 As Date, Dt2 As Date
        Dt1 = TxtNgay_ct1.Value
        Dt2 = TxtNgay_ct2.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RoXacNhanLenh_Load", Status & "#" & M_Loai_Xn & "#" & _So_Ro & "#" & Dt1.ToString("yyyyMMdd HH:mm").Trim & "#" & Dt2.ToString("yyyyMMdd HH:mm").Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name.Trim)
        If Status = "1" Then
            dt_Master = DsTmp.Tables(0).Copy
            dt_Header = DsTmp.Tables(2).Copy
            dv_Master = New DataView(dt_Master)
            dv_Header = New DataView(dt_Header)
            If DsTmp.Tables(1).Columns.Contains("Caption") Then lblMa.Text = DsTmp.Tables(1).Rows(0).Item("Caption").ToString.Trim
            If DsTmp.Tables(1).Columns.Contains("Ma") Then M_Ma = DsTmp.Tables(1).Rows(0).Item("Ma").ToString.Trim
            If DsTmp.Tables(1).Columns.Contains("Ten") Then M_Ten = DsTmp.Tables(1).Rows(0).Item("Ten").ToString.Trim
            If DsTmp.Tables(1).Columns.Contains("Danh_muc") Then M_Dmuc = DsTmp.Tables(1).Rows(0).Item("Danh_muc").ToString.Trim
            DsTmp.Dispose()
            Exit Sub
        End If
        '-------------------------------------------------------------------------
        dt_Master.Clear()
        dt_Master.Load(DsTmp.Tables(0).CreateDataReader)
        DsTmp.Dispose()
    End Sub
    Private Sub V_BilldtingRo(ByVal MasterGRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal Dv_Master As DataView, ByVal Dv_DetailTmp As DataView)
        If MasterGRV.GetFocusedRow Is Nothing Then Exit Sub
        If Not Dv_DetailTmp.Table.Columns.Contains("stt_rec") Then Exit Sub
        If Not Dv_Master.Table.Columns.Contains("stt_rec") Then Exit Sub
        If Dv_Master.Table.Rows.Count < 1 Then Exit Sub
        If Dv_Master.Table.Columns.Count < 1 Then Exit Sub
        Dim filter As String = "1=1"
        Dim selectedRow As DataRowView = Nothing
        Try
            selectedRow = MasterGRV.GetFocusedRow
            If (Not String.IsNullOrEmpty(selectedRow("stt_rec").ToString)) Then
                filter = "stt_rec='" + selectedRow("stt_rec").ToString() + "'"
                Dv_DetailTmp.RowFilter = filter
            End If
        Catch ex As Exception
            Dv_DetailTmp.RowFilter = "1=0"
        End Try
    End Sub
#End Region
    Private Sub V_FillDataToGridview(ByVal GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal dv_Header As DataView, ByVal DvData As DataView)
        GRV.OptionsBehavior.Editable = True
        CyberFill.V_FillReports(GRV, _M_lan, dv_Header, DvData)
        GRV.GridControl.DataSource = DvData
        'GRV.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect

        For Each dc As DevExpress.XtraGrid.Columns.GridColumn In MasterGRV.Columns
            dc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False
        Next
    End Sub
    Private Sub V_Save(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtSo_Ro.Text = "" Then Exit Sub
        Dim strFiled = "", strValues As String = "", nCount As Integer = 0, nKey As Integer = 0
        Dim Dt1 As Date, Dt2 As Date
        Dt1 = TxtNgay_ct1.Value
        Dt2 = TxtNgay_ct2.Value

        CyberSmodb.GetValueControler(Me, strFiled, strValues, "")

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RoXacNhanLenh_Save", txtSo_Ro.Text.Trim & "#" & M_Loai_Xn.Trim & "#" & strFiled.Trim & "#" & strValues.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name)
        nCount = DsTmp.Tables.Count
        If nCount < 1 Then
            DsTmp.Dispose()
            Return
        End If

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Return
        End If

        If nCount < 2 Then
            DsTmp.Dispose()
            Return
        End If

        If Not DsTmp.Tables(1).Columns.Contains("So_Ro") Then
            DsTmp.Dispose()
            Return
        End If


        For i As Integer = 0 To dt_Master.Rows.Count - 1
            If dt_Master.Rows(i).Item("So_Ro").ToString = DsTmp.Tables(1).Rows(0).Item("So_Ro").ToString Then
                dt_Master.Rows(i).Delete()
            End If
        Next

        dt_Master.ImportRow(DsTmp.Tables(1).Rows(0))

        dt_Master.AcceptChanges()
        DsTmp.Dispose()
        '--------------------------------------------------------------------
        txtSo_Ro.Text = ""
        txtMa_xe.Text = ""
        txtGhi_chu.Text = ""
        txtCoupon.Text = ""
        TxtTien.Double = 0
        ChkQC1.Checked = False
        ChkQC2.Checked = False
        ChkQC3.Checked = False
    End Sub
    Private Sub V_Delete(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If dt_Master.Rows.Count = 0 Then Exit Sub
        Dim iRow As Integer = MasterGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        Dim So_Ro As String = ""
        So_Ro = dt_Master.Rows(iRow).Item("So_Ro").ToString
        If So_Ro = "" Then Exit Sub
        Dim nCount As Integer = 0
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RoXacNhanLenh_Del", So_Ro & "#" & M_Loai_Xn.Trim & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name)
        nCount = DsTmp.Tables.Count
        If nCount < 1 Then
            DsTmp.Dispose()
            Return
        End If

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Return
        End If

        For i As Integer = 0 To dt_Master.Rows.Count - 1
            If dt_Master.Rows(i).Item("So_Ro").ToString = So_Ro Then
                dt_Master.Rows(i).Delete()
            End If
        Next
        dt_Master.AcceptChanges()

    End Sub
    Private Sub V_DetailVoucher(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtSo_Ro.Text.Trim = "" Or txtStt_rec.Text.Trim = "" Then Exit Sub
        Dim _Stt_rec As String = txtStt_rec.Text.Trim
        If _Stt_rec = "" Then Exit Sub
        Dim strAddParar As String = "S#HDK###24#C#" + _Stt_rec
        Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Input.dll", Me.Para, strAddParar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
    Private Sub EnterasTab(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
#Region "Valid"
    Private Sub L_Lenh_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtSo_Ro.Text = "" Then Exit Sub
        Dim _Dt As Date = Now.Date
        'txtSo_Ro.Text = CyberVoucher.V_GetSo_Ro("HDK", "S", "M", _Dt, txtSo_Ro.Text, M_Ma_Dvcs)
        txtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, "HDK", "S", "M", _Dt, txtSo_Ro.Text, M_ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        GetDetail()
    End Sub
    Private Sub GetDetail()
        If txtSo_Ro.Text = "" Then Exit Sub
        Dim DsTmpDetal As New DataSet
        Dim nCountTb As Integer
        DsTmpDetal = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RoXacNhanLenh_Get_Ro", txtSo_Ro.Text.Trim & "#" & M_Loai_Xn & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name)

        nCountTb = DsTmpDetal.Tables.Count
        For i = 0 To nCountTb - 1
            CyberSmodb.SetNotNullTable(DsTmpDetal.Tables(i))
        Next

        If DsTmpDetal.Tables(0).Rows.Count < 1 Then
            DsTmpDetal.Dispose()
            Exit Sub
        End If

        If DsTmpDetal.Tables(0).Rows(0).Item("Status").ToString.Trim = "N" Then
            If DsTmpDetal.Tables(0).Rows(0).Item("Msg").ToString.Trim = "Y" Then
                MsgBox(DsTmpDetal.Tables(0).Rows(0).Item("Note").ToString.Trim, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_Cyber_Ver"))
            End If
            DsTmpDetal.Dispose()
            Exit Sub
        End If

        If DsTmpDetal.Tables(0).Columns.Contains("Tien") Then TxtTien.Double = DsTmpDetal.Tables(0).Rows(0).Item("Tien")
        If DsTmpDetal.Tables(0).Columns.Contains("T_TT") Then TxtT_TT.Double = DsTmpDetal.Tables(0).Rows(0).Item("T_TT")
        If DsTmpDetal.Tables(0).Columns.Contains("T_C") Then TxtT_C.Double = DsTmpDetal.Tables(0).Rows(0).Item("T_C")
        If DsTmpDetal.Tables(0).Columns.Contains("Ma_xe") Then txtMa_xe.Text = DsTmpDetal.Tables(0).Rows(0).Item("Ma_xe")
        If DsTmpDetal.Tables(0).Columns.Contains("Ghi_chu") Then txtGhi_chu.Text = DsTmpDetal.Tables(0).Rows(0).Item("Ghi_chu")
        If DsTmpDetal.Tables(0).Columns.Contains("Coupon") Then txtCoupon.Text = DsTmpDetal.Tables(0).Rows(0).Item("Coupon")
        If DsTmpDetal.Tables(0).Columns.Contains("Stt_rec") Then txtStt_rec.Text = DsTmpDetal.Tables(0).Rows(0).Item("Stt_rec")

        If DsTmpDetal.Tables(0).Columns.Contains("Ma") Then TxtMa.Text = DsTmpDetal.Tables(0).Rows(0).Item("Ma")
        If DsTmpDetal.Tables(0).Columns.Contains("Ten") Then TxtTen.Text = DsTmpDetal.Tables(0).Rows(0).Item("ten")
        If DsTmpDetal.Tables(0).Columns.Contains("Ma_kh") Then TxtMa_Kh.Text = DsTmpDetal.Tables(0).Rows(0).Item("Ma_kh")
        If DsTmpDetal.Tables(0).Columns.Contains("Ten_kh") Then TxtTen_kh.Text = DsTmpDetal.Tables(0).Rows(0).Item("Ten_kh")
        If DsTmpDetal.Tables(0).Columns.Contains("Ma_bp") Then TxtMa_Bp.Text = DsTmpDetal.Tables(0).Rows(0).Item("Ma_bp")
        If DsTmpDetal.Tables(0).Columns.Contains("Ten_bp") Then txtTen_BP.Text = DsTmpDetal.Tables(0).Rows(0).Item("Ten_bp")

        If DsTmpDetal.Tables(0).Columns.Contains("QC1") Then ChkQC1.Checked = (DsTmpDetal.Tables(0).Rows(0).Item("QC1").ToString = "1")
        If DsTmpDetal.Tables(0).Columns.Contains("QC2") Then ChkQC2.Checked = (DsTmpDetal.Tables(0).Rows(0).Item("QC2").ToString = "1")
        If DsTmpDetal.Tables(0).Columns.Contains("QC3") Then ChkQC3.Checked = (DsTmpDetal.Tables(0).Rows(0).Item("QC3").ToString = "1")
        If DsTmpDetal.Tables(0).Columns.Contains("Trang_Thai") Then lblTrang_Thai.Text = DsTmpDetal.Tables(0).Rows(0).Item("Trang_Thai")
        If DsTmpDetal.Tables(0).Columns.Contains("Color") Then lblTrang_Thai.ForeColor = CyberColor.GetForeColor(DsTmpDetal.Tables(0).Rows(0).Item("Color"))

        DsTmpDetal.Dispose()
    End Sub
    Private Sub V_Ma_Tmp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa.V_LookUp(M_LAN, Para, Sysvar, AppConn, DsLookup, IIf(M_Ma.Trim <> "", M_Ma.Trim, "Ma_Tuyen"), IIf(M_Dmuc.Trim <> "", M_Dmuc.Trim, "DmTuyen"), "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Tmp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa.Text = "" Then
            TxtTen.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa.Text = DrReturn.Item(IIf(M_Ma.Trim <> "", M_Ma.Trim, "Ma_Tuyen"))
            TxtTen.Text = DrReturn.Item(IIf(M_Ten.Trim <> "", M_Ten.Trim, "Ten_Tuyen"))
        Else
            TxtMa.Text = ""
            TxtTen.Text = ""
        End If
    End Sub
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kh.V_LookUp(M_LAN, Para, Sysvar, AppConn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)

        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn("Ma_kh").ToString.Trim
            If DrReturn("ten_kh").ToString.Trim <> "" Then TxtTen_kh.Text = DrReturn("ten_kh").ToString.Trim
        Else
            TxtMa_Kh.Text = ""
            TxtTen_kh.Text = ""
        End If
    End Sub
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bp.V_LookUp(M_LAN, Para, Sysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        DrReturn = TxtMa_Bp.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp.Text = DrReturn.Item("Ma_BP")
            txtTen_BP.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_Bp.Text = ""
            txtTen_BP.Text = ""
        End If
    End Sub
#End Region
End Class

