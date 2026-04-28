Public Class DMUT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim CyberColor As New Cyber.Color.Sys
    Dim DtUT As New DataTable
    Private Sub FDMUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        CreateTabe()
        V_Load()

        CyberSupport.Translaste(Me, M_LAN, True)
        CmbMa_UT.Focus()
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

        TxtBackcolor.ReadOnly = True
        TxtForecolor.ReadOnly = True
        TxtBackcolor_Test.ReadOnly = True
        TxtForecolor_Test.ReadOnly = True

        TxtBackcolor.BackColor = Drawing.Color.White
        TxtForecolor.BackColor = Drawing.Color.White
        TxtBackcolor_Test.BackColor = Drawing.Color.White
        TxtForecolor_Test.BackColor = Drawing.Color.White

        TxtBackcolor_Test.BackColor = CyberColor.GetBacColorkReports(TxtBackcolor.Text)
        TxtForecolor_Test.BackColor = CyberColor.GetBacColorkReports(TxtForecolor.Text)

        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            CmbMa_UT.Enabled = True
        End If
        If Me.Mode = "S" Then
            CmbMa_UT.Enabled = False
        End If
    End Sub
    Private Sub CreateTabe()

        DtUT.Columns.Add("Ma_UT")
        DtUT.Columns.Add("Ten_UT")
        DtUT.Columns.Add("Ten_UT2")
        DtUT.Columns.Add("Default")
        Dim _MaUT As String = ""
        Dim _Default As String = "0"

        For i As Integer = 1 To 20
            _MaUT = Strings.Right("00" + i.ToString.Trim, 2).Trim
            DtUT.Rows.Add(_MaUT.ToString, _MaUT, _MaUT, _Default)
        Next
        CyberFill.V_FillComBoxDefaul(CmbMa_UT, DtUT, "Ma_UT", IIf(Me.M_LAN = "V", "Ten_UT", "Ten_UT2"), "Default")
    End Sub
   
    Private Sub V_Color(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ReturnColor As System.Drawing.Color
        If CyberColor.V_GetColor("", _ReturnColor) Then
            TxtBackcolor.Text = _ReturnColor.R.ToString + "," + _ReturnColor.G.ToString.Trim + "," + _ReturnColor.B.ToString.Trim
            TxtBackcolor_Test.BackColor = _ReturnColor
        End If
    End Sub
    Private Sub V_Color2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ReturnColor As System.Drawing.Color
        If CyberColor.V_GetColor("", _ReturnColor) Then
            TxtForecolor.Text = _ReturnColor.R.ToString + "," + _ReturnColor.G.ToString.Trim + "," + _ReturnColor.B.ToString.Trim
            TxtForecolor_Test.BackColor = _ReturnColor
        End If
    End Sub
    Private Sub V_Clear(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtBackcolor.Text = ""
        TxtBackcolor_Test.BackColor = Drawing.Color.White
    End Sub
    Private Sub V_Clear2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtForecolor.Text = ""
        TxtForecolor_Test.BackColor = Drawing.Color.White
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
       


    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler CmbMa_UT.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler CmbMa_UT.KeyPress, AddressOf TxtCodeError_KeyPress


        RemoveHandler ButtBColor.Click, AddressOf V_Color
        RemoveHandler ButtFColor.Click, AddressOf V_Color2

        RemoveHandler ButtBClear.Click, AddressOf V_Clear
        RemoveHandler ButtFClear.Click, AddressOf V_Clear2

        AddHandler ButtBColor.Click, AddressOf V_Color
        AddHandler ButtFColor.Click, AddressOf V_Color2

        AddHandler ButtBClear.Click, AddressOf V_Clear
        AddHandler ButtFClear.Click, AddressOf V_Clear2

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

 
End Class
