Imports System.Drawing
Imports System.Windows.Forms
Public Class GLCTPK3
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
    Dim Dt_head, Dt_Master, Dt_Dmct As DataTable
    Dim Dv_head, Dv_Master, Dv_Dmct As DataView
    Dim DrDmct As DataRow
    Dim CyberColor As New Cyber.Color.Sys
    Dim EditDc As New Cyber.Fill.CyberColumnGridView
    Dim M_Bar As String
    Dim M_Bar2 As String
    Private Sub FGLCTPK3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Bar = Me.Para(11).Trim
        M_Bar2 = Me.Para(12).Trim
        Me.Save_OK = False
        Me.Tag = ""
        V_Load()
        V_FilldatatoGridview()
        V_GetColumn()
        V_AddHandler_Master()
        V_AddHandler_Detail()
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
        Me.Text = Me.Text.Trim + " Năm " + Me.Nam.Trim
        CyberSupport.Translaste(Me, M_LAN, True)
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
    End Sub
    Private Sub V_GetColumn()
        EditDc.GetColumn(MasterGRV, "DC")
    End Sub
    Private Sub V_FilldatatoGridview()
        CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_head, Dv_Master)
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
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
    End Sub
#End Region
#Region "V_AddHandler"
    Private Sub V_AddHandler_Master()
        RemoveHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle

        RemoveHandler CmdSelectAll.Click, AddressOf V_SelectAll
        RemoveHandler CmdRemoveAll.Click, AddressOf V_RemoveAll

        RemoveHandler CmdCreate.Click, AddressOf V_CreateBT
        RemoveHandler CmdDelete.Click, AddressOf V_DeleteBT
        '------------
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing

        AddHandler CmdSelectAll.Click, AddressOf V_SelectAll
        AddHandler CmdRemoveAll.Click, AddressOf V_RemoveAll

        AddHandler CmdCreate.Click, AddressOf V_CreateBT
        AddHandler CmdDelete.Click, AddressOf V_DeleteBT

        AddHandler ButtExit.Click, AddressOf V_Exits

    End Sub
    Private Sub V_AddHandler_Detail()
        'RemoveHandler EditDc.EditColumn.Click, AddressOf V_F3
        'AddHandler EditDc.EditColumn.Click, AddressOf V_F3
    End Sub
    Private Sub V_CreateBT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmF3 As ThangToThang
        FrmF3 = New ThangToThang
        FrmF3.Add_Title = If(Me.Lan = "V", "Tạo: ", "Create: ")
        FrmF3.Lan = Me.Lan
        FrmF3.Para = Me.Para
        FrmF3.Sysvar = Me.Sysvar
        FrmF3.AppConn = Me.AppConn
        FrmF3.CyberSmlib = Me.CyberSmlib
        FrmF3.CyberSupport = Me.CyberSupport
        FrmF3.CyberFill = Me.CyberFill
        FrmF3.CyberSmlistSys = Me.CyberSmlistSys
        FrmF3.CyberSmodb = Me.CyberSmodb
        FrmF3.CyberExport = Me.CyberExport
        FrmF3.CyberVoucher = Me.CyberVoucher
        FrmF3.CyberLoading = Me.CyberLoading
        FrmF3.ShowInTaskbar = False
        FrmF3.ShowDialog()
        If Not FrmF3.Save_OK Then Exit Sub
        Dim _thang1 As String = FrmF3.Thang1.ToString.Trim
        Dim _thang2 As String = FrmF3.Thang2.ToString.Trim
        Dim _Nam As String = FrmF3.Nam.ToString.Trim

        Dim _DsChk As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ChkPK3", "D" & "#" & _thang1 & "#" & _thang2 & "#" & _Nam & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(_DsChk.Tables(0), Me.Sysvar, Me.Lan) Then Exit Sub
        '-----:Delete

        Dim _DsTmp As DataSet
        For i = 0 To Dt_Master.Rows.Count - 1
            If Not Dt_Master.Rows(i).Item("Tag") Then Continue For
            _DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GLCTPK3", Dt_Master.Rows(i).Item("Stt").ToString.Trim & "#" & _thang1 & "#" & _thang2 & "#" & _Nam & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Next
        If Not _DsTmp Is Nothing Then If _DsTmp.Tables.Count > 0 Then If _DsTmp.Tables(0).Columns.Contains("status") Then CyberSupport.V_MsgChk(_DsTmp.Tables(0), Me.Sysvar, Me.Lan)
        V_RemoveAll(New System.Object, New System.EventArgs)
    End Sub
    Private Sub V_DeleteBT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FrmF3 As ThangToThang
        FrmF3 = New ThangToThang
        FrmF3.Add_Title = If(Me.Lan = "V", "Xóa: ", "Delete: ")
        FrmF3.Lan = Me.Lan
        FrmF3.Para = Me.Para
        FrmF3.Sysvar = Me.Sysvar
        FrmF3.AppConn = Me.AppConn
        FrmF3.CyberSmlib = Me.CyberSmlib
        FrmF3.CyberSupport = Me.CyberSupport
        FrmF3.CyberFill = Me.CyberFill
        FrmF3.CyberSmlistSys = Me.CyberSmlistSys
        FrmF3.CyberSmodb = Me.CyberSmodb
        FrmF3.CyberExport = Me.CyberExport
        FrmF3.CyberVoucher = Me.CyberVoucher
        FrmF3.CyberLoading = Me.CyberLoading
        FrmF3.ShowInTaskbar = False
        FrmF3.ShowDialog()
        If Not FrmF3.Save_OK Then Exit Sub
        Dim _thang1 As String = FrmF3.Thang1.ToString.Trim
        Dim _thang2 As String = FrmF3.Thang2.ToString.Trim
        Dim _Nam As String = FrmF3.Nam.ToString.Trim
        Dim _DsChk As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ChkPK3", "D" & "#" & _thang1 & "#" & _thang2 & "#" & _Nam & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(_DsChk.Tables(0), Me.Sysvar, Me.Lan) Then Exit Sub
        '-----:Delete

        Dim _DsTmp As DataSet
        For i = 0 To Dt_Master.Rows.Count - 1
            If Not Dt_Master.Rows(i).Item("Tag") Then Continue For
            _DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GLCTPK3DELETE", "Y" & "#" & Dt_Master.Rows(i).Item("Stt").ToString.Trim & "#" & _thang1 & "#" & _thang2 & "#" & _Nam & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Next
        If Not _DsTmp Is Nothing Then If _DsTmp.Tables.Count > 0 Then If _DsTmp.Tables(0).Columns.Contains("status") Then CyberSupport.V_MsgChk(_DsTmp.Tables(0), Me.Sysvar, Me.Lan)

        V_RemoveAll(New System.Object, New System.EventArgs)
    End Sub
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
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Me.Tag = ""
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
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
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo " & M_Bar, "Create " & M_Bar2), AddressOf V_CreateBT, Shortcut.F4, My.Resources.apply_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa  " & M_Bar, "Delete " & M_Bar2), AddressOf V_DeleteBT, Shortcut.F8, My.Resources.Xoa_BT_16x16, True, False))
        If MasterGRV.OptionsView.AllowCellMerge = False Then PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.CtrlF5, My.Resources.refresh2_16x16, True, True), True)
        '--- End Tuy chọn
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        'PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)

        'End If
    End Sub
#End Region
End Class
