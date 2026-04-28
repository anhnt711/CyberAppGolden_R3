Public Class DMGIAXE
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FSysList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        If TxtNam_SX.Double = 0 Then TxtNam_SX.Double = Now.Year
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_KX.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_ban.Value = Now.Date
        End If
        TxtTen_KX.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kx", "DmKx", "(Ma_Kx = N'" + TxtMa_KX.Text.Trim + "')", CyberSmlib)
        TxtTen_mau.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_mau", "Dmmauxe", "(Ma_mau = N'" + TxtMa_mau.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '-Ma_VT
        RemoveHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_kx
        RemoveHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_kx
        AddHandler TxtMa_KX.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_KX.CyberLeave, AddressOf L_Ma_kx

        '-Ma_Kho
        RemoveHandler TxtMa_mau.CyberValiting, AddressOf V_Ma_mau
        RemoveHandler TxtMa_mau.CyberLeave, AddressOf L_Ma_mau
        AddHandler TxtMa_mau.CyberValiting, AddressOf V_Ma_mau
        AddHandler TxtMa_mau.CyberLeave, AddressOf L_Ma_mau

        RemoveHandler TxtMa_KX.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_KX.KeyPress, AddressOf TxtCodeError_KeyPress

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Vali --- Ma_kx"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KX.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kx", "Dmkx", " 1=1 AND Is_KD = N'1'", "1=1")
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
#Region "Vali --- Ma_mau"
    Private Sub V_Ma_mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _FilterClient As String = "1=1"
        Dim _Ma_Kx As String = TxtMa_KX.Text
        If Not _Ma_Kx = "" Then _FilterClient = " Ma_KX = '" + _Ma_Kx + "'"

        ''TxtMa_mau.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_mau", "Dmmauxe", "1=1", _FilterClient)
        TxtMa_mau.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_mau", "DmmauKx", "1=1", _FilterClient)
    End Sub
    Private Sub L_Ma_mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If TxtMa_mau.Text = "" Then
        '    TxtTen_mau.Text = ""
        '    Exit Sub
        'End If
        'DrReturn = TxtMa_mau.GetRowsSelectData(True)
        'If Not DrReturn Is Nothing Then
        '    TxtMa_mau.Text = DrReturn.Item("Ma_mau")
        '    TxtTen_mau.Text = DrReturn.Item("Ten_mau")
        'Else
        '    TxtMa_mau.Text = ""
        '    TxtTen_mau.Text = ""
        'End If
        'If TxtMa_mau.Text = "" Then
        '    TxtTen_mau.Text = ""
        '    Exit Sub
        'End If
        DrReturn = TxtMa_mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_mau.Text = DrReturn.Item("Ma_mau")
            If DrReturn.Table.Columns.Contains("Ten_mau") Then
                TxtTen_mau.Text = DrReturn.Item("Ten_mau")
            Else
                TxtTen_mau.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_mau", "Dmmauxe", "(Ma_mau = N'" + TxtMa_mau.Text.Trim + "')", CyberSmlib)
            End If
        Else
            TxtMa_mau.Text = ""
            TxtTen_mau.Text = ""
        End If

    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Txtgia2.Double = TxtGia_nt2.Double
        TxtGia3.Double = TxtGia_nt3.Double
        TxtGia.Double = TxtGia_NT.Double

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
