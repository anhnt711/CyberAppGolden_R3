
Public Class DMCHAMCONG
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
        TxtTen_HS.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_HS", "DmHS", "( Ma_HS = N'" + TxtMa_HS.Text.Trim + "')", CyberSmlib)
        'TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtTen_ve.Text.Trim + "')", CyberSmlib)
        'TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtDvt.Text.Trim + "')", CyberSmlib)
        'TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_ve1.Text.Trim + "')", CyberSmlib)
        'TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_ve2.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtTu_Ngay.Value = Now.Date
            TxtDen_Ngay.Value = Now.Date
        End If

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        AddHandler TxtMa_HS.CyberValiting, AddressOf V_Ma_HS
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_Ma_HS
       
       
    End Sub
    'Protected Overrides Sub V_GetValueParameter()
    '    MyBase.V_GetValueParameter()
    'End Sub
#End Region
#Region "Valid"

    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HS", "dmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HS.Text = DrReturn.Item("Ma_HS")
            TxtTen_HS.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_HS.Text = ""
            TxtTen_HS.Text = ""
        End If
    End Sub

#End Region


    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#Region "Vali --- NH_KH4"
    'Private Sub V_Nh_ve2(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    TxtMa_nv.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhve", "1=1", "Loai_Nh='2'")
    'End Sub
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

    '#Region "Vali --- NH_KH1"
    '    Private Sub V_Nh_ve3(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_nh", "DmNhve", "1=1", "Loai_Nh='3'")
    '    End Sub
    '    Private Sub L_Nh_ve3(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        DrReturn = sender.GetRowsSelectData(True)
    '        If Not DrReturn Is Nothing Then
    '            TxtNh_ve3.Text = DrReturn.Item("Ma_Nh")
    '            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
    '        Else
    '            TxtNh_ve3.Text = ""
    '            TxtTen_Nh3.Text = ""
    '        End If
    '    End Sub
#End Region
   
    '#Region "Vali --- NH_KH5"
    '    Private Sub V_NH_KH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        TxtNh_ve2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='5'")
    '    End Sub
    '    Private Sub L_NH_KH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '        DrReturn = TxtNh_ve2.GetRowsSelectData(True)
    '        If Not DrReturn Is Nothing Then
    '            TxtNh_ve2.Text = DrReturn.Item("Ma_Nh")
    '            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
    '        Else
    '            TxtNh_ve2.Text = ""
    '            TxtTen_Nh5.Text = ""
    '        End If
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
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
