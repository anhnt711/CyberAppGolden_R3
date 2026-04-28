Public Class DmDungSC
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim DsChkSave As New DataSet
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub DmTDTTXacNhanSC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs

        TxtBackcolor.ReadOnly = True
        TxtBackcolor_Test.ReadOnly = True
      
        TxtBackcolor.BackColor = Drawing.Color.White
         TxtBackcolor_Test.BackColor = Drawing.Color.White
     
        TxtBackcolor_Test.BackColor = CyberColor.GetBacColorkReports(TxtBackcolor.Text)
         End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler ButtColor.Click, AddressOf V_Color
        RemoveHandler ButtClear.Click, AddressOf V_Clear
      
        AddHandler ButtColor.Click, AddressOf V_Color
        AddHandler ButtClear.Click, AddressOf V_Clear
        End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
    Private Sub V_Color(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ReturnColor As System.Drawing.Color
        If CyberColor.V_GetColor("", _ReturnColor) Then
            TxtBackcolor.Text = _ReturnColor.R.ToString + "," + _ReturnColor.G.ToString.Trim + "," + _ReturnColor.B.ToString.Trim
            TxtBackcolor_Test.BackColor = _ReturnColor
        End If
    End Sub
    Private Sub V_Clear(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtBackcolor.Text = ""
        TxtBackcolor_Test.BackColor = Drawing.Color.White
    End Sub
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day

        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

End Class
