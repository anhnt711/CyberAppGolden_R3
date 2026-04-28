Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Public Class FrmTien_Do_VitriDo_Vitri
#Region "Get or Set Property----------------------"
    Public M_Ma_Xe As String = ""
    Public M_Loai As String = ""
    Public M_kieu_Xem As String = ""
    Public Ma_Do_Return As String = ""
    Public Ten_do_Return As String = ""
    Public M_Ma_Do As String = ""
    Public M_Ma_Tang As String = ""
#End Region
#Region "Bien----------------------"
    Dim Dt_Master, Dt_head As New DataTable
    Dim Dv_Master, Dv_head As New DataView
    Dim EditMasterTag As New Cyber.Fill.CyberColumnGridView
#End Region
    Private Sub FrmChonVitri_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        Me.Text = "Chọn vị trí đỗ xe"
        V_LoadDatabase("1")

        V_Set_Not_Allow_Edit_Readonly(False)
        V_GetColumn()
        V_AddHander()
        MasterGRV.OptionsBehavior.Editable = True
        Dim FixCol As Integer = 4
        If FixCol < MasterGRV.Columns.Count And FixCol > 0 Then
            For iCol = 0 To FixCol
                MasterGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
            Next
        End If
        ButtExit.Focus()
    End Sub
    Private Sub V_Set_Not_Allow_Edit_Readonly(ByVal _b As Boolean)
        For Each col As DevExpress.XtraGrid.Columns.GridColumn In MasterGRV.Columns
            If col.ReadOnly = True Then
                col.OptionsColumn.AllowEdit = _b
            End If
        Next
    End Sub

    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_GetColumn()
        EditMasterTag.GetColumn(MasterGRV, "tag")
    End Sub
    Private Sub V_AddHander()
        CyberFill.V_GridviewRowCellStyle(MasterGRV)
        AddHandler ButtOK.Click, AddressOf V_Nhan
        If Not EditMasterTag.Column Is Nothing Then AddHandler EditMasterTag.EditColumn.EditValueChanged, AddressOf V_change_Tag
        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
        AddHandler ButtExit.Click, AddressOf V_Exit
        AddHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
    End Sub
    Private Sub V_Exit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_Refresh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabase("0")
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        'V_dangky
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh, Shortcut.F5, Nothing, True, True), True)
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exit, Nothing, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        'End If
    End Sub
    Private Sub V_change_Tag(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = MasterGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        MasterGRV.PostEditor()
        If Dv_Master.Item(iRow).Item("Tag") = 1 Then
            V_RemoveAll(iRow)
        End If
        Dv_Master.Table.AcceptChanges()
    End Sub
    Private Sub V_RemoveAll(ByVal i_not As Integer)
        For iRow = 0 To Dv_Master.Count - 1
            If Dt_Master.Columns.Contains("Tag") And iRow <> i_not Then
                Dv_Master.Item(iRow).BeginEdit()
                Dv_Master.Item(iRow).Item("Tag") = 0
                Dv_Master.Item(iRow).EndEdit()
            End If
        Next
        Dv_Master.Table.AcceptChanges()
    End Sub
#Region "Load - "
    Private Sub V_EditVoucherRo(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberFill.V_EditVoucher(M_LAN, Me.Para, Me.Sysvar, AppConn, MasterGRV)
    End Sub
 
    Private Sub V_LoadDatabase(ByVal Status As String)
        Dim DsDongSon As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_VitriDoxe_Load", Status + "#" + M_kieu_Xem + "#" + M_Loai + "#" & M_Ma_Xe.Trim & "#" & M_Ma_Tang & "#" & M_Ma_Do & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsDongSon.Tables.Count < 2 Then
            DsDongSon.Dispose()
            Exit Sub
        End If
        For i = 0 To DsDongSon.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsDongSon.Tables(i))
        Next
        If Status = "1" Then
            Dt_Master = DsDongSon.Tables(0)
            Dt_head = DsDongSon.Tables(1)
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
        CyberFill.V_FillVoucher(GRV, _M_lan, DvHeader, DvData)
        GRV.GridControl.DataSource = DvData
    End Sub
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, MasterGRV, Dt_Master, Me.Font, "Tag", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
#End Region
#Region "Tinh toan"
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i = 0 To Dt_Master.Rows.Count - 1
            If Dt_Master.Columns.Contains("Tag") And Dt_Master.Columns.Contains("Ma_Do") Then
                If Dt_Master.Rows(i).Item("Tag") = 1 Then
                    Ma_Do_Return = Dt_Master.Rows(i).Item("Ma_Do").ToString
                    Ten_do_Return = Dt_Master.Rows(i).Item("Ten_Do").ToString
                    Exit For
                End If
            End If
        Next
        If V_Vitri_Do_Check() Then
            Me.Save_OK = True
            Me.Close()
        End If
    End Sub
    Private Sub V_Ngay_ct(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabase("0")
    End Sub
#Region "Grid"
    Private Sub gridView_DoubleClick(ByVal sender As Object, ByVal e As EventArgs) Handles MasterGRV.DoubleClick
        Dim ea As DevExpress.Utils.DXMouseEventArgs = TryCast(e, DevExpress.Utils.DXMouseEventArgs)
        Dim view As GridView = TryCast(sender, GridView)
        Dim info As GridHitInfo = view.CalcHitInfo(ea.Location)
        If info.InRow OrElse info.InRowCell Then
            Dim colName As String = info.Column.FieldName
            Dim rowName As String = info.RowHandle
            Ma_Do_Return = Dt_Master.Rows(rowName).Item("Ma_Do").ToString
            Ten_do_Return = Dt_Master.Rows(rowName).Item("Ten_Do").ToString
        End If
        If V_Vitri_Do_Check() Then
            Me.Save_OK = True
            Me.Close()
        End If
    End Sub
    Private Function V_Vitri_Do_Check() As Boolean
        Dim DsTgUp As DataSet
        DsTgUp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_VitriDoXe_Check", M_kieu_Xem & "#" & M_Loai & "#" & M_Ma_Xe & "#" & Ma_Do_Return & "#" & M_Ma_Tang & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTgUp.Tables(0), Me.Sysvar, M_LAN) Then
            DsTgUp.Dispose()
            Return False
        End If
        Return True
    End Function
#End Region
End Class
