Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors

Public Class FrmTiendo_Xem_KH
#Region "Get or Set Property----------------------"
    Public Property Stt_rec() As String
        Get
            Return M_Stt_rec
        End Get
        Set(ByVal value As String)
            M_Stt_rec = value
        End Set
    End Property
    Public Property Loai_SC() As String
        Get
            Return M_Loai_SC
        End Get
        Set(ByVal value As String)
            M_Loai_SC = value
        End Set
    End Property
    Public Property Ma_xe() As String
        Get
            Return M_Ma_Xe
        End Get
        Set(ByVal value As String)
            M_Ma_Xe = value
        End Set
    End Property
    Public Property TG() As String
        Get
            Return M_TG
        End Get
        Set(ByVal value As String)
            M_TG = value
        End Set
    End Property
    Public Property Muc_SDS() As String
        Get
            Return M_Muc_SDS
        End Get
        Set(ByVal value As String)
            M_Muc_SDS = value
        End Set
    End Property
    Public Property Ngay_Ct() As Date
        Get
            Return M_Ngay_Ct1
        End Get
        Set(ByVal value As Date)
            M_Ngay_Ct1 = value
        End Set
    End Property
    Public Property Ngay_Ct1() As Date
        Get
            Return M_Ngay_Ct1
        End Get
        Set(ByVal value As Date)
            M_Ngay_Ct1 = value
        End Set
    End Property
    Public Property Ngay_Ct2() As Date
        Get
            Return M_Ngay_Ct2
        End Get
        Set(ByVal value As Date)
            M_Ngay_Ct2 = value
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
    Dim M_Ma_Xe As String = ""
    Dim M_Loai_SC As String = ""
    Dim M_TG As String = ""
    Dim M_Muc_SDS As String = ""
    Dim M_Ngay_Ct1 As Date
    Dim M_Ngay_Ct2 As Date
    Dim M_Ma_Loai As String = "03"
    Dim M_Ma_Loai_SC As Integer = "0"

    Dim DsLookup As New DataSet
    Dim Dt_Master, Dt_head As New DataTable
    Dim Dv_Master, Dv_head As New DataView

    Dim EditMasterTag As New Cyber.Fill.CyberColumnGridView
    Dim M_Master_Return, Dt_Post As DataTable

    Dim DrReturn As DataRow
    Dim DtMa_Loai As DataTable
    Dim DtMa_LoaiSC As DataTable


#End Region
    Private Sub FrmTiendo_Xem_KH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_GetColumn()
        V_AddHander()
        MasterGRV.OptionsBehavior.Editable = False
        Dim FixCol As Integer = 4
        If FixCol < MasterGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If

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
        AddHandler CbbMa_Loai.SelectedValueChanged, AddressOf V_Ma_Loai_SelectedValueChanged
        AddHandler CbbMa_Loai_SC.SelectedValueChanged, AddressOf V_Ma_Loai_SC_SelectedValueChanged
        AddHandler TxtMa_Xe.TextChanged, AddressOf V_Ma_Xe
        AddHandler CmbbXuatExcelx.Click, AddressOf V_XuatExcelx
        'AddHandler TxtM_Ngay_ct1.KeyDown, AddressOf EnterasTab
    End Sub
#Region "Load - "
    Private Sub V_EditVoucherRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberFill.V_EditVoucher(M_LAN, Me.Para, Me.Sysvar, AppConn, MasterGRV)
    End Sub
    Private Sub V_Load()
        TxtM_Ngay_Ct1.Value = M_Ngay_Ct1
        TxtM_Ngay_Ct2.Value = M_Ngay_Ct2

        '-----Loại BC
        Dim _DsMa_Loai As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'Ma_Loai' AND Acti = N'1'#ID")
        DtMa_Loai = _DsMa_Loai.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_Loai, DtMa_Loai, "Nhom", "Ten_nhom")

        '-----Loại SC
        Dim _DsMa_LoaiSC As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "SysNhapXuat#CP_NAME= N'Loai_SC' AND Acti = N'1'#ID")
        DtMa_LoaiSC = _DsMa_LoaiSC.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(Me.CbbMa_Loai_SC, DtMa_LoaiSC, "Nhom", "Ten_nhom", Loai_SC)
        CbbMa_Loai_SC.SelectedValue = Loai_SC
        V_LoadDatabase("1")
    End Sub
    Private Sub V_LoadDatabase(ByVal Status As String)
        Dim DsDongSon As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RO_CVDV_BK1SC", Loai_SC & "#" & M_Ma_Loai & "#" & M_Ngay_Ct1.ToString("yyyyMMdd") & "#" & M_Ngay_Ct2.ToString("yyyyMMdd") & "#####" & TxtMa_Xe.Text.Trim & "###" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsDongSon.Tables.Count < 2 Then
            DsDongSon.Dispose()
            Exit Sub
        End If
        For i = 0 To DsDongSon.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsDongSon.Tables(i))
        Next
        If Status = "1" Then
            Dt_Master = DsDongSon.Tables(0)
            Dt_head = DsDongSon.Tables(2)
            Dv_Master = New DataView(Dt_Master)
            Dv_head = New DataView(Dt_head)
            V_FillDataToGridview(MasterGRV, M_LAN, Dv_head, Dv_Master)
        Else
            Dt_Master.Clear()
            CyberSmodb.SQLTbToTb(DsDongSon.Tables(0), Dt_Master)
            Dt_Master.AcceptChanges()
        End If
    End Sub
    Private Sub V_FillDataToGridview(ByRef GRV As DevExpress.XtraGrid.Views.Grid.GridView, ByVal _M_lan As String, ByVal DvHeader As DataView, ByVal DvData As DataView)
        CyberFill.V_FillReports(GRV, _M_lan, DvHeader, DvData)
        GRV.GridControl.DataSource = DvData
    End Sub
#End Region
#Region "Tinh toan"
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Ngay_Ct1 = TxtM_Ngay_Ct1.Value
        M_Ngay_Ct2 = TxtM_Ngay_Ct2.Value
        V_LoadDatabase("1")
    End Sub
#Region "Grid"
    Private Sub gridView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles MasterGRV.DoubleClick
        '    Dim ea As DevExpress.Utils.DXMouseEventArgs = TryCast(e, DevExpress.Utils.DXMouseEventArgs)
        '    Dim view As GridView = TryCast(sender, GridView)
        '    Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)
        '    If info.InRow OrElse info.InRowCell Then
        '        Dim colName As String = info.Column.FieldName
        '        Dim rowName As String = info.RowHandle
        '        M_TG = Dt_Master.Rows(rowName).Item("TG").ToString
        '        M_Ngay_Ct1 = Dt_Master.Rows(rowName).Item("Ngay_Ct")

        '        Dim DsTgUp As DataSet
        '        DsTgUp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_RoGioDongSonSave", M_Ngay_Ct1.ToString("yyyyMMdd") & "#" & M_TG.Trim & "#" & M_Stt_rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        '        If Not CyberSupport.V_MsgChk(DsTgUp.Tables(0), Me.Sysvar, M_LAN) Then
        '            DsTgUp.Dispose()
        '            Exit Sub
        '        End If

        '        Dt_Master.Rows(rowName).BeginEdit()
        '        Dt_Master.Rows(rowName).Item(colName) = M_Ma_Xe
        '        Dt_Master.Rows(rowName).EndEdit()
        '        Dt_Master.AcceptChanges()
        '    End If
        '    Me.Save_OK = True
        '    Me.Close()
    End Sub
#End Region
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabase("1")
    End Sub
    Private Sub V_Ma_Loai_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        M_Ma_Loai = Me.CbbMa_Loai.SelectedValue
        V_LoadDatabase("1")
    End Sub

    Private Sub V_Ma_Loai_SC_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Loai_SC = Me.CbbMa_Loai_SC.SelectedValue
        V_LoadDatabase("1")
    End Sub

    Private Sub V_XuatExcelx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        ' Dim _Tu_Ngay As String = "TỪ THÁNG " & Strings.Right("00" & Me.Thang1.ToString.Trim, 2) & " ĐẾN THÁNG " & Strings.Right("00" & Me.Thang2.ToString.Trim, 2) & " năm " & Me.Nam.ToString.Trim
        Dim _Tu_Ngay As String = "TỪ NGÀY " & Me.Key_Sub3.ToString & " ĐẾN NGÀY" & Me.Key_Sub4.ToString.Trim
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXlsx(AppConn, Me.MasterGRV, _Dv_Title, Dv_Master, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name, "C:\CYBER_DsXE.xlsx")
    End Sub
End Class

