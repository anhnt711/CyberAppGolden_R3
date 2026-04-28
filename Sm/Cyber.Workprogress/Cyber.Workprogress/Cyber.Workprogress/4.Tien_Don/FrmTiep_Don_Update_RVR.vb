Public Class FrmTiep_Don_Update_RVR
    Dim M_Kieu_Xem As String = "KH"
    Dim CyberProgress As New Sys
    Dim CyberColor As New Cyber.Color.Sys
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
    Dim M_Stt_rec As String = ""
    Public Property Stt_rec As String
        Get
            Stt_rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
        End Set
    End Property
    Dim M_Ma_Xe As String = ""
    Public Property Ma_Xe As String
        Get
            Ma_Xe = M_Ma_Xe
        End Get
        Set(ByVal Value As String)
            M_Ma_Xe = Value
        End Set
    End Property
    Private Sub FrmTiep_Don_Update_RVR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        Me.Text = IIf(M_LAN = "V", "Cập nhật thông tin xe vào", "Update information Car")
        V_Load()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub V_Load()
        Dim DstmpRVR As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_Load_RVR", M_Ma_Xe & "#" & M_Stt_rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        CyberSmodb.SetValueTObj(Me, DstmpRVR.Tables(0).Rows(0))
        DstmpRVR.Dispose()

        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------------------------------------------
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        '-----------------------------------------------------------------------------------------------------------------
        Dim _Ma_Xe As String = TxtMa_Xe.Text.Trim
        Dim _Is_SCC As String = IIf(ChkSCC.Checked = True, 1, 0).ToString.Trim
        Dim _Is_SBD As String = IIf(ChkSBD.Checked = True, 1, 0).ToString.Trim
        Dim _Is_SDS As String = IIf(ChkSDS.Checked = True, 1, 0).ToString.Trim

        Dim DsTmp_Up As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_Update_RVR", M_Stt_rec.Trim & "#" & _Ma_Xe.Trim & "#" & _Is_SCC.Trim & "#" & _Is_SBD.Trim & "#" & _Is_SDS.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmp_Up.Tables(0), Me.Sysvar, M_LAN)
        If Not _Return Then
            Me.Save_OK = False
            DsTmp_Up.Dispose()
            Return
        End If
        Me.Save_OK = True
        Me.Close()
    End Sub
End Class
