Public Class BHHDLDCLOC
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub BHHDLDCLOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_KH
        '--KH1
        RemoveHandler TxtNh_KH1.CyberValiting, AddressOf V_NH_KH1
        RemoveHandler TxtNh_KH1.CyberLeave, AddressOf L_NH_KH1
        AddHandler TxtNh_KH1.CyberValiting, AddressOf V_NH_KH1
        AddHandler TxtNh_KH1.CyberLeave, AddressOf L_NH_KH1
        '--KH2
        RemoveHandler TxtNh_KH2.CyberValiting, AddressOf V_NH_KH2
        RemoveHandler TxtNh_KH2.CyberLeave, AddressOf L_NH_KH2
        AddHandler TxtNh_KH2.CyberValiting, AddressOf V_NH_KH2
        AddHandler TxtNh_KH2.CyberLeave, AddressOf L_NH_KH2
        '--KH3
        RemoveHandler TxtNh_KH3.CyberValiting, AddressOf V_NH_KH3
        RemoveHandler TxtNh_KH3.CyberLeave, AddressOf L_NH_KH3
        AddHandler TxtNh_KH3.CyberValiting, AddressOf V_NH_KH3
        AddHandler TxtNh_KH3.CyberLeave, AddressOf L_NH_KH3
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        TxtNgay_CT1.Value = Date.Now
        TxtNgay_CT2.Value = Date.Now

        TxtMa_KH.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_KH)
        Txtten_KH.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_KH", "DmKH", "(Ma_KH= N'" + TxtMa_KH.Text.Trim + "')", CyberSmlib)
    End Sub
#Region "Valid"
#Region "Valid --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_KH.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_KH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KH.Text = DrReturn.Item("Ma_KH")
            Txtten_KH.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_KH.Text = ""
            Txtten_KH.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH1"
    Private Sub V_NH_KH1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_KH1.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_KH1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_KH1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_NhKH1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH1.Text = ""
            TxtTen_NhKH1.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- NH_KH2"
    Private Sub V_NH_KH2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_KH2.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_KH2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_KH2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_NhKH2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH2.Text = ""
            TxtTen_NhKH2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH3"
    Private Sub V_NH_KH3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_KH3.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_KH3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_KH3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_NhKH3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH3.Text = ""
            TxtTen_NhKH3.Text = ""
        End If
    End Sub
#End Region
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim _DT1 As Date = TxtNgay_CT1.Value
        Dim _DT2 As Date = TxtNgay_CT2.Value
        Dim M_strParameterStore As String = "1#" & _DT1.ToString("yyyyMMdd") & "#" & _DT2.ToString("yyyyMMdd")
        M_strParameterStore = M_strParameterStore & "#" & TxtLenh_SO.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_KH.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_KH1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_KH2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_KH3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
End Class
