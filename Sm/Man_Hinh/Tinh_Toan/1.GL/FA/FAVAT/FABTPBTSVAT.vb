Imports System.Drawing
Imports System.Windows.Forms
Public Class FABTPBTSVAT
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang, DtNam As DataTable
    Dim Dt_head, Dt_Master, Dt_Dmct As DataTable
    Dim Dv_head, Dv_Master, Dv_Dmct As DataView
    Dim DrDmct As DataRow
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub FABTPBTS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_LoadDatabase("1")
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master
        CyberFill.V_FillVoucher(MasterGRV, Me.Lan, Dv_head, Dv_Master, DrDmct)
        MasterGRV.OptionsView.ShowViewCaption = False
        MasterGRV.OptionsSelection.MultiSelect = False
        Me.MasterGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen

        V_AddHandler()
        Me.Text = Me.Para(11).Trim
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
        CyberSupport.Translaste(Me, M_LAN, True)
        Me.Text = Me.Text + " - Finance"
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_AddHandler()
        RemoveHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        RemoveHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        RemoveHandler ButtDelete.Click, AddressOf V_DeleteBT
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler CbbM_Thang.SelectedIndexChanged, AddressOf V_Thang_Name
        RemoveHandler CbbM_Nam.SelectedIndexChanged, AddressOf V_Thang_Name


        AddHandler MasterGRV.PopupMenuShowing, AddressOf MasterGRV_PopupMenuShowing
        AddHandler MasterGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        AddHandler ButtDelete.Click, AddressOf V_DeleteBT
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CbbM_Thang.SelectedIndexChanged, AddressOf V_Thang_Name
        AddHandler CbbM_Nam.SelectedIndexChanged, AddressOf V_Thang_Name

        MasterGRV.ViewCaption = ""
        MasterGRV.OptionsView.ShowViewCaption = False
    End Sub
    Private Sub V_Load()
        DtThang = CreateTableMonth()
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang, DtThang, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")
    End Sub
    Private Sub V_LoadDatabase(ByVal Status)
        Dim _Thang As String = CbbM_Thang.SelectedValue.ToString
        Dim _Nam As String = CbbM_Nam.SelectedValue.ToString
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_FABTPBTSVAT", Status & "#" & _Thang & "#" & _Nam & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        CyberSmodb.SetNotNullTable(DsTmp.Tables(0))
        If Status = "1" Then
            Dt_Master = DsTmp.Tables(0).Copy
            Dt_Dmct = DsTmp.Tables(1).Copy
            Dt_head = DsTmp.Tables(2).Copy

            Dv_Master = New DataView(Dt_Master)
            Dv_Dmct = New DataView(Dt_Dmct)
            Dv_head = New DataView(Dt_head)
            DrDmct = Dt_Dmct.Rows(0)
        Else
            Dim nCount As Integer = Dt_Master.Rows.Count - 1
            For i As Integer = nCount To 0 Step -1
                Dt_Master.Rows(i).Delete()

            Next
            Dt_Master.AcceptChanges()
            For i = 0 To DsTmp.Tables(0).Rows.Count - 1
                Dt_Master.ImportRow(DsTmp.Tables(0).Rows(i))
            Next
            Dt_Master.AcceptChanges()
        End If
    End Sub
    Private Function CreateTableMonth() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Thang")
        _Return.Columns.Add("Ten_Thang")
        _Return.Columns.Add("Ten_Thang2")
        _Return.Columns.Add("Default")
        Dim _Thang As String = ""
        Dim _Default As String = "0"

        For i As Integer = 1 To 12
            _Thang = Strings.Right("00" + i.ToString.Trim, 2).Trim
            If Now.Date.Month = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Thang.ToString, "Tháng " + _Thang, "Month " + _Thang, _Default)
        Next
        CreateTableMonth = _Return
    End Function
    Private Function CreateTableYear() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Nam")
        _Return.Columns.Add("Ten_Nam")
        _Return.Columns.Add("Ten_Nam2")
        _Return.Columns.Add("Default")

        Dim _CurYear As Integer = Now.Year

        Dim _Nam As String = ""
        Dim _Default As String = "0"

        For i As Integer = _CurYear - 10 To _CurYear + 10
            _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim

            If Now.Date.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
    Private Sub V_Thang_Name(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo bút toán", "Create"), AddressOf V_Nhan, Shortcut.F4, My.Resources.apply_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa bút toán", "Delete"), AddressOf V_DeleteBT, Shortcut.F8, My.Resources.Xoa_BT_16x16, True, False))
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Thang_Name, Shortcut.CtrlF5, My.Resources.refresh2_16x16, True, True), True)
        '--- End Tuy chọn
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        'End If
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
#Region "Valid"
#End Region
    Private Sub V_DeleteBT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Thang As String = CbbM_Thang.SelectedValue.ToString.Trim
        Dim _Nam As String = CbbM_Nam.SelectedValue.ToString.Trim

        If Not MsgBox("Bạn có muốn xóa khấu hao tháng " + _Thang + " năm " + _Nam, MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, Me.Sysvar("M_CYBER_VER")) = MsgBoxResult.Ok Then Exit Sub

        Dim _Title As String = "Đang thực hiện xoát bút toán khấu hao tài sản cố định"
        Dim _Title2 As String = "Đang thực hiện xoát bút toán khấu hao tài sản cố định"


        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, Me.Lan)
        Dim _DsDelete As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_FaBTDeleteVAT", "X#" & _Thang & "#" & _Nam & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        CyberSupport.V_MsgChk(_DsDelete.Tables(0), Me.Sysvar, Me.Lan)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim _Thang As String = CbbM_Thang.SelectedValue.ToString.Trim
        Dim _Nam As String = CbbM_Nam.SelectedValue.ToString.Trim


        If Not MsgBox("Bạn có muốn tạo bút toán hạch toán khấu hao tháng TSCĐ: tháng " + _Thang + " năm " + _Nam, MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Me.Sysvar("M_CYBER_VER")) = MsgBoxResult.Ok Then Exit Sub

        Dim _Title As String = "Đang thực hiện tạo bút toán khấu hao tài sản cố định"
        Dim _Title2 As String = "Đang thực hiện tạo bút toán khấu hao tài sản cố định"



        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title, _Title2, Me.Lan)
        '--Xoa truoc khi tao
        Dim _DsDelete As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_FaBTDeleteVAT", "S#" & _Thang & "#" & _Nam & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(_DsDelete.Tables(0), Me.Sysvar, Me.Lan) Then Exit Sub

        Dim _DsCreate As DataSet = Nothing
        For i As Integer = 0 To Dt_Master.Rows.Count - 1
            _DsCreate = Nothing
            Dim _strField As String = ""
            Dim _strValue As String = ""
            CyberSmodb.GetValueData(Dt_Master.Rows(i), _strField, _strValue)
            _DsCreate = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_FaBTCREATEVAT", (i + 1).ToString.Trim & "#" & _strField & "#" & _strValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Next
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        'If Not _DsCreate Is Nothing Then MsgBox(_DsCreate.Tables(0).Rows(0).Item("Note"), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Me.Sysvar("M_CYBER_VER"))
        If Not _DsCreate Is Nothing Then CyberSupport.V_MsgChk(_DsCreate.Tables(0), Me.Sysvar, Me.Lan)
        Me.Tag = ""
        'Me.Close()
    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
End Class
