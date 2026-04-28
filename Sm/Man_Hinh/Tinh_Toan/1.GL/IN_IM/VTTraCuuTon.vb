Imports System.Data.SqlClient

Public Class VTTraCuuTon
    Dim M_Cp_Name As String
    Dim DtThang, DtNam As DataTable
    Dim Dtnh_Vt1 As DataTable
    Dim Dtnh_Vt2 As DataTable
    Dim Dtnh_Vt3 As DataTable
    Dim DtKho_Vt As DataTable
    Dim Dt_Head As DataTable
    Dim Dt_Master As DataTable
    Dim DtDvcs As DataTable
    Dim Dv_Master, Dv_Head As DataView
    Dim DrReturn, DrReturn02 As DataRow
    Dim DsLookup, DsLookup02 As DataSet
    Private Sub VTTraCuuTon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        M_Cp_Name = "CP_VTTraCuuTon"
        If Me.Para(Me.M_VT_PARA + 2).ToString.Trim.ToUpper = "TAN_SUAT" Then
            CbbM_Nam.Visible = True
            CbbM_Thang.Visible = True
            Labthang.Visible = True
            Labnam.Visible = True

        End If
        AddHandler ButtOK.Click, AddressOf V_Nhan
        Me.Save_OK = False
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        '--------------------------------------------------------------------
        DtDvcs = V_GetUnists(AppConn, M_Ma_Dvcs, M_User_Name, CyberSmlib)
        Me.CyberFill.V_FillComBoxValue(Me.CbbMa_Dvcs, DtDvcs, "Ma_Dvcs", "Ten_Dvcs", M_Ma_Dvcs)
        '--------------------------------------------------------------------
        DtThang = CreateTableMonth()
        DtNam = CreateTableYear()
        CyberFill.V_FillComBoxDefaul(CbbM_Thang, DtThang, "Thang", IIf(Me.Lan = "V", "Ten_Thang", "Ten_Thang2"), "Default")
        CyberFill.V_FillComBoxDefaul(CbbM_Nam, DtNam, "Nam", IIf(Me.Lan = "V", "Ten_Nam", "Ten_nam2"), "Default")
        '--------------------------------------------------------------------
        V_LoadDatatabse("1")
        AddHander()
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
    End Sub
    Private Sub V_LoadDatatabse(ByVal _Status As String)
        Dim strField As String = ""
        Dim strValue As String = ""
        Dim _strLoaitru As String = "TEN_VT01"
        CyberSmodb.GetValueControler(Me, strField, strValue, _strLoaitru)

        Dim _DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, M_Cp_Name, _Status.ToString.Trim & "#" & Me.Para(Me.M_VT_PARA + 2).ToString.Trim.ToUpper & "#" & strField & "#" & strValue & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If _Status = "1" Then

            Dtnh_Vt1 = _DsTmp.Tables(0).Copy
            Dtnh_Vt2 = _DsTmp.Tables(1).Copy
            Dtnh_Vt3 = _DsTmp.Tables(2).Copy
            DtKho_Vt = _DsTmp.Tables(3).Copy
            Dt_Head = _DsTmp.Tables(4).Copy
            Dt_Master = _DsTmp.Tables(5).Copy
            Dv_Head = New DataView(Dt_Head)
            Dv_Master = New DataView(Dt_Master)
            CyberFill.V_FillComBoxDefaul(Me.CbbNh_VT1, Dtnh_Vt1, "ma_nh", If(M_LAN = "V", "Ten_nh", "Ten_nh2"))
            CyberFill.V_FillComBoxDefaul(Me.CbbNh_VT2, Dtnh_Vt2, "ma_nh", If(M_LAN = "V", "Ten_nh", "Ten_nh2"))
            CyberFill.V_FillComBoxDefaul(Me.CbbNh_VT3, Dtnh_Vt3, "ma_nh", If(M_LAN = "V", "Ten_nh", "Ten_nh2"))
            CyberFill.V_FillComBoxDefaul(Me.CbbMa_kho, DtKho_Vt, "ma_kho", If(M_LAN = "V", "Ten_kho", "Ten_kho2"))

            Master.DataSource = Dv_Master
            Me.MasterGRV.GridControl = Me.Master


            CyberFill.V_FillReports(MasterGRV, Me.Lan, Dv_Head, Dv_Master)
        Else
            Dim nCount As Integer = _DsTmp.Tables.Count
            Dt_Master.Clear()
            CyberSmodb.SetNotNullTable(_DsTmp.Tables(nCount - 1))
            For i = 0 To _DsTmp.Tables(nCount - 1).Rows.Count - 1
                Dt_Master.ImportRow(_DsTmp.Tables(nCount - 1).Rows(i))
            Next
            Dt_Master.AcceptChanges()
        End If
    End Sub
    Private Function CreateTableMonth() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Thang")
        _Return.Columns.Add("Ten_Thang")
        _Return.Columns.Add("Ten_Thang2")
        _Return.Columns.Add("Default")
        Dim _Thang As String = ""
        Dim _Default As String = "0"

        For i As Integer = 1 To 12
            _Thang = Strings.Right("00" + i.ToString.Trim, 2).Trim
            If Now.Date.Month = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Thang.ToString, "Tháng " + _Thang, "Month " + _Thang, _Default)
        Next
        CreateTableMonth = _Return
    End Function
    Private Function CreateTableYear() As DataTable
        Dim _Return As New DataTable
        _Return.Columns.Add("Nam")
        _Return.Columns.Add("Ten_Nam")
        _Return.Columns.Add("Ten_Nam2")
        _Return.Columns.Add("Default")

        Dim _CurYear As Integer = Now.Year

        Dim _Nam As String = ""
        Dim _Default As String = "0"

        For i As Integer = _CurYear - 10 To _CurYear + 10
            _Nam = Strings.Right("0000" + i.ToString.Trim, 4).Trim

            If Now.Date.Year = i Then
                _Default = "1"
            Else
                _Default = "0"
            End If
            _Return.Rows.Add(_Nam.ToString, "Năm " + _Nam, "Year " + _Nam, _Default)
        Next
        CreateTableYear = _Return
    End Function
    Private Function V_GetUnists(ByVal Appconn As SqlConnection, ByVal _Ma_Dvcs As String, ByVal _User_Name As String, Optional ByVal CyberSmLib As Cyber.SmLib.Sys = Nothing) As DataTable
        Dim DsUnits As New DataSet
        DsUnits = CyberSmLib.SQLExcuteStoreProcedure(Appconn, "CP_SysListUnits", _Ma_Dvcs.Trim + "#" + _User_Name)
        V_GetUnists = DsUnits.Tables(0).Copy
        DsUnits.Dispose()
    End Function
    Private Sub V_Search(ByVal sender As System.Object, ByVal e As System.EventArgs)
        V_LoadDatatabse("0")
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()
        Me.Close()
    End Sub
#Region "AddHandler"
    Private Sub AddHander()
        AddHandler CmdOK.Click, AddressOf V_Search
        AddHandler TxtMa_Vt01.CyberValiting, AddressOf V_Ma_vt01
        AddHandler TxtMa_Vt01.CyberLeave, AddressOf L_Ma_vt01

        AddHandler TxtMa_vt02.CyberValiting, AddressOf V_Ma_vt02
        AddHandler TxtMa_vt02.CyberLeave, AddressOf L_Ma_vt02

        AddHandler TxtMa_vt03.CyberValiting, AddressOf V_Ma_vt03
        AddHandler TxtMa_vt03.CyberLeave, AddressOf L_Ma_vt03

        AddHandler TxtMa_vt04.CyberValiting, AddressOf V_Ma_vt04
        AddHandler TxtMa_vt04.CyberLeave, AddressOf L_Ma_vt04

        AddHandler TxtMa_vt05.CyberValiting, AddressOf V_Ma_vt05
        AddHandler TxtMa_vt05.CyberLeave, AddressOf L_Ma_vt05

        AddHandler TxtMa_vt06.CyberValiting, AddressOf V_Ma_vt06
        AddHandler TxtMa_vt06.CyberLeave, AddressOf L_Ma_vt06

        AddHandler TxtMa_vt07.CyberValiting, AddressOf V_Ma_vt07
        AddHandler TxtMa_vt07.CyberLeave, AddressOf L_Ma_vt07

        AddHandler TxtMa_vt08.CyberValiting, AddressOf V_Ma_vt08
        AddHandler TxtMa_vt08.CyberLeave, AddressOf L_Ma_vt08

        AddHandler TxtMa_vt09.CyberValiting, AddressOf V_Ma_vt09
        AddHandler TxtMa_vt09.CyberLeave, AddressOf L_Ma_vt09

        AddHandler TxtMa_vt10.CyberValiting, AddressOf V_Ma_vt10
        AddHandler TxtMa_vt10.CyberLeave, AddressOf L_Ma_vt10

        AddHandler TxtMa_vt11.CyberValiting, AddressOf V_Ma_vt11
        AddHandler TxtMa_vt11.CyberLeave, AddressOf L_Ma_vt11

        AddHandler TxtMa_vt12.CyberValiting, AddressOf V_Ma_vt12
        AddHandler TxtMa_vt12.CyberLeave, AddressOf L_Ma_vt12
    End Sub
#End Region
#Region "Vali --- Ma_Vt"
    Private Sub V_Ma_vt01(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_Vt01.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt01(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        DrReturn = TxtMa_Vt01.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_Vt01.Text = DrReturn.Item("Ma_vt")

        Else
            TxtMa_Vt01.Text = ""

            Exit Sub
        End If
    End Sub
    Private Sub V_Ma_vt02(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt02.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt02(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        DrReturn = TxtMa_vt02.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt02.Text = DrReturn.Item("Ma_vt")

        Else
            TxtMa_vt02.Text = ""

            Exit Sub
        End If
    End Sub
    Private Sub V_Ma_vt03(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt03.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt03(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        DrReturn = TxtMa_vt03.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt03.Text = DrReturn.Item("Ma_vt")

        Else
            TxtMa_vt03.Text = ""

            Exit Sub
        End If
    End Sub

    Private Sub V_Ma_vt04(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt04.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt04(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        DrReturn = TxtMa_vt04.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt04.Text = DrReturn.Item("Ma_vt")

        Else
            TxtMa_vt04.Text = ""

            Exit Sub
        End If
    End Sub

    Private Sub V_Ma_vt05(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt05.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt05(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        DrReturn = TxtMa_vt05.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt05.Text = DrReturn.Item("Ma_vt")

        Else
            TxtMa_vt05.Text = ""

            Exit Sub
        End If
    End Sub

    Private Sub V_Ma_vt06(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt06.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt06(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        DrReturn = TxtMa_vt06.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt06.Text = DrReturn.Item("Ma_vt")

        Else
            TxtMa_vt06.Text = ""

            Exit Sub
        End If
    End Sub

    Private Sub V_Ma_vt07(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt07.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt07(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        DrReturn = TxtMa_vt07.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt07.Text = DrReturn.Item("Ma_vt")

        Else
            TxtMa_vt07.Text = ""

            Exit Sub
        End If
    End Sub

    Private Sub V_Ma_vt08(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt08.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt08(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        DrReturn = TxtMa_vt08.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt08.Text = DrReturn.Item("Ma_vt")

        Else
            TxtMa_vt08.Text = ""

            Exit Sub
        End If
    End Sub

    Private Sub V_Ma_vt09(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt09.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt09(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        DrReturn = TxtMa_vt09.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt09.Text = DrReturn.Item("Ma_vt")

        Else
            TxtMa_vt09.Text = ""

            Exit Sub
        End If
    End Sub

    Private Sub V_Ma_vt10(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt10.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt10(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        DrReturn = TxtMa_vt10.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt10.Text = DrReturn.Item("Ma_vt")

        Else
            TxtMa_vt10.Text = ""

            Exit Sub
        End If
    End Sub

    Private Sub V_Ma_vt11(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt11.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt11(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        DrReturn = TxtMa_vt11.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt11.Text = DrReturn.Item("Ma_vt")

        Else
            TxtMa_vt11.Text = ""

            Exit Sub
        End If
    End Sub

    Private Sub V_Ma_vt12(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        TxtMa_vt12.V_LookUp(Me.Lan, Me.Para, Me.Sysvar, AppConn, DsLookup, "Ma_vt", "Dmvt", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_vt12(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)

        DrReturn = TxtMa_vt12.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtMa_vt12.Text = DrReturn.Item("Ma_vt")

        Else
            TxtMa_vt12.Text = ""

            Exit Sub
        End If
    End Sub
#End Region
#Region "V_AddHandler"
    Private Sub V_AddHandler()

    End Sub
    Private Sub V_AddHandler_System()
    End Sub
#End Region
End Class
