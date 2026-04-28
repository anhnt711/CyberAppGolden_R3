Public Class ROCLOSE
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtMa_CT As DataTable
    Dim _P1, _P2 As String
    Private Sub ROCLOSE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        _P1 = Me.Para(Me.M_VT_PARA + 2).ToUpper.Trim
        _P2 = Me.Para(Me.M_VT_PARA + 3).ToUpper.Trim

        _P1 = _P1.Replace(" ", "")
        _P1 = _P1.Replace(",", "','")
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT Ma_Ct,Ten_Ct,Ten_Ct FROM dbo.Dmct WHERE Ma_CT IN ('" & _P1 & "')" & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        DtMa_CT = DsTmp.Tables(0).Copy
        CyberFill.V_FillComBoxValue(CmbbMa_CT, DtMa_CT, "Ma_CT", IIf(Me.Lan = "V", "Ten_Ct", "Ten_Ct"), _P2)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim Dt2 As Date = TxtM_Ngay_Ct2.Value

        Dim M_strParameterStore As String = Dt1.ToString("yyyyMMdd") & "#" & Dt2.ToString("yyyyMMdd").Trim
        M_strParameterStore = M_strParameterStore & "#" & CmbbMa_CT.SelectedValue.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name.Trim
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub

End Class
