Imports System.Windows.Forms
Public Class DMPBVAT
    Dim DrReturn As DataRow
    Dim DsLookup As New DataSet
    Dim tbCtPb As New DataTable
    Dim DvCtpb As New DataView
    Dim DvPbH As New DataView
    Dim EditTK, EditMa_KH, EditMa_phi, EditMa_vv, EditMa_hd, EditMa_sp As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_KU, EditMa_TTLN, EditMa_TTCP, EditMa_Bp, EditMa_HS As New Cyber.Fill.CyberColumnGridView
    Dim EditMa_TD1, EditMa_TD2, EditMa_TD3, EditMa_TD4, EditMa_TD5 As New Cyber.Fill.CyberColumnGridView
    Private Sub DMPB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        V_GetChkErro()
        V_Load()
        V_Load_CtPb(Mode, TxtStt_Rec.Text.Trim, M_Ma_Dvcs)
        V_GetColumns()
        V_AddhanderDetail()
        CyberSupport.Translaste(Me, M_LAN, True)
        If Me.Mode = "M" Then
            TxtMa_Dvcs.Text = M_Ma_Dvcs
            TxtStt.Text = 1
        End If
        CyberSmodb.SetListFixLengthEnabled(Me, Me.Tb_Name, Appconn, Me.Mode, M_User_Name, CyberSmlib)
        V_MenuNguonVon(DetailGRV, AddressOf V_ShortAddItem, AddressOf V_ShortDeleteItem)
        CyberSupport.Translaste(Me, M_LAN, True)
        Me.Text = Me.Text + " - Finance"
    End Sub
#Region "Load"
    Protected Overrides Sub V_Load()
        MyBase.V_Load()

        TxtTen_Tk.Text = CyberSmodb.SQLGetvalue(Appconn, "Ten_Tk0", "DmTk0", "(Tk0 = N'" + TxtTK.Text.Trim + "')", CyberSmlib)
        TxtNam.Text = Me.Key_Nam.ToString
    End Sub
    Protected Overrides Sub V_Addhander()
        MyBase.V_Addhander()

        RemoveHandler DetailGRV.KeyDown, AddressOf DetailGRV_KeyDown
        RemoveHandler TxtTK.CyberLeave, AddressOf L_TK
        RemoveHandler TxtTK.CyberValiting, AddressOf V_TK


        AddHandler TxtTK.CyberLeave, AddressOf L_TK
        AddHandler TxtTK.CyberValiting, AddressOf V_TK
        ' Enter dòng cuối
        AddHandler DetailGRV.KeyDown, AddressOf DetailGRV_KeyDown
    End Sub
    Private Sub V_AddhanderDetail()
        EditTK.V_ActiLookUpColumn(AddressOf V_Tk_i, AddressOf L_Tk_i)
        EditMa_KH.V_ActiLookUpColumn(AddressOf V_Ma_Kh, AddressOf L_Ma_Kh)

        EditMa_phi.V_ActiLookUpColumn(AddressOf V_Ma_phi, AddressOf L_Ma_phi)
        EditMa_vv.V_ActiLookUpColumn(AddressOf V_Ma_Vv, AddressOf L_Ma_Vv)
        EditMa_hd.V_ActiLookUpColumn(AddressOf V_Ma_Hd, AddressOf L_Ma_Hd)
        EditMa_sp.V_ActiLookUpColumn(AddressOf V_Ma_Sp, AddressOf L_Ma_Sp)

        EditMa_KU.V_ActiLookUpColumn(AddressOf V_Ma_KU, AddressOf L_Ma_KU)
        EditMa_TTLN.V_ActiLookUpColumn(AddressOf V_Ma_TTLN, AddressOf L_Ma_TTLN)
        EditMa_TTCP.V_ActiLookUpColumn(AddressOf V_Ma_TTCP, AddressOf L_Ma_TTCP)
        EditMa_Bp.V_ActiLookUpColumn(AddressOf V_Ma_Bp, AddressOf L_Ma_Bp)
        EditMa_HS.V_ActiLookUpColumn(AddressOf V_Ma_HS, AddressOf L_Ma_Hs)

        EditMa_TD1.V_ActiLookUpColumn(AddressOf V_Ma_TD1, AddressOf L_Ma_TD1)
        EditMa_TD2.V_ActiLookUpColumn(AddressOf V_Ma_TD2, AddressOf L_Ma_TD2)
        EditMa_TD3.V_ActiLookUpColumn(AddressOf V_Ma_TD3, AddressOf L_Ma_TD3)
        EditMa_TD4.V_ActiLookUpColumn(AddressOf V_Ma_TD4, AddressOf L_Ma_TD4)
        EditMa_TD5.V_ActiLookUpColumn(AddressOf V_Ma_TD5, AddressOf L_Ma_TD5)

    End Sub
    Protected Overrides Sub V_GetValueParameter()
        MyBase.V_GetValueParameter()
    End Sub
    Sub V_Load_CtPb(ByVal M_Mode As String, ByVal Stt_rec As String, ByVal sMa_Dvcs As String)
        Dim DsFilterTsCd As New DataSet
        Stt_rec = Stt_rec.Trim
        sMa_Dvcs = sMa_Dvcs.Trim
        M_Mode = M_Mode.Trim
        DsFilterTsCd = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_FilterCtPbVAT", Stt_rec & "#" & sMa_Dvcs & "#" & M_Mode)
        tbCtPb = DsFilterTsCd.Tables(0)
        DvCtpb = New DataView(tbCtPb)
        DvPbH = New DataView(DsFilterTsCd.Tables(1))
        CyberFill.V_FillVoucher(DetailGRV, M_LAN, DvPbH, DvCtpb, Nothing)
        V_AddNewITem()
    End Sub
    Sub UpdateList()
    End Sub
    Sub V_GetColumns()
        EditTK.GetColumn(DetailGRV, "Tk")
        EditMa_KH.GetColumn(DetailGRV, "Ma_KH")
        EditMa_phi.GetColumn(DetailGRV, "Ma_phi")
        EditMa_vv.GetColumn(DetailGRV, "Ma_vv")
        EditMa_hd.GetColumn(DetailGRV, "Ma_hd")
        EditMa_sp.GetColumn(DetailGRV, "Ma_sp")

        EditMa_TD1.GetColumn(DetailGRV, "Ma_TD1")
        EditMa_TD2.GetColumn(DetailGRV, "Ma_TD2")
        EditMa_TD3.GetColumn(DetailGRV, "Ma_TD3")
        EditMa_TD4.GetColumn(DetailGRV, "Ma_TD4")
        EditMa_TD5.GetColumn(DetailGRV, "Ma_TD5")

        EditMa_Bp.GetColumn(DetailGRV, "Ma_Bp")
        EditMa_HS.GetColumn(DetailGRV, "Ma_HS")
        EditMa_KU.GetColumn(DetailGRV, "Ma_KU")
        EditMa_TTLN.GetColumn(DetailGRV, "Ma_TTLN")
        EditMa_TTCP.GetColumn(DetailGRV, "Ma_TTCP")
    End Sub
    Sub V_AddNewITem()
        If tbCtPb.Rows.Count < 1 Then
            Dim DrCurren As DataRow
            tbCtPb.NewRow()
            DrCurren = tbCtPb.NewRow
            CyberSmodb.SetValueBlankRow(DrCurren)
            DrCurren.Item("Stt_Rec") = TxtStt_Rec.Text.Trim
            tbCtPb.Rows.Add(DrCurren)
            tbCtPb.AcceptChanges()
        End If
    End Sub
#End Region
#Region "Menu Gridview"
    Private Sub V_MenuNguonVon(ByVal Gridview As DevExpress.XtraGrid.Views.Grid.GridView, ByVal evenAdd As EventHandler, ByVal evenDele As EventHandler)
        Dim mnItemsMail = New Windows.Forms.ContextMenu
        Dim mnItemsF4 As New Windows.Forms.MenuItem("Thêm dòng", evenAdd, Windows.Forms.Keys.F4)
        Dim mnItemsF8 As New Windows.Forms.MenuItem("Xóa dòng", evenDele, Windows.Forms.Keys.F8)
        mnItemsMail.MenuItems.Add(mnItemsF4)
        mnItemsMail.MenuItems.Add(mnItemsF8)
        Gridview.GridControl.ContextMenu = mnItemsMail
    End Sub
#End Region
#Region "Valid Master"
#Region "Vali --- Ma_loai"
    Private Sub V_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TxtTK.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "TK0", "DmTK0", "1=1", "1=1")
    End Sub
    Private Sub L_TK(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DrReturn = TxtTK.GetRowsSelectData(True)
        If Not DrReturn Is Nothing Then
            TxtTK.Text = DrReturn.Item("TK0")
            TxtTen_Tk.Text = DrReturn.Item("Ten_TK0")
        Else
            TxtTK.Text = ""
            TxtTen_Tk.Text = ""
        End If
    End Sub
#End Region
#End Region
#Region "Leaver Detail"
    Private Sub V_Tk_i(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "tk0", "Dmtk0", "1=1", "1=1")
    End Sub
    Private Sub L_Tk_i(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("TK") = ""
            Exit Sub
        End If
        drvCurren("TK") = DrReturn("tk0")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_Kh(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Kh", "DmKh", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Kh(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Kh") = ""
            Exit Sub
        End If
        drvCurren("Ma_Kh") = DrReturn("Ma_Kh")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_phi(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Phi", "Dmphi", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_phi(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Phi") = ""
            Exit Sub
        End If
        drvCurren("Ma_Phi") = DrReturn("Ma_Phi")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_Vv(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Vv", "DmVv", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Vv(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Vv") = ""
            Exit Sub
        End If
        drvCurren("Ma_Vv") = DrReturn("Ma_Vv")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_Hd(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Hd", "DmHd", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hd(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Hd") = ""
            Exit Sub
        End If
        drvCurren("Ma_Hd") = DrReturn("Ma_Hd")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_Sp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Sp", "DmSp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Sp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Sp") = ""
            Exit Sub
        End If
        drvCurren("Ma_Sp") = DrReturn("Ma_Sp")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_TD1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD1", "DmTD1", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD1") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD1") = DrReturn("Ma_TD1")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_TD2(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD2", "DmTD2", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD2(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD2") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD2") = DrReturn("Ma_TD2")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_TD3(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD3", "DmTD3", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD3(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD3") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD3") = DrReturn("Ma_TD3")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_TD4(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD4", "DmTD4", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD4(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD4") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD4") = DrReturn("Ma_TD4")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_TD5(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TD5", "DmTD5", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TD5(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TD5") = ""
            Exit Sub
        End If
        drvCurren("Ma_TD5") = DrReturn("Ma_TD5")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_Bp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Bp", "DmBp", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Bp(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Bp") = ""
            Exit Sub
        End If
        drvCurren("Ma_Bp") = DrReturn("Ma_Bp")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_HS(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_Hs", "DmHs", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_Hs(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_Hs") = ""
            Exit Sub
        End If
        drvCurren("Ma_Hs") = DrReturn("Ma_Hs")
        DetailGRV.UpdateCurrentRow()
    End Sub
    Private Sub V_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTLN", "DmTTLN", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTLN(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TTLN") = ""
            Exit Sub
        End If
        drvCurren("Ma_TTLN") = DrReturn("Ma_TTLN")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_TTCP", "DmTTCP", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_TTCP(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_TTCP") = ""
            Exit Sub
        End If
        drvCurren("Ma_TTCP") = DrReturn("Ma_TTCP")
        DetailGRV.UpdateCurrentRow()
    End Sub

    Private Sub V_Ma_KU(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        sender.V_LookUp(M_LAN, M_Para, oSysvar, Appconn, DsLookup, "Ma_KU", "DmKU", "1=1", "1=1")
    End Sub
    Private Sub L_Ma_KU(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim drvCurren As DataRowView
        drvCurren = DetailGRV.GetFocusedRow
        If drvCurren Is Nothing Then Exit Sub
        Dim DrReturn As DataRow = sender.GetRowsSelectData(True)
        If DrReturn Is Nothing Then
            drvCurren("Ma_KU") = ""
            Exit Sub
        End If
        drvCurren("Ma_KU") = DrReturn("Ma_KU")
        DetailGRV.UpdateCurrentRow()
    End Sub
#End Region
#Region "Buuton"
    Protected Overrides Sub V_Save(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not ChkEmpty(TxtTK) Then
            Exit Sub
        End If
        If Not ChkEmpty(TxtTen_BT) Then
            Exit Sub
        End If
        If Not ChkEmpty(TxtStt) Then
            Exit Sub
        End If
        If Mode.Trim = "M" Or TxtStt_Rec.Text.Trim = "" Then
            ' Tao Stt_rec
            Dim dstmpPB As New DataSet
            TxtMa_Dvcs.Text = M_Ma_Dvcs.Trim
            TxtNam.Text = Me.Key_Nam.ToString
            dstmpPB = CyberSmlib.SQLExcuteStoreProcedure(Appconn, "CP_GetStt_RecDMPBVAT", Me.Key_Nam.ToString.Trim + "#" + M_Ma_Dvcs.Trim)
            TxtStt_Rec.Text = dstmpPB.Tables(0).Rows(0).Item(0)
            dstmpPB.Dispose()
        End If
        CyberSmodb.AddValueToRow(Me.DrNew, Me)
        Updatetable2(Mode)
        If Not CyberSmlistSys.SaveToSQLOfList(Appconn, oSysvar, Me, CyberSmodb, CyberSmlib, CyberSupport) Then Exit Sub
        CyberSmodb.V_SaveToSQL(Appconn, oSysvar, M_User_Name, tbCtPb, "DMPB1VAT", Mode, " Stt_rec =N'" + TxtStt_Rec.Text.Trim + "'")
        MyBase.V_Save(sender, e) '// khong xoa doan nay
    End Sub
    Sub Updatetable2(ByVal M_Mode As String)
        Dim iRow As Integer
        For iRow = tbCtPb.Rows.Count - 1 To 0 Step -1
            If tbCtPb.Rows(iRow).Item("TK").ToString.Trim = "" Then
                tbCtPb.Rows.RemoveAt(iRow)
                tbCtPb.AcceptChanges()
            End If
        Next
        For iRow = 0 To tbCtPb.Rows.Count - 1
            tbCtPb.Rows(iRow).BeginEdit()
            tbCtPb.Rows(iRow).Item("Stt_Rec") = TxtStt_Rec.Text.Trim
            tbCtPb.Rows(iRow).Item("Stt_Rec0") = Strings.Right("000" + (iRow + 1).ToString.Trim, 3) '--- Bat buoc phai co dong nay
            tbCtPb.Rows(iRow).EndEdit()
        Next
        tbCtPb.AcceptChanges()
    End Sub
#End Region
#Region "Add/Delete Gridview"
    Sub V_ShortAddItem(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        V_AddItem(iRow)
    End Sub
    Private Sub V_AddItem(Optional ByVal iRow As Integer = -1)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim DrvOld As DataRowView
        If iRow >= 0 Then DrvOld = DvCtpb.Item(iRow) Else DrvOld = Nothing
        DvCtpb.Table.Rows.Add()
        DvCtpb.Table.AcceptChanges()
        CyberSmodb.SetValueBlankRow(DvCtpb.Table.Rows(DvCtpb.Table.Rows.Count - 1))
        CyberSupport.SetCarryOn(DrvOld, DvCtpb.Table.Rows(DvCtpb.Table.Rows.Count - 1), DvPbH)
        CarrOnNguonVon(DvCtpb.Table.Rows(DvCtpb.Table.Rows.Count - 1))
        UpdateList()
        iRow = DvCtpb.Count - 1
        CyberFill.V_ForcusCell(DetailGRV, iRow, 0)
    End Sub
    Private Sub V_ShortDeleteItem(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim iRow As Integer = DetailGRV.FocusedRowHandle
        If iRow < 0 Then Exit Sub
        If Not CyberSupport.V_DeleteItemVoucher(oSysvar, M_LAN, "", iRow, DvCtpb, Appconn) Then Exit Sub
        DvCtpb.Delete(iRow)
        DvCtpb.Table.AcceptChanges()
        UpdateList()
    End Sub
    Private Sub CarrOnNguonVon(ByVal DvNew As DataRow)
        DvNew.Item("Stt_Rec") = TxtStt_Rec.Text.Trim
        'DvNew.Item("Ma_Ct") = M_Ma_CT.Trim
        'DvNew.Item("Ngay_tang") = Now.Date
        'DvNew.Item("Ngay_Kh") = Now.Date
    End Sub
#End Region
#Region "Enter Dong cuoi"
    Private Sub DetailGRV_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If Not (Mode = "M" Or Mode = "S") Then Exit Sub
        Dim Grid As New DevExpress.XtraGrid.Views.Grid.GridView
        Grid = sender
        Dim iCoumnVisible As Integer = Grid.VisibleColumns.Count - 1
        Dim iRowVisible As Integer = Grid.RowCount - 1
        Dim iRowRowFocus As Integer = Grid.FocusedRowHandle
        Dim iColumnRowFocus As Integer = Grid.VisibleColumns.IndexOf(Grid.FocusedColumn)
        Dim iRowOld As Integer = Grid.GetFocusedDataSourceRowIndex
        If iRowVisible <> iRowRowFocus Or iCoumnVisible <> iColumnRowFocus Then Exit Sub
        If e.KeyCode = Keys.Enter Then
            V_AddItem(iRowOld) '' Cot cuoi cung them dong
        ElseIf e.KeyCode = Keys.End Then
            SendKeys.Send("^{Tab}")
        End If
    End Sub
#End Region
End Class