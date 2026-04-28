Imports System.Windows.Forms

Public Class FrmVOC_XLKN_F4
    Dim M_Stt_rec As String = "", M_Stt_rec0 As String = "", M_Stt_rec0VOC As String = "", M_Ma_Lv As String = "", M_Back_Color As String = "", M_Ma_PostVOC As String = "", M_Ma_xe As String = "", M_so_ct As String = "", M_Mode As String = "", M_Row As DataRow = Nothing
    Public Property Stt_rec() As String
        Get
            Stt_rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
        End Set
    End Property
    Public Property Stt_rec0() As String
        Get
            Stt_rec0 = M_Stt_rec0
        End Get
        Set(ByVal Value As String)
            M_Stt_rec0 = Value
        End Set
    End Property
    Public Property Stt_rec0VOC() As String
        Get
            Stt_rec0VOC = M_Stt_rec0VOC
        End Get
        Set(ByVal Value As String)
            M_Stt_rec0VOC = Value
        End Set
    End Property
    Public Property Ma_Lv() As String
        Get
            Ma_lv = M_Ma_lv
        End Get
        Set(ByVal Value As String)
            M_Ma_lv = Value
        End Set
    End Property
    Public Property Ma_xe() As String
        Get
            Ma_xe = M_Ma_xe
        End Get
        Set(ByVal Value As String)
            M_Ma_xe = Value
        End Set
    End Property
    Public Property So_ct() As String
        Get
            So_ct = M_so_ct
        End Get
        Set(ByVal Value As String)
            M_so_ct = Value
        End Set
    End Property
    Public Property Back_Color() As String
        Get
            Back_Color = M_Back_Color
        End Get
        Set(ByVal Value As String)
            M_Back_Color = Value
        End Set
    End Property
    Public Property Ma_postVOC() As String
        Get
            Ma_postVOC = M_Ma_PostVOC
        End Get
        Set(ByVal Value As String)
            M_Ma_PostVOC = Value
        End Set
    End Property
    Public Property Mode() As String
        Get
            Mode = M_Mode
        End Get
        Set(ByVal Value As String)
            M_Mode = Value
        End Set
    End Property
    Public Property Row() As DataRow
        Get
            Row = M_Row
        End Get
        Set(ByVal Value As DataRow)
            M_Row = Value
        End Set
    End Property
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable
    Dim Dt_TTXL, TbTtxL, _Dt_VD, _Dt_BPHH, _Dt_CTVD, tbPostVOC As DataTable
    Dim vtbttxl, _Dv_BPHH, _Dv_CTVD As DataView
    Private Sub ROXPTFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_Addhander()

        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()        
    End Sub
    Private Sub V_Load()        
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GetVOC_VXLInfo", M_Ma_Lv & "#" & M_Stt_rec & "#" & M_Ma_Dvcs.ToString().Trim() & "#" & M_User_Name.ToString().Trim())
        _Dt_VD = DsTmp.Tables(0).Copy
        _Dt_BPHH = DsTmp.Tables(1).Copy
        _Dt_ctvd = DsTmp.Tables(2).Copy

        TbTtxL = DsTmp.Tables(3).Copy
        tbPostVOC = DsTmp.Tables(4).Copy
        vtbttxl = New DataView(TbTtxL)
        _Dv_BPHH = New DataView(_Dt_BPHH)
        _Dv_CTVD = New DataView(_Dt_ctvd)

        CyberFill.V_FillComBoxDefaul(CmbMa_VD, _Dt_VD, "Ma_VD", "Ten_VD", "")

        CyberFill.V_FillComBoxDefaul(CmbMa_bphh, _Dv_BPHH, "Ma_BPHH", "Ten_BPHH", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_CTVD, _Dv_CTVD, "Ma_CTVD", "Ten_CTVD", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CmbMa_Post, vtbttxl, "Ma_Post", "Ten_Post", "")


        If Me.Mode = "M" Then
            TxtNgay_GQ.Value = Now.Date.AddHours(Now.Hour).AddMinutes(Now.Minute)
            TxtNgay_Lap.Value = Now.Date.AddHours(Now.Hour).AddMinutes(Now.Minute)
            TxtNgay_LH.Text = "01/01/1900 00:00"
            TxtNgay_Hen1.Text = "01/01/1900 00:00"
            TxtNgay_Hen2.Text = "01/01/1900 00:00"
            TxtNgay_Hen3.Text = "01/01/1900 00:00"
            TxtNgay_Hen4.Text = "01/01/1900 00:00"
            TxtMa_Lv.Text = M_Ma_Lv
            TxtMa_Xe.Text = M_Ma_xe
            TxtSo_Ct.Text = M_so_ct
            CmbMa_Post.SelectedValue = "3"
        Else
            Dim dt As Date
            dt = M_Row.Item("Ngay_GQ")
            TxtSo_Ct.Text = M_Row.Item("So_Ct").ToString
            TxtMa_Xe.Text = M_Row.Item("Ma_Xe").ToString
            TxtNgay_GQ.Value = dt
            TxtNgay_Lap.Value = M_Row.Item("Ngay_Lap")
            ChkIs_klh.Checked = M_Row.Item("Is_KLH")
            ChkIs_lh.Checked = M_Row.Item("Is_LH")
            ChkIs_nonfir.Checked = M_Row.Item("Is_Nonfir")
            ChkIs_Dong.Checked = M_Row.Item("Is_Dong")
            ChkIs_XL.Checked = M_Row.Item("Is_XL")
            ChkIs_kaizen.Checked = M_Row.Item("Is_Kaizen")
            ChkLan1.Checked = M_Row.Item("Lan1")
            ChkLan2.Checked = M_Row.Item("Lan2")
            ChkLan3.Checked = M_Row.Item("Lan3")
            ChkIs_k1.Checked = M_Row.Item("Is_k1")
            ChkIs_k2.Checked = M_Row.Item("Is_k2")
            ChkIs_k3.Checked = M_Row.Item("Is_k3")
            ChkIs_k4.Checked = M_Row.Item("Is_k4")

            TxtNgay_LH.Value = M_Row.Item("Ngay_LH")
            TxtNgay_Hen1.Value = M_Row.Item("Ngay_Hen1")
            TxtNgay_Hen2.Value = M_Row.Item("Ngay_Hen2")
            TxtNgay_Hen3.Value = M_Row.Item("Ngay_Hen3")
            TxtNgay_Hen4.Value = M_Row.Item("Ngay_Hen4")
            TxtLy_DoKLH.Text = M_Row.Item("Ly_DoKLH").ToString
            TxtMa_Lv.Text = M_Row.Item("Ma_Lv").ToString
            TxtTen_Lv.Text = M_Row.Item("Ten_Lv").ToString
            CmbMa_VD.SelectedValue = M_Row.Item("Ma_VD").ToString.Trim
            CmbMa_CTVD.SelectedValue = M_Row.Item("Ma_CTVD").ToString.Trim
            CmbMa_bphh.SelectedValue = M_Row.Item("Ma_BPHH").ToString.Trim
            TxtMa_To.Text = M_Row.Item("Ma_To").ToString
            TxtTen_To.Text = M_Row.Item("Ten_To").ToString
            TxtNguyen_Nhan.Text = M_Row.Item("Nguyen_Nhan").ToString
            TxtND_XL.Text = M_Row.Item("ND_XL").ToString
            TxtBien_Phap.Text = M_Row.Item("Bien_Phap").ToString
            TxtLy_Do.Text = M_Row.Item("Ly_Do").ToString
            TxtDien_Giai.Text = M_Row.Item("Dien_Giai").ToString
            TxtKet_Qua.Text = M_Row.Item("Ket_Qua").ToString
            TxtND_Kaizen.Text = M_Row.Item("Nd_Kaizen").ToString
            TxtUser_ID.Text = M_Row.Item("User_Id").ToString
            CmbMa_Post.SelectedValue = M_Row.Item("Ma_Post").ToString.Trim
        End If
    End Sub
    Private Sub V_Addhander()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtNgay_GQ.KeyDown, AddressOf EnterasTab
        AddHandler TxtMa_Lv.CyberValiting, AddressOf V_Ma_Lv
        AddHandler TxtMa_Lv.CyberLeave, AddressOf L_Ma_Lv

        AddHandler TxtMa_To.CyberValiting, AddressOf V_Ma_To
        AddHandler TxtMa_To.CyberLeave, AddressOf L_Ma_to

        AddHandler CmbMa_VD.SelectedValueChanged, AddressOf V_Ma_VD
        AddHandler CmbMa_VD.SelectedValueChanged, AddressOf V_Ma_BPHH
        AddHandler CmbMa_bphh.SelectedValueChanged, AddressOf V_Ma_BPHH
    End Sub
#Region "Valid"
    Private Sub V_Ma_Lv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Lv.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Lv", "CRMDMLVKN", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Lv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Lv.Text = "" Then
            TxtTen_Lv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Lv.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Lv.Text = DrReturn.Item("Ma_Lv")
            TxtTen_Lv.Text = DrReturn.Item("Ten_Lv")
        Else
            TxtMa_Lv.Text = ""
            TxtTen_Lv.Text = ""
        End If
    End Sub
    Private Sub V_Ma_VD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_FilterMa_BPHH(CmbMa_VD, _Dv_BPHH)
    End Sub
    Private Sub V_Ma_BPHH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_FilterMa_CTVD(CmbMa_bphh, _Dv_CTVD)
    End Sub
    Private Sub V_FilterMa_BPHH(ByVal CbbVd As System.Windows.Forms.ComboBox, ByRef _Dv As DataView)
        Dim _Ma_VD As String = CmbMa_VD.SelectedValue.ToString.Trim
        Dim _Filter As String = "1=1"
        _Filter = "Ma_VD = '" + _Ma_VD + "'"
        _Dv.RowFilter = _Filter
    End Sub
    Private Sub V_FilterMa_CTVD(ByVal CbbVd As System.Windows.Forms.ComboBox, ByRef _Dv As DataView)
        Dim _Ma_BPHH As String = CmbMa_bphh.SelectedValue.ToString.Trim
        Dim _Filter As String = "1=1"
        _Filter = "Ma_BPHH = '" + _Ma_BPHH + "'"
        _Dv.RowFilter = _Filter
    End Sub
#Region "Ma_To"
    Private Sub V_Ma_To(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_To.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_to(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_To.Text = "" Then
            TxtTen_To.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_To.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_To.Text = DrReturn.Item("Ma_BP")
            TxtTen_To.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_To.Text = ""
            TxtTen_To.Text = ""
        End If
    End Sub
#End Region
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim strFiled = "", strValues As String = "", nCount As Integer = 0, nKey As Integer = 0
        Dim Dt As Date = TxtNgay_GQ.Value
        CyberSmodb.GetValueControler(Me, strFiled, strValues, "")

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_VOC_XLKN_Save", Mode & "#" & Stt_rec & "#" & Stt_rec0 & "#" & Stt_rec0VOC & "#" & strFiled & "#" & strValues & "#" & Dt.ToString("yyyyMMdd HH:mm").Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name.Trim)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Return
        End If
        If DsTmp.Tables.Count < 2 Then
            DsTmp.Dispose()
            Return
        End If
        Me.Save_OK = True
        M_Row = DsTmp.Tables(1).Rows(0)

        Back_Color = M_Row.Item("BackColor").ToString
        Ma_postVOC = M_Row.Item("Ma_PostVOC").ToString

        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#Region "Support"
    Private Sub EnterasTab(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
#End Region
End Class
