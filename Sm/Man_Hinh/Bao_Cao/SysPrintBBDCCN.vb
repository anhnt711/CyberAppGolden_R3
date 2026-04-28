Imports System.Data.SqlClient
Public Class SysPrintBBDCCN
#Region "Get or Set Property----------------------"
    Dim M_Du_Ck As Decimal = 0
    Dim M_Du_Ck_NT As Decimal = 0
    Dim M_Ngay_Ct1 As Date
    Dim M_Ngay_Ct2 As Date
    Public Property Du_Ck() As Decimal
        Get
            Du_Ck = M_Du_Ck
        End Get
        Set(ByVal Value As Decimal)
            M_Du_Ck = Value
        End Set
    End Property
    Public Property Du_Ck_NT() As Decimal
        Get
            Du_Ck_NT = M_Du_Ck_NT
        End Get
        Set(ByVal Value As Decimal)
            M_Du_Ck_NT = Value
        End Set
    End Property
    Public Property Ngay_Ct1() As Date
        Get
            Ngay_Ct1 = M_Ngay_Ct1
        End Get
        Set(ByVal Value As Date)
            M_Ngay_Ct1 = Value
        End Set
    End Property
    Public Property Ngay_Ct2() As Date
        Get
            Ngay_Ct2 = M_Ngay_Ct2
        End Get
        Set(ByVal Value As Date)
            M_Ngay_Ct2 = Value
        End Set
    End Property
    Public Property Save_OK() As Boolean
        Get
            Save_OK = M_Save_OK
        End Get
        Set(ByVal Value As Boolean)
            M_Save_OK = Value
        End Set
    End Property
    Public Property SysVar() As Collection
        Get
            Return oSysVar
        End Get
        Set(ByVal value As Collection)
            oSysVar = value
        End Set
    End Property
    Public Property Lan() As String
        Get
            Lan = M_LAN
        End Get
        Set(ByVal Value As String)
            M_LAN = Value
        End Set
    End Property
    Public Property Preview() As Boolean
        Get
            Preview = M_Preview
        End Get
        Set(ByVal Value As Boolean)
            M_Preview = Value
        End Set
    End Property

    Public Property Loai_Tien() As Boolean
        Get
            Loai_Tien = M_Loai_Tien
        End Get
        Set(ByVal Value As Boolean)
            M_Loai_Tien = Value
        End Set
    End Property
    Public Property Ngon_ngu() As Boolean
        Get
            Ngon_ngu = M_Ngon_ngu
        End Get
        Set(ByVal Value As Boolean)
            M_Ngon_ngu = Value
        End Set
    End Property
    Public Property Tk() As String
        Get
            Tk = M_Tk
        End Get
        Set(ByVal Value As String)
            M_Tk = Value
        End Set
    End Property
    Public Property Ma_kh() As String
        Get
            Ma_kh = M_Ma_kh
        End Get
        Set(ByVal Value As String)
            M_Ma_kh = Value
        End Set
    End Property
    Public Property Para() As String()
        Get
            Para = M_PARA
        End Get
        Set(ByVal Value As String())
            M_PARA = Value
        End Set
    End Property
    Public Property _Loai_IN() As String
        Get
            _Loai_IN = M_Loai_In
        End Get
        Set(ByVal Value As String)
            M_Loai_In = Value
        End Set
    End Property
    Public Property Dt_Return() As DataTable
        Get
            Dt_Return = M_Dt_Return
        End Get
        Set(ByVal Value As DataTable)
            M_Dt_Return = Value
        End Set
    End Property
    Public Property Ds_Return() As DataSet
        Get
            Ds_Return = M_Ds_Return
        End Get
        Set(ByVal Value As DataSet)
            M_Ds_Return = Value
        End Set
    End Property
#End Region

    Dim M_Ds_Return As DataSet
    Dim M_Dt_Return As DataTable

    Dim M_Loai_Tien As Boolean = False '--- True la VND, False la Ngoai te
    Dim M_Ngon_ngu As Boolean = False '--- True la tieng viet, False la tieng anh
    Dim M_Preview As Boolean = False '--- True la tieng viet, False la tieng anh
    Dim M_Loai_In As String = "1"

    Dim oSysVar As Collection
    Dim M_LAN As String = "V"
    Dim M_Save_OK As Boolean = False
    Dim M_Ma_kh As String = ""
    Dim M_Tk As String = ""
    Dim Cybersmlib As New Cyber.SmLib.Sys
    Dim CyberSupport As New Cyber.Support.Sys
    Dim CyberSmodb As New Cyber.Smodb.Sys
    Dim M_PARA As String()
    Dim AppConn As SqlConnection
    Dim M_Ma_Dvcs As String = ""
    Dim M_User_Name As String = ""
    Private Sub SysPrintBBDCCN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AppConn = Cybersmlib.GetConn()
        Me.Save_OK = False
        V_Load()
        AddHandler CmdEditReport.Click, AddressOf V_EditReport
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtCancel.Click, AddressOf V_Huy
        Me.Tag = "0"
        Dim M_is_Admin As Boolean = CType(M_PARA(8), Boolean)
        If M_is_Admin Then CmdEditReport.Enabled = True Else CmdEditReport.Enabled = False
    End Sub
    Private Sub V_Load()
        CyberSupport.Translaste(Me, M_LAN)
        Rad11.Checked = Not M_Preview
        Rad12.Checked = M_Preview
        Rad21.Checked = M_Loai_Tien
        Rad22.Checked = Not M_Loai_Tien
        Rad31.Checked = M_Ngon_ngu
        Rad32.Checked = Not M_Ngon_ngu
        Dim M_VT_PARA As Integer = CType(M_PARA(0).Trim, Integer)
        M_User_Name = M_PARA(6).Trim
        M_Ma_Dvcs = M_PARA(14).Trim
        Dim DsTmp As DataSet = Cybersmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARSO1_BBDCCNLoad", M_Tk & "#" & M_Ma_kh & "#" & M_Ngay_Ct1.ToString("yyyyMMdd") & "#" & M_Ngay_Ct2.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsTmp.Tables.Count <= 0 Then
            DsTmp.Dispose()
            Cybersmlib.FlushMemory()
        End If
        If DsTmp.Tables(0).Rows.Count <= 0 Then
            DsTmp.Dispose()
            Cybersmlib.FlushMemory()
        End If

        TxtHom_Nay.Value = Now.Date
        If DsTmp.Tables(0).Columns.Contains("Dai_Dien1") Then TxtDai_Dien1.Text = DsTmp.Tables(0).Rows(0).Item("Dai_Dien1").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dai_Dien2") Then TxtDai_Dien2.Text = DsTmp.Tables(0).Rows(0).Item("Dai_Dien2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dai_Dien3") Then TxtDai_Dien3.Text = DsTmp.Tables(0).Rows(0).Item("Dai_Dien3").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Dai_Dien4") Then TxtDai_Dien4.Text = DsTmp.Tables(0).Rows(0).Item("Dai_Dien4").ToString.Trim

        If DsTmp.Tables(0).Columns.Contains("Chuc_Vu1") Then TxtChuc_Vu1.Text = DsTmp.Tables(0).Rows(0).Item("Chuc_Vu1").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Chuc_Vu2") Then TxtChuc_Vu2.Text = DsTmp.Tables(0).Rows(0).Item("Chuc_Vu2").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Chuc_Vu3") Then TxtChuc_Vu3.Text = DsTmp.Tables(0).Rows(0).Item("Chuc_Vu3").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Chuc_Vu4") Then TxtChuc_Vu4.Text = DsTmp.Tables(0).Rows(0).Item("Chuc_Vu4").ToString.Trim
        If DsTmp.Tables(0).Columns.Contains("Tai") Then TxtTai.Text = DsTmp.Tables(0).Rows(0).Item("Tai").ToString.Trim

    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Save_OK = True
        'If Rad11.Checked Then Me.Preview = False Else Me.Preview = True
        'If Rad21.Checked Then Me.Loai_Tien = True Else Me.Loai_Tien = False
        'If Rad31.Checked Then Me.Ngon_ngu = True Else Me.Ngon_ngu = False
        'Dim strField As String = ""
        'Dim strValue As String = ""
        'CyberSmodb.GetValueControler(Me, strField, strValue)
        'Dim Dt As DataTable
        'Dim Dstmp As DataSet = Cybersmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARSO1_BBDCCNSAVE", M_Du_Ck.ToString.Trim.Replace(" ", "").Replace(",", ".") & "#" & _
        '                                                          M_Du_Ck_NT.ToString.Trim.Replace(" ", "").Replace(",", ".") & "#" & _
        '                                                          M_Ngay_Ct2.ToString("yyyyMMdd") & "#" & _
        '                                                          M_Ma_kh & "#" & strField & "#" & strValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        'Me.Dt_Return = Dstmp.Tables(0).Copy
        'M_Ds_Return = Dstmp.Copy
        'Me.Ds_Return = M_Ds_Return
        'Dstmp.Dispose()
        'Cybersmlib.FlushMemory()
        'If Rad12.Checked Then Me.Preview = True Else Me.Preview = False
        'Me.Close()
        V_Nhan(If(Rad12.Checked, "1", "2"))
    End Sub
    Private Sub V_Nhan(ByVal _Loai As String)
        Me.Save_OK = True
        If Rad11.Checked Then Me.Preview = False Else Me.Preview = True
        If Rad21.Checked Then Me.Loai_Tien = True Else Me.Loai_Tien = False
        If Rad31.Checked Then Me.Ngon_ngu = True Else Me.Ngon_ngu = False
        Dim strField As String = ""
        Dim strValue As String = ""
        CyberSmodb.GetValueControler(Me, strField, strValue)
        Dim Dt As DataTable
      
        Dim Dstmp As DataSet = Cybersmlib.SQLExcuteStoreProcedure(AppConn, "CP_ARSO1_BBDCCNSAVE", M_Du_Ck.ToString.Trim.Replace(" ", "").Replace(",", ".") & "#" & _
                                                                  M_Du_Ck_NT.ToString.Trim.Replace(" ", "").Replace(",", ".") & "#" & _
                                                                  M_Tk & "#" &
                                                                  M_Ma_kh & "#" &
                                                                  M_Ngay_Ct1.ToString("yyyyMMdd") & "#" & _
                                                                  M_Ngay_Ct2.ToString("yyyyMMdd") & "#" & _
                                                                  strField & "#" & strValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Me.Dt_Return = Dstmp.Tables(0).Copy
        M_Ds_Return = Dstmp.Copy
        Me.Ds_Return = M_Ds_Return
        Dstmp.Dispose()
        Cybersmlib.FlushMemorySave()
        If Rad12.Checked Then Me.Preview = True Else Me.Preview = False
        Me._Loai_IN = _Loai.Trim.ToString
        Me.Close()
    End Sub
    Private Sub V_EditReport(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Nhan("3")
    End Sub
    Private Sub V_Huy(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Me.Close()
    End Sub
End Class