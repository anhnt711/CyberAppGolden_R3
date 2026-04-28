Public Class FrmDLHen_Call
#Region "Property"
    Dim CyberProgress As New Sys
    Dim CyberColor As New Cyber.Color.Sys
    Dim M_Stt_rec As String = ""
    Dim M_Kieu_Xem As String = "HEN"
    Dim M_Loai_SC As String = "1"
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

    Public Property Stt_rec As String
        Get
            Stt_rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
        End Set
    End Property
    Dim M_Stt_rec_RO As String = ""
    Public Property Stt_rec_Ro As String
        Get
            Stt_rec_Ro = M_Stt_rec_RO
        End Get
        Set(ByVal Value As String)
            M_Stt_rec_RO = Value
        End Set
    End Property
#End Region
    Dim Dt_CbbKQ1 As DataTable
    Dim Dt_CbbKQ2 As DataTable
    Dim Dt_CbbKQ3 As DataTable
    Private Sub FrmCVDV_DLHen_Call_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtNgay1.Value = Now
        TxtNgay2.Value = Now
        TxtNgay3.Value = Now
        TxtStt_Rec.Text = ""
        TxtMa_Dvcs.Text = M_Ma_Dvcs

        V_Load()
        V_Addhander()

        V_Doi1(New System.Object, New System.EventArgs)
        V_Doi2(New System.Object, New System.EventArgs)
        V_Doi3(New System.Object, New System.EventArgs)

        CyberSupport.Translaste(Me, Me.Lan, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Dim _Dt_Save As DataTable
    Private Sub V_Load()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkDLH_Call_Load", M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Stt_rec & "#" & M_Stt_rec_RO & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        For i As Integer = 0 To Dstmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(Dstmp.Tables(i))
        Next

        Dt_CbbKQ1 = Dstmp.Tables(1).Copy
        Dt_CbbKQ2 = Dstmp.Tables(1).Copy
        Dt_CbbKQ3 = Dstmp.Tables(1).Copy

        CyberFill.V_FillComBoxDefaul(CbbKQ1, Dt_CbbKQ1, "Ma", If(M_LAN = "V", "Ten", "Ten2"), "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbKQ2, Dt_CbbKQ2, "Ma", If(M_LAN = "V", "Ten", "Ten2"), "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbKQ3, Dt_CbbKQ3, "Ma", If(M_LAN = "V", "Ten", "Ten2"), "Ngam_Dinh")
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        _Dt_Save = Dstmp.Tables(0).Copy
        CyberSmodb.SetValueTObj(Me, _Dt_Save.Rows(0))
        Dstmp.Dispose()
    End Sub

    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TxtStt_Rec.Text.Trim = "" Then
            MsgBox("Khôn tồn tại lịch hẹn", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Return
        End If

        Dim _dr As DataRow = _Dt_Save.Rows(0)
        CyberSmodb.AddValueToRow(_dr, Me)
        Dim _Xml As String = CyberSmodb.V_ConvertDataToXML(_Dt_Save)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkDLH_Call_Save", M_Kieu_Xem + "#" + M_Loai_SC + "#" + TxtStt_Rec.Text & "#" & _Xml & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        Dim _Return As Boolean = CyberSupport.V_MsgChk(Dstmp.Tables(0), Me.Sysvar, M_LAN)
        If Not _Return Then
            Dstmp.Dispose()
            Return
        End If

        Me.Save_OK = True
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_Addhander()
        AddHandler ButtOK.Click, AddressOf V_Nhan

        AddHandler ChkLan1.CheckedChanged, AddressOf V_Lan1
        AddHandler ChkLan2.CheckedChanged, AddressOf V_Lan2
        AddHandler ChkLan3.CheckedChanged, AddressOf V_Lan3

        AddHandler ChkDoi1.CheckedChanged, AddressOf V_Doi1
        AddHandler ChkDoi2.CheckedChanged, AddressOf V_Doi2
        AddHandler ChkDoi3.CheckedChanged, AddressOf V_Doi3

        AddHandler TxtNgay_Den1.Leave, AddressOf V_Ngay_Den1
        AddHandler TxtNgay2.Leave, AddressOf V_Ngay_Den2
        AddHandler TxtNgay3.Leave, AddressOf V_Ngay_Den3


        AddHandler TxtNgay_Den1.Leave, AddressOf V_Ngay_Den1
        AddHandler TxtNgay_Den2.Leave, AddressOf V_Ngay_Den2
        AddHandler TxtNgay_Den3.Leave, AddressOf V_Ngay_Den3

        AddHandler TxtTG1.Leave, AddressOf V_TG_SC1
        AddHandler TxtTG2.Leave, AddressOf V_TG_SC2
        AddHandler TxtTG3.Leave, AddressOf V_TG_SC3

        AddHandler TxtNgay_BD1.Leave, AddressOf V_Ngay_BD1
        AddHandler TxtNgay_BD2.Leave, AddressOf V_Ngay_BD2
        AddHandler TxtNgay_BD3.Leave, AddressOf V_Ngay_BD3

        AddHandler TxtNgay_KT1.Leave, AddressOf V_Ngay_KT1
        AddHandler TxtNgay_KT2.Leave, AddressOf V_Ngay_KT2
        AddHandler TxtNgay_KT3.Leave, AddressOf V_Ngay_KT3
    End Sub
    Dim _TG_Den As Decimal = 15

#Region "Ngay_Den"
    Private Sub V_Ngay_Den1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtNgay_BD1.Value = CyberProgress.V_AddTime(TxtNgay_Den1.Value, _TG_Den, AppConn, CyberSmlib, M_Ma_Dvcs)
        TxtNgay_BD1.Value = DateAdd(DateInterval.Minute, _TG_Den, TxtNgay_Den1.Value)
        TxtNgay_KT1.Value = CyberProgress.V_AddTime(TxtNgay_BD1.Value, TxtTG1.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_Ngay_Den2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtNgay_BD2.Value = CyberProgress.V_AddTime(TxtNgay_Den2.Value, _TG_Den, AppConn, CyberSmlib, M_Ma_Dvcs)
        TxtNgay_BD2.Value = DateAdd(DateInterval.Minute, _TG_Den, TxtNgay_Den2.Value)
        TxtNgay_KT2.Value = CyberProgress.V_AddTime(TxtNgay_BD2.Value, TxtTG2.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_Ngay_Den3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtNgay_BD3.Value = CyberProgress.V_AddTime(TxtNgay_Den3.Value, _TG_Den, AppConn, CyberSmlib, M_Ma_Dvcs)
        TxtNgay_BD3.Value = DateAdd(DateInterval.Minute, _TG_Den, TxtNgay_Den3.Value)
        TxtNgay_KT3.Value = CyberProgress.V_AddTime(TxtNgay_BD3.Value, TxtTG3.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
#End Region
#Region "TG_SC"
    Private Sub V_TG_SC1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNgay_BD1.Value = CyberProgress.V_AddTime(TxtNgay_Den1.Value, _TG_Den, AppConn, CyberSmlib, M_Ma_Dvcs)
        TxtNgay_KT1.Value = CyberProgress.V_AddTime(TxtNgay_BD1.Value, TxtTG1.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_TG_SC2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNgay_BD2.Value = CyberProgress.V_AddTime(TxtNgay_Den2.Value, _TG_Den, AppConn, CyberSmlib, M_Ma_Dvcs)
        TxtNgay_KT2.Value = CyberProgress.V_AddTime(TxtNgay_BD2.Value, TxtTG2.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_TG_SC3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNgay_BD3.Value = CyberProgress.V_AddTime(TxtNgay_Den3.Value, _TG_Den, AppConn, CyberSmlib, M_Ma_Dvcs)
        TxtNgay_KT3.Value = CyberProgress.V_AddTime(TxtNgay_BD3.Value, TxtTG3.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
#End Region
#Region "Ngay_BD"
    Private Sub V_Ngay_BD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtNgay_Den1.Value = CyberProgress.V_AddTime(TxtNgay_BD1.Value, -1 * _TG_Den, AppConn, CyberSmlib, M_Ma_Dvcs)
        TxtNgay_Den1.Value = DateAdd(DateInterval.Minute, -1 * _TG_Den, TxtNgay_BD1.Value)
        TxtNgay_KT1.Value = CyberProgress.V_AddTime(TxtNgay_BD1.Value, TxtTG1.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_Ngay_BD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtNgay_Den2.Value = CyberProgress.V_AddTime(TxtNgay_BD2.Value, -1 * _TG_Den, AppConn, CyberSmlib, M_Ma_Dvcs)
        TxtNgay_Den2.Value = DateAdd(DateInterval.Minute, -1 * _TG_Den, TxtNgay_BD2.Value)
        TxtNgay_KT2.Value = CyberProgress.V_AddTime(TxtNgay_BD2.Value, TxtTG2.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_Ngay_BD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtNgay_Den3.Value = CyberProgress.V_AddTime(TxtNgay_BD3.Value, -1 * _TG_Den, AppConn, CyberSmlib, M_Ma_Dvcs)
        TxtNgay_Den3.Value = DateAdd(DateInterval.Minute, -1 * _TG_Den, TxtNgay_BD3.Value)
        TxtNgay_KT3.Value = CyberProgress.V_AddTime(TxtNgay_BD3.Value, TxtTG3.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
#End Region
#Region "Ngay_KT"
    Private Sub V_Ngay_KT1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtNgay_BD1.Value = CyberProgress.V_AddTime(TxtNgay_KT1.Value, -1 * TxtTG1.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        'TxtNgay_Den1.Value = CyberProgress.V_AddTime(TxtNgay_BD1.Value, -1 * _TG_Den, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_Ngay_KT2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtNgay_BD2.Value = CyberProgress.V_AddTime(TxtNgay_KT2.Value, -1 * TxtTG2.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        'TxtNgay_Den2.Value = CyberProgress.V_AddTime(TxtNgay_BD2.Value, -1 * _TG_Den, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_Ngay_KT3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'TxtNgay_BD3.Value = CyberProgress.V_AddTime(TxtNgay_KT3.Value, -1 * TxtTG2.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        'TxtNgay_Den3.Value = CyberProgress.V_AddTime(TxtNgay_BD3.Value, -1 * _TG_Den, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
#End Region
#Region "Doi Hen"
    Private Sub V_Doi1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNgay_Den1.Enabled = ChkDoi1.Checked
        TxtTG1.Enabled = ChkDoi1.Checked
        TxtNgay_BD1.Enabled = ChkDoi1.Checked
        TxtNgay_KT1.Enabled = ChkDoi1.Checked
        If ChkDoi1.Checked Then
            Dim _Ngay_Den As Date = TxtNgay_Den1.Value
            If _Ngay_Den < Now Then _Ngay_Den = Now
            TxtNgay_Den1.Value = _Ngay_Den

            TxtNgay_BD1.Value = CyberProgress.V_AddTime(_Ngay_Den, 15, AppConn, CyberSmlib, M_Ma_Dvcs)
            Dim _Ngay_BD As Date = TxtNgay_BD1.Value
            TxtNgay_KT1.Value = CyberProgress.V_AddTime(_Ngay_BD, TxtTG1.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        End If

    End Sub
    Private Sub V_Doi2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNgay_Den2.Enabled = ChkDoi2.Checked
        TxtTG2.Enabled = ChkDoi2.Checked
        TxtNgay_BD2.Enabled = ChkDoi2.Checked
        TxtNgay_KT2.Enabled = ChkDoi2.Checked

        If ChkDoi2.Checked Then
            Dim _Ngay_Den As Date = TxtNgay_Den2.Value
            If _Ngay_Den < Now Then _Ngay_Den = Now
            TxtNgay_Den2.Value = _Ngay_Den
            TxtNgay_BD2.Value = CyberProgress.V_AddTime(_Ngay_Den, 15, AppConn, CyberSmlib, M_Ma_Dvcs)
            Dim _Ngay_BD As Date = TxtNgay_BD2.Value
            TxtNgay_KT2.Value = CyberProgress.V_AddTime(_Ngay_BD, TxtTG2.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        End If

    End Sub
    Private Sub V_Doi3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNgay_Den3.Enabled = ChkDoi3.Checked
        TxtTG3.Enabled = ChkDoi3.Checked
        TxtNgay_BD3.Enabled = ChkDoi3.Checked
        TxtNgay_KT3.Enabled = ChkDoi3.Checked


        If ChkDoi3.Checked Then
            Dim _Ngay_Den As Date = TxtNgay_Den3.Value
            If _Ngay_Den < Now Then _Ngay_Den = Now
            TxtNgay_Den3.Value = _Ngay_Den
            TxtNgay_BD3.Value = CyberProgress.V_AddTime(_Ngay_Den, 15, AppConn, CyberSmlib, M_Ma_Dvcs)
            Dim _Ngay_BD As Date = TxtNgay_BD2.Value
            TxtNgay_KT3.Value = CyberProgress.V_AddTime(_Ngay_BD, TxtTG3.Double, AppConn, CyberSmlib, M_Ma_Dvcs)
        End If
    End Sub
#End Region
#Region "Lan"
    Private Sub V_Lan1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BG1.Enabled = False
        BG1.Enabled = ChkLan1.Checked
        V_E2(ChkLan1.Checked)
    End Sub
    Private Sub V_Lan2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BG2.Enabled = ChkLan2.Checked
        V_E3(ChkLan2.Checked)
    End Sub
    Private Sub V_Lan3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BG3.Enabled = ChkLan3.Checked
    End Sub
    Private Sub V_E2(ByVal _Chk As Boolean)
        If Not _Chk Then ChkLan2.Checked = False
        BG2.Enabled = _Chk
        ChkLan2.Enabled = _Chk
        If _Chk Then ChkLan2.Checked = False
        V_E3(ChkLan2.Checked)
    End Sub
    Private Sub V_E3(ByVal _Chk As Boolean)
        If Not _Chk Then ChkLan3.Checked = False
        ChkLan3.Enabled = _Chk
        BG3.Enabled = _Chk
    End Sub
#End Region
End Class
