Imports ADODB
Public Class frmAccounts

    Private Sub frmAccounts_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        GP.Enabled = False
        lstList.Clear()
        header()

        If conServer() = False Then
            MsgBox("Please connect to database!    ", vbExclamation, "Database Conccetion")
            frmDbSettings.ShowDialog()
            Exit Sub
        End If

        fill()

    End Sub

    Sub header()
        lstList.Columns.Add("Username", 180, HorizontalAlignment.Left)
        lstList.Columns.Add("Name", 250, HorizontalAlignment.Left)
        lstList.Columns.Add("Designation", 150, HorizontalAlignment.Left)
        lstList.Columns.Add("", 0, HorizontalAlignment.Left)
    End Sub

    Sub fill()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = Conn.Execute("select * from tbluseracc")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Username").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Designation").Value)
                viewlst.SubItems.Add(rs("Password").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub find()
        On Error Resume Next
        Dim rs As New Recordset
        Dim lup As Short
        rs = New Recordset
        rs = Conn.Execute("select * from tbluseracc where " & cboCateg.Text & " like '" & txtKeyword.Text & "%'")
        txtCnt.Text = rs.RecordCount
        If rs.EOF = False Then
            For lup = 1 To rs.RecordCount
                lstList.Refresh()
                Dim viewlst As New ListViewItem
                viewlst = lstList.Items.Add(rs("Username").Value, lup)
                viewlst.SubItems.Add(rs("Name").Value)
                viewlst.SubItems.Add(rs("Designation").Value)
                viewlst.SubItems.Add(rs("Password").Value)
                rs.MoveNext()
            Next
        End If
    End Sub

    Sub Save()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tbluseracc", Conn, 1, 2)
        rs.AddNew()
        rs("Username").Value = txtUser.Text
        rs("Password").Value = txtPass.Text
        rs("Name").Value = txtName.Text
        rs("Designation").Value = cboDesig.Text
        rs.Update()

        lstList.Clear()
        header()
        fill()

        cmdEdit.Enabled = True
        cmdDel.Enabled = True
        Clear()
        GP.Enabled = False

        cmdAdd.Text = "&Add"
        MsgBox("New Account succeesfully saved!    ", vbInformation, "Save")
    End Sub

    Sub Edit()
        Dim rs As New Recordset
        rs = New Recordset
        rs.Open("select * from tbluseracc where Username = '" & txtUser.Text & "'", Conn, 1, 2)
        rs("Password").Value = txtPass.Text
        rs("Name").Value = txtName.Text
        rs("Designation").Value = cboDesig.Text
        rs.Update()

        lstList.Clear()
        header()
        fill()

        Clear()
        txtUser.Enabled = True
        cmdAdd.Enabled = True
        cmdDel.Enabled = True
        GP.Text = "Add New Account"
        GP.Enabled = False

        cmdEdit.Text = "&Edit"

        MsgBox("Account succeesfully updated!    ", vbInformation, "Update")
    End Sub

    Sub Clear()
        txtUser.Text = vbNullString
        txtPass.Text = vbNullString
        txtConfirm.Text = vbNullString
        txtName.Text = vbNullString
        cboDesig.Text = vbNullString
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If cmdAdd.Text = "&Add" Then
            GP.Text = "Add New Account"
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
        If txtUser.Text = vbNullString Then Exit Sub

        If cmdEdit.Text = "&Edit" Then
            GP.Text = "Update Account"
            cmdEdit.Text = "&Update"
            cmdAdd.Enabled = False
            cmdDel.Enabled = False
            GP.Enabled = True
            txtUser.Enabled = False
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
                txtUser.Text = viewlst.SubItems(0).Text
                txtName.Text = viewlst.SubItems(1).Text
                cboDesig.Text = viewlst.SubItems(2).Text
                txtPass.Text = viewlst.SubItems(3).Text
                txtConfirm.Text = viewlst.SubItems(3).Text
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
        txtUser.Enabled = True
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
                    rs = Conn.Execute("delete from tbluseracc where Username = '" & viewlst.SubItems(0).Text & "'")
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

    Private Sub cboDesig_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboDesig.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub

    Private Sub cboCateg_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboCateg.KeyPress
        If Asc(e.KeyChar) > 0 Then
            e.KeyChar = vbNullString
        End If
    End Sub
End Class