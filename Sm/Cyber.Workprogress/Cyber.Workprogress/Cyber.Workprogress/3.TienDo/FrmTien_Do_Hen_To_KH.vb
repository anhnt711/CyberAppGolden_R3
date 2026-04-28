Public Class FrmTien_Do_Hen_To_KH
#Region "AddProperty"
    Dim CyberWork As New Sys
    Dim CyberColor As New Cyber.Color.Sys
    Public M_So_Ro_Return As String = ""
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
    Dim M_Loai_SC As String = "1"
    Public Property Loai_SC As String
        Get
            Loai_SC = M_Loai_SC
        End Get
        Set(ByVal Value As String)
            M_Loai_SC = Value
        End Set
    End Property
    Dim M_Stt_Rec_hen As String = "1"
    Public Property Stt_Rec_hen() As String
        Get
            Stt_Rec_hen = M_Stt_Rec_hen
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec_hen = Value
        End Set
    End Property
    Dim M_So_RO As String = ""
    Public Property So_Ro() As String
        Get
            So_Ro = M_So_RO
        End Get
        Set(ByVal Value As String)
            M_So_RO = Value
        End Set
    End Property
#End Region
    Private Sub FFF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_LoadDatabase()
        CyberSupport.Translaste(Me, M_LAN, True)
        AddHandler TxtSo_Ro.Leave, AddressOf L_So_RO
        AddHandler ButtOK.Click, AddressOf V_Nhan
        Me.Text = "Chọn lệnh"
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_LoadDatabase()
        '---- Tim So_Ro goi nho
        Dim DstmpRo As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Hen_To_KH_GetRO", M_Kieu_Xem + "#" + M_Loai_SC + "#" + TxtSo_Ro.Text.Trim + "#" + M_Stt_Rec_hen.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If DstmpRo.Tables.Count > 0 Then
            If DstmpRo.Tables(0).Rows.Count > 0 Then
                If DstmpRo.Tables(0).Columns.Contains("So_Ro") Then TxtSo_Ro.Text = DstmpRo.Tables(0).Rows(0).Item("So_Ro").ToString.Trim Else TxtSo_Ro.Text = ""
                If DstmpRo.Tables(0).Columns.Contains("Ma_Xe") Then TxtMa_Xe.Text = DstmpRo.Tables(0).Rows(0).Item("Ma_Xe").ToString.Trim Else TxtMa_Xe.Text = ""
            End If
        End If
        If TxtSo_Ro.Text = "" Then
            TxtMa_Xe.Text = ""
            Return
        End If
    End Sub
    Private Sub L_So_RO(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtSo_Ro.Text.Trim = "" Then
            TxtMa_Xe.Text = ""
            Return
        End If
        Dim _Dt As Date = Now.Date
        _Dt = Now.Date

        TxtSo_Ro.Text = CyberVoucher.V_FormatSo_Ro(AppConn, Me.Sysvar, "HDK", "S", "S", _Dt, TxtSo_Ro.Text, M_Ma_TTCP, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        V_LoadDatabase()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If TxtSo_Ro.Text.Trim = "" Then
            Return
        End If
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = TxtSo_Ro.Text.Trim.Replace(" ", "")
        CyberSmlib.FlushMemorySave()
        M_So_Ro_Return = TxtSo_Ro.Text.Trim.Replace(" ", "")
        Me.Close()
    End Sub
End Class
