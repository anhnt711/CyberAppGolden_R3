Imports System.Data.SqlClient
Imports Cyber.Progress.Sys
Public Class FRun
    Dim oSysvar As Collection
    Dim Appconn As SqlConnection
    Dim M_Para As String()
    Dim _Para As String
    Dim _Ma_Dvcs As String = "01"
    Private Sub FRun_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim CyberSmlib As New Cyber.SmLib.Sys
        Appconn = CyberSmlib.GetConn()
        oSysvar = CyberSmlib.IniSysVar(Appconn, _Ma_Dvcs, "QuanDD")
        _Para = "14#C:\#F:\Project\CyberAppGolden_R2\System\#F:\Project\CyberAppGolden_R2\Repo\#F:\Project\CyberAppGolden_R2\Repo-nt\#Cyber Enterprice#ABC#Admin#True#1#02.05.00#Phiếu thu tiền mặt#Cash on hand receipt#V#" + _Ma_Dvcs
        ''_Para = "14#C:\#F:\Project\CyberAppGolden_R2\System\#F:\Project\CyberAppGolden_R2\Repo\#F:\Project\CyberAppGolden_R2\Repo-nt\#Cyber Enterprice#ABC#Admin#True#1#02.05.00#Phiếu thu tiền mặt#Cash on hand receipt#V#" + _Ma_Dvcs
        V_Addhander()
    End Sub

    Private Function GetParameter(ByVal _Ma_CT As String, ByVal _Ma_Dvcs As String, ByVal _User_Name As String) As String
        Dim CyberSmlib As New Cyber.SmLib.Sys
        Dim _Return As String = ""
        Dim DsGetCommand As DataSet = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "Cp_SysGetRunCommand", _Ma_CT + "#" + "" + _Ma_Dvcs + "#" + _User_Name)
        If DsGetCommand.Tables(1).Rows.Count > 0 Then
            Dim _Pr As String = DsGetCommand.Tables(1).Rows(0).Item("Procedure").ToString.Trim
            _Pr.Split("#")
            For i = 1 To _Pr.Split("#").Length - 1
                _Return = _Return + "#" + _Pr.Split("#")(i)
            Next
        End If
        GetParameter = _Return
    End Function
    Private Sub V_Addhander()
    End Sub

    Private Sub CmdLich_Hen_SCC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLich_Hen_SCC.Click
        Dim _Para1 As String
        _Para1 = _Para + "#CP_Workprogress#1#HEN" 'GetParameter("PT1", _Ma_Dvcs, "ABC")
        M_Para = _Para1.Split("#")
        Dim CyberInvao As New Cyber.Workprogress.Sys
        CyberInvao.Initvao(M_Para)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim _Para1 As String
        _Para1 = _Para + "#CP_Workprogress#2#HEN" 'GetParameter("PT1", _Ma_Dvcs, "ABC")
        M_Para = _Para1.Split("#")
        Dim CyberInvao As New Cyber.Workprogress.Sys
        CyberInvao.Initvao(M_Para)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim _Para1 As String
        _Para1 = _Para + "#CP_Workprogress#1#KH" 'GetParameter("PT1", _Ma_Dvcs, "ABC")
        M_Para = _Para1.Split("#")
        Dim CyberInvao As New Cyber.Workprogress.Sys
        CyberInvao.Initvao(M_Para)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim _Para1 As String
        _Para1 = _Para + "#CP_Workprogress#2#KH" 'GetParameter("PT1", _Ma_Dvcs, "ABC")
        M_Para = _Para1.Split("#")
        Dim CyberInvao As New Cyber.Workprogress.Sys
        CyberInvao.Initvao(M_Para)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim Frm As New Form1
        Frm.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim _Para1 As String
        _Para1 = _Para + "#CP_Work_TIEP_DON#2#KH" 'GetParameter("PT1", _Ma_Dvcs, "ABC")
        M_Para = _Para1.Split("#")
        Dim CyberInvao As New Cyber.Workprogress.Sys
        CyberInvao.Initvao(M_Para)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim _Para1 As String
        _Para1 = _Para + "#CP_Work_TEST#2#KH" 'GetParameter("PT1", _Ma_Dvcs, "ABC")
        M_Para = _Para1.Split("#")
        Dim CyberInvao As New Cyber.Workprogress.Sys
        CyberInvao.Initvao(M_Para)
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Dim _Para1 As String
        _Para1 = _Para + "#CP_Work_XN#1" 'GetParameter("PT1", _Ma_Dvcs, "ABC")
        M_Para = _Para1.Split("#")
        Dim CyberInvao As New Cyber.Workprogress.Sys
        CyberInvao.Initvao(M_Para)
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Dim _Para1 As String
        _Para1 = _Para + "#CP_Work_CW#1#3" 'GetParameter("PT1", _Ma_Dvcs, "ABC")
        M_Para = _Para1.Split("#")
        Dim CyberInvao As New Cyber.Workprogress.Sys
        CyberInvao.Initvao(M_Para)
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Dim _Para1 As String
        _Para1 = _Para + "#CP_Work_XN#2" 'GetParameter("PT1", _Ma_Dvcs, "ABC")
        M_Para = _Para1.Split("#")
        Dim CyberInvao As New Cyber.Workprogress.Sys
        CyberInvao.Initvao(M_Para)
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Dim _Para1 As String
        _Para1 = _Para + "#CP_Work_PDS#2" 'GetParameter("PT1", _Ma_Dvcs, "ABC")
        M_Para = _Para1.Split("#")
        Dim CyberInvao As New Cyber.Workprogress.Sys
        CyberInvao.Initvao(M_Para)
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Dim _Para1 As String
        _Para1 = _Para + "#CP_WorkCapStt" 'GetParameter("PT1", _Ma_Dvcs, "ABC")
        M_Para = _Para1.Split("#")
        Dim CyberInvao As New Cyber.Workprogress.Sys
        CyberInvao.Initvao(M_Para)

    End Sub
End Class