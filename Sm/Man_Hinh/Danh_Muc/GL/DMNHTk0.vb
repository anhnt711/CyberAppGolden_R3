Public Class DMNHTk0
    Dim DrReturn As DataRowView
    Dim DtrReturn As DataRow
    Dim Ds As New DataSet
    '----------------------------------------------------------------------
    Dim DtGroup As DataTable
    Dim Dt_CapNhom As DataTable
    Dim Dv_CapNhom As DataView
    '----------------------------------------------------------------------
    Dim _Loai_NhOld As String = ""
    Dim _ma_NhOld As String = ""
    Private Sub FDMNHOM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

        If Not Me.DrOld Is Nothing Then _ma_NhOld = Me.DrOld.Item("Ma_nh")
        If Me.Mode = "S" Then _ma_NhOld = Txtma_nh.Text.Trim
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class