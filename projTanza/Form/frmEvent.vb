Imports ADODB
Public Class frmEvent

    Private Sub frmEvent_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Restore_Bcode(txtBcodeCount.Value)
    End Sub

    Private Sub frmEvent_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GP.Enabled = False
        lstList.Clear()
        header()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Connection")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        fill()
        txtBcodeCount.Value = Ticket_Bcode_No()
    End Sub

    Sub header()
        lstList.Columns.Add("Event", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("EventDate", 200, HorizontalAlignment.Left)
        lstList.Columns.Add("EventStart", 120, HorizontalAlignment.Left)
        lstList.Columns.Add("EventEnd", 120, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = Conn.Execute("select * from tblevent")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("EventName").Value, lup)
                viewlst.SubItems.Add(rs("EventDate").Value)
                viewlst.SubItems.Add(Format(rs("EventStart").Value, "HH:mm:ss"))
                viewlst.SubItems.Add(Format(rs("EventEnd").Value, "HH:mm:ss"))
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub find()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = Conn.Execute("select * from tblevent where EventName like '" & txtKeyword.Text & "%'")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("EventName").Value, lup)
                viewlst.SubItems.Add(rs("EventDate").Value)
                viewlst.SubItems.Add(Format(rs("EventStart").Value, "HH:mm:ss"))
                viewlst.SubItems.Add(Format(rs("EventEnd").Value, "HH:mm:ss"))
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub Save()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblevent", Conn, 1, 2)
        rs.AddNew()
        rs("EventName").Value = txtEvent.Text
        rs("EventDate").Value = dtDate.Value
        rs("EventStart").Value = dtTimeStart.Text
        rs("EventEnd").Value = dtTimeEnd.Text
        rs.Update()

        lstList.Clear()
        header()
        fill()

        cmdEdit.Enabled = True
        cmdDel.Enabled = True
        Clear()
        GP.Enabled = False
        frmMain.ViewEvent()

        cmdAdd.Text = "&Add"
        MsgBox("New Event successfully saved!    ", vbInformation, "Save")
    End Sub

    Sub Edit()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tblevent where EventName = '" & txtEvent.Text & "'", Conn, 1, 2)
        rs("EventDate").Value = dtDate.Value
        rs("EventStart").Value = dtTimeStart.Text
        rs("EventEnd").Value = dtTimeEnd.Text
        rs.Update()

        lstList.Clear()
        header()
        fill()

        frmMain.ViewEvent()
        Clear()
        txtEvent.Enabled = True
        cmdAdd.Enabled = True
        cmdDel.Enabled = True
        GP.Text = "Add New Event"
        GP.Enabled = False
        frmMain.ViewEvent()

        cmdEdit.Text = "&Edit"
        MsgBox("Event successfully updated!    ", vbInformation, "Update")
    End Sub

    Sub Clear()
        txtEvent.Text = vbNullString
    End Sub


    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If cmdAdd.Text = "&Add" Then
            GP.Text = "Add New Event"
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
        If txtEvent.Text = vbNullString Then Exit Sub

        If cmdEdit.Text = "&Edit" Then
            GP.Text = "Update Event"
            cmdEdit.Text = "&Update"
            cmdAdd.Enabled = False
            cmdDel.Enabled = False
            GP.Enabled = True
            txtEvent.Enabled = False
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
                On Error Resume Next
                txtEvent.Text = viewlst.SubItems(0).Text
                dtDate.Value = viewlst.SubItems(1).Text
                dtTimeStart.Text = viewlst.SubItems(2).Text
                dtTimeEnd.Text = viewlst.SubItems(3).Text
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
        txtEvent.Enabled = True
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
                    rs = Conn.Execute("delete from tblevent where EventName = '" & viewlst.SubItems(0).Text & "'")
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
End Class