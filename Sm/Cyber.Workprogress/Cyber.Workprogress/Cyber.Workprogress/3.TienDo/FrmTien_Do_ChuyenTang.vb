Public Class FrmTien_Do_ChuyenTang
    Dim CyberWork As New Cyber.Workprogress.Sys
    Dim CyberColor As New Cyber.Color.Sys
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

    Dim M_Stt_rec_KH As String = ""
    Public Property Stt_rec_KH As String
        Get
            Stt_rec_KH = M_Stt_rec_KH
        End Get
        Set(ByVal Value As String)
            M_Stt_rec_KH = Value
        End Set
    End Property
    Dim M_Stt_rec_Ro As String = ""
    Public Property Stt_rec_Ro As String
        Get
            Stt_rec_Ro = M_Stt_rec_Ro
        End Get
        Set(ByVal Value As String)
            M_Stt_rec_Ro = Value
        End Set
    End Property
    Dim Dt_tang1, dt_tang2 As DataTable
#End Region
    Public Dt_Return As DataTable = Nothing
    Private Sub FrmTien_Do_ChuyenTang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CyberVoucher Is Nothing Then CyberVoucher = New Cyber.Voucher.Sys
        Me.Save_OK = False
        '------------------------------------------------------------------------------------------------------------------
        V_Load()
        '------------------------------------------------------------------------------------------------------------------
        V_AddHandler()
        '------------------------------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '------------------------------------------------------------------------------------------------------------------
        Me.Text = IIf(M_LAN.Trim = "V", "Tạo thông điệp chuyển tầng", "Floor shift")
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Dim Dt_Khoang As DataTable
    Private Sub V_Load()
        Dim DstmpCd As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Chuyentang_Load", M_Kieu_Xem & "#" & M_Loai_SC & "#" & M_Stt_rec_KH & "#" & M_Stt_rec_Ro & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dt_tang1 = DstmpCd.Tables(1).Copy
        dt_tang2 = DstmpCd.Tables(2).Copy
        CyberFill.V_FillComBoxDefaul(CbbMa_TangChuyen, Dt_tang1, "Ma_tang", "Ten_Tang", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMa_TangNhan, dt_tang2, "Ma_tang", "Ten_Tang", "Ngam_Dinh")

        CyberSmodb.SetValueTObj(Me, DstmpCd.Tables(0).Rows(0))
        DstmpCd.Dispose()
        If TxtForeColor_Ghichu.Text <> "" Then
            txtGhi_Chu.ForeColor = CyberColor.GetBackColor(TxtForeColor_Ghichu.Text)
            CldChon_ForeColor.Color = txtGhi_Chu.ForeColor
        End If
        If TxtBackColor_Ghichu.Text <> "" Then
            txtGhi_Chu.BackColor = CyberColor.GetBackColor(TxtBackColor_Ghichu.Text)
            CldChon_Backcolor.Color = txtGhi_Chu.BackColor
        End If

    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        'Dim _ma_TangChuyen As String = CyberWork.V_GetvalueCombox(CbbMa_TangChuyen)
        'Dim _ma_TangNhan As String = CyberWork.V_GetvalueCombox(CbbMa_TangNhan)
        'If _ma_TangChuyen.Trim = "" Then
        '    MsgBox("Bạn chưa chọn tầng chuyển?", MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
        '    Return
        'End If
        'If _ma_TangChuyen.Trim = "" Then
        '    MsgBox("Bạn chưa chọn tầng nhận?", MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
        '    Return
        'End If
        TxtMa_Dvcs.Text = M_Ma_Dvcs.Trim
        '-----------------------------------------------------------------------------------------------------------------
        Dim _Str As String = "SELECT TOP 0 * FROM dbo.PH89CVDV_SCC_Chuyentang WITH (NOLOCK) WHERE 1=0" + "#" + M_Ma_Dvcs + "#" + M_User_Name
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
        Dim strXML As String = CyberSmodb.V_ConvertDataToXML({"PH89CVDV_SCC_Chuyentang"}, {Dt_Save})
        Dim M_strParameterStore As String = M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Stt_rec_KH + "#" + M_Stt_rec_Ro + "#" + strXML + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Chuyentang_Save", M_strParameterStore)
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
#Region "V_AddHandler"
    Private Sub V_AddHandler()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtForeColor_Choose.Click, AddressOf V_Chon_Forecolor
        AddHandler ButtForeColor_Choose.Click, AddressOf V_Chon_Forecolor
        RemoveHandler ButtBackColor_Choose.Click, AddressOf V_Chon_BackColor
        AddHandler ButtBackColor_Choose.Click, AddressOf V_Chon_BackColor
        RemoveHandler buttRemove_Forecolor.Click, AddressOf V_Remove_Forecolor
        AddHandler buttRemove_Forecolor.Click, AddressOf V_Remove_Forecolor
        RemoveHandler buttRemove_backcolor.Click, AddressOf V_Remove_Backcolor
        AddHandler buttRemove_backcolor.Click, AddressOf V_Remove_Backcolor
    End Sub
#End Region
    Private Sub V_Remove_Forecolor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CldChon_ForeColor.Reset()
        txtGhi_Chu.ForeColor = Drawing.Color.Navy
        TxtForeColor_Ghichu.Text = ""
    End Sub
    Private Sub V_Remove_Backcolor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CldChon_Backcolor.Reset()
        txtGhi_Chu.BackColor = Drawing.Color.White
        TxtBackColor_Ghichu.Text = ""
    End Sub
    Private Sub V_Chon_BackColor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtBackColor_Choose.Enabled = False
        CldChon_Backcolor.ShowDialog()
        txtGhi_Chu.BackColor = CldChon_Backcolor.Color
        TxtBackColor_Ghichu.Text = CldChon_Backcolor.Color.R.ToString() + "," + CldChon_Backcolor.Color.G.ToString() + "," + CldChon_Backcolor.Color.B.ToString()
        ButtBackColor_Choose.Enabled = True
    End Sub
    Private Sub V_Chon_Forecolor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtForeColor_Choose.Enabled = False
        CldChon_ForeColor.ShowDialog()
        txtGhi_Chu.ForeColor = CldChon_ForeColor.Color
        TxtForeColor_Ghichu.Text = CldChon_ForeColor.Color.R.ToString() + "," + CldChon_ForeColor.Color.G.ToString() + "," + CldChon_ForeColor.Color.B.ToString()
        ButtForeColor_Choose.Enabled = True
    End Sub
End Class
