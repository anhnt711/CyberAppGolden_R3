Imports System.Data.SqlClient
Public Class HDN
#Region "Khai bao bien Property----------------------"
    Dim M_strFilter As String = "1=1"
    Dim M_DrDmct As DataRow
    Dim osysvar As Collection
    Dim M_Para As String() = Me.Para
    Dim M_AppConn As SqlConnection
    Dim M_DsData, M_DsHead, M_DsLookUp As DataSet

    Dim Dt_DetailCv, Dt_DetailCvTmp As New DataTable
    Dim Dv_DetailCv, Dv_DetailCvTmp As New DataView

    Dim Dt_DetailCT, Dt_DetailCTTmp As New DataTable
    Dim Dv_DetailCT, Dv_DetailCTTmp As New DataView

#End Region
#Region "Khai bao bien Paramater----------------------"

#End Region
#Region "Khai bao bien Dll"
    Dim CyberInput As New Cyber.Input.Sys
    Dim CyberMe As New Cyber.From.Frmvoucher
    Dim CyberFrom As New Cyber.From.Sys

#End Region
#Region "Columns Edit"
    Dim EditMa_lo, EditTk_VT, EditMa_Nx_I, EditMa_kh_I As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditMa_VT, EditMa_Vitri, EditMa_Kho_I, EditMa_Vv_I, EditMa_phi_i, EditMa_HD_I, EditMa_Sp_I, EditMa_ku_I, EditMa_TTLN_i, EditMa_TTCP_i, EditMa_BP_I, EditMa_HS_I, EditMa_CD_I, EditMa_TD1_I, EditMa_TD2_I, EditMa_TD3_I, EditMa_TD4_I, EditMa_TD5_I As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim Editma_Db_I, EditMa_KX_I, EditMa_Tuyen_I, EditMa_Ts, EditMa_Cc As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditSo_Luong, EditGia_NT, EditGia, EditTien_NT, EditTien, EditDien_Giaii, EditSo_So, EditSo_Po, EditSo_Ro, EditSo_VT As New Cyber.Fill.CyberColumnGridView 'DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Dim EditTen_Vt, EditDvt, EditTen_kho_i, EditTen_Tk_VT, EditTen_Nx_I As New Cyber.Fill.CyberColumnGridView

    Dim EditMa_Xe_I, EditMa_CV, EditTen_CV, EditTen_CV3, EditTen_CTCV, EditTen_CTCV3, EditMa_Ctcv, EditGio_TC, EditLAN As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_Ktv_S As New Cyber.Fill.CyberColumnGridView
    '--------------------------------------------------------Công việc

    Dim EditCVMa_Hd_i, EditCVMa_Vv_i, EditCVMa_Phi_i, EditCVMa_Sp_i, EditCVMa_Ku_i, EditCVMa_TTLN_i, EditCVMa_TTCP_i, EditCVMa_BP_i, EditCVMa_Hs_i, EditCVMa_Cd_i As New Cyber.Fill.CyberColumnGridView
    Dim EditCVMa_KTV_i, EditCVMa_Td1_i, EditCVMa_Td2_i, EditCVMa_Td3_i, EditCVMa_Td4_i, EditCVMa_Td5_i As New Cyber.Fill.CyberColumnGridView

    Dim EditCVMa_Xe_I, EditCVMa_CV, EditCVTen_CV, EditCVTen_CV3, EditCVMa_Ctcv, EditCVTen_CTCV, EditCVTen_CTCV3, EditCVGio_TC, EditCVLAN As New Cyber.Fill.CyberColumnGridView
    Dim EditCVMa_Ktv_S As New Cyber.Fill.CyberColumnGridView
    Dim EditCVThue_Suat, EditCVMa_Thue, EditCVTien_CV, EditCVThue As New Cyber.Fill.CyberColumnGridView
    '-------------------------------------------
    Dim EditCTMa_Hd_i, EditCTMa_Vv_i, EditCTMa_Phi_i, EditCTMa_Sp_i, EditCTMa_Ku_i, EditCTMa_TTLN_i, EditCTMa_TTCP_i, EditCTMa_BP_i, EditCTMa_Hs_i, EditCTMa_Cd_i As New Cyber.Fill.CyberColumnGridView
    Dim EditCTMa_KTV_i, EditCTMa_Td1_i, EditCTMa_Td2_i, EditCTMa_Td3_i, EditCTMa_Td4_i, EditCTMa_Td5_i As New Cyber.Fill.CyberColumnGridView

    Dim EditCTMa_Xe_I, EditCTMa_CV, EditCTTen_CV, EditCTTen_CV3, EditCTMa_Ctcv, EditCTTen_CTCV, EditCTTen_CTCV3, EditCTGio_TC, EditCTLAN As New Cyber.Fill.CyberColumnGridView
    Dim EditCTMa_Ktv_S As New Cyber.Fill.CyberColumnGridView

#End Region
#Region "Khai bao bien Private"



    Dim M_Ct, M_Ph As String
    Dim DrReturn As DataRow
    Dim M_Count As Integer = 1
    Dim DtPost, DtMaGD As DataTable
#End Region
    Private Sub HDN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        If DrDmct.Table.Columns.Contains("NonVAT") Then ChkNonVAT.Visible = (DrDmct.Item("NonVAT").ToString.Trim = "1")
        If DrDmct.Table.Columns.Contains("CaptionNonVAT") Then If DrDmct.Item("CaptionNonVAT").ToString.Trim <> "" Then ChkNonVAT.Text = DrDmct.Item("CaptionNonVAT").ToString.Trim
        V_GetColumn()
        V_AddHandler()
        V_Databing()
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()

        V_MainSystem()
        V_MainSystemCv()
        V_MainSystemCT()

        GetRound()
        CmdNew.Select()
    End Sub
#Region "Load And Set And Default"
    Private Sub V_Load()
        V_Getdefault()
        Dt_Detail = M_DsData.Tables(0)
        Dt_DetailTmp = Dt_Detail.Clone
        Dt_Master = M_DsData.Tables(1)


        Dv_Detail = New DataView(Dt_Detail)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)
        Dv_Master = New DataView(Dt_Master)
        '-------------------
        ' Công việc
        Dt_DetailCv = M_DsData.Tables(2)
        Dt_DetailCvTmp = Dt_DetailCv.Clone

        Dv_DetailCv = New DataView(Dt_DetailCv)
        Dv_DetailCvTmp = New DataView(Dt_DetailCvTmp)
        '-------------------
        ' Công việc chi tiết
        Dt_DetailCT = M_DsData.Tables(3)
        Dt_DetailCTTmp = Dt_DetailCT.Clone

        Dv_DetailCT = New DataView(Dt_DetailCT)
        Dv_DetailCTTmp = New DataView(Dt_DetailCTTmp)
        '-------------------

        DetailVt.DataSource = Dv_DetailTmp
        Me.DetailGRVVt.GridControl = Me.DetailVt
        CyberFill.V_FillVoucher(DetailGRVVt, M_LAN, New DataView(M_DsHead.Tables(1)), Dv_DetailTmp, Me.DrDmct)

        '========= FillData to Gridview Cv
        DetailCv.DataSource = Dv_DetailCvTmp
        Me.DetailGRVCv.GridControl = Me.DetailCv
        CyberFill.V_FillVoucher(DetailGRVCv, M_LAN, New DataView(M_DsHead.Tables(2)), Dv_DetailCvTmp, Me.DrDmct)

        '========= FillData to Gridview chi tieets công việc
        DetailCT.DataSource = Dv_DetailCTTmp
        Me.DetailGRVCT.GridControl = Me.DetailCT
        CyberFill.V_FillVoucher(DetailGRVCT, M_LAN, New DataView(M_DsHead.Tables(3)), Dv_DetailCTTmp, Me.DrDmct)


        V_SetProperty()
        CyberSupport.Translaste(Me, M_LAN, True)
        ' M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, Dslookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
        TxtTy_Gia.InputMask = IIf(DrDmct.Item("M_IP_MK_TG").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TG").ToString.Trim, TxtTy_Gia.InputMask)

        TxtT_SO_LUONG.InputMask = IIf(DrDmct.Item("M_IP_MK_SL").ToString.Trim <> "", DrDmct.Item("M_IP_MK_SL").ToString.Trim, TxtT_SO_LUONG.InputMask)
        TxtT_Tien_NT.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN_NT").ToString.Trim, TxtT_Tien_NT.InputMask)
        TxtT_Tien.InputMask = IIf(DrDmct.Item("M_IP_MK_TIEN").ToString.Trim <> "", DrDmct.Item("M_IP_MK_TIEN").ToString.Trim, TxtT_Tien.InputMask)

    End Sub
    Private Sub V_Getdefault()
        M_strFilter = Me.strFilter
        M_DrDmct = Me.DrDmct
        M_Ph = M_DrDmct.Item("M_Ph").ToString.Trim
        M_Ct = M_DrDmct.Item("M_Ct").ToString.Trim

        osysvar = Me.SysVar
        M_Stt_Rec = Me.Stt_Rec
        M_LAN = Me.Lan
        M_Para = Me.Para
        AppConn = Me.AppConn
        M_DsData = Me.DsData
        M_DsHead = Me.DsHead
        M_DsLookUp = Me.DsLookup

        Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
        K_Tmp = M_Para(1).Trim
        K_System = M_Para(2).Trim
        K_Repo = M_Para(3).Trim
        K_Repo_Nt = M_Para(4).Trim
        M_CYBER_VER = M_Para(5).Trim
        M_User_Name = M_Para(6).Trim
        M_Comment = M_Para(7).Trim
        M_is_Admin = CType(M_Para(8), Boolean)
        M_User_ID = M_Para(9).Trim
        M_Menu_ID0 = M_Para(10).Trim
        M_Bar = M_Para(11).Trim
        M_Bar2 = M_Para(12).Trim
        M_LAN = M_Para(13).Trim
        M_Ma_Dvcs = M_Para(14).Trim
        '---------------------------------------------------------------------------------------------'
        M_Ma_GD = M_Para(M_VT_PARA + 1).Trim
        M_Ma_CT = M_Para(M_VT_PARA + 2).Trim
        'M_Stt_Rec = M_Para(M_Para.Length - 1).Trim
        '---------------------------------------------------------------------------------------------'

        M_Ma_Post = CyberSupport.V_GetMaxPost(AppConn, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        '---
        M_Tk_No = DrDmct.Item("M_Tk_No").ToString.Trim
        M_Tk_Co = DrDmct.Item("M_Tk_Co").ToString.Trim
        M_Tk_Thue = DrDmct.Item("M_Tk_Thue").ToString.Trim
        M_Ma_Nt = DrDmct.Item("Ma_Nt").ToString.Trim
        M_Dien_Giai = DrDmct.Item("Dien_Giai").ToString.Trim

        DtPost = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmPost", "Ma_Post", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        DtMaGD = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmMaGd", "Ma_GD", "Ma_Ct =N'" + M_Ma_CT + "'", CyberSmlib)
        CyberFill.V_FillComBoxValue(Me.CbbMa_Post, DtPost, "Ma_Post", If(M_LAN = "V", "Ten_Post", "Ten_Post2"), M_Ma_Post)
        CyberFill.V_FillComBoxValue(Me.CbbMa_GD, DtMaGD, "Ma_GD", If(M_LAN = "V", "Ten_GD", "Ten_GD2"), M_Ma_GD)
        '---------------------------------------------------------------------------------------------'
        V_LoadDefault()
        '---------------------------------------------------------------------------------------------'
    End Sub
    Private Sub V_SetProperty()
        Me.Mode = M_Mode
        Me.Stt_Rec = M_Stt_Rec

        '---
        Dim FixCol As Integer = -1
        FixCol = DrDmct.Item("ColFrozen_master")

        If FixCol < DetailGRVVt.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                DetailGRVVt.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        DetailGRVVt.OptionsNavigation.EnterMoveNextColumn = True
        Me.DetailGRVVt.Appearance.SelectedRow.BackColor = System.Drawing.Color.Brown
    End Sub
    Private Sub V_GetColumn()
        EditMa_lo.GetColumn(DetailGRVVt, "Ma_Lo")
        EditMa_VT.GetColumn(DetailGRVVt, "Ma_VT")
        EditTen_Vt.GetColumn(DetailGRVVt, "Ten_VT")
        EditDvt.GetColumn(DetailGRVVt, "DVT")
        EditMa_Vitri.GetColumn(DetailGRVVt, "ma_Vitri")

        EditMa_Kho_I.GetColumn(DetailGRVVt, "Ma_kho_I")
        EditTen_kho_i.GetColumn(DetailGRVVt, "TEN_KHo_I")

        EditTk_VT.GetColumn(DetailGRVVt, "TK_VT")
        EditTen_Tk_VT.GetColumn(DetailGRVVt, "TEN_TK_VT")

        EditMa_Nx_I.GetColumn(DetailGRVVt, "Ma_Nx_I")
        EditTen_Nx_I.GetColumn(DetailGRVVt, "TEN_Nx_I")

        EditDien_Giaii.GetColumn(DetailGRVVt, "DIEN_GIAII")

        EditSo_Luong.GetColumn(DetailGRVVt, "So_Luong")
        EditGia_NT.GetColumn(DetailGRVVt, "Gia_NT")
        EditGia.GetColumn(DetailGRVVt, "Gia")
        EditTien_NT.GetColumn(DetailGRVVt, "TIEN_NT")
        EditTien.GetColumn(DetailGRVVt, "TIEN")


        EditMa_Vv_I.GetColumn(DetailGRVVt, "Ma_Vv_I")
        EditMa_phi_i.GetColumn(DetailGRVVt, "Ma_Phi_I")
        EditMa_HD_I.GetColumn(DetailGRVVt, "Ma_HD_I")
        EditMa_Sp_I.GetColumn(DetailGRVVt, "Ma_SP_I")
        EditMa_ku_I.GetColumn(DetailGRVVt, "Ma_KU_I")
        EditMa_TTLN_i.GetColumn(DetailGRVVt, "Ma_TTLN_I")
        EditMa_TTCP_i.GetColumn(DetailGRVVt, "Ma_TTCP_I")
        EditMa_BP_I.GetColumn(DetailGRVVt, "Ma_BP_I")
        EditMa_HS_I.GetColumn(DetailGRVVt, "Ma_Hs_I")
        EditMa_CD_I.GetColumn(DetailGRVVt, "Ma_CD_I")

        EditMa_TD1_I.GetColumn(DetailGRVVt, "Ma_TD1_I")
        EditMa_TD2_I.GetColumn(DetailGRVVt, "Ma_TD2_I")
        EditMa_TD3_I.GetColumn(DetailGRVVt, "Ma_TD3_I")
        EditMa_TD4_I.GetColumn(DetailGRVVt, "Ma_TD4_I")
        EditMa_TD5_I.GetColumn(DetailGRVVt, "Ma_TD5_I")

        EditSo_So.GetColumn(DetailGRVVt, "SO_SO")
        EditSo_Po.GetColumn(DetailGRVVt, "SO_PO")
        EditSo_Ro.GetColumn(DetailGRVVt, "SO_RO")
        EditSo_VT.GetColumn(DetailGRVVt, "SO_VT")

        Editma_Db_I.GetColumn(DetailGRVVt, "Ma_Db_I")
        EditMa_Tuyen_I.GetColumn(DetailGRVVt, "Ma_TUYEN_I")
        EditMa_Ts.GetColumn(DetailGRVVt, "Ma_Ts")
        EditMa_Cc.GetColumn(DetailGRVVt, "Ma_Cc")
        ''-------
        EditLAN.GetColumn(Me.DetailGRVVt, "LAN")
        EditMa_Xe_I.GetColumn(DetailGRVVt, "MA_XE_I")
        EditMa_CV.GetColumn(DetailGRVVt, "Ma_CV")
        EditMa_Ctcv.GetColumn(DetailGRVVt, "Ma_CTCV")
        EditGio_TC.GetColumn(DetailGRVVt, "Gio_TC")

        EditTen_CV.GetColumn(DetailGRVVt, "Ten_CV")
        EditTen_CV3.GetColumn(DetailGRVVt, "Ten_CV3")

        EditTen_CTCV.GetColumn(DetailGRVVt, "Ten_CTCV")
        EditTen_CTCV3.GetColumn(DetailGRVVt, "Ten_CTCV3")

        EditMa_Ktv_S.GetColumn(Me.DetailGRVVt, "Ma_KTV_S")

        '---------------------------------------------------------------------------------
        ' Cong Viec
        EditCVMa_KTV_i.GetColumn(DetailGRVCv, "Ma_KTV_I")
        EditCVMa_Vv_i.GetColumn(DetailGRVCv, "Ma_Vv_I")
        EditCVMa_Phi_i.GetColumn(DetailGRVCv, "Ma_Phi_I")
        EditCVMa_Hd_i.GetColumn(DetailGRVCv, "Ma_HD_I")
        EditCVMa_Sp_i.GetColumn(DetailGRVCv, "Ma_SP_I")
        EditCVMa_Ku_i.GetColumn(DetailGRVCv, "Ma_KU_I")
        EditCVMa_TTLN_i.GetColumn(DetailGRVCv, "Ma_TTLN_I")
        EditCVMa_TTCP_i.GetColumn(DetailGRVCv, "Ma_TTCP_I")
        EditCVMa_BP_i.GetColumn(DetailGRVCv, "Ma_BP_I")
        EditCVMa_Hs_i.GetColumn(DetailGRVCv, "Ma_Hs_I")
        EditCVMa_Cd_i.GetColumn(DetailGRVCv, "Ma_CD_I")

        EditCVMa_Td1_i.GetColumn(DetailGRVCv, "Ma_TD1_I")
        EditCVMa_Td2_i.GetColumn(DetailGRVCv, "Ma_TD2_I")
        EditCVMa_Td3_i.GetColumn(DetailGRVCv, "Ma_TD3_I")
        EditCVMa_Td4_i.GetColumn(DetailGRVCv, "Ma_TD4_I")
        EditCVMa_Td5_i.GetColumn(DetailGRVCv, "Ma_TD5_I")


        ''-------
        EditCVMa_Thue.GetColumn(DetailGRVCv, "MA_Thue")
        EditCVThue_Suat.GetColumn(DetailGRVCv, "Thue_Suat")
        EditCVTien_CV.GetColumn(DetailGRVCv, "Tien_CV")
        EditCVThue.GetColumn(DetailGRVCv, "Thue")


        EditCVLAN.GetColumn(Me.DetailGRVCv, "LAN")
        EditCVMa_Xe_I.GetColumn(DetailGRVCv, "MA_XE_I")
        EditCVMa_CV.GetColumn(DetailGRVCv, "Ma_CV")
        EditCVMa_Ctcv.GetColumn(DetailGRVCv, "Ma_CTCV")
        EditCVGio_TC.GetColumn(DetailGRVCv, "Gio_TC")

        EditCVTen_CV.GetColumn(DetailGRVCv, "Ten_CV")
        EditCVTen_CV3.GetColumn(DetailGRVCv, "Ten_CV3")

        EditCVTen_CTCV.GetColumn(DetailGRVCv, "Ten_CTCV")
        EditCVTen_CTCV3.GetColumn(DetailGRVCv, "Ten_CTCV3")
        EditCVMa_Ktv_S.GetColumn(Me.DetailGRVCv, "Ma_KTV_S")
        '---------------------------------------------------------------------------------
        ' Cong Viec chi tiết
        EditCTMa_KTV_i.GetColumn(DetailGRVCT, "Ma_KTV_I")
        EditCTMa_Vv_i.GetColumn(DetailGRVCT, "Ma_Vv_I")
        EditCTMa_Phi_i.GetColumn(DetailGRVCT, "Ma_Phi_I")
        EditCTMa_Hd_i.GetColumn(DetailGRVCT, "Ma_HD_I")
        EditCTMa_Sp_i.GetColumn(DetailGRVCT, "Ma_SP_I")
        EditCTMa_Ku_i.GetColumn(DetailGRVCT, "Ma_KU_I")
        EditCTMa_TTLN_i.GetColumn(DetailGRVCT, "Ma_TTLN_I")
        EditCTMa_TTCP_i.GetColumn(DetailGRVCT, "Ma_TTCP_I")
        EditCTMa_BP_i.GetColumn(DetailGRVCT, "Ma_BP_I")
        EditCTMa_Hs_i.GetColumn(DetailGRVCT, "Ma_Hs_I")
        EditCTMa_Cd_i.GetColumn(DetailGRVCT, "Ma_CD_I")

        EditCTMa_Td1_i.GetColumn(DetailGRVCT, "Ma_TD1_I")
        EditCTMa_Td2_i.GetColumn(DetailGRVCT, "Ma_TD2_I")
        EditCTMa_Td3_i.GetColumn(DetailGRVCT, "Ma_TD3_I")
        EditCTMa_Td4_i.GetColumn(DetailGRVCT, "Ma_TD4_I")
        EditCTMa_Td5_i.GetColumn(DetailGRVCT, "Ma_TD5_I")


        ''-------
        EditCTLAN.GetColumn(Me.DetailGRVCT, "LAN")
        EditCTMa_Xe_I.GetColumn(DetailGRVCT, "MA_XE_I")
        EditCTMa_CV.GetColumn(DetailGRVCT, "Ma_CV")
        EditCTMa_Ctcv.GetColumn(DetailGRVCT, "Ma_CTCV")
        EditCTGio_TC.GetColumn(DetailGRVCT, "Gio_TC")

        EditCTTen_CV.GetColumn(DetailGRVCT, "Ten_CV")
        EditCTTen_CV3.GetColumn(DetailGRVCT, "Ten_CV3")

        EditCTTen_CTCV.GetColumn(DetailGRVCT, "Ten_CTCV")
        EditCTTen_CTCV3.GetColumn(DetailGRVCT, "Ten_CTCV3")
        EditCTMa_Ktv_S.GetColumn(Me.DetailGRVCT, "Ma_KTV_S")
    End Sub
    Private Sub V_SetFocus(ByVal _Loai As String)
        _Loai = _Loai.Trim.ToUpper
        Select Case _Loai
            Case "M"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else TxtMa_Xe.Focus()
            Case "S"
                If DrDmct.Item("M_Ngay_CT").ToString.Trim <> "1" Then TxtNgay_Ct.Focus() Else txtDien_giai.Focus()
            Case "L"
                CmdPrint.Select()
        End Select
    End Sub
    Private Sub GetRound()
        M_R_TIEN = DrDmct.Item("M_R_Tien")
        M_R_TIEN_NT = DrDmct.Item("M_R_Tien_NT")
        M_R_GIA = DrDmct.Item("M_R_GIA")
        M_R_GIA_NT = DrDmct.Item("M_R_GIA_NT")
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.ToUpper.Trim = osysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            M_R_GIA_NT = M_R_GIA
            M_R_TIEN_NT = M_R_TIEN
        End If
    End Sub
#End Region
#Region "V_AddHandler"
    Private Sub V_AddHandler()
        V_AddHandler_System()
        V_AddHandler_Master()
        V_AddHandler_Detail()
    End Sub
    Private Sub V_AddHandler_System()
        AddHandler Me.KeyDown, AddressOf FrmMain_KeyDown
        '---
        AddHandler CmdSave.Click, AddressOf V_Save
        AddHandler CmdNew.Click, AddressOf V_New
        AddHandler CmdEdit.Click, AddressOf V_Edit
        AddHandler CmdDelete.Click, AddressOf V_Delete
        AddHandler CmdCancel.Click, AddressOf V_Cancel
        AddHandler CmdPrint.Click, AddressOf V_Print
        AddHandler CmdView.Click, AddressOf V_View
        AddHandler CmdSearch.Click, AddressOf V_Search
        AddHandler CmdExit.Click, AddressOf V_Exit

        AddHandler CmdImport.Click, AddressOf V_Import
        AddHandler CmdCopy.Click, AddressOf V_Copy
        '---
        AddHandler DetailGRVVt.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler DetailGRVVt.KeyDown, AddressOf MasterGRV_KeyDown
        '---
        AddHandler DetailGRVCv.PopupMenuShowing, AddressOf MasterGRVCv_PopupMenuShowing
        AddHandler DetailGRVCv.KeyDown, AddressOf MasterGRVCv_KeyDown
        '---
        AddHandler CbbMa_GD.SelectedValueChanged, AddressOf L_Ma_GD
    End Sub
    Private Sub L_Ma_GD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        VisibleColumnMa_GD()
        V_Update_Ma_Xe()
    End Sub
    Private Sub V_AddHandler_Master()
        AddHandler TxtNgay_Ct.Leave, AddressOf V_Ngay_Ct
        AddHandler TxtNgay_LCt.Leave, AddressOf V_Ngay_LCt
        AddHandler txtSo_ct.Enter, AddressOf V_So_Ct
        AddHandler TxtMa_NT.Leave, AddressOf L_Ma_NT
        AddHandler TxtTy_Gia.Leave, AddressOf L_Ty_Gia
        '--Ma_Xe
        AddHandler TxtMa_Xe.CyberValiting, AddressOf V_Ma_XE
        AddHandler TxtMa_Xe.CyberLeave, AddressOf L_Ma_XE
        '--Ma_Kx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
        '--Ma_Tuyen
        AddHandler TxtMa_Tuyen.CyberValiting, AddressOf V_Ma_Tuyen
        AddHandler TxtMa_Tuyen.CyberLeave, AddressOf L_Ma_Tuyen
        '----------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub V_AddHandler_Detail()
        If Not EditSo_Luong.Column Is Nothing Then AddHandler EditSo_Luong.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia_NT.Column Is Nothing Then AddHandler EditGia_NT.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditGia.Column Is Nothing Then AddHandler EditGia.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien_NT.Column Is Nothing Then AddHandler EditTien_NT.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditTien.Column Is Nothing Then AddHandler EditTien.EditColumn.Leave, AddressOf L_Tinh_Toan
        If Not EditDien_Giaii.Column Is Nothing Then AddHandler EditDien_Giaii.EditColumn.Enter, AddressOf E_Dien_Giaii

        '-------------------------------------
        If Not EditGio_TC.Column Is Nothing Then AddHandler EditGio_TC.EditColumn.Leave, AddressOf L_Tinh_Toan

        EditMa_Xe_I.V_ActiLookUpColumn(AddressOf V_Ma_Xe_I, AddressOf L_Ma_Xe_I)
        EditMa_CV.V_ActiLookUpColumn(AddressOf V_Ma_Cv, AddressOf L_Ma_Cv)
        EditMa_Ctcv.V_ActiLookUpColumn(AddressOf V_Ma_CtCv, AddressOf L_Ma_CtCV)
        '------

        
        EditMa_lo.V_ActiLookUpColumn(AddressOf V_Ma_Lo, AddressOf L_Ma_Lo)
        EditMa_VT.V_ActiLookUpColumn(AddressOf V_Ma_Vt, AddressOf L_Ma_Vt)
        EditMa_Kho_I.V_ActiLookUpColumn(AddressOf V_Ma_Kho_i, AddressOf L_Ma_Kho_i)
        EditMa_Vitri.V_ActiLookUpColumn(AddressOf V_Ma_Vitri, AddressOf L_Ma_Vitri)
        EditMa_Vv_I.V_ActiLookUpColumn(AddressOf V_Ma_Vv_i, AddressOf L_Ma_Vv_i)
        EditMa_phi_i.V_ActiLookUpColumn(AddressOf V_Ma_Phi_i, AddressOf L_Ma_Phi_i)
        EditMa_HD_I.V_ActiLookUpColumn(AddressOf V_Ma_HD_i, AddressOf L_Ma_HD_i)
        EditMa_Sp_I.V_ActiLookUpColumn(AddressOf V_Ma_SP_i, AddressOf L_Ma_SP_i)
        EditMa_ku_I.V_ActiLookUpColumn(AddressOf V_Ma_KU_i, AddressOf L_Ma_KU_i)
        EditMa_TTLN_i.V_ActiLookUpColumn(AddressOf V_Ma_TTLN_i, AddressOf L_Ma_TTLN_i)
        EditMa_TTCP_i.V_ActiLookUpColumn(AddressOf V_Ma_TTCP_i, AddressOf L_Ma_TTCP_i)
        EditMa_BP_I.V_ActiLookUpColumn(AddressOf V_Ma_Bp_i, AddressOf L_Ma_Bp_i)
        EditMa_HS_I.V_ActiLookUpColumn(AddressOf V_Ma_HS_i, AddressOf L_Ma_HS_i)
        EditMa_CD_I.V_ActiLookUpColumn(AddressOf V_Ma_CD_i, AddressOf L_Ma_CD_i)
        EditMa_TD1_I.V_ActiLookUpColumn(AddressOf V_Ma_TD1_i, AddressOf L_Ma_TD1_i)
        EditMa_TD2_I.V_ActiLookUpColumn(AddressOf V_Ma_TD2_i, AddressOf L_Ma_TD2_i)
        EditMa_TD3_I.V_ActiLookUpColumn(AddressOf V_Ma_TD3_i, AddressOf L_Ma_TD3_i)
        EditMa_TD4_I.V_ActiLookUpColumn(AddressOf V_Ma_TD4_i, AddressOf L_Ma_TD4_i)
        EditMa_TD5_I.V_ActiLookUpColumn(AddressOf V_Ma_TD5_i, AddressOf L_Ma_TD5_i)
        Editma_Db_I.V_ActiLookUpColumn(AddressOf V_Ma_Db_i, AddressOf L_Ma_Db_i)
        EditMa_Xe_I.V_ActiLookUpColumn(AddressOf V_Ma_Xe_I, AddressOf L_Ma_Xe_I)
        EditMa_KX_I.V_ActiLookUpColumn(AddressOf V_Ma_Kx_i, AddressOf L_Ma_Kx_i)
        EditMa_Tuyen_I.V_ActiLookUpColumn(AddressOf V_Ma_Tuyen_i, AddressOf L_Ma_Tuyen_i)
        EditMa_Ts.V_ActiLookUpColumn(AddressOf V_Ma_Ts, AddressOf L_Ma_Ts)
        EditMa_Cc.V_ActiLookUpColumn(AddressOf V_Ma_Cc, AddressOf L_Ma_Cc)
        
        '================== Cong viec============================================================================================================
        EditCVTen_CV.ColumnReadOnly = True
        EditCVLAN.ColumnReadOnly = True

        EditCVMa_Thue.V_ActiLookUpColumn(AddressOf V_CV_Ma_Thue, AddressOf L_CV_Ma_Thue)

        If Not EditCVThue_Suat.Column Is Nothing Then AddHandler EditCVThue_Suat.EditColumn.Leave, AddressOf V_CV_Tinh_Toan
        If Not EditCVThue.Column Is Nothing Then AddHandler EditCVThue.EditColumn.Leave, AddressOf V_CV_Tinh_Toan
        If Not EditCVTien_CV.Column Is Nothing Then AddHandler EditCVTien_CV.EditColumn.Leave, AddressOf V_CV_Tinh_Toan


        If Not EditCVGio_TC.Column Is Nothing Then AddHandler EditCVGio_TC.EditColumn.Leave, AddressOf V_CV_Tinh_Toan

        EditCVMa_Xe_I.V_ActiLookUpColumn(AddressOf V_CV_Ma_Xe_I, AddressOf L_CV_Ma_Xe_I)
        EditCVMa_CV.V_ActiLookUpColumn(AddressOf V_CV_Ma_Cv, AddressOf L_CV_Ma_Cv)
        EditCVMa_Ctcv.V_ActiLookUpColumn(AddressOf V_CV_Ma_CtCv, AddressOf L_CV_Ma_CtCv)

        EditCVMa_KTV_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_KTV_I, AddressOf L_CV_Ma_KTV_I)
        EditCVMa_Vv_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_Vv_I, AddressOf L_CV_Ma_Vv_I)
        EditCVMa_Phi_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_Phi_i, AddressOf L_CV_Ma_Phi_I)
        EditCVMa_Hd_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_HD_i, AddressOf L_CV_Ma_HD_I)
        EditCVMa_Sp_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_Sp_i, AddressOf L_CV_Ma_Sp_i)
        EditCVMa_Ku_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_Ku_I, AddressOf L_CV_Ma_Ku_I)
        EditCVMa_TTLN_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_TTLN_i, AddressOf L_CV_Ma_TTLN_i)
        EditCVMa_TTCP_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_TTCP_i, AddressOf L_CV_Ma_TTCP_i)
        EditCVMa_BP_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_Bp_i, AddressOf L_CV_Ma_Bp_i)
        EditCVMa_Hs_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_Hs_i, AddressOf L_CV_Ma_Hs_i)
        EditCVMa_Cd_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_CD_i, AddressOf L_CV_Ma_CD_i)
        EditCVMa_Td1_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_TD1_i, AddressOf L_CV_Ma_TD1_i)
        EditCVMa_Td2_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_TD2_i, AddressOf L_CV_Ma_TD2_i)
        EditCVMa_Td3_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_TD3_i, AddressOf L_CV_Ma_TD3_i)
        EditCVMa_Td4_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_TD4_i, AddressOf L_CV_Ma_TD4_i)
        EditCVMa_Td5_i.V_ActiLookUpColumn(AddressOf V_CV_Ma_TD5_i, AddressOf L_CV_Ma_TD5_i)

        '================== Cong viec chi tiết============================================================================================================
        EditCTTen_CV.ColumnReadOnly = True
        EditCTLAN.ColumnReadOnly = True

        If Not EditCTGio_TC.Column Is Nothing Then AddHandler EditCTGio_TC.EditColumn.Leave, AddressOf V_CT_Tinh_Toan

        EditCTMa_Xe_I.V_ActiLookUpColumn(AddressOf V_CT_Ma_Xe_I, AddressOf L_CT_Ma_Xe_I)
        EditCTMa_CV.V_ActiLookUpColumn(AddressOf V_CT_Ma_Cv, AddressOf L_CT_Ma_Cv)
        EditCTMa_Ctcv.V_ActiLookUpColumn(AddressOf V_CT_Ma_CtCv, AddressOf L_CT_Ma_CtCv)

        EditCTMa_KTV_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_KTV_I, AddressOf L_CT_Ma_KTV_I)
        EditCTMa_Vv_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_Vv_I, AddressOf L_CT_Ma_Vv_I)
        EditCTMa_Phi_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_Phi_i, AddressOf L_CT_Ma_Phi_I)
        EditCTMa_Hd_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_HD_i, AddressOf L_CT_Ma_HD_I)
        EditCTMa_Sp_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_Sp_i, AddressOf L_CT_Ma_Sp_i)
        EditCTMa_Ku_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_Ku_I, AddressOf L_CT_Ma_Ku_I)
        EditCTMa_TTLN_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_TTLN_i, AddressOf L_CT_Ma_TTLN_i)
        EditCTMa_TTCP_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_TTCP_i, AddressOf L_CT_Ma_TTCP_i)
        EditCTMa_BP_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_Bp_i, AddressOf L_CT_Ma_Bp_i)
        EditCTMa_Hs_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_Hs_i, AddressOf L_CT_Ma_Hs_i)
        EditCTMa_Cd_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_CD_i, AddressOf L_CT_Ma_CD_i)
        EditCTMa_Td1_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_TD1_i, AddressOf L_CT_Ma_TD1_i)
        EditCTMa_Td2_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_TD2_i, AddressOf L_CT_Ma_TD2_i)
        EditCTMa_Td3_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_TD3_i, AddressOf L_CT_Ma_TD3_i)
        EditCTMa_Td4_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_TD4_i, AddressOf L_CT_Ma_TD4_i)
        EditCTMa_Td5_i.V_ActiLookUpColumn(AddressOf V_CT_Ma_TD5_i, AddressOf L_CT_Ma_TD5_i)

        AddHandler DetailGRVVt.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        AddHandler DetailGRVCv.RowCellStyle, AddressOf DetailGRVCv_RowCellStyle
        AddHandler DetailGRVCT.RowCellStyle, AddressOf DetailGRVCT_RowCellStyle

    End Sub
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRVVt, Dt_DetailTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub DetailGRVCv_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRVVt, Dt_DetailCvTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub DetailGRVCT_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRVVt, Dt_DetailCTTmp, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub


    Private Sub VisibleColumnMa_NT()
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_Ma_NT0").ToString.Trim.ToUpper Then
            EditTien.Visible = False
            EditGia.Visible = False
            TxtT_Tien.Visible = False
        Else
            EditTien.Visible = True
            EditGia.Visible = True
            TxtT_Tien.Visible = True
        End If
        CyberFill.SetFoCusGRV(DetailGRVVt, M_Mode)
    End Sub
    Private Sub VisibleColumnMa_GD()
        Dim _Ma_GD As String = "1"
        Try
            _Ma_GD = CbbMa_GD.SelectedValue.ToString.Trim
        Catch ex As Exception
        End Try
        If _Ma_GD = "1" Then
            EditMa_Xe_I.Visible = False
            EditCVMa_Xe_I.Visible = False
            EditCTMa_Xe_I.Visible = False
        Else
            EditMa_Xe_I.Visible = True
            EditCVMa_Xe_I.Visible = True
            EditCTMa_Xe_I.Visible = True
        End If
    End Sub
    Protected Overrides Sub V_Databing()
        Dim i As Integer
        Dim Drv As DataRowView
        Drv = Nothing

        For i = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(i).Item("Stt_Rec").ToString.Trim = M_Stt_Rec.Trim Then
                Drv = Dv_Master.Item(i)
                Exit For
            End If
        Next

        CyberSmodb.SetValueTObj(Me, Drv)
        If Drv Is Nothing Then
            TxtMa_NT.Text = M_Ma_Nt
            TxtNgay_Ct.Value = Now.Date
            Dim _DT As Date = TxtNgay_Ct.Value
            TxtTy_Gia.Double = CyberSupport.GetRate(_DT, TxtMa_NT.Text, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
            CbbMa_GD.SelectedValue = M_Ma_GD
            CbbMa_Post.SelectedValue = M_Ma_Post
        End If
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()

        For i = 0 To Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailTmp.ImportRow(Dt_Detail.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        '---------------------------
        Dt_DetailCvTmp.Clear()
        Dt_DetailCvTmp.AcceptChanges()

        For i = 0 To Dt_DetailCv.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailCvTmp.ImportRow(Dt_DetailCv.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next
        '---------------------------
        Dt_DetailCTTmp.Clear()
        Dt_DetailCTTmp.AcceptChanges()

        For i = 0 To Dt_DetailCT.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'").Length - 1
            Dt_DetailCTTmp.ImportRow(Dt_DetailCT.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(i))
        Next

        If TxtMa_NT.Text.Trim = "" Then TxtMa_NT.Text = osysvar("M_Ma_NT0").ToString.Trim.ToUpper
        UpdateList()
        VisibleColumnMa_NT()
        VisibleColumnMa_GD()
    End Sub
    Private Sub V_Setstatus()
        If (M_Mode = "M" Or M_Mode = "S") Then
            DetailGRVVt.OptionsBehavior.Editable = True
            If DrDmct.Item("M_Ngay_LCT").ToString.Trim = "1" Then TxtNgay_LCt.ReadOnly = False Else TxtNgay_LCt.ReadOnly = True 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Ngay_CT").ToString.Trim = "1" Then TxtNgay_Ct.ReadOnly = True Else TxtNgay_Ct.ReadOnly = False 'Ngay chu tu nhap: vao hoac tu dong lay theo may chu
            If DrDmct.Item("M_Au_So_CT").ToString.Trim = "1" Then txtSo_ct.ReadOnly = True Else txtSo_ct.ReadOnly = False 'Tu dong danh so chung tu
        Else
            DetailGRVVt.OptionsBehavior.Editable = False
        End If
        If M_Mode = "S" Then CbbMa_GD.Enabled = False
        If M_Mode = "M" Then CbbMa_GD.Enabled = True
        CyberFill.SetFoCusGRV(DetailGRVVt, M_Mode)
        SetTxt()
    End Sub
    Private Sub V_GetDateVoucher(ByVal _Mode As String, ByRef _Ngay_Ct As Date, ByRef _Ngay_LCT As Date)
        Dim _DtReturn As DataTable = CyberSupport.V_GetDateVoucher(_Mode, _Ngay_Ct, _Ngay_LCT, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        If _DtReturn Is Nothing Then Exit Sub Else If _DtReturn.Rows.Count <= 0 Then Exit Sub
        If Not _DtReturn.Columns.Contains("Status") Then Exit Sub
        If _DtReturn.Rows(0).Item("Status").ToString.Trim = "N" Then Exit Sub
        If Not DrDmct.Item("M_Ngay_LCt").ToString.Trim = "1" Then TxtNgay_LCt.Value = _DtReturn.Rows(0).Item("Ngay_HT")
        If DrDmct.Item("M_Ngay_Ct").ToString.Trim = "1" Then TxtNgay_Ct.Value = _DtReturn.Rows(0).Item("Ngay_HT")
        _Ngay_Ct = TxtNgay_Ct.Value
        _Ngay_LCT = TxtNgay_Ct.Value
    End Sub
    Private Sub V_GetNoVoucherAuto()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Not DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" And txtSo_ct.Text.Trim <> "" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucherAuto(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
#End Region
#Region "Valid - Master"
#Region "Valid --- Ma_Xe"
    Private Sub V_Ma_XE(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Xe.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Xe", "DmXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_XE(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Xe.Text = "" Then
            TxtTen_Lx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Xe.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Xe.Text = DrReturn.Item("Ma_Xe")
            TxtTen_Lx.Text = DrReturn.Item("Ten_Lx")
            TxtSo_khung.Text = DrReturn.Item("So_khung")
            TxtSo_May.Text = DrReturn.Item("So_May")
        Else
            TxtMa_Xe.Text = ""
            TxtMa_Tuyen.Text = ""
            Txtten_Tuyen.Text = ""
            TxtMa_Kx.Text = ""
            Txtten_kx.Text = ""
            TxtTen_Lx.Text = ""
            TxtSo_khung.Text = ""
            TxtSo_May.Text = ""
        End If
        If TxtMa_Xe.Text = "" Then
            TxtMa_Tuyen.Text = ""
            Txtten_Tuyen.Text = ""
            TxtMa_Kx.Text = ""
            Txtten_kx.Text = ""
            TxtTen_Lx.Text = ""
            TxtSo_khung.Text = ""
            TxtSo_May.Text = ""
            Exit Sub
        End If
        V_Update_Ma_Xe()
    End Sub
    Private Sub V_Update_Ma_Xe()
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ma_GD As String = "1"
        Try
            _Ma_GD = CbbMa_GD.SelectedValue.ToString.Trim
        Catch ex As Exception
        End Try
        If Not _Ma_GD.Trim = "1" Then
            TxtMa_Tuyen.Text = ""
            Txtten_Tuyen.Text = ""
            TxtMa_Kx.Text = ""
            Txtten_kx.Text = ""
            TxtTen_Lx.Text = ""
            TxtSo_khung.Text = ""
            TxtSo_May.Text = ""
            Return
        End If
        '-----------------------------------------------------------
        '---Lay thong tin xe

        '-----------------------------------------------------------
        Dim _Ma_Xe As String = TxtMa_Xe.Text
        Dim _Ma_Tuyen As String = TxtMa_Tuyen.Text
        '-----------------------------------------------------------
        If Dt_DetailTmp.Columns.Contains("Ma_Xe_I") Then
            For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
                Dt_DetailTmp.Rows(i).BeginEdit()
                Dt_DetailTmp.Rows(i).Item("Ma_Xe_I") = _Ma_Xe
                If Dt_DetailTmp.Columns.Contains("Ma_Tuyen_I") Then Dt_DetailTmp.Rows(i).Item("Ma_Tuyen_I") = _Ma_Tuyen
                Dt_DetailTmp.Rows(i).EndEdit()
            Next
        End If
        Dt_DetailTmp.AcceptChanges()
        '-----------------------------------------------------------
        If Dt_DetailCvTmp.Columns.Contains("Ma_Xe_I") Then
            For i As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
                Dt_DetailCvTmp.Rows(i).BeginEdit()
                Dt_DetailCvTmp.Rows(i).Item("Ma_Xe_I") = _Ma_Xe
                If Dt_DetailCvTmp.Columns.Contains("Ma_Tuyen_I") Then Dt_DetailCvTmp.Rows(i).Item("Ma_Tuyen_I") = _Ma_Tuyen
                Dt_DetailCvTmp.Rows(i).EndEdit()
            Next
        End If
        Dt_DetailCvTmp.AcceptChanges()
        '-----------------------------------------------------------
        If Dt_DetailCTTmp.Columns.Contains("Ma_Xe_I") Then
            For i As Integer = 0 To Dt_DetailCTTmp.Rows.Count - 1
                Dt_DetailCTTmp.Rows(i).BeginEdit()
                Dt_DetailCTTmp.Rows(i).Item("Ma_Xe_I") = _Ma_Xe
                If Dt_DetailCTTmp.Columns.Contains("Ma_Tuyen_I") Then Dt_DetailCTTmp.Rows(i).Item("Ma_Tuyen_I") = _Ma_Tuyen
                Dt_DetailCTTmp.Rows(i).EndEdit()
            Next
        End If
        Dt_DetailCTTmp.AcceptChanges()
    End Sub
    Private Sub V_Update_Theo_Xe(ByVal _Ma_Xe As String, ByVal _Irow As Integer)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _StrValue As String = ""


        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetInfoHDN", M_Stt_Rec + "#" + M_Mode + "#" + _Ma_GD + "#" + _Ma_Post + "#" + _
                                                                  M_Ma_CT + "#" + _Ngay_Ct.ToString("yyyyMMdd") + "#" + _StrValue + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        '------------------------------------------
        If DsTmp.Tables.Count = 0 Then
            DsTmp.Dispose()
            Return
        End If

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), osysvar, M_LAN) Then
            DsTmp.Dispose()
            Return
        End If
        '------------------------------------------
        If DsTmp.Tables.Count = 1 Then
            DsTmp.Dispose()
            Return
        End If
        V_Update_PH(DsTmp.Tables(1))
        '------------------------------------------
        If DsTmp.Tables.Count = 2 Then
            DsTmp.Dispose()
            Return
        End If
        V_Update_CT(DsTmp.Tables(2))

    End Sub
    Private Sub V_Update_PH(ByVal _Tb As DataTable)
        If _Tb Is Nothing Then Return
        If _Tb.Rows.Count = 0 Then Return

        If _Tb.Columns.Contains("Ma_Kx") Then TxtMa_Kx.Text = _Tb.Rows(0).Item("Ma_Kx").ToString.Trim
        If _Tb.Columns.Contains("Ten_Kx") Then TxtMa_Kx.Text = _Tb.Rows(0).Item("Ten_Kx").ToString.Trim
        If _Tb.Columns.Contains("Ma_Tuyen") Then TxtMa_Kx.Text = _Tb.Rows(0).Item("Ma_Tuyen").ToString.Trim
        If _Tb.Columns.Contains("Ten_Tuyen") Then TxtMa_Kx.Text = _Tb.Rows(0).Item("Ten_Tuyen").ToString.Trim
        If _Tb.Columns.Contains("So_Km") Then TxtSo_Km.Double = _Tb.Rows(0).Item("So_Km")

    End Sub
    Private Sub V_Update_CT(ByVal _Tb As DataTable)
        If _Tb Is Nothing Then Return
        If _Tb.Rows.Count = 0 Then Return
        Dim nCount As Integer = Dv_DetailTmp.Count - 1

        For _iRow As Integer = 0 To _Tb.Rows.Count - 1
            If _iRow > nCount Then Return
            Dv_DetailTmp.BeginInit()
            If Dt_DetailTmp.Columns.Contains("Seri_Old") And _Tb.Columns.Contains("Seri_Old") Then Dv_DetailTmp.Item(_iRow).Item("Seri_Old") = _Tb.Rows(0).Item("Seri_Old")

        Next

        Dt_DetailTmp.AcceptChanges()
    End Sub
    Private Sub V_Update_CT(ByVal _Tb As DataTable, ByVal _Dv_DetailTmp As DataView, ByVal _IRow As Integer, ByVal _Field_name As String)
        If _Tb.Columns.Contains(_Field_name) Then Return
        If _Dv_DetailTmp.Table.Columns.Contains(_Field_name) Then Return
        _Field_name = _Dv_DetailTmp.Table.Columns(_Field_name).ColumnName.Trim
        _Dv_DetailTmp.BeginInit()
        _Dv_DetailTmp.Item(_IRow).Item(_Field_name) = _Tb.Rows(_IRow).Item(_Field_name)
    End Sub
#End Region
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Kx.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Kx", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Kx.Text = "" Then
            Txtten_kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            Txtten_kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_Kx.Text = ""
            Txtten_kx.Text = ""
        End If
        If TxtMa_Kx.Text = "" Then
            Txtten_kx.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Tuyen"
    Private Sub V_Ma_Tuyen(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        TxtMa_Tuyen.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Tuyen", "DmTuyen", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Tuyen(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_Tuyen.Text = "" Then
            Txtten_Tuyen.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Tuyen.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Tuyen.Text = DrReturn.Item("Ma_Tuyen")
            Txtten_Tuyen.Text = DrReturn.Item("Ten_Tuyen")
        Else
            TxtMa_Tuyen.Text = ""
            Txtten_Tuyen.Text = ""
        End If
        If TxtMa_Tuyen.Text = "" Then
            Txtten_Tuyen.Text = ""
            Exit Sub
        End If
    End Sub
#End Region
#Region "Valid --- Ma_LhSC"
    Private Sub V_Ma_LhSC(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Lhsc", "DmLhSc", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_LhSC(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_LHSC.Text = DrReturn.Item("Ma_Lhsc")
            TxtTen_LHSC.Text = DrReturn.Item("Ten_Lhsc")
        Else
            TxtMa_LHSC.Text = ""
            TxtTen_LHSC.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Sc"
    Private Sub V_Ma_Sc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Sc", "DmSc", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Sc(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = sender.GetRowsSelectData(True)


        If Not DrReturn Is Nothing Then
            TxtMa_SC.Text = DrReturn.Item("Ma_SC")
            Txtten_SC.Text = DrReturn.Item("Ten_SC")
        Else
            TxtMa_SC.Text = ""
            Txtten_SC.Text = ""
        End If

        ' If TxtMa_SC.Text.Trim <> "" Then V_UPDATE_GOISC()
    End Sub
    'Private Sub V_UPDATE_GOISC()
    '    Dim nCountCV As Integer = 0, nCountVt As Integer = 0
    '    For i = 0 To Dt_DetailCvTmp.Rows.Count - 1
    '        If Dt_DetailCvTmp.Rows(i).Item("Ma_Cv").ToString.Trim <> "" Then nCountCV = nCountCV + 1
    '    Next

    '    For i = 0 To Dt_DetailTmp.Rows.Count - 1
    '        If Dt_DetailTmp.Rows(i).Item("Ma_VT").ToString.Trim <> "" Then nCountVt = nCountVt + 1
    '    Next
    '    If nCountCV + nCountVt <> 0 Then Exit Sub

    '    Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
    '    Dim _Ma_GD As String = CbbMa_GD.SelectedValue.ToString.Trim
    '    Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
    '    Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ROUpdateMa_SC", TxtMa_Kx.Text.Trim & "#" & TxtMa_Xe.Text & "#" & _Ma_GD & "#" & _Ma_Post & "#" & TxtMa_SC.Text.Trim & "#" & _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Stt_Rec & "#" & M_Ma_CT & "#" & M_Mode & "#" & M_Ma_Dvcs & "#" & M_User_Name)
    '    For i As Integer = 0 To DsTmp.Tables.Count - 1
    '        CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
    '    Next
    '    If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), SysVar, M_LAN) Or DsTmp.Tables.Count < 3 Then
    '        DsTmp.Dispose()
    '        Exit Sub
    '    End If

    '    Dt_DetailTmp.Clear()
    '    Dt_DetailCvTmp.Clear()
    '    CyberSmodb.SQLTbToTb(DsTmp.Tables(1), Dt_DetailCvTmp)
    '    CyberSmodb.SQLTbToTb(DsTmp.Tables(2), Dt_DetailTmp)
    '    For i = 0 To Dt_DetailCvTmp.Rows.Count - 1
    '        Tinh_TienCV(i)
    '    Next

    '    For i = 0 To Dt_DetailTmp.Rows.Count - 1
    '        Tinh_TienPT(i)
    '    Next
    '    UpdateList()
    '    DsTmp.Dispose()
    'End Sub
#End Region
#End Region
#Region "Valid - Detail"
#Region "Valid - Detail - Core"
    Private Sub UpdateList()
        'Dim nT_Tien_NT As Decimal = 0
        'Dim nT_Tien As Decimal = 0
        Dim nT_So_Luong As Decimal = 0

        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            'nT_Tien_NT = nT_Tien_NT + Dv_DetailTmp.Item(iRow).Item("Tien_NT")
            'nT_Tien = nT_Tien + Dv_DetailTmp.Item(iRow).Item("Tien")
            nT_So_Luong = nT_So_Luong + Dv_DetailTmp.Item(iRow).Item("So_Luong")
        Next
        TxtT_SO_LUONG.Double = nT_So_Luong
        'TxtT_Tien_NT.Double = nT_Tien_NT
        'TxtT_Tien.Double = nT_Tien

        Dim nT_Tien_CV As Decimal = 0
        Dim nT_Thue_CV As Decimal = 0
        Dim nT_TT_CV As Decimal = 0

        For iRow As Integer = 0 To Dv_DetailCvTmp.Count - 1
            
            If Dt_DetailCvTmp.Columns.Contains("Tien_CV") Then nT_Tien_CV = nT_Tien_CV + Dv_DetailCvTmp.Item(iRow).Item("Tien_CV")
            If Dt_DetailCvTmp.Columns.Contains("Thue") Then nT_Thue_CV = nT_Thue_CV + Dv_DetailCvTmp.Item(iRow).Item("Thue")

        Next
        nT_TT_CV = nT_Tien_CV + nT_Thue_CV
        TxtT_CV.Double = nT_Tien_CV
        TxtT_Thue_CV.Double = nT_Thue_CV
        TxtT_TT_CV.Double = nT_TT_CV
    End Sub
    Private Sub V_Tinh_Toan(ByVal iRow As Integer)
        Dim nTy_Gia As Decimal = V_GetTyGia()
        '--------------------------------------------------------------------------------
        If Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_NT") <> 0 Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Tien_NT") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("So_Luong") * Dv_DetailTmp.Item(iRow).Item("Gia_NT"), M_R_TIEN_NT)
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        '----------------
        If nTy_Gia = 1 Then
            Dv_DetailTmp.Item(iRow).Item("Tien") = Dv_DetailTmp.Item(iRow).Item("Tien_NT")
            Dv_DetailTmp.Item(iRow).Item("Gia") = Dv_DetailTmp.Item(iRow).Item("Gia_NT")
        Else
            Dv_DetailTmp.Item(iRow).Item("Tien") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Tien_NT") * nTy_Gia, M_R_TIEN)
            Dv_DetailTmp.Item(iRow).Item("Gia") = CyberSupport.V_Round(Dv_DetailTmp.Item(iRow).Item("Gia_NT") * nTy_Gia, M_R_GIA)
        End If
        Dv_DetailTmp.Item(iRow).EndEdit()

        CyberSupport.V_UpdateGRV(DetailGRVVt)
        UpdateList()
    End Sub
    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DetailGRVVt.PostEditor()
        Dim drvCurren As DataRowView
        drvCurren = DetailGRVVt.GetFocusedRow
        CyberSupport.V_UpdateGRV(DetailGRVVt)
        V_Tinh_Toan(iRow)
    End Sub
    Private Sub E_Dien_Giaii(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M") Then Exit Sub
        'If Not (M_Mode = "M" Or M_Mode = "S") And (M_Is_Delete = "X") Then Exit Sub
        Dim iRow As Integer = DetailGRVVt.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Dv_DetailTmp.Item(iRow).Item("Dien_Giaii").ToString.Trim = "" Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Dien_Giaii") = txtDien_giai.Text
            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
        DetailGRVVt.ShowEditor()

    End Sub
#End Region
#Region "Vat tu kho/Vitri - "
    Private Sub V_Ma_Lo(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Lo(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Lo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Lo(M_Mode, M_Ma_CT, sender, DetailGRVVt)
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_SetSD(iRow)
    End Sub
    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vt(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
        'If Not (M_Mode = "M" Or M_Mode = "S") And (M_Is_Delete = "X") Then Exit Sub
        'sender.V_LookUp(M_LAN, M_Para, osysvar, AppConn, DsLookup, "Ma_Vt", "DmVt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        DrReturn = CyberSupport.L_Ma_Vt(M_Mode, M_Ma_CT, sender, DetailGRVVt)
        Dim iRow As Integer = -1
        If DrReturn Is Nothing Then
            iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            If Dv_DetailTmp.Item(iRow).Item("MA_VT").ToString.Trim = "" Then
                If Not CyberSupport.V_NhapTiep(osysvar, M_LAN) Then
                    Dv_DetailTmp.Item(iRow).Delete()
                    Dv_DetailTmp.Table.AcceptChanges()
                    UpdateList()
                    SendKeys.Send("^{TAB}")
                End If
            End If
            Exit Sub
        End If
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        
        Dv_DetailTmp.Item(iRow).BeginEdit()

        If Dv_DetailTmp.Item(iRow).Item("Ma_kho_I").ToString.Trim = "" Then Dv_DetailTmp.Item(iRow).Item("Ma_kho_I") = DrReturn.Item("Ma_Kho").ToString.Trim
        If Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim = "" Then Dv_DetailTmp.Item(iRow).Item("Ma_Vitri") = DrReturn.Item("Ma_Vitri").ToString.Trim

        Dv_DetailTmp.Item(iRow).EndEdit()
        Dv_DetailTmp.Table.AcceptChanges()
        V_SetSD(iRow)
    End Sub
    Private Sub V_Ma_Kho_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Kho_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kho_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Kho_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_SetSD(iRow)
    End Sub
    Private Sub V_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vitri(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vitri(M_Mode, M_Ma_CT, sender, DetailGRVVt)
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_SetSD(iRow)
    End Sub
    Private Sub V_SetSD(ByVal iRow As Integer)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If iRow < 0 Then Exit Sub
        Dim _Ma_Vt As String = Dv_DetailTmp.Item(iRow).Item("Ma_Vt").ToString.Trim
        Dim _Ma_kho As String = Dv_DetailTmp.Item(iRow).Item("Ma_Kho_I").ToString.Trim
        Dim _Ma_Vitri As String = If(Dv_DetailTmp.Table.Columns.Contains("Ma_Vitri"), Dv_DetailTmp.Item(iRow).Item("Ma_Vitri").ToString.Trim, "")
        Dim _Ma_Lo As String = If(Dt_DetailTmp.Columns.Contains("Ma_Lo"), Dv_DetailTmp.Item(iRow).Item("Ma_lo").ToString.Trim, "")
        Dim _Return As DataRow = CyberSupport.V_SetSD(StatusFooter1, AppConn, "VT", M_Mode, _Ma_Vt, _Ma_kho, _Ma_Vitri, _Ma_Lo, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        If Dv_DetailTmp.Table.Columns.Contains("Ton13") Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            If Dt_DetailTmp.Columns.Contains("Ton13") Then Dv_DetailTmp.Item(iRow).Item("Ton13") = If(_Return Is Nothing, 0, _Return("SL"))
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("ma_Vitri") And _Return.Table.Columns.Contains("ma_Vitri") Then Dv_DetailTmp.Item(iRow).Item("ma_Vitri") = _Return("ma_Vitri")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("BackColor") And _Return.Table.Columns.Contains("BackColor") Then Dv_DetailTmp.Item(iRow).Item("BackColor") = _Return.Item("BackColor")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("BackColor2") And _Return.Table.Columns.Contains("BackColor2") Then Dv_DetailTmp.Item(iRow).Item("BackColor2") = _Return.Item("BackColor2")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("ForeColor") And _Return.Table.Columns.Contains("ForeColor") Then Dv_DetailTmp.Item(iRow).Item("ForeColor") = _Return.Item("ForeColor")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Bold") And _Return.Table.Columns.Contains("Bold") Then Dv_DetailTmp.Item(iRow).Item("Bold") = _Return.Item("Bold")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Underline") And _Return.Table.Columns.Contains("Underline") Then Dv_DetailTmp.Item(iRow).Item("Underline") = _Return.Item("Underline")
            If Not _Return Is Nothing Then If Dt_DetailTmp.Columns.Contains("Italic") And _Return.Table.Columns.Contains("Italic") Then Dv_DetailTmp.Item(iRow).Item("Italic") = _Return.Item("Italic")


            Dv_DetailTmp.Item(iRow).EndEdit()
        End If
    End Sub
#End Region
#Region "Valid - Lookup"
    Private Sub L_Ma_Xe_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Xe_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
    End Sub
    Private Sub V_Ma_Xe_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Xe_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub V_Ma_Cv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Cv", "Dmcv", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow).BeginEdit()
            Dv_DetailTmp.Item(iRow).Item("Ma_Cv") = ""
            If Dt_DetailTmp.Columns.Contains("Ten_CV") Then Dv_DetailTmp.Item(iRow).Item("Ten_Cv") = ""
            Dv_DetailTmp.Item(iRow).EndEdit()
            DetailGRVVt.UpdateCurrentRow()
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()

        Dv_DetailTmp.Item(iRow).Item("Ma_Cv") = DrReturn("Ma_Cv").ToString.Trim
        If Dt_DetailTmp.Columns.Contains("Ten_CV") Then Dv_DetailTmp.Item(iRow).Item("Ten_Cv") = DrReturn("Ten_Cv").ToString.Trim
        If Dt_DetailTmp.Columns.Contains("Ten_CV3") Then Dv_DetailTmp.Item(iRow).Item("Ten_Cv3") = IIf(Dv_DetailTmp.Item(iRow).Item("Ten_Cv3").ToString.Trim <> "", Dv_DetailTmp.Item(iRow).Item("Ten_Cv3"), DrReturn("Ten_Cv").ToString.Trim)
        If Dt_DetailTmp.Columns.Contains("MA_KTV_I") Then Dv_DetailTmp.Item(iRow).Item("MA_KTV_I") = IIf(Dv_DetailTmp.Item(iRow).Item("MA_KTV_I").ToString.Trim <> "", Dv_DetailTmp.Item(iRow).Item("MA_KTV_I"), DrReturn("Ma_Hs").ToString.Trim)


        If Dv_DetailTmp.Item(iRow).Item("Gio_TC") = 0 Then Dv_DetailTmp.Item(iRow).Item("Gio_TC") = DrReturn("Gio_TC")

        Dv_DetailTmp.Item(iRow).EndEdit()
        DetailGRVVt.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_CtCv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_CtCv", "DmCtCv", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CtCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow)("Ma_CtCv") = ""
            If Dt_DetailTmp.Columns.Contains("Ten_CtCv") Then Dv_DetailTmp.Item(iRow)("Ten_CtCv") = ""
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_CtCv") = DrReturn("Ma_CtCv").ToString.Trim
        If Dt_DetailTmp.Columns.Contains("Ten_CtCv") Then Dv_DetailTmp.Item(iRow).Item("Ten_CtCv") = DrReturn("Ten_CtCv").ToString.Trim
        If Dt_DetailTmp.Columns.Contains("Ten_CtCv3") Then Dv_DetailTmp.Item(iRow).Item("Ten_CtCv3") = IIf(Dv_DetailTmp.Item(iRow).Item("Ten_CtCv3").ToString.Trim <> "", Dv_DetailTmp.Item(iRow).Item("Ten_CtCv3"), DrReturn("Ten_CTCv").ToString.Trim)
        Dv_DetailTmp.Item(iRow).EndEdit()
        DetailGRVVt.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_KTV_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_hs", "DmKTV", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_KTV_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVVt.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailTmp.Item(iRow)("Ma_KTV_I") = ""
            If Dv_DetailTmp.Table.Columns.Contains("Ten_KTV_I") Then Dv_DetailTmp.Item(iRow).Item("Ten_KTV_I") = ""
            Exit Sub
        End If
        Dv_DetailTmp.Item(iRow).BeginEdit()
        Dv_DetailTmp.Item(iRow).Item("Ma_KTV_I") = DrReturn("Ma_hs").ToString.Trim
        If Dv_DetailTmp.Table.Columns.Contains("Ten_KTV_I") Then Dv_DetailTmp.Item(iRow).Item("Ten_KTV_I") = DrReturn("Ten_hs").ToString.Trim
        Dv_DetailTmp.Item(iRow).EndEdit()
        DetailGRVVt.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vv_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Vv_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vv_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Phi_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Phi_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hd_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Sp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_SP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Sp_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_KU_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ku_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_KU_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ku_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTLN_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTLN_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTCP_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTCP_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_HS_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hs_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cd_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Td1_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Td1_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD2_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD2_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD3_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD3_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD4_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD4_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD5_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD5_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_Db_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Db_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Db_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Db_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_Kx_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Kx_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Kx_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Kx_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_Tuyen_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Tuyen_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Tuyen_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Tuyen_i(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_Ts(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ts(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Ts(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ts(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
    Private Sub V_Ma_Cc(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cc(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_Ma_Cc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cc(M_Mode, M_Ma_CT, sender, DetailGRVVt)
    End Sub
#End Region
#End Region
#Region "Valid - công việc"
    Private Sub V_CV_Ma_Thue(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Thue", "DmThue", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_Thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCvTmp.Item(iRow).BeginEdit()
            Dv_DetailCvTmp.Item(iRow).Item("Ma_thue") = ""
            If Dt_DetailCvTmp.Columns.Contains("Thue_Suat") Then Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") = 0
            Dv_DetailCvTmp.Item(iRow).EndEdit()
            DetailGRVCv.UpdateCurrentRow()
            Exit Sub
        End If
        Dv_DetailCvTmp.Item(iRow).BeginEdit()
        If Dt_DetailCvTmp.Columns.Contains("Thue_Suat") Then Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") = DrReturn("Thue_Suat")
        Dv_DetailTmp.Item(iRow).EndEdit()
        Tinh_TienCV(iRow)
        DetailGRVVt.UpdateCurrentRow()
    End Sub

    Private Sub V_CV_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        DetailGRVCv.PostEditor()
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailCvTmp.AcceptChanges()
        Tinh_TienCV(iRow)
    End Sub
    Private Sub Tinh_TienCV(ByVal iRow As Integer)
        'Tinh Tiền Cong viec ---------------------------------------------------------------------------------------
        If Dt_DetailCvTmp.Columns.Contains("Gia_CV") And Dt_DetailCvTmp.Columns.Contains("Gio_TC") And Dt_DetailCvTmp.Columns.Contains("Tien_CV") Then
            If Dv_DetailCvTmp.Item(iRow).Item("Gia_CV") * Dv_DetailCvTmp.Item(iRow).Item("Gio_TC") <> 0 Then
                Dv_DetailCvTmp.Item(iRow).BeginEdit()
                Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") = CyberSupport.V_Round(Dv_DetailCvTmp.Item(iRow).Item("Gia_CV") * Dv_DetailCvTmp.Item(iRow).Item("Gio_TC"), 0)
                Dv_DetailCvTmp.Item(iRow).EndEdit()
            End If
        End If
        If Dt_DetailCvTmp.Columns.Contains("Thue") And Dt_DetailCvTmp.Columns.Contains("Tien_CV") And Dt_DetailCvTmp.Columns.Contains("Thue_Suat") Then
            Dv_DetailCvTmp.Item(iRow).BeginEdit()
            Dv_DetailCvTmp.Item(iRow).Item("Thue") = Math.Round((Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") * Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat")) / 100, 0, MidpointRounding.AwayFromZero)
            Dv_DetailCvTmp.Item(iRow).EndEdit()
        End If
        UpdateList()
    End Sub
    Private Sub L_CV_Ma_Xe_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Xe_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

    End Sub
    Private Sub V_CV_Ma_Xe_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Xe_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub V_CV_Ma_Cv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Cv", "Dmcv", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCvTmp.Item(iRow).BeginEdit()
            Dv_DetailCvTmp.Item(iRow).Item("Ma_Cv") = ""
            If Dt_DetailCvTmp.Columns.Contains("Ten_CV") Then Dv_DetailCvTmp.Item(iRow).Item("Ten_Cv") = ""
            Dv_DetailCvTmp.Item(iRow).EndEdit()
            DetailGRVCT.UpdateCurrentRow()
            Exit Sub

        End If
        Dv_DetailCvTmp.Item(iRow).BeginEdit()

        Dv_DetailCvTmp.Item(iRow).Item("Ma_Cv") = DrReturn("Ma_Cv").ToString.Trim
        If Dt_DetailCvTmp.Columns.Contains("Ten_CV") Then Dv_DetailCvTmp.Item(iRow).Item("Ten_Cv") = DrReturn("Ten_Cv").ToString.Trim
        If Dt_DetailCvTmp.Columns.Contains("Ten_CV3") Then Dv_DetailCvTmp.Item(iRow).Item("Ten_Cv3") = IIf(Dv_DetailCvTmp.Item(iRow).Item("Ten_Cv3").ToString.Trim <> "", Dv_DetailCvTmp.Item(iRow).Item("Ten_Cv3"), DrReturn("Ten_Cv").ToString.Trim)
        If Dt_DetailCvTmp.Columns.Contains("MA_KTV_I") Then Dv_DetailCvTmp.Item(iRow).Item("MA_KTV_I") = IIf(Dv_DetailCvTmp.Item(iRow).Item("MA_KTV_I").ToString.Trim <> "", Dv_DetailCvTmp.Item(iRow).Item("MA_KTV_I"), DrReturn("Ma_Hs").ToString.Trim)
        If Dt_DetailCvTmp.Columns.Contains("Thue_Suat") And DrReturn.Table.Columns.Contains("Thue_Suat") Then Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") = IIf(Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat") <> 0, Dv_DetailCvTmp.Item(iRow).Item("Thue_Suat"), DrReturn("Thue_Suat"))



        If Dv_DetailCvTmp.Item(iRow).Item("Gia_CV") = 0 And DrReturn.Table.Columns.Contains("Gia_CV") Then Dv_DetailCvTmp.Item(iRow).Item("Gia_CV") = DrReturn("Gia_CV")
        If Dv_DetailCvTmp.Item(iRow).Item("Gio_TC") = 0 And DrReturn.Table.Columns.Contains("Gio_TC") Then Dv_DetailCvTmp.Item(iRow).Item("Gio_TC") = DrReturn("Gio_TC")
        If Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") = 0 And DrReturn.Table.Columns.Contains("Tien_CV") Then Dv_DetailCvTmp.Item(iRow).Item("Tien_CV") = DrReturn("Tien_CV")

        Dv_DetailCvTmp.Item(iRow).EndEdit()
        Tinh_TienCV(iRow)
        DetailGRVCv.UpdateCurrentRow()
    End Sub
    Private Sub V_CV_Ma_CtCv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_CtCv", "DmCtCv", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_CtCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCvTmp.Item(iRow)("Ma_CtCv") = ""
            If Dt_DetailCvTmp.Columns.Contains("Ten_CtCv") Then Dv_DetailCvTmp.Item(iRow)("Ten_CtCv") = ""
            Exit Sub
        End If
        Dv_DetailCvTmp.Item(iRow).BeginEdit()
        Dv_DetailCvTmp.Item(iRow).Item("Ma_CtCv") = DrReturn("Ma_CtCv").ToString.Trim
        If Dt_DetailCvTmp.Columns.Contains("Ten_CtCv") Then Dv_DetailCvTmp.Item(iRow).Item("Ten_CtCv") = DrReturn("Ten_CtCv").ToString.Trim
        If Dt_DetailCvTmp.Columns.Contains("Ten_CtCv3") Then Dv_DetailCvTmp.Item(iRow).Item("Ten_CtCv3") = IIf(Dv_DetailCvTmp.Item(iRow).Item("Ten_CtCv3").ToString.Trim <> "", Dv_DetailCvTmp.Item(iRow).Item("Ten_CtCv3"), DrReturn("Ten_CTCv").ToString.Trim)
        Dv_DetailCvTmp.Item(iRow).EndEdit()
        DetailGRVCv.UpdateCurrentRow()
    End Sub
    Private Sub V_CV_Ma_KTV_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_hs", "DmKTV", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_KTV_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCvTmp.Item(iRow)("Ma_KTV_I") = ""
            If Dv_DetailCvTmp.Table.Columns.Contains("Ten_KTV_I") Then Dv_DetailCvTmp.Item(iRow).Item("Ten_KTV_I") = ""
            Exit Sub
        End If
        Dv_DetailCvTmp.Item(iRow).BeginEdit()
        Dv_DetailCvTmp.Item(iRow).Item("Ma_KTV_I") = DrReturn("Ma_hs").ToString.Trim
        If Dv_DetailCvTmp.Table.Columns.Contains("Ten_KTV_I") Then Dv_DetailCvTmp.Item(iRow).Item("Ten_KTV_I") = DrReturn("Ten_hs").ToString.Trim
        Dv_DetailCvTmp.Item(iRow).EndEdit()
        DetailGRVCv.UpdateCurrentRow()
    End Sub
    Private Sub V_CV_Ma_Vv_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vv_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_Vv_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vv_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Phi_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_Phi_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Phi_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_HD_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hd_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_Sp_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Sp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_Sp_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Sp_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_Ku_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ku_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_Ku_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ku_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTLN_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTLN_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTCP_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTCP_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_Hs_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_Hs_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hs_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cd_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Td1_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Td1_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD2_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD2_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD3_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD3_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD4_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD4_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
    Private Sub V_CV_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD5_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CV_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD5_i(M_Mode, M_Ma_CT, sender, DetailGRVCv)
    End Sub
#End Region
#Region "Valid - công việc chi tiết"
    Private Sub V_CT_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode.Trim = "M" Or M_Mode.Trim = "S") Then Exit Sub
        DetailGRVCT.PostEditor()
        Dim iRow As Integer = -1
        iRow = DetailGRVCT.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dt_DetailCTTmp.AcceptChanges()
        Tinh_Tien_CT(iRow)
    End Sub
    Private Sub Tinh_Tien_CT(ByVal iRow As Integer)
        UpdateList()

    End Sub
    Private Sub L_CT_Ma_Xe_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Xe_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
        Dim iRow As Integer = -1
        iRow = DetailGRVCT.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

    End Sub
    Private Sub V_CT_Ma_Xe_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Xe_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub V_CT_Ma_Cv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_Cv", "Dmcv", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_Cv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVCT.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCTTmp.Item(iRow).BeginEdit()
            Dv_DetailCTTmp.Item(iRow).Item("Ma_Cv") = ""
            If Dt_DetailCTTmp.Columns.Contains("Ten_CV") Then Dv_DetailCTTmp.Item(iRow).Item("Ten_Cv") = ""
            Dv_DetailCTTmp.Item(iRow).EndEdit()
            DetailGRVCT.UpdateCurrentRow()
            Exit Sub
        End If
        Dv_DetailCTTmp.Item(iRow).BeginEdit()

        Dv_DetailCTTmp.Item(iRow).Item("Ma_Cv") = DrReturn("Ma_Cv").ToString.Trim
        If Dt_DetailCTTmp.Columns.Contains("Ten_CV") Then Dv_DetailCTTmp.Item(iRow).Item("Ten_Cv") = DrReturn("Ten_Cv").ToString.Trim
        If Dt_DetailCTTmp.Columns.Contains("Ten_CV3") Then Dv_DetailCTTmp.Item(iRow).Item("Ten_Cv3") = IIf(Dv_DetailCTTmp.Item(iRow).Item("Ten_Cv3").ToString.Trim <> "", Dv_DetailCTTmp.Item(iRow).Item("Ten_Cv3"), DrReturn("Ten_Cv").ToString.Trim)
        If Dt_DetailCTTmp.Columns.Contains("MA_KTV_I") Then Dv_DetailCTTmp.Item(iRow).Item("MA_KTV_I") = IIf(Dv_DetailCTTmp.Item(iRow).Item("MA_KTV_I").ToString.Trim <> "", Dv_DetailCTTmp.Item(iRow).Item("MA_KTV_I"), DrReturn("Ma_Hs").ToString.Trim)


        If Dv_DetailCTTmp.Item(iRow).Item("Gio_TC") = 0 Then Dv_DetailCTTmp.Item(iRow).Item("Gio_TC") = DrReturn("Gio_TC")

        Dv_DetailCTTmp.Item(iRow).EndEdit()
        Tinh_TienCV(iRow)
        DetailGRVCT.UpdateCurrentRow()
    End Sub
    Private Sub V_CT_Ma_CtCv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_CtCv", "DmCtCv", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_CtCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = -1
        iRow = DetailGRVCT.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCTTmp.Item(iRow)("Ma_CtCv") = ""
            If Dt_DetailCTTmp.Columns.Contains("Ten_CtCv") Then Dv_DetailCTTmp.Item(iRow)("Ten_CtCv") = ""
            Exit Sub
        End If
        Dv_DetailCTTmp.Item(iRow).BeginEdit()
        Dv_DetailCTTmp.Item(iRow).Item("Ma_CtCv") = DrReturn("Ma_CtCv").ToString.Trim
        If Dt_DetailCTTmp.Columns.Contains("Ten_CtCv") Then Dv_DetailCTTmp.Item(iRow).Item("Ten_CtCv") = DrReturn("Ten_CtCv").ToString.Trim
        If Dt_DetailCTTmp.Columns.Contains("Ten_CtCv3") Then Dv_DetailCTTmp.Item(iRow).Item("Ten_CtCv3") = IIf(Dv_DetailCTTmp.Item(iRow).Item("Ten_CtCv3").ToString.Trim <> "", Dv_DetailCTTmp.Item(iRow).Item("Ten_CtCv3"), DrReturn("Ten_CTCv").ToString.Trim)
        Dv_DetailCTTmp.Item(iRow).EndEdit()
        DetailGRVCT.UpdateCurrentRow()
    End Sub
    Private Sub V_CT_Ma_KTV_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Lookup("Ma_hs", "DmKTV", "1=1", "1=1", M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_KTV_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVCT.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(M_Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCTTmp.Item(iRow)("Ma_KTV_I") = ""
            If Dv_DetailCTTmp.Table.Columns.Contains("Ten_KTV_I") Then Dv_DetailCTTmp.Item(iRow).Item("Ten_KTV_I") = ""
            Exit Sub
        End If
        Dv_DetailCTTmp.Item(iRow).BeginEdit()
        Dv_DetailCTTmp.Item(iRow).Item("Ma_KTV_I") = DrReturn("Ma_hs").ToString.Trim
        If Dv_DetailCTTmp.Table.Columns.Contains("Ten_KTV_I") Then Dv_DetailCTTmp.Item(iRow).Item("Ten_KTV_I") = DrReturn("Ten_hs").ToString.Trim
        Dv_DetailCTTmp.Item(iRow).EndEdit()
        DetailGRVCT.UpdateCurrentRow()
    End Sub
    Private Sub V_CT_Ma_Vv_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Vv_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_Vv_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Vv_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_Phi_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Phi_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_Phi_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Phi_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_HD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_HD_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hd_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_Sp_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Sp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_Sp_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Sp_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_Ku_I(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Ku_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_Ku_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Ku_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTLN_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_TTLN_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTLN_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TTCP_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_TTCP_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TTCP_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Bp_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_Bp_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Bp_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_Hs_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Hs_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_Hs_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Hs_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Cd_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_CD_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Cd_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_Td1_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_TD1_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_Td1_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD2_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_TD2_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD2_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD3_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_TD3_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD3_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD4_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_TD4_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD4_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
    Private Sub V_CT_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        CyberSupport.V_Ma_TD5_i(M_Mode, M_Ma_CT, M_LAN, M_Para, osysvar, AppConn, DsLookup, sender)
    End Sub
    Private Sub L_CT_Ma_TD5_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.L_Ma_TD5_i(M_Mode, M_Ma_CT, sender, DetailGRVCT)
    End Sub
#End Region
#Region "Ngay ct, ngay lap chung tu,so chung tu"
    Private Sub V_Ngay_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub

        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Ngay_LCt(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_So_Ct(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If DrDmct.Item("M_Au_So_Ct").ToString.Trim = "1" Then Exit Sub
        If Not txtSo_ct.Text.Trim = "" Then Exit Sub
        Dim _Ngay_LCt As Date = TxtNgay_LCt.Value
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        txtSo_ct.Text = CyberSupport.V_GetNoVoucher(M_Mode, txtSo_ct.Text, M_Stt_Rec, _Ngay_Ct, _Ngay_LCt, M_Ma_CT, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
#End Region
#Region "Ty gia -  Ngoai te"
    Private Sub L_Ma_NT(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        DrReturn = Nothing
        CyberSmlistSys.Lookup(M_LAN, M_Para, osysvar, AppConn, DsLookup, TxtMa_NT.Text, "Ma_NT", "DmNT", DrReturn, "1=1", "1=1", "1")
        If Not DrReturn Is Nothing Then TxtMa_NT.Text = DrReturn.Item("Ma_NT") Else TxtMa_NT.Text = ""
        Dim Dt As Date = TxtNgay_Ct.Value
        TxtTy_Gia.Double = CyberSupport.GetRate(Dt, TxtMa_NT.Text, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        GetRound()
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            V_Tinh_Toan(iRow)
        Next
        VisibleColumnMa_NT()
    End Sub
    Private Sub L_Ty_Gia(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_MA_NT0").ToString.Trim Then TxtTy_Gia.Double = 1
        For iRow As Integer = 0 To Dv_DetailTmp.Count - 1
            V_Tinh_Toan(iRow)
        Next
        Dv_DetailTmp.Table.AcceptChanges()
    End Sub
    Private Function V_GetTyGia() As Decimal
        Dim nTy_Gia As Decimal = TxtTy_Gia.Double
        If nTy_Gia = 0 Then nTy_Gia = 1
        If TxtMa_NT.Text.Trim = "" Then TxtMa_NT.Text = osysvar("M_MA_NT0")
        If TxtMa_NT.Text.Trim = "" Or TxtMa_NT.Text.Trim.ToUpper = osysvar("M_MA_NT0").ToString.ToUpper.Trim Then TxtTy_Gia.Double = 1
        TxtTy_Gia.Double = nTy_Gia
        V_GetTyGia = nTy_Gia
    End Function
#End Region
#Region "Mainform"
    Private Sub V_MainSystem()
        Dim mnItemsMail = New ContextMenu

        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItem, Keys.F8)

        Dim mnItemsSave As New MenuItem(If(M_LAN = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Keys.Control + Keys.Enter)
        Dim mnItemsPrint As New MenuItem(If(M_LAN = "V", "In chứng từ", "Print"), AddressOf V_ShortPrint, Keys.Control + Keys.P)

        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)

        mnItemsMail.MenuItems.Add(mnItemsSave)
        mnItemsMail.MenuItems.Add(mnItemsPrint)
        Me.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_Import, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVVT.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVVT.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailTmp, AppConn, DetailGRVVT) Then Exit Sub
        Dv_DetailTmp.Delete(iRow)
        Dv_DetailTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub V_ShortSAVE(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        If Me.CmdSave.Enabled Then CmdSave.Focus()
        If Me.CmdSave.Enabled Then CmdSave.PerformClick()
    End Sub
    Private Sub V_ShortPrint(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not M_Mode = "X" Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Me.CmdPrint.Enabled Then V_Print(sender, e)
    End Sub
    Private Sub FrmMain_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If M_Mode.Trim = "X" Then If e.KeyValue = 27 Then V_Exit(sender, e)
        If M_Mode.Trim = "X" Then
            Select Case e.KeyValue
                Case 33 'Pageup
                    V_Prev(sender, e)
                Case 34 'PageDown
                    V_NEXT(sender, e)
                Case 35 'End
                    V_Bottom(sender, e)
                Case 36 'Home
                    V_Top(sender, e)
            End Select
        End If
    End Sub
    Private Function ChkRightsVoucher(ByVal _Mode As String) As Boolean
        Dim _Dt As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        ChkRightsVoucher = CyberSupport.ChkRightsVoucher(_Dt, _Mode, _Ma_Post, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, M_LAN, AppConn, osysvar, CyberSmlib)
    End Function
#End Region
#Region "Mainform Cong Viec"
    Private Sub V_MainSystemCv()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItemCv, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItemCv, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVCv.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterGRVCv_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()

            If Not (M_Mode = "M" Or M_Mode = "S") And Dt_DetailCvTmp.Columns.Contains("Ma_KTV_S") Then
                PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Cập nhập kỹ thuật viên", "Update"), AddressOf V_Ma_KTV_SCV, Nothing, True, False))
            End If
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItemCv, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItemCv, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_ImportCv, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_ShortAddItemCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        V_AddItemCv(iRow)
        iRow = Dv_DetailCvTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCv, iRow, 0)
    End Sub
    Private Sub V_ShortDeleteItemCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailCvTmp, AppConn, DetailGRVCv) Then Exit Sub
        Dv_DetailCvTmp.Delete(iRow)
        Dv_DetailCvTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub V_Ma_KTV_SCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        'If Not (M_Mode = "M" Or M_Mode = "S") And (M_Is_Delete = "X") Then Exit Sub
        If Not Dt_DetailCvTmp.Columns.Contains("Ma_KTV_S") Then Exit Sub
        Dim _iRow As Integer = -1
        _iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If _iRow < 0 Then Exit Sub
        Dim str As String
        Dim _ma_Ktv_s As String = Dv_DetailCvTmp.Item(_iRow).Item("Ma_KTV_S")

        Dim strTen As String = ""
        If Dv_DetailCvTmp.Table.Columns.Contains("Ten_KTV_S") Then strTen = Dv_DetailCvTmp.Item(_iRow).Item("ten_KTV_S")

        str = GetKTV(_ma_Ktv_s, strTen)

        If Not (M_Mode = "M" Or M_Mode = "S") Then
            If str Is Nothing Then Exit Sub
            UpdateKTV(_iRow, str, strTen, "CV")
            Exit Sub
        End If

        'If str Is Nothing Then Exit Sub
        If str Is Nothing Then str = ""
        If strTen Is Nothing Then strTen = ""

        Dv_DetailCvTmp.Item(_iRow).BeginEdit()
        Dv_DetailCvTmp.Item(_iRow).Item("Ma_KTV_S") = str
        If Dv_DetailCvTmp.Table.Columns.Contains("ten_KTV_S") Then Dv_DetailCvTmp.Item(_iRow).Item("ten_KTV_S") = strTen
        Dv_DetailCvTmp.Item(_iRow).EndEdit()

        For i As Integer = 0 To Dv_DetailCvTmp.Count - 1
            Dv_DetailCvTmp.Item(i).BeginEdit()
            Dv_DetailCvTmp.Item(i).Item("Ma_KTV_S") = IIf(Dv_DetailCvTmp.Item(i).Item("Ma_KTV_S").ToString.Trim = "", str, Dv_DetailCvTmp.Item(i).Item("Ma_KTV_S"))
            If Dv_DetailCvTmp.Table.Columns.Contains("ten_KTV_S") Then
                Dv_DetailCvTmp.Item(i).Item("ten_KTV_S") = IIf(Dv_DetailCvTmp.Item(i).Item("ten_KTV_S").ToString.Trim = "", strTen, Dv_DetailCvTmp.Item(i).Item("ten_KTV_S"))
            End If
            Dv_DetailCvTmp.Item(i).EndEdit()
        Next
        DetailGRVCv.UpdateCurrentRow()
    End Sub
    Private Sub UpdateKTV(ByVal _iRow As Integer, ByVal _Ma_KTV_S As String, ByVal _Ten_KTV_S As String, ByVal Loai As String)
        If Dv_DetailCvTmp.Table.Columns.Contains("Ma_KTV_S") Then
            If Loai = "CV" Then

                Dim strsql As String = ""
                For i As Integer = 0 To Dv_DetailCvTmp.Count - 1
                    If i = _iRow Then
                        strsql = strsql + "; INSERT DsKTVS SELECT N'" + "CV" + "',N'" + Dv_DetailCvTmp.Item(i).Item("Stt_Rec0") + "',N'" + _Ma_KTV_S + "'"
                    Else
                        strsql = strsql + "; INSERT DsKTVS SELECT N'" + "CV" + "',N'" + Dv_DetailCvTmp.Item(i).Item("Stt_Rec0") + "',N'" + IIf(Dv_DetailCvTmp.Item(i).Item("Ma_KTv_S").ToString.Trim = "", _Ma_KTV_S, Dv_DetailCvTmp.Item(i).Item("Ma_KTv_S").ToString.Trim) + "'"
                    End If

                Next
                Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SaveKTVSHDK", "U" & "#" & Loai & "#" & M_Stt_Rec.Trim & "#" & strsql & "#" & M_Ma_CT.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
                If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), SysVar, M_LAN) Then
                    Dstmp.Dispose()
                    Exit Sub
                End If
                Dstmp.Dispose()
                '------------Save Client
                Dv_DetailCvTmp.Item(_iRow).BeginEdit()
                Dv_DetailCvTmp.Item(_iRow).Item("Ma_KTV_S") = _Ma_KTV_S
                If Dt_DetailCv.Columns.Contains("Ten_KTV_S") Then Dv_DetailCvTmp.Item(_iRow).Item("Ten_KTV_S") = _Ten_KTV_S
                Dv_DetailCvTmp.Item(_iRow).EndEdit()
                '-------------
                For i As Integer = 0 To Dv_DetailCvTmp.Count - 1
                    If Not Dv_DetailCvTmp.Item(i).Item("Ma_KTV_S").ToString.Trim = "" Then Continue For
                    Dv_DetailCvTmp.Item(i).BeginEdit()
                    Dv_DetailCvTmp.Item(i).Item("Ma_KTV_S") = _Ma_KTV_S
                    If Dt_DetailCv.Columns.Contains("Ten_KTV_S") Then Dv_DetailCvTmp.Item(i).Item("Ten_KTV_S") = _Ten_KTV_S
                    Dv_DetailCvTmp.Item(i).EndEdit()
                Next
                DetailGRVCv.UpdateCurrentRow()
                ''-------------
                'For iRow = 0 To Dt_DetailCv.Rows.Count - 1
                '    If Not Dt_DetailCv.Rows(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then Continue For
                '    If Not Dt_DetailCv.Rows(iRow).Item("Ma_KTV_S").ToString.Trim = "" Then Continue For
                '    Dt_DetailCv.Rows(iRow).BeginEdit()
                '    Dt_DetailCv.Rows(iRow).Item("Ma_KTV_S") = _Ma_KTV_S
                '    Dt_DetailCv.Rows(iRow).EndEdit()
                'Next
                'Dt_DetailCv.AcceptChanges()
            End If
        End If
        '--------------------------------------------------------
        If Dv_DetailTmp.Table.Columns.Contains("Ma_KTV_S") Then
            If Loai = "VT" Then
                '
                Dim strsql As String = ""
                For i As Integer = 0 To Dv_DetailTmp.Count - 1
                    If i = _iRow Then
                        strsql = strsql + "; INSERT DsKTVS SELECT N'" + "VT" + "',N'" + Dv_DetailTmp.Item(i).Item("Stt_Rec0") + "',N'" + _Ma_KTV_S + "'"
                    Else
                        strsql = strsql + "; INSERT DsKTVS SELECT N'" + "VT" + "',N'" + Dv_DetailTmp.Item(i).Item("Stt_Rec0") + "',N'" + IIf(Dv_DetailTmp.Item(i).Item("Ma_KTv_S").ToString.Trim = "", _Ma_KTV_S, Dv_DetailTmp.Item(i).Item("Ma_KTv_S").ToString.Trim) + "'"
                    End If

                Next
                Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SaveKTVSHDK", "U" & "#" & Loai & "#" & M_Stt_Rec.Trim & "#" & strsql & "#" & M_Ma_CT.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
                If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), SysVar, M_LAN) Then
                    Dstmp.Dispose()
                    Exit Sub
                End If
                Dstmp.Dispose()
                '------------Save Client
                Dv_DetailTmp.Item(_iRow).BeginEdit()
                Dv_DetailTmp.Item(_iRow).Item("Ma_KTV_S") = _Ma_KTV_S
                If Dt_Detail.Columns.Contains("Ten_KTV_S") Then Dv_DetailTmp.Item(_iRow).Item("Ten_KTV_S") = _Ten_KTV_S
                Dv_DetailTmp.Item(_iRow).EndEdit()

                '------------
                For i = 0 To Dv_DetailTmp.Count - 1
                    If Not Dv_DetailTmp.Item(i).Item("Ma_KTV_S").ToString.Trim = "" Then Continue For
                    Dv_DetailTmp.Item(i).BeginEdit()
                    Dv_DetailTmp.Item(i).Item("Ma_KTV_S") = _Ma_KTV_S
                    If Dt_Detail.Columns.Contains("Ten_KTV_S") Then Dv_DetailTmp.Item(i).Item("Ten_KTV_S") = _Ten_KTV_S
                    Dv_DetailTmp.Item(i).EndEdit()
                Next
                DetailGRVVt.UpdateCurrentRow()
                ''-------------
                'For iRow = 0 To Dt_Detail.Rows.Count - 1
                '    If Not Dt_Detail.Rows(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then Continue For
                '    If Not Dt_Detail.Rows(iRow).Item("Ma_KTV_S").ToString.Trim = "" Then Continue For
                '    Dt_Detail.Rows(iRow).BeginEdit()
                '    Dt_Detail.Rows(iRow).Item("Ma_KTV_S") = _Ma_KTV_S
                '    Dt_Detail.Rows(iRow).EndEdit()
                'Next
                'Dt_Detail.AcceptChanges()
            End If
        End If
    End Sub
    Private Function GetKTV(ByVal _Ma_KTV As String, ByRef _Ten_KTV As String) As String
        GetKTV = CyberSupport.V_GetStrSelectList(AppConn, osysvar, M_Para, "CP_GetListSelect", "DMKTVSC#" & _Ma_KTV & "#" & M_Ma_CT & "#" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN, _Ten_KTV)
    End Function
#End Region
#Region "Mainform Cong Viec chi tiet"
    Private Sub V_MainSystemCT()
        Dim mnItemsMail = New ContextMenu
        Dim mnItemsF4 As New MenuItem(If(M_LAN = "V", "Thêm dòng", "New row"), AddressOf V_ShortAddItemCT, Keys.F4)
        Dim mnItemsF8 As New MenuItem(If(M_LAN = "V", "Xóa dòng", "Delete row"), AddressOf V_ShortDeleteItemCT, Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVCT.GridControl.ContextMenu = mnItemsMail
    End Sub
    Private Sub MasterGRVCT_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()

            If Not (M_Mode = "M" Or M_Mode = "S") And Dt_DetailCTTmp.Columns.Contains("Ma_KTV_S") Then
                PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Cập nhập kỹ thuật viên", "Update"), AddressOf V_Ma_KTV_SCT, Nothing, True, False))
            End If
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItemCT, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItemCT, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Import", "Delete item"), AddressOf V_ImportCv, Nothing, True, True))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Lưu chứng từ", "Save"), AddressOf V_ShortSAVE, Nothing, True, True))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_ShortAddItemCT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVCT.FocusedRowHandle
        V_AddItemCT(iRow)
        iRow = Dv_DetailCTTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCT, iRow, 0)
    End Sub
    Private Sub V_ShortDeleteItemCT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRVCT.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(osysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailCTTmp, AppConn, DetailGRVCT) Then Exit Sub
        Dv_DetailCTTmp.Delete(iRow)
        Dv_DetailCTTmp.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub V_Ma_KTV_SCT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = M_Mode.Trim
        'If Not (M_Mode = "M" Or M_Mode = "S") And (M_Is_Delete = "X") Then Exit Sub
        If Not Dt_DetailCTTmp.Columns.Contains("Ma_KTV_S") Then Exit Sub
        Dim _iRow As Integer = -1
        _iRow = DetailGRVCT.GetFocusedDataSourceRowIndex
        If _iRow < 0 Then Exit Sub
        Dim str As String
        Dim _ma_Ktv_s As String = Dv_DetailCTTmp.Item(_iRow).Item("Ma_KTV_S")

        Dim strTen As String = ""
        If Dv_DetailCTTmp.Table.Columns.Contains("Ten_KTV_S") Then strTen = Dv_DetailCTTmp.Item(_iRow).Item("ten_KTV_S")

        str = GetKTV(_ma_Ktv_s, strTen)

        If Not (M_Mode = "M" Or M_Mode = "S") Then
            If str Is Nothing Then Exit Sub
            UpdateKTV_CT(_iRow, str, strTen, "CV")
            Exit Sub
        End If

        'If str Is Nothing Then Exit Sub
        If str Is Nothing Then str = ""
        If strTen Is Nothing Then strTen = ""

        Dv_DetailCTTmp.Item(_iRow).BeginEdit()
        Dv_DetailCTTmp.Item(_iRow).Item("Ma_KTV_S") = str
        If Dv_DetailCTTmp.Table.Columns.Contains("ten_KTV_S") Then Dv_DetailCTTmp.Item(_iRow).Item("ten_KTV_S") = strTen
        Dv_DetailCTTmp.Item(_iRow).EndEdit()

        For i As Integer = 0 To Dv_DetailCTTmp.Count - 1
            Dv_DetailCTTmp.Item(i).BeginEdit()
            Dv_DetailCTTmp.Item(i).Item("Ma_KTV_S") = IIf(Dv_DetailCTTmp.Item(i).Item("Ma_KTV_S").ToString.Trim = "", str, Dv_DetailCTTmp.Item(i).Item("Ma_KTV_S"))
            If Dv_DetailCTTmp.Table.Columns.Contains("ten_KTV_S") Then
                Dv_DetailCTTmp.Item(i).Item("ten_KTV_S") = IIf(Dv_DetailCTTmp.Item(i).Item("ten_KTV_S").ToString.Trim = "", strTen, Dv_DetailCTTmp.Item(i).Item("ten_KTV_S"))
            End If
            Dv_DetailCTTmp.Item(i).EndEdit()
        Next
        DetailGRVCT.UpdateCurrentRow()
    End Sub
    Private Sub UpdateKTV_CT(ByVal _iRow As Integer, ByVal _Ma_KTV_S As String, ByVal _Ten_KTV_S As String, ByVal Loai As String)
        If Dv_DetailCTTmp.Table.Columns.Contains("Ma_KTV_S") Then
            If Loai = "CV" Then

                Dim strsql As String = ""
                For i As Integer = 0 To Dv_DetailCTTmp.Count - 1
                    If i = _iRow Then
                        strsql = strsql + "; INSERT DsKTVS SELECT N'" + "CV" + "',N'" + Dv_DetailCTTmp.Item(i).Item("Stt_Rec0") + "',N'" + _Ma_KTV_S + "'"
                    Else
                        strsql = strsql + "; INSERT DsKTVS SELECT N'" + "CV" + "',N'" + Dv_DetailCTTmp.Item(i).Item("Stt_Rec0") + "',N'" + IIf(Dv_DetailCTTmp.Item(i).Item("Ma_KTv_S").ToString.Trim = "", _Ma_KTV_S, Dv_DetailCTTmp.Item(i).Item("Ma_KTv_S").ToString.Trim) + "'"
                    End If

                Next
                Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SaveKTVSHDK", "U" & "#" & Loai & "#" & M_Stt_Rec.Trim & "#" & strsql & "#" & M_Ma_CT.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
                If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), SysVar, M_LAN) Then
                    Dstmp.Dispose()
                    Exit Sub
                End If
                Dstmp.Dispose()
                '------------Save Client
                Dv_DetailCTTmp.Item(_iRow).BeginEdit()
                Dv_DetailCTTmp.Item(_iRow).Item("Ma_KTV_S") = _Ma_KTV_S
                If Dt_DetailCv.Columns.Contains("Ten_KTV_S") Then Dv_DetailCTTmp.Item(_iRow).Item("Ten_KTV_S") = _Ten_KTV_S
                Dv_DetailCTTmp.Item(_iRow).EndEdit()
                '-------------
                For i As Integer = 0 To Dv_DetailCTTmp.Count - 1
                    If Not Dv_DetailCTTmp.Item(i).Item("Ma_KTV_S").ToString.Trim = "" Then Continue For
                    Dv_DetailCTTmp.Item(i).BeginEdit()
                    Dv_DetailCTTmp.Item(i).Item("Ma_KTV_S") = _Ma_KTV_S
                    If Dt_DetailCv.Columns.Contains("Ten_KTV_S") Then Dv_DetailCTTmp.Item(i).Item("Ten_KTV_S") = _Ten_KTV_S
                    Dv_DetailCTTmp.Item(i).EndEdit()
                Next
                DetailGRVCT.UpdateCurrentRow()
                ''-------------
                'For iRow = 0 To Dt_DetailCt.Rows.Count - 1
                '    If Not Dt_DetailCt.Rows(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then Continue For
                '    If Not Dt_DetailCt.Rows(iRow).Item("Ma_KTV_S").ToString.Trim = "" Then Continue For
                '    Dt_DetailCt.Rows(iRow).BeginEdit()
                '    Dt_DetailCt.Rows(iRow).Item("Ma_KTV_S") = _Ma_KTV_S
                '    Dt_DetailCt.Rows(iRow).EndEdit()
                'Next
                'Dt_DetailCt.AcceptChanges()
            End If
        End If
        '--------------------------------------------------------
        If Dv_DetailCTTmp.Table.Columns.Contains("Ma_KTV_S") Then
            If Loai = "VT" Then
                '
                Dim strsql As String = ""
                For i As Integer = 0 To Dv_DetailCTTmp.Count - 1
                    If i = _iRow Then
                        strsql = strsql + "; INSERT DsKTVS SELECT N'" + "VT" + "',N'" + Dv_DetailCTTmp.Item(i).Item("Stt_Rec0") + "',N'" + _Ma_KTV_S + "'"
                    Else
                        strsql = strsql + "; INSERT DsKTVS SELECT N'" + "VT" + "',N'" + Dv_DetailCTTmp.Item(i).Item("Stt_Rec0") + "',N'" + IIf(Dv_DetailCTTmp.Item(i).Item("Ma_KTv_S").ToString.Trim = "", _Ma_KTV_S, Dv_DetailCTTmp.Item(i).Item("Ma_KTv_S").ToString.Trim) + "'"
                    End If

                Next
                Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SaveKTVSHDK", "U" & "#" & Loai & "#" & M_Stt_Rec.Trim & "#" & strsql & "#" & M_Ma_CT.Trim & "#" & TxtMa_Dvcs.Text.Trim & "#" & M_User_Name)
                If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), SysVar, M_LAN) Then
                    Dstmp.Dispose()
                    Exit Sub
                End If
                Dstmp.Dispose()
                '------------Save Client
                Dv_DetailCTTmp.Item(_iRow).BeginEdit()
                Dv_DetailCTTmp.Item(_iRow).Item("Ma_KTV_S") = _Ma_KTV_S
                If Dt_DetailCT.Columns.Contains("Ten_KTV_S") Then Dv_DetailCTTmp.Item(_iRow).Item("Ten_KTV_S") = _Ten_KTV_S
                Dv_DetailCTTmp.Item(_iRow).EndEdit()

                '------------
                For i = 0 To Dv_DetailCTTmp.Count - 1
                    If Not Dv_DetailCTTmp.Item(i).Item("Ma_KTV_S").ToString.Trim = "" Then Continue For
                    Dv_DetailCTTmp.Item(i).BeginEdit()
                    Dv_DetailCTTmp.Item(i).Item("Ma_KTV_S") = _Ma_KTV_S
                    If Dt_DetailCT.Columns.Contains("Ten_KTV_S") Then Dv_DetailCTTmp.Item(i).Item("Ten_KTV_S") = _Ten_KTV_S
                    Dv_DetailCTTmp.Item(i).EndEdit()
                Next
                DetailGRVVt.UpdateCurrentRow()
                ''-------------
                'For iRow = 0 To Dt_DetailCT.Rows.Count - 1
                '    If Not Dt_DetailCT.Rows(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then Continue For
                '    If Not Dt_DetailCT.Rows(iRow).Item("Ma_KTV_S").ToString.Trim = "" Then Continue For
                '    Dt_DetailCT.Rows(iRow).BeginEdit()
                '    Dt_DetailCT.Rows(iRow).Item("Ma_KTV_S") = _Ma_KTV_S
                '    Dt_DetailCT.Rows(iRow).EndEdit()
                'Next
                'Dt_DetailCT.AcceptChanges()
            End If
        End If
    End Sub
#End Region

#Region "Button"
    Private Sub V_Save(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DetailGRVVT.PostEditor()
        Dv_DetailTmp.Table.AcceptChanges()
        If M_Mode.Trim = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If M_Mode.Trim = "M" Then TxtUser_id.Text = M_User_ID
        If TxtMa_NT.Text.Trim = "" Then V_GetTyGia()
        Dim _Ngay_Ct As Date = TxtNgay_Ct.Value
        Dim _Ngay_LCt As Date = TxtNgay_Ct.Value
        '----------------------------------------------------------------------------------------------------------------------
        V_GetDateVoucher(M_Mode, _Ngay_Ct, _Ngay_LCt)
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkRightsVoucher("L") Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        V_GetNoVoucherAuto() ' Tao So Chung tu tu dong
        '----------------------------------------------------------------------------------------------------------------------
        V_Update_Ma_Xe() '--Update Ma xe_I trong cac File chi tiet trong truong hop Ma_GD = "1"
        '----------------------------------------------------------------------------------------------------------------------
        If Not ChkVsave() Then Exit Sub 'Kiem tra va Update du lieu chuong tri
        CyberInput.V_Save_Default_TTCP(Dt_DetailTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)
        CyberInput.V_Save_Default_TTCP(Dt_DetailCvTmp, M_Is_Visible_TTCP, CbbMa_TTCP_H, M_Ma_CT, CyberSmodb)

        '----------------------------------------------------------------------------------------------------------------------
        If Not CyberSupport.ChkVoucherInput(Me, AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Ma_CT, _Ngay_Ct, CbbMa_GD.SelectedValue, M_Stt_Rec, CbbMa_Post.SelectedValue, M_Ma_Dvcs, M_User_Name, Dt_DetailTmp, "Ten_Tk,TEN_KH", "TEN_VT,TEN_KHO_I", CyberSmlib, CyberSupport, CyberSmodb, CyberLoading) Then Exit Sub
        '----------------------------------------------------------------------------------------------------------------------
        'If Not CyberSupport.V_ChkExistNovoucher(AppConn, osysvar, M_LAN, DrDmct, M_Mode, M_Stt_Rec, M_Ma_CT, txtSo_ct.Text.Trim, _Ngay_Ct, _Ngay_LCt, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub '---Kiem tra trung so chung tu
        '----------------------------------------------------------------------------------------------------------------------

        If Not Add2Database() Then Return
        '----------------------------------------------------------------------------------------------------------------------
        M_Mode = "X"
        M_Count = Dt_Master.Rows.Count
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("L")
        CyberSmlib.FlushMemorySave()

    End Sub
    Private Function ChkVsave() As Boolean
        Dim iRow, nCount As Integer
        nCount = Dt_DetailTmp.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailTmp.Rows(iRow).Item("Ma_VT").ToString.Trim = "" Then
                Dt_DetailTmp.Rows(iRow).Delete()
                Dt_DetailTmp.AcceptChanges()
            End If
        Next
        nCount = Dt_DetailCvTmp.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailCvTmp.Rows(iRow).Item("Ma_CV").ToString.Trim = "" Then
                Dt_DetailCvTmp.Rows(iRow).Delete()
                Dt_DetailCvTmp.AcceptChanges()
            End If
        Next
        nCount = Dt_DetailCTTmp.Rows.Count
        For iRow = nCount - 1 To 0 Step -1
            If Dt_DetailCTTmp.Rows(iRow).Item("Ma_CV").ToString.Trim = "" Then
                Dt_DetailCTTmp.Rows(iRow).Delete()
                Dt_DetailCTTmp.AcceptChanges()
            End If
        Next
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(iRow).BeginEdit()
            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            If Dt_DetailTmp.Columns.Contains("So_Ct") Then Dt_DetailTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
            If Dt_DetailTmp.Columns.Contains("So_Ro") Then Dt_DetailTmp.Rows(iRow).Item("So_Ro") = TxtSo_Ro.Text
            If Dt_DetailTmp.Columns.Contains("Ma_Post") Then Dt_DetailTmp.Rows(iRow).Item("Ma_Post") = CbbMa_Post.SelectedValue.ToString.Trim
            If Dt_DetailTmp.Columns.Contains("Ma_GD") Then Dt_DetailTmp.Rows(iRow).Item("Ma_GD") = CbbMa_GD.SelectedValue.ToString.Trim

            Dt_DetailTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            Dt_DetailTmp.Rows(iRow).EndEdit()
        Next
        Dt_DetailTmp.AcceptChanges()

        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCvTmp.Rows(iRow).BeginEdit()
            Dt_DetailCvTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailCvTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailCvTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            If Dt_DetailCvTmp.Columns.Contains("So_Ct") Then Dt_DetailCvTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
            If Dt_DetailCvTmp.Columns.Contains("So_Ro") Then Dt_DetailCvTmp.Rows(iRow).Item("So_Ro") = TxtSo_Ro.Text
            If Dt_DetailCvTmp.Columns.Contains("Ma_Post") Then Dt_DetailCvTmp.Rows(iRow).Item("Ma_Post") = CbbMa_Post.SelectedValue.ToString.Trim
            If Dt_DetailCvTmp.Columns.Contains("Ma_GD") Then Dt_DetailCvTmp.Rows(iRow).Item("Ma_GD") = CbbMa_GD.SelectedValue.ToString.Trim

            Dt_DetailCvTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            Dt_DetailCvTmp.Rows(iRow).EndEdit()
        Next
        Dt_DetailCvTmp.AcceptChanges()
        '---------------------------------------------------------------------------------
        For iRow = 0 To Dt_DetailCTTmp.Rows.Count - 1
            Dt_DetailCTTmp.Rows(iRow).BeginEdit()
            Dt_DetailCTTmp.Rows(iRow).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailCTTmp.Rows(iRow).Item("Ma_Ct") = M_Ma_CT
            Dt_DetailCTTmp.Rows(iRow).Item("Ngay_Ct") = TxtNgay_Ct.Value
            If Dt_DetailCTTmp.Columns.Contains("So_Ct") Then Dt_DetailCTTmp.Rows(iRow).Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
            If Dt_DetailCTTmp.Columns.Contains("So_Ro") Then Dt_DetailCTTmp.Rows(iRow).Item("So_Ro") = TxtSo_Ro.Text
            If Dt_DetailCTTmp.Columns.Contains("Ma_Post") Then Dt_DetailCTTmp.Rows(iRow).Item("Ma_Post") = CbbMa_Post.SelectedValue.ToString.Trim
            If Dt_DetailCTTmp.Columns.Contains("Ma_GD") Then Dt_DetailCTTmp.Rows(iRow).Item("Ma_GD") = CbbMa_GD.SelectedValue.ToString.Trim

            Dt_DetailCTTmp.Rows(iRow).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(iRow + 1)
            Dt_DetailCTTmp.Rows(iRow).EndEdit()
        Next
        Dt_DetailCTTmp.AcceptChanges()
        '---------------------------------------------------------------------------------
        If Not CyberSupport.ChkDetail(Dv_DetailTmp.Count, M_Ma_CT, M_LAN, osysvar) And Not CyberSupport.ChkDetail(Dv_DetailCvTmp.Count, M_Ma_CT, M_LAN, osysvar) Or Not CyberSupport.ChkDetail(Dv_DetailCTTmp.Count, M_Ma_CT, M_LAN, osysvar) Then Return False

        UpdateList()
        ChkVsave = True
    End Function
    Private Function Add2Database() As Boolean
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        If M_Mode.Trim = "M" Then
            drMaster = Dt_Master.NewRow
            CyberSmodb.SetValueBlankRow(drMaster)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.Item("Stt_Rec") = M_Stt_Rec
            drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        Else
            CrrRow = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
            drMaster = Dt_Master.Rows(CrrRow)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        '--------------drMaster.Item("User_Id") = M_User_ID.Trim
        If drMaster.Table.Columns.Contains("So_Ct") Then drMaster.Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong DetailCV
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailCv, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To DetailCV 
        For i As Integer = 0 To Dt_DetailCvTmp.Rows.Count - 1
            Dt_DetailCv.ImportRow(Dt_DetailCvTmp.Rows(i))
        Next

        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong DetailCT
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_DetailCT, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To DetailCT 
        For i As Integer = 0 To Dt_DetailCTTmp.Rows.Count - 1
            Dt_DetailCT.ImportRow(Dt_DetailCTTmp.Rows(i))
        Next

        '-----------------------------------------------------------------------------------------------------
        Return CyberSmodb.V_Add2Database(AppConn, osysvar, {Dt_DetailTmp, CyberSmodb.V_ConvertDrToTb(drMaster), Dt_DetailCvTmp, Dt_DetailCTTmp}, {M_Ct, M_Ph, "CTHDNCV", "CTHDNCT"}, M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_LAN, TxtMa_Dvcs.Text, M_User_Name, CyberSmlib, CyberSupport)
        ''---Save: History
        'CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: TO SQL
        'If M_Ph.Trim <> "" Then CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        'If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        'CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailVaTTmp, "CTGT30", M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'")
        ''-----------------------------------------------------------------------------------------------------
        ''---Save: Post
        'CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)

    End Function

    Private Sub Add2Database_Luu()
        Dim drMaster As DataRow
        Dim CrrRow As Integer = -1
        If M_Mode.Trim = "M" Then
            drMaster = Dt_Master.NewRow
            CyberSmodb.SetValueBlankRow(drMaster)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.Item("Stt_Rec") = M_Stt_Rec
            drMaster.Item("Ma_Dvcs") = M_Ma_Dvcs
        Else
            CrrRow = Dt_Master.Rows.IndexOf(Dt_Master.Select("Stt_Rec ='" + M_Stt_Rec.Trim + "'")(0))
            drMaster = Dt_Master.Rows(CrrRow)
            CyberSmodb.AddValueToRow(drMaster, Me)
            drMaster.BeginEdit()
        End If
        drMaster.Item("Stt_Rec") = M_Stt_Rec.Trim
        drMaster.Item("Ma_Ct") = M_Ma_CT.Trim
        '--------------drMaster.Item("User_Id") = M_User_ID.Trim
        drMaster.Item("So_Ct") = CyberSupport.V_soct(txtSo_ct.Text.Trim)
        '---Save Post
        CyberSupport.V_SavePost(AppConn, drMaster, CbbMa_Post.SelectedValue, M_Ma_CT, M_User_Name, M_User_Name, CyberSmlib)
        If M_Mode.Trim = "M" Then Dt_Master.Rows.Add(drMaster) Else Dt_Master.Rows(CrrRow).EndEdit()
        Dt_Master.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------
        '---Xoa trong Detail
        If M_Mode.Trim = "S" Then CyberSmodb.DeleteDatatable(Dt_Detail, "Stt_Rec = '" + M_Stt_Rec + "'")
        '+Import To Detail 
        For i As Integer = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_Detail.ImportRow(Dt_DetailTmp.Rows(i))
        Next
        '-----------------------------------------------------------------------------------------------------
        '---Save: History
        CyberSupport.V_HistoryVoucher(M_Mode, CbbMa_Post.SelectedValue.ToString.Trim, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
        '-----------------------------------------------------------------------------------------------------
        '---Save: TO SQL
        If M_Ph.Trim <> "" Then CyberSmodb.V_SaveToSQL(AppConn, osysvar, M_User_Name, drMaster, M_Ph, M_Mode, "Stt_Rec = N'" + M_Stt_Rec + "'", IIf(M_Mode.Trim = "S", True, False))
        If M_Ct.Trim <> "" Then CyberSmodb.V_CyberSaveToSQL(AppConn, osysvar, M_User_Name, Dt_DetailTmp, M_Ct, M_Mode, "Stt_Rec =N'" + M_Stt_Rec + "'")
        '-----------------------------------------------------------------------------------------------------
        '---Save: Post
        CyberSupport.V_PostVoucher(M_Mode, M_Ma_CT, M_Stt_Rec, M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
    Private Sub V_Copy(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("C") Then Exit Sub

        M_Stt_RecOld = M_Stt_Rec
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)

        Dim Frm As Cyber.From.FrmCopy
        Frm = New FrmCopy
        Frm.Para = M_Para
        Frm.Lan = M_LAN
        Frm.Sysvar = osysvar
        Frm.DrDmct = Me.DrDmct
        Frm.So_CT = ""
        Frm.Ngay_CT = Now.Date
        Frm.Ngay_LCT = Now.Date
        Frm.SysApp = AppConn
        Frm.Ma_Dvcs = TxtMa_Dvcs.Text
        Frm.Stt_Rec = M_Stt_Rec
        Frm.ShowDialog()

        If Not Frm.Ok_Copy Then
            M_Stt_Rec = M_Stt_RecOld
            Exit Sub
        End If

        Dim _Ngay_Ct_Copy As Date = Frm.TxtNgay_Ct.Value
        Dim _Ngay_LCt_Copy As Date = Frm.TxtNgay_LCt.Value
        Dim _So_Ct_Copy As String = Frm.txtSo_ct.Text
        Dim _Ma_Quyen_Copy As String = Frm.TxtMa_Quyen.Text

        Dim I As Integer
        For I = 0 To Dt_DetailTmp.Rows.Count - 1
            Dt_DetailTmp.Rows(I).BeginEdit()
            Dt_DetailTmp.Rows(I).Item("Stt_Rec") = M_Stt_Rec
            Dt_DetailTmp.Rows(I).Item("Ngay_Ct") = _Ngay_Ct_Copy
            Dt_DetailTmp.Rows(I).Item("So_Ct") = _So_Ct_Copy
            Dt_DetailTmp.Rows(I).EndEdit()
        Next

        TxtStt_Rec.Text = M_Stt_Rec
        TxtNgay_Ct.Value = _Ngay_Ct_Copy
        TxtNgay_LCt.Value = _Ngay_LCt_Copy
        txtSo_ct.Text = _So_Ct_Copy.Trim
        M_Mode = "M"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()


    End Sub
    Private Sub V_New(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec
        If Not ChkRightsVoucher("M") Then Exit Sub
        M_Stt_Rec = CyberSmlib.V_Get_Stt_Rec(M_Ma_CT, AppConn)

        M_Mode = "M"
        V_Databing()
        '--------------
        TxtStt_Rec.Text = M_Stt_Rec
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        If txtDien_giai.Text.Trim = "" Then txtDien_giai.Text = M_Dien_Giai

        V_New()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("M")
        '----------------------------------------------------------------------------
        CyberSmodb.SetValueFromCombox(CbbMa_TTCP_H, M_Ma_TTCP_H)
        '----------------------------------------------------------------------------
    End Sub
    Private Sub V_New()
        If Dt_DetailTmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailTmp.NewRow()
            DrCurren = Dt_DetailTmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)


            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"
            If Dt_DetailCvTmp.Columns.Contains("Ma_Xe_i") Then DrCurren.Item("Ma_Xe_I") = TxtMa_Xe.Text.Trim

            Dt_DetailTmp.Rows.Add(DrCurren)
            Dt_DetailTmp.AcceptChanges()
        End If

        If Dt_DetailCvTmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailCvTmp.NewRow()
            DrCurren = Dt_DetailCvTmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)


            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"
            If Dt_DetailCvTmp.Columns.Contains("Ma_Xe_i") Then DrCurren.Item("Ma_Xe_I") = TxtMa_Xe.Text.Trim

            Dt_DetailCvTmp.Rows.Add(DrCurren)
            Dt_DetailCvTmp.AcceptChanges()
        End If

        If Dt_DetailCTTmp.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            Dt_DetailCTTmp.NewRow()
            DrCurren = Dt_DetailCTTmp.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)


            DrCurren.Item("Stt_Rec") = M_Stt_Rec.Trim
            DrCurren.Item("Ma_Ct") = M_Ma_CT.Trim
            DrCurren.Item("Ngay_Ct") = TxtNgay_Ct.Value
            DrCurren.Item("Stt_Rec0") = "0001"
            If Dt_DetailCTTmp.Columns.Contains("Ma_Xe_i") Then DrCurren.Item("Ma_Xe_I") = TxtMa_Xe.Text.Trim

            Dt_DetailCTTmp.Rows.Add(DrCurren)
            Dt_DetailCTTmp.AcceptChanges()
        End If

    End Sub
    Private Sub V_Edit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_RecOld = M_Stt_Rec
        If Not ChkRightsVoucher("S") Then Exit Sub
        M_Mode = "S"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("S")
    End Sub
    Private Sub V_Delete(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("D") Then Exit Sub
        Dim iMasterRow As Integer = -1
        For iRow As Integer = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim = M_Stt_Rec Then
                iMasterRow = iRow
                Exit For
            End If
        Next
        If Not CyberSupport.V_DeleteVoucher(AppConn, osysvar, M_LAN, M_Stt_Rec, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib) Then Exit Sub

        CyberSupport.V_DeleteTableVoucher(Dt_Master, M_Stt_Rec)
        CyberSupport.V_DeleteTableVoucher(Dt_Detail, M_Stt_Rec)
        CyberSupport.V_DeleteTableVoucher(Dt_DetailCv, M_Stt_Rec)
        CyberSupport.V_DeleteTableVoucher(Dt_DetailCT, M_Stt_Rec)

        M_Count = Dt_Master.Rows.Count

        If M_Count < 0 Then iMasterRow = -1
        If iMasterRow >= M_Count Then iMasterRow = M_Count - 1

        If iMasterRow >= 0 Then M_Stt_Rec = Dv_Master.Item(iMasterRow).Item("Stt_Rec").ToString.Trim Else M_Stt_Rec = ""

        M_Mode = "X"
        V_Databing()

        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("D")
    End Sub
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkRightsVoucher("P") Then Exit Sub
        If M_Stt_Rec.Trim = "" Then Exit Sub
        Dim _Dt As Date = TxtNgay_Ct.Value
        Dim _Ma_Post As String = CbbMa_Post.SelectedValue.ToString.Trim
        CyberVoucher.V_PrintVocuher(AppConn, osysvar, Nothing, M_Stt_Rec, _Dt, _Ma_Post, M_LAN, M_Para, DrDmct, M_Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)
    End Sub
    Private Sub V_Cancel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Stt_Rec = M_Stt_RecOld
        V_Databing()
        M_Mode = "X"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        V_SetFocus("X")
    End Sub
    Private Sub V_View(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Mode = "X"
        If M_Stt_Rec = "" Then Exit Sub
        M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, DsData, DsHead, DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)
        V_Databing()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CyberVoucher.V_FilterVocuher(AppConn, osysvar, Me.DsLookup, M_LAN, M_Para, DrDmct, M_strFilter, M_Ma_CT, M_Ma_Dvcs, M_User_Name) Then Exit Sub
        Dim DsRefresh As DataSet = CyberSupport.V_FilterData(AppConn, M_strFilter, CyberSmlib, CyberSmodb, DsData)
        If Not CyberSupport.MsgFilterData(DsRefresh.Tables(1), M_LAN, osysvar) Then Exit Sub

        If DsRefresh.Tables(1).Rows.Count = 1 Then M_Stt_Rec = DsRefresh.Tables(1).Rows(0).Item("Stt_Rec")
        If DsRefresh.Tables(1).Rows.Count > 1 Then M_Stt_Rec = CyberFrom.V_ViewVoucher(AppConn, osysvar, M_LAN, M_Para, DrDmct, Me.DsData, Me.DsHead, Me.DsLookup, Dv_Master, Dv_Detail, M_Stt_Rec, strFilter, CyberFill, CyberSmlib, CyberSupport, False, True)

        V_Databing()
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
        M_Mode = "X"
        CyberMe.V_SetEnabled(Me, M_Mode, Dt_Master)
        V_Setstatus()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not CyberSupport.V_ExitVoucher(osysvar, M_LAN) Then Exit Sub
        Me.Close()
    End Sub
#End Region
#Region "Add Or Detete Item"
    Private Sub MasterGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = DetailGRVVT.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = DetailGRVVT.RowCount - 1
        Dim iRowRowFocus As Integer = DetailGRVVT.FocusedRowHandle
        Dim iColumnRowFocus As Integer = DetailGRVVT.VisibleColumns.IndexOf(DetailGRVVT.FocusedColumn)
        Dim iRowOld As Integer = DetailGRVVT.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub

        If e.KeyCode = Keys.Enter Then
            V_AddItem(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = Dv_DetailTmp.Item(iRow) Else DrvOld = Nothing
        Dv_DetailTmp.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1), New DataView(M_DsHead.Tables(1)))
        CarrOn(Dv_DetailTmp.Table.Rows(Dv_DetailTmp.Table.Rows.Count - 1))
        UpdateList()
        iRow = Dv_DetailTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVVT, iRow, 0)

    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
#End Region
#Region "Add Or Detete Item Cong Viec"
    Private Sub MasterGRVCv_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItemCv(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItemCv(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        Dim TbHeader As New DataTable
        vTbAdd = Dv_DetailCvTmp
        TbHeader = M_DsHead.Tables(2)
        '===================================
        If iRow >= 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing
        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), New DataView(TbHeader))
        CarrOnCv(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailCvTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCv, iRow, 0)
        UpdateList()
    End Sub
    Private Sub CarrOnCv(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
#End Region

#Region "Add Or Detete Item Cong Viec cho tiet"
    Private Sub MasterGRVCT_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItemCT(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
    Private Sub V_AddItemCT(Optional ByVal iRow As Integer = -1)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        Dim TbHeader As New DataTable
        vTbAdd = Dv_DetailCTTmp
        TbHeader = M_DsHead.Tables(3)
        '===================================
        If iRow >= 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing
        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), New DataView(TbHeader))
        CarrOnCT(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailCTTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCT, iRow, 0)
        UpdateList()
    End Sub
    Private Sub CarrOnCT(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = M_Stt_Rec.Trim
        DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        DvNew.Item("Ngay_Ct") = Me.TxtNgay_Ct.Value
    End Sub
#End Region

#Region "Sms - Import"
    Private Sub V_Import(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TbImport As New DataTable
        TbImport = CyberExport.V_ImportDataToGridview(AppConn, osysvar, M_Para, DetailGRVVT, Dt_DetailTmp, M_LAN)
        If TbImport Is Nothing Then Exit Sub
        '==================== Xu ly du lieu được Import vào
        Dt_DetailTmp.Clear()
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To TbImport.Rows.Count - 1
            Dt_DetailTmp.ImportRow(TbImport.Rows(i))
        Next
        Dt_DetailTmp.AcceptChanges()
        For iRow = 0 To Dt_DetailTmp.Rows.Count - 1
            V_Tinh_Toan(iRow)
        Next
        Dt_DetailTmp.AcceptChanges()
    End Sub
    Private Sub V_ImportCv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim TbImport As New DataTable
        TbImport = CyberExport.V_ImportDataToGridview(AppConn, osysvar, M_Para, DetailGRVCv, Dt_DetailCvTmp, M_LAN)
        If TbImport Is Nothing Then Exit Sub
        '==================== Xu ly du lieu được Import vào
        Dt_DetailCvTmp.Clear()
        Dt_DetailCvTmp.AcceptChanges()
        For i = 0 To TbImport.Rows.Count - 1
            Dt_DetailCvTmp.ImportRow(TbImport.Rows(i))
        Next
        Dt_DetailCvTmp.AcceptChanges()
    End Sub
    Private Sub SetTxt()

        TxtT_CV.ReadOnly = True
        TxtT_Thue_CV.ReadOnly = True
        TxtT_TT_CV.ReadOnly = True

        TxtSo_Ro.ReadOnly = True
        TxtMa_Kx.ReadOnly = True
        Txtten_kx.ReadOnly = True

        TxtMa_Tuyen.ReadOnly = True
        Txtten_Tuyen.ReadOnly = True

        TxtSo_khung.ReadOnly = True
        TxtSo_May.ReadOnly = True
        TxtTen_Lx.ReadOnly = True

        TxtT_SO_LUONG.ReadOnly = True
        TxtT_Tien_NT.ReadOnly = True
        TxtT_Tien.ReadOnly = True

    End Sub
#End Region
#Region "TTCP Default and New/Save _TTCP"
    Dim M_Is_Visible_TTCP As Boolean = False
    Dim DtTTCP As DataTable
    Dim M_Ma_TTCP_H As String = ""
    Dim M_Ten_TTCP_H As String = ""
    Dim M_Ten_TTCP2_H As String = ""

    Dim M_Ma_TTLN_H As String = ""
    Dim M_Ten_TTLN_H As String = ""
    Dim M_Ten_TTLN2_H As String = ""

    Dim M_Ma_HS_H As String = ""
    Dim M_Ten_HS_H As String = ""
    Dim M_Ten_HS2_H As String = ""

    Dim M_Ma_BP_H As String = ""
    Dim M_Ten_BP_H As String = ""
    Dim M_Ten_BP2_H As String = ""
    Private Sub V_LoadDefault()
        If DrDmct.Table.Columns.Contains("Is_Visible_TTCP") Then M_Is_Visible_TTCP = (DrDmct.Item("Is_Visible_TTCP").ToString.Trim = "1")
        LabMa_TTCP_H.Visible = M_Is_Visible_TTCP
        CbbMa_TTCP_H.Visible = M_Is_Visible_TTCP
        If M_Is_Visible_TTCP And DrDmct.Table.Columns.Contains("CaptionTTCP") Then If DrDmct.Item("CaptionTTCP").ToString.Trim <> "" Then LabMa_TTCP_H.Text = DrDmct.Item("CaptionTTCP").ToString.Trim

        If M_Is_Visible_TTCP Then
            Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetDefaultVoucher", M_Ma_CT.Trim & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())

            If DsTmp.Tables.Count = 0 Then
                M_Is_Visible_TTCP = False
                DsTmp.Dispose()
                Return
            End If

            If DsTmp.Tables(0).Columns.Contains("Ma_TTCP_H") Then M_Ma_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ma_TTCP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTCP_H") Then M_Ten_TTCP_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTCP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTCP2_H") Then M_Ten_TTCP2_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTCP2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_TTLN_H") Then M_Ma_TTLN_H = DsTmp.Tables(0).Rows(0).Item("Ma_TTLN_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTLN_H") Then M_Ten_TTLN_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTLN_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_TTLN2_H") Then M_Ten_TTLN2_H = DsTmp.Tables(0).Rows(0).Item("Ten_TTLN2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_HS_H") Then M_Ma_HS_H = DsTmp.Tables(0).Rows(0).Item("Ma_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS_H") Then M_Ten_HS_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_HS2_H") Then M_Ten_HS2_H = DsTmp.Tables(0).Rows(0).Item("Ten_HS2_H").ToString.Trim

            If DsTmp.Tables(0).Columns.Contains("Ma_BP_H") Then M_Ma_BP_H = DsTmp.Tables(0).Rows(0).Item("Ma_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP_H") Then M_Ten_BP_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP_H").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Ten_BP2_H") Then M_Ten_BP2_H = DsTmp.Tables(0).Rows(0).Item("Ten_BP2_H").ToString.Trim

            If DsTmp.Tables.Count > 1 Then
                DtTTCP = DsTmp.Tables(1).Copy
                CyberFill.V_FillComBoxValue(Me.CbbMa_TTCP_H, DtTTCP, "Ma_TTCP", If(M_LAN = "V", "Ten_TTCP", "Ten_TTCP2"), M_Ma_TTCP_H)
            Else
                M_Is_Visible_TTCP = False
            End If

            DsTmp.Dispose()
        End If
    End Sub

      

#End Region
End Class


