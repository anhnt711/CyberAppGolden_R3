Imports System.Windows.Forms
Public Class DMCV
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DT_DetailCVTmp, Dt_HeadCV, Dt_DmCt As DataTable
    Dim Dv_DetailCVTmp, Dv_HeadCV, Dv_DmCt As DataView
    Dim EditMa_KX, EditTen_KX, EditGio_TC, EditGia_CV, EditMa_Khoang, EditTen_Khoang, EditPt1, EditTien_PT1, EditPt2, EditTien_PT2 As New Cyber.Fill.CyberColumnGridView
    Dim M_Ma_CT As String = "HDK"
    Dim M_Ma_TT As String = "C"
    Dim Lan As String = "V"
    Dim Ma_CvOld, Ma_DvcsOld As String
    Private Sub FDMCV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_Cv.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load and System"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_FilterDmCVKX", TxtMa_Cv.Text.Trim + "#" + Me.Mode.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        DT_DetailCVTmp = DsTmp.Tables(0).Copy
        Dt_HeadCV = DsTmp.Tables(1).Copy
        Dt_DmCt = DsTmp.Tables(2).Copy

        Dv_DetailCVTmp = New DataView(DT_DetailCVTmp)
        Dv_HeadCV = New DataView(Dt_HeadCV)
        Dv_DmCt = New DataView(Dt_DmCt)

        '========= FillData to Gridview Cv
        DetailCv.DataSource = Dv_DetailCVTmp
        Me.DetailGRVCv.GridControl = Me.DetailCv
        CyberFill.V_FillVoucher(DetailGRVCv, M_LAN, Dv_HeadCV, Dv_DetailCVTmp, Dt_DmCt.Rows(0))

        V_GetColumn()
        V_MainSystem()
        V_AddHandDetail()

        V_CreateFillMucSDS()
        V_VisbleMuc_SBD()

        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If TxtNh_Cv1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCV", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Cv1.Text.Trim + "')", CyberSmlib)
        If TxtNh_Cv2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCV", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_Cv2.Text.Trim + "')", CyberSmlib)
        If TxtNh_Cv3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCV", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_Cv3.Text.Trim + "')", CyberSmlib)
        If TxtNh_Cv4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCV", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_Cv4.Text.Trim + "')", CyberSmlib)
        If TxtNh_Cv5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhCV", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_Cv5.Text.Trim + "')", CyberSmlib)

        LabThue_suat.Text = CyberSmodb.SQLGetvalue(Appconn, "Thue_suat", "Dmthue", "(Ma_Thue = N'" + TxtMa_thue.Text.Trim + "')", CyberSmlib)
        TxtTen_HS.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_HS", "Dmhs", "(Ma_HS = N'" + TxtMa_HS.Text.Trim + "')", CyberSmlib)
        TxtTen_Tk_DT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "Dmtk0", "(TK0 = N'" + TxtTk_dt.Text.Trim + "')", CyberSmlib)
        TxtTen_TT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TT", "Dmtt", "(MA_TT = N'" + TxtMa_TT.Text.Trim + "')", CyberSmlib)
        TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kx", "DmKx", "(Ma_Kx = N'" + TxtMa_Kx.Text.Trim + "')", CyberSmlib)
        If TxtNh_Kx1.Text.Trim = "" Then TxtTen_Nh_Kx1.Text = "" Else TxtTen_Nh_Kx1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKX", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_Kx1.Text.Trim + "')", CyberSmlib)

        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If Mode = "M" Then
            Ma_CvOld = ""
            Ma_DvcsOld = ""
        Else
            Ma_CvOld = TxtMa_Cv.Text.Trim
            Ma_DvcsOld = TxtMa_Dvcs.Text.Trim
        End If

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_Cv.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Cv.KeyPress, AddressOf TxtCodeError_KeyPress

        AddHandler TxtMa_thue.CyberValiting, AddressOf V_Ma_thue
        AddHandler TxtMa_thue.CyberLeave, AddressOf L_Ma_thue
        '--Nh_CV1
        RemoveHandler TxtNh_Cv1.CyberValiting, AddressOf V_Nh_Cv1
        RemoveHandler TxtNh_Cv1.CyberLeave, AddressOf L_Nh_Cv1
        AddHandler TxtNh_Cv1.CyberValiting, AddressOf V_Nh_Cv1
        AddHandler TxtNh_Cv1.CyberLeave, AddressOf L_Nh_Cv1
        '--Nh_CV2
        RemoveHandler TxtNh_Cv2.CyberValiting, AddressOf V_Nh_Cv2
        RemoveHandler TxtNh_Cv2.CyberLeave, AddressOf L_Nh_Cv2
        AddHandler TxtNh_Cv2.CyberValiting, AddressOf V_Nh_Cv2
        AddHandler TxtNh_Cv2.CyberLeave, AddressOf L_Nh_Cv2
        '--Nh_CV3
        RemoveHandler TxtNh_Cv3.CyberValiting, AddressOf V_Nh_Cv3
        RemoveHandler TxtNh_Cv3.CyberLeave, AddressOf L_Nh_Cv3
        AddHandler TxtNh_Cv3.CyberValiting, AddressOf V_Nh_Cv3
        AddHandler TxtNh_Cv3.CyberLeave, AddressOf L_Nh_Cv3
        '--Nh_CV4
        RemoveHandler TxtNh_Cv4.CyberValiting, AddressOf V_Nh_Cv4
        RemoveHandler TxtNh_Cv4.CyberLeave, AddressOf L_Nh_Cv4
        AddHandler TxtNh_Cv4.CyberValiting, AddressOf V_Nh_Cv4
        AddHandler TxtNh_Cv4.CyberLeave, AddressOf L_Nh_Cv4
        '--Nh_CV5
        RemoveHandler TxtNh_Cv5.CyberValiting, AddressOf V_Nh_Cv5
        RemoveHandler TxtNh_Cv5.CyberLeave, AddressOf L_Nh_Cv5
        AddHandler TxtNh_Cv5.CyberValiting, AddressOf V_Nh_Cv5
        AddHandler TxtNh_Cv5.CyberLeave, AddressOf L_Nh_Cv5

        '--Ma_KX
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_KX1
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_KX1

        '--Nh_KX1
        AddHandler TxtNh_Kx1.CyberValiting, AddressOf V_Nh_KX1
        AddHandler TxtNh_Kx1.CyberLeave, AddressOf L_Nh_KX1

        '--Ma_TT
        AddHandler TxtMa_TT.CyberValiting, AddressOf V_Ma_TT
        AddHandler TxtMa_TT.CyberLeave, AddressOf L_Ma_TT

        '--Tk_dt
        AddHandler TxtTk_dt.CyberValiting, AddressOf V_Tk_Dt
        AddHandler TxtTk_dt.CyberLeave, AddressOf L_Dt_DT
        '--Ma_Khoang

        AddHandler Txtma_Khoang.CyberValiting, AddressOf V_Ma_khoang
        AddHandler Txtma_Khoang.CyberLeave, AddressOf L_Ma_Khoang

        '--Ma_Hs
        AddHandler TxtMa_HS.CyberValiting, AddressOf V_Ma_HS
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_Ma_HS
        AddHandler TxtGia_CV.Leave, AddressOf L_Tinh_Toan
        AddHandler TxtGio_TC.Leave, AddressOf L_Tinh_Toan
        AddHandler TxtTien_CV.Leave, AddressOf L_Tinh_Toan

        AddHandler ChkIs_SBD.CheckedChanged, AddressOf V_Chk_IS_SBD

    End Sub
#Region "Mức Mức bảo dưỡng"
    Dim Dt_DmMucSBD As New DataTable
    Private Sub V_CreateFillMucSDS()

        Dt_DmMucSBD.Columns.Add("Muc_SBD")
        Dt_DmMucSBD.Columns.Add("Ten_SBD")
        Dt_DmMucSBD.Columns.Add("Ten_SBD2")
        Dt_DmMucSBD.Columns.Add("Default")

        Dt_DmMucSBD.Rows.Add("1", "1K", "Super light", "0")
        Dt_DmMucSBD.Rows.Add("2", "Nhỏ", "light", "0")
        Dt_DmMucSBD.Rows.Add("3", "Trung bình", "Medium", "1")
        Dt_DmMucSBD.Rows.Add("4", "Trung bình lớn", "Heavy", "0")
        Dt_DmMucSBD.Rows.Add("5", "Bảo dưỡng lớn", "Heavy", "0")
        CyberFill.V_FillComBoxDefaul(CbbMuc_SBD, Dt_DmMucSBD, "Muc_SBD", If(M_LAN = "V", "Ten_SBD", "Ten_SBD2"), "Default")

    End Sub
    Private Sub V_VisbleMuc_SBD()
        CbbMuc_SBD.Visible = ChkIs_SBD.Checked
    End Sub
    Private Sub V_Chk_IS_SBD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_VisbleMuc_SBD()
    End Sub

#End Region

    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub V_MainSystem()
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsManl As New Windows.Forms.ContextMenu
        Dim mnItemsF4 As New MenuItem("Thêm dòng", AddressOf V_ShortAddItem, Keys.F4)
        Dim mnItemsF8 As New MenuItem("Xóa dòng", AddressOf V_ShortDeleteItem, Keys.F8)

        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        DetailGRVCv.GridControl.ContextMenu = mnItemsMail
        Me.ContextMenu = mnItemsManl
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer = e.HitInfo.RowHandle
        If e.MenuType <> DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
            PopupMenuMasterGrid.ItemLinks.Clear()
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Thêm dòng", "Add item"), AddressOf V_ShortAddItem, Nothing, True, False))
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa dòng", "Delete item"), AddressOf V_ShortDeleteItem, Nothing, True, False))
            PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        End If
    End Sub
    Private Sub V_GetColumn()
        EditMa_KX.GetColumn(Me.DetailGRVCv, "Ma_KX")
        EditTen_KX.GetColumn(Me.DetailGRVCv, "Ten_KX")
        EditGio_TC.GetColumn(Me.DetailGRVCv, "Gio_TC")
        EditGia_CV.GetColumn(Me.DetailGRVCv, "Gia_CV")
        EditMa_Khoang.GetColumn(Me.DetailGRVCv, "Ma_Khoang")
        EditPt1.GetColumn(Me.DetailGRVCv, "PT1")
        EditTien_PT1.GetColumn(Me.DetailGRVCv, "Tien_PT1")
        EditPt2.GetColumn(Me.DetailGRVCv, "PT2")
        EditTien_PT2.GetColumn(Me.DetailGRVCv, "Tien_PT2")
    End Sub
    Private Sub V_AddHandDetail()
        EditMa_KX.V_ActiLookUpColumn(AddressOf V_Ma_KX, AddressOf L_Ma_KX)
        EditMa_Khoang.V_ActiLookUpColumn(AddressOf V_Ma_Khoang_I, AddressOf L_Ma_Khoang_I)
        If Not EditGio_TC.Column Is Nothing Then AddHandler EditGio_TC.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditGia_CV.Column Is Nothing Then AddHandler EditGia_CV.EditColumn.Leave, AddressOf V_Tinh_ToanCV

        If Not EditPt1.Column Is Nothing Then AddHandler EditPt1.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditTien_PT1.Column Is Nothing Then AddHandler EditTien_PT1.EditColumn.Leave, AddressOf V_Tinh_ToanCV

        If Not EditPt2.Column Is Nothing Then AddHandler EditPt2.EditColumn.Leave, AddressOf V_Tinh_ToanCV
        If Not EditTien_PT2.Column Is Nothing Then AddHandler EditTien_PT2.EditColumn.Leave, AddressOf V_Tinh_ToanCV

    End Sub
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Cv.Text = _Value

        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub

        Dim nCount As Integer = 0
        nCount = Dv_DetailCVTmp.Count - 1
        For i = nCount To 0 Step -1
            If Dv_DetailCVTmp.Item(i).Item("Ma_Kx").ToString.Trim = "" Then Dv_DetailCVTmp.Item(i).Delete()
        Next
        DT_DetailCVTmp.AcceptChanges()

        For i = 0 To Dv_DetailCVTmp.Count - 1
            Dv_DetailCVTmp.Item(i).BeginEdit()

            Dv_DetailCVTmp.Item(i).Item("Ma_Cv") = TxtMa_Cv.Text.Trim
            If DT_DetailCVTmp.Columns.Contains("Ma_Dvcs") Then Dv_DetailCVTmp.Item(i).Item("Ma_Dvcs") = TxtMa_Dvcs.Text.Trim

            Dv_DetailCVTmp.Item(i).Item("Stt_Rec0") = CyberSupport.GetStt_Rec0(i + 1)
            Dv_DetailCVTmp.Item(i).EndEdit()
        Next
        DT_DetailCVTmp.AcceptChanges()
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, DT_DetailCVTmp, "DMCVKX", Mode, "Ma_Cv = N'" + Ma_CvOld.Trim + "'")
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
#End Region
#Region "Master============================="
    Private Sub L_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtGia_CV.Double * TxtGio_TC.Double <> 0 Then TxtTien_CV.Double = CyberSupport.V_Round(TxtGia_CV.Double * TxtGio_TC.Double, 0)
    End Sub
    Private Sub V_Ma_thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Thue", "DmThue", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_thue(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_thue.Text = DrReturn.Item("Ma_Thue")
            txtThue_suat.Double = DrReturn.Item("Thue_suat")
        Else
            TxtMa_thue.Text = ""
            txtThue_suat.Double = 0
        End If
    End Sub
#Region "Vali --- Nh_Cv1"
    Private Sub V_Nh_Cv1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Cv1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCv", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Cv1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Cv1.GetRowsSelectData(True)
        If TxtNh_Cv1.Text = "" Then
            TxtTen_Nh1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_Cv1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Cv1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Cv2"
    Private Sub V_Nh_Cv2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Cv2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCv", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_Cv2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Cv2.Text = "" Then
            TxtTen_Nh2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Cv2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Cv2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Cv2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Cv3"
    Private Sub V_Nh_Cv3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Cv3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCv", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_Cv3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not DrReturn Is Nothing Then TxtNh_Cv3.Text = DrReturn.Item("Ma_Nh")
        If TxtNh_Cv3.Text = "" Then
            TxtTen_Nh3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Cv3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Cv3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Cv3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Cv4"
    Private Sub V_Nh_Cv4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Cv4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCv", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_Nh_Cv4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Cv4.Text = "" Then
            TxtTen_Nh4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Cv4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Cv4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Cv4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Cv5"
    Private Sub V_Nh_Cv5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Cv5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhCv", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_Nh_Cv5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNh_Cv5.Text = "" Then
            TxtTen_Nh5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtNh_Cv5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_Cv5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Cv5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region

#Region "Vali --- Ma_Kx1"
    Private Sub V_Ma_Kx1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kx", "DMKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kx.Text = "" Then
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_Kx")
            TxtTen_Kx.Text = DrReturn.Item("Ten_Kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_Kx1"
    Private Sub V_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_Kx1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKx", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_Nh_Kx1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_Kx1.GetRowsSelectData(True)
        If TxtNh_Kx1.Text = "" Then
            TxtTen_Nh_Kx1.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtNh_Kx1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh_Kx1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_Kx1.Text = ""
            TxtTen_Nh_Kx1.Text = ""
        End If
    End Sub
#End Region

#Region "Vali --- Ma_TT"
    Private Sub V_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TT", "DMTT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_TT.Text = "" Then
            TxtTen_TT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_TT.Text = DrReturn.Item("Ma_TT")
            TxtTen_TT.Text = DrReturn.Item("Ten_TT")
        Else
            TxtMa_TT.Text = ""
            TxtTen_TT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_DT"
    Private Sub V_Tk_Dt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk0", "DmTk0", "1=1", "1=1")
    End Sub
    Private Sub L_Dt_DT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtTk_dt.Text = "" Then
            TxtTen_Tk_DT.Text = ""
            Exit Sub
        End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_dt.Text = DrReturn.Item("tk0")
            TxtTen_Tk_DT.Text = DrReturn.Item("Ten_tk0")
        Else
            TxtTk_dt.Text = ""
            TxtTen_Tk_DT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Khoang"
    Private Sub V_Ma_khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "ma_khoang", "Dmkhoang", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If TxtTk_dt.Text = "" Then
        '    TxtTen_Tk0.Text = ""
        '    Exit Sub
        'End If
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_Khoang.Text = DrReturn.Item("ma_khoang")
            Txtten_Khoang.Text = DrReturn.Item("Ten_khoang")
        Else
            TxtTk_dt.Text = ""
            TxtTen_Tk_DT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_HS"
    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HS", "DMHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_HS.Text = "" Then
            TxtTen_HS.Text = ""
            Exit Sub
        End If
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
#End Region
#Region "Detail============================="
#Region "Vali --- Ma_kx"
    Private Sub V_Ma_KX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kx", "DMKX", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Me.Mode = "S") Then Exit Sub
        DrReturn = Nothing

        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCVTmp.Item(iRow).BeginEdit()
            Dv_DetailCVTmp.Item(iRow)("Ma_kx") = ""
            Dv_DetailCVTmp.Item(iRow).Item("Ten_kx") = ""

            Dv_DetailCVTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_KX As String = "", _Ten_KX As String = ""

        _Ma_KX = DrReturn("Ma_kx").ToString.Trim
        _Ten_KX = DrReturn("Ten_kx").ToString.Trim
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailCVTmp.Item(iRow).BeginEdit()
        Dv_DetailCVTmp.Item(iRow).Item("Ma_kx") = _Ma_KX
        Dv_DetailCVTmp.Item(iRow).Item("Ten_kx") = _Ten_KX

        Dv_DetailCVTmp.Item(iRow).EndEdit()

        DetailGRVCv.UpdateCurrentRow()
    End Sub
#End Region
#Region "Vali --- Ma_khoang"
    Private Sub V_Ma_Khoang_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_khoang", "DMKHOANG", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Khoang_I(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Me.Mode = "M" Or Me.Mode = "S") Then Exit Sub
        DrReturn = Nothing

        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DrReturn = CyberSupport.L_Lookup(Me.Mode, M_Ma_CT, sender, True)
        If DrReturn Is Nothing Then
            Dv_DetailCVTmp.Item(iRow).BeginEdit()
            Dv_DetailCVTmp.Item(iRow)("Ma_khoang") = ""
            If Dv_DetailCVTmp.Table.Columns.Contains("Ten_khoang") Then Dv_DetailCVTmp.Item(iRow).Item("Ten_khoang") = ""
            Dv_DetailCVTmp.Item(iRow).EndEdit()
            Exit Sub
        End If
        Dim _Ma_Khoang As String = "", _Ten_Khoang As String = ""
        _Ma_Khoang = DrReturn("Ma_khoang").ToString.Trim
        _Ten_Khoang = DrReturn("Ten_khoang").ToString.Trim
        '-----------------------------------------------------------------------------------------------------------
        Dv_DetailCVTmp.Item(iRow).BeginEdit()
        Dv_DetailCVTmp.Item(iRow).Item("Ma_khoang") = _Ma_Khoang
        If Dv_DetailCVTmp.Table.Columns.Contains("Ten_khoang") Then Dv_DetailCVTmp.Item(iRow).Item("Ten_khoang") = _Ten_Khoang
        Dv_DetailCVTmp.Item(iRow).EndEdit()
        DetailGRVCv.UpdateCurrentRow()
    End Sub
#End Region
#Region "Tinh toan"
    Private Sub V_Tinh_ToanCV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRVCv.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        DT_DetailCVTmp.AcceptChanges()
        Tinh_TienCV(iRow)
    End Sub
    Private Sub Tinh_TienCV(ByVal iRow As Integer)
        If iRow < 0 Then Exit Sub
        '-----------------------------------------------------------
        If Dv_DetailCVTmp.Table.Columns.Contains("Gia_CV") And Dv_DetailCVTmp.Table.Columns.Contains("Gio_TC") And Dv_DetailCVTmp.Table.Columns.Contains("Tien_CV") Then
            If Dv_DetailCVTmp.Item(iRow).Item("Gia_CV") * Dv_DetailCVTmp.Item(iRow).Item("Gio_TC") <> 0 Then
                Dv_DetailCVTmp.Item(iRow).BeginEdit()
                Dv_DetailCVTmp.Item(iRow).Item("Tien_CV") = CyberSupport.V_Round(Dv_DetailCVTmp.Item(iRow).Item("Gia_CV") * Dv_DetailCVTmp.Item(iRow).Item("Gio_TC"), 0)
                Dv_DetailCVTmp.Item(iRow).EndEdit()
            End If
        End If
        '-----------------------------------------------------------
        Dv_DetailCVTmp.Item(iRow).BeginEdit()
        If Dv_DetailCVTmp.Table.Columns.Contains("Pt1") And Dv_DetailCVTmp.Table.Columns.Contains("Tien_CV") Then
            Dim _Tien_PT1 As Decimal = CyberSupport.V_Round(Dv_DetailCVTmp.Item(iRow).Item("Pt1") * Dv_DetailCVTmp.Item(iRow).Item("Tien_CV") / 100, 0)
            If _Tien_PT1 <> 0 Then Dv_DetailCVTmp.Item(iRow).Item("Tien_PT1") = _Tien_PT1
        End If
        If Dv_DetailCVTmp.Table.Columns.Contains("Pt2") And Dv_DetailCVTmp.Table.Columns.Contains("Tien_CV") Then
            Dim _Tien_PT2 As Decimal = CyberSupport.V_Round(Dv_DetailCVTmp.Item(iRow).Item("Pt2") * Dv_DetailCVTmp.Item(iRow).Item("Tien_CV") / 100, 0)
            If _Tien_PT2 <> 0 Then Dv_DetailCVTmp.Item(iRow).Item("Tien_PT2") = _Tien_PT2
        End If
        Dv_DetailCVTmp.Item(iRow).EndEdit()
        '-----------------------------------------------------------
        DetailGRVCv.UpdateCurrentRow()
    End Sub
#End Region
#Region "GRV----"
    Private Sub V_ShortAddItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        Dim DrvOld As DataRowView
        '===================================
        Dim vTbAdd As New DataView
        vTbAdd = Dv_DetailCVTmp
        '===================================
        If iRow >= 0 Then DrvOld = vTbAdd.Item(iRow) Else DrvOld = Nothing

        vTbAdd.Table.Rows.Add()
        CyberSmodb.SetValueBlankRow(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1), Dv_HeadCV)
        CarrOn(vTbAdd.Table.Rows(vTbAdd.Table.Rows.Count - 1))

        iRow = Dv_DetailCVTmp.Count - 1
        CyberFill.V_ForcusCell(DetailGRVCv, iRow, 0)

    End Sub
    Private Sub CarrOn(ByVal DvNew As DataRow)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = DetailGRVCv.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, M_Ma_CT, iRow, Dv_DetailCVTmp, Appconn) Then Exit Sub
        Dv_DetailCVTmp.Delete(iRow)
        Dv_DetailCVTmp.Table.AcceptChanges()

    End Sub
    Private Sub MasterGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Dim iCoumnVisible As Integer = sender.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = sender.RowCount - 1
        Dim iRowRowFocus As Integer = sender.FocusedRowHandle
        Dim iColumnRowFocus As Integer = sender.VisibleColumns.IndexOf(sender.FocusedColumn)
        Dim iRowOld As Integer = sender.GetFocusedDataSourceRowIndex
        'If e.KeyCode = Keys.Enter And iRowVisible = iRowRowFocus And iCoumnVisible = iColumnRowFocus Then V_AddItem(iRowOld) '' Cot cuoi cung them dong
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItem(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
#End Region
#End Region
End Class