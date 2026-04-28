Public Class FrmTien_Do_Dung_SC
    Dim CyberWork As New Cyber.Workprogress.Sys
    Dim M_Mode As String = "M"
#Region "Property"
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
#End Region
    Public Dt_Return As DataTable = Nothing
    Public Dt_Cd, Dt_Dung As DataTable
    Dim Dv_Cd, Dv_Dung As DataView
    Private Sub FrmCVDV_Dung_SC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CyberVoucher Is Nothing Then CyberVoucher = New Cyber.Voucher.Sys
        Me.Save_OK = False
        '------------------------------------------------------------------------------------------------------------------
        TxtNgay_BD.Value = DateAndTime.Now
        TxtNgay_KT.Value = DateAndTime.Now

        '------------------------------------------------------------------------------------------------------------------
        V_Load()
        '------------------------------------------------------------------------------------------------------------------
        V_AddHandler()
        '------------------------------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '------------------------------------------------------------------------------------------------------------------
        Me.Text = IIf(M_Mode.Trim = "M", "XÁC NHẬN LÝ DO DỪNG SỬA CHỮA", "XÁC NHẬN LÝ DO DỪNG SỬA CHỮA")
        ChkTrong_khoang.Checked = True
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub

    Private Sub V_Load()
        Dim DstmpCd As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_DungSC_Load", M_Kieu_Xem & "#" & M_Loai_SC & "#" & M_Stt_rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dt_Cd = DstmpCd.Tables(1).Copy
        Dt_Dung = DstmpCd.Tables(2).Copy

        Dv_Cd = New DataView(Dt_Cd)
        Dv_Dung = New DataView(Dt_Dung)

        CyberFill.V_FillComBoxDefaul(CbbMa_Cd, Dt_Cd, "Ma_Cd", "Ten_Cd", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_Dung, Dt_Dung, "Ma_Dung", "Ten_Dung", "Ngam_Dinh")

        CyberSmodb.SetValueTObj(Me, DstmpCd.Tables(0).Rows(0))
        DstmpCd.Dispose()
    End Sub
    Private Sub V_AddHandler()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub


    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim _ma_Dung As String = CyberWork.V_GetvalueCombox(CbbMa_Dung)
        If _ma_Dung.Trim = "" Then
            MsgBox("Bạn chưa chọn lý do dừng sửa chữa?", MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Return
        End If
        TxtMa_Dvcs.Text = M_Ma_Dvcs.Trim
        '-----------------------------------------------------------------------------------------------------------------
        Dim _Str As String = "SELECT TOP 0 * FROM dbo.PH89CVDV_DungSC WITH (NOLOCK) WHERE 1=0" + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmpStru As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", _Str)
        Dim Dt_Save As DataTable = DsTmpStru.Tables(0).Copy
        DsTmpStru.Dispose()

        Dim _DrSave As DataRow = Dt_Save.NewRow
        _DrSave.BeginEdit()
        CyberSmodb.SetValueBlankRow(_DrSave)
        CyberSmodb.AddValueToRow(_DrSave, Me)

        _DrSave.EndEdit()
        Dt_Save.Rows.Add(_DrSave)
        Dt_Save.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------------------
        Dim strXML As String = CyberSmodb.V_ConvertDataToXML({"PH89CVDV_DungSC"}, {Dt_Save})
        Dim M_strParameterStore As String = M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Stt_rec + "#" + strXML + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_DungSC_Save_BD", M_strParameterStore)
        '-----------------------------------------------------------------------------------------------------------------
        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN)
        If Not _Return Then
            Dt_Return = Nothing
            DsTmp.Dispose()
            Me.Save_OK = False
            Return
        End If
        Dt_Return = DsTmp.Tables(0).Copy
        Me.Save_OK = True
        '-----------------------------------------------------------------------------------------------------------------
        Me.Close()
    End Sub

End Class
