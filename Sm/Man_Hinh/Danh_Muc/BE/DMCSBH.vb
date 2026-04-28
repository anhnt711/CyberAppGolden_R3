Public Class DMCSBH
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMCSBH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        If TxtNam_Sx.Double = 0 Then TxtNam_Sx.Double = Now.Year
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_Kx.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)

        If Mode.Trim = "S" Then TxtMa_Kx.Enabled = False Else TxtMa_Kx.Enabled = True
        If Mode.Trim = "S" Then TxtMa_Mau.Enabled = False Else TxtMa_Mau.Enabled = True

        TxtMa_CSBH.Enabled = False
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_HL1.Value = Now.Date
            TxtNgay_HL2.Value = Now.Date.AddMonths(1)
            TxtNgay_Gx1.Value = Now.Date
            TxtNgay_Gx2.Value = Now.Date.AddMonths(2)
        End If
        If TxtMa_Kx.Text.Trim = "" Then TxtTen_Kx.Text = "" Else TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kx", "DmKx", "(Ma_Kx = N'" & TxtMa_Kx.Text.Trim & "')", CyberSmlib)
        If TxtMa_Mau.Text.Trim = "" Then TxtTen_Mau.Text = "" Else TxtTen_Mau.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Mau", "DmMauXe", "(Ma_Mau = N'" & TxtMa_Mau.Text.Trim & "')", CyberSmlib)

        TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCSBH", "(Loai_Nh = '1' AND Ma_Nh = N'" & TxtNh_CSBH1.Text.Trim & "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCSBH", "(Loai_Nh = '2' AND Ma_Nh = N'" & TxtNh_CSBH2.Text.Trim & "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCSBH", "(Loai_Nh = '3' AND Ma_Nh = N'" & TxtNh_CSBH3.Text.Trim & "')", CyberSmlib)
        TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCSBH", "(Loai_Nh = '4' AND Ma_Nh = N'" & TxtNh_CSBH4.Text.Trim & "')", CyberSmlib)
        TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCSBH", "(Loai_Nh = '5' AND Ma_Nh = N'" & TxtNh_CSBH5.Text.Trim & "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '-Ma_VT
        RemoveHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        RemoveHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx

        '-Ma_Kho
        RemoveHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        RemoveHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau

        RemoveHandler TxtMa_Kx.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Kx.KeyPress, AddressOf TxtCodeError_KeyPress
        '----
        AddHandler TxtNiem_Yet.Leave, AddressOf V_Niem_yet

        AddHandler TxtTien_NT.Leave, AddressOf V_Tien_NT
        AddHandler TxtTien_NT_Min.Leave, AddressOf V_Tien_NT
        AddHandler TxtTien_NT_Max.Leave, AddressOf V_Tien_NT

        AddHandler TxtBH_BB.Leave, AddressOf V_BH_BB
        AddHandler TxtBH_BB_Min.Leave, AddressOf V_BH_BB
        AddHandler TxtBH_BB_Max.Leave, AddressOf V_BH_BB

        AddHandler TxtPK_BB.Leave, AddressOf V_PK_BB
        AddHandler TxtPK_BB_Min.Leave, AddressOf V_PK_BB
        AddHandler TxtPK_BB_Max.Leave, AddressOf V_PK_BB

        AddHandler TxtKhac_BB.Leave, AddressOf V_Khac_BB
        AddHandler TxtKhac_BB_Min.Leave, AddressOf V_Khac_BB
        AddHandler TxtKhac_BB_Max.Leave, AddressOf V_Khac_BB

        AddHandler TxtCk.Leave, AddressOf V_CK_I
        AddHandler TxtCk_Min.Leave, AddressOf V_CK_I
        AddHandler TxtCk_Max.Leave, AddressOf V_CK_I

        AddHandler TxtKm_PK.Leave, AddressOf V_Km_PK
        AddHandler TxtKm_PK_Min.Leave, AddressOf V_Km_PK
        AddHandler TxtKm_PK_Max.Leave, AddressOf V_Km_PK

        AddHandler TxtMoi_Gioi.Leave, AddressOf V_Moi_Gioi
        AddHandler TxtMoi_Gioi_Min.Leave, AddressOf V_Moi_Gioi
        AddHandler TxtMoi_Gioi_Max.Leave, AddressOf V_Moi_Gioi

        AddHandler TxtKm_Khac.Leave, AddressOf V_Km_Khac
        AddHandler TxtKm_Khac_Min.Leave, AddressOf V_Km_Khac
        AddHandler TxtKm_Khac_Max.Leave, AddressOf V_Km_Khac

        '--CSBH1
        RemoveHandler TxtNh_CSBH1.CyberValiting, AddressOf V_Nh_CSBH1
        RemoveHandler TxtNh_CSBH1.CyberLeave, AddressOf L_Nh_CSBH1
        AddHandler TxtNh_CSBH1.CyberValiting, AddressOf V_Nh_CSBH1
        AddHandler TxtNh_CSBH1.CyberLeave, AddressOf L_Nh_CSBH1
        '--CSBH2
        RemoveHandler TxtNh_CSBH2.CyberValiting, AddressOf V_Nh_CSBH2
        RemoveHandler TxtNh_CSBH2.CyberLeave, AddressOf L_Nh_CSBH2
        AddHandler TxtNh_CSBH2.CyberValiting, AddressOf V_Nh_CSBH2
        AddHandler TxtNh_CSBH2.CyberLeave, AddressOf L_Nh_CSBH2
        '--CSBH3
        RemoveHandler TxtNh_CSBH3.CyberValiting, AddressOf V_Nh_CSBH3
        RemoveHandler TxtNh_CSBH3.CyberLeave, AddressOf L_Nh_CSBH3
        AddHandler TxtNh_CSBH3.CyberValiting, AddressOf V_Nh_CSBH3
        AddHandler TxtNh_CSBH3.CyberLeave, AddressOf L_Nh_CSBH3
        '--CSBH4
        RemoveHandler TxtNh_CSBH4.CyberValiting, AddressOf V_Nh_CSBH4
        RemoveHandler TxtNh_CSBH4.CyberLeave, AddressOf L_Nh_CSBH4
        AddHandler TxtNh_CSBH4.CyberValiting, AddressOf V_Nh_CSBH4
        AddHandler TxtNh_CSBH4.CyberLeave, AddressOf L_Nh_CSBH4
        '--CSBH5
        RemoveHandler TxtNh_CSBH5.CyberValiting, AddressOf V_Nh_CSBH5
        RemoveHandler TxtNh_CSBH5.CyberLeave, AddressOf L_Nh_CSBH5
        AddHandler TxtNh_CSBH5.CyberValiting, AddressOf V_Nh_CSBH5
        AddHandler TxtNh_CSBH5.CyberLeave, AddressOf L_Nh_CSBH5

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#Region "Vali Min_MAX"
    Private Sub V_Niem_Yet(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNiem_Yet.Double = 0 Then TxtNiem_Yet.Double = TxtTien_NT.Double
    End Sub
    Private Sub V_Tien_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTien_NT_Min.Double > TxtTien_NT.Double Then TxtTien_NT_Min.Double = TxtTien_NT.Double
        If TxtTien_NT_Max.Double < TxtTien_NT.Double And TxtTien_NT_Max.Double <> 0 Then TxtTien_NT_Max.Double = TxtTien_NT.Double
        If TxtNiem_Yet.Double = 0 Then TxtNiem_Yet.Double = TxtTien_NT.Double
    End Sub
    Private Sub V_BH_BB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtBH_BB_Min.Double > TxtBH_BB.Double And TxtBH_BB_Min.Double <> 0 Then TxtBH_BB_Min.Double = TxtBH_BB.Double
        If TxtBH_BB_Max.Double < TxtBH_BB.Double And TxtBH_BB_Max.Double <> 0 Then TxtBH_BB_Max.Double = TxtBH_BB.Double
    End Sub
    Private Sub V_PK_BB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtPK_BB_Min.Double > TxtPK_BB.Double And TxtPK_BB_Min.Double <> 0 Then TxtPK_BB_Min.Double = TxtPK_BB.Double
        If TxtPK_BB_Max.Double < TxtPK_BB.Double And TxtPK_BB_Max.Double <> 0 Then TxtPK_BB_Max.Double = TxtPK_BB.Double
    End Sub
    Private Sub V_Khac_BB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtKhac_BB_Min.Double > TxtKhac_BB.Double And TxtKhac_BB_Min.Double <> 0 Then TxtKhac_BB_Min.Double = TxtKhac_BB.Double
        If TxtKhac_BB_Max.Double < TxtKhac_BB.Double And TxtKhac_BB_Max.Double <> 0 Then TxtKhac_BB_Max.Double = TxtKhac_BB.Double
    End Sub
    Private Sub V_CK_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtCk_Min.Double > TxtCk.Double And TxtCk_Min.Double <> 0 Then TxtCk_Min.Double = TxtCk.Double
        If TxtCk_Max.Double < TxtCk.Double And TxtCk_Max.Double <> 0 Then TxtCk_Max.Double = TxtCk.Double
    End Sub
    Private Sub V_Km_PK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtKm_PK_Min.Double > TxtKm_PK.Double And TxtKm_PK_Min.Double <> 0 Then TxtKm_PK_Min.Double = TxtKm_PK.Double
        If TxtKm_PK_Max.Double < TxtKm_PK.Double And TxtKm_PK_Max.Double <> 0 Then TxtKm_PK_Max.Double = TxtKm_PK.Double
    End Sub
    Private Sub V_Moi_Gioi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMoi_Gioi_Min.Double > TxtMoi_Gioi.Double And TxtMoi_Gioi_Min.Double <> 0 Then TxtMoi_Gioi_Min.Double = TxtMoi_Gioi.Double
        If TxtMoi_Gioi_Max.Double < TxtMoi_Gioi.Double And TxtMoi_Gioi_Max.Double <> 0 Then TxtMoi_Gioi_Max.Double = TxtMoi_Gioi.Double
    End Sub
    Private Sub V_Km_Khac(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtKm_Khac_Min.Double > TxtKm_Khac.Double And TxtKm_Khac_Min.Double <> 0 Then TxtKm_Khac_Min.Double = TxtKm_Khac.Double
        If TxtKm_Khac_Max.Double < TxtKm_Khac.Double And TxtKm_Khac_Max.Double <> 0 Then TxtKm_Khac_Max.Double = TxtKm_Khac.Double
    End Sub
#End Region
#Region "Vali --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kx.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kx", "DmKx", "1=1 AND Is_KD = N'1'", " 1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kx.Text = "" Then
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_kx")
            If DrReturn.Table.Columns.Contains("Nam_SX") And TxtNam_Sx.Double = 0 Then
                TxtNam_Sx.Double = DrReturn.Item("Nam_SX")
            End If
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If

        V_GetGiaXeCoso()
        If TxtNam_Sx.Double = 0 Then TxtNam_Sx.Double = Now.Year
    End Sub
    Private Sub V_GetGiaXeCoso()
        Dim _strF As String = ""
        Dim _strV As String = ""
        Dim _Ma_Kx As String = TxtMa_Kx.Text.Trim
        Dim _Ma_Mau As String = TxtMa_Mau.Text
        Dim _Ngay_HL1 As Date = TxtNgay_HL1.Value
        Dim _Ngay_HL2 As Date = TxtNgay_HL2.Value
        CyberSmodb.GetValueControler(Me, _strF, _strV, "Ten_Kx,Ten_Mau")

        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_BECSBHGetGiaCoso", Mode & "#" & _Ma_Kx & "#" & _Ma_Mau & "#" & _
                                                                  _Ngay_HL1.ToString("yyyyMMdd") & "#" & _
                                                                _Ngay_HL2.ToString("yyyyMMdd") & "#" & _
                                                                  _strF & "#" & _strV & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Dstmp.Tables.Count <= 1 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), oSysvar, M_LAN) Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(1).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(1).Columns.Contains("Tien_NT") Then TxtTien_NT.Double = Dstmp.Tables(1).Rows(0).Item("Tien_NT")
        If Dstmp.Tables(1).Columns.Contains("Tien_NT_Min") Then TxtTien_NT_Min.Double = Dstmp.Tables(1).Rows(0).Item("Tien_NT_Min")
        If Dstmp.Tables(1).Columns.Contains("Tien_NT_Max") Then TxtTien_NT_Max.Double = Dstmp.Tables(1).Rows(0).Item("Tien_NT_Max")
        If Dstmp.Tables(1).Columns.Contains("Tien_NT") Then TxtTien_NT.Double = Dstmp.Tables(1).Rows(0).Item("Tien_NT")
        If Dstmp.Tables(1).Columns.Contains("Dat_Coc") Then TxtDat_Coc.Double = Dstmp.Tables(1).Rows(0).Item("Dat_Coc")

        If Dstmp.Tables(1).Columns.Contains("Nam_Sx") Then TxtDat_Coc.Double = Dstmp.Tables(1).Rows(0).Item("Nam_Sx")

        If Dstmp.Tables(1).Columns.Contains("Ngay_Gx1") Then TxtNgay_Gx1.Value = Dstmp.Tables(1).Rows(0).Item("Ngay_Gx1")
        If Dstmp.Tables(1).Columns.Contains("Ngay_Gx2") Then TxtNgay_Gx2.Value = Dstmp.Tables(1).Rows(0).Item("Ngay_Gx2")
    End Sub
#End Region
#Region "Vali --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Kx As String = TxtMa_Kx.Text
        Dim iRow As Integer = -1
        Dim _FilterClient As String = "1=1"
        If Not _Ma_Kx = "" Then _FilterClient = " Ma_Kx = '" + _Ma_Kx + "'"
        TxtMa_Mau.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Mau", "DmMauKx", "1=1", _FilterClient)
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Mau.Text = "" Then
            TxtTen_Mau.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            If DrReturn.Table.Columns.Contains("Ten_Mau") Then
                TxtTen_Mau.Text = DrReturn.Item("Ten_Mau")
            Else
                TxtTen_Mau.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Mau", "DmMauXe", "(Ma_Mau = N'" & TxtMa_Mau.Text.Trim & "')", CyberSmlib)
            End If
        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
        End If
        V_GetGiaXeCoso()
    End Sub
#End Region
#Region "Vali --- Nh_CSBH1"
    Private Sub V_Nh_CSBH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CSBH1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhCSBH", "1=1", "Loai_Nh = '1'")
    End Sub
    Private Sub L_Nh_CSBH1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CSBH1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CSBH1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CSBH1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CSBH2"
    Private Sub V_Nh_CSBH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CSBH2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhCSBH", "1=1", "Loai_Nh = '2'")
    End Sub
    Private Sub L_Nh_CSBH2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CSBH2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CSBH2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CSBH2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CSBH3"
    Private Sub V_Nh_CSBH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CSBH3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhCSBH", "1=1", "Loai_Nh = '3'")
    End Sub
    Private Sub L_Nh_CSBH3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CSBH3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CSBH3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CSBH3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CSBH4"
    Private Sub V_Nh_CSBH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CSBH4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhCSBH", "1=1", "Loai_Nh = '4'")
    End Sub
    Private Sub L_Nh_CSBH4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CSBH4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CSBH4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CSBH4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_CSBH5"
    Private Sub V_Nh_CSBH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_CSBH5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhCSBH", "1=1", "Loai_Nh = '5'")
    End Sub
    Private Sub L_Nh_CSBH5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_CSBH5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_CSBH5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_CSBH5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_CSBH.Text = _Value

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
