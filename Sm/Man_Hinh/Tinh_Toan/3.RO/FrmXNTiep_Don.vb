Public Class FrmXNTiep_Don
    Public Property Stt_rec() As String
        Get
            Return M_Stt_rec
        End Get
        Set(ByVal value As String)
            M_Stt_rec = value
        End Set
    End Property
    Public Property Ma_Xe() As String
        Get
            Return M_Ma_Xe
        End Get
        Set(ByVal value As String)
            M_Ma_Xe = value
        End Set
    End Property
    Public Property Ma_Ct() As String
        Get
            Return M_Ma_Ct
        End Get
        Set(ByVal value As String)
            M_Ma_Ct = value
        End Set
    End Property
    Dim M_Ma_Xe As String = ""
    Dim M_Ma_Ct As String = ""
    Dim M_Stt_rec As String = ""
    Private Sub FrmXNTiep_Don_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_Addhandler()
        Me.Text = "Xác nhận/ giải phóng: Tiếp đón"
        txtma_Xe.Text = M_Ma_Xe

    End Sub
    Private Sub V_Addhandler()
       
        AddHandler ButtOK.Click, AddressOf V_Nhan
       
    End Sub

    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
    End Sub
    
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Xe.Text = "" Then Return
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RoHDXXacNhanTiepDon", TxtMa_Xe.Text + "#" + If(ChkGiai_Phong.Checked, "1", "0") + "#" + M_Stt_rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, Me.Lan) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        DsTmp.Dispose()
        Me.Save_OK = True
        Me.Close()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Me.Close()
    End Sub
End Class
