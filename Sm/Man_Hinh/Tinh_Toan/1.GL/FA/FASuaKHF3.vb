Public Class FASUAKHF3
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
    Dim DtThang1, DtThang2, DtNam As DataTable

    Private Sub FASUAKHF3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        CyberSmodb.SetValueTObj(Me, Drv)
        TxtTen_loai.Text = CyberSmodb.SQLGetvalue(AppConn, "ten_Loai", "DmPlts", "(Ma_Loai= N'" + TxtMa_Loai.Text.Trim + "')", CyberSmlib)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        Dim _ma_Ts As String = Drv.Item("Ma_Ts").ToString.Trim
        Dim _ma_NV As String = Drv.Item("Ma_NV").ToString.Trim
        Dim _Stt0 As String = Drv.Item("Stt0").ToString.Trim
        Dim _Ngay_Ct As Date = Drv.Item("Ngay_Ct")

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_FaSuaKhUpdate", _Ngay_Ct.ToString("yyyyMMdd") + "#" + If(ChkSua_Kh.Checked, "1", "0") + "#" + TxtGt_kh.Double.ToString.Trim.Replace(" ", "").Replace(",", ".") + "#" + _ma_Ts + "#" + _ma_NV + "#" + _Stt0 + "#" + M_Ma_Dvcs + "#" + M_User_name)
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
End Class
