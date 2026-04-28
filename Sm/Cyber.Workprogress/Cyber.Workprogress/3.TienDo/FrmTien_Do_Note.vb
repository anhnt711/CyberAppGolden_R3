Public Class FrmTien_Do_Note
    Dim CyberWork As New Cyber.Workprogress.Sys
    Dim CyberColor As New Cyber.Color.Sys
    Dim M_Mode As String = "M"
#Region "Property"
    Dim M_Kieu_Xem As String = "HEN"
    Public Property Kieu_Xem As String
        Get
            Kieu_Xem = M_Kieu_Xem
        End Get
        Set(ByVal Value As String)
            M_Kieu_Xem = Value
        End Set
    End Property

    Dim M_Loai_SC As String = "1"
    Public Property Loai_SC As String
        Get
            Loai_SC = M_Loai_SC
        End Get
        Set(ByVal Value As String)
            M_Loai_SC = Value
        End Set
    End Property

    Dim M_Stt_Rec As String = ""
    Public Property Stt_Rec As String
        Get
            Stt_Rec = M_Stt_Rec
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec = Value
        End Set
    End Property
    Dim M_Stt_rec_Ro As String = ""
    Public Property Stt_rec_Ro As String
        Get
            Stt_rec_Ro = M_Stt_rec_Ro
        End Get
        Set(ByVal Value As String)
            M_Stt_rec_Ro = Value
        End Set
    End Property
#End Region
    Public Dt_Return As DataTable = Nothing
    Private Sub FrmCVDV_SCC_NOTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CyberVoucher Is Nothing Then CyberVoucher = New Cyber.Voucher.Sys
        Me.Save_OK = False
        '------------------------------------------------------------------------------------------------------------------
        V_Load()
        '------------------------------------------------------------------------------------------------------------------
        V_AddHandler()
        '------------------------------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '------------------------------------------------------------------------------------------------------------------
        Me.Text = IIf(M_Mode.Trim = "V", "Cập nhật Ghi chú", "Note")
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Dim Dt_Khoang As DataTable
    Private Sub V_Load()
        V_AddHandler()
        TxtStt_Rec.Text = M_Stt_Rec
        TxtStt_Rec_Ro.Text = M_Stt_rec_Ro

        Dim _Ghi_Chu As String = ""
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Note", "0#" & M_Kieu_Xem & "#" & M_Loai_SC & "#" & M_Stt_Rec & "#" & M_Stt_rec_Ro & "###" & M_Ma_Dvcs & "#" & M_User_Name)
        If Dstmp.Tables().Count = 0 Then Return
        If Dstmp.Tables(0).Rows.Count = 0 Then Return
        If Dstmp.Tables(0).Columns.Contains("Ma_Xe") Then TxtMa_Xe.Text = Dstmp.Tables(0).Rows(0).Item("Ma_Xe").ToString.Trim
        If Dstmp.Tables(0).Columns.Contains("So_RO") Then TxtSo_RO.Text = Dstmp.Tables(0).Rows(0).Item("So_RO").ToString.Trim
        If Dstmp.Tables(0).Columns.Contains("Ten_KH") Then TxtTen_KH.Text = Dstmp.Tables(0).Rows(0).Item("Ten_KH").ToString.Trim
        If Dstmp.Tables(0).Columns.Contains("Ghi_Chu") Then txtGhi_Chu.Text = Dstmp.Tables(0).Rows(0).Item("Ghi_Chu").ToString.Trim
        If Dstmp.Tables(0).Columns.Contains("Stt_Rec") Then txtStt_Rec.Text = Dstmp.Tables(0).Rows(0).Item("Stt_Rec").ToString.Trim
        If Dstmp.Tables(0).Columns.Contains("Stt_Rec_RO") Then TxtStt_Rec_Ro.Text = Dstmp.Tables(0).Rows(0).Item("Stt_Rec_RO").ToString.Trim
        If Dstmp.Tables(0).Columns.Contains("ForeColor_Ghichu") Then TxtForeColor_Ghichu.Text = Dstmp.Tables(0).Rows(0).Item("ForeColor_Ghichu").ToString.Trim
        If Dstmp.Tables(0).Columns.Contains("BackColor_Ghichu") Then TxtBackColor_Ghichu.Text = Dstmp.Tables(0).Rows(0).Item("BackColor_Ghichu").ToString.Trim


        If TxtForeColor_Ghichu.Text <> "" Then
            txtGhi_Chu.ForeColor = CyberColor.GetBackColor(TxtForeColor_Ghichu.Text)
            CldChon_ForeColor.Color = txtGhi_Chu.ForeColor
        End If
        If TxtBackColor_Ghichu.Text <> "" Then
            txtGhi_Chu.BackColor = CyberColor.GetBackColor(TxtBackColor_Ghichu.Text)
            CldChon_Backcolor.Color = txtGhi_Chu.BackColor
        End If
        Dstmp.Dispose()
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        '-----------------------------------------------------------------------------------------------------------------
        Dim _strField As String = ""
        Dim _strValue As String = "'"
        CyberSmodb.GetValueControler(Me, _strField, _strValue)
        _strValue = _strValue.Replace("'", "")
        _strValue = _strValue.Replace("#", "")
        Dim _Stt_Rec As String = TxtStt_Rec.Text
        Dim _Stt_Rec_Ro As String = TxtStt_Rec_Ro.Text
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Note", "1#" & M_Kieu_Xem & "#" & M_Loai_SC & "#" & _Stt_Rec & "#" & _Stt_Rec_Ro & "#" & _strField & "#" & _strValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        '-----------------------------------------------------------------------------------------------------------------
        Dim _Return As Boolean = CyberSupport.V_MsgChk(Dstmp.Tables(0), Me.Sysvar, M_LAN)
        If Not _Return Then
            Dt_Return = Nothing
            Dstmp.Dispose()
            Me.Save_OK = False
            Return
        End If
        Me.Save_OK = True
        Dt_Return = Dstmp.Tables(0).Copy
        Dstmp.Dispose()
        '-----------------------------------------------------------------------------------------------------------------
        Me.Close()
    End Sub
#Region "V_AddHandler"
    Private Sub V_AddHandler()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler ButtForeColor_Choose.Click, AddressOf V_Chon_Forecolor
        AddHandler ButtForeColor_Choose.Click, AddressOf V_Chon_Forecolor
        RemoveHandler ButtBackColor_Choose.Click, AddressOf V_Chon_BackColor
        AddHandler ButtBackColor_Choose.Click, AddressOf V_Chon_BackColor
        RemoveHandler buttRemove_Forecolor.Click, AddressOf V_Remove_Forecolor
        AddHandler buttRemove_Forecolor.Click, AddressOf V_Remove_Forecolor
        RemoveHandler buttRemove_backcolor.Click, AddressOf V_Remove_Backcolor
        AddHandler buttRemove_backcolor.Click, AddressOf V_Remove_Backcolor
    End Sub
#End Region
    Private Sub V_Remove_Forecolor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CldChon_ForeColor.Reset()
        txtGhi_Chu.ForeColor = Drawing.Color.Navy
        TxtForeColor_Ghichu.Text = ""
    End Sub
    Private Sub V_Remove_Backcolor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CldChon_Backcolor.Reset()
        txtGhi_Chu.BackColor = Drawing.Color.White
        TxtBackColor_Ghichu.Text = ""
    End Sub
    Private Sub V_Chon_BackColor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtBackColor_Choose.Enabled = False
        CldChon_Backcolor.ShowDialog()
        txtGhi_Chu.BackColor = CldChon_Backcolor.Color
        TxtBackColor_Ghichu.Text = CldChon_Backcolor.Color.R.ToString() + "," + CldChon_Backcolor.Color.G.ToString() + "," + CldChon_Backcolor.Color.B.ToString()
        ButtBackColor_Choose.Enabled = True
    End Sub
    Private Sub V_Chon_Forecolor(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ButtForeColor_Choose.Enabled = False
        CldChon_ForeColor.ShowDialog()
        txtGhi_Chu.ForeColor = CldChon_ForeColor.Color
        TxtForeColor_Ghichu.Text = CldChon_ForeColor.Color.R.ToString() + "," + CldChon_ForeColor.Color.G.ToString() + "," + CldChon_ForeColor.Color.B.ToString()
        ButtForeColor_Choose.Enabled = True
    End Sub
End Class
