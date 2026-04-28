Public Class DmXeTichdiem
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim Dt_DmTTLN, Dt_DmTTCP, Dt_DmNN, Dt_DmNH, Dt_GioiTinh As DataTable
    Dim TbTP, TbQuan, TbXa As New DataTable
    Public vTbTP, vTbQuan, vTbXa As DataView
    Private Sub DMHSQuyDoiDiem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        'TxtID.ReadOnly = True
        TxtNgay_HL.Focus()
        If Me.Mode = "M" Then
            TxtNgay_HL.Value = Now.Date
            TxtMa_Dvcs.Text = M_Ma_Dvcs
        End If
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_xe.CyberValiting, AddressOf V_Ma_xe
        RemoveHandler TxtMa_xe.CyberLeave, AddressOf L_Ma_xe
        AddHandler TxtMa_xe.CyberValiting, AddressOf V_Ma_xe
        AddHandler TxtMa_xe.CyberLeave, AddressOf L_Ma_xe
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub

#End Region
#Region "Valid"
#Region "Vali --- Ma_Vtri"
    Private Sub V_Ma_xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_xe.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_xe", "Dmxe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_xe.Text = "" Then
            TxtTen_Vitri.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_xe.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_xe.Text = DrReturn.Item("Ma_xe")
            ' TxtTen_Vitri.Text = DrReturn.Item("Ten_Vitri")
        Else
            TxtMa_xe.Text = ""
            'TxtTen_Vitri.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        ' If Not _Value.Trim = "" Then TxtID.Text = _Value

        Dim _Ngay_HL As Date = TxtNgay_HL.Value
        Dim _Acti_C As String = "0"
        Dim _Acti_I As String = "0"
        Dim _Acti_N As String = "0"
        Dim _Acti_W As String = "0"
        If ChkActi_C.Checked = True Then _Acti_C = "1"
        If ChkActi_I.Checked = True Then _Acti_I = "1"
        If ChkActi_N.Checked = True Then _Acti_N = "1"
        If ChkActi_W.Checked = True Then _Acti_W = "1"
        Dim _Gia_tri_C As Double = TxtGia_Tri_C.Double
        Dim _Gia_tri_I As Double = TxtGia_Tri_I.Double
        Dim _Gia_tri_N As Double = TxtGia_Tri_N.Double
        Dim _Gia_tri_W As Double = TxtGia_Tri_W.Double

        'Dim DsTmpSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_ChckSaveDMHSQuyDoiDiem", _Ngay_HL.ToString("yyyyMMdd") + "#" + TxtID.Text + "#" + _
        '                                                                 _Gia_tri_C.ToString + "#" + _Gia_tri_I.ToString + "#" + _Gia_tri_N.ToString + "#" + _Gia_tri_W.ToString + "#" + _Acti_C + "#" + _Acti_I + "#" + _Acti_N + "#" + _Acti_W + "#" + TxtMa_Dvcs.Text)

        'If Not CyberSupport.V_MsgChk(DsTmpSave.Tables(0), Me.Sysvar, M_LAN) Then
        '    DsTmpSave.Dispose()
        '    Exit Sub
        'End If

        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

    
End Class
