Public Class FAGiamTsF3VAT
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
    Private Sub FAGiamTsF3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()
        '-------------------------------------------------------------------
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ChkGiam_Ts.CheckedChanged, AddressOf V_Giam_TS
        RemoveHandler TxtMa_Giam.CyberValiting, AddressOf V_Ma_Giam
        RemoveHandler TxtMa_Giam.CyberLeave, AddressOf L_Ma_Giam

        '-------------------------------------------------------------------
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ChkGiam_Ts.CheckedChanged, AddressOf V_Giam_TS
        AddHandler TxtMa_Giam.CyberValiting, AddressOf V_Ma_Giam
        AddHandler TxtMa_Giam.CyberLeave, AddressOf L_Ma_Giam

        '-------------------------------------------------------------------
        V_Giam_TS(New System.Object, New System.EventArgs)
        CyberSupport.Translaste(Me, M_LAN, True)
        Me.Text = Me.Text + " - Finance"
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        CyberSmodb.SetValueTObj(Me, Drv)
        TxtTen_ts.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Ts", "DmTsVAT", "(Ma_Ts= N'" + Txtma_Ts.Text.Trim + "')", CyberSmlib)
        TxtTen_NV.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_NV", "DmNV", "(Ma_NV= N'" + TxtMa_NV.Text.Trim + "')", CyberSmlib)
        TxtTen_Giam.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Tg_Ts", "DmTgTS", "(Ma_Tg_Ts= N'" + TxtMa_Giam.Text.Trim + "')", CyberSmlib)

    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkGiam_Ts.Checked Then
            If TxtMa_Giam.Text.Trim = "" Then
                TxtMa_Giam.Focus()
                Exit Sub
            End If
            If txtSo_ct.Text.Trim = "" Then
                txtSo_ct.Focus()
                Exit Sub
            End If
            If txtLy_do.Text.Trim = "" Then
                txtLy_do.Focus()
                Exit Sub
            End If
            Dim _Dt As Date = TxtNgay_Giam.Value
            If _Dt.ToString("yyyyMMdd") = "19000101" Then
                TxtNgay_Giam.Focus()
                Exit Sub
            End If
        End If

        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Dim _ma_Ts As String = Drv.Item("Ma_Ts").ToString.Trim
        Dim _ma_NV As String = Drv.Item("Ma_NV").ToString.Trim
        Dim _Stt0 As String = Drv.Item("Stt0").ToString.Trim

        Dim _Ngay_Ct As Date = TxtNgay_Giam.Value



        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_FaGiamTsUpdateVAT", _Ngay_Ct.ToString("yyyyMMdd") + "#" + If(ChkGiam_Ts.Checked, "1", "0") + "#" + _ma_Ts + "#" + _ma_NV + "#" + _Stt0 + "#" + TxtMa_Giam.Text + "#" + txtSo_ct.Text.Trim + "#" + txtLy_do.Text.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)
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
    Private Sub V_Giam_TS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkGiam_Ts.Checked Then
            TxtNgay_Giam.Enabled = True
            TxtMa_Giam.Enabled = True
            txtSo_ct.Enabled = True
            txtLy_do.Enabled = True
        Else
            TxtNgay_Giam.Enabled = False
            TxtMa_Giam.Enabled = False
            txtSo_ct.Enabled = False
            txtLy_do.Enabled = False
        End If
        '----------------------------------------------------------------
        If ChkGiam_Ts.Checked Then
            Dim _Dt As Date = TxtNgay_Giam.Value
            If _Dt.ToString("yyyyMMdd") = "19000101" Then TxtNgay_Giam.Value = Now.Date
        End If
    End Sub
#Region "Valid --- Ma_Giam"
    Private Sub V_Ma_Giam(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Giam.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Tg_ts", "DmTgts", "Loai_Tg_TS= N'G'", "1=1")
    End Sub
    Private Sub L_Ma_Giam(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Giam.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Giam.Text = DrReturn.Item("Ma_Tg_ts")
            TxtTen_Giam.Text = DrReturn.Item("Ten_Tg_Ts")
        Else
            TxtMa_Giam.Text = ""
            TxtTen_Giam.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
End Class

