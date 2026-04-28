Public Class DMKCVAT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMTD1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtStt.Focus()
        Me.Text = Me.Text + " - Finance"
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_TK01.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_tk0", "Dmtk0", "(Tk0 = N'" + TxtTk01.Text.Trim + "')", CyberSmlib)
        TxtTen_tk02.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_tk0", "Dmtk0", "(Tk0 = N'" + TxtTk02.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then
            Rd01.Checked = "1"
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtNam.Text = Me.Key_Nam
        End If
        If TxtLoai_kc.Text.Trim = "1" Then Rd01.Checked = True
        If TxtLoai_kc.Text.Trim = "2" Then Rd02.Checked = True
        If TxtLoai_kc.Text.Trim = "3" Then Rd03.Checked = True
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--Rd01
        RemoveHandler Rd01.CheckedChanged, AddressOf C_Rd01
        AddHandler Rd01.CheckedChanged, AddressOf C_Rd01

        '--Rd02
        RemoveHandler Rd02.CheckedChanged, AddressOf C_Rd02
        AddHandler Rd02.CheckedChanged, AddressOf C_Rd02

        '--Rd03
        RemoveHandler Rd03.CheckedChanged, AddressOf C_Rd03
        AddHandler Rd03.CheckedChanged, AddressOf C_Rd03

        '--Tk01
        RemoveHandler TxtTk01.CyberValiting, AddressOf V_Tk01
        RemoveHandler TxtTk01.CyberLeave, AddressOf L_Tk01
        AddHandler TxtTk01.CyberValiting, AddressOf V_Tk01
        AddHandler TxtTk01.CyberLeave, AddressOf L_Tk01

        '--Tk02
        RemoveHandler TxtTk02.CyberValiting, AddressOf V_Tk02
        RemoveHandler TxtTk02.CyberLeave, AddressOf L_Tk02
        AddHandler TxtTk02.CyberValiting, AddressOf V_Tk02
        AddHandler TxtTk02.CyberLeave, AddressOf L_Tk02
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Check"
#Region "Check --- Rd01'"
    Private Sub C_Rd01(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.Rd01.Checked Then
            Me.TxtLoai_kc.Text = "1"
        End If
    End Sub
#End Region
#Region "Check --- Rd02'"
    Private Sub C_Rd02(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.Rd02.Checked Then
            Me.TxtLoai_kc.Text = "2"
        End If
    End Sub
#End Region
#Region "Check --- Rd03'"
    Private Sub C_Rd03(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.Rd03.Checked Then
            Me.TxtLoai_kc.Text = "3"
        End If
    End Sub
#End Region
#End Region
#Region "Valid"
#Region "Vali --- Tk01"
    Private Sub V_Tk01(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk01.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk0", "Dmtk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk01(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk01.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk01.Text = DrReturn.Item("Tk0")
            TxtTen_TK01.Text = DrReturn.Item("Ten_tk0")
        Else
            TxtTk01.Text = ""
            TxtTen_TK01.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Tk02"
    Private Sub V_Tk02(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTk02.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Tk0", "Dmtk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk02(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTk02.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk02.Text = DrReturn.Item("Tk0")
            TxtTen_tk02.Text = DrReturn.Item("Ten_tk0")
        Else
            TxtTk02.Text = ""
            TxtTen_tk02.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
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