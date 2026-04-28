Public Class CDBH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim So_Dau_Nam As Boolean = True
    Dim Dt_DmStt As DataTable
    Private Sub CDBH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        txtTon00.Double = 1
        txtTon00.Enabled = True
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtNam.Text = Me.Key_Nam.ToString
        'txtTon00.Text = 1
       
        If TxtMa_BH.Text.Trim = "" Then TxtTen_BH.Text = "" Else TxtTen_BH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_BH", "DmBH", "(Ma_BH = N'" + TxtMa_BH.Text.Trim + "')", CyberSmlib)
        If TxtMa_kho.Text.Trim = "" Then TxtTen_kho.Text = "" Else TxtTen_kho.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_kho.Text.Trim + "')", CyberSmlib)
        If TxtMa_Vitri.Text.Trim = "" Then TxtTen_vitri.Text = "" Else TxtTen_vitri.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_vitri", "Dmvitri", "(Ma_vitri = N'" + TxtMa_Vitri.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If TxtMa_Dvcs.Text.Trim = "" Then TxtTen_Dvcs.Text = "" Else TxtTen_Dvcs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Dvcs", "DmDvcs", "(Ma_Dvcs = N'" + TxtMa_Dvcs.Text.Trim + "')", CyberSmlib)

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        '--Ma_BH

        AddHandler TxtMa_BH.CyberValiting, AddressOf V_Ma_BH
        AddHandler TxtMa_BH.CyberLeave, AddressOf L_Ma_BH
        '--TK

        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Ma_kho
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_MA_Kho
        '---

        AddHandler TxtMa_Vitri.Leave, AddressOf V_Ma_vitri
        AddHandler TxtMa_Vitri.Leave, AddressOf L_Ma_vitri


    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Vali --- ma_BH"
    Private Sub V_Ma_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_BH", "DmBH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BH.Text = DrReturn.Item("Ma_BH")
            TxtTen_BH.Text = DrReturn.Item("Ten_BH")
        Else
            TxtMa_BH.Text = ""
            TxtTen_BH.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- Ma_kho"
    Private Sub V_Ma_kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kho", "Dmkho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_kho.Text = DrReturn.Item("Ten_kho")
        Else
            TxtMa_kho.Text = ""
            TxtTen_kho.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Vitri"
    Private Sub V_MA_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_vitri", "Dmvitri", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vitri.Text = DrReturn.Item("Ma_vitri")
            TxtTen_vitri.Text = DrReturn.Item("Ten_vitri")
        Else
            TxtMa_Vitri.Text = ""
            TxtTen_vitri.Text = ""
        End If
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        If TxtMa_BH.Text.Trim = "" Then
            TxtMa_BH.Focus()
            Exit Sub
        End If
        TxtDu00.Double = TxtDu_NT00.Double
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class