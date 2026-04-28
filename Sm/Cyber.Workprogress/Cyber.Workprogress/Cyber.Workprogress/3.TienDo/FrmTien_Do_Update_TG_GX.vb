Imports System.Windows.Forms
Imports System.Drawing

Public Class FrmTien_Do_Update_TG_GX
    Public M_Dr_Return As DataRow
    Dim CyberColor As New Cyber.Color.Sys
    Dim CyberWork As New Sys
    Dim M_Stt_Rec_RO As String = ""
    Dim M_Loai_SC As String = "1"
    Dim M_Kieu_Xem As String = "HEN"
    Dim M_Ma_TTCP As String = ""
    Public Property Ma_TTCP() As String
        Get
            Ma_TTCP = M_Ma_TTCP
        End Get
        Set(ByVal Value As String)
            M_Ma_TTCP = Value
        End Set
    End Property
    Public Property Kieu_Xem As String
        Get
            Kieu_Xem = M_Kieu_Xem
        End Get
        Set(ByVal Value As String)
            M_Kieu_Xem = Value
        End Set
    End Property
    Public Property Loai_SC() As String
        Get
            Loai_SC = M_Loai_SC
        End Get
        Set(ByVal Value As String)
            M_Loai_SC = Value
        End Set
    End Property
    Public Property Stt_rec_Ro() As String
        Get
            Stt_rec_Ro = M_Stt_Rec_RO
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec_RO = Value
        End Set
    End Property
    Dim M_So_RO As String = ""
    Public Property So_RO() As String
        Get
            So_RO = M_So_RO
        End Get
        Set(ByVal Value As String)
            M_So_RO = Value
        End Set
    End Property
    Private Sub FrmTien_Do_Update_TG_GX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtStt_Rec_Ro.Text = M_Stt_Rec_RO
        TxtSo_Ro.Text = M_So_RO
        V_LoadDatabase("1")
        V_Load()
        V_AddHander()
        Me.Text = "CẬP NHẬP THỜI GIAN GIAO XE"
        '------------------------------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '------------------------------------------------------------------------------------------------------------------

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()

    End Sub
    Private Sub V_AddHander()

        RemoveHandler CmdUp_TG_GX_KH_SCC.Click, AddressOf V_Update_Lenh
        RemoveHandler TxtSo_Ro.Leave, AddressOf L_So_Ro
        RemoveHandler ButtExit.Click, AddressOf V_Quay_Ra
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler Master_UpdateGRV.PopupMenuShowing, AddressOf Master_UpdateGRV_PopupMenuShowing
        RemoveHandler Master_UpdateGRV.RowCellStyle, AddressOf Master_UpdateGRV_RowCellStyle

        AddHandler CmdUp_TG_GX_KH_SCC.Click, AddressOf V_Update_Lenh
        AddHandler TxtSo_Ro.Leave, AddressOf L_So_Ro
        AddHandler ButtExit.Click, AddressOf V_Quay_Ra
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler Master_UpdateGRV.PopupMenuShowing, AddressOf Master_UpdateGRV_PopupMenuShowing
        AddHandler Master_UpdateGRV.RowCellStyle, AddressOf Master_UpdateGRV_RowCellStyle

    End Sub
    Dim Dt_ph As DataTable
    Dim Dt_Master, Dt_head As DataTable
    Dim Dv_Master, Dv_head As DataView
    Dim _Bold_Up As Boolean = False
    Dim _BackColor_Up As Boolean = False
    Dim _BackColor2_Up As Boolean = False
    Dim _Forecolor_Up As Boolean = False
    Dim _FieldBold_Up As String = ""
    Dim _FieldBackColor_Up As String = ""
    Dim _FieldBackColor2_Up As String = ""
    Dim _FieldForecolor_Up As String = ""
    Private Sub V_LoadDatabase(ByVal status As String)
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_Update_TG_GX_Load", status & "#" & M_Loai_SC & "#" & TxtSo_Ro.Text & "#" & TxtStt_Rec_Ro.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        For i = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next
        If status = "1" Then
            Dt_ph = DsTmp.Tables(0).Copy
            Dt_Master = DsTmp.Tables(1).Copy
            Dt_head = DsTmp.Tables(2).Copy
            Dv_Master = New DataView(Dt_Master)
            Dv_head = New DataView(Dt_head)
            CyberWork.V_GetColorBold(Dt_Master, _Bold_Up, _BackColor_Up, _BackColor2_Up, _Forecolor_Up, _FieldBold_Up, _FieldBackColor_Up, _FieldBackColor2_Up, _FieldForecolor_Up)

            Master_Update.DataSource = Dv_Master
            Me.Master_UpdateGRV.GridControl = Me.Master_Update
            CyberFill.V_FillReports(Master_UpdateGRV, M_LAN, Dv_head, Dv_Master)
            Master_UpdateGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
            Master_UpdateGRV.OptionsSelection.MultiSelect = False

        Else
            Dt_ph.Clear()
            Dt_ph.Load(DsTmp.Tables(0).CreateDataReader)
            Dt_Master.Clear()
            Dt_Master.Load(DsTmp.Tables(1).CreateDataReader)
        End If
        If Dt_ph.Columns.Contains("So_RO") Then TxtSo_Ro.Text = Dt_ph.Rows(0).Item("So_Ro")
        If Dt_ph.Columns.Contains("Ma_Xe") Then TxtMa_Xe.Text = Dt_ph.Rows(0).Item("Ma_Xe")
        If Dt_ph.Columns.Contains("Stt_Rec_Ro") Then TxtStt_Rec_Ro.Text = Dt_ph.Rows(0).Item("Stt_Rec_Ro")
        If Dt_ph.Columns.Contains("Ten_HS") Then TxtTen_Hs.Text = Dt_ph.Rows(0).Item("Ten_HS")
        If Dt_ph.Columns.Contains("Ten_LX") Then TxtTen_Lx.Text = Dt_ph.Rows(0).Item("Ten_LX")
        If Dt_ph.Columns.Contains("Dt_LX") Then txtDt_lx.Text = Dt_ph.Rows(0).Item("Dt_LX")
        If Dt_ph.Columns.Contains("Ngay_BD_RO") Then TxtNgay_BD_RO.Value = Dt_ph.Rows(0).Item("Ngay_BD_RO")
        If Dt_ph.Columns.Contains("Ngay_KT_RO") Then TxtNgay_KT_RO.Value = Dt_ph.Rows(0).Item("Ngay_KT_RO")
        If Dt_ph.Columns.Contains("Ngay_henKT_RO") Then TxtNgay_HenKT_RO.Value = Dt_ph.Rows(0).Item("Ngay_henKT_RO")

        If Dt_ph.Columns.Contains("Ngay_BD_KH") Then TxtNgay_BD_KH.Value = Dt_ph.Rows(0).Item("Ngay_BD_Kh")
        If Dt_ph.Columns.Contains("Ngay_KT_KH") Then TxtNgay_KT_KH.Value = Dt_ph.Rows(0).Item("Ngay_KT_KH")

        If Dt_ph.Columns.Contains("Ngay_BD_RX") Then TxtNgay_BD_RX.Value = Dt_ph.Rows(0).Item("Ngay_BD_RX")
        If Dt_ph.Columns.Contains("Ngay_KT_RX") Then TxtNgay_KT_RX.Value = Dt_ph.Rows(0).Item("Ngay_KT_RX")

        If Dt_ph.Columns.Contains("Ngay_BD_Up") Then TxtNgay_BD_Up.Value = Dt_ph.Rows(0).Item("Ngay_BD_Up")
        If Dt_ph.Columns.Contains("Ngay_KT_Up") Then TxtNgay_KT_Up.Value = Dt_ph.Rows(0).Item("Ngay_KT_Up")
        If Dt_ph.Columns.Contains("Ngay_henKT_Up") Then TxtNgay_HenKT_Up.Value = Dt_ph.Rows(0).Item("Ngay_henKT_Up")
        If Dt_ph.Columns.Contains("Is_Rua") Then ChkIs_Rua.Checked = (Dt_ph.Rows(0).Item("Is_Rua").ToString.Trim = "1")

        DsTmp.Dispose()
    End Sub
    Private Sub V_Update_Lenh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Dr_Return = Nothing
        Dim _So_Ro As String = TxtSo_Ro.Text
        Dim _Ngay_BD_Up As Date = TxtNgay_BD_Up.Value
        Dim _Ngay_KT_Up As Date = TxtNgay_KT_Up.Value
        Dim _Ngay_HenKT_Up As Date = TxtNgay_HenKT_Up.Value

        Dim _Ngay_BD_Rx As Date = TxtNgay_BD_RX.Value
        Dim _Ngay_KT_Rx As Date = TxtNgay_KT_RX.Value

        Dim _Is_Rua As String = IIf(ChkIs_Rua.Checked, "1", "0")
        Dim DsTmp_Up As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_Update_TG_GX_Update", _Is_Rua & "#" & _So_Ro & "#" & _Ngay_BD_Up.ToString("yyyyMMdd HH:mm") & "#" & _Ngay_KT_Up.ToString("yyyyMMdd HH:mm") & "#" & _Ngay_HenKT_Up.ToString("yyyyMMdd HH:mm") & "#" & _
                                                                     _Ngay_BD_Rx.ToString("yyyyMMdd HH:mm") & "#" & _
                                                                     _Ngay_KT_Rx.ToString("yyyyMMdd HH:mm") & "#" & _
                                                                     M_Ma_Dvcs & "#" & M_User_Name)

        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmp_Up.Tables(0), Me.Sysvar, M_LAN)
        If Not _Return Then
            Me.Save_OK = False
            DsTmp_Up.Dispose()
            Return
        End If
        Me.Save_OK = True
        M_Dr_Return = DsTmp_Up.Tables(0).Copy.Rows(0)
        Me.Close()
    End Sub
    Private Sub V_Ngay_BD_UP(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub V_Ngay_KT_UP(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub V_Ngay_HenKT_UP(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub L_So_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt As Date = TxtNgay_BD_RO.Value
        _Dt = Now.Date
        'If _Dt.ToString("yyyyMMdd").Trim = "19000101" Then _Dt = Now.Date
        If TxtSo_Ro.Text.Trim = "" Then
            Return
        End If
        TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, "HDK", "S", "M", _Dt, TxtSo_Ro.Text, M_Ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)

        V_LoadDatabase("0")
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        M_Dr_Return = Nothing
        Me.Close()
    End Sub
#Region "Even GRV"
    Private Sub Master_UpdateGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()


        'If Not M_Kieu_Xem = "HEN" Then PopupMenu.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo Kế hoạch sửa chữa", "Create repair plan"), AddressOf V_Tao_Tien_Do_KH_SCC, Shortcut.F4, My.Resources.apply_16x16, True, True)).BeginGroup = False
        'PopupMenu.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_Up, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Tải dữ liệu", AddressOf V_ExportExcel, Shortcut.F11, Nothing, True, True), True).BeginGroup = True

        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_Quay_Ra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_ExportExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberExport As New Cyber.Export.Sys
        Dim FileName As String = ""

        Dim Dt_Title As New DataTable
        Dt_Title.Columns.Add("Title1")
        Dt_Title.Columns.Add("Title2")
        Dt_Title.Rows.Add("DANH SÁCH XE TIẾN ĐỘ")
        Dim Dt_TitleDetail As New DataTable
        Dt_TitleDetail.Columns.Add("Tu_Ngay")
        FileName = CyberExport.V_ExportToXlsx(AppConn, Master_UpdateGRV, New DataView(Dt_Title), New DataView(Dt_TitleDetail), Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub Master_UpdateGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        GRV_RowCellStyle(sender, e, Master_UpdateGRV, _Bold_Up, _BackColor_Up, _BackColor2_Up, _Forecolor_Up, _FieldBold_Up, _FieldBackColor_Up, _FieldBackColor2_Up, _FieldForecolor_Up)
    End Sub
    Private Sub GRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs, ByVal _GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _Bold As Boolean, ByVal _BackColor As Boolean, ByVal _BackColor2 As Boolean, ByVal _Forecolor As Boolean, ByVal _FieldBold As String, ByVal _FieldBackColor As String, ByVal _FieldBackColor2 As String, ByVal _FieldForecolor As String)

        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If _Bold Then
                Dim _categoryBold As String = _GRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
                If _categoryBold = "1" Then e.Appearance.Font = New System.Drawing.Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
            End If
            If _BackColor Then
                Dim _categoryBackColor As String = _GRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If _BackColor2 Then
                Dim _categoryBackColor2 As String = _GRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If

            If _Forecolor Then
                Dim _categoryForeColor As String = _GRV.GetRowCellDisplayText(e.RowHandle, _FieldForecolor).ToString.Trim
                e.Appearance.ForeColor = CyberColor.GetForeColor(_categoryForeColor)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
#End Region
End Class
