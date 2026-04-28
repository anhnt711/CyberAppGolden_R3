Public Class Ph89CVDV_Clock_CVDVKhoangToKTV
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim tbmau As DataTable
    Dim CyberColor As New Cyber.Color.Sys

    Private Sub Ph89CVDV_Clock_KhoangToKTV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        CreateTabe()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        Txtma.Focus()
    End Sub

#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtTu_ngay.Value = Now
            Txtden_ngay.Value = Now
        End If

        If Mode.Trim = "S" Then CmbLoai.Enabled = False Else CmbLoai.Enabled = True
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        If Txtma.Text.Trim = "" Then Txtten.Text = ""

        Dim _Loai As String = CmbLoai.SelectedValue.ToString

        Select Case _Loai.ToString.ToUpper.Trim
            Case "KHOANG"
                Txtten.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_khoang", "DmKhoang", "( Ma_khoang = N'" + Txtma.Text.Trim + "')", CyberSmlib)
            Case "CVDV"
                Txtten.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_HS", "DmHs", "( Ma_HS = N'" + Txtma.Text.Trim + "')", CyberSmlib)
            Case "TO"
                Txtten.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_to", "DmToSC", "( Ma_to = N'" + Txtma.Text.Trim + "')", CyberSmlib)
            Case "KTV"
                Txtten.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_HS", "DmKTVSC", "( Ma_HS = N'" + Txtma.Text.Trim + "')", CyberSmlib)
        End Select
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler Txtma.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler Txtma.KeyPress, AddressOf TxtCodeError_KeyPress
        ''--ma
        RemoveHandler Txtma.CyberValiting, AddressOf V_ma
        RemoveHandler Txtma.CyberLeave, AddressOf L_ma
        AddHandler Txtma.CyberValiting, AddressOf V_ma
        AddHandler Txtma.CyberLeave, AddressOf L_ma
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Private Sub CreateTabe()
        Dim DtLoai As New DataTable

        DtLoai.Columns.Add("Loai", GetType(String))
        DtLoai.Columns.Add("Ten", GetType(String))
        DtLoai.Columns.Add("Ten2", GetType(String))
        DtLoai.Columns.Add("Ngam_Dinh", GetType(String))

        DtLoai.Rows.Add("KHOANG", "Khoang", "Khoang", "1")
        DtLoai.Rows.Add("CVDV", "Cố vấn dịch vụ", "Cố vấn dịch vụ", "0")
        DtLoai.Rows.Add("TO", "Tổ", "Tổ", "0")
        DtLoai.Rows.Add("KTV", "Kỹ thuật viên", "Kỹ thuật viên", "0")

        CyberFill.V_FillComBoxDefaul(Me.CmbLoai, DtLoai, "Loai", "Ten", "Ngam_Dinh")
        '---
    End Sub
  
#End Region
#Region "Vali --- ma"
    Private Sub V_ma(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Loai As String = CmbLoai.SelectedValue.ToString
        Select Case _Loai.ToString.ToUpper.Trim
            Case "KHOANG"
                Txtma.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_khoang", "DMKhoang", "1=1", "1=1")
            Case "CVDV"
                Txtma.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HS", "DMHS", "1=1", "1=1")
            Case "TO"
                Txtma.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_to", "DMToSC", "1=1", "1=1")
            Case "KTV"
                Txtma.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HS", "DMKTVSC", "1=1", "1=1")
        End Select

    End Sub
    Private Sub L_ma(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Txtma.Text = "" Then
            Txtten.Text = ""
            Exit Sub
        End If
        DrReturn = Txtma.GetRowsSelectData(True)
        Dim _Loai As String = CmbLoai.SelectedValue.ToString
        If Not DrReturn Is Nothing Then
            Select Case _Loai.ToString.ToUpper.Trim
                Case "KHOANG"
                    If CmbLoai.SelectedValue = "KHOANG" Then
                        Txtma.Text = DrReturn.Item("Ma_khoang")
                        Txtten.Text = DrReturn.Item("Ten_khoang")
                    End If
                Case "CVDV"
                    Txtma.Text = DrReturn.Item("Ma_HS")
                    Txtten.Text = DrReturn.Item("Ten_HS")
                Case "TO"
                    Txtma.Text = DrReturn.Item("Ma_to")
                    Txtten.Text = DrReturn.Item("Ten_to")
                Case "KTV"
                    Txtma.Text = DrReturn.Item("Ma_HS")
                    Txtten.Text = DrReturn.Item("Ten_HS")
            End Select
        Else
            Txtma.Text = ""
            Txtten.Text = ""

        End If
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        '----Tạm thời Fix theo Phương án này
        Dim _Tu_ngay As Date = TxtTu_ngay.Value
        Dim _Den_ngay As Date = Txtden_ngay.Value
        Dim _Loai As String = CmbLoai.SelectedValue.ToString.Trim
        'Dim _Str As String = "Update dbo.Ph89CVDV_Clock_CVDVKhoangToKTV SET Tu_ngay = N'" + _Tu_ngay.ToString("yyyyMMdd HH:mm") + "',Den_Ngay = N'" + _Den_ngay.ToString("yyyyMMdd HH:mm") + "' WHERE Ma_Dvcs = N'" + M_Ma_Dvcs + "' AND Loai =N'" + _Loai + "' AND Ma = N'" + Txtma.Text + "'"

        'CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_SysExecute", _Str & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        

        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)
        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region

End Class
