Public Class FrmDLHenFilter
    Dim M_Kieu_Xem As String = "HEN"
    Public Property Kieu_Xem As String
        Get
            Kieu_Xem = M_Kieu_Xem
        End Get
        Set(ByVal Value As String)
            M_Kieu_Xem = Value
        End Set
    End Property
    Dim M_Loai_SC As String = "1"
    Public Property Loai_SC() As String
        Get
            Loai_SC = M_Loai_SC
        End Get
        Set(ByVal Value As String)
            M_Loai_SC = Value
        End Set
    End Property
    Dim M_Ma_Xe As String = ""
    Public Property Ma_Xe() As String
        Get
            Ma_Xe = M_Ma_Xe
        End Get
        Set(ByVal Value As String)
            M_Ma_Xe = Value
        End Set
    End Property
    Dim M_Ma_Hs As String = ""
    Public Property Ma_Hs() As String
        Get
            Ma_Hs = M_Ma_Hs
        End Get
        Set(ByVal Value As String)
            M_Ma_Hs = Value
        End Set
    End Property
    Dim M_Ngay_Ct1 As Date = Now.Date
    Public Property Ngay_CT1() As Date
        Get
            Ngay_CT1 = M_Ngay_Ct1
        End Get
        Set(ByVal Value As Date)
            M_Ngay_Ct1 = Value
        End Set
    End Property
    Dim M_Ngay_Ct2 As Date = Now.Date
    Public Property Ngay_CT2() As Date
        Get
            Ngay_CT2 = M_Ngay_Ct2
        End Get
        Set(ByVal Value As Date)
            M_Ngay_Ct1 = Value
        End Set
    End Property
    Private Sub FrmDLHenFilter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TxtNgay_Ct1.Value = Now.Date
        TxtNgay_Ct2.Value = Now.Date


        Try
            If M_Ngay_Ct1.ToString("yyyyMMdd").Trim = "19000101" Then M_Ngay_Ct1 = Now.Date
            If M_Ngay_Ct2.ToString("yyyyMMdd").Trim = "19000101" Then M_Ngay_Ct2 = Now.Date

            TxtNgay_Ct1.Value = M_Ngay_Ct1
            TxtNgay_Ct2.Value = M_Ngay_Ct2

        Catch ex As Exception
        End Try
        TxtMa_Xe.Text = M_Ma_Xe
        TxtMa_Hs.Text = M_Ma_Hs
        If Not TxtMa_Hs.Text.Trim = "" Then TxtTen_HS.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_HS", "Dmhs", "Ma_Hs = N'" + TxtMa_Hs.Text + "'", CyberSmlib)

        Me.Save_OK = False
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        Me.Text = "Loc Điều kiện hẹn"
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()

    End Sub
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet

    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Hs.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_HS", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        If TxtMa_Hs.Text = "" Then
            TxtTen_HS.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_HS")
            TxtTen_HS.Text = DrReturn.Item("Ten_HS")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_HS.Text = ""
        End If

    End Sub

    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim _Ngay1 As Date = TxtNgay_Ct1.Value
        Dim _Ngay2 As Date = TxtNgay_Ct2.Value
        Dim M_strParameterStore As String = M_Kieu_Xem + "#" + M_Loai_SC '--Kieu_Xem + Loai_SC
        M_strParameterStore = M_strParameterStore + "#" + "" 'Stt_Rec
        M_strParameterStore = M_strParameterStore + "#" + TxtMa_Xe.Text
        M_strParameterStore = M_strParameterStore + "#" + TxtMa_Hs.Text
        M_strParameterStore = M_strParameterStore + "#" + _Ngay1.ToString("yyyyMMdd") + "#" + _Ngay2.ToString("yyyyMMdd") + "#" + "" + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
