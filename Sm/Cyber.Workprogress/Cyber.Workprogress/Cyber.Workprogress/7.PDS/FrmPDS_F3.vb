Public Class FrmPDS_F3
#Region "Biến"
    Dim CyberWork As New Cyber.Workprogress.Sys
    Public Dt_Return As DataTable = Nothing
    Dim M_Tg_SC As Integer = 5
    Public Property Tg_SC As Integer
        Get
            Tg_SC = M_Tg_SC
        End Get
        Set(ByVal Value As Integer)
            M_Tg_SC = Value
        End Set
    End Property
    Dim M_DmKhoang As DataTable
    Public Property DmKhoang As DataTable
        Get
            DmKhoang = M_DmKhoang
        End Get
        Set(ByVal Value As DataTable)
            M_DmKhoang = Value
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
    Private Sub FrmPDS_F3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        If M_Mode = "M" Then If M_LAN = "V" Then Me.Text = "Tạo mới kế hoạch" Else Me.Text = "Create Planning"
        If M_Mode = "S" Then If M_LAN = "V" Then Me.Text = "Sửa kế hoạch" Else Me.Text = "Edit Planning"
        TxtMa_Xe.Enabled = (M_Mode = "M")
        If M_Mode = "S" Then TxtTG_SC.Focus() Else TxtMa_Xe.Focus()
        V_FillComBoxDefaul(CbbMa_khoang, DmKhoang, "Ma_Khoang", "Ten_khoang", "Ngam_Dinh")
        '----------------------------------------------------------------------------------------------------------------------
        V_Load()
        '----------------------------------------------------------------------------------------------------------------------
        V_AddHandler()
        '----------------------------------------------------------------------------------------------------------------------
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        TxtTG_SC.Double = CyberWork.V_GetTimeM(_Ngay_BD, _Ngay_KT, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_PDS_F3_Load", M_Mode + "#" + M_Stt_rec + "#" + M_ma_khoang + "#" + M_Ngay_BD.ToString("yyyyMMdd HH:mm") + "#" + M_Ngay_KT.ToString("yyyyMMdd HH:mm") + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        CyberSmodb.SetValueTObj(Me, Dstmp.Tables(0).Rows(0))
        V_Ma_Xe(New System.Object, New System.EventArgs)
    End Sub
    Public Sub V_FillComBoxDefaul(ByVal _Cbb As System.Windows.Forms.ComboBox, ByVal _Dt As DataTable, ByVal _Field As String, ByVal _Name As String, Optional ByVal _FieldDefault As String = "Ngam_Dinh")
        Dim _is_Ngam_Dinh As Boolean = False
        If _Dt Is Nothing Then Return
        If Not _Dt.Columns.Contains(_Field) Then Return
        If Not _Dt.Columns.Contains(_Name) Then Return
        _Field = _Dt.Columns(_Field).ColumnName
        _Name = _Dt.Columns(_Name).ColumnName

        If _FieldDefault = "" Then _FieldDefault = "Ngam_Dinh"
        If Not _Dt.Columns.Contains(_FieldDefault) Then
            If _Dt.Columns.Contains("Ngam_Dinh") Then
                _FieldDefault = _Dt.Columns(_FieldDefault).ColumnName
                _is_Ngam_Dinh = True
            End If
        Else
            _FieldDefault = _Dt.Columns(_FieldDefault).ColumnName
            _is_Ngam_Dinh = True
        End If
        If _Dt.Rows.Count = 0 Then Return
        _Cbb.Visible = True
        CyberFill.V_FillComBoxDefaul(_Cbb, _Dt, _Field, _Name, _FieldDefault)
    End Sub
    Private Sub V_AddHandler()
        AddHandler TxtTG_SC.Leave, AddressOf V_TG_SC
        AddHandler TxtNgay_BD.Leave, AddressOf V_Ngay_BD
        AddHandler TxtNgay_KT.Leave, AddressOf V_Ngay_KT
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub

    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Xe.Text.Trim = "" Then
            TxtTen_HS.Text = ""
            txtten_Kx.Text = ""
            txtTen_Mau.Text = ""
            txtOng_Ba.Text = ""
            TxtMa_HD.Text = ""
            TxtDien_Thoai.Text = ""
            Return
        End If
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_PDS_F3_Load_So_khung", TxtMa_Xe.Text.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(0).Columns.Contains("ten_kh") Then TxtTen_KH.Text = Dstmp.Tables(0).Rows(0).Item("Ten_kh")
        If Dstmp.Tables(0).Columns.Contains("ten_Hs") Then TxtTen_HS.Text = Dstmp.Tables(0).Rows(0).Item("ten_Hs")
        If Dstmp.Tables(0).Columns.Contains("ten_Kx") Then txtten_Kx.Text = Dstmp.Tables(0).Rows(0).Item("ten_Kx")
        If Dstmp.Tables(0).Columns.Contains("ten_Mau") Then txtTen_Mau.Text = Dstmp.Tables(0).Rows(0).Item("ten_Mau")
        If Dstmp.Tables(0).Columns.Contains("Ong_ba") Then txtOng_Ba.Text = Dstmp.Tables(0).Rows(0).Item("Ong_ba")
        If Dstmp.Tables(0).Columns.Contains("Ma_HD") Then TxtMa_HD.Text = Dstmp.Tables(0).Rows(0).Item("Ma_HD")

        If Dstmp.Tables(0).Columns.Contains("Ngay_CT") Then TxtNgay_Ct.Value = Dstmp.Tables(0).Rows(0).Item("Ngay_CT")
        If Dstmp.Tables(0).Columns.Contains("Ngay_Gx") Then TxtNgay_Gx.Value = Dstmp.Tables(0).Rows(0).Item("Ngay_Gx")


    End Sub

    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        If TxtMa_Xe.Text.Trim = "" Then
            TxtMa_Xe.Focus()
            Return
        End If
        '-----------------------------------------------------------------------------------------------------------------
        Dim _StrV As String = ""
        Dim _StrF As String = ""
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        Dim _Ma_Xe As String = TxtMa_Xe.Text
        Dim _Ma_Khoang As String = CyberWork.V_GetvalueCombox(CbbMa_khoang)
        '-----------------------------------------------------------------------------------------------------------------
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_PDS_F3_Save", M_Mode + "#" + _Ma_Xe + "#" + TxtStt_Rec.Text + "#" + _Ma_Khoang + "#" + _Ngay_BD.ToString("yyyyMMdd HH:mm") + "#" + _Ngay_KT.ToString("yyyyMMdd HH:mm") + "#" + _StrF + "#" + _StrV + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then Return
        Dt_Return = DsTmp.Tables(0).Copy
        '----------------------------------------------------------------------------------
        Me.Save_OK = True
        Me.Close()
        '----------------------------------------------------------------------------------
    End Sub
#Region "Thoi gian"
    Private Sub V_TG_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        If TxtTG_SC.Double <= 0 Then TxtTG_SC.Double = 5
        ' If Not (TxtTG_SC.Double = 5 Or TxtTG_SC.Double = 10 Or TxtTG_SC.Double = 15 Or TxtTG_SC.Double = 20 Or TxtTG_SC.Double = 25 Or TxtTG_SC.Double = 30) Then TxtTG_SC.Double = 5
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
End Class
