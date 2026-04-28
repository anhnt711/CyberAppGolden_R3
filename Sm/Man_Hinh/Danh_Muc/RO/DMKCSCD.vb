Imports System.Data.SqlClient
Public Class DMKCSCD
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub FDMKCSCD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_KCS.Focus()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        If TxtMa_CD.Text.Trim = "" Then TxtTen_CD.Text = "" Else TxtTen_CD.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_CD", "DMCDSC", "(Ma_CD = N'" + TxtMa_CD.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_KCS.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_KCS.KeyPress, AddressOf TxtCodeError_KeyPress

        '--CD
        RemoveHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        RemoveHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD
        AddHandler TxtMa_CD.CyberValiting, AddressOf V_Ma_CD
        AddHandler TxtMa_CD.CyberLeave, AddressOf L_Ma_CD
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_CD"
    Private Sub V_Ma_CD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_CD.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_CD", "DmCDSC", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_CD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_CD.GetRowsSelectData(True)
        If TxtMa_CD.Text = "" Then
            TxtTen_CD.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtMa_CD.Text = DrReturn.Item("Ma_CD")
            TxtTen_CD.Text = DrReturn.Item("Ten_CD")
        Else
            TxtMa_CD.Text = ""
            TxtTen_CD.Text = ""
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
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
