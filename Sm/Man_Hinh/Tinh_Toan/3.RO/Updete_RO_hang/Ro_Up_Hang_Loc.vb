Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Drawing
Public Class Ro_Up_Hang_Loc
    Public Property Add_Title() As String
        Get
            Add_Title = M_Add_Title
        End Get
        Set(ByVal Value As String)
            M_Add_Title = Value
        End Set
    End Property

    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim M_Add_Title As String = ""
    Dim Dt_Loai, _Dt_Loai_TMSS, _Dt_post1, _Dt_post2 As DataTable
    Dim tbkx As New DataTable
    Public vtbkx As DataView
    Dim _Dt_Bp_Hs As DataTable
    Dim M_Ma_BP As String = ""
    Dim M_Ten_BP As String = ""
    Dim M_Ma_CT As String = "HDK"
    Dim M_Ma_GD As String = "S"
    Dim M_Ma_Post1 As String = "2"
    Dim M_Ma_Post2 As String = "9"

    Private Sub Ro_Up_Hang_Loc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_ct2.Value = Now.Date
        TxtNgay_Ct1.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtNgay_Ct1)
        TxtNgay_ct2.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtNgay_ct2)

        V_Load()

        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        AddHandler ButtOK.Click, AddressOf V_Nhan
        If M_Add_Title <> "" Then Me.Text = M_Add_Title & Me.Text

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()

        TxtMa_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "ma_Hs", "UserInfo", "[User_Name] = N'" + M_User_Name.Trim + "'", CyberSmlib)
        TxtTen_Hs.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "DmHs", "[Ma_Hs] = N'" + TxtTen_Hs.Text + "'", CyberSmlib)
        If TxtTen_Hs.Text.Trim = "" Then TxtMa_Hs.Text = ""

        ''Dim _DsPost As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetMaPostReports", M_Ma_CT & "##")
        '_Dt_post1 = _DsPost.Tables(0).Copy
        '_Dt_post2 = _DsPost.Tables(1).Copy
        '_DsPost.Dispose()

        _Dt_post1 = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmPost", "Ma_Post", "Ma_Post >='2' AND ma_Ct = 'HDK'", CyberSmlib)
        _Dt_post2 = _Dt_post1.Copy

        CyberFill.V_FillComBoxValue(Me.CbbMa_Post1, _Dt_post1, "ma_post", "Ten_post", M_Ma_Post1)
        CyberFill.V_FillComBoxValue(Me.CbbMa_post2, _Dt_post2, "ma_post", "Ten_post", M_Ma_Post2)

        Dim M_VT_PARA As Integer = CType(Para(0).Trim, Integer)
        Dim _DsTmp As New DataSet
    End Sub
#Region "Vali --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Hs.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
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
#Region "Vali --- Ma_kx"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kx.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_kx", "Dmkx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kx.Text = "" Then
            Txtten_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_kx")
            Txtten_Kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_Kx.Text = ""
            Txtten_Kx.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Mau"
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Mau.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
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

    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim _Ngay_Ct1 As Date = TxtNgay_Ct1.Value
        Dim _Ngay_Ct2 As Date = TxtNgay_ct2.Value

        Dim _Ma_Post1_Filter As String = Me.CbbMa_Post1.SelectedValue.ToString.Trim
        Dim _Ma_Post2_Filter As String = Me.CbbMa_post2.SelectedValue.ToString.Trim
        Dim _Ma_LoaiBC_Filter As String
        _Ma_LoaiBC_Filter = IIf(ChkIs_Loai.Checked, "1", "0")
        Dim M_strParameterStore As String = _Ngay_Ct1.ToString("yyyyMMdd") & "#" & _Ngay_Ct2.ToString("yyyyMMdd")
        M_strParameterStore = M_strParameterStore & "#" & TxtSo_RO.Text
        M_strParameterStore = M_strParameterStore & "#" & ""
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Xe.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Post1_Filter
        M_strParameterStore = M_strParameterStore & "#" & _Ma_Post2_Filter
        M_strParameterStore = M_strParameterStore & "#" & _Ma_LoaiBC_Filter
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name

        Me.Tag = "1" & "#" & M_strParameterStore
        CyberSmodb.SetValueTObj(Me, Me.DrReturn)
        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
