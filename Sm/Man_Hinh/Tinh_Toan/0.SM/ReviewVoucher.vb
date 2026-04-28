Public Class ReviewVoucher
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtDmPost, DtDmCt As DataTable
    Dim M_Ma_CT As String = ""
    Dim List_Ma_CT As String = ""
    Dim CyberFrom As New Cyber.From.Sys
    Private Sub ReviewVoucher_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            M_Ma_CT = Me.Para(Me.M_VT_PARA + 2).ToString.Trim
        Catch ex As Exception
        End Try
        Try
            List_Ma_CT = Me.Para(Me.M_VT_PARA + 3).ToString.Trim
        Catch ex As Exception

        End Try
        If List_Ma_CT <> "" Then
            List_Ma_CT = List_Ma_CT.Trim.Replace(" ", "")
        End If
        Me.Save_OK = False
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        TxtM_Ngay_Ct1.Value = Now.Date
        TxtM_Ngay_Ct2.Value = Now.Date
        TxtM_Ngay_Ct1.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtM_Ngay_Ct1)
        TxtM_Ngay_Ct2.Text = CyberSmlib.GetKeyValueRegistryDate(Me.Sysvar, TxtM_Ngay_Ct2)
        Dim _Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_ReviewVoucherLoadDmct", List_Ma_CT & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        DtDmCt = _Dstmp.Tables(0).Copy
        If M_Ma_CT.Trim = "" And DtDmCt.Rows.Count > 0 Then M_Ma_CT = DtDmCt.Rows(0).Item("Ma_Ct").ToString.Trim
        Dim _Chk As Boolean = False
        For i = 0 To DtDmCt.Rows.Count - 1
            If DtDmCt.Rows(i).Item("Ma_Ct").ToString.Trim.ToUpper = M_Ma_CT.Trim.ToUpper Then
                _Chk = True
                '        Exit Sub
            End If
        Next
        If Not _Chk Then
            M_Ma_CT = ""
            If DtDmCt.Rows.Count > 0 Then M_Ma_CT = DtDmCt.Rows(0).Item("Ma_Ct")
        End If
        CyberFill.V_FillComBoxValue(CbbMa_Ct, DtDmCt, "Ma_Ct", If(Me.M_LAN = "V", "ten_Ct", "Ten_Ct2"), M_Ma_CT)
        GetPost(CbbMa_Ct.SelectedValue.ToString.Trim)
    End Sub
    Private Sub CbbMa_Ct_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles CbbMa_Ct.SelectedValueChanged
        GetPost(CbbMa_Ct.SelectedValue.ToString.Trim)
    End Sub
    Private Sub GetPost(ByVal _Ma_CT As String)
        Dim _Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysGetTable", "DMPost#Ma_CT = N'" & _Ma_CT.Trim & "'#ma_Post")
        Dim _Ma_Post As String = ""
        DtDmPost = _Dstmp.Tables(0).Copy
        Dim nCount As Integer = DtDmPost.Rows.Count - 1
        If _Ma_Post.Trim = "" And nCount >= 0 Then _Ma_Post = DtDmPost.Rows(nCount).Item("Ma_Post").ToString.Trim
        CyberFill.V_FillComBoxValue(CbbMa_Post, DtDmPost, "Ma_Post", If(Me.M_LAN = "V", "ten_Post", "Ten_Post2"), _Ma_Post)

    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Save_OK = True
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        V_Nhan(CbbMa_Ct.SelectedValue.ToString, CbbMa_Post.SelectedValue.ToString)
        'Me.Close()
    End Sub
    Private Sub V_Nhan(ByVal _Ma_Ct As String, ByVal _Ma_Post As String)

        If Not CyberLoading.IsShowWaitFrom Then CyberLoading.V_ShowWailtForm(M_LAN)
        Dim _Dt1 As Date = TxtM_Ngay_Ct1.Value
        Dim _Dt2 As Date = TxtM_Ngay_Ct2.Value
        Dim DrDmct As DataRow = CyberSmodb.SQLGetRow(AppConn, "DMCT", "Ma_CT =N'" + _Ma_Ct.Trim + "'", CyberSmlib)
        Dim M_DsHead As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_HeadVoucher", _Ma_Ct.Trim + "#" + M_User_Name)
        Dim M_strFilter As String = "0###" & "" & "#" & _Dt1.ToString("yyyyMMdd") & "#" & _Dt2.ToString("yyyyMMdd") & "#0#" & _Ma_Post & "#" & _Ma_Ct.Trim & "#" & M_Ma_Dvcs & "#" & M_User_Name
        Dim M_DsData As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Filter" + _Ma_Ct.Trim, M_strFilter)
        For i As Integer = 0 To M_DsData.Tables.Count - 1
            CyberSmodb.SetNotNullTable(M_DsData.Tables(i))
        Next
        Dim M_DsLooKup As New DataSet
        '------------------------------------------------------------------------------------
        '---Head
        '------------------------------------------------------------------------------------
        CyberFrom.V_ViewVoucher(AppConn, Me.Sysvar, M_LAN, Me.Para, DrDmct, M_DsData, M_DsHead, M_DsLooKup, Nothing, Nothing, "", M_strFilter, CyberFill, CyberSmlib, CyberSupport, True, True)
        '------------------------------------------------------------------------------------
        If CyberLoading.IsShowWaitFrom Then CyberLoading.V_CloseWailtForm()
        ''------------------------------------------------------------------------------------

    End Sub

End Class
