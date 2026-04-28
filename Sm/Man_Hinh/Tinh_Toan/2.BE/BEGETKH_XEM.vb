Imports System.Drawing
Imports System.Windows.Forms

Public Class BEGETKH_XEM
    Public Property Loai_KH() As String
        Get
            Loai_KH = M_Loai_KH
        End Get
        Set(ByVal Value As String)
            M_Loai_KH = Value
        End Set
    End Property

    Public Property strLoc() As String
        Get
            strLoc = M_strLoc
        End Get
        Set(ByVal Value As String)
            M_strLoc = Value
        End Set
    End Property
    Public Property Cp_Loc() As String
        Get
            Cp_Loc = M_Cp_Loc
        End Get
        Set(ByVal Value As String)
            M_Cp_Loc = Value
        End Set
    End Property
    Public Property Cp_Update() As String
        Get
            Cp_Update = M_Cp_Update
        End Get
        Set(ByVal Value As String)
            M_Cp_Update = Value
        End Set
    End Property
    Public Property DsDataLoc() As DataSet
        Get
            DsDataLoc = M_DsDataLoc
        End Get
        Set(ByVal Value As DataSet)
            M_DsDataLoc = Value
        End Set
    End Property
    Public Property Ma_Kx() As String
        Get
            Ma_Kx = M_MA_KX
        End Get
        Set(ByVal Value As String)
            M_MA_KX = Value
        End Set
    End Property
    Public Property Ma_Mau() As String
        Get
            Ma_Mau = M_MA_Mau
        End Get
        Set(ByVal Value As String)
            M_MA_Mau = Value
        End Set
    End Property
    Public Property Ma_MauNT() As String
        Get
            Ma_MauNT = M_MA_MauNT
        End Get
        Set(ByVal Value As String)
            M_MA_MauNT = Value
        End Set
    End Property

    Dim M_Loai_KH As String = "1"
    Dim ProccessList As New Collection
    Dim M_strLoc, M_Cp_Update, M_Cp_Loc As String
    Dim M_MA_KX As String = ""
    Dim M_MA_Mau As String = ""
    Dim M_MA_MauNT As String = ""

    Dim M_DsDataLoc As DataSet
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim Dt_head, Dt_Master, Dt_Dmct, Dt_Filter1, Dt_Filter0 As DataTable
    Dim Dv_head, Dv_Master, Dv_Dmct, DV_Filter1, DV_Filter0 As DataView
    Dim DrDmct As DataRow
    Dim CyberColor As New Cyber.Color.Sys

    Dim EditSo_Khung As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_KH As New Cyber.Fill.CyberColumnGridView
    Dim EditTen_KH As New Cyber.Fill.CyberColumnGridView

    Dim EditTen_KX As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_KX As New Cyber.Fill.CyberColumnGridView

    Dim M_Bar As String
    Dim M_Bar2 As String
    Dim _Tab_Boolean As Boolean = False
    Dim Dt_DmKx As DataTable
    Dim Dt_DmMau As DataTable
    'Dim Dt_DmMauNT As DataTable
    Dim EditT01, EditT02, EditT03, EditT04, EditT05, EditT06, EditT07, EditT08, EditT09, EditT10, EditT11, EditT12, EditT_T As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditH01, EditH02, EditH03, EditH04, EditH05, EditH06, EditH07, EditH08, EditH09, EditH10, EditH11, EditH12, EditT_H As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditM01, EditM02, EditM03, EditM04, EditM05, EditM06, EditM07, EditM08, EditM09, EditM10, EditM11, EditM12, EditT_M As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Dim EditV01, EditV02, EditV03, EditV04, EditV05, EditV06, EditV07, EditV08, EditV09, EditV10, EditV11, EditV12, EditT_V As New Cyber.Fill.CyberColumnGridView 'Cyber.SmLists.EditLookUp
    Private Sub BEBOOKING_XEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        M_Bar = Me.Para(11).Trim
        M_Bar2 = Me.Para(12).Trim

        Me.Save_OK = False
        'Me.Tag = ""
        V_Load()
        V_FilldatatoGridview()
        V_GetColumn()
        V_AddHandler_Master()
        V_AddHandler_Detail()
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)

        Dt_DmKx = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmKx", "Ma_Kx", "Is_Kd = '1'", CyberSmlib)
        'Dt_DmKx = CyberSmodb.OpenTableKey(AppConn, Nothing, "DmKx", "Ma_Kx", "Is_Kd = N'1' AND Ma_Dvcs = N'" + M_Ma_Dvcs + "'", CyberSmlib)

        Dt_DmMau = CyberSmodb.OpenTable(AppConn, Nothing, "DmMauxe", "1", CyberSmlib)
        'Dt_DmMauNT = CyberSmodb.OpenTable(AppConn, Nothing, "DmMauxeNT", "1", CyberSmlib)
        MasterGRV.OptionsView.ShowViewCaption = False

        If M_Loai_KH = "1" Then
            Me.Text = If(M_LAN = "V", "Chỉ tiêu xe: Chi tiết theo màu", "Vehicle targets For color")
        Else
            Me.Text = If(M_LAN = "V", "Chỉ tiêu xe: Tổng hợp theo kiểu xe", "Vehicle targets By car type")
        End If
    End Sub
#Region "Load data"
    Private Sub V_Load()

        Dt_Master = DsDataLoc.Tables(0).Copy
        Dt_Dmct = DsDataLoc.Tables(1).Copy
        Dt_head = DsDataLoc.Tables(2).Copy

        Dv_Master = New DataView(Dt_Master)
        Dv_Dmct = New DataView(Dt_Dmct)
        Dv_head = New DataView(Dt_head)
        DrDmct = Dt_Dmct.Rows(0)

        If Dv_Master.Table.Columns.Contains("Tag") Then _Tab_Boolean = True


        Dt_Filter0 = New DataTable
        Dt_Filter1 = New DataTable

        Dt_Filter1.Columns.Add("Field_Name")
        Dt_Filter1.Columns.Add("Field_Type")

        Dt_Filter0.Columns.Add("Ma")
        Dt_Filter0.Columns.Add("Ten")
        Dt_Filter0.Columns.Add("Default")


        Dim _Field_Name As String = ""
        Dim _Field_Head As String = ""
        Dim _Field_Type As String = ""
        Dt_Filter0.Rows.Add("", "Tất cả", "0")

        For i As Integer = 1 To Dt_head.Rows.Count - 1
            _Field_Name = Dt_head.Rows(i).Item("Field_Name").ToString
            _Field_Head = Dt_head.Rows(i).Item("Field_Head1").ToString
            _Field_Type = Dt_head.Rows(i).Item("Field_Type").ToString.ToUpper.Trim

            If _Field_Type = "N" Or _Field_Type = "D" Or _Field_Type = "B" Then Continue For
            If Not CyberSmodb.isExistField(Dt_Master, _Field_Name) Then Continue For
            If _Field_Name.ToString.Trim.ToUpper = "TAG" Then Continue For
            Dt_Filter0.Rows.Add(_Field_Name, _Field_Head, "0")
            Dt_Filter1.Rows.Add(_Field_Name, _Field_Type)
        Next
        CyberFill.V_FillComBoxValue(ComFilter, Dt_Filter0, "Ma", "Ten", "")
        DV_Filter0 = New DataView(Dt_Filter0)
        DV_Filter1 = New DataView(Dt_Filter1)
        CyberFill.V_GridviewRowCellStyle(MasterGRV)
    End Sub
    Private Sub V_GetColumn()
        EditMa_KX.GetColumn(MasterGRV, "Ma_kx")
        EditTen_KX.GetColumn(MasterGRV, "TEN_KX")
        EditSo_Khung.GetColumn(MasterGRV, "So_Khung")

        EditT01.GetColumn(MasterGRV, "T01")
        EditT02.GetColumn(MasterGRV, "T02")
        EditT03.GetColumn(MasterGRV, "T03")
        EditT04.GetColumn(MasterGRV, "T04")
        EditT05.GetColumn(MasterGRV, "T05")
        EditT06.GetColumn(MasterGRV, "T06")
        EditT07.GetColumn(MasterGRV, "T07")
        EditT08.GetColumn(MasterGRV, "T08")
        EditT09.GetColumn(MasterGRV, "T09")
        EditT10.GetColumn(MasterGRV, "T10")
        EditT11.GetColumn(MasterGRV, "T11")
        EditT12.GetColumn(MasterGRV, "T12")
        EditT_T.GetColumn(MasterGRV, "T_T")

        EditH01.GetColumn(MasterGRV, "H01")
        EditH02.GetColumn(MasterGRV, "H02")
        EditH03.GetColumn(MasterGRV, "H03")
        EditH04.GetColumn(MasterGRV, "H04")
        EditH05.GetColumn(MasterGRV, "H05")
        EditH06.GetColumn(MasterGRV, "H06")
        EditH07.GetColumn(MasterGRV, "H07")
        EditH08.GetColumn(MasterGRV, "H08")
        EditH09.GetColumn(MasterGRV, "H09")
        EditH10.GetColumn(MasterGRV, "H10")
        EditH11.GetColumn(MasterGRV, "H11")
        EditH12.GetColumn(MasterGRV, "H12")
        EditT_H.GetColumn(MasterGRV, "T_H")

        EditM01.GetColumn(MasterGRV, "M01")
        EditM02.GetColumn(MasterGRV, "M02")
        EditM03.GetColumn(MasterGRV, "M03")
        EditM04.GetColumn(MasterGRV, "M04")
        EditM05.GetColumn(MasterGRV, "M05")
        EditM06.GetColumn(MasterGRV, "M06")
        EditM07.GetColumn(MasterGRV, "M07")
        EditM08.GetColumn(MasterGRV, "M08")
        EditM09.GetColumn(MasterGRV, "M09")
        EditM10.GetColumn(MasterGRV, "M10")
        EditM11.GetColumn(MasterGRV, "M11")
        EditM12.GetColumn(MasterGRV, "M12")
        EditT_M.GetColumn(MasterGRV, "T_M")

        EditV01.GetColumn(MasterGRV, "V01")
        EditV02.GetColumn(MasterGRV, "V02")
        EditV03.GetColumn(MasterGRV, "V03")
        EditV04.GetColumn(MasterGRV, "V04")
        EditV05.GetColumn(MasterGRV, "V05")
        EditV06.GetColumn(MasterGRV, "V06")
        EditV07.GetColumn(MasterGRV, "V07")
        EditV08.GetColumn(MasterGRV, "V08")
        EditV09.GetColumn(MasterGRV, "V09")
        EditV10.GetColumn(MasterGRV, "V10")
        EditV11.GetColumn(MasterGRV, "V11")
        EditV12.GetColumn(MasterGRV, "V12")
        EditT_V.GetColumn(MasterGRV, "T_V")

    End Sub
    Private Sub V_FilldatatoGridview()
        'CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_head, Dv_Master)



        Master.DataSource = Dv_Master
        MasterGRV.GridControl = Me.Master

        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False

        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen

        CyberFill.V_FillVoucher(MasterGRV, M_LAN, Dv_head, Dv_Master, DrDmct)

        'Dim FixCol As Integer = -1
        'Try
        '    FixCol = Dt_Dmct.Rows(0).Item("ColFrozen_Master")
        'Catch ex As Exception
        'End Try

        'If FixCol < MasterGRV.Columns.Count And FixCol > 0 Then
        '    For iCol = 0 To FixCol
        '        MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
        '    Next
        'End If

    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, Cp_Loc, "0#" & strLoc)
        CyberSmodb.SetNotNullTable(Dstmp.Tables(0))
        Dim nCount As Integer = Dt_Master.Rows.Count - 1
        For i = nCount To 0 Step -1
            Dt_Master.Rows(i).Delete()
        Next
        Dt_Master.AcceptChanges()
        For i = 0 To Dstmp.Tables(0).Rows.Count - 1
            Dt_Master.ImportRow(Dstmp.Tables(0).Rows(i))
        Next
        Dt_Master.AcceptChanges()
    End Sub
#End Region
#Region "V_AddHandler"
    Private Sub V_AddHandler_Master()
        RemoveHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        AddHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        '--------------------------------------------------------------------------
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exit
        AddHandler CmbbRefresh.Click, AddressOf V_Refresh
        AddHandler CmbbPrint.Click, AddressOf V_Print
        AddHandler CmbbInBien_Ban.Click, AddressOf V_IN_Bien_Ban
        AddHandler CmbbXuatExcel.Click, AddressOf V_XuatExcel
        AddHandler CmbbSelectAll.Click, AddressOf V_SelectAll
        AddHandler CmbbUnSelectAll.Click, AddressOf V_RemoveAll
        AddHandler CmbbSms.Click, AddressOf V_SMS
        AddHandler TxtSearch.TextChanged, AddressOf V_Search
        '--------------------------------------------------------------------------
        If Not EditT01.Column Is Nothing Then AddHandler EditT01.EditColumn.Leave, AddressOf L_Tinh_Toan_T
        If Not EditT02.Column Is Nothing Then AddHandler EditT02.EditColumn.Leave, AddressOf L_Tinh_Toan_T
        If Not EditT03.Column Is Nothing Then AddHandler EditT03.EditColumn.Leave, AddressOf L_Tinh_Toan_T
        If Not EditT04.Column Is Nothing Then AddHandler EditT04.EditColumn.Leave, AddressOf L_Tinh_Toan_T
        If Not EditT05.Column Is Nothing Then AddHandler EditT05.EditColumn.Leave, AddressOf L_Tinh_Toan_T
        If Not EditT06.Column Is Nothing Then AddHandler EditT06.EditColumn.Leave, AddressOf L_Tinh_Toan_T
        If Not EditT07.Column Is Nothing Then AddHandler EditT07.EditColumn.Leave, AddressOf L_Tinh_Toan_T
        If Not EditT08.Column Is Nothing Then AddHandler EditT08.EditColumn.Leave, AddressOf L_Tinh_Toan_T
        If Not EditT09.Column Is Nothing Then AddHandler EditT09.EditColumn.Leave, AddressOf L_Tinh_Toan_T
        If Not EditT10.Column Is Nothing Then AddHandler EditT10.EditColumn.Leave, AddressOf L_Tinh_Toan_T
        If Not EditT11.Column Is Nothing Then AddHandler EditT11.EditColumn.Leave, AddressOf L_Tinh_Toan_T
        If Not EditT12.Column Is Nothing Then AddHandler EditT12.EditColumn.Leave, AddressOf L_Tinh_Toan_T
        If Not EditT_T.Column Is Nothing Then AddHandler EditT_T.EditColumn.Leave, AddressOf L_Tinh_Toan_T

        If Not EditH01.Column Is Nothing Then AddHandler EditH01.EditColumn.Leave, AddressOf L_Tinh_Toan_H
        If Not EditH02.Column Is Nothing Then AddHandler EditH02.EditColumn.Leave, AddressOf L_Tinh_Toan_H
        If Not EditH03.Column Is Nothing Then AddHandler EditH03.EditColumn.Leave, AddressOf L_Tinh_Toan_H
        If Not EditH04.Column Is Nothing Then AddHandler EditH04.EditColumn.Leave, AddressOf L_Tinh_Toan_H
        If Not EditH05.Column Is Nothing Then AddHandler EditH05.EditColumn.Leave, AddressOf L_Tinh_Toan_H
        If Not EditH06.Column Is Nothing Then AddHandler EditH06.EditColumn.Leave, AddressOf L_Tinh_Toan_H
        If Not EditH07.Column Is Nothing Then AddHandler EditH07.EditColumn.Leave, AddressOf L_Tinh_Toan_H
        If Not EditH08.Column Is Nothing Then AddHandler EditH08.EditColumn.Leave, AddressOf L_Tinh_Toan_H
        If Not EditH09.Column Is Nothing Then AddHandler EditH09.EditColumn.Leave, AddressOf L_Tinh_Toan_H
        If Not EditH10.Column Is Nothing Then AddHandler EditH10.EditColumn.Leave, AddressOf L_Tinh_Toan_H
        If Not EditH11.Column Is Nothing Then AddHandler EditH11.EditColumn.Leave, AddressOf L_Tinh_Toan_H
        If Not EditH12.Column Is Nothing Then AddHandler EditH12.EditColumn.Leave, AddressOf L_Tinh_Toan_H
        If Not EditT_H.Column Is Nothing Then AddHandler EditT_H.EditColumn.Leave, AddressOf L_Tinh_Toan_H

        If Not EditM01.Column Is Nothing Then AddHandler EditM01.EditColumn.Leave, AddressOf L_Tinh_Toan_M
        If Not EditM02.Column Is Nothing Then AddHandler EditM02.EditColumn.Leave, AddressOf L_Tinh_Toan_M
        If Not EditM03.Column Is Nothing Then AddHandler EditM03.EditColumn.Leave, AddressOf L_Tinh_Toan_M
        If Not EditM04.Column Is Nothing Then AddHandler EditM04.EditColumn.Leave, AddressOf L_Tinh_Toan_M
        If Not EditM05.Column Is Nothing Then AddHandler EditM05.EditColumn.Leave, AddressOf L_Tinh_Toan_M
        If Not EditM06.Column Is Nothing Then AddHandler EditM06.EditColumn.Leave, AddressOf L_Tinh_Toan_M
        If Not EditM07.Column Is Nothing Then AddHandler EditM07.EditColumn.Leave, AddressOf L_Tinh_Toan_M
        If Not EditM08.Column Is Nothing Then AddHandler EditM08.EditColumn.Leave, AddressOf L_Tinh_Toan_M
        If Not EditM09.Column Is Nothing Then AddHandler EditM09.EditColumn.Leave, AddressOf L_Tinh_Toan_M
        If Not EditM10.Column Is Nothing Then AddHandler EditM10.EditColumn.Leave, AddressOf L_Tinh_Toan_M
        If Not EditM11.Column Is Nothing Then AddHandler EditM11.EditColumn.Leave, AddressOf L_Tinh_Toan_M
        If Not EditM12.Column Is Nothing Then AddHandler EditM12.EditColumn.Leave, AddressOf L_Tinh_Toan_M
        If Not EditT_M.Column Is Nothing Then AddHandler EditT_M.EditColumn.Leave, AddressOf L_Tinh_Toan_M

        If Not EditV01.Column Is Nothing Then AddHandler EditV01.EditColumn.Leave, AddressOf L_Tinh_Toan_V
        If Not EditV02.Column Is Nothing Then AddHandler EditV02.EditColumn.Leave, AddressOf L_Tinh_Toan_V
        If Not EditV03.Column Is Nothing Then AddHandler EditV03.EditColumn.Leave, AddressOf L_Tinh_Toan_V
        If Not EditV04.Column Is Nothing Then AddHandler EditV04.EditColumn.Leave, AddressOf L_Tinh_Toan_V
        If Not EditV05.Column Is Nothing Then AddHandler EditV05.EditColumn.Leave, AddressOf L_Tinh_Toan_V
        If Not EditV06.Column Is Nothing Then AddHandler EditV06.EditColumn.Leave, AddressOf L_Tinh_Toan_V
        If Not EditV07.Column Is Nothing Then AddHandler EditV07.EditColumn.Leave, AddressOf L_Tinh_Toan_V
        If Not EditV08.Column Is Nothing Then AddHandler EditV08.EditColumn.Leave, AddressOf L_Tinh_Toan_V
        If Not EditV09.Column Is Nothing Then AddHandler EditV09.EditColumn.Leave, AddressOf L_Tinh_Toan_V
        If Not EditV10.Column Is Nothing Then AddHandler EditV10.EditColumn.Leave, AddressOf L_Tinh_Toan_V
        If Not EditV11.Column Is Nothing Then AddHandler EditV11.EditColumn.Leave, AddressOf L_Tinh_Toan_V
        If Not EditV12.Column Is Nothing Then AddHandler EditV12.EditColumn.Leave, AddressOf L_Tinh_Toan_V
        If Not EditT_V.Column Is Nothing Then AddHandler EditT_V.EditColumn.Leave, AddressOf L_Tinh_Toan_V

    End Sub
    Private Sub L_Tinh_Toan_T(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)
        Dim _StrF As String = "T01,T02,T03,T04,T05,T06,T07,T08,T09,T10,T11,T12"
        L_Tinh_Toan(_StrF)
        T_Tong_T()
        T_Tong_CL()
    End Sub
    Private Sub T_Tong_T()
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)

        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            Dv_Master.Item(i).Item("T_T") = Dv_Master.Item(i).Item("T01") + Dv_Master.Item(i).Item("T02") + Dv_Master.Item(i).Item("T03") + Dv_Master.Item(i).Item("T04") + Dv_Master.Item(i).Item("T05") + Dv_Master.Item(i).Item("T06") + Dv_Master.Item(i).Item("T07") + Dv_Master.Item(i).Item("T08") + Dv_Master.Item(i).Item("T09") + Dv_Master.Item(i).Item("T10") + Dv_Master.Item(i).Item("T11") + Dv_Master.Item(i).Item("T12")
            Dv_Master.Item(i).EndEdit()
        Next
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)
    End Sub
    Private Sub L_Tinh_Toan_H(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)
        Dim _StrF As String = "H01,H02,H03,H04,H05,H06,H07,H08,H09,H10,H11,H12"
        L_Tinh_Toan(_StrF)
        T_Tong_H()
        T_Tong_CL()
    End Sub
    Private Sub T_Tong_H()
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)

        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            Dv_Master.Item(i).Item("T_H") = Dv_Master.Item(i).Item("H01") + Dv_Master.Item(i).Item("H02") + Dv_Master.Item(i).Item("H03") + Dv_Master.Item(i).Item("H04") + Dv_Master.Item(i).Item("H05") + Dv_Master.Item(i).Item("H06") + Dv_Master.Item(i).Item("H07") + Dv_Master.Item(i).Item("H08") + Dv_Master.Item(i).Item("H09") + Dv_Master.Item(i).Item("H10") + Dv_Master.Item(i).Item("H11") + Dv_Master.Item(i).Item("H12")
            Dv_Master.Item(i).EndEdit()
        Next
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)
    End Sub
    Private Sub L_Tinh_Toan_M(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)
        Dim _StrF As String = "M01,M02,M03,M04,M05,M06,M07,M08,M09,M10,M11,M12"
        L_Tinh_Toan(_StrF)
        T_Tong_M()
        T_Tong_CL()
    End Sub
    Private Sub T_Tong_M()
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)

        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            Dv_Master.Item(i).Item("T_M") = Dv_Master.Item(i).Item("M01") + Dv_Master.Item(i).Item("M02") + Dv_Master.Item(i).Item("M03") + Dv_Master.Item(i).Item("M04") + Dv_Master.Item(i).Item("M05") + Dv_Master.Item(i).Item("M06") + Dv_Master.Item(i).Item("M07") + Dv_Master.Item(i).Item("M08") + Dv_Master.Item(i).Item("M09") + Dv_Master.Item(i).Item("M10") + Dv_Master.Item(i).Item("M11") + Dv_Master.Item(i).Item("M12")
            Dv_Master.Item(i).EndEdit()
        Next
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)
    End Sub
    Private Sub L_Tinh_Toan_V(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)
        Dim _StrF As String = "V01,V02,V03,V04,V05,V06,V07,V08,V09,V10,V11,V12"
        L_Tinh_Toan(_StrF)
        T_Tong_V()
        T_Tong_CL()
    End Sub
    Private Sub T_Tong_V()
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)

        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            Dv_Master.Item(i).Item("T_V") = Dv_Master.Item(i).Item("V01") + Dv_Master.Item(i).Item("V02") + Dv_Master.Item(i).Item("V03") + Dv_Master.Item(i).Item("V04") + Dv_Master.Item(i).Item("V05") + Dv_Master.Item(i).Item("V06") + Dv_Master.Item(i).Item("V07") + Dv_Master.Item(i).Item("V08") + Dv_Master.Item(i).Item("V09") + Dv_Master.Item(i).Item("V10") + Dv_Master.Item(i).Item("V11") + Dv_Master.Item(i).Item("V12")
            Dv_Master.Item(i).EndEdit()
        Next
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)

    End Sub
    Private Sub T_Tong_CL()
        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            Dv_Master.Item(i).Item("T_CL") = Dv_Master.Item(i).Item("T_T") + Dv_Master.Item(i).Item("T_V") + Dv_Master.Item(i).Item("T_M") - Dv_Master.Item(i).Item("T_H")
            Dv_Master.Item(i).EndEdit()
        Next
    End Sub
    Private Sub L_Tinh_Toan(ByVal _StrFieldSum As String)
        If M_Loai_KH = "1" Then L_Tinh_Toan_CT(_StrFieldSum) Else L_Tinh_Toan_TH(_StrFieldSum)
    End Sub
    Private Sub L_Tinh_Toan_CT(ByVal _StrFieldSum As String)
        Dim _Key As String = "Ma_Kx <> '' AND Ma_Mau <> ''"
        Dim _DtSum As DataTable = CyberSmodb.dtSumGroup(_StrFieldSum, "Ma_Kx", Dt_Master, _Key)
        Dim _Ma_Kx As String = ""

        For _iSum As Integer = 0 To _DtSum.Rows.Count - 1
            _Ma_Kx = _DtSum.Rows(_iSum).Item("Ma_Kx").ToString.Trim.ToUpper
            For i As Integer = 0 To Dv_Master.Count - 1
                If Dv_Master.Item(i).Item("Ma_Kx").ToString.Trim.ToUpper = _Ma_Kx And Dv_Master.Item(i).Item("Ma_Mau").ToString.Trim = "" Then
                    CyberSmodb.V_UpdateRowtoRow(_DtSum.Rows(_iSum), Dv_Master, i)
                    Exit For
                End If
            Next
        Next
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)
        'Sum All
        Dim _DtSumAll As DataTable = CyberSmodb.dtSumGroup(_StrFieldSum, "", _DtSum, "1=1")

        If _DtSumAll.Rows.Count = 1 Then
            For i As Integer = 0 To Dv_Master.Count - 1
                If Dv_Master.Item(i).Item("Ma_Kx").ToString.Trim.ToUpper = "" And Dv_Master.Item(i).Item("Ma_Mau").ToString.Trim = "" Then
                    CyberSmodb.V_UpdateRowtoRow(_DtSumAll.Rows(0), Dv_Master, i)
                    Exit For
                End If
            Next
        End If

        _DtSumAll.Dispose()
        _DtSum.Dispose()
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)
    End Sub
    Private Sub L_Tinh_Toan_TH(ByVal _StrFieldSum As String)
        Dim _Key As String = "Ma_Kx <> '' "
        Dim _DtSum As DataTable = CyberSmodb.dtSumGroup(_StrFieldSum, "Ma_Kx", Dt_Master, _Key)
        'Sum All

        Dim _DtSumAll As DataTable = CyberSmodb.dtSumGroup(_StrFieldSum, "", Dt_Master, _Key)

        If _DtSumAll.Rows.Count = 1 Then
            For i As Integer = 0 To Dv_Master.Count - 1
                If Dv_Master.Item(i).Item("Ma_Kx").ToString.Trim.ToUpper = "" Then
                    CyberSmodb.V_UpdateRowtoRow(_DtSumAll.Rows(0), Dv_Master, i)
                    Exit For
                End If
            Next
        End If
        _DtSumAll.Dispose()
        _DtSum.Dispose()
        MasterGRV.PostEditor()
        CyberSupport.V_UpdateGRV(MasterGRV)
    End Sub
    Private Sub V_AddHandler_Detail()

    End Sub


    Private Sub FrmRepports_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        KillProce()
    End Sub
    Private Sub KillProce()
        Try
            Dim op As Process
            For i As Integer = ProccessList.Count To 1 Step -1
                op = ProccessList(i)
                If Not op Is Nothing Then
                    If Not op.HasExited() Then
                        op.Kill()
                        ProccessList.Remove(i)
                    End If
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

#End Region
#Region "Event - Nut Lenh"
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not _Tab_Boolean Then Exit Sub
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True
        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            If _Type Then Dv_Master.Item(i).Item("Tag") = True Else Dv_Master.Item(i).Item("Tag") = "1"
            Dv_Master.Item(i).EndEdit()
            MasterGRV.UpdateCurrentRow()
        Next
    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not _Tab_Boolean Then Exit Sub
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True

        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            If _Type Then Dv_Master.Item(i).Item("Tag") = False Else Dv_Master.Item(i).Item("Tag") = "0"
            Dv_Master.Item(i).EndEdit()
            MasterGRV.UpdateCurrentRow()
        Next
    End Sub
    Private Sub V_SMS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        Dim _Ma_CT As String = _Drv.Item("Ma_CT")
        Dim _Dien_Thoai As String = _Drv.Item("Dien_Thoai")
        If _Stt_Rec.Trim <> "" Then CyberSupport.V_Sms(AppConn, Me.Para, Me.Sysvar, M_LAN, _Stt_Rec, _Ma_CT, M_Ma_Dvcs, M_User_Name, _Dien_Thoai, "", CyberSmlib, CyberSmodb)
    End Sub
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _FieldName, _Value, _Filter, _Filter1 As String
        Dim _Count = 0, _Index As Decimal = 0

        _FieldName = ComFilter.SelectedValue.ToString.Trim
        _Value = TxtSearch.Text.Trim
        _Value = CyberSmlistSys.V_FormatKeyFilter(_Value)
        _Filter = CyberSmlistSys.V_FilterDataColumns(Dv_Master, DV_Filter1, _FieldName, _Value, "%")
        _Filter1 = "1=1"
        If _Filter.Trim = "" Then _Filter = "1=1"
        If _Filter1.Trim = "" Then _Filter1 = "1=1"
        MasterGRV.ActiveFilterString = _Filter
        MasterGRV.FocusedRowHandle = 0
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm("Đang thực hiện lưu vào cơ sở dữ liệu", "Processing", M_LAN)
        If Loai_KH.ToString.ToUpper = "1" Then V_Save_CT() Else V_Save_TH()
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
    End Sub
    Private Function V_Save_CT() As Boolean
        Dim _Return As Boolean
        '----------------------------------------------------------------------------
        Dim _StrSave As String = ""
        Dim _Field As String = ""
        For i As Integer = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(i).Item("ma_Kx").ToString.Trim = "" Or Dv_Master.Item(i).Item("ma_mau").ToString.Trim = "" Then Continue For

            _StrSave = _StrSave + ";INSERT BEKHCTSave SELECT N'" + Dv_Master.Item(i).Item("Ma_Kx").ToString.Trim.Replace("'", "''") + "',N'" + Dv_Master.Item(i).Item("Ma_Mau").ToString.Trim.Replace("'", "''") + "'"
            For j As Integer = 1 To 12
                _Field = "T" + Strings.Right("00" + j.ToString.Trim, 2)
                _StrSave = _StrSave + ",N'" + Dv_Master.Item(i).Item(_Field).ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            Next
            For j As Integer = 1 To 12
                _Field = "H" + Strings.Right("00" + j.ToString.Trim, 2)
                _StrSave = _StrSave + ",N'" + Dv_Master.Item(i).Item(_Field).ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            Next

            For j As Integer = 1 To 12
                _Field = "M" + Strings.Right("00" + j.ToString.Trim, 2)
                _StrSave = _StrSave + ",N'" + Dv_Master.Item(i).Item(_Field).ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            Next
            For j As Integer = 1 To 12
                _Field = "V" + Strings.Right("00" + j.ToString.Trim, 2)
                _StrSave = _StrSave + ",N'" + Dv_Master.Item(i).Item(_Field).ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            Next
        Next
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BEGetKHCTSAVE", Thang1 & "#" & Thang2 & "#" & Nam & "#" & _StrSave & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        _Return = Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN)
        CyberSmlib.FlushMemorySave()
        Return _Return
    End Function
    Private Function V_Save_TH() As Boolean
        Dim _Return As Boolean
        '----------------------------------------------------------------------------
        Dim _StrSave As String = ""
        Dim _Field As String = ""
        For i As Integer = 0 To Dv_Master.Count - 1
            If Dv_Master.Item(i).Item("ma_Kx").ToString.Trim = "" Then Continue For

            _StrSave = _StrSave + ";INSERT BEKHTHSave SELECT N'" + Dv_Master.Item(i).Item("Ma_Kx").ToString.Trim.Replace("'", "''") + "'"
            For j As Integer = 1 To 12
                _Field = "T" + Strings.Right("00" + j.ToString.Trim, 2)
                _StrSave = _StrSave + ",N'" + Dv_Master.Item(i).Item(_Field).ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            Next
            For j As Integer = 1 To 12
                _Field = "H" + Strings.Right("00" + j.ToString.Trim, 2)
                _StrSave = _StrSave + ",N'" + Dv_Master.Item(i).Item(_Field).ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            Next

            For j As Integer = 1 To 12
                _Field = "M" + Strings.Right("00" + j.ToString.Trim, 2)
                _StrSave = _StrSave + ",N'" + Dv_Master.Item(i).Item(_Field).ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            Next
            For j As Integer = 1 To 12
                _Field = "V" + Strings.Right("00" + j.ToString.Trim, 2)
                _StrSave = _StrSave + ",N'" + Dv_Master.Item(i).Item(_Field).ToString.Trim.Replace(" ", "").Replace(",", ".") + "'"
            Next
        Next
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BEGetKHTHSAVE", Thang1 & "#" & Thang2 & "#" & Nam & "#" & _StrSave & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        _Return = Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN)
        CyberSmlib.FlushMemorySave()
        Return _Return

    End Function
    Sub V_GetValueRowDataTable(ByVal drData As DataRow, ByRef Field As String, ByRef Value As String)
        For Each dcData As DataColumn In drData.Table.Columns
            Field &= dcData.ColumnName.Trim & "!~!"
            Value &= drData(dcData.ColumnName.Trim).ToString.Trim & "!~!"
        Next
    End Sub
#End Region
#Region "Print "
    Private Sub V_XuatExcel(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")
        Dim _Title As String = Me.Text.Trim
        Dim _Tu_Ngay As String = "TỪ THÁNG " & Strings.Right("00" & Me.Thang1.ToString.Trim, 2) & " ĐẾN THÁNG " & Strings.Right("00" & Me.Thang2.ToString.Trim, 2) & " năm " & Me.Nam.ToString.Trim
        _Title = _Title.ToUpper
        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXls(AppConn, Me.MasterGRV, _Dv_Title, Dv_Master, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name, "C:\CYBER_DsXE.xls")
    End Sub
    Private Sub V_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec")
        Dim _Ma_CT As String = _Drv.Item("Ma_CT")
        Dim _Ma_Post As String = _Drv.Item("Ma_Post")
        Dim _Ngay_CT As String = _Drv.Item("Ngay_CT")
        If _Stt_Rec.Trim = "" Then Exit Sub
        If Not ChkRightsVoucher("P", _Ngay_CT, _Ma_Post, _Stt_Rec, _Ma_CT) Then Exit Sub
        CyberVoucher.V_PrintVocuher(AppConn, Me.Sysvar, Nothing, _Stt_Rec, _Ngay_CT, _Ma_Post, M_LAN, Me.Para, DrDmct, _Ma_CT, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport)
    End Sub
    Private Sub V_IN_Bien_Ban(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_In As String = ""
        Dim _Loai_in As String = ""
        Dim _Ma_HD As String = ""
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec0 As String = ""
        Dim _So_khung As String = ""
        Dim _Ma_KX As String = ""
        Dim _Ma_Mau As String = ""

        ' GetMa_IN_InFor(_Ma_HD, _Stt_Rec, _Stt_Rec0, _So_khung, _Ma_KX, _Ma_Mau)
        Lua_Chon_IN(_Ma_In, _Loai_in, _Ma_HD, _Stt_Rec, _Stt_Rec0, _So_khung, _Ma_KX, _Ma_Mau)
        If _Ma_In.Trim = "" Or _Loai_in = "" Then Exit Sub
        '--- Get WaterMark
        Dim DrMaterMark As DataRow = CyberVoucher.GetWaterMark(AppConn, _Stt_Rec, "00", "HDX", M_Ma_Dvcs, M_User_Name, CyberSmlib)
        Dim _IsWaterMark As Boolean = False
        Dim _WaterMark As String = ""
        If Not DrMaterMark Is Nothing Then
            If DrMaterMark.Table.Columns.Contains("IsWaterMark") Then If DrMaterMark.Item("IsWaterMark").ToString.Trim = "1" Then _IsWaterMark = True Else _IsWaterMark = False
            If DrMaterMark.Table.Columns.Contains("WaterMark") Then _WaterMark = DrMaterMark.Item("WaterMark").ToString
        End If
        V_PRIN_Bien_Ban(_Ma_In, _Loai_in, _IsWaterMark, _WaterMark)
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_PRIN_Bien_Ban(ByVal _Ma_In As String, ByVal _Loai_in As String, ByVal _IsWaterMark As Boolean, ByVal _WaterMark As String)

        Dim _Ma_HD As String = ""
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec0 As String = ""
        Dim _So_khung As String = ""
        Dim _Ma_KX As String = ""
        Dim _Ma_Mau As String = ""
        If Not _Tab_Boolean Then
            Dim iRow As Integer = -1
            iRow = MasterGRV.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            _Ma_HD = Dv_Master.Item(iRow).Item("Ma_HD").ToString.Trim
            _Stt_Rec = Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
            _Stt_Rec0 = Dv_Master.Item(iRow).Item("Stt_Rec0").ToString.Trim
            _So_khung = Dv_Master.Item(iRow).Item("So_khung").ToString.Trim
            _Ma_KX = Dv_Master.Item(iRow).Item("Ma_Kx").ToString.Trim
            _Ma_Mau = Dv_Master.Item(iRow).Item("ma_Mau").ToString.Trim

            V_PRIN_Bien_Ban("1", _Ma_In, _Loai_in, _Ma_HD, _Stt_Rec, _Stt_Rec0, _So_khung, _Ma_KX, _Ma_Mau, _IsWaterMark, _WaterMark)
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------------------------------------
        Dim _Type As Boolean = False
        If Dv_Master.Table.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True
        Dim nCountTag As Integer = 0
        For i = 0 To Dv_Master.Count - 1
            If _Type Then
                If Dv_Master.Item(i).Item("Tag") = True Then
                    nCountTag = nCountTag + 1
                End If
            Else
                If Dv_Master.Item(i).Item("Tag").ToString.Trim = "1" Then
                    nCountTag = nCountTag + 1
                End If
            End If
        Next
        If nCountTag = 0 Then
            Dim iRow As Integer = -1
            iRow = MasterGRV.GetFocusedDataSourceRowIndex
            If iRow < 0 Then Exit Sub
            _Ma_HD = Dv_Master.Item(iRow).Item("Ma_HD").ToString.Trim
            _Stt_Rec = Dv_Master.Item(iRow).Item("Stt_Rec").ToString.Trim
            _Stt_Rec0 = Dv_Master.Item(iRow).Item("Stt_Rec0").ToString.Trim
            _So_khung = Dv_Master.Item(iRow).Item("So_khung").ToString.Trim
            _Ma_KX = Dv_Master.Item(iRow).Item("Ma_Kx").ToString.Trim
            _Ma_Mau = Dv_Master.Item(iRow).Item("ma_Mau").ToString.Trim
            V_PRIN_Bien_Ban("1", _Ma_In, _Loai_in, _Ma_HD, _Stt_Rec, _Stt_Rec0, _So_khung, _Ma_KX, _Ma_Mau, _IsWaterMark, _WaterMark)
            Exit Sub
        End If
        '-------------------------------------------------------------------------------------------------------------------
        Dim _Lan As Integer = 0
        For i = 0 To Dv_Master.Count - 1
            If _Type Then
                If Dv_Master.Item(i).Item("Tag") = True Then
                    _Ma_HD = Dv_Master.Item(i).Item("Ma_HD").ToString.Trim
                    _Stt_Rec = Dv_Master.Item(i).Item("Stt_Rec").ToString.Trim
                    _Stt_Rec0 = Dv_Master.Item(i).Item("Stt_Rec0").ToString.Trim
                    _So_khung = Dv_Master.Item(i).Item("So_khung").ToString.Trim
                    _Ma_KX = Dv_Master.Item(i).Item("Ma_Kx").ToString.Trim
                    _Ma_Mau = Dv_Master.Item(i).Item("ma_Mau").ToString.Trim
                    _Lan = _Lan + 1
                    V_PRIN_Bien_Ban(_Lan, _Ma_In, _Loai_in, _Ma_HD, _Stt_Rec, _Stt_Rec0, _So_khung, _Ma_KX, _Ma_Mau, _IsWaterMark, _WaterMark)
                    If _Loai_in = "3" Then Exit Sub
                End If
            Else
                If Dv_Master.Item(i).Item("Tag").ToString.Trim = "1" Then
                    _Ma_HD = Dv_Master.Item(i).Item("Ma_HD").ToString.Trim
                    _Stt_Rec = Dv_Master.Item(i).Item("Stt_Rec").ToString.Trim
                    _Stt_Rec0 = Dv_Master.Item(i).Item("Stt_Rec0").ToString.Trim
                    _So_khung = Dv_Master.Item(i).Item("So_khung").ToString.Trim
                    _Ma_KX = Dv_Master.Item(i).Item("Ma_Kx").ToString.Trim
                    _Ma_Mau = Dv_Master.Item(i).Item("ma_Mau").ToString.Trim
                    _Lan = _Lan + 1
                    V_PRIN_Bien_Ban(_Lan, _Ma_In, _Loai_in, _Ma_HD, _Stt_Rec, _Stt_Rec0, _So_khung, _Ma_KX, _Ma_Mau, _IsWaterMark, _WaterMark)
                    If _Loai_in = "3" Then Exit Sub
                End If
            End If
        Next

    End Sub
    Private Sub V_PRIN_Bien_Ban(ByVal _Lan_In As Integer, ByVal _Ma_In As String, ByVal _Loai_in As String, ByVal _Ma_HD As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec0 As String, _
                                ByVal _So_khung As String, ByVal _ma_Kx As String, ByVal _ma_Mau As String, ByVal _IsWaterMark As Boolean, ByVal _WaterMark As String)
        Dim DsPrint As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BeXepXe_PRINT", _Ma_In & "#" & _Ma_HD & "#" & _Stt_Rec & "#" & _Stt_Rec0 & "#" & _ma_Kx & "#" & _ma_Mau & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim _Report_Name As String = DsPrint.Tables(0).Rows(0).Item("Repo_Name").ToString.Trim
        Dim _Title As String = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        Dim CyberPrint As New Cyber.Print.Sys
        CyberPrint.CyberPrintReport(AppConn, _Loai_in, _Report_Name, DsPrint, _Title, _Title, Me.Sysvar, Me.Para, M_Ma_Dvcs, _IsWaterMark, _WaterMark, Me.Lan, True, True)
        DsPrint.Dispose()
    End Sub
    Private Sub Lua_Chon_IN(ByRef _Ma_In As String, ByRef _Loai_In As String, ByVal _Ma_HD As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec0 As String, ByVal _So_khung As String, ByVal _ma_Kx As String, ByVal _ma_Mau As String)
        If Dv_Master.Count <= 0 Then
            _Ma_In = ""
            _Loai_In = ""

            Exit Sub
        End If
        Dim frm1 As BEXEPXE_IN_BB
        frm1 = New BEXEPXE_IN_BB

        frm1.Lan = M_LAN
        frm1.Para = Me.Para
        frm1.Sysvar = Me.Sysvar
        frm1.AppConn = AppConn
        frm1.CyberSmlib = CyberSmlib
        frm1.CyberSupport = CyberSupport
        frm1.CyberFill = CyberFill
        frm1.CyberSmlistSys = CyberSmlistSys
        frm1.CyberSmodb = CyberSmodb
        'frm1.CyberExport = Me.CyberEport
        frm1.CyberVoucher = CyberVoucher
        frm1.CyberLoading = CyberLoading
        'frm1.DsDataLoc = DsCalculator
        ' frm1.WindowState = Windows.Forms.FormWindowState.Maximized
        frm1.Key_Sub1 = Me.Key_Sub1.ToString.Trim
        frm1.Key_Sub2 = Me.Key_Sub1.ToString.Trim
        frm1.Thang1 = Me.Thang1.ToUpper.Trim
        frm1.Thang2 = Me.Thang2.ToUpper.Trim
        frm1.Nam = Me.Nam.ToUpper.Trim
        frm1.ShowInTaskbar = False
        '-----------------------------------------------------------------------------------
        frm1.Ma_HD = _Ma_HD
        frm1.Stt_Rec = _Stt_Rec
        frm1.Stt_Rec0 = _Stt_Rec0
        frm1.So_Khung = _So_khung
        frm1.Ma_Kx = _ma_Kx
        frm1.Ma_Mau = _ma_Mau
        '-----------------------------------------------------------------------------------
        frm1.ShowDialog()
        If Not frm1.Save_OK Then
            _Ma_In = ""
            _Loai_In = ""
            Exit Sub
        End If
        _Ma_In = frm1.Key_Sub1.ToString.Trim
        _Loai_In = frm1.Key_Sub2.ToString.Trim
    End Sub
    Private Function ChkRightsVoucher(ByVal _Mode As String, ByVal _Ngay_CT As Date, ByVal _Ma_Post As String, ByVal _Stt_Rec As String, ByVal _Ma_CT As String) As Boolean
        ChkRightsVoucher = CyberSupport.ChkRightsVoucher(_Ngay_CT, _Mode, _Ma_Post, _Stt_Rec, _Ma_CT, M_Ma_Dvcs, M_User_Name, M_LAN, AppConn, Me.Sysvar, CyberSmlib)
    End Function
#End Region
#Region "Event"
    Private Function FindRowHandleByRowObject(ByVal view As DevExpress.XtraGrid.Views.Grid.GridView, ByVal row As Object) As Integer
        Dim I As Integer
        If Not row Is Nothing Then
            For I = 0 To view.DataRowCount - 1
                If row.Equals(view.GetRow(I)) Then
                    Return I
                End If
            Next
        End If
        Return DevExpress.XtraGrid.GridControl.InvalidRowHandle
    End Function
    Private Function V_UpdateItem(ByVal Dv As DataView, ByVal iRow As Decimal, ByVal DrvUp As DataRowView) As DataRowView
        If iRow < 0 Then Return Nothing
        Dim iCol As Integer
        Dim _Fieldname As String
        Dim Drv As DataRowView
        Drv = Dv.Item(iRow)
        Drv.BeginEdit()
        For iCol = 0 To Dv.Table.Columns.Count - 1
            _Fieldname = Dv.Table.Columns(iCol).ColumnName
            If DrvUp.DataView.Table.Columns.Contains(_Fieldname) Then
                Drv.Item(_Fieldname) = DrvUp.Item(_Fieldname)
            End If
        Next
        Drv.EndEdit()
        Dv.Table.AcceptChanges()
        Return Drv
    End Function
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        If Dt_Master.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dt_Master.Columns("Bold").ColumnName
            Dim _categoryBold As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New Drawing.Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        End If
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dt_Master.Columns.Contains("BackColor") Then
                Dim _FieldBackColor As String = ""
                _FieldBackColor = Dt_Master.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If
            If Dt_Master.Columns.Contains("BackColor2") Then
                Dim _FieldBackColor2 As String = ""
                _FieldBackColor2 = Dt_Master.Columns("BackColor2").ColumnName
                Dim _categoryBackColor2 As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor2).ToString.Trim
                e.Appearance.BackColor2 = CyberColor.GetBacColorkReports(_categoryBackColor2)
            End If
        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()

        '--- End Tuy chọn
        If _Tab_Boolean Then
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chọn chứng từ", "Select All"), AddressOf V_SelectAll, Shortcut.CtrlA, Nothing, True, True)).BeginGroup = True
            PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gỡ chọn", "Remove All"), AddressOf V_RemoveAll, Shortcut.CtrlU, Nothing, True, True)).BeginGroup = False
        End If
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)

        'End If
    End Sub
#End Region
End Class
