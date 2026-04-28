Public Class FrmTien_Do_Mau_KX
    Dim CyberWork As New Cyber.Workprogress.Sys
    Dim CyberColor As New Cyber.Color.Sys

#Region "AddProperty"
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
    Dim M_Ma_Xe As String = ""
    Public Property Ma_Xe As String
        Get
            Ma_Xe = M_Ma_Xe
        End Get
        Set(ByVal Value As String)
            M_Ma_Xe = Value
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
    Dim M_Stt_Rec_Ro As String = ""
    Public Property Stt_Rec_Ro As String
        Get
            Stt_Rec_Ro = M_Stt_Rec_Ro
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec_Ro = Value
        End Set
    End Property
    Dim M_Dt_Return As DataTable = Nothing
    Public Property Dt_Return As DataTable
        Get
            Dt_Return = M_Dt_Return
        End Get
        Set(ByVal Value As DataTable)
            M_Dt_Return = Value
        End Set
    End Property
#End Region
#Region "Biến"
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Dim DtThang1, DtThang2, DtNam As DataTable
#End Region
    Private Sub FrmTien_Do_Mau_KX_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        TxtMa_Xe.Text = M_Ma_Xe
        TxtMa_Xe.Focus()
        Me.Tag = ""
        V_Load()
        V_AddHandler()
        Me.Text = IIf(M_LAN = "V", "Cập nhập kiểu xe, Màu xe", "Update Model/Color")
    End Sub
    Private Sub V_Load()
        V_Ma_Xe(New System.Object, New System.EventArgs)
    End Sub
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _ma_Xe As String = TxtMa_Xe.Text.Trim.Replace("#", "")
        Dim _ma_Kx As String = TxtMa_Kx.Text.Trim.Replace("#", "")
        Dim _ma_Mau As String = TxtMa_Mau.Text.Trim.Replace("#", "")
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Update_Mau_KX", "0#" & M_Kieu_Xem & "#" & M_Loai_SC & "#" & M_Stt_Rec & "#" & M_Stt_Rec_Ro & "#" & _ma_Xe & "###" & M_Ma_Dvcs & "#" & M_User_Name)
        If DsTmp.Tables.Count > 0 Then
            If DsTmp.Tables(0).Rows.Count > 0 Then
                If DsTmp.Tables(0).Columns.Contains("Ma_Xe") Then
                    If DsTmp.Tables(0).Rows(0).Item("Ma_Xe").ToString.Trim <> "" Then
                        If TxtMa_Xe.Text.Trim = "" Then TxtMa_Xe.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Xe").ToString.Trim
                    End If
                End If

                If DsTmp.Tables(0).Columns.Contains("Ma_Kx") Then
                    If DsTmp.Tables(0).Rows(0).Item("Ma_Kx").ToString.Trim <> "" Then
                        If TxtMa_Kx.Text.Trim = "" Then TxtMa_Kx.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Kx").ToString.Trim
                    End If
                End If

                If DsTmp.Tables(0).Columns.Contains("Ma_Mau") Then
                    If DsTmp.Tables(0).Rows(0).Item("Ma_Mau").ToString.Trim <> "" Then
                        If TxtMa_Mau.Text.Trim = "" Then TxtMa_Mau.Text = DsTmp.Tables(0).Rows(0).Item("Ma_Mau").ToString.Trim
                    End If
                End If
            End If
            If DsTmp.Tables(0).Columns.Contains("Ghi_Chu") Then txtGhi_Chu.Text = DsTmp.Tables(0).Rows(0).Item("Ghi_Chu").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("ForeColor_Ghichu") Then TxtForeColor_Ghichu.Text = DsTmp.Tables(0).Rows(0).Item("ForeColor_Ghichu").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("BackColor_Ghichu") Then TxtBackColor_Ghichu.Text = DsTmp.Tables(0).Rows(0).Item("BackColor_Ghichu").ToString.Trim
            If DsTmp.Tables(0).Columns.Contains("Mau_kho") Then ChkMau_kho.Checked = IIf(DsTmp.Tables(0).Rows(0).Item("Mau_kho").ToString.Trim = "1", True, False)
            DsTmp.Dispose()
        End If
        If TxtMa_Kx.Text.Trim = "" Then TxtTen_Kx.Text = "" Else TxtTen_Kx.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Kx", "DmKx", "(Ma_KX = N'" + TxtMa_Kx.Text.Trim + "')", CyberSmlib)
        If TxtMa_Mau.Text.Trim = "" Then TxtTen_Mau.Text = "" Else TxtTen_Mau.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_Mau", "DmMauXe", "(Ma_Mau = N'" + TxtMa_Mau.Text.Trim + "')", CyberSmlib)

        If TxtForeColor_Ghichu.Text <> "" Then
            txtGhi_Chu.ForeColor = CyberColor.GetBackColor(TxtForeColor_Ghichu.Text)
            CldChon_ForeColor.Color = txtGhi_Chu.ForeColor
        End If
        If TxtBackColor_Ghichu.Text <> "" Then
            txtGhi_Chu.BackColor = CyberColor.GetBackColor(TxtBackColor_Ghichu.Text)
            CldChon_Backcolor.Color = txtGhi_Chu.BackColor
        End If
    End Sub
    Private Sub V_AddHandler()
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        RemoveHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_KX
        RemoveHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_KX
        RemoveHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        RemoveHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        RemoveHandler ButtForeColor_Choose.Click, AddressOf V_Chon_Forecolor
        RemoveHandler ButtBackColor_Choose.Click, AddressOf V_Chon_BackColor
        RemoveHandler buttRemove_Forecolor.Click, AddressOf V_Remove_Forecolor
        RemoveHandler buttRemove_backcolor.Click, AddressOf V_Remove_Backcolor
        RemoveHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
        '------------------------------------------------------------------------------
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler TxtMa_Kx.CyberValiting, AddressOf V_Ma_KX
        AddHandler TxtMa_Kx.CyberLeave, AddressOf L_Ma_KX
        AddHandler TxtMa_Mau.CyberValiting, AddressOf V_Ma_Mau
        AddHandler TxtMa_Mau.CyberLeave, AddressOf L_Ma_Mau
        AddHandler ButtForeColor_Choose.Click, AddressOf V_Chon_Forecolor
        AddHandler ButtBackColor_Choose.Click, AddressOf V_Chon_BackColor
        AddHandler buttRemove_Forecolor.Click, AddressOf V_Remove_Forecolor
        AddHandler buttRemove_backcolor.Click, AddressOf V_Remove_Backcolor
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe
    End Sub
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
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Kx.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_KX", "DmKx", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KX(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        If TxtMa_Kx.Text = "" Then
            TxtTen_Kx.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Kx.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Kx.Text = DrReturn.Item("Ma_KX")
            TxtTen_Kx.Text = DrReturn.Item("Ten_kx")
        Else
            TxtMa_Kx.Text = ""
            TxtTen_Kx.Text = ""
        End If

    End Sub
    Private Sub V_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Mau.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_Mau", "DmMauXe", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Mau(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        If TxtMa_Mau.Text = "" Then
            TxtTen_Mau.Text = ""
            Exit Sub
        End If
        DrReturn = TxtMa_Mau.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Mau.Text = DrReturn.Item("Ma_Mau")
            TxtTen_Mau.Text = DrReturn.Item("Ten_Mau")
        Else
            TxtMa_Mau.Text = ""
            TxtTen_Mau.Text = ""
        End If

    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '--------------------------------------------------------------------------------------------
        If TxtMa_Xe.Text.Trim = "" Then
            TxtMa_Xe.Focus()
            Return
        End If
        '--------------------------------------------------------------------------------------------
        If TxtMa_Kx.Text.Trim = "" Then
            TxtMa_Kx.Focus()
            Return
        End If
        '--------------------------------------------------------------------------------------------
        Dim _ma_Xe As String = TxtMa_Xe.Text.Trim.Replace("#", "")
        '
        Dim _strField As String = ""
        Dim _strValue As String = "'"
        CyberSmodb.GetValueControler(Me, _strField, _strValue)
        _strValue = _strValue.Replace("'", "")
        _strValue = _strValue.Replace("#", "")
        '
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_Update_Mau_KX", "1#" & M_Kieu_Xem & "#" & M_Loai_SC & "#" & M_Stt_Rec & "#" & M_Stt_Rec_Ro & "#" & _ma_Xe & "#" & _strField & "#" & _strValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)

        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            Me.Save_OK = False
            M_Dt_Return = Nothing
        Else
            Me.Save_OK = True
            M_Dt_Return = DsTmp.Tables(0).Copy
        End If
        '--------------------------------------------------------------------------------------------
        Dim M_strParameterStore As String = ""
        Me.Tag = TxtMa_Kx.Text
        CyberSmlib.FlushMemorySave()
        Me.Close()
        '--------------------------------------------------------------------------------------------
    End Sub


End Class
