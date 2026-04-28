
Public Class KHCT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
   
    Private Sub FDMKH_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)

    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtNam.Text = Me.Key_Nam.ToString
        TxtTen_Vv.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_VV", "DMvv", "( Ma_VV = N'" + TxtMa_Vv.Text.Trim + "')", CyberSmlib)
        TxtTen_tk.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_TK0", "DMtk0", "( tk0 = N'" + TxtTk.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()


        AddHandler TxtTk.CyberValiting, AddressOf V_TK
        AddHandler TxtTk.CyberLeave, AddressOf L_TK

        AddHandler TxtMa_Vv.CyberValiting, AddressOf V_Ma_vv
        AddHandler TxtMa_Vv.CyberLeave, AddressOf L_Ma_VV
    End Sub
#End Region
#Region "Valid"
#End Region
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#Region "Valid"

    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK0", "DMTK0", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTk.Text = DrReturn.Item("TK0")
            TxtTen_tk.Text = DrReturn.Item("Ten_tk0")
        Else
            TxtTk.Text = ""
            TxtTen_tk.Text = ""
        End If
    End Sub


    Private Sub V_Ma_vv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_vv", "DMvv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_VV(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vv.Text = DrReturn.Item("Ma_vv")
            TxtTen_Vv.Text = DrReturn.Item("Ten_vv")
        Else
            TxtMa_Vv.Text = ""
            TxtTen_Vv.Text = ""
        End If
    End Sub

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
