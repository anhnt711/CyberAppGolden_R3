Public Class DMKU
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMKU_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        CreateTabe()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Cyber.ListGroupGL.Sys.SetAutoCode(Appconn, Me.Tb_Name, Me.Mode, CyberSmlib, CyberSmodb, TxtMa_KU, TxtNh_KU1, TxtNh_KU2, TxtNh_KU3, TxtNh_KU4, TxtNh_KU5)
        TxtMa_KU.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        If TxtNh_KU1.Text.Trim = "" Then TxtTen_Nh1.Text = "" Else TxtTen_Nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKU", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_KU1.Text.Trim + "')", CyberSmlib)
        If TxtNh_KU2.Text.Trim = "" Then TxtTen_Nh2.Text = "" Else TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKU", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_KU2.Text.Trim + "')", CyberSmlib)
        If TxtNh_KU3.Text.Trim = "" Then TxtTen_Nh3.Text = "" Else TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKU", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_KU3.Text.Trim + "')", CyberSmlib)
        If TxtNh_KU4.Text.Trim = "" Then TxtTen_Nh4.Text = "" Else TxtTen_Nh4.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKU", "(Loai_Nh = '4' AND Ma_Nh = N'" + TxtNh_KU4.Text.Trim + "')", CyberSmlib)
        If TxtNh_KU5.Text.Trim = "" Then TxtTen_Nh5.Text = "" Else TxtTen_Nh5.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhKU", "(Loai_Nh = '5' AND Ma_Nh = N'" + TxtNh_KU5.Text.Trim + "')", CyberSmlib)


        If TxtMa_KH.Text.Trim.Trim = "" Then TxtTen_KH.Text = "" Else TxtTen_KH.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kh", "Dmkh", "(Ma_kh = N'" + TxtMa_KH.Text.Trim + "')", CyberSmlib)
        If CmbLoai_LS.Text.Trim = "" Then CmbLoai_LS.SelectedValue = "1"
        If CmbKy_Tra.Text.Trim = "" Then CmbKy_Tra.SelectedValue = "1"
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_KU.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_KU.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Ma_kh
        RemoveHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_Kh
        RemoveHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_Kh
        AddHandler TxtMa_KH.CyberValiting, AddressOf V_Ma_Kh
        AddHandler TxtMa_KH.CyberLeave, AddressOf L_Ma_Kh

        '--Ma_kh
        RemoveHandler TxtMa_NT.CyberValiting, AddressOf V_Ma_NT
        RemoveHandler TxtMa_NT.CyberLeave, AddressOf L_Ma_NT
        AddHandler TxtMa_NT.CyberValiting, AddressOf V_Ma_NT
        AddHandler TxtMa_NT.CyberLeave, AddressOf L_Ma_NT

        '--KU1
        RemoveHandler TxtNh_KU1.CyberValiting, AddressOf V_NH_KU1
        RemoveHandler TxtNh_KU1.CyberLeave, AddressOf L_NH_KU1
        AddHandler TxtNh_KU1.CyberValiting, AddressOf V_NH_KU1
        AddHandler TxtNh_KU1.CyberLeave, AddressOf L_NH_KU1
        '--KU2
        RemoveHandler TxtNh_KU2.CyberValiting, AddressOf V_NH_KU2
        RemoveHandler TxtNh_KU2.CyberLeave, AddressOf L_NH_KU2
        AddHandler TxtNh_KU2.CyberValiting, AddressOf V_NH_KU2
        AddHandler TxtNh_KU2.CyberLeave, AddressOf L_NH_KU2
        '--KU3
        RemoveHandler TxtNh_KU3.CyberValiting, AddressOf V_NH_KU3
        RemoveHandler TxtNh_KU3.CyberLeave, AddressOf L_NH_KU3
        AddHandler TxtNh_KU3.CyberValiting, AddressOf V_NH_KU3
        AddHandler TxtNh_KU3.CyberLeave, AddressOf L_NH_KU3
        '--KU4
        RemoveHandler TxtNh_KU4.CyberValiting, AddressOf V_NH_KU4
        RemoveHandler TxtNh_KU4.CyberLeave, AddressOf L_NH_KU4
        AddHandler TxtNh_KU4.CyberValiting, AddressOf V_NH_KU4
        AddHandler TxtNh_KU4.CyberLeave, AddressOf L_NH_KU4
        '--KU5
        RemoveHandler TxtNh_KU5.CyberValiting, AddressOf V_NH_KU5
        RemoveHandler TxtNh_KU5.CyberLeave, AddressOf L_NH_KU5
        AddHandler TxtNh_KU5.CyberValiting, AddressOf V_NH_KU5
        AddHandler TxtNh_KU5.CyberLeave, AddressOf L_NH_KU5
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub CreateTabe()
        Dim DtLoai_Ls As New DataTable
        Dim DtKy_Tra As New DataTable

        DtLoai_Ls.Columns.Add("Loai_Ls", GetType(String))
        DtLoai_Ls.Columns.Add("Ten", GetType(String))
        DtLoai_Ls.Columns.Add("Default", GetType(String))
        DtLoai_Ls.Rows.Add("1", IIf(M_LAN = "V", "Lãi suất theo năm", "Yearly interest rate"), "1")
        DtLoai_Ls.Rows.Add("2", IIf(M_LAN = "V", "Lãi suất theo quý", "Quarterly interest rates"), "0")
        DtLoai_Ls.Rows.Add("3", IIf(M_LAN = "V", "Lãi suất theo tháng", "Monthly interest rate"), "0")
        DtLoai_Ls.Rows.Add("4", IIf(M_LAN = "V", "Lãi suất theo tuần", "Weekly interest rate"), "0")
        CyberFill.V_FillComBoxDefaul(Me.CmbLoai_LS, DtLoai_Ls, "Loai_Ls", "Ten")

        DtKy_Tra.Columns.Add("Ky_Tra", GetType(String))
        DtKy_Tra.Columns.Add("Ten", GetType(String))
        DtKy_Tra.Columns.Add("Default", GetType(String))
        DtKy_Tra.Rows.Add("1", IIf(M_LAN = "V", "Trả gốc và Lãi theo năm", "Pay principal and interest by year"), "1")
        DtKy_Tra.Rows.Add("2", IIf(M_LAN = "V", "Trả gốc và Lãi theo quý", "Pay principal and interest quarterly"), "0")
        DtKy_Tra.Rows.Add("3", IIf(M_LAN = "V", "Trả gốc và Lãi theo tháng", "Pay principal and interest by month"), "0")
        DtKy_Tra.Rows.Add("4", IIf(M_LAN = "V", "Trả gốc và Lãi theo tuần", "Pay principal and interest by week"), "0")
        CyberFill.V_FillComBoxDefaul(Me.CmbKy_Tra, DtKy_Tra, "Ky_Tra", "Ten")

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Kh"
    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_KH.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kh", "Dmkh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_KH.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KH.Text = DrReturn.Item("Ma_Kh")
            TxtTen_KH.Text = DrReturn.Item("Ten_Kh")
        Else
            TxtMa_KH.Text = ""
            TxtTen_KH.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_NT"
    Private Sub V_Ma_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_NT.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NT", "DmNT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_NT.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_NT.Text = DrReturn.Item("Ma_NT")
            'TxtTen_NT.Text = DrReturn.Item("Ten_NT")
        Else
            TxtMa_NT.Text = ""
            'TxtTen_NT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KU1"
    Private Sub V_NH_KU1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KU1.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKU", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_KU1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KU1.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KU1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KU1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KU2"
    Private Sub V_NH_KU2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KU2.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKU", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_NH_KU2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KU2.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KU2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KU2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KU3"
    Private Sub V_NH_KU3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KU3.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKU", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_NH_KU3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KU3.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KU3.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KU3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KU4"
    Private Sub V_NH_KU4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KU4.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKU", "1=1", "Loai_Nh='4'")
    End Sub
    Private Sub L_NH_KU4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KU4.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KU4.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh4.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KU4.Text = ""
            TxtTen_Nh4.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- NH_KU5"
    Private Sub V_NH_KU5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNh_KU5.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhKU", "1=1", "Loai_Nh='5'")
    End Sub
    Private Sub L_NH_KU5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtNh_KU5.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_KU5.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh5.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_KU5.Text = ""
            TxtTen_Nh5.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_KU.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

 
End Class
