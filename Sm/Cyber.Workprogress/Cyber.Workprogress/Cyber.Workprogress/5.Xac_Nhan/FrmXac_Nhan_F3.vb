Imports DevExpress.XtraScheduler
Imports System.Drawing
Imports DevExpress.Utils
Public Class FrmXac_Nhan_F3
#Region "AddProperty"
    Public M_Dr As DataRow
#End Region

    Private Sub FrmXac_Nhan_F3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        CyberSmodb.SetValueTObj(Me, M_Dr)
        Dim _Ngay_BD_TH As Date = TxtNgay_BD_TH.Value
        Dim _Ngay_KT_TH As Date = TxtNgay_KT_TH.Value

        If _Ngay_BD_TH.ToString("yyyyMMdd") = "19000101" Then ChkNgayBD.Checked = False Else ChkNgayBD.Checked = True
        If _Ngay_KT_TH.ToString("yyyyMMdd") = "19000101" Then ChkNgayKT.Checked = False Else ChkNgayKT.Checked = True

        V_NgayBD_CheckedChanged(New System.Object, New System.EventArgs)
        V_NgayKT_CheckedChanged(New System.Object, New System.EventArgs)

        V_AddHander()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_AddHander()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ChkNgayBD.CheckedChanged, AddressOf V_NgayBD_CheckedChanged
        AddHandler ChkNgayKT.CheckedChanged, AddressOf V_NgayKT_CheckedChanged
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = True
        Dim _Ngay_BD_TH As Date = TxtNgay_BD_TH.Value
        Dim _Ngay_KT_TH As Date = TxtNgay_KT_TH.Value

        Dim _StrNgay_BD_TH As String = _Ngay_BD_TH.ToString("yyyyMMdd HH:mm")
        Dim _StrNgay_KT_TH As String = _Ngay_KT_TH.ToString("yyyyMMdd HH:mm")

        If Not ChkNgayBD.Checked Then _StrNgay_BD_TH = "19000101"
        If Not ChkNgayKT.Checked Then _StrNgay_KT_TH = "19000101"

        Me.Key_Sub1 = _StrNgay_BD_TH
        Me.Key_Sub2 = _StrNgay_KT_TH
        Me.Close()
    End Sub
    Private Sub V_NgayBD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNgay_BD_TH.Enabled = ChkNgayBD.Checked
        Dim _Ngay_BD_TH As Date = TxtNgay_BD_TH.Value
        If _Ngay_BD_TH.ToString("yyyyMMdd") = "19000101" And ChkNgayBD.Checked = True Then TxtNgay_BD_TH.Value = Now

    End Sub
    Private Sub V_NgayKT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtNgay_KT_TH.Enabled = ChkNgayKT.Checked
        Dim _Ngay_KT_TH As Date = TxtNgay_KT_TH.Value
        If _Ngay_KT_TH.ToString("yyyyMMdd") = "19000101" And ChkNgayKT.Checked = True Then TxtNgay_KT_TH.Value = Now
    End Sub
End Class
