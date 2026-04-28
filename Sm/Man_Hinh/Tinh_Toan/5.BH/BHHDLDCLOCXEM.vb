Imports System.Drawing
Imports System.Windows.Forms
Public Class BHHDLDCLOCXEM
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

    Dim M_strLoc, M_Cp_Update, M_Cp_Loc As String
    Dim M_DsDataLoc As DataSet

    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim Dt_head, Dt_headDetail, Dt_Master, Dt_DetailTmp, Dt_Dmct As DataTable
    Dim Dv_head, Dv_headDetail, Dv_Master, Dv_DetailTmp, Dv_Dmct As DataView
    Dim DrDmct As DataRow
    Dim CyberColor As New Cyber.Color.Sys
    Dim EditDc As New Cyber.Fill.CyberColumnGridView
    Private Sub BHHDLDCLOCXEM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        M_Bar = Me.Para(11).Trim
        M_Bar2 = Me.Para(12).Trim
        Me.Save_OK = False
        Me.Tag = ""
        V_Load()
        V_FilldatatoGridview(sender, e)
        V_GetColumn()

        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtExit.Click, AddressOf V_Exits
        RemoveHandler ButtRefresh.Click, AddressOf V_Refresh

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Exits
        AddHandler ButtRefresh.Click, AddressOf V_Refresh
        AddHandler ButtSelectAll.Click, AddressOf V_SelectAll
        AddHandler ButtRemoveAll.Click, AddressOf V_RemoveAll
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Drv As DataRowView
        Dim _Dv As DataView
        Dim _DsTmp As New DataSet
        Dim _dt As Date
        For i = 0 To Dt_Master.Rows.Count - 1
            If Dt_Master.Rows(i).Item("Tag").ToString.ToUpper = "TRUE" Then
                For j As Integer = 0 To Dv_DetailTmp.Count - 1
                    If Dv_DetailTmp.Item(j).Item("Stt_rec").ToString = Dt_Master.Rows(i).Item("Stt_rec").ToString Then
                        _dt = Dv_DetailTmp.Item(j).Item("Ngay_Ct")
                        _DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_BHHDLDCUPDATE", _dt.ToString("yyyyMMdd") & "#" & Dv_DetailTmp.Item(j).Item("Stt_rec").ToString.Trim & "#" & Dv_DetailTmp.Item(j).Item("Stt_rec0").ToString.Trim & "#" & Dv_DetailTmp.Item(j).Item("So_SO").ToString.Trim & "#" & Dv_DetailTmp.Item(j).Item("Ma_VT").ToString.Trim & "#" & Dv_DetailTmp.Item(j).Item("Ma_Kho").ToString.Trim & "#" & Dv_DetailTmp.Item(j).Item("Ma_DB").ToString.Trim & "#" & Dv_DetailTmp.Item(j).Item("SL_DC") & "#" & M_Ma_Dvcs & "#" & M_User_Name)
                        _Dv = New DataView(_DsTmp.Tables(0))
                        _Drv = _Dv.Item(0)
                        V_UpdateItem(Dv_DetailTmp, j, _Drv)
                    End If
                Next
            End If
        Next
        If Not _DsTmp Is Nothing Then If _DsTmp.Tables.Count > 0 Then If _DsTmp.Tables(0).Columns.Contains("status") Then CyberSupport.V_MsgChk(_DsTmp.Tables(0), Me.Sysvar, Me.Lan)
        V_RemoveAll(New System.Object, New System.EventArgs)
    End Sub
#Region "Load data"
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To Dt_Master.Rows.Count - 1
            Dt_Master.Rows(i).BeginEdit()
            Dt_Master.Rows(i).Item("Tag") = True
            Dt_Master.Rows(i).EndEdit()
            Dt_Master.AcceptChanges()
        Next
    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim i As Integer
        For i = 0 To Dt_Master.Rows.Count - 1
            Dt_Master.Rows(i).BeginEdit()
            Dt_Master.Rows(i).Item("Tag") = False
            Dt_Master.Rows(i).EndEdit()
            Dt_Master.AcceptChanges()
        Next
    End Sub
    Private Sub V_Load()
        CyberSmodb.SetNotNullTable(DsDataLoc.Tables(0))
        CyberSmodb.SetNotNullTable(DsDataLoc.Tables(1))
        CyberSmodb.SetNotNullTable(DsDataLoc.Tables(2))
        CyberSmodb.SetNotNullTable(DsDataLoc.Tables(3))

        Dt_Master = DsDataLoc.Tables(0).Copy
        Dt_DetailTmp = DsDataLoc.Tables(1).Copy
        Dt_head = DsDataLoc.Tables(2).Copy
        Dt_headDetail = DsDataLoc.Tables(3).Copy

        Dv_Master = New DataView(Dt_Master)
        Dv_DetailTmp = New DataView(Dt_DetailTmp)

        Dv_head = New DataView(Dt_head)
        Dv_headDetail = New DataView(Dt_headDetail)
    End Sub
    Private Sub V_GetColumn()

    End Sub
    Private Sub V_FilldatatoGridview(ByVal sender As Object, ByVal e As EventArgs)
        CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_head, Dv_Master)
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
        '-----------------------------------------------------------------------------------
        FillDetailGRV(sender, e)

        'CyberFill.V_FillReports(DetailGRV, Me.Lan, Dv_headDetail, Dv_DetailTmp)
        'Detail.DataSource = Dv_DetailTmp
        'Me.DetailGRV.GridControl = Me.Detail
        'DetailGRV.OptionsView.ShowViewCaption = False
        'DetailGRV.OptionsSelection.MultiSelect = False
        'Me.DetailGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
    End Sub
    Private Sub FillDetailGRV(ByVal sender As Object, ByVal e As EventArgs)
        Binding_PositionChanged(sender, e)
        Dim currency As CurrencyManager
        currency = Me.BindingContext(Me.MasterGRV.DataSource)
        AddHandler currency.PositionChanged, AddressOf Binding_PositionChanged
        '---------------------------
        Detail.DataSource = Dv_DetailTmp
        Me.DetailGRV.GridControl = Me.Detail
        DetailGRV.OptionsView.ShowViewCaption = False
        DetailGRV.OptionsSelection.MultiSelect = False
        'CyberFill.V_FillVoucherView(DetailGRV, M_LAN, Dv_headDetail, Dv_DetailTmp)
        CyberFill.V_FillReports(DetailGRV, Me.Lan, Dv_headDetail, Dv_DetailTmp)
    End Sub
    Private Sub Binding_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim filter As String = Nothing
        Dim selectedRow As DataRowView = Nothing

        Try
            If (Dv_Master.Table.Rows.Count() <> Nothing And Dv_Master.Table.Columns.Count > 0) Then
                selectedRow = CType(Me.BindingContext(MasterGRV.DataSource).Current, DataRowView)
            End If
            If (Not String.IsNullOrEmpty(selectedRow("stt_rec").ToString)) Then

                filter = "stt_rec='" + selectedRow("stt_rec").ToString() + "'"
                Dv_DetailTmp.RowFilter = filter
            End If
        Catch ex As Exception
            Dv_DetailTmp.RowFilter = "1=0"
        End Try

    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, Cp_Loc, strLoc)
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
        '--------------------------------------------------------------
        nCount = Dt_DetailTmp.Rows.Count - 1
        For i = nCount To 0 Step -1
            Dt_DetailTmp.Rows(i).Delete()
        Next
        Dt_DetailTmp.AcceptChanges()
        For i = 0 To Dstmp.Tables(1).Rows.Count - 1
            Dt_DetailTmp.ImportRow(Dstmp.Tables(1).Rows(i))
        Next
        Dt_DetailTmp.AcceptChanges()
    End Sub
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
            If Dt_Master.Columns.Contains("BackColor") And Dt_Master.Columns.Contains("Tag") Then
                Dim _FieldBackColor As String = Dt_Master.Columns("BackColor").ColumnName
                Dim _categoryBackColor As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBackColor).ToString.Trim
                '------------
                Dim _FieldTab As String = Dt_Master.Columns("Tag").ColumnName
                Dim _Tag As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldTab).ToString.Trim.ToUpper
                If Not _Tag = "CHECKED".ToUpper.Trim Then _categoryBackColor = ""
                '-------------
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
#End Region

End Class
