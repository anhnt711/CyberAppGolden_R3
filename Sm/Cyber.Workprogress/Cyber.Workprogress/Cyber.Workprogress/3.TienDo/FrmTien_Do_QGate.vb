Public Class FrmTien_Do_QGate
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
    Private Sub FrmTien_Do_QGate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If CyberVoucher Is Nothing Then CyberVoucher = New Cyber.Voucher.Sys
        Me.Save_OK = False
        '------------------------------------------------------------------------------------------------------------------
        V_Load()
        '------------------------------------------------------------------------------------------------------------------
        V_AddHandler()
        '------------------------------------------------------------------------------------------------------------------
        CyberSupport.Translaste(Me, M_LAN, True)
        '------------------------------------------------------------------------------------------------------------------
        Me.Text = IIf(M_Mode.Trim = "M", "Cập nhật thông tin Q-Gate", "Cập nhật thông tin Q-Gate")
        CbbMa_Cd.Enabled = False

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Dim Dt_Khoang As DataTable
    Dim Dv_Cd As DataView
    Dim Ma_CD As String = ""
    Private Sub V_SetDefault()
        CbbMa_Cd.SelectedValue = TxtMa_CD.Text
        Ma_Cd = TxtMa_CD.Text
    End Sub
    Private Sub V_Load()
        V_AddHandler()

        Dim DstmpCd As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_QG_Load", M_Kieu_Xem & "#" & M_Loai_SC & "#" & M_Stt_rec & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        Dt_Cd = DstmpCd.Tables(1).Copy
        CyberSmodb.SetValueTObj(Me, DstmpCd.Tables(0).Rows(0))
        DstmpCd.Dispose()

        Dv_Cd = New DataView(Dt_Cd)
        CyberFill.V_FillComBoxDefaul(CbbMa_Cd, Dt_Cd, "Ma_Cd", "Ten_Cd", "Ngam_Dinh")
        V_SetDefault()

        If TxtMa_QG.Text.Trim = "" Then TxtTen_QG.Text = "" Else TxtTen_QG.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_QG", "DmQGCD", "Ma_QG = N'" + TxtMa_QG.Text.Trim + "' AND  Ma_CD = N'" + Ma_CD.Trim + "'", CyberSmlib)
        If TxtMa_QG2.Text.Trim = "" Then TxtTen_QG2.Text = "" Else TxtTen_QG2.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_QG", "DmQGCD", "Ma_QG = N'" + TxtMa_QG2.Text.Trim + "' AND  Ma_CD = N'" + Ma_CD.Trim + "'", CyberSmlib)
        If TxtMa_QG3.Text.Trim = "" Then TxtTen_QG3.Text = "" Else TxtTen_QG3.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_QG", "DmQGCD", "Ma_QG = N'" + TxtMa_QG3.Text.Trim + "' AND  Ma_CD = N'" + Ma_CD.Trim + "'", CyberSmlib)
        If TxtMa_QG4.Text.Trim = "" Then TxtTen_QG4.Text = "" Else TxtTen_QG4.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_QG", "DmQGCD", "Ma_QG = N'" + TxtMa_QG4.Text.Trim + "' AND  Ma_CD = N'" + Ma_CD.Trim + "'", CyberSmlib)
        If TxtMa_QG5.Text.Trim = "" Then TxtTen_QG5.Text = "" Else TxtTen_QG5.Text = CyberSmodb.SQLGetvalue(AppConn, "Ten_QG", "DmQGCD", "Ma_QG = N'" + TxtMa_QG5.Text.Trim + "' AND  Ma_CD = N'" + Ma_CD.Trim + "'", CyberSmlib)
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CbbMa_Cd.SelectedValue.ToString().Trim = "" Then Return
        TxtMa_Dvcs.Text = M_Ma_Dvcs.Trim

        '-----------------------------------------------------------------------------------------------------------------
        Dim _Str As String = "SELECT TOP 0 * FROM dbo.PH89CVDV_QG WITH (NOLOCK) WHERE 1=0" + "#" + M_Ma_Dvcs + "#" + M_User_Name
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
        Dim strXML As String = CyberSmodb.V_ConvertDataToXML({"PH89CVDV_QG"}, {Dt_Save})
        Dim M_strParameterStore As String = M_Kieu_Xem + "#" + M_Loai_SC + "#" + M_Stt_rec + "#" + strXML + "#" + M_Ma_Dvcs + "#" + M_User_Name
        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_Work_QG_Save", M_strParameterStore)
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
        RemoveHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtOK.Click, AddressOf V_Nhan

        'Ma_Cd 
        AddHandler CbbMa_Cd.SelectedValueChanged, AddressOf CbbMa_Cd_SelectedValueChanged

        ' KCS1
        AddHandler TxtMa_QG.CyberValiting, AddressOf V_Ma_QG
        AddHandler TxtMa_QG.CyberLeave, AddressOf L_Ma_QG

        ' KCS2
        AddHandler TxtMa_QG2.CyberValiting, AddressOf V_Ma_QG2
        AddHandler TxtMa_QG2.CyberLeave, AddressOf L_Ma_QG2

        ' KCS3
        AddHandler TxtMa_QG3.CyberValiting, AddressOf V_Ma_QG3
        AddHandler TxtMa_QG3.CyberLeave, AddressOf L_Ma_QG3

        ' KCS4
        AddHandler TxtMa_QG4.CyberValiting, AddressOf V_Ma_QG4
        AddHandler TxtMa_QG4.CyberLeave, AddressOf L_Ma_QG4

        ' KCS5
        AddHandler TxtMa_QG5.CyberValiting, AddressOf V_Ma_QG5
        AddHandler TxtMa_QG5.CyberLeave, AddressOf L_Ma_QG5
    End Sub
#End Region
#Region "Q-Gate"
    Dim DsLookup As DataSet
    Private Sub CbbMa_Cd_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Ma_CD = CyberWork.V_GetvalueCombox(CbbMa_Cd)
    End Sub
    Private Sub V_Ma_QG(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_QG", "DmQGCD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_QG(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_QG.Text = DrReturn.Item("Ma_QG")
            TxtTen_QG.Text = DrReturn.Item("Ten_QG")
        Else
            TxtMa_QG.Text = ""
            TxtTen_QG.Text = ""
        End If
    End Sub
    Private Sub V_Ma_QG2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_QG", "DmQGCD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_QG2(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_QG2.Text = DrReturn.Item("Ma_QG")
            TxtTen_QG2.Text = DrReturn.Item("Ten_QG")
        Else
            TxtMa_QG2.Text = ""
            TxtTen_QG2.Text = ""
        End If
    End Sub
    Private Sub V_Ma_QG3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_QG", "DmQGCD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_QG3(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_QG3.Text = DrReturn.Item("Ma_QG")
            TxtTen_QG3.Text = DrReturn.Item("Ten_QG")
        Else
            TxtMa_QG3.Text = ""
            TxtTen_QG3.Text = ""
        End If
    End Sub
    Private Sub V_Ma_QG4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_QG", "DmQGCD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_QG4(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_QG4.Text = DrReturn.Item("Ma_QG")
            TxtTen_QG4.Text = DrReturn.Item("Ten_QG")
        Else
            TxtMa_QG4.Text = ""
            TxtTen_QG4.Text = ""
        End If
    End Sub
    Private Sub V_Ma_QG5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_QG", "DmQGCD", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_QG5(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If Not (M_Mode = "M" Or M_Mode = "S") Then Exit Sub
        Dim DrReturn = sender.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_QG5.Text = DrReturn.Item("Ma_QG")
            TxtTen_QG5.Text = DrReturn.Item("Ten_QG")
        Else
            TxtMa_QG5.Text = ""
            TxtTen_QG5.Text = ""
        End If
    End Sub
#End Region
End Class
