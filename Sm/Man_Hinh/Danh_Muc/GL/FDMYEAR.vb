Public Class FDMYEAR
    Dim DtNam As DataTable
    Private Sub FYEAR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CmbMonth, DtNam, "Thang", IIf(M_LAN = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        V_Load()
        TxtM_Nam.Text = Now.Year.ToString.Trim
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtM_Nam.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
    End Sub
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
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
#End Region
#Region "Valid"
#End Region
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Filter_View = " (a.Nam ='" & Me.TxtM_Nam.Double & "' AND a.Thang='" & CmbMonth.SelectedValue & "') "
        Me.Key_Nam = Me.TxtM_Nam.Text.Trim.Replace(" ", "").Replace(",", ".").Trim
        Me.Key_Sub1 = CmbMonth.SelectedValue
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs) ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
End Class