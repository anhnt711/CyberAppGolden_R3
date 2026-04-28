Public Class CRMQLLLBK1
    Dim CyberMe As New Cyber.Reports.Sys
    Dim DtGroup, Dt_TTCS As DataTable
    Dim DvGroup, Dv_TTCS As DataView
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Private Sub CRMQLLLBK1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_AddMenuShorcut()
        V_Load()
        V_GetData()
        V_Addhander()
    End Sub
#Region "Load"
    Private Sub V_Load()
        CyberMe.V_LoadLoai_BC(ChkVND, ChkNT)
        Me.is_continue = False
        Me.CyberFill.V_FillComBoxValue(Me.CBBMa_Dvcs, Me.DtUnists, "Ma_Dvcs", "Ten_Dvcs", Me.Ma_Dvcs)
        '----Set
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmLib.GetKeyValueRegistryDate(Me.sysvar, TxtM_Ngay_Ct2)

        Me.CyberSmodb.GetValueToControler(Me)
    End Sub
    Private Sub V_GetData()
        Dim M_VT_PARA As Integer = CType(Me.Para(0).Trim, Integer)
        Dim _Loai As String = Me.Para(M_VT_PARA + 2).ToString.Trim
        Dim _Ma_Loai As String = Me.Para(M_VT_PARA + 3).ToString.Trim

        Dim DsTmp As DataSet = CyberSmLib.SQLExcuteStoreProcedure(AppConn, "CP_CRM_CS01_Filter", _Loai + "#" + _Ma_Loai + "#" + Me.Ma_Dvcs + "#" + Me.User_Name)

        If DsTmp.Tables.Count >= 1 Then DtGroup = DsTmp.Tables(0).Copy
        If DsTmp.Tables.Count >= 4 Then Dt_TTCS = DsTmp.Tables(3).Copy        

        If Not Dt_TTCS Is Nothing Then If Dt_TTCS.Rows.Count = 0 Then Dt_TTCS = Nothing       

        If Not DtGroup Is Nothing Then DvGroup = New DataView(DtGroup)
        If Not Dt_TTCS Is Nothing Then Dv_TTCS = New DataView(Dt_TTCS)

        If Not DtGroup Is Nothing Then
            CyberFill.V_FillComBoxDefaul(CmbMa_TH, DtGroup, "Ma", "Ten", "Default")
            CmbMa_TH.Visible = True
            LabMa_TH.Visible = True
        Else
            CmbMa_TH.Visible = False
            LabMa_TH.Visible = False
        End If
        If Not Dt_TTCS Is Nothing Then
            CyberFill.V_FillComBoxDefaul(CmbMa_TTCS, Dt_TTCS, "Ma_TTCS", "Ten_TTCS", "Ngam_Dinh")
            CmbMa_TTCS.Visible = True
            LabMa_TTCS.Visible = True
        Else
            CmbMa_TTCS.Visible = False
            LabMa_TTCS.Visible = False
        End If

        'Ma_Loai
        TxtMa_Loai.Text = _Ma_Loai.Trim
        If TxtMa_Loai.Text.Trim = "" Then TxtTen_Loai.Text = "" Else TxtTen_Loai.Text = CyberSmodb.SQLGetvalue(AppConn, "CrmTen_Loai", "CrmDmLoai", "CrmMa_Loai = N'" + TxtMa_Loai.Text.Trim + "'", CyberSmLib)
    End Sub   
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exit
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit        

        'Ma_Loai
        AddHandler TxtMa_Loai.CyberValiting, AddressOf V_Ma_Loai
        AddHandler TxtMa_Loai.CyberLeave, AddressOf L_Ma_Loai
        'Ma_Ngay
        AddHandler TxtMa_Ngay.CyberValiting, AddressOf V_Ma_Ngay
        AddHandler TxtMa_Ngay.CyberLeave, AddressOf L_Ma_Ngay
        'Ma_CS
        AddHandler TxtMa_Cs.CyberValiting, AddressOf V_Ma_Cs
        AddHandler TxtMa_Cs.CyberLeave, AddressOf L_Ma_Cs
        'Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        'Ma_Kx
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_Kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_Kx
        'Ma_Mau
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        'Ma_ChienDich
        AddHandler TxtMa_ChienDich.CyberValiting, AddressOf V_Ma_ChienDich
        AddHandler TxtMa_ChienDich.CyberLeave, AddressOf L_Ma_ChienDich
    End Sub
#End Region
#Region "Valid"
#Region "Valid --- Ma_Loai"
    Private Sub V_Ma_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Loai.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "CrmMa_Loai", "CrmDmLoai", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Loai(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Loai.Text = "" Then
            TxtTen_Loai.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Loai.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Loai.Text = DrReturn.Item("CrmMa_Loai")
            TxtTen_Loai.Text = DrReturn.Item("CrmTen_Loai")
        Else
            TxtMa_Loai.Text = ""
            TxtTen_Loai.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Ngay"
    Private Sub V_Ma_Ngay(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Ngay.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Ngay", "CrmLoaiNgay", "1=1", "CrmMa_Loai = '" & TxtMa_Loai.Text.Trim & "'")
    End Sub
    Private Sub L_Ma_Ngay(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Ngay.Text = "" Then
            TxtTen_Ngay.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Ngay.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Ngay.Text = DrReturn.Item("Ma_Ngay")
            TxtTen_Ngay.Text = DrReturn.Item("Ten_Ngay")
        Else
            TxtMa_Ngay.Text = ""
            TxtTen_Ngay.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Cs"
    Private Sub V_Ma_Cs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Cs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Cs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Cs.Text = "" Then
            TxtTen_Cs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Cs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Cs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Cs.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Hs.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
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
#Region "Valid --- Ma_Kx"
    Private Sub V_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kx.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Kx", "Dmkx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
#Region "Valid --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Mau.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Mau.Text = "" Then
            TxtTen_Mau.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            TxtTen_Mau.Text = DrReturn.Item("Ten_Mau")
        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_ChienDich"
    Private Sub V_Ma_ChienDich(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_ChienDich.V_LookUp(Me.LAN, Me.Para, Me.sysvar, AppConn, DsLookup, "Ma_ChienDich", "DmChienDich", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_ChienDich(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_ChienDich.Text = "" Then
            TxtTen_ChienDich.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_ChienDich.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_ChienDich.Text = DrReturn.Item("Ma_ChienDich")
            TxtTen_ChienDich.Text = DrReturn.Item("Ten_ChienDich")
        Else
            TxtMa_ChienDich.Text = ""
            TxtTen_ChienDich.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Button"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '-----------------------------------------------------------------------------
        Dim _Ngay_Ct1 As Date = TxtM_Ngay_Ct1.Value
        Dim _Ngay_Ct2 As Date = TxtM_Ngay_Ct2.Value               
        Dim _Ma_TH As String = CyberSmodb.GetvalueFromCombox(CmbMa_TH)
        Dim _Ma_TTCS As String = CyberSmodb.GetvalueFromCombox(CmbMa_TTCS)

        Dim M_Ma_Dvcs_Filter As String = Me.CBBMa_Dvcs.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = _Ma_TH & "#" & _Ngay_Ct1.ToString("yyyyMMdd") & "#" & _Ngay_Ct2.ToString("yyyyMMdd")
        M_strParameterStore = M_strParameterStore & "#" & _Ma_TTCS & "#" & TxtMa_Loai.Text.Trim & "#" & TxtMa_Ngay.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Cs.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kx.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Mau.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_ChienDich.Text
        M_strParameterStore = M_strParameterStore & "#" & CyberMe.GetLoai_BC(ChkVND, ChkNT)
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs_Filter
        M_strParameterStore = M_strParameterStore & "#" & Me.User_Name.Trim

        '-----------------------------------------------------------------------------
        Me.is_continue = True
        Dim M_strFieldValue As String = ""
        Dim M_strFieldName As String = ""
        CyberSmodb.GetValueControler(Me, M_strFieldName, M_strFieldValue, "")
        Me.Tag_Field = M_strFieldName
        Me.Tag_Value = M_strFieldValue
        CyberSmLib.SaveRegistry(Me, Me.sysvar)
        Me.Tag = M_strParameterStore
        Me.Close()
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_AddMenuShorcut()
        Dim mnItems = New ContextMenu
        Dim mnItemsNhan As New MenuItem(IIf(Me.LAN = "V", "Chấp nhận", "OK"), AddressOf V_Nhan, Keys.Control + Keys.Enter)
        Dim mnItemsExit As New MenuItem(IIf(Me.LAN = "V", "Quay ra", "Exit"), AddressOf V_Exit, Keys.Escape)
        mnItems.MenuItems.Add(mnItemsNhan)
        mnItems.MenuItems.Add(mnItemsExit)
        Me.ContextMenu = mnItems
    End Sub
#End Region
End Class
