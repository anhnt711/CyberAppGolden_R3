Public Class FrmCapStt_F3
#Region "AddProperty"
    Dim M_Stt_Rec As String = ""
    Public Property Stt_Rec() As String
        Get
            Stt_Rec = M_Stt_Rec
        End Get
        Set(ByVal Value As String)
            M_Stt_Rec = Value
        End Set
    End Property
    Dim M_Mode As String = ""
    Public Property Mode() As String
        Get
            Mode = M_Mode
        End Get
        Set(ByVal Value As String)
            M_Mode = Value
        End Set
    End Property
    Dim M_Ma_Xe As String = ""
    Public Property Ma_Xe() As String
        Get
            Ma_Xe = M_Ma_Xe
        End Get
        Set(ByVal Value As String)
            M_Ma_Xe = Value
        End Set
    End Property
    Public M_Dt_Return As DataTable = Nothing
#End Region
    Dim Dt_WorkCapStt As DataTable
    Dim Dt_Post As DataTable
    Dim Dt_DmQuay As DataTable
    Private Sub FrmCapStt_F3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load_Quay()
        V_Load()
        V_AddHander()

        CbbMa_Post.Enabled = False
        TxtNgay_Hen.Enabled = False
        Chkis_Hen.Enabled = False
        TxtStt1.Enabled = False
        If M_Mode = "S" Then Me.Text = "Sửa phiếu" Else Me.Text = "Tạo phiếu"
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load_Quay()
        Dim dsQuay As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkCapStt_DmQuay", M_Ma_Dvcs + "#" + M_User_Name)
        Dt_DmQuay = dsQuay.Tables(0).Copy
        CyberFill.V_FillComBoxDefaul(CbbMa_Quay, Dt_DmQuay, "Ma_Quay", "ten_Quay", "Ngam_Dinh")
    End Sub
    Private Sub V_Load()
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkCapStt_F3", M_Mode + "#" + M_Ma_Xe + "#" + M_Stt_Rec + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dt_Post = Dstmp.Tables(1).Copy
        CyberFill.V_FillComBoxValue(CbbMa_Post, Dt_Post, "Ma_Post", "ten_post")

        Dim Dr As DataRow = Dstmp.Tables(0).Copy.Rows(0)
        CyberSmodb.SetValueTObj(Me, Dr)

        Dt_WorkCapStt = Dstmp.Tables(0).Clone

        Dstmp.Dispose()
    End Sub
    Private Sub V_AddHander()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        AddHandler ButtExit.Click, AddressOf V_Quay_Ra
        AddHandler TxtMa_Xe.Leave, AddressOf V_Ma_Xe

    End Sub
    Private Sub V_Ma_Xe(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtMa_Xe.Text = CyberVoucher.V_FormatBien_So(TxtMa_Xe.Text, True)
        If TxtMa_Xe.Text.Trim = "" Then Exit Sub
        Dim Dstmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkCapStt_Ma_Xe", TxtMa_Xe.Text + "#" + M_Ma_Dvcs + "#" + M_User_Name)
        If Dstmp.Tables.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(0).Rows.Count = 0 Then
            Dstmp.Dispose()
            Return
        End If

        If Dstmp.Tables(0).Columns.Contains("Ten_Lx") Then If Not Dstmp.Tables(0).Rows(0).Item("Ten_lx").ToString.Trim = "" Then TxtTen_Lx.Text = Dstmp.Tables(0).Rows(0).Item("Ten_lx").ToString.Trim
        If Dstmp.Tables(0).Columns.Contains("Ten_Kh") Then If Not Dstmp.Tables(0).Rows(0).Item("Ten_Kh").ToString.Trim = "" Then txtTen_KH.Text = Dstmp.Tables(0).Rows(0).Item("Ten_Kh").ToString.Trim
        If Dstmp.Tables(0).Columns.Contains("Dt_Lx") Then If Not Dstmp.Tables(0).Rows(0).Item("Dt_Lx").ToString.Trim = "" Then TxtDt_LX.Text = Dstmp.Tables(0).Rows(0).Item("Dt_Lx").ToString.Trim
        If Dstmp.Tables(0).Columns.Contains("Ngay_hen") Then TxtNgay_Hen.Value = Dstmp.Tables(0).Rows(0).Item("Ngay_hen").ToString.Trim
        If Dstmp.Tables(0).Columns.Contains("Is_hen") Then Chkis_Hen.Checked = (Dstmp.Tables(0).Rows(0).Item("Is_hen").ToString.Trim = "1")

        Dstmp.Dispose()

    End Sub

    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim drMaster As DataRow
        drMaster = Dt_WorkCapStt.NewRow()
        CyberSmodb.SetValueBlankRow(drMaster)
        CyberSmodb.AddValueToRow(drMaster, Me)

        Dt_WorkCapStt.Rows.Add(drMaster)
        Dt_WorkCapStt.AcceptChanges()

        Dim strXML As String = CyberSmodb.V_ConvertDataToXML({"WorkCapStt"}, {Dt_WorkCapStt})

        '--------------------------------------------------------------------------------------------
        Dim M_strParameterStore As String = M_Mode + "#" + TxtStt_Rec.Text + "#" + strXML + "#" + M_Ma_Dvcs + "#" + M_User_Name

        Dim DsTmp As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_WorkCapStt_Save", M_strParameterStore)
        If Not CyberSupport.V_MsgChk(DsTmp.Tables(0), Sysvar, M_LAN) Then
            DsTmp.Dispose()
            Me.Save_OK = False
            Me.M_Dt_Return = Nothing
            Exit Sub
        Else
            Me.Tag = M_Stt_Rec
            Me.M_Dt_Return = DsTmp.Tables(0).Copy
            Me.Save_OK = True
            DsTmp.Dispose()
            Me.Close()
        End If
    End Sub
    Private Sub V_Quay_Ra(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Save_OK = False
        Me.Close()
    End Sub
End Class
