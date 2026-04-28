Public Class ConvertNextYear

    Private Sub ConvertNextYear_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Dim tbYear As New DataTable
        ' Create four typed columns in the DataTable.
        tbYear.Columns.Add("Nam", GetType(String))
        tbYear.Columns.Add("Ten_Nam", GetType(String))
        tbYear.Columns.Add("Ngam_Dinh", GetType(String))
        Dim _Year As String = Now.Year.ToString.Trim
        Dim _Ngam_Dinh As String = "0"
        For i As Integer = _Year - 10 To _Year + 5
            If i = _Year + 1 Then _Ngam_Dinh = "1" Else _Ngam_Dinh = "0"
            tbYear.Rows.Add(i.ToString.Trim, IIf(Me.Lan = "V", "Năm " + i.ToString.Trim, "Year " + i.ToString.Trim), _Ngam_Dinh)
        Next
        CyberFill.V_FillComBoxDefaul(CbbYear, tbYear, "Nam", "Ten_Nam", "Ngam_Dinh")
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True

        Me.Tag = CbbYear.SelectedValue.ToString.Trim
        Dim M_strParameterStore As String = CbbYear.SelectedValue.ToString.Trim
        M_strParameterStore = M_strParameterStore & "#" & M_Ma_Dvcs
        M_strParameterStore = M_strParameterStore & "#" & M_User_Name
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
End Class
