Public Class LOA_Loc
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
    Dim M_Add_Title As String = ""
    Dim M_Ma_GD As String = ""
    Dim DtMaGD As DataTable
    Private Sub LOA_Loc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_GetData()

        V_AddHander()
        If M_Add_Title <> "" Then Me.Text = M_Add_Title & Me.Text
        TxtMa_BP.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_GetData()
        V_LoadDmmaGD()
        CyberFill.V_FillComBoxValue(Me.CmbMa_GD, DtMaGD, "Ma_GD", If(M_LAN = "V", "Ten_GD", "Ten_GD2"), M_Ma_GD)
    End Sub
    Private Sub V_LoadDmmaGD()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LOALoadMa_GD", M_Ma_GD + "#" + "LOA_APPRO" + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        DtMaGD = Dstmp.Tables(0).Copy
        Try
            Dim _Drs As DataRow() = DtMaGD.Select("Ngam_Dinh = '1'")
            M_Ma_GD = _Drs(0).Item("Ma_GD").ToString.Trim()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub V_AddHander()
        'Ma_Hs
        AddHandler TxtMa_Hs.CyberValiting, AddressOf V_Ma_Hs
        AddHandler TxtMa_Hs.CyberLeave, AddressOf L_Ma_Hs
        'Ma_BP
        AddHandler TxtMa_BP.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_BP.CyberLeave, AddressOf L_Ma_BP

        AddHandler ButtOK.Click, AddressOf V_Nhan
    End Sub
#Region "Valid"
#Region "Valid --- Ma_BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_BP.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_BP", "DMBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_BP.Text = "" Then
            TxtTen_BP.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_BP.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_BP.Text = DrReturn.Item("Ma_BP")
            TxtTen_BP.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_BP.Text = ""
            TxtTen_BP.Text = ""
        End If
    End Sub
#End Region
#Region "Valid --- Ma_Hs"
    Private Sub V_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Hs.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Hs.Text = "" Then
            TxtTen_Hs.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Hs.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Hs.Text = DrReturn.Item("Ma_Hs")
            TxtTen_Hs.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_Hs.Text = ""
            TxtTen_Hs.Text = ""
        End If
    End Sub
#End Region
#End Region
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim _Ma_CT As String = ""
        Dim _Ma_GD As String = ""


        Dim M_VT_PARA As Integer = CType(Me.Para(0).Trim, Integer)
        Try
            _Ma_CT = Me.Para(M_VT_PARA + 2).ToString.Trim.ToUpper()
        Catch ex As Exception

        End Try

        _Ma_GD = CyberSmodb.GetvalueFromCombox(CmbMa_GD)

        Dim M_strParameterStore As String = _Ma_CT & "#" & _Ma_GD.Trim
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_BP.Text
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Hs.Text
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name

        Me.Key_Sub3 = _Ma_CT
        Me.Key_Sub4 = _Ma_GD

        Me.Tag = M_strParameterStore
        CyberSmlib.SaveRegistry(Me, Me.Sysvar)
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
End Class
