Public Class FAThoiKHF3
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
    Private Sub FAThoiKHF3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()
        '-------------------------------------------------------------------
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ChkThoi_Kh.CheckedChanged, AddressOf V_Thoi_Kh
        '-------------------------------------------------------------------
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ChkThoi_Kh.CheckedChanged, AddressOf V_Thoi_Kh
        '-------------------------------------------------------------------
        If ChkThoi_Kh.Checked Then TxtNgay_Thoi.Enabled = True Else TxtNgay_Thoi.Enabled = False
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        CyberSmodb.SetValueTObj(Me, Drv)
        TxtTen_ts.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Ts", "DmTs", "(Ma_Ts= N'" + Txtma_Ts.Text.Trim + "')", CyberSmlib)
        TxtTen_NV.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_NV", "DmNV", "(Ma_NV= N'" + TxtMa_NV.Text.Trim + "')", CyberSmlib)

    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Dim _ma_Ts As String = Drv.Item("Ma_Ts").ToString.Trim
        Dim _ma_NV As String = Drv.Item("Ma_NV").ToString.Trim
        Dim _Stt0 As String = Drv.Item("Stt0").ToString.Trim

        Dim _Ngay_Ct As Date = TxtNgay_Thoi.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_FaThoiKhUpdate", _Ngay_Ct.ToString("yyyyMMdd") + "#" + If(ChkThoi_Kh.Checked, "1", "0") + "#" + _ma_Ts + "#" + _ma_NV + "#" + _Stt0 + "#" + txtLy_do.Text.Trim.Replace("'", "").Replace("#", "") + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, Me.Lan)
        If DsTmp.Tables(0).Rows(0).Item("Status") = "N" Then
            Exit Sub
        End If
        Dim _DvReturn As DataView
        _DvReturn = New DataView(DsTmp.Tables(1).Copy)

        Drv = _DvReturn.Item(0)
        Me.Save_OK = True
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
    Private Sub V_Thoi_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkThoi_Kh.Checked Then TxtNgay_Thoi.Enabled = True Else TxtNgay_Thoi.Enabled = False
        If ChkThoi_Kh.Checked Then
            Dim _Dt As Date = TxtNgay_Thoi.Value
            If _Dt.ToString("yyyyMMdd") = "19000101" Then TxtNgay_Thoi.Value = Now.Date
        End If
    End Sub

End Class
