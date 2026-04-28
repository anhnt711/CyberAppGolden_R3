Public Class DMCDSC
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim CyberColor As New Cyber.Color.Sys

    Private Sub DMCDSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        If Mode.Trim = "M" Then ChkIs_ConFlict.Checked = False
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

        TxtBackcolor.ReadOnly = True
        TxtBackcolor2.ReadOnly = True
        TxtForecolor.ReadOnly = True
        TxtBackcolor_TH.ReadOnly = True
        TxtBackColor_TH2.ReadOnly = True
        TxtForeColor_TH.ReadOnly = True


        TxtBackcolor_Test.ReadOnly = True
        TxtBackcolor2_Test.ReadOnly = True
        TxtForecolor_Test.ReadOnly = True
        TxtBackcolor_TH_Test.ReadOnly = True
        TxtBackColor_TH2_Test.ReadOnly = True
        TxtForeColor_TH_Test.ReadOnly = True

        TxtBackcolor.BackColor = Drawing.Color.White
        TxtBackcolor2.BackColor = Drawing.Color.White
        TxtForecolor.BackColor = Drawing.Color.White
        TxtBackcolor_TH.BackColor = Drawing.Color.White
        TxtBackColor_TH2.BackColor = Drawing.Color.White
        TxtForeColor_TH.BackColor = Drawing.Color.White

        TxtBackcolor_Test.BackColor = Drawing.Color.White
        TxtBackcolor2_Test.BackColor = Drawing.Color.White
        TxtForecolor_Test.BackColor = Drawing.Color.White
        TxtBackcolor_TH_Test.BackColor = Drawing.Color.White
        TxtBackColor_TH2_Test.BackColor = Drawing.Color.White
        TxtForeColor_TH_Test.BackColor = Drawing.Color.White

        TxtBackcolor_Test.BackColor = CyberColor.GetBacColorkReports(TxtBackcolor.Text)
        TxtBackcolor2_Test.BackColor = CyberColor.GetBacColorkReports(TxtBackcolor2.Text)
        TxtForecolor_Test.BackColor = CyberColor.GetBacColorkReports(TxtForecolor.Text)
        TxtBackcolor_TH_Test.BackColor = CyberColor.GetBacColorkReports(TxtForecolor.Text)
        TxtBackColor_TH2_Test.BackColor = CyberColor.GetBacColorkReports(TxtBackColor_TH2.Text)
        TxtForeColor_TH_Test.BackColor = CyberColor.GetBacColorkReports(TxtForeColor_TH.Text)
        
        TxtMa_Cd.Focus()
        V_SetLoai_SC()
        AddHandler ChkSCC.CheckedChanged, AddressOf V_CHk_SCC
        AddHandler ChKSDS.CheckedChanged, AddressOf V_CHk_SDS
        AddHandler ChkRua_Xe.CheckedChanged, AddressOf V_CHk_Rua_Xe
    End Sub
    Private Sub V_SetLoai_SC()
        ChkSCC.Checked = False
        ChKSDS.Checked = False
        ChkRua_Xe.Checked = True
        If TxtLoai_SC.Text.Trim = "2" Then
            ChkSCC.Checked = False
            ChKSDS.Checked = True
            ChkRua_Xe.Checked = False
        End If
        If TxtLoai_SC.Text.Trim = "1" Then
            ChkSCC.Checked = True
            ChKSDS.Checked = False
            ChkRua_Xe.Checked = False
        End If
    End Sub
    Private Sub V_getLoai_SC()
        TxtLoai_SC.Text = "0"
        If ChkSCC.Checked Then
            TxtLoai_SC.Text = "1"
            Exit Sub
        End If
        If ChKSDS.Checked Then
            TxtLoai_SC.Text = "2"
            Exit Sub
        End If
    End Sub
    Private Sub V_CHk_SCC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkSCC.Checked Then
            ChKSDS.Checked = False
            ChkRua_Xe.Checked = False
        Else
            If ChKSDS.Checked Then
                ChkRua_Xe.Checked = False
            Else
                If Not ChkRua_Xe.Checked Then
                    ChKSDS.Checked = True
                End If
            End If
        End If
    End Sub
    Private Sub V_CHk_SDS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChKSDS.Checked Then
            ChkSCC.Checked = False
            ChkRua_Xe.Checked = False
        Else
            If ChkSCC.Checked Then
                ChkRua_Xe.Checked = False
            Else
                If Not ChkRua_Xe.Checked Then
                    ChkSCC.Checked = True
                End If
            End If
        End If
    End Sub
    Private Sub V_CHk_Rua_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If ChkRua_Xe.Checked Then
            ChkSCC.Checked = False
            ChKSDS.Checked = False
        Else
            If ChkSCC.Checked Then
                ChKSDS.Checked = False
            Else
                If Not ChKSDS.Checked Then
                    ChkSCC.Checked = True
                End If
            End If
        End If
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
    Private Sub V_Color4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ReturnColor As System.Drawing.Color
        If CyberColor.V_GetColor("", _ReturnColor) Then
            TxtBackcolor_TH.Text = _ReturnColor.R.ToString + "," + _ReturnColor.G.ToString.Trim + "," + _ReturnColor.B.ToString.Trim
            TxtBackcolor_TH_Test.BackColor = _ReturnColor
        End If
    End Sub
    Private Sub V_Color5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ReturnColor As System.Drawing.Color
        If CyberColor.V_GetColor("", _ReturnColor) Then
            TxtBackColor_TH2.Text = _ReturnColor.R.ToString + "," + _ReturnColor.G.ToString.Trim + "," + _ReturnColor.B.ToString.Trim
            TxtBackColor_TH2_Test.BackColor = _ReturnColor
        End If
    End Sub
    Private Sub V_Color6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ReturnColor As System.Drawing.Color
        If CyberColor.V_GetColor("", _ReturnColor) Then
            TxtForeColor_TH.Text = _ReturnColor.R.ToString + "," + _ReturnColor.G.ToString.Trim + "," + _ReturnColor.B.ToString.Trim
            TxtForeColor_TH_Test.BackColor = _ReturnColor
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
    Private Sub V_Clear4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtBackcolor_TH.Text = ""
        TxtBackcolor_TH_Test.BackColor = Drawing.Color.White
    End Sub
    Private Sub V_Clear5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtBackColor_TH2.Text = ""
        TxtBackColor_TH2_Test.BackColor = Drawing.Color.White
    End Sub
    Private Sub V_Clear6(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtForeColor_TH.Text = ""
        TxtForeColor_TH_Test.BackColor = Drawing.Color.White
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_to.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_To", "DmToSC", "ma_To = N'" + TxtMa_to.Text + "'", CyberSmlib)
        TxtTen_khoang.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_khoang", "Dmkhoang", "ma_khoang = N'" + Txtma_khoang.Text + "'", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If Me.Mode = "M" Then TxtLoai_SC.Text = "0"
        If Me.Mode = "M" Then
            ChkSCC.Checked = True
            ChKSDS.Checked = False
            ChkRua_Xe.Checked = False
        End If
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_Cd.KeyPress, AddressOf TxtCodeError_KeyPress
        RemoveHandler ButtColor.Click, AddressOf V_Color
        RemoveHandler ButtColor2.Click, AddressOf V_Color2
        RemoveHandler ButtColor3.Click, AddressOf V_Color3
        RemoveHandler ButtColor4.Click, AddressOf V_Color4
        RemoveHandler ButtColor5.Click, AddressOf V_Color5
        RemoveHandler ButtColor6.Click, AddressOf V_Color6
        RemoveHandler ButtClear.Click, AddressOf V_Clear
        RemoveHandler ButtClear2.Click, AddressOf V_Clear2
        RemoveHandler ButtClear3.Click, AddressOf V_Clear3
        RemoveHandler ButtClear4.Click, AddressOf V_Clear4
        RemoveHandler ButtClear5.Click, AddressOf V_Clear5
        RemoveHandler ButtClear6.Click, AddressOf V_Clear6

        AddHandler TxtMa_Cd.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler ButtColor.Click, AddressOf V_Color
        AddHandler ButtColor2.Click, AddressOf V_Color2
        AddHandler ButtColor3.Click, AddressOf V_Color3
        AddHandler ButtColor4.Click, AddressOf V_Color4
        AddHandler ButtColor5.Click, AddressOf V_Color5
        AddHandler ButtColor6.Click, AddressOf V_Color6
        AddHandler ButtClear.Click, AddressOf V_Clear
        AddHandler ButtClear2.Click, AddressOf V_Clear2
        AddHandler ButtClear3.Click, AddressOf V_Clear3
        AddHandler ButtClear4.Click, AddressOf V_Clear4
        AddHandler ButtClear5.Click, AddressOf V_Clear5
        AddHandler ButtClear6.Click, AddressOf V_Clear6

        ''--to
        RemoveHandler TxtMa_to.CyberValiting, AddressOf V_Ma_to
        RemoveHandler TxtMa_to.CyberLeave, AddressOf L_Ma_to
        AddHandler TxtMa_to.CyberValiting, AddressOf V_Ma_to
        AddHandler TxtMa_to.CyberLeave, AddressOf L_Ma_to
        ''--khoang
        RemoveHandler Txtma_khoang.CyberValiting, AddressOf V_Ma_khoang
        RemoveHandler Txtma_khoang.CyberLeave, AddressOf L_Ma_khoang
        AddHandler Txtma_khoang.CyberValiting, AddressOf V_Ma_khoang
        AddHandler Txtma_khoang.CyberLeave, AddressOf L_Ma_khoang
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Vali --- Ma_to"
    Private Sub V_Ma_to(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_to.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_to", "DmToSC", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_to(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_to.Text = "" Then
            TxtTen_to.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_to.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_to.Text = DrReturn.Item("Ma_to")
            TxtTen_to.Text = DrReturn.Item("Ten_to")
        Else
            TxtMa_to.Text = ""
            TxtTen_to.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_khoang"
    Private Sub V_Ma_khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_khoang.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_khoang", "Dmkhoang", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_khoang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_khoang.Text = "" Then
            TxtTen_khoang.Text = ""
        End If
        DrReturn = TxtMa_khoang.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_khoang.Text = DrReturn.Item("Ma_khoang")
            TxtTen_khoang.Text = DrReturn.Item("Ten_khoang")
        Else
            TxtMa_khoang.Text = ""
            TxtTen_khoang.Text = ""
        End If
    End Sub
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        V_getLoai_SC()
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
