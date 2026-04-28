Imports System.Windows.Forms
Public Class LOA_Approve
#Region "AddProperty"
    Dim M_Ma_CT As String
    Public Property Ma_CT() As String
        Get
            Ma_CT = M_Ma_CT
        End Get
        Set(ByVal Value As String)
            M_Ma_CT = Value
        End Set
    End Property
    Dim M_Ma_GD As String
    Public Property Ma_GD() As String
        Get
            Ma_GD = M_Ma_GD
        End Get
        Set(ByVal Value As String)
            M_Ma_GD = Value
        End Set
    End Property
    Dim M_Stt_rec As String
    Public Property Stt_rec() As String
        Get
            Stt_rec = M_Stt_rec
        End Get
        Set(ByVal Value As String)
            M_Stt_rec = Value
        End Set
    End Property

    Dim M_Dt_Load As DataTable
    Public Property Dt_Load() As DataTable
        Get
            Dt_Load = M_Dt_Load
        End Get
        Set(ByVal Value As DataTable)
            M_Dt_Load = Value
        End Set
    End Property
#End Region
    Dim DrReturn As DataRow
    Dim DsLookup As DataSet
    Public M_Dt_Return1, M_Dt_Return2 As DataTable
    Private Sub FFF_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False

        V_Load()
        V_AddHandler()
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        CyberSmodb.SetValueTObj(Me, M_Dt_Load.Rows(0))

        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub

    Private Sub V_AddHandler()

        AddHandler ChkAgree.CheckedChanged, AddressOf V_Agree
        AddHandler ChkAgreeCondition.CheckedChanged, AddressOf V_AgreeCondition
        AddHandler ChkDisAgree.CheckedChanged, AddressOf V_DisAgree
        AddHandler ChkReject.CheckedChanged, AddressOf V_Reject

        AddHandler ButtOK.Click, AddressOf V_Nhan

    End Sub

    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim M_strParameterStore As String = ""

        Dim Dstmp1 As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_SysExecute", "SELECT TOP 0 * FROM dbo.CTLOA_Approve WHERE 1=0#" + M_Ma_Dvcs + "#" + M_User_Name)
        Dim DtMaster As DataTable = Dstmp1.Tables(0).Copy
        Dim drMaster As DataRow = DtMaster.NewRow
        CyberSmodb.AddValueToRow(drMaster, Me)
        DtMaster.Rows.Add(drMaster)
        CyberSmodb.SetNotNullTable(DtMaster)
        DtMaster.AcceptChanges()
        '------------
        Dim _Xml As String = CyberSmodb.V_ConvertDataToXML({"CTLOA_Approve"}, {DtMaster})
        Dim _ReplaceDauThang As String = "!~!"
        Dim DsSave As DataSet = CyberSmlib.SQLExcuteStoreProcedure(AppConn, "CP_LOAApproval_ApprovingSave", M_Stt_rec & "#" & M_Ma_CT & "#" & _Xml & "#" & _ReplaceDauThang & "#" & M_Ma_Dvcs & "#" & M_User_Name)
        If Not CyberSupport.V_MsgChk(DsSave.Tables(0), Me.Sysvar, Me.Lan) Then Exit Sub

        If DsSave.Tables.Count >= 2 Then
            M_Dt_Return1 = DsSave.Tables(1)
        End If
        If DsSave.Tables.Count >= 3 Then
            M_Dt_Return2 = DsSave.Tables(2)
        End If
        Me.Save_OK = True

        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub

#Region "Check Box"
    Private Sub V_Agree(ByVal sender As Object, ByVal e As EventArgs)
        If ChkAgree.Checked = True Then
            ChkAgreeCondition.Checked = False
            ChkDisAgree.Checked = False
            ChkReject.Checked = False
        End If
    End Sub

    Private Sub V_AgreeCondition(ByVal sender As Object, ByVal e As EventArgs)
        If ChkAgreeCondition.Checked = True Then
            ChkAgree.Checked = False
            ChkDisAgree.Checked = False
            ChkReject.Checked = False
        End If
    End Sub

    Private Sub V_DisAgree(ByVal sender As Object, ByVal e As EventArgs)
        If ChkDisAgree.Checked = True Then
            ChkAgree.Checked = False
            ChkAgreeCondition.Checked = False
            ChkReject.Checked = False
        End If
    End Sub

    Private Sub V_Reject(ByVal sender As Object, ByVal e As EventArgs)
        If ChkReject.Checked = True Then
            ChkAgree.Checked = False
            ChkAgreeCondition.Checked = False
            ChkDisAgree.Checked = False
        End If
    End Sub
#End Region
End Class
