Public Class CRMDMHTLL
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa As DataTable
    Private _Load_TP As Boolean = False
    Private Sub FDMKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load_TP = False
        V_GetChkErro()

        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_Loai.Text = CyberSmodb.SQLGetvalue(Appconn, "CrmTen_Loai", "CRMDmLoai", "CrmMa_Loai = N'" + Txtma_Loai.Text.Trim + "'", CyberSmlib)
        'TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtMa_Ve.Text.Trim + "')", CyberSmlib)
        'TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtTen_ve.Text.Trim + "')", CyberSmlib)
        'TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtDvt.Text.Trim + "')", CyberSmlib)
        'TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_ve1.Text.Trim + "')", CyberSmlib)
        'TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_ve2.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        '--Ma_Loai
        RemoveHandler Txtma_Loai.CyberValiting, AddressOf V_ma_Loai
        RemoveHandler Txtma_Loai.CyberLeave, AddressOf L_Ma_Loai
        AddHandler Txtma_Loai.CyberValiting, AddressOf V_ma_Loai
        AddHandler Txtma_Loai.CyberLeave, AddressOf L_Ma_Loai
    End Sub

    'Protected Overrides Sub V_GetValueParameter()
    '    MyBase.V_GetValueParameter()
    'End Sub
#End Region
#Region "Valid"
#Region "Vali --- ma_Loai"
    Private Sub V_ma_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Txtma_Loai.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "CrmMa_Loai", "CRMDmLoai", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = Txtma_Loai.GetRowsSelectData(True)
        If Txtma_Loai.Text = "" Then
            TxtTen_Loai.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            Txtma_Loai.Text = DrReturn.Item("CrmMa_Loai")
            TxtTen_Loai.Text = DrReturn.Item("CrmTen_Loai")
        Else
            Txtma_Loai.Text = ""
            TxtTen_Loai.Text = ""
        End If
    End Sub
#End Region
#End Region
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    'Private Sub L_Nh_ve2(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    DrReturn = sender.GetRowsSelectData(True)
    '    If Not DrReturn Is Nothing Then
    '        TxtNh_ve2.Text = DrReturn.Item("Ma_Nh")
    '        TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
    '    Else
    '        TxtNh_ve2.Text = ""
    '        TxtTen_Nh2.Text = ""
    '    End If
    'End Sub


    '#Region "Vali --- Ten_KH,Dia_Chi"
    '    Private Sub V_TxtTen_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        txtMa_Tuyen.Text = IIf(txtMa_Tuyen.Text.Trim = "", TxtDinh_muc.Text, txtMa_Tuyen.Text)
    '    End Sub
    '    Private Sub V_TxtDia_Chi(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        TxtMa_Kho.Text = IIf(TxtMa_Kho.Text.Trim = "", txtChieu_Ve.Text, TxtMa_Kho.Text)
    '    End Sub
    '#End Region


    '#Region "Vali --- TK"
    '    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        TxtMa_Chang.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "DMTK", "1=1", "1=1")
    '    End Sub
    '    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        DrReturn = TxtMa_Chang.GetRowsSelectData(True)
    '        If Not DrReturn Is Nothing Then TxtMa_Chang.Text = DrReturn.Item("TK")
    '        If TxtMa_Chang.Text = "" Then Exit Sub
    '    End Sub
    '#End Region
    '#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_HTLL.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
