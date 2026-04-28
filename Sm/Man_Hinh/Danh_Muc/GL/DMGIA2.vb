Public Class DMGIA2
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FSysList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_Vt.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_ban.Value = Now.Date
        End If

        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_KH1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_KH2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_KH3.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_KH4.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKh", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_KH5.Text.Trim + "')", CyberSmlib)

        TxtTen_vt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Vt", "DmVt", "(Ma_Vt = N'" + TxtMa_Vt.Text.Trim + "')", CyberSmlib)
        If TxtMa_Kho.Text.Trim = "" Then TxtTen_Kho.Text = "" Else TxtTen_Kho.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_Kho.Text.Trim + "')", CyberSmlib)
        TxtTen_DB.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_db", "Dmdb", "(Ma_db = N'" + TxtMa_DB.Text.Trim + "')", CyberSmlib)
        If TxtMa_KH.Text.Trim.Trim = "" Then TxtTen_KH.Text = "" Else TxtTen_KH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kh", "Dmkh", "(Ma_kh = N'" + TxtMa_KH.Text.Trim + "')", CyberSmlib)

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '-Ma_VT
        RemoveHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_Vt
        RemoveHandler TxtMa_Vt.CyberLeave, AddressOf L_Ma_Vt
        AddHandler TxtMa_Vt.CyberValiting, AddressOf V_Ma_Vt
        AddHandler TxtMa_Vt.CyberLeave, AddressOf L_Ma_Vt

        '-Ma_Kho
        RemoveHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_kho
        RemoveHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_kho
        AddHandler TxtMa_Kho.CyberValiting, AddressOf V_Ma_kho
        AddHandler TxtMa_Kho.CyberLeave, AddressOf L_Ma_kho

        '-Ma_db
        RemoveHandler TxtMa_DB.CyberValiting, AddressOf V_Ma_db
        RemoveHandler TxtMa_DB.CyberLeave, AddressOf L_Ma_db
        AddHandler TxtMa_DB.CyberValiting, AddressOf V_Ma_db
        AddHandler TxtMa_DB.CyberLeave, AddressOf L_Ma_db

        '-Ma_KH
        RemoveHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_KH
        RemoveHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_KH
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
        '--KH4
        RemoveHandler TxtNh_KH4.CyberValiting, AddressOf V_NH_KH4
        RemoveHandler TxtNh_KH4.CyberLeave, AddressOf L_NH_KH4
        AddHandler TxtNh_KH4.CyberValiting, AddressOf V_NH_KH4
        AddHandler TxtNh_KH4.CyberLeave, AddressOf L_NH_KH4
        '--KH5
        RemoveHandler TxtNh_KH5.CyberValiting, AddressOf V_NH_KH5
        RemoveHandler TxtNh_KH5.CyberLeave, AddressOf L_NH_KH5
        AddHandler TxtNh_KH5.CyberValiting, AddressOf V_NH_KH5
        AddHandler TxtNh_KH5.CyberLeave, AddressOf L_NH_KH5

        RemoveHandler TxtMa_Vt.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Vt.KeyPress, AddressOf TxtCodeError_KeyPress



    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Vt"
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Vt.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Vt", "DmVt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Vt.Text = "" Then
            TxtTen_vt.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Vt.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vt.Text = DrReturn.Item("Ma_Vt")
            TxtTen_vt.Text = DrReturn.Item("Ten_Vt")
        Else
            TxtMa_Vt.Text = ""
            TxtTen_vt.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_kho"
    Private Sub V_Ma_kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kho.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kho", "Dmkho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kho.Text = "" Then
            TxtTen_Kho.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kho.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_Kho.Text = DrReturn.Item("Ten_kho")
        Else
            TxtMa_Kho.Text = ""
            TxtTen_Kho.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_db"
    Private Sub V_Ma_db(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_DB.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_db", "Dmdb", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_db(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_DB.Text = "" Then
            TxtTen_DB.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_DB.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_DB.Text = DrReturn.Item("Ma_db")
            TxtTen_DB.Text = DrReturn.Item("Ten_db")
        Else
            TxtMa_DB.Text = ""
            TxtTen_DB.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_KH"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_KH", "DmKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_KH.Text = "" Then
            TxtTen_KH.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_KH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KH.Text = DrReturn.Item("Ma_KH")
            TxtTen_KH.Text = DrReturn.Item("Ten_KH")
        Else
            TxtMa_KH.Text = ""
            TxtTen_KH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH1"
    Private Sub V_NH_KH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_KH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_KH1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_KH1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH2"
    Private Sub V_NH_KH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_KH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_KH2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_KH2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH3"
    Private Sub V_NH_KH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_KH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_KH3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_KH3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH4"
    Private Sub V_NH_KH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_KH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_KH4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_KH4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KH5"
    Private Sub V_NH_KH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KH5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKH", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_KH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_KH5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_KH5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KH5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KH5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Txtgia2.Double = TxtGia_nt2.Double
        TxtGia3.Double = TxtGia_nt3.Double
        TxtGia.Double = TxtGia_NT.Double

        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
        CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_UpdateDmVtAndDmGia2", "2" & "#" & Mode & "#" & TxtMa_Vt.Text.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name)
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

End Class
