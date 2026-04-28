Public Class FrmTiep_Don_Dat_Cho
    Public M_DmCvdv As DataTable
    Public M_Ma_CT As String
    Public M_DmUT As DataTable

    Public Dr_Return As DataRow
    Public M_Mode As String
    Dim CyberWork As New Sys
    ''Dim DtLoai_SC As DataTable

    Private Sub FTiep_Don_Dat_Cho_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        Me.Text = "Đặt chỗ"
        If Me.M_Mode = "M" Then Me.Text = "Tạo mới đặt chỗ" Else Me.Text = "Sửa đặt chỗ"

        Me.Save_OK = False
        TxtNgay_BD.Value = Now.Date
        TxtNgay_KT.Value = Now.Date
        '-------------------------------------------------------
        ''V_CreateLoaiSC()
        CyberFill.V_FillComBoxDefaul(CbbXe_UT, M_DmUT, "Ma_UT", "Ten_UT", "Default")
        CyberFill.V_FillComBoxValue(CbbMa_Cvdv, M_DmCvdv, "Ma_cvdv", "Ten_cvdv", "")
        '-------------------------------------------------------
        'V_Load()
        '-------------------------------------------------------
        TxtMa_Ct.Text = M_Ma_CT
        V_AddHandler()

        ChkSCC.Checked = True
        ChkSBD.Checked = False
        ChkSDS.Checked = False

        V_Load()
        '-------------------------------------------------------
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        TxtTG_SC.Double = TxtTG_SC.Double = CyberWork.V_GetTimeM(_Ngay_BD, _Ngay_KT, AppConn, CyberSmlib, M_Ma_Dvcs)
        '-------------------------------------------------------
        If TxtLoai.Text.Trim = "2" Then  '--> Theo yêu cầu Mr Cường
            TxtMa_Xe.ReadOnly = False
        Else
            'TxtMa_Xe.ReadOnly = True
        End If
    End Sub
    Private Sub V_CreateLoaiSC()
        'DtLoai_SC = New DataTable
        'DtLoai_SC.Columns.Add("Loai_SC")
        'DtLoai_SC.Columns.Add("Ten_Loai")
        'DtLoai_SC.Columns.Add("Ngam_Dinh")
        'DtLoai_SC.Rows.Add("1", "Sửa chữa chung", "1")
        'DtLoai_SC.Rows.Add("2", "Bảo dưỡng", "0")
        'DtLoai_SC.Rows.Add("3", "Đồng sơn", "0")
    End Sub
    Private Sub V_AddHandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        '---------------------------------------------------------
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
        AddHandler TxtTG_SC.Leave, AddressOf V_TG_SC
        AddHandler TxtNgay_BD.Leave, AddressOf V_Ngay_BD
        AddHandler TxtNgay_KT.Leave, AddressOf V_Ngay_KT
        '---------------------------------------------------------
    End Sub
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Xe.Text.Trim = "" Then Return
        If TxtDt_Lx.Text.Trim = "" Then TxtDt_Lx.Text = CyberSmodb.SQLGetvalue(AppConn, "DT_LX", "DmXe", "(Ma_Xe = N'" + TxtMa_Xe.Text.Trim + "')", CyberSmlib)
        If TxtTen_Lx.Text.Trim = "" Then TxtTen_Lx.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_LX", "DmXe", "(Ma_Xe = N'" + TxtMa_Xe.Text.Trim + "')", CyberSmlib)

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        TxtLoai.Text = "2"
        'TxtLoai_SC.Text = "1"
        CyberSmodb.SetValueTObj(Me, Dr_Return)
        TxtTinh_Trang.Text = "1"
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If TxtMa_Xe.Text.Trim = "" Then
            TxtMa_Xe.Focus()
            Exit Sub
        End If
        Dim _Ma_Dvcs As String = ""
        Try
            _Ma_Dvcs = CbbMa_Cvdv.SelectedValue.ToString
        Catch ex As Exception

        End Try
        If _Ma_Dvcs.Trim = "" Then
            CbbMa_Cvdv.Focus()
            MsgBox("Bạn chưa chọn cố vấn dịch vụ", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Sysvar("M_CYBER_VER"))
            Exit Sub
        End If
        '----------------------------------------------------------------------------------------
        Me.Save_OK = True
        Dim _StrDelete As String = "Stt_rec = N'" + TxtStt_Rec.Text.ToString.Trim + "'"
        CyberSmodb.AddValueToRow(Dr_Return, Me)
        CyberSmodb.V_SaveHToSQL(AppConn, Sysvar, M_User_Name, Dr_Return, "PhTiepDon", M_Mode, _StrDelete, IIf(Me.M_Mode.Trim = "S", True, False))

        CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Tiep_Don_UpdateIsTiepDon", TxtMa_Ct.Text + "#" + TxtStt_Rec.Text + "#" + TxtMa_Xe.Text + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        CyberSmlib.FlushMemorySave()
        '----------------------------------------------------------------------------------------
        Me.Dr_Return = Dr_Return
        Me.Close()
    End Sub

#Region "Thoi gian"
    Private Sub V_TG_SC(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        If TxtTG_SC.Double <= 0 Then TxtTG_SC.Double = 15
        TxtNgay_KT.Value = _Ngay_BD.AddMinutes(TxtTG_SC.Double)
    End Sub
    Private Sub V_Ngay_BD(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        If TxtTG_SC.Double > 0 Then TxtNgay_KT.Value = _Ngay_BD.AddMinutes(TxtTG_SC.Double)
        Dim _Ngay_KT As Date = TxtNgay_KT.Value

        TxtTG_SC.Double = TxtTG_SC.Double = CyberWork.V_GetTimeM(_Ngay_BD, _Ngay_KT, AppConn, CyberSmlib, M_Ma_Dvcs)
    End Sub
    Private Sub V_Ngay_KT(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Ngay_BD As Date = TxtNgay_BD.Value
        Dim _Ngay_KT As Date = TxtNgay_KT.Value
        TxtTG_SC.Double = TxtTG_SC.Double = CyberWork.V_GetTimeM(_Ngay_BD, _Ngay_KT, AppConn, CyberSmlib, M_Ma_Dvcs)

    End Sub
#End Region

End Class
