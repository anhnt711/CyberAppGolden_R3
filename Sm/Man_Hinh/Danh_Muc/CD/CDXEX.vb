Public Class CDXEX
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim So_Dau_Nam As Boolean = True
    Dim Dt_DmStt As DataTable
    Private Sub CDXEX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        'TxtMa_NT.Properties.ReadOnly = True
        'TxtTK.Focus()
        txtTon00.Double = 1
        txtTon00.Enabled = False
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtNam.Text = Me.Key_Nam.ToString
        txtTon00.Text = 1
        'TxtMa_Dvcs.Text = M_Ma_Dvcs
        'If TxtMa_Dvcs.Text.Trim = "" Then TxtTen_Dvcs.Text = "" Else TxtTen_Dvcs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Dvcs", "DmDvcs", "(Ma_Dvcs = N'" + TxtMa_Dvcs.Text.Trim + "')", CyberSmlib)
        If TxtMa_kho.Text.Trim = "" Then TxtTen_kho.Text = "" Else TxtTen_kho.Text = CyberSmodb.SQLGetvalue(Appconn, "ten_kho", "DmKho", "(Ma_kho = N'" + TxtMa_kho.Text.Trim + "')", CyberSmlib)
        'If Not TxtTK.Text.Trim = "" Then TxtMa_NT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ma_NT", "DmTK", "(TK = N'" + TxtTK.Text.Trim + "')", CyberSmlib)
        If TxtTen_vitri.Text.Trim = "" Then TxtTen_vitri.Text = "" Else TxtTen_vitri.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_vitri", "Dmvitri", "(Ma_vitri = N'" + TxtMa_Vitri.Text.Trim + "')", CyberSmlib)
        If TxtTen_kx.Text.Trim = "" Then TxtTen_kx.Text = "" Else TxtTen_kx.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Kx", "DmKx", "(Ma_Kx = N'" + TxtMa_kx.Text.Trim + "')", CyberSmlib)
        If TxtMa_mau.Text.Trim = "" Then TxtTen_mau.Text = "" Else TxtTen_mau.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_mau", "Dmmauxe", "(Ma_mau = N'" + TxtMa_mau.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If Me.Mode = "M" Then TxtNam_Sx.Text = Now.Year
        If TxtMa_Dvcs.Text.Trim = "" Then TxtTen_Dvcs.Text = "" Else TxtTen_Dvcs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Dvcs", "DmDvcs", "(Ma_Dvcs = N'" + TxtMa_Dvcs.Text.Trim + "')", CyberSmlib)

    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--Ma_Kx

        AddHandler TxtMa_kx.CyberValiting, AddressOf V_Ma_kx
        AddHandler TxtMa_kx.CyberLeave, AddressOf L_Ma_kx


        '--Ma_mau

        AddHandler TxtMa_mau.CyberValiting, AddressOf V_Ma_mau
        AddHandler TxtMa_mau.CyberLeave, AddressOf L_Ma_mau
        '--TK

        AddHandler TxtMa_kho.CyberValiting, AddressOf V_Ma_kho
        AddHandler TxtMa_kho.CyberLeave, AddressOf L_MA_Kho
        '---

        AddHandler TxtMa_Vitri.CyberValiting, AddressOf V_MA_Vitri
        AddHandler TxtMa_Vitri.Leave, AddressOf L_Ma_vitri

        AddHandler TxtNam_SX.Leave, AddressOf L_Nam_Sx

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub L_Nam_Sx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtNam_SX.Double <= 0 Then TxtNam_SX.Double = Now.Year
    End Sub
#End Region
#Region "Vali --- KX"
    Private Sub V_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kx", "Dmkx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kx(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kx.Text = DrReturn.Item("Ma_kx")
            TxtTen_kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_kx.Text = ""
            TxtTen_kx.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- mauxe"
    Private Sub V_Ma_mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_mau", "Dmmauxe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_mau(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_mau.Text = DrReturn.Item("Ma_mau")
            TxtTen_mau.Text = DrReturn.Item("Ten_mau")
        Else
            TxtMa_mau.Text = ""
            TxtTen_mau.Text = ""
        End If
    End Sub

#End Region
#Region "Vali --- TK"
    Private Sub V_Ma_kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kho", "Dmkho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_kho.Text = DrReturn.Item("Ma_kho")
            TxtTen_kho.Text = DrReturn.Item("Ten_kho")
        Else
            TxtMa_kho.Text = ""
            TxtTen_kho.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NT"
    Private Sub V_MA_Vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_vitri", "Dmvitri", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vitri(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vitri.Text = DrReturn.Item("Ma_vitri")
            TxtTen_vitri.Text = DrReturn.Item("Ten_vitri")
        Else
            TxtMa_Vitri.Text = ""
            TxtTen_vitri.Text = ""
        End If
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        If TxtSo_khung.Text.Trim = "" Then
            TxtSo_khung.Focus()
            Exit Sub
        End If
        If TxtSo_May.Text.Trim = "" Then
            TxtSo_May.Focus()
            Exit Sub
        End If
        TxtDu00.Double = TxtDu_NT00.Double
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class