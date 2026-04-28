Public Class GLCTPK4_F3
    Public Property Drv() As DataRowView
        Get
            Drv = M_Drv
        End Get
        Set(ByVal Value As DataRowView)
            M_Drv = Value
        End Set
    End Property
    Dim M_Drv As DataRowView
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable
    Private Sub GLCTPK4_F3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        V_Addhander()

        Me.Text = If(Me.Lan = "V", "Điều chỉnh hệ số phân bổ", "Adjust attribution factor")
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        CyberSmodb.SetValueTObj(Me, Drv)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim strUpdate As String = TxtSo_Ct01.Text.ToString.Trim.Replace("'", "").Replace("#", "")
        strUpdate = strUpdate & "#" & TxtSo_Ct02.Text.ToString.Trim.Replace("'", "").Replace("#", "")
        strUpdate = strUpdate & "#" & TxtSo_Ct03.Text.ToString.Trim.Replace("'", "").Replace("#", "")
        strUpdate = strUpdate & "#" & TxtSo_Ct04.Text.ToString.Trim.Replace("'", "").Replace("#", "")
        strUpdate = strUpdate & "#" & TxtSo_Ct05.Text.ToString.Trim.Replace("'", "").Replace("#", "")
        strUpdate = strUpdate & "#" & TxtSo_Ct06.Text.ToString.Trim.Replace("'", "").Replace("#", "")
        strUpdate = strUpdate & "#" & TxtSo_Ct07.Text.ToString.Trim.Replace("'", "").Replace("#", "")
        strUpdate = strUpdate & "#" & TxtSo_Ct08.Text.ToString.Trim.Replace("'", "").Replace("#", "")
        strUpdate = strUpdate & "#" & TxtSo_Ct09.Text.ToString.Trim.Replace("'", "").Replace("#", "")
        strUpdate = strUpdate & "#" & TxtSo_Ct10.Text.ToString.Trim.Replace("'", "").Replace("#", "")
        strUpdate = strUpdate & "#" & TxtSo_Ct11.Text.ToString.Trim.Replace("'", "").Replace("#", "")
        strUpdate = strUpdate & "#" & TxtSo_Ct12.Text.ToString.Trim.Replace("'", "").Replace("#", "")
        strUpdate = strUpdate & "#" & TxtTien.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & TxtTien_NT.Double.ToString.Trim.Replace(",", ".")
        strUpdate = strUpdate & "#" & Drv.Item("Stt_Rec").ToString.Trim & "#" & Me.Nam.ToString.Trim
        strUpdate = strUpdate & "#" & M_Ma_Dvcs & "#" & M_User_Name
        Dim DsUpdate As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_GLCTPK4UpdateDmpb", strUpdate)

        Dim _DvReturn As DataView
        _DvReturn = New DataView(DsUpdate.Tables(0).Copy)
        Drv = _DvReturn.Item(0)
        Me.Tag = ""
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
    Private Sub V_Addhander()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtOK.Click, AddressOf V_Nhan
        '
    End Sub
End Class
