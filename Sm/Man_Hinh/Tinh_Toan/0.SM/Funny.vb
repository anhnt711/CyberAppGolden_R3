Public Class Funny

    Dim DrReturn As DataRow
    Dim dstmp, DsLookup As DataSet
    Dim tbtmp, DtThang1, DtThang2, DtNam As DataTable
    Dim Index As Integer = 0
    Private Sub Funny_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Save_OK = False
        V_Load()
        AddHandler ButtOK.Click, AddressOf V_Nhan
        CyberSupport.Translaste(Me, M_LAN, True)
    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
        '----------------------------
    End Sub
    Private Sub V_Load()
        tbtmp = CyberSmodb.OpenTable(AppConn, dstmp, "Funny", "", CyberSmlib)

        Dim SelectRow As Random = New Random()

        Dim row As DataRow = SelectRandomRow(tbtmp, SelectRow)

        Me.Txtnoi_Dung.Text = row.Item("Noi_Dung")
        Me.Txtten_Truyen.Text = row.Item("Ten_truyen").ToString.Trim
        For i As Integer = 0 To tbtmp.Rows.Count - 1
            If (tbtmp.Rows(i).Item("Ten_truyen") = row.Item("Ten_truyen")) Then
                Index = i
            End If
        Next

    End Sub
    Private Function SelectRandomRow(ByVal dataTable As DataTable, ByVal RandomSelector As Random) As DataRow
        Return dataTable.Rows(RandomSelector.Next(dataTable.Rows.Count - 1))
    End Function
    Private Sub CmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNext.Click
        Next_click()
    End Sub
    Private Sub Next_click()
        If (Index < tbtmp.Rows.Count - 1) Then
            Index = Index + 1
            Me.Txtnoi_Dung.Text = tbtmp.Rows(Index).Item("Noi_Dung")
            Me.Txtten_Truyen.Text = tbtmp.Rows(Index).Item("Ten_truyen").ToString.Trim
            Exit Sub
        End If
        If Index = tbtmp.Rows.Count - 1 Then
            Index = 0
            Me.Txtnoi_Dung.Text = tbtmp.Rows(Index).Item("Noi_Dung")
            Me.Txtten_Truyen.Text = tbtmp.Rows(Index).Item("Ten_truyen").ToString.Trim
            Exit Sub
        End If

    End Sub
    Private Sub CmdPrev_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrev.Click
        If (Index > 0) Then
            Index = Index - 1
            Me.Txtnoi_Dung.Text = tbtmp.Rows(Index).Item("Noi_Dung")
            Me.Txtten_Truyen.Text = tbtmp.Rows(Index).Item("Ten_truyen").ToString.Trim
            Exit Sub
        End If
        If (Index = 0) Then
            Index = tbtmp.Rows.Count - 1
            Me.Txtnoi_Dung.Text = tbtmp.Rows(Index).Item("Noi_Dung")
            Me.Txtten_Truyen.Text = tbtmp.Rows(Index).Item("Ten_truyen").ToString.Trim
            Exit Sub
        End If
    End Sub
    Private Sub V_Nhan(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Save_OK = True
        Me.Save_OK = False
        Dim M_strParameterStore As String = ""
        Me.Tag = M_strParameterStore
        CyberSmlib.FlushMemorySave()

        Me.Close()
    End Sub
End Class
