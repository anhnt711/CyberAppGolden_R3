Imports DevExpress.XtraScheduler
Imports DevExpress.Utils
Imports DevExpress.XtraScheduler.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing
Imports System.Windows.Forms

Public Class FrmTien_Do_Luu

#Region "Bien He thong"
    Dim CyberWork As New Cyber.Workprogress.Sys
    Dim CyberColor As New Cyber.Color.Sys
    Dim M_Ma_CT_DLH As String = "DLH"
    Dim M_Ma_CT_PKH As String = "PKH"
    Dim M_Ma_CT_PDC As String = "PDC"
    Dim M_Kieu_Xem As String = "KH" 'HEN/TIEN_DO----Hen nay tien do sua chua
    Dim M_Loai_SC As String = "1"
    Dim M_Stt_Rec_Ro As String = ""
    Dim M_Ma_Hs As String = ""
    Dim M_Ma_TTCP As String = ""
    '---------------------------------------------------------------------------------------------------------------
    Dim Dt_ConFigColor_Tien_Do, Dt_Time, Dt_CVDV, Dt_KTV, Dt_To, Dt_CD, Dt_Khoang, Dt_MucSBD, Dt_MucSDS, Dt_Buoc_Nhay, Dt_Do_Rong, Dt_Tang, Dt_Loai_Xem, Dt_Gio_Xem As DataTable
    Dim dt_configForm, dt_configTab, Dt_Right As DataTable
    Dim _TabVisible1 As Boolean = False, _TabVisible2 As Boolean = False, _TabVisible3 As Boolean = False, _TabVisible4 As Boolean = False, _TabVisible5 As Boolean = False, _TabVisible6 As Boolean = False, _TabVisible7 As Boolean = False, _TabVisible8 As Boolean = False, _TabVisible9 As Boolean = False, _TabVisible10 As Boolean = False, _TabVisible11 As Boolean = False, _TabVisible12 As Boolean = False
    Dim _TabRefresh1 As Boolean = False, _TabRefresh2 As Boolean = False, _TabRefresh3 As Boolean = False, _TabRefresh4 As Boolean = False, _TabRefresh5 As Boolean = False, _TabRefresh6 As Boolean = False, _TabRefresh7 As Boolean = False, _TabRefresh8 As Boolean = False, _TabRefresh9 As Boolean = False, _TabRefresh10 As Boolean = False, _TabRefresh11 As Boolean = False, _TabRefresh12 As Boolean = False
    Dim _TabFocus1 As Boolean = False, _TabFocus2 As Boolean = False, _TabFocus3 As Boolean = False, _TabFocus4 As Boolean = False, _TabFocus5 As Boolean = False, _TabFocus6 As Boolean = False, _TabFocus7 As Boolean = False, _TabFocus8 As Boolean = False, _TabFocus9 As Boolean = False, _TabFocus10 As Boolean = False, _TabFocus11 As Boolean = False, _TabFocus12 As Boolean = False
    '---------------------------------------------------------------------------------------------------------------
#End Region
    Private Sub FrmTienDo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_GetKieu_Xem_Loai_SC()
        '------------------------------------------------------
        V_LoadTabVisible()
        '------------------------------------------------------
        If _TabVisible1 Then V_TAB1_Load_Hen()
        '------------------------------------------------------
        If _TabVisible3 Then V_TAB3_Load_Tien_Do()
        '------------------------------------------------------
        If _TabVisible2 And Not _TabRefresh2 Then V_TAB2_Load_TiepDon()
        If _TabVisible2 And _TabRefresh2 And _TabFocus2 Then V_TAB2_Load_TiepDon()
        '------------------------------------------------------
        If _TabVisible4 And Not _TabRefresh4 Then V_TAB4_Load_HonHop()
        If _TabVisible4 And _TabRefresh4 And _TabFocus4 Then V_TAB4_Load_HonHop()
        '------------------------------------------------------
        If _TabVisible5 And Not _TabRefresh5 Then V_TAB5_Load_Dung()
        If _TabVisible5 And _TabRefresh5 And _TabFocus5 Then V_TAB5_Load_Dung()
        '------------------------------------------------------
        If _TabVisible6 And Not _TabRefresh6 Then V_TAB6_Load_ChayThu()
        If _TabVisible6 And _TabRefresh6 And _TabFocus6 Then V_TAB6_Load_ChayThu()
        '------------------------------------------------------
        If _TabVisible7 And Not _TabRefresh7 Then V_TAB7_Load_ThemGio()
        If _TabVisible7 And _TabRefresh7 And _TabFocus7 Then V_TAB7_Load_ThemGio()
        '------------------------------------------------------
        If _TabVisible8 And Not _TabRefresh8 Then V_TAB8_Load_Khac()
        If _TabVisible8 And _TabRefresh8 And _TabFocus8 Then V_TAB8_Load_Khac()
        '------------------------------------------------------
        If _TabVisible9 And Not _TabRefresh9 Then V_TAB9_Load_HieuSuat()
        If _TabVisible9 And _TabRefresh9 And _TabFocus9 Then V_TAB9_Load_HieuSuat()
        '------------------------------------------------------
        V_AddHandler_System()
        '------------------------------------------------------
        CmdDong_Lai.Visible = False
        CmdThu_Nho.Visible = False
        M_Ma_TTCP = CyberSupport.V_GetDefault_TTCP("PKH", M_Ma_Dvcs, M_User_Name, AppConn, CyberSmlib)
    End Sub
#Region "System"
    Private Sub V_FullScreen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Maximized
        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            CmdDong_Lai.Visible = False
            CmdThu_Nho.Visible = False
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            CmdDong_Lai.Visible = True
            CmdThu_Nho.Visible = True
        End If
    End Sub
    Private Sub V_LoadTabVisible()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Config", M_Kieu_Xem & "#" & M_Loai_SC & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dim itb As Integer = 0

        dt_configForm = Dstmp.Tables(itb).Copy
        itb = itb + 1
        '---------------------------------------------------------------------------------------------------------------------------------------
        If dt_configForm.Rows.Count > 0 And dt_configForm.Columns.Contains("Is_Max") Then If dt_configForm.Rows(0).Item("Is_Max").ToString.Trim = "1" Then Me.WindowState = FormWindowState.Maximized
        If dt_configForm.Rows.Count > 0 And dt_configForm.Columns.Contains("Is_FormBorderStyle") Then
            If dt_configForm.Rows(0).Item("Is_FormBorderStyle").ToString.Trim = "0" Then Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            If dt_configForm.Rows(0).Item("Is_FormBorderStyle").ToString.Trim = "1" Then Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            If dt_configForm.Rows(0).Item("Is_FormBorderStyle").ToString.Trim = "2" Then Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
            If dt_configForm.Rows(0).Item("Is_FormBorderStyle").ToString.Trim = "3" Then Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
            If dt_configForm.Rows(0).Item("Is_FormBorderStyle").ToString.Trim = "4" Then Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            If dt_configForm.Rows(0).Item("Is_FormBorderStyle").ToString.Trim = "5" Then Me.FormBorderStyle = Windows.Forms.FormBorderStyle.SizableToolWindow
        End If
        '---------------------------------------------------------------------------------------------------------------------------------------
        dt_configTab = Dstmp.Tables(itb).Copy
        itb = itb + 1
        For iRow As Integer = 0 To dt_configTab.Rows.Count - 1
            Dim TabCount As Integer = TabCVDV.TabPages.Count - 1
            For j As Integer = TabCount To 0 Step -1
                If TabCVDV.TabPages(j).Name.ToString.ToUpper.Trim = dt_configTab.Rows(iRow).Item("Tab_Name").ToString.ToUpper.Trim Then
                    TabCVDV.TabPages(j).Text = IIf(M_LAN = "V", dt_configTab.Rows(iRow).Item("Tab_Caption").ToString, dt_configTab.Rows(iRow).Item("Tab_Caption2").ToString).ToString.ToUpper
                    If dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim <> "1" Then
                        TabCVDV.TabPages.Remove(TabCVDV.TabPages(j))
                    End If
                    Exit For
                End If
            Next

            If dt_configTab.Rows(iRow).Item("Stt") = 1 Then _TabVisible1 = (dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 2 Then _TabVisible2 = (dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 3 Then _TabVisible3 = (dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 4 Then _TabVisible4 = (dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 5 Then _TabVisible5 = (dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 6 Then _TabVisible6 = (dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 7 Then _TabVisible7 = (dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 8 Then _TabVisible8 = (dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 9 Then _TabVisible9 = (dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 10 Then _TabVisible10 = (dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 11 Then _TabVisible11 = (dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 12 Then _TabVisible12 = (dt_configTab.Rows(iRow).Item("Is_Visible").ToString.Trim = "1")

            If dt_configTab.Rows(iRow).Item("Stt") = 1 And _TabVisible1 Then _TabRefresh1 = (dt_configTab.Rows(iRow).Item("Click_Refresh").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 2 And _TabVisible2 Then _TabRefresh2 = (dt_configTab.Rows(iRow).Item("Click_Refresh").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 3 And _TabVisible3 Then _TabRefresh3 = (dt_configTab.Rows(iRow).Item("Click_Refresh").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 4 And _TabVisible4 Then _TabRefresh4 = (dt_configTab.Rows(iRow).Item("Click_Refresh").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 5 And _TabVisible5 Then _TabRefresh5 = (dt_configTab.Rows(iRow).Item("Click_Refresh").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 6 And _TabVisible6 Then _TabRefresh6 = (dt_configTab.Rows(iRow).Item("Click_Refresh").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 7 And _TabVisible7 Then _TabRefresh7 = (dt_configTab.Rows(iRow).Item("Click_Refresh").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 8 And _TabVisible8 Then _TabRefresh8 = (dt_configTab.Rows(iRow).Item("Click_Refresh").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 9 And _TabVisible9 Then _TabRefresh9 = (dt_configTab.Rows(iRow).Item("Click_Refresh").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 10 And _TabVisible10 Then _TabRefresh10 = (dt_configTab.Rows(iRow).Item("Click_Refresh").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 11 And _TabVisible11 Then _TabRefresh11 = (dt_configTab.Rows(iRow).Item("Click_Refresh").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 12 And _TabVisible12 Then _TabRefresh12 = (dt_configTab.Rows(iRow).Item("Click_Refresh").ToString.Trim = "1")

            If dt_configTab.Rows(iRow).Item("Stt") = 1 Then _TabFocus1 = (dt_configTab.Rows(iRow).Item("TabFocus").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 2 Then _TabFocus2 = (dt_configTab.Rows(iRow).Item("TabFocus").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 3 Then _TabFocus3 = (dt_configTab.Rows(iRow).Item("TabFocus").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 4 Then _TabFocus4 = (dt_configTab.Rows(iRow).Item("TabFocus").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 5 Then _TabFocus5 = (dt_configTab.Rows(iRow).Item("TabFocus").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 6 Then _TabFocus6 = (dt_configTab.Rows(iRow).Item("TabFocus").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 7 Then _TabFocus7 = (dt_configTab.Rows(iRow).Item("TabFocus").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 8 Then _TabFocus8 = (dt_configTab.Rows(iRow).Item("TabFocus").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 9 Then _TabFocus9 = (dt_configTab.Rows(iRow).Item("TabFocus").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 10 Then _TabFocus10 = (dt_configTab.Rows(iRow).Item("TabFocus").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 11 Then _TabFocus11 = (dt_configTab.Rows(iRow).Item("TabFocus").ToString.Trim = "1")
            If dt_configTab.Rows(iRow).Item("Stt") = 12 Then _TabFocus12 = (dt_configTab.Rows(iRow).Item("TabFocus").ToString.Trim = "1")

        Next

        If _TabVisible1 And _TabFocus1 Then TabCVDV.SelectedTab = Tab1
        If _TabVisible2 And _TabFocus2 Then TabCVDV.SelectedTab = Tab2
        If _TabVisible3 And _TabFocus3 Then TabCVDV.SelectedTab = Tab3
        If _TabVisible4 And _TabFocus4 Then TabCVDV.SelectedTab = Tab4
        If _TabVisible5 And _TabFocus5 Then TabCVDV.SelectedTab = Tab5
        If _TabVisible6 And _TabFocus6 Then TabCVDV.SelectedTab = Tab6
        If _TabVisible7 And _TabFocus7 Then TabCVDV.SelectedTab = Tab7
        If _TabVisible8 And _TabFocus8 Then TabCVDV.SelectedTab = Tab8
        If _TabVisible9 And _TabFocus9 Then TabCVDV.SelectedTab = Tab9

        'If _TabVisible10 And _TabFocus10 Then TabCVDV.SelectedTab = Tab10
        'If _TabVisible11 And _TabFocus11 Then TabCVDV.SelectedTab = Tab11
        'If _TabVisible12 And _TabFocus12 Then TabCVDV.SelectedTab = Tab12

        Dt_Right = Dstmp.Tables(itb).Copy
        itb = itb + 1


        Dt_ConFigColor_Tien_Do = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_Time = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_CVDV = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_KTV = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_To = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_CD = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_Khoang = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_MucSBD = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_MucSDS = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_Buoc_Nhay = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_Do_Rong = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_Tang = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_Loai_Xem = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dt_Gio_Xem = Dstmp.Tables(itb).Copy
        itb = itb + 1

        '-------Các table Head của Tree
        Head_khoang_Tree = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Head_CVDV_Tree = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Head_CD_Tree = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Head_To_Tree = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Head_KTV_Tree = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Head_Xe_Tree = Dstmp.Tables(itb).Copy
        itb = itb + 1

        Dstmp.Dispose()

    End Sub
    Private Sub V_GetKieu_Xem_Loai_SC()
        Dim M_VT_PARA As Integer = CType(Para(0).Trim, Integer)
        Try
            M_Loai_SC = Para(M_VT_PARA + 2).Trim
        Catch ex As Exception
        End Try
        Try
            M_Kieu_Xem = Para(M_VT_PARA + 3).Trim
        Catch ex As Exception
        End Try
        Try
            M_Stt_Rec_Ro = Para(M_VT_PARA + 4).Trim
        Catch ex As Exception
        End Try
    End Sub
    Private Sub V_AddHandler_System()
        RemoveHandler TabCVDV.DrawItem, AddressOf V_DrawItem
        RemoveHandler TabCVDV.SelectedIndexChanged, AddressOf V_TagSelectedIndexChanged
        RemoveHandler CmbFullScreen.Click, AddressOf V_FullScreen
        RemoveHandler CmdDong_Lai.Click, AddressOf V_Quay_Ra
        RemoveHandler CmdThu_Nho.Click, AddressOf V_Thu_Nho

        TabCVDV.DrawMode = TabDrawMode.OwnerDrawFixed
        TabCVDV.Padding = New Point(20, 6)
        AddHandler TabCVDV.DrawItem, AddressOf V_DrawItem
        AddHandler TabCVDV.SelectedIndexChanged, AddressOf V_TagSelectedIndexChanged
        AddHandler CmbFullScreen.Click, AddressOf V_FullScreen
        AddHandler CmdDong_Lai.Click, AddressOf V_Quay_Ra
        AddHandler CmdThu_Nho.Click, AddressOf V_Thu_Nho
    End Sub
    Private Sub V_Tab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SelectedTab As String = sender.ToString

    End Sub
    Private Sub V_TagSelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim indexOfSelectedTab As Integer = TabCVDV.SelectedIndex
        Dim selectedTab As System.Windows.Forms.TabPage = TabCVDV.SelectedTab
        Select Case selectedTab.Name.Trim.ToUpper
            Case "TAB2".ToUpper
                If _TabRefresh2 Then V_TAB2_Load_TiepDon()
            Case "TAB4".ToUpper
                If _TabRefresh4 Then V_TAB4_Load_HonHop()
            Case "TAB5".ToUpper
                If _TabRefresh5 Then V_TAB5_Load_Dung()
            Case "TAB6".ToUpper
                If _TabRefresh6 Then V_TAB6_Load_ChayThu()
            Case "TAB7".ToUpper
                If _TabRefresh7 Then V_TAB7_Load_ThemGio()
            Case "TAB8".ToUpper
                If _TabRefresh8 Then V_TAB8_Load_Khac()
            Case "TAB9".ToUpper
                If _TabRefresh9 Then V_TAB9_Load_HieuSuat()
        End Select
    End Sub
    Private Sub V_DrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs)
        Dim SelectedTab As TabPage = sender.TabPages(e.Index)
        Dim HeaderRect As Rectangle = sender.GetTabRect(e.Index)
        Dim TextBrush As New SolidBrush(System.Drawing.Color.Black)
        Dim sf As New StringFormat()
        sf.Alignment = StringAlignment.Center
        sf.LineAlignment = StringAlignment.Center
        If Convert.ToBoolean(e.State And DrawItemState.Selected) Then
            Dim BoldFont As New Font(TabCVDV.Font.Name, sender.Font.Size, FontStyle.Bold)
            e.Graphics.FillRectangle(New SolidBrush(System.Drawing.Color.OrangeRed), e.Bounds)
            TextBrush = New SolidBrush(System.Drawing.Color.White)
            e.Graphics.DrawString(SelectedTab.Text, BoldFont, TextBrush, HeaderRect, sf)

        Else
            e.Graphics.DrawString(SelectedTab.Text, e.Font, TextBrush, HeaderRect, sf)
        End If
        TextBrush.Dispose()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_EnabledTime(ByRef Chk As CheckBox, ByVal _Cbb As ComboBox, ByRef _Timer As Timer, ByVal _Value As Decimal)
        Dim _Chk As Boolean = Chk.Checked
        If _Value <= 0 Then _Chk = False

        _Cbb.Enabled = _Chk
        _Timer.Enabled = _Chk

        If _Chk Then _Timer.Start() Else _Timer.Stop()
        If Not _Chk Then Return

        If _Value <= 0 Then _Value = 3000
        _Timer.Interval = _Value
    End Sub
    Private Sub V_Quay_Ra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
    Private Sub V_Thu_Nho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
    Private Sub V_LoadDatabasesALL(ByVal status As String, Optional ByVal _Stt_Rec As String = "", Optional ByVal _Stt_Rec_Ro As String = "")
        '---------------------------------------------------------------
        V_LoadData_Hen(status, _Stt_Rec, _Stt_Rec_Ro)
        '---------------------------------------------------------------
        V_LoadData_Cho_Lap_KH(status, _Stt_Rec, _Stt_Rec_Ro)
        '---------------------------------------------------------------
        V_LoadData_Tien_Do(status, _Stt_Rec, _Stt_Rec_Ro)
        '---------------------------------------------------------------
        If _TabVisible4 And Not _TabRefresh4 Then V_LoadData_HonHop(status, _Stt_Rec, _Stt_Rec_Ro)
        '---------------------------------------------------------------
    End Sub
    Private Sub V_LoadDatabasesALL(ByVal _Dt As DataTable)
        If _Dt Is Nothing Then Return
        If _Dt.Rows.Count = 0 Then Return
        If Not _Dt.Columns.Contains("Stt_Rec") And Not _Dt.Columns.Contains("Stt_Rec_Ro") Then Return
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        For i As Integer = 0 To _Dt.Rows.Count - 1
            If _Dt.Columns.Contains("Stt_Rec") Then _Stt_Rec = _Dt.Rows(i).Item("Stt_Rec").ToString.Trim
            If _Dt.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = _Dt.Rows(i).Item("Stt_Rec_Ro").ToString.Trim
            V_LoadDatabasesALL("0", _Stt_Rec, _Stt_Rec_Ro)
        Next
    End Sub
    Private Sub V_LoadData_Hen(ByVal _Dt As DataTable)
        If _Dt Is Nothing Then Return
        If _Dt.Rows.Count = 0 Then Return
        If Not _Dt.Columns.Contains("Stt_Rec") And Not _Dt.Columns.Contains("Stt_Rec_Ro") Then Return
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        For i As Integer = 0 To _Dt.Rows.Count - 1
            If _Dt.Columns.Contains("Stt_Rec") Then _Stt_Rec = _Dt.Rows(i).Item("Stt_Rec").ToString.Trim
            If _Dt.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = _Dt.Rows(i).Item("Stt_Rec_Ro").ToString.Trim
            V_LoadData_Hen("0", _Stt_Rec, _Stt_Rec_Ro)
        Next
    End Sub
    Private Sub V_LoadData_Cho_Lap_KH(ByVal _Dt As DataTable)
        If _Dt Is Nothing Then Return
        If _Dt.Rows.Count = 0 Then Return
        If Not _Dt.Columns.Contains("Stt_Rec") And Not _Dt.Columns.Contains("Stt_Rec_Ro") Then Return
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        For i As Integer = 0 To _Dt.Rows.Count - 1
            If _Dt.Columns.Contains("Stt_Rec") Then _Stt_Rec = _Dt.Rows(i).Item("Stt_Rec").ToString.Trim
            If _Dt.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = _Dt.Rows(i).Item("Stt_Rec_Ro").ToString.Trim
            V_LoadData_Cho_Lap_KH("0", _Stt_Rec, _Stt_Rec_Ro)
        Next
    End Sub
    Private Sub V_LoadData_Tien_Do(ByVal _Dt As DataTable)
        If _Dt Is Nothing Then Return
        If _Dt.Rows.Count = 0 Then Return
        If Not _Dt.Columns.Contains("Stt_Rec") And Not _Dt.Columns.Contains("Stt_Rec_Ro") Then Return
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        For i As Integer = 0 To _Dt.Rows.Count - 1
            If _Dt.Columns.Contains("Stt_Rec") Then _Stt_Rec = _Dt.Rows(i).Item("Stt_Rec").ToString.Trim
            If _Dt.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = _Dt.Rows(i).Item("Stt_Rec_Ro").ToString.Trim
            V_LoadData_Tien_Do("0", _Stt_Rec, _Stt_Rec_Ro)
        Next
    End Sub
#End Region

#Region "TAB1 - Hen Sua chua"
#Region "Khai bao bien"
    Dim _CP_DLH As String = "CP_WORKDLH"
    Dim Dt_Hen, Dt_ColFrozen_Hen, Dt_Head_Hen As DataTable
    Dim Dv_Hen, Dv_Head_Hen As DataView
    Dim Dt_Time_Hen, Dt_CVDV_Hen, Dt_To_Hen, Dt_CD_Hen, Dt_Khoang_Hen, Dt_MucSBD_Hen, Dt_MucSDS_Hen, Dt_Buoc_Nhay_Hen, Dt_Do_Rong_Hen, Dt_Tang_Hen, Dt_Loai_Xem_Hen, Dt_Gio_Xem_Hen As DataTable
#End Region
#Region "Load"
    Private Sub V_TAB1_Load_Hen()
        '------------------------------------------------------------------------------------------------------
        TxtM_Ngay_Ct_hen.Value = Now.Date
        '------------------------------------------------------------------------------------------------------
        V_GetAndFillData_Hen()
        '------------------------------------------------------------------------------------------------------
        V_LoadData_Hen("1", "", "")
        '------------------------------------------------------------------------------------------------------
        V_SetDeffault_HEN()
        '------------------------------------------------------------------------------------------------------
        V_AddHander_Hen()
        '------------------------------------------------------------------------------------------------------
        V_Auto_Data_Hen(New System.Object, New System.EventArgs)
        '------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub V_GetAndFillData_Hen()
        Dt_Time_Hen = Dt_Time.Copy
        Dt_CVDV_Hen = Dt_CVDV.Copy
        Dt_To_Hen = Dt_To.Copy
        Dt_CD_Hen = Dt_CD.Copy
        Dt_Khoang_Hen = Dt_Khoang.Copy

        Dt_MucSBD_Hen = Dt_MucSBD.Copy
        Dt_MucSDS_Hen = Dt_MucSDS.Copy

        Dt_Buoc_Nhay_Hen = Dt_Buoc_Nhay.Copy
        Dt_Do_Rong_Hen = Dt_Do_Rong.Copy
        Dt_Tang_Hen = Dt_Tang.Copy
        Dt_Loai_Xem_Hen = Dt_Loai_Xem.Copy
        Dt_Gio_Xem_Hen = Dt_Gio_Xem.Copy
        '------------------------------------------------------------------------------------------------------
        CyberFill.V_FillComBoxDefaul(CbbTime_Data_Hen, Dt_Time_Hen, "Tg", "Ten_Tg", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbCVDV_Hen, Dt_CVDV_Hen, "Ma_HS", "Ten_Hs", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbTo_Hen, Dt_To_Hen, "Ma_TO", "Ten_To", "Ngam_Dinh")
    End Sub
    Private Sub V_LoadData_Hen(ByVal status As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String)
        If status = "0" And Dt_Hen Is Nothing Then Return

        Dim _Dt As Date = TxtM_Ngay_Ct_hen.Value
        Dim _Filter As String = status
        _Filter = _Filter & "#" & M_Kieu_Xem
        _Filter = _Filter & "#" & M_Loai_SC
        _Filter = _Filter & "#" & _Stt_Rec
        _Filter = _Filter & "#" & ""
        _Filter = _Filter & "#" & ""
        _Filter = _Filter & "#" & _Dt.ToString("yyyyMMdd")
        _Filter = _Filter & "#" & _Dt.ToString("yyyyMMdd")
        _Filter = _Filter & "#" & ""
        _Filter = _Filter & "#" & M_Ma_Dvcs
        _Filter = _Filter & "#" & M_User_Name
        If Dt_Hen Is Nothing And status <> "1" Then Return
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, _CP_DLH, _Filter)
        If status.ToString.Trim = "1" Then
            Dt_Hen = New DataTable
            Dt_Head_Hen = New DataTable

            Dt_Hen = DsTmp.Tables(0).Copy
            Dt_ColFrozen_Hen = DsTmp.Tables(1).Copy
            Dt_Head_Hen = DsTmp.Tables(2).Copy

            Dv_Hen = New DataView(Dt_Hen)
            Dv_Head_Hen = New DataView(Dt_Head_Hen)

            CyberFill.V_FillReports(Master_HenGRV, M_LAN, Dv_Head_Hen, Dv_Hen)
            Master_Hen.DataSource = Dv_Hen
        Else
            If _Stt_Rec.Trim = "" Then
                Dt_Hen.Clear()
                Dt_Hen.Load(DsTmp.Tables(0).CreateDataReader)
                Dt_Hen.AcceptChanges()
            Else
                '----------------------------------------------
                If Not Dt_Hen Is Nothing Then CyberSmodb.DeleteDatatable(Dt_Hen, "Stt_Rec ='" + _Stt_Rec.Trim + "'")
                If Not Dt_Hen Is Nothing Then Dt_Hen.Load(DsTmp.Tables(0).CreateDataReader)
            End If
        End If
        V_Filter_Hen(New System.Object, New System.EventArgs)
        DsTmp.Dispose()
    End Sub
    Private Sub V_SetDeffault_HEN()
        If Dt_ColFrozen_Hen Is Nothing Then Return
        If Dt_ColFrozen_Hen.Rows.Count = 0 Then Return

        Dim _ColFrozen As Integer = -1
        If Dt_ColFrozen_Hen.Columns.Contains("ColFrozen") Then _ColFrozen = Dt_ColFrozen_Hen.Rows(0).Item("ColFrozen")
        CyberSupport.V_SetSortView(Dv_Hen, Dt_ColFrozen_Hen)

        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_HenGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_HenGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub V_AddHander_Hen()
        AddHandler ChkAuto_Data_Hen.CheckedChanged, AddressOf V_Auto_Data_Hen
        AddHandler CbbTime_Data_Hen.SelectedValueChanged, AddressOf V_Auto_Data_Hen
        AddHandler Timer_Data_hen.Tick, AddressOf V_Timer_Data_hen

        AddHandler CbbCVDV_Hen.SelectedIndexChanged, AddressOf V_Filter_Hen
        AddHandler CbbTo_Hen.SelectedIndexChanged, AddressOf V_Filter_Hen

        AddHandler ChkHen_SCC.CheckedChanged, AddressOf V_Filter_Hen
        AddHandler ChkHen_SBD.CheckedChanged, AddressOf V_Filter_Hen
        AddHandler ChkHen_SDS.CheckedChanged, AddressOf V_Filter_Hen

        AddHandler TxtM_Ngay_Ct_hen.TextChanged, AddressOf V_Ngay_Ct_Hen

        AddHandler Master_HenGRV.PopupMenuShowing, AddressOf Master_HenGRV_PopupMenuShowing
        AddHandler Master_HenGRV.RowCellStyle, AddressOf Master_HenGRV_RowCellStyle

    End Sub
#End Region
#Region "Su Kien"
    Private Sub V_Refresh_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_Hen("0", "", "")
    End Sub
    Private Sub V_Ngay_Ct_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Refresh_Hen(sender, e)
    End Sub
    Private Sub V_Filter_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---------------------------------
        If Not Dt_Hen.Columns.Contains("Ma_Hs") Then Return
        Dim _ma_hs As String = CyberWork.V_GetvalueCombox(CbbCVDV_Hen)
        '---------------------------------
        Dim _Filter As String = "1=1"
        If _ma_hs <> "" Then _Filter = _Filter + " AND Ma_HS = '" + _ma_hs.Trim + "'"
        If ChkHen_SCC.Checked Then _Filter = _Filter + " AND SCC = '1'"
        If ChkHen_SBD.Checked Then _Filter = _Filter + " AND SBD = '1'"
        If ChkHen_SDS.Checked Then _Filter = _Filter + " AND SDS = '1'"
        '----------------------------------------------------------------------------------------
        Dim _ma_To As String = CyberWork.V_GetvalueCombox(CbbTo_Hen)
        If _ma_To <> "" And Dt_Hen.Columns.Contains("ma_To") Then _Filter = _Filter + " AND ma_To = '" + _ma_To.Trim + "'"
        Try
            Dv_Hen.RowFilter = _Filter
        Catch ex As Exception

        End Try

    End Sub
    Private Sub V_Auto_Data_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _value As Decimal = CyberWork.V_StringToNumeric(CbbTime_Data_Hen)
        V_EnabledTime(ChkAuto_Data_Hen, CbbTime_Data_Hen, Timer_Data_hen, _value)
    End Sub
    Private Sub V_Timer_Data_hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not ChkAuto_Data_Hen.Enabled Then Exit Sub
        V_Refresh_Hen(sender, e)
    End Sub
    Private Sub Master_HenGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Tạo lịch hẹn", "Create appointment schedule"), AddressOf V_Tao_Hen, System.Windows.Forms.Shortcut.F4, My.Resources.apply_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Sửa lịch hẹn", "Edit appointment schedule"), AddressOf V_Sua_Hen, System.Windows.Forms.Shortcut.F3, My.Resources.edit_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem lịch hẹn", "View appointment schedule"), AddressOf V_Loc_Hen, System.Windows.Forms.Shortcut.F2, My.Resources.historyitem_16x16, True, True), True).BeginGroup = True

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Gọi xác nhận lịch hẹn", "Call"), AddressOf V_Hen_Call, System.Windows.Forms.Shortcut.F6, Nothing, True, True), True).BeginGroup = True

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Xác nhận lịch", "Approval"), AddressOf V_Xac_Nhan_Hen, System.Windows.Forms.Shortcut.F10, My.Resources.apply_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Gỡ nhận lịch", "UnApproval"), AddressOf V_Go_Xac_Nhan_Hen, System.Windows.Forms.Shortcut.F11, My.Resources.cancel_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Hủy hẹn", "Cancel"), AddressOf V_Huy_Hen, System.Windows.Forms.Shortcut.F8, My.Resources.cancel_16x16, True, True), True).BeginGroup = True

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "In phiếu hẹn", "Print"), AddressOf V_IN_Phieu_Hen, System.Windows.Forms.Shortcut.F7, My.Resources.preview_16x16, True, True), True).BeginGroup = False

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(M_LAN = "V", "Tra cứu thay đổi lịch hẹn", "History Edit"), AddressOf V_History_Hen, Nothing, My.Resources.historyitem_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Lịch sử hẹn", "History Repair"), AddressOf V_Xem_Lich_Su_Hen, Nothing, Nothing, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Lịch sử sửa chữa", "History Repair"), AddressOf V_Xem_LSSC_Hen, Nothing, Nothing, True, True), True).BeginGroup = True

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Export Excel", AddressOf V_ExportExcel_Hen, System.Windows.Forms.Shortcut.F12, My.Resources.exporttoxls_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_Hen, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)

    End Sub
    Private Sub Master_HenGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_HenGRV, Dt_Hen, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub V_Tao_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberWork As New Cyber.Workprogress.Sys
        Dim _Date As Date = TxtM_Ngay_Ct_hen.Value
        Dim Dt_Return As DataTable = CyberWork.V_Lich_Hen(M_Ma_TTCP, M_Ma_CT_DLH, "M", M_Kieu_Xem, M_Loai_SC, "", "", M_Ma_Hs, "", "", "", "", _Date, _Date, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

        Dim _Stt_Rec_Return As String = ""
        If Not Dt_Return Is Nothing Then If Dt_Return.Rows.Count > 0 And Dt_Return.Columns.Contains("Stt_Rec") Then _Stt_Rec_Return = Dt_Return.Rows(0).Item("Stt_Rec")
        If _Stt_Rec_Return.Trim = "" Then Return
        V_LoadDatabasesALL("0", _Stt_Rec_Return, "")
    End Sub
    Private Sub V_Sua_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_HenGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Hen.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return

        Dim CyberWork As New Cyber.Workprogress.Sys
        Dim _Date As Date = TxtM_Ngay_Ct_hen.Value

        Dim Dt_Return As DataTable = CyberWork.V_Lich_Hen(M_Ma_TTCP, M_Ma_CT_DLH, "S", M_Kieu_Xem, M_Loai_SC, _Stt_Rec, "", M_Ma_Hs, "", "", "", "", _Date, _Date, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

        Dim _Stt_Rec_Return As String = ""
        If Not Dt_Return Is Nothing Then If Dt_Return.Rows.Count > 0 And Dt_Return.Columns.Contains("Stt_Rec") Then _Stt_Rec_Return = Dt_Return.Rows(0).Item("Stt_Rec")
        If _Stt_Rec_Return.Trim = "" Then Return
        V_LoadDatabasesALL("0", _Stt_Rec_Return, "")

    End Sub
    Private Sub V_Loc_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.V_WorkView("CP_WorkDLH", "", "DANH SÁCH LỊCH HẸN SỬA CHỮA", True, M_Ma_Dvcs, M_User_Name, AppConn, Me.Sysvar, M_LAN, Me.Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_Xac_Nhan_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_HenGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Hen.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return
        If Not CyberWork.V_Hen_Thay_Doi_Post(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, "9", AppConn, Sysvar, M_LAN, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading) Then Return
        V_LoadDatabasesALL("0", _Stt_Rec, "")
    End Sub
    Private Sub V_Go_Xac_Nhan_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_HenGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Hen.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return
        If Not CyberWork.V_Hen_Thay_Doi_Post(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, "3", AppConn, Sysvar, M_LAN, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading) Then Return
        V_LoadDatabasesALL("0", _Stt_Rec, "")
    End Sub
    Private Sub V_Huy_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_HenGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Hen.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return
        If Not CyberWork.V_Hen_Thay_Doi_Post(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, "0", AppConn, Sysvar, M_LAN, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading) Then Return
        V_LoadDatabasesALL("0", _Stt_Rec, "")
    End Sub
    Private Sub V_IN_Phieu_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_HenGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Hen.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return

        Dim _Return As Boolean = CyberWork.V_Hen_Print(_Stt_Rec, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        If Not _Return Then Return

        'Dim DsPrint As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkDLH_Print", _Stt_Rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        'If Not CyberSupport.V_MsgChk(DsPrint.Tables(0), Me.Sysvar, M_LAN) Then
        '    DsPrint.Dispose()
        '    Return
        'End If

        'Dim _ReportName As String = ""
        'Dim _Title1 As String = "PHIẾU ĐẶT LỊCH HẸN"
        'Dim _Title2 As String = "PHIẾU ĐẶT LỊCH HẸN"
        'If DsPrint.Tables(0).Columns.Contains("Repo_Name") Then _ReportName = DsPrint.Tables(0).Rows(0).Item("Repo_Name").ToString.Trim()
        'If DsPrint.Tables(0).Columns.Contains("M_Title") Then _Title1 = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        'If DsPrint.Tables(0).Columns.Contains("M_Title") Then _Title2 = DsPrint.Tables(0).Rows(0).Item("M_Title").ToString.Trim
        'DsPrint.Tables.Remove(DsPrint.Tables(0))
        'CyberWork.V_Print(AppConn, M_Ma_Dvcs, M_LAN, "1", True, True, _ReportName, DsPrint, _Title1, _Title2, Me.Sysvar, Me.Para)
    End Sub
    Private Sub V_History_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_HenGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec As String = Dv_Hen.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec = "" Then Return
        Dim _StrKey As String = "" + _Stt_Rec.Trim + "#DmDlhen_CVDV#" + M_Ma_Dvcs + "#" + M_User_Name
        CyberSupport.V_WorkView("CP_SysGetHistorydeleandedit", _StrKey, "LỊCH SỬ TẠO MỚI VÀ SỬA LỊCH HẸN", False, M_Ma_Dvcs, M_User_Name, AppConn, Sysvar, M_LAN, Me.Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_Xem_Lich_Su_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec_Ro As String = ""

        If Not Dt_Hen Is Nothing Then
            Dim iRow As Integer = -1
            iRow = Master_HenGRV.GetFocusedDataSourceRowIndex
            If iRow >= 0 And Dt_Hen.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_Hen.Item(iRow).Item("Ma_Xe").ToString.Trim
            If iRow >= 0 And Dt_Hen.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_Hen.Item(iRow).Item("Ma_Ct").ToString.Trim
            If iRow >= 0 And Dt_Hen.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Hen.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim

        End If
        ''CyberSupport.V_Lich_Su_SC(_Ma_Xe, _Ma_Ct, _Stt_Rec_Ro, AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        If _Ma_Xe.Trim = "" Then Return
        Dim _StrLoc As String = M_Kieu_Xem + "#" + M_Loai_SC + "#" + "" + "#" + _Ma_Xe + "#" + "" + "#" + "19000101" + "#" + "20500101" + "#" + "" + "#" + M_Ma_Dvcs + "#" + M_User_Name
        CyberSupport.V_WorkView("CP_WorkDLH", _StrLoc, "DANH SÁCH LỊCH HẸN SỬA CHỮA", False, M_Ma_Dvcs, M_User_Name, AppConn, Me.Sysvar, M_LAN, Me.Para, Nothing, CyberSmlib, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
    Private Sub V_Xem_LSSC_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec_Ro As String = ""

        If Not Dt_Hen Is Nothing Then
            Dim iRow As Integer = -1
            iRow = Master_HenGRV.GetFocusedDataSourceRowIndex
            If iRow >= 0 And Dt_Hen.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_Hen.Item(iRow).Item("Ma_Xe").ToString.Trim
            If iRow >= 0 And Dt_Hen.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_Hen.Item(iRow).Item("Ma_Ct").ToString.Trim
            If iRow >= 0 And Dt_Hen.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Hen.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim

        End If
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, "HDK", "", AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
    Private Sub V_ExportExcel_Hen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberExport As New Cyber.Export.Sys
        Dim FileName As String = ""
        Dim Dt_Title As New DataTable
        Dt_Title.Columns.Add("Title1")
        Dt_Title.Columns.Add("Title2")
        Dt_Title.Rows.Add("Danh sách hẹn sửa chữa", "Danh sách hẹn sửa chữa")
        Dim Dt_TitleDetail As New DataTable
        Dt_TitleDetail.Columns.Add("Tu_Ngay")
        FileName = CyberExport.V_ExportToXlsx(AppConn, Master_HenGRV, New DataView(Dt_Title), New DataView(Dt_TitleDetail), Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub V_Hen_Call(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_HenGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        Dim _Stt_Rec_Hen As String = Dv_Hen.Item(iRow).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec_Hen = "" Then Return
        Dim _Stt_Rec_TD As String = ""

        Dim _Return As Boolean = CyberWork.V_Hen_Call(M_Kieu_Xem, M_Loai_SC, _Stt_Rec_Hen, _Stt_Rec_TD, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        If Not _Return Then Return
        V_LoadDatabasesALL("0", _Stt_Rec_Hen, "")

    End Sub
#End Region
#End Region
#Region "TAB3 - Bảng tiến độ"
#Region "Khai bao bien"
    Dim _CP_Name As String = ""
    Dim Dt_Ngay_Tien_Do As DataTable
    Dim Dt_Time_Tien_Do, Dt_CVDV_Tien_Do, Dt_To_Tien_Do, Dt_CD_Tien_Do, Dt_Khoang_Tien_Do, Dt_MucSBD_Tien_Do, Dt_MucSDS_Tien_Do, Dt_Buoc_Nhay_Tien_Do, Dt_Do_Rong_Tien_Do, Dt_Tang_Tien_Do, Dt_Loai_Xem_Tien_Do, Dt_Gio_Xem_Tien_Do As DataTable

    Dim M_StartHour, M_FinishHour As Integer
    Dim M_StartMINUTE, M_FinishMINUTE As Integer

    Dim M_Gio_Sang1 As Integer = 8
    Dim M_Phut_Sang1 As Integer = 0

    Dim M_Gio_Sang2 As Integer = 11
    Dim M_Phut_Sang2 As Integer = 30

    Dim M_Gio_Chieu1 As Integer = 13
    Dim M_Phut_Chieu1 As Integer = 30

    Dim M_Gio_Chieu2 As Integer = 17
    Dim M_Phut_Chieu2 As Integer = 0

    Dim M_Ngay_LimitInterval_Min As Date
    Dim M_Ngay_LimitInterval_Max As Date
    Dim M_Thu_Bay As String = "0"
    Dim M_Chu_Nhat As String = "1"
#End Region

#Region "-------Chung"
    Private Sub V_TAB3_Load_Tien_Do()

        TxtM_Ngay_Ct_KH_SCC.Value = Now.Date
        '------------------------------------------------------------------------------------------------------
        V_TAB3_Load_Cho_Lap_KH() '---Bảng chờ lập KH/xe sửa xong
        '------------------------------------------------------------------------------------------------------
        V_TAB3_Load_Tien_Do_KHSC() '---Bảng lập KH sửa chữa     
        '------------------------------------------------------------------------------------------------------
    End Sub
    Private Function V_GetFilter_Tien_Do(ByVal _DT_Filter As DataTable) As String
        Dim _StrFilter As String = "1=1"
        Dim _KeyFilterOr As String = ""

        If _DT_Filter Is Nothing Then Return _StrFilter
        Dim _Ma_Hs As String = CyberWork.V_GetvalueCombox(CbbCVDV_KH_SCC)
        If _DT_Filter.Columns.Contains("Ma_Hs") And _Ma_Hs <> "" Then _StrFilter = _StrFilter + " AND Ma_Hs = '" + _Ma_Hs.Trim + "'"

        Dim _Ma_Khoang As String = CyberWork.V_GetvalueCombox(CbbKhoang_KH_SCC)
        If _DT_Filter.Columns.Contains("Ma_Khoang") And _Ma_Khoang <> "" Then _StrFilter = _StrFilter + " AND Ma_khoang = '" + _Ma_Khoang.Trim + "'"

        Dim _Ma_CD As String = CyberWork.V_GetvalueCombox(CbbCD_KH_SCC)
        If _DT_Filter.Columns.Contains("Ma_CD") And _Ma_CD <> "" Then _StrFilter = _StrFilter + " AND Ma_CD = '" + _Ma_CD.Trim + "'"

        Dim _Tang As String = CyberWork.V_GetvalueCombox(CbbTang_KH_SCC)
        If _DT_Filter.Columns.Contains("Tang") And _Tang <> "" Then _StrFilter = _StrFilter + " AND Tang = '" + _Tang.Trim + "'"

        Dim _Ma_Xe As String = TxtMa_Xe_KH_SCC.Text
        If _DT_Filter.Columns.Contains("Ma_Xe") And _Ma_Xe <> "" Then _StrFilter = _StrFilter + " AND Ma_Xe LIKE '%" + _Ma_Xe.Trim + "%'"

        Dim _So_RO As String = TxtSo_RO_KH_SCC.Text
        If _DT_Filter.Columns.Contains("So_RO") And _So_RO <> "" Then _StrFilter = _StrFilter + " AND So_RO LIKE '%" + _So_RO.Trim + "%'"

        '------------------------------------------------
        Dim _Muc_SBD As String = CyberWork.V_GetvalueCombox(CbbMuc_SBD_KH_SCC)
        If ChkSBD_KH_SCC.Checked And _Muc_SBD.Trim <> "" Then
            If _DT_Filter.Columns.Contains("Muc_SBD") Then _StrFilter = _StrFilter + " AND Muc_SBD = '" + _Muc_SBD.Trim + "'"
        End If
        Dim _Muc_SDS As String = CyberWork.V_GetvalueCombox(CbbMuc_SDS_KH_SCC)
        If ChkSDS_KH_SCC.Checked And _Muc_SDS.Trim <> "" Then
            If _DT_Filter.Columns.Contains("Muc_SDS") Then _StrFilter = _StrFilter + " AND Muc_SDS = '" + _Muc_SDS.Trim + "'"
        End If
        '------------------------------------------------
        If ChkUu_Tien.Checked And _DT_Filter.Columns.Contains("Uu_Tien") Then _StrFilter = _StrFilter + " AND Uu_Tien = '1'"
        If ChkFV_KH_SCC.Checked And _DT_Filter.Columns.Contains("first_visit") Then _StrFilter = _StrFilter + " AND first_visit = '1'"
        If ChkDung_KH_SCC.Checked And _DT_Filter.Columns.Contains("Dung") Then _StrFilter = _StrFilter + " AND Dung = '1'"
        If ChkSDS_KH_SCC.Checked And _DT_Filter.Columns.Contains("SDS") Then _StrFilter = _StrFilter + " AND SDS = '1'"
        If ChkCho_Rua_KH_SCC.Checked And _DT_Filter.Columns.Contains("Cho_Rua") Then _StrFilter = _StrFilter + " AND Cho_Rua = '1'"
        If ChkDang_Rua_KH_SCC.Checked And _DT_Filter.Columns.Contains("Dang_Rua") Then _StrFilter = _StrFilter + " AND Dang_Rua = '1'"
        If ChkCho_Giao_KH_SCC.Checked And _DT_Filter.Columns.Contains("Cho_Giao") Then _StrFilter = _StrFilter + " AND Cho_Giao = '1'"
        If ChkGiao_Ngay_Kh_SCC.Checked And _DT_Filter.Columns.Contains("Giao_Ngay") Then _StrFilter = _StrFilter + " AND Giao_Ngay = '1'" 'Hadv bổ sung 08.06.2019

        If ChkEM60_KH_SCC.Checked And _DT_Filter.Columns.Contains("EM60") Then _StrFilter = _StrFilter + " AND Em60 = '1'"
        If ChkPM90_KH_SCC.Checked And _DT_Filter.Columns.Contains("Pm90") Then _StrFilter = _StrFilter + " AND Pm90 = '1'"
        If ChkSCL_KH_SCC.Checked And _DT_Filter.Columns.Contains("SCL") Then _StrFilter = _StrFilter + " AND SCL = '1'"

        If ChkIs_EM_KH_SCC.Checked And _DT_Filter.Columns.Contains("Is_Em") Then _StrFilter = _StrFilter + " AND Is_Em = '1'"
        If ChkIs_GJ_KH_SCC.Checked And _DT_Filter.Columns.Contains("Is_GJ") Then _StrFilter = _StrFilter + " AND Is_GJ = '1'"
        '------------------------------------------------        
        Return _StrFilter
    End Function
    Private Sub V_SetColorlabel_Tien_Do()
        For i As Integer = 0 To Dt_ConFigColor_Tien_Do.Rows.Count - 1
            V_SetColorlabel_Tien_Do(i, Dt_ConFigColor_Tien_Do.Rows(i))
        Next
    End Sub
    Private Sub V_SetColorlabel_Tien_Do(ByVal _i As Integer, ByVal _Dr As DataRow)
        If _Dr Is Nothing Then Return
        If _i > 19 Then Return
        Dim _J As Integer = _i + 1
        Dim _V As Boolean = True

        Select Case _J
            Case 1
                Lab_SCC1_01.Visible = _V
                Lab_SCC_01.Visible = True
                Lab_SCC1_01.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_01.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                ''If _Dr.Table.Columns.Contains("BackColor2") Then If Not _Dr.Item("BackColor2").ToString.Trim = "" Then Lab_SCC_01.BackColor2 = CyberColor.GetBackColor(_Dr.Item("BackColor2"))
                Lab_SCC_01.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_01.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 2
                Lab_SCC1_02.Visible = _V
                Lab_SCC_02.Visible = True
                Lab_SCC1_02.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_02.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_02.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_02.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 3
                Lab_SCC1_03.Visible = _V
                Lab_SCC_03.Visible = True
                Lab_SCC1_03.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_03.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_03.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_03.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 4
                Lab_SCC1_04.Visible = _V
                Lab_SCC_04.Visible = True
                Lab_SCC1_04.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_04.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_04.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_04.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 5
                Lab_SCC1_05.Visible = _V
                Lab_SCC_05.Visible = True
                Lab_SCC1_05.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_05.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_05.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_05.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 6
                Lab_SCC1_06.Visible = _V
                Lab_SCC_06.Visible = True
                Lab_SCC1_06.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_06.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_06.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_06.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 7
                Lab_SCC1_07.Visible = _V
                Lab_SCC_07.Visible = True
                Lab_SCC1_07.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_07.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_07.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_07.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 8
                Lab_SCC1_08.Visible = _V
                Lab_SCC_08.Visible = True
                Lab_SCC1_08.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_08.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_08.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_08.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 9
                Lab_SCC1_09.Visible = _V
                Lab_SCC_09.Visible = True
                Lab_SCC1_09.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_09.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_09.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_09.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 10
                Lab_SCC1_10.Visible = _V
                Lab_SCC_10.Visible = True
                Lab_SCC1_10.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_10.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_10.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_10.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 11
                Lab_SCC1_11.Visible = _V
                Lab_SCC_11.Visible = True
                Lab_SCC1_11.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_11.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_11.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_11.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 12
                Lab_SCC1_12.Visible = _V
                Lab_SCC_12.Visible = True
                Lab_SCC1_12.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_12.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_12.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_12.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 13
                Lab_SCC1_13.Visible = _V
                Lab_SCC_13.Visible = True
                Lab_SCC1_13.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_13.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_13.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_13.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 14
                Lab_SCC1_14.Visible = _V
                Lab_SCC_14.Visible = True
                Lab_SCC1_14.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_14.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_14.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_14.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 15
                Lab_SCC1_15.Visible = _V
                Lab_SCC_15.Visible = True
                Lab_SCC1_15.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_15.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_15.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_15.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 16
                Lab_SCC1_16.Visible = _V
                Lab_SCC_16.Visible = True
                Lab_SCC1_16.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_16.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_16.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_16.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 17
                Lab_SCC1_17.Visible = _V
                Lab_SCC_17.Visible = True
                Lab_SCC1_17.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_17.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_17.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_17.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 18
                Lab_SCC1_18.Visible = _V
                Lab_SCC_18.Visible = True
                Lab_SCC1_18.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_18.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_18.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_18.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 19
                Lab_SCC1_19.Visible = _V
                Lab_SCC_19.Visible = True
                Lab_SCC1_19.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_19.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_19.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_19.Tag = _Dr.Item("Ma_Color").ToString.Trim
            Case 20
                Lab_SCC1_20.Visible = _V
                Lab_SCC_20.Visible = True
                Lab_SCC1_20.Text = _Dr.Item(IIf(M_LAN = "V", "Ten_Color", "Ten_Color2"))
                Lab_SCC_20.BackColor = CyberColor.GetBackColor(_Dr.Item("BackColor"))
                Lab_SCC_20.ForeColor = CyberColor.GetForeColor(_Dr.Item("ForeColor"))
                Lab_SCC_20.Tag = _Dr.Item("Ma_Color").ToString.Trim
        End Select
    End Sub
#End Region

#Region "-------1: Chờ lập KH Sửa chữa Cho_Lap_LH/Xe sửa chữa xong"
    Dim _CP_Cho_Lap_KH As String = "CP_Work_Cho_Lap_KH"
    Dim Dt_ColFrozen_Cho_Lap_KH, Dt_Cho_Lap_KH_H, Dt_Cho_Lap_KH As DataTable
    Dim Dv_Cho_Lap_KH_H, Dv_Cho_Lap_KH As DataView

    Dim Dt_ColFrozen_Sua_Xong_KH, Dt_Sua_Xong_KH, Dt_Sua_Xong_KH_H As DataTable
    Dim Dv_Sua_Xong_KH, Dv_Sua_Xong_KH_H As DataView

    Private Sub V_TAB3_Load_Cho_Lap_KH()
        V_LoadData_Cho_Lap_KH("1", "", "")
        '---------------------------
        V_Fill_Cho_Lap_KH()
        V_Fill_Sua_Xong_KH()
        '---------------------------
        V_AddHander_Cho_Lap_KH()
        V_AddHander_Sua_Xong_KH()
        '---------------------------
        V_SetDeffault_Cho_Lap_KH()
        V_SetDeffault_Sua_Xong_KH()
        '---------------------------
    End Sub
    Private Sub V_Refresh_Cho_Lap_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_Cho_Lap_KH("0", "", "")
    End Sub
    Private Sub V_LoadData_Cho_Lap_KH(ByVal status As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String)
        Dim _Dt As Date = TxtM_Ngay_Ct_KH_SCC.Value
        If status <> "1" And Dt_Cho_Lap_KH Is Nothing Then Return

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, _CP_Cho_Lap_KH, status & "#" & M_Kieu_Xem & "#" & M_Loai_SC & "#" & _Stt_Rec & "#" & _Stt_Rec_Ro & "#" & _Dt.ToString("yyyyMMdd") & "#" & "" & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        For i = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next

        If DsTmp.Tables.Count = 0 Then Return

        If status.ToUpper.Trim = "1" Then
            Dt_Cho_Lap_KH = DsTmp.Tables(0).Copy
            Dt_Sua_Xong_KH = DsTmp.Tables(1).Copy

            Dt_Cho_Lap_KH_H = DsTmp.Tables(2).Copy
            Dt_Sua_Xong_KH_H = DsTmp.Tables(3).Copy

            Dt_ColFrozen_Cho_Lap_KH = DsTmp.Tables(4)
            Dt_ColFrozen_Sua_Xong_KH = DsTmp.Tables(5)

            Dv_Cho_Lap_KH = New DataView(Dt_Cho_Lap_KH)
            Dv_Cho_Lap_KH_H = New DataView(Dt_Cho_Lap_KH_H)

            Dv_Sua_Xong_KH = New DataView(Dt_Sua_Xong_KH)
            Dv_Sua_Xong_KH_H = New DataView(Dt_Sua_Xong_KH_H)

        Else
            If _Stt_Rec_Ro.Trim = "" And Not Dt_Cho_Lap_KH Is Nothing Then
                Dt_Cho_Lap_KH.Clear()
                Dt_Cho_Lap_KH.Load(DsTmp.Tables(0).CreateDataReader)

                Dt_Sua_Xong_KH.Clear()
                Dt_Sua_Xong_KH.Load(DsTmp.Tables(1).CreateDataReader)

            Else
                '----------------------------------------------
                If Not Dt_Cho_Lap_KH Is Nothing Then CyberSmodb.DeleteDatatable(Dt_Cho_Lap_KH, "Stt_Rec_Ro ='" + _Stt_Rec_Ro.Trim + "'")
                If Not Dt_Cho_Lap_KH Is Nothing Then Dt_Cho_Lap_KH.Load(DsTmp.Tables(0).CreateDataReader)

                If Not Dt_Sua_Xong_KH Is Nothing Then CyberSmodb.DeleteDatatable(Dt_Sua_Xong_KH, "Stt_Rec_Ro ='" + _Stt_Rec_Ro.Trim + "'")
                If Not Dt_Sua_Xong_KH Is Nothing Then Dt_Sua_Xong_KH.Load(DsTmp.Tables(1).CreateDataReader)

            End If
        End If
        'T_tinh_So_Xe()
        If Not Dt_Cho_Lap_KH Is Nothing Then Dt_Cho_Lap_KH.AcceptChanges()
        If Not Dt_Sua_Xong_KH Is Nothing Then Dt_Sua_Xong_KH.AcceptChanges()
        DsTmp.Dispose()
    End Sub
    Private Sub V_Fill_Cho_Lap_KH()
        If Dv_Cho_Lap_KH Is Nothing Then
            Master_Cho_Lap_KH.Visible = False
            SplitContainer_Left.Panel1Collapsed = True
            Return
        End If
        '------------------------------------------------------------------------------------
        If Dv_Cho_Lap_KH Is Nothing Then Return
        Master_Cho_Lap_KH.DataSource = Dv_Cho_Lap_KH
        Me.Master_Cho_Lap_KHGRV.GridControl = Me.Master_Cho_Lap_KH
        CyberFill.V_FillReports(Master_Cho_Lap_KHGRV, M_LAN, Dv_Cho_Lap_KH_H, Dv_Cho_Lap_KH)
        Master_Cho_Lap_KHGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
        Master_Cho_Lap_KHGRV.OptionsSelection.MultiSelect = False

    End Sub
    Private Sub V_Fill_Sua_Xong_KH()
        Dim _Visible_Sua_Xong As Boolean = True
        Dim _Visible_Color As Boolean = True

        If Dt_ConFigColor_Tien_Do Is Nothing Then _Visible_Color = False
        If Dv_Sua_Xong_KH Is Nothing Or Dv_Sua_Xong_KH_H Is Nothing Then _Visible_Sua_Xong = False Else If Dv_Sua_Xong_KH_H.Count = 0 Then _Visible_Sua_Xong = False

        If Not _Visible_Sua_Xong Then
            Master_Sua_Xong_KH.Visible = False
            For i As Integer = TabSua_Xong_Mau_XE.TabCount - 1 To 0 Step -1
                If TabSua_Xong_Mau_XE.TabPages(i).Name.ToString.ToUpper.Trim = "TabPage_Sua_Xong".ToUpper.Trim Then
                    TabSua_Xong_Mau_XE.TabPages.Remove(TabSua_Xong_Mau_XE.TabPages(i))
                    Exit For
                End If
            Next
        End If

        If Not _Visible_Color Then
            For i As Integer = TabSua_Xong_Mau_XE.TabCount - 1 To 0 Step -1
                If TabSua_Xong_Mau_XE.TabPages(i).Name.ToString.ToUpper.Trim = "TabPage_Sua_Xong".ToUpper.Trim Then
                    TabSua_Xong_Mau_XE.TabPages.Remove(TabSua_Xong_Mau_XE.TabPages(i))
                    Exit For
                End If
            Next
        End If
        If Not _Visible_Sua_Xong And Not _Visible_Color Then
            SplitContainer_Right.Panel2Collapsed = True
            Return
        End If
        If Not _Visible_Sua_Xong Then Return
        Dim _SplitterDistance As Integer = 50
        For i As Integer = 0 To Dv_Sua_Xong_KH_H.Count - 1
            _SplitterDistance = _SplitterDistance + Dv_Sua_Xong_KH_H.Item(i).Item("Field_Width")
        Next

        '------------------------------------------------------------------------------------
        If Dv_Sua_Xong_KH Is Nothing Then Return
        Master_Sua_Xong_KH.DataSource = Dv_Sua_Xong_KH
        Master_Sua_Xong_KHGRV.GridControl = Me.Master_Sua_Xong_KH

        CyberFill.V_FillReports(Master_Sua_Xong_KHGRV, M_LAN, Dv_Sua_Xong_KH_H, Dv_Sua_Xong_KH)

        Master_Sua_Xong_KHGRV.Appearance.SelectedRow.BackColor = System.Drawing.Color.YellowGreen
        Master_Sua_Xong_KHGRV.OptionsSelection.MultiSelect = False

    End Sub
    Private Sub V_SetDeffault_Cho_Lap_KH()
        If Dt_ColFrozen_Cho_Lap_KH Is Nothing Then Return
        If Dt_ColFrozen_Cho_Lap_KH.Rows.Count = 0 Then Return
        If Dt_Cho_Lap_KH_H Is Nothing Then Return
        If Dt_Cho_Lap_KH_H.Rows.Count = 0 Then Return

        Dim _ColFrozen As Integer = -1
        If Dt_ColFrozen_Cho_Lap_KH.Columns.Contains("ColFrozen") Then _ColFrozen = Dt_ColFrozen_Cho_Lap_KH.Rows(0).Item("ColFrozen")
        CyberSupport.V_SetSortView(Dv_Cho_Lap_KH, Dt_ColFrozen_Cho_Lap_KH.Rows(0))

        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_Cho_Lap_KHGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_Cho_Lap_KHGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub V_SetDeffault_Sua_Xong_KH()
        If Dt_ColFrozen_Sua_Xong_KH Is Nothing Then Return
        If Dt_ColFrozen_Sua_Xong_KH.Rows.Count = 0 Then Return
        If Dt_Sua_Xong_KH_H Is Nothing Then Return
        If Dt_Sua_Xong_KH_H.Rows.Count = 0 Then Return

        Dim _ColFrozen As Integer = -1
        If Dt_ColFrozen_Sua_Xong_KH.Columns.Contains("ColFrozen") Then _ColFrozen = Dt_ColFrozen_Sua_Xong_KH.Rows(0).Item("ColFrozen")
        CyberSupport.V_SetSortView(Dv_Sua_Xong_KH, Dt_ColFrozen_Sua_Xong_KH.Rows(0))

        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_Sua_Xong_KHGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_Sua_Xong_KHGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Dim _keotha2Grid As New GridviewDragDrop
    Private Sub V_AddHander_Cho_Lap_KH()
        If Dt_Cho_Lap_KH Is Nothing Then Return
        AddHandler Master_Cho_Lap_KHGRV.PopupMenuShowing, AddressOf Master_Cho_Lap_KHGRV_PopupMenuShowing
        AddHandler Master_Cho_Lap_KHGRV.RowCellStyle, AddressOf Master_Cho_Lap_KHGRV_RowCellStyle
        '---------------------------------------------------------------
        AddHandler TxtSo_Ro_Cho_Lap_KH.TextChanged, AddressOf V_Loc_Xe_Cho_Lap_KH
        AddHandler TxtMa_Xe_Cho_Lap_KH.TextChanged, AddressOf V_Loc_Xe_Cho_Lap_KH
        '---------------------------------------------------------------
        If M_Kieu_Xem.Trim <> "HEN" And M_Loai_SC.Trim = "1" Then
            _keotha2Grid = New GridviewDragDrop(Master_Cho_Lap_KH, SchedulerControl)
            AddHandler SchedulerControl.DragDrop, AddressOf Master_Cho_Lap_KH_DragDrop
        End If
    End Sub
    Private Sub V_AddHander_Sua_Xong_KH()
        If Dt_Sua_Xong_KH Is Nothing Then Return

        AddHandler Master_Sua_Xong_KHGRV.PopupMenuShowing, AddressOf Master_Sua_Xong_KHGRV_PopupMenuShowing
        AddHandler Master_Sua_Xong_KHGRV.RowCellStyle, AddressOf Master_Sua_Xong_KHGRV_RowCellStyle
        '---------------------------------------------------------------
    End Sub
    Private Sub Master_Cho_Lap_KHGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()
        If Not M_Kieu_Xem = "HEN" Then PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Tạo Kế hoạch sửa chữa", "Create repair plan"), AddressOf V_Tao_Tien_Do_Cho_Lap_KH, System.Windows.Forms.Shortcut.F4, My.Resources.apply_16x16, True, True), True).BeginGroup = False
        If Not M_Kieu_Xem = "HEN" And M_Loai_SC.Trim = "2" Then PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Tạo nhanh kế hoạch sửa chữa đồng sơn", "Create repair plan"), AddressOf V_Tao_Tien_Do_Cho_Lap_KHALL, Nothing, My.Resources.apply_16x16, True, True), True).BeginGroup = False

        If Not M_Kieu_Xem = "HEN" Then PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem Lệnh", "View"), AddressOf V_Preview_Cho_Lap_KH, System.Windows.Forms.Shortcut.F7, My.Resources.preview_16x16, True, True), True).BeginGroup = False

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Lịch sử sửa chữa", "History Repair"), AddressOf V_Xem_LSSC_Cho_Lap, Nothing, Nothing, True, True), True)
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_Cho_Lap_KH, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Tải dữ liệu", AddressOf V_XuatExcel_Cho_Lap_KH, System.Windows.Forms.Shortcut.F11, Nothing, True, True), True).BeginGroup = True
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub Master_Sua_Xong_KHGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()

        PopupMenu.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Đặt vị trí xe", "Location"), AddressOf V_Vi_Tri_Xe, System.Windows.Forms.Shortcut.F4, My.Resources.apply_16x16, True, True), True).BeginGroup = True
        PopupMenu.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem vị trí xe", "Set Location"), AddressOf V_Vi_Tri_Xe_Load, System.Windows.Forms.Shortcut.F10, Nothing, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Xem Lệnh", "View"), AddressOf V_Preview_Sua_Xong_KH, System.Windows.Forms.Shortcut.F7, My.Resources.preview_16x16, True, True), True).BeginGroup = True

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Lịch sử sửa chữa", "History Repair"), AddressOf V_Xem_LSSC_Sua_Xong, Nothing, Nothing, True, True), True)
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_Cho_Lap_KH, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Tải dữ liệu", AddressOf V_XuatExcel_Sua_Xong_KH, System.Windows.Forms.Shortcut.F11, Nothing, True, True), True).BeginGroup = True
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)
        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_Tao_Tien_Do_Cho_Lap_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_Cho_Lap_KHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        If Not Dt_Cho_Lap_KH.Columns.Contains("Stt_Rec_Ro") Or Not Dt_Cho_Lap_KH.Columns.Contains("So_Ro") Then Return
        V_Set_Auto_Refresh(False)


        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        Dim _So_Ro As String = ""
        Dim _ma_Xe As String = ""
        Dim _ma_khoang As String = ""
        Dim _Ma_CVDV As String = ""
        Dim _Ma_To As String = ""
        Dim _Ma_CD As String = ""
        Dim _ma_Ktv As String = ""


        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End

        V_GetFromSetScheduler(_Ngay_Bd, _Ngay_Kt, _Stt_Rec_Ro, _So_Ro, _ma_khoang, _Ma_CVDV, _Ma_To, _ma_Xe, _Ma_CD, _ma_Ktv)

        If Dt_Cho_Lap_KH.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Cho_Lap_KH.Item(iRow).Item("Stt_Rec_Ro")
        If Dt_Cho_Lap_KH.Columns.Contains("So_Ro") Then _So_Ro = Dv_Cho_Lap_KH.Item(iRow).Item("So_Ro")
        If Dt_Cho_Lap_KH.Columns.Contains("Ma_Xe") Then _ma_Xe = Dv_Cho_Lap_KH.Item(iRow).Item("Ma_Xe")
        If Dt_Cho_Lap_KH.Columns.Contains("_Ma_CVDV") Then _ma_Xe = Dv_Cho_Lap_KH.Item(iRow).Item("Ma_HS")

        If Dt_Cho_Lap_KH.Columns.Contains("Ngay_BD0") Then _Ngay_Bd = Dv_Cho_Lap_KH.Item(iRow).Item("Ngay_BD0")
        If Dt_Cho_Lap_KH.Columns.Contains("Ngay_KT0") Then _Ngay_Kt = Dv_Cho_Lap_KH.Item(iRow).Item("Ngay_KT0")
        '----------------------------
        V_Tao_Sua_Tien_Do_KH_SCC("M", M_Ma_CT_PKH, _Stt_Rec, _Stt_Rec_Ro, _So_Ro, _Ngay_Bd, _Ngay_Kt, _ma_khoang, _Ma_CVDV, _Ma_To, _ma_Xe, _Ma_CD, _ma_Ktv)

    End Sub
    Private Sub V_Tao_Tien_Do_Cho_Lap_KHALL(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim iRow As Integer = -1
        iRow = Master_Cho_Lap_KHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        If Not Dt_Cho_Lap_KH.Columns.Contains("Stt_Rec_Ro") Or Not Dt_Cho_Lap_KH.Columns.Contains("So_Ro") Then Return
        V_Set_Auto_Refresh(False)

        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        Dim _So_Ro As String = ""
        Dim _ma_Xe As String = ""
        Dim _ma_khoang As String = ""
        Dim _Ma_CVDV As String = ""
        Dim _Ma_To As String = ""
        Dim _Ma_CD As String = ""
        Dim _ma_Ktv As String = ""

        If Dt_Cho_Lap_KH.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Cho_Lap_KH.Item(iRow).Item("Stt_Rec_Ro")
        If Dt_Cho_Lap_KH.Columns.Contains("So_Ro") Then _So_Ro = Dv_Cho_Lap_KH.Item(iRow).Item("So_Ro")
        If Dt_Cho_Lap_KH.Columns.Contains("Ma_Xe") Then _ma_Xe = Dv_Cho_Lap_KH.Item(iRow).Item("Ma_Xe")
        If Dt_Cho_Lap_KH.Columns.Contains("_Ma_CVDV") Then _ma_Xe = Dv_Cho_Lap_KH.Item(iRow).Item("Ma_HS")



        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End


        If Dt_Cho_Lap_KH.Columns.Contains("Ngay_BD0") Then _Ngay_Bd = Dv_Cho_Lap_KH.Item(iRow).Item("Ngay_BD0")
        If Dt_Cho_Lap_KH.Columns.Contains("Ngay_KT0") Then _Ngay_Kt = Dv_Cho_Lap_KH.Item(iRow).Item("Ngay_KT0")
        '----------------------------
        V_Tao_Moi_SDSALL("M", M_Ma_CT_PKH, _Stt_Rec, _Stt_Rec_Ro, _So_Ro, _Ngay_Bd, _Ngay_Kt, _ma_khoang, _Ma_CVDV, _Ma_To, _ma_Xe, _Ma_CD, _ma_Ktv)

    End Sub
    Private Sub V_Preview_Cho_Lap_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_Cho_Lap_KHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        If Not Dt_Cho_Lap_KH.Columns.Contains("Stt_Rec_Ro") Then Return
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        If Dt_Cho_Lap_KH.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Cho_Lap_KH.Item(iRow).Item("Stt_Rec_Ro")
        V_Preview(_Stt_Rec, _Stt_Rec_Ro)
    End Sub
    Private Sub V_Preview_Sua_Xong_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        iRow = Master_Sua_Xong_KHGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        If Not Dt_Sua_Xong_KH.Columns.Contains("Stt_Rec_Ro") Then Return
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        If Dt_Sua_Xong_KH.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Sua_Xong_KH.Item(iRow).Item("Stt_Rec_Ro")
        V_Preview(_Stt_Rec, _Stt_Rec_Ro)
    End Sub
    Private Sub Master_Cho_Lap_KHGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_Cho_Lap_KHGRV, Dt_Cho_Lap_KH, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)

    End Sub
    Private Sub Master_Sua_Xong_KHGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_Sua_Xong_KHGRV, Dt_Sua_Xong_KH, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
    Private Sub V_Xem_LSSC_Cho_Lap(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec_Ro As String = ""
        If Not Dt_Cho_Lap_KH Is Nothing Then
            Dim iRow As Integer = -1
            iRow = Master_Cho_Lap_KHGRV.GetFocusedDataSourceRowIndex
            If iRow >= 0 And Dt_Cho_Lap_KH.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_Cho_Lap_KH.Item(iRow).Item("Ma_Xe").ToString.Trim
            If iRow >= 0 And Dt_Cho_Lap_KH.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_Cho_Lap_KH.Item(iRow).Item("Ma_Ct").ToString.Trim
            If iRow >= 0 And Dt_Cho_Lap_KH.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Cho_Lap_KH.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim

        End If
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, _Ma_Ct, _Stt_Rec_Ro, AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
    Private Sub V_Xem_LSSC_Sua_Xong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec_Ro As String = ""

        If Not Dt_Sua_Xong_KH Is Nothing Then
            Dim iRow As Integer = -1
            iRow = Master_Sua_Xong_KHGRV.GetFocusedDataSourceRowIndex
            If iRow >= 0 And Dt_Sua_Xong_KH.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_Sua_Xong_KH.Item(iRow).Item("Ma_Xe").ToString.Trim
            If iRow >= 0 And Dt_Sua_Xong_KH.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_Sua_Xong_KH.Item(iRow).Item("Ma_Ct").ToString.Trim
            If iRow >= 0 And Dt_Sua_Xong_KH.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Sua_Xong_KH.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim

        End If
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, _Ma_Ct, _Stt_Rec_Ro, AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub

    Private Sub V_XuatExcel_Cho_Lap_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")

        Dim _Title As String = "DANH SÁCH CHỜ LẬP KH SỬA CHỮA"
        Dim _Tu_Ngay As String = ""

        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXls(AppConn, Me.Master_Cho_Lap_KHGRV, _Dv_Title, Dv_Cho_Lap_KH, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name, "C:\CYBER_DsXE.xls")
    End Sub
    Private Sub V_XuatExcel_Sua_Xong_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Dt_Title As New DataTable
        _Dt_Title.Columns.Add("Title1")
        _Dt_Title.Columns.Add("Title2")
        _Dt_Title.Columns.Add("Tu_ngay")

        Dim _Title As String = "DANH SÁCH SỬA XONG - CHỜ GIAO XE"
        Dim _Tu_Ngay As String = ""

        _Tu_Ngay = _Tu_Ngay.ToUpper
        _Dt_Title.Rows.Add(_Title, _Title, _Tu_Ngay)
        Dim _Dv_Title As DataView = New DataView(_Dt_Title)
        If CyberExport Is Nothing Then CyberExport = New Cyber.Export.Sys
        CyberExport.V_ExportToXls(AppConn, Me.Master_Sua_Xong_KHGRV, _Dv_Title, Dv_Sua_Xong_KH, Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name, "C:\CYBER_DsXE.xls")
    End Sub

    Private Sub V_Loc_Xe_Cho_Lap_KH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Dt_Cho_Lap_KH Is Nothing Then Return
        Dim _StrFilterCho_Lap_KH As String = V_GetFilter_Tien_Do(Dt_Cho_Lap_KH)
        If Not TxtMa_Xe_Cho_Lap_KH.Text = "" And Dt_Cho_Lap_KH.Columns.Contains("Ma_Xe") Then _StrFilterCho_Lap_KH = _StrFilterCho_Lap_KH & " AND Ma_Xe Like '*" & TxtMa_Xe_Cho_Lap_KH.Text.Trim & "*'"
        If Not TxtSo_Ro_Cho_Lap_KH.Text = "" And Dt_Cho_Lap_KH.Columns.Contains("So_Ro") Then _StrFilterCho_Lap_KH = _StrFilterCho_Lap_KH & " AND So_Ro Like '*" & TxtSo_Ro_Cho_Lap_KH.Text.Trim & "*'"
        Try
            Dv_Cho_Lap_KH.RowFilter = _StrFilterCho_Lap_KH
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Master_Cho_Lap_KH_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
        Dim SchedulerControlDragDrop As New SchedulerControl
        SchedulerControlDragDrop = sender
        If Dt_Cho_Lap_KH Is Nothing Then Exit Sub

        Dim _Dr_Cho_Lap_KH As DataRow = TryCast(e.Data.GetData(GetType(DataRow)), DataRow)
        If _Dr_Cho_Lap_KH Is Nothing Then Exit Sub
        Dim pt As Point = SchedulerControlDragDrop.PointToClient(New Point(e.X, e.Y))
        Dim hitInfo As DevExpress.XtraScheduler.Drawing.SchedulerHitInfo = SchedulerControl.ActiveView.ViewInfo.CalcHitInfo(pt, True)
        If hitInfo.HitTest = DevExpress.XtraScheduler.Drawing.SchedulerHitTest.Cell Then
            Dim cell As DevExpress.XtraScheduler.Drawing.SelectableIntervalViewInfo = hitInfo.ViewInfo
            'Dim apt As Appointment = SchedulerStorage_KH_SCC.CreateAppointment(AppointmentType.Normal, cell.Interval.Start, TimeSpan.FromHours(4))
            Dim _Stt_Rec_Ro As String = _Dr_Cho_Lap_KH.Item("Stt_Rec_Ro")
            Dim _Value As String = cell.Resource.Id
            Dim _Ngay_BD As Date = SchedulerControl.SelectedInterval.Start
            Dim _Ngay_KT As Date = SchedulerControl.SelectedInterval.End

            Dim _Stt_Rec_Hen As String = ""
            Try
                Dim hi As DevExpress.XtraScheduler.Drawing.SchedulerHitInfo = SchedulerControl.ActiveView.CalcHitInfo(pt, False)
                Dim targetApt As Appointment = (TryCast(hi.ViewInfo, DevExpress.XtraScheduler.Drawing.AppointmentViewInfo)).Appointment
                _Stt_Rec_Hen = targetApt.Id
                If _Stt_Rec_Hen.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Stt_Rec_Hen = ""
            Catch ex As Exception
                _Stt_Rec_Hen = ""
            End Try
            If Not _Stt_Rec_Hen.Trim = "" Then
                If Dt_Data.Columns.Contains("Ma_CT") And Dt_Data.Columns.Contains("Stt_rec") Then
                    Dim _Drs As DataRow() = Dt_Data.Select("Stt_Rec = '" + _Stt_Rec_Hen + "'")
                    If _Drs.Length = 0 Then
                        _Stt_Rec_Hen = ""
                    Else
                        If _Drs(0).Item("ma_Ct").ToString.ToUpper.Trim <> M_Ma_CT_DLH.ToUpper.Trim Then _Stt_Rec_Hen = ""
                    End If
                End If
            End If
            _Stt_Rec_Hen = _Stt_Rec_Hen.Replace("_THUCHIEN", "")
            If Not _Stt_Rec_Hen.Trim = "" Then
                If Not V_Hen_To_KH_Drap_Drop(_Stt_Rec_Ro, _Stt_Rec_Hen) Then
                    V_Tao_DragDrop_KH_SCC(_Stt_Rec_Ro, _Value, _Ngay_BD, _Ngay_KT)
                End If
            Else
                V_Tao_DragDrop_KH_SCC(_Stt_Rec_Ro, _Value, _Ngay_BD, _Ngay_KT)
            End If
            ''V_Tao_DragDrop_KH_SCC(_Stt_Rec_Ro, _Value, _Ngay_BD, _Ngay_KT)
        End If
        CyberSmlib.FlushMemorySave()
    End Sub
    Private Sub V_Tao_DragDrop_KH_SCC(ByVal _Stt_Rec_Ro As String, ByVal _Value As String, ByVal _Ngay_BD As Date, ByVal _Ngay_KT As Date)
        V_Set_Auto_Refresh(False)
        Dim _Stt_rec As String = ""
        Dim _So_RO As String = ""
        Dim _ma_khoang As String = ""
        Dim _Ma_CVDV As String = ""
        Dim _Ma_To As String = ""
        Dim _Ma_Xe As String = ""
        Dim _Ma_CD As String = ""
        Dim _ma_Ct As String = M_Ma_CT_PKH
        Dim _Mode As String = "M"
        Dim _Ma_KTV As String = ""
        '----------------------------
        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)
        Select Case _Loai_Xem
            Case "01"
                _ma_khoang = _Value
            Case "02"
                _Ma_CVDV = _Value
            Case "03"
                _Ma_To = _Value
            Case "04"
                _Ma_CD = _Value
            Case "05"
                _Stt_Rec_Ro = _Value
            Case "06"
                _Ma_KTV = _Value
            Case Else
                _ma_khoang = _Value
        End Select
        Dim _Ngay_Ct As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Save_DragDrop", M_Kieu_Xem & "#" & M_Loai_SC.Trim & "#" & _ma_Ct & "#" & _Ngay_Ct.ToString("yyyyMMdd") & "#" & _
                                                                        _Stt_Rec_Ro & "#" & _ma_khoang + "#" & _Ma_CVDV & "#" & _Ma_To & "#" & _Ma_Xe & "#" & _Ma_CD & "#" & _Ma_KTV & "#" & _
                                                                          _Ngay_BD.ToString("yyyyMMdd HH:mm") & "#" & _Ngay_KT.ToString("yyyyMMdd HH:mm") & "#" & M_Ma_Dvcs & "#" + M_User_Name)


        If DsTmp.Tables.Count = 0 Then Return
        If DsTmp.Tables(0).Rows.Count = 0 Then Return

        For i As Integer = 0 To DsTmp.Tables.Count - 1
            CyberSmodb.SetNotNullTable(DsTmp.Tables(i))
        Next
        If Not DsTmp.Tables(0).Columns.Contains("Status") Or Not DsTmp.Tables(0).Columns.Contains("Msg") Or Not DsTmp.Tables(0).Columns.Contains("Note") Then Return


        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Return
        End If
        If Not DsTmp.Tables(0).Columns.Contains("Stt_Rec") Then Return
        Dim _Stt_Rec_Load As String = DsTmp.Tables(0).Rows(0).Item("Stt_Rec").ToString.Trim
        If _Stt_Rec_Load.Trim = "" Then Return
        V_LoadDatabasesALL("0", "", _Stt_Rec_Ro)
        DsTmp.Dispose()
    End Sub
#Region "Vi tri do xe"
    Private Sub V_Vi_Tri_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Sua_Xong_KH.Columns.Contains("Ma_Xe") Then Return
        iRow = Master_Sua_Xong_KHGRV.GetFocusedDataSourceRowIndex
        Dim _Ma_Xe As String = ""
        If iRow >= 0 Then _Ma_Xe = Dv_Sua_Xong_KH.Item(iRow).Item("Ma_Xe")
        Dim Dt_Vitri As DataTable = CyberWork.V_Do_Xe(_Ma_Xe, M_Kieu_Xem, M_Loai_SC, CbbTang_KH_SCC.SelectedValue, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

        If Dt_Vitri Is Nothing Then Return
        If Dt_Vitri.Rows.Count = 0 Then Return


        Dim _Ma_Xe_Up As String = ""
        Dim _Ma_Do_Up As String = ""
        Dim _Ten_Do_Up As String = ""

        If Dt_Vitri.Columns.Contains("Ma_Xe") Then _Ma_Xe_Up = Dt_Vitri.Rows(0).Item("Ma_Xe").ToString.Trim()
        If Dt_Vitri.Columns.Contains("Ma_Do") Then _Ma_Do_Up = Dt_Vitri.Rows(0).Item("Ma_Do").ToString.Trim()
        If Dt_Vitri.Columns.Contains("Ten_Do") Then _Ten_Do_Up = Dt_Vitri.Rows(0).Item("Ten_Do").ToString.Trim()
        If _Ma_Xe_Up = "" Or _Ma_Do_Up.Trim = "" Then Return

        Dim _Xe As Boolean = Dt_Sua_Xong_KH.Columns.Contains("Ma_Xe")
        Dim _Do As Boolean = Dt_Sua_Xong_KH.Columns.Contains("Ma_Do")
        Dim _Ten As Boolean = Dt_Sua_Xong_KH.Columns.Contains("Ten_Do")

        If Not _Xe Then Return
        If Not _Do Then Return

        For i As Integer = 0 To Dt_Sua_Xong_KH.Rows.Count - 1
            If Not Dt_Sua_Xong_KH.Rows(i).Item("Ma_Xe").ToString.Trim.ToUpper = _Ma_Xe_Up.Trim.ToUpper.Trim Then Continue For
            Dt_Sua_Xong_KH.Rows(i).BeginEdit()
            If _Do Then Dt_Sua_Xong_KH.Rows(i).Item("Ma_Do") = _Ma_Do_Up
            If _Ten Then Dt_Sua_Xong_KH.Rows(i).Item("Ten_Do") = _Ten_Do_Up
            Dt_Sua_Xong_KH.Rows(i).EndEdit()
        Next
        Dt_Sua_Xong_KH.AcceptChanges()

    End Sub
    Private Sub V_Vi_Tri_Xe_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = -1
        If Not Dt_Sua_Xong_KH.Columns.Contains("Ma_Xe") Then Return
        iRow = Master_Sua_Xong_KHGRV.GetFocusedDataSourceRowIndex
        Dim _Ma_Xe As String = ""
        If iRow >= 0 Then _Ma_Xe = Dv_Sua_Xong_KH.Item(iRow).Item("Ma_Xe")
        V_Vi_Tri_Xe(_Ma_Xe)
    End Sub
    Dim ProccessList As New Collection
    Private Sub V_Vi_Tri_Xe(ByVal _Ma_Xe As String)
        CyberWork.V_Do_Xe_Load(_Ma_Xe, "P", "3", "", AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        'Dim CyberReport As New Cyber.Reports.Sys
        'Dim strAddParar As String = "CP_RO_Do_Xe_Load#" + _Ma_Xe + "##" + M_Ma_Dvcs + "#" + M_User_Name
        'Dim _Process As Process = CyberSmlib.V_CallRun("Cyber.Reports.dll", Me.Para, strAddParar)
        'If Not _Process Is Nothing Then ProccessList.Add(_Process)
    End Sub
#End Region
#End Region

#Region "-------2: Bảng kế hoạch xưởng - Bảng tiến độ"
    Dim Dm_khoang, Dm_CVDV, Dm_CD, Dm_To, Dm_KTV, Dm_Xe As DataTable
    Dim Head_khoang_Tree, Head_CVDV_Tree, Head_CD_Tree, Head_To_Tree, Head_KTV_Tree, Head_Xe_Tree As DataTable
    Dim Dv_khoang, Dv_CVDV, Dv_CD, Dv_To, Dv_KTV, Dv_Xe As DataView
#Region "-------Load"
    Private Sub V_TAB3_Load_Tien_Do_KHSC()
        '------------------------------------------------------------------------------------------------------
        Tao_Ngam_Dinh()
        '------------------------------------------------------------------------------------------------------
        CyberSupport.V_SetTree(ResourcesTree)
        '------------------------------------------------------------------------------------------------------
        CyberSupport.V_LoadTimeLine(SchedulerControl)
        '------------------------------------------------------------------------------------------------------
        V_Ngay_Ct_Tien_Do()
        '------------------------------------------------------------------------------------------------------
        V_CyberSetTime_Tien_Do()
        '------------------------------------------------------------------------------------------------------
        V_LoadData_Tien_Do("1", "", "")
        '------------------------------------------------------------------------------------------------------
        V_SetSchedulerControl()
        '------------------------------------------------------------------------------------------------------
        V_Auto_Data_Tien_Do(New System.Object, New System.EventArgs)
        '------------------------------------------------------------------------------------------------------
        V_SetColorlabel_Tien_Do()
        '------------------------------------------------------------------------------------------------------
        V_AddHander_Tien_Do()
        '------------------------------------------------------------------------------------------------------
        V_Do_Rong(New System.Object, New System.EventArgs) 'Độ rộng của cột
        '------------------------------------------------------------------------------------------------------
        V_SetRowHeight() ' RowPage trong bảng tiến độ
        '------------------------------------------------------------------------------------------------------
        V_SetAppointmentHeight() ' Độ cao của chíp

    End Sub
    Private Sub Tao_Ngam_Dinh()
        Dt_Time_Tien_Do = Dt_Time.Copy
        Dt_CVDV_Tien_Do = Dt_CVDV.Copy
        Dt_To_Tien_Do = Dt_To.Copy
        Dt_CD_Tien_Do = Dt_CD.Copy
        Dt_Khoang_Tien_Do = Dt_Khoang.Copy

        Dt_MucSBD_Tien_Do = Dt_MucSBD.Copy
        Dt_MucSDS_Tien_Do = Dt_MucSDS.Copy

        Dt_Buoc_Nhay_Tien_Do = Dt_Buoc_Nhay.Copy
        Dt_Do_Rong_Tien_Do = Dt_Do_Rong.Copy
        Dt_Tang_Tien_Do = Dt_Tang.Copy
        Dt_Loai_Xem_Tien_Do = Dt_Loai_Xem.Copy
        Dt_Gio_Xem_Tien_Do = Dt_Gio_Xem.Copy

        '------------------------------------------------------------------------------------------------------
        CyberFill.V_FillComBoxDefaul(CbbTime_Data_KH_SCC, Dt_Time_Tien_Do, "Tg", "Ten_Tg" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbCVDV_KH_SCC, Dt_CVDV_Tien_Do, "Ma_HS", "Ten_Hs", "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbTo_KH_SCC, Dt_To_Tien_Do, "Ma_TO", "Ten_To" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbCD_KH_SCC, Dt_CD_Tien_Do, "Ma_CD", "Ten_CD" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbKhoang_KH_SCC, Dt_Khoang_Tien_Do, "Ma_Khoang", "Ten_Khoang" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")

        CyberFill.V_FillComBoxDefaul(CbbMuc_SBD_KH_SCC, Dt_MucSBD_Tien_Do, "Muc_SBD", "ten_SBD" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbMuc_SDS_KH_SCC, Dt_MucSDS_Tien_Do, "Muc_SDS", "ten_SDS" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")

        CyberFill.V_FillComBoxDefaul(CbbMa_BN_KH_SCC, Dt_Buoc_Nhay_Tien_Do, "Ma_BN", "Ma_BN" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbDo_Rong_KH_SCC, Dt_Do_Rong_Tien_Do, "Ma_Width", "Ten_Width" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")

        CyberFill.V_FillComBoxDefaul(CbbTang_KH_SCC, Dt_Tang_Tien_Do, "Tang", "Ten_Tang" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbLoai_Xem_KH_SCC, Dt_Loai_Xem_Tien_Do, "Loai", "Ten_Loai" + IIf(M_LAN = "V", "", "2"), "Ngam_Dinh")
        CyberFill.V_FillComBoxDefaul(CbbGio_Xem, Dt_Gio_Xem_Tien_Do, "Gio_Xem", IIf(M_LAN = "V", "Ten_Xem", "Ten2_Xem"), "Ngam_Dinh")
        '------------------------------------------------------------------------------------------------------

        Dm_khoang = CyberWork.V_GetTbRowEmpty(Dt_Khoang, "Ma_Khoang")
        Dm_CVDV = CyberWork.V_GetTbRowEmpty(Dt_CVDV, "Ma_Hs")
        Dm_KTV = CyberWork.V_GetTbRowEmpty(Dt_KTV, "Ma_KTV")

        Dm_CD = CyberWork.V_GetTbRowEmpty(Dt_CD, "Ma_CD")
        Dm_To = CyberWork.V_GetTbRowEmpty(Dt_To, "Ma_To")
        Dm_Xe = CyberWork.V_GetTbRowEmpty(Dm_Xe, "Stt_Rec_Ro")

        CyberWork.V_GetDataview(Dm_khoang, Dv_khoang)
        CyberWork.V_GetDataview(Dm_CVDV, Dv_CVDV)
        CyberWork.V_GetDataview(Dm_CD, Dv_CD)
        CyberWork.V_GetDataview(Dm_To, Dv_To)
        CyberWork.V_GetDataview(Dm_KTV, Dv_KTV)
        CyberWork.V_GetDataview(Dm_Xe, Dv_Xe)
        '------------------------------------------------------------------------------------------------------
    End Sub
    Private Sub V_Refresh_Tien_Do_KHSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatabasesALL("0", "", "")
    End Sub
#End Region
#Region "AddHander"
    Private Sub V_AddHander_Tien_Do()
        '-------------Menu
        AddHandler SchedulerControl.PopupMenuShowing, AddressOf V_PopupMenu_KH_SCC
        AddHandler SchedulerControl.EditAppointmentFormShowing, AddressOf CyberWork.V_Lap_F3F4
        AddHandler SchedulerControl.DoubleClick, AddressOf V_Sua_Tien_Do_KH_SCC
        '------------------------------------------------------------------------------------------------------------------------------------------------------------
        AddHandler SchedulerControl.CustomDrawTimeIndicator, AddressOf CyberSupport.SchedulerControl_CustomDrawTimeIndicator '--Đường thời gian chạy (Màu đỏ)
        AddHandler SchedulerControl.CustomDrawTimeCell, AddressOf V_CustomDrawTimeCell ' --Đường xanh khoảng giữa các giờ chặn + màu của dòng trên bảng tiến độ
        AddHandler SchedulerControl.CustomDrawDayHeader, AddressOf CyberSupport.schedulerControl_CustomDrawDayHeader ' --Bôi màu Head ngày trên cùng: VD 16-03
        AddHandler SchedulerControl.CustomDrawResourceHeader, AddressOf scheduler_CustomDrawResourceHeader ' --Set Màu, cờ, Chữ (Bold,Italic,Underline) của Head dòng : VD Tên Khoang)
        AddHandler SchedulerControl.InitAppointmentImages, AddressOf SchedulerControl_InitAppointmentImages 'Cờ trên chíp
        AddHandler SchedulerControl.CustomDrawAppointmentBackground, AddressOf SchedulerControl_CustomDrawAppointmentBackground '---Border chíp
        AddHandler SchedulerControl.AppointmentViewInfoCustomizing, AddressOf V_AppointmentViewInfoCustomizing '---backColor/ForeColor tren chíp

        '-------------keo tha - chuyen khoang
        AddHandler SchedulerControl.AppointmentDrop, AddressOf V_SchedulerControl_AppointmentDrop
        AddHandler SchedulerControl.AppointmentResized, AddressOf V_SchedulerControl_AppointmentResized
        '------------------------------------------------------------------------------------------------------------------------------------------------------------
        '-------------Footer/Tree
        V_AddHander_Tien_Do_Footer()
        V_AddHander_Tien_Do_Tree_ToolTip()

    End Sub

    Private Sub V_AddHander_Tien_Do_Footer()
        '-------------Ngày,Giờ xem,Loai_Xe,Dộ rộng, bước nhảy
        AddHandler TxtM_Ngay_Ct_KH_SCC.TextChanged, AddressOf V_Ngay_Ct_Tien_Do
        AddHandler CbbGio_Xem.SelectedIndexChanged, AddressOf V_Gio_Xem
        AddHandler CbbLoai_Xem_KH_SCC.SelectedValueChanged, AddressOf V_Loai_Xem
        AddHandler CbbMa_BN_KH_SCC.SelectedValueChanged, AddressOf V_Buoc_Nhay
        AddHandler CbbDo_Rong_KH_SCC.SelectedValueChanged, AddressOf V_Do_Rong
        '-------------Timer

        AddHandler ChkAuto_Data_KH_SCC.CheckedChanged, AddressOf V_Auto_Data_Tien_Do
        AddHandler CbbTime_Data_KH_SCC.SelectedValueChanged, AddressOf V_Auto_Data_Tien_Do
        AddHandler Timer_Data_KH_SC.Tick, AddressOf V_Timer_Data

        AddHandler Timer_PercentComplete.Tick, AddressOf V_Timer_PercentComplete
        '-------------Filter
        AddHandler CbbTang_KH_SCC.SelectedValueChanged, AddressOf V_Filter_KHSC
        AddHandler TxtMa_Xe_KH_SCC.TextChanged, AddressOf V_Filter_KHSC
        AddHandler TxtSo_RO_KH_SCC.TextChanged, AddressOf V_Filter_KHSC
        AddHandler CbbMuc_SBD_KH_SCC.SelectedIndexChanged, AddressOf V_Filter_KHSC
        AddHandler CbbMuc_SDS_KH_SCC.SelectedIndexChanged, AddressOf V_Filter_KHSC
        AddHandler CbbCVDV_KH_SCC.SelectedValueChanged, AddressOf V_Filter_KHSC
        AddHandler CbbKhoang_KH_SCC.SelectedValueChanged, AddressOf V_Filter_KHSC
        AddHandler CbbTo_KH_SCC.SelectedValueChanged, AddressOf V_Filter_KHSC
        AddHandler CbbCD_KH_SCC.SelectedValueChanged, AddressOf V_Filter_KHSC


        AddHandler ChkFV_KH_SCC.Click, AddressOf V_Filter_KHSC
        AddHandler ChkDung_KH_SCC.Click, AddressOf V_Filter_KHSC
        AddHandler ChkSDS_KH_SCC.Click, AddressOf V_Filter_KHSC
        AddHandler ChkCho_Rua_KH_SCC.Click, AddressOf V_Filter_KHSC
        AddHandler ChkDang_Rua_KH_SCC.Click, AddressOf V_Filter_KHSC
        AddHandler ChkCho_Giao_KH_SCC.Click, AddressOf V_Filter_KHSC
        AddHandler ChkGiao_Ngay_Kh_SCC.Click, AddressOf V_Filter_KHSC
        AddHandler ChkEM60_KH_SCC.Click, AddressOf V_Filter_KHSC
        AddHandler ChkPM90_KH_SCC.Click, AddressOf V_Filter_KHSC
        AddHandler ChkSCL_KH_SCC.Click, AddressOf V_Filter_KHSC

        AddHandler ChkSBD_KH_SCC.Click, AddressOf V_Filter_KHSC
        AddHandler ChkIs_EM_KH_SCC.Click, AddressOf V_Filter_KHSC
        AddHandler ChkIs_GJ_KH_SCC.Click, AddressOf V_Filter_KHSC

        '---Nut lenh
        AddHandler buttRemove_Filter.Click, AddressOf V_Remove_Filter
        AddHandler LabLock.Click, AddressOf V_Lock_Data
        AddHandler CmdRefresh_KH_SCC.Click, AddressOf V_Refresh_Tien_Do_KHSC
        AddHandler CmdUp_TG_GX_KH_SCC.Click, AddressOf V_UP_TG_TX_KH_SCC
        AddHandler LabTotal.Click, AddressOf Label_Xem_BC_KH_SCC

    End Sub
    Private Sub V_AddHander_Tien_Do_Tree_ToolTip()
        AddHandler ResourcesTree.CustomDrawNodeCell, AddressOf ResourcesTree_CustomDrawNodeCell
        AddHandler ToolTipController1.BeforeShow, AddressOf ToolTipController_BeforeShow
    End Sub
    Private Sub V_PopupMenu_KH_SCC(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.PopupMenuShowingEventArgs)

        Dim scheduler As DevExpress.XtraScheduler.SchedulerControl = CType(sender, DevExpress.XtraScheduler.SchedulerControl)
        Dim _Stt_Rec As String = ""
        If scheduler.SelectedAppointments.Count > 0 Then
            Try
                _Stt_Rec = scheduler.SelectedAppointments(0).Id.ToString
            Catch ex As Exception
            End Try
        End If
        e.Menu.Items.Clear()
        Dim rowHandle As Integer = 0
        PopupMenuSchedulerControl.ItemLinks.Clear()
        '-----------------
        If Not M_Kieu_Xem = "HEN" Then PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo Kế hoạch sửa chữa", "Create repair plan"), AddressOf V_Tao_Tien_Do_KH_SCC, System.Windows.Forms.Shortcut.F4, My.Resources.apply_16x16, True, True)).BeginGroup = False
        If Not M_Kieu_Xem = "HEN" And M_Loai_SC = "2" Then PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo nhanh KHSC đồng sơn", "Create repair plan BP"), AddressOf V_Tao_KH_ALLS, System.Windows.Forms.Shortcut.F9, My.Resources.apply_16x16, True, True)).BeginGroup = False
        If M_Kieu_Xem = "HEN" Or M_Loai_SC = "1" Then PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo kế hoạch hẹn", "Create an appointment"), AddressOf V_Tao_Lich_Hen_KHSC, System.Windows.Forms.Shortcut.F6, My.Resources.apply_16x16, True, True)).BeginGroup = False
        If M_Kieu_Xem = "HEN" Or M_Loai_SC = "1" Then PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tạo đặt chỗ", "Booking"), AddressOf V_Tao_Dat_CHo_KH_SCC, System.Windows.Forms.Shortcut.F2, Nothing, True, True)).BeginGroup = False
        If M_Kieu_Xem = "HEN" Then PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Gọi xác nhận lịch hẹn", "Call to confirm the appointment "), AddressOf V_Hen_Call_KHSC, Nothing, Nothing, True, True)).BeginGroup = False
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Sửa Kế hoạch", "Edit"), AddressOf V_Sua_Tien_Do_KH_SCC, System.Windows.Forms.Shortcut.F3, My.Resources.edit_16x16, True, True)).BeginGroup = True
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Xóa Kế hoạch", "Edit"), AddressOf V_Xoa_Tien_Do_KH_SCC, System.Windows.Forms.Shortcut.F8, My.Resources.deletelist_16x16, True, True)).BeginGroup = False

        '-----------------Chạy thử, Dừng, Q-Get,KSC, Dừng sửa chữa
        If M_Kieu_Xem <> "HEN" Then

            Dim PopAdd As New CyberBarSubMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chạy thử/Dừng/Q-Get/KSC", "Test run"), Nothing, Nothing, True)
            PopupMenuSchedulerControl.ItemLinks.Add(PopAdd, True)

            Dim PopAdd_Chay_Thu As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "1. Chạy thử", "Test run"), AddressOf V_KH_SCC_Chay_Thu, Nothing, Nothing, True, True)
            PopAdd.AddItem(PopAdd_Chay_Thu)

            Dim PopAdd_Dung_Chay_Thu As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "2. Kết thúc chạy thử", "Stop test run"), AddressOf V_KH_SCC_Chay_Thu_Stop, Nothing, Nothing, True, True)
            PopAdd.AddItem(PopAdd_Dung_Chay_Thu)

            Dim PopAdd_BD_Dung_SC As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "3. Bắt đầu Dừng sửa chữa", "Begin Stop to repair"), AddressOf V_KH_SCC_BD_Dung_SC, Nothing, Nothing, True, True)
            PopAdd.AddItem(PopAdd_BD_Dung_SC).BeginGroup = True

            Dim PopAdd_KT_Dung_SC As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "4. Kết thúc Dừng sửa chữa", "Finish Stop to repair"), AddressOf V_KH_SCC_KT_Dung_SC, Nothing, Nothing, True, True)
            PopAdd.AddItem(PopAdd_KT_Dung_SC)

            Dim PopAdd_Q_Get_SC As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "5. Q-Gate", "Q-Gate"), AddressOf V_KH_SCC_QGate, Nothing, Nothing, True, True)
            PopAdd.AddItem(PopAdd_Q_Get_SC).BeginGroup = True


            Dim PopAdd_KSC_SC As CyberMenuPopup
            PopAdd_KSC_SC = New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "6. KCS công đoạn", "KCS of step"), AddressOf V_KH_SCC_KCS_CD, Nothing, Nothing, True, True)
            'PopAdd_KSC_SC.Enabled = M_Loai_SC = "2"
            PopAdd.AddItem(PopAdd_KSC_SC)

            Dim PopAdd_Chuyen_Tung As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "7. Tạo thông điệp chuyển tầng", "Floor shift"), AddressOf V_Chuyen_Tang, Nothing, Nothing, True, True)
            PopAdd.AddItem(PopAdd_Chuyen_Tung)

        End If

        '----------Opiton
        Dim PopOption As New CyberBarSubMenuPopup(sender, rowHandle, IIf(Lan = "V", "Tùy chọn", "Option"), Nothing, Nothing, True)
        PopupMenuSchedulerControl.ItemLinks.Add(PopOption, True)

        Dim PopOption_Hen_To_KH As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "1. Chuyển hẹn sang kế hoạch", "Transef"), AddressOf V_Hen_To_Kh, Nothing, Nothing, True, True)
        PopOption_Hen_To_KH.Enabled = (M_Loai_SC = "1" And M_Kieu_Xem <> "HEN")
        PopOption.AddItem(PopOption_Hen_To_KH).BeginGroup = True

        Dim PopOption_Xem_Lenh As New CyberMenuPopup(sender, 0, IIf(Lan = "V", "2. Xem lệnh", "Preview R/O"), AddressOf V_Preview_Scheduler, System.Windows.Forms.Shortcut.F7, My.Resources.preview_16x16, True, True)
        PopOption_Xem_Lenh.Enabled = M_Kieu_Xem <> "HEN"
        PopOption.AddItem(PopOption_Xem_Lenh)


        Dim PopOption_LSSC As New CyberMenuPopup(sender, 0, IIf(Lan = "V", "3. Lịch sử sửa chữa", "History Repair"), AddressOf V_Xem_LSSC_Scheduler, Nothing, Nothing, True, True)
        PopOption.AddItem(PopOption_LSSC).BeginGroup = True

        '' If M_Kieu_Xem <> "HEN" Then
        Dim PopOption_Up_Mau As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "4. Cập nhật màu xe/Kiểu xe", "Update Color/Model"), AddressOf V_Cap_Nhap_Mau_KX, Nothing, Nothing, True, True)
        PopOption_Up_Mau.Enabled = M_Kieu_Xem <> "HEN"
        PopOption.AddItem(PopOption_Up_Mau)

        Dim PopOption_Up_Ghi_Chu As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "5. Cập nhật phát sinh/Ghi chú", "Update note"), AddressOf V_Update_Ghi_Chu, Nothing, Nothing, True, True)
        PopOption_Up_Ghi_Chu.Enabled = M_Kieu_Xem <> "HEN"
        PopOption.AddItem(PopOption_Up_Ghi_Chu)

        Dim PopOption_Up_Tg_GX As New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "6. Cập nhật thời gian giao xe", "Update vehicle delivery time"), AddressOf V_Update_Tg_GX, Nothing, Nothing, True, True)
        PopOption_Up_Tg_GX.Enabled = M_Kieu_Xem <> "HEN"
        PopOption.AddItem(PopOption_Up_Tg_GX)


        Dim PopOption_KHoa As New CyberMenuPopup(sender, 0, IIf(Lan = "V", "7. Khóa: Khoang/KTV/CVDV/Tổ", "Lock"), AddressOf V_Lock_Data, Nothing, Nothing, True, True)
        PopOption_KHoa.Enabled = M_Kieu_Xem <> "HEN"
        PopOption.AddItem(PopOption_KHoa).BeginGroup = True

        Dim PopOption_Ngam_Dinh As New CyberMenuPopup(sender, 0, IIf(Lan = "V", "8. Quay về giao diện ban đầu", "Reload Default"), AddressOf V_Refresh_Load_Default, System.Windows.Forms.Shortcut.ShiftF5, Nothing, True, True)
        PopOption_Ngam_Dinh.Enabled = M_Kieu_Xem <> "HEN"
        PopOption.AddItem(PopOption_Ngam_Dinh)
        '----------END Opiton

        If Not M_Kieu_Xem = "HEN" Then PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "In phiếu giao việc", "Print Work"), AddressOf V_Giao_Viec_Print, Nothing, My.Resources.printer_16x16, True, True)).BeginGroup = False
        If Not M_Kieu_Xem = "HEN" Then PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Bắt đầu sửa chữa", "Approval Begin"), AddressOf V_XN_BD_SC, System.Windows.Forms.Shortcut.F10, Nothing, True, True)).BeginGroup = True
        If Not M_Kieu_Xem = "HEN" Then PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Kết thúc sửa chữa", "Approval End"), AddressOf V_XN_KT_SC, System.Windows.Forms.Shortcut.F11, Nothing, True, True)).BeginGroup = False
        If Not M_Kieu_Xem = "HEN" Then PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Chuyển giao xe", "Transfer Delivery"), AddressOf V_Giao_Xe, Nothing, Nothing, True, True)).BeginGroup = True

        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_Tien_Do_KHSC, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = True
        PopupMenuSchedulerControl.ItemLinks.Add(New CyberMenuPopup(sender, 0, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, Nothing, My.Resources.cancel_16x16, True, True), True).BeginGroup = False
        If Not e Is Nothing Then PopupMenuSchedulerControl.ShowPopup(Control.MousePosition)
    End Sub
#End Region
#Region " data"
    Dim Dt_Data_Sort, Dt_Data, Dt_Data_Parent As DataTable
    Dim Dv_Data, Dv_Data_Parent As DataView
    Private Sub V_LoadData_Tien_Do(ByVal status As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String)
        SchedulerStorage.Appointments.AutoReload = False
        SchedulerControl.BeginUpdate()

        Dim _Dt As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC).ToString.Trim.ToUpper
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_DATA", status & "#" & M_Kieu_Xem & "#" & M_Loai_SC & "#" & _Loai_Xem & "#" & _Stt_Rec & "#" & _Stt_Rec_Ro & "#" & "" & "#" & _Dt.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If status = "1" Then
            LabTotal.Text = ""

            Dt_Data_Sort = Nothing
            Dt_Data = Nothing
            Dm_Xe = Nothing
            Dt_Data_Parent = Nothing
            Dt_Data_Sort = DsTmp.Tables(0).Copy


            If DsTmp.Tables.Count > 1 Then
                Dt_Data = DsTmp.Tables(1).Copy
                Dv_Data = New DataView(Dt_Data)
            End If


            If DsTmp.Tables.Count > 2 Then
                Dm_Xe = DsTmp.Tables(2).Copy
                Dv_Xe = New DataView(Dm_Xe)
            End If

            If DsTmp.Tables.Count > 3 Then
                Dt_Data_Parent = DsTmp.Tables(3).Copy
                Dv_Data_Parent = New DataView(Dt_Data_Parent)
            End If

            '---------Set SortDataview
            If Not Dt_Data Is Nothing And Not Dt_Data_Sort Is Nothing Then
                Dim _Drs As DataRow() = Dt_Data_Sort.Select("Loai = 'DATA_KH'")
                If _Drs.Length > 0 Then CyberSupport.V_SetSortView(Dv_Data, _Drs(0))
            End If

            If Not Dm_Xe Is Nothing And Not Dt_Data_Sort Is Nothing Then
                Dim _Drs As DataRow() = Dt_Data_Sort.Select("Loai = 'DATA_XE'")
                If _Drs.Length > 0 Then CyberSupport.V_SetSortView(Dv_Xe, _Drs(0))
            End If

            If Not Dt_Data_Parent Is Nothing And Not Dt_Data_Sort Is Nothing Then
                Dim _Drs As DataRow() = Dt_Data_Sort.Select("Loai = 'DATA_PARENT'")
                If _Drs.Length > 0 Then CyberSupport.V_SetSortView(Dv_Data_Parent, _Drs(0))
            End If

        Else
            If _Stt_Rec_Ro.Trim = "" And _Stt_Rec.Trim = "" Then
                '----
                Dt_Data.Clear()
                Dt_Data.Load(DsTmp.Tables(0).CreateDataReader)
                '----
                If DsTmp.Tables.Count > 1 And Not Dm_Xe Is Nothing Then
                    Dm_Xe.Clear()
                    Dm_Xe.Load(DsTmp.Tables(1).CreateDataReader)
                End If
                '----
                If DsTmp.Tables.Count > 2 And Not Dt_Data_Parent Is Nothing Then
                    Dt_Data_Parent.Clear()
                    Dt_Data_Parent.Load(DsTmp.Tables(2).CreateDataReader)
                End If
                V_Update_Tree("", "", "", "", "", "")
            Else
                '------------------------------------------------------------------------------------------
                '---Lấy các giá trị để Update vào tree
                Dim _VkhoangOld As String = ""
                Dim _VCVDVOld As String = ""
                Dim _VToOld As String = ""
                Dim _VCDOld As String = ""
                Dim _Vstt_Rec_RoOld As String = ""
                Dim _VKTVOld As String = ""
                V_GetInforValue(_Stt_Rec, _Stt_Rec_Ro, _VkhoangOld, _VCVDVOld, _VToOld, _VCDOld, _Vstt_Rec_RoOld, _VKTVOld)
                '------------------------------------------------------------------------------------------
                If DsTmp.Tables.Count > 0 And Not Dt_Data Is Nothing Then
                    V_Delete_KH_SCC_DATA(Dt_Data, _Stt_Rec, _Stt_Rec_Ro)
                    Dt_Data.Load(DsTmp.Tables(0).CreateDataReader)
                End If
                '----
                If DsTmp.Tables.Count > 1 And Not Dm_Xe Is Nothing Then
                    V_Delete_KH_SCC_DATA(Dm_Xe, _Stt_Rec, _Stt_Rec_Ro)
                    Dm_Xe.Load(DsTmp.Tables(1).CreateDataReader)
                End If
                '----
                If DsTmp.Tables.Count > 2 And Not Dt_Data_Parent Is Nothing Then
                    V_Delete_KH_SCC_DATA(Dt_Data_Parent, _Stt_Rec, _Stt_Rec_Ro)
                    Dt_Data_Parent.Load(DsTmp.Tables(2).CreateDataReader)
                End If

                Dim _VkhoangNew As String = ""
                Dim _VCVDVNew As String = ""
                Dim _VToNew As String = ""
                Dim _VCDNew As String = ""
                Dim _Vstt_Rec_RoNew As String = ""
                Dim _VKTVNew As String = ""
                V_GetInforValue(_Stt_Rec, _Stt_Rec_Ro, _VkhoangNew, _VCVDVNew, _VToNew, _VCDNew, _Vstt_Rec_RoNew, _VKTVNew)
                V_Update_Tree(_VkhoangOld + "," + _VkhoangNew, _VCVDVOld + "," + _VCVDVNew, _VToOld + "," + _VToNew, _VCDOld + "," + _VCDNew, _Vstt_Rec_RoOld + "," + _Vstt_Rec_RoNew, _VKTVOld + "," + _VKTVNew)
            End If
        End If
        DsTmp.Dispose()

        SchedulerControl.EndUpdate()
        SchedulerControl.Storage.RefreshData()
        SchedulerStorage.Appointments.AutoReload = True
        Tinh_toan_so_Xe_Lab(status, _Stt_Rec, _Stt_Rec_Ro)
    End Sub
    Private Sub Tinh_toan_so_Xe_Lab(ByVal status As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String)
        Dim _Dt As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_LabTotal", status + "#" + M_Kieu_Xem + "#" + M_Loai_SC + "#" + _Stt_Rec + "#" + _Stt_Rec_Ro + "#" + _Dt.ToString("yyyyMMdd") + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Columns.Contains("LabTooltip") Then ToolTip.SetToolTip(LabTotal, Dstmp.Tables(0).Rows(0).Item("LabTooltip").ToString.Trim)
        If Dstmp.Tables(0).Columns.Contains("LabTotal") Then LabTotal.Text = Dstmp.Tables(0).Rows(0).Item("LabTotal").ToString.Trim
        Dstmp.Dispose()
    End Sub
    Private Sub V_LoadData_Tien_Do(ByVal status As String, ByVal _Dt As DataTable)
        If _Dt Is Nothing Then Return
        If _Dt.Rows.Count = 0 Then Return
        If Not _Dt.Columns.Contains("Stt_Rec") And Not _Dt.Columns.Contains("Stt_Rec_Ro") Then Return
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        For i As Integer = 0 To _Dt.Rows.Count - 1
            If _Dt.Columns.Contains("Stt_Rec") Then _Stt_Rec = _Dt.Rows(i).Item("Stt_Rec").ToString.Trim
            If _Dt.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = _Dt.Rows(i).Item("Stt_Rec_Ro").ToString.Trim
            V_LoadData_Tien_Do("0", _Stt_Rec, _Stt_Rec_Ro)
        Next
    End Sub
    Private Sub V_Delete_KH_SCC_DATA(ByVal _Dt As DataTable, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String)
        If _Dt Is Nothing Then Return
        Dim nCount As Integer = _Dt.Rows.Count - 1
        If _Stt_Rec_Ro.Trim = "" And _Stt_Rec.Trim = "" Then
            _Dt.Clear()
            _Dt.AcceptChanges()
            Return
        End If

        Dim is_Rec_RO As Boolean = False
        Dim is_Rec As Boolean = False

        If _Dt.Columns.Contains("Stt_Rec_Ro") Then is_Rec_RO = True
        If _Dt.Columns.Contains("Stt_Rec") Then is_Rec = True

        If is_Rec_RO Then If _Stt_Rec_Ro.Trim = "" Then is_Rec_RO = False
        If is_Rec Then If _Stt_Rec.Trim = "" Then is_Rec = False

        If Not is_Rec_RO And Not is_Rec Then Return
        nCount = _Dt.Rows.Count - 1

        For i As Integer = nCount To 0 Step -1
            '-------------------
            If is_Rec_RO And is_Rec Then
                If _Dt.Rows(i).Item("Stt_Rec_RO").ToString.Trim Like _Stt_Rec_Ro.Trim & "*" And _Dt.Rows(i).Item("Stt_Rec").ToString.Trim Like _Stt_Rec.Trim & "*" Then
                    _Dt.Rows(i).Delete()
                End If
            End If
            '-------------------
            If is_Rec_RO And Not is_Rec Then
                If _Dt.Rows(i).Item("Stt_Rec_RO").ToString.Trim Like _Stt_Rec_Ro.Trim & "*" Then
                    _Dt.Rows(i).Delete()
                End If
            End If
            If Not is_Rec_RO And is_Rec Then
                If _Dt.Rows(i).Item("Stt_Rec").ToString.Trim Like _Stt_Rec.Trim & "*" Then
                    _Dt.Rows(i).Delete()
                End If
            End If
        Next
        _Dt.AcceptChanges()
    End Sub
    Public Sub V_UpdateRowtoRow(ByVal _Dr_Nguon As DataRow, ByVal _Dr_Dich As DataRow, ByVal _Field_Loai_Tru As String)
        If _Dr_Nguon Is Nothing Or _Dr_Dich Is Nothing Then Return
        Dim _ColName As String = ""
        For i As Integer = 0 To _Dr_Nguon.Table.Columns.Count - 1
            _ColName = _Dr_Nguon.Table.Columns(i).ColumnName
            If Not _Dr_Dich.Table.Columns.Contains(_ColName) Then Continue For
            If _Field_Loai_Tru.Trim.ToUpper = _ColName.Trim.ToUpper Then Continue For

            _Dr_Dich.BeginEdit()
            _Dr_Dich.Item(_ColName) = _Dr_Nguon.Item(_ColName)
            _Dr_Dich.EndEdit()
        Next
    End Sub
#End Region
#Region "Update Tree"
    Private Sub V_GetInforValue(ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String, ByRef _Value_khoang As String, ByRef _Value_CVDV As String, ByRef _Value_To As String, ByRef _Value_CD As String, ByRef _Value_Stt_Rec_Ro As String, ByRef _Value_KTV As String)
        If Not ResourcesTree.Visible Then Return
        If Dt_Data Is Nothing Then Return
        Dim _Drs As DataRow()

        If Not Dt_Data.Columns.Contains("Stt_rec") And Dt_Data.Columns.Contains("Stt_rec_RO") Then Return
        If Dt_Data.Columns.Contains("Stt_rec") And Dt_Data.Columns.Contains("Stt_rec_RO") Then _Drs = Dt_Data.Select("(Stt_Rec = '" + _Stt_Rec + "' OR '" + _Stt_Rec.Trim + "' = '') AND (Stt_rec_Ro = '" + _Stt_Rec_Ro.Trim + "' OR '" + _Stt_Rec_Ro.Trim + "' = '')")
        If Dt_Data.Columns.Contains("Stt_rec") And Not Dt_Data.Columns.Contains("Stt_rec_RO") Then _Drs = Dt_Data.Select("Stt_Rec = '" + _Stt_Rec + "' OR '" + _Stt_Rec.Trim + "' = ''")
        If Not Dt_Data.Columns.Contains("Stt_rec") And Dt_Data.Columns.Contains("Stt_rec_RO") Then _Drs = Dt_Data.Select("Stt_rec_Ro = '" + _Stt_Rec_Ro.Trim + "' OR '" + _Stt_Rec_Ro.Trim + "' = ''")

        If _Drs.Length = 0 Then Return
        Dim _VMa_khoang As String = ""
        Dim _VMa_CVDV As String = ""
        Dim _VMa_To As String = ""
        Dim _VMa_CD As String = ""
        Dim _VStt_Rec_Ro As String = ""
        Dim _VMa_KTV As String = ""

        For i As Integer = 0 To _Drs.Length - 1
            If i > 0 Then _Value_khoang = _Value_khoang + ","
            If i > 0 Then _Value_CVDV = _Value_CVDV + ","
            If i > 0 Then _Value_To = _Value_To + ","
            If i > 0 Then _Value_CD = _Value_CD + ","
            If i > 0 Then _Value_Stt_Rec_Ro = _Value_Stt_Rec_Ro + ","
            If i > 0 Then _Value_KTV = _Value_KTV + ","

            _Value_khoang = _Value_khoang + If(Dt_Data.Columns.Contains("Ma_khoang"), _Drs(i).Item("Ma_khoang"), "")
            _Value_CVDV = _Value_CVDV + If(Dt_Data.Columns.Contains("Ma_CVDV"), _Drs(i).Item("Ma_CVDV"), "")
            _Value_To = _Value_To + If(Dt_Data.Columns.Contains("Ma_To"), _Drs(i).Item("Ma_To"), "")
            _Value_CD = _Value_CD + If(Dt_Data.Columns.Contains("Ma_CD"), _Drs(i).Item("Ma_CD"), "")
            _Value_Stt_Rec_Ro = _Value_Stt_Rec_Ro + If(Dt_Data.Columns.Contains("Stt_Rec_Ro"), _Drs(i).Item("Stt_Rec_Ro"), "")
            _Value_KTV = _Value_KTV + If(Dt_Data.Columns.Contains("Ma_KTV"), _Drs(i).Item("Ma_KTV"), "")
        Next
    End Sub
    Private Sub V_Update_Tree(ByVal _Value_khoang As String, ByVal _Value_CVDV As String, ByVal _Value_To As String, ByVal _Value_CD As String, ByVal _Value_Stt_Rec_Ro As String, ByVal _Value_KTV As String)
        If Not ResourcesTree.Visible Then Return
        'Đã- Thực hiện ở: Kéo thả,
        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)
        Dim _Ma_Update As String = ""

        If _Loai_Xem = "02" And Dm_CVDV Is Nothing Then _Loai_Xem = "01"
        If _Loai_Xem = "03" And Dm_To Is Nothing Then _Loai_Xem = "01"
        If _Loai_Xem = "04" And Dm_CD Is Nothing Then _Loai_Xem = "01"
        If _Loai_Xem = "05" And Dm_Xe Is Nothing Then _Loai_Xem = "01"
        If _Loai_Xem = "06" And Dm_KTV Is Nothing Then _Loai_Xem = "01"

        If _Loai_Xem = "01" Then _Ma_Update = "Ma_Khoang"
        If _Loai_Xem = "02" Then _Ma_Update = "Ma_Hs"
        If _Loai_Xem = "03" Then _Ma_Update = "Ma_TO"
        If _Loai_Xem = "04" Then _Ma_Update = "Ma_CD"
        If _Loai_Xem = "05" Then _Ma_Update = "Stt_Rec_Ro"
        If _Loai_Xem = "06" Then _Ma_Update = "Ma_KTV"

        Dim _Dt As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Data_Tree", M_Kieu_Xem + "#" + M_Loai_SC + "#" + _Loai_Xem + "#" + _Dt.ToString("yyyyMMdd") + "#" + _
                                                                  _Value_khoang + "#" + _
                                                                  _Value_CVDV + "#" + _
                                                                  _Value_To + "#" + _
                                                                  _Value_CD + "#" + _
                                                                  _Value_Stt_Rec_Ro + "#" + _
                                                                  _Value_KTV + "#" + _
                                                                  M_Ma_Dvcs + "#" + M_User_Name)
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Not Dstmp.Tables(0).Columns.Contains(_Ma_Update) Then
            Dstmp.Dispose()
            Return
        End If
        '------------------------------------------------------------------------------------------------

        For i As Integer = 0 To Dstmp.Tables(0).Rows.Count - 1
            Dim _Dr_Dich As DataRow() = Dt_Khoang.Select(_Ma_Update + " = '" + Dstmp.Tables(0).Rows(i).Item(_Ma_Update).ToString.Trim + "'")
            If _Loai_Xem = "01" Then _Dr_Dich = Dm_khoang.Select(_Ma_Update + " = '" + Dstmp.Tables(0).Rows(i).Item(_Ma_Update).ToString.Trim + "'")
            If _Loai_Xem = "02" Then _Dr_Dich = Dm_CVDV.Select(_Ma_Update + " = '" + Dstmp.Tables(0).Rows(i).Item(_Ma_Update).ToString.Trim + "'")
            If _Loai_Xem = "03" Then _Dr_Dich = Dm_To.Select(_Ma_Update + " = '" + Dstmp.Tables(0).Rows(i).Item(_Ma_Update).ToString.Trim + "'")
            If _Loai_Xem = "04" Then _Dr_Dich = Dm_CD.Select(_Ma_Update + " = '" + Dstmp.Tables(0).Rows(i).Item(_Ma_Update).ToString.Trim + "'")
            If _Loai_Xem = "05" Then _Dr_Dich = Dm_Xe.Select(_Ma_Update + " = '" + Dstmp.Tables(0).Rows(i).Item(_Ma_Update).ToString.Trim + "'")
            If _Loai_Xem = "06" Then _Dr_Dich = Dm_KTV.Select(_Ma_Update + " = '" + Dstmp.Tables(0).Rows(i).Item(_Ma_Update).ToString.Trim + "'")
            If _Dr_Dich Is Nothing Then Continue For
            If _Dr_Dich.Length <> 1 Then Continue For
            V_UpdateRowtoRow(Dstmp.Tables(0).Rows(i), _Dr_Dich(0), _Ma_Update)

        Next
    End Sub
#End Region
#Region "Scheduler"
    Private Sub V_CyberSetTime_Tien_Do()
        V_Set_Ngay_Ct_Tien_Do()
        CyberSupport.V_CyberSetTime_Tien_Do(SchedulerControl, CyberWork.V_GetvalueCombox(CbbMa_BN_KH_SCC), M_StartHour, M_StartMINUTE, M_FinishHour, M_FinishMINUTE, M_Ngay_LimitInterval_Min, M_Ngay_LimitInterval_Max, M_Thu_Bay, M_Chu_Nhat)

    End Sub
    Private Sub V_SetSchedulerControl()

        SchedulerControl.DateNavigationBar.Visible = False
        '------------------------------------------------------------------------
        SchedulerControl.ActiveViewType = SchedulerViewType.Gantt
        SchedulerControl.Views.GanttView.Scales(6).Width = Dt_Ngay_Tien_Do.Rows(0).Item("HourWidth")
        SchedulerControl.Views.GanttView.ResourcesPerPage = Dt_Ngay_Tien_Do.Rows(0).Item("RowPage")
        '------------------------------------------------------------------------
        SchedulerControl.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource
        '------------------------------------------------------------------------
        V_SetSchedulerSetValue()
        '------------------------------------------------------------------------
        V_SetColorAppointments()
        '------------------------------------------------------------------------
        If Dm_khoang.Columns.Contains("Color") Then SchedulerStorage.Resources.Mappings.Color = Dm_khoang.Columns("Color").ColumnName.ToString.Trim
        If Dm_khoang.Columns.Contains("Image") Then SchedulerStorage.Resources.Mappings.Image = Dm_khoang.Columns("Image").ColumnName.ToString.Trim
        '------------------------------------------------------------------------
        Me.SchedulerStorage.Appointments.DataSource = Dv_Data
        Me.SchedulerStorage.Appointments.Mappings.AllDay = "AllDay"
        Me.SchedulerStorage.Appointments.Mappings.AppointmentId = Dt_Data.Columns("Stt_Rec").ColumnName


        If Dt_Data.Columns.Contains("Dien_Giai") Then Me.SchedulerStorage.Appointments.Mappings.Description = Dt_Data.Columns("Dien_Giai").ColumnName
        Me.SchedulerStorage.Appointments.Mappings.Start = Dt_Data.Columns("Ngay_BD").ColumnName
        Me.SchedulerStorage.Appointments.Mappings.End = Dt_Data.Columns("Ngay_KT").ColumnName

        Me.SchedulerControl.Views.GanttView.AppointmentDisplayOptions.AutoAdjustForeColor = False

        If Dt_Data.Columns.Contains("Size_Border") Then Me.SchedulerStorage.Appointments.Mappings.Status = Dt_Data.Columns("Size_Border").ColumnName
        If Dt_Data.Columns.Contains("PercentComplete") Then Me.SchedulerStorage.Appointments.Mappings.PercentComplete = Dt_Data.Columns("PercentComplete").ColumnName Else SchedulerControl.Views.GanttView.AppointmentDisplayOptions.PercentCompleteDisplayType = PercentCompleteDisplayType.None
        If Dt_Data.Columns.Contains("Type") Then Me.SchedulerStorage.Appointments.Mappings.Type = Dt_Data.Columns("Type").ColumnName


        '------------------------------------------------------------------------
        SchedulerControl.OptionsView.ToolTipVisibility = ToolTipVisibility.Always
        If M_Loai_SC.Trim = "2" And M_Kieu_Xem <> "HEN" Then
            SchedulerControl.GanttView.Appearance.Appointment.ForeColor = System.Drawing.Color.Navy
        Else
            SchedulerControl.GanttView.Appearance.Appointment.ForeColor = System.Drawing.Color.White
        End If

        SchedulerControl.GanttView.Appearance.Appointment.Font = New Font(SchedulerControl.DayView.Appearance.Appointment.Font.FontFamily, 10)
        '------------------------------------------------------------------------
        SchedulerControl.Views.GanttView.AppointmentDisplayOptions.StartTimeVisibility = AppointmentTimeVisibility.Never
        SchedulerControl.Views.GanttView.AppointmentDisplayOptions.EndTimeVisibility = AppointmentTimeVisibility.Never
        SchedulerControl.Views.GanttView.AppointmentDisplayOptions.SnapToCellsMode = AppointmentSnapToCellsMode.Disabled
        '------------------------------------------------------------------------
    End Sub
    Private Sub V_SetSchedulerSetValue()
        '-----------------------------------------------------------------------------------------------------------------------------
        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)

        Dim _ShowLeft As Boolean = False
        Dim _ShowTree As Boolean = False
        Dim _ShowHead As Boolean = False
        Dim _ShowRight As Boolean = False

        Dim _SplitterDistance_Left As Integer = 200
        Dim _SplitterDistance_Right As Integer = 160
        Dim _SplitterDistance_Tree As Integer = 140

        Dim _Is_AppointmentHeight As Boolean = False
        Dim _AppointmentHeight As Integer = 100
        Dim _Do_Rong As Decimal = 0

        If Not Dt_Loai_Xem Is Nothing Then
            If Dt_Loai_Xem.Columns.Contains("Loai") Then
                Dim _Dr() As DataRow = Dt_Loai_Xem.Select("Loai='" + _Loai_Xem + "'")
                If _Dr.Length > 0 Then
                    If Dt_Loai_Xem.Columns.Contains("ShowLeft") Then _ShowLeft = _Dr(0).Item("ShowLeft").ToString.Trim = "1"
                    If Dt_Loai_Xem.Columns.Contains("ShowTree") Then _ShowTree = _Dr(0).Item("ShowTree").ToString.Trim = "1"
                    If Dt_Loai_Xem.Columns.Contains("ShowHead") Then _ShowHead = _Dr(0).Item("ShowHead").ToString.Trim = "1"
                    If Dt_Loai_Xem.Columns.Contains("ShowRight") Then _ShowRight = _Dr(0).Item("ShowRight").ToString.Trim = "1"

                    If Dt_Loai_Xem.Columns.Contains("SplitterDistance_Left") Then _SplitterDistance_Left = _Dr(0).Item("SplitterDistance_Left")
                    If Dt_Loai_Xem.Columns.Contains("SplitterDistance_Right") Then _SplitterDistance_Right = _Dr(0).Item("SplitterDistance_Right")
                    If Dt_Loai_Xem.Columns.Contains("SplitterDistance_Tree") Then _SplitterDistance_Tree = _Dr(0).Item("SplitterDistance_Tree")

                    If Dt_Loai_Xem.Columns.Contains("Do_Rong") Then _Do_Rong = _Dr(0).Item("Do_Rong")

                    If Dt_Loai_Xem.Columns.Contains("Is_AppointmentHeight") Then If _Dr(0).Item("Is_AppointmentHeight").ToString.Trim = "1" Then _Is_AppointmentHeight = True
                    If Dt_Loai_Xem.Columns.Contains("AppointmentHeight") Then _AppointmentHeight = _Dr(0).Item("AppointmentHeight")

                End If
            End If
        End If
        '-----------------------------------------------------------------------------------------------------------------------------
        If _Loai_Xem = "02" And Dm_CVDV Is Nothing Then _Loai_Xem = "01"
        If _Loai_Xem = "03" And Dm_To Is Nothing Then _Loai_Xem = "01"
        If _Loai_Xem = "04" And Dm_CD Is Nothing Then _Loai_Xem = "01"
        If _Loai_Xem = "05" And Dm_Xe Is Nothing Then _Loai_Xem = "01"
        If _Loai_Xem = "06" And Dm_KTV Is Nothing Then _Loai_Xem = "01"

        Dim _Ma As String = ""
        Dim _Ten As String = ""
        Select Case _Loai_Xem
            Case "02"
                If Head_CVDV_Tree Is Nothing Then _ShowTree = False Else If Head_CVDV_Tree.Rows.Count = 0 Then _ShowTree = False
                If Dm_CVDV.Columns.Contains("Ma_Hs_Tmp") Then _Ma = "Ma_Hs_Tmp" Else _Ma = "Ma_Hs"
                If Dm_CVDV.Columns.Contains("Ten_Hs_Tmp") Then _Ten = "Ten_Hs_Tmp" Else _Ten = If(Dm_CVDV.Columns.Contains("Ten3"), "Ten3", "Ten_HS")
                CyberSupport.V_SetScheduler(Dv_Data, Dv_Data_Parent, Dv_CVDV, _Ma, _Ten, "Ma_Xe", _Do_Rong, SchedulerControl, ResourcesTree, IIf(_ShowTree, Head_CVDV_Tree, Nothing))

            Case "03"
                If Head_To_Tree Is Nothing Then _ShowTree = False Else If Head_To_Tree.Rows.Count = 0 Then _ShowTree = False
                If Dm_To.Columns.Contains("Ma_To_Tmp") Then _Ma = "Ma_To_Tmp" Else _Ma = "Ma_To"
                If Dm_To.Columns.Contains("Ten_To_Tmp") Then _Ten = "Ten_To_Tmp" Else _Ten = If(Dm_To.Columns.Contains("Ten3"), "Ten3", "Ten_To")
                CyberSupport.V_SetScheduler(Dv_Data, Dv_Data_Parent, Dv_To, _Ma, _Ten, "Ma_Xe", _Do_Rong, SchedulerControl, ResourcesTree, IIf(_ShowTree, Head_To_Tree, Nothing))

            Case "04"
                If Head_CD_Tree Is Nothing Then _ShowTree = False Else If Head_CD_Tree.Rows.Count = 0 Then _ShowTree = False
                If Dm_CD.Columns.Contains("Ma_CD_Tmp") Then _Ma = "Ma_CD_Tmp" Else _Ma = "Ma_CD"
                If Dm_CD.Columns.Contains("Ten_CD_Tmp") Then _Ten = "Ten_CD_Tmp" Else _Ten = If(Dm_CD.Columns.Contains("Ten3"), "Ten3", "Ten_CD")
                CyberSupport.V_SetScheduler(Dv_Data, Dv_Data_Parent, Dv_CD, _Ma, _Ten, "Ma_Xe", _Do_Rong, SchedulerControl, ResourcesTree, IIf(_ShowTree, Head_CD_Tree, Nothing))

            Case "05"
                If Head_Xe_Tree Is Nothing Then _ShowTree = False Else If Head_Xe_Tree.Rows.Count = 0 Then _ShowTree = False
                If Dm_Xe.Columns.Contains("Stt_Rec_Ro_Tmp") Then _Ma = "Stt_Rec_Ro_Tmp" Else _Ma = "Stt_Rec_Ro"
                If Dm_Xe.Columns.Contains("Ma_Xe_Tmp") Then _Ten = "Ma_Xe_Tmp" Else _Ten = If(Dm_Xe.Columns.Contains("Ten3"), "Ten3", "Ma_Xe")
                Dim _SubJect As String = "Ma_Xe"
                If Dt_Data.Columns.Contains("ten_CD") Then _SubJect = "Ten_CD"
                CyberSupport.V_SetScheduler(Dv_Data, Dv_Data_Parent, Dv_Xe, _Ma, _Ten, _SubJect, _Do_Rong, SchedulerControl, ResourcesTree, IIf(_ShowTree, Head_Xe_Tree, Nothing))
            Case "06"
                If Head_KTV_Tree Is Nothing Then _ShowTree = False Else If Head_KTV_Tree.Rows.Count = 0 Then _ShowTree = False
                If Dm_KTV.Columns.Contains("Ma_KTV_Tmp") Then _Ma = "Ma_KTV_Tmp" Else _Ma = "Ma_KTV"
                If Dm_KTV.Columns.Contains("Ten_KTV_Tmp") Then _Ten = "Ten_KTV_Tmp" Else _Ten = If(Dm_KTV.Columns.Contains("Ten3"), "Ten3", "Ten_KTV")
                CyberSupport.V_SetScheduler(Dv_Data, Dv_Data_Parent, Dv_KTV, _Ma, _Ten, "Ma_Xe", _Do_Rong, SchedulerControl, ResourcesTree, IIf(_ShowTree, Head_KTV_Tree, Nothing))
            Case Else
                If Head_khoang_Tree Is Nothing Then _ShowTree = False Else If Head_khoang_Tree.Rows.Count = 0 Then _ShowTree = False
                If Dm_khoang.Columns.Contains("Ma_Khoang_Tmp") Then _Ma = "Ma_Khoang_Tmp" Else _Ma = "Ma_Khoang"
                If Dm_khoang.Columns.Contains("Ten_Khoang_Tmp") Then _Ten = "Ten_Khoang_Tmp" Else _Ten = If(Dm_khoang.Columns.Contains("Ten3"), "Ten3", "Ten_Khoang")
                CyberSupport.V_SetScheduler(Dv_Data, Dv_Data_Parent, Dv_khoang, _Ma, _Ten, "Ma_Xe", _Do_Rong, SchedulerControl, ResourcesTree, IIf(_ShowTree, Head_khoang_Tree, Nothing))

        End Select
        '-------------------------------------------------------------------------------------
        If Not _ShowTree Then _ShowHead = True
        SchedulerControl.Views.GanttView.ShowResourceHeaders = _ShowHead

        If Not _ShowLeft Then _SplitterDistance_Left = 0
        If Not _ShowRight Then _SplitterDistance_Right = 0
        If Not _ShowTree Then _SplitterDistance_Tree = 0

        '-------------------------------------------------------------------------------------
        SplitContainer_Left.Panel1Collapsed = Not _ShowLeft
        SplitContainer_Right.Panel2Collapsed = Not _ShowRight
        SplitContainer_Tree.Panel1Collapsed = Not _ShowTree
        '-------------------------------------------------------------------------------------
        If _ShowLeft Then
            If _SplitterDistance_Left <= 10 Then _SplitterDistance_Left = 10
            SplitContainer_Left.SplitterDistance = _SplitterDistance_Left
        End If

        If _ShowRight Then
            Dim _With_Right As Decimal = SplitContainer_Right.Width
            _SplitterDistance_Right = _With_Right - _SplitterDistance_Right
            If _SplitterDistance_Right <= 10 Then _SplitterDistance_Right = 10
            SplitContainer_Right.SplitterDistance = _SplitterDistance_Right
        End If

        If _ShowTree Then
            If _SplitterDistance_Tree <= 10 Then _SplitterDistance_Tree = 10
            SplitContainer_Tree.SplitterDistance = _SplitterDistance_Tree
        End If
        '-------------------------------------------------------------------------------------
    End Sub
    Private Sub V_SetColorAppointments()
        For i = 0 To Dt_ConFigColor_Tien_Do.Rows.Count - 1
            '    SchedulerStorage_KH_SCC.Appointments.Labels(i).Color = CyberColor.GetBackColor(Dt_ConFigColor_Tien_Do.Rows(i).Item("BackColor"))
            '    SchedulerStorage_KH_SCC.Appointments.Labels(i).DisplayName = Dt_ConFigColor_Tien_Do.Rows(i).Item("Ten_Color")
            '    SchedulerStorage_KH_SCC.Appointments.Labels(i).MenuCaption = Dt_ConFigColor_Tien_Do.Rows(i).Item("Ten_Color")
            V_SetColorlabel_Tien_Do(i, Dt_ConFigColor_Tien_Do.Rows(i))
        Next
    End Sub
    Private Sub V_GetFromSetScheduler(ByRef _Ngay_BD As Date, ByRef _Ngay_KT As Date, ByRef _Stt_Rec_Ro As String, ByRef _So_Ro As String, ByRef _ma_khoang As String, ByRef _Ma_CVDV As String, ByRef _Ma_To As String, ByRef _Ma_Xe As String, ByRef _Ma_CD As String, ByRef _Ma_KTV As String, Optional ByVal _Appointment As Appointment = Nothing)
        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)
        _Ngay_BD = Now.Date
        _Ngay_KT = Now.Date
        _Stt_Rec_Ro = ""
        _So_Ro = ""
        _ma_khoang = ""
        _Ma_CVDV = ""
        _Ma_To = ""
        _Ma_Xe = ""
        _Ma_CD = ""
        _Ma_KTV = ""
        If _Appointment Is Nothing Then
            _Ngay_BD = SchedulerControl.SelectedInterval.Start
            _Ngay_KT = SchedulerControl.SelectedInterval.End
        Else
            _Ngay_BD = _Appointment.Start
            _Ngay_KT = _Appointment.End
        End If

        Dim _Value As String = CyberSupport.GetvalueSelectedResource(_Appointment, SchedulerControl)
        If _Value.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Value = ""
        _Value = _Value.Replace("_THUCHIEN", "")

        Select Case _Loai_Xem
            Case "01"
                _ma_khoang = _Value
            Case "02"
                _Ma_CVDV = _Value
            Case "03"
                _Ma_To = _Value
            Case "04"
                _Ma_CD = _Value
            Case "05"
                _Stt_Rec_Ro = _Value
            Case "06"
                _Ma_KTV = _Value
            Case Else
                _ma_khoang = _Value
        End Select
    End Sub
    Private Sub V_GetFromSetSchedulerOld(ByRef _Ngay_BDOld As Date, ByRef _Ngay_KTOld As Date, ByRef _Stt_Rec_RoOld As String, ByRef _So_RoOld As String, ByRef _ma_khoangOld As String, ByRef _Ma_CVDVOld As String, ByRef _Ma_ToOld As String, ByRef _Ma_XeOld As String, ByRef _Ma_CDOld As String, ByRef _Ma_KTVOld As String, Optional ByVal _Appointment As Appointment = Nothing)
        Dim _drv As DataRowView = CyberSupport.V_GetFromSetSchedulerOld(_Appointment, _SchedulerControl)
        If _drv Is Nothing Then Return

        If Dt_Data.Columns.Contains("Ngay_BD") Then _Ngay_BDOld = _drv.Item("Ngay_BD").ToString.Trim
        If Dt_Data.Columns.Contains("Ngay_KT") Then _Ngay_KTOld = _drv.Item("Ngay_KT").ToString.Trim
        If Dt_Data.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_RoOld = _drv.Item("Stt_Rec_Ro").ToString.Trim
        If Dt_Data.Columns.Contains("So_Ro") Then _So_RoOld = _drv.Item("So_Ro").ToString.Trim

        If Dt_Data.Columns.Contains("ma_khoang") Then _ma_khoangOld = _drv.Item("Ma_khoang").ToString.Trim
        If Dt_Data.Columns.Contains("Ma_Hs") Then _Ma_CVDVOld = _drv.Item("Ma_Hs").ToString.Trim
        If Dt_Data.Columns.Contains("Ma_To") Then _Ma_ToOld = _drv.Item("Ma_To").ToString.Trim
        If Dt_Data.Columns.Contains("Ma_Xe") Then _Ma_XeOld = _drv.Item("Ma_Xe").ToString.Trim
        If Dt_Data.Columns.Contains("Ma_CD") Then _Ma_CDOld = _drv.Item("Ma_CD").ToString.Trim
        If Dt_Data.Columns.Contains("Ma_KTV") Then _Ma_KTVOld = _drv.Item("Ma_KTV").ToString.Trim
    End Sub
#End Region

#Region "----------Sự kiện - SchedulerControl"
    Private Sub V_CustomDrawTimeCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs)
        ''CyberSupport.V_CustomDrawTimeCell(sender, e, SchedulerControl, M_FinishHour, CyberColor)
        CyberSupport.V_CustomDrawTimeCell2(sender, e, SchedulerControl, M_FinishHour, M_Gio_Sang2, M_Phut_Sang2, M_Gio_Chieu1, M_Phut_Chieu1, CyberColor)
    End Sub

    Private Sub scheduler_CustomDrawResourceHeader(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs)
        CyberSupport.Scheduler_CustomDrawResourceHeader(sender, e, CyberColor, My.Resources.flag1, My.Resources.flag2, My.Resources.flag3, My.Resources.flag4, My.Resources.flag5, My.Resources.flag6)
    End Sub

    Private Sub SchedulerControl_InitAppointmentImages(ByVal sender As Object, ByVal e As AppointmentImagesEventArgs)
        CyberSupport.SchedulerControl_InitAppointmentImages(sender, e, CyberColor, My.Resources.flag1, My.Resources.flag2, My.Resources.flag3, My.Resources.flag4, My.Resources.flag5, My.Resources.flag6)
    End Sub
    Private Sub SchedulerControl_CustomDrawAppointmentBackground(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.CustomDrawObjectEventArgs)
        CyberSupport.SchedulerControl_CustomDrawAppointmentBackground(sender, e, CyberColor)
    End Sub

    Private Sub V_AppointmentViewInfoCustomizing(ByVal sender As Object, ByVal e As DevExpress.XtraScheduler.AppointmentViewInfoCustomizingEventArgs)
        CyberSupport.V_AppointmentViewInfoCustomizing(sender, e, Me.Font, CyberColor)
    End Sub

#End Region

#Region "----------Chạy thử/Q-Get/Dừng SC/KSC"
    Private Sub V_KH_SCC_Chay_Thu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Return
        If Not V_ChkStt_Rec(_Stt_Rec) Then Return '---Khong lam gi o phan thuc hien
        V_Set_Auto_Refresh(False)
        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        Dim _Stt_rec_Ro As String = ""
        Dim _Return As DataTable = CyberWork.V_Chay_Thu(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, _Stt_rec_Ro, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Return)
    End Sub
    Private Sub V_KH_SCC_Chay_Thu_Stop(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Return
        If Not V_ChkStt_Rec(_Stt_Rec) Then Return '---Khong lam gi o phan thuc hien
        V_Set_Auto_Refresh(False)
        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        Dim _Stt_rec_Ro As String = ""

        Dim _Return As DataTable = CyberWork.V_Chay_Thu_Stop(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, _Stt_rec_Ro, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Return)
    End Sub
    Private Sub V_KH_SCC_BD_Dung_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Return
        If Not V_ChkStt_Rec(_Stt_Rec) Then Return '---Khong lam gi o phan thuc hien
        V_Set_Auto_Refresh(False)
        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        Dim _Return As DataTable = CyberWork.V_BD_Dung_SC(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Return)
    End Sub
    Private Sub V_KH_SCC_KT_Dung_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        Dim _So_Ro As String = ""
        Dim _Ma_Xe As String = ""
        '
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        If _Stt_Rec.Trim = "" Then Return
        If Not V_ChkStt_Rec(_Stt_Rec) Then Return '---Khong lam gi o phan thuc hien
        V_Set_Auto_Refresh(False)

        Dim dr() As DataRow = Dt_Data.Select("Stt_Rec = '" & _Stt_Rec.ToString.Trim & "'")
        If dr.Length > 0 Then
            If Dt_Data.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = dr(0).Item("Stt_Rec_Ro")
            If Dt_Data.Columns.Contains("So_Ro") Then _So_Ro = dr(0).Item("So_Ro")
            If Dt_Data.Columns.Contains("Ma_Xe") Then _Ma_Xe = dr(0).Item("Ma_Xe")
        Else
            Exit Sub
        End If
        Dim _Return As DataTable = CyberWork.V_KT_Dung_SC(M_Kieu_Xem, M_Loai_SC, _Stt_Rec_Ro, _Stt_Rec, _So_Ro, _Ma_Xe, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Return)
    End Sub
    Private Sub V_KH_SCC_QGate(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Return
        If Not V_ChkStt_Rec(_Stt_Rec) Then Return '---Khong lam gi o phan thuc hien
        V_Set_Auto_Refresh(False)
        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        Dim _Return As DataTable = CyberWork.V_QGate(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Return)
    End Sub
    Private Sub V_KH_SCC_KCS_CD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Return
        If Not V_ChkStt_Rec(_Stt_Rec) Then Return '---Khong lam gi o phan thuc hien
        V_Set_Auto_Refresh(False)

        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        Dim _Return As DataTable = CyberWork.V_KCS_CD(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Return)
    End Sub
    Private Sub V_Chuyen_Tang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Return
        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        If Not V_ChkStt_Rec(_Stt_Rec) Then Return '---Khong lam gi o phan thuc hien
        Dim dr() As DataRow = Dt_Data.Select("Stt_Rec = '" & _Stt_Rec.ToString.Trim & "'")
        Dim _Stt_Rec_Ro As String = ""
        If dr.Length > 0 Then
            If Dt_Data.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = dr(0).Item("Stt_Rec_Ro")
        End If

        Dim _Return As DataTable = CyberWork.V_Chuyen_Tang("0", M_Kieu_Xem, M_Loai_SC, _Stt_Rec, _Stt_Rec_Ro, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Return)
    End Sub
#End Region
#Region "----------Option: KHác(Chuyển hẹn/Xem Lệnh/LSSC/Cập nhập màu/Ghi Chú/KHóa/Defaul)"
    Private Function V_Hen_To_KH_Drap_Drop(ByVal _Stt_Rec_Ro As String, ByVal _Stt_Rec_Hen As String) As Boolean

        Dim _Return As Boolean = False
        If Not _Stt_Rec_Hen Like "*" + M_Ma_CT_DLH.Trim Then Return False
        _Return = V_Hen_To_Kh(_Stt_Rec_Hen, _Stt_Rec_Ro)
        V_Hen_To_KH_Drap_Drop = _Return
    End Function
    Private Sub V_Hen_To_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Set_Auto_Refresh(False)
        Dim _Stt_Rec_Hen As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec_Hen = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec_Hen.Trim = "" Then Return
        _Stt_Rec_Hen = _Stt_Rec_Hen.Replace("_THUCHIEN", "")
        If Not _Stt_Rec_Hen Like "*" + M_Ma_CT_DLH.Trim Then Return
        V_Hen_To_Kh(_Stt_Rec_Hen, "")
    End Sub
    Private Function V_Hen_To_Kh(ByVal _Stt_rec_hen As String, ByVal _Stt_Rec_Ro As String) As Boolean
        Dim _Return As Boolean = False
        If _Stt_rec_hen.Trim = "" Then Return _Return
        _Stt_rec_hen = _Stt_rec_hen.Replace("_THUCHIEN", "")
        If Not _Stt_rec_hen Like "*" + M_Ma_CT_DLH.Trim Then Return _Return
        Dim _So_Ro As String = CyberWork.V_Hen_To_Kh(M_Kieu_Xem, M_Loai_SC, _Stt_rec_hen, _Stt_Rec_Ro, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

        If _So_Ro.Trim = "" Then Return _Return
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Hen_To_KH", M_Kieu_Xem & "#" & M_Loai_SC.Trim & "#" & _So_Ro & "#" & _Stt_rec_hen & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Return _Return
        End If
        V_LoadDatabasesALL(DsTmp.Tables(0).Copy)
        CyberSmlib.FlushMemorySave()
        V_Hen_To_Kh = True
    End Function
    Private Sub V_Preview_Scheduler(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString

        If _Stt_Rec.Trim = "" Then
            Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)
            If _Loai_Xem.Trim = "05" Then
                Try
                    _Stt_Rec_Ro = SchedulerControl.SelectedResource.Id.ToString.Trim().ToUpper.Trim
                    If _Stt_Rec_Ro.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Stt_Rec_Ro = ""
                    If _Stt_Rec_Ro.ToUpper.Trim Like "*DevExpress.XtraScheduler*".ToUpper.Trim Then _Stt_Rec_Ro = ""
                Catch ex As Exception
                End Try
            End If
        End If
        V_Preview(_Stt_Rec, _Stt_Rec_Ro)
    End Sub
    Private Sub V_Preview(ByVal _Stt_Rec As String, ByVal _Stt_rec_Ro As String)
        If _Stt_Rec.Trim = "" And _Stt_rec_Ro.Trim = "" Then Return
        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        _Stt_rec_Ro = _Stt_rec_Ro.Replace("_THUCHIEN", "")
        CyberWork.V_PreviewLenh(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, _Stt_rec_Ro, M_Ma_Dvcs, M_User_Name, Me.Para, AppConn, Me.Sysvar, M_LAN, CyberSmlib, CyberVoucher, CyberSupport)
    End Sub
    Private Sub V_Xem_LSSC_Scheduler(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        Dim _Ma_ct As String = "HDK"

        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        Dim _Ma_Xe As String = ""

        If Not _Stt_Rec.Trim = "" Then
            Dim _Dr As DataRow() = Dt_Data.Select("Stt_rec = '" + _Stt_Rec + "'")
            If _Dr.Length > 0 And Dt_Data.Columns.Contains("Ma_Xe") Then _Ma_Xe = _Dr(0).Item("Ma_Xe").ToString.Trim
            If _Dr.Length > 0 And Dt_Data.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = _Dr(0).Item("Stt_Rec_Ro").ToString.Trim
            If _Dr.Length > 0 And Dt_Data.Columns.Contains("Ma_ct") Then _Ma_ct = _Dr(0).Item("Ma_ct").ToString.Trim
        Else
            Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)
            If _Loai_Xem.Trim = "05" Then
                Try
                    _Stt_Rec_Ro = SchedulerControl.SelectedResource.Id.ToString.Trim().ToUpper.Trim
                    If _Stt_Rec_Ro.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Stt_Rec_Ro = ""
                    If _Stt_Rec_Ro.ToUpper.Trim Like "*DevExpress.XtraScheduler*".ToUpper.Trim Then _Stt_Rec_Ro = ""

                    Dim _Dv As DataView = SchedulerStorage.Resources.DataSource
                    If Not _Dv Is Nothing Then
                        If _Dv.Table.Columns.Contains("Ma_Xe") And _Dv.Table.Columns.Contains("Stt_Rec_RO") Then
                            Dim _Drs As DataRow() = _Dv.Table.Select("Stt_Rec_RO = '" + _Stt_Rec_Ro + "'")
                            If _Drs.Length > 0 Then _Ma_Xe = _Drs(0).Item("Ma_Xe").ToString.Trim
                        End If
                    End If
                Catch ex As Exception
                End Try
            End If

        End If

        CyberSupport.V_Lich_Su_SC(_Ma_Xe, _Ma_ct, _Stt_Rec_Ro, AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

    End Sub
    Private Sub V_Cap_Nhap_Mau_KX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Kieu_Xem = "HEN" Then Return
        Dim _Ma_Xe As String = ""
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_RO As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then
            Try
                _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
            Catch ex As Exception

            End Try
        End If
        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)
        If _Loai_Xem.Trim = "05" Then
            Try
                _Stt_Rec_RO = SchedulerControl.SelectedResource.Id.ToString.Trim().ToUpper.Trim
                If _Stt_Rec_RO.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Stt_Rec_RO = ""
                If _Stt_Rec_RO.ToUpper.Trim Like "*DevExpress.XtraScheduler*".ToUpper.Trim Then _Stt_Rec_RO = ""
            Catch ex As Exception
            End Try
        End If
        ''---------------------------------------------------------------------------------------
        If _Stt_Rec.Trim = "" And _Stt_Rec_RO.Trim = "" Then Return
        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        _Stt_Rec_RO = _Stt_Rec_RO.Replace("_THUCHIEN", "")
        ''---------------------------------------------------------------------------------------
        Dim _Dt_Return As DataTable = CyberWork.V_Update_Mau_KX(M_Kieu_Xem, M_Loai_SC, _Ma_Xe, _Stt_Rec, _Stt_Rec_RO, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Dt_Return)
    End Sub
    Private Sub V_Update_Ghi_Chu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Kieu_Xem = "HEN" Then Return
        Dim _Ma_Xe As String = ""
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_RO As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then
            Try
                _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
            Catch ex As Exception

            End Try
        End If
        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)
        If _Loai_Xem.Trim = "05" Then
            Try
                _Stt_Rec_RO = SchedulerControl.SelectedResource.Id.ToString.Trim().ToUpper.Trim
                If _Stt_Rec_RO.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Stt_Rec_RO = ""
                If _Stt_Rec_RO.ToUpper.Trim Like "*DevExpress.XtraScheduler*".ToUpper.Trim Then _Stt_Rec_RO = ""
            Catch ex As Exception
            End Try
        End If
        ''---------------------------------------------------------------------------------------
        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        _Stt_Rec_RO = _Stt_Rec_RO.Replace("_THUCHIEN", "")
        If _Stt_Rec.Trim = "" And _Stt_Rec_RO.Trim = "" Then Return
        ''---------------------------------------------------------------------------------------
        Dim _Dt_Return As DataTable = CyberWork.V_Update_Ghi_Chu(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, _Stt_Rec_RO, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

        V_LoadDatabasesALL(_Dt_Return)
    End Sub
    Private Sub V_Update_Tg_GX(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If M_Kieu_Xem = "HEN" Then Return
        Dim _Ma_Xe As String = ""
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_RO As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then
            Try
                _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
            Catch ex As Exception

            End Try
        End If
        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)
        If _Loai_Xem.Trim = "05" Then
            Try
                _Stt_Rec_RO = SchedulerControl.SelectedResource.Id.ToString.Trim().ToUpper.Trim
                If _Stt_Rec_RO.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Stt_Rec_RO = ""
                If _Stt_Rec_RO.ToUpper.Trim Like "*DevExpress.XtraScheduler*".ToUpper.Trim Then _Stt_Rec_RO = ""
            Catch ex As Exception
            End Try
        End If
        ''---------------------------------------------------------------------------------------
        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        _Stt_Rec_RO = _Stt_Rec_RO.Replace("_THUCHIEN", "")
        If _Stt_Rec.Trim = "" And _Stt_Rec_RO.Trim = "" Then Return
        Dim _So_Ro As String = ""

        If Not Dt_Data Is Nothing Then
            If Dt_Data.Columns.Contains("Stt_Rec_Ro") And _Stt_Rec_RO <> "" Then
                Dim _Drs As DataRow() = Dt_Data.Select("Stt_Rec_Ro = '" + _Stt_Rec_RO + "'")
                If _Drs.Length > 0 Then
                    If Dt_Data.Columns.Contains("So_RO") Then _So_Ro = _Drs(0).Item("So_RO")
                    If Dt_Data.Columns.Contains("Ma_CT") Then If Not _Drs(0).Item("Ma_Ct").ToUpper.Trim = M_Ma_CT_PKH.ToUpper.Trim Then Return

                End If
            Else
                If Dt_Data.Columns.Contains("Stt_Rec") And _Stt_Rec <> "" Then
                    Dim _Drs As DataRow() = Dt_Data.Select("Stt_Rec= '" + _Stt_Rec + "'")
                    If _Drs.Length > 0 Then
                        If Dt_Data.Columns.Contains("So_RO") Then _So_Ro = _Drs(0).Item("So_RO")
                        If Dt_Data.Columns.Contains("Ma_CT") Then If Not _Drs(0).Item("Ma_Ct").ToUpper.Trim = M_Ma_CT_PKH.ToUpper.Trim Then Return
                    End If
                End If
            End If
        End If

        CyberWork.V_Up_TG_GX(M_Ma_TTCP, M_Loai_SC, _Stt_Rec_RO, _So_Ro, AppConn, Me.Sysvar, Me.Para, M_LAN, M_Ma_Dvcs, M_User_Name, False, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberVoucher, CyberLoading)

    End Sub
    Private Sub V_Refresh_Load_Default(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberFill.V_FillComBoxDefaul(CbbGio_Xem, Dt_Gio_Xem_Tien_Do, "Gio_Xem", IIf(M_LAN = "V", "Ten_Xem", "Ten2_Xem"), "Ngam_Dinh")
        V_Gio_Xem(sender, e)
    End Sub
#End Region
#Region "----------Sự kiện - Footer"
#Region "----------Sự kiện - Footer:1. Ngày,Giờ xem, Loại xem, Bước ngày, độ rộng, Độ cao của chíp, Độ rộng của Head"
    Private Sub V_Ngay_Ct_Tien_Do(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Ngay_Ct_Tien_Do()
        V_LoadDatabasesALL("1", "", "")

        V_SetSchedulerControl()
    End Sub
    Private Sub V_Ngay_Ct_Tien_Do()
        Dim _Ngay_Ct As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Ngay_Ngam_Dinh", M_Kieu_Xem & "#" & M_Loai_SC & "#" & _Ngay_Ct.ToString("yyyyMMdd") & "#" & M_Ma_Dvcs + "#" & M_User_Name)
        If Dt_Ngay_Tien_Do Is Nothing Then
            Dt_Ngay_Tien_Do = DsTmp.Tables(0).Copy
        Else
            Dt_Ngay_Tien_Do.Clear()
            Dt_Ngay_Tien_Do.ImportRow(DsTmp.Tables(0).Rows(0))
        End If
        DsTmp.Dispose()
        V_Set_Ngay_Ct_Tien_Do()

    End Sub
    Private Sub V_Set_Ngay_Ct_Tien_Do()
        M_Thu_Bay = Dt_Ngay_Tien_Do.Rows(0).Item("Thu_Bay").ToString.Trim
        M_Chu_Nhat = Dt_Ngay_Tien_Do.Rows(0).Item("Chu_Nhat").ToString.Trim

        M_StartHour = Dt_Ngay_Tien_Do.Rows(0).Item("StartHour")
        M_FinishHour = Dt_Ngay_Tien_Do.Rows(0).Item("FinishHour")
        M_StartMINUTE = Dt_Ngay_Tien_Do.Rows(0).Item("StartMINUTE")
        M_FinishMINUTE = Dt_Ngay_Tien_Do.Rows(0).Item("FinishMINUTE")
        M_Ngay_LimitInterval_Min = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_LimitInterval_Min")
        M_Ngay_LimitInterval_Max = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_LimitInterval_Max")

        If Dt_Ngay_Tien_Do.Columns.Contains("Ngay_Sang1") Then
            Dim _Dt As DateTime = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Sang1")
            M_Gio_Sang1 = _Dt.Hour
            M_Phut_Sang1 = _Dt.Minute
        End If

        If Dt_Ngay_Tien_Do.Columns.Contains("Ngay_Sang2") Then
            Dim _Dt As DateTime = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Sang2")
            M_Gio_Sang2 = _Dt.Hour
            M_Phut_Sang2 = _Dt.Minute
        End If

        If Dt_Ngay_Tien_Do.Columns.Contains("Ngay_Chieu1") Then
            Dim _Dt As DateTime = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Chieu1")
            M_Gio_Chieu1 = _Dt.Hour
            M_Phut_Chieu1 = _Dt.Minute
        End If

        If Dt_Ngay_Tien_Do.Columns.Contains("Ngay_Chieu2") Then
            Dim _Dt As DateTime = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Chieu2")
            M_Gio_Chieu2 = _Dt.Hour
            M_Phut_Chieu2 = _Dt.Minute
        End If

        SchedulerControl.LimitInterval.Start = M_Ngay_LimitInterval_Min
        SchedulerControl.LimitInterval.End = M_Ngay_LimitInterval_Max
        SchedulerControl.Start = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Ct")
        TxtM_Ngay_Ct_KH_SCC.Value = Dt_Ngay_Tien_Do.Rows(0).Item("Ngay_Ct")
    End Sub
    Private Sub V_Gio_Xem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Gio_Xem As String = CyberWork.V_GetvalueCombox(CbbGio_Xem)
        If _Gio_Xem = "01" Then V_ActiView_Gantt(sender, e)
        If _Gio_Xem = "02" Then V_ActiView_Day(sender, e)
        V_SetAppointmentHeight()
    End Sub
    Dim M_Loai_XemOld As String = ""
    Private Sub V_Loai_Xem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Timer As Boolean = V_GetEnableTimer()
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm("Đang thực hiện", "Waiting", M_LAN)
        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)
        '----Load lai du lieu khi doi phuong phap xem
        If (M_Loai_SC = "2") Then V_LoadData_Tien_Do("0", "", "")

        V_SetSchedulerSetValue()

        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        M_Loai_XemOld = _Loai_Xem

        If _Timer Then V_SetEnableTimer()
        V_SetAppointmentHeight()

    End Sub
    Private Sub V_Buoc_Nhay(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_CyberSetTime_Tien_Do()
        V_Do_Rong(sender, e)
    End Sub
    Private Sub V_Do_Rong(ByVal sender As System.Object, ByVal e As System.EventArgs)
        For i = 0 To 6
            If SchedulerControl.GanttView.Scales(i).Visible Then SchedulerControl.Views.GanttView.Scales(i).Width = CyberWork.V_GetvalueCombox(CbbDo_Rong_KH_SCC)
        Next
        If SchedulerControl.ActiveViewType = SchedulerViewType.Day Then SchedulerControl.DayView.RowHeight = CyberWork.V_GetvalueCombox(CbbDo_Rong_KH_SCC)
    End Sub
    Private Sub V_SetAppointmentHeight()
        If Not _TabVisible3 Then Return
        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)

        If Dt_Loai_Xem Is Nothing Then Return
        If Not Dt_Loai_Xem.Columns.Contains("Is_AppointmentHeight") Then Return
        If Not Dt_Loai_Xem.Columns.Contains("AppointmentHeight") Then Return
        If Not Dt_Loai_Xem.Columns.Contains("Loai") Then Return
        Dim _Dr As DataRow()
        _Dr = Dt_Loai_Xem.Select("Loai = '" & _Loai_Xem & "'")
        If _Dr.Length = 0 Then Return

        Dim _Is_AppointmentHeight As String = _Dr(0).Item("Is_AppointmentHeight")
        Dim _AppointmentHeight As Decimal = _Dr(0).Item("AppointmentHeight")

        If _Is_AppointmentHeight = 0 Then Return
        If _AppointmentHeight = 0 Then Return

        '--------------------------------
        CyberSupport.V_SetAppointmentHeight(SchedulerControl, _AppointmentHeight, Sysvar)

    End Sub
    Private Sub V_SetRowHeight()
        If Not _TabVisible3 Then Return
        Dim _RowHeight As Decimal = 0
        Dim _RowPage As Decimal = 0
        If Dt_Ngay_Tien_Do Is Nothing Then Return
        If Dt_Ngay_Tien_Do.Rows.Count = 0 Then Return
        If Dt_Ngay_Tien_Do.Columns.Contains("RowHeight") Then _RowHeight = Dt_Ngay_Tien_Do.Rows(0).Item("RowHeight")
        If Dt_Ngay_Tien_Do.Columns.Contains("RowPage") Then _RowPage = Dt_Ngay_Tien_Do.Rows(0).Item("RowPage")
        CyberSupport.V_SetRowHeight(SchedulerControl, _RowHeight, _RowPage, Sysvar)

    End Sub
#End Region
#Region "----------Sự kiện - Footer:2. Filter"
    Private Sub V_Filter_KHSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.BeginUpdate()

        Dim _StrFilter As String = ""
        _StrFilter = V_GetFilter_KHSC(Dt_Data)

        Dim _StrFilterXe As String = ""
        _StrFilterXe = V_GetFilter_KHSC(Dm_Xe)

        Dim _StrFilterKhoang As String = ""
        _StrFilterKhoang = V_GetFilter_KHSC(Dm_khoang, True, True)

        Dim _StrFilterKTV As String = ""
        _StrFilterKTV = V_GetFilter_KHSC(Dm_KTV, True, True)

        Dim _StrFilterCD As String = ""
        _StrFilterCD = V_GetFilter_KHSC(Dm_CD, True, True)

        Dim _StrFilterTo As String = ""
        _StrFilterTo = V_GetFilter_KHSC(Dm_To, True, True)

        Set_Filter(Dv_Data, _StrFilter)
        Set_Filter(Dv_Xe, _StrFilterXe)
        Set_Filter(Dv_khoang, _StrFilterKhoang)
        Set_Filter(Dv_KTV, _StrFilterKTV)
        Set_Filter(Dv_CD, _StrFilterCD)
        Set_Filter(Dv_To, _StrFilterTo)

        SchedulerControl.EndUpdate()
        'T_tinh_So_Xe()

    End Sub
    Private Function V_GetFilter_KHSC(ByVal _DT_Filter As DataTable, Optional ByVal _Is_Non_xe As Boolean = False, Optional ByVal _Is_Non_Ro As Boolean = False) As String
        Dim _StrFilter As String = "1=1"
        Dim _KeyFilterOr As String = ""

        If _DT_Filter Is Nothing Then Return _StrFilter
        Dim _Ma_Hs As String = CyberWork.V_GetvalueCombox(CbbCVDV_KH_SCC)
        If _DT_Filter.Columns.Contains("Ma_Hs") And _Ma_Hs <> "" Then _StrFilter = _StrFilter + " AND Ma_Hs = '" + _Ma_Hs.Trim + "'"

        Dim _Ma_Khoang As String = CyberWork.V_GetvalueCombox(CbbKhoang_KH_SCC)
        If _DT_Filter.Columns.Contains("Ma_Khoang") And _Ma_Khoang <> "" Then _StrFilter = _StrFilter + " AND Ma_khoang = '" + _Ma_Khoang.Trim + "'"


        Dim _Ma_To As String = CyberWork.V_GetvalueCombox(CbbTo_KH_SCC)
        If _DT_Filter.Columns.Contains("Ma_To") Or _DT_Filter.Columns.Contains("Ma_To1") Or _DT_Filter.Columns.Contains("Ma_To2") Or _DT_Filter.Columns.Contains("Ma_To3") Or _DT_Filter.Columns.Contains("Ma_To4") Or _DT_Filter.Columns.Contains("Ma_To5") Or _DT_Filter.Columns.Contains("Ma_To6") Then
            If _Ma_To.Trim <> "" Then
                _StrFilter = _StrFilter + " AND ("
                If _DT_Filter.Columns.Contains("ma_To") Then _StrFilter = _StrFilter + "(Ma_To = '" + _Ma_To.Trim + "')"
                If _DT_Filter.Columns.Contains("ma_To2") Then _StrFilter = _StrFilter + "OR (Ma_To2 = '" + _Ma_To.Trim + "')"
                If _DT_Filter.Columns.Contains("ma_To3") Then _StrFilter = _StrFilter + "OR (ma_To3 = '" + _Ma_To.Trim + "')"
                If _DT_Filter.Columns.Contains("ma_To4") Then _StrFilter = _StrFilter + "OR (ma_To4 = '" + _Ma_To.Trim + "')"
                If _DT_Filter.Columns.Contains("ma_To5") Then _StrFilter = _StrFilter + "OR (ma_To5 = '" + _Ma_To.Trim + "')"
                If _DT_Filter.Columns.Contains("ma_To6") Then _StrFilter = _StrFilter + "OR (ma_To6 = '" + _Ma_To.Trim + "')"
                _StrFilter = _StrFilter + ")"
            End If
        End If




        Dim _Ma_CD As String = CyberWork.V_GetvalueCombox(CbbCD_KH_SCC)
        If _DT_Filter.Columns.Contains("Ma_CD") And _Ma_CD <> "" Then _StrFilter = _StrFilter + " AND Ma_CD = '" + _Ma_CD.Trim + "'"

        Dim _Tang As String = CyberWork.V_GetvalueCombox(CbbTang_KH_SCC)
        If _DT_Filter.Columns.Contains("Tang") And _Tang <> "" Then _StrFilter = _StrFilter + " AND Tang = '" + _Tang.Trim + "'"

        If Not _Is_Non_xe Then
            Dim _Ma_Xe As String = TxtMa_Xe_KH_SCC.Text
            If _DT_Filter.Columns.Contains("Ma_Xe") And _Ma_Xe <> "" Then _StrFilter = _StrFilter + " AND Ma_Xe LIKE '%" + _Ma_Xe.Trim + "%'"
        End If

        If Not _Is_Non_Ro Then
            Dim _So_RO As String = TxtSo_RO_KH_SCC.Text
            If _DT_Filter.Columns.Contains("So_RO") And _So_RO <> "" Then _StrFilter = _StrFilter + " AND So_RO LIKE '%" + _So_RO.Trim + "%'"

        End If

        '------------------------------------------------
        Dim _Muc_SBD As String = CyberWork.V_GetvalueCombox(CbbMuc_SBD_KH_SCC)
        If ChkSBD_KH_SCC.Checked And _Muc_SBD.Trim <> "" Then
            If _DT_Filter.Columns.Contains("Muc_SBD") Then _StrFilter = _StrFilter + " AND Muc_SBD = '" + _Muc_SBD.Trim + "'"
        End If
        Dim _Muc_SDS As String = CyberWork.V_GetvalueCombox(CbbMuc_SDS_KH_SCC)
        If ChkSDS_KH_SCC.Checked And _Muc_SDS.Trim <> "" Then
            If _DT_Filter.Columns.Contains("Muc_SDS") Then _StrFilter = _StrFilter + " AND Muc_SDS = '" + _Muc_SDS.Trim + "'"
        End If
        '------------------------------------------------
        If ChkUu_Tien.Checked And _DT_Filter.Columns.Contains("Uu_Tien") Then _StrFilter = _StrFilter + " AND Uu_Tien = '1'"
        If ChkFV_KH_SCC.Checked And _DT_Filter.Columns.Contains("first_visit") Then _StrFilter = _StrFilter + " AND first_visit = '1'"
        If ChkDung_KH_SCC.Checked And _DT_Filter.Columns.Contains("Dung") Then _StrFilter = _StrFilter + " AND Dung = '1'"
        If ChkSDS_KH_SCC.Checked And _DT_Filter.Columns.Contains("SDS") Then _StrFilter = _StrFilter + " AND SDS = '1'"
        If ChkCho_Rua_KH_SCC.Checked And _DT_Filter.Columns.Contains("Cho_Rua") Then _StrFilter = _StrFilter + " AND Cho_Rua = '1'"
        If ChkDang_Rua_KH_SCC.Checked And _DT_Filter.Columns.Contains("Dang_Rua") Then _StrFilter = _StrFilter + " AND Dang_Rua = '1'"
        If ChkCho_Giao_KH_SCC.Checked And _DT_Filter.Columns.Contains("Cho_Giao") Then _StrFilter = _StrFilter + " AND Cho_Giao = '1'"
        If ChkGiao_Ngay_Kh_SCC.Checked And _DT_Filter.Columns.Contains("Giao_Ngay") Then _StrFilter = _StrFilter + " AND Giao_Ngay = '1'" 'Hadv bổ sung 08.06.2019

        If ChkEM60_KH_SCC.Checked And _DT_Filter.Columns.Contains("EM60") Then _StrFilter = _StrFilter + " AND Em60 = '1'"
        If ChkPM90_KH_SCC.Checked And _DT_Filter.Columns.Contains("Pm90") Then _StrFilter = _StrFilter + " AND Pm90 = '1'"
        If ChkSCL_KH_SCC.Checked And _DT_Filter.Columns.Contains("SCL") Then _StrFilter = _StrFilter + " AND SCL = '1'"

        If ChkIs_EM_KH_SCC.Checked And _DT_Filter.Columns.Contains("Is_Em") Then _StrFilter = _StrFilter + " AND Is_Em = '1'"
        If ChkIs_GJ_KH_SCC.Checked And _DT_Filter.Columns.Contains("Is_GJ") Then _StrFilter = _StrFilter + " AND Is_GJ = '1'"
        '------------------------------------------------        
        Return _StrFilter
    End Function
    Private Sub Set_Filter(ByVal _dv As DataView, ByVal _StrFilter As String)
        If Not _dv Is Nothing Then
            Try
                _dv.RowFilter = _StrFilter
            Catch ex As Exception
            End Try
        End If
    End Sub
#End Region
#Region "----------Sự kiện - Footer:3. Timer"
    Private Function V_GetEnableTimer() As Boolean
        Dim _Return As Boolean = False
        If Timer_Data_KH_SC.Enabled Then _Return = True
        If _Return Then Timer_Data_KH_SC.Enabled = False
        Return _Return
    End Function
    Private Sub V_SetEnableTimer()
        Timer_Data_KH_SC.Enabled = True
    End Sub
    Private Sub V_Auto_Data_Tien_Do(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Timer_Data_KH_SC.Enabled = ChkAuto_Data_KH_SCC.Checked
        CbbTime_Data_KH_SCC.Enabled = ChkAuto_Data_KH_SCC.Checked
        Dim _TimeData As Decimal = CyberWork.V_StringToNumeric(CbbTime_Data_KH_SCC)
        If _TimeData <= 0 Then _TimeData = 3000
        Timer_Data_KH_SC.Interval = _TimeData
    End Sub
    Private Sub V_Timer_Data(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Timer_Data_KH_SC.Enabled Then Exit Sub
        V_LoadDatabasesALL("0", "", "")
        'abc
    End Sub
    Private Sub V_Timer_PercentComplete(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Timer_PercentComplete.Enabled Then Exit Sub
        V_PercentComplete_KHSC("", "")
        'abc
    End Sub
    Private Sub V_PercentComplete_KHSC(Optional ByVal _Stt_Rec As String = "", Optional ByVal _So_Ro As String = "")

    End Sub
#End Region
#Region "----------Sự kiện - Footer:4. Nút lệnh: Reset Defaul/LockData/Up_Tg_GX"
    Private Sub V_Remove_Filter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtSo_Ro_Cho_Lap_KH.Text = ""
        TxtSo_RO_KH_SCC.Text = ""
        TxtMa_Xe_Cho_Lap_KH.Text = ""
        TxtMa_Xe_KH_SCC.Text = ""
        ChkShow_All_Cd_Xe.Checked = False
        ChkDu_kien_giaoCVDV.Checked = False

        V_SetNgamDinh(CbbDo_Rong_KH_SCC, Dt_Do_Rong_Tien_Do, "Ma_Width", "Ngam_Dinh")
        V_SetNgamDinh(CbbLoai_Xem_KH_SCC, Dt_Loai_Xem_Tien_Do, "Loai", "Ngam_Dinh")
        V_SetNgamDinh(CbbGio_Xem, Dt_Loai_Xem_Tien_Do, "Gio_Xem", "Ngam_Dinh")


        V_SetNgamDinh(CbbKhoang_KH_SCC, Dt_Khoang_Tien_Do, "Ma_Khoang", "Ngam_Dinh")
        V_SetNgamDinh(CbbTo_KH_SCC, Dt_To_Tien_Do, "Ma_To", "Ngam_Dinh")
        V_SetNgamDinh(CbbCD_KH_SCC, Dt_CD_Tien_Do, "Ma_CD", "Ngam_Dinh")
        V_SetNgamDinh(CbbTang_KH_SCC, Dt_Tang_Tien_Do, "Tang", "Ngam_Dinh")
        V_SetNgamDinh(CbbMa_BN_KH_SCC, Dt_Buoc_Nhay_Tien_Do, "Ma_BN", "Ngam_Dinh")

        V_SetNgamDinh(CbbCVDV_KH_SCC, Dt_CVDV_Tien_Do, "Ma_Hs", "Ngam_Dinh")
        V_SetNgamDinh(CbbMuc_SBD_KH_SCC, Dt_MucSBD_Tien_Do, "Muc_SBD", "Ngam_Dinh")
        V_SetNgamDinh(CbbMuc_SDS_KH_SCC, Dt_MucSDS_Tien_Do, "Muc_SDS", "Ngam_Dinh")

        V_Filter_KHSC(sender, e)


    End Sub
    Private Sub V_SetNgamDinh(ByVal _cmb As ComboBox, ByVal _Dt As DataTable, ByVal _FieldKey As String, Optional ByVal _FielNgamDinh As String = "Ngam_Dinh")
        If _Dt Is Nothing Then Return
        If Not _Dt.Columns.Contains(_FieldKey) Then Return
        If Not _Dt.Columns.Contains(_FielNgamDinh) Then Return
        Dim _Str As String = _FielNgamDinh + " = '1'"
        Try
            Dim _Dr As DataRow() = _Dt.Select(_Str)
            If _Dr.Length > 0 Then _cmb.SelectedValue = _Dr(0).Item(_FieldKey).ToString.Trim
        Catch ex As Exception
        End Try
    End Sub
    Private Sub V_Lock_Data(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Return As Boolean = CyberWork.V_Lock_Tien_Do(M_Kieu_Xem, M_Loai_SC, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        '     If Not _Return Then Return
        V_Lock_Xem()
    End Sub
    Private Sub V_Lock_Xem()
        Dim _Ngay_Ct As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Lock_Unlock_Xem", M_Kieu_Xem + "#" + M_Loai_SC + "#" + _Ngay_Ct.ToString("yyyyMMdd") + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Columns.Contains("Caption_Lock") Then LabLock.Text = Dstmp.Tables(0).Rows(0).Item("Caption_Lock")
        If Dstmp.Tables(0).Columns.Contains("BackColor") Then LabLock.BackColor = CyberColor.GetBackColor(Dstmp.Tables(0).Rows(0).Item("BackColor"))
        If Dstmp.Tables(0).Columns.Contains("ForeColor") Then LabLock.ForeColor = CyberColor.GetForeColor(Dstmp.Tables(0).Rows(0).Item("ForeColor"))

        If Dstmp Is Nothing Then Return
        Dstmp.Dispose()
    End Sub
    Private Sub V_UP_TG_TX_KH_SCC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec_Ro As String = ""
        Dim _So_Ro As String = ""
        CyberWork.V_Up_TG_GX(M_Ma_TTCP, M_Loai_SC, _Stt_Rec_Ro, _So_Ro, AppConn, Me.Sysvar, Me.Para, M_LAN, M_Ma_Dvcs, M_User_Name, False, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberVoucher, CyberLoading)
    End Sub
    Private Sub Label_Xem_BC_KH_SCC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strField As String = "", strValue As String = ""
        Dim Form As New FrmTiendo_Xem_KH
        Form.AppConn = AppConn
        Form.Para = Me.Para
        Form.Sysvar = Me.Sysvar
        Form.M_LAN = Me.M_LAN
        Form.M_User_Name = M_User_Name
        Form.M_Ma_Dvcs = M_Ma_Dvcs
        Form.Loai_SC = M_Loai_SC
        Form.Ngay_Ct1 = TxtM_Ngay_Ct_KH_SCC.Value
        Form.Ngay_Ct2 = TxtM_Ngay_Ct_KH_SCC.Value
        Form.ShowDialog()
        If Not Form.Save_OK = True Then
            Exit Sub
        End If
    End Sub
#End Region
#Region "----------Scheduler -View"
    Private Sub V_ActiView_Day(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.Day
        V_CyberSetTime_Tien_Do()
        SchedulerControl.OptionsView.ResourceHeaders.Height = 30
    End Sub
    Private Sub V_ActiView_Gantt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.Gantt
        V_CyberSetTime_Tien_Do()
        SchedulerControl.OptionsView.ResourceHeaders.Height = 80
    End Sub
    Private Sub V_ActiView_FullWeek(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.FullWeek
    End Sub
    Private Sub V_ActiView_Month(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.Month
    End Sub
    Private Sub V_ActiView_Agenda(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.Agenda
    End Sub
    Private Sub V_ActiView_Timeline(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.Timeline
    End Sub
    Private Sub V_ActiView_Week(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.Week
    End Sub
    Private Sub V_ActiView_WorkWeek(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SchedulerControl.ActiveViewType = SchedulerViewType.WorkWeek
    End Sub
#End Region

#Region "----------Sự kiện - Tree; Tootltip"
    Private Sub ResourcesTree_CustomDrawNodeCell(ByVal sender As System.Object, ByVal e As DevExpress.XtraTreeList.CustomDrawNodeCellEventArgs)
        CyberSupport.ResourcesTree_CustomDrawNodeCell(sender, e, CyberColor)
    End Sub
    Private Sub ToolTipController_BeforeShow(ByVal sender As Object, ByVal e As DevExpress.Utils.ToolTipControllerShowEventArgs)
        'Handles ToolTipController1.BeforeShow
        Dim controller As DevExpress.Utils.ToolTipController = TryCast(sender, DevExpress.Utils.ToolTipController)
        Dim aptViewInfo As DevExpress.XtraScheduler.Drawing.AppointmentViewInfo = TryCast(controller.ActiveObject, DevExpress.XtraScheduler.Drawing.AppointmentViewInfo)
        If aptViewInfo Is Nothing Then
            Return
        End If
        Dim _Stt_Rec = aptViewInfo.Appointment.Id
        Dim dr() As DataRow = Dt_Data.Select("Stt_Rec = '" & _Stt_Rec & "'")
        If dr.Length < 1 Then
            Exit Sub
        End If
        Dim drDt As DataRow = dr(0)
        If ToolTipController1.ToolTipType = DevExpress.Utils.ToolTipType.SuperTip Then
            Dim SuperTip As New DevExpress.Utils.SuperToolTip()
            Dim args As New DevExpress.Utils.SuperToolTipSetupArgs()
            args.Title.Text = drDt("Ma_Xe").ToString
            args.Title.Font = New Font(Me.Font.FontFamily, 11, FontStyle.Bold)
            args.Title.Image = My.Resources.refresh2_16x16
            If M_Loai_SC = "2" And CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC) = "01" Then
                If drDt.Table.Columns.Contains("Ten_Khoang") Then args.Contents.Text = drDt("Ten_Khoang").ToString
            Else
                If drDt.Table.Columns.Contains("Dien_Giai") Then args.Contents.Text = drDt("Dien_Giai").ToString
            End If
            args.ShowFooterSeparator = True
            args.Footer.Font = New Font(Me.Font.FontFamily, 10)
            args.Footer.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True
            If drDt.Table.Columns.Contains("Tootip") Then args.Footer.Text = drDt("Tootip").ToString
            SuperTip.Setup(args)
            e.SuperTip = SuperTip
        End If
    End Sub
#End Region
#Region "----------Sự kiện - SchedulerControl - SCC/SĐS"
    Private Sub V_Tao_KH_ALLS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Set_Auto_Refresh(False)
        Dim _Stt_Rec_Ro As String = ""
        Dim _Stt_rec As String = ""
        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End
        Dim _So_RO As String = ""
        '----------------------------
        Dim _ma_khoang As String = ""
        Dim _Ma_CVDV As String = ""
        Dim _Ma_To As String = ""
        Dim _Ma_Xe As String = ""
        Dim _Ma_CD As String = ""
        Dim _ma_Ct As String = M_Ma_CT_PKH
        Dim _Mode As String = "M"
        Dim _Ma_KTV As String = ""
        V_GetFromSetScheduler(_Ngay_Bd, _Ngay_Kt, _Stt_Rec_Ro, _So_RO, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV)
        If _ma_Ct.Trim = "" Then Return
        Dim Dt_Return As DataTable = Nothing
        V_Tao_Moi_SDSALL("M", M_Ma_CT_PKH, _Stt_rec, _Stt_Rec_Ro, _So_RO, _Ngay_Bd, _Ngay_Kt, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV)
    End Sub
    Private Sub V_Tao_Moi_SDSALL(ByVal _Mode As String, ByVal _ma_Ct As String, ByVal _Stt_rec As String, ByVal _Stt_rec_RO As String, ByVal _So_Ro As String, ByVal _Ngay_BD As Date, ByVal _Ngay_KT As Date, ByVal _ma_khoang As String, ByVal _Ma_CVDV As String, ByVal _Ma_To As String, ByVal _Ma_Xe As String, ByVal _Ma_CD As String, ByVal _Ma_KTV As String)
        If Not V_ChkStt_Rec(_Stt_rec) Then Return '---Khong lam gi o phan thuc hien
        If _ma_Ct.Trim = "" Then Return

        Dim Dt_Return As DataTable = CyberWork.V_KH_SDSALL(M_Ma_TTCP, _ma_Ct, _Mode, M_Kieu_Xem, "2", _Stt_rec, _Stt_rec_RO, _So_Ro, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV, _Ngay_BD, _Ngay_KT, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

        If Dt_Return Is Nothing Then Return
        If Dt_Return.Rows.Count = 0 Then Return
        If Dt_Return.Rows.Count = 0 Then Return
        If Not Dt_Return.Columns.Contains("Stt_Rec_Ro") Then Return
        Dim _Stt_Rec_Ro_Load As String = Dt_Return.Rows(0).Item("Stt_Rec_Ro").ToString.Trim
        V_LoadDatabasesALL("0", "", _Stt_Rec_Ro_Load)
        '---------------------------------------
    End Sub
    Private Sub V_Tao_Tien_Do_KH_SCC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Set_Auto_Refresh(False)
        Dim _Stt_Rec_Ro As String = ""
        Dim _Stt_rec As String = ""
        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End
        Dim _So_RO As String = ""
        '    Dim _Ma_khoang As String = SchedulerControl_KH_SCC.SelectedResource.Id.ToString.Trim
        '----------------------------
        Dim _ma_khoang As String = ""
        Dim _Ma_CVDV As String = ""
        Dim _Ma_To As String = ""
        Dim _Ma_Xe As String = ""
        Dim _Ma_CD As String = ""
        Dim _Ma_KTV As String = ""
        V_GetFromSetScheduler(_Ngay_Bd, _Ngay_Kt, _Stt_Rec_Ro, _So_RO, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV)

        If _Stt_Rec_Ro = "" And M_Stt_Rec_Ro <> "" Then _Stt_Rec_Ro = M_Stt_Rec_Ro
        V_Tao_Sua_Tien_Do_KH_SCC("M", M_Ma_CT_PKH, _Stt_rec, _Stt_Rec_Ro, _So_RO, _Ngay_Bd, _Ngay_Kt, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV)

    End Sub
    Private Sub V_Sua_Tien_Do_KH_SCC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Set_Auto_Refresh(False)

        Dim _Stt_Rec_Ro As String = ""
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Return
        If Not V_ChkStt_Rec(_Stt_Rec) Then Return '---Khong lam gi o phan thuc hien

        'If V_GetMa_Ct(_Stt_Rec) = "PKH" And M_Kieu_Xem = "HEN" Then Return
        V_Set_Auto_Refresh(False)
        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End
        Dim _So_RO As String = ""
        Dim _ma_Ct As String = V_GetMa_Ct(_Stt_Rec)
        '--------------------------------------------------------------------------------------------------
        Dim _ma_khoang As String = ""
        Dim _Ma_CVDV As String = ""
        Dim _Ma_To As String = ""
        Dim _Ma_Xe As String = ""
        Dim _Ma_CD As String = ""
        Dim _Ma_KTV As String = ""
        V_GetFromSetScheduler(_Ngay_Bd, _Ngay_Kt, _Stt_Rec_Ro, _So_RO, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV)
        V_Tao_Sua_Tien_Do_KH_SCC("S", _ma_Ct, _Stt_Rec, _Stt_Rec_Ro, _So_RO, _Ngay_Bd, _Ngay_Kt, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV)

    End Sub
    Private Function V_Tao_Sua_Tien_Do_KH_SCC(ByVal _Mode As String, ByVal _ma_Ct As String, ByVal _Stt_rec As String, ByVal _Stt_rec_RO As String, ByVal _So_Ro As String, ByVal _Ngay_BD As Date, ByVal _Ngay_KT As Date, ByVal _ma_khoang As String, ByVal _Ma_CVDV As String, ByVal _Ma_To As String, ByVal _Ma_Xe As String, ByVal _Ma_CD As String, ByVal _Ma_KTV As String) As Boolean
        If Not V_ChkStt_Rec(_Stt_rec) Then Return False '---Khong lam gi o phan thuc hien
        If _ma_Ct.Trim = "" Then Return False
        '------------------------------------------------2019.05.28
        If _Mode = "S" And Not V_Chk_Righ(_Stt_rec, "SUA") Then Return False
        '------------------------------------------------2019.05.28
        Dim Dt_Return As DataTable = Nothing
        Select Case _ma_Ct.ToString.Trim.ToUpper
            Case M_Ma_CT_PKH.ToString.Trim.ToUpper
                Dt_Return = CyberWork.V_KH_SCC(M_Ma_TTCP, _ma_Ct, _Mode, M_Kieu_Xem, M_Loai_SC, _Stt_rec, _Stt_rec_RO, _So_Ro, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV, _Ngay_BD, _Ngay_KT, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
            Case M_Ma_CT_DLH.ToString.Trim.ToUpper
                Dt_Return = CyberWork.V_Lich_Hen(M_Ma_TTCP, _ma_Ct, _Mode, M_Kieu_Xem, M_Loai_SC, _Stt_rec, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV, _Ngay_BD, _Ngay_KT, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)

            Case M_Ma_CT_PDC.ToString.Trim.ToUpper
                Dt_Return = CyberWork.V_Dat_Cho(M_Ma_TTCP, _ma_Ct, _Mode, M_Kieu_Xem, M_Loai_SC, _Stt_rec, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV, _Ngay_BD, _Ngay_KT, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        End Select
        V_LoadDatabasesALL(Dt_Return)
        '--------------
        V_Tao_Sua_Tien_Do_KH_SCC = Not Dt_Return Is Nothing
    End Function
    Private Sub V_Xoa_Tien_Do_KH_SCC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Set_Auto_Refresh(False)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Return
        If Not V_ChkStt_Rec(_Stt_Rec) Then Return '---Khong lam gi o phan thuc hien
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_DELETE", M_Kieu_Xem + "#" + M_Loai_SC + "#" + _Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim _Dt_Return As DataTable = Nothing
        If CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then _Dt_Return = DsTmp.Tables(0).Copy
        DsTmp.Dispose()

        V_LoadDatabasesALL(_Dt_Return)
    End Sub
#End Region
#Region "----------Sự kiện - SchedulerControl - In phiếu giao việc/Bắt đầu kết thúc sửa chữa/Chuyển giao xe"
    Private Sub V_Giao_Viec_Print(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec As String = ""
        Dim _So_RO As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Exit Sub
        Dim _ma_Ct As String = V_GetMa_Ct(_Stt_Rec)
        If _ma_Ct <> M_Ma_CT_PKH Then Return

        Dim DsPrint As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_GiaoViec_KTV_Print", M_Kieu_Xem & "#" & M_Loai_SC & "#" & _Stt_Rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsPrint.Tables(0), Me.Sysvar, M_LAN) Then
            DsPrint.Dispose()
            Return
        End If
        Dim _ReportName As String = ""
        Dim _Title1 As String = "BẢNG THEO DÕI THỜI GIAN THỰC HIỆN CÔNG VIỆC"
        Dim _Title2 As String = "BẢNG THEO DÕI THỜI GIAN THỰC HIỆN CÔNG VIỆC"
        If DsPrint.Tables(0).Columns.Contains("ReportName") Then _ReportName = DsPrint.Tables(0).Rows(0).Item("ReportName").ToString.Trim()
        If DsPrint.Tables(0).Columns.Contains("Title1") Then _Title1 = DsPrint.Tables(0).Rows(0).Item("Title1").ToString.Trim
        If DsPrint.Tables(0).Columns.Contains("Title2") Then _Title2 = DsPrint.Tables(0).Rows(0).Item("Title2").ToString.Trim
        DsPrint.Tables.Remove(DsPrint.Tables(0))
        CyberWork.V_Print(AppConn, M_Ma_Dvcs, M_LAN, "1", True, True, _ReportName, DsPrint, _Title1, _Title2, Me.Sysvar, Me.Para)
    End Sub
    Private Sub V_XN_BD_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Set_Auto_Refresh(False)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Return
        If Not V_ChkStt_Rec(_Stt_Rec) Then Return '---Khong lam gi o phan thuc hien
        If MsgBox("Bạn có xác nhận bắt đầu không?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Sysvar("M_CYBER_VER")) = MsgBoxResult.Cancel Then Return

        Dim _Phuong_Thuc As String = "1"
        Dim _StrKTV As String = ""
        Dim _Ghi_Chu As String = "Xác nhận trên bảng tiến độ"
        Dim _Loai_XN As String = "BD"
        Dim _Dt_Return As DataTable = CyberWork.V_Xac_Nhan(_Phuong_Thuc, _StrKTV, _Ghi_Chu, _Loai_XN, M_Kieu_Xem, M_Loai_SC, _Stt_Rec, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Dt_Return)
    End Sub
    Private Sub V_XN_KT_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Set_Auto_Refresh(False)

        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        If _Stt_Rec.Trim = "" Then Return
        If Not V_ChkStt_Rec(_Stt_Rec) Then Return '---Khong lam gi o phan thuc hien
        If MsgBox("Bạn có xác nhận kết thúc không?", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, Sysvar("M_CYBER_VER")) = MsgBoxResult.Cancel Then Return
        Dim _Phuong_Thuc As String = "1"
        Dim _StrKTV As String = ""
        Dim _Ghi_Chu As String = "Xác nhận trên bảng tiến độ"
        Dim _Loai_XN As String = "KT"
        Dim _Dt_Return As DataTable = CyberWork.V_Xac_Nhan(_Phuong_Thuc, _StrKTV, _Ghi_Chu, _Loai_XN, M_Kieu_Xem, M_Loai_SC, _Stt_Rec, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Dt_Return)
    End Sub
    Private Sub V_Giao_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Set_Auto_Refresh(False)

        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_RO As String = ""
        Dim _Ma_Xe As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then
            Try
                _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
            Catch ex As Exception

            End Try
        End If
        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        If _Stt_Rec.Trim <> "" And Dt_Data.Columns.Contains("Stt_Rec") And Dt_Data.Columns.Contains("Ma_Xe") Then
            Dim _Drs As DataRow() = Dt_Data.Select("Stt_Rec = '" + _Stt_Rec + "'")
            If _Drs.Length > 0 Then _Ma_Xe = _Drs(0).Item("Ma_Xe").ToString.Trim
        End If

        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)
        If _Loai_Xem.Trim = "05" Then
            Try
                _Stt_Rec_RO = SchedulerControl.SelectedResource.Id.ToString.Trim().ToUpper.Trim
                If _Stt_Rec_RO.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Stt_Rec_RO = ""
                If _Stt_Rec_RO.ToUpper.Trim Like "*DevExpress.XtraScheduler*".ToUpper.Trim Then _Stt_Rec_RO = ""
                _Stt_Rec_RO = _Stt_Rec_RO.Replace("_THUCHIEN", "")

                If _Ma_Xe.Trim = "" And _Stt_Rec_RO.Trim <> "" Then
                    If Not Dm_Xe Is Nothing Then
                        If Dm_Xe.Columns.Contains("Stt_Rec_RO") And Dm_Xe.Columns.Contains("Ma_Xe") Then
                            Dim _Drs As DataRow() = Dm_Xe.Select("Stt_Rec_Ro = '" + _Stt_Rec_RO + "'")
                            If _Drs.Length > 0 Then _Ma_Xe = _Drs(0).Item("Ma_Xe").ToString.Trim
                        End If
                    End If
                End If
            Catch ex As Exception
            End Try
        End If

        ''---------------------------------------------------------------------------------------
        If _Stt_Rec.Trim = "" And _Stt_Rec_RO.Trim = "" Then Return
        If MsgBox("Bạn có chắc chắn xe BKS " + _Ma_Xe.Trim + " đã sửa chữa xong không?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, Sysvar("M_CYBER_VER")) = MsgBoxResult.No Then Return
        ''---------------------------------------------------------------------------------------
        Dim _Dt_Return As DataTable = CyberWork.V_Giao_Xe(M_Kieu_Xem, M_Loai_SC, _Stt_Rec_RO, _Stt_Rec, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Dt_Return)
    End Sub
#End Region
#Region "----------Sự kiện - SchedulerControl - Hẹn sửa chữa"
    Private Sub V_Hen_Call_KHSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Set_Auto_Refresh(False)
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
        _Stt_Rec = _Stt_Rec.Trim.Replace("_THUCHIEN", "")
        If Not _Stt_Rec Like "*" & M_Ma_CT_DLH.Trim Then Return
        If _Stt_Rec.Trim = "" Then Return

        Dim _Return As Boolean = CyberWork.V_Hen_Call(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, "", AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        If Not _Return Then Return
        V_LoadDatabasesALL("0", _Stt_Rec, "")

    End Sub
    Private Sub V_Tao_Lich_Hen_KHSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Set_Auto_Refresh(False)

        Dim _Stt_Rec_Ro As String = ""
        Dim _Stt_rec As String = ""
        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End
        Dim _So_RO As String = ""
        '    Dim _Ma_khoang As String = SchedulerControl_KH_SCC.SelectedResource.Id.ToString.Trim
        '----------------------------
        Dim _ma_khoang As String = ""
        Dim _Ma_CVDV As String = ""
        Dim _Ma_To As String = ""
        Dim _Ma_Xe As String = ""
        Dim _Ma_CD As String = ""
        Dim _Ma_KTV As String = ""
        V_GetFromSetScheduler(_Ngay_Bd, _Ngay_Kt, _Stt_Rec_Ro, _So_RO, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV)
        V_Tao_Sua_Tien_Do_KH_SCC("M", M_Ma_CT_DLH, _Stt_rec, _Stt_Rec_Ro, _So_RO, _Ngay_Bd, _Ngay_Kt, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV)
    End Sub
    Private Sub V_Tao_Dat_CHo_KH_SCC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Stt_Rec_Ro As String = ""
        Dim _Stt_rec As String = ""
        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End
        Dim _So_RO As String = ""
        '    Dim _Ma_khoang As String = SchedulerControl_KH_SCC.SelectedResource.Id.ToString.Trim
        '----------------------------
        Dim _ma_khoang As String = ""
        Dim _Ma_CVDV As String = ""
        Dim _Ma_To As String = ""
        Dim _Ma_Xe As String = ""
        Dim _Ma_CD As String = ""
        Dim _Ma_KTV As String = ""
        V_GetFromSetScheduler(_Ngay_Bd, _Ngay_Kt, _Stt_Rec_Ro, _So_RO, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV)
        V_Tao_Sua_Tien_Do_KH_SCC("M", M_Ma_CT_PDC, _Stt_rec, _Stt_Rec_Ro, _So_RO, _Ngay_Bd, _Ngay_Kt, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV)
    End Sub
#End Region

#Region "----------Kéo thả chíp"
    Private Function V_Update_Keo_Tha_KH_SCC(ByVal _Appointment As Appointment) As Boolean
        Dim _Stt_Rec As String = ""
        If SchedulerControl.SelectedAppointments.Count > 0 Then
            Try
                _Stt_Rec = SchedulerControl.SelectedAppointments(0).Id.ToString
            Catch ex As Exception
            End Try
        End If
        If _Stt_Rec.ToString.Trim = "" Then Return False

        If Not V_ChkStt_Rec(_Stt_Rec) Then Return False '---Khong lam gi o phan thuc hien

        If V_GetMa_Ct(_Stt_Rec) = "PKH" And M_Kieu_Xem = "HEN" And InStr(_Stt_Rec, "_FN") Then Return False

        '----------------------------KHong thay doi duoc ngay o doan nay
        Dim _Ngay_Bd As Date = SchedulerControl.SelectedInterval.Start
        Dim _Ngay_Kt As Date = SchedulerControl.SelectedInterval.End

        Dim _Value As String = ""
        Try
            _Value = CyberSupport.GetvalueSelectedResource(_Appointment, SchedulerControl)
            If _Value.ToUpper.Trim = "DevExpress.XtraScheduler.EmptyResourceId".ToUpper.Trim Then _Value = ""
            _Value = _Value.Replace("_THUCHIEN", "")
        Catch ex As Exception
        End Try

        Dim _Loai_Xem As String = CyberWork.V_GetvalueCombox(CbbLoai_Xem_KH_SCC)

        Dim _Stt_Rec_Ro As String = ""
        Dim _So_RO As String = ""
        Dim _ma_khoang As String = ""
        Dim _Ma_CVDV As String = ""
        Dim _Ma_To As String = ""
        Dim _Ma_Xe As String = ""
        Dim _Ma_CD As String = ""
        Dim _Ma_KTV As String = ""



        '--------------------------------------------------------------------------------------------------
        Dim _Ngay_BdOld As Date
        Dim _Ngay_KtOld As Date
        Dim _Stt_Rec_RoOld As String = ""
        Dim _So_ROOld As String = ""
        Dim _ma_khoangOld As String = ""
        Dim _Ma_CVDVOld As String = ""
        Dim _Ma_ToOld As String = ""
        Dim _Ma_XeOld As String = ""
        Dim _Ma_CDOld As String = ""
        Dim _Ma_KTVOld As String = ""
        V_GetFromSetSchedulerOld(_Ngay_BdOld, _Ngay_KtOld, _Stt_Rec_RoOld, _So_ROOld, _ma_khoangOld, _Ma_CVDVOld, _Ma_ToOld, _Ma_XeOld, _Ma_CDOld, _Ma_KTVOld, _Appointment)
        '--------------------------------------------------------------------------------------------------

        V_GetFromSetScheduler(_Ngay_Bd, _Ngay_Kt, _Stt_Rec_Ro, _So_RO, _ma_khoang, _Ma_CVDV, _Ma_To, _Ma_Xe, _Ma_CD, _Ma_KTV, _Appointment)
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Keo_Tha", M_Kieu_Xem + "#" + M_Loai_SC + "#" + _Stt_Rec + "#" + _Loai_Xem + "#" + _Value + "#" + _
                                                                  _Ngay_Bd.ToString("yyyyMMdd HH:mm") + "#" + _Ngay_Kt.ToString("yyyyMMdd HH:mm") + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim _Dt_Return As DataTable = DsTmp.Tables(0).Copy
        DsTmp.Dispose()

        Dim _Return As Boolean = CyberSupport.V_MsgChk(_Dt_Return, Me.Sysvar, M_LAN)

        If _Return Then V_PercentComplete_KHSC(_Stt_Rec, "")
        If _Return Then V_LoadData_Tien_Do("0", _Dt_Return)
        If _Return Then If _Stt_Rec Like "*DLH*" And Not Dt_Hen Is Nothing Then V_LoadData_Hen("0", _Stt_Rec, "")

        Return _Return
    End Function
    Private Sub V_SchedulerControl_AppointmentDrop(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentDragEventArgs) '----Handles SchedulerControl_KH_SCC.AppointmentDrop
        V_Set_Auto_Refresh(False)
        Dim _Appointment As Appointment
        _Appointment = e.EditedAppointment
        Dim _Return As Boolean = V_Update_Keo_Tha_KH_SCC(_Appointment)

        e.Allow = _Return
    End Sub
    Private Sub V_SchedulerControl_AppointmentResized(ByVal sender As System.Object, ByVal e As DevExpress.XtraScheduler.AppointmentResizeEventArgs) '----Handles SchedulerControl_KH_SCC.AppointmentResized
        V_Set_Auto_Refresh(False)
        Dim _Appointment As Appointment
        _Appointment = e.EditedAppointment
        Dim _Return As Boolean = V_Update_Keo_Tha_KH_SCC(_Appointment)
        e.Allow = _Return
        e.Handled = Not _Return
    End Sub
#End Region
#Region "----------Các hàm thủ tục hỗ trợ"
    Private Sub V_Set_Auto_Refresh(ByVal _b As Boolean)
        ChkAuto_Data_KH_SCC.Checked = _b
        V_Auto_Data_Tien_Do(New System.Object, New System.EventArgs)
    End Sub
    Private Function V_GetThong_Tin(ByVal _Stt_Rec As String) As DataRow
        If _Stt_Rec.Trim = "" Then Return Nothing
        Dim _Dr As DataRow
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 1 Ma_Ct,Stt_rec_Ro,Loai_SC,ket_Thuc FROM dbo.PH89CVDV_SCC WITH (NOLOCK) WHERE Stt_Rec = N'" + _Stt_Rec.Trim.Replace("_THUCHIEN", "") + "'#" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsTmp.Tables(0).Rows.Count = 0 Then _Dr = Nothing Else _Dr = DsTmp.Tables(0).Copy.Rows(0)
        DsTmp.Dispose()
        Return _Dr
    End Function
    Private Function V_GetMa_Ct(ByVal _Stt_Rec As String) As String
        Dim _Dr As DataRow = V_GetThong_Tin(_Stt_Rec.Replace("_THUCHIEN", ""))
        If _Dr Is Nothing Then Return "" Else Return _Dr.Item("ma_Ct")
    End Function
    Private Function V_ChkStt_Rec(ByVal _Stt_rec As String) As Boolean
        If Strings.Right(_Stt_rec.Trim, 9) = "_THUCHIEN" Or InStr(_Stt_rec, "_FN") Then Return False Else Return True
    End Function
    Private Function V_Chk_Righ(ByVal _Stt_Rec As String, ByVal _Loai As String) As Boolean
        '_Loai: Nhằm để nhận biết đó là hạnh đồng gì: KH_NEW: Tạo mới KH, KH_SUA: Sửa KH, KH_XOA: Xóa kế hoạch
        '----------------------------------------
        Dim _Return As Boolean = True
        If Dt_Right Is Nothing Then Return True
        If Dt_Right.Rows.Count = 0 Then Return True
        If Dt_Data Is Nothing Then Return True
        If _Stt_Rec.Trim = "" Then Return True
        '----------------------------------------

        Dim Is_Admin As Boolean = Dt_Right.Columns.Contains("Is_Admin")
        Dim Is_CS As Boolean = Dt_Right.Columns.Contains("Is_CS")
        Dim Is_CVDV As Boolean = Dt_Right.Columns.Contains("Is_CVDV")
        Dim Is_Controler As Boolean = Dt_Right.Columns.Contains("Is_Controler")
        Dim Is_KTV As Boolean = Dt_Right.Columns.Contains("Is_KTV")
        Dim Is_SCC As Boolean = Dt_Right.Columns.Contains("Is_SCC")
        Dim Is_SDS As Boolean = Dt_Right.Columns.Contains("Is_SDS")
        Dim Is_Hen As Boolean = Dt_Right.Columns.Contains("Is_Hen")
        Dim Is_XN_SCC As Boolean = Dt_Right.Columns.Contains("Is_XN_SCC")
        Dim Is_XN_SDS As Boolean = Dt_Right.Columns.Contains("Is_XN_SDS")
        '----------------------------------------
        If Is_Admin Then Return True
        If Is_Controler Then Return True
        '----------------------------------------
        Dim _Ma_HS As String = ""
        If Dt_Right.Columns.Contains("Ma_HS") Then _Ma_HS = Dt_Right.Rows(0).Item("Ma_Hs").ToString.Trim.ToUpper
        _Stt_Rec = _Stt_Rec.Trim.Replace("_THUCHIEN", "")
        Dim _Dr() As DataRow = Dt_Data.Select("Stt_Rec = '" & _Stt_Rec.Trim & "'")
        If _Dr.Length = 0 Then Return True
        Dim _Ma_Hs_KH As String = _Dr(0).Item("Ma_Hs").ToString.Trim.ToUpper
        If _Ma_Hs_KH <> _Ma_HS Then
            MsgBox("Bạn không được phân quyền thay đổi lịch hẹn hoặc kế hoạch của User khác!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            _Return = False
        End If
        V_Chk_Righ = _Return
    End Function
#End Region

#End Region
#End Region
#End Region

#Region "Các tab Load Gridview: Tiếp đón, Hỗn hợp, Dừng, Chạy thử, Thêm giờ, khác"

#Region "TAB2 - Tiếp đón"
#Region "Khai bao bien"
    Dim _CP_TiepDon As String = "CP_WORK_TiepDon"
    Dim Dt_TiepDon, Dt_ColFrozen_TiepDon, Dt_Head_TiepDon As DataTable
    Dim Dv_TiepDon, Dv_Head_TiepDon As DataView
    Dim Dt_CVDV_TiepDon As DataTable
#End Region
#Region "Load"
    Private Sub V_TAB2_Load_TiepDon()
        '------------------------------------------------------------------------------------------------------
        V_GetAndFillData_TiepDon()
        '------------------------------------------------------------------------------------------------------
        V_LoadData_TiepDon("1", "", "")
        '------------------------------------------------------------------------------------------------------
        V_SetDeffault_TiepDon()
        '------------------------------------------------------------------------------------------------------
        V_AddHander_TiepDon()
        '------------------------------------------------------------------------------------------------------
        Master_TiepDonGRV.ColumnPanelRowHeight = 30
    End Sub
    Private Sub V_GetAndFillData_TiepDon()
        Dt_CVDV_TiepDon = Dt_CVDV.Copy
        '------------------------------------------------------------------------------------------------------
        CyberFill.V_FillComBoxDefaul(CbbCVDV_TiepDon, Dt_CVDV_TiepDon, "Ma_HS", "Ten_Hs", "Ngam_Dinh")
    End Sub
    Private Sub V_LoadData_TiepDon(ByVal status As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String)
        If status = "0" And Dt_TiepDon Is Nothing Then Return
        If Dt_TiepDon Is Nothing And status <> "1" Then Return
        If Not Dt_TiepDon Is Nothing Then status = "0"

        Dim _Dt As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim _Filter As String = status
        _Filter = _Filter & "#" & M_Kieu_Xem
        _Filter = _Filter & "#" & M_Loai_SC
        _Filter = _Filter & "#" & _Stt_Rec
        _Filter = _Filter & "#" & _Stt_Rec_Ro
        _Filter = _Filter & "#" & _Dt.ToString("yyyyMMdd")
        _Filter = _Filter & "#" & ""
        _Filter = _Filter & "#" & M_Ma_Dvcs
        _Filter = _Filter & "#" & M_User_Name


        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, _CP_TiepDon, _Filter)
        If status.ToString.Trim = "1" Then
            Dt_TiepDon = New DataTable
            Dt_Head_TiepDon = New DataTable

            Dt_TiepDon = DsTmp.Tables(0).Copy
            Dt_ColFrozen_TiepDon = DsTmp.Tables(1).Copy
            Dt_Head_TiepDon = DsTmp.Tables(2).Copy

            Dv_TiepDon = New DataView(Dt_TiepDon)
            Dv_Head_TiepDon = New DataView(Dt_Head_TiepDon)

            CyberFill.V_FillReports(Master_TiepDonGRV, M_LAN, Dv_Head_TiepDon, Dv_TiepDon)
            Master_TiepDon.DataSource = Dv_TiepDon
        Else
            If _Stt_Rec.Trim = "" Then
                Dt_TiepDon.Clear()
                Dt_TiepDon.Load(DsTmp.Tables(0).CreateDataReader)
                Dt_TiepDon.AcceptChanges()
            Else
                '----------------------------------------------
                If Not Dt_TiepDon Is Nothing Then CyberSmodb.DeleteDatatable(Dt_TiepDon, "Stt_Rec ='" + _Stt_Rec.Trim + "'")
                If Not Dt_TiepDon Is Nothing Then Dt_TiepDon.Load(DsTmp.Tables(0).CreateDataReader)
            End If
        End If
        V_Filter_TiepDon(New System.Object, New System.EventArgs)
        DsTmp.Dispose()
    End Sub
    Private Sub V_Filter_TiepDon(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---------------------------------
        If Dt_TiepDon Is Nothing Then Return
        If Not Dt_TiepDon.Columns.Contains("Ma_Hs") Then Return
        Dim _ma_hs As String = CyberWork.V_GetvalueCombox(CbbCVDV_TiepDon)
        '---------------------------------
        Dim _Filter As String = "1=1"
        If _ma_hs <> "" Then _Filter = _Filter + " AND Ma_HS = '" + _ma_hs.Trim + "'"
        Try
            Dv_TiepDon.RowFilter = _Filter
        Catch ex As Exception
            Dv_TiepDon.RowFilter = ""
        End Try
    End Sub
    Private Sub V_SetDeffault_TiepDon()
        If Dt_ColFrozen_TiepDon Is Nothing Then Return
        If Dt_ColFrozen_TiepDon.Rows.Count = 0 Then Return

        Dim _ColFrozen As Integer = -1
        If Dt_ColFrozen_TiepDon.Columns.Contains("ColFrozen") Then _ColFrozen = Dt_ColFrozen_TiepDon.Rows(0).Item("ColFrozen")
        CyberSupport.V_SetSortView(Dv_TiepDon, Dt_ColFrozen_TiepDon)

        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_TiepDonGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_TiepDonGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub V_AddHander_TiepDon()
        RemoveHandler CbbCVDV_TiepDon.SelectedIndexChanged, AddressOf V_Filter_TiepDon
        RemoveHandler Master_TiepDonGRV.PopupMenuShowing, AddressOf Master_TiepDonGRV_PopupMenuShowing
        RemoveHandler Master_TiepDonGRV.RowCellStyle, AddressOf Master_TiepDonGRV_RowCellStyle
        '--------------------------------------------------------------------------------------
        AddHandler CbbCVDV_TiepDon.SelectedIndexChanged, AddressOf V_Filter_TiepDon
        AddHandler Master_TiepDonGRV.PopupMenuShowing, AddressOf Master_TiepDonGRV_PopupMenuShowing
        AddHandler Master_TiepDonGRV.RowCellStyle, AddressOf Master_TiepDonGRV_RowCellStyle
    End Sub
    Private Sub Master_TiepDonGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Lịch sử sửa chữa", "History Repair"), AddressOf V_Xem_TiepDon_LSSC, Nothing, Nothing, True, True), True).BeginGroup = True

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Export Excel", AddressOf V_ExportExcel_TiepDon, System.Windows.Forms.Shortcut.F12, My.Resources.exporttoxls_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_TiepDon, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)

        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_Refresh_TiepDon(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_TiepDon("0", "", "")
    End Sub
    Private Sub V_Xem_TiepDon_LSSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec_Ro As String = ""

        If Not Dt_TiepDon Is Nothing Then
            Dim iRow As Integer = -1
            iRow = Master_TiepDonGRV.GetFocusedDataSourceRowIndex
            If iRow >= 0 And Dt_TiepDon.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_TiepDon.Item(iRow).Item("Ma_Xe").ToString.Trim
            If iRow >= 0 And Dt_TiepDon.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_TiepDon.Item(iRow).Item("Ma_Ct").ToString.Trim
            If iRow >= 0 And Dt_TiepDon.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_TiepDon.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim

        End If
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, "HDK", "", AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_ExportExcel_TiepDon(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberExport As New Cyber.Export.Sys
        Dim FileName As String = ""
        Dim Dt_Title As New DataTable
        Dt_Title.Columns.Add("Title1")
        Dt_Title.Columns.Add("Title2")
        Dt_Title.Rows.Add(Dt_ColFrozen_TiepDon.Rows(0).Item("Title"))
        Dim Dt_TitleDetail As New DataTable
        Dt_TitleDetail.Columns.Add("Tu_Ngay")
        FileName = CyberExport.V_ExportToXlsx(AppConn, Master_TiepDonGRV, New DataView(Dt_Title), New DataView(Dt_TitleDetail), Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub Master_TiepDonGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_TiepDonGRV, Dt_TiepDon, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub

#End Region
#End Region

#Region "TAB4 - Hỗn hợp"
#Region "Khai bao bien"
    Dim _CP_HonHop As String = "CP_WORK_HONHOP"
    Dim Dt_HONHOP, Dt_ColFrozen_HONHOP, Dt_Head_HONHOP As DataTable
    Dim Dv_HONHOP, Dv_Head_HONHOP As DataView
    Dim Dt_CVDV_HONHOP As DataTable
#End Region
#Region "Load"
    Private Sub V_TAB4_Load_HonHop()
        '------------------------------------------------------------------------------------------------------
        V_GetAndFillData_HonHop()
        '------------------------------------------------------------------------------------------------------
        V_LoadData_HonHop("1", "", "")
        '------------------------------------------------------------------------------------------------------
        V_SetDeffault_HonHop()
        '------------------------------------------------------------------------------------------------------
        V_AddHander_HonHop()
        '------------------------------------------------------------------------------------------------------
        Master_HonHopGRV.ColumnPanelRowHeight = 30
    End Sub
    Private Sub V_GetAndFillData_HonHop()
        Dt_CVDV_HONHOP = Dt_CVDV.Copy
        '------------------------------------------------------------------------------------------------------
        CyberFill.V_FillComBoxDefaul(CbbCVDV_HonHop, Dt_CVDV_HONHOP, "Ma_HS", "Ten_Hs", "Ngam_Dinh")
    End Sub
    Private Sub V_LoadData_HonHop(ByVal status As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String)
        If status = "0" And Dt_HONHOP Is Nothing Then Return
        If Dt_HONHOP Is Nothing And status <> "1" Then Return
        If Not Dt_HONHOP Is Nothing Then status = "0"

        Dim _Dt As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim _Filter As String = status
        _Filter = _Filter & "#" & M_Kieu_Xem
        _Filter = _Filter & "#" & M_Loai_SC
        _Filter = _Filter & "#" & _Stt_Rec
        _Filter = _Filter & "#" & _Stt_Rec_Ro
        _Filter = _Filter & "#" & _Dt.ToString("yyyyMMdd")
        _Filter = _Filter & "#" & ""
        _Filter = _Filter & "#" & M_Ma_Dvcs
        _Filter = _Filter & "#" & M_User_Name


        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, _CP_HonHop, _Filter)
        If status.ToString.Trim = "1" Then
            Dt_HONHOP = New DataTable
            Dt_Head_HONHOP = New DataTable

            Dt_HONHOP = DsTmp.Tables(0).Copy
            Dt_ColFrozen_HONHOP = DsTmp.Tables(1).Copy
            Dt_Head_HONHOP = DsTmp.Tables(2).Copy

            Dv_HONHOP = New DataView(Dt_HONHOP)
            Dv_Head_HONHOP = New DataView(Dt_Head_HONHOP)

            CyberFill.V_FillReports(Master_HonHopGRV, M_LAN, Dv_Head_HONHOP, Dv_HONHOP)
            Master_HonHop.DataSource = Dv_HONHOP
        Else
            If _Stt_Rec.Trim = "" Then
                Dt_HONHOP.Clear()
                Dt_HONHOP.Load(DsTmp.Tables(0).CreateDataReader)
                Dt_HONHOP.AcceptChanges()
            Else
                '----------------------------------------------
                If Not Dt_HONHOP Is Nothing Then CyberSmodb.DeleteDatatable(Dt_HONHOP, "Stt_Rec ='" + _Stt_Rec.Trim + "'")
                If Not Dt_HONHOP Is Nothing Then Dt_HONHOP.Load(DsTmp.Tables(0).CreateDataReader)
            End If
        End If
        V_Filter_HonHop(New System.Object, New System.EventArgs)
        DsTmp.Dispose()
    End Sub
    Private Sub V_Filter_HonHop(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---------------------------------
        If Dt_HONHOP Is Nothing Then Return
        If Not Dt_HONHOP.Columns.Contains("Ma_Hs") Then Return
        Dim _ma_hs As String = CyberWork.V_GetvalueCombox(CbbCVDV_HonHop)
        '---------------------------------
        Dim _Filter As String = "1=1"
        If _ma_hs <> "" Then _Filter = _Filter + " AND Ma_HS = '" + _ma_hs.Trim + "'"
        Try
            Dv_HONHOP.RowFilter = _Filter
        Catch ex As Exception
            Dv_HONHOP.RowFilter = ""
        End Try
    End Sub
    Private Sub V_SetDeffault_HonHop()
        If Dt_ColFrozen_HONHOP Is Nothing Then Return
        If Dt_ColFrozen_HONHOP.Rows.Count = 0 Then Return

        Dim _ColFrozen As Integer = -1
        If Dt_ColFrozen_HONHOP.Columns.Contains("ColFrozen") Then _ColFrozen = Dt_ColFrozen_HONHOP.Rows(0).Item("ColFrozen")
        CyberSupport.V_SetSortView(Dv_HONHOP, Dt_ColFrozen_HONHOP)

        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_HonHopGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_HonHopGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub V_AddHander_HonHop()
        RemoveHandler CbbCVDV_HonHop.SelectedIndexChanged, AddressOf V_Filter_HonHop
        RemoveHandler Master_HonHopGRV.PopupMenuShowing, AddressOf Master_HonHopGRV_PopupMenuShowing
        RemoveHandler Master_HonHopGRV.RowCellStyle, AddressOf Master_HonHopGRV_RowCellStyle
        '--------------------------------------------------------------------------------------
        AddHandler CbbCVDV_HonHop.SelectedIndexChanged, AddressOf V_Filter_HonHop
        AddHandler Master_HonHopGRV.PopupMenuShowing, AddressOf Master_HonHopGRV_PopupMenuShowing
        AddHandler Master_HonHopGRV.RowCellStyle, AddressOf Master_HonHopGRV_RowCellStyle
    End Sub
    Private Sub Master_HonHopGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Lịch sử sửa chữa", "History Repair"), AddressOf V_Xem_HonHop_LSSC, Nothing, Nothing, True, True), True).BeginGroup = True

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Export Excel", AddressOf V_ExportExcel_HonHop, System.Windows.Forms.Shortcut.F12, My.Resources.exporttoxls_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_HonHop, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)

        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_Refresh_HonHop(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_HonHop("0", "", "")
    End Sub
    Private Sub V_Xem_HonHop_LSSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec_Ro As String = ""

        If Not Dt_HONHOP Is Nothing Then
            Dim iRow As Integer = -1
            iRow = Master_HonHopGRV.GetFocusedDataSourceRowIndex
            If iRow >= 0 And Dt_HONHOP.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_HONHOP.Item(iRow).Item("Ma_Xe").ToString.Trim
            If iRow >= 0 And Dt_HONHOP.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_HONHOP.Item(iRow).Item("Ma_Ct").ToString.Trim
            If iRow >= 0 And Dt_HONHOP.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_HONHOP.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim

        End If
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, "HDK", "", AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_ExportExcel_HonHop(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberExport As New Cyber.Export.Sys
        Dim FileName As String = ""
        Dim Dt_Title As New DataTable
        Dt_Title.Columns.Add("Title1")
        Dt_Title.Columns.Add("Title2")
        Dt_Title.Rows.Add(Dt_ColFrozen_HONHOP.Rows(0).Item("Title"))
        Dim Dt_TitleDetail As New DataTable
        Dt_TitleDetail.Columns.Add("Tu_Ngay")
        FileName = CyberExport.V_ExportToXlsx(AppConn, Master_HonHopGRV, New DataView(Dt_Title), New DataView(Dt_TitleDetail), Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub Master_HonHopGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_HonHopGRV, Dt_HONHOP, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub

#End Region
#End Region

#Region "TAB5 - Dừng"
#Region "Khai bao bien"
    Dim _CP_Dung As String = "CP_WORK_Dung"
    Dim Dt_Dung, Dt_ColFrozen_Dung, Dt_Head_Dung As DataTable
    Dim Dv_Dung, Dv_Head_Dung As DataView
    Dim Dt_CVDV_Dung As DataTable
#End Region
#Region "Load"
    Private Sub V_TAB5_Load_Dung()
        '------------------------------------------------------------------------------------------------------
        V_GetAndFillData_Dung()
        '------------------------------------------------------------------------------------------------------
        V_LoadData_Dung("1", "", "")
        '------------------------------------------------------------------------------------------------------
        V_SetDeffault_Dung()
        '------------------------------------------------------------------------------------------------------
        V_AddHander_Dung()
        '------------------------------------------------------------------------------------------------------
        Master_DungGRV.ColumnPanelRowHeight = 30
    End Sub
    Private Sub V_GetAndFillData_Dung()
        Dt_CVDV_Dung = Dt_CVDV.Copy
        '------------------------------------------------------------------------------------------------------
        CyberFill.V_FillComBoxDefaul(CbbCVDV_Dung, Dt_CVDV_Dung, "Ma_HS", "Ten_Hs", "Ngam_Dinh")
    End Sub
    Private Sub V_LoadData_Dung(ByVal status As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String)
        If status = "0" And Dt_Dung Is Nothing Then Return
        If Dt_Dung Is Nothing And status <> "1" Then Return
        If Not Dt_Dung Is Nothing Then status = "0"

        Dim _Dt As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim _Filter As String = status
        _Filter = _Filter & "#" & M_Kieu_Xem
        _Filter = _Filter & "#" & M_Loai_SC
        _Filter = _Filter & "#" & _Stt_Rec
        _Filter = _Filter & "#" & _Stt_Rec_Ro
        _Filter = _Filter & "#" & _Dt.ToString("yyyyMMdd")
        _Filter = _Filter & "#" & ""
        _Filter = _Filter & "#" & M_Ma_Dvcs
        _Filter = _Filter & "#" & M_User_Name


        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, _CP_Dung, _Filter)
        If status.ToString.Trim = "1" Then
            Dt_Dung = New DataTable
            Dt_Head_Dung = New DataTable

            Dt_Dung = DsTmp.Tables(0).Copy
            Dt_ColFrozen_Dung = DsTmp.Tables(1).Copy
            Dt_Head_Dung = DsTmp.Tables(2).Copy

            Dv_Dung = New DataView(Dt_Dung)
            Dv_Head_Dung = New DataView(Dt_Head_Dung)

            CyberFill.V_FillReports(Master_DungGRV, M_LAN, Dv_Head_Dung, Dv_Dung)
            Master_Dung.DataSource = Dv_Dung
        Else
            If _Stt_Rec.Trim = "" Then
                Dt_Dung.Clear()
                Dt_Dung.Load(DsTmp.Tables(0).CreateDataReader)
                Dt_Dung.AcceptChanges()
            Else
                '----------------------------------------------
                If Not Dt_Dung Is Nothing Then CyberSmodb.DeleteDatatable(Dt_Dung, "Stt_Rec ='" + _Stt_Rec.Trim + "'")
                If Not Dt_Dung Is Nothing Then Dt_Dung.Load(DsTmp.Tables(0).CreateDataReader)
            End If
        End If
        V_Filter_Dung(New System.Object, New System.EventArgs)
        DsTmp.Dispose()
    End Sub
    Private Sub V_Filter_Dung(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---------------------------------
        If Dt_Dung Is Nothing Then Return
        If Not Dt_Dung.Columns.Contains("Ma_Hs") Then Return
        Dim _ma_hs As String = CyberWork.V_GetvalueCombox(CbbCVDV_Dung)
        '---------------------------------
        Dim _Filter As String = "1=1"
        If _ma_hs <> "" Then _Filter = _Filter + " AND Ma_HS = '" + _ma_hs.Trim + "'"
        Try
            Dv_Dung.RowFilter = _Filter
        Catch ex As Exception
            Dv_Dung.RowFilter = ""
        End Try
    End Sub
    Private Sub V_SetDeffault_Dung()
        If Dt_ColFrozen_Dung Is Nothing Then Return
        If Dt_ColFrozen_Dung.Rows.Count = 0 Then Return

        Dim _ColFrozen As Integer = -1
        If Dt_ColFrozen_Dung.Columns.Contains("ColFrozen") Then _ColFrozen = Dt_ColFrozen_Dung.Rows(0).Item("ColFrozen")
        CyberSupport.V_SetSortView(Dv_Dung, Dt_ColFrozen_Dung)

        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_DungGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_DungGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub V_AddHander_Dung()
        RemoveHandler CbbCVDV_Dung.SelectedIndexChanged, AddressOf V_Filter_Dung
        RemoveHandler Master_DungGRV.PopupMenuShowing, AddressOf Master_DungGRV_PopupMenuShowing
        RemoveHandler Master_DungGRV.RowCellStyle, AddressOf Master_DungGRV_RowCellStyle
        '--------------------------------------------------------------------------------------
        AddHandler CbbCVDV_Dung.SelectedIndexChanged, AddressOf V_Filter_Dung
        AddHandler Master_DungGRV.PopupMenuShowing, AddressOf Master_DungGRV_PopupMenuShowing
        AddHandler Master_DungGRV.RowCellStyle, AddressOf Master_DungGRV_RowCellStyle
    End Sub
    Private Sub Master_DungGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()


        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Kết thúc kế hoạch Dừng", "Create repair plan"), AddressOf V_Dung_SC_KT_Dung_SC, Nothing, Nothing, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Sửa kế hoạch Dừng", "Create repair plan"), AddressOf V_Dung_Sua_Chua_Edit_Dung_SC, Nothing, Nothing, True, True), True).BeginGroup = False

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Lịch sử sửa chữa", "History Repair"), AddressOf V_Xem_Dung_LSSC, Nothing, Nothing, True, True), True).BeginGroup = True

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Export Excel", AddressOf V_ExportExcel_Dung, System.Windows.Forms.Shortcut.F12, My.Resources.exporttoxls_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_Dung, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)

        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_Refresh_Dung(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_Dung("0", "", "")
    End Sub
    Private Sub V_LoadData_DungALL(ByVal _Dt As DataTable)
        If _Dt Is Nothing Then Return
        If _Dt.Rows.Count = 0 Then Return
        If Not _Dt.Columns.Contains("Stt_Rec") And Not _Dt.Columns.Contains("Stt_Rec_Ro") Then Return
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        For i As Integer = 0 To _Dt.Rows.Count - 1
            If _Dt.Columns.Contains("Stt_Rec") Then _Stt_Rec = _Dt.Rows(i).Item("Stt_Rec").ToString.Trim
            If _Dt.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = _Dt.Rows(i).Item("Stt_Rec_Ro").ToString.Trim
            V_LoadData_Dung("0", _Stt_Rec, _Stt_Rec_Ro)
        Next
    End Sub
    Private Sub V_Dung_SC_KT_Dung_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim iRow As Integer = -1
        iRow = Master_DungGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        V_Set_Auto_Refresh(False)

        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        Dim _So_Ro As String = ""
        Dim _Ma_Xe As String = ""
        If Dt_Dung.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Dung.Item(iRow).Item("Stt_Rec_Ro")
        If Dt_Dung.Columns.Contains("So_Ro") Then _So_Ro = Dv_Dung.Item(iRow).Item("So_Ro")
        If Dt_Dung.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_Dung.Item(iRow).Item("Ma_Xe")
        Dim _Return As DataTable = CyberWork.V_KT_Dung_SC(M_Kieu_Xem, M_Loai_SC, _Stt_Rec_Ro, _Stt_Rec, _So_Ro, _Ma_Xe, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Return)
        V_LoadData_DungALL(_Return)

    End Sub
    Private Sub V_Dung_Sua_Chua_Edit_Dung_SC()
        Dim iRow As Integer = -1
        iRow = Master_DungGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub
        If Not Dt_Dung.Columns.Contains("Stt_Rec_Ro") Or Not Dt_Dung.Columns.Contains("So_Ro") Then Return
        V_Set_Auto_Refresh(False)

        Dim _Stt_Rec_Dung_SC As String = ""
        Dim _Stt_Rec_Ro As String = ""
        Dim _So_Ro As String = ""
        Dim _Ma_Xe As String = ""

        If Dt_Dung.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Dung.Item(iRow).Item("Stt_Rec_Ro")
        If Dt_Dung.Columns.Contains("So_Ro") Then _So_Ro = Dv_Dung.Item(iRow).Item("So_Ro")
        If Dt_Dung.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_Dung.Item(iRow).Item("Ma_Xe")

        Dim _Ngay_Ct As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_DungSC_GetStt_Rec_KH", M_Kieu_Xem + "#" + M_Loai_SC + "#" + _Ngay_Ct.ToString("yyyyMMdd") + "#" + _Stt_Rec_Ro + "#" + _So_Ro + "#" + _Ma_Xe + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If
        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(0).Columns.Contains("Stt_Rec_Dung_SC") Then _Stt_Rec_Dung_SC = Dstmp.Tables(0).Rows(0).Item("Stt_Rec_Dung_SC")
        Dstmp.Dispose()
        If _Stt_Rec_Dung_SC = "" Then
            Return
        End If

        Dim _Return As DataTable = CyberWork.V_BD_Dung_SC(M_Kieu_Xem, M_Loai_SC, _Stt_Rec_Dung_SC, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Return)
        V_LoadData_DungALL(_Return)

    End Sub
    Private Sub V_Xem_Dung_LSSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec_Ro As String = ""

        If Not Dt_Dung Is Nothing Then
            Dim iRow As Integer = -1
            iRow = Master_DungGRV.GetFocusedDataSourceRowIndex
            If iRow >= 0 And Dt_Dung.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_Dung.Item(iRow).Item("Ma_Xe").ToString.Trim
            If iRow >= 0 And Dt_Dung.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_Dung.Item(iRow).Item("Ma_Ct").ToString.Trim
            If iRow >= 0 And Dt_Dung.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Dung.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim

        End If
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, "HDK", "", AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub

    Private Sub V_ExportExcel_Dung(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberExport As New Cyber.Export.Sys
        Dim FileName As String = ""
        Dim Dt_Title As New DataTable
        Dt_Title.Columns.Add("Title1")
        Dt_Title.Columns.Add("Title2")
        Dt_Title.Rows.Add(Dt_ColFrozen_Dung.Rows(0).Item("Title"))
        Dim Dt_TitleDetail As New DataTable
        Dt_TitleDetail.Columns.Add("Tu_Ngay")
        FileName = CyberExport.V_ExportToXlsx(AppConn, Master_DungGRV, New DataView(Dt_Title), New DataView(Dt_TitleDetail), Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub Master_DungGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_DungGRV, Dt_Dung, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub

#End Region
#End Region

#Region "TAB6 - Chạy thử"
#Region "Khai bao bien"
    Dim _CP_ChayThu As String = "CP_WORK_ChayThu"
    Dim Dt_ChayThu, Dt_ColFrozen_ChayThu, Dt_Head_ChayThu As DataTable
    Dim Dv_ChayThu, Dv_Head_ChayThu As DataView
    Dim Dt_CVDV_ChayThu As DataTable
#End Region
#Region "Load"
    Private Sub V_TAB6_Load_ChayThu()
        '------------------------------------------------------------------------------------------------------
        V_GetAndFillData_ChayThu()
        '------------------------------------------------------------------------------------------------------
        V_LoadData_ChayThu("1", "", "")
        '------------------------------------------------------------------------------------------------------
        V_SetDeffault_ChayThu()
        '------------------------------------------------------------------------------------------------------
        V_AddHander_ChayThu()
        '------------------------------------------------------------------------------------------------------
        Master_ChayThuGRV.ColumnPanelRowHeight = 30
    End Sub
    Private Sub V_GetAndFillData_ChayThu()
        Dt_CVDV_ChayThu = Dt_CVDV.Copy
        '------------------------------------------------------------------------------------------------------
        CyberFill.V_FillComBoxDefaul(CbbCVDV_Chaythu, Dt_CVDV_ChayThu, "Ma_HS", "Ten_Hs", "Ngam_Dinh")
    End Sub
    Private Sub V_LoadData_ChayThu(ByVal status As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String)
        If status = "0" And Dt_ChayThu Is Nothing Then Return
        If Dt_ChayThu Is Nothing And status <> "1" Then Return
        If Not Dt_ChayThu Is Nothing Then status = "0"

        Dim _Dt As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim _Filter As String = status
        _Filter = _Filter & "#" & M_Kieu_Xem
        _Filter = _Filter & "#" & M_Loai_SC
        _Filter = _Filter & "#" & _Stt_Rec
        _Filter = _Filter & "#" & _Stt_Rec_Ro
        _Filter = _Filter & "#" & _Dt.ToString("yyyyMMdd")
        _Filter = _Filter & "#" & ""
        _Filter = _Filter & "#" & M_Ma_Dvcs
        _Filter = _Filter & "#" & M_User_Name


        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, _CP_ChayThu, _Filter)
        If status.ToString.Trim = "1" Then
            Dt_ChayThu = New DataTable
            Dt_Head_ChayThu = New DataTable

            Dt_ChayThu = DsTmp.Tables(0).Copy
            Dt_ColFrozen_ChayThu = DsTmp.Tables(1).Copy
            Dt_Head_ChayThu = DsTmp.Tables(2).Copy

            Dv_ChayThu = New DataView(Dt_ChayThu)
            Dv_Head_ChayThu = New DataView(Dt_Head_ChayThu)

            CyberFill.V_FillReports(Master_ChayThuGRV, M_LAN, Dv_Head_ChayThu, Dv_ChayThu)
            Master_ChayThu.DataSource = Dv_ChayThu
        Else
            If _Stt_Rec.Trim = "" Then
                Dt_ChayThu.Clear()
                Dt_ChayThu.Load(DsTmp.Tables(0).CreateDataReader)
                Dt_ChayThu.AcceptChanges()
            Else
                '----------------------------------------------
                If Not Dt_ChayThu Is Nothing Then CyberSmodb.DeleteDatatable(Dt_ChayThu, "Stt_Rec ='" + _Stt_Rec.Trim + "'")
                If Not Dt_ChayThu Is Nothing Then Dt_ChayThu.Load(DsTmp.Tables(0).CreateDataReader)
            End If
        End If
        V_Filter_ChayThu(New System.Object, New System.EventArgs)
        DsTmp.Dispose()
    End Sub
    Private Sub V_Filter_ChayThu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---------------------------------
        If Dt_ChayThu Is Nothing Then Return
        If Not Dt_ChayThu.Columns.Contains("Ma_Hs") Then Return
        Dim _ma_hs As String = CyberWork.V_GetvalueCombox(CbbCVDV_Chaythu)
        '---------------------------------
        Dim _Filter As String = "1=1"
        If _ma_hs <> "" Then _Filter = _Filter + " AND Ma_HS = '" + _ma_hs.Trim + "'"
        Try
            Dv_ChayThu.RowFilter = _Filter
        Catch ex As Exception
            Dv_ChayThu.RowFilter = ""
        End Try
    End Sub
    Private Sub V_SetDeffault_ChayThu()
        If Dt_ColFrozen_ChayThu Is Nothing Then Return
        If Dt_ColFrozen_ChayThu.Rows.Count = 0 Then Return


        Dim _ColFrozen As Integer = -1
        If Dt_ColFrozen_ChayThu.Columns.Contains("ColFrozen") Then _ColFrozen = Dt_ColFrozen_ChayThu.Rows(0).Item("ColFrozen")
        CyberSupport.V_SetSortView(Dv_ChayThu, Dt_ColFrozen_ChayThu)

        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_ChayThuGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_ChayThuGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub V_AddHander_ChayThu()
        RemoveHandler CbbCVDV_Chaythu.SelectedIndexChanged, AddressOf V_Filter_ChayThu
        RemoveHandler Master_ChayThuGRV.PopupMenuShowing, AddressOf Master_ChayThuGRV_PopupMenuShowing
        RemoveHandler Master_ChayThuGRV.RowCellStyle, AddressOf Master_ChayThuGRV_RowCellStyle
        '--------------------------------------------------------------------------------------
        AddHandler CbbCVDV_Chaythu.SelectedIndexChanged, AddressOf V_Filter_ChayThu
        AddHandler Master_ChayThuGRV.PopupMenuShowing, AddressOf Master_ChayThuGRV_PopupMenuShowing
        AddHandler Master_ChayThuGRV.RowCellStyle, AddressOf Master_ChayThuGRV_RowCellStyle
    End Sub
    Private Sub Master_ChayThuGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()


        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Kết thúc chạy thử", "Create repair plan"), AddressOf V_ChayThu_SCC_Chay_Thu_Stop, Nothing, Nothing, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Sửa kế hoạch chạy thử", "Create repair plan"), AddressOf V_ChayThu_SCC_Chay_Thu, Nothing, Nothing, True, True), True).BeginGroup = False


        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Lịch sử sửa chữa", "History Repair"), AddressOf V_Xem_ChayThu_LSSC, Nothing, Nothing, True, True), True).BeginGroup = True

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Export Excel", AddressOf V_ExportExcel_ChayThu, System.Windows.Forms.Shortcut.F12, My.Resources.exporttoxls_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_ChayThu, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)

        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_Refresh_ChayThu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_ChayThu("0", "", "")
    End Sub
    Private Sub V_LoadData_ChayThuALL(ByVal _Dt As DataTable)
        If _Dt Is Nothing Then Return
        If _Dt.Rows.Count = 0 Then Return
        If Not _Dt.Columns.Contains("Stt_Rec") And Not _Dt.Columns.Contains("Stt_Rec_Ro") Then Return
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_Ro As String = ""
        For i As Integer = 0 To _Dt.Rows.Count - 1
            If _Dt.Columns.Contains("Stt_Rec") Then _Stt_Rec = _Dt.Rows(i).Item("Stt_Rec").ToString.Trim
            If _Dt.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = _Dt.Rows(i).Item("Stt_Rec_Ro").ToString.Trim
            V_LoadData_ChayThu("0", _Stt_Rec, _Stt_Rec_Ro)
        Next
    End Sub

    Private Sub V_ChayThu_SCC_Chay_Thu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = Master_ChayThuGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Return
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_RO As String = ""

        If Dt_ChayThu.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_ChayThu.Item(iRow).Item("Ma_Xe").ToString.Trim
        If Dt_ChayThu.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_ChayThu.Item(iRow).Item("Ma_Ct").ToString.Trim
        If Dt_ChayThu.Columns.Contains("Stt_Rec") Then _Stt_Rec = Dv_ChayThu.Item(iRow).Item("Stt_Rec").ToString.Trim
        If Dt_ChayThu.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_RO = Dv_ChayThu.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim

        If _Stt_Rec.Trim = "" Then Return
        Dim _Return As DataTable = CyberWork.V_Chay_Thu(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, _Stt_Rec_RO, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Return)
        V_LoadData_ChayThuALL(_Return)
    End Sub
    Private Sub V_ChayThu_SCC_Chay_Thu_Stop(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim iRow As Integer = Master_ChayThuGRV.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Return
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec As String = ""
        Dim _Stt_Rec_RO As String = ""

        If Dt_ChayThu.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_ChayThu.Item(iRow).Item("Ma_Xe").ToString.Trim
        If Dt_ChayThu.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_ChayThu.Item(iRow).Item("Ma_Ct").ToString.Trim
        If Dt_ChayThu.Columns.Contains("Stt_Rec_RO") Then _Stt_Rec_RO = Dv_ChayThu.Item(iRow).Item("Stt_Rec_RO").ToString.Trim
        If _Stt_Rec.Trim = "" Then Return
        _Stt_Rec = _Stt_Rec.Replace("_THUCHIEN", "")
        Dim _Return As DataTable = CyberWork.V_Chay_Thu_Stop(M_Kieu_Xem, M_Loai_SC, _Stt_Rec, _Stt_Rec_RO, AppConn, Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
        V_LoadDatabasesALL(_Return)
        V_LoadData_ChayThuALL(_Return)
    End Sub
    Private Sub V_Xem_ChayThu_LSSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec_Ro As String = ""

        If Not Dt_ChayThu Is Nothing Then
            Dim iRow As Integer = -1
            iRow = Master_ChayThuGRV.GetFocusedDataSourceRowIndex
            If iRow >= 0 And Dt_ChayThu.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_ChayThu.Item(iRow).Item("Ma_Xe").ToString.Trim
            If iRow >= 0 And Dt_ChayThu.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_ChayThu.Item(iRow).Item("Ma_Ct").ToString.Trim
            If iRow >= 0 And Dt_ChayThu.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_ChayThu.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim

        End If
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, "HDK", "", AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_ExportExcel_ChayThu(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberExport As New Cyber.Export.Sys
        Dim FileName As String = ""
        Dim Dt_Title As New DataTable
        Dt_Title.Columns.Add("Title1")
        Dt_Title.Columns.Add("Title2")
        Dt_Title.Rows.Add(Dt_ColFrozen_ChayThu.Rows(0).Item("Title"))
        Dim Dt_TitleDetail As New DataTable
        Dt_TitleDetail.Columns.Add("Tu_Ngay")
        FileName = CyberExport.V_ExportToXlsx(AppConn, Master_ChayThuGRV, New DataView(Dt_Title), New DataView(Dt_TitleDetail), Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub Master_ChayThuGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_ChayThuGRV, Dt_ChayThu, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub

#End Region
#End Region

#Region "TAB7 - Thêm giờ"
#Region "Khai bao bien"
    Dim _CP_ThemGio As String = "CP_WORK_ThemGio"
    Dim Dt_ThemGio, Dt_ColFrozen_ThemGio, Dt_Head_ThemGio As DataTable
    Dim Dv_ThemGio, Dv_Head_ThemGio As DataView
    Dim Dt_CVDV_ThemGio As DataTable
#End Region
#Region "Load"
    Private Sub V_TAB7_Load_ThemGio()
        '------------------------------------------------------------------------------------------------------
        V_GetAndFillData_ThemGio()
        '------------------------------------------------------------------------------------------------------
        V_LoadData_ThemGio("1", "", "")
        '------------------------------------------------------------------------------------------------------
        V_SetDeffault_ThemGio()
        '------------------------------------------------------------------------------------------------------
        V_AddHander_ThemGio()
        '------------------------------------------------------------------------------------------------------
        Master_ThemGioGRV.ColumnPanelRowHeight = 30
    End Sub
    Private Sub V_GetAndFillData_ThemGio()
        Dt_CVDV_ThemGio = Dt_CVDV.Copy
        '------------------------------------------------------------------------------------------------------
        CyberFill.V_FillComBoxDefaul(CbbCVDV_ThemGio, Dt_CVDV_ThemGio, "Ma_HS", "Ten_Hs", "Ngam_Dinh")
    End Sub
    Private Sub V_LoadData_ThemGio(ByVal status As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String)
        If status = "0" And Dt_ThemGio Is Nothing Then Return
        If Dt_ThemGio Is Nothing And status <> "1" Then Return
        If Not Dt_ThemGio Is Nothing Then status = "0"

        Dim _Dt As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim _Filter As String = status
        _Filter = _Filter & "#" & M_Kieu_Xem
        _Filter = _Filter & "#" & M_Loai_SC
        _Filter = _Filter & "#" & _Stt_Rec
        _Filter = _Filter & "#" & _Stt_Rec_Ro
        _Filter = _Filter & "#" & _Dt.ToString("yyyyMMdd")
        _Filter = _Filter & "#" & ""
        _Filter = _Filter & "#" & M_Ma_Dvcs
        _Filter = _Filter & "#" & M_User_Name


        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, _CP_ThemGio, _Filter)
        If status.ToString.Trim = "1" Then
            Dt_ThemGio = New DataTable
            Dt_Head_ThemGio = New DataTable

            Dt_ThemGio = DsTmp.Tables(0).Copy
            Dt_ColFrozen_ThemGio = DsTmp.Tables(1).Copy
            Dt_Head_ThemGio = DsTmp.Tables(2).Copy

            Dv_ThemGio = New DataView(Dt_ThemGio)
            Dv_Head_ThemGio = New DataView(Dt_Head_ThemGio)

            CyberFill.V_FillReports(Master_ThemGioGRV, M_LAN, Dv_Head_ThemGio, Dv_ThemGio)
            Master_ThemGio.DataSource = Dv_ThemGio
        Else
            If _Stt_Rec.Trim = "" Then
                Dt_ThemGio.Clear()
                Dt_ThemGio.Load(DsTmp.Tables(0).CreateDataReader)
                Dt_ThemGio.AcceptChanges()
            Else
                '----------------------------------------------
                If Not Dt_ThemGio Is Nothing Then CyberSmodb.DeleteDatatable(Dt_ThemGio, "Stt_Rec ='" + _Stt_Rec.Trim + "'")
                If Not Dt_ThemGio Is Nothing Then Dt_ThemGio.Load(DsTmp.Tables(0).CreateDataReader)
            End If
        End If
        V_Filter_ThemGio(New System.Object, New System.EventArgs)
        DsTmp.Dispose()
    End Sub
    Private Sub V_Filter_ThemGio(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---------------------------------
        If Dt_ThemGio Is Nothing Then Return
        If Not Dt_ThemGio.Columns.Contains("Ma_Hs") Then Return
        Dim _ma_hs As String = CyberWork.V_GetvalueCombox(CbbCVDV_ThemGio)
        '---------------------------------
        Dim _Filter As String = "1=1"
        If _ma_hs <> "" Then _Filter = _Filter + " AND Ma_HS = '" + _ma_hs.Trim + "'"
        Try
            Dv_ThemGio.RowFilter = _Filter
        Catch ex As Exception
            Dv_ThemGio.RowFilter = ""
        End Try
    End Sub
    Private Sub V_SetDeffault_ThemGio()
        If Dt_ColFrozen_ThemGio Is Nothing Then Return
        If Dt_ColFrozen_ThemGio.Rows.Count = 0 Then Return

        Dim _ColFrozen As Integer = -1
        If Dt_ColFrozen_ThemGio.Columns.Contains("ColFrozen") Then _ColFrozen = Dt_ColFrozen_ThemGio.Rows(0).Item("ColFrozen")
        CyberSupport.V_SetSortView(Dv_ThemGio, Dt_ColFrozen_ThemGio)

        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_ThemGioGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_ThemGioGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub V_AddHander_ThemGio()
        RemoveHandler CbbCVDV_ThemGio.SelectedIndexChanged, AddressOf V_Filter_ThemGio
        RemoveHandler Master_ThemGioGRV.PopupMenuShowing, AddressOf Master_ThemGioGRV_PopupMenuShowing
        RemoveHandler Master_ThemGioGRV.RowCellStyle, AddressOf Master_ThemGioGRV_RowCellStyle
        '--------------------------------------------------------------------------------------
        AddHandler CbbCVDV_ThemGio.SelectedIndexChanged, AddressOf V_Filter_ThemGio
        AddHandler Master_ThemGioGRV.PopupMenuShowing, AddressOf Master_ThemGioGRV_PopupMenuShowing
        AddHandler Master_ThemGioGRV.RowCellStyle, AddressOf Master_ThemGioGRV_RowCellStyle
    End Sub
    Private Sub Master_ThemGioGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Lịch sử sửa chữa", "History Repair"), AddressOf V_Xem_ThemGio_LSSC, Nothing, Nothing, True, True), True).BeginGroup = True

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Export Excel", AddressOf V_ExportExcel_ThemGio, System.Windows.Forms.Shortcut.F12, My.Resources.exporttoxls_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_ThemGio, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)

        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_Refresh_ThemGio(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_ThemGio("0", "", "")
    End Sub
    Private Sub V_Xem_ThemGio_LSSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec_Ro As String = ""

        If Not Dt_ThemGio Is Nothing Then
            Dim iRow As Integer = -1
            iRow = Master_ThemGioGRV.GetFocusedDataSourceRowIndex
            If iRow >= 0 And Dt_ThemGio.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_ThemGio.Item(iRow).Item("Ma_Xe").ToString.Trim
            If iRow >= 0 And Dt_ThemGio.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_ThemGio.Item(iRow).Item("Ma_Ct").ToString.Trim
            If iRow >= 0 And Dt_ThemGio.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_ThemGio.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim

        End If
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, "HDK", "", AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_ExportExcel_ThemGio(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberExport As New Cyber.Export.Sys
        Dim FileName As String = ""
        Dim Dt_Title As New DataTable
        Dt_Title.Columns.Add("Title1")
        Dt_Title.Columns.Add("Title2")
        Dt_Title.Rows.Add(Dt_ColFrozen_ThemGio.Rows(0).Item("Title"))
        Dim Dt_TitleDetail As New DataTable
        Dt_TitleDetail.Columns.Add("Tu_Ngay")
        FileName = CyberExport.V_ExportToXlsx(AppConn, Master_ThemGioGRV, New DataView(Dt_Title), New DataView(Dt_TitleDetail), Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub Master_ThemGioGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_ThemGioGRV, Dt_ThemGio, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub

#End Region
#End Region

#Region "TAB8 - Khác"
#Region "Khai bao bien"
    Dim _CP_Khac As String = "CP_WORK_Khac"
    Dim Dt_Khac, Dt_ColFrozen_Khac, Dt_Head_Khac As DataTable
    Dim Dv_Khac, Dv_Head_Khac As DataView
    Dim Dt_CVDV_Khac As DataTable
#End Region
#Region "Load"
    Private Sub V_TAB8_Load_Khac()
        '------------------------------------------------------------------------------------------------------
        V_GetAndFillData_Khac()
        '------------------------------------------------------------------------------------------------------
        V_LoadData_Khac("1", "", "")
        '------------------------------------------------------------------------------------------------------
        V_SetDeffault_Khac()
        '------------------------------------------------------------------------------------------------------
        V_AddHander_Khac()
        '------------------------------------------------------------------------------------------------------
        Master_khacGRV.ColumnPanelRowHeight = 30
    End Sub
    Private Sub V_GetAndFillData_Khac()
        Dt_CVDV_Khac = Dt_CVDV.Copy
        '------------------------------------------------------------------------------------------------------
        CyberFill.V_FillComBoxDefaul(CbbCVDV_Khac, Dt_CVDV_Khac, "Ma_HS", "Ten_Hs", "Ngam_Dinh")
    End Sub
    Private Sub V_LoadData_Khac(ByVal status As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String)
        If status = "0" And Dt_Khac Is Nothing Then Return
        If Dt_Khac Is Nothing And status <> "1" Then Return
        If Not Dt_Khac Is Nothing Then status = "0"

        Dim _Dt As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim _Filter As String = status
        _Filter = _Filter & "#" & M_Kieu_Xem
        _Filter = _Filter & "#" & M_Loai_SC
        _Filter = _Filter & "#" & _Stt_Rec
        _Filter = _Filter & "#" & _Stt_Rec_Ro
        _Filter = _Filter & "#" & _Dt.ToString("yyyyMMdd")
        _Filter = _Filter & "#" & ""
        _Filter = _Filter & "#" & M_Ma_Dvcs
        _Filter = _Filter & "#" & M_User_Name


        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, _CP_Khac, _Filter)
        If status.ToString.Trim = "1" Then
            Dt_Khac = New DataTable
            Dt_Head_Khac = New DataTable

            Dt_Khac = DsTmp.Tables(0).Copy
            Dt_ColFrozen_Khac = DsTmp.Tables(1).Copy
            Dt_Head_Khac = DsTmp.Tables(2).Copy

            Dv_Khac = New DataView(Dt_Khac)
            Dv_Head_Khac = New DataView(Dt_Head_Khac)

            CyberFill.V_FillReports(Master_khacGRV, M_LAN, Dv_Head_Khac, Dv_Khac)
            Master_khac.DataSource = Dv_Khac
            If Dt_Khac.Columns.Contains("Ma_Hs") Then CbbCVDV_Khac.Visible = True

        Else
            If _Stt_Rec.Trim = "" Then
                Dt_Khac.Clear()
                Dt_Khac.Load(DsTmp.Tables(0).CreateDataReader)
                Dt_Khac.AcceptChanges()
            Else
                '----------------------------------------------
                If Not Dt_Khac Is Nothing Then CyberSmodb.DeleteDatatable(Dt_Khac, "Stt_Rec ='" + _Stt_Rec.Trim + "'")
                If Not Dt_Khac Is Nothing Then Dt_Khac.Load(DsTmp.Tables(0).CreateDataReader)
            End If
        End If
        V_Filter_Khac(New System.Object, New System.EventArgs)
        DsTmp.Dispose()
    End Sub
    Private Sub V_Filter_Khac(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---------------------------------
        If Dt_Khac Is Nothing Then Return
        If Not Dt_Khac.Columns.Contains("Ma_Hs") Then Return
        Dim _ma_hs As String = CyberWork.V_GetvalueCombox(CbbCVDV_Khac)
        '---------------------------------
        Dim _Filter As String = "1=1"
        If _ma_hs <> "" Then _Filter = _Filter + " AND Ma_HS = '" + _ma_hs.Trim + "'"
        Try
            Dv_Khac.RowFilter = _Filter
        Catch ex As Exception
            Dv_Khac.RowFilter = ""
        End Try
    End Sub
    Private Sub V_SetDeffault_Khac()
        If Dt_ColFrozen_Khac Is Nothing Then Return
        If Dt_ColFrozen_Khac.Rows.Count = 0 Then Return

        Dim _ColFrozen As Integer = -1
        If Dt_ColFrozen_Khac.Columns.Contains("ColFrozen") Then _ColFrozen = Dt_ColFrozen_Khac.Rows(0).Item("ColFrozen")
        CyberSupport.V_SetSortView(Dv_Khac, Dt_ColFrozen_Khac)

        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_khacGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_khacGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub V_AddHander_Khac()
        RemoveHandler CbbCVDV_Khac.SelectedIndexChanged, AddressOf V_Filter_Khac
        RemoveHandler Master_khacGRV.PopupMenuShowing, AddressOf Master_KhacGRV_PopupMenuShowing
        RemoveHandler Master_khacGRV.RowCellStyle, AddressOf Master_KhacGRV_RowCellStyle
        '--------------------------------------------------------------------------------------
        AddHandler CbbCVDV_Khac.SelectedIndexChanged, AddressOf V_Filter_Khac
        AddHandler Master_khacGRV.PopupMenuShowing, AddressOf Master_KhacGRV_PopupMenuShowing
        AddHandler Master_khacGRV.RowCellStyle, AddressOf Master_KhacGRV_RowCellStyle
    End Sub
    Private Sub Master_KhacGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()

        If Dt_Khac.Columns.Contains("Ma_Xe") Then PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Lịch sử sửa chữa", "History Repair"), AddressOf V_Xem_Khac_LSSC, Nothing, Nothing, True, True), True).BeginGroup = True

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Export Excel", AddressOf V_ExportExcel_Khac, System.Windows.Forms.Shortcut.F12, My.Resources.exporttoxls_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_Khac, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)

        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_Refresh_Khac(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_Khac("0", "", "")
    End Sub
    Private Sub V_Xem_Khac_LSSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec_Ro As String = ""

        If Not Dt_Khac Is Nothing Then
            Dim iRow As Integer = -1
            iRow = Master_khacGRV.GetFocusedDataSourceRowIndex
            If iRow >= 0 And Dt_Khac.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_Khac.Item(iRow).Item("Ma_Xe").ToString.Trim
            If iRow >= 0 And Dt_Khac.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_Khac.Item(iRow).Item("Ma_Ct").ToString.Trim
            If iRow >= 0 And Dt_Khac.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_Khac.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim

        End If
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, "HDK", "", AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_ExportExcel_Khac(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberExport As New Cyber.Export.Sys
        Dim FileName As String = ""
        Dim Dt_Title As New DataTable
        Dt_Title.Columns.Add("Title1")
        Dt_Title.Columns.Add("Title2")
        Dt_Title.Rows.Add(Dt_ColFrozen_Khac.Rows(0).Item("Title"))
        Dim Dt_TitleDetail As New DataTable
        Dt_TitleDetail.Columns.Add("Tu_Ngay")
        FileName = CyberExport.V_ExportToXlsx(AppConn, Master_khacGRV, New DataView(Dt_Title), New DataView(Dt_TitleDetail), Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub Master_KhacGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_khacGRV, Dt_Khac, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
#End Region
#End Region

#Region "TAB9 - Hiệu suất"
#Region "Khai bao bien"
    Dim _CP_HieuSuat As String = "CP_WORK_HieuSuat"
    Dim Dt_HieuSuat, Dt_ColFrozen_HieuSuat, Dt_Head_HieuSuat As DataTable
    Dim Dv_HieuSuat, Dv_Head_HieuSuat As DataView
    Dim Dt_CVDV_HieuSuat As DataTable
#End Region
#Region "Load"
    Private Sub V_TAB9_Load_HieuSuat()
        '------------------------------------------------------------------------------------------------------
        V_GetAndFillData_HieuSuat()
        '------------------------------------------------------------------------------------------------------
        V_CreateLoai_HieuSuat()
        '------------------------------------------------------------------------------------------------------
        V_LoadData_HieuSuat("1", "", "")
        '------------------------------------------------------------------------------------------------------
        V_SetDeffault_HieuSuat()
        '------------------------------------------------------------------------------------------------------
        V_AddHander_HieuSuat()
        '------------------------------------------------------------------------------------------------------
        Master_HieuSuatGRV.ColumnPanelRowHeight = 30
    End Sub
    Dim Dt_Loai_HieuSuat As DataTable
    Private Sub V_CreateLoai_HieuSuat()
        Dt_Loai_HieuSuat = New DataTable

        Dt_Loai_HieuSuat.Columns.Add("Loai")
        Dt_Loai_HieuSuat.Columns.Add("Ten")
        Dt_Loai_HieuSuat.Columns.Add("Ten2")
        Dt_Loai_HieuSuat.Columns.Add("Ngam_Dinh")

        If M_Loai_SC = "1" Then
            Dt_Loai_HieuSuat.Rows.Add("01", "Theo khoang", "Cabil", "1")
            Dt_Loai_HieuSuat.Rows.Add("02", "Theo tổ", "Department", "0")
        Else
            Dt_Loai_HieuSuat.Rows.Add("01", "Theo khoang", "Cabil", "0")
            Dt_Loai_HieuSuat.Rows.Add("02", "Theo tổ", "Department", "1")
        End If
        Dt_Loai_HieuSuat.Rows.Add("03", "Theo KTV", "Technicians", "0")

        CyberFill.V_FillComBoxDefaul(CbbLoai_HieuSuat, Dt_Loai_HieuSuat, "Loai", IIf(M_LAN = "V", "Ten", "Ten2"), "Ngam_Dinh")

    End Sub
    Private Sub V_GetAndFillData_HieuSuat()
        Dt_CVDV_HieuSuat = Dt_CVDV.Copy
        '------------------------------------------------------------------------------------------------------
        CyberFill.V_FillComBoxDefaul(CbbCVDV_HieuSuat, Dt_CVDV_HieuSuat, "Ma_HS", "Ten_Hs", "Ngam_Dinh")
    End Sub
    Private Sub V_LoadData_HieuSuat(ByVal status As String, ByVal _Stt_Rec As String, ByVal _Stt_Rec_Ro As String)
        If status = "0" And Dt_HieuSuat Is Nothing Then Return
        If Dt_HieuSuat Is Nothing And status <> "1" Then Return
        ''    If Not Dt_HieuSuat Is Nothing Then status = "0"

        Dim _Loai_HieuSuat As String = CyberWork.V_GetvalueCombox(CbbLoai_HieuSuat)

        Dim _Dt As Date = TxtM_Ngay_Ct_KH_SCC.Value
        Dim _Filter As String = status
        _Filter = _Filter & "#" & M_Kieu_Xem
        _Filter = _Filter & "#" & M_Loai_SC
        _Filter = _Filter & "#" & _Loai_HieuSuat
        _Filter = _Filter & "#" & _Stt_Rec
        _Filter = _Filter & "#" & _Stt_Rec_Ro
        _Filter = _Filter & "#" & _Dt.ToString("yyyyMMdd")
        _Filter = _Filter & "#" & ""
        _Filter = _Filter & "#" & M_Ma_Dvcs
        _Filter = _Filter & "#" & M_User_Name

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, _CP_HieuSuat, _Filter)
        If status.ToString.Trim = "1" Then
            Dt_HieuSuat = New DataTable
            Dt_Head_HieuSuat = New DataTable

            Dt_HieuSuat = DsTmp.Tables(0).Copy
            Dt_ColFrozen_HieuSuat = DsTmp.Tables(1).Copy
            Dt_Head_HieuSuat = DsTmp.Tables(2).Copy

            Dv_HieuSuat = New DataView(Dt_HieuSuat)
            Dv_Head_HieuSuat = New DataView(Dt_Head_HieuSuat)

            CyberFill.V_FillReports(Master_HieuSuatGRV, M_LAN, Dv_Head_HieuSuat, Dv_HieuSuat)
            Master_HieuSuat.DataSource = Dv_HieuSuat
            If Dt_HieuSuat.Columns.Contains("Ma_Hs") Then CbbCVDV_HieuSuat.Visible = True

        Else
            If _Stt_Rec.Trim = "" Then
                Dt_HieuSuat.Clear()
                Dt_HieuSuat.Load(DsTmp.Tables(0).CreateDataReader)
                Dt_HieuSuat.AcceptChanges()
            Else
                '----------------------------------------------
                If Not Dt_HieuSuat Is Nothing Then CyberSmodb.DeleteDatatable(Dt_HieuSuat, "Stt_Rec ='" + _Stt_Rec.Trim + "'")
                If Not Dt_HieuSuat Is Nothing Then Dt_HieuSuat.Load(DsTmp.Tables(0).CreateDataReader)
            End If
        End If
        V_Filter_HieuSuat(New System.Object, New System.EventArgs)
        DsTmp.Dispose()
    End Sub

    Private Sub V_Filter_HieuSuat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '---------------------------------
        If Dt_HieuSuat Is Nothing Then Return
        If Not Dt_HieuSuat.Columns.Contains("Ma_Hs") Then Return
        Dim _ma_hs As String = CyberWork.V_GetvalueCombox(CbbCVDV_HieuSuat)
        '---------------------------------
        Dim _Filter As String = "1=1"
        If _ma_hs <> "" Then _Filter = _Filter + " AND Ma_HS = '" + _ma_hs.Trim + "'"
        Try
            Dv_HieuSuat.RowFilter = _Filter
        Catch ex As Exception
            Dv_HieuSuat.RowFilter = ""
        End Try
    End Sub
    Private Sub V_SetDeffault_HieuSuat()
        If Dt_ColFrozen_HieuSuat Is Nothing Then Return
        If Dt_ColFrozen_HieuSuat.Rows.Count = 0 Then Return

        Dim _ColFrozen As Integer = -1
        If Dt_ColFrozen_HieuSuat.Columns.Contains("ColFrozen") Then _ColFrozen = Dt_ColFrozen_HieuSuat.Rows(0).Item("ColFrozen")
        CyberSupport.V_SetSortView(Dv_HieuSuat, Dt_ColFrozen_HieuSuat)

        If _ColFrozen >= 0 Then
            Try
                If _ColFrozen < Master_HieuSuatGRV.Columns.Count And _ColFrozen > 0 Then
                    For iCol = 0 To _ColFrozen
                        Master_HieuSuatGRV.Columns(iCol).Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left
                    Next
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub V_AddHander_HieuSuat()
        RemoveHandler CbbCVDV_HieuSuat.SelectedIndexChanged, AddressOf V_Filter_HieuSuat
        RemoveHandler Master_HieuSuatGRV.PopupMenuShowing, AddressOf Master_HieuSuatGRV_PopupMenuShowing
        RemoveHandler Master_HieuSuatGRV.RowCellStyle, AddressOf Master_HieuSuatGRV_RowCellStyle
        RemoveHandler CbbLoai_HieuSuat.SelectedIndexChanged, AddressOf V_Loai_HieuSuat

        '--------------------------------------------------------------------------------------
        AddHandler CbbCVDV_HieuSuat.SelectedIndexChanged, AddressOf V_Filter_HieuSuat
        AddHandler Master_HieuSuatGRV.PopupMenuShowing, AddressOf Master_HieuSuatGRV_PopupMenuShowing
        AddHandler Master_HieuSuatGRV.RowCellStyle, AddressOf Master_HieuSuatGRV_RowCellStyle
        AddHandler CbbLoai_HieuSuat.SelectedIndexChanged, AddressOf V_Loai_HieuSuat
    End Sub
    Private Sub Master_HieuSuatGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If

        PopupMenu.ItemLinks.Clear()

        If Dt_HieuSuat.Columns.Contains("Ma_Xe") Then PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Lịch sử sửa chữa", "History Repair"), AddressOf V_Xem_HieuSuat_LSSC, Nothing, Nothing, True, True), True).BeginGroup = True

        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, "Export Excel", AddressOf V_ExportExcel_HieuSuat, System.Windows.Forms.Shortcut.F12, My.Resources.exporttoxls_16x16, True, True), True).BeginGroup = False
        PopupMenu.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, 0, IIf(Lan = "V", "Làm tươi dữ liệu", "Refresh"), AddressOf V_Refresh_HieuSuat, System.Windows.Forms.Shortcut.F5, My.Resources.refresh2_16x16, True, True), True).BeginGroup = False
        Dim MenuExits As New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Quay ra", "Exit"), AddressOf V_Quay_Ra, My.Resources.cancel_16x16, True, True)

        PopupMenu.ItemLinks.Add(MenuExits, True)
        PopupMenu.ShowPopup(Control.MousePosition)
        If Not e Is Nothing Then PopupMenu.ShowPopup(Control.MousePosition)
    End Sub
    Private Sub V_Loai_HieuSuat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_HieuSuat("1", "", "")
    End Sub
    Private Sub V_Refresh_HieuSuat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadData_HieuSuat("0", "", "")
    End Sub
    Private Sub V_Xem_HieuSuat_LSSC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ma_Xe As String = ""
        Dim _Ma_Ct As String = ""
        Dim _Stt_Rec_Ro As String = ""

        If Not Dt_HieuSuat Is Nothing Then
            Dim iRow As Integer = -1
            iRow = Master_HieuSuatGRV.GetFocusedDataSourceRowIndex
            If iRow >= 0 And Dt_HieuSuat.Columns.Contains("Ma_Xe") Then _Ma_Xe = Dv_HieuSuat.Item(iRow).Item("Ma_Xe").ToString.Trim
            If iRow >= 0 And Dt_HieuSuat.Columns.Contains("Ma_Ct") Then _Ma_Ct = Dv_HieuSuat.Item(iRow).Item("Ma_Ct").ToString.Trim
            If iRow >= 0 And Dt_HieuSuat.Columns.Contains("Stt_Rec_Ro") Then _Stt_Rec_Ro = Dv_HieuSuat.Item(iRow).Item("Stt_Rec_Ro").ToString.Trim

        End If
        CyberSupport.V_Lich_Su_SC(_Ma_Xe, "HDK", "", AppConn, Me.Sysvar, M_LAN, Me.Para, M_Ma_Dvcs, M_User_Name, CyberSmlib, CyberSupport, CyberFill, CyberSmlistSys, CyberSmodb, CyberExport, CyberLoading)
    End Sub
    Private Sub V_ExportExcel_HieuSuat(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim CyberExport As New Cyber.Export.Sys
        Dim FileName As String = ""
        Dim Dt_Title As New DataTable
        Dt_Title.Columns.Add("Title1")
        Dt_Title.Columns.Add("Title2")
        Dt_Title.Rows.Add(Dt_ColFrozen_HieuSuat.Rows(0).Item("Title"))
        Dim Dt_TitleDetail As New DataTable
        Dt_TitleDetail.Columns.Add("Tu_Ngay")
        FileName = CyberExport.V_ExportToXlsx(AppConn, Master_HieuSuatGRV, New DataView(Dt_Title), New DataView(Dt_TitleDetail), Me.Para, Me.Sysvar, Me.Lan, M_Ma_Dvcs, M_User_Name)
    End Sub
    Private Sub Master_HieuSuatGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, Master_HieuSuatGRV, Dt_HieuSuat, Me.Font, "Bold", "BackColor", "BackColor2", "Forecolor", "Underline", "Italic", CyberColor)
    End Sub
#End Region
#End Region
#End Region
End Class
