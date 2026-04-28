
Public Class COGTSPDD
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private TbTP, TbQuan, TbXa, DtNam As New DataTable
    Private _Load_TP As Boolean = False
    Private Sub FDMKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CmbThang, DtNam, "Thang", IIf(M_LAN = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        _Load_TP = False
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        _Load_TP = True
        CmbThang.Enabled = False
    End Sub
#Region "Load"
    Private Function CreateTableYear() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Thang")
        _Return.Columns.Add("Ten_Thang")
        _Return.Columns.Add("Ten_Thang2")
        _Return.Columns.Add("Default")
        Dim _Thang As String = ""
        Dim _Default As String = "0"
        For i As Integer = 0 To 12
            _Thang = IIf(i < 12, i + 1, i)
            If Now.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(i, IIf(i < 12, "Đầu " & _Thang, "Cuối " & _Thang), IIf(i < 12, "Begin " & _Thang, "End " & _Thang), _Default)
        Next
        CreateTableYear = _Return
    End Function
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtNam.Text = Me.Key_Nam.ToString
        TxtTen_Vt.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_vt", "DMVT", "( Ma_vt = N'" + TxtMa_vt.Text.Trim + "')", CyberSmlib)
        TxtTen_Vv.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_VV", "DMvv", "( Ma_VV = N'" + TxtMa_Vv.Text.Trim + "')", CyberSmlib)
        TxtTen_HD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_HD", "DMHD", "( Ma_HD = N'" + TxtMa_HD.Text.Trim + "')", CyberSmlib)
        TxtTen_tk.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TK0", "DMtk0", "( tk0 = N'" + TxtTk.Text.Trim + "')", CyberSmlib)
        TxtTen_TK0.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TK0", "DMTK0", "( TK0 = N'" + TxtTK_CP.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNam.Text = Key_Nam
            Try
                CmbThang.SelectedValue = Key_Sub1
            Catch ex As Exception
            End Try
        End If
    End Sub

    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        AddHandler TxtMa_vt.CyberValiting, AddressOf V_Ma_Vt
        AddHandler TxtMa_vt.CyberLeave, AddressOf L_Ma_Vt

        AddHandler TxtTk.CyberValiting, AddressOf V_TK
        AddHandler TxtTk.CyberLeave, AddressOf L_TK

        AddHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_vv
        AddHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_VV

        AddHandler TxtMa_HD.CyberValiting, AddressOf V_Ma_HD
        AddHandler TxtMa_HD.CyberLeave, AddressOf L_Ma_HD

        AddHandler TxtTK_CP.CyberValiting, AddressOf V_TK_CP
        AddHandler TxtTK_CP.CyberLeave, AddressOf L_TK_CP
    End Sub
#End Region
#Region "Valid"
#End Region
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#Region "Valid"

    Private Sub V_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_VT", "DMVT", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt.Text = DrReturn.Item("Ma_VT")
            TxtTen_Vt.Text = DrReturn.Item("Ten_VT")
        Else
            TxtMa_vt.Text = ""
            TxtTen_Vt.Text = ""
        End If
    End Sub

#End Region
#Region "Valid"




    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK0", "DMTK0", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("TK0")
            TxtTen_tk.Text = DrReturn.Item("Ten_tk0")
        Else
            TxtTk.Text = ""
            TxtTen_tk.Text = ""
        End If
    End Sub

    Private Sub V_Ma_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HD", "DMHD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_HD.Text = DrReturn.Item("Ma_HD")
            TxtTen_HD.Text = DrReturn.Item("Ten_HD")
        Else
            TxtMa_Vv.Text = ""
            TxtTen_Vv.Text = ""
        End If
    End Sub
    Private Sub V_Ma_vv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_vv", "DMvv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_VV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vv.Text = DrReturn.Item("Ma_vv")
            TxtTen_Vv.Text = DrReturn.Item("Ten_vv")
        Else
            TxtMa_Vv.Text = ""
            TxtTen_Vv.Text = ""
        End If
    End Sub

#End Region
#Region "Valid"

    Private Sub V_TK_CP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK0", "DMTK0", "1=1", "1=1")
    End Sub
    Private Sub L_TK_CP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK_CP.Text = DrReturn.Item("TK0")
            TxtTen_TK0.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtMa_HD.Text = ""
            TxtTen_HD.Text = ""
        End If
    End Sub

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
