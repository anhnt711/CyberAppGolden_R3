Public Class FaTgNgF3
    Public Property Loai_TG() As String
        Get
            Loai_TG = M_Loai_TG
        End Get
        Set(ByVal Value As String)
            M_Loai_TG = Value
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
    Public Property Drv() As DataRowView
        Get
            Drv = M_Drv
        End Get
        Set(ByVal Value As DataRowView)
            M_Drv = Value
        End Set
    End Property
    Public Property DrvDetail() As DataRowView
        Get
            DrvDetail = M_DrvDetail
        End Get
        Set(ByVal Value As DataRowView)
            M_DrvDetail = Value
        End Set
    End Property
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim M_Mode As String
    Dim M_Drv, M_DrvDetail As DataRowView
    Dim _TbDc As DataTable
    Dim M_Loai_TG As String = "T"
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub FaTgNgF3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtNgay_Tang.Value = Now.Date
        V_Load()
        V_AddHandler()
        Me.Text = IIf(Me.Lan = "V", Me.M_Bar, Me.M_Bar2)
        If M_Loai_TG.ToString.Trim.ToUpper = "T" Then
            LabMa_Tang.Enabled = True
            TxtMa_Tang.Enabled = True
            LabNgay_Tang.Enabled = True
            TxtNgay_Tang.Enabled = True


            Labma_Giam.Enabled = False
            Txtma_GIam.Enabled = False
            LabNgay_Giam.Enabled = False
            TxtNgay_Giam.Enabled = False

            Txtma_GIam.Text = ""
            TxtTen_Giam.Text = ""
            Me.Text = "Khai bao tăng nguyên giá tài sản" & If(M_Mode = "S", ": Sửa khai báo tăng nguyên giá", ": Tạo mới khai báo tăng nguyên giá")
        Else
            LabMa_Tang.Enabled = False
            TxtMa_Tang.Enabled = False
            LabNgay_Tang.Enabled = False
            TxtNgay_Tang.Enabled = False

            Labma_Giam.Enabled = True
            Txtma_GIam.Enabled = True
            LabNgay_Giam.Enabled = True
            TxtNgay_Giam.Enabled = True

            Me.Text = "Khai báo giảm nguyên giá tài sản" & If(M_Mode = "S", ": Sửa khai báo giảm nguyên giá", ": Tạo mới khai báo giảm nguyên giá")
        End If
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Private Sub V_Load()
        Dim _Ma_TS As String = Drv.Item("Ma_TS").ToString.Trim
        Dim _Stt0 As String = Drv.Item("Stt0").ToString.Trim
        Dim _Ma_Nv As String = Drv.Item("Ma_NV").ToString.Trim


        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_FaTgNGloc", "0" & "#" & _Ma_Nv & "#" & _Stt0 & "#" & _Ma_TS & "#" & "#" & "#" & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        _TbDc = DsTmp.Tables(0).Copy
        CyberSmodb.SetValueTObj(Me, _TbDc.Rows(0))
        '-------------------------------------------------------------------
        TxtTen_ts.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TS", "DmTS", "(Ma_TS= N'" + Txtma_Ts.Text.Trim + "')", CyberSmlib)
        TxtTen_Tang.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tg_Ts", "DmTgTs", "(Ma_Tg_TS= N'" + TxtMa_Tang.Text.Trim + "')", CyberSmlib)
        TxtTen_Giam.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Tg_Ts", "DmTgTs", "(Ma_Tg_TS= N'" + Txtma_GIam.Text.Trim + "')", CyberSmlib)

        TxtTen_NV.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_NV", "DmNV", "(Ma_NV= N'" + TxtMa_NV.Text.Trim + "')", CyberSmlib)
        TxtTen_Tk_No.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TK", "DmTk", "(TK= N'" + TxtTk_No.Text.Trim + "')", CyberSmlib)
        TxtTen_Tk_Co.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TK", "DmTk", "(TK= N'" + TxtTk_Co.Text.Trim + "')", CyberSmlib)

        TxtTen_Vv.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_VV", "DmVV", "(Ma_VV= N'" + TxtMa_Vv.Text.Trim + "')", CyberSmlib)
        TxtTen_HD.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HD", "DmHD", "(Ma_HD= N'" + TxtMa_HD.Text.Trim + "')", CyberSmlib)
        TxtTen_Phi.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Phi", "DmPhi", "(Ma_Phi= N'" + TxtMa_phi.Text.Trim + "')", CyberSmlib)
        TxtTen_Sp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Sp", "DmSp", "(Ma_Sp= N'" + TxtMa_Sp.Text.Trim + "')", CyberSmlib)
        TxtTen_ku.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Ku", "DmKu", "(Ma_Ku= N'" + Txtma_Ku.Text.Trim + "')", CyberSmlib)

        TxtTen_TTLN.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTLN", "DmTTLN", "(Ma_TTLN= N'" + TxtMa_TTLN.Text.Trim + "')", CyberSmlib)
        TxtTen_TTCP.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TTCP", "DmTTCP", "(Ma_TTCP= N'" + TxtMa_TTCP.Text.Trim + "')", CyberSmlib)
        TxtTen_Bp.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_BP", "DmBP", "(Ma_BP= N'" + TxtMa_Bp.Text.Trim + "')", CyberSmlib)
        TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "DmHS", "(Ma_HS= N'" + TxtMa_Hs.Text.Trim + "')", CyberSmlib)
        TxtTen_CD.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_CD", "DmCD", "(Ma_CD= N'" + TxtMa_CD.Text.Trim + "')", CyberSmlib)

        TxtTen_Td1.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD1", "DmTD1", "(Ma_TD1= N'" + TxtMa_Td1.Text.Trim + "')", CyberSmlib)
        TxtTen_Td2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD2", "DmTD2", "(Ma_TD2= N'" + TxtMa_Td2.Text.Trim + "')", CyberSmlib)
        TxtTen_Td3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD3", "DmTD3", "(Ma_TD3= N'" + TxtMa_Td3.Text.Trim + "')", CyberSmlib)
        TxtTen_Td4.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD4", "DmTD4", "(Ma_TD4= N'" + TxtMa_Td4.Text.Trim + "')", CyberSmlib)
        TxtTen_Td5.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_TD5", "DmTD5", "(Ma_TD5= N'" + TxtMa_Td5.Text.Trim + "')", CyberSmlib)
    End Sub
    Private Sub V_AddHandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        '--NV
        'RemoveHandler TxtMa_NV.CyberValiting, AddressOf V_Ma_Nv
        'RemoveHandler TxtMa_NV.CyberLeave, AddressOf L_Ma_Nv
        AddHandler TxtMa_NV.CyberValiting, AddressOf V_Ma_Nv
        AddHandler TxtMa_NV.CyberLeave, AddressOf L_Ma_Nv

        '--Tang
        'RemoveHandler TxtMa_Tang.CyberValiting, AddressOf V_Ma_Tang
        'RemoveHandler TxtMa_Tang.CyberLeave, AddressOf L_Ma_Tang
        AddHandler TxtMa_Tang.CyberValiting, AddressOf V_Ma_Tang
        AddHandler TxtMa_Tang.CyberLeave, AddressOf L_Ma_Tang

        '--Tang
        'RemoveHandler Txtma_GIam.CyberValiting, AddressOf V_Ma_Giam
        'RemoveHandler Txtma_GIam.CyberLeave, AddressOf L_Ma_Giam
        AddHandler Txtma_GIam.CyberValiting, AddressOf V_Ma_Giam
        AddHandler Txtma_GIam.CyberLeave, AddressOf L_Ma_Giam


        '--Tk_NO
        'RemoveHandler TxtTk_No.CyberValiting, AddressOf V_Tk_NO
        'RemoveHandler TxtTk_No.CyberLeave, AddressOf L_Tk_NO
        AddHandler TxtTk_No.CyberValiting, AddressOf V_Tk_NO
        AddHandler TxtTk_No.CyberLeave, AddressOf L_Tk_NO
        '--Tk_Co
        'RemoveHandler TxtTk_Co.CyberValiting, AddressOf V_Tk_Co
        'RemoveHandler TxtTk_Co.CyberLeave, AddressOf L_Tk_Co
        AddHandler TxtTk_Co.CyberValiting, AddressOf V_Tk_Co
        AddHandler TxtTk_Co.CyberLeave, AddressOf L_Tk_Co
        '--Vv
        'RemoveHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        'RemoveHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        AddHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_Vv
        AddHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_Vv
        '--HD
        'RemoveHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        'RemoveHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD
        '--Phi
        'RemoveHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_Phi
        'RemoveHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_Phi
        AddHandler TxtMa_phi.CyberValiting, AddressOf V_Ma_Phi
        AddHandler TxtMa_phi.CyberLeave, AddressOf L_Ma_Phi
        '--Sp
        'RemoveHandler TxtMa_Sp.CyberValiting, AddressOf V_Ma_Sp
        'RemoveHandler TxtMa_Sp.CyberLeave, AddressOf L_Ma_Sp
        AddHandler TxtMa_Sp.CyberValiting, AddressOf V_Ma_Sp
        AddHandler TxtMa_Sp.CyberLeave, AddressOf L_Ma_Sp
        '--Ku
        'RemoveHandler Txtma_Ku.CyberValiting, AddressOf V_Ma_Ku
        'RemoveHandler Txtma_Ku.CyberLeave, AddressOf L_Ma_Ku
        AddHandler Txtma_Ku.CyberValiting, AddressOf V_Ma_Ku
        AddHandler Txtma_Ku.CyberLeave, AddressOf L_Ma_Ku

        '--TTLN
        'RemoveHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        'RemoveHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberValiting, AddressOf V_Ma_TTLN
        AddHandler TxtMa_TTLN.CyberLeave, AddressOf L_Ma_TTLN

        '--TTCP
        'RemoveHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        'RemoveHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberValiting, AddressOf V_Ma_TTCP
        AddHandler TxtMa_TTCP.CyberLeave, AddressOf L_Ma_TTCP


        '--Bp
        'RemoveHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_Bp
        'RemoveHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_Bp
        AddHandler TxtMa_Bp.CyberValiting, AddressOf V_Ma_Bp
        AddHandler TxtMa_Bp.CyberLeave, AddressOf L_Ma_Bp

        '--Hs
        'RemoveHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        'RemoveHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs

        '--CD
        'RemoveHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        'RemoveHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD
        AddHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        AddHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD

        '--TD1
        'RemoveHandler TxtMa_Td1.CyberValiting, AddressOf V_Ma_TD1
        'RemoveHandler TxtMa_Td1.CyberLeave, AddressOf L_Ma_TD1
        AddHandler TxtMa_Td1.CyberValiting, AddressOf V_Ma_TD1
        AddHandler TxtMa_Td1.CyberLeave, AddressOf L_Ma_TD1
        '--TD2
        'RemoveHandler TxtMa_Td2.CyberValiting, AddressOf V_Ma_TD2
        'RemoveHandler TxtMa_Td2.CyberLeave, AddressOf L_Ma_TD2
        AddHandler TxtMa_Td2.CyberValiting, AddressOf V_Ma_TD2
        AddHandler TxtMa_Td2.CyberLeave, AddressOf L_Ma_TD2
        '--TD3
        'RemoveHandler TxtMa_Td3.CyberValiting, AddressOf V_Ma_TD3
        'RemoveHandler TxtMa_Td3.CyberLeave, AddressOf L_Ma_TD3
        AddHandler TxtMa_Td3.CyberValiting, AddressOf V_Ma_TD3
        AddHandler TxtMa_Td3.CyberLeave, AddressOf L_Ma_TD3
        '--TD4
        'RemoveHandler TxtMa_Td4.CyberValiting, AddressOf V_Ma_TD4
        'RemoveHandler TxtMa_Td4.CyberLeave, AddressOf L_Ma_TD4
        AddHandler TxtMa_Td4.CyberValiting, AddressOf V_Ma_TD4
        AddHandler TxtMa_Td4.CyberLeave, AddressOf L_Ma_TD4
        '--TD5
        'RemoveHandler TxtMa_Td5.CyberValiting, AddressOf V_Ma_TD5
        'RemoveHandler TxtMa_Td5.CyberLeave, AddressOf L_Ma_TD5
        AddHandler TxtMa_Td5.CyberValiting, AddressOf V_Ma_TD5
        AddHandler TxtMa_Td5.CyberLeave, AddressOf L_Ma_TD5

        '------------
        RemoveHandler TxtNguyen_Gia.Leave, AddressOf V_Tinh_Toan
        RemoveHandler TxtGt_Da_KH.Leave, AddressOf V_Tinh_Toan
        RemoveHandler TxtGt_CL.Leave, AddressOf V_Tinh_Toan
        RemoveHandler TxtGt_kh_Ky.Leave, AddressOf V_Tinh_Toan
        RemoveHandler TxtThang_kh.Leave, AddressOf V_Tinh_Toan

        AddHandler TxtNguyen_Gia.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtGt_Da_KH.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtGt_CL.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtGt_kh_Ky.Leave, AddressOf V_Tinh_Toan
        AddHandler TxtThang_kh.Leave, AddressOf V_Tinh_Toan

    End Sub
    Private Sub V_Tinh_Toan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtGt_CL.Double = TxtNguyen_Gia.Double - TxtGt_Da_KH.Double
        If TxtThang_kh.Double <> 0 And TxtGt_kh_Ky.Double = 0 Then TxtGt_kh_Ky.Double = CyberSupport.V_Round(TxtNguyen_Gia.Double / TxtThang_kh.Double, 0)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim _StrDelete As String = ""
        Dim _Mode As String = Me.Mode.Trim.ToUpper
        Dim _StrField As String = ""
        Dim _StrValue As String = ""
        CyberSmodb.GetValueControler(Me, _StrField, _StrValue, "ten_Ts,Ten_NV,Ten_Tang,Ten_Giam,Ten_Vv,Ten_HD,Ten_Phi,Ten_SP,Ten_Ku,Ten_TTLN,Ten_TTCP,Ten_Bp,Ten_HS,Ten_CD,Ten_TD1,Ten_TD2,Ten_TD3,Ten_TD4,Ten_TD5")
        Dim DsUpdate As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_FATGNGUPDATE", Loai_TG.Trim + "#" + _Mode + "#" + _StrField + "#" + _StrValue + "#" + M_Ma_Dvcs + "#" + M_User_Name)

        If DsUpdate.Tables(0).Rows(0).Item("Status").ToString.Trim = "N" Then
            If DsUpdate.Tables(0).Rows(0).Item("Msg").ToString.Trim = "Y" Then MsgBox(DsUpdate.Tables(0).Rows(0).Item("Note"), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_Cyber_Ver"))
            Exit Sub
        End If
        Dim _DvReturn As DataView
        _DvReturn = New DataView(DsUpdate.Tables(1).Copy)

        Drv = _DvReturn.Item(0)
        Me.Save_OK = True
        Me.Tag = ""
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
#Region "Vali --- Ma_Nv"
    Private Sub V_Ma_Nv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_NV.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Nv", "DmNv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Nv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_NV.Text = "" Then
            TxtTen_NV.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_NV.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_NV.Text = DrReturn.Item("Ma_Nv")
            TxtTen_NV.Text = DrReturn.Item("Ten_Nv")
        Else
            TxtMa_NV.Text = ""
            TxtTen_NV.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Tang"
    Private Sub V_Ma_Tang(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Tang.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Tg_TS", "DmTgTs", "1=1", "Loai_Tg_Ts = 'T'")
    End Sub
    Private Sub L_Ma_Tang(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Tang.Text = "" Then
            TxtTen_Tang.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Tang.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Tang.Text = DrReturn.Item("Ma_Tg_TS")
            TxtTen_Tang.Text = DrReturn.Item("Ten_Tg_Ts")
        Else
            TxtMa_Tang.Text = ""
            TxtTen_Tang.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Giam"
    Private Sub V_Ma_Giam(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_GIam.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Tg_TS", "DmTgTs", "1=1", "Loai_Tg_Ts = 'G'")
    End Sub
    Private Sub L_Ma_Giam(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Txtma_GIam.Text = "" Then
            TxtTen_Giam.Text = ""
            Exit Sub
        End If
        DrReturn = Txtma_GIam.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            Txtma_GIam.Text = DrReturn.Item("Ma_Tg_TS")
            TxtTen_Giam.Text = DrReturn.Item("Ten_Tg_Ts")
        Else
            TxtTen_Giam.Text = ""
            TxtTen_Giam.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Vv"
    Private Sub V_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vv.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Vv", "DmVv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vv(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Vv.Text = "" Then
            TxtTen_Vv.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Vv.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Vv.Text = DrReturn.Item("Ma_Vv")
            TxtTen_Vv.Text = DrReturn.Item("Ten_Vv")
        Else
            TxtMa_Vv.Text = ""
            TxtTen_Vv.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_No"
    Private Sub V_Tk_NO(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_No.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Tk0", "DmTk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_NO(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtTk_No.Text = "" Then
            TxtTen_Tk_No.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_No.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtTk_No.Text = DrReturn.Item("Tk0")
            TxtTen_Tk_No.Text = DrReturn.Item("Ten_Tk0")
        Else
            TxtTk_No.Text = ""
            TxtTen_Tk_No.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk_Co"
    Private Sub V_Tk_Co(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtTk_Co.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Tk0", "DmTk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Co(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtTk_Co.Text = "" Then
            TxtTen_Tk_Co.Text = ""
            Exit Sub
        End If
        DrReturn = TxtTk_Co.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtTk_Co.Text = DrReturn.Item("Tk0")
            TxtTen_Tk_Co.Text = DrReturn.Item("Ten_Tk0")
        Else
            TxtTk_Co.Text = ""
            TxtTen_Tk_Co.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_HD"
    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_HD.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_HD", "DmHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_HD.Text = "" Then
            TxtTen_HD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_HD.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn.Item("Ma_HD")
            TxtTen_HD.Text = DrReturn.Item("Ten_HD")
        Else
            TxtMa_HD.Text = ""
            TxtTen_HD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Phi"
    Private Sub V_Ma_Phi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_phi.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Phi", "DmPhi", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Phi(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_phi.Text = "" Then
            TxtTen_Phi.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_phi.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_phi.Text = DrReturn.Item("Ma_Phi")
            TxtTen_Phi.Text = DrReturn.Item("Ten_Phi")
        Else
            TxtMa_phi.Text = ""
            TxtTen_Phi.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Sp"
    Private Sub V_Ma_Sp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Sp.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Sp", "DmSp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Sp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Sp.Text = "" Then
            TxtTen_Sp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Sp.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Sp.Text = DrReturn.Item("Ma_Sp")
            TxtTen_Sp.Text = DrReturn.Item("Ten_Sp")
        Else
            TxtMa_Sp.Text = ""
            TxtTen_Sp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Ku"
    Private Sub V_Ma_Ku(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        Txtma_Ku.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Ku", "DmKu", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Ku(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Txtma_Ku.Text = "" Then
            TxtTen_ku.Text = ""
            Exit Sub
        End If
        DrReturn = Txtma_Ku.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            Txtma_Ku.Text = DrReturn.Item("Ma_Ku")
            TxtTen_ku.Text = DrReturn.Item("Ten_Ku")
        Else
            Txtma_Ku.Text = ""
            TxtTen_ku.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTLN"
    Private Sub V_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTLN.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TTLN.Text = "" Then
            TxtTen_TTLN.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTLN.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TTLN.Text = DrReturn.Item("Ma_TTLN")
            TxtTen_TTLN.Text = DrReturn.Item("Ten_TTLN")
        Else
            TxtMa_TTLN.Text = ""
            TxtTen_TTLN.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TTCP"
    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_TTCP.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_TTCP.Text = "" Then
            TxtTen_TTCP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_TTCP.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_TTCP.Text = DrReturn.Item("Ma_TTCP")
            TxtTen_TTCP.Text = DrReturn.Item("Ten_TTCP")
        Else
            TxtMa_TTCP.Text = ""
            TxtTen_TTCP.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Bp"
    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Bp.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bp(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Bp.Text = "" Then
            TxtTen_Bp.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Bp.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Bp.Text = DrReturn.Item("Ma_Bp")
            TxtTen_Bp.Text = DrReturn.Item("Ten_Bp")
        Else
            TxtMa_Bp.Text = ""
            TxtTen_Bp.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_CD"
    Private Sub V_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_CD.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_CD", "DmCD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CD(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_CD.Text = "" Then
            TxtTen_CD.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_CD.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_CD.Text = DrReturn.Item("Ma_CD")
            TxtTen_CD.Text = DrReturn.Item("Ten_CD")
        Else
            TxtMa_CD.Text = ""
            TxtTen_CD.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD1"
    Private Sub V_Ma_TD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Td1.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.AppConn, DsLookup, "Ma_TD1", "DmTD1", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD1(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td1.Text = "" Then
            TxtTen_Td1.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td1.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td1.Text = DrReturn.Item("Ma_TD1")
            TxtTen_Td1.Text = DrReturn.Item("Ten_TD1")
        Else
            TxtMa_Td1.Text = ""
            TxtTen_Td1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD2"
    Private Sub V_Ma_TD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Td2.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.AppConn, DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td2.Text = "" Then
            TxtTen_Td2.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td2.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td2.Text = DrReturn.Item("Ma_TD2")
            TxtTen_Td2.Text = DrReturn.Item("Ten_TD2")
        Else
            TxtMa_Td2.Text = ""
            TxtTen_Td2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD3"
    Private Sub V_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Td3.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.AppConn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td3.Text = "" Then
            TxtTen_Td3.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td3.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td3.Text = DrReturn.Item("Ma_TD3")
            TxtTen_Td3.Text = DrReturn.Item("Ten_TD3")
        Else
            TxtMa_Td3.Text = ""
            TxtTen_Td3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD4"
    Private Sub V_Ma_TD4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Td4.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.AppConn, DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td4.Text = "" Then
            TxtTen_Td4.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td4.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td4.Text = DrReturn.Item("Ma_TD4")
            TxtTen_Td4.Text = DrReturn.Item("Ten_TD4")
        Else
            TxtMa_Td4.Text = ""
            TxtTen_Td4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_TD5"
    Private Sub V_Ma_TD5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Td5.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, Me.AppConn, DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If TxtMa_Td5.Text = "" Then
            TxtTen_Td5.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Td5.GetRowsSelectData(False)
        If Not DrReturn Is Nothing Then
            TxtMa_Td5.Text = DrReturn.Item("Ma_TD5")
            TxtTen_Td5.Text = DrReturn.Item("Ten_TD5")
        Else
            TxtMa_Td5.Text = ""
            TxtTen_Td5.Text = ""
        End If
    End Sub
#End Region

End Class
