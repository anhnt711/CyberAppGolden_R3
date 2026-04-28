Imports System.Drawing
Imports System.Windows.Forms

Public Class FATgNgXemVAT
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
    Dim EditTangNg, EditGiamNg As New Cyber.Fill.CyberColumnGridView
    Dim M_Bar As String
    Dim M_Bar2 As String
    Private Sub FATgNgXemVAT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        CyberSupport.Translaste(Me, M_LAN, True)
        Me.Text = Me.Text + " - Finance"
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
        Dv_Master.Sort = "Ma_Ts,Stt0"
    End Sub
    Private Sub V_GetColumn()
        EditTangNg.GetColumn(MasterGRV, "TangNG")
        EditGiamNg.GetColumn(MasterGRV, "GiamNG")
    End Sub
    Private Sub V_FilldatatoGridview()
        CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_head, Dv_Master)
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
    End Sub
    Private Sub V_Tang_Giam(ByVal _Moi_Sua As String, ByVal _Loai_TG As String, ByVal iRow As Integer)

        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)

        If _Moi_Sua.Trim = "S" Then If _Drv.Item("TgTs").ToString.Trim.ToUpper <> _Loai_TG.Trim.ToUpper.Trim Then Exit Sub

        Dim FrmF3 As New FaTgNgF3VAT
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
        FrmF3.Drv = _Drv
        FrmF3.ShowInTaskbar = False
        FrmF3.Loai_TG = _Loai_TG
        FrmF3.Mode = _Moi_Sua
        FrmF3.ShowDialog()

        If Not FrmF3.Save_OK Then Exit Sub
        _Drv = FrmF3.Drv


        Dim rowView As DataRowView
        Dim iCol As Integer = -1
        If _Moi_Sua = "S" Then
            rowView = V_UpdateItem(Dv_Master, iRow, _Drv)
            MasterGRV.FocusedRowHandle = 0
            iCol = FindRowHandleByRowObject(MasterGRV, rowView)
            MasterGRV.FocusedRowHandle = iCol
            MasterGRV.ClearSelection()
            MasterGRV.SelectRow(MasterGRV.FocusedRowHandle)
        Else
            rowView = V_InsertItem(_Drv)
            MasterGRV.FocusedRowHandle = 0
            iCol = FindRowHandleByRowObject(MasterGRV, rowView)
            MasterGRV.FocusedRowHandle = iCol
            MasterGRV.ClearSelection()
            MasterGRV.SelectRow(MasterGRV.FocusedRowHandle)
        End If
    End Sub
    Private Sub V_Tang_F4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_Tang_Giam("M", "T", iRow)
    End Sub
    Private Sub V_Tang_F3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_Tang_Giam("S", "T", iRow)
    End Sub
    Private Sub V_Tang_Giam_F8(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = Dv_Master.Item(iRow)

        Dim _Ma_Ts As String = _Drv("Ma_Ts")
        Dim _Stt0 As String = _Drv("Stt0")
        Dim _Ma_Nv As String = _Drv("Ma_Nv")

        If Not MsgBox("Bạn có chắc chẵn xóa điều chỉnh tăng/giảm nguyên giá của tài sản này không ?", MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, Me.Sysvar("M_CYBER_VER")) = MsgBoxResult.Ok Then Exit Sub
        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_FaTgNgDeleteVAT", _Ma_Nv & "#" & _Stt0 & "#" & _Ma_Ts & "#" & Me.M_Ma_Dvcs & "#" & Me.M_User_Name)
        If CyberSupport.V_MsgChk(_DsTmp.Tables(0), Me.Sysvar) Then
            V_DeleteItem(Dv_Master, iRow)
        End If
    End Sub
    Private Sub V_Giam_F4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_Tang_Giam("M", "G", iRow)
    End Sub
    Private Sub V_Giam_F3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_Tang_Giam("S", "G", iRow)
    End Sub
    Private Sub V_DeleteItem(ByVal Dv As DataView, ByVal iRow As Decimal)
        If iRow < 0 Then Exit Sub
        Dv.Item(iRow).Delete()
        Dv.Table.AcceptChanges()
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

        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
    End Sub
    Private Sub V_AddHandler_Detail()
        RemoveHandler EditTangNg.EditColumn.Click, AddressOf V_Tang_F4
        AddHandler EditTangNg.EditColumn.Click, AddressOf V_Tang_F4

        RemoveHandler EditGiamNg.EditColumn.Click, AddressOf V_Giam_F4
        AddHandler EditGiamNg.EditColumn.Click, AddressOf V_Giam_F4
    End Sub
#End Region
#Region "Event"
    Private Function V_InsertItem(ByVal DrInsert As DataRow) As DataRowView
        Dim iCol As Integer = Dv_Master.Table.Columns.Count - 1
        Dim rowView As DataRowView = Dv_Master.AddNew
        Dim _Fieldname As String = ""
        rowView.BeginEdit()
        For iCol = 0 To Dv_Master.Table.Columns.Count - 1
            _Fieldname = Dv_Master.Table.Columns(iCol).ColumnName
            If Not DrInsert.Table.Columns.Contains(_Fieldname) Then Continue For
            rowView(_Fieldname) = DrInsert.Item(_Fieldname)
        Next
        rowView.EndEdit()
        Dv_Master.Table.AcceptChanges()
        Return rowView
    End Function
    Private Function V_InsertItem(ByVal DrInsert As DataRowView) As DataRowView
        Dim iCol As Integer = Dv_Master.Table.Columns.Count - 1
        Dim rowView As DataRowView = Dv_Master.AddNew
        Dim _Fieldname As String = ""
        rowView.BeginEdit()
        For iCol = 0 To Dv_Master.Table.Columns.Count - 1
            _Fieldname = Dv_Master.Table.Columns(iCol).ColumnName
            If Not DrInsert.DataView.Table.Columns.Contains(_Fieldname) Then Continue For
            rowView(_Fieldname) = DrInsert.Item(_Fieldname)
        Next
        rowView.EndEdit()
        Dv_Master.Table.AcceptChanges()
        Return rowView
    End Function
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
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "1. Điều chỉnh tăng nguyên giá tài sản cố định", AddressOf V_Tang_F4, Nothing, Nothing, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "2. Sửa điều chỉnh tăng nguyên giá tăng tài sản cố đinh", AddressOf V_Tang_F3, Nothing, Nothing, True, True))

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "3. Điều chỉnh giảm nguyên giá tài sản cố định", AddressOf V_Giam_F4, Nothing, Nothing, True, False), True)
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "4. Sửa điều chỉnh giảm nguyên giá tài sản cố đinh", AddressOf V_Giam_F3, Nothing, Nothing, True, True))

        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "5. Xóa điểu chỉnh Tăng/giảm nguyên giá tài sản cố đinh", AddressOf V_Tang_Giam_F8, Nothing, Nothing, True, True), True)

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
