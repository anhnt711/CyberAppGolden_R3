Public Class DMTK0
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMTK0_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        '------------------------------------------------------------------------------------
        ChkRO.Visible = False
        Try
            Dim M_VT_PARA As Integer = CType(M_Para(0).Trim, Integer)
            If M_Para(M_Para.Length - 1).Trim = "1" Then ChkRO.Visible = True
        Catch ex As Exception
        End Try
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        CyberSupport.Translaste(Me, M_LAN, True)
        'TxtTk0.Focus()
        '------------------------------------------------------------------------------------
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_NT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_NT", "DmNT", "(Ma_NT =N'" + TxtMa_NT.Text.Trim + "')", CyberSmlib)
        TxtTen_Tk_Me.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 =N'" + TxtTk_Me.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander() '// khong xoa doan nay

        RemoveHandler TxtTk0.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtTk0.KeyPress, AddressOf TxtCodeError_KeyPress
        '--Ma_Nt
        RemoveHandler TxtMa_NT.CyberValiting, AddressOf V_Ma_Nt
        RemoveHandler TxtMa_NT.CyberLeave, AddressOf L_Ma_NT

        AddHandler TxtMa_NT.CyberValiting, AddressOf V_Ma_Nt
        AddHandler TxtMa_NT.CyberLeave, AddressOf L_Ma_NT
        '--TK_Me
        RemoveHandler TxtTk_Me.CyberValiting, AddressOf V_Tk_Me
        RemoveHandler TxtTk_Me.CyberLeave, AddressOf L_Tk_Me

        AddHandler TxtTk_Me.CyberValiting, AddressOf V_Tk_Me
        AddHandler TxtTk_Me.CyberLeave, AddressOf L_Tk_Me
        '--------------------------------------------------------------------------------
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_NT"
    Private Sub V_Ma_Nt(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_NT", "DmNt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_NT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_NT.Text = DrReturn.Item("Ma_NT")
            TxtTen_NT.Text = DrReturn.Item("Ten_NT")
        Else
            TxtMa_NT.Text = ""
            TxtTen_NT.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TK_me"
    Private Sub V_Tk_Me(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk_Me.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk0", "Dmtk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_Me(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk_Me.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk_Me.Text = DrReturn.Item("Tk0")
            TxtTen_Tk_Me.Text = DrReturn.Item("Ten_Tk0")
        Else
            TxtTk_Me.Text = ""
            TxtTen_Tk_Me.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Bac_TK"
    Private Sub V_Bac_Loai_TK(ByVal tk0 As String, ByVal tk_me As String)
        Dim dstmp As New DataSet
        dstmp = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "GetBac_Loai_TK", TxtTk0.Text.Trim + "#" + tk_me.Trim)
        Me.TxtLoai_Tk.Text = dstmp.Tables(0).Rows(0).Item("Loai_Tk")
        Me.Txtbac_Tk.Text = dstmp.Tables(0).Rows(0).Item("bac_Tk")
        Me.TxtLoai_Tk.Refresh()
        Me.Txtbac_Tk.Refresh()
        dstmp.Dispose()
    End Sub
    Function V_ChkTkMe() As Boolean
        Dim dstmp As New DataSet
        Dim _Return As Boolean = True
        dstmp = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_ChkTkMe", TxtTk0.Text.Trim + "#" + Me.DrOld.Item("Tk0").Trim + "#" + TxtTk_Me.Text.Trim + "#" + Me.Mode.Trim + "#" + M_User_Name)
        _Return = CyberSupport.V_MsgChk(dstmp.Tables(0), oSysvar)
        dstmp.Dispose()
        V_ChkTkMe = _Return
    End Function
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi luu du lieu vao truong trinh viet vao day
        TxtTk011.Text = TxtTk0.Text
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not V_ChkTkMe() Then Exit Sub
        V_Bac_Loai_TK(TxtTk0.Text.Trim, TxtTk_Me.Text.Trim)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class