Imports System.Windows.Forms
Public Class FrmTien_Do_VitriDo
    Dim M_Ma_Xe As String = ""
    Public Property Ma_Xe As String
        Get
            Ma_Xe = M_Ma_Xe
        End Get
        Set(ByVal Value As String)
            M_Ma_Xe = Value
        End Set
    End Property
    Dim M_Ma_Do As String = ""
    Public Property Ma_Do As String
        Get
            Ma_Do = M_Ma_Do
        End Get
        Set(ByVal Value As String)
            M_Ma_Do = Value
        End Set
    End Property
    Dim M_Dt_Return As DataTable = Nothing
    Public Property Dt_Return As DataTable
        Get
            Dt_Return = M_Dt_Return
        End Get
        Set(ByVal Value As DataTable)
            M_Dt_Return = Value
        End Set
    End Property
    Public M_kieu_Xem As String = ""
    Public M_Loai As String = ""
    Public M_Ma_Tang As String = ""
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable
    Dim Dt_Do As DataTable
    Private Sub FrmVitriDo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtMa_Xe.Text = M_Ma_Xe
        Me.Tag = ""
        Me.Text = "Chọn vị trí đỗ xe"
        V_Load()
        TxtMa_Xe.Focus()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler CmdFind_Vitri.Click, AddressOf V_Find_Vitri
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_VitriDoxe", M_kieu_Xem & "#" & M_Loai & "#" & M_Ma_Xe.ToString() & "#" & M_Ma_Do & "#" & M_Ma_Tang & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Dstmp.Tables.Count > 0 Then
            Dim stt As Integer = 0
            If Dstmp.Tables.Count >= stt Then
                Dt_Do = Dstmp.Tables(stt).Copy
            End If
            stt = stt + 1
        End If
        Dstmp.Dispose()
        If Not Dt_Do.Rows Is Nothing Then
            CyberFill.V_FillComBoxDefaul(CbbMa_Do, Dt_Do, "Ma_Do", "Ten_Do", "Ngam_Dinh")
        End If
    End Sub
    Private Sub V_Find_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim FRM = New FrmTien_Do_VitriDo_Vitri
        FRM.M_Loai = Me.M_Loai
        FRM.M_Ma_Xe = TxtMa_Xe.Text
        FRM.M_Ma_Dvcs = Me.M_Ma_Dvcs
        FRM.M_User_Name = Me.M_User_Name
        FRM.M_Ma_Tang = ""
        FRM.M_kieu_Xem = Me.M_kieu_Xem
        FRM.M_Ma_Do = CbbMa_Do.SelectedValue
        FRM.ShowDialog()
        If FRM.Save_OK = True Then CbbMa_Do.SelectedValue = FRM.Ma_Do_Return
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '--------------------------------------------------------------------------------------------
        If TxtMa_Xe.Text.Trim = "" Then
            TxtMa_Xe.Focus()
            Return
        End If
        '--------------------------------------------------------------------------------------------
        If CbbMa_Do.SelectedValue.Trim = "" Then
            CbbMa_Do.Focus()
            Return
        End If
        '
        Dim _strField As String = ""
        Dim _strValue As String = "'"
        CyberSmodb.GetValueControler(Me, _strField, _strValue)
        _strValue = _strValue.Replace("'", "")
        _strValue = _strValue.Replace("#", "")
        '--------------------------------------------------------------------------------------------
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_VitriDoxe_Save", M_kieu_Xem & "#" & M_Loai & "#" & TxtMa_Xe.Text & "#" & _strField & "#" & _strValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(Dstmp.Tables(0), Sysvar, M_LAN) Then
            M_Dt_Return = Nothing
        Else
            M_Dt_Return = Dstmp.Tables(0).Copy
        End If

        '--------------------------------------------------------------------------------------------
        Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = CbbMa_Do.SelectedValue
        CyberSmlib.FlushMemorySave()
        Me.Close()
        '--------------------------------------------------------------------------------------------
    End Sub
End Class
