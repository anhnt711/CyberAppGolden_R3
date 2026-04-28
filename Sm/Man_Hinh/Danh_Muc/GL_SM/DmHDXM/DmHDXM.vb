Public Class DmHDXM
#Region "Khai bao bien Paramater----------------------"
    Dim Dt_DmTTLN, Dt_DmTTCP, Dt_DmNN, Dt_DmNH, Dt_DmGiaBH, Dt_GioiTinh, Dt_Ht_Dv As DataTable
    Dim TbTP, TbQuan, TbXa As New DataTable
    Public vTbTP, vTbQuan, vTbXa As DataView

    '--> CTHD----------------------------------------------
    Dim Tb_MasterCtHd, Tb_DetailCtHd As New DataTable
    Dim DV_MasterCtHd, DV_DetailCtHd As New DataView
    Dim Tb_MasterCtHdTmp, Tb_DetailCtHdTmp As New DataTable

    '--> CTTTHD
    Dim Tb_MasterCTTTHd, Tb_DetailCTTTHd As New DataTable
    Dim DV_MasterCTTTHd, DV_DetailCTTTHd As New DataView
    Dim Tb_MasterCTTTHdTmp, Tb_DetailCTTTHdTmp As New DataTable
    '------------------------------------------------------
    Dim M_Ma_TP_Ngam_Dinh As String = ""
    Dim M_Ma_Quan_Ngam_Dinh As String = ""
    Dim M_Ma_Xa_Ngam_Dinh As String = ""
    Dim M_Ma_TTLN As String = ""
    Dim M_Ma_TTCP As String = ""
    Dim M_MA_NN As String = ""
    Dim M_Gioi_Tinh As String = ""
    Dim M_HT_Dv As String = ""
    Dim M_Ma_Hs As String = ""
    Dim M_Ten_Hs As String = ""
    Dim M_Ma_NH As String = ""
#End Region
    Dim M_Mode As String = "M"
    Dim CyberSupport As New Cyber.Support.Sys
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim M_Ma_KH_Le As String = ""
    Dim M_Ten_KH_Le As String = ""
    Dim M_Ma_KH_Dk As String = ""
    Dim M_Ten_KH_Dk As String = ""
    Dim _Han_TT As Integer = 0
    Private Sub DMHD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_LoadDefaultDMHD()
        V_Load()

        M_Mode = Me.Mode.Trim
        If Me.Mode = "M" Then
            TxtNgay_HD1.Value = Now.Date
            TxtNgay_HD2.Value = Now.Date
            TxtNgay_Cap.Value = New Date(1900, 1, 1)
            TxtNgay_Sinh.Value = New Date(1900, 1, 1)
            ChkActi.Checked = True
        End If

        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

        V_Addhander1()
        V_GetNgamDinh()
        V_Addhander()

        Settxt()

        If M_Mode = "M" Then Me.Text = "TẠO HỢP ĐỒNG" Else Me.Text = "SỬA HỢP ĐỒNG"
        If M_Mode = "M" Then TxtSo_PTV.Focus() Else TxtSo_PTV.Focus()
        If M_Mode = "S" Then If TxtSo_May.Text.Trim = "" Or TxtSo_Khung.Text.Trim = "" Then SetMa_kx_Mau(False) Else SetMa_kx_Mau(True) Else SetMa_kx_Mau(False)

        If M_Mode = "M" Then
            ChkTra_Gop.Checked = False
            ChkIs_Xe_lo.Checked = False
            ChkIs_Huy_HD.Checked = False
        End If
        V_LoadCTHD()
        V_Is_Xe_lo()
    End Sub
    Private Sub V_Addhander1()
        AddHandler CmdSavePrint.Click, AddressOf V_SavePrint

        'Tên hợp đồng
        AddHandler TxtTen_HD.Leave, AddressOf V_Ten_HD
        AddHandler TxtDia_Chi.Leave, AddressOf V_Dia_Chi
        AddHandler TxtTen_KhVAT.Leave, AddressOf V_Ten_KhVat
        AddHandler TxtDia_ChiVAT.Leave, AddressOf V_Dia_ChiVat

        'Tính toán
        AddHandler TxtDon_Gia.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtTra_Gop_Online.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtDang_Ky.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtPhi_Hs.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtHH.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtT_Pk.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtTT_TM.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtTT_QuetThe.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtPhi_QuetThe.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtPhi_QuetThe_TM.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtTT_CK.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtGia_NH.Leave, AddressOf V_Tinh_Toan

        AddHandler TxtPhi_Tham_Gia.Leave, AddressOf V_Tinh_Gop
        AddHandler TxtT_Gop.Leave, AddressOf V_Tinh_Gop

        AddHandler ChkTra_Gop.CheckedChanged, AddressOf V_Tra_Gop
        AddHandler ChkIs_Xe_lo.CheckedChanged, AddressOf V_Is_Xe_lo
        AddHandler CmdBan_Buon.Click, AddressOf V_XemHDBanSi
        AddHandler CmdCong_No.Click, AddressOf V_XemCTTTHD
    End Sub
    Private Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_HD.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_HD.KeyPress, AddressOf TxtCodeError_KeyPress
        'HD1
        RemoveHandler TxtNh_HD1.CyberValiting, AddressOf V_Nh_HD1
        RemoveHandler TxtNh_HD1.CyberLeave, AddressOf L_Nh_HD1
        AddHandler TxtNh_HD1.CyberValiting, AddressOf V_Nh_HD1
        AddHandler TxtNh_HD1.CyberLeave, AddressOf L_Nh_HD1
        'HD2
        RemoveHandler TxtNh_HD2.CyberValiting, AddressOf V_Nh_HD2
        RemoveHandler TxtNh_HD2.CyberLeave, AddressOf L_Nh_HD2
        AddHandler TxtNh_HD2.CyberValiting, AddressOf V_Nh_HD2
        AddHandler TxtNh_HD2.CyberLeave, AddressOf L_Nh_HD2
        'HD3
        RemoveHandler TxtNh_HD3.CyberValiting, AddressOf V_Nh_HD3
        RemoveHandler TxtNh_HD3.CyberLeave, AddressOf L_Nh_HD3
        AddHandler TxtNh_HD3.CyberValiting, AddressOf V_Nh_HD3
        AddHandler TxtNh_HD3.CyberLeave, AddressOf L_Nh_HD3
        'HD4
        RemoveHandler TxtNh_HD4.CyberValiting, AddressOf V_Nh_HD4
        RemoveHandler TxtNh_HD4.CyberLeave, AddressOf L_Nh_HD4
        AddHandler TxtNh_HD4.CyberValiting, AddressOf V_Nh_HD4
        AddHandler TxtNh_HD4.CyberLeave, AddressOf L_Nh_HD4
        'HD5
        RemoveHandler TxtNh_HD5.CyberValiting, AddressOf V_Nh_HD5
        RemoveHandler TxtNh_HD5.CyberLeave, AddressOf L_Nh_HD5
        AddHandler TxtNh_HD5.CyberValiting, AddressOf V_Nh_HD5
        AddHandler TxtNh_HD5.CyberLeave, AddressOf L_Nh_HD5

        'So_PTV
        AddHandler TxtSo_PTV.Leave, AddressOf V_So_PTV
        AddHandler CmbMa_HT_Dv.SelectedValueChanged, AddressOf L_Ma_HT_Dv
        'Ngay_HD2
        AddHandler TxtNgay_HD2.Leave, AddressOf V_Ngay_HD2
        'Giá xuất theo ngày xuất xe
        AddHandler ChkIs_Gia_Ngay_Xuat.CheckedChanged, AddressOf V_Gia_Xuat

        'Ma_Hs
        RemoveHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        RemoveHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        'Ma_Hs_Online
        RemoveHandler TxtMa_Hs_Online.CyberValiting, AddressOf V_Ma_Hs_Online
        RemoveHandler TxtMa_Hs_Online.CyberLeave, AddressOf L_Ma_Hs_Online
        AddHandler TxtMa_Hs_Online.CyberValiting, AddressOf V_Ma_Hs_Online
        AddHandler TxtMa_Hs_Online.CyberLeave, AddressOf L_Ma_Hs_Online
        'Ma_KTV
        RemoveHandler TxtMa_KTV.CyberValiting, AddressOf V_Ma_KTV
        RemoveHandler TxtMa_KTV.CyberLeave, AddressOf L_Ma_KTV
        AddHandler TxtMa_KTV.CyberValiting, AddressOf V_Ma_KTV
        AddHandler TxtMa_KTV.CyberLeave, AddressOf L_Ma_KTV
        'Ma_Kh
        RemoveHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        RemoveHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_KH
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_KH
        'Ma_Kx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_kx
        'Ma_Mau
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        'So_Khung
        AddHandler TxtSo_Khung.CyberValiting, AddressOf V_SoKhung
        AddHandler TxtSo_Khung.CyberLeave, AddressOf L_SoKhung
        AddHandler TxtSo_Khung.Leave, AddressOf V_So_Khung
        'Ma_Kh_DK
        RemoveHandler TxtMa_KH_DK.CyberValiting, AddressOf V_Ma_KH_DK
        RemoveHandler TxtMa_KH_DK.CyberLeave, AddressOf L_Ma_KH_DK
        AddHandler TxtMa_KH_DK.CyberValiting, AddressOf V_Ma_KH_DK
        AddHandler TxtMa_KH_DK.CyberLeave, AddressOf L_Ma_KH_DK
        'Ma_NH_QuetThe
        RemoveHandler TxtMa_Nh_QuetThe.CyberValiting, AddressOf V_Ma_Nh_QuetThe
        RemoveHandler TxtMa_Nh_QuetThe.CyberLeave, AddressOf L_Ma_Nh_QuetThe
        AddHandler TxtMa_Nh_QuetThe.CyberValiting, AddressOf V_Ma_Nh_QuetThe
        AddHandler TxtMa_Nh_QuetThe.CyberLeave, AddressOf L_Ma_Nh_QuetThe
        'Ma_Gop
        RemoveHandler TxtMa_Gop.CyberValiting, AddressOf V_Ma_Gop
        RemoveHandler TxtMa_Gop.CyberLeave, AddressOf L_Ma_Gop
        AddHandler TxtMa_Gop.CyberValiting, AddressOf V_Ma_Gop
        AddHandler TxtMa_Gop.CyberLeave, AddressOf L_Ma_Gop
        AddHandler TxtTra_Gop_Online.Leave, AddressOf V_GetPhiTG
        AddHandler TxtPT_Phi_Online.Leave, AddressOf V_GetPhiTG

        'Ma_Kh_Online
        RemoveHandler TxtMa_Kh_Online.CyberValiting, AddressOf V_Ma_Kh_Online
        RemoveHandler TxtMa_Kh_Online.CyberLeave, AddressOf L_Ma_Kh_Online
        AddHandler TxtMa_Kh_Online.CyberValiting, AddressOf V_Ma_Kh_Online
        AddHandler TxtMa_Kh_Online.CyberLeave, AddressOf L_Ma_Kh_Online
        AddHandler TxtMa_Kh_Online.Leave, AddressOf V_Get_Gia_Xe

        'Ma_TP
        AddHandler TxtMa_TP.CyberValiting, AddressOf V_Ma_TP
        AddHandler TxtMa_TP.CyberLeave, AddressOf L_Ma_TP
        'Ma_Quan
        AddHandler TxtMa_Quan.CyberValiting, AddressOf V_Ma_Quan
        AddHandler TxtMa_Quan.CyberLeave, AddressOf L_Ma_Quan
        'Ma_Xa
        AddHandler TxtMa_Xa.CyberValiting, AddressOf V_Ma_Xa
        AddHandler TxtMa_Xa.CyberLeave, AddressOf L_Ma_Xa
        'Ma_TP2
        AddHandler TxtMa_TP2.CyberValiting, AddressOf V_Ma_TP2
        AddHandler TxtMa_TP2.CyberLeave, AddressOf L_Ma_TP2
        AddHandler TxtMa_TP2.Leave, AddressOf V_Ma_TP2_Empty
        'Ma_Quan2
        AddHandler TxtMa_Quan2.CyberValiting, AddressOf V_Ma_Quan2
        AddHandler TxtMa_Quan2.CyberLeave, AddressOf L_Ma_Quan2
        AddHandler TxtMa_Quan2.Leave, AddressOf V_Ma_Quan2_Empty
        'Ma_Xa2
        AddHandler TxtMa_Xa2.CyberValiting, AddressOf V_Ma_Xa2
        AddHandler TxtMa_Xa2.CyberLeave, AddressOf L_Ma_Xa2
        AddHandler TxtMa_Xa2.Leave, AddressOf V_Ma_Xa2_Empty

        'Ma_HD_Old
        AddHandler ChkIs_Doi_Tra.CheckedChanged, AddressOf V_Doi_Tra
        AddHandler TxtMa_HD_Doi.CyberValiting, AddressOf V_Ma_HD_Old
        AddHandler TxtMa_HD_Doi.CyberLeave, AddressOf L_Ma_HD_Old
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If Me.Mode.ToString.Trim = "M" Then TxtNh_HD5.Text = "05"

        If TxtNh_HD1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHD", "(Loai_Nh = '1' AND Ma_Nh = N'" & TxtNh_HD1.Text.Trim & "')", CyberSmlib)
        If TxtNh_HD2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHD", "(Loai_Nh = '2' AND Ma_Nh = N'" & TxtNh_HD2.Text.Trim & "')", CyberSmlib)
        If TxtNh_HD3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHD", "(Loai_Nh = '3' AND Ma_Nh = N'" & TxtNh_HD3.Text.Trim & "')", CyberSmlib)
        If TxtNh_HD4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_SK", "DMSK", "(Ma_Sk = N'" + TxtNh_HD4.Text.Trim & "')", CyberSmlib)
        If TxtNh_HD5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhHD", "(Loai_Nh = '5' AND Ma_Nh = N'" & TxtNh_HD5.Text.Trim & "')", CyberSmlib)

        If TxtMa_Kh.Text.Trim.Trim = "" Then TxtTen_Kh.Text = "" Else TxtTen_Kh.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kh", "Dmkh", "(Ma_Kh = N'" & TxtMa_Kh.Text.Trim & "')", CyberSmlib)

        If TxtMa_KTV.Text.Trim = "" Then TxtTen_KTV.Text = "" Else TxtTen_KTV.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Hs", "DmHs", "(Ma_Hs = N'" & TxtMa_KTV.Text.Trim & "')", CyberSmlib)
        If TxtMa_Hs.Text.Trim = "" Then TxtTen_Hs.Text = "" Else TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Hs", "DmHs", "(Ma_Hs = N'" & TxtMa_Hs.Text.Trim & "')", CyberSmlib)
        If TxtMa_Hs_Online.Text.Trim = "" Then TxtTen_Hs_Online.Text = "" Else TxtTen_Hs_Online.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Hs", "DmHs", "(Ma_Hs = N'" & TxtMa_Hs_Online.Text.Trim & "')", CyberSmlib)
        If TxtMa_Kx.Text.Trim = "" Then TxtTen_Kx.Text = "" Else TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kx", "DmKx", "(Ma_Kx = N'" & TxtMa_Kx.Text.Trim & "')", CyberSmlib)
        If TxtMa_Mau.Text.Trim = "" Then TxtTen_Mau.Text = "" Else TxtTen_Mau.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_MAU", "DmMAUXe", "(Ma_Mau = N'" & TxtMa_Mau.Text.Trim & "')", CyberSmlib)

        If TxtMa_KH_DK.Text.Trim.Trim = "" Then TxtTen_KH_DK.Text = "" Else TxtTen_KH_DK.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kh", "Dmkh", "(Ma_kh = N'" & TxtMa_KH_DK.Text.Trim & "')", CyberSmlib)
        If TxtMa_Nh_QuetThe.Text.Trim.Trim = "" Then TxtTen_Nh_QuetThe.Text = "" Else TxtTen_Nh_QuetThe.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_NH", "DMNH", "(Ma_NH = N'" & TxtMa_Nh_QuetThe.Text.Trim & "')", CyberSmlib)
        If TxtMa_Kh_Online.Text.Trim.Trim = "" Then TxtTen_Kh_Online.Text = "" Else TxtTen_Kh_Online.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kh", "DmKhOnline", "(Ma_Kh = N'" & TxtMa_Kh_Online.Text.Trim & "')", CyberSmlib)

        If TxtMa_TP.Text.Trim.Trim = "" Then TxtTen_TP.Text = "" Else TxtTen_TP.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TP", "DMTP", "(Ma_TP = N'" & TxtMa_TP.Text.Trim & "')", CyberSmlib)
        If TxtMa_Quan.Text.Trim.Trim = "" Then TxtTen_Quan.Text = "" Else TxtTen_Quan.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Quan", "DMQUAN", "(Ma_Quan = N'" & TxtMa_Quan.Text.Trim & "')", CyberSmlib)
        If TxtMa_Xa.Text.Trim.Trim = "" Then TxtTen_Xa.Text = "" Else TxtTen_Xa.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Xa", "DMXA", "(Ma_Xa = N'" & TxtMa_Xa.Text.Trim & "')", CyberSmlib)

        If TxtMa_TP2.Text.Trim.Trim = "" Then TxtTen_TP2.Text = "" Else TxtTen_TP2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TP", "DMTP", "(Ma_TP = N'" & TxtMa_TP2.Text.Trim & "')", CyberSmlib)
        If TxtMa_Quan2.Text.Trim.Trim = "" Then TxtTen_Quan2.Text = "" Else TxtTen_Quan2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Quan", "DMQUAN", "(Ma_Quan = N'" & TxtMa_Quan2.Text.Trim & "')", CyberSmlib)
        If TxtMa_Xa2.Text.Trim.Trim = "" Then TxtTen_Xa2.Text = "" Else TxtTen_Xa2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Xa", "DMXA", "(Ma_Xa = N'" & TxtMa_Xa2.Text.Trim & "')", CyberSmlib)
        If TxtMa_Gop.Text.Trim.Trim = "" Then TxtTen_Gop.Text = "" Else TxtTen_Gop.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Gop", "DMMAGOP", "(Ma_Gop = N'" & TxtMa_Gop.Text.Trim & "')", CyberSmlib)

        If Me.Mode.ToString.Trim = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtMa_Kh.Text = M_Ma_KH_Le
            TxtTen_Kh.Text = M_Ten_KH_Le
            TxtMa_KH_DK.Text = M_Ma_KH_Dk
            TxtTen_KH_DK.Text = M_Ten_KH_Dk
            TxtHan_TT.Double = _Han_TT
        End If
        Dim Dt As Date = TxtNgay_HD1.Value
        Dim Dt1 As Date = TxtNgay_HD1.Value
        Dim Dt2 As Date = TxtNgay_HD1.Value

        If Dt1.ToString("yyyyMMdd").Trim = "19000101" Then TxtNgay_HD1.Value = Now.Date
        If Dt2.ToString("yyyyMMdd").Trim = "19000101" Then TxtNgay_HD2.Value = Now.Date
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub V_LoadCTHD()
        Dim DsCtHd As New DataSet
        Dim _Ngay_Hd As Date = TxtNgay_HD1.Value
        DsCtHd = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetCTDMHD", _Ngay_Hd.ToString("yyyyMMdd") & "#" & TxtMa_HD.Text.Trim & "#" & CmbMa_TTLN.SelectedValue.Trim & "#" & CmbMa_TTCP.SelectedValue.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)

        ' Bán sỉ
        Tb_MasterCtHd = DsCtHd.Tables(0)
        Tb_DetailCtHd = DsCtHd.Tables(1)
        Tb_DetailCtHdTmp = New DataTable
        Tb_DetailCtHdTmp = Tb_DetailCtHd.Copy

        ' Chi tiết thanh toán
        Tb_MasterCTTTHd = DsCtHd.Tables(2)
        Tb_DetailCTTTHd = DsCtHd.Tables(3)
        Tb_DetailCTTTHdTmp = New DataTable
        Tb_DetailCTTTHdTmp = Tb_DetailCTTTHd.Copy
    End Sub
    Private Sub V_LoadDefaultDMHD()
        Dim _Dt_Bp_Hs As DataTable
        Dim _DsHanTT As DataTable

        Dim DsDefault As New DataSet
        DsDefault = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetDefaultDMHD", M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())

        ' 1. Tỉnh/thành phố
        TbTP = DsDefault.Tables(0).Copy
        vTbTP = New DataView(TbTP)
        ' 2. Huyện/quận
        TbQuan = DsDefault.Tables(1).Copy
        vTbQuan = New DataView(TbQuan)
        ' 3. Xã/phường
        TbXa = DsDefault.Tables(2).Copy
        vTbXa = New DataView(TbXa)
        ' 4. Tư vấn hàng
        _Dt_Bp_Hs = DsDefault.Tables(3).Copy
        ' 5. Ma_TTLN
        Dt_DmTTLN = DsDefault.Tables(4).Copy
        ' 6. Ma_TTCP
        Dt_DmTTCP = DsDefault.Tables(5).Copy
        ' 7 . Ma_Kh mặc định
        Dim Dt_Khac_le As DataTable = DsDefault.Tables(6).Copy
        ' 8 . Nghề nghiệp
        Dt_DmNN = DsDefault.Tables(7).Copy
        ' 9 . Đơn vị tài chính
        Dt_DmNH = DsDefault.Tables(8).Copy
        ' 10. Giới tính
        Dt_GioiTinh = DsDefault.Tables(9).Copy
        ' 11. Hình thức dịch vụ đăng ký
        Dt_Ht_Dv = DsDefault.Tables(10).Copy
        '12. Thời hạn giải ngân
        _DsHanTT = DsDefault.Tables(11).Copy

        DsDefault.Dispose()

        ' Mã khách mặc định
        M_Ma_KH_Le = Dt_Khac_le.Rows(0).Item("Ma_Kh").ToString.Trim
        M_Ten_KH_Le = Dt_Khac_le.Rows(0).Item("Ten_Kh").ToString.Trim
        M_Ma_KH_Dk = Dt_Khac_le.Rows(0).Item("Ma_Kh_Dk").ToString.Trim
        M_Ten_KH_Dk = Dt_Khac_le.Rows(0).Item("Ten_Kh_Dk").ToString.Trim

        ' Ngầm đinh
        ' Ma_TP
        If TbTP.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To TbTP.Rows.Count - 1
                If TbTP.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_TP_Ngam_Dinh = TbTP.Rows(i).Item("Ma_TP").ToString.Trim
                    Exit For
                End If
            Next
        End If
        ' Ma_Quan
        If TbQuan.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To TbQuan.Rows.Count - 1
                If TbQuan.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_Quan_Ngam_Dinh = TbQuan.Rows(i).Item("Ma_Quan").ToString.Trim
                    Exit For
                End If
            Next
        End If
        ' Ma_Xa
        If TbXa.Columns.Contains("Ngam_Dinh") Then
            For i As Integer = 0 To TbXa.Rows.Count - 1
                If TbXa.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                    M_Ma_Xa_Ngam_Dinh = TbXa.Rows(i).Item("Ma_Xa").ToString.Trim
                    Exit For
                End If
            Next
        End If
        ' Ma_TTLN
        For i As Integer = 0 To Dt_DmTTLN.Rows.Count - 1
            If Not Dt_DmTTLN.Columns.Contains("Ngam_Dinh") Then Exit Sub
            If Dt_DmTTLN.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                M_Ma_TTLN = Dt_DmTTLN.Rows(i).Item("MA_TTLN").ToString.Trim
                Exit For
            End If
        Next

        CyberFill.V_FillComBoxDefaul(CmbMa_TTLN, Dt_DmTTLN, "Ma_TTLN", "Ten_TTLN", "Ngam_Dinh")
        ' Ma_TTCP
        For i As Integer = 0 To Dt_DmTTCP.Rows.Count - 1
            If Not Dt_DmTTCP.Columns.Contains("Ngam_Dinh") Then Exit Sub
            If Dt_DmTTCP.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                M_Ma_TTCP = Dt_DmTTCP.Rows(i).Item("Ma_TTCP").ToString.Trim
                Exit For
            End If
        Next
        If Not Dt_DmTTCP.Columns.Contains("Ngam_Dinh") Then CyberFill.V_FillComBoxDefaul(CmbMa_TTCP, Dt_DmTTCP, "Ma_TTCP", "Ten_TTCP", ) Else CyberFill.V_FillComBoxDefaul(CmbMa_TTCP, Dt_DmTTCP, "Ma_TTCP", "Ten_TTCP", "Ngam_Dinh")

        ' Ma_NN
        For i As Integer = 0 To Dt_DmNN.Rows.Count - 1
            If Not Dt_DmNN.Columns.Contains("Ngam_Dinh") Then Exit Sub
            If Dt_DmNN.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                M_MA_NN = Dt_DmNN.Rows(i).Item("MA_NN").ToString.Trim
                Exit For
            End If
        Next
        CyberFill.V_FillComBoxDefaul(CmbMa_NN, Dt_DmNN, "Ma_NN", "Ten_NN", "Ngam_Dinh")

        ' đơn vị tài chính
        For i As Integer = 0 To Dt_DmNH.Rows.Count - 1
            If Not Dt_DmNH.Columns.Contains("Ngam_Dinh") Then Exit Sub
            If Dt_DmNH.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                M_Ma_NH = Dt_DmNH.Rows(i).Item("Ma_NH").ToString.Trim
                Exit For
            End If
        Next
        CyberFill.V_FillComBoxDefaul(CmbMa_NH, Dt_DmNH, "Ma_NH", "Ten_NH", "Ngam_Dinh")

        ' Ma_GT
        For i As Integer = 0 To Dt_GioiTinh.Rows.Count - 1
            If Not Dt_GioiTinh.Columns.Contains("Ngam_Dinh") Then Exit Sub
            If Dt_GioiTinh.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                M_Gioi_Tinh = Dt_GioiTinh.Rows(i).Item("Ma_GT").ToString.Trim
                Exit For
            End If
        Next
        CyberFill.V_FillComBoxDefaul(CmbMa_GT, Dt_GioiTinh, "Ma_GT", "Ten_GT", "Ngam_Dinh")
        ' Ma_HT_Dv
        For i As Integer = 0 To Dt_Ht_Dv.Rows.Count - 1
            If Not Dt_Ht_Dv.Columns.Contains("Ngam_Dinh") Then Exit Sub
            If Dt_Ht_Dv.Rows(i).Item("Ngam_Dinh").ToString.Trim = "1" Then
                M_HT_Dv = Dt_Ht_Dv.Rows(i).Item("Ma_HT_Dv").ToString.Trim
                Exit For
            End If
        Next
        CyberFill.V_FillComBoxDefaul(CmbMa_HT_Dv, Dt_Ht_Dv, "Ma_HT_Dv", "Ten_HT_Dv", "Ngam_Dinh")

        If _Dt_Bp_Hs.Columns.Contains("Ma_Hs_H") Then M_Ma_Hs = _Dt_Bp_Hs.Rows(0).Item("Ma_Hs_H")
        If _Dt_Bp_Hs.Columns.Contains("Ten_Hs_H") Then M_Ten_Hs = _Dt_Bp_Hs.Rows(0).Item("Ten_Hs_H")

        ' Thời hạn thanh toán
        If _DsHanTT.Rows.Count > 0 Then
            _Han_TT = _DsHanTT.Rows(0).Item("Han_TT")
        End If
    End Sub
    Private Sub V_GetNgamDinh()
        If Not Me.Mode.Trim = "M" Then Exit Sub
        If M_Ma_TTLN.Trim <> "" And V_GetTTLN() = "" Then
            Try
                CmbMa_TTLN.SelectedValue = M_Ma_TTLN
            Catch ex As Exception
            End Try
        End If
        If M_MA_NN.Trim <> "" And CmbMa_NN.SelectedValue.ToString.Trim = "" Then
            Try
                CmbMa_NN.SelectedValue = M_MA_NN
            Catch ex As Exception
            End Try
        End If

        If M_HT_Dv.Trim <> "" And CmbMa_HT_Dv.SelectedValue.ToString.Trim = "" Then
            Try
                CmbMa_HT_Dv.SelectedValue = M_HT_Dv
            Catch ex As Exception
            End Try
        End If
    End Sub
#End Region
#Region "Số phiếu tiếp nhận"
    Private Sub V_So_PTV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Mode.Trim = "M" Then Exit Sub
        If TxtSo_PTV.Text.Trim = "" Then Exit Sub
        ' Định dạng So_PTV
        Dim _Ma_TTLN As String = CmbMa_TTLN.SelectedValue.ToString.Trim
        Dim _Ngay_Ct As String = TxtNgay_HD1.Text
        If TxtSo_PTV.Text.Length <= 5 Then
            TxtSo_PTV.Text = Strings.Right("00" & _Ma_TTLN, 2) & "." & Strings.Right(_Ngay_Ct, 2) & "." & Strings.Right("00000" & TxtSo_PTV.Text.Trim, 5)
        End If
        GetTTKH("1")
        Updatelist()
    End Sub
    Private Sub GetTTKH(ByVal _Loai As String)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        Dim _StrField As String = ""
        Dim _Strvalue As String = ""
        Dim _Ngay_Ct As Date = TxtNgay_HD1.Value
        Dim _Mode As String = Me.Mode.Trim
        Dim _So_PTV As String = TxtSo_PTV.Text.Trim
        Dim _Ma_TTLN_H As String = CmbMa_TTLN.SelectedValue.ToString.Trim

        CyberSmodb.GetValueControler(Me, _StrField, _Strvalue, "Dien_Giai,Ghi_Chu")

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetTTKHDMHDFROMPTV", _Loai & "#" & _Ngay_Ct.ToString("yyyyMMdd") & "#" & _So_PTV & "#" & _
                                                                  _Ma_TTLN_H & "#" & _Mode & "#" & _StrField & "#" & _Strvalue & "#" & M_Ma_Dvcs + "#" + M_User_Name)
        Dim _ncount = DsTmp.Tables.Count
        If _ncount < 1 Then
            DsTmp.Dispose()
            Exit Sub
        End If

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(_ncount - 1), Me.oSysvar, Me.M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        If DsTmp.Tables.Count < 2 Then
            DsTmp.Dispose()
            Exit Sub
        End If
        If DsTmp.Tables(0).Rows.Count < 1 Then
            DsTmp.Dispose()
            Exit Sub
        End If

        If DsTmp.Tables(0).Columns.Contains("Ma_Hs") Then TxtMa_Hs.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Hs").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_Hs") Then TxtTen_Hs.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Hs").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("DT1") And TxtDT1.Text.Trim = "" Then TxtDT1.Text = DsTmp.Tables(0).Rows(0).Item("DT1").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("DT2") And TxtDT2.Text.Trim = "" Then TxtDT2.Text = DsTmp.Tables(0).Rows(0).Item("DT2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("DT3") And TxtDT3.Text.Trim = "" Then TxtDT3.Text = DsTmp.Tables(0).Rows(0).Item("DT3").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("DT4") And TxtDT4.Text.Trim = "" Then TxtDT4.Text = DsTmp.Tables(0).Rows(0).Item("DT4").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_HD") And TxtTen_HD.Text.Trim = "" Then TxtTen_HD.Text = DsTmp.Tables(0).Rows(0).Item("Ten_HD").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ong_Ba1") And TxtOng_Ba1.Text.Trim = "" Then TxtOng_Ba1.Text = DsTmp.Tables(0).Rows(0).Item("Ong_Ba1").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ong_Ba2") And TxtOng_Ba2.Text.Trim = "" Then TxtOng_Ba2.Text = DsTmp.Tables(0).Rows(0).Item("Ong_Ba2").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ma_TP") And TxtMa_TP.Text.Trim = "" Then TxtMa_TP.Text = DsTmp.Tables(0).Rows(0).Item("Ma_TP").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_TP") And TxtTen_TP.Text.Trim = "" Then TxtTen_TP.Text = DsTmp.Tables(0).Rows(0).Item("Ten_TP").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_QUAN") And TxtMa_Quan.Text.Trim = "" Then TxtMa_Quan.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Quan").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_QUAN") And TxtTen_Quan.Text.Trim = "" Then TxtTen_Quan.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Quan").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_XA") And TxtMa_Xa.Text.Trim = "" Then TxtMa_Xa.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Xa").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_XA") And TxtTen_Xa.Text.Trim = "" Then TxtTen_Xa.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Xa").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ma_TP2") And TxtMa_TP2.Text.Trim = "" Then TxtMa_TP2.Text = DsTmp.Tables(0).Rows(0).Item("Ma_TP2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_TP2") And TxtTen_TP2.Text.Trim = "" Then TxtTen_TP2.Text = DsTmp.Tables(0).Rows(0).Item("Ten_TP2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_QUAN2") And TxtMa_Quan2.Text.Trim = "" Then TxtMa_Quan2.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Quan2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_QUAN2") And TxtTen_Quan2.Text.Trim = "" Then TxtTen_Quan2.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Quan2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_XA2") And TxtMa_Xa2.Text.Trim = "" Then TxtMa_Xa2.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Xa2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_XA2") And TxtTen_Xa2.Text.Trim = "" Then TxtTen_Xa2.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Xa2").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Dia_Chi") And TxtDia_Chi.Text.Trim = "" Then TxtDia_Chi.Text = DsTmp.Tables(0).Rows(0).Item("Dia_Chi").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dia_Chi2") And TxtDia_Chi2.Text.Trim = "" Then TxtDia_Chi2.Text = DsTmp.Tables(0).Rows(0).Item("Dia_Chi2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_So_Thue") And TxtMa_So_Thue.Text.Trim = "" Then TxtMa_So_Thue.Text = DsTmp.Tables(0).Rows(0).Item("Ma_So_Thue").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_KhVat") And TxtTen_KhVAT.Text.Trim = "" Then TxtTen_KhVAT.Text = DsTmp.Tables(0).Rows(0).Item("Ten_KhVat").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dia_ChiVat") And TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = DsTmp.Tables(0).Rows(0).Item("Dia_ChiVat").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dia_ChiVat") And TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = DsTmp.Tables(0).Rows(0).Item("Dia_ChiVat").ToString.Trim

        'If DsTmp.Tables(0).Columns.Contains("Ma_NN") And CmbMa_NN.SelectedValue.ToString = "" Then CmbMa_NN.SelectedValue = DsTmp.Tables(0).Rows(0).Item("Ma_NN").ToString.Trim
        'If DsTmp.Tables(0).Columns.Contains("Ma_GT") And CmbMa_GT.SelectedValue.ToString = "" Then CmbMa_GT.SelectedValue = DsTmp.Tables(0).Rows(0).Item("Ma_GT").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ma_NN") Then CmbMa_NN.SelectedValue = DsTmp.Tables(0).Rows(0).Item("Ma_NN").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_GT") Then CmbMa_GT.SelectedValue = DsTmp.Tables(0).Rows(0).Item("Ma_GT").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ngay_Sinh") Then
            Dim _Ngay_Sinh As Date = DsTmp.Tables(0).Rows(0).Item("Ngay_Sinh")
            Dim _Ngay_SiNh_HD As Date = TxtNgay_Sinh.Value
            If _Ngay_SiNh_HD.ToString("yyyyMMdd") = "19000101" Then TxtNgay_Sinh.Value = _Ngay_Sinh
        End If

        If DsTmp.Tables(0).Columns.Contains("E_Mail") And TxtE_Mail.Text.Trim = "" Then TxtE_Mail.Text = DsTmp.Tables(0).Rows(0).Item("E_Mail").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dai_Dien") And TxtDai_Dien.Text.Trim = "" Then TxtDai_Dien.Text = DsTmp.Tables(0).Rows(0).Item("Dai_Dien").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ong_Ba") And TxtOng_Ba.Text.Trim = "" Then TxtOng_Ba.Text = DsTmp.Tables(0).Rows(0).Item("Ong_Ba").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dc_LH") And TxtDC_LH.Text.Trim = "" Then TxtDC_LH.Text = DsTmp.Tables(0).Rows(0).Item("Dc_LH").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("SCMT") And TxtSCMT.Text.Trim = "" Then TxtSCMT.Text = DsTmp.Tables(0).Rows(0).Item("SCMT").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ngay_Cap") Then
            Dim _Ngay_Cap As Date = DsTmp.Tables(0).Rows(0).Item("Ngay_Cap")
            Dim _Ngay_Cap_HD As Date = TxtNgay_Cap.Value
            If _Ngay_Cap_HD.ToString("yyyyMMdd") = "19000101" Then TxtNgay_Cap.Value = _Ngay_Cap
        End If

        If DsTmp.Tables(0).Columns.Contains("Noi_Cap") And TxtNoi_Cap.Text.Trim = "" Then TxtNoi_Cap.Text = DsTmp.Tables(0).Rows(0).Item("Noi_Cap").ToString.Trim

        ' Mua online
        If DsTmp.Tables(0).Columns.Contains("Online") Then
            If DsTmp.Tables(0).Rows(0).Item("Online") = 1 Then
                ChkOnline.Checked = True
            Else
                ChkOnline.Checked = False
            End If
        End If
        If DsTmp.Tables(0).Columns.Contains("Ma_Kh_Online") And TxtMa_Kh_Online.Text.Trim = "" Then TxtMa_Kh_Online.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Kh_Online").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_Kh_Online") And TxtTen_Kh_Online.Text.Trim = "" Then TxtTen_Kh_Online.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Kh_Online").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_Don_Hang") And TxtMa_Don_Hang.Text.Trim = "" Then TxtMa_Don_Hang.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Don_Hang").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("So_Khung") And TxtSo_Khung.Text.Trim = "" Then TxtSo_Khung.Text = DsTmp.Tables(0).Rows(0).Item("So_Khung").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("So_May") And TxtSo_May.Text.Trim = "" Then TxtSo_May.Text = DsTmp.Tables(0).Rows(0).Item("So_May").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_Kx") And TxtMa_Kx.Text.Trim = "" Then TxtMa_Kx.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Kx").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_Kx") And TxtTen_Kx.Text.Trim = "" Then TxtTen_Kx.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Kx").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_Mau") And TxtMa_Mau.Text.Trim = "" Then TxtMa_Mau.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Mau").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_Mau") And TxtTen_Mau.Text.Trim = "" Then TxtTen_Mau.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Mau").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dien_Giai") And TxtDien_Giai.Text.Trim = "" Then TxtDien_Giai.Text = DsTmp.Tables(0).Rows(0).Item("Dien_Giai").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Tra_Gop") Then
            If DsTmp.Tables(0).Rows(0).Item("Tra_Gop") = 1 Then
                ChkTra_Gop.Checked = True
            Else
                ChkTra_Gop.Checked = False
            End If
        End If

        If DsTmp.Tables(0).Columns.Contains("Ma_HT_Dv") And CmbMa_HT_Dv.SelectedValue.ToString = "" Then CmbMa_HT_Dv.SelectedValue = DsTmp.Tables(0).Rows(0).Item("Ma_HT_Dv").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_NH") And CmbMa_NH.SelectedValue.ToString = "" Then CmbMa_NH.SelectedValue = DsTmp.Tables(0).Rows(0).Item("Ma_NH").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ma_Gop") And TxtMa_Gop.Text.Trim = "" Then TxtMa_Gop.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Gop").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_Gop") And TxtTen_Gop.Text.Trim = "" Then TxtTen_Gop.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Gop").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("HD_Gop") And TxtHd_Gop.Text.Trim = "" Then TxtHd_Gop.Text = DsTmp.Tables(0).Rows(0).Item("HD_Gop").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Don_Gia") Then TxtDon_Gia.Double = DsTmp.Tables(0).Rows(0).Item("Don_Gia").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dang_Ky") And TxtDang_Ky.Double = 0 Then TxtDang_Ky.Double = DsTmp.Tables(0).Rows(0).Item("Dang_Ky").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Phi_Hs") And TxtPhi_Hs.Double = 0 Then TxtPhi_Hs.Double = DsTmp.Tables(0).Rows(0).Item("Phi_Hs").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Phi_Tham_Gia") And TxtPhi_Tham_Gia.Double = 0 Then TxtPhi_Tham_Gia.Double = DsTmp.Tables(0).Rows(0).Item("Phi_Tham_Gia").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("HH") And TxtHH.Double = 0 Then TxtHH.Double = DsTmp.Tables(0).Rows(0).Item("HH").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("T_Pk") And TxtT_Pk.Double = 0 Then TxtT_Pk.Double = DsTmp.Tables(0).Rows(0).Item("T_Pk").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Giam_Gia") And TxtGiam_Gia.Double = 0 Then TxtGiam_Gia.Double = DsTmp.Tables(0).Rows(0).Item("Giam_Gia").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("TT_QuetThe") And TxtTT_QuetThe.Double = 0 Then TxtTT_QuetThe.Double = DsTmp.Tables(0).Rows(0).Item("TT_QuetThe").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Phi_QuetThe") And TxtPhi_QuetThe.Double = 0 Then TxtPhi_QuetThe.Double = DsTmp.Tables(0).Rows(0).Item("Phi_QuetThe").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Phi_QuetTheTM") And TxtPhi_QuetThe_TM.Double = 0 Then TxtPhi_QuetThe_TM.Double = DsTmp.Tables(0).Rows(0).Item("Phi_QuetTheTM").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("TT_CK") And TxtTT_CK.Double = 0 Then TxtTT_CK.Double = DsTmp.Tables(0).Rows(0).Item("TT_CK").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Gop_Xe") And TxtGop_Xe.Double = 0 Then TxtGop_Xe.Double = DsTmp.Tables(0).Rows(0).Item("Gop_Xe").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Gop_Pk") And TxtGop_Pk.Double = 0 Then TxtGop_Pk.Double = DsTmp.Tables(0).Rows(0).Item("Gop_Pk").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("T_Gop") And TxtT_Gop.Double = 0 Then TxtT_Gop.Double = DsTmp.Tables(0).Rows(0).Item("T_Gop").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("TT_TM") And TxtTT_TM.Double = 0 Then TxtTT_TM.Double = DsTmp.Tables(0).Rows(0).Item("TT_TM").ToString.Trim
        '
        If DsTmp.Tables(0).Columns.Contains("Gia_NH") Then TxtGia_NH.Double = DsTmp.Tables(0).Rows(0).Item("Gia_NH").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Tra_Truoc_Nh") Then TxtTra_Truoc_Nh.Double = DsTmp.Tables(0).Rows(0).Item("Tra_Truoc_Nh").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Is_Doi_Tra") Then
            If DsTmp.Tables(0).Rows(0).Item("Is_Doi_Tra") = 1 Then
                ChkIs_Doi_Tra.Checked = True
            Else
                ChkIs_Doi_Tra.Checked = False
            End If
        End If
        DsTmp.Dispose()
    End Sub
#End Region
#Region "Tinh_Toan"
    Private Sub Updatelist()
        TxtT_Xe.Double = TxtDon_Gia.Double + TxtDang_Ky.Double + TxtPhi_Hs.Double + TxtPhi_Mua_HD.Double + TxtPhi_Tham_Gia.Double + TxtHH.Double
        TxtT_TT.Double = TxtT_Xe.Double + TxtT_Pk.Double
        TxtCong_No.Double = TxtT_TT.Double - TxtTra_Gop_Online.Double - TxtGop_Xe.Double - TxtGop_Pk.Double - TxtTT_QuetThe.Double - TxtTT_CK.Double - TxtTT_TM.Double

        ' Tiền góp
        If ChkOnline.Checked = False Then
            If TxtT_Xe.Double >= TxtT_Gop.Double Then
                TxtGop_Xe.Double = TxtT_Gop.Double
                TxtGop_Pk.Double = 0
            End If
            If TxtT_Xe.Double < TxtT_Gop.Double Then
                TxtGop_Pk.Double = TxtT_Pk.Double
                TxtGop_Xe.Double = TxtT_Gop.Double - TxtT_Pk.Double
            End If
        End If

        If ChkOnline.Checked = True Then
            If TxtT_Xe.Double - TxtTra_Gop_Online.Double >= TxtT_Gop.Double Then
                TxtGop_Xe.Double = TxtT_Gop.Double
                TxtGop_Pk.Double = 0
            End If
            If TxtT_Xe.Double - TxtTra_Gop_Online.Double < TxtT_Gop.Double Then
                TxtGop_Pk.Double = TxtT_Pk.Double
                TxtGop_Xe.Double = TxtT_Gop.Double - TxtT_Pk.Double
            End If
        End If

        ' giá ngân hàng        
        If ChkTra_Gop.Checked = True Then
            If TxtGia_NH.Double = 0 Then TxtGia_NH.Double = TxtT_TT.Double
            If TxtGia_NH.Double >= TxtT_Gop.Double Then
                TxtTra_Truoc_Nh.Double = TxtGia_NH.Double - TxtT_Gop.Double
            End If
        End If

        If ChkTra_Gop.Checked = False Then
            TxtGia_NH.Double = 0
            TxtTra_Truoc_Nh.Double = 0
        End If
    End Sub
    Private Sub V_Tinh_Gop(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        'Tính phí tham gia
        V_GetPhiTG()
        Updatelist()
    End Sub
    Private Sub V_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        Updatelist()
    End Sub
    Private Sub V_Get_Gia_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode.Trim = "M" Or Mode.Trim = "S") Then Exit Sub
        V_Tinh_Gia("1")
    End Sub
    Private Sub Settxt()
        SetReadOnly(TxtDon_Gia)
        SetReadOnly(TxtDang_Ky)
        SetReadOnly(TxtPhi_Hs)
        SetReadOnly(TxtPhi_Mua_HD)
        SetReadOnly(TxtT_Xe)
        ''SetReadOnly(TxtT_Pk)
        SetReadOnly(TxtT_TT)
        SetReadOnly(TxtGia_VAT)
        SetReadOnly(TxtGia_TB)
        SetReadOnly(TxtCong_No)
        SetReadOnly(TxtGop_Xe)
        SetReadOnly(TxtGop_Pk)
        SetReadOnly(TxtTra_Truoc_Nh)

        TxtMa_Hs.ReadOnly = True
        TxtTen_Hs.ReadOnly = True

        TxtMa_HD.Enabled = False
        Dim _E_N As Boolean = M_Mode = "M"

        CmbMa_TTLN.Enabled = _E_N
        CmbMa_TTCP.Enabled = False
        TxtSo_May.Enabled = False
    End Sub
    Private Sub SetReadOnly(ByVal _Txt As ClsTextBox.txtTy_Gia)
        _Txt.ReadOnly = True
        _Txt.TabStop = False
    End Sub
#End Region
#Region "Valid - Kx/Mau/So_khung/So_May"
    Private Sub SetMa_kx_Mau(ByVal _Readonly As Boolean)
        TxtMa_Kx.ReadOnly = _Readonly
        TxtMa_Kx.TabStop = Not _Readonly

        TxtMa_Mau.ReadOnly = _Readonly
        TxtMa_Mau.TabStop = Not _Readonly

        CmbMa_TTCP.Enabled = Not _Readonly
    End Sub
    Private Sub V_Ngay_HD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Tinh_Gia("1")
    End Sub
    Private Sub V_So_Khung(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtSo_Khung.Text.Trim = "" Then
            TxtSo_May.Text = ""
            SetMa_kx_Mau(False)
            Exit Sub
        End If
        V_Tinh_Gia("1")
    End Sub
    Private Sub V_Tinh_Gia(ByVal _Loai As String)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _So_Khung As String = TxtSo_Khung.Text.Trim
        Dim _So_May As String = TxtSo_May.Text.Trim
        Dim _Ngay_HD1 As Date = TxtNgay_HD1.Value
        Dim _Ngay_HD2 As Date = TxtNgay_HD2.Value
        Dim _Is_Gia_Ngay_Xuat As String = "0"
        Dim _Ma_HD As String = TxtMa_HD.Text.Trim
        Dim _Ma_Kx As String = TxtMa_Kx.Text.Trim
        Dim _Ma_Mau As String = TxtMa_Mau.Text.Trim
        Dim _Ma_HT_Dv As String = CmbMa_HT_Dv.SelectedValue.ToString.Trim
        Dim _Ma_TTLN As String = V_GetTTLN()
        Dim _Ma_TTCP As String = V_GetTTCP()
        Dim _Ma_TP As String = TxtMa_TP.Text.Trim
        Dim _Ma_Quan As String = TxtMa_Quan.Text.Trim
        Dim _Ma_Xa As String = TxtMa_Xa.Text.Trim
        Dim _Mode As String = Me.Mode.Trim
        Dim _Online As String = "0"
        Dim _Ma_Kh_Online As String = TxtMa_Kh_Online.Text.Trim
        Dim _Ma_Kh_Dk As String = TxtMa_KH_DK.Text.Trim
        If ChkOnline.Checked = True Then _Online = "1"
        If ChkIs_Gia_Ngay_Xuat.Checked = True Then _Is_Gia_Ngay_Xuat = "1"

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetGiaXeDMHD", _Loai & "#" & If(ChkIs_Xe_lo.Checked, "1", "0") & "#" & _Ngay_HD1.ToString("yyyyMMdd") & "#" & _Ngay_HD2.ToString("yyyyMMdd") & "#" & _Is_Gia_Ngay_Xuat & "#" & _
                                                                  _Ma_TTLN & "#" & _Ma_TTCP & "#" & _Ma_TP & "#" & _Ma_Quan & "#" & _Ma_Xa & "#" & _Ma_HD & "#" & _Mode & "#" & _Online.Trim & "#" & _Ma_Kh_Online.Trim & "#" & _Ma_Kh_Dk.Trim & "#" & _
                                                                  _So_Khung & "#" & _So_May & "#" & _Ma_Kx & "#" & _Ma_Mau & "#" & _Ma_HT_Dv & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        Dim _ncount As Integer = DsTmp.Tables.Count
        If _ncount < 1 Then
            DsTmp.Dispose()
            Exit Sub
        End If
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(_ncount - 1), Me.oSysvar, Me.M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        If _ncount < 2 Then
            DsTmp.Dispose()
            Exit Sub
        End If
        If DsTmp.Tables(0).Rows.Count < 1 Then
            DsTmp.Dispose()
            Exit Sub
        End If
        'Update trường dữ liệu
        If DsTmp.Tables(0).Columns.Contains("So_May") Then TxtSo_May.Text = DsTmp.Tables(0).Rows(0).Item("So_May")
        If DsTmp.Tables(0).Columns.Contains("Ma_Kx") Then TxtMa_Kx.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Kx")
        If DsTmp.Tables(0).Columns.Contains("Ten_Kx") Then TxtTen_Kx.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Kx")
        If DsTmp.Tables(0).Columns.Contains("Ma_Mau") Then TxtMa_Mau.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Mau")
        If DsTmp.Tables(0).Columns.Contains("Ten_Mau") Then TxtTen_Mau.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Mau")

        If ChkIs_Doi_Tra.Checked = False Then
            If DsTmp.Tables(0).Columns.Contains("Don_Gia") Then TxtDon_Gia.Double = DsTmp.Tables(0).Rows(0).Item("Don_Gia")
            If DsTmp.Tables(0).Columns.Contains("Dang_Ky") Then TxtDang_Ky.Double = DsTmp.Tables(0).Rows(0).Item("Dang_Ky")
            If DsTmp.Tables(0).Columns.Contains("Phi_Hs") Then TxtPhi_Hs.Double = DsTmp.Tables(0).Rows(0).Item("Phi_Hs")
            If DsTmp.Tables(0).Columns.Contains("Phi_Mua_HD") Then TxtPhi_Mua_HD.Double = DsTmp.Tables(0).Rows(0).Item("Phi_Mua_HD")
            If DsTmp.Tables(0).Columns.Contains("Gia_Vat") Then TxtGia_VAT.Double = DsTmp.Tables(0).Rows(0).Item("Gia_Vat")
            If DsTmp.Tables(0).Columns.Contains("Gia_TB") Then TxtGia_TB.Double = DsTmp.Tables(0).Rows(0).Item("Gia_TB")
        End If

        DsTmp.Dispose()
        Updatelist()
        If _So_Khung = "" And _So_May = "" Then
            SetMa_kx_Mau(False)
            Exit Sub
        Else
            SetMa_kx_Mau(True)
        End If
    End Sub
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kx.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kx", "Dmkx", "Is_KD ='1'", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kx.Text = "" Then
            TxtTen_Kx.Text = ""
            V_Tinh_Gia("3")
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
        V_Tinh_Gia("3")
    End Sub
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _FilterClient As String = "1=1"
        Dim _Ma_Kx = TxtMa_Kx.Text.Trim
        If Not _Ma_Kx = "" Then _FilterClient = " Ma_Kx = '" & _Ma_Kx & "'"
        TxtMa_Mau.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Mau", "DmmauKx", "1=1", _FilterClient)
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Mau.Text = "" Then
            TxtTen_Mau.Text = ""
            V_Tinh_Gia("4")
            Exit Sub
        End If
        DrReturn = TxtMa_Mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_mau")
            If DrReturn.Table.Columns.Contains("Ten_Mau") Then
                TxtTen_Mau.Text = DrReturn.Item("Ten_mau")
            Else
                TxtTen_Mau.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Mau", "DmMauXe", "(Ma_Mau = N'" & DrReturn("Ma_Mau").ToString.Trim & "')", CyberSmlib)
            End If
        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
        End If
        V_Tinh_Gia("4")
    End Sub
#End Region
#Region "Đổi trả"
    Private Sub V_Doi_Tra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkIs_Doi_Tra.Checked Then TxtMa_HD_Doi.Focus()
        If Not ChkIs_Doi_Tra.Checked Then
            V_Tinh_Gia("1")
        End If
        V_GetInfoHD_Old()
    End Sub
    Private Sub V_Ma_HD_Old(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        V_GetInfoHD_Old()
    End Sub
    Private Sub L_Ma_HD_Old(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        V_GetInfoHD_Old()
    End Sub
    Private Sub V_GetInfoHD_Old()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Is_Doi_Tra As Integer = 0
        If ChkIs_Doi_Tra.Checked = True Then _Is_Doi_Tra = 1
        If _Is_Doi_Tra = 0 Then Exit Sub

        Dim _Ma_HD_Doi As String = TxtMa_HD_Doi.Text.Trim
        Dim _Ma_TTLN = CmbMa_TTLN.SelectedValue.ToString.Trim
        Dim _Ngay_HD1 As Date = TxtNgay_HD1.Value

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_BEGetInfoHD_Old", _Ma_HD_Doi & "#" & _Ma_TTLN & "#" & _Ngay_HD1.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        Dim _ncount As Integer = DsTmp.Tables.Count
        If _ncount < 1 Then
            DsTmp.Dispose()
            Exit Sub
        End If
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(_ncount - 1), Me.oSysvar, Me.M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        If _ncount < 2 Then
            DsTmp.Dispose()
            Exit Sub
        End If
        If DsTmp.Tables(0).Rows.Count < 1 Then
            DsTmp.Dispose()
            Exit Sub
        End If
        'Update trường dữ liệu
        If DsTmp.Tables(0).Columns.Contains("Ma_Hs") Then TxtMa_Hs.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Hs").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_Hs") Then TxtTen_Hs.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Hs").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("DT1") And TxtDT1.Text.Trim = "" Then TxtDT1.Text = DsTmp.Tables(0).Rows(0).Item("DT1").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("DT2") And TxtDT2.Text.Trim = "" Then TxtDT2.Text = DsTmp.Tables(0).Rows(0).Item("DT2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("DT3") And TxtDT3.Text.Trim = "" Then TxtDT3.Text = DsTmp.Tables(0).Rows(0).Item("DT3").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("DT4") And TxtDT4.Text.Trim = "" Then TxtDT4.Text = DsTmp.Tables(0).Rows(0).Item("DT4").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_HD") And TxtTen_HD.Text.Trim = "" Then TxtTen_HD.Text = DsTmp.Tables(0).Rows(0).Item("Ten_HD").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ong_Ba1") And TxtOng_Ba1.Text.Trim = "" Then TxtOng_Ba1.Text = DsTmp.Tables(0).Rows(0).Item("Ong_Ba1").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ong_Ba2") And TxtOng_Ba2.Text.Trim = "" Then TxtOng_Ba2.Text = DsTmp.Tables(0).Rows(0).Item("Ong_Ba2").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ma_TP") And TxtMa_TP.Text.Trim = "" Then TxtMa_TP.Text = DsTmp.Tables(0).Rows(0).Item("Ma_TP").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_TP") And TxtTen_TP.Text.Trim = "" Then TxtTen_TP.Text = DsTmp.Tables(0).Rows(0).Item("Ten_TP").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_Quan") And TxtMa_Quan.Text.Trim = "" Then TxtMa_Quan.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Quan").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_Quan") And TxtTen_Quan.Text.Trim = "" Then TxtTen_Quan.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Quan").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_Xa") And TxtMa_Xa.Text.Trim = "" Then TxtMa_Xa.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Xa").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_Xa") And TxtTen_Xa.Text.Trim = "" Then TxtTen_Xa.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Xa").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ma_TP2") And TxtMa_TP2.Text.Trim = "" Then TxtMa_TP2.Text = DsTmp.Tables(0).Rows(0).Item("Ma_TP2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_TP2") And TxtTen_TP2.Text.Trim = "" Then TxtTen_TP2.Text = DsTmp.Tables(0).Rows(0).Item("Ten_TP2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_Quan2") And TxtMa_Quan2.Text.Trim = "" Then TxtMa_Quan2.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Quan2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_Quan2") And TxtTen_Quan2.Text.Trim = "" Then TxtTen_Quan2.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Quan2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_Xa2") And TxtMa_Xa2.Text.Trim = "" Then TxtMa_Xa2.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Xa2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_Xa2") And TxtTen_Xa2.Text.Trim = "" Then TxtTen_Xa2.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Xa2").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Dia_Chi") And TxtDia_Chi.Text.Trim = "" Then TxtDia_Chi.Text = DsTmp.Tables(0).Rows(0).Item("Dia_Chi").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dia_Chi2") And TxtDia_Chi2.Text.Trim = "" Then TxtDia_Chi2.Text = DsTmp.Tables(0).Rows(0).Item("Dia_Chi2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_So_Thue") And TxtMa_So_Thue.Text.Trim = "" Then TxtMa_So_Thue.Text = DsTmp.Tables(0).Rows(0).Item("Ma_So_Thue").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_KhVat") And TxtTen_KhVAT.Text.Trim = "" Then TxtTen_KhVAT.Text = DsTmp.Tables(0).Rows(0).Item("Ten_KhVat").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dia_ChiVat") And TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = DsTmp.Tables(0).Rows(0).Item("Dia_ChiVat").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dia_ChiVat") And TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = DsTmp.Tables(0).Rows(0).Item("Dia_ChiVat").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ma_NN") Then CmbMa_NN.SelectedValue = DsTmp.Tables(0).Rows(0).Item("Ma_NN").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_GT") Then CmbMa_GT.SelectedValue = DsTmp.Tables(0).Rows(0).Item("Ma_GT").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ngay_Sinh") Then
            Dim _Ngay_Sinh As Date = DsTmp.Tables(0).Rows(0).Item("Ngay_Sinh")
            Dim _Ngay_SiNh_HD As Date = TxtNgay_Sinh.Value
            If _Ngay_SiNh_HD.ToString("yyyyMMdd") = "19000101" Then TxtNgay_Sinh.Value = _Ngay_Sinh
        End If

        If DsTmp.Tables(0).Columns.Contains("E_Mail") And TxtE_Mail.Text.Trim = "" Then TxtE_Mail.Text = DsTmp.Tables(0).Rows(0).Item("E_Mail").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dai_Dien") And TxtDai_Dien.Text.Trim = "" Then TxtDai_Dien.Text = DsTmp.Tables(0).Rows(0).Item("Dai_Dien").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ong_Ba") And TxtOng_Ba.Text.Trim = "" Then TxtOng_Ba.Text = DsTmp.Tables(0).Rows(0).Item("Ong_Ba").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dc_LH") And TxtDC_LH.Text.Trim = "" Then TxtDC_LH.Text = DsTmp.Tables(0).Rows(0).Item("Dc_LH").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("SCMT") And TxtSCMT.Text.Trim = "" Then TxtSCMT.Text = DsTmp.Tables(0).Rows(0).Item("SCMT").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ngay_Cap") Then
            Dim _Ngay_Cap As Date = DsTmp.Tables(0).Rows(0).Item("Ngay_Cap")
            Dim _Ngay_Cap_HD As Date = TxtNgay_Cap.Value
            If _Ngay_Cap_HD.ToString("yyyyMMdd") = "19000101" Then TxtNgay_Cap.Value = _Ngay_Cap
        End If

        If DsTmp.Tables(0).Columns.Contains("Noi_Cap") And TxtNoi_Cap.Text.Trim = "" Then TxtNoi_Cap.Text = DsTmp.Tables(0).Rows(0).Item("Noi_Cap").ToString.Trim

        ' Mua online
        If DsTmp.Tables(0).Columns.Contains("Online") Then
            If DsTmp.Tables(0).Rows(0).Item("Online") = 1 Then
                ChkOnline.Checked = True
            Else
                ChkOnline.Checked = False
            End If
        End If
        If DsTmp.Tables(0).Columns.Contains("Ma_Kh_Online") Then TxtMa_Kh_Online.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Kh_Online").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_Kh_Online") Then TxtTen_Kh_Online.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Kh_Online").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_Don_Hang") Then TxtMa_Don_Hang.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Don_Hang").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Dien_Giai") And TxtDien_Giai.Text.Trim = "" Then TxtDien_Giai.Text = DsTmp.Tables(0).Rows(0).Item("Dien_Giai").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Tra_Gop") Then
            If DsTmp.Tables(0).Rows(0).Item("Tra_Gop") = 1 Then
                ChkTra_Gop.Checked = True
            Else
                ChkTra_Gop.Checked = False
            End If
        End If

        If DsTmp.Tables(0).Columns.Contains("Ma_HT_Dv") Then CmbMa_HT_Dv.SelectedValue = DsTmp.Tables(0).Rows(0).Item("Ma_HT_Dv").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ma_NH") Then CmbMa_NH.SelectedValue = DsTmp.Tables(0).Rows(0).Item("Ma_NH").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Ma_Gop") Then TxtMa_Gop.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Gop").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Ten_Gop") Then TxtTen_Gop.Text = DsTmp.Tables(0).Rows(0).Item("Ten_Gop").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("HD_Gop") Then TxtHd_Gop.Text = DsTmp.Tables(0).Rows(0).Item("HD_Gop").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Don_Gia") Then TxtDon_Gia.Double = DsTmp.Tables(0).Rows(0).Item("Don_Gia").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dang_Ky") Then TxtDang_Ky.Double = DsTmp.Tables(0).Rows(0).Item("Dang_Ky").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Phi_Hs") Then TxtPhi_Hs.Double = DsTmp.Tables(0).Rows(0).Item("Phi_Hs").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Phi_Tham_Gia") And TxtPhi_Tham_Gia.Double = 0 Then TxtPhi_Tham_Gia.Double = DsTmp.Tables(0).Rows(0).Item("Phi_Tham_Gia").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("HH") Then TxtHH.Double = DsTmp.Tables(0).Rows(0).Item("HH").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("T_Pk") Then TxtT_Pk.Double = DsTmp.Tables(0).Rows(0).Item("T_Pk").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Giam_Gia") Then TxtGiam_Gia.Double = DsTmp.Tables(0).Rows(0).Item("Giam_Gia").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("TT_QuetThe") Then TxtTT_QuetThe.Double = DsTmp.Tables(0).Rows(0).Item("TT_QuetThe").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Phi_QuetThe") Then TxtPhi_QuetThe.Double = DsTmp.Tables(0).Rows(0).Item("Phi_QuetThe").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Phi_QuetThe_TM") Then TxtPhi_QuetThe_TM.Double = DsTmp.Tables(0).Rows(0).Item("Phi_QuetThe_TM").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("TT_CK") Then TxtTT_CK.Double = DsTmp.Tables(0).Rows(0).Item("TT_CK").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Gop_Xe") Then TxtGop_Xe.Double = DsTmp.Tables(0).Rows(0).Item("Gop_Xe").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Gop_Pk") Then TxtGop_Pk.Double = DsTmp.Tables(0).Rows(0).Item("Gop_Pk").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("T_Gop") Then TxtT_Gop.Double = DsTmp.Tables(0).Rows(0).Item("T_Gop").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("TT_TM") Then TxtTT_TM.Double = DsTmp.Tables(0).Rows(0).Item("TT_TM").ToString.Trim
        '
        If DsTmp.Tables(0).Columns.Contains("Gia_NH") Then TxtGia_NH.Double = DsTmp.Tables(0).Rows(0).Item("Gia_NH").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Tra_Truoc_Nh") Then TxtTra_Truoc_Nh.Double = DsTmp.Tables(0).Rows(0).Item("Tra_Truoc_Nh").ToString.Trim

        Updatelist()
        DsTmp.Dispose()
    End Sub
#End Region
#Region "Trả góp"
    Private Sub V_Tra_Gop(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkTra_Gop.Checked Then TxtGop_Xe.Focus()
        If Not ChkTra_Gop.Checked Then
            TxtGop_Xe.Double = 0
            TxtGop_Pk.Double = 0
        End If
        Updatelist()
    End Sub
#End Region
#Region "Giá xuất theo ngày xuất xe"
    Private Sub V_Gia_Xuat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Tinh_Gia("1")
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Nh_HD1"
    Private Sub V_Nh_HD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHD", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_HD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HD1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_HD2"
    Private Sub V_Nh_HD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHD", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_HD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HD2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_HD3"
    Private Sub V_Nh_HD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHD", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_HD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HD3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_HD4"
    Private Sub V_Nh_HD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_SK", "DMSK", "1=1", "1=1")
    End Sub
    Private Sub L_Nh_HD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD4.Text = DrReturn.Item("Ma_SK")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_SK")
        Else
            TxtNh_HD4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_HD5"
    Private Sub V_Nh_HD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_HD5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhHD", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_HD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_HD5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_HD5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_HD5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Hs.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Hs_Online"
    Private Sub V_Ma_Hs_Online(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Hs_Online.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs_Online(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Hs_Online.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs_Online.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs_Online.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs_Online.Text = ""
            TxtTen_Hs_Online.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_KTV"
    Private Sub V_Ma_KTV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KTV.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KTV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_KTV.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KTV.Text = DrReturn.Item("Ma_Hs")
            TxtTen_KTV.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_KTV.Text = ""
            TxtTen_KTV.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_TP"
    Private Sub V_Ma_TP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TP.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TP", "DmTP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TP.Text = "" Then
            TxtTen_TP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TP.Text = DrReturn.Item("Ma_TP")
            TxtTen_TP.Text = DrReturn.Item("Ten_TP")
            TxtMa_TP2.Text = IIf(TxtMa_TP2.Text.Trim = "", DrReturn.Item("Ma_TP"), TxtMa_TP2.Text.Trim)
            TxtTen_TP2.Text = IIf(TxtTen_TP2.Text.Trim = "", DrReturn.Item("Ten_TP"), TxtTen_TP2.Text.Trim)
        Else
            TxtMa_TP.Text = ""
            TxtTen_TP.Text = ""
        End If

        V_Tinh_Gia("2")
    End Sub
#End Region
#Region "Valid --- Ma_Quan"
    Private Sub V_Ma_Quan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        If TxtMa_TP.Text.Trim = "" Then Exit Sub
        Dim _FilterClient As String = "1=1"
        Dim _Ma_TP = TxtMa_TP.Text.Trim
        If Not _Ma_TP = "" Then _FilterClient = " Ma_TP = '" + _Ma_TP + "'"
        TxtMa_Quan.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Quan", "DMQUAN", "1=1", _FilterClient)
    End Sub
    Private Sub L_Ma_Quan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TP.Text.Trim = "" Then Exit Sub
        If TxtMa_Quan.Text = "" Then
            TxtTen_Quan.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Quan.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Quan.Text = DrReturn.Item("Ma_Quan")
            If DrReturn.Table.Columns.Contains("Ten_Quan") Then
                TxtTen_Quan.Text = DrReturn.Item("Ten_Quan")
            Else
                TxtTen_Quan.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Quan", "DMQUAN", "(Ma_Quan = N'" + DrReturn("Ma_Quan").ToString.Trim + "')", CyberSmlib)
            End If
        Else
            TxtMa_Quan.Text = ""
            TxtTen_Quan.Text = ""
        End If

        If TxtMa_Quan.Text.Trim <> "" And TxtMa_Quan2.Text.Trim = "" Then
            TxtMa_Quan2.Text = TxtMa_Quan.Text.Trim
            TxtTen_Quan2.Text = TxtTen_Quan.Text.Trim
        End If

        V_Tinh_Gia("2")
    End Sub
#End Region
#Region "Valid --- Ma_Xa"
    Private Sub V_Ma_Xa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        If TxtMa_Quan.Text.Trim = "" Then Exit Sub
        Dim _FilterClient As String = "1=1"
        Dim _Ma_Quan = TxtMa_Quan.Text.Trim
        If Not _Ma_Quan = "" Then _FilterClient = " Ma_Quan = '" + _Ma_Quan + "'"
        TxtMa_Xa.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Xa", "DMXA", "1=1", _FilterClient)
    End Sub
    Private Sub L_Ma_Xa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Quan.Text.Trim = "" Then Exit Sub
        If TxtMa_Xa.Text = "" Then
            TxtTen_Xa.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Xa.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Xa.Text = DrReturn.Item("Ma_Xa")
            If DrReturn.Table.Columns.Contains("Ten_Xa") Then
                TxtTen_Xa.Text = DrReturn.Item("Ten_Xa")
            Else
                TxtTen_Xa.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Xa", "DMXA", "(Ma_Xa = N'" + DrReturn("Ma_Xa").ToString.Trim + "')", CyberSmlib)
            End If
        Else
            TxtMa_Xa.Text = ""
            TxtTen_Xa.Text = ""
        End If

        If TxtMa_Xa.Text.Trim <> "" And TxtMa_Xa2.Text.Trim = "" Then
            TxtMa_Xa2.Text = TxtMa_Xa.Text.Trim
            TxtTen_Xa2.Text = TxtTen_Xa.Text.Trim
        End If

        V_Tinh_Gia("2")
    End Sub
#End Region
#Region "Valid --- Ma_TP2"
    Private Sub V_Ma_TP2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_TP2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TP", "DmTP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TP2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TP2.Text = "" Then
            TxtTen_TP2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TP2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TP2.Text = DrReturn.Item("Ma_TP")
            TxtTen_TP2.Text = DrReturn.Item("Ten_TP")
        Else
            TxtMa_TP2.Text = ""
            TxtTen_TP2.Text = ""
        End If
    End Sub
    Private Sub V_Ma_TP2_Empty(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If TxtMa_TP.Text.Trim <> "" And TxtMa_TP2.Text.Trim = "" Then
            TxtMa_TP2.Text = TxtMa_TP.Text.Trim
            TxtTen_TP2.Text = TxtTen_TP.Text.Trim
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Quan2"
    Private Sub V_Ma_Quan2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        If TxtMa_TP2.Text.Trim = "" Then Exit Sub
        Dim _FilterClient As String = "1=1"
        Dim _Ma_TP2 = TxtMa_TP2.Text.Trim
        If Not _Ma_TP2 = "" Then _FilterClient = " Ma_TP = '" + _Ma_TP2 + "'"
        TxtMa_Quan2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Quan", "DMQUAN", "1=1", _FilterClient)
    End Sub
    Private Sub L_Ma_Quan2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TP2.Text.Trim = "" Then Exit Sub
        If TxtMa_Quan2.Text = "" Then
            TxtTen_Quan2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Quan2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Quan2.Text = DrReturn.Item("Ma_Quan")
            If DrReturn.Table.Columns.Contains("Ten_Quan") Then
                TxtTen_Quan2.Text = DrReturn.Item("Ten_Quan")
            Else
                TxtTen_Quan2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Quan", "DMQUAN", "(Ma_Quan = N'" + DrReturn("Ma_Quan").ToString.Trim + "')", CyberSmlib)
            End If
        Else
            TxtMa_Quan2.Text = ""
            TxtTen_Quan2.Text = ""
        End If

        If TxtMa_Quan.Text.Trim <> "" And TxtMa_Quan2.Text.Trim = "" Then
            TxtMa_Quan2.Text = TxtMa_Quan.Text.Trim
            TxtTen_Quan2.Text = TxtTen_Quan.Text.Trim
        End If
    End Sub
    Private Sub V_Ma_Quan2_Empty(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If TxtMa_Quan.Text.Trim <> "" And TxtMa_Quan2.Text.Trim = "" Then
            TxtMa_Quan2.Text = TxtMa_Quan.Text.Trim
            TxtTen_Quan2.Text = TxtTen_Quan.Text.Trim
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Xa2"
    Private Sub V_Ma_Xa2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        If TxtMa_Quan2.Text.Trim = "" Then Exit Sub
        Dim _FilterClient As String = "1=1"
        Dim _Ma_Quan2 = TxtMa_Quan2.Text.Trim
        If Not _Ma_Quan2 = "" Then _FilterClient = " Ma_Quan = '" + _Ma_Quan2 + "'"
        TxtMa_Xa2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Xa", "DMXA", "1=1", _FilterClient)
    End Sub
    Private Sub L_Ma_Xa2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Quan2.Text.Trim = "" Then Exit Sub
        If TxtMa_Xa2.Text = "" Then
            TxtTen_Xa2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Xa2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Xa2.Text = DrReturn.Item("Ma_Xa")
            If DrReturn.Table.Columns.Contains("Ten_Xa") Then
                TxtTen_Xa2.Text = DrReturn.Item("Ten_Xa")
            Else
                TxtTen_Xa2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Xa", "DMXA", "(Ma_Xa = N'" + DrReturn("Ma_Xa").ToString.Trim + "')", CyberSmlib)
            End If
        Else
            TxtMa_Xa2.Text = ""
            TxtTen_Xa2.Text = ""
        End If

        If TxtMa_Xa.Text.Trim <> "" And TxtMa_Xa2.Text.Trim = "" Then
            TxtMa_Xa2.Text = TxtMa_Xa.Text.Trim
            TxtTen_Xa2.Text = TxtTen_Xa.Text.Trim
        End If
    End Sub
    Private Sub V_Ma_Xa2_Empty(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        If TxtMa_Xa.Text.Trim <> "" And TxtMa_Xa2.Text.Trim = "" Then
            TxtMa_Xa2.Text = TxtMa_Xa.Text.Trim
            TxtTen_Xa2.Text = TxtTen_Xa.Text.Trim
        End If
    End Sub
#End Region
#Region "Khach hang"
    Private Sub V_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kh.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kh", "DMKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_Kh")
            TxtTen_Kh.Text = DrReturn.Item("Ten_Kh")
            TxtTen_HD.Text = IIf(TxtTen_HD.Text.Trim = "" And TxtMa_Kh.Text.Trim <> "KL", DrReturn.Item("Ten_Kh"), TxtTen_HD.Text.Trim)
            TxtDia_Chi.Text = IIf(TxtDia_Chi.Text.Trim = "", DrReturn.Item("Dia_chi"), TxtDia_Chi.Text.Trim)
            TxtDia_Chi2.Text = IIf(TxtDia_Chi2.Text.Trim = "", DrReturn.Item("Dia_chi"), TxtDia_Chi.Text.Trim)

            TxtTen_KhVAT.Text = IIf(TxtTen_KhVAT.Text.Trim = "" And TxtMa_Kh.Text.Trim <> "KL", DrReturn.Item("Ten_KHVat"), TxtTen_KhVAT.Text.Trim)
            TxtDia_ChiVAT.Text = IIf(TxtDia_ChiVAT.Text.Trim = "", DrReturn.Item("Dia_chiVat"), TxtDia_ChiVAT.Text.Trim)
            TxtMa_So_Thue.Text = IIf(TxtMa_So_Thue.Text.Trim = "", DrReturn.Item("Ma_So_Thue"), TxtMa_So_Thue.Text.Trim)
            TxtDT1.Text = IIf(TxtDT1.Text.Trim = "", DrReturn.Item("Dien_Thoai"), TxtDT1.Text.Trim)
        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
        End If
    End Sub
    Private Sub V_Dia_Chi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtDia_ChiVAT.Text.Trim = "" Then TxtDia_ChiVAT.Text = TxtDia_Chi.Text
        If TxtDia_Chi2.Text.Trim = "" Then TxtDia_Chi2.Text = TxtDia_Chi.Text
        If TxtDC_LH.Text.Trim = "" Then TxtDC_LH.Text = TxtDia_Chi.Text
    End Sub
    Private Sub V_Dia_ChiVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtDia_Chi.Text.Trim = "" Then TxtDia_Chi.Text = TxtDia_ChiVAT.Text
    End Sub
    Private Sub V_Ten_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTen_KhVAT.Text.Trim = "" Then TxtTen_KhVAT.Text = TxtTen_HD.Text
        If TxtOng_Ba.Text.Trim = "" Then TxtOng_Ba.Text = TxtTen_HD.Text
        If TxtDai_Dien.Text.Trim = "" Then TxtDai_Dien.Text = TxtTen_HD.Text
    End Sub
    Private Sub V_Ten_KhVat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTen_HD.Text.Trim = "" Then TxtTen_HD.Text = TxtTen_KhVAT.Text
    End Sub
#End Region
#Region "Valid - Ma_Kh_Dk"
    Private Sub V_Ma_KH_DK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KH_DK.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kh", "DMKH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KH_DK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_KH_DK.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KH_DK.Text = DrReturn.Item("Ma_Kh")
            TxtTen_KH_DK.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtMa_KH_DK.Text = ""
            TxtTen_KH_DK.Text = ""
        End If
    End Sub
#End Region
#Region "Valid - Ma_NH_QuetThe"
    Private Sub V_Ma_Nh_QuetThe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Nh_QuetThe.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DMNH", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Nh_QuetThe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Nh_QuetThe.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Nh_QuetThe.Text = DrReturn.Item("Ma_NH")
            TxtTen_Nh_QuetThe.Text = DrReturn.Item("Ten_NH")
        Else
            TxtMa_Nh_QuetThe.Text = ""
            TxtTen_Nh_QuetThe.Text = ""
        End If
    End Sub
#End Region
#Region "Valid - Ma_Gop"
    Private Sub V_Ma_Gop(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Gop.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Gop", "DMMAGOP", "1=1", "Ma_Kh = '" & CmbMa_NH.SelectedValue.ToString.Trim & "'")
    End Sub
    Private Sub L_Ma_Gop(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Gop.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Gop.Text = DrReturn.Item("Ma_Gop")
            TxtTen_Gop.Text = DrReturn.Item("Ten_Gop")
        Else
            TxtMa_Gop.Text = ""
            TxtTen_Gop.Text = ""
        End If
        V_GetPhiTG()
    End Sub
    Private Sub V_GetPhiTG()
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        Dim _Dt As Date = TxtNgay_HD1.Value
        Dim _Online As String = "0"
        Dim _Ma_NH As String = CmbMa_NH.SelectedValue.ToString.Trim
        Dim _Ma_Gop As String = TxtMa_Gop.Text.Trim
        Dim _T_Gop As Double = TxtT_Gop.Double
        Dim _Ma_TTLN As String = CmbMa_TTLN.SelectedValue.ToString
        Dim _Tien_Online As Double = TxtTra_Gop_Online.Double
        Dim _PT_Phi_Online As Double = TxtPT_Phi_Online.Double

        If ChkOnline.Checked = True Then _Online = "1"

        Dim _DsPhi As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetPhiTG_DMHD", _Dt.ToString("yyyyMMdd") & "#" & M_Mode.Trim & "#" & _
                                                                   _Online.Trim & "#" & _Ma_NH & "#" & _Ma_Gop & "#" & _T_Gop.ToString.Trim & "#" & _Tien_Online & "#" & _PT_Phi_Online & "#" & _Ma_TTLN & "#" & M_Ma_Dvcs.Trim & "#" & M_User_Name.Trim)

        Dim _ncount As Integer = _DsPhi.Tables.Count

        If _ncount < 1 Then
            _DsPhi.Dispose()
            Exit Sub
        End If
        If Not CyberSupport.V_MsgChk(_DsPhi.Tables(_ncount - 1), Me.oSysvar, Me.M_LAN) Then
            _DsPhi.Dispose()
            Exit Sub
        End If

        'Update phí
        If _ncount < 2 Then
            _DsPhi.Dispose()
            Exit Sub
        End If

        If _DsPhi.Tables(0).Rows.Count < 1 Then
            _DsPhi.Dispose()
            Exit Sub
        End If

        If _DsPhi.Tables(0).Columns.Contains("Phi_Tham_Gia") Then TxtPhi_Tham_Gia.Double = _DsPhi.Tables(0).Rows(0).Item("Phi_Tham_Gia")

        Updatelist()
    End Sub
#End Region
#Region "Valid - Ma_Kh_Online"
    Private Sub V_Ma_Kh_Online(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kh_Online.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kh", "DMKHOnline", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh_Online(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Kh_Online.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh_Online.Text = DrReturn.Item("Ma_Kh")
            TxtTen_Kh_Online.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtMa_Kh_Online.Text = ""
            TxtTen_Kh_Online.Text = ""
        End If
    End Sub
#End Region
#Region "Ma_HT_Dv"
    Private Sub L_Ma_HT_Dv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        V_Tinh_Gia("1")
        Updatelist()
    End Sub
#End Region
#End Region
#Region "Button"
    Private Function V_GetTTCP() As String
        Dim _Return As String = ""
        Try
            _Return = CmbMa_TTCP.SelectedValue.ToString.Trim
        Catch ex As Exception

        End Try
        V_GetTTCP = _Return
    End Function
    Private Function V_GetTTLN() As String
        Dim _Return As String = ""
        Try
            _Return = CmbMa_TTLN.SelectedValue.ToString.Trim
        Catch ex As Exception

        End Try
        V_GetTTLN = _Return
    End Function
    Private Function V_Tao_Va_Kiem_Tra() As Boolean
        Dim _StrField As String = ""
        Dim _StrValue As String = ""
        CyberSmodb.GetValueControler(Me, _StrField, _StrValue)
        Dim _Ngay_Ct As Date = TxtNgay_HD1.Value
        Dim _Ma_TTLN As String = V_GetTTLN()
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_ChkSaveDmHD", M_Mode & "#" & _Ma_TTLN & "#" & _Ngay_Ct.ToString("yyyyMMdd") & "#" & _StrField & "#" & _StrValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Return False
        End If
        If M_Mode.Trim = "M" Then TxtMa_HD.Text = DsTmp.Tables(0).Rows(0).Item("Ma_HD").ToString.Trim
        Return True
    End Function
    Private Sub V_SavePrint(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not V_Tao_Va_Kiem_Tra() Then Exit Sub
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        If IsDBNull(TxtNgay_Sinh.Value) Then
            TxtNgay_Sinh.Value = New Date(1900, 1, 1)
        End If

        If IsDBNull(TxtNgay_Cap.Value) Then
            TxtNgay_Cap.Value = New Date(1900, 1, 1)
        End If

        If IsDBNull(TxtNgay_HD2.Value) Then
            TxtNgay_HD2.Value = New Date(1900, 1, 1)
        End If

        '----------------------------------------------------------
        If Not V_Tao_Va_Kiem_Tra() Then Exit Sub

        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub

        ' CTHD ----------------------------------------------------
        If ChkIs_Xe_lo.Checked Then
            For irow As Integer = 0 To Tb_MasterCtHd.Rows.Count - 1
                Tb_MasterCtHd.Rows(irow)("Ma_Dvcs") = M_Ma_Dvcs
                Tb_MasterCtHd.Rows(irow)("Ma_Hd") = TxtMa_HD.Text.Trim
                Tb_MasterCtHd.Rows(irow)("Ma_TTLN") = CmbMa_TTLN.SelectedValue.ToString
                Tb_MasterCtHd.Rows(irow)("Ma_TTCP") = CmbMa_TTCP.SelectedValue.ToString
                Tb_MasterCtHd.Rows(irow)("Stt_rec0") = CyberSupport.GetStt_Rec0(irow + 1)
            Next
            CyberSmodb.V_CyberBulkSaveToSQL(Appconn, oSysvar, M_User_Name, Tb_MasterCtHd, "CTDMHD", "S", "Ma_hd = N'" & TxtMa_HD.Text.Trim & "'", True)
        End If
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Xu ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
#Region "Bán sỉ"
    Private Sub V_Is_Xe_lo()
        If ChkIs_Xe_lo.Checked Then CmdBan_Buon.Enabled = True Else CmdBan_Buon.Enabled = False
        If ChkIs_Xe_lo.Checked Then CmdBan_Buon.Visible = True Else CmdBan_Buon.Visible = False
    End Sub
    Private Sub V_Is_Xe_lo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Is_Xe_lo()
        If ChkIs_Xe_lo.Checked = False Then Exit Sub
    End Sub
    Private Sub V_XemHDBanSi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkIs_Xe_lo.Checked = False Then Exit Sub

        Tb_MasterCtHdTmp = New DataTable
        Tb_MasterCtHdTmp = Tb_MasterCtHd.Copy

        DV_DetailCtHd = New DataView(Tb_DetailCtHdTmp)
        DV_MasterCtHd = New DataView(Tb_MasterCtHdTmp)

        Dim Frm As New CTDmHDXM
        Frm.Dt_Master = Tb_MasterCtHdTmp
        Frm.Dt_head = Tb_DetailCtHdTmp
        Frm.Dv_Master = DV_MasterCtHd
        Frm.Dv_head = DV_DetailCtHd
        Frm.Lan = M_LAN
        Frm.Para = M_Para
        Frm.Sysvar = oSysvar
        Frm.AppConn = Appconn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.ShowDialog()
        If Frm.Save_OK = False Then Exit Sub
        Tb_MasterCtHd.Rows.Clear()
        Tb_MasterCtHd.AcceptChanges()
        For i = 0 To Tb_MasterCtHdTmp.Rows.Count - 1
            Tb_MasterCtHd.ImportRow(Tb_MasterCtHdTmp.Rows(i))
        Next
    End Sub
#End Region
#Region "Kỳ thanh toán"
    Private Sub V_XemCTTTHD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ''If TxtCong_No.Double = 0 Then Exit Sub

        Tb_MasterCTTTHdTmp = New DataTable
        Tb_MasterCTTTHdTmp = Tb_MasterCTTTHd.Copy

        DV_DetailCTTTHd = New DataView(Tb_DetailCTTTHdTmp)
        DV_MasterCTTTHd = New DataView(Tb_MasterCTTTHdTmp)

        Dim Frm As New CTTTDMHDXM
        Frm.Dt_Master = Tb_MasterCTTTHdTmp
        Frm.Dt_head = Tb_DetailCTTTHdTmp
        Frm.Dv_Master = DV_MasterCTTTHd
        Frm.Dv_head = DV_DetailCTTTHd
        Frm.Lan = M_LAN
        Frm.Para = M_Para
        Frm.Sysvar = oSysvar
        Frm.AppConn = Appconn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.TxtT_Tien_No.Double = TxtCong_No.Double
        Frm.ShowDialog()
        If Frm.Save_OK = False Then Exit Sub
        Tb_MasterCTTTHd.Rows.Clear()
        Tb_MasterCTTTHd.AcceptChanges()
        For i = 0 To Tb_MasterCTTTHdTmp.Rows.Count - 1
            Tb_MasterCTTTHd.ImportRow(Tb_MasterCTTTHdTmp.Rows(i))
        Next
    End Sub
#End Region
#Region "LookUp Lists from Storeprocedure"
    Private Sub V_SoKhung(ByVal sender As Object, ByVal e As EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DsLookup.Tables.Contains("DMSOKHUNG") = False Then
            Dim DsDmLookup As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetDataDmSoKhung", M_Ma_Dvcs & "#" & M_User_Name)
            Dim TbDmLookUp As DataTable = DsDmLookup.Tables(0).Copy
            TbDmLookUp.TableName = "DMSOKHUNG"
            DsLookup.Tables.Add(TbDmLookUp)
        End If
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "So_Khung", "DMSOKHUNG", "1=1", "1=1")
    End Sub
    Private Sub L_SoKhung(ByVal sender As Object, ByVal e As EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtSo_Khung.Text = DrReturn.Item("So_Khung")
        Else
            TxtSo_Khung.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
End Class