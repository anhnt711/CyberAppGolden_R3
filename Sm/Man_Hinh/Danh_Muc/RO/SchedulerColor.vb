Public Class SchedulerColor
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim tbmau As DataTable
    Dim CyberColor As New Cyber.Color.Sys
    Private vTbLoai_TD As DataView

    Private Sub DMBANGMAU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()

        CreateTabe()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

        'TxtBackcolor.ReadOnly = True
        'TxtBackcolor22.ReadOnly = True
        'TxtForecolor.ReadOnly = True
        'TxtBordercolor.ReadOnly = True

        'TxtBackcolor_Test.ReadOnly = True
        'TxtBackcolor22_Test.ReadOnly = True
        'TxtForecolor_Test.ReadOnly = True
        'TxtBordercolor_Test.ReadOnly = True

        TxtBackcolor.BackColor = Drawing.Color.White
        TxtBackcolor22.BackColor = Drawing.Color.White
        TxtForecolor.BackColor = Drawing.Color.White
        TxtBordercolor.BackColor = Drawing.Color.White

        TxtBackcolor_Test.BackColor = Drawing.Color.White
        TxtBackcolor22_Test.BackColor = Drawing.Color.White
        TxtForecolor_Test.BackColor = Drawing.Color.White
        TxtBordercolor_Test.BackColor = Drawing.Color.White

        TxtBackcolor_Test.BackColor = CyberColor.GetBacColorkReports(TxtBackcolor.Text)
        TxtBackcolor22_Test.BackColor = CyberColor.GetBacColorkReports(TxtBackcolor22.Text)
        TxtForecolor_Test.BackColor = CyberColor.GetBacColorkReports(TxtForecolor.Text)
        TxtBordercolor_Test.BackColor = CyberColor.GetBacColorkReports(TxtBordercolor.Text)

        TxtMa_Color.Focus()
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
            TxtBackcolor22.Text = _ReturnColor.R.ToString + "," + _ReturnColor.G.ToString.Trim + "," + _ReturnColor.B.ToString.Trim
            TxtBackcolor22_Test.BackColor = _ReturnColor
        End If
    End Sub
    Private Sub V_Color3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ReturnColor As System.Drawing.Color
        If CyberColor.V_GetColor("", _ReturnColor) Then
            TxtForecolor.Text = _ReturnColor.R.ToString + "," + _ReturnColor.G.ToString.Trim + "," + _ReturnColor.B.ToString.Trim
            TxtForecolor_Test.BackColor = _ReturnColor
        End If
    End Sub
    Private Sub V_Color4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ReturnColor As System.Drawing.Color
        If CyberColor.V_GetColor("", _ReturnColor) Then
            TxtBordercolor.Text = _ReturnColor.R.ToString + "," + _ReturnColor.G.ToString.Trim + "," + _ReturnColor.B.ToString.Trim
            TxtBordercolor_Test.BackColor = _ReturnColor
        End If
    End Sub
    Private Sub V_Clear(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtBackcolor.Text = ""
        TxtBackcolor_Test.BackColor = Drawing.Color.White
    End Sub
    Private Sub V_Clear2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtBackcolor22.Text = ""
        TxtBackcolor22_Test.BackColor = Drawing.Color.White
    End Sub
    Private Sub V_Clear3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtForecolor.Text = ""
        TxtForecolor_Test.BackColor = Drawing.Color.White
    End Sub
    Private Sub V_Clear4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtBordercolor.Text = ""
        TxtBordercolor_Test.BackColor = Drawing.Color.White
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If Me.Mode = "M" Then CmbLoai_TD.SelectedValue = "HEN"
        'If TxtLoai_TD.Text.Trim = "" Then CmbLoai_TD.SelectedValue = "HEN"
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_Color.KeyPress, AddressOf TxtCodeError_KeyPress
        RemoveHandler ButtColor.Click, AddressOf V_Color
        RemoveHandler ButtColor2.Click, AddressOf V_Color2
        RemoveHandler ButtColor3.Click, AddressOf V_Color3
        RemoveHandler ButtColor4.Click, AddressOf V_Color4
        RemoveHandler ButtClear.Click, AddressOf V_Clear
        RemoveHandler ButtClear2.Click, AddressOf V_Clear2
        RemoveHandler ButtClear3.Click, AddressOf V_Clear3
        RemoveHandler ButtClear4.Click, AddressOf V_Clear4

        AddHandler TxtMa_Color.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler ButtColor.Click, AddressOf V_Color
        AddHandler ButtColor2.Click, AddressOf V_Color2
        AddHandler ButtColor3.Click, AddressOf V_Color3
        AddHandler ButtColor4.Click, AddressOf V_Color4

        AddHandler ButtClear.Click, AddressOf V_Clear
        AddHandler ButtClear2.Click, AddressOf V_Clear2
        AddHandler ButtClear3.Click, AddressOf V_Clear3
        AddHandler ButtClear4.Click, AddressOf V_Clear4

        'AddHandler CmbLoai_TD.SelectedValueChanged, AddressOf V_Loai_TD_SelectedIndexChanged
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub CreateTabe()
        Dim DtLoai_TD As New DataTable

        DtLoai_TD.Columns.Add("Loai_TD", GetType(String))
        DtLoai_TD.Columns.Add("Ten", GetType(String))
        DtLoai_TD.Rows.Add("HEN", IIf(M_LAN = "V", "Hẹn sửa chữa", ""))
        ''DtLoai_TD.Rows.Add("HEN_DS", IIf(M_LAN = "V", "Hẹn sửa chữa đồng sơn", ""))
        DtLoai_TD.Rows.Add("SCC", IIf(M_LAN = "V", "Sửa chữa chung", ""))
        DtLoai_TD.Rows.Add("SDS", IIf(M_LAN = "V", "Đồng sơn", ""))
        DtLoai_TD.Rows.Add("RX", IIf(M_LAN = "V", "Rửa xe", ""))
        DtLoai_TD.Rows.Add("KHAC", IIf(M_LAN = "V", "Khác", ""))

        CyberFill.V_FillComBoxDefaul(Me.CmbLoai_TD, DtLoai_TD, "Loai_TD", "Ten")
        '---
    End Sub
    'Private Sub V_Loai_TD(ByVal Load As Boolean)
    '    If Load Then
    '        MsgBox(1)
    '        CmbLoai_TD.SelectedValue = TxtLoai_TD.Text.Trim
    '    Else
    '        TxtLoai_TD.Text = CmbLoai_TD.SelectedValue.ToString.Trim
    '    End If

    'End Sub
    'Private Sub V_Loai_TD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    V_Loai_TD(False)
    'End Sub
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
