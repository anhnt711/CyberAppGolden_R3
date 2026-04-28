Public Class BEGETKH_Filter
    Public Property Add_Title() As String
        Get
            Add_Title = M_Add_Title
        End Get
        Set(ByVal Value As String)
            M_Add_Title = Value
        End Set
    End Property
    Public Property Loai_KH() As String
        Get
            Loai_KH = M_Loai_KH
        End Get
        Set(ByVal Value As String)
            M_Loai_KH = Value
        End Set
    End Property
    Dim M_Loai_KH As String = "1"
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable
    Dim M_Add_Title As String = ""
    Private Sub FThangToThang_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Save_OK = False

        V_Load()
        ChkCT.Checked = True
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_kx
        AddHandler ChkCT.Click, AddressOf V_CHk_CT
        AddHandler ChkTH.Click, AddressOf V_CHk_TH
        AddHandler ChkNV.Click, AddressOf V_CHk_NV
        AddHandler chkBB.Click, AddressOf V_CHk_BB
        If M_Add_Title <> "" Then Me.Text = M_Add_Title & Me.Text
        Me.Tag = ""
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        DtThang1 = CreateTableMonth()
        DtThang2 = CreateTableMonth()
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang1, DtThang1, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Thang2, DtThang2, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")

    End Sub
#Region "-------------------------------------- Chk --------------------------------------"
    Private Sub V_CHk_CT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Chk("1")
    End Sub
    Private Sub V_CHk_TH(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Chk("2")
    End Sub
    Private Sub V_CHk_NV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Chk("3")
    End Sub
    Private Sub V_CHk_BB(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_Chk("4")
    End Sub

    Sub V_Chk(ByVal Loai As String)
        Select Case Loai.Trim.Trim
            Case "1" ' Lenh
                If ChkCT.Checked = True Then
                    ChkTH.Checked = False
                    ChkNV.Checked = False
                    chkBB.Checked = False
                Else
                    ChkTH.Checked = True
                    ChkNV.Checked = False
                    chkBB.Checked = False
                End If
            Case "2"
                If ChkTH.Checked = True Then
                    ChkCT.Checked = False
                    ChkNV.Checked = False
                    chkBB.Checked = False
                Else
                    ChkNV.Checked = True
                    ChkCT.Checked = False
                    chkBB.Checked = False
                End If
            Case "3"
                If ChkNV.Checked = True Then
                    ChkCT.Checked = False
                    ChkTH.Checked = False
                    chkBB.Checked = False
                Else
                    ChkCT.Checked = False
                    ChkTH.Checked = False
                    chkBB.Checked = True
                End If
            Case "4"
                If chkBB.Checked = True Then
                    ChkCT.Checked = False
                    ChkTH.Checked = False
                    ChkNV.Checked = False
                Else
                    ChkCT.Checked = True
                    ChkTH.Checked = False
                    ChkNV.Checked = False
                End If

        End Select
    End Sub

#End Region
#Region "Vali --- Ma_kx"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kx.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_kx", "Dmkx", "Is_kd = '1'", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_KX.Text = "" Then
            TxtTen_KX.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_KX.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KX.Text = DrReturn.Item("Ma_kx")
            TxtTen_KX.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_KX.Text = ""
            TxtTen_KX.Text = ""
        End If
    End Sub
#End Region
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

            If Now.Year = i Then
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

        If ChkCT.Checked = "1" Then M_Loai_KH = "1" Else M_Loai_KH = "0"

        Me.Thang1 = CbbM_Thang1.SelectedValue.ToString.Trim
        Me.Thang2 = CbbM_Thang2.SelectedValue.ToString.Trim
        Me.Nam = CbbM_Nam.SelectedValue.ToString.Trim

        Dim M_strParameterStore As String = Me.Thang1 & "#" & Me.Thang2 & "#" & Me.Nam
        M_strParameterStore = M_strParameterStore & "#" & TxtMa_Kx.Text.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Me.Tag = M_strParameterStore
        Me.Close()
    End Sub
End Class
