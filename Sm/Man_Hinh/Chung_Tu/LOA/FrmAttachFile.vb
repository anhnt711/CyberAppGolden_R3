Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Data.SqlClient
Public Class FrmAttachFile
#Region "Property"
    Public Property Ma_CT() As String
        Get
            Ma_CT = M_Ma_CT
        End Get
        Set(ByVal Value As String)
            M_Ma_CT = Value
        End Set
    End Property
    Public Property Stt_rec() As String
        Get
            Stt_rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
        End Set
    End Property
    Public Property Row() As Integer
        Get
            Row = iRow
        End Get
        Set(ByVal Value As Integer)
            iRow = Value
        End Set
    End Property
    Dim M_Ma_CT As String = ""
    Dim M_Stt_rec As String = ""
    Dim iRow As Integer
#End Region
    Dim fileData As Byte() = Nothing
    Dim File_Name As String = ""
    Dim File_Type As String = ""
    Dim File_Size As Long = 0
    Public M_Dt_Return As DataTable
    Private Sub FrmUpdateRoHang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        Me.Text = "Đính kèm file"
        V_Load()
        AddHandler CmdSelectFile.Click, AddressOf V_SelectFile
        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Check Rights
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysAttachRightVoucher", "SAVE" & "#" & M_Ma_CT & "#" & M_Stt_rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            Me.M_Dt_Return = Nothing
            DsTmp.Dispose()
            Exit Sub
        End If
        'Save
        V_AttachVoucher("SAVE")

        Dim _DsReturn As DataSet = V_AttachVoucher("DOWNLOAD")
        Me.Save_OK = True
        Me.M_Dt_Return = _DsReturn.Tables(0).Copy

        Dim M_strParameterStore As String = ""
        'Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub

#Region "Attach File"
    Private Sub V_SelectFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenStatus As OpenFileDialog = CyberSupport.GetOpenFileDialog(False, "All Files |*.*")
        If (OpenStatus.ShowDialog = DialogResult.OK) Then
            Dim file As String
            For Each file In OpenStatus.FileNames
                File_Type = System.IO.Path.GetExtension(file)
                File_Name = System.IO.Path.GetFileNameWithoutExtension(file)
                Dim Fullfile_Name As String = file
                Dim info As New FileInfo(file)
                File_Size = info.Length
                fileData = CyberSupport.ReadFileToBytes(Fullfile_Name)
                TxtFile_Name.Text = Fullfile_Name
            Next
        End If
    End Sub
    Private Function V_AttachVoucher(ByVal _Type As String) As DataSet
        Dim _Parameter As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
        _Parameter.Add("M_Loai", _Type)
        _Parameter.Add("M_Ma_Sub", M_Ma_CT)
        _Parameter.Add("M_Ma_Sub_Detail", M_Stt_rec)
        _Parameter.Add("M_Stt", iRow)
        _Parameter.Add("M_File_Name", File_Name)
        _Parameter.Add("M_File_Type", File_Type)
        _Parameter.Add("M_File_SIZE", File_Size)
        _Parameter.Add("M_File_BIT", fileData)
        _Parameter.Add("M_Ma_Dvcs", M_Ma_Dvcs)
        _Parameter.Add("M_User_Name", M_User_Name)
        Dim DsReturn As DataSet = CyberSmlib.SQLExcuteStoreProcedureFile(AppConn, "CP_SysAttachVoucher", _Parameter)
        Return DsReturn
    End Function
#End Region
End Class
