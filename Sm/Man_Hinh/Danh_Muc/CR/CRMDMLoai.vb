Imports System.Data.SqlClient
Public Class CRMDMLoai
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim _DtPhanHe As DataTable
    Dim _DtLoai As DataTable
    Private Sub CRMDMLoai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        _DtPhanHe = CreateTablePhanHe()
        _DtLoai = CreateTableLoai()
        CyberFill.V_FillComBoxValue(CmbMa_Phan_He, _DtPhanHe, "Ma", "Ten", "Ngam_Dinh")
        CyberFill.V_FillComBoxValue(CmbCrmLoai, _DtLoai, "Ma", "Ten", "Ngam_Dinh")
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtCrmMa_Loai.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Private Function CreateTablePhanHe() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Ma")
        _Return.Columns.Add("Ten")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("RO", "Đánh giá khách hàng sửa chữa", "1")
        _Return.Rows.Add("BE", "Đánh giá khách hàng bán xe", "0")
        CreateTablePhanHe = _Return
    End Function
    Private Function CreateTableLoai() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Ma")
        _Return.Columns.Add("Ten")
        _Return.Columns.Add("Ngam_Dinh")
        _Return.Rows.Add("CS", "CS", "1")
        _Return.Rows.Add("CR", "CR", "0")
        _Return.Rows.Add("CD", "CD", "0")
        CreateTableLoai = _Return
    End Function
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        If Me.Mode = "M" Then
            CmbMa_Phan_He.SelectedIndex = 0
            CmbCrmLoai.SelectedIndex = 0
        End If
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtCrmMa_Loai.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtCrmMa_Loai.KeyPress, AddressOf TxtCodeError_KeyPress

        '--BP2
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtCrmMa_Loai.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
