Public Class GLTC20Loc
    Public Property Add_Title() As String
        Get
            Add_Title = M_Add_Title
        End Get
        Set(ByVal Value As String)
            M_Add_Title = Value
        End Set
    End Property
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang, DtNam, Dt_MauBC As DataTable
    Dim M_Add_Title As String = ""
    Private Sub GLTC20Loc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        If M_Add_Title <> "" Then Me.Text = M_Add_Title & Me.Text
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        DtNam = CreateTableYear()

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "DmMauBC#Ma_MauBC = N'GLTC20'#Ma_MauBC,File_MauBC")
        Dt_MauBC = DsTmp.Tables(0).Copy
        DsTmp.Dispose()
        Dim DsTmp1 As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "DmThang#1=1#Id_Date")
        DtThang = DsTmp1.Tables(0).Copy
        DsTmp1.Dispose()

        Dim _Month As String = Strings.Right("00" & Now.Date.Month.ToString.Trim, 2)

        CyberFill.V_FillComBoxDefaul(CbbM_DmMauBC, Dt_MauBC, "File_mauBC", IIf(Me.Lan = "V", "Ten_MauBC", "Ten_MauBC2"), "Ngam_Dinh")
        CyberFill.V_FillComBoxValue(CbbM_Thang, DtThang, "ID_Date", IIf(Me.Lan = "V", "Caption0", "Caption1"), _Month)
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")
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
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Me.Thang1 = CbbM_Thang.SelectedValue.ToString.Trim
        Me.Nam = CbbM_Nam.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = Me.CbbM_DmMauBC.SelectedValue.ToString.Trim & "#" & Me.Thang1.ToString.Trim & "#" & Me.Nam.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Me.Tag = M_strParameterStore
        Me.Thang1 = Me.CbbM_DmMauBC.SelectedValue.ToString.Trim
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
End Class
