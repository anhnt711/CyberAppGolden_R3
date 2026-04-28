Public Class DmNgayNghi
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DmNgayNghi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtTu_Ngay.Value = Now.Date
            TxtDen_Ngay.Value = Now.Date
        End If
        Dim DtLoai As New DataTable
        DtLoai.Columns.Add("Ma_Loai")
        DtLoai.Columns.Add("Ten_Loai")
        DtLoai.Columns.Add("Default")

        DtLoai.Rows.Add("1", "Nghỉ cả ngày", "1")
        DtLoai.Rows.Add("2", "Nghỉ buổi sáng", "0")
        DtLoai.Rows.Add("3", "Nghỉ buổi chiều", "0")

        CyberFill.V_FillComBoxDefaul(CmbLoai, DtLoai, "Ma_Loai", "Ten_Loai", "Default")
        End Sub

    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()

    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
    
        Dim _Tu_ngay As Date = TxtTu_Ngay.Value
        Dim _Den_Ngay As Date = TxtDen_Ngay.Value

        Dim DsTmpSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_ChckSaveDMNgayNghi", _Tu_ngay.ToString("yyyyMMdd") + "#" + _Den_Ngay.ToString("yyyyMMdd") + "#" + _
                                                                        CmbLoai.SelectedValue.ToString.Trim)

        If Not CyberSupport.V_MsgChk(DsTmpSave.Tables(0), Me.Sysvar, M_LAN) Then
            DsTmpSave.Dispose()
            Exit Sub
        End If

        TxtSTT.Text = DsTmpSave.Tables(0).Rows(0)("STT").ToString
        DsTmpSave.Dispose()

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
