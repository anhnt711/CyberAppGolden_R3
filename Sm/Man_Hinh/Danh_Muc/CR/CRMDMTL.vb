Imports System.Data.SqlClient
Public Class CRMDMTL
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMTT_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_Tl.Focus()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        If Me.Mode = "M" Then CyberSmodb.SetValueTObj(Me, Me.DrNew) Else CyberSmodb.SetValueTObj(Me, Me.DrOld)
        TxtTen_Ch.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Ch", "CRMDmCH", "(Ma_Ch = N'" + TxtMa_Ch.Text.Trim + "')", CyberSmlib)
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        RemoveHandler TxtMa_Tl.KeyPress, AddressOf TxtCodeError_KeyPress
        AddHandler TxtMa_Tl.KeyPress, AddressOf TxtCodeError_KeyPress

        '--BP1
        RemoveHandler TxtMa_Ch.CyberValiting, AddressOf V_Ma_Ch
        RemoveHandler TxtMa_Ch.CyberLeave, AddressOf L_Ma_Ch
        AddHandler TxtMa_Ch.CyberValiting, AddressOf V_Ma_Ch
        AddHandler TxtMa_Ch.CyberLeave, AddressOf L_Ma_Ch
        '--BP2
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_Ch"
    Private Sub V_Ma_Ch(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Ch.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_CH", "CRMDmCH", "1=1", "'1'='1'")
    End Sub
    Private Sub L_Ma_Ch(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_Ch.GetRowsSelectData(True)
        If TxtMa_Ch.Text = "" Then
            TxtTen_Ch.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtMa_Ch.Text = DrReturn.Item("Ma_CH")
            TxtTen_Ch.Text = DrReturn.Item("Ten_CH")
        Else
            TxtMa_Ch.Text = ""
            TxtTen_Ch.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim _Value As String = V_GetCode(Me, Mode, M_Ma_Dvcs, M_User_Name)
        If Not _Value.Trim = "" Then TxtMa_Tl.Text = _Value
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Protected Overrides Sub V_Exit(ByVal sender As Object, ByVal e As System.EventArgs)        ''// Su ly truoc khi thoat truong trinh viet vao day
        MyBase.V_Exit(sender, e) '// khong xoa doan nay
    End Sub
#End Region
End Class
