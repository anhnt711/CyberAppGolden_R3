Imports System.Drawing
Public Class UserControlMa_CH
    Public Sub V_load(ByVal _Dr As DataRow, ByVal _Dt_TL As DataTable, Optional ByVal CyberColor As Cyber.Color.Sys = Nothing, Optional ByVal CyberFill As Cyber.Fill.Sys = Nothing)
        If CyberColor Is Nothing Then CyberColor = New Cyber.Color.Sys
        If CyberFill Is Nothing Then CyberFill = New Cyber.Fill.Sys

        Dim _Dt_Tra_Loi As DataTable = Nothing
        Dim _Bold As String = "0"
        Dim _BackColor As String = ""
        Dim _ForeColor As String = ""
        Dim _Ma_CH As String = ""
        Dim _ten_CH As String = ""
        Dim _Ma_TL As String = ""
        Dim _Ghi_Chu As String = ""

        _Ma_TL = _Ma_TL.Trim
        If _Dr.Table.Columns.Contains("Ma_CH") Then _Ma_CH = _Dr.Item("Ma_CH").ToString.Trim
        If _Dr.Table.Columns.Contains("ten_CH") Then _ten_CH = _Dr.Item("ten_CH").ToString.Trim

        If _Dr.Table.Columns.Contains("Ma_TL") Then _Ma_TL = _Dr.Item("Ma_TL").ToString.Trim
        If _Dr.Table.Columns.Contains("Ghi_Chu") Then _Ghi_Chu = _Dr.Item("Ghi_Chu").ToString.Trim

        If _Dr.Table.Columns.Contains("Bold") Then _Bold = _Dr.Item("Bold").ToString.Trim
        If _Dr.Table.Columns.Contains("BackColor") Then _BackColor = _Dr.Item("BackColor").ToString.Trim
        If _Dr.Table.Columns.Contains("ForeColor") Then _ForeColor = _Dr.Item("ForeColor").ToString.Trim

        _Dt_Tra_Loi = _Dt_TL.Clone

        LabbTen_CH.Font = New Drawing.Font(Me.Font, IIf(_Bold = "1", FontStyle.Bold, FontStyle.Regular))
        If Not _ForeColor.Trim = "" Then LabbTen_CH.ForeColor = CyberColor.GetForeColor(_ForeColor)
        If Not _BackColor.Trim = "" Then LabbTen_CH.BackColor = CyberColor.GetBackColor(_BackColor)
        TxtMa_CH.Text = _Ma_CH
        LabbTen_CH.Text = _ten_CH
        TxtGhi_Chu.Text = _Ghi_Chu
        _Dt_Tra_Loi = _Dt_TL.Clone
        For i As Integer = 0 To _Dt_TL.Rows.Count - 1
            If _Dt_TL.Rows(i).Item("MA_CH").ToString.Trim.ToUpper = _Ma_CH.Trim.ToUpper Then _Dt_Tra_Loi.ImportRow(_Dt_TL.Rows(i))
        Next
        CyberFill.V_FillComBoxDefaul(CbbMa_TL, _Dt_Tra_Loi, "Ma_TL", "Ten_TL", "Ngam_Dinh")
        If Not _Ma_TL.Trim = "" Then
            Try
                CbbMa_TL.SelectedValue = _Ma_TL
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class
