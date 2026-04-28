Public Class ARAPTTPBLOC
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub ARAPTTPBLOC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        '--TK
        AddHandler TxtM_Tk_CN.CyberValiting, AddressOf V_Tk
        AddHandler TxtM_Tk_CN.CyberLeave, AddressOf L_Tk
        '--TK
        AddHandler TxtM_Ma_kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtM_Ma_kh.CyberLeave, AddressOf L_Ma_KH
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtM_Ngay_Ct2)
        Try
            TxtM_Tk_CN.Text = Me.Para(Me.M_VT_PARA + 3).ToString.Trim
        Catch ex As Exception
        End Try
        Try
            TxtM_Ma_kh.Text = Me.Para(Me.M_VT_PARA + 4).ToString.Trim
        Catch ex As Exception
        End Try

        If TxtM_Ma_kh.Text = "" Then TxtM_Ma_kh.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtM_Ma_kh)
        If TxtM_Tk_CN.Text.Trim = "" Then TxtM_Tk_CN.Text = CyberSmlib.GetKeyValueRegistry(Me.Sysvar, TxtM_Tk_CN)

        If TxtM_Tk_CN.Text.Trim = "" Then Txtten_Tk_CN.Text = "" Else Txtten_Tk_CN.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tk0", "Dmtk0", "Tk0 = N'" + TxtM_Tk_CN.Text.Trim + "'", CyberSmlib)
        If TxtM_Ma_kh.Text.Trim = "" Then TxtTen_KH.Text = "" Else TxtTen_KH.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kh", "DmKh", "Ma_Kh = N'" + TxtM_Ma_kh.Text.Trim + "'", CyberSmlib)
    End Sub
#Region "Valid --- Tk"
    Private Sub V_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtM_Tk_CN.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Tk", "DmTKCN", "1=1", "1=1")
    End Sub
    Private Sub L_Tk(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtM_Tk_CN.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtM_Tk_CN.Text = DrReturn.Item("Tk")
            Txtten_Tk_CN.Text = DrReturn.Item("Ten_TK")
        Else
            TxtM_Tk_CN.Text = ""
            Txtten_Tk_CN.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtM_Ma_kh.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtM_Ma_kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtM_Ma_kh.Text = DrReturn.Item("Ma_kh")
            TxtTen_KH.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtM_Ma_kh.Text = ""
            TxtTen_KH.Text = ""
            Exit Sub
        End If
    End Sub
#End Region

    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        If TxtM_Tk_CN.Text.Trim = "" Then
            TxtM_Tk_CN.Focus()
            Exit Sub
        End If
        Dim M_strParameterStore As String = ""
        Dim _Ngay1 As Date = TxtM_Ngay_Ct1.Value
        Dim _Ngay2 As Date = TxtM_Ngay_Ct2.Value
        M_strParameterStore = "1" + "#" + "" + "#" + TxtM_Tk_CN.Text + "#" + TxtM_Ma_kh.Text + "#" + _Ngay1.ToString("yyyyMMdd") + "#" + _Ngay2.ToString("yyyyMMdd") + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Me.Tag = M_strParameterStore
        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
End Class
