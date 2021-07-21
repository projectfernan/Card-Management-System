Imports ADODB
Public Class frmCharging

    Private Sub frmCharging_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GP.Enabled = False
        lstList.Clear()
        header()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        fill()
        eventList(cboEvent)

    End Sub

    Sub eventList(ByVal cbo As ComboBox)
        Dim rs As New Recordset
        cbo.Items.Clear()

        rs = New Recordset
        rs = Conn.Execute("SELECT * from tblevent")

        While rs.EOF = False
            cbo.Items.Add(rs("EventName").Value)
            rs.MoveNext()
        End While
    End Sub

    Sub header()
        Dim hd As Integer = lstList.Width / 3
        lstList.Columns.Add("CardType", hd, HorizontalAlignment.Left)
        lstList.Columns.Add("Event", hd, HorizontalAlignment.Left)
        lstList.Columns.Add("Key", hd, HorizontalAlignment.Left)
        'lstList.Columns.Add("VAT", 120, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = Conn.Execute("select * from tblCharging")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("CardType").Value, lup)
                viewlst.SubItems.Add(rs("Event").Value)
                viewlst.SubItems.Add(rs("Key").Value)
                'viewlst.SubItems.Add(rs("VAT").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub find()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = Conn.Execute("select * from tblCharging where " & cboCateg.Text & " like '" & txtKeyword.Text & "%'")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("CardType").Value, lup)
                viewlst.SubItems.Add(rs("Event").Value)
                viewlst.SubItems.Add(rs("Key").Value)
                'viewlst.SubItems.Add(rs("VAT").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub Save()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblCharging", Conn, 1, 2)
        rs.AddNew()
        rs("CardType").Value = txtCardtype.Text
        rs("Event").Value = cboEvent.Text
        rs("Key").Value = cboKey.Text
        '   rs("VAT").Value = txtVAT.Text
        rs.Update()

        lstList.Clear()
        header()
        fill()

        cmdEdit.Enabled = True
        cmdDel.Enabled = True
        Clear()
        GP.Enabled = False

        cmdAdd.Text = "&Add"
        MsgBox("Charging rule succeesfully saved!    ", vbInformation, "Save")
    End Sub

    Sub Edit()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblCharging where CardType = '" & txtCardtype.Text & "'", Conn, 1, 2)
        rs("Event").Value = cboEvent.Text
        rs("Key").Value = cboKey.Text
        '   rs("VAT").Value = txtVAT.Text
        rs.Update()

        lstList.Clear()
        header()
        fill()

        Clear()
        txtCardtype.Enabled = True
        cmdAdd.Enabled = True
        cmdDel.Enabled = True
        GP.Text = "Add Charging Rule"
        GP.Enabled = False

        cmdEdit.Text = "&Edit"

        MsgBox("Charging rule succeesfully updated!    ", vbInformation, "Update")
    End Sub

    Sub Clear()
        txtCardtype.Text = vbNullString
        cboEvent.Text = vbNullString
        cboKey.Text = vbNullString
        '  txtAmount.Value = 0
        ' txtVAT.Value = 0
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If cmdAdd.Text = "&Add" Then
            GP.Text = "Add Charging Rule"
            Clear()
            cmdAdd.Text = "&Save"
            cmdEdit.Enabled = False
            cmdDel.Enabled = False
            GP.Enabled = True
        Else
            If MsgBox("Are you sure, your entries are correct?", vbQuestion + vbYesNo + vbDefaultButton2, "Save") = vbYes Then
                If conServer() = False Then
                    MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
                    frmDbSettings.ShowDialog()
                    Exit Sub
                End If
                Save()
            End If
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtCardtype.Text = vbNullString Then Exit Sub

        If cmdEdit.Text = "&Edit" Then
            GP.Text = "Update Charging Rule"
            cmdEdit.Text = "&Update"
            cmdAdd.Enabled = False
            cmdDel.Enabled = False
            GP.Enabled = True
            txtCardtype.Enabled = False
        Else
            If MsgBox("Are you sure do you want to save changes?", vbQuestion + vbYesNo + vbDefaultButton2, "Update") = vbYes Then
                If conServer() = False Then
                    MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
                    frmDbSettings.ShowDialog()
                    Exit Sub
                End If
                Edit()
            End If
        End If
    End Sub

    Private Sub lstList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstList.SelectedIndexChanged
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                txtCardtype.Text = viewlst.SubItems(0).Text
                cboEvent.Text = viewlst.SubItems(1).Text
                cboKey.Text = viewlst.SubItems(2).Text
                ' txtVAT.Text = viewlst.SubItems(3).Text
            End If
        Next
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        cmdEdit.Enabled = True
        cmdDel.Enabled = True
        cmdAdd.Enabled = True

        cmdAdd.Text = "&Add"
        cmdEdit.Text = "&Edit"

        Clear()
        txtCardtype.Enabled = True
        GP.Enabled = False
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        lstList.Clear()
        header()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        fill()
    End Sub

    Private Sub cmdDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDel.Click
        Dim viewlst As New ListViewItem
        For Each viewlst In lstList.Items
            If viewlst.Selected = True Then
                If MsgBox("Are you sure do you want to delete this record?    ", vbYesNo + vbQuestion + vbDefaultButton2, "Delete") = vbYes Then
                    Dim rs As New Recordset
                    rs = New Recordset
                    rs = Conn.Execute("delete from tblCharging where CardType = '" & viewlst.SubItems(0).Text & "'")
                    MsgBox("Record successfully deleted!    ", vbInformation, "Delete")

                    lstList.Clear()
                    header()
                    fill()
                End If
            End If
        Next
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        lstList.Clear()
        header()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        find()
    End Sub

    Private Sub txtKeyword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKeyword.KeyDown
        If e.KeyCode = Keys.Enter Then
            lstList.Clear()
            header()

            If conServer() = False Then
                MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
                frmDbSettings.ShowDialog()
                Exit Sub
            End If

            find()
        End If
    End Sub

    Private Sub cboEvent_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboEvent.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboEvent_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEvent.SelectedIndexChanged

    End Sub
End Class