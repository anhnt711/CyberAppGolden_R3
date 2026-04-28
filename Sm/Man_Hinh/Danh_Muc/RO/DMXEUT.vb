Public Class DMXEUT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim CyberColor As New Cyber.Color.Sys
    Private Sub FDMXEUT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()

        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_xe.Focus()
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

    End Sub
    
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_HL.Value = Now.Date
            TxtNgay_HL.Enabled = True
        End If
        If Me.Mode = "S" Then TxtNgay_HL.Enabled = False
        TxtTen_UT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_UT", "DMUT", "(Ma_UT = N'" + TxtMa_UT.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        'RemoveHandler TxtMa_xe.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_xe.KeyPress, AddressOf TxtCodeError_KeyPress

        '--ma_Ct
        RemoveHandler TxtMa_UT.CyberValiting, AddressOf V_Ma_UT
        RemoveHandler TxtMa_UT.CyberLeave, AddressOf L_Ma_UT
        AddHandler TxtMa_UT.CyberValiting, AddressOf V_Ma_UT
        AddHandler TxtMa_UT.CyberLeave, AddressOf L_Ma_UT

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_UT"
    Private Sub V_Ma_UT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_UT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_UT", "DMUT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_UT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_UT.Text = "" Then
            TxtTen_UT.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_UT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_UT.Text = DrReturn.Item("Ma_UT")
            TxtTen_UT.Text = DrReturn.Item("Ten_UT")
        Else
            TxtMa_UT.Text = ""
            TxtTen_UT.Text = ""
        End If
    End Sub
#End Region
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
