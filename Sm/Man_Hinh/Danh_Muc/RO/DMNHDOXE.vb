Public Class DMNHDOXE
    Dim DrReturn As DataRow '  DataRowView
    Dim DtrReturn As DataRow
    Dim Ds As New DataSet
    Dim DsLookup As New DataSet
    '----------------------------------------------------------------------
    Dim DtGroup As DataTable
    Dim Dt_CapNhom As DataTable
    Dim Dv_CapNhom As DataView
    '----------------------------------------------------------------------
    Dim _Loai_NhOld As String = ""
    Dim _ma_NhOld As String = ""
    'Dim CyberSmlistSys As New Sys
    Private Sub DMNHVT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_LoadLoaiNhom()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        If Not Me.DrOld Is Nothing Then
            _Loai_NhOld = Me.DrOld.Item("Loai_Nh")
            _ma_NhOld = Me.DrOld.Item("Ma_nh")
        Else
            _Loai_NhOld = ""
            _ma_NhOld = ""
        End If
        If Me.Mode = "S" Then
            _Loai_NhOld = CmbLoai_Nh.SelectedValue.ToString.Trim
            _ma_NhOld = Txtma_nh.Text.Trim
        Else
            TxtMa_Dvcs.Text = M_Ma_Dvcs
        End If
        GetTbCapNhom()
        CmbLoai_Nh.Select()

    End Sub
    Private Sub GetTbCapNhom()
        Dim _Loai_NhNew = "", _Ma_nhNew As String = ""
        Dim DsTmp As New DataSet
        If CmbLoai_Nh.Text = "" Then CmbLoai_Nh.SelectedIndex = 0
        _Loai_NhNew = CmbLoai_Nh.SelectedValue.ToString.Trim
        _Ma_nhNew = Txtma_nh.Text.Trim

        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysGetNhom", Me.Mode.Trim + "#" + _Loai_NhOld + "#" + _Loai_NhNew + "#" + _ma_NhOld + "#" + _Ma_nhNew + "#" + Me.Tb_Name.Trim.ToString + "#" + Me.TxtMa_Dvcs.Text.ToString + "#" + M_User_Name)
        Dt_CapNhom = DsTmp.Tables(0).Copy
        Dv_CapNhom = New DataView(Dt_CapNhom)

        ChkListBox.DataSource = Dv_CapNhom
        ChkListBox.DisplayMember = Dt_CapNhom.Columns("Ten_nh").ColumnName
        ChkListBox.ValueMember = Dt_CapNhom.Columns("Ma_Nh").ColumnName

        For iRow As Integer = 0 To Dv_CapNhom.Count - 1
            If Dv_CapNhom.Item(iRow).Item("Tag").ToString.ToUpper.Trim = "TRUE".ToString.ToUpper.Trim Or Dv_CapNhom.Item(iRow).Item("Tag").ToString.ToUpper.Trim = "1" Then
                ChkListBox.SetItemChecked(iRow, True)
            End If
        Next
    End Sub
#Region "Load"
    Private Sub V_LoadLoaiNhom()
        Dim DsTmp As New DataSet
        DsTmp = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysListGetDmNhom", Me.Tb_Name.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        DtGroup = DsTmp.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(CmbLoai_Nh, DtGroup, "Loai_nh", IIf(M_LAN = "V", "Ten_Loai", "Ten_Loai2"), "Default")



    End Sub
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

     
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        AddHandler CmbLoai_Nh.SelectedIndexChanged, AddressOf V_Loai_Nh
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Nhom"
    Private Sub V_Loai_Nh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        GetTbCapNhom()
    End Sub
    Private Sub V_SaveSysNhom()
        If Me.Mode = "S" Then
            Dim sKey As String = "(Tb_name = N'" + Me.Tb_Name.Trim + "') AND (Loai_Nh = N'" + _Loai_NhOld.Trim + "') AND (Ma_Nh = N'" + _ma_NhOld.Trim + "')"
            CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysDeleteTabel", "SysNhom".Trim + "#" + sKey + "#" + M_User_Name)
        End If
        Dim DrV As DataRowView
        Dim _Ma_Nh As String = Txtma_nh.Text.Trim
        Dim _Loai_nh As String = CmbLoai_Nh.SelectedValue.ToString.Trim
        Dim strField As String = "", strValue As String = ""

        For Each _Chk As Object In ChkListBox.CheckedItems
            DrV = _Chk
            strField = ""
            strValue = ""
            CyberSmodb.GetValueData(DrV, strField, strValue)
            CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysSaveNhom", strField + "#" + strValue + "#" + _Loai_nh + "#" + _Ma_Nh + "#" + Me.Tb_Name.Trim + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Next
    End Sub
#End Region

#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        Dim DsGenCode As New DataSet
        DsGenCode = V_GetCode(Mode, M_Ma_Dvcs, M_User_Name)
        If Not DsGenCode Is Nothing Then Txtma_nh.Text = DsGenCode.Tables(0).Rows(0).Item("Value").ToString.Trim
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        V_SaveSysNhom()
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class