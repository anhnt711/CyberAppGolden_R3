Imports System.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Columns
Imports System.Windows.Forms
Imports System.IO

Public Class FrmMaintain
    Dim ProccessList As New Collection
    Dim osysvar As Collection
    Dim DtNam As DataTable
    Dim _Dt1, _Dt2, _Dt3, _Dt4 As DataTable
    Dim _DH1, _DH2, _DH3, _DH4 As DataTable

    Dim _Vt1, _Vt2, _Vt3, _Vt4 As DataView
    Dim _VH1, _VH2, _VH3, _VH4 As DataView
    Private Sub FrmMaintain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        AddHander()
        GridView1_PopupMenuShowing(GridView1, Nothing)
        GridView2_PopupMenuShowing(GridView2, Nothing)
        GridView3_PopupMenuShowing(GridView3, Nothing)
        GridView4_PopupMenuShowing(GridView4, Nothing)
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow
        Me.GridView2.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow
        Me.GridView3.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow
        Me.GridView4.Appearance.SelectedRow.BackColor = System.Drawing.Color.Yellow
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Me.GridView1.GridControl = Me.Detail1
        GridView1.OptionsView.ShowViewCaption = False
        GridView1.OptionsSelection.MultiSelect = False
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        osysvar = Me.Sysvar
        Chk00.Checked = True
        Chk01.Checked = True
        Chk02.Checked = True
        Chk03.Checked = True
        Chk04.Checked = True

        Lbprocess.Visible = False
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CmbNam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")
    End Sub
    Private Sub GridView1_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Xem chứng từ", AddressOf V_F3_1, Shortcut.F3, My.Resources.edit_16x16, True, False))
        '--- End Tuy chọn
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub GridView2_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Xem chứng từ", AddressOf V_F3_2, Shortcut.F3, My.Resources.edit_16x16, True, False))
        '--- End Tuy chọn
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub GridView3_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Xem chứng từ", AddressOf V_F3_3, Shortcut.F3, My.Resources.edit_16x16, True, False))
        '--- End Tuy chọn
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub GridView4_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then rowHandle = -1 Else rowHandle = e.HitInfo.RowHandle
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, "Xem chứng từ", AddressOf V_F3_4, Shortcut.F3, My.Resources.edit_16x16, True, False))
        '--- End Tuy chọn
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Exits, My.Resources.cancel_16x16, True, True)
        PopupMenuMasterGrid.ItemLinks.Add(MenuExits, True)
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
    End Sub

    Private Sub V_F3_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not _Vt1.Table.Columns.Contains("Stt_Rec") Then Exit Sub
        If Not _Vt1.Table.Columns.Contains("Ma_Ct") Then Exit Sub

        Dim iRow As Integer = -1
        iRow = GridView1.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = _Vt1.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec").ToString.Trim
        Dim _Ma_Ct As String = _Drv.Item("Ma_Ct").ToString.Trim
        If _Stt_Rec.Trim = "" Or _Ma_Ct.Trim = "" Then Exit Sub
        Dim _Process As Process = CyberSmlib.V_EditVoucher(_Stt_Rec, _Ma_Ct, Me.Para, AppConn, Me.Sysvar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
    Private Sub V_F3_2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not _Vt2.Table.Columns.Contains("Stt_Rec") Then Exit Sub
        If Not _Vt2.Table.Columns.Contains("Ma_Ct") Then Exit Sub

        Dim iRow As Integer = -1
        iRow = GridView2.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = _Vt2.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec").ToString.Trim
        Dim _Ma_Ct As String = _Drv.Item("Ma_Ct").ToString.Trim
        If _Stt_Rec.Trim = "" Or _Ma_Ct.Trim = "" Then Exit Sub
        Dim _Process As Process = CyberSmlib.V_EditVoucher(_Stt_Rec, _Ma_Ct, Me.Para, AppConn, Me.Sysvar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
    Private Sub V_F3_3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not _Vt3.Table.Columns.Contains("Stt_Rec") Then Exit Sub
        If Not _Vt3.Table.Columns.Contains("Ma_Ct") Then Exit Sub

        Dim iRow As Integer = -1
        iRow = GridView3.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = _Vt3.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec").ToString.Trim
        Dim _Ma_Ct As String = _Drv.Item("Ma_Ct").ToString.Trim
        If _Stt_Rec.Trim = "" Or _Ma_Ct.Trim = "" Then Exit Sub
        Dim _Process As Process = CyberSmlib.V_EditVoucher(_Stt_Rec, _Ma_Ct, Me.Para, AppConn, Me.Sysvar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
    Private Sub V_F3_4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not _Vt4.Table.Columns.Contains("Stt_Rec") Then Exit Sub
        If Not _Vt4.Table.Columns.Contains("Ma_Ct") Then Exit Sub

        Dim iRow As Integer = -1
        iRow = GridView4.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Drv As DataRowView = _Vt4.Item(iRow)
        Dim _Stt_Rec As String = _Drv.Item("Stt_Rec").ToString.Trim
        Dim _Ma_Ct As String = _Drv.Item("Ma_Ct").ToString.Trim
        If _Stt_Rec.Trim = "" Or _Ma_Ct.Trim = "" Then Exit Sub
        Dim _Process As Process = CyberSmlib.V_EditVoucher(_Stt_Rec, _Ma_Ct, Me.Para, AppConn, Me.Sysvar)
        If Not _Process Is Nothing Then ProccessList.Add(_Process)
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
    Private Sub FrmRepports_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        KillProce()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Title1 As String = "Chú ý!" & vbCrLf & "Khi chạy chức năng này thì nên đóng phần mềm tại các máy trạm khác để đảm bảo tính hiệu năng của máy chủ" & vbCrLf & "Bạn có tiếp thực hiện không?"
        Dim _Title2 As String = ""
        If MsgBox(_Title1, MsgBoxStyle.Critical + MsgBoxStyle.OkCancel, Sysvar("M_CYBER_VER")) = MsgBoxResult.Cancel Then Exit Sub

        Me.Save_OK = False
        Dim _DsTmp As DataSet
        _Title1 = "Đang thực hiện"
        _Title2 = "Đang thực hiện"

        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(_Title1, _Title2, M_LAN)
        _DsTmp = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Maintain", If(Chk00.Checked, "1#", "0#") & If(Chk01.Checked, "1#", "0#") & If(Chk02.Checked, "1#", "0#") & If(Chk03.Checked, "1#", "0#") & If(Chk04.Checked, "1#", "0#") & Me.CmbNam.SelectedValue.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()

        _Dt1 = _DsTmp.Tables(0)
        _DH1 = _DsTmp.Tables(1)

        _Dt2 = _DsTmp.Tables(2)
        _DH2 = _DsTmp.Tables(3)

        _Dt3 = _DsTmp.Tables(4)
        _DH3 = _DsTmp.Tables(5)

        _Dt4 = _DsTmp.Tables(6)
        _DH4 = _DsTmp.Tables(7)

        _Vt1 = New DataView(_Dt1)
        _Vt2 = New DataView(_Dt2)
        _Vt3 = New DataView(_Dt3)
        _Vt4 = New DataView(_Dt4)

        _VH1 = New DataView(_DH1)
        _VH2 = New DataView(_DH2)
        _VH3 = New DataView(_DH3)
        _VH4 = New DataView(_DH4)

        Detail1.DataSource = _Vt1
        Detail2.DataSource = _Vt2
        Detail3.DataSource = _Vt3
        Detail4.DataSource = _Vt4

        Me.GridView1.GridControl = Me.Detail1
        Me.GridView2.GridControl = Me.Detail2
        Me.GridView3.GridControl = Me.Detail3
        Me.GridView4.GridControl = Me.Detail4

        CyberFill.V_FillReports(GridView1, M_LAN, _VH1, _Vt1)
        CyberFill.V_FillReports(GridView2, M_LAN, _VH2, _Vt2)
        CyberFill.V_FillReports(GridView3, M_LAN, _VH3, _Vt3)
        CyberFill.V_FillReports(GridView4, M_LAN, _VH4, _Vt4)

    End Sub
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
    Private Sub GridView1_CustomDrawRowIndicator(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            'Nếu là dòng Indicator
            If e.RowHandle < 0 Then
                e.Info.ImageIndex = 0
                e.Info.DisplayText = String.Empty
            Else
                e.Info.ImageIndex = -1
                'Số thứ tự tăng dần
                e.Info.DisplayText = (e.RowHandle + 1).ToString()
            End If
            Dim _Size As SizeF = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font)
            'Lấy kích thước của vùng hiển thị Text
            Dim _Width As Int32 = Convert.ToInt32(_Size.Width) + 50
            'Tăng kích thước nếu Text vượt quá
            If (GridView1.IndicatorWidth < _Width) Then
                GridView1.IndicatorWidth = "40"
            End If
        End If
    End Sub
    Private Sub GridView2_CustomDrawRowIndicator(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView2.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            'Nếu là dòng Indicator
            If e.RowHandle < 0 Then
                e.Info.ImageIndex = 0
                e.Info.DisplayText = String.Empty
            Else
                e.Info.ImageIndex = -1
                'Số thứ tự tăng dần
                e.Info.DisplayText = (e.RowHandle + 1).ToString()
            End If
            Dim _Size As SizeF = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font)
            'Lấy kích thước của vùng hiển thị Text
            Dim _Width As Int32 = Convert.ToInt32(_Size.Width) + 50
            'Tăng kích thước nếu Text vượt quá
            If (GridView2.IndicatorWidth < _Width) Then
                GridView2.IndicatorWidth = "40"
            End If
        End If
    End Sub
    Private Sub GridView3_CustomDrawRowIndicator(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView3.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            'Nếu là dòng Indicator
            If e.RowHandle < 0 Then
                e.Info.ImageIndex = 0
                e.Info.DisplayText = String.Empty
            Else
                e.Info.ImageIndex = -1
                'Số thứ tự tăng dần
                e.Info.DisplayText = (e.RowHandle + 1).ToString()
            End If
            Dim _Size As SizeF = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font)
            'Lấy kích thước của vùng hiển thị Text
            Dim _Width As Int32 = Convert.ToInt32(_Size.Width) + 50
            'Tăng kích thước nếu Text vượt quá
            If (GridView3.IndicatorWidth < _Width) Then
                GridView3.IndicatorWidth = "40"
            End If
        End If
    End Sub
    Private Sub GridView4_CustomDrawRowIndicator(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs) Handles GridView4.CustomDrawRowIndicator
        If e.Info.IsRowIndicator Then
            'Nếu là dòng Indicator
            If e.RowHandle < 0 Then
                e.Info.ImageIndex = 0
                e.Info.DisplayText = String.Empty
            Else
                e.Info.ImageIndex = -1
                'Số thứ tự tăng dần
                e.Info.DisplayText = (e.RowHandle + 1).ToString()
            End If
            Dim _Size As SizeF = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font)
            'Lấy kích thước của vùng hiển thị Text
            Dim _Width As Int32 = Convert.ToInt32(_Size.Width) + 50
            'Tăng kích thước nếu Text vượt quá
            If (GridView4.IndicatorWidth < _Width) Then
                GridView4.IndicatorWidth = "40"
            End If
        End If
    End Sub
#Region "AddHandler"
    Private Sub AddHander()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmdDang_Ky_Dll.Click, AddressOf V_Dang_Ky_Dll
        RemoveHandler GridView1.PopupMenuShowing, AddressOf GridView1_PopupMenuShowing
        RemoveHandler GridView2.PopupMenuShowing, AddressOf GridView2_PopupMenuShowing
        RemoveHandler GridView3.PopupMenuShowing, AddressOf GridView3_PopupMenuShowing
        RemoveHandler GridView4.PopupMenuShowing, AddressOf GridView4_PopupMenuShowing


        AddHandler GridView1.PopupMenuShowing, AddressOf GridView1_PopupMenuShowing
        AddHandler GridView2.PopupMenuShowing, AddressOf GridView2_PopupMenuShowing
        AddHandler GridView3.PopupMenuShowing, AddressOf GridView3_PopupMenuShowing
        AddHandler GridView4.PopupMenuShowing, AddressOf GridView4_PopupMenuShowing


    End Sub
    Private Sub V_Exits(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Tag = ""
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
    Private Sub V_Dang_Ky_Dll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Command As String = "@echo off"
        Dim Instal As String = ""
        Dim FileName As String = Path.GetTempPath() & "\Cyber.Intall.bat"
        'Dim ListFileExe As String() = Directory.GetFiles(Application.StartupPath, "*.exe", SearchOption.TopDirectoryOnly)
        Dim ListFileDll As String() = Directory.GetFiles(Application.StartupPath, "*.dll", SearchOption.TopDirectoryOnly)
        If Not File.Exists(FileName) Then
            File.Create(FileName).Dispose()
        End If
        Command &= vbNewLine & "cd %windir%\Microsoft.NET\Framework\v4.0.30319"
        'For Each Str As String In ListFileExe
        '    If Not Str.Contains("DevExpress.") And Not Str.Contains("Stimulsoft.") Then Continue For

        '    Command &= vbNewLine & "Ngen uninstall " & Str
        '    Instal &= vbNewLine & "Ngen install " & Str
        'Next
        For Each Str As String In ListFileDll
            If Not Str.Contains("DevExpress.") And Not Str.Contains("Stimulsoft.") Then Continue For
            Command &= vbNewLine & "Ngen uninstall " & Str
            Instal &= vbNewLine & "Ngen install " & Str
        Next
        Command = Command & vbNewLine & Instal
        Dim objWriter As New StreamWriter(FileName, False)
        objWriter.WriteLine(Command)
        objWriter.Close()

        Dim psi As New ProcessStartInfo(FileName)
        psi.UseShellExecute = True
        psi.WorkingDirectory = "C:\Windows\System32"
        psi.Verb = "runas"
        Dim process As Process = process.Start(psi)
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
#End Region
#Region "V_AddHandler"
    Private Sub V_AddHandler()

    End Sub
    Private Sub V_AddHandler_System()
    End Sub
#End Region

End Class
