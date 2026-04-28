Imports System.Windows.Forms
Imports System.IO
Public Class LOA_F3
#Region "AddProperty"
    Dim M_Ma_CT As String
    Public Property Ma_CT() As String
        Get
            Ma_CT = M_Ma_CT
        End Get
        Set(ByVal Value As String)
            M_Ma_CT = Value
        End Set
    End Property
    Dim M_Ma_GD As String
    Public Property Ma_GD() As String
        Get
            Ma_GD = M_Ma_GD
        End Get
        Set(ByVal Value As String)
            M_Ma_GD = Value
        End Set
    End Property
    Dim M_Stt_rec As String
    Public Property Stt_rec() As String
        Get
            Stt_rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
        End Set
    End Property
    Dim M_Drv_Load As DataRowView
    Public Property Drv_Load() As DataRowView
        Get
            Drv_Load = M_Drv_Load
        End Get
        Set(ByVal Value As DataRowView)
            M_Drv_Load = Value
        End Set
    End Property
#End Region
#Region "Declare "
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet

    Dim Dt_Master, Dt_Detail, Dt_Detail_Attach, Dt_Detail_Approve, Dt_Detail_Support As DataTable
    Dim Dv_Master, Dv_Detail, Dv_Detail_Attach, Dv_Detail_Approve, Dv_Detail_Support As DataView

    Dim EditButtOpen, EditButtDownLoad As New Cyber.Fill.CyberColumnGridView

    Dim M_Path As String
    Dim FileData As Byte() = Nothing
    Dim File_Name As String = ""
    Dim File_Type As String = ""
    Dim File_Size As Long = 0
#End Region
    Private Sub CRM_F3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        '--------------------------------------------------------------------
        M_Path = Sysvar("M_Tmp") + "\Download\"
        V_Load()
        EditButtOpen.GetColumn(DetailGRV_Attach, "ButtOpen")
        EditButtDownLoad.GetColumn(DetailGRV_Attach, "ButtDownLoad")
        '--------------------------------------------------------------------
        V_Addhander()
        Settxt()
        '--------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '--------------------------------------------------------------------
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub Settxt()
        ChkIsBudget.Enabled = False
        TxtDeadlineFrom.Enabled = False
        TxtDeadlineTo.Enabled = False
        TxtNgay_TH1.Enabled = False
        TxtNgay_TH2.Enabled = False
        TxtNgay_Tao.Enabled = False
    End Sub
    Private Sub V_Load()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LOAApproval_GetData", "1#" & M_Stt_rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If Dstmp.Tables.Count < 9 Then Exit Sub
        Dt_Master = Dstmp.Tables(0)
        Dv_Master = New DataView(Dt_Master)

        Dt_Detail = Dstmp.Tables(1)
        Dt_Detail_Attach = Dstmp.Tables(2)
        Dt_Detail_Approve = Dstmp.Tables(3)
        Dt_Detail_Support = Dstmp.Tables(4)

        Dv_Detail = New DataView(Dt_Detail)
        Dv_Detail_Attach = New DataView(Dt_Detail_Attach)
        Dv_Detail_Approve = New DataView(Dt_Detail_Approve)
        Dv_Detail_Support = New DataView(Dt_Detail_Support)

        Detail.DataSource = Dv_Detail
        Me.DetailGRV.GridControl = Me.Detail
        CyberFill.V_FillReports(DetailGRV, Me.Lan, New DataView(Dstmp.Tables(5)), Dv_Detail)

        Detail_Attach.DataSource = Dv_Detail_Attach
        Me.DetailGRV_Attach.GridControl = Me.Detail_Attach
        CyberFill.V_FillReports(DetailGRV_Attach, Me.Lan, New DataView(Dstmp.Tables(6)), Dv_Detail_Attach)

        Detail_Approve.DataSource = Dv_Detail_Approve
        Me.DetailGRV_Approve.GridControl = Me.Detail_Approve
        CyberFill.V_FillReports(DetailGRV_Approve, Me.Lan, New DataView(Dstmp.Tables(7)), Dv_Detail_Approve)

        Detail_Support.DataSource = Dv_Detail_Support
        Me.DetailGRV_Support.GridControl = Me.Detail_Support
        CyberFill.V_FillReports(DetailGRV_Support, Me.Lan, New DataView(Dstmp.Tables(8)), Dv_Detail_Support)

        txtSo_ct.Text = Dv_Master.Item(0).Item("So_CT")
        TxtDeadlineFrom.Value = Dv_Master.Item(0).Item("DeadlineFrom")
        TxtDeadlineTo.Value = Dv_Master.Item(0).Item("DeadlineTo")
        TxtNgay_TH1.Value = Dv_Master.Item(0).Item("Ngay_TH1")
        TxtNgay_TH2.Value = Dv_Master.Item(0).Item("Ngay_TH2")
        TxtNgay_Tao.Value = Dv_Master.Item(0).Item("Ngay_Tao")
        TxtTen_HS.Text = Dv_Master.Item(0).Item("Ten_HS")
        TxtTen_BP.Text = Dv_Master.Item(0).Item("Ten_BP")
        TxtTen_GD.Text = Dv_Master.Item(0).Item("Ten_GD")
        TxtSubject.Text = Dv_Master.Item(0).Item("Subject")
        TxtBody.Text = Dv_Master.Item(0).Item("Body")
        ChkIsBudget.Checked = IIf(Dv_Master.Item(0).Item("IsBudget") = 1, True, False)
        TxtCodeBudget.Text = Dv_Master.Item(0).Item("CodeBudget")
        TxtT_SO_LUONG.Double = Dv_Master.Item(0).Item("T_So_Luong")
        TxtT_Tien_NT.Double = Dv_Master.Item(0).Item("T_Tien_NT")
    End Sub
    Private Sub V_Addhander()
        AddHandler DetailGRV.RowCellStyle, AddressOf DetailGRV_RowCellStyle
        AddHandler DetailGRV_Attach.RowCellStyle, AddressOf DetailGRV_Attach_RowCellStyle
        AddHandler DetailGRV_Approve.RowCellStyle, AddressOf DetailGRV_Approve_RowCellStyle
        AddHandler DetailGRV_Support.RowCellStyle, AddressOf DetailGRV_Support_RowCellStyle


        AddHandler EditButtOpen.EditColumn.Click, AddressOf V_OpenFile
        AddHandler EditButtDownLoad.EditColumn.Click, AddressOf V_DownLoadFile

        AddHandler ButtApprove.Click, AddressOf V_Approve
        AddHandler ButtSupport.Click, AddressOf V_Support
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
#Region "------ Save/Close"
    Public M_Dt_Return As DataTable
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        '---------------------------------------------------------------------------------------------------------

        '---------------------------------------------------------------------------------------------------------
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub

    Dim ProccessList As New Collection
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
#End Region
#Region "Approve - Support"
    Private Sub V_Approve(ByVal sender As Object, ByVal e As EventArgs)
        Dim Dt_Data As DataTable
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LOAApproval_ApprovingLoad", M_Stt_rec & "#" & M_Ma_CT & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Exit Sub
        End If
        Dt_Data = DsTmp.Tables(1).Copy

        Dim FrmF3 As New LOA_Approve
        FrmF3.Ma_CT = Ma_CT
        FrmF3.Ma_GD = Ma_GD
        FrmF3.Stt_rec = M_Stt_rec
        FrmF3.Dt_Load = Dt_Data
        '---------------------------------------------
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
        M_Dt_Return = FrmF3.M_Dt_Return2
        Me.Save_OK = True
        Dt_Detail_Approve.Clear()
        Dt_Detail_Approve.AcceptChanges()
        For i = 0 To FrmF3.M_Dt_Return1.Rows.Count - 1
            Dt_Detail_Approve.ImportRow(FrmF3.M_Dt_Return1.Rows(i))
        Next
        Dt_Detail_Approve.AcceptChanges()
    End Sub

    Private Sub V_Support(ByVal sender As Object, ByVal e As EventArgs)
        If MsgBox("Bạn có muốn xác nhận đã Hỗ trợ cho Đề nghị này không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Sysvar("M_CYBER_VER")) <> vbAbort.Yes Then
            Exit Sub
        End If

        Dim Dstmp1 As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo.CTLOA_Approve WHERE 1=0#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim DtMaster As DataTable = Dstmp1.Tables(0).Copy
        Dim drMaster As DataRow = DtMaster.NewRow
        CyberSmodb.AddValueToRow(drMaster, Me)
        DtMaster.Rows.Add(drMaster)
        CyberSmodb.SetNotNullTable(DtMaster)
        DtMaster.AcceptChanges()
        '------------
        Dim _Xml As String = CyberSmodb.V_ConvertDataToXML({"CTLOA_Approve"}, {DtMaster})
        Dim _ReplaceDauThang As String = "!~!"
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LOAApproval_SupportSave", M_Stt_rec & "#" & M_Ma_CT & "#" & _Xml & "#" & _ReplaceDauThang & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, Me.Lan) Then Exit Sub

        Dt_Detail_Support.Clear()
        Dt_Detail_Support.AcceptChanges()
        For i = 0 To DsTmp.Tables(1).Rows.Count - 1
            Dt_Detail_Support.ImportRow(DsTmp.Tables(1).Rows(i))
        Next
        Dt_Detail_Support.AcceptChanges()
    End Sub
#End Region
#Region "Grid"
    Private Sub V_OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRV_Attach.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        '-------------------- Chk
        Dim CyberSupport As New Cyber.Support.Sys
        If Not CyberSupport.V_ChkRightAttach(AppConn, Sysvar, "CP_SysAttachRightVoucher", "DOWNLOAD", M_Ma_CT, M_Stt_rec, M_Ma_Dvcs, M_User_Name) Then Exit Sub
        '-------------------- End Chk

        Dim CyberLoading = New Cyber.Loading.Loading
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm()

        Dim Dsdownload As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysAttachVoucher", "DOWNLOAD" + "#" + M_Ma_CT + "#" + M_Stt_rec + "#" + Dv_Detail_Attach.Item(iRow).Item("Stt").ToString.Trim + "#" + "" + "#" + "" + "#" + "0" + "#" + "" + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Dsdownload.Tables(0).Rows.Count <> 1 Then MsgBox(IIf(M_LAN = "V", "Dữ liệu này đã bị xóa", "This data was deleted"), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))

        Dim Dr As DataRow = Dsdownload.Tables(0).Rows(0)


        Dim _path_Window As String = Path.GetTempPath().ToString.Trim
        If Not My.Computer.FileSystem.DirectoryExists(_path_Window) Then My.Computer.FileSystem.CreateDirectory(_path_Window)

        Dim _File_name As String = ""
        Dim _FullFile_name As String = ""
        Dim _File_Type As String = ""


        _File_name = Dr.Item("File_Name").ToString.Trim
        _File_Type = Dr.Item("File_Type").ToString.Trim
        _File_name = GetFileName(_path_Window, _File_name, _File_Type)

        Dim _File_Full As String = ""
        _File_Full = _path_Window.Trim & IIf(Strings.Right(_path_Window.Trim, 1).Trim = "\", "", "\") & _File_name.Trim & _File_Type

        If Not CyberSupport.ReadBytesToFile(_File_Full, Dr.Item("File_Bit")) Then Exit Sub

        'If My.Computer.FileSystem.FileExists Then

        'End If
        'MsgBox(_File_Full)
        CyberSupport.V_OpenProcessFile(AppConn, Para, Sysvar, Lan, M_Ma_Dvcs, M_User_Name, _File_Full)

        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        Dsdownload.Dispose()
        CyberSmlib.FlushMemorySave()
    End Sub

    Private Sub V_DownLoadFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim iRow As Integer = -1
        iRow = DetailGRV_Attach.GetFocusedDataSourceRowIndex
        If iRow < 0 Then Exit Sub

        '-------------------- Chk
        Dim CyberSupport As New Cyber.Support.Sys
        If Not CyberSupport.V_ChkRightAttach(AppConn, Sysvar, "CP_SysAttachRightVoucher", "DOWNLOAD", M_Ma_CT, M_Stt_rec, M_Ma_Dvcs, M_User_Name) Then Exit Sub
        '-------------------- End Chk

        Dim CyberLoading = New Cyber.Loading.Loading
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm()

        Dim Dsdownload As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysAttachVoucher", "DOWNLOAD" + "#" + M_Ma_CT + "#" + M_Stt_rec + "#" + Dv_Detail_Attach.Item(iRow).Item("Stt").ToString.Trim + "#" + "" + "#" + "" + "#" + "0" + "#" + "" + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Dsdownload.Tables(0).Rows.Count <> 1 Then MsgBox(IIf(M_LAN = "V", "Dữ liệu này đã bị xóa", "This data was deleted"), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))

        Dim Frm As New Cyber.Support.FrmAttachFile_Download

        Frm.CP_Attach = "CP_SysAttachRightVoucher"
        Frm.CP_ChkAttach = "CP_SysAttachVoucher"
        Frm.Loai_Attach = "DOWNLOAD"

        Frm.AppConn = AppConn
        Frm.Para = Para
        Frm.SysVar = Sysvar
        Frm.Lan = M_LAN
        Frm.Ma_Dvcs = M_Ma_Dvcs
        Frm.User_name = M_User_Name

        Frm.Ma_Sub_Detail = M_Stt_rec
        Frm.Ma_Sub = M_Ma_CT

        Frm.Path = M_Path
        Frm.Dr = Dsdownload.Tables(0).Rows(0)

        Dsdownload.Dispose()
        CyberSmlib.FlushMemory()

        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()

        Frm.ShowDialog()
        M_Path = Frm.Path.Trim
        CyberSmlib.FlushMemorySave()
    End Sub

    Private Function GetFileName(ByVal _Path As String, ByVal _File_name As String, ByVal _File_Type As String) As String

        Dim _FilePath As String = ""
        _FilePath = _Path.Trim & IIf(Strings.Right(_Path.Trim, 1).Trim = "\", "", "\") & _File_name.Trim & _File_Type
        If Not My.Computer.FileSystem.FileExists(_FilePath) Then
            GetFileName = _File_name
            Exit Function
        End If
        Dim _Return As String = _File_name
        For i As Integer = 1 To 10000
            _FilePath = _Path.Trim & IIf(Strings.Right(_Path.Trim, 1).Trim = "\", "", "\") & _File_name.Trim & i.ToString & _File_Type
            If Not My.Computer.FileSystem.FileExists(_FilePath) Then
                GetFileName = _File_name.Trim & i.ToString
                Exit Function
            End If
        Next
        GetFileName = _Return
    End Function
    Private Sub DetailGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV, Dt_Detail, Me.Font)
    End Sub
    Private Sub DetailGRV_Attach_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV_Attach, Dt_Detail_Attach, Me.Font)
    End Sub
    Private Sub DetailGRV_Approve_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV_Approve, Dt_Detail_Approve, Me.Font)
    End Sub
    Private Sub DetailGRV_Support_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        CyberSupport.DetailGRV_RowCellStyle2(sender, e, DetailGRV_Support, Dt_Detail_Support, Me.Font)
    End Sub
#End Region
End Class

