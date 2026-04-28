Public Class FrmTien_Do_ChayThu
    Dim CyberWork As New Cyber.Workprogress.Sys
#Region "Add_Property"
    Dim M_Kieu_Xem As String = "KH"
    Public Property Kieu_Xem() As String
        Get
            Kieu_Xem = M_Kieu_Xem
        End Get
        Set(ByVal Value As String)
            M_Kieu_Xem = Value
        End Set
    End Property
    Dim M_Loai_SC As String = "1"
    Public Property Loai_SC() As String
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
    Dim M_Stt_rec_RO As String = ""
    Public Property Stt_rec_RO As String
        Get
            Stt_rec_RO = M_Stt_rec_RO
        End Get
        Set(ByVal Value As String)
            M_Stt_rec_RO = Value
        End Set
    End Property
#End Region
    Public Dt_Return As DataTable = Nothing
    Private Sub FrmCVDV_ChayThu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CyberVoucher Is Nothing Then CyberVoucher = New Cyber.Voucher.Sys
        Me.Save_OK = False
        '------------------------------------------------------------------------------------------------------------------
        V_LoadData()
        '------------------------------------------------------------------------------------------------------------------
        V_AddHandler()
        '------------------------------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '------------------------------------------------------------------------------------------------------------------
        Me.Text = IIf(M_Mode.Trim = "M", "PHIẾU XE CHẠY THỬ", "PHIẾU XE CHẠY THỬ")
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
#Region "V_AddHandler"
    Private Sub V_AddHandler()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtTG_SC.Leave, AddressOf V_TG_SC
        AddHandler CmdSave.Click, AddressOf V_Save
        AddHandler CmdPrint.Click, AddressOf V_Print
    End Sub
#End Region
    Private Sub V_LoadData()
        TxtTG_SC.Double = 15
        TxtNgay_BD.Value = DateAndTime.Now
        TxtNgay_KT.Value = DateAndTime.Now.AddMilliseconds(TxtTG_SC.Double)
        TxtNgay_BD.Enabled = False
        TxtNgay_KT.Enabled = False
        ChkKet_Thuc.Enabled = False
        '--------------------------------------------------------------------------------------------------------------
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CHAYTHU_Load", M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Stt_rec + "#" + M_Stt_rec_RO + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        If Dstmp.Tables(0).Rows.Count = 1 Then
            If Dstmp.Tables(0).Columns.Contains("Ngay_BD") Then TxtNgay_BD.Value = Dstmp.Tables(0).Rows(0).Item("Ngay_BD")
            If Dstmp.Tables(0).Columns.Contains("Ngay_KT") Then TxtNgay_KT.Value = Dstmp.Tables(0).Rows(0).Item("Ngay_KT")
            If Dstmp.Tables(0).Columns.Contains("TG_SC") Then TxtTG_SC.Double = Dstmp.Tables(0).Rows(0).Item("TG_SC")
            If Dstmp.Tables(0).Columns.Contains("Ket_Thuc") Then If Dstmp.Tables(0).Rows(0).Item("Ket_Thuc").ToString.Trim = "1" Then ChkKet_Thuc.Checked = True Else ChkKet_Thuc.Checked = False

            If ChkKet_Thuc.Checked Then LabTinh_Trang.Text = "ĐÃ HOÀN THÀNH CHẠY THỬ, BẠN CÓ CẤP MỚI CHẠY THỬ KHÔNG ?" Else LabTinh_Trang.Text = "KẾT THÚC CHẠY THỬ"
        Else
            If TxtTG_SC.Double <= 0 Then TxtTG_SC.Double = 15
            _Ngay_BD = TxtNgay_BD.Value
            TxtNgay_BD.Value = DateAndTime.Now
            TxtNgay_KT.Value = CyberWork.V_AddTime(_Ngay_BD, TxtTG_SC.Double, AppConn, CyberSmlib, M_Ma_Dvcs)

            ChkKet_Thuc.Checked = False
            LabTinh_Trang.Text = "CẤP PHIẾU"
        End If
        TxtTG_SC.Enabled = True
        TxtTG_SC.Focus()
    End Sub
    Private Sub V_TG_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        If TxtTG_SC.Double <= 0 Then TxtTG_SC.Double = 15
        TxtNgay_KT.Value = CyberWork.V_AddTime(_Ngay_BD, TxtTG_SC.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_Print(ByVal Loai_IN As String, ByVal Loai_Tien As Boolean, ByVal Ngon_ngu As Boolean, ByVal M_Reports As String, ByVal DsDataReport As DataSet, ByVal M_Title1 As String, ByVal M_Title2 As String, ByVal oSysVar As Collection, ByVal M_PARA As String())
        Dim ClssPrint As New Cyber.Print.Sys
        ClssPrint.CyberPrintReport(AppConn, Loai_IN, M_Reports, DsDataReport, M_Title1, M_Title2, oSysVar, M_PARA, M_Ma_Dvcs, False, "", Lan, Loai_Tien, Ngon_ngu)
        GC.Collect()
    End Sub

    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DsPrint As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CHAYTHU_Print", M_Stt_rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsPrint.Tables(0), Me.Sysvar, M_LAN) Then
            DsPrint.Dispose()
            Return
        End If

        Dim _ReportName As String = ""
        Dim _Title1 As String = ""
        Dim _Title2 As String = ""

        If DsPrint.Tables(0).Columns.Contains("ReportName") Then _ReportName = DsPrint.Tables(0).Rows(0).Item("ReportName").ToString.Trim()
        If DsPrint.Tables(0).Columns.Contains("Title1") Then _Title1 = DsPrint.Tables(0).Rows(0).Item("Title1").ToString.Trim
        If DsPrint.Tables(0).Columns.Contains("Title2") Then _Title2 = DsPrint.Tables(0).Rows(0).Item("Title2").ToString.Trim

        DsPrint.Tables.Remove(DsPrint.Tables(0))
        V_Print("1", True, True, _ReportName, DsPrint, _Title1, _Title2, Me.Sysvar, Me.Para)
    End Sub
    Private Sub V_Save(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If V_Save() Then Me.Close()
    End Sub
    Private Function V_Save() As Boolean
        TxtMa_Dvcs.Text = M_Ma_Dvcs.Trim
        '----------------------------------------------------------------------------------
        If ChkKet_Thuc.Checked Then
            If Not MsgBox("Đã kết thúc chạy thử rồi, bạn có muốn tạo kế hoạch chạy thử mới không", MsgBoxStyle.Critical + MsgBoxStyle.YesNo, Sysvar("M_CYBER_VER")) = MsgBoxResult.Yes Then Return False
        End If

        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        Dim _StrF As String = ""
        Dim _StrV As String = ""
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        CyberSmodb.GetValueControler(Me, _StrF, _StrV)

        Dim DsSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_CHAYTHU_Save", M_Kieu_Xem + "#" + M_Loai_SC + "#" + _Ngay_BD.ToString("yyyyMMdd HH:mm").Trim + "#" + _
                                                                   _Ngay_KT.ToString("yyyyMMdd HH:mm").Trim + "#" + _StrF + "#" + _StrV + "#" + _
                                                                   M_Stt_rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        V_Save = CyberSupport.V_MsgChk(DsSave.Tables(0), Me.Sysvar, M_LAN)
        If V_Save Then Dt_Return = DsSave.Tables(0).Copy Else Dt_Return = Nothing
        Me.Save_OK = V_Save
    End Function
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not V_Save() Then Return
        '----------------------------------------------------------------------------------
        V_Print(New System.Object, New System.EventArgs)
        '----------------------------------------------------------------------------------   
        Me.Close()
    End Sub


End Class
