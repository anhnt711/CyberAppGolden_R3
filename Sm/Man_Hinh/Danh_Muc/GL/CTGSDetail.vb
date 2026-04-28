Imports System.Drawing
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class CTGSDetail
#Region "Get or Set Property----------------------"
    Public Property Lan() As String
        Get
            Lan = M_lan
        End Get
        Set(ByVal Value As String)
            M_lan = Value
        End Set
    End Property
    Public Property AppConn() As SqlConnection
        Get
            Return M_AppConn
        End Get
        Set(ByVal value As SqlConnection)
            M_AppConn = value
        End Set
    End Property
    Public Property SysVar() As Collection
        Get
            Return oSysvar
        End Get
        Set(ByVal value As Collection)
            oSysvar = value
        End Set
    End Property

    Public Property Para() As String()
        Get
            Return M_Para
        End Get
        Set(ByVal value As String())
            M_Para = value
        End Set
    End Property
    Public Property Is_Ok() As Boolean
        Get
            Is_Ok = M_Is_Ok
        End Get
        Set(ByVal Value As Boolean)
            M_Is_Ok = Value
        End Set
    End Property
    Public Property DsData() As DataSet
        Get
            DsData = M_DsData
        End Get
        Set(ByVal Value As DataSet)
            M_DsData = Value
        End Set
    End Property
    Public Property Dt_Return() As DataTable
        Get
            Return M_Dt_Return
        End Get
        Set(ByVal value As DataTable)
            M_Dt_Return = value
        End Set
    End Property

#End Region
#Region "Khai bao bien----------------------"
    Dim M_AppConn As SqlConnection
    Dim M_lan As String = "V"
    Dim oSysvar As Collection
    Dim M_Para As String()
    Dim M_Is_Ok As Boolean
    Dim M_DsData As DataSet
    Dim Dt_Master As DataTable
    Dim tb1H As DataTable
    Dim Dv_Master As DataView
    Dim M_Dt_Return As DataTable


    Dim CyberFill As New Cyber.Fill.Sys
    Dim CyberColor As New Cyber.Color.Sys
#End Region
    Private Sub CTGSDetail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Is_Ok = False
        V_Load()
        MasterGRV_PopupMenuShowing(MasterGRV, Nothing)
        V_Addhander()
    End Sub
    Private Sub V_Load()
        Dt_Master = DsData.Tables(0)
        tb1H = DsData.Tables(1)
        Dv_Master = New DataView(Dt_Master)
        Master.DataSource = Dv_Master
        Me.MasterGRV.GridControl = Me.Master

        CyberFill.V_FillReports(MasterGRV, M_lan, New DataView(tb1H), Dv_Master)

    End Sub
    Public Sub V_Addhander()
        RemoveHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        RemoveHandler CmdOk.Click, AddressOf V_NHan
        RemoveHandler CmdExit.Click, AddressOf V_QuayRa
        RemoveHandler CmdSelectAll.Click, AddressOf V_SelectAll
        RemoveHandler CmdRemoveAll.Click, AddressOf V_RemoveAll
        AddHandler MasterGRV.RowCellStyle, AddressOf MasterGRV_RowCellStyle
        AddHandler CmdOk.Click, AddressOf V_NHan
        AddHandler CmdExit.Click, AddressOf V_QuayRa
        AddHandler CmdSelectAll.Click, AddressOf V_SelectAll
        AddHandler CmdRemoveAll.Click, AddressOf V_RemoveAll
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Is_Ok = True
        Me.Dt_Return = Dt_Master.Copy
        Me.Close()
    End Sub
    Private Sub V_QuayRa(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub V_SelectAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Type As Boolean = False
        If Dt_Master.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True
        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            Dv_Master.Item(i).Item("Tag") = If(_Type, True, "1")
            Dv_Master.Item(i).EndEdit()
        Next
    End Sub
    Private Sub V_RemoveAll(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim _Type As Boolean = False
        If Dt_Master.Columns("Tag").DataType.Name.ToString.Trim.ToUpper = "Boolean".Trim.ToUpper Then _Type = True
        For i As Integer = 0 To Dv_Master.Count - 1
            Dv_Master.Item(i).BeginEdit()
            Dv_Master.Item(i).Item("Tag") = If(_Type, False, "0")

            Dv_Master.Item(i).EndEdit()
        Next
    End Sub
    Private Sub MasterGRV_PopupMenuShowing(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
        Dim rowHandle As Integer
        If e Is Nothing Then
            rowHandle = -1
        Else
            rowHandle = e.HitInfo.RowHandle
        End If
        PopupMenuMasterGrid.ItemLinks.Clear()
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Đánh dấu", "Select All"), AddressOf V_SelectAll, Shortcut.CtrlA, My.Resources.highlightactiveelements_16x16, True, True)).BeginGroup = True
        PopupMenuMasterGrid.ItemLinks.Add(New Cyber.SmLib.CyberMenuPopup(sender, rowHandle, IIf(Lan = "V", "Hũy đánh dấu ", "Remove All"), AddressOf V_RemoveAll, Shortcut.CtrlU, My.Resources.removeitem_16x16, True, True)).BeginGroup = False
        If Not e Is Nothing Then PopupMenuMasterGrid.ShowPopup(Control.MousePosition)
        'End If
    End Sub
    Dim _i As Integer = 1
    Private Sub MasterGRV_RowCellStyle(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs)
        If Dt_Master.Columns.Contains("Bold") Then
            Dim _FieldBold As String = ""
            _FieldBold = Dt_Master.Columns("Bold").ColumnName
            Dim _categoryBold As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldBold).ToString.Trim
            If _categoryBold = "1" Then e.Appearance.Font = New Font(Me.Font.FontFamily, Me.Font.Size, FontStyle.Bold)
        End If
        _i = _i + 1
        If Not sender.IsCellSelected(e.RowHandle, e.Column) Then
            If Dt_Master.Columns.Contains("Tag") Then
                Dim _FieldTag As String = ""
                _FieldTag = Dt_Master.Columns("tag").ColumnName

                Dim _categoryTag As String = MasterGRV.GetRowCellDisplayText(e.RowHandle, _FieldTag).ToString.Trim.ToUpper
                'If _i = 20 Then MsgBox(_categoryTag.ToString + " ---- " + _FieldTag)
                Dim _categoryBackColor As String = ""
                If _categoryTag = "TRUE".Trim.ToUpper Or _categoryTag = "1".Trim.ToUpper Or _categoryTag = "CHECKED".Trim.ToUpper Then _categoryBackColor = "YELLOW"
                e.Appearance.BackColor = CyberColor.GetBacColorkReports(_categoryBackColor)
            End If

        Else
            e.Appearance.BackColor = System.Drawing.Color.Silver
        End If
    End Sub
End Class