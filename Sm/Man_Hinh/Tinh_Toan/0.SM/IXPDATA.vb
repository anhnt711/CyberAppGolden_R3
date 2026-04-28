Imports Ionic.Zip
Public Class IXPDATA
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim K_Path As String
    Dim Ok_Import As Boolean = False
    Dim pathfile As String
    Private Sub ReviewVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        FrmLoad()
        V_Addhandel()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
        K_Path = K_Tmp.Trim + "\Dri"
    End Sub
    Private Sub V_Load()
        TxtxDFrom.Value = Now.Date
        TxtxDTo.Value = Now.Date

        TxtIDFrom.Value = Now.Date
        TxtIDTo.Value = Now.Date
    End Sub
    Private Sub FrmLoad()
        With Me
            .Text = IIf(M_LAN = "V", M_Bar, M_Bar2)
            .ChkIBak.Checked = True
            .ChkEBak.Checked = True
            .TxtL_ma_DVCS.Text = M_Ma_Dvcs.Trim
            V_TenFile()
        End With
        If Not My.Computer.FileSystem.DirectoryExists(Sysvar("M_PATH_XI")) Then
            My.Computer.FileSystem.CreateDirectory(Sysvar("M_PATH_XI"))
        End If
    End Sub
    Private Sub V_Addhandel()
        AddHandler ButtOK.Click, AddressOf V_Save
        '============ Exports
        AddHandler TxtxDFrom.Leave, AddressOf V_GetTen
        AddHandler TxtxDTo.Leave, AddressOf V_GetTen
        AddHandler CmdEXFile_Copy.Click, AddressOf V_EXFile_Copy
        AddHandler CmdEXL_ma_Dvsc.Click, AddressOf V_EXL_ma_Dvsc
        AddHandler CmdEXFile_Export.Click, AddressOf V_EXFile_Export
        AddHandler CmdEXHistory_Export.Click, AddressOf V_EXHistory_Export
        '============ Import
        AddHandler CmdIFile_Import.Click, AddressOf V_IFile_Import
        AddHandler CmdIHistory_Import.Click, AddressOf V_History_Import
    End Sub
    Private Sub V_GetTen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_TenFile()
    End Sub
    Sub V_TenFile()
        Dim dt1 As Date
        Dim dt2 As Date
        dt1 = TxtxDFrom.Value
        dt2 = TxtxDTo.Value
        With Me
            If pathfile = "" Then
                .TxtFile_Export.Text = Sysvar("M_PATH_XI").ToString.Trim + TxtL_ma_DVCS.Text.ToString.Trim.Replace(",", "_").Replace(" ", "") + "_" + dt1.ToString("yyyyMMdd") + "_To_" + dt2.ToString("yyyyMMdd") + ".Zip"
            Else
                .TxtFile_Export.Text = pathfile + TxtL_ma_DVCS.Text.ToString.Trim.Replace(",", "_").Replace(" ", "") + "_" + dt1.ToString("yyyyMMdd") + "_To_" + dt2.ToString("yyyyMMdd") + ".Zip"
            End If

        End With
    End Sub
    Private Sub V_Save(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Nhan()
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
    Private Sub V_Nhan()
        If Tab_RaVaoSolieu.SelectedIndex = 0 Then
            If ChkEBak.Checked Then If Not V_BackupDatabase() Then Exit Sub
            If Not V_Export() Then Exit Sub
        Else
            If ChkIBak.Checked Then If Not V_BackupDatabase() Then Exit Sub
            If Not V_Imports() Then Exit Sub
        End If
    End Sub
#Region "Export "
    Private Function V_Export() As Boolean
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm()
        Dim Dt1 As New Date
        Dim Dt2 As New Date
        Dt1 = TxtxDFrom.Value
        Dt2 = TxtxDTo.Value
        Dim File_Full_Path As String = Me.TxtFile_Export.Text.Trim
        Dim fileName As String = IO.Path.GetFileNameWithoutExtension(File_Full_Path)
        Dim Path_File = IO.Path.GetDirectoryName(File_Full_Path)
        Dim DsKQ As New DataSet
        Dim strParameterStore = Dt1.ToString("yyyyMMdd")
        strParameterStore = strParameterStore + "#" + Dt2.ToString("yyyyMMdd")
        strParameterStore = strParameterStore + "#" + TxtL_ma_DVCS.Text.Trim
        strParameterStore = strParameterStore + "#" + M_Ma_Dvcs.Trim
        strParameterStore = strParameterStore + "#" + M_User_ID.Trim
        Try
            DsKQ = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "Cp_ExportDataBase", strParameterStore)
        Catch ex As Exception
            MsgBox("Qúa trình thực hiện lưu trữ bị lỗi, bạn liên hệ với nhà cung cấp phần mềm!", MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Return False
        End Try

        If Not My.Computer.FileSystem.DirectoryExists(Path_File) Then My.Computer.FileSystem.CreateDirectory(Path_File)
        If Not My.Computer.FileSystem.DirectoryExists(K_Path.Trim) Then
            My.Computer.FileSystem.CreateDirectory(K_Path.Trim)
        Else
            My.Computer.FileSystem.DeleteDirectory(K_Path.Trim, FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.CreateDirectory(K_Path.Trim)
        End If

        'DsKQ.Tables(0).WriteXml(K_Path.Trim + "\SysDbname.Xml", XmlWriteMode.WriteSchema)
        DsKQ.Tables(0).WriteXml(K_Path.Trim + "\Notes.Xml", XmlWriteMode.WriteSchema)
        DsKQ.Tables(1).WriteXml(K_Path.Trim + "\Data.Xml", XmlWriteMode.WriteSchema)
        '-------Zip
        Zip_file(K_Path, Path_File, fileName)

        Try
            'My.Computer.FileSystem.DeleteFile(K_Path.Trim + "\SysDbname.Xml")
            My.Computer.FileSystem.DeleteFile(K_Path.Trim + "\Notes.Xml")
            My.Computer.FileSystem.DeleteFile(K_Path.Trim + "\Data.Xml")
            If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        Catch ex As Exception
            If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
            MsgBox("Qúa trình thực hiện bị lỗi, bạn liên hệ với nhà cung cấp phần mềm!", MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Return False
        End Try
        Return True
    End Function
    Private Sub V_EXL_ma_Dvsc(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strReturn As String = CyberSupport.V_GetStrSelectList(AppConn, Sysvar, Para, "CP_GetListSelect", "DMDVCS#" & TxtL_ma_DVCS.Text & "##" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
        If strReturn Is Nothing Then Exit Sub
        TxtL_ma_DVCS.Text = strReturn
    End Sub
    Private Sub V_EXFile_Copy(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.V_GetStrSelectList(AppConn, Sysvar, Para, "CP_GetListSysDbname", "SysDbname###" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
    End Sub
    Private Sub V_EXFile_Export(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dt1 As Date
        Dim dt2 As Date
        dt1 = TxtxDFrom.Value
        dt2 = TxtxDTo.Value

        OpenFileDialogOuput.Filter = "All files|*.*"
        OpenFileDialogOuput.InitialDirectory = Sysvar("M_PATH_XI").ToString.Trim
        OpenFileDialogOuput.CheckFileExists = False
        OpenFileDialogOuput.FileName = Sysvar("M_PATH_XI").ToString.Trim + TxtL_ma_DVCS.Text.ToString.Trim.Replace(",", "_").Replace(" ", "") + "_" + dt1.ToString("yyyyMMdd") + "_To_" + dt2.ToString("yyyyMMdd") + ".Zip"
        OpenFileDialogOuput.ShowDialog()
        TxtFile_Export.Text = OpenFileDialogOuput.FileName
        pathfile = IO.Path.GetDirectoryName(TxtFile_Export.Text)
    End Sub
    Private Sub V_EXHistory_Export(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.V_GetStrSelectList(AppConn, Sysvar, Para, "CP_GetListDataHistory", "HistoryInOut#R##" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
    End Sub
#End Region
#Region "Import "
    Private Function V_Imports() As Boolean
        If Not Ok_Import Then Return False
        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm()
        Dim Dt1 As Date
        Dim Dt2 As Date
        Dim Ds As New DataSet
        Dt1 = TxtIDFrom.Value
        Dt2 = TxtIDTo.Value
        Try
            Dt1 = TxtIDFrom.Value
            Dt2 = TxtIDTo.Value
            Ds = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ImportdataChk", Dt1.ToString("yyyyMMdd") + "#" + Dt2.ToString("yyyyMMdd") + "#" + TxtIL_Ma_DVCS.Text + "#" + M_Ma_Dvcs + "#" + M_User_Name.ToString.ToString)
            If Ds.Tables(0).Rows(0).Item("status").ToString.Trim.ToUpper = "N" Then
                If Ds.Tables(0).Rows(0).Item("Msg").ToString.Trim.ToUpper = "Y" Then
                    MsgBox(Ds.Tables(0).Rows(0).Item("note").ToString.Trim, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
                End If
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try

        Dim Ds_Import As New DataSet
        Dim i, nCount As Integer
        Dim streamRead As New System.IO.StreamReader(K_Path.Trim + "\Data.xml", System.IO.FileMode.Open)
        Ds_Import.ReadXml(streamRead)
        nCount = Ds_Import.Tables(0).Rows.Count - 1
        For i = 0 To Ds_Import.Tables(0).Rows.Count - 1
            CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Importdata", Ds_Import.Tables(0).Rows(i).Item("txt").ToString.Trim)
        Next
        streamRead.Dispose()
        Ds_Import.Dispose()
        '--------------------------------------------------------------------------------------------------------------------------------      
        CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_PortDataHistory", "V#" + TxtFile_Import.Text.Trim + "#" + M_User_ID.Trim)
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        Return True
    End Function
    Private Sub V_History_Import(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSupport.V_GetStrSelectList(AppConn, Sysvar, Para, "CP_GetListDataHistory", "HistoryInOut#V##" & M_Ma_Dvcs & "#" & M_User_Name, M_LAN)
    End Sub
    Private Sub V_IFile_Import(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not My.Computer.FileSystem.DirectoryExists(Sysvar("M_PATH_XI").ToString.Trim) Then
            My.Computer.FileSystem.CreateDirectory(Sysvar("M_PATH_XI").ToString.Trim)
        End If

        Dim dt1 As Date
        Dim dt2 As Date
        dt1 = TxtxDFrom.Value
        dt2 = TxtxDTo.Value
        OpenFileDialogInput.Filter = "All files|*.Zip"
        OpenFileDialogInput.InitialDirectory = Sysvar("M_PATH_XI").ToString.Trim
        OpenFileDialogInput.ShowDialog()
        TxtFile_Import.Text = OpenFileDialogInput.FileName
        If Not My.Computer.FileSystem.DirectoryExists(K_Path.Trim) Then
            My.Computer.FileSystem.CreateDirectory(K_Path.Trim)
        Else
            My.Computer.FileSystem.DeleteDirectory(K_Path.Trim, FileIO.DeleteDirectoryOption.DeleteAllContents)
            My.Computer.FileSystem.CreateDirectory(K_Path.Trim)
        End If
        Ok_Import = UnZip(Me.TxtFile_Import.Text.Trim, K_Path)
    End Sub
#End Region
#Region "BACkUPData"
    Private Function V_BackupDatabase() As Boolean
        Dim strParameterStoreBk = M_User_ID.Trim + "#" + M_User_Name.Trim
        Try
            CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysBackUp", strParameterStoreBk)
        Catch ex As Exception
            MsgBox("Qúa trình thực hiện lưu trữ bị lỗi, bạn liên hệ với nhà cung cấp phần mềm!", MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Return False
        End Try
        Return True
    End Function
#End Region
#Region "Zip File"
    Public Sub Zip_file(ByVal Path_In As String, ByVal Path_Out As String, ByVal FileName_Zip As String)
        If Not IO.Directory.Exists(Path_In) Then Exit Sub
        If Not IO.Directory.Exists(Path_Out) Then IO.Directory.CreateDirectory(Path_Out)
        Using zip As New ZipFile()
            zip.AddDirectory(Path_In.Trim)
            zip.Save(FileName_Zip.Trim)
        End Using
        My.Computer.FileSystem.CopyFile(FileName_Zip, Path_Out.ToString.Trim + "\" + FileName_Zip + ".Zip", True)
    End Sub
    Private Function UnZip(ByVal zipFileName As String, ByVal outputDirectory As String) As Boolean
        Try
            Dim zip As ZipFile = ZipFile.Read(zipFileName)
            Dim Ds_Cn_DB As New DataSet
            IO.Directory.CreateDirectory(outputDirectory)
            zip.ExtractAll(outputDirectory, ExtractExistingFileAction.OverwriteSilently)
            zip.Dispose()
            Dim streamRead As New System.IO.StreamReader(K_Path.Trim + "\Notes.xml", System.IO.FileMode.Open)
            Ds_Cn_DB.ReadXml(streamRead)
            TxtIDFrom.Value = Ds_Cn_DB.Tables(0).Rows(0).Item("DFrom")
            TxtIDTo.Value = Ds_Cn_DB.Tables(0).Rows(0).Item("DTo")
            TxtIL_Ma_DVCS.Text = Ds_Cn_DB.Tables(0).Rows(0).Item("Units").ToString.Trim
            Ok_Import = True
            streamRead.Dispose()
            Ds_Cn_DB.Dispose()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
#End Region
End Class