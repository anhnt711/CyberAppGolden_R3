Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing
Imports System.Data.SqlClient
Public Class DMKYHD
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub DMKYHD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        CyberSupport.Translaste(Me, M_LAN, True)
        TxtMa_hs.Focus()
        If Me.Mode = "M" Then TxtMa_Dvcs.Text = M_Ma_Dvcs
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        V_AddhanderMaster()
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()
        TxtTen_hs.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Hs", "Dmhs", "Ma_HS = N'" + TxtMa_hs.Text.Trim + "'", CyberSmlib)
        TxtTen_bp.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Bp", "DmBp", "Ma_Bp = N'" + TxtMa_bp.Text.Trim + "'", CyberSmlib)
    End Sub
    Private Sub V_AddhanderMaster()
        RemoveHandler TxtMa_hs.CyberValiting, AddressOf V_Ma_HS
        RemoveHandler TxtMa_hs.CyberLeave, AddressOf L_Ma_HS
        AddHandler TxtMa_hs.CyberValiting, AddressOf V_Ma_HS
        AddHandler TxtMa_hs.CyberLeave, AddressOf L_Ma_HS
        RemoveHandler TxtMa_bp.CyberValiting, AddressOf V_Ma_BP
        RemoveHandler TxtMa_bp.CyberLeave, AddressOf L_Ma_BP
        AddHandler TxtMa_bp.CyberValiting, AddressOf V_Ma_BP
        AddHandler TxtMa_bp.CyberLeave, AddressOf L_Ma_BP
    End Sub

    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
#End Region
#Region "Valid"
#Region "Vali --- Ma_HS"
    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_HS", "DmHS", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_HS(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_hs.Text = DrReturn.Item("Ma_HS")
            TxtTen_hs.Text = DrReturn.Item("Ten_HS")
            TxtMa_bp.Text = DrReturn.Item("Ma_bp")
        Else
            TxtMa_hs.Text = ""
            txtTen_HS.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- Ma_BP"
    Private Sub V_Ma_BP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_BP", "DmBP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_BP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_bp.Text = DrReturn.Item("Ma_BP")
            TxtTen_Bp.Text = DrReturn.Item("Ten_BP")
        Else
            TxtMa_bp.Text = ""
            TxtTen_Bp.Text = ""
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
