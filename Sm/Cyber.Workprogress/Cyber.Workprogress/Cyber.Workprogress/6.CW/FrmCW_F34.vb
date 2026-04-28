Public Class FrmCW_F34
    Dim CyberWork As New Cyber.Workprogress.Sys
#Region "AddProperty"
    Dim M_Ma_TTCP As String = ""
    Public Property Ma_TTCP As String
        Get
            Ma_TTCP = M_Ma_TTCP
        End Get
        Set(ByVal Value As String)
            M_Ma_TTCP = Value
        End Set
    End Property

    Dim M_Tg_SC As Integer = 5
    Public Property Tg_SC As Integer
        Get
            Tg_SC = M_Tg_SC
        End Get
        Set(ByVal Value As Integer)
            M_Tg_SC = Value
        End Set
    End Property

    Dim M_Loai_SC As String = "1"
    Public Property Loai_SC As String
        Get
            Loai_SC = M_Loai_SC
        End Get
        Set(ByVal Value As String)
            M_Loai_SC = Value
        End Set
    End Property
    Dim M_Mode As String = "M"
    Public Property Mode As String
        Get
            Mode = M_Mode
        End Get
        Set(ByVal Value As String)
            M_Mode = Value
        End Set
    End Property
    Dim M_Stt_rec As String = ""
    Public Property Stt_rec As String
        Get
            Stt_rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
        End Set
    End Property
    Dim M_ma_khoang As String = ""
    Public Property Ma_khoang As String
        Get
            Ma_khoang = M_ma_khoang
        End Get
        Set(ByVal Value As String)
            M_ma_khoang = Value
        End Set
    End Property
    Dim M_Ngay_BD As Date
    Public Property Ngay_BD As Date
        Get
            Ngay_BD = M_Ngay_BD
        End Get
        Set(ByVal Value As Date)
            M_Ngay_BD = Value
        End Set
    End Property
    Dim M_Ngay_KT As Date
    Public Property Ngay_KT As Date
        Get
            Ngay_KT = M_Ngay_KT
        End Get
        Set(ByVal Value As Date)
            M_Ngay_KT = Value
        End Set
    End Property
#End Region
    Public Dt_Return As DataTable = Nothing
    Private Sub FrmCW_F34_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CyberVoucher Is Nothing Then CyberVoucher = New Cyber.Voucher.Sys
        Me.Save_OK = False
        '------------------------------------------------------------------------------------------------------------------
        V_LoadData()
        V_SetDefault()
        '------------------------------------------------------------------------------------------------------------------
        V_AddHandler()
        '------------------------------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '------------------------------------------------------------------------------------------------------------------
        Me.Text = IIf(M_Mode.Trim = "M", "Tạo mới/Mew", "Sửa KH/Edit")
        V_Dat_Them()
        V_Chk_Dat_Them(New System.Object, New System.EventArgs)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Dim Dt_Khoang As DataTable
    Private Sub V_SetDefault()
        TxtNgay_BD_RO.Enabled = False
        TxtNgay_KT_RO.Enabled = False
        TxtNgay_henKT_RO.Enabled = False

        TxtSo_Ro.Enabled = (M_Mode.Trim = "M")
        TxtMa_Xe.Enabled = (M_Mode.Trim = "M")
        ChkDat_them.Enabled = (M_Mode.Trim = "M")
        If M_Mode.Trim = "M" Then
            TxtMa_Xe.Focus()
            TxtLoai_SC.Text = M_Loai_SC
        Else
            TxtTG_SC.Focus()
        End If
        TxtNgay_KT.Enabled = False

    End Sub
    Private Sub V_LoadData()
        V_SetDefault()
        V_AddHandler()
        Dim _Str As String = "SELECT Ma_khoang,Ten_khoang FROM dbo.Dmkhoang WITH (NOLOCK) WHERE Ma_Dvcs = N'" + M_Ma_Dvcs + "' AND Is_Rua = '1' AND Is_TienDo = '1'" + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmpKhoang As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", _Str)
        Dt_Khoang = DsTmpKhoang.Tables(0).Copy
        CyberFill.V_FillComBoxValue(CbbMa_khoang, Dt_Khoang, "Ma_khoang", "Ten_Khoang")


        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_F3F4_Load", M_Tg_SC.ToString.Trim.Replace(",", ".").Replace(" ", "") & "#" & M_Loai_SC & "#" & M_Stt_rec & "#" & M_ma_khoang & "#" & M_Ngay_BD.ToString("yyyyMMdd HH:mm") & "#" & M_Ngay_KT.ToString("yyyyMMdd HH:mm") & "#" & M_Ma_Dvcs & "#" + M_User_Name)
        CyberSmodb.SetValueTObj(Me, DsTmp.Tables(0).Rows(0))

        If CyberWork.V_GetvalueCombox(CbbMa_khoang).ToString.Trim = "" And M_Mode = "M" Then
            Try
                CbbMa_khoang.SelectedValue = Dt_Khoang.Rows(0).Item("Ma_khoang").ToString.Trim
            Catch ex As Exception
            End Try
        End If


        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        If TxtTG_SC.Double <= 0 Then TxtTG_SC.Double = M_Tg_SC
        If TxtTG_SC.Double > 0 Then
            TxtNgay_KT.Value = CyberWork.V_AddTime(_Ngay_BD, TxtTG_SC.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        End If
        DsTmp.Dispose()
    End Sub
    Private Sub V_AddHandler()
        RemoveHandler TxtTG_SC.Leave, AddressOf V_TG_SC
        AddHandler TxtTG_SC.Leave, AddressOf V_TG_SC

        RemoveHandler TxtNgay_BD.Leave, AddressOf V_Ngay_BD
        AddHandler TxtNgay_BD.Leave, AddressOf V_Ngay_BD

        RemoveHandler TxtNgay_KT.Leave, AddressOf V_Ngay_KT
        AddHandler TxtNgay_KT.Leave, AddressOf V_Ngay_KT

        RemoveHandler TxtSo_Ro.Leave, AddressOf L_So_Ro
        AddHandler TxtSo_Ro.Leave, AddressOf L_So_Ro


        RemoveHandler ChkDat_them.CheckedChanged, AddressOf V_Dat_Them
        AddHandler ChkDat_them.CheckedChanged, AddressOf V_Dat_Them

        RemoveHandler LabMa_Xe.Click, AddressOf V_Ma_Xe_Click
        AddHandler LabMa_Xe.Click, AddressOf V_Ma_Xe_Click

        RemoveHandler ChkDat_them.CheckedChanged, AddressOf V_Chk_Dat_Them
        AddHandler ChkDat_them.CheckedChanged, AddressOf V_Chk_Dat_Them

        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
#Region "Ro/Xe/Dat_Them"
    Private Sub V_Chk_Dat_Them(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LabSo_RO.Visible = Not ChkDat_them.Checked
        TxtSo_Ro.Visible = Not ChkDat_them.Checked

    End Sub

    Private Sub L_So_Ro(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtSo_Ro.Text.Trim = "" Then
            Return
        End If
        Dim _Dt As Date = TxtNgay_BD_RO.Value
        TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Sysvar, "HDK", "S", M_Mode, _Dt, TxtSo_Ro.Text, M_Ma_TTCP, M_Ma_Dvcs, M_User_Name)
        V_GetInfor()
    End Sub
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim Dr = CyberSmlistSys.V_CheckAndAddRowList(M_LAN, Me.Para, Me.Sysvar, AppConn, "DMXE", "Ma_Xe= N'" & TxtMa_Xe.Text.Trim.Replace("'", "").Replace("#", "") & "'", "MA_XE#", TxtMa_Xe.Text.Trim)
        If Dr Is Nothing Then Exit Sub
        V_GetInfor()
    End Sub
    Private Sub V_Dat_Them()
        TxtSo_Ro.ReadOnly = ChkDat_them.Checked
        TxtMa_Xe.ReadOnly = Not ChkDat_them.Checked
    End Sub
    Private Sub V_Dat_them(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Dat_Them()
        V_GetInfor()
    End Sub
    Private Sub V_Ma_Xe_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim Dr = CyberSmlistSys.V_CheckAndAddRowList(M_LAN, Me.Para, Me.Sysvar, AppConn, "DMXE", "Ma_Xe= N'" & TxtMa_Xe.Text.Trim.Replace("'", "").Replace("#", "") & "'", "MA_XE#", TxtMa_Xe.Text.Trim, True)
        If Dr Is Nothing Then Exit Sub
    End Sub
    Private Sub V_GetInfor()
        Dim _So_Ro As String = TxtSo_Ro.Text
        Dim _ma_Xe As String = TxtMa_Xe.Text
        Dim _Dat_Them As String = IIf(ChkDat_them.Checked, "1", "0")

        If _So_Ro.Trim = "" And _ma_Xe.Trim = "" Then Return

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_F3F4_Load_Ro_Xe", M_Loai_SC & "#" & Mode.Trim & "#" & TxtStt_Rec.Text & "#" & TxtMa_Ct.Text & "#" & _
                                                                  _So_Ro & "#" & _ma_Xe & "#" & _Dat_Them & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsTmp.Tables.Count = 0 Then
            DsTmp.Dispose()
            Return
        End If

        If DsTmp.Tables(0).Rows.Count = 0 Then
            DsTmp.Dispose()
            Return
        End If

        If DsTmp.Tables(0).Columns.Contains("Ngay_BD_Ro") Then TxtNgay_BD_RO.Value = DsTmp.Tables(0).Rows(0).Item("Ngay_Bd_RO")
        If DsTmp.Tables(0).Columns.Contains("Ngay_KT_Ro") Then TxtNgay_KT_RO.Value = DsTmp.Tables(0).Rows(0).Item("Ngay_KT_RO")
        If DsTmp.Tables(0).Columns.Contains("Ngay_henKT_Ro") Then TxtNgay_henKT_RO.Value = DsTmp.Tables(0).Rows(0).Item("Ngay_henKT_RO")
        If DsTmp.Tables(0).Columns.Contains("Ma_Xe") Then TxtMa_Xe.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Xe").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("So_RO") Then TxtMa_Xe.Text = DsTmp.Tables(0).Rows(0).Item("So_RO").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ma_Ct") Then TxtMa_Xe.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Ct").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Stt_Rec") Then TxtMa_Xe.Text = DsTmp.Tables(0).Rows(0).Item("Stt_Rec").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dat_Them") Then ChkDat_them.Checked = (DsTmp.Tables(0).Rows(0).Item("Dat_Them").ToString = "1")
    End Sub
#End Region
#Region "Thoi gian"
    Private Sub V_TG_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        If TxtTG_SC.Double <= 0 Then TxtTG_SC.Double = 5
        If Not (TxtTG_SC.Double = 5 Or TxtTG_SC.Double = 10 Or TxtTG_SC.Double = 15 Or TxtTG_SC.Double = 20 Or TxtTG_SC.Double = 25 Or TxtTG_SC.Double = 30) Then TxtTG_SC.Double = 5
        TxtNgay_KT.Value = CyberWork.V_AddTime(_Ngay_BD, TxtTG_SC.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_Ngay_BD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        If TxtTG_SC.Double > 0 Then
            TxtNgay_KT.Value = CyberWork.V_AddTime(_Ngay_BD, TxtTG_SC.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        End If
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        TxtTG_SC.Double = CyberWork.V_GetTimeM(_Ngay_BD, _Ngay_KT, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_Ngay_KT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        TxtTG_SC.Double = CyberWork.V_GetTimeM(_Ngay_BD, _Ngay_KT, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub

#End Region
#Region "Save"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        If TxtMa_Xe.Text.Trim = "" Then
            TxtMa_Xe.Focus()
            Return
        End If
        'If TxtSo_Ro.Text.Trim = "" Then
        '    TxtSo_Ro.Focus()
        '    Return
        'End If
        TxtMa_Dvcs.Text = M_Ma_Dvcs.Trim

        Dim _Str As String = "SELECT TOP 0 * FROM dbo.PH89CVDV_RX WITH (NOLOCK) WHERE 1=0" + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", _Str)
        Dim Dt_Save As DataTable = DsTmp.Tables(0).Copy
        DsTmp.Dispose()

        Dim _DrSave As DataRow = Dt_Save.NewRow
        _DrSave.BeginEdit()
        CyberSmodb.SetValueBlankRow(_DrSave)
        CyberSmodb.AddValueToRow(_DrSave, Me)
        _DrSave.EndEdit()
        Dt_Save.Rows.Add(_DrSave)
        Dt_Save.AcceptChanges()
        '----------------------------------------------------------------------------------
        Dim strXML As String = CyberSmodb.V_ConvertDataToXML({"PH89CVDV_RX"}, {Dt_Save})

        Dim DsTmpSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CW_Save", Mode + "#" + M_Stt_rec.Trim + "#" + TxtMa_Ct.Text + "#" + strXML + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        '-----------------------------------------------------------------------------------------------------------------
        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmpSave.Tables(0), Me.Sysvar, M_LAN)
        If Not _Return Then
            Dt_Return = Nothing
            DsTmpSave.Dispose()
            Return
        End If
        Dt_Return = DsTmpSave.Tables(0).Copy
        '----------------------------------------------------------------------------------
        Me.Save_OK = True
        Me.Close()
    End Sub

    Private Sub V_Nhan_Luu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        If TxtMa_Xe.Text.Trim = "" Then
            TxtMa_Xe.Focus()
            Return
        End If
        'If TxtSo_Ro.Text.Trim = "" Then
        '    TxtSo_Ro.Focus()
        '    Return
        'End If
        TxtMa_Dvcs.Text = M_Ma_Dvcs.Trim

        Dim _Str As String = "SELECT TOP 0 * FROM dbo.PH89CVDV_RX WITH (NOLOCK) WHERE 1=0" + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", _Str)
        Dim Dt_Save As DataTable = DsTmp.Tables(0).Copy
        DsTmp.Dispose()

        Dim _DrSave As DataRow = Dt_Save.NewRow
        _DrSave.BeginEdit()
        CyberSmodb.SetValueBlankRow(_DrSave)
        CyberSmodb.AddValueToRow(_DrSave, Me)
        _DrSave.EndEdit()
        Dt_Save.Rows.Add(_DrSave)
        Dt_Save.AcceptChanges()
        '----------------------------------------------------------------------------------
        Dim _Ngay_Ct As Date = TxtNgay_BD.Value
        Dim DsTmpSave As DataSet = CyberSmodb.V_ChkAndSaveVoucher(Mode, TxtStt_Rec.Text, TxtMa_Ct.Text, _Ngay_Ct, M_Ma_Dvcs, M_User_Name, _
                                                                  {"PH89CVDV_RX"}, _
                                                                  {Dt_Save}, _
                                                                  AppConn, Me.Sysvar, M_LAN, "CP_Work_CW_Save", CyberSmlib, CyberSupport)
        '-----------------------------------------------------------------------------------------------------------------
        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmpSave.Tables(0), Me.Sysvar, M_LAN)
        If Not _Return Then
            Dt_Return = Nothing
            DsTmpSave.Dispose()
            Return
        End If
        If DsTmpSave.Tables(0).Columns.Contains("Ma_Xe") Then TxtMa_Xe.Text = DsTmpSave.Tables(0).Rows(0).Item("ma_Xe")
        If DsTmpSave.Tables(0).Columns.Contains("So_Ro") Then TxtSo_Ro.Text = DsTmpSave.Tables(0).Rows(0).Item("So_Ro")
        If DsTmpSave.Tables(0).Columns.Contains("Stt_Rec") Then TxtStt_Rec.Text = DsTmpSave.Tables(0).Rows(0).Item("Stt_Rec")
        If DsTmpSave.Tables(0).Columns.Contains("Ma_Ct") Then TxtMa_Ct.Text = DsTmpSave.Tables(0).Rows(0).Item("Ma_Ct")
        Dt_Return = DsTmpSave.Tables(0).Copy
        '----------------------------------------------------------------------------------
        Me.Save_OK = True
        Me.Close()
    End Sub
#End Region
End Class
