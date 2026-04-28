Public Class CRMTraCuuLHen
#Region "Get or Set Property----------------------"
    Dim M_Ma_Get As String
    Public Property Stt_rec() As String
        Get
            Return M_Stt_rec
        End Get
        Set(ByVal value As String)
            M_Stt_rec = value
        End Set
    End Property
    Public Property Ma_Ct() As String
        Get
            Return M_Ma_Ct
        End Get
        Set(ByVal value As String)
            M_Ma_Ct = value
        End Set
    End Property
    Public Property Mode() As String
        Get
            Return M_Mode
        End Get
        Set(ByVal value As String)
            M_Mode = value
        End Set
    End Property
    Public Property Ma_Get() As String
        Get
            Return M_Ma_Get
        End Get
        Set(ByVal value As String)
            M_Ma_Get = value
        End Set
    End Property
    Public Property Ma_GD() As String
        Get
            Return M_Ma_GD
        End Get
        Set(ByVal value As String)
            M_Ma_GD = value
        End Set
    End Property
    Public Property Master_Return() As DataTable
        Get
            Master_Return = M_Master_Return
        End Get
        Set(ByVal Value As DataTable)
            M_Master_Return = Value
        End Set
    End Property
    Public Property _Ds_LoolUp() As DataSet
        Get
            _Ds_LoolUp = DsLookup
        End Get
        Set(ByVal Value As DataSet)
            DsLookup = Value
        End Set
    End Property
#End Region
#Region "Bien----------------------"
    Dim M_Stt_rec As String = ""
    Dim M_Ma_Ct As String = ""
    Dim M_Mode As String = "M"
    Dim M_Ma_KH As String = ""
    Dim M_Ma_GD As String = "1"

    Dim DsLookup As New DataSet
    Dim Dt_Master, Dt_head, Dt_MasterBH, Dt_headBH As New DataTable
    Dim Dv_Master, Dv_head, Dv_MasterBH, Dv_headBH As New DataView

    Dim EditMasterTag As New Cyber.Fill.CyberColumnGridView
    Dim M_Master_Return, Dt_Post As DataTable

    Dim DrReturn As DataRow

    Dim CyberWork As New Sys

#End Region
    Private Sub FrmXemTT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_GetColumn()
        V_AddHander()

        Dim FixCol As Integer = 4
        If FixCol < MasterGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        TxtNgay_CT1.Value = DateTime.Now()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_GetColumn()
        EditMasterTag.GetColumn(MasterGRV, "tag")
    End Sub
    Private Sub V_AddHander()
        'V_Menu(DetailGRVRo_Master, AddressOf V_EditVoucherRo)
        CyberFill.V_GridviewRowCellStyle(MasterGRV)

        AddHandler ButtOK.Click, AddressOf V_Nhan

        AddHandler CbbLoc.Click, AddressOf V_Loc

    End Sub

#Region "Load - "
    Private Sub V_EditVoucherRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberFill.V_EditVoucher(M_LAN, Me.Para, Me.Sysvar, AppConn, MasterGRV)
    End Sub
    Private Sub V_Load()
        'V_LoadDatabase("1")
        Dim DtTTCP As New DataTable
        DtTTCP.Columns.Add("Ma_TTCP_Nhan")
        DtTTCP.Columns.Add("Ten_TTCP_Nhan")
        DtTTCP.Columns.Add("Ten_TTCP_Nhan2")
        DtTTCP.Columns.Add("Default")
        DtTTCP.Rows.Add("", "Tất cả", "All", "0")
        DtTTCP.Rows.Add("01", "Yên Lãng", "Yen Lang", "1")
        DtTTCP.Rows.Add("02", "Xưởng 3 (HĐ)", "Xuong 3", "0")
        DtTTCP.Rows.Add("04", "Xưởng 4 (TC)", "Xuong 4", "0")
        DtTTCP.Rows.Add("06", "Xưởng 2 (HĐ)", "Xuong 2", "0")
        DtTTCP.AcceptChanges()
        CyberFill.V_FillComBoxDefaul(CbbMa_TTCP_Nhan, DtTTCP, "Ma_TTCP_Nhan", "Ten_TTCP_Nhan", "Default")

    End Sub
    Private Sub V_Loc()
        Dim _NgayCt1 As Date = TxtNgay_CT1.Value
        Dim DsTT_Xe As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_CrmTraCuuDhen", TxtMa_Xe.Text.Trim + "#" + _NgayCt1.ToString("yyyyMMdd") + "#" & M_Ma_Dvcs & "#" & M_User_Name + "#" + CyberWork.V_GetvalueCombox(CbbMa_TTCP_Nhan))
        For i = 0 To DsTT_Xe.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTT_Xe.Tables(i))
        Next
        Dt_Master = DsTT_Xe.Tables(1)
        Dt_head = DsTT_Xe.Tables(2)
        Dv_Master = New DataView(Dt_Master)
        Dv_head = New DataView(Dt_head)
        V_FillDataToGridview(MasterGRV, M_LAN, Dv_head, Dv_Master)
    End Sub
    Private Sub V_FillDataToGridview(ByRef GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal DvHeader As DataView, ByVal DvData As DataView)
        CyberFill.V_FillReports(GRV, _M_lan, DvHeader, DvData)
        GRV.GridControl.DataSource = DvData
    End Sub
#End Region
#Region "Tinh toan"
#End Region
    Private Sub V_LocRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'V_LoadDatabase("0")
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore

        Dim _Master_Return As DataTable = Dt_Master.Clone
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex

        If iRow >= 0 Then
            _Master_Return.ImportRow(Dt_Master.Rows(iRow))
        End If

        Me.Master_Return = _Master_Return
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
