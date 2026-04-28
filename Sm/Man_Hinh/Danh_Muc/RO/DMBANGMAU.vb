Public Class DMBANGMAU
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim CyberColor As New Cyber.Color.Sys

    Private Sub DMBANGMAU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

        TxtBackcolor.ReadOnly = True
        TxtBackcolor2.ReadOnly = True
        TxtForecolor.ReadOnly = True

        TxtBackcolor_Test.ReadOnly = True
        TxtBackcolor2_Test.ReadOnly = True
        TxtForecolor_Test.ReadOnly = True


        TxtBackcolor.BackColor = Drawing.Color.White
        TxtBackcolor2.BackColor = Drawing.Color.White
        TxtForecolor.BackColor = Drawing.Color.White

        TxtBackcolor_Test.BackColor = Drawing.Color.White
        TxtBackcolor2_Test.BackColor = Drawing.Color.White
        TxtForecolor_Test.BackColor = Drawing.Color.White

        TxtBackcolor_Test.BackColor = CyberColor.GetBacColorkReports(TxtBackcolor.Text)
        TxtBackcolor2_Test.BackColor = CyberColor.GetBacColorkReports(TxtBackcolor2.Text)
        TxtForecolor_Test.BackColor = CyberColor.GetBacColorkReports(TxtForecolor.Text)

        TxtMa_BangMau.Focus()
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
            TxtBackcolor2.Text = _ReturnColor.R.ToString + "," + _ReturnColor.G.ToString.Trim + "," + _ReturnColor.B.ToString.Trim
            TxtBackcolor2_Test.BackColor = _ReturnColor
        End If
    End Sub
    Private Sub V_Color3(ByVal sender As System.Object, ByVal e As System.EventArgs)
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
        TxtBackcolor2.Text = ""
        TxtBackcolor2_Test.BackColor = Drawing.Color.White
    End Sub
    Private Sub V_Clear3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtForecolor.Text = ""
        TxtForecolor_Test.BackColor = Drawing.Color.White
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_BangMau.KeyPress, AddressOf TxtCodeError_KeyPress
        RemoveHandler ButtColor.Click, AddressOf V_Color
        RemoveHandler ButtColor2.Click, AddressOf V_Color2
        RemoveHandler ButtColor3.Click, AddressOf V_Color3
        RemoveHandler ButtClear.Click, AddressOf V_Clear
        RemoveHandler ButtClear2.Click, AddressOf V_Clear2
        RemoveHandler ButtClear3.Click, AddressOf V_Clear3

        AddHandler TxtMa_BangMau.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler ButtColor.Click, AddressOf V_Color
        AddHandler ButtColor2.Click, AddressOf V_Color2
        AddHandler ButtColor3.Click, AddressOf V_Color3
        AddHandler ButtClear.Click, AddressOf V_Clear
        AddHandler ButtClear2.Click, AddressOf V_Clear2
        AddHandler ButtClear3.Click, AddressOf V_Clear3
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
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
