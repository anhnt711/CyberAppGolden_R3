Imports System.Windows.Forms
Public Class FrmVOD_XLTM_F4
    Dim M_Stt_Rec As String = "", M_Stt_Rec0 As String = "", M_Stt_Rec0VOD As String = "", M_Mode As String = "", M_Row As DataRow = Nothing
    Public Property Stt_Rec() As String
        Get
            Stt_Rec = M_Stt_Rec
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec = Value
        End Set
    End Property
    Public Property Stt_Rec0() As String
        Get
            Stt_Rec0 = M_Stt_Rec0
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec0 = Value
        End Set
    End Property
    Public Property Stt_Rec0VOD() As String
        Get
            Stt_Rec0VOD = M_Stt_Rec0VOD
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec0VOD = Value
        End Set
    End Property
    Public Property Mode() As String
        Get
            Mode = M_Mode
        End Get
        Set(ByVal Value As String)
            M_Mode = Value
        End Set
    End Property
    Public Property Row() As DataRow
        Get
            Row = M_Row
        End Get
        Set(ByVal Value As DataRow)
            M_Row = Value
        End Set
    End Property
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable
    Private Sub FrmVOD_XLKN_F4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtNgay_GQ.KeyDown, AddressOf EnterasTab
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        If Mode = "M" Then
            TxtNgay_GQ.Value = Now.Date.AddHours(Now.Hour).AddMinutes(Now.Minute)
            TxtNgay_Lap.Value = Now.Date.AddHours(Now.Hour).AddMinutes(Now.Minute)
        Else
            Dim dt As Date
            dt = M_Row.Item("Ngay_GQ")
            TxtNgay_GQ.Value = dt
            TxtNgay_Lap.Value = M_Row.Item("Ngay_Lap")
            TxtDien_Giai.Text = M_Row.Item("Dien_Giai").ToString
            TxtKet_Qua.Text = M_Row.Item("Ket_Qua").ToString
            TxtUser_Id.Text = M_Row.Item("User_ID").ToString
        End If
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strFiled = "", strValues As String = "", nCount As Integer = 0, nKey As Integer = 0
        Dim Dt As Date = TxtNgay_GQ.Value
        CyberSmodb.GetValueControler(Me, strFiled, strValues, "")

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_VOD_XLKN_Save", Mode & "#" & Stt_Rec & "#" & Stt_Rec0 & "#" & Stt_Rec0VOD & "#" & strFiled & "#" & strValues & "#" & Dt.ToString("yyyyMMdd HH:mm").Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name.Trim)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Return
        End If
        If DsTmp.Tables.Count < 2 Then
            DsTmp.Dispose()
            Return
        End If
        Me.Save_OK = True
        M_Row = DsTmp.Tables(1).Rows(0)

        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#Region "Support"
    Private Sub EnterasTab(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
#End Region
End Class
