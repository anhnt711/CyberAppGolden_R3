Public Class IMMatCCF8
    Public Property DtLocSua() As DataTable
        Get
            DtLocSua = M_DtLocSua
        End Get
        Set(ByVal Value As DataTable)
            M_DtLocSua = Value
        End Set
    End Property
    Public Property Drv() As DataRowView
        Get
            Drv = M_Drv
        End Get
        Set(ByVal Value As DataRowView)
            M_Drv = Value
        End Set
    End Property
    Dim M_DtLocSua As DataTable
    Dim M_Drv As DataRowView


    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub IMThoiPBF3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()
        '-------------------------------------------------------------------
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ChkThoi_PB.CheckedChanged, AddressOf V_Thoi_Kh
        '-------------------------------------------------------------------
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ChkThoi_PB.CheckedChanged, AddressOf V_Thoi_Kh
        '-------------------------------------------------------------------
        If ChkThoi_PB.Checked Then TxtNgay_Thoi.Enabled = True Else TxtNgay_Thoi.Enabled = False
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        CyberSmodb.SetValueTObj(Me, Drv)
        TxtTen_CC.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_CC", "DmCc", "(Ma_CC= N'" + Txtma_CC.Text.Trim + "')", CyberSmlib)

    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Dim _ma_CC As String = Drv.Item("Ma_CC").ToString.Trim
        Dim _Stt_Rec As String = Drv.Item("Stt_Rec").ToString.Trim
        Dim _Stt_Rec0 As String = Drv.Item("Stt_Rec0").ToString.Trim

        Dim _Ngay_Ct As Date = TxtNgay_Thoi.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ImMatCCUpdate", _Ngay_Ct.ToString("yyyyMMdd") + "#" + If(ChkThoi_PB.Checked, "1", "0") + "#" + _ma_CC + "#" + _Stt_Rec + "#" + _Stt_Rec0 + "#" + txtLy_do.Text.Trim.Replace("'", "").Replace("#", "") + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, Me.Lan)
        If DsTmp.Tables(0).Rows(0).Item("Status") = "N" Then Exit Sub

        Dim _DvReturn As DataView
        _DvReturn = New DataView(DsTmp.Tables(1).Copy)
        Drv = _DvReturn.Item(0)
        Me.Save_OK = True
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
    Private Sub V_Thoi_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkThoi_PB.Checked Then TxtNgay_Thoi.Enabled = True Else TxtNgay_Thoi.Enabled = False
        If ChkThoi_PB.Checked Then
            Dim _Dt As Date = TxtNgay_Thoi.Value
            If _Dt.ToString("yyyyMMdd") = "19000101" Then TxtNgay_Thoi.Value = Now.Date
        End If
    End Sub

End Class
