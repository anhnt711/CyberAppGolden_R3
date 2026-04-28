Public Class CDLO
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim So_Dau_Nam As Boolean = True
    Dim Dt_DmStt As DataTable
    Private Sub CDKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()


        'TxtNam.Text = Me.Key_Nam.ToString
        If TxtMa_kho.Text.Trim = "" Then TxtTen_kho.Text = "" Else TxtTen_kho.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_kho.Text.Trim + "')", CyberSmlib)
        TxtTen_vt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_vt", "Dmvt", "(Ma_vt = N'" + TxtMa_vt.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs



    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()


        AddHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_vt
        AddHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_vt
        '---

        AddHandler TxtMa_kho.Leave, AddressOf V_MA_kho
        AddHandler TxtMa_kho.Leave, AddressOf L_Ma_kho


    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region

#Region "Vali --- KH"
    Private Sub V_MA_kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_kho", "Dmkho", "1=1", "1=1")
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
#Region "Vali --- TK"
    Private Sub V_Ma_vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt.Text = DrReturn.Item("Ma_vt")
            TxtTen_vt.Text = DrReturn.Item("Ten_vt")
        Else
            TxtMa_vt.Text = ""
            TxtTen_vt.Text = ""
        End If
    End Sub
#End Region


#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class