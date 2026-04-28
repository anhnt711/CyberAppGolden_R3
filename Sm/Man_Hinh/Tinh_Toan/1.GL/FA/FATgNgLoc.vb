Public Class FATgNgLoc

    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub FATgNgLoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtMa_ts.CyberValiting, AddressOf V_Ma_ts
        AddHandler TxtMa_ts.CyberLeave, AddressOf L_Ma_ts

        '--TS1
        RemoveHandler TxtNh_ts1.CyberValiting, AddressOf V_NH_ts1
        RemoveHandler TxtNh_ts1.CyberLeave, AddressOf L_NH_ts1
        AddHandler TxtNh_ts1.CyberValiting, AddressOf V_NH_ts1
        AddHandler TxtNh_ts1.CyberLeave, AddressOf L_NH_ts1
        '--ts2
        RemoveHandler TxtNh_ts2.CyberValiting, AddressOf V_NH_ts2
        RemoveHandler TxtNh_ts2.CyberLeave, AddressOf L_NH_ts2
        AddHandler TxtNh_ts2.CyberValiting, AddressOf V_NH_ts2
        AddHandler TxtNh_ts2.CyberLeave, AddressOf L_NH_ts2
        '--ts3
        RemoveHandler TxtNh_ts3.CyberValiting, AddressOf V_NH_ts3
        RemoveHandler TxtNh_ts3.CyberLeave, AddressOf L_NH_ts3
        AddHandler TxtNh_ts3.CyberValiting, AddressOf V_NH_ts3
        AddHandler TxtNh_ts3.CyberLeave, AddressOf L_NH_ts3
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        TxtMa_ts.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtMa_ts)
        Txtten_ts.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Ts", "DmTs", "(Ma_Ts= N'" + TxtMa_ts.Text.Trim + "')", CyberSmlib)
    End Sub
#Region "Valid"
#Region "Valid --- Ma_ts"
    Private Sub V_Ma_ts(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_ts.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_ts", "Dmts", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_ts(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_ts.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_ts.Text = DrReturn.Item("Ma_ts")
            Txtten_ts.Text = DrReturn.Item("Ten_ts")
        Else
            TxtMa_ts.Text = ""
            Txtten_ts.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Vali --- NH_ts1"
    Private Sub V_NH_ts1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_ts1.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhts", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_ts1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_ts1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ts1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nhts1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ts1.Text = ""
            TxtTen_Nhts1.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- NH_TS2"
    Private Sub V_NH_ts2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_ts2.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhts", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_ts2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_ts2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ts2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nhts2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ts2.Text = ""
            TxtTen_Nhts2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_ts3"
    Private Sub V_NH_ts3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtNh_ts3.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_NH", "DmNhts", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_ts3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtNh_ts3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ts3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nhts3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ts3.Text = ""
            TxtTen_Nhts3.Text = ""
        End If
    End Sub
#End Region
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = "1"
        M_strParameterStore = M_strParameterStore & "#"
        M_strParameterStore = M_strParameterStore & "#"
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_ts.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_ts1.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_ts2.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtNh_ts3.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
End Class
