Public Class DMVE
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa As DataTable
    Private _Load_TP As Boolean = False
    Private Sub FDMKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _Load_TP = False
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_nh1.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVe", "(Loai_Nh = '1' AND Ma_Nh = N'" + TxtNh_ve1.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh2.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVe", "(Loai_Nh = '2' AND Ma_Nh = N'" + TxtNh_ve2.Text.Trim + "')", CyberSmlib)
        TxtTen_Nh3.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nh", "DmNhVe", "(Loai_Nh = '3' AND Ma_Nh = N'" + TxtNh_ve3.Text.Trim + "')", CyberSmlib)
        TxtTen_tuyen.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_tuyen", "Dmtuyen", "(Ma_tuyen = N'" + TxtMa_tuyen.Text.Trim + "')", CyberSmlib)
        TxtTen_kho.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_kho", "Dmkho", "( Ma_kho = N'" + Txtma_kho.Text.Trim + "')", CyberSmlib)
        TxtTen_chang.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_chang", "Dmchang", "( Ma_chang = N'" + TxtMa_Chang.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        AddHandler TxtNh_ve1.CyberValiting, AddressOf V_NH_VE1
        AddHandler TxtNh_ve1.CyberLeave, AddressOf L_NH_VE1
        '--Ten_KH

        AddHandler TxtNh_ve2.CyberValiting, AddressOf V_Nh_ve2
        AddHandler TxtNh_ve2.CyberLeave, AddressOf L_Nh_ve2

        AddHandler TxtNh_ve3.CyberValiting, AddressOf V_Nh_ve3
        AddHandler TxtNh_ve3.CyberLeave, AddressOf L_Nh_ve3

        AddHandler TxtMa_tuyen.CyberValiting, AddressOf V_Ma_tuyen
        AddHandler TxtMa_tuyen.CyberLeave, AddressOf L_Ma_Tuyen

        AddHandler Txtma_kho.CyberValiting, AddressOf V_Ma_kho
        AddHandler Txtma_kho.CyberLeave, AddressOf L_Ma_kho

        AddHandler TxtMa_Chang.CyberValiting, AddressOf V_Ma_chang
        AddHandler TxtMa_Chang.CyberLeave, AddressOf L_Ma_Chang


    End Sub
#End Region
#Region "Valid --- Nh_ve1"
    Private Sub V_NH_VE1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_NH", "DmNhve", "1=1", "Loai_Nh='1'")
    End Sub
    Private Sub L_NH_VE1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ve1.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh1.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ve1.Text = ""
            TxtTen_Nh1.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_ve2"
    Private Sub V_Nh_ve2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhve", "1=1", "Loai_Nh='2'")
    End Sub
    Private Sub L_Nh_ve2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ve2.Text = DrReturn.Item("Ma_Nh")
            TxtTen_Nh2.Text = DrReturn.Item("Ten_Nh")
        Else
            TxtNh_ve2.Text = ""
            TxtTen_Nh2.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Nh_ve3"
    Private Sub V_Nh_ve3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhve", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Nh_ve3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtNh_ve3.Text = DrReturn.Item("Ma_Nh").ToString().Trim()
            TxtTen_Nh3.Text = DrReturn.Item("Ten_Nh").ToString().Trim()
        Else
            TxtNh_ve3.Text = ""
            TxtTen_Nh3.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- ma_tuyen"
    Private Sub V_Ma_tuyen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Tuyen", "DmTuyen", "1=1", "1=1")
        'sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Tuyen", "DmTuyen ", "1=1", "1=1")
        'sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Nh", "DmNhve", "1=1", "Loai_Nh='3'")
    End Sub
    Private Sub L_Ma_Tuyen(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_tuyen.Text = DrReturn.Item("Ma_Tuyen").ToString().Trim()
            TxtTen_tuyen.Text = DrReturn.Item("Ten_tuyen").ToString().Trim()
        Else
            TxtMa_tuyen.Text = ""
            TxtTen_tuyen.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- ma_kho"
    Private Sub V_Ma_kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_kho", "dmKho", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_kho(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            Txtma_kho.Text = DrReturn.Item("Ma_kho").ToString().Trim()
            TxtTen_kho.Text = DrReturn.Item("Ten_kho").ToString().Trim()
        Else
            Txtma_kho.Text = ""
            TxtTen_kho.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_Chang"
    Private Sub V_Ma_chang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_chang", "Dmchang", "1=1", "1=1")
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_chang", "Dmchang", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Chang(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Chang.Text = DrReturn.Item("Ma_chang").ToString().Trim()
            TxtTen_chang.Text = DrReturn.Item("Ten_chang").ToString().Trim()
        Else
            TxtMa_Chang.Text = ""
            TxtTen_chang.Text = ""

        End If
    End Sub
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_ve.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
