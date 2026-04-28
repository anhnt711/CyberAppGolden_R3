Public Class DMHMCN
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMHMCN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_Kh.Focus()
        TxtMa_Dvcs.Enabled = False
        TxtTen_Dvcs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Dvcs", "DmDvcs", "(Ma_Dvcs = N'" + TxtMa_Dvcs.Text.Trim + "')", CyberSmlib)
        V_Is_End(New System.Object, New System.EventArgs)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNgay_CT1.Value = Now.Date
            TxtNgay_CT2.Value = Now.Date
        End If
        If Me.Mode = "S" Then
            TxtNgay_CT1.Enabled = True
            TxtMa_Kh.Enabled = True
        End If
        TxtTen_Kh.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kh", "DmKH", "(Ma_Kh = N'" + TxtMa_Kh.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '-Ma_KH
        AddHandler TxtMa_Kh.CyberValiting, AddressOf V_Ma_kh
        AddHandler TxtMa_Kh.CyberLeave, AddressOf L_Ma_kh

        RemoveHandler TxtMa_Kh.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Kh.KeyPress, AddressOf TxtCodeError_KeyPress

        RemoveHandler ChkIs_End.CheckedChanged, AddressOf V_Is_End
        AddHandler ChkIs_End.CheckedChanged, AddressOf V_Is_End
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Vali --- Ma_kh"
    Private Sub V_Ma_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Kh.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kh", "Dmkh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Kh.Text = "" Then
            TxtTen_Kh.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kh.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kh.Text = DrReturn.Item("Ma_kh")
            TxtTen_Kh.Text = DrReturn.Item("Ten_kh")
        Else
            TxtMa_Kh.Text = ""
            TxtTen_Kh.Text = ""
        End If
    End Sub
#End Region
    Private Sub V_Is_End(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        If ChkIs_End.Checked = True Then
            TxtNgay_CT2.Focus()
            TxtNgay_CT2.Enabled = True
            LabNgay_Ct2.Enabled = True
        Else
            TxtNgay_CT2.Enabled = False
            LabNgay_Ct2.Enabled = False
        End If
    End Sub
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
