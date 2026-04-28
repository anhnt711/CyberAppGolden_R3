Imports System.Windows.Forms
Public Class Ro_Up_Hang_F3
#Region "AddProperty"
    Dim CyberCalculatorUserControlMa_CH As Cyber.Calculator.UserControlMa_CH
    Dim CyberCalculator As New Cyber.Calculator.Sys
#End Region
#Region "Declare "
    'Dim M_Dr_Return As DataRow
    'Dim ListPanel As New List(Of Panel)
    Dim M_Loai As String = "DV"
    Dim M_Ma_Loai As String = "99"
    Dim M_Drv As DataRowView
    Dim M_Dt_LL, M_Dt_Goi, M_Dt_GX, M_Dt_Status As DataTable
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
#End Region
    'Dim _Ma_Loai As String = "10"
    'Dim _Loai As String = "RO"
    Dim _Dt_HTLL As DataTable
    Public Property Drv() As DataRowView
        Get
            Drv = M_Drv
        End Get
        Set(ByVal Value As DataRowView)
            M_Drv = Value
        End Set
    End Property
    Dim _Stt_rec As String = ""
    Private Sub Ro_Up_Hang_F3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_Addhander()
        SetTxt()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        M_Bar = Para(11).Trim
        Me.Text = M_Bar.ToString.Trim

    End Sub
    Private Sub V_Load()
        _Stt_rec = Drv.Item("Stt_rec").ToString.Trim
        CyberSmodb.SetValueTObj(Me, Drv)
    End Sub

    Private Sub V_Addhander()
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
    Private Sub SetTxt()
        TxtSo_Km.Enabled = False
        TxtSo_Ro.Enabled = False

        TxtTen_Kx.Enabled = False
        TxtTen_Mau.Enabled = False
        TxtSo_Khung.Enabled = False
        TxtSo_May.Enabled = False

        TxtMa_xe.Enabled = False
        txtTen_kh.Enabled = False

        TxtDia_Chi.Enabled = False
        txtma_So_Thue.Enabled = False
        txtTen_Lx.Enabled = False
        txtDien_Thoai.Enabled = False
        TxtDt_LX.Enabled = False
        txtDien_giai.Enabled = False

    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        '----------------------------------------------------------------------------------------------------------------
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Ro_Up_Hang_Save", _Stt_rec & "#" & TxtSo_Ro_Hang.Text & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsTmp.Tables(0).Rows.Count > 0 Then
            If DsTmp.Tables(0).Rows(0)("Status").ToString.Trim.ToUpper = "N" Then
                MsgBox(DsTmp.Tables(0).Rows(0)("NOTE").ToString.Trim, MsgBoxStyle.Critical, Sysvar("M_CYBER_VER"))
                Exit Sub
            End If
        End If
        CyberSmlib.FlushMemorySave()
        Me.Save_OK = True
        Me.Close()
    End Sub
End Class
