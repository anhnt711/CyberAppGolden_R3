Imports System.Windows.Forms
Public Class FrmVOD_XLKN_User
    Dim M_Stt_Rec As String = "", M_Stt_Rec0 As String = "", M_Ma_Hs_PT As String = "", M_Ten_Hs_PT As String = "", M_Mode As String = "", M_Row As DataRow = Nothing
    Public Property Stt_Rec() As String
        Get
            Stt_rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
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
    Public Property Ma_Hs_PT() As String
        Get
            Ma_Hs_PT = M_Ma_Hs_PT
        End Get
        Set(ByVal Value As String)
            M_Ma_Hs_PT = Value
        End Set
    End Property
    Public Property Ten_Hs_PT() As String
        Get
            Ten_Hs_PT = M_Ten_Hs_PT
        End Get
        Set(ByVal Value As String)
            M_Ten_Hs_PT = Value
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
    Private Sub FrmVOD_XLKN_User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan

        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs        
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        If M_Ma_Hs_PT <> "" Then
            TxtMa_Hs.Text = M_Ma_Hs_PT
            TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Hs", "DmHs", "Ma_Hs = N'" & TxtMa_Hs.Text.Trim & "'", CyberSmlib)
        End If
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_VOD_XLKN_ChangeUser", Stt_Rec & "#" & Stt_Rec0 & "#" & TxtMa_Hs.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name.Trim)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Return
        End If
        Ma_Hs_PT = TxtMa_Hs.Text
        Ten_Hs_PT = TxtTen_Hs.Text
        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(M_LAN, Para, Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
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
