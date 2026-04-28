Imports System.Windows.Forms
Public Class CDHS
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Private Sub CDHS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        V_Load()

        CyberSupport.Translaste(Me, M_LAN, True)
        TxtTK.Focus()
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            Me.Text = If(M_LAN = "V", "Tạo mới : " + M_Bar, "New : " + M_Bar2)
        Else
            Me.Text = If(M_LAN = "V", "Sửa : " + M_Bar, "Edit : " + M_Bar2)
        End If
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        TxtMa_NT.Properties.ReadOnly = True
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        TxtNam.Text = Me.Key_Nam.ToString
        TxtMa_Dvcs.Text = M_Ma_Dvcs
        If TxtMa_Dvcs.Text.Trim = "" Then Txtten_DVCS.Text = "" Else Txtten_DVCS.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Dvcs", "DmDvcs", "(Ma_Dvcs = N'" + TxtMa_Dvcs.Text.Trim + "')", CyberSmlib)
        If TxtTen_TK.Text.Trim = "" Then TxtTen_TK.Text = "" Else TxtTen_TK.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk", "DmTk", "(TK = N'" + TxtTK.Text.Trim + "')", CyberSmlib)
        If Not TxtTK.Text.Trim = "" Then TxtMa_NT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ma_NT", "DmTK", "(TK = N'" + TxtTK.Text.Trim + "')", CyberSmlib)
        If TxtMa_NT.Text.Trim = "" Then TxtTen_NT.Text = "" Else TxtTen_NT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nt", "DmNt", "(Ma_Nt = N'" + TxtMa_NT.Text.Trim + "')", CyberSmlib)
        TxtTen_HS.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Hs", "DmHs", "(Ma_Hs = N'" + TxtMa_HS.Text.Trim + "')", CyberSmlib)
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()
        '--Ma_KH
        RemoveHandler TxtMa_HS.CyberValiting, AddressOf V_MA_Hs
        RemoveHandler TxtMa_HS.CyberLeave, AddressOf L_MA_Hs
        AddHandler TxtMa_HS.CyberValiting, AddressOf V_MA_Hs
        AddHandler TxtMa_HS.CyberLeave, AddressOf L_MA_Hs
        '--TK
        RemoveHandler TxtTK.CyberValiting, AddressOf V_TK
        RemoveHandler TxtTK.CyberLeave, AddressOf L_TK
        AddHandler TxtTK.CyberValiting, AddressOf V_TK
        AddHandler TxtTK.CyberLeave, AddressOf L_TK
        '---
        RemoveHandler TxtDu_no00.Leave, AddressOf V_L_Du_No00
        RemoveHandler TxtDu_No_NT00.Leave, AddressOf V_L_Du_No_NT00
        AddHandler TxtDu_no00.Leave, AddressOf V_L_Du_No00
        AddHandler TxtDu_No_NT00.Leave, AddressOf V_L_Du_No_NT00
        '---
        RemoveHandler TxtDu_Co00.Leave, AddressOf V_L_Du_Co00
        RemoveHandler TxtDu_Co_NT00.Leave, AddressOf V_L_Du_Co_NT00
        AddHandler TxtDu_Co00.Leave, AddressOf V_L_Du_Co00
        AddHandler TxtDu_Co_NT00.Leave, AddressOf V_L_Du_Co_NT00
        '---

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()



        '----------------------------















    End Sub
#End Region
#Region "Valid"
    Private Sub V_L_Du_No00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtDu_no00.Double <> 0 Then
            TxtDu_Co00.Double = 0
            TxtDu_Co_NT00.Double = 0
        End If
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_No_NT00.Double = TxtDu_no00.Double
        End If
    End Sub
    Private Sub V_L_Du_No_NT00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_No_NT00.Double = TxtDu_no00.Double
        End If
        If TxtDu_No_NT00.Double <> 0 Then TxtDu_Co_NT00.Double = 0
    End Sub
    '-----------------------------------------------------------------------------
    Private Sub V_L_Du_Co00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtDu_Co00.Double <> 0 Then
            TxtDu_no00.Double = 0
            TxtDu_No_NT00.Double = 0
        End If
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_Co_NT00.Double = TxtDu_Co00.Double
        End If
    End Sub
    Private Sub V_L_Du_Co_NT00(ByVal sender As Object, ByVal e As System.EventArgs)
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_Co_NT00.Double = TxtDu_Co00.Double
        End If
        If TxtDu_Co_NT00.Double <> 0 Then TxtDu_No_NT00.Double = 0
    End Sub
#Region "Vali --- Hs"
    Private Sub V_MA_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_HS.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "MA_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_MA_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtMa_HS.GetRowsSelectData(True)
        If TxtMa_HS.Text = "" Then
            TxtTen_HS.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtMa_HS.Text = DrReturn.Item("Ma_Hs")
            TxtTen_HS.Text = DrReturn.Item("Ten_Hs")
        Else
            TxtMa_HS.Text = ""
            TxtTen_HS.Text = ""
        End If
    End Sub
#End Region
#Region "Vali --- TK"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTK.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK", "Dmtk", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTK.GetRowsSelectData(True)
        If TxtTK.Text = "" Then
            TxtTen_TK.Text = ""
            TxtMa_NT.Text = ""
            TxtTen_NT.Text = ""
            Exit Sub
        End If
        If Not DrReturn Is Nothing Then
            TxtTK.Text = DrReturn.Item("TK")
            TxtTen_TK.Text = DrReturn.Item("Ten_TK")
            TxtMa_NT.Text = DrReturn.Item("Ma_NT")
            If TxtMa_NT.Text.Trim = "" Then TxtTen_NT.Text = "" Else TxtTen_NT.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Nt", "DmNt", "(Ma_Nt = N'" + TxtMa_NT.Text.Trim + "')", CyberSmlib)
            V_Reset()
        Else
            TxtTK.Text = ""
            TxtTen_TK.Text = ""
            TxtMa_NT.Text = ""
            TxtTen_NT.Text = ""
        End If
    End Sub
    Private Sub V_Reset()
        If TxtMa_NT.Text.Trim.ToUpper = "" Or TxtMa_NT.Text.Trim.ToUpper = oSysvar("M_MA_NT0").ToString.Trim.ToUpper Then
            TxtDu_No_NT00.Double = TxtDu_no00.Double
            TxtDu_Co_NT00.Double = TxtDu_Co00.Double

            TxtDu_No_NT00.InputMask = TxtDu_no00.InputMask.ToString.Trim
            TxtDu_Co_NT00.InputMask = TxtDu_Co00.InputMask.ToString.Trim
        Else
            TxtDu_No_NT00.InputMask = TxtDu_No_NT00.Tag.ToString.Trim
            TxtDu_Co_NT00.InputMask = TxtDu_Co_NT00.Tag.ToString.Trim

        End If
        TxtDu_No_NT00.Refresh()
        TxtDu_Co_NT00.Refresh()
    End Sub
#End Region
#End Region
#Region "Buuton"
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        Me.Close()
    End Sub
#End Region
End Class
