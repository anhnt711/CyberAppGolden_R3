Public Class FrmTien_Do_KCS_CD
    Dim CyberWork As New Cyber.Workprogress.Sys
    Dim M_Mode As String = "M"
#Region "Property"

    Public Property Mode As String
        Get
            Mode = M_Mode
        End Get
        Set(ByVal Value As String)
            M_Mode = Value
        End Set
    End Property
    Dim M_Kieu_Xem As String = "TD"
    Public Property Kieu_Xem() As String
        Get
            Kieu_Xem = M_Kieu_Xem
        End Get
        Set(ByVal Value As String)
            M_Kieu_Xem = Value
        End Set
    End Property
    Dim M_Loai_SC As String = ""
    Public Property Loai_SC As String
        Get
            Loai_SC = M_Loai_SC
        End Get
        Set(ByVal Value As String)
            M_Loai_SC = Value
        End Set
    End Property
    Dim M_Stt_rec As String = ""
    Public Property Stt_rec As String
        Get
            Stt_rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
        End Set
    End Property
#End Region
    Public Dt_Return As DataTable = Nothing
    Public Dt_Cd As DataTable = Nothing
    Private Sub FrmTien_Do_KCS_CD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CyberVoucher Is Nothing Then CyberVoucher = New Cyber.Voucher.Sys
        Me.Save_OK = False
        '------------------------------------------------------------------------------------------------------------------
        V_Load()
        '------------------------------------------------------------------------------------------------------------------
        V_AddHandler()
        '------------------------------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '------------------------------------------------------------------------------------------------------------------
        Me.Text = IIf(M_Mode.Trim = "M", "Cập nhật KCS công đoạn", "Cập nhật KCS công đoạn")
        CbbMa_Cd.Enabled = False

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Dim Dt_Khoang As DataTable
    Dim Dv_Cd As DataView
    Private Sub V_Load()
        V_AddHandler()

        Dim DstmpCd As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_KCS_Load", M_Kieu_Xem + "#" + M_Loai_SC & "#" & M_Stt_rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dt_Cd = DstmpCd.Tables(1).Copy

        Dv_Cd = New DataView(Dt_Cd)
        Dim _Ma_CD As String = CyberWork.V_GetvalueCombox(CbbMa_Cd)
        CyberFill.V_FillComBoxValue(CbbMa_Cd, Dt_Cd, "Ma_Cd", "Ten_Cd", _Ma_CD)
        CyberSmodb.SetValueTObj(Me, DstmpCd.Tables(0).Rows(0))
        DstmpCd.Dispose()

        If TxtMa_KCS.Text.Trim = "" Then TXTTEN_KCS.Text = "" Else TXTTEN_KCS.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_KCS", "DmKCSCD", "Ma_KCS = N'" + TxtMa_KCS.Text.Trim + "' AND  Ma_CD = N'" + _Ma_CD.Trim + "'", CyberSmlib)
        If TxtMa_KCS2.Text.Trim = "" Then TXTTEN_KCS2.Text = "" Else TXTTEN_KCS2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_KCS", "DmKCSCD", "Ma_KCS = N'" + TxtMa_KCS2.Text.Trim + "' AND  Ma_CD = N'" + _Ma_CD.Trim + "'", CyberSmlib)
        If TxtMa_KCS3.Text.Trim = "" Then TXTTEN_KCS3.Text = "" Else TXTTEN_KCS3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_KCS", "DmKCSCD", "Ma_KCS = N'" + TxtMa_KCS3.Text.Trim + "' AND  Ma_CD = N'" + _Ma_CD.Trim + "'", CyberSmlib)
        If TxtMa_KCS4.Text.Trim = "" Then TXTTEN_KCS4.Text = "" Else TXTTEN_KCS4.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_KCS", "DmKCSCD", "Ma_KCS = N'" + TxtMa_KCS4.Text.Trim + "' AND  Ma_CD = N'" + _Ma_CD.Trim + "'", CyberSmlib)
        If TxtMa_KCS5.Text.Trim = "" Then TXTTEN_KCS5.Text = "" Else TXTTEN_KCS5.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_KCS", "DmKCSCD", "Ma_KCS = N'" + TxtMa_KCS5.Text.Trim + "' AND  Ma_CD = N'" + _Ma_CD.Trim + "'", CyberSmlib)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CbbMa_Cd.SelectedValue.ToString().Trim = "" Then Return
        TxtMa_Dvcs.Text = M_Ma_Dvcs.Trim
        '-----------------------------------------------------------------------------------------------------------------
        Dim _Str As String = "SELECT TOP 0 * FROM dbo.PH89CVDV_KCS WHERE 1=0" + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmpStru As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", _Str)
        Dim Dt_Save As DataTable = DsTmpStru.Tables(0).Copy
        DsTmpStru.Dispose()

        Dim _DrSave As DataRow = Dt_Save.NewRow
        _DrSave.BeginEdit()
        CyberSmodb.SetValueBlankRow(_DrSave)
        CyberSmodb.AddValueToRow(_DrSave, Me)

        _DrSave.EndEdit()
        Dt_Save.Rows.Add(_DrSave)
        Dt_Save.AcceptChanges()
        '-----------------------------------------------------------------------------------------------------------------
        Dim strXML As String = CyberSmodb.V_ConvertDataToXML({"PH89CVDV_KCS"}, {Dt_Save})
        Dim M_strParameterStore As String = M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Stt_rec + "#" + strXML + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_KCS_Save", M_strParameterStore)
        '-----------------------------------------------------------------------------------------------------------------
        Dim _Return As Boolean = CyberSupport.V_MsgChk(DsTmp.Tables(0), Me.Sysvar, M_LAN)
        If Not _Return Then
            Dt_Return = Nothing
            DsTmp.Dispose()
            Me.Save_OK = False
            Return
        End If
        Dt_Return = DsTmp.Tables(0).Copy
        Me.Save_OK = True
        '-----------------------------------------------------------------------------------------------------------------
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#Region "V_AddHandler"
    Private Sub V_AddHandler()
        AddHandler ButtOK.Click, AddressOf V_Nhan

        ' KCS1

        RemoveHandler TxtMa_KCS.CyberValiting, AddressOf V_Ma_KCS
        AddHandler TxtMa_KCS.CyberValiting, AddressOf V_Ma_KCS

        AddHandler TxtMa_KCS.CyberLeave, AddressOf L_Ma_KCS

        ' KCS2
        AddHandler TxtMa_KCS2.CyberValiting, AddressOf V_Ma_KCS2
        AddHandler TxtMa_KCS2.CyberLeave, AddressOf L_Ma_KCS2

        ' KCS3
        AddHandler TxtMa_KCS3.CyberValiting, AddressOf V_Ma_KCS3
        AddHandler TxtMa_KCS3.CyberLeave, AddressOf L_Ma_KCS3

        ' KCS4
        AddHandler TxtMa_KCS4.CyberValiting, AddressOf V_Ma_KCS4
        AddHandler TxtMa_KCS4.CyberLeave, AddressOf L_Ma_KCS4

        ' KCS5
        AddHandler TxtMa_KCS5.CyberValiting, AddressOf V_Ma_KCS5
        AddHandler TxtMa_KCS5.CyberLeave, AddressOf L_Ma_KCS5
    End Sub
#End Region
#Region "KCS"
    Dim DsLookup As New DataSet
    Private Sub V_Ma_KCS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ma_CD As String = CyberWork.V_GetvalueCombox(CbbMa_Cd)
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_KCS", "DmKCSCD", "1=1", "Ma_CD = '" + _Ma_CD + "'")
    End Sub
    Private Sub L_Ma_KCS(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KCS.Text = DrReturn.Item("Ma_KCS")
            TXTTEN_KCS.Text = DrReturn.Item("Ten_KCS")
        Else
            TxtMa_KCS.Text = ""
            TXTTEN_KCS.Text = ""
        End If
    End Sub
    Private Sub V_Ma_KCS2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ma_CD As String = CyberWork.V_GetvalueCombox(CbbMa_Cd)
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_KCS", "DmKCSCD", "1=1", "Ma_CD = '" + _Ma_CD + "'")
    End Sub
    Private Sub L_Ma_KCS2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KCS2.Text = DrReturn.Item("Ma_KCS")
            TXTTEN_KCS2.Text = DrReturn.Item("Ten_KCS")
        Else
            TxtMa_KCS2.Text = ""
            TXTTEN_KCS2.Text = ""
        End If
    End Sub
    Private Sub V_Ma_KCS3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ma_CD As String = CyberWork.V_GetvalueCombox(CbbMa_Cd)

        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_KCS", "DmKCSCD", "1=1", "Ma_CD = '" + _Ma_CD + "'")
    End Sub
    Private Sub L_Ma_KCS3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KCS3.Text = DrReturn.Item("Ma_KCS")
            TXTTEN_KCS3.Text = DrReturn.Item("Ten_KCS")
        Else
            TxtMa_KCS3.Text = ""
            TXTTEN_KCS3.Text = ""
        End If
    End Sub
    Private Sub V_Ma_KCS4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ma_CD As String = CyberWork.V_GetvalueCombox(CbbMa_Cd)

        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_KCS", "DmKCSCD", "1=1", "Ma_CD = '" + _Ma_CD + "'")
    End Sub
    Private Sub L_Ma_KCS4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KCS4.Text = DrReturn.Item("Ma_KCS")
            TXTTEN_KCS4.Text = DrReturn.Item("Ten_KCS")
        Else
            TxtMa_KCS4.Text = ""
            TXTTEN_KCS4.Text = ""
        End If
    End Sub
    Private Sub V_Ma_KCS5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim _Ma_CD As String = CyberWork.V_GetvalueCombox(CbbMa_Cd)
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_KCS", "DmKCSCD", "1=1", "Ma_CD = '" + _Ma_CD + "'")

    End Sub
    Private Sub L_Ma_KCS5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_KCS5.Text = DrReturn.Item("Ma_KCS")
            TXTTEN_KCS5.Text = DrReturn.Item("Ten_KCS")
        Else
            TxtMa_KCS5.Text = ""
            TXTTEN_KCS5.Text = ""
        End If
    End Sub
#End Region
End Class
