Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class Sys
    Public Sub Initvao(ByVal M_Para As String())
        Dim CyberCalculatorCustom As New Cyber.CalculatorCustom.Sys
        If CyberCalculatorCustom.Initvao(M_Para) Then Exit Sub

        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
        Dim M_CP_Name As String = M_Para(M_VT_PARA + 1).Trim
        Dim M_User_Name As String = M_Para(6).Trim
        Dim M_Lan As String = M_Para(13).Trim
        Dim M_Ma_Dvcs As String = M_Para(14).Trim
        Dim M_Bar As String = M_Para(11).Trim
        Dim M_Bar2 As String = M_Para(12).Trim
        Dim _Title As String = "Đang thực hiện: " + M_Bar
        Dim _Title2 As String = "Processing: " + M_Bar2
        Dim CyberSmlib As New Cyber.SmLib.Sys
        Dim CyberSupport As New Cyber.Support.Sys
        Dim CyberFill As New Cyber.Fill.Sys
        Dim CyberSmlistSys As New Cyber.SmLists.Sys
        Dim CyberSmodb As New Cyber.Smodb.Sys
        Dim CyberEport As New Cyber.Export.Sys
        Dim CyberVoucher As New Cyber.Voucher.Sys
        Dim CyberLoading = New Cyber.Loading.Loading


        Dim Appconn As SqlConnection = CyberSmlib.GetConn()
        Dim oSysvar As Collection = CyberSmlib.IniSysVar(Appconn, M_Ma_Dvcs, M_User_Name)
        M_CP_Name = M_CP_Name.Trim.ToUpper

        Dim Frm As Cyber.From.FrmCalculator
        Dim M_strParameterStore As String = ""
        '-------------------------------------------------------------------------------------------------------------------------------------
        '-------------------SM
        If M_CP_Name = "CP_Maintain".ToUpper.Trim Then Frm = New FrmMaintain '---Bảo trì và kiểm tra số liệu
        If M_CP_Name = "Funny".ToUpper.Trim Then Frm = New Funny '---Bảo trì và kiểm tra số liệu
        If M_CP_Name = "CP_ReviewVoucher".ToUpper.Trim Then Frm = New ReviewVoucher '---Bảo trì và kiểm tra số liệu
        If M_CP_Name = "CP_IXPDATA".ToUpper.Trim Then Frm = New IXPDATA
        If M_CP_Name = "CP_SysKPI".ToUpper.Trim Then Frm = New FSysKPI
        'If M_CP_Name = "CP_CyberFTP".Trim.ToUpper Then Frm = New FrmFTP
        '-------------------------------------------------------------------------------------------------------------------------------------
        Dim _Stt_Rec_ARAP As String = ""
        If M_CP_Name = "CP_ARAPTTPB".ToUpper.Trim Then
            Dim _TK As String = ""
            Dim _Ma_kh As String = ""
            Try
                _Stt_Rec_ARAP = M_Para(M_VT_PARA + 2)
            Catch ex As Exception

            End Try
            Try
                _TK = M_Para(M_VT_PARA + 3)
            Catch ex As Exception

            End Try
            Try
                _Ma_kh = M_Para(M_VT_PARA + 4)
            Catch ex As Exception

            End Try
            M_strParameterStore = "1" & "#" & _Stt_Rec_ARAP & "#" & _TK & "#" & _Ma_kh & "#" & "19000101" & "#" & "19000101" & "#" & M_Ma_Dvcs & "#" & M_User_Name
            If _Stt_Rec_ARAP <> "" Then GoTo _Continu
            Frm = New ARAPTTPBLOC
        End If
        '---------------------------------------------------------------------------------------
        If M_CP_Name = "CP_ShowTivi".ToUpper.Trim Then
            Dim Frm1 = New FrmShowTivi
            Dim _Ma_Loai As String = ""
            Try
                _Ma_Loai = M_Para(M_VT_PARA + 2).Trim
            Catch ex As Exception
            End Try
            Frm1.Ma_Loai = _Ma_Loai
            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.ShowDialog()
            Return
        End If

        If M_CP_Name = "CP_DNCapTK".ToUpper.Trim Then
            Dim Frm1 = New FrmUserName
            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.ShowDialog()
            Return
        End If

        If M_CP_Name = "CP_SmViewLog".ToUpper.ToString Then
            Dim Frm1 = New FrmLogfile
            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.ShowDialog()
            Return
        End If
        '---------------------------------------------------------------------------------------
        If M_CP_Name.Trim.ToUpper = "CP_SMUSERDNCAPTK".Trim.ToUpper Then
            Dim Frm1 = New FrmUserName
            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.ShowDialog()
            Return
        End If

        '---------------------------------------------------------------------------------------
        If M_CP_Name = "CP_GLTC20".Trim.ToUpper Then Frm = New GLTC20Loc
        '-------------------PK3/Pk4
        If M_CP_Name = "CP_GLCTPK3Loc".Trim.ToUpper Then Frm = New FrmNam
        If M_CP_Name = "CP_GLCTPK4Loc".Trim.ToUpper Then Frm = New GLCTPK4LOC
        If M_CP_Name = "CP_GLCTPK8".Trim.ToUpper Then Frm = New ThangToThangTk
        If M_CP_Name = "CP_GLClosing".Trim.ToUpper Then Frm = New ThangToThang


        '--------------------TK3,TK4
        '---2019.10.25

        If M_CP_Name = "CP_GLCTKT3Loc".Trim.ToUpper Then Frm = New FrmNam
        If M_CP_Name = "CP_GLCTKT4Loc".Trim.ToUpper Then Frm = New GLCTKT4LOC
        If M_CP_Name = "CP_GLCTKT8".Trim.ToUpper Then Frm = New ThangToThangTk
        If M_CP_Name = "CP_GLClosing".Trim.ToUpper Then Frm = New ThangToThang
        '---2019.10.25
        '-------------------Chuyen doi so du
        If M_CP_Name = "CP_ConvertNextYear".Trim.ToUpper Then Frm = New ConvertNextYear
        If M_CP_Name = "CP_ConvertNextYear".Trim.ToUpper Then M_CP_Name = M_CP_Name.Trim & M_Para(M_VT_PARA + 2).Trim
        '-------------------Tinh gia von
        If M_CP_Name = "CP_InGiaCost".ToUpper.Trim Then Frm = New InGiaCost '---
        '-------------------Tinh gia von cong cu dung cu
        If M_CP_Name = "CP_ImGiaCost".ToUpper.Trim Then Frm = New ImGiaCost '---
        If M_CP_Name = "CP_IMTINHPB".ToUpper.Trim Then Frm = New ImTinhPB
        If M_CP_Name = "CP_IMbtpbCC".ToUpper.Trim Then Frm = New IMBTPBCC '---Tao but toan khau hao
        If M_CP_Name = "CP_ImThoiPBLoc".ToUpper.Trim Then Frm = New IMThoiPbLoc '---Thoi phan bo cong cu dung cu
        If M_CP_Name = "CP_IMSuaPBLoc".ToUpper.Trim Then Frm = New IMSuaPBLoc '---Thoi phan bo cong cu dung cu
        If M_CP_Name = "CP_ImDcCcLoc".ToUpper.Trim Then Frm = New IMThoiPbLoc '---Dieu chuyen cong cu
        '-------------------Tai san
        If M_CP_Name = "CP_FATINHKH".ToUpper.Trim Then Frm = New FATinhKh
        If M_CP_Name = "CP_Fabtpbts".ToUpper.Trim Then Frm = New FABTPBTS '---Tao but toan khau hao
        If M_CP_Name = "CP_FaSuaKHLoc".ToUpper.Trim Then Frm = New FaSuaKHLoc '---ĐIều chỉnh khấu hao tài sản cố định
        If M_CP_Name = "CP_FaThoiKHLoc".ToUpper.Trim Then Frm = New FAThoiKHLoc '---ĐIều chỉnh khấu hao tài sản cố định
        If M_CP_Name = "CP_FaGiamTsLoc".ToUpper.Trim Then Frm = New FAThoiKHLoc '---ĐIều chỉnh Giam tai san co dinh
        If M_CP_Name = "CP_FaDcTsLoc".ToUpper.Trim Then Frm = New FAThoiKHLoc '---Dieu chuyen tai san
        If M_CP_Name = "CP_FATgNgLoc".ToUpper.Trim Then Frm = New FATgNgLoc '---Dieu chuyen tai san

        '-------------------Tai sanVAT
        If M_CP_Name = "CP_FATINHKHVAT".ToUpper.Trim Then Frm = New FATinhKhVAT
        If M_CP_Name = "CP_FabtpbtsVAT".ToUpper.Trim Then Frm = New FABTPBTSVAT '---Tao but toan khau hao
        If M_CP_Name = "CP_FaSuaKHLocVAT".ToUpper.Trim Then Frm = New FASuaKHLocVAT '---ĐIều chỉnh khấu hao tài sản cố định
        If M_CP_Name = "CP_FaThoiKHLocVAT".ToUpper.Trim Then Frm = New FAThoiKHLocVAT '---ĐIều chỉnh khấu hao tài sản cố định
        If M_CP_Name = "CP_FaGiamTsLocVAT".ToUpper.Trim Then Frm = New FAThoiKHLocVAT '---ĐIều chỉnh Giam tai san co dinh
        If M_CP_Name = "CP_FaDcTsLocVAT".ToUpper.Trim Then Frm = New FAThoiKHLocVAT '---Dieu chuyen tai san
        If M_CP_Name = "CP_FATgNgLocVAT".ToUpper.Trim Then Frm = New FATgNgLocVAT '---Dieu chuyen tai san

        '-------------------Gia thanh san xuat
        If M_CP_Name = "CP_COTINHGT".ToUpper.Trim Then Frm = New COTinhGT '---Tinh gia thanh san xuat
        If M_CP_Name = "CP_COTINHAPGIA".ToUpper.Trim Then Frm = New COTinhApGia '---Tinh gia thanh san xuat
        '---------------------------------------------------------------------------------------
        '-----Ket thuc phan ke toan
        '---------------------------------------------------------------------------------------
        If M_CP_Name = "CP_BHHDLDCLOC".ToUpper.Trim Then Frm = New BHHDLDCLOC '---Tinh gia thanh san xuat
        '-----Ket thuc phan phan he ban hang
        '---------------------------------------------------------------------------------------
        If M_CP_Name = "CP_ROXPT".ToUpper.ToString Then Frm = New ROXPT

        If M_CP_Name = "CP_VTTraCuuTon".ToUpper.Trim Then Frm = New VTTraCuuTon '---Tinh gia thanh san xuat
        '-----Ket thuc phan phan ton kho
        '---------------------------------------------------------------------------------------
        If M_CP_Name = "CP_Ro_Up_Hang".ToUpper.Trim Then Frm = New Ro_Up_Hang_Loc '---Update lệnh hãng
        '---------------------------------------------------------------------------------------

        '----Ban xe
        If M_CP_Name = "CP_BeGiaCost".ToUpper.Trim Then Frm = New BeGiaCost 'Xe
        If M_CP_Name = "CP_BEXEPXE".ToUpper.Trim Then Frm = New BEXEPXELOC 'Xep Xe
        If M_CP_Name = "CP_BELAPKHGX_Load".ToUpper.Trim Then Frm = New BELapKHGX_Filter 'Xep Xe

        If M_CP_Name = "CP_RODmSoKmXeSave".ToUpper.Trim Then
            CyberSupport.V_DmSokmXe(Appconn, oSysvar, M_Para, "", M_Lan, False, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, Nothing, CyberVoucher, CyberLoading)
            Return
        End If

        If M_CP_Name = "CP_LOADHEADERMIP".ToUpper.ToString Then Frm = New ROTINHMIP

        '---------------------------------------------------------------------------------------
        If M_CP_Name = "CP_VOD_XLKN_LOAD".ToUpper.Trim Then
            Dim Frm1 = New FrmVOD_XLTM
            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.ShowDialog()
            Return
        End If

        '---------------------------------------------------------------------------------------VOC
        If M_CP_Name = "CP_VOC_XLKN_LOAD".ToUpper.Trim Then
            Dim Frm1 = New FrmVOC_XLKN 'Xep Xe
            'Dim _Ma_Xe As String = ""
            'Try
            '    _Ma_Xe = M_Para(M_VT_PARA + 2).Trim
            'Catch ex As Exception

            'End Try
            'Frm1.ma_Xe = _Ma_Xe
            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.ShowDialog()
            Return
        End If
        '---------------------------------------------------------------------------------------Xác nhận

        If M_CP_Name.ToUpper.Trim = "CP_RoXacNhanLenh_Load".ToUpper.Trim Then
            Frm = New FrmXacNhan
            Frm.Lan = M_Lan
            Frm.Para = M_Para
            Frm.Sysvar = oSysvar
            Frm.AppConn = Appconn
            Frm.CyberSmlib = CyberSmlib
            Frm.CyberSupport = CyberSupport
            Frm.CyberFill = CyberFill
            Frm.CyberSmlistSys = CyberSmlistSys
            Frm.CyberSmodb = CyberSmodb
            Frm.CyberExport = CyberEport
            Frm.CyberVoucher = CyberVoucher
            Frm.CyberLoading = CyberLoading
            Frm.ShowDialog()
            If Not Frm.Save_OK Then Exit Sub
            Return
        End If

        '---------------------------------------------------------------------------------------
        If M_CP_Name = "CP_BEGETKH".ToUpper.Trim Then

            Dim Frm_Filter_KH = New BEGETKH_Filter
            Frm_Filter_KH.Para = M_Para
            Frm_Filter_KH.Sysvar = oSysvar
            Frm_Filter_KH.AppConn = Appconn
            Frm_Filter_KH.CyberSmlib = CyberSmlib
            Frm_Filter_KH.CyberSupport = CyberSupport
            Frm_Filter_KH.CyberFill = CyberFill
            Frm_Filter_KH.CyberSmlistSys = CyberSmlistSys
            Frm_Filter_KH.CyberSmodb = CyberSmodb
            Frm_Filter_KH.CyberExport = CyberEport
            Frm_Filter_KH.CyberVoucher = CyberVoucher
            Frm_Filter_KH.CyberLoading = CyberLoading
            Frm_Filter_KH.ShowDialog()
            M_strParameterStore = Frm_Filter_KH.Tag.ToString.Trim

            If Not Frm_Filter_KH.Save_OK Then Exit Sub
            If M_strParameterStore.Trim = "" Then Exit Sub
            Dim _Loai_Kh As String = Frm_Filter_KH.Loai_KH.ToString.Trim
            If _Loai_Kh = "1" Then M_CP_Name = "CP_BEGetKHCT" Else M_CP_Name = "CP_BEGetKHTH"

            If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, M_Lan)
            Dim DsCalculator1 As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, M_CP_Name.Trim, "1#" & M_strParameterStore)
            If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()

            Dim _Dt_Master, _Dt_Head As DataTable

            _Dt_Master = DsCalculator1.Tables(0).Copy
            _Dt_Head = DsCalculator1.Tables(1).Copy

            Dim Frm1 As BEGETKH_XEM
            Frm1 = New BEGETKH_XEM

            Frm1.Loai_KH = _Loai_Kh
            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name
            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator1
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized

            Frm1.Key_Sub1 = Frm_Filter_KH.Key_Sub1.ToString.Trim
            Frm1.Key_Sub2 = Frm_Filter_KH.Key_Sub1.ToString.Trim

            Frm1.Ma_Kx = Frm_Filter_KH.Key_Sub1.ToString.Trim
            Frm1.Ma_Mau = Frm_Filter_KH.Key_Sub1.ToString.Trim
            Frm1.Thang1 = Frm_Filter_KH.Thang1.ToUpper.Trim
            Frm1.Thang2 = Frm_Filter_KH.Thang2.ToUpper.Trim
            Frm1.Nam = Frm_Filter_KH.Nam.ToUpper.Trim

            Frm1.ShowDialog()
            Exit Sub
        End If
        '---------------------------------------------------------------------------------------
        '----Phan hệ quản lý sửa chữa
        If M_CP_Name = "CP_ROTRANLOC".Trim.ToUpper Then Frm = New ROTRAN
        If M_CP_Name = "CP_ROCLOSE".Trim.ToUpper Then Frm = New ROCLOSE
        If M_CP_Name = "CP_UPDATEGIA2".Trim.ToUpper Then Frm = New RoUpdateGia
        If M_CP_Name = "CP_ROXPT".Trim.ToUpper Then Frm = New ROXPT
        If M_CP_Name = "CP_RO_TinhDD".Trim.ToUpper Then Frm = New FrmTinhDD

        '---------------------------------------------------------------------------------------
        If M_CP_Name = "CP_CRMQLLLLoad".Trim.ToUpper Then
            ''If M_Para(M_VT_PARA + 2).ToString.Trim.ToUpper = "CA" Then Frm = New CRM_Xem_Loc_RO
            ''If M_Para(M_VT_PARA + 2).ToString.Trim.ToUpper = "CS" Then Frm = New CRM_Xem_Loc_CS
            Frm = New CRM_Loc
            Frm.Lan = M_Lan
            Frm.Para = M_Para
            Frm.Sysvar = oSysvar
            Frm.AppConn = Appconn
            Frm.CyberSmlib = CyberSmlib
            Frm.CyberSupport = CyberSupport
            Frm.CyberFill = CyberFill
            Frm.CyberSmlistSys = CyberSmlistSys
            Frm.CyberSmodb = CyberSmodb
            Frm.CyberExport = CyberEport
            Frm.CyberVoucher = CyberVoucher
            Frm.CyberLoading = CyberLoading
            Frm.ShowDialog()
            If Not Frm.Save_OK Then Exit Sub
            '-------------
            Dim Frm1 As New CRM_Xem
            Frm1.strLoc = Frm.Tag.ToString.Trim
            '-------------
            Frm1.Loai = Frm.Key_Sub3.ToString.Trim
            Frm1.Ma_Loai = Frm.Key_Sub4.ToString.Trim
            Frm1.Ma_Ngay = Frm.Key_Sub5.ToString.Trim

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.ShowDialog()
            Exit Sub
        End If
        If M_CP_Name = "CP_CRMQLLLTinh".Trim.ToUpper Then Frm = New CRMQLLLTinh
        'LOA ------------------------------------------------------------------------------------
        If M_CP_Name = "CP_LOAApproval".Trim.ToUpper Then
            Frm = New LOA_Loc
            Frm.Lan = M_Lan
            Frm.Para = M_Para
            Frm.Sysvar = oSysvar
            Frm.AppConn = Appconn
            Frm.CyberSmlib = CyberSmlib
            Frm.CyberSupport = CyberSupport
            Frm.CyberFill = CyberFill
            Frm.CyberSmlistSys = CyberSmlistSys
            Frm.CyberSmodb = CyberSmodb
            Frm.CyberExport = CyberEport
            Frm.CyberVoucher = CyberVoucher
            Frm.CyberLoading = CyberLoading
            Frm.ShowDialog()
            If Not Frm.Save_OK Then Exit Sub
            '-------------
            Dim Frm1 As New LOA_Xem
            Frm1.strLoc = Frm.Tag.ToString.Trim
            '-------------
            Frm1.Ma_CT = Frm.Key_Sub3.ToString.Trim
            Frm1.Ma_GD = Frm.Key_Sub4.ToString.Trim
            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.ShowDialog()
            Exit Sub
        End If
        '--------Dat lich hen-------------------------------------------------------------------------------
        If M_CP_Name = "CP_CRMDmHen".Trim.ToUpper Then
            Dim CyberWork As New Cyber.Workprogress.Sys
            Dim _Date As Date = New Date(1900, 1, 1)
            Dim _Loai_SC As String = "1"

            Dim M_Ma_TTCP_H As String = CyberSupport.V_GetDefault_TTCP("DLH", M_Ma_Dvcs, M_User_Name, Appconn, CyberSmlib)
            Dim Dt_Return As DataTable = CyberWork.V_Lich_Hen(M_Ma_TTCP_H, "DLH", "M", "HEN", _Loai_SC, "", "", "", "", "", "", "", _Date, _Date, Appconn, oSysvar, M_Lan, M_Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, Nothing, CyberLoading)

            Return
        End If
        '---------------------------------------------------------------------------------------
        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        '--------------------Ban xe may

        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        If M_CP_Name = "CP_XM1DMHDXM".ToUpper.Trim Then '--Hợp đồng bán xe
            Frm = New FrmDmHDXM
            Frm.Lan = M_Lan
            Frm.Para = M_Para
            Frm.Sysvar = oSysvar
            Frm.AppConn = Appconn
            Frm.CyberSmlib = CyberSmlib
            Frm.CyberSupport = CyberSupport
            Frm.CyberFill = CyberFill
            Frm.CyberSmlistSys = CyberSmlistSys
            Frm.CyberSmodb = CyberSmodb
            Frm.CyberExport = CyberEport
            Frm.CyberVoucher = CyberVoucher
            Frm.CyberLoading = CyberLoading
            Frm.ShowDialog()
            Return
        End If
        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        Frm.Lan = M_Lan
        Frm.Para = M_Para
        Frm.Sysvar = oSysvar
        Frm.AppConn = Appconn
        Frm.CyberSmlib = CyberSmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = CyberEport
        Frm.CyberVoucher = CyberVoucher
        Frm.CyberLoading = CyberLoading
        Frm.ShowDialog()
        If Not Frm.Save_OK Then Exit Sub
        '--------------
        'If M_CP_Name = "CP_BELAPKHGX_Load".ToUpper.Trim Then Return

        M_strParameterStore = Frm.Tag.ToString.Trim
        If M_CP_Name = "CP_BEXEPXE".ToUpper.Trim Then M_strParameterStore = "1#" + M_strParameterStore
        '--------------------------------------------------------------------------------------------------------------------------------------------------------


        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        If M_CP_Name = "CP_GLTC20".ToUpper.Trim Then
            Dim _FileName As String = Application.StartupPath.ToString.Trim & "\Help\" & Frm.Thang1.ToString.Trim & ".doc"
            If Not My.Computer.FileSystem.FileExists(_FileName) Then
                MsgBox("Không tồn tại tệp mẫu báo cáo, Bạn liên hệ với nhà cung cấp", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, oSysvar("M_CYBER_VER"))
                Exit Sub
            End If
        End If


        '--------------------------------------------------------------------------------------------------------------------------------------------------------
_Continu:
        '--------------
        If M_strParameterStore.Trim = "" Then Exit Sub
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, M_Lan)
        Dim DsCalculator As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, M_CP_Name.Trim, M_strParameterStore)
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        If M_CP_Name = "CP_BEXEPXE".ToUpper.Trim Then
            Dim _Dt_Master, _Dt_Head As DataTable
            _Dt_Master = DsCalculator.Tables(0).Copy
            _Dt_Head = DsCalculator.Tables(1).Copy

            Dim Frm1 As BEXEPXE_XEM
            Frm1 = New BEXEPXE_XEM

            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized

            Frm1.Key_Sub1 = Frm.Key_Sub1.ToString.Trim
            Frm1.Key_Sub2 = Frm.Key_Sub1.ToString.Trim

            Frm1.Ma_Kx = Frm.Key_Sub1.ToString.Trim
            Frm1.Ma_Mau = Frm.Key_Sub1.ToString.Trim
            Frm1.Thang1 = Frm.Thang1.ToUpper.Trim
            Frm1.Thang2 = Frm.Thang2.ToUpper.Trim
            Frm1.Nam1 = Frm.Nam1.ToUpper.Trim
            Frm1.Nam2 = Frm.Nam2.ToUpper.Trim
            Frm1.Nam = Frm.Nam.ToUpper.Trim



            Frm1.ShowDialog()
            Exit Sub
        End If
        If M_CP_Name = "CP_BELAPKHGX_Load".ToUpper.Trim Then
            Dim _Dt_Master, _Dt_Head As DataTable
            _Dt_Master = DsCalculator.Tables(0).Copy
            _Dt_Head = DsCalculator.Tables(1).Copy

            Dim Frm1 As BELapKHGX_XEM
            Frm1 = New BELapKHGX_XEM

            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized

            Frm1.Key_Sub1 = Frm.Key_Sub1.ToString.Trim
            Frm1.Key_Sub2 = Frm.Key_Sub1.ToString.Trim

            Frm1.Ma_Kx = Frm.Key_Sub1.ToString.Trim
            Frm1.Ma_Mau = Frm.Key_Sub1.ToString.Trim
            Frm1.Thang1 = Frm.Thang1.ToUpper.Trim
            Frm1.Thang2 = Frm.Thang2.ToUpper.Trim
            Frm1.Nam1 = Frm.Nam1.ToUpper.Trim
            Frm1.Nam2 = Frm.Nam2.ToUpper.Trim
            Frm1.Nam = Frm.Nam.ToUpper.Trim
            Frm1.M_Loai = Frm.Key_Sub3.ToString.Trim

            Frm1.ShowDialog()
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        If M_CP_Name = "CP_GLTC20".ToUpper.Trim Then
            Dim _FileName As String = Frm.Thang1.ToString.Trim & ".doc"
            V_GLTC20(DsCalculator, True, _FileName, M_Para, M_Lan, oSysvar)
            CyberSmlib.FlushMemorySave()
            Exit Sub
        End If
        If M_CP_Name = "CP_ARAPTTPB".ToUpper.Trim Then
            Dim Frm1 As ARAPTTPB
            Frm1 = New ARAPTTPB
            Dim M_CP_UPdate As String = ""

            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name
            Frm1.Cp_Update = M_CP_UPdate

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator
            If _Stt_Rec_ARAP.Trim = "" Then Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
            If _Stt_Rec_ARAP.Trim = "" Then Frm1.ShowDialog() Else Frm1.Show()
            'Frm1.ShowDialog()
            Exit Sub
        End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        If M_CP_Name = "CP_IMSuaPBLoc".ToUpper.Trim Or _
            M_CP_Name = "CP_ImDcCCLoc".ToUpper.Trim Or _
            M_CP_Name = "CP_FaSuaKHLoc".ToUpper.Trim Or _
            M_CP_Name = "CP_FaThoiKHLoc".ToUpper.Trim Or _
            M_CP_Name = "CP_FaGiamTsLoc".ToUpper.Trim Or _
            M_CP_Name = "CP_FaDcTsLoc".ToUpper.Trim Or _
            M_CP_Name = "CP_ImThoiPBLoc".ToUpper.Trim Then
            Dim _Dt_Master, _Dt_Head As DataTable
            _Dt_Master = DsCalculator.Tables(0).Copy
            _Dt_Head = DsCalculator.Tables(1).Copy

            Dim Frm1 As FaSuaKHXem
            Frm1 = New FaSuaKHXem
            Dim M_CP_UPdate As String = ""
            If M_CP_Name = "CP_FaSuaKHLoc".ToUpper.Trim Then M_CP_UPdate = "CP_FaSuaKhUPDATE"
            If M_CP_Name = "CP_FaThoiKHLoc".ToUpper.Trim Then M_CP_UPdate = "CP_FaThoiKHUpdate"
            If M_CP_Name = "CP_FaGiamTsLoc".ToUpper.Trim Then M_CP_UPdate = "CP_FaGiamTsUpdate"

            If M_CP_Name = "CP_ImThoiPBLoc".ToUpper.Trim Then M_CP_UPdate = "CP_ImThoiPBUpdate"
            If M_CP_Name = "CP_IMSuaPBLoc".ToUpper.Trim Then M_CP_UPdate = "CP_IMSuaPBUpdate"


            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name
            Frm1.Cp_Update = M_CP_UPdate

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
            Frm1.ShowDialog()
            Exit Sub
        End If
        If M_CP_Name = "CP_FaSuaKHLocVAT".ToUpper.Trim Or _
            M_CP_Name = "CP_FaThoiKHLocVAT".ToUpper.Trim Or _
            M_CP_Name = "CP_FaGiamTsLocVAT".ToUpper.Trim Or _
            M_CP_Name = "CP_FaDcTsLocVAT".ToUpper.Trim Then

            Dim _Dt_Master, _Dt_Head As DataTable
            _Dt_Master = DsCalculator.Tables(0).Copy
            _Dt_Head = DsCalculator.Tables(1).Copy

            Dim Frm1 As FASuaKHXemVAT
            Frm1 = New FASuaKHXemVAT
            Dim M_CP_UPdate As String = ""
            If M_CP_Name = "CP_FaSuaKHLocVAT".ToUpper.Trim Then M_CP_UPdate = "CP_FaSuaKhUPDATEVAT"
            If M_CP_Name = "CP_FaThoiKHLocVAT".ToUpper.Trim Then M_CP_UPdate = "CP_FaThoiKHUpdateVAT"
            If M_CP_Name = "CP_FaGiamTsLocVAT".ToUpper.Trim Then M_CP_UPdate = "CP_FaGiamTsUpdateVAT"

            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name
            Frm1.Cp_Update = M_CP_UPdate

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
            Frm1.ShowDialog()
            Exit Sub
        End If

        '------------------------------------------------------------------------------------------------
        If M_CP_Name = "CP_FATgNgLoc".ToUpper.Trim Then
            Dim _Dt_Master, _Dt_Head As DataTable
            _Dt_Master = DsCalculator.Tables(0).Copy
            _Dt_Head = DsCalculator.Tables(1).Copy


            Dim Frm1 As FATgNgXem
            Frm1 = New FATgNgXem
            Dim M_CP_UPdate As String = ""

            If M_CP_Name = "CP_FATgNgLoc".ToUpper.Trim Then M_CP_UPdate = "CP_FaTgNgUpDate"

            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name
            Frm1.Cp_Update = M_CP_UPdate

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
            Frm1.ShowDialog()
            Exit Sub
        End If
        If M_CP_Name = "CP_FATgNgLocVAT".ToUpper.Trim Then
            Dim _Dt_Master, _Dt_Head As DataTable
            _Dt_Master = DsCalculator.Tables(0).Copy
            _Dt_Head = DsCalculator.Tables(1).Copy


            Dim Frm1 As FATgNgXemVAT
            Frm1 = New FATgNgXemVAT
            Dim M_CP_UPdate As String = ""

            If M_CP_Name = "CP_FATgNgLocVAT".ToUpper.Trim Then M_CP_UPdate = "CP_FaTgNgUpDateVAT"

            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name
            Frm1.Cp_Update = M_CP_UPdate

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
            Frm1.ShowDialog()
            Exit Sub
        End If

        '------------------------------------------------------------------------------------------------
        If M_CP_Name = "CP_GLCTPK3Loc".ToUpper.Trim Then
            Dim _Dt_Master, _Dt_Head As DataTable
            _Dt_Master = DsCalculator.Tables(0).Copy
            _Dt_Head = DsCalculator.Tables(1).Copy
            Dim Frm1 As GLCTPK3
            Frm1 = New GLCTPK3
            Dim M_CP_UPdate As String = ""

            Frm1.Nam = Frm.Nam
            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name
            Frm1.Cp_Update = M_CP_UPdate

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
            Frm1.ShowDialog()
            Exit Sub
        End If
        '------------------------------------------------------------------------------------------------
        If M_CP_Name = "CP_GLCTPK4Loc".ToUpper.Trim Then
            Dim _Dt_Master, _Dt_Head As DataTable
            _Dt_Master = DsCalculator.Tables(0).Copy
            _Dt_Head = DsCalculator.Tables(1).Copy
            Dim Frm1 As GLCTPK4
            Frm1 = New GLCTPK4
            Dim M_CP_UPdate As String = ""

            Frm1.Nam = Frm.Nam
            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name
            Frm1.Cp_Update = M_CP_UPdate

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
            Frm1.ShowDialog()
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        '---2019.10.25
        If M_CP_Name = "CP_GLCTKT3Loc".ToUpper.Trim Then
            Dim _Dt_Master, _Dt_Head As DataTable
            _Dt_Master = DsCalculator.Tables(0).Copy
            _Dt_Head = DsCalculator.Tables(1).Copy
            Dim Frm1 As GLCTKT3
            Frm1 = New GLCTKT3
            Dim M_CP_UPdate As String = ""

            Frm1.Nam = Frm.Nam
            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name
            Frm1.Cp_Update = M_CP_UPdate

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
            Frm1.ShowDialog()
            Exit Sub
        End If
        '------------------------------------------------------------------------------------------------
        If M_CP_Name = "CP_GLCTKT4Loc".ToUpper.Trim Then
            Dim _Dt_Master, _Dt_Head As DataTable
            _Dt_Master = DsCalculator.Tables(0).Copy
            _Dt_Head = DsCalculator.Tables(1).Copy
            Dim Frm1 As GLCTKT4
            Frm1 = New GLCTKT4
            Dim M_CP_UPdate As String = ""

            Frm1.Nam = Frm.Nam
            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name
            Frm1.Cp_Update = M_CP_UPdate

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
            Frm1.ShowDialog()
            Exit Sub
        End If
        '---2019.10.25
        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        '----Ban Hang
        If M_CP_Name = "CP_BHHDLDCLOC".ToUpper.Trim Then

            Dim Frm1 As BHHDLDCLOCXEM
            Frm1 = New BHHDLDCLOCXEM

            Dim M_CP_UPdate As String = "CP_BHHDLDCUPDATE"

            Frm1.Nam = Frm.Nam
            Frm1.strLoc = M_strParameterStore
            Frm1.Cp_Loc = M_CP_Name
            Frm1.Cp_Update = M_CP_UPdate

            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.DsDataLoc = DsCalculator
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
            Frm1.ShowDialog()

            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        'If M_CP_Name = "CP_CRMQLLLLoad".Trim.ToUpper Then

        '    Dim Frm1 As CRM_Xem
        '    Frm1 = New CRM_Xem

        '    Dim M_CP_UPdate As String = "CP_CRMQLLLUpdate"

        '    Frm1.Nam = Frm.Nam
        '    Frm1.strLoc = Frm.Key_Sub1.ToString.Trim
        '    Frm1.Cp_Loc = M_CP_Name
        '    Frm1.Cp_Update = M_CP_UPdate

        '    Frm1.Lan = M_Lan
        '    Frm1.Para = M_Para
        '    Frm1.Sysvar = oSysvar
        '    Frm1.AppConn = Appconn
        '    Frm1.CyberSmlib = CyberSmlib
        '    Frm1.CyberSupport = CyberSupport
        '    Frm1.CyberFill = CyberFill
        '    Frm1.CyberSmlistSys = CyberSmlistSys
        '    Frm1.CyberSmodb = CyberSmodb
        '    Frm1.CyberExport = CyberEport
        '    Frm1.CyberVoucher = CyberVoucher
        '    Frm1.CyberLoading = CyberLoading
        '    Frm1.DsDataLoc = DsCalculator
        '    Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
        '    Frm1.Key_Sub2 = Frm.Key_Sub2.ToString.Trim
        '    Frm1.Key_Sub3 = Frm.Key_Sub3.ToString.Trim
        '    Frm1.Key_Sub4 = Frm.Key_Sub4.ToString.Trim

        '    Frm1.ShowDialog()
        '    Exit Sub
        'End If

        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        If M_CP_Name = "CP_Ro_Up_Hang".ToUpper.Trim Then
            Dim Frm1 As New Ro_Up_Hang_Xem
            Frm1.Cp_Loc = M_CP_Name
            Frm1.strLoc = M_strParameterStore
            Frm1.DsDataLoc = DsCalculator
            Frm1.Lan = M_Lan
            Frm1.Para = M_Para
            Frm1.Sysvar = oSysvar
            Frm1.AppConn = Appconn
            Frm1.CyberSmlib = CyberSmlib
            Frm1.CyberSupport = CyberSupport
            Frm1.CyberFill = CyberFill
            Frm1.CyberSmlistSys = CyberSmlistSys
            Frm1.CyberSmodb = CyberSmodb
            Frm1.CyberExport = CyberEport
            Frm1.CyberVoucher = CyberVoucher
            Frm1.CyberLoading = CyberLoading
            Frm1.WindowState = Windows.Forms.FormWindowState.Maximized
            Frm1.ShowDialog()
            Exit Sub
        End If
        '--------------------------------------------------------------------------------------------------------------------------------------------------------
        CyberSupport.V_MsgChk(DsCalculator.Tables(0), oSysvar, M_Para(13).Trim)
    End Sub
  
    Public Sub V_ARAPTTPB(ByVal M_Para As String(), ByVal _Stt_Rec As String, ByVal _Ma_Ct As String, ByVal _Tk As String, ByVal _ma_Kh As String, _
                          Optional ByVal Appconn As SqlConnection = Nothing, _
                          Optional ByVal CyberSmlib As Cyber.SmLib.Sys = Nothing)
        If CyberSmlib Is Nothing Then CyberSmlib = New Cyber.SmLib.Sys
        If Appconn Is Nothing Then Appconn = CyberSmlib.GetConn()
        '---Lay lai Paramter:
        Dim _Para As String()
        If _Tk.Trim = "" Then
            Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_ARAPTTPB_TK", _Stt_Rec & "#" & _Ma_Ct & "#" & _ma_Kh & "#" & M_Para(14) & "#" & M_Para(6).Trim)
            If _DsTmp.Tables.Count > 0 Then
                If _DsTmp.Tables(0).Rows.Count > 0 Then
                    If _DsTmp.Tables(0).Columns.Contains("TK") Then _Tk = _DsTmp.Tables(0).Rows(0).Item("Tk").ToString.Trim
                    If _DsTmp.Tables(0).Columns.Contains("Ma_KH") Then _ma_Kh = _DsTmp.Tables(0).Rows(0).Item("Ma_KH").ToString.Trim
                End If
            End If
        End If

        Dim strPara As String = CyberSmlib.V_StringParameter(M_Para)
        strPara = strPara & "#" & "CP_ARAPTTPB#" & _Stt_Rec & "#" & _Tk.Trim & "#" & _ma_Kh.Trim
        _Para = strPara.Split("#")
        Initvao(_Para)

    End Sub
    Public Sub V_XN_Don_Tiep(ByVal _ma_Xe As String, ByVal _ma_Ct As String, ByVal _Stt_Rec As String, _
                             ByVal _App As SqlConnection, ByVal osysvar As Collection, ByVal _Para As String(), ByVal _Lan As String, _
                          Optional ByVal _ShowInTaskbar As Boolean = True, _
                          Optional ByVal Cybersmlib As Cyber.SmLib.Sys = Nothing, _
                        Optional ByVal CyberSupport As Cyber.Support.Sys = Nothing, _
                        Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing, _
        Optional ByVal CyberSmlistSys As Cyber.SmLists.Sys = Nothing, _
        Optional ByVal CyberSmodb As Cyber.Smodb.Sys = Nothing, _
        Optional ByVal CyberEport As Cyber.Export.Sys = Nothing, _
        Optional ByVal CyberVoucher As Cyber.Voucher.Sys = Nothing, _
        Optional ByVal CyberLoading As Cyber.Loading.Loading = Nothing)

        If Cybersmlib Is Nothing Then Cybersmlib = New Cyber.SmLib.Sys
        If CyberSupport Is Nothing Then CyberSupport = New Cyber.Support.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys
        If CyberSmlistSys Is Nothing Then CyberSmlistSys = New Cyber.SmLists.Sys
        If CyberSmodb Is Nothing Then CyberSmodb = New Cyber.Smodb.Sys
        If CyberEport Is Nothing Then CyberEport = New Cyber.Export.Sys
        If CyberVoucher Is Nothing Then CyberVoucher = New Cyber.Voucher.Sys
        If CyberLoading Is Nothing Then CyberLoading = New Cyber.Loading.Loading

        Dim Frm As New FrmXNTiep_Don
        Frm.Ma_Xe = _ma_Xe
        Frm.Ma_Ct = _ma_Ct
        Frm.Stt_rec = _Stt_Rec

        Frm.Lan = _Lan
        Frm.Para = _Para
        Frm.Sysvar = osysvar
        Frm.AppConn = _App
        Frm.CyberSmlib = Cybersmlib
        Frm.CyberSupport = CyberSupport
        Frm.CyberFill = CyberFill
        Frm.CyberSmlistSys = CyberSmlistSys
        Frm.CyberSmodb = CyberSmodb
        Frm.CyberExport = Nothing
        Frm.CyberVoucher = CyberVoucher
        Frm.CyberLoading = CyberLoading
        Frm.ShowInTaskbar = False
        Frm.ShowDialog()

    End Sub
    Private Sub V_GLTC20(ByVal _DsLoc As DataSet, ByVal isOpenW As Boolean, ByVal _FileName As String, ByVal _Para As String(), ByVal _M_Lan As String, ByVal osysvar As Collection)
        If My.Computer.FileSystem.FileExists(_FileName) Then
            MsgBox("Không tồn tại tệp mẫu báo cáo, Bạn liên hệ với nhà cung cấp", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, osysvar("M_CYBER_VER"))
            Exit Sub
        End If
        Dim M_Path As String = Application.StartupPath.ToString.Trim & "\"
        Dim K_Help = M_Path.ToString.Trim & "\Help\"
        Dim K_Temp As String = _Para(1).ToString

        Dim CyberEport As New Cyber.Export.Sys
        Dim CyberLoading = New Cyber.Loading.Loading
        Dim M_User_Name As String = _Para(6).ToString.Trim
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm("Đang thực hiện tạo báo cáo thuyết minh", "Đang thực hiện tạo báo cáo thuyết minh", _M_Lan)
        'CyberEport.WordReplaceText(isOpenW, K_Help.Trim & _FileName, K_Temp.Trim & _FileName, _DsLoc.Tables(1), osysvar, M_User_Name)
        CyberEport.WordReplaceText(isOpenW, K_Help.Trim & _FileName, _DsLoc.Tables(0).Rows(0).Item("FullWord_Saves").ToString.Trim, _DsLoc.Tables(1), osysvar, M_User_Name)
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
    End Sub
End Class
